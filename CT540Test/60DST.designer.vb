<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form16
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
	Public WithEvents txtd As System.Windows.Forms.TextBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdDistance As System.Windows.Forms.Button
	Public WithEvents cmdTime As System.Windows.Forms.Button
	Public WithEvents cmdSpeed As System.Windows.Forms.Button
	Public WithEvents txtm As System.Windows.Forms.TextBox
	Public WithEvents txth As System.Windows.Forms.TextBox
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents txtTime As System.Windows.Forms.TextBox
	Public WithEvents txtSpeed As System.Windows.Forms.TextBox
	Public WithEvents txtDistance As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblm As System.Windows.Forms.Label
	Public WithEvents lblh As System.Windows.Forms.Label
	Public WithEvents lblmin As System.Windows.Forms.Label
	Public WithEvents lblkn As System.Windows.Forms.Label
	Public WithEvents lblnm As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtm = New System.Windows.Forms.TextBox()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.cmdDistance = New System.Windows.Forms.Button()
        Me.cmdTime = New System.Windows.Forms.Button()
        Me.cmdSpeed = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lblkn = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtd
        '
        Me.txtd.AcceptsReturn = True
        Me.txtd.BackColor = System.Drawing.SystemColors.Window
        Me.txtd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtd.Location = New System.Drawing.Point(183, 88)
        Me.txtd.MaxLength = 2
        Me.txtd.Name = "txtd"
        Me.txtd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtd.Size = New System.Drawing.Size(25, 20)
        Me.txtd.TabIndex = 16
        Me.txtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtd, "Maximum 99")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(310, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 15
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtm
        '
        Me.txtm.AcceptsReturn = True
        Me.txtm.BackColor = System.Drawing.SystemColors.Window
        Me.txtm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtm.Location = New System.Drawing.Point(271, 88)
        Me.txtm.MaxLength = 2
        Me.txtm.Name = "txtm"
        Me.txtm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtm.Size = New System.Drawing.Size(25, 20)
        Me.txtm.TabIndex = 9
        Me.txtm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtm, "Maximum 59")
        '
        'txth
        '
        Me.txth.AcceptsReturn = True
        Me.txth.BackColor = System.Drawing.SystemColors.Window
        Me.txth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txth.Location = New System.Drawing.Point(223, 88)
        Me.txth.MaxLength = 3
        Me.txth.Name = "txth"
        Me.txth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txth.Size = New System.Drawing.Size(33, 20)
        Me.txth.TabIndex = 7
        Me.txth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txth, "Maximum 999")
        '
        'txtTime
        '
        Me.txtTime.AcceptsReturn = True
        Me.txtTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime.Location = New System.Drawing.Point(88, 88)
        Me.txtTime.MaxLength = 5
        Me.txtTime.Name = "txtTime"
        Me.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime.Size = New System.Drawing.Size(41, 20)
        Me.txtTime.TabIndex = 1
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTime, "Maximum 59999")
        '
        'txtSpeed
        '
        Me.txtSpeed.AcceptsReturn = True
        Me.txtSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpeed.Location = New System.Drawing.Point(96, 56)
        Me.txtSpeed.MaxLength = 4
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpeed.Size = New System.Drawing.Size(33, 20)
        Me.txtSpeed.TabIndex = 0
        Me.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtSpeed, "Maximum 99.9")
        '
        'txtDistance
        '
        Me.txtDistance.AcceptsReturn = True
        Me.txtDistance.BackColor = System.Drawing.Color.White
        Me.txtDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDistance.Location = New System.Drawing.Point(80, 120)
        Me.txtDistance.MaxLength = 6
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDistance.Size = New System.Drawing.Size(49, 20)
        Me.txtDistance.TabIndex = 2
        Me.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDistance, "Maximum 9999.9")
        '
        'cmdDistance
        '
        Me.cmdDistance.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDistance.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDistance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDistance.Location = New System.Drawing.Point(16, 120)
        Me.cmdDistance.Name = "cmdDistance"
        Me.cmdDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDistance.Size = New System.Drawing.Size(57, 19)
        Me.cmdDistance.TabIndex = 13
        Me.cmdDistance.Text = "Distance"
        Me.cmdDistance.UseVisualStyleBackColor = False
        '
        'cmdTime
        '
        Me.cmdTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTime.Location = New System.Drawing.Point(16, 88)
        Me.cmdTime.Name = "cmdTime"
        Me.cmdTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTime.Size = New System.Drawing.Size(57, 19)
        Me.cmdTime.TabIndex = 12
        Me.cmdTime.Text = "Time"
        Me.cmdTime.UseVisualStyleBackColor = False
        '
        'cmdSpeed
        '
        Me.cmdSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSpeed.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSpeed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSpeed.Location = New System.Drawing.Point(16, 56)
        Me.cmdSpeed.Name = "cmdSpeed"
        Me.cmdSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSpeed.Size = New System.Drawing.Size(57, 19)
        Me.cmdSpeed.TabIndex = 11
        Me.cmdSpeed.Text = "Speed"
        Me.cmdSpeed.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(128, 152)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(57, 25)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(208, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(9, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "d"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(288, 53)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter at least two of the values.   Press the button of the value to be (re)calcu" &
    "lated.  (If present, previous value will be overwritten.)"
        '
        'lblm
        '
        Me.lblm.BackColor = System.Drawing.SystemColors.Window
        Me.lblm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblm.Location = New System.Drawing.Point(296, 88)
        Me.lblm.Name = "lblm"
        Me.lblm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblm.Size = New System.Drawing.Size(9, 17)
        Me.lblm.TabIndex = 10
        Me.lblm.Text = "m"
        '
        'lblh
        '
        Me.lblh.BackColor = System.Drawing.SystemColors.Window
        Me.lblh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblh.Location = New System.Drawing.Point(256, 88)
        Me.lblh.Name = "lblh"
        Me.lblh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblh.Size = New System.Drawing.Size(9, 17)
        Me.lblh.TabIndex = 8
        Me.lblh.Text = "h"
        '
        'lblmin
        '
        Me.lblmin.BackColor = System.Drawing.SystemColors.Window
        Me.lblmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmin.Location = New System.Drawing.Point(126, 88)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmin.Size = New System.Drawing.Size(55, 20)
        Me.lblmin.TabIndex = 5
        Me.lblmin.Text = "min  OR"
        Me.lblmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblkn
        '
        Me.lblkn.BackColor = System.Drawing.SystemColors.Window
        Me.lblkn.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblkn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblkn.Location = New System.Drawing.Point(129, 56)
        Me.lblkn.Name = "lblkn"
        Me.lblkn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblkn.Size = New System.Drawing.Size(41, 17)
        Me.lblkn.TabIndex = 4
        Me.lblkn.Text = "kn"
        '
        'lblnm
        '
        Me.lblnm.BackColor = System.Drawing.SystemColors.Window
        Me.lblnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnm.Location = New System.Drawing.Point(129, 120)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnm.Size = New System.Drawing.Size(41, 17)
        Me.lblnm.TabIndex = 3
        Me.lblnm.Text = "nm"
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitBtn.Location = New System.Drawing.Point(264, 152)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(57, 25)
        Me.ExitBtn.TabIndex = 18
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(334, 184)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDistance)
        Me.Controls.Add(Me.cmdTime)
        Me.Controls.Add(Me.cmdSpeed)
        Me.Controls.Add(Me.txtm)
        Me.Controls.Add(Me.txth)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblm)
        Me.Controls.Add(Me.lblh)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.lblkn)
        Me.Controls.Add(Me.lblnm)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(359, 275)
        Me.MaximizeBox = False
        Me.Name = "Form16"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "60D = ST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ExitBtn As Button
#End Region
End Class