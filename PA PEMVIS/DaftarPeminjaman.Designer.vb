<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarPeminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarPeminjaman))
        BtnKembali = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
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
        BtnKembali.Margin = New Padding(3, 4, 3, 4)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(56, 58)
        BtnKembali.TabIndex = 17
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(242, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(361, 46)
        Label1.TabIndex = 16
        Label1.Text = "Daftar Peminjaman"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.OldLace
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(26, 87)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(817, 362)
        DataGridView1.TabIndex = 18
        ' 
        ' DaftarPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(DataGridView1)
        Controls.Add(BtnKembali)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.SaddleBrown
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "DaftarPeminjaman"
        Text = "DaftarPeminjaman"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
