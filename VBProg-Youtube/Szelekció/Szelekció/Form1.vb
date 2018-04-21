Public Class Form1
    Dim Osztandó, Osztó, Hányados As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Osztandó = TextBox1.Text
        Osztó = TextBox2.Text

        If Osztó = 0 Then
            Label1.Text = "Nullával nem lehet osztani!"
        Else
            Hányados = Osztandó / Osztó
            Label1.Text = Hányados
        End If
        Label1.Text &= vbNewLine

    End Sub
End Class
