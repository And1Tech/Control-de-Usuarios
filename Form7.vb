Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7

    Public cedulaAEliminar As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eliminarUsuario()
    End Sub
    Private Sub eliminarUsuario()
        ' Obtener la cédula ingresada por el usuario
        Dim miConexion As New ConexionBD()

        If miConexion.AbrirConexion() Then
            Try
                ' Consultar si el usuario con la cédula proporcionada está registrado
                Dim cedula As String = Me.cedulaAEliminar
                Dim queryEliminarUsuario As String = "DELETE FROM usuarios WHERE cedula = @cedula"

                ' Ejecutar la eliminación del usuario
                Using commandEliminarUsuario As New MySqlCommand(queryEliminarUsuario, miConexion.connection)
                    commandEliminarUsuario.Parameters.AddWithValue("@cedula", cedula)
                    Dim rowsAffected As Integer = commandEliminarUsuario.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario eliminado correctamente")
                    Else
                        MessageBox.Show("No se encontró ningún usuario con esa cédula")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el usuario: " & ex.Message)
            Finally
                ' Cerrar la conexión
                miConexion.CerrarConexion()
            End Try
        Else
            MessageBox.Show("No se pudo abrir la conexión a la base de datos.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

End Class