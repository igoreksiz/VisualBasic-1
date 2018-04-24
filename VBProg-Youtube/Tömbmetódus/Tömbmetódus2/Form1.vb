Public Class Form1
    Structure TTrade
        Dim OpenTime As Date
        Dim Type As String
        Dim Size As Single
        Dim OpenPrice As Single
        Dim CloseTime As Date
        Dim ClosePrice As Single
        Dim Profit As Single
        Dim Komment As String
        Dim ProfitPerc As String
        Dim Update As String
        Dim Hozam As Single
        Dim HozamPerc As Single
    End Structure

    Dim Tradek(9999) As TTrade
    Dim N As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' beolvasás fileból -------------------------------------------------------------
        Dim FileBe As New IO.StreamReader("AUDUSD_M5_Zoom.csv")
        Dim Temp() As String
        Dim TempHozam As Single
        Dim TempHozamPerc As Single
        TempHozam = 0
        TempHozamPerc = 0
        N = 0
        Do While FileBe.Peek <> -1
            Temp = FileBe.ReadLine.Split(";")
            N += 1
            TempHozam += CSng(Replace(Temp(6), ".", ","))
            Dim hossz As Integer = Len(Temp(8)) - 1
            Dim subString As String = CSng(Replace(Temp(8).Substring(0, hossz), ".", ","))
            TempHozamPerc += subString
            With Tradek(N)
                .OpenTime = Temp(0)
                .Type = Temp(1)
                .Size = CSng(Replace(Temp(2), ".", ","))
                .OpenPrice = CSng(Replace(Temp(3), ".", ","))
                .CloseTime = Temp(4)
                .ClosePrice = CSng(Replace(Temp(5), ".", ","))
                .Profit = CSng(Replace(Temp(6), ".", ","))
                .Komment = Temp(7)
                .ProfitPerc = subString
                .Update = Temp(9)
                .Hozam = TempHozam
                .HozamPerc = TempHozamPerc
            End With
        Loop

        ' DataGridView feltöltése
        FileBe.Close()
        For J = 1 To N

            DataGridView1.Rows.Add(Tradek(J).OpenTime, Tradek(J).Type, Tradek(J).Size, Tradek(J).OpenPrice, Tradek(J).CloseTime, Tradek(J).ClosePrice, Tradek(J).Profit, Tradek(J).Komment, Tradek(J).ProfitPerc, Tradek(J).Update, Tradek(J).Hozam, Tradek(J).HozamPerc)

        Next

        ' Array Resize
        ReDim Preserve Tradek(N)

        ' nyerő trédek DB száma ------------------------ külön függvényhivatkozással
        Dim NyerőDb As Integer
        Tradek(0).Hozam = -0.01
        NyerőDb = Tradek.Count(AddressOf NyerőTrédek)
        Label_Stat.Text = "Nyerő Trédek: " & NyerőDb & " db" & vbNewLine

        ' vesztő trédek DB száma ------------------------ ugyanez egyszerűbben Lambda kifejezéssel:
        Dim VesztőDb As Integer
        Tradek(0).Hozam = 0.01
        VesztőDb = Tradek.Count(Function(Elem) Elem.Hozam < 0)
        Label_Stat.Text += "Vesztő Trédek: " & VesztőDb & " db" & vbNewLine
    End Sub

    Function NyerőTrédek(Elem As TTrade) As Boolean
        NyerőTrédek = (Elem.Hozam > 0)
    End Function

End Class
