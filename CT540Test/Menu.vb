Option Strict Off
Option Explicit On
Friend Class Form3
	Inherits System.Windows.Forms.Form
    'Public FZH(10) As Variant, FZM(10) As Variant, FZS(10) As Variant, FMI(10) As Variant, FZN(10) As Variant
    'Public FLD(10) As Variant, FLM(10) As Variant, FL(10) As Variant, FMD(10) As Variant, FMM(10) As Variant, FM(10) As Variant

    Private Sub cmd60DST_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd60DST.Click
        Dim lclForm16 As Form16 = New Form16
        lclForm16.Show()
    End Sub

    Private Sub cmdAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAbout.Click
        'frmAbout.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdArcTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdArcTime.Click
        Form10.Show()
        'NotConvertedYes()
    End Sub
	
	Private Sub cmdCPA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCPA.Click
        'Form20.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdDistances_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistances.Click
        Form14.Show()
        'NotConvertedYes()
    End Sub
	
	Private Sub cmdFavorites_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFavorites.Click
        Form7.Show()
        'NotConvertedYes()
    End Sub
	
	Private Sub cmdHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelp.Click
        'Form6.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdLengthDeg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLengthDeg.Click
        'Form18.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdPlanning_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlanning.Click
        'Form2.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdReduction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReduction.Click
        'Form1.Show()
        NotConvertedYes()
    End Sub

    Private Sub cmdNoon_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNoon.Click
        Dim lclForm5 As Form5 = New Form5
        lclForm5.Show()
        'NotConvertedYes()
    End Sub
    Private Sub cmdSelectPrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectPrinter.Click
        'frmSelectPrinter.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdSailings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSailings.Click
        'Form12.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdCTSSOA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCTSSOA.Click
        'Form13.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdTVMDC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTVMDC.Click
        'Form17.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdTwoBearings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTwoBearings.Click
        'Form21.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub cmdYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdYellow.Click
        'Form19.Show()
        NotConvertedYes()
    End Sub
	
	Private Sub Form3_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
        NotConvertedYes()
    End Sub
	
	Private Sub SRMethod_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SRMethod.Click
        'Form8.Show()
        NotConvertedYes()
    End Sub
	Private Sub cmdAveraging_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAveraging.Click
        'Form9.Show()
        NotConvertedYes()
    End Sub
	Private Sub cmdInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInterpolate.Click
        'Form15.Show()
        NotConvertedYes()
    End Sub
	Private Sub cmdTides_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTides.Click
        'Form23.Show()
        NotConvertedYes()
    End Sub
    Private Sub cmdCurrents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCurrents.Click
        'Form24.Show()
        NotConvertedYes()

    End Sub
    Public Sub NotConvertedYes()
        MessageBox.Show("Form not converted yet")
    End Sub
End Class