<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueF
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueF))
        Me.btnDefs = New System.Windows.Forms.Button
        Me.mnuEstoque = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grGrupo = New System.Windows.Forms.ToolStripMenuItem
        Me.grEstado = New System.Windows.Forms.ToolStripMenuItem
        Me.grEstabelecim = New System.Windows.Forms.ToolStripMenuItem
        Me.grArmazem = New System.Windows.Forms.ToolStripMenuItem
        Me.grPraca = New System.Windows.Forms.ToolStripMenuItem
        Me.grProduto = New System.Windows.Forms.ToolStripMenuItem
        Me.grNCM = New System.Windows.Forms.ToolStripMenuItem
        Me.grMedida = New System.Windows.Forms.ToolStripMenuItem
        Me.grQualidade = New System.Windows.Forms.ToolStripMenuItem
        Me.grPedido = New System.Windows.Forms.ToolStripMenuItem
        Me.grFilaImp = New System.Windows.Forms.ToolStripMenuItem
        Me.grOrdemVenda = New System.Windows.Forms.ToolStripMenuItem
        Me.grViagem = New System.Windows.Forms.ToolStripMenuItem
        Me.grDataEmissao = New System.Windows.Forms.ToolStripMenuItem
        Me.grEtiqueta = New System.Windows.Forms.ToolStripMenuItem
        Me.grContainer = New System.Windows.Forms.ToolStripMenuItem
        Me.grPedItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grOVItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grCarregaEta = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.LimparToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.opcPraca = New Icraft.IcftFOpc
        Me.opcProd = New Icraft.IcftFOpc
        Me.opcEstab = New Icraft.IcftFOpc
        Me.opcNCM = New Icraft.IcftFOpc
        Me.opcGrupo = New Icraft.IcftFOpc
        Me.opcMedida = New Icraft.IcftFOpc
        Me.opcQualidade = New Icraft.IcftFOpc
        Me.opcArm = New Icraft.IcftFOpc
        Me.opcEstado = New Icraft.IcftFOpc
        Me.opcPedido = New Icraft.IcftFOpc
        Me.opcFilaImp = New Icraft.IcftFOpc
        Me.opcOrdemVenda = New Icraft.IcftFOpc
        Me.OpcViagemPed = New Icraft.IcftFOpc
        Me.opcDataEmissao = New Icraft.IcftFOpc
        Me.opcEtiqueta = New Icraft.IcftFOpc
        Me.opcContainer = New Icraft.IcftFOpc
        Me.opcOVItem = New Icraft.IcftFOpc
        Me.opcPedItem = New Icraft.IcftFOpc
        Me.opcCarregaEta = New Icraft.IcftFOpc
        Me.mnuEstoque.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDefs
        '
        Me.btnDefs.Location = New System.Drawing.Point(3, 3)
        Me.btnDefs.Name = "btnDefs"
        Me.btnDefs.Size = New System.Drawing.Size(114, 24)
        Me.btnDefs.TabIndex = 0
        Me.btnDefs.Text = "Filtro de Estoque"
        Me.btnDefs.UseVisualStyleBackColor = True
        '
        'mnuEstoque
        '
        Me.mnuEstoque.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grGrupo, Me.grEstado, Me.grEstabelecim, Me.grArmazem, Me.grPraca, Me.grProduto, Me.grNCM, Me.grMedida, Me.grQualidade, Me.grPedido, Me.grFilaImp, Me.grOrdemVenda, Me.grViagem, Me.grDataEmissao, Me.grEtiqueta, Me.grContainer, Me.grPedItem, Me.grOVItem, Me.grCarregaEta, Me.ToolStripMenuItem1, Me.LimparToolStripMenuItem})
        Me.mnuEstoque.Name = "mnuEstoque"
        Me.mnuEstoque.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuEstoque.Size = New System.Drawing.Size(218, 450)
        '
        'grGrupo
        '
        Me.grGrupo.Name = "grGrupo"
        Me.grGrupo.Size = New System.Drawing.Size(217, 22)
        Me.grGrupo.Text = "Grupo"
        '
        'grEstado
        '
        Me.grEstado.Name = "grEstado"
        Me.grEstado.Size = New System.Drawing.Size(217, 22)
        Me.grEstado.Text = "Estado"
        '
        'grEstabelecim
        '
        Me.grEstabelecim.Name = "grEstabelecim"
        Me.grEstabelecim.Size = New System.Drawing.Size(217, 22)
        Me.grEstabelecim.Text = "Estabelecimento"
        '
        'grArmazem
        '
        Me.grArmazem.Name = "grArmazem"
        Me.grArmazem.Size = New System.Drawing.Size(217, 22)
        Me.grArmazem.Text = "Armazém"
        '
        'grPraca
        '
        Me.grPraca.Name = "grPraca"
        Me.grPraca.Size = New System.Drawing.Size(217, 22)
        Me.grPraca.Text = "Praça"
        '
        'grProduto
        '
        Me.grProduto.Name = "grProduto"
        Me.grProduto.Size = New System.Drawing.Size(217, 22)
        Me.grProduto.Text = "Produto"
        '
        'grNCM
        '
        Me.grNCM.Name = "grNCM"
        Me.grNCM.Size = New System.Drawing.Size(217, 22)
        Me.grNCM.Text = "NCM"
        '
        'grMedida
        '
        Me.grMedida.Name = "grMedida"
        Me.grMedida.Size = New System.Drawing.Size(217, 22)
        Me.grMedida.Text = "Medida"
        '
        'grQualidade
        '
        Me.grQualidade.Name = "grQualidade"
        Me.grQualidade.Size = New System.Drawing.Size(217, 22)
        Me.grQualidade.Text = "Qualidade"
        '
        'grPedido
        '
        Me.grPedido.Name = "grPedido"
        Me.grPedido.Size = New System.Drawing.Size(217, 22)
        Me.grPedido.Text = "Pedido"
        '
        'grFilaImp
        '
        Me.grFilaImp.Name = "grFilaImp"
        Me.grFilaImp.Size = New System.Drawing.Size(217, 22)
        Me.grFilaImp.Text = "Fila de Impressão"
        '
        'grOrdemVenda
        '
        Me.grOrdemVenda.Name = "grOrdemVenda"
        Me.grOrdemVenda.Size = New System.Drawing.Size(217, 22)
        Me.grOrdemVenda.Text = "Ordem de Venda"
        '
        'grViagem
        '
        Me.grViagem.Name = "grViagem"
        Me.grViagem.Size = New System.Drawing.Size(217, 22)
        Me.grViagem.Text = "Viagem"
        '
        'grDataEmissao
        '
        Me.grDataEmissao.Name = "grDataEmissao"
        Me.grDataEmissao.Size = New System.Drawing.Size(217, 22)
        Me.grDataEmissao.Text = "Data de Emissão"
        '
        'grEtiqueta
        '
        Me.grEtiqueta.Name = "grEtiqueta"
        Me.grEtiqueta.Size = New System.Drawing.Size(217, 22)
        Me.grEtiqueta.Text = "Etiqueta"
        '
        'grContainer
        '
        Me.grContainer.Name = "grContainer"
        Me.grContainer.Size = New System.Drawing.Size(217, 22)
        Me.grContainer.Text = "Container"
        '
        'grPedItem
        '
        Me.grPedItem.Name = "grPedItem"
        Me.grPedItem.Size = New System.Drawing.Size(217, 22)
        Me.grPedItem.Text = "Itens do Pedido"
        '
        'grOVItem
        '
        Me.grOVItem.Name = "grOVItem"
        Me.grOVItem.Size = New System.Drawing.Size(217, 22)
        Me.grOVItem.Text = "Itens da Ordem de Venda"
        '
        'grCarregaEta
        '
        Me.grCarregaEta.Name = "grCarregaEta"
        Me.grCarregaEta.Size = New System.Drawing.Size(217, 22)
        Me.grCarregaEta.Text = "Previsões para Carregamento"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(214, 6)
        '
        'LimparToolStripMenuItem
        '
        Me.LimparToolStripMenuItem.Name = "LimparToolStripMenuItem"
        Me.LimparToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LimparToolStripMenuItem.Text = "Limpar"
        '
        'opcPraca
        '
        Me.opcPraca.Atualizar = Nothing
        Me.opcPraca.AutoBind = False
        Me.opcPraca.ListaSQL = "SELECT PRACA FROM IM.ARMAZEM_PRACA GROUP BY PRACA"
        Me.opcPraca.Location = New System.Drawing.Point(3, 666)
        Me.opcPraca.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcPraca.MostraConfirma = True
        Me.opcPraca.Name = "opcPraca"
        Me.opcPraca.Params = CType(resources.GetObject("opcPraca.Params"), System.Collections.ArrayList)
        Me.opcPraca.Size = New System.Drawing.Size(312, 314)
        Me.opcPraca.StrConn = Nothing
        Me.opcPraca.TabIndex = 5
        Me.opcPraca.TextoSQL = ""
        Me.opcPraca.Titulo = "Escolha Praças"
        Me.opcPraca.Visible = False
        '
        'opcProd
        '
        Me.opcProd.Atualizar = Nothing
        Me.opcProd.AutoBind = False
        Me.opcProd.ListaSQL = "SELECT COD FROM IM.PRODUTO"
        Me.opcProd.Location = New System.Drawing.Point(321, 666)
        Me.opcProd.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcProd.MostraConfirma = True
        Me.opcProd.Name = "opcProd"
        Me.opcProd.Params = CType(resources.GetObject("opcProd.Params"), System.Collections.ArrayList)
        Me.opcProd.Size = New System.Drawing.Size(312, 314)
        Me.opcProd.StrConn = Nothing
        Me.opcProd.TabIndex = 4
        Me.opcProd.TextoSQL = ""
        Me.opcProd.Titulo = "Escolha Produtos"
        Me.opcProd.Visible = False
        '
        'opcEstab
        '
        Me.opcEstab.Atualizar = Nothing
        Me.opcEstab.AutoBind = False
        Me.opcEstab.ListaSQL = "SELECT COD FROM IM.CIA WHERE EXISTS(SELECT * FROM IM.CIA_RAMO_ATIVIDADE WHERE RAM" & _
            "O_ATIVIDADE_COD = 'ARMAZÉM' AND CIA_COD = COD)"
        Me.opcEstab.Location = New System.Drawing.Point(3, 346)
        Me.opcEstab.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcEstab.MostraConfirma = True
        Me.opcEstab.Name = "opcEstab"
        Me.opcEstab.Params = CType(resources.GetObject("opcEstab.Params"), System.Collections.ArrayList)
        Me.opcEstab.Size = New System.Drawing.Size(312, 314)
        Me.opcEstab.StrConn = Nothing
        Me.opcEstab.TabIndex = 3
        Me.opcEstab.TextoSQL = ""
        Me.opcEstab.Titulo = "Escolha Estabelecimentos"
        Me.opcEstab.Visible = False
        '
        'opcNCM
        '
        Me.opcNCM.Atualizar = Nothing
        Me.opcNCM.AutoBind = False
        Me.opcNCM.ListaSQL = "SELECT NCM FROM IM.PROD_ESPEC GROUP BY NCM"
        Me.opcNCM.Location = New System.Drawing.Point(3, 977)
        Me.opcNCM.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcNCM.MostraConfirma = True
        Me.opcNCM.Name = "opcNCM"
        Me.opcNCM.Params = CType(resources.GetObject("opcNCM.Params"), System.Collections.ArrayList)
        Me.opcNCM.Size = New System.Drawing.Size(312, 314)
        Me.opcNCM.StrConn = Nothing
        Me.opcNCM.TabIndex = 7
        Me.opcNCM.TextoSQL = ""
        Me.opcNCM.Titulo = "Escolha NCM"
        Me.opcNCM.Visible = False
        '
        'opcGrupo
        '
        Me.opcGrupo.Atualizar = Nothing
        Me.opcGrupo.AutoBind = False
        Me.opcGrupo.ListaSQL = "SELECT COD FROM IM.ESTOQUE_ORGANIZA"
        Me.opcGrupo.Location = New System.Drawing.Point(3, 35)
        Me.opcGrupo.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcGrupo.MostraConfirma = True
        Me.opcGrupo.Name = "opcGrupo"
        Me.opcGrupo.Params = CType(resources.GetObject("opcGrupo.Params"), System.Collections.ArrayList)
        Me.opcGrupo.Size = New System.Drawing.Size(312, 314)
        Me.opcGrupo.StrConn = Nothing
        Me.opcGrupo.TabIndex = 1
        Me.opcGrupo.TextoSQL = ""
        Me.opcGrupo.Titulo = "Escolha Grupos"
        Me.opcGrupo.Visible = False
        '
        'opcMedida
        '
        Me.opcMedida.Atualizar = Nothing
        Me.opcMedida.AutoBind = False
        Me.opcMedida.ListaSQL = resources.GetString("opcMedida.ListaSQL")
        Me.opcMedida.Location = New System.Drawing.Point(321, 977)
        Me.opcMedida.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcMedida.MostraConfirma = True
        Me.opcMedida.Name = "opcMedida"
        Me.opcMedida.Params = CType(resources.GetObject("opcMedida.Params"), System.Collections.ArrayList)
        Me.opcMedida.Size = New System.Drawing.Size(312, 314)
        Me.opcMedida.StrConn = Nothing
        Me.opcMedida.TabIndex = 7
        Me.opcMedida.TextoSQL = ""
        Me.opcMedida.Titulo = "Escolha Medidas"
        Me.opcMedida.Visible = False
        '
        'opcQualidade
        '
        Me.opcQualidade.Atualizar = Nothing
        Me.opcQualidade.AutoBind = False
        Me.opcQualidade.ListaSQL = "SELECT QUALIDADE FROM IM.PROD_ESPEC GROUP BY QUALIDADE"
        Me.opcQualidade.Location = New System.Drawing.Point(3, 1297)
        Me.opcQualidade.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcQualidade.MostraConfirma = True
        Me.opcQualidade.Name = "opcQualidade"
        Me.opcQualidade.Params = CType(resources.GetObject("opcQualidade.Params"), System.Collections.ArrayList)
        Me.opcQualidade.Size = New System.Drawing.Size(312, 314)
        Me.opcQualidade.StrConn = Nothing
        Me.opcQualidade.TabIndex = 7
        Me.opcQualidade.TextoSQL = ""
        Me.opcQualidade.Titulo = "Escolha Qualidades"
        Me.opcQualidade.Visible = False
        '
        'opcArm
        '
        Me.opcArm.Atualizar = Nothing
        Me.opcArm.AutoBind = False
        Me.opcArm.ListaSQL = "SELECT ARMAZEM_NUM FROM IM.ARMAZEM_PRACA GROUP BY ARMAZEM_NUM"
        Me.opcArm.Location = New System.Drawing.Point(321, 346)
        Me.opcArm.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcArm.MostraConfirma = True
        Me.opcArm.Name = "opcArm"
        Me.opcArm.Params = CType(resources.GetObject("opcArm.Params"), System.Collections.ArrayList)
        Me.opcArm.Size = New System.Drawing.Size(312, 314)
        Me.opcArm.StrConn = Nothing
        Me.opcArm.TabIndex = 2
        Me.opcArm.TextoSQL = ""
        Me.opcArm.Titulo = "Escolha Armazéns"
        Me.opcArm.Visible = False
        '
        'opcEstado
        '
        Me.opcEstado.Atualizar = Nothing
        Me.opcEstado.AutoBind = False
        Me.opcEstado.ListaSQL = "SELECT UF FROM IM.ESTADO"
        Me.opcEstado.Location = New System.Drawing.Point(321, 35)
        Me.opcEstado.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcEstado.MostraConfirma = True
        Me.opcEstado.Name = "opcEstado"
        Me.opcEstado.Params = CType(resources.GetObject("opcEstado.Params"), System.Collections.ArrayList)
        Me.opcEstado.Size = New System.Drawing.Size(312, 314)
        Me.opcEstado.StrConn = Nothing
        Me.opcEstado.TabIndex = 1
        Me.opcEstado.TextoSQL = ""
        Me.opcEstado.Titulo = "Escolha Estados"
        Me.opcEstado.Visible = False
        '
        'opcPedido
        '
        Me.opcPedido.Atualizar = Nothing
        Me.opcPedido.AutoBind = False
        Me.opcPedido.ListaSQL = "SELECT REF FROM IM.PED"
        Me.opcPedido.Location = New System.Drawing.Point(3, 1937)
        Me.opcPedido.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcPedido.MostraConfirma = True
        Me.opcPedido.Name = "opcPedido"
        Me.opcPedido.Params = CType(resources.GetObject("opcPedido.Params"), System.Collections.ArrayList)
        Me.opcPedido.Size = New System.Drawing.Size(312, 314)
        Me.opcPedido.StrConn = Nothing
        Me.opcPedido.TabIndex = 8
        Me.opcPedido.TextoSQL = ""
        Me.opcPedido.Titulo = "Escolha Pedidos"
        Me.opcPedido.Visible = False
        '
        'opcFilaImp
        '
        Me.opcFilaImp.Atualizar = Nothing
        Me.opcFilaImp.AutoBind = False
        Me.opcFilaImp.ListaSQL = "SELECT FILA_IMP FROM IM.ETIQUETA WHERE FILA_IMP IS NOT NULL"
        Me.opcFilaImp.Location = New System.Drawing.Point(321, 1297)
        Me.opcFilaImp.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcFilaImp.MostraConfirma = True
        Me.opcFilaImp.Name = "opcFilaImp"
        Me.opcFilaImp.Params = CType(resources.GetObject("opcFilaImp.Params"), System.Collections.ArrayList)
        Me.opcFilaImp.Size = New System.Drawing.Size(312, 314)
        Me.opcFilaImp.StrConn = Nothing
        Me.opcFilaImp.TabIndex = 9
        Me.opcFilaImp.TextoSQL = ""
        Me.opcFilaImp.Titulo = "Escolha Filas de Impressão"
        Me.opcFilaImp.Visible = False
        '
        'opcOrdemVenda
        '
        Me.opcOrdemVenda.Atualizar = Nothing
        Me.opcOrdemVenda.AutoBind = False
        Me.opcOrdemVenda.ListaSQL = "SELECT ORDEM_VENDA_REF FROM IM.VW_COL_RASTREA_ETIQ GROUP BY ORDEM_VENDA_REF"
        Me.opcOrdemVenda.Location = New System.Drawing.Point(3, 1617)
        Me.opcOrdemVenda.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcOrdemVenda.MostraConfirma = True
        Me.opcOrdemVenda.Name = "opcOrdemVenda"
        Me.opcOrdemVenda.Params = CType(resources.GetObject("opcOrdemVenda.Params"), System.Collections.ArrayList)
        Me.opcOrdemVenda.Size = New System.Drawing.Size(312, 314)
        Me.opcOrdemVenda.StrConn = Nothing
        Me.opcOrdemVenda.TabIndex = 10
        Me.opcOrdemVenda.TextoSQL = ""
        Me.opcOrdemVenda.Titulo = "Escolha Ordens de Venda"
        Me.opcOrdemVenda.Visible = False
        '
        'OpcViagemPed
        '
        Me.OpcViagemPed.Atualizar = Nothing
        Me.OpcViagemPed.AutoBind = False
        Me.OpcViagemPed.ListaSQL = "SELECT VIAGEM_REF_PED FROM IM.VW_COL_RASTREA_ETIQ GROUP BY VIAGEM_REF"
        Me.OpcViagemPed.Location = New System.Drawing.Point(3, 2257)
        Me.OpcViagemPed.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.OpcViagemPed.MostraConfirma = True
        Me.OpcViagemPed.Name = "OpcViagemPed"
        Me.OpcViagemPed.Params = Nothing
        Me.OpcViagemPed.Size = New System.Drawing.Size(312, 314)
        Me.OpcViagemPed.StrConn = Nothing
        Me.OpcViagemPed.TabIndex = 11
        Me.OpcViagemPed.TextoSQL = ""
        Me.OpcViagemPed.Titulo = "Escolha Viagens"
        Me.OpcViagemPed.Visible = False
        '
        'opcDataEmissao
        '
        Me.opcDataEmissao.Atualizar = Nothing
        Me.opcDataEmissao.AutoBind = False
        Me.opcDataEmissao.ListaSQL = "SELECT DATA_EMISSAO FROM IM.VW_COL_RASTREA_ETIQ GROUP BY DATA_EMISSAO"
        Me.opcDataEmissao.Location = New System.Drawing.Point(321, 2257)
        Me.opcDataEmissao.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcDataEmissao.MostraConfirma = True
        Me.opcDataEmissao.Name = "opcDataEmissao"
        Me.opcDataEmissao.Params = Nothing
        Me.opcDataEmissao.Size = New System.Drawing.Size(312, 314)
        Me.opcDataEmissao.StrConn = Nothing
        Me.opcDataEmissao.TabIndex = 12
        Me.opcDataEmissao.TextoSQL = ""
        Me.opcDataEmissao.Titulo = "Escolha Datas de Emissão"
        Me.opcDataEmissao.Visible = False
        '
        'opcEtiqueta
        '
        Me.opcEtiqueta.Atualizar = Nothing
        Me.opcEtiqueta.AutoBind = False
        Me.opcEtiqueta.ListaSQL = "SELECT ETIQUETA FROM IM.VW_COL_RASTREA_ETIQ GROUP BY ETIQUETA"
        Me.opcEtiqueta.Location = New System.Drawing.Point(3, 2577)
        Me.opcEtiqueta.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcEtiqueta.MostraConfirma = True
        Me.opcEtiqueta.Name = "opcEtiqueta"
        Me.opcEtiqueta.Params = Nothing
        Me.opcEtiqueta.Size = New System.Drawing.Size(312, 314)
        Me.opcEtiqueta.StrConn = Nothing
        Me.opcEtiqueta.TabIndex = 13
        Me.opcEtiqueta.TextoSQL = ""
        Me.opcEtiqueta.Titulo = "Escolha Etiquetas"
        Me.opcEtiqueta.Visible = False
        '
        'opcContainer
        '
        Me.opcContainer.Atualizar = Nothing
        Me.opcContainer.AutoBind = False
        Me.opcContainer.ListaSQL = "SELECT TEU_NR FROM IM.VW_COL_RASTREA_ETIQ GROUP BY TEU_NR"
        Me.opcContainer.Location = New System.Drawing.Point(321, 2577)
        Me.opcContainer.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcContainer.MostraConfirma = True
        Me.opcContainer.Name = "opcContainer"
        Me.opcContainer.Params = Nothing
        Me.opcContainer.Size = New System.Drawing.Size(312, 314)
        Me.opcContainer.StrConn = Nothing
        Me.opcContainer.TabIndex = 14
        Me.opcContainer.TextoSQL = ""
        Me.opcContainer.Titulo = "Escolha Containers"
        Me.opcContainer.Visible = False
        '
        'opcOVItem
        '
        Me.opcOVItem.Atualizar = Nothing
        Me.opcOVItem.AutoBind = False
        Me.opcOVItem.ListaSQL = """"""
        Me.opcOVItem.Location = New System.Drawing.Point(321, 1617)
        Me.opcOVItem.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcOVItem.MostraConfirma = True
        Me.opcOVItem.Name = "opcOVItem"
        Me.opcOVItem.Params = CType(resources.GetObject("opcOVItem.Params"), System.Collections.ArrayList)
        Me.opcOVItem.Size = New System.Drawing.Size(312, 314)
        Me.opcOVItem.StrConn = Nothing
        Me.opcOVItem.TabIndex = 16
        Me.opcOVItem.TextoSQL = ""
        Me.opcOVItem.Titulo = "Escolha Itens da Ordem de Venda"
        Me.opcOVItem.Visible = False
        '
        'opcPedItem
        '
        Me.opcPedItem.Atualizar = Nothing
        Me.opcPedItem.AutoBind = False
        Me.opcPedItem.ListaSQL = """"""
        Me.opcPedItem.Location = New System.Drawing.Point(321, 1937)
        Me.opcPedItem.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcPedItem.MostraConfirma = True
        Me.opcPedItem.Name = "opcPedItem"
        Me.opcPedItem.Params = CType(resources.GetObject("opcPedItem.Params"), System.Collections.ArrayList)
        Me.opcPedItem.Size = New System.Drawing.Size(312, 314)
        Me.opcPedItem.StrConn = Nothing
        Me.opcPedItem.TabIndex = 15
        Me.opcPedItem.TextoSQL = ""
        Me.opcPedItem.Titulo = "Escolha Itens do Pedido"
        Me.opcPedItem.Visible = False
        '
        'opcCarregaEta
        '
        Me.opcCarregaEta.Atualizar = Nothing
        Me.opcCarregaEta.AutoBind = False
        Me.opcCarregaEta.ListaSQL = "SELECT CARREGA_ETA FROM IM.VW_COL_INSTRUCAO GROUP BY CARREGA_ETA"
        Me.opcCarregaEta.Location = New System.Drawing.Point(3, 2897)
        Me.opcCarregaEta.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.opcCarregaEta.MostraConfirma = True
        Me.opcCarregaEta.Name = "opcCarregaEta"
        Me.opcCarregaEta.Params = Nothing
        Me.opcCarregaEta.Size = New System.Drawing.Size(312, 314)
        Me.opcCarregaEta.StrConn = Nothing
        Me.opcCarregaEta.TabIndex = 17
        Me.opcCarregaEta.TextoSQL = ""
        Me.opcCarregaEta.Titulo = "Escolha Previsões de Carregamento"
        Me.opcCarregaEta.Visible = False
        '
        'EstoqueF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.opcCarregaEta)
        Me.Controls.Add(Me.opcOVItem)
        Me.Controls.Add(Me.opcPedItem)
        Me.Controls.Add(Me.opcPraca)
        Me.Controls.Add(Me.opcContainer)
        Me.Controls.Add(Me.opcEtiqueta)
        Me.Controls.Add(Me.opcDataEmissao)
        Me.Controls.Add(Me.OpcViagemPed)
        Me.Controls.Add(Me.opcOrdemVenda)
        Me.Controls.Add(Me.opcFilaImp)
        Me.Controls.Add(Me.opcProd)
        Me.Controls.Add(Me.opcEstab)
        Me.Controls.Add(Me.opcPedido)
        Me.Controls.Add(Me.btnDefs)
        Me.Controls.Add(Me.opcNCM)
        Me.Controls.Add(Me.opcMedida)
        Me.Controls.Add(Me.opcGrupo)
        Me.Controls.Add(Me.opcQualidade)
        Me.Controls.Add(Me.opcArm)
        Me.Controls.Add(Me.opcEstado)
        Me.Name = "EstoqueF"
        Me.Size = New System.Drawing.Size(962, 3274)
        Me.mnuEstoque.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDefs As System.Windows.Forms.Button
    Friend WithEvents mnuEstoque As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents grGrupo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grEstado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grEstabelecim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grArmazem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grPraca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grProduto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grNCM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grMedida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grQualidade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grFilaImp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grOrdemVenda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grViagem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grDataEmissao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grEtiqueta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grContainer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grPedItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grOVItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grCarregaEta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcGrupo As Icraft.IcftFOpc
    Friend WithEvents opcEstado As Icraft.IcftFOpc
    Friend WithEvents opcPraca As Icraft.IcftFOpc
    Friend WithEvents opcProd As Icraft.IcftFOpc
    Friend WithEvents opcEstab As Icraft.IcftFOpc
    Friend WithEvents opcNCM As Icraft.IcftFOpc
    Friend WithEvents opcArm As Icraft.IcftFOpc
    Friend WithEvents opcMedida As Icraft.IcftFOpc
    Friend WithEvents opcQualidade As Icraft.IcftFOpc
    Friend WithEvents LimparToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents opcPedido As Icraft.IcftFOpc
    Friend WithEvents opcFilaImp As Icraft.IcftFOpc
    Friend WithEvents opcOrdemVenda As Icraft.IcftFOpc
    Friend WithEvents OpcViagemPed As Icraft.IcftFOpc
    Friend WithEvents opcDataEmissao As Icraft.IcftFOpc
    Friend WithEvents opcEtiqueta As Icraft.IcftFOpc
    Friend WithEvents opcContainer As Icraft.IcftFOpc
    Friend WithEvents opcOVItem As Icraft.IcftFOpc
    Friend WithEvents opcPedItem As Icraft.IcftFOpc
    Friend WithEvents opcCarregaEta As Icraft.IcftFOpc

End Class
