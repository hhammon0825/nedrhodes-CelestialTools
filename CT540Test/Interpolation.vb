Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form15
	Inherits System.Windows.Forms.Form
	Dim U4, U2, U1, U3, U5 As Single
	Dim InterpType, fnumeral As String
	Dim Degrees, Time, DecimalMinutes As Double
	Dim Angle3, Angle1, Angle2, result As Double
	Dim ResultDeg As Short
	Dim ResultMin As Single
	Dim ResultMinute As String
	Dim Time1inSeconds, Time2inSeconds As Integer
	Dim TimeResult As Single
	Dim TimeResultSeconds, TimeResultHours, TimeResultMinutes, Days As Short
	Dim T1Seconds, T2Seconds As Single
	Dim TimeInSeconds As Double ',H1 As Single, M1 As Single, S1 As Single, H2 As Single, M2 As Single, S2 As Single
	Dim TimeMinutes, TimeDays, TimeHours, TimeSeconds As Single
	Dim ZD1, Lo, ZD, ZD2 As Double
	Dim SignZD As String
	Dim ZD1inseconds, ZD2inseconds As Integer
	Dim ZT2inSeconds, ZT1inSeconds, UTinSeconds As Single
	Dim S, H, D, M, Sign As String
	
	'UPGRADE_WARNING: Event cboZDm1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboZDm1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm1.SelectedIndexChanged
		txtTimeResult.Text = "" : txtDays.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event cboZDm2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboZDm2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm2.SelectedIndexChanged
		txtTimeResult.Text = "" : txtDays.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event chkDST1.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDST1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST1.CheckStateChanged
		txtTimeResult.Text = "" : txtDays.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event chkDST2.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkDST2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST2.CheckStateChanged
		txtTimeResult.Text = "" : txtDays.Text = ""
	End Sub
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		txtC1.Text = "" : txtC2.Text = "" : txtC3.Text = "" : txtR1.Text = "" : txtR2.Text = "" : txtR3.Text = "" : txtK1.Text = "" : txtK2.Text = "" : txtK3.Text = "" : txtK4.Text = "" : txtU1.Text = "" : txtU2.Text = "" : txtU3.Text = "" : txtU4.Text = "" : txtU5.Text = ""
	End Sub
	
	Private Sub cmdClearAddSubtract_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAddSubtract.Click
		txtDeg1.Text = "" : txtMin1.Text = "" : txtDeg2.Text = "" : txtMin2.Text = "" : txtDeg3.Text = "" : txtMin3.Text = "" : txtResult.Text = ""
	End Sub
	
	Private Sub cmdClearConverter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearConverter.Click
        'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        txtHsDeg.Text = "" : txtHsMin.Text = "" : txtHsSec.Text = "" : txtTime.Text = "" : txtAngle.Text = "" : txtConvertedTime.Text = ""
	End Sub
	
	Private Sub cmdClearTZ_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearTZ.Click
		txtLoDeg.Text = ""
		txtLoMin.Text = ""
		txtZD.Text = ""
	End Sub
	
	Private Sub cmdConvert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvert.Click
        'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentY = 4000
        'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        Degrees = Val(txtHsDeg.Text) + Val(txtHsMin.Text) / 60 + Val(txtHsSec.Text) / 3600
		Degrees = Int(Degrees * 100000 + 0.5) / 100000
		Time = Val(VB.Left(txtTime.Text, 2)) + Val(Mid(txtTime.Text, 3, 2)) / 60 + Val(VB.Right(txtTime.Text, 2)) / 3600
		DecimalMinutes = Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2)) / 60
		DecimalMinutes = Int(DecimalMinutes * 100000 + 0.5) / 100000
		Time = Int(Time * 100000 + 0.5) / 100000
        'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentY = 4850
        'UPGRADE_ISSUE: Form property Form15.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentX = 3500
        'Print Degrees; " degrees"
        txtAngle.Text = Str(Degrees) & " degrees"
        'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentY = 5330
        'UPGRADE_ISSUE: Form property Form15.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentX = 3500
        'Print Time; "h or"; Val(Left$(txtTime, 2)); "h"; DecimalMinutes; "m"
        txtConvertedTime.Text = Str(Time) & " h or " & VB.Left(txtTime.Text, 2) & " h" & Str(DecimalMinutes) & " m"
	End Sub
	
	Private Sub cmdInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInterpolate.Click
		txtU1.Text = "" : txtU2.Text = "" : txtU3.Text = "" : txtU4.Text = "" : txtU5.Text = ""
		If txtK1.Text = "" Then MsgBox("Not enough data.") : Exit Sub
		If txtK2.Text = "" And txtK3.Text = "" Then MsgBox("Not enough data.") : Exit Sub
		'If (txtC3 = txtC1) Or (txtR3 = txtR1) Then MsgBox "Incorrect data.": Exit Sub
		If Val(txtC1.Text) = Val(txtC3.Text) And txtC1.Text <> "" Then MsgBox("Check for incorrect C value(s).") : Exit Sub
		If Val(txtC1.Text) < Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC1.Text) Or Val(txtC2.Text) >= Val(txtC3.Text)) Then MsgBox("Check for incorrect C value(s).") : Exit Sub
		If Val(txtC1.Text) > Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC3.Text) Or Val(txtC2.Text) >= Val(txtC1.Text)) Then MsgBox("Check for incorrect C value(s).") : Exit Sub
		If Val(txtR1.Text) = Val(txtR3.Text) And txtR1.Text <> "" Then MsgBox("Check for incorrect R value(s).") : Exit Sub
		If Val(txtR1.Text) < Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR1.Text) Or Val(txtR2.Text) >= Val(txtR3.Text)) Then MsgBox("Check for incorrect R value(s).") : Exit Sub
		If Val(txtR1.Text) > Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR3.Text) Or Val(txtR2.Text) >= Val(txtR1.Text)) Then MsgBox("Check for incorrect R value(s).") : Exit Sub
		If txtK4.Text = "" And (txtK2.Text = "" Or txtK3.Text = "") Then InterpType = "Single" Else InterpType = "Double"
		If InterpType = "Double" Then
			If Val(txtK1.Text) < Val(txtK2.Text) And Val(txtK3.Text) > Val(txtK4.Text) Then MsgBox("Check for incorrect K value(s).") : Exit Sub
			If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK3.Text) < Val(txtK4.Text) Then MsgBox("Check for incorrect K value(s).") : Exit Sub
			If Val(txtK1.Text) < Val(txtK3.Text) And Val(txtK2.Text) > Val(txtK4.Text) Then MsgBox("Check for incorrect K value(s).") : Exit Sub
			If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK2.Text) < Val(txtK4.Text) Then MsgBox("Check for incorrect K value(s).") : Exit Sub
			If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Or txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then MsgBox("Not enough data.") : Exit Sub
			'If optHorizontal = True Then
			U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
			U1 = Val(txtK1.Text) + U1
			U1 = Int(U1 * 100000 + 0.5) / 100000
			U2 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK4.Text) - Val(txtK2.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
			U2 = Val(txtK2.Text) + U2
			U2 = Int(U2 * 100000 + 0.5) / 100000
			'U5 = (Val(txtR2) - Val(txtR1)) * (U2 - U1) / (Val(txtR3) - Val(txtR1))
			'U5 = U1 + U5
			'U5 = Int(U5 * 100000 + 0.5) / 100000
			txtU1.Text = Str(U1)
			txtU2.Text = Str(U2)
			'txtU5 = Str$(U5)
			'End If
			'If optVertical = True Then
			U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
			U3 = Val(txtK1.Text) + U3
			U3 = Int(U3 * 100000 + 0.5) / 100000
			U4 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK4.Text) - Val(txtK3.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
			U4 = Val(txtK3.Text) + U4
			U4 = Int(U4 * 100000 + 0.5) / 100000
			U5 = (Val(txtC2.Text) - Val(txtC1.Text)) * (U4 - U3) / (Val(txtC3.Text) - Val(txtC1.Text))
			U5 = U3 + U5
			U5 = Int(U5 * 100000 + 0.5) / 100000
			txtU3.Text = Str(U3)
			txtU4.Text = Str(U4)
			txtU5.Text = Str(U5)
			'End If
		End If
		If InterpType = "Single" Then
			If txtK2.Text = "" And txtK4.Text = "" Then 'Across
				If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Then MsgBox("Not enough data.") : Exit Sub
				U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
				U1 = Val(txtK1.Text) + U1
				U1 = Int(U1 * 100000 + 0.5) / 100000
				txtU1.Text = Str(U1)
			End If
			If txtK3.Text = "" And txtK4.Text = "" Then 'Down
				If txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then MsgBox("Not enough data.") : Exit Sub
				U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
				U3 = Val(txtK1.Text) + U3
				U3 = Int(U3 * 100000 + 0.5) / 100000
				txtU3.Text = Str(U3)
			End If
		End If
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    'UPGRADE_WARNING: Event optAdd1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAdd1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAdd1.CheckedChanged
        If eventSender.Checked Then
            Calculate()
        End If
    End Sub

    'UPGRADE_WARNING: Event optAdd2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAdd2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAdd2.CheckedChanged
        If eventSender.Checked Then
            Calculate()
        End If
    End Sub

    'UPGRADE_WARNING: Event optAddTimes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAddTimes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAddTimes.CheckedChanged
        If eventSender.Checked Then
            txtCalcTime.Text = ""
        End If
    End Sub

    'UPGRADE_WARNING: Event optAddToD.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optAddToD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAddToD.CheckedChanged
        If eventSender.Checked Then
            txtTimeResult.Text = "" : txtDays.Text = ""
        End If
    End Sub

    'UPGRADE_WARNING: Event optHsDMm.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
        If eventSender.Checked Then
            If optHsDMm.Checked = True Then
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                'txtHsSec.Enabled = False
                txtHsMin.Text = ""
                txtHsSec.Text = ""
                'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentY = 4850
                'CurrentX = 3500
                'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'Cls()
                'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentY = 5330
                'UPGRADE_ISSUE: Form property Form15.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentX = 3500
                'UPGRADE_ISSUE: Form method Form15.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'

                'If Time <> 0 Then Print(CStr(Time) & " hours")
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
                txtHsMin.Text = ""
                txtHsSec.Text = ""
                'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentY = 4850
                'CurrentX = 3500
                'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'Cls()
                'UPGRADE_ISSUE: Form property Form15.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentY = 5330
                'UPGRADE_ISSUE: Form property Form15.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'CurrentX = 3500
                'UPGRADE_ISSUE: Form method Form15.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'If Time <> 0 Then Print(CStr(Time) & " hours")
            End If
        End If
    End Sub

    'UPGRADE_WARNING: Event optSubtract1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optSubtract1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtract1.CheckedChanged
        If eventSender.Checked Then
            Calculate()
        End If
    End Sub

    'UPGRADE_WARNING: Event optSubtract2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optSubtract2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtract2.CheckedChanged
        If eventSender.Checked Then
            Calculate()
        End If
    End Sub

    'UPGRADE_WARNING: Event optSubtractTimes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optSubtractTimes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtractTimes.CheckedChanged
        If eventSender.Checked Then
            txtCalcTime.Text = ""
        End If
    End Sub

    'UPGRADE_WARNING: Event optSubtractToD.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optSubtractToD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtractToD.CheckedChanged
        If eventSender.Checked Then
            txtTimeResult.Text = "" : txtDays.Text = ""
        End If
    End Sub

    Private Sub txtC1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtC1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtC1.Text, ".") Then
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
    Private Sub txtC1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtC1.Enter
        SelectAllText(txtC1)
    End Sub

    Private Sub txtC2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtC2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtC2.Text, ".") Then
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
    Private Sub txtC2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtC2.Enter
        SelectAllText(txtC2)
    End Sub

    Private Sub txtC3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtC3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtC3.Text, ".") Then
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
    Private Sub txtC3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtC3.Enter
        SelectAllText(txtC3)
    End Sub

    'UPGRADE_WARNING: Event txtHsDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
        '    txtHsDeg.ForeColor = &H80000008
        '    txtHsDeg.BackColor = &H80000005
        '    If Val(txtHsDeg.Text) > 140 Then
        '        txtHsDeg.BackColor = &HFF&
        '        MsgBox "Out of Range"
        '    End If
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
        '    If Val(txtHsDeg.Text) > 140 Then
        '        KeepFocus = True
        '    End If
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

    Private Sub txtK1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtK1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        bMinusSignAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc("-")
                'If Len(txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtK1.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtK1.Text, ".") Then
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
    Private Sub txtK1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtK1.Enter
        SelectAllText(txtK1)
    End Sub

    Private Sub txtK2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtK2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        bMinusSignAlready = False
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc("-")
                'If Len(txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtK2.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtK2.Text, ".") Then
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
    Private Sub txtK2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtK2.Enter
        SelectAllText(txtK2)
    End Sub

    Private Sub txtK3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtK3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        bMinusSignAlready = False
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc("-")
                'If Len(txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtK3.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtK3.Text, ".") Then
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
    Private Sub txtK3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtK3.Enter
        SelectAllText(txtK3)
    End Sub

    Private Sub txtK4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtK4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        bMinusSignAlready = False
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc("-")
                'If Len(txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtK4.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtK4.Text, ".") Then
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
    Private Sub txtK4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtK4.Enter
        SelectAllText(txtK4)
    End Sub

    Private Sub txtR1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtR1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtR1.Text, ".") Then
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
    Private Sub txtR1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtR1.Enter
        SelectAllText(txtR1)
    End Sub

    Private Sub txtR2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtR2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtR2.Text, ".") Then
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
    Private Sub txtR2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtR2.Enter
        SelectAllText(txtR2)
    End Sub

    Private Sub txtR3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtR3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtR3.Text, ".") Then
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
    Private Sub txtR3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtR3.Enter
        SelectAllText(txtR3)
    End Sub

    Private Sub Form15_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboLo.SelectedIndex = 0 '"W"
        cboZDm1.SelectedIndex = 0 '"00"
        cboZDm2.SelectedIndex = 0 '"00"
    End Sub

    Private Sub Form15_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cleanup()
    End Sub

    'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime.Text) = 6 And Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Then '(Val(Left(txtTime.Text, 2)) > 99 Or
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
        If Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then 'Val(Left(txtTime.Text, 2)) > 23 Or
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

    Private Sub Calculate()
        'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        Angle1 = Val(txtDeg1.Text) + Val(txtMin1.Text) / 60
        Angle2 = Val(txtDeg2.Text) + Val(txtMin2.Text) / 60
        Angle3 = Val(txtDeg3.Text) + Val(txtMin3.Text) / 60
        If optAdd1.Checked = True And optAdd2.Checked = True Then result = Angle1 + Angle2 + Angle3
        If optAdd1.Checked = True And optSubtract2.Checked = True Then result = Angle1 + Angle2 - Angle3
        If optSubtract1.Checked = True And optAdd2.Checked = True Then result = Angle1 - Angle2 + Angle3
        If optSubtract1.Checked = True And optSubtract2.Checked = True Then result = Angle1 - Angle2 - Angle3
        While result >= 360
            result = result - 360
        End While
        While result < 0
            result = result + 360
        End While
        ResultDeg = Int(result)
        ResultMin = (result - ResultDeg) * 60
        ResultMin = Int(ResultMin * 10 + 0.5) / 10
        'Form1.Font = FontChangeName(Form1.Font, "Tahoma")
        'Form1.Font = FontChangeSize(Form1.Font, 9)
        ResultMinute = Format(ResultMin, "00.0")
        txtResult.Text = Str(ResultDeg) & Chr(176) & ResultMinute & "'"
    End Sub

    Private Sub optAdd_Click()
        Calculate()
    End Sub

    Private Sub optSubtract_Click()
        Calculate()
    End Sub

    'UPGRADE_WARNING: Event txtDeg1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDeg1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg1.TextChanged
        '    txtDeg1.ForeColor = &H80000008
        '    txtDeg1.BackColor = &H80000005
        '    If Val(txtDeg1.Text) > 140 Then
        '        txtDeg1.BackColor = &HFF&
        '        MsgBox "Out of Range"
        '    End If
        Calculate()
    End Sub

    Private Sub txtDeg1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg1.KeyPress
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

    Private Sub txtDeg1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If Val(txtDeg1.Text) > 140 Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg1.Enter
        SelectAllText(txtDeg1)
    End Sub

    'UPGRADE_WARNING: Event txtMin1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtMin1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin1.TextChanged
        'txtMin1.ForeColor = &H80000008
        txtMin1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin1.Text) > 59.9 Then
            txtMin1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        Calculate()
    End Sub

    Private Sub txtMin1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin1.Text, ".") Then
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

    Private Sub txtMin1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin1.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin1.Enter
        SelectAllText(txtMin1)
    End Sub

    'UPGRADE_WARNING: Event txtDeg2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDeg2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg2.TextChanged
        '    txtDeg2.ForeColor = &H80000008
        '    txtDeg2.BackColor = &H80000005
        '    If Val(txtDeg2.Text) > 140 Then
        '        txtDeg2.BackColor = &HFF&
        '        MsgBox "Out of Range"
        '    End If
        Calculate()
    End Sub

    Private Sub txtDeg2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg2.KeyPress
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

    Private Sub txtDeg2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If Val(txtDeg2.Text) > 140 Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg2.Enter
        SelectAllText(txtDeg2)
    End Sub

    'UPGRADE_WARNING: Event txtMin2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtMin2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin2.TextChanged
        'txtMin2.ForeColor = &H80000008
        txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin2.Text) > 59.9 Then
            txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        Calculate()
    End Sub

    Private Sub txtMin2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin2.Text, ".") Then
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

    Private Sub txtMin2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin2.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin2.Enter
        SelectAllText(txtMin2)
    End Sub

    'UPGRADE_WARNING: Event txtDeg3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDeg3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg3.TextChanged
        '    txtDeg2.ForeColor = &H80000008
        '    txtDeg2.BackColor = &H80000005
        '    If Val(txtDeg2.Text) > 140 Then
        '        txtDeg2.BackColor = &HFF&
        '        MsgBox "Out of Range"
        '    End If
        Calculate()
    End Sub

    Private Sub txtDeg3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg3.KeyPress
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

    Private Sub txtDeg3_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg3.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If Val(txtDeg2.Text) > 140 Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg3.Enter
        SelectAllText(txtDeg3)
    End Sub

    'UPGRADE_WARNING: Event txtMin3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtMin3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin3.TextChanged
        'txtMin2.ForeColor = &H80000008
        txtMin3.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin3.Text) > 59.9 Then
            txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        Calculate()
    End Sub

    Private Sub txtMin3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin3.Text, ".") Then
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

    Private Sub txtMin3_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin3.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin3.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin3.Enter
        SelectAllText(txtMin3)
    End Sub

    'UPGRADE_WARNING: Event txtTime1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTime1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
        'txtTime.ForeColor = &H80000008
        txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        'If Len(txtTime1.text) = 6 And (Val(Left(txtTime1.text, 2)) > 23 Or Val(Mid(txtTime1.text, 3, 2)) > 59 Or Val(Mid(txtTime1.text, 5, 2)) > 59) Then
        If Len(txtTime1.Text) = 4 And (Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(VB.Right(txtTime1.Text, 2)) > 59) Then
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
        'If Val(Left(txtTime1.text, 2)) > 23 Or Val(Mid(txtTime1.text, 3, 2)) > 59 Or Val(Mid(txtTime1.text, 5, 2)) > 59 Or Len(txtTime1) <> 6 Then
        If Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(VB.Right(txtTime1.Text, 2)) > 59 Or Len(txtTime1.Text) <> 4 Then
            KeepFocus = True
        End If
        If Len(txtTime1.Text) = 0 Then
            KeepFocus = False
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.Enter
        SelectAllText(txtTime1)
    End Sub

    'UPGRADE_WARNING: Event txtIntD.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtIntD_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntD.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
    End Sub
    Private Sub txtIntD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntD.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntD.Text, ".") Then
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
    Private Sub txtIntD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntD.Enter
        SelectAllText(txtIntD)
    End Sub

    'UPGRADE_WARNING: Event txtIntH.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtIntH_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntH.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
    End Sub
    Private Sub txtIntH_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntH.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntH.Text, ".") Then
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
    Private Sub txtIntH_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntH.Enter
        SelectAllText(txtIntH)
    End Sub

    'UPGRADE_WARNING: Event txtIntM.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtIntM_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntM.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
    End Sub
    Private Sub txtIntM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntM.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntM.Text, ".") Then
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
    Private Sub txtIntM_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntM.Enter
        SelectAllText(txtIntM)
    End Sub

    'UPGRADE_WARNING: Event txtZDh1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtZDh1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh1.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
        'txtZDh.ForeColor = &H80000008
        txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If (Val(txtZDh1.Text) < -13 Or Val(txtZDh1.Text) > 12) Then
            txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtZDh1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh1.KeyPress
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
                If txtZDh1.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtZDh1.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
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
    Private Sub txtZDh1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh1.Text) < -13 Or Val(txtZDh1.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh1.Enter
        SelectAllText(txtZDh1)
    End Sub

    'UPGRADE_WARNING: Event txtZDh2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtZDh2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh2.TextChanged
        txtTimeResult.Text = "" : txtDays.Text = ""
        'txtZDh.ForeColor = &H80000008
        txtZDh2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If (Val(txtZDh2.Text) < -13 Or Val(txtZDh2.Text) > 12) Then
            txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtZDh2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh2.KeyPress
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
                If txtZDh2.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtZDh2.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
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
    Private Sub txtZDh2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh2.Text) < -13 Or Val(txtZDh2.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh2.Enter
        SelectAllText(txtZDh2)
    End Sub

    Private Sub cmdClearToD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearToD.Click
        txtTime1.Text = "" : txtZDh1.Text = "" : txtZDh2.Text = "" : txtIntD.Text = "" : txtIntH.Text = "" : txtIntM.Text = "" : txtTimeResult.Text = ""
        chkDST1.CheckState = System.Windows.Forms.CheckState.Unchecked : chkDST2.CheckState = System.Windows.Forms.CheckState.Unchecked
        cboZDm1.SelectedIndex = 0 : cboZDm2.SelectedIndex = 0
    End Sub

    Private Sub cmdCalculateToD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateToD.Click
        'UPGRADE_ISSUE: Form method Form15.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        Time1inSeconds = 3600 * Val(VB.Left(txtTime1.Text, 2)) + 60 * Val(Mid(txtTime1.Text, 3, 2)) + Val(VB.Right(txtTime1.Text, 2))
        ZD1 = System.Math.Abs(Val(txtZDh1.Text))
        ZD1 = System.Math.Abs(ZD1) + Val(cboZDm1.Text) / 60
        If VB.Left(txtZDh1.Text, 1) = "-" Then ZD1 = -ZD1
        If chkDST1.CheckState = 1 Then ZD1 = ZD1 - 1
        ZD1inseconds = 3600 * ZD1
        UTinSeconds = Time1inSeconds + ZD1inseconds
        T1Seconds = 86400 * Val(txtIntD.Text) + 3600 * Val(txtIntH.Text) + 60 * Val(txtIntM.Text) '+ Val(txtIntS.text)
        ZD2 = System.Math.Abs(Val(txtZDh2.Text))
        ZD2 = System.Math.Abs(ZD2) + Val(cboZDm2.Text) / 60
        If VB.Left(txtZDh2.Text, 1) = "-" Then ZD2 = -ZD2
        If chkDST2.CheckState = 1 Then ZD2 = ZD2 - 1
        ZD2inseconds = 3600 * ZD2
        If optAddToD.Checked = True Then TimeResult = UTinSeconds + T1Seconds
        If optSubtractToD.Checked = True Then TimeResult = UTinSeconds - T1Seconds
        TimeResult = TimeResult - ZD2inseconds
        Days = 0
        While TimeResult >= 86399
            TimeResult = TimeResult - 86400
            Days = Days + 1
        End While
        While TimeResult < 0
            TimeResult = TimeResult + 86400
            Days = Days - 1
        End While
        TimeResultHours = Int(TimeResult / 3600)
        TimeResultMinutes = Int((TimeResult - CSng(TimeResultHours) * 3600) / 60)
        'TimeResultSeconds = TimeResult - CLng(TimeResultHours) * 3600 - TimeResultMinutes * 60
        'Me.Font = FontChangeName(Me.Font, "Tahoma")
        'Me.Font = FontChangeSize(Me.Font, 8)
        'CurrentX = 6500
        'CurrentY = 4920
        'Print "Time at Location B"
        txtTimeResult.Text = Format(Str(TimeResultHours), "00") & Format(Str(TimeResultMinutes), "00") '& Format(Str$(TimeResultSeconds), "00")
        'CurrentY = 8020
        'CurrentX = 3250
        If Days = 1 Then txtDays.Text = "+ 1 day"
		If Days = -1 Then txtDays.Text = "- 1 day"
		If Days > 1 Then txtDays.Text = "+" & Str(System.Math.Abs(Days)) & " days"
		If Days < -1 Then txtDays.Text = "-" & Str(System.Math.Abs(Days)) & " days"
	End Sub
	
	'UPGRADE_WARNING: Event txtD1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtD1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtD1.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtD1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtD1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtD1.Text, ".") Then
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
	
	Private Sub txtD1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtD1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtH1.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtD1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtD1.Enter
		SelectAllText(txtD1)
	End Sub
	
	'UPGRADE_WARNING: Event txtH1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtH1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtH1.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtH1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtH1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtH1.Text, ".") Then
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
	
	Private Sub txtH1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtH1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtH1.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtH1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtH1.Enter
		SelectAllText(txtH1)
	End Sub
	
	'UPGRADE_WARNING: Event txtM1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtM1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtM1.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtM1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtM1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtM1.Text, ".") Then
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
	
	Private Sub txtM1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtM1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtM1.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtM1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtM1.Enter
		SelectAllText(txtM1)
	End Sub
	
	'UPGRADE_WARNING: Event txtS1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtS1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtS1.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtS1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtS1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtS1.Text, ".") Then
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
	
	Private Sub txtS1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtS1.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtS1.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtS1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtS1.Enter
		SelectAllText(txtS1)
	End Sub
	
	'UPGRADE_WARNING: Event txtD2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtD2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtD2.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtD2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtD2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtD2.Text, ".") Then
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
	
	Private Sub txtD2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtD2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtH1.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtD2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtD2.Enter
		SelectAllText(txtD2)
	End Sub
	
	'UPGRADE_WARNING: Event txtH2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtH2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtH2.TextChanged
		txtCalcTime.Text = ""
	End Sub
	
	Private Sub txtH2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtH2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtH2.Text, ".") Then
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
	
	Private Sub txtH2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtH2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtH2.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtH2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtH2.Enter
		SelectAllText(txtH2)
	End Sub
	
	'UPGRADE_WARNING: Event txtM2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtM2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtM2.TextChanged
		txtCalcTime.Text = ""
		'txtTime.ForeColor = &H80000008
		'txtM2.BackColor = &H80000005
		'If Val(txtM2.text) > 32760 Then
		'    txtM2.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
	End Sub
	
	Private Sub txtM2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtM2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtM2.Text, ".") Then
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
	
	Private Sub txtM2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtM2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtM2.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtM2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtM2.Enter
		SelectAllText(txtM2)
	End Sub
	
	'UPGRADE_WARNING: Event txtS2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtS2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtS2.TextChanged
		txtCalcTime.Text = ""
		'txtTime.ForeColor = &H80000008
		'txtS2.BackColor = &H80000005
		'If Val(txtS2.text) > 32760 Then
		'    txtS2.BackColor = &HFF&
		'    MsgBox "Out of Range"
		'End If
	End Sub
	
	Private Sub txtS2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtS2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtS2.Text, ".") Then
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
	
	Private Sub txtS2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtS2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		'If Val(txtS2.text) > 32760 Then KeepFocus = True
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtS2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtS2.Enter
		SelectAllText(txtS2)
	End Sub
	
	
	Private Sub cmdCalculateTimes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateTimes.Click
		T1Seconds = 86400 * Val(txtD1.Text) + 3600 * Val(txtH1.Text) + 60 * Val(txtM1.Text) + Val(txtS1.Text)
		T2Seconds = 86400 * Val(txtD2.Text) + 3600 * Val(txtH2.Text) + 60 * Val(txtM2.Text) + Val(txtS2.Text)
		If optAddTimes.Checked = True Then TimeInSeconds = T1Seconds + T2Seconds
		If optSubtractTimes.Checked = True Then TimeInSeconds = T1Seconds - T2Seconds
		TimeDays = Fix(TimeInSeconds / 86400)
		TimeHours = Int(((System.Math.Abs(TimeInSeconds) - System.Math.Abs(TimeDays) * 86400)) / 3600)
		'TimeHours = (Abs(TimeInSeconds) - Abs(TimeDays) * 3600) / 3600
		TimeMinutes = Int((System.Math.Abs(TimeInSeconds) - System.Math.Abs(CInt(TimeDays)) * 86400 - CInt(TimeHours) * 3600) / 60)
		'TimeMinutes = (Abs(TimeDays) * 3600 - TimeHours) * 60
		TimeSeconds = System.Math.Abs(System.Math.Abs(TimeInSeconds) - System.Math.Abs(TimeDays) * 86400 - TimeHours * 3600 - TimeMinutes * 60)
		TimeSeconds = Int(TimeSeconds + 0.5)
		D = " days" : If TimeDays = 1 Or TimeDays = -1 Then D = " day"
		H = " hours" : If TimeHours = 1 Then H = " hour"
		M = " minutes" : If TimeMinutes = 1 Then M = " minute"
		S = " seconds" : If TimeSeconds = 1 Then S = " second"
		Sign = "" : If TimeInSeconds < 0 Then Sign = "-"
		txtCalcTime.Text = Sign & Str(System.Math.Abs(TimeDays)) & D & Str(TimeHours) & H & Str(TimeMinutes) & M & Str(TimeSeconds) & S
	End Sub
	
	Private Sub cmdClearTimes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearTimes.Click
		txtD1.Text = ""
		txtD2.Text = ""
		txtH1.Text = ""
		txtM1.Text = ""
		txtS1.Text = ""
		txtH2.Text = ""
		txtM2.Text = ""
		txtS2.Text = ""
		txtCalcTime.Text = ""
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
	
	'UPGRADE_WARNING: Event cboLo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
		AutoZDCalc()
	End Sub
	
	Public Sub AutoZDCalc()
		Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
		ZD = Int(Lo / 15 + 0.5)
		If cboLo.Text = "E " Then ZD = -ZD
		SignZD = "+" : If cboLo.Text = "E " Then SignZD = "-"
		txtZD.Text = SignZD & System.Math.Abs(ZD)
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class