<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdemVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdemVenda))
        Me.pnlGeral = New System.Windows.Forms.Panel
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCria = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.ctl = New System.Windows.Forms.Label
        Me.pnlOrdemCriada = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblPref = New System.Windows.Forms.Label
        Me.ORDPREFIXO = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnGravar = New System.Windows.Forms.Button
        Me.pnlComandos.SuspendLayout()
        Me.pnlOrdemCriada.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGeral
        '
        Me.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGeral.Name = "pnlGeral"
        Me.pnlGeral.Size = New System.Drawing.Size(413, 289)
        Me.pnlGeral.TabIndex = 0
        '
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlComandos.Controls.Add(Me.Button1)
        Me.pnlComandos.Controls.Add(Me.btnCria)
        Me.pnlComandos.Controls.Add(Me.btnImprimir)
        Me.pnlComandos.Controls.Add(Me.btnCancelar)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(413, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlComandos.Size = New System.Drawing.Size(79, 289)
        Me.pnlComandos.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(5, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Deletar Ordem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCria
        '
        Me.btnCria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCria.Location = New System.Drawing.Point(5, 81)
        Me.btnCria.Name = "btnCria"
        Me.btnCria.Size = New System.Drawing.Size(65, 38)
        Me.btnCria.TabIndex = 2
        Me.btnCria.Text = "Criar Ordem"
        Me.btnCria.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimir.Location = New System.Drawing.Point(5, 43)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(65, 38)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Ordem"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancelar.Location = New System.Drawing.Point(5, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 38)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar Ordem"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ctl
        '
        Me.ctl.Location = New System.Drawing.Point(0, 0)
        Me.ctl.Name = "ctl"
        Me.ctl.Size = New System.Drawing.Size(100, 23)
        Me.ctl.TabIndex = 0
        '
        'pnlOrdemCriada
        '
        Me.pnlOrdemCriada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrdemCriada.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlOrdemCriada.Controls.Add(Me.lblTitulo)
        Me.pnlOrdemCriada.Controls.Add(Me.lblPref)
        Me.pnlOrdemCriada.Controls.Add(Me.ORDPREFIXO)
        Me.pnlOrdemCriada.Controls.Add(Me.Button3)
        Me.pnlOrdemCriada.Controls.Add(Me.btnGravar)
        Me.pnlOrdemCriada.Location = New System.Drawing.Point(193, 83)
        Me.pnlOrdemCriada.Name = "pnlOrdemCriada"
        Me.pnlOrdemCriada.Size = New System.Drawing.Size(221, 117)
        Me.pnlOrdemCriada.TabIndex = 3
        Me.pnlOrdemCriada.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(221, 13)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Ordem a ser Criada"
        '
        'lblPref
        '
        Me.lblPref.AutoSize = True
        Me.lblPref.Location = New System.Drawing.Point(11, 30)
        Me.lblPref.Name = "lblPref"
        Me.lblPref.Size = New System.Drawing.Size(88, 13)
        Me.lblPref.TabIndex = 2
        Me.lblPref.Text = "Prefixo da Ordem"
        '
        'ORDPREFIXO
        '
        Me.ORDPREFIXO.Location = New System.Drawing.Point(105, 27)
        Me.ORDPREFIXO.MaxLength = 13
        Me.ORDPREFIXO.Name = "ORDPREFIXO"
        Me.ORDPREFIXO.Size = New System.Drawing.Size(92, 20)
        Me.ORDPREFIXO.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(115, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 22)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnGravar
        '
        Me.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGravar.Location = New System.Drawing.Point(30, 85)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(82, 22)
        Me.btnGravar.TabIndex = 0
        Me.btnGravar.Text = "Criar"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'frmOrdemVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 289)
        Me.Controls.Add(Me.pnlOrdemCriada)
        Me.Controls.Add(Me.pnlGeral)
        Me.Controls.Add(Me.pnlComandos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdemVenda"
        Me.Text = "Ordem de Venda"
        Me.pnlComandos.ResumeLayout(False)
        Me.pnlOrdemCriada.ResumeLayout(False)
        Me.pnlOrdemCriada.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlGeral As System.Windows.Forms.Panel
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCria As System.Windows.Forms.Button
    Friend WithEvents pnlOrdemCriada As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblPref As System.Windows.Forms.Label
    Friend WithEvents ORDPREFIXO As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ctl As System.Windows.Forms.Label
End Class
