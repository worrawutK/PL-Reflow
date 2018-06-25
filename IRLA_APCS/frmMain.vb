Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Rohm.Apcs.Tdc
Imports System.Runtime.Serialization.Formatters.Soap
Imports iLibrary
Imports Rohm.Common.Logging
Imports WindowsApplication1.ServiceReference1
Imports System.Xml.Serialization

Public Class frmMain
    Private m_TdcService As TdcService
    Dim DataSendTDC As String
    Dim SoftwareRevision As String = "Reflow SelfCon ver.161109"
    Dim buffer As String
    Dim frmSeachData As frmSearch
    Dim m_Locker As New Object
    Private m_LotSetQueue As Queue(Of String) = New Queue(Of String)
    Private m_LotEndQueue As Queue(Of String) = New Queue(Of String)
    Private m_LotReqQueue As Queue(Of String) = New Queue(Of String)
    Dim c_dlg As TdcAlarmMessageForm
    'Private m_LotReqMesQueue As Queue(Of String) = New Queue(Of String)

    'Sub SaveTDCConfig()
    '    Using sw As StreamWriter = New StreamWriter(Path.Combine(My.Application.Info.DirectoryPath, "Config.txt"), False)
    '        Dim TDCConfig As String
    '        TDCConfig = "01 not found = " & m_01 & vbCrLf
    '        TDCConfig &= "02 running = " & m_02 & vbCrLf
    '        TDCConfig &= "03 not run= " & m_03 & vbCrLf
    '        TDCConfig &= "04 machine not found = " & m_04 & vbCrLf
    '        TDCConfig &= "05 error lot status= " & m_05 & vbCrLf
    '        TDCConfig &= "06 error process = " & m_06 & vbCrLf
    '        TDCConfig &= "70 error connect database = " & m_70 & vbCrLf
    '        TDCConfig &= "71 error read data base = " & m_71 & vbCrLf
    '        TDCConfig &= "72 error write data base = " & m_72 & vbCrLf
    '        TDCConfig &= "99 other = " & m_99 & vbCrLf
    '        TDCConfig &= "Run Off Line= " & m_Offline
    '        sw.WriteLine(TDCConfig)
    '    End Using
    'End Sub

    Sub LoadTDCConfig()
        If m_SelfData.CellConState <> 0 Then
            lbStatusMC.Text = "Run Offline"
            lbStatusMC.BackColor = Color.Red
        Else
            lbStatusMC.Text = "Online"
            lbStatusMC.BackColor = Color.Lime
        End If





        'Using sr As StreamReader = New StreamReader(Path.Combine(My.Application.Info.DirectoryPath, "Config.txt"))
        '    Dim strData As String = sr.ReadToEnd()
        '    Dim strTmp As String() = strData.Split(CChar(vbCrLf))
        '    Dim SplitDat As String()
        '    For Each DataString As String In strTmp
        '        If DataString.Contains("01") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_01 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("02") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_02 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("03") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_03 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("04") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_04 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("05") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_05 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("06") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_06 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("70") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_70 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("71") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_71 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("72") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_72 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("99") Then
        '            SplitDat = DataString.Split(CChar("="))
        '            m_99 = CBool(SplitDat(1).Trim)
        '        ElseIf DataString.Contains("Run Offline") Then
        '            SplitDat = DataString.Split(CChar("="))

        '            If SplitDat(1).Trim <> "Online" Then
        '                m_Offline = _SelfConMode.Offline
        '                lbStatusMC.Text = "Run Offline"
        '                lbStatusMC.BackColor = Color.Red
        '            Else
        '                m_Offline = _SelfConMode.Online
        '                lbStatusMC.Text = "Online"
        '                lbStatusMC.BackColor = Color.Lime
        '            End If

        '        End If
        '    Next
        'End Using
    End Sub

#Region "========================== Windows Form Designer generated code ==============================="

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bgTDC.IsBusy = True Or bgTDCLotReq.IsBusy = True Then
            MsgBox("ไม่สามารถติดโปรแกรมได้ โปรแกรมกำลังประมวลผลอยู่")
            e.Cancel = True
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbNetversion.Text = "180612 APCS Pro." '"170109"
        m_TdcService = TdcService.GetInstance()
        m_TdcService.ConnectionString = My.Settings.APCSDBConnectionString

        LoadPFAlarmTable()
        LoadAlarmInfoXml()
        LoadReflowDataTableXml()
        LoadBackup()
        LoadTDCConfig()

        InitialNetworkComponent()
        Me.StartSocketThread()

        radNormalEnd.Checked = True

        m_SelfData.McNo = My.Settings.MCNo
        m_SelfData.IPA = My.Settings.IP
        UpdateDisplay()

        XmlLoad(c_ApcsPro, c_ApcsPro.GetType())
    End Sub
    Sub LoadPFAlarmTable()
        Dim pathReflowTable As String = Path.Combine(My.Application.Info.DirectoryPath, "ReflowAlarmTable.xml")
        If My.Computer.Network.Ping("172.16.0.102") Then
            ReflowAlarmTableTableAdapter.Fill(DBxDataSet.ReflowAlarmTable)
            SaveAlarmTableXML()
        Else
            LoadAlarmTableXml()
        End If
    End Sub
    Private Sub MinimizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub addlogfile(ByVal m As String)
        Dim logfile As String = My.Application.Info.DirectoryPath & "\Log\Errlog.log"
        Using outfile As IO.StreamWriter = New StreamWriter(logfile, True)
            outfile.WriteLine(Format(Now, "yyyy/MM/dd HH:mm:ss") & " : " & m)
        End Using

        'Using sr As StreamReader = File.OpenText(logfile)
        '    If sr.BaseStream.Length > 900000 Then
        '        sr.Close()
        '        File.Delete(logfile)
        '    End If
        'End Using
    End Sub

    Private Sub CommunicatedLog(ByVal strData As String)
        Dim PathComLog As String = Path.Combine(My.Application.Info.DirectoryPath, "Log\DataLog1.log")
        Dim PathComlogMove As String = Path.Combine(My.Application.Info.DirectoryPath, "Log\DataLog2.log")
        Dim tmpTime As String = Format(Now, "yyyy/MM/dd HH:mm:ss")
        Using sw As StreamWriter = New StreamWriter(PathComLog, True)
            sw.WriteLine(tmpTime & " " & strData)
        End Using
        Dim CountData As Integer
        Using sr As StreamReader = New StreamReader(PathComLog)
            CountData = CInt(sr.ReadToEnd.Length)
        End Using
        If CountData > 5000000 Then
            File.Copy(PathComLog, PathComlogMove, True)
            File.Delete(PathComLog)
        End If
    End Sub


    Private Delegate Sub CommunicateLogDisplayDelegate(ByVal strData As String, ByVal mcNo As String)
    Private Sub CommunicateLogDisplay(ByVal strData As String, ByVal mcNo As String)
        If Me.InvokeRequired Then
            Me.Invoke(New CommunicateLogDisplayDelegate(AddressOf CommunicateLogDisplay), strData, mcNo)
            Exit Sub
        End If

        Dim tmpTime As String = Format(Now, "yyyy/MM/dd HH:mm:ss")
        If ComLog.Text.Length = 25000 Then ComLog.Text = ""
        If cbSDGood.Checked = True And strData.Contains("SD,") = True Then Exit Sub
        If strData.Contains("LP") = True Then
            strData = " Send :" & strData
        Else
            strData = " Rev :" & strData
        End If
        CommLog.AppendText(tmpTime & " " & mcNo & " " & strData & vbCrLf)
        CommunicatedLog(mcNo & strData)
    End Sub
#End Region

#Region "======================================= Networking ============================================"

    Private udpSck As UDPSocket
    Private bgWorker1 As BackgroundWorker
    Private continues As Boolean
    Private strRecv As String

    Private Sub InitialNetworkComponent()
        Me.bgWorker1 = New BackgroundWorker
        AddHandler Me.bgWorker1.DoWork, AddressOf Me.bgWorker1_DoWork
        AddHandler Me.bgWorker1.RunWorkerCompleted, AddressOf Me.bgWorker1_RunWorkerComplete
        Me.udpSck = New UDPSocket
        Me.udpSck.LocalPort = 5720
        Me.udpSck.RemotePort = 5720
    End Sub

    Private Sub bgWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        e.Result = Me.udpSck.GetUDPMessage()
    End Sub

    Private Sub bgWorker1_RunWorkerComplete(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)

        Dim UDPreceive As String = ""
        If Me.continues Then
            Me.StartSocketThread()
        End If

        Dim data() As String
        'socket result is <IPAddresss>|<Message>
        data = e.Result.ToString.Split(CChar("|"))

        If data.Length = 2 Then
            GetDataFromIPAddress(data(0), data(1))
        End If
    End Sub

    Private Sub StartSocketThread()

        If Not Me.udpSck.IsListening Then
            Me.udpSck.StartListening()
        End If
        Me.continues = True
        Me.bgWorker1.RunWorkerAsync()
    End Sub

    Private Sub StopSocketThread()

        Me.continues = False
        Me.udpSck.Send(Chr(13))  'send some charactor to stop BackgroundWorker Blocking Call
        Me.udpSck.StopListening()
    End Sub

    Public Sub SendTheMessage(ByVal host As String, ByVal sendMsg As String, ByVal MCNo As String)
        If sendMsg <> "" Then
            'send to network
            Me.udpSck.RemoteHost = host
            Me.udpSck.Send(sendMsg)
            'show in list
            Dim strData As String = sendMsg.Replace(vbCr, "")
            CommunicateLogDisplay(strData, MCNo)
        End If
    End Sub

