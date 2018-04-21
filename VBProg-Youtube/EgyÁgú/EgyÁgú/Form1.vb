Public Class Form1

    Dim Szám As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Szám = TextBox1.Text
        Label1.Text = "A " & Szám & vbNewLine
        Label1.Text &= "Abszolút értéke: "
        Label1.Text &= Math.Abs(Szám) & vbNewLine

        If Szám <> 0 Then
            Label1.Text &= "Reciproka: "
            Label1.Text &= 1 / Szám & vbNewLine
        End If

        If Szám >= 0 Then
            Label1.Text &= "Négyzetgyöke: "
            Label1.Text &= Math.Sqrt(Szám)
        End If

    End Sub
End Class
