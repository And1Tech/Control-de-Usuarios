Imports MySql.Data.MySqlClient

Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginadmin()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(255, 255, 255)
        Button1.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(31, 31, 31)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub loginadmin()
        Dim miConexion As New ConexionBD() ' Crear una nueva instancia de la clase ConexionBD
        If miConexion.AbrirConexion Then
            Dim usuario As String = TextBox1.Text
            Dim contrasena As String = TextBox2.Text
            ' Consulta SQL para verificar el usuario y la contraseña
            Dim sql As String = "SELECT COUNT(*) FROM admin WHERE a_usuario = @usuario AND a_contraseña = @contrasena"
            Using command As New MySqlCommand(sql, miConexion.connection)
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@contrasena", contrasena)
                ' Ejecutar la consulta y obtener el resultado (cantidad de coincidencias)
                Dim resultado As Integer = Convert.ToInt32(command.ExecuteScalar())
                ' Verificar si se encontró un registro coincidente
                If resultado > 0 Then
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Menus.Show()
                    ' Aquí puedes realizar alguna acción adicional, como abrir otra ventana o realizar alguna operación en la aplicación.
                Else
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
            ' Cerrar la conexión
            miConexion.CerrarConexion()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.TabStop = False
        TextBox1.TabStop = False
        TextBox2.TabStop = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Reproduce un sonido cuando se hace clic en la imagen
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

End Class