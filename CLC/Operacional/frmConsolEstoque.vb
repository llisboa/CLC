Public Class frmConsolEstoque

    Private Sub frmEtiqsPraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Usuario = Login.Usuario!usuario
        Try
            Dim SQL As String = "SELECT COL.*, CASE " & vbCrLf & _
            "WHEN TIPO='PEDIDO' THEN '1-PEDIDO' " & vbCrLf & _
            "WHEN TIPO='ENTRADA' THEN '2-ENTRADA'" & vbCrLf & _
            "WHEN TIPO='REAL' THEN '3-REAL'" & vbCrLf & _
            "WHEN TIPO='SAÍDA' THEN '4-SAÍDA'" & vbCrLf & _
            "WHEN TIPO='NEGOCIADO' THEN '5-NEGOCIADO'" & vbCrLf & _
            "WHEN TIPO='RESERVADO' THEN '6-RESERVADO'" & vbCrLf & _
            "END TIPO_DESCR FROM IM.VW_COL_CONSOLIDA COL"
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Tipo;Data;Qtd Vol;Peso Líquido;Peso Bruto;Nominal Ped Unid;Pedido;Item;Ordem de Venda;Item da OV;Código;Produto;SEQ;Status;Localizador;Descrição;"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

End Class