<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyReport))
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtSubC = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBlockWiseTotal = New System.Windows.Forms.Label()
        Me.lblAbsentSeatNo = New System.Windows.Forms.Label()
        Me.lblAbsentStudent = New System.Windows.Forms.Label()
        Me.lblPresentStudent = New System.Windows.Forms.Label()
        Me.lblSubCode = New System.Windows.Forms.Label()
        Me.lblSubName = New System.Windows.Forms.Label()
        Me.lblBlockNo = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCR3 = New System.Windows.Forms.Button()
        Me.lblDailyReport = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(696, 336)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(121, 20)
        Me.TextBox10.TabIndex = 90
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(696, 294)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(121, 20)
        Me.TextBox8.TabIndex = 88
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(314, 519)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(121, 20)
        Me.TextBox6.TabIndex = 86
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(314, 472)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 84
        '
        'txtSubC
        '
        Me.txtSubC.Location = New System.Drawing.Point(314, 427)
        Me.txtSubC.Name = "txtSubC"
        Me.txtSubC.Size = New System.Drawing.Size(121, 20)
        Me.txtSubC.TabIndex = 83
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(314, 381)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 82
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(314, 336)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 81
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(314, 293)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 80
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(383, 247)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 79
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Evening"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(314, 249)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton1.TabIndex = 78
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Morning"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(497, 166)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 77
        '
        'lblBlockWiseTotal
        '
        Me.lblBlockWiseTotal.AutoSize = True
        Me.lblBlockWiseTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblBlockWiseTotal.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlockWiseTotal.Location = New System.Drawing.Point(498, 331)
        Me.lblBlockWiseTotal.Name = "lblBlockWiseTotal"
        Me.lblBlockWiseTotal.Size = New System.Drawing.Size(141, 25)
        Me.lblBlockWiseTotal.TabIndex = 75
        Me.lblBlockWiseTotal.Text = "Block Wise Total"
        '
        'lblAbsentSeatNo
        '
        Me.lblAbsentSeatNo.AutoSize = True
        Me.lblAbsentSeatNo.BackColor = System.Drawing.Color.Transparent
        Me.lblAbsentSeatNo.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsentSeatNo.Location = New System.Drawing.Point(508, 293)
        Me.lblAbsentSeatNo.Name = "lblAbsentSeatNo"
        Me.lblAbsentSeatNo.Size = New System.Drawing.Size(131, 25)
        Me.lblAbsentSeatNo.TabIndex = 72
        Me.lblAbsentSeatNo.Text = "Absent Seat No"
        '
        'lblAbsentStudent
        '
        Me.lblAbsentStudent.AutoSize = True
        Me.lblAbsentStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblAbsentStudent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsentStudent.Location = New System.Drawing.Point(170, 514)
        Me.lblAbsentStudent.Name = "lblAbsentStudent"
        Me.lblAbsentStudent.Size = New System.Drawing.Size(130, 25)
        Me.lblAbsentStudent.TabIndex = 69
        Me.lblAbsentStudent.Text = "Absent Student"
        '
        'lblPresentStudent
        '
        Me.lblPresentStudent.AutoSize = True
        Me.lblPresentStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblPresentStudent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentStudent.Location = New System.Drawing.Point(170, 467)
        Me.lblPresentStudent.Name = "lblPresentStudent"
        Me.lblPresentStudent.Size = New System.Drawing.Size(133, 25)
        Me.lblPresentStudent.TabIndex = 68
        Me.lblPresentStudent.Text = "Present Student"
        '
        'lblSubCode
        '
        Me.lblSubCode.AutoSize = True
        Me.lblSubCode.BackColor = System.Drawing.Color.Transparent
        Me.lblSubCode.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCode.Location = New System.Drawing.Point(170, 422)
        Me.lblSubCode.Name = "lblSubCode"
        Me.lblSubCode.Size = New System.Drawing.Size(81, 25)
        Me.lblSubCode.TabIndex = 67
        Me.lblSubCode.Text = "Sub Code"
        '
        'lblSubName
        '
        Me.lblSubName.AutoSize = True
        Me.lblSubName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubName.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubName.Location = New System.Drawing.Point(170, 376)
        Me.lblSubName.Name = "lblSubName"
        Me.lblSubName.Size = New System.Drawing.Size(90, 25)
        Me.lblSubName.TabIndex = 66
        Me.lblSubName.Text = "Sub Name"
        '
        'lblBlockNo
        '
        Me.lblBlockNo.AutoSize = True
        Me.lblBlockNo.BackColor = System.Drawing.Color.Transparent
        Me.lblBlockNo.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlockNo.Location = New System.Drawing.Point(170, 331)
        Me.lblBlockNo.Name = "lblBlockNo"
        Me.lblBlockNo.Size = New System.Drawing.Size(82, 25)
        Me.lblBlockNo.TabIndex = 65
        Me.lblBlockNo.Text = "Block No"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.BackColor = System.Drawing.Color.Transparent
        Me.lblSemester.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(170, 289)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(76, 25)
        Me.lblSemester.TabIndex = 64
        Me.lblSemester.Text = "Semester"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.BackColor = System.Drawing.Color.Transparent
        Me.lblSession.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(170, 246)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(66, 25)
        Me.lblSession.TabIndex = 63
        Me.lblSession.Text = "Session"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(426, 164)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 25)
        Me.lblDate.TabIndex = 62
        Me.lblDate.Text = "Date"
        '
        'btnCR3
        '
        Me.btnCR3.BackColor = System.Drawing.Color.Transparent
        Me.btnCR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCR3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCR3.Location = New System.Drawing.Point(552, 519)
        Me.btnCR3.Name = "btnCR3"
        Me.btnCR3.Size = New System.Drawing.Size(162, 64)
        Me.btnCR3.TabIndex = 94
        Me.btnCR3.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCR3.UseVisualStyleBackColor = False
        '
        'lblDailyReport
        '
        Me.lblDailyReport.AutoSize = True
        Me.lblDailyReport.BackColor = System.Drawing.Color.Transparent
        Me.lblDailyReport.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyReport.Location = New System.Drawing.Point(375, 40)
        Me.lblDailyReport.Name = "lblDailyReport"
        Me.lblDailyReport.Size = New System.Drawing.Size(247, 57)
        Me.lblDailyReport.TabIndex = 95
        Me.lblDailyReport.Text = "Daily Report"
        '
        'frmDailyReport
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1043, 741)
        Me.Controls.Add(Me.lblDailyReport)
        Me.Controls.Add(Me.btnCR3)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtSubC)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblBlockWiseTotal)
        Me.Controls.Add(Me.lblAbsentSeatNo)
        Me.Controls.Add(Me.lblAbsentStudent)
        Me.Controls.Add(Me.lblPresentStudent)
        Me.Controls.Add(Me.lblSubCode)
        Me.Controls.Add(Me.lblSubName)
        Me.Controls.Add(Me.lblBlockNo)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmDailyReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDailyReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubC As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBlockWiseTotal As System.Windows.Forms.Label
    Friend WithEvents lblAbsentSeatNo As System.Windows.Forms.Label
    Friend WithEvents lblAbsentStudent As System.Windows.Forms.Label
    Friend WithEvents lblPresentStudent As System.Windows.Forms.Label
    Friend WithEvents lblSubCode As System.Windows.Forms.Label
    Friend WithEvents lblSubName As System.Windows.Forms.Label
    Friend WithEvents lblBlockNo As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnCR3 As System.Windows.Forms.Button
    Friend WithEvents lblDailyReport As System.Windows.Forms.Label
End Class
