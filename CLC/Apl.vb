Public Class Apl
    Public Const Esquema As String = "IM"

    Public Shared Function ReportPorNome(ByVal Nome As String) As Object
        Select Case UCase(Nome)
            Case "RPTLISTACIA"
                Return New RptListaCIA
            Case "RPTBOLETORELITAU"
                Return New BoletoRelItau
            Case "RPTETIQUETA"
                Return New RptEtiqueta
            Case "RPTETIQUETASEMPESO"
                Return New RptEtiquetaSemPeso
            Case "RPTPEDDET"
                Return New RptPedDet
            Case "RPTDANFELAND"
                Return New RptDanfeLand
            Case "RPTORDEMVENDA"
                Return New RptOrdemVenda
            Case "RPTEMBALAGEM"
                Return New RptEmbalagem
            Case "RPTPRODESPEC"
                Return New RptProdEspec
            Case "RPTPRODUTO"
                Return New RptProduto
            Case "RPTSTATUSESTOQUE"
                Return New RptStatusEstoque
            Case "RPTVENDEDOR"
                Return New RptVendedor
            Case "RPTLISTADEPARTAM"
                Return New RptListaDepartam
            Case "RPTNFPORORDEMVENDA"
                Return New RptNFPorOV
            Case "RPTVIAGEMPORPEDIDO"
                Return New RptViagemPorPedido
            Case "RPTGERENCIAL"
                Return New RptGerencial
            Case "RPTGERENCIALAGRUPADO"
                Return New RptGerencialAgrupado
            Case "RPTNFSEMITEM"
                Return New RptNFSemItem
            Case "RPTPEDITEMEPROD"
                Return New RptPedItemeProd
            Case "RPTPEDITEMEPRODOBS"
                Return New RptPedItemeProdObs
            Case "RPTRELDENF"
                Return New RptReldeNF
            Case "RPTETQPORQUALID"
                Return New RptEtiqQualidade
            Case "RPTESTOQUEFISICO"
                Return New RptEstoqueFisico
            Case "RPTETIQPEDITEM"
                Return New RptEtiqPedItem
            Case "RPTETIQPRACA"
                Return New RptEtiqPraca
            Case "RPTVIAGEMFECH"
                Return New RptViagemFech
            Case "RPTCONFIRMCARREGAM"
                Return New RptConfirmCarregamento
            Case "RPTRESUMOCARREGAM"
                Return New RptResumoCarregam
            Case "RPTPEDGAL"
                Return New RptPedGal
            Case "RPTTOTSTATUS"
                Return New RptTotStatus
            Case "RPTDIMPRACA"
                Return New RptDimPraca
            Case "RPTPESOREAL"
                Return New RptPesoReal
            Case "RPTCHECKPACKINGLIST"
                Return New RptCheckPackingList
            Case "RPTRECLAMA"
                Return New RptReclama
            Case "RPTGERENCIALENTRADA"
                Return New RptGerencialEntrada
            Case "RPTETIQPED"
                Return New RptEtiqPed
        End Select
        Return Nothing
    End Function

End Class
