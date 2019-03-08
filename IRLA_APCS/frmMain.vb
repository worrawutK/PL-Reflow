Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Rohm.Apcs.Tdc
Imports System.Runtime.Serialization.Formatters.Soap
'Imports iLibrary
Imports Rohm.Common.Logging
Imports WindowsApplication1.ServiceReference1
Imports System.Xml.Serialization
Imports System.Text.RegularExpressions
Imports WindowsApplication1.iLibraryService
Imports MessageDialog
Public Class frmMain
    'Private m_TdcService As TdcService
    Dim DataSendTDC As String
    Dim SoftwareRevision As String = "Reflow SelfCon ver.161109"
    Dim buffer As String
    'Dim frmSeachData As frmSearch
    Dim m_Locker As New Object
    Private m_LotSetQueue As Queue(Of String) = New Queue(Of String)
    Private m_LotEndQueue As Queue(Of String) = New Queue(Of String)
    Private m_LotReqQueue As Queue(Of String) = New Queue(Of String)
    'Dim c_dlg As TdcAlarmMessageForm

    Private RFData As Dictionary(Of String, ReflowData) = New Dictionary(Of String, ReflowData)
    Private ReFlowDataList As List(Of ReflowData)

    Private c_ServiceiLibrary As ServiceiLibraryClient



