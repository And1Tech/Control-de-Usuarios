Imports MySql.Data.MySqlClient

Public Class ConexionBD
    Private connectionString As String = "Server=localhost;Port=3307;Database=bdd_formulario;Uid=root;Pwd=usbw;"
    Public connection As MySqlConnection

    Public Sub New()
        connection = New MySqlConnection(connectionString)
    End Sub

    Public Function AbrirConexion() As Boolean
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub CerrarConexion()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class