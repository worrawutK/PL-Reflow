Imports Rohm.Apcs.Tdc
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Threading
Imports iLibrary
Imports Rohm.Common.Logging
Public Class frmMain
    Private m_TdcService As TdcService
    Public CtlFocust As Control
    Dim LoginOP As String
    Dim DataQR As String
    Dim VersionCellCon As String = "Version : 151009"
    Dim _TB As TextBox

    Private m_LotSetQueue As Queue(Of String) = New Queue(Of String)
    Private m_LotEndQueue As Queue(Of String) = New Queue(Of String)
    Private m_Locker As Object = New Object()

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bgTDC.IsBusy = True Then
            MsgBox("ไม่สามารถติดโปรแกรมได้ โปรแกรมกำลังประมวลผลอยู่")
            e.Cancel = True
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_TdcService = TdcService.GetInstance()
        m_TdcService.LogFolder = "Log"
        LoadDataLotBin()
        CountRowData()
        lbVersion.Text = VersionCellCon
        Dim Folderlog As String = Path.Combine(My.Application.Info.DirectoryPath, "LOG")
        If Not Directory.Exists(Folderlog) Then
            Directory.CreateDirectory(Folderlog)
        End If
    End Sub

    Private Sub BtStartManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtStartManual.Click

        If FrmKeyBoard.Visible = True Then
            FrmKeyBoard.Hide()
            frmNumpad.Hide()
        End If

        If frmNumpad.Visible = True Then
            frmNumpad.Hide()
        End If

        If ConditiondatalotStart() = False Then
            Exit Sub
        End If
        Try
            ReflowData.McNo = CmbMCNO.Text
            ReflowData.LotNo = TbLotNo.Text.ToUpper
            ReflowData.Package = TbPackage.Text
            ReflowData.Device = TbDevice.Text
            ReflowData.OpNo = TbOPNO.Text.ToUpper
            ReflowData.MagazineNo = TbMagazineNo.Text.ToUpper
            ReflowData.Remark = CmbRemark.Text
            ReflowData.Input = TbInput.Text.ToString
            ReflowData.StartTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
            TbStartTime.Text = ReflowData.StartTime
            ReflowData.StopTime = ""
            ReflowData.Output = 0
            ReflowData.LotStatus = "LOTRUNNING"
            If CmbRemark.Text = "" Then
                CmbRemark.Text = "-"
            End If
            ReflowData.Remark = CmbRemark.Text

        Catch ex As Exception
            addErrLog("StartManual : " & ex.Message.ToString)
        End Try



        'Send TDC
        SyncLock m_Locker
            Dim strLotSetData As String = "RF-" & ReflowData.McNo & "," & ReflowData.LotNo & "," & ReflowData.StartTime & "," & ReflowData.OpNo
            m_LotSetQueue.Enqueue(strLotSetData)
        End SyncLock

        If bgTDC.IsBusy = False Then
            bgTDC.RunWorkerAsync()
        End If

        BtStartManual.Enabled = False
        BtClearManual.Enabled = False
        BtEndManual.Enabled = True

    End Sub

    Private Sub TbLotNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TbLotNo.Enter
        _TB = TbLotNo
    End Sub

    Private Sub TbLotNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbLotNo.KeyPress

        If e.KeyChar = Chr(13) AndAlso TbLotNo.Text.Length = 252 Then
            DataQR = TbLotNo.Text
            TbPackage.Text = Trim(DataQR.Substring(0, 10)).ToUpper
            TbDevice.Text = Trim(DataQR.Substring(10, 20)).ToUpper
            TbLotNo.Text = Trim(DataQR.Substring(30, 10)).ToUpper
            If IsNumeric(LoginOP) = True Then
                TbOPNO.Text = LoginOP
            End If
            ConditionInputData()
        ElseIf e.KeyChar = Chr(13) AndAlso TbLotNo.Text.Length <> 252 Then
            TbLotNo.Text = ""
            MsgBox("Work Slip ไม่ถูกต้องกรุณาตรวจสอบ")
        End If

    End Sub
    Sub ConditionInputData()
        If TbLotNo.Text = "" Then
            TbLotNo.Select()

        ElseIf TbOPNO.Text = "" Then
            TbOPNO.Focus()
            TbOPNO.Select()

        ElseIf TbMagazineNo.Text = "" Then
            TbMagazineNo.Focus()
            TbMagazineNo.Select()
        ElseIf TbInput.Text = "" Then
            TbInput.Focus()
            TbInput.Select()
        Else
            TbOutput.Focus()
            TbOutput.Select()
        End If

        If TbMagazineNo.Text <> "" Then
            TbMagazineNo.Text = TbMagazineNo.Text.ToUpper
        End If
    End Sub
    Public Sub CtrlClick_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TbDevice.Enter _
                                , TbMagazineNo.Enter, TbOPNO.Enter, TbPackage.Enter _
                                , TbInput.Enter, TbOutput.Enter, btKeyboard.Click


        BtEndManual.Enabled = True

        If TypeOf (sender) Is Button = True Then
            _TB = TbLotNo
        Else
            _TB = CType(sender, TextBox)
        End If

        CtlFocust = _TB

        frmNumpad.TragetTextbox = CtlFocust
        frmNumpad.Show()

        FrmKeyBoard.TargetTextBox = CtlFocust
        FrmKeyBoard.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOPNo.Click
        Dim strOP As String
        strOP = InputBox("กรุณากรอก OPNo")
        If IsNumeric(strOP) = False OrElse strOP.Length <> 6 Then
            MsgBox("กรุณากรอก OPNo")
            Exit Sub
        End If
        btOPNo.Text = "OPNo : " & strOP
        LoginOP = strOP
        TbOPNO.Text = strOP
    End Sub


    Private Sub BtEndManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEndManual.Click
        If FrmKeyBoard.Visible = True Then
            FrmKeyBoard.Hide()
            frmNumpad.Hide()
        End If

        If frmNumpad.Visible = True Then
            frmNumpad.Hide()
        End If


        If ConditionDataLotEnd() = False Then
            Exit Sub
        End If

        Try
            If ReflowData.McNo = CmbMCNO.Text Then
                ReflowData.LotNo = TbLotNo.Text
                ReflowData.StartTime = TbStartTime.Text
                ReflowData.OpNo = TbOPNO.Text
                ReflowData.Input = TbInput.Text
                ReflowData.Output = TbOutput.Text
                ReflowData.StopTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                ReflowData.MagazineNo = TbMagazineNo.Text
                ReflowData.Remark = CmbRemark.Text
                ReflowData.LotStatus = "LOTREQUEST"
                TbStopTime.Text = ReflowData.StopTime
                If RdbGroupA.Checked = True Then
                    ReflowData.Group = "A"
                ElseIf RdbGroupB.Checked = True Then
                    ReflowData.Group = "B"
                End If
            End If

        Catch ex As Exception
            addErrLog("EndManual Para : " & ex.Message.ToString)
        End Try

        addlogQRCode()

        Dim strLog As String
        Dim NGQty As Integer = 0 'เป็น Manual ก่อนรันไม่มี NG
        strLog = "OPNo :" & ReflowData.OpNo & " Group :" & ReflowData.Group & " LotNo :" & ReflowData.LotNo & " Mag :" & ReflowData.MagazineNo & " Input :" & ReflowData.Input & " Output :" & ReflowData.Output & " Remark :" & ReflowData.Remark
        addlogFile(strLog)

        AddDataToTable()
        UpdateDataReflow()
        CountRowData()
        SaveDataLotBin()

        Dim tmpData As String = "RF-" & ReflowData.McNo & "," & ReflowData.LotNo & "," & CDate(ReflowData.StopTime) & "," & CInt(ReflowData.Output) & "," & NGQty & "," & ReflowData.OpNo
        SyncLock m_Locker
            m_LotEndQueue.Enqueue(tmpData)
        End SyncLock

        If bgTDC.IsBusy = False Then
            bgTDC.RunWorkerAsync()
        End If


        BtEndManual.Enabled = False
        BtClearManual.Enabled = True
    End Sub
    Sub AddDataToTable()
        Try
            Dim DataRow As DBxDataSet.ReflowDataRow = DBxDataSet.ReflowData.NewReflowDataRow
            DataRow.MCNo = "RF-" & ReflowData.McNo
            DataRow.LotNo = ReflowData.LotNo
            DataRow.LotStartTime = ReflowData.StartTime
            DataRow.OPNo = ReflowData.OpNo
            DataRow.InputQty = ReflowData.Input
            DataRow.OutputQty = ReflowData.Output
            DataRow.LotEndTime = ReflowData.StopTime
            DataRow.TemperatureGroup = ReflowData.Group
            DataRow.MagazineNo = ReflowData.MagazineNo.ToUpper
            DataRow.Remark = ReflowData.Remark
            DBxDataSet.ReflowData.Rows.Add(DataRow)

        Catch ex As Exception
            addErrLog("AddDataToTable :" & ex.Message.ToString)
        End Try
    End Sub

    Sub CountRowData()
        Try
            Dim countRow As Integer = 0
            For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                If row.IsLotEndTimeNull = False Then
                    countRow += 1
                End If
            Next
            LbCounterFile.Text = countRow
        Catch ex As Exception
            addErrLog("CountRowData :" & ex.Message.ToString)
        End Try
    End Sub
    Sub UpdateDataReflow()
        If My.Computer.Network.IsAvailable Then
            If My.Computer.Network.Ping("172.16.0.102") Then
                Dim removeList As List(Of DataRow) = New List(Of DataRow)
                For Each row As DBxDataSet.ReflowDataRow In DBxDataSet.ReflowData.Rows
                    If row.IsLotEndTimeNull = False Then
                        Try
                            ReflowDataTableAdapter.Update(row)
                            removeList.Add(row)
                        Catch ex As Exception
                            addErrLog("UpdateDataReflow : " & row.LotNo & " :" & ex.Message.ToString)
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

    Public Sub SaveDataError(ByVal row As DBxDataSet.ReflowDataRow)
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
    Function ConditiondatalotStart() As Boolean

        If TbStopTime.Text <> "" Then
            MsgBox("Please Press ''Clear Data'' before ''Start''", 48, "Start")
            Exit Function
        End If
        If CmbMCNO.Text = "" Then
            MsgBox("Please Select M/C No.", 48, "Manual TDC")
            Label3.BackColor = Color.Yellow
            Exit Function
        ElseIf RdbGroupA.Checked = False And RdbGroupB.Checked = False Then
            MsgBox("Please Select Group", 48, "Manual TDC")
            lbGroup.BackColor = Color.Yellow
            Exit Function
        ElseIf TbLotNo.Text = "" Then
            MsgBox("Please Key Lot No.", 48, "Manual TDC")
            TbLotNo.Select()
            TbLotNo.BackColor = Color.Yellow
            CtlFocust = TbLotNo
            Exit Function
        ElseIf TbLotNo.Text.Length <> 10 Then
            MsgBox("LotNo is not correct", 48, "Manual TDC")
            TbLotNo.Select()
            TbLotNo.BackColor = Color.Yellow
            CtlFocust = TbLotNo
            Exit Function
        ElseIf TbOPNO.Text = "" Then
            MsgBox("Please Key OP No.", 48, "Manual TDC")
            TbOPNO.Select()
            TbOPNO.BackColor = Color.Yellow
            CtlFocust = TbOPNO
            Exit Function
        ElseIf TbOPNO.Text.Length <> 6 OrElse IsNumeric(TbOPNO.Text) = False Then
            MsgBox("OpNo is not correct", 48, "Manual TDC")
            TbOPNO.Select()
            TbOPNO.BackColor = Color.Yellow
            CtlFocust = TbOPNO
            Exit Function
        ElseIf TbMagazineNo.Text = "" Then
            MsgBox("Please Key Magazine No,", 48, "Manual TDC")
            TbMagazineNo.Select()
            TbMagazineNo.BackColor = Color.Yellow
            CtlFocust = TbMagazineNo
            Exit Function
        End If
        Return True
    End Function

    Function ConditionDataLotEnd() As Boolean

        If TbStartTime.Text <> "" Then
            Dim time() As String = Split(TbStartTime.Text, " ")
            If UBound(time) <> 1 Then
                MsgBox("Please Press ''Start'' before ''End''", 48, "Manual TDC")
                Exit Function
            End If
        ElseIf TbStartTime.Text = "" Then
            MsgBox("Please Press ''Start'' before ''End''", 48, "Manual TDC")
            Exit Function
        End If

        If CmbMCNO.Text = "" Then
            MsgBox("Please Select M/C No.", 48, "Manual TDC")
            Label3.BackColor = Color.Yellow
            Exit Function
        ElseIf TbLotNo.Text = "" Then
            MsgBox("Please Key Lot No.", 48, "Manual TDC")
            TbLotNo.Select()
            TbLotNo.BackColor = Color.Yellow
            Exit Function
        ElseIf TbOPNO.Text = "" Then
            MsgBox("Please Key OP No.", 48, "Manual TDC")
            TbOPNO.Select()
            TbOPNO.BackColor = Color.Yellow
            Exit Function
        ElseIf TbMagazineNo.Text = "" Then
            MsgBox("Please Key Magazine No,", 48, "Manual TDC")
            TbMagazineNo.Select()
            TbMagazineNo.BackColor = Color.Yellow
            Exit Function

        ElseIf TbInput.Text = "" Then
            MsgBox("Please Key Input", 48, "Manual TDC")
            TbInput.Select()
            TbInput.BackColor = Color.Yellow
            Exit Function
        ElseIf IsNumeric(TbInput.Text) = False Then
            MsgBox("Input is not correct", 48, "Manual TDC")
            TbInput.Select()
            TbInput.BackColor = Color.Yellow
            Exit Function
        ElseIf TbOutput.Text = "" Then
            MsgBox("Please Key Output", 48, "Manual TDC")
            TbOutput.Select()
            TbOutput.BackColor = Color.Yellow
            Exit Function
        ElseIf IsNumeric(TbOutput.Text) = False Then
            MsgBox("Output is not corroct", 48, "Manual TDC")
            TbOutput.Select()
            TbOutput.BackColor = Color.Yellow
            Exit Function
        ElseIf RdbGroupA.Checked = False And RdbGroupB.Checked = False Then
            MsgBox("Please Select Group", 48, "Manual TDC")
            GbGroup.BackColor = Color.Yellow
            Exit Function
        End If


        If TbInput.Text > 90000 Then

            MsgBox("Please Check Input Not Over 90000 pcs", 48)
            Exit Function
        End If
        If TbOutput.Text > 90000 Then

            MsgBox("Please Check Output Not Over 90000 pcs", 48)
            Exit Function
        End If
        Dim NG As Integer = TbInput.Text - TbOutput.Text
        If NG < 0 Then
            MsgBox("Please Check ''Input < Outpot''", 48, "Manual TDC")
            TbOutput.BackColor = Color.Yellow
            TbInput.BackColor = Color.Yellow
            Exit Function
        End If

        Return True

    End Function


    Private Sub BtClearManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClearManual.Click

        If FrmKeyBoard.Visible = True Then
            FrmKeyBoard.Hide()
            frmNumpad.Hide()
        End If

        For Each ctr In gb1.Controls
            If TypeOf ctr Is TextBox Then
                Dim txt As TextBox = CType(ctr, TextBox)
                txt.Text = ""
            End If

        Next
        For Each ctr In gb1.Controls
            If TypeOf ctr Is TextBox Then
                Dim txt As TextBox = CType(ctr, TextBox)
                txt.BackColor = Color.White
            End If
        Next

        For Each ctr In gb1.Controls
            If TypeOf ctr Is Label Then
                Dim lb As Label = CType(ctr, Label)
                lb.BackColor = Color.Transparent
            End If
        Next

        BtStartManual.Enabled = True

        CmbMCNO.Enabled = True
        GbGroup.Enabled = True
        TbLotNo.Enabled = True
        TbDevice.Enabled = True
        TbPackage.Enabled = True
        TbOPNO.Enabled = True
        TbMagazineNo.Enabled = True
        CmbRemark.Enabled = True
        CmbRemark.Text = "-"
        TbStartTime.Enabled = True
        TbStopTime.Enabled = True

        If RdbGroupA.Checked = True Then
            RdbGroupA.Checked = Not RdbGroupA.Checked
        ElseIf RdbGroupB.Checked = True Then
            RdbGroupB.Checked = Not RdbGroupB.Checked
        End If

        ReflowData.LotStatus = ""


    End Sub

    Private Sub BtUpdateDataManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtUpdateDataManual.Click
        UpdateDataReflow()
        CountRowData()
        SaveDataLotBin()
    End Sub
    Private Sub LoadDataLotBin()
        If File.Exists(My.Application.Info.DirectoryPath & "\ReflowData.bin") = False Then
            Exit Sub
        End If
        Using sw As StreamReader = New StreamReader("ReflowData.bin")
            Dim b As BinaryFormatter = New BinaryFormatter()
            Dim dt As DBxDataSet.ReflowDataDataTable = CType(b.Deserialize(sw.BaseStream), DBxDataSet.ReflowDataDataTable)

            For Each row As DBxDataSet.ReflowDataRow In dt.Rows
                DBxDataSet.ReflowData.ImportRow(row)
            Next

        End Using
    End Sub

    Private Sub SaveDataLotBin()
        Using sw As StreamWriter = New StreamWriter("ReflowData.bin")
            Dim b As BinaryFormatter = New BinaryFormatter()
            b.Serialize(sw.BaseStream, DBxDataSet.ReflowData)
        End Using
    End Sub

    Private Sub addlogQRCode()
        Dim logfile As String = Path.Combine(My.Application.Info.DirectoryPath, "LOG\QRCode.txt")
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Date.Now & " : " & DataQR)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub addlogFile(ByVal m As String)
        Dim logfile As String = Path.Combine(My.Application.Info.DirectoryPath, "LOG\Comm.txt")
        Dim logfile1 As String = Path.Combine(My.Application.Info.DirectoryPath, "LOG\Comm1.txt")
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Date.Now & " : " & m)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim sr As StreamReader = File.OpenText(logfile)
        If sr.BaseStream.Length > 2000000 Then
            sr.Close()
            If File.Exists(logfile1) Then
                File.Delete(logfile1)
            End If
            File.Copy(logfile, logfile1, True)
            File.Delete(logfile)
        End If
        sr.Close()
    End Sub

    Public Sub addErrLog(ByVal m As String)
        Dim logfile As String = Path.Combine(My.Application.Info.DirectoryPath, "LOG\Err.txt")
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Date.Now & " : " & m)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Apcs_Pro Valiable"
    Private c_ApcsProService As IApcsProService = New ApcsProService()
    Private lotInfo As iLibrary.LotInfo
    Private machineInfo As MachineInfo
    Private userInfo As UserInfo
    Private log As New Logger
    Private ResultApcsProService As LotUpdateInfo = Nothing
