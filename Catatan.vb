Imports MySql.Data.MySqlClient

Public Class Catatan

    Sub BuatData(kode As String)
        CMD = New MySqlCommand("INSERT INTO tbnote (id, Note, kode)
VALUES (@id, @note, @kode)", CONN)
        CMD.Parameters.AddWithValue("@id", kode)
        CMD.Parameters.AddWithValue("@note", TxtCatatan.Text)
        CMD.Parameters.AddWithValue("@kode", kode)
        CMD.ExecuteNonQuery()
    End Sub

    Sub HapusData(kode As String)
        Form1.CekDataReader()
        CMD2 = New MySqlCommand("DELETE FROM tbnote WHERE id = @id", CONN)
        CMD2.Parameters.AddWithValue("@id", kode)
        CMD2.ExecuteNonQuery()
    End Sub
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Form1.CekDataReader()
        Dim ubah As String = "update tbnote set Note = (@note) where id = @id"
        CMD = New MySqlCommand(ubah, CONN)
        CMD.Parameters.AddWithValue("@id", Form1.TxtKode.Text)
        CMD.Parameters.AddWithValue("@note", TxtCatatan.Text)
        CMD.ExecuteNonQuery()
        Me.Close()
    End Sub

    Private Sub Catatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.CekDataReader()
        CMD = New MySqlCommand("select Note from tbnote where id = @id", CONN)
        CMD.Parameters.AddWithValue("@id", Form1.TxtKode.Text)
        TxtCatatan.Text = ""
        Dim result As Object = CMD.ExecuteScalar()
        TxtCatatan.Text = result
    End Sub
End Class