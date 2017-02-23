<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintHelp
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
	Public WithEvents CancelButton_Renamed As System.Windows.Forms.Button
	Public WithEvents cmdOKButton As System.Windows.Forms.Button
	Public WithEvents cboPrintHelpList As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintHelp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.CancelButton_Renamed = New System.Windows.Forms.Button
		Me.cmdOKButton = New System.Windows.Forms.Button
		Me.cboPrintHelpList = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Print Help Topics"
		Me.ClientSize = New System.Drawing.Size(328, 154)
		Me.Location = New System.Drawing.Point(3, 29)
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
		Me.Name = "frmPrintHelp"
		Me.CancelButton_Renamed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton_Renamed.Text = "&Cancel"
		Me.CancelButton_Renamed.Size = New System.Drawing.Size(81, 25)
		Me.CancelButton_Renamed.Location = New System.Drawing.Point(240, 56)
		Me.CancelButton_Renamed.TabIndex = 2
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
		Me.cmdOKButton.Location = New System.Drawing.Point(240, 24)
		Me.cmdOKButton.TabIndex = 1
		Me.cmdOKButton.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOKButton.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOKButton.CausesValidation = True
		Me.cmdOKButton.Enabled = True
		Me.cmdOKButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOKButton.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOKButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOKButton.TabStop = True
		Me.cmdOKButton.Name = "cmdOKButton"
		Me.cboPrintHelpList.Size = New System.Drawing.Size(225, 21)
		Me.cboPrintHelpList.Location = New System.Drawing.Point(8, 24)
		Me.cboPrintHelpList.Items.AddRange(New Object(){"All", "2/3 Bearings", "60D=ST", "Arcs and Times", "CTS/TR/SOA", "Currents", "Distances", "Favorite Places", "General", "Navigation Mathematics", "Length of Degree", "SR Methods & Fix", "MoBoard", "Noon Sight", "Sight Averaging", "Sight Planner", "Sight Reduction & Fix", "The Sailings", "Tides", "TVMDC", "Yellow Pages (Increment and Corrections)"})
		Me.cboPrintHelpList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPrintHelpList.TabIndex = 0
		Me.cboPrintHelpList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPrintHelpList.BackColor = System.Drawing.SystemColors.Window
		Me.cboPrintHelpList.CausesValidation = True
		Me.cboPrintHelpList.Enabled = True
		Me.cboPrintHelpList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPrintHelpList.IntegralHeight = True
		Me.cboPrintHelpList.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPrintHelpList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPrintHelpList.Sorted = False
		Me.cboPrintHelpList.TabStop = True
		Me.cboPrintHelpList.Visible = True
		Me.cboPrintHelpList.Name = "cboPrintHelpList"
		Me.Label1.Text = "Select which Help topic to print"
		Me.Label1.Size = New System.Drawing.Size(161, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 3
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
		Me.Controls.Add(CancelButton_Renamed)
		Me.Controls.Add(cmdOKButton)
		Me.Controls.Add(cboPrintHelpList)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class