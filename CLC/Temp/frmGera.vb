Public Class frmGera

    Private Sub BTNCARREGA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCARREGA.Click
        FRM.Sistema = TXTSISTEMA.Text
        FRM.EsquemaGerador = TXTESQUEMAGERADOR.Text
        FRM.EsquemaPrinc = TXTESQUEMAPRINC.Text
        FRM.Tabela = TXTTABELA.Text
        FRM.StrConn = TXTSTRCONN.Text
        FRM.Usuario = TXTUSUARIO.Text
        FRM.LargEtiq = TXTLARGETIQ.Text
        FRM.LargCampo = TXTLARGCAMPO.Text
        FRM.UsuarioConfig = TXTUSUARIOCONFIG.Text
        FRM.Consulta = TXTCONSULTA.Text
        FRM.Bind()
    End Sub

    Private Sub btnPega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPega.Click
        VALCHAVE.Text = FRM.Text
    End Sub

    Private Sub btnvai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvai.Click
        FRM.Text = VALCHAVE.Text
    End Sub
End Class