Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form12
	Inherits System.Windows.Forms.Form
	Dim TimeHours, Time1inMinutes, TimeinMinutes, Time2inMinutes, TimeMinutes As Short
	Dim fnumeral As String
	Dim CourseAngle, L2, L1, Lo1, Lo2, Distance As Double
	Dim MaxTimem As Short ', L1forMaxLat As Double
	Dim Lm, Pi, LatDifference, LatDiff, DLo As Double
	Dim L2Deg, Lo2Deg As Short
	Dim CourseAngleDeg, Lo2Min, L2Min, Course, Drift As Double
	Dim MLDeg, Direction As Short
	Dim MP, MP1, MLMin, LmML, MP2, MaxLat As Double
	Dim SignL2, SignL1, MaxLatDeg As Short
	Dim MaxLatMin As Double
	Dim BadCLS As Boolean
	Dim AdjustedCourse As Single
	Dim dphi, q As Double
	Dim Flag1, Flag, Flag2 As Boolean 'Flag used to retain values when switching sailing, Flag1 to exit if positions are the same, Flag2 to exit if composite sailing cannot be used
	Dim LPoint, LPointMin As Double
	Dim LastLo, Increment, LoPoint, FirstLo, LPointDeg As Short
	Dim LoPointPrint As Double
	Dim TabVal As Short 'Case5 As Boolean, Case8 As Boolean, LoPointPrint As Integer
	
	Dim DirectionFinal As Short
	Dim DLoFinal, L2Final, L1Final, Lo1Final, Lo2Final, DistanceFinal As Double
	Dim SignL1Final, SignL2Final As Short
	Dim CourseAngleDegFinal, CourseFinal, CourseAngleFinal As Double
	Dim InitialQuadrant, FinalQuadrant As Short
	Dim Lo1Rhumb, L1Rhumb, L2Rhumb, Lo2Rhumb As Double
	Dim Dist As String
	Dim TotalDistance As Single
	Dim Fix1LD, Fix1LoD As Short
	Dim Fix1L, Fix1LM, Fix1LoM, Fix1Lo As Double
	Dim CourseToFix, CourseToDR, DriftAng As Double
	Dim Lon32, DLon, C, A, L3, B, Lon, Lon31, x As Double 'for GCCrossings
	Dim Lon31Deg, Lon32Deg As Short
	Dim Lon31Min, Lon32Min As Double
	Dim Distance2, Course3, Course1, Distance1, Distance3 As Double
	Dim SignL1CD, DirectionCD, SignL2CD As Short
	Dim L1CD, Lo2CD, DLoCD, Lo1CD, L2CD As Double
	Dim CourseCD, DistanceCD, CourseAngleCD, CourseAngleDegCD As Double
	Dim DistanceComposite, DistanceM2 As Single
	Dim LoVertexMin, DLoVertex, LoVertex, LPointLimit As Double
	Dim LoVertexDeg, Segment As Short
	Dim DLo1, DLo2 As Double
	Dim Flag3, Flag4 As Boolean 'Flag3 used for PointsM2, Flag4 for Drift Angle port or starboard
	Dim ReachedMaxLat, AtMaxLat, LeftMaxLat As Boolean
	Dim LoPointPrintMin, SavedLoPoint, LPointPrint As Double
	Dim ReachedMaxLatCount, LoPointPrintDeg, LeftMaxLatCount As Short
	Dim LPointPrintDeg, CoursePrevious As Short
	Dim Lo2Initial, L1Initial, LPointPrintMin, Lo1Initial, LPointPrior As Double
	Dim Prefix, Suffix As String
	Dim Departure, Factor, CompC, LmMin As Single
	Dim IntLmMin, IntLatDiff, LmDeg, IntDLo As Short
	Dim SMG As Double
	
	'UPGRADE_WARNING: Event chkComposite.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkComposite_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkComposite.CheckStateChanged
		If chkComposite.CheckState = 1 Then Frame3.Visible = True : lblLimLat.Visible = True : txtL3Deg.Visible = True : Label16.Visible = True : cboL3.Visible = True : cmdPoints.Text = "&Points on Composite Route" : txtL3Min.Visible = True : Label15.Visible = True ':optMethod1.Visible = True: optMethod2.Visible = True
		If chkComposite.CheckState = 0 Then Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : cmdPoints.Text = "&Points on Great Circle Route" : txtL3Min.Visible = False : Label15.Visible = False
		If chkComposite.CheckState = 1 And optMethod1.Checked = True Then cmdPoints.Text = "&Points on Composite Route" ': frmPointsOnGCR.Caption = "Points on Composite Route, Method 1"
		If chkComposite.CheckState = 1 And optMethod2.Checked = True Then cmdPoints.Text = "&Points on Composite Route" ': frmPointsOnGCR.Caption = "Points on Composite Route, Method 2"
		If chkComposite.CheckState = 0 Then
			cmdPoints.Text = "&Points on Great Circle Route"
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Cls()
		End If ': cmdPoints_Clickcmd:Calculate_Click:: frmPointsOnGCR.Caption = "Points on Great Circle Route"
	End Sub
	
	'UPGRADE_WARNING: Event chkDriftAngle.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDriftAngle_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDriftAngle.CheckStateChanged
		If chkDriftAngle.CheckState = 1 Then
			Label14.Visible = True
			Label13.Visible = True
			Label12.Visible = True
			Label11.Visible = True
			Label10.Visible = True
			Label9.Visible = True
			txtFix1LD.Visible = True
			txtFix1LM.Visible = True
			txtFix1LoD.Visible = True
			txtFix1LoM.Visible = True
			cboFix1L.Visible = True
			cboFix1Lo.Visible = True
		End If
		If chkDriftAngle.CheckState = 0 Then
			Label14.Visible = False
			Label13.Visible = False
			Label12.Visible = False
			Label11.Visible = False
			Label10.Visible = False
			Label9.Visible = False
			txtFix1LD.Visible = False
			txtFix1LM.Visible = False
			txtFix1LoD.Visible = False
			txtFix1LoM.Visible = False
			cboFix1L.Visible = False
			cboFix1Lo.Visible = False
			txtFix1LD.Text = ""
			txtFix1LM.Text = ""
			txtFix1LoD.Text = ""
			txtFix1LoM.Text = ""
		End If
	End Sub
	
	Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
		'TimeinMinutes = 60 * Val(txtTimeh.Text) + Val(txtTimem.Text)
		'If Val(txtSpeed.Text) * TimeinMinutes / 60 > 600 Then MsgBox "Distance exceeds range for mid-latitude sailing.": Exit Sub
		Flag1 = False
		LatLong()
		If BadCLS = True Then txtMLDeg.Focus() : Exit Sub
		If chkDriftAngle.CheckState = 1 Then DriftAngle()
		If optMidLat.Checked = True Or optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True Then RhumbLine()
		If optGreatCircle.Checked = True Then
			GreatCircle() : cmdPoints.Enabled = True
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Cls() : frmPointsOnGCR.txtLoPointDeg.Text = "" : frmPointsOnGCR.txtLoPointMin.Text = ""
		End If
		If optGreatCircle.Checked = True And optICD.Checked = True And (Lo1 = Lo2 Or (System.Math.Sign(Lo1) <> System.Math.Sign(Lo2) And System.Math.Abs(Lo1) + System.Math.Abs(Lo2) = 180)) Or L1 = 90 Or L1 = -90 Or L2 = 90 Or L2 = -90 Then cmdPoints.Enabled = False
		If optGreatCircle.Checked = True And optL2Lo2GC.Checked = True And (Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180) Then cmdPoints.Enabled = False
		
		If Flag1 = True Then Exit Sub
		
		'If optGreatCircle = True And optICD.Value = True And chkComposite = 1 And optMethod1 = False And optMethod2 = False Then MsgBox ("You must select a method.")
		'If optGreatCircle = True And optICD.Value = True And chkComposite = 1 And optMethod1 = True Then GCCrossings
		'If optGreatCircle = True And optICD.Value = True And chkComposite = 1 And optMethod2 = True Then GCVertices
	End Sub
	Private Sub RhumbLine()
		'Calculate destination position
		If optL2Lo2.Checked = True Then
			'Time
			Time1inMinutes = 60 * Val(VB.Left(txtTime1.Text, 2)) + Val(VB.Right(txtTime1.Text, 2))
			Time2inMinutes = 60 * Val(VB.Left(txtTime2.Text, 2)) + Val(VB.Right(txtTime2.Text, 2))
			TimeinMinutes = Time2inMinutes - Time1inMinutes
			TimeHours = Int(TimeinMinutes / 60) : TimeMinutes = TimeinMinutes - 60 * TimeHours
			'txtTimeh.Text = Str$(TimeHours): txtTimem.Text = Str$(TimeMinutes)
			If TimeinMinutes < 0 Then MsgBox("Error:  Time1 later than Time2") : Exit Sub
			If TimeinMinutes = 0 Then TimeinMinutes = 60 * Val(txtTimeh.Text) + Val(txtTimem.Text)
			'Distance
			If Val(txtLog2.Text) < Val(txtLog1.Text) Then MsgBox("Error:  Log1 greater than Log2") : Exit Sub
			Distance = Val(txtLog2.Text) - Val(txtLog1.Text) ': txtDist.Text = Str$(Distance) 'Log values entered
			If txtLog1.Text = "" And txtLog2.Text = "" Then Distance = Val(txtDist.Text) 'No log values entered
			If Distance = 0 Then Distance = Val(txtSpeed.Text) * TimeinMinutes / 60 ': txtDist.Text = Str$(Distance) 'No log or distance values entered, use speed and time
			'If Distance > 600 Then MsgBox "Distance exceeds range for mid-latitude sailing.": Exit Sub
			If Val(txtCourse.Text) >= 0 And Val(txtCourse.Text) < 90 Then CourseAngle = -Val(txtCourse.Text)
			If Val(txtCourse.Text) >= 90 And Val(txtCourse.Text) < 180 Then CourseAngle = -(180 - Val(txtCourse.Text))
			If Val(txtCourse.Text) >= 180 And Val(txtCourse.Text) < 270 Then CourseAngle = Val(txtCourse.Text) - 180
			If Val(txtCourse.Text) >= 270 And Val(txtCourse.Text) < 360 Then CourseAngle = 360 - Val(txtCourse.Text)
			
			'If L1 = 90 And (Val(txtCourse.Text) <= 90 Or Val(txtCourse.Text) >= 270) Then MsgBox "You can't get there from here.": BadCLS = True: Cls: Exit Sub
			'If L1 = -90 Then AdjustedCourse = Val(txtCourse.Text) + 180: If AdjustedCourse >= 360 Then AdjustedCourse = AdjustedCourse - 360
			'If L1 = -90 And (AdjustedCourse <= 90 Or AdjustedCourse >= 270) Then MsgBox "You can't get there from here.": BadCLS = True: Cls: Exit Sub
			
			LatDiff = (Distance * System.Math.Cos(CourseAngle * Pi / 180)) / 60
			If Val(txtCourse.Text) > 90 And Val(txtCourse.Text) < 270 Then LatDiff = -LatDiff
			L2 = L1 + LatDiff
			If optMidLat.Checked = True And System.Math.Abs(L2) >= 85 Then MsgBox("Latitude too high for Mid-Latitude sailing.") : Exit Sub
			If (optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And (Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180) Then MsgBox("Course crosses pole into other hemisphere.") : Exit Sub
			
			If System.Math.Abs(L2) > 90 And Val(txtCourse.Text) <> 0 And Val(txtCourse.Text) <> 180 Then MsgBox("Distance too large.  Cannot go this far along this rhumb line.") : Exit Sub
			If optMidLat.Checked = True Then
				Lm = (L1 + L2) / 2 'Mid-latitude
				If chkML.CheckState = 1 Then
					If System.Math.Abs(L1 - L2) > 1 Then
						MsgBox("Calculated L2 more than 1º from L1.  CLS SAPS cannot be used.")
						'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						Cls() : Exit Sub
					End If
					Lm = LmML
					
					'TestML
					'If BadCLS = True Then txtMLDeg.SetFocus: Exit Sub
					
					
				End If
				DLo = (Distance * System.Math.Sin(CourseAngle * Pi / 180) / System.Math.Cos(Lm * Pi / 180)) / 60
				If chkML.CheckState = 1 And System.Math.Abs(DLo) > 1 Then
					MsgBox("Calculated Lo2 more than 1º from Lo1.  CLS SAPS cannot be used.")
					'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Cls() : Exit Sub
				End If
				
				'If Val(txtCourse.Text) >= 0 And Val(txtCourse.Text) < 180 Then DLo = -DLo
				'Lo2 = Lo1 + DLo
			End If
			'If optMercator = True And Abs(CourseAngle) >= 85 And Abs(CourseAngle) <= 90 Then  'use mid-latitude
			'    Lm = (L1 + L2) / 2  'Mid-latitude
			'    DLo = (Distance * Sin(CourseAngle * Pi / 180) / Cos(Lm * Pi / 180)) / 60
			'End If
			If (optMercatorE.Checked = True Or optMercatorS.Checked = True) And System.Math.Abs(CourseAngle) <> 90 Then
				MeridionalParts()
				DLo = (System.Math.Tan(CourseAngle * Pi / 180) * MP) / 60 'degrees
				'Else: DLo = (Distance * Sin(CourseAngle * Pi / 180) / Cos(L1 * Pi / 180)) / 60
			End If
			If (optMercatorE.Checked = True Or optMercatorS.Checked = True) And System.Math.Abs(CourseAngle) = 90 Then 'This section not in versions prior to V4.2.1
				MeridionalParts()
				DLo = (Distance * System.Math.Sin(CourseAngle * Pi / 180) / System.Math.Cos(L1 * Pi / 180)) / 60
			End If
			'If optAccurateRhumb = True Then
			
			If optAccurateRhumb.Checked = True Then
				Course = Val(txtCourse.Text)
				L2 = (L1 * Pi / 180) + (Distance / 60 * Pi / 180) * System.Math.Cos(Course * Pi / 180)
				If System.Math.Abs(L2) > 90 Then MsgBox("Distance too large.  Cannot go this far along this rhumb line.") : Exit Sub
				If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1 * Pi / 180) Else dphi = System.Math.Log(System.Math.Tan((L2) / 2 + Pi / 4) / System.Math.Tan((L1 * Pi / 180) / 2 + Pi / 4)) : q = (LatDiff * Pi / 180) / dphi
				DLo = -(Distance / 60 * Pi / 180) * System.Math.Sin(Course * Pi / 180) / q
				DLo = DLo * 180 / Pi
				L2 = L2 * 180 / Pi
			End If
			Lo2 = Lo1 + DLo
			Do While Lo2 >= 360
				Lo2 = Lo2 - 360
			Loop 
			'Crossing IDL
			If System.Math.Abs(Lo2) > 180 Then Lo2 = -System.Math.Sign(Lo2) * (360 - System.Math.Abs(Lo2))
			DisplayDestination()
		End If
		'Calculate course and distance
		If optCD.Checked = True Then
			'If optMidLat = True Then
			CDandSD()
			Course = (Int(Course * 10 + 0.5)) / 10
			DisplayCD()
			'End If
			'If optMercator = True Then
			'    CDandSD
			'    Course = (Int(Course * 10 + 0.5)) / 10
			'    DisplayCD
			'End If
		End If
		'Calculate set and drift
		If optSD.Checked = True Then
			Time1inMinutes = 60 * Val(VB.Left(txtTime1.Text, 2)) + Val(VB.Right(txtTime1.Text, 2))
			Time2inMinutes = 60 * Val(VB.Left(txtTime2.Text, 2)) + Val(VB.Right(txtTime2.Text, 2))
			TimeinMinutes = Time2inMinutes - Time1inMinutes
			TimeHours = Int(TimeinMinutes / 60) : TimeMinutes = TimeinMinutes - 60 * TimeHours
			'txtTimeh.Text = Str$(TimeHours): txtTimem.Text = Str$(TimeMinutes)
			If TimeinMinutes < 0 Then MsgBox("Error:  Time1 later than Time2") : Exit Sub
			If TimeinMinutes = 0 Then TimeinMinutes = 60 * Val(txtTimeh.Text) + Val(txtTimem.Text)
			'If TimeinMinutes = 0 And chkDriftAngle = 0 Then MsgBox "No time entered.  Required for set and drift calculation.": Exit Sub
			CDandSD()
			'Course = Int(Course + 0.5)  'Course = (Int(Course * 10 + 0.5)) / 10        'removed in V5.4.0
			If TimeinMinutes <> 0 Then Drift = System.Math.Abs(Distance / (TimeinMinutes / 60))
			DisplaySD()
			
			If chkDriftAngle.CheckState = 1 Then
				L1 = Fix1L
				Lo1 = Fix1Lo
				CDandSD()
				Distance = System.Math.Abs(Int(Distance * 10 + 0.5) / 10)
				'Course = Int(Course + 0.5)  'Course = (Int(Course * 10 + 0.5)) / 10
				If TimeinMinutes <> 0 Then SMG = Distance / (TimeinMinutes / 60)
				SMG = Int(SMG * 10 + 0.5) / 10
				DisplayCMGSMG()
			End If
			
		End If
	End Sub
	
	Private Sub CDandSD()
		If BadCLS = True Then Exit Sub
		If L1 = L2 And Lo1 = Lo2 Then MsgBox("Initial and final positions are the same.") : Flag1 = True : Exit Sub
		LatDiff = L2 - L1
		DLo = Lo2 - Lo1
		'Crossing IDL
		If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
		If optMidLat.Checked = True Then
			Lm = (L1 + L2) / 2 'Mid-latitude
			If chkML.CheckState = 1 Then Lm = LmML : TestML()
			
			If LatDiff = 0 Then CourseAngle = Pi / 2 Else CourseAngle = System.Math.Abs(System.Math.Atan((DLo * 60 * System.Math.Cos(Lm * Pi / 180)) / (LatDiff * 60)))
			CourseAngleDeg = CourseAngle * 180 / Pi
		End If
		If optMercatorE.Checked = True Or optMercatorS.Checked = True Then
			MeridionalParts()
			If MP = 0 Then CourseAngle = Pi / 2 Else CourseAngle = (System.Math.Atan((DLo * 60) / MP))
			CourseAngleDeg = CourseAngle * 180 / Pi
		End If
		If optAccurateRhumb.Checked = True Then
			dphi = System.Math.Log(System.Math.Tan((L2 * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((L1 * Pi / 180) / 2 + Pi / 4))
			If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1 * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
			'End If
			'If optAccurateRhumb = True Then
			Distance = System.Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff)
			'        If Abs(dphi) < 0.008 Then dphi = 0    'Added in V4.9.3 to eliminte problem when course was exactly 0º; added abs in V5.0.4; value was 0.02  ELIMINATED THIS LINE IN v5.0.4
			CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
			CourseAngleDeg = CourseAngle * 180 / Pi
			If DLo = 0 And L2 > L1 Then CourseAngleDeg = 0 'ADDED THIS LINE IN V5.0.4 FOR WHEN COURSE WAS EXACTLY 0º
		End If
		'CourseAngleDeg = CourseAngle * 180 / Pi
		If optMidLat.Checked = True Or optMercatorE.Checked = True Or optMercatorS.Checked = True Then
			If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
			If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
			If LatDiff < 0 And DLo < 0 Then Course = 180 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
			If LatDiff < 0 And DLo >= 0 Then Course = 180 + System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
		End If
		If optAccurateRhumb.Checked = True Then
			If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
		End If
		If Course >= 360 Then Course = Course - 360 'Added in V4.9.3
		If optMidLat.Checked = True Or optMercatorE.Checked = True Or optMercatorS.Checked = True Then Distance = LatDiff / System.Math.Cos(CourseAngle) 'for both mid-latitude and Mercator; total drift for S&D
		'The next line is called for in text but makes answers worse
		'If Abs(CourseAngleDeg) >= 85 And Abs(CourseAngleDeg) <= 90 Then Distance = (DLo * Cos(Lm * Pi / 180)) / Sin(CourseAngle) 'for both mid-latitude and Mercator; total drift for S&D 'CourseAngle = (90 * Pi / 180) - Abs(CourseAngle)
		If L1 = L2 Then Distance = DLo * System.Math.Cos(L1 * Pi / 180)
		Distance = 60 * Distance
	End Sub
	Private Sub cmdClearAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAll.Click
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		txtL1Deg.Text = ""
		txtL1Min.Text = ""
		txtLo1Deg.Text = ""
		txtLo1Min.Text = ""
		txtL2Deg.Text = ""
		txtL2Min.Text = ""
		txtLo2Deg.Text = ""
		txtLo2Min.Text = ""
		cboL1.SelectedIndex = 0 ' "N "
		cboLo1.SelectedIndex = 0 '"W "
		cboL2.SelectedIndex = 0 ' "N "
		cboLo2.SelectedIndex = 0 ' "W "
		txtCourse.Text = ""
		txtDist.Text = ""
		txtSpeed.Text = ""
		txtTimeh.Text = ""
		txtTimem.Text = ""
		txtMLDeg.Text = ""
		'cboMLmin.Text = ""
		cboMLmin.SelectedIndex = -1
		cboML.SelectedIndex = 0 ' "N "
		chkML.CheckState = System.Windows.Forms.CheckState.Unchecked
		txtLog1.Text = ""
		txtLog2.Text = ""
		txtTime1.Text = ""
		txtTime2.Text = ""
		txtFix1LD.Text = ""
		txtFix1LM.Text = ""
		txtFix1LoD.Text = ""
		txtFix1LoM.Text = ""
		cboL3.SelectedIndex = 0 ' "N "
		txtL3Deg.Text = ""
		txtL3Min.Text = ""
		chkComposite.CheckState = System.Windows.Forms.CheckState.Unchecked
		optMethod1.Checked = False
		optMethod2.Checked = False
	End Sub
	
	Private Sub cmdClearSwap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearSwap.Click
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If optL2Lo2.Checked = True Then
			txtL1Deg.Text = VB6.Format(L2Deg, "#0")
			txtL1Min.Text = VB6.Format(L2Min, "00.0")
			txtLo1Deg.Text = VB6.Format(Lo2Deg, "##0")
			txtLo1Min.Text = VB6.Format(Lo2Min, "00.0")
			If L2 >= 0 Then cboL1.SelectedIndex = 0 Else cboL1.SelectedIndex = 0 ' "N " else "S "
			If Lo2 >= 0 Then cboLo1.SelectedIndex = 0 Else cboLo1.SelectedIndex = 0 '"W " else "E "
		End If
		If optCD.Checked = True Then
			txtL1Deg.Text = txtL2Deg.Text
			txtL1Min.Text = txtL2Min.Text
			txtLo1Deg.Text = txtLo2Deg.Text
			txtLo1Min.Text = txtLo2Min.Text
			cboL1.Text = cboL2.Text
			cboLo1.Text = cboLo2.Text
		End If
		txtL2Deg.Text = ""
		txtL2Min.Text = ""
		txtLo2Deg.Text = ""
		txtLo2Min.Text = ""
		'cboL2.text = "N "
		'cboLo2.text = "W "
		txtCourse.Text = ""
		txtDist.Text = ""
		txtSpeed.Text = ""
		txtTime1.Text = ""
		txtTime2.Text = ""
		txtTimeh.Text = ""
		txtTimem.Text = ""
		If chkML.CheckState = 1 Then Exit Sub
		txtMLDeg.Text = ""
		'cboMLmin.Text = ""
		cboMLmin.SelectedIndex = -1
		cboML.SelectedIndex = 0 ' "N "
		chkML.CheckState = System.Windows.Forms.CheckState.Unchecked
		txtLog1.Text = ""
		txtLog2.Text = ""
	End Sub
	
	Public Sub cmdPoints_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPoints.Click
		If chkComposite.CheckState = 0 Then frmPointsOnGCR.Text = "Points on Great Circle Route"
		If chkComposite.CheckState = 1 And optMethod1.Checked = True Then frmPointsOnGCR.Text = "Points on Composite Route, Method 1"
		If chkComposite.CheckState = 1 And optMethod2.Checked = True Then frmPointsOnGCR.Text = "Points on Composite Route, Method 2"
		frmPointsOnGCR.cmdWaypoint.Enabled = True : If chkComposite.CheckState = 1 And optMethod2.Checked = True Then frmPointsOnGCR.cmdWaypoint.Enabled = False
		If chkComposite.CheckState = 1 And optMethod2.Checked = True Then PointsM2() : Exit Sub
		'If Lo1 = Lo2 Or Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180 Then MsgBox "Longitude change cannot be zero.": Exit Sub
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Cls()
		'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.CurrentY = 490
		frmPointsOnGCR.Show()
		TotalDistance = 0
		Distance = 0
		Lo1Initial = Lo1
		Lo2Initial = Lo2
		ReachedMaxLatCount = 0 : LeftMaxLatCount = 0
		Flag3 = False
		'convert all east longitudes to west
		If Lo1 < 0 Then Lo1 = 360 - System.Math.Abs(Lo1)
		If Lo2 < 0 Then Lo2 = 360 - System.Math.Abs(Lo2)
		If Lon31 < 0 Then Lon31 = 360 - System.Math.Abs(Lon31)
		If Lon32 < 0 Then Lon32 = 360 - System.Math.Abs(Lon32)
		'determine whether traveling should be eastward or westward and increment
		DLo = Lo2 - Lo1
		Increment = 5 : If DLo < 0 Then Increment = -5
		'If Abs(DLo) > 180 Then DLo = 360 - DLo
		If Lo2 > Lo1 And System.Math.Abs(DLo) > 180 And Increment = 5 Then Lo1 = Lo1 + 360 : Increment = -5 : Flag3 = True 'skip next line if this line is used
		If Flag3 = False And Lo2 < Lo1 And System.Math.Abs(DLo) > 180 And Increment = -5 Then Lo2 = Lo2 + 360 : Increment = 5
		'make Lon31 and Lon32 fall between Lo1 and Lo2
		If Lo2 > Lo1 And (Lon31 > Lo2 Or Lon31 < Lo1) Then Lon31 = Lon31 + 360
		If Lo1 > Lo2 And (Lon31 > Lo1 Or Lon31 < Lo2) Then Lon31 = Lon31 + 360
		If Lo2 > Lo1 And (Lon32 > Lo2 Or Lon32 < Lo1) Then Lon32 = Lon32 + 360
		If Lo1 > Lo2 And (Lon32 > Lo1 Or Lon32 < Lo2) Then Lon32 = Lon32 + 360
		
		DLo = System.Math.Abs(Lo2 - Lo1)
		Increment = 5 : Direction = 1
		If Lo2 < Lo1 Then Increment = -5 : Direction = -1
		If DLo > 180 Then DLo = 360 - DLo : Increment = -Increment : Direction = -Direction
		If Increment = -5 And Lo1 < Lo2 Then Lo1 = Lo1 + 360
		If Increment = 5 And Lo1 > Lo2 Then Lo2 = Lo2 + 360
		
		
		If (chkComposite.CheckState = 1 And L1 <> L3) Or chkComposite.CheckState = 0 Then
			TabVal = 5 : If txtLo1Deg.Text = "" Then TabVal = 4
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(TabVal - Len(txtLo1Deg.Text)), VB6.Format(Val(txtLo1Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtLo1Min.Text), "00.0") & "'" & cboLo1.Text) 'If ModFP(Lo1, 5) <> 0 Then
			'frmPointsOnGCR.Print Tab(18 - Len(txtLo1Deg.Text)); Format(Val(txtLo1Deg.Text), "0"); Chr$(176); Format(Val(txtLo1Min.Text), "00.0"); "'"; cboLo1.Text
			TabVal = 16 : If txtL1Deg.Text = "" Then TabVal = 15
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(TabVal - Len(txtL1Deg.Text)), VB6.Format(Val(txtL1Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtL1Min.Text), "00.0") & "'") 'If ModFP(Lo1, 5) <> 0 Then
			'frmPointsOnGCR.Print Tab(6 - Len(txtL1Deg.Text)); Format(Val(txtL1Deg.Text), "0"); Chr$(176); Format(Val(txtL1Min), "00.0"); "'";  '6 was TabVal
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If L1 <> 0 Then frmPointsOnGCR.Print(cboL1.Text) 'ModFP(Lo1, 5) <> 0 And
			'If L1 <> 0 Then frmPointsOnGCR.Print cboL1.Text;
		End If
		
		If Increment = -5 Then
			FirstLo = Lo1 - ModFP(Lo1, 5)
			LastLo = Lo2 - ModFP(Lo2, 5)
			If ModFP(Lo2, 5) = 0 Then LastLo = Lo2
		End If
		If Increment = 5 Then
			FirstLo = Lo1 - ModFP(Lo1, 5)
			LastLo = Lo2 - ModFP(Lo2, 5)
			If ModFP(Lo1, 5) <> 0 Then FirstLo = FirstLo + 5 ': If Segment = 1 Then LastLo = LastLo + 5
			If ModFP(Lo2, 5) = 0 Then LastLo = Lo2
		End If
		
		TotalDistance = 0
		If L1 <> L3 And (FirstLo - Lon31) > 5 And (LastLo - Lon31) > 5 Then Lon31 = Lon31 + 360
		If L2 <> L3 And (FirstLo - Lon32) > 5 And (LastLo - Lon32) > 5 Then Lon32 = Lon32 + 360
		
		AtMaxLat = False : ReachedMaxLat = False : ReachedMaxLatCount = 0 : LeftMaxLat = False : LeftMaxLatCount = 0
		
		For LoPoint = FirstLo To LastLo Step Increment
			If ReachedMaxLatCount = 1 Or LeftMaxLatCount = 1 Then LoPoint = SavedLoPoint
			'        If (LoPoint > Lo2 And Increment = 5) Or (LoPoint < Lo2 And Increment = -5) Then LoPointPrint = Lo2: LPointPrint = L2: GoTo TheLastPoint
			LPoint = System.Math.Atan((System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((LoPoint - Lo2) * Pi / 180) - System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(L1 * Pi / 180) * System.Math.Sin((LoPoint - Lo1) * Pi / 180)) / (System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((Lo1 - Lo2) * Pi / 180)))
			LPoint = LPoint * 180 / Pi
			LoPointPrint = LoPoint
			If chkComposite.CheckState = 1 Then 'And optMethod1 = True   not necessary since Method 2 goes to PointsM2
				'If (LoPoint > Lon31 And Direction = 1) Or (LoPoint < Lon31 And Direction = -1) And Abs(LoPoint - Lon31) < 5 And ReachedMaxLatCount = 0 Then AtMaxLat = True: ReachedMaxLat = True: SavedLoPoint = LoPoint: ReachedMaxLatCount = ReachedMaxLatCount + 1
				If (LoPoint > Lon31 And Increment = 5) Or (LoPoint < Lon31 And Increment = -5) And System.Math.Abs(LoPoint - Lon31) <= 5 And ReachedMaxLatCount = 0 Then AtMaxLat = True : ReachedMaxLat = True : SavedLoPoint = LoPoint : ReachedMaxLatCount = ReachedMaxLatCount + 1
				If AtMaxLat = True And ReachedMaxLat = False Then ReachedMaxLatCount = ReachedMaxLatCount + 1 'to make ReachedMaxLatCount>1
				If ReachedMaxLat = False Then LPointPrint = LPoint : LoPointPrint = LoPoint
				If AtMaxLat = True And ReachedMaxLatCount <> 1 Then LPointPrint = L3 : LoPointPrint = LoPoint
				If AtMaxLat = True And ReachedMaxLatCount = 1 Then LPointPrint = L3 : LoPointPrint = Lon31 : ReachedMaxLat = False
				If AtMaxLat = False Then LoPointPrint = LoPoint : LPointPrint = LPoint
				'If L2 = L3 And AtMaxLat = True Then If Course >= 0 And Course < 180 Then Course = 90 Else Course = 270
				
				'If (LoPoint > Lon32 And Direction = 1) Or (LoPoint < Lon32 And Direction = -1) And Abs(LoPoint - Lon32) < 5 Then LPointPrint = L3: LoPointPrint = Lon32: AtMaxLat = False: LeftMaxLat = True: SavedLoPoint = LoPoint: LeftMaxLatCount = LeftMaxLatCount + 1
				If (LoPoint > Lon32 And Increment = 5) Or (LoPoint < Lon32 And Increment = -5) And System.Math.Abs(LoPoint - Lon32) <= 5 Then LPointPrint = L3 : LoPointPrint = Lon32 : AtMaxLat = False : LeftMaxLat = True : SavedLoPoint = LoPoint : LeftMaxLatCount = LeftMaxLatCount + 1
				If AtMaxLat = True And LeftMaxLat = True Then LeftMaxLatCount = LeftMaxLatCount + 1 'to make LeftMaxLatCount>1
				If AtMaxLat = False And LeftMaxLatCount > 1 Then LPointPrint = LPoint : LoPointPrint = LoPoint
			End If
			
			If chkComposite.CheckState = 0 Then LPointPrint = LPoint : LoPointPrint = LoPoint
			LPointDeg = Int(System.Math.Abs(LPointPrint))
			LPointMin = (System.Math.Abs(LPointPrint) - LPointDeg) * 60
			If Int(LPointMin * 10 + 0.5) / 10 = 60 Then LPointMin = 0 : LPointDeg = LPointDeg + 1
			If LoPointPrint > 180 Then LoPointPrint = -System.Math.Sign(LoPointPrint) * (360 - System.Math.Abs(LoPointPrint))
			LoPointPrintDeg = Int(System.Math.Abs(LoPointPrint))
			LoPointPrintMin = (System.Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60
			If Int(LoPointPrintMin * 10 + 0.5) / 10 = 60 Then LoPointPrintMin = 0 : LoPointPrintDeg = LoPointPrintDeg + 1
			
			'uses Accurate Rhumb Line for course and distance
			L2Rhumb = LPointPrint : Lo2Rhumb = LoPointPrint
			If LoPoint = FirstLo Then L1Rhumb = L1 : Lo1Rhumb = Lo1
			LatDiff = L2Rhumb - L1Rhumb
			DLo = Lo2Rhumb - Lo1Rhumb
			'Crossing IDL
			If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
			dphi = System.Math.Log(System.Math.Tan((L2Rhumb * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((L1Rhumb * Pi / 180) / 2 + Pi / 4))
			If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1Rhumb * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
			Distance = 60 * System.Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff)
			CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
			CourseAngleDeg = CourseAngle * 180 / Pi
			If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			
			Course = Int(Course + 0.5)
			Distance = Int(Distance * 10 + 0.5) / 10
			If LeftMaxLatCount = 1 Then Distance = Distance2
			If AtMaxLat = True And ReachedMaxLatCount > 1 Then Distance = 0
			TotalDistance = TotalDistance + Distance
			Dist = CStr(Str(Distance) Or "000.0")
			
			If LPoint <> L3 Then
				If AtMaxLat = False Or (AtMaxLat = True And ReachedMaxLatCount = 1) Then
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(6 - Len(Str(System.Math.Abs(LoPointPrintDeg)))), VB6.Format(System.Math.Abs(LoPointPrintDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(LoPointPrintMin), "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint > 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("W")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint = 0 Or System.Math.Abs(LoPointPrint) = 180 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint < 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("E")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(17 - Len(Str(LPointDeg))), VB6.Format(LPointDeg, "0") & Chr(176) & VB6.Format(LPointMin, "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint > 0 Then frmPointsOnGCR.Print("N")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint = 0 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint < 0 Then frmPointsOnGCR.Print("S")
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(30), VB6.Format(Course, "000"))
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
				End If
			End If
			
			L1Rhumb = L2Rhumb : Lo1Rhumb = Lo2Rhumb
			
			If chkComposite.CheckState = 0 And System.Math.Abs(LoPoint - Lo2) <= 5 Then GoTo TheLastPoint 'LoPointPrint = Lo2: LPointPrint = L2:
			
			ReachedMaxLat = False 'IS THIS LINE NEEDED?
			CoursePrevious = Course
			'The next line sometimes needs -5 and 5 swapped  WHEN?????  #1 REVERSED WANTS FIRST LINE, #5 FORWARD WANTS SECOND LINE,     problem if L2=L3
			'Want third line if L2=L3
			If L2 <> L3 Then
				If ((LoPoint > Lo2 And Increment = -5) Or (LoPoint < Lo2 And Increment = 5)) And System.Math.Abs(LoPoint - Lo2) <= 5 And System.Math.Abs(Lo2 - Lon32) >= 5 Then GoTo TheLastPoint 'LoPointPrint = Lo2: LPointPrint = L2:   'THIS LINE IS TROUBLE!!!!
				If ((LoPoint > Lo2 And Increment = 5) Or (LoPoint < Lo2 And Increment = -5)) And System.Math.Abs(LoPoint - Lo2) <= 5 And System.Math.Abs(Lo2 - Lon32) < 5 Then GoTo TheLastPoint 'LoPointPrint = Lo2: LPointPrint = L2:   'THIS LINE IS TROUBLE!!!!
			End If
			If L2 = L3 And ((LoPoint > Lo2 And Increment = -5) Or (LoPoint < Lo2 And Increment = 5)) And System.Math.Abs(LoPoint - Lo2) <= 5 Then GoTo TheLastPoint
		Next LoPoint
		
		'TabVal = 6: If L2 = 0 Then TabVal = 5
		If optL2Lo2GC.Checked = True Then
			txtL2Deg.Text = CStr(Int(System.Math.Abs(L2)))
			txtL2Min.Text = CStr((System.Math.Abs(L2) - Int(System.Math.Abs(L2))) * 60)
			txtLo2Deg.Text = CStr(Int(System.Math.Abs(Lo2)))
			txtLo2Min.Text = CStr((System.Math.Abs(Lo2) - Int(System.Math.Abs(Lo2))) * 60)
		End If
		TabVal = 5 : If txtLo2Deg.Text = "" Then TabVal = 4
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtLo2Deg.Text)), VB6.Format(Val(txtLo2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtLo2Min.Text), "00.0") & "'") '6 was TabVal
		If Lo2 <> 0 And ModFP(Lo2, 5) <> 0 Then
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoPointPrint > 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("W")
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoPointPrint = 0 Or System.Math.Abs(LoPointPrint) = 180 Then frmPointsOnGCR.Print(" ")
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoPointPrint < 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("E")
		End If
		TabVal = 16 : If txtL2Deg.Text = "" Then TabVal = 15
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtL2Deg.Text)), VB6.Format(Val(txtL2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtL2Min.Text), "00.0") & "'")
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optL2Lo2GC.Checked = False And ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(cboL2.Text)
		If optL2Lo2GC.Checked = True Then
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(L2) = 1 Then frmPointsOnGCR.Print("N")
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(L2) = 0 Then frmPointsOnGCR.Print("")
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(L2) = -1 Then frmPointsOnGCR.Print("S")
		End If
		