#End Region

#Region "======================================= Data Secon ============================================"

    Private Sub GetDataFromIPAddress(ByVal ip As String, ByVal data As String)

        m_SelfData.LotData &= data
        If m_SelfData.LotData.Contains(vbCr) = True Then

            Dim posVbCr As Integer = m_SelfData.LotData.LastIndexOf(vbCr) 'หาตำแหน่งสุดท้าย
            Dim BuffData1 As String = m_SelfData.LotData.Substring(0, posVbCr) 'ตัดVbCrตำแหน่งสุดท้ายใส่ลงบัฟเฟอร์
            Dim Buff2 As String = ""
            If m_SelfData.LotData.Length > posVbCr Then
                Buff2 = m_SelfData.LotData.Substring(posVbCr, m_SelfData.LotData.Length - posVbCr)    'กรณีที่   SD,00EE VbCr SD, เก็บข้อมูลส่วนนี้ วนบันทึกในรอบต่อไป
            End If
            'SplitData เพื่อวนลูป
            Dim cmdArray As String() = BuffData1.Split(CChar(vbCr))
            For Each cmd As String In cmdArray
                If cmd <> "" Then
                    m_SelfData.LotData = cmd
                    CommunicateLogDisplay(m_SelfData.LotData, m_SelfData.McNo)
                    GetCode(m_SelfData)
                End If
            Next
            m_SelfData.LotData = Buff2
        End If

    End Sub

    Sub AlarmMessage(ByVal Mes As String)
        frmShowAlarmData.Show()
        frmShowAlarmData.lbAlarmMes.Text = Mes
    End Sub
    Private Function GetInfoPro(MCNo As String, LotNo As String, OpNo As String) As UserInfo

        log = New Logger("1.0", MCNo)
        lotInfo = c_ApcsProService.GetLotInfo(LotNo)
        If lotInfo Is Nothing Then
            log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", LotNo)
        End If
        If machineInfo Is Nothing Then
            machineInfo = c_ApcsProService.GetMachineInfo(MCNo)
        End If
        If machineInfo Is Nothing Then
            log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", MCNo)
        End If
        userInfo = c_ApcsProService.GetUserInfo(OpNo)
        If userInfo Is Nothing Then
            log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", OpNo)
        End If
        c_ApcsPro.LotNo = LotNo
        c_ApcsPro.MachineNo = MCNo
        c_ApcsPro.UserCode = OpNo

        XmlSave(c_ApcsPro)
        Return userInfo
    End Function
#Region "APCS Pro Function"
    Private Sub Reload(goodQty As Integer, ngQty As Integer, mcNo As String, opNo As String, lotNo As String)
        Try
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.AbnormalLotEnd_BackToThe_BeforeProcess(lotInfo.Id, machineInfo.Id, userInfo.Id, False, goodQty, ngQty, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "Reload", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotEnd_BackToThe_BeforeProcess", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
                MsgBox(ResultApcsProService.ErrorMessage)
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "Reload", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotEnd_BackToThe_BeforeProcess", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
        End Try
    End Sub
    Private Sub LotHold(mcNo As String, opNo As String, lotNo As String)
        Try
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.AbnormalLotHold(lotInfo.Id, machineInfo.Id, userInfo.Id, 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "LotHold", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotHold", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
                MsgBox(ResultApcsProService.ErrorMessage)
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "LotHold", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotHold", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
        End Try
    End Sub
    Private Sub LotCancel(mcNo As String, opNo As String, lotNo As String)
        Try
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.LotCancel(lotInfo.Id, machineInfo.Id, userInfo.Id, 1, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "LotCancel", "OUT", "CellCon", "iLibrary", 0, "LotCancel", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
                MsgBox(ResultApcsProService.ErrorMessage)
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "LotCancel", "OUT", "CellCon", "iLibrary", 0, "LotCancel", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
        End Try

    End Sub
    'Private Sub ReInput(goodQty As Integer, ngQty As Integer, mcNo As String, opNo As String, lotNo As String)
    '    currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
    '    ResultApcsProService = c_ApcsProService.ReInput(lotInfo.Id, machineInfo.Id, userInfo.Id, goodQty, ngQty, 1, currentServerTime.Datetime, log)
    '    If Not ResultApcsProService.IsOk Then
    '        log.ConnectionLogger.Write(0, "ReInput", "OUT", "CellCon", "iLibrary", 0, "ReInput", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '        MsgBox(ResultApcsProService.ErrorMessage)
    '    End If
    'End Sub
#End Region
#Region "APCS Pro CheckPermission"
    Private Function CheckPermissionApcsPro(MCNo As String, userInfo As iLibrary.UserInfo, functionName As String, logger As Logger, Optional appName As String = "CellController") As Boolean
        currentServerTime = c_ApcsProService.Get_DateTimeInfo(logger)
        Dim userPermission As CheckUserPermissionResult = c_ApcsProService.CheckUserPermission(userInfo, appName, functionName)
        If Not userPermission.IsPass Then
            MsgBox(userPermission.ErrorMessage)
            Return False
        End If
        If Not c_ApcsProService.Check_PermissionMachinesByLMS(userInfo.Id, MCNo, logger) Then
            MsgBox("รหัส : " & userInfo.Code & " ไม่ผ่านการตรวจสอบในระบบ Licenser กรุณาติดต่อ ETG (MCNo : " & MCNo & ")")
            Return False
        End If
        If Not c_ApcsProService.Check_UserLotAutoMotive(userInfo, lotInfo, logger) Then
            MsgBox("รหัส : " & userInfo.Code & " User ที่ไม่ใช่ Automotive ไม่สามารถรัน Lot Automotive ได้ กรุณาติดต่อ ETG (Lot Automotive : " & MCNo & ")")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "APCS Pro LotStart"
    Private Sub StartLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String)
        Try
            ' If packageEnable Then
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.LotStart(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, Recipe, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If
            ResultApcsProService = c_ApcsProService.OnlineStart(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If
            ' Else
            'log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            'End If

        Catch ex As Exception
            log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
        End Try
    End Sub
    Private Sub OnlineStartLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String)
        Try
            'If packageEnable Then
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.OnlineStart(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "OnlineStartLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If
            'Else
            'log.ConnectionLogger.Write(0, "OnlineStartLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            'End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "OnlineStartLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
        End Try
    End Sub
#End Region
#Region "APCS Pro LotEnd"
    Private Sub EndLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String, good As Integer, ng As Integer)
        Try
            'If packageEnable Then
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)

            ResultApcsProService = c_ApcsProService.OnlineEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, good, ng, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If

            ResultApcsProService = c_ApcsProService.LotEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, good, ng, 0, "", 1, currentServerTime.Datetime, log)
            UpdateMachineState(machineInfo.Id, MachineProcessingState.Idle, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If

            ' Else
            'log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "CheckPackageEnable", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            ' End If

        Catch ex As Exception
            log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
        End Try
    End Sub
    Private Sub OnlineEndLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String, good As Integer, ng As Integer)
        Try
            ' If packageEnable Then
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.OnlineEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, good, ng, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "OnlineEndLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", ResultApcsProService.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            End If
            ' Else
            ' log.ConnectionLogger.Write(0, "OnlineEndLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
            'End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "OnlineEndLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
        End Try
    End Sub
#End Region
#Region "Machine State and Machine OnlineState"
    Enum MachineProcessingState
        Idle = 1
        Ready = 3
        Execute = 4
        Pause = 5
        LotSetUp = 6
    End Enum
    Private Sub UpdateMachineState(machineID As Integer, runState As Integer, log As Logger, Optional userID As Integer = -1)
        c_ApcsProService.Update_MachineState(machineID, runState, userID, log)
    End Sub
    Private Sub UpdateMachineOnlineState(machineID As Integer, onlineState As Integer, log As Logger, Optional userID As Integer = -1)
        c_ApcsProService.Update_MachineOnlineState(machineID, onlineState, userID, log)
    End Sub
#End Region
#Region "License"
    Private Sub LicenseWarning(user As UserInfo)
        Try
            If user.License(0).Is_Warning Then
                MsgBox("แจ้งเตือน!! รหัส :" & user.Code + Environment.NewLine + "License " & user.License(0).Name & Environment.NewLine & " ใกล้หมดอายุ กรุณาต่ออายุ License ที่ ETG " & Environment.NewLine & "วันหมดอายุ " & user.License(0).ExpireDate.ToString("yyyy/MM/dd"))
                'lbNotification.Text = "แจ้งเตือน!! รหัส :" & user.Code + Environment.NewLine + "License " & user.License(0).Name & Environment.NewLine & " ใกล้หมดอายุ กรุณาต่ออายุ License ที่ ETG " & Environment.NewLine & "วันหมดอายุ " & user.License(0).ExpireDate.ToString("yyyy/MM/dd")
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "LicenseWarning", "OUT", "CellCon", "iLibrary", 0, "user.License(0)", "", "")
        End Try

    End Sub