#End Region
    Private Sub bgTDC_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgTDC.DoWork
        Dim TmpData As String = ""
        Dim ArrayData As String()
        'LotSet
        Dim MCNo As String
        Dim LotNo As String
        Dim StartTime As String
        Dim OPNo As String
        'LotEnd
        Dim EndTime As String
        Dim GoodQty As String
        Dim NGQTy As String
        Dim CountErr03 As Integer = 0

LBL_QUEUE_LOTSET_CHECK:
        Dim RepeatCountLotSet As Integer = 0
        SyncLock m_Locker
            If m_LotSetQueue.Count > 0 Then 'ทำ LotSet จนกว่าจะหมด Qeue
                TmpData = m_LotSetQueue.Dequeue
                ArrayData = TmpData.Split(",")
                MCNo = ArrayData(0)
                LotNo = ArrayData(1)
                StartTime = ArrayData(2)
                OPNo = ArrayData(3)
                RepeatCountLotSet = 0
            Else 'ทำ LotEnd จนกว่าจะหมด Qeue
                GoTo LBL_QUEUE_LOTEND_CHECK
            End If
        End SyncLock

LBL_QUEUE_LotSet_Err:
#Region "Apcs_Pro LotSetUp"

        Try
            ' iLibrary.AppConfig.AddConnectionString("ApcsProConnectionString", "Server=10.28.32.122;Database=APCSProDB_V0_96_15;User Id=sa;Password=p@$$w0rd;")
            Dim strHostName As String
            Dim strIPAddress As String
            strHostName = System.Net.Dns.GetHostName()
            strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
            Dim machineInfoArray As MachineInfo() = c_ApcsProService.GetMachineInfoArrayByCellConIp(strIPAddress)
            For Each mc As MachineInfo In machineInfoArray
                machineInfo = mc
            Next
            lotInfo = c_ApcsProService.GetLotInfo(LotNo)
            machineInfo = c_ApcsProService.GetMachineInfo(machineInfo.Id)
            userInfo = c_ApcsProService.GetUserInfo(OPNo)
            Dim currentServerTime As DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(log)

            ResultApcsProService = c_ApcsProService.LotSetup(lotInfo.Id, machineInfo.Id, userInfo.Id, "", "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ResultApcsProService.ErrorMessage, "")
            End If
        Catch ex As Exception
            'addErrLogfile("c_ApcsProService.LotSetup,LotStart:" & ex.ToString())
            log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ex.Message.ToString(), "")

        End Try
