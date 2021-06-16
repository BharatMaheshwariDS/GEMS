<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDutyOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDutyOrder))
        Me.clbPeon = New System.Windows.Forms.CheckedListBox()
        Me.clbSTSuprvisior = New System.Windows.Forms.CheckedListBox()
        Me.CclbJRSupervisor = New System.Windows.Forms.CheckedListBox()
        Me.lblPeon = New System.Windows.Forms.Label()
        Me.lblSTSupervisior = New System.Windows.Forms.Label()
        Me.lblJRSupervisor = New System.Windows.Forms.Label()
        Me.clbSRSupervisor = New System.Windows.Forms.CheckedListBox()
        Me.lblSRSupervisor = New System.Windows.Forms.Label()
        Me.txtTotalBlocks = New System.Windows.Forms.TextBox()
        Me.lblTotalBlock = New System.Windows.Forms.Label()
        Me.rbEvening = New System.Windows.Forms.RadioButton()
        Me.rbMorning = New System.Windows.Forms.RadioButton()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCR2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDutyOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clbPeon
        '
        Me.clbPeon.FormattingEnabled = True
        Me.clbPeon.Location = New System.Drawing.Point(502, 575)
        Me.clbPeon.Name = "clbPeon"
        Me.clbPeon.Size = New System.Drawing.Size(141, 64)
        Me.clbPeon.TabIndex = 50
        '
        'clbSTSuprvisior
        '
        Me.clbSTSuprvisior.FormattingEnabled = True
        Me.clbSTSuprvisior.Location = New System.Drawing.Point(502, 485)
        Me.clbSTSuprvisior.Name = "clbSTSuprvisior"
        Me.clbSTSuprvisior.Size = New System.Drawing.Size(141, 64)
        Me.clbSTSuprvisior.TabIndex = 49
        '
        'CclbJRSupervisor
        '
        Me.CclbJRSupervisor.FormattingEnabled = True
        Me.CclbJRSupervisor.Location = New System.Drawing.Point(501, 393)
        Me.CclbJRSupervisor.Name = "CclbJRSupervisor"
        Me.CclbJRSupervisor.Size = New System.Drawing.Size(142, 64)
        Me.CclbJRSupervisor.TabIndex = 48
        '
        'lblPeon
        '
        Me.lblPeon.AutoSize = True
        Me.lblPeon.BackColor = System.Drawing.Color.Transparent
        Me.lblPeon.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeon.Location = New System.Drawing.Point(361, 575)
        Me.lblPeon.Name = "lblPeon"
        Me.lblPeon.Size = New System.Drawing.Size(49, 25)
        Me.lblPeon.TabIndex = 47
        Me.lblPeon.Text = "Peon"
        '
        'lblSTSupervisior
        '
        Me.lblSTSupervisior.AutoSize = True
        Me.lblSTSupervisior.BackColor = System.Drawing.Color.Transparent
        Me.lblSTSupervisior.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTSupervisior.Location = New System.Drawing.Point(363, 485)
        Me.lblSTSupervisior.Name = "lblSTSupervisior"
        Me.lblSTSupervisior.Size = New System.Drawing.Size(115, 25)
        Me.lblSTSupervisior.TabIndex = 46
        Me.lblSTSupervisior.Text = "ST Supervisor"
        '
        'lblJRSupervisor
        '
        Me.lblJRSupervisor.AutoSize = True
        Me.lblJRSupervisor.BackColor = System.Drawing.Color.Transparent
        Me.lblJRSupervisor.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJRSupervisor.Location = New System.Drawing.Point(361, 393)
        Me.lblJRSupervisor.Name = "lblJRSupervisor"
        Me.lblJRSupervisor.Size = New System.Drawing.Size(115, 25)
        Me.lblJRSupervisor.TabIndex = 45
        Me.lblJRSupervisor.Text = "JR Supervisor"
        '
        'clbSRSupervisor
        '
        Me.clbSRSupervisor.FormattingEnabled = True
        Me.clbSRSupervisor.Location = New System.Drawing.Point(500, 295)
        Me.clbSRSupervisor.Name = "clbSRSupervisor"
        Me.clbSRSupervisor.Size = New System.Drawing.Size(142, 64)
        Me.clbSRSupervisor.TabIndex = 44
        '
        'lblSRSupervisor
        '
        Me.lblSRSupervisor.AutoSize = True
        Me.lblSRSupervisor.BackColor = System.Drawing.Color.Transparent
        Me.lblSRSupervisor.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRSupervisor.Location = New System.Drawing.Point(361, 295)
        Me.lblSRSupervisor.Name = "lblSRSupervisor"
        Me.lblSRSupervisor.Size = New System.Drawing.Size(117, 25)
        Me.lblSRSupervisor.TabIndex = 43
        Me.lblSRSupervisor.Text = "SR Supervisor"
        '
        'txtTotalBlocks
        '
        Me.txtTotalBlocks.Location = New System.Drawing.Point(501, 242)
        Me.txtTotalBlocks.Name = "txtTotalBlocks"
        Me.txtTotalBlocks.Size = New System.Drawing.Size(142, 20)
        Me.txtTotalBlocks.TabIndex = 42
        '
        'lblTotalBlock
        '
        Me.lblTotalBlock.AutoSize = True
        Me.lblTotalBlock.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBlock.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBlock.Location = New System.Drawing.Point(360, 242)
        Me.lblTotalBlock.Name = "lblTotalBlock"
        Me.lblTotalBlock.Size = New System.Drawing.Size(106, 25)
        Me.lblTotalBlock.TabIndex = 41
        Me.lblTotalBlock.Text = "Total Blocks"
        '
        'rbEvening
        '
        Me.rbEvening.AutoSize = True
        Me.rbEvening.BackColor = System.Drawing.Color.Transparent
        Me.rbEvening.Location = New System.Drawing.Point(579, 209)
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
        Me.rbMorning.Location = New System.Drawing.Point(501, 209)
        Me.rbMorning.Name = "rbMorning"
        Me.rbMorning.Size = New System.Drawing.Size(63, 17)
        Me.rbMorning.TabIndex = 37
        Me.rbMorning.TabStop = True
        Me.rbMorning.Text = "Morning"
        Me.rbMorning.UseVisualStyleBackColor = False
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.BackColor = System.Drawing.Color.Transparent
        Me.lblSession.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(360, 201)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(66, 25)
        Me.lblSession.TabIndex = 36
        Me.lblSession.Text = "Session"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(443, 163)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 35
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(360, 158)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 25)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Date"
        '
        'btnCR2
        '
        Me.btnCR2.BackColor = System.Drawing.Color.Transparent
        Me.btnCR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCR2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCR2.Location = New System.Drawing.Point(501, 663)
        Me.btnCR2.Name = "btnCR2"
        Me.btnCR2.Size = New System.Drawing.Size(162, 64)
        Me.btnCR2.TabIndex = 52
        Me.btnCR2.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report"
        Me.btnCR2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(499, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Required Supervisiors :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(499, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Required Supervisiors :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(499, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Required Supervisiors :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(499, 559)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Required Peons :"
        '
        'lblDutyOrder
        '
        Me.lblDutyOrder.AutoSize = True
        Me.lblDutyOrder.BackColor = System.Drawing.Color.Transparent
        Me.lblDutyOrder.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDutyOrder.Location = New System.Drawing.Point(375, 40)
        Me.lblDutyOrder.Name = "lblDutyOrder"
        Me.lblDutyOrder.Size = New System.Drawing.Size(220, 57)
        Me.lblDutyOrder.TabIndex = 57
        Me.lblDutyOrder.Text = "Duty Order"
        '
        'frmDutyOrder
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1046, 741)
        Me.Controls.Add(Me.lblDutyOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCR2)
        Me.Controls.Add(Me.clbPeon)
        Me.Controls.Add(Me.clbSTSuprvisior)
        Me.Controls.Add(Me.CclbJRSupervisor)
        Me.Controls.Add(Me.lblPeon)
        Me.Controls.Add(Me.lblSTSupervisior)
        Me.Controls.Add(Me.lblJRSupervisor)
        Me.Controls.Add(Me.clbSRSupervisor)
        Me.Controls.Add(Me.lblSRSupervisor)
        Me.Controls.Add(Me.txtTotalBlocks)
        Me.Controls.Add(Me.lblTotalBlock)
        Me.Controls.Add(Me.rbEvening)
        Me.Controls.Add(Me.rbMorning)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmDutyOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDutyOrder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbPeon As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbSTSuprvisior As System.Windows.Forms.CheckedListBox
    Friend WithEvents CclbJRSupervisor As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblPeon As System.Windows.Forms.Label
    Friend WithEvents lblSTSupervisior As System.Windows.Forms.Label
    Friend WithEvents lblJRSupervisor As System.Windows.Forms.Label
    Friend WithEvents clbSRSupervisor As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblSRSupervisor As System.Windows.Forms.Label
    Friend WithEvents txtTotalBlocks As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBlock As System.Windows.Forms.Label
    Friend WithEvents rbEvening As System.Windows.Forms.RadioButton
    Friend WithEvents rbMorning As System.Windows.Forms.RadioButton
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnCR2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDutyOrder As System.Windows.Forms.Label
End Class
