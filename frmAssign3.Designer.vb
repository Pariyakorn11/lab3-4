<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign3
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
        Me.txtDigis = New System.Windows.Forms.TextBox()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDigis
        '
        Me.txtDigis.Location = New System.Drawing.Point(179, 30)
        Me.txtDigis.Multiline = True
        Me.txtDigis.Name = "txtDigis"
        Me.txtDigis.Size = New System.Drawing.Size(118, 48)
        Me.txtDigis.TabIndex = 0
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(303, 28)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(32, 22)
        Me.btnHigh.TabIndex = 1
        Me.btnHigh.Text = "+"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(303, 56)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(32, 22)
        Me.btnLow.TabIndex = 1
        Me.btnLow.Text = "-"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"10", "14", "18", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70"})
        Me.cboSelect.Location = New System.Drawing.Point(257, 84)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(78, 21)
        Me.cboSelect.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFOrange.Location = New System.Drawing.Point(7, 56)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(34, 26)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFYellow.Location = New System.Drawing.Point(47, 56)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(34, 26)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBrown.Location = New System.Drawing.Point(87, 56)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(34, 26)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWhite.Location = New System.Drawing.Point(127, 56)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(34, 26)
        Me.lblFWhite.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFSky.Location = New System.Drawing.Point(167, 56)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(34, 26)
        Me.lblFSky.TabIndex = 0
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFRed.Location = New System.Drawing.Point(7, 16)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(34, 26)
        Me.lblFRed.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBlue.Location = New System.Drawing.Point(47, 16)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(34, 26)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Lime
        Me.lblFGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFGreen.Location = New System.Drawing.Point(87, 16)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(34, 26)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFViolet.Location = New System.Drawing.Point(127, 16)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(34, 26)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBlack.Location = New System.Drawing.Point(167, 16)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(34, 26)
        Me.lblFBlack.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBlack.Location = New System.Drawing.Point(167, 16)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(34, 26)
        Me.lblBBlack.TabIndex = 0
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBViolet.Location = New System.Drawing.Point(127, 16)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(34, 26)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSky.Location = New System.Drawing.Point(167, 56)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(34, 26)
        Me.lblBSky.TabIndex = 0
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Lime
        Me.lblBGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBGreen.Location = New System.Drawing.Point(87, 16)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(34, 26)
        Me.lblBGreen.TabIndex = 0
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBWhite.Location = New System.Drawing.Point(127, 56)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(34, 26)
        Me.lblBWhite.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBlue.Location = New System.Drawing.Point(47, 16)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(34, 26)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBrown.Location = New System.Drawing.Point(87, 56)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(34, 26)
        Me.lblBBrown.TabIndex = 0
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRed.Location = New System.Drawing.Point(7, 16)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(34, 26)
        Me.lblBRed.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBYellow.Location = New System.Drawing.Point(47, 56)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(34, 26)
        Me.lblBYellow.TabIndex = 0
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBOrange.Location = New System.Drawing.Point(7, 56)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(34, 26)
        Me.lblBOrange.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ขนาดฟอนด์"
        '
        'frmAssign3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 242)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.txtDigis)
        Me.Name = "frmAssign3"
        Me.Text = "frmAssign3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDigis As System.Windows.Forms.TextBox
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBBlack As System.Windows.Forms.Label
    Friend WithEvents lblBViolet As System.Windows.Forms.Label
    Friend WithEvents lblBSky As System.Windows.Forms.Label
    Friend WithEvents lblBGreen As System.Windows.Forms.Label
    Friend WithEvents lblBWhite As System.Windows.Forms.Label
    Friend WithEvents lblBBlue As System.Windows.Forms.Label
    Friend WithEvents lblBBrown As System.Windows.Forms.Label
    Friend WithEvents lblBRed As System.Windows.Forms.Label
    Friend WithEvents lblBYellow As System.Windows.Forms.Label
    Friend WithEvents lblBOrange As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
