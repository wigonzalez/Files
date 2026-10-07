VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmActivity 
   Caption         =   "Scheduled Events"
   ClientHeight    =   8490
   ClientLeft      =   1785
   ClientTop       =   1680
   ClientWidth     =   7950
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   8490
   ScaleWidth      =   7950
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdRefresh 
      Caption         =   "&Refresh"
      Height          =   375
      Left            =   4680
      TabIndex        =   5
      Top             =   0
      Width           =   1335
   End
   Begin VB.CommandButton cmdDetail 
      Caption         =   "&Correspondence"
      Height          =   375
      Left            =   3360
      TabIndex        =   4
      Top             =   0
      Width           =   1335
   End
   Begin VB.CommandButton cmdRemove 
      Caption         =   "&Remove"
      Height          =   375
      Left            =   2040
      TabIndex        =   3
      Top             =   0
      Width           =   1335
   End
   Begin VB.CommandButton cmdAddNew 
      Caption         =   "&Schedule an Event"
      Height          =   375
      Left            =   0
      TabIndex        =   2
      Top             =   0
      Width           =   2055
   End
   Begin MSComctlLib.TabStrip TabStrip1 
      Height          =   30
      Left            =   1185
      TabIndex        =   1
      Top             =   4785
      Width           =   30
      _ExtentX        =   53
      _ExtentY        =   53
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ListView lvwDB 
      Height          =   7080
      Left            =   0
      TabIndex        =   0
      Top             =   360
      Width           =   7920
      _ExtentX        =   13970
      _ExtentY        =   12488
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      Icons           =   "imlIcons"
      SmallIcons      =   "imlIcons"
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      Appearance      =   1
      NumItems        =   0
   End
   Begin MSComDlg.CommonDialog dlgDialog 
      Left            =   1680
      Top             =   7920
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      FilterIndex     =   474
      FontSize        =   8.01821e-38
   End
   Begin MSComctlLib.ImageList imlIcons 
      Left            =   240
      Top             =   7680
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   13
      ImageHeight     =   13
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   7
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":0000
            Key             =   "closed"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":0522
            Key             =   "cylinder"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":0A44
            Key             =   "leaf"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":0F66
            Key             =   "event"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":1280
            Key             =   "open"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":17A2
            Key             =   "smlBook"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmActivity.frx":1E04
            Key             =   ""
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmActivity"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private mNode As Node ' Module-level variable for Nodes
Private mItem As ListItem ' Module-level ListItem variable.
Private EventFlag As Integer ' To signal which event has occurred.
Private mCurrentIndex As Integer ' Flag to assure this node wasn't already clicked.
Public Sub LIST_PLAN_TYPES()
    ' Declare variables for the Data Access objects.
    On Error GoTo Errhandler
    Dim ObjPlanTyp As Object
    Dim LuConnectInfo As ConnectInfo
    Dim retPlanTypDm() As IndGrpPlnTypDm
    Dim x As Long: Dim Y As Long
    Dim intIndex ' Variable for index of current node.
    
    Screen.MousePointer = vbHourglass
    
    Set ObjPlanTyp = CreateObject("BarsDataService.cIndGrpPlnTypDm")
    LuConnectInfo = SetConnectionInfo
    
     
    ' Show the Progressbar.
    'prgLoad.Visible = True
    
    retPlanTypDm = ObjPlanTyp.GetData(LuConnectInfo)
    If IsArray(retPlanTypDm) Then
        x = UBound(retPlanTypDm)
    End If
    
    For Y = 0 To (x - 1)
        
        ' mNode.Tag = "Publisher" ' Identifies the table.
        ' Set the variable intIndex to the Index property of the
        ' newly created Node. Use this variable to add child
        ' Node objects to the present Node.
        intIndex = mNode.index
        
        'Set mNode = tvwDB.Nodes.Add(intIndex, tvwChild)
        'mNode.Text = rsTitles!TITLE ' Text.
        'mNode.Key = rsTitles!ISBN   ' Unique ID.
        'mNode.Tag = "Authors"       ' Table name.
        'mNode.Image = "smlBook"     ' Image from ImageList.
    Next
    ' Sort the Plan types nodes.
    ''tvwDB.Nodes(1).Sorted = True
    '' Expand top node.
    ''tvwDB.Nodes(1).Expanded = True
    
    Set ObjPlanTyp = Nothing
    
    Screen.MousePointer = vbDefault
    ' configure statusbar.
    ' PublishersStatusBar
    Exit Sub
Errhandler:
    Screen.MousePointer = vbDefault
    MsgBox Err.Description & " at procedure LIST_PLAN_TYPES", 16, "Error Message"

End Sub
Private Sub cmdAddNew_Click()
    If gintCaseNumber <> 0 Then
        frmReportSel.ShowEvents
        cmdRefresh_Click
    End If
End Sub
Private Sub cmdDetail_Click()
    lvwDB_DblClick
End Sub
Private Sub cmdRefresh_Click()
    LOAD_EVENTS
