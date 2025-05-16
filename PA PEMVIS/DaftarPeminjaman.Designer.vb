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
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        BtnCetak = New Button()
        PrintDialog1 = New PrintDialog()
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
        BtnKembali.Location = New Point(8, 7)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(49, 49)
        BtnKembali.TabIndex = 17
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 Hv BT", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(212, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 39)
        Label1.TabIndex = 16
        Label1.Text = "Daftar Peminjaman"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.OldLace
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 74)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(715, 308)
        DataGridView1.TabIndex = 18
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' BtnCetak
        ' 
        BtnCetak.BackColor = Color.SaddleBrown
        BtnCetak.Cursor = Cursors.Hand
        BtnCetak.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnCetak.FlatAppearance.BorderSize = 0
        BtnCetak.FlatAppearance.MouseDownBackColor = Color.Firebrick
        BtnCetak.FlatAppearance.MouseOverBackColor = Color.Firebrick
        BtnCetak.FlatStyle = FlatStyle.Flat
        BtnCetak.Font = New Font("Swis721 Cn BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCetak.ForeColor = SystemColors.ControlLightLight
        BtnCetak.Location = New Point(596, 399)
        BtnCetak.Name = "BtnCetak"
        BtnCetak.Size = New Size(142, 43)
        BtnCetak.TabIndex = 31
        BtnCetak.Text = "Cetak"
        BtnCetak.UseVisualStyleBackColor = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' DaftarPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(763, 560)
        Controls.Add(BtnCetak)
        Controls.Add(DataGridView1)
        Controls.Add(BtnKembali)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.SaddleBrown
        FormBorderStyle = FormBorderStyle.None
        Name = "DaftarPeminjaman"
        Text = "DaftarPeminjaman"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents BtnCetak As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
