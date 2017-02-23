Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form17
	Inherits System.Windows.Forms.Form
	Dim ChartedVariation, CorrVar As Single
	Dim Variation, AnnualChange, Years, Deviation As Short
	Dim Change As Integer
	Dim valtxtDeviation, valtxtVariation, valtxtTrue, valtxtMagnetic, valtxtCompass As Single
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		txtTrue.Text = "" : txtMagnetic.Text = "" : txtCompass.Text = "" : txtVariation.Text = "" : txtDeviation.Text = "" : valtxtTrue = 0 : valtxtVariation = 0 : valtxtMagnetic = 0 : valtxtDeviation = 0 : valtxtCompass = 0
	End Sub
	
	'UPGRADE_WARNING: Event cboCV.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboCV_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCV.SelectedIndexChanged
		CorrectedVariation()
	End Sub
	
	'UPGRADE_WARNING: Event cboIncDec.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboIncDec_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboIncDec.SelectedIndexChanged
		CorrectedVariation()
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form17_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim CompFlag As Object
        Dim MagFlag As Object
        Dim TrueFlag As Object
        cboV.SelectedIndex = 0 '"W"
        cboD.SelectedIndex = 0 '"W"
        cboCV.SelectedIndex = 0 '"W"
        cboIncDec.SelectedIndex = 0 '"Increasing"
        txtYI.Text = CStr(Year(Today))
        txtTrue.Text = ""
        txtMagnetic.Text = ""
        txtCompass.Text = ""
        txtVariation.Text = ""
        txtDeviation.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object TrueFlag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TrueFlag = False
        'UPGRADE_WARNING: Couldn't resolve default property of object MagFlag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        MagFlag = False
        'UPGRADE_WARNING: Couldn't resolve default property of object CompFlag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CompFlag = False
    End Sub

    Private Sub CorrectedVariation()
        'If txtCY = "" Then MsgBox "No chart year"
        ChartedVariation = 60 * Val(txtCVDeg.Text) + Val(txtCVMin.Text)
        AnnualChange = Val(txtChange.Text) : If cboIncDec.Text = "Decreasing" Then AnnualChange = -AnnualChange
        Years = Val(txtYI.Text) - Val(txtCY.Text)
        Change = CInt(AnnualChange) * Years
        CorrVar = ChartedVariation + Change
        CorrVar = CorrVar / 60
        CorrVar = Int(CorrVar + 0.5)
        txtEW.Text = cboCV.Text
        If CorrVar < 0 And cboCV.Text = "E " Then txtEW.Text = "W"
        If CorrVar < 0 And cboCV.Text = "W " Then txtEW.Text = "E"
        If System.Math.Abs(CorrVar) > 99 Then txtCorrVar.BackColor = System.Drawing.ColorTranslator.FromOle(&HC8FF) Else txtCorrVar.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        If System.Math.Abs(CorrVar) > 99 Then txtEW.BackColor = System.Drawing.ColorTranslator.FromOle(&HC8FF) Else txtEW.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        txtCorrVar.Text = Str(System.Math.Abs(CorrVar))
    End Sub

    'UPGRADE_WARNING: Event txtChange.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtChange_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChange.TextChanged
        If Val(txtChange.Text) > 59 Then
            txtChange.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtChange.Text) < 60 Then
            'txtChange.ForeColor = &H80000008
            txtChange.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        CorrectedVariation()
    End Sub
    Private Sub txtChange_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChange.KeyPress
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
    Private Sub txtChange_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtChange.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtChange.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtChange_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChange.Enter
        SelectAllText(txtChange)
    End Sub



    'UPGRADE_WARNING: Event txtCVDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtCVDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVDeg.TextChanged
        CorrectedVariation()
    End Sub
    Private Sub txtCVDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCVDeg.KeyPress
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
    Private Sub txtCVDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVDeg.Enter
        SelectAllText(txtCVDeg)
    End Sub

    'UPGRADE_WARNING: Event txtCVMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtCVMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVMin.TextChanged
        If Val(txtCVMin.Text) > 59 Then
            txtCVMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtCVMin.Text) < 60 Then
            'txtCVMin.ForeColor = &H80000008
            txtCVMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        CorrectedVariation()
    End Sub
    Private Sub txtCVMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCVMin.KeyPress
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
    Private Sub txtCVMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCVMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCVMin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCVMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVMin.Enter
        SelectAllText(txtCVMin)
    End Sub

    'UPGRADE_WARNING: Event txtCY.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtCY_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCY.TextChanged
        CorrectedVariation()
    End Sub
    Private Sub txtCY_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCY.KeyPress
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
    Private Sub txtCY_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCY.Enter
        SelectAllText(txtCY)
    End Sub

    'Private Sub txtDeviation_Change()
    '    Deviation = Val(txtDeviation): If cboD = "E " Then Deviation = -Val(txtDeviation)
    '    'If optDown = True Then txtTrue_Change: txtMagnetic_Change: txtCompass_Change
    '    'If optUp = True Then txtCompass_Change: txtMagnetic_Change: txtTrue_Change
    'End Sub
    'UPGRADE_WARNING: Event cboD.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboD_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboD.SelectedIndexChanged
        valtxtDeviation = Val(txtDeviation.Text) : If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        DisplayD()
        'If optDown = True Then txtCompass_KeyPress
        'If optUp = True Then txtMagnetic_KeyPress ': txtTrue_Change
    End Sub

    'Private Sub txtVariation_Change()
    '   Variation = Val(txtVariation): If cboV = "E " Then Variation = -Val(txtVariation)
    '    If optDown = True Then txtTrue_Change: txtMagnetic_Change: txtCompass_Change
    '    If optUp = True Then txtCompass_Change: txtMagnetic_Change: txtTrue_Change
    'End Sub
    'UPGRADE_WARNING: Event cboV.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboV_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboV.SelectedIndexChanged
        valtxtVariation = Val(txtVariation.Text) : If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        'If optDown = True Then txtTrue_KeyPress: txtMagnetic_KeyPress: txtCompass_KeyPress
        'If optUp = True Then txtCompass_KeyPress: txtMagnetic_KeyPress: txtTrue_KeyPress
        DisplayV()
    End Sub



    'UPGRADE_WARNING: Event txtYI.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtYI_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYI.TextChanged
        CorrectedVariation()
    End Sub
    Private Sub txtYI_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtYI.KeyPress
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
    Private Sub txtYI_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYI.Enter
        SelectAllText(txtYI)
    End Sub

    Private Sub txtTrue_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTrue.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtTrue.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then KeyAscii = 0
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtTrue = CSng(Val(txtTrue.Text) & Val(Chr(KeyAscii))) Else valtxtTrue = Val(txtTrue.Text)
        If KeyAscii = System.Windows.Forms.Keys.Back Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then KeyAscii = 0 : Beep()
        DisplayT()
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtTrue_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtTrue.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        'If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtTrue = Val(txtTrue) & Val(Chr$(KeyAscii)) Else valtxtTrue = Val(txtTrue)
        If KeyCode = System.Windows.Forms.Keys.Delete Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        DisplayT()
    End Sub
    'UPGRADE_WARNING: Event txtTrue.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTrue_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrue.TextChanged
        If Val(txtTrue.Text) > 359 Then
            txtTrue.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtTrue.Text) < 360 Then
            'txtTrue.ForeColor = &H80000008
            txtTrue.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtTrue_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTrue.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTrue.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTrue_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrue.Enter
        SelectAllText(txtTrue)
    End Sub

    Private Sub txtVariation_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVariation.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtVariation.Text) = 2 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then KeyAscii = 0
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtVariation = CSng(Val(txtVariation.Text) & Val(Chr(KeyAscii))) Else valtxtVariation = Val(txtVariation.Text)
        If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        If KeyAscii = System.Windows.Forms.Keys.Back Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then KeyAscii = 0 : Beep()
        DisplayV()
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtVariation_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVariation.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        'If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtVariation = Val(txtVariation) & Val(Chr$(KeyAscii)) Else valtxtVariation = Val(txtVariation)
        If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        If KeyCode = System.Windows.Forms.Keys.Delete Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        DisplayV()
    End Sub
    Private Sub txtVariation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVariation.Enter
        SelectAllText(txtVariation)
    End Sub

    Private Sub txtMagnetic_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMagnetic.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtMagnetic.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then KeyAscii = 0
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtMagnetic = CSng(Val(txtMagnetic.Text) & Val(Chr(KeyAscii))) Else valtxtMagnetic = Val(txtMagnetic.Text)
        If KeyAscii = System.Windows.Forms.Keys.Back Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then KeyAscii = 0 : Beep()
        DisplayM()
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtMagnetic_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtMagnetic.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        'If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtMagnetic = Val(txtMagnetic) & Val(Chr$(KeyAscii)) Else valtxtMagnetic = Val(txtMagnetic)
        If KeyCode = System.Windows.Forms.Keys.Delete Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        DisplayM()
    End Sub
    'UPGRADE_WARNING: Event txtMagnetic.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtMagnetic_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagnetic.TextChanged
        If Val(txtMagnetic.Text) > 359 Then
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtMagnetic.Text) < 360 Then
            'txtMagnetic.ForeColor = &H80000008
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtMagnetic_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMagnetic.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMagnetic.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMagnetic_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagnetic.Enter
        SelectAllText(txtMagnetic)
    End Sub

    Private Sub txtDeviation_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeviation.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtDeviation.Text) = 1 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then KeyAscii = 0
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtDeviation = CSng(Val(txtDeviation.Text) & Val(Chr(KeyAscii))) Else valtxtDeviation = Val(txtDeviation.Text)
        If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        If KeyAscii = System.Windows.Forms.Keys.Back Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then KeyAscii = 0 : Beep()
        DisplayD()
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtDeviation_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtDeviation.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        'If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtDeviation = Val(txtDeviation) & Val(Chr$(KeyAscii)) Else valtxtDeviation = Val(txtDeviation)
        If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        If KeyCode = System.Windows.Forms.Keys.Delete Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        DisplayD()
    End Sub
    Private Sub txtDeviation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeviation.Enter
        SelectAllText(txtDeviation)
    End Sub

    Private Sub txtCompass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCompass.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtCompass.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then KeyAscii = 0
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtCompass = CSng(Val(txtCompass.Text) & Val(Chr(KeyAscii))) Else valtxtCompass = Val(txtCompass.Text)
        If KeyAscii = System.Windows.Forms.Keys.Back Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then KeyAscii = 0 : Beep()
        DisplayC()
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtCompass_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtCompass.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        'If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then valtxtCompass = Val(txtCompass) & Val(Chr$(KeyAscii)) Else valtxtCompass = Val(txtCompass)
        If KeyCode = System.Windows.Forms.Keys.Delete Then System.Windows.Forms.SendKeys.Send("{ENTER}")
        DisplayC()
    End Sub
    'UPGRADE_WARNING: Event txtCompass.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtCompass_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCompass.TextChanged
        If Val(txtCompass.Text) > 359 Then
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtCompass.Text) < 360 Then
            'txtCompass.ForeColor = &H80000008
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCompass_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCompass.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCompass.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCompass_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCompass.Enter
        SelectAllText(txtCompass)
    End Sub

    Private Sub DisplayT()
        valtxtVariation = Val(txtVariation.Text) : If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        valtxtDeviation = Val(txtDeviation.Text) : If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        valtxtMagnetic = valtxtTrue + valtxtVariation
        If valtxtMagnetic > 359 Then valtxtMagnetic = valtxtMagnetic - 360
        If valtxtMagnetic < 0 Then valtxtMagnetic = valtxtMagnetic + 360
        valtxtCompass = valtxtMagnetic + valtxtDeviation
        If valtxtCompass > 359 Then valtxtCompass = valtxtCompass - 360
        If valtxtCompass < 0 Then valtxtCompass = valtxtCompass + 360
        txtMagnetic.Text = Format(Str(valtxtMagnetic), "00#")
        txtCompass.Text = Format(Str(valtxtCompass), "00#")
    End Sub
    Private Sub DisplayM()
        valtxtVariation = Val(txtVariation.Text) : If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        valtxtDeviation = Val(txtDeviation.Text) : If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        'If optDown = True Then
        '    valtxtCompass = Val(txtMagnetic) + Val(txtDeviation)
        '    valtxtTrue = Val(txtMagnetic) - Val(txtVariation)
        'End If
        'If optUp = True Then
        '    valtxtTrue = Val(txtMagnetic) - Val(txtVariation)
        'End If
        valtxtCompass = valtxtMagnetic + valtxtDeviation
        valtxtTrue = valtxtMagnetic + valtxtVariation

        If valtxtTrue > 359 Then valtxtTrue = valtxtTrue - 360
        If valtxtTrue < 0 Then valtxtTrue = valtxtTrue + 360
        txtTrue.Text = Format(Str(valtxtTrue), "00#")
        If valtxtCompass > 359 Then valtxtCompass = valtxtCompass - 360
        If valtxtCompass < 0 Then valtxtCompass = valtxtCompass + 360
        txtCompass.Text = Format(Str(valtxtCompass), "00#")
    End Sub
    Private Sub DisplayC()
        valtxtVariation = Val(txtVariation.Text) : If cboV.Text = "E " Then valtxtVariation = -valtxtVariation
        valtxtDeviation = Val(txtDeviation.Text) : If cboD.Text = "E " Then valtxtDeviation = -valtxtDeviation
        valtxtMagnetic = valtxtCompass - valtxtDeviation
        valtxtTrue = valtxtMagnetic - valtxtVariation
        If valtxtTrue > 359 Then valtxtTrue = valtxtTrue - 360
        If valtxtTrue < 0 Then valtxtTrue = valtxtTrue + 360
        txtTrue.Text = Format(Str(valtxtTrue), "00#")
        If valtxtMagnetic > 359 Then valtxtMagnetic = valtxtMagnetic - 360
        If valtxtMagnetic < 0 Then valtxtMagnetic = valtxtMagnetic + 360
        txtMagnetic.Text = Format(Str(valtxtMagnetic), "00#")
    End Sub
    Private Sub DisplayV()
        'valtxtVariation = Val(txtVariation): If cboV = "E " Then valtxtVariation = -valtxtVariation
        'valtxtDeviation = Val(txtDeviation): If cboD = "E " Then valtxtDeviation = -valtxtDeviation
        If optDown.Checked = True Then
            valtxtMagnetic = valtxtTrue + valtxtVariation
            valtxtCompass = valtxtMagnetic + valtxtDeviation
        End If
        If optUp.Checked = True Then
            valtxtTrue = valtxtMagnetic - valtxtVariation
        End If
        If valtxtTrue > 359 Then valtxtTrue = valtxtTrue - 360
        If valtxtTrue < 0 Then valtxtTrue = valtxtTrue + 360
        txtTrue.Text = Format(Str(valtxtTrue), "00#")
        If valtxtMagnetic > 359 Then valtxtMagnetic = valtxtMagnetic - 360
        If valtxtMagnetic < 0 Then valtxtMagnetic = valtxtMagnetic + 360
        txtMagnetic.Text = Format(Str(valtxtMagnetic), "00#")
        txtDeviation.Text = Format(Str(System.Math.Abs(valtxtDeviation)), "##")
        If valtxtCompass > 359 Then valtxtCompass = valtxtCompass - 360
        If valtxtCompass < 0 Then valtxtCompass = valtxtCompass + 360
        txtCompass.Text = Format(Str(valtxtCompass), "00#")
    End Sub
    Private Sub DisplayD()
        'valtxtVariation = Val(txtVariation): If cboV = "E " Then valtxtVariation = -valtxtVariation
        'valtxtDeviation = Val(txtDeviation): If cboD = "E " Then valtxtDeviation = -valtxtDeviation
        If optDown.Checked = True Then
            valtxtCompass = valtxtMagnetic + valtxtDeviation
        End If
        If optUp.Checked = True Then
            valtxtMagnetic = valtxtCompass - valtxtDeviation
            valtxtTrue = valtxtMagnetic - valtxtVariation
        End If
        If valtxtTrue > 359 Then valtxtTrue = valtxtTrue - 360
        If valtxtTrue < 0 Then valtxtTrue = valtxtTrue + 360
        txtTrue.Text = Format(Str(valtxtTrue), "00#")
        txtVariation.Text = Format(Str(System.Math.Abs(valtxtVariation)), "###")
        If valtxtMagnetic > 359 Then valtxtMagnetic = valtxtMagnetic - 360
        If valtxtMagnetic < 0 Then valtxtMagnetic = valtxtMagnetic + 360
        txtMagnetic.Text = Format(Str(valtxtMagnetic), "00#")
        If valtxtCompass > 359 Then valtxtCompass = valtxtCompass - 360
        If valtxtCompass < 0 Then valtxtCompass = valtxtCompass + 360
        txtCompass.Text = Format(Str(valtxtCompass), "00#")
    End Sub
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		Form_Initialize_Renamed()
	End Sub
	Private Sub Form17_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class