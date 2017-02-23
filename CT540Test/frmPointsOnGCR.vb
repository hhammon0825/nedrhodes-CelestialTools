Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmPointsOnGCR
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub cmdWaypoint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWaypoint.Click
        Dim LPointMin As Double
        Dim LPointDeg As Double
        Dim LPoint As Double
        Dim LoPoint As Double
        Dim Lo2 As Double
        Dim L2 As Double
        Dim Lo1 As Double
        Dim L1 As Double
        Dim Pi As Double
        Pi = 4 * System.Math.Atan(1.0#)
        L1 = Val(Form12.txtL1Deg.Text) + Val(Form12.txtL1Min.Text) / 60
        If Form12.cboL1.Text = "S " Then L1 = -L1
        Lo1 = Val(Form12.txtLo1Deg.Text) + Val(Form12.txtLo1Min.Text) / 60
        If Form12.cboLo1.Text = "E " Then Lo1 = -Lo1
        L2 = Val(Form12.txtL2Deg.Text) + Val(Form12.txtL2Min.Text) / 60
        If Form12.cboL2.Text = "S " Then L2 = -L2
        Lo2 = Val(Form12.txtLo2Deg.Text) + Val(Form12.txtLo2Min.Text) / 60
        If Form12.cboLo2.Text = "E " Then Lo2 = -Lo2

        LoPoint = Val(txtLoPointDeg.Text) + Val(txtLoPointMin.Text) / 60
        If cboLoPoint.Text = "E " Then LoPoint = -LoPoint
        LPoint = System.Math.Atan((System.Math.Sin(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((LoPoint - Lo2) * Pi / 180) - System.Math.Sin(L2 * Pi / 180) * System.Math.Cos(L1 * Pi / 180) * System.Math.Sin((LoPoint - Lo1) * Pi / 180)) / (System.Math.Cos(L1 * Pi / 180) * System.Math.Cos(L2 * Pi / 180) * System.Math.Sin((Lo1 - Lo2) * Pi / 180)))
        LPoint = LPoint * 180 / Pi
        LPointDeg = Int(System.Math.Abs(LPoint))
        LPointMin = (System.Math.Abs(LPoint) - LPointDeg) * 60
        If Int(LPointMin * 10 + 0.5) / 10 = 60 Then
            LPointMin = 0
            LPointDeg = LPointDeg + 1
        End If
        Form12.cmdPoints_Click(Nothing, New System.EventArgs())
        txtGCR.AppendText(Format(LPointDeg, "0") & Chr(176) & Format(LPointMin, "00.0") & "'")
        If LPoint > 0 Then
            txtGCR.AppendText("N")
        End If
        If LPoint = 0 Then
            txtGCR.AppendText(" ")
        End If
        If LPoint < 0 Then
            txtGCR.AppendText("S")
        End If
        txtGCR.AppendText(vbNewLine)
    End Sub

    Private Sub frmPointsOnGCR_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Me.Left = TwipsToPixelsX((PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - PixelsToTwipsX(Me.Width)) / 2)
        'Me.Top = TwipsToPixelsY((PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - PixelsToTwipsY(Me.Height)) / 2)
        cboLoPoint.SelectedIndex = 0 '"W"
	End Sub
	
	Private Sub frmPointsOnGCR_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event txtLoPointDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLoPointDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoPointDeg.TextChanged
		If Val(txtLoPointDeg.Text) <> 180 Then txtLoPointMin.Enabled = True
		If Val(txtLoPointDeg.Text) = 180 Then txtLoPointMin.Text = "" : txtLoPointMin.Enabled = False : txtLoPointMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLoPointDeg.ForeColor = &H80000008
		txtLoPointDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLoPointDeg.Text) > 180 Or (Val(txtLoPointDeg.Text) = 180 And Val(txtLoPointMin.Text) <> 0) Then
			txtLoPointDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLoPointDeg.Text) < 180 Then
			'txtLoPointMin.ForeColor = &H80000008
			txtLoPointMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLoPointMin.Text = "    "
		End If
	End Sub
	
	Private Sub txtLoPointDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoPointDeg.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim fnumeral As String = vbNullString
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
	
	Private Sub txtLoPointDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoPointDeg.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLoPointDeg.Text) > 180 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLoPointDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoPointDeg.Enter
		SelectAllText(txtLoPointDeg)
	End Sub
	
	'UPGRADE_WARNING: Event txtLoPointMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLoPointMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoPointMin.TextChanged
		'txtLoPointMin.ForeColor = &H80000008
		txtLoPointMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLoPointMin.Text) > 59.9 Then
			txtLoPointMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtLoPointMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoPointMin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim fnumeral As String = vbNullString
        Select Case KeyAscii
			Case Asc("0") To Asc("9")
				fnumeral = fnumeral & Chr(KeyAscii)
			Case Asc(".") 'only allows one decimal point
				If InStr(txtLoPointMin.Text, ".") Then
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
	
	Private Sub txtLoPointMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoPointMin.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtLoPointMin.Text) > 59.9 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtLoPointMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoPointMin.Enter
		SelectAllText(txtLoPointMin)
	End Sub
	
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class