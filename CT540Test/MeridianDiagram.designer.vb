<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form22
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
	Public WithEvents optCircle As System.Windows.Forms.RadioButton
	Public WithEvents optEllipse As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents lblZn As System.Windows.Forms.Label
	Public WithEvents lblHo As System.Windows.Forms.Label
	Public WithEvents lblDec As System.Windows.Forms.Label
	Public WithEvents lvlLHA As System.Windows.Forms.Label
	Public WithEvents lblL As System.Windows.Forms.Label
	Public WithEvents lblNa As System.Windows.Forms.Label
	Public WithEvents lblS As System.Windows.Forms.Label
	Public WithEvents lblN As System.Windows.Forms.Label
	Public WithEvents lblZ As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form22))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optCircle = New System.Windows.Forms.RadioButton()
        Me.optEllipse = New System.Windows.Forms.RadioButton()
        Me.lblZn = New System.Windows.Forms.Label()
        Me.lblHo = New System.Windows.Forms.Label()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.lvlLHA = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblNa = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(440, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optCircle)
        Me.Frame1.Controls.Add(Me.optEllipse)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 400)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(73, 54)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Use"
        '
        'optCircle
        '
        Me.optCircle.BackColor = System.Drawing.SystemColors.Window
        Me.optCircle.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCircle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCircle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCircle.Location = New System.Drawing.Point(8, 34)
        Me.optCircle.Name = "optCircle"
        Me.optCircle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCircle.Size = New System.Drawing.Size(54, 14)
        Me.optCircle.TabIndex = 7
        Me.optCircle.TabStop = True
        Me.optCircle.Text = "Circles"
        Me.optCircle.UseVisualStyleBackColor = False
        '
        'optEllipse
        '
        Me.optEllipse.BackColor = System.Drawing.SystemColors.Window
        Me.optEllipse.Checked = True
        Me.optEllipse.Cursor = System.Windows.Forms.Cursors.Default
        Me.optEllipse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEllipse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optEllipse.Location = New System.Drawing.Point(8, 19)
        Me.optEllipse.Name = "optEllipse"
        Me.optEllipse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optEllipse.Size = New System.Drawing.Size(57, 14)
        Me.optEllipse.TabIndex = 6
        Me.optEllipse.TabStop = True
        Me.optEllipse.Text = "Ellipses"
        Me.optEllipse.UseVisualStyleBackColor = False
        '
        'lblZn
        '
        Me.lblZn.BackColor = System.Drawing.SystemColors.Window
        Me.lblZn.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblZn.Location = New System.Drawing.Point(0, 64)
        Me.lblZn.Name = "lblZn"
        Me.lblZn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZn.Size = New System.Drawing.Size(76, 17)
        Me.lblZn.TabIndex = 12
        Me.lblZn.Text = "Azimuth (Zn)"
        '
        'lblHo
        '
        Me.lblHo.BackColor = System.Drawing.SystemColors.Window
        Me.lblHo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHo.ForeColor = System.Drawing.Color.Red
        Me.lblHo.Location = New System.Drawing.Point(0, 48)
        Me.lblHo.Name = "lblHo"
        Me.lblHo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHo.Size = New System.Drawing.Size(65, 17)
        Me.lblHo.TabIndex = 11
        Me.lblHo.Text = "Altitude (h)"
        '
        'lblDec
        '
        Me.lblDec.BackColor = System.Drawing.SystemColors.Window
        Me.lblDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDec.Location = New System.Drawing.Point(0, 32)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDec.Size = New System.Drawing.Size(105, 17)
        Me.lblDec.TabIndex = 10
        Me.lblDec.Text = "Declination (Dec)"
        '
        'lvlLHA
        '
        Me.lvlLHA.BackColor = System.Drawing.SystemColors.Window
        Me.lvlLHA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvlLHA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlLHA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lvlLHA.Location = New System.Drawing.Point(0, 16)
        Me.lvlLHA.Name = "lvlLHA"
        Me.lvlLHA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lvlLHA.Size = New System.Drawing.Size(130, 17)
        Me.lvlLHA.TabIndex = 9
        Me.lvlLHA.Text = "Local Hour Angle (LHA)"
        '
        'lblL
        '
        Me.lblL.BackColor = System.Drawing.SystemColors.Window
        Me.lblL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblL.Location = New System.Drawing.Point(0, 0)
        Me.lblL.Name = "lblL"
        Me.lblL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblL.Size = New System.Drawing.Size(73, 17)
        Me.lblL.TabIndex = 8
        Me.lblL.Text = "Latitude (L)"
        '
        'lblNa
        '
        Me.lblNa.BackColor = System.Drawing.Color.Transparent
        Me.lblNa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNa.Location = New System.Drawing.Point(220, 447)
        Me.lblNa.Name = "lblNa"
        Me.lblNa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNa.Size = New System.Drawing.Size(17, 17)
        Me.lblNa.TabIndex = 3
        Me.lblNa.Text = "Na"
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(450, 227)
        Me.lblS.Name = "lblS"
        Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblS.Size = New System.Drawing.Size(9, 17)
        Me.lblS.TabIndex = 2
        Me.lblS.Text = "S"
        '
        'lblN
        '
        Me.lblN.BackColor = System.Drawing.Color.Transparent
        Me.lblN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblN.Location = New System.Drawing.Point(0, 227)
        Me.lblN.Name = "lblN"
        Me.lblN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblN.Size = New System.Drawing.Size(9, 17)
        Me.lblN.TabIndex = 1
        Me.lblN.Text = "N"
        '
        'lblZ
        '
        Me.lblZ.BackColor = System.Drawing.Color.Transparent
        Me.lblZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZ.Location = New System.Drawing.Point(227, 0)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZ.Size = New System.Drawing.Size(9, 17)
        Me.lblZ.TabIndex = 0
        Me.lblZ.Text = "Z"
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(459, 459)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.lblZn)
        Me.Controls.Add(Me.lblHo)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.lvlLHA)
        Me.Controls.Add(Me.lblL)
        Me.Controls.Add(Me.lblNa)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblZ)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "Form22"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Projection on the Plane of the Celestial Meridian"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class