Public Class frmEndManual
    Public intPcs As Integer
    Private _inPut As Integer
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If tbPcs.Text = "" OrElse CDbl(tbPcs.Text) = 0 OrElse IsNumeric(tbPcs.Text) = False Then
            MsgBox("กรอกข้อมูลไม่ถูกต้องกรุณาตรวจสอบ")
            Exit Sub
        ElseIf CInt(tbPcs.Text) > _inPut Then
            MsgBox("Output มากกว่า Input ข้อมูลไม่ถูกต้องกรุณาตรวจสอบ")
            Exit Sub
        End If

        intPcs = CInt(tbPcs.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button11.Click, Button10.Click
        Dim bt As Button = CType(sender, Button)
        tbPcs.Focus()
        If bt.Text <> "BS" Then
            SendKeys.Send(bt.Text)
        Else
            SendKeys.Send("{BS}")
        End If
    End Sub
    Dim _frmmain As frmMain
    Public Sub New(ByVal input As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' _frmmain = frmmain
        _inPut = input
        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class