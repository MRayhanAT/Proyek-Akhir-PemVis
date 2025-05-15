Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HomeUser
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tugas As String = txtList.Text.Trim()
        If tugas <> "" Then
            Todolistbox.Items.Add(tugas)
            txtList.Clear()
        Else
            MessageBox.Show("Masukkan tugas terlebih dahulu.")
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

    Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        UserName.Text = GlobalVariables.Username
    End Sub
End Class
