<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRegister
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtboxPhone = New System.Windows.Forms.TextBox()
        Me.txtboxCitizenship = New System.Windows.Forms.TextBox()
        Me.NudSalary = New System.Windows.Forms.NumericUpDown()
        Me.NudWorking = New System.Windows.Forms.NumericUpDown()
        Me.txtboxCar = New System.Windows.Forms.TextBox()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.NudAge = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtboxLicense = New System.Windows.Forms.TextBox()
        CType(Me.NudSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudWorking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 34)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Have a driving license ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(YES/NO)"
        '
        'txtboxAddress
        '
        Me.txtboxAddress.Location = New System.Drawing.Point(201, 162)
        Me.txtboxAddress.Multiline = True
        Me.txtboxAddress.Name = "txtboxAddress"
        Me.txtboxAddress.Size = New System.Drawing.Size(257, 62)
        Me.txtboxAddress.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "years"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Castellar", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(307, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(383, 29)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "UBER APPLICATION FORM"
        '
        'txtboxPhone
        '
        Me.txtboxPhone.Location = New System.Drawing.Point(690, 248)
        Me.txtboxPhone.Name = "txtboxPhone"
        Me.txtboxPhone.Size = New System.Drawing.Size(204, 22)
        Me.txtboxPhone.TabIndex = 44
        '
        'txtboxCitizenship
        '
        Me.txtboxCitizenship.Location = New System.Drawing.Point(690, 171)
        Me.txtboxCitizenship.Name = "txtboxCitizenship"
        Me.txtboxCitizenship.Size = New System.Drawing.Size(204, 22)
        Me.txtboxCitizenship.TabIndex = 43
        '
        'NudSalary
        '
        Me.NudSalary.Location = New System.Drawing.Point(690, 367)
        Me.NudSalary.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NudSalary.Name = "NudSalary"
        Me.NudSalary.Size = New System.Drawing.Size(102, 22)
        Me.NudSalary.TabIndex = 42
        '
        'NudWorking
        '
        Me.NudWorking.Location = New System.Drawing.Point(201, 367)
        Me.NudWorking.Name = "NudWorking"
        Me.NudWorking.Size = New System.Drawing.Size(64, 22)
        Me.NudWorking.TabIndex = 41
        '
        'txtboxCar
        '
        Me.txtboxCar.Location = New System.Drawing.Point(201, 318)
        Me.txtboxCar.Name = "txtboxCar"
        Me.txtboxCar.Size = New System.Drawing.Size(71, 22)
        Me.txtboxCar.TabIndex = 40
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Location = New System.Drawing.Point(201, 258)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(257, 22)
        Me.txtboxEmail.TabIndex = 39
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(201, 107)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(257, 22)
        Me.txtboxName.TabIndex = 38
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnExit.Location = New System.Drawing.Point(515, 447)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 40)
        Me.BtnExit.TabIndex = 37
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnSubmit.Location = New System.Drawing.Point(331, 447)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 40)
        Me.BtnSubmit.TabIndex = 35
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'NudAge
        '
        Me.NudAge.Location = New System.Drawing.Point(690, 108)
        Me.NudAge.Name = "NudAge"
        Me.NudAge.Size = New System.Drawing.Size(62, 22)
        Me.NudAge.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(512, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Desired Salary    RM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Working Experience"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Citizenship"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 34)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Have a car ? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(YES/NO)"
        '
        'txtboxLicense
        '
        Me.txtboxLicense.Location = New System.Drawing.Point(690, 311)
        Me.txtboxLicense.Name = "txtboxLicense"
        Me.txtboxLicense.Size = New System.Drawing.Size(69, 22)
        Me.txtboxLicense.TabIndex = 50
        '
        'formRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(955, 525)
        Me.Controls.Add(Me.txtboxLicense)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtboxAddress)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtboxPhone)
        Me.Controls.Add(Me.txtboxCitizenship)
        Me.Controls.Add(Me.NudSalary)
        Me.Controls.Add(Me.NudWorking)
        Me.Controls.Add(Me.txtboxCar)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.NudAge)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formRegister"
        Me.Text = "Register"
        CType(Me.NudSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudWorking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtboxPhone As TextBox
    Friend WithEvents txtboxCitizenship As TextBox
    Friend WithEvents NudSalary As NumericUpDown
    Friend WithEvents NudWorking As NumericUpDown
    Friend WithEvents txtboxCar As TextBox
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents NudAge As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtboxLicense As TextBox
End Class