End Sub
Public Sub cmdRemove_Click()
    Dim LoBarsSchdEvnt As Object
    'Dim strKey$, varProcessDt, strAdminCd$, strEntityID$, intSeqNo%, strEntityType$
    Dim strKey$
    Dim rtnVal As Boolean
    
    Dim LuConnectInfo As ConnectInfo
    
    LuConnectInfo = SetConnectionInfo
    
    If MsgBox("Are you sure you want to remove this Scheduling?", vbQuestion + _
                vbYesNo, "Message") = vbNo Then
        Exit Sub
    End If
    
    strKey = lvwDB.SelectedItem.Key
    If Len(strKey) = 0 Then
        Exit Sub
    'Else
    '    varProcessDt = ParseString(strKey, ",", 1)
    '    strAdminCd = ParseString(strKey, ",", 2)
    '    strEntityID = ParseString(strKey, ",", 3)
    '    intSeqNo = ParseString(strKey, ",", 4)
    '    strEntityType = ParseString(strKey, ",", 5)
    End If
    Set LoBarsSchdEvnt = CreateObject("BarsDataService.cBarsSchdEvnt")
    rtnVal = LoBarsSchdEvnt.DeleteData(LuConnectInfo, strKey)
    
    Set LoBarsSchdEvnt = Nothing
    cmdRefresh_Click
End Sub
Private Sub Form_Load()
    'Centform
    
    gfrmMain.lblTitle(1).Caption = "BMS Event Activities"
    
    ' Configure ListView control.
    
    lvwDB.View = lvwReport
        
    StatusBar "Loading Event Activities..."
    
    LOAD_EVENTS
    
    StatusBar "Status"
    
    Exit Sub
errFind:
    
End Sub
Sub LOAD_EVENTS()
    Dim strCaseNumber   As String
    Dim LoBarsSchdEvnt  As Object
    Dim LuConnectInfo   As ConnectInfo
    Dim RetArray()      As BarsSchdEvnt
    Dim x, Y As Long

    Screen.MousePointer = vbHourglass
    
    MakeColumns
        
    Set LoBarsSchdEvnt = CreateObject("BarsDataService.cBarsSchdEvnt")
    LuConnectInfo = SetConnectionInfo
    
    RetArray() = LoBarsSchdEvnt.GetDataClient(LuConnectInfo, gstrClientId, gintCaseNumber)
    If IsArray(RetArray) Then
        x = UBound(RetArray)
    End If

    'Do Until Obj.EOF
    For Y = 0 To (x - 1)
                
           Set mItem = lvwDB.ListItems.Add(, CStr(RetArray(Y).SchdEvntTs), Format(RetArray(Y).SchdPrcsDt, "mm/dd/yyyy"), "event", "event")
             
           ' 2nd "event" icon shows along with listdetail
            mItem.SubItems(1) = RetArray(Y).EvntTypTxt_Ext
            mItem.SubItems(2) = RetArray(Y).EVNTID
            If IsDate(RetArray(Y).ActPrcsDt) Then
  
                mItem.SubItems(3) = "Processed..."
            Else
                mItem.SubItems(3) = "Waiting..."
            End If
            mItem.SubItems(4) = Format(RetArray(Y).RptEndDt, "mm/dd/yyyy")
            mItem.SubItems(5) = IIf(IsNull(RetArray(Y).AdmnrACIDId), "", RetArray(Y).AdmnrACIDId)
            mItem.SubItems(6) = IIf(IsNull(RetArray(Y).SchdAcidId), "", RetArray(Y).SchdAcidId)
    Next
            
    Screen.MousePointer = vbDefault
End Sub
Private Sub Form_Resize()
    lvwDB.Width = Me.Width - 100
    lvwDB.height = Me.height - 100
    
End Sub
Private Sub lvwDB_ColumnClick(ByVal ColumnHeader As ColumnHeader)
    lvwDB.SortKey = ColumnHeader.index - 1
    ' Set Sorted to True to sort the list.
    lvwDB.Sorted = True

End Sub
Private Sub lvwDB_DblClick()
    Screen.MousePointer = vbHourglass
    Dim strKey As String
    Dim sEvent As String
    strKey = lvwDB.SelectedItem.Key
    sEvent = Trim$(lvwDB.SelectedItem.SubItems(2))
    If Len(strKey) = 0 Then
        Exit Sub
    Else
        frmEvntDet.AllowCustomize = False
        frmEvntDet.CompositeString = lvwDB.SelectedItem.Tag
        frmEvntDet.EVNTID = sEvent
        frmEvntDet.TIMESTAMP = strKey
    End If
    frmEvntDet.SetEventlabel (lvwDB.SelectedItem.SubItems(1))
    frmEvntDet.Show 1
    Screen.MousePointer = vbDefault
End Sub
Private Sub lvwDB_ItemClick(ByVal Item As ListItem)
   ' GetData (Item.Key)
   
End Sub
Private Sub tvwDB_Collapse(ByVal Node As Node)
    If Node.Tag = "Publisher" Or Node.index = 1 _
    Then Node.Image = "closed"
End Sub
Private Sub tvwDB_Expand(ByVal Node As Node)
    If Node.Tag = "Publisher" Or Node.index = 1 Then
        Node.Image = "open"
        Node.Sorted = True
    End If
   
End Sub
Private Sub MakeColumns()
    ' Clear the data
    lvwDB.ListItems.Clear
    ' Clear the ColumnHeaders collection.
    lvwDB.ColumnHeaders.Clear
    ' Add four ColumnHeaders.
    lvwDB.ColumnHeaders.Add , , "Scheduled Date", 1335
    lvwDB.ColumnHeaders.Add , , "Event", 3000
    lvwDB.ColumnHeaders.Add , , "Event ID", 1000
    lvwDB.ColumnHeaders.Add , , "Status", 1100
    lvwDB.ColumnHeaders.Add , , "Schedule as of Date", 1500
    lvwDB.ColumnHeaders.Add , , "Administrator", 1300
    lvwDB.ColumnHeaders.Add , , "Operator", 1300
    
End Sub
Private Sub tvwDB_NodeClick(ByVal Node As Node)

End Sub
Private Sub lvwDB_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
    Screen.MousePointer = vbDefault
End Sub

