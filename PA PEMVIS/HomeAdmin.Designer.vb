<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeAdmin))
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        ManajemenPinjamanToolStripMenuItem = New ToolStripMenuItem()
        DaftarUserToolStripMenuItem = New ToolStripMenuItem()
        DaftarPinjamanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label2 = New Label()
        LbUser = New Label()
        LbPinjaman = New Label()
        LbTerima = New Label()
        LbTolak = New Label()
        LblPinjaman = New Label()
        LblTerima = New Label()
        LblTolak = New Label()
        LblUser = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkGoldenrod
        Label1.Font = New Font("Swis721 Hv BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(102, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(554, 77)
        Label1.TabIndex = 0
        Label1.Text = "Selamat Datang,"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManajemenPinjamanToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(763, 25)
        MenuStrip1.TabIndex = 16
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ManajemenPinjamanToolStripMenuItem
        ' 
        ManajemenPinjamanToolStripMenuItem.BackColor = SystemColors.Control
        ManajemenPinjamanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DaftarUserToolStripMenuItem, DaftarPinjamanToolStripMenuItem})
        ManajemenPinjamanToolStripMenuItem.Font = New Font("Swis721 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ManajemenPinjamanToolStripMenuItem.Name = "ManajemenPinjamanToolStripMenuItem"
        ManajemenPinjamanToolStripMenuItem.Size = New Size(143, 21)
        ManajemenPinjamanToolStripMenuItem.Text = "Manajemen Pinjaman"
        ' 
        ' DaftarUserToolStripMenuItem
        ' 
        DaftarUserToolStripMenuItem.Name = "DaftarUserToolStripMenuItem"
        DaftarUserToolStripMenuItem.Size = New Size(165, 22)
        DaftarUserToolStripMenuItem.Text = "Daftar User"
        ' 
        ' DaftarPinjamanToolStripMenuItem
        ' 
        DaftarPinjamanToolStripMenuItem.Name = "DaftarPinjamanToolStripMenuItem"
        DaftarPinjamanToolStripMenuItem.Size = New Size(165, 22)
        DaftarPinjamanToolStripMenuItem.Text = "Daftar Pinjaman"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(57, 21)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkGoldenrod
        Label5.Location = New Point(59, 363)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 25)
        Label5.TabIndex = 17
        Label5.Text = "Total User"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGoldenrod
        Label6.Location = New Point(261, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 25)
        Label6.TabIndex = 18
        Label6.Text = "Total"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGoldenrod
        Label7.Location = New Point(424, 352)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 25)
        Label7.TabIndex = 19
        Label7.Text = "Pinjaman"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkGoldenrod
        Label8.Location = New Point(603, 360)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 25)
        Label8.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkGoldenrod
        Label9.Location = New Point(231, 378)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 25)
        Label9.TabIndex = 21
        Label9.Text = "Peminjaman"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkGoldenrod
        Label10.Location = New Point(428, 378)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 25)
        Label10.TabIndex = 22
        Label10.Text = "Diterima"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkGoldenrod
        Label11.Location = New Point(614, 378)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 25)
        Label11.TabIndex = 24
        Label11.Text = "Ditolak"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkGoldenrod
        Label12.Location = New Point(606, 352)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 25)
        Label12.TabIndex = 23
        Label12.Text = "Pinjaman"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkGoldenrod
        Label2.Font = New Font("Swis721 Hv BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(254, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 77)
        Label2.TabIndex = 25
        Label2.Text = "Admin!"
        ' 
        ' LbUser
        ' 
        LbUser.AutoSize = True
        LbUser.BackColor = Color.Transparent
        LbUser.Font = New Font("Swis721 Cn BT", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbUser.ForeColor = Color.DarkGoldenrod
        LbUser.Location = New Point(80, 410)
        LbUser.Name = "LbUser"
        LbUser.Size = New Size(0, 77)
        LbUser.TabIndex = 26
        ' 
        ' LbPinjaman
        ' 
        LbPinjaman.AutoSize = True
        LbPinjaman.BackColor = Color.Transparent
        LbPinjaman.Font = New Font("Swis721 Cn BT", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbPinjaman.ForeColor = Color.DarkGoldenrod
        LbPinjaman.Location = New Point(261, 410)
        LbPinjaman.Name = "LbPinjaman"
        LbPinjaman.Size = New Size(0, 77)
        LbPinjaman.TabIndex = 27
        ' 
        ' LbTerima
        ' 
        LbTerima.AutoSize = True
        LbTerima.BackColor = Color.Transparent
        LbTerima.Font = New Font("Swis721 Cn BT", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbTerima.ForeColor = Color.DarkGoldenrod
        LbTerima.Location = New Point(443, 410)
        LbTerima.Name = "LbTerima"
        LbTerima.Size = New Size(0, 77)
        LbTerima.TabIndex = 28
        ' 
        ' LbTolak
        ' 
        LbTolak.AutoSize = True
        LbTolak.BackColor = Color.Transparent
        LbTolak.Font = New Font("Swis721 Cn BT", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbTolak.ForeColor = Color.DarkGoldenrod
        LbTolak.Location = New Point(625, 410)
        LbTolak.Name = "LbTolak"
        LbTolak.Size = New Size(0, 77)
        LbTolak.TabIndex = 29
        ' 
        ' LblPinjaman
        ' 
        LblPinjaman.AutoSize = True
        LblPinjaman.BackColor = Color.Transparent
        LblPinjaman.Font = New Font("Swis721 BlkCn BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPinjaman.ForeColor = Color.DarkGoldenrod
        LblPinjaman.Location = New Point(259, 429)
        LblPinjaman.Name = "LblPinjaman"
        LblPinjaman.Size = New Size(0, 77)
        LblPinjaman.TabIndex = 30
        ' 
        ' LblTerima
        ' 
        LblTerima.AutoSize = True
        LblTerima.BackColor = Color.Transparent
        LblTerima.Font = New Font("Swis721 BlkCn BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTerima.ForeColor = Color.DarkGoldenrod
        LblTerima.Location = New Point(441, 429)
        LblTerima.Name = "LblTerima"
        LblTerima.Size = New Size(0, 77)
        LblTerima.TabIndex = 31
        ' 
        ' LblTolak
        ' 
        LblTolak.AutoSize = True
        LblTolak.BackColor = Color.Transparent
        LblTolak.Font = New Font("Swis721 BlkCn BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTolak.ForeColor = Color.DarkGoldenrod
        LblTolak.Location = New Point(622, 429)
        LblTolak.Name = "LblTolak"
        LblTolak.Size = New Size(0, 77)
        LblTolak.TabIndex = 32
        ' 
        ' LblUser
        ' 
        LblUser.AutoSize = True
        LblUser.BackColor = Color.Transparent
        LblUser.Font = New Font("Swis721 BlkCn BT", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblUser.ForeColor = Color.DarkGoldenrod
        LblUser.Location = New Point(76, 429)
        LblUser.Name = "LblUser"
        LblUser.Size = New Size(0, 77)
        LblUser.TabIndex = 33
        ' 
        ' HomeAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(LblUser)
        Controls.Add(LblTolak)
        Controls.Add(LblTerima)
        Controls.Add(LblPinjaman)
        Controls.Add(LbTolak)
        Controls.Add(LbTerima)
        Controls.Add(LbPinjaman)
        Controls.Add(LbUser)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "HomeAdmin"
        Text = "HomeAdmin"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManajemenPinjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarPinjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbUser As Label
    Friend WithEvents LbPinjaman As Label
    Friend WithEvents LbTerima As Label
    Friend WithEvents LbTolak As Label
    Friend WithEvents LblPinjaman As Label
    Friend WithEvents LblTerima As Label
    Friend WithEvents LblTolak As Label
    Friend WithEvents LblUser As Label
End Class
