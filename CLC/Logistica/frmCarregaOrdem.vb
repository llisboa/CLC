Imports Icraft.IcftBase

Public Class frmCarregaOrdem

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Carregou = False
            Dim SQL As String = "select OVI.OV_REF, OV.DATA_ORDEM, OVI.OV_ITEM, OV.CLIENTE_COD, OVI.PRODUTO_COD, OVI.ESPEC, OVI.NOMINAL_PED_UNID, OVI.PED_UNID, OVI.VOLUME_PECAS_QTD, OVI.VOLUME_STATUS_REQUER, OVI.STATUS_COD, OV.INSTR_CARREGA  from IM.VW_COL_RASTREA_OVI OVI, IM.ORDEM_VENDA OV WHERE OVI.OV_REF = OV.REF (+)"
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
            SQL &= " ORDER BY OV_REF, OV_ITEM"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = ""
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
            Carregou = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Dim Carregou As Boolean = False
    Private Sub frmEstoqueDina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkOpc.SQL = "SELECT NVL(STATUS_COD,'[VAZIO]') STATUS_COD FROM IM.ORDEM_VENDA_ITEM GROUP BY STATUS_COD"
        chkOpc.StrConn = Login.Strconn
        chkOpc.BIND()
        chkOpc.Text = "PENDENTE"
        'AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChangedPrinc
    End Sub

    'Private Sub SelectionChangedPrinc(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Carregou = True Then
    '        Dim Produto As String = grdPrinc.Grid.SelectedCells(0).Value
    '        Dim Espec As String = grdPrinc.Grid.SelectedCells(1).Value
    '    End If
    'End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        '        Local.MostraRelatorio("RPTETIQUETA", "ETIQUETA = '" & grdEtiq.Grid.SelectedCells(0).Value & "'")
    End Sub

    Private Sub txtBusca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAtualizar_Click(sender, Nothing)
        End If
    End Sub
End Class