Imports MySql.Data.MySqlClient

Public Class AjukanPijaman
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub form_input_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub form_input_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = AjukanPijaman.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Pengajuan_Pinjaman_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lbNama_Pengajuan.Text = GlobalVariables.Username
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

            Dim insertQuery As String = "INSERT INTO Pinjaman (Nama, Alamat, Nominal, cicilan, NomorHP_Pengguna) VALUES (@unamep, @al, @nom, @ci, @nop)"

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
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If

        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        HomeUser.Show()
        Me.Hide()
    End Sub
End Class