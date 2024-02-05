<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9F)
        TextBox1.Location = New Point(140, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(190, 22)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(177, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 32)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 9F)
        TextBox2.Location = New Point(140, 232)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(190, 22)
        TextBox2.TabIndex = 5
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(140, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 18)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(140, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 18)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(350, 236)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 7
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(206, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 21)
        Label1.TabIndex = 0
        Label1.Text = "your account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(369, 223)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 36)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(149, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 19)
        Label4.TabIndex = 9
        Label4.Text = "Login"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.Location = New Point(34, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 19)
        Label5.TabIndex = 10
        Label5.Text = "Hola!"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.Location = New Point(34, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(209, 19)
        Label6.TabIndex = 11
        Label6.Text = "Bienvenido Administrador" & vbCrLf
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(356, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(439, 365)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(396, 326)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 36)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.capture_240203_101626
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(356, 365)
        Panel2.TabIndex = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(795, 365)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox

End Class
