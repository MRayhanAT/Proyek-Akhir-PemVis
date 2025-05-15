<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        BtnKembali = New Button()
        DataGridView1 = New DataGridView()
        txtNominal = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        cbCicilan = New ComboBox()
        BtnAjukan = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label11 = New Label()
        Label2 = New Label()
        txtID = New TextBox()
        lbID = New Label()
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
        BtnKembali.Location = New Point(9, 7)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 43)
        BtnKembali.TabIndex = 14
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(38, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(692, 250)
        DataGridView1.TabIndex = 15
        ' 
        ' txtNominal
        ' 
        txtNominal.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNominal.Location = New Point(203, 362)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(217, 26)
        txtNominal.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(38, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(179, 24)
        Label6.TabIndex = 32
        Label6.Text = "Nominal Pinjaman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(188, 362)
        Label1.Name = "Label1"
        Label1.Size = New Size(16, 24)
        Label1.TabIndex = 39
        Label1.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(38, 391)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 24)
        Label9.TabIndex = 40
        Label9.Text = "Cicilan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SaddleBrown
        Label10.Location = New Point(188, 392)
        Label10.Name = "Label10"
        Label10.Size = New Size(16, 24)
        Label10.TabIndex = 41
        Label10.Text = ":"
        ' 
        ' cbCicilan
        ' 
        cbCicilan.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCicilan.FormattingEnabled = True
        cbCicilan.Items.AddRange(New Object() {"3 Bulan", "6 Bulan", "12 Bulan"})
        cbCicilan.Location = New Point(203, 392)
        cbCicilan.Name = "cbCicilan"
        cbCicilan.Size = New Size(217, 28)
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
        BtnAjukan.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAjukan.ForeColor = SystemColors.ControlLightLight
        BtnAjukan.Location = New Point(443, 334)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(287, 39)
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
        Button1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(443, 431)
        Button1.Name = "Button1"
        Button1.Size = New Size(287, 39)
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
        Button2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(443, 382)
        Button2.Name = "Button2"
        Button2.Size = New Size(287, 39)
        Button2.TabIndex = 45
        Button2.Text = "Batalkan Perubahan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.SaddleBrown
        Label11.Location = New Point(231, 16)
        Label11.Name = "Label11"
        Label11.Size = New Size(272, 37)
        Label11.TabIndex = 46
        Label11.Text = "Riwayat Pinjaman"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(188, 334)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 24)
        Label2.TabIndex = 49
        Label2.Text = ":"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(203, 334)
        txtID.Name = "txtID"
        txtID.Size = New Size(217, 26)
        txtID.TabIndex = 48
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.BackColor = Color.Transparent
        lbID.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbID.ForeColor = Color.SaddleBrown
        lbID.Location = New Point(38, 334)
        lbID.Name = "lbID"
        lbID.Size = New Size(29, 24)
        lbID.TabIndex = 47
        lbID.Text = "ID"
        ' 
        ' Riwayat
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__13_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(763, 494)
        Controls.Add(Label2)
        Controls.Add(txtID)
        Controls.Add(lbID)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BtnAjukan)
        Controls.Add(cbCicilan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(txtNominal)
        Controls.Add(Label6)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCicilan As ComboBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbID As Label
End Class
