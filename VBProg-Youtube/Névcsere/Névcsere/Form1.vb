Public Class Form1
    Dim Név1, Név2, Temp As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Név1 = TextBox1.Text
        Név2 = TextBox2.Text

        Temp = Név1

        Név1 = Név2
        Név2 = Temp

        TextBox1.Text = Név1
        TextBox2.Text = Név2

    End Sub
End Class
