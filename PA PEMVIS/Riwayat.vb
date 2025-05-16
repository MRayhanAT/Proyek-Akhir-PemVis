Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Riwayat
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub Riwayat_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Riwayat_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Riwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        TampilkanRiwayat()
    End Sub

    Sub TampilkanRiwayat()
        Try
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridView1.Columns.Add("ID", "ID")
            DataGridView1.Columns("ID").Width = 50

            DataGridView1.Columns.Add("JumlahPinjaman", "Jumlah Pinjaman")
            DataGridView1.Columns("JumlahPinjaman").Width = 120

            DataGridView1.Columns.Add("Cicilan", "Cicilan")
            DataGridView1.Columns("Cicilan").Width = 100

            DataGridView1.Columns.Add("TanggalDiterima", "Tanggal Diterima")
            DataGridView1.Columns("TanggalDiterima").Width = 130

            DataGridView1.Columns.Add("AdminVerifikator", "Admin Verifikator")
            DataGridView1.Columns("AdminVerifikator").Width = 130

            DataGridView1.Columns.Add("Status", "Status")
            DataGridView1.Columns("Status").Width = 100

            Module1.koneksi()
            Dim sql As String =
                "SELECT idPinjaman, Nominal, cicilan, tanggalACCEPT, adminACCEPT, status " &
                "FROM Pinjaman " &
                "WHERE NomorHP_Pengguna = @hp"
            Dim cmd As New MySqlCommand(sql, Module1.CONN)
            cmd.Parameters.AddWithValue("@hp", GlobalVariables.nomor_hp_user)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim idx As Integer
            While reader.Read()
                idx = DataGridView1.Rows.Add()
                With DataGridView1.Rows(idx)
                    .Cells("ID").Value = reader("idPinjaman").ToString()
                    .Cells("JumlahPinjaman").Value = reader("Nominal").ToString()
                    .Cells("Cicilan").Value = reader("cicilan").ToString()
                    .Cells("TanggalDiterima").Value = reader("tanggalACCEPT").ToString()
                    .Cells("AdminVerifikator").Value = reader("adminACCEPT").ToString()
                    .Cells("Status").Value = reader("status").ToString()

                    If Not reader("status").ToString().ToLower().Equals("pending") Then
                        .ReadOnly = True
                        .DefaultCellStyle.BackColor = Color.LightGray
                    End If
                End With
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim stat As String = row.Cells("Status").Value.ToString().ToLower()

        If stat = "pending" Then
            LbID2.Text = row.Cells("ID").Value.ToString()
            txtNominal.Text = row.Cells("JumlahPinjaman").Value.ToString()
            cbCicilan.Text = row.Cells("Cicilan").Value.ToString()
        Else
            LbID2.Text = ""
            txtNominal.Clear()
            cbCicilan.Text = ""
        End If
    End Sub

    Private Sub BtnAjukan_Click(sender As Object, e As EventArgs) Handles BtnAjukan.Click
        If String.IsNullOrWhiteSpace(LbID2.Text) Then
            MessageBox.Show("Pilih entri yang berstatus pending untuk diedit.")
            Return
        End If

        Try
            Module1.koneksi()
            Dim q As String =
                "UPDATE Pinjaman " &
                "SET Nominal = @nom, cicilan = @cic " &
                "WHERE idPinjaman = @id"
            Dim c As New MySqlCommand(q, Module1.CONN)
            c.Parameters.AddWithValue("@id", LbID2.Text)
            c.Parameters.AddWithValue("@nom", txtNominal.Text)
            c.Parameters.AddWithValue("@cic", cbCicilan.Text)
            If c.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil diperbarui!")
            Else
                MessageBox.Show("Update gagal, ID tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat update: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try

        TampilkanRiwayat()
    End Sub

    Private Sub BtnBatalkanPerubahan_Click(sender As Object, e As EventArgs) Handles BtnBatalkanPerubahan.Click
        LbID2.Text = ""
        txtNominal.Clear()
        cbCicilan.Text = ""
    End Sub

    Private Sub BtnBatalkanPinjaman_Click(sender As Object, e As EventArgs) Handles BtnBatalkanPinjaman.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris terlebih dahulu.")
            Return
        End If

        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        If row.Cells("Status").Value.ToString().ToLower() <> "pending" Then
            MessageBox.Show("Hanya pinjaman berstatus pending yang bisa dibatalkan.")
            Return
        End If

        If MessageBox.Show("Yakin ingin membatalkan pinjaman ini?", "Konfirmasi", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Return
        End If

        Try
            Module1.koneksi()
            Dim q As String = "DELETE FROM Pinjaman WHERE idPinjaman = @id"
            Dim c As New MySqlCommand(q, Module1.CONN)
            c.Parameters.AddWithValue("@id", row.Cells("ID").Value)
            If c.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Pinjaman berhasil dibatalkan.")
            Else
                MessageBox.Show("Gagal membatalkan pinjaman.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat delete: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then Module1.CONN.Close()
        End Try

        TampilkanRiwayat()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        HomeUser.Show()
        Me.Hide()
    End Sub

End Class
