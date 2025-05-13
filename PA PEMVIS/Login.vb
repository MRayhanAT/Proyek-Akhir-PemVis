Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            BukaKoneksi()

            Dim query As String = "SELECT * FROM peminjam WHERE username = @uname AND password = @pw"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uname", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pw", txtPassword.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim namaUser As String = reader("username")

                MessageBox.Show("Login berhasil! Selamat datang, " & namaUser)
                Me.Hide()
                HomeUser.Show()

            Else
                MessageBox.Show("Login gagal. Username atau password salah.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FMenu.Show()
    End Sub
End Class
