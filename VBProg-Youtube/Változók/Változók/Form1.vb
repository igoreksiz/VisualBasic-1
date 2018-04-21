Public Class Form1
    Dim Név As String
    Dim SzületésiÉv As Integer
    Dim Magasság As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Név: " & Név & vbNewLine
        Label1.Text &= "SzületésiÉv: " & SzületésiÉv.ToString & vbNewLine
        Label1.Text &= "Magasság: " & Magasság
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Név = "Laci"
        SzületésiÉv = "2001"
        Magasság = 167.5
    End Sub
End Class
