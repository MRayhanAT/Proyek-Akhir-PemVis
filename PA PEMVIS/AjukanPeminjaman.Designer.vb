<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjukanPijaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjukanPijaman))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        BtnAjukan = New Button()
        BtnBatal = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(634, 515)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 35)
        Label1.TabIndex = 1
        Label1.Text = "SihCepat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Swis721 Hv BT", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(202, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(360, 39)
        Label2.TabIndex = 2
        Label2.Text = "Formulir Peminjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(104, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 29)
        Label3.TabIndex = 19
        Label3.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(314, 150)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(342, 25)
        txtNama.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(104, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 29)
        Label4.TabIndex = 22
        Label4.Text = "Nomor HP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(104, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 29)
        Label5.TabIndex = 23
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(104, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(189, 29)
        Label6.TabIndex = 24
        Label6.Text = "Nominal Pinjaman"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(314, 189)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(342, 25)
        TextBox1.TabIndex = 25
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(314, 231)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(342, 25)
        TextBox2.TabIndex = 26
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(314, 274)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(342, 25)
        TextBox3.TabIndex = 27
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Swis721 Cn BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.SaddleBrown
        GroupBox1.Location = New Point(314, 324)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(342, 150)
        GroupBox1.TabIndex = 28
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cicilan"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(15, 105)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(104, 29)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "12 Bulan"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(15, 70)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(93, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "6 Bulan"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(15, 35)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(93, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "3 Bulan"
        CheckBox1.UseVisualStyleBackColor = True
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
        BtnAjukan.Location = New Point(104, 324)
        BtnAjukan.Name = "BtnAjukan"
        BtnAjukan.Size = New Size(189, 68)
        BtnAjukan.TabIndex = 29
        BtnAjukan.Text = "Ajukan"
        BtnAjukan.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.Red
        BtnBatal.Cursor = Cursors.Hand
        BtnBatal.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBatal.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBatal.ForeColor = SystemColors.ControlLightLight
        BtnBatal.Location = New Point(104, 406)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(189, 68)
        BtnBatal.TabIndex = 30
        BtnBatal.Text = "Batalkan"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SaddleBrown
        Label7.Location = New Point(288, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 29)
        Label7.TabIndex = 31
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(288, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(20, 29)
        Label8.TabIndex = 32
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(288, 225)
        Label9.Name = "Label9"
        Label9.Size = New Size(20, 29)
        Label9.TabIndex = 33
        Label9.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Swis721 Cn BT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SaddleBrown
        Label10.Location = New Point(288, 268)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 29)
        Label10.TabIndex = 34
        Label10.Text = ":"
        ' 
        ' AjukanPijaman
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(BtnBatal)
        Controls.Add(BtnAjukan)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "AjukanPijaman"
        Text = "AjukanPeminjaman"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BtnAjukan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
