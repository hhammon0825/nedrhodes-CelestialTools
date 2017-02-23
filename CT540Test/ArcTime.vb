Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form10
	Inherits System.Windows.Forms.Form
	
    Dim TimeHours As Integer
    Dim TimeMinutes As Double
    Dim TimeSeconds As Double
    Dim ArcDegrees As Double
    Dim ArcMinutes As Double
	Dim Lo As Double
    Dim ConvertedTimeMinutes As Integer
    Dim ZM As Integer
    Dim ConvertedTimeHours As Integer
    Dim ConvertedTimeSeconds As Integer

	Public Sub cmdConvert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvert.Click
        Dim ConvertedTime As Double
        Dim TimeInSeconds As Double
        Dim Tdiff As Double
        Dim DLo As Double
        Dim ArcInDegrees As Double
        Dim DecimalHours As Double
        Dim timeinhours As Double
        Dim DecimalDegrees As Double
		If optArcToTime.Checked = True Then
            DecimalDegrees = Val(txtDeg.Text) + Val(txtMin.Text) / 60
            timeinhours = DecimalDegrees / 15
            TimeHours = Convert.ToInt32(timeinhours)
            TimeMinutes = (timeinhours - Convert.ToInt32(timeinhours)) * 60
            TimeSeconds = (TimeMinutes - Int(TimeMinutes)) * 60
			TimeMinutes = Int(TimeMinutes)
			TimeSeconds = Int(TimeSeconds + 0.5)
			If TimeSeconds = 60 Then TimeSeconds = 0 : TimeMinutes = TimeMinutes + 1
			If TimeMinutes = 60 Then TimeMinutes = 0 : TimeHours = TimeHours + 1
			'If TimeHours = 24 Then TimeHours = 0
		End If
		If optTimeToArc.Checked = True Then
            DecimalHours = Val(VB.Left(txtTime.Text, 2)) + Val(Mid(txtTime.Text, 3, 2)) / 60 + Val(Mid(txtTime.Text, 5, 2)) / 3600
            ArcInDegrees = DecimalHours * 15
            ArcDegrees = Int(CDbl(ArcInDegrees))
            ArcMinutes = (ArcInDegrees - Int(CDbl(ArcInDegrees))) * 60
            ArcMinutes = Int(ArcMinutes * 10 + 0.5) / 10
		End If
		
		ZDCalc()
        DLo = Lo - ZM
        Tdiff = 240 * DLo 'seconds
        TimeInSeconds = 3600 * Val(VB.Left(txtTime2.Text, 2)) + 60 * Val(Mid(txtTime2.Text, 3, 2)) + Val(VB.Right(txtTime2.Text, 2))
        If optLMTtoZT.Checked = True Then ConvertedTime = TimeInSeconds + Tdiff
        If optZTtoLMT.Checked = True Then ConvertedTime = TimeInSeconds - Tdiff
        If ConvertedTime > 86400 Then ConvertedTime = ConvertedTime - 86400
        If ConvertedTime < 0 Then ConvertedTime = ConvertedTime + 86400
        ConvertedTimeHours = Int(ConvertedTime / 3600)
        ConvertedTimeMinutes = Int((ConvertedTime - CInt(ConvertedTimeHours) * 3600) / 60)
        ConvertedTimeSeconds = ConvertedTime - CInt(ConvertedTimeHours) * 3600 - ConvertedTimeMinutes * 60
        ConvertedTimeSeconds = Int(ConvertedTimeSeconds + 0.5)
		If ConvertedTimeSeconds = 60 Then ConvertedTimeSeconds = 0 : ConvertedTimeMinutes = ConvertedTimeMinutes + 1
		If ConvertedTimeMinutes = 60 Then ConvertedTimeMinutes = 0 : ConvertedTimeHours = TimeHours + 1
		Display()
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub ZDCalc()
        Dim ZD As Object
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        ZD = Int(Lo / 15 + 0.5)
        If cboLo.Text = "E " Then
            ZD = -ZD : Lo = -Lo
        End If
        ZM = ZD * 15
    End Sub

    Private Sub Form10_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboLo.SelectedIndex = 0 '"W"
    End Sub

    Private Sub Form10_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cleanup()
    End Sub

    'UPGRADE_WARNING: Event optArcToTime.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optArcToTime_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optArcToTime.CheckedChanged
        If eventSender.Checked Then
            If optArcToTime.Checked = True Then
                'Cls()

                txtDeg.Text = ""
                txtMin.Text = ""
                lblTime.Visible = False
                txtTime.Visible = False
                lblArc.Visible = True
                lblDeg.Visible = True
                lblMin.Visible = True
                txtDeg.Visible = True
                txtMin.Visible = True
                Refresh()

            End If
        End If
    End Sub

    Private Sub optLMTtoZT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optLMTtoZT.CheckedChanged
        If eventSender.Checked Then
            If optLMTtoZT.Checked = True Then
                'Cls()
                lblLMT.Visible = True
                lblZT.Visible = False
                Refresh()
            End If
        End If
    End Sub
    Private Sub optZTtoLMT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZTtoLMT.CheckedChanged
        If eventSender.Checked Then
            If optZTtoLMT.Checked = True Then
                'Cls()
                lblZT.Visible = True
                lblLMT.Visible = False
                Refresh()

            End If
        End If
    End Sub
    Private Sub optTimeToArc_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTimeToArc.CheckedChanged
        If eventSender.Checked Then
            If optTimeToArc.Checked = True Then
                'Cls()
                txtTime.Text = ""
                lblTime.Visible = True
                txtTime.Visible = True
                lblArc.Visible = False
                lblDeg.Visible = False
                lblMin.Visible = False
                txtDeg.Visible = False
                txtMin.Visible = False
                Refresh()
            End If
        End If
    End Sub

    Private Sub txtDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.TextChanged
        txtDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDeg.Text) > 359 Then
            txtDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg.KeyPress
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

    Private Sub txtDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDeg.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.Enter
        SelectAllText(txtDeg)
    End Sub

    Private Sub txtMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin.TextChanged
        txtMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin.Text) > 59.9 Then
            txtMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim optHsDMS As Boolean = False
        Dim fnumeral As String = vbNullString

        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If optHsDMS = True Then
                    KeyAscii = 0
                    Beep()
                Else
                    If InStr(txtMin.Text, ".") Then
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

    'UPGRADE_WARNING: Event txtLoDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
        If Val(txtLoDeg.Text) <> 180 Then txtLoMin.Enabled = True
        If Val(txtLoDeg.Text) = 180 Then txtLoMin.Text = "" : txtLoMin.Enabled = False : txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
        If Val(txtLoDeg.Text) < 180 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtLoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoDeg.KeyPress
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
        txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoMin.Text) > 59.9 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtLoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim fnumeral As String = vbNullString
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLoMin.Text, ".") Then
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

    'UPGRADE_WARNING: Event txtTime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
            txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
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

    Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then
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

    Public Sub Display()
        txtArcTime.Clear()
        txtLMTZT.Clear()

        If optArcToTime.Checked = True And (txtDeg.Text <> "" Or txtMin.Text <> "") Then
            txtArcTime.Text = ("Time         " & Format(TimeHours, "00") & "h" & Format(TimeMinutes, "00") & "m" & Format(TimeSeconds, "00") & "s")
        End If
        If optTimeToArc.Checked = True And txtTime.Text <> "" Then
            txtArcTime.Text = (" Arc          " & Format(ArcDegrees, "0") & Chr(176) & Format(ArcMinutes, "00.0") & "'")
        End If
        If txtLoDeg.Text <> "" Or txtLoMin.Text <> "" Or txtTime2.Text <> "" Then
            If optLMTtoZT.Checked = True Then txtLMTZT.Text = ("ZT         ")
            If optZTtoLMT.Checked = True Then txtLMTZT.Text = ("LMT        ")
            txtLMTZT.Text = (Format(ConvertedTimeHours, "00") & "h" & Format(ConvertedTimeMinutes, "00") & "m" & Format(ConvertedTimeSeconds, "00") & "s") & vbNewLine

            txtLMTZT.Text = ("ZM            " & System.Math.Abs(ZM) & Chr(176))
            If ZM > 0 Then txtLMTZT.Text = ("W")
            If ZM < 0 Then txtLMTZT.Text = ("E")
            If ZM = 0 Then txtLMTZT.Text = ("")
        End If
        Refresh()

    End Sub
    Private Sub txtTime2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.TextChanged
        txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime2.Text) = 6 And (Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Val(Mid(txtTime2.Text, 5, 2)) > 59) Then
            txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            MsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTime2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime2.KeyPress
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
	
	Private Sub txtTime2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime2.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Val(Mid(txtTime2.Text, 5, 2)) > 59 Or Len(txtTime2.Text) <> 6 Then
			KeepFocus = True
		End If
		If Len(txtTime2.Text) = 0 Then
			KeepFocus = False
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtTime2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime2.Enter
		SelectAllText(txtTime2)
	End Sub

    'Public Function Time() As Integer
    '    Dim ZTSeconds As Double = 0.0
    '    Dim ZTMinutes As Double = 0.0
    '    Dim ZTHours As Double = 0.0
    '    Dim ZTTemp As Double = 0.0
    '    Dim TimeInSeconds As Double = 0.0
    '    TimeInSeconds = 3600 * Val(VB.Left(txtTime2.Text, 2)) + 60 * Val(Mid(txtTime2.Text, 3, 2)) + Val(VB.Right(txtTime2.Text, 2))
    '    ZTHours = Int(ZTTemp / 3600)
    '    ZTMinutes = Int((ZTTemp - CInt(ZTHours) * 3600) / 60)
    '    ZTSeconds = ZTTemp - CInt(ZTHours) * 3600 - ZTMinutes * 60
    'End Function
    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class