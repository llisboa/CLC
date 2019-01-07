Public Class frmPendencias

    Private Sub frmPendencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtualizarParciais()
        AtualizarPendentes()
        AddHandler grdItensParc.Grid.SelectionChanged, AddressOf SelectionChanged
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "CTL")
        Icraft.IcftBase.CarregaCombo(cbxLocal, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.CIA", Login.Strconn))
        Icraft.IcftBase.CarregaCombo(cbxTransp, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.VEICULO", Login.Strconn))
    End Sub

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Filtro As String = ""
        If grdItensParc.Grid.SelectedRows.Count > 0 Then
            For Each Grd As DataGridViewRow In grdItensParc.Grid.SelectedRows
                Dim z As Integer = Grd.Index
                Filtro &= "ORDEM_VENDA_REF = '" & Icraft.IcftBase.NZ(grdItensParc.Grid.Rows(z).Cells(1).Value) & "' AND ORDEM_VENDA_ITEM = " & Icraft.IcftBase.NZ(grdItensParc.Grid.Rows(z).Cells(2).Value) & " OR "
            Next
            Filtro = Filtro.Substring(0, Len(Filtro) - 4)
            'VIAGENS
            Dim Sql As String = "SELECT VIAGEM_REF," & vbCrLf & _
            "DATA_FECHAMENTO," & vbCrLf & _
            "ENTREGA_NOME," & vbCrLf & _
            "ENTREGA_LOCAL," & vbCrLf & _
            "VEICULO_COD," & vbCrLf & _
            "STATUS_COD," & vbCrLf & _
            "OBS_VIAGEM" & vbCrLf & _
            "FROM IM.VW_COL_INSTRUCAO"
            If Filtro <> "" Then
                Sql &= " WHERE " & Filtro
            End If
            Sql &= " GROUP BY VIAGEM_REF, DATA_FECHAMENTO, ENTREGA_NOME, ENTREGA_LOCAL, VEICULO_COD, STATUS_COD, OBS_VIAGEM"
            grdViagens.SQL = Sql
            grdViagens.Usuario = Login.Usuario!USUARIO
            grdViagens.StrConn = Login.Strconn
            grdViagens.ColunaNomes = "Viagem;Data de Fechamento;Entrega;Local de Entrega;Veículo;Status;Observações"
            grdViagens.EsquemaGerador = Apl.Esquema
            grdViagens.Sistema = Apl.Esquema
            grdViagens.EsquemaPrinc = Apl.Esquema
            grdViagens.Bind()
        End If
    End Sub

    Sub AtualizarParciais(Optional ByVal Filtro As String = "")
        'ITENS PARCIAIS
        Dim SQL As String = "SELECT '' CONFIRMA, OVI.OV_REF, OVI.OV_ITEM, OVI.PRODUTO_COD, OVI.EMBALAGEM, OVI.ESPEC, OVI.NOMINAL_PED_UNID || ' ' || OVI.PED_UNID, OVI.EMB_PED_UNID || ' ' || OVI.PED_UNID, OVI.SALDO || ' ' || OVI.PED_UNID, OVI.CLIENTE_COD, OVI.STATUS_COD FROM IM.VW_COL_RASTREA_OVI OVI, IM.ORDEM_VENDA_EMB OVE WHERE OVI.STATUS_COD NOT IN ('ENTREGUE','CANCELADO','RESERVADO') AND OVI.OV_REF || '/' || OVI.OV_ITEM = OVE.ORDEM_VENDA_REF || '/' || OVE.ORDEM_VENDA_ITEM"
        If Filtro <> "" Then
            If Filtro.StartsWith("BHOV") Then
                SQL &= " AND OVI.OV_REF LIKE '%" & Filtro & "%'"
            ElseIf Filtro.StartsWith("CTCA") Then
                SQL &= " AND OVE.VIAGEM_REF LIKE '%" & Filtro & "%'"
            End If
        End If
            grdItensParc.SQL = SQL
            grdItensParc.Usuario = Login.Usuario!USUARIO
            grdItensParc.StrConn = Login.Strconn
            grdItensParc.ColunaNomes = "Confirmação;Ordem de Venda;Item;Produto;Embalagem;Especificações;Qtd Vendida;Qtd Embarcada;Saldo;Cliente;Status da Venda"
            grdItensParc.CamposExtend = "Geral.CONFIRMA|FORMATO:BOOL"
            grdItensParc.EsquemaGerador = Apl.Esquema
            grdItensParc.Sistema = Apl.Esquema
            grdItensParc.EsquemaPrinc = Apl.Esquema
            grdItensParc.Tabela = "Geral"
            grdItensParc.Bind()
    End Sub

    Sub AtualizarPendentes(Optional ByVal Filtro As String = "")
        'PENDENTES
        Dim SQL As String = "SELECT '' QTD_EMB," & vbCrLf & _
        "VW.CLIENTE_COD," & vbCrLf & _
        "VW.OV_REF," & vbCrLf & _
        "VW.OV_ITEM," & vbCrLf & _
        "VW.PRODUTO_COD," & vbCrLf & _
        "VW.ESPEC," & vbCrLf & _
        "NVL(VW.NOMINAL_PED_UNID,0) VENDIDO," & vbCrLf & _
        "NVL(VW.EMB_PED_UNID,0) EMBARCADO," & vbCrLf & _
        "NVL(VW.SALDO,0) SALDO," & vbCrLf & _
        "SUM(NVL(E.PESO_BALANCA_LIQ,0)) TOTAL_REAL_LIQ," & vbCrLf & _
        "VW.STATUS_COD" & vbCrLf & _
        "FROM IM.VW_COL_RASTREA_ETIQ E," & vbCrLf & _
        "IM.VW_COL_RASTREA_OVI VW" & vbCrLf & _
        "WHERE VW.OV_REF = E.ORDEM_VENDA_REF (+)" & vbCrLf & _
        "AND VW.OV_ITEM  = E.ORDEM_VENDA_ITEM (+)" & vbCrLf & _
        "AND VW.STATUS_COD IN ('PENDENTE', 'ENTREGUE PARCIALMENTE')" & vbCrLf & _
        "AND NVL(VW.SALDO,0) <> 0"
        If Filtro <> "" Then
            Sql &= " AND VW.OV_REF LIKE '%" & Filtro & "%'"
        End If
        SQL &= "GROUP BY VW.CLIENTE_COD," & vbCrLf & _
        "VW.OV_REF," & vbCrLf & _
        "VW.OV_ITEM," & vbCrLf & _
        "VW.PRODUTO_COD," & vbCrLf & _
        "VW.ESPEC," & vbCrLf & _
        "VW.NOMINAL_PED_UNID," & vbCrLf & _
        "VW.EMB_PED_UNID," & vbCrLf & _
        "VW.SALDO," & vbCrLf & _
        "VW.STATUS_COD" & vbCrLf & _
        "ORDER BY 1,2,3"
        grdPend.SQL = Sql
        grdPend.Usuario = Login.Usuario!USUARIO
        grdPend.StrConn = Login.Strconn
        grdPend.ColunaNomes = "Quantidade a ser Embarcada;Cliente;Ordem de Venda;Item;Produto;Especificações;Vendido;Embarcado;Saldo;Peso Real Total;Status da Venda"
        grdPend.CamposExtend = "Geral.CONFIRMA|FORMATO:BOOL"
        grdPend.EsquemaGerador = Apl.Esquema
        grdPend.Sistema = Apl.Esquema
        grdPend.EsquemaPrinc = Apl.Esquema
        grdPend.Tabela = "Geral"
        grdPend.Bind()
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        If MsgBox("Confirma término do carregamento?", MsgBoxStyle.YesNo, "Finalizar Carregamento.") = MsgBoxResult.Yes Then
            Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT GRUPO FROM IM.GER_USUARIO WHERE USUARIO = '" & Login.Usuario!usuario & "'", Login.Strconn)
            Dim Grupo As String = DS.Tables(0).Rows(0)(0)
            If Grupo.Contains("LOGÍSTICA") Then
                Dim DT As System.Data.DataTable = grdItensParc.Grid.DataSource
                Dim SQL As New ArrayList
                Dim Erro As Integer = 0
                For Each LINHA As System.Data.DataRow In DT.Rows
                    If Icraft.IcftBase.NZ(LINHA!CONFIRMA, False) Then
                        SQL.Add("UPDATE IM.ORDEM_VENDA_ITEM SET STATUS_COD = 'ENTREGUE' WHERE ORDEM_VENDA_REF = '" & LINHA!OV_REF & "' AND ITEM = " & LINHA!OV_ITEM)
                    End If
                Next
                For Each Item As String In SQL
                    Try
                        Icraft.IcftBase.DSGrava(Item, Login.Strconn)
                    Catch ex As Exception
                        MsgBox(ex)
                        Erro += 1
                    End Try
                Next
                If Erro = 0 Then
                    MsgBox("Embarques finalizados com sucesso!")
                End If
            Else
                MsgBox("Você não tem permissão para usar esta funcionalidade. Favor solicitar permissão ao Administrador.")
                AtualizarParciais()
            End If
        End If
    End Sub

    Private Sub btnBuscaParc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaParc.Click
        AtualizarParciais(txtBuscaParc.Text)
    End Sub

    Private Sub txtBuscaParc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaParc.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscaParc_Click(sender, Nothing)
        End If
    End Sub

    Private Sub txtBuscaPend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaPend.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscaPend_Click(sender, Nothing)
        End If
    End Sub

    Private Sub btnEmbarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmbarcar.Click
        If MsgBox("Criar nova Viagem? Se não informe uma viagem existente", MsgBoxStyle.YesNo, "Criação de Embarque.") = MsgBoxResult.Yes Then
            pnlCriação.Visible = True
        Else
            MsgBox("Preenche")
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        pnlCriação.Visible = False
    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        pnlCriação.Visible = False
    End Sub

    Private Sub btnBuscaPend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPend.Click
        AtualizarPendentes(txtBuscaPend.Text)
    End Sub
End Class