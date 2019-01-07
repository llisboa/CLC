Public Class frmVolumesPedido

    Private Sub frmVolumesPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim SQL As String = "SELECT re.etiq_status_cod," & vbCrLf & _
            "  RE.PED_REF," & vbCrLf & _
            "  RE.PED_ITEM," & vbCrLf & _
            "  RE.PRODUTO_COD," & vbCrLf & _
            "  RE.ESPEC," & vbCrLf & _
            "  COUNT(RE.ETIQUETA) AS QTD," & vbCrLf & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_LIQ, RE.PESO_TEORICO)) LIQUIDO, " & vbCrLf & _
            " SUM(NVL(RE.PESO_" & TipoPeso & "_BRUTO, RE.PESO_TEORICO)) BRUTO " & vbCrLf & _
            " FROM (" & EstoqueF.SQL & ") RE" & vbCrLf & _
            " where not RE.ARMAZEM_PRACA is null" & vbCrLf & _
            " AND " & Local.InSQL(chkStatus.Text) & vbCrLf & _
            " GROUP BY re.etiq_status_cod," & vbCrLf & _
            "  RE.PED_REF," & vbCrLf & _
            "  RE.PED_ITEM," & vbCrLf & _
            "  RE.PRODUTO_COD," & vbCrLf & _
            "  RE.ESPEC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Pedido;Item;Produto;Especificações;Quantidade;Peso Líquido;Peso Bruto"
            grdPrinc.Totaliza = "COUNT;;;;;SUM;SUM;SUM;"
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