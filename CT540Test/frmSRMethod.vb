Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form8
	Inherits System.Windows.Forms.Form
	Dim DecLOC, Ho, GHA, DE, Hc, A As Double
	Dim i As Short
	Dim APEstLMin, APEstL, APEstLo, APEstLoMin As Double
	Dim APEstLDeg, APEstLoDeg As Short
	Dim LHAMin, EstLMin, EstL, EstLo, EstLoMin, Pi As Double
	Dim L8, L6, L4, L2, L1, L3, L5, L7, Z As Double
	Dim LHADeg, EstLDeg, GHADeg, EstLoDeg, HcDeg As Short
	Dim HcMin As Double
	Dim fnumeral As String
	Dim HoDeg, DecDegrees, AsmLoDeg As Short
	Dim DecMinutes, HoMin As Double
	Dim AsmLHA, GHAAsm, BMin As Double
	Dim AsmLoMin, Z1display As Single
	Dim BDeg As Short 'BMin As Integer
	Dim B1, Z3, A1, Aval, Z1, B As Double
	Dim AvalDeg, AvalMin As Short
	Dim P1, Z4, F, H, H1, Z2, P As Double
	Dim DecMinDisplay As Short
	Dim HDeg, PDeg, FMin, FDeg, AWhole, FWhole, HMin As Short
	Dim Z2Display1, Z2Display2 As Single
	Dim GHAAsmDeg, GHAAsmMin As Short
	Dim SignCorr1, SignF, SignZ1, SignB, SignDE, SignZ2, SignCorr2 As String 'LoDiff As Single
	Dim Ztot, Corr1, Corr2, HoinMinutes As Double
	Dim ZtotDisplay As Single
	Dim HtotDeg, HtotMin As Short ',Htot As Single
	Dim LengthZ2Display, LengthZ1Display, LengthZtotDisplay As Short
	Dim Z2Deg As Short
	Dim IU, II, IJ As Short
	Dim ZTTemp As Integer
	'some below not necessary
	Dim FZH(50) As Object
	Dim FZM(50) As Object
	Dim FZS(50) As Object
	Dim FMI(50) As Object
	Dim FZN(50) As Object 'these 19 variables, 50 better be enough
	Dim FLD(50) As Object
	Dim FLM(50) As Object
	Dim FL(50) As Object
	Dim FMD(50) As Object
	Dim FMM(50) As Object
	Dim FM(50) As Object
	Dim FZT(50) As Object
	Dim FUT(50) As Object
	Dim FD(50) As Object ', FA(50) As Variant
	'Dim TypeRed$, TypeReduction(50) As Variant ', FType(50) As Variant
	Dim FLA(50) As Object
	Dim FLo(50) As Object
	Public FixData4, FixData2, FixData1, FixData3, FixData5 As Object
	Public FixData9, FixData7, FixData6, FixData8, FixData10 As Object
	Public FixData11, FixData12 As Object
	Public AsmL, AsmLo As Double 'AsmL was integer
	Dim IV, IW As Short
	Dim Lo As Double
	'Dim FAPL(10) As Variant, FAPLNS(10) As Variant, FAPLo(10) As Variant, FAPLoDeg(10) As Variant, FAPLoMin(10) As Variant, FAPLoEW(10) As Variant
	Dim TR As String
	Dim Hk, VL, DL, DLo, VLo, KPLOPDist As Single
	Public Dec, ZN, L, LHA, Htot As Double
	Public FlagMD, FlagSRFLoCNASR As Boolean ' ,HoinMinutes As Double
	Dim D, DecIncr, AsmDec As Single
	Dim TabHcDeg, NextHcDeg As Short
	Dim NextHc, TabHcMin, NextHcMin As Double
	Dim SignD As String
	Dim dcorr As Single
	Dim Signdcorr As String
	Dim TotHc, TotHcMin As Double
	Dim sgnHc, TotHcDeg, sgnTotHc As Short
	Dim Zdiff, Zcorr1 As Double
	Dim SignZdiff, SignTotcorr As String
	Dim d1corr, TabZ, Zcorr As Single
	Dim Totcorr As Single
	Dim DSDcorr, d2corr As Double
	Dim SgnD As Short
	Dim NextHcDSD1, NextHcDSD1Min As Double
	Dim NextHcDSD1Deg As Short
	Dim NextHcDSD2, NextHcDSD2Min As Double
	Dim NextHcDSD2Deg As Short
	Dim NextHctP, NextHcdP, NextHcdM, NextHctM As Double
	Dim DSD3, DSD1, DSD As Single
	Dim DSD2 As Double
	Dim SgnDSD As Short
	Dim DSDcorrFlag As Boolean
	Dim ZL8, ZL6, ZL4, ZL5, ZL7, ZC As Double
	Dim T, tMin As Double
	Dim tDeg As Short
	Dim A6, A4, A2, A3, A5, A7 As Single
	Dim B4, B2, B3, B5 As Single
	Dim k, KMin As Double
	Dim KDeg As Short
	Dim tDecimal, KL, KLMin, DecDecimal As Double
	Dim KLDeg As Short
	Dim A3AngleMin, A3Angle, A3AngleDecimal As Double
	Dim A3AngleDeg As Short
	Dim HcDecimal, HcAngle, ZMin As Double
	Dim ZDeg As Short
	Dim Flag, Flag0 As Boolean
	Dim AsmDecDeg As Short
	Dim LHAdiff, AsmDecMin, Ldiff As Single
	Dim SignL, Signd2corr, SignA3 As String
	Dim B1Deg, A3Deg As Short
	Dim A3Min, B1Min, DB As Double
	Dim L2Deg, h1Deg, h2Deg, L3Deg As Short
	Dim L2Min, h1Min, h2Min, L3Min As Double
	Dim NextDec, LHADecimal, r, NextDecMin As Double
	Dim FlagFarley, FlagWeems As Boolean
	Dim NextDecDeg As Short
	Dim Btot, KdMin, N, Kd, AB, B22 As Double
	Dim KdDeg As Short 'B34 As Double
	Dim Z4Deg, ZnTDeg As Short
	Dim ZnT, Z4Min, ZnTMin As Double
	
	'UPGRADE_WARNING: Event chkDSD.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDSD_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDSD.CheckStateChanged
		cmd229_Click(cmd229, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event chkInterpolateB.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkInterpolateB_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkInterpolateB.CheckStateChanged
		cmdWeems_Click(cmdWeems, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event chkSadler.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkSadler_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSadler.CheckStateChanged
		If chkSadler.CheckState = 1 Then
			chkDSD.Visible = False ':chkDSD.Value = 0
			frameNASRUsing.Visible = False
			frame211.Visible = True ': optCompact.Value = True
			frame214.Visible = False : Label9.Visible = False
			FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
			'TypeRed = "NASR"
			DecimalDegrees()
			Sadler()
			If Flag = True Then Exit Sub
			'If cboL.text = "S " Then L = -L
			EstimatedPosition()
			DisplaySadler()
			cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
		End If
		
		If chkSadler.CheckState = 0 Then cmd211_Click(cmd211, New System.EventArgs())
	End Sub
	
	Private Sub cmd208_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd208.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = True ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		Line12.Visible = False
		Line13.Visible = False
		'TypeRed = "NASR"
		DecimalDegrees()
		HO208()
		If Flag0 = True Then Exit Sub
		'EstimatedPosition
		'AsmL = Sgn(L) * AsmL
		APEPNASR()
		KPLOPNASR()
		EPNASR()
		Display208()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmd211_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd211.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		chkSadler.CheckState = System.Windows.Forms.CheckState.Unchecked
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = True ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		HO211()
		If Flag = True Then Exit Sub
		'If cboL.text = "S " Then L = -L
		EstimatedPosition()
		Display211()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmd214_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd214.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = True: Label9.Visible = True
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		HO214()
		If optd.Checked = True Then APEPNASR() : KPLOPNASR() : EPNASR()
		If optdt.Checked = True Then AsmLo = System.Math.Abs(Lo) : APEPNASR() : KPLOPNASR() : EPNASR()
		If optdtL.Checked = True Then EstimatedPosition()
		'EstimatedPositionNASR
		Display214()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmdWeems_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWeems.Click
		FlagWeems = True
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = True
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		Weems()
		APEPNASR()
		KPLOPNASR()
		EPNASR()
		'EstimatedPositionNASR
		DisplayWeems()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
		
	End Sub
	
	Private Sub cmd229_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd229.Click
		chkDSD.Visible = True
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		HO229()
		APEPNASR()
		KPLOPNASR()
		EPNASR()
		'EstimatedPositionNASR
		Display229()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmd249_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd249.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = True
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		HO249()
		APEPNASR()
		KPLOPNASR()
		EPNASR()
		'EstimatedPositionNASR
		Display249()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		txtGHADeg.Text = ""
		txtGHAMin.Text = ""
		txtDecDeg.Text = ""
		txtDecMin.Text = ""
		txtHoDeg.Text = ""
		txtHoMin.Text = ""
		txtLDeg.Text = ""
		txtLMin.Text = ""
		txtLoDeg.Text = ""
		txtLoMin.Text = ""
		txtTime.Text = ""
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked : chkDSD.Visible = False
		chkSadler.Visible = False
		chkInterpolateB.Visible = False
		frame211.Visible = False ': optCompact.Value = True
		frame214.Visible = False : Label9.Visible = False
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		txtGHADeg.Focus()
	End Sub
	Private Sub cmdClearSome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearSome.Click
		txtGHADeg.Text = ""
		txtGHAMin.Text = ""
		txtDecDeg.Text = ""
		txtDecMin.Text = ""
		txtHoDeg.Text = ""
		txtHoMin.Text = ""
		txtTime.Text = ""
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked : chkDSD.Visible = False
		chkSadler.Visible = False
		chkInterpolateB.Visible = False
		frame211.Visible = False ': optCompact.Value = True
		frame214.Visible = False : Label9.Visible = False
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		txtGHADeg.Focus()
	End Sub
	
	Public Sub cmdMerDiag_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMerDiag.Click
		FlagMD = True
		Form1.FlagMD = False
		Form22.Show()
		Form22.DisplayMerDiag()
		cmdMerDiag.Enabled = False
	End Sub
	
	Private Sub cmdNASR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNASR.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		NASR()
		APEPNASR()
		KPLOPNASR()
		EPNASR()
		'EstimatedPositionNASR
		DisplayNASR()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		FormHeight = VB6.PixelsToTwipsY(Me.Height)
		FormWidth = VB6.PixelsToTwipsX(Me.Width)
		PrintScreen()
	End Sub
	
	Private Sub cmdSTable_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSTable.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = True
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "NASR"
		DecimalDegrees()
		STable()
		If Flag = True Then Exit Sub 'WHAT IS THIS FOR?
		'If cboL.text = "S " Then L = -L
		EstimatedPosition()
		DisplaySTable()
		cmdSave.Visible = False : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
		
	End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		Pi = 4 * System.Math.Atan(1#)
	End Sub
	
	Private Sub cmdLawOfCosines_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLawOfCosines.Click
		chkDSD.Visible = False ':chkDSD.Value = 0
		chkSadler.Visible = False
		'    frameNASRUsing.Visible = False
		'    frame211.Visible = False ': optCompact.Value = True
		'    frame214.Visible = False: Label9.Visible = False
		'    frameS.Visible = False
		FlagSRFLoCNASR = True : Form1.FlagSRFLoCNASR = False
		'TypeRed = "LoC"
		DecimalDegrees()
		LawOfCosines()
		EstimatedPosition()
		DisplayLOC()
		cmdSave.Visible = True : cmdMerDiag.Visible = True : cmdMerDiag.Enabled = True
	End Sub
	
	Private Sub Form8_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cboDec.SelectedIndex = 0 '"N "
		cboL.SelectedIndex = 0 '"N "
		cboLo.SelectedIndex = 0 '"W "
	End Sub
	Public Sub DisplayLOC()
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame211.Visible = False
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(23), "INTERCEPT and AZIMUTH by the LAW of COSINES METHOD")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "LHA", TAB(53 - Len(Str(LHADeg))), VB6.Format(LHADeg, "0") & Chr(176) & VB6.Format(LHAMin, "00.0") & "'", TAB(60), "-------> LHA", TAB(81 - Len(Str(LHADeg))), VB6.Format(LHA, "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "Lat", TAB(53 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text, TAB(60), "-------> Lat (+)", TAB(81 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(System.Math.Abs(L), "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "Dec", TAB(53 - Len(Str(DecDegrees))), VB6.Format(System.Math.Abs(DecDegrees), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'")
		'If DE > 0 Then Print "N";
		'If DE = 0 Then Print " ";
		'If DE < 0 Then Print "S";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DE = 0 Then
			Print("")
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(cboDec.Text)
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(60), "-------> Dec (" & SignDE & ")")
		'If Sgn(L) = Sgn(DE) Then Print "+)";
		'If Sgn(L) <> Sgn(DE) Then Print "-)";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(81 - Len(Str(DecDegrees))), VB6.Format(System.Math.Abs(DE), "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("(cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc ---->" & "   Hc " & VB6.Format(Int(Hc * 100000 + 0.5) / 100000, "0.00000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("(sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z ----->" & "   Z  " & cboL.Text, SPC(1), VB6.Format(Int(Z * 10 + 0.5) / 10, "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		'i = 8: If Sgn(Hc) = -1 Then i = 7
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Hc) = -1 Then Print(TAB(7 - Len(Str(HcDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(8 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(7 - Len(Str(HoDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(8 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		'Print " a"; Tab(13 - Len(Str$(A))); Format((Int(Abs(A) * 10 + 0.5)) / 10, "0.0"); " nm ";
		i = Len(Str(Int(System.Math.Abs(A) * 10 + 0.5))) : If System.Math.Abs(A) < 1 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" a", TAB(12 - i), VB6.Format(System.Math.Abs(A), "0.0") & " nm ")
		'Print " a"; Tab(13 - Len(Str$((Int((Abs(A)) * 10 + 0.5)) / 10))); Format(Int((Abs(A) * 10 + 0.5)) / 10, "0.0"); " nm "; 'Tab(13 - Len(Str$(Round(Abs(A), 1)))); Format(Round(Abs(A), 1), "0.0"); " nm ";
		'If displayed value of a is 0 do not print T or A
		'If Int((Abs(A) * 10 + 0.5)) / 10 <> 0 And A < 0 Then Print "T  Ho > Hc....Toward";
		'If Int((Abs(A) * 10 + 0.5)) / 10 <> 0 And A > 0 Then Print "A  Hc > Ho....Away";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A <> 0 And A < 0 Then Print("T  Ho > Hc....Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A <> 0 And A > 0 Then Print("A  Hc > Ho....Away")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(70), "Zn " & VB6.Format(ZN, "000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("EP L  ", TAB(11 - Len(Str(EstLDeg))), VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("EP Lo ", TAB(11 - Len(Str(EstLoDeg))), VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
	End Sub
	Public Function LawOfCosines() As Object
		'Are the next few lines necessary?
		'HD$ = "N ": If DE < 0 Then HD$ = "S"
		'SL$ = "+": If Sgn(L) = -Sgn(DE) Then SL$ = "-"
		'DE = Abs(DE): If SL$ = "-" Then DE = -DE
		'If DE = 0 Then SL$ = " "
		'DecLOC = Abs(DE): If Sgn(L) = -Sgn(DE) Then DecLOC = -DecLOC
		DE = Int(DE * 100000 + 0.5) / 100000 'Moved from DecimalDegrees in V4.7.1
		SignDE = "+"
		If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then DE = -DE : SignDE = "-"
		L1 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(L) * Pi / 180) * System.Math.Cos(DE * Pi / 180)
		L2 = System.Math.Sin(System.Math.Abs(L) * Pi / 180) * System.Math.Sin(DE * Pi / 180)
		L3 = L1 + L2
		'If L3 = 1 Then L3 = 0
		If System.Math.Abs(L3) >= 1 Then Hc = System.Math.Sign(L3) * Pi / 2 Else Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
		Hc = Hc * 180 / Pi
		Hc = Int(Hc * 10000 + 0.5) / 10000 'added in V5.1.5
		Htot = Hc
		
		'A = 60 * Hc - HoinMinutes
		HcDeg = Fix(Hc) : HcMin = (Hc - HcDeg) * 60 ':HcMin = Abs((Hc - HcDeg) * 60)
		HcMin = Int(HcMin * 10 + 0.5) / 10
		'If Int(HcMin * 10 + 0.5) / 10 = 60 Then
		If HcMin = 60 Then
			HcMin = 0
			If HcDeg >= 0 Then HcDeg = HcDeg + 1
			If HcDeg < 0 Then HcDeg = HcDeg - 1
		End If
		A = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		'If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
		A = System.Math.Sign(A) * Int(System.Math.Abs(A) * 10 + 0.5) / 10
		
		'MI = Abs(A * 60) ': MI = FNRD(MI) ?Need to round?
		'D$ = "T  Ho > Hc....toward": If Hc > Ho Then D$ = "A  Hc > Ho....away"
		'If Hc = Ho Then D$ = " "
		L4 = System.Math.Sin(DE * Pi / 180)
		L5 = System.Math.Sin(System.Math.Abs(L) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
		L6 = L4 - L5
		L7 = System.Math.Cos(System.Math.Abs(L) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
		L8 = L6 / L7
		'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
		If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2
		Z = Z * 180 / Pi
		'Z = FNRD(Z)    ?Need to round?
		Z = Int(Z * 10 + 0.5) / 10 'round to one decimal place
		'TLHA$ = "W": If LHA > 180 Then TLHA$ = "E"
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		'If L > 0 And LHA > 180 Then ZN = Z
		'If L > 0 And LHA <= 180 Then ZN = 360 - Z
		'If L <= 0 And LHA > 180 Then ZN = 180 - Z
		'If L <= 0 And LHA <= 180 Then ZN = 180 + Z
		
		ZN = Int(ZN + 0.5)
		If ZN = 360 Then ZN = 0
		'ZN = Int(ZN + 0.5): ZN$ = Str$(1000 + ZN): ZN$ = Right$(ZN$, 3)
		'HR = FNTD(HC)
		'HD = Int(HC): HM = (HC - HD) * 60: HM = FNRD(HM)
		HcDeg = Fix(Hc) : HcMin = System.Math.Abs((Hc - HcDeg) * 60)
		If Int(HcMin * 10 + 0.5) / 10 = 60 Then
			HcMin = 0
			If HcDeg >= 0 Then HcDeg = HcDeg + 1
			If HcDeg < 0 Then HcDeg = HcDeg - 1
		End If
	End Function
	
	Private Sub Form8_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event optCompact.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optCompact_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCompact.CheckedChanged
		If eventSender.Checked Then
			'chkSadler.Value = 0
			cmd211_Click(cmd211, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optd.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optd_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optd.CheckedChanged
		If eventSender.Checked Then
			cmd214_Click(cmd214, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optdt.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optdt_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optdt.CheckedChanged
		If eventSender.Checked Then
			cmd214_Click(cmd214, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optdtL.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optdtL_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optdtL.CheckedChanged
		If eventSender.Checked Then
			cmd214_Click(cmd214, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optFarley.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optFarley_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFarley.CheckedChanged
		If eventSender.Checked Then
			cmdSTable_Click(cmdSTable, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optNATable.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optNATable_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optNATable.CheckedChanged
		If eventSender.Checked Then
			cmdNASR_Click(cmdNASR, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optOriginal.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOriginal_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOriginal.CheckedChanged
		If eventSender.Checked Then
			'chkSadler.Value = 0
			cmd211_Click(cmd211, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optPepperday.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optPepperday_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optPepperday.CheckedChanged
		If eventSender.Checked Then
			cmdSTable_Click(cmdSTable, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optUSPSTable.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optUSPSTable_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optUSPSTable.CheckedChanged
		If eventSender.Checked Then
			cmdNASR_Click(cmdNASR, New System.EventArgs())
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDecDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDecDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecDeg.TextChanged
		If Val(txtDecDeg.Text) <> 90 Then txtDecMin.Enabled = True
		If Val(txtDecDeg.Text) = 90 Then txtDecMin.Enabled = False : txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtDecDeg.ForeColor = &H80000008
		txtDecDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtDecDeg.Text) > 90 Or (Val(txtDecDeg.Text) = 90 And Val(txtDecMin.Text) <> 0) Then
			txtDecDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtDecDeg.Text) < 90 Then
			'txtDecMin.ForeColor = &H80000008
			txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtDecMin.Text = "    "
		End If
	End Sub
	
	Private Sub txtDecDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDecDeg.KeyPress
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
	
	Private Sub txtDecDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDecDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtDecDeg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDecDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecDeg.Enter
		SelectAllText(txtDecDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtDecMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDecMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecMin.TextChanged
		'txtDecMin.ForeColor = &H80000008
		txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtDecMin.Text) > 59.9 Then
			txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtDecMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDecMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtDecMin.Text, ".") Then
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
	Private Sub txtDecMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDecMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtDecMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDecMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecMin.Enter
		SelectAllText(txtDecMin)
	End Sub
	
	'UPGRADE_WARNING: Event txtGHADeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtGHADeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHADeg.TextChanged
		'If Val(txtLoDeg.Text) <> 180 Then txtLoMin.Enabled = True
		'If Val(txtLoDeg.Text) = 180 Then txtLoMin.Enabled = False: txtLoMin.Text = "00.0"
		'txtGHADeg.ForeColor = &H80000008
		txtGHADeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtGHADeg.Text) > 719 Then
			txtGHADeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	Private Sub txtGHADeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGHADeg.KeyPress
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
	Private Sub txtGHADeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtGHADeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtGHADeg.Text) > 719 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtGHADeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHADeg.Enter
		SelectAllText(txtGHADeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtGHAMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtGHAMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHAMin.TextChanged
		'txtGHAMin.ForeColor = &H80000008
		txtGHAMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtGHAMin.Text) > 59.9 Then
			txtGHAMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtGHAMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGHAMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtGHAMin.Text, ".") Then
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
	Private Sub txtGHAMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtGHAMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtGHAMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtGHAMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHAMin.Enter
		SelectAllText(txtGHAMin)
	End Sub
	
	'UPGRADE_WARNING: Event txtHoDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoDeg.TextChanged
		cmdNASR.Enabled = True
		cmdLawOfCosines.Enabled = True
		cmd229.Enabled = True
		txtHoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtHoDeg.Text) = 90 Then txtHoMin.Enabled = False : txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		If Val(txtHoDeg.Text) > 90 Then txtHoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) : MsgBox("Out of Range")
		If Val(txtHoDeg.Text) > 88 Or (Val(txtHoDeg.Text) = 88 And Val(txtHoMin.Text) <> 0) Then cmdLawOfCosines.Enabled = False
		If Val(txtHoDeg.Text) > 85 Or (Val(txtHoDeg.Text) = 85 And Val(txtHoMin.Text) <> 0) Then cmd229.Enabled = False
		If Val(txtHoDeg.Text) > 75 Or (Val(txtHoDeg.Text) = 75 And Val(txtHoMin.Text) <> 0) Then cmdNASR.Enabled = False
	End Sub
	
	Private Sub txtHoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHoDeg.KeyPress
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
	
	Private Sub txtHoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHoDeg.Text) > 90 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoDeg.Enter
		SelectAllText(txtHoDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtHoMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoMin.TextChanged
		cmdNASR.Enabled = True
		cmdLawOfCosines.Enabled = True
		cmd229.Enabled = True
		txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtHoMin.Text) > 59.9 Then txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) : MsgBox("Out of Range")
		If Val(txtHoDeg.Text) > 88 Or (Val(txtHoDeg.Text) = 88 And Val(txtHoMin.Text) <> 0) Then cmdLawOfCosines.Enabled = False
		If Val(txtHoDeg.Text) > 85 Or (Val(txtHoDeg.Text) = 85 And Val(txtHoMin.Text) <> 0) Then cmd229.Enabled = False
		If Val(txtHoDeg.Text) > 75 Or (Val(txtHoDeg.Text) = 75 And Val(txtHoMin.Text) <> 0) Then cmdNASR.Enabled = False
	End Sub
	
	Private Sub txtHoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHoMin.KeyPress
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
				'If Len(txtHoMin.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				If txtHoMin.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
			Case Asc("+")
				'If Len(txtHoMin.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				If txtHoMin.SelectionStart <> 0 Or bPlusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bPlusSignAlready = True
				End If
				
			Case Asc(".") 'only allows one decimal point
				If InStr(txtHoMin.Text, ".") Then
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
	
	Private Sub txtHoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHoMin.Text) > 59.9 Or Val(txtHoMin.Text) < -59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoMin.Enter
		SelectAllText(txtHoMin)
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
	
	Public Function DecimalDegrees() As Object
		GHA = Val(txtGHADeg.Text) + Val(txtGHAMin.Text) / 60
		'GHA = Int(GHA * 100000 + 0.5) / 100000             NOT ADDED V4.3.0
		DE = Val(txtDecDeg.Text) + Val(txtDecMin.Text) / 60
		'DE = Int(DE * 100000 + 0.5) / 100000                'ADDED V4.3.0,  removed in V4.7.1 and moved to LoC only
		Dec = DE : If cboDec.Text = "S " Then Dec = -DE
		DecDegrees = Int(DE) : DecMinutes = (DE - DecDegrees) * 60
		If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0 : DecDegrees = DecDegrees + 1
		Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
		'Ho = Int(Ho * 100000 + 0.5) / 100000
		HoinMinutes = Ho * 60
		HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
		'HoMin = Abs(HoinMinutes - 60 * HoDeg)
		HoMin = HoinMinutes - 60 * HoDeg
		'HoMin = Int(HoMin + 0.5)                           NOT ADDED V4.3.0
		If Int(HoMin * 10 + 0.5) / 10 = 60 Then HoMin = 0 : HoDeg = HoDeg + 1
		L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
		L = Int(L * 100000 + 0.5) / 100000 'ADDED V4.3.0
		If cboL.Text = "S " Then L = -L
		Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
		If cboLo.Text = "E " Then Lo = -Lo
		LHA = GHA - Lo
		LHA = Int(LHA * 100000 + 0.5) / 100000 'ADDED V4.3.0
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		LHADeg = Int(LHA) : LHAMin = (LHA - LHADeg) * 60
		LHAMin = Int(LHAMin * 10 + 0.5) / 10
		If Int(LHAMin * 10 + 0.5) / 10 = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
	End Function
	
	Public Function EstimatedPosition() As Object
		'If PL = 2 Then EstL = L: EstLo = Lo: Exit Function
		'A = Sgn(A) * Int(Abs(A) * 10 + 0.5) / 10    'added in V4.0.0
		'ZN = Int(ZN + 0.5)                         'added in V4.0.0
		
		EstL = L - (A / 60) * System.Math.Cos(ZN * Pi / 180)
		EstLo = Lo + (A / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(L * Pi / 180)
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
	
	Public Function NASR() As Object
		'If HoinMinutes > (75 * 60) Then txtHoDeg.BackColor = &HFF&: txtHoMin.BackColor = &HFF&: cmdNASR.Enabled = False: MsgBox "Ho exceeds maximum of 75º for NASR"
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 360 Then AsmLHA = 0
		GHAAsmDeg = Val(txtGHADeg.Text)
		GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
		GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
		'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If cboLo.text = "W " Then AsmLo = GHAAsm - AsmLHA Else AsmLo = AsmLHA - GHAAsm 'AsmLoDeg = Val(txtLoDeg.Text)
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Int(Val(txtGHAMin.Text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.Text) + 0.5)
		'    If Lo > 0 Or txtLoDeg.text = "180" Then AsmLoMin = Int(Val(txtGHAMin.text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.text) + 0.5)
		'If cboLo.text = "E " Then AsmLoMin = Int(Val(txtGHAMin.text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.text) + 0.5)
		If AsmLoMin = 60 Then AsmLoMin = 0
		'LoDiff = Abs(Val(txtLoDeg.Text) + Int(Val(txtLoMin.Text) + 0.5) / 60) - Abs(AsmLo) 'LoDiff = Abs(Lo) - Abs(AsmLo)   'LoDiff = Abs(Lo) - Abs(AsmLoDeg + AsmLoMin / 60)
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = 1 Then AsmLoDeg = AsmLoDeg + 1
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = -1 Then AsmLoDeg = AsmLoDeg - 1
		AsmL = Int(L + 0.5)
		A1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(AsmLHA * Pi / 180)
		If System.Math.Abs(A1) >= 1 Then Aval = System.Math.Sign(A1) * Pi / 2 Else Aval = System.Math.Atan(A1 / System.Math.Sqrt(-A1 * A1 + 1)) 'in radians
		AvalDeg = Int(System.Math.Abs(Aval * 180 / Pi))
		AvalMin = Int((System.Math.Abs(Aval * 180 / Pi) - AvalDeg) * 60 + 0.5)
		If AvalMin = 60 Then AvalMin = 0 : AvalDeg = AvalDeg + 1
		Z3 = System.Math.Cos(AsmLHA * Pi / 180) / System.Math.Cos(Aval) 'Example b p 2-24 bottom of first column makes Z3=1 NG
		'If Abs(Z3) = 1 Then Z3 = 0  'prevents program from crashing with no inputs
		If System.Math.Abs(Z3) >= 1 Then Z1 = System.Math.Sign(Z3) * Pi / 2 Else Z1 = System.Math.Atan(Z3 / System.Math.Sqrt(-Z3 * Z3 + 1)) 'in radians
		Z1display = Int(Z1 * 180 / Pi * 10 + 0.5) / 10
		B1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(Z1)
		If System.Math.Abs(B1) >= 1 Then B = System.Math.Sign(B1) * Pi / 2 Else B = System.Math.Atan(B1 / System.Math.Sqrt(-B1 * B1 + 1)) 'in radians
		BDeg = Int(System.Math.Abs(B * 180 / Pi))
		BMin = Int((System.Math.Abs(B) * 180 / Pi - BDeg) * 60 + 0.5)
		If BMin = 60 Then BMin = 0 : BDeg = BDeg + 1
		If LHA > 90 And LHA < 270 Then SignB = "-" Else SignB = "+"
		If LHA > 90 And LHA < 270 Then SignZ1 = "-" Else SignZ1 = "+"
		'If Sgn(L) <> Sgn(DE) Then SignDE$ = "-" Else SignDE$ = "+"
		SignDE = "+"
		'If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then DE = -DE: SignDE$ = "-"
		'If Abs(L * 60) < 29 Then SignDE$ = "+": DE = Abs(DE)   'For latitudes less than half degree from equator Dec is positive (from N93 no longer used)
		'If SignDE$ = "-" Then DE = -Abs(DE)
		DecMinDisplay = Int(Val(txtDecMin.Text) + 0.5)
		If DecMinDisplay = 60 Then DecMinDisplay = 0 : DecDegrees = DecDegrees + 1
		'F = B + DE * Pi / 180   'in radians
		B = Int(B * 180 / Pi * 60 + 0.5) 'rounded to whole minutes
		DE = Int(DE * 60 + 0.50000000001) 'rounded to whole minutes
		If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then DE = -DE : SignDE = "-"
		F = B + DE 'in minutes
		'F = Int(F + 0.5) 'rounded to whole minutes
		F = F / 60 'in degrees
		FWhole = Int(F + 0.5)
		FDeg = Fix(F) 'Int(F)
		FMin = Int((System.Math.Abs(F - FDeg)) * 60 + 0.5) 'Int((F - FDeg) * 60 + 0.5)               'Round((F * 180 / Pi - FDeg) * 60)
		If FMin = 60 Then FMin = 0 : FDeg = FDeg + 1
		If System.Math.Sign(F) = 1 Then SignF = "+"
		If System.Math.Sign(F) = -1 Then SignF = "-"
		If System.Math.Sign(F) = 0 Then SignF = " "
		AWhole = Int(AvalDeg + AvalMin / 60 + 0.5)
		H1 = System.Math.Cos(AWhole * Pi / 180) * System.Math.Sin(System.Math.Abs(FWhole) * Pi / 180) 'Abs(FWhole) was FWhole
		If System.Math.Abs(H1) >= 1 Then H = System.Math.Sign(H1) * Pi / 2 Else H = System.Math.Atan(H1 / System.Math.Sqrt(-H1 * H1 + 1)) 'in radians
		If System.Math.Sign(F) = -1 Then H = -H
		HDeg = Fix(H * 180 / Pi)
		HMin = Int((H * 180 / Pi - HDeg) * 60 + 0.5)
		If HMin = 60 Then HMin = 0 : HDeg = HDeg + 1
		'If Sgn(F) = -1 Then H = -H
		'Z4 = Cos(FWhole * Pi / 180) / Cos((HDeg + HMin / 60) * Pi / 180)'Example in book gives 76.0, program gives 76.1 (76.06... before rounding)with this line
		Z4 = System.Math.Cos(FWhole * Pi / 180) / System.Math.Cos(H) '76 with this line
		'If Abs(Z4) = 1 Then Z4 = 0  'prevents program from crashing with no inputs
		'If Abs(Z4) >= 1 Then Z2 = Sgn(Z4) * Pi / 2 Else Z2 = Atn(Z4 / Sqr(-Z4 * Z4 + 1)) 'in radians
		If System.Math.Abs(Z4) >= 1 Then Z2 = 0 Else Z2 = System.Math.Atan(Z4 / System.Math.Sqrt(-Z4 * Z4 + 1)) 'in radians   arcsine
		'    Z2Display2 = Int(Z2 * 180 / Pi + 0.5)      removed in V5.1.5 to fix rounding
		If System.Math.Sign(F) = -1 Then Z2 = Pi - Z2 'THIS IS FOR WHEN Z2>90 DEGREES - TABLE DOES NOT SHOW Z2>90 - use supplement, but use original to get corr2
		Z2Display1 = Int(Z2 * 180 / Pi * 10 + 0.5) / 10
		Z2Display2 = Int(Z2Display1 + 0.5) 'added in V5.1.5 to fix rounding
		'If H < 0 Then Z2 = Pi - Z2        'was HoinMinutes < 0
		'Z2Display2 = Int(Z2 * 180 / Pi * 10 + 0.5) / 10
		
		'If Abs(Z2Display2) < 10 Then Z2 = 10 * Pi / 180 'If Z2Display < 10 Then Z2Display = 10
		'P1 = Cos(Aval) * Sin(Z2)
		'P1 = Abs(Cos(Aval) * Sin(Z2))    'Added Abs after Healy tests             was Abs(Cos(AWhole * Pi / 180)* Sin(Z2Display * Pi / 180))
		P1 = System.Math.Abs(System.Math.Cos(AWhole * Pi / 180) * System.Math.Sin(Z2))
		If System.Math.Abs(P1) >= 1 Then P = System.Math.Sign(P1) * Pi / 2 Else P = System.Math.Atan(P1 / System.Math.Sqrt(-P1 * P1 + 1)) 'in radians
		PDeg = Int(P * 180 / Pi + 0.5)
		If PDeg > 80 Then P = 80 * Pi / 180 'If PDeg > 80 Then PDeg = 80
		If System.Math.Abs(Z2Display2) < 10 Then Z2 = 10 * Pi / 180 'If Z2Display < 10 Then Z2Display = 10
		If F > 90 Then SignZ2 = "-" Else SignZ2 = "+"
		If (F - FWhole) >= 0 Then Corr1 = FMin * System.Math.Sin(PDeg * Pi / 180) Else Corr1 = (60 - FMin) * System.Math.Sin(PDeg * Pi / 180)
		'Corr1 = Sgn(F) * FMin * Sin(PDeg * Pi / 180)
		If H < 0 Then 'was HoinMinutes < 0
			If System.Math.Abs(F - FWhole) >= 0 Then Corr1 = System.Math.Sign(F) * FMin * System.Math.Sin(PDeg * Pi / 180) Else Corr1 = System.Math.Sign(F) * (60 - FMin) * System.Math.Sin(PDeg * Pi / 180)
		End If
		Corr1 = Int(Corr1 + 0.50000000000001) 'Why isn't 0.5 enough?
		If optNATable.Checked And PDeg = 30 And FMin Mod 2 <> 0 Then Corr1 = Corr1 - 1 'F is odd
		If (F < 90 And FMin > 29) Or (F > 90 And FMin < 30) Then Corr1 = -Corr1
		If System.Math.Sign(Corr1) = 1 Then SignCorr1 = "+"
		If System.Math.Sign(Corr1) = -1 Then SignCorr1 = "-"
		If System.Math.Sign(Corr1) = 0 Then SignCorr1 = " "
		'    Z2Deg = Int(Z2 * 180 / Pi + 0.5)                   'Removed in V5.4.0
		'    If (Abs(Aval * 180 / Pi) - Abs(AWhole)) >= 0 Then Corr2 = AvalMin * Cos(Z2Deg * Pi / 180) Else Corr2 = (60 - AvalMin) * Cos(Z2Deg * Pi / 180)      'Removed in V5.4.0
		If (System.Math.Abs(Aval * 180 / Pi) - System.Math.Abs(AWhole)) >= 0 Then Corr2 = AvalMin * System.Math.Cos(Z2Display2 * Pi / 180) Else Corr2 = (60 - AvalMin) * System.Math.Cos(Z2Display2 * Pi / 180) 'Added in V5.4.0
		If AvalMin = 0 Then Corr2 = 0
		Corr2 = Int(Corr2 + 0.50000000000001) 'Why isn't 0.5 enough?
		If optNATable.Checked And Int(System.Math.Abs(Z2Display2) + 0.5) = 60 And AvalMin Mod 2 <> 0 Then Corr2 = Corr2 - 1 'AvalMin is odd
		If AvalMin < 30 Then Corr2 = -Corr2
		If System.Math.Sign(Corr2) = 1 Then SignCorr2 = "+"
		If System.Math.Sign(Corr2) = -1 Then SignCorr2 = "-"
		If System.Math.Sign(Corr2) = 0 Then SignCorr2 = " "
		Ztot = (Z1display + Z2Display1)
		ZtotDisplay = Int(Ztot * 10 + 0.5) / 10
		If cboL.Text = "N " And LHA >= 180 Then ZN = ZtotDisplay
		If cboL.Text = "N " And LHA < 180 Then ZN = 360 - ZtotDisplay
		If cboL.Text = "S " And LHA >= 180 Then ZN = 180 - ZtotDisplay
		If cboL.Text = "S " And LHA < 180 Then ZN = 180 + ZtotDisplay
		If ZN < 0 Then ZN = ZN + 360
		If ZN >= 360 Then ZN = ZN - 360
		'If L >= 0 And LHA > 180 Then ZN = ZtotDisplay
		'If L >= 0 And LHA <= 180 Then ZN = 360 - ZtotDisplay
		'If L < 0 And LHA > 180 Then ZN = 180 - ZtotDisplay
		'If L < 0 And LHA <= 180 Then ZN = 180 + ZtotDisplay
		
		ZN = Int(ZN + 0.5) 'added in V4.0.0
		
		Htot = (HDeg * 60 + HMin + Corr1 + Corr2) / 60 'degrees
		'If F < 0 Then Htot = -Htot
		sgnTotHc = System.Math.Sign(Htot)
		HtotDeg = Fix(Htot)
		HtotMin = (Htot - HtotDeg) * 60
		If HtotMin = 60 Then HtotMin = 0 : HtotDeg = HtotDeg + 1
		'A = (Htot - Ho) * 60
		HoMin = Int(HoMin + 0.5)
		A = (HtotDeg * 60 + HtotMin) - (HoDeg * 60 + HoMin)
		'If HoinMinutes < 0 Then A = -(60 * Abs(HtotDeg) + HtotMin) - HoMin
		'If HoinMinutes < 0 Then A = -A
	End Function
	
	Public Sub DisplayNASR()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = True
		Shape2.Visible = True
		Shape3.Visible = False
		Line4.Visible = True
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = True
		frame211.Visible = False
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(15), "INTERCEPT and AZIMUTH by the NAUTICAL ALMANAC SIGHT REDUCTION TABLES")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Calc. of Asm Lo and Asm LHA", SPC(20), "Asm L " & VB6.Format(System.Math.Abs(AsmL), "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL = 0 Then
			Print(" " & "    Asm LHA " & VB6.Format(AsmLHA, "0") & Chr(176))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(cboL.Text & "    Asm LHA " & VB6.Format(AsmLHA, "0") & Chr(176))
		End If
		LengthZ1Display = Len(Str(System.Math.Abs(Z1display)))
		If System.Math.Abs(Z1display) - Int(System.Math.Abs(Z1display)) = 0 Then LengthZ1Display = LengthZ1Display + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   Tot GHA", TAB(18 - Len(Str(GHAAsmDeg))), VB6.Format(GHAAsmDeg, "0") & Chr(176) & VB6.Format(GHAAsmMin, "00") & "'", SPC(14), "A ", TAB(40 - Len(Str(AvalDeg))), VB6.Format(AvalDeg, "0") & Chr(176) & VB6.Format(AvalMin, "00") & "'", SPC(12), "B (" & SignB & ")", TAB(64 - Len(Str(BDeg))), VB6.Format(System.Math.Abs(BDeg), "0") & Chr(176) & VB6.Format(BMin, "00") & "'", SPC(10), "Z1 (" & SignZ1 & ")", TAB(89 - LengthZ1Display), VB6.Format(System.Math.Abs(Z1display), "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   Asm Lo (")
		'If cboLo.text = "W " Then SignA3$ = "W": Print "-";
		'If cboLo.text = "E " Then SignA3$ = "E": Print "+";
		If AsmLo = 0 Then
			SignA3 = " "
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
		End If
		If System.Math.Sign(AsmLo) = 1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-")
			SignA3 = "W"
		End If
		If System.Math.Sign(AsmLo) = -1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+")
			SignA3 = "E"
		End If
		If System.Math.Sign(AsmLo) = 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
			SignA3 = " "
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(18 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00") & "'" & SignA3, SPC(31), "Dec (" & SignDE & ")", TAB(64 - Len(Str(DecDegrees))), VB6.Format(DecDegrees, "0") & Chr(176) & VB6.Format(DecMinDisplay, "00") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   Asm LHA", TAB(18 - Len(Str(AsmLHA))), VB6.Format(AsmLHA, "0") & Chr(176), SPC(37), "F (" & SignF & ")", TAB(64 - Len(Str(FDeg))), VB6.Format(System.Math.Abs(FDeg), "0") & Chr(176) & VB6.Format(FMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(50), "A " & VB6.Format(System.Math.Abs(AWhole), "0") & Chr(176), SPC(10), "F " & VB6.Format(System.Math.Abs(FWhole), "0") & Chr(176)) 'Abs(FWhole) was FWhole
		LengthZ2Display = Len(Str(System.Math.Abs(Z2Display1)))
		If System.Math.Abs(Z2Display1) - Int(System.Math.Abs(Z2Display1)) = 0 Then LengthZ2Display = LengthZ2Display + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "H  ") ': If Sgn(F) = -1 Then Print Tab(45 - Len(Str$(HDeg))); "-";
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If H < 0 Then Print("    -")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(46 - Len(Str(System.Math.Abs(HDeg)))), VB6.Format(System.Math.Abs(HDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HMin), "00") & "'", TAB(59), "P " & VB6.Format(PDeg, "0") & Chr(176), TAB(77), "Z2 (" & SignZ2 & ")", TAB(89 - LengthZ2Display), VB6.Format(System.Math.Abs(Z2Display1), "0.0") & Chr(176))
		i = Len(Str(PDeg)) : If PDeg < 10 Then i = 3
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "corr 1 (" & SignCorr1 & ")", TAB(46), VB6.Format(System.Math.Abs(Corr1), "00") & "'", TAB(54), "(F' " & VB6.Format(FMin, "00") & ", Pº", TAB(69 - i), VB6.Format(PDeg, "00") & ")")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If H < 0 Then
			Print(TAB(75), "(supplement of " & VB6.Format(180 - Z2Display1, "0.0") & Chr(176) & ")")
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print()
		End If 'was HoinMinutes < 0
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "corr 2 (" & SignCorr2 & ")", TAB(46), VB6.Format(System.Math.Abs(Corr2), "00") & "'", TAB(54), "(A' " & VB6.Format(AvalMin, "00") & ", Z2º", TAB(69 - Len(Str(Int(Z2Display2)))), VB6.Format(Int(System.Math.Abs(Z2Display2)), "0") & ")") 'added ABS to Z2Display after Healy tests
		LengthZtotDisplay = Len(Str(System.Math.Abs(ZtotDisplay)))
		If System.Math.Abs(ZtotDisplay) - Int(System.Math.Abs(ZtotDisplay)) = 0 Then LengthZtotDisplay = LengthZtotDisplay + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "Hc") ': If sgnTotHc = -1 Then Print Tab(45 - Len(Str$(HtotDeg))); "-";
		'    If HoinMinutes < 0 Then Print Tab(43 - Len(Str$(HtotDeg))); "(-)";                            '????????
		'If sgnTotHc = -1 Then Print Tab(43 - Len(Str$(HtotDeg))); "(-)";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If sgnTotHc = -1 Then Print("     -")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(46 - Len(Str(System.Math.Abs(HtotDeg)))), VB6.Format(System.Math.Abs(HtotDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HtotMin), "00") & "'")
		
		'If H < 0 Then Print "(Change sign to minus)";     'was HoinMinutes < 0
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(77), "Z   " & cboL.Text, TAB(89 - LengthZtotDisplay), VB6.Format(System.Math.Abs(ZtotDisplay), "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "Ho ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoinMinutes < 0 Then Print("    -")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(46 - Len(Str(HoDeg))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "a", TAB(48 - Len(Str(Int(System.Math.Abs(A))))), CStr(Int(System.Math.Abs(A) + 0.5)) & "nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A < 0 Then Print("T  Ho > Hc....Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A > 0 Then Print("A  Hc > Ho....Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(81), "Zn " & VB6.Format(ZN, "000") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "AP/EP L " & VB6.Format(APEstLDeg, "0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist < 0 Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist > 0 Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
	End Sub
	Public Function APEPNASR() As Object
		'A = Sgn(A) * Int(Abs(A) * 10 + 0.5) / 10    'added in V4.0.0
		'ZN = Int(ZN + 0.5)              'added in V4.0.0
		
		APEstL = AsmL - (A / 60) * System.Math.Cos(ZN * Pi / 180) 'Changed in V4.0.0
		APEstLo = AsmLo + (A / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(AsmL * Pi / 180) 'Changed in V4.0.0
		'APEstL = AsmL - (Int(A + 0.5) / 60) * Cos(ZN * Pi / 180)
		'APEstLo = AsmLo + (Int(A + 0.5) / 60) * Sin(ZN * Pi / 180) / Cos(AsmL * Pi / 180)
		
		If System.Math.Abs(APEstLo) > 180 Then APEstLo = -System.Math.Sign(APEstLo) * (360 - System.Math.Abs(APEstLo))
		APEstLDeg = Int(System.Math.Abs(APEstL))
		APEstLMin = (System.Math.Abs(APEstL) - APEstLDeg) * 60
		If Int(APEstLMin * 10 + 0.5) / 10 = 60 Then APEstLMin = 0 : APEstLDeg = APEstLDeg + 1
		'APEstLDeg = Abs(APEstLDeg)
		APEstLoDeg = Int(System.Math.Abs(APEstLo))
		APEstLoMin = (System.Math.Abs(APEstLo) - APEstLoDeg) * 60
		If Int(APEstLoMin * 10 + 0.5) / 10 = 60 Then APEstLoMin = 0 : APEstLoDeg = APEstLoDeg + 1
		APEstLoDeg = System.Math.Abs(APEstLoDeg)
	End Function
	Public Sub KPLOPNASR()
		If cboLo.Text = "E " Then AsmLo = -AsmLo
		DL = System.Math.Abs(L - AsmL) * 60
		'If AsmLo < 0 Then AsmLo = AsmLo + 360
		DLo = System.Math.Abs(Lo - AsmLo) * System.Math.Cos(L * Pi / 180) * 60
		VL = System.Math.Abs(DL * System.Math.Cos(ZN * Pi / 180))
		VLo = System.Math.Abs(DLo * System.Math.Sin(ZN * Pi / 180))
		If ((ZN > 270 And ZN <= 360) Or (ZN >= 0 And ZN < 90)) And L < AsmL Then VL = -VL 'Zn north and KP south of AP
		If (ZN >= 90 And ZN < 270) And L >= AsmL Then VL = -VL 'Zn south and KP north of AP
		If (ZN >= 0 And ZN < 180) And Lo >= AsmLo Then VLo = -VLo 'Zn east and KP west of AP
		If (ZN >= 180 And ZN < 360) And Lo < AsmLo Then VLo = -VLo 'Zn west and KP east of AP
		Hk = Htot * 60 + VL + VLo
		KPLOPDist = Hk - (HoDeg * 60 + HoMin)
		KPLOPDist = Int(KPLOPDist * 10 + 0.5) / 10
	End Sub
	Public Sub EPNASR()
		If cboLo.Text = "E " Then AsmLo = -AsmLo
		
		'If HoinMinutes < 0 Then KPLOPDist = -KPLOPDist
		
		'KPLOPDist = Sgn(KPLOPDist) * Int(Abs(KPLOPDist) * 10 + 0.5) / 10    'added in V4.0.0
		'ZN = Int(ZN + 0.5)                              'added in V4.0.0
		
		EstL = L - (KPLOPDist / 60) * System.Math.Cos(ZN * Pi / 180)
		EstLo = Lo + (KPLOPDist / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(L * Pi / 180)
		If System.Math.Abs(EstLo) > 180 Then EstLo = -System.Math.Sign(EstLo) * (360 - System.Math.Abs(EstLo))
		EstLDeg = Int(System.Math.Abs(EstL))
		EstLMin = (System.Math.Abs(EstL) - EstLDeg) * 60
		If Int(EstLMin * 10 + 0.5) / 10 = 60 Then EstLMin = 0 : EstLDeg = EstLDeg + 1
		EstLoDeg = Int(System.Math.Abs(EstLo))
		EstLoMin = (System.Math.Abs(EstLo) - EstLoDeg) * 60
		If Int(EstLoMin * 10 + 0.5) / 10 = 60 Then EstLoMin = 0 : EstLoDeg = EstLoDeg + 1
		EstLoDeg = System.Math.Abs(EstLoDeg)
	End Sub
	
	'Public Function EstimatedPositionNASR()
	'    EstL = AsmL - (Int(A + 0.5) / 60) * Cos(ZN * Pi / 180)
	'    EstLo = AsmLo + (Int(A + 0.5) / 60) * Sin(ZN * Pi / 180) / Cos(AsmL * Pi / 180)
	'    If Abs(EstLo) > 180 Then EstLo = -Sgn(EstLo) * (360 - Abs(EstLo))
	'    EstLDeg = Int(Abs(EstL))
	'    EstLMin = (Abs(EstL) - EstLDeg) * 60
	'    If Int(EstLMin * 10 + 0.5) / 10 = 60 Then EstLMin = 0: EstLDeg = EstLDeg + 1
	'    'EstLDeg = Abs(EstLDeg)
	'    EstLoDeg = Int(Abs(EstLo))
	'    EstLoMin = (Abs(EstLo) - EstLoDeg) * 60
	'    If Int(EstLoMin * 10 + 0.5) / 10 = 60 Then EstLoMin = 0: EstLoDeg = EstLoDeg + 1
	'    EstLoDeg = Abs(EstLoDeg)
	'End Function
	
	Public Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		II = II + 1 : IU = IU + 1 ': If II = 11 Then II = 1
		If IU > 1 Then cmdFix.Visible = True ': cmdFix.Enabled = True
		'TypeReduction(II) = TypeRed$
		'FType(II) = "LoC"
		'FZT(II) = ZTTemp: FZH(II) = ZTHours: FZM(II) = ZTMinutes: FZS(II) = ZTSeconds: FUT(II) = UTinSeconds
		'UPGRADE_WARNING: Couldn't resolve default property of object FZH(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZH(II) = VB.Left(txtTime.Text, 2)
		'UPGRADE_WARNING: Couldn't resolve default property of object FZM(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZM(II) = Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
		'FMI(II) = A: 'FA(II) = -(60 * MI)
		'UPGRADE_WARNING: Couldn't resolve default property of object FMI(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FMI(II) = System.Math.Sign(A) * Int(System.Math.Abs(A) * 10 + 0.5) / 10 'changed in V4.0.0
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FD(II) = "T"
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If A > 0 Then FD(II) = "A"
		'UPGRADE_WARNING: Couldn't resolve default property of object FD(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If A = 0 Then FD(II) = " "
		'FZN(II) = ZN: 'FIU(II) = IU
		'UPGRADE_WARNING: Couldn't resolve default property of object FZN(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FZN(II) = Int(ZN + 0.5) 'changed in V4.0.0
		'BF(II) = cboBody.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object FL(II). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FL(II) = L
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
		'If TypeRed = "NASR" Then
		'    FType(II) = "NASR"
		'    FAPL(II) = AsmL
		'    FAPLNS(II) = cboL.Text
		'    FAPLo(II) = AsmLo
		'    FAPLoDeg(II) = AsmLoDeg
		'    FAPLoMin(II) = AsmLoMin
		'    FAPLoEW(II) = cboLo.Text
		'End If
		cmdSave.Visible = False
		'cmdSave.Enabled = False
	End Sub
	Public Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
		Form11.Check1.Visible = False : Form11.Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check2.Visible = False : Form11.Check2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check3.Visible = False : Form11.Check3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check4.Visible = False : Form11.Check4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check5.Visible = False : Form11.Check5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check6.Visible = False : Form11.Check6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check7.Visible = False : Form11.Check7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check8.Visible = False : Form11.Check8.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check9.Visible = False : Form11.Check9.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check10.Visible = False : Form11.Check10.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check11.Visible = False : Form11.Check11.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Check12.Visible = False : Form11.Check12.CheckState = System.Windows.Forms.CheckState.Unchecked
		Form11.Show()
		If IU > 1 Then Form11.Check1.Visible = True : Form11.Check2.Visible = True ': Form11.Check2.Enabled = True
		If IU > 2 Then Form11.Check3.Visible = True ': Form11.Check3.Enabled = True
		If IU > 3 Then Form11.Check4.Visible = True ': Form11.Check4.Enabled = True
		If IU > 4 Then Form11.Check5.Visible = True ': Form11.Check5.Enabled = True
		If IU > 5 Then Form11.Check6.Visible = True ': Form11.Check6.Enabled = True
		If IU > 6 Then Form11.Check7.Visible = True ': Form11.Check7.Enabled = True
		If IU > 7 Then Form11.Check8.Visible = True ': Form11.Check8.Enabled = True
		If IU > 8 Then Form11.Check9.Visible = True ': Form11.Check9.Enabled = True
		If IU > 9 Then Form11.Check10.Visible = True ': Form11.Check10.Enabled = True
		If IU > 10 Then Form11.Check11.Visible = True ': Form11.Check11.Enabled = True
		If IU > 11 Then Form11.Check12.Visible = True ': Form11.Check12.Enabled = True
		WriteFixScreen()
		FixData()
	End Sub
	Public Sub WriteFixScreen()
		'UPGRADE_ISSUE: Form method Form11.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Form11.Cls()
		'UPGRADE_ISSUE: Form property Form11.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Form11.CurrentY = 1000
		IV = IU : If IU > 12 Then IV = 12
		For IW = 1 To IV
			i = IW : If IU > 12 Then i = IW + IU - Int((IU - 1) / 12) * 12
			'If i > 10 Then i = i - 10
			'Form11.Print Tab(11); TypeReduction(i);
			'If TypeReduction(i) = "LoC" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object FD(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMI(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print(TAB(13), VB6.Format(System.Math.Abs(FMI(i)), "0.0") & " " & FD(i))
			'If TypeReduction(i) = "NASR" Then Form11.Print Tab(23); Format(Abs(FMI(i)), "0"); " "; FD(i);
			'UPGRADE_WARNING: Couldn't resolve default property of object FZN(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print(TAB(26), VB6.Format(FZN(i), "000") & Chr(176))
			'UPGRADE_WARNING: Couldn't resolve default property of object FLA(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FLM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FLD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print(TAB(39 - Len(Str(Val(FLD(i))))), VB6.Format(Val(FLD(i)), "#0") & Chr(176) & VB6.Format(Val(FLM(i)), "00.0") & "'" & FLA(i))
			'UPGRADE_WARNING: Couldn't resolve default property of object FM(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FMD(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print(TAB(56 - Len(Str(Val(FMD(i))))), VB6.Format(Val(FMD(i)), "##0") & Chr(176) & VB6.Format(Val(FMM(i)), "00.0") & "'" & FM(i))
			'UPGRADE_WARNING: Couldn't resolve default property of object FZM(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FZH(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print(TAB(68), VB6.Format(FZH(i), "00") & VB6.Format(FZM(i), "00"))
			'If TypeReduction(i) = "LoC" Then Form11.Print
			'If TypeReduction(i) = "NASR" Then
			'    Form11.Print Tab(83 - Len(Str$((Val(FAPL(i)))))); Format(Val(FAPL(i)), "##0"); Chr$(176); FAPLNS(i);
			'    Form11.Print Tab(91 - Len(Str$((Val(FAPLoDeg(i)))))); Format(Val(FAPLoDeg(i)), "##0"); Chr$(176); Format(Val(FAPLoMin(i)), "00"); "'"; FAPLoEW(i)
			'End If
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print()
			'UPGRADE_ISSUE: Form method Form11.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Form11.Print()
		Next IW
	End Sub
	
	Public Function FixData() As Object
		IJ = 0 : If II > 10 Then IJ = II - Int(II / 10) * 10
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData1 = New Object(){FZN(1 + IJ), FMI(1 + IJ), FL(1 + IJ), FLo(1 + IJ), FZH(1 + IJ), FZM(1 + IJ)} ', FAPL(1+II-10), FAPLNS(1+II-10), FAPLo(1+II-10), FAPLoDeg(1+II-10), FAPLoMin(1+II-10), FAPLoEW(1+II-10), FType(1+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData2 = New Object(){FZN(2 + IJ), FMI(2 + IJ), FL(2 + IJ), FLo(2 + IJ), FZH(2 + IJ), FZM(2 + IJ)} ', FAPL(2+II-10), FAPLNS(2+II-10), FAPLo(2+II-10), FAPLoDeg(2+II-10), FAPLoMin(2+II-10), FAPLoEW(2+II-10), FType(2+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData3 = New Object(){FZN(3 + IJ), FMI(3 + IJ), FL(3 + IJ), FLo(3 + IJ), FZH(3 + IJ), FZM(3 + IJ)} ', FAPL(3+II-10), FAPLNS(3+II-10), FAPLo(3+II-10), FAPLoDeg(3+II-10), FAPLoMin(3+II-10), FAPLoEW(3+II-10), FType(3+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData4 = New Object(){FZN(4 + IJ), FMI(4 + IJ), FL(4 + IJ), FLo(4 + IJ), FZH(4 + IJ), FZM(4 + IJ)} ', FAPL(4+II-10), FAPLNS(4+II-10), FAPLo(4+II-10), FAPLoDeg(4+II-10), FAPLoMin(4+II-10), FAPLoEW(4+II-10), FType(4+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData5 = New Object(){FZN(5 + IJ), FMI(5 + IJ), FL(5 + IJ), FLo(5 + IJ), FZH(5 + IJ), FZM(5 + IJ)} ', FAPL(5+II-10), FAPLNS(5+II-10), FAPLo(5+II-10), FAPLoDeg(5+II-10), FAPLoMin(5+II-10), FAPLoEW(5+II-10), FType(5+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData6 = New Object(){FZN(6 + IJ), FMI(6 + IJ), FL(6 + IJ), FLo(6 + IJ), FZH(6 + IJ), FZM(6 + IJ)} ', FAPL(6+II-10), FAPLNS(6+II-10), FAPLo(6+II-10), FAPLoDeg(6+II-10), FAPLoMin(6+II-10), FAPLoEW(6+II-10), FType(6+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData7 = New Object(){FZN(7 + IJ), FMI(7 + IJ), FL(7 + IJ), FLo(7 + IJ), FZH(7 + IJ), FZM(7 + IJ)} ', FAPL(7+II-10), FAPLNS(7+II-10), FAPLo(7+II-10), FAPLoDeg(7+II-10), FAPLoMin(7+II-10), FAPLoEW(7+II-10), FType(7+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData8 = New Object(){FZN(8 + IJ), FMI(8 + IJ), FL(8 + IJ), FLo(8 + IJ), FZH(8 + IJ), FZM(8 + IJ)} ', FAPL(8+II-10), FAPLNS(8+II-10), FAPLo(8+II-10), FAPLoDeg(8+II-10), FAPLoMin(8+II-10), FAPLoEW(8+II-10), FType(8+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData9 = New Object(){FZN(9 + IJ), FMI(9 + IJ), FL(9 + IJ), FLo(9 + IJ), FZH(9 + IJ), FZM(9 + IJ)} ', FAPL(9+II-10), FAPLNS(9+II-10), FAPLo(9+II-10), FAPLoDeg(9+II-10), FAPLoMin(9+II-10), FAPLoEW(9+II-10), FType(9+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData10. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData10 = New Object(){FZN(10 + IJ), FMI(10 + IJ), FL(10 + IJ), FLo(10 + IJ), FZH(10 + IJ), FZM(10 + IJ)} ', FAPL(10+II-10), FAPLNS(10+II-10), FAPLo(10+II-10), FAPLoDeg(10+II-10), FAPLoMin(10+II-10), FAPLoEW(10+II-10), FType(10+II-10)+II-10+II-10)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData11. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData11 = New Object(){FZN(11 + IJ), FMI(11 + IJ), FL(11 + IJ), FLo(11 + IJ), FZH(11 + IJ), FZM(11 + IJ)} ', FAPL(11+II-11), FAPLNS(11+II-11), FAPLo(11+II-11), FAPLoDeg(11+II-11), FAPLoMin(11+II-11), FAPLoEW(11+II-11), FType(11+II-11)+II-11+II-11)
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FixData12. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FixData12 = New Object(){FZN(12 + IJ), FMI(12 + IJ), FL(12 + IJ), FLo(12 + IJ), FZH(12 + IJ), FZM(12 + IJ)} ', FAPL(12+II-12), FAPLNS(12+II-12), FAPLo(12+II-12), FAPLoDeg(12+II-12), FAPLoMin(12+II-12), FAPLoEW(12+II-12), FType(12+II-12)+II-12+II-12)
	End Function
	
	'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
		'txtTime.ForeColor = &H80000008
		txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime.Text) = 4 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(VB.Right(txtTime.Text, 2)) > 59) Then
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
		If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(VB.Right(txtTime.Text, 2)) > 59 Or Len(txtTime.Text) <> 4 Then
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
	Public Sub HO249()
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 360 Then AsmLHA = 0
		GHAAsmDeg = Val(txtGHADeg.Text)
		GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
		GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
		'    If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = AsmLHA - GHAAsm 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		'If Lo >= 0 Then AsmLoMin = Int(Val(txtGHAMin.text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.text) + 0.5)
		'If Lo > 0 Or txtLoDeg.text = "180" Then AsmLoMin = Val(txtGHAMin.text) Else AsmLoMin = 60 - Val(txtGHAMin.text)
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
		If AsmLoMin = 60 Then AsmLoMin = 0
		'LoDiff = Abs(Val(txtLoDeg.Text) + Int(Val(txtLoMin.Text) + 0.5) / 60) - Abs(AsmLo) 'LoDiff = Abs(Lo) - Abs(AsmLo)   'LoDiff = Abs(Lo) - Abs(AsmLoDeg + AsmLoMin / 60)
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = 1 Then AsmLoDeg = AsmLoDeg + 1
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = -1 Then AsmLoDeg = AsmLoDeg - 1
		AsmL = Int(L + 0.5)
		'AsmDec = Sgn(Dec) * Int(Abs(Dec))
		AsmDec = Int(System.Math.Abs(Dec))
		DecIncr = Int(Val(txtDecMin.Text) + 0.5)
		
		If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then AsmDec = -AsmDec ': SignDE$ = "-"
		
		Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
		If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
		Hc = Hc * 180 / Pi
		sgnHc = System.Math.Sign(Hc)
		TabHcDeg = Fix(Hc)
		TabHcMin = Hc - TabHcDeg
		TabHcMin = Int(60 * TabHcMin + 0.50023) 'WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.
		
		i = 1 : If AsmDec < 0 Then i = -1
		NextHc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
		If System.Math.Abs(NextHc) >= 1 Then NextHc = System.Math.Sign(NextHc) * Pi / 2 Else NextHc = System.Math.Atan(NextHc / System.Math.Sqrt(-NextHc * NextHc + 1)) 'arcsine
		NextHc = NextHc * 180 / Pi
		NextHcDeg = Int(NextHc)
		NextHcMin = NextHc - NextHcDeg
		NextHcMin = Int(60 * NextHcMin + 0.5)
		D = (60 * NextHcDeg + NextHcMin) - (60 * TabHcDeg + TabHcMin)
		
		D = System.Math.Sign(D) * Int(System.Math.Abs(D) + 0.5)
		SignD = "+" : If System.Math.Sign(D) = -1 Then SignD = "-"
		
		dcorr = D * DecIncr / 60
		dcorr = System.Math.Sign(D) * Int(System.Math.Abs(dcorr) + 0.5)
		TotHc = (TabHcDeg * 60 + TabHcMin + dcorr) / 60
		sgnTotHc = System.Math.Sign(TotHc)
		
		Signdcorr = "+" : If System.Math.Sign(dcorr) = -1 Then Signdcorr = "-"
		'dcorr = Sgn(D) * Int(Abs(dcorr) + 0.5)
		
		TotHcDeg = Fix(TotHc) : Htot = TotHc
		TotHcMin = TotHc - TotHcDeg
		TotHcMin = Int(60 * TotHcMin + 0.5)
		If TotHcMin = 60 Then TotHcMin = 0 : TotHcDeg = TotHcDeg + 1
		
		A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)
		'If HoinMinutes < 0 Then A = -(60 * Abs(TotHcDeg) + TotHcMin) - HoMin
		
		L4 = System.Math.Sin(AsmDec * Pi / 180)
		L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
		L6 = L4 - L5
		L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
		L8 = L6 / L7
		'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
		If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
		Z = Z * 180 / Pi
		'Z = FNRD(Z)    ?Need to round?
		Z = Int(Z + 0.5)
		'If L > 0 And LHA > 180 Then ZN = Z
		'If L > 0 And LHA <= 180 Then ZN = 360 - Z
		'If L <= 0 And LHA > 180 Then ZN = 180 - Z
		'If L <= 0 And LHA <= 180 Then ZN = 180 + Z
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		
		ZN = Int(ZN + 0.5) 'added in V4.0.0
	End Sub
	Public Sub Display249()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = True
		Line4.Visible = True
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame211.Visible = False
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(19), "INTERCEPT and AZIMUTH by Pub. 249 SIGHT REDUCTION TABLES")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Calc. of Asm Lo and Asm LHA")
		
		'LengthZtotDisplay = Len(Str$(Abs(ZtotDisplay)))
		'If Abs(ZtotDisplay) - Int(Abs(ZtotDisplay)) = 0 Then LengthZtotDisplay = LengthZtotDisplay + 2
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA", TAB(22 - Len(Str(Val(txtGHADeg.Text)))), VB6.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & VB6.Format(Val(txtGHAMin.Text), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Tab Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If sgnHc = -1 Then Print(TAB(38), "-")
		'If sgnHc = -1 Then Print Tab(41 - Len(Str$(TabHcDeg))); "-";
		'i = 42          'i = 43:If sgnHc = -1 Then i = 42
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42 - Len(Str(System.Math.Abs(TabHcDeg)))), VB6.Format(System.Math.Abs(TabHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TabHcMin), "00") & "'", TAB(56), "d (" & SignD & ") " & VB6.Format(System.Math.Abs(D), "00") & "'", TAB(77), "Tab Z " & cboL.Text, TAB(89 - Len(Str(Z))), VB6.Format(System.Math.Abs(Z), "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm Lo (")
		'If cboLo.text = "W" Then SignA3$ = "W": Print "-";
		'If cboLo.text = "E" Then SignA3$ = "E": Print "+";
		If AsmLo = 0 Then
			SignA3 = " "
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		If System.Math.Sign(AsmLo) = 1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-")
			SignA3 = "W"
		End If
		If System.Math.Sign(AsmLo) = -1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+")
			SignA3 = "E"
		End If
		If System.Math.Sign(AsmLo) = 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
			SignA3 = " "
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(22 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00.0") & "'" & SignA3)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "d corr. (" & Signdcorr & ") " & VB6.Format(System.Math.Abs(dcorr), "00") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("LHA", TAB(22 - Len(Str(AsmLHA))), VB6.Format(AsmLHA, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If sgnTotHc = -1 Then Print(TAB(38), "-") 'Tab(i - Len(Str$(TotHcDeg))); "-";        'If sgnTotHc = -1 Then
		'i = 42         'i = 43: If sgnTotHc = -1 Then i = 42
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42 - Len(Str(System.Math.Abs(TotHcDeg)))), VB6.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TotHcMin), "00") & "'")
		
		HoMin = Int(HoMin + 0.5)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm L ", TAB(22 - Len(Str(AsmL))), VB6.Format(System.Math.Abs(AsmL), "#0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL = 0 Then
			Print(" ")
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(cboL.Text)
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Ho ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoinMinutes < 0 Then Print(TAB(38), "-")
		'i = 42          'i = 43: If HoinMinutes < 0 Then i = 42
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(42 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm Dec", TAB(22 - Len(Str(DecDegrees))), VB6.Format(DecDegrees, "#0") & Chr(176) & cboDec.Text, SPC(7), "a ", TAB(44 - Len(Str(Int(System.Math.Abs(A))))), CStr(Int(System.Math.Abs(A) + 0.5)) & "nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotHc < Ho Then Print("T  Ho > Hc....Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If TotHc > Ho Then Print("A  Hc > Ho....Away")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Dec Incr", TAB(22 - Len(Str(DecIncr))), VB6.Format(DecIncr, "00") & "'", SPC(58), "Zn  " & VB6.Format(ZN, "000") & Chr(176))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(33), "d corr. Interpolation")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(29), "d corr. =" & DecIncr & "x " & CStr(D) & "/ 60 => " & Signdcorr & VB6.Format(System.Math.Abs(dcorr), "00"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "AP/EP L " & VB6.Format(APEstLDeg, "0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist < 0 Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist > 0 Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
	End Sub
	
	Public Sub Weems()
		B3 = 0 : B4 = 0 : B5 = 0 : Btot = 0
		LHA = GHA - Lo
		LHA = Int(LHA + 0.5)
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		If LHA <= 180 Then T = LHA 'W
		If LHA > 180 Then T = 360 - LHA 'E
		tDeg = Int(T + 0.5)
		'    tMin = (T - tDeg) * 60
		'    tMin = Int(tMin + 0.50000001)
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 360 Then AsmLHA = 0
		GHAAsmDeg = Val(txtGHADeg.Text)
		GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
		GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
		'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		'If Lo >= 0 Then AsmLoMin = Int(Val(txtGHAMin.text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.text) + 0.5)
		'If Lo > 0 Or txtLoDeg.text = "180" Then AsmLoMin = Val(txtGHAMin.text) Else AsmLoMin = 60 - Val(txtGHAMin.text)
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
		If AsmLoMin = 60 Then AsmLoMin = 0
		AsmL = Int(L + 0.5)
		
		N = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(LHA * Pi / 180)
		If System.Math.Abs(N) >= 1 Then N = System.Math.Sign(N) * Pi / 2 Else N = System.Math.Atan(N / System.Math.Sqrt(-N * N + 1)) 'arcsin
		If N = 0 Then N = 0.0000000001 * Pi / 180
		A1 = 100000 * (System.Math.Log(1 / System.Math.Cos(N)) / System.Math.Log(10))
		'A1 = Int(A1 + 0.5)
		If T >= 21 Then A1 = Int(A1 + 0.65) 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
		If T <= 20 Then A1 = Int(A1 * 10 + 0.65) / 10
		If T = 0 Then A1 = 0 'do not want to round for 0 latitude
		'A1 = Round(A1)
		
		Z3 = System.Math.Cos(AsmLHA * Pi / 180) / System.Math.Cos(N) 'Example b p 2-24 bottom of first column makes Z3=1 NG
		'If Abs(Z3) = 1 Then Z3 = 0  'prevents program from crashing with no inputs
		If System.Math.Abs(Z3) >= 1 Then Z1 = System.Math.Sign(Z3) * Pi / 2 Else Z1 = System.Math.Atan(Z3 / System.Math.Sqrt(-Z3 * Z3 + 1)) 'in radians
		B1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(Z1)
		If System.Math.Abs(B1) >= 1 Then B = System.Math.Sign(B1) * Pi / 2 Else B = System.Math.Atan(B1 / System.Math.Sqrt(-B1 * B1 + 1)) 'in radians
		B = B * 180 / Pi
		BDeg = Int(System.Math.Abs(B))
		BMin = Int(((System.Math.Abs(B) - BDeg) * 60) * 10 + 0.5) / 10
		If BMin = 60 Then BMin = 0 : BDeg = BDeg + 1
		B = BDeg + BMin / 60
		'    DE = Int(DE * 60 + 0.50000000001) 'rounded to whole minutes
		If (cboDec.Text = "N " And cboL.Text = "S ") Or (cboDec.Text = "S " And cboL.Text = "N ") Then DE = -DE ': SignDE$ = "-"
		F = B + DE 'in degrees
		
		Kd = 90 - F ': KdOrig = Kd
		If AsmL = 0 Then k = 0
		KdDeg = Int(System.Math.Abs(Kd))
		KdMin = Int(((System.Math.Abs(Kd) - KdDeg) * 60) * 10 + 0.5) / 10 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
		If AsmL = 0 Then KdMin = 0
		'KdMin = Int((Abs(Kd) - KdDeg) * 60)
		'    If chkInterpolateB = 0 Then KdMin = Int(KdMin + 1)    '1 was 0.5   ??????????????????????????????????????????????????????????
		k = KdDeg + KdMin / 60 + DE
		If T > 90 Then
			k = 180 - k
			Kd = k - DE 'Kd must be 0-90 for a legitimate sight
			'If Kd > 90 Then Kd = 180 = Kd
			If Kd > 90 Then Exit Sub
			KdDeg = Int(System.Math.Abs(Kd))
			KdMin = Int(((System.Math.Abs(Kd) - KdDeg) * 60) * 10 + 0.5) / 10 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
		End If
		'k = Kd + DE
		KDeg = Int(System.Math.Abs(k))
		KMin = Int(((System.Math.Abs(k) - KDeg) * 60) * 10 + 0.5) / 10
		If AsmL = 0 Then KMin = 0
		'    If chkInterpolateB = 0 Then B = 100000 * (Log(1 / Cos((KdDeg + Int(KdMin + 0.5) / 60) * Pi / 180)) / Log(10))
		'    If chkInterpolateB = 1 Then B = 100000 * (Log(1 / Cos((KdDeg + KdMin / 60) * Pi / 180)) / Log(10))
		'    'B = 100000 * (Log(1 / Cos((KdDeg + KdMin / 60) * Pi / 180)) / Log(10))
		'    'B = 100000 * (Log(1 / Cos((Kd) * Pi / 180)) / Log(10))
		'    'B = 100000 * (Log(1 / Cos((KdOrig) * Pi / 180)) / Log(10))
		'    If chkInterpolateB = 0 Then B = Int(B + 0.5)   'If Kd >= 10 Then B = Int(B + 0.5)
		'    If chkInterpolateB = 1 Then B = Int(B * 10 + 0.5) / 10      'If Kd < 10 Then B = Int(B * 10 + 0.5) / 10
		B = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin + 0.5) / 60) * Pi / 180)) / System.Math.Log(10)) 'round to nearest minute
		'B = 100000 * (Log(1 / (Cos((KdDeg + KdMin / 60) * Pi / 180))) / Log(10))         'use tenths of minutes
		'B = 100000 * (Log(1 / Cos(Kd * Pi / 180)) / Log(10))
		If Kd >= 10 Then B = Int(B + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
		If Kd < 10 Then B = Int(B * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
		If chkInterpolateB.CheckState = 1 Then 'this does linear interpolation
			'B = 100000 * (Log(1 / (Cos((KdDeg + KdMin / 60) * Pi / 180))) / Log(10))
			If Int(KdMin + 0.5) > KdMin Then B22 = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin - 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
			If Int(KdMin + 0.5) < KdMin Then B22 = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin + 1.5) / 60) * Pi / 180)) / System.Math.Log(10))
			If (Kd + 1 / 60) >= 10 Then B22 = Int(B22 + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
			If (Kd + 1 / 60) < 10 Then B22 = Int(B22 * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
			If B >= B22 Then B = B22 + (KdMin - Int(KdMin)) * System.Math.Abs(B - B22)
			If B < B22 Then B = B + (KdMin - Int(KdMin)) * System.Math.Abs(B - B22)
			'B = Int(B * 10 + 0.5) / 10
		End If
		If Kd >= 10 Then B = Int(B + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
		If Kd < 10 Then B = Int(B * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
		
		
		AB = A1 + B
		'If T <= 20 Or Kd < 10 Or chkInterpolateB = 1 Then AB = Int(AB * 10 + 0.5) / 10 Else AB = Int(AB + 0.5)
		If T <= 20 Or Kd < 10 Or chkInterpolateB.CheckState = 1 Then AB = Int(AB * 10 + 0.5) / 10 Else AB = Int(AB + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
		Hc = 1 / (10 ^ (AB / 100000))
		
		If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
		Hc = Hc * 180 / Pi
		HcDeg = Int(System.Math.Abs(Hc))
		If chkInterpolateB.CheckState = 0 Then HcMin = Int(((System.Math.Abs(Hc) - HcDeg) * 60) + 0.5)
		If chkInterpolateB.CheckState = 1 Then HcMin = Int(((System.Math.Abs(Hc) - HcDeg) * 60) * 10 + 0.5) / 10
		HcDecimal = HcDeg + HcMin / 60
		Htot = Hc
		
		A = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		'Z by formula
		'Z = (Sin(T * Pi / 180) * Cos(DE * Pi / 180)) / Cos(Hc * Pi / 180)
		Z = (System.Math.Sin(T * Pi / 180) * System.Math.Cos(DE * Pi / 180)) / System.Math.Cos((HcDeg + HcMin / 60) * Pi / 180)
		If System.Math.Abs(Z) >= 1 Then Z = System.Math.Sign(Z) * Pi / 2 Else Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1)) 'arcsine
		Z = Z * 180 / Pi
		'Z = FNRD(Z)    ?Need to round?
		Z = Int(Z * 10 + 0.5) / 10
		If DE >= L And LHA > 180 Then ZN = Z
		If DE >= L And LHA <= 180 Then ZN = 360 - Z
		If DE < L And LHA > 180 Then ZN = 180 - Z
		If DE < L And LHA <= 180 Then ZN = 180 + Z
		
		ZN = Int(ZN * 10 + 0.5) / 10
		If ZN = 360 Then ZN = 0
		
		'Z by table
		If T = 0 Then Exit Sub
		
		B2 = 100000 * (System.Math.Log(1 / System.Math.Sin(T * Pi / 180)) / System.Math.Log(10))
		'The next two lines were eliminated when it ws found that LPB never interpolated B for azimuth by table
		'If T < 80 Then B3 = Int(B2 + 0.5)
		'If T >= 80 Then B3 = Int(B2 * 10 + 0.5) / 10
		B3 = Int(B2 + 0.5)
		'If T < 80 Or chkInterpolateB = 0 Then B3 = Int(B2 + 0.5)
		'If T >= 80 Or chkInterpolateB = 1 Then B3 = Int(B2 * 10 + 0.5) / 10
		'B2 = 100000 * (Log(1 / Sin(T * Pi / 180)) / Log(10))
		'If T < 80 Then B3 = Int(B2 + 0.5)
		'If T >= 80 Then B3 = Int(B2 * 10 + 0.5) / 10
		'If chkInterpolateB = 1 Then
		'    B22 = 100000 * (Log(1 / Sin((T + 1) * Pi / 180)) / Log(10))
		'    If (T + 1) < 80 Then B22 = Int(B22 + 0.5)
		'    If (T + 1) >= 80 Then B22 = Int(B22 * 10 + 0.5) / 10
		'    B4 = B4 + (Val(DecMinutes) - Int(Val(DecMinutes))) * (B22 - B2)
		'    B4 = Int(B4 * 10 + 0.5) / 10
		'End If
		
		'B2 = 100000 * (Log(1 / Cos((DE) * Pi / 180)) / Log(10))
		'B22 = 100000 * (Log(1 / Cos((DecDegrees + Int(DecMinutes + 1.5) / 60) * Pi / 180)) / Log(10))
		'If Abs(DE) >= 10 Or chkInterpolateB = 0 Or (Val(DecMinutes) - Int(Val(DecMinutes)) = 0) Then B4 = Int(B2 + 0.5)
		'If Abs(DE) < 10 Or chkInterpolateB = 1 And (Val(DecMinutes) - Int(Val(DecMinutes)) = 0) Then B4 = Int(B2 * 10 + 0.5) / 10
		'The next 10 lines were eliminated when it ws found that LPB never interpolated B for azimuth by table (linear interpolation was wrong anyway)
		'    B2 = 100000 * (Log(1 / Cos((DecDegrees + Int(DecMinutes + 0.5) / 60) * Pi / 180)) / Log(10))
		'    If Abs(DE) >= 10 Then B4 = Int(B2 + 0.5)                                                    'SHOULD THIS BE 0.65???????????????????????????
		'    If Abs(DE) < 10 Then B4 = Int(B2 * 10 + 0.5) / 10                                           'SHOULD THIS BE 0.65???????????????????????????
		'    If chkInterpolateB = 1 Then
		'        B22 = 100000 * (Log(1 / Cos((DecDegrees + Int(DecMinutes + 1.5) / 60) * Pi / 180)) / Log(10))
		'        If Abs(DE + 1) >= 10 Then B22 = Int(B22 + 0.5)                                          'SHOULD THIS BE 0.65???????????????????????????
		'        If Abs(DE + 1) < 10 Then B22 = Int(B22 * 10 + 0.5) / 10                                 'SHOULD THIS BE 0.65???????????????????????????
		'        B4 = B4 + (Val(DecMinutes) - Int(Val(DecMinutes))) * (B22 - B2)
		'        B4 = Int(B4 * 10 + 0.5) / 10
		'    End If
		B2 = 100000 * (System.Math.Log(1 / System.Math.Cos((DecDegrees + Int(DecMinutes + 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
		B4 = Int(B2 + 0.5)
		
		B2 = 100000 * (System.Math.Log(1 / System.Math.Cos((HcDeg + Int(HcMin + 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
		'If (HcDeg + HcMin / 60) >= 10 Or chkInterpolateB = 0 Then B5 = Int(B2 + 0.5)
		'If (HcDeg + HcMin / 60) < 10 Or chkInterpolateB = 1 Then B5 = Int(B2 * 10 + 0.5) / 10
		'The next nine lines were eliminated when it ws found that LPB never interpolated B for azimuth by table (linear interpolation was wrong anyway)
		'If (HcDeg + HcMin / 60) >= 10 Then B5 = Int(B2 + 0.5)
		'If (HcDeg + HcMin / 60) < 10 Then B5 = Int(B2 * 10 + 0.5) / 10
		'If chkInterpolateB = 1 Then
		'    B22 = 100000 * (Log(1 / Cos((HcDeg + Int(HcMin - 0.5) / 60) * Pi / 180)) / Log(10))
		'    If (HcDeg + (HcMin - 1) / 60) >= 10 Then B22 = Int(B22 + 0.5)
		'    If (HcDeg + (HcMin - 1) / 60) < 10 Then B22 = Int(B22 * 10 + 0.5) / 10
		'    B5 = B22 + (Val(HcMin) - Int(Val(HcMin))) * (B5 - B22)
		'    B5 = Int(B5 * 10 + 0.5) / 10
		'End If
		B5 = Int(B2 + 0.5)
		
		
		'B34 = B3 + B4
		'If chkInterpolateB = 0 Then B34 = Int(B34 + 0.5)
		'If chkInterpolateB = 1 Then B34 = Int(B34 * 10 + 0.5) / 10
		Btot = B3 + B4 - B5
		'The next line was eliminated when it ws found that LPB never interpolated B for azimuth by table
		'If chkInterpolateB = 0 And B3 - Int(B3) = 0 And B4 - Int(B4) = 0 And B5 - Int(B5) = 0 Then Btot = Int(Btot + 0.5) Else Btot = Int(Btot * 10 + 0.5) / 10
		Btot = Int(Btot + 0.5)
		Z4 = 1 / (10 ^ (Btot / 100000)) 'Z4 is Z using tables
		'    If Z4 = 0 Then Z4 = 0.0000000001
		If System.Math.Abs(Z4) >= 1 Then Z4 = System.Math.Sign(Z4) * Pi / 2 Else Z4 = System.Math.Atan(Z4 / System.Math.Sqrt(-Z4 * Z4 + 1)) 'arcsine
		Z4 = Z4 * 180 / Pi
		Z4Deg = Int(System.Math.Abs(Z4))
		'The next line was eliminated when it ws found that LPB never interpolated B for azimuth by table
		'If chkInterpolateB = 0 Then Z4Min = Int((Abs(Z4) - Z4Deg) * 60 + 0.5)
		'If chkInterpolateB = 1 Then Z4Min = Int(((Abs(Z4) - Z4Deg) * 60) * 10 + 0.5) / 10
		Z4Min = Int((System.Math.Abs(Z4) - Z4Deg) * 60 + 0.5)
		
		If DE >= L And LHA > 180 Then ZnT = Z4
		If DE >= L And LHA <= 180 Then ZnT = 360 - Z4
		If DE < L And LHA > 180 Then ZnT = 180 - Z4
		If DE < L And LHA <= 180 Then ZnT = 180 + Z4
		ZnTDeg = Int(System.Math.Abs(ZnT))
		'The next two lines were eliminated when it ws found that LPB never interpolated B for azimuth by table
		'If chkInterpolateB = 0 Then ZnTMin = Int((Abs(ZnT) - ZnTDeg) * 60 + 0.5)
		'If chkInterpolateB = 1 Then ZnTMin = Int(((Abs(ZnT) - ZnTDeg) * 60) * 10 + 0.5) / 10
		ZnTMin = Int((System.Math.Abs(ZnT) - ZnTDeg) * 60 + 0.5)
		
	End Sub
	
	Public Sub DisplayWeems()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = True
		Line18.Visible = True
		Line19.Visible = True
		Line20.Visible = True
		Line21.Visible = True
		Line22.Visible = True
		Line23.Visible = True
		frameNASRUsing.Visible = False
		'frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = True
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If Kd > 90 Then
			Line17.Visible = False
			Line18.Visible = False
			Line19.Visible = False
			Line20.Visible = False
			Line21.Visible = False
			Line22.Visible = False
			Line23.Visible = False
			chkInterpolateB.Visible = False
			MsgBox("Check input data.")
			Exit Sub
		End If
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(23), "INTERCEPT and AZIMUTH by WEEMS LINE OF POSITION BOOK")
		'Print
		'    Print "Calc. of Asm Lo and LHA"
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA", TAB(17 - Len(Str(Val(txtGHADeg.Text)))), VB6.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & VB6.Format(Val(txtGHAMin.Text), "00.0") & "'") '; Tab(83); "DEC and LAT "
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm Lo (")
		'If cboLo.text = "W " Then SignA3$ = "W": Print "-";
		'If cboLo.text = "E " Then SignA3$ = "E": Print "+";
		If AsmLo = 0 Then
			SignA3 = " "
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		If System.Math.Sign(AsmLo) = 1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-")
			SignA3 = "W"
		End If
		If System.Math.Sign(AsmLo) = -1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+")
			SignA3 = "E"
		End If
		If System.Math.Sign(AsmLo) = 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
			SignA3 = " "
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(17 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00.0") & "'" & SignA3)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "d", TAB(53 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("-->  B")
		i = Len(Str(B4)) : If (B4 - Int(B4)) = 0 Then i = i + 2
		If B4 < 1 And B4 > 0 Then i = i + 1
		'The next line was changed when it was found that LPB never interpolated B for azimuth by table
		'If Abs(DE) < 10 Or chkInterpolateB = 1 Then Print Tab(76 - i); Format(B4, "#0.0"); " (top, from d)" Else _
		'Print Tab(76 - i); Format(B4, "#0"); "   (top, from d)"
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(76 - i), VB6.Format(B4, "#0") & "   (top, from d)")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("t*(LHA)", TAB(17 - Len(Str(tDeg))), VB6.Format(tDeg, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" ----->", TAB(26), "A")
		i = Len(Str(A1)) : If (A1 - Int(A1)) = 0 Then i = i + 2
		If A1 < 1 And A1 > 0 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T >= 21 Or A1 = 0 Then Print(TAB(39 - i), VB6.Format(A1, "#0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T <= 20 And A1 <> 0 Then Print(TAB(39 - i), VB6.Format(A1, "#0.0")) '39 was 41
		i = Len(Str(KDeg)) : If (KDeg - Int(KDeg)) = 0 Then i = i + 2
		If KDeg < 1 And KDeg > 0 Then i = i + 1 'is this line necessary?
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "K", TAB(55 - i), VB6.Format(KDeg, "0") & Chr(176) & VB6.Format(KMin, "00.0") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("--> +B")
		i = Len(Str(B3)) : If (B3 - Int(B3)) = 0 Then i = i + 2
		If B3 < 1 And B3 > 0 Then i = i + 1
		'The next lines were changed when it was found that LPB never interpolated B for azimuth by table
		'If T >= 80 And T <> 0 Then Print Tab(76 - i); Format(B3, "#0.0"); " (bottom, from t)" Else _
		'If T <> 0 Then Print Tab(76 - i); Format(B3, "#0"); "   (bottom, from t)"
		'    If T = 0 Then Print Tab(67); "infinite (bottom, from t)"
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T <> 0 Then Print(TAB(76 - i), VB6.Format(B3, "#0") & "   (bottom, from t)")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T = 0 Then Print(TAB(67), "infinite (bottom, from t)")
		
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm L* ", TAB(17 - Len(Str(AsmL))), VB6.Format(System.Math.Abs(AsmL), "#0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL <> 0 Then Print(cboL.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "B")
		i = Len(Str(B)) : If (B - Int(B)) = 0 Then i = i + 2
		If B < 1 And B > 0 Then i = i + 1
		'If Kd >= 10 Then Print Tab(39 - i); Format(B, "#0");                'DO THESE LINES  NEED CHKINTERPOLATEB?????????????????????????
		'In next line, was (Kd < 10 Or chkInterpolateB = 1)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Kd < 10 And (KdMin - Int(KdMin)) <> 0 Then
			Print(TAB(39 - i), VB6.Format(B, "#0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(39 - i), VB6.Format(B, "#0"))
		End If 'If (Kd >= 10 Or chkInterpolateB = 0) And (KdMin - Int(KdMin)) = 0 Then
		i = Len(Str(KdDeg)) : If (KdDeg - Int(KdDeg)) = 0 Then i = i + 2
		If KdDeg < 1 And KdDeg > 0 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(39), "<--", TAB(44), "K~d*", TAB(55 - i), VB6.Format(KdDeg, "0") & Chr(176) & VB6.Format(KdMin, "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(26), "A+B") 'THIS IS JUST AN ADDITION - DOES NOT NEED CHKINTERPOLATEB?  BUT IT CHANGES WITH CHKINTERPOLATEB
		i = Len(Str(AB)) : If (AB - Int(AB)) = 0 Then i = i + 2
		If AB < 1 And AB > 0 Then i = i + 1
		'If T >= 21 Or Kd >= 10 Then Print Tab(37 - Len(Str$(AB))); Format(AB, "#0"); Tab(38); " --->"; Tab(44); "Hc"; Tab(52 - Len(Str$(HcDeg))); Format(HcDeg, "0"); Chr$(176); Format(HcMin, "00.0"); "'"
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (T <= 20 Or Kd < 10 Or chkInterpolateB.CheckState = 1) And ((AB - Int(AB)) <> 0) Then
			Print(TAB(39 - i), VB6.Format(AB, "#0.0"), TAB(38), " -B->", TAB(44), "Hc", TAB(52 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(39 - i), VB6.Format(AB, "#0"), TAB(38), " -B->", TAB(44), "Hc", TAB(52 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" ----> -B")
		i = Len(Str(B5)) : If (B5 - Int(B5)) = 0 Then i = i + 2
		If B5 < 1 And B5 > 0 Then i = i + 1
		'The next lines were changed when it was found that LPB never interpolated B for azimuth by table
		'If (HcDeg + HcMin / 60) < 10 Or chkInterpolateB = 1 Then Print Tab(76 - i); Format(B5, "#0.0"); " (top, from Hc)" Else _
		'Print Tab(76 - i); Format(B5, "#0"); "   (top, from Hc)"
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(76 - i), VB6.Format(B5, "#0") & "   (top, from Hc)")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(44), "Ho", TAB(52 - Len(Str(HoDeg))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(HoMin, "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Z ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DE >= L Then Print("N ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DE < L Then Print("S ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(Z, "#00.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W" & "; ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E" & "; ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Zn " & VB6.Format(ZN, "000.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(44), "a", TAB(55 - Len(Str(Int(System.Math.Abs(A))))))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal < Ho Then Print(" Towards")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal > Ho Then Print(" Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal = Ho Then Print(" ")
		i = Len(Str(Btot)) : If (Btot - Int(Btot)) = 0 Then i = i + 2
		If Btot < 1 And Btot > 0 Then i = i + 1
		'The next lines were changed when it was found that LPB never interpolated B for azimuth by table
		'If ((Btot - Int(Btot)) <> 0 Or chkInterpolateB = 1) And T <> 0 Then Print Tab(76 - i); Format(Btot, "#0.0"); " --B->"; Else _
		''    If T <> 0 Then Print Tab(76 - i); Format(Btot, "#0"); " ----B->";
		'                If T = 0 Then Print Tab(67); "infinite --B->";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T <> 0 Then Print(TAB(76 - i), VB6.Format(Btot, "#0") & " ----B->")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If T = 0 Then Print(TAB(67), "infinite --B->")
		
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(82))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DE >= L Then Print("Z N ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DE < L Then Print("Z S ")
		'The next lines were changed when it was found that LPB never interpolated B for azimuth by table
		'If chkInterpolateB = 0 Then Print Format(Z4Deg, "#0"); Chr$(176); Format(Z4Min, "00"); "'";
		'If chkInterpolateB = 1 Then Print Format(Z4Deg, "#0"); Chr$(176); Format(Z4Min, "00.0"); "'";
		'    If LHA <= 180 Then Print " W"
		'    If LHA > 180 Then Print " E"
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(Z4Deg, "#0") & Chr(176) & VB6.Format(Z4Min, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("    (by formula)", TAB(25), "AP/EP L " & VB6.Format(APEstLDeg, "#0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(71), "(bottom)")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(82), "Zn ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkInterpolateB.CheckState = 0 Then Print(VB6.Format(ZnTDeg, "#0") & Chr(176) & VB6.Format(ZnTMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkInterpolateB.CheckState = 1 Then Print(VB6.Format(ZnTDeg, "#0") & Chr(176) & VB6.Format(ZnTMin, "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist < 0 Then Print("Towards")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist > 0 Then Print("Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(82), "(by tables)")
		
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("*Table entry values")
		
	End Sub
	
	Public Sub HO229()
		DSDcorrFlag = False
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 360 Then AsmLHA = 0
		GHAAsmDeg = Val(txtGHADeg.Text)
		GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
		GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
		'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		'If Lo >= 0 Then AsmLoMin = Int(Val(txtGHAMin.text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.text) + 0.5)
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
		If AsmLoMin = 60 Then AsmLoMin = 0
		'LoDiff = Abs(Val(txtLoDeg.Text) + Int(Val(txtLoMin.Text) + 0.5) / 60) - Abs(AsmLo) 'LoDiff = Abs(Lo) - Abs(AsmLo)   'LoDiff = Abs(Lo) - Abs(AsmLoDeg + AsmLoMin / 60)
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = 1 Then AsmLoDeg = AsmLoDeg + 1
		'If Abs(LoDiff) > 0.5 And Sgn(LoDiff) = -1 Then AsmLoDeg = AsmLoDeg - 1
		AsmL = Int(L + 0.5)
		'AsmDec = Sgn(Dec) * Int(Abs(Dec))
		AsmDec = Int(System.Math.Abs(Dec))
		DecIncr = Val(txtDecMin.Text)
		
		If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then AsmDec = -AsmDec ': SignDE$ = "-"
		
		Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
		If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
		Hc = Hc * 180 / Pi
		TabHcDeg = Fix(Hc) 'was Int
		TabHcMin = Hc - TabHcDeg
		TabHcMin = Int((60 * TabHcMin) * 10 + 0.5) / 10 'WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.
		
		i = 1 : If AsmDec < 0 Then i = -1
		NextHc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
		If System.Math.Abs(NextHc) >= 1 Then NextHc = System.Math.Sign(NextHc) * Pi / 2 Else NextHc = System.Math.Atan(NextHc / System.Math.Sqrt(-NextHc * NextHc + 1)) 'arcsine
		NextHc = NextHc * 180 / Pi
		NextHcDeg = Int(NextHc)
		NextHcMin = NextHc - NextHcDeg
		NextHcMin = Int((60 * NextHcMin) * 10 + 0.5) / 10
		
		i = -1 : If AsmDec < 0 Then i = 1
		NextHcDSD1 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
		If System.Math.Abs(NextHcDSD1) >= 1 Then NextHcDSD1 = System.Math.Sign(NextHcDSD1) * Pi / 2 Else NextHcDSD1 = System.Math.Atan(NextHcDSD1 / System.Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1)) 'arcsine
		NextHcDSD1 = NextHcDSD1 * 180 / Pi
		NextHcDSD1Deg = Int(NextHcDSD1)
		NextHcDSD1Min = NextHcDSD1 - NextHcDSD1Deg
		NextHcDSD1Min = Int((60 * NextHcDSD1Min) * 10 + 0.5) / 10
		
		i = 2 : If AsmDec < 0 Then i = -2
		NextHcDSD2 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
		If System.Math.Abs(NextHcDSD2) >= 1 Then NextHcDSD2 = System.Math.Sign(NextHcDSD2) * Pi / 2 Else NextHcDSD2 = System.Math.Atan(NextHcDSD2 / System.Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1)) 'arcsine
		NextHcDSD2 = NextHcDSD2 * 180 / Pi
		NextHcDSD2Deg = Int(NextHcDSD2)
		NextHcDSD2Min = NextHcDSD2 - NextHcDSD2Deg
		NextHcDSD2Min = Int((60 * NextHcDSD2Min) * 10 + 0.5) / 10
		
		D = (60 * NextHcDeg + NextHcMin) - (60 * TabHcDeg + TabHcMin)
		SgnD = System.Math.Sign(D)
		'D = Sgn(D) * Int(Abs(D) + 0.5)
		SignD = "+" : If System.Math.Sign(D) = -1 Then SignD = "-"
		d1corr = Int((Int(System.Math.Abs(D) / 10) * DecIncr / 60) * 100 + 0.5) / 10
		d2corr = Int(((System.Math.Abs(D) - 10 * Int(System.Math.Abs(D) / 10)) * DecIncr / 60) * 10 + 0.5) / 10
		
		DSD1 = (60 * TabHcDeg + TabHcMin) - (60 * NextHcDSD1Deg + NextHcDSD1Min)
		'DSD2 = (60 * NextHcDeg + NextHcMin) - (60 * TabHcDeg + TabHcMin)
		DSD3 = (60 * NextHcDSD2Deg + NextHcDSD2Min) - (60 * NextHcDeg + NextHcMin)
		'DSD = (DSD2 - DSD1) + (DSD3 - DSD2)
		DSD = (D - DSD1) + (DSD3 - D)
		SgnDSD = System.Math.Sign(DSD)
		
		DSDcorr = 2.1 * System.Math.Sin(DecIncr * 3 * Pi / 180) * System.Math.Abs(DSD) / 33
		DSDcorr = Int(DSDcorr * 10 + 0.5) / 10
		If chkDSD.CheckState = 0 And DSDcorr <= 0.25 Then DSDcorr = 0 : DSDcorrFlag = True
		
		Totcorr = SgnD * (d1corr + d2corr) + System.Math.Abs(DSDcorr)
		SignTotcorr = "+" : If Totcorr < 0 Then SignTotcorr = "-"
		'Totcorr=
		
		TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60
		'Signdcorr$ = "+": If Sgn(dcorr) = -1 Then Signdcorr$ = "-"
		'dcorr = Sgn(D) * Int(Abs(dcorr) + 0.5)
		
		TotHcDeg = Fix(TotHc) : Htot = TotHc 'was Int
		TotHcMin = TotHc - TotHcDeg
		TotHcMin = Int(600 * TotHcMin + 0.5) / 10
		If TotHcMin = 60 Then TotHcMin = 0 : TotHcDeg = TotHcDeg + 1
		
		A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)
		
		L4 = System.Math.Sin(AsmDec * Pi / 180)
		L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
		L6 = L4 - L5
		L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
		L8 = L6 / L7
		'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
		If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
		Z = Z * 180 / Pi
		'Z = FNRD(Z)    ?Need to round?
		TabZ = Int(Z * 10 + 0.5) / 10
		
		'For calculating Z corr
		i = 1 : If AsmDec < 0 Then i = -1
		ZL4 = System.Math.Sin((AsmDec + i) * Pi / 180)
		ZL5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(NextHc * Pi / 180)
		ZL6 = ZL4 - ZL5
		ZL7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(NextHc * Pi / 180)
		ZL8 = ZL6 / ZL7
		'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
		If System.Math.Abs(ZL8) >= 1 Then ZC = Pi Else ZC = System.Math.Atan(-ZL8 / System.Math.Sqrt(-ZL8 * ZL8 + 1)) + Pi / 2 'arccosine
		ZC = ZC * 180 / Pi
		ZC = Int(ZC * 10 + 0.5) / 10
		
		Zdiff = ZC - TabZ
		If System.Math.Sign(Zdiff) = 0 Then SignZdiff = " "
		If System.Math.Sign(Zdiff) > 0 Then SignZdiff = "+"
		If System.Math.Sign(Zdiff) < 0 Then SignZdiff = "-"
		
		Zcorr = DecIncr / 60 * Zdiff
		Zcorr = Int(Zcorr * 10 + 0.5) / 10
		Ztot = TabZ + Zcorr
		Ztot = Int(Ztot * 10 + 0.5) / 10
		
		'If L > 0 And LHA > 180 Then ZN = Ztot
		'If L > 0 And LHA <= 180 Then ZN = 360 - Ztot
		'If L <= 0 And LHA > 180 Then ZN = 180 - Ztot
		'If L <= 0 And LHA <= 180 Then ZN = 180 + Ztot
		If cboL.Text = "N " And LHA > 180 Then ZN = Ztot
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Ztot
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Ztot
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Ztot
		
		ZN = Int(ZN + 0.5) 'added in V4.0.0
		
	End Sub
	
	Public Sub Display229()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame211.Visible = False
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		chkDSD.Enabled = True : If DSDcorr > 0.25 Then chkDSD.Enabled = False
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "Pub 229")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Calc. of Asm Lo and LHA", TAB(83), "Asm L ", TAB(92 - Len(Str(AsmL))), VB6.Format(System.Math.Abs(AsmL), "#0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL = 0 Then
			Print(" ")
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(cboL.Text)
		End If
		
		'LengthZtotDisplay = Len(Str$(Abs(ZtotDisplay)))
		'If Abs(ZtotDisplay) - Int(Abs(ZtotDisplay)) = 0 Then LengthZtotDisplay = LengthZtotDisplay + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tot GHA", TAB(18 - Len(Str(Val(txtGHADeg.Text)))), VB6.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & VB6.Format(Val(txtGHAMin.Text), "00.0") & "'", TAB(83), "DEC and LAT ")
		'Spc(11); "Tab Z "; cboL.text; Tab(88 - Len(Str$(Z))); Format(Abs(Z), "0"); Chr$(176);
		'If LHA <= 180 Then Print " W"
		'If LHA > 180 Then Print " E"
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm Lo (")
		'If cboLo.text = "W " Then SignA3$ = "W": Print "-";
		'If cboLo.text = "E " Then SignA3$ = "E": Print "+";
		If AsmLo = 0 Then
			SignA3 = " "
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		If System.Math.Sign(AsmLo) = 1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-")
			SignA3 = "W"
		End If
		If System.Math.Sign(AsmLo) = -1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+")
			SignA3 = "E"
		End If
		If System.Math.Sign(AsmLo) = 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
			SignA3 = " "
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(18 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00.0") & "'" & SignA3)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Dec", TAB(37 - Len(Str(DecDegrees))), VB6.Format(DecDegrees, "#0") & Chr(176) & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(48), "Dec Incr " & VB6.Format(DecIncr, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboL.Text = cboDec.Text Then Print(TAB(84), "SAME NAME")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboL.Text <> cboDec.Text Then Print(TAB(82), "CONTRARY NAME")
		
		i = 89 : If TabZ < 100 Then i = 90 : If TabZ < 10 Then i = 91
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("LHA", TAB(18 - Len(Str(AsmLHA))), VB6.Format(AsmLHA, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "d (" & SignD & ") " & VB6.Format(System.Math.Abs(D), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DSDcorrFlag = False Then Print(TAB(45), "DSD " & VB6.Format(System.Math.Abs(DSD), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkDSD.CheckState = 0 And DSDcorrFlag = True Then Print(TAB(45), "DSD " & "    '")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(62), "Z diff (" & SignZdiff & ") " & VB6.Format(System.Math.Abs(Zdiff), "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(83), "Tab Z ", TAB(i), VB6.Format(TabZ, "0.0") & Chr(176))
		'"Hc "; Tab(42 - Len(Str$(TotHcDeg))); Format(TotHcDeg, "0"); Chr$(176); Format(TotHcMin, "00"); "'"
		
		
		'i = 18: If Sgn(Hc) = -1 Then i = 17
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tab Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Hc) = -1 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(System.Math.Abs(TabHcDeg)))), VB6.Format(System.Math.Abs(TabHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TabHcMin), "00.0") & "'")
		i = 53 : If d1corr < 10 Then i = 54
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(40), "d1 corr. (" & SignD & ") ", TAB(i), VB6.Format(System.Math.Abs(d1corr), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(80), "Z corr (" & SignZdiff & ") " & VB6.Format(System.Math.Abs(Zcorr), "0.0") & Chr(176))
		
		i = 18 : If System.Math.Abs(Totcorr) < 10 Then i = 19
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tot corr", TAB(13), " (" & SignTotcorr & ") ", TAB(i), VB6.Format(System.Math.Abs(Totcorr), "0.0") & "'")
		i = 53 : If d2corr < 10 Then i = 54
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(40), "d2 corr. (" & SignD & ") ", TAB(i), VB6.Format(System.Math.Abs(d2corr), "0.0") & "'")
		
		'i = 18: If Sgn(TotHc) = -1 Then i = 17
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(TotHc) = -1 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(System.Math.Abs(TotHcDeg)))), VB6.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TotHcMin), "00.0") & "'")
		i = 53 : If DSDcorr < 10 Then i = 54
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If DSDcorrFlag = False Then Print(TAB(40), "DSD corr (+) ", TAB(i), VB6.Format(System.Math.Abs(DSDcorr), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If chkDSD.CheckState = 0 And DSDcorrFlag = True Then Print(TAB(40), "DSD corr (+) ", TAB(i), "   '")
		i = 89 : If Ztot < 100 Then i = 90 : If Ztot < 10 Then i = 91
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Z " & cboL.Text, TAB(i), VB6.Format(System.Math.Abs(Ztot), "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		
		i = 53 : If System.Math.Abs(Totcorr) < 10 Then i = 54
		'HoMin = Int(HoMin + 0.5)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoinMinutes < 0 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(40), "Tot corr (" & SignTotcorr & ") ", TAB(i), VB6.Format(System.Math.Abs(Totcorr), "0.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(13), "a ", TAB(21 - Len(Str(Int(System.Math.Abs(A))))), VB6.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A < 0 Then Print("T  Observed greater - Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A > 0 Then Print("A  Computed greater - Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Zn    " & VB6.Format(ZN, "000") & Chr(176))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "AP/EP L " & VB6.Format(APEstLDeg, "0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist < 0 Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist > 0 Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		
	End Sub
	Public Sub HO211()
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		frame211.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Flag = False 'Part of avoiding divide-by-zero errors
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		If LHA <= 180 Then T = LHA 'W
		If LHA > 180 Then T = 360 - LHA 'E
		tDeg = Int(T)
		tMin = (T - tDeg) * 60
		If optCompact.Checked = True Then tMin = Int(tMin + 0.50000001)
		If optOriginal.Checked = True Then tMin = Int(2 * tMin + 0.5) / 2
		If tMin = 60 Then tMin = 0 : tDeg = tDeg + 1
		tDecimal = tDeg + tMin / 60 ': If tDecimal = 0 Then tDecimal = 0.00000001
		If optCompact.Checked = True And tDecimal = 0 Then MsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.") : Flag = True : Exit Sub
		If optOriginal.Checked = True And tDecimal = 0 Then MsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.") : Flag = True : Exit Sub
		A1 = Csc211(tDecimal)
		If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then A1 = Int(10 * A1 + 0.5) / 10 Else A1 = Int(A1 + 0.5)
		If optCompact.Checked = True Then DecMinutes = Int(Val(txtDecMin.Text) + 0.5)
		If optOriginal.Checked = True Then DecMinutes = Int(2 * Val(txtDecMin.Text) + 0.5) / 2
		DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60
		'If DecDecimal = 0 Then MsgBox "For H.O. 211, Dec cannot be zero.": Flag = True: Exit Sub
		If optCompact.Checked = True And DecDecimal = 0 Then MsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.") : Flag = True : Exit Sub
		If optOriginal.Checked = True And DecDecimal = 0 Then MsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.") : Flag = True : Exit Sub
		frame211.Visible = True
		B1 = Sec211(DecDecimal)
		If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then B1 = Int(10 * B1 + 0.5) / 10 Else B1 = Int(B1 + 0.5)
		A2 = Csc211(DecDecimal)
		If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then A2 = Int(10 * A2 + 0.5) / 10 Else A2 = Int(A2 + 0.5)
		A3 = A1 + B1
		A3 = Int(A3 * 10 + 0.5) / 10 'is this line necessary?
		A4 = A3
		A3Angle = 1 / (10 ^ (A3 / 100000))
		A3Angle = System.Math.Atan(A3Angle / System.Math.Sqrt(-A3Angle * A3Angle + 1) + 9.999999E-21) 'arcsin
		A3Angle = A3Angle * 180 / Pi
		A3AngleDeg = Int(A3Angle)
		A3AngleMin = (A3Angle - A3AngleDeg) * 60
		If optCompact.Checked = True Then A3AngleMin = Int(A3AngleMin + 0.5)
		If optOriginal.Checked = True Then A3AngleMin = Int(2 * A3AngleMin + 0.5) / 2
		A3AngleDecimal = A3AngleDeg + A3AngleMin / 60
		B2 = Sec211(A3AngleDecimal)
		If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then B2 = Int(10 * B2 + 0.5) / 10 Else B2 = Int(B2 + 0.5)
		B3 = B2
		A5 = A2 - B2
		A5 = Int(A5 * 10 + 0.5) / 10 'is this line necessary?
		k = 1 / (10 ^ (A5 / 100000))
		If k = 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin
		k = k * 180 / Pi
		
		If k >= 82 And k <= 98 Then
			B2 = Sec211(A3Angle)
			B2 = Int(1000 * B2 + 0.5) / 1000
			B3 = B2
			A5 = A2 - B2
			'A5 = CscS(DecDecimal) - SecS(A3Angle)
			'A5 = Int(1000 * A5 + 0.5) / 1000
			k = 1 / (10 ^ (A5 / 100000))
			If k = 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin
			k = k * 180 / Pi
			A5 = Int(1000 * A5 + 0.5) / 1000
		End If
		
		If tDecimal > 90 Then k = 180 - k '????????????90-K or 180-K????????
		KDeg = Int(k)
		KMin = (k - KDeg) * 60
		If optCompact.Checked = True Then KMin = Int(KMin + 0.5)
		If optOriginal.Checked = True Then KMin = Int(2 * KMin + 0.5) / 2
		If optCompact.Checked = True Then L = Val(txtLDeg.Text) + Int(Val(txtLMin.Text) + 0.5) / 60
		If optOriginal.Checked = True Then L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
		If cboDec.Text = cboL.Text Then KL = System.Math.Abs(L - KDeg - KMin / 60)
		If cboDec.Text <> cboL.Text Then KL = System.Math.Abs(L + KDeg + KMin / 60)
		'If KL > 90 Then KL = KL + 180
		KLDeg = Int(KL)
		KLMin = (KL - KLDeg) * 60
		If KLDeg > 90 Then KLDeg = KLDeg + 180
		If optCompact.Checked = True Then KLMin = Int(KLMin + 0.5)
		If optOriginal.Checked = True Then KLMin = Int(2 * KLMin + 0.5) / 2
		If KLMin >= 60 Then KLMin = KLMin - 60 : KLDeg = KLDeg + 1
		'If Cos((KLDeg + KLMin / 60) * Pi / 180) < 0 Then MsgBox "H.O. 211 does not allow values that would result in a negative Hc.": Flag = True: Exit Sub
		B4 = Sec211(KLDeg + KLMin / 60)
		If KLDeg > 270 Then KLDeg = KLDeg - 180
		If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then B4 = Int(10 * B4 + 0.5) / 10 Else B4 = Int(B4 + 0.5)
		A6 = B3 + B4
		A6 = Int(A6 * 10 + 0.5) / 10 'is this line necessary?
		HcAngle = 1 / (10 ^ (A6 / 100000))
		If HcAngle = 1 Then HcAngle = Pi / 2 Else HcAngle = System.Math.Atan(HcAngle / System.Math.Sqrt(-HcAngle * HcAngle + 1) + 9.999999E-21) 'arcsin
		HcAngle = HcAngle * 180 / Pi : Htot = HcAngle
		HcDeg = Int(HcAngle)
		HcMin = (HcAngle - HcDeg) * 60
		If optCompact.Checked = True Then HcMin = Int(HcMin + 0.5)
		If optOriginal.Checked = True Then HcMin = Int(2 * HcMin + 0.5) / 2
		If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
		HcDecimal = HcDeg + HcMin / 60
		If KL > 90 Then HcDecimal = -HcDecimal
		B5 = Sec211(HcDecimal)
		If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then B5 = Int(10 * B5 + 0.5) / 10 Else B5 = Int(B5 + 0.5)
		Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
		'HoDeg = Int(Ho)
		'HoMin = (Ho - HoDeg) * 60
		HoDeg = Val(txtHoDeg.Text)
		HoMin = Val(txtHoMin.Text)
		If optCompact.Checked = True Then HoMin = Int(HoMin + 0.5)
		If optOriginal.Checked = True Then HoMin = Int(HoMin * 10 + 0.5) / 10
		A = System.Math.Sign(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
		A7 = A4 - B5
		If A7 <= 0 Then A7 = 0 : Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
		If A7 <> 0 Then
			Z = 1 / (10 ^ (A7 / 100000))
			Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
			Z = Z * 180 / Pi
		End If
		A7 = Int(A7 * 10 + 0.5) / 10 'this line was necessary for low value of A7
		If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
		ZDeg = Int(Z)
		ZMin = (Z - ZDeg) * 60
		'If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
		If optCompact.Checked = True Then ZMin = Int(ZMin + 0.5)
		If optOriginal.Checked = True Then ZMin = Int(2 * ZMin + 0.5) / 2
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		
		If cboL.Text = "S " Then L = -L
		
	End Sub
	Public Sub HO208()
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'    frame211.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Flag = False : Flag0 = False
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 0 Or AsmLHA = 360 Or AsmLHA = 180 Then MsgBox("For H.O. 208, LHA (GHA - LoW, GHA + LoE) to nearest whole degree cannot be 0º or 180º.") : Flag0 = True : Exit Sub
		If LHA <= 180 Then T = AsmLHA 'W
		If LHA > 180 Then T = 360 - AsmLHA 'E
		'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
		If AsmLoMin = 60 Then AsmLoMin = 0
		'AsmL = Int(Abs(L) + 0.5)
		AsmL = Int(L + 0.5)
		
		DecDecimal = System.Math.Abs(Val(txtDecDeg.Text) + DecMinutes / 60)
		'If cboDec.text = "S " Then DecDecimal = -DecDecimal
		
		'If AsmL = 0 Or T = 0 Then B1 = 90 Else
		'If T = 0 Then T = 0.0000000001
		If AsmL = 0 Then AsmL = 0.0000000001
		B1 = (1 / System.Math.Tan(AsmL * Pi / 180)) * System.Math.Cos(T * Pi / 180) : B1 = System.Math.Atan(B1) * 180 / Pi 'B1 is b
		B1Deg = Int(System.Math.Abs(B1))
		B1Min = (System.Math.Abs(B1) - B1Deg) * 60
		B1Min = Int(B1Min * 10 + 0.5) / 10
		If B1Min = 60 Then B1Min = 0 : B1Deg = B1Deg + 1
		B1 = System.Math.Abs(B1Deg + B1Min / 60)
		'If T < 90 And Sgn(L) < 0 Then B1 = -B1
		If T <= 90 Then SignB = cboL.Text
		If T > 90 Then
			'B1 = -B1
			If cboL.Text = "N " Then SignB = "S"
			If cboL.Text = "S " Then SignB = "N"
		End If
		If System.Math.Abs(AsmL) <= 0.5 Then SignB = cboDec.Text 'For L=0, b gets same name as Dec
		
		A1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(T * Pi / 180)
		A1 = System.Math.Atan(A1 / System.Math.Sqrt(-A1 * A1 + 1)) 'arcsin        A1 is a
		If A1 = 0 Then A1 = 0.0000000001 * Pi / 180
		A2 = 100000 * (System.Math.Log(1 / System.Math.Cos(A1)) / System.Math.Log(10))
		A2 = Int(A2 + 0.5) 'A2 is A
		A4 = 1000 * System.Math.Abs(System.Math.Log(1 / (System.Math.Sin(A1))) / System.Math.Log(10))
		A4 = Int(A4 + 0.5) 'A4 is C
		If AsmL = 0 Or T = 0 Then Z1 = 0 Else Z1 = System.Math.Sin(AsmL * Pi / 180) * System.Math.Tan(T * Pi / 180) : Z1 = System.Math.Atan(1 / Z1) * 180 / Pi
		Z1 = Int(System.Math.Abs(Z1) * 10 + 0.5) / 10 'Z1 is Z'
		SignZ1 = SignB
		
		If cboDec.Text = SignB Then A3 = System.Math.Abs(DecDecimal + B1) Else A3 = System.Math.Abs(DecDecimal - B1) 'A3 is d + b
		If System.Math.Abs(DecDecimal) >= System.Math.Abs(B1) Then SignA3 = cboDec.Text
		If System.Math.Abs(DecDecimal) < System.Math.Abs(B1) Then SignA3 = SignB
		A3Deg = Int(A3)
		A3Min = (A3 - Int(A3)) * 60
		A3Min = Int(A3Min * 10 + 0.5) / 10
		If A3Min = 60 Then A3Min = 0 : A3Deg = A3Deg + 1
		A3 = A3Deg + A3Min / 60
		
		'If A3 > 90 Then A3 = 180 - A3: Flag = True
		
		B2 = 100000 * (System.Math.Log(1 / System.Math.Sin(A3 * Pi / 180)) / System.Math.Log(10))
		B2 = Int(B2 + 0.5) 'B2 is B
		
		If cboDec.Text <> cboL.Text Then DecDecimal = -DecDecimal
		
		A5 = A2 + B2 'A + B
		Hc = System.Math.Cos(A1) * System.Math.Sin(A3 * Pi / 180)
		If Hc = 1 Then Hc = Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1) + 9.999999E-21) 'arcsin
		Hc = Hc * 180 / Pi ': Htot = Hc
		HcDeg = Int(Hc)
		HcMin = (Hc - HcDeg) * 60
		HcMin = Int(HcMin * 10 + 0.5) / 10
		If HcMin = 60 Then HcMin = 0 : HcDeg = HcDeg + 1
		Hc = HcDeg + HcMin / 60
		'If (DecDecimal + B1) < 0 Then Hc = -Hc
		If SignA3 <> cboL.Text Then Hc = -Hc
		Htot = Hc
		
		'B3 = 1 / Tan(A3 * Pi / 180)
		B3 = System.Math.Abs(1 / System.Math.Tan(A3 * Pi / 180))
		B3 = 1000 * (System.Math.Log(B3) / System.Math.Log(10)) 'B3 is D
		B3 = Int(B3 + 0.5)
		If A3 = 90 Then B3 = 0
		If B3 < 0 Then B3 = 10000 + B3 'WHY?
		'B3 = Int(B3 + 0.5)
		
		A6 = A4 + B3 'A6 is C + D
		If A6 > 10000 Then A6 = A6 - 10000
		Z2 = (1 / (System.Math.Sin(A1))) * (1 / System.Math.Tan(A3 * Pi / 180))
		Z2 = System.Math.Abs(System.Math.Atan(Z2))
		Z2 = Z2 * 180 / Pi
		Z2 = Int(Z2 * 10 + 0.5) / 10
		'If cboDec.text <> cboL.text Then DecDecimal = -DecDecimal
		If (DecDecimal + B1) < 0 Then Z2 = 180 - Z2
		SignZ2 = SignA3
		
		
		
		'If Flag = True Then Z2 = -Z2
		'If A3 > 90 Then Z2 = -Z2
		If A3 > 90 Then
			If SignA3 = "N " Then SignZ2 = "S"
			If SignA3 = "S " Then SignZ2 = "N"
		End If
		
		'Z = Z1 + Z2
		If SignZ1 = SignZ2 Then Z = System.Math.Abs(Z1 + Z2) Else Z = System.Math.Abs(Z1 - Z2)
		If System.Math.Abs(AsmL) <= 0.5 Then cboL.Text = cboDec.Text 'For L=0, L gets same name as Dec
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		
		A = System.Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
		
	End Sub
	
	Public Sub Display211()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = True
		Line7.Visible = True
		Line8.Visible = True
		Line9.Visible = True
		Line10.Visible = True
		Line11.Visible = True
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		'frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(24), "INTERCEPT and AZIMUTH by AGETON'S METHOD (H.O. 211)")
		'Print
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("t*", TAB(13 - Len(Str(tDeg))), VB6.Format(tDeg, "0") & Chr(176) & VB6.Format(tMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("t*", TAB(13 - Len(Str(tDeg))), VB6.Format(tDeg, "0") & Chr(176) & VB6.Format(tMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print("E")
		i = Len(Str(A1)) : If (A1 - Int(A1)) = 0 Then i = i + 2
		If A1 < 1 And A1 > 0 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A1, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A1, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("Dec*", TAB(13 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("Dec*", TAB(13 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
		i = Len(Str(B1)) : If (B1 - Int(B1)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then
			Print(TAB(25), "B+", TAB(37 - i), VB6.Format(B1, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "B+", TAB(37 - i), VB6.Format(B1, "0"))
		End If
		i = Len(Str(A2)) : If (A2 - Int(A2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then
			Print(TAB(45), "A", TAB(57 - i), VB6.Format(A2, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "A", TAB(57 - i), VB6.Format(A2, "0"))
		End If
		
		i = Len(Str(A3)) : If (A3 - Int(A3)) = 0 Then i = i + 2 '7
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A3 - Int(A3) <> 0 Then Print(TAB(25), "A", TAB(37 - i), VB6.Format(A3, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A3 - Int(A3) = 0 Then Print(TAB(25), "A", TAB(37 - i), VB6.Format(A3, "0"))
		i = Len(Str(B2)) : If (B2 - Int(B2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
			Print(TAB(45), "B-", TAB(57 - i), VB6.Format(B2, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "B-", TAB(57 - i), VB6.Format(B2, "0"))
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If k >= 82 And k <= 98 Then Print("**")
		i = Len(Str(B3)) : If (B3 - Int(B3)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then
			Print(TAB(65), "B", TAB(77 - i), VB6.Format(B3, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(65), "B", TAB(77 - i), VB6.Format(B3, "0"))
		End If
		i = Len(Str(A4)) : If (A4 - Int(A4)) = 0 Then i = i + 2
		'If (optCompact = True And A4 < 166) Or (optOriginal = True And A4 < 239) Then Print Tab(85); "A"; Tab(97 - i); Format(A4, "0.0") Else _
		'Print Tab(85); "A"; Tab(97 - i); Format(A4, "0")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A4 - Int(A4) <> 0 Then Print(TAB(85), "A", TAB(97 - i), VB6.Format(A4, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A4 - Int(A4) = 0 Then Print(TAB(85), "A", TAB(97 - i), VB6.Format(A4, "0"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("K", TAB(13 - Len(Str(KDeg))), VB6.Format(KDeg, "0") & Chr(176) & VB6.Format(KMin, "00") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("K", TAB(13 - Len(Str(KDeg))), VB6.Format(KDeg, "0") & Chr(176) & VB6.Format(KMin, "00.0") & "'" & cboDec.Text)
		'If k >= 82 And k <= 98 Then Print "**";
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  <- <- <- <- <- <- <-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(" <- ")
		i = Len(Str(A5)) : If (A5 - Int(A5)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A5 - Int(A5) <> 0 Then Print(TAB(45), "A", TAB(57 - i), VB6.Format(A5, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A5 - Int(A5) = 0 Then Print(TAB(45), "A", TAB(57 - i), VB6.Format(A5, "0"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("DR L", TAB(13 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("DR L", TAB(13 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("K ~ L", TAB(13 - Len(Str(KLDeg))), VB6.Format(KLDeg, "0") & Chr(176) & VB6.Format(KLMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("K ~ L", TAB(13 - Len(Str(KLDeg))), VB6.Format(KLDeg, "0") & Chr(176) & VB6.Format(KLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  -> -> -> -> -> -> -> -> -> -> -> -> -> ->")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(" -> ")
		i = Len(Str(B4)) : If (B4 - Int(B4)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then
			Print(TAB(65), "B+", TAB(77 - i), VB6.Format(B4, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(65), "B+", TAB(77 - i), VB6.Format(B4, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KL > 90 Then Print(TAB(12 - Len(Str(HcDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(13 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(13 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  <- <- <- <- <- <- <- <- <- <- <- <- <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("<- ")
		i = Len(Str(A6)) : If (A6 - Int(A6)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A6 - Int(A6) <> 0 Then Print(TAB(65), "A", TAB(77 - i), VB6.Format(A6, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A6 - Int(A6) = 0 Then Print(TAB(65), "A", TAB(77 - i), VB6.Format(A6, "0"))
		i = Len(Str(B5)) : If (B5 - Int(B5)) = 0 Then i = i + 2
		If optOriginal.Checked = True And B5 < 1 Then i = 4
		'If (optCompact = True And B5 < 166) Or (optOriginal = True And B5 < 239) Then Print Tab(85); "B-"; Tab(97 - Len(Str$(B5))); Format(B5, "0.0") Else _
		'Print Tab(85); "B-"; Tab(95 - Len(Str$(B5))); Format(B5, "0")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then
			Print(TAB(85), "B-", TAB(97 - i), VB6.Format(B5, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(85), "B-", TAB(97 - i), VB6.Format(B5, "0"))
		End If
		
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoMin < 0 Then Print(TAB(10), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(13 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(13 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		'If KL > 90 Then HcDecimal = -HcDecimal
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho > HcDecimal Then Print("    Observed greater - Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho < HcDecimal Then Print("    Computed greater - Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho = HcDecimal Then Print()
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("a", TAB(16 - Len(Str(Int(System.Math.Abs(A))))))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(VB6.Format(Int(System.Math.Abs(A) + 0.5), "0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(VB6.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal < Ho Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal > Ho Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HcDecimal = Ho Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "Zn", TAB(33), VB6.Format(ZN, "000") & Chr(176) & " <- <- <- <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(53), "Z " & cboL.Text, SPC(1), VB6.Format(ZDeg, "0") & Chr(176) & VB6.Format(ZMin, "00") & "'") 'Format(Z, "0"); Chr$(176); for whole degrees
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(53), "Z " & cboL.Text, SPC(1), VB6.Format(ZDeg, "0") & Chr(176) & VB6.Format(ZMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W" & " <- <- <- <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E" & " <- <- <- <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("<-")
		i = Len(Str(A7)) : If (A7 - Int(A7)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A7 - Int(A7) <> 0 Then Print(TAB(85), "A", TAB(97 - i), VB6.Format(A7, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A7 - Int(A7) = 0 Then Print(TAB(85), "A", TAB(97 - i), VB6.Format(A7, "0"))
		
		'Print ': Print
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("*Table entry values")
		If k >= 82 And k <= 98 Then
			'Print Tab(23); "**An error of several miles can occur if K is between 82 and 98 degrees."
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(23), "**If K is between 82" & Chr(176) & " and 98" & Chr(176) & " this B is interpolated.")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "USPS rule:  Discard the sight if K is between 82" & Chr(176) & " and 98" & Chr(176))
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(36), " or use Sadler Technique.")
			chkSadler.Visible = True
		End If
	End Sub
	
	Public Sub Display208()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False 'True
		Line7.Visible = False 'True
		Line8.Visible = False 'True
		Line9.Visible = True
		Line10.Visible = True
		Line11.Visible = True
		Line12.Visible = True
		Line13.Visible = True
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame211.Visible = False
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "H.O. 208")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("GHA", TAB(16 - Len(Str(Val(txtGHADeg.Text)))), VB6.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & VB6.Format(Val(txtGHAMin.Text), "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm Lo (")
		'If cboLo.text = "W " Then SignF$ = "W": Print "-";
		'If cboLo.text = "E " Then SignF$ = "E": Print "+";
		If AsmLo = 0 Then
			SignF = " "
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("")
		End If
		If System.Math.Sign(AsmLo) = 1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("-")
			SignF = "W"
		End If
		If System.Math.Sign(AsmLo) = -1 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("+")
			SignF = "E"
		End If
		If System.Math.Sign(AsmLo) = 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(" ")
			SignF = " "
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(")", TAB(16 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00.0") & "'" & SignF)
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm LHA", TAB(16 - Len(Str(AsmLHA))), VB6.Format(AsmLHA, "0") & Chr(176))
		
		T = Int(T)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("t", TAB(16 - Len(Str(T))), VB6.Format(T, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print("E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "d", TAB(31 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
		
		AsmL = Int(AsmL)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Asm L ", TAB(16 - Len(Str(AsmL))), VB6.Format(System.Math.Abs(AsmL), "#0") & Chr(176) & cboL.Text)
		i = Len(Str(B1Deg)) ': If B1 = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "b", TAB(31 - i), VB6.Format(B1Deg, "0") & Chr(176) & VB6.Format(B1Min, "00.0") & "'" & SignB)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   ->")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "A", TAB(55 - Len(Str(A2))), VB6.Format(A2, "0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(65), "C", TAB(75 - Len(Str(A4))), VB6.Format(A4, "0"))
		i = Len(Str(Z1)) : If (Z1 - Int(Z1)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Z'", TAB(95 - i), VB6.Format(System.Math.Abs(Z1), "0.0") & Chr(176), SPC(1), SignZ1)
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(23), "d+b", TAB(31 - Len(Str(A3Deg))), VB6.Format(A3Deg, "0") & Chr(176) & VB6.Format(A3Min, "00.0") & "'" & SignA3)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   ->")
		i = Len(Str(B2)) : If (B2 - Int(B2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "B", TAB(57 - i), VB6.Format(B2, "0"))
		i = Len(Str(B3)) : If (B3 - Int(B3)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(65), "D", TAB(77 - i), VB6.Format(B3, "0"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Hc < 0 Then Print(TAB(12 - Len(Str(HcDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(13 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "<-")
		i = Len(Str(A5)) : If (A5 - Int(A5)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(43), "A+B", TAB(57 - i), VB6.Format(A5, "0"))
		i = Len(Str(A6)) : If (A6 - Int(A6)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(63), "C+D", TAB(77 - i), VB6.Format(A6, "0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(78), "->")
		i = Len(Str(Z2)) : If (Z2 - Int(Z2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Z""", TAB(95 - i), VB6.Format(System.Math.Abs(Z2), "0.0") & Chr(176))
		'If Flag = True And cboL.text = "S " Then Print " N"
		'If Flag = True And cboL.text = "N " Then Print " S"
		'If Flag = False Then Print Spc(1); cboL.text
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(1), SignZ2)
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoinMinutes < 0 Then Print(TAB(12 - Len(Str(HoDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(13 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		i = Len(Str(Z)) : If (Z - Int(Z)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Z " & cboL.Text, TAB(95 - i), VB6.Format(Z, "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("a", TAB(16 - Len(Str(Int(System.Math.Abs(A))))), VB6.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Hc < Ho Then Print("T     Observed greater - Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Hc > Ho Then Print("A     Computed greater - Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Zn", TAB(91), VB6.Format(ZN, "000") & Chr(176))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "AP/EP L " & VB6.Format(APEstLDeg, "0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If APEstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist < 0 Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist > 0 Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KPLOPDist = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		
	End Sub
	
	Public Function Csc211(ByRef x As Object) As Single
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If x < 0 Or x > 180 Then x = 360 - x
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Csc211 = 100000 * (System.Math.Log(1 / System.Math.Sin(x * Pi / 180)) / System.Math.Log(10))
		If (optCompact.Checked = True And Csc211 < 166) Or (optOriginal.Checked = True And Csc211 < 239) Then Csc211 = Int(Csc211 * 10 + 0.5) / 10 Else Csc211 = Int(Csc211 + 0.5)
	End Function
	
	Public Function Sec211(ByRef x As Object) As Single
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If x >= 90 And x <= 270 Then x = x - 180
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sec211 = 100000 * (System.Math.Log(1 / System.Math.Cos(x * Pi / 180)) / System.Math.Log(10))
		If (optCompact.Checked = True And Sec211 < 166) Or (optOriginal.Checked = True And Sec211 < 239) Then Sec211 = Int(Sec211 * 10 + 0.5) / 10 Else Sec211 = Int(Sec211 + 0.5)
	End Function
	Public Function CscS(ByRef x As Object) As Single
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If x > 180 Or x < 0 Then x = 360 - x
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If optPepperday.Checked = True And x = 0 Then CscS = 999.999 : Exit Function
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If optFarley.Checked = True And x = 0 Then CscS = 1000 : Exit Function
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CscS = (System.Math.Log(1 / System.Math.Sin(x * Pi / 180)) / System.Math.Log(10))
		If optPepperday.Checked = True Then CscS = 94.2932531 * CscS
		If optFarley.Checked = True Then CscS = 100 * CscS
	End Function
	Public Function SecS(ByRef x As Object) As Single
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If x >= 90 And x <= 270 Then x = x - 180
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SecS = (System.Math.Log(1 / System.Math.Cos(x * Pi / 180)) / System.Math.Log(10))
		If optPepperday.Checked = True Then SecS = 94.2932531 * SecS
		If optFarley.Checked = True Then SecS = 100 * SecS
	End Function
	Public Sub Display214()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame211.Visible = False
		frame214.Visible = True : Label9.Visible = True
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(45), "H.O. 214")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optd.Checked = True Then Print("Calc. of Asm Lo and LHA")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdt.Checked = True Or optdtL.Checked = True Then Print("   Calc. of Asm LHA")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tot GHA", TAB(18 - Len(Str(Val(txtGHADeg.Text)))), VB6.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & VB6.Format(Val(txtGHAMin.Text), "00.0") & "'")
		
		If optd.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Asm Lo (")
			'If cboLo.text = "W " Then SignA3$ = "W": Print "-";
			'If cboLo.text = "E " Then SignA3$ = "E": Print "+";
			If AsmLo = 0 Then
				SignA3 = " "
				'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print("")
			End If
			If System.Math.Sign(AsmLo) = 1 Then
				'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print("-")
				SignA3 = "W"
			End If
			If System.Math.Sign(AsmLo) = -1 Then
				'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print("+")
				SignA3 = "E"
			End If
			If System.Math.Sign(AsmLo) = 0 Then
				'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Print(" ")
				SignA3 = " "
			End If
		End If
		If optdt.Checked = True Or optdtL.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("DR Lo  (")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboLo.Text = "W " Then Print("-")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboLo.Text = "E " Then Print("+")
			'If AsmLo = 0 Then Print " ":
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optd.Checked = True Then Print(")", TAB(18 - Len(Str(AsmLoDeg))), VB6.Format(AsmLoDeg, "0") & Chr(176) & VB6.Format(AsmLoMin, "00.0") & "'" & SignA3)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdt.Checked = True Or optdtL.Checked = True Then Print(")", TAB(18 - Len(Str(Val(txtLoDeg.Text)))), VB6.Format(Val(txtLoDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(83), "DEC and LAT ")
		
		If optd.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("H.A.", TAB(18 - Len(Str(T))), VB6.Format(T, "0") & Chr(176))
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LHA <= 180 Then Print("W")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If LHA > 180 Then Print("E")
		End If
		If optdt.Checked = True Or optdtL.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("LHA", TAB(18 - Len(Str(LHADeg))), VB6.Format(LHADeg, "#0") & Chr(176) & VB6.Format(LHAMin, "00.0") & "'->" & "H.A. " & VB6.Format(T, "0") & Chr(176))
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(38), "Dec", TAB(45 - Len(Str(AsmDecDeg))), VB6.Format(AsmDecDeg, "#0") & Chr(176) & VB6.Format(AsmDecMin, "00") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(63), "Asm L ", TAB(72 - Len(Str(AsmL))), VB6.Format(System.Math.Abs(AsmL), "#0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If AsmL <> 0 Then Print(cboL.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboL.Text = cboDec.Text Then Print(TAB(84), "SAME NAME")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboL.Text <> cboDec.Text Then Print(TAB(82), "CONTRARY NAME")
		
		'i = 18: If Sgn(Hc) = -1 Then i = 17
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tab Alt. ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(Hc) = -1 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(System.Math.Abs(TabHcDeg)))), VB6.Format(System.Math.Abs(TabHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TabHcMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(34), "Dec diff " & VB6.Format(System.Math.Abs(DecIncr), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(51))
		Font = VB6.FontChangeName(Font, "Symbol")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("D") 'this prints a Greek capital delta
		Font = VB6.FontChangeName(Font, "Courier New")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("d " & VB6.Format(System.Math.Abs(D * 100), "00"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(60))
		Font = VB6.FontChangeName(Font, "Symbol")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("D") 'this prints a Greek capital delta
		Font = VB6.FontChangeName(Font, "Courier New")
		i = 73 : If System.Math.Abs(d1corr) < 10 Then i = 74 'd1corr is delta d corr
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("d corr.", TAB(69), "(" & SignD & ") ", TAB(i), VB6.Format(System.Math.Abs(d1corr), "0.0") & "'")
		i = 89 : If TabZ < 100 Then i = 90 : If TabZ < 10 Then i = 91#
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(81), "Tab Az. ", TAB(i), VB6.Format(TabZ, "0.0") & Chr(176))
		
		
		i = 18 : If System.Math.Abs(Totcorr) < 10 Then i = 19 'd2corr is delta t corr
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Tot corr", TAB(13), " (" & SignTotcorr & ") ", TAB(i), VB6.Format(System.Math.Abs(Totcorr), "0.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdt.Checked = True Or optdtL.Checked = True Then Print(TAB(34), "LHA diff " & VB6.Format(LHAdiff, "00.0") & "'")
		If optdt.Checked = True Or optdtL.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(51))
			Font = VB6.FontChangeName(Font, "Symbol")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("D") 'this prints a Greek capital delta
			Font = VB6.FontChangeName(Font, "Courier New")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("t " & VB6.Format(System.Math.Abs(DSD2 * 100), "00"))
		End If
		If optdt.Checked = True Or optdtL.Checked = True Then
			i = 73 : If System.Math.Abs(d2corr) < 10 Then i = 74
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(60))
			Font = VB6.FontChangeName(Font, "Symbol")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("D") 'this prints a Greek capital delta
			Font = VB6.FontChangeName(Font, "Courier New")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("t corr.", TAB(69), "(" & Signd2corr & ") ", TAB(i), VB6.Format(System.Math.Abs(d2corr), "0.0") & "'")
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optd.Checked = True Then Print()
		
		'If Zcorr = 0 Then i = 55
		i = 18 : If System.Math.Sign(TotHc) = -1 Then i = 17
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(TotHc) = -1 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(System.Math.Abs(TotHcDeg)))), VB6.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(TotHcMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdtL.Checked = True Then Print(TAB(34), "L diff   " & VB6.Format(Ldiff, "00.0") & "'")
		i = 73 : If System.Math.Abs(Zcorr) < 10 Then i = 74 'Zcorr is delta L corr
		If optdtL.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(60))
			Font = VB6.FontChangeName(Font, "Symbol")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("D") 'this prints a Greek capital delta
			Font = VB6.FontChangeName(Font, "Courier New")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("L corr.", TAB(69), "(" & SignL & ") ", TAB(i), VB6.Format(System.Math.Abs(Zcorr), "0.0") & "'")
		End If
		i = 89 : If Ztot < 100 Then i = 90 : If Ztot < 10 Then i = 91
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Z " & cboL.Text, TAB(i), VB6.Format(System.Math.Abs(Ztot), "0.0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E")
		
		i = 73 : If System.Math.Abs(Totcorr) < 10 Then i = 74
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Ho ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoinMinutes < 0 Then Print(TAB(14), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(60), "Tot corr", TAB(69), "(" & SignTotcorr & ") ", TAB(i), VB6.Format(System.Math.Abs(Totcorr), "0.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(13), "a ", TAB(21 - Len(Str(Int(System.Math.Abs(A))))), VB6.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A < 0 Then Print("T  Observed greater - Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A > 0 Then Print("A  Computed greater - Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(85), "Zn    " & VB6.Format(ZN, "000") & Chr(176))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optd.Checked = True Then Print(TAB(37), "Plot LOP from Asm L, Asm Lo")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdt.Checked = True Then Print(TAB(37), "Plot LOP from Asm L, DR Lo")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optdtL.Checked = True Then Print(TAB(37), "Plot LOP from DR L, DR Lo")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		If optdtL.Checked = False Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(SPC(34), "AP/EP L " & VB6.Format(APEstLDeg, "0") & Chr(176) & VB6.Format(APEstLMin, "00.0") & "'")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstL > 0 Then Print("N")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstL = 0 Then Print(" ")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstL < 0 Then Print("S")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("   AP/EP Lo " & VB6.Format(APEstLoDeg, "0") & Chr(176) & VB6.Format(APEstLoMin, "00.0") & "'")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstLo > 0 Then Print("W")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstLo = 0 Then Print(" ")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If APEstLo < 0 Then Print("E")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(SPC(34), "DR-LOP Distance " & VB6.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If KPLOPDist < 0 Then Print("T")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If KPLOPDist > 0 Then Print("A")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If KPLOPDist = 0 Then Print(" ")
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(SPC(34), "   EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
	End Sub
	
	Public Sub HO214()
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		If LHA <= 180 Then T = LHA 'W           'T is H.A.
		If LHA > 180 Then T = 360 - LHA 'E
		'tDeg = Int(T)
		'tMin = (T - tDeg) * 60
		'tMin = Int(tMin + 0.50000001)
		T = Int(T + 0.5)
		AsmLHA = Int(LHA + 0.5)
		If AsmLHA = 360 Then AsmLHA = 0
		GHAAsmDeg = Val(txtGHADeg.Text)
		GHAAsmMin = Val(txtGHAMin.Text)
		GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
		'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
		AsmLo = GHAAsm - AsmLHA
		'If AsmLo >= 360 Then AsmLo = AsmLo - 360
		If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
		If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
		'    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
		'    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
		AsmLoDeg = Int(System.Math.Abs(AsmLo))
		If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
		If AsmLoMin = 60 Then AsmLoMin = 0
		AsmL = Int(L + 0.5)
		AsmDec = Int(System.Math.Abs(Dec) * 2 + 0.5) / 2
		If System.Math.Abs(Dec) > 29.5 And System.Math.Abs(Dec) < 31 Then AsmDec = 30
		If System.Math.Abs(Dec) >= 31 And System.Math.Abs(Dec) < 33 Then AsmDec = 32
		If System.Math.Abs(Dec) >= 33 And System.Math.Abs(Dec) < 34.25 Then AsmDec = 34
		If System.Math.Abs(Dec) >= 34.25 And System.Math.Abs(Dec) < 35 Then AsmDec = 34.5
		If System.Math.Abs(Dec) >= 35 And System.Math.Abs(Dec) < 35.75 Then AsmDec = 35.5
		If System.Math.Abs(Dec) >= 35.5 And System.Math.Abs(Dec) < 36.5 Then AsmDec = 36
		If System.Math.Abs(Dec) >= 36 And System.Math.Abs(Dec) < 37.75 Then AsmDec = 37
		If System.Math.Abs(Dec) >= 37.75 And System.Math.Abs(Dec) < 39.25 Then AsmDec = 38.5
		If System.Math.Abs(Dec) >= 39.25 And System.Math.Abs(Dec) < 41 Then AsmDec = 40
		If System.Math.Abs(Dec) >= 41 And System.Math.Abs(Dec) < 42.25 Then AsmDec = 42
		If System.Math.Abs(Dec) >= 42.25 And System.Math.Abs(Dec) < 44 Then AsmDec = 43
		If System.Math.Abs(Dec) >= 44 And System.Math.Abs(Dec) < 45.5 Then AsmDec = 45
		If System.Math.Abs(Dec) >= 45.5 And System.Math.Abs(Dec) < 46.5 Then AsmDec = 46
		If System.Math.Abs(Dec) >= 46.5 And System.Math.Abs(Dec) < 47.75 Then AsmDec = 47
		If System.Math.Abs(Dec) >= 47.75 And System.Math.Abs(Dec) < 49 Then AsmDec = 48.5
		If System.Math.Abs(Dec) >= 49 And System.Math.Abs(Dec) < 50 Then AsmDec = 49.5
		If System.Math.Abs(Dec) >= 50 And System.Math.Abs(Dec) < 51 Then AsmDec = 50.5
		If System.Math.Abs(Dec) >= 51 And System.Math.Abs(Dec) < 52 Then AsmDec = 51.5
		If System.Math.Abs(Dec) >= 52 And System.Math.Abs(Dec) < 53.25 Then AsmDec = 52.5
		If System.Math.Abs(Dec) >= 53.25 And System.Math.Abs(Dec) < 54.25 Then AsmDec = 54
		If System.Math.Abs(Dec) >= 54.25 And System.Math.Abs(Dec) < 54.75 Then AsmDec = 54.5
		If System.Math.Abs(Dec) >= 54.75 And System.Math.Abs(Dec) < 55.5 Then AsmDec = 55
		If System.Math.Abs(Dec) >= 55.5 And System.Math.Abs(Dec) < 56.25 Then AsmDec = 56
		If System.Math.Abs(Dec) >= 56.25 And System.Math.Abs(Dec) < 56.75 Then AsmDec = 56.5
		If System.Math.Abs(Dec) >= 56.75 And System.Math.Abs(Dec) < 57.25 Then AsmDec = 57
		If System.Math.Abs(Dec) >= 57.25 And System.Math.Abs(Dec) < 58.25 Then AsmDec = 57.5
		If System.Math.Abs(Dec) >= 58.25 And System.Math.Abs(Dec) < 59.25 Then AsmDec = 59
		If System.Math.Abs(Dec) >= 59.25 And System.Math.Abs(Dec) < 59.75 Then AsmDec = 59.5
		If System.Math.Abs(Dec) >= 59.75 And System.Math.Abs(Dec) < 60.25 Then AsmDec = 60
		If System.Math.Abs(Dec) >= 60.25 And System.Math.Abs(Dec) < 61.25 Then AsmDec = 60.5
		If System.Math.Abs(Dec) >= 61.25 And System.Math.Abs(Dec) < 62.25 Then AsmDec = 62
		If System.Math.Abs(Dec) >= 62.25 And System.Math.Abs(Dec) < 62.75 Then AsmDec = 62.5
		If System.Math.Abs(Dec) >= 62.75 And System.Math.Abs(Dec) < 66 Then AsmDec = 63
		If System.Math.Abs(Dec) >= 66 And System.Math.Abs(Dec) < 69.25 Then AsmDec = 69
		If System.Math.Abs(Dec) >= 69.25 And System.Math.Abs(Dec) < 72 Then AsmDec = 69.5
		If System.Math.Abs(Dec) >= 72 Then AsmDec = 74.5
		
		AsmDecDeg = Int(AsmDec)
		AsmDecMin = (AsmDec - AsmDecDeg) * 60
		DecIncr = (System.Math.Abs(Dec) - AsmDec) * 60 'this is really Dec diff for HO214
		DecIncr = Int(DecIncr * 10 + 0.5) / 10
		LHAdiff = System.Math.Abs((LHA - AsmLHA) * 60)
		Ldiff = System.Math.Abs((L - AsmL) * 60)
		Ldiff = Int(Ldiff * 10 + 0.5) / 10
		
		If (cboDec.Text = "S " And cboL.Text = "N ") Or (cboDec.Text = "N " And cboL.Text = "S ") Then AsmDec = -AsmDec : DE = -DE ': SignDE$ = "-" 'sign of Dec was already set in DecimalDegrees
		
		'Hc is altitude for Asm L, Asm Dec, Asm LHA
		Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
		If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
		Hc = Hc * 180 / Pi
		TabHcDeg = Fix(Hc) 'was Int
		TabHcMin = Hc - TabHcDeg
		TabHcMin = Int((60 * TabHcMin) * 10 + 0.5) / 10
		
		'The next group is for determining delta d
		
		i = 1 : If AsmDec < 0 Then i = -1
		NextHcdP = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i / 60) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i / 60) * Pi / 180)
		If System.Math.Abs(NextHcdP) >= 1 Then NextHcdP = System.Math.Sign(NextHcdP) * Pi / 2 Else NextHcdP = System.Math.Atan(NextHcdP / System.Math.Sqrt(-NextHcdP * NextHcdP + 1)) 'arcsine
		NextHcdP = NextHcdP * 180 / Pi
		
		i = -1 : If AsmDec < 0 Then i = 1
		NextHcdM = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i / 60) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i / 60) * Pi / 180)
		If System.Math.Abs(NextHcdM) >= 1 Then NextHcdM = System.Math.Sign(NextHcdM) * Pi / 2 Else NextHcdM = System.Math.Atan(NextHcdM / System.Math.Sqrt(-NextHcdM * NextHcdM + 1)) 'arcsine
		NextHcdM = NextHcdM * 180 / Pi
		
		'NextHcDSD1 is altitude for Asm L, Asm LHA, actual Dec
		NextHcDSD1 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(DE * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(DE * Pi / 180)
		If System.Math.Abs(NextHcDSD1) >= 1 Then NextHcDSD1 = System.Math.Sign(NextHcDSD1) * Pi / 2 Else NextHcDSD1 = System.Math.Atan(NextHcDSD1 / System.Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1)) 'arcsine
		NextHcDSD1 = NextHcDSD1 * 180 / Pi
		
		D = ((NextHcdP - NextHcdM) / (2 / 60)) 'D is delta d, d1corr is delta d corr
		D = Int(System.Math.Abs(D) * 100 + 0.5) / 100
		SignD = "+" ': If Sgn(D) = -1 Then SignD$ = "-"
		'd1corr = Abs(DecIncr * D)                                                  'This is the the mathematically correct delta d corr
		i = 0 : d1corr = 0 : If System.Math.Abs(DecIncr) > 30.9 Then i = 30 'This and next lines emulate multiplication table.  This lineif DecDiff >30.9'
		d1corr = Int(i * D * 10 + 0.50001) / 10 'This line for units of DecDiff from 1' to 30'
		d1corr = d1corr + Int(Int(System.Math.Abs(DecIncr) - i) * D * 10 + 0.50001) / 10 'This line for tenths of DecDiff
		d1corr = d1corr + Int((System.Math.Abs(DecIncr) - Int(System.Math.Abs(DecIncr))) * D * 10 + 0.5) / 10
		d1corr = Int(d1corr * 10 + 0.5) / 10
		If Hc > NextHcDSD1 Then d1corr = -d1corr : SignD = "-"
		
		'the next group is for determining delta t
		i = 1 : If LHA > 180 Then i = -1 'this seems to help
		NextHctP = System.Math.Cos((AsmLHA + i) * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
		If System.Math.Abs(NextHctP) >= 1 Then NextHctP = System.Math.Sign(NextHctP) * Pi / 2 Else NextHctP = System.Math.Atan(NextHctP / System.Math.Sqrt(-NextHctP * NextHctP + 1)) 'arcsine
		NextHctP = NextHctP * 180 / Pi
		
		NextHcDSD2 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec) * Pi / 180)
		If System.Math.Abs(NextHcDSD2) >= 1 Then NextHcDSD2 = System.Math.Sign(NextHcDSD2) * Pi / 2 Else NextHcDSD2 = System.Math.Atan(NextHcDSD2 / System.Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1)) 'arcsine
		NextHcDSD2 = NextHcDSD2 * 180 / Pi
		
		DSD2 = 0 : d2corr = 0 'd2corr is delta t corr
		If optdt.Checked = True Or optdtL.Checked = True Then
			DSD2 = (NextHctP - Hc) 'this is delta t
			DSD2 = Int(System.Math.Abs(DSD2) * 100 + 0.5) / 100
			Signd2corr = "+" ': If Sgn(DSD2) = -1 Then Signd2corr$ = "-"
			'd2corr = 0: If optdt.Value = True Or optdtL.Value = True Then d2corr = Abs(LHAdiff * DSD2)     'this is the mathematically correct delta t corr
			If optdt.Checked = True Or optdtL.Checked = True Then
				d2corr = Int(Int(System.Math.Abs(LHAdiff)) * DSD2 * 10 + 0.5) / 10 'this and next line emulate multiplication table
				d2corr = d2corr + Int((System.Math.Abs(LHAdiff) - Int(System.Math.Abs(LHAdiff))) * DSD2 * 10 + 0.5) / 10
			End If
			d2corr = Int(d2corr * 10 + 0.5) / 10
			If Hc > NextHcDSD2 Then d2corr = -d2corr : Signd2corr = "-"
		End If
		
		
		L4 = System.Math.Sin(AsmDec * Pi / 180)
		L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
		L6 = L4 - L5
		L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
		L8 = L6 / L7
		'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
		If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
		Z = Z * 180 / Pi
		TabZ = Int(Z * 10 + 0.5) / 10
		
		Ztot = TabZ
		
		'If L > 0 And LHA > 180 Then ZN = Ztot
		'If L > 0 And LHA <= 180 Then ZN = 360 - Ztot
		'If L <= 0 And LHA > 180 Then ZN = 180 - Ztot
		'If L <= 0 And LHA <= 180 Then ZN = 180 + Ztot
		If cboL.Text = "N " And LHA > 180 Then ZN = Ztot
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Ztot
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Ztot
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Ztot
		
		
		Zcorr = 0 'Zcorr is delta L corr
		If optdtL.Checked = True Then
			Zcorr1 = System.Math.Abs(System.Math.Cos(ZN * Pi / 180)) 'cos(ZN) is the same as cos(TabZ rounded to whole degrees)
			'Zcorr = Zcorr * Ldiff                 'this is the mathematically correct delta L corr
			Zcorr = Int(Int(System.Math.Abs(Ldiff)) * Zcorr1 * 10 + 0.5) / 10 'this and next line emulate multiplication table
			Zcorr = Zcorr + Int((System.Math.Abs(Ldiff) - Int(System.Math.Abs(Ldiff))) * Zcorr1 * 10 + 0.5) / 10
			Zcorr = Int(Zcorr * 10 + 0.5) / 10
			SignL = "+"
			If System.Math.Abs(L) > System.Math.Abs(AsmL) And TabZ > 90 Then Zcorr = -Zcorr : SignL = "-"
			If System.Math.Abs(L) < System.Math.Abs(AsmL) And TabZ < 90 Then Zcorr = -Zcorr : SignL = "-"
		End If
		
		ZN = Int(ZN + 0.5) 'added in V4.0.0
		
		Totcorr = (d1corr + d2corr) + Zcorr
		SignTotcorr = "+" : If Totcorr < 0 Then SignTotcorr = "-"
		
		TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60
		
		TotHcDeg = Fix(TotHc) : Htot = TotHc 'was Int
		TotHcMin = TotHc - TotHcDeg
		TotHcMin = Int(600 * TotHcMin + 0.5) / 10
		If TotHcMin = 60 Then TotHcMin = 0 : TotHcDeg = TotHcDeg + 1
		
		A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)
		
	End Sub
	
	Public Sub Sadler()
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		If L = 0 Then L = 0.000000000000001 'Prevents divide-by-zero error if latitude is 0º
		frame211.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Flag = False 'Part of avoiding divide-by-zero errors
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		If LHA <= 180 Then T = LHA 'W
		If LHA > 180 Then T = 360 - LHA 'E
		tDeg = Int(T)
		tMin = (T - tDeg) * 60
		If optCompact.Checked = True Then tMin = Int(tMin + 0.50000001)
		If optOriginal.Checked = True Then tMin = Int(2 * tMin + 0.5) / 2
		If tMin = 60 Then tMin = 0 : tDeg = tDeg + 1
		tDecimal = tDeg + tMin / 60 ': If tDecimal = 0 Then tDecimal = 0.00000001
		If optCompact.Checked = True And tDecimal = 0 Then MsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.") : Flag = True : Exit Sub
		If optOriginal.Checked = True And tDecimal = 0 Then MsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.") : Flag = True : Exit Sub
		If optCompact.Checked = True And tDecimal = 90 Then MsgBox("For Sadler Technique using Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5' away from 90º.") : cmd211_Click(cmd211, New System.EventArgs()) : Flag = True : Exit Sub
		If optOriginal.Checked = True And tDecimal = 90 Then MsgBox("For Sadler Technique using Original H.O. 211 without interpolation, meridian angle t must be at least 0.3' away from 90º.") : cmd211_Click(cmd211, New System.EventArgs()) : Flag = True : Exit Sub
		B1 = Sec211(tDecimal)
		If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then B1 = Int(10 * A1 + 0.5) / 10 Else B1 = Int(B1 + 0.5)
		A1 = Csc211(tDecimal)
		If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then A1 = Int(10 * A1 + 0.5) / 10 Else A1 = Int(A1 + 0.5)
		DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60
		'If DecDecimal = 0 Then MsgBox "For H.O. 211, Dec cannot be zero.": Flag = True: Exit Sub
		If optCompact.Checked = True And DecDecimal = 0 Then MsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.") : Flag = True : Exit Sub
		If optOriginal.Checked = True And DecDecimal = 0 Then MsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.") : Flag = True : Exit Sub
		frame211.Visible = True
		A2 = Csc211(DecDecimal)
		If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then A2 = Int(10 * A2 + 0.5) / 10 Else A2 = Int(A2 + 0.5)
		B2 = Sec211(DecDecimal)
		If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then B2 = Int(10 * B2 + 0.5) / 10 Else B2 = Int(B2 + 0.5)
		A3 = Csc211(System.Math.Abs(L))
		If (optCompact.Checked = True And A3 < 166) Or (optOriginal.Checked = True And A3 < 239) Then A3 = Int(10 * A3 + 0.5) / 10 Else A3 = Int(A3 + 0.5)
		B3 = Sec211(System.Math.Abs(L))
		If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then B3 = Int(10 * B3 + 0.5) / 10 Else B3 = Int(B3 + 0.5)
		A4 = A2 + A3
		A4 = Int(A4 * 10 + 0.5) / 10 'is this line necessary?
		L1 = 1 / (10 ^ (A4 / 100000)) 'L1 is h1
		If L1 = 1 Then L1 = Pi / 2 Else L1 = System.Math.Atan(L1 / System.Math.Sqrt(-L1 * L1 + 1) + 9.999999E-21) 'arcsin
		L1 = L1 * 180 / Pi
		If cboL.Text <> cboDec.Text Then L1 = -L1
		h1Deg = Int(System.Math.Abs(L1)) : h1Min = (System.Math.Abs(L1) - h1Deg) * 60
		If optCompact.Checked = True Then h1Min = Int(h1Min + 0.5)
		If optOriginal.Checked = True Then h1Min = Int(2 * h1Min + 0.5) / 2
		If h1Min >= 60 Then h1Min = h1Min - 60 : h1Deg = h1Deg + 1
		L2 = L1 + Ho 'h1 + Ho
		L2Deg = Int(System.Math.Abs(L2)) : L2Min = (System.Math.Abs(L2) - L2Deg) * 60
		If L2Min >= 60 Then L2Min = L2Min - 60 : L2Deg = L2Deg + 1
		L3 = L2 / 2 '(h1 + Ho)/2
		L3Deg = Int(System.Math.Abs(L3)) : L3Min = (System.Math.Abs(L3) - L3Deg) * 60
		If optCompact.Checked = True Then L3Min = Int(L3Min + 0.5)
		If optOriginal.Checked = True Then L3Min = Int(L3Min * 10 + 0.5) / 10
		If L3Min >= 60 Then L3Min = L3Min - 60 : L3Deg = L3Deg + 1
		B4 = Sec211(L3)
		A5 = B1 + B2 + B3 - B4
		L4 = 1 / (10 ^ (A5 / 100000)) 'L4 is h2
		If L4 = 1 Then L4 = Pi / 2 Else L4 = System.Math.Atan(L4 / System.Math.Sqrt(-L4 * L4 + 1) + 9.999999E-21) 'arcsin
		L4 = L4 * 180 / Pi
		If T < 90 Then L4 = System.Math.Abs(L4)
		If T > 90 Then L4 = -System.Math.Abs(L4)
		If T = 90 Then L4 = 0
		h2Deg = Int(L4) : h2Min = (L4 - h2Deg) * 60
		If optCompact.Checked = True Then h2Min = Int(h2Min + 0.5)
		If optOriginal.Checked = True Then h2Min = Int(2 * h2Min + 0.5) / 2
		If h2Min >= 60 Then h2Min = h2Min - 60 : h2Deg = h2Deg + 1
		Hc = h1Deg + h2Deg + (h1Min + h2Min) / 60 'h1 + h2
		HcDeg = Int(Hc) : HcMin = (Hc - HcDeg) * 60
		If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
		B5 = Sec211(Hc)
		If (L1 + L4) < 0 Then Hc = -Hc
		
		Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
		'HoDeg = Int(Ho)
		'HoMin = (Ho - HoDeg) * 60
		HoDeg = Val(txtHoDeg.Text)
		HoMin = Val(txtHoMin.Text)
		If optCompact.Checked = True Then HoMin = Int(HoMin + 0.5)
		If optOriginal.Checked = True Then HoMin = Int(HoMin * 10 + 0.5) / 10
		A = System.Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
		
		If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then B5 = Int(10 * B5 + 0.5) / 10 Else B5 = Int(B5 + 0.5)
		A6 = A1 + B2 - B5
		If A6 <= 0 Then A6 = 0 : Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
		If A6 <> 0 Then
			Z = 1 / (10 ^ (A6 / 100000))
			Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
			Z = Z * 180 / Pi
		End If
		A6 = Int(A6 * 10 + 0.5) / 10 'this line was necessary for low value of A7
		If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
		ZDeg = Int(Z)
		ZMin = (Z - ZDeg) * 60
		'If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
		If optCompact.Checked = True Then ZMin = Int(ZMin + 0.5)
		If optOriginal.Checked = True Then ZMin = Int(2 * ZMin + 0.5) / 2
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		
		'If cboL.text = "S " Then L = -L
		
	End Sub
	
	Public Sub DisplaySadler()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = True
		Line15.Visible = True
		Line16.Visible = True
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		'frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
		frame214.Visible = False : Label9.Visible = False
		frameS.Visible = False
		chkInterpolateB.Visible = False
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(22), "INTERCEPT and AZIMUTH by SADLER'S TECHNIQUE (H.O. 211)")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("t*", TAB(14 - Len(Str(tDeg))), VB6.Format(tDeg, "0") & Chr(176) & VB6.Format(tMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("t*", TAB(14 - Len(Str(tDeg))), VB6.Format(tDeg, "0") & Chr(176) & VB6.Format(tMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" -> -> -> -> -> -> -> -> ")
		i = Len(Str(B1)) : If (B1 - Int(B1)) = 0 Then i = i + 2
		If B1 < 1 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then
			Print(TAB(45), "B", TAB(57 - i), VB6.Format(B1, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "B", TAB(57 - i), VB6.Format(B1, "0"))
		End If
		i = Len(Str(A1)) : If (A1 - Int(A1)) = 0 Then i = i + 2
		If A1 < 1 And A1 > 0 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then
			Print(TAB(65), "A", TAB(77 - i), VB6.Format(A1, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(65), "A", TAB(77 - i), VB6.Format(A1, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("Dec*", TAB(14 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00") & "'" & cboDec.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("Dec*", TAB(14 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
		i = Len(Str(A2)) : If (A2 - Int(A2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A2, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A2, "0"))
		End If
		i = Len(Str(B2)) : If (B2 - Int(B2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
			Print(TAB(45), "B+", TAB(57 - i), VB6.Format(B2, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "B+", TAB(57 - i), VB6.Format(B2, "0"))
		End If
		i = Len(Str(B2)) : If (B2 - Int(B2)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
			Print(TAB(65), "B+", TAB(77 - i), VB6.Format(B2, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(65), "B+", TAB(77 - i), VB6.Format(B2, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("DR L", TAB(14 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'" & cboL.Text)
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("DR L", TAB(14 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
		i = Len(Str(A3)) : If (A3 - Int(A3)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A3 < 166) Or (optOriginal.Checked = True And A3 < 239) Then
			Print(TAB(25), "A+", TAB(37 - i), VB6.Format(A3, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "A+", TAB(37 - i), VB6.Format(A3, "0"))
		End If
		i = Len(Str(B3)) : If (B3 - Int(B3)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then
			Print(TAB(45), "B+", TAB(57 - i), VB6.Format(B3, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "B+", TAB(57 - i), VB6.Format(B3, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("h1")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L1 < 0 Then Print(TAB(13 - Len(Str(h1Deg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(14 - Len(Str(h1Deg))), VB6.Format(h1Deg, "0") & Chr(176) & VB6.Format(Int(h1Min), "00") & "'") 'cboL.text;
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(14 - Len(Str(h1Deg))), VB6.Format(h1Deg, "0") & Chr(176) & VB6.Format(Int(h1Min), "00.0") & "'") 'cboL.text;
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  <-  ")
		i = Len(Str(A4)) : If (A4 - Int(A4)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A4 < 166) Or (optOriginal.Checked = True And A4 < 239) Then
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A4, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(25), "A", TAB(37 - i), VB6.Format(A4, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("Ho", TAB(14 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("Ho", TAB(14 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("h1+Ho")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L2 < 0 Then Print(TAB(13 - Len(Str(L2Deg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(14 - Len(Str(L2Deg))), VB6.Format(L2Deg, "0") & Chr(176) & VB6.Format(L2Min, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(14 - Len(Str(L2Deg))), VB6.Format(L2Deg, "0") & Chr(176) & VB6.Format(L2Min, "00.0") & "'")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("(h1+Ho)/2")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L3 < 0 Then Print(TAB(13 - Len(Str(L3Deg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(14 - Len(Str(L3Deg))), VB6.Format(L3Deg, "0") & Chr(176) & VB6.Format(L3Min, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(14 - Len(Str(L3Deg))), VB6.Format(L3Deg, "0") & Chr(176) & VB6.Format(L3Min, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" -> -> -> -> -> -> -> -> ")
		i = Len(Str(B4)) : If (B4 - Int(B4)) = 0 Then i = i + 2
		If B4 < 1 And B4 > 0 Then i = i + 1
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then
			Print(TAB(45), "B-", TAB(57 - i), VB6.Format(B4, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "B-", TAB(57 - i), VB6.Format(B4, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("h2")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If L4 < 0 Then Print(TAB(13 - Len(Str(h2Deg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(14 - Len(Str(h2Deg))), VB6.Format(System.Math.Abs(h2Deg), "0") & Chr(176) & VB6.Format(System.Math.Abs(h2Min), "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(14 - Len(Str(h2Deg))), VB6.Format(System.Math.Abs(h2Deg), "0") & Chr(176) & VB6.Format(System.Math.Abs(h2Min), "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" <- <- <- <- <- <- <- <- ")
		i = Len(Str(A5)) : If (A5 - Int(A5)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And A5 < 166) Or (optOriginal.Checked = True And A5 < 239) Then
			Print(TAB(45), "A", TAB(57 - i), VB6.Format(A5, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(45), "A", TAB(57 - i), VB6.Format(A5, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Hc(h1+h2)")
		If (L1 + L4) < 0 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(13 - Len(Str(HcDeg))), "-") : Hc = -Hc
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(14 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(14 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(HcMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" -> -> -> -> -> -> -> -> -> -> -> -> -> -> -> ")
		i = Len(Str(B5)) : If (B5 - Int(B5)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then
			Print(TAB(65), "B-", TAB(77 - i), VB6.Format(B5, "0.0"))
		Else
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(65), "B-", TAB(77 - i), VB6.Format(B5, "0"))
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("Ho", TAB(14 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(HoMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print("Ho", TAB(14 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(HoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho > Hc Then Print("    Observed greater - Toward")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho < Hc Then Print("    Computed greater - Away")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Ho = Hc Then Print()
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("a", TAB(17 - Len(Str(Int(System.Math.Abs(A))))))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(VB6.Format(Int(System.Math.Abs(A) + 0.5), "0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(VB6.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " miles ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Hc < Ho Then Print("T")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Hc > Ho Then Print("A")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(28), "Zn", TAB(31), VB6.Format(ZN, "000") & Chr(176) & " <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print(TAB(42), "Z " & cboL.Text, SPC(1), VB6.Format(ZDeg, "0") & Chr(176) & VB6.Format(ZMin, "00") & "'") 'Format(Z, "0"); Chr$(176); for whole degrees
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optOriginal.Checked = True Then Print(TAB(42), "Z " & cboL.Text, SPC(1), VB6.Format(ZDeg, "0") & Chr(176) & VB6.Format(ZMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W" & " <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E" & " <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optCompact.Checked = True Then Print("<-")
		i = Len(Str(A6)) : If (A6 - Int(A6)) = 0 Then i = i + 2
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A6 - Int(A6) <> 0 Then Print(TAB(65), "A", TAB(77 - i), VB6.Format(A6, "0.0"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If A6 - Int(A6) = 0 Then Print(TAB(65), "A", TAB(77 - i), VB6.Format(A6, "0"))
		
		'Print ': Print
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("    EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print()
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(25), "*Table entry values")
		
	End Sub
	
	Private Sub STable()
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		frame211.Visible = False
		Line6.Visible = False
		Line7.Visible = False
		Line8.Visible = False
		Line9.Visible = False
		Line10.Visible = False
		Line11.Visible = False
		Flag = False 'Part of avoiding divide-by-zero errors
		LHA = GHA - Lo
		If LHA >= 360 Then LHA = LHA - 360
		If LHA < 0 Then LHA = LHA + 360
		LHADeg = Int(LHA)
		LHAMin = (LHA - LHADeg) * 60
		LHAMin = Int(LHAMin + 0.50000001)
		If LHAMin = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
		LHADecimal = LHADeg + LHAMin / 60
		If LHADecimal = 0 Then A1 = 999.999 Else A1 = CscS(LHADecimal)
		A1 = Int(1000 * A1 + 0.5) / 1000
		DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60
		frameS.Visible = True
		B1 = SecS(DecDecimal)
		B1 = Int(1000 * B1 + 0.5) / 1000
		A2 = CscS(DecDecimal)
		A2 = Int(1000 * A2 + 0.5) / 1000
		A3 = A1 + B1
		'        A3 = Int(A3 * 10 + 0.5) / 10    'is this line necessary?
		A4 = A3
		If optPepperday.Checked = True Then A3Angle = 1 / (10 ^ (A3 / 94.2932531))
		If optFarley.Checked = True Then A3Angle = 1 / (10 ^ (A3 / 100))
		A3Angle = System.Math.Atan(A3Angle / System.Math.Sqrt(-A3Angle * A3Angle + 1) + 9.999999E-21) 'arcsin
		A3Angle = A3Angle * 180 / Pi
		A3AngleDeg = Int(A3Angle)
		A3AngleMin = (A3Angle - A3AngleDeg) * 60
		A3AngleMin = Int(A3AngleMin + 0.5)
		A3AngleDecimal = A3AngleDeg + A3AngleMin / 60
		B2 = SecS(A3AngleDecimal)
		B2 = Int(1000 * B2 + 0.5) / 1000
		B3 = B2
		A5 = A2 - B2
		'        A5 = Int(A5 * 10 + 0.5) / 10    'is this line necessary?
		If optPepperday.Checked = True Then k = 1 / (10 ^ (A5 / 94.2932531))
		If optFarley.Checked = True Then k = 1 / (10 ^ (A5 / 100))
		If k = 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin
		k = k * 180 / Pi
		'    If tDecimal > 90 Then k = 180 - k       '????????????90-K or 180-K????????
		
		If k >= 82 And k <= 98 Then
			B2 = SecS(A3Angle)
			B2 = Int(1000 * B2 + 0.5) / 1000
			B3 = B2
			A5 = A2 - B2
			'A5 = CscS(DecDecimal) - SecS(A3Angle)
			'A5 = Int(1000 * A5 + 0.5) / 1000
			If optPepperday.Checked = True Then k = 1 / (10 ^ (A5 / 94.2932531))
			If optFarley.Checked = True Then k = 1 / (10 ^ (A5 / 100))
			If k = 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin
			k = k * 180 / Pi
			A5 = Int(1000 * A5 + 0.5) / 1000
		End If
		
		If LHADecimal >= 90 And LHADecimal <= 270 Then k = 180 - k
		KDeg = Int(k)
		KMin = (k - KDeg) * 60
		KMin = Int(KMin + 0.5)
		L = Val(txtLDeg.Text) + Int(Val(txtLMin.Text) + 0.5) / 60
		If cboDec.Text = cboL.Text Then KL = System.Math.Abs(L - KDeg - KMin / 60)
		If cboDec.Text <> cboL.Text Then KL = System.Math.Abs(L + KDeg + KMin / 60)
		'If KL > 90 Then KL = KL + 180
		KLDeg = Int(KL)
		KLMin = (KL - KLDeg) * 60
		'If KLDeg > 90 Then KLDeg = KLDeg + 180
		KLMin = Int(KLMin + 0.5)
		If KLMin >= 60 Then KLMin = KLMin - 60 : KLDeg = KLDeg + 1
		B4 = SecS(KLDeg + KLMin / 60)
		B4 = Int(1000 * B4 + 0.5) / 1000
		If KLDeg > 270 Then KLDeg = KLDeg - 180
		A6 = B3 + B4
		'        A6 = Int(A6 * 10 + 0.5) / 10    'is this line necessary?
		If optPepperday.Checked = True Then HcAngle = 1 / (10 ^ (A6 / 94.2932531))
		If optFarley.Checked = True Then HcAngle = 1 / (10 ^ (A6 / 100))
		If HcAngle = 1 Then HcAngle = Pi / 2 Else HcAngle = System.Math.Atan(HcAngle / System.Math.Sqrt(-HcAngle * HcAngle + 1) + 9.999999E-21) 'arcsin
		HcAngle = HcAngle * 180 / Pi
		If KL > 90 Then HcAngle = -HcAngle
		Htot = HcAngle
		HcDeg = Fix(HcAngle) 'was Int
		HcMin = (HcAngle - HcDeg) * 60
		HcMin = Int(HcMin + 0.5)
		If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
		HcDecimal = HcDeg + HcMin / 60
		'If KL > 90 Then HcDecimal = -HcDecimal
		B5 = SecS(HcDecimal)
		B5 = Int(1000 * B5 + 0.5) / 1000
		Ho = Val(txtHoDeg.Text) + Int(Val(txtHoMin.Text) + 0.5) / 60 'WHY THIS LINE???????????????????
		'HoDeg = Int(Ho)
		'HoMin = (Ho - HoDeg) * 60
		HoDeg = Val(txtHoDeg.Text)
		HoMin = Val(txtHoMin.Text)
		HoMin = Int(HoMin + 0.5)
		'A = Sgn(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
		A = (60 * HoDeg + HoMin) - (60 * HcDeg + HcMin)
		'If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
		A7 = A4 - B5
		If A7 <= 0 Then A7 = 0 : Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
		'A7 = Int(1000 * A7 + 0.5) / 1000
		If A7 <> 0 Then
			If optPepperday.Checked = True Then Z = 1 / (10 ^ (A7 / 94.2932531))
			If optFarley.Checked = True Then Z = 1 / (10 ^ (A7 / 100))
			Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
			Z = Z * 180 / Pi
		End If
		A7 = Int(A7 * 1000 + 0.5) / 1000 'this line was necessary for low value of A7
		If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
		Z = Int(Z + 0.5)
		If cboL.Text = "N " And LHA > 180 Then ZN = Z
		If cboL.Text = "N " And LHA <= 180 Then ZN = 360 - Z
		If cboL.Text = "S " And LHA > 180 Then ZN = 180 - Z
		If cboL.Text = "S " And LHA <= 180 Then ZN = 180 + Z
		
		If cboL.Text = "S " Then L = -L
		
	End Sub
	Private Sub DisplaySTable()
		cmdSave.Visible = False ': cmdSave.Enabled = False
		cmdFix.Visible = False ': cmdFix.Enabled = False
		Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
		Shape1.Visible = False
		Shape2.Visible = False
		Shape3.Visible = False
		Line4.Visible = False
		Line6.Visible = True
		Line7.Visible = True
		Line8.Visible = True
		Line9.Visible = True
		Line10.Visible = True
		Line11.Visible = True
		Line12.Visible = False
		Line13.Visible = False
		Line14.Visible = False
		Line15.Visible = False
		Line16.Visible = False
		Line17.Visible = False
		Line18.Visible = False
		Line19.Visible = False
		Line20.Visible = False
		Line21.Visible = False
		Line22.Visible = False
		Line23.Visible = False
		frameNASRUsing.Visible = False
		frame214.Visible = False : Label9.Visible = False
		chkInterpolateB.Visible = False
		frameS.Visible = True
		'UPGRADE_ISSUE: Form method Form8.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'UPGRADE_ISSUE: Form property Form8.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2260
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(36), "S TABLE SIGHT COMPUTATION")
		'If optPepperday = True Then Print "LHA*"; Tab(14 - Len(Str$(LHADeg))); Format(LHADeg, "0"); Chr$(176); Format(LHAMin, "00"); "'";
		FlagFarley = False
		If optFarley.Checked = True And LHA > 180 Then
			LHA = (360 - LHA)
			LHADeg = Int(LHA)
			LHAMin = (LHA - LHADeg) * 60
			LHAMin = Int(LHAMin + 0.50000001)
			If LHAMin = 60 Then LHAMin = 0 : LHADeg = LHADeg + 1
			FlagFarley = True
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("LHA*")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If FlagFarley = True Then Print("    -")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(14 - Len(Str(LHADeg))), VB6.Format(LHADeg, "0") & Chr(176) & VB6.Format(LHAMin, "00") & "'")
		i = Len(Str(Int(A1))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(25), "S", TAB(37 - i), VB6.Format(A1, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(25), "S1", TAB(37 - i), VB6.Format(A1, "0.000"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("Dec*    " & cboDec.Text, TAB(14 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00") & "'")
		If optFarley.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("DEC*    ")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboDec.Text = "N " Then Print("+")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboDec.Text = "S " Then Print("-")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(14 - Len(Str(Val(txtDecDeg.Text)))), VB6.Format(Val(txtDecDeg.Text), "0") & Chr(176) & VB6.Format(DecMinutes, "00") & "'")
		End If
		i = Len(Str(Int(B1))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(25), "C+", TAB(37 - i), VB6.Format(B1, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(25), "C2", TAB(37 - i), VB6.Format(B1, "0.000"))
		i = Len(Str(Int(A2))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(45), "S", TAB(57 - i), VB6.Format(A2, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(45), "S2", TAB(57 - i), VB6.Format(A2, "0.000"))
		
		i = Len(Str(Int(A3))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(25), "S", TAB(37 - i), VB6.Format(A3, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(25), "S3", TAB(37 - i), VB6.Format(A3, "0.000"))
		i = Len(Str(Int(B2))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(45), "C-", TAB(57 - i), VB6.Format(B2, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(45), "C3", TAB(57 - i), VB6.Format(B2, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If k >= 82 And k <= 98 Then Print("**")
		i = Len(Str(Int(B3))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(65), "C", TAB(77 - i), VB6.Format(B3, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(65), "C3", TAB(77 - i), VB6.Format(B3, "0.000"))
		i = Len(Str(Int(A4))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(85), "S", TAB(97 - i), VB6.Format(A4, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(85), "S3", TAB(97 - i), VB6.Format(A4, "0.000"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("K", TAB(14 - Len(Str(KDeg))), VB6.Format(KDeg, "0") & Chr(176) & VB6.Format(KMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(" <- <- <- <- <- <- <- <- <- ")
		i = Len(Str(Int(A5))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(45), "S", TAB(57 - i), VB6.Format(A5, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(45), "S4", TAB(57 - i), VB6.Format(A5, "0.000"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("lat     " & cboL.Text, TAB(14 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'")
		If optFarley.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("LAT     ")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboL.Text = "N " Then Print("+")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If cboL.Text = "S " Then Print("-")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(14 - Len(Str(Val(txtLDeg.Text)))), VB6.Format(Val(txtLDeg.Text), "0") & Chr(176) & VB6.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'")
		End If
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("K")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboDec.Text = cboL.Text Then Print("-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If cboDec.Text <> cboL.Text Then Print("+")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("lat", TAB(14 - Len(Str(KLDeg))), VB6.Format(KLDeg, "0") & Chr(176) & VB6.Format(KLMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print("lat(K')", TAB(14 - Len(Str(KLDeg))), VB6.Format(KLDeg, "0") & Chr(176) & VB6.Format(KLMin, "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  -> -> -> -> -> -> -> -> -> -> -> -> -> ->")
		i = Len(Str(Int(B4))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(65), "C+", TAB(77 - i), VB6.Format(B4, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(65), "C5", TAB(77 - i), VB6.Format(B4, "0.000"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("Comp. alt")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print("Hc")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If KL > 90 Then Print(TAB(13 - Len(Str(HcDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(14 - Len(Str(HcDeg))), VB6.Format(HcDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HcMin), "00") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  <- <- <- <- <- <- <- <- <- <- <- <- <- <- <- ")
		i = Len(Str(Int(A6))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(65), "S", TAB(77 - i), VB6.Format(A6, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(65), "S6", TAB(77 - i), VB6.Format(A6, "0.000"))
		i = Len(Str(Int(B5))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(85), "C-", TAB(97 - i), VB6.Format(B5, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(85), "C6", TAB(97 - i), VB6.Format(B5, "0.000"))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("obs.alt")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print("Ho")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If HoMin < 0 Then Print(TAB(13 - Len(Str(HoDeg))), "-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(14 - Len(Str(Val(txtHoDeg.Text)))), VB6.Format(HoDeg, "0") & Chr(176) & VB6.Format(System.Math.Abs(HoMin), "00") & "'")
		'Print Tab(13 - Len(Str$(HcDeg))); "-"; Tab(14 - Len(Str$(Val(txtHoDeg.text)))); ; Format(HoDeg, "0"); Chr$(176); Format(Abs(HoMin), "00"); "'"
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print("intercept", TAB(16 - Len(Str(Int(System.Math.Abs(A))))))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print("Doffset", TAB(16 - Len(Str(Int(System.Math.Abs(A))))))
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(A) = 1 Then Print("+")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(A) = -1 Then Print("-")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If System.Math.Sign(A) = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(VB6.Format(Int(System.Math.Abs(A) + 0.5), "0"))
		If optPepperday.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If HcDecimal < Ho Then Print(" Toward")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If HcDecimal > Ho Then Print(" Away")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If HcDecimal = Ho Then Print(" ")
		End If
		If optFarley.Checked = True Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(A) = -1 Then Print("(Away)")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(A) = 1 Then Print("(Toward)")
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If System.Math.Sign(A) = 0 Then Print(" ")
		End If
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(25), "Azimuth", TAB(33), VB6.Format(ZN, "000") & Chr(176) & " <- <- <-  ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(30), "Zn", TAB(33), VB6.Format(ZN, "000") & Chr(176) & " <- <- <-  ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(48), "Mer. Bg. " & cboL.Text, SPC(1), VB6.Format(Z, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(48), "Zo " & cboL.Text, SPC(1), VB6.Format(Z, "0") & Chr(176))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA <= 180 Then Print(" W" & " <- <- <- <- <- <- ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If LHA > 180 Then Print(" E" & " <- <- <- <- <- <- ")
		i = Len(Str(Int(A7))) + 4
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optPepperday.Checked = True Then Print(TAB(85), "S", TAB(97 - i), VB6.Format(A7, "0.000"))
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If optFarley.Checked = True Then Print(TAB(85), "S7", TAB(97 - i), VB6.Format(A7, "0.000"))
		
		'Print ': Print
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), "EP L " & VB6.Format(EstLDeg, "0") & Chr(176) & VB6.Format(EstLMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL > 0 Then Print("N")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstL < 0 Then Print("S")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("      EP Lo " & VB6.Format(EstLoDeg, "0") & Chr(176) & VB6.Format(EstLoMin, "00.0") & "'")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo > 0 Then Print("W")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo = 0 Then Print(" ")
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If EstLo < 0 Then Print("E")
		
		'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("*Table entry values")
		If k >= 82 And k <= 98 Then
			'UPGRADE_ISSUE: Form method Form8.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print(TAB(23), "**If K is between 82" & Chr(176) & " and 98" & Chr(176) & " this C is interpolated.")
		End If
		
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class