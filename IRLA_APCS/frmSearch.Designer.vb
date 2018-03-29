<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ReflowDataDataGridView = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMC = New System.Windows.Forms.ComboBox
        Me.DTPTime1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.bgQuery = New System.ComponentModel.BackgroundWorker
        Me.lbProcess = New System.Windows.Forms.Label
        Me.btSearch = New System.Windows.Forms.Button
        Me.tbLotNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.bgQueryLot = New System.ComponentModel.BackgroundWorker
        Me.ReflowDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBxDataSet = New WindowsApplication1.DBxDataSet
        Me.ReflowDataTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter
        Me.SearchQueryTableAdapter1 = New WindowsApplication1.DBxDataSetTableAdapters.SearchQueryTableAdapter
        Me.SearchQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LotStartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OPNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InputQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OutputQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LotEndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MagazineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TemperatureGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlarmTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflowDataDataGridView
        '
        Me.ReflowDataDataGridView.AllowUserToAddRows = False
        Me.ReflowDataDataGridView.AllowUserToDeleteRows = False
        Me.ReflowDataDataGridView.AutoGenerateColumns = False
        Me.ReflowDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageDataGridViewTextBoxColumn, Me.DeviceDataGridViewTextBoxColumn, Me.LotNoDataGridViewTextBoxColumn, Me.MCNoDataGridViewTextBoxColumn, Me.LotStartTimeDataGridViewTextBoxColumn, Me.OPNoDataGridViewTextBoxColumn, Me.InputQtyDataGridViewTextBoxColumn, Me.OutputQtyDataGridViewTextBoxColumn, Me.LotEndTimeDataGridViewTextBoxColumn, Me.MagazineNoDataGridViewTextBoxColumn, Me.TemperatureGroupDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.AlarmTotalDataGridViewTextBoxColumn})
        Me.ReflowDataDataGridView.DataSource = Me.SearchQueryBindingSource
        Me.ReflowDataDataGridView.Location = New System.Drawing.Point(12, 119)
        Me.ReflowDataDataGridView.Name = "ReflowDataDataGridView"
        Me.ReflowDataDataGridView.ReadOnly = True
        Me.ReflowDataDataGridView.Size = New System.Drawing.Size(956, 447)
        Me.ReflowDataDataGridView.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Work Record"
        '
        'cbMC
        '
        Me.cbMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbMC.FormattingEnabled = True
        Me.cbMC.Location = New System.Drawing.Point(177, 23)
        Me.cbMC.Name = "cbMC"
        Me.cbMC.Size = New System.Drawing.Size(153, 33)
        Me.cbMC.TabIndex = 7
        '
        'DTPTime1
        '
        Me.DTPTime1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTime1.Location = New System.Drawing.Point(350, 23)
        Me.DTPTime1.Name = "DTPTime1"
        Me.DTPTime1.Size = New System.Drawing.Size(382, 30)
        Me.DTPTime1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Machine No."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(738, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bgQuery
        '
        '
        'lbProcess
        '
        Me.lbProcess.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProcess.Location = New System.Drawing.Point(171, 318)
        Me.lbProcess.Name = "lbProcess"
        Me.lbProcess.Size = New System.Drawing.Size(615, 73)
        Me.lbProcess.TabIndex = 11
        Me.lbProcess.Text = "ระบบกำลังประมวลผล. . . . . . ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "โปรดรอสักครู่"
        Me.lbProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbProcess.Visible = False
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSearch.Location = New System.Drawing.Point(597, 69)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(135, 34)
        Me.btSearch.TabIndex = 12
        Me.btSearch.Text = "Lot Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbLotNo
        '
        Me.tbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbLotNo.Location = New System.Drawing.Point(350, 65)
        Me.tbLotNo.Name = "tbLotNo"
        Me.tbLotNo.Size = New System.Drawing.Size(227, 38)
        Me.tbLotNo.TabIndex = 13
        Me.tbLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lot No."
        '
        'bgQueryLot
        '
        '
        'ReflowDataBindingSource
        '
        Me.ReflowDataBindingSource.DataMember = "ReflowData"
        Me.ReflowDataBindingSource.DataSource = Me.DBxDataSet
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReflowDataTableAdapter
        '
        Me.ReflowDataTableAdapter.ClearBeforeFill = True
        '
        'SearchQueryTableAdapter1
        '
        Me.SearchQueryTableAdapter1.ClearBeforeFill = True
        '
        'SearchQueryBindingSource
        '
        Me.SearchQueryBindingSource.DataMember = "SearchQuery"
        Me.SearchQueryBindingSource.DataSource = Me.DBxDataSet
        '
        'PackageDataGridViewTextBoxColumn
        '
        Me.PackageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageDataGridViewTextBoxColumn.DataPropertyName = "Package"
        Me.PackageDataGridViewTextBoxColumn.HeaderText = "Package"
        Me.PackageDataGridViewTextBoxColumn.Name = "PackageDataGridViewTextBoxColumn"
        Me.PackageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PackageDataGridViewTextBoxColumn.Width = 75
        '
        'DeviceDataGridViewTextBoxColumn
        '
        Me.DeviceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DeviceDataGridViewTextBoxColumn.DataPropertyName = "Device"
        Me.DeviceDataGridViewTextBoxColumn.HeaderText = "Device"
        Me.DeviceDataGridViewTextBoxColumn.Name = "DeviceDataGridViewTextBoxColumn"
        Me.DeviceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeviceDataGridViewTextBoxColumn.Width = 66
        '
        'LotNoDataGridViewTextBoxColumn
        '
        Me.LotNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.Name = "LotNoDataGridViewTextBoxColumn"
        Me.LotNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotNoDataGridViewTextBoxColumn.Width = 61
        '
        'MCNoDataGridViewTextBoxColumn
        '
        Me.MCNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MCNoDataGridViewTextBoxColumn.DataPropertyName = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.HeaderText = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.Name = "MCNoDataGridViewTextBoxColumn"
        Me.MCNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MCNoDataGridViewTextBoxColumn.Width = 62
        '
        'LotStartTimeDataGridViewTextBoxColumn
        '
        Me.LotStartTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotStartTimeDataGridViewTextBoxColumn.DataPropertyName = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.HeaderText = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.Name = "LotStartTimeDataGridViewTextBoxColumn"
        Me.LotStartTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotStartTimeDataGridViewTextBoxColumn.Width = 92
        '
        'OPNoDataGridViewTextBoxColumn
        '
        Me.OPNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OPNoDataGridViewTextBoxColumn.DataPropertyName = "OPNo"
        Me.OPNoDataGridViewTextBoxColumn.HeaderText = "OPNo"
        Me.OPNoDataGridViewTextBoxColumn.Name = "OPNoDataGridViewTextBoxColumn"
        Me.OPNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OPNoDataGridViewTextBoxColumn.Width = 61
        '
        'InputQtyDataGridViewTextBoxColumn
        '
        Me.InputQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.InputQtyDataGridViewTextBoxColumn.DataPropertyName = "InputQty"
        Me.InputQtyDataGridViewTextBoxColumn.HeaderText = "InputQty"
        Me.InputQtyDataGridViewTextBoxColumn.Name = "InputQtyDataGridViewTextBoxColumn"
        Me.InputQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.InputQtyDataGridViewTextBoxColumn.Width = 72
        '
        'OutputQtyDataGridViewTextBoxColumn
        '
        Me.OutputQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OutputQtyDataGridViewTextBoxColumn.DataPropertyName = "OutputQty"
        Me.OutputQtyDataGridViewTextBoxColumn.HeaderText = "OutputQty"
        Me.OutputQtyDataGridViewTextBoxColumn.Name = "OutputQtyDataGridViewTextBoxColumn"
        Me.OutputQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.OutputQtyDataGridViewTextBoxColumn.Width = 80
        '
        'LotEndTimeDataGridViewTextBoxColumn
        '
        Me.LotEndTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotEndTimeDataGridViewTextBoxColumn.DataPropertyName = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.HeaderText = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.Name = "LotEndTimeDataGridViewTextBoxColumn"
        Me.LotEndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotEndTimeDataGridViewTextBoxColumn.Width = 89
        '
        'MagazineNoDataGridViewTextBoxColumn
        '
        Me.MagazineNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MagazineNoDataGridViewTextBoxColumn.DataPropertyName = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.HeaderText = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.Name = "MagazineNoDataGridViewTextBoxColumn"
        Me.MagazineNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MagazineNoDataGridViewTextBoxColumn.Width = 92
        '
        'TemperatureGroupDataGridViewTextBoxColumn
        '
        Me.TemperatureGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TemperatureGroupDataGridViewTextBoxColumn.DataPropertyName = "TemperatureGroup"
        Me.TemperatureGroupDataGridViewTextBoxColumn.HeaderText = "TemperatureGroup"
        Me.TemperatureGroupDataGridViewTextBoxColumn.Name = "TemperatureGroupDataGridViewTextBoxColumn"
        Me.TemperatureGroupDataGridViewTextBoxColumn.ReadOnly = True
        Me.TemperatureGroupDataGridViewTextBoxColumn.Width = 121
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemarkDataGridViewTextBoxColumn.Width = 69
        '
        'AlarmTotalDataGridViewTextBoxColumn
        '
        Me.AlarmTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AlarmTotalDataGridViewTextBoxColumn.DataPropertyName = "AlarmTotal"
        Me.AlarmTotalDataGridViewTextBoxColumn.HeaderText = "AlarmTotal"
        Me.AlarmTotalDataGridViewTextBoxColumn.Name = "AlarmTotalDataGridViewTextBoxColumn"
        Me.AlarmTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmTotalDataGridViewTextBoxColumn.Width = 82
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 581)
        Me.Controls.Add(Me.tbLotNo)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.lbProcess)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPTime1)
        Me.Controls.Add(Me.cbMC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReflowDataDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearch"
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBxDataSet As WindowsApplication1.DBxDataSet
    Friend WithEvents ReflowDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowDataTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter
    Friend WithEvents ReflowDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMC As System.Windows.Forms.ComboBox
    Friend WithEvents DTPTime1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bgQuery As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbProcess As System.Windows.Forms.Label
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents tbLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bgQueryLot As System.ComponentModel.BackgroundWorker
    Friend WithEvents SearchQueryTableAdapter1 As WindowsApplication1.DBxDataSetTableAdapters.SearchQueryTableAdapter
    Friend WithEvents SearchQueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PackageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotStartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutputQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotEndTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MagazineNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
