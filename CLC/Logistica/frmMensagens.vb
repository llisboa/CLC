Public Class frmMensagens

    Private Sub frmMensagens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO")
        AtualizarResumos()
        AtualizarViagens()
        Assinatura(False)
        EMAIL = Icraft.IcftBase.DSCarrega("SELECT CONFIG FROM IM.SYS_CONFIG_USUARIO WHERE USUARIO = '" & grdResumo.Usuario & "'  AND PARAM = 'Email'", Login.Strconn)
    End Sub
    Dim EMAIL As New System.Data.DataSet

    Function Assinatura(ByVal Envia As Boolean)
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT DESCR, CONFIG FROM IM.SYS_CONFIG_USUARIO WHERE USUARIO = '" & grdResumo.Usuario & "'  AND PARAM = 'Assinatura'", Login.Strconn)
        Dim ret As String = ""
        If Envia = True Then
            'ret = Corpo.Text.Replace(DS.Tables(0).Rows(0)("DESCR"), "")
            ret &= "<BR><BR><BR>" & DS.Tables(0).Rows(0)("CONFIG")
        Else
            'ret = Corpo.Text.Replace("<BR><BR><BR>" & DS.Tables(0).Rows(0)("CONFIG"), "")
            ret &= DS.Tables(0).Rows(0)("DESCR")
        End If
        Return ret
    End Function

    Sub AtualizarResumos()
        Try
            Dim SQL As String = "SELECT DISTINCT 0 SEL, NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) XTA, CARREGA_NOME FROM IM.VW_COL_INSTRUCAO WHERE CARREGA_NOME IS NOT NULL ORDER BY XTA DESC"
            grdResumo.SQL = SQL
            grdResumo.StrConn = Login.Strconn
            grdResumo.Usuario = Login.Usuario.ItemArray(1)
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
            grdViagens.Usuario = Login.Usuario.ItemArray(1)
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
    Dim Filtro As String = ""
    Dim Nome As String = ""
    Dim Check As Boolean = False
    Dim Ret As String = ""

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

    Sub Restricao()
        Check = False
        If txtAssunto.Text = "" Then
            MsgBox("Preencha o campo assunto.")
            Check = True
        ElseIf txtEmails.Text = "" Then
            MsgBox("Preencha os emails que receberão esse relatório.")
            Check = True
        End If
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
        Filtro = ""
        Dim z As Integer = 0
        Dim DT As System.Data.DataTable = grdResumo.Grid.DataSource
        For Each LINHA As System.Data.DataRow In DT.Rows
            If Icraft.IcftBase.NZ(LINHA!SEL, False) Then
                Check = True
                Filtro &= "'" & LINHA!XTA & "'"
            End If
        Next
        Filtro = Filtro.Replace("''", "','")
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT VIAGEM_REF FROM IM.VW_COL_INSTRUCAO WHERE NVL(TRUNC(CARREGA_ATA),TRUNC(CARREGA_ETA)) IN (" & Filtro & ") GROUP BY VIAGEM_REF", Login.Strconn)
        Filtro = ""
        For Each LINHA As System.Data.DataRow In DS.Tables(0).Rows
            Filtro &= "'" & LINHA!VIAGEM_REF & "'"
        Next
        Filtro = Filtro.Replace("''", "','")
    End Sub

    Private Sub btnEnviaViagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaViagem.Click
        Restricao()
        PegaViagens()
        Dim Temp As String = Icraft.IcftBase.TemporaryDir(System.IO.Path.GetTempPath)
        MkDir(Temp)
        Dim NomeArq As String = "Programação de Carregamento_" & Date.Now
        NomeArq = Icraft.IcftBase.TrocaTexto(NomeArq, " ", "_", "/", "_", ":", "_")
        If Check = False Then
            MsgBox("Marque os resumos que deseja enviar")
            Exit Sub
        End If
        Dim Arq As New ArrayList
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF IN (" & Filtro & ") AND CARREGA_NOME IN (" & Nome & ") ORDER BY VIAGEM_REF", Temp & "\" & NomeArq & ".PDF")
        Arq.Add(Temp & "\" & NomeArq & ".PDF")
        Ret = Icraft.IcftBase.EnviaEmail(EMAIL.Tables(0).Rows(0)(0), txtEmails.Text, txtAssunto.Text, Corpo.Text.Replace(Chr(13), "<br/>") & Assinatura(True), VerificaPrioridade, "10.0.0.5", , txtCC.Text, , , , True, , Arq)
        Filtro = ""
        Nome = ""
        Dim SQL As String = "SELECT 0 SEL, NULL DOCUMENTO, NULL EMAIL, NULL MOMENTO, NULL RESULTADO FROM DUAL"
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega(SQL, Login.Strconn)
        Dim Row As System.Data.DataRow = DS.Tables(0).NewRow
        Row(0) = 0
        Row(1) = Temp & "\" & NomeArq & ".PDF"
        Row(2) = txtEmails.Text
        Row(3) = Date.Now
        If Ret = "" Then
            Row(4) = "Enviado com sucesso."
            Try
                System.IO.File.Delete(Temp & "\" & NomeArq & ".PDF")
                RmDir(Temp)
            Catch ex As Exception
            End Try
        Else
            Row(4) = Ret
        End If
        DS.Tables(0).Rows.Clear()
        DS.Tables(0).Rows.Add(Row)
        AtualizaAcompanhamento(SQL, DS.Tables(0))
        Assinatura(False)
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
    End Sub

    Private Sub btnImpViagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpViagem.Click
        PegaViagens()
        If Check = False Then
            MsgBox("Marque as viagens que deseja visualizar")
            Exit Sub
        End If
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF IN (" & Filtro & ") AND CARREGA_NOME IN (" & Nome & ") ORDER BY VIAGEM_REF")
    End Sub

    Private Sub btnEnviaResumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaResumo.Click
        Restricao()
        PegaResumos()
        Assinatura(True)
        Dim Temp As String = Icraft.IcftBase.TemporaryDir(System.IO.Path.GetTempPath)
        MkDir(Temp)
        Dim NomeArq As String = "Resumo de Carregamento_" & Date.Now
        NomeArq = Icraft.IcftBase.TrocaTexto(NomeArq, " ", "_", "/", "_", ":", "_")
        If Check = False Then
            MsgBox("Marque os resumos que deseja enviar")
            Exit Sub
        End If
        Dim Arq As New ArrayList
        Local.MostraRelatorio("RPTRESUMOCARREGAM", "VIAGEM_REF IN (" & Filtro & ") ORDER BY VIAGEM_REF", Temp & "\" & NomeArq & ".PDF")
        Arq.Add(Temp & "\" & NomeArq & ".PDF")
        Ret = Icraft.IcftBase.EnviaEmail(EMAIL.Tables(0).Rows(0)(0), txtEmails.Text, txtAssunto.Text, Corpo.Text, VerificaPrioridade, "SMTPI", , txtCC.Text, , , True, , Arq)
        Filtro = ""
        Nome = ""
        Dim SQL As String = "SELECT 0 SEL, NULL DOCUMENTO, NULL EMAIL, NULL MOMENTO, NULL RESULTADO FROM DUAL"
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega(SQL, Login.Strconn)
        Dim Row As System.Data.DataRow = DS.Tables(0).NewRow
        Row(0) = 0
        Row(1) = Temp & "\" & NomeArq & ".PDF"
        Row(2) = txtEmails.Text
        Row(3) = Date.Now
        If ret = "" Then
            Row(4) = "Enviado com sucesso."
            Try
                System.IO.File.Delete(Temp & "\" & NomeArq & ".PDF")
                RmDir(Temp)
            Catch ex As Exception
            End Try
        Else
            Row(4) = Ret
        End If
        DS.Tables(0).Rows.Clear()
        DS.Tables(0).Rows.Add(Row)
        AtualizaAcompanhamento(SQL, DS.Tables(0))
        Assinatura(False)
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
    End Sub

    Sub AtualizaAcompanhamento(ByVal SQL As String, ByVal DTB As System.Data.DataTable)
        grdAcompanhamento.SQL = SQL
        grdAcompanhamento.StrConn = Login.Strconn
        grdAcompanhamento.Usuario = Login.Usuario!usuario
        grdAcompanhamento.ColunaNomes = "Sel;Arquivo;Para;Momento;Resultado"
        grdAcompanhamento.CamposExtend = "Geral.SEL|FORMATO:BOOL"
        grdAcompanhamento.EsquemaGerador = Apl.Esquema
        grdAcompanhamento.Sistema = Apl.Esquema
        grdAcompanhamento.EsquemaPrinc = Apl.Esquema
        grdAcompanhamento.Tabela = "Geral"
        grdAcompanhamento.Bind()
        grdAcompanhamento.Grid.DataSource = DTB
        If grdAcompanhamento.Grid.Rows(0).Cells("Resultado").Value <> "Enviado com sucesso." Then
            grdAcompanhamento.Grid.Rows(0).Cells("Resultado").Style.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnImpResumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpResumo.Click
        PegaResumos()
        If Check = False Then
            MsgBox("Marque os resumos que deseja visualizar")
            Exit Sub
        End If
        Local.MostraRelatorio("RPTRESUMOCARREGAM", "VIAGEM_REF IN (" & Filtro & ") ORDER BY VIAGEM_REF")
    End Sub

    Sub Reenvia()
        Dim Arq As New ArrayList
        Arq.Add(grdAcompanhamento.Grid.Rows(0).Cells(1).Value)
        Ret = Icraft.IcftBase.EnviaEmail(EMAIL.Tables(0).Rows(0)(0), grdAcompanhamento.Grid.Rows(0).Cells(2).Value, txtAssunto.Text, Corpo.Text, VerificaPrioridade, "SMTPI", , txtCC.Text, , , , True, , Arq)
    End Sub

    Private Sub btnReenvia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenvia.Click
        Reenvia()
    End Sub
End Class