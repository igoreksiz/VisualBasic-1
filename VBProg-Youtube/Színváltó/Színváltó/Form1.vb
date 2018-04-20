Public Class Form1
    Private Sub Piros_Click(sender As Object, e As EventArgs) Handles Piros.Click
        Me.BackColor = Color.Red
        Piros.Enabled = False
        Zöld.Enabled = True
        Kék.Enabled = True
    End Sub

    Private Sub Zöld_Click(sender As Object, e As EventArgs) Handles Zöld.Click
        Me.BackColor = Color.Green
        Piros.Enabled = True
        Zöld.Enabled = False
        Kék.Enabled = True
    End Sub

    Private Sub Kék_Click(sender As Object, e As EventArgs) Handles Kék.Click
        Me.BackColor = Color.CornflowerBlue
        Piros.Enabled = True
        Zöld.Enabled = True
        Kék.Enabled = False
    End Sub
End Class
