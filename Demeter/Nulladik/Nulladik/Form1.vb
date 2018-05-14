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

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim HolX, HolY As Int32

        HolX = (Me.Width - Label1.Width) / 2
        HolY = (Me.ClientSize.Height) / 2
        Label1.Location = New System.Drawing.Point(HolX, HolY)
    End Sub
End Class
