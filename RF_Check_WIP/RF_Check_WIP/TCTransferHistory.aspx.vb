Public Class TCTransferHistory
    Inherits System.Web.UI.Page
    Public c_TCTransfer As New List(Of TransferData)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lotNo As String = Request.Params("LOTNO")
        Dim topSelect As String
        Dim data As List(Of TransferData)
        If String.IsNullOrEmpty(lotNo) Then
            topSelect = Request.Params("TOP")
            If String.IsNullOrEmpty(topSelect) Then
                topSelect = "1000"
            End If
            data = GetTopTCTransferData(topSelect)
        Else
            data = GetLotNoTCTransferData(lotNo)
        End If





        c_TCTransfer = data
    End Sub
    Public c_ColorList As String() = {"default", "success", "danger", "info", "warning", "active"}
    Private Function GetLotNoTCTransferData(lotNo As String) As List(Of TransferData)
        Dim data As DataTable = New DataTable()
        Using cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection("Data Source=172.16.0.102;Initial Catalog=APCSDB;Persist Security Info=True;User ID=system;Password=p@$$w0rd")
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT [LotNo],[CartNo],[LotStartTime],[LotEndTime]
                               FROM [DBx].[dbo].[TCTransfer]
                               where LotNo = @LotNo
                               order by LotStartTime desc"
            cmd.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = lotNo
            cmd.Connection.Open()
            Using rd = cmd.ExecuteReader()
                If rd.HasRows Then
                    data.Load(rd)
                End If
            End Using
        End Using

        'Dim transferDataList As New List(Of TransferData)
        'For Each row As DataRow In data.Rows
        '    Dim transferData As New TransferData
        '    transferData.LotNo = row("LotNo").ToString()
        '    transferData.CartNo = row("CartNo").ToString()
        '    If Not String.IsNullOrEmpty(row("LotStartTime")) Then
        '        transferData.LotStartTime = CType(row("LotStartTime"), Date)
        '    End If
        '    If Not row("LotEndTime") Is DBNull.Value Then
        '        transferData.LotEndTime = CType(row("LotEndTime"), Date)
        '    End If
        '    transferDataList.Add(transferData)
        'Next
        Return setData(data)
    End Function
    Private Function GetTopTCTransferData(topSelected As String) As List(Of TransferData)
        Dim data As DataTable = New DataTable()
        Using cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection("Data Source=172.16.0.102;Initial Catalog=APCSDB;Persist Security Info=True;User ID=system;Password=p@$$w0rd")
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TOP (" & topSelected & ") [LotNo],[CartNo],[LotStartTime],[LotEndTime]
                               FROM [DBx].[dbo].[TCTransfer]
                               order by LotStartTime desc"
            ' cmd.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = lotNo
            cmd.Connection.Open()
            Using rd = cmd.ExecuteReader()
                If rd.HasRows Then
                    data.Load(rd)
                End If
            End Using
        End Using

        'Dim transferDataList As New List(Of TransferData)
        'For Each row As DataRow In data.Rows
        '    Dim transferData As New TransferData
        '    transferData.LotNo = row("LotNo").ToString()
        '    transferData.CartNo = row("CartNo").ToString()
        '    If Not String.IsNullOrEmpty(row("LotStartTime")) Then
        '        transferData.LotStartTime = CType(row("LotStartTime"), Date)
        '    End If
        '    If Not row("LotEndTime") Is DBNull.Value Then
        '        transferData.LotEndTime = CType(row("LotEndTime"), Date)
        '    End If
        '    transferDataList.Add(transferData)
        'Next
        Return setData(data)
    End Function
    Private Function setData(data As DataTable) As List(Of TransferData)
        Dim transferDataList As New List(Of TransferData)
        For Each row As DataRow In data.Rows
            Dim transferData As New TransferData
            transferData.LotNo = row("LotNo").ToString()
            transferData.CartNo = row("CartNo").ToString()
            If Not String.IsNullOrEmpty(row("LotStartTime")) Then
                transferData.LotStartTime = CType(row("LotStartTime"), Date)
            End If
            If Not row("LotEndTime") Is DBNull.Value Then
                transferData.LotEndTime = CType(row("LotEndTime"), Date)
            End If
            transferDataList.Add(transferData)
        Next
        Return transferDataList
    End Function
End Class