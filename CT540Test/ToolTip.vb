Option Strict Off
Option Explicit On
Friend Class ToolTip
	
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function CreateWindowEx Lib "USER32"  Alias "CreateWindowExA"(ByVal dwExStyle As Integer, ByVal lpClassName As String, ByVal lpWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWndParent As Integer, ByVal hMenu As Integer, ByVal hInstance As Integer, ByRef lpParam As Any) As Integer
	Private Declare Function CallWindowProc Lib "USER32"  Alias "CallWindowProcA"(ByVal wndProc As Integer, ByVal hWnd As Integer, ByVal uMsg As Short, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	Private Declare Function SetWindowPos Lib "USER32" (ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal CX As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
	Private Declare Function DestroyWindow Lib "USER32" (ByVal hWnd As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function SendMessage Lib "USER32"  Alias "SendMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer
	Private Declare Function SendMessageByString Lib "USER32"  Alias "SendMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
	Private Declare Function GetWindowLong Lib "USER32"  Alias "GetWindowLongA"(ByVal hWnd As Integer, ByVal nIndex As Integer) As Integer
	Private Declare Function SetWindowLong Lib "USER32"  Alias "SetWindowLongA"(ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	Private Declare Function GetSysColor Lib "USER32" (ByVal nIndex As Integer) As Integer
	Private Declare Function GetStockObject Lib "GDI32" (ByVal nIndex As Integer) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function PtInRect Lib "USER32" (ByRef r As RECT, ByVal x As Integer, ByVal y As Integer) As Integer
	
	
	
	Dim m_toolTipWnd As Integer
	Dim m_parentWnd As Integer
	Dim m_hInst As Integer
	Dim m_rect As RECT
	Dim m_nID As Integer
	Dim m_tooltipText As String
	
	Private Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	Private Structure POINT
		Dim x As Short
		Dim y As Short
	End Structure
	
	Private Structure TOOLINFO
		Dim cbSize As Integer
		Dim uFlags As Integer
		Dim hWnd As Integer
		Dim uId As Integer
		Dim r As RECT
		Dim hinst As Integer
		Dim lpszText As String
	End Structure
	
	
	Const TOOLTIPS_CLASS As String = "tooltips_class32"
	
	Const STATIC_CLASS As String = "Static"
	Private Const WS_VISIBLE As Integer = &H10000000
	Private Const WS_CHILD As Integer = &H40000000
	Private Const WM_SETTEXT As Integer = &HC
	Private Const GWL_WNDPROC As Short = (-4)
	Private Const WM_USER As Integer = &H400
	
	Private Const TTS_NOPREFIX As Integer = &H2
	Private Const TTF_TRANSPARENT As Integer = &H100
	Private Const TTF_CENTERTIP As Integer = &H2
	Private Const TTM_ADDTOOL As Decimal = (WM_USER + 4)
	Private Const TTM_DELTOOL As Decimal = WM_USER + 5
	Private Const TTM_ACTIVATE As Decimal = WM_USER + 1
	Private Const TTM_UPDATETIPTEXTA As Decimal = (WM_USER + 12)
	Private Const TTM_SETMAXTIPWIDTH As Decimal = (WM_USER + 24)
	Private Const TTM_SETTIPBKCOLOR As Decimal = (WM_USER + 19)
	Private Const TTM_SETTIPTEXTCOLOR As Decimal = (WM_USER + 20)
	Private Const TTM_SETTITLE As Decimal = (WM_USER + 32)
	Private Const TTS_BALLOON As Integer = &H40
	Private Const TTS_ALWAYSTIP As Integer = &H1
	Private Const TTF_SUBCLASS As Integer = &H10
	Private Const TTF_IDISHWND As Integer = &H1
	Private Const TTM_SETDELAYTIME As Decimal = (WM_USER + 3)
	Private Const TTDT_AUTOPOP As Short = 2
	Private Const TTDT_INITIAL As Short = 3
	Private Const TTN_FIRST As Short = (-520)
	Private Const TTN_SHOW As Short = (TTN_FIRST - 1)
	
	Private Const GWL_STYLE As Short = (-16)
	Private Const WS_BORDER As Integer = &H800000
	Private Const CW_USEDEFAULT As Integer = &H80000000
	Private Const WS_POPUP As Integer = &H80000000
	
	
	Private Const HWND_TOPMOST As Short = -1
	Private Const HWND_NOTOPMOST As Short = -2
	Private Const SWP_NOSIZE As Integer = &H1
	Private Const SWP_NOMOVE As Integer = &H2
	Private Const SWP_NOACTIVATE As Integer = &H10
	Private Const SWP_SHOWWINDOW As Integer = &H40
	
	
	Private Const COLOR_INFOTEXT As Short = 23
	Private Const COLOR_INFOBK As Short = 24
	Private Const COLOR_GRAYTEXT As Short = 17
	Private Const COLOR_3DLIGHT As Short = 22
	Private Const DKGRAY_BRUSH As Short = 3
	
	Public Function GetDefaultBalloonColor() As Integer
		GetDefaultBalloonColor = GetSysColor(COLOR_INFOBK)
	End Function
	
	Public Function GetDefaultTextColor() As Integer
		GetDefaultTextColor = GetSysColor(COLOR_INFOTEXT)
	End Function
	
	Public Function GetDefaultBorderColor() As Integer
		GetDefaultBorderColor = GetStockObject(DKGRAY_BRUSH)
	End Function
	Public Function PointInBounds(ByRef x As Short, ByRef y As Short) As Boolean
		Dim testPt As POINT
		
		testPt.x = x
		testPt.y = y
		PointInBounds = PtInRect(m_rect, x, y)
		
	End Function
	Public Function CreateToolTip(ByVal hWndParent As Integer, ByVal hInstance As Integer, ByVal toolText As String, ByVal toolID As Integer, ByVal x As Integer, ByVal y As Integer, ByVal CX As Integer, ByVal cy As Integer) As Integer
		Dim lngStyle As Integer
		Dim typTI As TOOLINFO
		Dim result As Integer
		
		m_rect.Left_Renamed = x
		m_rect.Top = y
		m_rect.Right_Renamed = x + CX
		m_rect.Bottom = y + cy
		m_tooltipText = toolText
		
		With typTI
			.cbSize = Len(typTI)
			.uFlags = TTF_SUBCLASS 'TTF_IDISHWND + TTF_SUBCLASS
			.hWnd = hWndParent
			.uId = toolID
			.lpszText = toolText
			'UPGRADE_WARNING: Couldn't resolve default property of object typTI.r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.r = m_rect
		End With
		
		If m_toolTipWnd = 0 And hWndParent <> 0 Then
			m_toolTipWnd = CreateWindowEx(0, TOOLTIPS_CLASS, CStr(0), WS_POPUP Or TTS_NOPREFIX Or TTS_ALWAYSTIP, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, hWndParent, 0, hInstance, 0)
			result = SetWindowPos(m_toolTipWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOACTIVATE)
			result = SendMessage(m_toolTipWnd, TTM_SETMAXTIPWIDTH, 0, 80)
			'UPGRADE_WARNING: Couldn't resolve default property of object typTI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SendMessage(m_toolTipWnd, TTM_ADDTOOL, 0, typTI)
			m_parentWnd = hWndParent
			m_hInst = hInstance
			m_nID = toolID
		End If
		
		CreateToolTip = m_toolTipWnd
	End Function
	
	Public Sub DestroyToolTip()
		Dim typTI As TOOLINFO
		If m_toolTipWnd > 0 Then
			With typTI
				.cbSize = Len(typTI)
				.uFlags = TTF_SUBCLASS 'TTF_IDISHWND + TTF_SUBCLASS
				.hWnd = m_parentWnd
				'.uId = pobjTip.ControlhWnd
				.lpszText = CStr(0)
			End With
			'UPGRADE_WARNING: Couldn't resolve default property of object typTI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SendMessage(m_toolTipWnd, TTM_DELTOOL, 0, typTI)
			DestroyWindow(m_toolTipWnd)
			m_toolTipWnd = 0
		End If
	End Sub
	
	Public Sub SetToolTipText(ByVal text As String)
		DestroyToolTip()
		CreateToolTip(m_parentWnd, m_hInst, text, m_nID, m_rect.Left_Renamed, m_rect.Top, m_rect.Right_Renamed, m_rect.Bottom)
	End Sub
	Public Function GetToolTipText() As String
		GetToolTipText = m_tooltipText
		
	End Function
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		m_toolTipWnd = 0
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		DestroyToolTip()
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
End Class