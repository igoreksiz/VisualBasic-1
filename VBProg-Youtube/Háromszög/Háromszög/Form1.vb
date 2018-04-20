Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        válasz.Text = "A háromszög oldalai: " & vbNewLine

        válasz.Text &= a.Text & " " & mértékegység.Text & ", "
        válasz.Text &= b.Text & " " & mértékegység.Text & " és "
        válasz.Text &= c.Text & " " & mértékegység.Text & "."
    End Sub
End Class
