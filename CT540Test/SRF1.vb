Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Public Lat, ZN, Hc, LHA, TotDE As Double
	Public FlagMD, FlagSRFLoCNASR As Boolean
	Dim EstLoDeg, EstLDeg, EstL, DecimalDate, EstLo, EstLMin, EstLoMin As Double
	Dim DecDegrees As Short
	Dim DecMinutes As Double
	Dim Pressure, HEinFeet, HE, Temperature, DipShortDist As Double
	Dim hsinMinutes, ZD, Lo, ICinMinutes, hainMinutes As Double
	Dim MonthDays, DateOfSight, SignZD, fnumeral, MonthList As String
	Dim GDayOfYear, GMonth As Short
	Dim RA, Dec As Object
	Dim PlusCount, i As Short
	Dim DeltaT As Double
	Dim DecYr, Theta As Single 'Tdelta As Double, Theta As Double
	Dim E, L0, PM, LP, P0, DecLOC As Double
	Dim dHP, h3, H2, DSD, h4 As Double ',h4UL As Double, h4LL As Double,havg As Double
	Dim AR, Pi, SH, DE As Double
	Dim BN As Integer
	Dim DI, EA, NO, OE, NU, RN, AL As Double
	Dim GHAAriesMin, GHAAries, GHAAriesHour As Double
	Dim GHAAriesDeg As Short
	Dim TotGHA, GHA, GHAMin, TotGHAMin As Double
	Dim GHADeg, TotGHADeg As Short
	Dim LHADeg As Short
	Dim LHAMin As Double
    Dim RstdTP, Main_Renamed, Rstd, PX, GHAHour, GHAMinSec, TX, Raddl, Addl, RstdA2 As Double
    Dim BackSight As Boolean
	Dim r, HP, PA, HPA As Double
	Dim GHAHourDeg1, GHAHourDeg2 As Short
	Dim GHAHourMin1, GHAHourMin2 As Double ', GHAMinSecDeg As Integer, GHAMinSecMin As Double
	Dim y, x, S As Double
	Dim HG As Double
	Dim MA, TN, NL, M As Double
	Dim NY As Double
	Dim B, T, A, C, MS As Double
	Dim LN, HoinMinutes As Double
	Dim ZTinSeconds As Integer
	Dim ZTSeconds, ZTHours, ZTMinutes, WEinSeconds As Short
	Dim GHour As Short
	Dim WTinSeconds, GMinute, GSecond, ZTTemp As Integer
	Dim LocalYear, GYear, GDay, GYearJ, MonthNumber As Short
	Dim MonthatG As String
	Dim Corr1, Corr1Min As Double
	Dim Corr1Deg, DayNumber As Short
	Dim ZDinSeconds As Integer
	Dim HoDeg, Corr2Min, HoMin, D As Double
	Dim HD As String ', Hc As Double
	Dim HcDeg As Short
	Dim HsMin, HcMin, ICMin As Double
	Dim L8, L6, L4, L2, L1, L3, L5, L7, Z As Double
	Dim haDeg As Short
	Dim SHdeg, haMin, SHmin As Double
	Dim UTinSeconds As Integer
	Dim PC, LR, XM, PCmin As Double
	Dim XD, PCdeg As Short
	Dim PD2, Aug As Double
	Dim PL As String
	Public IU, II, IJ As Short
	Dim FZH(50) As Object
	Dim FZM(50) As Object
	Dim FZS(50) As Object
	Dim FMI(50) As Object
	Dim FZN(50) As Object 'this 19 variables, 50 better be enough
	Dim FLD(50) As Object
	Dim FLM(50) As Object
	Dim FL(50) As Object
	Dim FMD(50) As Object
	Dim FMM(50) As Object
	Dim FM(50) As Object
	Dim FZT(50) As Object
	Dim FUT(50) As Object
	Dim FD(50) As Object ', FA(50) As Variant
	Dim BF(50) As Object ', FIU(50) As Variant
	Dim FLA(50) As Object
	Dim FLo(50) As Object
	Public FixData4, FixData2, FixData1, FixData3, FixData5 As Object
	Public FixData9, FixData7, FixData6, FixData8, FixData10 As Object
	Public FixData11, FixData12 As Object
	Dim IV, IW As Short
	Dim THour1, DecimalDateHour1, DecimalDateHour2, THour2 As Double
	Dim PCorr, Pola0min, Pola2, Pola0, Pola1, Pola0deg, LbyPol, LforPol As Double
	Dim Ldiff, ldiffMin As Double
	Dim ldiffDeg As Short
	Dim LHAPol, TotGHAPol, TotGHAPolMin, LHAPolMin As Double
	Dim TotGHAPolDeg, LHAPolDeg As Short
	Dim MeanSHAPol, MeanDecPol As Double
	Dim MonthPolaris As Short
	Dim LeapYear, GLeapYear As Boolean
	Dim DayG(12) As Short
	Dim EqTinSeconds As Integer
	Dim EqTminutes, EqTseconds As Single
	Dim DateError As Boolean
	Dim HourChange, vvalue As Double
	Dim vcorr, k, GHAIncrement, GHAIncrementMin As Double
	Dim GHAIncrementDeg As Short
	Dim dvalue, DE1, DE2, dcorr As Double
	Dim Signdvalue, SignHourChange As Short
	Dim Lendcorr, TotDecDegrees, Lenvcorr, LenCorr2Min As Short
	Dim TotDecMinutes As Double
	Dim Intercept, GHAHour1, GHAHour2, L As Double
	Dim PMRA, PMDec As Object
	Dim AberrL, Ecc, PeriLo, AberrB As Double
	Dim Pre2, JDHour2, JDHour, JD, JDHour1, Pre1, Pre3 As Double
	Dim AberrRA, NutRA, NutDec, AberrDec As Double
	Dim OETrue, Tfull As Double
	Dim MSinA, MMprimeA, MDA, MMA, MFA, MCosA As Object
	Dim MFB, MMB, MDB, MMprimeB, MSinB As Object
	Dim A2, MF, MM, MLprime, MD, MMprime, A1, A3 As Double
	Dim r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau As Double
	Dim NutF, NutM, NutD, NutMprime, NutOmega As Double
	Dim NCos, NSin, NF, NM, ND, NMprime, NOmega, NSinT, NCosT As Object
	Dim TFK5, DecDegrees2, DecMinutes2, Lprime As Double ', L0Sun As Double
	Dim LMin, LoMin As String
	Dim SunHourChange, SunGHACorr As Double
	Dim Corr2forParallax As Double
	Dim StarDayNumber As Short
	Dim StarNAFlag As Boolean
	Dim SHminDisplay, SHdegDisplay, DENA As Double
	Dim FlagPlanets As Boolean
	Dim DENA1, DENA2 As Double 'vvalueP As Double, dvalueP As Double, SigndvalueP As Integer
	
	'UPGRADE_WARNING: Event cboBody.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboBody_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBody.SelectedIndexChanged
		If cboBody.Text = "Polaris" Then
			cboPolaris.Visible = True
			'cboPolaris.Enabled = True
			cboSun.Visible = False
			cboStars.Visible = False
			cboPlanets.Visible = False
		End If
		If cboBody.Text = "Sun L.L." Or cboBody.Text = "Sun U.L." Then
			cboSun.Visible = True
			'cboSun.Enabled = True
			cboPolaris.Visible = False
			cboStars.Visible = False
			cboPlanets.Visible = False
		End If
		If cboBody.Text <> "Polaris" And cboBody.Text <> "Sun L.L." And cboBody.Text <> "Sun U.L." Then
			cboPolaris.Visible = False
			'cboPolaris.Enabled = False
			cboSun.Visible = False
			'cboSun.Enabled = False
			cboStars.Visible = False
			cboPlanets.Visible = False
			lblDRL.Visible = True
			txtLDeg.Visible = True
			'txtLDeg.Enabled = True
			lblLDeg.Visible = True
			txtLMin.Visible = True
			'txtLMin.Enabled = True
			lblLMin.Visible = True
			cboL.Visible = True
			'cboL.Enabled = True
			If cboBody.Text <> "Polaris" Then cboPolaris.Text = "Latitude by altitude of Polaris"
		End If
		If cboBody.Text <> "Polaris" And cboBody.Text <> "Sun L.L." And cboBody.Text <> "Sun U.L." And cboBody.Text <> "Moon L.L." And cboBody.Text <> "Moon U.L." And cboBody.Text <> "Venus" And cboBody.Text <> "Mars" And cboBody.Text <> "Jupiter" And cboBody.Text <> "Saturn" Then 'stars othr than Polaris
			cboPolaris.Visible = False
			'cboPolaris.Enabled = True
			cboSun.Visible = False
			cboStars.Visible = True
			cboPlanets.Visible = False
		End If
        If cboBody.Text = "Venus" Or cboBody.Text = "Mars" Or cboBody.Text = "Jupiter" Or cboBody.Text = "Staurn" Then
            cboPolaris.Visible = False
            'cboPolaris.Enabled = True
            cboSun.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = True
        End If
        BN = cboBody.SelectedIndex
        BN = GetItemData(cboBody, cboBody.SelectedIndex)
        If BN >= 62 And BN <= 65 And optHorizonArtificial.Checked = True Then chkAH.Visible = True Else chkAH.Visible = False
	End Sub
	
	'UPGRADE_WARNING: Event cboLo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
		AutoZDCalc()
	End Sub
	
	'UPGRADE_WARNING: Event cboMonth.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Public Sub cboMonth_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMonth.SelectedIndexChanged
		CheckDate()
	End Sub
	
	'UPGRADE_WARNING: Event cboPolaris.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboPolaris_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPolaris.SelectedIndexChanged
		'If cboBody.Text = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" Then
		'    lblDRL.Visible = False
		'    txtLDeg.Visible = False
		'    txtLDeg.Enabled = False
		'    lblLDeg.Visible = False
		'    txtLMin.Visible = False
		'    txtLMin.Enabled = False
		'    lblLMin.Visible = False
		'    cboL.Visible = False
		'    cboL.Enabled = False
		'End If
		If cboBody.Text <> "Polaris" Or cboPolaris.Text <> "Latitude by altitude of Polaris" Then
			lblDRL.Visible = True
			txtLDeg.Visible = True
			'txtLDeg.Enabled = True
			lblLDeg.Visible = True
			txtLMin.Visible = True
			'txtLMin.Enabled = True
			lblLMin.Visible = True
			cboL.Visible = True
			'cboL.Enabled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cboPressure.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboPressure_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPressure.SelectedIndexChanged
		If cboPressure.Text = "in Hg" Then txtPressure.Text = "29.83"
		If cboPressure.Text = "mbar" Then txtPressure.Text = "1010"
		txtPressure_TextChanged(txtPressure, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cboTemperature.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTemperature_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemperature.SelectedIndexChanged
		If cboTemperature.Text = "F " Then txtTemperature.Text = "50"
		If cboTemperature.Text = "C " Then txtTemperature.Text = "10"
		txtTemperature_TextChanged(txtTemperature, New System.EventArgs())
	End Sub
	
	'Private Sub cmdApparentSun_Click()
	'    If BN = 64 Or BN = 65 Then _
	''        Line (0, 0)-(700 * Cos((LHA + 90) * Pi / 180), 700 * Sin((LHA + 90) * Pi / 180)): _
	''        DrawStyle = 5: _
	''        Line (0, 0)-(850 * Cos((LHA + 90) * Pi / 180), 850 * Sin((LHA + 90) * Pi / 180)): _
	''        CurrentY = CurrentY + 100: _
	''        Print "S"   'Print "O"
	'    DrawStyle = 0
	'End Sub
	
	Private Sub cmdEqT_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdEqT.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5 'or else JD incorrect for planets
		
		'Mean Sun for sun sight
		If BN = 64 Or BN = 65 Then
			Sun()
			HourAngles()
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((-Lo - 90 + HG * 15) * Pi / 180), 700 * System.Math.Sin((-Lo - 90 + HG * 15) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((-Lo - 90 + HG * 15) * Pi / 180), 850 * System.Math.Sin((-Lo - 90 + HG * 15) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("O")
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
		End If
		
		T = Tfull
		'Apparent sun for all sights except sun
		If BN <= 63 Then
			BN = 64
			Sun()
			HourAngles()
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((LHA + 90) * Pi / 180), 700 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((LHA + 90) * Pi / 180), 850 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("o")
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
		End If
		'Get LHA Sun for EqT
		BN = 64
		Sun()
		HourAngles()
		'If GHA < 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds - 43200) '43200 is 12 hours in seconds
		'If GHA >= 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds + 43200) '43200 is 12 hours in seconds
		EqTinSeconds = GHA * 240 - UTinSeconds
		Do While System.Math.Abs(EqTinSeconds) >= 1020 '17 minutes
			If EqTinSeconds >= 0 Then
				EqTinSeconds = EqTinSeconds - 43200 '43200 is 12 hours in second
				If EqTinSeconds < 0 Then Exit Do
			End If
			If EqTinSeconds < 0 Then
				EqTinSeconds = EqTinSeconds + 43200 '43200 is 12 hours in seconds
				If EqTinSeconds >= 0 Then Exit Do
			End If
		Loop 
		EqTminutes = Int(System.Math.Abs(EqTinSeconds / 60))
		EqTseconds = System.Math.Abs(EqTinSeconds) - EqTminutes * 60
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = -800
		'UPGRADE_ISSUE: Form property Form1.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentX = -1300
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(EqTinSeconds) = 1 Then Print("(+)")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(EqTinSeconds) = 0 Then Print("   ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(EqTinSeconds) = -1 Then Print("(-)")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(EqTminutes, "00") & "m" & VB6.Format(EqTseconds, "00") & "s")
	End Sub
	Private Sub cmdEqT_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdEqT.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'    If BN = 64 Or BN = 65 Then _
		''        DrawStyle = 5: _
		''        Line (0, 0)-(700 * Cos((LHA + 90) * Pi / 180), 700 * Sin((LHA + 90) * Pi / 180)): _
		''        Line (0, 0)-(850 * Cos((LHA + 90) * Pi / 180), 850 * Sin((LHA + 90) * Pi / 180)): _
		''        CurrentY = CurrentY + 100: _
		''        Print "S"   'Print "O"
		'    DrawStyle = 0
		cmdReduce_Click(cmdReduce, New System.EventArgs())
	End Sub
	
	Public Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
		Form4.Check1.Visible = False : Form4.Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check2.Visible = False : Form4.Check2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check3.Visible = False : Form4.Check3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check4.Visible = False : Form4.Check4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check5.Visible = False : Form4.Check5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check6.Visible = False : Form4.Check6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check7.Visible = False : Form4.Check7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check8.Visible = False : Form4.Check8.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check9.Visible = False : Form4.Check9.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check10.Visible = False : Form4.Check10.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check11.Visible = False : Form4.Check11.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Check12.Visible = False : Form4.Check12.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form4.Show()
		If IU > 1 Then Form4.Check1.Visible = True : Form4.Check2.Visible = True ': Form4.Check2.Enabled = True
		If IU > 2 Then Form4.Check3.Visible = True ': Form4.Check3.Enabled = True
		If IU > 3 Then Form4.Check4.Visible = True ': Form4.Check4.Enabled = True
		If IU > 4 Then Form4.Check5.Visible = True ': Form4.Check5.Enabled = True
		If IU > 5 Then Form4.Check6.Visible = True ': Form4.Check6.Enabled = True
		If IU > 6 Then Form4.Check7.Visible = True ': Form4.Check7.Enabled = True
		If IU > 7 Then Form4.Check8.Visible = True ': Form4.Check8.Enabled = True
		If IU > 8 Then Form4.Check9.Visible = True ': Form4.Check9.Enabled = True
		If IU > 9 Then Form4.Check10.Visible = True ': Form4.Check10.Enabled = True
		If IU > 10 Then Form4.Check11.Visible = True ': Form4.Check11.Enabled = True
		If IU > 11 Then Form4.Check12.Visible = True ': Form4.Check12.Enabled = True
		If IU > 12 Then i = IU + 12
		WriteFixScreen()
		FixData()
	End Sub
	
	Public Sub cmdMerDiag_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMerDiag.Click
		FlagMD = True
		Form8.FlagMD = False
		Form22.Show()
		Form22.DisplayMerDiag()
		cmdMerDiag.Enabled = False
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
	
	Private Sub cmdReduce_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReduce.Click
		FlagSRFLoCNASR = True : Form8.FlagSRFLoCNASR = False
		DateError = False
		CheckDate()
		If DateError = True Then DateError = False : Exit Sub
		If cboIE.Text = "off the arc (rdg.)" And Val(txtIEdeg.Text) = 0 Then MsgBox("For IE off the arc (rdg.), degree value cannot be zero.") : Exit Sub
		If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
			With txtDsDist
				.Focus()
			End With
			MsgBox("You must enter a non-zero value for Ds distance")
			Exit Sub
		End If
		'    If cboBody = "" Then
		'        With cboBody
		'            .SetFocus
		'        End With
		'        MsgBox ("You must select a body.")
		'        Exit Sub
		'    End If
		'UPGRADE_ISSUE: Form method Form1.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale  'Puts (0,0) back at upper left after rescaling for Time Diagram
		'On Error GoTo ErrorHandler
		If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
			txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			'cboTemperature.BackColor = &HFF&
			MsgBox("Out of Range")
		End If
		If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
			txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			'cboTemperature.BackColor = &HFF&
			MsgBox("Out of Range")
		End If
		If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 28 Or Val(txtPressure.Text) > 32) Then
			txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			'cboPressure.BackColor = &HFF&
			MsgBox("Out of Range")
		End If
		If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
			txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			'cboPressure.BackColor = &HFF&
			MsgBox("Out of Range")
		End If
		'BN is Body Number
		BN = VB6.GetItemData(cboBody, cboBody.SelectedIndex)
		If (BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris") Then
			LatByPolaris()
			If HoinMinutes > 4139.9 Then
				MsgBox("Approximate latitude exceeds range of Nautical Almanac Polaris Tables.  Calculation aborted.")
				'UPGRADE_ISSUE: Form method Form1.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Cls() : Exit Sub
			End If
			LatByPolaris() 'need to do LatByPolaris twice to make it work
			Exit Sub
		End If
		'next line added sun stuff in V5.3.1
		StarNAFlag = False : If (BN <= 57 And cboStars.Text = "NA vals. of SHA/Dec") Or (BN > 57 And BN < 62 And cboPlanets.Text = "NA vals. of v/d") Or (BN = 64 Or BN = 65 And cboSun.Text = "NA val. of hourly GHA/d") Then StarNAFlag = True 'is "BN > 57 And BN < 62 And" needed?
		
		
		If StarNAFlag = True Then '1st pass for 12h of middle day
			LatLong()
			ZoneTime()
			Greenwich()
			Delta_T()
			Julian()
			If BN <= 57 Then
				Stars()
				'DE1 = DENA
				DENA = DE
				HourAngles()
			End If
			If (BN > 57 And BN < 62) Or BN = 64 Or BN = 65 Then
				T = THour1 : JDHour = JDHour1
				Nutation()
				Obliquity()
				JD = JDHour1
				If (BN > 57 And BN < 62) Then Planets()
				If (BN = 64 Or BN = 65) Then Sun()
				'DE1 = DENA
				DENA1 = DE
				HourAnglesHour() : GHAHour1 = GHAHour
				If (BN > 57 And BN < 62) Then FlagPlanets = True
				Greenwich()
				Delta_T()
				Julian()
				T = THour2 : JDHour = JDHour2
				Nutation()
				Obliquity()
				JD = JDHour2
				If (BN > 57 And BN < 62) Then Planets()
				If (BN = 64 Or BN = 65) Then Sun()
				'DE1 = DENA
				DENA2 = DE
				HourAnglesHour() : GHAHour2 = GHAHour
				IandC()
				''            vvalueP = vvalue
				''            dvalueP = dvalue
				If (BN > 57 And BN < 62) Then FlagPlanets = False
			End If
		End If
		
		StarNAFlag = False '2nd pass for date and time of sight
		LatLong()
		ZoneTime()
		Greenwich()
		Delta_T()
		Julian()
		If BN <= 57 Then
			Stars()
			DE1 = DE
			HourAngles()
		End If
		
		'Make StarNAFlag true again if necc.
		If (BN <= 57 And cboStars.Text = "NA vals. of SHA/Dec") Or (BN > 57 And BN < 62 And cboPlanets.Text = "NA vals. of v/d") Or (BN = 64 Or BN = 65 And cboSun.Text = "NA val. of hourly GHA/d") Then StarNAFlag = True
		
		'all bodies; does Aries for stars
		T = THour1 : JDHour = JDHour1
		Nutation()
		Obliquity()
		If BN = 62 Or BN = 63 Then Moon() : If GMinute < 30 Then HPA = HP 'This is for nearest whole hour 'HPA = HP without GMinute<30 for using previous whole hour
		If BN = 64 Or BN = 65 Then Sun()
		If BN > 57 And BN < 62 Then JD = JDHour1 : Planets()
		DE1 = DE
		HourAnglesHour()
		GHAHour1 = GHAHour
		'not for stars
		If BN > 57 Then
			T = THour2 : JDHour = JDHour2
			Nutation()
			Obliquity()
			If BN = 62 Or BN = 63 Then Moon() : If GMinute >= 30 Then HPA = HP 'This is for nearest whole hour
			If BN = 64 Or BN = 65 Then Sun()
			If BN > 57 And BN < 62 Then JD = JDHour2 : Planets()
			
			DE2 = DE
			HourAnglesHour()
			GHAHour2 = GHAHour
		End If
		
		If (BN = 64 Or BN = 65) And cboSun.Text = "NA val. of hourly GHA" Then 'for Nautical Almanac value of hourly GHA of Sun
			SunHourChange = GHAHour2 - GHAHour1
			If SunHourChange < 0 Then SunHourChange = SunHourChange + 360
			SunGHACorr = (15 - SunHourChange) / 2
			GHAHour1 = GHAHour1 - SunGHACorr
			GHAHourDeg1 = Int(GHAHour1) : GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60 : GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
			If GHAHourMin1 = 60 Then GHAHourMin1 = 0 : GHAHourDeg1 = GHAHourDeg1 + 1
			TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
			TotGHADeg = Int(TotGHA) : TotGHAMin = (TotGHA - TotGHADeg) * 60
			TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
			If TotGHAMin = 60 Then TotGHAMin = 0 : TotGHADeg = TotGHADeg + 1
			If TotGHADeg >= 360 Then TotGHADeg = TotGHADeg - 360
			LHA = TotGHADeg + TotGHAMin / 60 - Lo
			If LHA >= 360 Then LHA = LHA - 360
			If LHA < 0 Then LHA = LHA + 360
			LHADeg = Int(LHA) : LHAMin = (LHA - LHADeg) * 60
			If Int(LHAMin * 10 + 0.5) / 10 = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
		End If
		
		'IandC
		If (BN <= 57 Or BN >= 62) Or (BN > 57 And BN < 62 And cboPlanets.Text = "Accurate vals. of v/d") Then IandC()
		If BN > 57 And BN < 62 And cboPlanets.Text = "NA vals. of v/d" Then IandCP()
		'Parallax PA removed from AltitudeCorrection and done here in case Parameters is done before SR Form
		AltitudeCorrection()
		If BN <> 62 And BN <> 63 Then HPA = HP
		'LawOfCosines
		'PA = HPA * Cos(Hc * Pi / 180)
		'PA = HPA * Cos((hainMinutes / 60) * Pi / 180)
		PA = HPA * System.Math.Cos(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) 'the next three lines are approximated by this
		'x = Sin((HPA / 60) * Pi / 180) * Cos((hainMinutes / 60) * Pi / 180)
		'PA = Atn(x / (Sqr(-x * x + 1) + 9.999999E-21))  'arcsin, radians
		'PA = PA * 60 * 180 / Pi
		AltitudeCorrection() 'this is needed if Parameters done first
		LawOfCosines()
		If BN = 62 Or BN = 63 Then 'Moon
			'Oblateness of Earth correction for Moon parallax
			''PA = PA - 0.102 * Cos((hainMinutes / 60) * Pi / 180) 'simplified oblateness correction good for mid-latitudes, altitude <60 degrees
			'PA = PA + (1 / 298.257) * HPA * (Sin(2 * Lat * Pi / 180) * Cos(ZN * Pi / 180) * Sin((hainMinutes / 60) * Pi / 180) - Sin(Lat * Pi / 180) * Sin(Lat * Pi / 180) * Cos((hainMinutes / 60) * Pi / 180))    'Umland
			'PA = PA - HPA * Sin(Lat * Pi / 180) * Sin(Lat * Pi / 180) / 298.3     'Navsoft
			PA = PA - 0.192 * System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(Lat * Pi / 180) * System.Math.Cos(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) + 0.192 * System.Math.Sin(2 * Lat * Pi / 180) * System.Math.Cos(ZN * Pi / 180) * System.Math.Sin(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) 'Nautical Almanac formula
			'    AltitudeCorrection 'for Moon do again with value of Zn for oblateness correction
			If PA < 0 Then PA = 0
			LawOfCosines() 'in case oblateness made a difference
		End If
		
		EstimatedPosition()
		DisplaySR()
		DisplayLOC() : cmdSave.Visible = True : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
		Exit Sub 'this seems to be needed
	End Sub
	
	Public Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		II = II + 1 : IU = IU + 1 ': If II > 10 Then II = II - Int(II / 10) * 10
		If IU > 1 Then cmdFix.Visible = True ': cmdFix.Enabled = True
		'UPGRADE_WARNING: Couldn't resolve default property of object FZT(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZT(II) = ZTTemp
		'UPGRADE_WARNING: Couldn't resolve default property of object FZH(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZH(II) = ZTHours
		'UPGRADE_WARNING: Couldn't resolve default property of object FZM(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZM(II) = ZTMinutes
		'UPGRADE_WARNING: Couldn't resolve default property of object FZS(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZS(II) = ZTSeconds
		'UPGRADE_WARNING: Couldn't resolve default property of object FUT(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FUT(II) = UTinSeconds
		'FMI(II) = Intercept: 'FA(II) = -(60 * MI)
		'UPGRADE_WARNING: Couldn't resolve default property of object FMI(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FMI(II) = System.Math.Sign(Intercept) * Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 'changed in V4.0.0
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FD(II) = "T"
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Intercept > 0 Then FD(II) = "A"
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Intercept = 0 Then FD(II) = " "
		'FZN(II) = ZN: 'FIU(II) = IU
		'UPGRADE_WARNING: Couldn't resolve default property of object FZN(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZN(II) = Int(ZN + 0.5) 'changed in V4.0.0
		'UPGRADE_WARNING: Couldn't resolve default property of object BF(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BF(II) = cboBody.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FL(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FL(II) = Lat
		'UPGRADE_WARNING: Couldn't resolve default property of object FLD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FLD(II) = txtLDeg.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FLM(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FLM(II) = txtLMin.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FLA(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FLA(II) = cboL.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FLo(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FLo(II) = Lo
		'UPGRADE_WARNING: Couldn't resolve default property of object FMD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FMD(II) = txtLoDeg.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FMM(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FMM(II) = txtLoMin.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FM(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FM(II) = cboLo.Text
		cmdSave.Visible = False
		'cmdSave.Enabled = False
	End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		Pi = 4 * System.Math.Atan(1#)
		II = 0 : IU = 0
		txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
		cboZDm.SelectedIndex = 0 ' "00"
		
		
		
		'RA is Right Ascension hours of stars
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RA = New Object(){2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065, 4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679, 7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617, 12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587, 14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901, 18.92109048, 19.84638861, 20.42846051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827}
		'Dec is Declination degrees of stars
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Dec = New Object(){89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959, 16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374, 5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947, -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818, 74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918, -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
		
		
		
		'Proper motion right ascension in seconds/century
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PMRA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PMRA = New Object(){22.9526, 1.0351, 2.0982, 0.6089, 1.6317, 1.0843, 1.3861, -0.468, -0.0789, 0.2493, 0.4365, 0.0126, 0.7247, -0.0587, 0.1768, 0.0099, 0.1837, 0.2199, -3.8007, 0.02, -4.797, -4.7254, -0.3329, -0.2131, -3.032, -0.0977, -1.6996, -1.9221, -3.4374, -1.1158, -0.5212, 0.3431, 1.3308, -0.2888, -1.2397, -0.458, -4.2995, -7.718, -50.3145, -0.7331, -0.7884, 0.8984, -0.0756, 0.3325, 0.2851, -0.0744, 0.7519, -0.0912, -0.32, 1.7192, 0.1031, 3.6221, 0.0937, 0.0148, 0.2031, 1.2464, 2.5248, 0.4221}
		'Proper motion declination in arcseconds/century
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PMDec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PMDec = New Object(){-1.1746, -16.295, -35.3638, -3.217, 3.2711, -4.0079, -14.5771, 2.571, -7.876, -2.601, -18.936, -0.056, -42.713, -1.328, -17.422, -0.106, 1.086, 2.367, -122.3076, 0.229, -103.4582, -4.5959, 2.272, 1.428, 10.8913, 3.325, 0.4909, -3.5251, 11.3783, 2.231, -1.473, -26.433, -0.8991, -3.173, -1.5561, -2.506, -51.7862, -199.9418, 48.2868, -6.9, 1.191, -8.944, -2.321, -3.292, 9.765, -2.995, -22.261, -2.305, -12.405, 28.7459, -5.265, 38.5538, -8.615, 0.155, 0.138, -14.7909, -16.4217, -4.256}
		
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
		
	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		cboDay.SelectedIndex = VB.Day(Today) - 1 '-1 because ListIndex starts with 0
		MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec"
		cboMonth.Text = Mid(MonthList, 3 * Val(CStr(Month(Today))) - 2, 3)
		txtYear.Text = CStr(Year(Today))
		cboPolaris.SelectedIndex = 0 '"Latitude by altitude of Polaris"
		cboSun.SelectedIndex = 0 '"NA val. of hourly GHA"
		cboStars.SelectedIndex = 0 '"NA val. of SHA and Dec"
		cboPlanets.SelectedIndex = 0 'NA val. of v/d
		cboWE.SelectedIndex = 0 '"fast"
		cboL.SelectedIndex = 0 '"N "
		cboLo.SelectedIndex = 0 '"W "
		cboIE.SelectedIndex = 0 '"on the arc"
		cboHE.SelectedIndex = 0 '"ft"
		cboDsUnit.SelectedIndex = 1 '"yards"
		cboTemperature.SelectedIndex = 0 '"F "
		cboPressure.SelectedIndex = 0 '"in Hg"
		cboBody.SelectedIndex = 61 '"Sun L.L."
	End Sub
	
	Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event optHoParameters.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHoParameters_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoParameters.CheckedChanged
		If eventSender.Checked Then
			cmdReduce_Click(cmdReduce, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonArtificial.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonArtificial_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonArtificial.CheckedChanged
		If eventSender.Checked Then
			If optHorizonArtificial.Checked = True Then
				lblHE.Visible = False
				txtHE.Visible = False
				'txtHE.Enabled = False
				cboHE.Visible = False
				'cboHE.Enabled = False
				lblDsDist.Visible = False
				txtDsDist.Visible = False
				'txtDsDist.Enabled = False
				cboDsUnit.Visible = False
				'cboDsUnit.Enabled = False
				BN = VB6.GetItemData(cboBody, cboBody.SelectedIndex)
				If BN >= 62 And BN <= 65 Then chkAH.Visible = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonDipShort.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonDipShort_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonDipShort.CheckedChanged
		If eventSender.Checked Then
			If optHorizonDipShort.Checked = True Then
				lblHE.Visible = True
				txtHE.Visible = True
				'txtHE.Enabled = True
				cboHE.Visible = True
				'cboHE.Enabled = True
				lblDsDist.Visible = True
				txtDsDist.Visible = True
				'txtDsDist.Enabled = True
				cboDsUnit.Visible = True
				'cboDsUnit.Enabled = True
			End If
			chkAH.Visible = False
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonNatural.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonNatural_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonNatural.CheckedChanged
		If eventSender.Checked Then
			If optHorizonNatural.Checked = True Then
				lblHE.Visible = True
				txtHE.Visible = True
				'txtHE.Enabled = True
				cboHE.Visible = True
				'cboHE.Enabled = True
				lblDsDist.Visible = False
				txtDsDist.Visible = False
				'txtDsDist.Enabled = False
				cboDsUnit.Visible = False
				'cboDsUnit.Enabled = False
			End If
			chkAH.Visible = False
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHoSRForm.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHoSRForm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoSRForm.CheckedChanged
		If eventSender.Checked Then
			cmdReduce_Click(cmdReduce, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHsDMm.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
		If eventSender.Checked Then
			If optHsDMm.Checked = True Then
				txtHsSec.Visible = False
				lblHsSec.Visible = False
				'txtHsSec.Enabled = False
				txtIESec.Visible = False
				lblIEsec.Visible = False
				'txtIESec.Enabled = False
				txtHsMin.Text = ""
				txtIEmin.Text = ""
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHsDMS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
		If eventSender.Checked Then
			If optHsDMS.Checked = True Then
				txtHsSec.Visible = True
				lblHsSec.Visible = True
				'txtHsSec.Enabled = True
				txtIESec.Visible = True
				lblIEsec.Visible = True
				'txtIESec.Enabled = True
				txtHsMin.Text = ""
				txtIEmin.Text = ""
				txtHsSec.Text = ""
				txtIESec.Text = ""
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optStdTPYes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optStdTPYes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStdTPYes.CheckedChanged
		If eventSender.Checked Then
			lblTemperature.Visible = False
			txtTemperature.Visible = False
			lblTempDeg.Visible = False
			cboTemperature.Visible = False
			'cboTemperature.Enabled = False
			lblPressure.Visible = False
			txtPressure.Visible = False
			cboPressure.Visible = False
			'cboPressure.Enabled = False
			txtTemperature.Text = "50"
			cboTemperature.SelectedIndex = 0 '"F "
			txtPressure.Text = "29.83"
			cboPressure.SelectedIndex = 0 '"in Hg"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optStdTPNo.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optStdTPNo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStdTPNo.CheckedChanged
		If eventSender.Checked Then
			lblTemperature.Visible = True
			txtTemperature.Visible = True
			lblTempDeg.Visible = True
			cboTemperature.Visible = True
			'cboTemperature.Enabled = True
			lblPressure.Visible = True
			txtPressure.Visible = True
			cboPressure.Visible = True
			'cboPressure.Enabled = True
		End If
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
	
	'UPGRADE_WARNING: Event cboDay.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Public Sub cboDay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDay.SelectedIndexChanged
		'txtDay.ForeColor = &H80000008
		'txtDay.BackColor = &H80000005
		'If Val(txtDay.Text) > 31 Then
		'    txtDay.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
		CheckDate()
	End Sub
	
	
	
	
	
	'Public Sub txtDay_KeyPress(KeyAscii As Integer)
	'Select Case KeyAscii
	'     Case Asc("0")
	'         If Len(txtDay.Text) = 0 Then
	'             KeyAscii = 0
	'             Beep
	'         Else
	'             fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'         End If
	'     Case Asc("1") To Asc("9")
	'         fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'     Case Asc(Chr$(8))
	'         fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'     Case Else
	'         KeyAscii = 0
	'         Beep
	' End Select
	'End Sub
	
	Private Sub txtDsDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDsDist.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtDsDist.Text, ".") Then
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
	Private Sub txtDsDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDsDist.Enter
		SelectAllText(txtDsDist)
	End Sub
	Private Sub txtHE_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHE.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtHE.Text, ".") Then
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
	Private Sub txtHE_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHE.Enter
		SelectAllText(txtHE)
	End Sub
	
	'UPGRADE_WARNING: Event txtHsDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
		'txtHsDeg.ForeColor = &H80000008
		txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtHsDeg.Text) > 145 Then
			txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtHsDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsDeg.KeyPress
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
	
	Private Sub txtHsDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHsDeg.Text) > 145 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHsDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.Enter
		SelectAllText(txtHsDeg)
	End Sub
	'UPGRADE_WARNING: Event txtHsMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHsMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.TextChanged
		'txtHsMin.ForeColor = &H80000008
		txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
			txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
			txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtHsMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If optHsDMS.Checked = True Then
					KeyAscii = 0
					Beep()
				Else
					If InStr(txtHsMin.Text, ".") Then
						If KeyAscii = 46 Then KeyAscii = 0 : Beep()
					End If
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
	
	Private Sub txtHsMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHsMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.Enter
		SelectAllText(txtHsMin)
	End Sub
	'UPGRADE_WARNING: Event txtHsSec.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHsSec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.TextChanged
		'txtHsSec.ForeColor = &H80000008
		txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtHsSec.Text) > 59 Then
			txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtHsSec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsSec.KeyPress
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
	
	Private Sub txtHsSec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsSec.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHsSec.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHsSec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.Enter
		SelectAllText(txtHsSec)
	End Sub
	'UPGRADE_WARNING: Event txtIEdeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtIEdeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.TextChanged
		'This is not really necessary since only one digit is allowed
		'txtIEdeg.ForeColor = &H80000008
		txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtIEdeg.Text) > 9 Then
			txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtIEdeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEdeg.KeyPress
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
	
	Private Sub txtIEdeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEdeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'This is not really necessary since only one digit is allowed
		If Val(txtIEdeg.Text) > 9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtIEDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEDeg.Enter
		SelectAllText(txtIEdeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtIEmin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtIEmin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.TextChanged
		'txtIEmin.ForeColor = &H80000008
		txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If optHsDMm.Checked = True And Val(txtIEmin.Text) > 59.9 Then
			txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
			txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtIEmin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.Enter
		SelectAllText(txtIEmin)
	End Sub
	
	Private Sub txtIEmin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEmin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If optHsDMS.Checked = True Then
					KeyAscii = 0
					Beep()
				Else
					If InStr(txtIEmin.Text, ".") Then
						If KeyAscii = 46 Then KeyAscii = 0 : Beep()
					End If
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
	
	Private Sub txtIEmin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEmin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If optHsDMm.Checked = True And Val(txtIEmin.Text) > 59.9 Then
			KeepFocus = True
		End If
		If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	
	'UPGRADE_WARNING: Event txtIESec.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtIESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.TextChanged
		'txtIESec.ForeColor = &H80000008
		txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtIESec.Text) > 59 Then
			txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtIESec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIESec.KeyPress
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
	
	Private Sub txtIESec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIESec.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtIESec.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtIESec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.Enter
		SelectAllText(txtIESec)
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
	
	Private Sub txtSightNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSightNo.KeyPress
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
	Private Sub txtSightNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSightNo.Enter
		SelectAllText(txtSightNo)
	End Sub
	
	'UPGRADE_WARNING: Event txtWEMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWEMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWEMin.TextChanged
		'This is unnecessary
		'txtWEMin.ForeColor = &H80000008
		txtWEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtWEMin.Text) > 9 Then
			txtWEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtWEMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWEMin.KeyPress
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
	Private Sub txtWEMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWEMin.Enter
		SelectAllText(txtWEMin)
	End Sub
	
	Private Sub txtMin_Change()
		
	End Sub
	
	'UPGRADE_WARNING: Event txtPressure.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPressure_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.TextChanged
		'txtPressure.ForeColor = &H80000008
		txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'If (cboPressure.Text = "in Hg" And Len(txtPressure.Text) < 2) Or _
		''    (cboPressure.Text = "mbar" And Len(txtPressure.Text) < 3) Then
		'        Exit Sub
		'End If
		If cboPressure.Text = "in Hg" And ((Val(txtPressure.Text) < 28 Or Val(txtPressure.Text) > 32)) And Len(txtPressure.Text) >= 2 Then
			txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		
		'If cboPressure.Text = "mbar" And Left$(txtPressure.Text, 1) <> "1" And _
		''    Left$(txtPressure.Text, 1) <> "9" Then
		'        txtPressure.BackColor = &HFF&
		'        MsgBox "OutofRange"
		'End If
		'If cboPressure.Text = "mbar" And Left$(txtPressure.Text, 1) = "1" And _
		''    Len(txtPressure.Text) >= 4 And Val(txtPressure.Text) > 1100 Then
		'        txtPressure.BackColor = &HFF&
		'        MsgBox "OutofRange"
		'End If
		'If cboPressure.Text = "mbar" And Left$(txtPressure.Text, 1) = "9" And _
		''    Len(txtPressure.Text) = 3 And Val(txtPressure.Text) < 950 Then
		'        txtPressure.BackColor = &HFF&
		'        MsgBox "OutofRange"
		'End If
		
		'    If optStdTPYes = True Then cboPressure.text = "in Hg"
		
		If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) And Len(txtPressure.Text) >= 4 And optStdTPNo.Checked = True Then 'optStdTPNo = True added for bug going back to standard
			txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtPressure_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPressure.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		'If cboPressure.Text = "mbar" And (Left$(txtPressure.Text, 1) <> "1" And Left$(txtPressure.Text, 1) <> "9") Then
		'    KeyAscii = 0
		'    Beep
		'End If
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If cboPressure.Text = "mbar" Then
					KeyAscii = 0
					Beep()
				End If
				If InStr(txtPressure.Text, ".") Then
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
	
	'Private Sub txtPressure_Validate(KeepFocus As Boolean)
	'    If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 26 Or Val(txtPressure.Text) > 32) Then
	'        KeepFocus = True
	'    End If
	'    If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
	'        KeepFocus = True
	'    End If
	'End Sub
	Private Sub txtPressure_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.Enter
		SelectAllText(txtPressure)
	End Sub
	
	'UPGRADE_WARNING: Event txtWESec.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtWESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWESec.TextChanged
		'txtWESec.ForeColor = &H80000008
		txtWESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtWESec.Text) > 59 Then
			txtWESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtWESec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWESec.KeyPress
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
	
	Private Sub txtWESec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtWESec.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtWESec.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtWESec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWESec.Enter
		SelectAllText(txtWESec)
	End Sub
	
	'UPGRADE_WARNING: Event txtTemperature.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTemperature_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.TextChanged
		'txtTemperature.ForeColor = &H80000008
		txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
			txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
			txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtTemperature_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTemperature.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		'    DPCount% = 0
		'    Select Case KeyAscii
		'        Case Asc("0") To Asc("9")
		'            fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'        Case Asc("-")
		'            If Left(txtTemperature, 1) <> "" Then
		'                KeyAscii = 0
		'                Beep
		'            End If
		'            For i% = 1 To Len(txtTemperature)
		'                If Mid(txtTemperature, i%, 1) = "-" Then
		'                    MinusCount% = MinusCount% + 1
		'                End If
		'            Next i%
		'            If MinusCount% > 0 Then
		'                KeyAscii = 0
		'                Beep
		'             Else
		'                fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'            End If
		'        Case Asc(".")
		'            For i% = 1 To Len(txtTemperature)
		'                If Mid(txtTemperature, i%, 1) = "." Then
		'                    DPCount% = DPCount% + 1
		'                End If
		'            Next i%
		'            If DPCount% > 0 Then
		'                KeyAscii = 0
		'                Beep
		'             Else
		'                fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'            End If
		'        Case Asc(Chr$(8))   'Backspace
		'            fNumeral$ = fNumeral$ + Chr$(KeyAscii)
		'        'Case Asc(",")
		'        Case Else
		'            KeyAscii = 0
		'            Beep
		'    End Select
		Static bMinusSignAlready As Boolean
		bMinusSignAlready = False
		Select Case KeyAscii
			Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
				'do nothing
			Case Asc("0") To Asc("9")
				'do nothing
			Case Asc("-")
				'If Len(txtTemperature.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtTemperature.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc(".") 'only allows one decimal point
				If InStr(txtTemperature.Text, ".") Then
					If KeyAscii = 46 Then KeyAscii = 0 : Beep()
				End If
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
	
	'Private Sub txtTemperature_Validate(KeepFocus As Boolean)
	'    If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -10 Or Val(txtTemperature.Text) > 130) Then
	'        KeepFocus = True
	'    End If
	'    If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -25 Or Val(txtTemperature.Text) > 55) Then
	'        KeepFocus = True
	'    End If
	'End Sub
	Private Sub txtTemperature_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.Enter
		SelectAllText(txtTemperature)
	End Sub
	
	'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
			txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
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
		If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then
			KeepFocus = True
		End If
		If Len(txtTime.Text) = 0 Then
			KeepFocus = False
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
	
	'UPGRADE_WARNING: Event txtZDh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
		'txtZDh.ForeColor = &H80000008
		If optZDAuto.Checked = True Or optZDUT.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		If optZDManual.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If optZDManual.Checked = True And (Val(txtZDh.Text) < -13 Or Val(txtZDh.Text) > 12) Then
			txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	'Private Sub txtZDh_KeyPress(KeyAscii As Integer)
	'    Select Case KeyAscii
	'        Case Asc("0") To Asc("9")
	'            fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'        Case Asc("+")
	'            If Left(txtZDh, 1) <> "" Then
	'                KeyAscii = 0
	'                Beep
	'            End If
	'            For i% = 1 To Len(txtZDh)
	'                If Mid(txtZDh, i%, 1) = "+" Then
	'                    PlusCount% = PlusCount% + 1
	'                End If
	'            Next i%
	'            If PlusCount% > 0 Then
	'                KeyAscii = 0
	'                Beep
	'             Else
	'                fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'            End If
	'        Case Asc("-")
	'            If Left(txtZDh, 1) <> "" Then
	'                KeyAscii = 0
	'                Beep
	'            End If
	'            For i% = 1 To Len(txtZDh)
	'                If Mid(txtZDh, i%, 1) = "-" Then
	'                    MinusCount% = MinusCount% + 1
	'                End If
	'            Next i%
	'            If MinusCount% > 0 Then
	'                KeyAscii = 0
	'                Beep
	'             Else
	'                fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'            End If
	'        Case Asc(Chr$(8))
	'            fNumeral$ = fNumeral$ + Chr$(KeyAscii)
	'        Case Else
	'            KeyAscii = 0
	'            Beep
	'    End Select
	'End Sub
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
			Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
			ZD = Int(Lo / 15 + 0.5)
			If cboLo.Text = "E " Then ZD = -ZD
			SignZD = "+" : If cboLo.Text = "E " Then SignZD = "-"
			txtZDh.Text = SignZD & System.Math.Abs(ZD)
		End If
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
	
	Private Sub cboDay_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles cboDay.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		
		'    If Val(txtDay.Text) > 31 Then
		'        KeepFocus = True
		'    End If
		eventArgs.Cancel = KeepFocus
	End Sub
	
	
	
	Public Sub LatLong()
		'Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
		LMin = Replace(txtLMin.Text, ",", ".")
		LoMin = Replace(txtLoMin.Text, ",", ".")
		Lat = Val(txtLDeg.Text) + Val(LMin) / 60
		If cboL.Text = "S " Then Lat = -Lat
		Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
		If cboLo.Text = "E " Then Lo = -Lo
	End Sub
	
	Public Function ZoneTime() As Object
		'WT = Watch Time, WE = Watch Error, ZT = Zone Time
		WTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2))
		WEinSeconds = 60 * Val(txtWEMin.Text) + Val(txtWESec.Text)
		If cboWE.Text = "fast" Then WEinSeconds = -WEinSeconds
		ZTinSeconds = WTinSeconds + WEinSeconds
		'Be sure Zone Time is not less than 0 or greater than 24 hours (86400 seconds)
		'Use ZTTemp as temporary variable
		ZTTemp = ZTinSeconds
		If ZTTemp > 86400 Then ZTTemp = ZTTemp - 86400
		If ZTTemp < 0 Then ZTTemp = ZTTemp + 86400
		ZTHours = Int(ZTTemp / 3600)
		ZTMinutes = Int((ZTTemp - CInt(ZTHours) * 3600) / 60)
		ZTSeconds = ZTTemp - CInt(ZTHours) * 3600 - ZTMinutes * 60
	End Function
	
	Public Function Greenwich() As Object
		'Prefix (or suffix) G for Greenwich, UT = Universal Time
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
		'If optZDManual = True Then ZD = Sgn(ZD) * (Abs(ZD) + Val((cboZDm.Text)) / 60)   'If optZDManual = True Then not necessary 'Sgn(ZD) was Sgn(Lo)
		If optZDManual.Checked = True Then ZD = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
		'If Val(txtZDh.Text) < 0 Then ZD = -ZD
		If VB.Left(txtZDh.Text, 1) = "-" Then ZD = -ZD
		''''If Sgn(Val(txtZDh.Text)) = -1 Then ZD = -ZD
		If chkDST.CheckState = 1 Then ZD = ZD - 1
		ZDinSeconds = 3600 * ZD
		UTinSeconds = ZTinSeconds + ZDinSeconds
		
		If StarNAFlag = True And BN <> 0 Then 'added And BN <> 0 in V5.3.1
			StarDayNumber = DayNumber Mod 3
			If StarDayNumber = 1 Then DayNumber = DayNumber + 1
			'If StarDayNumber = 2 Then DayNumber = DayNumber
			If StarDayNumber = 0 Then DayNumber = DayNumber - 1
			UTinSeconds = 43200 '12h
			If FlagPlanets = True Then UTinSeconds = 46800
		End If
		
		GHour = Int(UTinSeconds / 3600)
		GMinute = Int((UTinSeconds - CInt(GHour) * 3600) / 60)
		'    If (BN > 57 And BN < 62 And cboPlanets.text = "NA vals. of v/d") Then GMinuteP
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
		If StarNAFlag = True And BN <> 0 Then GHour = 12 : GMinute = 0 : GSecond = 0 'added And BN <> 0 in V5.3.1
		'    If FlagPlanets = True Then GHour = 13: GMinute = 0: GSecond = 0
		DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400!)
		DecimalDateHour1 = GDay + (GHour / 24)
		DecimalDateHour2 = GDay + ((GHour + 1) / 24)
		GYearJ = GYear
		If GMonth < 3 Then GYearJ = GYear - 1 : GMonth = GMonth + 12
		JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
		JDHour1 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour1 - 1537.5
		JDHour2 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour2 - 1537.5
		'    If BN = 64 Or BN = 65 Then T = (JD - 2451545) / 36525! Else            'eliminated in 4.7.1 - used DeltaT formula even if BN was 64 or 65????????
		T = (JD - 2451545 + DeltaT / 86400) / 36525!
		
		Tfull = T
		'T = (JD - 2451545 + DeltaT / 86400) / 36525!
		''    If BN = 64 Or BN = 65 Then THour1 = (JDHour1 - 2451545) / 36525!: THour2 = (JDHour2 - 2451545) / 36525!
		'THour1 = (JDHour1 - 2451545) / 36525!: THour2 = (JDHour2 - 2451545) / 36525!
		
		'If BN <> 64 And BN <> 65 Then
		THour1 = (JDHour1 - 2451545 + DeltaT / 86400) / 36525! : THour2 = (JDHour2 - 2451545 + DeltaT / 86400) / 36525!
	End Function
	
	Public Sub DisplaySR()
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Me.Font = VB6.FontChangeSize(Me.Font, 8)
		'UPGRADE_ISSUE: Form method Form1.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If cboBody.Text = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" Then
			cmdEqT.Visible = False
			'cmdEqT.Enabled = False
		Else
			cmdEqT.Visible = True
			'cmdEqT.Enabled = True
		End If
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2500
		'DecDegrees = Int(Abs(DE1)): DecMinutes = (Abs(DE1) - DecDegrees) * 60
		'If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0: DecDegrees = DecDegrees + 1
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(14), "TIME", TAB(41), "SIGHT DATA", TAB(73), "ALTITUDE")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Date", TAB(15), cboDay.Text, SPC(1), cboMonth.Text, SPC(1), txtYear.Text, TAB(35), "Sight No. " & txtSightNo.Text, TAB(60), "Ht of eye")
		If optHorizonArtificial.Checked = False Then
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(75), VB6.Format(HE, "0.0"), TAB(85))
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboHE.Text = "ft" Or cboHE.Text = "in" Then Print("ft")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboHE.Text = "m " Or cboHE.Text = "cm" Then Print("m")
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHorizonArtificial.Checked = True Then Print()
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("WT", TAB(15), Mid(txtTime.Text, 1, 2), TAB(17), "-" & Mid(txtTime.Text, 3, 2), TAB(20), "-" & Mid(txtTime.Text, 5, 2), TAB(35), "Body", TAB(43), cboBody.Text, TAB(60), "hs", TAB(92 - Len(Str(Val(txtHsDeg.Text)))), VB6.Format(Val(txtHsDeg.Text), "0") & Chr(176) & VB6.Format(HsMin, "00.0") & "'")
		'If optHsDMS.Value = True Then Print Format(Val(txtHsSec.Text), "00")
		'If optHsDMS.Value = False Then Print
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("WE", TAB(12), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If WEinSeconds <> 0 And cboWE.Text = "fast" Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If WEinSeconds <> 0 And cboWE.Text = "slow" Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If WEinSeconds = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(19), txtWEMin.Text, TAB(20), "-" & VB6.Format(txtWESec.Text, "00"))
		'If cboPolaris.Text <> "Latitude by altitude of Polaris" Then
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN <> 0 Or (BN = 0 And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then Print(TAB(35), "DR L", TAB(52 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(LMin), "00.0") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(64), "IC", TAB(78), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If ICinMinutes = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboIE.Text = "on the arc" And ICinMinutes <> 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (cboIE.Text = "off the arc (rdg.)" Or cboIE.Text = "off the arc (val.)") And ICinMinutes <> 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(82))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (cboIE.Text = "on the arc" Or cboIE.Text = "off the arc (val.)") Then Print(VB6.Format(Val(txtIEdeg.Text), "0"))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboIE.Text = "off the arc (rdg.)" Then Print(VB6.Format(Val(txtIEdeg.Text) - 1, "0"))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(83), Chr(176) & VB6.Format(ICMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("ZT", TAB(15), VB6.Format(ZTHours, "00") & "-" & VB6.Format(ZTMinutes, "00") & "-" & VB6.Format(ZTSeconds, "00"), TAB(35), "DR Lo", TAB(52 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(LoMin), "00.0") & "'" & cboLo.Text, TAB(64), "Dip", TAB(78))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHorizonArtificial.Checked = False Then
			Print("(-)", TAB(87 - Len(Str(Int(Dip)))), VB6.Format(Dip, "##0.0"), TAB(88), "'")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("ZD", TAB(12), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = 1 Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = -1 Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(ZD) = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", SPC(3 - Len(Str(Int(System.Math.Abs(ZD))))), VB6.Format(Int(System.Math.Abs(ZD)), "#0")) 'Format(Abs(Val(txtZDh.Text)), "00");
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optZDManual.Checked = True And cboZDm.Text <> "00" Then Print("-" & cboZDm.Text)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(67), "Corr", TAB(78), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr1 > 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr1 = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr1 < 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(82), VB6.Format(Corr1Deg, "0"), TAB(83), Chr(176) & VB6.Format(Corr1Min, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("UT (GMT)", TAB(15), VB6.Format(GHour, "00") & "-" & VB6.Format(GMinute, "00") & "-" & VB6.Format(GSecond, "00"), TAB(60), "ha")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(hainMinutes) = -1 Then Print(TAB(91 - Len(Str(haDeg))), "-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(92 - Len(Str(haDeg))), VB6.Format(System.Math.Abs(haDeg), "0") & Chr(176) & VB6.Format(haMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("G Day/Mo/Yr", TAB(14), Str(GDay), SPC(1), MonthatG & Str(GYear))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(67), "HP Moon")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 62 Or BN = 63 Then
			Print(TAB(75), VB6.Format(Int(HPA * 10 + 0.5) / 10, "00.0") & "'")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoParameters.Checked Then Print(TAB(10), "ALMANAC - LHA", TAB(64), "Refraction", TAB(78), "(-)", TAB(87 - Len(Str(Int(r)))), VB6.Format(Int(r * 1000 + 0.5) / 1000, "0.000") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked Then Print(TAB(10), "ALMANAC - LHA", TAB(64), "Main", TAB(78), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And Main_Renamed > 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And Main_Renamed = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And Main_Renamed < 0 Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked Then Print(")", TAB(84), VB6.Format(Int(System.Math.Abs(Main_Renamed * 10) + 0.5) / 10, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("SHA *")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN <= 57 And BN <> 0 And StarNAFlag = True Then Print(TAB(20 - Len(Str(SHdegDisplay))), VB6.Format(SHdegDisplay, "0") & Chr(176) & VB6.Format(SHminDisplay, "00.0") & "'", TAB(64)) 'standard star reduction
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN <= 57 And BN <> 0 And StarNAFlag = False Then Print(TAB(20 - Len(Str(SHdeg))), VB6.Format(SHdeg, "0") & Chr(176) & VB6.Format(SHmin, "00.0") & "'", TAB(64)) 'standard star reduction
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 0 And cboPolaris.Text = "Full reduction of Polaris sight" Then Print(TAB(20 - Len(Str(SHdeg))), VB6.Format(SHdeg, "0") & Chr(176) & VB6.Format(SHmin, "00.0") & "'", TAB(64)) 'standard Polaris reduction
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" Then Print(TAB(64)) 'latitude by altitude of Polaris
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoParameters.Checked Then Print(TAB(64), "Parallax", TAB(78), "(+)", TAB(87 - Len(Str(Int(PA)))), VB6.Format(PA, "0.000") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked Then Print(TAB(64), "Add'l (, Pl", TAB(78))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And (BN = 58 Or BN = 59 Or BN = 62 Or BN = 63) Then Print("(+)", TAB(84), VB6.Format(Addl, "00.0") & "'") 'Else Print
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And BN <> 58 And BN <> 59 And BN <> 62 And BN <> 63 Then Print()
		'End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN <= 57 Then Print("Aries")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN >= 58 And BN <= 61 Then Print(cboBody.Text)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 62 Or BN = 63 Then Print("Moon")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 64 Or BN = 65 Then Print("Sun")
		'If BN <= 57 Then Print "Aries"; Tab(20 - Len(Str$(GHAAriesDeg))); Format(GHAAriesDeg, "0"); Chr$(176); Format(GHAAriesMin, "00.0"); "'"
		'If BN > 57 Then Print cboBody.Text; Tab(20 - Len(Str$(GHADeg))); Format(GHADeg, "0"); Chr$(176); Format(GHAMin, "00.0"); "'" 'Incomplete line
		'    If optHorizonNatural = True Or optHorizonDipShort = True Then chkAH = 0     'Added in V5.1.7 - NOT NEEDED, TAKEN CARE OF IN AltitudeCorrection
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkAH.CheckState = 1 Then Print() 'Added ; in V5.1.7
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkAH.CheckState = 0 And optHoParameters.Checked Then Print(TAB(64), "Semi-diameter", TAB(78), "(")
		If chkAH.CheckState = 0 Then
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked And (BN = 62 Or BN = 64) Then Print("+)")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked And (BN = 63 Or BN = 65) Then Print("-)")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked And (BN < 62 Or BN > 65) Then Print(" )")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked Then Print(TAB(84), VB6.Format(DI, "00.000") & "'")
		End If
		'If optHoSRForm.Value Then Print Tab(64); "UL ( -30.0'"; Tab(78); 'always prints label if SR format
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And chkAH.CheckState = 0 Then Print(TAB(64), "UL ( -30.0'", TAB(78)) 'always prints label if SR format except if artificial horizon with superimposition
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And (BN = 62 Or BN = 63) And chkAH.CheckState = 1 Then Print(TAB(64), "AH ( superimp.", TAB(78), "(-)", TAB(84), "15.0'") 'artificial horizon with superimposition
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And BN = 63 Then Print(TAB(78), "(-)", TAB(84), "30.0'") 'Else Print
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And BN <> 63 And chkAH.CheckState <> 1 Then Print()
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(GHour, "00"), TAB(4), "hr", TAB(20 - Len(Str(GHAHourDeg1))), VB6.Format(GHAHourDeg1, "0") & Chr(176) & VB6.Format(GHAHourMin1, "00.0") & "'")
		
		'If optHoParameters.Value And (BN <= 57 Or BN = 62 Or BN = 63) Then Print
		
		If optHoParameters.Checked And (BN = 62 Or BN = 63) And chkAH.CheckState = 0 Then
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(64), "Augmentation", TAB(78), "(") '"(-)"; Tab(85); Format(Aug, "0.0") 'Else Print
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked And BN = 62 Then Print("+)")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked And BN = 63 Then Print("-)")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If optHoParameters.Checked Then Print(TAB(85), VB6.Format(Aug, "0.000") & "'")
		End If
		
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoParameters.Checked And BN = 65 And GYear >= 1954 And GYear <= 1969 Then Print(TAB(64), "Irradiation   (-)    1.2'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoParameters.Checked And BN = 64 And GYear >= 1954 And GYear <= 1969 Then Print()
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked Then Print(TAB(64), "Add'l Ref", TAB(78))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And optStdTPNo.Checked = True And System.Math.Sign(Raddl) = 1 Then Print(TAB(78), "(-)", TAB(85), VB6.Format(System.Math.Abs(Raddl), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And optStdTPNo.Checked = True And System.Math.Sign(Raddl) = -1 Then Print(TAB(78), "(+)", TAB(85), VB6.Format(System.Math.Abs(Raddl), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And optStdTPNo.Checked = True And System.Math.Sign(Raddl) = 0 Then Print(TAB(78), "( )", TAB(85), VB6.Format(System.Math.Abs(Raddl), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoSRForm.Checked And OptStdTPYes.Checked = True Then Print()
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHoParameters.Checked And (GYear < 1954 Or GYear > 1969) Then Print()
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(GMinute, "00"), TAB(4), "m", TAB(6), VB6.Format(GSecond, "00"), TAB(9), "s")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (GMinute + GSecond <> 0) Then Print(TAB(20 - Len(Str(GHAIncrementDeg))), VB6.Format(GHAIncrementDeg, "0") & Chr(176) & VB6.Format(GHAIncrementMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(67), "Corr", TAB(78), "(")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr2Min > 0 Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr2Min = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Corr2Min < 0 Then Print("-")
		LenCorr2Min = Len(Str(System.Math.Abs(Corr2Min))) : If Corr2Min - Int(Corr2Min) = 0 Then LenCorr2Min = LenCorr2Min + 2
		If LenCorr2Min < 4 Then LenCorr2Min = 4
		'If optHoParameters.Value Then x = 87
		'If optHoSRForm.Value Then x = 88
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(89 - LenCorr2Min), VB6.Format(System.Math.Abs(Corr2Min), "0.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("v (")
		If SignHourChange = 0 Or ((BN = 64 Or BN = 65) And cboSun.Text = "NA val. of hourly GHA") Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'sun and stars have no v correction; add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ) ")
		ElseIf SignHourChange = 1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+) ")
		ElseIf SignHourChange = -1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-) ")
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If ((BN = 64 Or BN = 65) And cboSun.Text = "Accurate val. of hourly GHA") Or (BN > 57 And BN < 64) And (GMinute + GSecond <> 0) Then Print(VB6.Format(System.Math.Abs(vvalue), "0.0") & "'") 'add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(60), "Ho")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(91 - Len(Str(HoDeg))), "-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(92 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		
		Lenvcorr = Len(Str(System.Math.Abs(vcorr))) : If Lenvcorr < 4 Then Lenvcorr = 4
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(7), "v corr (")
		If SignHourChange = 0 Or ((BN = 64 Or BN = 65) And cboSun.Text = "NA val. of hourly GHA") Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ) ") 'Tab(40); "ALMANAC - Dec"    'sun or stars
		ElseIf SignHourChange = 1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+) ")
		ElseIf SignHourChange = -1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-) ")
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If ((BN = 64 Or BN = 65) And cboSun.Text = "Accurate val. of hourly GHA") Or (BN > 57 And BN < 64) And (GMinute + GSecond <> 0) Then Print(TAB(25 - Lenvcorr), VB6.Format(System.Math.Abs(vcorr), "0.0") & "'") 'Tab(40); "ALMANAC - Dec"   'not sun or stars; add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(40), "ALMANAC - Dec")
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" Then
			Print("Tot GHA", TAB(20 - Len(Str(TotGHAPolDeg))), VB6.Format(TotGHAPolDeg, "0") & Chr(176) & VB6.Format(TotGHAPolMin, "00.0") & "'")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Tot GHA", TAB(20 - Len(Str(TotGHADeg))), VB6.Format(TotGHADeg, "0") & Chr(176) & VB6.Format(TotGHAMin, "00.0") & "'")
		End If
		
		If BN <= 57 Then
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(35), "Dec ", TAB(42), "hr")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(35), "Dec " & VB6.Format(GHour, "00"), TAB(42), "hr", TAB(52 - Len(Str(DecDegrees))), VB6.Format(System.Math.Abs(DecDegrees), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If DE1 > 0 Then Print("N")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If DE1 = 0 Then Print(" ")
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If DE1 < 0 Then Print("S")
		End If
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("DR Lo (")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo <> 0 And cboLo.Text = "W " Then Print("-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo <> 0 And cboLo.Text = "E " Then Print("+")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(20 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(LoMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Lo <> 0 Then Print(cboLo.Text)
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(35), "d (") 'stars have no d correction
		If Signdvalue = 0 Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ) ")
		ElseIf Signdvalue = 1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+) ")
		ElseIf Signdvalue = -1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-) ")
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN > 57 And (GMinute + GSecond <> 0) Then
			Print(VB6.Format(System.Math.Abs(dvalue), "0.0") & "'")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If 'add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" Then
			Print("LHA", TAB(20 - Len(Str(LHAPolDeg))), VB6.Format(LHAPolDeg, "0") & Chr(176) & VB6.Format(LHAPolMin, "00.0") & "'")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("LHA", TAB(20 - Len(Str(LHADeg))), VB6.Format(LHADeg, "0") & Chr(176) & VB6.Format(LHAMin, "00.0") & "'")
		End If
		
		Lendcorr = Len(Str(dcorr)) : If Lendcorr < 4 Then Lendcorr = 4
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(38), "d corr (")
		If Signdvalue = 0 Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ) ")
		ElseIf Signdvalue = 1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+) ")
		ElseIf Signdvalue = -1 Then 
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-) ")
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN > 57 And (GMinute + GSecond <> 0) Then Print(TAB(57 - Lendcorr), VB6.Format(dcorr, "0.0") & "'") 'add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(35), "Dec", TAB(52 - Len(Str(TotDecDegrees))), VB6.Format(System.Math.Abs(TotDecDegrees), "0") & Chr(176) & VB6.Format(TotDecMinutes, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE < 0 Then Print("S")
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHorizonArtificial.Checked = True Then Print(TAB(60), "ha adjusted for artificial horizon")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BackSight = True And optHorizonArtificial.Checked = False Then Print(TAB(60), "ha adjusted for back sight")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optHorizonArtificial.Checked = False And BackSight = False Then Print()
		
		TotDE = System.Math.Sign(TotDE) * (TotDecDegrees + TotDecMinutes / 60)
		
	End Sub
	
	Public Function Dip() As Object
		HE = Val(txtHE.Text)
		If cboHE.Text = "ft" Then HEinFeet = HE
		If cboHE.Text = "m " Then HEinFeet = HE * 3.28095
		If cboHE.Text = "in" Then HEinFeet = HE / 12
		If cboHE.Text = "cm" Then HEinFeet = HE * 0.0328095
		If cboHE.Text = "ft" Or cboHE.Text = "m " Then HE = Int(HE * 10 + 0.5) / 10
		If cboHE.Text = "in" Then HE = Int((HE / 12) * 10 + 0.5) / 10
		If cboHE.Text = "cm" Then HE = Int((HE / 100) * 10 + 0.50000001) / 10
		
		DipShortDist = Val(txtDsDist.Text)
		'Convert distance to dip short horizon to nautical miles
		If cboDsUnit.Text = "feet" Then DipShortDist = DipShortDist / 6076.1
		If cboDsUnit.Text = "yards" Then DipShortDist = DipShortDist * 3 / 6076.1
		If cboDsUnit.Text = "meters" Then DipShortDist = DipShortDist / 1852
		If cboDsUnit.Text = "statute miles" Then DipShortDist = DipShortDist * 5280 / 6076.1
		'Check if dip short distance is greater than distance to natural horizon
		If optHorizonDipShort.Checked = True And DipShortDist > 1.169 * System.Math.Sqrt(HEinFeet) Then MsgBox("Dip short distance exceeded distance to natural horizon.  Natural horizon will be used.") : optHorizonNatural.Checked = True : txtDsDist.Text = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If optHorizonDipShort.Checked = True Then Dip = (10800 / Pi) * System.Math.Atan(HEinFeet / (6076.1 * DipShortDist) + 0.8321 * DipShortDist / 6880.2)
		
		'Convert C to F
		Temperature = Val(txtTemperature.Text)
		If cboTemperature.Text = "C " Then Temperature = (5 / 9) * (Temperature - 32)
		'Convert mbar to in Hg
		Pressure = Val(txtPressure.Text)
		If cboPressure.Text = "mbar" Then Pressure = 33.858532 * Pressure
		'Calculate dip
		If optHorizonNatural.Checked = True And (cboHE.Text = "ft" Or cboHE.Text = "in") Then
			Select Case HE
				Case Is < 2
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 0.7 * HE
				Case Is <= 3.9
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 1.4 + (HE - 2) * 0.25
				Case Is <= 5.9
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 1.9 + (HE - 4) * 0.25
				Case Is <= 7.6
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 2.4 + (HE - 6) * 0.15
				Case Is >= 7.7
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 0.970003 * System.Math.Sqrt(HE)
			End Select
		End If
		If optHorizonNatural.Checked = True And (cboHE.Text = "m " Or cboHE.Text = "cm") Then
			Select Case HE
				Case Is < 1
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 1.79 * HE
				Case Is <= 1.6
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 1.79 * System.Math.Sqrt(HE)
				Case Is >= 1.7
					'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dip = 1.76 * System.Math.Sqrt(HE)
			End Select
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Dip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Dip = Int(Dip * 10 + 0.5) / 10
	End Function
	
	Public Function Obliquity() As Object
		'Obliquity of the ecliptic
		OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
		OE = OE / 3600 'degrees
		OETrue = OE + NO 'degrees
	End Function
	
	
	Public Sub Nutation()
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
	End Sub
	Public Function Stars() As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object RA(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AR = RA(BN)
		'UPGRADE_WARNING: Couldn't resolve default property of object Dec(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DE = Dec(BN)
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
	Public Sub Sun()
		Ecc = 0.016708634 - 0.000042037 * T - 0.0000001267 * T * T 'Ecc of Earth's orbit
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
		If BN <> 64 And BN <> 65 Then Exit Sub 'no need to go further if not sun sight
		
		
		T = T / 10
		' Compute heliocentric, ecliptical Longitude L in radians
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_L01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		L = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
		If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
		' Compute heliocentric, ecliptical Latitude B in radians
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_B01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
		' Compute heliocentric distance R in AU
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R51(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R41(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R31(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R21(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R11(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R02(T). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Earth_R01(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		r = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)
		
		L1 = L + Pi 'geocentric longitude, radians
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
		EclipticToEquatorial()
		AR = AR * 180 / Pi 'for Meeus ecl-to-eq
		DE = DE * 180 / Pi 'for Meeus ecl-to-eq
		
		DI = System.Math.Atan(0.00465424336 / RN) * 180 / Pi * 60
		'DI = (959.63 / RN) / 60        'Meeus
		'back to normal T
		T = 10 * T
	End Sub
	
	Public Function HourAngles() As Object
		SH = 360 - AR
		SHdeg = Int(SH)
		SHmin = (SH - SHdeg) * 60
		SHmin = Int(SHmin * 10 + 0.5) / 10
		If SHmin = 60 Then SHmin = 0 : SHdeg = SHdeg + 1
		
		If StarNAFlag = True Then 'this must be True for SHA to remain constant throughout a day
			SHdegDisplay = SHdeg
			SHminDisplay = SHmin
			'SH = SHdegDisplay + SHminDisplay / 60
		End If
		
		HG = UTinSeconds / 3600
		GHAAries = 280.46061837 + 360.98564736629 * (JD - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees, only used for Time Diagram
		GHAAries = GHAAries + NL * System.Math.Cos(OETrue) 'true GHA of Aries, degrees
		If GHAAries >= 360 Or GHAAries < 0 Then GHAAries = GHAAries - Int(GHAAries / 360) * 360
		GHAAriesDeg = Int(GHAAries)
		GHAAriesMin = (GHAAries - GHAAriesDeg) * 60
		GHAAriesMin = Int(GHAAriesMin * 10 + 0.5) / 10
		If GHAAriesMin = 60 Then GHAAriesMin = 0 : GHAAriesDeg = GHAAriesDeg + 1
		
		'If BN <= 57 Then GHA = GHAAries Else GHA = SH + GHAAries
		If BN <= 57 Then GHA = GHAAriesDeg + GHAAriesMin / 60 Else GHA = SHdeg + SHmin / 60 + GHAAriesDeg + GHAAriesMin / 60
		If GHA >= 360 Or GHA < 0 Then GHA = GHA - Int(GHA / 360) * 360
		If BN <= 57 Then TotGHA = SH + GHA Else TotGHA = GHA
		If TotGHA >= 360 Or TotGHA < 0 Then TotGHA = TotGHA - Int(TotGHA / 360) * 360
		TotGHAPol = TotGHA - SH
		If TotGHAPol >= 360 Then TotGHAPol = TotGHAPol - 360
		If TotGHAPol < 0 Then TotGHAPol = TotGHAPol + 360
		TotGHAPolDeg = Int(TotGHAPol) : TotGHAPolMin = (TotGHAPol - TotGHAPolDeg) * 60
		If Int(TotGHAPolMin * 10 + 0.5) / 10 = 60 Then TotGHAPolMin = 0 : TotGHAPolDeg = TotGHAPolDeg + 1
		LHA = TotGHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		LHAPol = LHA - SH
		If LHAPol >= 360 Then LHAPol = LHAPol - 360
		If LHAPol < 0 Then LHAPol = LHAPol + 360
		TotGHADeg = Int(TotGHA) : TotGHAMin = (TotGHA - TotGHADeg) * 60
		If Int(TotGHAMin * 10 + 0.5) / 10 = 60 Then TotGHAMin = 0 : TotGHADeg = TotGHADeg + 1
		If TotGHADeg >= 360 Then TotGHADeg = TotGHADeg - 360
		LHADeg = Int(LHA) : LHAMin = (LHA - LHADeg) * 60
		If Int(LHAMin * 10 + 0.5) / 10 = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
		LHAPolDeg = Int(LHAPol) : LHAPolMin = (LHAPol - LHAPolDeg) * 60
		If Int(LHAPolMin * 10 + 0.5) / 10 = 60 Then LHAPolMin = 0 : LHAPolDeg = LHAPolDeg + 1
		If LHAPolDeg >= 360 Then LHAPolDeg = LHAPolDeg - 360
		
	End Function
	
	Public Function HourAnglesHour() As Object
		SH = 360 - AR
		GHAAriesHour = 280.46061837 + 360.98564736629 * (JDHour - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees
		GHAAriesHour = GHAAriesHour + NL * System.Math.Cos(OETrue * Pi / 180) 'true GHA of Aries, degrees
		If GHAAriesHour >= 360 Or GHAAriesHour < 0 Then GHAAriesHour = GHAAriesHour - Int(GHAAriesHour / 360) * 360
		If BN <= 57 Then GHAHour = GHAAriesHour Else GHAHour = SH + GHAAriesHour
		If GHAHour >= 360 Or GHAHour < 0 Then GHAHour = GHAHour - Int(GHAHour / 360) * 360
	End Function
	
	'Public Function HourAnglesMinSec()
	'    GHAMinSec = GHA - GHAHour
	'    If GHAMinSec < 0 Then GHAMinSec = GHAMinSec + 360
	'    GHAMinSecDeg = Int(GHAMinSec): GHAMinSecMin = (GHAMinSec - GHAMinSecDeg) * 60
	'    If Int(GHAMinSecMin * 10 + 0.5) / 10 = 60 Then GHAMinSecMin = 0: GHAMinSecDeg = GHAMinSecDeg + 1 'If Round(GHAMinSecMin, 1) = 60 Then GHAMinSecMin = 0: GHAMinSecDeg = GHAMinSecDeg + 1
	'End Function
	
	Public Function AltitudeCorrection() As Object
		If optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True Then chkAH.CheckState = System.Windows.Forms.CheckState.Unchecked 'Added in V5.1.7
		If optHsDMS.Checked = False Then txtHsSec.Text = "" : txtIESec.Text = ""
		ICMin = Val(txtIEmin.Text) + Val(txtIESec.Text) / 60
		'If cboIE.Text = "off the arc (rdg.)" And ICMin = 60 Then ICMin = 0
		If cboIE.Text = "on the arc" Then ICinMinutes = -(Val(txtIEdeg.Text) * 60 + ICMin)
		If cboIE.Text = "off the arc (rdg.)" Then
			ICMin = 60 - ICMin
			If ICMin = 60 Then ICMin = 0
			ICinMinutes = (Val(txtIEdeg.Text) - 1) * 60 + ICMin
		End If
		If cboIE.Text = "off the arc (val.)" Then ICinMinutes = Val(txtIEdeg.Text) * 60 + ICMin
		Corr1 = ICinMinutes - Dip
		Corr1Deg = Int(System.Math.Abs(Corr1 / 60))
		Corr1Min = System.Math.Abs(Corr1) - 60 * Corr1Deg
		hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
		HsMin = Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
		hainMinutes = hsinMinutes + Corr1
		'If optHorizonArtificial = True And hainMinutes >= 5400 Then _
		'MsgBox ("Back sight with artificial horizon not permitted."): BSwithAH = True: Exit Function
		If optHorizonArtificial.Checked = True Then hainMinutes = (hsinMinutes + ICinMinutes) / 2
		BackSight = False
		If hainMinutes >= 5400 Then hainMinutes = 10800 - hainMinutes : BackSight = True
		Refraction()
		'    If BN = 64 Or BN = 65 Then HP = 0.14656956         'removed this line and added next line in V5.4.0 so more accurate parallax of Sun, not just average parallax,is computed
		If BN = 64 Or BN = 65 Then HP = 60 * System.Math.Atan(0.0000426349651 / RN) * 180 / Pi '0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
		'If BN = 58 Or BN = 59 Then Planets: ER = 6378.16 / (H0 * 149597900#): HP = 60 * 180 / Pi * Atn(ER / Sqr(-ER * ER + 1)) 'Why did this work?
		If BN = 58 Or BN = 59 Then HP = 60 * 180 / Pi * System.Math.Atan(6378.16 / (Delta * 149597871))
		If BN <= 57 Or BN = 60 Or BN = 61 Then HP = 0
		'PA = HP * Cos((hainMinutes / 60) * Pi / 180)   Parallax moved to cmdReduce, including oblateness of Earth correction for Moon parallax
		'Oblateness of Earth correction for Moon parallax
		''If BN = 62 Or BN = 63 Then PA = PA - 0.102 * Cos((hainMinutes / 60) * Pi / 180) 'simplified oblateness correction good for mid-latitudes, altitude <60 degrees
		'If BN = 62 Or BN = 63 Then PA = PA - 0.192 * Sin(Lat * Pi / 180) * Sin(Lat * Pi / 180) * Cos((hainMinutes / 60) * Pi / 180) + 0.192 * Sin(2 * Lat * Pi / 180) * Cos(ZN * Pi / 180) * Sin((hainMinutes / 60) * Pi / 180)
		'If BN = 62 Or BN = 63 Then PA = PA + (1 / 298.257) * HPA * (Sin(2 * Lat * Pi / 180) * Cos(ZN * Pi / 180) * Sin((hainMinutes / 60) * Pi / 180) - Sin(Lat * Pi / 180) * Sin(Lat * Pi / 180) * Cos((hainMinutes / 60) * Pi / 180))    'Umland
		'If BN = 62 Or BN = 63 Then PA = PA - HPA * Sin(Lat * Pi / 180) * Sin(Lat * Pi / 180) / 298.257
		'    Corr2Min = -r + PA  'r from Refraction
		'    If BN < 62 Then DI = 0         'Removed this and added next few lines in V5.4.0 to get real semidiameters of planets.  These values are just displayed, but not used in the Ho calculation.
		Dim S0 As Double
		If BN < 58 Then DI = 0 'stars
		If BN = 58 Then S0 = 8.41 / 60
		If BN = 59 Then S0 = 4.68 / 60
		If BN = 60 Then S0 = 95.25 / 60 'average of equatorial and polar values (new values) for Jupiter
		If BN = 61 Then S0 = 78.275 / 60 ''average of equatorial and polar values (new values) for Saturn
		If BN > 57 And BN < 62 Then DI = S0 / Delta
		'Semi-diameter of Moon is in Moon sub
		If (BN = 64 Or BN = 65) And optHoSRForm.Checked And GMonth >= 4 And GMonth <= 9 Then DI = 15.859 : PA = 0.145 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP
		If (BN = 64 Or BN = 65) And optHoSRForm.Checked And (GMonth < 4 Or GMonth > 9) Then DI = 16.1968 : PA = 0.148 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP
		If (BN = 62 Or BN = 63 Or BN = 64 Or BN = 65) And chkAH.CheckState = 1 Then DI = 0
		If (BN = 62 Or BN = 63 Or BN = 64 Or BN = 65) And chkAH.CheckState = 1 And optHoSRForm.Checked = True Then PA = 0
		
		Corr2Min = -r 'Was If BN <= 57 Then Corr2Min = -r, but should apply refraction to all bodies.  Changed in V5.4.0
		
		
		'If BN = 64 Then DI = DI - 0.1
		'If BN = 65 Then DI = DI + 0.1
		
		'If BN = 62 Or BN = 64 Then Corr2Min = Corr2Min + DI
		'If BN = 63 Or BN = 65 Then Corr2Min = Corr2Min - DI
		'If BN = 65 And GYear >= 1954 And GYear <= 1969 Then Corr2Min = Corr2Min - 1.2  '1.2' for irradiation
		If BN = 65 And GYear >= 1954 And GYear <= 1969 Then DI = DI - 1.2 '1.2' for irradiation
		
		'Corr2forParallax = Corr2Min
		'Augmentation of the semi-diameter of the moon
		Aug = 0 'Augmentation increases the size of the semi-diameter correction, whether positive or negative
		If BN = 62 Or BN = 63 Then
			Aug = (((1738 / 6378) * HPA / 60) / (1 - System.Math.Sin(HPA / 60 * Pi / 180) * System.Math.Sin((hainMinutes / 60) * Pi / 180)) - DI / 60) * 60
			'If BN = 62 Then Corr2Min = Corr2Min + Aug
			'If BN = 63 Then Corr2Min = Corr2Min - Aug
			'If BN = 62 Then DI = DI + Aug
			'If BN = 63 Then DI = DI - Aug
			Aug = Int(Aug * 1000 + 0.5) / 1000
		End If
		If (BN = 62 Or BN = 63) And chkAH.CheckState = 1 Then Aug = 0
		'If BN = 62 Then DI = DI + Aug
		'If BN = 63 Then DI = DI - Aug
		If BN = 62 Or BN = 64 Then Corr2Min = DI - r '+ PA 'r from Refraction
		If BN = 63 Or BN = 65 Then Corr2Min = -DI - r '+ PA 'r from Refraction
		If BN = 62 Then Corr2Min = Corr2Min + Aug
		If BN = 63 Then Corr2Min = Corr2Min - Aug
		'If BN = 62 Then DI = DI + Aug
		'If BN = 63 Then DI = DI - Aug
		Corr2forParallax = Corr2Min
		Corr2Min = Corr2Min + PA 'previously calculated refraction + parallax
		
		'Corrections for SR Form format
		Main_Renamed = 0
		Addl = 0
		If BN <= 57 Or BN = 60 Or BN = 61 Then 'stars, Jupiter, Saturn
			Main_Renamed = -Rstd
			Addl = 0
		End If
		If BN = 58 Or BN = 59 Then 'Venus, Mars
			Main_Renamed = -Rstd
			Addl = PA
		End If
		
		If BN = 64 And optHoSRForm.Checked Then
			Main_Renamed = -Rstd + PA + DI
			Addl = 0
		End If
		If BN = 65 And optHoSRForm.Checked Then
			Main_Renamed = -Rstd + PA - DI
			If GYear >= 1954 And GYear <= 1969 Then Main_Renamed = Main_Renamed - 1.2 '1.2' for irradiation
			Addl = 0
		End If
		''double comments are original based on Frank Reed
		If BN = 62 Or BN = 63 Then 'Moon            57.7 better as 57.66
			''        H2 = (hainMinutes - r) / 60 'degrees
			''        h3 = H2 + 57.7 * Cos(H2 * Pi / 180) / 60 + 15.64247 / 60    'degrees
			''        havg = 2.5 + 5 * Int((hainMinutes / 60) / 5)
			''        dHP = (HPA - 57.7) / 60
			''        DSD = 0.2711 * dHP      '0.2724 was no better
			''        h4 = h3 + dHP * Cos(havg * Pi / 180)
			''        h4LL = h4 + DSD
			''        h4UL = h4 - DSD
			''        Main = 60 * (h3 - hainMinutes / 60) - 5 'minutes
			''        Main = Int(Main * 10 + 0.5) / 10
			h3 = 57.66 * System.Math.Cos((hainMinutes / 60) * Pi / 180)
			
			'Use refraction formulas from Nautical Almanac, standard temperature and pressure, dependent on year
			H2 = hainMinutes / 60 'ha in degrees
			If GYear <= 2003 Then
				r = H2 + 7.31 / (H2 + 4.4)
				'R = R - 0.06 * Sin((14.7 * R / 60) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
			Else
				r = H2 + 7.32 / (H2 + 4.32)
			End If
			
			r = r * Pi / 180
			r = 1.002 / System.Math.Tan(r) '1.002 is 0.0167º in minutes, actually 0.01666666.... becomes 1, but 1.002 makes it match moon table better
			Main_Renamed = h3 - r + (0.2724 * 57.66) - 5 : h4 = Main_Renamed 'h4 is Main before rounding
			Main_Renamed = Int(Main_Renamed * 10 + 0.5) / 10
			'Main = Round(Main, 1)
		End If
		''    If BN = 62 Then Addl = 60 * (h4LL - h3) + 5
		''    If BN = 63 Then Addl = 60 * (h4UL - h3) + 3.61506   'was 3.71506=-2*.2711*57.7+35, changed 35 to 34.9
		dHP = Int(HPA * 10 + 0.5) / 10 'rounds HP to 0.1'
		If BN = 62 Then Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r + DI - h4
		If BN = 63 Then Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r - DI + 30 - h4
		
		If (BN = 62 Or BN = 63) And optHorizonArtificial.Checked = True And chkAH.CheckState = 1 Then Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r - h4 + 15
		
		Addl = Int(Addl * 10 + 0.5) / 10
		Raddl = Int(Raddl * 10 + 0.5) / 10
		If optHoSRForm.Checked Then Corr2Min = Main_Renamed + Addl - Raddl
		If optHoSRForm.Checked And BN = 63 Then Corr2Min = Corr2Min - 30
		If optHoSRForm.Checked And (BN = 62 Or BN = 63) And chkAH.CheckState = 1 Then Corr2Min = Corr2Min - 15
		'Corr2Min = Fix(Corr2Min * 10 + 0.5) / 10
		Corr2Min = System.Math.Sign(Corr2Min) * Int(System.Math.Abs(Corr2Min) * 10 + 0.5) / 10
		'Totals
		HoinMinutes = hainMinutes + Corr2Min 'minutes
		HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
		'HoMin = Abs(HoinMinutes - 60 * HoDeg)
		HoMin = HoinMinutes - 60 * HoDeg
		HoMin = Int(HoMin * 10 + 0.5) / 10
		If HoMin = 60 Then HoMin = 0 : HoDeg = HoDeg + 1
		haDeg = Fix(hainMinutes / 60) 'min. to dec. deg
		haMin = System.Math.Abs(hainMinutes - 60 * haDeg)
		If Int(haMin * 10 + 0.5) / 10 = 60 Then haMin = 0 : haDeg = haDeg + 1
		
	End Function
	
	Public Function LawOfCosines() As Object
		'DecLOC = Abs(TotDE)
		DecLOC = System.Math.Abs(TotDecDegrees + TotDecMinutes / 60)
		If System.Math.Sign(Lat) = -System.Math.Sign(TotDE) Then DecLOC = -DecLOC 'does not work of L=0
		If System.Math.Sign(Lat) = 0 And cboL.Text = "N " And TotDE <= 0 Then DecLOC = -DecLOC
		If System.Math.Sign(Lat) = 0 And cboL.Text = "S " And TotDE >= 0 Then DecLOC = -DecLOC
		
		L1 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(Lat) * Pi / 180) * System.Math.Cos(DecLOC * Pi / 180)
		'L1 = Cos((LHADeg + LHAMin / 60) * Pi / 180) * Cos(Abs(Lat) * Pi / 180) * Cos(DecLOC * Pi / 180)
		L2 = System.Math.Sin(System.Math.Abs(Lat) * Pi / 180) * System.Math.Sin(DecLOC * Pi / 180)
		L3 = L1 + L2
		If System.Math.Abs(L3) >= 1 Then Hc = System.Math.Sign(L3) * Pi / 2 Else Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
		Hc = Hc * 180 / Pi
		'HcDeg = Fix(Hc): HcMin = Abs((Hc - HcDeg) * 60)
		HcDeg = Fix(Hc) : HcMin = (Hc - HcDeg) * 60 ':HcMin = Abs((Hc - HcDeg) * 60)
		HcMin = Int(HcMin * 10 + 0.5) / 10
		
		'If Int(HcMin * 10 + 0.5) / 10 = 60 Then
		If HcMin = 60 Then
			HcMin = 0
			If HcDeg >= 0 Then HcDeg = HcDeg + 1
			If HcDeg < 0 Then HcDeg = HcDeg - 1
		End If
		'Intercept = 60 * Hc - HoinMinutes
		'Intercept = Abs(60 * HcDeg + HcMin) - Abs(60 * HoDeg + HoMin)
		Intercept = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		Intercept = System.Math.Sign(Intercept) * Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10
		L4 = System.Math.Sin(DecLOC * Pi / 180)
		L5 = System.Math.Sin(System.Math.Abs(Lat) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
		L6 = L4 - L5
		L7 = System.Math.Cos(System.Math.Abs(Lat) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
		L8 = L6 / L7
		If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2
		Z = Z * 180 / Pi
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		If BN <> 0 Or (BN = 0 And cboPolaris.Text = "Full reduction of Polaris sight") Then ZN = Int(ZN + 0.5)
		If ZN = 360 Then ZN = 0
	End Function
	
	Public Sub Refraction()
		'Atmospheric refraction
		TX = Val(txtTemperature.Text)
		If cboTemperature.Text = "F " Then TX = (5 / 9) * (TX - 32)
		PX = Val(txtPressure.Text)
		If cboPressure.Text = "in Hg" Then PX = 33.85853168 * PX
		
		If optHoSRForm.Checked = True Then
			'        If GYear <= 2003 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then
			If GYear <= 2003 And hainMinutes >= 596 Then 'And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then
				
				Select Case hainMinutes
					Case Is <= 608
						r = 5.3
					Case Is <= 620
						r = 5.2
					Case Is <= 633
						r = 5.1
					Case Is <= 646
						r = 5
					Case Is <= 660
						r = 4.9
					Case Is <= 674
						r = 4.8
					Case Is <= 689
						r = 4.7
					Case Is <= 705
						r = 4.6
					Case Is <= 721
						r = 4.5
					Case Is <= 738
						r = 4.4
					Case Is <= 755
						r = 4.3
					Case Is <= 774
						r = 4.2
					Case Is <= 793
						r = 4.1
					Case Is <= 813
						r = 4
					Case Is <= 834
						r = 3.9
					Case Is <= 856
						r = 3.8
					Case Is <= 880
						r = 3.7
					Case Is <= 904
						r = 3.6
					Case Is <= 930
						r = 3.5
					Case Is <= 957
						r = 3.4
					Case Is <= 986
						r = 3.3
					Case Is <= 1016
						r = 3.2
					Case Is <= 1048
						r = 3.1
					Case Is <= 1082
						r = 3
					Case Is <= 1118
						r = 2.9
					Case Is <= 1157
						r = 2.8
					Case Is <= 1198
						r = 2.7
					Case Is <= 1242
						r = 2.6
					Case Is <= 1288
						r = 2.5
					Case Is <= 1339
						r = 2.4
					Case Is <= 1393
						r = 2.3
					Case Is <= 1451
						r = 2.2
					Case Is <= 1514
						r = 2.1
					Case Is <= 1582
						r = 2
					Case Is <= 1656
						r = 1.9
					Case Is <= 1736
						r = 1.8
					Case Is <= 1824
						r = 1.7
					Case Is <= 1920
						r = 1.6
					Case Is <= 2025
						r = 1.5
					Case Is <= 2140
						r = 1.4
					Case Is <= 2268
						r = 1.3
					Case Is <= 2408
						r = 1.2
					Case Is <= 2564
						r = 1.1
					Case Is <= 2736
						r = 1
					Case Is <= 2927
						r = 0.9
					Case Is <= 3138
						r = 0.8
					Case Is <= 3371
						r = 0.7
					Case Is <= 3628
						r = 0.6
					Case Is <= 3908
						r = 0.5
					Case Is <= 4211
						r = 0.4
					Case Is <= 4534
						r = 0.3
					Case Is <= 4873
						r = 0.2
					Case Is <= 5223
						r = 0.1
					Case Is <= 5400
						r = 0
				End Select
			End If
			
			'            If GYear >= 2004 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then
			If GYear >= 2004 And hainMinutes >= 595 Then 'And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then
				
				Select Case hainMinutes
					Case Is <= 607
						r = 5.3
					Case Is <= 620
						r = 5.2
					Case Is <= 632
						r = 5.1
					Case Is <= 646
						r = 5
					Case Is <= 659
						r = 4.9
					Case Is <= 674
						r = 4.8
					Case Is <= 689
						r = 4.7
					Case Is <= 704
						r = 4.6
					Case Is <= 720
						r = 4.5
					Case Is <= 737
						r = 4.4
					Case Is <= 755
						r = 4.3
					Case Is <= 773
						r = 4.2
					Case Is <= 792
						r = 4.1
					Case Is <= 812
						r = 4
					Case Is <= 833
						r = 3.9
					Case Is <= 856
						r = 3.8
					Case Is <= 879
						r = 3.7
					Case Is <= 903
						r = 3.6
					Case Is <= 929
						r = 3.5
					Case Is <= 956
						r = 3.4
					Case Is <= 985
						r = 3.3
					Case Is <= 1015
						r = 3.2
					Case Is <= 1047
						r = 3.1
					Case Is <= 1081
						r = 3
					Case Is <= 1117
						r = 2.9
					Case Is <= 1156
						r = 2.8
					Case Is <= 1196
						r = 2.7
					Case Is <= 1240
						r = 2.6
					Case Is <= 1287
						r = 2.5
					Case Is <= 1337
						r = 2.4
					Case Is <= 1391
						r = 2.3
					Case Is <= 1449
						r = 2.2
					Case Is <= 1512
						r = 2.1
					Case Is <= 1580
						r = 2
					Case Is <= 1654
						r = 1.9
					Case Is <= 1734
						r = 1.8
					Case Is <= 1822
						r = 1.7
					Case Is <= 1918
						r = 1.6
					Case Is <= 2023
						r = 1.5
					Case Is <= 2138
						r = 1.4
					Case Is <= 2265
						r = 1.3
					Case Is <= 2406
						r = 1.2
					Case Is <= 2562
						r = 1.1
					Case Is <= 2734
						r = 1
					Case Is <= 2925
						r = 0.9
					Case Is <= 3136
						r = 0.8
					Case Is <= 3369
						r = 0.7
					Case Is <= 3626
						r = 0.6
					Case Is <= 3906
						r = 0.5
					Case Is <= 4209
						r = 0.4
					Case Is <= 4532
						r = 0.3
					Case Is <= 4872
						r = 0.2
					Case Is <= 5223
						r = 0.1
					Case Is <= 5400
						r = 0
				End Select
			End If
		End If
		RstdA2 = r 'Standard refraction before temperature and pressure applied, from Table A2
		
		If (GYear <= 2003 And hainMinutes < 596) Or (GYear >= 2004 And hainMinutes < 595) Or ((GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) And ((Val(txtPressure.Text) <> 1010 And cboPressure.Text = "mbar") Or (Val(txtPressure.Text) <> 29.83 And cboPressure.Text = "in Hg")) Or ((Val(txtTemperature.Text) <> 50 And cboTemperature.Text = "F ") Or (Val(txtTemperature.Text) <> 10 And cboTemperature.Text = "C "))) Or optHoParameters.Checked = True Then
			y = hainMinutes / 60
			'R = 58.294 * Tan(Pi / 2 - y) - 0.0668 * Tan(Pi / 2 - y) * Tan(Pi / 2 - y) * Tan(Pi / 2 - y): R = 60 * R
			If GYear <= 2003 Then
				r = y + 7.31 / (y + 4.4)
				'R = R - 0.06 * Sin((14.7 * R / 60) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
			Else
				r = y + 7.32 / (y + 4.32)
			End If
			r = r * Pi / 180
			r = 1 / System.Math.Tan(r)
			If GYear <= 2003 Then r = r - 0.06 * System.Math.Sin((14.7 * (r / 60) + 13) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
			Rstd = r 'added in 5.1.4
		End If
        'R = -0.97 * Tan(((y * Pi / 180) - Atn(12 * (y + 3))))   'formula from The Calculator Afloat - better for some values of y (ha)
        '        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then RstdTP = Rstd Else RstdTP = r   'removed in 5.1.4
        RstdTP = r 'replaced previous line in 5.1.4
		'End If
		If r < 0 Then r = 0 'This line added to get rid of negative values at very high altitudes under certain circumstances
		'    Rstd = r    'Standard refraction before temperature and pressure applied
		r = r * (283 / 1010) * PX / (TX + 273) 'PX=1010, TX=10    Total Refraction    Constant was 0.28019802
		Raddl = r - RstdTP
		''    Rstd = RstdTP       'to make the proper Main correction print     removed in 5.1.4
		If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then Rstd = RstdA2
	End Sub
	
	Public Function EstimatedPosition() As Object
		'If PL = 2 Then EstL = L: EstLo = Lo: Exit Function
		Intercept = System.Math.Sign(Intercept) * Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 'added in V4.0.0
		'ZN = Int(ZN + 0.5)                              'added in V4.0.0
		If cboPolaris.Text <> "Latitude by altitude of Polaris" Then ZN = Int(ZN + 0.5) 'changed above line to this in V4.3.1
		EstL = Lat - (Intercept / 60) * System.Math.Cos(ZN * Pi / 180)
		EstLo = Lo + (Intercept / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(Lat * Pi / 180)
		If System.Math.Abs(EstLo) > 180 Then EstLo = -System.Math.Sign(EstLo) * (360 - System.Math.Abs(EstLo))
		EstLDeg = Int(System.Math.Abs(EstL))
		EstLMin = (System.Math.Abs(EstL) - EstLDeg) * 60
		If Int(EstLMin * 10 + 0.5) / 10 = 60 Then EstLMin = 0 : EstLDeg = EstLDeg + 1
		'EstLDeg = Abs(EstLDeg)
		EstLoDeg = Int(System.Math.Abs(EstLo))
		EstLoMin = (System.Math.Abs(EstLo) - EstLoDeg) * 60
		If Int(EstLoMin * 10 + 0.5) / 10 = 60 Then EstLoMin = 0 : EstLoDeg = EstLoDeg + 1
		EstLoDeg = System.Math.Abs(EstLoDeg)
	End Function
	Public Sub Moon()
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
		'DI = 56204.92 * Sin(HP): DI = DI / 60       'this is geocentric semidiameter
		'DI = (0.2724 * HP * 180 / Pi) * 60          'this is geocentric semidiameter, Nautical Almanac formula
		DI = 5974556.667 / Delta 'this is geocentric semidiameter, simple formula from Meeus (was in arcseconds)
		''DI=DI*(1+sin(hainminutes/60*Pi/180)*sin(HP))       'simple conversion from geocentric semidiameter to topocentric semidiameter
		''Aug = DI * (1 + Sin(hainMinutes / 60 * Pi / 180) * Sin(HP)) - DI   'Augmentation of moon's semidiameter
		HP = HP * 180 / Pi * 60 'arcminutes
		L1 = L1 + NL 'apparent longitude
		L1 = L1 * Pi / 180
		B = B * Pi / 180
		EclipticToEquatorial()
		AR = AR * 180 / Pi 'for Meeus ecl-to-eq
		DE = DE * 180 / Pi 'for Meeus ecl-to-eq
		
	End Sub
	Public Sub Planets()
		'L is heliocentric, ecliptic longitude, radians
		'B is heliocentric, ecliptic latitude, radians
		'r is heliocentric distance, astronomical units
		Delta = 0 : Tau = 0
		T = T / 10
		For i = 1 To 3
			If i > 1 Then T = (JD - 2451545 - Tau) / 365250
			If BN = 58 Then
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
			If BN = 59 Then
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
			If BN = 60 Then
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
			If BN = 61 Then
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
				If System.Math.Abs(L0) > (2 * Pi) Then L0 = L0 - 2 * Pi * Int(L0 / 2 / Pi)
				'L0Sun = L0
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
		
		EclipticToEquatorial()
		AR = AR * 180 / Pi
		DE = DE * 180 / Pi
		
	End Sub
	
	Public Sub LatByPolaris()
		PolarisMeans()
		LatLong()
		ZoneTime()
		Greenwich()
		Delta_T()
		Julian()
		Stars()
		DE1 = DE
		HourAngles()
		LR = GHAAries - Lo
		If LR < 0 Then LR = LR + 360
		If LR >= 360 Then LR = LR - 360
		XD = Int(LR) : XM = (LR - XD) * 60 : XM = Int(XM * 10 + 0.5) / 10 : If XM = 60 Then XM = 0 : XD = XD + 1
		Pola0 = -(90 - MeanDecPol) * System.Math.Cos((LR + MeanSHAPol) * Pi / 180) + 0.5 * (90 - MeanDecPol) * System.Math.Sin((90 - MeanDecPol) * Pi / 180) * (System.Math.Sin((LR + MeanSHAPol) * Pi / 180)) ^ 2 * System.Math.Tan(50 * Pi / 180)
		Pola0 = 60 * Pola0 + 58.8
		Pola0deg = 0 : Pola0min = Pola0
		If Pola0 >= 60 Then Pola0deg = 1 : Pola0min = Pola0 - 60
		LforPol = Lat
		If (txtLDeg.Text = "" And txtLMin.Text = "") Then LforPol = HoinMinutes / 60 'Hoinminutes/60 is approximate latitude in degrees
		'    LforPol = HoinMinutes / 60
		Dim Lfora2 As Double
		'Lfora2 = LforPol
		Select Case LforPol
			Case Is < 5
				LforPol = 0
			Case Is < 15
				LforPol = 10
			Case Is < 25
				LforPol = 20
			Case Is < 35
				LforPol = 30
			Case Is < 42.5
				LforPol = 40
			Case Is < 47.5
				LforPol = 45
			Case Is < 52.5
				LforPol = 50
			Case Is < 57.5
				LforPol = 55
			Case Is < 61
				LforPol = 60
			Case Is < 63
				LforPol = 62
			Case Is < 65
				LforPol = 64
			Case Is < 67
				LforPol = 66
			Case Is < 69
				LforPol = 68
		End Select
		'Pola1 = 0.5 * (90 - MeanDecPol) * Sin((90 - MeanDecPol) * Pi / 180) * (Sin((LR + MeanSHAPol) * Pi / 180)) ^ 2 * (Tan(LforPol * Pi / 180) - Tan(50 * Pi / 180))
		Pola1 = 0.5 * (90 - DE) * System.Math.Sin((90 - DE) * Pi / 180) * (System.Math.Sin((LR + SH) * Pi / 180)) ^ 2 * (System.Math.Tan(LforPol * Pi / 180)) - 0.5 * (90 - MeanDecPol) * System.Math.Sin((90 - MeanDecPol) * Pi / 180) * (System.Math.Sin((LR + MeanSHAPol) * Pi / 180)) ^ 2 * (System.Math.Tan(50 * Pi / 180))
		'Pola1 = 0.5 * (90 - DE) * Sin((90 - DE) * Pi / 180) * (Sin((LR + SH) * Pi / 180)) ^ 2 * (Tan(LforPol * Pi / 180)) - 0.5 * (90 - DE) * Sin((90 - DE) * Pi / 180) * (Sin((LR + SH) * Pi / 180)) ^ 2 * (Tan(50 * Pi / 180))
		Pola1 = 60 * Pola1 + 0.6
		Pola2 = (90 - MeanDecPol) * System.Math.Cos((LR + MeanSHAPol) * Pi / 180) - (90 - DE) * System.Math.Cos((LR + SH) * Pi / 180)
		Pola2 = 60 * Pola2 + 0.6
		'Pola2 = 60 + 60 * (Lfora2 - Hc) - Pola0 - Pola1       'alternative a2?
		Pola0min = Int(10 * Pola0min + 0.5) / 10
		Pola1 = Int(10 * Pola1 + 0.5) / 10
		Pola2 = Int(10 * Pola2 + 0.5) / 10
		PC = Pola0deg * 60 + Pola0min + Pola1 + Pola2
		PCdeg = 0 : PCmin = PC
		If PC >= 60 Then PCdeg = 1 : PCmin = PC - 60
		PCorr = PC - 60
		
		Stars()
		HourAngles()
		
		T = THour1 : JDHour = JDHour1 ': AR = AR1
		Obliquity()
		Nutation()
		HourAnglesHour()
		GHAHour1 = GHAHour
		IandC()
		AltitudeCorrection()
		LawOfCosines()
		LP = LHA * Pi / 180 : HD = "N"
		
		P0 = 90 - DE 'polar distance (degrees)
		'    'L0 = Ho
		L0 = HoinMinutes / 60
Line9820: 
		'    LbyPol = HoinMinutes / 60 - P0 * Cos(LP) + 0.5 * P0 * Sin(P0 * Pi / 180) * Sin(LP) * Sin(LP) * Tan(L0 * Pi / 180)     'removed this line to make math work
		'    LbyPol = (HoinMinutes + PCorr) / 60                                                                                     'added this line to make math work
		LbyPol = (HoDeg * 60 + HoMin + PCorr) / 60 'changed to this in V5.1.5 to make math work better
		'    'L = L0 - P0 * Cos(LP) + 0.5 * P0 * Sin(P0 * Pi / 180) * Sin(LP) * Sin(LP) * Tan(L0 * Pi / 180)
		If System.Math.Abs(LbyPol - L0) < 0.000001 Then GoTo Line9870
		L0 = LbyPol : GoTo Line9820
Line9870: 
		
		
		
		PD2 = Fix(LbyPol) : PM = (LbyPol - PD2) * 60 : PM = Int(PM * 10 + 0.5) / 10 : If PM = 60 Then PM = 0 : PD2 = PD2 + 1
		
		
		
		Ldiff = System.Math.Abs(LbyPol - Lat)
		ldiffDeg = Int(Ldiff) : ldiffMin = (Ldiff - ldiffDeg) * 60 : ldiffMin = Int(ldiffMin * 10 + 0.5) / 10 : If ldiffMin = 60 Then ldiffMin = 0 : ldiffDeg = ldiffDeg + 1
		EstimatedPosition()
		DisplaySR()
		DisplayPolaris() : cmdSave.Visible = False : cmdMerDiag.Visible = False
	End Sub
	
	Public Function DisplayPolaris() As Object
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 6460
		lblm.Visible = False : lblSmallm.Visible = False
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(32), "LATITUDE by ALTITUDE of POLARIS")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("LHA Aries      " & VB6.Format(XD, "##0") & Chr(176) & VB6.Format(XM, "00.0") & "'", TAB(38), "Polaris Correction", TAB(73), "Latitude Computation")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42), "a0     " & VB6.Format(Pola0deg, "0") & Chr(176) & VB6.Format(Pola0min, "00.0") & "'", TAB(77), "Ho     ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(86 - Len(Str(Val(CStr(HoDeg))))), "-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(87 - Len(Str(Val(CStr(HoDeg))))), VB6.Format(HoDeg, "##0") & Chr(176) & VB6.Format(HoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42), "a1       " & VB6.Format(Pola1, "00.0") & "'", TAB(75), "Corr (")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr = 0 Then Print(" )    00.0'") 'PCorr was PCorr2
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr > 0 Then Print("+)    ") 'PCorr was PCorr2
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr < 0 Then Print("-)    ") 'PCorr was PCorr2
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr <> 0 Then Print(VB6.Format(System.Math.Abs(PCorr), "00.0") & "'") 'PCorr was PCorr2
		PL = "N" : If LbyPol < 0 Then PL = "S"
		If LbyPol = 0 Then PL = " "
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42), "a2       " & VB6.Format(Pola2, "00.0") & "'", TAB(76), "Lat     ", TAB(87 - Len(Str(PD2))), VB6.Format(System.Math.Abs(PD2), "#0") & Chr(176) & VB6.Format(System.Math.Abs(PM), "00.0") & "'" & PL)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(39), "Total", TAB(51 - Len(Str(PCdeg))), VB6.Format(PCdeg, "0") & Chr(176) & VB6.Format(PCmin, "00.0") & "'", TAB(73))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (BN = 0 And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then Print("DR Lat   ", TAB(87 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(41), "    (-) 1" & Chr(176) & "00.0'", TAB(73))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (BN = 0 And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then Print("l diff", TAB(87 - Len(Str(ldiffDeg))), VB6.Format(ldiffDeg, "0") & Chr(176) & VB6.Format(ldiffMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(40), "Corr (")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr = 0 Then Print(" )   00.0'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr > 0 Then Print("+)   ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr < 0 Then Print("-)   ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If PCorr <> 0 Then Print(VB6.Format(System.Math.Abs(PCorr), "00.0") & "'", TAB(77), "Zn      " & VB6.Format(Int(ZN * 10 + 0.5) / 10, "##0.0") & Chr(176))
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("EP L  ", TAB(11 - Len(Str(PD2))), VB6.Format(System.Math.Abs(PD2), "#0") & Chr(176) & VB6.Format(System.Math.Abs(PM), "00.0") & "'" & PL)
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("EP Lo ", TAB(11 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text)
	End Function
	
	Public Sub DisplayLOC()
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 6460
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(23), "INTERCEPT and AZIMUTH by the LAW of COSINES METHOD")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "LHA", TAB(53 - Len(Str(LHADeg))), VB6.Format(LHADeg, "0") & Chr(176) & VB6.Format(LHAMin, "00.0") & "'", TAB(60), "-------> LHA", TAB(81 - Len(Str(LHADeg))), VB6.Format(LHA, "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "Lat", TAB(53 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(LMin), "00.0") & "'" & cboL.Text, TAB(60), "-------> Lat (+)", TAB(81 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(System.Math.Abs(Lat), "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "Dec", TAB(53 - Len(Str(TotDecDegrees))), VB6.Format(System.Math.Abs(TotDecDegrees), "0") & Chr(176) & VB6.Format(TotDecMinutes, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotDE < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(60), "-------> Dec (")
		'If Sgn(L) = Sgn(DE) Then Print "+)";
		'If Sgn(L) <> Sgn(DE) Then Print "-)";
		'If DE = 0 Then Print ""; Else Print cboDec.Text;
		'Print Tab(60); "-------> Dec ("; SignDE$; ")";
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (TotDE <= 0 And cboL.Text = "N ") Or (TotDE >= 0 And cboL.Text = "S ") Then
			Print("-)")
		Else
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+)")
		End If
		
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(81 - Len(Str(TotDecDegrees))), VB6.Format(System.Math.Abs(TotDE), "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("(cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc ---->" & "   Hc " & VB6.Format(Int(Hc * 100000 + 0.5) / 100000, "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("(sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z ----->" & "   Z  " & cboL.Text & VB6.Format(Int(Z * 10 + 0.5) / 10, "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Hc) = -1 Then Print(TAB(7 - Len(Str(HcDeg))), "-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(8 - Len(Str(HcDeg))), VB6.Format(System.Math.Abs(HcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HcMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(7 - Len(Str(HoDeg))), "-")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(8 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		'Print " a"; Tab(13 - Len(Str$(Round(Abs(Intercept), 1)))); Format(Round(Abs(Intercept), 1), "0.0"); " nm ";
		i = Len(Str(Int(System.Math.Abs(Intercept) * 10 + 0.5))) : If System.Math.Abs(Intercept) < 1 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" a", TAB(12 - i), VB6.Format((Int(System.Math.Abs(Intercept) * 10 + 0.5)) / 10, "0.0") & " nm ")
		'If displayed value of a is 0 do not print T or Intercept
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 <> 0 And Intercept < 0 Then Print("T  Ho > Hc....Toward")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 <> 0 And Intercept > 0 Then Print("A  Hc > Ho....Away")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(70), "Zn " & VB6.Format(ZN, "000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'") 'Tab(10 - Len(Str$(EstLDeg)));
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'") 'Tab(28 - Len(Str$(EstLoDeg)));
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		DisplayTimeDiagram()
	End Sub
	
	Public Function FixData() As Object
		IJ = 0 : If II > 10 Then IJ = II - Int(II / 10) * 10
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData1 = New Object(){FZH(1 + IJ), FZM(1 + IJ), FZS(1 + IJ), FZN(1 + IJ), FMI(1 + IJ), FL(1 + IJ), FLo(1 + IJ), BF(1 + IJ), FLD(1 + IJ), FLM(1 + IJ), FD(1 + IJ), FMD(1 + IJ), FMM(1 + IJ), FLA(1 + IJ), FM(1 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData2 = New Object(){FZH(2 + IJ), FZM(2 + IJ), FZS(2 + IJ), FZN(2 + IJ), FMI(2 + IJ), FL(2 + IJ), FLo(2 + IJ), BF(2 + IJ), FLD(2 + IJ), FLM(2 + IJ), FD(2 + IJ), FMD(2 + IJ), FMM(2 + IJ), FLA(2 + IJ), FM(2 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData3 = New Object(){FZH(3 + IJ), FZM(3 + IJ), FZS(3 + IJ), FZN(3 + IJ), FMI(3 + IJ), FL(3 + IJ), FLo(3 + IJ), BF(3 + IJ), FLD(3 + IJ), FLM(3 + IJ), FD(3 + IJ), FMD(3 + IJ), FMM(3 + IJ), FLA(3 + IJ), FM(3 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData4 = New Object(){FZH(4 + IJ), FZM(4 + IJ), FZS(4 + IJ), FZN(4 + IJ), FMI(4 + IJ), FL(4 + IJ), FLo(4 + IJ), BF(4 + IJ), FLD(4 + IJ), FLM(4 + IJ), FD(4 + IJ), FMD(4 + IJ), FMM(4 + IJ), FLA(4 + IJ), FM(4 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData5 = New Object(){FZH(5 + IJ), FZM(5 + IJ), FZS(5 + IJ), FZN(5 + IJ), FMI(5 + IJ), FL(5 + IJ), FLo(5 + IJ), BF(5 + IJ), FLD(5 + IJ), FLM(5 + IJ), FD(5 + IJ), FMD(5 + IJ), FMM(5 + IJ), FLA(5 + IJ), FM(5 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData6 = New Object(){FZH(6 + IJ), FZM(6 + IJ), FZS(6 + IJ), FZN(6 + IJ), FMI(6 + IJ), FL(6 + IJ), FLo(6 + IJ), BF(6 + IJ), FLD(6 + IJ), FLM(6 + IJ), FD(6 + IJ), FMD(6 + IJ), FMM(6 + IJ), FLA(6 + IJ), FM(6 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData7 = New Object(){FZH(7 + IJ), FZM(7 + IJ), FZS(7 + IJ), FZN(7 + IJ), FMI(7 + IJ), FL(7 + IJ), FLo(7 + IJ), BF(7 + IJ), FLD(7 + IJ), FLM(7 + IJ), FD(7 + IJ), FMD(7 + IJ), FMM(7 + IJ), FLA(7 + IJ), FM(7 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData8 = New Object(){FZH(8 + IJ), FZM(8 + IJ), FZS(8 + IJ), FZN(8 + IJ), FMI(8 + IJ), FL(8 + IJ), FLo(8 + IJ), BF(8 + IJ), FLD(8 + IJ), FLM(8 + IJ), FD(8 + IJ), FMD(8 + IJ), FMM(8 + IJ), FLA(8 + IJ), FM(8 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData9 = New Object(){FZH(9 + IJ), FZM(9 + IJ), FZS(9 + IJ), FZN(9 + IJ), FMI(9 + IJ), FL(9 + IJ), FLo(9 + IJ), BF(9 + IJ), FLD(9 + IJ), FLM(9 + IJ), FD(9 + IJ), FMD(9 + IJ), FMM(9 + IJ), FLA(9 + IJ), FM(9 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData10. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData10 = New Object(){FZH(10 + IJ), FZM(10 + IJ), FZS(10 + IJ), FZN(10 + IJ), FMI(10 + IJ), FL(10 + IJ), FLo(10 + IJ), BF(10 + IJ), FLD(10 + IJ), FLM(10 + IJ), FD(10 + IJ), FMD(10 + IJ), FMM(10 + IJ), FLA(10 + IJ), FM(10 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData11 = New Object(){FZH(11 + IJ), FZM(11 + IJ), FZS(11 + IJ), FZN(11 + IJ), FMI(11 + IJ), FL(11 + IJ), FLo(11 + IJ), BF(11 + IJ), FLD(11 + IJ), FLM(11 + IJ), FD(11 + IJ), FMD(11 + IJ), FMM(11 + IJ), FLA(11 + IJ), FM(11 + IJ)}
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData12. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData12 = New Object(){FZH(12 + IJ), FZM(12 + IJ), FZS(12 + IJ), FZN(12 + IJ), FMI(12 + IJ), FL(12 + IJ), FLo(12 + IJ), BF(12 + IJ), FLD(12 + IJ), FLM(12 + IJ), FD(12 + IJ), FMD(12 + IJ), FMM(12 + IJ), FLA(12 + IJ), FM(12 + IJ)}
	End Function
	
	Public Sub WriteFixScreen()
		'UPGRADE_ISSUE: Form method Form4.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Form4.Cls()
		'UPGRADE_ISSUE: Form property Form4.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Form4.CurrentY = 1000
		IV = IU : If IU > 12 Then IV = 12
		For IW = 1 To IV
			i = IW : If IU > 12 Then i = IW + IU - Int((IU - 1) / 12) * 12
			'If i > 10 Then i = i - 10
			'Form4.Print Tab(3); Format(FIU(i), "##");
			'UPGRADE_WARNING: Couldn't resolve default property of object BF(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(9), BF(i))
			'UPGRADE_WARNING: Couldn't resolve default property of object FZS(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FZM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(27), VB6.Format(FZH(i), "00") & "-" & VB6.Format(FZM(i), "00") & "-" & VB6.Format(FZS(i), "00"))
			'UPGRADE_WARNING: Couldn't resolve default property of object FD(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMI(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(44), VB6.Format(System.Math.Abs(FMI(i)), "0.0") & " " & FD(i))
			'Form4.Print Tab(47 - Len(Str$(Val(Round(Abs(FMI(i)), 1))))); Format(Abs(FMI(i)), "0.0"); " "; FD(i);
			'Form4.Print Tab(48 - Len(Round(Abs(FMI(i)), 1))); Format(Abs(FMI(i)), "0.0"); " "; FD(i);
			'UPGRADE_WARNING: Couldn't resolve default property of object FZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(56), VB6.Format(FZN(i), "000") & Chr(176))
			'UPGRADE_WARNING: Couldn't resolve default property of object FLA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FLM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FLD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(70 - Len(Str(Val(FLD(i))))), VB6.Format(Val(FLD(i)), "#0") & Chr(176) & VB6.Format(Val(FLM(i)), "00.0") & "'" & FLA(i))
			'UPGRADE_WARNING: Couldn't resolve default property of object FM(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print(TAB(86 - Len(Str(Val(FMD(i))))), VB6.Format(Val(FMD(i)), "##0") & Chr(176) & VB6.Format(Val(FMM(i)), "00.0") & "'" & FM(i))
			'UPGRADE_ISSUE: Form method Form4.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form4.Print()
		Next IW
	End Sub
	
	Public Sub DisplayTimeDiagram()
		Dim XTD1, YTD1 As Single
		Dim XTD2, YTD2 As Single
		Dim TwoPi, i As Single
		'Form1.Font.Name = "MS Sans Serif"
		TwoPi = 8 * System.Math.Atan(1)
		'UPGRADE_ISSUE: Form method Form1.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Scale (-4805, 4510) - (5305, -4010)
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		Show()
		'UPGRADE_ISSUE: Form method Form1.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Circle (0, 0), 700
		For i = 0 To TwoPi Step TwoPi / 72
			XTD1 = 650 * System.Math.Cos(i) '600
			YTD1 = 650 * System.Math.Sin(i) '600
			XTD2 = 700 * System.Math.Cos(i)
			YTD2 = 700 * System.Math.Sin(i)
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (XTD1, YTD1) - (XTD2, YTD2)
		Next i
		For i = 0 To TwoPi Step TwoPi / 24
			XTD1 = 600 * System.Math.Cos(i) '550
			YTD1 = 600 * System.Math.Sin(i) '550
			XTD2 = 650 * System.Math.Cos(i) '600
			YTD2 = 650 * System.Math.Sin(i) '600
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (XTD1, YTD1) - (XTD2, YTD2)
		Next i
		lblm.Visible = True
		lblSmallm.Visible = True
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (0, 700)
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 2 'dotted line
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (0, -700)
		'Greenwich lower branch
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (700 * System.Math.Cos((-Lo - 90) * Pi / 180), 700 * System.Math.Sin((-Lo - 90) * Pi / 180))
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 5
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (850 * System.Math.Cos((-Lo - 90) * Pi / 180), 850 * System.Math.Sin((-Lo - 90) * Pi / 180))
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = CurrentY + 100
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("g")
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'Greenwich upper branch
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (700 * System.Math.Cos((-Lo + 90) * Pi / 180), 700 * System.Math.Sin((-Lo + 90) * Pi / 180))
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 5
		'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line (0, 0) - (850 * System.Math.Cos((-Lo + 90) * Pi / 180), 850 * System.Math.Sin((-Lo + 90) * Pi / 180))
		'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = CurrentY + 100
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("G")
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'Show apparent sun button for sun sights
		'If BN = 64 Or BN = 65 Then
		'    cmdApparentSun.Visible = True
		'    cmdApparentSun.Enabled = True
		'Else
		'    cmdApparentSun.Visible = False
		'    cmdApparentSun.Enabled = False
		'End If
		'Aries (if star sight)
		If BN <= 57 Then
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((-Lo + 90 + GHAAries) * Pi / 180), 700 * System.Math.Sin((-Lo + 90 + GHAAries) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((-Lo + 90 + GHAAries) * Pi / 180), 850 * System.Math.Sin((-Lo + 90 + GHAAries) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("V") 'Print "A"
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
		End If
		'Any body other than Sun
		If BN < 64 Then
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((LHA + 90) * Pi / 180), 700 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((LHA + 90) * Pi / 180), 850 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
		End If
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN <= 57 Then Print("*")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN >= 58 And BN <= 61 Then Print("P")
		'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If BN = 62 Or BN = 63 Then Print("(")
		'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0
		'Mean Sun for all sights except sun
		If BN <= 63 Then
			T = Tfull
			Sun()
			HourAngles()
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((-Lo - 90 + HG * 15) * Pi / 180), 700 * System.Math.Sin((-Lo - 90 + HG * 15) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((-Lo - 90 + HG * 15) * Pi / 180), 850 * System.Math.Sin((-Lo - 90 + HG * 15) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("O")
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
		End If
		'Apparent sun for sun sight
		If BN = 64 Or BN = 65 Then
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (700 * System.Math.Cos((LHA + 90) * Pi / 180), 700 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
			'UPGRADE_ISSUE: Form method Form1.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Me.Line (0, 0) - (850 * System.Math.Cos((LHA + 90) * Pi / 180), 850 * System.Math.Sin((LHA + 90) * Pi / 180))
			'UPGRADE_ISSUE: Form property Form1.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			CurrentY = CurrentY + 100
			'UPGRADE_ISSUE: Form method Form1.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("o")
			'UPGRADE_ISSUE: Form property Form1.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 0
		End If
		
	End Sub
	
	Public Function PolarisMeans() As Object
		MeanSHAPol = 0 : MeanDecPol = 0 ': GHour = 12 : GMinute = 0: GSecond = 0
		For MonthPolaris = 1 To 12
			GreenwichForPolaris()
			Delta_T()
			JulianForPolaris()
			'        Obliquity
			'        Nutation
			Stars()
			HourAngles()
			MeanSHAPol = MeanSHAPol + SH
			MeanDecPol = MeanDecPol + DE
		Next MonthPolaris
		MeanSHAPol = (MeanSHAPol / 12) '- 0.033333       'without -0.033333 MeanSHAPol averages about 2' greater than stated on page 256 of the Nautical Almanac (2009-2015 tested)
		'Removed -0.033333 in V5.3.1 based on 21 sample years.  Worst years were some from 2009-2017, averaging 1.0777...' high, requiring a correction of approx. -0.018, but this made many years worse.
		'Debug.Print MeanSHAPol
		'MeanSHAPol = (MeanSHAPol - Int(MeanSHAPol)) * 60
		'Debug.Print MeanSHAPol
		MeanDecPol = (MeanDecPol / 12)
	End Function
	
	Public Function GreenwichForPolaris() As Object
		'Prefix (or suffix) G for Greenwich, UT = Universal Time
		MonthDays = "312831303130313130313031"
		'Check for local leap year
		LocalYear = Val(txtYear.Text)
		If (LocalYear Mod 4) = 0 Then LeapYear = True
		If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then LeapYear = False
		'If LeapYear = True Then MonthDays$ = "312931303130313130313031"
		'If BN = 0 And cboPolaris.Text = "Latitude by altitude of Polaris" Then MonthNumber = MonthPolaris Else _
		''    MonthNumber = cboMonth.ListIndex + 1
		DayNumber = 0
		For i = 1 To MonthPolaris - 1
			DayNumber = Val(Mid(MonthDays, 2 * i - 1, 2)) + DayNumber
		Next i
		If MonthPolaris >= 3 And LeapYear = True Then DayNumber = DayNumber + 1
		'    DayNumber = DayNumber + 15     'to middle of month         ELIMINATING THIS LINE in V5.3.1 MADE FOR BETTER a2 (and a0)
		GYear = Val(txtYear.Text) : GDayOfYear = DayNumber
		'If GHour >= 24 Then GHour = GHour - 24: GDayOfYear = GDayOfYear + 1
		If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then GDayOfYear = 1 : GYear = GYear + 1 : GoTo GreenwichDate
		'If GHour < 0 Then GHour = GHour + 24: GDayOfYear = GDayOfYear - 1
		'If GDayOfYear = 0 Then GYear = GYear - 1
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
	
	Public Function JulianForPolaris() As Object 'UNFINISHED?
		DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400!)
		DecimalDateHour1 = GDay + (GHour / 24)
		DecimalDateHour2 = GDay + ((GHour + 1) / 24)
		GYearJ = GYear
		GMonth = MonthPolaris
		If GMonth < 3 Then GYearJ = GYear - 1 : GMonth = GMonth + 12
		JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
		T = (JD - 2451545 + DeltaT / 86400) / 36525!
	End Function
	
	Public Function Delta_T() As Object 'http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html
		DecYr = GYear + (GMonth - 0.5) / 12
		If GYear >= 1901 And GYear <= 1920 Then Theta = DecYr - 1900 : DeltaT = -2.79 + 1.494119 * Theta - 0.0598939 * Theta ^ 2 + 0.0061966 * Theta ^ 3 - 0.000197 * Theta ^ 4
		If GYear >= 1921 And GYear <= 1941 Then Theta = DecYr - 1920 : DeltaT = 21.2 + 0.84493 * Theta - 0.0761 * Theta ^ 2 + 0.0020936 * Theta ^ 3
		If GYear >= 1942 And GYear <= 1961 Then Theta = DecYr - 1950 : DeltaT = 29.07 + 0.407 * Theta - (Theta ^ 2) / 233 + (Theta ^ 3) / 2547
		If GYear >= 1962 And GYear <= 1986 Then Theta = DecYr - 1975 : DeltaT = 45.45 + 1.067 * Theta - (Theta ^ 2) / 260 - (Theta ^ 3) / 718
		If GYear >= 1987 And GYear <= 2005 Then Theta = DecYr - 2000 : DeltaT = 63.86 + 0.3345 * Theta - 0.060374 * Theta ^ 2 + 0.0017275 * Theta ^ 3 + 0.000651814 * Theta ^ 4 + 0.00002373599 * Theta ^ 5
		If GYear >= 2006 And GYear <= 2050 Then Theta = DecYr - 2000 : DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2
		If GYear >= 2051 And GYear <= 2099 Then DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)
	End Function
	
	Public Sub IandC()
		If (BN >= 58 And BN <= 61) Or BN = 64 Or BN = 65 Then k = 15 'sun/planets
		If BN <= 57 Then k = 15.04106864 'stars
		If BN = 62 Or BN = 63 Then k = 14 + 19 / 60 'moon
		
		
		If BN = 62 Or BN = 63 Then 'moon, use rounded values
			GHAHourDeg1 = Int(GHAHour1) : GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60 : GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
			If GHAHourMin1 = 60 Then GHAHourMin1 = 0 : GHAHourDeg1 = GHAHourDeg1 + 1
			GHAHourDeg2 = Int(GHAHour2) : GHAHourMin2 = (GHAHour2 - GHAHourDeg2) * 60 : GHAHourMin2 = Int(GHAHourMin2 * 10 + 0.5) / 10
			If GHAHourMin2 = 60 Then GHAHourMin2 = 0 : GHAHourDeg2 = GHAHourDeg2 + 1
			HourChange = (GHAHourDeg2 + GHAHourMin2 / 60) - (GHAHourDeg1 + GHAHourMin1 / 60)
		End If
		
		'not moon
		'HourChange = (GHAHourDeg2 + GHAHourMin2 / 60) - (GHAHourDeg1 + GHAHourMin1 / 60)
		If BN <> 62 And BN <> 63 Then HourChange = GHAHour2 - GHAHour1
		If HourChange < 0 Then HourChange = HourChange + 360
		vvalue = HourChange - k : vvalue = vvalue * 60
		vvalue = Int(vvalue * 10 + 0.5) / 10 'This line was lower
		'    If GMinute = 0 And GSecond = 0 Then vvalue = 0  'Add this line to not add correction to whole hour value
		If (BN <= 57 And BN >= 62) Or (BN > 57 And BN < 62 And cboPlanets.Text = "Accurate vals. of v/d") And GMinute = 0 And GSecond = 0 Then vvalue = 0
		
		SignHourChange = System.Math.Sign(vvalue)
		GHAIncrement = k * (GMinute + GSecond / 60) / 60
		vcorr = vvalue * (GMinute + 0.5) / 60
		
		GHAIncrementDeg = Int(GHAIncrement)
		GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
		GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10
		'vvalue = Int(vvalue * 10 + 0.5) / 10
		'vcorr = Int(vcorr * 10 + 0.50000000000001) / 10
		vcorr = System.Math.Sign(vcorr) * Int(System.Math.Abs(vcorr) * 10 + 0.50000000000001) / 10
		If (GMinute = 22 And vvalue = 2.8) Then vcorr = 1#
		If (GMinute = 22 And vvalue = 16.4) Then vcorr = 6.1
		If (GMinute = 42 And vvalue = 15.6) Then vcorr = 11.1
		If (GMinute = 52 And vvalue = 13.2) Then vcorr = 11.6
		If (GMinute = 52 And vvalue = 17.2) Then vcorr = 15.1
		If (GMinute = 55 And vvalue = 18) Then vcorr = 16.7
		If (GMinute = 57 And vvalue = 13.2) Then vcorr = 12.7
		If GMinute = 0 And GSecond = 0 Then vcorr = 0 'Add this line to not add correction to whole hour value
		
		If GYear <= 2001 And (GMinute = 22 And vvalue = 2.8) Then vcorr = 1#
		If GYear <= 2001 And (GMinute = 22 And vvalue = 16.4) Then vcorr = 6.1
		If GYear <= 2001 And (GMinute = 52 And vvalue = 9.2) Then vcorr = 8.1
		If GYear <= 2001 And (GMinute = 52 And vvalue = 16.4) Then vcorr = 14.4
		
		GHAHourDeg1 = Int(GHAHour1) : GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60 : GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
		If GHAHourMin1 = 60 Then GHAHourMin1 = 0 : GHAHourDeg1 = GHAHourDeg1 + 1
		
		If BN <= 57 Then
			If StarNAFlag = False Then TotGHA = SHdeg + SHmin / 60 + GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60
			If StarNAFlag = True Then TotGHA = SHdegDisplay + SHminDisplay / 60 + GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60
		End If
		'If BN <= 57 Then TotGHA = SH + GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrement
		'    If BN <= 57 Then TotGHA = Int(SH * 600 + 0.5) / 10 + GHAHourDeg1 * 60 + GHAHourMin1 + Int(GHAIncrement * 600 + 0.5) / 10: TotGHA = TotGHA / 60
		
		
		If BN >= 58 Then
			TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
			If BN <> 64 And BN <> 65 Or ((BN = 64 Or BN = 65) And cboSun.Text = "Accurate val. of hourly GHA") Then TotGHA = TotGHA + System.Math.Sign(HourChange) * vcorr / 60
			'If (BN = 64 Or BN = 65) And cboSun.text = "Accurate val. of hourly GHA" Then TotGHA = TotGHA + Sgn(HourChange) * vcorr / 60 'NEW LINE, COMBINE WITH PREVIOUS LINE
			
		End If
		'If BN >= 58 Then TotGHA = GHAHourDeg1 * 60 + GHAHourMin1 + Int(GHAIncrement * 600 + 0.5) / 10 + Sgn(HourChange) * vcorr: TotGHA = TotGHA / 60
		TotGHADeg = Int(TotGHA) : TotGHAMin = (TotGHA - TotGHADeg) * 60
		TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
		If TotGHAMin = 60 Then TotGHAMin = 0 : TotGHADeg = TotGHADeg + 1
		If TotGHADeg >= 360 Then TotGHADeg = TotGHADeg - 360
		'LHA = TotGHA - Lo
		LHA = TotGHADeg + TotGHAMin / 60 - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		LHADeg = Int(LHA) : LHAMin = (LHA - LHADeg) * 60
		If Int(LHAMin * 10 + 0.5) / 10 = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
		
		
		If BN = 62 Or BN = 63 Then 'moon, use rounded values
			DecDegrees = Int(System.Math.Abs(DE1)) : DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60 : DecMinutes = Int(DecMinutes * 10 + 0.5) / 10
			If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0 : DecDegrees = DecDegrees + 1
			DecDegrees2 = Int(System.Math.Abs(DE2)) : DecMinutes2 = (System.Math.Abs(DE2) - DecDegrees2) * 60 : DecMinutes2 = Int(DecMinutes2 * 10 + 0.5) / 10
			If Int(DecMinutes2 * 10 + 0.5) / 10 = 60 Then DecMinutes2 = 0 : DecDegrees2 = DecDegrees2 + 1
			dvalue = (System.Math.Sign(DE2) * (DecDegrees2 + DecMinutes2 / 60) - System.Math.Sign(DE1) * (DecDegrees + DecMinutes / 60)) * 60
		End If
		'not moon
		'dvalue = Abs(DE2 - DE1) * 60: Signdvalue = Sgn(Abs(DE2) - Abs(DE1)): If dvalue < 0.05 Then Signdvalue = 0
		If BN <> 62 And BN <> 63 Then dvalue = (DE2 - DE1) * 60
		'next line added sun stuff in V5.3.1
		If ((BN > 57 And BN < 62) And cboPlanets.Text = "NA vals. of v/d") Or (BN = 64 Or BN = 65 And cboSun.Text = "NA val. of hourly GHA/d") Then dvalue = (DENA2 - DENA1) * 60
		dvalue = Int(System.Math.Abs(dvalue) * 10 + 0.5) / 10 'This line was lower
		Signdvalue = 1 : If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then Signdvalue = -1
		'Signdvalue = Sgn(dvalue)
		'If Sgn(DE2) <> Sgn(DE1) And Abs(DE2) > Abs(DE1) Then Signdvalue = -Signdvalue
		
		'If StarNAFlag = False Then DecDegrees = Int(Abs(DE1)): DecMinutes = (Abs(DE1) - DecDegrees) * 60
		'If StarNAFlag = True Then DecDegrees = Int(Abs(DENA)): DecMinutes = (Abs(DENA) - DecDegrees) * 60
		DecDegrees = Int(System.Math.Abs(DE1)) : DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
		If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0 : DecDegrees = DecDegrees + 1
		
		If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then Signdvalue = -1
		dvalue = System.Math.Abs(dvalue)
		If GMinute = 0 And GSecond = 0 Then dvalue = 0 'Add this line to not add correction to whole hour value
		If dvalue < 0.05 Then Signdvalue = 0
		dcorr = dvalue * (GMinute + 0.5) / 60
		'dvalue = Int(Abs(dvalue) * 10 + 0.5) / 10
		dcorr = Int(System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10
		If GMinute = 0 And GSecond = 0 Then dcorr = 0 'Add this line to not add correction to whole hour value
		
		If GYear <= 2001 And (GMinute = 22 And dvalue = 2.8) Then dcorr = 1#
		If GYear <= 2001 And (GMinute = 22 And dvalue = 16.4) Then dcorr = 6.1
		If GYear <= 2001 And (GMinute = 52 And dvalue = 9.2) Then dcorr = 8.1
		If GYear <= 2001 And (GMinute = 52 And dvalue = 16.4) Then dcorr = 14.4
		'If BN <= 57 Then TotDE = DE1 Else TotDE = Sgn(DE1) * (Abs(DE1) + Signdvalue * dcorr / 60)
		If BN <= 57 And StarNAFlag = False Then TotDE = DE1
		If BN <= 57 And StarNAFlag = True Then TotDE = DENA
		If BN > 57 Then TotDE = System.Math.Sign(DE1) * (Int(System.Math.Abs(DE1) * 600 + 0.5) / 10 + Signdvalue * dcorr) : TotDE = TotDE / 60
		'TotDE = DE1 + Signdvalue * dcorr / 60
		'If Sgn(DE1) <> Sgn(DE2) And Abs(dcorr - Abs(DE1 * 60)) >= 0.05 Then TotDE = DE1 - Signdvalue * dcorr / 60 '= Sgn(DE1) * (Abs(DE1) - Signdvalue * dcorr / 60)
		TotDecDegrees = Int(System.Math.Abs(TotDE))
		TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
		TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
		If TotDecMinutes = 60 Then TotDecMinutes = 0 : TotDecDegrees = TotDecDegrees + 1
	End Sub
	Public Sub IandCP()
		SignHourChange = System.Math.Sign(vvalue)
		GHAIncrement = 15 * (GMinute + GSecond / 60) / 60
		GHAIncrementDeg = Int(GHAIncrement)
		GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
		GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10
		vcorr = vvalue * (GMinute + 0.5) / 60
		vcorr = System.Math.Sign(vcorr) * Int(System.Math.Abs(vcorr) * 10 + 0.50000000000001) / 10
		If (GMinute = 22 And vvalue = 2.8) Then vcorr = 1#
		If (GMinute = 22 And vvalue = 16.4) Then vcorr = 6.1
		If (GMinute = 42 And vvalue = 15.6) Then vcorr = 11.1
		If (GMinute = 52 And vvalue = 13.2) Then vcorr = 11.6
		If (GMinute = 52 And vvalue = 17.2) Then vcorr = 15.1
		If (GMinute = 55 And vvalue = 18) Then vcorr = 16.7
		If (GMinute = 57 And vvalue = 13.2) Then vcorr = 12.7
		If GMinute = 0 And GSecond = 0 Then vcorr = 0 'Add this line to not add correction to whole hour value
		
		If GYear <= 2001 And (GMinute = 22 And vvalue = 2.8) Then vcorr = 1#
		If GYear <= 2001 And (GMinute = 22 And vvalue = 16.4) Then vcorr = 6.1
		If GYear <= 2001 And (GMinute = 52 And vvalue = 9.2) Then vcorr = 8.1
		If GYear <= 2001 And (GMinute = 52 And vvalue = 16.4) Then vcorr = 14.4
		
		GHAHourDeg1 = Int(GHAHour1) : GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60 : GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
		If GHAHourMin1 = 60 Then GHAHourMin1 = 0 : GHAHourDeg1 = GHAHourDeg1 + 1
		
		TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
		TotGHA = TotGHA + System.Math.Sign(HourChange) * vcorr / 60
		TotGHADeg = Int(TotGHA) : TotGHAMin = (TotGHA - TotGHADeg) * 60
		TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
		If TotGHAMin = 60 Then TotGHAMin = 0 : TotGHADeg = TotGHADeg + 1
		If TotGHADeg >= 360 Then TotGHADeg = TotGHADeg - 360
		'LHA = TotGHA - Lo
		LHA = TotGHADeg + TotGHAMin / 60 - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		LHADeg = Int(LHA) : LHAMin = (LHA - LHADeg) * 60
		If Int(LHAMin * 10 + 0.5) / 10 = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
		
		'next two lines try to fix Egbert's problem of 2/20/2016
		DecDegrees = Int(System.Math.Abs(DE1)) : DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
		If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0 : DecDegrees = DecDegrees + 1
		
		dvalue = (DENA2 - DENA1) * 60
		dvalue = Int(System.Math.Abs(dvalue) * 10 + 0.5) / 10 'This line was lower
		Signdvalue = 1 : If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then Signdvalue = -1
		
		If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then Signdvalue = -1
		dvalue = System.Math.Abs(dvalue)
		If GMinute = 0 And GSecond = 0 Then dvalue = 0 'Add this line to not add correction to whole hour value
		If dvalue < 0.05 Then Signdvalue = 0
		dcorr = dvalue * (GMinute + 0.5) / 60
		'dvalue = Int(Abs(dvalue) * 10 + 0.5) / 10
		dcorr = Int(System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10
		If GMinute = 0 And GSecond = 0 Then dcorr = 0 'Add this line to not add correction to whole hour value
		
		If GYear <= 2001 And (GMinute = 22 And dvalue = 2.8) Then dcorr = 1#
		If GYear <= 2001 And (GMinute = 22 And dvalue = 16.4) Then dcorr = 6.1
		If GYear <= 2001 And (GMinute = 52 And dvalue = 9.2) Then dcorr = 8.1
		If GYear <= 2001 And (GMinute = 52 And dvalue = 16.4) Then dcorr = 14.4
		TotDE = System.Math.Sign(DE1) * (Int(System.Math.Abs(DE1) * 600 + 0.5) / 10 + Signdvalue * dcorr) : TotDE = TotDE / 60
		'TotDE = DE1 + Signdvalue * dcorr / 60
		'If Sgn(DE1) <> Sgn(DE2) And Abs(dcorr - Abs(DE1 * 60)) >= 0.05 Then TotDE = DE1 - Signdvalue * dcorr / 60 '= Sgn(DE1) * (Abs(DE1) - Signdvalue * dcorr / 60)
		TotDecDegrees = Int(System.Math.Abs(TotDE))
		TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
		TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
		If TotDecMinutes = 60 Then TotDecMinutes = 0 : TotDecDegrees = TotDecDegrees + 1
		
		
	End Sub
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
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class