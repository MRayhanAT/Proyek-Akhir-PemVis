Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PeriksaKosongFormLogin() Then
            Try
                If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    HomeAdmin.Show()
                End If

                Module1.koneksi()

                Module1.CMD = New MySqlCommand("SELECT username FROM tbUsers WHERE username = @UserName AND password = @pw", Module1.CONN)
                Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
                Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

                Module1.RD = Module1.CMD.ExecuteReader()
                If Module1.RD.Read() Then
                    Dim namaUser As String = Module1.RD("username")
                    MessageBox.Show("Login berhasil! Selamat datang, " & namaUser)
                    End 'ganti ke menu user biasa
                Else
                    MessageBox.Show("Login gagal. Username atau password salah.")
                End If
                Module1.RD.Close()

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

    Private Sub LihatPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LihatPassword.LinkClicked
        Dim lihat As Boolean
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            lihat = True
        Else
            txtPassword.PasswordChar = "*"
            lihat = False
        End If
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
End Class