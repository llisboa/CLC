Public Class frmConfTeorico

    Private Sub frmConfDifPeso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            grdPrinc.SQL = "select ETIQUETA, PRODUTO_COD, ESPEC, PED_REF, VOLUME_PECAS_QTD, PESO_TEORICO, " & vbCrLf & _
            "PESO_TEORICO_CALC, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA from (" & EstoqueF.SQL & ") RE" & vbCrLf & _
            "where RE.ETIQ_STATUS_COD in ('DISPONÍVEL') and" & vbCrLf & _
            "NVL(PESO_TEORICO,-1) <> NVL(PESO_TEORICO_CALC,-1)"
            grdPrinc.ColunaNomes = "Etiqueta;Produto;Especificação;Pedido;Qtd Peças;Teórico na Etiqueta;Teórico Calculado;Estabelecimento;Armazém;Praça"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.Totaliza = "COUNT;;;;SUM;SUM;SUM;"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

End Class