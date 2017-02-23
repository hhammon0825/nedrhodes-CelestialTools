Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form9
	Inherits System.Windows.Forms.Form
	Private AverageTimeMinutes, AverageTimeHours, AverageTimeSeconds As Integer
	Private AverageAltitudeDegrees As Integer
	Private AverageAltitudeMinutes As Single
	'Dim DPCount%(9)
	Dim OutOfOrder(9) As Boolean
	Dim WTDiff(9) As Integer
	Dim TimeInSeconds(9) As Double
	Dim fnumeral As String
	Dim AltitudeInArcseconds(9) As Double
	Dim AltDiff(9) As Single
	'UPGRADE_NOTE: Rate was upgraded to Rate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim Rate_Renamed(9) As Single
	Private N, CheckCount, M, i As Short
	Private Analyze As Boolean
	'Dim Flag As Boolean
	Dim Slope, Intercept As Double
	Dim AverageTimeInSeconds, TotalTimeInSeconds, TotalAltitudeInArcseconds, AverageAltitudeInArcseconds As Double
	Dim TotalTimeInSecondsSquared As Double
	
	Private Sub cmdAnalyze_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAnalyze.Click
		Analyze = True
		N = 0 : M = 0
		Slope = 0
		TotalTimeInSeconds = 0 ': TotalAltitudeInArcseconds = 0
		TotalTimeInSecondsSquared = 0
		AverageTimeInSeconds = 0
		AverageAltitudeInArcseconds = 0
		For i = 0 To 9
			If txtTime(i).Text <> "" Then N = N + 1
			If txtHsDeg(i).Text <> "" Or txtHsMin(i).Text <> "" Or txtHsSec(i).Text <> "" Then M = M + 1
			If txtTime(i).Text = "" And txtHsDeg(i).Text = "" And txtHsMin(i).Text = "" And txtHsSec(i).Text = "" Then Check1(i).Visible = False : Check1(i).CheckState = System.Windows.Forms.CheckState.Unchecked
		Next i
		If M <> N Then MsgBox("Data mismatch - number of times does not equal number of altitudes") : Exit Sub
		If M < 2 Then Exit Sub 'cmdAnalyze.Visible = False: cmdAnalyze.Enabled=False
		For i = 0 To N - 1
			'If txtTime(i) = "" Or (txtHsDeg(i) = "" And txtHsMin(i) = "" And txtHsSec(i) = "") Then MsgCox "Data mismatch"
			If txtTime(i).Text = "" And (txtHsDeg(i).Text = "" And txtHsMin(i).Text = "" And txtHsSec(i).Text = "") Then MsgBox("Missing data") : Exit Sub
		Next i
		For i = 0 To M - 1
			Check1(i).Visible = True
			'Check1(i).Enabled = True
			Check1(i).CheckState = System.Windows.Forms.CheckState.Checked
		Next i
		'    lblDifferences.Visible = True
		'    lblTimeDiff.Visible = True
		lblhsDiff.Visible = True
		'    lblhsWTDiff.Visible = True
		'    Line1.Visible = True
		
		For i = 0 To M - 1
			'If Check1(i) = 1 Then CheckCount = CheckCount + 1
			'If Check1(i) = 1 Then TotalTimeInSecondsSquared = (TotalTimeInSeconds + 3600 * Val(Left(txtTime(i).text, 2)) + 60 * Val(Mid(txtTime(i).text, 3, 2)) + Val(Mid(txtTime(i).text, 5, 2))) ^ 2
			TotalTimeInSecondsSquared = TotalTimeInSecondsSquared + (3600 * Val(VB.Left(txtTime(i).Text, 2)) + 60 * Val(Mid(txtTime(i).Text, 3, 2)) + Val(Mid(txtTime(i).Text, 5, 2))) ^ 2
		Next i
		
		For i = 0 To M - 1
			TimeInSeconds(i) = 3600 * Val(VB.Left(txtTime(i).Text, 2)) + 60 * Val(Mid(txtTime(i).Text, 3, 2)) + Val(Mid(txtTime(i).Text, 5, 2))
			AverageTimeInSeconds = AverageTimeInSeconds + TimeInSeconds(i)
			AltitudeInArcseconds(i) = 3600 * Val(txtHsDeg(i).Text) + 60 * Val(txtHsMin(i).Text) + Val(txtHsSec(i).Text)
			AverageAltitudeInArcseconds = AverageAltitudeInArcseconds + AltitudeInArcseconds(i)
			Slope = Slope + TimeInSeconds(i) * AltitudeInArcseconds(i) 'temporary variable, not yet slope
		Next i
		AverageAltitudeInArcseconds = AverageAltitudeInArcseconds / M
		AverageTimeInSeconds = AverageTimeInSeconds / M
		
		
		Slope = (Slope - M * AverageTimeInSeconds * AverageAltitudeInArcseconds) / (TotalTimeInSecondsSquared - M * (AverageTimeInSeconds) ^ 2) 'arcseconds/second
		Slope = Slope / 60 'arcminutes/ssecond
		Intercept = AverageAltitudeInArcseconds / 60 - Slope * AverageTimeInSeconds 'arcminutes
		
		'    For i = 0 To M - 2
		'        WTDiff(i) = TimeInSeconds(i + 1) - TimeInSeconds(i)
		'        AltDiff(i) = AltitudeInArcseconds(i + 1) - AltitudeInArcseconds(i): AltDiff(i) = AltDiff(i) / 60
		'        Rate(i) = AltDiff(i) / WTDiff(i)
		'    Next i
		
		For i = 0 To M - 1
			AltDiff(i) = -((Intercept + Slope * TimeInSeconds(i)) - AltitudeInArcseconds(i) / 60) 'arcminutes, how much actual point differs from linear regression curve
		Next i

        'Cls()
        DisplayAnalysis()
	End Sub
	
	Public Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
		N = 0 : M = 0
		For i = 0 To 9
			If txtTime(i).Text <> "" Then N = N + 1
			If txtHsDeg(i).Text <> "" Or txtHsMin(i).Text <> "" Or txtHsSec(i).Text <> "" Then M = M + 1
		Next i
		If M <> N Then MsgBox("Data mismatch - number of times does not equal number of altitudes") : BlankAverages() : Exit Sub
		If M < 2 Then Exit Sub 'cmdCalculate.Visible = False:cmdCalculate.Enabled=False Should this be 1?
		For i = 0 To N - 1
			'If txtTime(i) = "" Or (txtHsDeg(i) = "" And txtHsMin(i) = "" And txtHsSec(i) = "") Then MsgCox "Data mismatch"
			If txtTime(i).Text = "" And (txtHsDeg(i).Text = "" And txtHsMin(i).Text = "" And txtHsSec(i).Text = "") Then MsgBox("Missing data.  Use Analyze to eliminate a line.") : BlankAverages() : Exit Sub
		Next i
		TotalTimeInSeconds = 0
		CheckCount = 0
		For i = 0 To M - 1
			If Check1(i).CheckState = 1 Then CheckCount = CheckCount + 1
			If Check1(i).CheckState = 1 Then TotalTimeInSeconds = TotalTimeInSeconds + 3600 * Val(VB.Left(txtTime(i).Text, 2)) + 60 * Val(Mid(txtTime(i).Text, 3, 2)) + Val(Mid(txtTime(i).Text, 5, 2))
		Next i
		If CheckCount = 0 Then Exit Sub
		If M = 0 And N = 0 Then MsgBox("No data entered") : Exit Sub
		AverageTimeInSeconds = TotalTimeInSeconds / CheckCount
		AverageTimeHours = Int(AverageTimeInSeconds / 3600)
		AverageTimeMinutes = Int((AverageTimeInSeconds - AverageTimeHours * 3600) / 60)
		AverageTimeSeconds = Int(AverageTimeInSeconds - AverageTimeHours * 3600 - AverageTimeMinutes * 60 + 0.5)
		TotalAltitudeInArcseconds = 0
		For i = 0 To M - 1
			If Check1(i).CheckState = 1 Then TotalAltitudeInArcseconds = TotalAltitudeInArcseconds + 3600 * Val(txtHsDeg(i).Text) + 60 * Val(txtHsMin(i).Text) + Val(txtHsSec(i).Text)
		Next i
		AverageAltitudeInArcseconds = TotalAltitudeInArcseconds / CheckCount
		AverageAltitudeDegrees = Int(AverageAltitudeInArcseconds / 3600)
		AverageAltitudeMinutes = (AverageAltitudeInArcseconds - AverageAltitudeDegrees * 3600) / 60
		AverageAltitudeMinutes = Int(AverageAltitudeMinutes * 10 + 0.5) / 10
        'UPGRADE_ISSUE: Form method Form9.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        DisplayAverages()
		If Analyze = True Then DisplayAnalysis()
	End Sub
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		For i = 0 To 9
			txtTime(i).Text = ""
			txtHsDeg(i).Text = ""
			txtHsMin(i).Text = ""
			txtHsSec(i).Text = ""
		Next i
		'    AverageTimeHours = ""
		'    AverageTimeMinutes = ""
		'    AverageTimeSeconds = ""
		BlankAverages()
		For i = 0 To 9
			Check1(i).Visible = False
			'Check1(i).Enabled = False
		Next i
		For i = 1 To 9
			txtTime(i).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtTime(i).Enabled = False
			txtHsDeg(i).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtHsDeg(i).Enabled = False
			txtHsMin(i).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtHsMin(i).Enabled = False
			txtHsSec(i).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
			txtHsSec(i).Enabled = False
		Next i
		'lblDifferences.Visible = False
		'lblTimeDiff.Visible = False
		lblhsDiff.Visible = False
		'lblhsWTDiff.Visible = False
		'Line1.Visible = False
		Analyze = False
	End Sub
	
	Private Sub Form9_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	'UPGRADE_WARNING: Event optHsDMm.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
		If eventSender.Checked Then
			If optHsDMm.Checked = True Then
				For i = 0 To 9
					txtHsSec(i).Visible = False
					lblHsSec(i).Visible = False
					'txtHsSec(i).Enabled = False
					txtHsMin(i).Text = ""
				Next i
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHsDMS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
		If eventSender.Checked Then
			If optHsDMS.Checked = True Then
				For i = 0 To 9
					txtHsSec(i).Visible = True
					lblHsSec(i).Visible = True
					'txtHsSec(i).Enabled = True
					txtHsMin(i).Text = ""
					txtHsSec(i).Text = ""
				Next i
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
		Dim Index As Short = txtTime.GetIndex(eventSender)
		'txtTime(Index).ForeColor = &H80000008
		txtTime(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Len(txtTime(Index).Text) = 6 And (Val(VB.Left(txtTime(Index).Text, 2)) > 24 Or Val(Mid(txtTime(Index).Text, 3, 2)) > 59 Or Val(Mid(txtTime(Index).Text, 5, 2)) > 59) Then
			txtTime(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Len(txtTime(Index).Text) = 6 And Index < 9 Then
			txtTime(Index + 1).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtTime(Index + 1).Enabled = True
			txtHsDeg(Index + 1).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtHsDeg(Index + 1).Enabled = True
			txtHsMin(Index + 1).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtHsMin(Index + 1).Enabled = True
			txtHsSec(Index + 1).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			txtHsSec(Index + 1).Enabled = True
		End If
		If Index = 0 Then Exit Sub
		OutOfOrder(Index) = False
		If Len(txtTime(Index).Text) = 6 And Val(txtTime(Index).Text) <= Val(txtTime(Index - 1).Text) Then
			txtTime(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of chronological order")
			OutOfOrder(Index) = True
		End If
		'txtTime(Index + 1).ForeColor = &H80000008
		
	End Sub
	Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtTime.GetIndex(eventSender)
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
		Dim Index As Short = txtTime.GetIndex(eventSender)
		If Val(VB.Left(txtTime(Index).Text, 2)) > 24 Or Val(Mid(txtTime(Index).Text, 3, 2)) > 59 Or Val(Mid(txtTime(Index).Text, 5, 2)) > 59 Or Len(txtTime(Index).Text) <> 6 Then
			KeepFocus = True
		End If
		If Len(txtTime(Index).Text) = 0 Then
			KeepFocus = False
		End If
		If Index = 0 Then GoTo EventExitSub
		If OutOfOrder(Index) = True Then
			KeepFocus = True
		End If
EventExitSub: 
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
		Dim Index As Short = txtTime.GetIndex(eventSender)
		SelectAllText(txtTime(Index))
	End Sub
	
	Public Sub DisplayAverages()
        'Me.Font = FontChangeName(Me.Font, "Tahoma") '"MS Sans Serif" "Courier New"
        txtAveraging.Clear()
        'Cls
        txtAveraging.Text = ("Average WT" & Space(33) & "Average hs")
        'Print Tab(13); Format(AverageTimeHours, "00"); Tab(16); "-"; Format(AverageTimeMinutes, "00"); Tab(19); "-"; Format(AverageTimeSeconds, "00");
        txtAveraging.Text = (Format(AverageTimeHours, "00") & "-" & Format(AverageTimeMinutes, "00") & "-" & Format(AverageTimeSeconds, "00") & Space(37 - Len(Str(Val(CStr(AverageAltitudeDegrees))))) & Format(AverageAltitudeDegrees, "0") & Chr(176) & Format(AverageAltitudeMinutes, "00.0") & "'") & vbNewLine
        If Analyze = True Then DisplayAnalysis()
    End Sub
    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        '    Printer.ColorMode = vbPRCMMonochrome
        '    Form1.PrintForm
        '    Printer.ColorMode = vbPRCMColor
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub
    'UPGRADE_WARNING: Event txtHsDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
        Dim Index As Short = txtHsDeg.GetIndex(eventSender)
        'txtHsDeg(Index).ForeColor = &H80000008
        txtHsDeg(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsDeg(Index).Text) > 145 Then
            txtHsDeg(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtHsDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtHsDeg.GetIndex(eventSender)
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
        Dim Index As Short = txtHsDeg.GetIndex(eventSender)
        If Val(txtHsDeg(Index).Text) > 145 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.Enter
        Dim Index As Short = txtHsDeg.GetIndex(eventSender)
        SelectAllText(txtHsDeg(Index))
    End Sub

    'UPGRADE_WARNING: Event txtHsMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtHsMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.TextChanged
        Dim Index As Short = txtHsMin.GetIndex(eventSender)
        'txtHsMin(Index).ForeColor = &H80000008
        txtHsMin(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optHsDMm.Checked = True And Val(txtHsMin(Index).Text) > 59.9 Then
            txtHsMin(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If optHsDMS.Checked = True And Val(txtHsMin(Index).Text) > 59 Then
            txtHsMin(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtHsMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtHsMin.GetIndex(eventSender)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                'DPCount%(i) = 0
                If optHsDMS.Checked = True Then
                    KeyAscii = 0
                    Beep()
                Else
                    If InStr(txtHsMin(Index).Text, ".") Then
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

    Private Sub btnExitAvg_Click(sender As Object, e As EventArgs) Handles btnExitAvg.Click
        Me.Close()

    End Sub

    Private Sub txtHsMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        Dim Index As Short = txtHsMin.GetIndex(eventSender)
        If optHsDMm.Checked = True And Val(txtHsMin(Index).Text) > 59.9 Then
            KeepFocus = True
        End If
        If optHsDMS.Checked = True And Val(txtHsMin(Index).Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.Enter
        Dim Index As Short = txtHsMin.GetIndex(eventSender)
        SelectAllText(txtHsMin(Index))
    End Sub

    'UPGRADE_WARNING: Event txtHsSec.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtHsSec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.TextChanged
        Dim Index As Short = txtHsSec.GetIndex(eventSender)
        'txtHsSec(Index).ForeColor = &H80000008
        txtHsSec(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsSec(Index).Text) > 59 Then
            txtHsSec(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtHsSec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsSec.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtHsSec.GetIndex(eventSender)
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
        Dim Index As Short = txtHsSec.GetIndex(eventSender)
        If Val(txtHsSec(Index).Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsSec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.Enter
        Dim Index As Short = txtHsSec.GetIndex(eventSender)
        SelectAllText(txtHsSec(Index))
    End Sub

    Public Sub BlankAverages()
        Application.Restart()
    End Sub

    Public Sub DisplayAnalysis()
        'Me.Font = FontChangeName(Me.Font, "Tahoma") '"MS Sans Serif" '"Courier New"
        'Cls 'If Analyze = False Then Cls
        'CurrentY = 1300
        'For i = 0 To M - 2
        '    Print Tab(60); Format(WTDiff(i), "#0"); Tab(73); Format(AltDiff(i), "#0.0"); Tab(87); Format(Rate(i), "0.00")
        '    CurrentY = CurrentY + 160
        'Next i
        'UPGRADE_ISSUE: Form property Form9.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CurrentY = 1150
        For i = 0 To M - 1
            'Print(TAB(65))
            If AltDiff(i) > 0 Then
                txtAveraging.Text = ("+")
            End If
            txtAveraging.Text = (Format(AltDiff(i), "#0.0") & "'") & vbNewLine
        Next i

    End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class