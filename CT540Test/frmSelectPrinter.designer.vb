<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSelectPrinter
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
	Public WithEvents cboPrinterList As System.Windows.Forms.ComboBox
	Public WithEvents CancelButton_Renamed As System.Windows.Forms.Button
	Public WithEvents cmdOKButton As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectPrinter))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboPrinterList = New System.Windows.Forms.ComboBox
		Me.CancelButton_Renamed = New System.Windows.Forms.Button
		Me.cmdOKButton = New System.Windows.Forms.Button
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Select Printer"
		Me.ClientSize = New System.Drawing.Size(402, 145)
		Me.Location = New System.Drawing.Point(184, 250)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Name = "frmSelectPrinter"
		Me.cboPrinterList.Size = New System.Drawing.Size(297, 21)
		Me.cboPrinterList.Location = New System.Drawing.Point(8, 8)
		Me.cboPrinterList.TabIndex = 2
		Me.cboPrinterList.Text = "Combo1"
		Me.cboPrinterList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPrinterList.BackColor = System.Drawing.SystemColors.Window
		Me.cboPrinterList.CausesValidation = True
		Me.cboPrinterList.Enabled = True
		Me.cboPrinterList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPrinterList.IntegralHeight = True
		Me.cboPrinterList.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPrinterList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPrinterList.Sorted = False
		Me.cboPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPrinterList.TabStop = True
		Me.cboPrinterList.Visible = True
		Me.cboPrinterList.Name = "cboPrinterList"
		Me.CancelButton_Renamed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton_Renamed.Text = "&Cancel"
		Me.CancelButton_Renamed.Size = New System.Drawing.Size(81, 25)
		Me.CancelButton_Renamed.Location = New System.Drawing.Point(312, 40)
		Me.CancelButton_Renamed.TabIndex = 1
		Me.CancelButton_Renamed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CancelButton_Renamed.BackColor = System.Drawing.SystemColors.Control
		Me.CancelButton_Renamed.CausesValidation = True
		Me.CancelButton_Renamed.Enabled = True
		Me.CancelButton_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CancelButton_Renamed.Cursor = System.Windows.Forms.Cursors.Default
		Me.CancelButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CancelButton_Renamed.TabStop = True
		Me.CancelButton_Renamed.Name = "CancelButton_Renamed"
		Me.cmdOKButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOKButton.Text = "OK"
		Me.cmdOKButton.Size = New System.Drawing.Size(81, 25)
		Me.cmdOKButton.Location = New System.Drawing.Point(312, 8)
		Me.cmdOKButton.TabIndex = 0
		Me.cmdOKButton.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOKButton.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOKButton.CausesValidation = True
		Me.cmdOKButton.Enabled = True
		Me.cmdOKButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOKButton.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOKButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOKButton.TabStop = True
		Me.cmdOKButton.Name = "cmdOKButton"
		Me.Controls.Add(cboPrinterList)
		Me.Controls.Add(CancelButton_Renamed)
		Me.Controls.Add(cmdOKButton)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class