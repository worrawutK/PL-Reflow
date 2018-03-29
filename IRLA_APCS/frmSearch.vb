Public Class frmSearch
    Dim _frmMain As frmMain
    Dim _frmKeyboard As New FrmKeyBoard

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbMC.Items.Add("RF-" & m_SelfData.McNo)

        DTPTime1.Value = CDate(Format(Now, "yyyy/MM/dd"))

    End Sub

    Public Sub New(ByVal frm As frmMain)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmMain = frm
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbMC.Text = "" Then
            MsgBox ("กรุณาเลือก MC No.")
            Exit Sub
        ElseIf bgQuery.IsBusy = True Then
            MsgBox("กรุณารอสักครู่ ระบบกำลังประมวลผล")
            Exit Sub
        End If

        lbProcess.Visible = True
        bgQuery.RunWorkerAsync()

    End Sub

    Private Sub bgQuery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgQuery.DoWork
        Dim DateSelect As Date = DTPTime1.Value
        Dim DateLimit As Date = DateAdd("d", 1, DateSelect)
        QueryDataReflow(DateSelect, DateLimit)
    End Sub
    Delegate Sub QueryDataReflowDelegate(ByVal DateSelect As Date, ByVal DateLimit As Date)
    Private Sub QueryDataReflow(ByVal DateSelect As Date, ByVal DateLimit As Date)
        If InvokeRequired = True Then
            Me.Invoke(New QueryDataReflowDelegate(AddressOf QueryDataReflow), DateSelect, DateLimit)
            Exit Sub
        End If
        SearchQueryTableAdapter1.FillBy(DBxDataSet.SearchQuery, DateSelect, DateLimit, cbMC.Text)

    End Sub
    Delegate Sub QueryLotDataReflowDelegate(ByVal LotNo As String)
    Private Sub QueryLotDataReflow(ByVal LotNo As String)
        If InvokeRequired = True Then
            Me.Invoke(New QueryLotDataReflowDelegate(AddressOf QueryLotDataReflow), LotNo)
            Exit Sub
        End If

        SearchQueryTableAdapter1.FillBy1(DBxDataSet.SearchQuery, tbLotNo.Text)

    End Sub

    Private Sub bgQuery_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgQuery.RunWorkerCompleted
        lbProcess.Visible = False
    End Sub

    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        If tbLotNo.Text = "" Then
            MsgBox("กรุณากรอก LotNo")
            Exit Sub
        ElseIf tbLotNo.Text.Length <> 10 Then
            MsgBox("LotNo ไม่ถูกต้องกรุณาตรวจสอบ")
            Exit Sub
        ElseIf bgQueryLot.IsBusy = True Then
            MsgBox("กรุณารอสักครู่ ระบบกำลังประมวลผล")
            Exit Sub
        End If
        lbProcess.Visible = True
        bgQueryLot.RunWorkerAsync()
    End Sub

    Private Sub bgQueryLot_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgQueryLot.DoWork
        QueryLotDataReflow(tbLotNo.Text)
    End Sub

    Private Sub bgQueryLot_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgQueryLot.RunWorkerCompleted
        lbProcess.Visible = False
    End Sub

    Private Sub tbLotNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLotNo.Click
        If IsDisposed = True Then
            _frmKeyboard = New FrmKeyBoard
        End If

        _frmKeyboard.TargetTextBox = tbLotNo
        _frmKeyboard.Show()
    End Sub
End Class