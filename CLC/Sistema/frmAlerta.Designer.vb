<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlerta
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
        Me.lblEtiq = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pg = New System.Windows.Forms.ProgressBar
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEtiq
        '
        Me.lblEtiq.BackColor = System.Drawing.Color.Transparent
        Me.lblEtiq.Font = New System.Drawing.Font("Dax-Regular", 12.0!)
        Me.lblEtiq.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEtiq.Location = New System.Drawing.Point(44, 99)
        Me.lblEtiq.Margin = New System.Windows.Forms.Padding(10)
        Me.lblEtiq.Name = "lblEtiq"
        Me.lblEtiq.Size = New System.Drawing.Size(316, 48)
        Me.lblEtiq.TabIndex = 0
        Me.lblEtiq.Text = "..."
        Me.lblEtiq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Controls.Add(Me.lblEtiq)
        Me.PictureBox1.Controls.Add(Me.lblTitulo)
        Me.PictureBox1.Image = Global.CLC.My.Resources.Resources.CLCAlertaG1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(402, 264)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Dax-Regular", 14.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitulo.Location = New System.Drawing.Point(155, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(230, 64)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "..."
        '
        'pg
        '
        Me.pg.BackColor = System.Drawing.Color.White
        Me.pg.Location = New System.Drawing.Point(17, 235)
        Me.pg.Name = "pg"
        Me.pg.Size = New System.Drawing.Size(368, 10)
        Me.pg.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pg.TabIndex = 0
        '
        'frmAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(401, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.pg)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAlerta"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEtiq As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pg As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
