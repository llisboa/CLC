Public Class frmImpDSN
    Private Sub frmImpDSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
        Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO")
    End Sub

    Sub Atualizar()
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
        grdPrinc.SQL = "SELECT 0 SEL,  '' Arquivo FROM DUAL ARQS WHERE ROWNUM<1"
        grdPrinc.Usuario = Login.Usuario!USUARIO
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.ColunaNomes = "Sel;Arquivo"
        grdPrinc.CamposExtend = "Geral.SEL|FORMATO:BOOL"
        grdPrinc.EsquemaGerador = Apl.Esquema
        grdPrinc.Sistema = Apl.Esquema
        grdPrinc.EsquemaPrinc = Apl.Esquema
        grdPrinc.Tabela = "Geral"
        grdPrinc.Bind()
    End Sub

    Dim Ult As Integer = -1

    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
        grdPrinc.SQL = "SELECT 0 SEL,  '' Arquivo FROM DUAL ARQS WHERE ROWNUM<1"
        grdPrinc.Usuario = Login.Usuario!USUARIO
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.ColunaNomes = "Sel;Arquivo"
        grdPrinc.CamposExtend = "Geral.SEL|FORMATO:BOOL"
        grdPrinc.EsquemaGerador = Apl.Esquema
        grdPrinc.Sistema = Apl.Esquema
        grdPrinc.EsquemaPrinc = Apl.Esquema
        grdPrinc.Tabela = "Geral"
        grdPrinc.Bind()
    End Sub

    Private Sub btnDiretorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorio.Click
        Try
            DDG.SelectedPath = txtDiretorio.Text
            If DDG.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtDiretorio.Text = DDG.SelectedPath
                btnAtualiza_Click(Nothing, Nothing)
            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando diretório"))
        End Try
    End Sub

    Private Sub btnLer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLer.Click
        Dim DT As System.Data.DataTable = grdPrinc.Grid.DataSource
        Dim DS As New System.Data.DataSet
        grdAux.DataSource = DS
        For Each LINHA As System.Data.DataRow In DT.Rows
            If Icraft.IcftBase.NZ(LINHA!SEL, False) Then
                DS.ReadXml(LINHA!ARQUIVO)
                grdAux.DataSource = New System.Data.DataSet
                grdAux.DataSource = DS.Tables(0)
            End If
        Next
    End Sub
End Class