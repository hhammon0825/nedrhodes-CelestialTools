Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form25
	Inherits System.Windows.Forms.Form
	Dim DC, H1, VC, AC As Single
	Dim fnumeral As String
	Private Sub cmdCalcVert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalcVert.Click
		'UPGRADE_ISSUE: Form method Form25.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Cls()
		'Font = "Tahoma"
		H1 = 0.5 * Val(txtMTR.Text) + Val(txtMTL.Text) 'H1 is height of MHW above MLLW
		H1 = Int(H1 * 10 + 0.5) / 10
		VC = Val(txtCH.Text) + H1 - Val(txtHeight.Text)
		AC = VC - Val(txtBH.Text)
		AC = Int(AC * 10 + 0.5) / 10
		DC = Val(txtCD.Text) + Val(txtHeight.Text) - Val(txtDraft.Text)
		'UPGRADE_ISSUE: Form property Form25.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 2460
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Height of MHW above MLLW = 1/2 Mean Range + Mean Tide")
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), " = 1/2 (" & Val(txtMTR.Text) & ") + " & CStr(Val(txtMTL.Text)) & " = " & CStr(H1))
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Vertical Clearance = Charted Height + Height of MHW above MLLW - Height of Tide above MLLW")
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(19), " = " & Val(txtCH.Text) & " + " & CStr(H1) & " - " & CStr(Val(txtHeight.Text)) & " = " & CStr(VC))
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Actual Clearance = Vertical Clearance - Boat Height")
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(18), " = " & VC & " - " & CStr(Val(txtBH.Text)) & " = " & CStr(AC))
		'UPGRADE_ISSUE: Form property Form25.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		CurrentY = 5040
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("  Depth Clearance (under keel) = Charted Depth + Height of Tide above MLLW - Boat's Draft")
		'UPGRADE_ISSUE: Form method Form25.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print(TAB(30), " = " & Val(txtCD.Text) & " + " & CStr(Val(txtHeight.Text)) & " - " & CStr(Val(txtDraft.Text)) & " = " & CStr(DC))
	End Sub
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        'UPGRADE_ISSUE: Form method Form25.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        'If Form23.Flag = False Then
        txtHeight.Clear()
        txtCH.Clear()
        txtMTR.Clear()
        txtMTL.Clear()
        txtCD.Clear()
        txtDraft.Clear()
        txtBH.Clear()
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click

        '    Printer.ColorMode = vbPRCMMonochrome
        '    Form1.PrintForm
        '    Printer.ColorMode = vbPRCMColor
        '    Dim FormHeight As Integer, FormWidth As Integer
        'FormHeight = VB6.PixelsToTwipsY(Me.Height)
        'FormWidth = VB6.PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form25_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'UPGRADE_ISSUE: Form method Form25.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        If Form23.Flag = False Then
            txtHeight.Clear()
        End If
        txtCH.Clear()
        txtMTR.Clear()
        txtMTL.Clear()
        txtCD.Clear()
        txtDraft.Clear()
        txtBH.Clear()
    End Sub
	
	'UPGRADE_WARNING: Event txtBH.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtBH_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBH.TextChanged
		If Val(txtBH.Text) > 999.9 Then
			txtBH.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtBH.Text) <= 999.9 Then
			txtCH.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtBH_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBH.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtCH.Text, ".") Then
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
	
	Private Sub txtBH_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBH.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtBH.Text) > 999.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtBH_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBH.Enter
		SelectAllText(txtBH)
	End Sub
	
	'UPGRADE_WARNING: Event txtCD.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCD_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCD.TextChanged
		If Val(txtCD.Text) > 99.9 Then
			txtCD.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtCD.Text) <= 99.9 Then
			txtCD.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtCD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCD.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtCH.Text, ".") Then
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
	
	Private Sub txtCD_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCD.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtCD.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtCD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCD.Enter
		SelectAllText(txtCD)
	End Sub
	
	'UPGRADE_WARNING: Event txtCH.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtCH_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCH.TextChanged
		If Val(txtCH.Text) > 999.9 Then
			txtCH.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtCH.Text) <= 999.9 Then
			txtCH.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtCH_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCH.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtCH.Text, ".") Then
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
	
	Private Sub txtCH_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCH.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtCH.Text) > 999.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtCH_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCH.Enter
		SelectAllText(txtCH)
	End Sub
	
	'UPGRADE_WARNING: Event txtDraft.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDraft_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDraft.TextChanged
		If Val(txtDraft.Text) > 99.9 Then
			txtDraft.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtDraft.Text) <= 99.9 Then
			txtDraft.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtDraft_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDraft.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtDraft.Text, ".") Then
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
	
	Private Sub txtDraft_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDraft.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtDraft.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtDraft_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDraft.Enter
		SelectAllText(txtDraft)
	End Sub
	
	'UPGRADE_WARNING: Event txtMTR.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMTR_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMTR.TextChanged
		If Val(txtMTR.Text) > 99.9 Then
			txtMTR.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtMTR.Text) <= 99.9 Then
			txtMTR.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtMTR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMTR.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtMTR.Text, ".") Then
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
	Private Sub txtMTR_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMTR.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMTR.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMTR_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMTR.Enter
		SelectAllText(txtMTR)
	End Sub
	
	'UPGRADE_WARNING: Event txtMTL.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMTL_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMTL.TextChanged
		If Val(txtMTL.Text) > 99.9 Then
			txtMTL.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtMTL.Text) <= 99.9 Then
			txtMTL.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtMTL_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMTL.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtMTL.Text, ".") Then
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
	Private Sub txtMTL_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMTL.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMTL.Text) > 99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMTL_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMTL.Enter
		SelectAllText(txtMTL)
	End Sub
	
	'UPGRADE_WARNING: Event txtHeight.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtHeight_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHeight.TextChanged
		If System.Math.Abs(Val(txtHeight.Text)) > 99.9 Then
			txtHeight.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		'If Val(txtHeight.text) <= 99.9 Then
		'    txtHeight.BackColor = &H80000005
		'End If
		If System.Math.Abs(Val(txtHeight.Text)) <= 99.9 Then txtHeight.Enabled = True : txtHeight.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		
	End Sub
	
	Private Sub txtHeight_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Static bMinusSignAlready As Boolean
		'Static bPlusSignAlready As Boolean
		bMinusSignAlready = False
		'bPlusSignAlready = False
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
				If txtHeight.SelectionStart <> 0 Or bMinusSignAlready Then
					KeyAscii = 0
					Beep()
				Else
					bMinusSignAlready = True
				End If
				'Case Asc("+")
				'If Len(txtHeight.Text) > 0 Then
				'    KeyAscii = 0
				'    Beep
				'End If
				
				'    If txtHeight.SelStart <> 0 Or bPlusSignAlready Then
				'        KeyAscii = 0
				'        Beep
				'    Else
				'       bPlusSignAlready = True
				'    End If
				
			Case Asc(".") 'only allows one decimal point
				If InStr(txtHeight.Text, ".") Then
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
	Private Sub txtHeight_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHeight.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtHeight.Text) > 99.9 Or Val(txtHeight.Text) < -99.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtHeight_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHeight.Enter
		SelectAllText(txtHeight)
	End Sub
	
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class