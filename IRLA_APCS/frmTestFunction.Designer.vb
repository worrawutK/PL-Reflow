<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestFunction
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
        Me.ButtonSD = New System.Windows.Forms.Button()
        Me.ButtonLR = New System.Windows.Forms.Button()
        Me.ButtonLE = New System.Windows.Forms.Button()
        Me.ButtonLS = New System.Windows.Forms.Button()
        Me.TextBoxLR = New System.Windows.Forms.TextBox()
        Me.TextBoxLS = New System.Windows.Forms.TextBox()
        Me.TextBoxSD = New System.Windows.Forms.TextBox()
        Me.TextBoxLE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonSD
        '
        Me.ButtonSD.Location = New System.Drawing.Point(357, 119)
        Me.ButtonSD.Name = "ButtonSD"
        Me.ButtonSD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSD.TabIndex = 224
        Me.ButtonSD.Text = "SD"
        Me.ButtonSD.UseVisualStyleBackColor = True
        '
        'ButtonLR
        '
        Me.ButtonLR.Location = New System.Drawing.Point(357, 31)
        Me.ButtonLR.Name = "ButtonLR"
        Me.ButtonLR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLR.TabIndex = 223
        Me.ButtonLR.Text = " LR"
        Me.ButtonLR.UseVisualStyleBackColor = True
        '
        'ButtonLE
        '
        Me.ButtonLE.Location = New System.Drawing.Point(357, 164)
        Me.ButtonLE.Name = "ButtonLE"
        Me.ButtonLE.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLE.TabIndex = 222
        Me.ButtonLE.Text = "LE"
        Me.ButtonLE.UseVisualStyleBackColor = True
        '
        'ButtonLS
        '
        Me.ButtonLS.Location = New System.Drawing.Point(357, 73)
        Me.ButtonLS.Name = "ButtonLS"
        Me.ButtonLS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLS.TabIndex = 221
        Me.ButtonLS.Text = "LS"
        Me.ButtonLS.UseVisualStyleBackColor = True
        '
        'TextBoxLR
        '
        Me.TextBoxLR.Location = New System.Drawing.Point(32, 34)
        Me.TextBoxLR.Name = "TextBoxLR"
        Me.TextBoxLR.Size = New System.Drawing.Size(303, 20)
        Me.TextBoxLR.TabIndex = 225
        '
        'TextBoxLS
        '
        Me.TextBoxLS.Location = New System.Drawing.Point(32, 76)
        Me.TextBoxLS.Name = "TextBoxLS"
        Me.TextBoxLS.Size = New System.Drawing.Size(303, 20)
        Me.TextBoxLS.TabIndex = 225
        '
        'TextBoxSD
        '
        Me.TextBoxSD.Location = New System.Drawing.Point(32, 122)
        Me.TextBoxSD.Name = "TextBoxSD"
        Me.TextBoxSD.Size = New System.Drawing.Size(303, 20)
        Me.TextBoxSD.TabIndex = 225
        '
        'TextBoxLE
        '
        Me.TextBoxLE.Location = New System.Drawing.Point(32, 167)
        Me.TextBoxLE.Name = "TextBoxLE"
        Me.TextBoxLE.Size = New System.Drawing.Size(303, 20)
        Me.TextBoxLE.TabIndex = 225
        '
        'frmTestFunction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 226)
        Me.Controls.Add(Me.TextBoxLE)
        Me.Controls.Add(Me.TextBoxSD)
        Me.Controls.Add(Me.TextBoxLS)
        Me.Controls.Add(Me.TextBoxLR)
        Me.Controls.Add(Me.ButtonSD)
        Me.Controls.Add(Me.ButtonLR)
        Me.Controls.Add(Me.ButtonLE)
        Me.Controls.Add(Me.ButtonLS)
        Me.Name = "frmTestFunction"
        Me.Text = "frmTestFunction"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSD As Button
    Friend WithEvents ButtonLR As Button
    Friend WithEvents ButtonLE As Button
    Friend WithEvents ButtonLS As Button
    Friend WithEvents TextBoxLR As TextBox
    Friend WithEvents TextBoxLS As TextBox
    Friend WithEvents TextBoxSD As TextBox
    Friend WithEvents TextBoxLE As TextBox
End Class
