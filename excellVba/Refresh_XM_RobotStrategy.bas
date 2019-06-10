Attribute VB_Name = "Module1"
'files
    Dim MT4Path As String, Folder As String, file As String, DemoFile As String
    Dim LiveFile As String
    
    
Sub RefreshUser()
    
    MT4Path = Environ("UserProfile") & "\Documents\Tozsde\MT4ek\"
    Folder = "\MQL4\Files\csvStatement_"
    
    Application.DisplayAlerts = False
    
    file = "MasterOfRobotStrategies.csv"
    LiveFile = MT4Path & "XM1" & Folder & "19061180\" & file
    DemoFile = MT4Path & "XM2" & Folder & "9107935\" & file
    
    Call dDataCopy(LiveFile, "A1:M300", "dataLive", "A2", file)
    Call dDataCopy(DemoFile, "A1:M300", "dataDemo", "A2", file)
    
    '---------------------------------------------------------------------------------------
    'DailyData

    file = "robot_daily.csv"
    LiveFile = MT4Path & "XM1" & Folder & "19061180\robot\" & file
    DemoFile = MT4Path & "XM2" & Folder & "9107935\robot\" & file
    
    Call dDataCopy(LiveFile, "A1:C1000", "DailyData", "A2", file)
    Call dDataCopy(DemoFile, "A1:C1000", "DailyData", "D2", file)
    
    'Symbol Daily Datas
    Call symbolDailyDatas("AUDUSD", "G2")
    Call symbolDailyDatas("AUDCAD", "J2")
    Call symbolDailyDatas("AUDJPY", "M2")
    Call symbolDailyDatas("CADJPY", "P2")
    Call symbolDailyDatas("CHFJPY", "S2")
    Call symbolDailyDatas("EURAUD", "V2")
    Call symbolDailyDatas("EURGBP", "Y2")
    Call symbolDailyDatas("EURJPY", "AB2")
    Call symbolDailyDatas("EURUSD", "AE2")
    Call symbolDailyDatas("GBPAUD", "AH2")
    Call symbolDailyDatas("GBPCHF", "AK2")
    Call symbolDailyDatas("GBPJPY", "AN2")
    Call symbolDailyDatas("GBPUSD", "AQ2")
    Call symbolDailyDatas("GOLD", "AT2")
    Call symbolDailyDatas("NZDUSD", "AW2")
    Call symbolDailyDatas("USDCAD", "AZ2")
    Call symbolDailyDatas("USDCHF", "BC2")
    Call symbolDailyDatas("USDJPY", "BF2")
    
    '---------------------------------------------------------------------------------------
    Sheets("MasterList").Select
    Application.DisplayAlerts = True
    
    '---------------------------------------------------------------------------------------
    ' hozam chartok: kibõvíti a listát a holnapi dátumig
     Sheets("Charts").Select
     Dim réndzs As String, réndzs2 As String
        Do While Ido < Now()
            Y = Cells(Rows.Count, 1).End(xlUp).Row
            réndzs = "a" & Y & ":U" & Y
            réndzs2 = "a" & Y & ":U" & Y + 1
            Range(réndzs).Select
            Selection.AutoFill Destination:=Range(réndzs2), Type:=xlFillDefault
            Ido = Cells(Y + 1, 1)
        Loop
End Sub
Sub symbolDailyDatas(sym As String, place As String)

    MT4Path = Environ("UserProfile") & "\Documents\Tozsde\MT4ek\"
    Folder = "\MQL4\Files\csvStatement_"
    
    file = sym & "_daily.csv"
    LiveFile = MT4Path & "XM1" & Folder & "19061180\" & sym & "\" & file
    Call dDataCopy(LiveFile, "A1:C1000", "DailyData", place, file)
    
End Sub

Sub dDataCopy(path As String, rng As String, sht As String, place As String, file As String)

    Workbooks.OpenText Filename:=path, DataType:=xlDelimited, Comma:=True, Local:=True
    Range(rng).Select
    Selection.Copy
    Windows("XMRobot_19.xlsm").Activate
    Sheets(sht).Select
    Range(place).Select
    ActiveSheet.Paste
    Application.DisplayAlerts = False
    Workbooks(file).Close SaveChanges:=False
    
