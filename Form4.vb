Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Button1.Visible = False
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
                        Button1.Visible = True

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

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            verificarusuario()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mostrar el formulario Form7 de forma asíncrona
        ' Obtener la cédula ingresada por el usuario
        Dim cedula As String = Me.TextBox1.Text

        ' Mostrar el formulario Form7 de forma asíncrona
        Dim mostrarForm7Thread As New Thread(Sub()
                                                 Dim form7 As New Form7
                                                 form7.cedulaAEliminar = cedula
                                                 form7.ShowDialog()
                                             End Sub)
        mostrarForm7Thread.Start()

        ' Reproducir el primer audio
        My.Computer.Audio.Play(My.Resources.alertasonido1, AudioPlayMode.WaitToComplete)

        ' Reproducir el segundo audio después de que termine el primero
        My.Computer.Audio.Play(My.Resources.audiobot1, AudioPlayMode.Background)
    End Sub

    Private Sub MostrarForm7()
        Dim form7 As New Form7()
        form7.ShowDialog()
    End Sub



End Class