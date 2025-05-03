Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide Form1 while showing LoginForm
        Me.Hide()

        Using login As New LoginForm()
            Dim result = login.ShowDialog()
            If result = DialogResult.OK Then
                ' Login success, show Form1
                Me.Show()
            Else
                ' Login failed or canceled, close the app
                Me.Close()
            End If
        End Using
    End Sub
End Class