#End Region
    Private XmlPathDataApcsPro As String = My.Application.Info.DirectoryPath & "\ApcsPro.xml"
    Private Sub XmlSave(data As ApcsPro)
        Try
            Using fs As New System.IO.FileStream(XmlPathDataApcsPro, System.IO.FileMode.Create)
                Dim bs = New XmlSerializer(data.GetType())
                bs.Serialize(fs, data)
            End Using
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "XmlSave", "OUT", "", "", 0, "XmlSave", ex.Message.ToString, "")
        End Try

    End Sub
    Private Sub XmlLoad(ByRef data As ApcsPro, type As Type)
        Try
            If (File.Exists(XmlPathDataApcsPro)) Then
                Using fs As New System.IO.FileStream(XmlPathDataApcsPro, System.IO.FileMode.Open)
                    Dim bs = New XmlSerializer(type)
                    data = CType(bs.Deserialize(fs), ApcsPro)
                End Using
                GetInfoPro(data.MachineNo, data.LotNo, data.UserCode)
                Recipe = data.Recipe
                UpdateMachineOnlineState(machineInfo.Id, 1, log)
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "XmlLoad", "OUT", "", "", 0, "XmlLoad", ex.Message.ToString, "")
        End Try

    End Sub
#Region "Apcs_Pro LotSetUp"
    Private Function SetUpApcsPro(mcNo As String, lotNo As String, package As String, opNo As String, logger As Logger) As Boolean
        'Auto Move TDC
        Try
            m_TdcService.MoveLot(lotNo, mcNo, opNo, "0255")
            Dim userInf As UserInfo = GetInfoPro(mcNo, lotNo, opNo)

            If CheckPermissionApcsPro(mcNo, userInf, "PL-SetupLot", logger) Then
                LicenseWarning(userInf)
                lotInfo = c_ApcsProService.GetLotInfo(lotNo)
                If lotInfo Is Nothing Then
                    logger.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", lotNo)
                End If
                If machineInfo Is Nothing Then
                    machineInfo = c_ApcsProService.GetMachineInfo(mcNo)
                End If
                If machineInfo Is Nothing Then
                    logger.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", mcNo)
                End If
                userInfo = c_ApcsProService.GetUserInfo(opNo)
                If userInfo Is Nothing Then
                    logger.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", opNo)
                End If
                currentServerTime = c_ApcsProService.Get_DateTimeInfo(logger)
                ResultApcsProService = c_ApcsProService.LotSetup(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
                UpdateMachineState(machineInfo.Id, MachineProcessingState.LotSetUp, log)
                If Not ResultApcsProService.IsOk Then
                    logger.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
                    MsgBox(ResultApcsProService.ErrorMessage)
                    Return False
                End If
                Recipe = ResultApcsProService.Recipe1
                c_ApcsPro.Recipe = Recipe
                XmlSave(c_ApcsPro)
                Return True
                'Return SetupLotPro(mcNo, lotNo, opNo)
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("(SetUpApcsPro)" & ex.Message.ToString)
            logger.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ex.Message.ToString, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)

            Return False
        End Try

    End Function
