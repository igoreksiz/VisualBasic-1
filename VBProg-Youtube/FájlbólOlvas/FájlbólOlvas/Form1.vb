Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FájlBe As New IO.StreamReader("C:\Users\User\Documents\Tozsde\MT4ek\XM1\MQL4\Files\webStatement\data\EURJPY\EURJPY_M15_TSQ.csv")

        Dim Sor As String
        ' Előolvasás
        Sor = FájlBe.ReadLine()
        Do While Sor IsNot Nothing
            Label1.Text &= Sor & vbNewLine ' már beolvastuk a sort
            Sor = FájlBe.ReadLine()  ' a végén Nothing lesz
        Loop

        FájlBe.Close()
        Label1.Text &= vbNewLine & vbNewLine & "A Beolvasás kész." & vbNewLine & vbNewLine



    End Sub
End Class