#Region "========================== Windows Form Designer generated code ==============================="

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bgTDC.IsBusy = True Or bgTDCLotReq.IsBusy = True Then
            MsgBox("ไม่สามารถติดโปรแกรมได้ โปรแกรมกำลังประมวลผลอยู่")
            e.Cancel = True
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c_ServiceiLibrary = New ServiceiLibraryClient()
        lbMC.Text = My.Settings.MCNo
        lbIp.Text = My.Settings.IP
        lbNetversion.Text = "190220 Support APCS Pro." 'Add Search Record
        'm_TdcService = TdcService.GetInstance()
        'm_TdcService.ConnectionString = My.Settings.APCSDBConnectionString
        'LoadPFAlarmTable()
        ' LoadAlarmInfoXml()
        ' LoadReflowDataTableXml()
        'LoadBackup()
        If ReFlowDataList Is Nothing Then
            ReFlowDataList = New List(Of ReflowData)
        End If
        ReFlowDataList = LoadBackupList()
        ' LoadTDCConfig()
        For Each data As ReflowData In ReFlowDataList
            If Not data.StartTime Is Nothing Then
                LoadDbx(data)
            End If

        Next

        InitialNetworkComponent()
        Me.StartSocketThread()

        'radNormalEnd.Checked = True      

        UpdateDisplay(ReFlowDataList, False)
        Try
            c_ServiceiLibrary.MachineOnlineState(My.Settings.MCNo, MachineOnline.Online)
        Catch ex As Exception
            TextBoxNotification1.Text = "MachineOnlineState :" & ex.ToString()
        End Try

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
        '     If ComLog.Text.Length = 25000 Then ComLog.Text = ""
        '   If cbSDGood.Checked = True And strData.Contains("SD,") = True Then Exit Sub
        If strData.Contains("LP") = True Then
            strData = " Send :" & strData
        Else
            strData = " Rev :" & strData
        End If
        If Not frmLog Is Nothing Then
            frmLog.SendLog(tmpTime & " " & mcNo & " " & strData & vbCrLf)
        End If
        '     CommLog.AppendText(tmpTime & " " & mcNo & " " & strData & vbCrLf)
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

    Public Sub GetDataFromIPAddress(ByVal ip As String, ByVal data As String)

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
                    'CommunicateLogDisplay(m_SelfData.LotData, m_SelfData.McNo)
                    CommunicateLogDisplay(m_SelfData.LotData, My.Settings.MCNo)
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
    Private Function SearchReflowData(LotNo As String) As ReflowData
        For Each data As ReflowData In ReFlowDataList
            If data.LotNo = LotNo Then
                Return data
            End If
        Next
        Return Nothing
    End Function
    Private Function AutoCancelReflowData(LotNo As String) As Boolean
        For Each data As ReflowData In ReFlowDataList.ToArray
            If data.StartTime = "" Then
                ReFlowDataList.Remove(data)
            End If
        Next

        Return False
    End Function
    Private Function RemoveReflowData(LotNo As String) As ReflowData
        For Each data As ReflowData In ReFlowDataList
            If data.LotNo = LotNo Then
                Return data
            End If
        Next
        Return Nothing
    End Function
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
                    Dim strMaga As String = strText(6).Trim.ToUpper()
                    Dim strPCS_Frame As Integer = CInt(CLng("&H" & strText(7)))
                    Dim strGroup As String = Trim(strText(8)).Substring(0, 1)

                    Dim data As ReflowData
                    'If Not RFData.ContainsKey(strLotNo) Then
                    data = New ReflowData With {
                            .McNo = My.Settings.MCNo,
                            .IPA = My.Settings.IP,
                            .LotNo = strLotNo,
                            .Package = strPackage,
                            .Device = strDevice,
                            .OpNo = strOPNo,
                            .Input = intInputData,
                            .Pcs_frm = strPCS_Frame,
                            .Group = strGroup,
                            .Output = 0,
                            .AlarmTotal = 0,
                            .Remark = "-",
                            .LotStatus = _StatusLot.LotSetup,
                            .LotSetOfSending = False
                        }

                    ' .StopTime = "",
                    If (strMaga = "0000000000") Then
                        data.MagazineNo = ""
                    Else
                        data.MagazineNo = strMaga
                    End If
                    ' End If
                    'เชค Data error
                    If strLotNo = "" Then      ' LOT
                        AlarmMessage("LotNo ไม่ถูกต้องกรุณากรุณาตรวจสอบ Input ใหม่อีกครั้ง")
                        SendTheMessage(data.IPA, "LP01" & vbCr, data.McNo)
                        Exit Sub
                    ElseIf strOPNo = "" Then  'OP
                        AlarmMessage("OPNo ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        SendTheMessage(data.IPA, "LP01" & vbCr, data.McNo)
                        Exit Sub
                    ElseIf IsNumeric(strOPNo) = False Then
                        AlarmMessage("OPNo ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        SendTheMessage(data.IPA, "LP01" & vbCr, data.McNo)
                        Exit Sub
                    ElseIf intInputData = 0 Then  'Input
                        AlarmMessage("Input ไม่ถูกต้องกรุณาตรวจสอบและ Input ใหม่อีกครั้ง")
                        SendTheMessage(data.IPA, "LP01" & vbCr, data.McNo)
                        Exit Sub
                    End If
                    AutoCancelReflowData(strLotNo)
                    ReFlowDataList.Add(data)
                    Dim ApcsInfo = LotRequestTDC(strLotNo, RunModeType.Normal, strOPNo)
                    If ApcsInfo.IsPass = False Then
                        SendTheMessage(data.IPA, "LP01" & vbCr, data.McNo)
                        data.LotInform = ApcsInfo.ErrorMessage
                        UpdateDisplay(ReFlowDataList, False)
                        ReFlowDataList.Remove(data)

                        ' lbNotification1.Text = ApcsInfo.ErrorMessage
                        Exit Sub
                    Else
                        data.LotInform = ApcsInfo.ErrorMessage
                        SendTheMessage(data.IPA, "LP00" & vbCr, data.McNo)
                    End If


                    UpdateDisplay(ReFlowDataList)
                    SaveBackupList(ReFlowDataList)

                Catch ex As Exception
                    addlogfile("LR : " & ex.Message)
                End Try
            Case "LS" 'Start
                Try
                    If strText.Length <> 2 Then
                        Exit Sub
                    End If
                    SendTheMessage(My.Settings.IP, "ST" & vbCr, My.Settings.MCNo)
                    Dim strLotNo As String = strText(1).Trim
                    Dim data As ReflowData = SearchReflowData(strLotNo)
                    If data Is Nothing Then
                        MessageBox.Show("ไม่พบข้อมูล Lot " & strLotNo & "นี้")
                        Exit Sub
                    End If
                    data.StartTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    If data.LotStatus <> _StatusLot.LotStart Then
                        data.LotStatus = _StatusLot.LotStart
                    End If
                    LotSetTdc(data.McNo, data.LotNo, CDate(data.StartTime), data.OpNo)
                    UpdateDisplay(ReFlowDataList)
                    SaveLotStartToDbx(data)
                    ' SaveBackupList(ReFlowDataList)
                    'If m_SelfData.LotSetOfSending = False Then
                    '    m_SelfData.LotSetOfSending = True
                    '    LotSetTdc("RF-" & m_SelfData.McNo, m_SelfData.LotNo, CDate(m_SelfData.StartTime), m_SelfData.OpNo)
                    '    'Send TDC
                    '    'SyncLock m_Locker
                    '    '    Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
                    '    '    m_LotSetQueue.Enqueue(strLotSetData)
                    '    'End SyncLock

                    '    'If bgTDC.IsBusy = False Then
                    '    '    lbLotSetEnd.BackColor = Color.Lime
                    '    '    bgTDC.RunWorkerAsync()
                    '    'End If

                    '    SaveBackup()
                    'End If
                Catch ex As Exception

                End Try

            Case "SA" 'SA
                'UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.Execute, c_Log)
                Try
                    c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Execute)
                Catch ex As Exception
                    TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
                End Try

                For Each data As ReflowData In ReFlowDataList
                    If data.StartTime <> "" And data.StopTime = "" Then
                        Try
                            ClearAlarmInfoTable(data.LotNo, data.McNo)
                        Catch ex As Exception
                            addlogfile("SA : " & ex.Message)
                        End Try
                        data.LotStatus = _StatusLot.LotStart

                    End If
                Next
                UpdateDisplay(ReFlowDataList)
                'If m_SelfData.StartTime <> "" And m_SelfData.StopTime = "" Then


                '    m_SelfData.LotStatus = _StatusLot.LotStart
                '    UpdateDisplay()
                'End If

                'If m_SelfData.StartTime <> "" And m_SelfData.StopTime = "" Then
                '    Try
                '        Dim LotNo As String = m_SelfData.LotNo
                '        Dim MCNo As String = "RF-" & m_SelfData.McNo
                '        ClearAlarmInfoTable(LotNo, MCNo)
                '    Catch ex As Exception
                '        addlogfile("SA : " & ex.Message)
                '    End Try

                '    m_SelfData.LotStatus = _StatusLot.LotStart
                '    UpdateDisplay()
                'End If

            Case "SB" 'SB
                'UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.Idle, c_Log)
                Try
                    c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Idle)
                Catch ex As Exception
                    TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
                End Try
                For Each data As ReflowData In ReFlowDataList
                    If data.StartTime <> "" And data.StopTime = "" Then
                        data.LotStatus = _StatusLot.LotStop
                    End If
                Next
                UpdateDisplay(ReFlowDataList)
                'If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                '    m_SelfData.LotStatus = _StatusLot.LotStop
                '    UpdateDisplay()
                'End If

            Case "SC" 'SC,AlarmNo
                For Each data As ReflowData In ReFlowDataList
                    If data.StartTime <> "" And data.StopTime = "" Then
                        Try
                            Dim AlarmNo As String = strText(1).Trim
                            Dim AlarmID As String = ""

                            'UpdateAlarm(data.LotNo, AlarmNo, data.Package)
                            'UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.Pause, c_Log)
                            Try
                                c_ServiceiLibrary.MachineAlarm(data.LotNo, My.Settings.MCNo, data.OpNo, AlarmNo, AlarmState.SET)
                                c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Pause)
                            Catch ex As Exception
                                TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
                            End Try

                            AlarmID = SearchAlarmID(AlarmNo)
                            If AlarmID <> "" Then
                                AddAlarmInfoToTable(AlarmNo, data.LotNo, data.McNo)
                                data.AlarmTotal += 1
                            End If

                            data.LotStatus = _StatusLot.LotAlarm

                        Catch ex As Exception
                            addlogfile("SC : " & ex.Message)
                        End Try
                    End If
                Next
                UpdateDisplay(ReFlowDataList)

                'If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                '    Try
                '        Dim AlarmNo As String = strText(1).Trim
                '        Dim AlarmID As String = ""
                '        Dim LotNo As String = m_SelfData.LotNo
                '        Dim McNo As String = "RF-" & m_SelfData.McNo

                '        UpdateAlarm(LotNo, AlarmNo, m_SelfData.Package)
                '        UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.Pause, c_Log)

                '        AlarmID = SearchAlarmID(AlarmNo)
                '        If AlarmID <> "" Then
                '            AddAlarmInfoToTable(AlarmNo, LotNo, McNo)
                '            m_SelfData.AlarmTotal += 1
                '        End If

                '        m_SelfData.LotStatus = _StatusLot.LotAlarm
                '        UpdateDisplay()
                '    Catch ex As Exception
                '        addlogfile("SC : " & ex.Message)
                '    End Try
                'End If
            Case "SD" 'SD,LotNo,Good(frm)
                For Each data As ReflowData In ReFlowDataList
                    If data.StopTime = "" And data.StartTime <> "" And data.LotNo = strText(1).Trim Then
                        Try
                            Dim Output As Integer = CInt(CLng("&H" & strText(2).Trim) * data.Pcs_frm)
                            data.Output = Output

                            If data.LotStatus <> _StatusLot.LotStart Then
                                data.LotStatus = _StatusLot.LotStart
                            End If

                            'If data.LotSetOfSending = False Then
                            '    data.LotSetOfSending = True
                            '    LotSetTdc(data.McNo, data.LotNo, CDate(data.StartTime), data.OpNo)
                            'End If
                            ClearAlarmInfoTable(data.LotNo, data.McNo)

                        Catch ex As Exception
                            addlogfile("SD : " & ex.Message)
                        End Try
                    End If
                Next
                UpdateDisplay(ReFlowDataList)
                'If m_SelfData.StopTime = "" And m_SelfData.StartTime <> "" Then
                '    Try

                '        Dim Output As Integer = CInt(CLng("&H" & strText(1).Trim) * m_SelfData.Pcs_frm)

                '        m_SelfData.Output = Output

                '        If m_SelfData.LotStatus <> _StatusLot.LotStart Then
                '            m_SelfData.LotStatus = _StatusLot.LotStart
                '        End If

                '        If m_SelfData.LotSetOfSending = False Then
                '            m_SelfData.LotSetOfSending = True
                '            LotSetTdc("RF-" & m_SelfData.McNo, m_SelfData.LotNo, CDate(m_SelfData.StartTime), m_SelfData.OpNo)
                '            'Send TDC
                '            'SyncLock m_Locker
                '            '    Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
                '            '    m_LotSetQueue.Enqueue(strLotSetData)
                '            'End SyncLock

                '            'If bgTDC.IsBusy = False Then
                '            '    lbLotSetEnd.BackColor = Color.Lime
                '            '    bgTDC.RunWorkerAsync()
                '            'End If

                '            SaveBackup()
                '        End If

                '        ClearAlarmInfoTable(m_SelfData.LotNo, "RF-" & m_SelfData.McNo)
                '        UpdateDisplay()

                '    Catch ex As Exception
                '        addlogfile("SD : " & ex.Message)
                '    End Try
                'End If


            Case "LE" 'LE,LotNo,Good(frm),NORMAL or CONFIRM
                Try
                    'RegularExpressions
                    'Dim text As String = "sdsadd@sflA.net"
                    'Dim reg As Regex = New Regex("[abc]{2}[@]{1}")
                    'Dim match As Match = reg.Match(text)
                    'If match.Success Then

                    'End If

                    If strText.Length <> 4 OrElse strText(1).Trim.Length <> 10 OrElse strText(1).Contains(Chr(0)) Then
                        Exit Sub
                    End If
                    SendTheMessage(My.Settings.IP, "CP" & vbCr, My.Settings.MCNo)
                    If Not EndLot(strText(1), strText(2), True) Then
                        Exit Select
                    End If

                    'Dim data As ReflowData = SearchReflowData(strText(1))
                    'If data.StopTime <> "" OrElse (data.StartTime = "" AndAlso data.StopTime = "") Then
                    '    Exit Select
                    'End If

                    'Dim GoodPCS As Integer = CInt(CLng("&H" & strText(2)) * CDbl(data.Pcs_frm))
                    ''Dim LotEndStatus As String = strText(2)

                    'If GoodPCS > data.Input Then 'Output มาเกิน ทำให้มันค่าเท่ากับ Input
                    '    GoodPCS = data.Input
                    'End If

                    'data.Output = GoodPCS
                    'data.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    'data.LotStatus = _StatusLot.LotEnd
                    'data.NGQty = CInt(data.Input) - CInt(data.Output)

                    'If CInt(data.NGQty) < 0 Then
                    '    data.NGQty = 0
                    'ElseIf CInt(data.NGQty) > CInt(data.Input) Then
                    '    data.NGQty = 0
                    'End If

                    ''TDC เก็บข้อมูลแล้วส่ง TDC
                    'Try
                    '    LotEndTdc(data.McNo, data.LotNo, CDate(data.StopTime), data.Output, data.NGQty, data.OpNo)
                    'Catch ex As Exception
                    '    addlogfile("LE TDC LOTEND: " & ex.Message)
                    'End Try
                    'Try
                    '    SaveLotEndToDbx(data)
                    'Catch ex As Exception
                    '    addlogfile("LE Dbx : " & ex.Message)
                    'End Try

                    'Try
                    '    SaveAlarmInfoToDbx(data)
                    'Catch ex As Exception
                    '    addlogfile("LE Alm : " & ex.Message)
                    'End Try

                    'UpdateDisplay(ReFlowDataList, False)
                    'ReFlowDataList.Remove(data)
                    'SaveBackupList(ReFlowDataList)
                Catch ex As Exception
                    addlogfile("LE : " & ex.Message)
                End Try

        End Select
    End Sub

    Private Function EndLot(LotNo As String, good As String, Optional isHexadecimal As Boolean = False, Optional endMode As EndMode = EndMode.Normal) As Boolean
        Dim data As ReflowData = SearchReflowData(LotNo)
        If data Is Nothing Then
            MessageBox.Show("ไม่พบข้อมูลของ LotNo:" & LotNo)
            Return False
        End If
        If data.StopTime <> "" OrElse (data.StartTime = "" AndAlso data.StopTime = "") Then
            Return False
        End If

        Dim GoodPCS As Integer = CInt(CLng("&H" & good) * CDbl(data.Pcs_frm))
        If isHexadecimal Then
            GoodPCS = CInt(CLng("&H" & good) * CDbl(data.Pcs_frm))
        Else
            GoodPCS = CInt(good)
        End If

        'Dim LotEndStatus As String = strText(2)

        If GoodPCS > data.Input Then 'Output มาเกิน ทำให้มันค่าเท่ากับ Input
            GoodPCS = data.Input
        End If

        data.Output = GoodPCS
        data.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
        data.LotStatus = _StatusLot.LotEnd
        data.NGQty = CInt(data.Input) - CInt(data.Output)

        If CInt(data.NGQty) < 0 Then
            data.NGQty = 0
        ElseIf CInt(data.NGQty) >= CInt(data.Input) Then
            data.NGQty = 0
        End If


        'If data.LotSetOfSending = False Then
        '    Try
        '        data.LotSetOfSending = True
        '        LotSetTdc(data.McNo, data.LotNo, CDate(data.StartTime), data.OpNo)

        '        ''Send TDC
        '        'SyncLock m_Locker
        '        '    Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
        '        '    m_LotSetQueue.Enqueue(strLotSetData)
        '        'End SyncLock
        '        'If bgTDC.IsBusy = False Then
        '        '    lbLotSetEnd.BackColor = Color.Lime
        '        '    bgTDC.RunWorkerAsync()
        '        'End If

        '    Catch ex As Exception
        '        addlogfile("LE TDC LOTSET: " & ex.Message)
        '    End Try
        'End If

        'TDC เก็บข้อมูลแล้วส่ง TDC
        Try
            LotEndTdc(data.McNo, data.LotNo, CDate(data.StopTime), data.Output, data.NGQty, data.OpNo, endMode)

        Catch ex As Exception
            addlogfile("LE TDC LOTEND: " & ex.Message)
        End Try
        'เซฟข้อมูลลงใน DBx
        ' SaveBackup()

        Try
            SaveLotEndToDbx(data)
            'SaveReflowDataTableXml()
        Catch ex As Exception
            addlogfile("LE Dbx : " & ex.Message)
        End Try

        Try
            SaveAlarmInfoToDbx(data)
        Catch ex As Exception
            addlogfile("LE Alm : " & ex.Message)
        End Try

        UpdateDisplay(ReFlowDataList, False)
        ReFlowDataList.Remove(data)
        SaveBackupList(ReFlowDataList)
        Return True
    End Function
    Enum StatusLot
        None
        Load
        Remove
    End Enum
    Private Sub ClearText()
        LabelNextLot.Text = "-"
        TextBoxNotificationNextLot.Text = "-"
        PanelNextLot.BackColor = Color.Silver

        lbOpNo1.Text = "-"
        lbLotNo1.Text = "-"
        lbPackage1.Text = "-"
        lbDevice1.Text = "-"
        lbInput1.Text = "-"
        PanelLot1.BackColor = Color.Silver
        lbStart1.BackColor = Color.Transparent
        lbOutput1.Text = "-"
        lbStart1.Text = "-"
        lbStop1.Text = "-"
        TextBoxNotification1.Text = "-"
        LbGroup1.Text = "-"
        LbMagazine1.Text = "-"

        lbOpNo2.Text = "-"
        lbLotNo2.Text = "-"
        lbPackage2.Text = "-"
        lbDevice2.Text = "-"
        lbInput2.Text = "-"
        PanelLot2.BackColor = Color.Silver
        lbStart2.BackColor = Color.Transparent
        lbOutput2.Text = "-"
        lbStart2.Text = "-"
        lbStop2.Text = "-"
        TextBoxNotification2.Text = "-"
        LbGroup2.Text = "-"
        LbMagazine2.Text = "-"

    End Sub
    Public Sub UpdateDisplay(dataList As List(Of ReflowData), Optional backup As Boolean = True)
        'lbMC.Text = My.Settings.MCNo 'data.McNo
        'lbIp.Text = My.Settings.IP ' data.IPA
        If dataList Is Nothing Then
            Exit Sub
        End If
        LabelNextLot.Text = "-"
        TextBoxNotificationNextLot.Text = "-"
        PanelNextLot.BackColor = Color.Silver
        For Each data As ReflowData In dataList

            'lbMC.Text = My.Settings.MCNo 'data.McNo
            'lbIp.Text = My.Settings.IP ' data.IPA
            If (data.StartTime Is Nothing) Then
                LabelNextLot.Text = data.LotNo
                If Not data.LotInform Is Nothing Then
                    TextBoxNotificationNextLot.Text = data.LotInform
                Else
                    TextBoxNotificationNextLot.Text = "-"
                End If
                PanelNextLot.BackColor = Color.LawnGreen
            ElseIf (lbLotNo1.Text = "-" OrElse lbStop1.Text <> "-" Or lbLotNo1.Text = data.LotNo) And lbLotNo2.Text <> data.LotNo Then
                If Not data.OpNo Is Nothing Then
                    lbOpNo1.Text = data.OpNo
                End If
                If Not data.LotNo Is Nothing Then
                    lbLotNo1.Text = data.LotNo
                End If
                If Not data.Package Is Nothing Then
                    lbPackage1.Text = data.Package
                Else
                    lbPackage1.Text = "-"
                End If
                If Not data.Device Is Nothing Then
                    lbDevice1.Text = data.Device
                Else
                    lbDevice1.Text = "-"
                End If

                lbInput1.Text = CStr(data.Input)
                If (data.Output > 0) Then
                    PanelLot1.BackColor = Color.LawnGreen
                End If
                lbOutput1.Text = CStr(data.Output)

                If Not data.StartTime Is Nothing Then
                    lbStart1.Text = data.StartTime
                Else
                    lbStart1.Text = "-"
                End If
                If Not data.StopTime Is Nothing Then
                    lbStop1.Text = data.StopTime
                    PanelLot1.BackColor = Color.Silver
                Else
                    lbStop1.Text = "-"
                End If
                If Not data.LotInform Is Nothing Then
                    TextBoxNotification1.Text = data.LotInform
                Else
                    TextBoxNotification1.Text = "-"
                End If
                If Not data.Group Is Nothing Then
                    LbGroup1.Text = data.Group
                Else
                    LbGroup1.Text = "-"
                End If
                If Not data.MagazineNo Is Nothing Then
                    LbMagazine1.Text = data.MagazineNo
                Else
                    LbMagazine1.Text = "-"
                End If



                Select Case data.LotStatus
                    Case _StatusLot.LotSetup
                        lbStart1.BackColor = Color.Transparent
                    Case _StatusLot.LotStart
                        lbStart1.BackColor = Color.Lime
                    Case _StatusLot.LotAlarm
                'lbStart.BackColor = Color.Red
                    Case _StatusLot.LotEnd
                        lbStart1.BackColor = Color.Transparent
                End Select
            Else
                If Not data.OpNo Is Nothing Then
                    lbOpNo2.Text = data.OpNo
                Else
                    lbOpNo2.Text = "-"
                End If
                If Not data.LotNo Is Nothing Then
                    lbLotNo2.Text = data.LotNo
                Else
                    lbLotNo2.Text = "-"
                End If
                If Not data.Package Is Nothing Then
                    lbPackage2.Text = data.Package
                Else
                    lbPackage2.Text = "-"
                End If
                If Not data.Device Is Nothing Then
                    lbDevice2.Text = data.Device
                Else
                    lbDevice2.Text = "-"
                End If

                lbInput2.Text = CStr(data.Input)
                If (data.Output > 0) Then
                    PanelLot2.BackColor = Color.LawnGreen
                End If
                lbOutput2.Text = CStr(data.Output)

                If Not data.StartTime Is Nothing Then
                    lbStart2.Text = data.StartTime
                Else
                    lbStart2.Text = "-"
                End If
                If Not data.StopTime Is Nothing Then
                    lbStop2.Text = data.StopTime
                    PanelLot2.BackColor = Color.Silver
                Else
                    lbStop2.Text = "-"
                End If
                If Not data.LotInform Is Nothing Then
                    TextBoxNotification2.Text = data.LotInform
                Else
                    TextBoxNotification2.Text = "-"
                End If
                If Not data.Group Is Nothing Then
                    LbGroup2.Text = data.Group
                Else
                    LbGroup2.Text = "-"
                End If
                If Not data.MagazineNo Is Nothing Then
                    LbMagazine2.Text = data.MagazineNo
                Else
                    LbMagazine2.Text = "-"
                End If

                Select Case data.LotStatus
                    Case _StatusLot.LotSetup
                        lbStart2.BackColor = Color.Transparent
                    Case _StatusLot.LotStart
                        lbStart2.BackColor = Color.Lime
                    Case _StatusLot.LotAlarm
            'lbStart.BackColor = Color.Red
                    Case _StatusLot.LotEnd
                        lbStart2.BackColor = Color.Transparent
                End Select
            End If

        Next
        If backup = True Then
            SaveBackupList(dataList)
        End If


    End Sub

