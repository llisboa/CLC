Public Class frmTrataImagens

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Icraft.IcftBase.CarregaPB(Imagem, Icraft.IcftBase.DSArquivo("~\Img\LogoIM.jpg", Login.Strconn))
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub
End Class