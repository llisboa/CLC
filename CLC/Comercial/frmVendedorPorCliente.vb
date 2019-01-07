Imports Icraft.IcftBase

Public Class frmVendedorPorCliente

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Dim SQL As String = "SELECT CLIENTE_COD, COUNT(*) QTD_VENDEDORES, WM_CONCAT(VENDEDOR_COD) VENDEDORES FROM " & vbCrLf & _
            "(select CLIENTE_COD, VENDEDOR_COD from " & vbCrLf & _
            "(select COM.ORDEM_VENDA_REF, COM.VENDEDOR_COD, OV.CLIENTE_COD from IM.ORDEM_VENDA_COMISS COM, IM.ORDEM_VENDA OV" & vbCrLf & _
            "where COM.ORDEM_VENDA_REF = OV.ref (+) )" & vbCrLf & _
            "group by CLIENTE_COD, VENDEDOR_COD)"

            If txtBusca.Text <> "" Then
                Dim CRIT As String = ""
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(CLIENTE_COD || VENDEDOR_COD), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
                SQL &= " WHERE " & CRIT
            End If

            SQL &= "GROUP BY CLIENTE_COD ORDER BY 2 DESC"

            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Cliente;Qtd Vendedores;Vendedores"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
        Carregou = True
    End Sub
    Dim Carregou As Boolean = False
    Private Sub frmEstoqueDina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChanged
        AddHandler grdEtiq.Grid.CellDoubleClick, AddressOf DuploClique
    End Sub

    Private Sub DuploClique(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 1 Then
            Dim ORDEM As String = grdEtiq.Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Visualiza(ORDEM)
        End If
    End Sub

    Sub Visualiza(ByVal Ordem As String)
        Dim F As frmOrdemVenda = Local.MostraForm("Zoom em Ordem de Venda", frmOrdemVenda, Princ)
        F.f.Criado.ChaveConcatStr = Ordem
    End Sub

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Carregou = True Then
            Dim CLIENTECOD As String = NZ(grdPrinc.Grid.SelectedCells(0).Value, "")
            grdEtiq.StrConn = Login.Strconn
            grdEtiq.Usuario = Login.Usuario!usuario
            grdEtiq.SQL = "SELECT COM.VENDEDOR_COD, COM.ORDEM_VENDA_REF FROM IM.ORDEM_VENDA_COMISS COM, IM.ORDEM_VENDA OV" & vbCrLf & _
            "WHERE COM.ORDEM_VENDA_REF = OV.REF (+) AND " & IIf(CLIENTECOD = "", "OV.CLIENTE_COD IS NULL", "OV.CLIENTE_COD = '" & CLIENTECOD & "'") & vbCrLf & _
            "ORDER BY VENDEDOR_COD, ORDEM_VENDA_REF"
            grdEtiq.ColunaNomes = "Vendedor;Ordem de Venda"
            grdEtiq.Bind()
            grdEtiq.Grid.ReadOnly = True
        End If
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        Try
            Dim ORDEM As String = grdEtiq.Grid.SelectedRows(0).Cells(1).Value
            Visualiza(ORDEM)
        Catch
            MsgBox("Escolha uma das ordens antes de tentar visualizar.")
        End Try
    End Sub

End Class