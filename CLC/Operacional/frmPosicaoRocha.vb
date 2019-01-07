Public Class frmPosicaoRocha

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try

            Dim Sql = "SELECT * FROM (SELECT NF.CIA_COD EMISSOR, NFI.PROD_CFOP, NF.IDE_NATOP," & vbCrLf & _
    "" & vbCrLf & _
    "NFI.PROD_XPED ORDEM_VENDA, EMIT_XNOME, " & vbCrLf & _
    "NF.DEST_XNOME CLIENTE, NF.DEST_CNPJ," & vbCrLf & _
    "NF.ENDERDEST_DEST_UF UF," & vbCrLf & _
    "NF.INFNFE_IDE_SERIE," & vbCrLf & _
    "NF.INFNFE_IDE_NNF NUMERO_NOTA," & vbCrLf & _
    "NF.IDE_DEMI," & vbCrLf & _
    "NFI.PROD_CFOP CFOP," & vbCrLf & _
    "NFI.PROD_NCM NCM," & vbCrLf & _
    "TRIM(PROD_XPROD) PRODUTO," & vbCrLf & _
    "TRUNC(NFI.PROD_QCOM, 3) QUANTIDADE," & vbCrLf & _
    "PROD_VPROD VALOR," & vbCrLf & _
    "NFI.IPITRIB_IPI_VIPI IPI," & vbCrLf & _
    "PROD_VPROD + NVL(IPITRIB_IPI_VIPI,0) + NVL(ICMS10_ICMS_VICMSST, 0) TOTAL_NOTA, " & vbCrLf & _
    "DECODE(NF.RETCANCNFE_INFCANC_XMOTIVO,NULL,NF.PROTNFE_XMOTIVO,NF.RETCANCNFE_INFCANC_XMOTIVO) STATUS_NOTA, NF.INFADIC_INFCPL, " & vbCrLf & _
    "NF.IDE_TPNF TIPO" & vbCrLf & _
    "FROM " & Apl.Esquema & ".NF," & vbCrLf & _
    "" & Apl.Esquema & ".NF_ITEM NFI" & vbCrLf & _
    "WHERE(NF.CIA_COD = NFI.NF_CIA_COD)" & vbCrLf & _
    "AND NF.INFNFE_IDE_SERIE = NFI.INFNFE_IDE_SERIE" & vbCrLf & _
    "AND NF.INFNFE_IDE_NNF   = NFI.INFNFE_IDE_NNF " & vbCrLf & _
    IIf(chkSemCancel.Checked, " AND NOT DECODE(NF.RETCANCNFE_INFCANC_XMOTIVO,NULL,NF.PROTNFE_XMOTIVO,NF.RETCANCNFE_INFCANC_XMOTIVO) = 'Cancelamento de NF-e homologado'", "") & vbCrLf & _
    ")" & vbCrLf & _
    ""

            If txtTipo.Text = "" Then
                txtTipo.Text = txtTipo.Items(0)
            End If

            Dim TIPO As Integer = Val(txtTipo.Text)
            Select Case TIPO
                Case 1
                    Sql = "SELECT * FROM (" & Sql & ") WHERE (DEST_CNPJ = '07057278000144' OR DEST_CNPJ = '81716144000493') AND IDE_NATOP LIKE 'REMESSA%'"
                Case 2
                    Sql = "SELECT * FROM (" & Sql & ") WHERE INFADIC_INFCPL LIKE '%ROCHA%' AND NOT (  (DEST_CNPJ = '07057278000144' OR DEST_CNPJ = '81716144000493') AND IDE_NATOP LIKE 'REMESSA%')"
            End Select

            If CTLDE.Text <> "" AndAlso CTLDE.Text <> "  /  /" Then
                Sql &= " AND IDE_DEMI >= TO_DATE('" & CTLDE.Text & "','DD/MM/YYYY')"
            End If

            If CTLATE.Text <> "" AndAlso CTLATE.Text <> "  /  /" Then
                Sql &= " AND IDE_DEMI <= TO_DATE('" & CTLATE.Text & "', 'DD/MM/YYYY')"
            End If

            With grdPrinc
                .TamanhosPx = "73;87;232;100;161;290;122;49;112;100;86;48;78;206;100;97;99;100;170;1460;100;50;100"
                .SQL = Sql
                .StrConn = Login.Strconn
                .Usuario = Login.Usuario!USUARIO
                .ColunaNomes = "Emissor;CFOP do Produto;Natureza da operação;Ordem de venda;Nome do emissor;Cliente;CNPJ do destinatário;UF;Série da nota;Número da nota;Data da emissão;CFOP;NCM;Produto;Quantidade;Valor;IPI;Total da nota;Status da nota;Informações adicionais;Tipo"
                .SomenteLeitura = True

                .Bind()
            End With
            

        Catch EX As Exception
            MsgBox(EX.Message & " na consulta")
        End Try
    End Sub

    Private Sub frmPosicaoRocha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTipo.Text = txtTipo.Items(0)
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "CTL")
    End Sub
End Class