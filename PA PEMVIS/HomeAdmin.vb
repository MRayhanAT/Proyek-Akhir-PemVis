Imports System.Text
Imports MySql.Data.MySqlClient

Public Class HomeAdmin
    Private CONN As MySqlConnection
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form_input_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form_input_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = HomeAdmin.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        TampilkanTotal()
    End Sub

    Private Sub Koneksi()
        Try
            Dim connectionString As String =
            "server=localhost;userid=root;password=;database=ProyekAkhirPemVis"
            CONN = New MySqlConnection(connectionString)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TampilkanTotal()
        Dim reader As MySqlDataReader = Nothing

        Try
            Koneksi()

            Dim query As String = "SELECT 
                                    (SELECT COUNT(*) FROM tbUsers) AS TotalUser,
                                    (SELECT COUNT(*) FROM Pinjaman) AS TotalPeminjaman,
                                    (SELECT COUNT(*) FROM Pinjaman WHERE Status = 'Diterima') AS PinjamanDiterima,
                                    (SELECT COUNT(*) FROM Pinjaman WHERE Status = 'Ditolak') AS PinjamanDitolak"

            Dim cmd As New MySqlCommand(query, CONN)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                LblUser.Text = reader("TotalUser").ToString()
                LblPinjaman.Text = reader("TotalPeminjaman").ToString()
                LblTerima.Text = reader("PinjamanDiterima").ToString()
                LblTolak.Text = reader("PinjamanDitolak").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat statistik: " & ex.Message)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If

            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub DaftarUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarUserToolStripMenuItem.Click
        DaftarUser.Show()
        Me.Hide()
    End Sub

    Private Sub DaftarPinjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarPinjamanToolStripMenuItem.Click
        DaftarPeminjaman.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub HomeAdmin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TampilkanTotal()
    End Sub
End Class