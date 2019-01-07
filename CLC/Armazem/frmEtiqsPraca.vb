Public Class frmEtiqsPraca

    Private Sub frmEtiqsPraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = "SELECT RE.ARMAZEM_CIA_COD, " & vbCrLf & _
                "  RE.ARMAZEM_NUM, " & vbCrLf & _
                "  RE.ARMAZEM_PRACA, " & vbCrLf & _
                "  RE.ETIQ_STATUS_COD, " & vbCrLf & _
                "  RE.ETIQUETA, " & vbCrLf & _
                "  RE.PRODUTO_COD, " & vbCrLf & _
                "  RE.ESPEC, " & vbCrLf & _
                "  RE.VOLUME_PECAS_QTD, " & vbCrLf & _
                "  RE.MARCA, " & vbCrLf & _
                "  RE.COR, " & vbCrLf & _
                "  RE.PED_REF, " & vbCrLf & _
                "  RE.PED_ITEM, " & vbCrLf & _
                "  SUM(NVL(RE.PESO_" & TipoPeso & "_LIQ, RE.PESO_TEORICO)) LIQUIDO, " & _
                "  SUM(NVL(RE.PESO_" & TipoPeso & "_BRUTO, RE.PESO_TEORICO)) BRUTO " & _
                "  FROM (" & EstoqueF.SQL & ") RE " & vbCrLf & _
                " WHERE NOT ARMAZEM_PRACA IS NULL " & vbCrLf & _
                " AND " & Local.InSQL(chkStatus.Text) & vbCrLf & _
                " GROUP BY ARMAZEM_CIA_COD, " & vbCrLf & _
                "  ARMAZEM_NUM, " & vbCrLf & _
                "  ARMAZEM_PRACA, " & vbCrLf & _
                "  ETIQ_STATUS_COD, " & vbCrLf & _
                "  ETIQUETA, " & vbCrLf & _
                "  PRODUTO_COD, " & vbCrLf & _
                "  ESPEC, " & vbCrLf & _
                "  VOLUME_PECAS_QTD, " & vbCrLf & _
                "  MARCA, " & vbCrLf & _
                "  COR, " & vbCrLf & _
                "  PED_REF, " & vbCrLf & _
                "  PED_ITEM "
            grdPrinc.ColunaNomes = "Armazém;Número;Praça;Status;Etiqueta;Produto;Especificações;Peças;Marca;Cor;Pedido;Item;Peso Líquido;Peso Bruto"
            grdPrinc.Totaliza = "COUNT;;;;;;;;;;;;SUM;SUM;"
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
        Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA = '" & grdPrinc.Grid.SelectedCells(0).Value & "'")
    End Sub
End Class