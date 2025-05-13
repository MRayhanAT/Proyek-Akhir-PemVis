Imports MySql.Data.MySqlClient
Imports System.Text

Public Class DaftarPeminjaman

    Private Sub DaftarPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        TampilkanData_peminjaman()
    End Sub

    Sub TampilkanData_peminjaman()
        Try
            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = Nothing

            Module1.koneksi()
            Dim query As String = "SELECT * FROM Pinjaman"
            Dim cmd As New MySqlCommand(query, Module1.CONN)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt

            If DataGridView1.Columns.Contains("Status") Then
                DataGridView1.Columns.Remove("Status")
            End If

            Dim statusColumn As New DataGridViewComboBoxColumn()
            statusColumn.Name = "Status"
            statusColumn.HeaderText = "Status"
            statusColumn.DataPropertyName = "Status"
            statusColumn.Items.AddRange("pending", "Pengajuan Diterima", "Pengajuan Ditolak")
            DataGridView1.Columns.Add(statusColumn)

            With DataGridView1
                .Columns("idPinjaman").HeaderText = "ID"
                .Columns("Nama").HeaderText = "Nama"
                .Columns("Alamat").HeaderText = "Alamat"
                .Columns("Nominal").HeaderText = "Nominal"
                .Columns("Cicilan").HeaderText = "Cicilan"
                .Columns("NomorHP_Pengguna").HeaderText = "Nomor HP"
                .Columns("Status").HeaderText = "Status"

                .Columns("idPinjaman").Width = 40
                .Columns("Nama").Width = 100
                .Columns("Alamat").Width = 100
                .Columns("Nominal").Width = 92
                .Columns("Cicilan").Width = 100
                .Columns("NomorHP_Pengguna").Width = 100
                .Columns("Status").Width = 140

                .DefaultCellStyle.ForeColor = Color.Black
                .Columns("idPinjaman").ReadOnly = True
            End With

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Status" Then
            Try
                Module1.koneksi()

                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim idPinjaman As Integer = Convert.ToInt32(row.Cells("idPinjaman").Value)
                Dim statusBaru As String = row.Cells("Status").Value.ToString()

                Dim query As String = "UPDATE Pinjaman SET Status = @status WHERE idPinjaman = @id"
                Dim cmd As New MySqlCommand(query, CONN)
                cmd.Parameters.AddWithValue("@status", statusBaru)
                cmd.Parameters.AddWithValue("@id", idPinjaman)
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Gagal mengupdate status: " & ex.Message)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If DataGridView1.IsCurrentCellDirty Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        HomeAdmin.Show()
        Me.Hide()
    End Sub

End Class
