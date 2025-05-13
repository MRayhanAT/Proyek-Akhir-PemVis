Imports MySql.Data.MySqlClient

Module ModDB
    Public conn As MySqlConnection
    Public connStr As String = "server=localhost;user id=root;password=1245;database=dbPA_pemvis;"

    'Sub koneksi()
    '    Try
    '        Dim STR As String =
    '        "server=localhost;userid=root;password=;database=ProyekAkhirPemVis"
    '        'Ganti nama database sesuaikan dengan nama database kalian
    '        conn = New MySqlConnection(STR)
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Public Sub BukaKoneksi()
        conn = New MySqlConnection(connStr)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

    Public Sub TutupKoneksi()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal menutup koneksi: " & ex.Message)
        End Try
    End Sub
End Module

