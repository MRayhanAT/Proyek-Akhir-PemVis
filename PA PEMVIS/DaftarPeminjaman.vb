Imports MySql.Data.MySqlClient
Imports System.CodeDom
Imports System.Text

Public Class DaftarPeminjaman
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form_input_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form_input_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = DaftarPeminjaman.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

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

            Dim statusCombo As New DataGridViewComboBoxColumn()
            With statusCombo
                .Name = "Status"
                .HeaderText = "Status"
                .DataPropertyName = "Status"
                .Items.AddRange("pending", "Diterima", "Ditolak")
                .DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                .FlatStyle = FlatStyle.Flat
            End With
            DataGridView1.Columns.Add(statusCombo)

            With DataGridView1
                .Columns("idPinjaman").HeaderText = "ID"
                .Columns("Nama").HeaderText = "Nama"
                .Columns("Alamat").HeaderText = "Alamat"
                .Columns("Nominal").HeaderText = "Nominal"
                .Columns("Cicilan").HeaderText = "Cicilan"
                .Columns("NomorHP_Pengguna").HeaderText = "Nomor HP"
                .Columns("Status").HeaderText = "Status Peminjaman"
                .Columns("tanggalACCEPT").HeaderText = "Terakhir Diupdate"
                .Columns("idPinjaman").Width = 70
                .Columns("tanggalACCEPT").Width = 150
                .Columns("tanggalACCEPT").DefaultCellStyle.Format = "dd/MM/yyyy"
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
                Dim tanggalUpdate As DateTime = DateTime.Now

                Dim query As String = "UPDATE Pinjaman SET Status = @status, tanggalACCEPT = @tanggal WHERE idPinjaman = @id"
                Dim cmd As New MySqlCommand(query, Module1.CONN)
                cmd.Parameters.AddWithValue("@status", statusBaru)
                cmd.Parameters.AddWithValue("@tanggal", tanggalUpdate)
                cmd.Parameters.AddWithValue("@id", idPinjaman)
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Gagal mengupdate status: " & ex.Message)
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
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
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()

            If status = "Diterima" Then
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            ElseIf status = "Ditolak" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.Black
            ElseIf status = "pending" Then
                e.CellStyle.BackColor = Color.LightYellow
                e.CellStyle.ForeColor = Color.Black
            End If
        End If
        e.CellStyle.ForeColor = Color.Black
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is ComboBox AndAlso DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Status").Index Then
            Dim cmb As ComboBox = DirectCast(e.Control, ComboBox)
            RemoveHandler cmb.DrawItem, AddressOf ComboBox_DrawItem
            AddHandler cmb.DrawItem, AddressOf ComboBox_DrawItem
            cmb.DrawMode = DrawMode.OwnerDrawFixed
        End If
    End Sub

    Private Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Return

        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        Dim text As String = cmb.Items(e.Index).ToString().ToLower()

        Dim backColor As Color = Color.White
        Dim foreColor As Color = Color.Black

        Select Case text
            Case "pengajuan diterima"
                backColor = Color.LightGreen
            Case "pengajuan ditolak"
                backColor = Color.LightCoral
            Case "pending"
                backColor = Color.LightYellow
        End Select

        e.Graphics.FillRectangle(New SolidBrush(backColor), e.Bounds)
        TextRenderer.DrawText(e.Graphics, cmb.Items(e.Index).ToString(), cmb.Font, e.Bounds, foreColor)
        e.DrawFocusRectangle()
    End Sub

    Private Sub FormDaftarPinjaman_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TampilkanData_peminjaman()
    End Sub

End Class
