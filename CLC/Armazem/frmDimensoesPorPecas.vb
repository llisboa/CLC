Imports Icraft.IcftBase

Public Class frmDimensoesPorPecas

    Private Sub frmPesoPecaEspec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkStatus.SQL = "SELECT ETIQ_STATUS_COD FROM IM.VW_COL_RASTREA_ETIQ GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "CONFERIR"

        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChanged
        AddHandler grdEtiq.Grid.CellValueChanged, AddressOf Altera
        EstoqueF.StrConn = Login.Strconn
        Atualizar()
    End Sub

    Sub Altera(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If e.ColumnIndex = 5 And NZ(grdEtiq.Grid.Rows(e.RowIndex).Cells(6).Value, ) = 0 Then
                grdEtiq.Grid.Rows(e.RowIndex).Cells(6).Value = grdEtiq.Grid.Rows(e.RowIndex).Cells(5).Value
            End If
        Catch
        End Try
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT re.etiq_status_cod, " & _
        "         RE.PRODUTO_COD, " & _
        "         RE.ESPEC, RE.QUALIDADE, " & _
        "         RE.VOLUME_PECAS_QTD, " & _
        "         COUNT(RE.ETIQUETA) AS QTD, " & _
        "         SUM(RE." & Local.EscolhaParam(CBBPESO, "PESO_GERENCIA_LIQ", "PESO_INTERPRET_LIQ") & ") LIQUIDO, " & _
        "         SUM(RE." & Local.EscolhaParam(CBBPESO, "PESO_GERENCIA_BRUTO", "PESO_INTERPRET_BRUTO") & ") BRUTO " & _
        "         FROM (" & EstoqueF.SQL & ") RE " & _
        "         WHERE NOT RE.ARMAZEM_PRACA IS NULL AND " & _
        "         re." & Local.InSQL(chkStatus.Text) & _
        "         GROUP BY re.etiq_status_cod, " & _
        "         RE.PRODUTO_COD, RE.QUALIDADE, " & _
        "         RE.ESPEC, " & _
        "         RE.VOLUME_PECAS_QTD"

            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Produto;Especificação;Qualidade;Peças por Volume;Qtd Volumes;PesoLíq;PesoBrt"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim SQL As String = ""

        For Each Grd As DataGridViewRow In grdPrinc.Grid.SelectedRows
            Dim z As Integer = Grd.Index

            Dim Params As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(":ETIQ_STATUS_COD", NZ(grdPrinc.Grid.Rows(z).Cells(0).Value, "X"), ":PRODUTO_COD", NZ(grdPrinc.Grid.Rows(z).Cells(1).Value, "X"), ":ESPEC", NZ(grdPrinc.Grid.Rows(z).Cells(2).Value, "X"), ":QUALIDADE", NZ(grdPrinc.Grid.Rows(z).Cells(3).Value, "X"), ":VOLUME_PECAS_QTD", NZ(grdPrinc.Grid.Rows(z).Cells(4).Value, 0))
            Dim SQLTEMP As String = "SELECT ETIQUETA, PESO_TEORICO, PESO_LIQUIDO, PESO_BRUTO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, OBS, TEU_NR, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ORDEM_VENDA_REF, ETIQ_STATUS_COD, infnfe_ide_serie SERIE, infnfe_ide_nnf NF, NAVIO, DATA_BL FROM IM.VW_COL_RASTREA_ETIQ WHERE (" & Local.InSQL(chkStatus.Text) & ") AND NVL(ETIQ_STATUS_COD,'X')=[:ETIQ_STATUS_COD] AND NVL(PRODUTO_COD,'X')=[:PRODUTO_COD] AND NVL(ESPEC,'X')=[:ESPEC] AND NVL(QUALIDADE,'X')=[:QUALIDADE] AND NVL(VOLUME_PECAS_QTD,0)=[:VOLUME_PECAS_QTD]"
            SQLTEMP = Icraft.IcftBase.MacroSubstSQLText(SQLTEMP, Params)

            SQL &= IIf(SQL <> "", " UNION ", "") & SQLTEMP
        Next
        If SQL = "" Then
            grdEtiq.Visible = False
        Else
            grdEtiq.Visible = True
            grdEtiq.SQL = SQL
            grdEtiq.StrConn = Login.Strconn
            grdEtiq.Usuario = Login.Usuario!usuario
            grdEtiq.ColunaNomes = "Etiqueta;Teórico;Líquido;Bruto;Balança Liq;Balança Brt;Obs;Container Nr;Estabelecimento;Armazém;Praça;OV;Status;Série;NF;Navio;Data BL"
            grdEtiq.CamposFixos = "Etiqueta"
            grdEtiq.Totaliza = "COUNT;SUM;SUM;SUM;SUM;SUM;"
            grdEtiq.Bind()
        End If
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        Dim ETIQS As String = ""
        For Each LINHA As DataGridViewRow In grdEtiq.Grid.Rows
            ETIQS &= IIf(ETIQS <> "", ", ", "") & SqlExpr(LINHA.Cells(0).Value, "'")
        Next
        If ETIQS = "" Then
            MsgBox("Favor selecionar uma linha no grupo de dimensões acima!", vbOKOnly + vbCritical, "Erro!")
        Else
            Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA IN (" & ETIQS & ")")
        End If
    End Sub
End Class