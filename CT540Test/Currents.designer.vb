<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form24
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
	Public WithEvents txtSetEbb As System.Windows.Forms.TextBox
	Public WithEvents txtSetFlood As System.Windows.Forms.TextBox
	Public WithEvents chkE As System.Windows.Forms.CheckBox
	Public WithEvents chkSBE As System.Windows.Forms.CheckBox
	Public WithEvents chkF As System.Windows.Forms.CheckBox
	Public WithEvents chkSBF As System.Windows.Forms.CheckBox
	Public WithEvents txtTimeSlackBeforeEbb As System.Windows.Forms.TextBox
	Public WithEvents txtTimeSlackBeforeFlood As System.Windows.Forms.TextBox
	Public WithEvents txtTab2SlackFHour As System.Windows.Forms.TextBox
	Public WithEvents txtTab2SlackFMin As System.Windows.Forms.TextBox
	Public WithEvents txtTab2SlackEHour As System.Windows.Forms.TextBox
	Public WithEvents txtTab2SlackEMin As System.Windows.Forms.TextBox
	Public WithEvents txtLocation As System.Windows.Forms.TextBox
	Public WithEvents txtLocNo As System.Windows.Forms.TextBox
	Public WithEvents txtDesTime As System.Windows.Forms.TextBox
	Public WithEvents cboDay As System.Windows.Forms.ComboBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents cboMonth As System.Windows.Forms.ComboBox
	Public WithEvents txtRefSta As System.Windows.Forms.TextBox
	Public WithEvents txtTimeFlood As System.Windows.Forms.TextBox
	Public WithEvents txtVelFlood As System.Windows.Forms.TextBox
	Public WithEvents txtTimeEbb As System.Windows.Forms.TextBox
	Public WithEvents txtVelEbb As System.Windows.Forms.TextBox
	Public WithEvents txtTab2Diff As System.Windows.Forms.TextBox
	Public WithEvents txtSubStaNo As System.Windows.Forms.TextBox
	Public WithEvents txtTab2FloodHour As System.Windows.Forms.TextBox
	Public WithEvents txtTab2FloodMin As System.Windows.Forms.TextBox
	Public WithEvents txtTab2FloodMult As System.Windows.Forms.TextBox
	Public WithEvents txtTab2EbbHour As System.Windows.Forms.TextBox
	Public WithEvents txtTab2EbbMin As System.Windows.Forms.TextBox
	Public WithEvents txtTab2EbbMult As System.Windows.Forms.TextBox
	Public WithEvents cmdCurrents As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents optRule As System.Windows.Forms.RadioButton
	Public WithEvents optB As System.Windows.Forms.RadioButton
	Public WithEvents optA As System.Windows.Forms.RadioButton
	Public WithEvents optCalc As System.Windows.Forms.RadioButton
	Public WithEvents Line13 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Line12 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Line11 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents lblLocation As System.Windows.Forms.Label
	Public WithEvents lblLocNumber As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblDesTime As System.Windows.Forms.Label
	Public WithEvents lblYear As System.Windows.Forms.Label
	Public WithEvents lblMonth As System.Windows.Forms.Label
	Public WithEvents lblDay As System.Windows.Forms.Label
	Public WithEvents lblDate As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form24))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTimeSlackBeforeEbb = New System.Windows.Forms.TextBox()
        Me.txtTimeSlackBeforeFlood = New System.Windows.Forms.TextBox()
        Me.txtTab2SlackFMin = New System.Windows.Forms.TextBox()
        Me.txtTab2SlackEMin = New System.Windows.Forms.TextBox()
        Me.txtDesTime = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTimeFlood = New System.Windows.Forms.TextBox()
        Me.txtTimeEbb = New System.Windows.Forms.TextBox()
        Me.txtTab2FloodMin = New System.Windows.Forms.TextBox()
        Me.txtTab2EbbMin = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtSetEbb = New System.Windows.Forms.TextBox()
        Me.txtSetFlood = New System.Windows.Forms.TextBox()
        Me.chkE = New System.Windows.Forms.CheckBox()
        Me.chkSBE = New System.Windows.Forms.CheckBox()
        Me.chkF = New System.Windows.Forms.CheckBox()
        Me.chkSBF = New System.Windows.Forms.CheckBox()
        Me.txtTab2SlackFHour = New System.Windows.Forms.TextBox()
        Me.txtTab2SlackEHour = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtLocNo = New System.Windows.Forms.TextBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.txtRefSta = New System.Windows.Forms.TextBox()
        Me.txtVelFlood = New System.Windows.Forms.TextBox()
        Me.txtVelEbb = New System.Windows.Forms.TextBox()
        Me.txtTab2Diff = New System.Windows.Forms.TextBox()
        Me.txtSubStaNo = New System.Windows.Forms.TextBox()
        Me.txtTab2FloodHour = New System.Windows.Forms.TextBox()
        Me.txtTab2FloodMult = New System.Windows.Forms.TextBox()
        Me.txtTab2EbbHour = New System.Windows.Forms.TextBox()
        Me.txtTab2EbbMult = New System.Windows.Forms.TextBox()
        Me.cmdCurrents = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optRule = New System.Windows.Forms.RadioButton()
        Me.optB = New System.Windows.Forms.RadioButton()
        Me.optA = New System.Windows.Forms.RadioButton()
        Me.optCalc = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblLocNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesTime = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTimeSlackBeforeEbb
        '
        Me.txtTimeSlackBeforeEbb.AcceptsReturn = True
        Me.txtTimeSlackBeforeEbb.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeSlackBeforeEbb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeSlackBeforeEbb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeSlackBeforeEbb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeSlackBeforeEbb.Location = New System.Drawing.Point(576, 104)
        Me.txtTimeSlackBeforeEbb.MaxLength = 4
        Me.txtTimeSlackBeforeEbb.Name = "txtTimeSlackBeforeEbb"
        Me.txtTimeSlackBeforeEbb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeSlackBeforeEbb.Size = New System.Drawing.Size(41, 21)
        Me.txtTimeSlackBeforeEbb.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.txtTimeSlackBeforeEbb, "Range 0000 to 2359")
        '
        'txtTimeSlackBeforeFlood
        '
        Me.txtTimeSlackBeforeFlood.AcceptsReturn = True
        Me.txtTimeSlackBeforeFlood.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeSlackBeforeFlood.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeSlackBeforeFlood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeSlackBeforeFlood.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeSlackBeforeFlood.Location = New System.Drawing.Point(360, 104)
        Me.txtTimeSlackBeforeFlood.MaxLength = 4
        Me.txtTimeSlackBeforeFlood.Name = "txtTimeSlackBeforeFlood"
        Me.txtTimeSlackBeforeFlood.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeSlackBeforeFlood.Size = New System.Drawing.Size(41, 21)
        Me.txtTimeSlackBeforeFlood.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.txtTimeSlackBeforeFlood, "Range 0000 to 2359")
        '
        'txtTab2SlackFMin
        '
        Me.txtTab2SlackFMin.AcceptsReturn = True
        Me.txtTab2SlackFMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2SlackFMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2SlackFMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2SlackFMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2SlackFMin.Location = New System.Drawing.Point(384, 128)
        Me.txtTab2SlackFMin.MaxLength = 2
        Me.txtTab2SlackFMin.Name = "txtTab2SlackFMin"
        Me.txtTab2SlackFMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2SlackFMin.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2SlackFMin.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.txtTab2SlackFMin, "Range 0 to 59")
        '
        'txtTab2SlackEMin
        '
        Me.txtTab2SlackEMin.AcceptsReturn = True
        Me.txtTab2SlackEMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2SlackEMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2SlackEMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2SlackEMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2SlackEMin.Location = New System.Drawing.Point(600, 128)
        Me.txtTab2SlackEMin.MaxLength = 2
        Me.txtTab2SlackEMin.Name = "txtTab2SlackEMin"
        Me.txtTab2SlackEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2SlackEMin.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2SlackEMin.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtTab2SlackEMin, "Range 0 to 59")
        '
        'txtDesTime
        '
        Me.txtDesTime.AcceptsReturn = True
        Me.txtDesTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDesTime.Location = New System.Drawing.Point(128, 24)
        Me.txtDesTime.MaxLength = 4
        Me.txtDesTime.Name = "txtDesTime"
        Me.txtDesTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesTime.Size = New System.Drawing.Size(41, 21)
        Me.txtDesTime.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtDesTime, "Range 0000 to 2359")
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(393, 26)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(33, 21)
        Me.txtYear.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtYear, "Range 1901 to 2099")
        '
        'txtTimeFlood
        '
        Me.txtTimeFlood.AcceptsReturn = True
        Me.txtTimeFlood.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeFlood.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeFlood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeFlood.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeFlood.Location = New System.Drawing.Point(440, 104)
        Me.txtTimeFlood.MaxLength = 4
        Me.txtTimeFlood.Name = "txtTimeFlood"
        Me.txtTimeFlood.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeFlood.Size = New System.Drawing.Size(41, 21)
        Me.txtTimeFlood.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.txtTimeFlood, "Range 0000 to 2359")
        '
        'txtTimeEbb
        '
        Me.txtTimeEbb.AcceptsReturn = True
        Me.txtTimeEbb.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeEbb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeEbb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeEbb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeEbb.Location = New System.Drawing.Point(656, 104)
        Me.txtTimeEbb.MaxLength = 4
        Me.txtTimeEbb.Name = "txtTimeEbb"
        Me.txtTimeEbb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeEbb.Size = New System.Drawing.Size(41, 21)
        Me.txtTimeEbb.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.txtTimeEbb, "Range 0000 to 2359")
        '
        'txtTab2FloodMin
        '
        Me.txtTab2FloodMin.AcceptsReturn = True
        Me.txtTab2FloodMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2FloodMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2FloodMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2FloodMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2FloodMin.Location = New System.Drawing.Point(464, 128)
        Me.txtTab2FloodMin.MaxLength = 2
        Me.txtTab2FloodMin.Name = "txtTab2FloodMin"
        Me.txtTab2FloodMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2FloodMin.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2FloodMin.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtTab2FloodMin, "Range 0 to 59")
        '
        'txtTab2EbbMin
        '
        Me.txtTab2EbbMin.AcceptsReturn = True
        Me.txtTab2EbbMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2EbbMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2EbbMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2EbbMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2EbbMin.Location = New System.Drawing.Point(680, 128)
        Me.txtTab2EbbMin.MaxLength = 2
        Me.txtTab2EbbMin.Name = "txtTab2EbbMin"
        Me.txtTab2EbbMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2EbbMin.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2EbbMin.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.txtTab2EbbMin, "Range 0 to 59")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(748, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 14)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line13})
        Me.ShapeContainer2.Size = New System.Drawing.Size(257, 19)
        Me.ShapeContainer2.TabIndex = 73
        Me.ShapeContainer2.TabStop = False
        '
        'Line13
        '
        Me.Line13.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line13.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Line13.Name = "Line13"
        Me.Line13.X1 = 189
        Me.Line13.X2 = 189
        Me.Line13.Y1 = -5
        Me.Line13.Y2 = 18
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line12, Me.Line11, Me.Line10, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(804, 336)
        Me.ShapeContainer1.TabIndex = 72
        Me.ShapeContainer1.TabStop = False
        '
        'Line12
        '
        Me.Line12.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line12.Name = "Line12"
        Me.Line12.X1 = 0
        Me.Line12.X2 = 797
        Me.Line12.Y1 = 221
        Me.Line12.Y2 = 222
        '
        'Line11
        '
        Me.Line11.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line11.Name = "Line11"
        Me.Line11.X1 = 640
        Me.Line11.X2 = 640
        Me.Line11.Y1 = 48
        Me.Line11.Y2 = 168
        '
        'Line10
        '
        Me.Line10.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line10.Name = "Line10"
        Me.Line10.X1 = 552
        Me.Line10.X2 = 552
        Me.Line10.Y1 = 48
        Me.Line10.Y2 = 330
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 0
        Me.Line1.X2 = 798
        Me.Line1.Y1 = 48
        Me.Line1.Y2 = 48
        '
        'Line2
        '
        Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line2.Name = "Line2"
        Me.Line2.X1 = 0
        Me.Line2.X2 = 798
        Me.Line2.Y1 = 152
        Me.Line2.Y2 = 152
        '
        'Line3
        '
        Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line3.Name = "Line3"
        Me.Line3.X1 = 336
        Me.Line3.X2 = 336
        Me.Line3.Y1 = 48
        Me.Line3.Y2 = 168
        '
        'Line4
        '
        Me.Line4.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line4.Name = "Line4"
        Me.Line4.X1 = 424
        Me.Line4.X2 = 424
        Me.Line4.Y1 = 48
        Me.Line4.Y2 = 168
        '
        'Line5
        '
        Me.Line5.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line5.Name = "Line5"
        Me.Line5.X1 = 0
        Me.Line5.X2 = 798
        Me.Line5.Y1 = 168
        Me.Line5.Y2 = 168
        '
        'Line6
        '
        Me.Line6.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line6.Name = "Line6"
        Me.Line6.X1 = 0
        Me.Line6.X2 = 798
        Me.Line6.Y1 = 208
        Me.Line6.Y2 = 208
        '
        'Line7
        '
        Me.Line7.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line7.Name = "Line7"
        Me.Line7.X1 = 0
        Me.Line7.X2 = 798
        Me.Line7.Y1 = 260
        Me.Line7.Y2 = 260
        '
        'Line8
        '
        Me.Line8.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line8.Name = "Line8"
        Me.Line8.X1 = 0
        Me.Line8.X2 = 798
        Me.Line8.Y1 = 273
        Me.Line8.Y2 = 273
        '
        'Line9
        '
        Me.Line9.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line9.Name = "Line9"
        Me.Line9.X1 = 0
        Me.Line9.X2 = 798
        Me.Line9.Y1 = 312
        Me.Line9.Y2 = 312
        '
        'txtSetEbb
        '
        Me.txtSetEbb.AcceptsReturn = True
        Me.txtSetEbb.BackColor = System.Drawing.SystemColors.Window
        Me.txtSetEbb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSetEbb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetEbb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSetEbb.Location = New System.Drawing.Point(712, 67)
        Me.txtSetEbb.MaxLength = 3
        Me.txtSetEbb.Name = "txtSetEbb"
        Me.txtSetEbb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSetEbb.Size = New System.Drawing.Size(25, 21)
        Me.txtSetEbb.TabIndex = 49
        '
        'txtSetFlood
        '
        Me.txtSetFlood.AcceptsReturn = True
        Me.txtSetFlood.BackColor = System.Drawing.SystemColors.Window
        Me.txtSetFlood.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSetFlood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetFlood.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSetFlood.Location = New System.Drawing.Point(496, 67)
        Me.txtSetFlood.MaxLength = 3
        Me.txtSetFlood.Name = "txtSetFlood"
        Me.txtSetFlood.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSetFlood.Size = New System.Drawing.Size(25, 21)
        Me.txtSetFlood.TabIndex = 45
        '
        'chkE
        '
        Me.chkE.BackColor = System.Drawing.SystemColors.Window
        Me.chkE.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkE.Enabled = False
        Me.chkE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkE.Location = New System.Drawing.Point(688, 154)
        Me.chkE.Name = "chkE"
        Me.chkE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkE.Size = New System.Drawing.Size(13, 13)
        Me.chkE.TabIndex = 69
        Me.chkE.Text = "Check1"
        Me.chkE.UseVisualStyleBackColor = False
        Me.chkE.Visible = False
        '
        'chkSBE
        '
        Me.chkSBE.BackColor = System.Drawing.SystemColors.Window
        Me.chkSBE.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSBE.Enabled = False
        Me.chkSBE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSBE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSBE.Location = New System.Drawing.Point(608, 154)
        Me.chkSBE.Name = "chkSBE"
        Me.chkSBE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSBE.Size = New System.Drawing.Size(13, 13)
        Me.chkSBE.TabIndex = 68
        Me.chkSBE.Text = "Check1"
        Me.chkSBE.UseVisualStyleBackColor = False
        Me.chkSBE.Visible = False
        '
        'chkF
        '
        Me.chkF.BackColor = System.Drawing.SystemColors.Window
        Me.chkF.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkF.Enabled = False
        Me.chkF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkF.Location = New System.Drawing.Point(472, 154)
        Me.chkF.Name = "chkF"
        Me.chkF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkF.Size = New System.Drawing.Size(13, 13)
        Me.chkF.TabIndex = 67
        Me.chkF.Text = "Check1"
        Me.chkF.UseVisualStyleBackColor = False
        Me.chkF.Visible = False
        '
        'chkSBF
        '
        Me.chkSBF.BackColor = System.Drawing.SystemColors.Window
        Me.chkSBF.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSBF.Enabled = False
        Me.chkSBF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSBF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSBF.Location = New System.Drawing.Point(392, 154)
        Me.chkSBF.Name = "chkSBF"
        Me.chkSBF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSBF.Size = New System.Drawing.Size(13, 13)
        Me.chkSBF.TabIndex = 66
        Me.chkSBF.Text = "Check1"
        Me.chkSBF.UseVisualStyleBackColor = False
        Me.chkSBF.Visible = False
        '
        'txtTab2SlackFHour
        '
        Me.txtTab2SlackFHour.AcceptsReturn = True
        Me.txtTab2SlackFHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2SlackFHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2SlackFHour.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2SlackFHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2SlackFHour.Location = New System.Drawing.Point(352, 128)
        Me.txtTab2SlackFHour.MaxLength = 2
        Me.txtTab2SlackFHour.Name = "txtTab2SlackFHour"
        Me.txtTab2SlackFHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2SlackFHour.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2SlackFHour.TabIndex = 52
        '
        'txtTab2SlackEHour
        '
        Me.txtTab2SlackEHour.AcceptsReturn = True
        Me.txtTab2SlackEHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2SlackEHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2SlackEHour.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2SlackEHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2SlackEHour.Location = New System.Drawing.Point(568, 128)
        Me.txtTab2SlackEHour.MaxLength = 2
        Me.txtTab2SlackEHour.Name = "txtTab2SlackEHour"
        Me.txtTab2SlackEHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2SlackEHour.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2SlackEHour.TabIndex = 57
        '
        'txtLocation
        '
        Me.txtLocation.AcceptsReturn = True
        Me.txtLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocation.Location = New System.Drawing.Point(72, 0)
        Me.txtLocation.MaxLength = 0
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocation.Size = New System.Drawing.Size(273, 21)
        Me.txtLocation.TabIndex = 14
        '
        'txtLocNo
        '
        Me.txtLocNo.AcceptsReturn = True
        Me.txtLocNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocNo.Location = New System.Drawing.Point(376, 0)
        Me.txtLocNo.MaxLength = 7
        Me.txtLocNo.Name = "txtLocNo"
        Me.txtLocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocNo.Size = New System.Drawing.Size(49, 21)
        Me.txtLocNo.TabIndex = 13
        '
        'cboDay
        '
        Me.cboDay.BackColor = System.Drawing.SystemColors.Window
        Me.cboDay.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDay.Items.AddRange(New Object() {"1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(263, 24)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDay.Size = New System.Drawing.Size(42, 21)
        Me.cboDay.TabIndex = 11
        '
        'cboMonth
        '
        Me.cboMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cboMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cboMonth.Location = New System.Drawing.Point(328, 24)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMonth.Size = New System.Drawing.Size(49, 21)
        Me.cboMonth.TabIndex = 9
        '
        'txtRefSta
        '
        Me.txtRefSta.AcceptsReturn = True
        Me.txtRefSta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRefSta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRefSta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefSta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRefSta.Location = New System.Drawing.Point(96, 104)
        Me.txtRefSta.MaxLength = 0
        Me.txtRefSta.Name = "txtRefSta"
        Me.txtRefSta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRefSta.Size = New System.Drawing.Size(233, 21)
        Me.txtRefSta.TabIndex = 8
        '
        'txtVelFlood
        '
        Me.txtVelFlood.AcceptsReturn = True
        Me.txtVelFlood.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelFlood.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVelFlood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelFlood.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVelFlood.Location = New System.Drawing.Point(504, 104)
        Me.txtVelFlood.MaxLength = 5
        Me.txtVelFlood.Name = "txtVelFlood"
        Me.txtVelFlood.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVelFlood.Size = New System.Drawing.Size(41, 21)
        Me.txtVelFlood.TabIndex = 47
        '
        'txtVelEbb
        '
        Me.txtVelEbb.AcceptsReturn = True
        Me.txtVelEbb.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelEbb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVelEbb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelEbb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVelEbb.Location = New System.Drawing.Point(720, 104)
        Me.txtVelEbb.MaxLength = 5
        Me.txtVelEbb.Name = "txtVelEbb"
        Me.txtVelEbb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVelEbb.Size = New System.Drawing.Size(41, 21)
        Me.txtVelEbb.TabIndex = 51
        '
        'txtTab2Diff
        '
        Me.txtTab2Diff.AcceptsReturn = True
        Me.txtTab2Diff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTab2Diff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2Diff.Enabled = False
        Me.txtTab2Diff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2Diff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2Diff.Location = New System.Drawing.Point(96, 128)
        Me.txtTab2Diff.MaxLength = 0
        Me.txtTab2Diff.Name = "txtTab2Diff"
        Me.txtTab2Diff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2Diff.Size = New System.Drawing.Size(153, 21)
        Me.txtTab2Diff.TabIndex = 7
        '
        'txtSubStaNo
        '
        Me.txtSubStaNo.AcceptsReturn = True
        Me.txtSubStaNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubStaNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubStaNo.Enabled = False
        Me.txtSubStaNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubStaNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubStaNo.Location = New System.Drawing.Point(272, 128)
        Me.txtSubStaNo.MaxLength = 0
        Me.txtSubStaNo.Name = "txtSubStaNo"
        Me.txtSubStaNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubStaNo.Size = New System.Drawing.Size(49, 21)
        Me.txtSubStaNo.TabIndex = 6
        '
        'txtTab2FloodHour
        '
        Me.txtTab2FloodHour.AcceptsReturn = True
        Me.txtTab2FloodHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2FloodHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2FloodHour.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2FloodHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2FloodHour.Location = New System.Drawing.Point(432, 128)
        Me.txtTab2FloodHour.MaxLength = 2
        Me.txtTab2FloodHour.Name = "txtTab2FloodHour"
        Me.txtTab2FloodHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2FloodHour.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2FloodHour.TabIndex = 54
        '
        'txtTab2FloodMult
        '
        Me.txtTab2FloodMult.AcceptsReturn = True
        Me.txtTab2FloodMult.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2FloodMult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2FloodMult.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2FloodMult.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2FloodMult.Location = New System.Drawing.Point(512, 128)
        Me.txtTab2FloodMult.MaxLength = 5
        Me.txtTab2FloodMult.Name = "txtTab2FloodMult"
        Me.txtTab2FloodMult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2FloodMult.Size = New System.Drawing.Size(33, 21)
        Me.txtTab2FloodMult.TabIndex = 56
        '
        'txtTab2EbbHour
        '
        Me.txtTab2EbbHour.AcceptsReturn = True
        Me.txtTab2EbbHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2EbbHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2EbbHour.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2EbbHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2EbbHour.Location = New System.Drawing.Point(648, 128)
        Me.txtTab2EbbHour.MaxLength = 2
        Me.txtTab2EbbHour.Name = "txtTab2EbbHour"
        Me.txtTab2EbbHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2EbbHour.Size = New System.Drawing.Size(25, 21)
        Me.txtTab2EbbHour.TabIndex = 59
        '
        'txtTab2EbbMult
        '
        Me.txtTab2EbbMult.AcceptsReturn = True
        Me.txtTab2EbbMult.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2EbbMult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2EbbMult.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2EbbMult.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2EbbMult.Location = New System.Drawing.Point(728, 128)
        Me.txtTab2EbbMult.MaxLength = 5
        Me.txtTab2EbbMult.Name = "txtTab2EbbMult"
        Me.txtTab2EbbMult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2EbbMult.Size = New System.Drawing.Size(33, 21)
        Me.txtTab2EbbMult.TabIndex = 61
        '
        'cmdCurrents
        '
        Me.cmdCurrents.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCurrents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCurrents.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCurrents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCurrents.Location = New System.Drawing.Point(8, 56)
        Me.cmdCurrents.Name = "cmdCurrents"
        Me.cmdCurrents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCurrents.Size = New System.Drawing.Size(57, 25)
        Me.cmdCurrents.TabIndex = 5
        Me.cmdCurrents.Text = "&Calculate"
        Me.cmdCurrents.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(672, 16)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(65, 25)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clea&r"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optRule)
        Me.Frame1.Controls.Add(Me.optB)
        Me.Frame1.Controls.Add(Me.optA)
        Me.Frame1.Controls.Add(Me.optCalc)
        Me.Frame1.Controls.Add(Me.ShapeContainer2)
        Me.Frame1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(72, 50)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(257, 33)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Use Velocity Factor from"
        '
        'optRule
        '
        Me.optRule.BackColor = System.Drawing.SystemColors.Window
        Me.optRule.Cursor = System.Windows.Forms.Cursors.Default
        Me.optRule.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optRule.Location = New System.Drawing.Point(140, 8)
        Me.optRule.Name = "optRule"
        Me.optRule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optRule.Size = New System.Drawing.Size(48, 24)
        Me.optRule.TabIndex = 72
        Me.optRule.TabStop = True
        Me.optRule.Text = "50-90  Rule"
        Me.optRule.UseVisualStyleBackColor = False
        '
        'optB
        '
        Me.optB.BackColor = System.Drawing.SystemColors.Window
        Me.optB.Cursor = System.Windows.Forms.Cursors.Default
        Me.optB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optB.Location = New System.Drawing.Point(192, 14)
        Me.optB.Name = "optB"
        Me.optB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optB.Size = New System.Drawing.Size(62, 17)
        Me.optB.TabIndex = 65
        Me.optB.TabStop = True
        Me.optB.Text = "Table 3B"
        Me.optB.UseVisualStyleBackColor = False
        '
        'optA
        '
        Me.optA.BackColor = System.Drawing.SystemColors.Window
        Me.optA.Cursor = System.Windows.Forms.Cursors.Default
        Me.optA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optA.Location = New System.Drawing.Point(77, 14)
        Me.optA.Name = "optA"
        Me.optA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optA.Size = New System.Drawing.Size(62, 17)
        Me.optA.TabIndex = 2
        Me.optA.TabStop = True
        Me.optA.Text = "Table 3A"
        Me.optA.UseVisualStyleBackColor = False
        '
        'optCalc
        '
        Me.optCalc.BackColor = System.Drawing.SystemColors.Window
        Me.optCalc.Checked = True
        Me.optCalc.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCalc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCalc.Location = New System.Drawing.Point(4, 14)
        Me.optCalc.Name = "optCalc"
        Me.optCalc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCalc.Size = New System.Drawing.Size(84, 17)
        Me.optCalc.TabIndex = 1
        Me.optCalc.TabStop = True
        Me.optCalc.Text = "Calculation"
        Me.optCalc.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Window
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(672, 67)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(33, 17)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "Set (°)"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Window
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(456, 67)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(33, 17)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "Set (°)"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Window
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(568, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(65, 17)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Time (hhmm)"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(352, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(65, 17)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Time (hhmm)"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Window
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(504, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(9, 17)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "x"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Window
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(560, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(75, 17)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "SLACK Before E"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Window
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(344, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(75, 17)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "SLACK Before F"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Window
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(377, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(9, 17)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "h"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(409, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(9, 17)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "m"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(593, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(9, 17)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "h"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(625, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(9, 17)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "m"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(720, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(9, 17)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "x"
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Window
        Me.lblLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocation.Location = New System.Drawing.Point(8, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLocation.Size = New System.Drawing.Size(57, 17)
        Me.lblLocation.TabIndex = 36
        Me.lblLocation.Text = "LOCATION"
        '
        'lblLocNumber
        '
        Me.lblLocNumber.BackColor = System.Drawing.SystemColors.Window
        Me.lblLocNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLocNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocNumber.Location = New System.Drawing.Point(360, 0)
        Me.lblLocNumber.Name = "lblLocNumber"
        Me.lblLocNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLocNumber.Size = New System.Drawing.Size(17, 17)
        Me.lblLocNumber.TabIndex = 35
        Me.lblLocNumber.Text = "(#"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(426, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = ")  Substation # from Table 2"
        '
        'lblDesTime
        '
        Me.lblDesTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblDesTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDesTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDesTime.Location = New System.Drawing.Point(8, 24)
        Me.lblDesTime.Name = "lblDesTime"
        Me.lblDesTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDesTime.Size = New System.Drawing.Size(121, 17)
        Me.lblDesTime.TabIndex = 33
        Me.lblDesTime.Text = "DESIRED TIME (hhmm)"
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.SystemColors.Window
        Me.lblYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYear.Location = New System.Drawing.Point(380, 27)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYear.Size = New System.Drawing.Size(17, 17)
        Me.lblYear.TabIndex = 32
        Me.lblYear.Text = "Yr."
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.SystemColors.Window
        Me.lblMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMonth.Location = New System.Drawing.Point(307, 27)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMonth.Size = New System.Drawing.Size(21, 17)
        Me.lblMonth.TabIndex = 31
        Me.lblMonth.Text = "Mo."
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.SystemColors.Window
        Me.lblDay.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDay.Location = New System.Drawing.Point(240, 27)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDay.Size = New System.Drawing.Size(25, 17)
        Me.lblDay.TabIndex = 30
        Me.lblDay.Text = "Day"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(208, 27)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(25, 17)
        Me.lblDate.TabIndex = 29
        Me.lblDate.Text = "Date"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(456, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "MAX. FLOOD"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(680, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "MAX. EBB"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(432, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Time (hhmm)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(648, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Time (hhmm)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(507, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Vel (kn)"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(723, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Vel (kn)"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Ref. Station:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "+ Table 2 Diff:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(256, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "(#"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(321, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(9, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = ")"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(457, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(9, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "h"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(489, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(9, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "m"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(673, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(9, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "h"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(705, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(9, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "m"
        '
        'Form24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(804, 336)
        Me.Controls.Add(Me.txtSetEbb)
        Me.Controls.Add(Me.txtSetFlood)
        Me.Controls.Add(Me.chkE)
        Me.Controls.Add(Me.chkSBE)
        Me.Controls.Add(Me.chkF)
        Me.Controls.Add(Me.chkSBF)
        Me.Controls.Add(Me.txtTimeSlackBeforeEbb)
        Me.Controls.Add(Me.txtTimeSlackBeforeFlood)
        Me.Controls.Add(Me.txtTab2SlackFHour)
        Me.Controls.Add(Me.txtTab2SlackFMin)
        Me.Controls.Add(Me.txtTab2SlackEHour)
        Me.Controls.Add(Me.txtTab2SlackEMin)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtLocNo)
        Me.Controls.Add(Me.txtDesTime)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.txtRefSta)
        Me.Controls.Add(Me.txtTimeFlood)
        Me.Controls.Add(Me.txtVelFlood)
        Me.Controls.Add(Me.txtTimeEbb)
        Me.Controls.Add(Me.txtVelEbb)
        Me.Controls.Add(Me.txtTab2Diff)
        Me.Controls.Add(Me.txtSubStaNo)
        Me.Controls.Add(Me.txtTab2FloodHour)
        Me.Controls.Add(Me.txtTab2FloodMin)
        Me.Controls.Add(Me.txtTab2FloodMult)
        Me.Controls.Add(Me.txtTab2EbbHour)
        Me.Controls.Add(Me.txtTab2EbbMin)
        Me.Controls.Add(Me.txtTab2EbbMult)
        Me.Controls.Add(Me.cmdCurrents)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblLocNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDesTime)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "Form24"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set & Drift of Tidal Current at Desired Time"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class