Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Reflow
    Enum UpdateBy
        ReflowOrMeco
        Meco
    End Enum
    Private Sub LoadData(Status As UpdateBy)
        Dim ListPKGNotReflow As List(Of String) = New List(Of String)
        ListPKGNotReflow.Add("WSOF5")
        ListPKGNotReflow.Add("WSOF6")
        ListPKGNotReflow.Add("WSOF6I")
        ListPKGNotReflow.Add("SIP9")

        Try
            Dim MCNo01Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo01.xml"
            If System.IO.File.Exists(MCNo01Path) = True Then
                Dim _TableMCNo01 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                _TableMCNo01.Columns.Add("Period")
                _TableMCNo01.Columns.Add("RFWIP")
                Dim dataView01 As DataView
                _TableMCNo01.ReadXml(MCNo01Path)

                If Status = UpdateBy.ReflowOrMeco Then 'Check WIP Reflow
                    RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)

                End If
                For Each data As DataRow In _TableMCNo01
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                dataView01 = New DataView(_TableMCNo01) 'เรียง Data 1-n
                    dataView01.Sort = "GroupPKG"

                    ViewMeco1.DataSource = dataView01
                    For Each column As DataGridViewColumn In ViewMeco1.Columns
                        column.SortMode = DataGridViewColumnSortMode.NotSortable
                    Next

                    For Each DATA As DataGridViewRow In ViewMeco1.Rows


                        If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                            DATA.DefaultCellStyle.ForeColor = Color.Black
                            DATA.DefaultCellStyle.BackColor = Color.Yellow

                        Else
                            DATA.DefaultCellStyle.ForeColor = Color.Black
                            DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                        End If
                    Next



                End If
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo01Path")
        End Try

        Try
            Dim MCNo02Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo02.xml"
            If System.IO.File.Exists(MCNo02Path) = True Then
                Dim _TableMCNo02 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                _TableMCNo02.Columns.Add("Period")
                _TableMCNo02.Columns.Add("RFWIP")
                Dim dataView02 As DataView
                _TableMCNo02.ReadXml(MCNo02Path)

                dataView02 = New DataView(_TableMCNo02) 'เรียง Data 1-n
                dataView02.Sort = "GroupPKG"
                If Status = UpdateBy.ReflowOrMeco Then
                    RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                End If

                For Each data As DataRow In _TableMCNo02
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                ViewMeco2.DataSource = dataView02

                For Each column As DataGridViewColumn In ViewMeco2.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each DATA As DataGridViewRow In ViewMeco2.Rows


                    If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.Yellow

                    Else
                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                    End If
                Next


            End If

        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo02Path")
        End Try

        Try
            Dim MCNo03Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo03.xml"
            If System.IO.File.Exists(MCNo03Path) = True Then
                Dim _TableMCNo03 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                _TableMCNo03.Columns.Add("Period")
                _TableMCNo03.Columns.Add("RFWIP")
                Dim dataView03 As DataView
                _TableMCNo03.ReadXml(MCNo03Path)

                dataView03 = New DataView(_TableMCNo03) 'เรียง Data 1-n
                dataView03.Sort = "GroupPKG"
                If Status = UpdateBy.ReflowOrMeco Then
                    RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                End If
                For Each data As DataRow In _TableMCNo03
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                ViewMeco3.DataSource = dataView03



                For Each column As DataGridViewColumn In ViewMeco3.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each DATA As DataGridViewRow In ViewMeco3.Rows


                    If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.Yellow

                    Else
                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                    End If
                Next

            End If
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo03Path")
        End Try

        SettingColumns()
    End Sub
    Public DIR_LOG As String = My.Application.Info.DirectoryPath & "\LOG"
    Public Sub SaveCatchLog(ByVal message As String, ByVal fnName As String)
        If Directory.Exists(DIR_LOG & "\BackUp") = False Then
            Directory.CreateDirectory(DIR_LOG & "\BackUp")
        End If
        Dim arr As String() = Directory.GetFiles(DIR_LOG)
        If arr.Length >= 50 Then
            Dim arr1 As String() = Directory.GetFiles(DIR_LOG & "\BackUp")
            For Each strData1 As String In arr1
                File.Delete(strData1)
            Next
            For Each strData As String In arr
                Dim pathSource As String = strData
                Dim pathdes As String = strData.Replace(DIR_LOG, DIR_LOG & "\BackUp")
                File.Move(pathSource, pathdes)
            Next

            Directory.CreateDirectory(DIR_LOG & "\BackUp")
            '    File.Move(arr., DIR_LOG & "\BackUp")
        End If
        'Using sw As StreamReader = New StreamReader(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
        '    sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        'End Using

        Using sw As StreamWriter = New StreamWriter(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
            sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        End Using
    End Sub

    Private Sub SettingColumns()

        ViewMeco1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco1.Columns(0).Width = 50
        ViewMeco1.Columns(1).Width = 50
        ViewMeco1.Columns(2).Width = 50
        ViewMeco1.Columns(4).Width = 50
        ViewMeco1.Columns(5).Width = 80
        ViewMeco1.Columns(6).Width = 50

        ViewMeco1.Columns(4).HeaderText = "Plan" '/" & DayNight.Text
        ViewMeco1.Columns(1).HeaderText = "Result" '/" & DayNight.Text
        ViewMeco1.Columns(0).HeaderText = "MWIP"
        ViewMeco1.Columns(5).DisplayIndex = 0
        ViewMeco1.Columns(3).DisplayIndex = 1
        ViewMeco1.Columns(4).DisplayIndex = 2
        ViewMeco1.Columns(1).DisplayIndex = 3
        ViewMeco1.Columns(2).Visible = False


        ViewMeco2.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco2.Columns(0).Width = 50
        ViewMeco2.Columns(1).Width = 50
        ViewMeco2.Columns(2).Width = 50
        ViewMeco2.Columns(4).Width = 50
        ViewMeco2.Columns(5).Width = 80
        ViewMeco2.Columns(6).Width = 50

        ViewMeco2.Columns(4).HeaderText = "Plan" '/" & DayNight.Text
        ViewMeco2.Columns(1).HeaderText = "Result" '/" & DayNight.Text
        ViewMeco2.Columns(0).HeaderText = "MWIP"
        ViewMeco2.Columns(5).DisplayIndex = 0
        ViewMeco2.Columns(3).DisplayIndex = 1
        ViewMeco2.Columns(4).DisplayIndex = 2
        ViewMeco2.Columns(1).DisplayIndex = 3
        ViewMeco2.Columns(2).Visible = False


        ViewMeco3.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco3.Columns(0).Width = 50
        ViewMeco3.Columns(1).Width = 50
        ViewMeco3.Columns(2).Width = 50
        ViewMeco3.Columns(4).Width = 50
        ViewMeco3.Columns(5).Width = 80
        ViewMeco3.Columns(6).Width = 50

        ViewMeco3.Columns(4).HeaderText = "Plan" '/" & DayNight.Text
        ViewMeco3.Columns(1).HeaderText = "Result" '/" & DayNight.Text
        ViewMeco3.Columns(0).HeaderText = "MWIP"
        ViewMeco3.Columns(5).DisplayIndex = 0
        ViewMeco3.Columns(3).DisplayIndex = 1
        ViewMeco3.Columns(4).DisplayIndex = 2
        ViewMeco3.Columns(1).DisplayIndex = 3
        ViewMeco3.Columns(2).Visible = False
    End Sub





    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
        '   Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Reflow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StratService()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData(UpdateBy.Meco)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData(UpdateBy.ReflowOrMeco)
        ' LoadData(UpdateBy.Meco)
    End Sub

#Region "SQL Service"


    ' SQL service broker
    Private Const statusMessage As String =
     "{0} changes have occurred."
    Private changeCount As Integer = 0
    Private connection As SqlConnection = Nothing
    Private command1 As SqlCommand = Nothing
    Private dataToWatch1 As DataSet = Nothing
    Private Const tableName1 As String = "DailyProcessOperationRate"
    Private changeCount1 As Integer = 0
    Private Sub StratService()
        '   Me.Label2.Text = String.Format(statusMessage, changeCount)

        ' Remove any existing dependency connection, then create a new one.
        SqlDependency.Stop(GetConnectionString())
        SqlDependency.Start(GetConnectionString())

        If connection Is Nothing Then
            connection = New SqlConnection(GetConnectionString())
        End If

        If command1 Is Nothing Then
            ' GetSQL is a local procedure that returns
            ' a paramaterized SQL string. You might want
            ' to use a stored procedure in your application.
            command1 = New SqlCommand(GetSQLTest(), connection)
        End If


        If dataToWatch1 Is Nothing Then
            dataToWatch1 = New DataSet()
        End If


        GetData1()
    End Sub
    Private Function GetConnectionString() As String
        ' To avoid storing the connection string in your code,
        ' you can retrive it from a configuration file.
        'Return "Data Source=CLIENT-205\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=False;User ID=sa;Password=1234"
        '172.16.0.102;Initial Catalog=DBx;User ID=dbxuser
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBx;User ID=sa;Password=5dcda45fc424*"
        Return "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBxDW;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
    End Function
    Private Function GetSQLTest() As String
        '****** WARNING *****
        'http://www.codeproject.com/Articles/12335/Using-SqlDependency-for-data-change-events

        '    Dim frm As MonitorPassBoxMP = New MonitorPassBoxMP
        Dim MCno As String = "" ' frm.ReadTextBoxNum()
        ' Return "SELECT MCNo, LotNo, LotStartTime, LotEndTime, Material, Remark FROM dbo.PLData where   LotNo ='1739A1187V'"
        Return "SELECT  LotNo, CartNo, LotStartTime, LotEndTime FROM  dbo.TCTransfer where CartNo like'%-01%' and LotEndTime is null" 'MCNo='MP-PB-99' DATEADD(HOUR, -1, getdate())  order by LotStartTime desc
    End Function

    Private Sub GetData1()
        ' Empty the dataset so that there is only
        ' one batch worth of data displayed.
        dataToWatch1.Clear()

        ' Make sure the command object does not already have
        ' a notification object associated with it.
        command1.Notification = Nothing

        ' Create and bind the SqlDependency object
        ' to the command object.
        Dim dependency1 As New SqlDependency(command1)
        AddHandler dependency1.OnChange, AddressOf dependency1_OnChange

        Using adapter As New SqlDataAdapter(command1)
            adapter.Fill(dataToWatch1, tableName1)
            '    Me.DataGridView2.DataSource = dataToWatch1
            '    Me.DataGridView2.DataMember = tableName1

        End Using
        ' Query
        LoadData(UpdateBy.ReflowOrMeco)

    End Sub
    'Private Sub Query()

    'End Sub
    Private Sub dependency1_OnChange(ByVal sender As Object, ByVal e As SqlNotificationEventArgs)

        ' This event will occur on a thread pool thread.
        ' It is illegal to update the UI from a worker thread
        ' The following code checks to see if it is safe
        ' update the UI.
        Dim i As ISynchronizeInvoke = CType(Me, ISynchronizeInvoke)

        ' If InvokeRequired returns True, the code
        ' is executing on a worker thread.
        If i.InvokeRequired Then
            ' Create a delegate to perform the thread switch
            Dim tempDelegate As New OnChangeEventHandler(AddressOf dependency1_OnChange)

            Dim args() As Object = {sender, e}

            ' Marshal the data from the worker thread
            ' to the UI thread.
            i.BeginInvoke(tempDelegate, args)

            Return
        End If

        ' Remove the handler since it's only good
        ' for a single notification
        Dim dependency1 As SqlDependency = CType(sender, SqlDependency)

        RemoveHandler dependency1.OnChange, AddressOf dependency1_OnChange


        '  changeCount1 += 1
        '   Me.Label2.Text = String.Format(statusMessage, changeCount1)


        'With Me.ListBox2.Items
        '    .Clear()
        '    .Add("Info:   " & e.Info.ToString())
        '    .Add("Source: " & e.Source.ToString())
        '    .Add("Type:   " & e.Type.ToString())
        'End With


        If e.Type <> SqlNotificationType.Change Then
            Exit Sub
        End If

        ' Reload the dataset that's bound to the grid.
        GetData1()
    End Sub


#End Region
End Class
