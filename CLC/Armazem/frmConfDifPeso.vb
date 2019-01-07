Public Class frmConfDifPeso

    Private Sub frmConfDifPeso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Function PESODIF() As String
        'NVL(COL.PESO_TEORICO,0)-NVL(E.PESO_LIQUIDO,0) DIFERENCA
        If txtPeso.Text Like "01-*" Then
            Return "COL.PESO_TEORICO_CALC-E.PESO_TEORICO"
        ElseIf txtPeso.Text Like "02-*" Then
            Return "COL.PESO_TEORICO_CALC-E.PESO_LIQUIDO"
        ElseIf txtPeso.Text Like "03-*" Then
            Return "COL.PESO_TEORICO_CALC-E.PESO_BALANCA_LIQ"
        Else
            Return "[selecione tipo]"
        End If
    End Function

    Sub Atualizar()
        Try
            grdPrinc.SQL = "select E.ETIQUETA, PI.PRODUTO_COD, COL.ESPEC,  E.PESO_TEORICO TEORICO_ETIQUETA, COL.PESO_TEORICO_CALC TEORICO_CALC, E.VOLUME_PECAS_QTD, E.PESO_LIQUIDO, E.PESO_BRUTO, " & PESODIF() & " DIF, E.PESO_BALANCA_LIQ, E.PESO_BALANCA_BRUTO from IM.ETIQUETA E, (" & EstoqueF.SQL & ") COL, IM.PED_ITEM PI, IM.PROD_ESPEC PE" & vbCrLf & _
            "where" & vbCrLf & _
            "E.ETIQUETA = COL.ETIQUETA and" & vbCrLf & _
            "E.PED_REF = PI.PED_REF (+) and" & vbCrLf & _
            "E.PED_ITEM = PI.ITEM (+) and" & vbCrLf & _
            "PI.PRODUTO_COD = PE.PRODUTO_COD (+) and" & vbCrLf & _
            "PI.ESPEC_SEQ = PE.SEQ (+) and" & vbCrLf & _
            "E.STATUS_COD = 'DISPONÍVEL'" & vbCrLf
            grdPrinc.ColunaNomes = "Etiqueta;Produto;Especificação;Teórico na Etiq;Teórico Calculado;Qtd Peças;Liq BL;Brt BL;Diferença;Liq Balança;Brt Balança"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.Totaliza = "COUNT;;;SUM;SUM;SUM;SUM;SUM;"
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