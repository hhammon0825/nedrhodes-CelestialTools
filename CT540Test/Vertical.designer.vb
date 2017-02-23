<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form25
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
	Public WithEvents txtBH As System.Windows.Forms.TextBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents txtDraft As System.Windows.Forms.TextBox
	Public WithEvents txtCD As System.Windows.Forms.TextBox
	Public WithEvents txtHeight As System.Windows.Forms.TextBox
	Public WithEvents txtCH As System.Windows.Forms.TextBox
	Public WithEvents txtMTR As System.Windows.Forms.TextBox
	Public WithEvents txtMTL As System.Windows.Forms.TextBox
	Public WithEvents cmdCalcVert As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form25))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.txtBH = New System.Windows.Forms.TextBox
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdClear = New System.Windows.Forms.Button
		Me.txtDraft = New System.Windows.Forms.TextBox
		Me.txtCD = New System.Windows.Forms.TextBox
		Me.txtHeight = New System.Windows.Forms.TextBox
		Me.txtCH = New System.Windows.Forms.TextBox
		Me.txtMTR = New System.Windows.Forms.TextBox
		Me.txtMTL = New System.Windows.Forms.TextBox
		Me.cmdCalcVert = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label14 = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Vertical Clearances"
		Me.ClientSize = New System.Drawing.Size(481, 409)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("Form25.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Name = "Form25"
		Me.txtBH.AutoSize = False
		Me.txtBH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBH.Size = New System.Drawing.Size(41, 19)
		Me.txtBH.Location = New System.Drawing.Point(320, 136)
		Me.txtBH.Maxlength = 5
		Me.txtBH.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.txtBH, "Max. 999.9")
		Me.txtBH.AcceptsReturn = True
		Me.txtBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBH.BackColor = System.Drawing.SystemColors.Window
		Me.txtBH.CausesValidation = True
		Me.txtBH.Enabled = True
		Me.txtBH.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBH.HideSelection = True
		Me.txtBH.ReadOnly = False
		Me.txtBH.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBH.MultiLine = False
		Me.txtBH.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBH.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBH.TabStop = True
		Me.txtBH.Visible = True
		Me.txtBH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBH.Name = "txtBH"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
		Me.cmdPrint.Location = New System.Drawing.Point(460, 0)
		Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
		Me.cmdPrint.TabIndex = 17
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
		Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClear.Text = "&Clear"
		Me.cmdClear.Size = New System.Drawing.Size(89, 25)
		Me.cmdClear.Location = New System.Drawing.Point(328, 376)
		Me.cmdClear.TabIndex = 8
		Me.cmdClear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClear.CausesValidation = True
		Me.cmdClear.Enabled = True
		Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.TabStop = True
		Me.cmdClear.Name = "cmdClear"
		Me.txtDraft.AutoSize = False
		Me.txtDraft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDraft.Size = New System.Drawing.Size(33, 19)
		Me.txtDraft.Location = New System.Drawing.Point(328, 304)
		Me.txtDraft.Maxlength = 4
		Me.txtDraft.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.txtDraft, "Range 0 to 99.9")
		Me.txtDraft.AcceptsReturn = True
		Me.txtDraft.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDraft.BackColor = System.Drawing.SystemColors.Window
		Me.txtDraft.CausesValidation = True
		Me.txtDraft.Enabled = True
		Me.txtDraft.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDraft.HideSelection = True
		Me.txtDraft.ReadOnly = False
		Me.txtDraft.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDraft.MultiLine = False
		Me.txtDraft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDraft.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDraft.TabStop = True
		Me.txtDraft.Visible = True
		Me.txtDraft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDraft.Name = "txtDraft"
		Me.txtCD.AutoSize = False
		Me.txtCD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCD.Size = New System.Drawing.Size(33, 19)
		Me.txtCD.Location = New System.Drawing.Point(328, 280)
		Me.txtCD.Maxlength = 4
		Me.txtCD.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.txtCD, "Range 0 to 99.9")
		Me.txtCD.AcceptsReturn = True
		Me.txtCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCD.BackColor = System.Drawing.SystemColors.Window
		Me.txtCD.CausesValidation = True
		Me.txtCD.Enabled = True
		Me.txtCD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCD.HideSelection = True
		Me.txtCD.ReadOnly = False
		Me.txtCD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCD.MultiLine = False
		Me.txtCD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCD.TabStop = True
		Me.txtCD.Visible = True
		Me.txtCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCD.Name = "txtCD"
		Me.txtHeight.AutoSize = False
		Me.txtHeight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHeight.Size = New System.Drawing.Size(33, 19)
		Me.txtHeight.Location = New System.Drawing.Point(328, 8)
		Me.txtHeight.Maxlength = 5
		Me.txtHeight.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.txtHeight, "Range -99.9 to 99.9")
		Me.txtHeight.AcceptsReturn = True
		Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHeight.BackColor = System.Drawing.SystemColors.Window
		Me.txtHeight.CausesValidation = True
		Me.txtHeight.Enabled = True
		Me.txtHeight.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHeight.HideSelection = True
		Me.txtHeight.ReadOnly = False
		Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHeight.MultiLine = False
		Me.txtHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHeight.TabStop = True
		Me.txtHeight.Visible = True
		Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHeight.Name = "txtHeight"
		Me.txtCH.AutoSize = False
		Me.txtCH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCH.Size = New System.Drawing.Size(41, 19)
		Me.txtCH.Location = New System.Drawing.Point(320, 64)
		Me.txtCH.Maxlength = 5
		Me.txtCH.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.txtCH, "Range 0 to 999.9")
		Me.txtCH.AcceptsReturn = True
		Me.txtCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCH.BackColor = System.Drawing.SystemColors.Window
		Me.txtCH.CausesValidation = True
		Me.txtCH.Enabled = True
		Me.txtCH.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCH.HideSelection = True
		Me.txtCH.ReadOnly = False
		Me.txtCH.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCH.MultiLine = False
		Me.txtCH.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCH.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCH.TabStop = True
		Me.txtCH.Visible = True
		Me.txtCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCH.Name = "txtCH"
		Me.txtMTR.AutoSize = False
		Me.txtMTR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMTR.Size = New System.Drawing.Size(33, 19)
		Me.txtMTR.Location = New System.Drawing.Point(328, 88)
		Me.txtMTR.Maxlength = 4
		Me.txtMTR.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.txtMTR, "Range 0 to 99.9")
		Me.txtMTR.AcceptsReturn = True
		Me.txtMTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMTR.BackColor = System.Drawing.SystemColors.Window
		Me.txtMTR.CausesValidation = True
		Me.txtMTR.Enabled = True
		Me.txtMTR.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMTR.HideSelection = True
		Me.txtMTR.ReadOnly = False
		Me.txtMTR.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMTR.MultiLine = False
		Me.txtMTR.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMTR.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMTR.TabStop = True
		Me.txtMTR.Visible = True
		Me.txtMTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMTR.Name = "txtMTR"
		Me.txtMTL.AutoSize = False
		Me.txtMTL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMTL.Size = New System.Drawing.Size(33, 19)
		Me.txtMTL.Location = New System.Drawing.Point(328, 112)
		Me.txtMTL.Maxlength = 4
		Me.txtMTL.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.txtMTL, "Range 0 to 99.9")
		Me.txtMTL.AcceptsReturn = True
		Me.txtMTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMTL.BackColor = System.Drawing.SystemColors.Window
		Me.txtMTL.CausesValidation = True
		Me.txtMTL.Enabled = True
		Me.txtMTL.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMTL.HideSelection = True
		Me.txtMTL.ReadOnly = False
		Me.txtMTL.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMTL.MultiLine = False
		Me.txtMTL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMTL.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMTL.TabStop = True
		Me.txtMTL.Visible = True
		Me.txtMTL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMTL.Name = "txtMTL"
		Me.cmdCalcVert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCalcVert.Text = "Calculate &Vertical Clearances"
		Me.cmdCalcVert.Size = New System.Drawing.Size(177, 25)
		Me.cmdCalcVert.Location = New System.Drawing.Point(64, 376)
		Me.cmdCalcVert.TabIndex = 7
		Me.cmdCalcVert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCalcVert.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCalcVert.CausesValidation = True
		Me.cmdCalcVert.Enabled = True
		Me.cmdCalcVert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCalcVert.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCalcVert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCalcVert.TabStop = True
		Me.cmdCalcVert.Name = "cmdCalcVert"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Boat (mast) height"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(120, 136)
		Me.Label1.TabIndex = 18
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
		Me.Line3.BorderWidth = 2
		Me.Line3.X1 = 0
		Me.Line3.X2 = 480
		Me.Line3.Y1 = 368
		Me.Line3.Y2 = 368
		Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line3.Visible = True
		Me.Line3.Name = "Line3"
		Me.Line2.BorderWidth = 2
		Me.Line2.X1 = 480
		Me.Line2.X2 = 0
		Me.Line2.Y1 = 32
		Me.Line2.Y2 = 32
		Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line2.Visible = True
		Me.Line2.Name = "Line2"
		Me.Label14.BackColor = System.Drawing.SystemColors.Window
		Me.Label14.Text = "Height of tide at desired time"
		Me.Label14.Size = New System.Drawing.Size(137, 17)
		Me.Label14.Location = New System.Drawing.Point(96, 8)
		Me.Label14.TabIndex = 16
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 480
		Me.Line1.X2 = 0
		Me.Line1.Y1 = 248
		Me.Line1.Y2 = 248
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Label13.BackColor = System.Drawing.SystemColors.Window
		Me.Label13.Text = "Mean Tidal Range (from Table 2)"
		Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Size = New System.Drawing.Size(161, 17)
		Me.Label13.Location = New System.Drawing.Point(120, 88)
		Me.Label13.TabIndex = 15
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
		Me.Label12.Text = "Mean Tide Level (from Table 2)"
		Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Size = New System.Drawing.Size(153, 17)
		Me.Label12.Location = New System.Drawing.Point(120, 112)
		Me.Label12.TabIndex = 14
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
		Me.Label11.Text = "Charted Height of object (above MHW)"
		Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Size = New System.Drawing.Size(193, 17)
		Me.Label11.Location = New System.Drawing.Point(120, 64)
		Me.Label11.TabIndex = 13
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
		Me.Label9.BackColor = System.Drawing.SystemColors.Window
		Me.Label9.Text = "Boat's Draft"
		Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Size = New System.Drawing.Size(57, 17)
		Me.Label9.Location = New System.Drawing.Point(120, 304)
		Me.Label9.TabIndex = 12
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
		Me.Label7.BackColor = System.Drawing.SystemColors.Window
		Me.Label7.Text = "Charted Depth"
		Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.Location = New System.Drawing.Point(120, 280)
		Me.Label7.TabIndex = 11
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
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Depth Under Keel"
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Size = New System.Drawing.Size(89, 17)
		Me.Label6.Location = New System.Drawing.Point(200, 256)
		Me.Label6.TabIndex = 10
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
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "Vertical Clearance"
		Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.Location = New System.Drawing.Point(200, 40)
		Me.Label5.TabIndex = 9
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
		Me.Controls.Add(txtBH)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(txtDraft)
		Me.Controls.Add(txtCD)
		Me.Controls.Add(txtHeight)
		Me.Controls.Add(txtCH)
		Me.Controls.Add(txtMTR)
		Me.Controls.Add(txtMTL)
		Me.Controls.Add(cmdCalcVert)
		Me.Controls.Add(Label1)
		Me.ShapeContainer1.Shapes.Add(Line3)
		Me.ShapeContainer1.Shapes.Add(Line2)
		Me.Controls.Add(Label14)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(Label13)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(ShapeContainer1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class