#End Region

#Region "==========================================Button==============================================="

    'Private Sub BtEndLot_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtEndLot.MouseDown
    '    BtEndLot.BackColor = Color.Lime
    'End Sub

    'Private Sub BtEndLot_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtEndLot.MouseUp
    '    BtEndLot.BackColor = System.Drawing.SystemColors.Control
    'End Sub



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
        'CountRowData()
    End Sub

    Private Sub TPMaintenance_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TPMaintenance.Enter
        ' CountRowData()
    End Sub

    'Sub CountRowData()
    '    Try
    '        Dim countRow As Integer = 0
    '        For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
    '            If row.IsLotEndTimeNull = False Then
    '                countRow += 1
    '            End If
    '        Next
    '        LbCounterFile.Text = CStr(countRow)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub



    Private Sub APCSClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APCSClose.Click
        If MessageBox.Show("ต้องการปิดโปรแกรม ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            SaveAlarmInfo()
            SaveAlarmTableXML()
            SaveReflowDataTableXml()
            SaveBackup()
            Me.Close()
        End If
    End Sub

    Private Sub BtEndLot2_Click(sender As Object, e As EventArgs) Handles BtEndLot2.Click

        'If lbLotNo2.Text.Length <> 10 Then
        '    Exit Sub
        'End If
        'EndLot(lbLotNo2.Text, lbOutput2.Text)
        Try
            If lbLotNo2.Text.Length <> 10 Then
                Exit Sub
            End If
            If Not IsNumeric(lbInput2.Text) Then
                Exit Sub
            End If

            If MessageBox.Show("คุณต้องการ Manual End ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim _frmEndMan As frmEndManual = New frmEndManual(CInt(lbInput2.Text))
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
                EndLot(lbLotNo2.Text, InputGoodTotal)
            End If
        Catch ex As Exception
            MessageBox.Show("BtEndLot_Click :" & ex.Message.ToString())
        End Try

    End Sub
    Private Sub BtEndLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEndLot.Click
        'Dim tmpTime As String = Format(Now, "yyyy/MM/dd HH:mm:ss")


        'Dim strData As String = " Rev :" & "000xxx00x"
        'If Not frmLog Is Nothing Then
        '    frmLog.SendLog(tmpTime & " " & "RF-00" & " " & strData & vbCrLf)
        'End If
        Try
            If lbLotNo1.Text.Length <> 10 Then
                Exit Sub
            End If
            If Not IsNumeric(lbInput1.Text) Then
                Exit Sub
            End If

            If MessageBox.Show("คุณต้องการ Manual End ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim _frmEndMan As frmEndManual = New frmEndManual(CInt(lbInput1.Text))
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
                EndLot(lbLotNo1.Text, InputGoodTotal)
            End If
        Catch ex As Exception
            MessageBox.Show("BtEndLot_Click :" & ex.Message.ToString())
        End Try


        'If lbStart.Text <> "" And lbStop.Text = "" Then
        '    If MessageBox.Show("คุณต้องการ Manual End ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

        '        Dim _frmEndMan As frmEndManual = New frmEndManual(Me)
        '        Dim InputGoodTotal As String
        '        If _frmEndMan.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            InputGoodTotal = _frmEndMan.tbPcs.Text
        '        Else
        '            Exit Sub
        '        End If

        '        If InputGoodTotal = "" Or IsNumeric(InputGoodTotal) = False Or InputGoodTotal = "0" Then
        '            AlarmMessage("Good Pcs ไม่ถูกต้องกรุณาตรวจสอบ")
        '            Exit Sub
        '        End If


        '        Try
        '            m_SelfData.Output = CInt(InputGoodTotal)
        '            m_SelfData.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            m_SelfData.LotStatus = _StatusLot.LotEnd
        '            UpdateDisplay()
        '            SaveBackup()

        '            If m_SelfData.LotSetOfSending = False Then
        '                Try
        '                    m_SelfData.LotSetOfSending = True
        '                    'Send TDC
        '                    SyncLock m_Locker
        '                        Dim strLotSetData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & m_SelfData.StartTime & "," & m_SelfData.OpNo & "," & m_SelfData.LotStartMode
        '                        m_LotSetQueue.Enqueue(strLotSetData)
        '                    End SyncLock
        '                    If bgTDC.IsBusy = False Then
        '                        lbLotSetEnd.BackColor = Color.Lime
        '                        bgTDC.RunWorkerAsync()
        '                    End If
        '                Catch ex As Exception
        '                    addlogfile("BtEndLot TDC LOTSET: " & ex.Message)
        '                End Try
        '            End If

        '            'TDC เก็บข้อมูลแล้วส่ง TDC
        '            Try
        '                If radResetEnd.Checked Then
        '                    m_SelfData.LotEndMode = _TDCMode.Reload
        '                ElseIf radAccuEnd.Checked Then
        '                    m_SelfData.LotEndMode = _TDCMode.ReInput
        '                Else
        '                    m_SelfData.LotEndMode = _TDCMode.NormalEnd
        '                End If

        '                Dim tmpData As String = "RF-" & m_SelfData.McNo & "," & m_SelfData.LotNo & "," & CDate(m_SelfData.StopTime) & "," & CInt(m_SelfData.Output) & "," & m_SelfData.NGQty & "," & m_SelfData.OpNo & "," & m_SelfData.LotEndMode
        '                SyncLock m_Locker
        '                    m_LotEndQueue.Enqueue(tmpData)
        '                End SyncLock

        '                If bgTDC.IsBusy = False Then
        '                    bgTDC.RunWorkerAsync()
        '                End If

        '            Catch ex As Exception
        '                addlogfile("BtEndLot TDC : " & ex.Message)
        '            End Try
        '            'คืนค่าโหมดของ TDC
        '            'If Not radNormal.Checked Then radNormal.Checked = True '//783
        '            If Not radNormalEnd.Checked Then radNormalEnd.Checked = True '//783
        '            'เซฟข้อมูลลง Dbx

        '            Try
        '                SaveLotEndToDbx()
        '                SaveReflowDataTableXml()
        '            Catch ex As Exception
        '                addlogfile("LE Dbx : " & ex.Message)
        '            End Try
        '            'เซฟ Alarm ลง DBx
        '            Try
        '                SaveAlarmInfoToDbx()
        '            Catch ex As Exception
        '                addlogfile("LE Alm : " & ex.Message)
        '            End Try

        '        Catch ex As Exception
        '            addlogfile("BtEndLot : " & ex.Message)
        '        End Try


        '    End If
        'Else
        '    MsgBox("MCNo " & lbMC.Text & " ไม่สามารถ End Manual ได้")
        'End If
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

    Private Sub SaveAlarmInfoToDbx(data As ReflowData)
        If My.Computer.Network.Ping("172.16.0.102") = False Then
            Exit Sub
        End If

        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each DataRow As DBxDataSet.ReflowAlarmInfoRow In DBxDataSet.ReflowAlarmInfo.Rows
            Try
                If DataRow.MCNo = data.McNo AndAlso DataRow.IsClearTimeNull = False Then
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
    Private Sub SaveBackupList(RfDataList As List(Of ReflowData))
        If RfDataList Is Nothing Then
            Exit Sub
        End If
        'Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflowList.xml"
        'Using fw As New IO.FileStream(pathData, FileMode.Create)
        '    Dim bs As New SoapFormatter
        '    bs.Serialize(fw, RfDataList)
        'End Using

        Try
            Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflowList.xml"
            Using fs As New System.IO.FileStream(pathData, System.IO.FileMode.Create)
                Dim bs = New XmlSerializer(RfDataList.GetType())
                bs.Serialize(fs, RfDataList)
            End Using
        Catch ex As Exception
            ' c_Log.ConnectionLogger.Write(0, "XmlSave", "OUT", "", "", 0, "XmlSave", ex.Message.ToString, "")
        End Try

    End Sub
    Private Function LoadBackupList() As List(Of ReflowData)
        Try
            Dim RfDataList As New List(Of ReflowData)
            Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflowList.xml"
            If (File.Exists(pathData)) Then
                Using fs As New System.IO.FileStream(pathData, System.IO.FileMode.Open)
                    Dim bs = New XmlSerializer(RfDataList.GetType())
                    RfDataList = CType(bs.Deserialize(fs), List(Of ReflowData))
                End Using
                ' GetInfoPro(Data.MachineNo, Data.LotNo, Data.UserCode)

            End If
            Return RfDataList
        Catch ex As Exception
            Return Nothing
            ' c_Log.ConnectionLogger.Write(0, "XmlLoad", "OUT", "", "", 0, "XmlLoad", ex.Message.ToString, "")
        End Try

    End Function
    'Private Function LoadBackupList(RfDataList As List(Of ReflowData)) As List(Of ReflowData)
    '    Dim pathData As String = My.Application.Info.DirectoryPath & "\ParameterReflowList.xml"
    '    If File.Exists(pathData) = False Then
    '        MsgBox("ไม่มีไฟล์ ParameterReflowList.xml")
    '        Return Nothing
    '    End If

    '    Using fr As New IO.FileStream(pathData, FileMode.Open)
    '        Dim bs As New SoapFormatter
    '        RfDataList = CType(bs.Deserialize(fr), List(Of ReflowData))
    '    End Using
    '    Return RfDataList
    'End Function
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
    Private Sub LoadDbx(data As ReflowData)
        Dim ReflowAdapter As DBxDataSetTableAdapters.ReflowDataTableAdapter = New DBxDataSetTableAdapters.ReflowDataTableAdapter
        'dbx.ReflowData = ReflowAdapter.GetReflowData(data.LotNo, data.McNo, CDate(data.StartTime))
        ReflowDataTableAdapter.FillReflowData(DBxDataSet.ReflowData, data.LotNo, data.McNo, CDate(data.StartTime))

    End Sub
    Private Sub SaveLotStartToDbx(data As ReflowData)
        Try

            Dim strDataRow As DBxDataSet.ReflowDataRow = DBxDataSet.ReflowData.NewReflowDataRow
            strDataRow.LotNo = data.LotNo
            strDataRow.MCNo = data.McNo
            strDataRow.LotStartTime = CDate(data.StartTime)
            strDataRow.OPNo = data.OpNo
            strDataRow.InputQty = data.Input    '130807   Change data type of dataset
            strDataRow.MagazineNo = data.MagazineNo
            strDataRow.TemperatureGroup = data.Group
            DBxDataSet.ReflowData.Rows.Add(strDataRow)

            Dim RemoveList As List(Of DataRow) = New List(Of DataRow)
            For Each StartRow As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                Try
                    If strDataRow.LotNo = data.LotNo AndAlso StartRow.IsLotEndTimeNull = True Then
                        ReflowDataTableAdapter.Update(StartRow)
                    End If
                Catch ex As Exception
                    addlogfile("SaveLotStartToDbx StartRow:" & strDataRow.LotNo & " " & ex.Message.ToString)
                End Try
            Next

        Catch ex As Exception
            addlogfile("SaveLotStartToDbx :" & ex.Message.ToString)
        End Try
        'Try
        '    Dim strDataRow As DBxDataSet.ReflowDataRow = DBxDataSet.ReflowData.NewReflowDataRow
        '    strDataRow.LotNo = m_SelfData.LotNo
        '    strDataRow.MCNo = "RF-" & m_SelfData.McNo
        '    strDataRow.LotStartTime = CDate(m_SelfData.StartTime)
        '    strDataRow.OPNo = m_SelfData.OpNo
        '    strDataRow.InputQty = m_SelfData.Input    '130807   Change data type of dataset
        '    strDataRow.MagazineNo = m_SelfData.MagazineNo
        '    strDataRow.TemperatureGroup = m_SelfData.Group
        '    DBxDataSet.ReflowData.Rows.Add(strDataRow)

        '    Dim RemoveList As List(Of DataRow) = New List(Of DataRow)
        '    For Each StartRow As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
        '        Try
        '            If strDataRow.LotNo = m_SelfData.LotNo AndAlso StartRow.IsLotEndTimeNull = True Then
        '                ReflowDataTableAdapter.Update(StartRow)
        '            End If
        '        Catch ex As Exception
        '            addlogfile("SaveLotStartToDbx StartRow:" & strDataRow.LotNo & " " & ex.Message.ToString)
        '        End Try
        '    Next

        'Catch ex As Exception
        '    addlogfile("SaveLotStartToDbx :" & ex.Message.ToString)
        'End Try
    End Sub
    Private Sub SaveLotEndToDbx(data As ReflowData)
        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each tmpDataRow As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
            If tmpDataRow.LotNo = data.LotNo AndAlso tmpDataRow.LotStartTime = CDate(data.StartTime) Then
                tmpDataRow.OutputQty = data.Output
                tmpDataRow.LotEndTime = CDate(data.StopTime)
                tmpDataRow.AlarmTotal = CShort(data.AlarmTotal)
                tmpDataRow.Remark = data.Remark

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
        Dim Data As String = "LR,9999A0005V,SSOP-B28W ,BD3805F1234(BW)        ,007441,07D8,0000000,001E,B." & vbCr
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
        ' lbLotSetEnd.BackColor = Color.Tomato
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
        tmpStr = "MCNo=" & My.Settings.MCNo
        tmpStr = tmpStr & "&LotNo=" & lbLotNo1.Text
        If lbStart1.Text <> "" AndAlso lbStop1.Text = "" Then
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
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainPMlogin.asp?" & "MCNo=" & lbMC.Text, vbNormalFocus)

    End Sub

    Private Sub SearchToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem3.Click
        Using frmSeachData As New frmSearch(Me)
            frmSeachData.ShowDialog()
            frmSeachData.Focus()
        End Using
        'Dim frmSeachData As frmSearch
        'If frmSeachData Is Nothing OrElse frmSeachData.Visible = False Then
        '    frmSeachData = New frmSearch(Me)
        'End If
        'frmSeachData.Show()
        'frmSeachData.Focus()
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
        '   lbLotReq.BackColor = Color.Tomato
    End Sub

    Private Sub WIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIPToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/reflowwip/", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function LotRequestTDC(ByVal LotNo As String, ByVal rm As RunModeType, OpNo As String) As TDCInfo
        Dim apcsInfo As New TDCInfo
        Dim mc As String = My.Settings.MCNo
        Dim ap As New DBxDataSetTableAdapters.QueriesTableAdapter
        ' m_SelfData.Package = ap.SearchPackage(LotNo)
        Dim data As ReflowData = SearchReflowData(LotNo)
        'UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.LotSetUp, c_Log)
        Try
            c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Setup)
        Catch ex As Exception
            TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
        End Try

        'If c_ApcsProService.CheckPackageEnable(data.Package, c_Log) AndAlso c_ApcsProService.CheckLotisExist(LotNo, c_Log) Then
        '    If Not SetUpApcsPro(mc, LotNo, OpNo) Then
        '        apcsInfo.ErrorMessage = c_LotUpdateInfo.ErrorMessage
        '        apcsInfo.ErrorCode = c_LotUpdateInfo.ErrorNo.ToString()
        '        apcsInfo.IsPass = False
        '        Return apcsInfo
        '    End If
        'End If
        Try
            'If c_ServiceiLibrary.CheckLotApcsProManual(LotNo, mc, data.Package).IsPass Then
            Dim result As SetupLotResult = c_ServiceiLibrary.SetupLot(LotNo, mc, OpNo, "PL", "")
            If result.IsPass = SetupLotResult.Status.NotPass Then
                MessageBoxDialog.ShowMessage(result.FunctionName, result.Cause, result.Type.ToString(), result.ErrorNo)
                apcsInfo.ErrorMessage = result.Cause
                apcsInfo.IsPass = False
                Return apcsInfo
            ElseIf (result.IsPass = SetupLotResult.Status.Warning) Then
                MessageBoxDialog.ShowMessage(result.FunctionName, result.Cause, result.Type.ToString(), result.ErrorNo)
            End If
            c_ApcsPro.Recipe = result.Recipe
            XmlSave(c_ApcsPro)
            'End If

        Catch ex As Exception
            TextBoxNotification1.Text = "SetupLot :" & ex.ToString()
        End Try
        apcsInfo.ErrorMessage = "00 : Run Normal"
        apcsInfo.IsPass = True
        Return apcsInfo

        'Dim res As TdcLotRequestResponse = m_TdcService.LotRequest(mc, LotNo, rm)

        'If res.HasError Then

        '    Using svError As ApcsWebServiceSoapClient = New ApcsWebServiceSoapClient
        '        If svError.LotRptIgnoreError(mc, res.ErrorCode) = False Then
        '            Dim li As Rohm.Apcs.Tdc.LotInfo = Nothing
        '            li = m_TdcService.GetLotInfo(LotNo, mc)
        '            c_dlg = New TdcAlarmMessageForm(res.ErrorCode, res.ErrorMessage, LotNo, li)
        '            c_dlg.Show()
        '            apcsInfo.ErrorMessage = res.ErrorCode & " : " & res.ErrorMessage
        '            apcsInfo.ErrorCode = res.ErrorCode
        '            apcsInfo.IsPass = False
        '            Return apcsInfo
        '        End If
        '    End Using
        '    apcsInfo.ErrorMessage = res.ErrorCode & " : " & res.ErrorMessage
        '    apcsInfo.IsPass = True
        '    Return apcsInfo
        'Else

        '    apcsInfo.ErrorMessage = "00 : Run Normal"
        '    apcsInfo.IsPass = True
        '    Return apcsInfo
        'End If

    End Function

    Private Sub LotSetTdc(MCno As String, LotNo As String, StartTime As DateTime, OpNo As String)
        'Dim res As TdcResponse = m_TdcService.LotSet(MCno, LotNo, StartTime, OpNo, RunModeType.Normal)
        Dim data As ReflowData = SearchReflowData(LotNo)
        'GetInfoPro(MCno, LotNo, OpNo)

        Try

            Dim result As StartLotResult = c_ServiceiLibrary.StartLot(LotNo, MCno, OpNo, c_ApcsPro.Recipe)
            If Not result.IsPass Then
                TextBoxNotification1.Text = "StartLot :" & result.Cause
            End If
            c_ServiceiLibrary.OnlineStart(LotNo, MCno, OpNo)
        Catch ex As Exception
            TextBoxNotification1.Text = "StartLot,OnlineStart :" & ex.Message.ToString()
        End Try


        'If c_ApcsProService.CheckPackageEnable(data.Package, c_Log) AndAlso c_ApcsProService.CheckLotisExist(LotNo, c_Log) Then
        '    'OnlineStartLotPro(c_LotInfo, c_MachineInfo, OpNo)
        '    StartLotPro(c_LotInfo, c_MachineInfo, OpNo)
        'End If
        'UpdateMachineState(c_MachineInfo.Id, MachineProcessingState.Execute, c_Log)
        Try
            c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Execute)
        Catch ex As Exception
            TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
        End Try
    End Sub
    Private Sub LotEndTdc(McNo As String, LotNo As String, EndTime As DateTime, Good As Integer, Ng As Integer, OpNo As String, modeEnd As EndMode)
        'Dim res As TdcResponse = m_TdcService.LotEnd(McNo, LotNo, EndTime, Good, Ng, mode, OpNo)
        Dim data As ReflowData = SearchReflowData(LotNo)

        Try
            If modeEnd = EndMode.Normal Then
                Dim endLotResult = c_ServiceiLibrary.EndLotNoCheckLicenser(LotNo, McNo, OpNo, Good, Ng)
            Else
                Dim reinputLotResult = c_ServiceiLibrary.Reinput(LotNo, McNo, OpNo, Good, Ng, modeEnd)
            End If

            c_ServiceiLibrary.OnlineEnd(LotNo, McNo, OpNo, Good, Ng)
        Catch ex As Exception

        End Try

        Try
            c_ServiceiLibrary.UpdateMachineState(My.Settings.MCNo, iLibraryService.MachineProcessingState.Idle)
        Catch ex As Exception
            TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
        End Try
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            c_ServiceiLibrary.MachineOnlineState(My.Settings.MCNo, MachineOnline.Offline)

        Catch ex As Exception
            TextBoxNotification1.Text = "MachineOnlineState :" & ex.ToString()
        End Try
    End Sub
    Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
        Try
            If lbLotNo1.Text.Length <> 10 Then
                Exit Sub
            End If
            If Not IsNumeric(lbInput1.Text) Then
                Exit Sub
            End If

            If MessageBox.Show("คุณต้องการ Reload ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim _frmEndMan As frmEndManual = New frmEndManual(CInt(lbInput1.Text))
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
                EndLot(lbLotNo1.Text, InputGoodTotal, False, EndMode.AbnormalEndAccumulate)
                'If c_ApcsProService.CheckPackageEnable(lbPackage1.Text.Trim, c_Log) AndAlso c_ApcsProService.CheckLotisExist(lbLotNo1.Text.Trim, c_Log) Then
                '    Dim data As ReflowData = SearchReflowData(lbLotNo1.Text.Trim)
                '    'OnlineStartLotPro(c_LotInfo, c_MachineInfo, OpNo)
                '    Reload(0, 0, data.OpNo, data.McNo, lbLotNo1.Text.Trim)
                'End If
                'Try
                '    Dim data As ReflowData = SearchReflowData(lbLotNo1.Text.Trim)
                '    c_ServiceiLibrary.Reinput(data.LotNo, data.McNo, data.OpNo, 0, 0)
                'Catch ex As Exception

                'End Try

            End If
        Catch ex As Exception
            MessageBox.Show("BtEndLot_Click :" & ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonReload2_Click(sender As Object, e As EventArgs) Handles ButtonReload2.Click
        Try
            If lbLotNo2.Text.Length <> 10 Then
                Exit Sub
            End If
            If Not IsNumeric(lbInput2.Text) Then
                Exit Sub
            End If

            If MessageBox.Show("คุณต้องการ Reload ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim _frmEndMan As frmEndManual = New frmEndManual(CInt(lbInput2.Text))
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
                EndLot(lbLotNo2.Text, InputGoodTotal, False, EndMode.AbnormalEndAccumulate)
                'If c_ApcsProService.CheckPackageEnable(lbPackage2.Text.Trim, c_Log) AndAlso c_ApcsProService.CheckLotisExist(lbLotNo2.Text.Trim, c_Log) Then
                '    Dim data As ReflowData = SearchReflowData(lbLotNo2.Text.Trim)
                '    'OnlineStartLotPro(c_LotInfo, c_MachineInfo, OpNo)
                '    Reload(0, 0, data.OpNo, data.McNo, lbLotNo2.Text.Trim)
                'End If
                'Try
                '    Dim data As ReflowData = SearchReflowData(lbLotNo2.Text.Trim)
                '    c_ServiceiLibrary.Reinput(data.LotNo, data.McNo, data.OpNo, 0, 0)
                'Catch ex As Exception

                'End Try
            End If
        Catch ex As Exception
            MessageBox.Show("BtEndLot_Click :" & ex.Message.ToString())
        End Try
    End Sub
    Private Sub RemoveLotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveLotToolStripMenuItem.Click

        Dim toolMenu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(toolMenu.Owner, ContextMenuStrip)
        Dim name As String = menuStrip.SourceControl.Name
        Dim data As ReflowData = Nothing
        Select Case name
            Case "Panel1"
                data = SearchReflowData(lbLotNo1.Text.Trim)

            Case "Panel2"
                data = SearchReflowData(lbLotNo2.Text.Trim)
        End Select
        ReFlowDataList.Remove(data)
        ClearText()
        UpdateDisplay(ReFlowDataList)
    End Sub
#Region "APCS Pro"

    '#Region "Apcs_Pro LotSetUp"
    '    Private Function SetUpApcsPro(mcNo As String, lotNo As String, opNo As String) As Boolean
    '        'Auto Move TDC
    '        Try
    '            'm_TdcService.MoveLot(lotNo, mcNo, opNo, "0255")
    '            Dim userInf As UserInfo = GetInfoPro(mcNo, lotNo, opNo)

    '            If CheckPermissionApcsPro(mcNo, userInf, "PL-SetupLot", c_Log) Then
    '                LicenseWarning(userInf)
    '                ' lotInfo = c_ApcsProService.GetLotInfo(lotNo)
    '                If c_LotInfo Is Nothing Then
    '                    c_Log.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", lotNo)
    '                End If
    '                If c_MachineInfo Is Nothing Then
    '                    c_MachineInfo = c_ApcsProService.GetMachineInfo(mcNo, c_Log, Date.Now)
    '                End If
    '                If c_MachineInfo Is Nothing Then
    '                    c_Log.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", mcNo)
    '                End If
    '                'c_UserInfo = c_ApcsProService.GetUserInfo(opNo)
    '                'If c_UserInfo Is Nothing Then
    '                '    c_Log.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", opNo)
    '                'End If
    '                c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)
    '                c_LotUpdateInfo = c_ApcsProService.LotSetup(c_LotInfo.Id, c_MachineInfo.Id, c_UserInfo.Id, 0, "", 1, c_DateTimeInfo.Datetime, c_Log)
    '                If Not c_LotUpdateInfo.IsOk Then
    '                    c_Log.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '                    'MsgBox(c_LotUpdateInfo.ErrorMessage)
    '                    Return False
    '                End If
    '                c_ApcsPro.Recipe = c_LotUpdateInfo.Recipe1
    '                XmlSave(c_ApcsPro)
    '                Return True
    '                'Return SetupLotPro(mcNo, lotNo, opNo)
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            MsgBox("(SetUpApcsPro)" & ex.Message.ToString)
    '            c_Log.ConnectionLogger.Write(0, "SetupLotPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ex.Message.ToString, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)

    '            Return False
    '        End Try

    '    End Function
    '#Region "APCS Pro CheckPermission"
    '    Private Function CheckPermissionApcsPro(MCNo As String, userInfo As iLibrary.UserInfo, functionName As String, logger As Logger, Optional appName As String = "CellController") As Boolean
    '        c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(logger)
    '        Dim userPermission As CheckUserPermissionResult = c_ApcsProService.CheckUserPermission(userInfo, appName, functionName, logger, c_DateTimeInfo.Datetime)
    '        If Not userPermission.IsPass Then
    '            MsgBox(userPermission.ErrorMessage)
    '            Return False
    '        End If
    '        If Not c_ApcsProService.Check_PermissionMachinesByLMS(userInfo.Id, MCNo, logger) Then
    '            MsgBox("รหัส : " & userInfo.Code & " ไม่ผ่านการตรวจสอบในระบบ Licenser กรุณาติดต่อ ETG (MCNo : " & MCNo & ")")
    '            Return False
    '        End If
    '        If Not c_ApcsProService.Check_UserLotAutoMotive(userInfo, c_LotInfo, logger) Then
    '            MsgBox("รหัส : " & userInfo.Code & " User ที่ไม่ใช่ Automotive ไม่สามารถรัน Lot Automotive ได้ กรุณาติดต่อ ETG (Lot Automotive : " & MCNo & ")")
    '            Return False
    '        End If
    '        Return True
    '    End Function
    '#End Region
    '    Private Function GetInfoPro(MCNo As String, LotNo As String, OpNo As String) As UserInfo

    '        'c_Log = New Logger("1.0", MCNo)
    '        c_LotInfo = c_ApcsProService.GetLotInfo(LotNo, c_Log, Date.Now)
    '        If c_LotInfo Is Nothing Then
    '            c_Log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "lotInfo is Nothing", LotNo)
    '        End If
    '        If c_MachineInfo Is Nothing Then
    '            c_MachineInfo = c_ApcsProService.GetMachineInfo(MCNo, c_Log, Date.Now)
    '        End If
    '        If c_MachineInfo Is Nothing Then
    '            c_Log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "machineInfo is Nothing", MCNo)
    '        End If
    '        c_UserInfo = c_ApcsProService.GetUserInfo(OpNo, c_Log, Date.Now)
    '        If c_UserInfo Is Nothing Then
    '            c_Log.ConnectionLogger.Write(0, "GetInfoPro", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "userInfo is Nothing", OpNo)
    '        End If
    '        c_ApcsPro.LotNo = LotNo
    '        c_ApcsPro.MachineNo = MCNo
    '        c_ApcsPro.UserCode = OpNo

    '        XmlSave(c_ApcsPro)
    '        Return c_UserInfo
    '    End Function
    '#End Region

    '#Region "APCS Pro Function"
    '    Private Sub Reload(goodQty As Integer, ngQty As Integer, mcNo As String, opNo As String, lotNo As String)
    '        Try
    '            c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)
    '            c_LotUpdateInfo = c_ApcsProService.AbnormalLotEnd_BackToThe_BeforeProcess(c_LotInfo.Id, c_MachineInfo.Id, c_UserInfo.Id, False, goodQty, ngQty, 0, "", 1, c_DateTimeInfo.Datetime, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "Reload", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotEnd_BackToThe_BeforeProcess", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '                MsgBox(c_LotUpdateInfo.ErrorMessage)
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "Reload", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotEnd_BackToThe_BeforeProcess", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '        End Try
    '    End Sub
    '    Private Sub LotHold(mcNo As String, opNo As String, lotNo As String)
    '        Try
    '            c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)
    '            c_LotUpdateInfo = c_ApcsProService.AbnormalLotHold(c_LotInfo.Id, c_MachineInfo.Id, c_UserInfo.Id, 1, c_DateTimeInfo.Datetime, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "LotHold", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotHold", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '                MsgBox(c_LotUpdateInfo.ErrorMessage)
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "LotHold", "OUT", "CellCon", "iLibrary", 0, "AbnormalLotHold", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '        End Try
    '    End Sub
    '    Private Sub LotCancel(mcNo As String, opNo As String, lotNo As String)
    '        Try
    '            c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)
    '            c_LotUpdateInfo = c_ApcsProService.LotCancel(c_LotInfo.Id, c_MachineInfo.Id, c_UserInfo.Id, 1, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "LotCancel", "OUT", "CellCon", "iLibrary", 0, "LotCancel", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '                MsgBox(c_LotUpdateInfo.ErrorMessage)
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "LotCancel", "OUT", "CellCon", "iLibrary", 0, "LotCancel", ex.Message, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '        End Try

    '    End Sub
    '    'Private Sub ReInput(goodQty As Integer, ngQty As Integer, mcNo As String, opNo As String, lotNo As String)
    '    '    currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
    '    '    ResultApcsProService = c_ApcsProService.ReInput(lotInfo.Id, machineInfo.Id, userInfo.Id, goodQty, ngQty, 1, currentServerTime.Datetime, log)
    '    '    If Not ResultApcsProService.IsOk Then
    '    '        log.ConnectionLogger.Write(0, "ReInput", "OUT", "CellCon", "iLibrary", 0, "ReInput", ResultApcsProService.ErrorMessage, "LotNo:" & lotNo & ",MCNo:" & mcNo & ",OPNo:" & opNo)
    '    '        MsgBox(ResultApcsProService.ErrorMessage)
    '    '    End If
    '    'End Sub
    '#End Region


    '#Region "APCS Pro LotStart"
    '    Private Sub StartLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String)
    '        Try
    '            c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)

    '            c_LotUpdateInfo = c_ApcsProService.OnlineStart(c_LotInfo.Id, machineInfo.Id, c_UserInfo.Id, 0, CreateTableToXml(lotInfo.Name), 1, c_DateTimeInfo.Datetime, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            End If
    '            ' If packageEnable Then

    '            c_LotUpdateInfo = c_ApcsProService.LotStart(c_LotInfo.Id, machineInfo.Id, c_UserInfo.Id, 0, CreateTableToXml(lotInfo.Name), 1, c_ApcsPro.Recipe, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", c_LotUpdateInfo.ErrorMessage, "LotNo:" & c_LotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            End If

    '            ' Else
    '            'log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            'End If

    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "StartLotPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '        End Try
    '    End Sub

    '#End Region
    '#Region "APCS Pro LotEnd"
    '    Private Sub EndLotPro(lotInfo As iLibrary.LotInfo, machineInfo As MachineInfo, opNo As String, good As Integer, ng As Integer)
    '        Try
    '            'If packageEnable Then
    '            c_DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)

    '            c_LotUpdateInfo = c_ApcsProService.OnlineEnd(lotInfo.Id, machineInfo.Id, c_UserInfo.Id, False, good, ng, 0, CreateTableToXml(lotInfo.Name), 1, c_DateTimeInfo.Datetime, c_Log)
    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            End If

    '            c_LotUpdateInfo = c_ApcsProService.LotEnd(lotInfo.Id, machineInfo.Id, c_UserInfo.Id, False, good, ng, 0, CreateTableToXml(lotInfo.Name), 1, c_DateTimeInfo.Datetime, c_Log)

    '            If Not c_LotUpdateInfo.IsOk Then
    '                c_Log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", c_LotUpdateInfo.ErrorMessage, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            End If

    '            ' Else
    '            'log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "CheckPackageEnable", "CheckPackageEnable : " & packageEnable, "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '            ' End If

    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "EndLotPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ex.Message.ToString(), "LotNo:" & lotInfo.Name & ",MCNo:" & machineInfo.Name & ",OPNo:" & opNo)
    '        End Try
    '    End Sub

    '#End Region
    '#Region "Machine State and Machine OnlineState"
    '    Enum MachineProcessingState
    '        Idle = 1
    '        Ready = 3
    '        Execute = 4
    '        Pause = 5
    '        LotSetUp = 6
    '    End Enum
    '    Private Sub UpdateMachineState(machineID As Integer, runState As Integer, log As Logger, Optional userID As Integer = -1)
    '        Try
    '            c_ApcsProService.Update_MachineState(machineID, runState, userID, log)
    '        Catch ex As Exception
    '            TextBoxNotification1.Text = "Update_MachineState :" & ex.ToString()
    '        End Try

    '    End Sub
    '    Private Sub UpdateMachineOnlineState(machineID As String, onlineState As Integer, log As Logger, Optional userID As Integer = -1)
    '        Try
    '            c_MachineInfo = c_ApcsProService.GetMachineInfo(machineID, c_Log, Date.Now)
    '            c_ApcsProService.Update_MachineOnlineState(c_MachineInfo.Id, onlineState, userID, log)
    '        Catch ex As Exception
    '            TextBoxNotification1.Text = "Update_MachineOnlineState :" & ex.ToString()
    '        End Try

    '    End Sub
    '#End Region
    '#Region "ApcsPro Alarm"
    '    Private Sub UpdateAlarm(lotNo As String, errorCode As String, package As String)
    '        Try
    '            If c_ApcsProService.CheckPackageEnable(package, c_Log) Then
    '                If c_ApcsProService.CheckLotisExist(lotNo, c_Log) Then
    '                    Dim lotId(0) As Integer
    '                    lotId(0) = c_LotInfo.Id
    '                    Dim DateInfo As DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(c_Log)
    '                    Dim machineUpdateInfo As MachineUpdateInfo = c_ApcsProService.Update_ErrorHappenRecord(lotId, c_MachineInfo, c_UserInfo.Id, CInt(errorCode).ToString, DateInfo.Datetime, c_Log)

    '                End If

    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "UpdateAlarm", "OUT", "CellCon", "iLibrary", 0, "Update_ErrorHappenRecord", ex.Message.ToString(), "")
    '        End Try
    '    End Sub
    '#End Region
    '#Region "License"
    '    Private Sub LicenseWarning(user As UserInfo)
    '        Try
    '            If user.License(0).Is_Warning Then
    '                MsgBox("แจ้งเตือน!! รหัส :" & user.Code + Environment.NewLine + "License " & user.License(0).Name & Environment.NewLine & " ใกล้หมดอายุ กรุณาต่ออายุ License ที่ ETG " & Environment.NewLine & "วันหมดอายุ " & user.License(0).ExpireDate.ToString("yyyy/MM/dd"))
    '                'TextBoxNotification1.Text = "แจ้งเตือน!! รหัส :" & user.Code + Environment.NewLine + "License " & user.License(0).Name & Environment.NewLine & " ใกล้หมดอายุ กรุณาต่ออายุ License ที่ ETG " & Environment.NewLine & "วันหมดอายุ " & user.License(0).ExpireDate.ToString("yyyy/MM/dd")
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "LicenseWarning", "OUT", "CellCon", "iLibrary", 0, "user.License(0)", "", "")
    '        End Try

    '    End Sub
    '#End Region
    Private XmlPathDataApcsPro As String = My.Application.Info.DirectoryPath & "\ApcsPro.xml"
    Private Sub XmlSave(data As ApcsPro)
        Try
            Using fs As New System.IO.FileStream(XmlPathDataApcsPro, System.IO.FileMode.Create)
                Dim bs = New XmlSerializer(data.GetType())
                bs.Serialize(fs, data)
            End Using
        Catch ex As Exception
            'c_Log.ConnectionLogger.Write(0, "XmlSave", "OUT", "", "", 0, "XmlSave", ex.Message.ToString, "")
        End Try

    End Sub
    Private Sub XmlLoad(ByRef data As ApcsPro, type As Type)
        Try
            If (File.Exists(XmlPathDataApcsPro)) Then
                Using fs As New System.IO.FileStream(XmlPathDataApcsPro, System.IO.FileMode.Open)
                    Dim bs = New XmlSerializer(type)
                    data = CType(bs.Deserialize(fs), ApcsPro)
                End Using
                'GetInfoPro(data.MachineNo, data.LotNo, data.UserCode)

            End If
        Catch ex As Exception
            'c_Log.ConnectionLogger.Write(0, "XmlLoad", "OUT", "", "", 0, "XmlLoad", ex.Message.ToString, "")
        End Try

    End Sub
    Private Function CreateTableToXml(LotNo As String) As String
        Try
            Dim table As New DBxDataSet.ReflowDataDataTable
            Dim newRow As DBxDataSet.ReflowDataRow = table.NewReflowDataRow

            For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData
                If row.LotNo = LotNo Then
                    newRow.LotNo = row.LotNo
                    newRow.LotStartTime = row.LotStartTime
                    newRow.MCNo = row.MCNo
                    If Not row.IsAlarmTotalNull Then
                        newRow.AlarmTotal = row.AlarmTotal
                    End If
                    If Not row.IsInputQtyNull Then
                        newRow.InputQty = row.InputQty
                    End If

                    If Not row.IsLotEndTimeNull Then
                        newRow.LotEndTime = row.LotEndTime
                    End If
                    If Not row.IsMagazineNoNull Then
                        newRow.MagazineNo = row.MagazineNo
                    End If
                    If Not row.IsOutputQtyNull Then
                        newRow.OutputQty = row.OutputQty
                    End If
                    If Not row.IsOPNoNull Then
                        newRow.OPNo = row.OPNo
                    End If
                    If Not row.IsRemarkNull Then
                        newRow.Remark = row.Remark
                    End If
                    If Not row.IsTemperatureGroupNull Then
                        newRow.TemperatureGroup = row.TemperatureGroup
                    End If
                    Exit For
                End If
            Next
            table.Rows.Add(newRow)
            Return ToXml(table)

        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Function ToXml(source As Object) As String
        Try
            Dim xs As XmlSerializer = New XmlSerializer(source.GetType())
            Dim writer As StringWriter = New StringWriter()
            xs.Serialize(writer, source)
            Return writer.ToString()
        Catch ex As Exception
            Return ""
        End Try

    End Function
#Region "Apcs_Pro Valiable"
    ' Private ApcsProService As IApcsProService = New ApcsProService()
    'Private lotInfo As iLibrary.LotInfo
    'Private c_ApcsPro.machineInfo As MachineInfo
    'Private c_UserInfo As UserInfo
    'Private c_DateTimeInfo As DateTimeInfo
    'Private c_ApcsPro.log As New Logger
    'Private packageEnable As Boolean = False
    'Private c_LotUpdateInfo As LotUpdateInfo = Nothing
    'Private Recipe As String
    '' Private functionName As String


    'Private c_MachineInfo As MachineInfo
    'Private c_LotInfo As iLibrary.LotInfo
    'Private c_ApcsProService As IApcsProService = New ApcsProService()
    'Private c_UserInfo As UserInfo
    'Private c_Log As Logger = New Logger("1.0", My.Settings.MCNo)
    'Private c_DateTimeInfo As DateTimeInfo
    'Private c_LotUpdateInfoSetUp As LotUpdateInfo
    Private c_ApcsPro As New ApcsPro

    'Private c_LotUpdateInfo As LotUpdateInfo
    Private frmLog As frmCommLog
    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        frmLog = New frmCommLog()
        frmLog.Show()
    End Sub
    Private frmTestFunction As frmTestFunction
    Private Sub TestFuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFuToolStripMenuItem.Click
        frmTestFunction = New frmTestFunction(Me)
        frmTestFunction.Show()

    End Sub




#End Region

#End Region
End Class
