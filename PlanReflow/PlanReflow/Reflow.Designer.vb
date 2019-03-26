<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reflow
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ViewMeco2 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ViewMeco3 = New System.Windows.Forms.DataGridView()
        Me.ViewMeco1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RfwipTableAdapter1 = New PlanReflow.DBxDataSet1TableAdapters.RFWIPTableAdapter()
        Me.DBxDataSet11 = New PlanReflow.DBxDataSet1()
        Me.Panel1.SuspendLayout()
        CType(Me.ViewMeco2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewMeco3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewMeco1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(1215, 682)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(120, 57)
        Me.btExit.TabIndex = 46
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(895, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 42)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Meco#1 Machine"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ViewMeco2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btExit)
        Me.Panel1.Controls.Add(Me.ViewMeco3)
        Me.Panel1.Controls.Add(Me.ViewMeco1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 744)
        Me.Panel1.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1291, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Ver1.01"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 715)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Run"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 691)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Stop"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(56, 708)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(56, 682)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 48
        '
        'ViewMeco2
        '
        Me.ViewMeco2.AllowUserToAddRows = False
        Me.ViewMeco2.AllowUserToDeleteRows = False
        Me.ViewMeco2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMeco2.Location = New System.Drawing.Point(449, 143)
        Me.ViewMeco2.MultiSelect = False
        Me.ViewMeco2.Name = "ViewMeco2"
        Me.ViewMeco2.ReadOnly = True
        Me.ViewMeco2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco2.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ViewMeco2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewMeco2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewMeco2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewMeco2.Size = New System.Drawing.Size(440, 531)
        Me.ViewMeco2.TabIndex = 32
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(20, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(482, 56)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Meco Shift Production Plan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ViewMeco3
        '
        Me.ViewMeco3.AllowUserToAddRows = False
        Me.ViewMeco3.AllowUserToDeleteRows = False
        Me.ViewMeco3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMeco3.Location = New System.Drawing.Point(3, 143)
        Me.ViewMeco3.MultiSelect = False
        Me.ViewMeco3.Name = "ViewMeco3"
        Me.ViewMeco3.ReadOnly = True
        Me.ViewMeco3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco3.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ViewMeco3.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ViewMeco3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewMeco3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewMeco3.Size = New System.Drawing.Size(440, 531)
        Me.ViewMeco3.TabIndex = 32
        '
        'ViewMeco1
        '
        Me.ViewMeco1.AllowUserToAddRows = False
        Me.ViewMeco1.AllowUserToDeleteRows = False
        Me.ViewMeco1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMeco1.Location = New System.Drawing.Point(895, 143)
        Me.ViewMeco1.MultiSelect = False
        Me.ViewMeco1.Name = "ViewMeco1"
        Me.ViewMeco1.ReadOnly = True
        Me.ViewMeco1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMeco1.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ViewMeco1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ViewMeco1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewMeco1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewMeco1.Size = New System.Drawing.Size(440, 531)
        Me.ViewMeco1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(440, 42)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Meco#3 Machine"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(449, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 42)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Meco#2 Machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300000
        '
        'RfwipTableAdapter1
        '
        Me.RfwipTableAdapter1.ClearBeforeFill = True
        '
        'DBxDataSet11
        '
        Me.DBxDataSet11.DataSetName = "DBxDataSet1"
        Me.DBxDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reflow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reflow"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ViewMeco2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewMeco3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewMeco1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ViewMeco1 As DataGridView
    Friend WithEvents ViewMeco3 As DataGridView
    Friend WithEvents ViewMeco2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RfwipTableAdapter1 As DBxDataSet1TableAdapters.RFWIPTableAdapter
    Friend WithEvents DBxDataSet11 As DBxDataSet1
    Friend WithEvents Label8 As Label
End Class
