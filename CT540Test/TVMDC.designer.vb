<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form17
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
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents optUp As System.Windows.Forms.RadioButton
	Public WithEvents optDown As System.Windows.Forms.RadioButton
	Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtEW As System.Windows.Forms.TextBox
	Public WithEvents txtCorrVar As System.Windows.Forms.TextBox
	Public WithEvents txtYI As System.Windows.Forms.TextBox
	Public WithEvents cboCV As System.Windows.Forms.ComboBox
	Public WithEvents cboD As System.Windows.Forms.ComboBox
	Public WithEvents cboV As System.Windows.Forms.ComboBox
	Public WithEvents cboIncDec As System.Windows.Forms.ComboBox
	Public WithEvents txtChange As System.Windows.Forms.TextBox
	Public WithEvents txtCY As System.Windows.Forms.TextBox
	Public WithEvents txtCVMin As System.Windows.Forms.TextBox
	Public WithEvents txtCVDeg As System.Windows.Forms.TextBox
	Public WithEvents txtCompass As System.Windows.Forms.TextBox
	Public WithEvents txtDeviation As System.Windows.Forms.TextBox
	Public WithEvents txtMagnetic As System.Windows.Forms.TextBox
	Public WithEvents txtVariation As System.Windows.Forms.TextBox
	Public WithEvents txtTrue As System.Windows.Forms.TextBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblCompass As System.Windows.Forms.Label
	Public WithEvents lblDeviation As System.Windows.Forms.Label
	Public WithEvents lblMagnetic As System.Windows.Forms.Label
	Public WithEvents lblVariation As System.Windows.Forms.Label
	Public WithEvents lblTrue As System.Windows.Forms.Label
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form17))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdClear = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.optUp = New System.Windows.Forms.RadioButton
		Me.optDown = New System.Windows.Forms.RadioButton
		Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.txtEW = New System.Windows.Forms.TextBox
		Me.txtCorrVar = New System.Windows.Forms.TextBox
		Me.txtYI = New System.Windows.Forms.TextBox
		Me.cboCV = New System.Windows.Forms.ComboBox
		Me.cboD = New System.Windows.Forms.ComboBox
		Me.cboV = New System.Windows.Forms.ComboBox
		Me.cboIncDec = New System.Windows.Forms.ComboBox
		Me.txtChange = New System.Windows.Forms.TextBox
		Me.txtCY = New System.Windows.Forms.TextBox
		Me.txtCVMin = New System.Windows.Forms.TextBox
		Me.txtCVDeg = New System.Windows.Forms.TextBox
		Me.txtCompass = New System.Windows.Forms.TextBox
		Me.txtDeviation = New System.Windows.Forms.TextBox
		Me.txtMagnetic = New System.Windows.Forms.TextBox
		Me.txtVariation = New System.Windows.Forms.TextBox
		Me.txtTrue = New System.Windows.Forms.TextBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblCompass = New System.Windows.Forms.Label
		Me.lblDeviation = New System.Windows.Forms.Label
		Me.lblMagnetic = New System.Windows.Forms.Label
		Me.lblVariation = New System.Windows.Forms.Label
		Me.lblTrue = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "TVMDC"
		Me.ClientSize = New System.Drawing.Size(533, 206)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("Form17.Icon"), System.Drawing.Icon)
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
		Me.Name = "Form17"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
		Me.cmdPrint.Location = New System.Drawing.Point(512, 0)
		Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
		Me.cmdPrint.TabIndex = 41
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
		Me.cmdClear.Size = New System.Drawing.Size(65, 25)
		Me.cmdClear.Location = New System.Drawing.Point(120, 168)
		Me.cmdClear.TabIndex = 40
		Me.cmdClear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClear.CausesValidation = True
		Me.cmdClear.Enabled = True
		Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.TabStop = True
		Me.cmdClear.Name = "cmdClear"
		Me.Frame1.BackColor = System.Drawing.SystemColors.Window
		Me.Frame1.Text = "  Direction"
		Me.Frame1.Size = New System.Drawing.Size(65, 161)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 37
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.optUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optUp.BackColor = System.Drawing.SystemColors.Window
		Me.optUp.Size = New System.Drawing.Size(17, 13)
		Me.optUp.Location = New System.Drawing.Point(42, 16)
		Me.optUp.TabIndex = 39
		Me.optUp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optUp.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optUp.CausesValidation = True
		Me.optUp.Enabled = True
		Me.optUp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optUp.Cursor = System.Windows.Forms.Cursors.Default
		Me.optUp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optUp.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optUp.TabStop = True
		Me.optUp.Checked = False
		Me.optUp.Visible = True
		Me.optUp.Name = "optUp"
		Me.optDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optDown.BackColor = System.Drawing.SystemColors.Window
		Me.optDown.Size = New System.Drawing.Size(17, 13)
		Me.optDown.Location = New System.Drawing.Point(18, 16)
		Me.optDown.TabIndex = 38
		Me.optDown.Checked = True
		Me.optDown.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optDown.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optDown.CausesValidation = True
		Me.optDown.Enabled = True
		Me.optDown.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optDown.Cursor = System.Windows.Forms.Cursors.Default
		Me.optDown.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optDown.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optDown.TabStop = True
		Me.optDown.Visible = True
		Me.optDown.Name = "optDown"
		Me.Line7.X1 = 56
		Me.Line7.X2 = 48
		Me.Line7.Y1 = 27
		Me.Line7.Y2 = 19
		Me.Line7.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line7.BorderWidth = 1
		Me.Line7.Visible = True
		Me.Line7.Name = "Line7"
		Me.Line6.X1 = 40
		Me.Line6.X2 = 48
		Me.Line6.Y1 = 27
		Me.Line6.Y2 = 19
		Me.Line6.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line6.BorderWidth = 1
		Me.Line6.Visible = True
		Me.Line6.Name = "Line6"
		Me.Line5.X1 = 48
		Me.Line5.X2 = 48
		Me.Line5.Y1 = 19
		Me.Line5.Y2 = 131
		Me.Line5.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line5.BorderWidth = 1
		Me.Line5.Visible = True
		Me.Line5.Name = "Line5"
		Me.Line4.X1 = 16
		Me.Line4.X2 = 24
		Me.Line4.Y1 = 123
		Me.Line4.Y2 = 131
		Me.Line4.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line4.BorderWidth = 1
		Me.Line4.Visible = True
		Me.Line4.Name = "Line4"
		Me.Line3.X1 = 32
		Me.Line3.X2 = 24
		Me.Line3.Y1 = 123
		Me.Line3.Y2 = 131
		Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line3.BorderWidth = 1
		Me.Line3.Visible = True
		Me.Line3.Name = "Line3"
		Me.Line2.X1 = 24
		Me.Line2.X2 = 24
		Me.Line2.Y1 = 19
		Me.Line2.Y2 = 131
		Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line2.BorderWidth = 1
		Me.Line2.Visible = True
		Me.Line2.Name = "Line2"
		Me.txtEW.AutoSize = False
		Me.txtEW.BackColor = System.Drawing.Color.FromARGB(224, 224, 224)
		Me.txtEW.Size = New System.Drawing.Size(17, 19)
		Me.txtEW.Location = New System.Drawing.Point(392, 112)
		Me.txtEW.ReadOnly = True
		Me.txtEW.TabIndex = 35
		Me.txtEW.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEW.AcceptsReturn = True
		Me.txtEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEW.CausesValidation = True
		Me.txtEW.Enabled = True
		Me.txtEW.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEW.HideSelection = True
		Me.txtEW.Maxlength = 0
		Me.txtEW.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEW.MultiLine = False
		Me.txtEW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEW.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEW.TabStop = True
		Me.txtEW.Visible = True
		Me.txtEW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEW.Name = "txtEW"
		Me.txtCorrVar.AutoSize = False
		Me.txtCorrVar.BackColor = System.Drawing.Color.FromARGB(224, 224, 224)
		Me.txtCorrVar.Size = New System.Drawing.Size(33, 19)
		Me.txtCorrVar.Location = New System.Drawing.Point(352, 112)
		Me.txtCorrVar.ReadOnly = True
		Me.txtCorrVar.TabIndex = 33
		Me.txtCorrVar.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCorrVar.AcceptsReturn = True
		Me.txtCorrVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCorrVar.CausesValidation = True
		Me.txtCorrVar.Enabled = True
		Me.txtCorrVar.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCorrVar.HideSelection = True
		Me.txtCorrVar.Maxlength = 0
		Me.txtCorrVar.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCorrVar.MultiLine = False
		Me.txtCorrVar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCorrVar.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCorrVar.TabStop = True
		Me.txtCorrVar.Visible = True
		Me.txtCorrVar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCorrVar.Name = "txtCorrVar"
		Me.txtYI.AutoSize = False
		Me.txtYI.Size = New System.Drawing.Size(33, 19)
		Me.txtYI.Location = New System.Drawing.Point(328, 88)
		Me.txtYI.Maxlength = 4
		Me.txtYI.TabIndex = 31
		Me.ToolTip1.SetToolTip(Me.txtYI, "Limited to 4 digits")
		Me.txtYI.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtYI.AcceptsReturn = True
		Me.txtYI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtYI.BackColor = System.Drawing.SystemColors.Window
		Me.txtYI.CausesValidation = True
		Me.txtYI.Enabled = True
		Me.txtYI.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtYI.HideSelection = True
		Me.txtYI.ReadOnly = False
		Me.txtYI.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtYI.MultiLine = False
		Me.txtYI.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtYI.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtYI.TabStop = True
		Me.txtYI.Visible = True
		Me.txtYI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtYI.Name = "txtYI"
		Me.cboCV.Size = New System.Drawing.Size(41, 21)
		Me.cboCV.Location = New System.Drawing.Point(400, 40)
		Me.cboCV.Items.AddRange(New Object(){"W ", "E "})
		Me.cboCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCV.TabIndex = 29
		Me.cboCV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCV.BackColor = System.Drawing.SystemColors.Window
		Me.cboCV.CausesValidation = True
		Me.cboCV.Enabled = True
		Me.cboCV.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCV.IntegralHeight = True
		Me.cboCV.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCV.Sorted = False
		Me.cboCV.TabStop = True
		Me.cboCV.Visible = True
		Me.cboCV.Name = "cboCV"
		Me.cboD.Size = New System.Drawing.Size(41, 21)
		Me.cboD.Location = New System.Drawing.Point(176, 112)
		Me.cboD.Items.AddRange(New Object(){"W ", "E "})
		Me.cboD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboD.TabIndex = 28
		Me.cboD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboD.BackColor = System.Drawing.SystemColors.Window
		Me.cboD.CausesValidation = True
		Me.cboD.Enabled = True
		Me.cboD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboD.IntegralHeight = True
		Me.cboD.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboD.Sorted = False
		Me.cboD.TabStop = True
		Me.cboD.Visible = True
		Me.cboD.Name = "cboD"
		Me.cboV.Size = New System.Drawing.Size(41, 21)
		Me.cboV.Location = New System.Drawing.Point(176, 64)
		Me.cboV.Items.AddRange(New Object(){"W ", "E "})
		Me.cboV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboV.TabIndex = 27
		Me.cboV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboV.BackColor = System.Drawing.SystemColors.Window
		Me.cboV.CausesValidation = True
		Me.cboV.Enabled = True
		Me.cboV.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboV.IntegralHeight = True
		Me.cboV.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboV.Sorted = False
		Me.cboV.TabStop = True
		Me.cboV.Visible = True
		Me.cboV.Name = "cboV"
		Me.cboIncDec.Size = New System.Drawing.Size(81, 21)
		Me.cboIncDec.Location = New System.Drawing.Point(400, 64)
		Me.cboIncDec.Items.AddRange(New Object(){"Increasing", "Decreasing"})
		Me.cboIncDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboIncDec.TabIndex = 26
		Me.cboIncDec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboIncDec.BackColor = System.Drawing.SystemColors.Window
		Me.cboIncDec.CausesValidation = True
		Me.cboIncDec.Enabled = True
		Me.cboIncDec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboIncDec.IntegralHeight = True
		Me.cboIncDec.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboIncDec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboIncDec.Sorted = False
		Me.cboIncDec.TabStop = True
		Me.cboIncDec.Visible = True
		Me.cboIncDec.Name = "cboIncDec"
		Me.txtChange.AutoSize = False
		Me.txtChange.Size = New System.Drawing.Size(25, 19)
		Me.txtChange.Location = New System.Drawing.Point(368, 64)
		Me.txtChange.TabIndex = 24
		Me.ToolTip1.SetToolTip(Me.txtChange, "Range 0 to 59")
		Me.txtChange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtChange.AcceptsReturn = True
		Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtChange.BackColor = System.Drawing.SystemColors.Window
		Me.txtChange.CausesValidation = True
		Me.txtChange.Enabled = True
		Me.txtChange.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChange.HideSelection = True
		Me.txtChange.ReadOnly = False
		Me.txtChange.Maxlength = 0
		Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChange.MultiLine = False
		Me.txtChange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtChange.TabStop = True
		Me.txtChange.Visible = True
		Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChange.Name = "txtChange"
		Me.txtCY.AutoSize = False
		Me.txtCY.Size = New System.Drawing.Size(33, 19)
		Me.txtCY.Location = New System.Drawing.Point(488, 40)
		Me.txtCY.Maxlength = 4
		Me.txtCY.TabIndex = 22
		Me.ToolTip1.SetToolTip(Me.txtCY, "Limited to 4 digits")
		Me.txtCY.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCY.AcceptsReturn = True
		Me.txtCY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCY.BackColor = System.Drawing.SystemColors.Window
		Me.txtCY.CausesValidation = True
		Me.txtCY.Enabled = True
		Me.txtCY.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCY.HideSelection = True
		Me.txtCY.ReadOnly = False
		Me.txtCY.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCY.MultiLine = False
		Me.txtCY.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCY.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCY.TabStop = True
		Me.txtCY.Visible = True
		Me.txtCY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCY.Name = "txtCY"
		Me.txtCVMin.AutoSize = False
		Me.txtCVMin.Size = New System.Drawing.Size(25, 19)
		Me.txtCVMin.Location = New System.Drawing.Point(368, 40)
		Me.txtCVMin.Maxlength = 2
		Me.txtCVMin.TabIndex = 19
		Me.ToolTip1.SetToolTip(Me.txtCVMin, "Range 0 to 59")
		Me.txtCVMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCVMin.AcceptsReturn = True
		Me.txtCVMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCVMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtCVMin.CausesValidation = True
		Me.txtCVMin.Enabled = True
		Me.txtCVMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCVMin.HideSelection = True
		Me.txtCVMin.ReadOnly = False
		Me.txtCVMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCVMin.MultiLine = False
		Me.txtCVMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCVMin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCVMin.TabStop = True
		Me.txtCVMin.Visible = True
		Me.txtCVMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCVMin.Name = "txtCVMin"
		Me.txtCVDeg.AutoSize = False
		Me.txtCVDeg.Size = New System.Drawing.Size(25, 19)
		Me.txtCVDeg.Location = New System.Drawing.Point(336, 40)
		Me.txtCVDeg.Maxlength = 2
		Me.txtCVDeg.TabIndex = 17
		Me.ToolTip1.SetToolTip(Me.txtCVDeg, "Range 0 to 99")
		Me.txtCVDeg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCVDeg.AcceptsReturn = True
		Me.txtCVDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCVDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtCVDeg.CausesValidation = True
		Me.txtCVDeg.Enabled = True
		Me.txtCVDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCVDeg.HideSelection = True
		Me.txtCVDeg.ReadOnly = False
		Me.txtCVDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCVDeg.MultiLine = False
		Me.txtCVDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCVDeg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCVDeg.TabStop = True
		Me.txtCVDeg.Visible = True
		Me.txtCVDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCVDeg.Name = "txtCVDeg"
		Me.txtCompass.AutoSize = False
		Me.txtCompass.Size = New System.Drawing.Size(33, 19)
		Me.txtCompass.Location = New System.Drawing.Point(136, 136)
		Me.txtCompass.Maxlength = 3
		Me.txtCompass.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.txtCompass, "Range 0 to 359")
		Me.txtCompass.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCompass.AcceptsReturn = True
		Me.txtCompass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCompass.BackColor = System.Drawing.SystemColors.Window
		Me.txtCompass.CausesValidation = True
		Me.txtCompass.Enabled = True
		Me.txtCompass.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCompass.HideSelection = True
		Me.txtCompass.ReadOnly = False
		Me.txtCompass.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCompass.MultiLine = False
		Me.txtCompass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCompass.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCompass.TabStop = True
		Me.txtCompass.Visible = True
		Me.txtCompass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCompass.Name = "txtCompass"
		Me.txtDeviation.AutoSize = False
		Me.txtDeviation.Size = New System.Drawing.Size(17, 19)
		Me.txtDeviation.Location = New System.Drawing.Point(152, 112)
		Me.txtDeviation.Maxlength = 1
		Me.txtDeviation.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.txtDeviation, "Range 0 to 9")
		Me.txtDeviation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDeviation.AcceptsReturn = True
		Me.txtDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDeviation.BackColor = System.Drawing.SystemColors.Window
		Me.txtDeviation.CausesValidation = True
		Me.txtDeviation.Enabled = True
		Me.txtDeviation.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDeviation.HideSelection = True
		Me.txtDeviation.ReadOnly = False
		Me.txtDeviation.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDeviation.MultiLine = False
		Me.txtDeviation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDeviation.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDeviation.TabStop = True
		Me.txtDeviation.Visible = True
		Me.txtDeviation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDeviation.Name = "txtDeviation"
		Me.txtMagnetic.AutoSize = False
		Me.txtMagnetic.Size = New System.Drawing.Size(33, 19)
		Me.txtMagnetic.Location = New System.Drawing.Point(136, 88)
		Me.txtMagnetic.Maxlength = 3
		Me.txtMagnetic.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.txtMagnetic, "Range 0 to 359")
		Me.txtMagnetic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMagnetic.AcceptsReturn = True
		Me.txtMagnetic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMagnetic.BackColor = System.Drawing.SystemColors.Window
		Me.txtMagnetic.CausesValidation = True
		Me.txtMagnetic.Enabled = True
		Me.txtMagnetic.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMagnetic.HideSelection = True
		Me.txtMagnetic.ReadOnly = False
		Me.txtMagnetic.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMagnetic.MultiLine = False
		Me.txtMagnetic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMagnetic.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMagnetic.TabStop = True
		Me.txtMagnetic.Visible = True
		Me.txtMagnetic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMagnetic.Name = "txtMagnetic"
		Me.txtVariation.AutoSize = False
		Me.txtVariation.Size = New System.Drawing.Size(25, 19)
		Me.txtVariation.Location = New System.Drawing.Point(144, 64)
		Me.txtVariation.Maxlength = 2
		Me.txtVariation.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.txtVariation, "Range 0 to 99")
		Me.txtVariation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVariation.AcceptsReturn = True
		Me.txtVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVariation.BackColor = System.Drawing.SystemColors.Window
		Me.txtVariation.CausesValidation = True
		Me.txtVariation.Enabled = True
		Me.txtVariation.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVariation.HideSelection = True
		Me.txtVariation.ReadOnly = False
		Me.txtVariation.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVariation.MultiLine = False
		Me.txtVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVariation.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVariation.TabStop = True
		Me.txtVariation.Visible = True
		Me.txtVariation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVariation.Name = "txtVariation"
		Me.txtTrue.AutoSize = False
		Me.txtTrue.Size = New System.Drawing.Size(33, 19)
		Me.txtTrue.Location = New System.Drawing.Point(136, 40)
		Me.txtTrue.Maxlength = 3
		Me.txtTrue.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.txtTrue, "Range 0 to 359")
		Me.txtTrue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTrue.AcceptsReturn = True
		Me.txtTrue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTrue.BackColor = System.Drawing.SystemColors.Window
		Me.txtTrue.CausesValidation = True
		Me.txtTrue.Enabled = True
		Me.txtTrue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTrue.HideSelection = True
		Me.txtTrue.ReadOnly = False
		Me.txtTrue.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTrue.MultiLine = False
		Me.txtTrue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTrue.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTrue.TabStop = True
		Me.txtTrue.Visible = True
		Me.txtTrue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTrue.Name = "txtTrue"
		Me.Label16.BackColor = System.Drawing.SystemColors.Window
		Me.Label16.Text = "(rounded to whole degrees)"
		Me.Label16.Size = New System.Drawing.Size(137, 17)
		Me.Label16.Location = New System.Drawing.Point(248, 128)
		Me.Label16.TabIndex = 36
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label15.BackColor = System.Drawing.SystemColors.Window
		Me.Label15.Text = "°"
		Me.Label15.Size = New System.Drawing.Size(9, 17)
		Me.Label15.Location = New System.Drawing.Point(385, 112)
		Me.Label15.TabIndex = 34
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
		Me.Label14.Text = "Corrected Variation"
		Me.Label14.Size = New System.Drawing.Size(97, 17)
		Me.Label14.Location = New System.Drawing.Point(248, 112)
		Me.Label14.TabIndex = 32
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
		Me.Label13.BackColor = System.Drawing.SystemColors.Window
		Me.Label13.Text = "Year of Interest"
		Me.Label13.Size = New System.Drawing.Size(81, 17)
		Me.Label13.Location = New System.Drawing.Point(248, 88)
		Me.Label13.TabIndex = 30
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
		Me.Label12.Text = "'"
		Me.Label12.Size = New System.Drawing.Size(9, 17)
		Me.Label12.Location = New System.Drawing.Point(393, 64)
		Me.Label12.TabIndex = 25
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label11.Text = "Annual Change"
		Me.Label11.Size = New System.Drawing.Size(81, 17)
		Me.Label11.Location = New System.Drawing.Point(248, 64)
		Me.Label11.TabIndex = 23
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
		Me.Label10.Text = "Year"
		Me.Label10.Size = New System.Drawing.Size(25, 17)
		Me.Label10.Location = New System.Drawing.Point(456, 40)
		Me.Label10.TabIndex = 21
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
		Me.Label9.Size = New System.Drawing.Size(9, 17)
		Me.Label9.Location = New System.Drawing.Point(393, 40)
		Me.Label9.TabIndex = 20
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
		Me.Label8.Location = New System.Drawing.Point(361, 40)
		Me.Label8.TabIndex = 18
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
		Me.Label7.Text = "Chart Variation"
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.Location = New System.Drawing.Point(248, 40)
		Me.Label7.TabIndex = 16
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
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Chart Data"
		Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Size = New System.Drawing.Size(57, 17)
		Me.Label6.Location = New System.Drawing.Point(352, 8)
		Me.Label6.TabIndex = 15
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
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 240
		Me.Line1.X2 = 240
		Me.Line1.Y1 = 0
		Me.Line1.Y2 = 208
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "°"
		Me.Label5.Size = New System.Drawing.Size(9, 17)
		Me.Label5.Location = New System.Drawing.Point(169, 136)
		Me.Label5.TabIndex = 14
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
		Me.Label4.Text = "°"
		Me.Label4.Size = New System.Drawing.Size(9, 17)
		Me.Label4.Location = New System.Drawing.Point(169, 112)
		Me.Label4.TabIndex = 13
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
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "°"
		Me.Label3.Size = New System.Drawing.Size(9, 17)
		Me.Label3.Location = New System.Drawing.Point(169, 88)
		Me.Label3.TabIndex = 12
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
		Me.Label2.Text = "°"
		Me.Label2.Size = New System.Drawing.Size(9, 17)
		Me.Label2.Location = New System.Drawing.Point(169, 64)
		Me.Label2.TabIndex = 11
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
		Me.Label1.Text = "°"
		Me.Label1.Size = New System.Drawing.Size(9, 17)
		Me.Label1.Location = New System.Drawing.Point(169, 40)
		Me.Label1.TabIndex = 10
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
		Me.lblCompass.BackColor = System.Drawing.SystemColors.Window
		Me.lblCompass.Text = "Compass"
		Me.lblCompass.Size = New System.Drawing.Size(49, 17)
		Me.lblCompass.Location = New System.Drawing.Point(80, 136)
		Me.lblCompass.TabIndex = 4
		Me.lblCompass.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCompass.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCompass.Enabled = True
		Me.lblCompass.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCompass.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCompass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCompass.UseMnemonic = True
		Me.lblCompass.Visible = True
		Me.lblCompass.AutoSize = False
		Me.lblCompass.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCompass.Name = "lblCompass"
		Me.lblDeviation.BackColor = System.Drawing.SystemColors.Window
		Me.lblDeviation.Text = "Deviation"
		Me.lblDeviation.Size = New System.Drawing.Size(49, 17)
		Me.lblDeviation.Location = New System.Drawing.Point(80, 112)
		Me.lblDeviation.TabIndex = 3
		Me.lblDeviation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDeviation.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDeviation.Enabled = True
		Me.lblDeviation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDeviation.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDeviation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDeviation.UseMnemonic = True
		Me.lblDeviation.Visible = True
		Me.lblDeviation.AutoSize = False
		Me.lblDeviation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDeviation.Name = "lblDeviation"
		Me.lblMagnetic.BackColor = System.Drawing.SystemColors.Window
		Me.lblMagnetic.Text = "Magnetic"
		Me.lblMagnetic.Size = New System.Drawing.Size(49, 17)
		Me.lblMagnetic.Location = New System.Drawing.Point(80, 88)
		Me.lblMagnetic.TabIndex = 2
		Me.lblMagnetic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMagnetic.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMagnetic.Enabled = True
		Me.lblMagnetic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMagnetic.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMagnetic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMagnetic.UseMnemonic = True
		Me.lblMagnetic.Visible = True
		Me.lblMagnetic.AutoSize = False
		Me.lblMagnetic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMagnetic.Name = "lblMagnetic"
		Me.lblVariation.BackColor = System.Drawing.SystemColors.Window
		Me.lblVariation.Text = "Variation"
		Me.lblVariation.Size = New System.Drawing.Size(49, 17)
		Me.lblVariation.Location = New System.Drawing.Point(80, 64)
		Me.lblVariation.TabIndex = 1
		Me.lblVariation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVariation.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVariation.Enabled = True
		Me.lblVariation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVariation.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVariation.UseMnemonic = True
		Me.lblVariation.Visible = True
		Me.lblVariation.AutoSize = False
		Me.lblVariation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVariation.Name = "lblVariation"
		Me.lblTrue.BackColor = System.Drawing.SystemColors.Window
		Me.lblTrue.Text = "True"
		Me.lblTrue.Size = New System.Drawing.Size(25, 17)
		Me.lblTrue.Location = New System.Drawing.Point(80, 40)
		Me.lblTrue.TabIndex = 0
		Me.lblTrue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrue.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTrue.Enabled = True
		Me.lblTrue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTrue.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTrue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTrue.UseMnemonic = True
		Me.lblTrue.Visible = True
		Me.lblTrue.AutoSize = False
		Me.lblTrue.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTrue.Name = "lblTrue"
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(txtEW)
		Me.Controls.Add(txtCorrVar)
		Me.Controls.Add(txtYI)
		Me.Controls.Add(cboCV)
		Me.Controls.Add(cboD)
		Me.Controls.Add(cboV)
		Me.Controls.Add(cboIncDec)
		Me.Controls.Add(txtChange)
		Me.Controls.Add(txtCY)
		Me.Controls.Add(txtCVMin)
		Me.Controls.Add(txtCVDeg)
		Me.Controls.Add(txtCompass)
		Me.Controls.Add(txtDeviation)
		Me.Controls.Add(txtMagnetic)
		Me.Controls.Add(txtVariation)
		Me.Controls.Add(txtTrue)
		Me.Controls.Add(Label16)
		Me.Controls.Add(Label15)
		Me.Controls.Add(Label14)
		Me.Controls.Add(Label13)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblCompass)
		Me.Controls.Add(lblDeviation)
		Me.Controls.Add(lblMagnetic)
		Me.Controls.Add(lblVariation)
		Me.Controls.Add(lblTrue)
		Me.Controls.Add(ShapeContainer1)
		Me.Frame1.Controls.Add(optUp)
		Me.Frame1.Controls.Add(optDown)
		Me.ShapeContainer2.Shapes.Add(Line7)
		Me.ShapeContainer2.Shapes.Add(Line6)
		Me.ShapeContainer2.Shapes.Add(Line5)
		Me.ShapeContainer2.Shapes.Add(Line4)
		Me.ShapeContainer2.Shapes.Add(Line3)
		Me.ShapeContainer2.Shapes.Add(Line2)
		Me.Frame1.Controls.Add(ShapeContainer2)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class