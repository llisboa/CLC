Public Class CodBarras

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Try
            Icraft.IcftBase.DSConfig(Login.Strconn, "FRMCODBARRAS", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "txt")

            Dim l As New Icraft.IcftBase.CodBarras
            l.AlturaPx = imgCodB.Height
            l.LarguraPx = imgCodB.Width
            l.Text = txtTxt.Text
            l.Extensao = txtExt.Text
            l.Metodo = System.Enum.Parse(GetType(Icraft.IcftBase.CodBarras.MetodoOpc), txtTipo.Text)
            Dim bmp As System.Drawing.Bitmap = l.ObtemImagemInteira()
            imgCodB.Image = bmp
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CodBarras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Icraft.IcftBase.CarregaCombo(txtExt, True, Split("gif;png;jpg;bmp;tiff", ";"))
            'Icraft.IcftBase.CarregaCombo(txtTipo, True, Split("ImagemInteiraCode128B;ImagemInteiraCode128C;ImagemInteiraInterc25", ";"))
            Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfig(Login.Strconn, "FRMCODBARRAS", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class