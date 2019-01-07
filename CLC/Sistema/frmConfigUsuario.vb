Public Class frmConfigUsuario

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Sub Carregar(Optional ByVal Mostrar As Boolean = True)
        Local.UsuarioConfig = New Icraft.IcftBase.ElementosStr(Icraft.IcftBase.NZV(Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!USUARIO, "DEFINICOES", Apl.Esquema & ".SYS_CONFIG_USUARIO"), ""))
        If Mostrar Then
            grdConfig.Rows.Clear()
            For Z As Integer = 0 To Local.UsuarioConfig.Elementos.Count - 1
                grdConfig.Rows.Add(Local.UsuarioConfig.Items(Z).Nome, Local.UsuarioConfig.Items(Z).Conteudo)
            Next
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MsgBox("Recarregar configurações?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Recarregando Configurações") = MsgBoxResult.Yes Then
            Carregar()
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Local.UsuarioConfig = New Icraft.IcftBase.ElementosStr("")
        For Each Linha As DataGridViewRow In grdConfig.Rows
            If Trim(Linha.Cells("PARAM").Value) <> "" Then
                Local.UsuarioConfig.AddStr(Trim(Linha.Cells("PARAM").Value) & ":'" & Icraft.IcftBase.Tratex(Trim(Linha.Cells("valor").Value) & "'"))
            End If
        Next
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!USUARIO, "DEFINICOES", Apl.Esquema & ".SYS_CONFIG_USUARIO") = Local.UsuarioConfig.ToStyleStr
        MsgBox("Configuração confirmada.", MsgBoxStyle.Information, "Gravação de Configuração")
    End Sub
End Class