End Sub

Sub RobotsDailyToJson()
    
    Dim excelRange As Range
    Dim jsonItems As New Collection
    Dim jsonDictionary As New Dictionary
    Dim jsonFileObject As New FileSystemObject
    Dim jsonFileExport As TextStream
    Dim i As Long
    Dim cell As Variant
    
    Sheets("Charts").Select
    
    Set excelRange = Cells(1, 1).CurrentRegion
    
    For i = 23 To Cells(Rows.Count, 1).End(xlUp).Row
        jsonDictionary("date") = Cells(i, 1)
        If Cells(i, 4) = "" Then jsonDictionary("audusd") = "N/A" Else jsonDictionary("audusd") = Cells(i, 4)
        If Cells(i, 5) = "" Then jsonDictionary("audcad") = "N/A" Else jsonDictionary("audcad") = Cells(i, 5)
        If Cells(i, 6) = "" Then jsonDictionary("audjpy") = "N/A" Else jsonDictionary("audjpy") = Cells(i, 6)
        If Cells(i, 7) = "" Then jsonDictionary("cadjpy") = "N/A" Else jsonDictionary("cadjpy") = Cells(i, 7)
        If Cells(i, 8) = "" Then jsonDictionary("chfjpy") = "N/A" Else jsonDictionary("chfjpy") = Cells(i, 8)
        If Cells(i, 9) = "" Then jsonDictionary("euraud") = "N/A" Else jsonDictionary("euraud") = Cells(i, 9)
        If Cells(i, 10) = "" Then jsonDictionary("eurgbp") = "N/A" Else jsonDictionary("eurgbp") = Cells(i, 10)
        If Cells(i, 11) = "" Then jsonDictionary("eurjpy") = "N/A" Else jsonDictionary("eurjpy") = Cells(i, 11)
        If Cells(i, 12) = "" Then jsonDictionary("eurusd") = "N/A" Else jsonDictionary("eurusd") = Cells(i, 12)
        If Cells(i, 13) = "" Then jsonDictionary("gbpaud") = "N/A" Else jsonDictionary("gbpaud") = Cells(i, 13)
        If Cells(i, 14) = "" Then jsonDictionary("gbpchf") = "N/A" Else jsonDictionary("gbpchf") = Cells(i, 14)
        If Cells(i, 15) = "" Then jsonDictionary("gbpjpy") = "N/A" Else jsonDictionary("gbpjpy") = Cells(i, 15)
        If Cells(i, 16) = "" Then jsonDictionary("gbpusd") = "N/A" Else jsonDictionary("gbpusd") = Cells(i, 16)
        If Cells(i, 17) = "" Then jsonDictionary("gold") = "N/A" Else jsonDictionary("gold") = Cells(i, 17)
        If Cells(i, 18) = "" Then jsonDictionary("nzdusd") = "N/A" Else jsonDictionary("nzdusd") = Cells(i, 18)
        If Cells(i, 19) = "" Then jsonDictionary("usdcad") = "N/A" Else jsonDictionary("usdcad") = Cells(i, 19)
        If Cells(i, 20) = "" Then jsonDictionary("usdchf") = "N/A" Else jsonDictionary("usdchf") = Cells(i, 20)
        If Cells(i, 21) = "" Then jsonDictionary("usdjpy") = "N/A" Else jsonDictionary("usdjpy") = Cells(i, 21)



        
        jsonItems.Add jsonDictionary
        Set jsonDictionary = Nothing
        
    Next i
        
    MsgBox JsonConverter.ConvertToJson(jsonItems, Whitespace:=3)
    Set jsonFileExport = jsonFileObject.CreateTextFile("C:\wamp64\www\trade\data\robotsDaily.json", True)
    jsonFileExport.WriteLine (JsonConverter.ConvertToJson(jsonItems, Whitespace:=3))
   
    
End Sub


    



