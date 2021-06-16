<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlockReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlockReport))
        Me.txtNoOfStaff = New System.Windows.Forms.TextBox()
        Me.txtNoOfBlocks = New System.Windows.Forms.TextBox()
        Me.txtSubName = New System.Windows.Forms.TextBox()
        Me.txtSubCode = New System.Windows.Forms.TextBox()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.rbEvening = New System.Windows.Forms.RadioButton()
        Me.rbMorning = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNoOfStaff = New System.Windows.Forms.Label()
        Me.lblNoOfBlocks = New System.Windows.Forms.Label()
        Me.lblSubName = New System.Windows.Forms.Label()
        Me.lblSubCode = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblDtae = New System.Windows.Forms.Label()
        Me.btnCR2 = New System.Windows.Forms.Button()
        Me.lblBlockReport = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNoOfStaff
        '
        Me.txtNoOfStaff.Location = New System.Drawing.Point(490, 446)
        Me.txtNoOfStaff.Name = "txtNoOfStaff"
        Me.txtNoOfStaff.Size = New System.Drawing.Size(121, 20)
        Me.txtNoOfStaff.TabIndex = 44
        '
        'txtNoOfBlocks
        '
        Me.txtNoOfBlocks.Location = New System.Drawing.Point(490, 389)
        Me.txtNoOfBlocks.Name = "txtNoOfBlocks"
        Me.txtNoOfBlocks.Size = New System.Drawing.Size(121, 20)
        Me.txtNoOfBlocks.TabIndex = 43
        '
        'txtSubName
        '
        Me.txtSubName.Location = New System.Drawing.Point(490, 277)
        Me.txtSubName.Name = "txtSubName"
        Me.txtSubName.Size = New System.Drawing.Size(121, 20)
        Me.txtSubName.TabIndex = 42
        '
        'txtSubCode
        '
        Me.txtSubCode.Location = New System.Drawing.Point(490, 334)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.Size = New System.Drawing.Size(121, 20)
        Me.txtSubCode.TabIndex = 41
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Location = New System.Drawing.Point(490, 222)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(121, 21)
        Me.cbSemester.TabIndex = 40
        '
        'rbEvening
        '
        Me.rbEvening.AutoSize = True
        Me.rbEvening.BackColor = System.Drawing.Color.Transparent
        Me.rbEvening.Location = New System.Drawing.Point(547, 175)
        Me.rbEvening.Name = "rbEvening"
        Me.rbEvening.Size = New System.Drawing.Size(64, 17)
        Me.rbEvening.TabIndex = 39
        Me.rbEvening.TabStop = True
        Me.rbEvening.Text = "Evening"
        Me.rbEvening.UseVisualStyleBackColor = False
        '
        'rbMorning
        '
        Me.rbMorning.AutoSize = True
        Me.rbMorning.BackColor = System.Drawing.Color.Transparent
        Me.rbMorning.Location = New System.Drawing.Point(478, 175)
        Me.rbMorning.Name = "rbMorning"
        Me.rbMorning.Size = New System.Drawing.Size(63, 17)
        Me.rbMorning.TabIndex = 38
        Me.rbMorning.TabStop = True
        Me.rbMorning.Text = "Morning"
        Me.rbMorning.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(411, 129)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 37
        '
        'lblNoOfStaff
        '
        Me.lblNoOfStaff.AutoSize = True
        Me.lblNoOfStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfStaff.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaff.Location = New System.Drawing.Point(356, 441)
        Me.lblNoOfStaff.Name = "lblNoOfStaff"
        Me.lblNoOfStaff.Size = New System.Drawing.Size(105, 25)
        Me.lblNoOfStaff.TabIndex = 36
        Me.lblNoOfStaff.Text = "No Of Staff"
        '
        'lblNoOfBlocks
        '
        Me.lblNoOfBlocks.AutoSize = True
        Me.lblNoOfBlocks.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfBlocks.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBlocks.Location = New System.Drawing.Point(356, 384)
        Me.lblNoOfBlocks.Name = "lblNoOfBlocks"
        Me.lblNoOfBlocks.Size = New System.Drawing.Size(114, 25)
        Me.lblNoOfBlocks.TabIndex = 35
        Me.lblNoOfBlocks.Text = "No Of Blocks"
        '
        'lblSubName
        '
        Me.lblSubName.AutoSize = True
        Me.lblSubName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubName.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubName.Location = New System.Drawing.Point(356, 272)
        Me.lblSubName.Name = "lblSubName"
        Me.lblSubName.Size = New System.Drawing.Size(90, 25)
        Me.lblSubName.TabIndex = 34
        Me.lblSubName.Text = "Sub Name"
        '
        'lblSubCode
        '
        Me.lblSubCode.AutoSize = True
        Me.lblSubCode.BackColor = System.Drawing.Color.Transparent
        Me.lblSubCode.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCode.Location = New System.Drawing.Point(356, 329)
        Me.lblSubCode.Name = "lblSubCode"
        Me.lblSubCode.Size = New System.Drawing.Size(81, 25)
        Me.lblSubCode.TabIndex = 33
        Me.lblSubCode.Text = "Sub Code"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.BackColor = System.Drawing.Color.Transparent
        Me.lblSemester.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(356, 222)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(76, 25)
        Me.lblSemester.TabIndex = 32
        Me.lblSemester.Text = "Semester"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.BackColor = System.Drawing.Color.Transparent
        Me.lblSession.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(356, 167)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(66, 25)
        Me.lblSession.TabIndex = 31
        Me.lblSession.Text = "Session"
        '
        'lblDtae
        '
        Me.lblDtae.AutoSize = True
        Me.lblDtae.BackColor = System.Drawing.Color.Transparent
        Me.lblDtae.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtae.Location = New System.Drawing.Point(356, 127)
        Me.lblDtae.Name = "lblDtae"
        Me.lblDtae.Size = New System.Drawing.Size(50, 25)
        Me.lblDtae.TabIndex = 30
        Me.lblDtae.Text = "Date"
        '
        'btnCR2
        '
        Me.btnCR2.BackColor = System.Drawing.Color.Transparent
        Me.btnCR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCR2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCR2.Location = New System.Drawing.Point(472, 484)
        Me.btnCR2.Name = "btnCR2"
        Me.btnCR2.Size = New System.Drawing.Size(162, 64)
        Me.btnCR2.TabIndex = 46
        Me.btnCR2.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCR2.UseVisualStyleBackColor = False
        '
        'lblBlockReport
        '
        Me.lblBlockReport.AutoSize = True
        Me.lblBlockReport.BackColor = System.Drawing.Color.Transparent
        Me.lblBlockReport.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlockReport.Location = New System.Drawing.Point(375, 40)
        Me.lblBlockReport.Name = "lblBlockReport"
        Me.lblBlockReport.Size = New System.Drawing.Size(247, 57)
        Me.lblBlockReport.TabIndex = 47
        Me.lblBlockReport.Text = "Block Report"
        '
        'frmBlockReport
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 586)
        Me.Controls.Add(Me.lblBlockReport)
        Me.Controls.Add(Me.btnCR2)
        Me.Controls.Add(Me.txtNoOfStaff)
        Me.Controls.Add(Me.txtNoOfBlocks)
        Me.Controls.Add(Me.txtSubName)
        Me.Controls.Add(Me.txtSubCode)
        Me.Controls.Add(Me.cbSemester)
        Me.Controls.Add(Me.rbEvening)
        Me.Controls.Add(Me.rbMorning)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblNoOfStaff)
        Me.Controls.Add(Me.lblNoOfBlocks)
        Me.Controls.Add(Me.lblSubName)
        Me.Controls.Add(Me.lblSubCode)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblDtae)
        Me.Name = "frmBlockReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBlockReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoOfStaff As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfBlocks As System.Windows.Forms.TextBox
    Friend WithEvents txtSubName As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCode As System.Windows.Forms.TextBox
    Friend WithEvents cbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents rbEvening As System.Windows.Forms.RadioButton
    Friend WithEvents rbMorning As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNoOfStaff As System.Windows.Forms.Label
    Friend WithEvents lblNoOfBlocks As System.Windows.Forms.Label
    Friend WithEvents lblSubName As System.Windows.Forms.Label
    Friend WithEvents lblSubCode As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents lblDtae As System.Windows.Forms.Label
    Friend WithEvents btnCR2 As System.Windows.Forms.Button
    Friend WithEvents lblBlockReport As System.Windows.Forms.Label
End Class
