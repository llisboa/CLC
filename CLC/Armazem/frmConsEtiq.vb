Public Class frmConsEtiq

    Private Sub frmConsEtiq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Function InSQL(ByVal Status As String)
        Dim InStatus As String = ""
        If Status.Contains(";") Then
            Dim AR() As String = Split(Status, ";")
            For I As Integer = 0 To AR.Length - 1
                InStatus &= "'" & AR(I) & "'"
            Next
            InStatus = InStatus.Replace("''", "' , '")
        Else
            InStatus = "'" & Status & "'"
        End If
        Return InStatus
    End Function

    Sub Atualizar()
        Try
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.SQL = "SELECT E.ETIQUETA, E.PED_REF, E.PED_ITEM, VW.PRODUTO_COD, VW.DIMENSAO_POL, VW.DIMENSAO_MM, VW.DIMENSAO_OU, VW.QUALIDADE, E.ETIQ_FORN, E.REF_CLIENTE, E.NR_CORRIDA, E.VOLUME_PECAS_QTD, E.ICMS_REAL_IMP, E.IPI_REAL_IMP, E.PIS_REAL_DI, E.CONFINS_REAL_DI, E.CUSTO_REAL, E.PRECO_MIN_REAL_MT, E.PRECO_MIN_USD_MT, E.ORDEM_VENDA_REF, E.ORDEM_VENDA_ITEM, VW.VIAGEM_REF, NVL(VW.PESO_TEORICO, CASE WHEN NVL(VW.VOLUME_PECAS_QTD,0)=0 OR NVL(PE.PESO_TEORICO_PECA,0)  =0 THEN NULL ELSE VW.PESO_TEORICO_CALC END) PESO_TEORICO, E.PESO_LIQUIDO, E.PESO_BRUTO, E.PESO_BALANCA_LIQ, E.PESO_BALANCA_BRUTO, E.FILA_IMP, E.DATA_SOLICITA_IMP, E.DATA_EMISSAO, E.NOTA, E.AVARIA, E.ETIQ_ANTERIOR, E.ARMAZEM_CIA_COD, E.ARM_NUM, E.ARM_PRACA, E.ARM_LINHA, E.ARM_COLUNA, E.MOMENTO_REG, E.OPERADOR, E.STATUS_COD, E.OBS, E.IMPORTADOR, E.IMP_NF_SERIE, E.IMP_NF_NNF, E.IMP_NF_DATA, E.TEU_NR FROM (" & EstoqueF.SQL & ") VW, IM.ETIQUETA E, IM.PED_ITEM PI, IM.PROD_ESPEC PE WHERE VW.ETIQUETA = E.ETIQUETA AND E.PED_REF = PI.PED_REF AND E.PED_ITEM = PI.ITEM AND PI.ESPEC_SEQ = PE.SEQ AND PI.PRODUTO_COD = PE.PRODUTO_COD AND ETIQ_STATUS_COD IN (" & InSQL(chkStatus.Text) & ")"
            grdPrinc.ColunaNomes = "Etiqueta;Pedido;Item;Produto;Polegas;Milímetros;Outras;Qualidade;Etiqueta do Fornecedor;Referência do Cliente;Corrida;Peças por Volume;ICMS;IPI;PIS;Confins;Custo Real;Preço Mínimo R$;Preço Mínimo USD;Ordem de Venda;Item da Ordem de Venda;Viagem;Peso Teórico;Peso Liquido;Peso Bruto;Peso Líquido na Balança;Peso Bruto na Balança;Fila de Impressão;Solicitação da Impressão;Emissão;Nota;Avaria;Etiqueta Anterior;Armazém;Número;Praça;Linha;Coluna;Momento do Registro;Operador;Status;Observações;Importador;NF Série;NF Número;NF Data;Container"
            grdPrinc.EsquemaGerador = Apl.Esquema
            grdPrinc.EsquemaPrinc = Apl.Esquema
            grdPrinc.Sistema = Apl.Esquema
            grdPrinc.Totaliza = "COUNT;;;;;;;;;;;SUM;SUM;SUM;SUM;SUM;SUM;SUM;SUM;;;;SUM;SUM;SUM;SUM;SUM;"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("Recurso Indisponível!", MsgBoxStyle.Information)
    End Sub
End Class