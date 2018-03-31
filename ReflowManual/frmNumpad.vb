Public Class frmNumpad
    Public TragetTextbox As TextBox
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click

        Dim bt As Button = CType(sender, Button)
        TragetTextbox.Focus()
        SendKeys.Send(bt.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TragetTextbox.Focus()
        My.Computer.Keyboard.SendKeys("{TAB}", True)
    End Sub

    Private Sub frmNumpad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(681, 300)
    End Sub
End Class