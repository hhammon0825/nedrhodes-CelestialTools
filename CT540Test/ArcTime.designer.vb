<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form10
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
	Public WithEvents txtTime2 As System.Windows.Forms.TextBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents optZTtoLMT As System.Windows.Forms.RadioButton
	Public WithEvents optLMTtoZT As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdConvert As System.Windows.Forms.Button
	Public WithEvents txtDeg As System.Windows.Forms.TextBox
	Public WithEvents txtMin As System.Windows.Forms.TextBox
	Public WithEvents txtTime As System.Windows.Forms.TextBox
	Public WithEvents optTimeToArc As System.Windows.Forms.RadioButton
	Public WithEvents optArcToTime As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblZT As System.Windows.Forms.Label
	Public WithEvents lblLMT As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblArc As System.Windows.Forms.Label
	Public WithEvents lblDeg As System.Windows.Forms.Label
	Public WithEvents lblMin As System.Windows.Forms.Label
	Public WithEvents lblTime As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtDeg = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblArc = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.optZTtoLMT = New System.Windows.Forms.RadioButton()
        Me.optLMTtoZT = New System.Windows.Forms.RadioButton()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optTimeToArc = New System.Windows.Forms.RadioButton()
        Me.optArcToTime = New System.Windows.Forms.RadioButton()
        Me.lblZT = New System.Windows.Forms.Label()
        Me.lblLMT = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeg = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtArcTime = New System.Windows.Forms.TextBox()
        Me.txtLMTZT = New System.Windows.Forms.TextBox()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTime2
        '
        Me.txtTime2.AcceptsReturn = True
        Me.txtTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime2.Location = New System.Drawing.Point(352, 88)
        Me.txtTime2.MaxLength = 6
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime2.Size = New System.Drawing.Size(49, 19)
        Me.txtTime2.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtTime2, "Range 000000 to 235959")
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(344, 64)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 19)
        Me.txtLoMin.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(304, 64)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 19)
        Me.txtLoDeg.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(446, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 23
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtDeg
        '
        Me.txtDeg.AcceptsReturn = True
        Me.txtDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg.Location = New System.Drawing.Point(88, 64)
        Me.txtDeg.MaxLength = 3
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg.Size = New System.Drawing.Size(33, 19)
        Me.txtDeg.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDeg, "Range 0 to 359")
        '
        'txtMin
        '
        Me.txtMin.AcceptsReturn = True
        Me.txtMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin.Location = New System.Drawing.Point(128, 64)
        Me.txtMin.MaxLength = 4
        Me.txtMin.Name = "txtMin"
        Me.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin.Size = New System.Drawing.Size(33, 19)
        Me.txtMin.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtMin, "Range 0 to 59.9")
        '
        'txtTime
        '
        Me.txtTime.AcceptsReturn = True
        Me.txtTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime.Location = New System.Drawing.Point(128, 64)
        Me.txtTime.MaxLength = 6
        Me.txtTime.Name = "txtTime"
        Me.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime.Size = New System.Drawing.Size(49, 19)
        Me.txtTime.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtTime, "Range 000000 to 235959")
        Me.txtTime.Visible = False
        '
        'lblArc
        '
        Me.lblArc.BackColor = System.Drawing.SystemColors.Window
        Me.lblArc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblArc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArc.Location = New System.Drawing.Point(56, 64)
        Me.lblArc.Name = "lblArc"
        Me.lblArc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArc.Size = New System.Drawing.Size(17, 17)
        Me.lblArc.TabIndex = 9
        Me.lblArc.Text = "Arc"
        Me.ToolTip1.SetToolTip(Me.lblArc, "Sextant Altitude")
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.Location = New System.Drawing.Point(48, 64)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(73, 17)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Time (hhmmss)"
        Me.ToolTip1.SetToolTip(Me.lblTime, "Watch Time")
        Me.lblTime.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line2, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(465, 185)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'Line2
        '
        Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line2.Name = "Line2"
        Me.Line2.X1 = 464
        Me.Line2.X2 = 0
        Me.Line2.Y1 = 112
        Me.Line2.Y2 = 112
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line1.BorderWidth = 2
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 232
        Me.Line1.X2 = 232
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 147
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W ", "E "})
        Me.cboLo.Location = New System.Drawing.Point(384, 64)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 17
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Window
        Me.Frame2.Controls.Add(Me.optZTtoLMT)
        Me.Frame2.Controls.Add(Me.optLMTtoZT)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(256, 16)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(185, 41)
        Me.Frame2.TabIndex = 10
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Convert"
        '
        'optZTtoLMT
        '
        Me.optZTtoLMT.BackColor = System.Drawing.SystemColors.Window
        Me.optZTtoLMT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZTtoLMT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZTtoLMT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZTtoLMT.Location = New System.Drawing.Point(96, 16)
        Me.optZTtoLMT.Name = "optZTtoLMT"
        Me.optZTtoLMT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZTtoLMT.Size = New System.Drawing.Size(73, 17)
        Me.optZTtoLMT.TabIndex = 12
        Me.optZTtoLMT.TabStop = True
        Me.optZTtoLMT.Text = "ZT to LMT"
        Me.optZTtoLMT.UseVisualStyleBackColor = False
        '
        'optLMTtoZT
        '
        Me.optLMTtoZT.BackColor = System.Drawing.SystemColors.Window
        Me.optLMTtoZT.Checked = True
        Me.optLMTtoZT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLMTtoZT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLMTtoZT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLMTtoZT.Location = New System.Drawing.Point(8, 16)
        Me.optLMTtoZT.Name = "optLMTtoZT"
        Me.optLMTtoZT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLMTtoZT.Size = New System.Drawing.Size(73, 17)
        Me.optLMTtoZT.TabIndex = 11
        Me.optLMTtoZT.TabStop = True
        Me.optLMTtoZT.Text = "LMT to ZT"
        Me.optLMTtoZT.UseVisualStyleBackColor = False
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvert.Location = New System.Drawing.Point(176, 159)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvert.Size = New System.Drawing.Size(113, 25)
        Me.cmdConvert.TabIndex = 22
        Me.cmdConvert.Text = "&Convert"
        Me.cmdConvert.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optTimeToArc)
        Me.Frame1.Controls.Add(Me.optArcToTime)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(24, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(185, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Convert"
        '
        'optTimeToArc
        '
        Me.optTimeToArc.BackColor = System.Drawing.SystemColors.Window
        Me.optTimeToArc.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTimeToArc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTimeToArc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTimeToArc.Location = New System.Drawing.Point(96, 16)
        Me.optTimeToArc.Name = "optTimeToArc"
        Me.optTimeToArc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTimeToArc.Size = New System.Drawing.Size(81, 17)
        Me.optTimeToArc.TabIndex = 2
        Me.optTimeToArc.TabStop = True
        Me.optTimeToArc.Text = "Time to Arc"
        Me.optTimeToArc.UseVisualStyleBackColor = False
        '
        'optArcToTime
        '
        Me.optArcToTime.BackColor = System.Drawing.SystemColors.Window
        Me.optArcToTime.Checked = True
        Me.optArcToTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.optArcToTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optArcToTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optArcToTime.Location = New System.Drawing.Point(8, 16)
        Me.optArcToTime.Name = "optArcToTime"
        Me.optArcToTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optArcToTime.Size = New System.Drawing.Size(81, 17)
        Me.optArcToTime.TabIndex = 1
        Me.optArcToTime.TabStop = True
        Me.optArcToTime.Text = "Arc to Time"
        Me.optArcToTime.UseVisualStyleBackColor = False
        '
        'lblZT
        '
        Me.lblZT.BackColor = System.Drawing.SystemColors.Window
        Me.lblZT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZT.Location = New System.Drawing.Point(272, 88)
        Me.lblZT.Name = "lblZT"
        Me.lblZT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZT.Size = New System.Drawing.Size(73, 17)
        Me.lblZT.TabIndex = 21
        Me.lblZT.Text = "ZT (hhmmss)"
        Me.lblZT.Visible = False
        '
        'lblLMT
        '
        Me.lblLMT.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMT.Location = New System.Drawing.Point(272, 88)
        Me.lblLMT.Name = "lblLMT"
        Me.lblLMT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMT.Size = New System.Drawing.Size(73, 17)
        Me.lblLMT.TabIndex = 20
        Me.lblLMT.Text = "LMT (hhmmss)"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(377, 64)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 18
        Me.lblLoMin.Text = "'"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(337, 64)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 16
        Me.lblLoDeg.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(272, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Lo"
        '
        'lblDeg
        '
        Me.lblDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDeg.Location = New System.Drawing.Point(121, 64)
        Me.lblDeg.Name = "lblDeg"
        Me.lblDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblDeg.TabIndex = 8
        Me.lblDeg.Text = "°"
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMin.Location = New System.Drawing.Point(161, 64)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMin.Size = New System.Drawing.Size(9, 17)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "'"
        '
        'txtArcTime
        '
        Me.txtArcTime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArcTime.Location = New System.Drawing.Point(2, 115)
        Me.txtArcTime.Multiline = True
        Me.txtArcTime.Name = "txtArcTime"
        Me.txtArcTime.ReadOnly = True
        Me.txtArcTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArcTime.Size = New System.Drawing.Size(226, 45)
        Me.txtArcTime.TabIndex = 25
        Me.txtArcTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLMTZT
        '
        Me.txtLMTZT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMTZT.Location = New System.Drawing.Point(237, 115)
        Me.txtLMTZT.Multiline = True
        Me.txtLMTZT.Name = "txtLMTZT"
        Me.txtLMTZT.ReadOnly = True
        Me.txtLMTZT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLMTZT.Size = New System.Drawing.Size(226, 45)
        Me.txtLMTZT.TabIndex = 26
        Me.txtLMTZT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(465, 185)
        Me.Controls.Add(Me.txtLMTZT)
        Me.Controls.Add(Me.txtArcTime)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.txtDeg)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblZT)
        Me.Controls.Add(Me.lblLMT)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblArc)
        Me.Controls.Add(Me.lblDeg)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(285, 99)
        Me.MaximizeBox = False
        Me.Name = "Form10"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arc-Time, LMT-ZT Conversion"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArcTime As TextBox
    Friend WithEvents txtLMTZT As TextBox
#End Region
End Class