#End Region
    Private Sub GetCode(ByVal UserCtrlReflow As ReflowData)

        Dim strText() As String = m_SelfData.LotData.Split(CChar(","))
        Dim Header As String = strText(0).Trim
        Select Case Header

            Case "LR"   'LR,LotNo,PackageNo,DeviceNo,OpNo,Input,Mag,pcs/frm,Group

                Try
                    Dim strLotNo As String = strText(1).Trim
                    Dim strPackage As String = strText(2).Trim
                    Dim strDevice As String = strText(3).Trim
                    Dim strOPNo As String = strText(4).Trim
                    Dim intInputData As Integer = CInt(CLng("&H" & strText(5)))
                    Dim strMaga As String = strText(6).Trim
                    Dim strPCS_Frame As Integer = CInt(CLng("&H" & strText(7)))
                    Dim strGroup As String = Trim(strText(8)).Substring(0, 1)

                    'เชค Data error
                    If strLotNo = "" Then      ' LOT
                        AlarmMessage("LotNo ไม่ถูกต้องกรุณากรุณาตรวจสอบ Input ใหม่อีกครั้ง")
                        Exit Sub
                    ElseIf strOPNo = "" Then  'OP
                        AlarmMessage("OPNo ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        Exit Sub
                    ElseIf IsNumeric(strOPNo) = False Then
                        AlarmMessage("OPNo ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        Exit Sub
                    ElseIf intInputData = 0 Then  'Input
                        AlarmMessage("Input ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        Exit Sub
                    End If

                    If frmShowAlarmData.Visible = True Then
                        frmShowAlarmData.Close()
                    End If
                    If c_dlg IsNot Nothing Then
                        If c_dlg.Visible = True Then
                            c_dlg.Visible = False
                        End If
                    End If
                    'กรณี Reply ของ LotReq แล้ว Timeout Online
                    'If (m_Offline = _SelfConMode.Online AndAlso strLotNo = m_SelfData.LotNo) AndAlso m_SelfData.LeqLock = _EquipmentState.Unlock AndAlso m_SelfData.LotStatus <> _StatusLot.LotEnd Then
                    '    SendTheMessage(m_SelfData.IPA, "LP00" & vbCr, m_SelfData.McNo)
                    '    Exit Sub
                    'End If
                    'TDC
                    If m_SelfData.CellConState = _SelfConMode.Offline Then 'Run Offline
                        SendTheMessage(m_SelfData.IPA, "LP00" & vbCr, m_SelfData.McNo)
                        m_SelfData.LotInform = "Run Offline"
                    Else 'Run Online
                        Dim ApcsInfo = LotRequestTDC(strLotNo, RunModeType.Normal)
                        If ApcsInfo.IsPass = False Then
                            SendTheMessage(m_SelfData.IPA, "LP01" & vbCr, m_SelfData.McNo)
                            Exit Sub
                        Else
                            m_SelfData.LotInform = ApcsInfo.ErrorMessage
                            SendTheMessage(m_SelfData.IPA, "LP00" & vbCr, m_SelfData.McNo)
                        End If
                    End If



                    m_SelfData.LotNo = strLotNo
                    m_SelfData.Package = strPackage
                    m_SelfData.Device = strDevice
                    m_SelfData.OpNo = strOPNo
                    If strMaga = "0000000" Then
                        m_SelfData.MagazineNo = ""
                    Else
                        m_SelfData.MagazineNo = strMaga
                    End If
                    m_SelfData.Pcs_frm = strPCS_Frame
                    m_SelfData.Group = strGroup
                    m_SelfData.Input = intInputData
                    m_SelfData.StartTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    m_SelfData.StopTime = ""
                    m_SelfData.Output = 0
                    m_SelfData.AlarmTotal = 0
                    m_SelfData.Remark = "-"
                    m_SelfData.LotStatus = _StatusLot.LotSetup

                    m_SelfData.LotSetOfSending = False

                    ' m_SelfData.LotStartMode = _TDCMode.NormalInput

                    UpdateDisplay()


                    'TDC
                    'If m_Offline = _SelfConMode.Offline Then 'Run Offline
                    '    SendTheMessage(m_SelfData.IPA, "LP00" & vbCr, m_SelfData.McNo)
                    '    m_SelfData.LotInform = "Run Offline"

                    'Else 'Run Online
                    '    SyncLock m_Locker
                    '        Dim strLotReqData As String = m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.LotStartMode & "," & m_SelfData.IPA
                    '        m_LotReqQueue.Enqueue(strLotReqData)
                    '    End SyncLock

                    '    If bgTDCLotReq.IsBusy = False Then
                    '        lbLotReq.BackColor = Color.Lime
                    '        bgTDCLotReq.RunWorkerAsync()
                    '    End If

                    'End If

                    SaveLotStartToDbx()
                        SaveReflowDataTableXml()
                        SaveBackup()
                Catch ex As Exception
                    addlogfile("LR : " & ex.Message)
                End Try

            Case "SA" 'SA
                UpdateMachineState(machineInfo.Id, MachineProcessingState.Execute, log)
                If m_SelfData.StartTime <> "" And m_SelfData.StopTime = "" Then
                    Try
                        Dim LotNo As String = m_SelfData.LotNo
                        Dim MCNo As String = "RF-" & m_SelfData.McNo
                        ClearAlarmInfoTable(LotNo, MCNo)
                    Catch ex As Exception
                        addlogfile("SA : " & ex.Message)
                    End Try

                    m_SelfData.LotStatus = _StatusLot.LotStart
                    UpdateDisplay()
                End If

            Case "SB" 'SB
                UpdateMachineState(machineInfo.Id, MachineProcessingState.Idle, log)
                If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                    m_SelfData.LotStatus = _StatusLot.LotStop
                    UpdateDisplay()
                End If

            Case "SC" 'SC,AlarmNo
                UpdateMachineState(machineInfo.Id, MachineProcessingState.Pause, log)
                If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                    Try
                        Dim AlarmNo As String = strText(1).Trim
                        Dim AlarmID As String = ""
                        Dim LotNo As String = m_SelfData.LotNo
                        Dim McNo As String = "RF-" & m_SelfData.McNo

                        AlarmID = SearchAlarmID(AlarmNo)
                        If AlarmID <> "" Then
                            AddAlarmInfoToTable(AlarmNo, LotNo, McNo)
                            m_SelfData.AlarmTotal += 1
                        End If

                        m_SelfData.LotStatus = _StatusLot.LotAlarm
                        UpdateDisplay()
                    Catch ex As Exception
                        addlogfile("SC : " & ex.Message)
                    End Try
                End If
            Case "SD" 'SD,Good(frm)
                If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                    Try

                        Dim Output As Integer = CInt(CLng("&H" & strText(1).Trim) * m_SelfData.Pcs_frm)

                        m_SelfData.Output = Output

                        If m_SelfData.LotStatus <> _StatusLot.LotStart Then
                            m_SelfData.LotStatus = _StatusLot.LotStart
                        End If

                        If m_SelfData.LotSetOfSending = False Then
                            m_SelfData.LotSetOfSending = True
                            LotSetTdc("RF-" & m_SelfData.McNo, m_SelfData.LotNo, CDate(m_SelfData.StartTime), m_SelfData.OpNo)
                            'Send TDC
                            'SyncLock m_Locker
                            '    Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
                            '    m_LotSetQueue.Enqueue(strLotSetData)
                            'End SyncLock

                            'If bgTDC.IsBusy = False Then
                            '    lbLotSetEnd.BackColor = Color.Lime
                            '    bgTDC.RunWorkerAsync()
                            'End If

                            SaveBackup()
                        End If

                        ClearAlarmInfoTable(m_SelfData.LotNo, "RF-" & m_SelfData.McNo)
                        UpdateDisplay()

                    Catch ex As Exception
                        addlogfile("SD : " & ex.Message)
                    End Try
                End If


            Case "LE" 'LE,Good(frm),NORMAL or CONFIRM
                Try
                    If m_SelfData.StopTime <> "" OrElse (m_SelfData.StartTime = "" AndAlso m_SelfData.StopTime = "") Then
                        Exit Select
                    End If

                    Dim GoodPCS As Integer = CInt(CLng("&H" & strText(1)) * CDbl(m_SelfData.Pcs_frm))
                    'Dim LotEndStatus As String = strText(2)

                    If GoodPCS > m_SelfData.Input Then 'Output มาเกิน ทำให้มันค่าเท่ากับ Input
                        GoodPCS = m_SelfData.Input
                    End If

                    m_SelfData.Output = GoodPCS
                    m_SelfData.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    m_SelfData.LotStatus = _StatusLot.LotEnd
                    m_SelfData.NGQty = CInt(m_SelfData.Input) - CInt(m_SelfData.Output)

                    If CInt(m_SelfData.NGQty) < 0 Then
                        m_SelfData.NGQty = 0
                    ElseIf CInt(m_SelfData.NGQty) > CInt(m_SelfData.Input) Then
                        m_SelfData.NGQty = 0
                    End If
                    UpdateDisplay()

                    If m_SelfData.LotSetOfSending = False Then
                        Try
                            m_SelfData.LotSetOfSending = True
                            LotSetTdc("RF-" & m_SelfData.McNo, m_SelfData.LotNo, CDate(m_SelfData.StartTime), m_SelfData.OpNo)

                            ''Send TDC
                            'SyncLock m_Locker
                            '    Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
                            '    m_LotSetQueue.Enqueue(strLotSetData)
                            'End SyncLock
                            'If bgTDC.IsBusy = False Then
                            '    lbLotSetEnd.BackColor = Color.Lime
                            '    bgTDC.RunWorkerAsync()
                            'End If

                        Catch ex As Exception
                            addlogfile("LE TDC LOTSET: " & ex.Message)
                        End Try
                    End If

                    'TDC เก็บข้อมูลแล้วส่ง TDC
                    Try
                        'If radResetEnd.Checked Then
                        '    m_SelfData.LotEndMode = _TDCMode.Reload
                        'ElseIf radAccuEnd.Checked Then
                        '    m_SelfData.LotEndMode = _TDCMode.ReInput
                        'Else
                        '    m_SelfData.LotEndMode = _TDCMode.NormalEnd
                        'End If

                        'Dim tmpData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & CDate(m_SelfData.StopTime) & "," & CInt(m_SelfData.Output) & "," & CInt(m_SelfData.NGQty) & "," & m_SelfData.OpNo & "," & m_SelfData.LotEndMode
                        'SyncLock m_Locker
                        '    m_LotEndQueue.Enqueue(tmpData)
                        'End SyncLock

                        'If bgTDC.IsBusy = False Then
                        '    lbLotSetEnd.BackColor = Color.Lime
                        '    bgTDC.RunWorkerAsync()
                        'End If
                        LotEndTdc("RF-" & m_SelfData.McNo, m_SelfData.LotNo, CDate(m_SelfData.StopTime), m_SelfData.Output, m_SelfData.NGQty, m_SelfData.OpNo)
                    Catch ex As Exception
                        addlogfile("LE TDC LOTEND: " & ex.Message)
                    End Try

                    'If Not radNormal.Checked Then radNormal.Checked = True '//783
                    'If Not radNormalEnd.Checked Then radNormalEnd.Checked = True '//783

                    'เซฟข้อมูลลงใน DBx
                    SaveBackup()

                    Try
                        SaveLotEndToDbx()
                        SaveReflowDataTableXml()
                    Catch ex As Exception
                        addlogfile("LE Dbx : " & ex.Message)
                    End Try

                    Try
                        SaveAlarmInfoToDbx()
                    Catch ex As Exception
                        addlogfile("LE Alm : " & ex.Message)
                    End Try

                Catch ex As Exception
                    addlogfile("LE : " & ex.Message)
                End Try
        End Select
    End Sub

    Public Sub UpdateDisplay()

        lbMC.Text = m_SelfData.McNo
        lbIp.Text = m_SelfData.IPA
        lbOp.Text = m_SelfData.OpNo
        lbLotNo.Text = m_SelfData.LotNo
        lbPackage.Text = m_SelfData.Package
        lbDevice.Text = m_SelfData.Device
        lbInput.Text = CStr(m_SelfData.Input)
        lbOutput.Text = CStr(m_SelfData.Output)
        lbStart.Text = m_SelfData.StartTime
        lbStop.Text = m_SelfData.StopTime
        lbNotification.Text = m_SelfData.LotInform
        LbGroup.Text = m_SelfData.Group
        LbMagazine.Text = m_SelfData.MagazineNo

        Select Case m_SelfData.LotStatus
            Case _StatusLot.LotSetup
                lbStart.BackColor = Color.Transparent
            Case _StatusLot.LotStart
                lbStart.BackColor = Color.Lime
            Case _StatusLot.LotAlarm
                'lbStart.BackColor = Color.Red
            Case _StatusLot.LotEnd
                lbStart.BackColor = Color.Transparent
        End Select

    End Sub

#End Region

#Region "==========================================Button==============================================="

    Private Sub BtEndLot_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtEndLot.MouseDown
        BtEndLot.BackColor = Color.Lime
    End Sub

    Private Sub BtEndLot_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtEndLot.MouseUp
        BtEndLot.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub BtClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClearLog.Click
        CommLog.Text = ""
    End Sub

#End Region

    Private Sub TimerDateTime_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDateTime.Tick
        Lbtime.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Sub UpdateDataReflow()
        If My.Computer.Network.IsAvailable Then
            If My.Computer.Network.Ping(My.Settings.DBxServerIPAddress) Then
                Dim removeList As List(Of DataRow) = New List(Of DataRow)
                For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                    If row.IsLotEndTimeNull = False Then
                        Try
                            If ReflowDataTableAdapter.Update(row) = 1 Then
                                removeList.Add(row)
                            End If
                        Catch ex As Exception
                            SaveDataError(row)
                            removeList.Add(row)
                        End Try
                    End If
                Next
                For Each RemoveRow As DataRow In removeList
                    DBxDataSet.ReflowData.Rows.Remove(RemoveRow)
                Next
            End If
        End If

    End Sub

    Private Sub SaveDataError(ByVal row As DBxDataSet.ReflowDataRow)
        Dim randomFileName As String = Guid.NewGuid().ToString() & ".xml"
        Dim folder As String = Path.Combine(My.Application.Info.DirectoryPath, "DataError")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
        Using table As DBxDataSet.ReflowDataDataTable = New DBxDataSet.ReflowDataDataTable()
            table.ImportRow(row)
            Using sw As StreamWriter = New StreamWriter(Path.Combine(folder, randomFileName))
                table.WriteXml(sw.BaseStream)
            End Using
        End Using
    End Sub

    Private Sub SaveAlarmDataError(ByVal row As DBxDataSet.ReflowAlarmInfoRow)
        Dim randomFileName As String = Guid.NewGuid().ToString() & ".xml"
        Dim folder As String = Path.Combine(My.Application.Info.DirectoryPath, "AlarmDataError")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
        Using table As DBxDataSet.ReflowAlarmInfoDataTable = New DBxDataSet.ReflowAlarmInfoDataTable()
            table.ImportRow(row)
            Using sw As StreamWriter = New StreamWriter(Path.Combine(folder, randomFileName))
                table.WriteXml(sw.BaseStream)
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateDataReflow()
        CountRowData()
    End Sub

    Private Sub TPMaintenance_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TPMaintenance.Enter
        CountRowData()
    End Sub

    Sub CountRowData()
        Try
            Dim countRow As Integer = 0
            For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                If row.IsLotEndTimeNull = False Then
                    countRow += 1
                End If
            Next
            LbCounterFile.Text = CStr(countRow)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub



    Private Sub APCSClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APCSClose.Click
        If MessageBox.Show("ต้องการปิดโปรแกรม ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            SaveAlarmInfo()
            SaveAlarmTableXML()
            SaveReflowDataTableXml()
            SaveBackup()
            Me.Close()
        End If
    End Sub

    Private Sub BtEndLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEndLot.Click

        If lbStart.Text <> "" And lbStop.Text = "" Then
            If MessageBox.Show("คุณต้องการ Manual End ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim _frmEndMan As frmEndManual = New frmEndManual(Me)
                Dim InputGoodTotal As String
                If _frmEndMan.ShowDialog = Windows.Forms.DialogResult.OK Then
                    InputGoodTotal = _frmEndMan.tbPcs.Text
                Else
                    Exit Sub
                End If

                If InputGoodTotal = "" Or IsNumeric(InputGoodTotal) = False Or InputGoodTotal = "0" Then
                    AlarmMessage("Good Pcs ไม่ถูกต้องกรุณาตรวจสอบ")
                    Exit Sub
                End If


                Try
                    m_SelfData.Output = CInt(InputGoodTotal)
                    m_SelfData.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    m_SelfData.LotStatus = _StatusLot.LotEnd
                    UpdateDisplay()
                    SaveBackup()

                    If m_SelfData.LotSetOfSending = False Then
                        Try
                            m_SelfData.LotSetOfSending = True
                            'Send TDC
                            SyncLock m_Locker
                                Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
                                m_LotSetQueue.Enqueue(strLotSetData)
                            End SyncLock
                            If bgTDC.IsBusy = False Then
                                lbLotSetEnd.BackColor = Color.Lime
                                bgTDC.RunWorkerAsync()
                            End If
                        Catch ex As Exception
                            addlogfile("BtEndLot TDC LOTSET: " & ex.Message)
                        End Try
                    End If

                    'TDC เก็บข้อมูลแล้วส่ง TDC
                    Try
                        If radResetEnd.Checked Then
                            m_SelfData.LotEndMode = _TDCMode.Reload
                        ElseIf radAccuEnd.Checked Then
                            m_SelfData.LotEndMode = _TDCMode.ReInput
                        Else
                            m_SelfData.LotEndMode = _TDCMode.NormalEnd
                        End If

                        Dim tmpData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & CDate(m_SelfData.StopTime) & "," & CInt(m_SelfData.Output) & "," & m_SelfData.NGQty & "," & m_SelfData.OpNo & "," & m_SelfData.LotEndMode
                        SyncLock m_Locker
                            m_LotEndQueue.Enqueue(tmpData)
                        End SyncLock

                        If bgTDC.IsBusy = False Then
                            bgTDC.RunWorkerAsync()
                        End If

                    Catch ex As Exception
                        addlogfile("BtEndLot TDC : " & ex.Message)
                    End Try
                    'คืนค่าโหมดของ TDC
                    'If Not radNormal.Checked Then radNormal.Checked = True '//783
                    If Not radNormalEnd.Checked Then radNormalEnd.Checked = True '//783
                    'เซฟข้อมูลลง Dbx

                    Try
                        SaveLotEndToDbx()
                        SaveReflowDataTableXml()
                    Catch ex As Exception
                        addlogfile("LE Dbx : " & ex.Message)
                    End Try
                    'เซฟ Alarm ลง DBx
                    Try
                        SaveAlarmInfoToDbx()
                    Catch ex As Exception
                        addlogfile("LE Alm : " & ex.Message)
                    End Try

                Catch ex As Exception
                    addlogfile("BtEndLot : " & ex.Message)
                End Try


            End If
        Else
            MsgBox("MCNo " & lbMC.Text & " ไม่สามารถ End Manual ได้")
        End If
    End Sub

    Function SearchAlarmID(ByVal AlarmNo As String) As String

        Dim tmpAlarmNo As Integer = CInt(AlarmNo.Trim)
        Dim ret As String = ""

        Try
            For Each AlarmRow As DBxDataSet.ReflowAlarmTableRow In DBxDataSet.ReflowAlarmTable.Rows
                If CDbl(AlarmRow.AlarmNo) = tmpAlarmNo Then
                    ret = CStr(AlarmRow.ID)
                    Return ret
                End If
            Next
        Catch ex As Exception
        End Try
        Return ret
    End Function

    Private Sub AddAlarmInfoToTable(ByVal AlarmID As String, ByVal lotNo As String, ByVal MCNO As String)
        '-กรอง
        Dim intAlarmID As Integer = CInt(AlarmID)
        Dim CheckDuplicateAlarm As Boolean = False
        For Each AlarmRow As DBxDataSet.ReflowAlarmInfoRow In DBxDataSet.ReflowAlarmInfo.Rows
            If AlarmRow.AlarmID = intAlarmID And AlarmRow.LotNo = lotNo And AlarmRow.IsClearTimeNull = True Then
                CheckDuplicateAlarm = True
                Exit For
            End If
        Next

        If CheckDuplicateAlarm = False Then
            Dim newAlarmInfo As DBxDataSet.ReflowAlarmInfoRow = DBxDataSet.ReflowAlarmInfo.NewReflowAlarmInfoRow
            newAlarmInfo.RecordTime = Now
            newAlarmInfo.MCNo = MCNO
            newAlarmInfo.AlarmID = intAlarmID
            newAlarmInfo.LotNo = lotNo
            DBxDataSet.ReflowAlarmInfo.Rows.Add(newAlarmInfo)
            SaveAlarmInfo()
        End If

    End Sub

    Private Sub SaveAlarmInfoToDbx()
        If My.Computer.Network.Ping("172.16.0.102") = False Then
            Exit Sub
        End If

        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each DataRow As DBxDataSet.ReflowAlarmInfoRow In DBxDataSet.ReflowAlarmInfo.Rows
            Try
                If DataRow.MCNo = "RF-" & m_SelfData.McNo AndAlso DataRow.IsClearTimeNull = False Then
                    ReflowAlarmInfoTableAdapter.Update(DataRow)
                    removeList.Add(DataRow)
                End If
            Catch ex As Exception
                SaveAlarmDataError(DataRow)
                removeList.Add(DataRow)
            End Try
        Next
        For Each RemoveRow As DataRow In removeList
            DBxDataSet.ReflowAlarmInfo.Rows.Remove(RemoveRow)
        Next
    End Sub

    Sub ClearAlarmInfoTable(ByVal LotNo As String, ByVal McNo As String)
        For Each DataRow As DBxDataSet.ReflowAlarmInfoRow In DBxDataSet.ReflowAlarmInfo.Rows
            If DataRow.LotNo = LotNo And DataRow.MCNo = McNo And DataRow.IsClearTimeNull = True Then
                DataRow.ClearTime = Now
            End If
        Next
    End Sub

    Private Sub LoadAlarmInfoXml()
        If Not File.Exists(My.Application.Info.DirectoryPath & "\AlarmInfo.xml") Then
            Exit Sub
        End If

        Dim PathAlarmInfo As String = Path.Combine(My.Application.Info.DirectoryPath, "AlarmInfo.xml")
        Using sr As StreamReader = New StreamReader(PathAlarmInfo)
            DBxDataSet.ReflowAlarmInfo.ReadXml(sr)
        End Using
    End Sub

    Public Sub SaveAlarmInfo()
        Dim pathAlarmInfo As String = Path.Combine(My.Application.Info.DirectoryPath, "AlarmInfo.xml")
        Using sw As StreamWriter = New StreamWriter(pathAlarmInfo)
            DBxDataSet.ReflowAlarmInfo.WriteXml(sw)
        End Using
    End Sub

    Private Sub LoadAlarmTableXml()
        Dim PathAlarmTable As String = Path.Combine(My.Application.Info.DirectoryPath, "ReflowAlarmTable.xml")
        Using sr As StreamReader = New StreamReader(PathAlarmTable)
            DBxDataSet.ReflowAlarmTable.ReadXml(sr)
        End Using
    End Sub

    Private Sub SaveAlarmTableXML()
        Dim PathAlarmTable As String = Path.Combine(My.Application.Info.DirectoryPath, "ReflowAlarmTable.xml")
        Using sw As StreamWriter = New StreamWriter(PathAlarmTable)
            DBxDataSet.ReflowAlarmTable.WriteXml(sw)
        End Using
    End Sub

    Private Sub LoadReflowDataTableXml()
        If Not File.Exists(My.Application.Info.DirectoryPath & "\ReflowData.xml") Then
            Exit Sub
        End If
        Dim pathReflow As String = Path.Combine(My.Application.Info.DirectoryPath, "ReflowData.xml")
        Using sr As StreamReader = New StreamReader(pathReflow)
            DBxDataSet.ReflowData.ReadXml(sr)
        End Using
    End Sub

    Private Sub SaveReflowDataTableXml()
        Dim pathReflowData As String = Path.Combine(My.Application.Info.DirectoryPath, "ReflowData.xml")
        Using sw As StreamWriter = New StreamWriter(pathReflowData)
            DBxDataSet.ReflowData.WriteXml(sw)
        End Using
    End Sub

    Private Sub SaveBackup()
        Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflow.xml"
        Using fw As New IO.FileStream(pathData, FileMode.Create)
            Dim bs As New SoapFormatter
            bs.Serialize(fw, m_SelfData)
        End Using
    End Sub

    Private Sub LoadBackup()
        Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflow.xml"
        If File.Exists(pathData) = False Then
            MsgBox("ไม่มีไฟล์ ParameterReflow.xml")
            Exit Sub
        End If

        Using fr As New IO.FileStream(pathData, FileMode.Open)
            Dim bs As New SoapFormatter
            m_SelfData = CType(bs.Deserialize(fr), ReflowData)
        End Using

    End Sub

    Private Sub SaveLotStartToDbx()
        Try
            Dim strDataRow As DBxDataSet.ReflowDataRow = DBxDataSet.ReflowData.NewReflowDataRow
            strDataRow.LotNo = m_SelfData.LotNo
            strDataRow.MCNo = "RF-" & m_SelfData.McNo
            strDataRow.LotStartTime = CDate(m_SelfData.StartTime)
            strDataRow.OPNo = m_SelfData.OpNo
            strDataRow.InputQty = m_SelfData.Input    '130807   Change data type of dataset
            strDataRow.MagazineNo = m_SelfData.MagazineNo
            strDataRow.TemperatureGroup = m_SelfData.Group
            DBxDataSet.ReflowData.Rows.Add(strDataRow)

            Dim RemoveList As List(Of DataRow) = New List(Of DataRow)
            For Each StartRow As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                Try
                    If strDataRow.LotNo = m_SelfData.LotNo AndAlso StartRow.IsLotEndTimeNull = True Then
                        ReflowDataTableAdapter.Update(StartRow)
                    End If
                Catch ex As Exception
                    addlogfile("SaveLotStartToDbx StartRow:" & strDataRow.LotNo & " " & ex.Message.ToString)
                End Try
            Next

        Catch ex As Exception
            addlogfile("SaveLotStartToDbx :" & ex.Message.ToString)
        End Try
    End Sub
    Private Sub SaveLotEndToDbx()
        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each tmpDataRow As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
            If tmpDataRow.LotNo = m_SelfData.LotNo AndAlso tmpDataRow.LotStartTime = CDate(m_SelfData.StartTime) Then
                tmpDataRow.OutputQty = m_SelfData.Output
                tmpDataRow.LotEndTime = CDate(m_SelfData.StopTime)
                tmpDataRow.AlarmTotal = CShort(m_SelfData.AlarmTotal)
                tmpDataRow.Remark = m_SelfData.Remark

                Try
                    ReflowDataTableAdapter.Update(tmpDataRow)
                    removeList.Add(tmpDataRow)
                Catch ex As Exception
                    removeList.Add(tmpDataRow)
                    SaveDataError(tmpDataRow)
                End Try
            End If
        Next

        For Each removeRow As DataRow In removeList
            DBxDataSet.ReflowData.Rows.Remove(removeRow)
        Next

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "SA" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "SD,000000EE" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "LE,10,Normal" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "LR,9999A0006V,SSOP-B28W ,BD3805F1234(BW)        ,007567,07D8,0000000,001E,B." & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "LR,1535A4444V,SOP22     ,BD3805F4444(BW)        ,005588,0AD8,0000000,001E,B." & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "SA" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim Ip As String = "10.2.2.2"
        Dim Data As String = "SC,036" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "SC,040" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "LE,10,Normal" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim Ip As String = "10.2.2.2"
        Dim Data As String = "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr & "SA" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim Ip As String = "10.2.2.2"
        Dim Data As String = "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr & "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr & "LR,wwq"
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim Ip As String = "10.2.2.2"
        Dim Data As String = "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr & "LR,1535A2049V,SOP22     ,BD3805F(BW)         ,001656,09D8,0000000,001E,B." & vbCr
        Dim Ip1 As String = "10.2.2.2"
        Dim Data1 As String = "LE,10,Normal" & vbCr
        GetDataFromIPAddress(Ip, Data)
        GetDataFromIPAddress(Ip1, Data1)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim Ip As String = "10.2.2.2"
        Dim Data As String = "SD,000000EE" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim Ip As String = "10.1.1.50"
        Dim Data As String = "SD,000000AA" & vbCr
        GetDataFromIPAddress(Ip, Data)
    End Sub

#Region "Apcs_Pro Valiable"
    Private c_ApcsProService As IApcsProService = New ApcsProService()
    Private lotInfo As iLibrary.LotInfo
    Private machineInfo As MachineInfo
    Private userInfo As UserInfo
    Private currentServerTime As DateTimeInfo
    Private log As New Logger
    Private packageEnable As Boolean = False
    Private ResultApcsProService As LotUpdateInfo = Nothing
    Private Recipe As String
    '' Private functionName As String
    Private c_ApcsPro As New ApcsPro
#End Region
    '    Private Sub bgTDC_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgTDC.DoWork
    '        Dim TmpData As String = ""
    '        Dim ArrayData As String()
    '        'LotSet
    '        Dim MCNo As String
    '        Dim LotNo As String
    '        Dim StartTime As String
    '        Dim OPNo As String
    '        Dim LotSetMode As String = ""

    '        'LotEnd
    '        Dim EndTime As String
    '        Dim GoodQty As Integer
    '        Dim NGQTy As Integer
    '        Dim CountErr03 As Integer = 0
    '        Dim LotEndMode As String = ""

    'LBL_QUEUE_LOTSET_CHECK:
    '        Dim RepeatCountLotSet As Integer = 0
    '        SyncLock m_Locker
    '            If m_LotSetQueue.Count > 0 Then 'ทำ LotSet จนกว่าจะหมด Qeue
    '                TmpData = m_LotSetQueue.Dequeue
    '                ArrayData = TmpData.Split(CChar(","))
    '                MCNo = ArrayData(0)
    '                LotNo = ArrayData(1)
    '                StartTime = ArrayData(2)
    '                OPNo = ArrayData(3)
    '                LotSetMode = ArrayData(4)
    '                RepeatCountLotSet = 0
    '            Else 'ทำ LotEnd จนกว่าจะหมด Qeue
    '                GoTo LBL_QUEUE_LOTEND_CHECK
    '            End If
    '        End SyncLock

    'LBL_QUEUE_LotSet_Err:

    '        Dim resSet As TdcResponse = m_TdcService.LotSet(MCNo, LotNo, CDate(StartTime), OPNo, RunModeType.Normal)
    '        If resSet.HasError Then
    '            If RepeatCountLotSet > 5 Then 'กรณีที่ Err 70,71,72 วนรันซ้ำมากกว่า 5 ครั้ง เป็น Err Log แล้วรัน Lot ต่อไป
    '                addlogfile("LotSet : " & TmpData)
    '                GoTo LBL_QUEUE_LOTSET_CHECK
    '            End If

    '            Select Case resSet.ErrorCode
    '                Case "04"
    '                    RepeatCountLotSet += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotSet_Err
    '                Case "70"
    '                    RepeatCountLotSet += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotSet_Err
    '                Case "71"
    '                    RepeatCountLotSet += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotSet_Err
    '                Case "72"
    '                    RepeatCountLotSet += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotSet_Err
    '                Case "99"
    '                    RepeatCountLotSet += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotSet_Err
    '            End Select
    '        End If
    '#Region "Apcs_Pro LotSetUp"

    '        Try

    '            log = New Logger("1.0", MCNo)
    '            packageEnable = c_ApcsProService.CheckPackageEnable(m_SelfData.Package, log)
    '            If Not packageEnable Then
    '                GoTo LBL_QUEUE_LOTSET_CHECK
    '            End If

    '            lotInfo = c_ApcsProService.GetLotInfo(LotNo)
    '            If lotInfo Is Nothing Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", LotNo)
    '            End If
    '            machineInfo = c_ApcsProService.GetMachineInfo(MCNo)
    '            If machineInfo Is Nothing Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", MCNo)
    '            End If
    '            userInfo = c_ApcsProService.GetUserInfo(m_SelfData.OpNo)
    '            If userInfo Is Nothing Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", m_SelfData.OpNo)
    '            End If
    '            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)

    '            ResultApcsProService = c_ApcsProService.LotSetup(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
    '            If Not ResultApcsProService.IsOk Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ResultApcsProService.ErrorMessage, "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & m_SelfData.OpNo)
    '            End If
    '        Catch ex As Exception
    '            'addErrLogfile("c_ApcsProService.LotSetup,LotStart:" & ex.ToString())
    '            log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & m_SelfData.OpNo)

    '        End Try
    '#End Region
    '#Region "APCS Pro LotStart"
    '        Try
    '            'currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
    '            ResultApcsProService = c_ApcsProService.LotStart(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
    '            If Not ResultApcsProService.IsOk Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorMessage, "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & OPNo)
    '            End If
    '        Catch ex As Exception
    '            log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & OPNo)
    '        End Try
    '#End Region
    '        GoTo LBL_QUEUE_LOTSET_CHECK


    'LBL_QUEUE_LOTEND_CHECK:
    '        Dim RepeatCountLotEnd As Integer = 0
    '        SyncLock m_Locker

    '            If m_LotEndQueue.Count > 0 Then 'ทำ LotEnd จนกว่าจะหมด Qeue
    '                TmpData = m_LotEndQueue.Dequeue
    '                ArrayData = TmpData.Split(CChar(","))
    '                MCNo = ArrayData(0)
    '                LotNo = ArrayData(1)
    '                EndTime = ArrayData(2)
    '                GoodQty = CInt(ArrayData(3))

    '                If ArrayData(4) = "" Then
    '                    NGQTy = 0
    '                Else
    '                    NGQTy = CInt(ArrayData(4))
    '                End If
    '                OPNo = ArrayData(5)
    '                LotEndMode = ArrayData(6)
    '                RepeatCountLotEnd = 0
    '            Else 'ทำ LotEnd จนกว่าจะหมด Qeue
    '                Exit Sub
    '            End If
    '        End SyncLock

    'LBL_QUEUE_LotEnd_Err:

    '        Dim resEnd As TdcResponse = m_TdcService.LotEnd(MCNo, LotNo, CDate(EndTime), CInt(GoodQty), CInt(NGQTy), CType(LotEndMode, EndModeType), OPNo)
    '        If resEnd.HasError Then
    '            If RepeatCountLotEnd > 5 Then 'กรณีที่ Err 70,71,72 วนรันซ้ำมากกว่า 5 ครั้ง เป็น Err Log แล้วรัน Lot ต่อไป
    '                addlogfile("LotEnd : " & TmpData)
    '                GoTo LBL_QUEUE_LOTEND_CHECK
    '            End If
    '            Select Case resEnd.ErrorCode
    '                Case "03" 'Lot was not started or ended 150921
    '                    CountErr03 += 1 '                                  150923
    '                    If CountErr03 > 10 Then '                          150923
    '                        addlogfile("LotErr03 : " & TmpData) '          150923
    '                        CountErr03 = 0 '                               150923
    '                        GoTo LBL_QUEUE_LOTEND_CHECK '                  150923
    '                    End If '150923
    '                    m_LotEndQueue.Enqueue(TmpData)
    '                    GoTo LBL_QUEUE_LOTSET_CHECK
    '                Case "04" 'MC not found
    '                    RepeatCountLotEnd += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotEnd_Err
    '                Case "70"
    '                    RepeatCountLotEnd += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotEnd_Err
    '                Case "71"
    '                    RepeatCountLotEnd += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotEnd_Err
    '                Case "72"
    '                    RepeatCountLotEnd += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotEnd_Err
    '                Case "99"
    '                    RepeatCountLotEnd += 1
    '                    Thread.Sleep(3000)
    '                    GoTo LBL_QUEUE_LotEnd_Err
    '            End Select
    '        End If
    '        CountErr03 = 0
    '#Region "APCS Pro LotEnd"
    '        Try
    '            If Not packageEnable Then
    '                GoTo LBL_QUEUE_LOTEND_CHECK
    '            End If
    '            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
    '            ResultApcsProService = c_ApcsProService.LotEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, CInt(GoodQty), CInt(NGQTy), 0, "", 1, currentServerTime.Datetime, log)
    '            If Not ResultApcsProService.IsOk Then
    '                log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ResultApcsProService.ErrorMessage, "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & OPNo)
    '            End If
    '        Catch ex As Exception
    '            log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & OPNo)
    '        End Try
    '#End Region

    '        GoTo LBL_QUEUE_LOTEND_CHECK
    '    End Sub


    'Private Sub bgTDCLotReq_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgTDCLotReq.DoWork

    '    Dim TmpData As String
    '    Dim ArrayData() As String
    '    Dim MCNo As String
    '    Dim LotNo As String
    '    Dim LotSetMode As Integer
    '    Dim IPAdr As String
    '    Dim RepeatCountLotReq As Integer

    '    SyncLock m_Locker
    '        If m_LotReqQueue.Count > 0 Then 'ทำ LotSet จนกว่าจะหมด Qeue
    '            'McNo,LotNo,LotStartMode,IPA
    '            TmpData = m_LotReqQueue.Dequeue
    '            ArrayData = TmpData.Split(CChar(","))
    '            MCNo = ArrayData(0)
    '            LotNo = ArrayData(1)
    '            LotSetMode = CInt(ArrayData(2))
    '            IPAdr = ArrayData(3)
    '            RepeatCountLotReq = 0
    '        Else
    '            Exit Sub
    '        End If
    '    End SyncLock



    '    Dim strMess As String = ""

    '    Dim res As TdcResponse = m_TdcService.LotRequest("RF-" & MCNo, LotNo, RunModeType.Normal)
    '    If res.HasError Then
    '        If res.ErrorCode = "01" Then
    '            strMess = "01 : Not found"
    '            If m_01 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "02" Then
    '            strMess = "02 : Running"
    '            If m_02 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "03" Then
    '            strMess = "03 : Not run"
    '            If m_03 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "04" Then
    '            strMess = "04 : Machine not found"
    '            If m_04 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "05" Then
    '            strMess = "05 : Error lot status"
    '            If m_05 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "06" Then
    '            strMess = "06 : Error process"
    '            If m_06 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "70" Then
    '            strMess = "70 : Error connect database"
    '            If m_70 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "71" Then
    '            strMess = "71 : Error read database"
    '            If m_71 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "72" Then
    '            strMess = "72 : Error write database"
    '            If m_72 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        ElseIf res.ErrorCode = "99" Then
    '            strMess = "99 : Other"
    '            If m_99 = True Then
    '                m_SelfData.LeqLock = _EquipmentState.Unlock
    '                SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '            Else
    '                m_SelfData.LeqLock = _EquipmentState.LOCK
    '                SendTheMessage(IPAdr, "LP01" & vbCr, MCNo)
    '            End If
    '        End If
    '    Else
    '        m_SelfData.LeqLock = _EquipmentState.Unlock
    '        SendTheMessage(IPAdr, "LP00" & vbCr, MCNo)
    '        strMess = "00 : Running"
    '    End If



    '    Dim StrData As String = strMess
    '    m_SelfData.LotInform = StrData
    '    SaveBackup()

    'End Sub


    Private Sub bgTDC_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgTDC.RunWorkerCompleted
        lbLotSetEnd.BackColor = Color.Tomato
    End Sub



    Private Sub AndonToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndonToolStripMenuItem4.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/andon", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WorkRecordToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkRecordToolStripMenuItem3.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/ERecord/Default.aspx", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem2.Click
        Process.Start(Path.Combine(My.Application.Info.DirectoryPath, "ReflowManaul.pdf"))
    End Sub

    Private Sub BMRequestToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMRequestToolStripMenuItem3.Click
        Dim tmpStr As String
        tmpStr = "MCNo=" & "RF-" & My.Settings.MCNo
        tmpStr = tmpStr & "&LotNo=" & lbLotNo.Text
        If lbStart.Text <> "" AndAlso lbStop.Text = "" Then
            tmpStr = tmpStr & "&MCStatus=Running"
        Else
            tmpStr = tmpStr & "&MCStatus=Stop"
        End If
        tmpStr = tmpStr & "&AlarmNo="
        tmpStr = tmpStr & "&AlarmName="

        'If SelConDataLot.AlarmNo <> "" Then
        '    tmpStr = tmpStr & "&AlarmNo=" & SelConDataLot.AlarmNo
        '    tmpStr = tmpStr & "&AlarmName=" & SelConDataLot.AlarmMessage     'เขียนฟังชั่นหา
        'Else
        '    tmpStr = tmpStr & "&AlarmNo="
        '    tmpStr = tmpStr & "&AlarmName="
        'End If
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainloginPD.asp?" & tmpStr, vbNormalFocus)
        Process.Start("C:\WINDOWS\system32\osk.exe")
    End Sub

    Private Sub PMRepairingToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMRepairingToolStripMenuItem3.Click
        Process.Start("C:\WINDOWS\system32\osk.exe")
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainPMlogin.asp?" & "MCNo=" & "RF-" & lbMC.Text, vbNormalFocus)

    End Sub

    Private Sub SearchToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem3.Click
        If frmSeachData Is Nothing OrElse frmSeachData.Visible = False Then
            frmSeachData = New frmSearch(Me)
        End If
        frmSeachData.Show()
        frmSeachData.Focus()
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.RoyalBlue, 17)
        e.Graphics.DrawLine(myPen, 0, 70, Me.Width, 70)

        myPen = New Pen(Color.PowderBlue, 35)
        e.Graphics.DrawLine(myPen, 0, 180, Me.Width, 180)
    End Sub

    Private Sub BtSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSetting.Click
        If InputBox("กรุณาใส่รหัส") = Format(Now, "MMyydd") Then
            Dim _frmConfig As frmConfig = New frmConfig(Me)
            If _frmConfig.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SaveConfig()
            End If
        End If
    End Sub

    Public Sub SaveConfig()
        'Dim PathLog As String = My.Application.Info.DirectoryPath & "\Config.txt"
        ''create objext and open an exist file
        'Dim objWriter As New System.IO.StreamWriter(PathLog, False)
        'Dim StatusMode As String
        'If m_Offline = _SelfConMode.Online Then
        '    StatusMode = "Online"
        'Else
        '    StatusMode = "Offline"
        'End If
        ''write an error to file
        'Dim strLog As String
        'strLog = "01 Not found  = " & m_01 & vbCrLf & _
        '"02 Running = " & m_02 & vbCrLf & _
        '"03 Not Run  = " & m_03 & vbCrLf & _
        '"04 Machine not found = " & m_04 & vbCrLf & _
        '"05 Error Lot State = " & m_05 & vbCrLf & _
        '"06 Error Process = " & m_06 & vbCrLf & _
        '"70 Error Connect Database  = " & m_70 & vbCrLf & _
        '"72 Error Write Database = " & m_72 & vbCrLf & _
        '"99 Other  = " & m_99 & vbCrLf & _
        '"Run Offline = " & StatusMode
        'objWriter.WriteLine(strLog)
        ''close file
        'objWriter.Close()

    End Sub

    Public Sub LoadConfigTDC()

        'Dim PathLog As String = My.Application.Info.DirectoryPath & "\Config.txt"

        'Dim sr As StreamReader = File.OpenText(PathLog)
        'Dim tmpData As String = ""
        'Dim strDataArray As String()
        'Do While sr.Peek >= 0
        '    tmpData &= sr.ReadLine & ","
        'Loop
        'sr.Close()
        'tmpData = tmpData.Trim(CChar(","))
        'strDataArray = tmpData.Split(CChar(","))
        'For Each str As String In strDataArray
        '    If str.Trim <> "" Then
        '        Dim tempAr As String() = str.Split(CChar("="))
        '        If tempAr(0).Contains("01") = True Then
        '            m_01 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("02") = True Then
        '            m_02 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("03") = True Then
        '            m_03 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("04") = True Then
        '            m_04 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("05") = True Then
        '            m_05 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("06") = True Then
        '            m_06 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("70") = True Then
        '            m_70 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("72") = True Then
        '            m_72 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("99") = True Then
        '            m_99 = CBool(tempAr(1).Trim)
        '        ElseIf tempAr(0).Contains("Offline") = True Then
        '            If tempAr(1).Trim = "Online" Then
        '                m_Offline = _SelfConMode.Online
        '                lbStatusMC.BackColor = Color.Lime
        '            Else
        '                m_Offline = _SelfConMode.Offline
        '                lbStatusMC.BackColor = Color.Red
        '            End If
        '        End If
        '    End If
        'Next

    End Sub


    Private Sub bgTDCLotReq_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgTDCLotReq.RunWorkerCompleted
        lbLotReq.BackColor = Color.Tomato
    End Sub

    Private Sub WIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIPToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/reflowwip/", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function LotRequestTDC(ByVal LotNo As String, ByVal rm As RunModeType) As TDCInfo
        Dim apcsInfo As New TDCInfo
        Dim mc As String = "RF-" & My.Settings.MCNo

        Dim res As TdcLotRequestResponse = m_TdcService.LotRequest(mc, LotNo, rm)

        If res.HasError Then

            Using svError As ApcsWebServiceSoapClient = New ApcsWebServiceSoapClient
                If svError.LotRptIgnoreError(mc, res.ErrorCode) = False Then
                    Dim li As Rohm.Apcs.Tdc.LotInfo = Nothing
                    li = m_TdcService.GetLotInfo(LotNo, mc)
                    c_dlg = New TdcAlarmMessageForm(res.ErrorCode, res.ErrorMessage, LotNo, li)
                    c_dlg.Show()
                    apcsInfo.ErrorMessage = res.ErrorCode & " : " & res.ErrorMessage
                    apcsInfo.ErrorCode = res.ErrorCode
                    apcsInfo.IsPass = False
                    Return apcsInfo
                End If
            End Using
            apcsInfo.ErrorMessage = res.ErrorCode & " : " & res.ErrorMessage
            apcsInfo.IsPass = True
            Return apcsInfo
        Else
            apcsInfo.ErrorMessage = "00 : Run Normal"
            apcsInfo.IsPass = True
            Return apcsInfo
        End If

    End Function

    Private Sub LotSetTdc(MCno As String, LotNo As String, StartTime As DateTime, OpNo As String)
        Dim res As TdcResponse = m_TdcService.LotSet(MCno, LotNo, StartTime, OpNo, RunModeType.Normal)

#Region "Apcs_Pro LotSetUp"

        Try

            log = New Logger("1.0", MCno)
            packageEnable = c_ApcsProService.CheckPackageEnable(m_SelfData.Package, log)
            If Not packageEnable Then
                Exit Sub
            End If

            lotInfo = c_ApcsProService.GetLotInfo(LotNo)
            If lotInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotSet LotNo", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", LotNo)
            End If
            machineInfo = c_ApcsProService.GetMachineInfo(MCno)
            If machineInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotSet MC", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", MCno)
            End If
            userInfo = c_ApcsProService.GetUserInfo(m_SelfData.OpNo)
            If userInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotSet User", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", m_SelfData.OpNo)
            End If
            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)

            ResultApcsProService = c_ApcsProService.LotSetup(lotInfo.Id, machineInfo.Id, userInfo.Id, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "APCS Pro LotSet ApcsProService ", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ResultApcsProService.ErrorMessage, "LotNo:" & LotNo & ",MCNo:" & MCno & ",OPNo:" & m_SelfData.OpNo)
            End If
        Catch ex As Exception
            'addErrLogfile("c_ApcsProService.LotSetup,LotStart:" & ex.ToString())
            log.ConnectionLogger.Write(0, "APCS Pro LotSet Err", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & MCno & ",OPNo:" & m_SelfData.OpNo)

        End Try
