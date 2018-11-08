VERSION 5.00
Begin VB.Form FormSzövegFájl 
   AutoRedraw      =   -1  'True
   Caption         =   "SzövegFájl"
   ClientHeight    =   2880
   ClientLeft      =   48
   ClientTop       =   336
   ClientWidth     =   5016
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   238
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   2880
   ScaleWidth      =   5016
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton GombBeolvas 
      Caption         =   "&Beolvas"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   372
      Left            =   2520
      TabIndex        =   0
      Top             =   1080
      Width           =   1212
   End
End
Attribute VB_Name = "FormSzövegFájl"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
' több példa
'   szövegfájl beolvasása
'   Split függvény használatára
'   FormatNumber használatára
' FIGYELEM! A Timer használata nem szabatos (ha a két végrehajtása közé esik
'   éjfél, akkor hibás eredményt ad)
Dim FájlRendszer As FileSystemObject, SzövegFájl As TextStream
' dinamikus karakterlánctömbök
Dim STömb() As String, STömb2() As String
' az STömb indexe long legyen, mert bizony 32 ezer sornál több is elõfordulhat
Dim i As Long, MaxSorhossz As Long, FájlNév As String, Idõ As Single
' a For Each ciklus csak variant típusú ciklusváltozót fogad el
Dim V

Private Sub GombBeolvas_Click()
' he-he, jó kis szövegfájl, mi?
FájlNév = App.EXEName & ".frm"
If FájlRendszer.FileExists(FájlNév) Then
  Print "Kis türelmet..."
  MousePointer = vbHourglass: GombBeolvas.Enabled = False
  Idõ = Timer: DoEvents
  Set SzövegFájl = FájlRendszer.OpenTextFile(FájlNév)
  ' a Split az elsõ paraméterében megadott karakterláncot szeleteli fel
  ' a második paraméterben megadott karakterlánc "mentén"
  STömb = Split(SzövegFájl.ReadAll, vbNewLine): SzövegFájl.Close
  ' kész vagyunk, az STömb nevû karakterlánctömbben van a szövegfájl,
  ' a tömb minden eleme a szöveg egy-egy sora
  
  ' egyik példa a FormatNumber használatára,
  ' a FormatNumber a Vezérlõpult "Területi beállítások" beállításait használja
  Me.Cls: Print "Beolvasás ideje: " & FormatNumber(Timer - Idõ)
  MousePointer = vbDefault: GombBeolvas.Enabled = True: DoEvents
  
  ' másik példa a FormatNumber használatára,
  ' itt felülbíráljuk a Vezérlõpult "Területi beállítások"-ban megadott
  ' tizedesjegyek számát
  Print "Sorok száma: " & FormatNumber(UBound(STömb) - LBound(STömb) + 1, 0)
  
  ' leghosszabb sor hosszának megállapítása
  MaxSorhossz = 0
  For Each V In STömb
    If Len(V) > MaxSorhossz Then MaxSorhossz = Len(V)
  Next
  Print "Leghosszabb sor hossza: " & FormatNumber(MaxSorhossz, 0)
  
  ' példa válogatásra:
  '   STömb2-ben azok a sorok lesznek, amelyek tartalmazzák a második
  '   paraméterként megadott karakterláncot
  STömb2 = Filter(STömb, "valami")
Else
  MsgBox " Nem létezõ fájl: " & FájlNév: Beep
End If
End Sub

Private Sub Form_Load()
' a kötelezõ penzum
Set FájlRendszer = CreateObject("Scripting.FileSystemObject")
End Sub

Private Sub Form_Unload(Cancel As Integer)
' kitakarítunk
Set FájlRendszer = Nothing: Set SzövegFájl = Nothing
End Sub


