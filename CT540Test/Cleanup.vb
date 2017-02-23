Option Strict Off
Option Explicit On
Module Module2
	
	Dim VisibleFormCount As Short

    Public Sub Cleanup()
        Application.Exit()

        'VisibleFormCount = 0
        'If Form1.Visible = True Then 'VisibleFormCount = VisibleFormCount + 1
        '    Form1.ActiveForm.Close()
        'End If
        'If Form2.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form3.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form4.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form5.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form6.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form7.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form8.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form9.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form10.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form11.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form12.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form13.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form14.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form15.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form16.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form17.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form18.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form19.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form20.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form21.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form22.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form23.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form24.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If Form25.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If frmAbout.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If frmCredits.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If frmSelectPrinter.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If frmPrintHelp.Visible = True Then VisibleFormCount = VisibleFormCount + 1
        'If VisibleFormCount = 1 Then
        'UPGRADE_NOTE: Object Form1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form1 = Nothing
        'UPGRADE_NOTE: Object Form2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form2 = Nothing
        'UPGRADE_NOTE: Object Form3 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form3 = Nothing
        'UPGRADE_NOTE: Object Form4 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form4 = Nothing
        'UPGRADE_NOTE: Object Form5 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form5 = Nothing
        'UPGRADE_NOTE: Object Form6 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form6 = Nothing
        'UPGRADE_NOTE: Object Form7 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form7 = Nothing
        'UPGRADE_NOTE: Object Form8 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form8 = Nothing
        'UPGRADE_NOTE: Object Form9 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form9 = Nothing
        'UPGRADE_NOTE: Object Form10 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form10 = Nothing
        'UPGRADE_NOTE: Object Form11 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form11 = Nothing
        'UPGRADE_NOTE: Object Form12 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form12 = Nothing
        'UPGRADE_NOTE: Object Form13 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form13 = Nothing
        'UPGRADE_NOTE: Object Form14 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form14 = Nothing
        'UPGRADE_NOTE: Object Form15 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form15 = Nothing
        'UPGRADE_NOTE: Object Form16 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form16 = Nothing
        'UPGRADE_NOTE: Object Form17 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form17 = Nothing
        'UPGRADE_NOTE: Object Form18 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form18 = Nothing
        'UPGRADE_NOTE: Object Form19 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form19 = Nothing
        'UPGRADE_NOTE: Object Form20 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form20 = Nothing
        'UPGRADE_NOTE: Object Form21 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form21 = Nothing
        'UPGRADE_NOTE: Object Form22 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form22 = Nothing
        'UPGRADE_NOTE: Object Form23 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form23 = Nothing
        'UPGRADE_NOTE: Object Form24 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form24 = Nothing
        'UPGRADE_NOTE: Object Form25 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'Form25 = Nothing
        'UPGRADE_NOTE: Object frmAbout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'frmAbout = Nothing
        'Set frmCredits = Nothing
        'UPGRADE_NOTE: Object frmSelectPrinter may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        'frmSelectPrinter = Nothing
        'Set frmPrintHelp=Nothing
        'End
        'End If
        Exit Sub
    End Sub
End Module