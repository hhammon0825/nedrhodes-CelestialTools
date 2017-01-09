Option Strict Off
Option Explicit On
'UPGRADE_NOTE: Print was upgraded to Print_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Module Print_Renamed
	Private Const RASTERCAPS As Integer = 38
	Private Const RC_PALETTE As Integer = &H100
	Private Const SIZEPALETTE As Integer = 104
	Private Const LOGPIXELSX As Integer = 88
	Private Const LOGPIXELSY As Integer = 90
    Private Const SRCCOPY = &HCC0020
    Public FormHeight, FormWidth As Double
    Private Structure PicBmp
		Dim Size As Integer
		Dim Type As Integer
		Dim hBmp As Integer
		Dim hPal As Integer
		Dim Reserved As Integer
	End Structure
	
	Private Structure GUID
		Dim Data1 As Integer
		Dim Data2 As Short
        Dim Data3 As Short
        <VBFixedArray(7)> Dim Data4() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim Data4(7)
		End Sub
	End Structure
	
	
	Private Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	Private Structure PALETTEENTRY
		Dim peRed As Byte
		Dim peGreen As Byte
		Dim peBlue As Byte
		Dim peFlags As Byte
	End Structure
	
	Private Structure LOGPALETTE
		Dim palVersion As Short
		Dim palNumEntries As Short
		<VBFixedArray(255)> Dim palPalEntry() As PALETTEENTRY ' Enough for 256 colors.
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim palPalEntry(255)
		End Sub
	End Structure
	
	
	'UPGRADE_WARNING: Structure IPicture may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure GUID may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure PicBmp may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function OleCreatePictureIndirect Lib "olepro32.dll" (ByRef PicDesc As PicBmp, ByRef RefIID As GUID, ByVal fPictureOwnsHandle As Integer, ByRef IPic As System.Drawing.Image) As Integer
	
	Private Declare Function CreateCompatibleDC Lib "GDI32" (ByVal hDC As Integer) As Integer
	Private Declare Function CreateCompatibleBitmap Lib "GDI32" (ByVal hDC As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
	Private Declare Function GetDeviceCaps Lib "GDI32" (ByVal hDC As Integer, ByVal iCapabilitiy As Integer) As Integer
	'UPGRADE_WARNING: Structure PALETTEENTRY may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetSystemPaletteEntries Lib "GDI32" (ByVal hDC As Integer, ByVal wStartIndex As Integer, ByVal wNumEntries As Integer, ByRef lpPaletteEntries As PALETTEENTRY) As Integer
	'UPGRADE_WARNING: Structure LOGPALETTE may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreatePalette Lib "GDI32" (ByRef lpLogPalette As LOGPALETTE) As Integer
	Private Declare Function SelectObject Lib "GDI32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
	Private Declare Function BitBlt Lib "GDI32" (ByVal hDCDest As Integer, ByVal XDest As Integer, ByVal YDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hDCSrc As Integer, ByVal XSrc As Integer, ByVal YSrc As Integer, ByVal dwRop As Integer) As Integer
	Private Declare Function DeleteDC Lib "GDI32" (ByVal hDC As Integer) As Integer
	Private Declare Function GetForegroundWindow Lib "USER32" () As Integer
	Private Declare Function SelectPalette Lib "GDI32" (ByVal hDC As Integer, ByVal hPalette As Integer, ByVal bForceBackground As Integer) As Integer
	Private Declare Function RealizePalette Lib "GDI32" (ByVal hDC As Integer) As Integer
	Private Declare Function GetWindowDC Lib "USER32" (ByVal hWnd As Integer) As Integer
	Private Declare Function GetDC Lib "USER32" (ByVal hWnd As Integer) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetWindowRect Lib "USER32" (ByVal hWnd As Integer, ByRef lpRect As RECT) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetClientRect Lib "USER32" (ByVal hWnd As Integer, ByRef lpRect As RECT) As Integer
	Private Declare Function ReleaseDC Lib "USER32" (ByVal hWnd As Integer, ByVal hDC As Integer) As Integer
	Private Declare Function GetDesktopWindow Lib "USER32" () As Integer
	
	
	Public Function CreateBitmapPicture(ByVal hBmp As Integer, ByVal hPal As Integer) As System.Drawing.Image
		
		Dim r As Integer
		Dim pic As PicBmp
		' IPicture requires a reference to "Standard OLE Types."
		Dim IPic As System.Drawing.Image
        'UPGRADE_WARNING: Arrays in structure IID_IDispatch may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim IID_IDispatch As New GUID


        ' Fill in with IDispatch Interface ID.
        With IID_IDispatch
			.Data1 = &H20400
			.Data4(0) = &HC0
			.Data4(7) = &H46
		End With

        ' Fill Pic with necessary parts.
        Dim vbPicTypeBitmap As Integer = 1
        With pic
			.Size = Len(pic) ' Length of structure.
            .Type = vbPicTypeBitmap ' Type of Picture (bitmap).
            .hBmp = hBmp ' Handle to bitmap.
			.hPal = hPal ' Handle to palette (may be null).
		End With
		
		' Create Picture object.
		r = OleCreatePictureIndirect(pic, IID_IDispatch, 1, IPic)
		
		' Return the new Picture object.
		CreateBitmapPicture = IPic
	End Function


    Public Function CaptureWindow(ByVal hWndSrc As Integer, ByVal Client As Boolean, ByVal LeftSrc As Integer, ByVal TopSrc As Integer, ByVal WidthSrc As Integer, ByVal HeightSrc As Integer) As System.Drawing.Image

        Dim hDCMemory As Integer
        Dim hBmp As Integer
        Dim hBmpPrev As Integer
        Dim r As Integer
        Dim hDCSrc As Integer
        Dim hPal As Integer
        Dim hPalPrev As Integer
        Dim RasterCapsScrn As Integer
        Dim HasPaletteScrn As Integer
        Dim PaletteSizeScrn As Integer
        'UPGRADE_WARNING: Arrays in structure LogPal may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim LogPal As LOGPALETTE

        ' Depending on the value of Client get the proper device context.
        If Client Then
            hDCSrc = GetDC(hWndSrc) ' Get device context for client area.
        Else
            hDCSrc = GetWindowDC(hWndSrc) ' Get device context for entire
            ' window.
        End If

        ' Create a memory device context for the copy process.
        hDCMemory = CreateCompatibleDC(hDCSrc)
        ' Create a bitmap and place it in the memory DC.
        hBmp = CreateCompatibleBitmap(hDCSrc, WidthSrc, HeightSrc)
        hBmpPrev = SelectObject(hDCMemory, hBmp)

        ' Get screen properties.
        RasterCapsScrn = GetDeviceCaps(hDCSrc, RASTERCAPS) ' Raster
        ' capabilities.
        HasPaletteScrn = RasterCapsScrn And RC_PALETTE ' Palette
        ' support.
        PaletteSizeScrn = GetDeviceCaps(hDCSrc, SIZEPALETTE) ' Size of
        ' palette.

        ' If the screen has a palette make a copy and realize it.
        If HasPaletteScrn And (PaletteSizeScrn = 256) Then
            ' Create a copy of the system palette.
            LogPal.palVersion = &H300
            LogPal.palNumEntries = 256
            r = GetSystemPaletteEntries(hDCSrc, 0, 256, LogPal.palPalEntry(0))
            hPal = CreatePalette(LogPal)
            ' Select the new palette into the memory DC and realize it.
            hPalPrev = SelectPalette(hDCMemory, hPal, 0)
            r = RealizePalette(hDCMemory)
        End If

        ' Copy the on-screen image into the memory DC.
        'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        r = BitBlt(hDCMemory, 0, 0, WidthSrc, HeightSrc, hDCSrc, LeftSrc, TopSrc, SRCCOPY)

        ' Remove the new copy of the  on-screen image.
        hBmp = SelectObject(hDCMemory, hBmpPrev)

        ' If the screen has a palette get back the palette that was
        ' selected in previously.
        If HasPaletteScrn And (PaletteSizeScrn = 256) Then
            hPal = SelectPalette(hDCMemory, hPalPrev, 0)
        End If

        ' Release the device context resources back to the system.
        r = DeleteDC(hDCMemory)
        r = ReleaseDC(hWndSrc, hDCSrc)

        ' CreateBitmapPicture to create a picture object from the
        ' bitmap and palette handles. Then return the resulting picture
        ' object.
        CaptureWindow = CreateBitmapPicture(hBmp, hPal)
    End Function
    Public Sub PrintScreen()
		Dim Printer As New Printer
		Dim lWidth, lHeight As Integer
		Dim clipPicture As System.Drawing.Image
		Dim hForWnd As Integer
		Dim winRect As RECT
		Dim r As Integer
		Dim hDC As Integer
		Dim prtScaleX As Object
		Dim prtScaleY As Integer
		Dim dw As Object
		Dim dh As Double
		Dim winx As Object
		Dim winy As Integer
		
		
		hForWnd = GetForegroundWindow
		
		r = GetWindowRect(hForWnd, winRect)
		'UPGRADE_WARNING: Couldn't resolve default property of object winx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		winx = winRect.Right_Renamed - winRect.Left_Renamed
		winy = winRect.Bottom - winRect.Top
		
		hDC = GetDC(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object prtScaleX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		prtScaleX = GetDeviceCaps(hDC, LOGPIXELSX)
		prtScaleY = GetDeviceCaps(hDC, LOGPIXELSY)
		r = ReleaseDC(0, hDC)
		'UPGRADE_WARNING: Couldn't resolve default property of object winx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		clipPicture = CaptureWindow(hForWnd, False, 0, 0, winx, winy)
		
		Printer.Print()
		Printer.ScaleMode = ScaleModeConstants.vbTwips
		'UPGRADE_WARNING: Couldn't resolve default property of object prtScaleX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object winx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object dw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dw = winx / prtScaleX
		dh = winy / prtScaleY
		
		'convert to twips
		'UPGRADE_WARNING: Couldn't resolve default property of object dw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FormWidth = dw * 1440
		FormHeight = dh * 1440
		
		If FormWidth > Printer.ScaleWidth Then
			lWidth = Printer.ScaleWidth
			lHeight = (Printer.ScaleWidth / FormWidth) * FormHeight
		Else
			lWidth = FormWidth
			lHeight = FormHeight
		End If
		
		
		Printer.PaintPicture(clipPicture, (Printer.Width - lWidth) / 2, (Printer.Height - lHeight) / 2, lWidth, lHeight)
		
		Printer.EndDoc()
		
	End Sub
End Module