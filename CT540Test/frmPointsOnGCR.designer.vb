<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPointsOnGCR
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
	Public WithEvents txtLoPointDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoPointMin As System.Windows.Forms.TextBox
	Public WithEvents cboLoPoint As System.Windows.Forms.ComboBox
	Public WithEvents cmdWaypoint As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblWaypointLo As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPointsOnGCR))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLoPointDeg = New System.Windows.Forms.TextBox()
        Me.txtLoPointMin = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboLoPoint = New System.Windows.Forms.ComboBox()
        Me.cmdWaypoint = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWaypointLo = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGCR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtLoPointDeg
        '
        Me.txtLoPointDeg.AcceptsReturn = True
        Me.txtLoPointDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoPointDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoPointDeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoPointDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoPointDeg.Location = New System.Drawing.Point(448, 72)
        Me.txtLoPointDeg.MaxLength = 3
        Me.txtLoPointDeg.Name = "txtLoPointDeg"
        Me.txtLoPointDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoPointDeg.Size = New System.Drawing.Size(33, 19)
        Me.txtLoPointDeg.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtLoPointDeg, "Range 0 to 180")
        '
        'txtLoPointMin
        '
        Me.txtLoPointMin.AcceptsReturn = True
        Me.txtLoPointMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoPointMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoPointMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoPointMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoPointMin.Location = New System.Drawing.Point(488, 72)
        Me.txtLoPointMin.MaxLength = 4
        Me.txtLoPointMin.Name = "txtLoPointMin"
        Me.txtLoPointMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoPointMin.Size = New System.Drawing.Size(33, 19)
        Me.txtLoPointMin.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtLoPointMin, "Range 0 to 59.9")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(552, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(573, 568)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 368
        Me.Line1.X2 = 368
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 567
        '
        'cboLoPoint
        '
        Me.cboLoPoint.BackColor = System.Drawing.SystemColors.Window
        Me.cboLoPoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLoPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoPoint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoPoint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLoPoint.Items.AddRange(New Object() {"W ", "E "})
        Me.cboLoPoint.Location = New System.Drawing.Point(528, 72)
        Me.cboLoPoint.Name = "cboLoPoint"
        Me.cboLoPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLoPoint.Size = New System.Drawing.Size(41, 21)
        Me.cboLoPoint.TabIndex = 4
        '
        'cmdWaypoint
        '
        Me.cmdWaypoint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWaypoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWaypoint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWaypoint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWaypoint.Location = New System.Drawing.Point(424, 104)
        Me.cmdWaypoint.Name = "cmdWaypoint"
        Me.cmdWaypoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWaypoint.Size = New System.Drawing.Size(89, 33)
        Me.cmdWaypoint.TabIndex = 3
        Me.cmdWaypoint.Text = "&Point Latitude"
        Me.cmdWaypoint.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(264, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Distance (nm)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(176, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Course (ºT)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(176, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(169, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Rhumb line to next point"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(408, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "(not necessarily on route)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(400, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(161, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Individual Point on Great Circle"
        '
        'lblWaypointLo
        '
        Me.lblWaypointLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblWaypointLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWaypointLo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaypointLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWaypointLo.Location = New System.Drawing.Point(376, 67)
        Me.lblWaypointLo.Name = "lblWaypointLo"
        Me.lblWaypointLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWaypointLo.Size = New System.Drawing.Size(65, 29)
        Me.lblWaypointLo.TabIndex = 9
        Me.lblWaypointLo.Text = "Point Longitude"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(481, 72)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 8
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(521, 72)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 7
        Me.lblLoMin.Text = "'"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitude"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(96, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latitude"
        '
        'txtGCR
        '
        Me.txtGCR.Location = New System.Drawing.Point(2, 35)
        Me.txtGCR.Multiline = True
        Me.txtGCR.Name = "txtGCR"
        Me.txtGCR.ReadOnly = True
        Me.txtGCR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGCR.Size = New System.Drawing.Size(365, 501)
        Me.txtGCR.TabIndex = 16
        '
        'frmPointsOnGCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(573, 568)
        Me.Controls.Add(Me.txtGCR)
        Me.Controls.Add(Me.txtLoPointDeg)
        Me.Controls.Add(Me.txtLoPointMin)
        Me.Controls.Add(Me.cboLoPoint)
        Me.Controls.Add(Me.cmdWaypoint)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWaypointLo)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "frmPointsOnGCR"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Points on Great Circle Route"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGCR As TextBox
#End Region
End Class