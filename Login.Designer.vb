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
        Label1 = New Label()
        Label2 = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        Login1 = New Button()
        TxtLihat = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(120, 40)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(180, 27)
        TxtUsername.TabIndex = 2
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(121, 80)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(180, 27)
        TxtPassword.TabIndex = 3
        ' 
        ' Login1
        ' 
        Login1.Location = New Point(120, 130)
        Login1.Name = "Login1"
        Login1.Size = New Size(100, 29)
        Login1.TabIndex = 4
        Login1.Text = "Login"
        Login1.UseVisualStyleBackColor = True
        ' 
        ' TxtLihat
        ' 
        TxtLihat.AutoSize = True
        TxtLihat.BackColor = Color.White
        TxtLihat.DisabledLinkColor = Color.Silver
        TxtLihat.LinkColor = Color.Black
        TxtLihat.Location = New Point(259, 83)
        TxtLihat.Name = "TxtLihat"
        TxtLihat.Size = New Size(41, 20)
        TxtLihat.TabIndex = 5
        TxtLihat.TabStop = True
        TxtLihat.Text = "Lihat"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 203)
        Controls.Add(TxtLihat)
        Controls.Add(Login1)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Login1 As Button
    Friend WithEvents TxtLihat As LinkLabel
End Class
