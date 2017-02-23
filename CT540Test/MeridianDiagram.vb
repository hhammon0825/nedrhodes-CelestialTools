Option Strict Off
Option Explicit On
Friend Class Form22
    Inherits System.Windows.Forms.Form
    Dim Pi, LHA, ZN, StartPoint, Tau, ZNoriginal, LHAoriginal, TwoPi As Single
    Dim X2, X1, XAlt, L, XBody, YAlt, Y1, Y2 As Single
    Dim oxH, oyH As Double
    Dim SlopeC, SlopeE, radiusH As Single
    Dim oyV, oxV, radiusV As Double
    Dim SlopeEDir As Short
    Dim M As Double ', B As Double
    Dim ColorCode As Double

    Public Sub DisplayMerDiag()
        Dim Y2Dec As Double
        Dim X2Dec As Double
        Dim Y1Dec As Double
        Dim X1Dec As Double
        Dim Dec As Double
        Dim Ho As Double
        'UPGRADE_ISSUE: Form method Form22.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Cls()
        Dim i As Single ', XAlt As Single, YAlt As Single
        'If Form1.FlagMD = True Then L = Form1.Lat: Ho = Form1.HoinMinutes / 60: ZN = Form1.ZN: LHA = Form1.LHA: Dec = Form1.TotDE
        'If Form8.FlagMD = True Then L = Form8.L: Ho = Form8.HoinMinutes / 60: ZN = Form8.ZN: LHA = Form8.LHA: Dec = Form8.Dec
        If Form1.FlagMD = True Then
            L = Form1.Lat
            Ho = Form1.Hc : ZN = Form1.ZN : LHA = Form1.LHA
            Dec = Form1.TotDE
        End If
        If Form8.FlagMD = True Then
            L = Form8.L
            Ho = Form8.Htot
            ZN = Form8.ZN
            LHA = Form8.LHA
            Dec = Form8.Dec
        End If
        ZNoriginal = ZN
        LHAoriginal = LHA
        Dim XMD1, YMD1 As Single
        Dim XMD2, YMD2 As Single
        'Form1.Font.Name = "MS Sans Serif"
        'UPGRADE_ISSUE: Form method Form22.Scale was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Dim ScaleSizef As New SizeF
        ScaleSizef.Height = 3442
        ScaleSizef.Width = -3442
        Me.Scale(ScaleSizef)
        'Me.Scale(-3442, 3442) '- (3442, -3442)
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'

        DrawStyle = 0
        'UPGRADE_ISSUE: Form property Form22.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawWidth = 2
        'Show
        'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Circle(0, 0), 3000
		'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line(-3000, 0) - (3000, 0) 'horizon
		'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.Line(0, -3000) - (0, 3000)
        
		'DrawWidth = 1
		For i = 0 To TwoPi Step TwoPi / 72 '5º marks
            XMD1 = 2900 * System.Math.Cos(i)
            YMD1 = 2900 * System.Math.Sin(i)
            XMD2 = 3000 * System.Math.Cos(i)
            YMD2 = 3000 * System.Math.Sin(i)
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(XMD1, YMD1) - (XMD2, YMD2)
		Next i
        For i = 0 To TwoPi Step TwoPi / 36 '10º marks
            XMD1 = 2800 * System.Math.Cos(i)
            YMD1 = 2800 * System.Math.Sin(i)
            XMD2 = 2900 * System.Math.Cos(i)
            YMD2 = 2900 * System.Math.Sin(i)
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(XMD1, YMD1) - (XMD2, YMD2)
		Next i
        'lblN.Visible = True
        'lblS.Visible = True
        'lblZ.Visible = True
        'Equator
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(-3000 * System.Math.Cos((90 - L) * Pi / 180), -3000 * System.Math.Sin((90 - L) * Pi / 180)) - (3000 * System.Math.Cos((90 - L) * Pi / 180), 3000 * System.Math.Sin((90 - L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 5 'invisible
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(0, 0) - (3200 * System.Math.Cos((90 - L) * Pi / 180), 3200 * System.Math.Sin((90 - L) * Pi / 180)) 'for positioning Q
		'CurrentY = CurrentY + 100
		'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Q")
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(0, 0) - (-3200 * System.Math.Cos((90 - L) * Pi / 180), -3200 * System.Math.Sin((90 - L) * Pi / 180)) 'for positioning Q'
		'CurrentY = CurrentY - 10
		'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Print("Q'")
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 0
        'UPGRADE_ISSUE: Form property Form22.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawWidth = 2
        'North Pole
        If System.Math.Sign(L) = 1 Or System.Math.Sign(L) = 0 Then
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(-3000 * System.Math.Cos((180 - L) * Pi / 180), -3000 * System.Math.Sin((180 - L) * Pi / 180)) - (3000 * System.Math.Cos((180 - L) * Pi / 180), 3000 * System.Math.Sin((180 - L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 0) - (3300 * System.Math.Cos((180 - L) * Pi / 180), 3300 * System.Math.Sin((180 - L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'CurrentY = CurrentY + 150
			'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Pn")
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 0) - (-3100 * System.Math.Cos((180 - L) * Pi / 180), -3100 * System.Math.Sin((180 - L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Ps")
        End If
        'South Pole
        If System.Math.Sign(L) = -1 Then
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(-3000 * System.Math.Cos((-L) * Pi / 180), -3000 * System.Math.Sin((-L) * Pi / 180)) - (3000 * System.Math.Cos((-L) * Pi / 180), 3000 * System.Math.Sin((-L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			DrawStyle = 5
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 0) - (3200 * System.Math.Cos((-L) * Pi / 180), 3200 * System.Math.Sin((-L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'CurrentY = CurrentY + 150
			'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Ps")
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 0) - (-3200 * System.Math.Cos((-L) * Pi / 180), -3200 * System.Math.Sin((-L) * Pi / 180)), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
			'UPGRADE_ISSUE: Form method Form22.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Print("Pn")
        End If
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 0
        'UPGRADE_ISSUE: Form property Form22.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawWidth = 2
        'altitude
        'UPGRADE_WARNING: Couldn't resolve default property of object Ho. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        XAlt = 3000 * System.Math.Cos(Ho * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Ho. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        YAlt = 3000 * System.Math.Sin(Ho * Pi / 180)
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(-XAlt, YAlt) - (XAlt, YAlt), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		'declination
		'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X1Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X1Dec = 3000 * System.Math.Cos((Dec + 90 - L) * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Y1Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y1Dec = 3000 * System.Math.Sin((Dec + 90 - L) * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X2Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X2Dec = -3000 * System.Math.Cos((Dec + 270 + L) * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Y2Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y2Dec = 3000 * System.Math.Sin((Dec + 270 + L) * Pi / 180)
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(X1Dec, Y1Dec) - (X2Dec, Y2Dec), &H40C0
		'body
		'UPGRADE_WARNING: Couldn't resolve default property of object Y1Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Y2Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If System.Math.Abs(Y2Dec - Y1Dec) > 0.001 Then 'so body is not shown if Dec=Altitude
            'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            DrawStyle = 1
            'UPGRADE_ISSUE: Form property Form22.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            FillStyle = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object X1Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Y1Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Y2Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object X2Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            XBody = ((X2Dec - X1Dec) / (Y2Dec - Y1Dec)) * (YAlt - Y1Dec) + X1Dec 'This does not work if Dec and Altitude are very close, like within 0.2'
            If System.Math.Abs(XBody) > 3000 Then
                MsgBox("Bad sight.  Check data.")
                'UPGRADE_ISSUE: Form property Form22.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                FillStyle = 1 : Exit Sub
            End If
            'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Circle(XBody, YAlt), 75
			'UPGRADE_ISSUE: Form property Form22.FillStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			FillStyle = 1
        End If

        If optEllipse.Checked = True Then Ellipses()
        If optCircle.Checked = True Then Ellipses() : Circles()

    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        '    Printer.ColorMode = vbPRCMMonochrome
        '    Form1.PrintForm
        '    Printer.ColorMode = vbPRCMColor
        FormHeight = VB6.PixelsToTwipsY(Me.Height)
        FormWidth = VB6.PixelsToTwipsX(Me.Width)
        PrintScreen()
    End Sub

    Private Sub CirclePoint(ByVal Theta As Single, ByVal circle_radius As Single, ByRef x As Single, ByRef y As Single)
        x = circle_radius * System.Math.Cos(Theta)
        y = circle_radius * System.Math.Sin(Theta)
    End Sub
    Private Sub RotatePoint(ByVal Theta As Single, ByRef x As Single, ByRef y As Single)
        Dim new_x As Single
        Dim new_y As Single

        new_x = x * System.Math.Cos(Theta) + y * System.Math.Sin(Theta)
        new_y = x * System.Math.Sin(Theta) - y * System.Math.Cos(Theta)
        x = new_x
        y = new_y
    End Sub
    Private Sub ScalePoint(ByVal scale_x As Single, ByVal scale_y As Single, ByRef x As Single, ByRef y As Single)
        x = x * scale_x
        y = y * scale_y
    End Sub
    Private Sub TranslatePoint(ByVal TX As Single, ByVal TY As Single, ByRef x As Single, ByRef y As Single)
        x = x + TX
        y = y + TY
    End Sub

    'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
        TwoPi = 8 * System.Math.Atan(1)
    End Sub

    Private Sub Form22_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Me.Left = (Screen.Width - Me.Width) / 2
        'Me.Top = (Screen.Height - Me.Height) / 2
    End Sub

    Private Sub Form22_Paint(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Const Pi As Single = 3.14159265
        Dim dtheta As Single
        dtheta = Pi / 120 'keep - makes nice smooth curve
        Const radius As Single = 3000 '1440
        'DrawWidth = 2

        'Dim x0 As Single    'Not really needed?
        'Dim y0 As Single    'Not really needed?
        Dim x As Single
        Dim y As Single
        Dim Theta As Single
        Dim j As Short
        j = 0

        ' Get the first point.
        CirclePoint(0, radius, x, y)
        ScalePoint(1, Tau, x, y)
        RotatePoint(StartPoint, x, y)
        TranslatePoint(0, 0, x, y)
        eventArgs.Graphics.
        'UPGRADE_ISSUE: Form property Form22.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        CurrentX = x

        'UPGRADE_ISSUE: Form property Form22.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        CurrentY = y
        'x0 = x  'Not really needed?
        'y0 = y  'Not really needed?

        ' Draw other points.
        For Theta = 0 To Pi Step dtheta ' was 2 * Pi, changed to Pi for half ellipse, originally started at DTHETA, not 0; may need Pi + dtheta
            j = j + 1
            CirclePoint(Theta, radius, x, y) '* 1.066
            ScalePoint(1, Tau, x, y) '* 1.066
            RotatePoint(StartPoint, x, y) '* 1.066
            TranslatePoint(0, 0, x, y) '* 1.066   'both were 1440
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            If ZNoriginal >= 180 Then Me.Line(x, y) , ColorCode
			If ZNoriginal < 180 And Int(j / 4) Mod 2 = 0 Then
                'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                DrawStyle = 5
                'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                Me.Line(x, y), ColorCode
			End If 'dotted line spaces
            If ZNoriginal < 180 And Int(j / 4) Mod 2 <> 0 Then
                'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                DrawStyle = 0
                'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                Me.Line(x, y), ColorCode
			End If 'dotted line solids
        Next Theta

        ' Close the circle.
        'Line -(x0, y0) 'Not really needed?
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 0
    End Sub

    Public Sub Ellipses()
        Dim Y3 As Object
        Dim X3 As Object
        Dim SignY3 As Object
        Dim SignX3 As Object
        Dim Length As Object
        Dim y As Object
        Dim x As Object
        'UPGRADE_ISSUE: Form property Form22.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawWidth = 1
        'vertical circle
        StartPoint = Pi / 2
        If ZN > 180 Then ZN = 360 - ZN
        Tau = -System.Math.Cos(ZN * Pi / 180)
        ColorCode = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)
        If optEllipse.Checked = True Then Form22_Paint(Me, New System.Windows.Forms.PaintEventArgs(Nothing, Nothing))
        'construction line
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 2
        'CirclePoint ZNoriginal, RADIUS, x, y
        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        x = 3000 * System.Math.Cos((180 - ZNoriginal) * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        y = 3000 * System.Math.Sin((180 - ZNoriginal) * Pi / 180)
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If optEllipse.Checked = True Then Me.Line(x, y) - (x, 0), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)
		'hour circle
		'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 1
        StartPoint = (180 - L) * Pi / 180
        If LHA > 180 Then LHA = 360 - LHA
        Tau = System.Math.Cos(LHA * Pi / 180)
        ColorCode = &H8000
        If optEllipse.Checked = True Then Form22_Paint(Me, New System.Windows.Forms.PaintEventArgs(Nothing, Nothing))
        'construction line
        'X1, Y1 and X2,Y2 are the two possible ends of the construction line, where it hits meridian circle
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 2
        X1 = 3000 * System.Math.Cos((LHAoriginal + 90 - L) * Pi / 180)
        Y1 = 3000 * System.Math.Sin((LHAoriginal + 90 - L) * Pi / 180)
        X2 = 3000 * System.Math.Cos((90 - LHAoriginal - L) * Pi / 180)
        Y2 = 3000 * System.Math.Sin((90 - LHAoriginal - L) * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Length. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Length = System.Math.Sqrt((Y2 - Y1) ^ 2 + (X2 - X1) ^ 2) / 2
        If LHAoriginal >= 0 And LHAoriginal < 180 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object SignX3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SignX3 = 1
            'UPGRADE_WARNING: Couldn't resolve default property of object SignY3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SignY3 = -1
        End If
        If LHAoriginal >= 180 And LHAoriginal < 360 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object SignX3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SignX3 = -1
            'UPGRADE_WARNING: Couldn't resolve default property of object SignY3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SignY3 = 1
        End If
        'X3, Y3 is the point where construction line starts (at equator)
        'UPGRADE_WARNING: Couldn't resolve default property of object Length. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SignX3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X3 = X1 + SignX3 * Length * System.Math.Cos(L * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Length. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SignY3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Y3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y3 = Y1 + SignY3 * (Length * System.Math.Sin(L * Pi / 180))
        'Circle (X3, Y3), 75
        'Line (X1, Y1)-(X2, Y2)
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If optEllipse.Checked = True Then Me.Line(X1, Y1) - (X3, Y3), &H8000
		'SlopeEDir = 1: If Y1 > Y3 Then SlopeE = -1
		'UPGRADE_WARNING: Couldn't resolve default property of object X3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If X3 - X1 = 0 Then X3 = X1 + 1
        'UPGRADE_WARNING: Couldn't resolve default property of object X3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Y3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SlopeE = System.Math.Sign((Y3 - Y1) / (X3 - X1))
        SlopeEDir = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object Y3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If SlopeE = 1 And Y1 < Y3 Then SlopeEDir = -1
        'UPGRADE_WARNING: Couldn't resolve default property of object Y3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If SlopeE = -1 And Y1 > Y3 Then SlopeEDir = -1
        If SlopeE = 0 Then SlopeEDir = System.Math.Sign(X1)
    End Sub
    Private Sub Circles()
        Dim sign As Object
        Dim M2h As Object
        Dim M1h As Object
        Dim Dec As Object
        Dim Y3 As Object
        Dim X3 As Object
        Dim y2h As Object
        Dim x2h As Object
        Dim y1h As Object
        Dim x1h As Object
        Dim Theta As Object
        Dim Z As Object
        Dim EndPoint As Object
        Dim m2V As Object
        Dim m1V As Object
        'UPGRADE_ISSUE: Form property Form22.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawWidth = 1
        'Body is at XBody, YAlt
        'vertical circle
        'End points for vertical circle are 0,3000 and 0,-3000
        If XBody = 0 Then XBody = 1.0E-21
        'UPGRADE_WARNING: Couldn't resolve default property of object m1V. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        m1V = (YAlt - 3000) / (XBody - 0)
        'UPGRADE_WARNING: Couldn't resolve default property of object m2V. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        m2V = (-3000 - YAlt) / (0 - XBody)
        'UPGRADE_WARNING: Couldn't resolve default property of object m2V. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object m1V. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        oxV = (m1V * m2V * (-3000 - 3000) + m1V * (XBody + 0) - m2V * (0 + XBody)) / (2 * (m1V - m2V))
        oyV = 0
        radiusV = System.Math.Sqrt((XBody - oxV) * (XBody - oxV) + (YAlt - 0) * (YAlt - 0))
        If oxV >= 0 Then StartPoint = Pi - System.Math.Atan(3000 / System.Math.Abs(oxV)) Else StartPoint = 2 * Pi - System.Math.Atan(3000 / System.Math.Abs(oxV))
        'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If oxV >= 0 Then
            EndPoint = Pi + System.Math.Atan(3000 / System.Math.Abs(oxV))
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = System.Math.Atan(3000 / System.Math.Abs(oxV))
        End If
        If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 Or ZNoriginal > 270) Then
            'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            DrawStyle = 0
            'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Circle(0, 0), 3000, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta), Pi / 2, 3 * Pi / 2
		End If 'StartPoint = Pi + Atn(3000 / Abs(oxV)) Else StartPoint = Atn(3000 / Abs(oxV))
        If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 And ZNoriginal > 270) Then
            'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            DrawStyle = 1
            'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Circle(0, 0), 3000, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta), 3 * Pi / 2, Pi / 2
		End If ':EndPoint = Pi - Atn(3000 / Abs(oxV)) Else EndPoint = 2 * Pi - Atn(3000 / Abs(oxV))
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 0
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If ZNoriginal < 180 Then DrawStyle = 1
        If ZNoriginal = 90 Then
            'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            DrawStyle = 1
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 3000) - (0, -3000), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)
		End If
        If ZNoriginal = 270 Then
            'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            DrawStyle = 0
            'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            Me.Line(0, 3000) - (0, -3000), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)
		End If
        'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If ZNoriginal <> 90 And ZNoriginal <> 270 And System.Math.Abs(oxV) >= 0.0001 And radiusV < 10000000000.0# Then Me.Circle(oxV, oyV) , radiusV, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta), StartPoint, EndPoint 'And Abs(oxV) >= 0.0001
		'Circle (oxV, oyV), radiusV, vbMagenta, StartPoint, Endpoint
		
		'construction line
		'point where vertical circle intersects horizon is (oxV+radiusV,0), but can be on either side of y axis
		'Circle (oxV + radiusV, 0), 75
		X1 = radiusV - System.Math.Abs(oxV)
        'Y1 = 0
        'point where construction line intersects meridian circle is (oxV + radiusV,3000*sin(arccos((oxV + radiusV)/3000)
        'UPGRADE_WARNING: Couldn't resolve default property of object Z. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Z = X1 / 3000 'Z must be <1 or get square root of negative number
        'UPGRADE_WARNING: Couldn't resolve default property of object Z. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Z = 1 Then Z = -0.99999999999999
        'UPGRADE_WARNING: Couldn't resolve default property of object Z. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Theta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Theta = System.Math.Atan(-Z / System.Math.Sqrt(-Z * Z + 1)) + Pi / 2 'arccos
        'UPGRADE_WARNING: Couldn't resolve default property of object Theta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y2 = (3000 * System.Math.Sin(Theta))
        If ZNoriginal >= 180 Then Y2 = -Y2
        If oxV >= 0 Then X1 = -X1
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 2
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(X1, 0) - (X1, Y2), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)

        'hour circle
        'End points for hour circle are X1H=-3000*cos(L*Pi/180),Y1H=3000*sin(L*Pi/180),X2H=3000*cos(L*Pi/180),Y2H=-3000*sin(L*Pi/180) referred to original circle
        'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        x1h = -3000 * System.Math.Cos(L * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        y1h = 3000 * System.Math.Sin(L * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        x2h = 3000 * System.Math.Cos(L * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        y2h = -3000 * System.Math.Sin(L * Pi / 180)
        'UPGRADE_WARNING: Couldn't resolve default property of object Dec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If 90 - System.Math.Abs(Dec) <= 0.0006 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object X3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            XBody = X3
            'UPGRADE_WARNING: Couldn't resolve default property of object Y3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            YAlt = Y3
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object M1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        M1h = (YAlt - y1h) / (XBody - x1h) ': If Abs(YAlt - y1h) < 0.01 Then M1h = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object M2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        M2h = (y2h - YAlt) / (x2h - XBody) ': If Abs(y2h - YAlt) < 0.01 Then M2h = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object M2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object M1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If M1h = M2h Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object M2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object M1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        oxH = (M1h * M2h * (y2h - y1h) + M1h * (XBody + x2h) - M2h * (x1h + XBody)) / (2 * (M1h - M2h))
        If oxH > 214716800.0# Then oxH = 214716800.0# 'was 2183349376
        If oxH < -2183356799.0# Then oxH = -2183356799.0#
        'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object M1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        oyH = ((-1 / M1h) * (oxH - (x1h + XBody) / 2) + (y1h + YAlt) / 2)
        If oyH > 2199896192.0# Then oyH = 2199896192.0#
        If oyH < -2199889024.0# Then oyH = -2199889024.0#
        radiusH = System.Math.Sqrt((XBody - oxH) * (XBody - oxH) + (YAlt - oyH) * (YAlt - oyH))

        'NEED FOUR CONDITIONS?
        If oxH >= 0 And oyH >= 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
            'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sign = -1
        End If
        If oxH >= 0 And oyH < 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartPoint = Pi + System.Math.Atan((y2h - oyH) / (x2h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sign = 1
        End If
        If oxH < 0 And oyH >= 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
            'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sign = -1
        End If
        If oxH < 0 And oyH < 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y2h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object x1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object y1h. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
            'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sign = 1
        End If
        'x = (y1h - oyH) / radiusH

        'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If System.Math.Abs(StartPoint - EndPoint) >= Pi Then EndPoint = EndPoint - Pi
        If StartPoint < 0 Then StartPoint = StartPoint + 2 * Pi
        If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
        'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If StartPoint > EndPoint And StartPoint < EndPoint + Pi Then StartPoint = StartPoint - Pi
        'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If EndPoint < 0 Then EndPoint = EndPoint + 2 * Pi
        'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi

        If oxH < 0 And oyH >= 0 Then
            StartPoint = StartPoint + Pi
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EndPoint = EndPoint + Pi
            If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
            'UPGRADE_WARNING: Couldn't resolve default property of object EndPoint. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi
        End If

        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 0
        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If ZNoriginal < 180 Then DrawStyle = 1
        '    If LHA = 90 Then DrawStyle = 0: Line (x1h, y1h)-(x2h, y2h), &H8000&
        '    If LHA = 270 Then DrawStyle = 1: Line (x1h, y1h)-(x2h, y2h), &H8000&
        '    If LHA = 0 Then DrawStyle = 0: Line (x1h, y1h)-(x2h, y2h), &H8000&
        '    If LHA = 180 Then DrawStyle = 1: Line (x1h, y1h)-(x2h, y2h), &H8000&
        '    If LHA <> 90 And LHA <> 270 And LHA <> 0 And LHA <> 180 Then Circle (oxH, oyH), radiusH, &H8000&, StartPoint, EndPoint
        'UPGRADE_ISSUE: Form method Form22.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Circle(oxH, oyH), radiusH, &H8000, StartPoint, EndPoint
		
		'If LHA = 0 Then DrawStyle = 0: Exit Sub
		'construction line
		'point where hour circle intersects equator is (X1,Y1)
		'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X1 = radiusH * System.Math.Sin(L * Pi / 180) + sign * oxH
        'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X1 = sign * X1
        'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y1 = (radiusH * System.Math.Cos(L * Pi / 180) + sign * oyH)
        'UPGRADE_WARNING: Couldn't resolve default property of object sign. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y1 = sign * Y1


        'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        DrawStyle = 2

        M = -System.Math.Sin(L * Pi / 180) / System.Math.Cos(L * Pi / 180)
        'B = Y1 - M * X1

        X2 = X1
        Do
            X2 = X2 + SlopeEDir
            Y2 = Y1 + M * (X2 - X1)
            'Debug.Print Abs(9000000 - (X2 * X2 + Y2 * Y2))
        Loop Until System.Math.Abs(9000000 - (X2 * X2 + Y2 * Y2)) < 15000
        'UPGRADE_ISSUE: Form method Form22.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Me.Line(X1, Y1) - (X2, Y2), &H8000
		
		'UPGRADE_ISSUE: Form property Form22.DrawStyle was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		DrawStyle = 0

    End Sub

    Private Sub Form22_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cleanup()
    End Sub

    'UPGRADE_WARNING: Event optCircle.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optCircle_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCircle.CheckedChanged
        If eventSender.Checked Then
            If Form1.FlagSRFLoCNASR = True Then Form1.cmdMerDiag_Click(Nothing, New System.EventArgs())
            If Form8.FlagSRFLoCNASR = True Then Form8.cmdMerDiag_Click(Nothing, New System.EventArgs())
        End If
    End Sub

    'UPGRADE_WARNING: Event optEllipse.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optEllipse_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optEllipse.CheckedChanged
        If eventSender.Checked Then
            If Form1.FlagSRFLoCNASR = True Then Form1.cmdMerDiag_Click(Nothing, New System.EventArgs())
            If Form8.FlagSRFLoCNASR = True Then Form8.cmdMerDiag_Click(Nothing, New System.EventArgs())
        End If
    End Sub
End Class