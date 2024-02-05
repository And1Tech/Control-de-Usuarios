<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label10 = New Label()
        ComboBox4 = New ComboBox()
        CheckBox3 = New CheckBox()
        TextBox4 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label1.Location = New Point(66, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 32)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRAR USUARIO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label2.Location = New Point(67, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 22)
        Label2.TabIndex = 1
        Label2.Text = "Usted es :"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        CheckBox1.Location = New Point(190, 111)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(84, 20)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Estudiante"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        CheckBox2.Location = New Point(306, 111)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(73, 20)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Profesor"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label3.Location = New Point(67, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 22)
        Label3.TabIndex = 4
        Label3.Text = "Número de cedula :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label4.Location = New Point(67, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 22)
        Label4.TabIndex = 5
        Label4.Text = "Nombres :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label5.Location = New Point(67, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 22)
        Label5.TabIndex = 6
        Label5.Text = "Apellidos :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label6.Location = New Point(67, 286)
        Label6.Name = "Label6"
        Label6.Size = New Size(216, 22)
        Label6.TabIndex = 7
        Label6.Text = "Fecha de nacimiento :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Century Gothic", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(295, 285)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(66, 25)
        ComboBox1.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Century Gothic", 9F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(367, 285)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(65, 25)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Century Gothic", 9F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(438, 285)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(47, 25)
        ComboBox3.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label7.Location = New Point(306, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 23)
        Label7.TabIndex = 11
        Label7.Text = "Año"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label8.Location = New Point(377, 311)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 23)
        Label8.TabIndex = 12
        Label8.Text = "Mes"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label9.Location = New Point(445, 311)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 23)
        Label9.TabIndex = 13
        Label9.Text = "Dia"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9F)
        TextBox1.Location = New Point(266, 158)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 22)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F)
        TextBox2.Location = New Point(179, 201)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(306, 22)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 9F)
        TextBox3.Location = New Point(179, 241)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(306, 22)
        TextBox3.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label10.Location = New Point(73, 356)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 22)
        Label10.TabIndex = 17
        Label10.Text = "Genero :"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.Font = New Font("Century Gothic", 9F)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(170, 355)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(136, 25)
        ComboBox4.TabIndex = 18
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        CheckBox3.Location = New Point(318, 357)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(51, 20)
        CheckBox3.TabIndex = 19
        CheckBox3.Text = "Otro"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 9F)
        TextBox4.Location = New Point(374, 356)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(191, 22)
        TextBox4.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label11.Location = New Point(73, 400)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 22)
        Label11.TabIndex = 21
        Label11.Text = "Direccion :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label12.Location = New Point(73, 435)
        Label12.Name = "Label12"
        Label12.Size = New Size(189, 22)
        Label12.TabIndex = 22
        Label12.Text = "Número de celular :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Label13.Location = New Point(73, 471)
        Label13.Name = "Label13"
        Label13.Size = New Size(191, 22)
        Label13.TabIndex = 23
        Label13.Text = "Correo electronico :"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Century Gothic", 9F)
        TextBox5.Location = New Point(190, 400)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(341, 22)
        TextBox5.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Century Gothic", 9F)
        TextBox6.Location = New Point(265, 434)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(300, 22)
        TextBox6.TabIndex = 25
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Century Gothic", 9F)
        TextBox7.Location = New Point(265, 470)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(300, 22)
        TextBox7.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button1.Location = New Point(342, 565)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 53)
        Button1.TabIndex = 27
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(530, 574)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 636)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(TextBox4)
        Controls.Add(CheckBox3)
        Controls.Add(ComboBox4)
        Controls.Add(Label10)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
