<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpwelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpwelcome))
        Me.lblWel = New System.Windows.Forms.Label()
        Me.btnRole = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWel
        '
        Me.lblWel.AutoSize = True
        Me.lblWel.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWel.ForeColor = System.Drawing.Color.White
        Me.lblWel.Location = New System.Drawing.Point(12, 9)
        Me.lblWel.Name = "lblWel"
        Me.lblWel.Size = New System.Drawing.Size(312, 79)
        Me.lblWel.TabIndex = 0
        Me.lblWel.Text = "Welcome"
        '
        'btnRole
        '
        Me.btnRole.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRole.Location = New System.Drawing.Point(183, 280)
        Me.btnRole.Name = "btnRole"
        Me.btnRole.Size = New System.Drawing.Size(141, 79)
        Me.btnRole.TabIndex = 100
        Me.btnRole.Text = "Role"
        Me.btnRole.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInfo.Location = New System.Drawing.Point(26, 280)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(141, 79)
        Me.btnInfo.TabIndex = 99
        Me.btnInfo.Text = "Form"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(12, 88)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(211, 79)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.ForeColor = System.Drawing.Color.White
        Me.lblQuote.Location = New System.Drawing.Point(20, 185)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(94, 33)
        Me.lblQuote.TabIndex = 5
        Me.lblQuote.Text = "Quote"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(363, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(102, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 79)
        Me.btnExit.TabIndex = 102
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEmpwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 491)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnRole)
        Me.Controls.Add(Me.lblWel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpwelcome"
        Me.Text = "Welcome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWel As Label
    Friend WithEvents btnRole As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblQuote As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
End Class
