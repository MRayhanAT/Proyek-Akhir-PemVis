Imports MySql.Data.MySqlClient

Public Class DaftarAkun
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Try

            koneksi()


            Dim cekQuery As String = "SELECT COUNT(*) FROM tbUsers WHERE NomorHP = @no"
            Dim cekCmd As New MySqlCommand(cekQuery, conn)
            cekCmd.Parameters.AddWithValue("@no", Textbox3.Text)
            Dim jumlah As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

            If jumlah > 0 Then
                MessageBox.Show("Nomor sudah digunakan. Gunakan Nomor lain.")
            Else

                'Dim insertQuery As String = "INSERT INTO tbUsers (username, nomorHP,KTP, password) VALUES (@uname, @no, @ktp, @pw)"
                Dim insertQuery As String = "INSERT INTO tbusers (username, NomorHP, password) VALUES (@uname, @no, @pw)"

                Dim insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                insertCmd.Parameters.AddWithValue("@no", Textbox3.Text)
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
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If

        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FMenu.Show()
    End Sub
End Class
