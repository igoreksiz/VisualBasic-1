Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Szia " & TextBox1.Text & "!"
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        ' duplán kattintás eseménykezelése
        Label1.Text = "Ide ne kattints duplán!"
        Label1.BackColor = Color.Red
        Me.BackColor = Color.Gray   '--- az ablak szürke háttérszínt kap.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' betöltéskor megváltoztatja az ablak színét.
        Me.BackColor = Color.IndianRed
    End Sub
End Class
