Public Class Form2

    Public Shared Fak As Integer
    Public Shared Hasil As Long
    Public Sub Hitung()
        Hasil = 1
        If Fak > 0 And Fak <= 20 Then
            For i As Integer = 1 To Fak
                Hasil = Hasil * i
            Next
            TXT_Hasil.Text = Hasil
        ElseIf Fak = 0 Then
            TXT_Hasil.Text = ""
        Else
            TXT_Hasil.Text = "Kegedean"
        End If
    End Sub

    Private Sub TXT_Fak_TextChanged(sender As Object, e As EventArgs) Handles TXT_Fak.TextChanged
        If TXT_Fak.Text = "" Then
            TXT_Hasil.Text = ""
        ElseIf IsNumeric(TXT_Fak.Text) Then
            Fak = TXT_Fak.Text
            Hitung()
        Else
            TXT_Hasil.Text = "Harus angka dong!"
        End If
    End Sub

    Private Sub BTN_Hitung_Click(sender As Object, e As EventArgs) Handles BTN_Hitung.Click
        Hitung()
    End Sub

    Private Sub BTN_Kosongkan_Click(sender As Object, e As EventArgs) Handles BTN_Kosongkan.Click
        Fak = Nothing
        Hasil = Nothing
        TXT_Fak.Text = ""
        TXT_Hasil.Text = ""
    End Sub

    Private Sub BTN_Batal_Click(sender As Object, e As EventArgs) Handles BTN_Batal.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Dispose()
    End Sub
End Class