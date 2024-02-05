Imports MySql.Data.MySqlClient

Public Class Form1

    Dim miConexion As New ConexionBD()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Visible = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        CheckBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False

        ComboBox4.Items.Add("Masculino")
        ComboBox4.Items.Add("Femenino")

        Dim añoActual As Integer = 2024
        For año As Integer = añoActual To 1900 Step -1
            ComboBox1.Items.Add(año)
        Next
        Dim meses As Integer = 12
        For mes As Integer = meses To 1 Step -1
            ComboBox2.Items.Add(mes)
        Next
        Dim dias As Integer = 31
        For dia As Integer = dias To 1 Step -1
            ComboBox3.Items.Add(dia)
        Next
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox4.Visible = True
        Else
            TextBox4.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Enabled = False
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
            CheckBox3.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
        Else
            CheckBox2.Enabled = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            CheckBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Enabled = False
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
            CheckBox3.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
        Else
            CheckBox1.Enabled = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            CheckBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
        End If
    End Sub

    Private Function VerificarExistencia(columna As String, valor As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM usuarios WHERE {columna} = @valor"
        Using command As New MySqlCommand(query, miConexion.connection)
            command.Parameters.AddWithValue("@valor", valor)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub InsertarUsuario(idRol As Integer)
        ' Verificar si la cédula ya existe en la base de datos
        Dim cedulaExistente As Boolean = VerificarExistencia("cedula", TextBox1.Text)
        If cedulaExistente Then
            MessageBox.Show("La cédula ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            miConexion.CerrarConexion()
            Exit Sub ' Salir del método si la cédula ya existe
        End If
        ' Verificar si el correo electrónico ya existe en la base de datos
        Dim correoExistente As Boolean = VerificarExistencia("correo_electronico", TextBox7.Text)
        If correoExistente Then
            MessageBox.Show("El correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            miConexion.CerrarConexion()
            Exit Sub ' Salir del método si el correo electrónico ya existe
        End If
        ' Verificar si el teléfono ya existe en la base de datos
        Dim telefonoExistente As Boolean = VerificarExistencia("telefono", TextBox6.Text)
        If telefonoExistente Then
            MessageBox.Show("El teléfono ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            miConexion.CerrarConexion()
            Exit Sub ' Salir del método si el teléfono ya existe
        End If

        Dim otrogenero As String = ""

        If CheckBox3.Checked Then
            otrogenero = TextBox4.Text
        Else
            otrogenero = ComboBox4.Text ' Si CheckBox3 no está marcado, tomar el texto de ComboBox4
        End If

        Dim año As Integer = Convert.ToInt32(ComboBox1.Text)
        Dim mes As Integer = Convert.ToInt32(ComboBox2.Text)
        Dim dia As Integer = Convert.ToInt32(ComboBox3.Text)
        ' Crear un objeto DateTime con los valores
        Dim fecha_naci As New DateTime(año, mes, dia)
        ' Obtener la cadena formateada
        Dim fecha_naci_str As String = fecha_naci.ToString("yyyy-MM-dd")
        ' Crear la consulta SQL con parámetros
        Dim sql As String = "INSERT INTO usuarios (cedula, nombre, apellido, fecha_nacimiento, genero, direccion, telefono, correo_electronico, id_rol) VALUES (@cedula, @nombre, @apellido, @fecha_nacimiento, @genero, @direccion, @telefono,@correo_electronico, @id_rol)"
        ' Crear el comando con la conexión y la consulta SQL
        Using command As New MySqlCommand(sql, miConexion.connection)
            ' Agregar parámetros
            command.Parameters.AddWithValue("@cedula", TextBox1.Text)
            command.Parameters.AddWithValue("@nombre", TextBox2.Text)
            command.Parameters.AddWithValue("@apellido", TextBox3.Text)
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_naci_str)
            command.Parameters.AddWithValue("@genero", otrogenero)
            command.Parameters.AddWithValue("@direccion", TextBox5.Text)
            command.Parameters.AddWithValue("@telefono", TextBox6.Text)
            command.Parameters.AddWithValue("@correo_electronico", TextBox7.Text)
            command.Parameters.AddWithValue("@id_rol", idRol)
            ' Ejecutar la consulta
            command.ExecuteNonQuery()
            MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

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

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If TextBox6.TextLength >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar la acción de escritura y mostrar una alerta de error
            e.Handled = True
            MessageBox.Show("No se pueden ingresar más de 10 números.")
        ElseIf TextBox6.TextLength = 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Eliminar el último carácter
            TextBox6.Text = TextBox6.Text.Remove(TextBox6.TextLength - 1)
            ' Ubicar el cursor al final del texto
            TextBox6.SelectionStart = TextBox6.Text.Length
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idRol As Integer
        If TextBox1.Text = "" OrElse TextBox2.Text = "" OrElse TextBox3.Text = "" OrElse TextBox4.Text = "" OrElse TextBox5.Text = "" OrElse TextBox6.Text = "" OrElse TextBox7.Text = "" OrElse ComboBox1.SelectedIndex = -1 OrElse ComboBox2.SelectedIndex = -1 OrElse ComboBox3.SelectedIndex = -1 OrElse ComboBox4.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos de texto del 1 al 7 y seleccione una opción en todos los ComboBoxes del 1 al 4.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf miConexion.AbrirConexion Then
            If Not (CheckBox1.Checked Or CheckBox2.Checked) Then
                MessageBox.Show("Seleccione su identidad")
            ElseIf CheckBox1.Checked Then
                idRol = 1 ' Valor correspondiente al rol del CheckBox1
                InsertarUsuario(idRol)
            ElseIf CheckBox2.Checked Then
                idRol = 2 ' Valor correspondiente al rol del CheckBox2
                InsertarUsuario(idRol)
            End If
            miConexion.CerrarConexion()
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Visible = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        CheckBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Llamar al procedimiento que tiene Button1
            Button1.PerformClick()
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

End Class