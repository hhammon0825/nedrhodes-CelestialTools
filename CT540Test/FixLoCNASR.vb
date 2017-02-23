Option Strict Off
Option Explicit On
Friend Class Form11
	Inherits System.Windows.Forms.Form
	Dim TimeOfFix, IL, i, FixIL As Short
	Dim Pi As Double
	Dim XZH(12) As Object
	Dim XZM(12) As Object
	Dim XZT(12) As Short
	Dim XZN(12) As Object
	Dim XMI(12) As Object
	Dim XL(12) As Object
	Dim XLo(12) As Object
	Dim BI, BF, LI, LF, BD, DF, BM As Double
	Dim EX, CX, AX, BX, DX, GX As Double
	'Dim XType(12) As Variant, XAPL(12) As Variant, XAPLo(12) As Variant
	Dim FD, CheckCount As Short
	Dim FM As Double
	Dim LH, BH As String
	Dim CourseAngleDeg, Lm, LatDiff, LongDiff, CourseAngle, Course As Double
	
	
	Private Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
		'UPGRADE_ISSUE: Form method Form11.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls() 'This prevents writing on top of old sight
		'UPGRADE_ISSUE: Form property Form11.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 1000
		
		IL = 0
		
		If Check1.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData1(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData1(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XZN(IL) = Form8.FixData1(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XMI(IL) = Form8.FixData1(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XL(IL) = Form8.FixData1(2)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XLo(IL) = Form8.FixData1(3) ': XType(IL) = Form8.FixData1(10): XAPL(IL) = Form8.FixData1(4): XAPLo(IL) = Form8.FixData1(6)
		If Check2.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData2(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData2(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XZN(IL) = Form8.FixData2(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XMI(IL) = Form8.FixData2(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XL(IL) = Form8.FixData2(2)
		'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XLo(IL) = Form8.FixData2(3) ': XType(IL) = Form8.FixData2(10): XAPL(IL) = Form8.FixData2(4): XAPLo(IL) = Form8.FixData2(6)
		If Check3.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData3(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData3(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData3(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData3(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData3(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData3(3)
		End If ': XType(IL) = Form8.FixData3(10): XAPL(IL) = Form8.FixData3(4): XAPLo(IL) = Form8.FixData3(6)
		If Check4.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData4(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData4(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData4(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData4(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData4(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData4(3)
		End If ': XType(IL) = Form8.FixData4(10): XAPL(IL) = Form8.FixData4(4): XAPLo(IL) = Form8.FixData4(6)
		If Check5.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData5(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData5(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData5(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData5(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData5(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData5(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData5(3)
		End If ': XType(IL) = Form8.FixData5(10): XAPL(IL) = Form8.FixData5(4): XAPLo(IL) = Form8.FixData5(6)
		If Check6.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData6(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData6(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData6(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData6(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData6(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData6(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData6(3)
		End If ': XType(IL) = Form8.FixData6(10): XAPL(IL) = Form8.FixData6(4): XAPLo(IL) = Form8.FixData6(6)
		If Check7.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData7(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData7(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData7(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData7(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData7(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData7(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData7(3)
		End If ': XType(IL) = Form8.FixData7(10): XAPL(IL) = Form8.FixData7(4): XAPLo(IL) = Form8.FixData7(6)
		If Check8.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData8(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData8(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData8(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData8(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData8(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData8(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData8(3)
		End If ': XType(IL) = Form8.FixData8(10): XAPL(IL) = Form8.FixData8(4): XAPLo(IL) = Form8.FixData8(6)
		If Check9.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData9(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData9(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData9(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData9(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData9(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData9(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData9(3)
		End If ': XType(IL) = Form8.FixData9(10): XAPL(IL) = Form8.FixData9(4): XAPLo(IL) = Form8.FixData9(6)
		If Check10.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData10(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData10(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData10(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData10(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData10(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData10(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData10(3)
		End If ': XType(IL) = Form8.FixData10(10): XAPL(IL) = Form8.FixData10(4): XAPLo(IL) = Form8.FixData10(6)
		If Check11.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData11(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData11(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData11(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData11(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData11(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData11(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData11(3)
		End If ': XType(IL) = Form8.FixData11(11): XAPL(IL) = Form8.FixData11(4): XAPLo(IL) = Form8.FixData11(6)
		If Check12.CheckState = 1 Then
			IL = IL + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZH(IL) = Form8.FixData12(4)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZM(IL) = Form8.FixData12(5)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZM(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZT(IL) = Val(XZH(IL) + XZM(IL))
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XZN(IL) = Form8.FixData12(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XMI(IL) = Form8.FixData12(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XL(IL) = Form8.FixData12(2)
			'UPGRADE_WARNING: Couldn't resolve default property of object Form8.FixData12(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			XLo(IL) = Form8.FixData12(3)
		End If ': XType(IL) = Form8.FixData12(12): XAPL(IL) = Form8.FixData12(4): XAPLo(IL) = Form8.FixData12(6)
		
		Form8.WriteFixScreen()
		If IL < 2 Then MsgBox("You must select at least two sights.") : Exit Sub
		'Check if all sights have or do not have times
		CheckCount = 0
		For i = 1 To IL
			'UPGRADE_WARNING: Couldn't resolve default property of object XZH(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If XZH(i) <> "" Then CheckCount = CheckCount + 1
		Next i
		If CheckCount <> IL And CheckCount <> 0 Then MsgBox("Do not mix sights having times with sights not having times.") : Exit Sub
		
		'Time of fix is latest time of selected sights
		TimeOfFix = 0 : FixIL = 0
		For i = 1 To IL
			If XZT(i) > TimeOfFix Then TimeOfFix = XZT(i) : FixIL = i
		Next i
		'L and Lo of latest of selected sights
		'UPGRADE_WARNING: Couldn't resolve default property of object XL(FixIL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BF = XL(FixIL)
		'UPGRADE_WARNING: Couldn't resolve default property of object XLo(FixIL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		LF = XLo(FixIL)
		
		'Rem  calculate fix
		AX = 0 : BX = 0 : CX = 0 : DX = 0 : EX = 0 : GX = 0
		For i = 1 To IL
			'If XType(i) = "LoC" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object XL(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BF = XL(IL)
			'UPGRADE_WARNING: Couldn't resolve default property of object XLo(IL). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			LF = XLo(IL) 'this line not in srf fix
			'If XType(i) = "NASR" Then BF = XAPL(IL): LF = XAPLo(IL)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			AX = AX + (System.Math.Cos(XZN(i) * Pi / 180)) ^ 2
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BX = BX + System.Math.Cos(XZN(i) * Pi / 180) * System.Math.Sin(XZN(i) * Pi / 180)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CX = CX + (System.Math.Sin(XZN(i) * Pi / 180)) ^ 2
			'XMI(i) = -XMI(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DX = DX + (XMI(i) / 60) * System.Math.Cos(XZN(i) * Pi / 180) 'XMI(I) was AF(I)
			'UPGRADE_WARNING: Couldn't resolve default property of object XZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object XMI(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			EX = EX + (XMI(i) / 60) * System.Math.Sin(XZN(i) * Pi / 180) 'XMI(I) was AF(I)
			'Line2000:                                                       'this line not in srf fix
		Next i
		GX = AX * CX - BX * BX : If GX = 0 Then GoTo Line2200
		'    i = 0
		'Line1849:
		'    i = i + 1: If i = 100 Then GoTo Line2200
		LI = LF + (AX * EX - BX * DX) / (GX * System.Math.Cos(BF * Pi / 180))
		BI = BF - (CX * DX - BX * EX) / GX 'Sign is correct for sign of XMI
		DF = 60 * System.Math.Sqrt((LI - LF) ^ 2 * (System.Math.Cos(BF * Pi / 180)) ^ 2 + (BI - BF) ^ 2)
		
		'Debug.Print "I = "; i; "  LF = "; LF; "  BF = "; BF; "  LI = "; LI; "  BI = "; BI; "   DF = "; DF
		'    If DF > 20 Then LF = LI: BF = BI: GoTo Line1849
		DF = Int(DF * 10 + 0.5) / 10
		If System.Math.Abs(LI) > 180 Then LI = -System.Math.Sign(LI) * (360 - System.Math.Abs(LI)) 'In case fix is on other side of IDL
		'What if fix is on other side of equator?
		BD = Int(System.Math.Abs(BI)) : BM = (System.Math.Abs(BI) - BD) * 60 : BM = Int(BM * 10 + 0.5) / 10 : If BM = 60 Then BM = 0 : BD = BD + 1
		BH = "N" : If BI < 0 Then BH = "S"
		If BI = 0 Then BH = " "
		FD = Int(System.Math.Abs(LI)) : FM = (System.Math.Abs(LI) - FD) * 60 : FM = Int(FM * 10 + 0.5) / 10 : If FM = 60 Then FM = 0 : FD = FD + 1
		LH = "W" : If LI < 0 Then LH = "E"
		If LI = 0 Then LH = " "
		'Calculate bearing using mid-latitude sailing
		LatDiff = BI - BF
		LongDiff = LI - LF
		'Crossing IDL
		If System.Math.Abs(LongDiff) > 180 Then LongDiff = -System.Math.Sign(LongDiff) * (360 - System.Math.Abs(LongDiff))
		Lm = (BI + BF) / 2 'Mid-latitude       BF WAS BD BEFORE V4.2.0
		If LatDiff = 0 Then CourseAngle = Pi / 2 Else CourseAngle = System.Math.Abs(System.Math.Atan((LongDiff * 60 * System.Math.Cos(Lm * Pi / 180)) / (LatDiff * 60)))
		CourseAngleDeg = CourseAngle * 180 / Pi
		'CourseAngleDeg = CourseAngle * 180 / Pi
		If LatDiff >= 0 And LongDiff < 0 Then Course = System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
		If LatDiff >= 0 And LongDiff >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
		If LatDiff < 0 And LongDiff < 0 Then Course = 180 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
		If LatDiff < 0 And LongDiff >= 0 Then Course = 180 + System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
		Course = Int(Course + 0.5)
        txtLoCFix.Clear()
        'BEEP
        If CheckCount <> 0 Then
            txtLoCFix.Text = ("Fix at Time = " & Format(XZH(FixIL), "00") & Format(XZM(FixIL), "00")) & vbNewLine
        End If
        txtLoCFix.Text = ("Fix L  =  " & Format(BD, "#0") & Chr(176) & Format(BM, "00.0") & "'" & BH) & vbNewLine
        txtLoCFix.Text = ("Fix Lo = " & Format(FD, "##0") & Chr(176) & Format(FM, "00.0") & "'" & LH) & vbNewLine
        txtLoCFix.Text = ("Fix is " & Format(DF, "##0.0") & " nautical miles from DR")
        If DF <> 0 Then
            txtLoCFix.Text = (", at a bearing of " & Format(Course, "000") & Chr(176) & " True")
        End If

        Exit Sub
        'If IH = 2 Then Print #2,: Print #2,: IH = 1: GoTo 1915
Line2200:
        txtLoCFix.Text = ("Fix cannot be established.") & vbNewLine
        txtLoCFix.Text = ("Selected sights have unacceptable cuts or excessively large intercepts.")
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        '    Printer.ColorMode = vbPRCMMonochrome
        '    Form1.PrintForm
        '    Printer.ColorMode = vbPRCMColor
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
        Check1.Visible = False ': Check1.Enabled = False
        Check2.Visible = False ': Check2.Enabled = False
        Check3.Visible = False ': Check3.Enabled = False
        Check4.Visible = False ': Check4.Enabled = False
        Check5.Visible = False ': Check5.Enabled = False
        Check6.Visible = False ': Check6.Enabled = False
        Check7.Visible = False ': Check7.Enabled = False
        Check8.Visible = False ': Check8.Enabled = False
        Check9.Visible = False ': Check9.Enabled = False
        Check10.Visible = False ': Check10.Enabled = False
        Check11.Visible = False ': Check11.Enabled = False
        Check12.Visible = False ': Check12.Enabled = False
    End Sub

    Private Sub Form11_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Me.Left = TwipsToPixelsX((PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - PixelsToTwipsX(Me.Width)) / 2)
        'Me.Top = TwipsToPixelsY((PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - PixelsToTwipsY(Me.Height)) / 2)
    End Sub
	
	Private Sub Form11_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
End Class