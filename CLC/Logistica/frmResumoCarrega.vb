Public Class frmResumoCarrega

    Private Sub frmDimensoesPecas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT DISTINCT NVL(CARREGA_ATA,CARREGA_ETA) XTA, VIAGEM_REF, ORDEM_VENDA_REF, ORDEM_VENDA_ITEM, PRODUTO_COD, ENTREGA_NOME, CTRC_NUM, VALOR, VEICULO_COD, TRANSPORTADOR_COD, CARREGA_LOCAL FROM IM.VW_COL_INSTRUCAO"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Data de Carregamento;Viagem;Ordem;Item;Produto;Entrega;CTRC;Frete;Veículo;Transportadora;Ponto de Coleta"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("Recurso Indisponível!", MsgBoxStyle.Information)
    End Sub
End Class