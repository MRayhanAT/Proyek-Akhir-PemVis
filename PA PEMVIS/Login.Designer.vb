<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Button1 = New Button()
        BtnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(719, 609)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 42)
        Label1.TabIndex = 14
        Label1.Text = "SihCepat"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(11, 8)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(56, 58)
        Button1.TabIndex = 13
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.DarkGoldenrod
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(375, 398)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(366, 47)
        BtnLogin.TabIndex = 17
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(375, 249)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(365, 37)
        txtUsername.TabIndex = 16
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(375, 335)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(365, 37)
        txtPassword.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(375, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 29)
        Label2.TabIndex = 18
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(375, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 29)
        Label3.TabIndex = 19
        Label3.Text = "Password"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(872, 659)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnLogin)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(Button1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
