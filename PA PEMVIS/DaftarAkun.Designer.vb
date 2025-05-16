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
        txtNomorHP = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        BtnDaftar = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        SimpanGambar = New SaveFileDialog()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.Transparent
        BtnKembali.BackgroundImage = CType(resources.GetObject("BtnKembali.BackgroundImage"), Image)
        BtnKembali.BackgroundImageLayout = ImageLayout.Zoom
        BtnKembali.Cursor = Cursors.Hand
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.ForeColor = Color.Transparent
        BtnKembali.Location = New Point(12, 5)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 49)
        BtnKembali.TabIndex = 0
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Swis721 Cn BT", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(325, 126)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(320, 32)
        txtUsername.TabIndex = 1
        txtUsername.Text = " Masukkan Username"
        ' 
        ' txtNomorHP
        ' 
        txtNomorHP.Cursor = Cursors.IBeam
        txtNomorHP.Font = New Font("Swis721 Cn BT", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNomorHP.ForeColor = Color.DarkGray
        txtNomorHP.Location = New Point(378, 173)
        txtNomorHP.Multiline = True
        txtNomorHP.Name = "txtNomorHP"
        txtNomorHP.Size = New Size(267, 32)
        txtNomorHP.TabIndex = 7
        txtNomorHP.Text = " Masukkan Nomor HP"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(378, 220)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(267, 120)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(319, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 19)
        Label2.TabIndex = 9
        Label2.Text = "KTP :"
        ' 
        ' BtnDaftar
        ' 
        BtnDaftar.BackColor = Color.DarkGoldenrod
        BtnDaftar.Cursor = Cursors.Hand
        BtnDaftar.FlatAppearance.BorderSize = 0
        BtnDaftar.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnDaftar.FlatStyle = FlatStyle.Flat
        BtnDaftar.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDaftar.ForeColor = Color.White
        BtnDaftar.Location = New Point(325, 399)
        BtnDaftar.Name = "BtnDaftar"
        BtnDaftar.Size = New Size(320, 40)
        BtnDaftar.TabIndex = 10
        BtnDaftar.Text = "Daftar"
        BtnDaftar.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Swis721 Cn BT", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(325, 356)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(320, 32)
        txtPassword.TabIndex = 11
        txtPassword.Text = "Masukkan Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(631, 516)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 35)
        Label1.TabIndex = 12
        Label1.Text = "SihCepat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkGoldenrod
        Label3.Location = New Point(319, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 22)
        Label3.TabIndex = 13
        Label3.Text = "+62"
        ' 
        ' DaftarAkun
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(BtnDaftar)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(txtNomorHP)
        Controls.Add(txtUsername)
        Controls.Add(BtnKembali)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "DaftarAkun"
        Text = "DaftarAkun"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtNomorHP As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpanGambar As SaveFileDialog
    Friend WithEvents Label3 As Label
End Class
