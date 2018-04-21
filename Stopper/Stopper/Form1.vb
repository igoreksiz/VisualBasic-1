Public Class Form1
    Dim EzredMásodperc, Másodperc, Perc, Óra As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EzredMásodperc = 0
        Másodperc = 0
        Perc = 0
        Óra = 0
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        EzredMásodperc += 1

        If EzredMásodperc = 60 Then
            Másodperc += 1
            EzredMásodperc = 0
        End If

        If Másodperc = 60 Then
            Perc += 1
            Másodperc = 0
        End If

        If Perc = 60 Then
            Óra += 1
            Perc = 0
        End If

        Label1.Text = Óra & ":" & Format(Perc, "00") & ":" & Format(Másodperc, "00") & ":" & EzredMásodperc

    End Sub
End Class
