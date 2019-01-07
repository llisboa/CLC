Public Class frmVolumesDimensao

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

        If Local.Filtro <> "" Then
            Try
                Dim AR() As String = Local.Filtro.Split(";")
                EstoqueF.ArmazemSQL = "IN ('" & Trim(AR(0)) & "')"
                EstoqueF.PracaSQL = "IN ('" & Trim(AR(1)) & "')"
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
            End Try
        End If
        Try
            Dim TipoPeso As String = ""
            If Val(CBBPESO.Text) = 1 Then
                TipoPeso = "GERENCIA"
            Else
                TipoPeso = "INTERPRET"
            End If
            Dim SQL As String = "SELECT re.etiq_status_cod," & _
            " RE.PRODUTO_COD," & _
            " RE.ESPEC," & _
            " COUNT(RE.ETIQUETA) AS QTD," & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_LIQ, RE.PESO_TEORICO)) LIQUIDO, " & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_BRUTO, RE.PESO_TEORICO)) BRUTO " & _
            " FROM (" & EstoqueF.SQL & ") RE WHERE NOT RE.ARMAZEM_PRACA IS NULL AND" & _
            Local.InSQL(chkStatus.Text) & _
            " GROUP BY re.etiq_status_cod," & _
            " RE.PRODUTO_COD," & _
            " RE.ESPEC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Produto;Especificações;Quantidade;Peso Líquido;Peso Bruto"
            grdPrinc.Totaliza = "COUNT;;;SUM;SUM;SUM;"
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

    Private Sub CBBPESO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBBPESO.SelectedIndexChanged
        Atualizar()
    End Sub
End Class