Imports System.Text
Imports MySql.Data.MySqlClient

Public Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public CMD2 As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Sub koneksi()
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Try
            Dim STR As String =
            "server=localhost;userid=root;password=;database=ProyekAkhirPemVis"
            'Ganti nama database sesuaikan dengan nama database kalian
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

Public Class FMenu
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        DaftarAkun.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class
