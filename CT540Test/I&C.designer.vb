<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form19
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
	Public WithEvents txtMin As System.Windows.Forms.TextBox
	Public WithEvents txtDeg As System.Windows.Forms.TextBox
	Public WithEvents optBack As System.Windows.Forms.RadioButton
	Public WithEvents optFwd As System.Windows.Forms.RadioButton
	Public WithEvents frameFwdBack As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents optMoon As System.Windows.Forms.RadioButton
	Public WithEvents optAries As System.Windows.Forms.RadioButton
	Public WithEvents optSunPlanets As System.Windows.Forms.RadioButton
	Public WithEvents frameSelect As System.Windows.Forms.GroupBox
	Public WithEvents txtvd As System.Windows.Forms.TextBox
	Public WithEvents txtUTs As System.Windows.Forms.TextBox
	Public WithEvents txtUTm As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form19))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtDeg = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtvd = New System.Windows.Forms.TextBox()
        Me.txtUTs = New System.Windows.Forms.TextBox()
        Me.txtUTm = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.frameFwdBack = New System.Windows.Forms.GroupBox()
        Me.optBack = New System.Windows.Forms.RadioButton()
        Me.optFwd = New System.Windows.Forms.RadioButton()
        Me.frameSelect = New System.Windows.Forms.GroupBox()
        Me.optMoon = New System.Windows.Forms.RadioButton()
        Me.optAries = New System.Windows.Forms.RadioButton()
        Me.optSunPlanets = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.frameFwdBack.SuspendLayout()
        Me.frameSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMin
        '
        Me.txtMin.AcceptsReturn = True
        Me.txtMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin.Location = New System.Drawing.Point(168, 96)
        Me.txtMin.MaxLength = 4
        Me.txtMin.Name = "txtMin"
        Me.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin.Size = New System.Drawing.Size(33, 19)
        Me.txtMin.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txtMin, "Range 0 to 59.9")
        Me.txtMin.Visible = False
        '
        'txtDeg
        '
        Me.txtDeg.AcceptsReturn = True
        Me.txtDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg.Location = New System.Drawing.Point(128, 96)
        Me.txtDeg.MaxLength = 2
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg.Size = New System.Drawing.Size(25, 19)
        Me.txtDeg.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtDeg, "Range 0 to 15 for Sun/Planets, Aries; 0 to 14 for Moon")
        Me.txtDeg.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(288, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 13
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtvd
        '
        Me.txtvd.AcceptsReturn = True
        Me.txtvd.BackColor = System.Drawing.SystemColors.Window
        Me.txtvd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtvd.Location = New System.Drawing.Point(128, 128)
        Me.txtvd.MaxLength = 4
        Me.txtvd.Name = "txtvd"
        Me.txtvd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtvd.Size = New System.Drawing.Size(33, 19)
        Me.txtvd.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtvd, "Range 0 to 18.0")
        '
        'txtUTs
        '
        Me.txtUTs.AcceptsReturn = True
        Me.txtUTs.BackColor = System.Drawing.SystemColors.Window
        Me.txtUTs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUTs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUTs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUTs.Location = New System.Drawing.Point(168, 96)
        Me.txtUTs.MaxLength = 2
        Me.txtUTs.Name = "txtUTs"
        Me.txtUTs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUTs.Size = New System.Drawing.Size(25, 19)
        Me.txtUTs.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtUTs, "Range 0 to 60")
        '
        'txtUTm
        '
        Me.txtUTm.AcceptsReturn = True
        Me.txtUTm.BackColor = System.Drawing.SystemColors.Window
        Me.txtUTm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUTm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUTm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUTm.Location = New System.Drawing.Point(128, 96)
        Me.txtUTm.MaxLength = 2
        Me.txtUTm.Name = "txtUTm"
        Me.txtUTm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUTm.Size = New System.Drawing.Size(25, 19)
        Me.txtUTm.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtUTm, "Range 0 to 59")
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(309, 202)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 0
        Me.Line1.X2 = 312
        Me.Line1.Y1 = 152
        Me.Line1.Y2 = 152
        '
        'frameFwdBack
        '
        Me.frameFwdBack.BackColor = System.Drawing.SystemColors.Window
        Me.frameFwdBack.Controls.Add(Me.optBack)
        Me.frameFwdBack.Controls.Add(Me.optFwd)
        Me.frameFwdBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameFwdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameFwdBack.Location = New System.Drawing.Point(56, 8)
        Me.frameFwdBack.Name = "frameFwdBack"
        Me.frameFwdBack.Padding = New System.Windows.Forms.Padding(0)
        Me.frameFwdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameFwdBack.Size = New System.Drawing.Size(193, 41)
        Me.frameFwdBack.TabIndex = 14
        Me.frameFwdBack.TabStop = False
        Me.frameFwdBack.Text = "Enter table"
        '
        'optBack
        '
        Me.optBack.BackColor = System.Drawing.SystemColors.Window
        Me.optBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optBack.Location = New System.Drawing.Point(96, 16)
        Me.optBack.Name = "optBack"
        Me.optBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBack.Size = New System.Drawing.Size(87, 17)
        Me.optBack.TabIndex = 16
        Me.optBack.TabStop = True
        Me.optBack.Text = """Backwards"""
        Me.optBack.UseVisualStyleBackColor = False
        '
        'optFwd
        '
        Me.optFwd.BackColor = System.Drawing.SystemColors.Window
        Me.optFwd.Checked = True
        Me.optFwd.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFwd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFwd.Location = New System.Drawing.Point(8, 16)
        Me.optFwd.Name = "optFwd"
        Me.optFwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFwd.Size = New System.Drawing.Size(81, 17)
        Me.optFwd.TabIndex = 15
        Me.optFwd.TabStop = True
        Me.optFwd.Text = """Forwards"""
        Me.optFwd.UseVisualStyleBackColor = False
        '
        'frameSelect
        '
        Me.frameSelect.BackColor = System.Drawing.SystemColors.Window
        Me.frameSelect.Controls.Add(Me.optMoon)
        Me.frameSelect.Controls.Add(Me.optAries)
        Me.frameSelect.Controls.Add(Me.optSunPlanets)
        Me.frameSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameSelect.Location = New System.Drawing.Point(24, 48)
        Me.frameSelect.Name = "frameSelect"
        Me.frameSelect.Padding = New System.Windows.Forms.Padding(0)
        Me.frameSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameSelect.Size = New System.Drawing.Size(265, 41)
        Me.frameSelect.TabIndex = 9
        Me.frameSelect.TabStop = False
        Me.frameSelect.Text = "Select object"
        '
        'optMoon
        '
        Me.optMoon.BackColor = System.Drawing.SystemColors.Window
        Me.optMoon.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMoon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMoon.Location = New System.Drawing.Point(192, 16)
        Me.optMoon.Name = "optMoon"
        Me.optMoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMoon.Size = New System.Drawing.Size(65, 17)
        Me.optMoon.TabIndex = 12
        Me.optMoon.TabStop = True
        Me.optMoon.Text = "Moon"
        Me.optMoon.UseVisualStyleBackColor = False
        '
        'optAries
        '
        Me.optAries.BackColor = System.Drawing.SystemColors.Window
        Me.optAries.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAries.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAries.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAries.Location = New System.Drawing.Point(120, 16)
        Me.optAries.Name = "optAries"
        Me.optAries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAries.Size = New System.Drawing.Size(65, 17)
        Me.optAries.TabIndex = 11
        Me.optAries.TabStop = True
        Me.optAries.Text = "Aries"
        Me.optAries.UseVisualStyleBackColor = False
        '
        'optSunPlanets
        '
        Me.optSunPlanets.BackColor = System.Drawing.SystemColors.Window
        Me.optSunPlanets.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSunPlanets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSunPlanets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSunPlanets.Location = New System.Drawing.Point(16, 16)
        Me.optSunPlanets.Name = "optSunPlanets"
        Me.optSunPlanets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSunPlanets.Size = New System.Drawing.Size(81, 13)
        Me.optSunPlanets.TabIndex = 10
        Me.optSunPlanets.TabStop = True
        Me.optSunPlanets.Text = "Sun/Planets"
        Me.optSunPlanets.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(48, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "GHA Increment"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(201, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "'"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(153, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(9, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "°"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(161, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "'"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(170, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(from daily pages)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(88, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "v or d"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(193, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "s"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(153, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "m"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(104, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UT"
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(0, 155)
        Me.txtIC.Multiline = True
        Me.txtIC.Name = "txtIC"
        Me.txtIC.ReadOnly = True
        Me.txtIC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIC.Size = New System.Drawing.Size(308, 46)
        Me.txtIC.TabIndex = 23
        Me.txtIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(309, 202)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtDeg)
        Me.Controls.Add(Me.frameFwdBack)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.frameSelect)
        Me.Controls.Add(Me.txtvd)
        Me.Controls.Add(Me.txtUTs)
        Me.Controls.Add(Me.txtUTm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "Form19"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Increments and Corrections"
        Me.frameFwdBack.ResumeLayout(False)
        Me.frameSelect.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIC As TextBox
#End Region
End Class