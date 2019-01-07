Public Class frmEntregaCliente

    Private Sub frmDimensoesPecas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub
    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) XTA, CARREGA_NOME, ENTREGA_NOME, PRODUTO_COD, SUM(EMB_PED_UNID) QTD, PED_UNID FROM IM.VW_COL_INSTRUCAO WHERE NOT CARREGA_NOME IS NULL GROUP BY NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)), CARREGA_NOME, ENTREGA_NOME, PRODUTO_COD, PED_UNID ORDER BY XTA DESC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Data de Carregamento;Ponto de Coleta;Entrega;Produto;Quantidade;Unidade"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try

    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        MsgBox("Recurso Indisponível!", MsgBoxStyle.Information)
    End Sub
End Class