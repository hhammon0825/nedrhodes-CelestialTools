Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Friend Class frmSelectPrinter
	Inherits System.Windows.Forms.Form
	
	
	Private Sub CancelButton_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CancelButton_Renamed.Click
		Me.Close()
		'frmSelectPrinter.Visible = False
	End Sub
	
	Private Sub cmdOKButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOKButton.Click
		SelectPrinter(cboPrinterList.Text)
		Me.Close()
		'frmSelectPrinter.Visible = False
	End Sub
	
	'// Populate the Combobox 'cboPrinterList' at Form Load //
	
	Private Sub frmSelectPrinter_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim Printer As New Printer
		
		Dim dev As Printer
		Dim Index, CurrentPrinter As Short
		CurrentPrinter = -1
		Index = 0
		For	Each dev In Printers
			cboPrinterList.Items.Add(dev.DeviceName)
			If Printer.DeviceName = dev.DeviceName Then
				CurrentPrinter = Index
			End If
			Index = Index + 1
		Next dev
		If CurrentPrinter <> -1 Then
			cboPrinterList.SelectedIndex = CurrentPrinter
		End If
		
	End Sub
	Function SelectPrinter(ByVal printer_name As String) As Boolean
		Dim Printer As New Printer
		Dim i As Short
		
		SelectPrinter = False
		For i = 0 To Printers.Count - 1
			' if the specified printer is found, select it and return True
			If Printers(i).DeviceName = printer_name Then
				Printer = Printers(i)
				SelectPrinter = True
				Exit For
			End If
		Next i
	End Function
	
	
	Private Sub frmSelectPrinter_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Cleanup()
	End Sub
End Class