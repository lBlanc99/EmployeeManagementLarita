Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Module Database
    Public Const ConnectionString As String = "Server=localhost;Database=employee_management;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Dim connection As New MySqlConnection(ConnectionString)
        Return connection
    End Function
End Module
