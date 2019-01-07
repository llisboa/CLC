Public Class frmEstoqueAgrupado

    Private Sub EstoqueAgrupado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "CTL")
        CarregaProd()
        Atualizar()
    End Sub

    Sub CarregaProd()
        Icraft.IcftBase.CarregaCombo(cbxProd, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT PRODUTO FROM (" & SQL & ") GROUP BY PRODUTO", Login.Strconn))
    End Sub

    Sub CarregaDim()
        Icraft.IcftBase.CarregaCombo(cbxDim, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT ""DIMENSAO | QUALIDADE"" FROM (" & SQL & ") WHERE PRODUTO = '" & cbxProd.SelectedItem.ToString & "'", Login.Strconn))
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub
    Dim SQL As String = "SELECT PRODUTO_COD PRODUTO, ESPEC ""DIMENSAO | QUALIDADE"", COUNT(ETIQUETA) VOLUMES, SUM(PESO_GERENCIA_LIQ) PESO FROM IM.VW_COL_RASTREA_ETIQ WHERE ETIQ_STATUS_COD IN ('DISPONÍVEL','AVARIADO','FRACIONADO') GROUP BY PRODUTO_COD, ESPEC"
    Sub Atualizar()
        Try
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            If cbxProd.Text <> "" AndAlso cbxDim.Text <> "" Then
                SQL = "SELECT * FROM (" & SQL & ") WHERE PRODUTO = '" & cbxProd.Text & "' AND ""DIMENSAO | QUALIDADE"" = '" & cbxDim.Text & "'"
            Else
                SQL = "SELECT PRODUTO_COD PRODUTO, ESPEC ""DIMENSAO | QUALIDADE"", COUNT(ETIQUETA) VOLUMES, SUM(PESO_GERENCIA_LIQ) PESO FROM IM.VW_COL_RASTREA_ETIQ WHERE ETIQ_STATUS_COD IN ('DISPONÍVEL','AVARIADO','FRACIONADO') GROUP BY PRODUTO_COD, ESPEC"
            End If
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Produto;Especificação;Qtd Volumes;Peso"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub cbxProd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProd.SelectedIndexChanged
        CarregaDim()
    End Sub

    Private Sub cbxDim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDim.SelectedIndexChanged
        Atualizar()
    End Sub

End Class