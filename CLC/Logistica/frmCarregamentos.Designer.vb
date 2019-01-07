<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarregamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarregamentos))
        Me.pnlRight = New System.Windows.Forms.Panel
        Me.btnImprimirInstrucao = New System.Windows.Forms.Button
        Me.btnViagem = New System.Windows.Forms.Button
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.chkOpc = New Icraft.IcftFCheckOpc
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CTLATE = New System.Windows.Forms.MaskedTextBox
        Me.txtBusca = New System.Windows.Forms.TextBox
        Me.lblDe = New System.Windows.Forms.Label
        Me.CTLDE = New System.Windows.Forms.MaskedTextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.lblReg = New System.Windows.Forms.Label
        Me.pnlOrdens = New System.Windows.Forms.Panel
        Me.grdOrdens = New Icraft.IcftFGrid2
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grdViagens = New Icraft.IcftFGrid2
        Me.btnImprimirResumo = New System.Windows.Forms.Button
        Me.pnlRight.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlOrdens.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.btnImprimirResumo)
        Me.pnlRight.Controls.Add(Me.btnImprimirInstrucao)
        Me.pnlRight.Controls.Add(Me.btnViagem)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1025, 103)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(74, 508)
        Me.pnlRight.TabIndex = 0
        '
        'btnImprimirInstrucao
        '
        Me.btnImprimirInstrucao.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimirInstrucao.Location = New System.Drawing.Point(0, 38)
        Me.btnImprimirInstrucao.Margin = New System.Windows.Forms.Padding(20)
        Me.btnImprimirInstrucao.Name = "btnImprimirInstrucao"
        Me.btnImprimirInstrucao.Size = New System.Drawing.Size(74, 38)
        Me.btnImprimirInstrucao.TabIndex = 3
        Me.btnImprimirInstrucao.Text = "Visualizar Instrução"
        Me.btnImprimirInstrucao.UseVisualStyleBackColor = True
        '
        'btnViagem
        '
        Me.btnViagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViagem.Location = New System.Drawing.Point(0, 0)
        Me.btnViagem.Margin = New System.Windows.Forms.Padding(20)
        Me.btnViagem.Name = "btnViagem"
        Me.btnViagem.Size = New System.Drawing.Size(74, 38)
        Me.btnViagem.TabIndex = 2
        Me.btnViagem.Text = "Ir para Viagem"
        Me.btnViagem.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.SplitContainer1)
        Me.pnlTop.Controls.Add(Me.lblReg)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1099, 103)
        Me.pnlTop.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkOpc)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CTLATE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBusca)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDe)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CTLDE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1092, 93)
        Me.SplitContainer1.SplitterDistance = 703
        Me.SplitContainer1.TabIndex = 18
        '
        'chkOpc
        '
        Me.chkOpc.AlturaPx = 36
        Me.chkOpc.AutoBind = False
        Me.chkOpc.AutoSize = True
        Me.chkOpc.DeslocaAlturaPx = 20
        Me.chkOpc.DeslocaLarguraPx = 100
        Me.chkOpc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkOpc.LarguraPx = 198
        Me.chkOpc.Location = New System.Drawing.Point(0, 0)
        Me.chkOpc.Name = "chkOpc"
        Me.chkOpc.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkOpc.Params = CType(resources.GetObject("chkOpc.Params"), System.Collections.ArrayList)
        Me.chkOpc.Size = New System.Drawing.Size(703, 93)
        Me.chkOpc.SQL = ""
        Me.chkOpc.SqlText = ""
        Me.chkOpc.StrConn = Nothing
        Me.chkOpc.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(313, 5)
        Me.Panel3.MaximumSize = New System.Drawing.Size(60, 30)
        Me.Panel3.MinimumSize = New System.Drawing.Size(60, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(60, 30)
        Me.Panel3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Busca Rápida"
        '
        'CTLATE
        '
        Me.CTLATE.Location = New System.Drawing.Point(208, 56)
        Me.CTLATE.Name = "CTLATE"
        Me.CTLATE.Size = New System.Drawing.Size(82, 20)
        Me.CTLATE.TabIndex = 15
        Me.CTLATE.Tag = "tipo:DATE"
        Me.CTLATE.ValidatingType = GetType(Date)
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(102, 14)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(188, 20)
        Me.txtBusca.TabIndex = 3
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(18, 59)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(45, 13)
        Me.lblDe.TabIndex = 12
        Me.lblDe.Text = "Período"
        '
        'CTLDE
        '
        Me.CTLDE.Location = New System.Drawing.Point(102, 56)
        Me.CTLDE.Name = "CTLDE"
        Me.CTLDE.Size = New System.Drawing.Size(82, 20)
        Me.CTLDE.TabIndex = 13
        Me.CTLDE.Tag = "tipo:DATE"
        Me.CTLDE.ValidatingType = GetType(Date)
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(313, 47)
        Me.Panel2.MaximumSize = New System.Drawing.Size(60, 30)
        Me.Panel2.MinimumSize = New System.Drawing.Size(60, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(60, 30)
        Me.Panel2.TabIndex = 16
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 0)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(60, 30)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(12, 9)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(0, 13)
        Me.lblReg.TabIndex = 15
        '
        'pnlOrdens
        '
        Me.pnlOrdens.Controls.Add(Me.grdOrdens)
        Me.pnlOrdens.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOrdens.Location = New System.Drawing.Point(0, 103)
        Me.pnlOrdens.Name = "pnlOrdens"
        Me.pnlOrdens.Size = New System.Drawing.Size(1025, 145)
        Me.pnlOrdens.TabIndex = 1
        '
        'grdOrdens
        '
        Me.grdOrdens.AutoBind = False
        Me.grdOrdens.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdOrdens.BindContainer = Nothing
        Me.grdOrdens.Campos = Nothing
        Me.grdOrdens.CamposExtend = Nothing
        Me.grdOrdens.CamposFixos = ""
        Me.grdOrdens.Chave = Nothing
        Me.grdOrdens.ColunaNomes = ""
        Me.grdOrdens.Defs = Nothing
        Me.grdOrdens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOrdens.EsquemaGerador = "IM"
        Me.grdOrdens.EsquemaPrinc = "IM"
        Me.grdOrdens.Filtro = Nothing
        Me.grdOrdens.IncluiCamposSys = False
        Me.grdOrdens.Info = "Informações..."
        Me.grdOrdens.Location = New System.Drawing.Point(0, 0)
        Me.grdOrdens.MostraNumReg = False
        Me.grdOrdens.Name = "grdOrdens"
        Me.grdOrdens.Ocultar = Nothing
        Me.grdOrdens.Params = CType(resources.GetObject("grdOrdens.Params"), System.Collections.ArrayList)
        Me.grdOrdens.Sistema = "IM"
        Me.grdOrdens.Size = New System.Drawing.Size(1025, 145)
        Me.grdOrdens.SomenteLeitura = False
        Me.grdOrdens.SQL = ""
        Me.grdOrdens.StrConn = Nothing
        Me.grdOrdens.Tabela = ""
        Me.grdOrdens.TabIndex = 5
        Me.grdOrdens.Tag = ""
        Me.grdOrdens.Totaliza = ""
        Me.grdOrdens.Usuario = ""
        Me.grdOrdens.ValorPadrao = CType(resources.GetObject("grdOrdens.ValorPadrao"), System.Collections.ArrayList)
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 248)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1025, 10)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdViagens)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 353)
        Me.Panel1.TabIndex = 3
        '
        'grdViagens
        '
        Me.grdViagens.AutoBind = False
        Me.grdViagens.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdViagens.BindContainer = Nothing
        Me.grdViagens.Campos = Nothing
        Me.grdViagens.CamposExtend = Nothing
        Me.grdViagens.CamposFixos = ""
        Me.grdViagens.Chave = Nothing
        Me.grdViagens.ColunaNomes = ""
        Me.grdViagens.Defs = Nothing
        Me.grdViagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdViagens.EsquemaGerador = "IM"
        Me.grdViagens.EsquemaPrinc = "IM"
        Me.grdViagens.Filtro = Nothing
        Me.grdViagens.IncluiCamposSys = False
        Me.grdViagens.Info = "Informações..."
        Me.grdViagens.Location = New System.Drawing.Point(0, 0)
        Me.grdViagens.MostraNumReg = False
        Me.grdViagens.Name = "grdViagens"
        Me.grdViagens.Ocultar = Nothing
        Me.grdViagens.Params = CType(resources.GetObject("grdViagens.Params"), System.Collections.ArrayList)
        Me.grdViagens.Sistema = "IM"
        Me.grdViagens.Size = New System.Drawing.Size(1025, 353)
        Me.grdViagens.SomenteLeitura = False
        Me.grdViagens.SQL = ""
        Me.grdViagens.StrConn = Nothing
        Me.grdViagens.Tabela = ""
        Me.grdViagens.TabIndex = 6
        Me.grdViagens.Tag = ""
        Me.grdViagens.Totaliza = ""
        Me.grdViagens.Usuario = ""
        Me.grdViagens.ValorPadrao = CType(resources.GetObject("grdViagens.ValorPadrao"), System.Collections.ArrayList)
        '
        'btnImprimirResumo
        '
        Me.btnImprimirResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimirResumo.Location = New System.Drawing.Point(0, 76)
        Me.btnImprimirResumo.Margin = New System.Windows.Forms.Padding(20)
        Me.btnImprimirResumo.Name = "btnImprimirResumo"
        Me.btnImprimirResumo.Size = New System.Drawing.Size(74, 38)
        Me.btnImprimirResumo.TabIndex = 4
        Me.btnImprimirResumo.Text = "Visualizar Instrução"
        Me.btnImprimirResumo.UseVisualStyleBackColor = True
        '
        'frmCarregamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlOrdens)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmCarregamentos"
        Me.Text = "frmCarregamentos"
        Me.pnlRight.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlOrdens.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlOrdens As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grdOrdens As Icraft.IcftFGrid2
    Friend WithEvents grdViagens As Icraft.IcftFGrid2
    Friend WithEvents btnViagem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimirInstrucao As System.Windows.Forms.Button
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkOpc As Icraft.IcftFCheckOpc
    Friend WithEvents CTLATE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents CTLDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimirResumo As System.Windows.Forms.Button
End Class
