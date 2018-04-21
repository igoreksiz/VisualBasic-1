Public Class Form1
    Dim Szám1, Szám2, Összeg As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Szám1 = Convert.ToInt32(TextBox1.Text)
        Szám2 = Convert.ToInt32(TextBox2.Text)
        Összeg = Szám1 + Szám2
        Label1.Text = Összeg

    End Sub
End Class
