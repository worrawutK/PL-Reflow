<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbStart1 = New System.Windows.Forms.Label()
        Me.lbIp = New System.Windows.Forms.Label()
        Me.lbOpNo1 = New System.Windows.Forms.Label()
        Me.lbStop1 = New System.Windows.Forms.Label()
        Me.lbInput1 = New System.Windows.Forms.Label()
        Me.lbDevice1 = New System.Windows.Forms.Label()
        Me.lbOutput1 = New System.Windows.Forms.Label()
        Me.lbPackage1 = New System.Windows.Forms.Label()
        Me.lbLotNo1 = New System.Windows.Forms.Label()
        Me.lbMC = New System.Windows.Forms.Label()
        Me.ReflowDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBxDataSet = New WindowsApplication1.DBxDataSet()
        Me.ReflowAlarmInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReflowAlarmTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtEndLot = New System.Windows.Forms.Button()
        Me.LbGroup1 = New System.Windows.Forms.Label()
        Me.LbVersion = New System.Windows.Forms.Label()
        Me.Lbtime = New System.Windows.Forms.Label()
        Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.LbMagazine1 = New System.Windows.Forms.Label()
        Me.bgTDC = New System.ComponentModel.BackgroundWorker()
        Me.bgTDCLotReq = New System.ComponentModel.BackgroundWorker()
        Me.ANDONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WORKRECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMREQUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMREPAIRINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndonToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkRecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMRequestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMRepairingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndonToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkRecordToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMRequestToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMRepairingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndonToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AndonToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkRecordToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMRequestToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMRepairingToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbNetversion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestFuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxNotification1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxNotification2 = New System.Windows.Forms.TextBox()
        Me.BtEndLot2 = New System.Windows.Forms.Button()
        Me.lbOpNo2 = New System.Windows.Forms.Label()
        Me.lbLotNo2 = New System.Windows.Forms.Label()
        Me.lbPackage2 = New System.Windows.Forms.Label()
        Me.lbOutput2 = New System.Windows.Forms.Label()
        Me.lbDevice2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbInput2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbStop2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbStart2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpProductData = New System.Windows.Forms.TabPage()
        Me.gbxLotEnd = New System.Windows.Forms.GroupBox()
        Me.radResetEnd = New System.Windows.Forms.RadioButton()
        Me.radAccuEnd = New System.Windows.Forms.RadioButton()
        Me.radNormalEnd = New System.Windows.Forms.RadioButton()
        Me.TPMaintenance = New System.Windows.Forms.TabPage()
        Me.LbCounterFile = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtSetting = New System.Windows.Forms.Button()
        Me.ComLog = New System.Windows.Forms.TabPage()
        Me.lbLotReq = New System.Windows.Forms.Label()
        Me.lbLotSetEnd = New System.Windows.Forms.Label()
        Me.cbSDGood = New System.Windows.Forms.CheckBox()
        Me.CommLog = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LbGroup2 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LbMagazine2 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ReflowAlarmTableTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmTableTableAdapter()
        Me.ReflowAlarmInfoTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmInfoTableAdapter()
        Me.ReflowDataTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.APCSClose = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PanelNextLot = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBoxNotificationNextLot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelNextLot = New System.Windows.Forms.Label()
        Me.PanelLot2 = New System.Windows.Forms.Panel()
        Me.PanelLot1 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReflowDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.LotNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotStartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutputQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotEndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MagazineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflowAlarmInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClearTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflowAlarmTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.ButtonReload2 = New System.Windows.Forms.Button()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TpProductData.SuspendLayout()
        Me.gbxLotEnd.SuspendLayout()
        Me.TPMaintenance.SuspendLayout()
        Me.ComLog.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PanelNextLot.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelLot2.SuspendLayout()
        Me.PanelLot1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbStart1
        '
        Me.lbStart1.AutoSize = True
        Me.lbStart1.BackColor = System.Drawing.Color.Transparent
        Me.lbStart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStart1.Location = New System.Drawing.Point(159, 363)
        Me.lbStart1.Name = "lbStart1"
        Me.lbStart1.Size = New System.Drawing.Size(19, 25)
        Me.lbStart1.TabIndex = 27
        Me.lbStart1.Text = "-"
        '
        'lbIp
        '
        Me.lbIp.AutoSize = True
        Me.lbIp.BackColor = System.Drawing.Color.Transparent
        Me.lbIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbIp.ForeColor = System.Drawing.Color.Black
        Me.lbIp.Location = New System.Drawing.Point(787, 5)
        Me.lbIp.Name = "lbIp"
        Me.lbIp.Size = New System.Drawing.Size(32, 25)
        Me.lbIp.TabIndex = 29
        Me.lbIp.Text = "IP"
        '
        'lbOpNo1
        '
        Me.lbOpNo1.AutoSize = True
        Me.lbOpNo1.BackColor = System.Drawing.Color.Transparent
        Me.lbOpNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOpNo1.Location = New System.Drawing.Point(159, 14)
        Me.lbOpNo1.Name = "lbOpNo1"
        Me.lbOpNo1.Size = New System.Drawing.Size(19, 25)
        Me.lbOpNo1.TabIndex = 28
        Me.lbOpNo1.Text = "-"
        '
        'lbStop1
        '
        Me.lbStop1.AutoSize = True
        Me.lbStop1.BackColor = System.Drawing.Color.Transparent
        Me.lbStop1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStop1.Location = New System.Drawing.Point(159, 411)
        Me.lbStop1.Name = "lbStop1"
        Me.lbStop1.Size = New System.Drawing.Size(19, 25)
        Me.lbStop1.TabIndex = 26
        Me.lbStop1.Text = "-"
        '
        'lbInput1
        '
        Me.lbInput1.AutoSize = True
        Me.lbInput1.BackColor = System.Drawing.Color.Transparent
        Me.lbInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbInput1.Location = New System.Drawing.Point(159, 178)
        Me.lbInput1.Name = "lbInput1"
        Me.lbInput1.Size = New System.Drawing.Size(19, 25)
        Me.lbInput1.TabIndex = 25
        Me.lbInput1.Text = "-"
        '
        'lbDevice1
        '
        Me.lbDevice1.AutoSize = True
        Me.lbDevice1.BackColor = System.Drawing.Color.Transparent
        Me.lbDevice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDevice1.Location = New System.Drawing.Point(159, 136)
        Me.lbDevice1.Name = "lbDevice1"
        Me.lbDevice1.Size = New System.Drawing.Size(19, 25)
        Me.lbDevice1.TabIndex = 21
        Me.lbDevice1.Text = "-"
        '
        'lbOutput1
        '
        Me.lbOutput1.AutoSize = True
        Me.lbOutput1.BackColor = System.Drawing.Color.Transparent
        Me.lbOutput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutput1.Location = New System.Drawing.Point(159, 224)
        Me.lbOutput1.Name = "lbOutput1"
        Me.lbOutput1.Size = New System.Drawing.Size(19, 25)
        Me.lbOutput1.TabIndex = 20
        Me.lbOutput1.Text = "-"
        '
        'lbPackage1
        '
        Me.lbPackage1.AutoSize = True
        Me.lbPackage1.BackColor = System.Drawing.Color.Transparent
        Me.lbPackage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPackage1.Location = New System.Drawing.Point(159, 94)
        Me.lbPackage1.Name = "lbPackage1"
        Me.lbPackage1.Size = New System.Drawing.Size(19, 25)
        Me.lbPackage1.TabIndex = 23
        Me.lbPackage1.Text = "-"
        '
        'lbLotNo1
        '
        Me.lbLotNo1.AutoSize = True
        Me.lbLotNo1.BackColor = System.Drawing.Color.Transparent
        Me.lbLotNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNo1.Location = New System.Drawing.Point(159, 53)
        Me.lbLotNo1.Name = "lbLotNo1"
        Me.lbLotNo1.Size = New System.Drawing.Size(19, 25)
        Me.lbLotNo1.TabIndex = 22
        Me.lbLotNo1.Text = "-"
        '
        'lbMC
        '
        Me.lbMC.AutoSize = True
        Me.lbMC.BackColor = System.Drawing.Color.Transparent
        Me.lbMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbMC.Location = New System.Drawing.Point(169, 5)
        Me.lbMC.Name = "lbMC"
        Me.lbMC.Size = New System.Drawing.Size(73, 25)
        Me.lbMC.TabIndex = 24
        Me.lbMC.Text = "MCNo"
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
        'ReflowAlarmInfoBindingSource
        '
        Me.ReflowAlarmInfoBindingSource.DataMember = "ReflowAlarmInfo"
        Me.ReflowAlarmInfoBindingSource.DataSource = Me.DBxDataSet
        '
        'ReflowAlarmTableBindingSource
        '
        Me.ReflowAlarmTableBindingSource.DataMember = "ReflowAlarmTable"
        Me.ReflowAlarmTableBindingSource.DataSource = Me.DBxDataSet
        '
        'BtEndLot
        '
        Me.BtEndLot.BackColor = System.Drawing.SystemColors.Control
        Me.BtEndLot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEndLot.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEndLot.ForeColor = System.Drawing.Color.Black
        Me.BtEndLot.Location = New System.Drawing.Point(326, 574)
        Me.BtEndLot.Name = "BtEndLot"
        Me.BtEndLot.Size = New System.Drawing.Size(269, 62)
        Me.BtEndLot.TabIndex = 206
        Me.BtEndLot.Text = "End Lot "
        Me.BtEndLot.UseVisualStyleBackColor = False
        '
        'LbGroup1
        '
        Me.LbGroup1.AutoSize = True
        Me.LbGroup1.BackColor = System.Drawing.Color.Transparent
        Me.LbGroup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbGroup1.Location = New System.Drawing.Point(159, 317)
        Me.LbGroup1.Name = "LbGroup1"
        Me.LbGroup1.Size = New System.Drawing.Size(19, 25)
        Me.LbGroup1.TabIndex = 45
        Me.LbGroup1.Text = "-"
        '
        'LbVersion
        '
        Me.LbVersion.AutoSize = True
        Me.LbVersion.BackColor = System.Drawing.Color.Transparent
        Me.LbVersion.Location = New System.Drawing.Point(897, 773)
        Me.LbVersion.Name = "LbVersion"
        Me.LbVersion.Size = New System.Drawing.Size(178, 13)
        Me.LbVersion.TabIndex = 47
        Me.LbVersion.Text = "Reflow APCS Software Version 4.01"
        '
        'Lbtime
        '
        Me.Lbtime.AutoSize = True
        Me.Lbtime.BackColor = System.Drawing.Color.Transparent
        Me.Lbtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbtime.Location = New System.Drawing.Point(1092, 64)
        Me.Lbtime.Name = "Lbtime"
        Me.Lbtime.Size = New System.Drawing.Size(45, 13)
        Me.Lbtime.TabIndex = 48
        Me.Lbtime.Text = "Label3"
        Me.Lbtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerDateTime
        '
        Me.TimerDateTime.Enabled = True
        Me.TimerDateTime.Interval = 500
        '
        'LbMagazine1
        '
        Me.LbMagazine1.AutoSize = True
        Me.LbMagazine1.BackColor = System.Drawing.Color.Transparent
        Me.LbMagazine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbMagazine1.Location = New System.Drawing.Point(159, 270)
        Me.LbMagazine1.Name = "LbMagazine1"
        Me.LbMagazine1.Size = New System.Drawing.Size(19, 25)
        Me.LbMagazine1.TabIndex = 51
        Me.LbMagazine1.Text = "-"
        '
        'bgTDC
        '
        '
        'bgTDCLotReq
        '
        '
        'ANDONToolStripMenuItem
        '
        Me.ANDONToolStripMenuItem.Name = "ANDONToolStripMenuItem"
        Me.ANDONToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ANDONToolStripMenuItem.Text = "ANDON"
        '
        'WORKRECORDToolStripMenuItem
        '
        Me.WORKRECORDToolStripMenuItem.Name = "WORKRECORDToolStripMenuItem"
        Me.WORKRECORDToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.WORKRECORDToolStripMenuItem.Text = "WORK RECORD"
        '
        'BMREQUESTToolStripMenuItem
        '
        Me.BMREQUESTToolStripMenuItem.Name = "BMREQUESTToolStripMenuItem"
        Me.BMREQUESTToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.BMREQUESTToolStripMenuItem.Text = "BM REQUEST"
        '
        'PMREPAIRINGToolStripMenuItem
        '
        Me.PMREPAIRINGToolStripMenuItem.Name = "PMREPAIRINGToolStripMenuItem"
        Me.PMREPAIRINGToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.PMREPAIRINGToolStripMenuItem.Text = "PM REPAIRING"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'AndonToolStripMenuItem1
        '
        Me.AndonToolStripMenuItem1.Name = "AndonToolStripMenuItem1"
        Me.AndonToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.AndonToolStripMenuItem1.Text = "Andon"
        '
        'WorkRecordToolStripMenuItem1
        '
        Me.WorkRecordToolStripMenuItem1.Name = "WorkRecordToolStripMenuItem1"
        Me.WorkRecordToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.WorkRecordToolStripMenuItem1.Text = "Work Record"
        '
        'BMRequestToolStripMenuItem1
        '
        Me.BMRequestToolStripMenuItem1.Name = "BMRequestToolStripMenuItem1"
        Me.BMRequestToolStripMenuItem1.Size = New System.Drawing.Size(76, 20)
        Me.BMRequestToolStripMenuItem1.Text = "BM Request"
        '
        'PMRepairingToolStripMenuItem1
        '
        Me.PMRepairingToolStripMenuItem1.Name = "PMRepairingToolStripMenuItem1"
        Me.PMRepairingToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.PMRepairingToolStripMenuItem1.Text = "PM Repairing"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'AndonToolStripMenuItem2
        '
        Me.AndonToolStripMenuItem2.Name = "AndonToolStripMenuItem2"
        Me.AndonToolStripMenuItem2.Size = New System.Drawing.Size(50, 20)
        Me.AndonToolStripMenuItem2.Text = "Andon"
        '
        'WorkRecordToolStripMenuItem2
        '
        Me.WorkRecordToolStripMenuItem2.Name = "WorkRecordToolStripMenuItem2"
        Me.WorkRecordToolStripMenuItem2.Size = New System.Drawing.Size(81, 20)
        Me.WorkRecordToolStripMenuItem2.Text = "Work Record"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'BMRequestToolStripMenuItem2
        '
        Me.BMRequestToolStripMenuItem2.Name = "BMRequestToolStripMenuItem2"
        Me.BMRequestToolStripMenuItem2.Size = New System.Drawing.Size(76, 20)
        Me.BMRequestToolStripMenuItem2.Text = "BM Request"
        '
        'PMRepairingToolStripMenuItem2
        '
        Me.PMRepairingToolStripMenuItem2.Name = "PMRepairingToolStripMenuItem2"
        Me.PMRepairingToolStripMenuItem2.Size = New System.Drawing.Size(81, 20)
        Me.PMRepairingToolStripMenuItem2.Text = "PM Repairing"
        '
        'SearchToolStripMenuItem2
        '
        Me.SearchToolStripMenuItem2.Name = "SearchToolStripMenuItem2"
        Me.SearchToolStripMenuItem2.Size = New System.Drawing.Size(52, 20)
        Me.SearchToolStripMenuItem2.Text = "Search"
        '
        'AndonToolStripMenuItem3
        '
        Me.AndonToolStripMenuItem3.Name = "AndonToolStripMenuItem3"
        Me.AndonToolStripMenuItem3.Size = New System.Drawing.Size(50, 20)
        Me.AndonToolStripMenuItem3.Text = "Andon"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndonToolStripMenuItem4, Me.WorkRecordToolStripMenuItem3, Me.HelpToolStripMenuItem2, Me.BMRequestToolStripMenuItem3, Me.PMRepairingToolStripMenuItem3, Me.SearchToolStripMenuItem3, Me.WIPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(51, 166)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 27)
        Me.MenuStrip1.TabIndex = 213
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AndonToolStripMenuItem4
        '
        Me.AndonToolStripMenuItem4.Name = "AndonToolStripMenuItem4"
        Me.AndonToolStripMenuItem4.Size = New System.Drawing.Size(73, 23)
        Me.AndonToolStripMenuItem4.Text = "Andon"
        '
        'WorkRecordToolStripMenuItem3
        '
        Me.WorkRecordToolStripMenuItem3.Name = "WorkRecordToolStripMenuItem3"
        Me.WorkRecordToolStripMenuItem3.Size = New System.Drawing.Size(126, 23)
        Me.WorkRecordToolStripMenuItem3.Text = "Work Record"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(58, 23)
        Me.HelpToolStripMenuItem2.Text = "Help"
        '
        'BMRequestToolStripMenuItem3
        '
        Me.BMRequestToolStripMenuItem3.Name = "BMRequestToolStripMenuItem3"
        Me.BMRequestToolStripMenuItem3.Size = New System.Drawing.Size(118, 23)
        Me.BMRequestToolStripMenuItem3.Text = "BM Request"
        '
        'PMRepairingToolStripMenuItem3
        '
        Me.PMRepairingToolStripMenuItem3.Name = "PMRepairingToolStripMenuItem3"
        Me.PMRepairingToolStripMenuItem3.Size = New System.Drawing.Size(130, 23)
        Me.PMRepairingToolStripMenuItem3.Text = "PM Repairing"
        '
        'SearchToolStripMenuItem3
        '
        Me.SearchToolStripMenuItem3.Name = "SearchToolStripMenuItem3"
        Me.SearchToolStripMenuItem3.Size = New System.Drawing.Size(76, 23)
        Me.SearchToolStripMenuItem3.Text = "Search"
        Me.SearchToolStripMenuItem3.Visible = False
        '
        'WIPToolStripMenuItem
        '
        Me.WIPToolStripMenuItem.Name = "WIPToolStripMenuItem"
        Me.WIPToolStripMenuItem.Size = New System.Drawing.Size(55, 23)
        Me.WIPToolStripMenuItem.Text = "WIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "IP Address   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "MC No       : "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 27)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "OP No.        "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 27)
        Me.Label4.TabIndex = 214
        Me.Label4.Text = "Lot No.        "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 27)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Package      "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 27)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "Device         "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 27)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Input Qty     "
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 27)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Output Qty  "
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 27)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Magazine    "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 27)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "Group Name"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 27)
        Me.Label11.TabIndex = 214
        Me.Label11.Text = "Start Time   "
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 27)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "End Time    "
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 27)
        Me.Label13.TabIndex = 214
        Me.Label13.Text = "Lot Info.      "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label14.Location = New System.Drawing.Point(62, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(230, 54)
        Me.Label14.TabIndex = 215
        Me.Label14.Text = "REFLOW"
        '
        'lbNetversion
        '
        Me.lbNetversion.AutoSize = True
        Me.lbNetversion.Location = New System.Drawing.Point(1081, 773)
        Me.lbNetversion.Name = "lbNetversion"
        Me.lbNetversion.Size = New System.Drawing.Size(45, 13)
        Me.lbNetversion.TabIndex = 217
        Me.lbNetversion.Text = "Label15"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel1.Controls.Add(Me.ButtonReload)
        Me.Panel1.Controls.Add(Me.TextBoxNotification1)
        Me.Panel1.Controls.Add(Me.BtEndLot)
        Me.Panel1.Controls.Add(Me.lbOpNo1)
        Me.Panel1.Controls.Add(Me.lbLotNo1)
        Me.Panel1.Controls.Add(Me.lbPackage1)
        Me.Panel1.Controls.Add(Me.lbOutput1)
        Me.Panel1.Controls.Add(Me.lbDevice1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lbInput1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbStop1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbStart1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LbGroup1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LbMagazine1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 642)
        Me.Panel1.TabIndex = 218
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.TestFuToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(146, 48)
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LogToolStripMenuItem.Text = "Comlog"
        '
        'TestFuToolStripMenuItem
        '
        Me.TestFuToolStripMenuItem.Name = "TestFuToolStripMenuItem"
        Me.TestFuToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TestFuToolStripMenuItem.Text = "Test Function"
        '
        'TextBoxNotification1
        '
        Me.TextBoxNotification1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNotification1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNotification1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNotification1.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBoxNotification1.Location = New System.Drawing.Point(162, 461)
        Me.TextBoxNotification1.Multiline = True
        Me.TextBoxNotification1.Name = "TextBoxNotification1"
        Me.TextBoxNotification1.Size = New System.Drawing.Size(389, 88)
        Me.TextBoxNotification1.TabIndex = 215
        Me.TextBoxNotification1.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel2.Controls.Add(Me.ButtonReload2)
        Me.Panel2.Controls.Add(Me.TextBoxNotification2)
        Me.Panel2.Controls.Add(Me.BtEndLot2)
        Me.Panel2.Controls.Add(Me.lbOpNo2)
        Me.Panel2.Controls.Add(Me.lbLotNo2)
        Me.Panel2.Controls.Add(Me.lbPackage2)
        Me.Panel2.Controls.Add(Me.lbOutput2)
        Me.Panel2.Controls.Add(Me.lbDevice2)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.lbInput2)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.lbStop2)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.lbStart2)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.LbGroup2)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.LbMagazine2)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 643)
        Me.Panel2.TabIndex = 221
        '
        'TextBoxNotification2
        '
        Me.TextBoxNotification2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNotification2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNotification2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNotification2.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBoxNotification2.Location = New System.Drawing.Point(161, 462)
        Me.TextBoxNotification2.Multiline = True
        Me.TextBoxNotification2.Name = "TextBoxNotification2"
        Me.TextBoxNotification2.Size = New System.Drawing.Size(388, 88)
        Me.TextBoxNotification2.TabIndex = 216
        Me.TextBoxNotification2.Text = "-"
        '
        'BtEndLot2
        '
        Me.BtEndLot2.BackColor = System.Drawing.SystemColors.Control
        Me.BtEndLot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEndLot2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEndLot2.ForeColor = System.Drawing.Color.Black
        Me.BtEndLot2.Location = New System.Drawing.Point(318, 575)
        Me.BtEndLot2.Name = "BtEndLot2"
        Me.BtEndLot2.Size = New System.Drawing.Size(269, 62)
        Me.BtEndLot2.TabIndex = 206
        Me.BtEndLot2.Text = " End Lot "
        Me.BtEndLot2.UseVisualStyleBackColor = False
        '
        'lbOpNo2
        '
        Me.lbOpNo2.AutoSize = True
        Me.lbOpNo2.BackColor = System.Drawing.Color.Transparent
        Me.lbOpNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOpNo2.Location = New System.Drawing.Point(157, 13)
        Me.lbOpNo2.Name = "lbOpNo2"
        Me.lbOpNo2.Size = New System.Drawing.Size(19, 25)
        Me.lbOpNo2.TabIndex = 28
        Me.lbOpNo2.Text = "-"
        '
        'lbLotNo2
        '
        Me.lbLotNo2.AutoSize = True
        Me.lbLotNo2.BackColor = System.Drawing.Color.Transparent
        Me.lbLotNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNo2.Location = New System.Drawing.Point(157, 54)
        Me.lbLotNo2.Name = "lbLotNo2"
        Me.lbLotNo2.Size = New System.Drawing.Size(19, 25)
        Me.lbLotNo2.TabIndex = 22
        Me.lbLotNo2.Text = "-"
        '
        'lbPackage2
        '
        Me.lbPackage2.AutoSize = True
        Me.lbPackage2.BackColor = System.Drawing.Color.Transparent
        Me.lbPackage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPackage2.Location = New System.Drawing.Point(157, 95)
        Me.lbPackage2.Name = "lbPackage2"
        Me.lbPackage2.Size = New System.Drawing.Size(19, 25)
        Me.lbPackage2.TabIndex = 23
        Me.lbPackage2.Text = "-"
        '
        'lbOutput2
        '
        Me.lbOutput2.AutoSize = True
        Me.lbOutput2.BackColor = System.Drawing.Color.Transparent
        Me.lbOutput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutput2.Location = New System.Drawing.Point(157, 225)
        Me.lbOutput2.Name = "lbOutput2"
        Me.lbOutput2.Size = New System.Drawing.Size(19, 25)
        Me.lbOutput2.TabIndex = 20
        Me.lbOutput2.Text = "-"
        '
        'lbDevice2
        '
        Me.lbDevice2.AutoSize = True
        Me.lbDevice2.BackColor = System.Drawing.Color.Transparent
        Me.lbDevice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDevice2.Location = New System.Drawing.Point(157, 137)
        Me.lbDevice2.Name = "lbDevice2"
        Me.lbDevice2.Size = New System.Drawing.Size(19, 25)
        Me.lbDevice2.TabIndex = 21
        Me.lbDevice2.Text = "-"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 462)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 27)
        Me.Label20.TabIndex = 214
        Me.Label20.Text = "Lot Info.      "
        '
        'lbInput2
        '
        Me.lbInput2.AutoSize = True
        Me.lbInput2.BackColor = System.Drawing.Color.Transparent
        Me.lbInput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbInput2.Location = New System.Drawing.Point(157, 179)
        Me.lbInput2.Name = "lbInput2"
        Me.lbInput2.Size = New System.Drawing.Size(19, 25)
        Me.lbInput2.TabIndex = 25
        Me.lbInput2.Text = "-"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 412)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 27)
        Me.Label22.TabIndex = 214
        Me.Label22.Text = "End Time    "
        '
        'lbStop2
        '
        Me.lbStop2.AutoSize = True
        Me.lbStop2.BackColor = System.Drawing.Color.Transparent
        Me.lbStop2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStop2.Location = New System.Drawing.Point(156, 412)
        Me.lbStop2.Name = "lbStop2"
        Me.lbStop2.Size = New System.Drawing.Size(19, 25)
        Me.lbStop2.TabIndex = 26
        Me.lbStop2.Text = "-"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 366)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(135, 27)
        Me.Label24.TabIndex = 214
        Me.Label24.Text = "Start Time   "
        '
        'lbStart2
        '
        Me.lbStart2.AutoSize = True
        Me.lbStart2.BackColor = System.Drawing.Color.Transparent
        Me.lbStart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStart2.Location = New System.Drawing.Point(156, 364)
        Me.lbStart2.Name = "lbStart2"
        Me.lbStart2.Size = New System.Drawing.Size(19, 25)
        Me.lbStart2.TabIndex = 27
        Me.lbStart2.Text = "-"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TpProductData)
        Me.TabControl1.Controls.Add(Me.TPMaintenance)
        Me.TabControl1.Controls.Add(Me.ComLog)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(71, 45)
        Me.TabControl1.Location = New System.Drawing.Point(626, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(596, 458)
        Me.TabControl1.TabIndex = 36
        '
        'TpProductData
        '
        Me.TpProductData.BackColor = System.Drawing.SystemColors.Control
        Me.TpProductData.Controls.Add(Me.gbxLotEnd)
        Me.TpProductData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TpProductData.Location = New System.Drawing.Point(4, 49)
        Me.TpProductData.Name = "TpProductData"
        Me.TpProductData.Size = New System.Drawing.Size(588, 405)
        Me.TpProductData.TabIndex = 2
        Me.TpProductData.Text = "Product Mode"
        Me.TpProductData.UseVisualStyleBackColor = True
        '
        'gbxLotEnd
        '
        Me.gbxLotEnd.Controls.Add(Me.radResetEnd)
        Me.gbxLotEnd.Controls.Add(Me.radAccuEnd)
        Me.gbxLotEnd.Controls.Add(Me.radNormalEnd)
        Me.gbxLotEnd.Location = New System.Drawing.Point(46, 60)
        Me.gbxLotEnd.Name = "gbxLotEnd"
        Me.gbxLotEnd.Size = New System.Drawing.Size(198, 140)
        Me.gbxLotEnd.TabIndex = 1
        Me.gbxLotEnd.TabStop = False
        Me.gbxLotEnd.Text = "Lot End Mode"
        '
        'radResetEnd
        '
        Me.radResetEnd.AutoSize = True
        Me.radResetEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radResetEnd.Location = New System.Drawing.Point(24, 104)
        Me.radResetEnd.Name = "radResetEnd"
        Me.radResetEnd.Size = New System.Drawing.Size(101, 20)
        Me.radResetEnd.TabIndex = 2
        Me.radResetEnd.TabStop = True
        Me.radResetEnd.Text = "Re Input (All)"
        Me.radResetEnd.UseVisualStyleBackColor = True
        '
        'radAccuEnd
        '
        Me.radAccuEnd.AutoSize = True
        Me.radAccuEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAccuEnd.Location = New System.Drawing.Point(24, 66)
        Me.radAccuEnd.Name = "radAccuEnd"
        Me.radAccuEnd.Size = New System.Drawing.Size(71, 20)
        Me.radAccuEnd.TabIndex = 1
        Me.radAccuEnd.TabStop = True
        Me.radAccuEnd.Text = "Reload"
        Me.radAccuEnd.UseVisualStyleBackColor = True
        '
        'radNormalEnd
        '
        Me.radNormalEnd.AutoSize = True
        Me.radNormalEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNormalEnd.Location = New System.Drawing.Point(24, 28)
        Me.radNormalEnd.Name = "radNormalEnd"
        Me.radNormalEnd.Size = New System.Drawing.Size(97, 20)
        Me.radNormalEnd.TabIndex = 0
        Me.radNormalEnd.TabStop = True
        Me.radNormalEnd.Text = "Normal End"
        Me.radNormalEnd.UseVisualStyleBackColor = True
        '
        'TPMaintenance
        '
        Me.TPMaintenance.BackColor = System.Drawing.Color.Transparent
        Me.TPMaintenance.Controls.Add(Me.LbCounterFile)
        Me.TPMaintenance.Controls.Add(Me.Button1)
        Me.TPMaintenance.Controls.Add(Me.BtSetting)
        Me.TPMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPMaintenance.Location = New System.Drawing.Point(4, 49)
        Me.TPMaintenance.Name = "TPMaintenance"
        Me.TPMaintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.TPMaintenance.Size = New System.Drawing.Size(588, 405)
        Me.TPMaintenance.TabIndex = 0
        Me.TPMaintenance.Text = "Maintenance"
        Me.TPMaintenance.UseVisualStyleBackColor = True
        '
        'LbCounterFile
        '
        Me.LbCounterFile.AutoSize = True
        Me.LbCounterFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCounterFile.Location = New System.Drawing.Point(55, 71)
        Me.LbCounterFile.Name = "LbCounterFile"
        Me.LbCounterFile.Size = New System.Drawing.Size(13, 13)
        Me.LbCounterFile.TabIndex = 52
        Me.LbCounterFile.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(48, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 60)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtSetting
        '
        Me.BtSetting.BackgroundImage = CType(resources.GetObject("BtSetting.BackgroundImage"), System.Drawing.Image)
        Me.BtSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSetting.Location = New System.Drawing.Point(193, 24)
        Me.BtSetting.Name = "BtSetting"
        Me.BtSetting.Size = New System.Drawing.Size(100, 60)
        Me.BtSetting.TabIndex = 3
        Me.BtSetting.UseVisualStyleBackColor = True
        '
        'ComLog
        '
        Me.ComLog.BackColor = System.Drawing.Color.Transparent
        Me.ComLog.Controls.Add(Me.lbLotReq)
        Me.ComLog.Controls.Add(Me.lbLotSetEnd)
        Me.ComLog.Controls.Add(Me.cbSDGood)
        Me.ComLog.Controls.Add(Me.CommLog)
        Me.ComLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComLog.Location = New System.Drawing.Point(4, 49)
        Me.ComLog.Name = "ComLog"
        Me.ComLog.Padding = New System.Windows.Forms.Padding(3)
        Me.ComLog.Size = New System.Drawing.Size(588, 405)
        Me.ComLog.TabIndex = 1
        Me.ComLog.Text = "    ComLog    "
        Me.ComLog.UseVisualStyleBackColor = True
        '
        'lbLotReq
        '
        Me.lbLotReq.AutoSize = True
        Me.lbLotReq.BackColor = System.Drawing.Color.Tomato
        Me.lbLotReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotReq.Location = New System.Drawing.Point(15, 426)
        Me.lbLotReq.Name = "lbLotReq"
        Me.lbLotReq.Size = New System.Drawing.Size(72, 17)
        Me.lbLotReq.TabIndex = 212
        Me.lbLotReq.Text = "LOTREQ"
        '
        'lbLotSetEnd
        '
        Me.lbLotSetEnd.AutoSize = True
        Me.lbLotSetEnd.BackColor = System.Drawing.Color.Tomato
        Me.lbLotSetEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotSetEnd.Location = New System.Drawing.Point(15, 448)
        Me.lbLotSetEnd.Name = "lbLotSetEnd"
        Me.lbLotSetEnd.Size = New System.Drawing.Size(106, 17)
        Me.lbLotSetEnd.TabIndex = 212
        Me.lbLotSetEnd.Text = "LOTSET/END"
        '
        'cbSDGood
        '
        Me.cbSDGood.AutoSize = True
        Me.cbSDGood.Checked = True
        Me.cbSDGood.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSDGood.Location = New System.Drawing.Point(38, 489)
        Me.cbSDGood.Name = "cbSDGood"
        Me.cbSDGood.Size = New System.Drawing.Size(83, 20)
        Me.cbSDGood.TabIndex = 3
        Me.cbSDGood.Text = "SD Good"
        Me.cbSDGood.UseVisualStyleBackColor = True
        '
        'CommLog
        '
        Me.CommLog.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CommLog.Location = New System.Drawing.Point(2, 3)
        Me.CommLog.Multiline = True
        Me.CommLog.Name = "CommLog"
        Me.CommLog.ReadOnly = True
        Me.CommLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CommLog.Size = New System.Drawing.Size(473, 402)
        Me.CommLog.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Location = New System.Drawing.Point(4, 49)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(588, 405)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "AlarmInfo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button20)
        Me.TabPage2.Controls.Add(Me.Button19)
        Me.TabPage2.Controls.Add(Me.Button18)
        Me.TabPage2.Controls.Add(Me.Button16)
        Me.TabPage2.Controls.Add(Me.Button15)
        Me.TabPage2.Controls.Add(Me.Button14)
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 49)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(588, 405)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Test"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(285, 286)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 8
        Me.Button20.Text = "LOTEND"
        Me.Button20.UseVisualStyleBackColor = True
        Me.Button20.Visible = False
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(285, 212)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(75, 23)
        Me.Button19.TabIndex = 7
        Me.Button19.Text = "LOTREQ"
        Me.Button19.UseVisualStyleBackColor = True
        Me.Button19.Visible = False
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(285, 241)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 23)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "LotSet"
        Me.Button18.UseVisualStyleBackColor = True
        Me.Button18.Visible = False
        '
        'Button16
        '
        Me.Button16.Enabled = False
        Me.Button16.Location = New System.Drawing.Point(132, 419)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = "MC1 SD2"
        Me.Button16.UseVisualStyleBackColor = True
        Me.Button16.Visible = False
        '
        'Button15
        '
        Me.Button15.Enabled = False
        Me.Button15.Location = New System.Drawing.Point(300, 172)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        Me.Button15.Visible = False
        '
        'Button14
        '
        Me.Button14.Enabled = False
        Me.Button14.Location = New System.Drawing.Point(161, 354)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(187, 23)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "vbcr,vbcr,text"
        Me.Button14.UseVisualStyleBackColor = True
        Me.Button14.Visible = False
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(262, 79)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "MC3 LR"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(161, 79)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "MC2 LR"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.Location = New System.Drawing.Point(218, 419)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Vbcr,vbcr"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(161, 286)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "MC2 End"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(161, 241)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "MC2 SC"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(51, 419)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "MC1 LR"
        Me.Button12.UseVisualStyleBackColor = True
        Me.Button12.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "MC1 Start"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(161, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "MC2 SD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(161, 126)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "MC2 Start"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(51, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "MC1 SD"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(137, 477)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "MC1 End"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(137, 446)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "MC1 SC"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 318)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 27)
        Me.Label26.TabIndex = 214
        Me.Label26.Text = "Group Name"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.Location = New System.Drawing.Point(17, 271)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(135, 27)
        Me.Label28.TabIndex = 214
        Me.Label28.Text = "Magazine    "
        '
        'LbGroup2
        '
        Me.LbGroup2.AutoSize = True
        Me.LbGroup2.BackColor = System.Drawing.Color.Transparent
        Me.LbGroup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbGroup2.Location = New System.Drawing.Point(156, 318)
        Me.LbGroup2.Name = "LbGroup2"
        Me.LbGroup2.Size = New System.Drawing.Size(19, 25)
        Me.LbGroup2.TabIndex = 45
        Me.LbGroup2.Text = "-"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.Location = New System.Drawing.Point(17, 225)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 27)
        Me.Label30.TabIndex = 214
        Me.Label30.Text = "Output Qty  "
        '
        'LbMagazine2
        '
        Me.LbMagazine2.AutoSize = True
        Me.LbMagazine2.BackColor = System.Drawing.Color.Transparent
        Me.LbMagazine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbMagazine2.Location = New System.Drawing.Point(157, 271)
        Me.LbMagazine2.Name = "LbMagazine2"
        Me.LbMagazine2.Size = New System.Drawing.Size(19, 25)
        Me.LbMagazine2.TabIndex = 51
        Me.LbMagazine2.Text = "-"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.Location = New System.Drawing.Point(17, 179)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(135, 27)
        Me.Label32.TabIndex = 214
        Me.Label32.Text = "Input Qty     "
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(17, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(135, 27)
        Me.Label33.TabIndex = 214
        Me.Label33.Text = "OP No.        "
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.Location = New System.Drawing.Point(17, 137)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 27)
        Me.Label34.TabIndex = 214
        Me.Label34.Text = "Device         "
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label35.Location = New System.Drawing.Point(17, 54)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(135, 27)
        Me.Label35.TabIndex = 214
        Me.Label35.Text = "Lot No.        "
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(17, 95)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(134, 27)
        Me.Label36.TabIndex = 214
        Me.Label36.Text = "Package      "
        '
        'ReflowAlarmTableTableAdapter
        '
        Me.ReflowAlarmTableTableAdapter.ClearBeforeFill = True
        '
        'ReflowAlarmInfoTableAdapter
        '
        Me.ReflowAlarmInfoTableAdapter.ClearBeforeFill = True
        '
        'ReflowDataTableAdapter
        '
        Me.ReflowDataTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1156, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 63)
        Me.PictureBox1.TabIndex = 216
        Me.PictureBox1.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(970, 90)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(63, 55)
        Me.MinimizeButton.TabIndex = 18
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'APCSClose
        '
        Me.APCSClose.BackColor = System.Drawing.Color.Transparent
        Me.APCSClose.BackgroundImage = CType(resources.GetObject("APCSClose.BackgroundImage"), System.Drawing.Image)
        Me.APCSClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.APCSClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.APCSClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.APCSClose.Location = New System.Drawing.Point(1041, 90)
        Me.APCSClose.Name = "APCSClose"
        Me.APCSClose.Size = New System.Drawing.Size(64, 55)
        Me.APCSClose.TabIndex = 53
        Me.APCSClose.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(29, 205)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1239, 815)
        Me.TabControl2.TabIndex = 222
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.PanelNextLot)
        Me.TabPage3.Controls.Add(Me.PanelLot2)
        Me.TabPage3.Controls.Add(Me.PanelLot1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.lbMC)
        Me.TabPage3.Controls.Add(Me.lbIp)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.lbNetversion)
        Me.TabPage3.Controls.Add(Me.LbVersion)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1231, 789)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Production"
        '
        'PanelNextLot
        '
        Me.PanelNextLot.BackColor = System.Drawing.Color.Silver
        Me.PanelNextLot.Controls.Add(Me.Panel4)
        Me.PanelNextLot.Location = New System.Drawing.Point(6, 37)
        Me.PanelNextLot.Name = "PanelNextLot"
        Me.PanelNextLot.Size = New System.Drawing.Size(1218, 68)
        Me.PanelNextLot.TabIndex = 225
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.TextBoxNotificationNextLot)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.LabelNextLot)
        Me.Panel4.Location = New System.Drawing.Point(4, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1202, 51)
        Me.Panel4.TabIndex = 225
        '
        'TextBoxNotificationNextLot
        '
        Me.TextBoxNotificationNextLot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNotificationNextLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNotificationNextLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNotificationNextLot.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBoxNotificationNextLot.Location = New System.Drawing.Point(495, 11)
        Me.TextBoxNotificationNextLot.Multiline = True
        Me.TextBoxNotificationNextLot.Name = "TextBoxNotificationNextLot"
        Me.TextBoxNotificationNextLot.Size = New System.Drawing.Size(603, 27)
        Me.TextBoxNotificationNextLot.TabIndex = 226
        Me.TextBoxNotificationNextLot.Text = "-"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(351, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 27)
        Me.Label15.TabIndex = 225
        Me.Label15.Text = "Lot Info.      :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 25)
        Me.Label16.TabIndex = 224
        Me.Label16.Text = "Next Lot    : "
        '
        'LabelNextLot
        '
        Me.LabelNextLot.AutoSize = True
        Me.LabelNextLot.BackColor = System.Drawing.Color.Transparent
        Me.LabelNextLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelNextLot.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelNextLot.Location = New System.Drawing.Point(160, 13)
        Me.LabelNextLot.Name = "LabelNextLot"
        Me.LabelNextLot.Size = New System.Drawing.Size(20, 25)
        Me.LabelNextLot.TabIndex = 223
        Me.LabelNextLot.Text = "-"
        '
        'PanelLot2
        '
        Me.PanelLot2.BackColor = System.Drawing.Color.Silver
        Me.PanelLot2.Controls.Add(Me.Panel2)
        Me.PanelLot2.Location = New System.Drawing.Point(619, 111)
        Me.PanelLot2.Name = "PanelLot2"
        Me.PanelLot2.Size = New System.Drawing.Size(609, 660)
        Me.PanelLot2.TabIndex = 222
        '
        'PanelLot1
        '
        Me.PanelLot1.BackColor = System.Drawing.Color.Silver
        Me.PanelLot1.Controls.Add(Me.Panel1)
        Me.PanelLot1.Location = New System.Drawing.Point(6, 111)
        Me.PanelLot1.Name = "PanelLot1"
        Me.PanelLot1.Size = New System.Drawing.Size(609, 660)
        Me.PanelLot1.TabIndex = 216
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1231, 789)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Alarm"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReflowDataDataGridView)
        Me.Panel3.Controls.Add(Me.ReflowAlarmInfoDataGridView)
        Me.Panel3.Controls.Add(Me.ReflowAlarmTableDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1225, 783)
        Me.Panel3.TabIndex = 0
        '
        'ReflowDataDataGridView
        '
        Me.ReflowDataDataGridView.AllowUserToAddRows = False
        Me.ReflowDataDataGridView.AllowUserToDeleteRows = False
        Me.ReflowDataDataGridView.AutoGenerateColumns = False
        Me.ReflowDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNoDataGridViewTextBoxColumn1, Me.MCNoDataGridViewTextBoxColumn1, Me.LotStartTimeDataGridViewTextBoxColumn, Me.OPNoDataGridViewTextBoxColumn, Me.InputQtyDataGridViewTextBoxColumn, Me.OutputQtyDataGridViewTextBoxColumn, Me.LotEndTimeDataGridViewTextBoxColumn, Me.MagazineNoDataGridViewTextBoxColumn, Me.TemperatureGroupDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.AlarmTotalDataGridViewTextBoxColumn})
        Me.ReflowDataDataGridView.DataSource = Me.ReflowDataBindingSource
        Me.ReflowDataDataGridView.Location = New System.Drawing.Point(15, 272)
        Me.ReflowDataDataGridView.Name = "ReflowDataDataGridView"
        Me.ReflowDataDataGridView.ReadOnly = True
        Me.ReflowDataDataGridView.Size = New System.Drawing.Size(1194, 234)
        Me.ReflowDataDataGridView.TabIndex = 4
        '
        'LotNoDataGridViewTextBoxColumn1
        '
        Me.LotNoDataGridViewTextBoxColumn1.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn1.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn1.Name = "LotNoDataGridViewTextBoxColumn1"
        Me.LotNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MCNoDataGridViewTextBoxColumn1
        '
        Me.MCNoDataGridViewTextBoxColumn1.DataPropertyName = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn1.HeaderText = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn1.Name = "MCNoDataGridViewTextBoxColumn1"
        Me.MCNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LotStartTimeDataGridViewTextBoxColumn
        '
        Me.LotStartTimeDataGridViewTextBoxColumn.DataPropertyName = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.HeaderText = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.Name = "LotStartTimeDataGridViewTextBoxColumn"
        Me.LotStartTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoDataGridViewTextBoxColumn
        '
        Me.OPNoDataGridViewTextBoxColumn.DataPropertyName = "OPNo"
        Me.OPNoDataGridViewTextBoxColumn.HeaderText = "OPNo"
        Me.OPNoDataGridViewTextBoxColumn.Name = "OPNoDataGridViewTextBoxColumn"
        Me.OPNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InputQtyDataGridViewTextBoxColumn
        '
        Me.InputQtyDataGridViewTextBoxColumn.DataPropertyName = "InputQty"
        Me.InputQtyDataGridViewTextBoxColumn.HeaderText = "InputQty"
        Me.InputQtyDataGridViewTextBoxColumn.Name = "InputQtyDataGridViewTextBoxColumn"
        Me.InputQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OutputQtyDataGridViewTextBoxColumn
        '
        Me.OutputQtyDataGridViewTextBoxColumn.DataPropertyName = "OutputQty"
        Me.OutputQtyDataGridViewTextBoxColumn.HeaderText = "OutputQty"
        Me.OutputQtyDataGridViewTextBoxColumn.Name = "OutputQtyDataGridViewTextBoxColumn"
        Me.OutputQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotEndTimeDataGridViewTextBoxColumn
        '
        Me.LotEndTimeDataGridViewTextBoxColumn.DataPropertyName = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.HeaderText = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.Name = "LotEndTimeDataGridViewTextBoxColumn"
        Me.LotEndTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MagazineNoDataGridViewTextBoxColumn
        '
        Me.MagazineNoDataGridViewTextBoxColumn.DataPropertyName = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.HeaderText = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.Name = "MagazineNoDataGridViewTextBoxColumn"
        Me.MagazineNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TemperatureGroupDataGridViewTextBoxColumn
        '
        Me.TemperatureGroupDataGridViewTextBoxColumn.DataPropertyName = "TemperatureGroup"
        Me.TemperatureGroupDataGridViewTextBoxColumn.HeaderText = "TemperatureGroup"
        Me.TemperatureGroupDataGridViewTextBoxColumn.Name = "TemperatureGroupDataGridViewTextBoxColumn"
        Me.TemperatureGroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlarmTotalDataGridViewTextBoxColumn
        '
        Me.AlarmTotalDataGridViewTextBoxColumn.DataPropertyName = "AlarmTotal"
        Me.AlarmTotalDataGridViewTextBoxColumn.HeaderText = "AlarmTotal"
        Me.AlarmTotalDataGridViewTextBoxColumn.Name = "AlarmTotalDataGridViewTextBoxColumn"
        Me.AlarmTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReflowAlarmInfoDataGridView
        '
        Me.ReflowAlarmInfoDataGridView.AllowUserToAddRows = False
        Me.ReflowAlarmInfoDataGridView.AutoGenerateColumns = False
        Me.ReflowAlarmInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowAlarmInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordTimeDataGridViewTextBoxColumn, Me.MCNoDataGridViewTextBoxColumn, Me.AlarmIDDataGridViewTextBoxColumn, Me.LotNoDataGridViewTextBoxColumn, Me.ClearTimeDataGridViewTextBoxColumn})
        Me.ReflowAlarmInfoDataGridView.DataSource = Me.ReflowAlarmInfoBindingSource
        Me.ReflowAlarmInfoDataGridView.Location = New System.Drawing.Point(642, 24)
        Me.ReflowAlarmInfoDataGridView.Name = "ReflowAlarmInfoDataGridView"
        Me.ReflowAlarmInfoDataGridView.Size = New System.Drawing.Size(567, 220)
        Me.ReflowAlarmInfoDataGridView.TabIndex = 2
        '
        'RecordTimeDataGridViewTextBoxColumn
        '
        Me.RecordTimeDataGridViewTextBoxColumn.DataPropertyName = "RecordTime"
        Me.RecordTimeDataGridViewTextBoxColumn.HeaderText = "RecordTime"
        Me.RecordTimeDataGridViewTextBoxColumn.Name = "RecordTimeDataGridViewTextBoxColumn"
        '
        'MCNoDataGridViewTextBoxColumn
        '
        Me.MCNoDataGridViewTextBoxColumn.DataPropertyName = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.HeaderText = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.Name = "MCNoDataGridViewTextBoxColumn"
        '
        'AlarmIDDataGridViewTextBoxColumn
        '
        Me.AlarmIDDataGridViewTextBoxColumn.DataPropertyName = "AlarmID"
        Me.AlarmIDDataGridViewTextBoxColumn.HeaderText = "AlarmID"
        Me.AlarmIDDataGridViewTextBoxColumn.Name = "AlarmIDDataGridViewTextBoxColumn"
        '
        'LotNoDataGridViewTextBoxColumn
        '
        Me.LotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.Name = "LotNoDataGridViewTextBoxColumn"
        '
        'ClearTimeDataGridViewTextBoxColumn
        '
        Me.ClearTimeDataGridViewTextBoxColumn.DataPropertyName = "ClearTime"
        Me.ClearTimeDataGridViewTextBoxColumn.HeaderText = "ClearTime"
        Me.ClearTimeDataGridViewTextBoxColumn.Name = "ClearTimeDataGridViewTextBoxColumn"
        '
        'ReflowAlarmTableDataGridView
        '
        Me.ReflowAlarmTableDataGridView.AllowUserToAddRows = False
        Me.ReflowAlarmTableDataGridView.AllowUserToDeleteRows = False
        Me.ReflowAlarmTableDataGridView.AutoGenerateColumns = False
        Me.ReflowAlarmTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowAlarmTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AlarmNoDataGridViewTextBoxColumn, Me.MachineTypeDataGridViewTextBoxColumn, Me.AlarmTypeDataGridViewTextBoxColumn, Me.AlarmMessageDataGridViewTextBoxColumn})
        Me.ReflowAlarmTableDataGridView.DataSource = Me.ReflowAlarmTableBindingSource
        Me.ReflowAlarmTableDataGridView.Location = New System.Drawing.Point(15, 24)
        Me.ReflowAlarmTableDataGridView.Name = "ReflowAlarmTableDataGridView"
        Me.ReflowAlarmTableDataGridView.ReadOnly = True
        Me.ReflowAlarmTableDataGridView.Size = New System.Drawing.Size(594, 220)
        Me.ReflowAlarmTableDataGridView.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlarmNoDataGridViewTextBoxColumn
        '
        Me.AlarmNoDataGridViewTextBoxColumn.DataPropertyName = "AlarmNo"
        Me.AlarmNoDataGridViewTextBoxColumn.HeaderText = "AlarmNo"
        Me.AlarmNoDataGridViewTextBoxColumn.Name = "AlarmNoDataGridViewTextBoxColumn"
        Me.AlarmNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MachineTypeDataGridViewTextBoxColumn
        '
        Me.MachineTypeDataGridViewTextBoxColumn.DataPropertyName = "MachineType"
        Me.MachineTypeDataGridViewTextBoxColumn.HeaderText = "MachineType"
        Me.MachineTypeDataGridViewTextBoxColumn.Name = "MachineTypeDataGridViewTextBoxColumn"
        Me.MachineTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlarmTypeDataGridViewTextBoxColumn
        '
        Me.AlarmTypeDataGridViewTextBoxColumn.DataPropertyName = "AlarmType"
        Me.AlarmTypeDataGridViewTextBoxColumn.HeaderText = "AlarmType"
        Me.AlarmTypeDataGridViewTextBoxColumn.Name = "AlarmTypeDataGridViewTextBoxColumn"
        Me.AlarmTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlarmMessageDataGridViewTextBoxColumn
        '
        Me.AlarmMessageDataGridViewTextBoxColumn.DataPropertyName = "AlarmMessage"
        Me.AlarmMessageDataGridViewTextBoxColumn.HeaderText = "AlarmMessage"
        Me.AlarmMessageDataGridViewTextBoxColumn.Name = "AlarmMessageDataGridViewTextBoxColumn"
        Me.AlarmMessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ButtonReload
        '
        Me.ButtonReload.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReload.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReload.ForeColor = System.Drawing.Color.Black
        Me.ButtonReload.Location = New System.Drawing.Point(21, 574)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(269, 62)
        Me.ButtonReload.TabIndex = 216
        Me.ButtonReload.Text = "Reload"
        Me.ButtonReload.UseVisualStyleBackColor = False
        '
        'ButtonReload2
        '
        Me.ButtonReload2.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonReload2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReload2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReload2.ForeColor = System.Drawing.Color.Black
        Me.ButtonReload2.Location = New System.Drawing.Point(16, 575)
        Me.ButtonReload2.Name = "ButtonReload2"
        Me.ButtonReload2.Size = New System.Drawing.Size(269, 62)
        Me.ButtonReload2.TabIndex = 216
        Me.ButtonReload2.Text = "Reload"
        Me.ButtonReload2.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1280, 1026)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.APCSClose)
        Me.Controls.Add(Me.Lbtime)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1280, 835)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Self Controller"
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TpProductData.ResumeLayout(False)
        Me.gbxLotEnd.ResumeLayout(False)
        Me.gbxLotEnd.PerformLayout()
        Me.TPMaintenance.ResumeLayout(False)
        Me.TPMaintenance.PerformLayout()
        Me.ComLog.ResumeLayout(False)
        Me.ComLog.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.PanelNextLot.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelLot2.ResumeLayout(False)
        Me.PanelLot1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbStart1 As System.Windows.Forms.Label
    Friend WithEvents lbIp As System.Windows.Forms.Label
    Friend WithEvents lbOpNo1 As System.Windows.Forms.Label
    Friend WithEvents lbStop1 As System.Windows.Forms.Label
    Friend WithEvents lbInput1 As System.Windows.Forms.Label
    Friend WithEvents lbDevice1 As System.Windows.Forms.Label
    Friend WithEvents lbOutput1 As System.Windows.Forms.Label
    Friend WithEvents lbPackage1 As System.Windows.Forms.Label
    Friend WithEvents lbLotNo1 As System.Windows.Forms.Label
    Friend WithEvents lbMC As System.Windows.Forms.Label
    Friend WithEvents LbGroup1 As System.Windows.Forms.Label
    Friend WithEvents LbVersion As System.Windows.Forms.Label
    Friend WithEvents Lbtime As System.Windows.Forms.Label
    Friend WithEvents TimerDateTime As System.Windows.Forms.Timer
    Friend WithEvents BtEndLot As System.Windows.Forms.Button
    Friend WithEvents LbMagazine1 As System.Windows.Forms.Label
    Friend WithEvents ReflowAlarmTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowAlarmTableTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmTableTableAdapter
    Friend WithEvents ReflowAlarmInfoTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmInfoTableAdapter
    Friend WithEvents ReflowAlarmInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowDataTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter
    Friend WithEvents DBxDataSet As WindowsApplication1.DBxDataSet
    Friend WithEvents bgTDC As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgTDCLotReq As System.ComponentModel.BackgroundWorker
    Friend WithEvents ANDONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WORKRECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMREQUESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PMREPAIRINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndonToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkRecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMRequestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PMRepairingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndonToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkRecordToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMRequestToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PMRepairingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndonToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AndonToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkRecordToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMRequestToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PMRepairingToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbNetversion As System.Windows.Forms.Label
    Friend WithEvents WIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtEndLot2 As Button
    Friend WithEvents lbOpNo2 As Label
    Friend WithEvents lbLotNo2 As Label
    Friend WithEvents lbPackage2 As Label
    Friend WithEvents lbOutput2 As Label
    Friend WithEvents lbDevice2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbInput2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbStop2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lbStart2 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents LbGroup2 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LbMagazine2 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents APCSClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxNotification1 As TextBox
    Friend WithEvents TextBoxNotification2 As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ReflowDataDataGridView As DataGridView
    Friend WithEvents LotNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LotStartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InputQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutputQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotEndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MagazineNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemperatureGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReflowAlarmInfoDataGridView As DataGridView
    Friend WithEvents RecordTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClearTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReflowAlarmTableDataGridView As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmMessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpProductData As TabPage
    Friend WithEvents gbxLotEnd As GroupBox
    Friend WithEvents radResetEnd As RadioButton
    Friend WithEvents radAccuEnd As RadioButton
    Friend WithEvents radNormalEnd As RadioButton
    Friend WithEvents TPMaintenance As TabPage
    Friend WithEvents LbCounterFile As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtSetting As Button
    Friend WithEvents ComLog As TabPage
    Friend WithEvents lbLotReq As Label
    Friend WithEvents lbLotSetEnd As Label
    Friend WithEvents cbSDGood As CheckBox
    Friend WithEvents CommLog As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TestFuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelLot2 As Panel
    Friend WithEvents PanelLot1 As Panel
    Friend WithEvents LabelNextLot As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelNextLot As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxNotificationNextLot As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonReload As Button
    Friend WithEvents ButtonReload2 As Button
End Class
