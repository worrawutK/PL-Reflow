Public Class MasterForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Load") = Nothing Then
            Session("Load") = True
            Dropdown()
        End If


    End Sub

    Private Sub Dropdown()
        'Dim Name As New HttpCookie("Name")
        'Name.Value = ddlListItem.Text
        'Response.Cookies.Add(Name)
        'Response.RedirectPermanent("Form2.aspx")


        Button1.Visible = True
        ddlListItem.Visible = True
        '   Dim val As RadioButton = CType(sender, RadioButton)
        Dim val As String = ""
        If rbPACKAGE.Checked Then
            val = "PACKAGE"
        ElseIf rbCARTNO.Checked Then
            val = "CARTNO"
        Else
            val = "WIPALL"
        End If


        If val = "PACKAGE" Then
            SqlListitem.SelectCommand = "SELECT DISTINCT TransactionData.Package FROM TCTransfer INNER JOIN TransactionData ON TCTransfer.LotNo = TransactionData.LotNo order by TransactionData.Package"
            ddlListItem.Items.Clear()
            ddlListItem.DataSource = SqlListitem
            ddlListItem.DataValueField = "Package"
            ddlListItem.DataTextField = "Package"
            ddlListItem.DataBind()
            sqlPKG()
        ElseIf val = "CARTNO" Then

            SqlListitem.SelectCommand = "Select DISTINCT   TCTransfer.CartNo FROM TCTransfer INNER JOIN TransactionData On TCTransfer.LotNo = TransactionData.LotNo order by TCTransfer.CartNo "

            ddlListItem.Items.Clear()
            Dim dview As DataView = CType(SqlListitem.Select(DataSourceSelectArguments.Empty), DataView)
            Dim sum As Int16 = 1
            For Each data As DataRow In dview.Table.Rows
                If sum < 10 Then
                    If data("CartNo") Like "*C0" & sum & "*" Then
                        sum += 1
                        ddlListItem.Items.Add(Split(data("CartNo"), "-")(0))
                    End If
                Else
                    If data("CartNo") Like "*C" & sum & "*" Then
                        sum += 1
                        ddlListItem.Items.Add(Split(data("CartNo"), "-")(0))
                    End If
                End If

                'Dim cc As String = CType(data("CartNo"), String)
            Next
            sqlCart()
        Else
            sqlAll(True)

        End If

    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPACKAGE.CheckedChanged, rbCARTNO.CheckedChanged, rbWIPALL.CheckedChanged
        Dropdown()
        If rbPACKAGE.Checked Then

            Label1.Text = "Package : "
        ElseIf rbCARTNO.Checked Then

            Label1.Text = "Cart No : "
        Else
            Label1.Text = ""
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbPACKAGE.Checked Then
            sqlPKG()

        ElseIf rbCARTNO.Checked Then
            sqlCart()

        Else
            '  Label1.Text = ""
        End If



    End Sub
    Private Sub sqlAll(ByVal Qry As Boolean)
        'Dim c As Integer = 0
        'While c < 10
        '    Dim lab As New Label()
        '    Dim ltr As New Literal()
        '    lab.Text = c.ToString()
        '    ltr.Text = "<br/>"
        '    PlaceHolder1.Controls.Add(lab)
        '    PlaceHolder1.Controls.Add(ltr)
        '    c += 1
        'End While

        'search PKG ALL
        SqlSearchWIP.SelectCommand = "SELECT TCTransfer.LotNo, TCTransfer.CartNo, TCTransfer.LotStartTime, TCTransfer.LotEndTime, TransactionData.Package, TransactionData.Device FROM TCTransfer left JOIN TransactionData ON TCTransfer.LotNo = TransactionData.LotNo WHERE  (TCTransfer.LotEndTime > DATEADD(DAY, - 7, GETDATE())) AND (TCTransfer.LotNo NOT IN (SELECT DISTINCT LotNo FROM ReflowData WHERE (LotStartTime > DATEADD(DAY, - 7, GETDATE())))) ORDER BY TCTransfer.CartNo "
        Dim dview As DataView = CType(SqlSearchWIP.Select(DataSourceSelectArguments.Empty), DataView)

        Dim CartNo As String = "C"
        Dim Count As Int16 = 1
        Dim listLot As List(Of String) = New List(Of String)
        Dim listPKG As List(Of String) = New List(Of String)
        Dim listCart As List(Of String) = New List(Of String)
        Dim sum As Int16 = 0
        Dim PKG As String = ""
        For Each data As DataRowView In dview


            If data("Package") Is DBNull.Value Then

                PKG = "No PKG."
            Else
                PKG = data("Package")
            End If


            If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then
                'listLot.Add(data("LotNo"))
                'listPKG.Add(data("Package"))
                'listCart.Add(data("CartNo"))
                sum += 1
                ' control(data("LotNo"), PKG, data("CartNo"), "")
            Else
                Count += 1
                If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then
                    listLot.Add(data("LotNo"))
                    listPKG.Add(PKG)
                    listCart.Add(data("CartNo"))
                End If
                ' control(data("LotNo"), PKG, data("CartNo"))
            End If
            control(data("LotNo"), PKG, data("CartNo"), "#00FF00")
        Next


        If Qry = True Then
            ddlListItem.Visible = False
            Button1.Visible = False
            GridView1.DataSourceID = "SqlSearchWIP"
            GridView1.DataBind()
        End If


    End Sub
    Private Sub sqlPKG()
        sqlAll(False)
        'search PKG
        SqlSearchWIP.SelectCommand = "SELECT TCTransfer.LotNo, TCTransfer.CartNo, TCTransfer.LotStartTime, TCTransfer.LotEndTime, TransactionData.Package, TransactionData.Device FROM TCTransfer INNER JOIN TransactionData ON TCTransfer.LotNo = TransactionData.LotNo WHERE  (TransactionData.Package = '" & ddlListItem.Text & "') AND(TCTransfer.LotEndTime > DATEADD(DAY, - 7, GETDATE())) AND (TCTransfer.LotNo NOT IN (SELECT DISTINCT LotNo FROM ReflowData WHERE (LotStartTime > DATEADD(DAY, - 7, GETDATE())))) ORDER BY TCTransfer.CartNo"
        Dim dview As DataView = CType(SqlSearchWIP.Select(DataSourceSelectArguments.Empty), DataView)

        Dim CartNo As String = "C"
        Dim Count As Int16 = 1
        Dim listLot As List(Of String) = New List(Of String)
        Dim listPKG As List(Of String) = New List(Of String)
        Dim listCart As List(Of String) = New List(Of String)
        Dim sum As Int16 = 0
        Dim PKG As String = ""
        For Each data As DataRowView In dview


            If data("Package") Is DBNull.Value Then

                PKG = "No PKG."
            Else
                PKG = data("Package")
            End If


            If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then

            Else
                Count += 1
                If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then
                    listLot.Add(data("LotNo"))
                    listPKG.Add(PKG)
                    listCart.Add(data("CartNo"))
                End If
                ' control(data("LotNo"), PKG, data("CartNo"), "#00FF00")
            End If
            control(data("LotNo"), PKG, data("CartNo"), "#ffff00")
        Next

        GridView1.DataSourceID = "SqlSearchWIP"
        GridView1.DataBind()

    End Sub
    ' Public StatusData As Boolean
    Protected Property StatusData As String = "xxx"
    Friend StatusData1 As String
    Private Sub sqlCart()
        sqlAll(False)
        'search CartNo
        SqlSearchWIP.SelectCommand = "SELECT TCTransfer.LotNo, TCTransfer.CartNo, TCTransfer.LotStartTime, TCTransfer.LotEndTime, TransactionData.Package, TransactionData.Device FROM TCTransfer INNER JOIN TransactionData ON TCTransfer.LotNo = TransactionData.LotNo WHERE  (TCTransfer.CartNo like '%" & ddlListItem.Text & "%') AND(TCTransfer.LotEndTime > DATEADD(DAY, - 7, GETDATE())) AND (TCTransfer.LotNo NOT IN (SELECT DISTINCT LotNo FROM ReflowData WHERE (LotStartTime > DATEADD(DAY, - 7, GETDATE())))) ORDER BY TCTransfer.CartNo"
        Dim dview As DataView = CType(SqlSearchWIP.Select(DataSourceSelectArguments.Empty), DataView)

        Dim CartNo As String = "C"
        Dim Count As Int16 = 1
        Dim listLot As List(Of String) = New List(Of String)
        Dim listPKG As List(Of String) = New List(Of String)
        Dim listCart As List(Of String) = New List(Of String)
        Dim sum As Int16 = 0
        Dim PKG As String = ""
        For Each data As DataRowView In dview


            If data("Package") Is DBNull.Value Then

                PKG = "No PKG."
            Else
                PKG = data("Package")
            End If


            If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then
                'listLot.Add(data("LotNo"))
                'listPKG.Add(data("Package"))
                'listCart.Add(data("CartNo"))
                '   sum += 1
                '  control(data("LotNo"), PKG, data("CartNo"), "#00FF00")
            Else
                Count += 1
                If data("CartNo") Like "*" & CartNo & Count.ToString("00") & "*" Then
                    listLot.Add(data("LotNo"))
                    listPKG.Add(PKG)
                    listCart.Add(data("CartNo"))
                End If
                ' control(data("LotNo"), PKG, data("CartNo"), "#00FF00")
            End If
            control(data("LotNo"), PKG, data("CartNo"), "#ffff00")
        Next

        GridView1.DataSourceID = "SqlSearchWIP"
        GridView1.DataBind()

    End Sub
    Private Sub control(ByVal LotNo As String, ByVal PKG As String, ByVal CartNo As String, ByVal Color As String)

        'Dim la As Label = New Label
        'la.Text = "aa"
        ' table1.Rows(0).Cells(0).Controls.Add(la)
        'If Count <= 6 Then
        '    table1.Rows(0).Cells(Count).InnerHtml = LotNo & "<br/>" & PKG
        'ElseIf Count <= 13 Then
        '    table1.Rows(1).Cells(Count - 7).InnerHtml = LotNo & "<br/>" & PKG
        'End If
        Dim No As Int16 = CInt(Split(CartNo, "-")(1))
        Dim row As Int16
        Dim Cell As Int16
        Dim Cart As New HtmlTableCell
        Select Case No
            Case <= 7
                Cell = No - 1
                row = 0
            Case <= 14
                Cell = No - 8
                row = 1
            Case <= 21
                Cell = No - 15
                row = 2
            Case <= 28
                Cell = No - 22
                row = 3
            Case <= 35
                Cell = No - 29
                row = 4
        End Select
        If CartNo Like "*C01*" Then
            Cart = CartNo1.GetCell(row, Cell)
        ElseIf CartNo Like "*C02*" Then
            Cart = CartNo2.GetCell(row, Cell)
        ElseIf CartNo Like "*C03*" Then
            Cart = CartNo3.GetCell(row, Cell)
        ElseIf CartNo Like "*C04*" Then
            Cart = CartNo4.GetCell(row, Cell)
        ElseIf CartNo Like "*C05*" Then
            Cart = CartNo5.GetCell(row, Cell)
        ElseIf CartNo Like "*C06*" Then
            Cart = CartNo6.GetCell(row, Cell)
        End If

        Cart.BgColor = Color
        'Cart.InnerHtml = "<font size='2'> " & CartNo & "<br/>" & LotNo & "</font>" & "<br/>" & "<font size='2'>" & PKG & "</font>"
        Cart.InnerHtml = "<font size='2'> " & CartNo & "<br/></font><font size='2'>" & PKG & "</font>"

    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            GridView1.Columns(1).Visible = True
        Else
            GridView1.Columns(1).Visible = False
        End If

        Dropdown()
    End Sub
End Class