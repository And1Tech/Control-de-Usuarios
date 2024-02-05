Public Class Menus
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarFormulario(New Form1())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MostrarFormulario(New Form5())
    End Sub

    Private Sub MostrarFormulario(formulario As Form)
        ' Establecer el formulario como control secundario del panel "contenedor"
        formulario.TopLevel = False
        panel_contenedor.Controls.Clear()
        panel_contenedor.Controls.Add(formulario)
        formulario.Show()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(255, 255, 255)
        Button1.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(31, 31, 31)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.FromArgb(255, 255, 255)
        Button2.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(31, 31, 31)
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.FromArgb(255, 255, 255)
        Button3.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(31, 31, 31)
        Button3.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.FromArgb(255, 255, 255)
        Button4.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(31, 31, 31)
        Button4.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.BackColor = Color.FromArgb(255, 255, 255)
        Button5.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.FromArgb(31, 31, 31)
        Button5.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.BackColor = Color.FromArgb(255, 255, 255)
        Button6.ForeColor = Color.FromArgb(31, 31, 31)
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.FromArgb(31, 31, 31)
        Button6.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MostrarFormulario(New Form2())
    End Sub

    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.TabStop = False
        Button2.TabStop = False
        Button3.TabStop = False
        Button4.TabStop = False
        Button5.TabStop = False
        Button6.TabStop = False
        MostrarFormulario(New Form6())
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        MostrarFormulario(New Form6())
        Button1.TabStop = False
        Button2.TabStop = False
        Button3.TabStop = False
        Button4.TabStop = False
        Button5.TabStop = False
        Button6.TabStop = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MostrarFormulario(New Form3())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MostrarFormulario(New Form4())
    End Sub
End Class