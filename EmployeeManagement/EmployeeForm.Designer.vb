<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents labelPhoto As Label
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents btnBrowsePhoto As Button
    Friend WithEvents labelName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents labelAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents labelPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents labelGender As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

    Private Sub InitializeComponent()
        Me.labelPhoto = New System.Windows.Forms.Label()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePhoto = New System.Windows.Forms.Button()
        Me.labelName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.labelPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.labelGender = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelPhoto
        '
        Me.labelPhoto.AutoSize = True
        Me.labelPhoto.Location = New System.Drawing.Point(11, 16)
        Me.labelPhoto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPhoto.Name = "labelPhoto"
        Me.labelPhoto.Size = New System.Drawing.Size(35, 13)
        Me.labelPhoto.TabIndex = 0
        Me.labelPhoto.Text = "Photo"
        '
        'pbPhoto
        '
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPhoto.Location = New System.Drawing.Point(68, 12)
        Me.pbPhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(90, 98)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPhoto.TabIndex = 1
        Me.pbPhoto.TabStop = False
        '
        'btnBrowsePhoto
        '
        Me.btnBrowsePhoto.Location = New System.Drawing.Point(165, 49)
        Me.btnBrowsePhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBrowsePhoto.Name = "btnBrowsePhoto"
        Me.btnBrowsePhoto.Size = New System.Drawing.Size(56, 24)
        Me.btnBrowsePhoto.TabIndex = 2
        Me.btnBrowsePhoto.Text = "Browse"
        Me.btnBrowsePhoto.UseVisualStyleBackColor = True
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(11, 126)
        Me.labelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(35, 13)
        Me.labelName.TabIndex = 3
        Me.labelName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 124)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 20)
        Me.txtName.TabIndex = 3
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Location = New System.Drawing.Point(11, 158)
        Me.labelAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(45, 13)
        Me.labelAddress.TabIndex = 5
        Me.labelAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(68, 156)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(155, 50)
        Me.txtAddress.TabIndex = 4
        '
        'labelPhone
        '
        Me.labelPhone.AutoSize = True
        Me.labelPhone.Location = New System.Drawing.Point(11, 215)
        Me.labelPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPhone.Name = "labelPhone"
        Me.labelPhone.Size = New System.Drawing.Size(38, 13)
        Me.labelPhone.TabIndex = 7
        Me.labelPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(68, 213)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(155, 20)
        Me.txtPhone.TabIndex = 5
        '
        'labelGender
        '
        Me.labelGender.AutoSize = True
        Me.labelGender.Location = New System.Drawing.Point(11, 248)
        Me.labelGender.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelGender.Name = "labelGender"
        Me.labelGender.Size = New System.Drawing.Size(42, 13)
        Me.labelGender.TabIndex = 9
        Me.labelGender.Text = "Gender"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(68, 246)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 6
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(128, 246)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 7
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(68, 284)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(154, 284)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 24)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 325)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.labelGender)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.labelPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.btnBrowsePhoto)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.labelPhoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Form"
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
