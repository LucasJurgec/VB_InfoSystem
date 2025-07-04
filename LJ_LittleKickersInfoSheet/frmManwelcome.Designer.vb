<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManwelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mspManager = New System.Windows.Forms.MenuStrip()
        Me.EmployeeFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoSheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoSheetManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KickerManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeWageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mspManager.SuspendLayout()
        Me.SuspendLayout()
        '
        'mspManager
        '
        Me.mspManager.BackColor = System.Drawing.Color.Snow
        Me.mspManager.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mspManager.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mspManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeFormsToolStripMenuItem, Me.ManagerFormsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.tsmExit})
        Me.mspManager.Location = New System.Drawing.Point(0, 0)
        Me.mspManager.Name = "mspManager"
        Me.mspManager.Size = New System.Drawing.Size(482, 36)
        Me.mspManager.TabIndex = 0
        Me.mspManager.Text = "MenuStrip1"
        '
        'EmployeeFormsToolStripMenuItem
        '
        Me.EmployeeFormsToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.EmployeeFormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoSheetsToolStripMenuItem})
        Me.EmployeeFormsToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeFormsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeFormsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.EmployeeFormsToolStripMenuItem.Name = "EmployeeFormsToolStripMenuItem"
        Me.EmployeeFormsToolStripMenuItem.Size = New System.Drawing.Size(133, 32)
        Me.EmployeeFormsToolStripMenuItem.Text = "Employee"
        '
        'InfoSheetsToolStripMenuItem
        '
        Me.InfoSheetsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InfoSheetsToolStripMenuItem.Name = "InfoSheetsToolStripMenuItem"
        Me.InfoSheetsToolStripMenuItem.Size = New System.Drawing.Size(235, 36)
        Me.InfoSheetsToolStripMenuItem.Text = "Info sheets"
        '
        'ManagerFormsToolStripMenuItem
        '
        Me.ManagerFormsToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.ManagerFormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoSheetManagerToolStripMenuItem, Me.KickerManagerToolStripMenuItem, Me.NewEmployeesToolStripMenuItem, Me.EmployeeWageToolStripMenuItem})
        Me.ManagerFormsToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManagerFormsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ManagerFormsToolStripMenuItem.Name = "ManagerFormsToolStripMenuItem"
        Me.ManagerFormsToolStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.ManagerFormsToolStripMenuItem.Text = "Manager"
        '
        'InfoSheetManagerToolStripMenuItem
        '
        Me.InfoSheetManagerToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.InfoSheetManagerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InfoSheetManagerToolStripMenuItem.Name = "InfoSheetManagerToolStripMenuItem"
        Me.InfoSheetManagerToolStripMenuItem.Size = New System.Drawing.Size(325, 36)
        Me.InfoSheetManagerToolStripMenuItem.Text = "Info Sheet Manager"
        '
        'KickerManagerToolStripMenuItem
        '
        Me.KickerManagerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KickerManagerToolStripMenuItem.Name = "KickerManagerToolStripMenuItem"
        Me.KickerManagerToolStripMenuItem.Size = New System.Drawing.Size(325, 36)
        Me.KickerManagerToolStripMenuItem.Text = "Player Manager"
        '
        'NewEmployeesToolStripMenuItem
        '
        Me.NewEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewEmployeesToolStripMenuItem.Name = "NewEmployeesToolStripMenuItem"
        Me.NewEmployeesToolStripMenuItem.Size = New System.Drawing.Size(325, 36)
        Me.NewEmployeesToolStripMenuItem.Text = "Employee Manager"
        '
        'EmployeeWageToolStripMenuItem
        '
        Me.EmployeeWageToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.EmployeeWageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeWageToolStripMenuItem.Name = "EmployeeWageToolStripMenuItem"
        Me.EmployeeWageToolStripMenuItem.Size = New System.Drawing.Size(325, 36)
        Me.EmployeeWageToolStripMenuItem.Text = "Employee Wage"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(16, 32)
        '
        'tsmExit
        '
        Me.tsmExit.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(71, 32)
        Me.tsmExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(-2, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 79)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'frmManwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mspManager)
        Me.MainMenuStrip = Me.mspManager
        Me.Name = "frmManwelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.mspManager.ResumeLayout(False)
        Me.mspManager.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mspManager As MenuStrip
    Friend WithEvents EmployeeFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoSheetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagerFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoSheetManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeWageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents KickerManagerToolStripMenuItem As ToolStripMenuItem
End Class
