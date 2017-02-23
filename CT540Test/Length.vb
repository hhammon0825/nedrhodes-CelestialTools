Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form18
	Inherits System.Windows.Forms.Form
	Dim LengthDegLSpherefeet, LengthDegLSpherenm, LengthDegLSpheremeters, LengthDegLSpheresm As Single
	Dim LengthDegLoSpherefeet, LengthDegLoSpherenm, LengthDegLoSpheremeters, LengthDegLoSpheresm As Single
	Dim LengthDegLWGS84feet, LengthDegLWGS84nm, LengthDegLWGS84meters, LengthDegLWGS84sm As Single
	Dim LengthDegLoWGS84feet, LengthDegLoWGS84nm, LengthDegLoWGS84meters, LengthDegLoWGS84sm As Single
	Dim L, Pi As Double
	Dim fnumeral As String
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Calculate()
        L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
        Pi = 4 * System.Math.Atan(1.0#)
        LengthDegLSpherenm = 60
        LengthDegLSpheremeters = LengthDegLSpherenm * 1852
        LengthDegLSpherefeet = LengthDegLSpheremeters * 3.2808399
        LengthDegLSpheresm = LengthDegLSpherefeet / 5280
        LengthDegLoSpherenm = 60 * System.Math.Cos(L * Pi / 180)
        LengthDegLoSpheremeters = LengthDegLoSpherenm * 1852
        LengthDegLoSpherefeet = LengthDegLoSpheremeters * 3.2808399
        LengthDegLoSpheresm = LengthDegLoSpherefeet / 5280
        'LengthDegLWGS84 = (111132.954 - 559.822 * Cos(2 * L * Pi / 180) + 1.175 * Cos(4 * L * Pi / 180)) / 1852
        LengthDegLWGS84meters = 111132.92 - 559.82 * System.Math.Cos(2 * L * Pi / 180) + 1.175 * System.Math.Cos(4 * L * Pi / 180) - 0.0023 * System.Math.Cos(6 * L * Pi / 180)
        LengthDegLWGS84feet = LengthDegLWGS84meters * 3.2808399
        LengthDegLWGS84sm = LengthDegLWGS84feet / 5280
        LengthDegLWGS84nm = LengthDegLWGS84meters / 1852
        'LengthDegLoWGS84 = ((Pi / 180) * 6378137 * Cos((Atn(0.99664719 * (Tan(L * Pi / 180)))))) / 1852
        LengthDegLoWGS84meters = 111412.84 * System.Math.Cos(L * Pi / 180) - 93.5 * System.Math.Cos(3 * L * Pi / 180) + 0.118 * System.Math.Cos(5 * L * Pi / 180)
        LengthDegLoWGS84feet = LengthDegLoWGS84meters * 3.2808399
        LengthDegLoWGS84sm = LengthDegLoWGS84feet / 5280
        LengthDegLoWGS84nm = LengthDegLoWGS84meters / 1852
        'Round to three (nm and mi) or zero (feet and meters) decimal places
        'LengthDegLSpherenm needs no rounding
        LengthDegLSpheremeters = Int(LengthDegLSpheremeters + 0.5)
        LengthDegLSpherefeet = Int(LengthDegLSpherefeet + 0.5)
        LengthDegLSpheresm = Int(LengthDegLSpheresm * 1000 + 0.5) / 1000
        LengthDegLoSpherenm = Int(LengthDegLoSpherenm * 1000 + 0.5) / 1000
        LengthDegLoSpheremeters = Int(LengthDegLoSpheremeters + 0.5)
        LengthDegLoSpherefeet = Int(LengthDegLoSpherefeet + 0.5)
        LengthDegLoSpheresm = Int(LengthDegLoSpheresm * 1000 + 0.5) / 1000
        LengthDegLWGS84meters = Int(LengthDegLWGS84meters * 1000 + 0.5) / 1000
        LengthDegLWGS84feet = Int(LengthDegLWGS84feet + 0.5)
        LengthDegLWGS84sm = Int(LengthDegLWGS84sm * 1000 + 0.5) / 1000
        LengthDegLWGS84nm = Int(LengthDegLWGS84nm * 1000 + 0.5) / 1000
        LengthDegLoWGS84meters = Int(LengthDegLoWGS84meters + 0.5)
        LengthDegLoWGS84feet = Int(LengthDegLoWGS84feet + 0.5)
        LengthDegLoWGS84sm = Int(LengthDegLoWGS84sm * 1000 + 0.5) / 1000
        LengthDegLoWGS84nm = Int(LengthDegLoWGS84nm * 1000 + 0.5) / 1000
        'UPGRADE_ISSUE: Form method Form18.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        'UPGRADE_ISSUE: Form property Form18.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentY = 720 '1200
        'Print "At this latitude, one degree of longitude equals "; Format(LengthDegLoSphere, "#0.0"); " nm or "; Format(LengthDegLoSphere * 1.1507765, "#0.0"); " mi"
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Length of a Degree at Specified Latitude" & vbNewLine & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Print()
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Sphere" & vbTab(4) & "WGS84 Spheroid" & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Length of a degree of latitude" & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Feet" & vbTab & Format(LengthDegLSpherefeet, "#0") & vbTab(2) & Format(LengthDegLWGS84feet, "#0") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Meters" & vbTab & Format(LengthDegLSpheremeters, "#0") & vbTab(2) & Format(LengthDegLWGS84meters, "#0") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Statute Miles" & vbTab & Format(LengthDegLSpheresm, "#0.000") & vbTab(2) & Format(LengthDegLWGS84sm, "#0.000") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Nautical Miles" & vbTab & Format(LengthDegLSpherenm, "#0.000") & vbTab(2) & Format(LengthDegLWGS84nm, "#0.000") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Length of a degree of longitude" & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Feet" & vbTab & Format(LengthDegLoSpherefeet, "#0") & vbTab(2) & Format(LengthDegLoWGS84feet, "#0") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Meters" & vbTab & Format(LengthDegLoSpheremeters, "#0") & vbTab(2) & Format(LengthDegLoWGS84meters, "#0") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Statute Miles" & vbTab & Format(LengthDegLoSpheresm, "#0.000") & vbTab(2) & Format(LengthDegLoWGS84sm, "#0.000") & vbNewLine)
        'UPGRADE_ISSUE: Form method Form18.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        txtLength.AppendText(vbTab & "Nautical Miles" & vbTab & Format(LengthDegLoSpherenm, "#0.000") & vbTab(2) & Format(LengthDegLoWGS84nm, "#0.000") & vbNewLine)

    End Sub
	
	'UPGRADE_WARNING: Form event Form18.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form18_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Calculate()
	End Sub
	
	'UPGRADE_WARNING: Event txtLDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
		If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
		If Val(txtLDeg.Text) = 90 Then txtLMin.Text = "" : txtLMin.Enabled = False : txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLDeg.ForeColor = &H80000008
		txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLDeg.Text) > 90 Or (Val(txtLDeg.Text) = 90 And Val(txtLMin.Text) <> 0) Then
            'UPGRADE_ISSUE: Form property Form18.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 720
            'UPGRADE_ISSUE: Form method Form18.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtLDeg.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		If Val(txtLDeg.Text) < 90 Then
			'txtLMin.ForeColor = &H80000008
			txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLMin.Text = "  "
		End If
		Calculate()
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
            'UPGRADE_ISSUE: Form property Form18.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 720
            'UPGRADE_ISSUE: Form method Form18.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtLMin.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		Calculate()
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
	
	Private Sub Form18_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class