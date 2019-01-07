Public Class frmServicos

    Private Sub frmServicos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO")
        txtServidor.Text = "SMTPI"
        AtualizarResumos()
        AtualizarViagens()
        AtualizarAcompanhamentos()
    End Sub
    Sub AtualizarResumos()
        Try
            Dim SQL As String = "SELECT DISTINCT 0 SEL, NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) XTA, CARREGA_NOME FROM IM.VW_COL_INSTRUCAO WHERE CARREGA_NOME IS NOT NULL ORDER BY XTA DESC"
            grdResumo.SQL = SQL
            grdResumo.StrConn = Login.Strconn
            grdResumo.Usuario = Login.Usuario!usuario
            grdResumo.ColunaNomes = "Sel;Data;Ponto de Carregamento"
            grdResumo.CamposExtend = "Geral.SEL|FORMATO:BOOL"
            grdResumo.EsquemaGerador = Apl.Esquema
            grdResumo.Sistema = Apl.Esquema
            grdResumo.EsquemaPrinc = Apl.Esquema
            grdResumo.Tabela = "Geral"
            grdResumo.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Sub AtualizarViagens()
        Try
            Dim SQL As String = "SELECT DISTINCT 0 SEL, VIAGEM_REF, NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) XTA, CARREGA_NOME FROM IM.VW_COL_INSTRUCAO WHERE CARREGA_NOME IS NOT NULL ORDER BY XTA DESC"
            grdViagens.SQL = SQL
            grdViagens.StrConn = Login.Strconn
            grdViagens.Usuario = Login.Usuario!usuario
            grdViagens.ColunaNomes = "Sel;Viagem;Data;Ponto de Carregamento"
            grdViagens.CamposExtend = "Geral.SEL|FORMATO:BOOL"
            grdViagens.EsquemaGerador = Apl.Esquema
            grdViagens.Sistema = Apl.Esquema
            grdViagens.EsquemaPrinc = Apl.Esquema
            grdViagens.Tabela = "Geral"
            grdViagens.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Dim Ult As Integer = -1
    Sub AtualizarAcompanhamentos()
        Try
            Dim SQL As String = "SELECT 0 SEL, NULL DOCUMENTO, NULL EMAIL, NULL MOMENTO, NULL RESULTADO FROM DUAL"
            grdAcompanhamento.SQL = SQL
            grdAcompanhamento.StrConn = Login.Strconn
            grdAcompanhamento.Usuario = Login.Usuario!usuario
            grdAcompanhamento.ColunaNomes = "Sel;Documento;Email;Momento;Resultado"
            grdAcompanhamento.CamposExtend = "Geral.SEL|FORMATO:BOOL"
            grdAcompanhamento.EsquemaGerador = Apl.Esquema
            grdAcompanhamento.Sistema = Apl.Esquema
            grdAcompanhamento.EsquemaPrinc = Apl.Esquema
            grdAcompanhamento.Tabela = "Geral"
            grdAcompanhamento.Bind()
            Dim DT As System.Data.DataTable = grdAcompanhamento.Grid.DataSource
            For Each LINHA As System.Data.DataRow In DT.Rows
                If Icraft.IcftBase.NZV(LINHA!DOCUMENTO, "") = "" Then
                    grdAcompanhamento.Grid.Rows.Remove(grdAcompanhamento.Grid.Rows(0))
                End If
            Next
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Dim Filtro As String = ""
    Dim Nome As String = ""
    Dim Check As Boolean = False

    Function VerificaPrioridade()
        Dim ret As System.Net.Mail.MailPriority
        If rbtAlta.Checked Then
            ret = Net.Mail.MailPriority.High
        ElseIf rbtBaixa.Checked Then
            ret = Net.Mail.MailPriority.Low
        ElseIf rbtNormal.Checked Then
            ret = Net.Mail.MailPriority.Normal
        End If
        Return ret
    End Function

    Private Sub btnEnviaViagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaViagem.Click
        Restricao()
        PegaViagens()
        If Check = False Then
            MsgBox("Marque as viagens que deseja visualizar")
            Exit Sub
        End If
        Dim Arq As New ArrayList
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF IN (" & Filtro & ") AND CARREGA_NOME IN (" & Nome & ") ORDER BY VIAGEM_REF", txtNomeArq.Text & ".PDF")
        Arq.Add(txtNomeArq.Text & ".PDF")
        For Each ITEM In Anexos
            Arq.Add(ITEM)
        Next
        Dim ret As String = Icraft.IcftBase.EnviaEmail(txtRem.Text, txtEmails.Text, txtAssunto.Text, txtCorpo.Text, VerificaPrioridade, txtServidor.Text, , , , , , True, , Arq)
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT 0 SEL, NULL DOCUMENTO, NULL EMAIL, NULL MOMENTO, NULL RESULTADO FROM DUAL", Login.Strconn)
        Dim Row As System.Data.DataRow = DS.Tables(0).NewRow
        Row(0) = 0
        Row(1) = txtNomeArq.Text & ".PDF"
        Row(2) = txtEmails.Text
        Row(3) = Date.Now
        If ret = "" Then
            Row(4) = "Enviado com sucesso."
        Else
            Row(4) = ret
        End If
        DS.Tables(0).Rows.Add(Row)
        grdAcompanhamento.Grid.DataSource = DS.Tables(0)
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
    End Sub

    Private Sub btnImpViagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpViagem.Click
        PegaViagens()
        If Check = False Then
            MsgBox("Marque as viagens que deseja visualizar")
            Exit Sub
        End If
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF IN (" & Filtro & ") ORDER BY VIAGEM_REF")
    End Sub

    Sub PegaViagens()
        Nome = ""
        Check = False
        Dim z As Integer = 0
        Dim DT As System.Data.DataTable = grdViagens.Grid.DataSource
        For Each LINHA As System.Data.DataRow In DT.Rows
            If Icraft.IcftBase.NZ(LINHA!SEL, False) Then
                Check = True
                Filtro &= "'" & LINHA!VIAGEM_REF & "'"
                Nome &= "'" & LINHA!CARREGA_NOME & "'"
                If Nome <> "'" & LINHA!CARREGA_NOME & "'" Then
                    Nome &= "'" & LINHA!CARREGA_NOME & "'"
                End If
            End If
        Next
        Filtro = Filtro.Replace("''", "','")
        If Nome.Contains("''") Then
            Nome = Nome.Replace("''", "','")
        End If
    End Sub
    Sub PegaResumos()
        Check = False
        Dim z As Integer = 0
        Dim DT As System.Data.DataTable = grdResumo.Grid.DataSource
        For Each LINHA As System.Data.DataRow In DT.Rows
            If Icraft.IcftBase.NZ(LINHA!SEL, False) Then
                Check = True
                Filtro &= "'" & LINHA!XTA & "'"
            End If
        Next
        Filtro = Filtro.Replace("''", "','")
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT VIAGEM_REF FROM IM.VW_COL_INSTRUCAO WHERE NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) IN (" & Filtro & ")", Login.Strconn)
        Filtro = ""
        For Each LINHA As System.Data.DataRow In DS.Tables(0).Rows
            Filtro &= "'" & LINHA!VIAGEM_REF & "'"
        Next
        Filtro = Filtro.Replace("''", "','")
    End Sub

    Sub Restricao()
        Check = False
        If txtAssunto.Text = "" Then
            MsgBox("Preencha o campo assunto.")
            Check = True
        ElseIf txtEmails.Text = "" Then
            MsgBox("Preencha os emails que receberão esse relatório.")
            Check = True
        ElseIf txtRem.Text = "" Then
            MsgBox("Preencha o remetente.")
            Check = True
        ElseIf txtServidor.Text = "" Then
            MsgBox("Preencha o campo Servidor com o servidor SMTPI")
            Check = True
        End If
    End Sub

    Private Sub btnEnviaResumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaResumo.Click
        Restricao()
        PegaResumos()
        If Check = False Then
            MsgBox("Marque os resumos que deseja enviar")
            Exit Sub
        End If
        Dim Arq As New ArrayList
        Local.MostraRelatorio("RPTRESUMOCARREGAM", "VIAGEM_REF IN (" & Filtro & ") ORDER BY VIAGEM_REF", txtNomeArq.Text & ".PDF")
        Arq.Add(txtNomeArq.Text & ".PDF")
        For Each ITEM In Anexos
            Arq.Add(ITEM)
        Next
        Dim ret As String = Icraft.IcftBase.EnviaEmail(txtRem.Text, txtEmails.Text, txtAssunto.Text, txtCorpo.Text, VerificaPrioridade, txtServidor.Text, , , , , , True, , Arq)
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT 0 SEL, NULL DOCUMENTO, NULL EMAIL, NULL MOMENTO, NULL RESULTADO FROM DUAL", Login.Strconn)
        Dim Row As System.Data.DataRow = DS.Tables(0).NewRow
        Row(0) = 0
        Row(1) = txtNomeArq.Text & ".PDF"
        Row(2) = txtEmails.Text
        Row(3) = Date.Now
        If ret = "" Then
            Row(4) = "Enviado com sucesso."
        Else
            Row(4) = ret
        End If
        DS.Tables(0).Rows.Add(Row)
        grdAcompanhamento.Grid.DataSource = DS.Tables(0)
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
    End Sub

    Private Sub btnImpResumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpResumo.Click
        PegaResumos()
        If Check = False Then
            MsgBox("Marque os resumos que deseja visualizar")
            Exit Sub
        End If
        Local.MostraRelatorio("RPTRESUMOCARREGAM", "VIAGEM_REF IN (" & Filtro & ") ORDER BY VIAGEM_REF")
    End Sub

    Private Sub btnDiretorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorio.Click
        Try
            DDG.SelectedPath = txtNomeArq.Text
            If DDG.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtNomeArq.Text = DDG.SelectedPath
            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando diretório"))
        End Try
    End Sub

    Private Sub btnAnexar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexar.Click
        Try
            DDG.SelectedPath = lblAnexos.Text
            If DDG.ShowDialog() = Windows.Forms.DialogResult.OK Then
                lblAnexos.Text = DDG.SelectedPath
                ListaAnexos()
            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando diretório"))
        End Try
    End Sub
    Sub ListaAnexos()
        grpAnexos.Visible = True
        grdAnexos.SQL = "SELECT 0 SEL,  '' Arquivo FROM DUAL ARQS WHERE ROWNUM<1"
        grdAnexos.Usuario = Login.Usuario!USUARIO
        grdAnexos.StrConn = Login.Strconn
        grdAnexos.ColunaNomes = "Sel;Arquivo"
        grdAnexos.CamposExtend = "Geral.SEL|FORMATO:BOOL"
        grdAnexos.EsquemaGerador = Apl.Esquema
        grdAnexos.Sistema = Apl.Esquema
        grdAnexos.EsquemaPrinc = Apl.Esquema
        grdAnexos.Tabela = "Geral"
        grdAnexos.Bind()
        Dim dt As System.Data.DataTable = grdAnexos.Grid.DataSource
        Dim z As Integer = 1
        For Each Item As String In Icraft.IcftBase.ListaDir(lblAnexos.Text, "*.PDF", False)
            ' últimas colunas do grid sempre são posição e tipo
            dt.Rows.Add(0, Item, z, "det")
            z += 1
        Next
    End Sub
    Dim Anexos As New ArrayList
    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        Anexos.Clear()
        Dim Z As Integer = 0
        Dim DT As System.Data.DataTable = grdAnexos.Grid.DataSource
        For Each LINHA As System.Data.DataRow In DT.Rows
            If Icraft.IcftBase.NZ(LINHA!SEL, False) Then
                If Z = 0 Then
                    lblAnexos.Text = LINHA!ARQUIVO.Substring(LINHA!ARQUIVO.LastIndexOf("\") + 1) & vbCrLf
                    Anexos.Add(LINHA!ARQUIVO)
                Else
                    lblAnexos.Text &= LINHA!ARQUIVO.Substring(LINHA!ARQUIVO.LastIndexOf("\") + 1) & vbCrLf
                    Anexos.Add(LINHA!ARQUIVO)
                End If
                Z = +1
            End If
        Next
        grpAnexos.Visible = False
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        lblAnexos.Text = ""
        Anexos.Clear()
    End Sub
End Class