Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PeriksaKosongFormLogin() Then
            Try
                If txtUsername.Text = "admin1" And txtPassword.Text = "admin1" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf txtUsername.Text = "admin2" And txtPassword.Text = "admin2" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf txtUsername.Text = "admin3" And txtPassword.Text = "admin3" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    HomeAdmin.Show()
                    KosongkanForm()
                Else
                    Module1.koneksi()

                    Module1.CMD = New MySqlCommand("SELECT username, NomorHP FROM tbUsers WHERE username = @UserName AND password = @pw", Module1.CONN)
                    Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
                    Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

                    Module1.RD = Module1.CMD.ExecuteReader()
                    If Module1.RD.Read() Then
                        GlobalVariables.Username = Module1.RD("username").ToString()
                        GlobalVariables.nomor_hp_user = Convert.ToInt64(Module1.RD("NomorHP"))

                        MessageBox.Show("Login berhasil! Selamat datang, " & GlobalVariables.Username)

                        Me.Hide()
                        HomeUser.Show()
                    Else
                        MessageBox.Show("Login gagal. Username atau password salah.")
                    End If

                    Module1.RD.Close()
                End If


            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message)
                ' Tambahkan logging kesalahan di sini jika diperlukan
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub KosongkanForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FMenu.Show()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        txtUsername.MaxLength = 50
        If (e.KeyChar = Chr(13)) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.MaxLength = 50
    End Sub

    Function PeriksaKosongFormLogin() As Boolean
        If txtUsername.Text = "" Then
            MessageBox.Show("username harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("password harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LihatPass_Click(sender As Object, e As EventArgs) Handles LihatPass.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul_13
        Else
            txtPassword.PasswordChar = "*"
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul_11
        End If
    End Sub
End Class
