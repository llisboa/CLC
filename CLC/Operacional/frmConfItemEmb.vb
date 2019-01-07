Public Class frmConfItemEmb

    Private Sub frmConfItemEmb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String = "SELECT VW.OV_REF," & vbCrLf & _
        "VW.OV_ITEM," & vbCrLf & _
        "VW.PRODUTO_COD," & vbCrLf & _
        "VW.ESPEC," & vbCrLf & _
        "NVL(VW.NOMINAL_PED_UNID,0) VENDIDO," & vbCrLf & _
        "NVL(VW.EMB_PED_UNID,0) EMBARCADO," & vbCrLf & _
        "NVL(VW.SALDO,0) SALDO," & vbCrLf & _
        "SUM(NVL(E.PESO_GERENCIA_LIQ,0)) TOTAL_GERENCIAL," & vbCrLf & _
        "SUM(NVL(E.PESO_INTERPRET_LIQ,0)) TOTAL_INTERPRETADO," & vbCrLf & _
        "VW.STATUS_COD" & vbCrLf & _
        "FROM IM.VW_COL_RASTREA_ETIQ E," & vbCrLf & _
        "IM.VW_COL_RASTREA_OVI VW" & vbCrLf & _
        "WHERE VW.OV_REF = E.ORDEM_VENDA_REF (+)" & vbCrLf & _
        "AND VW.OV_ITEM  = E.ORDEM_VENDA_ITEM (+)" & vbCrLf & _
        "AND VW.STATUS_COD IN ('PENDENTE', 'ENTREGUE PARCIALMENTE')" & vbCrLf & _
        "AND NVL(VW.SALDO,0) <> 0" & vbCrLf & _
        "GROUP BY VW.OV_REF," & vbCrLf & _
        "VW.OV_ITEM," & vbCrLf & _
        "VW.PRODUTO_COD," & vbCrLf & _
        "VW.ESPEC," & vbCrLf & _
        "VW.NOMINAL_PED_UNID," & vbCrLf & _
        "VW.EMB_PED_UNID," & vbCrLf & _
        "VW.SALDO," & vbCrLf & _
        "VW.STATUS_COD" & vbCrLf & _
        "ORDER BY 1,2,3"
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Usuario = Login.Usuario!usuario
        grdPrinc.SQL = SQL
        grdPrinc.ColunaNomes = "Ordem de Venda;Item;Produto;Especificações;Qtd Vendida;Qtd Embarcada;Saldo;Total Gerencial;Total Interpretado;Status do Item"
        grdPrinc.Bind()
        grdPrinc.Grid.ReadOnly = True
    End Sub
End Class