<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        BtnKembali = New Button()
        DataGridView1 = New DataGridView()
        txtNominal = New TextBox()
        Label6 = New Label()
        Label9 = New Label()
        cbCicilan = New ComboBox()
        BtnAjukan = New Button()
        BtnBatalkanPinjaman = New Button()
        BtnBatalkanPerubahan = New Button()
        Label11 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        LbID2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnKembali.Location = New Point(9, 8)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 49)
        BtnKembali.TabIndex = 14
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(18, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(729, 231)
        DataGridView1.TabIndex = 15
        ' 
        ' txtNominal
        ' 
        txtNominal.Cursor = Cursors.IBeam
        txtNominal.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNominal.Location = New Point(37, 399)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(387, 27)
        txtNominal.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(37, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 22)
        Label6.TabIndex = 32
        Label6.Text = "Nominal Pinjaman"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(37, 436)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 22)
        Label9.TabIndex = 40
        Label9.Text = "Cicilan"
        ' 
        ' cbCicilan
        ' 
        cbCicilan.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCicilan.FormattingEnabled = True
        cbCicilan.Items.AddRange(New Object() {"3 Bulan", "6 Bulan", "12 Bulan"})
        cbCicilan.Location = New Point(37, 460)
        cbCicilan.Name = "cbCicilan"
        cbCicilan.Size = New Size(387, 27)
        cbCicilan.TabIndex = 42
        ' 
        ' BtnAjukan
        ' 
        BtnAjukan.BackColor = Color.LimeGreen
        BtnAjukan.Cursor = Cursors.Hand
        BtnAjukan.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnAjukan.FlatAppearance.BorderSize = 0
        BtnAjukan.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnAjukan.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnAjukan.FlatStyle = FlatStyle.Flat
        BtnAjukan.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAjukan.ForeColor = SystemColors.ControlLightLight
        BtnAjukan.Location = New Point(441, 342)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(287, 39)
        BtnAjukan.TabIndex = 43
        BtnAjukan.Text = "Simpan Perubahan"
        BtnAjukan.UseVisualStyleBackColor = False
        ' 
        ' BtnBatalkanPinjaman
        ' 
        BtnBatalkanPinjaman.BackColor = Color.DarkRed
        BtnBatalkanPinjaman.Cursor = Cursors.Hand
        BtnBatalkanPinjaman.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnBatalkanPinjaman.FlatAppearance.BorderSize = 0
        BtnBatalkanPinjaman.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBatalkanPinjaman.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnBatalkanPinjaman.FlatStyle = FlatStyle.Flat
        BtnBatalkanPinjaman.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBatalkanPinjaman.ForeColor = SystemColors.ControlLightLight
        BtnBatalkanPinjaman.Location = New Point(441, 448)
        BtnBatalkanPinjaman.Name = "BtnBatalkanPinjaman"
        BtnBatalkanPinjaman.Size = New Size(287, 39)
        BtnBatalkanPinjaman.TabIndex = 44
        BtnBatalkanPinjaman.Text = "Batalkan Pinjaman"
        BtnBatalkanPinjaman.UseVisualStyleBackColor = False
        ' 
        ' BtnBatalkanPerubahan
        ' 
        BtnBatalkanPerubahan.BackColor = Color.Brown
        BtnBatalkanPerubahan.Cursor = Cursors.Hand
        BtnBatalkanPerubahan.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnBatalkanPerubahan.FlatAppearance.BorderSize = 0
        BtnBatalkanPerubahan.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBatalkanPerubahan.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnBatalkanPerubahan.FlatStyle = FlatStyle.Flat
        BtnBatalkanPerubahan.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBatalkanPerubahan.ForeColor = SystemColors.ControlLightLight
        BtnBatalkanPerubahan.Location = New Point(441, 394)
        BtnBatalkanPerubahan.Name = "BtnBatalkanPerubahan"
        BtnBatalkanPerubahan.Size = New Size(287, 39)
        BtnBatalkanPerubahan.TabIndex = 45
        BtnBatalkanPerubahan.Text = "Batalkan Perubahan"
        BtnBatalkanPerubahan.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Swis721 Hv BT", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.SaddleBrown
        Label11.Location = New Point(231, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(301, 39)
        Label11.TabIndex = 46
        Label11.Text = "Riwayat Pinjaman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(37, 342)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 22)
        Label1.TabIndex = 47
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(73, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 22)
        Label2.TabIndex = 48
        Label2.Text = ":"
        ' 
        ' LbID2
        ' 
        LbID2.AutoSize = True
        LbID2.BackColor = Color.Transparent
        LbID2.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbID2.ForeColor = Color.SaddleBrown
        LbID2.Location = New Point(107, 379)
        LbID2.Name = "LbID2"
        LbID2.Size = New Size(0, 22)
        LbID2.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(6, 517)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 35)
        Label3.TabIndex = 50
        Label3.Text = "SihCepat"
        ' 
        ' Riwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__20_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(Label3)
        Controls.Add(LbID2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label11)
        Controls.Add(BtnBatalkanPerubahan)
        Controls.Add(BtnBatalkanPinjaman)
        Controls.Add(BtnAjukan)
        Controls.Add(cbCicilan)
        Controls.Add(Label9)
        Controls.Add(txtNominal)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Controls.Add(BtnKembali)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Riwayat"
        Text = "Riwayat"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbCicilan As ComboBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents BtnBatalkanPinjaman As Button
    Friend WithEvents BtnBatalkanPerubahan As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbID2 As Label
    Friend WithEvents Label3 As Label
End Class
