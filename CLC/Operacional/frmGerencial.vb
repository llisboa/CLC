Public Class frmGerencial

    Private Sub frmGerencial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim Resp As String = ""
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
            Dim SQL As String = "SELECT NF.CIA_COD EMISSOR," & vbCrLf & _
            "NFI.PROD_XPED ORDEM_VENDA," & vbCrLf & _
            "NF.DEST_XNOME CLIENTE," & vbCrLf & _
            "NF.ENDERDEST_DEST_UF UF," & vbCrLf & _
            "NF.INFNFE_IDE_NNF NUMERO_NOTA," & vbCrLf & _
            "NF.IDE_DEMI DATA_EMISSAO," & vbCrLf & _
            "NFI.PROD_CFOP CFOP," & vbCrLf & _
            "NFI.PROD_NCM NCM," & vbCrLf & _
            "LPAD(PROD_XPROD,30) PRODUTO," & vbCrLf & _
            "NF.IDE_NATOP NATUREZA_OPERACAO," & vbCrLf & _
            "TRUNC(NFI.PROD_QCOM, 3) QUANTIDADE," & vbCrLf & _
            "PROD_VPROD VALOR," & vbCrLf & _
            "NFI.IPITRIB_IPI_VIPI IPI," & vbCrLf & _
            "PROD_VPROD + NVL(IPITRIB_IPI_VIPI,0) + NVL(ICMS10_ICMS_VICMSST, 0) TOTAL_NOTA," & vbCrLf & _
            "NF.IDE_TPNF TIPO," & vbCrLf & _
            "DECODE(NF.RETCANCNFE_INFCANC_XMOTIVO,NULL,NF.PROTNFE_XMOTIVO,NF.RETCANCNFE_INFCANC_XMOTIVO) STATUS_NOTA" & vbCrLf & _
            "FROM " & Apl.Esquema & ".NF," & vbCrLf & _
            "" & Apl.Esquema & ".NF_ITEM NFI" & vbCrLf & _
            "WHERE NF.CIA_COD          = NFI.NF_CIA_COD" & vbCrLf & _
            "AND NF.INFNFE_IDE_SERIE = NFI.INFNFE_IDE_SERIE" & vbCrLf & _
            "AND NF.INFNFE_IDE_NNF   = NFI.INFNFE_IDE_NNF"
            If txtCFOP.Text = "" Then
                SQL &= " AND (NFI.PROD_CFOP LIKE '%" & CFOP & "%')"
            Else
                SQL &= " AND (NFI.PROD_CFOP = " & CFOP & ")"
            End If

            If CANC <> "" Then
                SQL &= " AND NF.RETCANCNFE_INFCANC_XMOTIVO IS " & CANC & ""
            End If

            If txtEmissor.Text <> "" Then
                SQL &= " AND NF.CIA_COD = '" & txtEmissor.Text & "'"
            End If
            If CTLDE.Text <> "  /  /" And CTLATE.Text <> "  /  /" Then
                SQL = "SELECT * FROM (" & SQL & ") WHERE DATA_EMISSAO BETWEEN '" & CTLDE.Text & "' AND '" & CTLATE.Text & "'"
            End If

            If txtTipo.Text <> "" Then
                If SQL.Contains("SELECT * FROM") Then
                    SQL &= " AND TIPO = " & txtTipo.Text
                Else
                    SQL = "SELECT * FROM (" & SQL & ") WHERE TIPO = " & txtTipo.Text
                End If
            End If
            SQL &= " ORDER BY 1,5,6"
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Emitente;Ordem de Venda;Cliente;UF;Número;Data de Emissão;CFOP;NCM;Produto;Natureza da Operação;Quantidade;Valor;IPI;Total da Nota;Tipo de Nota;Status da Nota"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

End Class