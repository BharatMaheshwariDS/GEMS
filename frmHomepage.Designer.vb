<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomepage))
        Me.tsModules = New System.Windows.Forms.ToolStrip()
        Me.btnDutyOrder = New System.Windows.Forms.ToolStripButton()
        Me.btnBlockReport = New System.Windows.Forms.ToolStripButton()
        Me.btnDailyReport = New System.Windows.Forms.ToolStripButton()
        Me.btnRemunerationBill = New System.Windows.Forms.ToolStripButton()
        Me.btnLogout = New System.Windows.Forms.ToolStripButton()
        Me.tsHeaderImage = New System.Windows.Forms.ToolStrip()
        Me.tsModules.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsModules
        '
        Me.tsModules.BackColor = System.Drawing.SystemColors.Control
        Me.tsModules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsModules.Dock = System.Windows.Forms.DockStyle.Left
        Me.tsModules.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tsModules.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDutyOrder, Me.btnBlockReport, Me.btnDailyReport, Me.btnRemunerationBill, Me.btnLogout})
        Me.tsModules.Location = New System.Drawing.Point(0, 172)
        Me.tsModules.Name = "tsModules"
        Me.tsModules.Size = New System.Drawing.Size(158, 569)
        Me.tsModules.TabIndex = 3
        '
        'btnDutyOrder
        '
        Me.btnDutyOrder.BackgroundImage = CType(resources.GetObject("btnDutyOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnDutyOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDutyOrder.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDutyOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDutyOrder.Name = "btnDutyOrder"
        Me.btnDutyOrder.Size = New System.Drawing.Size(155, 27)
        Me.btnDutyOrder.Text = "Duty Order"
        '
        'btnBlockReport
        '
        Me.btnBlockReport.BackgroundImage = CType(resources.GetObject("btnBlockReport.BackgroundImage"), System.Drawing.Image)
        Me.btnBlockReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBlockReport.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBlockReport.Name = "btnBlockReport"
        Me.btnBlockReport.Size = New System.Drawing.Size(155, 27)
        Me.btnBlockReport.Text = "Block Report"
        '
        'btnDailyReport
        '
        Me.btnDailyReport.BackgroundImage = CType(resources.GetObject("btnDailyReport.BackgroundImage"), System.Drawing.Image)
        Me.btnDailyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDailyReport.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDailyReport.Name = "btnDailyReport"
        Me.btnDailyReport.Size = New System.Drawing.Size(155, 27)
        Me.btnDailyReport.Text = "DailyReport"
        '
        'btnRemunerationBill
        '
        Me.btnRemunerationBill.BackgroundImage = CType(resources.GetObject("btnRemunerationBill.BackgroundImage"), System.Drawing.Image)
        Me.btnRemunerationBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemunerationBill.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemunerationBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemunerationBill.Name = "btnRemunerationBill"
        Me.btnRemunerationBill.Size = New System.Drawing.Size(155, 27)
        Me.btnRemunerationBill.Text = "Remuneration Bill"
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(155, 27)
        Me.btnLogout.Text = "LogOut"
        '
        'tsHeaderImage
        '
        Me.tsHeaderImage.AutoSize = False
        Me.tsHeaderImage.BackgroundImage = CType(resources.GetObject("tsHeaderImage.BackgroundImage"), System.Drawing.Image)
        Me.tsHeaderImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsHeaderImage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsHeaderImage.Location = New System.Drawing.Point(0, 0)
        Me.tsHeaderImage.Name = "tsHeaderImage"
        Me.tsHeaderImage.Size = New System.Drawing.Size(1244, 172)
        Me.tsHeaderImage.TabIndex = 2
        '
        'frmHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1244, 741)
        Me.Controls.Add(Me.tsModules)
        Me.Controls.Add(Me.tsHeaderImage)
        Me.IsMdiContainer = True
        Me.Name = "frmHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsModules.ResumeLayout(False)
        Me.tsModules.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsModules As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDutyOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBlockReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRemunerationBill As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDailyReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLogout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHeaderImage As System.Windows.Forms.ToolStrip

End Class
