Public Class frmPedidoViagem

    Private Sub frmGerencialAgrupado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "CTL")
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Usuario = Login.Usuario!usuario
        Dim ArPEDIDO() As String = Split(txtPEDIDO.Text, ";")
        Dim PEDIDO As String = ""
        For z As Integer = 0 To ArPEDIDO.Length - 1
            If z = ArPEDIDO.Length - 1 Then
                PEDIDO &= ArPEDIDO(z)
            Else
                PEDIDO &= ArPEDIDO(z) & "|"
            End If
        Next
        PEDIDO = PEDIDO.Replace("|", " OR NFI.PROD_CFOP = ")
        Try
            Dim SQL As String = "SELECT VW.PED_REF PEDIDO," & vbCrLf & _
            "  VW.NAVIO NAVIO," & vbCrLf & _
            "  VW.VIAGEM_REF_PED VIAGEM," & vbCrLf & _
            "  P.GRUPO GRUPO," & vbCrLf & _
            "  COUNT(VW.ETIQUETA) QTD," & vbCrLf & _
            "  SUM(VW.PESO_GERENCIA_LIQ) PESO" & vbCrLf & _
            "FROM IM.VW_COL_RASTREA_ETIQ VW," & vbCrLf & _
            "    IM.PRODUTO P" & vbCrLf & _
            "WHERE VW.FPRODUTO = P.COD" & vbCrLf & _
            "AND VW.ETIQ_STATUS_COD IN ('DISPONÍVEL','AVARIADO','DEVOLVIDO/AVARIADO','FRACIONADO')" & vbCrLf & _
            "GROUP BY VW.PED_REF," & vbCrLf & _
            "  VW.NAVIO," & vbCrLf & _
            "  VW.VIAGEM_REF_PED," & vbCrLf & _
            "  P.GRUPO" & vbCrLf & _
            " ORDER BY 1"
            If PEDIDO <> "" Then
                SQL = "SELECT * FROM(" & SQL & ") WHERE PEDIDO = '" & PEDIDO & "'"
            End If

            If CTLDE.Text <> "  /  /" And CTLATE.Text <> "  /  /" Then
                SQL = "SELECT PEDIDO, NAVIO, VIAGEM, GRUPO, QTD, PESO FROM (" & SQL & ") C1, IM.PED WHERE C1.PEDIDO = PED.REF(+) AND PED.DATA_PED BETWEEN '" & CTLDE.Text & "' AND '" & CTLATE.Text & "'"
            End If
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Pedido;Navio;Viagem;Grupo;Qtd;Peso"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

End Class