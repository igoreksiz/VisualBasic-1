Public Class Form1
    Dim Formátum As String
    Dim Szám As Single = 100
    Dim Szöveg As String = "VAKÁCIÓ"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' formátum: sztring
        ' {index, hoszz:formátumkód}  
        ' hossz -> fenntartott karakterek száma ha negatív, akkor balra zárja, ha pozitív, akkor jobbra
        ' formátumkód -> tizedesjegyek
        Formátum = "A {0, 10:F0}  négyzetgyöke: {1, 10:F2}." & vbNewLine

        ' String.Format(formátum, érék0, érték1, ... )
        Label1.Text = String.Format(Formátum, 10, Math.Sqrt(10))
        Label1.Text &= String.Format(Formátum, Szám, Math.Sqrt(Szám))
        Label1.Text &= String.Format(Formátum, 10 * Szám, Math.Sqrt(10 * Szám)) & vbNewLine

        Formátum = "{0, " & Szöveg.Length & "}" & vbNewLine

        For I = Szöveg.Length - 1 To 0 Step -1
            Label1.Text &= String.Format(Formátum, Szöveg.Substring(I))
        Next



    End Sub
End Class
