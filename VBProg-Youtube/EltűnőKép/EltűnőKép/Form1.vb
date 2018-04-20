Public Class Form1
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        PictureBox1.Visible = False
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        PictureBox1.Visible = True
    End Sub
End Class
