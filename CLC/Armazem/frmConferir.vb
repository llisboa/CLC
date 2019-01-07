Imports Icraft.IcftBase

Public Class frmConferir

    Private Sub frmPesoPecaEspec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
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
            Dim SQL As String = "SELECT PED_REF, VIAGEM_REF_PED, VIAGEM_REF_ORDEM, TEU_NR, PRODUTO_COD, ESPEC, QUALIDADE, NR_CORRIDA, VOLUME_PECAS_QTD, ETIQ_STATUS_COD, COUNT(*) QTD_VOL FROM (" & EstoqueF.SQL & ") WHERE (" & Local.InSQL(chkStatus.Text) & ") GROUP BY PED_REF, VIAGEM_REF_PED, VIAGEM_REF_ORDEM, TEU_NR, PRODUTO_COD, ESPEC, QUALIDADE, NR_CORRIDA,VOLUME_PECAS_QTD,ETIQ_STATUS_COD ORDER BY 1,2,3"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Pedido;Viagem do Pedido;Viagem da Ordem;Container Nr.;Produto;Especificação;Qualidade;Corrida;Qtd Peças;Status;Volumes"
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

            Dim Params As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(":PED_REF", NZ(grdPrinc.Grid.Rows(z).Cells(0).Value, "X"), ":VIAGEM_REF_PED", NZ(grdPrinc.Grid.Rows(z).Cells(1).Value, "X"), ":VIAGEM_REF_ORDEM", NZ(grdPrinc.Grid.Rows(z).Cells(2).Value, "X"), ":TEU_NR", NZ(grdPrinc.Grid.Rows(z).Cells(3).Value, "X"), ":PRODUTO_COD", NZ(grdPrinc.Grid.Rows(z).Cells(4).Value, "X"), ":ESPEC", NZ(grdPrinc.Grid.Rows(z).Cells(5).Value, "X"), ":QUALIDADE", NZ(grdPrinc.Grid.Rows(z).Cells(6).Value, "X"), ":NR_CORRIDA", NZ(grdPrinc.Grid.Rows(z).Cells(7).Value, "X"), ":VOLUME_PECAS_QTD", NZ(grdPrinc.Grid.Rows(z).Cells(8).Value, 0), ":ETIQ_STATUS_COD", NZ(grdPrinc.Grid.Rows(z).Cells(9).Value, "X"))
            Dim SQLTEMP As String = "SELECT ETIQUETA, PESO_TEORICO, PESO_LIQUIDO, PESO_BRUTO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, OBS, TEU_NR, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA FROM IM.VW_COL_RASTREA_ETIQ WHERE (" & Local.InSQL(chkStatus.Text) & ") AND NVL(PED_REF,'X')=[:PED_REF] AND NVL(VIAGEM_REF_PED,'X')=[:VIAGEM_REF_PED] AND NVL(VIAGEM_REF_ORDEM,'X')=[:VIAGEM_REF_ORDEM] AND NVL(TEU_NR,'X')=[:TEU_NR] AND NVL(PRODUTO_COD,'X')=[:PRODUTO_COD] AND NVL(ESPEC,'X')=[:ESPEC] AND NVL(QUALIDADE,'X')=[:QUALIDADE] AND NVL(NR_CORRIDA,'X')=[:NR_CORRIDA] AND NVL(VOLUME_PECAS_QTD,0)=[:VOLUME_PECAS_QTD] AND NVL(ETIQ_STATUS_COD,'X')=[:ETIQ_STATUS_COD]"
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
            grdEtiq.Totaliza = "COUNT;SUM;SUM;SUM;SUM;SUM;"
            grdEtiq.ColunaNomes = "Etiqueta;Teórico;Líquido;Bruto;Balança Liq;Balança Brt;Obs;Container Nr.;Estabelecimento;Armazém;Praça"
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


    'ETIQUETA, PESO_LIQUIDO, PESO_TEORICO, PESO_BRUTO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, OBS 

    Private Sub btnAtualizaPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizaPeso.Click
        If MsgBox("Deseja salvar informações que foram colocadas em peso balança e observações?", MsgBoxStyle.YesNo, "Salvar peso e observação?") = MsgBoxResult.Yes Then
            For Each LINHA As DataGridViewRow In grdEtiq.Grid.Rows
                DSGrava("UPDATE IM.ETIQUETA SET PESO_BALANCA_LIQ = :PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO = :PESO_BALANCA_BRT, OBS = :OBS, TEU_NR = :TEU_NR WHERE ETIQUETA=:ETIQUETA", Login.Strconn, ":PESO_BALANCA_LIQ", LINHA.Cells(4).Value, ":PESO_BALANCA_BRT", LINHA.Cells(5).Value, ":OBS", LINHA.Cells(6).Value, ":TEU_NR", LINHA.Cells(7).Value, ":ETIQUETA", LINHA.Cells(0).Value)
            Next
            MsgBox("Informações atualizadas.")
            'SelectionChanged(Nothing, Nothing)
        End If
    End Sub
End Class