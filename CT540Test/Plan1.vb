Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form2
	Inherits System.Windows.Forms.Form
	
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	Private IsMouseDown As Boolean
	Dim PMRA, RAStars, DecStars, PMDec As Object
	Dim GYearJ As Short
	Dim JD As Double
	Dim SH(57) As Object
	Dim GA(57) As Object
	Dim RA(57) As Object
	Dim i As Short
	Dim k As Short
	Dim Body, Magnitude As Object
	Dim Mag(63) As Object
	Dim BN As Short
	Dim HD(57) As Object
	Dim DF(57) As Object
	Dim C3(10) As Object
	Dim D3(10) As Object
	Dim fnumeral As String
	Dim j As Short
	Dim H As Double
	Dim T0 As Double
	Dim C30 As String
	Dim ZN, PZ, ZN1 As Double
	Dim Body1(27) As Object
	Dim Mag1(27) As Object
	Dim Z1(27) As Object
	Dim TZ, TH As Double
	Dim TB, TM As String
	Dim Z2(34) As Object
	Dim Body2(34) As Object
	Dim Mag2(34) As Object
	Dim H2A(34) As Object
	Dim Z3(6) As Object
	Dim Body3(6) As Object
	Dim Mag3(6) As Object
	Dim H3A(6) As Object
	Dim TTip1() As ToolTip
	Dim TTip2() As ToolTip
	Dim TTip3() As ToolTip
	Dim bShowToolTips As Boolean
	Dim q, CP As Double
	Dim GRD(57) As Object
	Dim GRM(57) As Object 'Not sure about (57)
	Dim IC As Short
	Dim CT, Lat, Pi, DE, TA As Double
	Dim V, AR, Lo, ZD, GR, T1, N1 As Double
	Dim HG, C2, TP As Double
	Dim N2, NT, X3 As String
	Dim IB As Short
	Dim VM(57) As Object
	Dim VD(57) As Object
	Dim H1A(27) As Object
	Dim NO, NL, LR As Double
	Dim WD, QD As Short
	Dim MV As Single
	Dim WM, QM As Double
	Dim MonthatG, SignZD, MonthList, DateOfSight As String
	Dim DeltaT As Double
	Dim DecYr, Theta As Single 'Tdelta As Double, Theta As Double
	Dim MonthDays As String
	Dim MonthNumber, LocalYear, DayNumber As Short
	Dim ZDinSeconds As Integer
	Dim GMinute, ZTinSeconds, UTinSeconds, GSecond As Integer
	Dim GHour As Short
	Dim GMonth, GYear, GDayOfYear, GDay As Short
	Dim GLeapYear, LeapYear As Boolean
	Dim A, DecimalDate, T As Double
	Dim OE, C, OETrue As Double
	Dim I2, I3 As Short
	Dim B, MS As Double
	Dim RN, LN, NU As Double
	Dim x, y As Double
	Dim M, SQ As Double
	Dim P As Short
	Dim N, NY As Double
	Dim KK0, I1, KK, IJ As Short
	Dim KKFull, Ho As Double
	Dim D, L1, E As Double
	Dim L0, SM As Double
	Dim LowAz, HighAz As Short
	Dim Z1Temp(27) As Object
	Dim Z2Temp(34) As Object
	Dim Z3Temp(6) As Object
	Dim RotateX, ShiftX, AutoZD, ShiftAz, RotateY As Double
	Dim rad As Single
	Dim View As Boolean
	Dim DMHelper, RSHelper, RDHelper, RMHelper, DDHelper, DSHelper As Object
	Dim MagHelper As Object
	Dim DMHelper1, RSHelper1, RDHelper1, RMHelper1, DDHelper1, DSHelper1 As Object
	Dim MagH1(70) As Object
	Dim ZH1(70) As Object
	Dim MagH2(70) As Object
	Dim ZH2(70) As Object
	Dim MagH3(70) As Object
	Dim ZH3(70) As Object
	Dim MagH4(70) As Object
	Dim ZH4(70) As Object
	Dim HH1A(70) As Object
	Dim HH2A(70) As Object
	Dim HH3A(70) As Object
	Dim HH4A(70) As Object
	Dim NumberOfHelpers As Short
	Dim DateError, BlankTimeFlag As Boolean
	Dim ZH1Temp(70) As Object
	Dim ZH2Temp(70) As Object
	Dim ZH3Temp(70) As Object
	Dim ZH4Temp(70) As Object
	Dim TempThird, TempFirst, TempSecond, AzTest As Boolean
	Dim StartTime, EndTime As Integer
	Dim SunMoon As Boolean
	Dim HoSun, ZNSun, ZNMoon, HoMoon As Single
	Dim FirstTime, LastTime As Double
	Dim FT As Boolean
	Dim LastTimeHours, FirstTimeHours, FirstTimeMinutes, LastTimeMinutes As Short
	Dim LTHours, FTHours, FTMinutes, LTMinutes As String
	Dim MoonPhaseFirst, MoonPhaseLast As Single
	Dim ZNDiff As Short ', MoonPhase$
	'Dim ZNSR$, ZNSS$, WhichWay As Single, ZNAmpSR$, ZNAmpSS$, Amp As Double, ZNAmp As Double, ZNAmpString$
	Dim ZNAmpSR, ZNSS, ZNSR, WhichWay, ZNAmpSS As Single
	Dim Amp, ZNAmp As Double ', ZNAmpString$
	Dim r As Double
	Dim MMoon(3, 3) As Object
	Dim A0, Z1Moon, Z, D0 As Double
	Dim M8, W8 As Short ', HP As Double, DI As Double
	Dim PMoon, SMoon, Z0, L5, TMoon, CMoon, L0Moon As Double
	Dim C0Moon As Short
	Dim K1, V2Moon, A2Moon, F1, F0, F2, D2Moon, T0Moon, L2 As Double
	Dim D1Moon, H2Moon, H0Moon, H1Moon, H3Moon, V0Moon As Double
	Dim D7, H7, EMoon, AMoon, BMoon, M3, N7, A7 As Double
	Dim T3 As Object
	Dim T3String As String ', A7String$
	Dim NMoon, FMoon, LMoon, R5, A5, D5, MMMoon, DMoon, GMoon As Double
	Dim PrintCount As Short
	Dim KK1, WMoon, VMoon, UMoon, V1Moon, KK2 As Double
	Dim MoonFlag, TwilightFlag As Boolean ', DSTFlag As Boolean
	Dim SweepStep2, SweepStep3 As Single
	Dim XTB3, XTB2, XTB1, YTB1, YTB2, YTB3 As Single
	Dim XTB7, XTB6, XTB5, XTB4, YTB4, YTB5, YTB6, YTB7 As Single
	Dim XTB11, XTB10, XTB9, XTB8, YTB8, YTB9, YTB10, YTB11 As Single
	Dim XTB15, XTB14, XTB13, XTB12, YTB12, YTB13, YTB14, YTB15 As Single
	Dim XTB16, YTB16 As Single ', XTB17 As Single, YTB17 As Single, XTB18 As Single, YTB18 As Single, XTB19 As Single, YTB19 As Single
	'Dim XTB20 As Single, YTB20 As Single
	Dim C36, C34, C32, Time, C33, C35, C37 As Short
	Dim NutF, NutM, NutD, NutMprime, NutOmega As Double
	Dim NCos, NSin, NF, NM, ND, NMprime, NOmega, NSinT, NCosT As Object
	Dim LH, Ecc, HP As Double ', L0Sun As Double              'HP in Moon - not needed
	Dim MSinA, MMprimeA, MDA, MMA, MFA, MCosA As Object
	Dim MFB, MMB, MDB, MMprimeB, MSinB As Object
	Dim A2, MF, MM, MLprime, MD, MMprime, A1, A3 As Double
	Dim r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau As Double
	Dim Pre2, AberrDec, NutDec, PhaseAngle, NutRA, AberrRA, Pre1, Pre3 As Double
	Dim cosi, AberrB, PeriLo, AberrL, L, xmag As Double
	Dim BodiesFlag As Boolean
	Dim LMin, LoMin As String
	
	Private Sub Calculate()
		'Private Sub cmdCalculate_Click()
		ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(VB.Right(txtTime.Text, 2))
		Greenwich()
		Delta_T()
		Julian()
		Obliquity()
		Nutation()
		Aries()
		NY = (JD - 2451545!) / 365.2425
		SolarSystem()
		Stars1()
		Sorting()
		BN = 0 : Helpers()
	End Sub
	
	'UPGRADE_WARNING: Event chkLimit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkLimit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkLimit.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Dim ScaleSizeF As SizeF
        ScaleSizeF.Height = Me.Height
        ScaleSizeF.Width = Me.Width
        Me.Scale(ScaleSizeF)

		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	'UPGRADE_WARNING: Event chkMoon.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkMoon_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMoon.CheckStateChanged
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
	End Sub
	
	Private Sub cmdCCW_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCCW.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If Button And 1 Then
			WhichWay = Pi / 180
			BestBodies()
		End If
	End Sub
	Private Sub cmdCCW_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCCW.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		IsMouseDown = False
	End Sub
	
	Private Sub cmdCW_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCW.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If Button And 1 Then
			WhichWay = -Pi / 180
			BestBodies()
		End If
	End Sub
	Private Sub cmdCW_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCW.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		IsMouseDown = False
	End Sub
	
	Private Sub cmdData_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdData.Click
		BodiesFlag = True
		'If txtTime.Text = "" Then txtTime.Text = "0000"
		If txtTime.Text = "" Then MsgBox("You must enter a desired ZT for body visibility or Star Finder Data.") : txtTime.Focus() : Exit Sub
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Dim ScaleSizeF As SizeF
        ScaleSizeF.Height = Me.Height
        ScaleSizeF.Width = Me.Width
        Me.Scale(ScaleSizeF)
		View = False
		BlankTimeFlag = False
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
		'Shape1.Visible = False
		'View = False
		'lblN.Visible = False
		'lblE.Visible = False
		'lblS.Visible = False
		'lblW.Visible = False
		'lblN2.Visible = False
		'lblS2.Visible = False
		'lblE2.Visible = False
		'lblW2.Visible = False
		'FrameView.Visible = False
		'optOverhead.Visible = False
		'optStarFinder.Visible = False
		'FrameDirection.Visible = False
		'optN.Visible = False
		'optS.Visible = False
		'optE.Visible = False
		'optW.Visible = False
		StarMagnitudes()
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		'DisplayTwilights
		Calculate()
		DisplayData()
		Warning()
		BodiesFlag = False
	End Sub
	
	Private Sub SunMoonFix()
		SunMoon = True
		FirstTime = 0
		'LastTime = 0
		FT = False
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		'Convert sunrise time to minutes (and round up to nearest five?)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		StartTime = (60 * Val(VB.Left(C3(4), 2)) + Val(VB.Right(C3(4), 2))) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		EndTime = (60 * Val(VB.Left(C3(5), 2)) + Val(VB.Right(C3(5), 2))) * 60
		'Increment in five minute intervals (300 seconds)
		For ZTinSeconds = StartTime To EndTime Step 300
			Greenwich()
			Delta_T()
			Julian()
			Obliquity()
			Nutation()
			Aries()
			NY = (JD - 2451545!) / 365.2425
			BN = 58 : Sun()
			AltAz()
			ZNSun = ZN : HoSun = Ho
			Moon()
			MoonPhase()
			AltAz()
			ZNMoon = ZN : HoMoon = Ho
			ZNDiff = System.Math.Abs(ZNSun - ZNMoon) : If ZNDiff > 180 Then ZNDiff = ZNDiff - 180
			If FT = False And HoSun >= Val(txtMinimumAltitude.Text) And HoMoon >= Val(txtMinimumAltitude.Text) And ZNDiff >= 45 And ZNDiff <= 135 And ZNSun >= LowAz And ZNSun <= HighAz And ZNMoon >= LowAz And ZNMoon <= HighAz Then FirstTime = ZTinSeconds : MoonPhaseFirst = KK : FT = True 'And HoSun > 0 And HoMoon > 0 not needed since already determined in AltAz
			If HoSun >= Val(txtMinimumAltitude.Text) And HoMoon >= Val(txtMinimumAltitude.Text) And ZNDiff >= 45 And ZNDiff <= 135 And ZNSun >= LowAz And ZNSun <= HighAz And ZNMoon >= LowAz And ZNMoon <= HighAz Then LastTime = ZTinSeconds : MoonPhaseLast = KK ' ZTinSeconds = EndTime 'HoSun > 0 And HoMoon > 0 And not needed since already determined in AltAz
		Next ZTinSeconds
		FirstTime = FirstTime / 3600 'hours
		FirstTimeHours = Int(FirstTime)
		FirstTimeMinutes = Int((FirstTime - FirstTimeHours) * 60 + 0.5) 'rounded to nearest minute
		FTHours = VB6.Format(FirstTimeHours, "00")
		FTMinutes = VB6.Format(FirstTimeMinutes, "00")
		LastTime = LastTime / 3600
		LastTimeHours = Int(LastTime)
		LastTimeMinutes = Int((LastTime - LastTimeHours) * 60 + 0.5) 'rounded to nearest minute
		LTHours = VB6.Format(LastTimeHours, "00")
		LTMinutes = VB6.Format(LastTimeMinutes, "00")
		'MoonPhase$ = Format(((MoonPhaseFirst + MoonPhaseLast) / 2), "#0")
	End Sub
	
	Private Sub MoonData()
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		'ZTinSeconds = 3600 * Val(Left$(txtTime.Text, 2)) + 60 * Val(Right$(txtTime.Text, 2))
		ZTinSeconds = 0 'Changing this does not seem to change anything
		
		LatLong()
		
		L5 = -Lo / 360 : Z0 = ZD / 24
		If chkMoon.CheckState = 1 Then L5 = 0 : Z0 = 0 'added in V5.3.0
		MoonFlag = True
		'    Greenwich     THIS LINE WAS MAKING EAST LONGITUDE RISE AND SET TIMES WRONG!!!!!Removed in 5.1.3
		'MoonFlag = True
		'Delta_T
		GDay = Val(cboDay.Text) 'was not in 3.1.0
		GHour = 0 : GMinute = 0 : GSecond = 0
		Julian() : TMoon = JD - 2451545 '3.1.0 had +FF
		MoonFlag = False
		LST() : TMoon = TMoon + Z0
		'   POSITION LOOP
		For i = 1 To 3
			FundamentalArguments()
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(i, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MMoon(i, 1) = A5
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MMoon(i, 2) = D5
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MMoon(i, 3) = R5 : TMoon = TMoon + 0.5
		Next 
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If MMoon(2, 1) > MMoon(1, 1) Then GoTo Line85
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMoon(2, 1) = MMoon(2, 1) + 2 * Pi
Line85: 
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If MMoon(3, 1) > MMoon(2, 1) Then GoTo Line95
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMoon(3, 1) = MMoon(3, 1) + 2 * Pi
Line95: 
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Z1Moon = (Pi / 180) * (90.567 - 41.685 / MMoon(2, 3))
		SMoon = System.Math.Sin(Lat * Pi / 180) : CMoon = System.Math.Cos(Lat * Pi / 180)
		Z = System.Math.Cos(Z1Moon) : M8 = 0 : W8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		A0 = MMoon(1, 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D0 = MMoon(1, 2)
		'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentX = 0
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2350 'is this line necessary?
		PrintCount = 0
		For C0Moon = 0 To 23
			PMoon = (C0Moon + 1) / 24
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F0 = MMoon(1, 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F1 = MMoon(2, 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F2 = MMoon(3, 1)
			ThreePointInterpolation() : A2Moon = FMoon
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F0 = MMoon(1, 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F1 = MMoon(2, 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object MMoon(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			F2 = MMoon(3, 2)
			ThreePointInterpolation() : D2Moon = FMoon
			MoonPosition() : A0 = A2Moon : D0 = D2Moon : V0Moon = V2Moon
		Next 
		'If DSTFlag = False Then SpecialMessages   'eliminated "If DSTFlag=False Then" in V2.7.3
		SpecialMessages()
		
		'Added next three lines in V5.1.3 so Moon phase shown for 1200 ZT instead of 0000 ZT
		GDay = Val(cboDay.Text)
		GHour = 12 + ZD : GMinute = 0 : GSecond = 0
		Julian() : TMoon = JD - 2451545
		
		Moon()
		MoonPhase()
		KK1 = KKFull
		T = T + 0.00000001 'approx. 32 seconds (to determine if waxing or waning?)         was 0.00001 in 3.1.0
		Moon()
		MoonPhase()
		KK2 = KKFull
		KK0 = Int(KK1 * 100 + 0.5)
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2350
		'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentX = 8190
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Moon " & KK0 & "% illuminated, ")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KK2 < KK1 Then
			Print("waning")
		Else
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("waxing")
		End If
	End Sub
	Private Sub MoonPhase()
		'lowest accuracy version
		PhaseAngle = 180 - MD * 180 / Pi - 6.289 * System.Math.Sin(MMprime) + 2.1 * System.Math.Sin(MM) - 1.274 * System.Math.Sin(2 * MD - MMprime) - 0.658 * System.Math.Sin(2 * MD) - 0.214 * System.Math.Sin(2 * MMprime) - 0.11 * System.Math.Sin(MD) 'degrees
		KKFull = (1 + System.Math.Cos(PhaseAngle * Pi / 180)) / 2
		KK = Int(KKFull * 100 + 0.5)
		'KK1 = Int(KK1 * 100 + 0.5)
		
	End Sub
	Private Sub LST()
		'LST at 0h zone time
		T0Moon = TMoon / 36525!
		SMoon = 24110.5 + 8640184.813 * T0Moon
		SMoon = SMoon + 86636.6 * Z0 + 86400! * L5
		SMoon = SMoon / 86400! : SMoon = SMoon - Int(SMoon)
		T0Moon = SMoon * 360 * Pi / 180
	End Sub
	Private Sub ThreePointInterpolation()
		AMoon = F1 - F0 : BMoon = F2 - F1 - AMoon
		FMoon = F0 + PMoon * (2 * AMoon + BMoon * (2 * PMoon - 1))
	End Sub
	Private Sub SpecialMessages()
		If PrintCount = 0 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 0
		End If
		If PrintCount = 1 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 2650
		End If
		If PrintCount = 2 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 5300
		End If
		If M8 = 0 And W8 = 0 Then GoTo Line475
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If M8 = 0 Then Print("No moonrise this date.")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If W8 = 0 Then Print("No moonset this date.")
		Exit Sub
Line475: 
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If V2Moon < 0 Then Print("Moon down all day.")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If V2Moon > 0 Then Print("Moon up all day.")
	End Sub
	Private Sub FundamentalArguments()
		LMoon = 0.606434 + 0.03660110129 * TMoon
		MMMoon = 0.374897 + 0.03629164709 * TMoon
		FMoon = 0.259091 + 0.0367481952 * TMoon
		DMoon = 0.827362 + 0.03386319198 * TMoon
		NMoon = 0.347343 - 0.00014709391 * TMoon
		GMoon = 0.993126 + 0.0027377785 * TMoon
		LMoon = LMoon - Int(LMoon) : MMMoon = MMMoon - Int(MMMoon)
		FMoon = FMoon - Int(FMoon) : DMoon = DMoon - Int(DMoon)
		NMoon = NMoon - Int(NMoon) : GMoon = GMoon - Int(GMoon)
		LMoon = LMoon * 2 * Pi : MMMoon = MMMoon * 2 * Pi : FMoon = FMoon * 2 * Pi
		DMoon = DMoon * 2 * Pi : NMoon = NMoon * 2 * Pi : GMoon = GMoon * 2 * Pi
		VMoon = 0.39558 * System.Math.Sin(FMoon + NMoon) + 0.082 * System.Math.Sin(FMoon) + 0.03257 * System.Math.Sin(MMMoon - FMoon - NMoon) + 0.01092 * System.Math.Sin(MMMoon + FMoon + NMoon) + 0.00666 * System.Math.Sin(MMMoon - FMoon) - 0.00644 * System.Math.Sin(MMMoon + FMoon - 2 * DMoon + NMoon)
		VMoon = VMoon - 0.00331 * System.Math.Sin(FMoon - 2 * DMoon + NMoon) - 0.00304 * System.Math.Sin(FMoon - 2 * DMoon) - 0.0024 * System.Math.Sin(MMMoon - FMoon - 2 * DMoon - NMoon) + 0.00226 * System.Math.Sin(MMMoon + FMoon) - 0.00108 * System.Math.Sin(MMMoon + FMoon - 2 * DMoon)
		VMoon = VMoon - 0.00079 * System.Math.Sin(FMoon - NMoon) + 0.00078 * System.Math.Sin(FMoon + 2 * DMoon + NMoon)
		UMoon = 1 - 0.10828 * System.Math.Cos(MMMoon) - 0.0188 * System.Math.Cos(MMMoon - 2 * DMoon) - 0.01479 * System.Math.Cos(2 * DMoon) + 0.00181 * System.Math.Cos(2 * MMMoon - 2 * DMoon) - 0.00147 * System.Math.Cos(2 * MMMoon)
		UMoon = UMoon - 0.00105 * System.Math.Cos(2 * DMoon - GMoon) - 0.00075 * System.Math.Cos(MMMoon - 2 * DMoon + GMoon)
		WMoon = 0.10478 * System.Math.Sin(MMMoon) - 0.04105 * System.Math.Sin(2 * FMoon + 2 * NMoon) - 0.0213 * System.Math.Sin(MMMoon - 2 * DMoon) - 0.01779 * System.Math.Sin(2 * FMoon + NMoon) + 0.01774 * System.Math.Sin(NMoon)
		WMoon = WMoon + 0.00987 * System.Math.Sin(2 * DMoon) - 0.00338 * System.Math.Sin(MMMoon - 2 * FMoon - 2 * NMoon) - 0.00309 * System.Math.Sin(GMoon) - 0.0019 * System.Math.Sin(2 * FMoon) - 0.00144 * System.Math.Sin(MMMoon + NMoon)
		WMoon = WMoon - 0.00144 * System.Math.Sin(MMMoon - 2 * FMoon - NMoon) - 0.00113 * System.Math.Sin(MMMoon + 2 * FMoon + 2 * NMoon) - 0.00094 * System.Math.Sin(MMMoon - 2 * DMoon + GMoon) - 0.00092 * System.Math.Sin(2 * MMMoon - 2 * DMoon)
		'COMPUTE RA, DEC, DIST
		SMoon = WMoon / System.Math.Sqrt(UMoon - VMoon * VMoon)
		A5 = LMoon + System.Math.Atan(SMoon / System.Math.Sqrt(1 - SMoon * SMoon))
		SMoon = VMoon / System.Math.Sqrt(UMoon) : D5 = System.Math.Atan(SMoon / System.Math.Sqrt(1 - SMoon * SMoon))
		R5 = 60.40974 * System.Math.Sqrt(UMoon)
	End Sub
	Private Sub MoonPosition()
		K1 = 15 * (Pi / 180) * 1.0027379
		L0Moon = T0Moon + C0Moon * K1 : L2 = L0Moon + K1
		If A2Moon < A0 Then A2Moon = A2Moon + 2 * Pi
		H0Moon = L0Moon - A0 : H2Moon = L2 - A2Moon
		H1Moon = (H2Moon + H0Moon) / 2 'HOUR ANGLE
		D1Moon = (D2Moon + D0) / 2 'DEC
		If C0Moon > 0 Then GoTo Line325
		V0Moon = SMoon * System.Math.Sin(D0) + CMoon * System.Math.Cos(D0) * System.Math.Cos(H0Moon) - Z
Line325: 
		V2Moon = SMoon * System.Math.Sin(D2Moon) + CMoon * System.Math.Cos(D2Moon) * System.Math.Cos(H2Moon) - Z
		If System.Math.Sign(V0Moon) = System.Math.Sign(V2Moon) Then Exit Sub
		V1Moon = SMoon * System.Math.Sin(D1Moon) + CMoon * System.Math.Cos(D1Moon) * System.Math.Cos(H1Moon) - Z
		AMoon = 2 * V2Moon - 4 * V1Moon + 2 * V0Moon : BMoon = 4 * V1Moon - 3 * V0Moon - V2Moon
		DMoon = BMoon * BMoon - 4 * AMoon * V0Moon : If DMoon < 0 Then Exit Sub
		DMoon = System.Math.Sqrt(DMoon)
		If PrintCount = 0 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 0
		End If
		If PrintCount = 1 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 2650
		End If
		If PrintCount = 2 Then
			'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = 2350
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 5300
		End If
		'If chkDST = 1 And T3 >= 23 And V0Moon < 0 And V2Moon > 0 Then Print "No moonrise this date.":  DSTFlag = True: Exit Sub    'This line eliminated in V2.7.3
		'If chkDST = 1 And T3 >= 23 And V0Moon > 0 And V2Moon < 0 Then Print "No moonset this date.":  DSTFlag = True: Exit Sub     'This line eliminated in V2.7.3
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If V0Moon < 0 And V2Moon > 0 Then Print("Moonrise at ZT ")
		If V0Moon < 0 And V2Moon > 0 Then M8 = 1
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If V0Moon > 0 And V2Moon < 0 Then Print("Moonset at ZT ")
		If V0Moon > 0 And V2Moon < 0 Then W8 = 1
		
		EMoon = (-BMoon + DMoon) / (2 * AMoon)
		If EMoon > 1 Or EMoon < 0 Then EMoon = (-BMoon - DMoon) / (2 * AMoon)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3 = C0Moon + EMoon + 1 / 120 'ROUND OFF, tried eliminating 1/120 in V2.7.3, sometimes better, sometimes worse
		
		H3Moon = Int(CDbl(T3))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		M3 = Int((T3 - H3Moon) * 60)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3 = H3Moon * 100 + M3
		
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If chkMoon.CheckState = 1 Then T3 = T3 - Int((ZD * 15 - Lo) * 4 + 0.5) 'added in V5.3.0
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If CDbl(VB.Right(Str(T3), 2)) >= 60 Then T3 = T3 + 40 'added in V5.3.0 - prevents times like 1060
		
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3String = Str(10000 + T3)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If chkDST.CheckState = 1 And TwilightFlag = False Then T3String = Str(10100 + T3)
		T3String = VB.Right(T3String, 4)
		
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(T3String)
		H7 = H0Moon + EMoon * (H2Moon - H0Moon)
		N7 = -System.Math.Cos(D1Moon) * System.Math.Sin(H7)
		D7 = CMoon * System.Math.Sin(D1Moon) - SMoon * System.Math.Cos(D1Moon) * System.Math.Cos(H7)
		A7 = System.Math.Atan(N7 / D7) / (Pi / 180)
		If D7 < 0 Then A7 = A7 + 180
		If A7 < 0 Then A7 = A7 + 360
		If A7 > 360 Then A7 = A7 - 360
		'    A7 = Int(A7 + 0.5)     'changed to next line in V5.1.5
		A7 = Int(A7 * 10 + 0.5) / 10
		'    A7String$ = Right$(Str$(1000 + A7), 3)       'A7String$ = Mid$(Str$(1000.01 + A7), 3, 5)
		'    Print ", Zn "; A7String$; Chr$(176): PrintCount = PrintCount + 1
		
		If V0Moon < 0 And V2Moon > 0 Then
			Amp = (System.Math.Sin(D1Moon) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(0.365 * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(0.365 * Pi / 180))
			If Amp > 1 Then Amp = 1 'added in V5.4.0 to avoid Dec. 21 90ºS type error
			Amp = System.Math.Atan(Amp / (System.Math.Sqrt(-Amp * Amp + 1) + 9.999999E-21)) 'arcsin
			Amp = Amp * 180 / Pi
			ZNAmp = 90 - Amp
			ZNAmp = Int(ZNAmp * 10 + 0.5) / 10
			'If ZNAmp - Int(ZNAmp) <> 0 Then ZNAmpString$ = Right$(Str$(1000 + ZNAmp), 5)
			'If ZNAmp - Int(ZNAmp) = 0 Then ZNAmpString$ = Right$(Str$(1000 + ZNAmp), 3) & ".0"
		End If
		
		If V0Moon > 0 And V2Moon < 0 Then
			Amp = (System.Math.Sin(D1Moon) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(0.365 * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(0.365 * Pi / 180))
			If Amp < -1 Then Amp = -1 'added in V5.4.0 to avoid Dec. 21 90ºN type error
			Amp = System.Math.Atan(Amp / (System.Math.Sqrt(-Amp * Amp + 1) + 9.999999E-21)) 'arcsin
			Amp = Amp * 180 / Pi
			ZNAmp = 270 + Amp
			ZNAmp = Int(ZNAmp * 10 + 0.5) / 10
			'If ZNAmp - Int(ZNAmp) <> 0 Then ZNAmpString$ = Right$(Str$(1000 + ZNAmp), 5)
			'If ZNAmp - Int(ZNAmp) = 0 Then ZNAmpString$ = Right$(Str$(1000 + ZNAmp), 3) & ".0"
		End If
		
		'    If optLimb = True Then Print ", Zn "; A7String$; Chr$(176): PrintCount = PrintCount + 1
		'    If optCenter = True Then Print ", Zn "; ZNAmpString$; Chr$(176): PrintCount = PrintCount + 1
		If optLimb.Checked = True Then
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(", Zn " & VB6.Format(A7, "000.0") & Chr(176)) : PrintCount = PrintCount + 1
		End If 'was "000" before V5.1.5
		If optCenter.Checked = True Then
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(", Zn " & VB6.Format(ZNAmp, "000.0") & Chr(176)) : PrintCount = PrintCount + 1
		End If
		
		
		If PrintCount = 2 Then TwilightFlag = False
	End Sub
	Private Sub CmdView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdView.Click
		BodiesFlag = True
		'If txtTime.Text = "" Then txtTime.Text = "0000"
		If txtTime.Text = "" Then MsgBox("You must enter a desired ZT for body visibility.") : txtTime.Focus() : Exit Sub
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		'optOff = True
		BlankTimeFlag = False
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		'Cls
		Shape1.Visible = False
		'    If (chkFirst.Value = 1 And chkSecond.Value = 1 And chkThird.Value = 1) Then
		'        chkHelper.Visible = True
		'        chkHelper.Enabled = True
		'        Else
		'        chkHelper.Visible = False
		'        chkHelper.Enabled = False
		'    End If
		View = True
		If GYear <= 2005 Then
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1-1.2", -0.9, -1.6, " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6"}
			'End If
		Else 'If Val(txtYear.Text) >= 2006 Then
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1-1.2", -0.7, -1.5, " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", -0.3, " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5"}
		End If
		For i = 0 To 57
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag(i) = Magnitude(i)
		Next i
		'Twilights
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		'DisplayTwilights
		'Warning
		Calculate()
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
		BodiesFlag = False
	End Sub
	
	Private Sub CmdVisible_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdVisible.Click
		BodiesFlag = True
		'If txtTime.Text = "" Then txtTime.Text = "0000"
		If txtTime.Text = "" Then MsgBox("You must enter a desired ZT for body visibility.") : txtTime.Focus() : Exit Sub
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		View = False
		BlankTimeFlag = False
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'View = False
		'lblN.Visible = False
		'lblE.Visible = False
		'lblS.Visible = False
		'lblW.Visible = False
		'lblN2.Visible = False
		'lblS2.Visible = False
		'lblE2.Visible = False
		'lblW2.Visible = False
		chkFirst.Visible = False
		chkSecond.Visible = False
		chkThird.Visible = False
		chkNames.Visible = False
		chkLimit.Visible = False
		'chkHelper.Visible = False
		'FrameView.Visible = False
		'optOverhead.Visible = False
		'optStarFinder.Visible = False
		'FrameDirection.Visible = False
		'optN.Visible = False
		'optS.Visible = False
		'optE.Visible = False
		'optW.Visible = False
		If GYear <= 2005 Then
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1-1.2", -0.9, -1.6, " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6"}
			'End If
		Else 'If Val(txtYear.Text) >= 2006 Then
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1-1.2", -0.7, -1.5, " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", -0.3, " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5"}
		End If
		For i = 0 To 57
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag(i) = Magnitude(i)
		Next i
		'DisplayTwilights
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		'If optHorizon = False Then DisplayView Else DisplayHorizonView
		'If optTwo = True Then optTwo_Click
		'If optThreeBoat = True Then optThreeBoat_Click
		Calculate()
		SunMoonFix()
		DisplayFirst()
		DisplaySecond()
		DisplayThird()
		DisplaySunMoon()
		Cursor = System.Windows.Forms.Cursors.Default
		Warning()
		BodiesFlag = False
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		'    Printer.ColorMode = vbPRCMMonochrome
		'    Form2.PrintForm
		'    Printer.ColorMode = vbPRCMColor
		FormHeight = VB6.PixelsToTwipsY(Me.Height)
		FormWidth = VB6.PixelsToTwipsX(Me.Width)
		PrintScreen()
	End Sub
	
	Private Sub cmdTwilights_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTwilights.Click
		BodiesFlag = False
		txtWarning.Visible = False
		TwilightFlag = True
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		LatLong()
		Greenwich()
		Twilights()
		DisplayTwilights()
		If BlankTimeFlag = True Then txtTime.Text = ""
		BlankTimeFlag = True
		MoonData()
		BodiesFlag = True
	End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		'DSTFlag = False    'eliminated in V2.7.3
		Pi = 4 * System.Math.Atan(1#)
		NT = "00010203040506070809101112131415161718192021222324252627282930"
		NT = NT & "3132333435363738394041424344454647484950515253545556575859"
		cboL.SelectedIndex = 0 ' "N"
		cboLo.SelectedIndex = 0 ' "W"
		'lblZDh.Visible = False
		txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
		cboZDm.SelectedIndex = 0 ' "00"
		
		'RA is Right Ascension hours of stars
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RAStars. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RAStars = New Object(){2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065, 4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679, 7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617, 12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587, 14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901, 18.92109048, 19.84638861, 20.42846051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827}
		'Dec is Declination degrees of stars
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DecStars. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DecStars = New Object(){89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959, 16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374, 5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947, -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818, 74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918, -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
		
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Body. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Body = New Object(){"Polaris", "Alpheratz", "Ankaa", "Schedar", "Diphda", "Achernar", "Hamal", "Acamar", "Menkar", "Mirfak", "Aldebaran", "Rigel", "Capella", "Bellatrix", "Elnath", "Alnilam", "Betelgeuse", "Canopus", "Sirius", "Adhara", "Procyon", "Pollux", "Avior", "Suhail", "Miaplacidus", "Alphard", "Regulus", "Dubhe", "Denebola", "Gienah", "Acrux", "Gacrux", "Alioth", "Spica", "Alkaid", "Hadar", "Menkent", "Arcturus", "Rigil Kentaurus", "Zubenelgenubi", "Kochab", "Alphecca", "Antares", "Atria", "Sabik", "Shaula", "Rasalhague", "Eltanin", "Kaus Australis", "Vega", "Nunki", "Altair", "Peacock", "Deneb", "Enif", "Al Na'ir", "Fomalhaut", "Markab", "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn"}
		
		'Proper motion right ascension in seconds/century
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PMRA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PMRA = New Object(){22.9526, 1.0351, 2.0982, 0.6089, 1.6317, 1.0843, 1.3861, -0.468, -0.0789, 0.2493, 0.4365, 0.0126, 0.7247, -0.0587, 0.1768, 0.0099, 0.1837, 0.2199, -3.8007, 0.02, -4.797, -4.7254, -0.3329, -0.2131, -3.032, -0.0977, -1.6996, -1.9221, -3.4374, -1.1158, -0.5212, 0.3431, 1.3308, -0.2888, -1.2397, -0.458, -4.2995, -7.718, -50.3145, -0.7331, -0.7884, 0.8984, -0.0756, 0.3325, 0.2851, -0.0744, 0.7519, -0.0912, -0.32, 1.7192, 0.1031, 3.6221, 0.0937, 0.0148, 0.2031, 1.2464, 2.5248, 0.4221}
		'Proper motion declination in arcseconds/century
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PMDec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PMDec = New Object(){-1.1746, -16.295, -35.3638, -3.217, 3.2711, -4.0079, -14.5771, 2.571, -7.876, -2.601, -18.936, -0.056, -42.713, -1.328, -17.422, -0.106, 1.086, 2.367, -122.3076, 0.229, -103.4582, -4.5959, 2.272, 1.428, 10.8913, 3.325, 0.4909, -3.5251, 11.3783, 2.231, -1.473, -26.433, -0.8991, -3.173, -1.5561, -2.506, -51.7862, -199.9418, 48.2868, -6.9, 1.191, -8.944, -2.321, -3.292, 9.765, -2.995, -22.261, -2.305, -12.405, 28.7459, -5.265, 38.5538, -8.615, 0.155, 0.138, -14.7909, -16.4217, -4.256}
		
		
		'Star magnitudes were here
		
		'nutation in longitude and obliquity
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ND. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ND = New Object(){0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NM = New Object(){0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NMprime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NMprime = New Object(){0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NF. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NF = New Object(){0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NOmega. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NOmega = New Object(){1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NSin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NSin = New Object(){-171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NSinT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NSinT = New Object(){-174.2, -1.6, -0.2, 0.2, -3.4, 0.1, 1.2, -0.4, 0, -0.5, 0, 0.1, 0, 0, 0.1, 0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NCos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NCos = New Object(){92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NCosT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NCosT = New Object(){8.9, -3.1, -0.5, 0.5, -0.1, 0, -0.6, 0, -0.1, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		
		'Moon
		'Table 47.A longitude and distance
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MDA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MDA = New Object(){0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 1, 0, 2, 0, 0, 4, 0, 4, 2, 2, 1, 1, 2, 2, 4, 2, 0, 2, 2, 1, 2, 0, 0, 2, 2, 2, 4, 0, 3, 2, 4, 0, 2, 2, 2, 4, 0, 4, 1, 2, 0, 1, 3, 4, 2, 0, 1, 2, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMA = New Object(){0, 0, 0, 0, 1, 0, 0, -1, 0, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, -1, 0, 0, 0, 1, 0, -1, 0, -2, 1, 2, -2, 0, 0, -1, 0, 0, 1, -1, 2, 2, 1, -1, 0, 0, -1, 0, 1, 0, 1, 0, 0, -1, 2, 1, 0, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMprimeA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMprimeA = New Object(){1, -1, 0, 2, 0, 0, -2, -1, 1, 0, -1, 0, 1, 0, 1, 1, -1, 3, -2, -1, 0, -1, 0, 1, 2, 0, -3, -2, -1, -2, 1, 0, 2, 0, -1, 1, 0, -1, 2, -1, 1, -2, -1, -1, -2, 0, 1, 4, 0, -2, 0, 2, 1, -2, -3, 2, 1, -1, 3, -1}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MFA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MFA = New Object(){0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, -2, 2, -2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, -2, 2, 0, 2, 0, 0, 0, 0, 0, 0, -2, 0, 0, 0, 0, -2, -2, 0, 0, 0, 0, 0, 0, 0, -2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSinA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MSinA = New Object(){6288774, 1274027, 658314, 213618, -185116, -114332, 58793, 57066, 53322, 45758, -40923, -34720, -30383, 15327, -12528, 10980, 10675, 10034, 8548, -7888, -6766, -5163, 4987, 4036, 3994, 3861, 3665, -2689, -2602, 2390, -2348, 2236, -2120, -2069, 2048, -1773, -1595, 1215, -1110, -892, -810, 759, -713, -700, 691, 596, 549, 537, 520, -487, -399, -381, 351, -340, 330, 327, -323, 299, 294, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MCosA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MCosA = New Object(){-20905355, -3699111, -2955968, -569925, 48888, -3149, 246158, -152138, -170733, -204586, -129620, 108743, 104755, 10321, 0, 79661, -34782, -23210, -21636, 24208, 30824, -8379, -16675, -12831, -10445, -11650, 14403, -7003, 0, 10056, 6322, -9884, 5751, 0, -4950, 4130, 0, -3958, 0, 3258, 2616, -1897, -2117, 2354, 0, 0, -1423, -1117, -1571, -1739, 0, -4421, 0, 0, 0, 0, 1165, 0, 0, 8752}
		'Table 47.B latitude
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MDB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MDB = New Object(){0, 0, 0, 2, 2, 2, 2, 0, 2, 0, 2, 2, 2, 2, 2, 2, 2, 0, 4, 0, 0, 0, 1, 0, 0, 0, 1, 0, 4, 4, 0, 4, 2, 2, 2, 2, 0, 2, 2, 2, 2, 4, 2, 2, 0, 2, 1, 1, 0, 2, 1, 2, 0, 4, 4, 1, 4, 1, 4, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMB = New Object(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 1, -1, -1, -1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1, 1, 0, -1, -2, 0, 1, 1, 1, 1, 1, 0, -1, 1, 0, -1, 0, 0, 0, -1, -2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MMprimeB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMprimeB = New Object(){0, 1, 1, 0, -1, -1, 0, 2, 1, 2, 0, -2, 1, 0, -1, 0, -1, -1, -1, 0, 0, -1, 0, 1, 1, 0, 0, 3, 0, -1, 1, -2, 0, 2, 1, -2, 3, 2, -3, -1, 0, 0, 1, 0, 1, 1, 0, 0, -2, -1, 1, -2, 2, -2, -1, 1, 1, -1, 0, 0}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MFB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MFB = New Object(){1, 1, -1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, -1, -1, -1, 1, 3, 1, 1, 1, -1, -1, -1, 1, -1, 1, -3, 1, -3, -1, -1, 1, -1, 1, -1, 1, 1, 1, 1, -1, 3, -1, -1, 1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MSinB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MSinB = New Object(){5128122, 280602, 277693, 173237, 55413, 46271, 32573, 17198, 9266, 8822, 8216, 4324, 4200, -3359, 2463, 2211, 2065, -1870, 1828, -1794, -1749, -1565, -1491, -1475, -1410, -1344, -1335, 1107, 1021, 833, 777, 671, 607, 596, 491, -451, 439, 422, 421, -366, -351, 331, 315, 302, -283, -229, 223, 223, -220, -220, -185, 181, -177, 176, 166, -164, 132, -119, 115, 107}
		
		
		'Helper stars
		NumberOfHelpers = 70
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RDHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RDHelper = New Object(){11, 11, 12, 13, 15, 16, 15, 16, 17, 0, 0, 1, 1, 23, 0, 5, 5, 5, 5, 7, 19, 20, 19, 20, 19, 12, 12, 12, 12, 12, 16, 16, 15, 16, 16, 16, 17, 17, 17, 15, 15, 15, 15, 15, 10, 11, 9, 10, 9, 11, 18, 18, 18, 19, 19, 18, 18, 19, 4, 4, 4, 5, 19, 19, 19, 19, 19, 20, 1, 2}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RMHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RMHelper = New Object(){1, 53, 15, 23, 20, 17, 44, 45, 32, 9, 56, 25, 54, 3, 13, 40, 32, 47, 35, 34, 30, 22, 44, 46, 56, 34, 29, 10, 47, 15, 5, 0, 58, 35, 50, 51, 12, 37, 42, 27, 32, 55, 57, 42, 19, 14, 45, 16, 45, 14, 5, 21, 27, 2, 9, 17, 45, 6, 28, 19, 28, 37, 55, 46, 5, 6, 25, 11, 9, 3}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RSHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RSHelper = New Object(){50, 50, 26, 56, 44, 30, 3, 58, 13, 11, 42, 49, 24, 46, 14, 46, 0, 45, 26, 36, 43, 14, 58, 13, 18, 23, 52, 7, 43, 9, 26, 20, 51, 53, 10, 52, 9, 19, 29, 50, 56, 48, 35, 45, 58, 6, 51, 41, 51, 14, 48, 0, 58, 37, 46, 38, 39, 56, 37, 48, 40, 39, 19, 15, 24, 15, 30, 18, 44, 54}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DDHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DDHelper = New Object(){56, 53, 57, 54, 71, 75, 77, 82, 86, 59, 60, 60, 63, 28, 15, -1, -0, -9, -5, 31, 27, 40, 45, 33, 35, -23, -16, -22, -59, -58, -19, -22, -26, -28, -34, -38, -43, -42, -39, 29, 31, 26, 26, 26, 19, 20, 23, 23, 23, 15, -30, -29, -25, -29, -21, -36, -26, -27, 19, 15, 15, 21, 6, 10, 13, -4, 3, -0, 35, 42}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DMHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DMHelper = New Object(){22, 41, 1, 55, 50, 45, 47, 2, 35, 8, 43, 14, 40, 4, 11, 56, -17, 40, 54, 53, 57, 15, 7, 58, 5, 23, 30, 37, 41, 44, 48, 37, 6, 12, 17, 2, 14, 59, 1, 6, 21, 4, 52, 17, 50, 31, 46, 25, 46, 25, 25, 49, 25, 52, 1, 45, 59, 40, 10, 37, 52, 8, 24, 36, 51, 52, 6, -49, 37, 19}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DSHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DSHelper = New Object(){56, 41, 57, 31, 2, 19, 40, 14, 11, 59, 0, 7, 13, 58, 1, 34, 57, 11, 36, 18, 35, 24, 51, 13, 0, 48, 55, 11, 19, 55, 19, 18, 50, 58, 36, 51, 21, 52, 48, 20, 32, 49, 40, 44, 30, 25, 27, 2, 27, 46, 26, 42, 18, 49, 25, 42, 27, 13, 49, 39, 15, 33, 24, 48, 48, 57, 53, 17, 14, 47}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MagHelper. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MagHelper = New Object(){2.4, 2.4, 3.3, 2.3, 3.1, 5, 4.3, 4.2, 4.4, 2.3, 2.5, 2.7, 3.4, 2.4, 2.8, 1.8, 2.2, 2.1, 2.8, 1.6, 3.1, 2.2, 2.9, 2.5, 3.9, 2.7, 3, 3, 1.3, 2.8, 2.6, 2.3, 2.9, 2.8, 2.3, 3, 3.3, 1.9, 2.4, 3.7, 4.1, 5.5, 4.2, 3.8, 2.3, 2.6, 3, 3.4, 3, 3.3, 3, 2.7, 2.8, 3, 2.9, 3.1, 3.2, 3.3, 3.5, 3.7, 3.4, 3, 3.7, 2.7, 3, 3.4, 3.4, 3.2, 2.1, 2.2}
		'Big Dipper 4, Little Dipper 5, Cassiopeia 4
		'Pegasus 2, Orion 4, Gemini 1, Cygnus 5, Corvus 3, Crux 2
		'Scorpius 9, Corona Borealis 5
		'Leo 6, Sagittarius 8
		'Taurus 4, Aquila 6, Andromeda 2
		MoonFlag = False 'is this necessary?
		ReDim TTip1(0)
		ReDim TTip2(0)
		ReDim TTip3(0)
		bShowToolTips = False ' set to true to display body name tooltip
	End Sub
	
	Private Sub Form2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		cboDay.SelectedIndex = VB.Day(Today) - 1 '-1 because ListIndex starts with 0
		MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec"
		cboMonth.Text = Mid(MonthList, 3 * Val(CStr(Month(Today))) - 2, 3)
		txtYear.Text = CStr(Year(Today))
		cboL.SelectedIndex = 0 '"N"
		cboLo.SelectedIndex = 0 '"W"
		Timer1.Interval = 100
		IsMouseDown = False
	End Sub
	
	'UPGRADE_WARNING: Event cboDay.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboDay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDay.SelectedIndexChanged
		'Form1.txtDay_Change
		'txtDay.ForeColor = &H80000008
		'txtDay.BackColor = &H80000005
		'If Val(txtDay.Text) > 31 Then
		'    txtDay.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
		CheckDate()
	End Sub
	
	Private Sub cboDay_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDay.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		'Select Case KeyAscii
		'    Case Asc("0")
		'        If Len(txtDay.Text) = 0 Then
		'            KeyAscii = 0
		'            Beep
		'        Else
		'            fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'        End If
		'    Case Asc("1") To Asc("9")
		'        fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'    Case Asc(Chr$(8))
		'        fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'    Case Else
		'        KeyAscii = 0
		'        Beep
		'    End Select
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cboMonth.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboMonth_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMonth.SelectedIndexChanged
		CheckDate()
	End Sub
	
	Private Sub Form2_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event optCenter.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optCenter_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCenter.CheckedChanged
		If eventSender.Checked Then
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optE.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optE_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optE.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			If optHorizon.Checked = True Then
				ShiftX = 0 '1620
				ShiftAz = 0 '-90
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				'lblW.Visible = True
				'lblN2.Visible = False
				'lblE2.Visible = False
				'lblS2.Visible = False
				'lblW2.Visible = True
				'lblW.Top = 8000
				'lblW.Left = 1730
				lblN.Top = VB6.TwipsToPixelsY(8000)
				lblN.Left = VB6.TwipsToPixelsX(1730) '3350
				lblE.Top = VB6.TwipsToPixelsY(8000)
				lblE.Left = VB6.TwipsToPixelsX(4970)
				lblS.Top = VB6.TwipsToPixelsY(8000)
				lblS.Left = VB6.TwipsToPixelsX(8210) '6590
				'lblW2.Top = 8000
				'lblW2.Left = 8210
				'DisplayHorizonView
			Else
				RotateX = 90
				RotateY = 90
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				lblE.Left = VB6.TwipsToPixelsX(5180)
				lblS.Top = VB6.TwipsToPixelsY(5880)
				lblS.Left = VB6.TwipsToPixelsX(7680)
				lblW.Left = VB6.TwipsToPixelsX(5180)
				lblN.Top = VB6.TwipsToPixelsY(5880)
				lblN.Left = VB6.TwipsToPixelsX(2640)
				If optStarFinder.Checked = True Then
					lblE.Top = VB6.TwipsToPixelsY(8350) '3460
					lblW.Top = VB6.TwipsToPixelsY(3400) '8350
					lblS.Left = VB6.TwipsToPixelsX(2640) '7680
					lblN.Left = VB6.TwipsToPixelsX(7680) '2680
					RotateX = 270
					RotateY = 270
				Else
					lblW.Top = VB6.TwipsToPixelsY(3400)
					lblE.Top = VB6.TwipsToPixelsY(8350)
				End If
				'DisplayView
			End If
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optHorizon = False And optTwo = True Then optTwo_Click
			'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
			'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizon.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizon.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			FrameDirection.Visible = True
			'optN.Visible = True
			'optS.Visible = True
			'optE.Visible = True
			'optW.Visible = True
			'DisplayTwilights
			If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
			If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
			If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
			If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
			'''DisplayHorizonView
			'Warning
			CmdView_Click(CmdView, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optLimb.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optLimb_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optLimb.CheckedChanged
		If eventSender.Checked Then
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optN.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optN_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optN.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			If optHorizon.Checked = True Then
				ShiftX = 3240
				ShiftAz = 270 '180
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				'lblS.Visible = True
				lblW.Visible = True
				'lblN2.Visible = False
				'lblE2.Visible = False
				'lblS2.Visible = True
				'lblW2.Visible = False
				'lblS.Top = 8000
				'lblS.Left = 1730
				lblW.Top = VB6.TwipsToPixelsY(8000)
				lblW.Left = VB6.TwipsToPixelsX(1730) '3350
				lblN.Top = VB6.TwipsToPixelsY(8000)
				lblN.Left = VB6.TwipsToPixelsX(4970)
				lblE.Top = VB6.TwipsToPixelsY(8000)
				lblE.Left = VB6.TwipsToPixelsX(8210) '6590
				'lblS2.Top = 8000
				'lblS2.Left = 8210
				'DisplayHorizonView
			Else
				RotateX = 180
				RotateY = 180
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				lblN.Top = VB6.TwipsToPixelsY(8350)
				lblN.Left = VB6.TwipsToPixelsX(5180)
				lblS.Top = VB6.TwipsToPixelsY(3400)
				lblS.Left = VB6.TwipsToPixelsX(5180)
				lblW.Top = VB6.TwipsToPixelsY(5880)
				lblE.Top = VB6.TwipsToPixelsY(5880)
				If optStarFinder.Checked = True Then
					lblW.Left = VB6.TwipsToPixelsX(7680)
					lblE.Left = VB6.TwipsToPixelsX(2640)
				Else
					lblW.Left = VB6.TwipsToPixelsX(2640)
					lblE.Left = VB6.TwipsToPixelsX(7680)
				End If
				'DisplayView
			End If
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optHorizon = False And optTwo = True Then optTwo_Click
			'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
			'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optOverhead.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOverhead_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOverhead.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'CurrentY = 3500
			'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			FrameDirection.Visible = True 'False
			'optN.Visible = True 'False
			'optS.Visible = True 'False
			'optE.Visible = True 'False
			'optW.Visible = True 'False
			'lblN2.Visible = False
			'lblS2.Visible = False
			'lblE2.Visible = False
			'lblW2.Visible = False
			'DisplayTwilights
			If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
			If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
			If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
			If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
			'lblE.Left = 2680
			'lblW.Left = 7680
			'lblW.Alignment = 1
			'''DisplayView
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optTwo = True Then optTwo_Click
			'If optThreeBoat = True Then optThreeBoat_Click
			'If optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optS.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			If optHorizon.Checked = True Then
				ShiftX = -3240 '0
				ShiftAz = 90 '0
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				'lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				'lblN2.Visible = True
				'lblE2.Visible = False
				'lblS2.Visible = False
				'lblW2.Visible = False
				'lblN.Top = 8000
				'lblN.Left = 1730
				lblE.Top = VB6.TwipsToPixelsY(8000)
				lblE.Left = VB6.TwipsToPixelsX(1730) '3350
				lblS.Top = VB6.TwipsToPixelsY(8000)
				lblS.Left = VB6.TwipsToPixelsX(4970)
				lblW.Top = VB6.TwipsToPixelsY(8000)
				lblW.Left = VB6.TwipsToPixelsX(8210) '6590
				'lblN2.Top = 8000
				'lblN2.Left = 8210
				'DisplayHorizonView
			Else
				RotateX = 0
				RotateY = 0
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				lblS.Top = VB6.TwipsToPixelsY(8350)
				lblS.Left = VB6.TwipsToPixelsX(5180)
				lblN.Top = VB6.TwipsToPixelsY(3400)
				lblN.Left = VB6.TwipsToPixelsX(5180)
				lblE.Top = VB6.TwipsToPixelsY(5880)
				lblW.Top = VB6.TwipsToPixelsY(5880)
				If optStarFinder.Checked = True Then
					lblE.Left = VB6.TwipsToPixelsX(7680)
					lblW.Left = VB6.TwipsToPixelsX(2640)
				Else
					lblW.Left = VB6.TwipsToPixelsX(7680)
					lblE.Left = VB6.TwipsToPixelsX(2640)
				End If
				'DisplayView
			End If
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optHorizon = False And optTwo = True Then optTwo_Click
			'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
			'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optStarFinder.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optStarFinder_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStarFinder.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'CurrentY = 3500
			'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Cls()
			FrameDirection.Visible = True 'False
			'optN.Visible = True 'False
			'optS.Visible = True 'False
			'optE.Visible = True 'False
			'optW.Visible = True 'False
			'lblN2.Visible = False
			'lblS2.Visible = False
			'lblE2.Visible = False
			'lblW2.Visible = False
			'DisplayTwilights
			If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
			If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
			If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
			If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
			'lblE.Left = 7680
			'lblE.Alignment = 1
			'lblW.Left = 2680
			'''DisplayView
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optTwo = True Then optTwo_Click
			'If optThreeBoat = True Then optThreeBoat_Click
			'If optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optThreeBoat.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optThreeBoat_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optThreeBoat.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'Cls
			CmdView_Click(CmdView, New System.EventArgs())
			cmdCW.Enabled = True
			'cmdCW.Visible = True
			cmdCCW.Enabled = True
			'cmdCCW.Visible = True
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale (-5228, 5980) - (5228, -2540)
			XTB1 = 2400 * System.Math.Cos(SweepStep3)
			YTB1 = 2400 * System.Math.Sin(SweepStep3)
			XTB2 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3)
			YTB2 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3)
			XTB3 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3)
			YTB3 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3)
			XTB9 = 2400 * System.Math.Cos(SweepStep3 - Pi / 12)
			YTB9 = 2400 * System.Math.Sin(SweepStep3 - Pi / 12)
			XTB10 = 2400 * System.Math.Cos(SweepStep3 + Pi / 12)
			YTB10 = 2400 * System.Math.Sin(SweepStep3 + Pi / 12)
			XTB11 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			YTB11 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			XTB12 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			YTB12 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			XTB13 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			YTB13 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			XTB14 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			YTB14 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB1, YTB1), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB2, YTB2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB3, YTB3), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 1
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB9, YTB9), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB10, YTB10), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 3
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB11, YTB11), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB12, YTB12), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 4
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB13, YTB13), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB14, YTB14), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		End If
	End Sub
	'UPGRADE_WARNING: Event optThreeBeach.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optThreeBeach_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optThreeBeach.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'Cls
			CmdView_Click(CmdView, New System.EventArgs())
			cmdCW.Enabled = True
			'cmdCW.Visible = True
			cmdCCW.Enabled = True
			'cmdCCW.Visible = True
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale (-5228, 5980) - (5228, -2540)
			XTB2 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3)
			YTB2 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3)
			XTB3 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3)
			YTB3 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3)
			XTB8 = 2400 * System.Math.Cos(SweepStep3 + Pi)
			YTB8 = 2400 * System.Math.Sin(SweepStep3 + Pi)
			XTB11 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			YTB11 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			'XTB12 = 2400 * Cos(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			'YTB12 = 2400 * Sin(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			'XTB13 = 2400 * Cos(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			'YTB13 = 2400 * Sin(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			XTB14 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			YTB14 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			'XTB15 = 2400 * Cos(SweepStep3 + Pi - Pi / 12)
			'YTB15 = 2400 * Sin(SweepStep3 + Pi - Pi / 12)
			'XTB16 = 2400 * Cos(SweepStep3 + Pi + Pi / 12)
			'YTB16 = 2400 * Sin(SweepStep3 + Pi + Pi / 12)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB2, YTB2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB3, YTB3), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB8, YTB8), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 1
			'Line (0, 0)-(XTB15, YTB15), vbRed
			'Line (0, 0)-(XTB16, YTB16), vbRed
			'DrawStyle = 3
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB11, YTB11), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'Line (0, 0)-(XTB12, YTB12), vbRed
			'DrawStyle = 4
			'Line (0, 0)-(XTB13, YTB13), vbRed
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB14, YTB14), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		End If
	End Sub
	'UPGRADE_WARNING: Event optTwo.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTwo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTwo.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'Cls
			CmdView_Click(CmdView, New System.EventArgs())
			cmdCW.Enabled = True
			'cmdCW.Visible = True
			cmdCCW.Enabled = True
			'cmdCCW.Visible = True
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale (-5228, 5980) - (5228, -2540)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
			XTB1 = 2400 * System.Math.Cos(SweepStep2)
			YTB1 = 2400 * System.Math.Sin(SweepStep2)
			XTB2 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2)
			YTB2 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB1, YTB1), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB2, YTB2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			XTB4 = 2400 * System.Math.Cos(SweepStep2 - Pi / 8)
			YTB4 = 2400 * System.Math.Sin(SweepStep2 - Pi / 8)
			XTB5 = 2400 * System.Math.Cos(SweepStep2 + Pi / 8)
			YTB5 = 2400 * System.Math.Sin(SweepStep2 + Pi / 8)
			XTB6 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2 - Pi / 8)
			YTB6 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2 - Pi / 8)
			XTB7 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2 + Pi / 8)
			YTB7 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2 + Pi / 8)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 1
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB4, YTB4), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB5, YTB5), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 3
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB6, YTB6), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB7, YTB7), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		End If
	End Sub
	'UPGRADE_WARNING: Event optOff.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOff_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOff.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			'Cls
			CmdView_Click(CmdView, New System.EventArgs())
			cmdCW.Enabled = False
			'cmdCW.Visible = False
			cmdCCW.Enabled = False
			'cmdCCW.Visible = False
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optW.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optW_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optW.CheckedChanged
		If eventSender.Checked Then
			'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Scale 
			If optHorizon.Checked = True Then
				ShiftX = -6480 '-1620
				ShiftAz = 180 '90
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				'lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				'lblN2.Visible = False
				'lblE2.Visible = True
				'lblS2.Visible = False
				'lblW2.Visible = False
				'lblE.Top = 8000
				'lblE.Left = 1730
				lblS.Top = VB6.TwipsToPixelsY(8000)
				lblS.Left = VB6.TwipsToPixelsX(1730) '3350
				lblW.Top = VB6.TwipsToPixelsY(8000)
				lblW.Left = VB6.TwipsToPixelsX(4970)
				lblN.Top = VB6.TwipsToPixelsY(8000)
				lblN.Left = VB6.TwipsToPixelsX(8210) '6590
				'lblE2.Top = 8000
				'lblE2.Left = 8210
				'DisplayHorizonView
			Else
				RotateX = 270
				RotateY = 270
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				'DisplayTwilights
				lblN.Visible = True
				lblE.Visible = True
				lblS.Visible = True
				lblW.Visible = True
				lblW.Left = VB6.TwipsToPixelsX(5180)
				lblN.Top = VB6.TwipsToPixelsY(5880)
				lblN.Left = VB6.TwipsToPixelsX(7680)
				lblE.Left = VB6.TwipsToPixelsX(5180)
				lblS.Top = VB6.TwipsToPixelsY(5880)
				lblS.Left = VB6.TwipsToPixelsX(2640)
				If optStarFinder.Checked = True Then
					lblW.Top = VB6.TwipsToPixelsY(8350) '3460
					lblE.Top = VB6.TwipsToPixelsY(3400) '8350
					lblS.Left = VB6.TwipsToPixelsX(7680)
					lblN.Left = VB6.TwipsToPixelsX(2640)
					RotateX = 90
					RotateY = 90
				Else
					lblE.Top = VB6.TwipsToPixelsY(3400)
					lblW.Top = VB6.TwipsToPixelsY(8350)
				End If
				'DisplayView
			End If
			'Warning
			BlankTimeFlag = False
			cmdTwilights_Click(cmdTwilights, New System.EventArgs())
			If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
			'If optHorizon = False And optTwo = True Then optTwo_Click
			'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
			'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim bBodyFound As Boolean
		
		If optHorizon.Checked = False Then
			rad = System.Math.Sqrt((MouseX - 349) ^ 2 + (MouseY - 399) ^ 2)
			'Debug.Print MouseX, MouseY, rad
			If rad > 160 Or View = False Then
				Cursor = System.Windows.Forms.Cursors.Default
				lblAlt.Text = ""
				lblAz.Text = ""
				lblBodyName.Text = ""
			Else
				'UPGRADE_ISSUE: Form property Form2.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
				Cursor = vbCustom
				lblAlt.Text = CStr(System.Math.Round((160 - rad) * 90 / 160))
				If MouseX - 349 = 0 And MouseY - 399 >= 0 Then lblAz.Text = "180"
				If MouseX - 349 = 0 And MouseY - 399 < 0 Then lblAz.Text = "0"
				If optOverhead.Checked = True And MouseX - 349 > 0 Then lblAz.Text = CStr(System.Math.Round(System.Math.Atan((399 - MouseY) / (MouseX - 349)) * 180 / Pi) + 270)
				If optOverhead.Checked = True And MouseX - 349 < 0 Then lblAz.Text = CStr(System.Math.Round(System.Math.Atan((399 - MouseY) / (MouseX - 349)) * 180 / Pi) + 90)
				If optStarFinder.Checked = True And MouseX - 349 > 0 Then lblAz.Text = CStr(System.Math.Round(System.Math.Atan((399 - MouseY) / (349 - MouseX)) * 180 / Pi) + 90)
				If optStarFinder.Checked = True And MouseX - 349 < 0 Then lblAz.Text = CStr(System.Math.Round(System.Math.Atan((399 - MouseY) / (349 - MouseX)) * 180 / Pi) + 270)
				If optS.Checked = True Then lblAz.Text = lblAz.Text
				If optN.Checked = True Then lblAz.Text = CStr(CDbl(lblAz.Text) + 180)
				If optE.Checked = True Then lblAz.Text = CStr(CDbl(lblAz.Text) + 270)
				If optW.Checked = True Then lblAz.Text = CStr(CDbl(lblAz.Text) + 90)
				If Val(lblAz.Text) >= 360 Then lblAz.Text = CStr(Val(lblAz.Text) - 360) 'Bad
				bBodyFound = False
				For i = 0 To UBound(TTip1, 1)
					If Not TTip1(i) Is Nothing Then
						If TTip1(i).PointInBounds(MouseX, MouseY) Then
							lblBodyName.Text = TTip1(i).GetToolTipText()
							bBodyFound = True
							Exit For
						End If
					End If
				Next i
				If Not bBodyFound Then
					For i = 0 To UBound(TTip2, 1)
						If Not TTip2(i) Is Nothing Then
							If TTip2(i).PointInBounds(MouseX, MouseY) Then
								lblBodyName.Text = TTip2(i).GetToolTipText()
								bBodyFound = True
								Exit For
							End If
						End If
					Next i
				End If
				If Not bBodyFound Then
					For i = 0 To UBound(TTip3, 1)
						If Not TTip3(i) Is Nothing Then
							If TTip3(i).PointInBounds(MouseX, MouseY) Then
								lblBodyName.Text = TTip3(i).GetToolTipText()
								bBodyFound = True
								Exit For
							End If
						End If
					Next i
				End If
				If Not bBodyFound Then
					lblBodyName.Text = ""
				End If
				
			End If
		Else 'for Horizon View
			'If (MouseX < -3500 Or MouseX > 2980 Or MouseY < -2000 Or MouseY > 2500) Or View = False Then
			
			If (MouseX < 115 Or MouseX > 547 Or MouseY < 316 Or MouseY > 532) Or View = False Then
				'If MouseX < -1000 Then
				Cursor = System.Windows.Forms.Cursors.Default
				lblAlt.Text = ""
				lblAz.Text = ""
				lblBodyName.Text = ""
			Else
				'UPGRADE_ISSUE: Form property Form2.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
				Cursor = vbCustom
				lblAlt.Text = CStr(System.Math.Round((532 - MouseY) / 2.4))
				lblAz.Text = CStr(System.Math.Round((MouseX - 115) / 2.4) + ShiftAz)
				If Val(lblAz.Text) >= 360 Then lblAz.Text = CStr(Val(lblAz.Text) - 360)
				If Val(lblAz.Text) < 0 Then lblAz.Text = CStr(Val(lblAz.Text) + 360)
				bBodyFound = False
				For i = 0 To UBound(TTip1, 1)
					If Not TTip1(i) Is Nothing Then
						If TTip1(i).PointInBounds(MouseX, MouseY) Then
							lblBodyName.Text = TTip1(i).GetToolTipText()
							bBodyFound = True
						End If
					End If
				Next i
				If Not bBodyFound Then
					For i = 0 To UBound(TTip2, 1)
						If Not TTip2(i) Is Nothing Then
							If TTip2(i).PointInBounds(MouseX, MouseY) Then
								lblBodyName.Text = TTip2(i).GetToolTipText()
								bBodyFound = True
								Exit For
							End If
						End If
					Next i
				End If
				If Not bBodyFound Then
					For i = 0 To UBound(TTip3, 1)
						If Not TTip3(i) Is Nothing Then
							If TTip3(i).PointInBounds(MouseX, MouseY) Then
								lblBodyName.Text = TTip3(i).GetToolTipText()
								bBodyFound = True
								Exit For
							End If
						End If
					Next i
				End If
				If Not bBodyFound Then
					lblBodyName.Text = ""
				End If
				'Debug.Print MouseX, MouseY
			End If
		End If
	End Sub
	
	
	'UPGRADE_WARNING: Event txtMinimumAltitude.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMinimumAltitude_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinimumAltitude.TextChanged
		'txtMinimumAltitude.ForeColor = &H80000008
		txtMinimumAltitude.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtMinimumAltitude.Text) > 90 Then 'Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
			txtMinimumAltitude.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	Private Sub txtMinimumAltitude_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMinimumAltitude.KeyPress
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
	
	Private Sub txtMinimumAltitude_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMinimumAltitude.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMinimumAltitude.Text) > 90 Then 'Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
			KeepFocus = True
			If txtMinimumAltitude.Text = "" Then KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMinimumAltitude_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinimumAltitude.Enter
		SelectAllText(txtMinimumAltitude)
	End Sub
	
	'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime.Text) = 4 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59) Then
			txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
			Exit Sub
		End If
		If Len(txtTime.Text) < 4 And txtTime.Text <> "" Then txtWarning.Visible = False Else Warning() 'txtWarning.Visible = True
	End Sub
	
	Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
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
	
	Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Len(txtTime.Text) <> 4 Then
			KeepFocus = True
			If txtTime.Text = "" Then KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
		SelectAllText(txtTime)
	End Sub
	
	'UPGRADE_WARNING: Event txtYear.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.TextChanged
		'txtYear.ForeColor = &H80000008
		txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
			txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		CheckDate()
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
	
	Private Sub txtYear_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtYear.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.Enter
		SelectAllText(txtYear)
	End Sub
	
	'UPGRADE_WARNING: Event txtLDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
		If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
		If Val(txtLDeg.Text) = 90 Then txtLMin.Text = "" : txtLMin.Enabled = False : txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLDeg.ForeColor = &H80000008
		txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'    If Val(txtLDeg.text) > 90 Or (Val(txtLDeg.text) = 90 And Val(txtLMin.text) <> 0) Then
		'        txtLDeg.BackColor = &HFF&
		'        MsgBox "Out of Range"
		'    End If
		If Val(txtLDeg.Text) > 90 Then
			txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLDeg.Text) < 90 Then
			'txtLMin.ForeColor = &H80000008
			txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLMin.Text = "  "
		End If
		
	End Sub
	
	Private Sub txtLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLDeg.KeyPress
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
	
	Private Sub txtLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLDeg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.Enter
		SelectAllText(txtLDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtLMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.TextChanged
		'txtLMin.ForeColor = &H80000008
		txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLMin.Text) > 59.9 Then
			txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLMin.Text, ".") Then
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
	
	Private Sub txtLMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.Enter
		SelectAllText(txtLMin)
	End Sub
	
	'UPGRADE_WARNING: Event txtLoDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
		If Val(txtLoDeg.Text) <> 180 Then txtLoMin.Enabled = True
		If Val(txtLoDeg.Text) = 180 Then txtLoMin.Text = "" : txtLoMin.Enabled = False : txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLoDeg.ForeColor = &H80000008
		txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
			txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLoDeg.Text) < 180 Then
			'txtLoMin.ForeColor = &H80000008
			txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLoMin.Text = "    "
		End If
		AutoZDCalc()
	End Sub
	
	Private Sub txtLoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoDeg.KeyPress
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
	
	Private Sub txtLoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLoDeg.Text) > 180 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.Enter
		SelectAllText(txtLoDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtLoMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.TextChanged
		'txtLoMin.ForeColor = &H80000008
		txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLoMin.Text) > 59.9 Then
			txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		AutoZDCalc()
	End Sub
	
	Private Sub txtLoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLoMin.Text, ".") Then
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
	
	Private Sub txtLoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLoMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.Enter
		SelectAllText(txtLoMin)
	End Sub
	
	Public Function Twilights() As Object
		j = -1 : T0 = 6 'J=-1 am phenomena; T0 is 0600 (6AM) for initial estimate
		H = -18 'am astronomical twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(1) = C30
		H = -12 'am nautical twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(2) = C30
		H = -6 'am civil twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(3) = C30
		H = -0.833 'sunrise
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(4) = C30
		
		ZTinSeconds = 3600 * N1 + 60 * C2 'these lines added for azimuth of sunrise
		SRSSAz()
		'ZNSR$ = Right$(Str$(1000 + Int(ZN + 0.5)), 3)
		ZNSR = ZN
		
		H = -0.7 'center of sun on visible horizon
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(9) = C30
		ZTinSeconds = 3600 * N1 + 60 * C2
		SRSSAz()
		'    If ZN1 - Int(ZN1) <> 0 Then ZNAmpSR$ = Right$(Str$(1000 + ZN1), 5)
		'    If ZN1 - Int(ZN1) = 0 Then ZNAmpSR$ = Right$(Str$(1000 + ZN1), 3) & ".0"
		ZNAmpSR = ZN1
		
		j = 1 : T0 = 18 'J=1 pm phenomena; T0 is 1800 (6PM) for initial estimate
		H = -0.833 'sunset
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(5) = C30
		
		ZTinSeconds = 3600 * N1 + 60 * C2 'these lines added for azimuth of sunset
		SRSSAz()
		'ZNSS$ = Right$(Str$(1000 + Int(ZN + 0.5)), 3)
		ZNSS = ZN
		
		H = -0.7 'center of sun on visible horizon
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(10). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(10) = C30
		ZTinSeconds = 3600 * N1 + 60 * C2
		SRSSAz()
		'    If ZN1 - Int(ZN1) <> 0 Then ZNAmpSS$ = Right$(Str$(1000 + ZN1), 5)
		'    If ZN1 - Int(ZN1) = 0 Then ZNAmpSS$ = Right$(Str$(1000 + ZN1), 3) & ".0"
		ZNAmpSS = ZN1
		
		H = -6 'pm civil twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(6) = C30
		H = -12 'pm nautical twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(7) = C30
		H = -18 'pm astronomical twilight
		Times()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C3(8) = C30
		'If chkDST.Value = 1 Then
		'    For i = 1 To 8
		'        C3(i) = C3(i) + 100 'must make 4 digits (leading zero if required)
		'    Next i
		'End If
		'CHEAT FOR PHENOMENA THAT SHOULD NOT OCCUR
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(1) = C3(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(2) = C3(2)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(3) = C3(3)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(4) = C3(4)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(5) = C3(5)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(6) = C3(6)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(7) = C3(7)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(8) = C3(8)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(9) = C3(9)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(10). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(10). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		D3(10) = C3(10)
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(1) = D3(2) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(1) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(2) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(2) = D3(3) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(2) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(3) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(3) = D3(4) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(3) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(4) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(8) = D3(7) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(8) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(7) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(7) = D3(6) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(7) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(6) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(6) = D3(5) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(6) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(5) = "----"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object D3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If D3(1) = D3(8) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(1) = "----"
			'UPGRADE_WARNING: Couldn't resolve default property of object C3(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			C3(8) = "----"
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If C3(4) = "----" Then C3(9) = "----" 'these two lines assume if there is no sunrise or sunset there is no corresponding amplitude
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(10). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If C3(5) = "----" Then C3(10) = "----"
	End Function
	Public Function SRSSAz() As Object
		Greenwich()
		Delta_T()
		Julian()
		Obliquity()
		Nutation()
		Aries()
		NY = (JD - 2451545!) / 365.2425
		Sun()
		GHADec()
		AltAz()
	End Function
	Public Function Times() As Object
		IC = 0
Line2202: 
		If IC = 4 Then C30 = "----" : Exit Function 'V1.0.5 had IC = 3
		ZTinSeconds = T0 * 3600
		Greenwich()
		Delta_T()
		Julian()
		Nutation()
		Obliquity()
		Aries()
		Sun()
		CT = (System.Math.Sin(H * Pi / 180) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(DE * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(DE * Pi / 180))
		If CT >= 1 Then TA = 0 : GoTo Line2250
		If CT <= -1 Then TA = 180 : GoTo Line2250
		TA = -System.Math.Atan(CT / System.Math.Sqrt(-CT * CT + 1)) + Pi / 2 : TA = TA * 180 / Pi
Line2250: 
		T1 = T0 + ZD + (j * TA + Lo - GR + AR) / 15
		
		If T1 >= (24 + 2 * 0.008000001) Or T1 < 0 Then T1 = T1 - Int(T1 / 24) * 24 'THIS WAS ORIGINALLY 24, THEN CHANGED TO 25, BUT THAT CAUSED THE PROBLEM FIXED IN V3.4.1, FIXED BY CHANGING BACK TO 24 - NO - FIXED(?) BY MAKING IT (24 + 2*0.008000001)
		If System.Math.Abs(T1 - T0) > 0.008000001 Then T0 = T1 : IC = IC + 1 : GoTo Line2202
		
		V = T1 - ZD
		If V < 0 Then V = V + 24
		If V >= 24 Then V = V - 24
		N1 = Int(V)
		C2 = (V - Int(V)) * 60
		C2 = Int(C2 + 0.5)
		If C2 = 60 Then C2 = 0 : N1 = N1 + 1
		N2 = Mid(NT, 2 * N1 + 1, 2)
		X3 = Mid(NT, 2 * C2 + 1, 2)
		C30 = N2 & X3
		'If ((Val(N2$) - (AutoZD - ZD)) * 60 + Val(X3$)) >= 2344 Or ((Val(N2$) - (AutoZD - ZD)) * 60 + Val(X3$)) <= 26 Then C30$ = "----" 'THIS IS A CHEAT FOR HIGH LATITUDES
	End Function
	
	Public Function Aries() As Object
		HG = UTinSeconds / 3600 : TP = (JD - 2451545! - HG / 24) / 36525!
		GR = 6.69737456 + 0.000000000000004 + (2400.051336 * TP)
		GR = GR + (0.0000258622 * TP * TP) + (1.002737909 * HG)
		GR = GR * 15 '  convert hours to degrees
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If GRM(IB) = 60 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GRM(IB) = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object GRD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GRD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GRD(IB) = GRD(IB) + 1
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object GRD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If GRD(IB) = 360 Then GRD(IB) = 0
		GR = GR + NL
		If GR >= 360 Or GR < 0 Then GR = GR - Int(GR / 360) * 360
		LR = GR - Lo
		If LR >= 360 Then LR = LR - 360
		If LR < 0 Then LR = LR + 360
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VM(IB) = 60 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VM(IB) = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object VD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VD(IB) = VD(IB) + 1
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VD(IB) = 360 Then VD(IB) = 0
		WD = Int(GR) : WM = (GR - WD) * 60 : WM = Int(WM * 10 + 0.5) / 10 : If WM = 60 Then WM = 0 : WD = WD + 1
		If WD = 360 Then WD = 0
		QD = Int(LR) : QM = (LR - QD) * 60 : QM = Int(QM * 10 + 0.5) / 10 : If QM = 60 Then QM = 0 : QD = QD + 1
		If QD = 360 Then QD = 0
	End Function
	
	'UPGRADE_WARNING: Event cboLo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
		If optZDAuto.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		AutoZDCalc()
	End Sub
	
	'UPGRADE_WARNING: Event optZDAuto.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optZDAuto_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDAuto.CheckedChanged
		If eventSender.Checked Then
			If optZDAuto.Checked = True Then
				txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
				txtZDh.Enabled = False
				lblZDh.Visible = False
				cboZDm.Visible = False
				'cboZDm.Enabled = False
				chkDST.Visible = True
				lblZDDST.Visible = True
				lblZDm.Visible = False
				cboZDm.SelectedIndex = 0 '"00"
				AutoZDCalc()
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optZDManual.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optZDManual_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDManual.CheckedChanged
		If eventSender.Checked Then
			If optZDManual.Checked = True Then
				txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
				txtZDh.Enabled = True
				lblZDh.Visible = True
				cboZDm.Visible = True
				chkDST.Visible = True
				lblZDDST.Visible = True
				'cboZDm.Enabled = True
				lblZDm.Visible = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optZDUT.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optZDUT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDUT.CheckedChanged
		If eventSender.Checked Then
			If optZDUT.Checked = True Then
				txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
				txtZDh.Enabled = False
				lblZDh.Visible = False
				cboZDm.Visible = False
				'cboZDm.Enabled = True
				lblZDm.Visible = False
				chkDST.Visible = False
				lblZDDST.Visible = False
				chkDST.CheckState = System.Windows.Forms.CheckState.Unchecked
				txtZDh.Text = "0"
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtZDh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
		'    'txtZDh.ForeColor = &H80000008
		'    If optZDManual = True And (Val(txtZDh.text) < -13 Or Val(txtZDh.text) > 12) Then
		'        txtZDh.BackColor = &HFF&
		'        MsgBox "Out of Range"
		'    End If
		'txtZDh.ForeColor = &H80000008
		If optZDAuto.Checked = True Or optZDUT.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		If optZDManual.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If optZDManual.Checked = True And (Val(txtZDh.Text) < -13 Or Val(txtZDh.Text) > 12) Then
			txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	Private Sub txtZDh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh.KeyPress
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
				If txtZDh.SelectionStart <> 0 Or bMinusSignAlready Then
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
				
				If txtZDh.SelectionStart <> 0 Or bPlusSignAlready Then
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
	
	Private Sub txtZDh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtZDh.Text) < -13 Or Val(txtZDh.Text) > 12 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtZDh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.Enter
		SelectAllText(txtZDh)
	End Sub
	
	Public Function AutoZDCalc() As Object
		If optZDAuto.Checked = True Then
			txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
			ZD = Int(Lo / 15 + 0.5) 'ZD = Round(Lo / 15)
			If cboLo.Text = "E " Then ZD = -ZD
			AutoZD = ZD
			SignZD = "+" : If cboLo.Text = "E " Then SignZD = "-"
			txtZDh.Text = SignZD & System.Math.Abs(ZD)
		End If
	End Function
	
	Public Sub DisplayTwilights()
		'Scale
		'txtTime.Text = ""
		'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		Shape1.Visible = False
		lblAltitude.Visible = False
		lblAzimuth.Visible = False
		lblAz.Visible = False
		lblAlt.Visible = False
		Label5.Visible = False
		Label7.Visible = False
		lblN.Visible = False
		lblE.Visible = False
		lblS.Visible = False
		lblW.Visible = False
		lblBody.Visible = False
		lblBodyName.Visible = False
		'lblN2.Visible = False
		'lblOverhead.Visible = False
		chkFirst.Visible = False
		chkSecond.Visible = False
		chkThird.Visible = False
		chkNames.Visible = False
		chkLimit.Visible = False
		'If (chkFirst.Value = 1 And chkSecond.Value = 1 And chkThird.Value = 1) Then chkHelper.Visible = True
		chkHelper.Visible = False
		FrameView.Visible = False
		'optOverhead.Visible = False
		'optStarFinder.Visible = False
		'optHorizon.Visible = False
		FrameDirection.Visible = False
		'optN.Visible = False
		'optS.Visible = False
		'optE.Visible = False
		'optW.Visible = False
		FrameBest.Visible = False
		'optOff.Visible = False
		'optTwo.Visible = False
		'optThreeBoat.Visible = False
		'optThreeBeach.Visible = False
		'cmdCCW.Visible = False
		'cmdCCW.Enabled = False
		'cmdCW.Visible = False
		'cmdCW.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Arial")
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 1100
		Me.Font = VB6.FontChangeBold(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(19), "Sun Rising and Setting Phenomena and Moon Data for " & cboDay.Text, SPC(1), cboMonth.Text, SPC(1), txtYear.Text & " at L " & VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(LMin), "00.0") & "'" & cboL.Text & ", Lo " & VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(LoMin), "00.0") & "'" & cboLo.Text)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Morning Phenomena", TAB(41), "Approx. ZT", TAB(80), "Evening Phenomena", TAB(121), "Approx. ZT")
		Me.Font = VB6.FontChangeBold(Me.Font, False)
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Start of AM Astronomical Twilight", TAB(44), C3(1), TAB(80), "Sunset", TAB(124), C3(5))
		'    If (C3(5) <> "----" And optLimb = True) Then Print " (Zn "; ZNSS$; "º)" 'Else Print
		'    If (C3(5) <> "----" And optCenter = True) Then Print " (Zn "; ZNAmpSS$; "º)" 'Else Print
		
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (C3(5) <> "----" And optLimb.Checked = True) Then Print(" (Zn " & VB6.Format(ZNSS, "000.0") & "º)") 'Else Print    'was "000" before V5.1.5
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (C3(5) <> "----" And optCenter.Checked = True) Then Print(" (Zn " & VB6.Format(ZNAmpSS, "000.0") & "º)") 'Else Print
		
		'    If C3(5) <> "----" Then Print " (Zn "; Format(ZNSS, "000.0"); "º)"   'Else Print
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If C3(5) = "----" Then Print()
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Start of AM Nautical Twilight", TAB(44), C3(2), TAB(80), "End of PM Civil Twilight", TAB(124), C3(6))
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Start of AM Civil Twilight", TAB(44), C3(3), TAB(80), "End of PM Nautical Twilight", TAB(124), C3(7))
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Sunrise", TAB(44), C3(4))
		'    If (C3(4) <> "----" And optLimb = True) Then Print " (Zn "; ZNSR$; "º)";
		'    If (C3(4) <> "----" And optCenter = True) Then Print " (Zn "; ZNAmpSR$; "º)";
		
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (C3(4) <> "----" And optLimb.Checked = True) Then Print(" (Zn " & VB6.Format(ZNSR, "000.0") & "º)") 'was "000" before V5.1.5
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (C3(4) <> "----" And optCenter.Checked = True) Then Print(" (Zn " & VB6.Format(ZNAmpSR, "000.0") & "º)")
		
		'    If C3(4) <> "----" Then Print " (Zn "; Format(ZNAmpSR, "000.0"); "º)";
		
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(80), "End of PM Astronomical Twilight", TAB(124), C3(8))
		'Print "Sunset"; Tab(44); C3(5)
		'Print "End of PM Civil Twilight"; Tab(44); C3(6)
		'Print "End of PM Nautical Twilight"; Tab(44); C3(7)
		'Print "End of PM Astronomical Twilight"; Tab(44); C3(8)
		'If IH = 2 Then Print #2,: Print #2,: IH = 1: GoTo 3100
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 4200
		lblEnterTime.Visible = True
		lblEnterTime.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
		txtTime.Visible = True
		'txtTime.Enabled = True
		txtTime.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
		FrameDisplay.Visible = True
		FrameDisplay.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
		CmdVisible.Visible = True
		'CmdVisible.Enabled = True
		cmdData.Visible = True
		'cmdData.Enabled = True
		lblMinimumAltitude.Visible = True
		txtMinimumAltitude.Visible = True
		lblAltDeg.Visible = True
		'txtTime.Text = ""
	End Sub
	
	Public Sub LatLong()
		'Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
		LMin = Replace(txtLMin.Text, ",", ".")
		LoMin = Replace(txtLoMin.Text, ",", ".")
		Lat = Val(txtLDeg.Text) + Val(LMin) / 60
		If Lat = 90 Then Lat = 89.999999999
		If cboL.Text = "S " Then Lat = -Lat
		Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
		If cboLo.Text = "E " Then Lo = -Lo
	End Sub
	Public Function Greenwich() As Object
		'Prefix (or suffix) G for Greenwich, UT = Universal Time
		Dim DayG(12) As Short
		MonthDays = "312831303130313130313031"
		'Check for local leap year
		LocalYear = Val(txtYear.Text)
		If (LocalYear Mod 4) = 0 Then LeapYear = True
		If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then LeapYear = False
		'If LeapYear = True Then MonthDays$ = "312931303130313130313031"
		MonthNumber = cboMonth.SelectedIndex + 1
		DayNumber = 0
		For i = 1 To MonthNumber - 1
			DayNumber = Val(Mid(MonthDays, 2 * i - 1, 2)) + DayNumber
		Next i
		If MonthNumber >= 3 And LeapYear = True Then DayNumber = DayNumber + 1
		DayNumber = DayNumber + Val(cboDay.Text)
		ZD = System.Math.Abs(Val(txtZDh.Text))
		If optZDManual.Checked = True Then ZD = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
		'If Val(txtZDh.Text) < 0 Then ZD = -ZD
		If VB.Left(txtZDh.Text, 1) = "-" Then ZD = -ZD
		'''''If Sgn(Val(txtZDh.Text)) = -1 Then ZD = -ZD
		If chkDST.CheckState = 1 And MoonFlag = False Then ZD = ZD - 1
		ZDinSeconds = 3600 * ZD
		UTinSeconds = ZTinSeconds + ZDinSeconds
		GHour = Int(UTinSeconds / 3600)
		GMinute = Int((UTinSeconds - CInt(GHour) * 3600) / 60)
		GSecond = UTinSeconds - CInt(GHour) * 3600 - GMinute * 60
		GYear = Val(txtYear.Text) : GDayOfYear = DayNumber
		If GHour >= 24 Then GHour = GHour - 24 : GDayOfYear = GDayOfYear + 1
		If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then GDayOfYear = 1 : GYear = GYear + 1 : GoTo GreenwichDate
		If GHour < 0 Then GHour = GHour + 24 : GDayOfYear = GDayOfYear - 1
		If GDayOfYear = 0 Then GYear = GYear - 1
		'Check for leap year at Greenwich
		If (GYear Mod 4) = 0 Then GLeapYear = True
		If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then GLeapYear = False
		'Days in year
		If GDayOfYear = 0 And GLeapYear = False Then GDayOfYear = 365
		If GDayOfYear = 0 And GLeapYear = True Then GDayOfYear = 366
		
GreenwichDate: 
		DayG(0) = GDayOfYear
		If GLeapYear = True Then MonthDays = "312931303130313130313031"
		For i = 1 To 12
			DayG(i) = DayG(i - 1) - Val(Mid(MonthDays, 2 * i - 1, 2))
			If DayG(i) <= 0 Then GMonth = i : GDay = DayG(i - 1) : GoTo GetMonth
		Next i
GetMonth: 
		'MonthList$ = "JanFebMarAprMayJunJulAugSepOctNovDec"
		MonthatG = Mid(MonthList, 3 * GMonth - 2, 3)
	End Function
	
	Public Function Julian() As Object
		DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400!)
		GYearJ = GYear
		If GMonth < 3 Then GYearJ = GYear - 1 : GMonth = GMonth + 12
		JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
		If BN = 58 Then T = (JD - 2451545) / 36525! Else 
		T = (JD - 2451545 + DeltaT / 86400) / 36525!
	End Function
	
	Public Function Obliquity() As Object
		'Obliquity of the ecliptic
		OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
		OE = OE / 3600 'degrees
		OETrue = OE + NO 'degrees
	End Function
	
	Public Function Nutation() As Object
		'Nutation
		NL = 0 : NO = 0
		
		NutD = 297.85036 + 445267.11148 * T - 0.0019142 * T * T + T * T * T / 189474 'mean elongation of moon from sun, degrees
		If NutD >= 360 Or NutD < 0 Then NutD = NutD - Int(NutD / 360) * 360
		NutD = NutD * Pi / 180 'radians
		
		NutM = 357.52772 + 35999.05034 * T - 0.0001603 * T * T - T * T * T / 300000 'mean anomaly of the sun (Earth), degrees
		If NutM >= 360 Or NutM < 0 Then NutM = NutM - Int(NutM / 360) * 360
		NutM = NutM * Pi / 180 'radians
		
		NutMprime = 134.96298 + 477198.867398 * T + 0.0086972 * T * T + T * T * T / 56250 'mean anomaly of the moon, degrees
		If NutMprime >= 360 Or NutMprime < 0 Then NutMprime = NutMprime - Int(NutMprime / 360) * 360
		NutMprime = NutMprime * Pi / 180 'radians
		
		NutF = 93.27191 + 483202.017538 * T - 0.0036825 * T * T + T * T * T / 327270 'moon's argument of latitude, degrees
		If NutF >= 360 Or NutF < 0 Then NutF = NutF - Int(NutF / 360) * 360
		NutF = NutF * Pi / 180 'radians
		
		NutOmega = 125.04452 - 1934.136261 * T + 0.0020708 * T * T + T * T * T / 450000 'longitude of ascending node of moon..., degrees
		If NutOmega >= 360 Or NutOmega < 0 Then NutOmega = NutOmega - Int(NutOmega / 360) * 360
		NutOmega = NutOmega * Pi / 180 'radians
		
		For i = 0 To 62
			'UPGRADE_WARNING: Couldn't resolve default property of object NOmega(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NF(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NMprime(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NM(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ND(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NSinT(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NSin(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			NL = NL + (NSin(i) + NSinT(i) * T) * System.Math.Sin(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
			'UPGRADE_WARNING: Couldn't resolve default property of object NOmega(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NF(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NMprime(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NM(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ND(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NCosT(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object NCos(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			NO = NO + (NCos(i) + NCosT(i) * T) * System.Math.Cos(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
		Next i
		NL = (NL / 10000) / 3600 'degrees
		NO = (NO / 10000) / 3600 'degrees
	End Function
	Public Sub Sun()
		Ecc = 0.016708634 - 0.000042037 * T - 0.0000001267 * T * T 'Ecc of Earth's orbit oO0
		MS = 357.52911 + 35999.05029 * T - 0.0001537 * T * T 'mean anomaly of Sun, degrees
		'MS=357.52772 + 35999.05034 * T + 0.0001603 * T * T +T*T*T/30000                   'mean anomaly of Sun, degrees
		If MS >= 360 Or MS < 0 Then MS = MS - Int(MS / 360) * 360
		C = (1.914602 - 0.004817 * T - 0.000014 * T * T) * System.Math.Sin(MS * Pi / 180) + (0.019993 - 0.000101 * T) * System.Math.Sin(2 * MS * Pi / 180) + 0.000289 * System.Math.Sin(3 * MS * Pi / 180) 'center of Sun, degrees
		NU = MS + C 'Sun's true anomaly, degrees
		RN = (1.000001018 * (1 - Ecc * Ecc)) / (1 + Ecc * System.Math.Cos(NU * Pi / 180)) 'Sun's radius vector (distance between centers of Sun and Earth), astronomical units
		L0 = 280.46646 + 36000.76983 * T + 0.0003032 * T * T 'geometric mean longitude of Sun, degrees
		If L0 >= 360 Or L0 < 0 Then L0 = L0 - Int(L0 / 360) * 360
		'L0 = L0 + NL - 0.005691611 / RN     'add effects of nutation and Aberration
		'If L0 >= 360 Or L0 < 0 Then L0 = L0 - Int(L0 / 360) * 360
		LN = L0 + C 'Sun's true longitude, degrees
		If TwilightFlag = False And BN <> 58 Then Exit Sub 'do not go further if not twilights and not sun sight
		If TwilightFlag = True And (BN >= 60 And BN <= 63) Then Exit Sub 'do not go further if twilights and planets
		If BodiesFlag = True And TwilightFlag = True And BN <= 57 Then Exit Sub 'want this line only for list, not for twilights
		
		T = T / 10
		' Compute heliocentric, ecliptical Longitude L in radians
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		LH = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
		If System.Math.Abs(LH) > (2 * Pi) Then LH = LH - 2 * Pi * Int(LH / 2 / Pi)
		' Compute heliocentric, ecliptical Latitude B in radians
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
		' Compute heliocentric distance r in AU
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		r = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)
		
		L1 = LH + Pi 'geocentric longitude, radians
		B = -B 'geocentric latitude, radians
		
		''Convert to FK5 system
		'    TFK5 = 10 * T
		'    Lprime = L * 180 / Pi - 1.397 * TFK5 - 0.00031 * TFK5 * TFK5    'degrees
		'    Lprime = Lprime * Pi / 180  'radians
		'    L = L * 180 / Pi - 0.09033 / 3600 + 0.03916 * (Cos(Lprime) + Sin(Lprime)) * Tan(B) / 3600'degrees
		'    B = B * 180 / Pi + 0.03916 * (Cos(Lprime) - Sin(Lprime)) / 3600 'degrees
		
		L1 = L1 * 180 / Pi 'geocentric longitude, degrees
		'add nutation to get apparent positions
		L1 = L1 + NL 'degrees
		'add aberration
		L1 = L1 - (20.4898 / 3600) / r 'apparent longitude, degrees
		'back to radians
		L1 = L1 * Pi / 180
		
		
		'If BN >= 60 And BN <= 63 Then        'planets
		EclipticToEquatorial()
		AR = AR * 180 / Pi 'for Meeus ecl-to-eq
		DE = DE * 180 / Pi 'for Meeus ecl-to-eq
		'End If
		
		'DI = Atn(0.00465424336 / RN) * 180 / Pi * 60
		'DI = (959.63 / RN) / 60        'Meeus
		'back to normal T
		T = 10 * T
	End Sub
	
	Public Function EclipticToEquatorial() As Object
		AR = System.Math.Atan((System.Math.Sin(L1) * System.Math.Cos(OETrue * Pi / 180) - System.Math.Tan(B) * System.Math.Sin(OETrue * Pi / 180)) / System.Math.Cos(L1)) 'radians
		If System.Math.Cos(L1) < 0 Then AR = AR + Pi
		If AR >= 2 * Pi Then AR = AR - 2 * Pi
		If AR < 0 Then AR = AR + 2 * Pi
		x = System.Math.Sin(B) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Cos(B) * System.Math.Sin(OETrue * Pi / 180) * System.Math.Sin(L1)
		DE = System.Math.Atan(x / (System.Math.Sqrt(-x * x + 1) + 9.999999E-21)) 'arcsin, radians
		'AR = AR * 180 / Pi
		'DE = DE * 180 / Pi
	End Function
	
	Public Function SolarSystem() As Object
		I1 = 0
		'PlanOrbEl
		For BN = 58 To 63
			If BN = 58 Then
				Sun()
				'UPGRADE_WARNING: Couldn't resolve default property of object Mag(58). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Mag(58) = "-26.8" : GoTo Line2406
			End If 'sun
			If BN = 59 Then
				Moon() : MoonPhase()
				'UPGRADE_WARNING: Couldn't resolve default property of object Mag(59). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Mag(59) = KK & "% ill." : GoTo Line2406
			End If 'moon
			Planets() 'planets
			PlanetMags()
Line2406: 
			IB = BN - 57 : GHADec()
			'IB = BN: GHADec
			AltAz()
			If Ho > 0 Then First()
		Next BN
	End Function
	
	Public Function Moon() As Object
		'T = (JD - 2451545) / 36525
		MLprime = 218.3164477 + 481267.88123421 * T - 0.0015786 * T * T + T * T * T / 538841 - T * T * T * T / 65194000 'Moon's mean longitude, degrees
		If MLprime >= 360 Or MLprime < 0 Then MLprime = MLprime - Int(MLprime / 360) * 360
		MLprime = MLprime * Pi / 180
		MD = 297.8501921 + 445267.1114034 * T - 0.0018819 * T * T + T * T * T / 545868 - T * T * T * T / 113065000 'Moon'smean elongation, degrees
		If MD >= 360 Or MD < 0 Then MD = MD - Int(MD / 360) * 360
		MD = MD * Pi / 180 'radians
		MM = 357.5291092 + 35999.0502909 * T - 0.0001536 * T * T + T * T * T / 24490000 'Sun's mean anomaly, degrees
		If MM >= 360 Or MM < 0 Then MM = MM - Int(MM / 360) * 360
		MM = MM * Pi / 180 'radians
		MMprime = 134.9633964 + 477198.8675055 * T + 0.0087414 * T * T + T * T * T / 69699 - T * T * T * T / 14712000 'Moon's mean anomaly, degrees
		If MMprime >= 360 Or MMprime < 0 Then MMprime = MMprime - Int(MMprime / 360) * 360
		MMprime = MMprime * Pi / 180 'radians
		MF = 93.272095 + 483202.0175233 * T - 0.0036539 * T * T - T * T * T / 3526000 + T * T * T * T / 863310000 'Moon's argument of altitude, degrees
		If MF >= 360 Or MF < 0 Then MF = MF - Int(MF / 360) * 360
		MF = MF * Pi / 180 'radians
		A1 = 119.75 + 131.849 * T 'degrees
		If A1 >= 360 Or A1 < 0 Then A1 = A1 - Int(A1 / 360) * 360
		A1 = A1 * Pi / 180 'radians
		A2 = 53.09 + 479264.29 * T 'degrees
		If A2 >= 360 Or A2 < 0 Then A2 = A2 - Int(A2 / 360) * 360
		A2 = A2 * Pi / 180 'radians
		A3 = 313.45 + 481266.484 * T 'degrees
		If A3 >= 360 Or A3 < 0 Then A3 = A3 - Int(A3 / 360) * 360
		A3 = A3 * Pi / 180 'radians
		E = 1 - 0.002516 * T - 0.0000074 * T * T
		SigmaL = 0 : SigmaR = 0 : SigmaB = 0
		For i = 0 To 59
			KA = 1 : KB = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object MMA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MMA(i) = 1 Or MMA(i) = -1 Then KA = E
			'UPGRADE_WARNING: Couldn't resolve default property of object MMB(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MMB(i) = 1 Or MMB(i) = -1 Then KB = E
			'UPGRADE_WARNING: Couldn't resolve default property of object MMA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MMA(i) = 2 Or MMA(i) = -2 Then KA = E * E
			'UPGRADE_WARNING: Couldn't resolve default property of object MMB(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MMB(i) = 2 Or MMB(i) = -2 Then KB = E * E
			'UPGRADE_WARNING: Couldn't resolve default property of object MFA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMprimeA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MDA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MSinA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SigmaL = SigmaL + KA * MSinA(i) * System.Math.Sin(MDA(i) * MD + MMA(i) * MM + MMprimeA(i) * MMprime + MFA(i) * MF)
			'UPGRADE_WARNING: Couldn't resolve default property of object MFA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMprimeA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MDA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MCosA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SigmaR = SigmaR + KA * MCosA(i) * System.Math.Cos(MDA(i) * MD + MMA(i) * MM + MMprimeA(i) * MMprime + MFA(i) * MF)
			'UPGRADE_WARNING: Couldn't resolve default property of object MFB(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMprimeB(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MMB(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MDB(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MSinB(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SigmaB = SigmaB + KB * MSinB(i) * System.Math.Sin(MDB(i) * MD + MMB(i) * MM + MMprimeB(i) * MMprime + MFB(i) * MF)
		Next i
		SigmaL = SigmaL + 3958 * System.Math.Sin(A1) + 1962 * System.Math.Sin(MLprime - MF) + 318 * System.Math.Sin(A2)
		SigmaB = SigmaB - 2235 * System.Math.Sin(MLprime) + 382 * System.Math.Sin(A3) + 175 * System.Math.Sin(A1 - MF) + 175 * System.Math.Sin(A1 + MF) + 127 * System.Math.Sin(MLprime - MMprime) - 115 * System.Math.Sin(MLprime + MMprime)
		L1 = MLprime * 180 / Pi + SigmaL / 1000000 'geocentric longitude, degrees
		B = SigmaB / 1000000 'geocentric latitude, degrees
		Delta = 385000.56 + SigmaR / 1000 'distance between centers of Earth and Moon, kilometers
		x = 6378.14 / Delta
		HP = System.Math.Atan(x / System.Math.Sqrt(-x * x + 1)) 'radians   arcsine
		HP = HP * 180 / Pi * 60 'arcminutes
		L1 = L1 + NL 'apparent longitude
		L1 = L1 * Pi / 180
		B = B * Pi / 180
		EclipticToEquatorial()
		AR = AR * 180 / Pi 'for Meeus ecl-to-eq
		DE = DE * 180 / Pi 'for Meeus ecl-to-eq
		
	End Function
	
	Public Function Planets() As Object
		'L is heliocentric, ecliptic longitude, radians
		'B is heliocentric, ecliptic latitude, radians
		'r is heliocentric distance, astronomical units
		Delta = 0 : Tau = 0
		T = T / 10
		'For BN = 60 To 63
		For i = 1 To 3
			If i > 1 Then T = (JD - 2451545 - Tau) / 365250
			If BN = 60 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				L = Venus_L01(T) + Venus_L11(T) + Venus_L21(T) + Venus_L31(T) + Venus_L41(T) + Venus_L51(T)
				If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B = Venus_B01(T) + Venus_B11(T) + Venus_B21(T) + Venus_B31(T) + Venus_B41(T) + Venus_B51(T)
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Venus_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = Venus_R01(T) + Venus_R11(T) + Venus_R21(T) + Venus_R31(T) + Venus_R41(T) + Venus_R51(T)
			End If
			If BN = 61 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L12(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L03(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				L = Mars_L01(T) + Mars_L02(T) + Mars_L03(T) + Mars_L11(T) + Mars_L12(T) + Mars_L21(T) + Mars_L31(T) + Mars_L41(T) + Mars_L51(T)
				If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B = Mars_B01(T) + Mars_B11(T) + Mars_B21(T) + Mars_B31(T) + Mars_B41(T) + Mars_B51(T)
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R12(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R03(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Mars_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = Mars_R01(T) + Mars_R02(T) + Mars_R03(T) + Mars_R11(T) + Mars_R12(T) + Mars_R21(T) + Mars_R31(T) + Mars_R41(T) + Mars_R51(T)
			End If
			If BN = 62 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				L = Jupiter_L01(T) + Jupiter_L02(T) + Jupiter_L11(T) + Jupiter_L21(T) + Jupiter_L31(T) + Jupiter_L41(T) + Jupiter_L51(T)
				If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B = Jupiter_B01(T) + Jupiter_B11(T) + Jupiter_B21(T) + Jupiter_B31(T) + Jupiter_B41(T) + Jupiter_B51(T)
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Jupiter_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = Jupiter_R01(T) + Jupiter_R02(T) + Jupiter_R11(T) + Jupiter_R21(T) + Jupiter_R31(T) + Jupiter_R41(T) + Jupiter_R51(T)
			End If
			If BN = 63 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L12(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L03(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				L = Saturn_L01(T) + Saturn_L02(T) + Saturn_L03(T) + Saturn_L11(T) + Saturn_L12(T) + Saturn_L21(T) + Saturn_L31(T) + Saturn_L41(T) + Saturn_L51(T)
				If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B = Saturn_B01(T) + Saturn_B02(T) + Saturn_B11(T) + Saturn_B21(T) + Saturn_B31(T) + Saturn_B41(T) + Saturn_B51(T)
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R12(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R03(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Saturn_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = Saturn_R01(T) + Saturn_R02(T) + Saturn_R03(T) + Saturn_R11(T) + Saturn_R12(T) + Saturn_R21(T) + Saturn_R31(T) + Saturn_R41(T) + Saturn_R51(T)
			End If
			'convert from heliocentric to geocentric coordinates
			If i = 1 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				L0 = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T)
				'L0Sun = L0
				If System.Math.Abs(L0) > (2 * Pi) Then L0 = L0 - 2 * Pi * Int(L0 / 2 / Pi)
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B0 = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T)
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r0 = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)
			End If
			x = r * System.Math.Cos(B) * System.Math.Cos(L) - r0 * System.Math.Cos(B0) * System.Math.Cos(L0)
			y = r * System.Math.Cos(B) * System.Math.Sin(L) - r0 * System.Math.Cos(B0) * System.Math.Sin(L0)
			Z = r * System.Math.Sin(B) - r0 * System.Math.Sin(B0)
			
			'Effect of light-time
			Delta = System.Math.Sqrt(x * x + y * y + Z * Z)
			Tau = 0.0057755183 * Delta
		Next i
		'geocentric longitude and latitude
		If System.Math.Abs(x) < 9.999999E-21 Then x = 9.999999E-21
		L1 = System.Math.Atan(y / x) 'geocentric longitude, radians
		If x < 0 Then L1 = L1 + Pi
		If L1 >= 2 * Pi Or L1 < 0 Then L1 = L1 - Int(L1 / (2 * Pi)) * 2 * Pi
		B = System.Math.Atan(Z / System.Math.Sqrt(x * x + y * y)) 'geocentric latitude, radians
		
		'Back to normal times
		T = T * 10
		'Apply Aberration
		Sun() 'for LN, Ecc needed in AberrationLB
		
		
		'LN = L0Sun
		AberrationLB()
		L1 = L1 + AberrL * Pi / 180 'radians
		B = B + AberrB * Pi / 180 'radians    'IS THIS LINE NEEDED????????????????????????????????????
		
		'Corrections for reduction to FK5 system would go here
		'    TFK5 = T
		'    Lprime = L1 * 180 / Pi - 1.397 * TFK5 - 0.00031 * TFK5 * TFK5    'degrees
		'    Lprime = Lprime * Pi / 180  'radians
		'    L1 = L1 * 180 / Pi - 0.09033 / 3600 + 0.03916 * (Cos(Lprime) + Sin(Lprime)) * Tan(B) / 3600 'degrees
		'    B = B * 180 / Pi + 0.03916 * (Cos(Lprime) - Sin(Lprime)) / 3600 'degrees
		
		'apply nutation in longitude and obliquity; NL and NO come in as degrees
		L1 = L1 + NL * Pi / 180 'apparent longitude
		
		xmag = x 'used in PlanetMags so x does not get changed by EclipticToEquatorial
		
		EclipticToEquatorial()
		AR = AR * 180 / Pi
		DE = DE * 180 / Pi
		
	End Function
	Private Sub PlanetMags()
		cosi = (xmag * System.Math.Cos(B) * System.Math.Cos(L) + y * System.Math.Cos(B) * System.Math.Sin(L) + Z * System.Math.Sin(B)) / Delta
		x = (-cosi * cosi + 1)
		If x <= 0 Then x = 9.999999E-21
		PhaseAngle = System.Math.Atan(-cosi / System.Math.Sqrt(x)) + Pi / 2 'phase angle, arc cosine
		PhaseAngle = PhaseAngle * 180 / Pi
		If GYear >= 1984 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 60 Then Mag(BN) = -4.4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.0009 * PhaseAngle + 0.000239 * PhaseAngle * PhaseAngle - 0.00000065 * PhaseAngle * PhaseAngle * PhaseAngle
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 61 Then Mag(BN) = -1.52 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.016 * PhaseAngle
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 62 Then Mag(BN) = -9.4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.005 * PhaseAngle
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 63 Then Mag(BN) = -8.88 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.044 * PhaseAngle - 2.6 * System.Math.Sin(17 * Pi / 180) + 1.25 * System.Math.Sin(17 * Pi / 180) * System.Math.Sin(17 * Pi / 180) 'Gross approximation
		End If
		If GYear < 1984 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 60 Then Mag(BN) = -4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.01322 * PhaseAngle - 0.0000004247 * PhaseAngle * PhaseAngle * PhaseAngle
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 61 Then Mag(BN) = -1.3 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.01486 * PhaseAngle
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 62 Then Mag(BN) = -8.93 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BN = 63 Then Mag(BN) = -8.68 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.044 * PhaseAngle - 2.6 * System.Math.Sin(17 * Pi / 180) + 1.25 * System.Math.Sin(17 * Pi / 180) * System.Math.Sin(17 * Pi / 180) 'Gross approximation
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mag(BN) = Int(Mag(BN) * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SM = System.Math.Sign(Mag(BN))
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mag(BN) = 10.01 + System.Math.Abs(Mag(BN))
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If SM = 1 Then Mag(BN) = " " & Mid(Str(Mag(BN)), 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If SM = -1 Then Mag(BN) = "-" & Mid(Str(Mag(BN)), 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If SM = 0 Then Mag(BN) = " 0.0"
		'Debug.Print Mag(60), Mag(61), Mag(62), Mag(63)
	End Sub
	Public Function GHADec() As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SH(IB) = 360 - AR
		'UPGRADE_WARNING: Couldn't resolve default property of object GA(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GA(IB) = GR - AR
		'UPGRADE_WARNING: Couldn't resolve default property of object GA(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GA(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If GA(IB) >= 360 Or GA(IB) < 0 Then GA(IB) = GA(IB) - Int(GA(IB) / 360) * 360
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SH(IB) = Int(SH(IB) * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object GRD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GRD(IB) = Int(AR)
		'UPGRADE_WARNING: Couldn't resolve default property of object GRD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GRM(IB) = (AR - GRD(IB)) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GRM(IB) = Int(GRM(IB) * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If GRM(IB) = 60 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object GRM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GRM(IB) = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object GRD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GRD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GRD(IB) = GRD(IB) + 1
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RA(IB) = Int(AR * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If DE = 0 Then HD(IB) = " "
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If DE > 0 Then HD(IB) = "N"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If DE < 0 Then HD(IB) = "S"
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DF(IB) = Int(System.Math.Abs(DE) * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VD(IB) = Int(CDbl(GA(IB)))
		'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VM(IB) = (GA(IB) - VD(IB)) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VM(IB) = Int(VM(IB) * 10 + 0.5) / 10
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VM(IB) = 60 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object VM(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VM(IB) = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object VD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VD(IB) = VD(IB) + 1
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object VD(IB). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VD(IB) = 360 Then VD(IB) = 0
	End Function
	
	Public Function AltAz() As Object
		SQ = System.Math.Sin(DE * Pi / 180) * System.Math.Sin(Lat * Pi / 180) + System.Math.Cos(DE * Pi / 180) * System.Math.Cos(Lat * Pi / 180) * System.Math.Cos((GR - Lo - AR) * Pi / 180)
		q = System.Math.Atan(SQ / (System.Math.Sqrt(-SQ * SQ + 1) + 9.999999E-21))
		If TwilightFlag = False And q < 0 Then Ho = -1 : Exit Function
		A = System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(q)
		If A < 9.999999E-21 Then A = 9.999999E-21
		CP = (System.Math.Sin(DE * Pi / 180) - (System.Math.Sin(Lat * Pi / 180) * SQ)) / A
		If CP > 1 Then CP = 1 'added in V5.4.0 to avoid Dec. 21 90ºN type of error
		If CP < -1 Then CP = -1 'added in V5.4.0 to avoid Dec. 21 90ºN type of error
		PZ = System.Math.Atan(-CP / (System.Math.Sqrt(-CP * CP + 1) + 9.999999E-21)) + Pi / 2
		If System.Math.Sin((GR - Lo - AR) * Pi / 180) > 0 Then PZ = 2 * Pi - PZ
		ZN = PZ * 180 / Pi
		Ho = q * 180 / Pi
		Ho = Int(Ho + 0.5) : ZN1 = Int(ZN * 10 + 0.5) / 10 : ZN = Int(ZN + 0.5) 'ZN = Int(ZN * 10 + 0.5) / 10 changing to this in V5.1.5 messed up azimuths
	End Function
	
	Public Function Stars1() As Object
		I2 = 0 : I3 = 0 'stars
		For BN = 0 To 57
			Stars2()
			AltAz()
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MV = Val(Mag(BN))
			If Ho > 0 And MV < 1.55 Then First()
			If Ho > 0 And MV > 1.55 And MV < 2.55 Then Second_Renamed()
			If Ho > 0 And MV > 2.55 Then Third()
		Next BN
	End Function
	
	Public Function Stars2() As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object RAStars(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AR = RAStars(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object DecStars(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DE = DecStars(BN)
		AR = AR * 15 'converts AR to degrees
		NY = (JD - 2451545!) / 365.25
		'Add Proper Motion
		'UPGRADE_WARNING: Couldn't resolve default property of object PMRA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AR = AR + PMRA(BN) * NY * 15 / 360000 ''PMRA(BN) in seconds/century - divide by 100 to get seconds/year, by 3600 to get hours, mult. by 15 to get degrees
		'UPGRADE_WARNING: Couldn't resolve default property of object PMDec(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DE = DE + PMDec(BN) * NY / 360000 'PMDec(BN) arcseconds/century - divide by 100 to get arcseconds/year, by 3600 to get degrees
		'Precession
		Precession() 'this is the rigorous method; goes in with degrees, comes back as radians
		Sun() 'for sun's (mean longitude, L0, used in Nutation, and) true longitude, LN, in degrees, and Eccentricity, both used in AberrationRADec
		Nutation() 'returns nutation in longitude (NL) and nutation in obliquity (NO), both in degrees
		Obliquity() 'returns mean obliquity of the ecliptic (OE) and true obliquity (OETrue), both in degrees
		AberrationRADec() 'returns Aberration corrections to RA and Dec, AberrRA and AberrDec, both in degrees
		OETrue = OETrue * Pi / 180 'radians
		NutRA = (System.Math.Cos(OETrue) + System.Math.Sin(OETrue) * System.Math.Sin(AR) * System.Math.Tan(DE)) * NL - (System.Math.Cos(AR) * System.Math.Tan(DE)) * NO 'nutation correction to RA, degrees
		NutDec = (System.Math.Sin(OETrue) * System.Math.Cos(AR)) * NL + System.Math.Sin(AR) * NO 'nutation correction to Dec, degrees
		AR = AR * 180 / Pi + NutRA + AberrRA 'RA corrected for nutation and Aberration, degrees
		DE = DE * 180 / Pi + NutDec + AberrDec 'Dec corrected for nutation and Aberration, degrees
	End Function
	
	Public Function Sorting() As Object
		If I1 <= 1 Then GoTo Line2720
		For i = 1 To I1 - 1 : P = i
			For IJ = i + 1 To I1
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(IJ). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z1(P) > Z1(IJ) Then P = IJ
			Next IJ
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TZ = Z1(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z1(i) = Z1(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z1(P) = TZ
			'UPGRADE_WARNING: Couldn't resolve default property of object Body1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TB = Body1(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body1(i) = Body1(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body1(P) = TB
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TM = Mag1(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag1(i) = Mag1(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag1(P) = TM
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TH = H1A(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H1A(i) = H1A(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H1A(P) = TH
		Next i
Line2720: 
		If I2 <= 1 Then GoTo Line2740
		For i = 1 To I2 - 1 : P = i
			For IJ = i + 1 To I2
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(IJ). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z2(P) > Z2(IJ) Then P = IJ
			Next IJ
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TZ = Z2(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z2(i) = Z2(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z2(P) = TZ
			'UPGRADE_WARNING: Couldn't resolve default property of object Body2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TB = Body2(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body2(i) = Body2(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body2(P) = TB
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TM = Mag2(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag2(i) = Mag2(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag2(P) = TM
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TH = H2A(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H2A(i) = H2A(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H2A(P) = TH
		Next i
Line2740: 
		If I3 <= 1 Then GoTo Line2760
		For i = 1 To I3 - 1 : P = i
			For IJ = i + 1 To I3
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(IJ). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z3(P) > Z3(IJ) Then P = IJ
			Next IJ
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TZ = Z3(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z3(i) = Z3(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z3(P) = TZ
			'UPGRADE_WARNING: Couldn't resolve default property of object Body3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TB = Body3(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body3(i) = Body3(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Body3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Body3(P) = TB
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TM = Mag3(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag3(i) = Mag3(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag3(P) = TM
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TH = H3A(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H3A(i) = H3A(P)
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(P). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			H3A(P) = TH
		Next i
Line2760: 
		For i = 1 To I1
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z1(i) = VB.Right(Str(1000 + Z1(i)), 3) : Next i
		For i = 1 To I2
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z2(i) = VB.Right(Str(1000 + Z2(i)), 3) : Next i
		For i = 1 To I3
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z3(i) = VB.Right(Str(1000 + Z3(i)), 3) : Next i
	End Function
	
	Public Sub DisplayFirst()
		'DisplayTwilights
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 3500
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		Me.Font = VB6.FontChangeUnderline(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("1st Magnitude Stars and Solar System Objects")
		If LowAz > HighAz Then HighAz = HighAz + 360
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Body", TAB(20), "Zn" & Chr(176), TAB(31), "h" & Chr(176), TAB(41), "Mag.")
		Me.Font = VB6.FontChangeUnderline(Me.Font, False)
		For i = 1 To I1
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If H1A(i) >= 15 And H1A(i) <= 75 Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z1Temp(i) = Z1(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Z1(i) < LowAz Then Z1Temp(i) = Z1(i) + 360
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H1A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz Then Print(Body1(i), TAB(20), Z1(i), TAB(33 - Len(H1A(i))), VB6.Format(H1A(i), "##"), TAB(45 - Len(Mag1(i))), Mag1(i)) ': GoTo 2608
			Me.Font = VB6.FontChangeBold(Me.Font, False)
		Next i
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 8300
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Note:  Planetary magnitudes are approximate.")
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (3450, 3500) - (3450, 8500)
	End Sub
	
	Public Sub DisplaySecond()
		'DisplayTwilights
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 3500
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		Me.Font = VB6.FontChangeUnderline(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(61), "2nd Magnitude Stars")
		If LowAz > HighAz Then HighAz = HighAz + 360
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(49), "Body", TAB(68), "Zn" & Chr(176), TAB(79), "h" & Chr(176), TAB(89), "Mag.")
		Me.Font = VB6.FontChangeUnderline(Me.Font, False)
		For i = 1 To I2
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If H2A(i) >= 15 And H2A(i) <= 75 Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z2Temp(i) = Z2(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Z2(i) < LowAz Then Z2Temp(i) = Z2(i) + 360
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H2A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz Then Print(TAB(49), Body2(i), TAB(68), Z2(i), TAB(81 - Len(H2A(i))), VB6.Format(H2A(i), "##"), TAB(89), Mag2(i)) ': GoTo 2608
			Me.Font = VB6.FontChangeBold(Me.Font, False)
		Next i
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (7000, 3500) - (7000, 8500)
	End Sub
	
	Public Sub DisplayThird()
		'DisplayTwilights
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 3500
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		Me.Font = VB6.FontChangeUnderline(Me.Font, True)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(108), "3rd Magnitude Stars")
		If LowAz > HighAz Then HighAz = HighAz + 360
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(96), "Body", TAB(115), "Zn" & Chr(176), TAB(126), "h" & Chr(176), TAB(136), "Mag.")
		Me.Font = VB6.FontChangeUnderline(Me.Font, False)
		For i = 1 To I3
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If H3A(i) >= 15 And H3A(i) <= 75 Then Me.Font = VB6.FontChangeBold(Me.Font, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Z3Temp(i) = Z3(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Z3(i) < LowAz Then Z3Temp(i) = Z3(i) + 360
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object H3A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Body3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz Then Print(TAB(96), Body3(i), TAB(115), Z3(i), TAB(128 - Len(H3A(i))), VB6.Format(H3A(i), "##"), TAB(136), Mag3(i)) ': GoTo 2608
			Me.Font = VB6.FontChangeBold(Me.Font, False)
		Next i
	End Sub
	
	Public Sub DisplayData()
		''lblAltitude.Visible = False
		''lblAzimuth.Visible = False
		''lblAz.Visible = False
		''lblAlt.Visible = False
		''Label5.Visible = False
		''Label7.Visible = False
		''lblN.Visible = False
		''lblE.Visible = False
		''lblS.Visible = False
		''lblW.Visible = False
		'lblOverhead.Visible = False
		''chkFirst.Visible = False
		''chkSecond.Visible = False
		''chkThird.Visible = False
		''chkNames.Visible = False
		''chkLimit.Visible = False
		'chkHelper.Visible = False
		'DisplayTwilights
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 3500
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Date", TAB(15), cboDay.Text, TAB(18), cboMonth.Text, TAB(23), txtYear.Text, TAB(45), "DR L", TAB(59 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(LMin), "00.0") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("ZT", TAB(15), txtTime.Text, TAB(45), "DR Lo", TAB(59 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(LoMin), "00.0") & "'" & cboLo.Text)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("ZD", TAB(11), "(")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = 1 Then Print("+")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = -1 Then Print("-")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(15), VB6.Format(System.Math.Abs(ZD), "00")) 'Format(Abs(Val(txtZDh.Text)), "00");
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optZDManual.Checked = True And cboZDm.Text <> "00" Then
			Print(cboZDm.Text)
		Else
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("UT (GMT)", TAB(15), VB6.Format(GHour, "00") & VB6.Format(GMinute, "00"))
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("G Day/Mo/Yr", TAB(14), Str(GDay), SPC(1), MonthatG & Str(GYear))
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA Aries      ", TAB(20 - Len(Str(WD))), VB6.Format(WD, "##0") & Chr(176) & VB6.Format(WM, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Lo) = 1 Then Print("DR Lo       (-)")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Lo) = -1 Then Print("DR Lo       (+)")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Lo) = 0 Then Print("DR Lo       ( )")
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(20 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(LoMin), "00.0") & "'" & cboLo.Text)
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("LHA Aries      ", TAB(20 - Len(Str(QD))), VB6.Format(QD, "##0") & Chr(176) & VB6.Format(QM, "00.0") & "' = " & VB6.Format(LR, "##0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_WARNING: Couldn't resolve default property of object VM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object VD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA Sun        ", TAB(20 - Len(Str(VD(1)))), VB6.Format(VD(1), "##0") & Chr(176) & VB6.Format(VM(1), "00.0") & "'", TAB(45), "GHA Moon       ", TAB(65 - Len(Str(VD(2)))), VB6.Format(VD(2), "##0") & Chr(176) & VB6.Format(VM(2), "00.0") & "'")
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GRM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GRD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("RA  Sun        ", TAB(20 - Len(Str(GRD(1)))), VB6.Format(GRD(1), "##0") & Chr(176) & VB6.Format(GRM(1), "00.0") & "' = " & VB6.Format(RA(1), "##0.0") & Chr(176), TAB(45), "RA  Moon       ", TAB(65 - Len(Str(GRD(2)))), VB6.Format(GRD(2), "##0") & Chr(176) & VB6.Format(GRM(2), "00.0") & "' = " & VB6.Format(RA(2), "##0.0") & Chr(176))
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Dec Sun        ", TAB(16), VB6.Format(DF(1), "0.0") & Chr(176) & HD(1), TAB(45), "Dec Moon       ", TAB(61), VB6.Format(DF(2), "0.0") & Chr(176) & HD(2))
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Planet", TAB(16), "SHA", TAB(37), "RA", TAB(53), "Dec")
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Venus", TAB(18 - Len(Int(CDbl(SH(3))))), VB6.Format(SH(3), "##0.0") & Chr(176), TAB(38 - Len(Int(CDbl(RA(3))))), VB6.Format(RA(3), "##0.0") & Chr(176), TAB(54 - Len(Int(CDbl(DF(3))))), VB6.Format(DF(3), "#0.0") & Chr(176) & HD(3))
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Mars", TAB(18 - Len(Int(CDbl(SH(4))))), VB6.Format(SH(4), "##0.0") & Chr(176), TAB(38 - Len(Int(CDbl(RA(4))))), VB6.Format(RA(4), "##0.0") & Chr(176), TAB(54 - Len(Int(CDbl(DF(4))))), VB6.Format(DF(4), "#0.0") & Chr(176) & HD(4))
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Jupiter", TAB(18 - Len(Int(CDbl(SH(5))))), VB6.Format(SH(5), "##0.0") & Chr(176), TAB(38 - Len(Int(CDbl(RA(5))))), VB6.Format(RA(5), "##0.0") & Chr(176), TAB(54 - Len(Int(CDbl(DF(5))))), VB6.Format(DF(5), "#0.0") & Chr(176) & HD(5))
		'UPGRADE_WARNING: Couldn't resolve default property of object HD(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object SH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Saturn", TAB(18 - Len(Int(CDbl(SH(6))))), VB6.Format(SH(6), "##0.0") & Chr(176), TAB(38 - Len(Int(CDbl(RA(6))))), VB6.Format(RA(6), "##0.0") & Chr(176), TAB(54 - Len(Int(Int(CDbl(DF(6)))))), VB6.Format(DF(6), "#0.0") & Chr(176) & HD(6))
	End Sub
	
	Public Function First() As Object 'was Sub2521
		I1 = I1 + 1
		'UPGRADE_WARNING: Couldn't resolve default property of object Body(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Body1(I1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Body1(I1) = Body(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag1(I1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mag1(I1) = Mag(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Z1(I1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Z1(I1) = ZN
		'UPGRADE_WARNING: Couldn't resolve default property of object H1A(I1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		H1A(I1) = Ho
	End Function
	
	'UPGRADE_NOTE: Second was upgraded to Second_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function Second_Renamed() As Object 'was Sub2522
		I2 = I2 + 1
		'UPGRADE_WARNING: Couldn't resolve default property of object Body(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Body2(I2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Body2(I2) = Body(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag2(I2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mag2(I2) = Mag(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Z2(I2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Z2(I2) = ZN
		'UPGRADE_WARNING: Couldn't resolve default property of object H2A(I2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		H2A(I2) = Ho
	End Function
	
	Public Function Third() As Object 'was Sub2523
		I3 = I3 + 1
		'UPGRADE_WARNING: Couldn't resolve default property of object Body(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Body3(I3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Body3(I3) = Body(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag(BN). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mag3(I3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mag3(I3) = Mag(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Z3(I3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Z3(I3) = ZN
		'UPGRADE_WARNING: Couldn't resolve default property of object H3A(I3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		H3A(I3) = Ho
	End Function
	Public Function CheckDate() As Object
		On Error GoTo ErrorHandler
		If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
			Exit Function
		Else
			DateOfSight = cboDay.Text & " " & VB6.GetItemData(cboMonth, cboMonth.SelectedIndex) & " " & txtYear.Text
			'UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			DateOfSight = CStr(DateValue(DateOfSight))
		End If
		Exit Function
ErrorHandler: 
		MsgBox("Invalid date")
		DateError = True
	End Function
	
	'UPGRADE_WARNING: Event txtLowAz.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLowAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLowAz.TextChanged
		'txtLowAz.ForeColor = &H80000008
		txtLowAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLowAz.Text) > 360 Then
			txtLowAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtLowAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLowAz.KeyPress
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
	
	Private Sub txtLowAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLowAz.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLowAz.Text) > 360 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLowAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLowAz.Enter
		SelectAllText(txtLowAz)
	End Sub
	
	'UPGRADE_WARNING: Event txtHighAz.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHighAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHighAz.TextChanged
		'txtHighAz.ForeColor = &H80000008
		txtHighAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtHighAz.Text) > 360 Then
			txtHighAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtHighAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHighAz.KeyPress
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
	
	Private Sub txtHighAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHighAz.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHighAz.Text) > 360 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHighAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHighAz.Enter
		SelectAllText(txtHighAz)
	End Sub
	
	Private Sub StarMagnitudes()
		If GYear <= 2005 Then
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1-1.2", -0.9, -1.6, " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6"}
		Else
			'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Magnitude = New Object(){" 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1-1.2", -0.7, -1.5, " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", -0.3, " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5"}
		End If
		For i = 0 To 57
			'UPGRADE_WARNING: Couldn't resolve default property of object Magnitude(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Mag(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Mag(i) = Magnitude(i)
		Next i
	End Sub
	
	
	Public Sub DisplayView()
		Dim ttx As Short
		Dim tty As Short
		Dim tWnd As Integer
		Dim hFrmWnd As Integer
		Warning()
		lblAltitude.Visible = True
		lblAzimuth.Visible = True
		lblAz.Visible = True
		lblAlt.Visible = True
		Label5.Visible = True
		Label7.Visible = True
		lblN.Visible = True
		lblE.Visible = True
		lblS.Visible = True
		lblW.Visible = True
		lblBody.Visible = True
		lblBodyName.Visible = True
		If bShowToolTips Then
			hFrmWnd = Me.Handle.ToInt32
		Else
			hFrmWnd = 0
		End If
		
		'lblN2.Visible = False
		'lblN.Top = 3460
		'lblN.Left = 5160
		'lblE.Top = 5880
		'lblE.Left = 2680
		'lblS.Top = 8350
		'lblS.Left = 5160
		'lblW.Top = 5880
		'lblW.Left = 7680
		'lblOverhead.Visible = True
		chkFirst.Visible = True
		chkSecond.Visible = True
		chkThird.Visible = True
		chkNames.Visible = True
		chkLimit.Visible = True
		'If (chkFirst.Value = 1 And chkSecond.Value = 1 And chkThird.Value = 1) Then
		chkHelper.Visible = True
		'chkHelper.Enabled = True
		'    Else
		'    chkHelper.Visible = False
		'    chkHelper.Enabled = False
		'End If
		'chkHelper.Visible = False
		FrameView.Visible = True
		'optOverhead.Visible = True
		'optStarFinder.Visible = True
		'optHorizon.Visible = True
		FrameDirection.Visible = True
		'optN.Visible = True
		'optS.Visible = True
		'optE.Visible = True
		'optW.Visible = True
		FrameBest.Visible = True
		'optOff.Visible = True
		'optTwo.Visible = True
		'optThreeBoat.Visible = True
		'optThreeBeach.Visible = True
		If optOff.Checked = False Then cmdCCW.Enabled = True : cmdCW.Enabled = True
		Dim XTD1, YTD1 As Single
		Dim XTD2, YTD2 As Single
		Dim TwoPi, i As Single
		'Form1.Font.Name = "MS Sans Serif"
		TwoPi = 8 * System.Math.Atan(1)
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale (-5228, 5980) - (5228, -2540)
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		Show()
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 2400 'Horizon circle
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 2000 '15 degree altitude circle
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 2
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 1600 '30 degree altitude circle
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 1200 '45 degree altitude circle
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 800 '60 degree altitude circle
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 400 '75 degree altitude circle
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 2
		For i = 0 To TwoPi Step TwoPi / 24
			XTD1 = 400 * System.Math.Cos(i)
			YTD1 = 400 * System.Math.Sin(i)
			XTD2 = 2400 * System.Math.Cos(i)
			YTD2 = 2400 * System.Math.Sin(i)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (XTD1, YTD1) - (XTD2, YTD2)
		Next i
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form property Form2.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		FillStyle = 0
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		If LowAz > HighAz Then HighAz = HighAz + 360
		'First magnitude bodies
		For i = 0 To UBound(TTip1, 1)
			If Not TTip1(i) Is Nothing Then
				'UPGRADE_NOTE: Object TTip1() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				TTip1(i) = Nothing
			End If
		Next i
		
		If chkFirst.CheckState = 1 Then
			ReDim TTip1(I1)
			For i = 1 To I1
				'UPGRADE_WARNING: Couldn't resolve default property of object H1A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - H1A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z1(i) = Val(Z1(i))
				'Z1(i) = Z1(i) + 90
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z1Temp(i) = Z1(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z1(i) < LowAz Then Z1Temp(i) = Z1(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((Z1(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((Z1(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz Then Me.Circle (x, y), 60
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 Then Me.Circle (x, y), 60
				TTip1(i) = New ToolTip
				' set the tooltip position to the upper left corner of the circle
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 60 / VB6.TwipsPerPixelX
				tty = (5980 - y) / VB6.TwipsPerPixelY - 60 / VB6.TwipsPerPixelY
				' the tooltip witdth & height is set to 2x the circle radius
				'UPGRADE_WARNING: Couldn't resolve default property of object Body1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip1(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body1(i), i, ttx, tty, 120 / VB6.TwipsPerPixelX, 120 / VB6.TwipsPerPixelY)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (chkNames.CheckState = 1 And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 70
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body1(i))
				End If
			Next i
		End If
		'Second magnitude bodies
		For i = 0 To UBound(TTip2, 1)
			If Not TTip2(i) Is Nothing Then
				'UPGRADE_NOTE: Object TTip2() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				TTip2(i) = Nothing
			End If
		Next i
		If chkSecond.CheckState = 1 Then
			ReDim TTip2(I2)
			For i = 1 To I2
				'UPGRADE_WARNING: Couldn't resolve default property of object H2A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - H2A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z2(i) = Val(Z2(i))
				'Z2(i) = Z2(i) + 90
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z2Temp(i) = Z2(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z2(i) < LowAz Then Z2Temp(i) = Z2(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((Z2(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((Z2(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz Then Me.Circle (x, y), 40
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 Then Me.Circle (x, y), 40
				TTip2(i) = New ToolTip
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 40 / VB6.TwipsPerPixelX
				tty = (5980 - y) / VB6.TwipsPerPixelY - 40 / VB6.TwipsPerPixelY
				'UPGRADE_WARNING: Couldn't resolve default property of object Body2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip2(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body2(i), i, ttx, tty, 80 / VB6.TwipsPerPixelX, 80 / VB6.TwipsPerPixelY)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (chkNames.CheckState = 1 And chkLimit.CheckState = 1 And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 50
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body2(i))
				End If
			Next i
		End If
		'Third magnitude bodies
		For i = 0 To UBound(TTip3, 1)
			If Not TTip3(i) Is Nothing Then
				'UPGRADE_NOTE: Object TTip3() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				TTip3(i) = Nothing
			End If
		Next i
		If chkThird.CheckState = 1 Then
			ReDim TTip3(I3)
			For i = 1 To I3
				'UPGRADE_WARNING: Couldn't resolve default property of object H3A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - H3A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z3(i) = Val(Z3(i))
				'Z3(i) = Z3(i) + 90
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z3Temp(i) = Z3(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z3(i) < LowAz Then Z3Temp(i) = Z3(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((Z3(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((Z3(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz Then Me.Circle (x, y), 20
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 Then Me.Circle (x, y), 20
				TTip3(i) = New ToolTip
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 2
				tty = (5980 - y) / VB6.TwipsPerPixelY - 2
				'UPGRADE_WARNING: Couldn't resolve default property of object Body3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip3(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body3(i), i, ttx, tty, 4, 4)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (chkNames.CheckState = 1 And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 30
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body3(i))
				End If
			Next i
		End If
		'UPGRADE_ISSUE: Form property Form2.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		FillStyle = 1
		If chkHelper.CheckState = 1 Then
			'First magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - HH1A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH1Temp(i) = ZH1(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH1(i) < LowAz Then ZH1Temp(i) = ZH1(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((ZH1(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((ZH1(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And ZH1Temp(i) >= LowAz And ZH1Temp(i) <= HighAz And HH1A(i) <> 0 Then Me.Circle (x, y), 60
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 And HH1A(i) <> 0 Then Me.Circle (x, y), 60
			Next i
			'Second magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - HH2A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH2Temp(i) = ZH2(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH2(i) < LowAz Then ZH2Temp(i) = ZH2(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((ZH2(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((ZH2(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And ZH2Temp(i) >= LowAz And ZH2Temp(i) <= HighAz And HH2A(i) <> 0 Then Me.Circle (x, y), 40
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 And HH2A(i) <> 0 Then Me.Circle (x, y), 40
			Next i
			'Third magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - HH3A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH3Temp(i) = ZH3(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH3(i) < LowAz Then ZH3Temp(i) = ZH3(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((ZH3(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((ZH3(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And ZH3Temp(i) >= LowAz And ZH3Temp(i) <= HighAz And HH3A(i) <> 0 Then Me.Circle (x, y), 20
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 And HH3A(i) <> 0 Then Me.Circle (x, y), 20
			Next i
			'Fourth+ magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rad = 2400 * (1 - HH4A(i) / 90)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH4Temp(i) = ZH4(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH4(i) < LowAz Then ZH4Temp(i) = ZH4(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = rad * System.Math.Cos((ZH4(i) + 90 + RotateX) * Pi / 180)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = rad * System.Math.Sin((ZH4(i) + 90 + RotateY) * Pi / 180)
				If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
				If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 1 And ZH4Temp(i) >= LowAz And ZH4Temp(i) <= HighAz And HH4A(i) <> 0 Then Me.Circle (x, y), 15
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If chkLimit.CheckState = 0 And HH4A(i) <> 0 Then Me.Circle (x, y), 15
			Next i
		End If
		'FillStyle = 1
		If optHorizon.Checked = False And optTwo.Checked = True Then
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
			XTB1 = 2400 * System.Math.Cos(SweepStep2)
			YTB1 = 2400 * System.Math.Sin(SweepStep2)
			XTB2 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2)
			YTB2 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB1, YTB1), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB2, YTB2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			XTB4 = 2400 * System.Math.Cos(SweepStep2 - Pi / 8)
			YTB4 = 2400 * System.Math.Sin(SweepStep2 - Pi / 8)
			XTB5 = 2400 * System.Math.Cos(SweepStep2 + Pi / 8)
			YTB5 = 2400 * System.Math.Sin(SweepStep2 + Pi / 8)
			XTB6 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2 - Pi / 8)
			YTB6 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2 - Pi / 8)
			XTB7 = 2400 * System.Math.Cos(SweepStep2 + Pi / 2 + Pi / 8)
			YTB7 = 2400 * System.Math.Sin(SweepStep2 + Pi / 2 + Pi / 8)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 1
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB4, YTB4), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB5, YTB5), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 3
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB6, YTB6), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB7, YTB7), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		End If
		If optHorizon.Checked = False And (optThreeBoat.Checked = True Or optThreeBeach.Checked = True) Then
			XTB1 = 2400 * System.Math.Cos(SweepStep3)
			YTB1 = 2400 * System.Math.Sin(SweepStep3)
			XTB2 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3)
			YTB2 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3)
			XTB3 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3)
			YTB3 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3)
			XTB8 = 2400 * System.Math.Cos(SweepStep3 + Pi)
			YTB8 = 2400 * System.Math.Sin(SweepStep3 + Pi)
			XTB9 = 2400 * System.Math.Cos(SweepStep3 - Pi / 12)
			YTB9 = 2400 * System.Math.Sin(SweepStep3 - Pi / 12)
			XTB10 = 2400 * System.Math.Cos(SweepStep3 + Pi / 12)
			YTB10 = 2400 * System.Math.Sin(SweepStep3 + Pi / 12)
			XTB11 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			YTB11 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3 - Pi / 12)
			XTB12 = 2400 * System.Math.Cos(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			YTB12 = 2400 * System.Math.Sin(SweepStep3 + 2 * Pi / 3 + Pi / 12)
			XTB13 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			YTB13 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3 - Pi / 12)
			XTB14 = 2400 * System.Math.Cos(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			YTB14 = 2400 * System.Math.Sin(SweepStep3 + 4 * Pi / 3 + Pi / 12)
			XTB15 = 2400 * System.Math.Cos(SweepStep3 + Pi - Pi / 12)
			YTB15 = 2400 * System.Math.Sin(SweepStep3 + Pi - Pi / 12)
			XTB16 = 2400 * System.Math.Cos(SweepStep3 + Pi + Pi / 12)
			YTB16 = 2400 * System.Math.Sin(SweepStep3 + Pi + Pi / 12)
			'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB2, YTB2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (XTB3, YTB3), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			If optThreeBoat.Checked = True Then
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 0
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB1, YTB1), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 1
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB9, YTB9), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB10, YTB10), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 3
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB11, YTB11), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB12, YTB12), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 4
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB13, YTB13), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB14, YTB14), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			End If
			If optThreeBeach.Checked = True Then
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 0
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB8, YTB8), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				DrawStyle = 1
				'Line (0, 0)-(XTB15, YTB15), vbRed
				'Line (0, 0)-(XTB16, YTB16), vbRed
				'DrawStyle = 3
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB11, YTB11), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				'Line (0, 0)-(XTB12, YTB12), vbRed
				'DrawStyle = 4
				'Line (0, 0)-(XTB13, YTB13), vbRed
				'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Line (0, 0) - (XTB14, YTB14), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
			End If
		End If
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
	End Sub
	
	Public Function MouseX(Optional ByVal hWnd As Integer = 0) As Integer
		Dim lpPoint As POINTAPI
		GetCursorPos(lpPoint)
		hWnd = Me.Handle.ToInt32
		If hWnd Then ScreenToClient(hWnd, lpPoint)
		MouseX = lpPoint.x
		'lblAlt.Caption = MouseX
	End Function
	
	Public Function MouseY(Optional ByVal hWnd As Integer = 0) As Integer
		Dim lpPoint As POINTAPI
		GetCursorPos(lpPoint)
		hWnd = Me.Handle.ToInt32
		If hWnd Then ScreenToClient(hWnd, lpPoint)
		MouseY = lpPoint.y
		'lblAlt.Caption = MouseY
	End Function
	
	'UPGRADE_WARNING: Event chkNames.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkNames_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNames.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	'UPGRADE_WARNING: Event chkFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFirst.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	'UPGRADE_WARNING: Event chkSecond.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkSecond_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSecond.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	'UPGRADE_WARNING: Event chkThird.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkThird_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkThird.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	Private Sub DisplayHorizonView()
		Warning()
		Dim ttx As Short
		Dim tty As Short
		Dim tWnd As Integer
		Dim hFrmWnd As Integer
		lblAltitude.Visible = True
		lblAzimuth.Visible = True
		lblAz.Visible = True
		lblAlt.Visible = True
		Label5.Visible = True
		Label7.Visible = True
		lblBody.Visible = True
		lblBodyName.Visible = True
		If bShowToolTips Then
			hFrmWnd = Me.Handle.ToInt32
		Else
			hFrmWnd = 0
		End If
		
		'lblOverhead.Visible = True
		chkFirst.Visible = True
		chkSecond.Visible = True
		chkThird.Visible = True
		chkNames.Visible = True
		chkLimit.Visible = True
		'If (chkFirst.Value = 1 And chkSecond.Value = 1 And chkThird.Value = 1) Then
		chkHelper.Visible = True
		'chkHelper.Enabled = True
		'    Else
		'    chkHelper.Visible = False
		'    chkHelper.Enabled = False
		'End If
		FrameView.Visible = True
		'optOverhead.Visible = True
		'optStarFinder.Visible = True
		'optHorizon.Visible = True
		FrameDirection.Visible = True
		'optN.Visible = True
		'optS.Visible = True
		'optE.Visible = True
		'optW.Visible = True
		lblN.Visible = True
		lblS.Visible = True
		lblE.Visible = True
		lblW.Visible = True
		FrameBest.Visible = False
		'optOff.Visible = False
		'optTwo.Visible = False
		'optThreeBoat.Visible = False
		'optThreeBeach.Visible = False
		''cmdCCW.Visible = False
		'cmdCCW.Enabled = False
		''cmdCW.Visible = False
		'cmdCW.Enabled = False
		'If optN = True And optHorizon = True Then lblS2.Visible = True
		'If optS = True And optHorizon = True Then lblN2.Visible = True
		'If optE = True And optHorizon = True Then lblW2.Visible = True
		'If optW = True And optHorizon = True Then lblE2.Visible = True
		If optN.Checked = True And optHorizon.Checked = True Then lblS.Visible = False
		If optS.Checked = True And optHorizon.Checked = True Then lblN.Visible = False
		If optE.Checked = True And optHorizon.Checked = True Then lblW.Visible = False
		If optW.Checked = True And optHorizon.Checked = True Then lblE.Visible = False
		Dim TwoPi, i As Single
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale (-5228, 5980) - (5228, -2540)
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		Show()
		'Line (-3500, -2000)-Step(6480, 4500), , B   'Outer box
		'Line (-3500, 1750)-(2980, 1750) '15 degree altitude line
		'DrawStyle = 2
		'Line (-3500, 1000)-(2980, 1000) '30 degree altitude line
		'Line (-3500, 250)-(2980, 250) '45 degree altitude line
		'Line (-3500, -500)-(2980, -500) '60 degree altitude line
		'DrawStyle = 0
		'Line (-3500, -1250)-(2980, -1250) '75 degree altitude line
		'DrawStyle = 2
		'For i = 1 To 23
		'    Line (-3500 + 270 * i, -2000)-(-3500 + 270 * i, 2500)
		'Next i
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, -2000) - Step(6480, 3240), B 'Outer box
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, 700) - (2980, 700) '15 degree altitude line
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 2
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, 160) - (2980, 160) '30 degree altitude line
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, -380) - (2980, -380) '45 degree altitude line
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, -920) - (2980, -920) '60 degree altitude line
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (-3500, -1460) - (2980, -1460) '75 degree altitude line
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 2
		For i = 1 To 11
			'Line (-3500 + 270 * i, -2000)-(-3500 + 270 * i, 2500)
			'UPGRADE_ISSUE: Form method Form2.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (-3500 + 540 * i, -2000) - (-3500 + 540 * i, 1240)
		Next i
		
		'UPGRADE_ISSUE: Form property Form2.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'UPGRADE_ISSUE: Form property Form2.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		FillStyle = 0
		LowAz = Val(txtLowAz.Text)
		HighAz = Val(txtHighAz.Text)
		If LowAz > HighAz Then HighAz = HighAz + 360
		'First magnitude bodies
		If chkFirst.CheckState = 1 Then
			ReDim TTip1(I1)
			For i = 1 To I1
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z1(i) = Val(Z1(i))
				'Z1(i) = Z1(i) + 90
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z1Temp(i) = Z1(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z1(i) < LowAz Then Z1Temp(i) = Z1(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * Z1(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object H1A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * H1A(i) 'y = -2000 + 50 * H1A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz Then Me.Circle (x, y), 60
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 Then Me.Circle (x, y), 60
				TTip1(i) = New ToolTip
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 60 / VB6.TwipsPerPixelX
				tty = (5980 - y) / VB6.TwipsPerPixelY - 60 / VB6.TwipsPerPixelY
				'UPGRADE_WARNING: Couldn't resolve default property of object Body1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip1(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body1(i), i, ttx, tty, 120 / VB6.TwipsPerPixelX, 120 / VB6.TwipsPerPixelY)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If AzTest = True And ((chkNames.CheckState = 1 And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0)) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 70
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body1(i))
				End If
			Next i
		End If
		'Second magnitude bodies
		If chkSecond.CheckState = 1 Then
			Dim TTips2(I2) As Object
			For i = 1 To I2
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z2(i) = Val(Z2(i))
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z2Temp(i) = Z2(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z2(i) < LowAz Then Z2Temp(i) = Z2(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * Z2(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object H2A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * H2A(i) 'y = -2000 + 50 * H2A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz Then Me.Circle (x, y), 40
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 Then Me.Circle (x, y), 40
				TTip2(i) = New ToolTip
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 40 / VB6.TwipsPerPixelX
				tty = (5980 - y) / VB6.TwipsPerPixelY - 40 / VB6.TwipsPerPixelY
				'UPGRADE_WARNING: Couldn't resolve default property of object Body2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip2(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body2(i), i, ttx, tty, 80 / VB6.TwipsPerPixelX, 80 / VB6.TwipsPerPixelY)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If AzTest = True And ((chkNames.CheckState = 1 And chkLimit.CheckState = 1 And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0)) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 50
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body2(i))
				End If
			Next i
		End If
		'Third magnitude bodies
		If chkThird.CheckState = 1 Then
			ReDim TTip3(I3)
			For i = 1 To I3
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z3(i) = Val(Z3(i))
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Z3Temp(i) = Z3(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Z3(i) < LowAz Then Z3Temp(i) = Z3(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * Z3(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object H3A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * H3A(i) 'y = -2000 + 50 * H3A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz Then Me.Circle (x, y), 20
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 Then Me.Circle (x, y), 20
				TTip3(i) = New ToolTip
				ttx = (5228 + x) / VB6.TwipsPerPixelX - 2
				tty = (5980 - y) / VB6.TwipsPerPixelY - 2
				'UPGRADE_WARNING: Couldn't resolve default property of object Body3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tWnd = TTip3(i).CreateToolTip(hFrmWnd, VB6.GetHInstance.ToInt32, Body3(i), i, ttx, tty, 4, 4)
				'UPGRADE_WARNING: Couldn't resolve default property of object Z3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If AzTest = True And ((chkNames.CheckState = 1 And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz) Or (chkNames.CheckState = 1 And chkLimit.CheckState = 0)) Then
					'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentX = x + 30
					'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					CurrentY = y + 90
					'UPGRADE_WARNING: Couldn't resolve default property of object Body3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					Print(Body3(i))
				End If
			Next i
		End If
		'UPGRADE_ISSUE: Form property Form2.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		FillStyle = 1
		If chkHelper.CheckState = 1 Then
			'First magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH1Temp(i) = ZH1(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH1(i) < LowAz Then ZH1Temp(i) = ZH1(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * ZH1(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * HH1A(i) 'y = -2000 + 50 * HH1A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And ZH1Temp(i) >= LowAz And ZH1Temp(i) <= HighAz And HH1A(i) <> 0 Then Me.Circle (x, y), 60
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 And HH1A(i) <> 0 Then Me.Circle (x, y), 60
			Next i
			'Second magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH2Temp(i) = ZH2(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH2(i) < LowAz Then ZH2Temp(i) = ZH2(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * ZH2(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * HH2A(i) 'y = -2000 + 50 * HH2A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And ZH2Temp(i) >= LowAz And ZH2Temp(i) <= HighAz And HH2A(i) <> 0 Then Me.Circle (x, y), 40
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 And HH2A(i) <> 0 Then Me.Circle (x, y), 40
			Next i
			'Third magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH3Temp(i) = ZH3(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH3(i) < LowAz Then ZH3Temp(i) = ZH3(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * ZH3(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * HH3A(i) 'y = -2000 + 50 * HH3A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And ZH3Temp(i) >= LowAz And ZH3Temp(i) <= HighAz And HH3A(i) <> 0 Then Me.Circle (x, y), 20
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 And HH3A(i) <> 0 Then Me.Circle (x, y), 20
			Next i
			'Fourth+ magnitude Helper stars
			For i = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH4Temp(i) = ZH4(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ZH4(i) < LowAz Then ZH4Temp(i) = ZH4(i) + 360
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = -3500 + 36 * ZH4(i) + ShiftX
				If optN.Checked = True And x >= 9460 And x <= 12700 Then x = x - 12960
				AzTest = True : If x > 2980 Or x < -3500 Then AzTest = False
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				y = -2000 + 36 * HH4A(i) 'y = -2000 + 50 * HH4A(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4Temp(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 1 And ZH4Temp(i) >= LowAz And ZH4Temp(i) <= HighAz Then Me.Circle (x, y), 15
				'UPGRADE_ISSUE: Form method Form2.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				If AzTest = True And chkLimit.CheckState = 0 Then Me.Circle (x, y), 15
			Next i
		End If
		'FillStyle = 1
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
	End Sub
	
	
	Public Function Helpers() As Object
		For k = 0 To NumberOfHelpers - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object RDHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object RDHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			RDHelper1 = RDHelper(k)
			'UPGRADE_WARNING: Couldn't resolve default property of object RMHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object RMHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			RMHelper1 = RMHelper(k)
			'UPGRADE_WARNING: Couldn't resolve default property of object RSHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object RSHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			RSHelper1 = RSHelper(k)
			'UPGRADE_WARNING: Couldn't resolve default property of object DDHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DDHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DDHelper1 = DDHelper(k)
			'UPGRADE_WARNING: Couldn't resolve default property of object DMHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DMHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DMHelper1 = DMHelper(k)
			'UPGRADE_WARNING: Couldn't resolve default property of object DSHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DSHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DSHelper1 = DSHelper(k)
			'AR = RDHelper1 + RMHelper1 / 60 + RSHelper1 / 3600: DE = Abs(DDHelper1) + DMHelper1 / 60 + DSHelper1 / 3600: DE = Sgn(DDHelper1) * DE
			'Line above changed for Helper stars less than one degree south declination
			'UPGRADE_WARNING: Couldn't resolve default property of object RSHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object RMHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object RDHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			AR = RDHelper1 + RMHelper1 / 60 + RSHelper1 / 3600
			'UPGRADE_WARNING: Couldn't resolve default property of object DSHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DMHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DDHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DE = System.Math.Abs(DDHelper1) + System.Math.Abs(DMHelper1) / 60 + System.Math.Abs(DSHelper1) / 3600
			'UPGRADE_WARNING: Couldn't resolve default property of object DSHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DMHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object DDHelper1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If System.Math.Sign(DDHelper1) = -1 Or System.Math.Sign(DMHelper1) = -1 Or System.Math.Sign(DSHelper1) = -1 Then DE = -DE
			AR = AR * 15 ': AR = AR * Pi / 180: DE = DE * Pi / 180
			'Don't bother with Proper Motion - PMRA and PMDec are for nav stars anyway
			'AR = AR + PMRA(BN) * NY * 15 / 360000       ''PMRA(BN) in seconds/century - divide by 100 to get seconds/year, by 3600 to get hours, mult. by 15 to get degrees
			'DE = DE + PMDec(BN) * NY / 360000      'PMDec(BN) arcseconds/century - divide by 100 to get arcseconds/year, by 3600 to get degrees
			'Precession
			Precession() 'this is the rigorous method; goes in with degrees, comes back as radians
			Sun() 'for sun's (mean longitude, L0, used in Nutation, and) true longitude, LN, in degrees, and Eccentricity, both used in AberrationRADec
			Nutation() 'returns nutation in longitude (NL) and nutation in obliquity (NO), both in degrees
			Obliquity() 'returns mean obliquity of the ecliptic (OE) and true obliquity (OETrue), both in degrees
			AberrationRADec() 'returns Aberration corrections to RA and Dec, AberrRA and AberrDec, both in degrees
			OETrue = OETrue * Pi / 180 'radians
			NutRA = (System.Math.Cos(OETrue) + System.Math.Sin(OETrue) * System.Math.Sin(AR) * System.Math.Tan(DE)) * NL - (System.Math.Cos(AR) * System.Math.Tan(DE)) * NO 'nutation correction to RA, degrees
			NutDec = (System.Math.Sin(OETrue) * System.Math.Cos(AR)) * NL + System.Math.Sin(AR) * NO 'nutation correction to Dec, degrees
			AR = AR * 180 / Pi + NutRA + AberrRA 'RA corrected for nutation and Aberration, degrees
			DE = DE * 180 / Pi + NutDec + AberrDec 'Dec corrected for nutation and Aberration, degrees
			'AR = AR * Pi / 180      'radians
			'DE = DE * Pi / 180      'radians
			
			For j = 0 To NumberOfHelpers - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH1(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH1(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH1(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH1A(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH2(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH2(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH2(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH2A(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH3(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH3(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH3(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH3A(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH4(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH4(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH4(k) = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH4A(k) = 0
			Next j
			AltAz() 'go in with degrees
			If Ho > 0 And MagHelper(k) < 1.55 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MagHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH1(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH1(k) = MagHelper(k)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH1(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH1(k) = ZN
				'UPGRADE_WARNING: Couldn't resolve default property of object HH1A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH1A(k) = Ho
			End If
			If Ho > 0 And MagHelper(k) > 1.55 And MagHelper(k) < 2.55 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MagHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH2(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH2(k) = MagHelper(k)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH2(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH2(k) = ZN
				'UPGRADE_WARNING: Couldn't resolve default property of object HH2A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH2A(k) = Ho
			End If
			If Ho > 0 And MagHelper(k) > 2.55 And MagHelper(k) < 3.55 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MagHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH3(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH3(k) = MagHelper(k)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH3(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH3(k) = ZN
				'UPGRADE_WARNING: Couldn't resolve default property of object HH3A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH3A(k) = Ho
			End If
			If Ho > 0 And MagHelper(k) > 3.55 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MagHelper(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object MagH4(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MagH4(k) = MagHelper(k)
				'UPGRADE_WARNING: Couldn't resolve default property of object ZH4(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ZH4(k) = ZN
				'UPGRADE_WARNING: Couldn't resolve default property of object HH4A(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HH4A(k) = Ho
			End If
		Next k
	End Function
	'UPGRADE_WARNING: Event chkHelper.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkHelper_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkHelper.CheckStateChanged
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		If chkHelper.CheckState = 1 Then
			TempFirst = chkFirst.CheckState
			TempSecond = chkSecond.CheckState
			TempThird = chkThird.CheckState
			chkFirst.CheckState = System.Windows.Forms.CheckState.Checked : chkFirst.Enabled = False
			chkSecond.CheckState = System.Windows.Forms.CheckState.Checked : chkSecond.Enabled = False
			chkThird.CheckState = System.Windows.Forms.CheckState.Checked : chkThird.Enabled = False
		End If
		If chkHelper.CheckState = 0 Then
			chkFirst.Enabled = True : If TempFirst = True Then chkFirst.CheckState = System.Windows.Forms.CheckState.Checked Else chkFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
			chkSecond.Enabled = True : If TempSecond = True Then chkSecond.CheckState = System.Windows.Forms.CheckState.Checked Else chkSecond.CheckState = System.Windows.Forms.CheckState.Unchecked
			chkThird.Enabled = True : If TempThird = True Then chkThird.CheckState = System.Windows.Forms.CheckState.Checked Else chkThird.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		BlankTimeFlag = False
		cmdTwilights_Click(cmdTwilights, New System.EventArgs())
		If optHorizon.Checked = False Then DisplayView() Else DisplayHorizonView()
		'If optHorizon = False And optTwo = True Then optTwo_Click
		'If optHorizon = False And optThreeBoat = True Then optThreeBoat_Click
		'If optHorizon = False And optThreeBeach = True Then optThreeBeach_Click
	End Sub
	
	Public Sub DisplaySunMoon()
		Shape1.Visible = True
		'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentX = 7345
		'UPGRADE_ISSUE: Form property Form2.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 7700
		If FirstTime <> 0 Then
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("     Acceptable Sun-Moon fix from ")
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 7345
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("                   " & FTHours & FTMinutes & " to " & LTHours & LTMinutes & ".")
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 7345
			'Print "             Moon " & MoonPhase$ & "% illuminated."
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("   Moon from " & VB6.Format(MoonPhaseFirst, "#0") & "% to " & VB6.Format(MoonPhaseLast, "#0") & "% illuminated.")
		End If
		If FirstTime = 0 Then
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" No acceptable Sun-Moon fix this date,")
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 7345
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" location, azimuth range, and")
			'UPGRADE_ISSUE: Form property Form2.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentX = 7345
			'UPGRADE_ISSUE: Form method Form2.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" minimum altitude.")
		End If
	End Sub
	
	Public Sub Warning()
		''Form2.Font.Bold = True: Form2.ForeColor = &HC8FF&
		'If txtTime.Text = "" Then txtTime.Text = "0000": txtTime.BackColor = &HFFFF&: txtWarning.Visible = True     'CurrentY = 2580: Print Tab(53); "Blank ZT defaults to 0000.": CurrentY = 2700: Print Tab(53); "Are you sure you want midnight?"
		'Form2.Font.Bold = False: Form2.ForeColor = vbBlack
		If txtTime.Text = "" Then Exit Sub
		txtWarning.Visible = True
		'Calculate AutoZD
		AutoZD = Int(Lo / 15 + 0.5)
		
		Time = 60 * Val(VB.Left(txtTime.Text, 2)) + Val(VB.Right(txtTime.Text, 2)) - (AutoZD - ZD) * 60
		If Time < 0 Then Time = Time + 1440
		If Time > 1440 Then Time = Time - 1440
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C32 = 60 * Val(VB.Left(C3(2), 2)) + Val(VB.Right(C3(2), 2)) - (AutoZD - ZD) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C33 = 60 * Val(VB.Left(C3(3), 2)) + Val(VB.Right(C3(3), 2)) - (AutoZD - ZD) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C34 = 60 * Val(VB.Left(C3(4), 2)) + Val(VB.Right(C3(4), 2)) - (AutoZD - ZD) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C35 = 60 * Val(VB.Left(C3(5), 2)) + Val(VB.Right(C3(5), 2)) - (AutoZD - ZD) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C36 = 60 * Val(VB.Left(C3(6), 2)) + Val(VB.Right(C3(6), 2)) - (AutoZD - ZD) * 60
		'UPGRADE_WARNING: Couldn't resolve default property of object C3(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		C37 = 60 * Val(VB.Left(C3(7), 2)) + Val(VB.Right(C3(7), 2)) - (AutoZD - ZD) * 60
		If C32 > 1440 Then C32 = C32 - 1440
		If C33 > 1440 Then C33 = C33 - 1440
		If C34 > 1440 Then C34 = C34 - 1440
		If C35 < 0 Then C35 = C35 + 1440
		If C36 < 0 Then C36 = C36 + 1440
		If C37 < 0 Then C37 = C37 + 1440
		If Time < C32 Or Time >= C37 Then txtWarning.ForeColor = System.Drawing.Color.White : txtWarning.BackColor = System.Drawing.Color.Black : txtWarning.Text = "Night" 'Else
		If Time >= C34 And Time < C35 Then txtWarning.ForeColor = System.Drawing.Color.Black : txtWarning.BackColor = System.Drawing.Color.Yellow : txtWarning.Text = "Day" 'Else
		If (Time >= C32 And Time < C34) Or (Time >= C35 And Time < C37) Then txtWarning.ForeColor = System.Drawing.Color.White : txtWarning.BackColor = System.Drawing.Color.Blue : txtWarning.Text = "Twilight"
	End Sub
	Public Function Delta_T() As Object
		DecYr = GYear + (GMonth - 0.5) / 12
		If GYear >= 1901 And GYear <= 1920 Then Theta = DecYr - 1900 : DeltaT = -2.79 + 1.494119 * Theta - 0.0598939 * Theta ^ 2 + 0.0061966 * Theta ^ 3 - 0.000197 * Theta ^ 4
		If GYear >= 1921 And GYear <= 1941 Then Theta = DecYr - 1920 : DeltaT = 21.2 + 0.84493 * Theta - 0.0761 * Theta ^ 2 + 0.0020936 * Theta ^ 3
		If GYear >= 1942 And GYear <= 1961 Then Theta = DecYr - 1950 : DeltaT = 29.07 + 0.407 * Theta - (Theta ^ 2) / 233 + (Theta ^ 3) / 2547
		If GYear >= 1962 And GYear <= 1986 Then Theta = DecYr - 1975 : DeltaT = 45.45 + 1.067 * Theta - (Theta ^ 2) / 260 - (Theta ^ 3) / 718
		If GYear >= 1987 And GYear <= 2005 Then Theta = DecYr - 2000 : DeltaT = 63.86 + 0.3345 * Theta - 0.060374 * Theta ^ 2 + 0.0017275 * Theta ^ 3 + 0.000651814 * Theta ^ 4 + 0.00002373599 * Theta ^ 5
		If GYear >= 2006 And GYear <= 2050 Then Theta = DecYr - 2000 : DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2
		If GYear >= 2051 And GYear <= 2099 Then DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)
	End Function
	Private Sub Precession()
		'coming in AR in degrees, DE in degrees
		AR = AR * Pi / 180 'convert to radians
		DE = DE * Pi / 180
		T = (JD - 2451545) / 36525
		Pre1 = 2306.2181 * T + 0.30188 * T * T + 0.017998 * T * T * T : Pre1 = Pre1 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
		Pre2 = 2306.2181 * T + 1.09468 * T * T + 0.018203 * T * T * T : Pre2 = Pre2 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
		Pre3 = 2004.3109 * T - 0.42665 * T * T - 0.041833 * T * T * T : Pre3 = Pre3 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
		A = System.Math.Cos(DE) * System.Math.Sin(AR + Pre1)
		B = System.Math.Cos(Pre3) * System.Math.Cos(DE) * System.Math.Cos(AR + Pre1) - System.Math.Sin(Pre3) * System.Math.Sin(DE)
		C = System.Math.Sin(Pre3) * System.Math.Cos(DE) * System.Math.Cos(AR + Pre1) + System.Math.Cos(Pre3) * System.Math.Sin(DE)
		D = System.Math.Atan(A / B) : If B < 0 Then D = D + Pi
		If D >= 2 * Pi Or D < 0 Then D = D - Int(D / (2 * Pi)) * 2 * Pi
		AR = D + Pre2 'radians
		DE = System.Math.Atan(C / (System.Math.Sqrt(-C * C + 1) + 9.999999E-21)) 'arcsin(C), radians
		'AR = AR * 180 / Pi
		'DE = DE * 180 / Pi
		
	End Sub
	Public Sub AberrationRADec()
		'Ecc comes from Sun
		PeriLo = 102.93735 + 1.71946 * T + 0.00046 * T * T 'Meeus pi in degrees
		PeriLo = PeriLo * Pi / 180 'in radians
		'Kappa = 20.49552" (/3600) = 0.0056932º
		AberrRA = -0.0056932 * (System.Math.Cos(AR) * System.Math.Cos(LN * Pi / 180) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Sin(AR) * System.Math.Sin(LN * Pi / 180)) / System.Math.Cos(DE) + Ecc * 0.0056932 * (System.Math.Cos(AR) * System.Math.Cos(PeriLo) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Sin(AR) * System.Math.Sin(PeriLo)) / System.Math.Cos(DE) 'degrees
		AberrDec = -0.0056932 * (System.Math.Cos(LN * Pi / 180) * System.Math.Cos(OETrue * Pi / 180) * (System.Math.Tan(OETrue * Pi / 180) * System.Math.Cos(DE) - System.Math.Sin(AR) * System.Math.Sin(DE)) + System.Math.Cos(AR) * System.Math.Sin(DE) * System.Math.Sin(LN * Pi / 180)) + Ecc * 0.0056932 * (System.Math.Cos(PeriLo) * System.Math.Cos(OETrue * Pi / 180) * (System.Math.Tan(OETrue * Pi / 180) * System.Math.Cos(DE) - System.Math.Sin(AR) * System.Math.Sin(DE)) + System.Math.Cos(AR) * System.Math.Sin(DE) * System.Math.Sin(PeriLo)) 'degrees
	End Sub
	Public Sub AberrationLB()
		'Ecc comes from Sun
		PeriLo = 102.93735 + 1.71946 * T + 0.00046 * T * T 'Meeus pi in degrees
		PeriLo = PeriLo * Pi / 180 'in radians
		'Kappa = 20.49552" (/3600) = 0.0056932º
		AberrL = (-0.0056932 * System.Math.Cos(LN * Pi / 180 - L1) + 0.0056932 * Ecc * System.Math.Cos(PeriLo - L1)) / System.Math.Cos(B) 'degrees
		AberrB = -0.0056932 * System.Math.Sin(B) * (System.Math.Sin(LN * Pi / 180 - L1) - Ecc * System.Math.Sin(PeriLo - L1)) 'degrees
	End Sub
	
	Public Sub BestBodies()
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
		'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'cmdTwilights_Click
		DisplayTwilights()
		IsMouseDown = True
		
		If optTwo.Checked = True Then
			Do While IsMouseDown
				SweepStep2 = SweepStep2 + WhichWay
				'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Scale 
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				BlankTimeFlag = False
				cmdTwilights_Click(cmdTwilights, New System.EventArgs())
				Sleep(92)
				DisplayView()
				System.Windows.Forms.Application.DoEvents()
			Loop 
		End If
		
		If optThreeBoat.Checked = True Or optThreeBeach.Checked = True Then
			Do While IsMouseDown
				SweepStep3 = SweepStep3 + WhichWay
				'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Me.Scale 
				'UPGRADE_ISSUE: Form method Form2.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls()
				BlankTimeFlag = False
				cmdTwilights_Click(cmdTwilights, New System.EventArgs())
				Sleep(92)
				DisplayView()
				System.Windows.Forms.Application.DoEvents()
			Loop 
		End If
		'UPGRADE_ISSUE: Form method Form2.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale 
	End Sub
	
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class