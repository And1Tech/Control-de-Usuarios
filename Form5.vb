Imports MySql.Data.MySqlClient

Public Class Form5

    Dim miConexion As New ConexionBD()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUsuarios()
    End Sub

    Private Sub CargarDatosUsuarios()
        If miConexion.AbrirConexion() Then
            Dim dataTable As New DataTable()
            Dim sql As String = "SELECT * FROM usuarios;"
            Dim adapter As New MySqlDataAdapter(sql, miConexion.connection)

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
            miConexion.CerrarConexion()
        Else
            MessageBox.Show("Error al conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class