<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKickerManager
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.cbxAddClass = New System.Windows.Forms.ComboBox()
        Me.cbxAddLocation = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxNewLocation = New System.Windows.Forms.ComboBox()
        Me.cbxNewClass = New System.Windows.Forms.ComboBox()
        Me.cbxNewDay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbxAddDay = New System.Windows.Forms.ComboBox()
        Me.lbxKickers = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblDateExample = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(587, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "D.O.B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(248, 580)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 577)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Class:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(23, 674)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 75)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(157, 674)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 75)
        Me.btnClear.TabIndex = 61
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(163, 535)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 26)
        Me.txtFirst.TabIndex = 50
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(411, 535)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 26)
        Me.txtLast.TabIndex = 51
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(674, 632)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(100, 26)
        Me.txtBirthday.TabIndex = 59
        '
        'cbxAddClass
        '
        Me.cbxAddClass.FormattingEnabled = True
        Me.cbxAddClass.Location = New System.Drawing.Point(103, 580)
        Me.cbxAddClass.Name = "cbxAddClass"
        Me.cbxAddClass.Size = New System.Drawing.Size(121, 28)
        Me.cbxAddClass.TabIndex = 54
        '
        'cbxAddLocation
        '
        Me.cbxAddLocation.FormattingEnabled = True
        Me.cbxAddLocation.Location = New System.Drawing.Point(362, 583)
        Me.cbxAddLocation.Name = "cbxAddLocation"
        Me.cbxAddLocation.Size = New System.Drawing.Size(121, 28)
        Me.cbxAddLocation.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 40)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Manage Players"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "First Name:"
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Location = New System.Drawing.Point(163, 69)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(185, 26)
        Me.txtNameSearch.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(368, 58)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 44)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(363, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Change Location:"
        '
        'cbxNewLocation
        '
        Me.cbxNewLocation.FormattingEnabled = True
        Me.cbxNewLocation.Location = New System.Drawing.Point(570, 200)
        Me.cbxNewLocation.Name = "cbxNewLocation"
        Me.cbxNewLocation.Size = New System.Drawing.Size(121, 28)
        Me.cbxNewLocation.TabIndex = 22
        '
        'cbxNewClass
        '
        Me.cbxNewClass.FormattingEnabled = True
        Me.cbxNewClass.Location = New System.Drawing.Point(547, 240)
        Me.cbxNewClass.Name = "cbxNewClass"
        Me.cbxNewClass.Size = New System.Drawing.Size(121, 28)
        Me.cbxNewClass.TabIndex = 23
        '
        'cbxNewDay
        '
        Me.cbxNewDay.FormattingEnabled = True
        Me.cbxNewDay.Location = New System.Drawing.Point(530, 278)
        Me.cbxNewDay.Name = "cbxNewDay"
        Me.cbxNewDay.Size = New System.Drawing.Size(121, 28)
        Me.cbxNewDay.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(363, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 28)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Change Class:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(363, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 28)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Change Day:"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChange.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Location = New System.Drawing.Point(368, 316)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(120, 75)
        Me.btnChange.TabIndex = 27
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpen.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(368, 108)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(120, 75)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(289, 630)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 28)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Phone Number:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 630)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 28)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "EMail:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(525, 535)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 28)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Guardian's Name:"
        '
        'txtGuardian
        '
        Me.txtGuardian.Location = New System.Drawing.Point(736, 538)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(100, 26)
        Me.txtGuardian.TabIndex = 52
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(473, 630)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 26)
        Me.txtPhone.TabIndex = 58
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(102, 633)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(181, 26)
        Me.txtMail.TabIndex = 57
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(721, 674)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 75)
        Me.btnExit.TabIndex = 35
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(507, 583)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 28)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Class Day:"
        '
        'cbxAddDay
        '
        Me.cbxAddDay.FormattingEnabled = True
        Me.cbxAddDay.Location = New System.Drawing.Point(640, 586)
        Me.cbxAddDay.Name = "cbxAddDay"
        Me.cbxAddDay.Size = New System.Drawing.Size(121, 28)
        Me.cbxAddDay.TabIndex = 56
        '
        'lbxKickers
        '
        Me.lbxKickers.FormattingEnabled = True
        Me.lbxKickers.ItemHeight = 20
        Me.lbxKickers.Location = New System.Drawing.Point(19, 108)
        Me.lbxKickers.Name = "lbxKickers"
        Me.lbxKickers.Size = New System.Drawing.Size(329, 364)
        Me.lbxKickers.TabIndex = 40
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(368, 397)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 75)
        Me.btnRemove.TabIndex = 41
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblDateExample
        '
        Me.lblDateExample.AutoSize = True
        Me.lblDateExample.Font = New System.Drawing.Font("Segoe UI Emoji", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateExample.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDateExample.Location = New System.Drawing.Point(670, 617)
        Me.lblDateExample.Name = "lblDateExample"
        Me.lblDateExample.Size = New System.Drawing.Size(108, 21)
        Me.lblDateExample.TabIndex = 62
        Me.lblDateExample.Text = "DD/MM/YYYY"
        Me.lblDateExample.Visible = False
        '
        'frmKickerManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 761)
        Me.Controls.Add(Me.lblDateExample)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lbxKickers)
        Me.Controls.Add(Me.cbxAddDay)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbxNewDay)
        Me.Controls.Add(Me.cbxNewClass)
        Me.Controls.Add(Me.cbxNewLocation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtNameSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxAddLocation)
        Me.Controls.Add(Me.cbxAddClass)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKickerManager"
        Me.Text = "Kickers Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents cbxAddClass As ComboBox
    Friend WithEvents cbxAddLocation As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNameSearch As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxNewLocation As ComboBox
    Friend WithEvents cbxNewClass As ComboBox
    Friend WithEvents cbxNewDay As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtGuardian As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents cbxAddDay As ComboBox
    Friend WithEvents lbxKickers As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblDateExample As Label
End Class
