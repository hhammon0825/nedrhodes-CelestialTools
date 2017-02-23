Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form23
	Inherits System.Windows.Forms.Form
	Dim Pi As Double
	Dim LocTimeHighMinutes, TimeHighMinutes, TimeLowMinutes, LocTimeLowMinutes As Short
	Dim LocTimeHighMin, LocTimeHighHour, LocTimeLowHour, LocTimeLowMin As Short
	Dim LocHtHigh, LocHtLow As Double
	Dim TimeIntHighMinutes, DesTimeMinutes, TimeIntLowMinutes As Short
	Dim TimeIntLowMin, TimeIntHighMin, TimeIntHighHour, TimeIntLowHour, DurationMinutes As Short
	Dim DurationHour, DurationMin As Short
	Dim Factor, Range, RangeDisplay, Correction As Single
	Dim TimeDiff, i As Short
	Dim DurationStep As Single
	Dim fnumeral As String
	Public TideHeight As Single
	Public Flag As Boolean
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		'UPGRADE_ISSUE: Form method Form23.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		txtLocation.Text = ""
		txtLocNo.Text = ""
		txtDesTime.Text = ""
		cboDay.SelectedIndex = -1
		cboMonth.SelectedIndex = -1
		txtYear.Text = ""
		txtRefSta.Text = ""
		txtTimeHigh.Text = ""
		txtHtHigh.Text = ""
		txtTimeLow.Text = ""
		txtHtLow.Text = ""
		txtTab2Diff.Text = ""
		txtSubStaNo.Text = ""
		txtTab2HighHour.Text = ""
		txtTab2HighMin.Text = ""
		txtTab2HtHigh.Text = ""
		txtTab2LowHour.Text = ""
		txtTab2LowMin.Text = ""
		txtTab2HtLow.Text = ""
		Flag = False
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		'    Printer.ColorMode = vbPRCMMonochrome
		'    Form1.PrintForm
		'    Printer.ColorMode = vbPRCMColor
		'    Dim FormHeight As Integer, FormWidth As Integer
		FormHeight = VB6.PixelsToTwipsY(Me.Height)
		FormWidth = VB6.PixelsToTwipsX(Me.Width)
		PrintScreen()
	End Sub
	
	Private Sub cmdTides_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTides.Click
		Flag = True 'used to check if a tide height has been calculated for Vertical Clearances
		Pi = 4 * System.Math.Atan(1#)
		'UPGRADE_ISSUE: Form method Form23.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'CheckDate
		If txtDesTime.Text = "" Then MsgBox("You must enter a Desired Time.") : txtDesTime.Focus() : Exit Sub
		If txtTimeHigh.Text = "" Then MsgBox("You must enter a time of high tide.") : txtTimeHigh.Focus() : Exit Sub
		If txtTimeLow.Text = "" Then MsgBox("You must enter a time of low tide.") : txtTimeLow.Focus() : Exit Sub
		
		TimeHighMinutes = 60 * Val(VB.Left(txtTimeHigh.Text, 2)) + Val(VB.Right(txtTimeHigh.Text, 2))
		TimeLowMinutes = 60 * Val(VB.Left(txtTimeLow.Text, 2)) + Val(VB.Right(txtTimeLow.Text, 2))
		If System.Math.Abs(TimeHighMinutes - TimeLowMinutes) > 720 Then
			If TimeHighMinutes < TimeLowMinutes Then TimeHighMinutes = TimeHighMinutes + 1440 Else TimeLowMinutes = TimeLowMinutes + 1440
		End If
		
		If txtHtHigh.Text = "" Then txtHtHigh.Text = "0"
		If txtHtHigh.Text = "-" Then txtHtHigh.Text = "-0"
		If txtHtLow.Text = "" Then txtHtLow.Text = "0"
		If txtHtLow.Text = "-" Then txtHtLow.Text = "-0"
		If txtTab2HighHour.Text = "-" Then txtTab2HighHour.Text = "-0"
		If txtTab2HighHour.Text = "" Then txtTab2HighHour.Text = "+0"
		If txtTab2HighMin.Text = "" Then txtTab2HighMin.Text = "0"
		If txtTab2HtHigh.Text = "" Then txtTab2HtHigh.Text = "0"
		If txtTab2HtHigh.Text = "-" Then txtTab2HtHigh.Text = "-0"
		If txtTab2LowHour.Text = "" Then txtTab2LowHour.Text = "+0"
		If txtTab2LowHour.Text = "-" Then txtTab2LowHour.Text = "-0"
		If txtTab2LowMin.Text = "" Then txtTab2LowMin.Text = "0"
		If txtTab2HtLow.Text = "" Then txtTab2HtLow.Text = "0"
		If txtTab2HtLow.Text = "-" Then txtTab2HtLow.Text = "-0"
		
		LocTimeHighMinutes = TimeHighMinutes + (60 * System.Math.Abs(Val(txtTab2HighHour.Text)) + Val(txtTab2HighMin.Text))
		If VB.Left(txtTab2HighHour.Text, 1) = "-" Then LocTimeHighMinutes = TimeHighMinutes - (60 * System.Math.Abs(Val(txtTab2HighHour.Text)) + Val(txtTab2HighMin.Text))
		LocTimeHighHour = Int(LocTimeHighMinutes / 60)
		LocTimeHighMin = Int(LocTimeHighMinutes - CInt(LocTimeHighHour) * 60)
		
		LocTimeLowMinutes = TimeLowMinutes + (60 * System.Math.Abs(Val(txtTab2LowHour.Text)) + Val(txtTab2LowMin.Text))
		If VB.Left(txtTab2LowHour.Text, 1) = "-" Then LocTimeLowMinutes = TimeLowMinutes - (60 * System.Math.Abs(Val(txtTab2LowHour.Text)) + Val(txtTab2LowMin.Text))
		LocTimeLowHour = Int(LocTimeLowMinutes / 60)
		LocTimeLowMin = Int(LocTimeLowMinutes - CInt(LocTimeLowHour) * 60)
		
		LocHtHigh = Val(txtHtHigh.Text) + Val(txtTab2HtHigh.Text)
		If VB.Left(txtTab2HtHigh.Text, 1) = "*" Then LocHtHigh = Val(txtHtHigh.Text) * Val(Mid(txtTab2HtHigh.Text, 2))
		LocHtHigh = Int(LocHtHigh * 10 + 0.5000000000001) / 10
		LocHtLow = Val(txtHtLow.Text) + Val(txtTab2HtLow.Text)
		If VB.Left(txtTab2HtLow.Text, 1) = "*" Then LocHtLow = Val(txtHtLow.Text) * Val(Mid(txtTab2HtLow.Text, 2))
		LocHtLow = Int(LocHtLow * 10 + 0.5000000000001) / 10
		If LocHtHigh <= LocHtLow Then MsgBox("Check the tide heights.") : Exit Sub
		
		DesTimeMinutes = 60 * Val(VB.Left(txtDesTime.Text, 2)) + Val(VB.Right(txtDesTime.Text, 2))
		TimeIntHighMinutes = System.Math.Abs(DesTimeMinutes - LocTimeHighMinutes)
		TimeIntLowMinutes = System.Math.Abs(DesTimeMinutes - LocTimeLowMinutes)
		TimeIntHighHour = Int(TimeIntHighMinutes / 60)
		TimeIntHighMin = Int(TimeIntHighMinutes - CInt(TimeIntHighHour) * 60)
		TimeIntLowHour = Int(TimeIntLowMinutes / 60)
		TimeIntLowMin = Int(TimeIntLowMinutes - CInt(TimeIntLowHour) * 60)
		
		'If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then MsgBox ("Check the data."): Exit Sub
		'If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then MsgBox ("Check the data."): Exit Sub
		'If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then MsgBox ("Desired Time must be between Localized Time of High and Localized Time of Low."): Exit Sub
		
		DurationMinutes = TimeIntHighMinutes + TimeIntLowMinutes
		If DurationMinutes = 0 Then MsgBox("Check the data.") : Exit Sub
		DurationHour = Int(DurationMinutes / 60)
		DurationMin = Int(DurationMinutes - CInt(DurationHour) * 60)
		If optTable3.Checked = True Then
			If DurationMin <= 9 Then DurationMinutes = 60 * DurationHour
			If DurationMin > 9 And DurationMin <= 29 Then DurationMinutes = 60 * DurationHour + 20
			If DurationMin > 29 And DurationMin <= 49 Then DurationMinutes = 60 * DurationHour + 40
			If DurationMin > 49 Then DurationMinutes = 60 * DurationHour + 60
		End If
		
		Range = System.Math.Abs(LocHtHigh - LocHtLow) : RangeDisplay = Range
		If optTable3.Checked = True Then Range = Int(2 * Range + 0.5) / 2
		If TimeIntHighMinutes > TimeIntLowMinutes Then Factor = System.Math.Abs((DesTimeMinutes - LocTimeLowMinutes) / DurationMinutes)
		If TimeIntHighMinutes <= TimeIntLowMinutes Then Factor = System.Math.Abs((DesTimeMinutes - LocTimeHighMinutes) / DurationMinutes)
		If optTable3.Checked = True Then
			Factor = Factor * 30
			Factor = Int(Factor + 0.5)
			Factor = Factor / 30
		End If
		Correction = Range / 2 * (1 - System.Math.Cos(Pi * Factor))
		If optRule.Checked = True Then
			If LocTimeHighMinutes <= DesTimeMinutes Then TimeDiff = TimeIntHighMinutes
			If LocTimeLowMinutes < DesTimeMinutes Then TimeDiff = TimeIntLowMinutes
			TimeDiff = Int(TimeDiff / 60 + 0.5)
			If TimeDiff = 0 Then Factor = 0
			If TimeDiff = 1 Then Factor = 0.05
			If TimeDiff = 2 Then Factor = 0.25
			If TimeDiff = 3 Then Factor = 0.5
			If TimeDiff = 4 Then Factor = 0.75
			If TimeDiff = 5 Then Factor = 0.95
			If TimeDiff = 6 Then Factor = 1
			'Range = Int(Range + 0.5)
			Correction = Range * Factor
		End If
		
		Static x(6) As Single
		Static Diff(6) As Single
		'If optRule = True And Abs(DurationMinutes - 360) >= 60 Then
		If optAltRule.Checked = True Then
			DurationStep = DurationMinutes / 6
			If LocTimeHighMinutes <= DesTimeMinutes Then x(0) = LocTimeHighMinutes
			If LocTimeLowMinutes < DesTimeMinutes Then x(0) = LocTimeLowMinutes
			Diff(0) = System.Math.Abs(x(0) - DesTimeMinutes)
			For i = 1 To 6
				x(i) = x(i - 1) + DurationStep
				Diff(i) = System.Math.Abs(x(i) - DesTimeMinutes)
				If Diff(i) > Diff(i - 1) Then Exit For
			Next i
			i = i - 1
			'TimeDiff = Int(TimeDiff / 60 + 0.5)
			If i = 0 Then Factor = 0
			If i = 1 Then Factor = 0.05
			If i = 2 Then Factor = 0.25
			If i = 3 Then Factor = 0.5
			If i = 4 Then Factor = 0.75
			If i = 5 Then Factor = 0.95
			If i = 6 Then Factor = 1
			'Range = Int(Range + 0.5)
			Correction = Range * Factor
		End If
		
		Correction = Int(Correction * 10 + 0.500001) / 10
		
		'TideHeight = Range / 2 * Cos(Pi * (DesTimeMinutes - LocTimeHighMinutes) / DurationMinutes) + (LocHtHigh + LocHtLow) / 2
		If optCalc.Checked = True Or optTable3.Checked = True Then
			If TimeIntLowMinutes < TimeIntHighMinutes Then TideHeight = LocHtLow + Correction
			If TimeIntHighMinutes <= TimeIntLowMinutes Then TideHeight = LocHtHigh - Correction
		End If
		If optRule.Checked = True Or optAltRule.Checked = True Then
			If LocTimeLowMinutes < DesTimeMinutes Then TideHeight = LocHtLow + Correction
			If LocTimeHighMinutes <= DesTimeMinutes Then TideHeight = LocHtHigh - Correction
		End If
		
		'Correction = TideHeight - LocHtLow
		TideHeight = Int(TideHeight * 10 + 0.500001) / 10
		
		
		'DISPLAY
		'Cls
		'If LocTimeHighMinutes >= 1440 Then LocTimeHighMinutes = LocTimeHighMinutes - 1440
		'If LocTimeHighMinutes < 0 Then LocTimeHighMinutes = LocTimeHighMinutes + 1440
		'If LocTimeLowMinutes >= 1440 Then LocTimeLowMinutes = LocTimeLowMinutes - 1440
		'If LocTimeLowMinutes < 0 Then LocTimeLowMinutes = LocTimeLowMinutes + 1440
		Me.Font = VB6.FontChangeName(Me.Font, "Tahoma")
		'UPGRADE_ISSUE: Form property Form23.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2100
		If LocTimeHighHour >= 24 Then LocTimeHighHour = LocTimeHighHour - 24
		If LocTimeLowHour >= 24 Then LocTimeLowHour = LocTimeLowHour - 24
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Localized Data:  " & txtTab2Diff.Text, TAB(75), VB6.Format(LocTimeHighHour, "00") & VB6.Format(LocTimeHighMin, "00"), TAB(88))
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LocHtHigh < 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LocHtHigh >= 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(System.Math.Abs(LocHtHigh), "0.0"), TAB(101), VB6.Format(LocTimeLowHour, "00") & VB6.Format(LocTimeLowMin, "00"), TAB(113))
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LocHtLow < 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LocHtLow >= 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(System.Math.Abs(LocHtLow), "0.0"))
		
		If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then MsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
		If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then MsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
		If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then MsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
		
		Me.Font = VB6.FontChangeBold(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Time Interval Between:")
		Me.Font = VB6.FontChangeBold(Me.Font, False)
		'If optCalc = True Or optTable3 = True Then Print Tab(73);
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCalc.Checked = True Or optTable3.Checked = True Then
			Print("(Use smaller of the two.)", TAB(104), "Time Interval")
		Else
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If
		
		If optCalc.Checked = True Or optTable3.Checked = True Then
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Desired Time & Time of Local High Tide  ")
			If TimeIntHighMinutes < TimeIntLowMinutes And optCalc.Checked = True Or optTable3.Checked = True Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("DT~H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(105), CStr(TimeIntHighHour) & " h " & VB6.Format(TimeIntHighMin, "00") & " m")
			
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Desired Time & Time of Local Low Tide  ")
			If TimeIntHighMinutes > TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("DT~L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(105), CStr(TimeIntLowHour) & " h " & VB6.Format(TimeIntLowMin, "00") & " m")
		End If
		
		If optRule.Checked = True Or optAltRule.Checked = True Then
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Desired Time & Time of preceding Local ")
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("High")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If TimeIntHighMinutes > TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Low")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" Tide")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Print(TAB(105), CStr(TimeIntHighHour) & " h " & VB6.Format(TimeIntHighMin, "00") & " m")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes > TimeIntLowMinutes Then Print(TAB(105), CStr(TimeIntLowHour) & " h " & VB6.Format(TimeIntLowMin, "00") & " m")
			
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Time of Local High Tide & Time of Local Low Tide  ", TAB(105), CStr(DurationHour) & " h " & VB6.Format(DurationMin, "00") & " m")
		End If
		
		
		Me.Font = VB6.FontChangeBold(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optTable3.Checked = True Then Print("  Entering Arguments for Table 3:")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCalc.Checked = True Then Print("  Values for Calculation:")
		Me.Font = VB6.FontChangeBold(Me.Font, False)
		
		If optCalc.Checked = True Or optTable3.Checked = True Then
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Duration of ")
			If LocTimeLowMinutes <= DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Rise (L-H)")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If LocTimeHighMinutes <= DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Fall (H-L)")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(105), CStr(DurationHour) & " h " & VB6.Format(DurationMin, "00") & " m")
			
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Time Interval of ")
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If TimeIntHighMinutes > TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" (whichever is closer)")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Print(TAB(105), CStr(TimeIntHighHour) & " h " & VB6.Format(TimeIntHighMin, "00") & " m")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes > TimeIntLowMinutes Then Print(TAB(105), CStr(TimeIntLowHour) & " h " & VB6.Format(TimeIntLowMin, "00") & " m")
		End If
		
		If optRule.Checked = True Or optAltRule.Checked = True Then
			Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("  Values for Rule of Twelfths")
			'If DurationMinutes >= 60 Then Print " (alternate)";
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optAltRule.Checked = True Then Print(" (alternate)")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(":")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Time Interval from ")
			If LocTimeHighMinutes < DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If LocTimeLowMinutes < DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" (whichever precedes desired time)")
			'If LocTimeHighMinutes >= 1440 Then LocTimeHighMinutes = LocTimeHighMinutes - 1440
			'If LocTimeLowMinutes >= 1440 Then LocTimeLowMinutes = LocTimeLowMinutes - 1440
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LocTimeHighMinutes < DesTimeMinutes Then Print(TAB(105), CStr(TimeIntHighHour) & " h " & VB6.Format(TimeIntHighMin, "00") & " m")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LocTimeLowMinutes < DesTimeMinutes Then Print(TAB(105), CStr(TimeIntLowHour) & " h " & VB6.Format(TimeIntLowMin, "00") & " m")
			
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Rounded Time Interval (as percent change)", TAB(107), CStr(Factor * 100) & "%")
		End If
		
		
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("     Range of Tide at Local (Table 2) Substation", TAB(107), VB6.Format(RangeDisplay, "0.0") & " ft")
		
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(31), "Height of Tide Correction from ")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optTable3.Checked = True Then Print("Table 3")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCalc.Checked = True Then Print("calculation")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optRule.Checked = True Then Print("Rule of Twelfths")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optAltRule.Checked = True Then Print("Rule of Twelfths (alternate)")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(107), VB6.Format(Correction, "0.0") & " ft")
		
		Me.Font = VB6.FontChangeBold(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optTable3.Checked = True Then Print("  Application of Table 3 Correction:")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCalc.Checked = True Then Print("  Application of Calculated Correction:")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optRule.Checked = True Or optAltRule.Checked = True Then Print("  Application of Rule of Twelfths Correction:")
		Me.Font = VB6.FontChangeBold(Me.Font, False)
		
		If optCalc.Checked = True Or optTable3.Checked = True Then
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Ht. of Tide at Local Substation:  ")
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If TimeIntHighMinutes > TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" whichever is closer in time.", TAB(107))
			If TimeIntHighMinutes <= TimeIntLowMinutes Then
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtHigh < 0 Then Print("-")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtHigh >= 0 Then Print("+")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(VB6.Format(System.Math.Abs(LocHtHigh), "0.0") & " ft")
			End If
			If TimeIntHighMinutes > TimeIntLowMinutes Then
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtLow < 0 Then Print("-")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtLow >= 0 Then Print("+")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(VB6.Format(System.Math.Abs(LocHtLow), "0.0") & " ft")
			End If
		End If
		
		If optRule.Checked = True Or optAltRule.Checked = True Then
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Ht. of Tide at Local Substation:  ")
			If LocTimeHighMinutes <= DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If LocTimeLowMinutes < DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" whichever precedes desired time.", TAB(107))
			If LocTimeHighMinutes <= DesTimeMinutes Then
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtHigh < 0 Then Print("-")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtHigh >= 0 Then Print("+")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(VB6.Format(System.Math.Abs(LocHtHigh), "0.0") & " ft")
			End If
			If LocTimeLowMinutes < DesTimeMinutes Then
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtLow < 0 Then Print("-")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LocHtLow >= 0 Then Print("+")
				'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(VB6.Format(System.Math.Abs(LocHtLow), "0.0") & " ft")
			End If
		End If
		
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optTable3.Checked = True Then Print("     Table 3 Correction:  ")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCalc.Checked = True Then Print("     Calculated Correction:  ")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optRule.Checked = True Or optAltRule.Checked = True Then Print("     Rule of Twelfths Correction:  ")
		
		If optCalc.Checked = True Or optTable3.Checked = True Then
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" Subtract from H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If TimeIntHighMinutes > TimeIntLowMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Add to L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(107))
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes <= TimeIntLowMinutes Then Print("-")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If TimeIntHighMinutes > TimeIntLowMinutes Then Print("+")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(VB6.Format(System.Math.Abs(Correction), "0.0") & " ft")
		End If
		
		If optRule.Checked = True Or optAltRule.Checked = True Then
			If LocTimeHighMinutes <= DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" Subtract from H")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" or ")
			If LocTimeLowMinutes < DesTimeMinutes Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Add to L")
			Me.Font = VB6.FontChangeBold(Me.Font, False)
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(107))
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LocTimeHighMinutes <= DesTimeMinutes Then Print("-")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LocTimeLowMinutes < DesTimeMinutes Then Print("+")
			'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(VB6.Format(System.Math.Abs(Correction), "0.0") & " ft")
		End If
		
		
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(16), "Predicted Height of Tide at Desired Time at Local (Table 2) Substation", TAB(107))
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TideHeight < 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TideHeight >= 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form23.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(System.Math.Abs(TideHeight), "0.0") & " ft")
		
	End Sub
	
	Private Sub cmdVertical_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdVertical.Click
		If Flag = True Then Form25.txtHeight.Text = VB6.Format(Str(TideHeight), "0.0") Else Form25.txtHeight.Text = ""
		'Form25.cmdClear
		Form25.Show()
	End Sub
	
	Private Sub Form23_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Flag = False
	End Sub
	
	'UPGRADE_WARNING: Event optAltRule.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optAltRule_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAltRule.CheckedChanged
		If eventSender.Checked Then
			cmdTides_Click(cmdTides, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optCalc.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optCalc_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCalc.CheckedChanged
		If eventSender.Checked Then
			cmdTides_Click(cmdTides, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optRule.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optRule_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optRule.CheckedChanged
		If eventSender.Checked Then
			cmdTides_Click(cmdTides, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optTable3.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTable3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTable3.CheckedChanged
		If eventSender.Checked Then
			cmdTides_Click(cmdTides, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDesTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDesTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDesTime.TextChanged
		'txtTime.ForeColor = &H80000008
		txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtDesTime.Text) = 4 And (Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59) Then
			txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
			Exit Sub
		End If
	End Sub
	
	Private Sub txtDesTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDesTime.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtDesTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDesTime.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59 Or Len(txtDesTime.Text) <> 4 Then
			KeepFocus = True
		End If
		If Len(txtDesTime.Text) = 0 Then
			KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDesTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDesTime.Enter
		SelectAllText(txtDesTime)
	End Sub
	
	'UPGRADE_WARNING: Event txtLocation.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLocation_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocation.TextChanged
		txtTab2Diff.Text = txtLocation.Text
	End Sub
	Private Sub txtLocation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocation.Enter
		SelectAllText(txtLocation)
	End Sub
	
	'UPGRADE_WARNING: Event txtLocNo.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLocNo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocNo.TextChanged
		txtSubStaNo.Text = txtLocNo.Text
	End Sub
	Private Sub txtLocNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLocNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtLocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocNo.Enter
		SelectAllText(txtLocNo)
	End Sub
	
	Private Sub txtRefSta_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRefSta.Enter
		SelectAllText(txtRefSta)
	End Sub
	
	Private Sub txtSubStaNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSubStaNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtTimeHigh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTimeHigh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeHigh.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTimeHigh.Text) = 4 And (Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59) Then
			txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
			Exit Sub
		End If
	End Sub
	
	Private Sub txtTimeHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTimeHigh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTimeHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTimeHigh.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59 Or Len(txtTimeHigh.Text) <> 4 Then
			KeepFocus = True
		End If
		If Len(txtTimeHigh.Text) = 0 Then
			KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTimeHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeHigh.Enter
		SelectAllText(txtTimeHigh)
	End Sub
	
	'UPGRADE_WARNING: Event txtTimeLow.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTimeLow_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeLow.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTimeLow.Text) = 4 And (Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59) Then
			txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
			Exit Sub
		End If
	End Sub
	
	Private Sub txtTimeLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTimeLow.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTimeLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTimeLow.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59 Or Len(txtTimeLow.Text) <> 4 Then
			KeepFocus = True
		End If
		If Len(txtTimeLow.Text) = 0 Then
			KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTimeLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeLow.Enter
		SelectAllText(txtTimeLow)
	End Sub
	
	'UPGRADE_WARNING: Event txtTab2HighHour.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTab2HighHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighHour.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTab2HighHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
		'    txtTime.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
	End Sub
	
	Private Sub txtTab2HighHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HighHour.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtTab2HighHour.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2HighHour.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
				'    Case Asc(".")
				'        If bDecimalPointUsedUp Then
				'            KeyAscii = 0
				'            Beep
				'        Else
				'            bDecimalPointUsedUp = True
				'        End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTab2HighHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HighHour.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2HighHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighHour.Enter
		SelectAllText(txtTab2HighHour)
	End Sub
	
	'UPGRADE_WARNING: Event txtTab2HighMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTab2HighMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighMin.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTab2HighMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTab2HighMin.Text) = 2 And Val(txtTab2HighMin.Text) > 59 Then
			txtTab2HighMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtTab2HighMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HighMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTab2HighMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HighMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtTab2HighMin.Text) > 59 Then
			KeepFocus = True
		End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2HighMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighMin.Enter
		SelectAllText(txtTab2HighMin)
	End Sub
	
	'UPGRADE_WARNING: Event txtTab2LowHour.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTab2LowHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowHour.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTab2LowHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
		'    txtTime.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
	End Sub
	
	Private Sub txtTab2LowHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2LowHour.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtTab2LowHour.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2LowHour.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
				'    Case Asc(".")
				'        If bDecimalPointUsedUp Then
				'            KeyAscii = 0
				'            Beep
				'        Else
				'            bDecimalPointUsedUp = True
				'        End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTab2LowHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2LowHour.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2LowHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowHour.Enter
		SelectAllText(txtTab2LowHour)
	End Sub
	
	'UPGRADE_WARNING: Event txtTab2LowMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTab2LowMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowMin.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTab2LowMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTab2LowMin.Text) = 2 And Val(txtTab2LowMin.Text) > 59 Then
			txtTab2LowMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtTab2LowMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2LowMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTab2LowMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2LowMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtTab2LowMin.Text) > 59 Then
			KeepFocus = True
		End If
		'If Len(txtTab2LowMins) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2LowMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowMin.Enter
		SelectAllText(txtTab2LowMin)
	End Sub
	
	Private Sub txtHtHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHtHigh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtHtHigh.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtHtHigh.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
			Case Asc(".") 'only allows one decimal point
				If InStr(txtHtHigh.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtHtHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHtHigh.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHtHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHtHigh.Enter
		SelectAllText(txtHtHigh)
	End Sub
	
	Private Sub txtHtLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHtLow.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtHtLow.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtHtLow.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
			Case Asc(".") 'only allows one decimal point
				If InStr(txtHtLow.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtHtLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHtLow.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHtLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHtLow.Enter
		SelectAllText(txtHtLow)
	End Sub
	
	Private Sub txtTab2HtHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HtHigh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		Static bAsteriskAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		bAsteriskAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtTab2HtHigh.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2HtHigh.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
			Case Asc("*")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2HtHigh.SelectionStart <> 0 Or bAsteriskAlready Then
					KeyAscii = 0
					Beep()
				Else
					bAsteriskAlready = True
				End If
			Case Asc(".") 'only allows one decimal point
				If InStr(txtTab2HtHigh.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtTab2HtHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HtHigh.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2HtHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HtHigh.Enter
		SelectAllText(txtTab2HtHigh)
	End Sub
	
	Private Sub txtTab2HtLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HtLow.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		Static bPlusSignAlready As Boolean
		Static bAsteriskAlready As Boolean
		bMinusSignAlready = False
		bPlusSignAlready = False
		bAsteriskAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtTab2HtLow.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2HtLow.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
			Case Asc("*")
				'If Len(txtZDh.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtTab2HtLow.SelectionStart <> 0 Or bAsteriskAlready Then
					KeyAscii = 0
					Beep()
				Else
					bAsteriskAlready = True
				End If
			Case Asc(".") 'only allows one decimal point
				If InStr(txtTab2HtLow.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtTab2HtLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HtLow.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
		'    KeepFocus = True
		'End If
		'If Len(txtTime) = 0 Then
		'    KeepFocus = False
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTab2HtLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HtLow.Enter
		SelectAllText(txtTab2HtLow)
	End Sub
	
	Private Sub Form23_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.Enter
		SelectAllText(txtYear)
	End Sub
	
	Public Function CheckDate() As Object
		'    On Error GoTo ErrorHandler
		'ErrorHandler:
		'        MsgBox ("Invalid date")
		'        DateError = True
	End Function
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class