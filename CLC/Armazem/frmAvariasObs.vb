Imports Icraft.IcftBase
Imports Icraft.IcftFGrid2
Public Class frmAvariasObs

    Private Sub frmAvariasObs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.SQL = "SELECT ETIQ_STATUS_COD FROM IM.VW_COL_RASTREA_ETIQ WHERE ETIQ_STATUS_COD NOT IN ('CARREGADO') GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT ETIQ_STATUS_COD, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ETIQUETA, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, AVARIA, OBS FROM (" & EstoqueF.SQL & ") WHERE (AVARIA IS NOT NULL OR OBS IS NOT NULL) AND " & Local.InSQL(chkStatus.Text)
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Armazém;Número;Praça;Etiqueta;Produto;Especificações;Pedido;Item;Avarias;Observações"
            grdPrinc.Totaliza = "COUNT;"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
        AddHandler grdPrinc.Grid.CellClick, AddressOf CellClick
    End Sub

    Dim Value As String
    Private Sub CellClick(ByVal sender As Object, ByVal e As Object)
        Dim DS As New System.Data.DataSet
        DS = DSCarrega("SELECT ETIQ_STATUS_COD, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ETIQUETA, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, AVARIA, OBS FROM (" & EstoqueF.SQL & ") WHERE (AVARIA IS NOT NULL OR OBS IS NOT NULL) AND " & Local.InSQL(chkStatus.Text), Login.Strconn)
        Value = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(4).Value, "")
        Try
            DS = DSCarrega("SELECT ETIQ_STATUS_COD, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ETIQUETA, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, AVARIA, OBS FROM (" & EstoqueF.SQL & ") WHERE (AVARIA IS NOT NULL OR OBS IS NOT NULL) AND " & Local.InSQL(chkStatus.Text) & " AND ETIQUETA = '" & Value & "'", Login.Strconn)
            txtAvarias.Text = DS.Tables(0).Rows(0)("AVARIA").ToString
            txtObs.Text = DS.Tables(0).Rows(0)("OBS").ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim DS As System.Data.DataSet = DSCarrega("SELECT ETIQ_STATUS_COD, ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ETIQUETA, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, AVARIA, OBS FROM (" & EstoqueF.SQL & ") WHERE (AVARIA IS NOT NULL OR OBS IS NOT NULL) AND " & Local.InSQL(chkStatus.Text) & " AND ETIQUETA = '" & Value & "'", Login.Strconn)
        Dim OldAvarias As String = DS.Tables(0).Rows(0)("AVARIA").ToString
        Dim OldObs As String = DS.Tables(0).Rows(0)("OBS").ToString
        If txtAvarias.Text <> OldAvarias Then
            Try
                DSGrava("UPDATE IM.ETIQUETA SET AVARIA = '" & txtAvarias.Text & "' WHERE ETIQUETA = '" & Value & "'", Login.Strconn)
                MsgBox("De: " & OldAvarias & vbCrLf & vbCrLf & "Para: " & txtAvarias.Text, , "Avaria na etiqueta " & Value & " alterada!")
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Não foi possível atualizar a etiqueta " & Value))
            End Try
        End If
        If txtObs.Text <> OldObs Then
            Try
                DSGrava("UPDATE IM.ETIQUETA SET OBS = '" & txtObs.Text & "' WHERE ETIQUETA = '" & Value & "'", Login.Strconn)
                MsgBox("De: " & OldObs & vbCrLf & vbCrLf & "Para: " & txtObs.Text, , "Observações na etiqueta " & Value & " alterada!")
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Não foi possível atualizar a etiqueta " & Value))
            End Try
        End If
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub
End Class