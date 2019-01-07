Imports Icraft.IcftBase
Public Class frmPontoColeta

    Private Sub frmDimensoesPecas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT DISTINCT NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) XTA, CARREGA_NOME FROM IM.VW_COL_INSTRUCAO WHERE CARREGA_NOME IS NOT NULL ORDER BY XTA DESC"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Data de Carregamento;Ponto de Coleta"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
        AddHandler grdPrinc.Grid.SelectionChanged, AddressOf SelectionChanged
    End Sub
    Dim SQL As String = ""

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SQL = ""
        For Each Grd As DataGridViewRow In grdPrinc.Grid.SelectedRows
            Dim z As Integer = Grd.Index
            Dim Params As ArrayList = ParamArrayToArrayList(":CARREGA_ETA", NZ(grdPrinc.Grid.Rows(z).Cells(0).Value, ""), ":CARREGA_NOME", NZ(grdPrinc.Grid.Rows(z).Cells(1).Value, ""))
            Dim SQLTEMP As String = "SELECT DISTINCT VIAGEM_REF FROM IM.VW_COL_INSTRUCAO WHERE NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) = [:CARREGA_ETA] AND CARREGA_NOME=[:CARREGA_NOME]"
            SQLTEMP = Icraft.IcftBase.MacroSubstSQLText(SQLTEMP, Params)
            SQL &= IIf(SQL <> "", " UNION ", "") & SQLTEMP
        Next
    End Sub
    Shared Function InSQL(ByVal SQL As String)
        Dim Ret As String = ""
        Dim DS As System.Data.DataSet = DSCarrega(SQL, Login.Strconn)
        For i As Integer = 0 To DS.Tables(0).Rows.Count - 1
            Ret &= "'" & DS.Tables(0).Rows(i)(0) & "'"
        Next
        Return Ret.Replace("''", "','")
    End Function
    Private Sub btnImprim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If SQL = "" Then
            MsgBox("Favor selecionar linha.", vbOKOnly + vbCritical, "Erro!")
        Else
            Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF IN (" & InSQL(SQL) & ")")
        End If
    End Sub
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub
End Class