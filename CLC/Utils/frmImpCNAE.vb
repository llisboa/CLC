Public Class frmImpCNAE

    Private Sub lnkSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSite.LinkClicked

        Dim cnpj As String = Icraft.IcftBase.NZV(Icraft.IcftBase.DSValor("cnpj", "im.cia", Login.Strconn, "cod=:cod", ":cod", lstCompanhia.Text), "")
        If cnpj <> "" Then
            Clipboard.Clear()
            Clipboard.SetText(Icraft.IcftBase.TrocaTexto(cnpj, ".", "", "/", "", "-", ""))
            Icraft.IcftBase.DosShell("explorer", "http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao.asp", "", "", "")
        Else
            MsgBox("CNPJ não encontrado para esta companhia.", MsgBoxStyle.Critical, "Atualizando CNAE")
        End If
    End Sub

    Private Sub frmImpCNAE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Icraft.IcftBase.CarregaCombo(lstCompanhia, 1, True, " ", True, Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.CIA", Login.Strconn))
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim DICT As New Dictionary(Of String, String)
        For Each Linha As String In Split(txtTexto.Text, vbCrLf)
            Dim LinhaStr As String = Trim(Linha)
            Dim F As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(LinhaStr, "([0-9][0-9].[0-9][0-9]-[0-9]-[0-9][0-9]) - (.*)")
            If F.Groups(0).Value <> "" Then
                DICT.Add(Trim(F.Groups(1).Value), Trim(F.Groups(2).Value))
            End If
        Next
        If MsgBox("Confirme se " & Icraft.IcftBase.NumPl(DICT.Count, "linha foi informada", "linhas foram informadas") & ". Deseja atualizar lista de CNAE para companhia '" & lstCompanhia.Text & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Icraft.IcftBase.DSGrava("DELETE FROM IM.CIA_ATIV_ECON WHERE CIA_COD=:COD", Login.Strconn, ":COD", lstCompanhia.Text)
            For Each Item As String In DICT.Keys
                Icraft.IcftBase.DSGrava("INSERT INTO IM.CIA_ATIV_ECON (CIA_COD, COD, DESCR) VALUES (:CIA_COD, :COD, :DESCR)", Login.Strconn, ":CIA_COD", lstCompanhia.Text, ":COD", Item, ":DESCR", DICT(Item))
            Next
            MsgBox("Dados cadastrados.", MsgBoxStyle.Information, "Atualizando CNAE")
        Else
            MsgBox("Nenhuma alteração foi realizada.", MsgBoxStyle.Information, "Atualizando CNAE")
        End If
    End Sub

    Private Sub lstCompanhia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCompanhia.DoubleClick
        lnkSite_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub lstCompanhia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCompanhia.SelectedIndexChanged
        txtTexto.Text = ""
    End Sub
End Class