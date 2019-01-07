Public Class frmOrdemItemSaldo

    Private Sub frmEtiqsPraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = "SELECT OV_REF, OV_ITEM, PRODUTO_COD, EMBALAGEM, ESPEC, NOMINAL_PED_UNID, PED_UNID, VOLUME_PECAS_QTD, OBS, SALDO, CLIENTE_COD, VENDEDOR_COD, STATUS_COD FROM IM.VW_COL_RASTREA_OVI"
            grdPrinc.ColunaNomes = "Ordem;Item;Produto;Embalagem;Especificação;Nominal;Unidade;Qtd Peças Requerida;Observações;Saldo;Cliente;Vendedor;Status"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

End Class