<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGems))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.imgGEMS = New System.Windows.Forms.PictureBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        CType(Me.imgGEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(508, 411)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(450, 371)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(202, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Tag = ""
        Me.txtPassword.Text = "Enter Password"
        '
        'imgGEMS
        '
        Me.imgGEMS.BackColor = System.Drawing.Color.Transparent
        Me.imgGEMS.BackgroundImage = CType(resources.GetObject("imgGEMS.BackgroundImage"), System.Drawing.Image)
        Me.imgGEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgGEMS.Location = New System.Drawing.Point(210, 112)
        Me.imgGEMS.Name = "imgGEMS"
        Me.imgGEMS.Size = New System.Drawing.Size(628, 223)
        Me.imgGEMS.TabIndex = 10
        Me.imgGEMS.TabStop = False
        '
        'lblTo
        '
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTo.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.Black
        Me.lblTo.Location = New System.Drawing.Point(13, 63)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(1002, 138)
        Me.lblTo.TabIndex = 9
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWelcome.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(-2, 2)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1002, 138)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmGems
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1012, 595)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.imgGEMS)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "frmGems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frgGems"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgGEMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents imgGEMS As System.Windows.Forms.PictureBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
End Class
