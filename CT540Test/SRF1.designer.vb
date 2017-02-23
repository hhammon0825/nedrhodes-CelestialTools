<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Public WithEvents cboPlanets As System.Windows.Forms.ComboBox
	Public WithEvents chkAH As System.Windows.Forms.CheckBox
	Public WithEvents cboStars As System.Windows.Forms.ComboBox
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents cboL As System.Windows.Forms.ComboBox
	Public WithEvents cboSun As System.Windows.Forms.ComboBox
	Public WithEvents cmdMerDiag As System.Windows.Forms.Button
	Public WithEvents cmdEqT As System.Windows.Forms.Button
	Public WithEvents chkDST As System.Windows.Forms.CheckBox
	Public WithEvents txtIESec As System.Windows.Forms.TextBox
	Public WithEvents optHoParameters As System.Windows.Forms.RadioButton
	Public WithEvents optHoSRForm As System.Windows.Forms.RadioButton
	Public WithEvents txtSightNo As System.Windows.Forms.TextBox
	Public WithEvents cboDay As System.Windows.Forms.ComboBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdFix As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents txtIEdeg As System.Windows.Forms.TextBox
	Public WithEvents cboZDm As System.Windows.Forms.ComboBox
	Public WithEvents txtLDeg As System.Windows.Forms.TextBox
	Public WithEvents cboPolaris As System.Windows.Forms.ComboBox
	Public WithEvents cboDsUnit As System.Windows.Forms.ComboBox
	Public WithEvents txtDsDist As System.Windows.Forms.TextBox
	Public WithEvents optHorizonDipShort As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonArtificial As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonNatural As System.Windows.Forms.RadioButton
	Public WithEvents FrameHorizon As System.Windows.Forms.Panel
	Public WithEvents optHsDMS As System.Windows.Forms.RadioButton
	Public WithEvents optHsDMm As System.Windows.Forms.RadioButton
	Public WithEvents Framehs As System.Windows.Forms.Panel
	Public WithEvents optZDUT As System.Windows.Forms.RadioButton
	Public WithEvents optZDManual As System.Windows.Forms.RadioButton
	Public WithEvents optZDAuto As System.Windows.Forms.RadioButton
	Public WithEvents FrameZD As System.Windows.Forms.Panel
	Public WithEvents cmdReduce As System.Windows.Forms.Button
	Public WithEvents cboPressure As System.Windows.Forms.ComboBox
	Public WithEvents txtPressure As System.Windows.Forms.TextBox
	Public WithEvents cboTemperature As System.Windows.Forms.ComboBox
	Public WithEvents txtTemperature As System.Windows.Forms.TextBox
	Public WithEvents cboIE As System.Windows.Forms.ComboBox
	Public WithEvents txtIEmin As System.Windows.Forms.TextBox
	Public WithEvents cboHE As System.Windows.Forms.ComboBox
	Public WithEvents txtHE As System.Windows.Forms.TextBox
	Public WithEvents txtHsSec As System.Windows.Forms.TextBox
	Public WithEvents txtHsMin As System.Windows.Forms.TextBox
	Public WithEvents txtHsDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLMin As System.Windows.Forms.TextBox
	Public WithEvents cboBody As System.Windows.Forms.ComboBox
	Public WithEvents txtZDh As System.Windows.Forms.TextBox
	Public WithEvents cboWE As System.Windows.Forms.ComboBox
	Public WithEvents txtWESec As System.Windows.Forms.TextBox
	Public WithEvents txtWEMin As System.Windows.Forms.TextBox
	Public WithEvents txtTime As System.Windows.Forms.TextBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents cboMonth As System.Windows.Forms.ComboBox
	Public WithEvents optStdTPNo As System.Windows.Forms.RadioButton
	Public WithEvents optStdTPYes As System.Windows.Forms.RadioButton
	Public WithEvents FrameTP As System.Windows.Forms.Panel
	Public WithEvents FrameHo As System.Windows.Forms.Panel
	Public WithEvents lblZDDST As System.Windows.Forms.Label
	Public WithEvents lblIEsec As System.Windows.Forms.Label
	Public WithEvents lblHoCorrs As System.Windows.Forms.Label
	Public WithEvents lblSightNo As System.Windows.Forms.Label
	Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblSmallm As System.Windows.Forms.Label
	Public WithEvents lblM As System.Windows.Forms.Label
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line14 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblIEdeg As System.Windows.Forms.Label
	Public WithEvents lblZDm As System.Windows.Forms.Label
	Public WithEvents lblZDh As System.Windows.Forms.Label
	Public WithEvents lblDsDist As System.Windows.Forms.Label
	Public WithEvents lblHorizon As System.Windows.Forms.Label
	Public WithEvents lblPressure As System.Windows.Forms.Label
	Public WithEvents lblTempDeg As System.Windows.Forms.Label
	Public WithEvents lblTemperature As System.Windows.Forms.Label
	Public WithEvents lblStdT_P As System.Windows.Forms.Label
	Public WithEvents lblIEMin As System.Windows.Forms.Label
	Public WithEvents lblIE As System.Windows.Forms.Label
	Public WithEvents lblHE As System.Windows.Forms.Label
	Public WithEvents lblHsSec As System.Windows.Forms.Label
	Public WithEvents lblHsMin As System.Windows.Forms.Label
	Public WithEvents lblHsDeg As System.Windows.Forms.Label
	Public WithEvents lblHs As System.Windows.Forms.Label
	Public WithEvents lblHsFormat As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents lblDRLo As System.Windows.Forms.Label
	Public WithEvents lblLMin As System.Windows.Forms.Label
	Public WithEvents lblLDeg As System.Windows.Forms.Label
	Public WithEvents lblDRL As System.Windows.Forms.Label
	Public WithEvents lblBody As System.Windows.Forms.Label
	Public WithEvents lblZD As System.Windows.Forms.Label
	Public WithEvents lblZDAutoManual As System.Windows.Forms.Label
	Public WithEvents lblWEsec As System.Windows.Forms.Label
	Public WithEvents lblWEmin As System.Windows.Forms.Label
	Public WithEvents lblWE As System.Windows.Forms.Label
	Public WithEvents lblTime As System.Windows.Forms.Label
	Public WithEvents lblYear As System.Windows.Forms.Label
	Public WithEvents lblMonth As System.Windows.Forms.Label
	Public WithEvents lblDay As System.Windows.Forms.Label
	Public WithEvents lblDate As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.cboPlanets = New System.Windows.Forms.ComboBox
		Me.chkAH = New System.Windows.Forms.CheckBox
		Me.cboStars = New System.Windows.Forms.ComboBox
		Me.cboLo = New System.Windows.Forms.ComboBox
		Me.cboL = New System.Windows.Forms.ComboBox
		Me.cboSun = New System.Windows.Forms.ComboBox
		Me.cmdMerDiag = New System.Windows.Forms.Button
		Me.cmdEqT = New System.Windows.Forms.Button
		Me.chkDST = New System.Windows.Forms.CheckBox
		Me.txtIESec = New System.Windows.Forms.TextBox
		Me.optHoParameters = New System.Windows.Forms.RadioButton
		Me.optHoSRForm = New System.Windows.Forms.RadioButton
		Me.txtSightNo = New System.Windows.Forms.TextBox
		Me.cboDay = New System.Windows.Forms.ComboBox
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdFix = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.txtIEdeg = New System.Windows.Forms.TextBox
		Me.cboZDm = New System.Windows.Forms.ComboBox
		Me.txtLDeg = New System.Windows.Forms.TextBox
		Me.cboPolaris = New System.Windows.Forms.ComboBox
		Me.cboDsUnit = New System.Windows.Forms.ComboBox
		Me.txtDsDist = New System.Windows.Forms.TextBox
		Me.FrameHorizon = New System.Windows.Forms.Panel
		Me.optHorizonDipShort = New System.Windows.Forms.RadioButton
		Me.optHorizonArtificial = New System.Windows.Forms.RadioButton
		Me.optHorizonNatural = New System.Windows.Forms.RadioButton
		Me.Framehs = New System.Windows.Forms.Panel
		Me.optHsDMS = New System.Windows.Forms.RadioButton
		Me.optHsDMm = New System.Windows.Forms.RadioButton
		Me.FrameZD = New System.Windows.Forms.Panel
		Me.optZDUT = New System.Windows.Forms.RadioButton
		Me.optZDManual = New System.Windows.Forms.RadioButton
		Me.optZDAuto = New System.Windows.Forms.RadioButton
		Me.cmdReduce = New System.Windows.Forms.Button
		Me.cboPressure = New System.Windows.Forms.ComboBox
		Me.txtPressure = New System.Windows.Forms.TextBox
		Me.cboTemperature = New System.Windows.Forms.ComboBox
		Me.txtTemperature = New System.Windows.Forms.TextBox
		Me.cboIE = New System.Windows.Forms.ComboBox
		Me.txtIEmin = New System.Windows.Forms.TextBox
		Me.cboHE = New System.Windows.Forms.ComboBox
		Me.txtHE = New System.Windows.Forms.TextBox
		Me.txtHsSec = New System.Windows.Forms.TextBox
		Me.txtHsMin = New System.Windows.Forms.TextBox
		Me.txtHsDeg = New System.Windows.Forms.TextBox
		Me.txtLoMin = New System.Windows.Forms.TextBox
		Me.txtLoDeg = New System.Windows.Forms.TextBox
		Me.txtLMin = New System.Windows.Forms.TextBox
		Me.cboBody = New System.Windows.Forms.ComboBox
		Me.txtZDh = New System.Windows.Forms.TextBox
		Me.cboWE = New System.Windows.Forms.ComboBox
		Me.txtWESec = New System.Windows.Forms.TextBox
		Me.txtWEMin = New System.Windows.Forms.TextBox
		Me.txtTime = New System.Windows.Forms.TextBox
		Me.txtYear = New System.Windows.Forms.TextBox
		Me.cboMonth = New System.Windows.Forms.ComboBox
		Me.FrameTP = New System.Windows.Forms.Panel
		Me.optStdTPNo = New System.Windows.Forms.RadioButton
		Me.optStdTPYes = New System.Windows.Forms.RadioButton
		Me.FrameHo = New System.Windows.Forms.Panel
		Me.lblZDDST = New System.Windows.Forms.Label
		Me.lblIEsec = New System.Windows.Forms.Label
		Me.lblHoCorrs = New System.Windows.Forms.Label
		Me.lblSightNo = New System.Windows.Forms.Label
		Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblSmallm = New System.Windows.Forms.Label
		Me.lblM = New System.Windows.Forms.Label
		Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line14 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line8 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblIEdeg = New System.Windows.Forms.Label
		Me.lblZDm = New System.Windows.Forms.Label
		Me.lblZDh = New System.Windows.Forms.Label
		Me.lblDsDist = New System.Windows.Forms.Label
		Me.lblHorizon = New System.Windows.Forms.Label
		Me.lblPressure = New System.Windows.Forms.Label
		Me.lblTempDeg = New System.Windows.Forms.Label
		Me.lblTemperature = New System.Windows.Forms.Label
		Me.lblStdT_P = New System.Windows.Forms.Label
		Me.lblIEMin = New System.Windows.Forms.Label
		Me.lblIE = New System.Windows.Forms.Label
		Me.lblHE = New System.Windows.Forms.Label
		Me.lblHsSec = New System.Windows.Forms.Label
		Me.lblHsMin = New System.Windows.Forms.Label
		Me.lblHsDeg = New System.Windows.Forms.Label
		Me.lblHs = New System.Windows.Forms.Label
		Me.lblHsFormat = New System.Windows.Forms.Label
		Me.lblLoMin = New System.Windows.Forms.Label
		Me.lblLoDeg = New System.Windows.Forms.Label
		Me.lblDRLo = New System.Windows.Forms.Label
		Me.lblLMin = New System.Windows.Forms.Label
		Me.lblLDeg = New System.Windows.Forms.Label
		Me.lblDRL = New System.Windows.Forms.Label
		Me.lblBody = New System.Windows.Forms.Label
		Me.lblZD = New System.Windows.Forms.Label
		Me.lblZDAutoManual = New System.Windows.Forms.Label
		Me.lblWEsec = New System.Windows.Forms.Label
		Me.lblWEmin = New System.Windows.Forms.Label
		Me.lblWE = New System.Windows.Forms.Label
		Me.lblTime = New System.Windows.Forms.Label
		Me.lblYear = New System.Windows.Forms.Label
		Me.lblMonth = New System.Windows.Forms.Label
		Me.lblDay = New System.Windows.Forms.Label
		Me.lblDate = New System.Windows.Forms.Label
		Me.FrameHorizon.SuspendLayout()
		Me.Framehs.SuspendLayout()
		Me.FrameZD.SuspendLayout()
		Me.FrameTP.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Sight Reduction"
		Me.ClientSize = New System.Drawing.Size(674, 568)
		Me.Location = New System.Drawing.Point(56, 29)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("Form1.Icon"), System.Drawing.Icon)
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
		Me.Name = "Form1"
		Me.cboPlanets.Size = New System.Drawing.Size(161, 21)
		Me.cboPlanets.Location = New System.Drawing.Point(240, 48)
		Me.cboPlanets.Items.AddRange(New Object(){"NA vals. of v/d", "Accurate vals. of v/d"})
		Me.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPlanets.TabIndex = 99
		Me.cboPlanets.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPlanets.BackColor = System.Drawing.SystemColors.Window
		Me.cboPlanets.CausesValidation = True
		Me.cboPlanets.Enabled = True
		Me.cboPlanets.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPlanets.IntegralHeight = True
		Me.cboPlanets.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPlanets.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPlanets.Sorted = False
		Me.cboPlanets.TabStop = True
		Me.cboPlanets.Visible = True
		Me.cboPlanets.Name = "cboPlanets"
		Me.chkAH.BackColor = System.Drawing.SystemColors.Window
		Me.chkAH.Text = "Use superimposed AH images"
		Me.chkAH.Size = New System.Drawing.Size(161, 25)
		Me.chkAH.Location = New System.Drawing.Point(240, 72)
		Me.chkAH.TabIndex = 98
		Me.chkAH.Visible = False
		Me.chkAH.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAH.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAH.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAH.CausesValidation = True
		Me.chkAH.Enabled = True
		Me.chkAH.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAH.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAH.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAH.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAH.TabStop = True
		Me.chkAH.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAH.Name = "chkAH"
		Me.cboStars.Size = New System.Drawing.Size(161, 21)
		Me.cboStars.Location = New System.Drawing.Point(240, 48)
		Me.cboStars.Items.AddRange(New Object(){"NA vals. of SHA/Dec", "Accurate vals. of SHA/Dec"})
		Me.cboStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStars.TabIndex = 97
		Me.cboStars.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStars.BackColor = System.Drawing.SystemColors.Window
		Me.cboStars.CausesValidation = True
		Me.cboStars.Enabled = True
		Me.cboStars.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStars.IntegralHeight = True
		Me.cboStars.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStars.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStars.Sorted = False
		Me.cboStars.TabStop = True
		Me.cboStars.Visible = True
		Me.cboStars.Name = "cboStars"
		Me.cboLo.Size = New System.Drawing.Size(41, 21)
		Me.cboLo.Location = New System.Drawing.Point(360, 120)
		Me.cboLo.Items.AddRange(New Object(){"W ", "E "})
		Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLo.TabIndex = 37
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
		Me.cboL.Size = New System.Drawing.Size(41, 21)
		Me.cboL.Location = New System.Drawing.Point(360, 96)
		Me.cboL.Items.AddRange(New Object(){"N ", "S "})
		Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboL.TabIndex = 31
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
		Me.cboSun.Size = New System.Drawing.Size(168, 21)
		Me.cboSun.Location = New System.Drawing.Point(237, 48)
		Me.cboSun.Items.AddRange(New Object(){"NA val. of hourly GHA/d", "Accurate val. of hourly GHA/d"})
		Me.cboSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSun.TabIndex = 96
		Me.cboSun.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboSun.BackColor = System.Drawing.SystemColors.Window
		Me.cboSun.CausesValidation = True
		Me.cboSun.Enabled = True
		Me.cboSun.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSun.IntegralHeight = True
		Me.cboSun.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSun.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSun.Sorted = False
		Me.cboSun.TabStop = True
		Me.cboSun.Visible = True
		Me.cboSun.Name = "cboSun"
		Me.cmdMerDiag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMerDiag.Text = "&Meridian Diagram"
		Me.cmdMerDiag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMerDiag.Size = New System.Drawing.Size(97, 25)
		Me.cmdMerDiag.Location = New System.Drawing.Point(568, 536)
		Me.cmdMerDiag.TabIndex = 95
		Me.cmdMerDiag.Visible = False
		Me.cmdMerDiag.BackColor = System.Drawing.SystemColors.Control
		Me.cmdMerDiag.CausesValidation = True
		Me.cmdMerDiag.Enabled = True
		Me.cmdMerDiag.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdMerDiag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMerDiag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdMerDiag.TabStop = True
		Me.cmdMerDiag.Name = "cmdMerDiag"
		Me.cmdEqT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEqT.Text = "EqT"
		Me.cmdEqT.Size = New System.Drawing.Size(33, 17)
		Me.cmdEqT.Location = New System.Drawing.Point(376, 348)
		Me.cmdEqT.TabIndex = 90
		Me.ToolTip1.SetToolTip(Me.cmdEqT, "Press and hold to see ""other"" sun and EqT")
		Me.cmdEqT.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEqT.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEqT.CausesValidation = True
		Me.cmdEqT.Enabled = True
		Me.cmdEqT.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEqT.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEqT.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEqT.TabStop = True
		Me.cmdEqT.Name = "cmdEqT"
		Me.chkDST.BackColor = System.Drawing.SystemColors.Window
		Me.chkDST.Text = "Check1"
		Me.chkDST.Size = New System.Drawing.Size(17, 17)
		Me.chkDST.Location = New System.Drawing.Point(136, 98)
		Me.chkDST.TabIndex = 88
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
		Me.txtIESec.AutoSize = False
		Me.txtIESec.Size = New System.Drawing.Size(33, 19)
		Me.txtIESec.Location = New System.Drawing.Point(528, 37)
		Me.txtIESec.Maxlength = 2
		Me.txtIESec.TabIndex = 54
		Me.ToolTip1.SetToolTip(Me.txtIESec, "Range 0 to 59")
		Me.txtIESec.Visible = False
		Me.txtIESec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIESec.AcceptsReturn = True
		Me.txtIESec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIESec.BackColor = System.Drawing.SystemColors.Window
		Me.txtIESec.CausesValidation = True
		Me.txtIESec.Enabled = True
		Me.txtIESec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIESec.HideSelection = True
		Me.txtIESec.ReadOnly = False
		Me.txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIESec.MultiLine = False
		Me.txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIESec.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIESec.TabStop = True
		Me.txtIESec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIESec.Name = "txtIESec"
		Me.optHoParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHoParameters.BackColor = System.Drawing.SystemColors.Window
		Me.optHoParameters.Text = "Parameters"
		Me.optHoParameters.Size = New System.Drawing.Size(81, 13)
		Me.optHoParameters.Location = New System.Drawing.Point(600, 155)
		Me.optHoParameters.TabIndex = 86
		Me.ToolTip1.SetToolTip(Me.optHoParameters, "Refraction, parallax, etc.")
		Me.optHoParameters.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHoParameters.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHoParameters.CausesValidation = True
		Me.optHoParameters.Enabled = True
		Me.optHoParameters.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHoParameters.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHoParameters.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHoParameters.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHoParameters.TabStop = True
		Me.optHoParameters.Checked = False
		Me.optHoParameters.Visible = True
		Me.optHoParameters.Name = "optHoParameters"
		Me.optHoSRForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHoSRForm.BackColor = System.Drawing.SystemColors.Window
		Me.optHoSRForm.Text = "SR Form"
		Me.optHoSRForm.Size = New System.Drawing.Size(65, 13)
		Me.optHoSRForm.Location = New System.Drawing.Point(536, 155)
		Me.optHoSRForm.TabIndex = 85
		Me.ToolTip1.SetToolTip(Me.optHoSRForm, "Main, Add'l, etc.")
		Me.optHoSRForm.Checked = True
		Me.optHoSRForm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHoSRForm.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHoSRForm.CausesValidation = True
		Me.optHoSRForm.Enabled = True
		Me.optHoSRForm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHoSRForm.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHoSRForm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHoSRForm.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHoSRForm.TabStop = True
		Me.optHoSRForm.Visible = True
		Me.optHoSRForm.Name = "optHoSRForm"
		Me.txtSightNo.AutoSize = False
		Me.txtSightNo.Size = New System.Drawing.Size(25, 19)
		Me.txtSightNo.Location = New System.Drawing.Point(304, 0)
		Me.txtSightNo.Maxlength = 2
		Me.txtSightNo.TabIndex = 24
		Me.ToolTip1.SetToolTip(Me.txtSightNo, "Range 0 to 99")
		Me.txtSightNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSightNo.AcceptsReturn = True
		Me.txtSightNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSightNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtSightNo.CausesValidation = True
		Me.txtSightNo.Enabled = True
		Me.txtSightNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSightNo.HideSelection = True
		Me.txtSightNo.ReadOnly = False
		Me.txtSightNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSightNo.MultiLine = False
		Me.txtSightNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSightNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSightNo.TabStop = True
		Me.txtSightNo.Visible = True
		Me.txtSightNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSightNo.Name = "txtSightNo"
		Me.cboDay.Size = New System.Drawing.Size(42, 21)
		Me.cboDay.Location = New System.Drawing.Point(63, 0)
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
		Me.cmdPrint.Location = New System.Drawing.Point(652, 0)
		Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
		Me.cmdPrint.TabIndex = 81
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
		Me.cmdFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFix.Text = "&Establish Fix"
		Me.cmdFix.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFix.Size = New System.Drawing.Size(81, 25)
		Me.cmdFix.Location = New System.Drawing.Point(392, 536)
		Me.cmdFix.TabIndex = 80
		Me.cmdFix.Visible = False
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
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.Location = New System.Drawing.Point(304, 536)
		Me.cmdSave.TabIndex = 79
		Me.cmdSave.Visible = False
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.txtIEdeg.AutoSize = False
		Me.txtIEdeg.Size = New System.Drawing.Size(17, 19)
		Me.txtIEdeg.Location = New System.Drawing.Point(464, 37)
		Me.txtIEdeg.Maxlength = 1
		Me.txtIEdeg.TabIndex = 51
		Me.ToolTip1.SetToolTip(Me.txtIEdeg, "Range 0 to 9; to right of index mark")
		Me.txtIEdeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIEdeg.AcceptsReturn = True
		Me.txtIEdeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIEdeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtIEdeg.CausesValidation = True
		Me.txtIEdeg.Enabled = True
		Me.txtIEdeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIEdeg.HideSelection = True
		Me.txtIEdeg.ReadOnly = False
		Me.txtIEdeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIEdeg.MultiLine = False
		Me.txtIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIEdeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIEdeg.TabStop = True
		Me.txtIEdeg.Visible = True
		Me.txtIEdeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIEdeg.Name = "txtIEdeg"
		Me.cboZDm.Size = New System.Drawing.Size(41, 21)
		Me.cboZDm.Location = New System.Drawing.Point(72, 96)
		Me.cboZDm.Items.AddRange(New Object(){"00", "30", "45"})
		Me.cboZDm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboZDm.TabIndex = 21
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
		Me.txtLDeg.AutoSize = False
		Me.txtLDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtLDeg.Location = New System.Drawing.Point(288, 96)
		Me.txtLDeg.Maxlength = 2
		Me.txtLDeg.TabIndex = 29
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
		Me.cboPolaris.Size = New System.Drawing.Size(161, 21)
		Me.cboPolaris.Location = New System.Drawing.Point(240, 48)
		Me.cboPolaris.Items.AddRange(New Object(){"Latitude by altitude of Polaris", "Full reduction of Polaris sight"})
		Me.cboPolaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPolaris.TabIndex = 27
		Me.cboPolaris.Visible = False
		Me.cboPolaris.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPolaris.BackColor = System.Drawing.SystemColors.Window
		Me.cboPolaris.CausesValidation = True
		Me.cboPolaris.Enabled = True
		Me.cboPolaris.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPolaris.IntegralHeight = True
		Me.cboPolaris.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPolaris.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPolaris.Sorted = False
		Me.cboPolaris.TabStop = True
		Me.cboPolaris.Name = "cboPolaris"
		Me.cboDsUnit.Size = New System.Drawing.Size(89, 21)
		Me.cboDsUnit.Location = New System.Drawing.Point(528, 94)
		Me.cboDsUnit.Items.AddRange(New Object(){"feet", "yards", "meters", "statute miles", "nautical miles"})
		Me.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDsUnit.TabIndex = 66
		Me.cboDsUnit.Visible = False
		Me.cboDsUnit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDsUnit.BackColor = System.Drawing.SystemColors.Window
		Me.cboDsUnit.CausesValidation = True
		Me.cboDsUnit.Enabled = True
		Me.cboDsUnit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDsUnit.IntegralHeight = True
		Me.cboDsUnit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDsUnit.Sorted = False
		Me.cboDsUnit.TabStop = True
		Me.cboDsUnit.Name = "cboDsUnit"
		Me.txtDsDist.AutoSize = False
		Me.txtDsDist.Size = New System.Drawing.Size(41, 19)
		Me.txtDsDist.Location = New System.Drawing.Point(480, 94)
		Me.txtDsDist.Maxlength = 5
		Me.txtDsDist.TabIndex = 65
		Me.ToolTip1.SetToolTip(Me.txtDsDist, "Limited to five characters")
		Me.txtDsDist.Visible = False
		Me.txtDsDist.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDsDist.AcceptsReturn = True
		Me.txtDsDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDsDist.BackColor = System.Drawing.SystemColors.Window
		Me.txtDsDist.CausesValidation = True
		Me.txtDsDist.Enabled = True
		Me.txtDsDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDsDist.HideSelection = True
		Me.txtDsDist.ReadOnly = False
		Me.txtDsDist.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDsDist.MultiLine = False
		Me.txtDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDsDist.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDsDist.TabStop = True
		Me.txtDsDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDsDist.Name = "txtDsDist"
		Me.FrameHorizon.BackColor = System.Drawing.SystemColors.Window
		Me.FrameHorizon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrameHorizon.Text = "Frame4"
		Me.FrameHorizon.Size = New System.Drawing.Size(209, 14)
		Me.FrameHorizon.Location = New System.Drawing.Point(464, 56)
		Me.FrameHorizon.TabIndex = 78
		Me.FrameHorizon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameHorizon.Enabled = True
		Me.FrameHorizon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameHorizon.Cursor = System.Windows.Forms.Cursors.Default
		Me.FrameHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameHorizon.Visible = True
		Me.FrameHorizon.Name = "FrameHorizon"
		Me.optHorizonDipShort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonDipShort.BackColor = System.Drawing.SystemColors.Window
		Me.optHorizonDipShort.Text = "Dip Short"
		Me.optHorizonDipShort.Size = New System.Drawing.Size(65, 13)
		Me.optHorizonDipShort.Location = New System.Drawing.Point(140, 0)
		Me.optHorizonDipShort.TabIndex = 60
		Me.optHorizonDipShort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonDipShort.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonDipShort.CausesValidation = True
		Me.optHorizonDipShort.Enabled = True
		Me.optHorizonDipShort.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHorizonDipShort.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHorizonDipShort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHorizonDipShort.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHorizonDipShort.TabStop = True
		Me.optHorizonDipShort.Checked = False
		Me.optHorizonDipShort.Visible = True
		Me.optHorizonDipShort.Name = "optHorizonDipShort"
		Me.optHorizonArtificial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonArtificial.BackColor = System.Drawing.SystemColors.Window
		Me.optHorizonArtificial.Text = "Artificial"
		Me.optHorizonArtificial.Size = New System.Drawing.Size(59, 13)
		Me.optHorizonArtificial.Location = New System.Drawing.Point(72, 0)
		Me.optHorizonArtificial.TabIndex = 59
		Me.optHorizonArtificial.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonArtificial.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonArtificial.CausesValidation = True
		Me.optHorizonArtificial.Enabled = True
		Me.optHorizonArtificial.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHorizonArtificial.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHorizonArtificial.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHorizonArtificial.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHorizonArtificial.TabStop = True
		Me.optHorizonArtificial.Checked = False
		Me.optHorizonArtificial.Visible = True
		Me.optHorizonArtificial.Name = "optHorizonArtificial"
		Me.optHorizonNatural.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonNatural.BackColor = System.Drawing.SystemColors.Window
		Me.optHorizonNatural.Text = "Natural"
		Me.optHorizonNatural.Size = New System.Drawing.Size(65, 13)
		Me.optHorizonNatural.Location = New System.Drawing.Point(8, 0)
		Me.optHorizonNatural.TabIndex = 58
		Me.optHorizonNatural.Checked = True
		Me.optHorizonNatural.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonNatural.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonNatural.CausesValidation = True
		Me.optHorizonNatural.Enabled = True
		Me.optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHorizonNatural.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHorizonNatural.TabStop = True
		Me.optHorizonNatural.Visible = True
		Me.optHorizonNatural.Name = "optHorizonNatural"
		Me.Framehs.BackColor = System.Drawing.SystemColors.Window
		Me.Framehs.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Framehs.Text = "Frame2"
		Me.Framehs.Size = New System.Drawing.Size(153, 20)
		Me.Framehs.Location = New System.Drawing.Point(488, -8)
		Me.Framehs.TabIndex = 77
		Me.Framehs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Framehs.Enabled = True
		Me.Framehs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Framehs.Cursor = System.Windows.Forms.Cursors.Default
		Me.Framehs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Framehs.Visible = True
		Me.Framehs.Name = "Framehs"
		Me.optHsDMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHsDMS.BackColor = System.Drawing.SystemColors.Window
		Me.optHsDMS.Text = "DMS"
		Me.optHsDMS.Size = New System.Drawing.Size(49, 13)
		Me.optHsDMS.Location = New System.Drawing.Point(64, 8)
		Me.optHsDMS.TabIndex = 42
		Me.optHsDMS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHsDMS.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHsDMS.CausesValidation = True
		Me.optHsDMS.Enabled = True
		Me.optHsDMS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHsDMS.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHsDMS.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHsDMS.TabStop = True
		Me.optHsDMS.Checked = False
		Me.optHsDMS.Visible = True
		Me.optHsDMS.Name = "optHsDMS"
		Me.optHsDMm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHsDMm.BackColor = System.Drawing.SystemColors.Window
		Me.optHsDMm.Text = "DM.m"
		Me.optHsDMm.Size = New System.Drawing.Size(49, 13)
		Me.optHsDMm.Location = New System.Drawing.Point(0, 8)
		Me.optHsDMm.TabIndex = 41
		Me.optHsDMm.Checked = True
		Me.optHsDMm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHsDMm.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHsDMm.CausesValidation = True
		Me.optHsDMm.Enabled = True
		Me.optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHsDMm.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHsDMm.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHsDMm.TabStop = True
		Me.optHsDMm.Visible = True
		Me.optHsDMm.Name = "optHsDMm"
		Me.FrameZD.BackColor = System.Drawing.SystemColors.Window
		Me.FrameZD.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrameZD.Size = New System.Drawing.Size(185, 25)
		Me.FrameZD.Location = New System.Drawing.Point(32, 72)
		Me.FrameZD.TabIndex = 76
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
		Me.optZDUT.Location = New System.Drawing.Point(110, 8)
		Me.optZDUT.TabIndex = 100
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
		Me.optZDManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDManual.BackColor = System.Drawing.SystemColors.Window
		Me.optZDManual.Text = "Manual"
		Me.optZDManual.Size = New System.Drawing.Size(57, 13)
		Me.optZDManual.Location = New System.Drawing.Point(48, 8)
		Me.optZDManual.TabIndex = 17
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
		Me.optZDAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optZDAuto.BackColor = System.Drawing.SystemColors.Window
		Me.optZDAuto.Text = "Auto"
		Me.optZDAuto.Size = New System.Drawing.Size(49, 13)
		Me.optZDAuto.Location = New System.Drawing.Point(0, 8)
		Me.optZDAuto.TabIndex = 16
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
		Me.cmdReduce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReduce.Text = "&Reduce Sight"
		Me.cmdReduce.Size = New System.Drawing.Size(161, 25)
		Me.cmdReduce.Location = New System.Drawing.Point(240, 140)
		Me.cmdReduce.TabIndex = 75
		Me.cmdReduce.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReduce.BackColor = System.Drawing.SystemColors.Control
		Me.cmdReduce.CausesValidation = True
		Me.cmdReduce.Enabled = True
		Me.cmdReduce.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdReduce.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReduce.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdReduce.TabStop = True
		Me.cmdReduce.Name = "cmdReduce"
		Me.cboPressure.Size = New System.Drawing.Size(57, 21)
		Me.cboPressure.Location = New System.Drawing.Point(608, 134)
		Me.cboPressure.Items.AddRange(New Object(){"in Hg", "mbar"})
		Me.cboPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPressure.TabIndex = 74
		Me.cboPressure.Visible = False
		Me.cboPressure.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPressure.BackColor = System.Drawing.SystemColors.Window
		Me.cboPressure.CausesValidation = True
		Me.cboPressure.Enabled = True
		Me.cboPressure.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPressure.IntegralHeight = True
		Me.cboPressure.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPressure.Sorted = False
		Me.cboPressure.TabStop = True
		Me.cboPressure.Name = "cboPressure"
		Me.txtPressure.AutoSize = False
		Me.txtPressure.Size = New System.Drawing.Size(41, 19)
		Me.txtPressure.Location = New System.Drawing.Point(560, 134)
		Me.txtPressure.Maxlength = 5
		Me.txtPressure.TabIndex = 73
		Me.txtPressure.Text = "29.83"
		Me.ToolTip1.SetToolTip(Me.txtPressure, "Range 28 to 32 (in Hg) or 950 to 1100 (mb)")
		Me.txtPressure.Visible = False
		Me.txtPressure.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPressure.AcceptsReturn = True
		Me.txtPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPressure.BackColor = System.Drawing.SystemColors.Window
		Me.txtPressure.CausesValidation = True
		Me.txtPressure.Enabled = True
		Me.txtPressure.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPressure.HideSelection = True
		Me.txtPressure.ReadOnly = False
		Me.txtPressure.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPressure.MultiLine = False
		Me.txtPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPressure.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPressure.TabStop = True
		Me.txtPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPressure.Name = "txtPressure"
		Me.cboTemperature.Size = New System.Drawing.Size(33, 21)
		Me.cboTemperature.Location = New System.Drawing.Point(488, 134)
		Me.cboTemperature.Items.AddRange(New Object(){"F ", "C "})
		Me.cboTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTemperature.TabIndex = 71
		Me.cboTemperature.Visible = False
		Me.cboTemperature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTemperature.BackColor = System.Drawing.SystemColors.Window
		Me.cboTemperature.CausesValidation = True
		Me.cboTemperature.Enabled = True
		Me.cboTemperature.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTemperature.IntegralHeight = True
		Me.cboTemperature.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTemperature.Sorted = False
		Me.cboTemperature.TabStop = True
		Me.cboTemperature.Name = "cboTemperature"
		Me.txtTemperature.AutoSize = False
		Me.txtTemperature.Size = New System.Drawing.Size(33, 19)
		Me.txtTemperature.Location = New System.Drawing.Point(448, 134)
		Me.txtTemperature.Maxlength = 4
		Me.txtTemperature.TabIndex = 69
		Me.txtTemperature.Text = "50"
		Me.ToolTip1.SetToolTip(Me.txtTemperature, "Range -40 to 130 (F) or -40 to 55 (C)")
		Me.txtTemperature.Visible = False
		Me.txtTemperature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTemperature.AcceptsReturn = True
		Me.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTemperature.BackColor = System.Drawing.SystemColors.Window
		Me.txtTemperature.CausesValidation = True
		Me.txtTemperature.Enabled = True
		Me.txtTemperature.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTemperature.HideSelection = True
		Me.txtTemperature.ReadOnly = False
		Me.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTemperature.MultiLine = False
		Me.txtTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTemperature.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTemperature.TabStop = True
		Me.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTemperature.Name = "txtTemperature"
		Me.cboIE.Size = New System.Drawing.Size(105, 21)
		Me.cboIE.Location = New System.Drawing.Point(568, 37)
		Me.cboIE.Items.AddRange(New Object(){"on the arc", "off the arc (val.)", "off the arc (rdg.)"})
		Me.cboIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboIE.TabIndex = 56
		Me.cboIE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboIE.BackColor = System.Drawing.SystemColors.Window
		Me.cboIE.CausesValidation = True
		Me.cboIE.Enabled = True
		Me.cboIE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboIE.IntegralHeight = True
		Me.cboIE.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboIE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboIE.Sorted = False
		Me.cboIE.TabStop = True
		Me.cboIE.Visible = True
		Me.cboIE.Name = "cboIE"
		Me.txtIEmin.AutoSize = False
		Me.txtIEmin.Size = New System.Drawing.Size(33, 19)
		Me.txtIEmin.Location = New System.Drawing.Point(488, 37)
		Me.txtIEmin.Maxlength = 4
		Me.txtIEmin.TabIndex = 53
		Me.ToolTip1.SetToolTip(Me.txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
		Me.txtIEmin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIEmin.AcceptsReturn = True
		Me.txtIEmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIEmin.BackColor = System.Drawing.SystemColors.Window
		Me.txtIEmin.CausesValidation = True
		Me.txtIEmin.Enabled = True
		Me.txtIEmin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIEmin.HideSelection = True
		Me.txtIEmin.ReadOnly = False
		Me.txtIEmin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIEmin.MultiLine = False
		Me.txtIEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIEmin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIEmin.TabStop = True
		Me.txtIEmin.Visible = True
		Me.txtIEmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIEmin.Name = "txtIEmin"
		Me.cboHE.Size = New System.Drawing.Size(41, 21)
		Me.cboHE.Location = New System.Drawing.Point(488, 72)
		Me.cboHE.Items.AddRange(New Object(){"ft", "in", "m ", "cm"})
		Me.cboHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboHE.TabIndex = 63
		Me.cboHE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboHE.BackColor = System.Drawing.SystemColors.Window
		Me.cboHE.CausesValidation = True
		Me.cboHE.Enabled = True
		Me.cboHE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboHE.IntegralHeight = True
		Me.cboHE.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboHE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboHE.Sorted = False
		Me.cboHE.TabStop = True
		Me.cboHE.Visible = True
		Me.cboHE.Name = "cboHE"
		Me.txtHE.AutoSize = False
		Me.txtHE.Size = New System.Drawing.Size(33, 19)
		Me.txtHE.Location = New System.Drawing.Point(440, 72)
		Me.txtHE.Maxlength = 4
		Me.txtHE.TabIndex = 62
		Me.ToolTip1.SetToolTip(Me.txtHE, "Max. 4 characters")
		Me.txtHE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHE.AcceptsReturn = True
		Me.txtHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHE.BackColor = System.Drawing.SystemColors.Window
		Me.txtHE.CausesValidation = True
		Me.txtHE.Enabled = True
		Me.txtHE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHE.HideSelection = True
		Me.txtHE.ReadOnly = False
		Me.txtHE.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHE.MultiLine = False
		Me.txtHE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHE.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHE.TabStop = True
		Me.txtHE.Visible = True
		Me.txtHE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHE.Name = "txtHE"
		Me.txtHsSec.AutoSize = False
		Me.txtHsSec.Size = New System.Drawing.Size(33, 19)
		Me.txtHsSec.Location = New System.Drawing.Point(528, 15)
		Me.txtHsSec.Maxlength = 2
		Me.txtHsSec.TabIndex = 48
		Me.ToolTip1.SetToolTip(Me.txtHsSec, "Range 0 to 59")
		Me.txtHsSec.Visible = False
		Me.txtHsSec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHsSec.AcceptsReturn = True
		Me.txtHsSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
		Me.txtHsSec.CausesValidation = True
		Me.txtHsSec.Enabled = True
		Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHsSec.HideSelection = True
		Me.txtHsSec.ReadOnly = False
		Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHsSec.MultiLine = False
		Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHsSec.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHsSec.TabStop = True
		Me.txtHsSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHsSec.Name = "txtHsSec"
		Me.txtHsMin.AutoSize = False
		Me.txtHsMin.Size = New System.Drawing.Size(33, 19)
		Me.txtHsMin.Location = New System.Drawing.Point(488, 15)
		Me.txtHsMin.Maxlength = 4
		Me.txtHsMin.TabIndex = 46
		Me.ToolTip1.SetToolTip(Me.txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
		Me.txtHsMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHsMin.AcceptsReturn = True
		Me.txtHsMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHsMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtHsMin.CausesValidation = True
		Me.txtHsMin.Enabled = True
		Me.txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHsMin.HideSelection = True
		Me.txtHsMin.ReadOnly = False
		Me.txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHsMin.MultiLine = False
		Me.txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHsMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHsMin.TabStop = True
		Me.txtHsMin.Visible = True
		Me.txtHsMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHsMin.Name = "txtHsMin"
		Me.txtHsDeg.AutoSize = False
		Me.txtHsDeg.Size = New System.Drawing.Size(33, 19)
		Me.txtHsDeg.Location = New System.Drawing.Point(448, 15)
		Me.txtHsDeg.Maxlength = 3
		Me.txtHsDeg.TabIndex = 44
		Me.ToolTip1.SetToolTip(Me.txtHsDeg, "Range 0 to 145")
		Me.txtHsDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHsDeg.AcceptsReturn = True
		Me.txtHsDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHsDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtHsDeg.CausesValidation = True
		Me.txtHsDeg.Enabled = True
		Me.txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHsDeg.HideSelection = True
		Me.txtHsDeg.ReadOnly = False
		Me.txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHsDeg.MultiLine = False
		Me.txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHsDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHsDeg.TabStop = True
		Me.txtHsDeg.Visible = True
		Me.txtHsDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHsDeg.Name = "txtHsDeg"
		Me.txtLoMin.AutoSize = False
		Me.txtLoMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLoMin.Location = New System.Drawing.Point(320, 120)
		Me.txtLoMin.Maxlength = 4
		Me.txtLoMin.TabIndex = 36
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
		Me.txtLoDeg.Location = New System.Drawing.Point(280, 120)
		Me.txtLoDeg.Maxlength = 3
		Me.txtLoDeg.TabIndex = 35
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
		Me.txtLMin.AutoSize = False
		Me.txtLMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLMin.Location = New System.Drawing.Point(320, 96)
		Me.txtLMin.Maxlength = 4
		Me.txtLMin.TabIndex = 30
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
		Me.cboBody.Size = New System.Drawing.Size(97, 21)
		Me.cboBody.Location = New System.Drawing.Point(304, 24)
		Me.cboBody.Items.AddRange(New Object(){"Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Jupiter", "Kaus Australis", "Kochab", "Markab", "Mars", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Moon L.L.", "Moon U.L.", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Saturn", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Sun L.L.", "Sun U.L.", "Vega", "Venus", "Zubenelgenubi"})
		Me.cboBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBody.TabIndex = 26
		Me.cboBody.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBody.BackColor = System.Drawing.SystemColors.Window
		Me.cboBody.CausesValidation = True
		Me.cboBody.Enabled = True
		Me.cboBody.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboBody.IntegralHeight = True
		Me.cboBody.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboBody.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboBody.Sorted = False
		Me.cboBody.TabStop = True
		Me.cboBody.Visible = True
		Me.cboBody.Name = "cboBody"
		Me.txtZDh.AutoSize = False
		Me.txtZDh.Enabled = False
		Me.txtZDh.Size = New System.Drawing.Size(25, 19)
		Me.txtZDh.Location = New System.Drawing.Point(32, 96)
		Me.txtZDh.Maxlength = 3
		Me.txtZDh.TabIndex = 19
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
		Me.cboWE.Size = New System.Drawing.Size(49, 21)
		Me.cboWE.Location = New System.Drawing.Point(144, 48)
		Me.cboWE.Items.AddRange(New Object(){"fast", "slow"})
		Me.cboWE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboWE.TabIndex = 14
		Me.cboWE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWE.BackColor = System.Drawing.SystemColors.Window
		Me.cboWE.CausesValidation = True
		Me.cboWE.Enabled = True
		Me.cboWE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWE.IntegralHeight = True
		Me.cboWE.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWE.Sorted = False
		Me.cboWE.TabStop = True
		Me.cboWE.Visible = True
		Me.cboWE.Name = "cboWE"
		Me.txtWESec.AutoSize = False
		Me.txtWESec.Size = New System.Drawing.Size(25, 19)
		Me.txtWESec.Location = New System.Drawing.Point(88, 48)
		Me.txtWESec.Maxlength = 2
		Me.txtWESec.TabIndex = 12
		Me.ToolTip1.SetToolTip(Me.txtWESec, "Range 0 to 59")
		Me.txtWESec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWESec.AcceptsReturn = True
		Me.txtWESec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWESec.BackColor = System.Drawing.SystemColors.Window
		Me.txtWESec.CausesValidation = True
		Me.txtWESec.Enabled = True
		Me.txtWESec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWESec.HideSelection = True
		Me.txtWESec.ReadOnly = False
		Me.txtWESec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWESec.MultiLine = False
		Me.txtWESec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWESec.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWESec.TabStop = True
		Me.txtWESec.Visible = True
		Me.txtWESec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWESec.Name = "txtWESec"
		Me.txtWEMin.AutoSize = False
		Me.txtWEMin.Size = New System.Drawing.Size(17, 19)
		Me.txtWEMin.Location = New System.Drawing.Point(40, 48)
		Me.txtWEMin.Maxlength = 1
		Me.txtWEMin.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.txtWEMin, "Range 0 to 9")
		Me.txtWEMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWEMin.AcceptsReturn = True
		Me.txtWEMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWEMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtWEMin.CausesValidation = True
		Me.txtWEMin.Enabled = True
		Me.txtWEMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWEMin.HideSelection = True
		Me.txtWEMin.ReadOnly = False
		Me.txtWEMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWEMin.MultiLine = False
		Me.txtWEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWEMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWEMin.TabStop = True
		Me.txtWEMin.Visible = True
		Me.txtWEMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWEMin.Name = "txtWEMin"
		Me.txtTime.AutoSize = False
		Me.txtTime.Size = New System.Drawing.Size(49, 19)
		Me.txtTime.Location = New System.Drawing.Point(88, 24)
		Me.txtTime.Maxlength = 6
		Me.txtTime.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.txtTime, "Range 000000 to 235959")
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
		Me.txtYear.AutoSize = False
		Me.txtYear.Size = New System.Drawing.Size(33, 19)
		Me.txtYear.Location = New System.Drawing.Point(194, 2)
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
		Me.cboMonth.Location = New System.Drawing.Point(128, 0)
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
		Me.FrameTP.BackColor = System.Drawing.SystemColors.Window
		Me.FrameTP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrameTP.Size = New System.Drawing.Size(89, 13)
		Me.FrameTP.Location = New System.Drawing.Point(528, 117)
		Me.FrameTP.TabIndex = 91
		Me.FrameTP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameTP.Enabled = True
		Me.FrameTP.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameTP.Cursor = System.Windows.Forms.Cursors.Default
		Me.FrameTP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameTP.Visible = True
		Me.FrameTP.Name = "FrameTP"
		Me.optStdTPNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStdTPNo.BackColor = System.Drawing.SystemColors.Window
		Me.optStdTPNo.Text = "No"
		Me.optStdTPNo.Size = New System.Drawing.Size(41, 13)
		Me.optStdTPNo.Location = New System.Drawing.Point(48, 0)
		Me.optStdTPNo.TabIndex = 94
		Me.optStdTPNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optStdTPNo.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStdTPNo.CausesValidation = True
		Me.optStdTPNo.Enabled = True
		Me.optStdTPNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optStdTPNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.optStdTPNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optStdTPNo.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optStdTPNo.TabStop = True
		Me.optStdTPNo.Checked = False
		Me.optStdTPNo.Visible = True
		Me.optStdTPNo.Name = "optStdTPNo"
		Me.optStdTPYes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStdTPYes.BackColor = System.Drawing.SystemColors.Window
		Me.optStdTPYes.Text = "Yes"
		Me.optStdTPYes.Size = New System.Drawing.Size(41, 13)
		Me.optStdTPYes.Location = New System.Drawing.Point(0, 0)
		Me.optStdTPYes.TabIndex = 93
		Me.optStdTPYes.Checked = True
		Me.optStdTPYes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optStdTPYes.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optStdTPYes.CausesValidation = True
		Me.optStdTPYes.Enabled = True
		Me.optStdTPYes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optStdTPYes.Cursor = System.Windows.Forms.Cursors.Default
		Me.optStdTPYes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optStdTPYes.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optStdTPYes.TabStop = True
		Me.optStdTPYes.Visible = True
		Me.optStdTPYes.Name = "optStdTPYes"
		Me.FrameHo.BackColor = System.Drawing.SystemColors.Window
		Me.FrameHo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrameHo.Size = New System.Drawing.Size(137, 16)
		Me.FrameHo.Location = New System.Drawing.Point(536, 152)
		Me.FrameHo.TabIndex = 92
		Me.FrameHo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameHo.Enabled = True
		Me.FrameHo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameHo.Cursor = System.Windows.Forms.Cursors.Default
		Me.FrameHo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameHo.Visible = True
		Me.FrameHo.Name = "FrameHo"
		Me.lblZDDST.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDDST.Text = "DST"
		Me.lblZDDST.Size = New System.Drawing.Size(33, 13)
		Me.lblZDDST.Location = New System.Drawing.Point(153, 99)
		Me.lblZDDST.TabIndex = 89
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
		Me.lblIEsec.BackColor = System.Drawing.SystemColors.Window
		Me.lblIEsec.Text = """"
		Me.lblIEsec.Size = New System.Drawing.Size(9, 17)
		Me.lblIEsec.Location = New System.Drawing.Point(561, 37)
		Me.lblIEsec.TabIndex = 87
		Me.lblIEsec.Visible = False
		Me.lblIEsec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIEsec.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblIEsec.Enabled = True
		Me.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblIEsec.UseMnemonic = True
		Me.lblIEsec.AutoSize = False
		Me.lblIEsec.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblIEsec.Name = "lblIEsec"
		Me.lblHoCorrs.BackColor = System.Drawing.SystemColors.Window
		Me.lblHoCorrs.Text = "Show Ho corrections as"
		Me.lblHoCorrs.Size = New System.Drawing.Size(113, 13)
		Me.lblHoCorrs.Location = New System.Drawing.Point(416, 154)
		Me.lblHoCorrs.TabIndex = 84
		Me.lblHoCorrs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHoCorrs.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHoCorrs.Enabled = True
		Me.lblHoCorrs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHoCorrs.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHoCorrs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHoCorrs.UseMnemonic = True
		Me.lblHoCorrs.Visible = True
		Me.lblHoCorrs.AutoSize = False
		Me.lblHoCorrs.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHoCorrs.Name = "lblHoCorrs"
		Me.lblSightNo.BackColor = System.Drawing.SystemColors.Window
		Me.lblSightNo.Text = "Sight No."
		Me.lblSightNo.Size = New System.Drawing.Size(49, 17)
		Me.lblSightNo.Location = New System.Drawing.Point(240, 3)
		Me.lblSightNo.TabIndex = 23
		Me.lblSightNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSightNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSightNo.Enabled = True
		Me.lblSightNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSightNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSightNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSightNo.UseMnemonic = True
		Me.lblSightNo.Visible = True
		Me.lblSightNo.AutoSize = False
		Me.lblSightNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSightNo.Name = "lblSightNo"
		Me.Line4.X1 = 232
		Me.Line4.X2 = 232
		Me.Line4.Y1 = 169
		Me.Line4.Y2 = 431
		Me.Line4.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line4.BorderWidth = 1
		Me.Line4.Visible = True
		Me.Line4.Name = "Line4"
		Me.Line5.X1 = 408
		Me.Line5.X2 = 408
		Me.Line5.Y1 = 169
		Me.Line5.Y2 = 431
		Me.Line5.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line5.BorderWidth = 1
		Me.Line5.Visible = True
		Me.Line5.Name = "Line5"
		Me.lblSmallm.Text = "m"
		Me.lblSmallm.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSmallm.Size = New System.Drawing.Size(9, 11)
		Me.lblSmallm.Location = New System.Drawing.Point(317, 352)
		Me.lblSmallm.TabIndex = 83
		Me.lblSmallm.Visible = False
		Me.lblSmallm.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSmallm.BackColor = System.Drawing.Color.Transparent
		Me.lblSmallm.Enabled = True
		Me.lblSmallm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSmallm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSmallm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSmallm.UseMnemonic = True
		Me.lblSmallm.AutoSize = False
		Me.lblSmallm.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSmallm.Name = "lblSmallm"
		Me.lblM.Text = "M"
		Me.lblM.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblM.Size = New System.Drawing.Size(9, 11)
		Me.lblM.Location = New System.Drawing.Point(317, 236)
		Me.lblM.TabIndex = 82
		Me.lblM.Visible = False
		Me.lblM.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblM.BackColor = System.Drawing.Color.Transparent
		Me.lblM.Enabled = True
		Me.lblM.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblM.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblM.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblM.UseMnemonic = True
		Me.lblM.AutoSize = False
		Me.lblM.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblM.Name = "lblM"
		Me.Line2.X1 = 408
		Me.Line2.X2 = 408
		Me.Line2.Y1 = 164
		Me.Line2.Y2 = 0
		Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line2.BorderWidth = 1
		Me.Line2.Visible = True
		Me.Line2.Name = "Line2"
		Me.Line1.X1 = 232
		Me.Line1.X2 = 232
		Me.Line1.Y1 = 164
		Me.Line1.Y2 = 0
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.BorderWidth = 1
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Line14.X1 = 232
		Me.Line14.X2 = 408
		Me.Line14.Y1 = 365
		Me.Line14.Y2 = 365
		Me.Line14.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line14.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line14.BorderWidth = 1
		Me.Line14.Visible = True
		Me.Line14.Name = "Line14"
		Me.Line8.X1 = 232
		Me.Line8.X2 = 408
		Me.Line8.Y1 = 237
		Me.Line8.Y2 = 237
		Me.Line8.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line8.BorderWidth = 1
		Me.Line8.Visible = True
		Me.Line8.Name = "Line8"
		Me.Line7.X1 = 232
		Me.Line7.X2 = 0
		Me.Line7.Y1 = 280
		Me.Line7.Y2 = 280
		Me.Line7.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line7.BorderWidth = 1
		Me.Line7.Visible = True
		Me.Line7.Name = "Line7"
		Me.Line6.X1 = 0
		Me.Line6.X2 = 672
		Me.Line6.Y1 = 431
		Me.Line6.Y2 = 431
		Me.Line6.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line6.BorderWidth = 1
		Me.Line6.Visible = True
		Me.Line6.Name = "Line6"
		Me.Line3.BorderWidth = 2
		Me.Line3.X1 = 0
		Me.Line3.X2 = 680
		Me.Line3.Y1 = 169
		Me.Line3.Y2 = 169
		Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line3.Visible = True
		Me.Line3.Name = "Line3"
		Me.lblIEdeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblIEdeg.Text = "°"
		Me.lblIEdeg.Size = New System.Drawing.Size(9, 17)
		Me.lblIEdeg.Location = New System.Drawing.Point(481, 37)
		Me.lblIEdeg.TabIndex = 52
		Me.lblIEdeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIEdeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblIEdeg.Enabled = True
		Me.lblIEdeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblIEdeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblIEdeg.UseMnemonic = True
		Me.lblIEdeg.Visible = True
		Me.lblIEdeg.AutoSize = False
		Me.lblIEdeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblIEdeg.Name = "lblIEdeg"
		Me.lblZDm.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDm.Text = "m"
		Me.lblZDm.Size = New System.Drawing.Size(9, 17)
		Me.lblZDm.Location = New System.Drawing.Point(113, 99)
		Me.lblZDm.TabIndex = 22
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
		Me.lblZDh.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDh.Text = "h"
		Me.lblZDh.Size = New System.Drawing.Size(9, 17)
		Me.lblZDh.Location = New System.Drawing.Point(57, 99)
		Me.lblZDh.TabIndex = 20
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
		Me.lblDsDist.BackColor = System.Drawing.SystemColors.Window
		Me.lblDsDist.Text = "Ds distance"
		Me.lblDsDist.Size = New System.Drawing.Size(57, 17)
		Me.lblDsDist.Location = New System.Drawing.Point(416, 97)
		Me.lblDsDist.TabIndex = 64
		Me.ToolTip1.SetToolTip(Me.lblDsDist, "Distance to dip short horizon")
		Me.lblDsDist.Visible = False
		Me.lblDsDist.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDsDist.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDsDist.Enabled = True
		Me.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDsDist.UseMnemonic = True
		Me.lblDsDist.AutoSize = False
		Me.lblDsDist.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDsDist.Name = "lblDsDist"
		Me.lblHorizon.BackColor = System.Drawing.SystemColors.Window
		Me.lblHorizon.Text = "Horizon"
		Me.lblHorizon.Size = New System.Drawing.Size(49, 17)
		Me.lblHorizon.Location = New System.Drawing.Point(416, 56)
		Me.lblHorizon.TabIndex = 57
		Me.lblHorizon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHorizon.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHorizon.Enabled = True
		Me.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHorizon.UseMnemonic = True
		Me.lblHorizon.Visible = True
		Me.lblHorizon.AutoSize = False
		Me.lblHorizon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHorizon.Name = "lblHorizon"
		Me.lblPressure.BackColor = System.Drawing.SystemColors.Window
		Me.lblPressure.Text = "Press."
		Me.lblPressure.Size = New System.Drawing.Size(33, 17)
		Me.lblPressure.Location = New System.Drawing.Point(528, 134)
		Me.lblPressure.TabIndex = 72
		Me.lblPressure.Visible = False
		Me.lblPressure.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPressure.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPressure.Enabled = True
		Me.lblPressure.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPressure.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPressure.UseMnemonic = True
		Me.lblPressure.AutoSize = False
		Me.lblPressure.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPressure.Name = "lblPressure"
		Me.lblTempDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblTempDeg.Text = "°"
		Me.lblTempDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblTempDeg.Location = New System.Drawing.Point(481, 134)
		Me.lblTempDeg.TabIndex = 70
		Me.lblTempDeg.Visible = False
		Me.lblTempDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTempDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTempDeg.Enabled = True
		Me.lblTempDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTempDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTempDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTempDeg.UseMnemonic = True
		Me.lblTempDeg.AutoSize = False
		Me.lblTempDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTempDeg.Name = "lblTempDeg"
		Me.lblTemperature.BackColor = System.Drawing.SystemColors.Window
		Me.lblTemperature.Text = "Temp."
		Me.lblTemperature.Size = New System.Drawing.Size(33, 17)
		Me.lblTemperature.Location = New System.Drawing.Point(416, 134)
		Me.lblTemperature.TabIndex = 68
		Me.lblTemperature.Visible = False
		Me.lblTemperature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTemperature.Enabled = True
		Me.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTemperature.UseMnemonic = True
		Me.lblTemperature.AutoSize = False
		Me.lblTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTemperature.Name = "lblTemperature"
		Me.lblStdT_P.BackColor = System.Drawing.SystemColors.Window
		Me.lblStdT_P.Text = "Std. temp. and press."
		Me.lblStdT_P.Size = New System.Drawing.Size(105, 17)
		Me.lblStdT_P.Location = New System.Drawing.Point(416, 115)
		Me.lblStdT_P.TabIndex = 67
		Me.lblStdT_P.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStdT_P.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStdT_P.Enabled = True
		Me.lblStdT_P.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStdT_P.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStdT_P.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStdT_P.UseMnemonic = True
		Me.lblStdT_P.Visible = True
		Me.lblStdT_P.AutoSize = False
		Me.lblStdT_P.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStdT_P.Name = "lblStdT_P"
		Me.lblIEMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblIEMin.Text = "'"
		Me.lblIEMin.Size = New System.Drawing.Size(9, 17)
		Me.lblIEMin.Location = New System.Drawing.Point(521, 37)
		Me.lblIEMin.TabIndex = 55
		Me.lblIEMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIEMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblIEMin.Enabled = True
		Me.lblIEMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblIEMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblIEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblIEMin.UseMnemonic = True
		Me.lblIEMin.Visible = True
		Me.lblIEMin.AutoSize = False
		Me.lblIEMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblIEMin.Name = "lblIEMin"
		Me.lblIE.BackColor = System.Drawing.SystemColors.Window
		Me.lblIE.Text = "IE"
		Me.lblIE.Size = New System.Drawing.Size(17, 17)
		Me.lblIE.Location = New System.Drawing.Point(416, 37)
		Me.lblIE.TabIndex = 50
		Me.ToolTip1.SetToolTip(Me.lblIE, "Index Error")
		Me.lblIE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIE.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblIE.Enabled = True
		Me.lblIE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblIE.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblIE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblIE.UseMnemonic = True
		Me.lblIE.Visible = True
		Me.lblIE.AutoSize = False
		Me.lblIE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblIE.Name = "lblIE"
		Me.lblHE.BackColor = System.Drawing.SystemColors.Window
		Me.lblHE.Text = "HE"
		Me.lblHE.Size = New System.Drawing.Size(17, 17)
		Me.lblHE.Location = New System.Drawing.Point(416, 77)
		Me.lblHE.TabIndex = 61
		Me.ToolTip1.SetToolTip(Me.lblHE, "Height of Eye")
		Me.lblHE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHE.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHE.Enabled = True
		Me.lblHE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHE.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHE.UseMnemonic = True
		Me.lblHE.Visible = True
		Me.lblHE.AutoSize = False
		Me.lblHE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHE.Name = "lblHE"
		Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
		Me.lblHsSec.Text = """"
		Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
		Me.lblHsSec.Location = New System.Drawing.Point(561, 15)
		Me.lblHsSec.TabIndex = 49
		Me.lblHsSec.Visible = False
		Me.lblHsSec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHsSec.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHsSec.Enabled = True
		Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHsSec.UseMnemonic = True
		Me.lblHsSec.AutoSize = False
		Me.lblHsSec.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHsSec.Name = "lblHsSec"
		Me.lblHsMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblHsMin.Text = "'"
		Me.lblHsMin.Size = New System.Drawing.Size(9, 17)
		Me.lblHsMin.Location = New System.Drawing.Point(521, 15)
		Me.lblHsMin.TabIndex = 47
		Me.lblHsMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHsMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHsMin.Enabled = True
		Me.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHsMin.UseMnemonic = True
		Me.lblHsMin.Visible = True
		Me.lblHsMin.AutoSize = False
		Me.lblHsMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHsMin.Name = "lblHsMin"
		Me.lblHsDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblHsDeg.Text = "°"
		Me.lblHsDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblHsDeg.Location = New System.Drawing.Point(481, 14)
		Me.lblHsDeg.TabIndex = 45
		Me.lblHsDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHsDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHsDeg.Enabled = True
		Me.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHsDeg.UseMnemonic = True
		Me.lblHsDeg.Visible = True
		Me.lblHsDeg.AutoSize = False
		Me.lblHsDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHsDeg.Name = "lblHsDeg"
		Me.lblHs.BackColor = System.Drawing.SystemColors.Window
		Me.lblHs.Text = "hs"
		Me.lblHs.Size = New System.Drawing.Size(17, 17)
		Me.lblHs.Location = New System.Drawing.Point(416, 15)
		Me.lblHs.TabIndex = 43
		Me.ToolTip1.SetToolTip(Me.lblHs, "Sextant Altitude")
		Me.lblHs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHs.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHs.Enabled = True
		Me.lblHs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHs.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHs.UseMnemonic = True
		Me.lblHs.Visible = True
		Me.lblHs.AutoSize = False
		Me.lblHs.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHs.Name = "lblHs"
		Me.lblHsFormat.BackColor = System.Drawing.SystemColors.Window
		Me.lblHsFormat.Text = "hs/IE format"
		Me.lblHsFormat.Size = New System.Drawing.Size(65, 13)
		Me.lblHsFormat.Location = New System.Drawing.Point(416, 0)
		Me.lblHsFormat.TabIndex = 40
		Me.ToolTip1.SetToolTip(Me.lblHsFormat, "Sextant Altitude/Index Error format")
		Me.lblHsFormat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHsFormat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHsFormat.Enabled = True
		Me.lblHsFormat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHsFormat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHsFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHsFormat.UseMnemonic = True
		Me.lblHsFormat.Visible = True
		Me.lblHsFormat.AutoSize = False
		Me.lblHsFormat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHsFormat.Name = "lblHsFormat"
		Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblLoMin.Text = "'"
		Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLoMin.Location = New System.Drawing.Point(353, 120)
		Me.lblLoMin.TabIndex = 39
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
		Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblLoDeg.Text = "°"
		Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLoDeg.Location = New System.Drawing.Point(313, 120)
		Me.lblLoDeg.TabIndex = 38
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
		Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRLo.Text = "DR Lo"
		Me.lblDRLo.Size = New System.Drawing.Size(33, 13)
		Me.lblDRLo.Location = New System.Drawing.Point(240, 123)
		Me.lblDRLo.TabIndex = 34
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
		Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
		Me.lblLMin.Text = "'"
		Me.lblLMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLMin.Location = New System.Drawing.Point(353, 96)
		Me.lblLMin.TabIndex = 33
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
		Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
		Me.lblLDeg.Text = "°"
		Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLDeg.Location = New System.Drawing.Point(313, 96)
		Me.lblLDeg.TabIndex = 32
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
		Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
		Me.lblDRL.Text = "DR L"
		Me.lblDRL.Size = New System.Drawing.Size(25, 13)
		Me.lblDRL.Location = New System.Drawing.Point(240, 99)
		Me.lblDRL.TabIndex = 28
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
		Me.lblBody.BackColor = System.Drawing.SystemColors.Window
		Me.lblBody.Text = "Body"
		Me.lblBody.Size = New System.Drawing.Size(25, 17)
		Me.lblBody.Location = New System.Drawing.Point(240, 27)
		Me.lblBody.TabIndex = 25
		Me.lblBody.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBody.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBody.Enabled = True
		Me.lblBody.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBody.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBody.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBody.UseMnemonic = True
		Me.lblBody.Visible = True
		Me.lblBody.AutoSize = False
		Me.lblBody.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBody.Name = "lblBody"
		Me.lblZD.BackColor = System.Drawing.SystemColors.Window
		Me.lblZD.Text = "ZD"
		Me.lblZD.Size = New System.Drawing.Size(17, 17)
		Me.lblZD.Location = New System.Drawing.Point(8, 99)
		Me.lblZD.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.lblZD, "Zone Description")
		Me.lblZD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblZD.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblZD.Enabled = True
		Me.lblZD.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblZD.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblZD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblZD.UseMnemonic = True
		Me.lblZD.Visible = True
		Me.lblZD.AutoSize = False
		Me.lblZD.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblZD.Name = "lblZD"
		Me.lblZDAutoManual.BackColor = System.Drawing.SystemColors.Window
		Me.lblZDAutoManual.Text = "ZD"
		Me.lblZDAutoManual.Size = New System.Drawing.Size(17, 17)
		Me.lblZDAutoManual.Location = New System.Drawing.Point(8, 80)
		Me.lblZDAutoManual.TabIndex = 15
		Me.ToolTip1.SetToolTip(Me.lblZDAutoManual, "Zone Description ")
		Me.lblZDAutoManual.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblZDAutoManual.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblZDAutoManual.Enabled = True
		Me.lblZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblZDAutoManual.UseMnemonic = True
		Me.lblZDAutoManual.Visible = True
		Me.lblZDAutoManual.AutoSize = False
		Me.lblZDAutoManual.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblZDAutoManual.Name = "lblZDAutoManual"
		Me.lblWEsec.BackColor = System.Drawing.SystemColors.Window
		Me.lblWEsec.Text = "sec"
		Me.lblWEsec.Size = New System.Drawing.Size(17, 17)
		Me.lblWEsec.Location = New System.Drawing.Point(113, 51)
		Me.lblWEsec.TabIndex = 13
		Me.lblWEsec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWEsec.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWEsec.Enabled = True
		Me.lblWEsec.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWEsec.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWEsec.UseMnemonic = True
		Me.lblWEsec.Visible = True
		Me.lblWEsec.AutoSize = False
		Me.lblWEsec.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWEsec.Name = "lblWEsec"
		Me.lblWEmin.BackColor = System.Drawing.SystemColors.Window
		Me.lblWEmin.Text = "min"
		Me.lblWEmin.Size = New System.Drawing.Size(17, 17)
		Me.lblWEmin.Location = New System.Drawing.Point(57, 51)
		Me.lblWEmin.TabIndex = 11
		Me.lblWEmin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWEmin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWEmin.Enabled = True
		Me.lblWEmin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWEmin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWEmin.UseMnemonic = True
		Me.lblWEmin.Visible = True
		Me.lblWEmin.AutoSize = False
		Me.lblWEmin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWEmin.Name = "lblWEmin"
		Me.lblWE.BackColor = System.Drawing.SystemColors.Window
		Me.lblWE.Text = "WE"
		Me.lblWE.Size = New System.Drawing.Size(17, 17)
		Me.lblWE.Location = New System.Drawing.Point(8, 51)
		Me.lblWE.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.lblWE, "Watch Error")
		Me.lblWE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWE.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWE.Enabled = True
		Me.lblWE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWE.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWE.UseMnemonic = True
		Me.lblWE.Visible = True
		Me.lblWE.AutoSize = False
		Me.lblWE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWE.Name = "lblWE"
		Me.lblTime.BackColor = System.Drawing.SystemColors.Window
		Me.lblTime.Text = "WT (hhmmss)"
		Me.lblTime.Size = New System.Drawing.Size(73, 13)
		Me.lblTime.Location = New System.Drawing.Point(8, 27)
		Me.lblTime.TabIndex = 7
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
		Me.lblYear.BackColor = System.Drawing.SystemColors.Window
		Me.lblYear.Text = "Yr."
		Me.lblYear.Size = New System.Drawing.Size(17, 17)
		Me.lblYear.Location = New System.Drawing.Point(180, 3)
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
		Me.lblMonth.Size = New System.Drawing.Size(21, 17)
		Me.lblMonth.Location = New System.Drawing.Point(107, 3)
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
		Me.lblDay.Location = New System.Drawing.Point(40, 3)
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
		Me.lblDate.Location = New System.Drawing.Point(8, 3)
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
		Me.Controls.Add(cboPlanets)
		Me.Controls.Add(chkAH)
		Me.Controls.Add(cboStars)
		Me.Controls.Add(cboLo)
		Me.Controls.Add(cboL)
		Me.Controls.Add(cboSun)
		Me.Controls.Add(cmdMerDiag)
		Me.Controls.Add(cmdEqT)
		Me.Controls.Add(chkDST)
		Me.Controls.Add(txtIESec)
		Me.Controls.Add(optHoParameters)
		Me.Controls.Add(optHoSRForm)
		Me.Controls.Add(txtSightNo)
		Me.Controls.Add(cboDay)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdFix)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(txtIEdeg)
		Me.Controls.Add(cboZDm)
		Me.Controls.Add(txtLDeg)
		Me.Controls.Add(cboPolaris)
		Me.Controls.Add(cboDsUnit)
		Me.Controls.Add(txtDsDist)
		Me.Controls.Add(FrameHorizon)
		Me.Controls.Add(Framehs)
		Me.Controls.Add(FrameZD)
		Me.Controls.Add(cmdReduce)
		Me.Controls.Add(cboPressure)
		Me.Controls.Add(txtPressure)
		Me.Controls.Add(cboTemperature)
		Me.Controls.Add(txtTemperature)
		Me.Controls.Add(cboIE)
		Me.Controls.Add(txtIEmin)
		Me.Controls.Add(cboHE)
		Me.Controls.Add(txtHE)
		Me.Controls.Add(txtHsSec)
		Me.Controls.Add(txtHsMin)
		Me.Controls.Add(txtHsDeg)
		Me.Controls.Add(txtLoMin)
		Me.Controls.Add(txtLoDeg)
		Me.Controls.Add(txtLMin)
		Me.Controls.Add(cboBody)
		Me.Controls.Add(txtZDh)
		Me.Controls.Add(cboWE)
		Me.Controls.Add(txtWESec)
		Me.Controls.Add(txtWEMin)
		Me.Controls.Add(txtTime)
		Me.Controls.Add(txtYear)
		Me.Controls.Add(cboMonth)
		Me.Controls.Add(FrameTP)
		Me.Controls.Add(FrameHo)
		Me.Controls.Add(lblZDDST)
		Me.Controls.Add(lblIEsec)
		Me.Controls.Add(lblHoCorrs)
		Me.Controls.Add(lblSightNo)
		Me.ShapeContainer1.Shapes.Add(Line4)
		Me.ShapeContainer1.Shapes.Add(Line5)
		Me.Controls.Add(lblSmallm)
		Me.Controls.Add(lblM)
		Me.ShapeContainer1.Shapes.Add(Line2)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.ShapeContainer1.Shapes.Add(Line14)
		Me.ShapeContainer1.Shapes.Add(Line8)
		Me.ShapeContainer1.Shapes.Add(Line7)
		Me.ShapeContainer1.Shapes.Add(Line6)
		Me.ShapeContainer1.Shapes.Add(Line3)
		Me.Controls.Add(lblIEdeg)
		Me.Controls.Add(lblZDm)
		Me.Controls.Add(lblZDh)
		Me.Controls.Add(lblDsDist)
		Me.Controls.Add(lblHorizon)
		Me.Controls.Add(lblPressure)
		Me.Controls.Add(lblTempDeg)
		Me.Controls.Add(lblTemperature)
		Me.Controls.Add(lblStdT_P)
		Me.Controls.Add(lblIEMin)
		Me.Controls.Add(lblIE)
		Me.Controls.Add(lblHE)
		Me.Controls.Add(lblHsSec)
		Me.Controls.Add(lblHsMin)
		Me.Controls.Add(lblHsDeg)
		Me.Controls.Add(lblHs)
		Me.Controls.Add(lblHsFormat)
		Me.Controls.Add(lblLoMin)
		Me.Controls.Add(lblLoDeg)
		Me.Controls.Add(lblDRLo)
		Me.Controls.Add(lblLMin)
		Me.Controls.Add(lblLDeg)
		Me.Controls.Add(lblDRL)
		Me.Controls.Add(lblBody)
		Me.Controls.Add(lblZD)
		Me.Controls.Add(lblZDAutoManual)
		Me.Controls.Add(lblWEsec)
		Me.Controls.Add(lblWEmin)
		Me.Controls.Add(lblWE)
		Me.Controls.Add(lblTime)
		Me.Controls.Add(lblYear)
		Me.Controls.Add(lblMonth)
		Me.Controls.Add(lblDay)
		Me.Controls.Add(lblDate)
		Me.Controls.Add(ShapeContainer1)
		Me.FrameHorizon.Controls.Add(optHorizonDipShort)
		Me.FrameHorizon.Controls.Add(optHorizonArtificial)
		Me.FrameHorizon.Controls.Add(optHorizonNatural)
		Me.Framehs.Controls.Add(optHsDMS)
		Me.Framehs.Controls.Add(optHsDMm)
		Me.FrameZD.Controls.Add(optZDUT)
		Me.FrameZD.Controls.Add(optZDManual)
		Me.FrameZD.Controls.Add(optZDAuto)
		Me.FrameTP.Controls.Add(optStdTPNo)
		Me.FrameTP.Controls.Add(optStdTPYes)
		Me.FrameHorizon.ResumeLayout(False)
		Me.Framehs.ResumeLayout(False)
		Me.FrameZD.ResumeLayout(False)
		Me.FrameTP.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class