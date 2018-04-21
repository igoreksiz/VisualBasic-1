Public Class Form1
    Dim a, c, m, t As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 3
        c = 1
        m = 2
        t = (a + c) / 2 * m
        Label1.Text = t

        a = 6 * (16 - 4 * 3) / (2 + 24 / (5 - 2))
        Label1.Text &= vbNewLine & a
    End Sub
End Class
