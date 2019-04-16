Attribute VB_Name = "Module1"
Sub RefreshUser()
    
    Application.DisplayAlerts = False
    
    'files
    Dim MT4Path, Folder, file, Symbol, Strategy, DemoFile, DemoStatFile As String
    
    Symbol = "SP500"
    Strategy = "_H_ADX"
    
    MT4Path = Environ("UserProfile") & "\Documents\Tozsde\MT4ek\"
    Folder = "\MQL4\Files\csvStatement_"
    file = Symbol & Strategy
    DemoFile = MT4Path & "Admiral2" & Folder & "23129454\" & Symbol & "\" & file & "_tick.csv"
    DemoStatFile = MT4Path & "Admiral2" & Folder & "23129454\" & Symbol & "\" & file & "_stat.csv"
    LiveFile = MT4Path & "Admiral2" & Folder & "27019217\" & Symbol & "\" & file & "_tick.csv"

    'demo
    Call copyCsv(DemoFile, file, "A1:R2000", "_tick.csv", "DemoData")
    
    'live
    Call copyCsv(LiveFile, file, "A1:R2000", "_tick.csv", "LiveData")
        
    'stat
    Call copyCsv(DemoStatFile, file, "A1:Y20", "_stat.csv", "stat")

    Application.DisplayAlerts = True
    
    Sheets("collected").Select
    
End Sub

Sub copyCsv(filePath As String, file As String, rng As String, fileType As String, lap As String)

    If (Dir(filePath) > "") Then
        Workbooks.OpenText Filename:=filePath, DataType:=xlDelimited, Comma:=True, Local:=True
        range(rng).Select
        Selection.Copy
        ThisWorkbook.Activate
        Sheets(lap).Select
        range("A1").Select
        ActiveSheet.Paste
        Workbooks(file & fileType).Close SaveChanges:=False
    End If
    
End Sub

