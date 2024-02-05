Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If TextBox1.TextLength >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar la acción de escritura y mostrar una alerta de error
            e.Handled = True
            MessageBox.Show("No se pueden ingresar más de 10 números.")
        ElseIf TextBox1.TextLength = 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Eliminar el último carácter
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.TextLength - 1)
            ' Ubicar el cursor al final del texto
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        verificarusuario()
    End Sub

    Private Sub verificarusuario()
        ' Obtener la cédula ingresada por el usuario
        Dim cedula As String = TextBox1.Text ' Suponiendo que la cédula se ingresa en un TextBox llamado TextBox1
        ' Crear una instancia de la conexión a la base de datos
        Dim miConexion As New ConexionBD()

        If miConexion.AbrirConexion() Then
            Try
                ' Consultar si el usuario con la cédula proporcionada está registrado
                Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE cedula = @cedula"
                Dim resultado As Integer = 0
                ' Ejecutar la consulta
                Using command As New MySqlCommand(query, miConexion.connection)
                    command.Parameters.AddWithValue("@cedula", cedula)
                    resultado = Convert.ToInt32(command.ExecuteScalar())
                    ' Verificar el resultado de la consulta
                    If resultado > 0 Then

                        MessageBox.Show("Usuario registrado")

                        ' Labels 1
                        Label4.Visible = True
                        Label2.Visible = True
                        Label5.Visible = True
                        Label6.Visible = True
                        Label7.Visible = True
                        Label8.Visible = True
                        Label9.Visible = True
                        ' Labels que mustran datos de los usuarios
                        Label10.Visible = True
                        Label11.Visible = True
                        Label12.Visible = True
                        Label13.Visible = True
                        Label14.Visible = True
                        Label15.Visible = True
                        Label16.Visible = True

                        ' Consultar los datos del usuario
                        Dim queryDatosUsuario As String = "SELECT id_rol, nombre, apellido, genero, direccion, telefono, correo_electronico FROM usuarios WHERE cedula = @cedula"
                        Dim id_rol As String = ""
                        Dim nombre As String = ""
                        Dim apellido As String = ""
                        Dim genero As String = ""
                        Dim direccion As String = ""
                        Dim telefono As String = ""
                        Dim correo_electronico As String = ""

                        Using commandDatosUsuario As New MySqlCommand(queryDatosUsuario, miConexion.connection)
                            commandDatosUsuario.Parameters.AddWithValue("@cedula", cedula)

                            Using reader As MySqlDataReader = commandDatosUsuario.ExecuteReader()
                                If reader.Read() Then
                                    id_rol = reader("id_rol").ToString()
                                    nombre = reader("nombre").ToString()
                                    apellido = reader("apellido").ToString()
                                    genero = reader("genero").ToString()
                                    direccion = reader("direccion").ToString()
                                    telefono = reader("telefono").ToString()
                                    correo_electronico = reader("correo_electronico").ToString()
                                End If
                            End Using
                        End Using

                        If id_rol = "1" Then
                            Label10.Text = "Estudiante"
                        ElseIf id_rol = "2" Then
                            Label10.Text = "Profesor"
                        End If
                        ' Asignar los datos del usuario a los labels correspondientes
                        Label11.Text = nombre
                        Label12.Text = apellido
                        Label13.Text = genero
                        Label14.Text = direccion
                        Label15.Text = telefono
                        Label16.Text = correo_electronico
                    Else
                        MessageBox.Show("Usuario no encontrado")
                        ' Labels 1
                        Label4.Visible = False
                        Label2.Visible = False
                        Label5.Visible = False
                        Label6.Visible = False
                        Label7.Visible = False
                        Label8.Visible = False
                        Label9.Visible = False
                        ' Labels que mustran datos de los usuarios
                        Label10.Visible = False
                        Label11.Visible = False
                        Label12.Visible = False
                        Label13.Visible = False
                        Label14.Visible = False
                        Label15.Visible = False
                        Label16.Visible = False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al verificar el usuario: " & ex.Message)
            Finally
                ' Cerrar la conexión
                miConexion.CerrarConexion()
            End Try
        Else
            MessageBox.Show("No se pudo abrir la conexión a la base de datos.")
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        TextBox1.Text = ""

        ' Labels 1
        Label4.Visible = False
        Label2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        ' Labels que mustran datos de los usuarios
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Labels 1
        Label4.Visible = False
        Label2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        ' Labels que mustran datos de los usuarios
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Llamar al procedimiento que tiene Button1
            Button1.PerformClick()
        End If
    End Sub
End Class