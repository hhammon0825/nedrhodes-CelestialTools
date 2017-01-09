Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility.VB6

Friend Class Form16
	Inherits System.Windows.Forms.Form
    Dim Speed, Distance, Time As Double
    Dim TSpan As TimeSpan
    Dim TSpanDbl As Double
    Dim Flag1, Flag2 As Boolean
	Dim fnumeral As String
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		'Cls
		txtDistance.Text = ""
		txtSpeed.Text = ""
		txtTime.Text = ""
		txtd.Text = ""
		txth.Text = ""
		txtm.Text = ""
		Flag1 = False
		txtTime_TextChanged(txtTime, New System.EventArgs())
		txtd_TextChanged(txtd, New System.EventArgs())
		txth_TextChanged(txth, New System.EventArgs())
        txtm_TextChanged(txtm, New System.EventArgs())
        Refresh()
    End Sub
    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        ' Conversion note: FormHeight and FormWidth defined and initialzed in PrintScreen sub - these statements are redundant and not needed - HRH 01/01/2017
        'FormHeight = PixelsToTwipsY(CDbl(Me.Height))
        'FormWidth = PixelsToTwipsX(CDbl(Me.Width))
        PrintScreen()
    End Sub

    Private Sub cmdDistance_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistance.Click
		Flag1 = True
		'If txtSpeed = "" And (txtTime = "" Or (txth = "" And txtm = "")) Then MsgBox "Not enough inputs": Exit Sub
		If txtTime.Text <> "" Then Distance = Val(txtSpeed.Text) * Val(txtTime.Text) / 60
		If txtTime.Text = "" Then Distance = Val(txtSpeed.Text) * (Val(txtd.Text) * 1440 + Val(txth.Text) * 60 + Val(txtm.Text)) / 60
        If Distance > 9999.9 Then txtDistance.Text = "------" : ExceedsLimit() : Exit Sub
        txtDistance.Text = (Int(Distance * 10 + 0.50000000000001) / 10).ToString("0.0")
        'txtDistance = Str$(Round(Distance, 1))
        Flag1 = False
	End Sub
	
	Private Sub cmdSpeed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSpeed.Click
		Flag1 = True
		'If txtDistance = "" And (txtTime = "" Or (txth = "" And txtm = "")) Then MsgBox "Not enough inputs": Exit Sub
		If Val(txtTime.Text) = 0 And Val(txtd.Text) = 0 And Val(txth.Text) = 0 And Val(txtm.Text) = 0 Then MsgBox("Not enough or illegal inputs") : Exit Sub
		If txtTime.Text <> "" Then Speed = 60 * Val(txtDistance.Text) / Val(txtTime.Text)
		If txtTime.Text = "" Then Speed = 60 * Val(txtDistance.Text) / ((Val(txtd.Text) * 1440 + Val(txth.Text) * 60 + Val(txtm.Text)))
		If Speed > 99.9 Then txtSpeed.Text = "-----" : ExceedsLimit() : Exit Sub
        txtSpeed.Text = (Int(Speed * 10 + 0.50000000000001) / 10).ToString("0.0")
        'txtSpeed = Format(Str$(Round(Speed, 1)), "0.0")
        Flag1 = False
	End Sub

    Private Sub cmdTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTime.Click

        Flag1 = True
        'If txtDistance = "" Or txtSpeed = "" Then MsgBox "Not enough inputs": Exit Sub
        txtTime.Enabled = True : txtd.Enabled = True : txth.Enabled = True : txtm.Enabled = True
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) : txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtSpeed.Text) = 0 Then MsgBox("Not enough or illegal inputs") : Exit Sub

        Time = 60 * Val(txtDistance.Text) / Val(txtSpeed.Text)

        If Time > 59999 Then txtTime.Text = "-----" : txth.Text = "---" : txtm.Text = "--" : ExceedsLimit() : Exit Sub
        TSpanDbl = Time + 0.50000000000001
        TSpan = TimeSpan.FromMinutes(TSpanDbl)
        txtTime.Text = Int(TSpanDbl).ToString("0")

        txtd.Text = TSpan.Days.ToString("0")
        txth.Text = TSpan.Hours.ToString("0")
        txtm.Text = TSpan.Minutes.ToString("0")

        'txtd.Text = (Int(Time / 1440)).ToString("0") & (Int(Time / 60) - CDbl(Str(Int(CDbl(txtd.Text)) * 24))).ToString("0") & (Int(Time + 0.50000000000001) - Int(Time / 60) * 60).ToString("0")
        'txth.Text = VB6.Format(Str(Int(Time / 60) - CDbl(Str(Int(CDbl(txtd.Text)) * 24))), "0")
        'txtm.Text = VB6.Format(Str(Int(Time + 0.50000000000001) - Int(Time / 60) * 60), "0")
        Flag1 = False
    End Sub

    'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
		If Flag1 = True Then Exit Sub
		Flag2 = True
		If txtTime.Text <> "" Then
			txtd.Enabled = False : txtd.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtd.ForeColor = &H80000011
			txth.Enabled = False : txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txth.ForeColor = &H80000011
			txtm.Enabled = False : txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtm.ForeColor = &H80000011
			txtd.Text = "" : txth.Text = "" : txtm.Text = ""
		Else
			txtd.Enabled = True : txtd.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txtd.ForeColor = &H80000005
			txth.Enabled = True : txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txth.ForeColor = &H80000005
			txtm.Enabled = True : txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txtm.ForeColor = &H80000005
		End If
		If Val(txtTime.Text) > 59999 Then
			txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtTime.Text) <= 59999 Then
			'txtTime.ForeColor = &H80000008
			txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		Flag2 = False
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
		'txth.Text = "": txtm.Text = ""
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtTime.Text) > 59999 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
		SelectAllText(txtTime)
	End Sub
	
	'UPGRADE_WARNING: Event txtd.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtd.TextChanged
		If Flag1 = True Then Exit Sub
		If Flag2 = True Then Exit Sub
		'If txtd.Enabled = False Then txtd.Text = ""
		If txtd.Text <> "" Or txth.Text <> "" Or txtm.Text <> "" Then
			txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtTime = ""
		Else
			txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	
	Private Sub txtd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtd.KeyPress
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
	Private Sub txtd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtd.Enter
		SelectAllText(txtd)
	End Sub
	
	'UPGRADE_WARNING: Event txth.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txth_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txth.TextChanged
		If Flag1 = True Then Exit Sub
		If Flag2 = True Then Exit Sub
		'If txth.Enabled = False Then txth.Text = ""
		If txth.Text <> "" Or txtm.Text <> "" Then
			txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtTime = ""
		Else
			txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
	End Sub
	Private Sub txth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txth.KeyPress
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
	Private Sub txth_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txth.Enter
		SelectAllText(txth)
	End Sub
	
	'UPGRADE_WARNING: Event txtm.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtm.TextChanged
		If Flag1 = True Then Exit Sub
		If Flag2 = True Then Exit Sub
		'If txtm.Enabled = False Then txtm.Text = ""
		If txth.Text <> "" Or txtm.Text <> "" Then
			txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) : txtTime.Text = ""
		Else
			txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		End If
		If Val(txtm.Text) > 59 Then
			txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtm.Text) <= 59 Then txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'   'txtm.ForeColor = &H80000008
		'   txtm.BackColor = &H80000005
		'End If
	End Sub
	Private Sub txtm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtm.KeyPress
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
	Private Sub txtm_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtm.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtm.Text) > 59 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtm_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtm.Enter
		SelectAllText(txtm)
	End Sub
	
	'UPGRADE_WARNING: Event txtDistance.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDistance_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDistance.TextChanged
		If Val(txtDistance.Text) > 9999.9 Then
			txtDistance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtDistance.Text) <= 9999.9 Then txtDistance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'txtDistance.ForeColor = &H80000008
		'If Val(txtDistance.Text) <= 999 Then txtDistance.BackColor = &HE0E0E0
	End Sub
	Private Sub txtDistance_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDistance.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtDistance.Text, ".") Then
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
	'Private Sub txtDistance_Validate(KeepFocus As Boolean)
	'    If Val(txtDistance.Text) > 9999 Then
	'        KeepFocus = True
	'    End If
	'End Sub
	Private Sub txtDistance_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDistance.Enter
		SelectAllText(txtDistance)
	End Sub
	
	'UPGRADE_WARNING: Event txtSpeed.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtSpeed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.TextChanged
		If Val(txtSpeed.Text) > 99.9 Then
			txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtSpeed.Text) <= 99.9 Then txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'txtSpeed.ForeColor = &H80000008
		'If Val(txtSpeed.Text) <= 99.9 Then txtSpeed.BackColor = &HE0E0E0
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ExceedsLimit()
        MsgBox("Calculated value exceeds allowed limit.")
    End Sub
    Private Sub Form16_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class