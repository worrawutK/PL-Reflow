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
        Me.components = New System.ComponentModel.Container
        Me.TbOutput = New System.Windows.Forms.TextBox
        Me.TbInput = New System.Windows.Forms.TextBox
        Me.BtUpdateDataManual = New System.Windows.Forms.Button
        Me.GbGroup = New System.Windows.Forms.GroupBox
        Me.RdbGroupB = New System.Windows.Forms.RadioButton
        Me.RdbGroupA = New System.Windows.Forms.RadioButton
        Me.BtClearManual = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbRemark = New System.Windows.Forms.ComboBox
        Me.BtEndManual = New System.Windows.Forms.Button
        Me.BtStartManual = New System.Windows.Forms.Button
        Me.TbOPNO = New System.Windows.Forms.TextBox
        Me.TbMagazineNo = New System.Windows.Forms.TextBox
        Me.TbStopTime = New System.Windows.Forms.TextBox
        Me.TbStartTime = New System.Windows.Forms.TextBox
        Me.CmbMCNO = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbGroup = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TbDevice = New System.Windows.Forms.TextBox
        Me.TbPackage = New System.Windows.Forms.TextBox
        Me.TbLotNo = New System.Windows.Forms.TextBox
        Me.btOPNo = New System.Windows.Forms.Button
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.DBxDataSet = New ReflowManual.DBxDataSet
        Me.ReflowDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReflowDataTableAdapter = New ReflowManual.DBxDataSetTableAdapters.ReflowDataTableAdapter
        Me.LbCounterFile = New System.Windows.Forms.Label
        Me.TableAdapterManager = New ReflowManual.DBxDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReflowDataDataGridView = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btKeyboard = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbVersion = New System.Windows.Forms.Label
        Me.bgTDC = New System.ComponentModel.BackgroundWorker
        Me.GbGroup.SuspendLayout()
        Me.gb1.SuspendLayout()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbOutput
        '
        Me.TbOutput.Location = New System.Drawing.Point(136, 327)
        Me.TbOutput.Name = "TbOutput"
        Me.TbOutput.Size = New System.Drawing.Size(146, 20)
        Me.TbOutput.TabIndex = 6
        '
        'TbInput
        '
        Me.TbInput.Location = New System.Drawing.Point(136, 289)
        Me.TbInput.Name = "TbInput"
        Me.TbInput.Size = New System.Drawing.Size(146, 20)
        Me.TbInput.TabIndex = 5
        '
        'BtUpdateDataManual
        '
        Me.BtUpdateDataManual.BackColor = System.Drawing.SystemColors.Info
        Me.BtUpdateDataManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtUpdateDataManual.Location = New System.Drawing.Point(236, 118)
        Me.BtUpdateDataManual.Name = "BtUpdateDataManual"
        Me.BtUpdateDataManual.Size = New System.Drawing.Size(154, 70)
        Me.BtUpdateDataManual.TabIndex = 66
        Me.BtUpdateDataManual.Text = "Update Data"
        Me.BtUpdateDataManual.UseVisualStyleBackColor = False
        '
        'GbGroup
        '
        Me.GbGroup.Controls.Add(Me.RdbGroupB)
        Me.GbGroup.Controls.Add(Me.RdbGroupA)
        Me.GbGroup.Location = New System.Drawing.Point(136, 56)
        Me.GbGroup.Name = "GbGroup"
        Me.GbGroup.Size = New System.Drawing.Size(85, 25)
        Me.GbGroup.TabIndex = 62
        Me.GbGroup.TabStop = False
        '
        'RdbGroupB
        '
        Me.RdbGroupB.AutoSize = True
        Me.RdbGroupB.Location = New System.Drawing.Point(45, 7)
        Me.RdbGroupB.Name = "RdbGroupB"
        Me.RdbGroupB.Size = New System.Drawing.Size(32, 17)
        Me.RdbGroupB.TabIndex = 28
        Me.RdbGroupB.TabStop = True
        Me.RdbGroupB.Text = "B"
        Me.RdbGroupB.UseVisualStyleBackColor = True
        '
        'RdbGroupA
        '
        Me.RdbGroupA.AutoSize = True
        Me.RdbGroupA.Location = New System.Drawing.Point(7, 7)
        Me.RdbGroupA.Name = "RdbGroupA"
        Me.RdbGroupA.Size = New System.Drawing.Size(32, 17)
        Me.RdbGroupA.TabIndex = 27
        Me.RdbGroupA.TabStop = True
        Me.RdbGroupA.Text = "A"
        Me.RdbGroupA.UseVisualStyleBackColor = True
        '
        'BtClearManual
        '
        Me.BtClearManual.BackColor = System.Drawing.Color.White
        Me.BtClearManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtClearManual.Location = New System.Drawing.Point(23, 320)
        Me.BtClearManual.Name = "BtClearManual"
        Me.BtClearManual.Size = New System.Drawing.Size(165, 70)
        Me.BtClearManual.TabIndex = 61
        Me.BtClearManual.Text = "Clear"
        Me.BtClearManual.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Remark"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbRemark
        '
        Me.CmbRemark.FormattingEnabled = True
        Me.CmbRemark.Items.AddRange(New Object() {"-", "Reload", "Run 2 Time", "Treatment Lot"})
        Me.CmbRemark.Location = New System.Drawing.Point(135, 365)
        Me.CmbRemark.Name = "CmbRemark"
        Me.CmbRemark.Size = New System.Drawing.Size(147, 21)
        Me.CmbRemark.TabIndex = 59
        '
        'BtEndManual
        '
        Me.BtEndManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEndManual.Location = New System.Drawing.Point(23, 218)
        Me.BtEndManual.Name = "BtEndManual"
        Me.BtEndManual.Size = New System.Drawing.Size(165, 70)
        Me.BtEndManual.TabIndex = 58
        Me.BtEndManual.Text = "End"
        Me.BtEndManual.UseVisualStyleBackColor = True
        '
        'BtStartManual
        '
        Me.BtStartManual.BackColor = System.Drawing.SystemColors.Control
        Me.BtStartManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtStartManual.Location = New System.Drawing.Point(23, 119)
        Me.BtStartManual.Name = "BtStartManual"
        Me.BtStartManual.Size = New System.Drawing.Size(165, 70)
        Me.BtStartManual.TabIndex = 57
        Me.BtStartManual.Text = "Start"
        Me.BtStartManual.UseVisualStyleBackColor = False
        '
        'TbOPNO
        '
        Me.TbOPNO.Location = New System.Drawing.Point(135, 213)
        Me.TbOPNO.Name = "TbOPNO"
        Me.TbOPNO.Size = New System.Drawing.Size(147, 20)
        Me.TbOPNO.TabIndex = 3
        '
        'TbMagazineNo
        '
        Me.TbMagazineNo.Location = New System.Drawing.Point(135, 251)
        Me.TbMagazineNo.Name = "TbMagazineNo"
        Me.TbMagazineNo.Size = New System.Drawing.Size(147, 20)
        Me.TbMagazineNo.TabIndex = 4
        '
        'TbStopTime
        '
        Me.TbStopTime.Location = New System.Drawing.Point(135, 441)
        Me.TbStopTime.Name = "TbStopTime"
        Me.TbStopTime.Size = New System.Drawing.Size(147, 20)
        Me.TbStopTime.TabIndex = 54
        '
        'TbStartTime
        '
        Me.TbStartTime.Location = New System.Drawing.Point(135, 403)
        Me.TbStartTime.Name = "TbStartTime"
        Me.TbStartTime.Size = New System.Drawing.Size(147, 20)
        Me.TbStartTime.TabIndex = 53
        '
        'CmbMCNO
        '
        Me.CmbMCNO.FormattingEnabled = True
        Me.CmbMCNO.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.CmbMCNO.Items.AddRange(New Object() {"", "R-08", "R-09", "R-10", "R-11", "R-12"})
        Me.CmbMCNO.Location = New System.Drawing.Point(135, 22)
        Me.CmbMCNO.Name = "CmbMCNO"
        Me.CmbMCNO.Size = New System.Drawing.Size(85, 21)
        Me.CmbMCNO.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 22)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Magazine No."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 22)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Stop Time"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Start Time"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 22)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Output Qty(PCS)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 22)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Input Qty(PCS)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbGroup
        '
        Me.lbGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGroup.Location = New System.Drawing.Point(18, 61)
        Me.lbGroup.Name = "lbGroup"
        Me.lbGroup.Size = New System.Drawing.Size(105, 22)
        Me.lbGroup.TabIndex = 46
        Me.lbGroup.Text = "Group"
        Me.lbGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Device Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Package Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 22)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Lot No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "OP No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "M/C No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbDevice
        '
        Me.TbDevice.Location = New System.Drawing.Point(135, 175)
        Me.TbDevice.Name = "TbDevice"
        Me.TbDevice.Size = New System.Drawing.Size(147, 20)
        Me.TbDevice.TabIndex = 2
        '
        'TbPackage
        '
        Me.TbPackage.Location = New System.Drawing.Point(135, 137)
        Me.TbPackage.Name = "TbPackage"
        Me.TbPackage.Size = New System.Drawing.Size(147, 20)
        Me.TbPackage.TabIndex = 1
        '
        'TbLotNo
        '
        Me.TbLotNo.Location = New System.Drawing.Point(135, 99)
        Me.TbLotNo.Name = "TbLotNo"
        Me.TbLotNo.Size = New System.Drawing.Size(147, 20)
        Me.TbLotNo.TabIndex = 0
        '
        'btOPNo
        '
        Me.btOPNo.BackColor = System.Drawing.Color.Bisque
        Me.btOPNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOPNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btOPNo.Location = New System.Drawing.Point(23, 30)
        Me.btOPNo.Name = "btOPNo"
        Me.btOPNo.Size = New System.Drawing.Size(367, 70)
        Me.btOPNo.TabIndex = 66
        Me.btOPNo.Text = "OP No : XXXXXX"
        Me.btOPNo.UseVisualStyleBackColor = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.TbOutput)
        Me.gb1.Controls.Add(Me.TbInput)
        Me.gb1.Controls.Add(Me.GbGroup)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.CmbRemark)
        Me.gb1.Controls.Add(Me.TbOPNO)
        Me.gb1.Controls.Add(Me.TbMagazineNo)
        Me.gb1.Controls.Add(Me.TbStopTime)
        Me.gb1.Controls.Add(Me.TbStartTime)
        Me.gb1.Controls.Add(Me.CmbMCNO)
        Me.gb1.Controls.Add(Me.Label13)
        Me.gb1.Controls.Add(Me.Label12)
        Me.gb1.Controls.Add(Me.Label11)
        Me.gb1.Controls.Add(Me.Label10)
        Me.gb1.Controls.Add(Me.Label9)
        Me.gb1.Controls.Add(Me.lbGroup)
        Me.gb1.Controls.Add(Me.Label7)
        Me.gb1.Controls.Add(Me.Label6)
        Me.gb1.Controls.Add(Me.Label5)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.TbDevice)
        Me.gb1.Controls.Add(Me.TbPackage)
        Me.gb1.Controls.Add(Me.TbLotNo)
        Me.gb1.Location = New System.Drawing.Point(38, 94)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(301, 470)
        Me.gb1.TabIndex = 70
        Me.gb1.TabStop = False
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReflowDataBindingSource
        '
        Me.ReflowDataBindingSource.DataMember = "ReflowData"
        Me.ReflowDataBindingSource.DataSource = Me.DBxDataSet
        '
        'ReflowDataTableAdapter
        '
        Me.ReflowDataTableAdapter.ClearBeforeFill = True
        '
        'LbCounterFile
        '
        Me.LbCounterFile.AutoSize = True
        Me.LbCounterFile.BackColor = System.Drawing.SystemColors.Info
        Me.LbCounterFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCounterFile.Location = New System.Drawing.Point(363, 169)
        Me.LbCounterFile.Name = "LbCounterFile"
        Me.LbCounterFile.Size = New System.Drawing.Size(13, 13)
        Me.LbCounterFile.TabIndex = 71
        Me.LbCounterFile.Text = "0"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ReflowDataTableAdapter = Me.ReflowDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = ReflowManual.DBxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "AlarmTotal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "AlarmTotal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TemperatureGroup"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TemperatureGroup"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MagazineNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MagazineNo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LotEndTime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LotEndTime"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OutputQty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OutputQty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "InputQty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "InputQty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OPNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OPNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LotStartTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LotStartTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MCNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MCNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LotNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LotNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ReflowDataDataGridView
        '
        Me.ReflowDataDataGridView.AllowUserToAddRows = False
        Me.ReflowDataDataGridView.AllowUserToDeleteRows = False
        Me.ReflowDataDataGridView.AutoGenerateColumns = False
        Me.ReflowDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReflowDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ReflowDataDataGridView.DataSource = Me.ReflowDataBindingSource
        Me.ReflowDataDataGridView.Location = New System.Drawing.Point(6, 80)
        Me.ReflowDataDataGridView.Name = "ReflowDataDataGridView"
        Me.ReflowDataDataGridView.ReadOnly = True
        Me.ReflowDataDataGridView.Size = New System.Drawing.Size(394, 350)
        Me.ReflowDataDataGridView.TabIndex = 71
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(353, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 462)
        Me.TabControl1.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btKeyboard)
        Me.TabPage1.Controls.Add(Me.btOPNo)
        Me.TabPage1.Controls.Add(Me.BtStartManual)
        Me.TabPage1.Controls.Add(Me.LbCounterFile)
        Me.TabPage1.Controls.Add(Me.BtEndManual)
        Me.TabPage1.Controls.Add(Me.BtClearManual)
        Me.TabPage1.Controls.Add(Me.BtUpdateDataManual)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(407, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Production"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btKeyboard
        '
        Me.btKeyboard.Location = New System.Drawing.Point(236, 218)
        Me.btKeyboard.Name = "btKeyboard"
        Me.btKeyboard.Size = New System.Drawing.Size(154, 70)
        Me.btKeyboard.TabIndex = 73
        Me.btKeyboard.Text = "Keyboard"
        Me.btKeyboard.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ReflowDataDataGridView)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(407, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Table"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "LotEnd"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "LotSet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ReflowManual.My.Resources.Resources.RohmLogo
        Me.PictureBox1.Location = New System.Drawing.Point(637, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 96)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 46)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "REFLOW"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Tomato
        Me.Label8.Location = New System.Drawing.Point(264, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Manual"
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(12, 574)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbVersion.Size = New System.Drawing.Size(154, 13)
        Me.lbVersion.TabIndex = 77
        Me.lbVersion.Text = "Version : XXXXXX Detail XXXX"
        '
        'bgTDC
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(781, 591)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReflowManual"
        Me.GbGroup.ResumeLayout(False)
        Me.GbGroup.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReflowDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbOutput As System.Windows.Forms.TextBox
    Friend WithEvents TbInput As System.Windows.Forms.TextBox
    Friend WithEvents BtUpdateDataManual As System.Windows.Forms.Button
    Friend WithEvents GbGroup As System.Windows.Forms.GroupBox
    Friend WithEvents RdbGroupB As System.Windows.Forms.RadioButton
    Friend WithEvents RdbGroupA As System.Windows.Forms.RadioButton
    Friend WithEvents BtClearManual As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbRemark As System.Windows.Forms.ComboBox
    Friend WithEvents BtEndManual As System.Windows.Forms.Button
    Friend WithEvents BtStartManual As System.Windows.Forms.Button
    Friend WithEvents TbOPNO As System.Windows.Forms.TextBox
    Friend WithEvents TbMagazineNo As System.Windows.Forms.TextBox
    Friend WithEvents TbStopTime As System.Windows.Forms.TextBox
    Friend WithEvents TbStartTime As System.Windows.Forms.TextBox
    Friend WithEvents CmbMCNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbGroup As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbDevice As System.Windows.Forms.TextBox
    Friend WithEvents TbPackage As System.Windows.Forms.TextBox
    Friend WithEvents TbLotNo As System.Windows.Forms.TextBox
    Friend WithEvents btOPNo As System.Windows.Forms.Button
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents DBxDataSet As ReflowManual.DBxDataSet
    Friend WithEvents ReflowDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReflowDataTableAdapter As ReflowManual.DBxDataSetTableAdapters.ReflowDataTableAdapter
    Friend WithEvents LbCounterFile As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As ReflowManual.DBxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReflowDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents btKeyboard As System.Windows.Forms.Button
    Friend WithEvents bgTDC As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
