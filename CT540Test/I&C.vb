Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form19
	Inherits System.Windows.Forms.Form
	Dim fnumeral As String
	Dim corr, k, GHAIncrement, GHAIncrementMin As Double
	Dim GHAIncrementDeg As Short
	Dim Time, TimeSec As Double
	Dim TimeMin As Short
	Dim corr2k As Double
	Dim Flag As Boolean
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = VB6.PixelsToTwipsY(Me.Height)
        'FormWidth = VB6.PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub
	
	'UPGRADE_WARNING: Form event Form19.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form19_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Calculate()
	End Sub
	
	'UPGRADE_WARNING: Event optAries.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optAries_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAries.CheckedChanged
		If eventSender.Checked Then
			txtDeg_TextChanged(txtDeg, New System.EventArgs())
			txtMin_TextChanged(txtMin, New System.EventArgs())
			Calculate()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optMoon.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optMoon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMoon.CheckedChanged
		If eventSender.Checked Then
			txtDeg_TextChanged(txtDeg, New System.EventArgs())
			txtMin_TextChanged(txtMin, New System.EventArgs())
			Calculate()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optSunPlanets.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optSunPlanets_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSunPlanets.CheckedChanged
		If eventSender.Checked Then
			txtDeg_TextChanged(txtDeg, New System.EventArgs())
			txtMin_TextChanged(txtMin, New System.EventArgs())
			Calculate()
		End If
	End Sub
	'UPGRADE_WARNING: Event optFwd.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optFwd_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFwd.CheckedChanged
		If eventSender.Checked Then
			If optFwd.Checked = True Then
                'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'Cls()
                Label1.Visible = True
				Label2.Visible = True
				Label3.Visible = True
				Label4.Visible = True
				Label5.Visible = True
				Label6.Visible = True
				txtUTm.Visible = True
				txtUTs.Visible = True
				txtvd.Visible = True
				'txtUTm.Enabled = True
				'txtUTs.Enabled = True
				'txtvd.Enabled = True
				Label7.Visible = False
				Label8.Visible = False
				Label9.Visible = False
				txtDeg.Visible = False
				txtMin.Visible = False
				'txtDeg.Enabled = False
				'txtMin.Enabled = False
			End If
			'Calculate
		End If
	End Sub
	'UPGRADE_WARNING: Event optBack.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optBack_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBack.CheckedChanged
		If eventSender.Checked Then
			If optBack.Checked = True Then
                'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'Cls()
                Label1.Visible = False
				Label2.Visible = False
				Label3.Visible = False
				Label4.Visible = False
				Label5.Visible = False
				Label6.Visible = False
				txtUTm.Visible = False
				txtUTs.Visible = False
				txtvd.Visible = False
				'txtUTm.Enabled = False
				'txtUTs.Enabled = False
				'txtvd.Enabled = False
				Label7.Visible = True
				Label8.Visible = True
				Label9.Visible = True
				txtDeg.Visible = True
				txtMin.Visible = True
				'txtDeg.Enabled = True
				'txtMin.Enabled = True
			End If
			'Calculate
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtUTm.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtUTm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTm.TextChanged
		txtUTm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtUTm.Text) > 59 Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtUTm.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtUTm.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		Calculate()
	End Sub
	Private Sub txtUTm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUTm.KeyPress
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
	
	Private Sub txtUTm_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtUTm.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtUTm.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtUTm_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTm.Enter
		SelectAllText(txtUTm)
	End Sub
	
	'UPGRADE_WARNING: Event txtUTs.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtUTs_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTs.TextChanged
		txtUTs.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtUTs.Text) > 60 Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtUTs.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtUTs.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		Calculate()
	End Sub
	Private Sub txtUTs_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUTs.KeyPress
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
	
	Private Sub txtUTs_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtUTs.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtUTs.Text) > 60 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtUTs_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTs.Enter
		SelectAllText(txtUTs)
	End Sub
	
	'UPGRADE_WARNING: Event txtvd.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtvd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtvd.TextChanged
		'txtLMin.ForeColor = &H80000008
		txtvd.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtvd.Text) > 18 Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtvd.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtvd.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		Calculate()
	End Sub
	
	Private Sub txtvd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtvd.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtvd.Text, ".") Then
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
	
	Private Sub txtvd_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtvd.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtvd.Text) > 18 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtvd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtvd.Enter
		SelectAllText(txtvd)
	End Sub
	
	Private Sub Calculate()
		Flag = False 'this and corr2k used for pre-2001 values of the four corrections that changed in 2001
		If (optSunPlanets.Checked = False And optAries.Checked = False And optMoon.Checked = False) And ((optFwd.Checked = True And (txtUTm.Text <> "" Or txtUTs.Text <> "" Or txtvd.Text <> "")) Or (optBack.Checked = True And (txtDeg.Text <> "" Or txtMin.Text <> ""))) Then
			MsgBox("You must select an object.")
			Exit Sub
		End If
		If optSunPlanets.Checked = True Then k = 15
		If optAries.Checked = True Then k = 15.04106864 'ideally 15+(36000/36535)/24=15.0410677618... but this works
		If optMoon.Checked = True Then k = 14 + 19 / 60
		If optFwd.Checked = True Then
			GHAIncrement = k * (Val(txtUTm.Text) + Val(txtUTs.Text) / 60) / 60
			corr = Val(txtvd.Text) * (Val(txtUTm.Text) + 0.5) / 60
			GHAIncrementDeg = Int(GHAIncrement)
			GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
			GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10
			corr = Int(corr * 10 + 0.50000000000001) / 10
			If (Val(txtUTm.Text) = 22 And Val(txtvd.Text) = 2.8) Then corr = 1# : corr2k = 1.1 : Flag = True
			If (Val(txtUTm.Text) = 22 And Val(txtvd.Text) = 16.4) Then corr = 6.1 : corr2k = 6.2 : Flag = True
			If (Val(txtUTm.Text) = 42 And Val(txtvd.Text) = 15.6) Then corr = 11.1
			If (Val(txtUTm.Text) = 52 And Val(txtvd.Text) = 13.2) Then corr = 11.6
			If (Val(txtUTm.Text) = 52 And Val(txtvd.Text) = 17.2) Then corr = 15.1
			If (Val(txtUTm.Text) = 55 And Val(txtvd.Text) = 18) Then corr = 16.7
			If (Val(txtUTm.Text) = 57 And Val(txtvd.Text) = 13.2) Then corr = 12.7
			If (Val(txtUTm.Text) = 52 And Val(txtvd.Text) = 9.2) Then corr2k = 8.1 : Flag = True
			If (Val(txtUTm.Text) = 52 And Val(txtvd.Text) = 16.4) Then corr2k = 14.4 : Flag = True
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            txtIC.AppendText("GHA Increment " & Format(GHAIncrementDeg, "0") & Chr(176) & Format(GHAIncrementMin, "00.0") & "'")
            'UPGRADE_ISSUE: Form method Form19.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            txtIC.AppendText("corr  " & Format(corr, "0.0") & "'" & vbNewLine)
            'UPGRADE_ISSUE: Form method Form19.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            If Flag = True Then
                txtIC.AppendText("     corr is for 2001 and later Almanac.  Pre-2001 value is " & Format(corr2k, "0.0") & "'" & vbNewLine)
            End If
        End If
		If optBack.Checked = True Then
			Time = (60 * (Val(txtDeg.Text) + Val(txtMin.Text) / 60)) / k
			TimeMin = Int(Time)
			TimeSec = Int((Time - TimeMin) * 60 + 0.5)
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            txtIC.AppendText("Time " & Format(TimeMin, "0") & "m" & Format(TimeSec, "00") & "s")
        End If
	End Sub
	'UPGRADE_WARNING: Event txtDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.TextChanged
		txtDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If (optMoon.Checked = False And Val(txtDeg.Text) > 15) Or (optMoon.Checked = True And Val(txtDeg.Text) > 14) Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtDeg.Focus()

            MsgBox("Out of Range") : Exit Sub
		End If
		Calculate()
	End Sub
	Private Sub txtDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg.KeyPress
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
	
	Private Sub txtDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If (optMoon.Checked = False And Val(txtDeg.Text) > 15) Or (optMoon.Checked = True And Val(txtDeg.Text) > 14) Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.Enter
		SelectAllText(txtDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin.TextChanged
		txtMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtMin.Text) > 59.9 Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range") : Exit Sub
		End If
		If (optSunPlanets.Checked = True And Val(txtDeg.Text) = 15 And Val(txtMin.Text) <> 0) Or (optAries.Checked = True And Val(txtDeg.Text) = 15 And Val(txtMin.Text) > 2.5) Or (optMoon.Checked = True And Val(txtDeg.Text) = 14 And Val(txtMin.Text) > 19) Then
            'UPGRADE_ISSUE: Form property Form19.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'CurrentY = 2400
            'UPGRADE_ISSUE: Form method Form19.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Cls()
            txtMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtMin.Focus()

            MsgBox("Illegal value") : Exit Sub
		End If
		Calculate()
	End Sub
	Private Sub txtMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtMin.Text, ".") Then
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
	
	Private Sub txtMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin.Enter
		SelectAllText(txtMin)
	End Sub
	
	Private Sub Form19_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class