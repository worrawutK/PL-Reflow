Public Class frmShowAlarmData


    Private Sub frmShowAlarmData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Timer1.Enabled = False
    End Sub

    Private Sub frmShowAlarmData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Me.BackColor = Color.WhiteSmoke Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.WhiteSmoke
        End If
    End Sub
End Class