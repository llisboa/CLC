Public Class frmSiteConfig

    Private Sub frmSiteConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Usuario = Login.Usuario("USUARIO")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        grdPrinc.Params.Clear()
        grdPrinc.Filtro = "PARAM LIKE 'SITE_%'"
        If txtBusca.Text <> "" Then
            grdPrinc.Filtro &= " AND "
            grdPrinc.Filtro &= "UPPER('|' || PARAM || '|' || CONFIG || '|') LIKE :BUSCA"
            grdPrinc.Params.Add(":BUSCA")
            grdPrinc.Params.Add("%" & UCase(txtBusca.Text) & "%")
        End If

        grdPrinc.Bind()
    End Sub

    Private Sub grdPrinc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdPrinc.Load

    End Sub
End Class