#End Region
    End Sub
    Private Sub LotEndTdc(McNo As String, LotNo As String, EndTime As DateTime, Good As Integer, Ng As Integer, OpNo As String)
        Dim res As TdcResponse = m_TdcService.LotEnd(McNo, LotNo, EndTime, Good, Ng, EndModeType.Normal, OpNo)
#Region "APCS Pro LotEnd"
        Try
            If Not packageEnable Then
                Exit Sub
            End If

            lotInfo = c_ApcsProService.GetLotInfo(LotNo)
            If lotInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotEnd LotNo", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", LotNo)
            End If
            machineInfo = c_ApcsProService.GetMachineInfo(McNo)
            If machineInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotEnd MC", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", McNo)
            End If
            userInfo = c_ApcsProService.GetUserInfo(m_SelfData.OpNo)
            If userInfo Is Nothing Then
                log.ConnectionLogger.Write(0, "APCS Pro LotEnd User", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", m_SelfData.OpNo)
            End If

            currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)

            ResultApcsProService = c_ApcsProService.LotEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, Good, Ng, 0, "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.ConnectionLogger.Write(0, "APCS Pro LotEnd", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ResultApcsProService.ErrorMessage, "LotNo:" & LotNo & ",MCNo:" & McNo & ",OPNo:" & OpNo)
            End If
        Catch ex As Exception
            log.ConnectionLogger.Write(0, "APCS Pro LotEnd Err", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & McNo & ",OPNo:" & OpNo)
        End Try
#End Region
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            UpdateMachineOnlineState(machineInfo.Id, 0, log)
        Catch ex As Exception

        End Try
    End Sub
End Class
