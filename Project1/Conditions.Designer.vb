<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConditions
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
        Me.BtnBackConditions = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DO YOU HAVE MEET THE CONDITIONS ?"
        '
        'BtnBackConditions
        '
        Me.BtnBackConditions.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnBackConditions.Location = New System.Drawing.Point(449, 320)
        Me.BtnBackConditions.Name = "BtnBackConditions"
        Me.BtnBackConditions.Size = New System.Drawing.Size(87, 44)
        Me.BtnBackConditions.TabIndex = 1
        Me.BtnBackConditions.Text = "Back"
        Me.BtnBackConditions.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(513, 145)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1) Must Malaysia citizen ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Age must be above 21 years old ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Must have at " &
    "least one year of driving experience ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4) Must have  a valid driver license ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "5) Must have a car ."
        '
        'formConditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(651, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBackConditions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formConditions"
        Me.Text = "Conditions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBackConditions As Button
    Friend WithEvents Label2 As Label
End Class
