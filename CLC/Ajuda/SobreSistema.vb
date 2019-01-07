Public NotInheritable Class SobreSistema
    Private Sub SobreSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblProd.Text = My.Application.Info.Title & " - " & My.Application.Info.ProductName
        lblVer.Text = "Prog CLC: " & Icraft.IcftBase.VersaoApl & " - Icft BASE: " & Icraft.IcftBase.Versao.ToString
        lblCopy.Text = My.Application.Info.Copyright
        lblLic.Text = My.Resources.INFO_LICENCA
        lblBase.Text = ""
        Try
            lblBase.Text = "Servidor em " & Icraft.IcftBase.DSValor("UTL_INADDR.GET_HOST_NAME || ' (' || UTL_INADDR.GET_HOST_ADDRESS || ')'", "DUAL", Login.Strconn, "")
        Catch
        End Try
        lblBaseId.Text = "Base " & Icraft.IcftBase.DSValor("NAME || ' DBID ' || DBID || ' com checkpoint ' || CHECKPOINT_CHANGE# || ' em ' || LOG_MODE", "SYS.V_$DATABASE", Login.Strconn, "")
        lblBaseAtu.Text = "Última atualização em " & Icraft.IcftBase.DSValor("TO_CHAR(SCN_TO_TIMESTAMP(CHECKPOINT_CHANGE#),'YYYY-MM-DD HH24:MI:SS')", "SYS.V_$DATABASE", Login.Strconn, "")
        txtObjetivos.Text = My.Resources.INFO_OBJETIVOS
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
