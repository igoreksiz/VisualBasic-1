Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Threading.Thread.Sleep(2000) ' 2 másodperc
        Me.BackColor = Color.Black
        Me.Refresh()
    End Sub
End Class
