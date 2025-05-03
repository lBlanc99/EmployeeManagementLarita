Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class EmployeeForm
    Private employeeId As Integer? = Nothing
    Private photoData As Byte() = Nothing
    Public Sub New()
        InitializeComponent()
        Me.Text = "Add Employee"
    End Sub

    Public Function ResizeImage(image As Image, maxWidth As Integer, maxHeight As Integer) As Image
        Dim ratioX As Double = maxWidth / image.Width
        Dim ratioY As Double = maxHeight / image.Height
        Dim ratio As Double = Math.Min(ratioX, ratioY)

        Dim newWidth As Integer = CInt(image.Width * ratio)
        Dim newHeight As Integer = CInt(image.Height * ratio)

        Dim newImage As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(newImage)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.CompositingQuality = CompositingQuality.HighQuality
            g.SmoothingMode = SmoothingMode.HighQuality
            g.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Public Sub New(id As Integer)
        InitializeComponent()
        employeeId = id
        Me.Text = "Edit Employee"
        LoadEmployeeData()
    End Sub

    Private Sub LoadEmployeeData()
        If employeeId Is Nothing Then Return

        Try
            Using conn = Database.GetConnection()
                conn.Open()
                Dim query As String = "SELECT photo, name, address, phone, gender FROM employees WHERE id=@id"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", employeeId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not reader.IsDBNull(0) Then
                                photoData = CType(reader("photo"), Byte())
                                Using ms As New MemoryStream(photoData)
                                    pbPhoto.Image = Image.FromStream(ms)
                                End Using
                            Else
                                pbPhoto.Image = Nothing
                            End If
                            txtName.Text = reader.GetString(1)
                            txtAddress.Text = reader.GetString(2)
                            txtPhone.Text = reader.GetString(3)
                            Dim genderValue As String = reader.GetString(4)
                            rbMale.Checked = (genderValue = "Male")
                            rbFemale.Checked = (genderValue = "Female")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles btnBrowsePhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Using originalImage As Image = Image.FromFile(ofd.FileName)
                        Using resizedImage As Image = ResizeImage(originalImage, 800, 800)
                            Using ms As New MemoryStream()
                                Dim encoderParameters As New EncoderParameters(1)
                                encoderParameters.Param(0) = New EncoderParameter(Encoder.Quality, 85L)
                                Dim jpegCodec As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)
                                resizedImage.Save(ms, jpegCodec, encoderParameters)
                                photoData = ms.ToArray()
                            End Using
                            pbPhoto.Image = CType(resizedImage.Clone(), Image)
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Failed to load or resize image: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Function GetEncoder(format As ImageFormat) As ImageCodecInfo
        Dim codecs() As ImageCodecInfo = ImageCodecInfo.GetImageDecoders()
        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next
        Return Nothing
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name = txtName.Text.Trim()
        Dim address = txtAddress.Text.Trim()
        Dim phone = txtPhone.Text.Trim()
        Dim gender As String = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))

        If name = String.Empty OrElse gender = String.Empty Then
            MessageBox.Show("Please input all required fields (Name and Gender).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = Database.GetConnection()
                conn.Open()
                Dim cmd As MySqlCommand
                If employeeId.HasValue Then
                    Dim query As String = "UPDATE employees SET photo=@photo, name=@name, address=@address, phone=@phone, gender=@gender WHERE id=@id"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", employeeId.Value)
                Else
                    Dim query As String = "INSERT INTO employees (photo, name, address, phone, gender) VALUES (@photo, @name, @address, @phone, @gender)"
                    cmd = New MySqlCommand(query, conn)
                End If

                cmd.Parameters.AddWithValue("@photo", If(photoData, DBNull.Value))
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@gender", gender)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
