<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConferir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConferir))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.chkStatus = New icraft.IcftFCheckOpc
        Me.grdEtiq = New Icraft.IcftFGrid2
        Me.pnlCima = New System.Windows.Forms.Panel
        Me.grpDimensoes = New System.Windows.Forms.GroupBox
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAtualizaPeso = New System.Windows.Forms.Button
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlCima.SuspendLayout()
        Me.grpDimensoes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chkStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 80)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(740, 50)
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
        Me.chkStatus.Location = New System.Drawing.Point(338, 6)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(334, 37)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 3
        '
        'grdEtiq
        '
        Me.grdEtiq.AutoBind = False
        Me.grdEtiq.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdEtiq.BindContainer = Nothing
        Me.grdEtiq.Campos = Nothing
        Me.grdEtiq.CamposExtend = Nothing
        Me.grdEtiq.CamposFixos = ""
        Me.grdEtiq.Chave = Nothing
        Me.grdEtiq.ColunaNomes = ""
        Me.grdEtiq.Defs = Nothing
        Me.grdEtiq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEtiq.EsquemaGerador = "IM"
        Me.grdEtiq.EsquemaPrinc = "IM"
        Me.grdEtiq.Filtro = Nothing
        Me.grdEtiq.IncluiCamposSys = False
        Me.grdEtiq.Location = New System.Drawing.Point(3, 16)
        Me.grdEtiq.MostraNumReg = False
        Me.grdEtiq.Name = "grdEtiq"
        Me.grdEtiq.Ocultar = Nothing
        Me.grdEtiq.Params = CType(resources.GetObject("grdEtiq.Params"), System.Collections.ArrayList)
        Me.grdEtiq.Sistema = "IM"
        Me.grdEtiq.Size = New System.Drawing.Size(683, 188)
        Me.grdEtiq.SQL = ""
        Me.grdEtiq.StrConn = Nothing
        Me.grdEtiq.Tabela = ""
        Me.grdEtiq.TabIndex = 6
        Me.grdEtiq.Tag = ""
        Me.grdEtiq.Totaliza = ""
        Me.grdEtiq.Usuario = ""
        Me.grdEtiq.ValorPadrao = CType(resources.GetObject("grdEtiq.ValorPadrao"), System.Collections.ArrayList)
        '
        'pnlCima
        '
        Me.pnlCima.Controls.Add(Me.grpDimensoes)
        Me.pnlCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCima.Location = New System.Drawing.Point(0, 80)
        Me.pnlCima.Name = "pnlCima"
        Me.pnlCima.Size = New System.Drawing.Size(820, 195)
        Me.pnlCima.TabIndex = 7
        '
        'grpDimensoes
        '
        Me.grpDimensoes.Controls.Add(Me.grdPrinc)
        Me.grpDimensoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDimensoes.Location = New System.Drawing.Point(0, 0)
        Me.grpDimensoes.Name = "grpDimensoes"
        Me.grpDimensoes.Size = New System.Drawing.Size(820, 195)
        Me.grpDimensoes.TabIndex = 5
        Me.grpDimensoes.TabStop = False
        Me.grpDimensoes.Text = "Dimensões"
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
        Me.grdPrinc.Location = New System.Drawing.Point(3, 16)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(814, 176)
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 4
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdEtiq)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(689, 207)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etiquetas"
        '
        'btnAtualizaPeso
        '
        Me.btnAtualizaPeso.Location = New System.Drawing.Point(6, 6)
        Me.btnAtualizaPeso.Name = "btnAtualizaPeso"
        Me.btnAtualizaPeso.Size = New System.Drawing.Size(119, 22)
        Me.btnAtualizaPeso.TabIndex = 8
        Me.btnAtualizaPeso.Text = "Atualizar Peso"
        Me.btnAtualizaPeso.UseVisualStyleBackColor = True
        '
        'btnVisualiza
        '
        Me.btnVisualiza.Location = New System.Drawing.Point(6, 34)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(119, 22)
        Me.btnVisualiza.TabIndex = 7
        Me.btnVisualiza.Text = "Visualizar Etiqueta"
        Me.btnVisualiza.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 285)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(820, 207)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnVisualiza)
        Me.Panel4.Controls.Add(Me.btnAtualizaPeso)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(689, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(131, 207)
        Me.Panel4.TabIndex = 9
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 275)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(820, 10)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
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
        'frmConferir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 492)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlCima)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConferir"
        Me.Text = "Etiquetas por Especificação e Status "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlCima.ResumeLayout(False)
        Me.grpDimensoes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents grdEtiq As Icraft.IcftFGrid2
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents btnAtualizaPeso As System.Windows.Forms.Button
    Friend WithEvents chkStatus As icraft.IcftFCheckOpc
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCima As System.Windows.Forms.Panel
    Friend WithEvents grpDimensoes As System.Windows.Forms.GroupBox
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
