Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox3.Image = PictureBox1.Image
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox3.Image

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox3.Image = PictureBox1.Image
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox3.Image
    End Sub
End Class
