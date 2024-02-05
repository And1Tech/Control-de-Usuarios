<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label3 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label3.Location = New Point(41, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 23)
        Label3.TabIndex = 7
        Label3.Text = "Número de cedula :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label1.Location = New Point(31, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(366, 32)
        Label1.TabIndex = 6
        Label1.Text = "ACTUALIZACION DE DATOS"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(240, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(188, 22)
        TextBox1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label2.Location = New Point(43, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 22)
        Label2.TabIndex = 9
        Label2.Text = "Rol :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label4.Location = New Point(43, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 22)
        Label4.TabIndex = 10
        Label4.Text = "Nombres :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label5.Location = New Point(43, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 22)
        Label5.TabIndex = 11
        Label5.Text = "Apellidos :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label6.Location = New Point(43, 277)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 22)
        Label6.TabIndex = 12
        Label6.Text = "Genero :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label7.Location = New Point(43, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 22)
        Label7.TabIndex = 13
        Label7.Text = "Direccion :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label8.Location = New Point(43, 349)
        Label8.Name = "Label8"
        Label8.Size = New Size(189, 22)
        Label8.TabIndex = 14
        Label8.Text = "Número de celular :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label9.Location = New Point(43, 385)
        Label9.Name = "Label9"
        Label9.Size = New Size(191, 22)
        Label9.TabIndex = 15
        Label9.Text = "Correo electronico :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label10.Location = New Point(43, 424)
        Label10.Name = "Label10"
        Label10.Size = New Size(216, 22)
        Label10.TabIndex = 16
        Label10.Text = "Fecha de nacimiento :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(96, 170)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(188, 22)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(150, 205)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(254, 22)
        TextBox3.TabIndex = 18
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(150, 243)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(254, 22)
        TextBox4.TabIndex = 19
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(150, 277)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(188, 22)
        TextBox5.TabIndex = 20
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(155, 310)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(249, 22)
        TextBox6.TabIndex = 21
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(242, 349)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(196, 22)
        TextBox7.TabIndex = 22
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(240, 387)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(243, 22)
        TextBox8.TabIndex = 23
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(265, 424)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(188, 22)
        TextBox9.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(329, 504)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 40)
        Button1.TabIndex = 25
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(503, 504)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 675)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
