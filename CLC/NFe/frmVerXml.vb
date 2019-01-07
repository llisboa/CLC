Public Class frmVerXml

    Dim DS As System.Data.DataSet = Nothing
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        DS = NFe.CarregaNotaDirDS(txtDire.Text, True)
        grdPrinc.DataSource = DS.Tables(0)
        MsgBox("Importação de dados concluída.", MsgBoxStyle.Information)
    End Sub

    Private Sub frmVerXml_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        grdPrinc.Width = Me.ClientRectangle.Width - grdPrinc.Left * 2
        grdPrinc.Height = Me.ClientRectangle.Height - grdPrinc.Top - 10
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Dim Arquivo As String = InputBox("Entre com diretório/nome do arquivo XSD.")
            CType(grdPrinc.DataSource, System.Data.DataTable).WriteXml(Arquivo)
            MsgBox("Exportação xsd concluída.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erro:" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Arquivo As String = InputBox("Entre com diretório/nome do arquivo XLS.")

            AddHandler Icraft.IcftBase.ExportaParaXlsLog, AddressOf Princ.MostraStatus
            Icraft.IcftBase.ExportaParaXls(CType(grdPrinc.DataSource, System.Data.DataTable), Arquivo)

            MsgBox("Exportação xls concluída.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erro:" & ex.Message)
        End Try
    End Sub
End Class