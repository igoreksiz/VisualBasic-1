Public Class Form1
    Dim A, B, C As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 7
        TextBox2.Text = 15

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = TextBox1.Text
        B = TextBox2.Text
        C = Math.Sqrt(A ^ 2 + B ^ 2)

        Label1.Text = Math.Round(C, 2) & vbNewLine 'kerekítés az értékben
        Label1.Text &= C.ToString("F2") 'kerekítés csak a kiírásban

    End Sub
End Class
