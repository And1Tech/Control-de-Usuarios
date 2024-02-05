Imports MySql.Data.MySqlClient

Public Class Form3
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

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            Button1.Visible = True
            PictureBox1.Visible = True

            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True

            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            ' Llama al método datosusuarios()
            datosusuarios()
        End If
    End Sub

    Public Sub datosusuarios()

        Dim cedula As String = TextBox1.Text
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
                        MessageBox.Show("Usuario encontrado.")

                        ' Consultar los datos del usuario
                        Dim queryDatosUsuario As String = "SELECT id_rol, nombre, apellido, genero, fecha_nacimiento, direccion, telefono, correo_electronico FROM usuarios WHERE cedula = @cedula"
                        Dim id_rol As String = ""
                        Dim nombre As String = ""
                        Dim apellido As String = ""
                        Dim genero As String = ""
                        Dim fecha_nacimiento As Date
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
                                    fecha_nacimiento = Convert.ToDateTime(reader("fecha_nacimiento"))
                                    direccion = reader("direccion").ToString()
                                    telefono = reader("telefono").ToString()
                                    correo_electronico = reader("correo_electronico").ToString()
                                End If
                            End Using
                        End Using

                        If id_rol = "1" Then
                            TextBox2.Text = "Estudiante"
                        ElseIf id_rol = "2" Then
                            TextBox2.Text = "Profesor"
                        End If

                        ' Mostrar los datos en los TextBox correspondientes
                        TextBox3.Text = nombre
                        TextBox4.Text = apellido
                        TextBox5.Text = genero
                        TextBox6.Text = direccion
                        TextBox7.Text = telefono
                        TextBox8.Text = correo_electronico
                        TextBox9.Text = fecha_nacimiento.ToString("yyyy-MM-dd") ' Formato personalizable
                    Else
                        MessageBox.Show("Usuario no encontrado")
                        PictureBox1.Visible = False
                        Button1.Visible = False

                        TextBox2.Visible = False
                        TextBox3.Visible = False
                        TextBox4.Visible = False
                        TextBox5.Visible = False
                        TextBox6.Visible = False
                        TextBox7.Visible = False
                        TextBox8.Visible = False
                        TextBox9.Visible = False

                        Label2.Visible = False
                        Label4.Visible = False
                        Label5.Visible = False
                        Label6.Visible = False
                        Label7.Visible = False
                        Label8.Visible = False
                        Label9.Visible = False
                        Label10.Visible = False
                        ' Limpiar los TextBox si el usuario no se encuentra
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        TextBox9.Clear()
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

    Public Sub ActualizarDatos()
        Dim cedula As String = TextBox1.Text
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
                        ' Actualizar los datos del usuario
                        Dim queryActualizarUsuario As String = "UPDATE usuarios SET nombre = @nombre, apellido = @apellido, genero = @genero, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion, telefono = @telefono, correo_electronico = @correo_electronico WHERE cedula = @cedula"

                        Using commandActualizarUsuario As New MySqlCommand(queryActualizarUsuario, miConexion.connection)
                            commandActualizarUsuario.Parameters.AddWithValue("@nombre", TextBox3.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@apellido", TextBox4.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@genero", TextBox5.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@fecha_nacimiento", TextBox9.Text) ' Suponiendo que el valor de TextBox9 es válido para fecha
                            commandActualizarUsuario.Parameters.AddWithValue("@direccion", TextBox6.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@telefono", TextBox7.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@correo_electronico", TextBox8.Text)
                            commandActualizarUsuario.Parameters.AddWithValue("@cedula", cedula)

                            Dim filasActualizadas As Integer = commandActualizarUsuario.ExecuteNonQuery()
                            If filasActualizadas > 0 Then
                                MessageBox.Show("Datos actualizados exitosamente.")
                            Else
                                MessageBox.Show("No se pudieron actualizar los datos del usuario.")
                            End If
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar los datos del usuario: " & ex.Message)
            Finally
                ' Cerrar la conexión
                miConexion.CerrarConexion()
            End Try
        Else
            MessageBox.Show("No se pudo abrir la conexión a la base de datos.")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False

        Button1.Visible = False
        PictureBox1.Visible = False

        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False

        Label2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Button1.Visible = False
        PictureBox1.Visible = False

        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        Label2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActualizarDatos()
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If TextBox7.TextLength >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar la acción de escritura y mostrar una alerta de error
            e.Handled = True
            MessageBox.Show("No se pueden ingresar más de 10 números.")
        ElseIf TextBox7.TextLength = 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Eliminar el último carácter
            TextBox7.Text = TextBox7.Text.Remove(TextBox7.TextLength - 1)
            ' Ubicar el cursor al final del texto
            TextBox7.SelectionStart = TextBox7.Text.Length
        End If
    End Sub
End Class