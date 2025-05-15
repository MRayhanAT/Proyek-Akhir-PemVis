Imports MySql.Data.MySqlClient

Public Class AjukanPijaman
    Private Sub Pengajuan_Pinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNama_pengajuan.Text = GlobalVariables.Username
        lbNomor.Text = GlobalVariables.nomor_hp_user.ToString()

    End Sub

    Private Sub btnAjukan_Click(sender As Object, e As EventArgs) Handles BtnAjukan.Click
        Try

            Module1.koneksi()
            Dim Cicilan As String = ""

            For Each ctrl As Control In gbCicilan.Controls
                If TypeOf ctrl Is RadioButton Then
                    Dim rb As RadioButton = CType(ctrl, RadioButton)
                    If rb.Checked Then
                        Cicilan = rb.Text
                        Exit For
                    End If
                End If
            Next

            Dim insertQuery As String = "INSERT INTO pinjaman (Nama, Alamat, Nominal, cicilan, NomorHP_Pengguna) VALUES (@unamep, @al, @nom, @ci, @nop)"

            Dim insertCmd As New MySqlCommand(insertQuery, Module1.CONN)
            insertCmd.Parameters.AddWithValue("@unamep", GlobalVariables.Username)
            insertCmd.Parameters.AddWithValue("@al", txtAlamat.Text)
            insertCmd.Parameters.AddWithValue("@nom", txtNominal.Text)
            insertCmd.Parameters.AddWithValue("@ci", Cicilan)
            insertCmd.Parameters.AddWithValue("@nop", GlobalVariables.nomor_hp_user)

            Dim result As Integer = insertCmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Pengajuan Berhasil, Mohon Ditunggu.")
                Me.Hide()
                HomeUser.Show()
            Else
                MessageBox.Show("Pengajuan Gagal gagal.")
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Hide()
        HomeUser.Show()
    End Sub

End Class
