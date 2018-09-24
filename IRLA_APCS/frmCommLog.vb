Public Class frmCommLog
    Private Sub frmCommLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub SendLog(txt As String)
        ListBox1.Items.Insert(0, txt)
    End Sub

End Class