#End Region
#Region "APCS Pro LotStart"
        Try
            Dim currentServerTime As DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.LotStart(lotInfo.Id, machineInfo.Id, userInfo.Id, "", "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorMessage, "")
            End If
        Catch ex As Exception
            log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ex.ToString(), "")
        End Try
#End Region
        Dim resSet As TdcResponse = m_TdcService.LotSet(MCNo, LotNo, CDate(StartTime), OPNo, 0)
        If resSet.HasError Then
            If RepeatCountLotSet > 5 Then 'กรณีที่ Err 70,71,72 วนรันซ้ำมากกว่า 5 ครั้ง เป็น Err Log แล้วรัน Lot ต่อไป
                addErrLog("LotSet : " & TmpData)
                GoTo LBL_QUEUE_LOTSET_CHECK
            End If

            Select Case resSet.ErrorCode
                Case "04"
                    RepeatCountLotSet += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotSet_Err
                Case "70"
                    RepeatCountLotSet += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotSet_Err
                Case "71"
                    RepeatCountLotSet += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotSet_Err
                Case "72"
                    RepeatCountLotSet += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotSet_Err
            End Select
        End If
        GoTo LBL_QUEUE_LOTSET_CHECK


LBL_QUEUE_LOTEND_CHECK:
        Dim RepeatCountLotEnd As Integer = 0
        SyncLock m_Locker
            If m_LotEndQueue.Count > 0 Then 'ทำ LotEnd จนกว่าจะหมด Qeue
                TmpData = m_LotEndQueue.Dequeue
                ArrayData = TmpData.Split(",")
                MCNo = ArrayData(0)
                LotNo = ArrayData(1)
                EndTime = ArrayData(2)
                GoodQty = ArrayData(3)
                NGQTy = ArrayData(4)
                OPNo = ArrayData(5)
                RepeatCountLotEnd = 0
            Else 'ทำ LotEnd จนกว่าจะหมด Qeue
                Exit Sub
            End If
        End SyncLock

