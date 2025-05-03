
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents panelDetails As Panel
    Friend WithEvents pbDetailPhoto As PictureBox
    Friend WithEvents lblDetailName As Label
    Friend WithEvents lblDetailAddress As Label
    Friend WithEvents lblDetailPhone As Label
    Friend WithEvents lblDetailGender As Label
    Friend WithEvents labelNameTitle As Label
    Friend WithEvents labelAddressTitle As Label
    Friend WithEvents labelPhoneTitle As Label
    Friend WithEvents labelGenderTitle As Label

    Private Sub InitializeComponent()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelDetails = New System.Windows.Forms.Panel()
        Me.pbDetailPhoto = New System.Windows.Forms.PictureBox()
        Me.labelNameTitle = New System.Windows.Forms.Label()
        Me.labelAddressTitle = New System.Windows.Forms.Label()
        Me.labelPhoneTitle = New System.Windows.Forms.Label()
        Me.labelGenderTitle = New System.Windows.Forms.Label()
        Me.lblDetailName = New System.Windows.Forms.Label()
        Me.lblDetailAddress = New System.Windows.Forms.Label()
        Me.lblDetailPhone = New System.Windows.Forms.Label()
        Me.lblDetailGender = New System.Windows.Forms.Label()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetails.SuspendLayout()
        CType(Me.pbDetailPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AllowUserToOrderColumns = True
        Me.dgvEmployees.AllowUserToResizeRows = False
        Me.dgvEmployees.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(9, 10)
        Me.dgvEmployees.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvEmployees.MultiSelect = False
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowHeadersVisible = False
        Me.dgvEmployees.RowTemplate.Height = 100
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(495, 325)
        Me.dgvEmployees.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(9, 349)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 24)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(81, 349)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(68, 24)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(153, 349)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 24)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Location = New System.Drawing.Point(436, 349)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(68, 24)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'panelDetails
        '
        Me.panelDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetails.Controls.Add(Me.pbDetailPhoto)
        Me.panelDetails.Controls.Add(Me.labelNameTitle)
        Me.panelDetails.Controls.Add(Me.labelAddressTitle)
        Me.panelDetails.Controls.Add(Me.labelPhoneTitle)
        Me.panelDetails.Controls.Add(Me.labelGenderTitle)
        Me.panelDetails.Controls.Add(Me.lblDetailName)
        Me.panelDetails.Controls.Add(Me.lblDetailAddress)
        Me.panelDetails.Controls.Add(Me.lblDetailPhone)
        Me.panelDetails.Controls.Add(Me.lblDetailGender)
        Me.panelDetails.Location = New System.Drawing.Point(508, 10)
        Me.panelDetails.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelDetails.Name = "panelDetails"
        Me.panelDetails.Size = New System.Drawing.Size(226, 364)
        Me.panelDetails.TabIndex = 5
        '
        'pbDetailPhoto
        '
        Me.pbDetailPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbDetailPhoto.Location = New System.Drawing.Point(49, 16)
        Me.pbDetailPhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbDetailPhoto.Name = "pbDetailPhoto"
        Me.pbDetailPhoto.Size = New System.Drawing.Size(141, 164)
        Me.pbDetailPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDetailPhoto.TabIndex = 0
        Me.pbDetailPhoto.TabStop = False
        '
        'labelNameTitle
        '
        Me.labelNameTitle.AutoSize = True
        Me.labelNameTitle.Location = New System.Drawing.Point(14, 193)
        Me.labelNameTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelNameTitle.Name = "labelNameTitle"
        Me.labelNameTitle.Size = New System.Drawing.Size(35, 13)
        Me.labelNameTitle.TabIndex = 1
        Me.labelNameTitle.Text = "Name"
        '
        'labelAddressTitle
        '
        Me.labelAddressTitle.AutoSize = True
        Me.labelAddressTitle.Location = New System.Drawing.Point(14, 230)
        Me.labelAddressTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelAddressTitle.Name = "labelAddressTitle"
        Me.labelAddressTitle.Size = New System.Drawing.Size(45, 13)
        Me.labelAddressTitle.TabIndex = 2
        Me.labelAddressTitle.Text = "Address"
        '
        'labelPhoneTitle
        '
        Me.labelPhoneTitle.AutoSize = True
        Me.labelPhoneTitle.Location = New System.Drawing.Point(14, 274)
        Me.labelPhoneTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPhoneTitle.Name = "labelPhoneTitle"
        Me.labelPhoneTitle.Size = New System.Drawing.Size(38, 13)
        Me.labelPhoneTitle.TabIndex = 3
        Me.labelPhoneTitle.Text = "Phone"
        '
        'labelGenderTitle
        '
        Me.labelGenderTitle.AutoSize = True
        Me.labelGenderTitle.Location = New System.Drawing.Point(14, 311)
        Me.labelGenderTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelGenderTitle.Name = "labelGenderTitle"
        Me.labelGenderTitle.Size = New System.Drawing.Size(42, 13)
        Me.labelGenderTitle.TabIndex = 4
        Me.labelGenderTitle.Text = "Gender"
        '
        'lblDetailName
        '
        Me.lblDetailName.AutoSize = True
        Me.lblDetailName.Location = New System.Drawing.Point(68, 130)
        Me.lblDetailName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetailName.Name = "lblDetailName"
        Me.lblDetailName.Size = New System.Drawing.Size(0, 13)
        Me.lblDetailName.TabIndex = 5
        '
        'lblDetailAddress
        '
        Me.lblDetailAddress.AutoSize = True
        Me.lblDetailAddress.Location = New System.Drawing.Point(68, 167)
        Me.lblDetailAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetailAddress.MaximumSize = New System.Drawing.Size(135, 0)
        Me.lblDetailAddress.Name = "lblDetailAddress"
        Me.lblDetailAddress.Size = New System.Drawing.Size(0, 13)
        Me.lblDetailAddress.TabIndex = 6
        '
        'lblDetailPhone
        '
        Me.lblDetailPhone.AutoSize = True
        Me.lblDetailPhone.Location = New System.Drawing.Point(68, 211)
        Me.lblDetailPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetailPhone.Name = "lblDetailPhone"
        Me.lblDetailPhone.Size = New System.Drawing.Size(0, 13)
        Me.lblDetailPhone.TabIndex = 7
        '
        'lblDetailGender
        '
        Me.lblDetailGender.AutoSize = True
        Me.lblDetailGender.Location = New System.Drawing.Point(68, 248)
        Me.lblDetailGender.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetailGender.Name = "lblDetailGender"
        Me.lblDetailGender.Size = New System.Drawing.Size(0, 13)
        Me.lblDetailGender.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 384)
        Me.Controls.Add(Me.panelDetails)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvEmployees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        CType(Me.pbDetailPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class

