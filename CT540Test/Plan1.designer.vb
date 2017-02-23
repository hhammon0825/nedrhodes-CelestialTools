<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form2
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This is required by the Windows Form Designer.
		InitializeComponent()
		Form_Initialize_renamed()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents chkMoon As System.Windows.Forms.CheckBox
	Public WithEvents optCenter As System.Windows.Forms.RadioButton
	Public WithEvents optLimb As System.Windows.Forms.RadioButton
	Public WithEvents FrameZn As System.Windows.Forms.GroupBox
	Public WithEvents txtWarning As System.Windows.Forms.TextBox
	Public WithEvents frmWarning As System.Windows.Forms.Panel
	Public WithEvents optThreeBeach As System.Windows.Forms.RadioButton
	Public WithEvents cmdCW As System.Windows.Forms.Button
	Public WithEvents cmdCCW As System.Windows.Forms.Button
	Public WithEvents optThreeBoat As System.Windows.Forms.RadioButton
	Public WithEvents optTwo As System.Windows.Forms.RadioButton
	Public WithEvents optOff As System.Windows.Forms.RadioButton
	Public WithEvents FrameBest As System.Windows.Forms.GroupBox
	Public WithEvents txtMinimumAltitude As System.Windows.Forms.TextBox
	Public WithEvents chkDST As System.Windows.Forms.CheckBox
	Public WithEvents chkHelper As System.Windows.Forms.CheckBox
	Public WithEvents optW As System.Windows.Forms.RadioButton
	Public WithEvents optE As System.Windows.Forms.RadioButton
	Public WithEvents optS As System.Windows.Forms.RadioButton
	Public WithEvents optN As System.Windows.Forms.RadioButton
	Public WithEvents FrameDirection As System.Windows.Forms.GroupBox
	Public WithEvents chkLimit As System.Windows.Forms.CheckBox
	Public WithEvents optHorizon As System.Windows.Forms.RadioButton
	Public WithEvents optStarFinder As System.Windows.Forms.RadioButton
	Public WithEvents optOverhead As System.Windows.Forms.RadioButton
	Public WithEvents FrameView As System.Windows.Forms.GroupBox
	Public WithEvents chkFirst As System.Windows.Forms.CheckBox
	Public WithEvents chkSecond As System.Windows.Forms.CheckBox
	Public WithEvents chkThird As System.Windows.Forms.CheckBox
	Public WithEvents chkNames As System.Windows.Forms.CheckBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cboDay As System.Windows.Forms.ComboBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents CmdView As System.Windows.Forms.Button
	Public WithEvents cmdData As System.Windows.Forms.Button
	Public WithEvents CmdVisible As System.Windows.Forms.Button
	Public WithEvents txtHighAz As System.Windows.Forms.TextBox
	Public WithEvents txtLowAz As System.Windows.Forms.TextBox
	Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblAzDeg As System.Windows.Forms.Label
	Public WithEvents lblAz1 As System.Windows.Forms.Label
	Public WithEvents FrameDisplay As System.Windows.Forms.GroupBox
	Public WithEvents txtTime As System.Windows.Forms.TextBox
	Public WithEvents txtZDh As System.Windows.Forms.TextBox
	Public WithEvents optZDUT As System.Windows.Forms.RadioButton
	Public WithEvents optZDAuto As System.Windows.Forms.RadioButton
	Public WithEvents optZDManual As System.Windows.Forms.RadioButton
	Public WithEvents FrameZD As System.Windows.Forms.Panel
	Public WithEvents cboZDm As System.Windows.Forms.ComboBox
	Public WithEvents cmdTwilights As System.Windows.Forms.Button
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents cboL As System.Windows.Forms.ComboBox
	Public WithEvents txtLMin As System.Windows.Forms.TextBox
	Public WithEvents txtLDeg As System.Windows.Forms.TextBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents cboMonth As System.Windows.Forms.ComboBox
	Public WithEvents lblBody As System.Windows.Forms.Label
	Public WithEvents lblBodyName As System.Windows.Forms.Label
	Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblAltDeg As System.Windows.Forms.Label
	Public WithEvents lblMinimumAltitude As System.Windows.Forms.Label
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents lblZDDST As System.Windows.Forms.Label
	Public WithEvents lblAlt As System.Windows.Forms.Label
	Public WithEvents lblAz As System.Windows.Forms.Label
	Public WithEvents lblAzimuth As System.Windows.Forms.Label
	Public WithEvents lblAltitude As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lblW As System.Windows.Forms.Label
	Public WithEvents lblE As System.Windows.Forms.Label
	Public WithEvents lblS As System.Windows.Forms.Label
	Public WithEvents lblN As System.Windows.Forms.Label
	Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblEnterTime As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents WEZDAutoManual As System.Windows.Forms.Label
	Public WithEvents lblWEZD As System.Windows.Forms.Label
	Public WithEvents lblZDh As System.Windows.Forms.Label
	Public WithEvents lblZDm As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents lblDRLo As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lblDRL As System.Windows.Forms.Label
	Public WithEvents lblYear As System.Windows.Forms.Label
	Public WithEvents lblMonth As System.Windows.Forms.Label
	Public WithEvents lblDay As System.Windows.Forms.Label
	Public WithEvents lblDate As System.Windows.Forms.Label
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.chkMoon = New System.Windows.Forms.CheckBox
		Me.FrameZn = New System.Windows.Forms.GroupBox
		Me.optCenter = New System.Windows.Forms.RadioButton
		Me.optLimb = New System.Windows.Forms.RadioButton
		Me.frmWarning = New System.Windows.Forms.Panel
		Me.txtWarning = New System.Windows.Forms.TextBox
		Me.FrameBest = New System.Windows.Forms.GroupBox
		Me.optThreeBeach = New System.Windows.Forms.RadioButton
		Me.cmdCW = New System.Windows.Forms.Button
		Me.cmdCCW = New System.Windows.Forms.Button
		Me.optThreeBoat = New System.Windows.Forms.RadioButton
		Me.optTwo = New System.Windows.Forms.RadioButton
		Me.optOff = New System.Windows.Forms.RadioButton
		Me.txtMinimumAltitude = New System.Windows.Forms.TextBox
		Me.chkDST = New System.Windows.Forms.CheckBox
		Me.chkHelper = New System.Windows.Forms.CheckBox
		Me.FrameDirection = New System.Windows.Forms.GroupBox
		Me.optW = New System.Windows.Forms.RadioButton
		Me.optE = New System.Windows.Forms.RadioButton
		Me.optS = New System.Windows.Forms.RadioButton
		Me.optN = New System.Windows.Forms.RadioButton
		Me.chkLimit = New System.Windows.Forms.CheckBox
		Me.FrameView = New System.Windows.Forms.GroupBox
		Me.optHorizon = New System.Windows.Forms.RadioButton
		Me.optStarFinder = New System.Windows.Forms.RadioButton
		Me.optOverhead = New System.Windows.Forms.RadioButton
		Me.chkFirst = New System.Windows.Forms.CheckBox
		Me.chkSecond = New System.Windows.Forms.CheckBox
		Me.chkThird = New System.Windows.Forms.CheckBox
		Me.chkNames = New System.Windows.Forms.CheckBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.cboDay = New System.Windows.Forms.ComboBox
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.FrameDisplay = New System.Windows.Forms.GroupBox
		Me.CmdView = New System.Windows.Forms.Button
		Me.cmdData = New System.Windows.Forms.Button
		Me.CmdVisible = New System.Windows.Forms.Button
		Me.txtHighAz = New System.Windows.Forms.TextBox
		Me.txtLowAz = New System.Windows.Forms.TextBox
		Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblAzDeg = New System.Windows.Forms.Label
		Me.lblAz1 = New System.Windows.Forms.Label
		Me.txtTime = New System.Windows.Forms.TextBox
		Me.txtZDh = New System.Windows.Forms.TextBox
		Me.FrameZD = New System.Windows.Forms.Panel
		Me.optZDUT = New System.Windows.Forms.RadioButton
		Me.optZDAuto = New System.Windows.Forms.RadioButton
		Me.optZDManual = New System.Windows.Forms.RadioButton
		Me.cboZDm = New System.Windows.Forms.ComboBox
		Me.cmdTwilights = New System.Windows.Forms.Button
		Me.cboLo = New System.Windows.Forms.ComboBox
		Me.txtLoMin = New System.Windows.Forms.TextBox
		Me.txtLoDeg = New System.Windows.Forms.TextBox
		Me.cboL = New System.Windows.Forms.ComboBox
		Me.txtLMin = New System.Windows.Forms.TextBox
		Me.txtLDeg = New System.Windows.Forms.TextBox
		Me.txtYear = New System.Windows.Forms.TextBox
		Me.cboMonth = New System.Windows.Forms.ComboBox
		Me.lblBody = New System.Windows.Forms.Label
		Me.lblBodyName = New System.Windows.Forms.Label
		Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblAltDeg = New System.Windows.Forms.Label
		Me.lblMinimumAltitude = New System.Windows.Forms.Label
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lblZDDST = New System.Windows.Forms.Label
		Me.lblAlt = New System.Windows.Forms.Label
		Me.lblAz = New System.Windows.Forms.Label
		Me.lblAzimuth = New System.Windows.Forms.Label
		Me.lblAltitude = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.lblW = New System.Windows.Forms.Label
		Me.lblE = New System.Windows.Forms.Label
		Me.lblS = New System.Windows.Forms.Label
		Me.lblN = New System.Windows.Forms.Label
		Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblEnterTime = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.WEZDAutoManual = New System.Windows.Forms.Label
		Me.lblWEZD = New System.Windows.Forms.Label
		Me.lblZDh = New System.Windows.Forms.Label
		Me.lblZDm = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.lblDRLo = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.lblDRL = New System.Windows.Forms.Label
		Me.lblYear = New System.Windows.Forms.Label
		Me.lblMonth = New System.Windows.Forms.Label
		Me.lblDay = New System.Windows.Forms.Label
		Me.lblDate = New System.Windows.Forms.Label
		Me.FrameZn.SuspendLayout()
		Me.frmWarning.SuspendLayout()
		Me.FrameBest.SuspendLayout()
		Me.FrameDirection.SuspendLayout()
		Me.FrameView.SuspendLayout()
		Me.FrameDisplay.SuspendLayout()
		Me.FrameZD.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Sight Planner"
		Me.ClientSize = New System.Drawing.Size(697, 568)
		Me.Location = New System.Drawing.Point(99, 29)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("Form2.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form2"
		Me.chkMoon.BackColor = System.Drawing.SystemColors.Window
		Me.chkMoon.Text = "Approximate Moon   rise and set data"
		Me.chkMoon.Size = New System.Drawing.Size(113, 25)
		Me.chkMoon.Location = New System.Drawing.Point(576, 40)
		Me.chkMoon.TabIndex = 88
		Me.chkMoon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMoon.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkMoon.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkMoon.CausesValidation = True
		Me.chkMoon.Enabled = True
		Me.chkMoon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkMoon.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkMoon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkMoon.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkMoon.TabStop = True
		Me.chkMoon.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkMoon.Visible = True
		Me.chkMoon.Name = "chkMoon"
		Me.FrameZn.BackColor = System.Drawing.SystemColors.Window
		Me.FrameZn.Text = "Show Zn of - when on visible horizon"
		Me.FrameZn.Size = New System.Drawing.Size(209, 35)
		Me.FrameZn.Location = New System.Drawing.Point(464, 0)
		Me.FrameZn.TabIndex = 84
		Me.FrameZn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameZn.Enabled = True
		Me.FrameZn.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameZn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameZn.Visible = True
		Me.FrameZn.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameZn.Name = "FrameZn"
		Me.optCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optCenter.BackColor = System.Drawing.SystemColors.Window
		Me.optCenter.Text = "Center"
		Me.optCenter.Size = New System.Drawing.Size(57, 17)
		Me.optCenter.Location = New System.Drawing.Point(136, 16)
		Me.optCenter.TabIndex = 86
		Me.optCenter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optCenter.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optCenter.CausesValidation = True
		Me.optCenter.Enabled = True
		Me.optCenter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optCenter.Cursor = System.Windows.Forms.Cursors.Default
		Me.optCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optCenter.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optCenter.TabStop = True
		Me.optCenter.Checked = False
		Me.optCenter.Visible = True
		Me.optCenter.Name = "optCenter"
		Me.optLimb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optLimb.BackColor = System.Drawing.SystemColors.Window
		Me.optLimb.Text = "Upper Limb"
		Me.optLimb.Size = New System.Drawing.Size(81, 17)
		Me.optLimb.Location = New System.Drawing.Point(8, 16)
		Me.optLimb.TabIndex = 85
		Me.optLimb.Checked = True
		Me.optLimb.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optLimb.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optLimb.CausesValidation = True
		Me.optLimb.Enabled = True
		Me.optLimb.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optLimb.Cursor = System.Windows.Forms.Cursors.Default
		Me.optLimb.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optLimb.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optLimb.TabStop = True
		Me.optLimb.Visible = True
		Me.optLimb.Name = "optLimb"
		Me.frmWarning.BackColor = System.Drawing.SystemColors.Window
		Me.frmWarning.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.frmWarning.Enabled = False
		Me.frmWarning.Size = New System.Drawing.Size(60, 26)
		Me.frmWarning.Location = New System.Drawing.Point(256, 174)
		Me.frmWarning.TabIndex = 80
		Me.frmWarning.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frmWarning.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frmWarning.Cursor = System.Windows.Forms.Cursors.Default
		Me.frmWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmWarning.Visible = True
		Me.frmWarning.Name = "frmWarning"
		Me.txtWarning.AutoSize = False
		Me.txtWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtWarning.BackColor = System.Drawing.Color.Blue
		Me.txtWarning.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWarning.ForeColor = System.Drawing.Color.Black
		Me.txtWarning.Size = New System.Drawing.Size(60, 26)
		Me.txtWarning.Location = New System.Drawing.Point(0, 0)
		Me.txtWarning.ReadOnly = True
		Me.txtWarning.MultiLine = True
		Me.txtWarning.TabIndex = 81
		Me.txtWarning.Visible = False
		Me.txtWarning.AcceptsReturn = True
		Me.txtWarning.CausesValidation = True
		Me.txtWarning.Enabled = True
		Me.txtWarning.HideSelection = True
		Me.txtWarning.Maxlength = 0
		Me.txtWarning.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWarning.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWarning.TabStop = True
		Me.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtWarning.Name = "txtWarning"
		Me.FrameBest.BackColor = System.Drawing.SystemColors.Window
		Me.FrameBest.Text = "Best Bodies Aid"
		Me.FrameBest.Size = New System.Drawing.Size(145, 129)
		Me.FrameBest.Location = New System.Drawing.Point(8, 432)
		Me.FrameBest.TabIndex = 73
		Me.FrameBest.Visible = False
		Me.FrameBest.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameBest.Enabled = True
		Me.FrameBest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameBest.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameBest.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameBest.Name = "FrameBest"
		Me.optThreeBeach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optThreeBeach.BackColor = System.Drawing.SystemColors.Window
		Me.optThreeBeach.Text = "Three-body fix (beach)"
		Me.optThreeBeach.Size = New System.Drawing.Size(134, 17)
		Me.optThreeBeach.Location = New System.Drawing.Point(8, 64)
		Me.optThreeBeach.TabIndex = 79
		Me.ToolTip1.SetToolTip(Me.optThreeBeach, "Limited horizon or sky available.")
		Me.optThreeBeach.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optThreeBeach.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optThreeBeach.CausesValidation = True
		Me.optThreeBeach.Enabled = True
		Me.optThreeBeach.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optThreeBeach.Cursor = System.Windows.Forms.Cursors.Default
		Me.optThreeBeach.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optThreeBeach.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optThreeBeach.TabStop = True
		Me.optThreeBeach.Checked = False
		Me.optThreeBeach.Visible = True
		Me.optThreeBeach.Name = "optThreeBeach"
		Me.cmdCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCW.Text = "  Rotate CW"
		Me.cmdCW.Enabled = False
		Me.cmdCW.Size = New System.Drawing.Size(57, 33)
		Me.cmdCW.Location = New System.Drawing.Point(80, 88)
		Me.cmdCW.TabIndex = 78
		Me.cmdCW.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCW.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCW.CausesValidation = True
		Me.cmdCW.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCW.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCW.TabStop = True
		Me.cmdCW.Name = "cmdCW"
		Me.cmdCCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCCW.Text = "  Rotate CCW"
		Me.cmdCCW.Enabled = False
		Me.cmdCCW.Size = New System.Drawing.Size(57, 33)
		Me.cmdCCW.Location = New System.Drawing.Point(8, 88)
		Me.cmdCCW.TabIndex = 77
		Me.cmdCCW.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCCW.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCCW.CausesValidation = True
		Me.cmdCCW.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCCW.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCCW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCCW.TabStop = True
		Me.cmdCCW.Name = "cmdCCW"
		Me.optThreeBoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optThreeBoat.BackColor = System.Drawing.SystemColors.Window
		Me.optThreeBoat.Text = "Three-body fix (boat)"
		Me.optThreeBoat.Size = New System.Drawing.Size(128, 17)
		Me.optThreeBoat.Location = New System.Drawing.Point(8, 48)
		Me.optThreeBoat.TabIndex = 76
		Me.ToolTip1.SetToolTip(Me.optThreeBoat, "Most of horizon and sky available.")
		Me.optThreeBoat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optThreeBoat.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optThreeBoat.CausesValidation = True
		Me.optThreeBoat.Enabled = True
		Me.optThreeBoat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optThreeBoat.Cursor = System.Windows.Forms.Cursors.Default
		Me.optThreeBoat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optThreeBoat.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optThreeBoat.TabStop = True
		Me.optThreeBoat.Checked = False
		Me.optThreeBoat.Visible = True
		Me.optThreeBoat.Name = "optThreeBoat"
		Me.optTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optTwo.BackColor = System.Drawing.SystemColors.Window
		Me.optTwo.Text = "Two-body fix"
		Me.optTwo.Size = New System.Drawing.Size(89, 17)
		Me.optTwo.Location = New System.Drawing.Point(8, 32)
		Me.optTwo.TabIndex = 75
		Me.optTwo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optTwo.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optTwo.CausesValidation = True
		Me.optTwo.Enabled = True
		Me.optTwo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optTwo.Cursor = System.Windows.Forms.Cursors.Default
		Me.optTwo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optTwo.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optTwo.TabStop = True
		Me.optTwo.Checked = False
		Me.optTwo.Visible = True
		Me.optTwo.Name = "optTwo"
		Me.optOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOff.BackColor = System.Drawing.SystemColors.Window
		Me.optOff.Text = "Off"
		Me.optOff.Size = New System.Drawing.Size(49, 17)
		Me.optOff.Location = New System.Drawing.Point(8, 16)
		Me.optOff.TabIndex = 74
		Me.optOff.Checked = True
		Me.optOff.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optOff.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOff.CausesValidation = True
		Me.optOff.Enabled = True
		Me.optOff.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optOff.Cursor = System.Windows.Forms.Cursors.Default
		Me.optOff.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optOff.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optOff.TabStop = True
		Me.optOff.Visible = True
		Me.optOff.Name = "optOff"
		Me.txtMinimumAltitude.AutoSize = False
		Me.txtMinimumAltitude.Size = New System.Drawing.Size(25, 19)
		Me.txtMinimumAltitude.Location = New System.Drawing.Point(656, 176)
		Me.txtMinimumAltitude.Maxlength = 2
		Me.txtMinimumAltitude.TabIndex = 27
		Me.txtMinimumAltitude.Text = "15"
		Me.ToolTip1.SetToolTip(Me.txtMinimumAltitude, "Range 0 to 90")
		Me.txtMinimumAltitude.Visible = False
		Me.txtMinimumAltitude.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMinimumAltitude.AcceptsReturn = True
		Me.txtMinimumAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMinimumAltitude.BackColor = System.Drawing.SystemColors.Window
		Me.txtMinimumAltitude.CausesValidation = True
		Me.txtMinimumAltitude.Enabled = True
		Me.txtMinimumAltitude.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMinimumAltitude.HideSelection = True
		Me.txtMinimumAltitude.ReadOnly = False
		Me.txtMinimumAltitude.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMinimumAltitude.MultiLine = False
		Me.txtMinimumAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMinimumAltitude.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMinimumAltitude.TabStop = True
		Me.txtMinimumAltitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMinimumAltitude.Name = "txtMinimumAltitude"
		Me.chkDST.BackColor = System.Drawing.SystemColors.Window
		Me.chkDST.Text = "Check1"
		Me.chkDST.Size = New System.Drawing.Size(17, 17)
		Me.chkDST.Location = New System.Drawing.Point(408, 48)
		Me.chkDST.TabIndex = 69
		Me.ToolTip1.SetToolTip(Me.chkDST, "Check if Dayslight Saving is in effect")
		Me.chkDST.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDST.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDST.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDST.CausesValidation = True
		Me.chkDST.Enabled = True
		Me.chkDST.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDST.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDST.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDST.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDST.TabStop = True
		Me.chkDST.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDST.Visible = True
		Me.chkDST.Name = "chkDST"
		Me.chkHelper.BackColor = System.Drawing.SystemColors.Window
		Me.chkHelper.Text = "Show Helpers"
		Me.chkHelper.Size = New System.Drawing.Size(105, 17)
		Me.chkHelper.Location = New System.Drawing.Point(568, 328)
		Me.chkHelper.TabIndex = 68
		Me.chkHelper.Visible = False
		Me.chkHelper.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkHelper.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkHelper.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkHelper.CausesValidation = True
		Me.chkHelper.Enabled = True
		Me.chkHelper.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkHelper.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkHelper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkHelper.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkHelper.TabStop = True
		Me.chkHelper.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkHelper.Name = "chkHelper"
		Me.FrameDirection.BackColor = System.Drawing.SystemColors.Window
		Me.FrameDirection.Text = "View toward"
		Me.FrameDirection.Size = New System.Drawing.Size(97, 89)
		Me.FrameDirection.Location = New System.Drawing.Point(8, 320)
		Me.FrameDirection.TabIndex = 61
		Me.FrameDirection.Visible = False
		Me.FrameDirection.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameDirection.Enabled = True
		Me.FrameDirection.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameDirection.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameDirection.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameDirection.Name = "FrameDirection"
		Me.optW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optW.BackColor = System.Drawing.SystemColors.Window
		Me.optW.Text = "West"
		Me.optW.Size = New System.Drawing.Size(65, 17)
		Me.optW.Location = New System.Drawing.Point(8, 64)
		Me.optW.TabIndex = 65
		Me.optW.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optW.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optW.CausesValidation = True
		Me.optW.Enabled = True
		Me.optW.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optW.Cursor = System.Windows.Forms.Cursors.Default
		Me.optW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optW.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optW.TabStop = True
		Me.optW.Checked = False
		Me.optW.Visible = True
		Me.optW.Name = "optW"
		Me.optE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optE.BackColor = System.Drawing.SystemColors.Window
		Me.optE.Text = "East"
		Me.optE.Size = New System.Drawing.Size(73, 17)
		Me.optE.Location = New System.Drawing.Point(8, 48)
		Me.optE.TabIndex = 64
		Me.optE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optE.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optE.CausesValidation = True
		Me.optE.Enabled = True
		Me.optE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optE.Cursor = System.Windows.Forms.Cursors.Default
		Me.optE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optE.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optE.TabStop = True
		Me.optE.Checked = False
		Me.optE.Visible = True
		Me.optE.Name = "optE"
		Me.optS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optS.BackColor = System.Drawing.SystemColors.Window
		Me.optS.Text = "South"
		Me.optS.Size = New System.Drawing.Size(73, 17)
		Me.optS.Location = New System.Drawing.Point(8, 32)
		Me.optS.TabIndex = 63
		Me.optS.Checked = True
		Me.optS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optS.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optS.CausesValidation = True
		Me.optS.Enabled = True
		Me.optS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optS.Cursor = System.Windows.Forms.Cursors.Default
		Me.optS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optS.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optS.TabStop = True
		Me.optS.Visible = True
		Me.optS.Name = "optS"
		Me.optN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optN.BackColor = System.Drawing.SystemColors.Window
		Me.optN.Text = "North"
		Me.optN.Size = New System.Drawing.Size(73, 17)
		Me.optN.Location = New System.Drawing.Point(8, 16)
		Me.optN.TabIndex = 62
		Me.optN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optN.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optN.CausesValidation = True
		Me.optN.Enabled = True
		Me.optN.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optN.Cursor = System.Windows.Forms.Cursors.Default
		Me.optN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optN.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optN.TabStop = True
		Me.optN.Checked = False
		Me.optN.Visible = True
		Me.optN.Name = "optN"
		Me.chkLimit.BackColor = System.Drawing.SystemColors.Window
		Me.chkLimit.Text = "Limit azimuth range"
		Me.chkLimit.Size = New System.Drawing.Size(121, 17)
		Me.chkLimit.Location = New System.Drawing.Point(568, 312)
		Me.chkLimit.TabIndex = 59
		Me.chkLimit.Visible = False
		Me.chkLimit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLimit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkLimit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkLimit.CausesValidation = True
		Me.chkLimit.Enabled = True
		Me.chkLimit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkLimit.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLimit.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkLimit.TabStop = True
		Me.chkLimit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkLimit.Name = "chkLimit"
		Me.FrameView.BackColor = System.Drawing.SystemColors.Window
		Me.FrameView.Text = "View"
		Me.FrameView.Size = New System.Drawing.Size(97, 73)
		Me.FrameView.Location = New System.Drawing.Point(8, 240)
		Me.FrameView.TabIndex = 56
		Me.FrameView.Visible = False
		Me.FrameView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameView.Enabled = True
		Me.FrameView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameView.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameView.Name = "FrameView"
		Me.optHorizon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizon.BackColor = System.Drawing.SystemColors.Window
		Me.optHorizon.Text = "Horizon"
		Me.optHorizon.Size = New System.Drawing.Size(81, 17)
		Me.optHorizon.Location = New System.Drawing.Point(8, 48)
		Me.optHorizon.TabIndex = 60
		Me.optHorizon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizon.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizon.CausesValidation = True
		Me.optHorizon.Enabled = True
		Me.optHorizon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHorizon.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHorizon.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHorizon.TabStop = True
		Me.optHorizon.Checked = False
		Me.optHorizon.Visible = True
		Me.optHorizon.Name = "optHorizon"
		Me.optStarFinder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStarFinder.BackColor = System.Drawing.SystemColors.Window
		Me.optStarFinder.Text = """Star Finder"""
		Me.optStarFinder.Size = New System.Drawing.Size(81, 17)
		Me.optStarFinder.Location = New System.Drawing.Point(8, 32)
		Me.optStarFinder.TabIndex = 58
		Me.optStarFinder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optStarFinder.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStarFinder.CausesValidation = True
		Me.optStarFinder.Enabled = True
		Me.optStarFinder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optStarFinder.Cursor = System.Windows.Forms.Cursors.Default
		Me.optStarFinder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optStarFinder.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optStarFinder.TabStop = True
		Me.optStarFinder.Checked = False
		Me.optStarFinder.Visible = True
		Me.optStarFinder.Name = "optStarFinder"
		Me.optOverhead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOverhead.BackColor = System.Drawing.SystemColors.Window
		Me.optOverhead.Text = "Overhead"
		Me.optOverhead.Size = New System.Drawing.Size(73, 17)
		Me.optOverhead.Location = New System.Drawing.Point(8, 16)
		Me.optOverhead.TabIndex = 57
		Me.optOverhead.Checked = True
		Me.optOverhead.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optOverhead.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOverhead.CausesValidation = True
		Me.optOverhead.Enabled = True
		Me.optOverhead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optOverhead.Cursor = System.Windows.Forms.Cursors.Default
		Me.optOverhead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optOverhead.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optOverhead.TabStop = True
		Me.optOverhead.Visible = True
		Me.optOverhead.Name = "optOverhead"
		Me.chkFirst.BackColor = System.Drawing.SystemColors.Window
		Me.chkFirst.Text = "Show 1st Mag. Stars and S.S. Objects"
		Me.chkFirst.Size = New System.Drawing.Size(129, 25)
		Me.chkFirst.Location = New System.Drawing.Point(568, 240)
		Me.chkFirst.TabIndex = 55
		Me.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkFirst.Visible = False
		Me.chkFirst.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFirst.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkFirst.CausesValidation = True
		Me.chkFirst.Enabled = True
		Me.chkFirst.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFirst.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFirst.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFirst.TabStop = True
		Me.chkFirst.Name = "chkFirst"
		Me.chkSecond.BackColor = System.Drawing.SystemColors.Window
		Me.chkSecond.Text = "Show 2nd Mag. Stars"
		Me.chkSecond.Size = New System.Drawing.Size(129, 17)
		Me.chkSecond.Location = New System.Drawing.Point(568, 264)
		Me.chkSecond.TabIndex = 54
		Me.chkSecond.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkSecond.Visible = False
		Me.chkSecond.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSecond.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkSecond.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkSecond.CausesValidation = True
		Me.chkSecond.Enabled = True
		Me.chkSecond.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkSecond.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSecond.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSecond.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkSecond.TabStop = True
		Me.chkSecond.Name = "chkSecond"
		Me.chkThird.BackColor = System.Drawing.SystemColors.Window
		Me.chkThird.Text = "Show 3rd Mag. Stars"
		Me.chkThird.Size = New System.Drawing.Size(129, 17)
		Me.chkThird.Location = New System.Drawing.Point(568, 280)
		Me.chkThird.TabIndex = 53
		Me.chkThird.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkThird.Visible = False
		Me.chkThird.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkThird.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkThird.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkThird.CausesValidation = True
		Me.chkThird.Enabled = True
		Me.chkThird.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkThird.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkThird.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkThird.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkThird.TabStop = True
		Me.chkThird.Name = "chkThird"
		Me.chkNames.BackColor = System.Drawing.SystemColors.Window
		Me.chkNames.Text = "Show Names"
		Me.chkNames.Size = New System.Drawing.Size(87, 13)
		Me.chkNames.Location = New System.Drawing.Point(568, 296)
		Me.chkNames.TabIndex = 52
		Me.chkNames.Visible = False
		Me.chkNames.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkNames.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkNames.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkNames.CausesValidation = True
		Me.chkNames.Enabled = True
		Me.chkNames.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkNames.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkNames.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkNames.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkNames.TabStop = True
		Me.chkNames.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkNames.Name = "chkNames"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.cboDay.Size = New System.Drawing.Size(41, 21)
		Me.cboDay.Location = New System.Drawing.Point(64, 4)
		Me.cboDay.Items.AddRange(New Object(){"1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
		Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDay.TabIndex = 2
		Me.cboDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDay.BackColor = System.Drawing.SystemColors.Window
		Me.cboDay.CausesValidation = True
		Me.cboDay.Enabled = True
		Me.cboDay.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDay.IntegralHeight = True
		Me.cboDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDay.Sorted = False
		Me.cboDay.TabStop = True
		Me.cboDay.Visible = True
		Me.cboDay.Name = "cboDay"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
		Me.cmdPrint.Location = New System.Drawing.Point(675, 0)
		Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
		Me.cmdPrint.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.FrameDisplay.BackColor = System.Drawing.SystemColors.Window
		Me.FrameDisplay.Text = "Select desired display:"
		Me.FrameDisplay.Size = New System.Drawing.Size(697, 37)
		Me.FrameDisplay.Location = New System.Drawing.Point(0, 193)
		Me.FrameDisplay.TabIndex = 33
		Me.FrameDisplay.Visible = False
		Me.FrameDisplay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameDisplay.Enabled = True
		Me.FrameDisplay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameDisplay.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameDisplay.Name = "FrameDisplay"
		Me.CmdView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdView.Text = "&View Visible Bodies"
		Me.CmdView.Size = New System.Drawing.Size(105, 21)
		Me.CmdView.Location = New System.Drawing.Point(480, 10)
		Me.CmdView.TabIndex = 43
		Me.CmdView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdView.BackColor = System.Drawing.SystemColors.Control
		Me.CmdView.CausesValidation = True
		Me.CmdView.Enabled = True
		Me.CmdView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdView.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdView.TabStop = True
		Me.CmdView.Name = "CmdView"
		Me.cmdData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdData.Text = "Star Finder &Data"
		Me.cmdData.Size = New System.Drawing.Size(89, 21)
		Me.cmdData.Location = New System.Drawing.Point(600, 10)
		Me.cmdData.TabIndex = 42
		Me.cmdData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdData.BackColor = System.Drawing.SystemColors.Control
		Me.cmdData.CausesValidation = True
		Me.cmdData.Enabled = True
		Me.cmdData.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdData.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdData.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdData.TabStop = True
		Me.cmdData.Name = "cmdData"
		Me.CmdVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdVisible.Text = "&List Visible Bodies/Sun-Moon Fix"
		Me.CmdVisible.Size = New System.Drawing.Size(169, 21)
		Me.CmdVisible.Location = New System.Drawing.Point(304, 10)
		Me.CmdVisible.TabIndex = 41
		Me.CmdVisible.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdVisible.BackColor = System.Drawing.SystemColors.Control
		Me.CmdVisible.CausesValidation = True
		Me.CmdVisible.Enabled = True
		Me.CmdVisible.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdVisible.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdVisible.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdVisible.TabStop = True
		Me.CmdVisible.Name = "CmdVisible"
		Me.txtHighAz.AutoSize = False
		Me.txtHighAz.Size = New System.Drawing.Size(25, 19)
		Me.txtHighAz.Location = New System.Drawing.Point(264, 14)
		Me.txtHighAz.Maxlength = 3
		Me.txtHighAz.TabIndex = 39
		Me.txtHighAz.Text = "360"
		Me.ToolTip1.SetToolTip(Me.txtHighAz, "Range 0 to 360")
		Me.txtHighAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHighAz.AcceptsReturn = True
		Me.txtHighAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHighAz.BackColor = System.Drawing.SystemColors.Window
		Me.txtHighAz.CausesValidation = True
		Me.txtHighAz.Enabled = True
		Me.txtHighAz.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHighAz.HideSelection = True
		Me.txtHighAz.ReadOnly = False
		Me.txtHighAz.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHighAz.MultiLine = False
		Me.txtHighAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHighAz.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHighAz.TabStop = True
		Me.txtHighAz.Visible = True
		Me.txtHighAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHighAz.Name = "txtHighAz"
		Me.txtLowAz.AutoSize = False
		Me.txtLowAz.Size = New System.Drawing.Size(25, 19)
		Me.txtLowAz.Location = New System.Drawing.Point(216, 14)
		Me.txtLowAz.Maxlength = 3
		Me.txtLowAz.TabIndex = 35
		Me.txtLowAz.Text = "0"
		Me.ToolTip1.SetToolTip(Me.txtLowAz, "Range 0 to 360")
		Me.txtLowAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLowAz.AcceptsReturn = True
		Me.txtLowAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLowAz.BackColor = System.Drawing.SystemColors.Window
		Me.txtLowAz.CausesValidation = True
		Me.txtLowAz.Enabled = True
		Me.txtLowAz.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLowAz.HideSelection = True
		Me.txtLowAz.ReadOnly = False
		Me.txtLowAz.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLowAz.MultiLine = False
		Me.txtLowAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLowAz.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLowAz.TabStop = True
		Me.txtLowAz.Visible = True
		Me.txtLowAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLowAz.Name = "txtLowAz"
		Me.Line6.BorderColor = System.Drawing.SystemColors.ControlDark
		Me.Line6.X1 = 592
		Me.Line6.X2 = 592
		Me.Line6.Y1 = -6
		Me.Line6.Y2 = 22
		Me.Line6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line6.BorderWidth = 1
		Me.Line6.Visible = True
		Me.Line6.Name = "Line6"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "°"
		Me.Label3.Size = New System.Drawing.Size(9, 17)
		Me.Label3.Location = New System.Drawing.Point(289, 14)
		Me.Label3.TabIndex = 40
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.SystemColors.Window
		Me.Label2.Text = "to"
		Me.Label2.Size = New System.Drawing.Size(9, 17)
		Me.Label2.Location = New System.Drawing.Point(248, 16)
		Me.Label2.TabIndex = 38
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.lblAzDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblAzDeg.Text = "°"
		Me.lblAzDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblAzDeg.Location = New System.Drawing.Point(241, 14)
		Me.lblAzDeg.TabIndex = 37
		Me.lblAzDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAzDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAzDeg.Enabled = True
		Me.lblAzDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAzDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAzDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAzDeg.UseMnemonic = True
		Me.lblAzDeg.Visible = True
		Me.lblAzDeg.AutoSize = False
		Me.lblAzDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAzDeg.Name = "lblAzDeg"
		Me.lblAz1.BackColor = System.Drawing.SystemColors.Window
		Me.lblAz1.Text = "List/view visible bodies with azimuths from"
		Me.lblAz1.Size = New System.Drawing.Size(201, 17)
		Me.lblAz1.Location = New System.Drawing.Point(8, 16)
		Me.lblAz1.TabIndex = 36
		Me.ToolTip1.SetToolTip(Me.lblAz1, """Clockwise""")
		Me.lblAz1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAz1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAz1.Enabled = True
		Me.lblAz1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAz1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAz1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAz1.UseMnemonic = True
		Me.lblAz1.Visible = True
		Me.lblAz1.AutoSize = False
		Me.lblAz1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAz1.Name = "lblAz1"
		Me.txtTime.AutoSize = False
		Me.txtTime.Size = New System.Drawing.Size(33, 19)
		Me.txtTime.Location = New System.Drawing.Point(216, 176)
		Me.txtTime.Maxlength = 4
		Me.txtTime.TabIndex = 26
		Me.ToolTip1.SetToolTip(Me.txtTime, "Range 0000 to 2359")
		Me.txtTime.Visible = False
		Me.txtTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTime.AcceptsReturn = True
		Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTime.BackColor = System.Drawing.SystemColors.Window
		Me.txtTime.CausesValidation = True
		Me.txtTime.Enabled = True
		Me.txtTime.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTime.HideSelection = True
		Me.txtTime.ReadOnly = False
		Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTime.MultiLine = False
		Me.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTime.TabStop = True
		Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTime.Name = "txtTime"
		Me.txtZDh.AutoSize = False
		Me.txtZDh.Enabled = False
		Me.txtZDh.Size = New System.Drawing.Size(25, 19)
		Me.txtZDh.Location = New System.Drawing.Point(272, 48)
		Me.txtZDh.Maxlength = 3
		Me.txtZDh.TabIndex = 22
		Me.ToolTip1.SetToolTip(Me.txtZDh, "Range -13 to +12.  Lo E is -.")
		Me.txtZDh.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtZDh.AcceptsReturn = True
		Me.txtZDh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtZDh.BackColor = System.Drawing.SystemColors.Window
		Me.txtZDh.CausesValidation = True
		Me.txtZDh.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtZDh.HideSelection = True
		Me.txtZDh.ReadOnly = False
		Me.txtZDh.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtZDh.MultiLine = False
		Me.txtZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtZDh.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtZDh.TabStop = True
		Me.txtZDh.Visible = True
		Me.txtZDh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtZDh.Name = "txtZDh"
		Me.FrameZD.BackColor = System.Drawing.SystemColors.Window
		Me.FrameZD.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrameZD.Text = "Frame1"
		Me.FrameZD.Size = New System.Drawing.Size(177, 25)
		Me.FrameZD.Location = New System.Drawing.Point(272, 20)
		Me.FrameZD.TabIndex = 30
		Me.FrameZD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameZD.Enabled = True
		Me.FrameZD.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameZD.Cursor = System.Windows.Forms.Cursors.Default
		Me.FrameZD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameZD.Visible = True
		Me.FrameZD.Name = "FrameZD"
		Me.optZDUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDUT.BackColor = System.Drawing.SystemColors.Window
		Me.optZDUT.Text = "UT (GMT)"
		Me.optZDUT.Size = New System.Drawing.Size(87, 17)
		Me.optZDUT.Location = New System.Drawing.Point(112, 8)
		Me.optZDUT.TabIndex = 87
		Me.optZDUT.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optZDUT.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDUT.CausesValidation = True
		Me.optZDUT.Enabled = True
		Me.optZDUT.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optZDUT.Cursor = System.Windows.Forms.Cursors.Default
		Me.optZDUT.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optZDUT.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optZDUT.TabStop = True
		Me.optZDUT.Checked = False
		Me.optZDUT.Visible = True
		Me.optZDUT.Name = "optZDUT"
		Me.optZDAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDAuto.BackColor = System.Drawing.SystemColors.Window
		Me.optZDAuto.Text = "Auto"
		Me.optZDAuto.Size = New System.Drawing.Size(49, 13)
		Me.optZDAuto.Location = New System.Drawing.Point(0, 8)
		Me.optZDAuto.TabIndex = 19
		Me.ToolTip1.SetToolTip(Me.optZDAuto, "ZD based on longitude alone")
		Me.optZDAuto.Checked = True
		Me.optZDAuto.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optZDAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDAuto.CausesValidation = True
		Me.optZDAuto.Enabled = True
		Me.optZDAuto.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optZDAuto.Cursor = System.Windows.Forms.Cursors.Default
		Me.optZDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optZDAuto.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optZDAuto.TabStop = True
		Me.optZDAuto.Visible = True
		Me.optZDAuto.Name = "optZDAuto"
		Me.optZDManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDManual.BackColor = System.Drawing.SystemColors.Window
		Me.optZDManual.Text = "Manual"
		Me.optZDManual.Size = New System.Drawing.Size(57, 13)
		Me.optZDManual.Location = New System.Drawing.Point(50, 8)
		Me.optZDManual.TabIndex = 20
		Me.ToolTip1.SetToolTip(Me.optZDManual, "ZD can be set for civil standard time zone")
		Me.optZDManual.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optZDManual.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDManual.CausesValidation = True
		Me.optZDManual.Enabled = True
		Me.optZDManual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optZDManual.Cursor = System.Windows.Forms.Cursors.Default
		Me.optZDManual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optZDManual.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optZDManual.TabStop = True
		Me.optZDManual.Checked = False
		Me.optZDManual.Visible = True
		Me.optZDManual.Name = "optZDManual"
		Me.cboZDm.Size = New System.Drawing.Size(41, 21)
		Me.cboZDm.Location = New System.Drawing.Point(312, 48)
		Me.cboZDm.Items.AddRange(New Object(){"00", "30", "45"})
		Me.cboZDm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboZDm.TabIndex = 23
		Me.cboZDm.Visible = False
		Me.cboZDm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboZDm.BackColor = System.Drawing.SystemColors.Window
		Me.cboZDm.CausesValidation = True
		Me.cboZDm.Enabled = True
		Me.cboZDm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboZDm.IntegralHeight = True
		Me.cboZDm.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboZDm.Sorted = False
		Me.cboZDm.TabStop = True
		Me.cboZDm.Name = "cboZDm"
		Me.cmdTwilights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdTwilights.Text = " Get &Twilight Times/  Moon Data"
		Me.cmdTwilights.Size = New System.Drawing.Size(105, 33)
		Me.cmdTwilights.Location = New System.Drawing.Point(464, 37)
		Me.cmdTwilights.TabIndex = 24
		Me.cmdTwilights.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdTwilights.BackColor = System.Drawing.SystemColors.Control
		Me.cmdTwilights.CausesValidation = True
		Me.cmdTwilights.Enabled = True
		Me.cmdTwilights.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdTwilights.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdTwilights.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdTwilights.TabStop = True
		Me.cmdTwilights.Name = "cmdTwilights"
		Me.cboLo.Size = New System.Drawing.Size(41, 21)
		Me.cboLo.Location = New System.Drawing.Point(144, 52)
		Me.cboLo.Items.AddRange(New Object(){"W ", "E "})
		Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLo.TabIndex = 16
		Me.cboLo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboLo.BackColor = System.Drawing.SystemColors.Window
		Me.cboLo.CausesValidation = True
		Me.cboLo.Enabled = True
		Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLo.IntegralHeight = True
		Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLo.Sorted = False
		Me.cboLo.TabStop = True
		Me.cboLo.Visible = True
		Me.cboLo.Name = "cboLo"
		Me.txtLoMin.AutoSize = False
		Me.txtLoMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLoMin.Location = New System.Drawing.Point(96, 52)
		Me.txtLoMin.Maxlength = 4
		Me.txtLoMin.TabIndex = 15
		Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
		Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLoMin.AcceptsReturn = True
		Me.txtLoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtLoMin.CausesValidation = True
		Me.txtLoMin.Enabled = True
		Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLoMin.HideSelection = True
		Me.txtLoMin.ReadOnly = False
		Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLoMin.MultiLine = False
		Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLoMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLoMin.TabStop = True
		Me.txtLoMin.Visible = True
		Me.txtLoMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLoMin.Name = "txtLoMin"
		Me.txtLoDeg.AutoSize = False
		Me.txtLoDeg.Size = New System.Drawing.Size(33, 19)
		Me.txtLoDeg.Location = New System.Drawing.Point(56, 52)
		Me.txtLoDeg.Maxlength = 3
		Me.txtLoDeg.TabIndex = 13
		Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
		Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLoDeg.AcceptsReturn = True
		Me.txtLoDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLoDeg.CausesValidation = True
		Me.txtLoDeg.Enabled = True
		Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLoDeg.HideSelection = True
		Me.txtLoDeg.ReadOnly = False
		Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLoDeg.MultiLine = False
		Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLoDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLoDeg.TabStop = True
		Me.txtLoDeg.Visible = True
		Me.txtLoDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLoDeg.Name = "txtLoDeg"
		Me.cboL.Size = New System.Drawing.Size(41, 21)
		Me.cboL.Location = New System.Drawing.Point(144, 28)
		Me.cboL.Items.AddRange(New Object(){"N ", "S "})
		Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboL.TabIndex = 11
		Me.cboL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboL.BackColor = System.Drawing.SystemColors.Window
		Me.cboL.CausesValidation = True
		Me.cboL.Enabled = True
		Me.cboL.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboL.IntegralHeight = True
		Me.cboL.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboL.Sorted = False
		Me.cboL.TabStop = True
		Me.cboL.Visible = True
		Me.cboL.Name = "cboL"
		Me.txtLMin.AutoSize = False
		Me.txtLMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLMin.Location = New System.Drawing.Point(96, 28)
		Me.txtLMin.Maxlength = 4
		Me.txtLMin.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.txtLMin, "Range 0 to 59.9")
		Me.txtLMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLMin.AcceptsReturn = True
		Me.txtLMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtLMin.CausesValidation = True
		Me.txtLMin.Enabled = True
		Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLMin.HideSelection = True
		Me.txtLMin.ReadOnly = False
		Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLMin.MultiLine = False
		Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLMin.TabStop = True
		Me.txtLMin.Visible = True
		Me.txtLMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLMin.Name = "txtLMin"
		Me.txtLDeg.AutoSize = False
		Me.txtLDeg.ForeColor = System.Drawing.Color.FromARGB(91, 0, 0)
		Me.txtLDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtLDeg.Location = New System.Drawing.Point(64, 28)
		Me.txtLDeg.Maxlength = 2
		Me.txtLDeg.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.txtLDeg, "Range 0 to 90")
		Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLDeg.AcceptsReturn = True
		Me.txtLDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLDeg.CausesValidation = True
		Me.txtLDeg.Enabled = True
		Me.txtLDeg.HideSelection = True
		Me.txtLDeg.ReadOnly = False
		Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLDeg.MultiLine = False
		Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLDeg.TabStop = True
		Me.txtLDeg.Visible = True
		Me.txtLDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLDeg.Name = "txtLDeg"
		Me.txtYear.AutoSize = False
		Me.txtYear.Size = New System.Drawing.Size(33, 19)
		Me.txtYear.Location = New System.Drawing.Point(200, 4)
		Me.txtYear.Maxlength = 4
		Me.txtYear.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.txtYear, "Range 1901 to 2099")
		Me.txtYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtYear.AcceptsReturn = True
		Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtYear.BackColor = System.Drawing.SystemColors.Window
		Me.txtYear.CausesValidation = True
		Me.txtYear.Enabled = True
		Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtYear.HideSelection = True
		Me.txtYear.ReadOnly = False
		Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtYear.MultiLine = False
		Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtYear.TabStop = True
		Me.txtYear.Visible = True
		Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtYear.Name = "txtYear"
		Me.cboMonth.Size = New System.Drawing.Size(49, 21)
		Me.cboMonth.Location = New System.Drawing.Point(128, 4)
		Me.cboMonth.Items.AddRange(New Object(){"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
		Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboMonth.TabIndex = 4
		Me.cboMonth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMonth.BackColor = System.Drawing.SystemColors.Window
		Me.cboMonth.CausesValidation = True
		Me.cboMonth.Enabled = True
		Me.cboMonth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMonth.IntegralHeight = True
		Me.cboMonth.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMonth.Sorted = False
		Me.cboMonth.TabStop = True
		Me.cboMonth.Visible = True
		Me.cboMonth.Name = "cboMonth"
		Me.lblBody.BackColor = System.Drawing.SystemColors.Window
		Me.lblBody.Text = "Name"
		Me.lblBody.Size = New System.Drawing.Size(27, 17)
		Me.lblBody.Location = New System.Drawing.Point(560, 384)
		Me.lblBody.TabIndex = 83
		Me.lblBody.Visible = False
		Me.lblBody.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBody.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBody.Enabled = True
		Me.lblBody.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBody.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBody.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBody.UseMnemonic = True
		Me.lblBody.AutoSize = False
		Me.lblBody.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBody.Name = "lblBody"
		Me.lblBodyName.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblBodyName.BackColor = System.Drawing.SystemColors.Window
		Me.lblBodyName.Size = New System.Drawing.Size(81, 17)
		Me.lblBodyName.Location = New System.Drawing.Point(592, 384)
		Me.lblBodyName.TabIndex = 82
		Me.lblBodyName.Visible = False
		Me.lblBodyName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBodyName.Enabled = True
		Me.lblBodyName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBodyName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBodyName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBodyName.UseMnemonic = True
		Me.lblBodyName.AutoSize = False
		Me.lblBodyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblBodyName.Name = "lblBodyName"
		Me.Line5.X1 = 0
		Me.Line5.X2 = 700
		Me.Line5.Y1 = 157
		Me.Line5.Y2 = 157
		Me.Line5.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line5.BorderWidth = 1
		Me.Line5.Visible = True
		Me.Line5.Name = "Line5"
		Me.lblAltDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblAltDeg.Text = "°"
		Me.lblAltDeg.Size = New System.Drawing.Size(17, 17)
		Me.lblAltDeg.Location = New System.Drawing.Point(681, 176)
		Me.lblAltDeg.TabIndex = 72
		Me.lblAltDeg.Visible = False
		Me.lblAltDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAltDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAltDeg.Enabled = True
		Me.lblAltDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAltDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAltDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAltDeg.UseMnemonic = True
		Me.lblAltDeg.AutoSize = False
		Me.lblAltDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAltDeg.Name = "lblAltDeg"
		Me.lblMinimumAltitude.BackColor = System.Drawing.SystemColors.Window
		Me.lblMinimumAltitude.Text = "Enter minimum altitude for Sun-Moon Fix"
		Me.lblMinimumAltitude.Size = New System.Drawing.Size(193, 17)
		Me.lblMinimumAltitude.Location = New System.Drawing.Point(456, 179)
		Me.lblMinimumAltitude.TabIndex = 71
		Me.lblMinimumAltitude.Visible = False
		Me.lblMinimumAltitude.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMinimumAltitude.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMinimumAltitude.Enabled = True
		Me.lblMinimumAltitude.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMinimumAltitude.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMinimumAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMinimumAltitude.UseMnemonic = True
		Me.lblMinimumAltitude.AutoSize = False
		Me.lblMinimumAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMinimumAltitude.Name = "lblMinimumAltitude"
		Me.Shape1.BorderWidth = 2
		Me.Shape1.Size = New System.Drawing.Size(200, 47)
		Me.Shape1.Location = New System.Drawing.Point(483, 512)
		Me.Shape1.Visible = False
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Name = "Shape1"
		Me.lblZDDST.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDDST.Text = "DST"
		Me.lblZDDST.Size = New System.Drawing.Size(25, 17)
		Me.lblZDDST.Location = New System.Drawing.Point(425, 48)
		Me.lblZDDST.TabIndex = 70
		Me.lblZDDST.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblZDDST.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblZDDST.Enabled = True
		Me.lblZDDST.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblZDDST.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblZDDST.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblZDDST.UseMnemonic = True
		Me.lblZDDST.Visible = True
		Me.lblZDDST.AutoSize = False
		Me.lblZDDST.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblZDDST.Name = "lblZDDST"
		Me.lblAlt.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblAlt.BackColor = System.Drawing.SystemColors.Window
		Me.lblAlt.Size = New System.Drawing.Size(25, 17)
		Me.lblAlt.Location = New System.Drawing.Point(648, 432)
		Me.lblAlt.TabIndex = 67
		Me.lblAlt.Visible = False
		Me.lblAlt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAlt.Enabled = True
		Me.lblAlt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAlt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAlt.UseMnemonic = True
		Me.lblAlt.AutoSize = False
		Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAlt.Name = "lblAlt"
		Me.lblAz.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblAz.BackColor = System.Drawing.SystemColors.Window
		Me.lblAz.Size = New System.Drawing.Size(25, 17)
		Me.lblAz.Location = New System.Drawing.Point(648, 408)
		Me.lblAz.TabIndex = 66
		Me.lblAz.Visible = False
		Me.lblAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAz.Enabled = True
		Me.lblAz.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAz.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAz.UseMnemonic = True
		Me.lblAz.AutoSize = False
		Me.lblAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAz.Name = "lblAz"
		Me.lblAzimuth.BackColor = System.Drawing.SystemColors.Window
		Me.lblAzimuth.Text = "Azimuth"
		Me.lblAzimuth.Size = New System.Drawing.Size(41, 17)
		Me.lblAzimuth.Location = New System.Drawing.Point(608, 408)
		Me.lblAzimuth.TabIndex = 51
		Me.lblAzimuth.Visible = False
		Me.lblAzimuth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAzimuth.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAzimuth.Enabled = True
		Me.lblAzimuth.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAzimuth.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAzimuth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAzimuth.UseMnemonic = True
		Me.lblAzimuth.AutoSize = False
		Me.lblAzimuth.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAzimuth.Name = "lblAzimuth"
		Me.lblAltitude.BackColor = System.Drawing.SystemColors.Window
		Me.lblAltitude.Text = "Altitude"
		Me.lblAltitude.Size = New System.Drawing.Size(41, 17)
		Me.lblAltitude.Location = New System.Drawing.Point(608, 432)
		Me.lblAltitude.TabIndex = 50
		Me.lblAltitude.Visible = False
		Me.lblAltitude.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAltitude.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAltitude.Enabled = True
		Me.lblAltitude.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAltitude.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAltitude.UseMnemonic = True
		Me.lblAltitude.AutoSize = False
		Me.lblAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAltitude.Name = "lblAltitude"
		Me.Label7.BackColor = System.Drawing.SystemColors.Window
		Me.Label7.Text = "°"
		Me.Label7.Size = New System.Drawing.Size(9, 17)
		Me.Label7.Location = New System.Drawing.Point(673, 408)
		Me.Label7.TabIndex = 49
		Me.Label7.Visible = False
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "°"
		Me.Label5.Size = New System.Drawing.Size(9, 25)
		Me.Label5.Location = New System.Drawing.Point(673, 432)
		Me.Label5.TabIndex = 48
		Me.Label5.Visible = False
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.lblW.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblW.BackColor = System.Drawing.Color.Transparent
		Me.lblW.Text = "W"
		Me.lblW.Size = New System.Drawing.Size(12, 17)
		Me.lblW.Location = New System.Drawing.Point(512, 392)
		Me.lblW.TabIndex = 47
		Me.lblW.Visible = False
		Me.lblW.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblW.Enabled = True
		Me.lblW.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblW.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblW.UseMnemonic = True
		Me.lblW.AutoSize = False
		Me.lblW.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblW.Name = "lblW"
		Me.lblE.BackColor = System.Drawing.Color.Transparent
		Me.lblE.Text = "E"
		Me.lblE.Size = New System.Drawing.Size(9, 17)
		Me.lblE.Location = New System.Drawing.Point(176, 392)
		Me.lblE.TabIndex = 46
		Me.lblE.Visible = False
		Me.lblE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblE.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblE.Enabled = True
		Me.lblE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblE.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblE.UseMnemonic = True
		Me.lblE.AutoSize = False
		Me.lblE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblE.Name = "lblE"
		Me.lblS.BackColor = System.Drawing.Color.Transparent
		Me.lblS.Text = "S"
		Me.lblS.Size = New System.Drawing.Size(9, 12)
		Me.lblS.Location = New System.Drawing.Point(346, 557)
		Me.lblS.TabIndex = 45
		Me.lblS.Visible = False
		Me.lblS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblS.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblS.Enabled = True
		Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblS.UseMnemonic = True
		Me.lblS.AutoSize = False
		Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblS.Name = "lblS"
		Me.lblN.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblN.BackColor = System.Drawing.Color.Transparent
		Me.lblN.Text = "N"
		Me.lblN.Size = New System.Drawing.Size(9, 17)
		Me.lblN.Location = New System.Drawing.Point(346, 227)
		Me.lblN.TabIndex = 44
		Me.lblN.Visible = False
		Me.lblN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblN.Enabled = True
		Me.lblN.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblN.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblN.UseMnemonic = True
		Me.lblN.AutoSize = False
		Me.lblN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblN.Name = "lblN"
		Me.Line4.BorderWidth = 2
		Me.Line4.X1 = 0
		Me.Line4.X2 = 700
		Me.Line4.Y1 = 174
		Me.Line4.Y2 = 174
		Me.Line4.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line4.Visible = True
		Me.Line4.Name = "Line4"
		Me.Line3.X1 = 456
		Me.Line3.X2 = 456
		Me.Line3.Y1 = 0
		Me.Line3.Y2 = 74
		Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line3.BorderWidth = 1
		Me.Line3.Visible = True
		Me.Line3.Name = "Line3"
		Me.Line2.X1 = 240
		Me.Line2.X2 = 240
		Me.Line2.Y1 = 0
		Me.Line2.Y2 = 74
		Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line2.BorderWidth = 1
		Me.Line2.Visible = True
		Me.Line2.Name = "Line2"
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 0
		Me.Line1.X2 = 700
		Me.Line1.Y1 = 74
		Me.Line1.Y2 = 74
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.lblEnterTime.BackColor = System.Drawing.SystemColors.Window
		Me.lblEnterTime.Text = "Enter desired ZT for body visibility (hhmm)"
		Me.lblEnterTime.Size = New System.Drawing.Size(217, 17)
		Me.lblEnterTime.Location = New System.Drawing.Point(8, 179)
		Me.lblEnterTime.TabIndex = 25
		Me.lblEnterTime.Visible = False
		Me.lblEnterTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEnterTime.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEnterTime.Enabled = True
		Me.lblEnterTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblEnterTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEnterTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEnterTime.UseMnemonic = True
		Me.lblEnterTime.AutoSize = False
		Me.lblEnterTime.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEnterTime.Name = "lblEnterTime"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Select ZD of timepiece:"
		Me.Label1.Size = New System.Drawing.Size(129, 17)
		Me.Label1.Location = New System.Drawing.Point(288, 4)
		Me.Label1.TabIndex = 17
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.WEZDAutoManual.BackColor = System.Drawing.SystemColors.Window
		Me.WEZDAutoManual.Text = "ZD"
		Me.WEZDAutoManual.Size = New System.Drawing.Size(17, 17)
		Me.WEZDAutoManual.Location = New System.Drawing.Point(248, 27)
		Me.WEZDAutoManual.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.WEZDAutoManual, "Zone Description ")
		Me.WEZDAutoManual.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.WEZDAutoManual.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.WEZDAutoManual.Enabled = True
		Me.WEZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.WEZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default
		Me.WEZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.WEZDAutoManual.UseMnemonic = True
		Me.WEZDAutoManual.Visible = True
		Me.WEZDAutoManual.AutoSize = False
		Me.WEZDAutoManual.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.WEZDAutoManual.Name = "WEZDAutoManual"
		Me.lblWEZD.BackColor = System.Drawing.SystemColors.Window
		Me.lblWEZD.Text = "ZD"
		Me.lblWEZD.Size = New System.Drawing.Size(17, 17)
		Me.lblWEZD.Location = New System.Drawing.Point(248, 48)
		Me.lblWEZD.TabIndex = 21
		Me.ToolTip1.SetToolTip(Me.lblWEZD, "Zone Description")
		Me.lblWEZD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWEZD.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWEZD.Enabled = True
		Me.lblWEZD.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWEZD.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWEZD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWEZD.UseMnemonic = True
		Me.lblWEZD.Visible = True
		Me.lblWEZD.AutoSize = False
		Me.lblWEZD.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWEZD.Name = "lblWEZD"
		Me.lblZDh.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDh.Text = "h"
		Me.lblZDh.Size = New System.Drawing.Size(9, 17)
		Me.lblZDh.Location = New System.Drawing.Point(297, 48)
		Me.lblZDh.TabIndex = 32
		Me.lblZDh.Visible = False
		Me.lblZDh.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblZDh.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblZDh.Enabled = True
		Me.lblZDh.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblZDh.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblZDh.UseMnemonic = True
		Me.lblZDh.AutoSize = False
		Me.lblZDh.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblZDh.Name = "lblZDh"
		Me.lblZDm.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDm.Text = "m"
		Me.lblZDm.Size = New System.Drawing.Size(9, 17)
		Me.lblZDm.Location = New System.Drawing.Point(353, 48)
		Me.lblZDm.TabIndex = 31
		Me.lblZDm.Visible = False
		Me.lblZDm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblZDm.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblZDm.Enabled = True
		Me.lblZDm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblZDm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblZDm.UseMnemonic = True
		Me.lblZDm.AutoSize = False
		Me.lblZDm.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblZDm.Name = "lblZDm"
		Me.Label10.BackColor = System.Drawing.SystemColors.Window
		Me.Label10.Text = "'"
		Me.Label10.Size = New System.Drawing.Size(9, 25)
		Me.Label10.Location = New System.Drawing.Point(129, 52)
		Me.Label10.TabIndex = 29
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.BackColor = System.Drawing.SystemColors.Window
		Me.Label9.Text = "'"
		Me.Label9.Size = New System.Drawing.Size(9, 25)
		Me.Label9.Location = New System.Drawing.Point(129, 28)
		Me.Label9.TabIndex = 28
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label8.BackColor = System.Drawing.SystemColors.Window
		Me.Label8.Text = "°"
		Me.Label8.Size = New System.Drawing.Size(9, 17)
		Me.Label8.Location = New System.Drawing.Point(89, 52)
		Me.Label8.TabIndex = 14
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRLo.Text = "DR Lo"
		Me.lblDRLo.Size = New System.Drawing.Size(33, 17)
		Me.lblDRLo.Location = New System.Drawing.Point(8, 52)
		Me.lblDRLo.TabIndex = 12
		Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDRLo.Enabled = True
		Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDRLo.UseMnemonic = True
		Me.lblDRLo.Visible = True
		Me.lblDRLo.AutoSize = False
		Me.lblDRLo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDRLo.Name = "lblDRLo"
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "°"
		Me.Label6.Size = New System.Drawing.Size(9, 17)
		Me.Label6.Location = New System.Drawing.Point(89, 28)
		Me.Label6.TabIndex = 9
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRL.Text = "DR L"
		Me.lblDRL.Size = New System.Drawing.Size(33, 17)
		Me.lblDRL.Location = New System.Drawing.Point(8, 28)
		Me.lblDRL.TabIndex = 7
		Me.lblDRL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDRL.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDRL.Enabled = True
		Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDRL.UseMnemonic = True
		Me.lblDRL.Visible = True
		Me.lblDRL.AutoSize = False
		Me.lblDRL.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDRL.Name = "lblDRL"
		Me.lblYear.BackColor = System.Drawing.SystemColors.Window
		Me.lblYear.Text = "Yr."
		Me.lblYear.Size = New System.Drawing.Size(17, 17)
		Me.lblYear.Location = New System.Drawing.Point(184, 4)
		Me.lblYear.TabIndex = 5
		Me.lblYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblYear.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblYear.Enabled = True
		Me.lblYear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblYear.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblYear.UseMnemonic = True
		Me.lblYear.Visible = True
		Me.lblYear.AutoSize = False
		Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblYear.Name = "lblYear"
		Me.lblMonth.BackColor = System.Drawing.SystemColors.Window
		Me.lblMonth.Text = "Mo."
		Me.lblMonth.Size = New System.Drawing.Size(17, 17)
		Me.lblMonth.Location = New System.Drawing.Point(110, 4)
		Me.lblMonth.TabIndex = 3
		Me.lblMonth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMonth.Enabled = True
		Me.lblMonth.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMonth.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMonth.UseMnemonic = True
		Me.lblMonth.Visible = True
		Me.lblMonth.AutoSize = False
		Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMonth.Name = "lblMonth"
		Me.lblDay.BackColor = System.Drawing.SystemColors.Window
		Me.lblDay.Text = "Day"
		Me.lblDay.Size = New System.Drawing.Size(25, 17)
		Me.lblDay.Location = New System.Drawing.Point(40, 4)
		Me.lblDay.TabIndex = 1
		Me.lblDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDay.Enabled = True
		Me.lblDay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDay.UseMnemonic = True
		Me.lblDay.Visible = True
		Me.lblDay.AutoSize = False
		Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDay.Name = "lblDay"
		Me.lblDate.BackColor = System.Drawing.SystemColors.Window
		Me.lblDate.Text = "Date"
		Me.lblDate.Size = New System.Drawing.Size(25, 17)
		Me.lblDate.Location = New System.Drawing.Point(8, 4)
		Me.lblDate.TabIndex = 0
		Me.lblDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDate.Enabled = True
		Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDate.UseMnemonic = True
		Me.lblDate.Visible = True
		Me.lblDate.AutoSize = False
		Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDate.Name = "lblDate"
		Me.Controls.Add(chkMoon)
		Me.Controls.Add(FrameZn)
		Me.Controls.Add(frmWarning)
		Me.Controls.Add(FrameBest)
		Me.Controls.Add(txtMinimumAltitude)
		Me.Controls.Add(chkDST)
		Me.Controls.Add(chkHelper)
		Me.Controls.Add(FrameDirection)
		Me.Controls.Add(chkLimit)
		Me.Controls.Add(FrameView)
		Me.Controls.Add(chkFirst)
		Me.Controls.Add(chkSecond)
		Me.Controls.Add(chkThird)
		Me.Controls.Add(chkNames)
		Me.Controls.Add(cboDay)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(FrameDisplay)
		Me.Controls.Add(txtTime)
		Me.Controls.Add(txtZDh)
		Me.Controls.Add(FrameZD)
		Me.Controls.Add(cboZDm)
		Me.Controls.Add(cmdTwilights)
		Me.Controls.Add(cboLo)
		Me.Controls.Add(txtLoMin)
		Me.Controls.Add(txtLoDeg)
		Me.Controls.Add(cboL)
		Me.Controls.Add(txtLMin)
		Me.Controls.Add(txtLDeg)
		Me.Controls.Add(txtYear)
		Me.Controls.Add(cboMonth)
		Me.Controls.Add(lblBody)
		Me.Controls.Add(lblBodyName)
		Me.ShapeContainer1.Shapes.Add(Line5)
		Me.Controls.Add(lblAltDeg)
		Me.Controls.Add(lblMinimumAltitude)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Controls.Add(lblZDDST)
		Me.Controls.Add(lblAlt)
		Me.Controls.Add(lblAz)
		Me.Controls.Add(lblAzimuth)
		Me.Controls.Add(lblAltitude)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label5)
		Me.Controls.Add(lblW)
		Me.Controls.Add(lblE)
		Me.Controls.Add(lblS)
		Me.Controls.Add(lblN)
		Me.ShapeContainer1.Shapes.Add(Line4)
		Me.ShapeContainer1.Shapes.Add(Line3)
		Me.ShapeContainer1.Shapes.Add(Line2)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(lblEnterTime)
		Me.Controls.Add(Label1)
		Me.Controls.Add(WEZDAutoManual)
		Me.Controls.Add(lblWEZD)
		Me.Controls.Add(lblZDh)
		Me.Controls.Add(lblZDm)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(lblDRLo)
		Me.Controls.Add(Label6)
		Me.Controls.Add(lblDRL)
		Me.Controls.Add(lblYear)
		Me.Controls.Add(lblMonth)
		Me.Controls.Add(lblDay)
		Me.Controls.Add(lblDate)
		Me.Controls.Add(ShapeContainer1)
		Me.FrameZn.Controls.Add(optCenter)
		Me.FrameZn.Controls.Add(optLimb)
		Me.frmWarning.Controls.Add(txtWarning)
		Me.FrameBest.Controls.Add(optThreeBeach)
		Me.FrameBest.Controls.Add(cmdCW)
		Me.FrameBest.Controls.Add(cmdCCW)
		Me.FrameBest.Controls.Add(optThreeBoat)
		Me.FrameBest.Controls.Add(optTwo)
		Me.FrameBest.Controls.Add(optOff)
		Me.FrameDirection.Controls.Add(optW)
		Me.FrameDirection.Controls.Add(optE)
		Me.FrameDirection.Controls.Add(optS)
		Me.FrameDirection.Controls.Add(optN)
		Me.FrameView.Controls.Add(optHorizon)
		Me.FrameView.Controls.Add(optStarFinder)
		Me.FrameView.Controls.Add(optOverhead)
		Me.FrameDisplay.Controls.Add(CmdView)
		Me.FrameDisplay.Controls.Add(cmdData)
		Me.FrameDisplay.Controls.Add(CmdVisible)
		Me.FrameDisplay.Controls.Add(txtHighAz)
		Me.FrameDisplay.Controls.Add(txtLowAz)
		Me.ShapeContainer2.Shapes.Add(Line6)
		Me.FrameDisplay.Controls.Add(Label3)
		Me.FrameDisplay.Controls.Add(Label2)
		Me.FrameDisplay.Controls.Add(lblAzDeg)
		Me.FrameDisplay.Controls.Add(lblAz1)
		Me.FrameDisplay.Controls.Add(ShapeContainer2)
		Me.FrameZD.Controls.Add(optZDUT)
		Me.FrameZD.Controls.Add(optZDAuto)
		Me.FrameZD.Controls.Add(optZDManual)
		Me.FrameZn.ResumeLayout(False)
		Me.frmWarning.ResumeLayout(False)
		Me.FrameBest.ResumeLayout(False)
		Me.FrameDirection.ResumeLayout(False)
		Me.FrameView.ResumeLayout(False)
		Me.FrameDisplay.ResumeLayout(False)
		Me.FrameZD.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class