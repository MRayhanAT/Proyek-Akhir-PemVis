<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeUser
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
        Todolistbox = New CheckedListBox()
        txtList = New TextBox()
        BtnTambah = New Button()
        BtnAjukan = New Button()
        BtnRiwayat = New Button()
        BtnLogout = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        LblNamaUser = New Label()
        UserName = New Label()
        SuspendLayout()
        ' 
        ' Todolistbox
        ' 
        Todolistbox.BackColor = Color.White
        Todolistbox.CheckOnClick = True
        Todolistbox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Todolistbox.FormattingEnabled = True
        Todolistbox.Items.AddRange(New Object() {"Tagihan Lunas", "Bayar Tagihan Bulan Ke-1", "Bayar Tagihan Bulan Ke-2", "Bayar Tagihan Bulan Ke-3"})
        Todolistbox.Location = New Point(370, 102)
        Todolistbox.Margin = New Padding(11, 12, 11, 12)
        Todolistbox.Name = "Todolistbox"
        Todolistbox.Size = New Size(459, 204)
        Todolistbox.TabIndex = 15
        ' 
        ' txtList
        ' 
        txtList.Location = New Point(370, 329)
        txtList.Margin = New Padding(3, 4, 3, 4)
        txtList.Multiline = True
        txtList.Name = "txtList"
        txtList.Size = New Size(459, 39)
        txtList.TabIndex = 16
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.DarkGoldenrod
        BtnTambah.FlatAppearance.BorderSize = 0
        BtnTambah.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnTambah.FlatStyle = FlatStyle.Flat
        BtnTambah.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(627, 384)
        BtnTambah.Margin = New Padding(3, 4, 3, 4)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(202, 42)
        BtnTambah.TabIndex = 18
        BtnTambah.Text = "Tambah Tugas"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnAjukan
        ' 
        BtnAjukan.BackColor = Color.DarkGoldenrod
        BtnAjukan.FlatAppearance.BorderSize = 0
        BtnAjukan.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnAjukan.FlatStyle = FlatStyle.Flat
        BtnAjukan.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAjukan.ForeColor = Color.White
        BtnAjukan.Location = New Point(16, 539)
        BtnAjukan.Margin = New Padding(3, 4, 3, 4)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(842, 47)
        BtnAjukan.TabIndex = 19
        BtnAjukan.Text = "Ajukan Pinjaman"
        BtnAjukan.UseVisualStyleBackColor = False
        ' 
        ' BtnRiwayat
        ' 
        BtnRiwayat.BackColor = Color.DarkGoldenrod
        BtnRiwayat.FlatAppearance.BorderSize = 0
        BtnRiwayat.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnRiwayat.FlatStyle = FlatStyle.Flat
        BtnRiwayat.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRiwayat.ForeColor = Color.White
        BtnRiwayat.Location = New Point(16, 475)
        BtnRiwayat.Margin = New Padding(3, 4, 3, 4)
        BtnRiwayat.Name = "BtnRiwayat"
        BtnRiwayat.Size = New Size(842, 47)
        BtnRiwayat.TabIndex = 20
        BtnRiwayat.Text = "Riwayat Peminjaman"
        BtnRiwayat.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogout.ForeColor = Color.White
        BtnLogout.Location = New Point(16, 598)
        BtnLogout.Margin = New Padding(3, 4, 3, 4)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(842, 47)
        BtnLogout.TabIndex = 21
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(370, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 46)
        Label2.TabIndex = 22
        Label2.Text = "To Do List"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 91)
        Label1.TabIndex = 23
        Label1.Text = "Selamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(16, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(317, 91)
        Label3.TabIndex = 24
        Label3.Text = "Datang,"
        ' 
        ' LblNamaUser
        ' 
        LblNamaUser.AutoSize = True
        LblNamaUser.BackColor = Color.Transparent
        LblNamaUser.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblNamaUser.ForeColor = Color.White
        LblNamaUser.Location = New Point(16, 276)
        LblNamaUser.Name = "LblNamaUser"
        LblNamaUser.Size = New Size(0, 91)
        LblNamaUser.TabIndex = 25
        ' 
        ' UserName
        ' 
        UserName.AutoSize = True
        UserName.BackColor = Color.Transparent
        UserName.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserName.ForeColor = Color.White
        UserName.Location = New Point(16, 276)
        UserName.Name = "UserName"
        UserName.Size = New Size(306, 91)
        UserName.TabIndex = 26
        UserName.Text = "(Nama)"
        ' 
        ' HomeUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__17_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(UserName)
        Controls.Add(LblNamaUser)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(BtnLogout)
        Controls.Add(BtnRiwayat)
        Controls.Add(BtnAjukan)
        Controls.Add(BtnTambah)
        Controls.Add(txtList)
        Controls.Add(Todolistbox)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "HomeUser"
        Text = "HomeUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Todolistbox As CheckedListBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents BtnRiwayat As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNamaUser As Label
    Friend WithEvents UserName As Label
End Class
