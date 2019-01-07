Public Class frmGerencialAgrupado

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
        Dim ArCFOP() As String = Split(txtCFOP.Text, ";")
        Dim CFOP As String = ""
        For z As Integer = 0 To ArCFOP.Length - 1
            If z = ArCFOP.Length - 1 Then
                CFOP &= ArCFOP(z)
            Else
                CFOP &= ArCFOP(z) & "|"
            End If
        Next
        CFOP = CFOP.Replace("|", " OR NFI.PROD_CFOP = ")
        Dim CANC As String = ""
        If chkCanc.Checked = True Then
            CANC = "NOT NULL"
        ElseIf chkNaoCanc.Checked = True Then
            CANC = "NULL"
        End If
        Try
            Dim SQL As String = "SELECT EMITENTE," & vbCrLf & _
            "  NCM," & vbCrLf & _
            "  PRODUTO," & vbCrLf & _
            "  QTD," & vbCrLf & _
            "  VALOR," & vbCrLf & _
            "  IPI," & vbCrLf & _
            "  TOTAL_NOTA" & vbCrLf & _
            "  FROM" & vbCrLf & _
            "  (SELECT NF.CIA_COD EMITENTE," & vbCrLf & _
            "    NFI.PROD_NCM NCM," & vbCrLf & _
            "    LPAD(NFI.PROD_XPROD,30) PRODUTO," & vbCrLf & _
            "    TRUNC(SUM(NFI.PROD_QCOM), 3) QTD," & vbCrLf & _
            "    SUM(NFI.IPITRIB_IPI_VIPI) IPI," & vbCrLf & _
            "    SUM(NFI.PROD_VPROD) VALOR," & vbCrLf & _
            "    SUM(NFI.PROD_VPROD) + SUM(NVL(NFI.IPITRIB_IPI_VIPI,0)) + SUM(NVL(NFI.ICMS10_ICMS_VICMSST, 0)) TOTAL_NOTA" & vbCrLf & _
            "  FROM " & Apl.Esquema & ".NF," & vbCrLf & _
            "   " & Apl.Esquema & ".NF_ITEM NFI" & vbCrLf & _
            "  WHERE NF.INFNFE_IDE_NNF = NFI.INFNFE_IDE_NNF(+)" & vbCrLf & _
            "  AND NF.INFNFE_IDE_SERIE = NFI.INFNFE_IDE_SERIE(+)" & vbCrLf & _
            "  AND NF.CIA_COD          = NFI.NF_CIA_COD(+)" & vbCrLf & _
            "  AND NF.IDE_TPNF         = 1"
            If txtCFOP.Text = "" Then
                SQL &= "AND (NFI.PROD_CFOP LIKE '%" & CFOP & "%')"
            Else
                SQL &= "AND (NFI.PROD_CFOP = " & CFOP & ")"
            End If

            If CANC <> "" Then
                SQL &= " AND NF.RETCANCNFE_INFCANC_XMOTIVO IS " & CANC & ""
            End If

            If CTLDE.Text <> "  /  /" And CTLATE.Text <> "  /  /" Then
                SQL &= " AND NF.IDE_DEMI BETWEEN '" & CTLDE.Text & "' AND '" & CTLATE.Text & "'"
            End If
            SQL &= " GROUP BY NF.CIA_COD, NFI.PROD_NCM, LPAD(NFI.PROD_XPROD, 30) ORDER BY 1,2,3)"
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Emitente;NCM;Produto;Qtd;Valor;IPI;Total da Nota; Data da Emissão"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

End Class