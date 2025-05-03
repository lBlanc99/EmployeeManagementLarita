Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
    End Sub

    Private Sub LoadEmployeeData()
        Try
            Using conn = Database.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id, name, address, phone, gender FROM employees" ' Exclude photo column here
                Using cmd = New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)

                        dgvEmployees.DataSource = dt

                        ' Hide id column
                        If dgvEmployees.Columns.Contains("id") Then
                            dgvEmployees.Columns("id").Visible = False
                        End If

                        ' Set headers
                        dgvEmployees.Columns("name").HeaderText = "Name"
                        dgvEmployees.Columns("address").HeaderText = "Address"
                        dgvEmployees.Columns("phone").HeaderText = "Phone"
                        dgvEmployees.Columns("gender").HeaderText = "Gender"


                    End Using
                End Using
            End Using

            dgvEmployees.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub dgvEmployees_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployees.SelectionChanged
        If dgvEmployees.SelectedRows.Count = 0 Then
            ClearDetailPanel()
            Return
        End If

        Dim selectedRow = dgvEmployees.SelectedRows(0)
        Dim employeeId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
        ShowEmployeeDetails(employeeId)
    End Sub

    Private Sub ShowEmployeeDetails(employeeId As Integer)
        Try
            Using conn = Database.GetConnection()
                conn.Open()
                Dim query As String = "SELECT photo, name, address, phone, gender FROM employees WHERE id=@id"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", employeeId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Photo
                            If Not reader.IsDBNull(0) Then
                                Dim photoData = CType(reader("photo"), Byte())
                                Using ms As New MemoryStream(photoData)
                                    pbDetailPhoto.Image = Image.FromStream(ms)
                                End Using
                            Else
                                pbDetailPhoto.Image = Nothing
                            End If
                           
                            lblDetailName.Text = reader.GetString(1)
                            lblDetailAddress.Text = reader.GetString(2)
                            lblDetailPhone.Text = reader.GetString(3)
                            lblDetailGender.Text = reader.GetString(4)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearDetailPanel()
        pbDetailPhoto.Image = Nothing
        lblDetailName.Text = ""
        lblDetailAddress.Text = ""
        lblDetailPhone.Text = ""
        lblDetailGender.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim formEmployee As New EmployeeForm()
        If formEmployee.ShowDialog() = DialogResult.OK Then
            LoadEmployeeData()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to edit.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow = dgvEmployees.SelectedRows(0)
        Dim employeeId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

        Dim formEmployee As New EmployeeForm(employeeId)
        If formEmployee.ShowDialog() = DialogResult.OK Then
            LoadEmployeeData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to delete.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow = dgvEmployees.SelectedRows(0)
        Dim employeeId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
        Dim employeeName As String = selectedRow.Cells("name").Value.ToString()

        Dim result = MessageBox.Show($"Are you sure you want to delete employee '{employeeName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                Using conn = Database.GetConnection()
                    conn.Open()
                    Dim query As String = "DELETE FROM employees WHERE id=@id"
                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", employeeId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Employee deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmployeeData()
                ClearDetailPanel()
            Catch ex As Exception
                MessageBox.Show("Error deleting employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class
