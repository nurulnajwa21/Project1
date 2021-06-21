<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJobApplication
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConditions = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UBER DRIVER APPLICATION"
        '
        'BtnConditions
        '
        Me.BtnConditions.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnConditions.Location = New System.Drawing.Point(114, 156)
        Me.BtnConditions.Name = "BtnConditions"
        Me.BtnConditions.Size = New System.Drawing.Size(93, 47)
        Me.BtnConditions.TabIndex = 1
        Me.BtnConditions.Text = "Conditions"
        Me.BtnConditions.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnRegister.Location = New System.Drawing.Point(343, 156)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(93, 47)
        Me.BtnRegister.TabIndex = 2
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'formJobApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(564, 262)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnConditions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formJobApplication"
        Me.Text = "Job Application Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConditions As Button
    Friend WithEvents BtnRegister As Button
End Class
