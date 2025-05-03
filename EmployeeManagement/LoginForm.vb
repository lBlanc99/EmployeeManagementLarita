Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = String.Empty Or password = String.Empty Then
            MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = Database.GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        Me.Hide()
                        Dim mainForm As New MainForm()
                        mainForm.Show()
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
