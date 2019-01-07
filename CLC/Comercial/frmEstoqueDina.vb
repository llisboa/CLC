Imports Icraft.IcftBase

Public Class frmEstoqueDina

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Carregou = False
            Dim SQL As String = "SELECT PRODUTO_COD, ESPEC, REAL_AVARIADO, NEGOCIADO_AVARIADO, RESERVADO_AVARIADO, DISPONIVEL_AVARIADO, REAL_OK, NEGOCIADO_OK, RESERVADO_OK, DISPONIVEL_OK FROM IM.VW_COL_ESTOQUE_DINA"
            If txtBusca.Text <> "" Then
                Dim CRIT As String = ""
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(PRODUTO_COD || ESPEC), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
                SQL &= " WHERE " & CRIT
            End If
            SQL &= " ORDER BY PRODUTO_COD, ESPEC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Produto;Dimensão / Qualidade;Real Avariado;Negociado Avariado;Reservado Avariado;Disponível Avariado;Real OK;Negociado OK;Reservado OK;Disponível OK"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
            Carregou = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Dim Carregou As Boolean = False
    Private Sub frmEstoqueDina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChangedPrinc
    End Sub

    Private Sub SelectionChangedPrinc(ByVal sender As Object, ByVal e As System.EventArgs)
        If Carregou = True Then
            'Dim Espec As String = grdPrinc.Grid.SelectedCells(1).Value
            Dim IndexCol As Integer = grdPrinc.Grid.SelectedCells.Item(0).ColumnIndex
            Dim IndexRow As Integer = grdPrinc.Grid.SelectedCells.Item(0).RowIndex
            Dim NomeCol As String = grdPrinc.Grid.Columns(IndexCol).Name
            Dim Produto As String = grdPrinc.Grid.Rows(IndexRow).Cells(0).Value
            Dim Espec As String = grdPrinc.Grid.Rows(IndexRow).Cells(1).Value
            grdEtiq.StrConn = Login.Strconn
            grdEtiq.Usuario = Login.Usuario!usuario
            'grdEtiq.SQL = "SELECT E.ETIQUETA, VW.PRODUTO_COD, VW.ESPEC_SEQ, VW.ESPEC, VW.PEDIDO, VW.ENTRADA, VW.SAIDA, VW.REAL_CALC FROM IM.VW_COL_ESTOQUE_DINA VW, IM.VW_COL_RASTREA_ETIQ E WHERE E.PRODUTO_COD = '" & Produto & "' AND E.ESPEC_SEQ = VW.ESPEC_SEQ AND E.ESPEC = '" & Espec & "' AND E.PRODUTO_COD = '" & Produto & "' AND VW." & NomeCol & " > 0 AND E.ETIQ_STATUS_COD <> 'CANCELADO'"
            grdEtiq.SQL = "SELECT PRODUTO_COD, ESPEC_SEQ, ESPEC, PEDIDO, ENTRADA, SAIDA, REAL_CALC FROM IM.VW_COL_ESTOQUE_DINA WHERE PRODUTO_COD = '" & Produto & "' AND ESPEC = '" & Espec & "' AND " & NomeCol & " > 0"
            grdEtiq.ColunaNomes = "Etiqueta;Produto;Sequencial Espec;Especificação;Pedido;Entrada;Saída;Real Calculado"
            grdEtiq.Bind()
            grdEtiq.Grid.ReadOnly = True
        End If
    End Sub
    
    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        Dim IndexRow As Integer = grdEtiq.Grid.SelectedCells.Item(0).RowIndex
        Dim Produto As String = grdEtiq.Grid.Rows(IndexRow).Cells(0).Value
        Dim Seq As String = grdEtiq.Grid.Rows(IndexRow).Cells(1).Value
        Dim Espec As String = grdEtiq.Grid.Rows(IndexRow).Cells(2).Value
        Dim SQL As String = "SELECT ETIQUETA FROM IM.VW_COL_RASTREA_ETIQ WHERE PRODUTO_COD = '" & Produto & "' AND ESPEC_SEQ = '" & Seq & "' AND ESPEC = '" & Espec & "'"
        Dim DS As System.Data.DataSet = DSCarrega(SQL, Login.Strconn)
        Dim INSQL As String = ""
        For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
            INSQL &= "'" & ROW!ETIQUETA & "'"
        Next
        INSQL = INSQL.Replace("''", "','")
        Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA IN (" & INSQL & ")")
    End Sub

    Private Sub txtBusca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAtualizar_Click(sender, Nothing)
        End If
    End Sub
End Class