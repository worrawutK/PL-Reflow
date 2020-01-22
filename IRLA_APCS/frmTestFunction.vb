Public Class frmTestFunction
    Private frm As frmMain
    Sub New(frmMain As frmMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frm = frmMain
    End Sub
    Private Ip As String = "10.1.1.50"
    Private Sub frmTestFunction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxLR.Text = "LR,9999A0005V,SSOP-B28W ,BD3805F1234(BW)        ,007441,07D8,0000000000,0000000000,001E,B."
        TextBoxLS.Text = "LS,9999A0005V"
        TextBoxSD.Text = "SD,9999A0005V,000000C2"
        TextBoxLE.Text = "LE,9999A0005V,000000C2,Normal"
    End Sub

    Private Sub ButtonLR_Click(sender As Object, e As EventArgs) Handles ButtonLR.Click
        ' Dim Ip As String = "10.1.1.50"
        Dim Data As String = TextBoxLR.Text & vbCr

        frm.GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub ButtonLS_Click(sender As Object, e As EventArgs) Handles ButtonLS.Click
        '  Dim Ip As String = "10.1.1.50"
        Dim Data As String = TextBoxLS.Text & vbCr
        frm.GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub ButtonSD_Click(sender As Object, e As EventArgs) Handles ButtonSD.Click
        ' Dim Ip As String = "10.2.2.2"
        Dim Data As String = TextBoxSD.Text & vbCr
        frm.GetDataFromIPAddress(Ip, Data)
    End Sub

    Private Sub ButtonLE_Click(sender As Object, e As EventArgs) Handles ButtonLE.Click

        Dim Data As String = TextBoxLE.Text & vbCr
        frm.GetDataFromIPAddress(Ip, Data)
    End Sub
End Class