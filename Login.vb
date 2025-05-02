Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        TxtPassword.PasswordChar = "*"
        TxtUsername.MaxLength = 20
        TxtPassword.MaxLength = 20
    End Sub

    Function PeriksaKosong()
        If TxtUsername.Text = "" Then
            MsgBox("Username tidak boleh kosong", MsgBoxStyle.Critical, "Peringatan")
            TxtUsername.Focus()
            Return False
        ElseIf TxtPassword.Text = "" Then
            MsgBox("Password tidak boleh kosong", MsgBoxStyle.Critical, "Peringatan")
            TxtPassword.Focus()
            Return False
        End If
        Return True
    End Function



    Private Sub TxtLihat_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TxtLihat.LinkClicked
        If Not LihatPassword Then
            TxtPassword.PasswordChar = ""
            LihatPassword = True
        Else
            TxtPassword.PasswordChar = "*"
            LihatPassword = False
        End If
    End Sub

    Function PeriksaLogin()
        koneksi()
        Form1.CekDataReader()
        CMD = New MySqlCommand("SELECT * FROM login WHERE username = @username AND password = @password", CONN)
        CMD.Parameters.AddWithValue("@username", TxtUsername.Text)
        CMD.Parameters.AddWithValue("@password", TxtPassword.Text)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Return True
        Else
            MsgBox("Username atau Password salah", MsgBoxStyle.Critical, "Peringatan")
            Return False
        End If
    End Function

    Private Sub Login1_Click(sender As Object, e As EventArgs) Handles Login1.Click
        PeriksaKosong()
        If PeriksaKosong() Then
            If PeriksaLogin() Then
                MenuAwal.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class