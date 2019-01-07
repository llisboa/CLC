Imports System.Drawing.Printing
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRel

    Dim Rels As New Dictionary(Of String, Local.RelDets)
    Public ReadOnly Property RelatorioAtual() As String
        Get
            If IsNothing(lstRel.SelectedItem) Then
                Return ""
            End If
            Dim Pos As Integer = InStr(lstRel.SelectedItem, "-")
            Dim NomeRel As String = Mid(lstRel.SelectedItem, Pos + 1)
            Return NomeRel
        End Get
    End Property

    Private Sub frmRel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstRel.Items.Clear()
        For Each LINHA As System.Data.DataRow In Icraft.IcftBase.DSCarrega("SELECT ORDEM, OBJETO, PROP_EXTEND FROM " & Apl.Esquema & ".GER_ADICIONAL_OBJ WHERE TIPO='RELATÓRIO' ORDER BY ORDEM, OBJETO", Login.Strconn).Tables(0).Rows
            Dim R As New Local.RelDets("Ordem:" & LINHA!ORDEM & ";Rpt:" & LINHA!OBJETO & ";" & LINHA!PROP_EXTEND)
            lstRel.Items.Add(Format(LINHA!ORDEM, "00") & "-" & R.Etiq)
            Rels.Add(R.Etiq, R)
        Next
        FF.FiltroTipo = 1

        For Each Impressora As String In PrinterSettings.InstalledPrinters
            lstImp.Items.Add(Impressora)
        Next
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Dim JaExec As Boolean = False

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        Try
            If RelatorioAtual = "" Then
                MsgBox("Selecione um relatório antes ou dê duplo-clique sobre ele.")
                Exit Sub
            End If
            If JaExec Then
                MsgBox("Aguarde. Construção em andamento. Inicie novo procedimento somente após a conclusão deste.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Visualização de Relatório")
            Else
                JaExec = True
                Try
                    Dim NomeRel As String = RelatorioAtual
                    Local.MostraRelatorio(Rels(NomeRel).Etiq, Rels(NomeRel).Rpt, Rels(NomeRel).DS, Rels(NomeRel).Pesquisas, FF)
                Catch EX As Exception
                    frmAlerta.HIDE()
                    JaExec = False
                    Throw EX
                End Try
                JaExec = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao visualizar relatório: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExpExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpExcel.Click
        Try
            If RelatorioAtual = "" Then
                MsgBox("Selecione um relatório antes ou dê duplo-clique sobre ele.")
                Exit Sub
            End If
            If JaExec Then
                MsgBox("Aguarde. Construção em andamento. Inicie novo procedimento somente após a conclusão deste.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Exportar para Excel")
            Else
                JaExec = True
                Try
                    Dim NomeRel As String = RelatorioAtual
                    Dim Rel As String = Rels(NomeRel).Etiq
                    frmAlerta.Show("Planilha sendo criada. Aguarde.", Rel)
                    Dim DS As System.Data.DataSet = Local.PreparaDS(Rel, Rels(NomeRel).DS, Rels(NomeRel).Pesquisas, FF, "")
                    Dim Arq As String = InputBox("Informe nome arquivo XLS:", "Exportar para Excel")
                    Icraft.IcftBase.ExportaParaXls(DS.Tables(0), Arq)
                Catch EX As Exception
                    frmAlerta.HIDE()
                    JaExec = False
                    Throw EX
                End Try
                frmAlerta.HIDE()
                JaExec = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar exportar para excel: " & ex.Message)
        End Try
    End Sub

    Private Sub lstRel_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstRel.MouseDoubleClick
        btnVisualiza_Click(sender, Nothing)
    End Sub

    Private Sub lstRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRel.SelectedIndexChanged
        Try
            FF.StrConn = Login.Strconn
            FF.EsquemaGerador = Apl.Esquema
            FF.Sistema = Apl.Esquema
            FF.EsquemaPrinc = Apl.Esquema
            Dim TTB As String = Rels(RelatorioAtual).Pesquisas(Rels(RelatorioAtual).Pesquisas.Keys(0))
            TTB = Local.TrimCasado(TTB, "(", ")")

            If TTB.StartsWith("SELECT ", StringComparison.OrdinalIgnoreCase) Then
                FF.ConsultaSQL = TTB
                FF.Tabela = Rels(RelatorioAtual).BuscaDefs
            Else
                FF.ConsultaSQL = ""

                Dim MMT As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(TTB, "(?<esquema>\w*).(?<tabela>\w*)")

                If MMT.Groups("esquema").Value <> "" AndAlso MMT.Groups("tabela").Value <> "" Then
                    FF.EsquemaPrinc = MMT.Groups("esquema").Value
                    FF.Tabela = MMT.Groups("tabela").Value
                Else
                    FF.Tabela = TTB
                End If
            End If
            If Rels(RelatorioAtual).FiltroCamposSQL <> "" Then
                FF.CamposSQL = Replace(Rels(RelatorioAtual).FiltroCamposSQL, ",", ";")
            End If
            FF.Bind()
        Catch
            FF.EsquemaGerador = ""
            FF.Sistema = ""
            FF.EsquemaPrinc = ""
            FF.Tabela = ""
            FF.ConsultaSQL = ""
            FF.Bind()
            JaExec = False
        End Try
    End Sub


    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Count = 0
        'If JaExec Then
        '    MsgBox("Aguarde. Construção em andamento. Inicie novo procedimento somente após a conclusão deste.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Visualização de Relatório")
        'Else
        '    JaExec = True
        '    Local.MostraRelatorio(Rels(lstRel.SelectedItem).Etiq, Rels(lstRel.SelectedItem).Rpt, Rels(lstRel.SelectedItem).DS, Rels(lstRel.SelectedItem).Pesquisas, FF, "", "c:\rel.pdf")
        '    Anexos.Add("c:\rel.pdf")
        Dim ret As String = Icraft.IcftBase.EnviaEmail(txtREM.Text, txtEMAIL.Text, txtASSUNTO.Text, "", Net.Mail.MailPriority.Normal, txtSMTP.Text, , , , txtUSUARIO.Text, txtSENHA.Text, True, , Anexos)
        'JaExec = False
        'End If
    End Sub

    Sub Imprimir()
        Local.MostraRelatorio(Rels(lstRel.SelectedItem).Etiq, Rels(lstRel.SelectedItem).Rpt, Rels(lstRel.SelectedItem).DS, Rels(lstRel.SelectedItem).Pesquisas, FF, "", "c:\" & lstRel.SelectedItem.ToString & ".pdf")
        Dim RELOB As Object = Apl.ReportPorNome("")
        Dim P As New Process
        P.StartInfo.UseShellExecute = True
        P.StartInfo.Verb = "print"
        P.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        P.StartInfo.FileName = "C:\TESTE_PDF.PDF"
        P.Start()
        'P.Kill()
    End Sub

    'Private Sub PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
    '    Dim PosicaoVertical As Single = 0
    '    Dim contador As Single = 0
    '    Dim linha As String = ""
    '    While Not (linha Is Nothing)
    '        linha = ARQ.ReadLine()
    '        PosicaoVertical = e.MarginBounds.Top + contador * TamFonte.GetHeight(e.Graphics)
    '        e.Graphics.DrawString(linha, TamFonte, Brushes.Black, e.MarginBounds.Left, PosicaoVertical)
    '        contador += 1
    '    End While
    'End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Imprimir()
    End Sub
    Dim Anexos As New ArrayList
    Dim Count As Integer = 0

    Private Sub btnAnexar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexar.Click
        Try
            Count += 1
            Dim lbl As New Windows.Forms.Label
            lbl.AutoSize = True
            lbl.Name = "lbl" & Count
            If DDG.ShowDialog() = Windows.Forms.DialogResult.OK Then
                lbl.Text = DDG.FileName
                Anexos.Add(lbl.Text)
                If Panel2.Controls.Count > 0 Then
                    lbl.Location = New System.Drawing.Point(0, lbl.Location.Y + (Count * 15))
                    Panel2.Controls.Add(lbl)
                Else
                    lbl.Location = New System.Drawing.Point(0, lbl.Location.Y + (Count * 15))
                    Panel2.Controls.Add(lbl)
                End If

            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando diretório"))
        End Try
    End Sub

    Public Sub Remove(ByVal sender As Object, ByVal e As EventArgs) Handles lbl.Click
        Panel2.Controls.Remove(lbl)
    End Sub

    Friend WithEvents lbl As Windows.Forms.Label
End Class