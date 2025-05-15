<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BtnDaftar = New Button()
        BtnLogin = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(8, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 42)
        Label1.TabIndex = 0
        Label1.Text = "SihCepat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(214, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 69)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(41, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(330, 91)
        Label3.TabIndex = 2
        Label3.Text = "Selamat"
        ' 
        ' BtnDaftar
        ' 
        BtnDaftar.BackColor = Color.White
        BtnDaftar.Cursor = Cursors.Hand
        BtnDaftar.FlatAppearance.BorderColor = Color.DarkGoldenrod
        BtnDaftar.FlatAppearance.BorderSize = 0
        BtnDaftar.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnDaftar.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnDaftar.FlatStyle = FlatStyle.Flat
        BtnDaftar.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDaftar.ForeColor = Color.DarkGoldenrod
        BtnDaftar.Location = New Point(486, 199)
        BtnDaftar.Margin = New Padding(3, 4, 3, 4)
        BtnDaftar.Name = "BtnDaftar"
        BtnDaftar.Size = New Size(229, 65)
        BtnDaftar.TabIndex = 5
        BtnDaftar.Text = "Daftar"
        BtnDaftar.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.White
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.LemonChiffon
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnLogin.FlatAppearance.MouseOverBackColor = Color.Cornsilk
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.DarkGoldenrod
        BtnLogin.Location = New Point(486, 293)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(229, 65)
        BtnLogin.TabIndex = 6
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(41, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(317, 91)
        Label4.TabIndex = 7
        Label4.Text = "Datang!"
        ' 
        ' FMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Solusi_Keuangan_Cepat_dan_Aman__3_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(Label4)
        Controls.Add(BtnLogin)
        Controls.Add(BtnDaftar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "FMenu"
        Text = "Fmenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label4 As Label

End Class
