Public Class Form1
    Public Shared pass As String = "Vincent"
    Public Sub eksekusi()
        If TXT_Pass.Text = pass Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Password Salah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_Pass.Text = ""
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BTN_Masuk_Click(sender As Object, e As EventArgs) Handles BTN_Masuk.Click
        eksekusi()
    End Sub
    Private Sub TXT_Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_Pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            eksekusi()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
