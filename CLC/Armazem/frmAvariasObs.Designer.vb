<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvariasObs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvariasObs))
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.tabMaster = New System.Windows.Forms.TabControl
        Me.tabAvarias = New System.Windows.Forms.TabPage
        Me.txtAvarias = New System.Windows.Forms.TextBox
        Me.tabObs = New System.Windows.Forms.TabPage
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.chkStatus = New Icraft.IcftFCheckOpc
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.EstoqueF = New CLC.EstoqueF
        Me.tabMaster.SuspendLayout()
        Me.tabAvarias.SuspendLayout()
        Me.tabObs.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPrinc
        '
        Me.grdPrinc.AutoBind = False
        Me.grdPrinc.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdPrinc.BindContainer = Nothing
        Me.grdPrinc.Campos = Nothing
        Me.grdPrinc.CamposExtend = Nothing
        Me.grdPrinc.CamposFixos = ""
        Me.grdPrinc.Chave = Nothing
        Me.grdPrinc.ColunaNomes = ""
        Me.grdPrinc.Defs = Nothing
        Me.grdPrinc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrinc.EsquemaGerador = "IM"
        Me.grdPrinc.EsquemaPrinc = "IM"
        Me.grdPrinc.Filtro = Nothing
        Me.grdPrinc.IncluiCamposSys = False
        Me.grdPrinc.Location = New System.Drawing.Point(0, 128)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(1158, 432)
        Me.grdPrinc.SomenteLeitura = False
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 3
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'tabMaster
        '
        Me.tabMaster.Controls.Add(Me.tabAvarias)
        Me.tabMaster.Controls.Add(Me.tabObs)
        Me.tabMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMaster.Location = New System.Drawing.Point(0, 0)
        Me.tabMaster.Name = "tabMaster"
        Me.tabMaster.SelectedIndex = 0
        Me.tabMaster.Size = New System.Drawing.Size(616, 128)
        Me.tabMaster.TabIndex = 10
        '
        'tabAvarias
        '
        Me.tabAvarias.Controls.Add(Me.txtAvarias)
        Me.tabAvarias.Location = New System.Drawing.Point(4, 22)
        Me.tabAvarias.Name = "tabAvarias"
        Me.tabAvarias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAvarias.Size = New System.Drawing.Size(608, 102)
        Me.tabAvarias.TabIndex = 0
        Me.tabAvarias.Text = "Avarias"
        Me.tabAvarias.UseVisualStyleBackColor = True
        '
        'txtAvarias
        '
        Me.txtAvarias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAvarias.Location = New System.Drawing.Point(3, 3)
        Me.txtAvarias.Multiline = True
        Me.txtAvarias.Name = "txtAvarias"
        Me.txtAvarias.Size = New System.Drawing.Size(602, 96)
        Me.txtAvarias.TabIndex = 1
        '
        'tabObs
        '
        Me.tabObs.Controls.Add(Me.txtObs)
        Me.tabObs.Location = New System.Drawing.Point(4, 22)
        Me.tabObs.Name = "tabObs"
        Me.tabObs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabObs.Size = New System.Drawing.Size(608, 102)
        Me.tabObs.TabIndex = 1
        Me.tabObs.Text = "Observações"
        Me.tabObs.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObs.Location = New System.Drawing.Point(3, 3)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(602, 96)
        Me.txtObs.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 128)
        Me.Panel1.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(542, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(616, 128)
        Me.Panel8.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(616, 128)
        Me.Panel4.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSalvar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 95)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(616, 33)
        Me.Panel6.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Location = New System.Drawing.Point(532, 1)
        Me.btnSalvar.MaximumSize = New System.Drawing.Size(80, 30)
        Me.btnSalvar.MinimumSize = New System.Drawing.Size(80, 30)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(80, 30)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.tabMaster)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(616, 128)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkStatus)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(124, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 128)
        Me.Panel3.TabIndex = 13
        '
        'chkStatus
        '
        Me.chkStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.chkStatus.AlturaPx = 37
        Me.chkStatus.AutoBind = False
        Me.chkStatus.AutoScroll = True
        Me.chkStatus.AutoSize = True
        Me.chkStatus.DeslocaAlturaPx = 20
        Me.chkStatus.DeslocaLarguraPx = 100
        Me.chkStatus.LarguraPx = 334
        Me.chkStatus.Location = New System.Drawing.Point(6, 3)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(405, 86)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(335, 95)
        Me.Panel2.MaximumSize = New System.Drawing.Size(50, 30)
        Me.Panel2.MinimumSize = New System.Drawing.Size(80, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(80, 30)
        Me.Panel2.TabIndex = 12
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 0)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(80, 30)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(124, 128)
        Me.Panel7.TabIndex = 15
        '
        'EstoqueF
        '
        Me.EstoqueF.ArmazemSQL = Nothing
        Me.EstoqueF.BotaoTexto = "Filtro de Estoque"
        Me.EstoqueF.CarregaEtaSQL = Nothing
        Me.EstoqueF.ContainerSQL = Nothing
        Me.EstoqueF.DataEmissaoSQL = Nothing
        Me.EstoqueF.EstabelecimentoSQL = Nothing
        Me.EstoqueF.EstadoSQL = Nothing
        Me.EstoqueF.EtiquetaSQL = Nothing
        Me.EstoqueF.FilaImpSQL = Nothing
        Me.EstoqueF.GrupoSQL = Nothing
        Me.EstoqueF.Location = New System.Drawing.Point(1, 0)
        Me.EstoqueF.MedidaSQL = Nothing
        Me.EstoqueF.Name = "EstoqueF"
        Me.EstoqueF.NCMSQL = Nothing
        Me.EstoqueF.OrdemVendaSQL = Nothing
        Me.EstoqueF.OVItemSQL = Nothing
        Me.EstoqueF.PedidoSQL = Nothing
        Me.EstoqueF.PedItemSQL = Nothing
        Me.EstoqueF.PracaSQL = Nothing
        Me.EstoqueF.ProdutoSQL = Nothing
        Me.EstoqueF.QualidadeSQL = Nothing
        Me.EstoqueF.Size = New System.Drawing.Size(117, 27)
        Me.EstoqueF.StrConn = Nothing
        Me.EstoqueF.TabIndex = 6
        Me.EstoqueF.ViagemSQL = Nothing
        '
        'frmAvariasObs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 560)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAvariasObs"
        Me.Text = "Avarias e Observações"
        Me.tabMaster.ResumeLayout(False)
        Me.tabAvarias.ResumeLayout(False)
        Me.tabAvarias.PerformLayout()
        Me.tabObs.ResumeLayout(False)
        Me.tabObs.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents tabMaster As System.Windows.Forms.TabControl
    Friend WithEvents tabAvarias As System.Windows.Forms.TabPage
    Friend WithEvents tabObs As System.Windows.Forms.TabPage
    Friend WithEvents txtAvarias As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents chkStatus As Icraft.IcftFCheckOpc
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
