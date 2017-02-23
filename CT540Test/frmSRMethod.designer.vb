<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form8
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
	Public WithEvents chkInterpolateB As System.Windows.Forms.CheckBox
	Public WithEvents cmdWeems As System.Windows.Forms.Button
	Public WithEvents optFarley As System.Windows.Forms.RadioButton
	Public WithEvents optPepperday As System.Windows.Forms.RadioButton
	Public WithEvents frameS As System.Windows.Forms.GroupBox
	Public WithEvents cmdSTable As System.Windows.Forms.Button
	Public WithEvents chkSadler As System.Windows.Forms.CheckBox
	Public WithEvents optdtL As System.Windows.Forms.RadioButton
	Public WithEvents optdt As System.Windows.Forms.RadioButton
	Public WithEvents optd As System.Windows.Forms.RadioButton
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents frame214 As System.Windows.Forms.GroupBox
	Public WithEvents chkDSD As System.Windows.Forms.CheckBox
	Public WithEvents optCompact As System.Windows.Forms.RadioButton
	Public WithEvents optOriginal As System.Windows.Forms.RadioButton
	Public WithEvents frame211 As System.Windows.Forms.GroupBox
	Public WithEvents cmd208 As System.Windows.Forms.Button
	Public WithEvents cmd211 As System.Windows.Forms.Button
	Public WithEvents cmd214 As System.Windows.Forms.Button
	Public WithEvents cmd229 As System.Windows.Forms.Button
	Public WithEvents cmd249 As System.Windows.Forms.Button
	Public WithEvents cmdClearSome As System.Windows.Forms.Button
	Public WithEvents cmdMerDiag As System.Windows.Forms.Button
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents txtTime As System.Windows.Forms.TextBox
	Public WithEvents cmdFix As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents optNATable As System.Windows.Forms.RadioButton
	Public WithEvents optUSPSTable As System.Windows.Forms.RadioButton
	Public WithEvents frameNASRUsing As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdNASR As System.Windows.Forms.Button
	Public WithEvents cmdLawOfCosines As System.Windows.Forms.Button
	Public WithEvents cboDec As System.Windows.Forms.ComboBox
	Public WithEvents txtHoMin As System.Windows.Forms.TextBox
	Public WithEvents txtDecMin As System.Windows.Forms.TextBox
	Public WithEvents txtGHAMin As System.Windows.Forms.TextBox
	Public WithEvents txtHoDeg As System.Windows.Forms.TextBox
	Public WithEvents txtDecDeg As System.Windows.Forms.TextBox
	Public WithEvents txtGHADeg As System.Windows.Forms.TextBox
	Public WithEvents txtLMin As System.Windows.Forms.TextBox
	Public WithEvents cboL As System.Windows.Forms.ComboBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents txtLDeg As System.Windows.Forms.TextBox
	Public WithEvents Line23 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line22 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line21 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line20 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line19 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line18 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line17 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line16 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line15 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line14 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line13 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line12 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Line11 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Shape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents lblTime As System.Windows.Forms.Label
	Public WithEvents Shape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblHoMin As System.Windows.Forms.Label
	Public WithEvents lblDecMin As System.Windows.Forms.Label
	Public WithEvents lblGHAMin As System.Windows.Forms.Label
	Public WithEvents lblHoDeg As System.Windows.Forms.Label
	Public WithEvents lblDecDeg As System.Windows.Forms.Label
	Public WithEvents lblGHADeg As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblDRL As System.Windows.Forms.Label
	Public WithEvents lblLDeg As System.Windows.Forms.Label
	Public WithEvents lblLMin As System.Windows.Forms.Label
	Public WithEvents lblDRLo As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form8))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.chkInterpolateB = New System.Windows.Forms.CheckBox
		Me.cmdWeems = New System.Windows.Forms.Button
		Me.frameS = New System.Windows.Forms.GroupBox
		Me.optFarley = New System.Windows.Forms.RadioButton
		Me.optPepperday = New System.Windows.Forms.RadioButton
		Me.cmdSTable = New System.Windows.Forms.Button
		Me.chkSadler = New System.Windows.Forms.CheckBox
		Me.frame214 = New System.Windows.Forms.GroupBox
		Me.optdtL = New System.Windows.Forms.RadioButton
		Me.optdt = New System.Windows.Forms.RadioButton
		Me.optd = New System.Windows.Forms.RadioButton
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.chkDSD = New System.Windows.Forms.CheckBox
		Me.frame211 = New System.Windows.Forms.GroupBox
		Me.optCompact = New System.Windows.Forms.RadioButton
		Me.optOriginal = New System.Windows.Forms.RadioButton
		Me.cmd208 = New System.Windows.Forms.Button
		Me.cmd211 = New System.Windows.Forms.Button
		Me.cmd214 = New System.Windows.Forms.Button
		Me.cmd229 = New System.Windows.Forms.Button
		Me.cmd249 = New System.Windows.Forms.Button
		Me.cmdClearSome = New System.Windows.Forms.Button
		Me.cmdMerDiag = New System.Windows.Forms.Button
		Me.cmdClear = New System.Windows.Forms.Button
		Me.txtTime = New System.Windows.Forms.TextBox
		Me.cmdFix = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.frameNASRUsing = New System.Windows.Forms.GroupBox
		Me.optNATable = New System.Windows.Forms.RadioButton
		Me.optUSPSTable = New System.Windows.Forms.RadioButton
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdNASR = New System.Windows.Forms.Button
		Me.cmdLawOfCosines = New System.Windows.Forms.Button
		Me.cboDec = New System.Windows.Forms.ComboBox
		Me.txtHoMin = New System.Windows.Forms.TextBox
		Me.txtDecMin = New System.Windows.Forms.TextBox
		Me.txtGHAMin = New System.Windows.Forms.TextBox
		Me.txtHoDeg = New System.Windows.Forms.TextBox
		Me.txtDecDeg = New System.Windows.Forms.TextBox
		Me.txtGHADeg = New System.Windows.Forms.TextBox
		Me.txtLMin = New System.Windows.Forms.TextBox
		Me.cboL = New System.Windows.Forms.ComboBox
		Me.txtLoDeg = New System.Windows.Forms.TextBox
		Me.txtLoMin = New System.Windows.Forms.TextBox
		Me.cboLo = New System.Windows.Forms.ComboBox
		Me.txtLDeg = New System.Windows.Forms.TextBox
		Me.Line23 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line22 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line21 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line20 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line19 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line18 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line17 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line16 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line15 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line14 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line13 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line12 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label6 = New System.Windows.Forms.Label
		Me.Line11 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line10 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line9 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line8 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.lblTime = New System.Windows.Forms.Label
		Me.Shape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblHoMin = New System.Windows.Forms.Label
		Me.lblDecMin = New System.Windows.Forms.Label
		Me.lblGHAMin = New System.Windows.Forms.Label
		Me.lblHoDeg = New System.Windows.Forms.Label
		Me.lblDecDeg = New System.Windows.Forms.Label
		Me.lblGHADeg = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblDRL = New System.Windows.Forms.Label
		Me.lblLDeg = New System.Windows.Forms.Label
		Me.lblLMin = New System.Windows.Forms.Label
		Me.lblDRLo = New System.Windows.Forms.Label
		Me.lblLoDeg = New System.Windows.Forms.Label
		Me.lblLoMin = New System.Windows.Forms.Label
		Me.frameS.SuspendLayout()
		Me.frame214.SuspendLayout()
		Me.frame211.SuspendLayout()
		Me.frameNASRUsing.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Sight Reduction Methods"
		Me.ClientSize = New System.Drawing.Size(672, 363)
		Me.Location = New System.Drawing.Point(61, 187)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("Form8.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
		Me.Name = "Form8"
		Me.chkInterpolateB.BackColor = System.Drawing.SystemColors.Window
		Me.chkInterpolateB.Text = "Interpolate Table B (for Hc calc.)"
		Me.chkInterpolateB.Size = New System.Drawing.Size(113, 22)
		Me.chkInterpolateB.Location = New System.Drawing.Point(8, 147)
		Me.chkInterpolateB.TabIndex = 66
		Me.chkInterpolateB.Visible = False
		Me.chkInterpolateB.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkInterpolateB.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkInterpolateB.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkInterpolateB.CausesValidation = True
		Me.chkInterpolateB.Enabled = True
		Me.chkInterpolateB.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkInterpolateB.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkInterpolateB.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkInterpolateB.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkInterpolateB.TabStop = True
		Me.chkInterpolateB.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkInterpolateB.Name = "chkInterpolateB"
		Me.cmdWeems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdWeems.Text = "&Weems LPB"
		Me.cmdWeems.Size = New System.Drawing.Size(65, 22)
		Me.cmdWeems.Location = New System.Drawing.Point(536, 120)
		Me.cmdWeems.TabIndex = 42
		Me.cmdWeems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdWeems.BackColor = System.Drawing.SystemColors.Control
		Me.cmdWeems.CausesValidation = True
		Me.cmdWeems.Enabled = True
		Me.cmdWeems.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdWeems.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdWeems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdWeems.TabStop = True
		Me.cmdWeems.Name = "cmdWeems"
		Me.frameS.BackColor = System.Drawing.SystemColors.Window
		Me.frameS.Text = "Version"
		Me.frameS.Size = New System.Drawing.Size(140, 32)
		Me.frameS.Location = New System.Drawing.Point(526, 145)
		Me.frameS.TabIndex = 63
		Me.frameS.Visible = False
		Me.frameS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frameS.Enabled = True
		Me.frameS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frameS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frameS.Padding = New System.Windows.Forms.Padding(0)
		Me.frameS.Name = "frameS"
		Me.optFarley.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optFarley.BackColor = System.Drawing.SystemColors.Window
		Me.optFarley.Text = "Farley"
		Me.optFarley.Size = New System.Drawing.Size(50, 17)
		Me.optFarley.Location = New System.Drawing.Point(88, 14)
		Me.optFarley.TabIndex = 65
		Me.optFarley.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optFarley.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optFarley.CausesValidation = True
		Me.optFarley.Enabled = True
		Me.optFarley.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optFarley.Cursor = System.Windows.Forms.Cursors.Default
		Me.optFarley.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optFarley.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optFarley.TabStop = True
		Me.optFarley.Checked = False
		Me.optFarley.Visible = True
		Me.optFarley.Name = "optFarley"
		Me.optPepperday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optPepperday.BackColor = System.Drawing.SystemColors.Window
		Me.optPepperday.Text = "Pepperday"
		Me.optPepperday.Size = New System.Drawing.Size(73, 17)
		Me.optPepperday.Location = New System.Drawing.Point(8, 14)
		Me.optPepperday.TabIndex = 64
		Me.optPepperday.Checked = True
		Me.optPepperday.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optPepperday.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optPepperday.CausesValidation = True
		Me.optPepperday.Enabled = True
		Me.optPepperday.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optPepperday.Cursor = System.Windows.Forms.Cursors.Default
		Me.optPepperday.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optPepperday.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optPepperday.TabStop = True
		Me.optPepperday.Visible = True
		Me.optPepperday.Name = "optPepperday"
		Me.cmdSTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSTable.Text = "&S-Table"
		Me.cmdSTable.Size = New System.Drawing.Size(57, 22)
		Me.cmdSTable.Location = New System.Drawing.Point(608, 120)
		Me.cmdSTable.TabIndex = 43
		Me.cmdSTable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSTable.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSTable.CausesValidation = True
		Me.cmdSTable.Enabled = True
		Me.cmdSTable.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSTable.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSTable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSTable.TabStop = True
		Me.cmdSTable.Name = "cmdSTable"
		Me.chkSadler.BackColor = System.Drawing.SystemColors.Window
		Me.chkSadler.Text = "Use Sadler Technique"
		Me.chkSadler.Size = New System.Drawing.Size(129, 17)
		Me.chkSadler.Location = New System.Drawing.Point(424, 332)
		Me.chkSadler.TabIndex = 62
		Me.chkSadler.Visible = False
		Me.chkSadler.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSadler.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkSadler.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkSadler.CausesValidation = True
		Me.chkSadler.Enabled = True
		Me.chkSadler.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkSadler.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSadler.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSadler.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkSadler.TabStop = True
		Me.chkSadler.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkSadler.Name = "chkSadler"
		Me.frame214.BackColor = System.Drawing.SystemColors.Window
		Me.frame214.Text = "Solution using"
		Me.frame214.Size = New System.Drawing.Size(201, 32)
		Me.frame214.Location = New System.Drawing.Point(464, 145)
		Me.frame214.TabIndex = 49
		Me.frame214.Visible = False
		Me.frame214.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frame214.Enabled = True
		Me.frame214.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frame214.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frame214.Padding = New System.Windows.Forms.Padding(0)
		Me.frame214.Name = "frame214"
		Me.optdtL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optdtL.BackColor = System.Drawing.SystemColors.Window
		Me.optdtL.Text = "D"
		Me.optdtL.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.optdtL.Size = New System.Drawing.Size(25, 14)
		Me.optdtL.Location = New System.Drawing.Point(120, 14)
		Me.optdtL.TabIndex = 53
		Me.optdtL.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optdtL.CausesValidation = True
		Me.optdtL.Enabled = True
		Me.optdtL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optdtL.Cursor = System.Windows.Forms.Cursors.Default
		Me.optdtL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optdtL.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optdtL.TabStop = True
		Me.optdtL.Checked = False
		Me.optdtL.Visible = True
		Me.optdtL.Name = "optdtL"
		Me.optdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optdt.BackColor = System.Drawing.SystemColors.Window
		Me.optdt.Text = "D"
		Me.optdt.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.optdt.Size = New System.Drawing.Size(25, 14)
		Me.optdt.Location = New System.Drawing.Point(56, 14)
		Me.optdt.TabIndex = 51
		Me.optdt.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optdt.CausesValidation = True
		Me.optdt.Enabled = True
		Me.optdt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optdt.Cursor = System.Windows.Forms.Cursors.Default
		Me.optdt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optdt.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optdt.TabStop = True
		Me.optdt.Checked = False
		Me.optdt.Visible = True
		Me.optdt.Name = "optdt"
		Me.optd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optd.BackColor = System.Drawing.SystemColors.Window
		Me.optd.Text = "D"
		Me.optd.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.optd.Size = New System.Drawing.Size(25, 14)
		Me.optd.Location = New System.Drawing.Point(8, 14)
		Me.optd.TabIndex = 50
		Me.optd.Checked = True
		Me.optd.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optd.CausesValidation = True
		Me.optd.Enabled = True
		Me.optd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optd.Cursor = System.Windows.Forms.Cursors.Default
		Me.optd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optd.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optd.TabStop = True
		Me.optd.Visible = True
		Me.optd.Name = "optd"
		Me.Label15.BackColor = System.Drawing.SystemColors.Window
		Me.Label15.Text = "L"
		Me.Label15.Size = New System.Drawing.Size(8, 17)
		Me.Label15.Location = New System.Drawing.Point(186, 14)
		Me.Label15.TabIndex = 61
		Me.Label15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label14.BackColor = System.Drawing.SystemColors.Window
		Me.Label14.Text = "D"
		Me.Label14.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.Label14.Size = New System.Drawing.Size(8, 17)
		Me.Label14.Location = New System.Drawing.Point(176, 14)
		Me.Label14.TabIndex = 60
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label13.BackColor = System.Drawing.SystemColors.Window
		Me.Label13.Text = "t,"
		Me.Label13.Size = New System.Drawing.Size(8, 17)
		Me.Label13.Location = New System.Drawing.Point(168, 14)
		Me.Label13.TabIndex = 59
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.BackColor = System.Drawing.SystemColors.Window
		Me.Label12.Text = "D"
		Me.Label12.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.Label12.Size = New System.Drawing.Size(8, 17)
		Me.Label12.Location = New System.Drawing.Point(157, 14)
		Me.Label12.TabIndex = 58
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label11.BackColor = System.Drawing.SystemColors.Window
		Me.Label11.Text = "d,"
		Me.Label11.Size = New System.Drawing.Size(8, 17)
		Me.Label11.Location = New System.Drawing.Point(147, 14)
		Me.Label11.TabIndex = 57
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label10.BackColor = System.Drawing.SystemColors.Window
		Me.Label10.Text = "t"
		Me.Label10.Size = New System.Drawing.Size(5, 17)
		Me.Label10.Location = New System.Drawing.Point(104, 14)
		Me.Label10.TabIndex = 56
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
		Me.Label8.BackColor = System.Drawing.SystemColors.Window
		Me.Label8.Text = "d,"
		Me.Label8.Size = New System.Drawing.Size(8, 14)
		Me.Label8.Location = New System.Drawing.Point(84, 14)
		Me.Label8.TabIndex = 55
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
		Me.Label7.BackColor = System.Drawing.SystemColors.Window
		Me.Label7.Text = "d"
		Me.Label7.Size = New System.Drawing.Size(5, 14)
		Me.Label7.Location = New System.Drawing.Point(35, 14)
		Me.Label7.TabIndex = 54
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label9.BackColor = System.Drawing.SystemColors.Window
		Me.Label9.Text = "D"
		Me.Label9.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.Label9.Size = New System.Drawing.Size(8, 17)
		Me.Label9.Location = New System.Drawing.Point(94, 14)
		Me.Label9.TabIndex = 52
		Me.Label9.Visible = False
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.chkDSD.BackColor = System.Drawing.SystemColors.Window
		Me.chkDSD.Text = "Always use DSD"
		Me.chkDSD.Size = New System.Drawing.Size(105, 17)
		Me.chkDSD.Location = New System.Drawing.Point(392, 150)
		Me.chkDSD.TabIndex = 47
		Me.chkDSD.Visible = False
		Me.chkDSD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDSD.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkDSD.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDSD.CausesValidation = True
		Me.chkDSD.Enabled = True
		Me.chkDSD.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDSD.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDSD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDSD.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDSD.TabStop = True
		Me.chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDSD.Name = "chkDSD"
		Me.frame211.BackColor = System.Drawing.SystemColors.Window
		Me.frame211.Text = "Version"
		Me.frame211.Size = New System.Drawing.Size(137, 34)
		Me.frame211.Location = New System.Drawing.Point(528, 145)
		Me.frame211.TabIndex = 44
		Me.frame211.Visible = False
		Me.frame211.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frame211.Enabled = True
		Me.frame211.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frame211.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frame211.Padding = New System.Windows.Forms.Padding(0)
		Me.frame211.Name = "frame211"
		Me.optCompact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optCompact.BackColor = System.Drawing.SystemColors.Window
		Me.optCompact.Text = "Compact"
		Me.optCompact.Size = New System.Drawing.Size(67, 17)
		Me.optCompact.Location = New System.Drawing.Point(4, 14)
		Me.optCompact.TabIndex = 46
		Me.optCompact.Checked = True
		Me.optCompact.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optCompact.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optCompact.CausesValidation = True
		Me.optCompact.Enabled = True
		Me.optCompact.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optCompact.Cursor = System.Windows.Forms.Cursors.Default
		Me.optCompact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optCompact.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optCompact.TabStop = True
		Me.optCompact.Visible = True
		Me.optCompact.Name = "optCompact"
		Me.optOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOriginal.BackColor = System.Drawing.SystemColors.Window
		Me.optOriginal.Text = "Original"
		Me.optOriginal.Size = New System.Drawing.Size(61, 17)
		Me.optOriginal.Location = New System.Drawing.Point(72, 14)
		Me.optOriginal.TabIndex = 45
		Me.optOriginal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optOriginal.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optOriginal.CausesValidation = True
		Me.optOriginal.Enabled = True
		Me.optOriginal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optOriginal.Cursor = System.Windows.Forms.Cursors.Default
		Me.optOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optOriginal.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optOriginal.TabStop = True
		Me.optOriginal.Checked = False
		Me.optOriginal.Visible = True
		Me.optOriginal.Name = "optOriginal"
		Me.cmd208.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmd208.Text = "H.O. 20&8"
		Me.cmd208.Size = New System.Drawing.Size(57, 25)
		Me.cmd208.Location = New System.Drawing.Point(608, 88)
		Me.cmd208.TabIndex = 41
		Me.cmd208.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd208.BackColor = System.Drawing.SystemColors.Control
		Me.cmd208.CausesValidation = True
		Me.cmd208.Enabled = True
		Me.cmd208.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmd208.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmd208.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmd208.TabStop = True
		Me.cmd208.Name = "cmd208"
		Me.cmd211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmd211.Text = "H.O. 21&1"
		Me.cmd211.Size = New System.Drawing.Size(57, 25)
		Me.cmd211.Location = New System.Drawing.Point(608, 56)
		Me.cmd211.TabIndex = 40
		Me.cmd211.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd211.BackColor = System.Drawing.SystemColors.Control
		Me.cmd211.CausesValidation = True
		Me.cmd211.Enabled = True
		Me.cmd211.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmd211.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmd211.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmd211.TabStop = True
		Me.cmd211.Name = "cmd211"
		Me.cmd214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmd214.Text = "H.O. 21&4"
		Me.cmd214.Size = New System.Drawing.Size(65, 25)
		Me.cmd214.Location = New System.Drawing.Point(536, 88)
		Me.cmd214.TabIndex = 39
		Me.cmd214.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd214.BackColor = System.Drawing.SystemColors.Control
		Me.cmd214.CausesValidation = True
		Me.cmd214.Enabled = True
		Me.cmd214.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmd214.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmd214.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmd214.TabStop = True
		Me.cmd214.Name = "cmd214"
		Me.cmd229.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmd229.Text = "Pub. 22&9"
		Me.cmd229.Size = New System.Drawing.Size(65, 25)
		Me.cmd229.Location = New System.Drawing.Point(536, 56)
		Me.cmd229.TabIndex = 38
		Me.cmd229.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd229.BackColor = System.Drawing.SystemColors.Control
		Me.cmd229.CausesValidation = True
		Me.cmd229.Enabled = True
		Me.cmd229.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmd229.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmd229.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmd229.TabStop = True
		Me.cmd229.Name = "cmd229"
		Me.cmd249.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmd249.Text = "Pub. &249 Vol. 2 && 3"
		Me.cmd249.Size = New System.Drawing.Size(105, 25)
		Me.cmd249.Location = New System.Drawing.Point(536, 24)
		Me.cmd249.TabIndex = 37
		Me.cmd249.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd249.BackColor = System.Drawing.SystemColors.Control
		Me.cmd249.CausesValidation = True
		Me.cmd249.Enabled = True
		Me.cmd249.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmd249.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmd249.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmd249.TabStop = True
		Me.cmd249.Name = "cmd249"
		Me.cmdClearSome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClearSome.Text = "&Clear except DR"
		Me.cmdClearSome.Size = New System.Drawing.Size(89, 25)
		Me.cmdClearSome.Location = New System.Drawing.Point(88, 112)
		Me.cmdClearSome.TabIndex = 70
		Me.cmdClearSome.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClearSome.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClearSome.CausesValidation = True
		Me.cmdClearSome.Enabled = True
		Me.cmdClearSome.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClearSome.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClearSome.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClearSome.TabStop = True
		Me.cmdClearSome.Name = "cmdClearSome"
		Me.cmdMerDiag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMerDiag.Text = "&Meridian Diagram"
		Me.cmdMerDiag.Size = New System.Drawing.Size(97, 25)
		Me.cmdMerDiag.Location = New System.Drawing.Point(568, 328)
		Me.cmdMerDiag.TabIndex = 69
		Me.cmdMerDiag.Visible = False
		Me.cmdMerDiag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMerDiag.BackColor = System.Drawing.SystemColors.Control
		Me.cmdMerDiag.CausesValidation = True
		Me.cmdMerDiag.Enabled = True
		Me.cmdMerDiag.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdMerDiag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMerDiag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdMerDiag.TabStop = True
		Me.cmdMerDiag.Name = "cmdMerDiag"
		Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClear.Text = "Clear &All"
		Me.cmdClear.Size = New System.Drawing.Size(81, 25)
		Me.cmdClear.Location = New System.Drawing.Point(56, 328)
		Me.cmdClear.TabIndex = 71
		Me.cmdClear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClear.CausesValidation = True
		Me.cmdClear.Enabled = True
		Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.TabStop = True
		Me.cmdClear.Name = "cmdClear"
		Me.txtTime.AutoSize = False
		Me.txtTime.Size = New System.Drawing.Size(33, 19)
		Me.txtTime.Location = New System.Drawing.Point(296, 56)
		Me.txtTime.Maxlength = 4
		Me.txtTime.TabIndex = 13
		Me.ToolTip1.SetToolTip(Me.txtTime, "Range 0000 to 2359")
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
		Me.txtTime.Visible = True
		Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTime.Name = "txtTime"
		Me.cmdFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFix.Text = "&Establish Fix"
		Me.cmdFix.Size = New System.Drawing.Size(81, 25)
		Me.cmdFix.Location = New System.Drawing.Point(336, 328)
		Me.cmdFix.TabIndex = 68
		Me.cmdFix.Visible = False
		Me.cmdFix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFix.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFix.CausesValidation = True
		Me.cmdFix.Enabled = True
		Me.cmdFix.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFix.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFix.TabStop = True
		Me.cmdFix.Name = "cmdFix"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "&Save for Fix"
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.Location = New System.Drawing.Point(248, 328)
		Me.cmdSave.TabIndex = 67
		Me.cmdSave.Visible = False
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.frameNASRUsing.BackColor = System.Drawing.SystemColors.Window
		Me.frameNASRUsing.Text = "Use Auxiliary Table from"
		Me.frameNASRUsing.Size = New System.Drawing.Size(177, 57)
		Me.frameNASRUsing.Location = New System.Drawing.Point(8, 240)
		Me.frameNASRUsing.TabIndex = 31
		Me.frameNASRUsing.Visible = False
		Me.frameNASRUsing.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frameNASRUsing.Enabled = True
		Me.frameNASRUsing.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frameNASRUsing.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frameNASRUsing.Padding = New System.Windows.Forms.Padding(0)
		Me.frameNASRUsing.Name = "frameNASRUsing"
		Me.optNATable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optNATable.BackColor = System.Drawing.SystemColors.Window
		Me.optNATable.Text = "Pre-1999/post-2004 Almanac "
		Me.optNATable.Size = New System.Drawing.Size(164, 17)
		Me.optNATable.Location = New System.Drawing.Point(8, 16)
		Me.optNATable.TabIndex = 33
		Me.optNATable.Checked = True
		Me.optNATable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optNATable.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optNATable.CausesValidation = True
		Me.optNATable.Enabled = True
		Me.optNATable.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optNATable.Cursor = System.Windows.Forms.Cursors.Default
		Me.optNATable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optNATable.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optNATable.TabStop = True
		Me.optNATable.Visible = True
		Me.optNATable.Name = "optNATable"
		Me.optUSPSTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optUSPSTable.BackColor = System.Drawing.SystemColors.Window
		Me.optUSPSTable.Text = "1999-2004 Almanac"
		Me.optUSPSTable.Size = New System.Drawing.Size(120, 17)
		Me.optUSPSTable.Location = New System.Drawing.Point(8, 32)
		Me.optUSPSTable.TabIndex = 32
		Me.optUSPSTable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optUSPSTable.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optUSPSTable.CausesValidation = True
		Me.optUSPSTable.Enabled = True
		Me.optUSPSTable.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optUSPSTable.Cursor = System.Windows.Forms.Cursors.Default
		Me.optUSPSTable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optUSPSTable.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optUSPSTable.TabStop = True
		Me.optUSPSTable.Checked = False
		Me.optUSPSTable.Visible = True
		Me.optUSPSTable.Name = "optUSPSTable"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
		Me.cmdPrint.Location = New System.Drawing.Point(651, 2)
		Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
		Me.cmdPrint.TabIndex = 72
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
		Me.cmdNASR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNASR.Text = "&NASR"
		Me.cmdNASR.Size = New System.Drawing.Size(97, 33)
		Me.cmdNASR.Location = New System.Drawing.Point(424, 88)
		Me.cmdNASR.TabIndex = 30
		Me.cmdNASR.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNASR.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNASR.CausesValidation = True
		Me.cmdNASR.Enabled = True
		Me.cmdNASR.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNASR.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNASR.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNASR.TabStop = True
		Me.cmdNASR.Name = "cmdNASR"
		Me.cmdLawOfCosines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLawOfCosines.Text = "&Law of Cosines"
		Me.cmdLawOfCosines.Size = New System.Drawing.Size(97, 33)
		Me.cmdLawOfCosines.Location = New System.Drawing.Point(424, 24)
		Me.cmdLawOfCosines.TabIndex = 29
		Me.cmdLawOfCosines.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLawOfCosines.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLawOfCosines.CausesValidation = True
		Me.cmdLawOfCosines.Enabled = True
		Me.cmdLawOfCosines.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLawOfCosines.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLawOfCosines.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLawOfCosines.TabStop = True
		Me.cmdLawOfCosines.Name = "cmdLawOfCosines"
		Me.cboDec.Size = New System.Drawing.Size(41, 21)
		Me.cboDec.Location = New System.Drawing.Point(120, 32)
		Me.cboDec.Items.AddRange(New Object(){"N ", "S "})
		Me.cboDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDec.TabIndex = 4
		Me.cboDec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDec.BackColor = System.Drawing.SystemColors.Window
		Me.cboDec.CausesValidation = True
		Me.cboDec.Enabled = True
		Me.cboDec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDec.IntegralHeight = True
		Me.cboDec.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDec.Sorted = False
		Me.cboDec.TabStop = True
		Me.cboDec.Visible = True
		Me.cboDec.Name = "cboDec"
		Me.txtHoMin.AutoSize = False
		Me.txtHoMin.Size = New System.Drawing.Size(33, 19)
		Me.txtHoMin.Location = New System.Drawing.Point(80, 56)
		Me.txtHoMin.Maxlength = 5
		Me.txtHoMin.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.txtHoMin, "Range -59.9 to 59.9")
		Me.txtHoMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHoMin.AcceptsReturn = True
		Me.txtHoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHoMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtHoMin.CausesValidation = True
		Me.txtHoMin.Enabled = True
		Me.txtHoMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHoMin.HideSelection = True
		Me.txtHoMin.ReadOnly = False
		Me.txtHoMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHoMin.MultiLine = False
		Me.txtHoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHoMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHoMin.TabStop = True
		Me.txtHoMin.Visible = True
		Me.txtHoMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHoMin.Name = "txtHoMin"
		Me.txtDecMin.AutoSize = False
		Me.txtDecMin.Size = New System.Drawing.Size(33, 19)
		Me.txtDecMin.Location = New System.Drawing.Point(80, 32)
		Me.txtDecMin.Maxlength = 4
		Me.txtDecMin.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.txtDecMin, "Range 0 to 59.9")
		Me.txtDecMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDecMin.AcceptsReturn = True
		Me.txtDecMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDecMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtDecMin.CausesValidation = True
		Me.txtDecMin.Enabled = True
		Me.txtDecMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDecMin.HideSelection = True
		Me.txtDecMin.ReadOnly = False
		Me.txtDecMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDecMin.MultiLine = False
		Me.txtDecMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDecMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDecMin.TabStop = True
		Me.txtDecMin.Visible = True
		Me.txtDecMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDecMin.Name = "txtDecMin"
		Me.txtGHAMin.AutoSize = False
		Me.txtGHAMin.Size = New System.Drawing.Size(33, 19)
		Me.txtGHAMin.Location = New System.Drawing.Point(80, 8)
		Me.txtGHAMin.Maxlength = 4
		Me.txtGHAMin.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.txtGHAMin, "Range 0 to 59.9")
		Me.txtGHAMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGHAMin.AcceptsReturn = True
		Me.txtGHAMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGHAMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtGHAMin.CausesValidation = True
		Me.txtGHAMin.Enabled = True
		Me.txtGHAMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGHAMin.HideSelection = True
		Me.txtGHAMin.ReadOnly = False
		Me.txtGHAMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGHAMin.MultiLine = False
		Me.txtGHAMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGHAMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGHAMin.TabStop = True
		Me.txtGHAMin.Visible = True
		Me.txtGHAMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGHAMin.Name = "txtGHAMin"
		Me.txtHoDeg.AutoSize = False
		Me.txtHoDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtHoDeg.Location = New System.Drawing.Point(48, 56)
		Me.txtHoDeg.Maxlength = 2
		Me.txtHoDeg.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.txtHoDeg, "Range 0 to 88 for LoC, 0 to 75 for NASR, 0 to 85 for 229, 0 to 90 for others")
		Me.txtHoDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHoDeg.AcceptsReturn = True
		Me.txtHoDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHoDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtHoDeg.CausesValidation = True
		Me.txtHoDeg.Enabled = True
		Me.txtHoDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHoDeg.HideSelection = True
		Me.txtHoDeg.ReadOnly = False
		Me.txtHoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHoDeg.MultiLine = False
		Me.txtHoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHoDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHoDeg.TabStop = True
		Me.txtHoDeg.Visible = True
		Me.txtHoDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHoDeg.Name = "txtHoDeg"
		Me.txtDecDeg.AutoSize = False
		Me.txtDecDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtDecDeg.Location = New System.Drawing.Point(48, 32)
		Me.txtDecDeg.Maxlength = 2
		Me.txtDecDeg.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.txtDecDeg, "Range 0 to 90")
		Me.txtDecDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDecDeg.AcceptsReturn = True
		Me.txtDecDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDecDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtDecDeg.CausesValidation = True
		Me.txtDecDeg.Enabled = True
		Me.txtDecDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDecDeg.HideSelection = True
		Me.txtDecDeg.ReadOnly = False
		Me.txtDecDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDecDeg.MultiLine = False
		Me.txtDecDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDecDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDecDeg.TabStop = True
		Me.txtDecDeg.Visible = True
		Me.txtDecDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDecDeg.Name = "txtDecDeg"
		Me.txtGHADeg.AutoSize = False
		Me.txtGHADeg.Size = New System.Drawing.Size(33, 19)
		Me.txtGHADeg.Location = New System.Drawing.Point(40, 8)
		Me.txtGHADeg.Maxlength = 3
		Me.txtGHADeg.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.txtGHADeg, "Range 0 to 719")
		Me.txtGHADeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGHADeg.AcceptsReturn = True
		Me.txtGHADeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGHADeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtGHADeg.CausesValidation = True
		Me.txtGHADeg.Enabled = True
		Me.txtGHADeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGHADeg.HideSelection = True
		Me.txtGHADeg.ReadOnly = False
		Me.txtGHADeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGHADeg.MultiLine = False
		Me.txtGHADeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGHADeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGHADeg.TabStop = True
		Me.txtGHADeg.Visible = True
		Me.txtGHADeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGHADeg.Name = "txtGHADeg"
		Me.txtLMin.AutoSize = False
		Me.txtLMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLMin.Location = New System.Drawing.Point(296, 8)
		Me.txtLMin.Maxlength = 4
		Me.txtLMin.TabIndex = 8
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
		Me.cboL.Size = New System.Drawing.Size(41, 21)
		Me.cboL.Location = New System.Drawing.Point(336, 8)
		Me.cboL.Items.AddRange(New Object(){"N ", "S "})
		Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboL.TabIndex = 9
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
		Me.txtLoDeg.AutoSize = False
		Me.txtLoDeg.Size = New System.Drawing.Size(33, 19)
		Me.txtLoDeg.Location = New System.Drawing.Point(256, 32)
		Me.txtLoDeg.Maxlength = 3
		Me.txtLoDeg.TabIndex = 10
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
		Me.txtLoMin.AutoSize = False
		Me.txtLoMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLoMin.Location = New System.Drawing.Point(296, 32)
		Me.txtLoMin.Maxlength = 4
		Me.txtLoMin.TabIndex = 11
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
		Me.cboLo.Size = New System.Drawing.Size(41, 21)
		Me.cboLo.Location = New System.Drawing.Point(336, 32)
		Me.cboLo.Items.AddRange(New Object(){"W ", "E "})
		Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLo.TabIndex = 12
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
		Me.txtLDeg.AutoSize = False
		Me.txtLDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtLDeg.Location = New System.Drawing.Point(264, 8)
		Me.txtLDeg.Maxlength = 2
		Me.txtLDeg.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.txtLDeg, "Range 0 to 90")
		Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLDeg.AcceptsReturn = True
		Me.txtLDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLDeg.CausesValidation = True
		Me.txtLDeg.Enabled = True
		Me.txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText
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
		Me.Line23.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
		Me.Line23.Visible = False
		Me.Line23.X1 = 422
		Me.Line23.X2 = 422
		Me.Line23.Y1 = 164
		Me.Line23.Y2 = 251
		Me.Line23.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line23.BorderWidth = 1
		Me.Line23.Name = "Line23"
		Me.Line22.Visible = False
		Me.Line22.X1 = 440
		Me.Line22.X2 = 528
		Me.Line22.Y1 = 248
		Me.Line22.Y2 = 248
		Me.Line22.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line22.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line22.BorderWidth = 1
		Me.Line22.Name = "Line22"
		Me.Line21.Visible = False
		Me.Line21.X1 = 296
		Me.Line21.X2 = 392
		Me.Line21.Y1 = 248
		Me.Line21.Y2 = 248
		Me.Line21.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line21.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line21.BorderWidth = 1
		Me.Line21.Name = "Line21"
		Me.Line20.Visible = False
		Me.Line20.X1 = 336
		Me.Line20.X2 = 408
		Me.Line20.Y1 = 208
		Me.Line20.Y2 = 208
		Me.Line20.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line20.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line20.BorderWidth = 1
		Me.Line20.Name = "Line20"
		Me.Line19.Visible = False
		Me.Line19.X1 = 174
		Me.Line19.X2 = 259
		Me.Line19.Y1 = 220
		Me.Line19.Y2 = 220
		Me.Line19.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line19.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line19.BorderWidth = 1
		Me.Line19.Name = "Line19"
		Me.Line18.Visible = False
		Me.Line18.X1 = 80
		Me.Line18.X2 = 152
		Me.Line18.Y1 = 192
		Me.Line18.Y2 = 192
		Me.Line18.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line18.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line18.BorderWidth = 1
		Me.Line18.Name = "Line18"
		Me.Line17.Visible = False
		Me.Line17.X1 = 120
		Me.Line17.X2 = 120
		Me.Line17.Y1 = 196
		Me.Line17.Y2 = 220
		Me.Line17.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line17.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line17.BorderWidth = 1
		Me.Line17.Name = "Line17"
		Me.Line16.Visible = False
		Me.Line16.X1 = 184
		Me.Line16.X2 = 244
		Me.Line16.Y1 = 208
		Me.Line16.Y2 = 208
		Me.Line16.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line16.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line16.BorderWidth = 1
		Me.Line16.Name = "Line16"
		Me.Line15.Visible = False
		Me.Line15.X1 = 472
		Me.Line15.X2 = 528
		Me.Line15.Y1 = 289
		Me.Line15.Y2 = 289
		Me.Line15.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line15.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line15.BorderWidth = 1
		Me.Line15.Name = "Line15"
		Me.Line14.Visible = False
		Me.Line14.X1 = 328
		Me.Line14.X2 = 384
		Me.Line14.Y1 = 262
		Me.Line14.Y2 = 262
		Me.Line14.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line14.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line14.BorderWidth = 1
		Me.Line14.Name = "Line14"
		Me.Line13.Visible = False
		Me.Line13.X1 = 328
		Me.Line13.X2 = 384
		Me.Line13.Y1 = 248
		Me.Line13.Y2 = 248
		Me.Line13.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line13.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line13.BorderWidth = 1
		Me.Line13.Name = "Line13"
		Me.Line12.Visible = False
		Me.Line12.X1 = 184
		Me.Line12.X2 = 240
		Me.Line12.Y1 = 235
		Me.Line12.Y2 = 235
		Me.Line12.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line12.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line12.BorderWidth = 1
		Me.Line12.Name = "Line12"
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Select Method"
		Me.Label6.Size = New System.Drawing.Size(73, 17)
		Me.Label6.Location = New System.Drawing.Point(496, 8)
		Me.Label6.TabIndex = 48
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
		Me.Line11.Visible = False
		Me.Line11.X1 = 664
		Me.Line11.X2 = 608
		Me.Line11.Y1 = 262
		Me.Line11.Y2 = 262
		Me.Line11.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line11.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line11.BorderWidth = 1
		Me.Line11.Name = "Line11"
		Me.Line10.Visible = False
		Me.Line10.X1 = 464
		Me.Line10.X2 = 528
		Me.Line10.Y1 = 249
		Me.Line10.Y2 = 249
		Me.Line10.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line10.BorderWidth = 1
		Me.Line10.Name = "Line10"
		Me.Line9.Visible = False
		Me.Line9.X1 = 64
		Me.Line9.X2 = 112
		Me.Line9.Y1 = 276
		Me.Line9.Y2 = 276
		Me.Line9.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line9.BorderWidth = 1
		Me.Line9.Name = "Line9"
		Me.Line8.Visible = False
		Me.Line8.X1 = 64
		Me.Line8.X2 = 112
		Me.Line8.Y1 = 234
		Me.Line8.Y2 = 234
		Me.Line8.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line8.BorderWidth = 1
		Me.Line8.Name = "Line8"
		Me.Line7.Visible = False
		Me.Line7.X1 = 328
		Me.Line7.X2 = 384
		Me.Line7.Y1 = 207
		Me.Line7.Y2 = 207
		Me.Line7.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line7.BorderWidth = 1
		Me.Line7.Name = "Line7"
		Me.Line6.Visible = False
		Me.Line6.X1 = 184
		Me.Line6.X2 = 244
		Me.Line6.Y1 = 193
		Me.Line6.Y2 = 193
		Me.Line6.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line6.BorderWidth = 1
		Me.Line6.Name = "Line6"
		Me.Shape3.Size = New System.Drawing.Size(215, 25)
		Me.Shape3.Location = New System.Drawing.Point(200, 280)
		Me.Shape3.Visible = False
		Me.Shape3.BackColor = System.Drawing.SystemColors.Window
		Me.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape3.BorderWidth = 1
		Me.Shape3.FillColor = System.Drawing.Color.Black
		Me.Shape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape3.Name = "Shape3"
		Me.Line5.X1 = 528
		Me.Line5.X2 = 528
		Me.Line5.Y1 = 24
		Me.Line5.Y2 = 144
		Me.Line5.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line5.BorderWidth = 1
		Me.Line5.Visible = True
		Me.Line5.Name = "Line5"
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "To use LHA instead of GHA, enter LHA  in place of GHA and set DR Lo to zero or leave blank."
		Me.Label5.Size = New System.Drawing.Size(185, 41)
		Me.Label5.Location = New System.Drawing.Point(8, 77)
		Me.Label5.TabIndex = 36
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.BackColor = System.Drawing.SystemColors.Window
		Me.Label4.Text = "Time is only required for establishing a fix from a moving vessel using Law of Cosines."
		Me.Label4.Size = New System.Drawing.Size(121, 57)
		Me.Label4.Location = New System.Drawing.Point(240, 80)
		Me.Label4.TabIndex = 35
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.lblTime.BackColor = System.Drawing.SystemColors.Window
		Me.lblTime.Text = "Time (hhmm)"
		Me.lblTime.Size = New System.Drawing.Size(65, 17)
		Me.lblTime.Location = New System.Drawing.Point(224, 56)
		Me.lblTime.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me.lblTime, "Watch Time")
		Me.lblTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTime.Enabled = True
		Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTime.UseMnemonic = True
		Me.lblTime.Visible = True
		Me.lblTime.AutoSize = False
		Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTime.Name = "lblTime"
		Me.Shape2.Size = New System.Drawing.Size(159, 17)
		Me.Shape2.Location = New System.Drawing.Point(340, 219)
		Me.Shape2.Visible = False
		Me.Shape2.BackColor = System.Drawing.SystemColors.Window
		Me.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape2.BorderWidth = 1
		Me.Shape2.FillColor = System.Drawing.Color.Black
		Me.Shape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape2.Name = "Shape2"
		Me.Shape1.Size = New System.Drawing.Size(207, 17)
		Me.Shape1.Location = New System.Drawing.Point(320, 164)
		Me.Shape1.Visible = False
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.BorderWidth = 1
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Name = "Shape1"
		Me.Line4.Visible = False
		Me.Line4.X1 = 192
		Me.Line4.X2 = 192
		Me.Line4.Y1 = 168
		Me.Line4.Y2 = 364
		Me.Line4.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line4.BorderWidth = 1
		Me.Line4.Name = "Line4"
		Me.Line2.BorderWidth = 2
		Me.Line2.X1 = 0
		Me.Line2.X2 = 672
		Me.Line2.Y1 = 144
		Me.Line2.Y2 = 144
		Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line2.Visible = True
		Me.Line2.Name = "Line2"
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 0
		Me.Line1.X2 = 672
		Me.Line1.Y1 = 0
		Me.Line1.Y2 = 0
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Line3.BorderWidth = 2
		Me.Line3.X1 = 0
		Me.Line3.X2 = 672
		Me.Line3.Y1 = 0
		Me.Line3.Y2 = 0
		Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line3.Visible = True
		Me.Line3.Name = "Line3"
		Me.lblHoMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblHoMin.Text = "'"
		Me.lblHoMin.Size = New System.Drawing.Size(9, 17)
		Me.lblHoMin.Location = New System.Drawing.Point(113, 56)
		Me.lblHoMin.TabIndex = 28
		Me.lblHoMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHoMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHoMin.Enabled = True
		Me.lblHoMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHoMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHoMin.UseMnemonic = True
		Me.lblHoMin.Visible = True
		Me.lblHoMin.AutoSize = False
		Me.lblHoMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHoMin.Name = "lblHoMin"
		Me.lblDecMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblDecMin.Text = "'"
		Me.lblDecMin.Size = New System.Drawing.Size(9, 17)
		Me.lblDecMin.Location = New System.Drawing.Point(113, 32)
		Me.lblDecMin.TabIndex = 27
		Me.lblDecMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDecMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDecMin.Enabled = True
		Me.lblDecMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDecMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDecMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDecMin.UseMnemonic = True
		Me.lblDecMin.Visible = True
		Me.lblDecMin.AutoSize = False
		Me.lblDecMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDecMin.Name = "lblDecMin"
		Me.lblGHAMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblGHAMin.Text = "'"
		Me.lblGHAMin.Size = New System.Drawing.Size(9, 17)
		Me.lblGHAMin.Location = New System.Drawing.Point(113, 8)
		Me.lblGHAMin.TabIndex = 26
		Me.lblGHAMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGHAMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGHAMin.Enabled = True
		Me.lblGHAMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGHAMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGHAMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGHAMin.UseMnemonic = True
		Me.lblGHAMin.Visible = True
		Me.lblGHAMin.AutoSize = False
		Me.lblGHAMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGHAMin.Name = "lblGHAMin"
		Me.lblHoDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblHoDeg.Text = "°"
		Me.lblHoDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblHoDeg.Location = New System.Drawing.Point(73, 56)
		Me.lblHoDeg.TabIndex = 25
		Me.lblHoDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHoDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHoDeg.Enabled = True
		Me.lblHoDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHoDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHoDeg.UseMnemonic = True
		Me.lblHoDeg.Visible = True
		Me.lblHoDeg.AutoSize = False
		Me.lblHoDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHoDeg.Name = "lblHoDeg"
		Me.lblDecDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblDecDeg.Text = "°"
		Me.lblDecDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblDecDeg.Location = New System.Drawing.Point(73, 32)
		Me.lblDecDeg.TabIndex = 24
		Me.lblDecDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDecDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDecDeg.Enabled = True
		Me.lblDecDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDecDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDecDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDecDeg.UseMnemonic = True
		Me.lblDecDeg.Visible = True
		Me.lblDecDeg.AutoSize = False
		Me.lblDecDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDecDeg.Name = "lblDecDeg"
		Me.lblGHADeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblGHADeg.Text = "°"
		Me.lblGHADeg.Size = New System.Drawing.Size(9, 17)
		Me.lblGHADeg.Location = New System.Drawing.Point(73, 8)
		Me.lblGHADeg.TabIndex = 23
		Me.lblGHADeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGHADeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGHADeg.Enabled = True
		Me.lblGHADeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGHADeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGHADeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGHADeg.UseMnemonic = True
		Me.lblGHADeg.Visible = True
		Me.lblGHADeg.AutoSize = False
		Me.lblGHADeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGHADeg.Name = "lblGHADeg"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "Ho"
		Me.Label3.Size = New System.Drawing.Size(25, 17)
		Me.Label3.Location = New System.Drawing.Point(7, 56)
		Me.Label3.TabIndex = 22
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
		Me.Label2.Text = "Dec"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(7, 32)
		Me.Label2.TabIndex = 21
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
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "GHA"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(7, 8)
		Me.Label1.TabIndex = 20
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
		Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRL.Text = "DR L"
		Me.lblDRL.Size = New System.Drawing.Size(25, 17)
		Me.lblDRL.Location = New System.Drawing.Point(216, 8)
		Me.lblDRL.TabIndex = 19
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
		Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblLDeg.Text = "°"
		Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLDeg.Location = New System.Drawing.Point(289, 8)
		Me.lblLDeg.TabIndex = 18
		Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLDeg.Enabled = True
		Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLDeg.UseMnemonic = True
		Me.lblLDeg.Visible = True
		Me.lblLDeg.AutoSize = False
		Me.lblLDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLDeg.Name = "lblLDeg"
		Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblLMin.Text = "'"
		Me.lblLMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLMin.Location = New System.Drawing.Point(329, 8)
		Me.lblLMin.TabIndex = 17
		Me.lblLMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLMin.Enabled = True
		Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLMin.UseMnemonic = True
		Me.lblLMin.Visible = True
		Me.lblLMin.AutoSize = False
		Me.lblLMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLMin.Name = "lblLMin"
		Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRLo.Text = "DR Lo"
		Me.lblDRLo.Size = New System.Drawing.Size(33, 17)
		Me.lblDRLo.Location = New System.Drawing.Point(216, 32)
		Me.lblDRLo.TabIndex = 16
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
		Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblLoDeg.Text = "°"
		Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLoDeg.Location = New System.Drawing.Point(289, 32)
		Me.lblLoDeg.TabIndex = 15
		Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLoDeg.Enabled = True
		Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLoDeg.UseMnemonic = True
		Me.lblLoDeg.Visible = True
		Me.lblLoDeg.AutoSize = False
		Me.lblLoDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLoDeg.Name = "lblLoDeg"
		Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblLoMin.Text = "'"
		Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLoMin.Location = New System.Drawing.Point(329, 32)
		Me.lblLoMin.TabIndex = 14
		Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLoMin.Enabled = True
		Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLoMin.UseMnemonic = True
		Me.lblLoMin.Visible = True
		Me.lblLoMin.AutoSize = False
		Me.lblLoMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLoMin.Name = "lblLoMin"
		Me.Controls.Add(chkInterpolateB)
		Me.Controls.Add(cmdWeems)
		Me.Controls.Add(frameS)
		Me.Controls.Add(cmdSTable)
		Me.Controls.Add(chkSadler)
		Me.Controls.Add(frame214)
		Me.Controls.Add(chkDSD)
		Me.Controls.Add(frame211)
		Me.Controls.Add(cmd208)
		Me.Controls.Add(cmd211)
		Me.Controls.Add(cmd214)
		Me.Controls.Add(cmd229)
		Me.Controls.Add(cmd249)
		Me.Controls.Add(cmdClearSome)
		Me.Controls.Add(cmdMerDiag)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(txtTime)
		Me.Controls.Add(cmdFix)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(frameNASRUsing)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdNASR)
		Me.Controls.Add(cmdLawOfCosines)
		Me.Controls.Add(cboDec)
		Me.Controls.Add(txtHoMin)
		Me.Controls.Add(txtDecMin)
		Me.Controls.Add(txtGHAMin)
		Me.Controls.Add(txtHoDeg)
		Me.Controls.Add(txtDecDeg)
		Me.Controls.Add(txtGHADeg)
		Me.Controls.Add(txtLMin)
		Me.Controls.Add(cboL)
		Me.Controls.Add(txtLoDeg)
		Me.Controls.Add(txtLoMin)
		Me.Controls.Add(cboLo)
		Me.Controls.Add(txtLDeg)
		Me.ShapeContainer1.Shapes.Add(Line23)
		Me.ShapeContainer1.Shapes.Add(Line22)
		Me.ShapeContainer1.Shapes.Add(Line21)
		Me.ShapeContainer1.Shapes.Add(Line20)
		Me.ShapeContainer1.Shapes.Add(Line19)
		Me.ShapeContainer1.Shapes.Add(Line18)
		Me.ShapeContainer1.Shapes.Add(Line17)
		Me.ShapeContainer1.Shapes.Add(Line16)
		Me.ShapeContainer1.Shapes.Add(Line15)
		Me.ShapeContainer1.Shapes.Add(Line14)
		Me.ShapeContainer1.Shapes.Add(Line13)
		Me.ShapeContainer1.Shapes.Add(Line12)
		Me.Controls.Add(Label6)
		Me.ShapeContainer1.Shapes.Add(Line11)
		Me.ShapeContainer1.Shapes.Add(Line10)
		Me.ShapeContainer1.Shapes.Add(Line9)
		Me.ShapeContainer1.Shapes.Add(Line8)
		Me.ShapeContainer1.Shapes.Add(Line7)
		Me.ShapeContainer1.Shapes.Add(Line6)
		Me.ShapeContainer1.Shapes.Add(Shape3)
		Me.ShapeContainer1.Shapes.Add(Line5)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(lblTime)
		Me.ShapeContainer1.Shapes.Add(Shape2)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.ShapeContainer1.Shapes.Add(Line4)
		Me.ShapeContainer1.Shapes.Add(Line2)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.ShapeContainer1.Shapes.Add(Line3)
		Me.Controls.Add(lblHoMin)
		Me.Controls.Add(lblDecMin)
		Me.Controls.Add(lblGHAMin)
		Me.Controls.Add(lblHoDeg)
		Me.Controls.Add(lblDecDeg)
		Me.Controls.Add(lblGHADeg)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblDRL)
		Me.Controls.Add(lblLDeg)
		Me.Controls.Add(lblLMin)
		Me.Controls.Add(lblDRLo)
		Me.Controls.Add(lblLoDeg)
		Me.Controls.Add(lblLoMin)
		Me.Controls.Add(ShapeContainer1)
		Me.frameS.Controls.Add(optFarley)
		Me.frameS.Controls.Add(optPepperday)
		Me.frame214.Controls.Add(optdtL)
		Me.frame214.Controls.Add(optdt)
		Me.frame214.Controls.Add(optd)
		Me.frame214.Controls.Add(Label15)
		Me.frame214.Controls.Add(Label14)
		Me.frame214.Controls.Add(Label13)
		Me.frame214.Controls.Add(Label12)
		Me.frame214.Controls.Add(Label11)
		Me.frame214.Controls.Add(Label10)
		Me.frame214.Controls.Add(Label8)
		Me.frame214.Controls.Add(Label7)
		Me.frame214.Controls.Add(Label9)
		Me.frame211.Controls.Add(optCompact)
		Me.frame211.Controls.Add(optOriginal)
		Me.frameNASRUsing.Controls.Add(optNATable)
		Me.frameNASRUsing.Controls.Add(optUSPSTable)
		Me.frameS.ResumeLayout(False)
		Me.frame214.ResumeLayout(False)
		Me.frame211.ResumeLayout(False)
		Me.frameNASRUsing.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class