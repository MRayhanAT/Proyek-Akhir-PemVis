Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Module1.koneksi()

            Module1.CMD = New MySqlCommand("SELECT username FROM tbUsers WHERE username = @UserName AND password = @pw", Module1.CONN)
            Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
            Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

            Module1.RD = Module1.CMD.ExecuteReader()
            If Module1.RD.HasRows Then
                Dim namaUser As String = Module1.RD("username")
                MessageBox.Show("Login berhasil! Selamat datang, " & namaUser)
                End
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FMenu.Show()
    End Sub
End Class