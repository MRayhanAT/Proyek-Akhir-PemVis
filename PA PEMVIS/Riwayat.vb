Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Riwayat
    Private Sub Riwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanRiwayat()
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        TampilkanRiwayat()
    End Sub

    Sub TampilkanRiwayat()
        Try
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.ReadOnly = False
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridView1.Columns.Add("idPinjaman", "idPinjaman")
            DataGridView1.Columns("idPinjaman").Width = 10

            DataGridView1.Columns.Add("Nominal", "Nominal")
            DataGridView1.Columns("Nominal").Width = 75

            DataGridView1.Columns.Add("cicilan", "cicilan")
            DataGridView1.Columns("cicilan").Width = 150

            DataGridView1.Columns.Add("tanggalACCEPT", "tanggalACCEPT")
            DataGridView1.Columns("tanggalACCEPT").Width = 150

            DataGridView1.Columns.Add("adminACCEPT", "adminACCEPT")
            DataGridView1.Columns("adminACCEPT").Width = 150

            DataGridView1.Columns.Add("status", "status")
            DataGridView1.Columns("status").Width = 150

            Module1.koneksi()
            Dim query As String = "SELECT * FROM Pinjaman"
            Dim cmd As New MySqlCommand(query, Module1.CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim ID_Pinjaman As String = reader("idPinjaman").ToString()
                Dim Nominal As String = reader("Nominal").ToString()
                Dim cicilan As String = reader("cicilan").ToString()
                Dim tanggalACCEPT As String = reader("tanggalACCEPT").ToString()
                Dim adminACCEPT As String = reader("adminACCEPT").ToString()
                Dim status As String = reader("status").ToString()

                Dim index As Integer = DataGridView1.Rows.Add(ID_Pinjaman, Nominal, cicilan, tanggalACCEPT, adminACCEPT, status)

            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub


    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        HomeUser.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            lbID2.Text = selectedRow.Cells("idPinjaman").Value.ToString()
            txtNominal.Text = selectedRow.Cells("Nominal").Value.ToString()
            cbCicilan.Text = selectedRow.Cells("cicilan").Value.ToString()
        End If
    End Sub

    Private Sub BtnAjukan_Click(sender As Object, e As EventArgs) Handles BtnAjukan.Click
        Try
            Module1.koneksi()

            Dim query As String = "UPDATE Pinjaman SET Nominal = @nominal, cicilan = @cicilan WHERE idPinjaman = @id"
            Dim cmd As New MySqlCommand(query, Module1.CONN)
            cmd.Parameters.AddWithValue("@id", lbID2.Text)
            cmd.Parameters.AddWithValue("@nominal", txtNominal.Text)
            cmd.Parameters.AddWithValue("@cicilan", cbCicilan.Text)


            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Data berhasil diupdate!")
            Else
                MessageBox.Show("Update gagal. ID tidak ditemukan.")
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat update: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbID2.Text = ""
        txtNominal.Clear()
        cbCicilan.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim idPinjaman As String = selectedRow.Cells("idPinjaman").Value.ToString()
            Dim adminAccept As String = selectedRow.Cells("adminACCEPT").Value.ToString()
            If String.IsNullOrWhiteSpace(adminAccept) Then
                Dim confirmResult As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
                If confirmResult = DialogResult.Yes Then
                    Try
                        Module1.koneksi()
                        Dim query As String = "DELETE FROM Pinjaman WHERE idPinjaman = @id"
                        Dim cmd As New MySqlCommand(query, Module1.CONN)
                        cmd.Parameters.AddWithValue("@id", idPinjaman)

                        Dim result As Integer = cmd.ExecuteNonQuery()
                        If result > 0 Then
                            MessageBox.Show("Data berhasil dihapus.")
                            TampilkanRiwayat()
                        Else
                            MessageBox.Show("Data gagal dihapus.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Terjadi kesalahan saat menghapus: " & ex.Message)
                    Finally
                        If Module1.CONN.State = ConnectionState.Open Then
                            Module1.CONN.Close()
                        End If
                    End Try
                End If
            Else
                MessageBox.Show("Data tidak dapat dihapus karena sudah diverifikasi oleh admin.")
            End If
        Else
            MessageBox.Show("Pilih satu baris yang ingin dihapus.")
        End If
    End Sub
End Class
