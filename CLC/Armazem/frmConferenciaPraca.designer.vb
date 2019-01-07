<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConferenciaPraca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConferenciaPraca))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlStatus = New System.Windows.Forms.Panel
        Me.chkStatus = New Icraft.IcftFCheckOpc
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlStatus)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(838, 80)
        Me.Panel1.TabIndex = 0
        '
        'pnlStatus
        '
        Me.pnlStatus.Controls.Add(Me.chkStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(338, 6)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(334, 37)
        Me.pnlStatus.TabIndex = 6
        '
        'chkStatus
        '
        Me.chkStatus.AlturaPx = 37
        Me.chkStatus.AutoBind = False
        Me.chkStatus.AutoScroll = True
        Me.chkStatus.AutoSize = True
        Me.chkStatus.DeslocaAlturaPx = 20
        Me.chkStatus.DeslocaLarguraPx = 100
        Me.chkStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkStatus.LarguraPx = 334
        Me.chkStatus.Location = New System.Drawing.Point(0, 0)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(334, 37)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(757, 46)
        Me.Panel2.MaximumSize = New System.Drawing.Size(50, 30)
        Me.Panel2.MinimumSize = New System.Drawing.Size(80, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(80, 30)
        Me.Panel2.TabIndex = 5
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
        Me.grdPrinc.Location = New System.Drawing.Point(0, 80)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(838, 290)
        Me.grdPrinc.SomenteLeitura = False
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 4
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
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
        Me.EstoqueF.TabIndex = 3
        Me.EstoqueF.ViagemSQL = Nothing
        '
        'frmConferenciaPraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 370)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConferenciaPraca"
        Me.Text = "Conferência de Praça"
        Me.Panel1.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents chkStatus As Icraft.IcftFCheckOpc
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
End Class
