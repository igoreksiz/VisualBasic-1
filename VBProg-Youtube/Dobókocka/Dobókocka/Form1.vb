Public Class Form1
    Dim Dobás As Integer
    Dim VélSzám As New Random
    Const Max As Integer = 90

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dobás = VélSzám.Next(1, Max + 1)
        Label1.Text = Dobás

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VélSzám = New Random
    End Sub
End Class
