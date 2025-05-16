Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DaftarAkun

    Private Sub DaftarAkun_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        txtUsername.Text = " Masukkan Username"
        txtPassword.Text = "Masukkan Password"
        TextBox3.Text = " Masukkan Nomor HP"
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        If Not PeriksaKosong() Then
            MessageBox.Show("inputan harus valid", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try

                Module1.koneksi()

                Dim cekQuery As String = "SELECT COUNT(*) FROM tbUsers WHERE NomorHP = @no"
                Dim cekCmd As New MySqlCommand(cekQuery, Module1.CONN)
                cekCmd.Parameters.AddWithValue("@no", TextBox3.Text)
                Dim jumlah As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

                If jumlah > 0 Then
                    MessageBox.Show("Nomor sudah digunakan. Gunakan Nomor lain.")
                Else

                    Dim insertQuery As String = "INSERT INTO tbUsers (username, nomorHP,KTP, password) VALUES (@uname, @no, @ktp, @pw)"

                    Dim insertCmd As New MySqlCommand(insertQuery, Module1.CONN)
                    insertCmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                    insertCmd.Parameters.AddWithValue("@no", TextBox3.Text)
                    insertCmd.Parameters.AddWithValue("@ktp", PictureBox1.ImageLocation)
                    insertCmd.Parameters.AddWithValue("@pw", txtPassword.Text)

                    Dim result As Integer = insertCmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Registrasi berhasil! Silakan login.")
                        Me.Hide()
                        FMenu.Show()
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
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FMenu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SimpanGambar.Filter = "PNG Image|*.png|JPG Image|*.jpg"
        If SimpanGambar.ShowDialog() = DialogResult.OK Then
            'PictureBox1.ImageLocation = SimpanGambar.FileName
            PictureBox1.BackgroundImage = Image.FromFile(SimpanGambar.FileName)
        End If
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.Text = " Masukkan Username" Then
            txtUsername.Text = ""
        End If
    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = " Masukkan Username"
        End If
    End Sub
    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = "Masukkan Password" Then
            txtPassword.Text = ""
        End If
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Masukkan Password"
        End If
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If TextBox3.Text = " Masukkan Nomor HP" Then
            TextBox3.Text = ""
        End If
    End Sub
    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = " Masukkan Nomor HP"
        End If
    End Sub

    Private Function PeriksaKosong()
        If txtPassword.Text = "" Or txtPassword.Text = "Masukkan Password" Then
            MessageBox.Show("Username harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtUsername.Text = "" Or txtUsername.Text = " Masukkan Username" Then
            MessageBox.Show("Password harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox3.Text = "" Or TextBox3.Text = " Masukkan Nomor HP" Then
            MessageBox.Show("No. HP harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function
End Class
