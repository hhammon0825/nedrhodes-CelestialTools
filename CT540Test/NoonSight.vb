Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form5
	Inherits System.Windows.Forms.Form
	Dim Lo, Pi, ZD As Double
	Dim DateOfSight As String
	Dim ZTinSeconds As Integer
	Dim i As Short
	Dim JD, DecimalDateHour1, DecimalDate, DecimalDateHour2, T As Double
	Dim TP, GA, HG, Lat As Double
	Dim HD, MonthList, SignZD, MonthDays, MonthatG, fnumeral As String
	Dim GYearJ As Short
	Dim JDHour1, JDHour2 As Double
	Dim GDayOfYear, GHour, DayNumber, GHourLAN As Short
	Dim GMinute, GSecond As Integer
	Dim LocalYear, GDay, GMonth, GYear, MonthNumber As Short
	Dim ZDinSeconds, UTinSeconds As Integer
	Dim LeapYear, GLeapYear As Boolean
	Dim L, C, OE, LMin As Double
	Dim LH, dh As String
	Dim LDeg As Short
	Dim B, MS As Double
	Dim NL, NO As Double
	Dim WM, LR, GR, VM, QM As Double
	Dim WD, QD As Short
	Dim VD As Double
    Dim RN, LN, NU As Double
    Dim AR As Double = 0
    Dim x, y, DE As Double
    Dim SH As Double
	Dim GRD As Short
	'UPGRADE_NOTE: Main was upgraded to Main_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim RstdTP, Rstd, Main_Renamed, Raddl, RstdA2 As Double
	Dim RA, GRM, DF As Double
	Dim DateError As Boolean
	Dim LANMinutes, LANSeconds As Short
	Dim hsinMinutes, ICinMinutes, hainMinutes As Double
	Dim Corr1, Corr1Min As Double
	Dim Corr1Deg As Short
	Dim BackSight As Boolean
	Dim PA, HP, r As Double
	Dim HoMin, Corr2Min, HoinMinutes, HoDeg As Double
	Dim PX, DI, TX, DecMinutes As Double
	Dim DecDegrees As Short
	Dim haDeg As Short
	Dim HsMin, Pressure, HEinFeet, haMin, HE, Temperature, DipShortDist, ICMin As Double
	Dim ZenithDistinDeg, ZenithDistMin As Double
	Dim ZenithDistDeg As Short
	Dim ZDMan, DRL As Double
	Dim ZDManinSeconds As Integer
	Dim SunAzN, SunAzS As Boolean
	Dim Ldiff As Double
	Dim EW As String
	Dim DecYr, Theta As Single
	Dim TLANObsSec As Integer
	Dim Flag3, Flag, Flag2 As Boolean
	Dim DeltaT As Double ', FlagLAN As Boolean, Flag2 As Boolean
	Dim DE1, THour1, THour2, DE2 As Double
	Dim dvalue, dcorr As Double
	Dim Signdvalue As Short
	Dim TotDecDegrees, Lendcorr As Short
	Dim TotDE, TotDecMinutes, LoforLAN As Double
	Dim GHADeg, LoforLANDeg As Short
	Dim GHAMin, LoforLANMin As Double
	Dim LANTime, GHADiff, GHADiffMin, ZTofLAN As Double
	Dim GHADiffDeg As Short
	Dim ZTofLANMinutes, ZTofLANHours, ZTofLANSeconds As Short
	Dim GHAAriesHour, GHAHour As Double
	Dim NutF, NutM, NutD, NutMprime, NutOmega As Double
    Dim NCos(64), NSin(64), NF(64), NM(64), ND(64), NMprime(64), NOmega(64), NSinT(64), NCosT(64) As Integer
    Dim L1, Ecc, OETrue, L0, JDHour As Double
	Dim DRLMin, LoMin As String
	Dim RH As Double
	Dim SunHourChange, GHAHour1, GHAHour2, SunGHACorr As Double
	Dim GHourLANDisplay, ZTofLANHoursDisplay As Short
	Dim StarDayNumber As Short
	
	'UPGRADE_WARNING: Event cboDay.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboDay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDay.SelectedIndexChanged
        CheckDate()
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()

        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
    End Sub

    'UPGRADE_WARNING: Event cboLo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()

        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        AutoZDCalc()
    End Sub

    'UPGRADE_WARNING: Event cboMonth.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboMonth_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        CheckDate()
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()

        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
    End Sub

    'UPGRADE_WARNING: Event cboZDm.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboZDm_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm.SelectedIndexChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()
        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
    End Sub

    'UPGRADE_WARNING: Event chkDST.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkDST_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST.CheckStateChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()
        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        'txtLoMin.ForeColor = &H80000008
        txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)

    End Sub

    Private Sub LongitudeByLAN()
        Flag2 = True
        ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2)) - (ZD - ZDMan) * 3600
        Greenwich()
        Delta_T()
        Julian()
        Nutation()
        Obliquity()
        Sun()
        Aries()
        GA = GR - AR
        If GA >= 360 Or GA < 0 Then GA = GA - Int(GA / 360) * 360
        EW = "W"
        If GA > 180 Then GA = 360 - GA : EW = "E"
        VD = Int(GA) : VM = (GA - VD) * 60 : VM = Int(VM * 10 + 0.5) / 10
        If VM = 60 Then VM = 0 : VD = VD + 1
        If (VD = 0 Or VD = 180) And VM = 0 Then EW = ""
        'UPGRADE_ISSUE: Form method Form5.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Dim ScaleSizeF As New SizeF
        ScaleSizeF.Height = 0
        ScaleSizeF.Width = 0
        Me.Scale(ScaleSizeF)
        'Me.Scale()
        Flag2 = False
    End Sub
    Private Sub DisplayLongitudeByLAN()
        'Font = VB6.FontChangeName(Font, "Courier New")
        'Dim ScaleSizeF As New SizeF
        'ScaleSizeF.Height = 0
        'ScaleSizeF.Width = 0
        'Me.Scale(ScaleSizeF)
        'Me.Scale()
        'CurrentX = 0
        'CurrentY = 8300 'CurrentX = 5500: CurrentY = 8220
        LongitudeCalcTxtBx.Text = vbNullString
        LongitudeCalcTxtBx.AppendText("Longitude from observed ZT of LAN " & VD.ToString("0") & Chr(176) & VM.ToString("00.0") & "'" & EW)
    End Sub

    Private Sub cmdLAN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLAN.Click
        '    FlagLAN = True
        LAN()
        GHourLAN = GHour
        GHourLANDisplay = GHour
        ZTofLANHoursDisplay = ZTofLANHours
        'Form5.MousePointer = 0
        DisplayLANTime()
        'txtTime.Text = Format(LANHours, "00") & Format(LANMinutes, "00") & Format(LANSeconds, "00")
        txtTime.Text = ZTofLANHours.ToString("00") & ZTofLANMinutes.ToString("00") & ZTofLANSeconds.ToString("00")
        '    Form5.MousePointer = 0
        cmdNoonSight.Visible = True ': cmdNoonSight.Enabled = True
        Flag = True
        'FlagLAN = False
        txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)

    End Sub

    Private Sub LAN()
        Flag2 = True
        DateError = False
        CheckDate()
        If DateError = True Then DateError = False : Exit Sub
        'UPGRADE_ISSUE: Form method Form5.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Dim ScaleSizeF As New SizeF
        'ScaleSizeF.Height = 0
        'ScaleSizeF.Width = 0
        'Me.Scale(ScaleSizeF)  'Puts (0,0) back at upper left after rescaling for Meridian Diagram
        LANTimeTxtBx.Text = vbNullString
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        txtTime.Text = vbNullString
        ClearScreen()
        'Me.ResizeRedraw = False
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor 'Hourglass
        'UPGRADE_ISSUE: Form property Form5.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.ResizeRedraw = True
        'Longitude
        AutoZDCalc()
        Longitude()
        If cboLo.Text = "W " Then LoforLAN = Lo Else LoforLAN = 360 - System.Math.Abs(Lo)
        'Test 12h
        ZTinSeconds = 43200
        Greenwich()
        Delta_T()
        Julian()
        Nutation()
        Obliquity()
        Aries()
        Sun()
        GHADec()
        GHADiff = LoforLAN - GA
        If GHADiff < 0 Then GHADiff = GHADiff + 360

        If GHADiff >= 15 Then 'GHADiff < 0 Or
            ZTinSeconds = 39600 '11h
            Greenwich()
            'If GHour = 23 Then GDay = GDay - 1
            Delta_T()
            Julian()
            Nutation()
            Obliquity()
            Aries()
            Sun()
            GHADec()
            GHADiff = LoforLAN - GA
            If GHADiff < 0 Then GHADiff = 360 + GHADiff
        End If

        GHADeg = Int(GA) : GHAMin = (GA - GHADeg) * 60
        If GHAMin >= 60 Then GHAMin = GHAMin - 60 : GHADeg = GHADeg + 1
        If GHADeg >= 360 Then GHADeg = GHADeg - 360

        '    GHourLAN = GHour

        Me.Cursor = System.Windows.Forms.Cursors.Default
        Flag2 = False
    End Sub

    Private Sub cmdNoonSight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNoonSight.Click 'This change was made in V4.9.0 as the easiest way to make Noon Sight without first calculating ZT of LAN work properly.  Fix was wrong in V4.6.1.
        Flag3 = False 'Flag3 used to prevent Sub from continuing if there are messages
        'LAN
        NoonSight()
        If Flag3 = True Then Exit Sub 'this line was after second NoonSight, but it allowed a second message
        NoonSight() 'need this so don't need second click
        DisplayLANTime()
        DisplayNoonSight()
        DisplayMeridianDiagram()
        DisplayLongitudeByLAN()
    End Sub
    Private Sub NoonSight()
        'cmdLAN_Click
        Longitude() 'Added as part of European comma as decimal separator solution
        If cboIE.Text = "off the arc (rdg.)" And Val(txtIEdeg.Text) = 0 Then MsgBox("For IE off the arc (rdg.), degree value cannot be zero.") : Exit Sub
        'If txtTime.Text = "" Then MsgBox "Observed ZT of LAN cannot be blank": Exit Sub
        ZDinSeconds = 3600 * System.Math.Sign(ZD) * Int(Lo / 15) 'goes back to normal ZD without (Lo + 1) correction in Greenwich
        ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2))
        UTinSeconds = UTinSeconds + (ZDinSeconds - ZDManinSeconds)
        If chkDST.CheckState = 1 Then UTinSeconds = UTinSeconds - 3600
        '    Greenwich                 'having this line messes up Dec hr, removing it makes GMinute = 0 so d corr is wrong ?????????
        'Delta_T
        'HourFlag = False
        '    If Flag = False Then Julian
        '    Julian
        T = THour1 ': JDHour = JDHour1
        Nutation()
        Obliquity()
        Aries()
        Sun()
        DE1 = DE
        GHADec()
        'HourFlag = True
        'Greenwich
        '    Julian
        T = THour2 ': JDHour = JDHour2
        Nutation()
        Obliquity()
        Aries()
        Sun()
        DE2 = DE
        GHADec()
        IandC()
        'LongitudeByLAN
        'UPGRADE_ISSUE: Form method Form5.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.Scale  'Puts (0,0) back at upper left after rescaling for Meridian Diagram
        '    If Flag2 = True Then
        If optAzN.Checked = False And optAzS.Checked = False And optDRL.Checked = False Then MsgBox("You must select a sun azimuth or DR L at LAN.") : Flag3 = True : Exit Sub
        If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
            With txtDsDist
                .Focus()
            End With
            MsgBox("You must enter a non-zero value for Ds distance")
            Flag3 = True
            Exit Sub
            '        End If
        End If
        If Flag3 = True Then Exit Sub
        AltitudeCorrection()
        DecDegrees = Int(System.Math.Abs(DE1)) : DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
        'If Val(Left$(txtTime, 2)) > ZTofLANHours Then DecDegrees = Int(Abs(DE2)): DecMinutes = (Abs(DE2) - DecDegrees) * 60
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then DecMinutes = 0 : DecDegrees = DecDegrees + 1
        ZenithDistinDeg = (5400 - HoinMinutes) / 60
        ZenithDistDeg = Int(ZenithDistinDeg) : ZenithDistMin = (ZenithDistinDeg - ZenithDistDeg) * 60
        ZenithDistMin = Int(ZenithDistMin * 10 + 0.5) / 10
        If ZenithDistMin = 60 Then ZenithDistMin = 0 : ZenithDistDeg = ZenithDistDeg + 1
        LatCalc()
        LongitudeByLAN()
        'AltitudeCorrection     'Moved here (from above) to correct refraction when Parameters is selected.
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()
        'cmdLAN_click
        '    If Flag = True Then DisplayLANTime

        GHourLAN = Val(VB.Left(txtTime.Text, 2)) + ZDMan 'ZDMan was ZD; changed in V5.4.0

        '    LongitudeByLAN         'need this so don't need second click
        'LongitudeByLAN
        'Flag = False
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        '    Printer.ColorMode = vbPRCMMonochrome
        '    Form5.PrintForm
        '    Printer.ColorMode = vbPRCMColor
        ' Setting FormHeight and FomrWidth not needed here - these are set in PrintScreen sub - HRH 01/05/2017
        'FormHeight = VB6.PixelsToTwipsY(Me.Height)
        'FormWidth = VB6.PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub ExitNoonSight_Click(sender As Object, e As EventArgs) Handles ExitNoonSight.Click
        Cleanup()
        Close()
    End Sub


    'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
        cboLo.SelectedIndex = 0 ' "W"
        cboDRL.SelectedIndex = 0 ' "N"
        txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        'txtTime.BackColor = &H8000000F
        cboZDm.SelectedIndex = 0 ' "00"
        'AriesFlag = False

        'nutation in longitude and obliquity
        ND = New Integer() {0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2}
        NM = New Integer() {0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1}
        NMprime = New Integer() {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0}
        NF = New Integer() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2}
        NOmega = New Integer() {1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2}
        NSin = New Integer() {-171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3}
        NSinT = New Integer() {-174.2, -1.6, -0.2, 0.2, -3.4, 0.1, 1.2, -0.4, 0, -0.5, 0, 0.1, 0, 0, 0.1, 0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCos = New Integer() {92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCosT = New Integer() {8.9, -3.1, -0.5, 0.5, -0.1, 0, -0.6, 0, -0.1, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    End Sub

    Private Sub MeridianPicBx_Paint(sender As Object, e As PaintEventArgs) Handles MeridianPicBx.Paint
        Dim g As Graphics = e.Graphics
    End Sub

    Private Sub Form5_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
        Me.Left = ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - (Me.Width)) / 2
        Me.Top = ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - (Me.Height)) / 2

        'cboDay.SelectedIndex = VB.Day(Today) - 1 '-1 because ListIndex starts with 0
        cboDay.SelectedIndex = Today.Day - 1 '-1 because ListIndex starts with 0
        MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec"
        cboMonth.Text = Mid(MonthList, 3 * Val(CStr(Month(Today))) - 2, 3)
        'txtYear.Text = CStr(Year(Today))
        txtYear.Text = Today.Year.ToString
        cboLo.SelectedIndex = 0 '"W"
        cboDRL.SelectedIndex = 0 '"N"
        cboIE.SelectedIndex = 0 '"on the arc"
        cboHE.SelectedIndex = 0 '"ft"
        cboDsUnit.SelectedIndex = 0 '"yards"
        cboTemperature.SelectedIndex = 0 '"F"
        cboPressure.SelectedIndex = 0 '"in Hg"
        Flag = False
    End Sub

    Private Sub Form5_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cleanup()
    End Sub

    'UPGRADE_WARNING: Event optAzN.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAzN_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAzN.CheckedChanged
        If eventSender.Checked Then
            If optDRL.Checked = False Then txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : txtDRLDeg.Enabled = False : txtDRLMin.Enabled = False : cboDRL.Enabled = False
        End If
    End Sub

    'UPGRADE_WARNING: Event optAzS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAzS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAzS.CheckedChanged
        If eventSender.Checked Then
            If optDRL.Checked = False Then txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F) : txtDRLDeg.Enabled = False : txtDRLMin.Enabled = False : cboDRL.Enabled = False
        End If
    End Sub

    'UPGRADE_WARNING: Event optDRL.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optDRL_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDRL.CheckedChanged
        If eventSender.Checked Then
            If optDRL.Checked = True Then txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : txtDRLDeg.Enabled = True : txtDRLMin.Enabled = True : cboDRL.Enabled = True
        End If
    End Sub

    'UPGRADE_WARNING: Event optHoSRForm.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optHoSRForm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoSRForm.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
        End If
    End Sub

    'UPGRADE_WARNING: Event optHoParameters.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optHoParameters_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoParameters.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
        End If
    End Sub

    'UPGRADE_WARNING: Event optZDAuto.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optZDAuto_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDAuto.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            ClearScreen()
            txtTime.Text = ""
            cmdNoonSight.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
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
        If eventSender.Checked And eventSender.Text <> "" Then
            'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            ClearScreen()
            txtTime.Text = ""
            cmdNoonSight.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
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
        If eventSender.Checked And eventSender.Text <> "" Then
            'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            ClearScreen()
            txtTime.Text = ""
            cmdNoonSight.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
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

    'UPGRADE_WARNING: Event txtDRLDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDRLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLDeg.TextChanged
        If Val(txtDRLDeg.Text) <> 90 Then txtDRLMin.Enabled = True
        If Val(txtDRLDeg.Text) = 90 Then txtDRLMin.Text = "" : txtDRLMin.Enabled = False : txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        'txtDRLDeg.ForeColor = &H80000008
        txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        '    If Val(txtDRLDeg.text) > 90 Or (Val(txtDRLDeg.text) = 90 And Val(txtDRLMin.text) <> 0) Then
        '        txtDRLDeg.BackColor = &HFF&
        '        MsgBox "Out of Range"
        '    End If
        If Val(txtDRLDeg.Text) > 90 Then
            txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtDRLDeg.Text) < 90 Then
            'txtDRLMin.ForeColor = &H80000008
            txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            'txtDRLMin.Text = "  "
        End If
    End Sub

    Private Sub txtDRLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDRLDeg.KeyPress
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

    Private Sub txtDRLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDRLDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDRLDeg.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDRLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLDeg.Enter
        SelectAllText(txtDRLDeg)
    End Sub

    'UPGRADE_WARNING: Event txtDRLMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDRLMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLMin.TextChanged
        'txtDRLMin.ForeColor = &H80000008
        txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDRLMin.Text) > 59.9 Then
            txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtDRLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDRLMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDRLMin.Text, ".") Then
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

    Private Sub txtDRLMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDRLMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDRLMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDRLMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLMin.Enter
        SelectAllText(txtDRLMin)
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

    'UPGRADE_WARNING: Event txtLoDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'ClearScreen()

        txtTime.Text = ""
        If Val(txtLoDeg.Text) <> 180 Then txtLoMin.Enabled = True
        If Val(txtLoDeg.Text) = 180 Then txtLoMin.Text = "" : txtLoMin.Enabled = False : txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
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
    Private Sub txtLoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.Enter
        SelectAllText(txtLoDeg)
    End Sub

    'UPGRADE_WARNING: Event txtLoMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtLoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.TextChanged
        'Cls()
        'ClearScreen()
        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
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
    Private Sub txtLoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.Enter
        SelectAllText(txtLoMin)
    End Sub

    'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
            txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If

        If Flag = False And Len(txtTime.Text) = 6 Then cmdNoonSight.Visible = True : Exit Sub
        Longitude()
        AutoZDCalc()

        'ZD = Abs(Val(txtZDh.Text))
        If optZDManual.Checked = False Then ZDMan = ZD
        If optZDManual.Checked = True Then ZDMan = System.Math.Abs(Val(txtZDh.Text)) + Val(cboZDm.Text) / 60
        If optZDUT.Checked = True Then ZDMan = 0 'added in V5.4.0
        If VB.Left(txtZDh.Text, 1) = "-" Then ZDMan = -ZDMan : ZD = -ZD
        'GHour = GHour - 1   'corrects GHour for additional hour added in Greenwich
        If chkDST.CheckState = 1 Then ZD = ZD - 1 : ZDMan = ZDMan - 1 ': GHour = GHour - 1



        'txtTime.ForeColor = &H80000008
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        TLANObsSec = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(Mid(txtTime.Text, 5, 2))
        'If optZDManual = False Then ZDMan = ZD
        'Next line converts to zone by longitude (in seconds)       Int(Lo / 15 + 0.5) is ZD by longitude
        '    If Len(txtTime.Text) = 6 And (TLANObsSec - (Int(Lo / 15 + 0.5) - ZDMan) * 3600 < 40408 Or TLANObsSec - (Int(Lo / 15 + 0.5) - ZDMan) * 3600 > 45867) Then
        If Len(txtTime.Text) = 6 And ((chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) Or (chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467)))) Then txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) : MsgBox("Out of Range") : cmdNoonSight.Visible = False Else : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : cmdNoonSight.Visible = True
        '        Exit Sub
        '    End If
        '    If Len(txtTime.Text) = 6 And (TLANObsSec >= 42208 Or TLANObsSec <= 44067) Then cmdNoonSight.Visible = True ': cmdNoonSight.Enabled = True

        'If Len(txtTime.Text) = 6 And ((chkDST.Value = 0 And (TLANObsSec < 40408 Or TLANObsSec > 45867) _
        ''    Or (chkDST.Value = 1 And (TLANObsSec < 44008 Or TLANObsSec > 49467)))) Then _
        ''    txtTime.BackColor = &HFF&: MsgBox "Out of Range": cmdNoonSight.Visible = False _
        ''    Else: txtTime.BackColor = &H80000005: cmdNoonSight.Visible = True
        If Len(txtTime.Text) < 6 Then cmdNoonSight.Visible = False ': cmdNoonSight.Enabled = False

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
        If Flag = False And Len(txtTime.Text) = 6 Then cmdNoonSight.Visible = True : GoTo EventExitSub
        If Len(txtTime.Text) = 6 And chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) Then
            KeepFocus = True ': txtTime.BackColor = &HFF&: MsgBox "Out of Range": cmdNoonSight.Visible = False
        End If
        If Len(txtTime.Text) = 6 And chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467) Then
            KeepFocus = True ': txtTime.BackColor = &HFF&: MsgBox "Out of Range": cmdNoonSight.Visible = False
        End If
        If Len(txtTime.Text) = 0 Then
            KeepFocus = False
        End If
