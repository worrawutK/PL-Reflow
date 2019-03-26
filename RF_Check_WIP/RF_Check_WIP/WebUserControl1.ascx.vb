Public Class WebUserControl1
    Inherits System.Web.UI.UserControl


    'Public Property TextLine1() As String
    '    Get
    '        Return Label1.Text
    '    End Get
    '    Set(ByVal value As String)
    '        Label1.Text = value
    '    End Set
    'End Property

    'Public Sub SetText(txt1 As String, txt2 As String, txt3 As String)

    'End Sub
    Public Function GetCell(rowIndex As Integer, colIndex As Integer) As HtmlTableCell
        Return table1.Rows(rowIndex).Cells(colIndex)
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class