Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Friend Class frmPrintHelp
	Inherits System.Windows.Forms.Form
	Private Sub CancelButton_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CancelButton_Renamed.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOKButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOKButton.Click
		Dim Printer As New Printer
		Dim ID As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ID = VB6.GetItemData(cboPrintHelpList, cboPrintHelpList.SelectedIndex)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 1 Then
			Printer.Print(Form6.txtHelpGeneral.Text)
			Printer.Print(Form6.txtHelpPlan.Text)
			Printer.Print(Form6.txtHelpSRF.Text)
			Printer.Print(Form6.txtHelpNoon.Text)
			Printer.Print(Form6.txtHelpYellow.Text)
			Printer.Print(Form6.txtHelpLoCNASR.Text)
			Printer.Print(Form6.txtHelpAveraging.Text)
			Printer.Print(Form6.txtHelpCTS_SOA.Text)
			Printer.Print(Form6.txtHelpMoBoard.Text)
			Printer.Print(Form6.txtHelpTwoBearings.Text)
			Printer.Print(Form6.txtHelpArcTime.Text)
			Printer.Print(Form6.txtHelpSailings.Text)
			Printer.Print(Form6.txtHelpDistances.Text)
			Printer.Print(Form6.txtHelpInterpolate.Text)
			Printer.Print(Form6.txtHelp60DST.Text)
			Printer.Print(Form6.txtHelpTVMDC.Text)
			Printer.Print(Form6.txtHelpLength.Text)
			Printer.Print(Form6.txtHelpTides.Text)
			Printer.Print(Form6.txtHelpCurrents.Text)
			Printer.Print(Form6.txtHelpFavorites.Text)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 2 Then Printer.Print(Form6.txtHelpTwoBearings.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 3 Then Printer.Print(Form6.txtHelp60DST.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 4 Then Printer.Print(Form6.txtHelpArcTime.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 5 Then Printer.Print(Form6.txtHelpCTS_SOA.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 6 Then Printer.Print(Form6.txtHelpCurrents.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 7 Then Printer.Print(Form6.txtHelpDistances.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 8 Then Printer.Print(Form6.txtHelpFavorites.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 9 Then Printer.Print(Form6.txtHelpGeneral.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 10 Then Printer.Print(Form6.txtHelpInterpolate.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 11 Then Printer.Print(Form6.txtHelpLength.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 12 Then Printer.Print(Form6.txtHelpLoCNASR.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 13 Then Printer.Print(Form6.txtHelpMoBoard.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 14 Then Printer.Print(Form6.txtHelpNoon.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 15 Then Printer.Print(Form6.txtHelpAveraging.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 16 Then Printer.Print(Form6.txtHelpPlan.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 17 Then Printer.Print(Form6.txtHelpSRF.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 18 Then Printer.Print(Form6.txtHelpSailings.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 19 Then Printer.Print(Form6.txtHelpTides.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 20 Then Printer.Print(Form6.txtHelpTVMDC.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ID = 21 Then Printer.Print(Form6.txtHelpYellow.Text)
		Printer.EndDoc()
		Me.Close()
	End Sub
	
	Private Sub frmPrintHelp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cboPrintHelpList.Text = "All"
	End Sub
End Class