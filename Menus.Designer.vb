<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menus
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menus))
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button6 = New Button()
        panel_contenedor = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button6)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 675)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button5.Cursor = Cursors.Hand
        Button5.Dock = DockStyle.Top
        Button5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(0, 434)
        Button5.Name = "Button5"
        Button5.Size = New Size(300, 63)
        Button5.TabIndex = 11
        Button5.Text = "Tabla de Usuarios Registrados"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button4.Cursor = Cursors.Hand
        Button4.Dock = DockStyle.Top
        Button4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(0, 371)
        Button4.Name = "Button4"
        Button4.Size = New Size(300, 63)
        Button4.TabIndex = 10
        Button4.Text = "Eliminar Usuario"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Top
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 308)
        Button3.Name = "Button3"
        Button3.Size = New Size(300, 63)
        Button3.TabIndex = 9
        Button3.Text = "Actualizar datos de Usuario"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Top
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(300, 63)
        Button2.TabIndex = 8
        Button2.Text = "Buscar Usuario"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Top
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 182)
        Button1.Name = "Button1"
        Button1.Size = New Size(300, 63)
        Button1.TabIndex = 7
        Button1.Text = "Registros de Usuarios"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 182)
        Panel2.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(28, -40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 206)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button6.Cursor = Cursors.Hand
        Button6.Dock = DockStyle.Bottom
        Button6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(0, 615)
        Button6.Name = "Button6"
        Button6.Size = New Size(300, 60)
        Button6.TabIndex = 5
        Button6.Text = "Cerrar Aplicacion"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' panel_contenedor
        ' 
        panel_contenedor.Dock = DockStyle.Fill
        panel_contenedor.Location = New Point(300, 0)
        panel_contenedor.Name = "panel_contenedor"
        panel_contenedor.Size = New Size(838, 675)
        panel_contenedor.TabIndex = 1
        ' 
        ' Menus
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 675)
        Controls.Add(panel_contenedor)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Menus"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menus"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents panel_contenedor As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
