Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form7
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Location was upgraded to Location_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim fnumeral, Location_Renamed As String
	Dim ChangeCount, i, VisibleFormCount As Short
    Dim TypeHorizon As String = "NH"
    'Dim HE As Single, HEinFeet As Double, NHDist As Double
    'Private favorite()

    Private Sub cmdAddLocation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddLocation.Click
		ChangeCount = ChangeCount + 1
		If optHorizonNatural.Checked = True Then
            TypeHorizon = "NH" : txtDsDist.Text = ""
		End If
		If optHorizonArtificial.Checked = True Then
            TypeHorizon = "AH" : txtDsDist.Text = ""
		End If
        If optHorizonDipShort.Checked = True Then TypeHorizon = "DS"
        Location_Renamed = txtNewName.Text & Space(37 - Len(txtNewName.Text))
        Location_Renamed = Location_Renamed & Space(3 - Len(Str(Val(txtLDeg.Text)))) & Format(Val(txtLDeg.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text & Space(2)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtLoDeg.Text)))) & Format(Val(txtLoDeg.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text & Space(4)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtMinAz.Text)))) & Format(Val(txtMinAz.Text), "0") & Chr(176) & Space(5)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtMaxAz.Text)))) & Format(Val(txtMaxAz.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Space(4) & TypeHorizon & Space(3)
        Location_Renamed = Location_Renamed & Space(6 - Len(Str(Val(txtDsDist.Text)))) & txtDsDist.Text & Space(1)
        If optHorizonDipShort.Checked = True Then Location_Renamed = Location_Renamed & cboDsUnit.Text
        If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
            With txtDsDist
                .Focus()
            End With
            MsgBox("You must enter a non-zero value for Ds distance")
            Exit Sub
        End If
        lstFavorites.Items.Add(Location_Renamed)
    End Sub

    Private Sub cmdRemoveLocation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRemoveLocation.Click
        ChangeCount = ChangeCount + 1
        Dim x As Short
        If lstFavorites.SelectedIndex = -1 Then MsgBox("No location selected.") : Exit Sub
        x = MsgBox("Are you sure?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.No Then Exit Sub
        lstFavorites.Items.RemoveAt(lstFavorites.SelectedIndex)
    End Sub

    Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        FileOpen(1, "Favorite_Places.txt", OpenMode.Output)
        For i = 0 To lstFavorites.Items.Count - 1
            PrintLine(1, lstFavorites.Items(i))
        Next i
        FileClose(1)
        ChangeCount = 0
    End Sub

    Private Sub cmdUse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUse.Click
        If lstFavorites.SelectedIndex = -1 Then MsgBox("No location selected.") : Exit Sub
        'lstFavorites.Text is equivalent to lstFavorites.List(lstFavorites.ListIndex)
        Form1.txtLDeg.Text = Mid(lstFavorites.Text, 38, 2)
        Form1.txtLMin.Text = Mid(lstFavorites.Text, 41, 4)
        'Form1.cboL = Mid$(lstFavorites.text, 46, 1)
        If Mid(lstFavorites.Text, 46, 1) = "N" Then Form1.cboL.SelectedIndex = 0 Else Form1.cboL.SelectedIndex = 1
        Form1.txtLoDeg.Text = Mid(lstFavorites.Text, 50, 3)
        Form1.txtLoMin.Text = Mid(lstFavorites.Text, 54, 4)
        'Form1.cboLo = Mid$(lstFavorites.text, 59, 1)
        If Mid(lstFavorites.Text, 59, 1) = "W" Then Form1.cboLo.SelectedIndex = 0 Else Form1.cboLo.SelectedIndex = 1
        Form2.txtLDeg.Text = Mid(lstFavorites.Text, 38, 2)
        Form2.txtLMin.Text = Mid(lstFavorites.Text, 41, 4)
        'Form2.cboL = Mid$(lstFavorites.text, 46, 1)
        If Mid(lstFavorites.Text, 46, 1) = "N" Then Form2.cboL.SelectedIndex = 0 Else Form2.cboL.SelectedIndex = 1
        Form2.txtLoDeg.Text = Mid(lstFavorites.Text, 50, 3)
        Form2.txtLoMin.Text = Mid(lstFavorites.Text, 54, 4)
        'Form2.cboLo = Mid$(lstFavorites.text, 59, 1)
        If Mid(lstFavorites.Text, 59, 1) = "W" Then Form2.cboLo.SelectedIndex = 0 Else Form2.cboLo.SelectedIndex = 1
        Form5.txtDRLDeg.Text = Mid(lstFavorites.Text, 38, 2)
        Form5.txtDRLMin.Text = Mid(lstFavorites.Text, 41, 4)
        'Form5.cboDRL = Mid$(lstFavorites.text, 46, 1)
        If Mid(lstFavorites.Text, 46, 1) = "N" Then Form5.cboDRL.SelectedIndex = 0 Else Form5.cboDRL.SelectedIndex = 1
        Form5.txtLoDeg.Text = Mid(lstFavorites.Text, 50, 3)
        Form5.txtLoMin.Text = Mid(lstFavorites.Text, 54, 4)
        Form8.txtLDeg.Text = Mid(lstFavorites.Text, 38, 2)
        Form8.txtLMin.Text = Mid(lstFavorites.Text, 41, 4)
        'Form8.cboL = Mid$(lstFavorites.text, 46, 1)
        If Mid(lstFavorites.Text, 46, 1) = "N" Then Form8.cboL.SelectedIndex = 0 Else Form8.cboL.SelectedIndex = 1
        Form8.txtLoDeg.Text = Mid(lstFavorites.Text, 50, 3)
        Form8.txtLoMin.Text = Mid(lstFavorites.Text, 54, 4)
        'Form8.cboLo = Mid$(lstFavorites.text, 59, 1)
        If Mid(lstFavorites.Text, 59, 1) = "W" Then Form8.cboLo.SelectedIndex = 0 Else Form8.cboLo.SelectedIndex = 1
        'Form5.cboLo = Mid$(lstFavorites.text, 59, 1)
        If Mid(lstFavorites.Text, 59, 1) = "W" Then Form5.cboLo.SelectedIndex = 0 Else Form5.cboLo.SelectedIndex = 1
        Form2.txtLowAz.Text = Mid(lstFavorites.Text, 65, 3)
        Form2.txtHighAz.Text = Mid(lstFavorites.Text, 74, 3)
        If Mid(lstFavorites.Text, 82, 2) = "DS" Then
            Form1.optHorizonDipShort.Checked = True
            Form1.txtDsDist.Text = Mid(lstFavorites.Text, 87, 5)
            Form1.cboDsUnit.Text = Me.cboDsUnit.Text 'Mid$(lstFavorites.Text, 92, 13)
            Form5.optHorizonDipShort.Checked = True
            Form5.txtDsDist.Text = Mid(lstFavorites.Text, 87, 5)
            Form5.cboDsUnit.Text = Me.cboDsUnit.Text 'Mid$(lstFavorites.Text, 92, 13)
        End If
        If Mid(lstFavorites.Text, 82, 2) = "AH" Then
            Form1.optHorizonArtificial.Checked = True
            Form5.optHorizonArtificial.Checked = True
        End If
        If Mid(lstFavorites.Text, 82, 2) = "NH" Then
            Form1.optHorizonNatural.Checked = True
            Form5.optHorizonNatural.Checked = True
        End If
    End Sub
    Private Sub Form7_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ChangeCount = 0
        On Error GoTo DiskErrorHandler
        cboL.SelectedIndex = 0 ' "N"    '0
        cboLo.SelectedIndex = 0 ' "W"   '0
        cboDsUnit.SelectedIndex = 1 ' "yards"   '1
        i = 0
        Dim favorite(0) As Object 'Was (0 to 25) How to change this on the fly?????
        FileOpen(1, "Favorite_Places.txt", OpenMode.Input)
        Do Until EOF(1)
            favorite(i) = LineInput(1)
            lstFavorites.Items.Insert(i - 1, favorite(i))
            ' SetItemString(lstFavorites, i - 1, favorite(i))
        Loop 
		FileClose(1)
DiskErrorHandler: 
		Select Case Err.Number
			Case 53
				FileOpen(1, "Favorite_Places.txt", OpenMode.Output)
				FileClose(1)
			Case Else
		End Select
		'Resume
	End Sub
	
	Private Sub Form7_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		If ChangeCount = 0 Then
			Cleanup()
			Exit Sub
		End If
		Dim YesNo As Short
		YesNo = MsgBox("Save Location List?", MsgBoxStyle.YesNo)
		If YesNo = MsgBoxResult.Yes Then
			cmdSave_Click(cmdSave, New System.EventArgs())
			Cancel = False
			'Close #1
		Else
			Cancel = False
		End If
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub Form7_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
	
	Private Sub lstFavorites_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstFavorites.DoubleClick
		cmdUse_Click(cmdUse, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonArtificial.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonArtificial_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonArtificial.CheckedChanged
		If eventSender.Checked Then
			If optHorizonArtificial.Checked = True Then
				lblDsDist.Visible = False
				txtDsDist.Visible = False
				'txtDsDist.Enabled = False
				cboDsUnit.Visible = False
				'cboDsUnit.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonDipShort.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonDipShort_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonDipShort.CheckedChanged
		If eventSender.Checked Then
			If optHorizonDipShort.Checked = True Then
				lblDsDist.Visible = True
				txtDsDist.Visible = True
				'txtDsDist.Enabled = True
				cboDsUnit.Visible = True
				'cboDsUnit.Enabled = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optHorizonNatural.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optHorizonNatural_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonNatural.CheckedChanged
		If eventSender.Checked Then
			If optHorizonNatural.Checked = True Then
				lblDsDist.Visible = False
				txtDsDist.Visible = False
				'txtDsDist.Enabled = False
				cboDsUnit.Visible = False
				'cboDsUnit.Enabled = False
			End If
		End If
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
	Private Sub txtDsDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDsDist.Enter
		SelectAllText(txtDsDist)
	End Sub
	
	'UPGRADE_WARNING: Event txtLDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
		If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
		If Val(txtLDeg.Text) = 90 Then txtLMin.Text = "" : txtLMin.Enabled = False : txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
		'txtLDeg.ForeColor = &H80000008
		txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		'    If Val(txtLDeg.text) > 90 Or (Val(txtLDeg.text) = 90 And Val(txtLMin.text) <> 0) Then
		'        txtLDeg.BackColor = &HFF&
		'        MsgBox "Out of Range"
		'    End If
		If Val(txtLDeg.Text) > 90 Then
			txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLDeg.Text) < 90 Then
			'txtLMin.ForeColor = &H80000008
			txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
			'txtLMin.Text = "  "
		End If
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
			txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
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
	
	'UPGRADE_WARNING: Event txtLoDeg.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
		'txtLoDeg.ForeColor = &H80000008
		txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtLoDeg.Text) > 180 Then
			txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
		If Val(txtLoDeg.Text) = 180 Then txtLoMin.Text = "" : txtLoMin.Enabled = False : txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
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
	
	'UPGRADE_WARNING: Event txtMinAz.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMinAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinAz.TextChanged
		'txtMinAz.ForeColor = &H80000008
		txtMinAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtMinAz.Text) > 360 Then
			txtMinAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtMinAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMinAz.KeyPress
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
	
	Private Sub txtMinAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMinAz.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMinAz.Text) > 360 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMinAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinAz.Enter
		SelectAllText(txtMinAz)
	End Sub
	
	'UPGRADE_WARNING: Event txtMaxAz.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtMaxAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMaxAz.TextChanged
		'txtMaxAz.ForeColor = &H80000008
		txtMaxAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
		If Val(txtMaxAz.Text) > 360 Then
			txtMaxAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			MsgBox("Out of Range")
		End If
	End Sub
	
	Private Sub txtMaxAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxAz.KeyPress
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
	
	Private Sub txtMaxAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMaxAz.Validating
		Dim KeepFocus As Boolean = eventArgs.Cancel
		If Val(txtMaxAz.Text) > 360 Then
			KeepFocus = True
		End If
		eventArgs.Cancel = KeepFocus
	End Sub
	Private Sub txtMaxAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMaxAz.Enter
		SelectAllText(txtMaxAz)
	End Sub
	Private Sub txtNewName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNewName.Enter
		SelectAllText(txtNewName)
	End Sub
	Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
		TB.SelectionStart = 0
		TB.SelectionLength = Len(TB.Text)
	End Sub
End Class