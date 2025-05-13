Imports MySql.Data.MySqlClient

Public Class DaftarAkun

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtNoHP_TextChanged(sender As Object, e As EventArgs) Handles txtNoHP.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Try

            BukaKoneksi()


            Dim cekQuery As String = "SELECT COUNT(*) FROM peminjam WHERE no_hp = @no"
            Dim cekCmd As New MySqlCommand(cekQuery, conn)
            cekCmd.Parameters.AddWithValue("@no", txtNoHP.Text)
            Dim jumlah As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

            If jumlah > 0 Then
                MessageBox.Show("Nomor sudah digunakan. Gunakan Nomor lain.")
            Else

                Dim insertQuery As String = "INSERT INTO akun (nama_akun, no_hp, path_ktp, password) VALUES (@uname, @no, @ktp, @pw)"
                'Dim insertQuery As String = "INSERT INTO peminjam (username, no_hp, password) VALUES (@uname, @no, @pw)"

                Dim insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                insertCmd.Parameters.AddWithValue("@no", txtNoHP.Text)
                'insertCmd.Parameters.AddWithValue("@ktp", PictureBox1.Text)
                insertCmd.Parameters.AddWithValue("@pw", txtPassword.Text)



                Dim result As Integer = insertCmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Registrasi berhasil! Silakan login.")
                    Me.Hide()
                    HomeUser.Show()
                Else
                    MessageBox.Show("Registrasi gagal.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            TutupKoneksi()

        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FMenu.Show()
    End Sub
End Class
