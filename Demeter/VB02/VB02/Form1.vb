Public Class Form1
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim MiniInfo As New ToolTip
        Dim mit As String
        MiniInfo.AutoPopDelay = 1000
        MiniInfo.InitialDelay = 100
        MiniInfo.ReshowDelay = 500
        MiniInfo.ShowAlways = True
        If e.Location.X < sender.Width / 2 And e.Location.Y < sender.ClientSize.Height / 2 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                mit = " Ablakkeret stílusa "
                If Me.FormBorderStyle < 6 Then
                    FormBorderStyle = FormBorderStyle + 1
                ElseIf CInt(Me.FormBorderStyle) = 6 Then
                    FormBorderStyle = 0
                End If
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                mit = " Control menü "
                Me.ControlBox = Not Me.ControlBox
            End If
        ElseIf e.Location.X > Me.Width / 2 And e.Location.Y < Me.ClientSize.Height / 2 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                mit = " Ablak átlátszóságának növelése "
                If Me.Opacity > 0.2 Then
                    Me.Opacity -= 0.1
                End If
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                mit = " Ablak átlátszóságának csökkentése "
                If Me.Opacity <= 1.0 Then
                    Me.Opacity += 0.1
                End If
            End If
        ElseIf e.Location.X < Me.Width / 2 And e.LocationY > Me.ClientSize.Height / 2 Then
            mit = " Ablak háttérképének megjelenítése "
            If Me.BackgroundImageLayout < 4 Then
                BackgroundImageLayout = BackgroundImageLayout + 1
            ElseIf CInt(Me.BackgroundImageLayout) = 4 Then
                BackgroundImageLayout = 0
            End If
        End If
    End Sub
End Class