LBL_QUEUE_LotEnd_Err:
#Region "APCS Pro LotEnd"
        Try
            Dim currentServerTime As DateTimeInfo = c_ApcsProService.Get_DateTimeInfo(log)
            ResultApcsProService = c_ApcsProService.LotEnd(lotInfo.Id, machineInfo.Id, userInfo.Id, False, CInt(GoodQty), CInt(NGQTy), "", "", 1, currentServerTime.Datetime, log)
            If Not ResultApcsProService.IsOk Then
                log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorMessage, "")
            End If
        Catch ex As Exception
            log.OperationLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotStart", ex.ToString(), "")
        End Try
#End Region
        Dim resEnd As TdcResponse = m_TdcService.LotEnd(MCNo, LotNo, CDate(EndTime), CInt(GoodQty), CInt(NGQTy), 1, OPNo)
        If resEnd.HasError Then
            If RepeatCountLotEnd > 5 Then 'กรณีที่ Err 70,71,72 วนรันซ้ำมากกว่า 5 ครั้ง เป็น Err Log แล้วรัน Lot ต่อไป
                addErrLog("LotEnd : " & TmpData)
                GoTo LBL_QUEUE_LOTEND_CHECK
            End If
            Select Case resEnd.ErrorCode
                Case "03" 'Lot was not started or ended 150921
                    CountErr03 += 1 '                                  150923
                    If CountErr03 > 10 Then '                          150923
                        addErrLog("LotErr03 : " & TmpData) '           150923
                        CountErr03 = 0 '                               150923
                        GoTo LBL_QUEUE_LOTEND_CHECK '                  150923
                    End If '150923
                    m_LotEndQueue.Enqueue(TmpData)
                    GoTo LBL_QUEUE_LOTSET_CHECK
                Case "04" 'MC not found
                    RepeatCountLotEnd += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotEnd_Err
                Case "70"
                    RepeatCountLotEnd += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotEnd_Err
                Case "71"
                    RepeatCountLotEnd += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotEnd_Err
                Case "72"
                    RepeatCountLotEnd += 1
                    Thread.Sleep(3000)
                    GoTo LBL_QUEUE_LotEnd_Err
            End Select
        End If
        CountErr03 = 0
        GoTo LBL_QUEUE_LOTEND_CHECK
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Send TDC
        SyncLock m_Locker
            Dim strLotSetData As String = "RF-" & "RF-R-11" & "," & "1111A2222V" & "," & "2015/09/10 10:10:10" & "," & "005588"
            m_LotSetQueue.Enqueue(strLotSetData)
        End SyncLock

        If bgTDC.IsBusy = False Then
            bgTDC.RunWorkerAsync()
        End If
    End Sub

    Private Sub TbInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbInput.TextChanged
        TbOutput.Text = TbInput.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
