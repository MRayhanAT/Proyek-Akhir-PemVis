Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DaftarUser
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form_input_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form_input_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = DaftarUser.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub
    Private Sub DaftarUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        TampilkanData_User()
    End Sub

    Sub TampilkanData_User()
        Try
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.ReadOnly = False
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridView1.Columns.Add("NomorHP", "Nomor HP")
            DataGridView1.Columns("NomorHP").Width = 130

            DataGridView1.Columns.Add("Username", "Username")
            DataGridView1.Columns("Username").Width = 195

            DataGridView1.Columns.Add("KTP", "KTP")
            DataGridView1.Columns("KTP").Width = 220

            Dim comboCol As New DataGridViewComboBoxColumn()
            comboCol.HeaderText = "Status Pinjaman"
            comboCol.Name = "StatusPinjaman"
            comboCol.Width = 150
            comboCol.Items.AddRange("tidak ada pinjaman", "Masih Menunggak")
            comboCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            DataGridView1.Columns.Add(comboCol)

            Module1.koneksi()
            Dim query As String = "SELECT * FROM tbUsers"
            Dim cmd As New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim nomorHP As String = reader("NomorHP").ToString()
                Dim username As String = reader("username").ToString()
                Dim ktp As String = reader("KTP").ToString()
                Dim statusPinjaman As String = reader("statusPinjaman").ToString()

                Dim index As Integer = DataGridView1.Rows.Add(nomorHP, username, ktp)
                DataGridView1.Rows(index).Cells("StatusPinjaman").Value = statusPinjaman
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

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If DataGridView1.CurrentCell IsNot Nothing AndAlso
           DataGridView1.CurrentCell.OwningColumn.Name = "StatusPinjaman" Then
            If DataGridView1.IsCurrentCellDirty Then
                DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.ColumnIndex = DataGridView1.Columns("StatusPinjaman").Index AndAlso e.RowIndex >= 0 Then
            Try
                Module1.koneksi()

                Dim nomorHP As String = DataGridView1.Rows(e.RowIndex).Cells("NomorHP").Value.ToString()
                Dim newStatus As String = DataGridView1.Rows(e.RowIndex).Cells("StatusPinjaman").Value.ToString()

                Dim query As String = "UPDATE tbUsers SET statusPinjaman = @status WHERE NomorHP = @nomorHP"
                Dim cmd As New MySqlCommand(query, Module1.CONN)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@nomorHP", nomorHP)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui status: " & ex.Message)
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        HomeAdmin.Show()
        Me.Hide()
    End Sub

End Class