Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If PictureBox1.Width > 10 Then
            PictureBox1.Width = PictureBox1.Width / 1.2
            PictureBox1.Height = PictureBox1.Height / 1.2
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If PictureBox1.Width < 1000 Then
            PictureBox1.Width = PictureBox1.Width * 1.2
            PictureBox1.Height = PictureBox1.Height * 1.2
        End If

    End Sub
End Class
