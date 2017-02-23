Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form21
	Inherits System.Windows.Forms.Form
	Dim Pi As Double
	Dim Time2inMinutes, Bearing2, Bearing1, Time1inMinutes, TimeinMinutes As Short
	Dim TimeHours, TimeMinutes As Short
	Dim DistanceToObject, DistanceTraveled, BeamDistance As Double
	Dim TimeOfCPA, DistanceUntilObjectAbeam, TimeToCPA, TimeOfCPAm As Double
	Dim TimeOfCPAh As Short
	Dim DistanceToObjectAbeam As Double
	Dim fnumeral As String
	Dim MaxTimem As Short
	Dim B2, B1, B3 As Short
	Dim I1, I2 As Single
	Dim C, MB, y As Short
	Dim x(180) As Object
	Dim Z As Double
	Dim Course2, Course1, Course As Short
	Dim ResultCourse As String
	Dim Lfix, L2, L1, Lo1, Lo2, LoFix As Double
	Dim Bg1, Bg2 As Short
	Dim L2Min, L1Min, Lo1Min, Lo2Min As String
	Dim LfixDeg, LofixDeg As Short
	Dim LfixMin, LofixMin As Double
	Dim dst13, ang2, crs21, dst12, w, crs12, ang1, ang3, DLo As Double
	Dim FL, FixL, FixLo, FLo As String
	Dim r As Short
	Dim Sep As Single
	
	Private Sub cmdCalculateD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateD.Click
		Pi = 4 * System.Math.Atan(1#)
		Bearing1 = Val(txtCourse.Text) - Val(txtBearing1.Text)
		If Bearing1 < 0 Then Bearing1 = Bearing1 + 360
		If Bearing1 > 90 Then Bearing1 = 360 - Bearing1
		Bearing2 = Val(txtCourse.Text) - Val(txtBearing2.Text)
		If Bearing2 < 0 Then Bearing2 = Bearing2 + 360
		If Bearing2 > 90 Then Bearing2 = 360 - Bearing2
		If System.Math.Abs(Bearing1) >= System.Math.Abs(Bearing2) Then MsgBox("Incorrect bearings.  Not moving towards object.") : Exit Sub
		Time1inMinutes = 60 * Val(VB.Left(txtTime1.Text, 2)) + Val(VB.Right(txtTime1.Text, 2))
		Time2inMinutes = 60 * Val(VB.Left(txtTime2.Text, 2)) + Val(VB.Right(txtTime2.Text, 2))
		TimeinMinutes = Time2inMinutes - Time1inMinutes
		TimeHours = Int(TimeinMinutes / 60) : TimeMinutes = TimeinMinutes - 60 * TimeHours
		'txtTimeh.Text = Str$(TimeHours): txtTimem.Text = Str$(TimeMinutes)
		If TimeinMinutes < 0 Then MsgBox("Error:  Time1 later than Time2") : Exit Sub
		If TimeinMinutes = 0 Then TimeinMinutes = 60 * Val(txtTimeh.Text) + Val(txtTimem.Text)
		'DistanceTraveled
		If Val(txtLog2.Text) < Val(txtLog1.Text) Then MsgBox("Error:  Log1 greater than Log2") : Exit Sub
		DistanceTraveled = Val(txtLog2.Text) - Val(txtLog1.Text) ': txtDist.Text = Str$(DistanceTraveled) 'Log values entered
		If txtLog1.Text = "" And txtLog2.Text = "" Then DistanceTraveled = Val(txtDist.Text) 'No log values entered
		If DistanceTraveled = 0 Then DistanceTraveled = Val(txtSpeed.Text) * TimeinMinutes / 60 ': txtDist.Text = Str$(DistanceTraveled) 'No log or DistanceTraveled values entered, use speed and time
		DistanceToObject = System.Math.Abs((DistanceTraveled * System.Math.Sin(Bearing1 * Pi / 180)) / System.Math.Sin((Bearing2 - Bearing1) * Pi / 180))
		BeamDistance = System.Math.Abs(DistanceToObject * System.Math.Sin(Bearing2 * Pi / 180))
		
		'DistanceToObjectAbeam = DistanceToObject * Cos(Val(txtBearing2.Text * Pi / 180))
		DistanceUntilObjectAbeam = System.Math.Sqrt(System.Math.Abs(DistanceToObject * DistanceToObject - BeamDistance * BeamDistance))
		If txtSpeed.Text <> "" Then TimeToCPA = 60 * DistanceUntilObjectAbeam / Val(txtSpeed.Text) 'CPA is when object is abeam
		If txtTime2.Text <> "" Then
			TimeOfCPA = Time2inMinutes + TimeToCPA
			TimeToCPA = Int(TimeToCPA * 10 + 0.5) / 10
			TimeOfCPA = TimeOfCPA / 60 'decimal hours
			TimeOfCPAh = Int(TimeOfCPA)
			TimeOfCPAm = (TimeOfCPA - TimeOfCPAh) * 60 : TimeOfCPAm = Int(TimeOfCPAm + 0.5)
			If TimeOfCPAh >= 24 Then TimeOfCPAh = TimeOfCPAh - 24
			TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm
		End If
		
		DistanceTraveled = Int(DistanceTraveled * 100 + 0.5) / 100
		BeamDistance = Int(BeamDistance * 100 + 0.5) / 100
		DistanceToObjectAbeam = Int(DistanceToObjectAbeam * 100 + 0.5) / 100
		TimeToCPA = Int(TimeToCPA + 0.5)
		TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm
		'UPGRADE_ISSUE: Form method Form21.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form21.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4500
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(15), "Distance of object at second bearing " & VB6.Format(DistanceToObject, "0.00") & " nm")
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(15), "Distance of object when abeam " & VB6.Format(BeamDistance, "0.00") & " nm")
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(15), "Distance until object is abeam " & VB6.Format(DistanceUntilObjectAbeam, "0.00") & " nm")
		
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtDist.Text = "" And txtTimeh.Text = "" And txtTimem.Text = "" And txtTime1.Text <> "" Then Print(TAB(15), "Run Time " & VB6.Format(TimeHours, "##0") & "h" & VB6.Format(TimeMinutes, "00") & "m")
		
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtSpeed.Text <> "" Then Print(TAB(15), "Time from second bearing to object abeam " & VB6.Format(TimeToCPA, "0") & " min.")
		'UPGRADE_ISSUE: Form method Form21.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtTime2.Text <> "" Then Print(TAB(15), "Time of object abeam " & VB6.Format(TimeOfCPA, "0000"))
		
	End Sub
	
	Private Sub cmdCalculateF2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateF2.Click
		Label28.Visible = False
		Sep = System.Math.Abs(Val(txtBg1.Text) - Val(txtBg2.Text))
		If Sep >= 225 Then Sep = 360 - Sep
		Pi = 4 * System.Math.Atan(1#)
		r = 180 : If chkReciprocal.CheckState = 1 Then r = 0
		LatLong()
		'Method fails if Lo1=Lo2 (or if L1=0 and L2=0)
		If Lo1 = Lo2 Then Lo1 = Lo1 + 0.00001
		'If (L1=0 and L2=0) then
		w = System.Math.Sqrt((System.Math.Sin((L1 - L2) / 2 * Pi / 180)) ^ 2 + System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((Lo1 - Lo2) / 2 * Pi / 180) ^ 2)
		dst12 = 2 * System.Math.Atan(w / (System.Math.Sqrt(-w * w + 1) + 9.999999E-21)) '2*arcsin, radians
		
		If System.Math.Sin((Lo2 - Lo1) * Pi / 180) < 0 Then
			w = (System.Math.Sin(L2 * Pi / 180) - System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(dst12)) / (System.Math.Sin(dst12) * System.Math.Cos(L1 * Pi / 180))
			crs12 = System.Math.Atan(-w / System.Math.Sqrt(-w * w + 1)) + Pi / 2 'arccos, radians
			w = (System.Math.Sin(L1 * Pi / 180) - System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(dst12)) / (System.Math.Sin(dst12) * System.Math.Cos(L2 * Pi / 180))
			crs21 = 2 * Pi - (System.Math.Atan(-w / System.Math.Sqrt(-w * w + 1)) + Pi / 2) '2*Pi - arccos, radians
		Else
			w = (System.Math.Sin(L2 * Pi / 180) - System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(dst12)) / (System.Math.Sin(dst12) * System.Math.Cos(L1 * Pi / 180))
			crs12 = 2 * Pi - (System.Math.Atan(-w / System.Math.Sqrt(-w * w + 1)) + Pi / 2) '2*Pi - arccos, radians
			w = (System.Math.Sin(L1 * Pi / 180) - System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(dst12)) / (System.Math.Sin(dst12) * System.Math.Cos(L2 * Pi / 180))
			crs21 = System.Math.Atan(-w / System.Math.Sqrt(-w * w + 1)) + Pi / 2 'arccos, radians
		End If
		
		ang1 = (Val(txtBg1.Text) + r) * Pi / 180 - crs12 + Pi
		If ang1 > 2 * Pi Then ang1 = ang1 - 2 * Pi
		ang1 = ang1 - Pi
		ang2 = crs21 - (Val(txtBg2.Text) + r) * Pi / 180 + Pi
		If ang2 > 2 * Pi Then ang2 = ang2 - 2 * Pi
		ang2 = ang2 - Pi
		
		If System.Math.Sin(ang1) = 0 And System.Math.Sin(ang2) = 0 Then MsgBox("Check data.  Infinite number of intersections.") : Exit Sub
		If System.Math.Sin(ang1) * System.Math.Sin(ang2) < 0 Then MsgBox("Check data.  Ambiguous intersection.") : Exit Sub
		
		ang1 = System.Math.Abs(ang1)
		ang2 = System.Math.Abs(ang2)
		w = -System.Math.Cos(ang1) * System.Math.Cos(ang2) + System.Math.Sin(ang1) * System.Math.Sin(ang2) * System.Math.Cos(dst12)
		ang3 = System.Math.Atan(-w / System.Math.Sqrt(-w * w + 1)) + Pi / 2 'arccos, radians
		dst13 = Atan2(System.Math.Sin(dst12) * System.Math.Sin(ang1) * System.Math.Sin(ang2), System.Math.Cos(ang2) + System.Math.Cos(ang1) * System.Math.Cos(ang3))
		w = System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(dst13) + System.Math.Cos(L1 * Pi / 180) * System.Math.Sin(dst13) * System.Math.Cos((Val(txtBg1.Text) + r) * Pi / 180)
		Lfix = System.Math.Atan(w / (System.Math.Sqrt(-w * w + 1) + 9.999999E-21)) 'arcsin, radians
		DLo = Atan2(System.Math.Sin((Val(txtBg1.Text) + r) * Pi / 180) * System.Math.Sin(dst13) * System.Math.Cos(L1 * Pi / 180), System.Math.Cos(dst13) - System.Math.Sin(L1 * Pi / 180) * System.Math.Sin(Lfix))
		LoFix = Lo1 * Pi / 180 - DLo + Pi
		If LoFix > 2 * Pi Then LoFix = LoFix - 2 * Pi
		LoFix = LoFix - Pi
		
		Lfix = Lfix * 180 / Pi
		LoFix = LoFix * 180 / Pi
		If System.Math.Abs(LoFix) > 180 Then LoFix = -System.Math.Sign(LoFix) * (360 - System.Math.Abs(LoFix))
		LfixDeg = Int(System.Math.Abs(Lfix))
		LfixMin = (System.Math.Abs(Lfix) - LfixDeg) * 60
		If Int(LfixMin * 10 + 0.5) / 10 = 60 Then LfixMin = 0 : LfixDeg = LfixDeg + 1
		LfixDeg = System.Math.Abs(LfixDeg)
		LofixDeg = Int(System.Math.Abs(LoFix))
		LofixMin = (System.Math.Abs(LoFix) - LofixDeg) * 60
		If Int(LofixMin * 10 + 0.5) / 10 = 60 Then LofixMin = 0 : LofixDeg = LofixDeg + 1
		
		'UPGRADE_ISSUE: Form method Form21.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form21.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2200
		If Lfix > 0 Then FL = "N"
		If Lfix = 0 Then FL = " "
		If Lfix < 0 Then FL = "S"
		If LoFix > 0 Then FLo = "W"
		If LoFix = 0 Then FLo = " "
		If LoFix < 0 Then FLo = "E"
		Label26.Visible = True
		txtFixL.Visible = True
		txtFixL.Text = VB6.Format(LfixDeg, "0") & Chr(176) & VB6.Format(LfixMin, "00.0") & "'" & FL
		Label27.Visible = True
		txtFixLo.Visible = True
		txtFixLo.Text = VB6.Format(LofixDeg, "0") & Chr(176) & VB6.Format(LofixMin, "00.0") & "'" & FLo
		
		If Sep > 135 Or Sep < 45 Then Label28.Visible = True
		
	End Sub
	
	Private Sub cmdClearC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearC.Click
		txtB1.Text = "" : txtB2.Text = "" : txtB3.Text = "" : txtI1.Text = "" : txtI2.Text = ""
		Label14.Visible = False : txtResultCourse.Visible = False
	End Sub
	
	Private Sub cmdClearF2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearF2.Click
		txtBg1.Text = "" : txtBg2.Text = ""
		txtL1Deg.Text = "" : txtL1Min.Text = ""
		txtLo1Deg.Text = "" : txtLo1Min.Text = ""
		txtL2Deg.Text = "" : txtL2Min.Text = ""
		txtLo2Deg.Text = "" : txtLo2Min.Text = ""
		Label26.Visible = False : Label27.Visible = False
		txtFixL.Visible = False : txtFixLo.Visible = False
		Label28.Visible = False
		chkReciprocal.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		FormHeight = VB6.PixelsToTwipsY(Me.Height)
		FormWidth = VB6.PixelsToTwipsX(Me.Width)
		PrintScreen()
	End Sub
	
	Private Sub Form21_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cboL1.SelectedIndex = 0 '"N"
		cboLo1.SelectedIndex = 0 '"W"
		cboL2.SelectedIndex = 0 '"N"
		cboLo2.SelectedIndex = 0 '"W"
	End Sub
	
	Private Sub Form21_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	Private Sub cmdClearD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearD.Click
		'UPGRADE_ISSUE: Form method Form21.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		txtCourse.Text = ""
		txtBearing1.Text = ""
		txtBearing2.Text = ""
		txtDist.Text = ""
		txtSpeed.Text = ""
		txtTimeh.Text = ""
		txtTimem.Text = ""
		txtLog1.Text = ""
		txtLog2.Text = ""
		txtTime1.Text = ""
		txtTime2.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event optRel.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optRel_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optRel.CheckedChanged
		If eventSender.Checked Then
			cmdClearD_Click(cmdClearD, New System.EventArgs())
			lblVesselCourse.Visible = False
			txtCourse.Visible = False
			lblCourse.Visible = False
			lblB1.Text = "� Relative (off the bow)"
			lblB2.Text = "� Relative (off the bow)"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optTrue.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTrue_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTrue.CheckedChanged
		If eventSender.Checked Then
			cmdClearD_Click(cmdClearD, New System.EventArgs())
			lblCourse.Text = "� True"
			lblVesselCourse.Visible = True
			txtCourse.Visible = True
			lblCourse.Visible = True
			lblB1.Text = "� True"
			lblB2.Text = "� True"
		End If
	End Sub
	'UPGRADE_WARNING: Event optMag.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMag_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMag.CheckedChanged
		If eventSender.Checked Then
			cmdClearD_Click(cmdClearD, New System.EventArgs())
			lblCourse.Text = "� Magnetic"
			lblVesselCourse.Visible = True
			txtCourse.Visible = True
			lblCourse.Visible = True
			lblB1.Text = "� Magnetic"
			lblB2.Text = "� Magnetic"
		End If
	End Sub
	'UPGRADE_WARNING: Event optComp.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optComp_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optComp.CheckedChanged
		If eventSender.Checked Then
			cmdClearD_Click(cmdClearD, New System.EventArgs())
			lblCourse.Text = "� Compass"
			lblVesselCourse.Visible = True
			txtCourse.Visible = True
			lblCourse.Visible = True
			lblB1.Text = "� Compass"
			lblB2.Text = "� Compass"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtB1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtB1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB1.TextChanged
		If Val(txtB1.Text) > 359 Then
			txtB1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtB1.Text) < 359 Then
			'txtDC.ForeColor = &H80000008
			txtB1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtB1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtB1.KeyPress
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
	Private Sub txtB1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtB1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtB1.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtB1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB1.Enter
		SelectAllText(txtB1)
	End Sub
	
	'UPGRADE_WARNING: Event txtB2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtB2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB2.TextChanged
		If Val(txtB2.Text) > 359 Then
			txtB2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtB2.Text) < 359 Then
			'txtDC.ForeColor = &H80000008
			txtB2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtB2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtB2.KeyPress
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
	Private Sub txtB2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtB2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtB2.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtB2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB2.Enter
		SelectAllText(txtB2)
	End Sub
	
	'UPGRADE_WARNING: Event txtB3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtB3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB3.TextChanged
		If Val(txtB3.Text) > 359 Then
			txtB3.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtB3.Text) < 359 Then
			'txtDC.ForeColor = &H80000008
			txtB3.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtB3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtB3.KeyPress
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
	Private Sub txtB3_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtB3.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtB3.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtB3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtB3.Enter
		SelectAllText(txtB3)
	End Sub
	
	'UPGRADE_WARNING: Event txtCourse.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCourse_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.TextChanged
		If Val(txtCourse.Text) > 359 Then
			txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtCourse.Text) < 360 Then
			txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtCourse_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		''Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		'bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
				'Case Asc("-")
				'    'If Len(txtCourse.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				'    If txtCourse.SelStart <> 0 Or bMinusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bMinusSignAlready = True
				'    End If
				'Case Asc("+")
				'    'If Len(txtCourse.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				
				'    If txtCourse.SelStart <> 0 Or bPlusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bPlusSignAlready = True
				'    End If
				
			Case Asc(".") 'only allows one decimal point
				If InStr(txtCourse.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtCourse_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCourse.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtCourse.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtCourse_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.Enter
		SelectAllText(txtCourse)
	End Sub
	
	'UPGRADE_WARNING: Event txtBearing1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBearing1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing1.TextChanged
		If optRel.Checked = True And Val(txtBearing1.Text) > 90 Or Val(txtBearing1.Text) < 1 And txtBearing1.Text <> "" Then
			txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optRel.Checked = True And Val(txtBearing1.Text) < 91 And Val(txtBearing1.Text) > 0 Or txtBearing1.Text = "" Then
			txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If optRel.Checked = False And Val(txtBearing1.Text) > 359 Then
			txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optRel.Checked = False And Val(txtBearing1.Text) < 360 Then
			txtBearing1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtBearing1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBearing1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		''Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		'bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
				'Case Asc("-")
				'    'If Len(txtBearing1.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				'    If txtBearing1.SelStart <> 0 Or bMinusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bMinusSignAlready = True
				'    End If
				'Case Asc("+")
				'    'If Len(txtBearing1.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				
				'    If txtBearing1.SelStart <> 0 Or bPlusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bPlusSignAlready = True
				'    End If
				
			Case Asc(".") 'only allows one decimal point
				If InStr(txtBearing1.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtBearing1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBearing1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If optRel.Checked = True And Val(txtBearing1.Text) > 90 Or Val(txtBearing1.Text) < 1 And txtBearing1.Text <> "" Then
			KeepFocus = True
		End If
		If optRel.Checked = False And Val(txtBearing1.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtBearing1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing1.Enter
		SelectAllText(txtBearing1)
	End Sub
	
	'UPGRADE_WARNING: Event txtBearing2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBearing2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing2.TextChanged
		If optRel.Checked = True And Val(txtBearing2.Text) > 90 Or Val(txtBearing2.Text) < 1 And txtBearing2.Text <> "" Then
			txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optRel.Checked = True And Val(txtBearing2.Text) < 91 And Val(txtBearing2.Text) > 0 Or txtBearing2.Text = "" Then
			txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If optRel.Checked = False And Val(txtBearing2.Text) > 359 Then
			txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optRel.Checked = False And Val(txtBearing2.Text) < 360 Then
			txtBearing2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtBearing2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBearing2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		''Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		'bPlusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
				'Case Asc("-")
				'    'If Len(txtBearing2.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				'    If txtBearing2.SelStart <> 0 Or bMinusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bMinusSignAlready = True
				'    End If
				'Case Asc("+")
				'    'If Len(txtBearing2.Text) > 0 Then
				'    '    KeyAscii = 0
				'    '    Beep
				'    'End If
				
				'    If txtBearing2.SelStart <> 0 Or bPlusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'        bPlusSignAlready = True
				'    End If
				
			Case Asc(".") 'only allows one decimal point
				If InStr(txtBearing2.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtBearing2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBearing2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If optRel.Checked = True And Val(txtBearing2.Text) > 90 Or Val(txtBearing2.Text) < 1 And txtBearing2.Text <> "" Then
			KeepFocus = True
		End If
		If optRel.Checked = False And Val(txtBearing2.Text) > 359 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtBearing2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBearing2.Enter
		SelectAllText(txtBearing2)
	End Sub
	
	'UPGRADE_WARNING: Event txtI1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtI1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtI1.TextChanged
		If Val(txtI1.Text) > 99999 Then
			txtI1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtI1.Text) <= 99999 Then
			txtI1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtI1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtI1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtI1.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	
	Private Sub txtI1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtI1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtI1.Text) > 99999 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtI1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtI1.Enter
		SelectAllText(txtI1)
	End Sub
	
	'UPGRADE_WARNING: Event txtI2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtI2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtI2.TextChanged
		If Val(txtI2.Text) > 99999 Then
			txtI2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtI2.Text) <= 99999 Then
			txtI2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtI2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtI2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtI2.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	
	Private Sub txtI2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtI2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtI2.Text) > 99999 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtI2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtI2.Enter
		SelectAllText(txtI2)
	End Sub
	
	'UPGRADE_WARNING: Event txtSpeed.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSpeed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.TextChanged
		If txtSpeed.Text <> "" Or txtTime1.Text <> "" Or txtTime1.Text <> "" Then
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			'txtTimeh.Enabled = False: txtTimeh.BackColor = &H80000011
			'txtTimem.Enabled = False: txtTimem.BackColor = &H80000011
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtTimeh.Enabled = True: txtTimeh.BackColor = &H80000005
			'txtTimem.Enabled = True: txtTimem.BackColor = &H80000005
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		'If txtSpeed.Text = "" And txtTime1.Text = "" And txtTime2.Text = "" Then
		'    txtTimeh.Enabled = True: txtTimeh.BackColor = &H80000005
		'    txtTimem.Enabled = True: txtTimem.BackColor = &H80000005
		'End If
		If Val(txtSpeed.Text) > 99.9 Then
			txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtSpeed.Text) <= 99.9 Then
			'txtSpeed.ForeColor = &H80000008
			txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtSpeed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeed.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtSpeed.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtSpeed_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSpeed.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtSpeed.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtSpeed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.Enter
		SelectAllText(txtSpeed)
	End Sub
	
	'UPGRADE_WARNING: Event txtDist.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDist_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDist.TextChanged
		If txtDist.Text <> "" Then
			txtSpeed.Enabled = False : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimem.Enabled = False : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtSpeed.Enabled = True : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtDist.Text) > 99.9 Then
			txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtDist.Text) <= 99.9 Then
			'txtDist.ForeColor = &H80000008
			txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDist.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtDist.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtDist_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDist.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtDist.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDist.Enter
		SelectAllText(txtDist)
	End Sub
	
	'UPGRADE_WARNING: Event txtLog1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLog1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLog1.TextChanged
		If txtLog1.Text <> "" Then
			txtSpeed.Enabled = False : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimem.Enabled = False : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtSpeed.Enabled = True : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtLog1.Text) > 9999.9 Then
			txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLog1.Text) <= 9999.9 Then
			'txtLog1.ForeColor = &H80000008
			txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		
	End Sub
	Private Sub txtLog1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLog1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLog1.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtLog1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLog1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLog1.Text) > 9999.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLog1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLog1.Enter
		SelectAllText(txtLog1)
	End Sub
	
	'UPGRADE_WARNING: Event txtLog2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLog2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLog2.TextChanged
		If txtLog2.Text <> "" Then
			txtSpeed.Enabled = False : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimem.Enabled = False : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtSpeed.Enabled = True : txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtLog2.Text) > 9999 Then
			txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLog2.Text) <= 9999.9 Then
			'txtLog2.ForeColor = &H80000008
			txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		
	End Sub
	Private Sub txtLog2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLog2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLog2.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
				
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
	Private Sub txtLog2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLog2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLog2.Text) > 9999.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLog2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLog2.Enter
		SelectAllText(txtLog2)
	End Sub
	
	'UPGRADE_WARNING: Event txtTime1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.TextChanged
		If txtSpeed.Text <> "" Or txtTime1.Text <> "" Or txtTime2.Text <> "" Then
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimem.Enabled = False : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If txtTime1.Text = "" And txtTime2.Text = "" Then
			'If txtSpeed.Text = "" And txtTime1.Text = "" And txtTime1.Text = "" Then
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		'txtTime1.ForeColor = &H80000008
		txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime1.Text) = 4 And (Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(Mid(txtTime1.Text, 3, 2)) > 59) Then
			txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	Private Sub txtTime1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime1.KeyPress
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
	Private Sub txtTime1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(Mid(txtTime1.Text, 3, 2)) > 59 Or Len(txtTime1.Text) <> 4 Then
			KeepFocus = True
			If txtTime1.Text = "" Then KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.Enter
		SelectAllText(txtTime1)
	End Sub
	
	'UPGRADE_WARNING: Event txtTime2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.TextChanged
		If txtSpeed.Text <> "" Or txtTime1.Text <> "" Or txtTime2.Text <> "" Then
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTimem.Enabled = False : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If txtTime1.Text = "" And txtTime2.Text = "" Then
			'If txtSpeed.Text = "" And txtTime1.Text = "" And txtTime1.Text = "" Then
			txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTimem.Enabled = True : txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		'txtTime2.ForeColor = &H80000008
		txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime2.Text) = 4 And (Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59) Then
			txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	Private Sub txtTime2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime2.KeyPress
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
	Private Sub txtTime2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Len(txtTime2.Text) <> 4 Then
			KeepFocus = True
			If txtTime2.Text = "" Then KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.Enter
		SelectAllText(txtTime2)
	End Sub
	
	'UPGRADE_WARNING: Event txtTimeh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTimeh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeh.TextChanged
		If txtSpeed.Text <> "" Or txtTimeh.Text <> "" Or txtTimem.Text <> "" Then
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If txtTimeh.Text <> "" Or txtTimem.Text <> "" Then
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		'If Val(txtTimeh.Text) > 99 Then
		'    txtTimeh.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
		'If Val(txtTimeh.Text) <= 99 Then
		'    txtTimeh.ForeColor = &H80000008
		'    txtTimeh.BackColor = &H80000005
		'End If
		'If Val(txtTimeh.Text) <> 0 Then MaxTimem = 59 Else MaxTimem = 999
	End Sub
	Private Sub txtTimeh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTimeh.KeyPress
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
	Private Sub txtTimeh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTimeh.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtTimeh.Text) > 99 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTimeh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimeh.Enter
		SelectAllText(txtTimeh)
	End Sub
	
	'UPGRADE_WARNING: Event txtTimem.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTimem_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimem.TextChanged
		If txtSpeed.Text <> "" Or txtTimeh.Text <> "" Or txtTimem.Text <> "" Then
			txtDist.Enabled = False : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog1.Enabled = False : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtLog2.Enabled = False : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime1.Enabled = False : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
			txtTime2.Enabled = False : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		Else
			txtDist.Enabled = True : txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog1.Enabled = True : txtLog1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtLog2.Enabled = True : txtLog2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime1.Enabled = True : txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime2.Enabled = True : txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtTimeh.Text) <> 0 Then MaxTimem = 59 Else MaxTimem = 99
		If Val(txtTimem.Text) > MaxTimem Then
			txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtTimem.Text) <= MaxTimem Then
			'txtTimem.ForeColor = &H80000008
			txtTimem.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtTimem.Text) > 59 Then txtTimeh.Enabled = False : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011)
		If Val(txtTimem.Text) <= 59 Then txtTimeh.Enabled = True : txtTimeh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
	End Sub
	Private Sub txtTimem_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTimem.KeyPress
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
	Private Sub txtTimem_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTimem.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtTimem.Text) > 59 Then
		'    KeepFocus = True
		'End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTimem_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTimem.Enter
		SelectAllText(txtTimem)
	End Sub
	
	Private Sub cmdCalculateC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateC.Click
		'Is ARE INTERVALS - CAN BE TIME INTERVALS AT CONSTANT SPEED OR DISTANCES IF SPEED CHANGES
		Pi = 4 * System.Math.Atan(1#)
		B1 = Val(txtB1.Text)
		B2 = Val(txtB2.Text)
		B3 = Val(txtB3.Text)
		I1 = Val(txtI1.Text)
		I2 = Val(txtI2.Text)
		If I1 = 0 Or I2 = 0 Then MsgBox("Intervals cannot be zero or blank.") : Exit Sub
		If B1 = B2 Or B2 = B3 Or B3 = B1 Then MsgBox("Check data.  No two bearings can be the same.") : Exit Sub
		If (B1 > B2 And B2 < B3 And B3 < B1) Or (B1 < B2 And B2 > B3 And B3 < B1) Or (B1 > B2 And B2 < B3 And B3 > B1) Or (B1 < B2 And B2 > B3 And B3 > B1) Then MB = MsgBox("Bearing values are not monotonically increasing or decreasing.  If correct (on both sides of 0�) press Yes.  If not, press No.", MsgBoxStyle.YesNo)
		If MB = MsgBoxResult.No Then Exit Sub
		'Next four lines allow for bearings on both sides of zero
		If B1 > B2 And B2 < B3 And B3 < B1 Then B2 = B2 + 360 : B3 = B3 + 360 : GoTo Line100
		If B1 < B2 And B2 > B3 And B3 < B1 Then B3 = B3 + 360 : GoTo Line100
		If B1 > B2 And B2 < B3 And B3 > B1 Then B1 = B1 + 360 : B2 = B2 + 360 : GoTo Line100
		If B1 < B2 And B2 > B3 And B3 > B1 Then B1 = B1 + 360
		
Line100: 
		Z = 1000
		For C = 0 To 180 '360
			'x(c) = Abs(Val(txtI1.Text) * Sin((c - Val(txtB1.Text)) * Pi / 180) / Sin((Val(txtB1.Text) - Val(txtB2.Text)) * Pi / 180) - Val(txtI2.Text) * Sin((180 - c + Val(txtB3.Text)) * Pi / 180) / Sin((Val(txtB2.Text) - Val(txtB3.Text)) * Pi / 180))
			'UPGRADE_WARNING: Couldn't resolve default property of object x(C). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x(C) = System.Math.Abs(I1 * System.Math.Sin((C - B1) * Pi / 180) / System.Math.Sin((B1 - B2) * Pi / 180) - I2 * System.Math.Sin((180 - C + B3) * Pi / 180) / System.Math.Sin((B2 - B3) * Pi / 180))
			If C > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x(C). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If x(C) < Z Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x(C). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Z = x(C) : Course1 = C
				End If
			End If
			'Debug.Print C, x(C)
		Next 
		'If course1 < 0 Then course1 = course1 + 360
		'If course1 = 360 Then course1 = course1 - 360
		
		Course2 = Course1 - 180
		If Course2 < 0 Then Course2 = Course2 + 360
		If Course2 >= 360 Then Course2 = Course2 - 360
		
		If B2 > B1 Then y = B2 - 90
		If B2 < B1 Then y = B2 + 90
		If y >= 360 Then y = y - 360
		If y < 0 Then y = y + 360
		
		Course = Course1
		
		'If Course2 - Val(txtDRCourse.Text) > Course1 - Val(txtDRCourse.Text) Then Course = Course1
		'If Abs(course2 - Val(txtDRCourse.Text)) < Abs(course1 - Val(txtDRCourse.Text)) Then Course = course2
		If System.Math.Abs(Course2 - y) < System.Math.Abs(Course1 - y) Then Course = Course2
		
		'UPGRADE_ISSUE: Form method Form21.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form21.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 8200
		'Print Tab(34); "CMG "; Course; Chr$(176)
		Label14.Visible = True
		'Print Tab(35); Format(Course, "000")
		'Label15.Visible = True
		txtResultCourse.Visible = True
		ResultCourse = VB6.Format(Course, "000")
		txtResultCourse.Text = ResultCourse & Chr(176)
		
	End Sub
	'UPGRADE_WARNING: Event txtL1Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL1Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.TextChanged
		If Val(txtL1Deg.Text) <> 90 Then txtL1Min.Enabled = True
		If Val(txtL1Deg.Text) = 90 Then txtL1Min.Text = "" : txtL1Min.Enabled = False : txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtL1Deg.ForeColor = &H80000008
		txtL1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'    If Val(txtL1Deg.text) > 90 Or (Val(txtL1Deg.text) = 90 And Val(txtL1Min.text) <> 0) Then
		'        txtL1Deg.BackColor = &HFF&
		'        MsgBox "Out of Range"
		'    End If
		If Val(txtL1Deg.Text) > 90 Then
			txtL1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtL1Deg.Text) < 90 Then
			'txtL1Min.ForeColor = &H80000008
			txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtL1Min.Text = "  "
		End If
	End Sub
	
	Private Sub txtL1Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL1Deg.KeyPress
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
	
	Private Sub txtL1Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL1Deg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL1Deg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL1Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.Enter
		SelectAllText(txtL1Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtL1Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL1Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Min.TextChanged
		'txtLMin.ForeColor = &H80000008
		txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtL1Min.Text) > 59.9 Then
			txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtL1Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL1Min.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtL1Min.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
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
	
	Private Sub txtL1Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL1Min.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL1Min.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL1Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Min.Enter
		SelectAllText(txtL1Min)
	End Sub
	
	'UPGRADE_WARNING: Event txtLo1Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLo1Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Deg.TextChanged
		If Val(txtLo1Deg.Text) <> 180 Then txtLo1Min.Enabled = True
		If Val(txtLo1Deg.Text) = 180 Then txtLo1Min.Text = "" : txtLo1Min.Enabled = False : txtLo1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLoDeg.ForeColor = &H80000008
		txtLo1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo1Deg.Text) > 180 Or (Val(txtLo1Deg.Text) = 180 And Val(txtLo1Min.Text) <> 0) Then
			txtLo1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLo1Deg.Text) < 180 Then
			'txtLoMin.ForeColor = &H80000008
			txtLo1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLoMin.Text = "    "
		End If
	End Sub
	
	Private Sub txtLo1Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo1Deg.KeyPress
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
	
	Private Sub txtLo1Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo1Deg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLo1Deg.Text) > 180 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLo1Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Deg.Enter
		SelectAllText(txtLo1Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtLo1Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLo1Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Min.TextChanged
		'txtLoMin.ForeColor = &H80000008
		txtLo1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo1Min.Text) > 59.9 Then
			txtLo1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtLo1Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo1Min.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLo1Min.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
				'Case Asc(",")
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtLo1Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo1Min.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLo1Min.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLo1Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Min.Enter
		SelectAllText(txtLo1Min)
	End Sub
	
	'UPGRADE_WARNING: Event txtL2Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL2Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Deg.TextChanged
		If Val(txtL2Deg.Text) <> 90 Then txtL2Min.Enabled = True
		If Val(txtL2Deg.Text) = 90 Then txtL2Min.Text = "" : txtL2Min.Enabled = False : txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtL2Deg.ForeColor = &H80000008
		txtL2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'    If Val(txtL2Deg.text) > 90 Or (Val(txtL2Deg.text) = 90 And Val(txtL2Min.text) <> 0) Then
		'        txtL2Deg.BackColor = &HFF&
		'        MsgBox "Out of Range"
		'    End If
		If Val(txtL2Deg.Text) > 90 Then
			txtL2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtL2Deg.Text) < 90 Then
			'txtL2Min.ForeColor = &H80000008
			txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtL2Min.Text = "  "
		End If
	End Sub
	
	Private Sub txtL2Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL2Deg.KeyPress
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
	
	Private Sub txtL2Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL2Deg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL2Deg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL2Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Deg.Enter
		SelectAllText(txtL2Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtL2Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL2Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Min.TextChanged
		'txtLMin.ForeColor = &H80000008
		txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtL2Min.Text) > 59.9 Then
			txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtL2Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL2Min.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtL2Min.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
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
	
	Private Sub txtL2Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL2Min.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL2Min.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL2Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Min.Enter
		SelectAllText(txtL2Min)
	End Sub
	
	'UPGRADE_WARNING: Event txtLo2Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLo2Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo2Deg.TextChanged
		If Val(txtLo2Deg.Text) <> 180 Then txtLo2Min.Enabled = True
		If Val(txtLo2Deg.Text) = 180 Then txtLo2Min.Text = "" : txtLo2Min.Enabled = False : txtLo2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLoDeg.ForeColor = &H80000008
		txtLo2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo2Deg.Text) > 180 Or (Val(txtLo2Deg.Text) = 180 And Val(txtLo2Min.Text) <> 0) Then
			txtLo2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLo2Deg.Text) < 180 Then
			'txtLoMin.ForeColor = &H80000008
			txtLo2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLoMin.Text = "    "
		End If
	End Sub
	
	Private Sub txtLo2Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo2Deg.KeyPress
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
	
	Private Sub txtLo2Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo2Deg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLo2Deg.Text) > 180 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLo2Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo2Deg.Enter
		SelectAllText(txtLo2Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtLo2Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLo2Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo2Min.TextChanged
		'txtLoMin.ForeColor = &H80000008
		txtLo2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo2Min.Text) > 59.9 Then
			txtLo2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtLo2Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo2Min.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLo2Min.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
			Case Asc(Chr(8))
				fnumeral = fnumeral & Chr(KeyAscii)
				'Case Asc(",")
			Case Else
				KeyAscii = 0
				Beep()
		End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtLo2Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo2Min.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLo2Min.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLo2Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo2Min.Enter
		SelectAllText(txtLo2Min)
	End Sub
	
	'UPGRADE_WARNING: Event txtBg1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBg1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBg1.TextChanged
		If Val(txtBg1.Text) > 359.9 Then
			txtBg1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtBg1.Text) < 359.9 Then
			'txtDC.ForeColor = &H80000008
			txtBg1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtBg1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBg1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtBg1.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
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
	Private Sub txtBg1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBg1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtBg1.Text) > 359.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtBg1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBg1.Enter
		SelectAllText(txtBg1)
	End Sub
	
	'UPGRADE_WARNING: Event txtBg2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBg2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBg2.TextChanged
		If Val(txtBg2.Text) > 359.9 Then
			txtBg2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtBg2.Text) < 359.9 Then
			'txtDC.ForeColor = &H80000008
			txtBg2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtBg2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBg2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtBg2.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
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
	Private Sub txtBg2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBg2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtBg2.Text) > 359.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtBg2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBg2.Enter
		SelectAllText(txtBg2)
	End Sub
	
	Public Sub LatLong()
		'Next four lines for problem with commas as decimal points in Europe with Favorite Places, etc.
		L1Min = Replace(txtL1Min.Text, ",", ".")
		Lo1Min = Replace(txtLo1Min.Text, ",", ".")
		L2Min = Replace(txtL2Min.Text, ",", ".")
		Lo2Min = Replace(txtLo2Min.Text, ",", ".")
		
		L1 = Val(txtL1Deg.Text) + Val(L1Min) / 60
		If cboL1.Text = "S " Then L1 = -L1
		Lo1 = Val(txtLo1Deg.Text) + Val(Lo1Min) / 60
		If cboLo1.Text = "E " Then Lo1 = -Lo1
		L2 = Val(txtL2Deg.Text) + Val(L2Min) / 60
		If cboL2.Text = "S " Then L2 = -L2
		Lo2 = Val(txtLo2Deg.Text) + Val(Lo2Min) / 60
		If cboLo2.Text = "E " Then Lo2 = -Lo2
		
	End Sub
	Public Function Atan2(ByVal y As Double, ByVal x As Double) As Double
		'Type 1
		'    If y > 0 Then
		'        If x >= y Then
		'            Atan2 = Atn(y / x)
		'        ElseIf x <= -y Then
		'            Atan2 = Atn(y / x) + Pi
		'        Else
		'            Atan2 = Pi / 2 - Atn(x / y)
		'        End If
		'    Else
		'        If x >= -y Then
		'            Atan2 = Atn(y / x)
		'        ElseIf x <= y Then
		'            Atan2 = Atn(y / x) - Pi
		'        Else
		'            Atan2 = -Atn(x / y) - Pi / 2
		'        End If
		'    End If
		
		'Type 2
		'    If x > 0 And y >= 0 Then Atan2 = Atn(y / x)                  'added and y>=0
		'    If x < 0 And y >= 0 Then Atan2 = Atn(y / x) + Pi
		'    If x = 0 And y > 0 Then Atan2 = Pi / 2
		'    If x < 0 And y < 0 Then Atan2 = Atn(y / x) - Pi
		'    If x = 0 And y < 0 Then Atan2 = -Pi / 2
		'    'If x = 0 And y = 0 Then MsgBox "Distance cannot be zero."
		
		'Type 3
		If x > 0 Then
			Atan2 = System.Math.Atan(y / x)
		ElseIf x < 0 Then 
			Atan2 = System.Math.Sign(y) * (Pi - System.Math.Atan(System.Math.Abs(y / x)))
		ElseIf y = 0 Then 
			Atan2 = 0
		Else
			Atan2 = System.Math.Sign(y) * Pi / 2
		End If
		
	End Function
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class