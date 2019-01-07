Public Class frmPesoPecaEspec

    Private Sub frmPesoPecaEspec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT VW.PRODUTO_COD," & _
            "VW.ESPEC," & _
            "PE.PESO_TEORICO_PECA " & _
            "FROM (" & EstoqueF.SQL & ") VW," & _
            "IM.ETIQUETA ETIQ, " & _
            "IM.PED_ITEM   PI," & _
            "IM.PROD_ESPEC PE " & _
            "WHERE VW.ETIQUETA    = ETIQ.ETIQUETA (+)" & _
            "AND ETIQ.PED_ITEM    = PI.ITEM (+)" & _
            "AND ETIQ.PED_REF     = PI.PED_REF (+)" & _
            "AND PI.ESPEC_SEQ     = PE.SEQ (+)" & _
            "AND PI.PRODUTO_COD   = PE.PRODUTO_COD (+)" & _
            "AND (VW.PRODUTO_COD IN ('PEH-PERFIL H', 'PEI-PERFIL I', 'PET-PERFIL T', 'PEU-PERFIL U')" & _
            "OR ( VW.PRODUTO_COD  ='CAN-PERFIL L (CANTONEIRA)'" & _
            "AND (VW.ESPEC LIKE '*11800*'" & _
            "or VW.ESPEC like '*12000*'" & _
            "or VW.ESPEC like '*12M*') ))" & _
            "GROUP BY VW.PRODUTO_COD, VW.ESPEC, PE.PESO_TEORICO_PECA ORDER BY PE.PESO_TEORICO_PECA"

            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Produto;Especificação;Peso Teórico Por Peça"
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
        Local.MostraForm("RPTETIQPED", "PRODUTO_COD = '" & grdPrinc.Grid.SelectedCells(0).Value & "'")
    End Sub
End Class