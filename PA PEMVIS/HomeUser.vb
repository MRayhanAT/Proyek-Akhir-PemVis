Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class HomeUser

    'Private Sub LoadToDoList()
    '    Try
    '        Module1.koneksi()

    '        Module1.STR = "SELECT COUNT(*) FROM Catatan"
    '        Module1.CMD = New MySqlCommand(Module1.STR, Module1.CONN)
    '        Dim jumlah As Integer = Convert.ToInt32(Module1.CMD.ExecuteScalar())
    '        If jumlah > 0 Then
    '            Module1.STR = "SELECT * FROM Catatan WHERE nomorHP = @noHP"
    '            Module1.CMD = New MySqlCommand(Module1.STR, Module1.CONN)
    '            Module1.CMD.Parameters.AddWithValue("@noHP", GlobalVariables.Username)
    '            Dim reader As MySqlDataReader = Module1.CMD.ExecuteReader()
    '            Dim tugas As String
    '            While reader.Read()
    '                tugas = reader("Tugas").ToString()
    '                Todolistbox.Items.Add(tugas)
    '            End While
    '            reader.Close()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Terjadi kesalahan: " & ex.Message)
    '    End Try
    'End Sub


    Private Sub LoadToDoList()
        Try
            Module1.koneksi()

            Module1.STR = "SELECT COUNT(*) FROM Catatan WHERE nomorHP = @noHP"
            Module1.CMD = New MySqlCommand(Module1.STR, Module1.CONN)
            Module1.CMD.Parameters.AddWithValue("@noHP", GlobalVariables.nomor_hp_user)
            Dim jumlah As Integer = Convert.ToInt32(Module1.CMD.ExecuteScalar())

            If jumlah > 0 Then

                Module1.STR = "SELECT idCatatan, catatan FROM Catatan WHERE nomorHP = @noHP"
                Module1.CMD = New MySqlCommand(Module1.STR, Module1.CONN)
                Module1.CMD.Parameters.AddWithValue("@noHP", GlobalVariables.nomor_hp_user)
                Dim reader As MySqlDataReader = Module1.CMD.ExecuteReader()


                Todolistbox.Items.Clear()

                While reader.Read()
                    Dim tugas As String = reader("catatan").ToString()
                    Todolistbox.Items.Add(tugas)
                End While
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat daftar catatan: " & ex.Message)
        Finally
            If Module1.CONN.State = ConnectionState.Open Then
                Module1.CONN.Close()
            End If
        End Try
    End Sub

    Private Sub TambahToDoList()

        If txtList.Text.Trim() <> "" Then
            Try
                Module1.koneksi()

                Module1.STR = "INSERT INTO Catatan (catatan, nomorHP) VALUES (@catatan, @nomorHP)"
                Module1.CMD = New MySqlCommand(Module1.STR, Module1.CONN)


                Module1.CMD.Parameters.AddWithValue("@catatan", txtList.Text.Trim())
                Module1.CMD.Parameters.AddWithValue("@nomorHP", GlobalVariables.nomor_hp_user)

                Module1.CMD.ExecuteNonQuery()

                MessageBox.Show("Catatan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Todolistbox.Items.Add(txtList.Text.Trim())
                txtList.Clear()

            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menambahkan catatan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
                End If
            End Try
        Else
            MessageBox.Show("Catatan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If Not Periksakosong() Then
            MessageBox.Show("Tugas tidak boleh kosong")
            Return
        Else
            LoadToDoList()
            TambahToDoList()
            LoadToDoList()
        End If
    End Sub

    Private Sub Todolistbox_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Todolistbox.DrawItem
        If e.Index < 0 Then Exit Sub

        Dim itemText As String = Todolistbox.Items(e.Index).ToString()

        e.DrawBackground()
        e.Graphics.FillRectangle(New SolidBrush(Color.LightYellow), e.Bounds)

        Dim checked As Boolean = Todolistbox.GetItemChecked(e.Index)

        CheckBoxRenderer.DrawCheckBox(e.Graphics, New Point(e.Bounds.X + 2, e.Bounds.Y + 1),
        If(checked, VisualStyles.CheckBoxState.CheckedNormal, VisualStyles.CheckBoxState.UncheckedNormal))

        Dim textBrush As Brush = Brushes.Black
        e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds.X + 20, e.Bounds.Y)

        e.DrawFocusRectangle()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAjukan_Click(sender As Object, e As EventArgs) Handles BtnAjukan.Click
        AjukanPijaman.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRiwayat_Click(sender As Object, e As EventArgs) Handles BtnRiwayat.Click
        Riwayat.Show()
        Me.Hide()
    End Sub

    'Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    UserName.Text = GlobalVariables.Username
    'End Sub

    Private Function Periksakosong()
        If txtList.Text = "" Then
            MessageBox.Show("Tugas tidak boleh kosong")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub HomeUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UserName.Text = GlobalVariables.Username
        Todolistbox.Items.Clear()
        LoadToDoList()
    End Sub
End Class
