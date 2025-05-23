﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PeriksaKosongFormLogin() Then
            Try
                If GlobalVariables.AkunAdmin(0, 0) = CStr(63) And txtPassword.Text = "daffa" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf GlobalVariables.AkunAdmin(1, 0) = CStr(59) And txtPassword.Text = "ayya" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                ElseIf GlobalVariables.AkunAdmin(2, 0) = CStr(50) And txtPassword.Text = "rehan" Then
                    MessageBox.Show("Login berhasil! Selamat datang, Admin")
                    Me.Hide()
                    GlobalVariables.Admin = txtUsername.Text
                    HomeAdmin.Show()
                    KosongkanForm()
                Else
                    Module1.koneksi()

                    Module1.CMD = New MySqlCommand("SELECT username, NomorHP FROM tbUsers WHERE NomorHP = @UserName AND password = @pw", Module1.CONN)
                    Module1.CMD.Parameters.AddWithValue("@UserName", txtUsername.Text)
                    Module1.CMD.Parameters.AddWithValue("@pw", txtPassword.Text)

                    Module1.RD = Module1.CMD.ExecuteReader()
                    If Module1.RD.Read() Then
                        GlobalVariables.Username = Module1.RD("username").ToString()
                        GlobalVariables.nomor_hp_user = Convert.ToInt64(Module1.RD("NomorHP"))

                        MessageBox.Show("Login berhasil! Selamat datang, " & GlobalVariables.Username)

                        Me.Hide()
                        HomeUser.Show()
                        KosongkanForm()
                    Else
                        MessageBox.Show("Login gagal. Username atau password salah.")
                    End If
                    Module1.RD.Close()
                End If


            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message)
                ' Tambahkan logging kesalahan di sini jika diperlukan
            Finally
                If Module1.CONN.State = ConnectionState.Open Then
                    Module1.CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub KosongkanForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FMenu.Show()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        txtUsername.MaxLength = 50
        Module1.HanyaAngka(e)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.MaxLength = 50
    End Sub

    Function PeriksaKosongFormLogin() As Boolean
        If txtUsername.Text = "" Then
            MessageBox.Show("username harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("password harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LihatPass_Click(sender As Object, e As EventArgs) Handles LihatPass.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__13_
        Else
            txtPassword.PasswordChar = "*"
            LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
        GlobalVariables.AkunAdmin(0, 0) = "63"
        GlobalVariables.AkunAdmin(0, 1) = "daffa"
        GlobalVariables.AkunAdmin(1, 0) = "59"
        GlobalVariables.AkunAdmin(1, 1) = "ayya"
        GlobalVariables.AkunAdmin(2, 0) = "50"
        GlobalVariables.AkunAdmin(2, 1) = "rehan"
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtPassword.PasswordChar = "*"
        LihatPass.BackgroundImage = My.Resources.Desain_tanpa_judul__11_
    End Sub
End Class