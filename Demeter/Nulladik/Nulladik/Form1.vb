Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Elrejt" Then
            Label1.Hide()
            Button1.Text = "Megmutat"
        Else
            Label1.Show()
            Button1.Text = "Elrejt"
        End If
    End Sub
End Class
