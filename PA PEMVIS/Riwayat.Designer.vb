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
        txtAlamat = New TextBox()
        txtNomorHP = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        cbCicilan = New ComboBox()
        BtnAjukan = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label11 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnKembali.Location = New Point(9, 8)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 49)
        BtnKembali.TabIndex = 14
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(38, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(692, 283)
        DataGridView1.TabIndex = 15
        ' 
        ' txtNominal
        ' 
        txtNominal.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNominal.Location = New Point(203, 471)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(217, 27)
        txtNominal.TabIndex = 35
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(203, 440)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(217, 27)
        txtAlamat.TabIndex = 34
        ' 
        ' txtNomorHP
        ' 
        txtNomorHP.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNomorHP.Location = New Point(203, 409)
        txtNomorHP.Name = "txtNomorHP"
        txtNomorHP.Size = New Size(217, 27)
        txtNomorHP.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(38, 471)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 22)
        Label6.TabIndex = 32
        Label6.Text = "Nominal Pinjaman"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(38, 440)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 22)
        Label5.TabIndex = 31
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(38, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 22)
        Label4.TabIndex = 30
        Label4.Text = "Nomor HP"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(203, 378)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(217, 27)
        txtNama.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(38, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 22)
        Label3.TabIndex = 28
        Label3.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(188, 472)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 22)
        Label1.TabIndex = 39
        Label1.Text = ":"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(188, 441)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 22)
        Label2.TabIndex = 38
        Label2.Text = ":"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SaddleBrown
        Label7.Location = New Point(188, 410)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 22)
        Label7.TabIndex = 37
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(188, 379)
        Label8.Name = "Label8"
        Label8.Size = New Size(15, 22)
        Label8.TabIndex = 36
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(38, 504)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 22)
        Label9.TabIndex = 40
        Label9.Text = "Cicilan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SaddleBrown
        Label10.Location = New Point(188, 505)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 22)
        Label10.TabIndex = 41
        Label10.Text = ":"
        ' 
        ' cbCicilan
        ' 
        cbCicilan.Font = New Font("Swis721 Cn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCicilan.FormattingEnabled = True
        cbCicilan.Items.AddRange(New Object() {"3 Bulan", "6 Bulan", "12 Bulan"})
        cbCicilan.Location = New Point(203, 505)
        cbCicilan.Name = "cbCicilan"
        cbCicilan.Size = New Size(217, 27)
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
        BtnAjukan.Location = New Point(443, 378)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(287, 44)
        BtnAjukan.TabIndex = 43
        BtnAjukan.Text = "Simpan Perubahan"
        BtnAjukan.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkRed
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.DarkGoldenrod
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(443, 488)
        Button1.Name = "Button1"
        Button1.Size = New Size(287, 44)
        Button1.TabIndex = 44
        Button1.Text = "Batalkan Pinjaman"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Brown
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.DarkGoldenrod
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(443, 433)
        Button2.Name = "Button2"
        Button2.Size = New Size(287, 44)
        Button2.TabIndex = 45
        Button2.Text = "Batalkan Perubahan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Swis721 Hv BT", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.SaddleBrown
        Label11.Location = New Point(231, 18)
        Label11.Name = "Label11"
        Label11.Size = New Size(301, 39)
        Label11.TabIndex = 46
        Label11.Text = "Riwayat Pinjaman"
        ' 
        ' Riwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__13_1
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BtnAjukan)
        Controls.Add(cbCicilan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(txtNominal)
        Controls.Add(txtAlamat)
        Controls.Add(txtNomorHP)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(BtnKembali)
        DoubleBuffered = True
        Name = "Riwayat"
        Text = "Riwayat"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNomorHP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCicilan As ComboBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
End Class
