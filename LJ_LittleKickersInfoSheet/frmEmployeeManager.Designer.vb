<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeManager
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearEmployee = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.lbxEmployee = New System.Windows.Forms.ListBox()
        Me.lblDateExample = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(14, 50)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 36)
        Me.txtSearch.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoad.Location = New System.Drawing.Point(209, 49)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(100, 30)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Increase Pay To:"
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(320, 197)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(47, 36)
        Me.txtPay.TabIndex = 4
        '
        'btnInfo
        '
        Me.btnInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInfo.Location = New System.Drawing.Point(209, 84)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 50)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "Employee Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(209, 142)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 50)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnIncrease
        '
        Me.btnIncrease.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIncrease.Location = New System.Drawing.Point(209, 225)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(100, 50)
        Me.btnIncrease.TabIndex = 7
        Me.btnIncrease.Text = "Increase"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 311)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 343)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 344)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 378)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "EMail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 378)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 276)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 40)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "New Employee:"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(320, 306)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(140, 36)
        Me.txtLast.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(92, 339)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(140, 36)
        Me.txtUser.TabIndex = 15
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(311, 338)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(140, 36)
        Me.txtPass.TabIndex = 16
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(59, 373)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(140, 36)
        Me.txtMail.TabIndex = 17
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(339, 373)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(140, 36)
        Me.txtPhone.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(20, 440)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 50)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClearEmployee
        '
        Me.btnClearEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClearEmployee.Location = New System.Drawing.Point(110, 440)
        Me.btnClearEmployee.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnClearEmployee.Name = "btnClearEmployee"
        Me.btnClearEmployee.Size = New System.Drawing.Size(80, 50)
        Me.btnClearEmployee.TabIndex = 20
        Me.btnClearEmployee.Text = "Clear"
        Me.btnClearEmployee.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(399, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 50)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(96, 306)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(140, 36)
        Me.txtFirst.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(242, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(322, 41)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Manage Employees"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Starting Rate:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(242, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 23)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "D.O.B:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(108, 406)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(131, 36)
        Me.txtRate.TabIndex = 27
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(287, 406)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(140, 36)
        Me.txtBirthday.TabIndex = 28
        '
        'lbxEmployee
        '
        Me.lbxEmployee.Font = New System.Drawing.Font("Sans Serif Collection", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEmployee.FormattingEnabled = True
        Me.lbxEmployee.ItemHeight = 54
        Me.lbxEmployee.Location = New System.Drawing.Point(17, 84)
        Me.lbxEmployee.Name = "lbxEmployee"
        Me.lbxEmployee.Size = New System.Drawing.Size(184, 166)
        Me.lbxEmployee.TabIndex = 29
        '
        'lblDateExample
        '
        Me.lblDateExample.AutoSize = True
        Me.lblDateExample.Font = New System.Drawing.Font("Segoe UI Emoji", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateExample.Location = New System.Drawing.Point(285, 433)
        Me.lblDateExample.Name = "lblDateExample"
        Me.lblDateExample.Size = New System.Drawing.Size(108, 21)
        Me.lblDateExample.TabIndex = 30
        Me.lblDateExample.Text = "DD/MM/YYYY"
        Me.lblDateExample.Visible = False
        '
        'frmEmployeeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 511)
        Me.Controls.Add(Me.lblDateExample)
        Me.Controls.Add(Me.lbxEmployee)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearEmployee)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmEmployeeManager"
        Me.Text = "Employee Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPay As TextBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnIncrease As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClearEmployee As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents lbxEmployee As ListBox
    Friend WithEvents lblDateExample As Label
End Class
