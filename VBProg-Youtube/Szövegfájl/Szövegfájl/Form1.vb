Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim FájlKi As IO.StreamWriter 'célszerű az eseménykezelőben deklarálni (csak itt hivatkozhatunk rá)
        ' FájlKi = New IO.StreamWriter("adatok.csv")

        Dim FájlKi As New IO.StreamWriter("adatok.csv")
        ' Létrejön a fájl
        Label1.Text = "Létrejött a fájl." & vbNewLine

        ' Írás fileba
        For I = 1 To 10
            FájlKi.Write(I & ";")
            FájlKi.Write("Béla" & ";" & "Cecil" & ";" & "Ubul")
            FájlKi.WriteLine(I)

        Next
        FájlKi.Close()
    End Sub

End Class
