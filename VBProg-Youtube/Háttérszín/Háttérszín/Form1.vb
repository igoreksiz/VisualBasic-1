Public Class Form1
    Dim Vörös, Zöld, Kék As Integer

    Private Sub G_Scroll(sender As Object, e As EventArgs) Handles G.Scroll
        Zöld = G.Value
        Me.BackColor = Color.FromArgb(Vörös, Zöld, Kék)
    End Sub

    Private Sub B_Scroll(sender As Object, e As EventArgs) Handles B.Scroll
        Kék = B.Value
        Me.BackColor = Color.FromArgb(Vörös, Zöld, Kék)
    End Sub

    Private Sub R_Scroll(sender As Object, e As EventArgs) Handles R.Scroll
        Vörös = R.Value
        Me.BackColor = Color.FromArgb(Vörös, Zöld, Kék)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vörös = 128
        Zöld = 127
        Kék = 126

        Me.BackColor = Color.FromArgb(Vörös, Zöld, Kék)
    End Sub
End Class
