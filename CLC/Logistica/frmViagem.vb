Imports Icraft.IcftBase

Public Class frmViagem

    Class Auto
        Public Criado As Local.GeraFormApl = Nothing
        Sub New(ByVal Formulario As Windows.Forms.Form, ByVal Sistema As String, ByVal EsquemaPrinc As String, ByVal EsquemaGerador As String, ByVal Tabela As String, ByVal StrConn As Object, Optional ByVal LargEtiq As Integer = 0, Optional ByVal LargCampo As Integer = 0, Optional ByVal UsuarioConfig As String = "", Optional ByVal ContainerParaCriacao As Object = Nothing, Optional ByVal Consulta As String = "")
            Criado = New Local.GeraFormApl(Formulario, Sistema, EsquemaPrinc, EsquemaGerador, Tabela, StrConn, UCase(Login.Usuario!USUARIO), LargEtiq, LargCampo, UsuarioConfig, ContainerParaCriacao, Consulta)
            AddHandler Criado.MostraStatus, AddressOf MostraStatus
        End Sub
        Public Shared Sub MostraStatus(ByVal Texto As String)
            Princ.lblStatus.Text = Texto
        End Sub
    End Class
    Dim f As Auto
    Dim Ativo As Icraft.IcftFOpc = Nothing
    Dim Grd As Icraft.IcftFGrid2
    Private Sub frmViagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlStatus.Visible = False
        pnlEscalas.Visible = False
        If Local.Filtro <> "" Then
            f = New Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "VIAGEM", Login.Strconn, , , Local.UsuarioConfig.ToStyleStr, pnlGeral, "SELECT * FROM IM.VIAGEM WHERE REF = '" & Local.Filtro & "'")
            Local.Filtro = ""
        Else
            f = New Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "VIAGEM", Login.Strconn, , , Local.UsuarioConfig.ToStyleStr, pnlGeral)
        End If
        Me.f.Criado.CarregaCamposEmGeral()
        Grd = f.Criado.Frm.Controls.Find("gtbORDEM_VENDA_EMB", True)(0)
        AddHandler Grd.DepoisDeCarregar, AddressOf DepoisDeCarregar
        AddHandler Grd.AposAtualizarInfo, AddressOf MostraInfo
        AddHandler Me.f.Criado.Frm.AoSolicitarDuplicacao, AddressOf Copia
    End Sub

    Sub MostraInfo(ByVal lbl As Label)
        Dim Masc As String = " \| Itens=\(.*?\)"
        If System.Text.RegularExpressions.Regex.Match(lbl.Text, Masc).Success Then
            lbl.Text = System.Text.RegularExpressions.Regex.Replace(lbl.Text, Masc, Total)
        Else
            lbl.Text &= " " & Total
        End If
    End Sub

    Public Total As String
    Private Sub DepoisDeCarregar()
        Try
            Dim pnl As System.Windows.Forms.Panel = Grd.Controls.Find("Panel1", True)(0)
            Dim lbl As Windows.Forms.Label = pnl.Controls.Find("lblInfo", True)(0)
            Dim QtdEmb As Double = 0
            Dim QtdVol As Double = 0
            Dim QtdLiq As Double = 0
            Dim QtdBrt As Double = 0
            For Each ROW As DataGridViewRow In Grd.Grid.Rows
                If Not ROW.Cells("STATUS_COD").Value = "CANCELADO" Then
                    QtdEmb += Icraft.IcftBase.NZV(ROW.Cells(10).Value, 0.0#)
                    QtdVol += Icraft.IcftBase.NZV(ROW.Cells(11).Value, 0.0#)
                    QtdLiq += Icraft.IcftBase.NZV(ROW.Cells(12).Value, 0.0#)
                    QtdBrt += Icraft.IcftBase.NZV(ROW.Cells(13).Value, 0.0#)
                End If
            Next
            Total = " | Itens=(Qtd Embarcada: " & QtdEmb & " Qtd Volumes: " & QtdVol & " Peso Líquido: " & QtdLiq & " Peso Bruto: " & QtdBrt & ")"
        Catch
        End Try
    End Sub

    Sub Copia(ByRef Padrao As Boolean)
        Padrao = False
        pnlOrdemCriada.Visible = True
        Dim CTL As Button = f.Criado.Frm.Controls.Find("btnDuplicar", True)(0)
        pnlOrdemCriada.Top = CTL.Top
        pnlOrdemCriada.Left = CTL.Left
        pnlOrdemCriada.Top = Icraft.IcftBase.TopAcum(CTL) - (pnlOrdemCriada.Height + CTL.Top)
        pnlOrdemCriada.Left = Icraft.IcftBase.LeftAcum(CTL) + (CTL.Left - CTL.Width)
        pnlOrdemCriada.Show()
        Form.Conteudo(pnlOrdemCriada, "ORD") = DSConfigUsuario(Login.Strconn, Login.Usuario("USUARIO"), "VIAGEM_COPIA_REG", "IM.SYS_CONFIG_USUARIO")
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim Chave As String = f.Criado.ChaveConcatStr
        Local.MostraRelatorio("RPTVIAGEMFECH", "VIAGEM_REF = '" & Icraft.IcftBase.Tratex(Chave) & "'")
    End Sub

    Private Sub btnCarrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarrega.Click
        If MsgBox("Confirma carregamento de todos os itens?", MsgBoxStyle.YesNo, "Confirmar carregamento.") = MsgBoxResult.Yes Then
            Dim DS As System.Data.DataSet = DSCarrega("SELECT VIAGEM_REF V_REF, ORDEM_VENDA_REF OV_REF, ORDEM_VENDA_ITEM OVI FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "'", Login.Strconn)
            For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
                DSGrava("UPDATE IM.ORDEM_VENDA_EMB SET STATUS_COD = 'CARREGADO' WHERE VIAGEM_REF =:VIAGEM_REF AND ORDEM_VENDA_REF =:OV_REF AND ORDEM_VENDA_ITEM =:OVI", Login.Strconn, ":VIAGEM_REF", ROW!V_REF, ":OV_REF", ROW!OV_REF, ":OVI", ROW!OVI)
            Next
            MsgBox("Itens carregados com sucesso!")
            Me.f.Criado.CarregaCamposEmGeral()
        End If
    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        If MsgBox("Esta operação irá cancelar todos os itens do carregamento. Confirma canelamento?", MsgBoxStyle.YesNo, "Confirmar cancelamento.") = MsgBoxResult.Yes Then
            Dim DS As System.Data.DataSet = DSCarrega("SELECT VIAGEM_REF V_REF, ORDEM_VENDA_REF OV_REF, ORDEM_VENDA_ITEM OVI FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "'", Login.Strconn)
            For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
                DSGrava("UPDATE IM.ORDEM_VENDA_EMB SET STATUS_COD = 'CANCELADO' WHERE VIAGEM_REF =:VIAGEM_REF AND ORDEM_VENDA_REF =:OV_REF AND ORDEM_VENDA_ITEM =:OVI", Login.Strconn, ":VIAGEM_REF", ROW!V_REF, ":OV_REF", ROW!OV_REF, ":OVI", ROW!OVI)
            Next
            MsgBox("Itens cancelados com sucesso!")
            Me.f.Criado.CarregaCamposEmGeral()
        End If
    End Sub

    Private Sub btnCancParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancParcial.Click
        pnlStatus.Show()
        Dim DS As System.Data.DataSet = DSCarrega("SELECT COD FROM IM.status_carrega", Login.Strconn)
        For i As Integer = 0 To DS.Tables(0).Rows.Count - 1
            cbxStatus.Items.Add(DS.Tables(0).Rows(i)(0))
        Next
        pnlStatus.Visible = True
        chkItens.SQL = "SELECT ORDEM_VENDA_REF || ' | ' || ORDEM_VENDA_ITEM REF_ITEM FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF ='" & f.Criado.ChaveConcatStr & "'"
        chkItens.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        chkItens.StrConn = Login.Strconn
        chkItens.BIND()
    End Sub

    Private Sub btnFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFecha.Click
        pnlStatus.Visible = False
        pnlStatus.Hide()
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        Dim Ar As ArrayList = SplitMultiDelim(TrocaTexto(chkItens.Text, " ", ""), ";-|".Split("-"))
        Dim DS As System.Data.DataSet = DSCarrega("SELECT ORDEM_VENDA_REF OV_REF, ORDEM_VENDA_ITEM OVI FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "'", Login.Strconn)
        For i As Integer = 0 To Ar.Count - 1 Step 2
            DSGrava("UPDATE IM.ORDEM_VENDA_EMB SET STATUS_COD =:STATUS WHERE VIAGEM_REF =:VIAGEM AND ORDEM_VENDA_REF =:OV AND ORDEM_VENDA_ITEM =:ITEM", Login.Strconn, ":STATUS", cbxStatus.SelectedItem, ":VIAGEM", f.Criado.ChaveConcatStr, ":OV", Ar(i), ":ITEM", Ar(i + 1))
        Next
        MsgBox("Alterações efetuadas com sucesso!")
        Me.f.Criado.CarregaCamposEmGeral()
    End Sub

    Private Sub btnAgendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgendar.Click
        pnlEscalas.Show()
        pnlEscalas.Location = New System.Drawing.Point(x:=287, y:=0)
        chkEscalas.SQL = "SELECT ESCALA || ' - ' || CIA_COD_LOCAL FROM IM.VIAGEM_ESCALA WHERE VIAGEM_REF ='" & f.Criado.ChaveConcatStr & "'"
        chkEscalas.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        chkEscalas.StrConn = Login.Strconn
        chkEscalas.BIND()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pnlEscalas.Visible = False
        pnlEscalas.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DS As System.Data.DataSet = DSCarrega("SELECT ESCALA, ETA FROM IM.VIAGEM_ESCALA WHERE VIAGEM_REF LIKE '" & f.Criado.ChaveConcatStr & "' AND ESCALA > " & chkEscalas.Text.Substring(0, chkEscalas.Text.IndexOf("-") - 1), Login.Strconn)
        Dim DS_ANT As System.Data.DataSet = DSCarrega("SELECT VIAGEM_REF, ESCALA, CIA_COD_LOCAL, ETA FROM IM.VIAGEM_ESCALA WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "' AND ESCALA = " & chkEscalas.Text.Substring(0, chkEscalas.Text.IndexOf("-") - 1), Login.Strconn)
        Dim EscalaBase As System.Data.DataRow = DS_ANT.Tables(0).Rows(0)
        Dim EtaNovo As Date = txtEta.Text
        Dim Intervalo As Integer = DateDiff(DateInterval.Day, EscalaBase!ETA, EtaNovo)
        Dim User As String = UCase(Login.Usuario!USUARIO)
        Dim Motivo As String = txtMotivo.Text
        Dim Momento As Date = New Date
        Momento = Now
        DSGrava("UPDATE IM.VIAGEM_ESCALA SET ETA = '" & EtaNovo & "' , OBS = '" & Momento & " | " & User & " | " & Motivo & "' WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "' AND ESCALA = " & chkEscalas.Text.Substring(0, chkEscalas.Text.IndexOf("-") - 1), Login.Strconn)
        For Each ESCALA As System.Data.DataRow In DS.Tables(0).Rows
            Dim NovaETA As Date = DateAdd(DateInterval.Day, Intervalo, ESCALA!ETA)
            DSGrava("UPDATE IM.VIAGEM_ESCALA SET ETA = '" & NovaETA & "', OBS = '" & Momento & " | " & User & " | " & Motivo & "' WHERE VIAGEM_REF = '" & f.Criado.ChaveConcatStr & "' AND ESCALA = " & ESCALA!ESCALA, Login.Strconn)
        Next
        MsgBox("Escalas alteradas com sucesso!")
        Me.f.Criado.CarregaCamposEmGeral()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pnlOrdemCriada.Visible = False
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        If MsgBox("Confirmar cópia da viagem, escala e conhecimentos?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DSConfigUsuario(Login.Strconn, Login.Usuario("USUARIO"), "VIAGEM_COPIA_REG", "IM.SYS_CONFIG_USUARIO") = Form.Conteudo(pnlOrdemCriada, "ORD")
            Dim Ordem As String = f.Criado.ChaveConcatStr
            Dim ORDEMNOVA As String = Icraft.IcftBase.DSRef(ORDPREFIXO.Text.ToUpper(), "REF", "IM.VIAGEM", Login.Strconn)
            DSGrava("BEGIN IM.LB.VIAGEM_COPIA('" & Ordem & "', '" & ORDEMNOVA & "');END;", Login.Strconn)
            f.Criado.Frm.AtualizaChaves(ORDEMNOVA)
        End If
        pnlOrdemCriada.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim VIAGEM As String = f.Criado.ChaveConcatStr
        Dim DS As System.Data.DataSet = DSCarrega("SELECT ORDEM_VENDA_REF || '/' || ORDEM_VENDA_ITEM VENDA FROM IM.ORDEM_VENDA_EMB WHERE VIAGEM_REF = '" & VIAGEM & "'", Login.Strconn)
        Dim CRIT As String = ""
        For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
            CRIT &= "'" & ROW!VENDA & "', "
        Next
        CRIT = CRIT.Remove(Len(CRIT) - 2)
        CRIT = "VENDA || '/' || ITEM IN (" & CRIT & ") AND CFOP = '" & f.Criado.ChaveConcatStr & "'"
        Local.MostraRelatorio("RPTPESOREAL", CRIT)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Assunto As String = InputBox("Digite o Assunto da Mensagem", My.Application.Info.Title, , , )
        Dim Liq As New ArrayList
        Dim Brt As New ArrayList
        Dim Item As New ArrayList
        Dim Vol As New ArrayList
        For Each ROW As DataGridViewRow In Grd.Grid.Rows
            If Not ROW.Cells(16).Value = "CANCELADO" Then
                Liq.Add(Icraft.IcftBase.NZV(ROW.Cells(12).Value, 0.0#))
                Brt.Add(Icraft.IcftBase.NZV(ROW.Cells(13).Value, 0.0#))
                Item.Add(Icraft.IcftBase.NZV(ROW.Cells(2).Value, "") & " | " & Icraft.IcftBase.NZV(ROW.Cells(3).Value, ""))
                Vol.Add(Icraft.IcftBase.NZV(ROW.Cells(11).Value, 0.0#))
            End If
        Next
        Dim Header As String = ""
        Dim Corpo As String = ""
        Header = "<h2>Peso Real Atualizado!</h2><br/><b>Atualizado por:</b> " & Login.Usuario!usuario & "<br/><b>Momento:</b> " & Date.Now & "<br/><br/><b>Viagem:</b> " & f.Criado.ChaveConcatStr & "</br><br/>"
        For x As Integer = 0 To Item.Count - 2
            Corpo &= "<br/><b>Item:</b> " & Item(x) & "<br/> <b>Qtd Volumes:</b> " & Vol(x) & " <b>Peso Líquido:</b> " & Liq(x) & " <b>Peso Bruto:</b> " & Brt(x) & "<br/></br>"
        Next
        Dim Mensagem As String = "<font face=Calibri> " & Header & Corpo & " </font>"
        Dim ret As String
        ret = Icraft.IcftBase.EnviaEmail("IMSC <imsc@intermesa.com.br>", "Valéria Gouveia <valeria.gouveia@intermesa.com.br>; IMSC <imsc@intermesa.com.br>", Assunto & " | Viagem: " & f.Criado.ChaveConcatStr, Mensagem, Net.Mail.MailPriority.High, "smtpi", , "Ronald Borges <ronald.borges@intermesa.com.br>;Faturamento <faturamento@intermesa.com.br>", , , , True, , )
        If ret = "" Then
            MsgBox("Mensagem enviada com sucesso!")
        Else
            MsgBox("Erro ao enviar mensagem! " & ret)
        End If
    End Sub
End Class