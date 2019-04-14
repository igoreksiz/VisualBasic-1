Attribute VB_Name = "Module1"
Sub RefreshUser()

    'files
    Dim MT4Path As String, Folder As String, file As String, pathFile As String, account As String, tickSheet As String
    
    
    MT4Path = Environ("UserProfile") & "\Documents\Tozsde\MT4ek\"
    Folder = "\MQL4\Files\csvStatement_"
    
    ' dollár számla: 27018855 - LiveData  / forint számla: 27019217 - HufData / <- aktuális számla beállítása
    account = "27019217"
    tickSheet = "HufData"
    
    Application.DisplayAlerts = False
    
    'live tick data all --------------------------------------------------------
    file = "manual_tick.csv"
    
    pathFile = MT4Path & "Admiral2" & Folder & account & "\manual\" & file
    Call dDataCopy(pathFile, "A1:N2000", tickSheet, "A1", file)
    
    
    Call rowFill(14, 15, "O", "Q")
    
    'stat
    file = "manual_stat.csv"
    pathFile = MT4Path & "Admiral2" & Folder & account & "\manual\" & file
    Call dDataCopy(pathFile, "A1:Z20", "stat", "A1", file)
    
    
    'master of manual statisztika
    file = "MasterOfManualStrategies.csv"
    pathFile = MT4Path & "Admiral2" & Folder & account & "\" & file
    Call dDataCopy(pathFile, "A1:M300", "master", "A1", file)
    
    'instrumentumok napi adatai
    Call InstrumentsDailyData("SP500", "AB2", account)
    Call InstrumentsDailyData("GOLD", "AE2", account)
    
'    Call InstrumentsDailyData("SP500", "A2")
'    Call InstrumentsDailyData("NQ100", "D2")
'    Call InstrumentsDailyData("DAX30", "G2")
'    Call InstrumentsDailyData("FTSE100", "J2")
'    Call InstrumentsDailyData("WTI", "M2")
'    Call InstrumentsDailyData("GOLD", "P2")
'    Call InstrumentsDailyData("SILVER", "S2")
'    Call InstrumentsDailyData("EURJPY", "V2")
'    Call InstrumentsDailyData("USDJPY", "Y2")

    'usdhuf árfolyam betöltése -----------------
    file = "usdhufPrices.csv"
    pathFile = MT4Path & "XM1\MQL4\Files\" & file
    Call dDataCopy(pathFile, "A1:B30000", "huf", "A1", file)
    
    Application.DisplayAlerts = True
    
    '-------------------------------------------------------------
    Sheets("monitor").Select
    
    'kibõvíti az adatsort a mholnapi dátumig
    Dim réndzs As String, réndzs2 As String, Ido As Date, Y As Integer

        Do While Ido < Now()
            Y = Cells(Rows.Count, 1).End(xlUp).Row
            réndzs = "a" & Y & ":V" & Y
            réndzs2 = "a" & Y & ":V" & Y + 1
            Range(réndzs).Select
            Selection.AutoFill Destination:=Range(réndzs2), Type:=xlFillDefault
            Ido = Cells(Y + 1, 1)
        Loop
        
    '-------------------------------------------------------------
    
End Sub

Sub InstrumentsDailyData(sym As String, col As String, acnt As String)
    
    Dim MT4Path As String, Folder As String, file As String, pathFile As String
    
    MT4Path = Environ("UserProfile") & "\Documents\Tozsde\MT4ek\"
    Folder = "\MQL4\Files\csvStatement_"
    
    file = "manual_" & sym & "_daily.csv"
    pathFile = MT4Path & "Admiral2" & Folder & acnt & "\manual\" & file
    Call dDataCopy(pathFile, "A1:C2000", "d", col, file)
    
End Sub

Sub dDataCopy(path As String, rng As String, sht As String, place As String, file As String)

    If (Dir(path) > "") Then
        Workbooks.OpenText Filename:=path, DataType:=xlDelimited, Comma:=True, Local:=True
        Range(rng).Select
        Selection.Copy
        ThisWorkbook.Activate
        Sheets(sht).Select
        Range(place).Select
        ActiveSheet.Paste
        Application.DisplayAlerts = False
        Workbooks(file).Close SaveChanges:=False
    End If
    
End Sub

Sub rowFill(refColumn As Integer, goalColumn As Integer, rowFrom As String, rowTo)
    ' kitölti a hiányzó sorokat
    
    Dim current As String, goal As String, adatSor As Integer, sumSor As Integer
    
    adatSor = Cells(Rows.Count, refColumn).End(xlUp).Row
    sumSor = Cells(Rows.Count, goalColumn).End(xlUp).Row
    current = rowFrom & sumSor & ":" & rowTo & sumSor
    goal = rowFrom & sumSor & ":" & rowTo & adatSor
    
    If (adatSor > sumSor) Then
        Range(current).Select
        Selection.AutoFill Destination:=Range(goal), Type:=xlFillDefault
    End If

End Sub