EventExitSub:
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
        SelectAllText(txtTime)
    End Sub

    'UPGRADE_WARNING: Event txtYear.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.TextChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()
        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        'txtYear.ForeColor = &H80000008
        txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
            txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        CheckDate()
    End Sub
    Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.Enter
        SelectAllText(txtYear)
    End Sub

    'UPGRADE_WARNING: Event txtZDh.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
        'UPGRADE_ISSUE: Form method Form5.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        ClearScreen()
        txtTime.Text = ""
        cmdNoonSight.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        'txtZDh.ForeColor = &H80000008
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
    Private Sub txtZDh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.Enter
        SelectAllText(txtZDh)
    End Sub

    Public Sub CheckDate()
        On Error GoTo ErrorHandler
        If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
            Exit Sub
        Else
            Dim tempstr As String = (cboMonth.GetItemText(cboMonth.SelectedIndex) + 1).ToString("00")
            DateOfSight = tempstr & "/" & cboDay.Text & "/" & txtYear.Text
            'UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            DateOfSight = DateValue(DateOfSight).ToString

            'DateOfSight = CStr(DateValue(DateOfSight))
        End If
        Exit Sub
ErrorHandler:
        MsgBox("Invalid date")
        DateError = True
        Exit Sub
    End Sub

    Public Sub Longitude()
        'Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
        LoMin = Replace(txtLoMin.Text, ",", ".")
        Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
        If cboLo.Text = "E " Then Lo = -Lo
    End Sub

    Public Function Greenwich() As Integer
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
        'ZD = Val(txtZDh.Text)
        'If optZDManual = True Then ZD = Sgn(Lo) * (Abs(ZD) + Val((cboZDm.Text)) / 60)
        '    ZD = Abs(Val(txtZDh.Text))
        '    If optZDManual = True Then ZD = Abs(ZD) + Val((cboZDm.Text)) / 60                          'REMOVED      THIS IS THE ONE THAT CAUSES 1 HOUR ERROR IN GHA SUN WITH MANUAL ZD, BUT REMOVING IT SCREWS UP AUTO ZD
        '    'If Val(txtZDh.Text) < 0 Then ZD = -ZD
        '    If Left(txtZDh.Text, 1) = "-" Then ZD = -ZD
        '    If chkDST.Value = 1 Then ZD = ZD - 1

        'AutoZDCalc 'this line replaced previous two lines

        'Longitude
        'ZD = Round(Lo / 15)
        'ZDinSeconds = 3600 * ZD
        ZDinSeconds = 3600 * System.Math.Sign(ZD) * System.Math.Abs(ZD)
        UTinSeconds = ZTinSeconds + ZDinSeconds

        If Flag2 = False Then
            StarDayNumber = DayNumber Mod 3 'added in V5.3.1 - screws up longitude from observed ZT of LAN
            If StarDayNumber = 1 Then DayNumber = DayNumber + 1
            'If StarDayNumber = 2 Then DayNumber = DayNumber
            If StarDayNumber = 0 Then DayNumber = DayNumber - 1
            UTinSeconds = 43200 'THIS DOES NOT WANT TO BE 43200 IN IandC
        End If

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
        Return True
    End Function
    Public Function Julian() As Integer
        DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400.0!)
        DecimalDateHour1 = GDay + (GHour / 24)
        DecimalDateHour2 = GDay + ((GHour + 1) / 24)
        'DecimalDateHour2 = (GDay + 1) + (GHour / 24)
        GYearJ = GYear
        If GMonth < 3 Then GYearJ = GYear - 1 : GMonth = GMonth + 12
        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
        JDHour1 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour1 - 1537.5
        JDHour2 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour2 - 1537.5
        'T = (JD - 2451545) / 36525!                    'eliminated in V4.7.1
        T = (JD - 2451545 + DeltaT / 86400) / 36525.0! 'added in V4.7.1
        'T = (JD - 2451545 + DeltaT / 86400) / 36525!
        ''    If BN = 64 Or BN = 65 Then THour1 = (JDHour1 - 2451545) / 36525!: THour2 = (JDHour2 - 2451545) / 36525!
        'THour1 = (JDHour1 - 2451545) / 36525!: THour2 = (JDHour2 - 2451545) / 36525!

        'If BN <> 64 And BN <> 65 Then
        THour1 = (JDHour1 - 2451545 + DeltaT / 86400) / 36525.0! : THour2 = (JDHour2 - 2451545 + DeltaT / 86400) / 36525.0!
        Return True
    End Function

    Public Function Obliquity() As Integer
        'Obliquity of the ecliptic
        OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
        OE = OE / 3600 'degrees
        OETrue = OE + NO 'degrees
        Return True
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
    Public Function Aries() As Integer
        HG = UTinSeconds / 3600 ': If AriesFlag = True Then HG = GHour
        TP = (JD - 2451545.0! - HG / 24) / 36525.0!
        GR = 6.69737456 + 0.000000000000004 + (2400.051336 * TP)
        GR = GR + (0.0000258622 * TP * TP) + (1.002737909 * HG)
        GR = GR * 15 '  convert hours to degrees
        'If GRM(IB) = 60 Then GRM(IB) = 0: GRD(IB) = GRD(IB) + 1    What is this?
        GR = GR + NL
        If GR >= 360 Or GR < 0 Then GR = GR - Int(GR / 360) * 360
        LR = GR - Lo
        If LR >= 360 Then LR = LR - 360
        If LR < 0 Then LR = LR + 360
        If VM = 60 Then VM = 0 : VD = VD + 1
        WD = Int(GR) : WM = (GR - WD) * 60 : WM = Int(WM * 10 + 0.5) / 10 : If WM = 60 Then WM = 0 : WD = WD + 1
        QD = Int(LR) : QM = (LR - QD) * 60 : QM = Int(QM * 10 + 0.5) / 10 : If QM = 60 Then QM = 0 : QD = QD + 1
        Return True
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

        T = T / 10
        ' Compute heliocentric, ecliptical Longitude L in radians
        L = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
        If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
        ' Compute heliocentric, ecliptical Latitude B in radians
        B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
        ' Compute heliocentric distance RH in AU
        RH = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)

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
        L1 = L1 - (20.4898 / 3600) / RH 'apparent longitude, degrees
        'back to radians
        L1 = L1 * Pi / 180
        EclipticToEquatorial()
        AR = AR * 180 / Pi 'for Meeus ecl-to-eq
        DE = DE * 180 / Pi 'for Meeus ecl-to-eq

        DI = System.Math.Atan(0.00465424336 / RN) * 180 / Pi * 60
        If optCenter.Checked = True Then DI = 0
        'DI = (959.63 / RN) / 60        'Meeus
        'back to normal T
        '    T = 10 * T
    End Sub

    Public Function GHADec() As Integer

        SH = 360 - AR
        GA = GR - AR
        If GA >= 360 Or GA < 0 Then GA = GA - Int(GA / 360) * 360

        T = THour1 : JDHour = JDHour1
        Nutation()
        Obliquity()
        Sun()
        DE1 = DE
        HourAnglesHour()
        GHAHour1 = GHAHour

        T = THour2 : JDHour = JDHour2
        Nutation()
        Obliquity()
        Sun()
        DE2 = DE
        HourAnglesHour()
        GHAHour2 = GHAHour

        SunHourChange = GHAHour2 - GHAHour1
        If SunHourChange < 0 Then SunHourChange = SunHourChange + 360
        SunGHACorr = (15 - SunHourChange) / 2
        GHAHour1 = GHAHour1 - SunGHACorr
        GA = GHAHour1

        SH = Int(SH * 10 + 0.5) / 10
        'GRD = Int(AR)
        GRD = Convert.ToInt32(AR)
        GRM = (AR - GRD) * 60
        GRM = Int(GRM * 10 + 0.5) / 10
        RA = Int(AR * 10 + 0.5) / 10
        If DE = 0 Then HD = " "
        If DE > 0 Then HD = "N"
        If DE < 0 Then HD = "S"
        DF = Int(System.Math.Abs(DE) * 10 + 0.5) / 10
        VD = Int(GA) : VM = (GA - VD) * 60 : VM = Int(VM * 10 + 0.5) / 10
        Return True

    End Function
    'Public Function GHADec()       'this was used up to V4.6.2 (V4.6.3)
    '    SH = 360 - AR
    '    GA = GR - AR
    '    If GA >= 360 Or GA < 0 Then GA = GA - Int(GA / 360) * 360
    '    SH = Int(SH * 10 + 0.5) / 10
    '    GRD = Int(AR): GRM = (AR - GRD) * 60: GRM = Int(GRM * 10 + 0.5) / 10
    '    RA = Int(AR * 10 + 0.5) / 10
    '    If DE = 0 Then HD = " "
    '    If DE > 0 Then HD = "N"
    '    If DE < 0 Then HD = "S"
    '    DF = Int(Abs(DE) * 10 + 0.5) / 10
    '    VD = Int(GA): VM = (GA - VD) * 60: VM = Int(VM * 10 + 0.5) / 10
    'End Function

    Public Sub AutoZDCalc()
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        ZD = Int(Lo / 15 + 0.5)
        If cboLo.Text = "E " Then ZD = -ZD
        If optZDAuto.Checked = True Then
            SignZD = "+" : If cboLo.Text = "E " Then SignZD = "-"
            txtZDh.Text = SignZD & System.Math.Abs(ZD)
        End If
        Exit Sub
    End Sub

    Public Sub EclipticToEquatorial()
        AR = System.Math.Atan((System.Math.Sin(L1) * System.Math.Cos(OETrue * Pi / 180) - System.Math.Tan(B) * System.Math.Sin(OETrue * Pi / 180)) / System.Math.Cos(L1)) 'radians
        If System.Math.Cos(L1) < 0 Then AR = AR + Pi
        If AR >= 2 * Pi Then AR = AR - 2 * Pi
        If AR < 0 Then AR = AR + 2 * Pi
        x = System.Math.Sin(B) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Cos(B) * System.Math.Sin(OETrue * Pi / 180) * System.Math.Sin(L1)
        DE = System.Math.Atan(x / (System.Math.Sqrt(-x * x + 1) + 9.999999E-21)) 'arcsin, radians
        'AR = AR * 180 / Pi
        'DE = DE * 180 / Pi
        Exit Sub

    End Sub

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
            Case Asc(",")
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
    Private Sub txtIEDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.Enter
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
    Private Sub txtIEmin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.Enter
        SelectAllText(txtIEmin)
    End Sub

    Public Function AltitudeCorrection() As Integer
        If optHsDMS.Checked = False Then txtHsSec.Text = "" : txtIESec.Text = ""
        ICMin = Val(txtIEmin.Text) + Val(txtIESec.Text) / 60
        If cboIE.Text = "on the arc" Then ICinMinutes = -(Val(txtIEdeg.Text) * 60 + ICMin)
        If cboIE.Text = "off the arc (rdg.)" Then
            ICMin = 60 - ICMin
            If ICMin = 60 Then ICMin = 0
            ICinMinutes = (Val(txtIEdeg.Text) - 1) * 60 + ICMin
        End If
        If cboIE.Text = "off the arc (val.)" Then ICinMinutes = Val(txtIEdeg.Text) * 60 + ICMin
        Corr1 = ICinMinutes - DipCalc()
        Corr1Deg = Int(System.Math.Abs(Corr1 / 60))
        Corr1Min = System.Math.Abs(Corr1) - 60 * Corr1Deg
        hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60



        'ICinMinutes = Val(txtIEdeg.Text) * 60 + Val(txtIEmin.Text)
        'If cboIE.Text = "on the arc" Then ICinMinutes = -ICinMinutes
        'Corr1 = ICinMinutes - Dip
        'Corr1Deg = Int(Abs(Corr1 / 60))
        'Corr1Min = Abs(Corr1) - 60 * Corr1Deg
        'If optHsDMS.Value = False Then txtHsSec.Text = ""
        'hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin) + Val(txtHsSec) / 60
        HsMin = Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        hainMinutes = hsinMinutes + Corr1
        'If optHorizonArtificial = True And hainMinutes >= 5400 Then _
        'MsgBox ("Back sight with artificial horizon not permitted."): BSwithAH = True: Exit Function
        If optHorizonArtificial.Checked = True Then hainMinutes = (hsinMinutes + ICinMinutes) / 2
        BackSight = False
        If hainMinutes >= 5400 Then hainMinutes = 10800 - hainMinutes : BackSight = True
        Refraction()
        '   HP = 0.14656956         'removed this line and added next line in V5.4.0 so more accurate parallax of Sun, not just average parallax,is computed
        HP = 60 * System.Math.Atan(0.0000426349651 / RN) * 180 / Pi '0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
        PA = HP * System.Math.Cos((hainMinutes / 60) * Pi / 180)
        If optCenter.Checked = True Then DI = 0
        If optCenter.Checked = True And optHoSRForm.Checked = True Then PA = 0
        Corr2Min = -r + PA 'R from Refraction
        '    Corr2Min = -Rstd + PA  'R from Refraction

        If optHoSRForm.Checked And GMonth >= 4 And GMonth <= 9 Then DI = 15.859 : PA = 0.145 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP'was 15.859 in V4.9.2, now matches SRF      'these five are the new ones
        If optHoSRForm.Checked And (GMonth < 4 Or GMonth > 9) Then DI = 16.1968 : PA = 0.148 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP

        'If optCenter = True Then DI = 0

        If optLower.Checked = True Then Corr2Min = Corr2Min + DI
        If optUpper.Checked = True Then Corr2Min = Corr2Min - DI
        If optUpper.Checked = True And GYear >= 1954 And GYear <= 1969 Then Corr2Min = Corr2Min - 1.2 '1.2' for irradiation


        'Corrections for SR Form format
        Main_Renamed = 0
        If optLower.Checked = True Then Main_Renamed = -Rstd + PA + DI
        If optUpper.Checked = True Then Main_Renamed = -Rstd + PA - DI
        If optCenter.Checked = True Then Main_Renamed = -Rstd

        'If optHoSRForm.Value Then Corr2Min = Main - Raddl        'NEEDED TO REMOVE THIS IN V5.1.1 BUT DID NOT UNTIL V5.1.2

        'Totals
        HoinMinutes = hainMinutes + Corr2Min 'minutes
        HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
        HoMin = System.Math.Abs(HoinMinutes - 60 * HoDeg)
        If Int(HoMin * 10 + 0.5) / 10 = 60 Then HoMin = 0 : HoDeg = HoDeg + 1
        haDeg = Fix(hainMinutes / 60) 'min. to dec. deg
        haMin = System.Math.Abs(hainMinutes - 60 * haDeg)
        If Int(haMin * 10 + 0.5) / 10 = 60 Then haMin = 0 : haDeg = haDeg + 1
        Return True
    End Function

    Public Sub DisplayNoonSight()
        DisplayLANTime()
        'Me.Font = VB6.FontChangeName(Me.Font, "Courier New")
        '   Cls        If optHorizonArtificial = False Then Print "(-)"; Tab(84); Format(Dip, "00.0"); Tab(88); "'" Else Print
        'Cls
        ClearScreen()
        'Form5.Font.Name = "Courier New"
        'DisplayLANTime
        'Print(TAB(16).Column, "ALTITUDE", TAB(44), "Latitude Computation")

        'Format AltitudeTxtBx text - alignment is center in textbox

        HE = txtHE.Text.ToString
        AltitudeTxtBx.AppendText(vbTab & vbTab & "ALTITUDE" & vbNewLine)
        Dim TextString As String = "Ht of eye" & vbTab & vbTab & HE.ToString("0.0") & vbTab & vbTab
        If cboHE.Text.ToString = "ft" Or cboHE.Text = "in" Then
            TextString &= "ft"
        ElseIf cboHE.Text = "m " Or cboHE.Text = "cm" Then
            TextString &= "m"
        Else
            TextString &= "ft"
        End If
        AltitudeTxtBx.AppendText(TextString & vbNewLine)
        TextString = vbNull

        TextString = "hs" & vbTab & vbTab & vbTab & vbTab & txtHsDeg.Text.ToString.Trim & Chr(176) & HsMin.ToString("00.0") & "'"
        If optHsDMS.Checked = True Then
            TextString &= txtHsSec.Text.ToString.Trim
        End If
        AltitudeTxtBx.AppendText(TextString & vbNewLine)
        TextString = vbNull

        TextString = vbTab & "IC" & vbTab & "("
        If ICinMinutes = 0 Then
            TextString &= " "
        ElseIf cboIE.Text = "on the arc" And ICinMinutes <> 0 Then
            TextString &= "-"
        ElseIf (cboIE.Text = "off the arc (rdg.)" Or cboIE.Text = "off the arc (val.)") And ICinMinutes <> 0 Then
            TextString &= "+"
        End If
        TextString &= ")" & vbTab
        Dim TempIEDeg As String = txtIEdeg.Text.ToString
        If TempIEDeg = "" Then
            TempIEDeg = "0"
        End If
        If (cboIE.Text = "on the arc" Or cboIE.Text = "off the arc (val.)") Then
            TextString &= TempIEDeg.ToString
        ElseIf cboIE.Text = "off the arc (rdg.)" Then
            TextString &= TempIEDeg.ToString
        End If
        TextString &= Chr(176) & ICMin.ToString("00.0") & "'" & vbNewLine
        AltitudeTxtBx.AppendText(TextString)
        TextString = vbNull

        If optHorizonArtificial.Checked = False Then
            TextString = vbTab & "Dip" & vbTab
            Dim LcLDip As Double = DipCalc()
            TextString &= "(-)" & vbTab & "     " & LcLDip.ToString("##0.0") & "'"
        End If
        TextString &= vbNewLine
        AltitudeTxtBx.AppendText(TextString)
        TextString = vbNull

        TextString = vbTab & "Corr" & vbTab & "("
        If Corr1 > 0 Then TextString &= "+"
        If Corr1 = 0 Then TextString &= " "
        If Corr1 < 0 Then TextString &= "-"
        TextString &= ")  " & vbTab & Corr1Deg.ToString("0") & Chr(176) & Corr1Min.ToString("00.0") & "'" & vbNewLine
        AltitudeTxtBx.AppendText(TextString)
        TextString = vbNull

        TextString = "ha" & vbTab & vbTab & vbTab & vbTab
        If System.Math.Sign(hainMinutes) = -1 Then
            TextString &= "-"
        Else
            TextString &= " "
        End If
        TextString &= (System.Math.Abs(haDeg)).ToString("0") & Chr(176) & haMin.ToString("00.0") & "'" & vbNewLine
        AltitudeTxtBx.AppendText(TextString)
        TextString = vbNull

        If optHoSRForm.Checked = True Then
            AltitudeTxtBx.AppendText(vbTab & "Main" & vbTab & "(")
            If Main_Renamed > 0 Then
                AltitudeTxtBx.AppendText(" + ")
            End If
            If Main_Renamed = 0 Then
                AltitudeTxtBx.AppendText(" ")
            End If
            If Main_Renamed < 0 Then
                AltitudeTxtBx.AppendText("-")
            End If
            AltitudeTxtBx.AppendText(")" & vbTab & (Int(System.Math.Abs(Main_Renamed * 10) + 0.5) / 10).ToString("00.0") & "'" & vbNewLine)
        End If

        If optHoSRForm.Checked And optDRL.Checked = False Then
            AltitudeTxtBx.AppendText(vbNewLine)
        End If

        If optHoParameters.Checked Then
            AltitudeTxtBx.AppendText(vbTab & "Refraction" & vbTab & "(-)" & vbTab & (Int(r * 1000 + 0.5) / 1000).ToString("00.000") & "'" & vbNewLine)
        End If

        If optHoSRForm.Checked = True Then
            AltitudeTxtBx.AppendText(vbTab & "Add'l Ref" & vbTab)
            If optStdTPNo.Checked = True And System.Math.Sign(Raddl) = 1 Then
                AltitudeTxtBx.AppendText("(-)" & vbTab & (System.Math.Abs(Raddl)).ToString("0.0") & "'" & vbNewLine)
            End If
            If optStdTPNo.Checked = True And System.Math.Sign(Raddl) = -1 Then
                AltitudeTxtBx.AppendText("(+)" & vbTab & (System.Math.Abs(Raddl)).ToString("0.0") & "'" & vbNewLine)
            End If
            If OptStdTPYes.Checked = True Then
                AltitudeTxtBx.AppendText(vbNewLine)
            End If
        End If

        If optHoParameters.Checked = True Then
            AltitudeTxtBx.AppendText(vbTab & "Parallax" & vbTab & "(+)" & vbTab & PA.ToString("00.000") & "'" & vbNewLine)
        End If
        If optHoSRForm.Checked Then
            AltitudeTxtBx.AppendText(vbNewLine)
        End If
        If optHoParameters.Checked = True And optCenter.Checked = False Then
            AltitudeTxtBx.AppendText(vbTab & "Semi-diameter" & vbTab)
            If optLower.Checked = True Then
                AltitudeTxtBx.AppendText("(+)")
            End If
            If optUpper.Checked = True Then
                AltitudeTxtBx.AppendText("(-)")
            End If
            AltitudeTxtBx.AppendText(vbTab & DI.ToString("00.000") & "'" & vbNewLine)
        End If
        If optHoParameters.Checked = True And optCenter.Checked = True Then
            AltitudeTxtBx.AppendText(vbNewLine)
        End If

        AltitudeTxtBx.AppendText(vbTab & "Corr" & vbTab & "(")
        If Corr2Min > 0 Then
            AltitudeTxtBx.AppendText("+")
        End If
        If Corr2Min = 0 Then
            AltitudeTxtBx.AppendText(" ")
        End If
        If Corr2Min < 0 Then
            AltitudeTxtBx.AppendText("-")
        End If
        AltitudeTxtBx.AppendText(")" & vbTab & (System.Math.Abs(Corr2Min)).ToString("00.0") & "'" & vbNewLine)

        AltitudeTxtBx.AppendText("Ho" & vbTab & vbTab & vbTab & vbTab)
        If System.Math.Sign(HoinMinutes) = -1 Then
            AltitudeTxtBx.AppendText("- ")
        Else
            AltitudeTxtBx.AppendText("  ")
        End If
        AltitudeTxtBx.AppendText((System.Math.Abs(HoDeg)).ToString("0") & Chr(176) & HoMin.ToString("00.0") & "'" & vbNewLine)

        If optHorizonArtificial.Checked = True Then
            AltitudeTxtBx.AppendText(" ha adjusted for artificial horizon")
        End If
        If BackSight = True And optHorizonArtificial.Checked = False Then
            AltitudeTxtBx.AppendText("    ha adjusted for back sight")
        End If
        If optHorizonArtificial.Checked = False And BackSight = False Then
            'AltitudeTxtBx.AppendText(vbNewLine)
        End If


        ' format LatitudeTxtBx text - alignment is center in textbox
        LatitudeTxtBx.ResetText()
        LatTxtLeft.ResetText()
        LatTxtRight.ResetText()

        LatitudeTxtBx.AppendText("Latitude Computation" & vbNewLine)
        LatTxtLeft.AppendText("Z" & vbNewLine)
        LatTxtRight.AppendText("89" & Chr(176) & "60.0'" & vbNewLine)

        LatTxtLeft.AppendText("Ho (-)" & vbNewLine)
        If System.Math.Sign(HoinMinutes) = -1 Then
            LatTxtRight.AppendText("-")
        End If
        LatTxtRight.AppendText((System.Math.Abs(HoDeg)).ToString("0") & Chr(176) & HoMin.ToString("00.0") & "'" & vbNewLine)

        LatTxtLeft.AppendText("z" & vbNewLine)
        LatTxtRight.AppendText(ZenithDistDeg.ToString("0") & Chr(176) & ZenithDistMin.ToString("00.0") & "'" & vbNewLine)

        LatTxtLeft.AppendText("Dec (" & dh & ")" & vbNewLine)
        TextString = TotDecDegrees.ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
        If TotDE > 0 Then TextString &= "N"
        If TotDE = 0 Then TextString &= " "
        If TotDE < 0 Then TextString &= "S"
        LatTxtRight.AppendText(TextString & vbNewLine)
        TextString = vbNull

        LatTxtLeft.AppendText("Lat" & vbNewLine)
        LatTxtRight.AppendText(LDeg.ToString("0") & Chr(176) & LMin.ToString("00.0") & "'" & LH & vbNewLine)

        If optDRL.Checked = True Then
            LatTxtLeft.AppendText("DR Lat" & vbNewLine)
            LatTxtRight.AppendText(Val(txtDRLDeg.Text).ToString("0") & Chr(176) & Val(DRLMin).ToString("00.0") & "'" & cboDRL.Text & vbNewLine)
        End If


        If optDRL.Checked = True Then
            LatTxtLeft.AppendText("l diff" & vbNewLine)
            LatTxtRight.AppendText(Ldiff.ToString("##0.0") & "'" & vbNewLine)
        End If

        'Print("Ht of eye", TAB(15), HE.ToString("0.0"), TAB(25))
        'If cboHE.Text = "ft" Or cboHE.Text = "in" Then Print("ft")
        'If cboHE.Text = "m " Or cboHE.Text = "cm" Then Print("m")
        'Print(TAB(49).Column, "Z  89" & Chr(176) & "60.0'")
        'Print("hs", TAB(32 - Len(Str(Val(txtHsDeg.Text)))), txtHsDeg.Text.ToString("0") & Chr(176) & HsMin.ToString("00.0") & "'")
        'If optHsDMS.Value = True Then Print Format(Val(txtHsSec.Text), "00")
        'If optHsDMS.Value = False Then Print
        'Print(TAB(44).Column, "Ho (-)")
        'If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(54 - Len(Str(HoDeg))), "-")
        'Print(TAB(55 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(HoMin, "00.0") & "'")
        'Print(TAB(4), "IC", TAB(18), "(")
        'If ICinMinutes = 0 Then Print(" ")
        'If cboIE.Text = "on the arc" And ICinMinutes <> 0 Then Print("-")
        'If (cboIE.Text = "off the arc (rdg.)" Or cboIE.Text = "off the arc (val.)") And ICinMinutes <> 0 Then Print("+")
        'Print(")", TAB(22))
        'If (cboIE.Text = "on the arc" Or cboIE.Text = "off the arc (val.)") Then Print(VB6.Format(Val(txtIEdeg.Text), "0"))
        'If cboIE.Text = "off the arc (rdg.)" Then Print(VB6.Format(Val(txtIEdeg.Text) - 1, "0"))
        'Print(TAB(23), Chr(176) & VB6.Format(ICMin, "00.0"), TAB(28), "'", TAB(49), "z", TAB(55 - Len(Str(ZenithDistDeg))), VB6.Format(ZenithDistDeg, "0") & Chr(176) & VB6.Format(ZenithDistMin, "00.0") & "'")
        'Print(TAB(4), "Dip", TAB(18))
        'If optHorizonArtificial.Checked = False Then Print("(-)", TAB(27 - Len(Str(Int(Dip)))), VB6.Format(Dip, "##0.0"), TAB(28), "'")
        'Print(TAB(43), "Dec (" & dh & ")", TAB(55 - Len(Str(TotDecDegrees))), VB6.Format(TotDecDegrees, "0") & Chr(176) & VB6.Format(TotDecMinutes, "00.0") & "'")
        'If TotDE > 0 Then Print("N")
        'If TotDE = 0 Then Print(" ")
        'If TotDE < 0 Then Print("S")
        'Print(TAB(7), "Corr", TAB(18), "(")
        'If Corr1 > 0 Then Print("+")
        'If Corr1 = 0 Then Print(" ")
        'If Corr1 < 0 Then Print("-")
        'Print(")", TAB(22), VB6.Format(Corr1Deg, "0"), TAB(23), Chr(176) & VB6.Format(Corr1Min, "00.0") & "'", TAB(47), "Lat", TAB(55 - Len(Str(LDeg))), VB6.Format(LDeg, "0") & Chr(176) & VB6.Format(LMin, "00.0") & "'" & LH)
        'Print("ha")
        'If System.Math.Sign(hainMinutes) = -1 Then Print(TAB(31 - Len(Str(haDeg))), "-")
        'Print(TAB(32 - Len(Str(haDeg))), VB6.Format(System.Math.Abs(haDeg), "0") & Chr(176) & VB6.Format(haMin, "00.0") & "'")
        'If optDRL.Checked = True Then Print(TAB(44), "DR Lat", TAB(55 - Len(Str(Val(txtDRLDeg.Text)))), VB6.Format(Val(txtDRLDeg.Text), "0") & Chr(176) & VB6.Format(Val(DRLMin), "00.0") & "'" & cboDRL.Text)
        'If optHoSRForm.Checked Then Print(TAB(4), "Main", TAB(18), "(")
        'If optHoSRForm.Checked And Main_Renamed > 0 Then Print("+")
        'If optHoSRForm.Checked And Main_Renamed = 0 Then Print(" ")
        'If optHoSRForm.Checked And Main_Renamed < 0 Then Print("-")
        'If optHoSRForm.Checked Then Print(")", TAB(24), VB6.Format(Int(System.Math.Abs(Main_Renamed * 10) + 0.5) / 10, "00.0") & "'")
        'If optHoSRForm.Checked And optDRL.Checked = False Then Print()
        'If optHoParameters.Checked Then Print(TAB(4), "Refraction", TAB(18), "(-)", TAB(24), VB6.Format(Int(r * 1000 + 0.5) / 1000, "00.000") & "'")
        'If optDRL.Checked = True Then Print(TAB(44), "l diff", TAB(60 - Len(Str(Int(Ldiff * 10 + 0.5) / 10))), VB6.Format(Ldiff, "##0.0") & "'")
        'If optHoSRForm.Checked Then Print(TAB(4), "Add'l Ref", TAB(18))
        'If optHoSRForm.Checked And optStdTPNo.Checked = True And System.Math.Sign(Raddl) = 1 Then Print("(-)", TAB(25), VB6.Format(System.Math.Abs(Raddl), "0.0") & "'")
        'If optHoSRForm.Checked And optStdTPNo.Checked = True And System.Math.Sign(Raddl) = -1 Then Print("(+)", TAB(25), VB6.Format(System.Math.Abs(Raddl), "0.0") & "'")
        'If optHoSRForm.Checked And OptStdTPYes.Checked = True Then Print()
        'If optHoParameters.Checked Then Print(TAB(4), "Parallax", TAB(18), "(+)", TAB(24), VB6.Format(PA, "00.000") & "'")
        'If optHoSRForm.Checked Then Print()
        'If optHoParameters.Checked And optCenter.Checked = False Then
        '    Print(TAB(4), "Semi-diameter", TAB(18))
        '    If optLower.Checked = True Then Print("(+)")
        '    If optUpper.Checked = True Then Print("(-)")
        '    Print(TAB(24), VB6.Format(DI, "00.000") & "'")
        'End If
        'If optHoParameters.Checked And optCenter.Checked = True Then Print()
        'Print(TAB(7), "Corr", TAB(18), "(")
        'If Corr2Min > 0 Then Print("+")
        'If Corr2Min = 0 Then Print(" ")
        'If Corr2Min < 0 Then Print("-")
        'Print(")", TAB(24), VB6.Format(System.Math.Abs(Corr2Min), "00.0") & "'")

        'Print("Ho")
        'If System.Math.Sign(HoinMinutes) = -1 Then Print(TAB(31 - Len(Str(HoDeg))), "-")
        'Print(TAB(32 - Len(Str(HoDeg))), VB6.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & VB6.Format(HoMin, "00.0") & "'")
        ''Print
        'If optHorizonArtificial.Checked = True Then Print(" ha adjusted for artificial horizon")
        'If BackSight = True And optHorizonArtificial.Checked = False Then Print("    ha adjusted for back sight")
        'If optHorizonArtificial.Checked = False And BackSight = False Then Print()
        ''Print
        'Print(TAB(12), "ALMANAC - Dec")


        ' alamanc text box  formatting - alignment is centered
        AlmanacTxtBx.AppendText("ALMANAC - Dec" & vbNewLine)

        AlmanacTxtBx.AppendText("Dec " & GHourLAN.ToString("00") & Space(2) & "hr" & vbTab & (System.Math.Abs(DecDegrees)).ToString("0") & Chr(176) & DecMinutes.ToString("00.0") & "'")
        If DE * 60 >= 0.05 Then
            AlmanacTxtBx.AppendText("N" & vbNewLine)
        End If
        If System.Math.Abs(DE * 60) < 0.05 Then
            AlmanacTxtBx.AppendText(" " & vbNewLine)
        End If
        If DE * 60 < 0.05 Then
            AlmanacTxtBx.AppendText("S" & vbNewLine)
        End If

        AlmanacTxtBx.AppendText("d (")
        If Signdvalue = 0 Then
            AlmanacTxtBx.AppendText(" ) ")
        ElseIf Signdvalue = 1 Then
            AlmanacTxtBx.AppendText("+) ")
        ElseIf Signdvalue = -1 Then
            AlmanacTxtBx.AppendText("-) ")
        End If
        AlmanacTxtBx.AppendText(vbTab & vbTab & (System.Math.Abs(dvalue)).ToString("0.0") & "'" & vbNewLine)

        'Lendcorr = Len(Str(dcorr)) : If Lendcorr < 4 Then Lendcorr = 4
        AlmanacTxtBx.AppendText("d corr (")
        If Signdvalue = 0 Then
            AlmanacTxtBx.AppendText(" ) ")
        ElseIf Signdvalue = 1 Then
            AlmanacTxtBx.AppendText("+) ")
        ElseIf Signdvalue = -1 Then
            AlmanacTxtBx.AppendText("-) ")
        End If
        AlmanacTxtBx.AppendText(vbTab & vbTab & dcorr.ToString("0.0") & "'" & vbNewLine)

        AlmanacTxtBx.AppendText("Dec" & vbTab & vbTab & (System.Math.Abs(TotDecDegrees)).ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'")
        If TotDE > 0 Then
            AlmanacTxtBx.AppendText("N")
        End If
        If TotDE = 0 Then
            AlmanacTxtBx.AppendText(" ")
        End If
        If TotDE < 0 Then
            AlmanacTxtBx.AppendText("S")
        End If
        AlmanacTxtBx.AppendText(vbNewLine)
        'DisplayLANTime
    End Sub

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
            Rstd = r 'added in 5.1.5
        End If
        'R = -0.97 * Tan(((y * Pi / 180) - Atn(12 * (y + 3))))   'formula from The Calculator Afloat - better for some values of y (ha)
        '        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then RstdTP = Rstd Else RstdTP = r   'removed in 5.1.5
        RstdTP = r 'replaced previous line in 5.1.5
        'End If
        If r < 0 Then r = 0 'This line added to get rid of negative values at very high altitudes under certain circumstances
        '    Rstd = r    'Standard refraction before temperature and pressure applied
        r = r * (283 / 1010) * PX / (TX + 273) 'PX=1010, TX=10    Total Refraction    Constant was 0.28019802
        Raddl = r - RstdTP
        ''    Rstd = RstdTP       'to make the proper Main correction print     removed in 5.1.5
        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then Rstd = RstdA2
    End Sub

    Public Function DipCalc() As Double
        Dim Dip As Double = 0
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
        Return Dip
    End Function

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
                optCenter.Visible = True
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
                optCenter.Visible = False
            End If
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
                optCenter.Visible = False
            End If
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

    Public Function LatCalc() As Integer
        'TotDE = TotDecDegrees + TotDecMinutes / 60
        ZenithDistinDeg = ZenithDistDeg + ZenithDistMin / 60
        SunAzN = False : SunAzS = False
        If optAzN.Checked = True Then SunAzN = True
        If optAzS.Checked = True Then SunAzS = True
        If optDRL.Checked = True Then Latitude()
        If optDRL.Checked = True And DRL >= TotDE Then SunAzS = True
        If optDRL.Checked = True And DRL < TotDE Then SunAzN = True
        If SunAzN = True And TotDE >= 0 And ZenithDistinDeg < System.Math.Abs(TotDE) Then Lat = System.Math.Abs(TotDE) - ZenithDistinDeg : LH = "N" : dh = "-"
        If SunAzN = True And TotDE >= 0 And ZenithDistinDeg >= System.Math.Abs(TotDE) Then Lat = ZenithDistinDeg - System.Math.Abs(TotDE) : LH = "S" : dh = "-"
        If SunAzN = True And TotDE < 0 Then Lat = ZenithDistinDeg + System.Math.Abs(TotDE) : LH = "S" : dh = "+"
        If SunAzS = True And TotDE >= 0 Then Lat = System.Math.Abs(TotDE) + ZenithDistinDeg : LH = "N" : dh = "+"
        If SunAzS = True And TotDE < 0 And ZenithDistinDeg >= System.Math.Abs(TotDE) Then Lat = ZenithDistinDeg - System.Math.Abs(TotDE) : LH = "N" : dh = "-"
        If SunAzS = True And TotDE < 0 And ZenithDistinDeg < System.Math.Abs(TotDE) Then Lat = System.Math.Abs(TotDE) - ZenithDistinDeg : LH = "S" : dh = "-"
        If Lat = 0 Then LH = " "
        'Lat = Abs(Lat)
        If LH = "S" Then Lat = -Lat
        LDeg = Int(System.Math.Abs(Lat)) : LMin = (System.Math.Abs(Lat) - LDeg) * 60
        If LMin = 60 Then LMin = 0 : LDeg = LDeg + 1
        If System.Math.Sign(Lat) = System.Math.Sign(DRL) Then Ldiff = System.Math.Abs(Lat - DRL)
        If System.Math.Sign(Lat) <> System.Math.Sign(DRL) Then Ldiff = System.Math.Abs(Lat) + System.Math.Abs(DRL)
        Ldiff = 60 * Ldiff
        'ldiffDeg = Int(LDiff): ldiffMin = (LDiff - ldiffDeg) * 60
        'If ldiffMin = 60 Then ldiffMin = 0: ldiffDeg = ldiffDeg + 1
        Return True
    End Function

    Public Sub DisplayLANTime()
        Dim Fld1Len As Integer = (LANTimeTxtBx.ToString.Length / 2)
        Dim TempStr1 As String = Space(Fld1Len)
        Dim TempStr2 As String = Space(Fld1Len)
        ZD = System.Math.Abs(Val(txtZDh.Text))
        If optZDManual.Checked = False Then ZDMan = ZD
        If optZDManual.Checked = True Then ZDMan = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
        If VB.Left(txtZDh.Text, 1) = "-" Then ZDMan = -ZDMan : ZD = -ZD
        'GHour = GHour - 1   'corrects GHour for additional hour added in Greenwich
        If chkDST.CheckState = 1 Then ZD = ZD - 1
        ZDMan = ZDMan - 1 ': GHour = GHour - 1

        'NEED TO DO TEXT ALIGNMENT IF DO NOT WANT LEADING ZEROS ON Lo AND GHA
        'Cls
        If cboLo.Text = "W " Then LoforLAN = Lo Else LoforLAN = 360 - System.Math.Abs(Lo)
        LoforLANDeg = Int(LoforLAN) : LoforLANMin = (LoforLAN - LoforLANDeg) * 60 : LoforLANMin = Int(LoforLANMin * 10 + 0.5) / 10
        'Form5.Font.Name = "MS Sans Serif"
        'Font = VB6.FontChangeName(Font, "Courier New")
        LANTimeTxtBx.ResetText()
        LANTimeTxtLeft.ResetText()
        LANTimeTxtRight.ResetText()


        LANTimeTxtBx.AppendText("TIME OF LAN" & vbNewLine)

        If cboLo.Text = "E " Then
            TempStr1 = ("360" & Chr(176) & " - LoE")
        Else
            TempStr1 = ("LoW")
        End If

        TempStr2 = LoforLANDeg.ToString("##0") & Chr(176) & LoforLANMin.ToString("00.0") & "'"
        LANTimeTxtLeft.AppendText(TempStr1 & vbNewLine)
        LANTimeTxtRight.AppendText(TempStr2 & vbNewLine)

        LANTimeTxtLeft.AppendText("GHA Sun " & GHourLAN.ToString("00") & " h" & vbNewLine)
        LANTimeTxtRight.AppendText(GHADeg.ToString("##0") & Chr(176) & GHAMin.ToString("00.0") & "'" & vbNewLine)

        'GHADiff = LoforLAN - GA: If GHADiff < 0 Then GHADiff = GHADiff + 360
        '    GHADiff = LoforLAN - GHAHour: If GHADiff < 0 Then GHADiff = GHADiff + 360

        GHADiffDeg = Int(GHADiff) : GHADiffMin = (GHADiff - GHADiffDeg) * 60 : GHADiffMin = Int(GHADiffMin * 10 + 0.5) / 10
        If GHADiffMin = 60 Then
            GHADiffMin = 0
            GHADiffDeg = GHADiffDeg + 1
        End If
        LANTimeTxtLeft.AppendText("GHA Difference" & vbNewLine)
        LANTimeTxtRight.AppendText(GHADiffDeg.ToString("##0") & Chr(176) & GHADiffMin.ToString("00.0") & "'" & vbNewLine)
        'LANTime = 4 * GHADiff           'maybe use GHADiffDeg and GHADiffMin (already rounded); LANTime is a bad name
        LANTime = 4 * (GHADiffDeg + GHADiffMin / 60) 'LANTime is a bad name
        LANMinutes = Int(LANTime)
        LANSeconds = Int((LANTime - LANMinutes) * 60 + 0.5)

        LANTimeTxtLeft.AppendText(vbNewLine)
        LANTimeTxtRight.AppendText("m " & LANMinutes.ToString("00") & " s " & LANSeconds.ToString("00") & vbNewLine)

        LANTimeTxtLeft.AppendText("UT of LAN   " & vbNewLine)
        LANTimeTxtRight.AppendText(GHourLANDisplay.ToString("00") & "-" & LANMinutes.ToString("00") & "-" & LANSeconds.ToString("00") & vbNewLine)

        LANTimeTxtLeft.AppendText("ZD" & "(")
        If optZDManual.Checked = False Then
            If System.Math.Sign(ZD) = 1 Then LANTimeTxtLeft.AppendText("+")
            If System.Math.Sign(ZD) = -1 Then LANTimeTxtLeft.AppendText("-")
            If System.Math.Sign(ZD) = 0 Then LANTimeTxtLeft.AppendText(" ")
        End If
        If optZDManual.Checked = True Then
            If System.Math.Sign(ZDMan) = 1 Then LANTimeTxtLeft.AppendText("+")
            If System.Math.Sign(ZDMan) = -1 Then LANTimeTxtLeft.AppendText("-")
            If System.Math.Sign(ZDMan) = 0 Then LANTimeTxtLeft.AppendText(" ")
        End If
        LANTimeTxtLeft.AppendText(")" & vbNewLine)

        LANTimeTxtRight.AppendText((System.Math.Abs(ZD)).ToString("#0")) 'Format(Abs(Val(txtZDh.Text)), "00");
        If optZDManual.Checked = True And cboZDm.Text <> "00" Then LANTimeTxtBx.AppendText("-" & cboZDm.Text)
        If optZDManual.Checked = True And cboZDm.Text <> "00" Then
            LANTimeTxtRight.AppendText("   (rev)")
        Else
            LANTimeTxtRight.AppendText("   (rev)")
        End If
        LANTimeTxtRight.AppendText(vbNewLine)

        ZTofLAN = (3600 * CInt(GHourLANDisplay) + 60 * CInt(LANMinutes) + CInt(LANSeconds) - 3600 * ZD) / 3600
        If ZTofLAN < 0 Then ZTofLAN = ZTofLAN + 24
        If ZTofLAN >= 24 Then ZTofLAN = ZTofLAN - 24
        If optZDManual.Checked = True Then ZTofLAN = (3600 * CInt(GHourLAN) + 60 * CInt(LANMinutes) + CInt(LANSeconds) - 3600 * ZDMan) / 3600 'Int(Lo / 15 + 0.5) is AutoZD
        ZTofLANHours = Int(ZTofLAN)
        ZTofLANMinutes = Int(((ZTofLAN - CInt(ZTofLANHours)) * 3600) / 60)
        ZTofLANSeconds = (ZTofLAN - CInt(ZTofLANHours)) * 3600 - ZTofLANMinutes * 60
        If ZTofLANSeconds >= 60 Then ZTofLANSeconds = ZTofLANSeconds - 60 : ZTofLANMinutes = ZTofLANMinutes + 1
        If ZTofLANMinutes >= 60 Then ZTofLANMinutes = ZTofLANMinutes - 60 : ZTofLANHours = ZTofLANHours + 1
        LANTimeTxtLeft.AppendText("ZT of LAN   " & vbNewLine)

        LANTimeTxtRight.AppendText(ZTofLANHours.ToString("00") & "-" & ZTofLANMinutes.ToString("00") & "-" & ZTofLANSeconds.ToString("00") & vbNewLine)
        Exit Sub
    End Sub

    Private Sub txtLoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoDeg.Text) > 180 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub txtYear_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtYear.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub cboDay_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles cboDay.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtDay.Text) > 31 Then
        '    KeepFocus = True
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub txtZDh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh.Text) < -13 Or Val(txtZDh.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    'UPGRADE_WARNING: Event optStdTPYes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optStdTPYes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptStdTPYes.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
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
        If eventSender.Checked And eventSender.Text <> "" Then
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

    'UPGRADE_WARNING: Event cboTemperature.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboTemperature_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemperature.SelectedIndexChanged
        If cboTemperature.Text = "F " Then txtTemperature.Text = "50"
        If cboTemperature.Text = "C " Then txtTemperature.Text = "10"
        txtTemperature_TextChanged(txtTemperature, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event cboPressure.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboPressure_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPressure.SelectedIndexChanged
        If cboPressure.Text = "in Hg" Then txtPressure.Text = "29.83"
        If cboPressure.Text = "mbar" Then txtPressure.Text = "1010"
        txtPressure_TextChanged(txtPressure, New System.EventArgs())
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
            MsgBox("OutofRange")
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
        If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) And Len(txtPressure.Text) >= 4 And optStdTPNo.Checked = True Then 'optStdTPNo = True added for bug going back to standard
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("OutofRange")
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

    Private Sub txtPressure_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPressure.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 26 Or Val(txtPressure.Text) > 32) Then
        '        KeepFocus = True
        '    End If
        '    If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtPressure_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.Enter
        SelectAllText(txtPressure)
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
        '    Static bDecimalPointUsedUp As Boolean
        Static bMinusSignAlready As Boolean
        '    bDecimalPointUsedUp = False
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

    Private Sub txtTemperature_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTemperature.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
        '        KeepFocus = True
        '    End If
        '    If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTemperature_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.Enter
        SelectAllText(txtTemperature)
    End Sub

    Public Sub Latitude()
        'Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
        DRLMin = Replace(txtDRLMin.Text, ",", ".")
        DRL = Val(txtDRLDeg.Text) + Val(DRLMin) / 60
        If cboDRL.Text = "S " Then DRL = -DRL
    End Sub

    Public Sub DisplayMeridianDiagram()
        'Dim XMD1, YMD1 As Single
        'Dim XMD2, YMD2 As Single
        Dim TwoPi, i As Single
        'Form1.Font.Name = "MS Sans Serif"
        TwoPi = 8 * System.Math.Atan(1)
        'Me.Scale(-5600, 7890) - (1750, -630)
        'DrawStyle = 0
        Dim bm As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim meridgraphic As Graphics = Graphics.FromImage(bm)

        meridgraphic.TranslateTransform(Me.Width / 2, Me.Height / 2)
        meridgraphic.RotateTransform(180)

        Dim DPen As Pen = New Pen(Color.Black, 2)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = 0
        ' draw circle arc for meridian diagram
        'meridgraphic.DrawArc(DPen, 0, 0, MeridianPicBx.Width, MeridianPicBx.Height, 0, 180)
        'Me.Circle(0, 0), 1400, 0, 0, TwoPi / 2
        'Me.Line(-1400, 0) - (1400, 0)
        ' set up and draw line across bottom of cicle arc
        ptA.X = -(MeridianPicBx.Width)
        ptA.Y = 0
        ptB.X = (MeridianPicBx.Width)
        ptB.Y = 0
        meridgraphic.DrawLine(DPen, ptA, ptB)
        '  setup and draw verticle Y axis to circle arc
        ptA.X = 0
        ptA.Y = 0
        ptB.X = 0
        ptB.Y = MeridianPicBx.Width
        meridgraphic.DrawLine(DPen, ptA, ptB)
        'Me.Line(0, 0) - (0, 1400)
        ' setup and draw tick marks on circle arc 
        Dim DrawFrom As Integer = (MeridianPicBx.Width)
        Dim DrawTo As Integer = (MeridianPicBx.Width) + 2
        For i = 0 To TwoPi / 2 Step TwoPi / 288
            ptA.X = DrawFrom * System.Math.Cos(i)
            ptA.Y = DrawFrom * System.Math.Sin(i)
            ptB.X = DrawTo * System.Math.Cos(i)
            ptB.Y = DrawTo * System.Math.Sin(i)    ' 1350 to 1400 
            'Me.Line(XMD1, YMD1) - (XMD2, YMD2)
            meridgraphic.DrawLine(DPen, ptA, ptB)
        Next i
        DrawFrom = (MeridianPicBx.Width)
        DrawTo = (MeridianPicBx.Width) + 5
        For i = 0 To TwoPi / 2 Step TwoPi / 72
            ptA.X = DrawFrom * System.Math.Cos(i)
            ptA.Y = DrawFrom * System.Math.Sin(i)
            ptB.X = DrawTo * System.Math.Cos(i)
            ptB.Y = DrawTo * System.Math.Sin(i)    ' 1350 to 1400 
            'Me.Line(XMD1, YMD1) - (XMD2, YMD2)
            meridgraphic.DrawLine(DPen, ptA, ptB)
        Next i
        DrawFrom = (MeridianPicBx.Width)
        DrawTo = (MeridianPicBx.Width) + 10
        For i = 0 To TwoPi / 2 Step TwoPi / 36
            ptA.X = DrawFrom * System.Math.Cos(i)
            ptA.Y = DrawFrom * System.Math.Sin(i)
            ptB.X = DrawTo * System.Math.Cos(i)
            ptB.Y = DrawTo * System.Math.Sin(i) ' from 1300 to 1350 
            'Me.Line(XMD1, YMD1) - (XMD2, YMD2)
            meridgraphic.DrawLine(DPen, ptA, ptB)
        Next i
        lblN.Visible = True
        lblS.Visible = True
        lblZ.Visible = True
        'Equator
        'Me.Line(0, 0) - (1400 * System.Math.Cos((90 - Lat) * Pi / 180), 1400 * System.Math.Sin((90 - Lat) * Pi / 180))
        ptA.X = 0 'Me.Width / 2
        ptA.Y = 0
        ptB.X = (MeridianPicBx.Width) * System.Math.Cos((90 - Lat) * Pi / 180)
        ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((90 - Lat) * Pi / 180)
        meridgraphic.DrawLine(DPen, ptA, ptB)
        'DrawStyle = 5
        'DPen.DashStyle = Drawing2D.DashStyle.Dash
        'Me.Line(0, 0) - (1600 * System.Math.Cos((90 - Lat) * Pi / 180), 1600 * System.Math.Sin((90 - Lat) * Pi / 180))
        ptA.X = 0 'Me.Width / 2
        ptA.Y = 0
        ptB.X = (MeridianPicBx.Width) * System.Math.Cos((90 - Lat) * Pi / 180)
        ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((90 - Lat) * Pi / 180)
        meridgraphic.DrawLine(DPen, ptA, ptB)
        'CurrentY = CurrentY + 200
        ptB.X = -((MeridianPicBx.Width) * System.Math.Cos((90 - Lat) * Pi / 180) + 15)
        ptB.Y = -((MeridianPicBx.Width) * System.Math.Sin((90 - Lat) * Pi / 180) + 15)
        meridgraphic.RotateTransform(180)
        meridgraphic.DrawString("Q ", LatitudeTxtBx.Font, DPen.Brush, ptB)
        meridgraphic.RotateTransform(180)
        'Print("Q")
        'DPen.DashStyle = Drawing2D.DashStyle.Solid

        'DrawStyle = 0
        'North Pole
        If System.Math.Sign(Lat) = 1 Or System.Math.Sign(Lat) = 0 Then
            'Me.Line(0, 0) - (1400 * System.Math.Cos((180 - Lat) * Pi / 180), 1400 * System.Math.Sin((180 - Lat) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((180 - Lat) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((180 - Lat) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'DrawStyle = 5
            'DPen.DashStyle = Drawing2D.DashStyle.Dash
            'Me.Line(0, 0) - (1600 * System.Math.Cos((180 - Lat) * Pi / 180), 1600 * System.Math.Sin((180 - Lat) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((180 - Lat) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((180 - Lat) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'CurrentY = CurrentY + 150
            ptB.X = -((MeridianPicBx.Width) * System.Math.Cos((180 - Lat) * Pi / 180) + 15)
            ptB.Y = -((MeridianPicBx.Width) * System.Math.Sin((180 - Lat) * Pi / 180) + 15)
            'Print("Pn")
            meridgraphic.RotateTransform(180)
            meridgraphic.DrawString("Pn", LatitudeTxtBx.Font, DPen.Brush, ptB)
            meridgraphic.RotateTransform(180)
        End If
        'South Pole
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        If System.Math.Sign(Lat) = -1 Then
            'Me.Line(0, 0) - (1400 * System.Math.Cos((-Lat) * Pi / 180), 1400 * System.Math.Sin((-Lat) * Pi / 180))
            ptA.X = 0 ' Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((-Lat) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((-Lat) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'DrawStyle = 5
            DPen.DashStyle = Drawing2D.DashStyle.Dash
            'Me.Line(0, 0) - (1500 * System.Math.Cos((-Lat) * Pi / 180), 1500 * System.Math.Sin((-Lat) * Pi / 180))
            ptA.X = 0 'me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((-Lat) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((-Lat) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'CurrentY = CurrentY + 150
            ptB.X = -((MeridianPicBx.Width) * System.Math.Cos((-Lat) * Pi / 180) + 15)
            ptB.Y = -((MeridianPicBx.Width) * System.Math.Sin((-Lat) * Pi / 180) + 15)
            meridgraphic.RotateTransform(180)
            meridgraphic.DrawString("Ps", LatitudeTxtBx.Font, DPen.Brush, ptB)
            meridgraphic.RotateTransform(180)
            'Print("Ps")
            meridgraphic.DrawString("Ps", LatitudeTxtBx.Font, DPen.Brush, ptB)
        End If
        'Sun
        If optAzS.Checked = True Or (optDRL.Checked = True And DRL >= DE) Then
            'DrawStyle = 0
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            'Me.Line(0, 0) - (1400 * System.Math.Cos((HoinMinutes / 60) * Pi / 180), 1400 * System.Math.Sin((HoinMinutes / 60) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((HoinMinutes / 60) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((HoinMinutes / 60) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'DrawStyle = 5
            DPen.DashStyle = Drawing2D.DashStyle.Dash
            'Me.Line(0, 0) - (1550 * System.Math.Cos((HoinMinutes / 60) * Pi / 180), 1550 * System.Math.Sin((HoinMinutes / 60) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos((HoinMinutes / 60) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin((HoinMinutes / 60) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
        End If
        If optAzN.Checked = True Or (optDRL.Checked = True And DRL < DE) Then
            'DrawStyle = 0
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            'Me.Line(0, 0) - (1400 * System.Math.Cos((180 - (HoinMinutes / 60)) * Pi / 180), 1400 * System.Math.Sin((HoinMinutes / 60) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos(((180 - (HoinMinutes / 60))) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin(((180 - (HoinMinutes / 60))) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            'DrawStyle = 5
            DPen.DashStyle = Drawing2D.DashStyle.Dash
            'Me.Line(0, 0) - (1550 * System.Math.Cos((180 - (HoinMinutes / 60)) * Pi / 180), 1550 * System.Math.Sin((HoinMinutes / 60) * Pi / 180))
            ptA.X = 0 'Me.Width / 2
            ptA.Y = 0
            ptB.X = (MeridianPicBx.Width) * System.Math.Cos(((180 - (HoinMinutes / 60))) * Pi / 180)
            ptB.Y = (MeridianPicBx.Width) * System.Math.Sin(((180 - (HoinMinutes / 60))) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
        End If
        'CurrentY = CurrentY + 150
        ptB.X = -((MeridianPicBx.Width) * System.Math.Cos((((HoinMinutes / 60))) * Pi / 180) + 15)
        ptB.Y = -((MeridianPicBx.Width) * System.Math.Sin((((HoinMinutes / 60))) * Pi / 180) + 15)
        meridgraphic.RotateTransform(180)
        meridgraphic.DrawString("O ", LatitudeTxtBx.Font, DPen.Brush, ptB)
        meridgraphic.RotateTransform(180)
        'Print("O")
        'DrawStyle = 0
        DPen.DashStyle = Drawing2D.DashStyle.Solid

        Dim NowTimeStr As String = Now.ToShortTimeString.Replace(":", "").Replace(" ", "").Replace("-", "")
        Dim BMFname As String = "MeridDiag" & NowTimeStr & ".jpg"
        bm.Save(BMFname)

        MeridianPicBx.ImageLocation = BMFname
        MeridianPicBx.Load()
        MeridianPicBx.Visible = True

        Dim earg As PaintEventArgs = New PaintEventArgs(meridgraphic, MeridianPicBx.Bounds)
        Dim esender As Object = New Object
        MeridianPicBx_Paint(esender, earg)
        meridgraphic.Dispose()

    End Sub

    Public Sub IandC()
        Flag2 = True 'added in V5.4.0 to prevent 120000 from being used in this calculation
        Greenwich()
        'dvalue = Abs(DE2 - DE1) * 60: Signdvalue = Sgn(Abs(DE2) - Abs(DE1)): If dvalue < 0.05 Then Signdvalue = 0
        dvalue = (DE2 - DE1) * 60
		'dvalue = (DE2 - DE1) / 24 * 60
		Signdvalue = 1 : If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then Signdvalue = -1
		'If Sgn(DE2) <> Sgn(DE1) And Abs(DE2) > Abs(DE1) Then Signdvalue = -Signdvalue
		If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then Signdvalue = -1
		dvalue = System.Math.Abs(dvalue)
		If dvalue < 0.05 Then Signdvalue = 0
		dvalue = Int(System.Math.Abs(dvalue) * 10 + 0.5) / 10
		dcorr = dvalue * (GMinute + 0.5) / 60
		dcorr = Int(System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10
		
		TotDE = System.Math.Sign(DE1) * (System.Math.Abs(DE1) + Signdvalue * dcorr / 60)
		'If Val(Left$(txtTime, 2)) > ZTofLANHours Then TotDE = Sgn(DE2) * (Abs(DE2) + Signdvalue * dcorr / 60)
		'TotDE = DE1 + Signdvalue * dcorr / 60
		'If Sgn(DE1) <> Sgn(DE2) And Abs(dcorr - Abs(DE1 * 60)) >= 0.05 Then TotDE = DE1 - Signdvalue * dcorr / 60 '= Sgn(DE1) * (Abs(DE1) - Signdvalue * dcorr / 60)
		TotDecDegrees = Int(System.Math.Abs(TotDE)) : TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
		TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
		If TotDecMinutes = 60 Then TotDecMinutes = 0 : TotDecDegrees = TotDecDegrees + 1
		
		Flag2 = False 'added in V5.4.0
	End Sub
    Public Function Delta_T() As Integer  'http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html
        DecYr = GYear + (GMonth - 0.5) / 12
        If GYear >= 1901 And GYear <= 1920 Then Theta = DecYr - 1900 : DeltaT = -2.79 + 1.494119 * Theta - 0.0598939 * Theta ^ 2 + 0.0061966 * Theta ^ 3 - 0.000197 * Theta ^ 4
        If GYear >= 1921 And GYear <= 1941 Then Theta = DecYr - 1920 : DeltaT = 21.2 + 0.84493 * Theta - 0.0761 * Theta ^ 2 + 0.0020936 * Theta ^ 3
        If GYear >= 1942 And GYear <= 1961 Then Theta = DecYr - 1950 : DeltaT = 29.07 + 0.407 * Theta - (Theta ^ 2) / 233 + (Theta ^ 3) / 2547
        If GYear >= 1962 And GYear <= 1986 Then Theta = DecYr - 1975 : DeltaT = 45.45 + 1.067 * Theta - (Theta ^ 2) / 260 - (Theta ^ 3) / 718
        If GYear >= 1987 And GYear <= 2005 Then Theta = DecYr - 2000 : DeltaT = 63.86 + 0.3345 * Theta - 0.060374 * Theta ^ 2 + 0.0017275 * Theta ^ 3 + 0.000651814 * Theta ^ 4 + 0.00002373599 * Theta ^ 5
        If GYear >= 2006 And GYear <= 2050 Then Theta = DecYr - 2000 : DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2
        If GYear >= 2051 And GYear <= 2099 Then DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)
        Return True
    End Function

    Public Function HourAnglesHour() As Integer
        SH = 360 - AR
        GHAAriesHour = 280.46061837 + 360.98564736629 * (JDHour - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees
        GHAAriesHour = GHAAriesHour + NL * System.Math.Cos(OETrue * Pi / 180) 'true GHA of Aries, degrees
        If GHAAriesHour >= 360 Or GHAAriesHour < 0 Then GHAAriesHour = GHAAriesHour - Int(GHAAriesHour / 360) * 360
        GHAHour = SH + GHAAriesHour
        If GHAHour >= 360 Or GHAHour < 0 Then GHAHour = GHAHour - Int(GHAHour / 360) * 360
        Return True
    End Function

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub
    Public Sub ClearScreen()
        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Color.Empty)
        g.Dispose()
        MeridianPicBx.Visible = False
        LatitudeTxtBx.Text = vbNullString
        AltitudeTxtBx.Text = vbNullString
        AlmanacTxtBx.Text = vbNullString
        Refresh()
    End Sub
    Public Sub Cleanup()
        'Me.Close()
        Exit Sub
    End Sub
End Class