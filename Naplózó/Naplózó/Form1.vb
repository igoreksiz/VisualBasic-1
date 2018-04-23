Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FájlBe As New IO.StreamReader("naplo.csv")
        Dim Sor As String
        Dim Temp() As String

        Do
            Sor = FájlBe.ReadLine
            If Sor Is Nothing Then Exit Do
            Temp = Sor.Split(";")
            DataGridView1.Rows.Add("")
            For i As Integer = 0 To 1
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(i).Value = Temp(i)
            Next
        Loop

        FájlBe.Close()
    End Sub
End Class
