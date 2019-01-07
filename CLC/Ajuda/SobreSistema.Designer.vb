<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SobreSistema
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

    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SobreSistema))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.txtObjetivos = New System.Windows.Forms.TextBox
        Me.lblProd = New System.Windows.Forms.Label
        Me.lblVer = New System.Windows.Forms.Label
        Me.lblCopy = New System.Windows.Forms.Label
        Me.lblLic = New System.Windows.Forms.Label
        Me.lblBaseId = New System.Windows.Forms.Label
        Me.lblBase = New System.Windows.Forms.Label
        Me.lblBaseAtu = New System.Windows.Forms.Label
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.ErrorImage = Nothing
        Me.LogoPictureBox.Image = Global.CLC.My.Resources.Resources.CLCVersao
        Me.LogoPictureBox.InitialImage = Nothing
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 6)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(326, 402)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'txtObjetivos
        '
        Me.txtObjetivos.Location = New System.Drawing.Point(350, 194)
        Me.txtObjetivos.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.txtObjetivos.Multiline = True
        Me.txtObjetivos.Name = "txtObjetivos"
        Me.txtObjetivos.ReadOnly = True
        Me.txtObjetivos.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObjetivos.Size = New System.Drawing.Size(405, 207)
        Me.txtObjetivos.TabIndex = 0
        Me.txtObjetivos.TabStop = False
        Me.txtObjetivos.Text = "Objetivos..."
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Location = New System.Drawing.Point(347, 12)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(39, 13)
        Me.lblProd.TabIndex = 8
        Me.lblProd.Text = "Label1"
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(347, 35)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(39, 13)
        Me.lblVer.TabIndex = 8
        Me.lblVer.Text = "Label1"
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Location = New System.Drawing.Point(347, 58)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(39, 13)
        Me.lblCopy.TabIndex = 8
        Me.lblCopy.Text = "Label1"
        '
        'lblLic
        '
        Me.lblLic.AutoSize = True
        Me.lblLic.Location = New System.Drawing.Point(347, 81)
        Me.lblLic.Name = "lblLic"
        Me.lblLic.Size = New System.Drawing.Size(39, 13)
        Me.lblLic.TabIndex = 8
        Me.lblLic.Text = "Label1"
        '
        'lblBaseId
        '
        Me.lblBaseId.AutoSize = True
        Me.lblBaseId.Location = New System.Drawing.Point(347, 127)
        Me.lblBaseId.Name = "lblBaseId"
        Me.lblBaseId.Size = New System.Drawing.Size(39, 13)
        Me.lblBaseId.TabIndex = 8
        Me.lblBaseId.Text = "Label1"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(347, 104)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(39, 13)
        Me.lblBase.TabIndex = 8
        Me.lblBase.Text = "Label1"
        '
        'lblBaseAtu
        '
        Me.lblBaseAtu.AutoSize = True
        Me.lblBaseAtu.Location = New System.Drawing.Point(347, 150)
        Me.lblBaseAtu.Name = "lblBaseAtu"
        Me.lblBaseAtu.Size = New System.Drawing.Size(39, 13)
        Me.lblBaseAtu.TabIndex = 8
        Me.lblBaseAtu.Text = "Label1"
        '
        'SobreSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 415)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.lblBaseAtu)
        Me.Controls.Add(Me.lblBaseId)
        Me.Controls.Add(Me.lblLic)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.txtObjetivos)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SobreSistema"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre o Sistema"
        Me.TopMost = True
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObjetivos As System.Windows.Forms.TextBox
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblCopy As System.Windows.Forms.Label
    Friend WithEvents lblLic As System.Windows.Forms.Label
    Friend WithEvents lblBaseId As System.Windows.Forms.Label
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblBaseAtu As System.Windows.Forms.Label

End Class
