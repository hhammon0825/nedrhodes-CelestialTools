<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form7
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents cboDsUnit As System.Windows.Forms.ComboBox
	Public WithEvents txtDsDist As System.Windows.Forms.TextBox
	Public WithEvents optHorizonNatural As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonArtificial As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonDipShort As System.Windows.Forms.RadioButton
	Public WithEvents cmdUse As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdRemoveLocation As System.Windows.Forms.Button
	Public WithEvents txtMaxAz As System.Windows.Forms.TextBox
	Public WithEvents txtMinAz As System.Windows.Forms.TextBox
	Public WithEvents txtLMin As System.Windows.Forms.TextBox
	Public WithEvents cboL As System.Windows.Forms.ComboBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents txtLDeg As System.Windows.Forms.TextBox
	Public WithEvents txtNewName As System.Windows.Forms.TextBox
	Public WithEvents cmdAddLocation As System.Windows.Forms.Button
	Public WithEvents lstFavorites As System.Windows.Forms.ListBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblDsDist As System.Windows.Forms.Label
	Public WithEvents lblHorizon As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblSelect As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblNewLocation As System.Windows.Forms.Label
	Public WithEvents lblMaxAzdeg As System.Windows.Forms.Label
	Public WithEvents lblMinAzDeg As System.Windows.Forms.Label
	Public WithEvents lblNewMaxAz As System.Windows.Forms.Label
	Public WithEvents lblNewMinAz As System.Windows.Forms.Label
	Public WithEvents lblNewLong As System.Windows.Forms.Label
	Public WithEvents lblNewLat As System.Windows.Forms.Label
	Public WithEvents lblLDeg As System.Windows.Forms.Label
	Public WithEvents lblLMin As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents lblNewName As System.Windows.Forms.Label
	Public WithEvents lblMaxAz As System.Windows.Forms.Label
	Public WithEvents lblMinAz As System.Windows.Forms.Label
	Public WithEvents lblLongitude As System.Windows.Forms.Label
	Public WithEvents lblLatitude As System.Windows.Forms.Label
	Public WithEvents lblName As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form7))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.cboDsUnit = New System.Windows.Forms.ComboBox
		Me.txtDsDist = New System.Windows.Forms.TextBox
		Me.optHorizonNatural = New System.Windows.Forms.RadioButton
		Me.optHorizonArtificial = New System.Windows.Forms.RadioButton
		Me.optHorizonDipShort = New System.Windows.Forms.RadioButton
		Me.cmdUse = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.cmdRemoveLocation = New System.Windows.Forms.Button
		Me.txtMaxAz = New System.Windows.Forms.TextBox
		Me.txtMinAz = New System.Windows.Forms.TextBox
		Me.txtLMin = New System.Windows.Forms.TextBox
		Me.cboL = New System.Windows.Forms.ComboBox
		Me.txtLoDeg = New System.Windows.Forms.TextBox
		Me.txtLoMin = New System.Windows.Forms.TextBox
		Me.cboLo = New System.Windows.Forms.ComboBox
		Me.txtLDeg = New System.Windows.Forms.TextBox
		Me.txtNewName = New System.Windows.Forms.TextBox
		Me.cmdAddLocation = New System.Windows.Forms.Button
		Me.lstFavorites = New System.Windows.Forms.ListBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblDsDist = New System.Windows.Forms.Label
		Me.lblHorizon = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblSelect = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblNewLocation = New System.Windows.Forms.Label
		Me.lblMaxAzdeg = New System.Windows.Forms.Label
		Me.lblMinAzDeg = New System.Windows.Forms.Label
		Me.lblNewMaxAz = New System.Windows.Forms.Label
		Me.lblNewMinAz = New System.Windows.Forms.Label
		Me.lblNewLong = New System.Windows.Forms.Label
		Me.lblNewLat = New System.Windows.Forms.Label
		Me.lblLDeg = New System.Windows.Forms.Label
		Me.lblLMin = New System.Windows.Forms.Label
		Me.lblLoDeg = New System.Windows.Forms.Label
		Me.lblLoMin = New System.Windows.Forms.Label
		Me.lblNewName = New System.Windows.Forms.Label
		Me.lblMaxAz = New System.Windows.Forms.Label
		Me.lblMinAz = New System.Windows.Forms.Label
		Me.lblLongitude = New System.Windows.Forms.Label
		Me.lblLatitude = New System.Windows.Forms.Label
		Me.lblName = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Favorite Places"
		Me.ClientSize = New System.Drawing.Size(776, 368)
		Me.Location_Renamed = New System.Drawing.Point(1004, 61)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("Form7.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form7"
		Me.cboDsUnit.Size = New System.Drawing.Size(89, 21)
		Me.cboDsUnit.Location = New System.Drawing.Point(272, 312)
		Me.cboDsUnit.Items.AddRange(New Object(){"feet", "yards", "meters", "statute miles", "nautical miles"})
		Me.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDsUnit.TabIndex = 39
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
		Me.txtDsDist.Location = New System.Drawing.Point(224, 312)
		Me.txtDsDist.Maxlength = 5
		Me.txtDsDist.TabIndex = 38
		Me.ToolTip1.SetToolTip(Me.txtDsDist, "Limited to four characters")
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
		Me.optHorizonNatural.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonNatural.Text = "Natural"
		Me.optHorizonNatural.Size = New System.Drawing.Size(65, 13)
		Me.optHorizonNatural.Location = New System.Drawing.Point(216, 296)
		Me.optHorizonNatural.TabIndex = 35
		Me.optHorizonNatural.Checked = True
		Me.optHorizonNatural.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonNatural.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonNatural.BackColor = System.Drawing.SystemColors.Control
		Me.optHorizonNatural.CausesValidation = True
		Me.optHorizonNatural.Enabled = True
		Me.optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default
		Me.optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optHorizonNatural.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optHorizonNatural.TabStop = True
		Me.optHorizonNatural.Visible = True
		Me.optHorizonNatural.Name = "optHorizonNatural"
		Me.optHorizonArtificial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonArtificial.Text = "Artificial"
		Me.optHorizonArtificial.Size = New System.Drawing.Size(60, 13)
		Me.optHorizonArtificial.Location = New System.Drawing.Point(284, 296)
		Me.optHorizonArtificial.TabIndex = 34
		Me.optHorizonArtificial.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonArtificial.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonArtificial.BackColor = System.Drawing.SystemColors.Control
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
		Me.optHorizonDipShort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonDipShort.Text = "Dip Short"
		Me.optHorizonDipShort.Size = New System.Drawing.Size(65, 13)
		Me.optHorizonDipShort.Location = New System.Drawing.Point(352, 296)
		Me.optHorizonDipShort.TabIndex = 33
		Me.optHorizonDipShort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHorizonDipShort.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optHorizonDipShort.BackColor = System.Drawing.SystemColors.Control
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
		Me.cmdUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdUse.Text = "&Use Location"
		Me.cmdUse.Size = New System.Drawing.Size(105, 25)
		Me.cmdUse.Location = New System.Drawing.Point(664, 144)
		Me.cmdUse.TabIndex = 32
		Me.cmdUse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUse.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUse.CausesValidation = True
		Me.cmdUse.Enabled = True
		Me.cmdUse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUse.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUse.TabStop = True
		Me.cmdUse.Name = "cmdUse"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "&Save Location List"
		Me.cmdSave.Size = New System.Drawing.Size(105, 25)
		Me.cmdSave.Location = New System.Drawing.Point(336, 144)
		Me.cmdSave.TabIndex = 28
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdRemoveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRemoveLocation.Text = "&Remove Location"
		Me.cmdRemoveLocation.Size = New System.Drawing.Size(105, 25)
		Me.cmdRemoveLocation.Location = New System.Drawing.Point(8, 144)
		Me.cmdRemoveLocation.TabIndex = 27
		Me.cmdRemoveLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRemoveLocation.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRemoveLocation.CausesValidation = True
		Me.cmdRemoveLocation.Enabled = True
		Me.cmdRemoveLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRemoveLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRemoveLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRemoveLocation.TabStop = True
		Me.cmdRemoveLocation.Name = "cmdRemoveLocation"
		Me.txtMaxAz.AutoSize = False
		Me.txtMaxAz.Size = New System.Drawing.Size(33, 19)
		Me.txtMaxAz.Location = New System.Drawing.Point(296, 272)
		Me.txtMaxAz.Maxlength = 3
		Me.txtMaxAz.TabIndex = 24
		Me.txtMaxAz.Text = "360"
		Me.ToolTip1.SetToolTip(Me.txtMaxAz, "Range 0 to 360")
		Me.txtMaxAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMaxAz.AcceptsReturn = True
		Me.txtMaxAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMaxAz.BackColor = System.Drawing.SystemColors.Window
		Me.txtMaxAz.CausesValidation = True
		Me.txtMaxAz.Enabled = True
		Me.txtMaxAz.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMaxAz.HideSelection = True
		Me.txtMaxAz.ReadOnly = False
		Me.txtMaxAz.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMaxAz.MultiLine = False
		Me.txtMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMaxAz.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxAz.TabStop = True
		Me.txtMaxAz.Visible = True
		Me.txtMaxAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMaxAz.Name = "txtMaxAz"
		Me.txtMinAz.AutoSize = False
		Me.txtMinAz.Size = New System.Drawing.Size(33, 19)
		Me.txtMinAz.Location = New System.Drawing.Point(232, 272)
		Me.txtMinAz.Maxlength = 3
		Me.txtMinAz.TabIndex = 21
		Me.txtMinAz.Text = "0"
		Me.ToolTip1.SetToolTip(Me.txtMinAz, "Range 0 to 360")
		Me.txtMinAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMinAz.AcceptsReturn = True
		Me.txtMinAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMinAz.BackColor = System.Drawing.SystemColors.Window
		Me.txtMinAz.CausesValidation = True
		Me.txtMinAz.Enabled = True
		Me.txtMinAz.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMinAz.HideSelection = True
		Me.txtMinAz.ReadOnly = False
		Me.txtMinAz.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMinAz.MultiLine = False
		Me.txtMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMinAz.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMinAz.TabStop = True
		Me.txtMinAz.Visible = True
		Me.txtMinAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMinAz.Name = "txtMinAz"
		Me.txtLMin.AutoSize = False
		Me.txtLMin.Size = New System.Drawing.Size(33, 19)
		Me.txtLMin.Location = New System.Drawing.Point(256, 224)
		Me.txtLMin.Maxlength = 4
		Me.txtLMin.TabIndex = 11
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
		Me.cboL.Location = New System.Drawing.Point(296, 224)
		Me.cboL.Items.AddRange(New Object(){"N ", "S "})
		Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboL.TabIndex = 13
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
		Me.txtLoDeg.Location = New System.Drawing.Point(216, 248)
		Me.txtLoDeg.Maxlength = 3
		Me.txtLoDeg.TabIndex = 15
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
		Me.txtLoMin.Location = New System.Drawing.Point(256, 248)
		Me.txtLoMin.Maxlength = 4
		Me.txtLoMin.TabIndex = 17
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
		Me.cboLo.Location = New System.Drawing.Point(296, 248)
		Me.cboLo.Items.AddRange(New Object(){"W ", "E "})
		Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLo.TabIndex = 19
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
		Me.txtLDeg.Location = New System.Drawing.Point(224, 224)
		Me.txtLDeg.Maxlength = 2
		Me.txtLDeg.TabIndex = 9
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
		Me.txtNewName.AutoSize = False
		Me.txtNewName.Size = New System.Drawing.Size(393, 19)
		Me.txtNewName.Location = New System.Drawing.Point(200, 200)
		Me.txtNewName.Maxlength = 35
		Me.txtNewName.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.txtNewName, "Max. 35 characters")
		Me.txtNewName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNewName.AcceptsReturn = True
		Me.txtNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNewName.BackColor = System.Drawing.SystemColors.Window
		Me.txtNewName.CausesValidation = True
		Me.txtNewName.Enabled = True
		Me.txtNewName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNewName.HideSelection = True
		Me.txtNewName.ReadOnly = False
		Me.txtNewName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNewName.MultiLine = False
		Me.txtNewName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNewName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNewName.TabStop = True
		Me.txtNewName.Visible = True
		Me.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNewName.Name = "txtNewName"
		Me.cmdAddLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAddLocation.Text = "&Add New Location"
		Me.cmdAddLocation.Size = New System.Drawing.Size(121, 25)
		Me.cmdAddLocation.Location = New System.Drawing.Point(328, 336)
		Me.cmdAddLocation.TabIndex = 26
		Me.cmdAddLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAddLocation.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddLocation.CausesValidation = True
		Me.cmdAddLocation.Enabled = True
		Me.cmdAddLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAddLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddLocation.TabStop = True
		Me.cmdAddLocation.Name = "cmdAddLocation"
		Me.lstFavorites.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstFavorites.Size = New System.Drawing.Size(761, 105)
		Me.lstFavorites.Location = New System.Drawing.Point(8, 32)
		Me.lstFavorites.Sorted = True
		Me.lstFavorites.TabIndex = 0
		Me.lstFavorites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstFavorites.BackColor = System.Drawing.SystemColors.Window
		Me.lstFavorites.CausesValidation = True
		Me.lstFavorites.Enabled = True
		Me.lstFavorites.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstFavorites.IntegralHeight = True
		Me.lstFavorites.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstFavorites.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstFavorites.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstFavorites.TabStop = True
		Me.lstFavorites.Visible = True
		Me.lstFavorites.MultiColumn = False
		Me.lstFavorites.Name = "lstFavorites"
		Me.Label3.Text = "Ds dist."
		Me.Label3.Size = New System.Drawing.Size(41, 17)
		Me.Label3.Location = New System.Drawing.Point(616, 16)
		Me.Label3.TabIndex = 41
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label1.Text = "Hor"
		Me.Label1.Size = New System.Drawing.Size(17, 17)
		Me.Label1.Location = New System.Drawing.Point(576, 16)
		Me.Label1.TabIndex = 40
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lblDsDist.Text = "Ds distance"
		Me.lblDsDist.Size = New System.Drawing.Size(57, 17)
		Me.lblDsDist.Location = New System.Drawing.Point(160, 312)
		Me.lblDsDist.TabIndex = 37
		Me.ToolTip1.SetToolTip(Me.lblDsDist, "Distance to dip short horizon")
		Me.lblDsDist.Visible = False
		Me.lblDsDist.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDsDist.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDsDist.BackColor = System.Drawing.SystemColors.Control
		Me.lblDsDist.Enabled = True
		Me.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDsDist.UseMnemonic = True
		Me.lblDsDist.AutoSize = False
		Me.lblDsDist.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDsDist.Name = "lblDsDist"
		Me.lblHorizon.Text = "Horizon"
		Me.lblHorizon.Size = New System.Drawing.Size(49, 17)
		Me.lblHorizon.Location = New System.Drawing.Point(160, 296)
		Me.lblHorizon.TabIndex = 36
		Me.lblHorizon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHorizon.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblHorizon.BackColor = System.Drawing.SystemColors.Control
		Me.lblHorizon.Enabled = True
		Me.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHorizon.UseMnemonic = True
		Me.lblHorizon.Visible = True
		Me.lblHorizon.AutoSize = False
		Me.lblHorizon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblHorizon.Name = "lblHorizon"
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 0
		Me.Line1.X2 = 776
		Me.Line1.Y1 = 176
		Me.Line1.Y2 = 176
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.lblSelect.Text = "Select location:"
		Me.lblSelect.Size = New System.Drawing.Size(81, 17)
		Me.lblSelect.Location = New System.Drawing.Point(8, 0)
		Me.lblSelect.TabIndex = 31
		Me.lblSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSelect.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSelect.BackColor = System.Drawing.SystemColors.Control
		Me.lblSelect.Enabled = True
		Me.lblSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSelect.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSelect.UseMnemonic = True
		Me.lblSelect.Visible = True
		Me.lblSelect.AutoSize = False
		Me.lblSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSelect.Name = "lblSelect"
		Me.Label2.Text = "Label2"
		Me.Label2.Size = New System.Drawing.Size(105, 1)
		Me.Label2.Location = New System.Drawing.Point(16, 8)
		Me.Label2.TabIndex = 30
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.lblNewLocation.Text = "New Location:"
		Me.lblNewLocation.Size = New System.Drawing.Size(73, 17)
		Me.lblNewLocation.Location = New System.Drawing.Point(200, 184)
		Me.lblNewLocation.TabIndex = 29
		Me.lblNewLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewLocation.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewLocation.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewLocation.Enabled = True
		Me.lblNewLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewLocation.UseMnemonic = True
		Me.lblNewLocation.Visible = True
		Me.lblNewLocation.AutoSize = False
		Me.lblNewLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewLocation.Name = "lblNewLocation"
		Me.lblMaxAzdeg.Text = "°"
		Me.lblMaxAzdeg.Size = New System.Drawing.Size(9, 17)
		Me.lblMaxAzdeg.Location = New System.Drawing.Point(329, 272)
		Me.lblMaxAzdeg.TabIndex = 25
		Me.lblMaxAzdeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMaxAzdeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMaxAzdeg.BackColor = System.Drawing.SystemColors.Control
		Me.lblMaxAzdeg.Enabled = True
		Me.lblMaxAzdeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMaxAzdeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMaxAzdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMaxAzdeg.UseMnemonic = True
		Me.lblMaxAzdeg.Visible = True
		Me.lblMaxAzdeg.AutoSize = False
		Me.lblMaxAzdeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMaxAzdeg.Name = "lblMaxAzdeg"
		Me.lblMinAzDeg.Text = "°"
		Me.lblMinAzDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblMinAzDeg.Location = New System.Drawing.Point(265, 272)
		Me.lblMinAzDeg.TabIndex = 22
		Me.lblMinAzDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMinAzDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMinAzDeg.BackColor = System.Drawing.SystemColors.Control
		Me.lblMinAzDeg.Enabled = True
		Me.lblMinAzDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMinAzDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMinAzDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMinAzDeg.UseMnemonic = True
		Me.lblMinAzDeg.Visible = True
		Me.lblMinAzDeg.AutoSize = False
		Me.lblMinAzDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMinAzDeg.Name = "lblMinAzDeg"
		Me.lblNewMaxAz.Text = "to"
		Me.lblNewMaxAz.Size = New System.Drawing.Size(9, 17)
		Me.lblNewMaxAz.Location = New System.Drawing.Point(275, 272)
		Me.lblNewMaxAz.TabIndex = 23
		Me.lblNewMaxAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewMaxAz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewMaxAz.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewMaxAz.Enabled = True
		Me.lblNewMaxAz.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewMaxAz.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewMaxAz.UseMnemonic = True
		Me.lblNewMaxAz.Visible = True
		Me.lblNewMaxAz.AutoSize = False
		Me.lblNewMaxAz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewMaxAz.Name = "lblNewMaxAz"
		Me.lblNewMinAz.Text = "Azimuth from"
		Me.lblNewMinAz.Size = New System.Drawing.Size(65, 17)
		Me.lblNewMinAz.Location = New System.Drawing.Point(160, 272)
		Me.lblNewMinAz.TabIndex = 20
		Me.lblNewMinAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewMinAz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewMinAz.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewMinAz.Enabled = True
		Me.lblNewMinAz.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewMinAz.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewMinAz.UseMnemonic = True
		Me.lblNewMinAz.Visible = True
		Me.lblNewMinAz.AutoSize = False
		Me.lblNewMinAz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewMinAz.Name = "lblNewMinAz"
		Me.lblNewLong.Text = "Longitude"
		Me.lblNewLong.Size = New System.Drawing.Size(49, 17)
		Me.lblNewLong.Location = New System.Drawing.Point(160, 248)
		Me.lblNewLong.TabIndex = 14
		Me.lblNewLong.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewLong.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewLong.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewLong.Enabled = True
		Me.lblNewLong.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewLong.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewLong.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewLong.UseMnemonic = True
		Me.lblNewLong.Visible = True
		Me.lblNewLong.AutoSize = False
		Me.lblNewLong.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewLong.Name = "lblNewLong"
		Me.lblNewLat.Text = "Latitude"
		Me.lblNewLat.Size = New System.Drawing.Size(57, 17)
		Me.lblNewLat.Location = New System.Drawing.Point(160, 224)
		Me.lblNewLat.TabIndex = 8
		Me.lblNewLat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewLat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewLat.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewLat.Enabled = True
		Me.lblNewLat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewLat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewLat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewLat.UseMnemonic = True
		Me.lblNewLat.Visible = True
		Me.lblNewLat.AutoSize = False
		Me.lblNewLat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewLat.Name = "lblNewLat"
		Me.lblLDeg.Text = "°"
		Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLDeg.Location = New System.Drawing.Point(249, 224)
		Me.lblLDeg.TabIndex = 10
		Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLDeg.BackColor = System.Drawing.SystemColors.Control
		Me.lblLDeg.Enabled = True
		Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLDeg.UseMnemonic = True
		Me.lblLDeg.Visible = True
		Me.lblLDeg.AutoSize = False
		Me.lblLDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLDeg.Name = "lblLDeg"
		Me.lblLMin.Text = "'"
		Me.lblLMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLMin.Location = New System.Drawing.Point(289, 224)
		Me.lblLMin.TabIndex = 12
		Me.lblLMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLMin.BackColor = System.Drawing.SystemColors.Control
		Me.lblLMin.Enabled = True
		Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLMin.UseMnemonic = True
		Me.lblLMin.Visible = True
		Me.lblLMin.AutoSize = False
		Me.lblLMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLMin.Name = "lblLMin"
		Me.lblLoDeg.Text = "°"
		Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
		Me.lblLoDeg.Location = New System.Drawing.Point(249, 248)
		Me.lblLoDeg.TabIndex = 16
		Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoDeg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Control
		Me.lblLoDeg.Enabled = True
		Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLoDeg.UseMnemonic = True
		Me.lblLoDeg.Visible = True
		Me.lblLoDeg.AutoSize = False
		Me.lblLoDeg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLoDeg.Name = "lblLoDeg"
		Me.lblLoMin.Text = "'"
		Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
		Me.lblLoMin.Location = New System.Drawing.Point(289, 248)
		Me.lblLoMin.TabIndex = 18
		Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLoMin.BackColor = System.Drawing.SystemColors.Control
		Me.lblLoMin.Enabled = True
		Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLoMin.UseMnemonic = True
		Me.lblLoMin.Visible = True
		Me.lblLoMin.AutoSize = False
		Me.lblLoMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLoMin.Name = "lblLoMin"
		Me.lblNewName.Text = "Name"
		Me.lblNewName.Size = New System.Drawing.Size(33, 17)
		Me.lblNewName.Location = New System.Drawing.Point(160, 200)
		Me.lblNewName.TabIndex = 6
		Me.lblNewName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewName.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewName.Enabled = True
		Me.lblNewName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewName.UseMnemonic = True
		Me.lblNewName.Visible = True
		Me.lblNewName.AutoSize = False
		Me.lblNewName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewName.Name = "lblNewName"
		Me.lblMaxAz.Text = "To Zn"
		Me.lblMaxAz.Size = New System.Drawing.Size(33, 17)
		Me.lblMaxAz.Location = New System.Drawing.Point(520, 16)
		Me.lblMaxAz.TabIndex = 5
		Me.lblMaxAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMaxAz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMaxAz.BackColor = System.Drawing.SystemColors.Control
		Me.lblMaxAz.Enabled = True
		Me.lblMaxAz.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMaxAz.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMaxAz.UseMnemonic = True
		Me.lblMaxAz.Visible = True
		Me.lblMaxAz.AutoSize = False
		Me.lblMaxAz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMaxAz.Name = "lblMaxAz"
		Me.lblMinAz.Text = "From Zn"
		Me.lblMinAz.Size = New System.Drawing.Size(41, 17)
		Me.lblMinAz.Location = New System.Drawing.Point(448, 16)
		Me.lblMinAz.TabIndex = 4
		Me.lblMinAz.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMinAz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMinAz.BackColor = System.Drawing.SystemColors.Control
		Me.lblMinAz.Enabled = True
		Me.lblMinAz.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMinAz.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMinAz.UseMnemonic = True
		Me.lblMinAz.Visible = True
		Me.lblMinAz.AutoSize = False
		Me.lblMinAz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMinAz.Name = "lblMinAz"
		Me.lblLongitude.Text = "Longitude"
		Me.lblLongitude.Size = New System.Drawing.Size(49, 17)
		Me.lblLongitude.Location = New System.Drawing.Point(360, 16)
		Me.lblLongitude.TabIndex = 3
		Me.lblLongitude.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLongitude.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLongitude.BackColor = System.Drawing.SystemColors.Control
		Me.lblLongitude.Enabled = True
		Me.lblLongitude.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLongitude.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLongitude.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLongitude.UseMnemonic = True
		Me.lblLongitude.Visible = True
		Me.lblLongitude.AutoSize = False
		Me.lblLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLongitude.Name = "lblLongitude"
		Me.lblLatitude.Text = "Latitude"
		Me.lblLatitude.Size = New System.Drawing.Size(41, 17)
		Me.lblLatitude.Location = New System.Drawing.Point(280, 16)
		Me.lblLatitude.TabIndex = 2
		Me.lblLatitude.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLatitude.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLatitude.BackColor = System.Drawing.SystemColors.Control
		Me.lblLatitude.Enabled = True
		Me.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLatitude.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLatitude.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLatitude.UseMnemonic = True
		Me.lblLatitude.Visible = True
		Me.lblLatitude.AutoSize = False
		Me.lblLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLatitude.Name = "lblLatitude"
		Me.lblName.Text = "Name"
		Me.lblName.Size = New System.Drawing.Size(33, 17)
		Me.lblName.Location = New System.Drawing.Point(16, 16)
		Me.lblName.TabIndex = 1
		Me.lblName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblName.BackColor = System.Drawing.SystemColors.Control
		Me.lblName.Enabled = True
		Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblName.UseMnemonic = True
		Me.lblName.Visible = True
		Me.lblName.AutoSize = False
		Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblName.Name = "lblName"
		Me.Controls.Add(cboDsUnit)
		Me.Controls.Add(txtDsDist)
		Me.Controls.Add(optHorizonNatural)
		Me.Controls.Add(optHorizonArtificial)
		Me.Controls.Add(optHorizonDipShort)
		Me.Controls.Add(cmdUse)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(cmdRemoveLocation)
		Me.Controls.Add(txtMaxAz)
		Me.Controls.Add(txtMinAz)
		Me.Controls.Add(txtLMin)
		Me.Controls.Add(cboL)
		Me.Controls.Add(txtLoDeg)
		Me.Controls.Add(txtLoMin)
		Me.Controls.Add(cboLo)
		Me.Controls.Add(txtLDeg)
		Me.Controls.Add(txtNewName)
		Me.Controls.Add(cmdAddLocation)
		Me.Controls.Add(lstFavorites)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblDsDist)
		Me.Controls.Add(lblHorizon)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(lblSelect)
		Me.Controls.Add(Label2)
		Me.Controls.Add(lblNewLocation)
		Me.Controls.Add(lblMaxAzdeg)
		Me.Controls.Add(lblMinAzDeg)
		Me.Controls.Add(lblNewMaxAz)
		Me.Controls.Add(lblNewMinAz)
		Me.Controls.Add(lblNewLong)
		Me.Controls.Add(lblNewLat)
		Me.Controls.Add(lblLDeg)
		Me.Controls.Add(lblLMin)
		Me.Controls.Add(lblLoDeg)
		Me.Controls.Add(lblLoMin)
		Me.Controls.Add(lblNewName)
		Me.Controls.Add(lblMaxAz)
		Me.Controls.Add(lblMinAz)
		Me.Controls.Add(lblLongitude)
		Me.Controls.Add(lblLatitude)
		Me.Controls.Add(lblName)
		Me.Controls.Add(ShapeContainer1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class