Public Class Form1
    Structure TSor
        Dim Dátum As Date
        Dim Egyenleg As Single
    End Structure

    Dim Sorok(9999999) As TSor
    Dim SorCount As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FájlBe As New IO.StreamReader("naplo.csv")

        ' beolvasás
        Dim Temp() As String
        SorCount = 0
        Do While FájlBe.Peek <> -1
            Temp = FájlBe.ReadLine.Split(";")
            SorCount += 1
            With Sorok(SorCount)
                .Dátum = Temp(0)
                .Egyenleg = Temp(1)
                Label1.Text += "dátum " & SorCount & " " & .Dátum & " egyenleg: " & .Egyenleg & vbNewLine
            End With
        Loop

        ' tömb átméretezése
        ReDim Preserve Sorok(SorCount)

        ' táblázat feltöltése
        FájlBe.Close()
        For J = 1 To SorCount

            DataGridView1.Rows.Add(Sorok(J).Dátum, Sorok(J).Egyenleg)

        Next

    End Sub
End Class
