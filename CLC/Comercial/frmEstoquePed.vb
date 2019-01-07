Imports Icraft.IcftBase

Public Class frmEstoquePed

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Carregou = False
            Dim SQL As String = "SELECT PED_REF, PED_ITEM, PRODUTO_COD, ESPEC, PEDIDO, ENTRADA, SAIDA, REAL_CALC, REAL, DISPONIVEL, NEGOCIADO, RESERVADO FROM IM.VW_COL_ESTOQUE_PED"
            If txtBusca.Text <> "" Then
                Dim CRIT As String = ""
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(PED_REF || PED_ITEM || PRODUTO_COD || ESPEC), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
                SQL &= " WHERE " & CRIT
            End If
            SQL &= " ORDER BY PED_REF, PED_ITEM, PRODUTO_COD, ESPEC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Pedido;Item;Produto;Especificação;Pedido;Entrada;Saída;Calculado;Real;Disponivel;Negociado;Reservado"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
            Carregou = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Dim Carregou As Boolean = False

    Private Sub txtBusca_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAtualizar_Click(sender, Nothing)
        End If
    End Sub

    Private Sub frmEstoquePed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChangedPrinc
    End Sub

    Private Sub SelectionChangedPrinc(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Carregou = True Then
        '    Dim IndexCol As Integer = grdPrinc.Grid.SelectedCells.Item(0).ColumnIndex
        '    Dim IndexRow As Integer = grdPrinc.Grid.SelectedCells.Item(0).RowIndex
        '    Dim NomeCol As String = grdPrinc.Grid.Columns(IndexCol).Name
        '    Dim Produto As String = grdPrinc.Grid.Rows(IndexRow).Cells(2).Value
        '    Dim Pedido As String = grdPrinc.Grid.Rows(IndexRow).Cells(0).Value
        '    Dim Item As String = grdPrinc.Grid.Rows(IndexRow).Cells(1).Value
        '    grdEtiq.StrConn = Login.Strconn
        '    grdEtiq.Usuario = Login.Usuario!usuario
        '    grdEtiq.SQL = "SELECT PED_REF, PED_ITEM, PRODUTO_COD, ESPEC_SEQ, ESPEC, ENTRADA, SAIDA, REAL_CALC FROM IM.VW_COL_ESTOQUE_PED WHERE PRODUTO_COD = '" & Produto & "' AND PED_REF = '" & Pedido & "' AND PED_ITEM = " & Item & " AND " & NomeCol & " > 0"
        '    grdEtiq.ColunaNomes = "Pedido;Item;Produto;Sequencial Espec;Especificações;Entrada;Saída;Real Calculado"
        '    grdEtiq.Bind()
        '    grdEtiq.Grid.ReadOnly = True
        'End If
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        'Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA = '" & grdEtiq.Grid.SelectedCells(0).Value & "'")
    End Sub

End Class