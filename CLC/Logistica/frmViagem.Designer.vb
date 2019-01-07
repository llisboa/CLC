<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViagem))
        Me.pnlGeral = New System.Windows.Forms.Panel
        Me.pnlOrdemCriada = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPref = New System.Windows.Forms.Label
        Me.ORDPREFIXO = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnGravar = New System.Windows.Forms.Button
        Me.pnlEscalas = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.chkEscalas = New Icraft.IcftFCheckOpc
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.txtEta = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.pnlStatus = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.chkItens = New Icraft.IcftFCheckOpc
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbxStatus = New System.Windows.Forms.ComboBox
        Me.btnConfirma = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl = New System.Windows.Forms.Label
        Me.btnFecha = New System.Windows.Forms.Button
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnAgendar = New System.Windows.Forms.Button
        Me.btnCancParcial = New System.Windows.Forms.Button
        Me.btnCancela = New System.Windows.Forms.Button
        Me.btnCarrega = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.pnlGeral.SuspendLayout()
        Me.pnlOrdemCriada.SuspendLayout()
        Me.pnlEscalas.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlComandos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGeral
        '
        Me.pnlGeral.Controls.Add(Me.pnlOrdemCriada)
        Me.pnlGeral.Controls.Add(Me.pnlEscalas)
        Me.pnlGeral.Controls.Add(Me.pnlStatus)
        Me.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGeral.Name = "pnlGeral"
        Me.pnlGeral.Size = New System.Drawing.Size(501, 289)
        Me.pnlGeral.TabIndex = 0
        '
        'pnlOrdemCriada
        '
        Me.pnlOrdemCriada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrdemCriada.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlOrdemCriada.Controls.Add(Me.Label5)
        Me.pnlOrdemCriada.Controls.Add(Me.lblPref)
        Me.pnlOrdemCriada.Controls.Add(Me.ORDPREFIXO)
        Me.pnlOrdemCriada.Controls.Add(Me.Button3)
        Me.pnlOrdemCriada.Controls.Add(Me.btnGravar)
        Me.pnlOrdemCriada.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrdemCriada.Name = "pnlOrdemCriada"
        Me.pnlOrdemCriada.Size = New System.Drawing.Size(221, 117)
        Me.pnlOrdemCriada.TabIndex = 2
        Me.pnlOrdemCriada.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Viagem a ser Criada"
        '
        'lblPref
        '
        Me.lblPref.AutoSize = True
        Me.lblPref.Location = New System.Drawing.Point(11, 30)
        Me.lblPref.Name = "lblPref"
        Me.lblPref.Size = New System.Drawing.Size(92, 13)
        Me.lblPref.TabIndex = 2
        Me.lblPref.Text = "Prefixo da Viagem"
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
        Me.btnGravar.Text = "Criar Viagem"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'pnlEscalas
        '
        Me.pnlEscalas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEscalas.Controls.Add(Me.Panel5)
        Me.pnlEscalas.Controls.Add(Me.Panel6)
        Me.pnlEscalas.Controls.Add(Me.Panel7)
        Me.pnlEscalas.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEscalas.Location = New System.Drawing.Point(73, 0)
        Me.pnlEscalas.Name = "pnlEscalas"
        Me.pnlEscalas.Size = New System.Drawing.Size(214, 289)
        Me.pnlEscalas.TabIndex = 9
        Me.pnlEscalas.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.chkEscalas)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 76)
        Me.Panel5.TabIndex = 8
        '
        'chkEscalas
        '
        Me.chkEscalas.AlturaPx = 37
        Me.chkEscalas.AutoBind = False
        Me.chkEscalas.AutoSize = True
        Me.chkEscalas.DeslocaAlturaPx = 20
        Me.chkEscalas.DeslocaLarguraPx = 100
        Me.chkEscalas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkEscalas.LarguraPx = 334
        Me.chkEscalas.Location = New System.Drawing.Point(0, 0)
        Me.chkEscalas.Name = "chkEscalas"
        Me.chkEscalas.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkEscalas.Params = CType(resources.GetObject("chkEscalas.Params"), System.Collections.ArrayList)
        Me.chkEscalas.Size = New System.Drawing.Size(210, 76)
        Me.chkEscalas.SQL = """"""
        Me.chkEscalas.SqlText = ""
        Me.chkEscalas.StrConn = Nothing
        Me.chkEscalas.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.txtMotivo)
        Me.Panel6.Controls.Add(Me.txtEta)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 157)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(210, 128)
        Me.Panel6.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Motivo do Reagendamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 107)
        Me.Label2.MaximumSize = New System.Drawing.Size(120, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nova ETA"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(8, 29)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(199, 65)
        Me.txtMotivo.TabIndex = 7
        '
        'txtEta
        '
        Me.txtEta.Location = New System.Drawing.Point(76, 100)
        Me.txtEta.Mask = "00/00/0000"
        Me.txtEta.Name = "txtEta"
        Me.txtEta.Size = New System.Drawing.Size(73, 20)
        Me.txtEta.TabIndex = 6
        Me.txtEta.ValidatingType = GetType(Date)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(210, 81)
        Me.Panel7.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "As escalas seguintes serão reagendadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automaticamente."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.MaximumSize = New System.Drawing.Size(120, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Marque a escala que será reagendada."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(185, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 21)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnlStatus
        '
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStatus.Controls.Add(Me.Panel3)
        Me.pnlStatus.Controls.Add(Me.Panel2)
        Me.pnlStatus.Controls.Add(Me.Panel1)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlStatus.Location = New System.Drawing.Point(287, 0)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(214, 289)
        Me.pnlStatus.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkItens)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 217)
        Me.Panel3.TabIndex = 8
        '
        'chkItens
        '
        Me.chkItens.AlturaPx = 37
        Me.chkItens.AutoBind = False
        Me.chkItens.AutoSize = True
        Me.chkItens.DeslocaAlturaPx = 20
        Me.chkItens.DeslocaLarguraPx = 100
        Me.chkItens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkItens.LarguraPx = 334
        Me.chkItens.Location = New System.Drawing.Point(0, 0)
        Me.chkItens.Name = "chkItens"
        Me.chkItens.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkItens.Params = CType(resources.GetObject("chkItens.Params"), System.Collections.ArrayList)
        Me.chkItens.Size = New System.Drawing.Size(210, 217)
        Me.chkItens.SQL = """"""
        Me.chkItens.SqlText = ""
        Me.chkItens.StrConn = Nothing
        Me.chkItens.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbxStatus)
        Me.Panel2.Controls.Add(Me.btnConfirma)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 251)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 34)
        Me.Panel2.TabIndex = 8
        '
        'cbxStatus
        '
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Location = New System.Drawing.Point(8, 4)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(144, 21)
        Me.cbxStatus.TabIndex = 0
        '
        'btnConfirma
        '
        Me.btnConfirma.Location = New System.Drawing.Point(155, 3)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(53, 21)
        Me.btnConfirma.TabIndex = 5
        Me.btnConfirma.Text = "OK"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Controls.Add(Me.btnFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 34)
        Me.Panel1.TabIndex = 6
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(5, 2)
        Me.lbl.MaximumSize = New System.Drawing.Size(120, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(108, 26)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Escolha os itens que serão alterados."
        '
        'btnFecha
        '
        Me.btnFecha.Location = New System.Drawing.Point(185, 7)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(26, 21)
        Me.btnFecha.TabIndex = 7
        Me.btnFecha.Text = "X"
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlComandos.Controls.Add(Me.Button5)
        Me.pnlComandos.Controls.Add(Me.Button4)
        Me.pnlComandos.Controls.Add(Me.btnAgendar)
        Me.pnlComandos.Controls.Add(Me.btnCancParcial)
        Me.pnlComandos.Controls.Add(Me.btnCancela)
        Me.pnlComandos.Controls.Add(Me.btnCarrega)
        Me.pnlComandos.Controls.Add(Me.btnCancelar)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(501, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlComandos.Size = New System.Drawing.Size(83, 289)
        Me.pnlComandos.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.Location = New System.Drawing.Point(5, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 38)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Confirmar Peso Real"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(5, 195)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Peso Real"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAgendar
        '
        Me.btnAgendar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgendar.Location = New System.Drawing.Point(5, 157)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(69, 38)
        Me.btnAgendar.TabIndex = 4
        Me.btnAgendar.Text = "Agendar Escalas"
        Me.btnAgendar.UseVisualStyleBackColor = True
        '
        'btnCancParcial
        '
        Me.btnCancParcial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancParcial.Location = New System.Drawing.Point(5, 119)
        Me.btnCancParcial.Name = "btnCancParcial"
        Me.btnCancParcial.Size = New System.Drawing.Size(69, 38)
        Me.btnCancParcial.TabIndex = 3
        Me.btnCancParcial.Text = "Alterar Status"
        Me.btnCancParcial.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancela.Location = New System.Drawing.Point(5, 81)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(69, 38)
        Me.btnCancela.TabIndex = 2
        Me.btnCancela.Text = "Cancelar Viagem"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnCarrega
        '
        Me.btnCarrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCarrega.Location = New System.Drawing.Point(5, 43)
        Me.btnCarrega.Name = "btnCarrega"
        Me.btnCarrega.Size = New System.Drawing.Size(69, 38)
        Me.btnCarrega.TabIndex = 1
        Me.btnCarrega.Text = "Carregar Viagem"
        Me.btnCarrega.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancelar.Location = New System.Drawing.Point(5, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 38)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Imprimir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmViagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 289)
        Me.Controls.Add(Me.pnlGeral)
        Me.Controls.Add(Me.pnlComandos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViagem"
        Me.Text = "Viagem"
        Me.pnlGeral.ResumeLayout(False)
        Me.pnlOrdemCriada.ResumeLayout(False)
        Me.pnlOrdemCriada.PerformLayout()
        Me.pnlEscalas.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlComandos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlGeral As System.Windows.Forms.Panel
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnCarrega As System.Windows.Forms.Button
    Friend WithEvents btnCancParcial As System.Windows.Forms.Button
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents chkItens As icraft.IcftFCheckOpc
    Friend WithEvents btnFecha As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAgendar As System.Windows.Forms.Button
    Friend WithEvents pnlEscalas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chkEscalas As icraft.IcftFCheckOpc
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtEta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlOrdemCriada As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPref As System.Windows.Forms.Label
    Friend WithEvents ORDPREFIXO As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
