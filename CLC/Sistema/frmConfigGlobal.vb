Public Class frmConfigGlobal

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdPrinc.Tabela = "SYS_CONFIG_GLOBAL"
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Sistema = Apl.Esquema
        grdPrinc.Chave = "PARAM"
        grdPrinc.EsquemaGerador = Apl.Esquema
        grdPrinc.EsquemaPrinc = Apl.Esquema
        grdPrinc.Usuario = Login.Usuario!USUARIO
        grdPrinc.Bind()

        AddHandler grdPrinc.Grid.RowValidating, AddressOf VerificaLinha

    End Sub

    Sub VerificaLinha(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs)
        Dim Linha As DataGridViewRow = grdPrinc.Grid.CurrentRow
        If Not IsNothing(Linha) Then
            If Icraft.IcftBase.NZV(Linha.Cells(0).Value, "") = "REPOSITORIO_RAIZ" Then
                Try
                    Dim COMANDO As String = "CREATE OR REPLACE DIRECTORY REPOSITORIO_RAIZ AS '" & Linha.Cells("CONFIG").Value & "'"
                    Icraft.IcftBase.DSGrava("BEGIN EXECUTE IMMEDIATE '" & Icraft.IcftBase.Tratex(COMANDO) & "';END;", Login.Strconn)
                Catch ex As Exception
                    Local.MostraErr(ex, "Erro ao definir REPOSITORIO_RAIZ")
                    e.Cancel = True
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedefinir.Click
        If MsgBox("Serão definidas as opções default que faltam, garantindo que o aplicativo tenha condições de rodar. Deseja continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Recarregando Configurações") = MsgBoxResult.Yes Then
            If MsgBox("Suas configurações poderão ser alteradas. Continuar mesmo assim?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Recarregando Configurações") = MsgBoxResult.Yes Then
                'Carregar()
            End If
        End If
    End Sub

End Class