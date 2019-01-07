Public Class frmCarregamentos

    Private Sub frmCarregamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkOpc.SQL = "SELECT NVL(STATUS_COD,'[VAZIO]') STATUS_COD FROM IM.ORDEM_VENDA_ITEM GROUP BY STATUS_COD"
        chkOpc.StrConn = Login.Strconn
        chkOpc.BIND()
        chkOpc.Text = "PENDENTE"
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "CTL")
        AddHandler grdOrdens.Grid.SelectionChanged, AddressOf SelectionChanged
        AddHandler grdViagens.DepoisDeCarregar, AddressOf DepoisDeCarregar
        AddHandler grdViagens.AposAtualizarInfo, AddressOf MostraInfo
        Atualizar()
    End Sub
    Dim Total As String = ""
    Private Sub DepoisDeCarregar()
        Dim pnl As System.Windows.Forms.Panel = grdViagens.Controls.Find("Panel1", True)(0)
        Dim lbl As Windows.Forms.Label = pnl.Controls.Find("lblInfo", True)(0)
        Dim Qtd As Double
        For Each ROW As DataGridViewRow In grdViagens.Grid.Rows
            Qtd += ROW.Cells(5).Value
        Next
        Total = " | Qtd: " & Qtd & ")"
    End Sub

    Sub MostraInfo(ByVal lbl As Label)
        Dim Masc As String = " \| Itens=\(.*?\)"
        If System.Text.RegularExpressions.Regex.Match(lbl.Text, Masc).Success Then
            lbl.Text = System.Text.RegularExpressions.Regex.Replace(lbl.Text, Masc, Total)
        Else
            lbl.Text &= " " & Total
        End If
    End Sub

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If grdOrdens.Grid.SelectedRows.Count = 1 Then
            Dim ORDEM As String = grdOrdens.Grid.SelectedCells(0).Value
            Try
                Dim SQL As String = "SELECT VIAGEM_REF, CLI_NOME, ENTREGA_LOCAL, PRODUTO_COD, ESPEC, EMB_PED_UNID EMB_PED_UNID, VEICULO_COD, DATA_FECHAMENTO, STATUS_COD FROM IM.VW_COL_INSTRUCAO WHERE ORDEM_VENDA_REF = '" & ORDEM & "' ORDER BY 1,2"
                grdViagens.StrConn = Login.Strconn
                grdViagens.Usuario = Login.Usuario!usuario
                grdViagens.SQL = SQL
                grdViagens.ColunaNomes = "Viagem da Ordem;Cliente;Endereço de Entrega;Produto;Especificações;Quantidade Embarcada;Transportador/Veículo;Data de Fechamento;Status"
                grdViagens.Bind()
                grdViagens.Grid.ReadOnly = True
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
            End Try
        End If
    End Sub
    
    Sub Atualizar()
        Dim SQL As String = ""
        Try
            If CTLDE.Text <> "  /  /" And CTLATE.Text <> "  /  /" Then
                SQL = "SELECT OV_REF, OV_ITEM, DATA_ORDEM, PRODUTO_COD, ESPEC, NOMINAL_PED_UNID, CLIENTE_COD, SALDO, STATUS_COD, VOLUME_STATUS_REQUER FROM IM.VW_COL_RASTREA_OVI WHERE STATUS_COD <> 'RESERVADO' AND DATA_ORDEM BETWEEN '" & CTLDE.Text & "' AND '" & CTLATE.Text & "'"
            Else
                SQL = "SELECT OV_REF, OV_ITEM, DATA_ORDEM, PRODUTO_COD, ESPEC, NOMINAL_PED_UNID, CLIENTE_COD, SALDO, STATUS_COD, VOLUME_STATUS_REQUER FROM IM.VW_COL_RASTREA_OVI WHERE STATUS_COD <> 'RESERVADO'"
            End If
            Dim CRIT As String = ""
            Dim CHK As String = chkOpc.Text
            CRIT = "NVL(STATUS_COD,'[VAZIO]') IN ('" & Join(Split(CHK, ";"), "','") & "')"
            If txtBusca.Text <> "" Then
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(OV_REF || OV_ITEM || PRODUTO_COD || ESPEC), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
            End If
            If CRIT <> "" Then
                SQL &= " AND " & CRIT
            End If
            SQL &= " ORDER BY 1, 2"
            grdOrdens.StrConn = Login.Strconn
            grdOrdens.Usuario = Login.Usuario!usuario
            grdOrdens.SQL = Sql
            grdOrdens.ColunaNomes = "Ordem de Venda;Item;Data da Ordem;Produto;Especificações;Quantidade Nominal;Cliente;Saldo;Status;Status Requerido"
            grdOrdens.Bind()
            grdOrdens.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim DataFim As String = ""
        Dim DataInicio As String = ""
        Try
            DataFim = Icraft.IcftBase.TrocaTexto(CTLATE.Text, "/", "")
            DataInicio = Icraft.IcftBase.TrocaTexto(CTLDE.Text, "/", "")

            If DataFim.Substring(4, 4) < DataInicio.Substring(4, 4) Then
                MsgBox("Favor inserir uma data final posterior a inicial!", vbOKOnly + vbExclamation, "Atenção!")
                CTLATE.Clear()
                CTLDE.Clear()
                CTLDE.Focus()
                Exit Sub
            End If

            If DataFim.Substring(2, 2) <= DataInicio.Substring(2, 2) And DataFim.Substring(0, 2) < DataInicio.Substring(0, 2) Then
                MsgBox("Favor inserir uma data final posterior a inicial!", vbOKOnly + vbExclamation, "Atenção!")
                CTLATE.Clear()
                CTLDE.Clear()
                CTLDE.Focus()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Atualizar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtBusca.Text.StartsWith("CTCA") Then
            Try
                Dim SQL As String = "SELECT VIAGEM_REF, CLI_NOME, ENTREGA_LOCAL, PRODUTO_COD, ESPEC, EMB_PED_UNID, VEICULO_COD, DATA_FECHAMENTO, STATUS_COD FROM IM.VW_COL_INSTRUCAO WHERE VIAGEM_REF = '" & txtBusca.Text & "' ORDER BY 1,2"
                grdViagens.StrConn = Login.Strconn
                grdViagens.Usuario = Login.Usuario!usuario
                grdViagens.SQL = SQL
                grdViagens.ColunaNomes = "Viagem da Ordem;Cliente;Endereço de Entrega;Produto;Especificações;Quantidade Embarcada;Transportador/Veículo;Data de Fechamento;Status"
                grdViagens.Bind()
                grdViagens.Grid.ReadOnly = True

                SQL = "SELECT OV_REF, OV_ITEM, DATA_ORDEM, PRODUTO_COD, ESPEC, NOMINAL_PED_UNID, CLIENTE_COD, SALDO, STATUS_COD, VOLUME_STATUS_REQUER FROM IM.VW_COL_RASTREA_OVI WHERE STATUS_COD <> 'RESERVADO' AND OV_REF IN (SELECT ORDEM_VENDA_REF FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF = '" & txtBusca.Text & "') ORDER BY 1,2"
                grdOrdens.StrConn = Login.Strconn
                grdOrdens.Usuario = Login.Usuario!usuario
                grdOrdens.SQL = SQL
                grdOrdens.ColunaNomes = "Ordem de Venda;Item;Data da Ordem;Produto;Especificações;Quantidade Nominal;Cliente;Saldo;Status;Status Requerido"
                grdOrdens.Bind()
                grdOrdens.Grid.ReadOnly = True
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
            End Try
        ElseIf txtBusca.Text.StartsWith("BHOV") Or txtBusca.Text.StartsWith("SPOV") Then
            Try
                Dim SQL As String = "SELECT OV_REF, OV_ITEM, DATA_ORDEM, PRODUTO_COD, ESPEC, NOMINAL_PED_UNID, CLIENTE_COD, SALDO, STATUS_COD, VOLUME_STATUS_REQUER FROM IM.VW_COL_RASTREA_OVI WHERE STATUS_COD <> 'RESERVADO' AND OV_REF = '" & txtBusca.Text & "' ORDER BY 1,2"
                grdOrdens.StrConn = Login.Strconn
                grdOrdens.Usuario = Login.Usuario!usuario
                grdOrdens.SQL = SQL
                grdOrdens.ColunaNomes = "Ordem de Venda;Item;Data da Ordem;Produto;Especificações;Quantidade Nominal;Cliente;Saldo;Status;Status Requerido"
                grdOrdens.Bind()
                grdOrdens.Grid.ReadOnly = True
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
            End Try
        End If
    End Sub

    Private Sub CTLATE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAtualizar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtBusca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusca.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(txtBusca.Text, Nothing)
            lblReg.Text = txtBusca.Text
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirInstrucao.Click
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF = '" & Icraft.IcftBase.Tratex(grdViagens.Grid.SelectedCells(0).Value) & "'")
    End Sub

    Private Sub btnViagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViagem.Click
        Local.MostraForm(frmViagem, Princ, "VIAGEM", grdViagens.Grid.SelectedCells(0).Value)
    End Sub
End Class