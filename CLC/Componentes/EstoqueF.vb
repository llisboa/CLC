Imports Icraft.IcftFOpc
Public Class EstoqueF

    Public Event AposConfirmar()

    Private Sub btnDefs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefs.Click
        mnuEstoque.Show(btnDefs, New System.Drawing.Point(0, btnDefs.Height + 2))
    End Sub

    Private CamposAr() As String = {"ESTADO", "ARMAZEM_CIA_COD", "ARMAZEM_NUM", "ARMAZEM_PRACA", "FPRODUTO", "NCM", "'POL:' || DIMENSAO_POL,'MM:' || DIMENSAO_MM,'OU:' ||DIMENSAO_OU", "QUALIDADE", "PED_REF", "FILA_IMP", "ORDEM_VENDA_REF", "VIAGEM_REF_PED", "DATA_EMISSAO", "ETIQUETA", "TEU_NR", "PED_ITEM", "ORDEM_VENDA_ITEM", "CARREGA_ETA"}

    Private Function Crit(ByVal Variav As String, ByVal CondSQL As String) As String
        Dim Ret As String = ""
        Dim Opc() As String = Split(Variav, ",")
        For Each Campo As String In Opc
            Ret &= IIf(Ret <> "", " OR ", "") & Campo & " " & CondSQL
        Next
        If Opc.Count > 1 Then
            Ret = "(" & Ret & ")"
        End If
        Return Ret
    End Function

    Public ReadOnly Property SQL() As String
        Get
            Dim RET As String = ""
            If EstadoSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(0), EstadoSQL)
            End If
            If EstabelecimentoSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(1), EstabelecimentoSQL)
            End If
            If ArmazemSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(2), ArmazemSQL)
            End If
            If PracaSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(3), PracaSQL)
            End If
            If ProdutoSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(4), ProdutoSQL)
            End If
            If NCMSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(5), NCMSQL)
            End If
            If MedidaSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(6), MedidaSQL)
            End If
            If QualidadeSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(7), QualidadeSQL)
            End If
            If PedidoSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(8), PedidoSQL)
                opcPedItem.ListaSQL = "SELECT PED_ITEM FROM IM.VW_COL_RASTREA_ETIQ WHERE " & RET & " GROUP BY PED_REF, PED_ITEM ORDER BY PED_REF, PED_ITEM"
            End If
            If FilaImpSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(9), FilaImpSQL)
            End If
            If OrdemVendaSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(10), OrdemVendaSQL)
                opcOVItem.ListaSQL = "SELECT ORDEM_VENDA_ITEM FROM IM.VW_COL_RASTREA_ETIQ WHERE " & RET & " GROUP BY ORDEM_VENDA_REF, ORDEM_VENDA_ITEM ORDER BY ORDEM_VENDA_REF, ORDEM_VENDA_ITEM"
            End If
            If ViagemSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(11), ViagemSQL)
            End If
            If DataEmissaoSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(12), DataEmissaoSQL)
            End If
            If EtiquetaSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(13), EtiquetaSQL)
            End If
            If ContainerSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(14), ContainerSQL)
            End If
            If PedItemSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(15), PedItemSQL)
            End If
            If OVItemSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(16), OVItemSQL)
            End If
            If CarregaEtaSQL <> "" Then
                RET &= IIf(RET <> "", " AND ", "") & Crit(CamposAr(16), OVItemSQL)
            End If
            Dim RET2 As String = ""
            If Trim(GrupoSQL) = "" Then
                RET2 = "SELECT * FROM IM.VW_COL_RASTREA_ETIQ"
            Else
                RET2 = VwColGrupo(GrupoSQL)
            End If
            If RET <> "" Then
                RET2 &= " WHERE " & RET
            End If
            Return RET2
        End Get
    End Property

    Public Function VwColGrupo(ByVal GruposIn As String) As String
        Dim GR As String = "SELECT * FROM (SELECT * FROM IM.VW_COL_RASTREA_ETIQ COL WHERE EXISTS(" & vbCrLf & _
        "SELECT * FROM IM.estoque_org_def OD WHERE OD.ESTOQUE_COD " & GruposIn & " AND" & vbCrLf & _
        "COL.ESTADO = NVL(OD.ESTADO,COL.ESTADO) AND" & vbCrLf & _
        "COL.ARMAZEM_CIA_COD = NVL(OD.ARMAZEM_COD,COL.ARMAZEM_CIA_COD) AND" & vbCrLf & _
        "COL.FPRODUTO = NVL(OD.PRODUTO_COD,COL.FPRODUTO)" & vbCrLf & _
        "AND COL.NCM = NVL(OD.NCM,COL.NCM)" & vbCrLf & _
        "AND NVL(COL.DIMENSAO_MM,'X') LIKE NVL(OD.DIMENSAO_MM,'%')" & vbCrLf & _
        "AND NVL(COL.DIMENSAO_POL,'X') LIKE NVL(OD.DIMENSAO_POL,'%')" & vbCrLf & _
        "AND NVL(COL.DIMENSAO_OU,'X') LIKE NVL(OD.DIMENSAO_OU,'%')" & vbCrLf & _
        "AND NVL(COL.QUALIDADE,'X') LIKE NVL(OD.QUALIDADE,'%')" & vbCrLf & _
        "AND COL.ESPEC_SEQ = NVL(OD.ESPEC_SEQ,COL.ESPEC_SEQ)" & vbCrLf & _
        "))"
        Return GR
    End Function

    Sub DMENU(ByVal menu As Object, ByVal valor As Object)
        menu.Text = Replace(menu.Text, " *", "")
        If valor <> "" Then
            menu.Text = menu.Text & " *"
        Else
            menu.Text = Replace(menu.Text, " *", "")
        End If
    End Sub

    Private _GrupoSQL As String
    Public Property GrupoSQL() As String
        Get
            Return _GrupoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grGrupo, value)
            _GrupoSQL = value
        End Set
    End Property

    Private _EstadoSQL As String
    Public Property EstadoSQL() As String
        Get
            Return _EstadoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grEstado, value)
            _EstadoSQL = value
        End Set
    End Property

    Private _EstabelecimentoSQL As String
    Public Property EstabelecimentoSQL() As String
        Get
            Return _EstabelecimentoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grEstabelecim, value)
            _EstabelecimentoSQL = value
        End Set
    End Property

    Private _ArmazemSQL As String
    Public Property ArmazemSQL() As String
        Get
            Return _ArmazemSQL
        End Get
        Set(ByVal value As String)
            DMENU(grArmazem, value)
            _ArmazemSQL = value
        End Set
    End Property

    Private _PracaSQL As String
    Public Property PracaSQL() As String
        Get
            Return _PracaSQL
        End Get
        Set(ByVal value As String)
            DMENU(grPraca, value)
            _PracaSQL = value
        End Set
    End Property

    Private _ProdutoSQL As String
    Public Property ProdutoSQL() As String
        Get
            Return _ProdutoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grProduto, value)
            _ProdutoSQL = value
        End Set
    End Property

    Private _NCMSQL As String
    Public Property NCMSQL() As String
        Get
            Return _NCMSQL
        End Get
        Set(ByVal value As String)
            DMENU(grNCM, value)
            _NCMSQL = value
        End Set
    End Property

    Private _MedidaSQL As String
    Public Property MedidaSQL() As String
        Get
            Return _MedidaSQL
        End Get
        Set(ByVal value As String)
            DMENU(grMedida, value)
            _MedidaSQL = value
        End Set
    End Property

    Private _QualidadeSQL As String
    Public Property QualidadeSQL() As String
        Get
            Return _QualidadeSQL
        End Get
        Set(ByVal value As String)
            DMENU(grQualidade, value)
            _QualidadeSQL = value
        End Set
    End Property


    Private _PedidoSQL As String
    Public Property PedidoSQL() As String
        Get
            Return _PedidoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grPedido, value)
            _PedidoSQL = value
        End Set
    End Property

    Private _FilaImpSQL As String
    Public Property FilaImpSQL() As String
        Get
            Return _FilaImpSQL
        End Get
        Set(ByVal value As String)
            DMENU(grFilaImp, value)
            _FilaImpSQL = value
        End Set
    End Property

    Private _OrdemVendaSQL As String
    Public Property OrdemVendaSQL() As String
        Get
            Return _OrdemVendaSQL
        End Get
        Set(ByVal value As String)
            DMENU(grOrdemVenda, value)
            _OrdemVendaSQL = value
        End Set
    End Property

    Private _ViagemSQL As String
    Public Property ViagemSQL() As String
        Get
            Return _ViagemSQL
        End Get
        Set(ByVal value As String)
            DMENU(grViagem, value)
            _ViagemSQL = value
        End Set
    End Property

    Private _DataEmissaoSQL As String
    Public Property DataEmissaoSQL() As String
        Get
            Return _DataEmissaoSQL
        End Get
        Set(ByVal value As String)
            DMENU(grDataEmissao, value)
            _DataEmissaoSQL = value
        End Set
    End Property

    Private _EtiquetaSQL As String
    Public Property EtiquetaSQL() As String
        Get
            Return _EtiquetaSQL
        End Get
        Set(ByVal value As String)
            DMENU(grEtiqueta, value)
            _EtiquetaSQL = value
        End Set
    End Property

    Private _ContainerSQL As String
    Public Property ContainerSQL() As String
        Get
            Return _ContainerSQL
        End Get
        Set(ByVal value As String)
            DMENU(grContainer, value)
            _ContainerSQL = value
        End Set
    End Property

    Private _PedItemSQL As String
    Public Property PedItemSQL() As String
        Get
            Return _PedItemSQL
        End Get
        Set(ByVal value As String)
            DMENU(grPedItem, value)
            _PedItemSQL = value
        End Set
    End Property

    Private _OVItemSQL As String
    Public Property OVItemSQL() As String
        Get
            Return _OVItemSQL
        End Get
        Set(ByVal value As String)
            DMENU(grOVItem, value)
            _OVItemSQL = value
        End Set
    End Property

    Private _CarregaEtaSQL As String
    Public Property CarregaEtaSQL() As String
        Get
            Return _CarregaEtaSQL
        End Get
        Set(ByVal value As String)
            DMENU(grCarregaEta, value)
            _CarregaEtaSQL = value
        End Set
    End Property

    Dim Ativo As Icraft.IcftFOpc = Nothing
    Enum TipoOpc
        Grupo
        Estado
        Estabelecim
        Armazem
        Praca
        Produto
        NCM
        Medida
        Qualidade
        Pedido
        FilaImp
        OrdemVenda
        Viagem
        DataEmissao
        Etiqueta
        Container
        PedItem
        OVItem
        CarregaEta
    End Enum

    Enum MetodoOpc
        Trecho
        Iniciando
    End Enum

    Sub Ativa(ByVal Tipo As TipoOpc, Optional ByVal Metodo As MetodoOpc = MetodoOpc.Trecho)
        If Not IsNothing(Ativo) Then
            Desativa()
        End If
        If Tipo = TipoOpc.Armazem Then
            opcArm.TextoSQL = ArmazemSQL
            Ativo = opcArm
        ElseIf Tipo = TipoOpc.Estabelecim Then
            opcEstab.TextoSQL = EstabelecimentoSQL
            Ativo = opcEstab
        ElseIf Tipo = TipoOpc.Estado Then
            opcEstado.TextoSQL = EstadoSQL
            Ativo = opcEstado
        ElseIf Tipo = TipoOpc.Grupo Then
            opcGrupo.TextoSQL = GrupoSQL
            Ativo = opcGrupo
        ElseIf Tipo = TipoOpc.Medida Then
            opcMedida.TextoSQL = MedidaSQL
            Ativo = opcMedida
        ElseIf Tipo = TipoOpc.NCM Then
            opcNCM.TextoSQL = NCMSQL
            Ativo = opcNCM
        ElseIf Tipo = TipoOpc.Praca Then
            opcPraca.TextoSQL = PracaSQL
            Ativo = opcPraca
        ElseIf Tipo = TipoOpc.Produto Then
            opcProd.TextoSQL = ProdutoSQL
            Ativo = opcProd
        ElseIf Tipo = TipoOpc.Qualidade Then
            opcQualidade.TextoSQL = QualidadeSQL
            Ativo = opcQualidade
        ElseIf Tipo = TipoOpc.Pedido Then
            opcPedido.TextoSQL = PedidoSQL
            Ativo = opcPedido
        ElseIf Tipo = TipoOpc.FilaImp Then
            opcFilaImp.TextoSQL = FilaImpSQL
            Ativo = opcFilaImp
        ElseIf Tipo = TipoOpc.OrdemVenda Then
            opcOrdemVenda.TextoSQL = OrdemVendaSQL
            Ativo = opcOrdemVenda
        ElseIf Tipo = TipoOpc.Viagem Then
            OpcViagemPed.TextoSQL = ViagemSQL
            Ativo = OpcViagemPed
        ElseIf Tipo = TipoOpc.DataEmissao Then
            opcDataEmissao.TextoSQL = DataEmissaoSQL
            Ativo = opcDataEmissao
        ElseIf Tipo = TipoOpc.Etiqueta Then
            opcEtiqueta.TextoSQL = EtiquetaSQL
            Ativo = opcEtiqueta
        ElseIf Tipo = TipoOpc.Container Then
            opcContainer.TextoSQL = ContainerSQL
            Ativo = opcContainer
        ElseIf Tipo = TipoOpc.PedItem Then
            opcPedItem.TextoSQL = PedItemSQL
            Ativo = opcPedItem
        ElseIf Tipo = TipoOpc.OVItem Then
            opcOVItem.TextoSQL = OVItemSQL
            Ativo = opcOVItem
        ElseIf Tipo = TipoOpc.CarregaEta Then
            opcCarregaEta.TextoSQL = CarregaEtaSQL
            Ativo = opcCarregaEta
        End If
        If Not IsNothing(Ativo) Then
            If Metodo = MetodoOpc.Iniciando Then
                Ativo.Metodo = Icraft.IcftFOpc.MetodoOpc.Iniciando
            ElseIf Metodo = MetodoOpc.Trecho Then
                Ativo.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
            End If
            Ativo.Bind()
            Ativo.Top = btnDefs.Top + btnDefs.Height + 5
            Ativo.Left = btnDefs.Left - 4
            Ativo.Visible = True
            Me.Height = Ativo.Height + Ativo.Top + 4
            Me.Width = Ativo.Width + Ativo.Left + 4
        End If

    End Sub

    Public Property BotaoTexto() As String
        Get
            Return btnDefs.Text
        End Get
        Set(ByVal value As String)
            btnDefs.Text = value
        End Set
    End Property

    Sub Desativa()
        If Not IsNothing(Ativo) Then
            Ativo.Visible = False
        End If
        Me.Height = btnDefs.Height + btnDefs.Top
        Me.Width = btnDefs.Width + btnDefs.Left
        Ativo = Nothing
    End Sub

    Private Sub EstoqueF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Desativa()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grEstado.Click
        Ativa(TipoOpc.Estado)
    End Sub

    Private Sub EstabelecimentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grEstabelecim.Click
        Ativa(TipoOpc.Estabelecim)
    End Sub

    Private Sub ArmazémToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grArmazem.Click
        Ativa(TipoOpc.Armazem)
    End Sub

    Private Sub PraçaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grPraca.Click
        Ativa(TipoOpc.Praca)
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grProduto.Click
        Ativa(TipoOpc.Produto)
    End Sub

    Private Sub NCMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grNCM.Click
        Ativa(TipoOpc.NCM)
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grGrupo.Click
        Ativa(TipoOpc.Grupo)
    End Sub

    Private Sub MedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grMedida.Click
        Ativa(TipoOpc.Medida)
    End Sub

    Private Sub QualidadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grQualidade.Click
        Ativa(TipoOpc.Qualidade)
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grPedido.Click
        Ativa(TipoOpc.Pedido)
    End Sub
    Private Sub FilaImpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grFilaImp.Click
        Ativa(TipoOpc.FilaImp)
    End Sub

    Private Sub OrdemVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grOrdemVenda.Click
        Ativa(TipoOpc.OrdemVenda)
    End Sub

    Private Sub ViagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grViagem.Click
        Ativa(TipoOpc.Viagem)
    End Sub

    Private Sub DataEmissaoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grDataEmissao.Click
        Ativa(TipoOpc.DataEmissao)
    End Sub

    Private Sub EtiquetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grEtiqueta.Click
        Ativa(TipoOpc.Etiqueta)
    End Sub

    Private Sub ContainerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grContainer.Click
        Ativa(TipoOpc.Container)
    End Sub

    Private Sub PedItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grPedItem.Click
        If PedidoSQL = "" Then
            If MsgBox("Para filtrar itens de um pedido, é necessário definir o pedido previamente. Deseja definir o pedido?", MsgBoxStyle.YesNo, "Itens do Pedido.") = MsgBoxResult.Yes Then
                Ativa(TipoOpc.Pedido)
            Else
                Desativa()
            End If
        Else
            Ativa(TipoOpc.PedItem)
        End If
    End Sub

    Private Sub OVItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grOVItem.Click
        If OrdemVendaSQL = "" Then
            If MsgBox("Para filtrar itens de uma ordem de venda, é necessário definir a ordem previamente. Deseja definir a ordem?", MsgBoxStyle.YesNo, "Itens da Ordem de Venda.") = MsgBoxResult.Yes Then
                Ativa(TipoOpc.OrdemVenda)
            Else
                Desativa()
            End If
        Else
            Ativa(TipoOpc.OVItem)
        End If
    End Sub

    Private Sub CarregaEtaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grCarregaEta.Click
        Ativa(TipoOpc.CarregaEta)
    End Sub

    Sub Confirm() Handles opcArm.AposConfirmar, opcEstab.AposConfirmar, opcEstado.AposConfirmar, opcGrupo.AposConfirmar, opcMedida.AposConfirmar, opcNCM.AposConfirmar, opcPraca.AposConfirmar, opcProd.AposConfirmar, opcQualidade.AposConfirmar, opcPedido.AposConfirmar, opcFilaImp.AposConfirmar, opcOrdemVenda.AposConfirmar, OpcViagemPed.AposConfirmar, opcDataEmissao.AposConfirmar, opcEtiqueta.AposConfirmar, opcContainer.AposConfirmar, opcPedItem.AposConfirmar, opcOVItem.AposConfirmar, opcCarregaEta.AposConfirmar
        If Not IsNothing(Ativo) Then
            If Ativo.Titulo = opcArm.Titulo Then
                ArmazemSQL = opcArm.TextoSQL
            ElseIf Ativo.Titulo = opcEstab.Titulo Then
                EstabelecimentoSQL = opcEstab.TextoSQL
            ElseIf Ativo.Titulo = opcEstado.Titulo Then
                EstadoSQL = opcEstado.TextoSQL
            ElseIf Ativo.Titulo = opcGrupo.Titulo Then
                GrupoSQL = opcGrupo.TextoSQL
            ElseIf Ativo.Titulo = opcMedida.Titulo Then
                MedidaSQL = opcMedida.TextoSQL
            ElseIf Ativo.Titulo = opcNCM.Titulo Then
                NCMSQL = opcNCM.TextoSQL
            ElseIf Ativo.Titulo = opcPraca.Titulo Then
                PracaSQL = opcPraca.TextoSQL
            ElseIf Ativo.Titulo = opcProd.Titulo Then
                ProdutoSQL = opcProd.TextoSQL
            ElseIf Ativo.Titulo = opcQualidade.Titulo Then
                QualidadeSQL = opcQualidade.TextoSQL
            ElseIf Ativo.Titulo = opcPedido.Titulo Then
                PedidoSQL = opcPedido.TextoSQL
            ElseIf Ativo.Titulo = opcFilaImp.Titulo Then
                FilaImpSQL = opcFilaImp.TextoSQL
            ElseIf Ativo.Titulo = opcOrdemVenda.Titulo Then
                OrdemVendaSQL = opcOrdemVenda.TextoSQL
            ElseIf Ativo.Titulo = OpcViagemPed.Titulo Then
                ViagemSQL = OpcViagemPed.TextoSQL
            ElseIf Ativo.Titulo = opcDataEmissao.Titulo Then
                DataEmissaoSQL = opcDataEmissao.TextoSQL
            ElseIf Ativo.Titulo = opcEtiqueta.Titulo Then
                EtiquetaSQL = opcEtiqueta.TextoSQL
            ElseIf Ativo.Titulo = opcContainer.Titulo Then
                ContainerSQL = opcContainer.TextoSQL
            ElseIf Ativo.Titulo = opcPedItem.Titulo Then
                PedItemSQL = opcPedItem.TextoSQL
            ElseIf Ativo.Titulo = opcOVItem.Titulo Then
                OVItemSQL = opcOVItem.TextoSQL
            ElseIf Ativo.Titulo = opcCarregaEta.Titulo Then
                CarregaEtaSQL = opcCarregaEta.TextoSQL
            End If
        End If
        Desativa()
        RaiseEvent AposConfirmar()
    End Sub

    Sub Canc() Handles opcArm.AposCancelar, opcEstab.AposCancelar, opcEstado.AposCancelar, opcGrupo.AposCancelar, opcMedida.AposCancelar, opcNCM.AposCancelar, opcPraca.AposCancelar, opcProd.AposCancelar, opcQualidade.AposCancelar, opcPedido.AposCancelar, opcFilaImp.AposCancelar, opcOrdemVenda.AposCancelar, OpcViagemPed.AposCancelar, opcDataEmissao.AposCancelar, opcEtiqueta.AposCancelar, opcContainer.AposCancelar, opcPedItem.AposCancelar, opcOVItem.AposCancelar, opcCarregaEta.AposCancelar
        Desativa()
    End Sub

    Private _StrConn As Object
    Public Property StrConn() As Object
        Get
            Return _StrConn
        End Get
        Set(ByVal value As Object)
            If IsNothing(_StrConn) OrElse _StrConn <> value Then
                opcArm.StrConn = value
                opcEstab.StrConn = value
                opcEstado.StrConn = value
                opcGrupo.StrConn = value
                opcMedida.StrConn = value
                opcNCM.StrConn = value
                opcPraca.StrConn = value
                opcProd.StrConn = value
                opcQualidade.StrConn = value
                opcPedido.StrConn = value
                opcFilaImp.StrConn = value
                opcOrdemVenda.StrConn = value
                OpcViagemPed.StrConn = value
                opcDataEmissao.StrConn = value
                opcEtiqueta.StrConn = value
                opcContainer.StrConn = value
                opcPedItem.StrConn = value
                opcOVItem.StrConn = value
                opcCarregaEta.StrConn = value
                _StrConn = value
            End If
        End Set
    End Property

    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        ArmazemSQL = ""
        EstabelecimentoSQL = ""
        EstadoSQL = ""
        GrupoSQL = ""
        MedidaSQL = ""
        NCMSQL = ""
        PracaSQL = ""
        ProdutoSQL = ""
        QualidadeSQL = ""
        PedidoSQL = ""
        FilaImpSQL = ""
        OrdemVendaSQL = ""
        ViagemSQL = ""
        DataEmissaoSQL = ""
        EtiquetaSQL = ""
        ContainerSQL = ""
        PedItemSQL = ""
        OVItemSQL = ""
        CarregaEtaSQL = ""
        RaiseEvent AposConfirmar()
    End Sub
End Class
