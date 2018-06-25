<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbStart = New System.Windows.Forms.Label()
        Me.lbIp = New System.Windows.Forms.Label()
        Me.lbOp = New System.Windows.Forms.Label()
        Me.lbStop = New System.Windows.Forms.Label()
        Me.lbInput = New System.Windows.Forms.Label()
        Me.lbDevice = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.lbPackage = New System.Windows.Forms.Label()
        Me.lbLotNo = New System.Windows.Forms.Label()
        Me.lbMC = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpProductData = New System.Windows.Forms.TabPage()
        Me.BtEndLot = New System.Windows.Forms.Button()
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
        Me.BtClearLog = New System.Windows.Forms.Button()
        Me.CommLog = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.ReflowDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBxDataSet = New WindowsApplication1.DBxDataSet()
        Me.ReflowAlarmInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClearTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflowAlarmInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReflowAlarmTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflowAlarmTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.APCSClose = New System.Windows.Forms.Button()
        Me.lbNotification = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.LbGroup = New System.Windows.Forms.Label()
        Me.LbVersion = New System.Windows.Forms.Label()
        Me.Lbtime = New System.Windows.Forms.Label()
        Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.LbMagazine = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReflowAlarmTableTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmTableTableAdapter()
        Me.ReflowAlarmInfoTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmInfoTableAdapter()
        Me.ReflowDataTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter()
        Me.lbNetversion = New System.Windows.Forms.Label()
        Me.lbStatusMC = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TpProductData.SuspendLayout()
        Me.gbxLotEnd.SuspendLayout()
        Me.TPMaintenance.SuspendLayout()
        Me.ComLog.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbStart
        '
        Me.lbStart.AutoSize = True
        Me.lbStart.BackColor = System.Drawing.Color.Transparent
        Me.lbStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStart.Location = New System.Drawing.Point(367, 977)
        Me.lbStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStart.Name = "lbStart"
        Me.lbStart.Size = New System.Drawing.Size(123, 29)
        Me.lbStart.TabIndex = 27
        Me.lbStart.Text = "StartTime"
        '
        'lbIp
        '
        Me.lbIp.AutoSize = True
        Me.lbIp.BackColor = System.Drawing.Color.Transparent
        Me.lbIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbIp.ForeColor = System.Drawing.Color.Black
        Me.lbIp.Location = New System.Drawing.Point(367, 286)
        Me.lbIp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbIp.Name = "lbIp"
        Me.lbIp.Size = New System.Drawing.Size(38, 29)
        Me.lbIp.TabIndex = 29
        Me.lbIp.Text = "IP"
        '
        'lbOp
        '
        Me.lbOp.AutoSize = True
        Me.lbOp.BackColor = System.Drawing.Color.Transparent
        Me.lbOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOp.Location = New System.Drawing.Point(367, 409)
        Me.lbOp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOp.Name = "lbOp"
        Me.lbOp.Size = New System.Drawing.Size(81, 29)
        Me.lbOp.TabIndex = 28
        Me.lbOp.Text = "OPNo"
        '
        'lbStop
        '
        Me.lbStop.AutoSize = True
        Me.lbStop.BackColor = System.Drawing.Color.Transparent
        Me.lbStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStop.Location = New System.Drawing.Point(367, 1055)
        Me.lbStop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStop.Name = "lbStop"
        Me.lbStop.Size = New System.Drawing.Size(122, 29)
        Me.lbStop.TabIndex = 26
        Me.lbStop.Text = "StopTime"
        '
        'lbInput
        '
        Me.lbInput.AutoSize = True
        Me.lbInput.BackColor = System.Drawing.Color.Transparent
        Me.lbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbInput.Location = New System.Drawing.Point(367, 686)
        Me.lbInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(68, 29)
        Me.lbInput.TabIndex = 25
        Me.lbInput.Text = "Input"
        '
        'lbDevice
        '
        Me.lbDevice.AutoSize = True
        Me.lbDevice.BackColor = System.Drawing.Color.Transparent
        Me.lbDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDevice.Location = New System.Drawing.Point(367, 615)
        Me.lbDevice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDevice.Name = "lbDevice"
        Me.lbDevice.Size = New System.Drawing.Size(91, 29)
        Me.lbDevice.TabIndex = 21
        Me.lbDevice.Text = "Device"
        '
        'lbOutput
        '
        Me.lbOutput.AutoSize = True
        Me.lbOutput.BackColor = System.Drawing.Color.Transparent
        Me.lbOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutput.Location = New System.Drawing.Point(367, 759)
        Me.lbOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(91, 29)
        Me.lbOutput.TabIndex = 20
        Me.lbOutput.Text = "OutPut"
        '
        'lbPackage
        '
        Me.lbPackage.AutoSize = True
        Me.lbPackage.BackColor = System.Drawing.Color.Transparent
        Me.lbPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPackage.Location = New System.Drawing.Point(367, 548)
        Me.lbPackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPackage.Name = "lbPackage"
        Me.lbPackage.Size = New System.Drawing.Size(112, 29)
        Me.lbPackage.TabIndex = 23
        Me.lbPackage.Text = "Package"
        '
        'lbLotNo
        '
        Me.lbLotNo.AutoSize = True
        Me.lbLotNo.BackColor = System.Drawing.Color.Transparent
        Me.lbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNo.Location = New System.Drawing.Point(367, 476)
        Me.lbLotNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLotNo.Name = "lbLotNo"
        Me.lbLotNo.Size = New System.Drawing.Size(76, 29)
        Me.lbLotNo.TabIndex = 22
        Me.lbLotNo.Text = "Lotno"
        '
        'lbMC
        '
        Me.lbMC.AutoSize = True
        Me.lbMC.BackColor = System.Drawing.Color.Transparent
        Me.lbMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbMC.Location = New System.Drawing.Point(367, 346)
        Me.lbMC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMC.Name = "lbMC"
        Me.lbMC.Size = New System.Drawing.Size(88, 29)
        Me.lbMC.TabIndex = 24
        Me.lbMC.Text = "MCNo"
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
        Me.TabControl1.Location = New System.Drawing.Point(915, 286)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 926)
        Me.TabControl1.TabIndex = 36
        '
        'TpProductData
        '
        Me.TpProductData.BackColor = System.Drawing.SystemColors.Control
        Me.TpProductData.Controls.Add(Me.BtEndLot)
        Me.TpProductData.Controls.Add(Me.gbxLotEnd)
        Me.TpProductData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TpProductData.Location = New System.Drawing.Point(4, 49)
        Me.TpProductData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpProductData.Name = "TpProductData"
        Me.TpProductData.Size = New System.Drawing.Size(768, 873)
        Me.TpProductData.TabIndex = 2
        Me.TpProductData.Text = "Product Mode"
        Me.TpProductData.UseVisualStyleBackColor = True
        '
        'BtEndLot
        '
        Me.BtEndLot.BackColor = System.Drawing.SystemColors.Control
        Me.BtEndLot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEndLot.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEndLot.ForeColor = System.Drawing.Color.Black
        Me.BtEndLot.Location = New System.Drawing.Point(111, 560)
        Me.BtEndLot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtEndLot.Name = "BtEndLot"
        Me.BtEndLot.Size = New System.Drawing.Size(359, 76)
        Me.BtEndLot.TabIndex = 206
        Me.BtEndLot.Text = "End Lot "
        Me.BtEndLot.UseVisualStyleBackColor = False
        '
        'gbxLotEnd
        '
        Me.gbxLotEnd.Controls.Add(Me.radResetEnd)
        Me.gbxLotEnd.Controls.Add(Me.radAccuEnd)
        Me.gbxLotEnd.Controls.Add(Me.radNormalEnd)
        Me.gbxLotEnd.Location = New System.Drawing.Point(61, 74)
        Me.gbxLotEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxLotEnd.Name = "gbxLotEnd"
        Me.gbxLotEnd.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxLotEnd.Size = New System.Drawing.Size(264, 172)
        Me.gbxLotEnd.TabIndex = 1
        Me.gbxLotEnd.TabStop = False
        Me.gbxLotEnd.Text = "Lot End Mode"
        '
        'radResetEnd
        '
        Me.radResetEnd.AutoSize = True
        Me.radResetEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radResetEnd.Location = New System.Drawing.Point(32, 128)
        Me.radResetEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radResetEnd.Name = "radResetEnd"
        Me.radResetEnd.Size = New System.Drawing.Size(128, 24)
        Me.radResetEnd.TabIndex = 2
        Me.radResetEnd.TabStop = True
        Me.radResetEnd.Text = "Re Input (All)"
        Me.radResetEnd.UseVisualStyleBackColor = True
        '
        'radAccuEnd
        '
        Me.radAccuEnd.AutoSize = True
        Me.radAccuEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAccuEnd.Location = New System.Drawing.Point(32, 81)
        Me.radAccuEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radAccuEnd.Name = "radAccuEnd"
        Me.radAccuEnd.Size = New System.Drawing.Size(82, 24)
        Me.radAccuEnd.TabIndex = 1
        Me.radAccuEnd.TabStop = True
        Me.radAccuEnd.Text = "Reload"
        Me.radAccuEnd.UseVisualStyleBackColor = True
        '
        'radNormalEnd
        '
        Me.radNormalEnd.AutoSize = True
        Me.radNormalEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNormalEnd.Location = New System.Drawing.Point(32, 34)
        Me.radNormalEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radNormalEnd.Name = "radNormalEnd"
        Me.radNormalEnd.Size = New System.Drawing.Size(118, 24)
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
        Me.TPMaintenance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPMaintenance.Name = "TPMaintenance"
        Me.TPMaintenance.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPMaintenance.Size = New System.Drawing.Size(768, 873)
        Me.TPMaintenance.TabIndex = 0
        Me.TPMaintenance.Text = "Maintenance"
        Me.TPMaintenance.UseVisualStyleBackColor = True
        '
        'LbCounterFile
        '
        Me.LbCounterFile.AutoSize = True
        Me.LbCounterFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCounterFile.Location = New System.Drawing.Point(73, 87)
        Me.LbCounterFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCounterFile.Name = "LbCounterFile"
        Me.LbCounterFile.Size = New System.Drawing.Size(16, 17)
        Me.LbCounterFile.TabIndex = 52
        Me.LbCounterFile.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(64, 31)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 74)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtSetting
        '
        Me.BtSetting.BackgroundImage = CType(resources.GetObject("BtSetting.BackgroundImage"), System.Drawing.Image)
        Me.BtSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSetting.Location = New System.Drawing.Point(257, 30)
        Me.BtSetting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtSetting.Name = "BtSetting"
        Me.BtSetting.Size = New System.Drawing.Size(133, 74)
        Me.BtSetting.TabIndex = 3
        Me.BtSetting.UseVisualStyleBackColor = True
        '
        'ComLog
        '
        Me.ComLog.BackColor = System.Drawing.Color.Transparent
        Me.ComLog.Controls.Add(Me.lbLotReq)
        Me.ComLog.Controls.Add(Me.lbLotSetEnd)
        Me.ComLog.Controls.Add(Me.cbSDGood)
        Me.ComLog.Controls.Add(Me.BtClearLog)
        Me.ComLog.Controls.Add(Me.CommLog)
        Me.ComLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComLog.Location = New System.Drawing.Point(4, 49)
        Me.ComLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComLog.Name = "ComLog"
        Me.ComLog.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComLog.Size = New System.Drawing.Size(768, 873)
        Me.ComLog.TabIndex = 1
        Me.ComLog.Text = "    ComLog    "
        Me.ComLog.UseVisualStyleBackColor = True
        '
        'lbLotReq
        '
        Me.lbLotReq.AutoSize = True
        Me.lbLotReq.BackColor = System.Drawing.Color.Tomato
        Me.lbLotReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotReq.Location = New System.Drawing.Point(20, 524)
        Me.lbLotReq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLotReq.Name = "lbLotReq"
        Me.lbLotReq.Size = New System.Drawing.Size(84, 20)
        Me.lbLotReq.TabIndex = 212
        Me.lbLotReq.Text = "LOTREQ"
        '
        'lbLotSetEnd
        '
        Me.lbLotSetEnd.AutoSize = True
        Me.lbLotSetEnd.BackColor = System.Drawing.Color.Tomato
        Me.lbLotSetEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotSetEnd.Location = New System.Drawing.Point(20, 551)
        Me.lbLotSetEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLotSetEnd.Name = "lbLotSetEnd"
        Me.lbLotSetEnd.Size = New System.Drawing.Size(125, 20)
        Me.lbLotSetEnd.TabIndex = 212
        Me.lbLotSetEnd.Text = "LOTSET/END"
        '
        'cbSDGood
        '
        Me.cbSDGood.AutoSize = True
        Me.cbSDGood.Checked = True
        Me.cbSDGood.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSDGood.Location = New System.Drawing.Point(51, 602)
        Me.cbSDGood.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSDGood.Name = "cbSDGood"
        Me.cbSDGood.Size = New System.Drawing.Size(100, 24)
        Me.cbSDGood.TabIndex = 3
        Me.cbSDGood.Text = "SD Good"
        Me.cbSDGood.UseVisualStyleBackColor = True
        '
        'BtClearLog
        '
        Me.BtClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtClearLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClearLog.Location = New System.Drawing.Point(477, 556)
        Me.BtClearLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtClearLog.Name = "BtClearLog"
        Me.BtClearLog.Size = New System.Drawing.Size(120, 74)
        Me.BtClearLog.TabIndex = 2
        Me.BtClearLog.Text = "Clear"
        Me.BtClearLog.UseVisualStyleBackColor = True
        '
        'CommLog
        '
        Me.CommLog.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CommLog.Location = New System.Drawing.Point(3, 4)
        Me.CommLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CommLog.Multiline = True
        Me.CommLog.Name = "CommLog"
        Me.CommLog.ReadOnly = True
        Me.CommLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CommLog.Size = New System.Drawing.Size(629, 494)
        Me.CommLog.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ReflowDataDataGridView)
        Me.TabPage1.Controls.Add(Me.ReflowAlarmInfoDataGridView)
        Me.TabPage1.Controls.Add(Me.ReflowAlarmTableDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 49)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(768, 873)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "AlarmInfo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReflowDataDataGridView
        '
        Me.ReflowDataDataGridView.AllowUserToAddRows = False
        Me.ReflowDataDataGridView.AllowUserToDeleteRows = False
        Me.ReflowDataDataGridView.AutoGenerateColumns = False
        Me.ReflowDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNoDataGridViewTextBoxColumn1, Me.MCNoDataGridViewTextBoxColumn1, Me.LotStartTimeDataGridViewTextBoxColumn, Me.OPNoDataGridViewTextBoxColumn, Me.InputQtyDataGridViewTextBoxColumn, Me.OutputQtyDataGridViewTextBoxColumn, Me.LotEndTimeDataGridViewTextBoxColumn, Me.MagazineNoDataGridViewTextBoxColumn, Me.TemperatureGroupDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.AlarmTotalDataGridViewTextBoxColumn})
        Me.ReflowDataDataGridView.DataSource = Me.ReflowDataBindingSource
        Me.ReflowDataDataGridView.Location = New System.Drawing.Point(19, 304)
        Me.ReflowDataDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReflowDataDataGridView.Name = "ReflowDataDataGridView"
        Me.ReflowDataDataGridView.ReadOnly = True
        Me.ReflowDataDataGridView.Size = New System.Drawing.Size(733, 288)
        Me.ReflowDataDataGridView.TabIndex = 2
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
        'ReflowAlarmInfoDataGridView
        '
        Me.ReflowAlarmInfoDataGridView.AllowUserToAddRows = False
        Me.ReflowAlarmInfoDataGridView.AutoGenerateColumns = False
        Me.ReflowAlarmInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowAlarmInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordTimeDataGridViewTextBoxColumn, Me.MCNoDataGridViewTextBoxColumn, Me.AlarmIDDataGridViewTextBoxColumn, Me.LotNoDataGridViewTextBoxColumn, Me.ClearTimeDataGridViewTextBoxColumn})
        Me.ReflowAlarmInfoDataGridView.DataSource = Me.ReflowAlarmInfoBindingSource
        Me.ReflowAlarmInfoDataGridView.Location = New System.Drawing.Point(377, 7)
        Me.ReflowAlarmInfoDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReflowAlarmInfoDataGridView.Name = "ReflowAlarmInfoDataGridView"
        Me.ReflowAlarmInfoDataGridView.Size = New System.Drawing.Size(389, 271)
        Me.ReflowAlarmInfoDataGridView.TabIndex = 1
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
        'ReflowAlarmInfoBindingSource
        '
        Me.ReflowAlarmInfoBindingSource.DataMember = "ReflowAlarmInfo"
        Me.ReflowAlarmInfoBindingSource.DataSource = Me.DBxDataSet
        '
        'ReflowAlarmTableDataGridView
        '
        Me.ReflowAlarmTableDataGridView.AllowUserToAddRows = False
        Me.ReflowAlarmTableDataGridView.AllowUserToDeleteRows = False
        Me.ReflowAlarmTableDataGridView.AutoGenerateColumns = False
        Me.ReflowAlarmTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowAlarmTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AlarmNoDataGridViewTextBoxColumn, Me.MachineTypeDataGridViewTextBoxColumn, Me.AlarmTypeDataGridViewTextBoxColumn, Me.AlarmMessageDataGridViewTextBoxColumn})
        Me.ReflowAlarmTableDataGridView.DataSource = Me.ReflowAlarmTableBindingSource
        Me.ReflowAlarmTableDataGridView.Location = New System.Drawing.Point(19, 7)
        Me.ReflowAlarmTableDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReflowAlarmTableDataGridView.Name = "ReflowAlarmTableDataGridView"
        Me.ReflowAlarmTableDataGridView.ReadOnly = True
        Me.ReflowAlarmTableDataGridView.Size = New System.Drawing.Size(351, 271)
        Me.ReflowAlarmTableDataGridView.TabIndex = 0
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
        'ReflowAlarmTableBindingSource
        '
        Me.ReflowAlarmTableBindingSource.DataMember = "ReflowAlarmTable"
        Me.ReflowAlarmTableBindingSource.DataSource = Me.DBxDataSet
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
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(768, 873)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Test"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(380, 352)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(100, 28)
        Me.Button20.TabIndex = 8
        Me.Button20.Text = "LOTEND"
        Me.Button20.UseVisualStyleBackColor = True
        Me.Button20.Visible = False
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(380, 261)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(100, 28)
        Me.Button19.TabIndex = 7
        Me.Button19.Text = "LOTREQ"
        Me.Button19.UseVisualStyleBackColor = True
        Me.Button19.Visible = False
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(380, 297)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(100, 28)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "LotSet"
        Me.Button18.UseVisualStyleBackColor = True
        Me.Button18.Visible = False
        '
        'Button16
        '
        Me.Button16.Enabled = False
        Me.Button16.Location = New System.Drawing.Point(176, 516)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(100, 28)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = "MC1 SD2"
        Me.Button16.UseVisualStyleBackColor = True
        Me.Button16.Visible = False
        '
        'Button15
        '
        Me.Button15.Enabled = False
        Me.Button15.Location = New System.Drawing.Point(400, 212)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(100, 28)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        Me.Button15.Visible = False
        '
        'Button14
        '
        Me.Button14.Enabled = False
        Me.Button14.Location = New System.Drawing.Point(215, 436)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(249, 28)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "vbcr,vbcr,text"
        Me.Button14.UseVisualStyleBackColor = True
        Me.Button14.Visible = False
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(349, 97)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(100, 28)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "MC3 LR"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(215, 97)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 28)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "MC2 LR"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.Location = New System.Drawing.Point(291, 516)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 28)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Vbcr,vbcr"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(215, 352)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 28)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "MC2 End"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(215, 297)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 28)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "MC2 SC"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(68, 516)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 28)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "MC1 LR"
        Me.Button12.UseVisualStyleBackColor = True
        Me.Button12.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 551)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "MC1 Start"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(215, 212)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 28)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "MC2 SD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(215, 155)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 28)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "MC2 Start"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(68, 587)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "MC1 SD"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(183, 587)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "MC1 End"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(183, 549)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 28)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "MC1 SC"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'APCSClose
        '
        Me.APCSClose.BackColor = System.Drawing.Color.Transparent
        Me.APCSClose.BackgroundImage = CType(resources.GetObject("APCSClose.BackgroundImage"), System.Drawing.Image)
        Me.APCSClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.APCSClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.APCSClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.APCSClose.Location = New System.Drawing.Point(1388, 111)
        Me.APCSClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.APCSClose.Name = "APCSClose"
        Me.APCSClose.Size = New System.Drawing.Size(85, 68)
        Me.APCSClose.TabIndex = 53
        Me.APCSClose.UseVisualStyleBackColor = False
        '
        'lbNotification
        '
        Me.lbNotification.AutoSize = True
        Me.lbNotification.BackColor = System.Drawing.Color.Transparent
        Me.lbNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotification.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbNotification.Location = New System.Drawing.Point(367, 1132)
        Me.lbNotification.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNotification.Name = "lbNotification"
        Me.lbNotification.Size = New System.Drawing.Size(151, 29)
        Me.lbNotification.TabIndex = 37
        Me.lbNotification.Text = "Notification"
        Me.lbNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(1293, 111)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(84, 68)
        Me.MinimizeButton.TabIndex = 18
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'LbGroup
        '
        Me.LbGroup.AutoSize = True
        Me.LbGroup.BackColor = System.Drawing.Color.Transparent
        Me.LbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbGroup.Location = New System.Drawing.Point(367, 906)
        Me.LbGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbGroup.Name = "LbGroup"
        Me.LbGroup.Size = New System.Drawing.Size(150, 29)
        Me.LbGroup.TabIndex = 45
        Me.LbGroup.Text = "GroupName"
        '
        'LbVersion
        '
        Me.LbVersion.AutoSize = True
        Me.LbVersion.BackColor = System.Drawing.Color.White
        Me.LbVersion.Location = New System.Drawing.Point(1308, 1233)
        Me.LbVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbVersion.Name = "LbVersion"
        Me.LbVersion.Size = New System.Drawing.Size(233, 17)
        Me.LbVersion.TabIndex = 47
        Me.LbVersion.Text = "Reflow APCS Software Version 4.00"
        '
        'Lbtime
        '
        Me.Lbtime.AutoSize = True
        Me.Lbtime.BackColor = System.Drawing.Color.Transparent
        Me.Lbtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbtime.Location = New System.Drawing.Point(1456, 79)
        Me.Lbtime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbtime.Name = "Lbtime"
        Me.Lbtime.Size = New System.Drawing.Size(57, 17)
        Me.Lbtime.TabIndex = 48
        Me.Lbtime.Text = "Label3"
        Me.Lbtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerDateTime
        '
        Me.TimerDateTime.Enabled = True
        Me.TimerDateTime.Interval = 500
        '
        'LbMagazine
        '
        Me.LbMagazine.AutoSize = True
        Me.LbMagazine.BackColor = System.Drawing.Color.Transparent
        Me.LbMagazine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LbMagazine.Location = New System.Drawing.Point(367, 830)
        Me.LbMagazine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbMagazine.Name = "LbMagazine"
        Me.LbMagazine.Size = New System.Drawing.Size(123, 29)
        Me.LbMagazine.TabIndex = 51
        Me.LbMagazine.Text = "Magazine"
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
        Me.MenuStrip1.Location = New System.Drawing.Point(68, 204)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 32)
        Me.MenuStrip1.TabIndex = 213
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AndonToolStripMenuItem4
        '
        Me.AndonToolStripMenuItem4.Name = "AndonToolStripMenuItem4"
        Me.AndonToolStripMenuItem4.Size = New System.Drawing.Size(87, 28)
        Me.AndonToolStripMenuItem4.Text = "Andon"
        '
        'WorkRecordToolStripMenuItem3
        '
        Me.WorkRecordToolStripMenuItem3.Name = "WorkRecordToolStripMenuItem3"
        Me.WorkRecordToolStripMenuItem3.Size = New System.Drawing.Size(154, 28)
        Me.WorkRecordToolStripMenuItem3.Text = "Work Record"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(68, 28)
        Me.HelpToolStripMenuItem2.Text = "Help"
        '
        'BMRequestToolStripMenuItem3
        '
        Me.BMRequestToolStripMenuItem3.Name = "BMRequestToolStripMenuItem3"
        Me.BMRequestToolStripMenuItem3.Size = New System.Drawing.Size(143, 28)
        Me.BMRequestToolStripMenuItem3.Text = "BM Request"
        '
        'PMRepairingToolStripMenuItem3
        '
        Me.PMRepairingToolStripMenuItem3.Name = "PMRepairingToolStripMenuItem3"
        Me.PMRepairingToolStripMenuItem3.Size = New System.Drawing.Size(158, 28)
        Me.PMRepairingToolStripMenuItem3.Text = "PM Repairing"
        '
        'SearchToolStripMenuItem3
        '
        Me.SearchToolStripMenuItem3.Name = "SearchToolStripMenuItem3"
        Me.SearchToolStripMenuItem3.Size = New System.Drawing.Size(92, 28)
        Me.SearchToolStripMenuItem3.Text = "Search"
        '
        'WIPToolStripMenuItem
        '
        Me.WIPToolStripMenuItem.Name = "WIPToolStripMenuItem"
        Me.WIPToolStripMenuItem.Size = New System.Drawing.Size(66, 28)
        Me.WIPToolStripMenuItem.Text = "WIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "IP Address  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 31)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "MC No        "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 409)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 31)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "OP No.        "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 476)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 31)
        Me.Label4.TabIndex = 214
        Me.Label4.Text = "Lot No.        "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 548)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 31)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Package      "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 615)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 31)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "Device         "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 686)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 31)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Input Qty     "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 759)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 31)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Output Qty  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(133, 830)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 31)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Magazine    "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 906)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 31)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "Group Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(133, 980)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 31)
        Me.Label11.TabIndex = 214
        Me.Label11.Text = "Start Time   "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(133, 1055)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 31)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "End Time    "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(133, 1132)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 31)
        Me.Label13.TabIndex = 214
        Me.Label13.Text = "Lot Info.      "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label14.Location = New System.Drawing.Point(83, 124)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(288, 67)
        Me.Label14.TabIndex = 215
        Me.Label14.Text = "REFLOW"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1541, 108)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 78)
        Me.PictureBox1.TabIndex = 216
        Me.PictureBox1.TabStop = False
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
        'lbNetversion
        '
        Me.lbNetversion.AutoSize = True
        Me.lbNetversion.Location = New System.Drawing.Point(1553, 1233)
        Me.lbNetversion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNetversion.Name = "lbNetversion"
        Me.lbNetversion.Size = New System.Drawing.Size(59, 17)
        Me.lbNetversion.TabIndex = 217
        Me.lbNetversion.Text = "Label15"
        '
        'lbStatusMC
        '
        Me.lbStatusMC.AutoSize = True
        Me.lbStatusMC.BackColor = System.Drawing.Color.Red
        Me.lbStatusMC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStatusMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStatusMC.Location = New System.Drawing.Point(1524, 210)
        Me.lbStatusMC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatusMC.Name = "lbStatusMC"
        Me.lbStatusMC.Size = New System.Drawing.Size(121, 27)
        Me.lbStatusMC.TabIndex = 212
        Me.lbStatusMC.Text = "Run Offline"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1707, 1094)
        Me.Controls.Add(Me.lbNetversion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbStatusMC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.APCSClose)
        Me.Controls.Add(Me.LbMagazine)
        Me.Controls.Add(Me.Lbtime)
        Me.Controls.Add(Me.LbVersion)
        Me.Controls.Add(Me.LbGroup)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.lbNotification)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbStart)
        Me.Controls.Add(Me.lbIp)
        Me.Controls.Add(Me.lbOp)
        Me.Controls.Add(Me.lbStop)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.lbDevice)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lbPackage)
        Me.Controls.Add(Me.lbLotNo)
        Me.Controls.Add(Me.lbMC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1707, 1028)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Self Controller"
        Me.TabControl1.ResumeLayout(False)
        Me.TpProductData.ResumeLayout(False)
        Me.gbxLotEnd.ResumeLayout(False)
        Me.gbxLotEnd.PerformLayout()
        Me.TPMaintenance.ResumeLayout(False)
        Me.TPMaintenance.PerformLayout()
        Me.ComLog.ResumeLayout(False)
        Me.ComLog.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbStart As System.Windows.Forms.Label
    Friend WithEvents lbIp As System.Windows.Forms.Label
    Friend WithEvents lbOp As System.Windows.Forms.Label
    Friend WithEvents lbStop As System.Windows.Forms.Label
    Friend WithEvents lbInput As System.Windows.Forms.Label
    Friend WithEvents lbDevice As System.Windows.Forms.Label
    Friend WithEvents lbOutput As System.Windows.Forms.Label
    Friend WithEvents lbPackage As System.Windows.Forms.Label
    Friend WithEvents lbLotNo As System.Windows.Forms.Label
    Friend WithEvents lbMC As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TPMaintenance As System.Windows.Forms.TabPage
    Friend WithEvents ComLog As System.Windows.Forms.TabPage
    Friend WithEvents CommLog As System.Windows.Forms.TextBox
    Friend WithEvents lbNotification As System.Windows.Forms.Label
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents TpProductData As System.Windows.Forms.TabPage
    Friend WithEvents gbxLotEnd As System.Windows.Forms.GroupBox
    Friend WithEvents radResetEnd As System.Windows.Forms.RadioButton
    Friend WithEvents radAccuEnd As System.Windows.Forms.RadioButton
    Friend WithEvents radNormalEnd As System.Windows.Forms.RadioButton
    Friend WithEvents BtSetting As System.Windows.Forms.Button
    Friend WithEvents LbGroup As System.Windows.Forms.Label
    Friend WithEvents BtClearLog As System.Windows.Forms.Button
    Friend WithEvents LbVersion As System.Windows.Forms.Label
    Friend WithEvents Lbtime As System.Windows.Forms.Label
    Friend WithEvents TimerDateTime As System.Windows.Forms.Timer
    Friend WithEvents BtEndLot As System.Windows.Forms.Button
    Friend WithEvents LbMagazine As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LbCounterFile As System.Windows.Forms.Label
    Friend WithEvents APCSClose As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReflowAlarmTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowAlarmTableTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmTableTableAdapter
    Friend WithEvents ReflowAlarmTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReflowAlarmInfoTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowAlarmInfoTableAdapter
    Friend WithEvents ReflowAlarmInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowAlarmInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReflowDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowDataTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.ReflowDataTableAdapter
    Friend WithEvents ReflowDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LotNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotStartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutputQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotEndTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MagazineNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBxDataSet As WindowsApplication1.DBxDataSet
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MachineTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmMessageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents cbSDGood As System.Windows.Forms.CheckBox
    Friend WithEvents RecordTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClearTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents bgTDC As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgTDCLotReq As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbLotReq As System.Windows.Forms.Label
    Friend WithEvents lbLotSetEnd As System.Windows.Forms.Label
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbNetversion As System.Windows.Forms.Label
    Friend WithEvents WIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbStatusMC As Label
End Class
