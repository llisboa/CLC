Imports Icraft.IcftBase

Public Class frmEstoqueEstat

    Public Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            pnlBaixo.Visible = False

            Dim SQL As String = ""
            Dim OPC As Integer = Val(TXTCONSULTA.Text)
            Dim BRAPIDA As String = ""
            Dim ORDEM As String = ""
            Dim TITULOS As String = ""
            Dim CHAVE As String = ""

            Select Case OPC
                Case 1


                    '1=Total de vendas/saldo/reservas por cliente

                    SQL = "SELECT CLIENTE_COD, SUM(DECODE(STATUS_COD,'RESERVA', 0, NOMINAL_PED_UNID)) PEDIDO, PED_UNID, " & vbCrLf & _
                    "SUM(EMB_PED_UNID) ENTREGUE, SUM(SALDO) SALDO, " & vbCrLf & _
                    "SUM(DECODE(STATUS_COD,'RESERVA', NOMINAL_PED_UNID,0)) RESERVA FROM IM.VW_COL_RASTREA_OVI" & vbCrLf & _
                    "WHERE STATUS_COD <> 'CANCELADO'" & vbCrLf & _
                    "GROUP BY CLIENTE_COD, PED_UNID "

                    BRAPIDA = "CLIENTE_COD || PEDIDO"
                    ORDEM = "CLIENTE_COD"
                    TITULOS = "Cliente;Qtd Ped;Unid;Entregue;Saldo;Reserva"

                Case 2

                    '2=Vendas por vendedor com saldo e reservas

                    SQL = "SELECT VENDEDOR_COD, SUM(DECODE(STATUS_COD,'RESERVA', 0, NOMINAL_PED_UNID)) PEDIDO, PED_UNID, " & vbCrLf & _
                    "SUM(EMB_PED_UNID) ENTREGUE, SUM(SALDO) SALDO, " & vbCrLf & _
                    "SUM(DECODE(STATUS_COD,'RESERVA', NOMINAL_PED_UNID,0)) RESERVA " & vbCrLf & _
                    "FROM IM.VW_COL_RASTREA_OVI" & vbCrLf & _
                    "WHERE STATUS_COD <> 'CANCELADO'" & vbCrLf & _
                    "GROUP BY VENDEDOR_COD, PED_UNID "

                    BRAPIDA = "VENDEDOR_COD || PEDIDO"
                    ORDEM = "VENDEDOR_COD"
                    TITULOS = "Vendedor;Qtd Ped;Unid;Entregue;Saldo;Reserva"


                Case 3

                    '3=Vendas mensais por vendedor

                    SQL = "SELECT VW.VENDEDOR_COD, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM') PERIODO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', 0, VW.NOMINAL_PED_UNID)) PEDIDO," & vbCrLf & _
                    "  VW.PED_UNID," & vbCrLf & _
                    "  SUM(VW.EMB_PED_UNID) ENTREGUE," & vbCrLf & _
                    "  SUM(VW.SALDO) SALDO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', VW.NOMINAL_PED_UNID,0)) RESERVA" & vbCrLf & _
                    "FROM IM.VW_COL_RASTREA_OVI VW, IM.ORDEM_VENDA OV" & vbCrLf & _
                    "WHERE VW.STATUS_COD <> 'CANCELADO' AND" & vbCrLf & _
                    "VW.OV_REF = OV.REF (+)" & vbCrLf & _
                    "GROUP BY VW.VENDEDOR_COD, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM'),  VW.PED_UNID"

                    SQL = Icraft.IcftBase.RefCruz(SQL, "VENDEDOR_COD;PED_UNID", "PERIODO", "SUM", "PEDIDO", Login.Strconn, "", "")
                    BRAPIDA = "VENDEDOR_COD || PED_UNID"
                    ORDEM = ""
                    TITULOS = "Vendedor;Unid"


                Case 4

                    '4=Vendas mensais por cliente

                    SQL = "SELECT VW.CLIENTE_COD, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM') PERIODO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', 0, VW.NOMINAL_PED_UNID)) PEDIDO," & vbCrLf & _
                    "  VW.PED_UNID," & vbCrLf & _
                    "  SUM(VW.EMB_PED_UNID) ENTREGUE," & vbCrLf & _
                    "  SUM(VW.SALDO) SALDO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', VW.NOMINAL_PED_UNID,0)) RESERVA" & vbCrLf & _
                    "FROM IM.VW_COL_RASTREA_OVI VW, IM.ORDEM_VENDA OV" & vbCrLf & _
                    "WHERE VW.STATUS_COD <> 'CANCELADO' AND" & vbCrLf & _
                    "VW.OV_REF = OV.REF (+)" & vbCrLf & _
                    "GROUP BY VW.CLIENTE_COD, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM'),  VW.PED_UNID"

                    SQL = Icraft.IcftBase.RefCruz(SQL, "CLIENTE_COD;PED_UNID", "PERIODO", "SUM", "PEDIDO", Login.Strconn, "", "")
                    BRAPIDA = "CLIENTE_COD || PED_UNID"
                    ORDEM = ""
                    TITULOS = "Cliente;Unid"


                Case 5

                    '5=Vendas mensais de produto

                    SQL = "SELECT VW.PRODUTO_COD, VW.ESPEC, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM') PERIODO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', 0, VW.NOMINAL_PED_UNID)) PEDIDO," & vbCrLf & _
                    "  VW.PED_UNID," & vbCrLf & _
                    "  SUM(VW.EMB_PED_UNID) ENTREGUE," & vbCrLf & _
                    "  SUM(VW.SALDO) SALDO," & vbCrLf & _
                    "  SUM(DECODE(VW.STATUS_COD,'RESERVA', VW.NOMINAL_PED_UNID,0)) RESERVA" & vbCrLf & _
                    "FROM IM.VW_COL_RASTREA_OVI VW, IM.ORDEM_VENDA OV" & vbCrLf & _
                    "WHERE VW.STATUS_COD <> 'CANCELADO' AND" & vbCrLf & _
                    "VW.OV_REF = OV.REF (+)" & vbCrLf & _
                    "GROUP BY VW.PRODUTO_COD, VW.ESPEC, TO_CHAR(OV.DATA_ORDEM, 'YYYY-MM'),  VW.PED_UNID"

                    SQL = Icraft.IcftBase.RefCruz(SQL, "PRODUTO_COD;ESPEC;PED_UNID", "PERIODO", "SUM", "PEDIDO", Login.Strconn, "", "")
                    BRAPIDA = "PRODUTO_COD || ESPEC"
                    ORDEM = ""
                    TITULOS = "Produto;Espec;Unidade;"


                Case 6

                    '6=Total de compras por fornecedor

                    SQL = "SELECT FORNEC_COD, SUM(NOMINAL_PED_UNID) NOMINAL_PED_UNID, PED_UNID  FROM IM.VW_COL_PED_ITEM GROUP BY FORNEC_COD, PED_UNID"
                    BRAPIDA = "FORNEC_COD || NOMINAL_PED_UNID"
                    ORDEM = "FORNEC_COD"
                    CHAVE = "FORNEC_COD;PED_UNID"
                    TITULOS = "Fornecedor;Nominal;Unid"

                Case 7

                    '7=Correlação Prod/Espec CLC x CIEX

                    SQL = "SELECT * FROM (SELECT vw.produto_cod CLC_PROD, ciex.descr CIEX_PROD, vw.espec CLC_ESPEC, CIEX.""DIMENSÃO"" CIEX_ESPEC FROM " & vbCrLf & _
                    "IM.vw_col_rastrea_ovi VW, IM.ORDEM_VENDA_ITEM IM, CIEX.CONFIRM_VENDA_ITEM CIEX" & vbCrLf & _
                    "WHERE vw.ov_ref = im.ordem_venda_ref (+) and" & vbCrLf & _
                    "vw.ov_item = im.item (+) and" & vbCrLf & _
                    "nvl(im.ciex_ordem_ref,im.ordem_venda_ref) = CIEX.CONFIRM_VENDA_REF (+) AND" & vbCrLf & _
                    "nvl(IM.CIEX_ITEM,IM.ITEM) = CIEX.ITEM (+) AND" & vbCrLf & _
                    "NOT CIEX.CONFIRM_VENDA_REF IS NULL) GROUP BY" & vbCrLf & _
                    "CLC_PROD, CIEX_PROD, CLC_ESPEC, CIEX_ESPEC"


                    BRAPIDA = "CLC_PROD || CIEX_PROD || CLC_ESPEC || CIEX_ESPEC"
                    ORDEM = "CLC_PROD, CLC_ESPEC"
                    CHAVE = "CLC_PROD;CLC_ESPEC;CIEX_PROD;CIEX_ESPEC"
                    TITULOS = "Produto no CLC;Produto no CIEX;Especificações no CLC;Especificações no CIEX"

                Case 8

                    SQL = "SELECT DISTINCT * FROM (SELECT IM.REF, IM.CLIENTE_COD CLIENTE_CLC,  CIEX.COMPRADOR CLIENTE_CIEX, " & vbCrLf & _
                    "IM.INCOTERM_VENDA INCOTERM_VENDA_CLC, CIEX.PREÇO_DETALHE INCOTERM_VENDA_CIEX, " & vbCrLf & _
                    "IM.MOEDA_COD MOEDA_CLC, CIEX.MOEDA MOEDA_CIEX" & vbCrLf & _
                    "FROM IM.ORDEM_VENDA IM, CIEX.CONFIRM_VENDA CIEX" & vbCrLf & _
                    "WHERE im.REF = CIEX.REF (+) AND NOT CIEX.REF IS NULL)" & vbCrLf & _
                    "WHERE (CLIENTE_CLC <> CLIENTE_CIEX OR INCOTERM_VENDA_CLC <> INCOTERM_VENDA_CIEX OR MOEDA_CLC <> MOEDA_CIEX)"

                    BRAPIDA = "REF || CLIENTE_CLC || CLIENTE_CIEX || INCOTERM_VENDA_CLC || INCOTERM_VENDA_CIEX || MOEDA_CLC || MOEDA_CIEX"
                    ORDEM = ""
                    CHAVE = ""
                    TITULOS = "Ordem de Venda;Cliente no CLC;Cliente no CIEX;Termo Internacional de Venda no CLC;Termo Internacional de Venda no CIEX;Moeda no CLC;Moeda no CIEX;"

                Case 9

                    '9=Estoque de produto avariado de não avariado

                    SQL = "SELECT PRODUTO_COD, ESPEC, REAL_AVARIADO, NEGOCIADO_AVARIADO, RESERVADO_AVARIADO, DISPONIVEL_AVARIADO, REAL_OK, NEGOCIADO_OK, RESERVADO_OK, DISPONIVEL_OK  FROM IM.VW_COL_ESTOQUE_DINA"

                    BRAPIDA = "PRODUTO_COD || ESPEC"
                    ORDEM = ""
                    CHAVE = ""
                    TITULOS = "Produto;Especificação;Real Avariado;Negociado Avariado;Reservado Avariado;Disponível Avariado;Real OK;Negociado OK;Reservado OK;Disponível OK"


                Case 10

                    '10=Especificações de Produto e Descrições Comerciais p/ Vendedores
                    SQL = "select VW.PRODUTO_COD, VW.ESPEC, PE.COMER_PROD, PE.COMER_DIMENS, PE.COMER_COMPL from IM.VW_COL_PED_ITEM VW, IM.PROD_ESPEC PE" & vbCrLf & _
                    "where VW.PROD_COD = PE.PRODUTO_COD (+) and" & vbCrLf & _
                    "VW.ESPEC_SEQ = PE.SEQ (+)"

                    BRAPIDA = "PRODUTO_COD, ESPEC || COMER_PROD || COMER_DIMENS || COMER_COMPL"
                    ORDEM = ""
                    CHAVE = ""
                    TITULOS = "CLC-Produto;CLC-Especificação;Vendedores-Produto;Vend.-Dimensão;Vend.Compl"

                Case 11
                    '11=Ordens de Venda sem IPI
                    SQL = "SELECT OV_REF, OV_ITEM, FPRODUTO, EMBALAGEM, ESPEC, ESPEC_SEQ, NOMINAL_PED_UNID || ' ' || PED_UNID NOMINAL, SALDO, CLIENTE_COD, STATUS_COD, CFOP, ICMS, IPI, PIS, COFINS FROM IM.VW_COL_RASTREA_OVI WHERE (IPI IS NULL OR IPI = 0) AND FPRODUTO NOT IN ('PEH','PEI','PET','CAN','BCH','BQA','BRD') ORDER BY 1,2,3,4"
                    ORDEM = ""
                    CHAVE = ""
                    TITULOS = "Ordem de Venda;Item;Produto;Embalagem;Especificações;Sequencial;Nominal;Saldo;Cliente;Status;CFOP;ICMS;IPI;PIS;COFINS"
                Case Else
                    MsgBox("Informe uma das consultas para visualizar informações.", vbOKOnly + vbInformation, "Mensagem")
                    Exit Sub
            End Select

            If txtBusca.Text <> "" Then
                Dim CRIT As String = ""
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(" & BRAPIDA & "), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
                SQL = "SELECT * FROM (" & SQL & ") WHERE " & CRIT
            End If
            If ORDEM <> "" Then
                SQL &= " ORDER BY " & ORDEM
            End If

            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.Chave = CHAVE
            grdPrinc.ColunaNomes = TITULOS
            grdPrinc.SomenteLeitura = True
            grdPrinc.Bind()
            Me.Text = Mid(TXTCONSULTA.Items(OPC - 1), InStr(TXTCONSULTA.Items(OPC - 1), "=") + 1)

        Catch ex As Exception
            MsgBox("Erro ao atualizar consulta:" & ex.Message)
        End Try
    End Sub

    Private Sub frmEstoqueEstat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChanged
    End Sub


    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim SQL As String = ""
        Try
            Dim OPC As Integer = Val(TXTCONSULTA.Text)

            Select Case OPC
                Case 1
                    SQL = "SELECT VW.OV_REF, VW.OV_ITEM, VW.PRODUTO_COD, VW.EMBALAGEM," & vbCrLf & _
                    " VW.ESPEC, VW.NOMINAL_PED_UNID, VW.PED_UNID, VW.VOLUME_PECAS_QTD," & vbCrLf & _
                    " VW.OBS, VW.EMB_PED_UNID, VW.SALDO, VW.CLIENTE_COD, VW.VENDEDOR_COD, VW.STATUS_COD FROM IM.VW_COL_RASTREA_OVI VW" & vbCrLf & _
                    " WHERE VW.CLIENTE_COD = '" & grdPrinc.Grid.SelectedCells(0).Value & "'" & vbCrLf & _
                    " ORDER BY VW.OV_REF"
                    grdEtiq.SQL = SQL
                    grdEtiq.StrConn = Login.Strconn
                    grdEtiq.Usuario = Login.Usuario!usuario
                    grdEtiq.ColunaNomes = "Ordem de Venda;Item;Produto;Embalagem;Especificação;Quantidade nominal;Unidade;Qtd Peças;Obs;Embalagem;Saldo;Cliente;Vendedor;Status;"
                    grdEtiq.Totaliza = "COUNT;;;;;SUM;;SUM;;SUM;;;;"
                    grdEtiq.Bind()
                    grdEtiq.Grid.ReadOnly = True
                    grpSub.Text = "Ordens de Venda"

                Case 6
                    SQL = "SELECT PED_REF, ITEM, PRODUTO_COD, ESPEC, SUM(NOMINAL_PED_UNID) NOMINAL_PED_UNID, PED_UNID  FROM IM.VW_COL_PED_ITEM " & vbCrLf & _
                    "WHERE FORNEC_COD || ';' || PED_UNID = '" & Icraft.IcftBase.Tratex(grdPrinc.Text) & "'" & vbCrLf & _
                    "GROUP BY PED_REF, ITEM, PRODUTO_COD, ESPEC, PED_UNID"
                    grdEtiq.SQL = SQL
                    grdEtiq.StrConn = Login.Strconn
                    grdEtiq.Usuario = Login.Usuario!usuario
                    grdEtiq.ColunaNomes = "Pedido;Item;Produto;Especificação;Nominal;Unid"
                    grdEtiq.Totaliza = "COUNT;;;;SUM;;"
                    grdEtiq.Bind()
                    grdEtiq.Grid.ReadOnly = True
                    grpSub.Text = "Pedido e Item com Especificações"

                Case 7
                    SQL = "SELECT CLC_ORDEM_REF, CLC_ORDEM_ITEM, CIEX_ORDEM_REF, CIEX_ORDEM_ITEM FROM (" & vbCrLf & _
                    "SELECT vw.produto_cod CLC_PROD, ciex.descr CIEX_PROD, " & vbCrLf & _
                    "vw.espec CLC_ESPEC, CIEX.""DIMENSÃO"" CIEX_ESPEC, IM.ORDEM_VENDA_REF CLC_ORDEM_REF, IM.ITEM CLC_ORDEM_ITEM, " & vbCrLf & _
                    "CIEX.CONFIRM_VENDA_REF CIEX_ORDEM_REF, CIEX.ITEM CIEX_ORDEM_ITEM FROM " & vbCrLf & _
                    "IM.vw_col_rastrea_ovi VW, IM.ORDEM_VENDA_ITEM IM, CIEX.CONFIRM_VENDA_ITEM CIEX" & vbCrLf & _
                    "WHERE vw.ov_ref = im.ordem_venda_ref (+) and" & vbCrLf & _
                    "vw.ov_item = im.item (+) and" & vbCrLf & _
                    "nvl(im.ciex_ordem_ref,im.ordem_venda_ref) = CIEX.CONFIRM_VENDA_REF (+) AND" & vbCrLf & _
                    "nvl(IM.CIEX_ITEM,IM.ITEM) = CIEX.ITEM (+) AND" & vbCrLf & _
                    "NOT CIEX.CONFIRM_VENDA_REF IS NULL" & vbCrLf & _
                    ") " & vbCrLf & _
                    "WHERE CLC_PROD || ';' || CLC_ESPEC || ';' || CIEX_PROD || ';' || CIEX_ESPEC = '" & grdPrinc.Text & "'" & vbCrLf & _
                    "GROUP BY CLC_ORDEM_REF, CLC_ORDEM_ITEM, CIEX_ORDEM_REF, CIEX_ORDEM_ITEM" & vbCrLf & _
                    "ORDER BY CLC_ORDEM_REF, CLC_ORDEM_ITEM"

                    grdEtiq.SQL = SQL
                    grdEtiq.StrConn = Login.Strconn
                    grdEtiq.Usuario = Login.Usuario!usuario
                    grdEtiq.ColunaNomes = "Ordem de Venda do CLC;Item da ordem no CLC;Ordem de Venda do CIEX;Item da ordem no CIEX"
                    grdEtiq.Totaliza = "COUNT;"
                    grdEtiq.Bind()
                    grdEtiq.Grid.ReadOnly = True
                    grpSub.Text = "Cliente / Moeda / Incoterm"

                Case 8
                    pnlBotoes.Visible = True
                    btnVisualiza.Text = "Gravar Alterações"
                    SQL = "SELECT DISTINCT * FROM (SELECT REF, CLIENTE_COD, INCOTERM_VENDA, MOEDA_COD FROM IM.ORDEM_VENDA) WHERE REF = '" & grdPrinc.Grid.SelectedCells(0).Value & "'"
                    grdEtiq.SQL = SQL
                    grdEtiq.StrConn = Login.Strconn
                    grdEtiq.Usuario = Login.Usuario!usuario
                    grdEtiq.ColunaNomes = "Ordem de Venda;CLiente;Termo internacional de venda;Moeda"
                    grdEtiq.Bind()
                    grpSub.Text = "Pedidos/Itens"

                Case 11
                    pnlBotoes.Visible = True
                    btnVisualiza.Text = "Gravar Alterações"
                    SQL = "SELECT PRODUTO_COD, DIMENSAO_POL, DIMENSAO_MM, DIMENSAO_OU, QUALIDADE, NCM, PERC_II, PERC_IPI, PERC_PIS, PERC_COFINS, LI, SI, DC, PESO_TEORICO_PECA FROM IM.PROD_ESPEC WHERE PRODUTO_COD = '" & grdPrinc.Grid.SelectedCells(2).Value & "'" & " AND SEQ = '" & grdPrinc.Grid.SelectedCells(5).Value & "'" & " ORDER BY 1,2,3,4"
                    grdEtiq.SQL = SQL
                    grdEtiq.StrConn = Login.Strconn
                    grdEtiq.Usuario = Login.Usuario!usuario
                    grdEtiq.ColunaNomes = "Produto;Dim. Polegadas;Dim. Milímetros;Dim. Outras;Qualidade;NCM;% II;% IPI;% PIS;% COFINS;LI;ST;DC;Peso Teórico da Peça"
                    grdEtiq.Bind()
                    grpSub.Text = "Ordens de Venda sem IPI"
            End Select

        Catch
        End Try
        pnlBaixo.Visible = SQL <> ""
    End Sub

    Private Sub txtBusca_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAtualizar_Click(sender, Nothing)
        End If
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        If Not grdEtiq.Grid.Columns.Contains("RESULTADO") Then
            grdEtiq.Grid.Columns.Add("RESULTADO", "Resultado")
        End If
        Dim OPC As Integer = Val(TXTCONSULTA.Text)

        Select Case OPC
            Case 8
                Try
                    DSGrava("UPDATE IM.ORDEM_VENDA SET CLIENTE_COD = :CLIENTE_COD, INCOTERM_VENDA = :INCOTERM_VENDA, MOEDA_COD = :MOEDA_COD WHERE REF=:REF", Login.Strconn, ":CLIENTE_COD", grdEtiq.Grid.CurrentRow.Cells(1).Value, ":INCOTERM_VENDA", grdEtiq.Grid.CurrentRow.Cells(2).Value, ":MOEDA_COD", grdEtiq.Grid.CurrentRow.Cells(3).Value, ":REF", grdEtiq.Grid.CurrentRow.Cells(0).Value)
                    grdEtiq.Grid.CurrentRow.Cells(6).Value = "Atualização efetuada com sucesso."
                Catch ex As Exception
                    grdEtiq.Grid.CurrentRow.Cells(6).Value = ex
                End Try
            Case 11
                Try
                    DSGrava("UPDATE IM.PROD_ESPEC SET PERC_II = :II, PERC_IPI = :IPI, PERC_PIS = :PIS, PERC_COFINS = :COFINS, LI = :LI, SI = :SI, DC = :DC, PESO_TEORICO_PECA = :PESO WHERE PRODUTO_COD=:COD AND SEQ=:SEQ", Login.Strconn, ":II", grdEtiq.Grid.CurrentRow.Cells(6).Value, ":IPI", grdEtiq.Grid.CurrentRow.Cells(7).Value, ":PIS", grdEtiq.Grid.CurrentRow.Cells(8).Value, ":COFINS", grdEtiq.Grid.CurrentRow.Cells(9).Value, ":LI", grdEtiq.Grid.CurrentRow.Cells(10).Value, ":SI", grdEtiq.Grid.CurrentRow.Cells(11).Value, ":DC", grdEtiq.Grid.CurrentRow.Cells(12).Value, ":PESO", grdEtiq.Grid.CurrentRow.Cells(13).Value, ":COD", grdPrinc.Grid.CurrentRow.Cells(2).Value, ":SEQ", grdPrinc.Grid.CurrentRow.Cells(5).Value)
                    MsgBox("Registros atualizados com sucesso!")
                    btnAtualizar_Click(Nothing, Nothing)
                Catch ex As Exception
                    grdEtiq.Grid.CurrentRow.Cells(11).Value = ex
                End Try
        End Select

    End Sub
End Class