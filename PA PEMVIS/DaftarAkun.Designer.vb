<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarAkun
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarAkun))
        BtnKembali = New Button()
        txtUsername = New TextBox()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        BtnDaftar = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        SimpanGambar = New SaveFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.Transparent
        BtnKembali.BackgroundImage = CType(resources.GetObject("BtnKembali.BackgroundImage"), Image)
        BtnKembali.BackgroundImageLayout = ImageLayout.Zoom
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.ForeColor = Color.Transparent
        BtnKembali.Location = New Point(14, 6)
        BtnKembali.Margin = New Padding(3, 4, 3, 4)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(56, 58)
        BtnKembali.TabIndex = 0
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(371, 148)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(365, 37)
        txtUsername.TabIndex = 1
        txtUsername.Text = " Masukkan Username"
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.DarkGray
        TextBox3.Location = New Point(371, 204)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(365, 37)
        TextBox3.TabIndex = 7
        TextBox3.Text = " Masukkan Nomor HP"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(432, 259)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(305, 141)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(365, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 29)
        Label2.TabIndex = 9
        Label2.Text = "KTP :"
        ' 
        ' BtnDaftar
        ' 
        BtnDaftar.BackColor = Color.DarkGoldenrod
        BtnDaftar.FlatAppearance.BorderSize = 0
        BtnDaftar.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnDaftar.FlatStyle = FlatStyle.Flat
        BtnDaftar.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDaftar.ForeColor = Color.White
        BtnDaftar.Location = New Point(371, 469)
        BtnDaftar.Margin = New Padding(3, 4, 3, 4)
        BtnDaftar.Name = "BtnDaftar"
        BtnDaftar.Size = New Size(366, 47)
        BtnDaftar.TabIndex = 10
        BtnDaftar.Text = "Daftar"
        BtnDaftar.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(371, 419)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(365, 37)
        txtPassword.TabIndex = 11
        txtPassword.Text = "Masukkan Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(721, 607)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 42)
        Label1.TabIndex = 12
        Label1.Text = "SihCepat"
        ' 
        ' DaftarAkun
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(BtnDaftar)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(txtUsername)
        Controls.Add(BtnKembali)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "DaftarAkun"
        Text = "DaftarAkun"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpanGambar As SaveFileDialog
End Class
