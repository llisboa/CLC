Public Class frmEtiqsNaoEncontradas

    Private Sub frmEtiqsNaoEncontradas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT ARMAZEM_CIA_COD, ARMAZEM_NUM,  ARMAZEM_PRACA,  ETIQUETA, PED_REF,  PED_ITEM, PRODUTO_COD,  ESPEC FROM (" & EstoqueF.SQL & ") WHERE ETIQ_STATUS_COD = 'CONFERIR' AND NOT PRODUTO_COD LIKE 'PCS%' ORDER BY ARMAZEM_NUM,  ARMAZEM_PRACA"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Armazém;Número;Praça;Etiqueta;Pedido;Item;Produto;Especificações"
            grdPrinc.Totaliza = "COUNT;"
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
        Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA = '" & grdPrinc.Grid.SelectedCells(0).Value & "' ")
    End Sub
End Class