TheLastPoint: 
		'calculate rhumb line course and distance to last point if Lo is not divisible by 5 and destination is not at latitude limit
		If (L2 <> L3 Or chkComposite.CheckState = 0) Then 'ModFP(Lo2, 5) <> 0 And
			L1Rhumb = LPoint
			Lo1Rhumb = LoPoint - Increment : If Lo1Rhumb > 180 Then Lo1Rhumb = -(360 - System.Math.Abs(Lo1Rhumb)) 'Lo1Rhumb = LoPoint - Increment
			'Lo1Rhumb = LoPoint '- Increment: If Lo1Rhumb > 180 Then Lo1Rhumb = -(360 - Abs(Lo1Rhumb))
			If System.Math.Abs(LoPoint - Lo2) <= 5 And Increment = 5 Then Lo1Rhumb = LoPointPrint : L1Rhumb = LPointPrint
			If System.Math.Abs(LoPoint - Lo2) <= 5 And Increment = -5 Then Lo1Rhumb = LoPointPrint : L1Rhumb = LPointPrint
			If chkComposite.CheckState = 0 And System.Math.Abs(LoPoint - Lo2) <= 5 And Increment = -5 Then Lo1Rhumb = LoPointPrint : L1Rhumb = LPointPrint
			L2Rhumb = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60 : If cboL2.Text = "S " Then L2Rhumb = -L2Rhumb
			Lo2Rhumb = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60 : If cboLo2.Text = "E " Then Lo2Rhumb = -Lo2Rhumb
			If Lo2Rhumb < 0 Then Lo2Rhumb = 360 - System.Math.Abs(Lo2Rhumb)
			LatDiff = L2Rhumb - L1Rhumb
			DLo = Lo2Rhumb - Lo1Rhumb
			'Crossing IDL
			If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
			
			dphi = System.Math.Log(System.Math.Tan((L2Rhumb * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((L1Rhumb * Pi / 180) / 2 + Pi / 4))
			If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1Rhumb * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
			Distance = 60 * System.Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff)
			CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
			CourseAngleDeg = CourseAngle * 180 / Pi
			If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			Course = Int(Course + 0.5)
			Distance = Int(Distance * 10 + 0.5) / 10
			TotalDistance = TotalDistance + Distance
		End If
		If L2 = L3 And chkComposite.CheckState = 1 Then
			Distance = Distance2 'this and next line removed because of total distance of #6
			TotalDistance = TotalDistance + Distance
			If CoursePrevious > 0 And CoursePrevious < 180 Then Course = 90 Else Course = 270
		End If
		
		TotalDistance = Int(TotalDistance * 10 + 0.5) / 10
		Dist = CStr(Str(Distance) Or "000.0")
		'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Print(TAB(30), VB6.Format(Course, "000"))
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
		'   frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
		If LoPointPrint <> Lo2 Then
			TabVal = 5 : If txtLo2Deg.Text = "" Then TabVal = 4
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(TabVal - Len(txtLo2Deg.Text)), VB6.Format(Val(txtLo2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtLo2Min.Text), "00.0") & "'" & cboLo2.Text)
			TabVal = 16 : If txtL2Deg.Text = "" Then TabVal = 15
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(TabVal - Len(txtL2Deg.Text)), VB6.Format(Val(txtL2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtL2Min.Text), "00.0") & "'" & cboL2.Text)
		End If
		
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Print(TAB(14), "Total rhumb line distance = " & VB6.Format(TotalDistance, "0.0") & " nm")
		cmdPoints.Enabled = False
		
	End Sub
	
	Private Sub cmdTraverse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTraverse.Click
		LatLong()
		'Time
		Time1inMinutes = 60 * Val(VB.Left(txtTime1.Text, 2)) + Val(VB.Right(txtTime1.Text, 2))
		Time2inMinutes = 60 * Val(VB.Left(txtTime2.Text, 2)) + Val(VB.Right(txtTime2.Text, 2))
		TimeinMinutes = Time2inMinutes - Time1inMinutes
		TimeHours = Int(TimeinMinutes / 60) : TimeMinutes = TimeinMinutes - 60 * TimeHours
		'txtTimeh.Text = Str$(TimeHours): txtTimem.Text = Str$(TimeMinutes)
		If TimeinMinutes < 0 Then MsgBox("Error:  Time1 later than Time2") : Exit Sub
		If TimeinMinutes = 0 Then TimeinMinutes = 60 * Val(txtTimeh.Text) + Val(txtTimem.Text)
		'Distance
		If Val(txtLog2.Text) < Val(txtLog1.Text) Then MsgBox("Error:  Log1 greater than Log2") : Exit Sub
		Distance = Val(txtLog2.Text) - Val(txtLog1.Text) ': txtDist.Text = Str$(Distance) 'Log values entered
		If txtLog1.Text = "" And txtLog2.Text = "" Then Distance = Val(txtDist.Text) 'No log values entered
		If Distance = 0 Then Distance = Val(txtSpeed.Text) * TimeinMinutes / 60 ': txtDist.Text = Str$(Distance) 'No log or distance values entered, use speed and time
		'If Distance > 600 Then MsgBox "Distance exceeds range for mid-latitude sailing.": Exit Sub
		If Val(txtCourse.Text) >= 0 And Val(txtCourse.Text) < 90 Then CourseAngle = Val(txtCourse.Text) : Prefix = "N" : Suffix = "E"
		If Val(txtCourse.Text) >= 90 And Val(txtCourse.Text) < 180 Then CourseAngle = 180 - Val(txtCourse.Text) : Prefix = "S" : Suffix = "E"
		If Val(txtCourse.Text) >= 180 And Val(txtCourse.Text) < 270 Then CourseAngle = Val(txtCourse.Text) - 180 : Prefix = "S" : Suffix = "W"
		If Val(txtCourse.Text) >= 270 And Val(txtCourse.Text) < 360 Then CourseAngle = 360 - Val(txtCourse.Text) : Prefix = "N" : Suffix = "W"
		
		'If L1 = 90 And (Val(txtCourse.Text) <= 90 Or Val(txtCourse.Text) >= 270) Then MsgBox "You can't get there from here.": BadCLS = True: Cls: Exit Sub
		'If L1 = -90 Then AdjustedCourse = Val(txtCourse.Text) + 180: If AdjustedCourse >= 360 Then AdjustedCourse = AdjustedCourse - 360
		'If L1 = -90 And (AdjustedCourse <= 90 Or AdjustedCourse >= 270) Then MsgBox "You can't get there from here.": BadCLS = True: Cls: Exit Sub
		
		
		'        LatDiff = (Distance * Cos(CourseAngle * Pi / 180)) / 60
		'        If Val(txtCourse.text) > 90 And Val(txtCourse.text) < 270 Then LatDiff = -LatDiff
		'        L2 = L1 + LatDiff
		If System.Math.Abs(L2) > 90 Then MsgBox("Distance too large.  Cannot go this far along this rhumb line.") : Exit Sub
		'            Lm = (L1 + L2) / 2  'Mid-latitude
		'DLo = (Distance * Sin(CourseAngle * Pi / 180) / Cos(Lm * Pi / 180)) / 60
		
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form12.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4600
		Factor = System.Math.Cos(CourseAngle * Pi / 180)
		Factor = Int(Factor * 10 + 0.5) / 10
		LatDiff = Distance * Factor
		LatDiff = Int(LatDiff * 10 + 0.5) / 10
		IntLatDiff = Int(LatDiff + 0.5)
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "1. C = " & Prefix & Str(System.Math.Abs(CourseAngle)) & Chr(176) & " " & Suffix & "    factor (C) = " & CStr(System.Math.Abs(Factor)))
		CompC = 90 - CourseAngle
		Factor = System.Math.Cos(CompC * Pi / 180)
		Factor = Int(Factor * 10 + 0.5) / 10
		Departure = Distance * Factor
		Departure = Int(Departure * 10 + 0.5) / 10
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "2. Complement C = " & Str(CompC) & Chr(176) & "    factor (Comp C) = " & CStr(System.Math.Abs(Factor)))
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "3. Diff Lat = " & Str(LatDiff) & "' rounded to " & Str(IntLatDiff) & "'")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "4. Departure = " & System.Math.Abs(Departure) & " nm")
		If Val(txtCourse.Text) > 90 And Val(txtCourse.Text) < 270 Then IntLatDiff = -IntLatDiff
		L2 = L1 + IntLatDiff / 60
		If System.Math.Abs(L2) >= 85 Then MsgBox("Latitude too high for Simplified Traverse Table, a form of mid-latitude sailing.") : Exit Sub
		L2Deg = Int(System.Math.Abs(L2))
		L2Min = (System.Math.Abs(L2) - L2Deg) * 60 : L2Min = Int(L2Min + 0.5)
		If L2Min = 60 Then L2Min = 0 : L2Deg = L2Deg + 1
		If Lo2Min = 60 Then Lo2Min = 0 : Lo2Deg = Lo2Deg + 1
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "5. L2 = " & VB6.Format(L2Deg, "0") & Chr(176) & VB6.Format(L2Min, "00") & "'")
		If System.Math.Abs(L2) < 0.01 Then
			L2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 > 0 And System.Math.Abs(L2) > 0.01 Then Print("N")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 < 0 And System.Math.Abs(L2) > 0.01 Then Print("S")
		L2 = System.Math.Sign(L2) * (L2Deg + L2Min / 60)
		Lm = (L1 + L2) / 2 'Mid-latitude
		Factor = System.Math.Abs(System.Math.Cos(Lm * Pi / 180))
		Factor = Int(Factor * 10 + 0.5) / 10
		LmDeg = Int(System.Math.Abs(Lm))
		LmMin = (System.Math.Abs(Lm) - LmDeg) * 60 : LmMin = Int(LmMin * 10 + 0.5) / 10
		IntLmMin = Int(LmMin + 0.5)
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "6. Mid Lat = " & VB6.Format(LmDeg, "0") & Chr(176) & VB6.Format(LmMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lm >= 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lm < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" rounded to " & VB6.Format(LmDeg, "0") & Chr(176) & VB6.Format(IntLmMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lm >= 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lm < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(33), "factor (Mid-Lat) = " & Factor)
		DLo = Int(Departure / Factor * 10 + 0.5) / 10
		IntDLo = System.Math.Sign(DLo) * Int(System.Math.Abs(DLo) + 0.5)
		'    If (cboLo1.text = "E " And Val(txtCourse.text) >= 180) Or (cboLo1.text = "W " And Val(txtCourse.text) <= 180) Then IntDLo = -IntDLo
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "7. Diff Lo = " & Str(System.Math.Abs(DLo)) & "' rounded to " & Str(System.Math.Abs(IntDLo)) & "'")
		If Val(txtCourse.Text) > 0 And Val(txtCourse.Text) < 180 Then IntDLo = -IntDLo
		Lo2 = Lo1 + IntDLo / 60
		Do While Lo2 >= 360
			Lo2 = Lo2 - 360
		Loop 
		'Crossing IDL
		If System.Math.Abs(Lo2) > 180 Then Lo2 = -System.Math.Sign(Lo2) * (360 - System.Math.Abs(Lo2))
		Lo2Deg = Int(System.Math.Abs(Lo2))
		Lo2Min = (System.Math.Abs(Lo2) - Lo2Deg) * 60 : Lo2Min = Int(Lo2Min + 0.5)
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "8. Lo2 = " & VB6.Format(Lo2Deg, "0") & Chr(176) & VB6.Format(Lo2Min, "00") & "'")
		If System.Math.Abs(Lo2) < 0.01 Then
			Lo2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Abs(Lo2) > 179.999 Then Print("")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 > 0 And System.Math.Abs(Lo2) < 179.999 Then Print("W")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 < 0 And System.Math.Abs(Lo2) < 179.999 Then Print("E")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Answer:  Arrival Position = L2 " & VB6.Format(L2Deg, "0") & Chr(176) & VB6.Format(L2Min, "00") & "'")
		If System.Math.Abs(L2) < 0.01 Then
			L2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 > 0 And System.Math.Abs(L2) > 0.01 Then Print("N")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 < 0 And System.Math.Abs(L2) > 0.01 Then Print("S")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Lo2 " & VB6.Format(Lo2Deg, "0") & Chr(176) & VB6.Format(Lo2Min, "00") & "'")
		If System.Math.Abs(Lo2) < 0.01 Then
			Lo2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Abs(Lo2) > 179.999 Then Print("")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 > 0 And System.Math.Abs(Lo2) < 179.999 Then Print("W")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 < 0 And System.Math.Abs(Lo2) < 179.999 Then Print("E")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" by Simplified Traverse Table")
		
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtDist.Text = "" And txtTimeh.Text = "" And txtTimem.Text = "" And txtTime1.Text <> "" Then Print(TAB(30), "Run Time  " & VB6.Format(TimeHours, "##0") & "h" & VB6.Format(TimeMinutes, "00") & "m")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtDist.Text = "" Then Print(TAB(30), "Distance   " & VB6.Format(Distance, "##0.0") & " nm")
		
		
	End Sub
	
	Private Sub Form12_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event optAccurateRhumb.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optAccurateRhumb_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAccurateRhumb.CheckedChanged
		If eventSender.Checked Then
			If optAccurateRhumb.Checked = True Then cmdTraverse.Visible = False
			chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
			frameCalculate.Visible = True
			frameCalculateGC.Visible = False
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			Flag = True
			If optL2Lo2.Checked = True Then optL2Lo2_CheckedChanged(optL2Lo2, New System.EventArgs())
			If optCD.Checked = True Then optCD_CheckedChanged(optCD, New System.EventArgs())
			If optSD.Checked = True Then optSD_CheckedChanged(optSD, New System.EventArgs())
			Flag = False
			optICD.Visible = False
			lblInitial.Visible = False
			optL2Lo2.Visible = True
			optL2Lo2GC.Visible = False
			optCD.Visible = True
			optSD.Visible = True
			chkML.Visible = False
			txtMLDeg.Visible = False
			Label4.Visible = False
			cboMLmin.Visible = False
			Label1.Visible = False
			cboML.Visible = False
			cmdPoints.Visible = False
			'cmdPoints.Enabled = False
			txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
			txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
			LatLong() : If L1 <> L2 Or Lo1 <> Lo2 Then cmdCalculate_Click(cmdCalculate, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optGreatCircle.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optGreatCircle_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optGreatCircle.CheckedChanged
		If eventSender.Checked Then
			If optGreatCircle.Checked = True Then cmdTraverse.Visible = False : ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 90") : ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 90")
			chkComposite.CheckState = System.Windows.Forms.CheckState.Unchecked
			If optGreatCircle.Checked = True And optICD.Checked = True Then chkComposite.Visible = True
			If optGreatCircle.Checked = True Then chkDriftAngle.Visible = False
			
			frameCalculate.Visible = False
			frameCalculateGC.Visible = True
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			Flag = True
			If optL2Lo2GC.Checked = True Then optL2Lo2GC_CheckedChanged(optL2Lo2GC, New System.EventArgs())
			If optICD.Checked = True Then optICD_CheckedChanged(optICD, New System.EventArgs())
			Flag = False
			
			cmdPoints.Visible = True
			'cmdPoints.Enabled = False
			optL2Lo2.Visible = False
			optL2Lo2GC.Visible = True
			optCD.Visible = False
			'optCD = True
			optSD.Visible = False
			optICD.Visible = True
			'optICD.Value = True
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			cmdClearSwap.Visible = True
			'cmdClearSwap.Enabled = True
			chkML.Visible = False
			txtMLDeg.Visible = False
			Label4.Visible = False
			cboMLmin.Visible = False
			Label1.Visible = False
			cboML.Visible = False
			txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
			txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
			LatLong() : If L1 <> L2 Or Lo1 <> Lo2 Then cmdCalculate_Click(cmdCalculate, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optICD.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optICD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optICD.CheckedChanged
		If eventSender.Checked Then
			If optGreatCircle.Checked = True Then chkComposite.Visible = True
			
			If Flag = False Then cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optL2Lo2.Value = True Then
			'cmdClearAll_Click
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			'txtTimeh.Text = ""
			'txtTimem.Text = ""
			lblL2.Visible = True
			txtL2Deg.Visible = True
			lblLDeg.Visible = True
			txtL2Min.Visible = True
			lblLMin.Visible = True
			cboL2.Visible = True
			lblLo2.Visible = True
			txtLo2Deg.Visible = True
			lblLoDeg.Visible = True
			txtLo2Min.Visible = True
			lblLoMin.Visible = True
			cboLo2.Visible = True
			lblCourse.Visible = False
			txtCourse.Visible = False
			lblInitial.Visible = False
			lblCourseDeg.Visible = False
			lblDistance.Visible = False
			txtDist.Visible = False
			lblnm.Visible = False
			lblor.Visible = False
			lblor2.Visible = False
			lblSpeed.Visible = False
			txtSpeed.Visible = False
			lblkn.Visible = False
			lblTime.Visible = False
			txtTimeh.Visible = False
			lblh.Visible = False
			txtTimem.Visible = False
			lblm.Visible = False
			cmdClearSwap.Visible = True
			'cmdClearSwap.Enabled = True
			lblDRL.Visible = False
			lblDRLo.Visible = False
			lblFixL.Visible = False
			lblFixLo.Visible = False
			lblLog1.Visible = False
			lblLog2.Visible = False
			lblTime1.Visible = False
			lblTime2.Visible = False
			lblLog1nm.Visible = False
			lblLog2nm.Visible = False
			''txtTime1.Text = ""
			''txtTime2.Text = ""
			txtLog1.Visible = False
			txtLog2.Visible = False
			txtTime1.Visible = False
			txtTime2.Visible = False
			Shape1.Visible = False
			Line2.Visible = False
			Line3.Visible = False
			Line4.Visible = False
			Line5.Visible = False
			Line6.Visible = False
			Label14.Visible = False
			Label13.Visible = False
			Label12.Visible = False
			Label11.Visible = False
			Label10.Visible = False
			Label9.Visible = False
			txtFix1LD.Visible = False
			txtFix1LM.Visible = False
			txtFix1LoD.Visible = False
			txtFix1LoM.Visible = False
			cboFix1L.Visible = False
			cboFix1Lo.Visible = False
			txtFix1LD.Text = ""
			txtFix1LM.Text = ""
			txtFix1LoD.Text = ""
			txtFix1LoM.Text = ""
			If optCD.Checked = True Then chkDriftAngle.Visible = False
			chkDriftAngle.CheckState = System.Windows.Forms.CheckState.Unchecked
			'    End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optL2Lo2GC.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optL2Lo2GC_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optL2Lo2GC.CheckedChanged
		If eventSender.Checked Then
			chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
			If Flag = False Then cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optL2Lo2.Value = True Then
			'cmdClearAll_Click
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			'txtTimeh.Text = ""
			'txtTimem.Text = ""
			lblL2.Visible = False
			txtL2Deg.Visible = False
			lblLDeg.Visible = False
			txtL2Min.Visible = False
			lblLMin.Visible = False
			cboL2.Visible = False
			lblLo2.Visible = False
			txtLo2Deg.Visible = False
			lblLoDeg.Visible = False
			txtLo2Min.Visible = False
			lblLoMin.Visible = False
			cboLo2.Visible = False
			lblCourse.Visible = True
			txtCourse.Visible = True
			lblInitial.Visible = True
			lblCourseDeg.Visible = True
			lblDistance.Visible = True
			txtDist.Visible = True
			lblnm.Visible = True
			lblor.Visible = False
			lblor2.Visible = False
			lblSpeed.Visible = False
			txtSpeed.Visible = False
			lblkn.Visible = False
			lblTime.Visible = False
			txtTimeh.Visible = False
			lblh.Visible = False
			txtTimem.Visible = False
			lblm.Visible = False
			cmdClearSwap.Visible = True
			'cmdClearSwap.Enabled = True
			lblDRL.Visible = False
			lblDRLo.Visible = False
			lblFixL.Visible = False
			lblFixLo.Visible = False
			lblLog1.Visible = False
			lblLog2.Visible = False
			lblTime1.Visible = False
			lblTime2.Visible = False
			lblLog1nm.Visible = False
			lblLog2nm.Visible = False
			''txtTime1.Text = ""
			''txtTime2.Text = ""
			txtLog1.Visible = False
			txtLog2.Visible = False
			txtTime1.Visible = False
			txtTime2.Visible = False
			Shape1.Visible = False
			Line2.Visible = False
			Line3.Visible = False
			Line4.Visible = False
			Line5.Visible = False
			Line6.Visible = False
			chkDriftAngle.Visible = False
			chkDriftAngle.CheckState = System.Windows.Forms.CheckState.Unchecked
			
			'    End If
			
		End If
	End Sub
	
	Private Sub optMercator_Click()
		If optMercatorE.Checked = True Or optMercatorS.Checked = True Then cmdTraverse.Visible = False
		chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
		frameCalculate.Visible = True
		frameCalculateGC.Visible = False
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		Flag = True
		If optL2Lo2.Checked = True Then optL2Lo2_CheckedChanged(optL2Lo2, New System.EventArgs())
		If optCD.Checked = True Then optCD_CheckedChanged(optCD, New System.EventArgs())
		If optSD.Checked = True Then optSD_CheckedChanged(optSD, New System.EventArgs())
		Flag = False
		optICD.Visible = False
		lblInitial.Visible = False
		optL2Lo2.Visible = True
		optL2Lo2GC.Visible = False
		optCD.Visible = True
		optSD.Visible = True
		chkML.Visible = False
		txtMLDeg.Visible = False
		Label4.Visible = False
		cboMLmin.Visible = False
		Label1.Visible = False
		cboML.Visible = False
		cmdPoints.Visible = False
		'cmdPoints.Enabled = False
		txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
		txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
		cmdCalculate_Click(cmdCalculate, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event optMercatorE.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMercatorE_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMercatorE.CheckedChanged
		If eventSender.Checked Then
			'If optMercatorE = True Then
			cmdTraverse.Visible = False : ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 89") : ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 89")
			chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
			frameCalculate.Visible = True
			frameCalculateGC.Visible = False
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			Flag = True
			If optL2Lo2.Checked = True Then optL2Lo2_CheckedChanged(optL2Lo2, New System.EventArgs())
			If optCD.Checked = True Then optCD_CheckedChanged(optCD, New System.EventArgs())
			If optSD.Checked = True Then optSD_CheckedChanged(optSD, New System.EventArgs())
			Flag = False
			optICD.Visible = False
			lblInitial.Visible = False
			optL2Lo2.Visible = True
			optL2Lo2GC.Visible = False
			optCD.Visible = True
			optSD.Visible = True
			chkML.Visible = False
			txtMLDeg.Visible = False
			Label4.Visible = False
			cboMLmin.Visible = False
			Label1.Visible = False
			cboML.Visible = False
			cmdPoints.Visible = False
			'cmdPoints.Enabled = False
			txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
			txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
			LatLong() : If L1 <> L2 Or Lo1 <> Lo2 Then cmdCalculate_Click(cmdCalculate, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optMercatorS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMercatorS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMercatorS.CheckedChanged
		If eventSender.Checked Then
			'If optMercatorS = True Then
			cmdTraverse.Visible = False : ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 89") : ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 89")
			chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
			frameCalculate.Visible = True
			frameCalculateGC.Visible = False
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			Flag = True
			If optL2Lo2.Checked = True Then optL2Lo2_CheckedChanged(optL2Lo2, New System.EventArgs())
			If optCD.Checked = True Then optCD_CheckedChanged(optCD, New System.EventArgs())
			If optSD.Checked = True Then optSD_CheckedChanged(optSD, New System.EventArgs())
			Flag = False
			optICD.Visible = False
			lblInitial.Visible = False
			optL2Lo2.Visible = True
			optL2Lo2GC.Visible = False
			optCD.Visible = True
			optSD.Visible = True
			chkML.Visible = False
			txtMLDeg.Visible = False
			Label4.Visible = False
			cboMLmin.Visible = False
			Label1.Visible = False
			cboML.Visible = False
			cmdPoints.Visible = False
			'cmdPoints.Enabled = False
			txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
			txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
			LatLong() : If L1 <> L2 Or Lo1 <> Lo2 Then cmdCalculate_Click(cmdCalculate, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optMethod1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMethod1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMethod1.CheckedChanged
		If eventSender.Checked Then
			If txtL3Deg.Text = "" Then MsgBox("Enter a latitude limit from 1 to 89 degrees") : Exit Sub
			'cmdPoints.Caption = "&Points on Composite Route"
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Cls() ': cmdPoints_Click:cmdCalculate_Click:frmPointsOnGCR.Caption = "Points on Composite Route, Method 1":
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optMethod2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMethod2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMethod2.CheckedChanged
		If eventSender.Checked Then
			If txtL3Deg.Text = "" Then MsgBox("Enter a latitude limit from 1 to 89 degrees") : Exit Sub
			'cmdPoints.Caption = "&Points on Composite Route"
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Cls() ': cmdPoints_Click: cmdCalculate_Click:frmPointsOnGCR.Caption = "Points on Composite Route, Method 2":
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optMidLat.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMidLat_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMidLat.CheckedChanged
		If eventSender.Checked Then
			If optMidLat.Checked = True Then ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 84") : ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 84")
			If optMidLat.Checked = True And optL2Lo2.Checked = True Then cmdTraverse.Visible = True
			chkComposite.Visible = False : Frame3.Visible = False : lblLimLat.Visible = False : txtL3Deg.Visible = False : Label16.Visible = False : cboL3.Visible = False : optMethod1.Checked = False : optMethod2.Checked = False : txtL3Min.Visible = False : Label15.Visible = False
			frameCalculate.Visible = True
			frameCalculateGC.Visible = False
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			Flag = True
			If optL2Lo2.Checked = True Then optL2Lo2_CheckedChanged(optL2Lo2, New System.EventArgs())
			If optCD.Checked = True Then optCD_CheckedChanged(optCD, New System.EventArgs())
			If optSD.Checked = True Then optSD_CheckedChanged(optSD, New System.EventArgs())
			Flag = False
			optICD.Visible = False
			lblInitial.Visible = False
			optL2Lo2GC.Visible = False
			optL2Lo2.Visible = True
			optCD.Visible = True
			optSD.Visible = True
			chkML.Visible = True
			txtMLDeg.Visible = True
			Label4.Visible = True
			cboMLmin.Visible = True
			Label1.Visible = True
			cboML.Visible = True
			cmdPoints.Visible = False
			'cmdPoints.Enabled = False
			txtL1Deg_TextChanged(txtL1Deg, New System.EventArgs())
			txtL2Deg_TextChanged(txtL2Deg, New System.EventArgs())
			LatLong() : If L1 <> L2 Or Lo1 <> Lo2 Then cmdCalculate_Click(cmdCalculate, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optL2Lo2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optL2Lo2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optL2Lo2.CheckedChanged
		If eventSender.Checked Then
			If optMidLat.Checked = True And optL2Lo2.Checked = True Then cmdTraverse.Visible = True
			If Flag = False Then cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optL2Lo2.Value = True Then
			'cmdClearAll_Click
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			'txtTimeh.Text = ""
			'txtTimem.Text = ""
			lblL2.Visible = False
			txtL2Deg.Visible = False
			lblLDeg.Visible = False
			txtL2Min.Visible = False
			lblLMin.Visible = False
			cboL2.Visible = False
			lblLo2.Visible = False
			txtLo2Deg.Visible = False
			lblLoDeg.Visible = False
			txtLo2Min.Visible = False
			lblLoMin.Visible = False
			cboLo2.Visible = False
			lblCourse.Visible = True
			txtCourse.Visible = True
			lblCourseDeg.Visible = True
			lblDistance.Visible = True
			txtDist.Visible = True
			lblnm.Visible = True
			lblor.Visible = True
			lblor2.Visible = False
			lblSpeed.Visible = True
			txtSpeed.Visible = True
			lblkn.Visible = True
			lblTime.Visible = True
			txtTimeh.Visible = True
			lblh.Visible = True
			txtTimem.Visible = True
			lblm.Visible = True
			cmdClearSwap.Visible = True
			'cmdClearSwap.Enabled = True
			lblDRL.Visible = False
			lblDRLo.Visible = False
			lblFixL.Visible = False
			lblFixLo.Visible = False
			lblLog1.Visible = True
			lblLog2.Visible = True
			lblTime1.Visible = True
			lblTime2.Visible = True
			lblLog1nm.Visible = True
			lblLog2nm.Visible = True
			''txtTime1.Text = ""
			''txtTime2.Text = ""
			txtLog1.Visible = True
			txtLog2.Visible = True
			txtTime1.Visible = True
			txtTime2.Visible = True
			Shape1.Visible = True
			Line2.Visible = True
			Line3.Visible = True
			Line4.Visible = True
			Line5.Visible = True
			Line6.Visible = True
			Label14.Visible = False
			Label13.Visible = False
			Label12.Visible = False
			Label11.Visible = False
			Label10.Visible = False
			Label9.Visible = False
			txtFix1LD.Visible = False
			txtFix1LM.Visible = False
			txtFix1LoD.Visible = False
			txtFix1LoM.Visible = False
			cboFix1L.Visible = False
			cboFix1Lo.Visible = False
			txtFix1LD.Text = ""
			txtFix1LM.Text = ""
			txtFix1LoD.Text = ""
			txtFix1LoM.Text = ""
			chkDriftAngle.Visible = False
			chkDriftAngle.CheckState = System.Windows.Forms.CheckState.Unchecked
			'    End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optCD.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optCD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCD.CheckedChanged
		If eventSender.Checked Then
			If optCD.Checked = True Then cmdTraverse.Visible = False
			If Flag = False Then cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optCD.Value = True Then
			'cmdClearAll_Click
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			lblL2.Visible = True
			txtL2Deg.Visible = True
			lblLDeg.Visible = True
			txtL2Min.Visible = True
			lblLMin.Visible = True
			cboL2.Visible = True
			lblLo2.Visible = True
			txtLo2Deg.Visible = True
			lblLoDeg.Visible = True
			txtLo2Min.Visible = True
			lblLoMin.Visible = True
			cboLo2.Visible = True
			lblCourse.Visible = False
			txtCourse.Visible = False
			lblCourseDeg.Visible = False
			lblDistance.Visible = False
			txtDist.Visible = False
			lblnm.Visible = False
			lblor.Visible = False
			lblor2.Visible = False
			lblSpeed.Visible = False
			txtSpeed.Visible = False
			lblkn.Visible = False
			lblTime.Visible = False
			txtTimeh.Visible = False
			lblh.Visible = False
			txtTimem.Visible = False
			lblm.Visible = False
			cmdClearSwap.Visible = True
			'cmdClearSwap.Enabled = True
			lblDRL.Visible = False
			lblDRLo.Visible = False
			lblFixL.Visible = False
			lblFixLo.Visible = False
			lblLog1.Visible = False
			lblLog2.Visible = False
			lblTime1.Visible = False
			lblTime2.Visible = False
			lblLog1nm.Visible = False
			lblLog2nm.Visible = False
			'txtTime1.Text = ""
			'txtTime2.Text = ""
			txtLog1.Visible = False
			txtLog2.Visible = False
			txtTime1.Visible = False
			txtTime2.Visible = False
			Shape1.Visible = False
			Line2.Visible = False
			Line3.Visible = False
			Line4.Visible = False
			Line5.Visible = False
			Line6.Visible = False
			chkDriftAngle.Visible = False
			chkDriftAngle.CheckState = System.Windows.Forms.CheckState.Unchecked
			'    End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optSD.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optSD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSD.CheckedChanged
		If eventSender.Checked Then
			If optSD.Checked = True Then cmdTraverse.Visible = False
			If Flag = False Then cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optSD.Value = True Then
			'cmdClearAll_Click
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			'txtL1Deg.Text = ""
			'txtLo1Deg.Text = ""
			'txtL1Min.Text = ""
			'txtLo1Min.Text = ""
			'cboL1.Text = "N "
			'cboLo1.Text = "W "
			'txtTimeh.Text = ""
			'txtTimem.Text = ""
			lblL2.Visible = True
			txtL2Deg.Visible = True
			lblLDeg.Visible = True
			txtL2Min.Visible = True
			lblLMin.Visible = True
			cboL2.Visible = True
			lblLo2.Visible = True
			txtLo2Deg.Visible = True
			lblLoDeg.Visible = True
			txtLo2Min.Visible = True
			lblLoMin.Visible = True
			cboLo2.Visible = True
			lblCourse.Visible = False
			txtCourse.Visible = False
			lblCourseDeg.Visible = False
			lblDistance.Visible = False
			txtDist.Visible = False
			'txtDist.Text = ""
			lblnm.Visible = False
			lblor.Visible = False
			lblor2.Visible = True
			lblSpeed.Visible = False
			txtSpeed.Visible = False
			'txtSpeed.Text = ""
			lblkn.Visible = False
			lblTime.Visible = True
			txtTimeh.Visible = True
			lblh.Visible = True
			txtTimem.Visible = True
			lblm.Visible = True
			cmdClearSwap.Visible = False
			'cmdClearSwap.Enabled = False
			lblDRL.Visible = True
			lblDRLo.Visible = True
			lblFixL.Visible = True
			lblFixLo.Visible = True
			lblLog1.Visible = False
			lblLog2.Visible = False
			lblTime1.Visible = True
			'txtTime1.Text = ""
			lblTime2.Visible = True
			'txtTime2.Text = ""
			lblLog1nm.Visible = False
			lblLog2nm.Visible = False
			txtLog1.Visible = False
			'txtLog1.Text = ""
			txtLog2.Visible = False
			'txtLog2.Text = ""
			txtTime1.Visible = True
			txtTime2.Visible = True
			Shape1.Visible = False
			Line2.Visible = False
			Line3.Visible = False
			Line4.Visible = False
			Line5.Visible = True
			Line6.Visible = False
			If optSD.Checked = True Then chkDriftAngle.Visible = True
			'    End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtL1Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL1Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.TextChanged
		txtL1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If (optGreatCircle.Checked = True And Val(txtL1Deg.Text) > 90) Or ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL1Deg.Text) > 89) Or (optMidLat.Checked = True And Val(txtL1Deg.Text) > 84) Then 'Or (Val(txtL1Deg.Text) = 90 And Val(txtL1Min.Text) <> 0) Then
			txtL1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL1Deg.Text) <= 89) Or (optMidLat.Checked = True And Val(txtL1Deg.Text) <= 84) Then
			'txtL1Min.ForeColor = &H80000008
			txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtL1Min.Text = "  "
		End If
		If optGreatCircle.Checked = True Then
			If Val(txtL1Deg.Text) <> 90 Then txtL1Min.Enabled = True : txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			If Val(txtL1Deg.Text) = 90 Then txtL1Min.Text = "" : txtL1Min.Enabled = False : txtL1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtL1Deg.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000008)
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
		If ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL1Deg.Text) > 89) Or (optMidLat.Checked = True And Val(txtL1Deg.Text) > 84) Then
			KeepFocus = True
		End If
		If optGreatCircle.Checked = True And Val(txtL1Deg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL1Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.Enter
		SelectAllText(txtL1Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtL1Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL1Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Min.TextChanged
		'txtL1Min.ForeColor = &H80000008
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
		'txtLo1Deg.ForeColor = &H80000008
		txtLo1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo1Deg.Text) > 180 Or (Val(txtLo1Deg.Text) = 180 And Val(txtLo1Min.Text) <> 0) Then
			txtLo1Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLo1Deg.Text) < 180 Then
			'txtLo1Min.ForeColor = &H80000008
			txtLo1Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLo1Min.Text = "    "
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
		'txtLo1Min.ForeColor = &H80000008
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
		txtL2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If (optGreatCircle.Checked = True And Val(txtL2Deg.Text) > 90) Or ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL2Deg.Text) > 89) Or (optMidLat.Checked = True And Val(txtL2Deg.Text) > 84) Then 'Or (Val(txtL2Deg.Text) = 90 And Val(txtL2Min.Text) <> 0) Then
			txtL2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL2Deg.Text) <= 89) Or (optMidLat.Checked = True And Val(txtL2Deg.Text) <= 84) Then
			'txtL2Min.ForeColor = &H80000008
			txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtL2Min.Text = "  "
		End If
		If optGreatCircle.Checked = True Then
			If Val(txtL2Deg.Text) <> 90 Then txtL2Min.Enabled = True : txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			If Val(txtL2Deg.Text) = 90 Then txtL2Min.Text = "" : txtL2Min.Enabled = False : txtL2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtL2Deg.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000008)
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
		If ((optMercatorE.Checked = True Or optMercatorS.Checked = True Or optAccurateRhumb.Checked = True) And Val(txtL2Deg.Text) > 89) Or (optMidLat.Checked = True And Val(txtL2Deg.Text) > 84) Then
			KeepFocus = True
		End If
		If optGreatCircle.Checked = True And Val(txtL1Deg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL2Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Deg.Enter
		SelectAllText(txtL2Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtL2Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL2Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL2Min.TextChanged
		'txtL2Min.ForeColor = &H80000008
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
		'txtLo2Deg.ForeColor = &H80000008
		txtLo2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLo2Deg.Text) > 180 Or (Val(txtLo2Deg.Text) = 180 And Val(txtLo2Min.Text) <> 0) Then
			txtLo2Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLo2Deg.Text) < 180 Then
			'txtLo2Min.ForeColor = &H80000008
			txtLo2Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLo2Min.Text = "    "
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
		'txtLo2Min.ForeColor = &H80000008
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
	
	'UPGRADE_WARNING: Event txtCourse.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCourse_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.TextChanged
		If Val(txtCourse.Text) > 359.9 Then
			txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtCourse.Text) < 359.9 Then
			'txtCourse.ForeColor = &H80000008
			txtCourse.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txtCourse_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
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
		If Val(txtCourse.Text) > 359.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtCourse_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.Enter
		SelectAllText(txtCourse)
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
		If Val(txtDist.Text) > 10800 Then
			txtDist.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtDist.Text) <= 10800 Then
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
		'If Val(txtDist.Text) > 600 Then
		'    KeepFocus = True
		'End If
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
	
	'UPGRADE_WARNING: Event txtMLDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLDeg.TextChanged
		If Val(txtMLDeg.Text) <= 54 Then cboMLmin.Enabled = True Else cboMLmin.Enabled = False
		If (Val(txtMLDeg.Text) = 54 And Val(cboMLmin.Text) > 30) Or Val(txtMLDeg.Text) > 55 Then ': cboMLmin.BackColor = &H8000000B
			txtMLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			cboMLmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		
		'txtMLDeg.ForeColor = &H80000008
		'txtMLDeg.BackColor = &H80000005
		'If Val(txtMLDeg.Text) > 88 Then ' Or (Val(txtMLDeg.Text) = 90 And Val(cboMLmin.Text) <> 0) Then
		'    txtMLDeg.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
		If Val(txtMLDeg.Text) < 55 Or (Val(txtMLDeg.Text) = 55 And Val(cboMLmin.Text) <= 30) Then
			'cboMLmin.ForeColor = &H80000008
			txtMLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			cboMLmin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'cboMLmin.Text = "  "
		End If
	End Sub
	Private Sub txtMLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMLDeg.KeyPress
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
	
	Private Sub txtMLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMLDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMLDeg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLDeg.Enter
		SelectAllText(txtMLDeg)
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
		If Val(txtTimeh.Text) <> 0 Then MaxTimem = 59 Else MaxTimem = 999
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
	
	Public Sub LatLong()
		BadCLS = False
		L1 = Val(txtL1Deg.Text) + Val(txtL1Min.Text) / 60
		If cboL1.Text = "S " Then L1 = -L1
		Lo1 = Val(txtLo1Deg.Text) + Val(txtLo1Min.Text) / 60
		If cboLo1.Text = "E " Then Lo1 = -Lo1
		L2 = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60
		If cboL2.Text = "S " Then L2 = -L2
		Lo2 = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60
		If cboLo2.Text = "E " Then Lo2 = -Lo2
		If optMidLat.Checked = True And chkML.CheckState = 1 Then
			If (optCD.Checked = True Or optSD.Checked = True) And System.Math.Abs(L1 - L2) > 1 Then MsgBox("Maximum difference in latitude for CLS SAPS plot is 1º.") : BadCLS = True : Exit Sub
			If (optCD.Checked = True Or optSD.Checked = True) And System.Math.Abs(Lo1 - Lo2) > 1 Then MsgBox("Maximum difference in longitude for CLS SAPS plot is 1º.") : BadCLS = True : Exit Sub
			'"(optCD = True Or optSD = True) And" added in above lines.  Is it necessary?
			LmML = Val(txtMLDeg.Text) + Val(cboMLmin.Text) / 60
			If cboML.Text = "S " Then LmML = -LmML
			TestML()
			'If BadCLS = True Then txtMLDeg.SetFocus: Exit Sub
		End If
		
		Fix1L = Val(txtFix1LD.Text) + Val(txtFix1LM.Text) / 60
		If cboFix1L.Text = "S " Then Fix1L = -Fix1L
		Fix1Lo = Val(txtFix1LoD.Text) + Val(txtFix1LoM.Text) / 60
		If cboFix1Lo.Text = "E " Then Fix1Lo = -Fix1Lo
		
	End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		Pi = 4 * System.Math.Atan(1#)
		'lblICD.Visible = False
		BadCLS = False
	End Sub
	
	Private Sub Form12_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		chkComposite.Visible = False
		lblLimLat.Visible = False
		txtL3Deg.Visible = False
		Label16.Visible = False
		Frame3.Visible = False
		txtL3Min.Visible = False
		Label15.Visible = False
		frameCalculate.Visible = True
		frameCalculateGC.Visible = False
		optL2Lo2.Visible = True : optL2Lo2.Checked = False
		optCD.Visible = True : optCD.Checked = True
		optSD.Visible = True : optSD.Checked = False
		cboL1.SelectedIndex = 0 '"N"
		cboLo1.SelectedIndex = 0 '"W"
		cboL2.SelectedIndex = 0 '"N"
		cboLo2.SelectedIndex = 0 '"W"
		cboFix1L.SelectedIndex = 0 '"N"
		cboFix1Lo.SelectedIndex = 0 '"W"
		cboML.SelectedIndex = 0 '"N"
		optCD_CheckedChanged(optCD, New System.EventArgs())
		cboL3.SelectedIndex = 0 '"N"
	End Sub
	
	Public Sub DisplayDestination()
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If BadCLS = True Then Exit Sub
		'UPGRADE_ISSUE: Form property Form12.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4600
		L2Deg = Int(System.Math.Abs(L2))
		L2Min = (System.Math.Abs(L2) - L2Deg) * 60 : L2Min = Int(L2Min * 10 + 0.5) / 10
		If L2Min = 60 Then L2Min = 0 : L2Deg = L2Deg + 1
		Lo2Deg = Int(System.Math.Abs(Lo2))
		Lo2Min = (System.Math.Abs(Lo2) - Lo2Deg) * 60 : Lo2Min = Int(Lo2Min * 10 + 0.5) / 10
		If Lo2Min = 60 Then Lo2Min = 0 : Lo2Deg = Lo2Deg + 1
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(44), "L2     ", TAB(57 - Len(Str(L2Deg))), VB6.Format(L2Deg, "0") & Chr(176) & VB6.Format(L2Min, "00.0") & "'")
		If System.Math.Abs(L2) < 0.01 Then
			L2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 > 0 And System.Math.Abs(L2) > 0.01 Then Print("N")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 < 0 And System.Math.Abs(L2) > 0.01 Then Print("S")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(44), "Lo2    ", TAB(57 - Len(Str(Lo2Deg))), VB6.Format(Lo2Deg, "0") & Chr(176) & VB6.Format(Lo2Min, "00.0") & "'")
		If System.Math.Abs(Lo2) < 0.01 Then
			Lo2 = 0
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Abs(Lo2) > 179.999 Then Print("")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 > 0 And System.Math.Abs(Lo2) < 179.999 Then Print("W")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo2 < 0 And System.Math.Abs(Lo2) < 179.999 Then Print("E")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtDist.Text = "" And txtTimeh.Text = "" And txtTimem.Text = "" And txtTime1.Text <> "" Then Print(TAB(44), "Run Time  " & VB6.Format(TimeHours, "##0") & "h" & VB6.Format(TimeMinutes, "00") & "m")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optL2Lo2GC.Checked = False And txtDist.Text = "" Then Print(TAB(44), "Distance   " & VB6.Format(Distance, "##0.0") & " nm")
		If (optMercatorE.Checked = True Or optMercatorS.Checked = True) And System.Math.Abs(CourseAngle) <> 90 Then '< 85 Then
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(44), "M1            " & VB6.Format(System.Math.Abs(MP1), "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(44), "M2            " & VB6.Format(System.Math.Abs(MP2), "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(44), "m              " & VB6.Format(System.Math.Abs(MP), "###0.0"))
		End If
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optMercatorE.Checked = True Or optMercatorS.Checked = True) And System.Math.Abs(CourseAngle) = 90 Then Print(TAB(18), "Calculated by conventional mid-latitude sailing for courses directly east or west.")
		If optGreatCircle.Checked = True Then
			MaxLatDeg = Int(System.Math.Abs(MaxLat))
			MaxLatMin = (System.Math.Abs(MaxLat) - MaxLatDeg) * 60 : MaxLatMin = Int(MaxLatMin * 10 + 0.5) / 10
			If MaxLatMin = 60 Then MaxLatMin = 0 : MaxLatDeg = MaxLatDeg + 1
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(31), "Maximum latitude           " & VB6.Format(MaxLatDeg, "0") & Chr(176) & VB6.Format(MaxLatMin, "00.0") & "'")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optICD.Checked = True And CourseAngleDeg < 90 Then Print(cboL2.Text)
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optICD.Checked = True And CourseAngleDeg >= 90 Then Print(cboL1.Text) 'need Abs?
			If optL2Lo2GC.Checked = True And System.Math.Abs(MaxLat) < 0.01 Then
				MaxLat = 0
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print("")
			End If
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optL2Lo2GC.Checked = True And MaxLat > 0 And System.Math.Abs(MaxLat) > 0.01 Then Print("N")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optL2Lo2GC.Checked = True And MaxLat < 0 And System.Math.Abs(MaxLat) > 0.01 Then Print("S")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" at " & VB6.Format(LoVertexDeg, "0") & Chr(176) & VB6.Format(LoVertexMin, "00.0") & "'")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoVertex < 0 Then Print("E")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoVertex > 0 Then Print("W")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LoVertex = 0 Then Print(" ")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(36), "Final course           " & VB6.Format(CourseFinal, "000.00") & Chr(176) & " True => " & VB6.Format(CourseFinal, "000") & Chr(176) & " True")
		End If
		
	End Sub
	
	Public Sub DisplayCD()
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If BadCLS = True Then Exit Sub
		'UPGRADE_ISSUE: Form property Form12.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4600
		'CourseAngleDeg = Int(CourseAngleDeg + 0.5)
		Distance = System.Math.Abs(Int(Distance * 10 + 0.5) / 10)
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optGreatCircle.Checked = True And chkComposite.CheckState = 0 Then Print("Great Circle Sailing results:")
		If optGreatCircle.Checked = True And chkComposite.CheckState = 1 Then
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optMethod1.Checked = True Then Print("Composite Sailing results, Method 1:")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optMethod2.Checked = True Then Print("Composite Sailing results, Method 2:")
		End If
		'UPGRADE_ISSUE: Form property Form12.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optGreatCircle.Checked = True Then CurrentY = 4800
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optGreatCircle.Checked = True Then Print(TAB(26), "Initial ")
		'CurrentY = 4600
		'If optGreatCircle = True And chkComposite = 1 And optMethod2 = True Then Course = Course1: CourseFinal = Course3
		If optGreatCircle.Checked = True And chkComposite.CheckState = 1 Then
			Course = Course1
			'If L2 <> L3 Then CourseFinal = Course3
			CourseFinal = Course3
		End If
		Course = (Int(Course * 100 + 0.5)) / 100
		If Course >= 360 Then Course = Course - 360
		
		CourseFinal = (Int(CourseFinal * 100 + 0.5)) / 100
		If CourseFinal >= 360 Then CourseFinal = CourseFinal - 360
		
		'    If optGreatCircle = True And chkComposite = 1 And optMethod2 = True Then Course = Course1: CourseFinal = Course3
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optGreatCircle.Checked = False Then Print(TAB(26))
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Course", TAB(52), VB6.Format(Course, "000.00") & Chr(176) & " True => " & VB6.Format(Course, "000") & Chr(176) & " True")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optGreatCircle.Checked = True And chkComposite.CheckState = 0) Or optGreatCircle.Checked = False Then Print(TAB(26), "Distance", TAB(52), VB6.Format(Distance, "0.0") & " nm")
		If optMercatorE.Checked = True Or optMercatorS.Checked = True Then
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "M1", TAB(52), VB6.Format(System.Math.Abs(MP1), "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "M2", TAB(52), VB6.Format(System.Math.Abs(MP2), "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "m", TAB(52), VB6.Format(System.Math.Abs(MP), "###0.0"))
		End If
		If optGreatCircle.Checked = True And chkComposite.CheckState = 0 Then
			MaxLatDeg = Int(System.Math.Abs(MaxLat))
			MaxLatMin = (System.Math.Abs(MaxLat) - MaxLatDeg) * 60 : MaxLatMin = Int(MaxLatMin * 10 + 0.5) / 10
			If MaxLatMin = 60 Then MaxLatMin = 0 : MaxLatDeg = MaxLatDeg + 1
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "Maximum latitude", TAB(52), VB6.Format(MaxLatDeg, "0") & Chr(176) & VB6.Format(MaxLatMin, "00.0") & "'")
			
			''If SignL1 = 1 And SignL2 = 1 Then Print "N"
			''If SignL1 = -1 And SignL2 = -1 Then Print "S"
			''If SignL1 = 1 And SignL2 = -1 And Abs(L1) > Abs(L2) Then Print "N"
			''If SignL1 = 1 And SignL2 = -1 And Abs(L1) < Abs(L2) Then Print "S"
			''If SignL1 = -1 And SignL2 = 1 And Abs(L1) > Abs(L2) Then Print "S"
			''If SignL1 = -1 And SignL2 = 1 And Abs(L1) < Abs(L2) Then Print "N"
			''If ??????????? then Print " "
			'If Course > 90 And Course < 270 Then Print "S"
			'If Course = 90 Or Course = 270 Then Print " "
			'If Course < 90 Or Course > 270 Then Print "N"
			'If MaxLat = 90 Then Print "N"
			'If MaxLat = -90 Then Print "S"
			'If Abs(MaxLat) < 90 And CourseAngleDeg < 90 And CourseAngleDeg <> 0 Then Print cboL2 'Else Print cboL1 'need Abs?
			'If Abs(MaxLat) < 90 And CourseAngleDeg >= 90 And CourseAngleDeg <> 0 Then Print cboL1
			'If Abs(MaxLat) <= 90 And CourseAngleDeg = 0 And Sgn(MaxLat) = 1 Then Print "N"
			'If Abs(MaxLat) <= 90 And CourseAngleDeg = 0 And Sgn(MaxLat) = -1 Then Print "S"
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(MaxLat) = 1 Then Print("N")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(MaxLat) = -1 Then Print("S")
			If MaxLat <> 90 Then 'added If MaxLat <> 90 in V5.1.2
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(" at " & VB6.Format(LoVertexDeg, "0") & Chr(176) & VB6.Format(LoVertexMin, "00.0") & "'")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LoVertex < 0 Then Print("E")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LoVertex > 0 Then Print("W")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If LoVertex = 0 Then Print(" ")
			End If
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "Final Course", TAB(52), VB6.Format(CourseFinal, "000.00") & Chr(176) & " True => " & VB6.Format(CourseFinal, "000") & Chr(176) & " True")
		End If
		L3 = Val(txtL3Deg.Text) + Val(txtL3Min.Text) / 60 : If cboL3.Text = "S " Then L3 = -L3
		If optGreatCircle.Checked = True And chkComposite.CheckState = 1 Then
			If L1 <> L3 Then
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(TAB(19), "Route reaches latitude limit at   " & VB6.Format(Lon31Deg, "0") & Chr(176) & VB6.Format(Lon31Min, "00.0") & "'")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon31 > 0 Then Print("W")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon31 < 0 Then Print("E")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon31 = 0 Then Print(" ")
			End If
			'If optMethod1 = True Then Print
			'If optMethod2 = True Then Print
			If L2 <> L3 Then
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(TAB(20), "Route leaves latitude limit at    " & VB6.Format(Lon32Deg, "0") & Chr(176) & VB6.Format(Lon32Min, "00.0") & "'")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon32 > 0 Then Print("W")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon32 < 0 Then Print("E")
				'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lon32 = 0 Then Print(" ")
			End If
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If L1 <> L3 Then Print(TAB(10), "Distance from departure to latitude limit  " & VB6.Format(Distance1, "0.0") & " nm")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(12), "Distance along limiting latitude parallel  " & VB6.Format(Distance2, "0.0") & " nm")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If L2 <> L3 Then Print(TAB(9), "Distance from latitude limit to destination  " & VB6.Format(Distance3, "0.0") & " nm")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(18), "Total composite sailing distance  " & VB6.Format(DistanceComposite, "0.0") & " nm")
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(35), "Final Course    " & VB6.Format(CourseFinal, "000.00") & Chr(176) & " True => " & VB6.Format(CourseFinal, "000") & Chr(176) & " True")
			
		End If
		'End If
	End Sub
	Public Sub DisplaySD()
		'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If BadCLS = True Then Exit Sub
		'UPGRADE_ISSUE: Form property Form12.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4600
		'CourseAngleDeg = Int(CourseAngleDeg + 0.5)
		Distance = System.Math.Abs(Int(Distance * 10 + 0.5) / 10)
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "Set", TAB(52), VB6.Format(Course, "000.00") & Chr(176) & " True => " & VB6.Format(Course, "000") & Chr(176) & " True") 'was Format(Course, "000"); Chr$(176); " True" until V5.4.0
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "Total Drift", TAB(52), VB6.Format(Distance, "0.0") & " nm")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TimeinMinutes <> 0 Then Print(TAB(26), "Drift", TAB(52), VB6.Format(Drift, "0.0") & " kn")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkDriftAngle.CheckState = 1 Then Print(TAB(26), "Drift Angle", TAB(52), VB6.Format(DriftAng, "#0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If CourseToFix < CourseToDR And Flag4 = False Then Print(" to port")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If CourseToFix > CourseToDR And Flag4 = False Then Print(" to starboard")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If CourseToFix < CourseToDR And Flag4 = True Then Print(" to starboard")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If CourseToFix > CourseToDR And Flag4 = True Then Print(" to port")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If txtTimeh.Text = "" And txtTimem.Text = "" And TimeinMinutes <> 0 Then Print(TAB(26), "Run Time", TAB(52), VB6.Format(TimeHours, "##0") & "h" & VB6.Format(TimeMinutes, "00") & "m")
		If optMercatorE.Checked = True Or optMercatorS.Checked = True Then
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "M1", TAB(52), VB6.Format((System.Math.Abs(MP1) * 10 + 0.5) / 10, "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "M2", TAB(52), VB6.Format((System.Math.Abs(MP2) * 10 + 0.5) / 10, "###0.0"))
			'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(26), "m", TAB(52), VB6.Format(System.Math.Abs(MP), "###0.0"))
		End If
	End Sub
	Public Sub DisplayCMGSMG()
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "Distance between fixes      " & VB6.Format(Distance, "0.0") & " nm")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "Course Made Good (CMG)  " & VB6.Format(Course, "000.00") & Chr(176) & " True => " & VB6.Format(Course, "000") & Chr(176) & " True")
		'UPGRADE_ISSUE: Form method Form12.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TimeinMinutes <> 0 Then Print(TAB(26), "Speed Made Good (SMG)    " & VB6.Format(SMG, "0.0") & " kn")
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
	
	Public Sub MeridionalParts()
		If optMercatorS.Checked Then
			MP1 = 7915.704468 * (System.Math.Log(System.Math.Tan((45 + System.Math.Abs(L1) / 2) * Pi / 180))) / System.Math.Log(10) - 23.268932 * System.Math.Sin(System.Math.Abs(L1) * Pi / 180) - 0.0525 * (System.Math.Sin(System.Math.Abs(L1) * Pi / 180)) ^ 3 - 0.000213 * (System.Math.Sin(System.Math.Abs(L1) * Pi / 180)) ^ 5
			MP2 = 7915.704468 * (System.Math.Log(System.Math.Tan((45 + System.Math.Abs(L2) / 2) * Pi / 180))) / System.Math.Log(10) - 23.268932 * System.Math.Sin(System.Math.Abs(L2) * Pi / 180) - 0.0525 * (System.Math.Sin(System.Math.Abs(L2) * Pi / 180)) ^ 3 - 0.000213 * (System.Math.Sin(System.Math.Abs(L2) * Pi / 180)) ^ 5
		End If
		'simpler formula
		'MP1 = 7915.704468 * (Log(Tan((45 + Abs(L1) / 2) * Pi / 180))) / Log(10) - 23.0133633 * Sin(Abs(L1) * Pi / 180)
		'MP2 = 7915.704468 * (Log(Tan((45 + Abs(L2) / 2) * Pi / 180))) / Log(10) - 23.0133633 * Sin(Abs(L2) * Pi / 180)
		If optMercatorE.Checked Then
			'From Bowditch 2002
			MP1 = 7915.704468 * (System.Math.Log(System.Math.Tan((45 + System.Math.Abs(L1) / 2) * Pi / 180))) / System.Math.Log(10) - 23.0133633 * System.Math.Sin(System.Math.Abs(L1) * Pi / 180) - 0.051353 * (System.Math.Sin(System.Math.Abs(L1) * Pi / 180)) ^ 3 - 0.000206 * (System.Math.Sin(System.Math.Abs(L1) * Pi / 180)) ^ 5
			MP2 = 7915.704468 * (System.Math.Log(System.Math.Tan((45 + System.Math.Abs(L2) / 2) * Pi / 180))) / System.Math.Log(10) - 23.0133633 * System.Math.Sin(System.Math.Abs(L2) * Pi / 180) - 0.051353 * (System.Math.Sin(System.Math.Abs(L2) * Pi / 180)) ^ 3 - 0.000206 * (System.Math.Sin(System.Math.Abs(L2) * Pi / 180)) ^ 5
		End If
		If System.Math.Sign(L1) = System.Math.Sign(L2) Then MP = System.Math.Abs(MP2 - MP1)
		If System.Math.Sign(L1) <> System.Math.Sign(L2) Then MP = System.Math.Abs(MP2) + System.Math.Abs(MP1)
	End Sub
	
	Private Sub GreatCircle()
		'Convert east longitudes to west, >180
		'    If Lo1 < 0 Then Lo1 = 360 - Abs(Lo1)
		'    If Lo2 < 0 Then Lo2 = 360 - Abs(Lo2)
		'    DLo = Lo2 - Lo1
		'    If Abs(DLo) > 180 Then DLo = -(360 - Abs(DLo))
		'    Direction = 1 'west
		'    If DLo < 0 Then Direction = -1
		'If optICD.Value = True And chkComposite = 1 And optMethod1 = False And optMethod2 = False Then MsgBox ("You must select a method.")
		If optICD.Checked = True Then
			If L1 = L2 And Lo1 = Lo2 Then MsgBox("Initial and final positions are the same.") : Flag1 = True : Exit Sub
			If optGreatCircle.Checked = True And L1 = -L2 And System.Math.Sign(Lo1) <> System.Math.Sign(Lo2) And System.Math.Abs(Lo1) + System.Math.Abs(Lo2) = 180 Then
				'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls() : MsgBox("Distance 10800 nm.  Course between antipodal points is undefined.") : Exit Sub
			End If
			'If optGreatCircle = True And L1 = -L2 And DLo = 180 Then Cls: MsgBox "Distance 10800 nm.  Course between antipodal points is undefined.": Exit Sub
			If Lo1 <> Lo2 And chkComposite.CheckState = 1 And optMethod1.Checked = False And optMethod2.Checked = False Then MsgBox("You must select a method.") : Exit Sub 'added Lo1<>LO2 in V5.1.2
			'If Lo1 = Lo2 And L1 > L2 Then Course = 180: Distance = Abs(L2 - L1) * 60: FinalGCCourse: DisplayCD: Exit Sub
			'If Lo1 = Lo2 And L1 < L2 Then Course = 0: Distance = Abs(L2 - L1) * 60: FinalGCCourse: DisplayCD: Exit Sub
			If Lo1 = Lo2 Then
				If chkComposite.CheckState = 1 Then MsgBox("Composite Sailing not needed and will be disabled.") : chkComposite.CheckState = System.Windows.Forms.CheckState.Unchecked 'added If chkComposite = 1 Then in V5.1.2
				If L1 > L2 Then Course = 180 : CourseFinal = 180
				If L1 < L2 Then Course = 0 : CourseFinal = 0
				Distance = System.Math.Abs(L2 - L1) * 60
				If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = L1
				If System.Math.Abs(L1) < System.Math.Abs(L2) Or System.Math.Abs(L1) = System.Math.Abs(L2) Then MaxLat = L2
				'MaxLatDeg = Int(Abs(MaxLat))
				'MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60
				'FinalGCCourse
				DisplayCD()
				Exit Sub
			End If
			If System.Math.Sign(Lo1) <> System.Math.Sign(Lo2) And System.Math.Abs(Lo1) + System.Math.Abs(Lo2) = 180 Then
				'If DLo = 180 Then
				'If Abs(L1) > Abs(L2) Then Course = 0
				'If Abs(L1) < Abs(L2) Then Course = 180
				'Distance = Abs(L2 - L1) * 60
				'If Abs(L1) > Abs(L2) Then MaxLat = L1
				'If Abs(L1) < Abs(L2) Then MaxLat = L2
				If System.Math.Abs(L1) >= System.Math.Abs(L2) And System.Math.Sign(L1) = System.Math.Sign(L2) And L1 > 0 Then Course = 0 : Distance = (180 - System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = 90 : CourseFinal = 180
				If System.Math.Abs(L1) >= System.Math.Abs(L2) And System.Math.Sign(L1) = System.Math.Sign(L2) And L1 < 0 Then Course = 180 : Distance = (180 - System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = -90 : CourseFinal = 0
				If System.Math.Abs(L1) >= System.Math.Abs(L2) And System.Math.Sign(L1) <> System.Math.Sign(L2) And L1 > 0 Then Course = 0 : Distance = (180 + System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = 90 : CourseFinal = 180
				If System.Math.Abs(L1) >= System.Math.Abs(L2) And System.Math.Sign(L1) <> System.Math.Sign(L2) And L1 < 0 Then Course = 180 : Distance = (180 + System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = -90 : CourseFinal = 0
				If System.Math.Abs(L1) < System.Math.Abs(L2) And System.Math.Sign(L1) = System.Math.Sign(L2) And L1 > 0 Then Course = 0 : Distance = (180 - System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = 90 : CourseFinal = 180
				If System.Math.Abs(L1) < System.Math.Abs(L2) And System.Math.Sign(L1) = System.Math.Sign(L2) And L1 < 0 Then Course = 180 : Distance = (180 - System.Math.Abs(L2) - System.Math.Abs(L1)) * 60 : MaxLat = -90 : CourseFinal = 0
				If System.Math.Abs(L1) < System.Math.Abs(L2) And System.Math.Sign(L1) <> System.Math.Sign(L2) And L1 > 0 Then Course = 180 : Distance = (180 - System.Math.Abs(L2) + System.Math.Abs(L1)) * 60 : MaxLat = -90 : CourseFinal = 0
				If System.Math.Abs(L1) < System.Math.Abs(L2) And System.Math.Sign(L1) <> System.Math.Sign(L2) And L1 < 0 Then Course = 0 : Distance = (180 - System.Math.Abs(L2) + System.Math.Abs(L1)) * 60 : MaxLat = 90 : CourseFinal = 180
				'MaxLatDeg = Int(Abs(MaxLat))
				'MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60
				'FinalGCCourse
				DisplayCD()
				Exit Sub
			End If
			If System.Math.Abs(L1) = 90 Or System.Math.Abs(L2) = 90 Then
				If L1 = 90 Or L2 = -90 Then Course = 180 : CourseFinal = 180
				If L1 = -90 Or L2 = 90 Then Course = 0 : CourseFinal = 0
				If L1 = 90 Then MaxLat = 90
				If L1 = -90 Then MaxLat = -90
				If System.Math.Sign(L1) = System.Math.Sign(L2) Then Distance = 60 * System.Math.Abs(L1 - L2)
				If System.Math.Sign(L1) <> System.Math.Sign(L2) Then Distance = 60 * (System.Math.Abs(L1) + System.Math.Abs(L2))
				DisplayCD()
				Exit Sub
			End If
			
			Direction = 1 'West
			DLo = Lo2 - Lo1 : If DLo < 0 Then Direction = -1
			If DLo > 180 Then DLo = 360 - DLo : Direction = -1
			If DLo < -180 Then DLo = 360 - System.Math.Abs(DLo) : Direction = 1
			'If DLo < 0 Then Direction = -1
			SignL1 = System.Math.Sign(L1)
			SignL2 = System.Math.Sign(L2)
			If System.Math.Sign(L1) <> System.Math.Sign(L2) And System.Math.Sign(L1) <> 0 And System.Math.Sign(L2) <> 0 Then L2 = -System.Math.Abs(L2) Else L2 = System.Math.Abs(L2)
			L1 = System.Math.Abs(L1)
			Distance = System.Math.Sin(L1 * Pi / 180) * System.Math.Sin(L2 * Pi / 180) + System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Cos(DLo * Pi / 180)
			Distance = System.Math.Atan(-Distance / (System.Math.Sqrt(-Distance * Distance + 1) + 9.999999E-21)) + Pi / 2
			CourseAngle = (System.Math.Sin(L2 * Pi / 180) - (System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(Distance))) / (System.Math.Cos(L1 * Pi / 180) * System.Math.Sin(Distance)) 'add SignL1?
			If DLo <> 0 And System.Math.Abs(DLo) <> 180 Then CourseAngle = System.Math.Atan(-CourseAngle / (System.Math.Sqrt(-CourseAngle * CourseAngle + 1) + 9.999999E-21)) + Pi / 2
			Distance = Distance * 180 / Pi * 60
			CourseAngleDeg = CourseAngle * 180 / Pi
			If SignL1 >= 0 And Direction = 1 Then Course = 360 - CourseAngleDeg
			If SignL1 >= 0 And Direction = -1 Then Course = CourseAngleDeg
			If SignL1 < 0 And Direction = 1 Then Course = 180 + CourseAngleDeg
			If SignL1 < 0 And Direction = -1 Then Course = 180 - CourseAngleDeg
			If Lo1 = Lo2 And L1 > L2 Then Course = 180
			If Lo1 = Lo2 And L1 < L2 Then Course = 0
			InitialQuadrant = Int(Course / 90) + 1
			FinalGCCourse()
			If chkComposite.CheckState = 1 And optMethod1.Checked = True Then GCCrossings()
			If chkComposite.CheckState = 1 And optMethod2.Checked = True Then GCVertices()
			If Flag2 = True Then
				'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls() : Exit Sub
			End If
		End If
		
		If optL2Lo2GC.Checked = True Then 'Mathematically radius of spherical Earth = (360 * 60)/(2 * Pi) = 3437.75
			L2 = System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(Val(txtDist.Text) / 3437.75) + System.Math.Cos(L1 * Pi / 180) * System.Math.Sin(Val(txtDist.Text) / 3437.75) * System.Math.Cos(Val(txtCourse.Text) * Pi / 180)
			L2 = System.Math.Atan(L2 / System.Math.Sqrt(-L2 * L2 + 1))
			
			'DLo = Atan2(Sin(Val(txtCourse.Text) * Pi / 180) * Sin(Val(txtDist.Text) * Pi / 180) * Cos(L1 * Pi / 180), Cos(Val(txtDist.Text) * Pi / 180) - Sin(L1 * Pi / 180) * Sin(L2))
			'Lo2 = (Lo1 * Pi / 180 - DLo + Pi) Mod (2 * Pi) - Pi
			
			Lo2 = Lo1 * Pi / 180 - Atan2(System.Math.Sin(Val(txtCourse.Text) * Pi / 180) * System.Math.Sin(Val(txtDist.Text) / 3437.75) * System.Math.Cos(L1 * Pi / 180), System.Math.Cos(Val(txtDist.Text) / 3437.75) - System.Math.Sin(L1 * Pi / 180) * System.Math.Sin(L2))
			L2 = L2 * 180 / Pi
			Lo2 = Lo2 * 180 / Pi
			If Val(txtCourse.Text) = 0 And Val(txtDist.Text) > (90 - L1) * 60 Then Lo2 = -(180 - Lo2)
			'If Val(txtCourse.Text) = 0 And L1 > 0 And Val(txtDist.Text) > (90 - L1) * 60 Then Lo2 = -(180 - Lo2)
			'If Val(txtCourse.Text) = 180 And L1 < 0 And Val(txtDist.Text) > (90 - Abs(L1)) * 60 Then Lo2 = -(180 - Lo2)
			If System.Math.Abs(Lo2) > 180 Then Lo2 = -System.Math.Sign(Lo2) * (360 - System.Math.Abs(Lo2))
			Direction = 1 'West
			DLo = Lo2 - Lo1 : If DLo < 0 Then Direction = -1
			If DLo > 180 Then DLo = 360 - DLo : Direction = -1
			If DLo < -180 Then DLo = 360 - System.Math.Abs(DLo) : Direction = 1
			InitialQuadrant = Int(Val(txtCourse.Text) / 90) + 1
		End If
		'Formula for maximum latitude (vertex) of entire great circle, not necessarily on route
		If optICD.Checked = True Then MaxLat = System.Math.Abs(System.Math.Sin(Course * Pi / 180) * System.Math.Cos(L1 * Pi / 180))
		If optL2Lo2GC.Checked = True Then MaxLat = System.Math.Abs(System.Math.Sin(Val(txtCourse.Text) * Pi / 180) * System.Math.Cos(L1 * Pi / 180))
		If MaxLat = 1 Then MaxLat = L2 : GoTo Degrees 'ACos(1)=0     what is this line for??????????
		MaxLat = System.Math.Atan(-MaxLat / System.Math.Sqrt(-MaxLat * MaxLat + 1)) + Pi / 2 'this is ACos(MaxLat)
		FinalGCCourse()
		'This makes it maximum latitude on route        DOESN'T SEEM TO WORK IF MAX LAT IS AT BEGINNING OR END OF ROUTE
		If InitialQuadrant = FinalQuadrant Then
			MaxLat = L2 * Pi / 180 : LoVertex = Lo2
			If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = L1 : LoVertex = Lo1
			GoTo Degrees
		End If
		MaxLat = System.Math.Abs(MaxLat)
		If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = System.Math.Sign(L1) * MaxLat
		If System.Math.Abs(L1) < System.Math.Abs(L2) Then MaxLat = System.Math.Sign(L2) * MaxLat
		If optICD.Checked = True Then DLoVertex = System.Math.Cos(Course * Pi / 180) / System.Math.Sin(MaxLat)
		If optL2Lo2GC.Checked = True Then DLoVertex = System.Math.Cos(Val(txtCourse.Text) * Pi / 180) / System.Math.Sin(MaxLat)
		DLoVertex = System.Math.Atan(DLoVertex / (System.Math.Sqrt(-DLoVertex * DLoVertex + 1) + 9.999999E-21)) 'arcsin
		If Direction = -1 Then DLoVertex = -DLoVertex
		LoVertex = Lo1 + (DLoVertex * 180 / Pi)
		If System.Math.Abs(LoVertex) > 180 Then LoVertex = -System.Math.Sign(LoVertex) * (360 - System.Math.Abs(LoVertex))
		'       LoVertexDeg = Int(Abs(LoVertex))
		'       LoVertexMin = (Abs(LoVertex) - LoVertexDeg) * 60
		'       LoVertexMin = Int(LoVertexMin * 10 + 0.5) / 10
		'       If LoVertexMin = 60 Then LoVertexMin = 0: LoVertexDeg = LoVertexDeg + 1
		
		
Degrees: 
		MaxLat = MaxLat * 180 / Pi 'this is maximum latitude of entire great circle, not just of route
		LoVertexDeg = Int(System.Math.Abs(LoVertex))
		LoVertexMin = (System.Math.Abs(LoVertex) - LoVertexDeg) * 60
		LoVertexMin = Int(LoVertexMin * 10 + 0.5) / 10
		If LoVertexMin = 60 Then LoVertexMin = 0 : LoVertexDeg = LoVertexDeg + 1
		
		'        If SignL1 = 1 And Course > 90 And Course < 270 Then    'maybe SignL1>=0
		'            If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
		'            If Abs(SignL1 * Abs(L1)) <= Abs(SignL2 * Abs(L2)) Then MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
		'        End If
		'        If SignL1 = -1 And (Course > 270 Or Course < 90) Then
		'            If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
		'            If Abs(SignL1 * Abs(L1)) <= Abs(SignL2 * Abs(L2)) Then MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
		'        End If
		'If DLo = 0 Then
		'If DLo < 0.0000001 Then
		'    Course = 0: MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
		'    If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
		'    If SignL1 * Abs(L1) > SignL2 * Abs(L2) Then Course = 180
		'    'If L1 > L2 Then Course = 180
		'    'If L1 < L2 Then Course = 0
		'End If
		''If InitialQuadrant = FinalQuadrant Then MaxLat = L2: If Abs(L1) > Abs(L2) Then MaxLat = L1
		'If Abs(DLo) = 180 Then
		'    Course = 0: MaxLat = 90: CourseAngleDeg = 0
		'    If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = -90: CourseAngleDeg = 180
		'    If SignL1 * Abs(L1) > SignL2 * Abs(L2) Then Course = 180
		'End If
		If optL2Lo2GC.Checked = True Then
			If (Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180) And (System.Math.Sign(Lo1) = System.Math.Sign(Lo2) Or System.Math.Sign(Lo1) = 0) Then
				If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = L1
				If System.Math.Abs(L1) < System.Math.Abs(L2) Then MaxLat = L2
			End If
			If Val(txtCourse.Text) = 0 And (System.Math.Sign(Lo1) <> System.Math.Sign(Lo2) Or System.Math.Sign(Lo1) = 0) Then MaxLat = 90
			If Val(txtCourse.Text) = 180 And System.Math.Sign(Lo1) <> System.Math.Sign(Lo2) Then MaxLat = -90
		End If
		'MaxLatDeg = Int(Abs(MaxLat))
		'MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60: MaxLatMin = Int(MaxLatMin * 10 + 0.5) / 10
		'If MaxLatMin = 60 Then MaxLatMin = 0: MaxLatDeg = MaxLatDeg + 1
		'InitialQuadrant = Int(Course / 90) + 1
		FinalGCCourse()
		If InitialQuadrant = FinalQuadrant Then MaxLat = L2 : If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = L1
		'    If Lo1 > 180 Then Lo1 = 360 - Lo1
		'    If Lo2 > 180 Then Lo2 = 360 - Lo1
		If optICD.Checked = True Then DisplayCD()
		If optL2Lo2GC.Checked = True Then DisplayDestination()
	End Sub
	
	Public Sub TestML()
		''If ((Abs(L1) >= Abs(L2) And Abs(Abs(L1) - Abs(LmML)) > 0.5)) Or ((Abs(L2) >= Abs(L1) And Abs(Abs(L2) - Abs(LmML)) > 0.5)) Then
		'If Sgn(L1) = Sgn(L2) And _
		''    (Abs(L1) >= Abs(L2) And Abs(L2) >= Abs(LmML) And Abs(L1 - LmML) > 0.5) Or _
		''    (Abs(L2) >= Abs(L1) And Abs(L1) >= Abs(LmML) And Abs(L2 - LmML) > 0.5) Or _
		''    (Abs(L1) >= Abs(L2) And Abs(LmML) >= Abs(L1) And Abs(L2 - LmML) > 0.5) Or _
		''    (Abs(L2) >= Abs(L1) And Abs(LmML) >= Abs(L2) And Abs(L1 - LmML) > 0.5) Then
		'    'txtMLDeg.BackColor = &HFF&
		'    'cboMLmin.BackColor = &HFF&
		'    'cboML.BackColor = &HFF&
		'    MsgBox "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
		''Else
		'    'txtMLDeg.BackColor = &H80000005
		'    'cboMLmin.BackColor = &H80000005
		'    'cboML.BackColor = &H80000005
		'End If
		'If Sgn(L1) <> Sgn(L2) And (Abs(L2 - LmML) > 0.5 Or Abs(L1 - LmML) > 0.5) Then _
		''    MsgBox "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
		'If Abs(L2 - LmML) > 0.5 Or Abs(L1 - LmML) > 0.5 Then _
		'MsgBox "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
		If (optL2Lo2.Checked = False And System.Math.Abs(L2 - LmML) > 0.5) Or System.Math.Abs(L1 - LmML) > 0.5 Then
			MsgBox("Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.")
			'UPGRADE_ISSUE: Form method Form12.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls() : BadCLS = True
		End If
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
	
	Public Sub FinalGCCourse()
		'Final course is initial course going the other way +180
		If optICD.Checked = True Then LatLong()
		L3 = (Val(txtL3Deg.Text) + Val(txtL3Min.Text) / 60) : If cboL3.Text = "S " Then L3 = -L3
		'If chkComposite = 1 Then
		'    If Abs(L1) = Abs(L3) Then If Course >= 0 And Course < 180 Then Course1 = 90 Else Course1 = 270: Exit Sub
		'    If Abs(L2) = Abs(L3) Then If Course >= 0 And Course < 180 Then Course3 = 90 Else Course3 = 270: Exit Sub
		'    'Exit Sub
		'End If
		If chkComposite.CheckState = 1 And L2 = L3 Then Exit Sub '(L1 = L3 Or L2 = L3)
		
		L1Final = L2 : L2Final = L1 : Lo1Final = Lo2 : Lo2Final = Lo1
		'    If optICD.Value = True Then
		DirectionFinal = 1 'West
		DLoFinal = Lo2Final - Lo1Final : If DLoFinal < 0 Then DirectionFinal = -1
		If DLoFinal > 180 Then DLoFinal = 360 - DLoFinal : DirectionFinal = -1
		If DLoFinal < -180 Then DLoFinal = 360 - System.Math.Abs(DLoFinal) : DirectionFinal = 1
		If System.Math.Abs(DLoFinal) < 0.000001 Then DLoFinal = 0 : DirectionFinal = 0
		SignL1Final = System.Math.Sign(L1Final)
		SignL2Final = System.Math.Sign(L2Final)
		If System.Math.Sign(L1Final) <> System.Math.Sign(L2Final) And System.Math.Sign(L1Final) <> 0 And System.Math.Sign(L2Final) <> 0 Then L2Final = -System.Math.Abs(L2Final) Else L2Final = System.Math.Abs(L2Final)
		L1Final = System.Math.Abs(L1Final)
		DistanceFinal = System.Math.Sin(L1Final * Pi / 180) * System.Math.Sin(L2Final * Pi / 180) + System.Math.Cos(L1Final * Pi / 180) * System.Math.Cos(L2Final * Pi / 180) * System.Math.Cos(DLoFinal * Pi / 180)
		DistanceFinal = System.Math.Atan(-DistanceFinal / (System.Math.Sqrt(-DistanceFinal * DistanceFinal + 1) + 9.999999E-21)) + Pi / 2
		CourseAngleFinal = (System.Math.Sin(L2Final * Pi / 180) - (System.Math.Sin(L1Final * Pi / 180) * System.Math.Cos(DistanceFinal))) / (System.Math.Cos(L1Final * Pi / 180) * System.Math.Sin(DistanceFinal)) 'add SignL1?
		If System.Math.Abs(DLoFinal) <> 0 And System.Math.Abs(DLoFinal) <> 180 Then CourseAngleFinal = System.Math.Atan(-CourseAngleFinal / (System.Math.Sqrt(-CourseAngleFinal * CourseAngleFinal + 1) + 9.999999E-21)) + Pi / 2
		DistanceFinal = DistanceFinal * 180 / Pi * 60
		CourseAngleDegFinal = CourseAngleFinal * 180 / Pi
		If SignL1Final >= 0 And DirectionFinal = 1 Then CourseFinal = 360 - CourseAngleDegFinal
		If SignL1Final >= 0 And DirectionFinal = -1 Then CourseFinal = CourseAngleDegFinal
		If SignL1Final < 0 And DirectionFinal = 1 Then CourseFinal = 180 + CourseAngleDegFinal
		If SignL1Final < 0 And DirectionFinal = -1 Then CourseFinal = 180 - CourseAngleDegFinal
		'If DirectionFinal = 0 And L1Final > L2Final Then CourseFinal = 0
		'If DirectionFinal = 0 And L1Final < L2Final Then CourseFinal = 180
		'    End If
		'    If optL2Lo2GC.Value = True Then
		'        L2Final = Sin(L1Final * Pi / 180) * Cos(Val(txtDist.Text) / 3440.07) + Cos(L1Final * Pi / 180) * Sin(Val(txtDist.Text) / 3440.07) * Cos((Val(txtCourse.Text) + 180) * Pi / 180)
		'        L2Final = Atn(L2Final / Sqr(-L2Final * L2Final + 1))
		
		'DLo = Atan2(Sin(Val(txtCourse.Text) * Pi / 180) * Sin(Val(txtDist.Text) * Pi / 180) * Cos(L1 * Pi / 180), Cos(Val(txtDist.Text) * Pi / 180) - Sin(L1 * Pi / 180) * Sin(L2))
		'Lo2 = (Lo1 * Pi / 180 - DLo + Pi) Mod (2 * Pi) - Pi
		
		'        Lo2Final = Lo1Final * Pi / 180 - Atan2(Sin((Val(txtCourse.Text) + 180) * Pi / 180) * Sin(Val(txtDist.Text) / 3440.07) * Cos(L1Final * Pi / 180), Cos(Val(txtDist.Text) / 3440.07) - Sin(L1 * Pi / 180) * Sin(L2Final))
		'        L2Final = L2Final * 180 / Pi
		'        Lo2Final = Lo2Final * 180 / Pi
		'        If Abs(Lo2Final) > 180 Then Lo2Final = -Sgn(Lo2Final) * (360 - Abs(Lo2Final))
		'        DirectionFinal = 1 'West
		'        DLoFinal = Lo2Final - Lo1Final: If DLoFinal < 0 Then DirectionFinal = -1
		'        If DLoFinal > 180 Then DLoFinal = 360 - DLoFinal: DirectionFinal = -1
		'        If DLoFinal < -180 Then DLoFinal = 360 - Abs(DLoFinal): DirectionFinal = 1
		'    End If
		If optL2Lo2GC.Checked = True Then
			If System.Math.Abs(Lo1Final) < 0.00001 Then Lo1Final = 0
			If (Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180) And System.Math.Sign(Lo1Final) = System.Math.Sign(Lo2Final) Then CourseFinal = Val(txtCourse.Text) + 180
			If (Val(txtCourse.Text) = 0 Or Val(txtCourse.Text) = 180) And System.Math.Sign(Lo1Final) <> System.Math.Sign(Lo2Final) Then CourseFinal = Val(txtCourse.Text)
		End If
		'If L2 = 90 Or L2 = -90 Then CourseFinal = CourseFinal + 180
		CourseFinal = (CourseFinal + 180) : If CourseFinal >= 360 Then CourseFinal = CourseFinal - 360
		If chkComposite.CheckState = 1 And optMethod1.Checked = True Then Course3 = CourseFinal 'for composite sailing Method 1
		
		'If Lo1Final = Lo2Final Then CourseFinal = Course
		FinalQuadrant = Int(CourseFinal / 90) + 1
		
		
	End Sub
	
	Public Function ModFP(ByVal y As Double, ByVal x As Double) As Double
		'Modulus function that works with floating point numbers
		ModFP = y - (x * Fix(y / x))
	End Function
	
	Private Sub DriftAngle()
		LatDiff = L2 - Fix1L
		DLo = Lo2 - Fix1Lo
		'Crossing IDL
		If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
		
		dphi = System.Math.Log(System.Math.Tan((L2 * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((Fix1L * Pi / 180) / 2 + Pi / 4))
		If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(Fix1L * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
		CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
		CourseAngleDeg = CourseAngle * 180 / Pi
		If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
		If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
		If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
		If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
		CourseToFix = Course 'course to fix
		
		LatDiff = L1 - Fix1L
		DLo = Lo1 - Fix1Lo
		'Crossing IDL
		If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
		
		dphi = System.Math.Log(System.Math.Tan((L1 * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((Fix1L * Pi / 180) / 2 + Pi / 4))
		If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(Fix1L * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
		CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
		CourseAngleDeg = CourseAngle * 180 / Pi
		If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
		If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
		If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
		If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
		CourseToDR = Course 'course to DR
		
		DriftAng = System.Math.Abs(CourseToFix - CourseToDR)
		'DriftAng = CourseToFix - CourseToDR
		Flag4 = False
		If DriftAng > 180 Then DriftAng = 360 - DriftAng : Flag4 = True
		DriftAng = Int(DriftAng + 0.5)
		
	End Sub
	'UPGRADE_WARNING: Event txtFix1LD.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFix1LD_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LD.TextChanged
		txtFix1LD.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtFix1LD.Text) > 89 Then
			txtFix1LD.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtFix1LD.Text) <= 89 Then
			'txtFix1LM.ForeColor = &H80000008
			txtFix1LM.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtFix1LM.Text = "  "
		End If
	End Sub
	
	Private Sub txtFix1LD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFix1LD.KeyPress
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
	
	Private Sub txtFix1LD_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtFix1LD.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtFix1LD.Text) > 89 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtFix1LD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LD.Enter
		SelectAllText(txtFix1LD)
	End Sub
	
	'UPGRADE_WARNING: Event txtFix1LM.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFix1LM_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LM.TextChanged
		'txtFix1LM.ForeColor = &H80000008
		txtFix1LM.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtFix1LM.Text) > 59.9 Then
			txtFix1LM.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtFix1LM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFix1LM.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtFix1LM.Text, ".") Then
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
	
	Private Sub txtFix1LM_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtFix1LM.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtFix1LM.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtFix1LM_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LM.Enter
		SelectAllText(txtFix1LM)
	End Sub
	
	'UPGRADE_WARNING: Event txtFix1LoD.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFix1LoD_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LoD.TextChanged
		If Val(txtFix1LoD.Text) <> 180 Then txtFix1LoM.Enabled = True
		If Val(txtFix1LoD.Text) = 180 Then txtFix1LoM.Enabled = False : txtFix1LoM.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtFix1LoD.ForeColor = &H80000008
		txtFix1LoD.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtFix1LoD.Text) > 180 Or (Val(txtFix1LoD.Text) = 180 And Val(txtFix1LoM.Text) <> 0) Then
			txtFix1LoD.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtFix1LoD.Text) < 180 Then
			'txtFix1LoM.ForeColor = &H80000008
			txtFix1LoM.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtFix1LoM.Text = "    "
		End If
	End Sub
	
	Private Sub txtFix1LoD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFix1LoD.KeyPress
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
	
	Private Sub txtFix1LoD_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtFix1LoD.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtFix1LoD.Text) > 180 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtFix1LoD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LoD.Enter
		SelectAllText(txtFix1LoD)
	End Sub
	
	'UPGRADE_WARNING: Event txtFix1LoM.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFix1LoM_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LoM.TextChanged
		'txtFix1LoM.ForeColor = &H80000008
		txtFix1LoM.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtFix1LoM.Text) > 59.9 Then
			txtFix1LoM.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtFix1LoM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFix1LoM.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtFix1LoM.Text, ".") Then
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
	
	Private Sub txtFix1LoM_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtFix1LoM.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtFix1LoM.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtFix1LoM_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFix1LoM.Enter
		SelectAllText(txtFix1LoM)
	End Sub
	
	Public Sub GCCrossings() 'for use with Composite Method 1
		'Suppose a great circle passes through (L1,Lo1) and (L2,Lo2). It crosses the parallel L3 at longitudes Lon31 and Lon32 given by:
		L3 = (Val(txtL3Deg.Text) + Val(txtL3Min.Text) / 60) * Pi / 180 : If cboL3.Text = "S " Then L3 = -L3
		'If vertex (maximum latitude) is not between the ends of the great circle route, message and exit sub
		'If (Abs(MaxLat) = Abs(L1) Or Abs(MaxLat) = Abs(L2)) And Abs(L3) < Abs(L2 * Pi / 180) And Abs(L3) > Abs(L1 * Pi / 180) Then MsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
		'If Abs(L3 * 180 / Pi) < Abs(L2) Or Abs(L3 * 180 / Pi) < Abs(L1) Then MsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
		Flag2 = False
		If System.Math.Abs(L2) - System.Math.Abs(L3 * 180 / Pi) > 0.001 Or System.Math.Abs(L1) - System.Math.Abs(L3 * 180 / Pi) > 0.001 Then MsgBox("Destination cannot be reached without exceeding latitude limit.") : Flag2 = True : Exit Sub
		DLo = Lo1 - Lo2 'east is + for DLo<=180,
		'If DLo > 180 Then DLo = -(360 - DLo)
		'If Course > 180 And Course < 360 Then x = Lo1: Lo1 = Lo2: Lo2 = x
		'If DLo > 0 Then x = Lo1: Lo1 = Lo2: Lo2 = x
		'If DLo > 0 Then Lo1 = Lo2
		'    DLo = Lo2 - Lo1
		'If Abs(DLo) > 180 Then DLo = -Sgn(DLo) * (360 - Abs(DLo))
		
		A = System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Cos(L3) * System.Math.Sin(DLo * Pi / 180)
		
		B = System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Cos(L3) * System.Math.Cos(DLo * Pi / 180) - System.Math.Cos(L1 * Pi / 180) * System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(L3)
		
		C = System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin(L3) * System.Math.Sin(DLo * Pi / 180)
		
		Lon = Atan2(B, A) 'atan2(y,x) convention
		x = C / System.Math.Sqrt(A ^ 2 + B ^ 2)
		If (System.Math.Abs(C) > System.Math.Sqrt(A ^ 2 + B ^ 2)) Then
			MsgBox("Great Circle does not cross latitude limit.  Composite Sailing will not be used.") : chkComposite.CheckState = System.Windows.Forms.CheckState.Unchecked : GreatCircle() : Exit Sub
		Else : DLon = System.Math.Atan(-x / System.Math.Sqrt(-x * x + 1)) + Pi / 2 'arc cosine
			'If Course > 180 And Course < 360 Then DLon = -DLon
			'DLon = -DLon
			Lon31 = Lo1 * Pi / 180 - DLon + Lon + Pi
			'Lon31 = Lon31 - 2 * Pi * Int(Lon31 / (2 * Pi))     'equiv. of next three lines
			While Lon31 >= 2 * Pi
				Lon31 = Lon31 - 2 * Pi
			End While
			Lon31 = Lon31 - Pi
			Lon31 = Lon31 * 180 / Pi
			'       If Lon31 < 0 Then Lon31 = Lon31 + 180
			If System.Math.Abs(Lon31) > 180 Then Lon31 = -System.Math.Sign(Lon31) * (360 - System.Math.Abs(Lon31))
			
			Lon32 = Lo1 * Pi / 180 + DLon + Lon + Pi
			'Lon32 = Lon32 - 2 * Pi * Int(Lon32 / (2 * Pi))     'equiv. of next three lines
			While Lon32 >= 2 * Pi
				Lon32 = Lon32 - 2 * Pi
			End While
			Lon32 = Lon32 - Pi
			Lon32 = Lon32 * 180 / Pi
			'       If Lon32 < 0 Then Lon32 = Lon32 + 180
			If System.Math.Abs(Lon32) > 180 Then Lon32 = -System.Math.Sign(Lon32) * (360 - System.Math.Abs(Lon32))
		End If
		'Interchange Lon31 and Lon32 if course is westward
		'If DLo < 0 Or DLo > 180 Then x = Lon32: Lon32 = Lon31: Lon31 = x
		If Lon < 0 Then x = Lon32 : Lon32 = Lon31 : Lon31 = x
		Lon31Deg = Int(System.Math.Abs(Lon31))
		Lon31Min = (System.Math.Abs(Lon31) - Lon31Deg) * 60
		If Int(Lon31Min * 10 + 0.5) / 10 = 60 Then Lon31Min = 0 : Lon31Deg = Lon31Deg + 1
		Lon32Deg = Int(System.Math.Abs(Lon32))
		Lon32Min = (System.Math.Abs(Lon32) - Lon32Deg) * 60
		If Int(Lon32Min * 10 + 0.5) / 10 = 60 Then Lon32Min = 0 : Lon32Deg = Lon32Deg + 1
		
		'Calculate initial course and distance of first segment
		L1CD = L1
		Lo1CD = Lo1
		L2CD = L3 * 180 / Pi
		Lo2CD = Lon31
		CD()
		Course1 = CourseCD
		If chkComposite.CheckState = 1 And L1 = L3 * 180 / Pi Then If Course >= 0 And Course < 180 Then Course1 = 90 Else Course1 = 270
		Distance1 = DistanceCD
		'Calculate (course and) distance of second segment
		DLoCD = Lon32 - Lon31
		If System.Math.Abs(DLoCD) > 180 Then DLoCD = -System.Math.Sign(DLoCD) * (360 - System.Math.Abs(DLoCD))
		Distance2 = System.Math.Cos(L3) * System.Math.Abs(DLoCD) * 60
		'Calculate distance of second segment and final course          1s and 2s swapped in this segment    Was this necessary, since FinalGCCourse is used anyway?
		L2CD = L2
		L1CD = L3 * 180 / Pi
		Lo2CD = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60
		If cboLo2.Text = "E " Then Lo2CD = -Lo2CD
		Lo1CD = Lon32
		
		CD()
		Distance3 = DistanceCD
		
		FinalGCCourse()
		Course3 = CourseFinal 'CourseCD
		If chkComposite.CheckState = 1 And L2 = L3 Then If Course >= 0 And Course < 180 Then Course3 = 90 Else Course3 = 270
		'Course3 = CourseCD + 180: If Course3 >= 360 Then Course3 = Course3 - 360
		
		'If L2 = L3 * 180 / Pi Then FinalGCCourse
		'Course3 = CourseCD
		
		
		Distance1 = Int(Distance1 * 10 + 0.5) / 10
		Distance2 = Int(Distance2 * 10 + 0.5) / 10
		Distance3 = Int(Distance3 * 10 + 0.5) / 10
		DistanceComposite = Distance1 + Distance2 + Distance3
	End Sub
	
	Public Sub GCVertices() 'for use with Composite Method 2
		'L3 = (Val(txtL3Deg.text) + Val(txtL3Min.text) / 60) * Pi / 180: If cboL3 = "S " Then L3 = -L3
		
		MaxLat = System.Math.Abs(System.Math.Sin(Course * Pi / 180) * System.Math.Cos(L1 * Pi / 180))
		If MaxLat = 1 Then MaxLat = L2 ': GoTo Degrees        'ACos(1)=0     what is this line for??????????
		MaxLat = System.Math.Atan(-MaxLat / System.Math.Sqrt(-MaxLat * MaxLat + 1)) + Pi / 2 'this is ACos(MaxLat)
		MaxLat = MaxLat * 180 / Pi
		FinalGCCourse()
		'This makes it maximum latitude on route
		If InitialQuadrant = FinalQuadrant Then
			MaxLat = L2 * Pi / 180 : LoVertex = Lo2
			If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = L1 : LoVertex = Lo1
			'GoTo Degrees
		End If
		MaxLat = System.Math.Abs(MaxLat)
		If System.Math.Abs(L1) > System.Math.Abs(L2) Then MaxLat = System.Math.Sign(L1) * MaxLat
		If System.Math.Abs(L1) < System.Math.Abs(L2) Then MaxLat = System.Math.Sign(L2) * MaxLat
		
		L3 = (Val(txtL3Deg.Text) + Val(txtL3Min.Text) / 60) * Pi / 180 : If cboL3.Text = "S " Then L3 = -L3
		
		'If vertex (maximum latitude) is not between the ends of the great circle route, message and exit sub
		'If (Abs(MaxLat) = Abs(L1) Or Abs(MaxLat) = Abs(L2)) And Abs(L3 * 180 / Pi) < Abs(L2) And Abs(L3 * 180 / Pi) > Abs(L1) Then MsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
		'If Abs(L3 * 180 / Pi) < Abs(L2) Or Abs(L3 * 180 / Pi) < Abs(L1) Then MsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
		Flag2 = False
		If System.Math.Abs(L2) - System.Math.Abs(L3 * 180 / Pi) > 0.001 Or System.Math.Abs(L1) - System.Math.Abs(L3 * 180 / Pi) > 0.001 Then MsgBox("Destination cannot be reached without exceeding latitude limit.") : Flag2 = True : Exit Sub
		If System.Math.Abs(MaxLat) < System.Math.Abs(L3 * 180 / Pi) Then MsgBox("Great Circle does not cross latitude limit.  Composite Sailing will not be used.") : chkComposite.CheckState = System.Windows.Forms.CheckState.Unchecked : GreatCircle() : Exit Sub
		DLo = Lo2 - Lo1
		If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
		DLo1 = System.Math.Tan(L1 * Pi / 180) / System.Math.Tan(L3)
		If DLo1 = 1 Then DLo1 = -0.99999999999999
		DLo1 = System.Math.Atan(-DLo1 / System.Math.Sqrt(-DLo1 * DLo1 + 1)) + Pi / 2 'arc cosine
		If DLo < 0 Then DLo1 = -DLo1 'should this be If DLo1 < 0?
		Lon31 = Lo1 * Pi / 180 + DLo1
		While Lon31 >= 2 * Pi
			Lon31 = Lon31 - 2 * Pi
		End While
		If Lon31 < 0 Then Lon31 = Lon31 + 2 * Pi
		Lon31 = Lon31 * 180 / Pi
		If System.Math.Abs(Lon31) > 180 Then Lon31 = -System.Math.Sign(Lon31) * (360 - System.Math.Abs(Lon31))
		'If Abs(L1 - L3 * 180 / Pi) < 0.001 Then Lon31 = Lo1     'less that 0.1' (0.06')
		If L1 * Pi / 180 = L3 Then Lon31 = Lo1
		
		DLo2 = System.Math.Tan(L2 * Pi / 180) / System.Math.Tan(L3)
		If System.Math.Abs(DLo2) = 1 Then DLo2 = -0.99999999999999
		DLo2 = System.Math.Atan(-DLo2 / System.Math.Sqrt(-DLo2 * DLo2 + 1)) + Pi / 2 'arc cosine
		If DLo < 0 Then DLo2 = -DLo2 'should this be If DLo2 < 0?
		Lon32 = Lo2 * Pi / 180 - DLo2
		While Lon32 >= 2 * Pi
			Lon32 = Lon32 - 2 * Pi
		End While
		If Lon32 < 0 Then Lon32 = Lon32 + 2 * Pi
		Lon32 = Lon32 * 180 / Pi
		If System.Math.Abs(Lon32) > 180 Then Lon32 = -System.Math.Sign(Lon32) * (360 - System.Math.Abs(Lon32))
		'If Abs(L2 - L3 * 180 / Pi) < 0.001 Then Lon32 = Lo2     'less that 0.1' (0.06')
		If L2 * Pi / 180 = L3 Then Lon32 = Lo2
		
		Lon31Deg = Int(System.Math.Abs(Lon31))
		Lon31Min = (System.Math.Abs(Lon31) - Lon31Deg) * 60
		If Int(Lon31Min * 10 + 0.5) / 10 = 60 Then Lon31Min = 0 : Lon31Deg = Lon31Deg + 1
		Lon32Deg = Int(System.Math.Abs(Lon32))
		Lon32Min = (System.Math.Abs(Lon32) - Lon32Deg) * 60
		If Int(Lon32Min * 10 + 0.5) / 10 = 60 Then Lon32Min = 0 : Lon32Deg = Lon32Deg + 1
		
		'L3 = Val(txtL3Deg.text) + Val(txtL3Min.text) / 60: If cboL3 = "S " Then L3 = -L3
		'Calculate initial course and distance of first segment
		Segment = 1
		L1CD = L1
		Lo1CD = Lo1
		L2CD = L3 * 180 / Pi
		Lo2CD = Lon31
		CD()
		Course1 = CourseCD
		Distance1 = DistanceCD
		If L1 * Pi / 180 = L3 Then Distance1 = 0
		
		
		'Calculate (course and) distance of second segment
		Segment = 2
		DLoCD = Lon32 - Lon31
		'If L1 = L3 Then DLoCD = Lon31 - Lo1
		'If L2 = L3 Then DLoCD = Lo2 - Lon31
		If System.Math.Abs(DLoCD) > 180 Then DLoCD = -System.Math.Sign(DLoCD) * (360 - System.Math.Abs(DLoCD))
		Distance2 = System.Math.Cos(L3) * System.Math.Abs(DLoCD) * 60
		'Calculate distance of third segment and final course
		Segment = 3
		L1CD = L2
		L2CD = L3 * 180 / Pi
		Lo1CD = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60
		If cboLo2.Text = "E " Then Lo1CD = -Lo1CD
		Lo2CD = Lon32
		CD()
		Course3 = CourseCD + 180 : If Course3 >= 360 Then Course3 = Course3 - 360
		Distance3 = DistanceCD
		If L2 * Pi / 180 = L3 Then Distance3 = 0
		
		FinalGCCourse()
		
		If L2 = L3 Then
			'If Course1 > 0 And Course1 < 180 Then CourseFinal = 90 Else CourseFinal = 270
			If Course1 > 0 And Course1 < 180 Then Course3 = 90 Else Course3 = 270
		End If
		
		Distance1 = Int(Distance1 * 10 + 0.5) / 10
		Distance2 = Int(Distance2 * 10 + 0.5) / 10
		Distance3 = Int(Distance3 * 10 + 0.5) / 10
		DistanceComposite = Distance1 + Distance2 + Distance3
		
		
	End Sub
	'UPGRADE_WARNING: Event txtL3Deg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL3Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL3Deg.TextChanged
		txtL3Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtL3Deg.Text) > 89 Or Val(txtL3Deg.Text) < 1 And txtL3Deg.Text <> "" Then
			txtL3Deg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtL3Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL3Deg.KeyPress
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
	
	Private Sub txtL3Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL3Deg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL3Deg.Text) > 89 Or Val(txtL3Deg.Text) < 1 And txtL3Deg.Text <> "" Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL3Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL3Deg.Enter
		SelectAllText(txtL3Deg)
	End Sub
	
	'UPGRADE_WARNING: Event txtL3Min.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtL3Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL3Min.TextChanged
		'txtL1Min.ForeColor = &H80000008
		txtL3Min.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtL3Min.Text) > 59.9 Then
			txtL3Min.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtL3Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL3Min.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtL3Min.Text, ".") Then
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
	
	Private Sub txtL3Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL3Min.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtL3Min.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtL3Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL3Min.Enter
		SelectAllText(txtL3Min)
	End Sub
	
	Public Sub CD()
		DirectionCD = 1 'West
		DLoCD = Lo2CD - Lo1CD : If DLoCD < 0 Then DirectionCD = -1
		If DLoCD > 180 Then DLoCD = 360 - DLoCD : DirectionCD = -1
		If DLoCD < -180 Then DLoCD = 360 - System.Math.Abs(DLoCD) : DirectionCD = 1
		SignL1CD = System.Math.Sign(L1CD)
		SignL2CD = System.Math.Sign(L2CD)
		If System.Math.Sign(L1CD) <> System.Math.Sign(L2CD) And System.Math.Sign(L1CD) <> 0 And System.Math.Sign(L2CD) <> 0 Then L2CD = -System.Math.Abs(L2CD) Else L2CD = System.Math.Abs(L2CD)
		L1CD = System.Math.Abs(L1CD)
		DistanceCD = System.Math.Sin(L1CD * Pi / 180) * System.Math.Sin(L2CD * Pi / 180) + System.Math.Cos(L1CD * Pi / 180) * System.Math.Cos(L2CD * Pi / 180) * System.Math.Cos(DLoCD * Pi / 180)
		DistanceCD = System.Math.Atan(-DistanceCD / (System.Math.Sqrt(-DistanceCD * DistanceCD + 1) + 9.999999E-21)) + Pi / 2
		CourseAngleCD = (System.Math.Sin(L2CD * Pi / 180) - (System.Math.Sin(L1CD * Pi / 180) * System.Math.Cos(DistanceCD))) / (System.Math.Cos(L1 * Pi / 180) * System.Math.Sin(DistanceCD)) 'add SignL1?
		'       If CourseAngleCD > 1 Then CourseAngleCD = CourseAngleCD - 1
		If DLoCD <> 0 And System.Math.Abs(DLoCD) <> 180 Then CourseAngleCD = System.Math.Atan(-CourseAngleCD / (System.Math.Sqrt(-CourseAngleCD * CourseAngleCD + 1) + 9.999999E-21)) + Pi / 2
		DistanceCD = DistanceCD * 180 / Pi * 60
		DistanceCD = Int(DistanceCD * 10 + 0.5) / 10
		CourseAngleDegCD = CourseAngleCD * 180 / Pi 'course in quadrant
		If SignL1CD >= 0 And DirectionCD = 1 Then CourseCD = 360 - CourseAngleDegCD
		If SignL1CD >= 0 And DirectionCD = -1 Then CourseCD = CourseAngleDegCD
		If SignL1CD < 0 And DirectionCD = 1 Then CourseCD = 180 + CourseAngleDegCD
		If SignL1CD < 0 And DirectionCD = -1 Then CourseCD = 180 - CourseAngleDegCD
		'If L1CD >= L2CD And DirectionCD = 1 Then CourseCD = 180 + CourseAngleDegCD         'SW
		'If L1CD >= L2CD And DirectionCD = -1 Then CourseCD = 180 - CourseAngleDegCD             'SE
		'If L1CD < L2CD And DirectionCD = 1 Then CourseCD = 360 - CourseAngleDegCD          'NW
		'If L1CD < L2CD And DirectionCD = -1 Then CourseCD = CourseAngleDegCD          'NE
		
		If Lo1CD = Lo2CD And L1CD > L2CD Then CourseCD = 180
		If Lo1CD = Lo2CD And L1CD < L2CD Then CourseCD = 0
		'InitialQuadrantCD = Int(CourseCD / 90) + 1
		
		If Segment = 1 And L1 = L3 * 180 / Pi Then
			If DirectionCD = 1 Then CourseCD = 270 Else CourseCD = 90
		End If
		
	End Sub
	
	Public Sub PointsM2()
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Cls()
		'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.CurrentY = 490
		frmPointsOnGCR.Show()
		TotalDistance = 0
		Distance = 0
		Lo1Initial = Lo1
		Lo2Initial = Lo2
		ReachedMaxLatCount = 0 : LeftMaxLatCount = 0
		Flag3 = False
		'convert all east longitudes to west
		If Lo1 < 0 Then Lo1 = 360 - System.Math.Abs(Lo1)
		If Lo2 < 0 Then Lo2 = 360 - System.Math.Abs(Lo2)
		If Lon31 < 0 Then Lon31 = 360 - System.Math.Abs(Lon31)
		If Lon32 < 0 Then Lon32 = 360 - System.Math.Abs(Lon32)
		'determine whether traveling should be eastward or westward and increment
		DLo = Lo2 - Lo1
		Increment = 5 : If DLo < 0 Then Increment = -5
		'If Abs(DLo) > 180 Then DLo = 360 - DLo
		If Lo2 > Lo1 And System.Math.Abs(DLo) > 180 And Increment = 5 Then Lo1 = Lo1 + 360 : Increment = -5 : Flag3 = True 'skip next line if this line is used
		If Flag3 = False And Lo2 < Lo1 And System.Math.Abs(DLo) > 180 And Increment = -5 Then Lo2 = Lo2 + 360 : Increment = 5
		'make Lon31 and Lon32 fall between Lo1 and Lo2
		If Lo2 > Lo1 And (Lon31 > Lo2 Or Lon31 < Lo1) Then Lon31 = Lon31 + 360
		If Lo1 > Lo2 And (Lon31 > Lo1 Or Lon31 < Lo2) Then Lon31 = Lon31 + 360
		If Lo2 > Lo1 And (Lon32 > Lo2 Or Lon32 < Lo1) Then Lon32 = Lon32 + 360
		If Lo1 > Lo2 And (Lon32 > Lo1 Or Lon32 < Lo2) Then Lon32 = Lon32 + 360
		
		Segment = 1
		For Segment = 1 To 3 '1 is first great circle, 2 is parallel, 3 is second great circle
			If Segment = 1 Then
				L1 = System.Math.Abs(L1) : If cboL1.Text = "S " Then L1 = -L1
				L2 = System.Math.Abs(L3) : If cboL3.Text = "S " Then L2 = -L2
				'Lo1 is what it was
				Lo2 = Lon31
			End If
			If Segment = 2 Then 'IS ALL THIS NECESSARY????????????????????????????????????????????????????????
				L1 = L3 'LPoint
				L2 = L3 'LPoint
				Lo1 = Lon31 'LoPoint ': If LoPoint < 0 Then Lo1 = 360 - Abs(LoPoint)
				Lo2 = Lon32 'last Lo before leaving parallel, close to Lon32
			End If
			If Segment = 3 Then
				L1 = L3 'LPoint 'Print
				L2 = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60 'make this L2Initial!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
				If cboL2.Text = "S " Then L2 = -L2
				Lo1 = Lon32 'last Lo before leaving parallel, close to Lon32
				Lo2 = Lo2Initial
				If Lo2 < 0 Then Lo2 = 360 - System.Math.Abs(Lo2)
				If System.Math.Abs(Lo2 - Lo1) > 180 Then Lo1 = Lo1 - 360 ': Increment = -Increment
			End If
			
			If Segment = 1 Then 'And L1 <> L3 Then
				TabVal = 5 : If txtLo1Deg.Text = "" Then TabVal = 4
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If ModFP(Lo1, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtLo1Deg.Text)), VB6.Format(Val(txtLo1Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtLo1Min.Text), "00.0") & "'" & cboLo1.Text)
				'frmPointsOnGCR.Print Tab(18 - Len(txtLo1Deg.Text)); Format(Val(txtLo1Deg.Text), "0"); Chr$(176); Format(Val(txtLo1Min.Text), "00.0"); "'"; cboLo1.Text
				TabVal = 16 : If txtL1Deg.Text = "" Then TabVal = 15
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If ModFP(Lo1, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtL1Deg.Text)), VB6.Format(Val(txtL1Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtL1Min.Text), "00.0") & "'" & cboL1.Text)
				'frmPointsOnGCR.Print Tab(6 - Len(txtL1Deg.Text)); Format(Val(txtL1Deg.Text), "0"); Chr$(176); Format(Val(txtL1Min), "00.0"); "'";  '6 was TabVal
			End If
			
			If Increment = -5 Then
				FirstLo = Lo1 - ModFP(Lo1, 5)
				LastLo = Lo2 - ModFP(Lo2, 5)
				If ModFP(Lo2, 5) = 0 Then LastLo = Lo2
			End If
			If Increment = 5 Then
				FirstLo = Lo1 - ModFP(Lo1, 5)
				LastLo = Lo2 - ModFP(Lo2, 5)
				If ModFP(Lo1, 5) <> 0 Then FirstLo = FirstLo + 5 : If Segment = 1 Then LastLo = LastLo + 5
				If ModFP(Lo2, 5) = 0 Then LastLo = Lo2
			End If
			
			
			
			For LoPoint = FirstLo To LastLo Step Increment
				'If Segment = 1 Or Segment = 3 Then
				
				'If ReachedMaxLatCount < 2 Then  ' Or LeftMaxLatCount = 1 Then LoPoint = SavedLoPoint
				LPointPrior = LPoint
				If Lo1 <> Lo2 Then LPoint = System.Math.Atan((System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((LoPoint - Lo2) * Pi / 180) - System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(L1 * Pi / 180) * System.Math.Sin((LoPoint - Lo1) * Pi / 180)) / (System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((Lo1 - Lo2) * Pi / 180)))
				LPoint = LPoint * 180 / Pi
				LoPointPrint = LoPoint : LPointPrint = LPoint
				If LoPoint = FirstLo Then L1Rhumb = L1 : Lo1Rhumb = Lo1
				
				If (LoPoint > Lon31 And Increment = 5) Or (LoPoint < Lon31 And Increment = -5) Then ReachedMaxLatCount = ReachedMaxLatCount + 1
				If ReachedMaxLatCount = 1 Then LoPointPrint = Lon31 : LPointPrint = L3
				If Segment = 3 And ((LoPoint > Lo1 And Increment = 5) Or (LoPoint < Lo1 And Increment = -5)) Then LeftMaxLatCount = LeftMaxLatCount + 1
				If Segment = 3 And ((LoPoint > Lo2 And Increment = 5) Or (LoPoint < Lo2 And Increment = -5)) Then GoTo TheLastPoint
				
				'uses Accurate Rhumb Line for course and distance
				If (Segment = 1 And L1 <> L3) Or (Segment = 3 And L2 <> L3) Or (Segment = 2 And ReachedMaxLatCount = 1) Then
					L2Rhumb = LPointPrint : Lo2Rhumb = LoPointPrint
					'If Segment=3 and Lo1Rhumb = Lo1
					If Segment = 1 And LoPoint = FirstLo Then L1Rhumb = L1 : Lo1Rhumb = Lo1
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If Segment = 3 And LeftMaxLatCount = 1 Then frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
					'If Segment = 3 And Increment = -5 And LeftMaxLatCount = 2 Then Lo1Rhumb = Lo1            'WHY???????????????????????
					'Lo1Rhumb = Lo1Print          'added??????????????????
					'If Segment = 3 And Increment = 5 And Lo1Rhumb > Lo2Rhumb Then Lo1Rhumb = Lo1Rhumb - 360 'WHY?????????????????????????
					LatDiff = L2Rhumb - L1Rhumb
					DLo = Lo2Rhumb - Lo1Rhumb
					If Segment = 3 And LeftMaxLatCount = 1 Then
						'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210 : DLo = Lo2Rhumb - Lon32
					End If
					'Crossing IDL
					If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
					dphi = System.Math.Log(System.Math.Tan((L2Rhumb * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((L1Rhumb * Pi / 180) / 2 + Pi / 4))
					If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1Rhumb * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
					Distance = 60 * System.Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff)
					CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
					CourseAngleDeg = CourseAngle * 180 / Pi
					If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
					If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
					If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
					If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
					'If (Segment = 2 And ReachedMaxLatCount = 1) Then
					Course = Int(Course + 0.5)
					''                    If Segment = 3 And LeftMaxLatCount = 1 Then Distance = 0
					If Segment = 2 And ReachedMaxLatCount = 1 And L1Initial = L3 Then Distance = 0 'want this if L1=L3
					Distance = Int(Distance * 10 + 0.5) / 10
					TotalDistance = TotalDistance + Distance
					Dist = CStr(Str(Distance) Or "000.0")
					'End If
					LPointPrintDeg = Int(System.Math.Abs(LPointPrint))
					LPointPrintMin = (System.Math.Abs(LPointPrint) - LPointPrintDeg) * 60
					If Int(LPointPrintMin * 10 + 0.5) / 10 = 60 Then LPointPrintMin = 0 : LPointPrintDeg = LPointPrintDeg + 1
					If LoPointPrint > 180 Then LoPointPrint = -(360 - System.Math.Abs(LoPointPrint))
					LoPointPrintDeg = Int(System.Math.Abs(LoPointPrint))
					LoPointPrintMin = (System.Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60
					If Int(LoPointPrintMin * 10 + 0.5) / 10 = 60 Then LoPointPrintMin = 0 : LoPointPrintDeg = LoPointPrintDeg + 1
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(6 - Len(Str(System.Math.Abs(LoPointPrintDeg)))), VB6.Format(System.Math.Abs(LoPointPrintDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(LoPointPrintMin), "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint > 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("W")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint = 0 Or System.Math.Abs(LoPointPrint) = 180 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint < 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("E")
					'frmPointsOnGCR.Print Tab(17 - Len(Str$(LPointDeg))); Format(LPointDeg, "0"); Chr$(176); Format(LPointMin, "00.0"); "'";
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(17 - Len(Str(LPointPrintDeg))), VB6.Format(LPointPrintDeg, "0") & Chr(176) & VB6.Format(LPointPrintMin, "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint > 0 Then frmPointsOnGCR.Print("N")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint = 0 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint < 0 Then frmPointsOnGCR.Print("S")
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
					'If L1Initial <> L3 Then '(Segment = 2 And ReachedMaxLatCount <> 1) Then
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(30), VB6.Format(Course, "000"))
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If Segment = 3 And LeftMaxLatCount = 1 Then
						frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
					Else
						'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
					End If '''''''''''''''
					'        End If
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
					L1Rhumb = L2Rhumb : Lo1Rhumb = Lo2Rhumb
					'                    ReachedMaxLat = False                                                   'IS THIS LINE NEEDED?
				End If
				'End If
				
				'Segment=2
				If ReachedMaxLatCount = 1 Then 'Segment = 2 Then 'And
					LPointPrintDeg = Int(System.Math.Abs(LPointPrint))
					LPointPrintMin = (System.Math.Abs(LPointPrint) - LPointPrintDeg) * 60
					If Int(LPointPrintMin * 10 + 0.5) / 10 = 60 Then LPointPrintMin = 0 : LPointPrintDeg = LPointPrintDeg + 1
					LoPointPrint = Lon32
					If LoPointPrint > 180 Then LoPointPrint = -(360 - System.Math.Abs(LoPointPrint))
					LoPointPrintDeg = Int(System.Math.Abs(LoPointPrint))
					LoPointPrintMin = (System.Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60
					If Int(LoPointPrintMin * 10 + 0.5) / 10 = 60 Then LoPointPrintMin = 0 : LoPointPrintDeg = LoPointPrintDeg + 1
					
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(6 - Len(Str(System.Math.Abs(LoPointPrintDeg)))), VB6.Format(System.Math.Abs(LoPointPrintDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(LoPointPrintMin), "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint > 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("W")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint = 0 Or System.Math.Abs(LoPointPrint) = 180 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LoPointPrint < 0 And System.Math.Abs(LoPointPrint) <> 180 Then frmPointsOnGCR.Print("E")
					'frmPointsOnGCR.Print Tab(17 - Len(Str$(LPointDeg))); Format(LPointDeg, "0"); Chr$(176); Format(LPointMin, "00.0"); "'";
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(17 - Len(Str(LPointPrintDeg))), VB6.Format(LPointPrintDeg, "0") & Chr(176) & VB6.Format(LPointPrintMin, "00.0") & "'")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint > 0 Then frmPointsOnGCR.Print("N")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint = 0 Then frmPointsOnGCR.Print(" ")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If LPoint < 0 Then frmPointsOnGCR.Print("S")
					
					DLo = System.Math.Abs(Lon32 - Lon31) : If DLo > 180 Then DLo = 360 - System.Math.Abs(DLo)
					Distance = 60 * DLo * System.Math.Cos(L3 * Pi / 180)
					Distance = Int(Distance * 10 + 0.5) / 10
					TotalDistance = TotalDistance + Distance
					'If Segment = 1 And L1Initial <> L3 Then
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
					If L1Initial <> L3 Then
						If Course > 0 And Course < 180 Then Course = 90 Else Course = 270
					End If
					If L1Initial = L3 Then
						If Direction = 1 Then Course = 270 Else Course = 90
					End If
					
					Dist = CStr(Str(Distance) Or "000.0")
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(30), VB6.Format(Course, "000"))
					'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
					'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210 'THIS IS THE LINE THT CAUSES EXTRA SPACE
				End If
			Next LoPoint
		Next Segment
		
TheLastPoint: 
		'calculate rhumb line course and distance to last point if Lo is not divisible by 5 and destination is not at latitude limit
		If ModFP(Lo2, 5) <> 0 And L2 <> L3 Then
			If System.Math.Abs(Lo2 - Lon32) >= 5 Then
				If Increment = -5 Then L1Rhumb = LPointPrior
				If Increment = 5 Then L1Rhumb = LPointPrint
				Lo1Rhumb = LoPoint - Increment : If Lo1Rhumb > 180 Then Lo1Rhumb = -(360 - System.Math.Abs(Lo1Rhumb))
			End If
			L2Rhumb = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60 : If cboL2.Text = "S " Then L2Rhumb = -L2Rhumb
			Lo2Rhumb = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60 : If cboLo2.Text = "E " Then Lo2Rhumb = -Lo2Rhumb
			'       If Lo2Rhumb < 0 Then Lo2Rhumb = 360 - Abs(Lo2Rhumb)
			LatDiff = L2Rhumb - L1Rhumb
			DLo = Lo2Rhumb - Lo1Rhumb
			'Crossing IDL
			If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
			dphi = System.Math.Log(System.Math.Tan((L2Rhumb * Pi / 180) / 2 + Pi / 4) / System.Math.Tan((L1Rhumb * Pi / 180) / 2 + Pi / 4))
			If System.Math.Abs(LatDiff) < System.Math.Sqrt(0.000000000000001) Then q = System.Math.Cos(L1Rhumb * Pi / 180) Else q = (LatDiff * Pi / 180) / dphi
			Distance = 60 * System.Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff)
			CourseAngle = 2 * System.Math.Atan((System.Math.Sqrt(DLo * Pi / 180 * DLo * Pi / 180 + dphi * dphi) - dphi) / ((DLo + 9.999999E-21) * Pi / 180))
			CourseAngleDeg = CourseAngle * 180 / Pi
			If LatDiff >= 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff >= 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo < 0 Then Course = System.Math.Abs(CourseAngleDeg)
			If LatDiff < 0 And DLo >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg)
			Course = Int(Course + 0.5)
			Distance = Int(Distance * 10 + 0.5) / 10
			TotalDistance = TotalDistance + Distance
			TotalDistance = Int(TotalDistance * 10 + 0.5) / 10
			Dist = CStr(Str(Distance) Or "000.0")
			'UPGRADE_ISSUE: Form property frmPointsOnGCR.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(30), VB6.Format(Course, "000"))
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			frmPointsOnGCR.Print(TAB(46 - Len(Dist)), VB6.Format(Distance, "##0.0"))
			TabVal = 5 : If txtLo1Deg.Text = "" Then TabVal = 4
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtLo2Deg.Text)), VB6.Format(Val(txtLo2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtLo2Min.Text), "00.0") & "'") '6 was TabVal
			If Lo2 <> 0 And ModFP(Lo2, 5) <> 0 Then
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lo2 < 180 Then frmPointsOnGCR.Print("W")
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lo2 = 180 Then frmPointsOnGCR.Print("")
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If Lo2 > 180 Then frmPointsOnGCR.Print("E")
			End If
		End If
		
		If Lo1Rhumb <> Lo2 Then
			TabVal = 16 : If txtL2Deg.Text = "" Then TabVal = 15
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(TAB(TabVal - Len(txtL2Deg.Text)), VB6.Format(Val(txtL2Deg.Text), "0") & Chr(176) & VB6.Format(Val(txtL2Min.Text), "00.0") & "'")
			'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optL2Lo2GC.Checked = False And ModFP(Lo2, 5) <> 0 Then frmPointsOnGCR.Print(cboL2.Text)
			If optL2Lo2GC.Checked = True Then
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If System.Math.Sign(L2) = 1 Then frmPointsOnGCR.Print("N")
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If System.Math.Sign(L2) = 0 Then frmPointsOnGCR.Print("")
				'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If System.Math.Sign(L2) = -1 Then frmPointsOnGCR.Print("S")
			End If
		End If
		
		'UPGRADE_ISSUE: Form method frmPointsOnGCR.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		frmPointsOnGCR.Print(TAB(14), "Total rhumb line distance = " & VB6.Format(TotalDistance, "0.0") & " nm")
		cmdPoints.Enabled = False
		
		
		
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class