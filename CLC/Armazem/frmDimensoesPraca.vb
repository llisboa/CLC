Public Class frmDimensoesPraca

    Private Sub frmDimensoesPraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim TipoPeso As String = ""
            If Val(CBBPESO.Text) = 1 Then
                TipoPeso = "GERENCIA"
            Else
                TipoPeso = "INTERPRET"
            End If
            Dim SQL As String = "SELECT RE.ETIQ_STATUS_COD," & _
            " AP.ARMAZEM_CIA_COD," & _
            " AP.ARMAZEM_NUM, " & _
            " AP.PRACA, " & _
            " RE.PRODUTO_COD, " & _
            " RE.ESPEC, " & _
            " COUNT(RE.ETIQUETA) AS QTD, " & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_LIQ, RE.PESO_TEORICO)) LIQUIDO, " & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_BRUTO, RE.PESO_TEORICO)) BRUTO " & _
            " FROM IM.ARMAZEM_PRACA AP, " & _
            " (SELECT * FROM IM.VW_COL_RASTREA_ETIQ) RE " & _
            " WHERE(AP.ARMAZEM_CIA_COD = RE.ARMAZEM_CIA_COD)" & _
            " AND AP.ARMAZEM_NUM        = RE.ARMAZEM_NUM" & _
            " AND AP.PRACA              = RE.ARMAZEM_PRACA" & _
            " AND NOT RE.ARMAZEM_PRACA IS NULL " & _
            " AND " & Local.InSQL(chkStatus.Text) & _
            " GROUP BY RE.ETIQ_STATUS_COD, AP.ARMAZEM_CIA_COD, AP.ARMAZEM_NUM, AP.PRACA, RE.PRODUTO_COD, RE.ESPEC, PESO_GERENCIA_LIQ, PESO_GERENCIA_BRUTO" & _
            " ORDER BY 1,2,3,4,5"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Armazém;Número;Praça;Produto;Esepecificações;Quantidade;Peso Líquido;Peso Bruto"
            grdPrinc.Totaliza = "COUNT;;;;;;SUM;SUM;SUM;"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Recurso Indisponível!", MsgBoxStyle.Information)
    End Sub

    Private Sub CBBPESO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBBPESO.SelectedIndexChanged
        Atualizar()
    End Sub
End Class