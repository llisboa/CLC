Public Class frmConferenciaPraca

    Private Sub frmConferenciaPraca2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = Icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            grdPrinc.SQL = "SELECT AP.ARMAZEM_CIA_COD, AP.ARMAZEM_NUM, AP.PRACA, AP.DESCR, AP.QTD_VOL_CONF, Count(R.ETIQUETA) AS VOLUMES " & _
            "FROM IM.ARMAZEM_PRACA AP, (" & EstoqueF.SQL & ") R " & _
            "WHERE R.ETIQ_STATUS_COD = 'DISPONÍVEL' AND AP.PRACA = R.ARMAZEM_PRACA (+) AND AP.ARMAZEM_NUM = R.ARMAZEM_NUM (+) AND AP.ARMAZEM_CIA_COD = R.ARMAZEM_CIA_COD (+) " & _
            "GROUP BY AP.ARMAZEM_CIA_COD, AP.ARMAZEM_NUM, AP.PRACA, AP.DESCR, AP.QTD_VOL_CONF " & _
            "ORDER BY AP.ARMAZEM_CIA_COD, AP.ARMAZEM_NUM, AP.PRACA"
            grdPrinc.ColunaNomes = "Armazém;Número;Praça;Descrição;Volumes Conferidos;Volumes"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.Totaliza = "COUNT;;;;SUM;SUM;"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub
End Class