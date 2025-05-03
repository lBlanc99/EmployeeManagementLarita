<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private WithEvents btnLogin As Button
    Private txtUsername As TextBox
    Private txtPassword As TextBox
    Private labelUsername As Label
    Private labelPassword As Label

    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(120, 115)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 30)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(90, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(180, 22)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(90, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Location = New System.Drawing.Point(20, 33)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(68, 17)
        Me.labelUsername.TabIndex = 3
        Me.labelUsername.Text = "Username"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(20, 78)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(66, 17)
        Me.labelPassword.TabIndex = 4
        Me.labelPassword.Text = "Password"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 170)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
