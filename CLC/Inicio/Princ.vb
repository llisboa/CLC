Public Class Princ

    Private Sub Princ_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Opacity = 0 Then
            Login.Focus()
        End If
    End Sub

    Sub OutrosFecha()
        Try
            Login.Close()
        Catch
        End Try
        Try
            Importa.Close()
        Catch
        End Try
    End Sub

    Private Sub Princ_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(Login.Strconn) Then
            e.Cancel = True
            If Not MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo, "Saída do Sistema") = MsgBoxResult.Yes Then
                Exit Sub
            End If
            OutrosFecha()
        End If
    End Sub

    Public Sub AutoAtt()
        Try
            Icraft.IcftBase.EliminarProcesso("CLC_TEMP")
            Dim DirTemp As String = Environ("TEMP")
            Dim Arq As String = "clc.zip"
            Dim ArqBackup As String = Icraft.IcftBase.FileExpr(DirTemp, "clc_backup_" & Format(Now, "yyyy_mm_dd") & ".zip")
            Dim ArqDown As String = "~/down/" & Arq
            Dim ArqCompress As String = Icraft.IcftBase.FileExpr(DirTemp, Arq)
            Dim DirTempCLC As String = Icraft.IcftBase.FileExpr(DirTemp, "CLC")
            Dim ArqsMasc As String = Icraft.IcftBase.FileExpr(Local.BaseDir, "*.*")

            Dim NomeServ As String = Icraft.IcftBase.TextoCondicional(Icraft.IcftBase.WebConf("atualiza_config_web"), Join(Icraft.IcftBase.IPLocal().ToArray, "|"))
            NomeServ = LCase(NomeServ)

            Dim www As New www.ConsultaSoapClient
            Dim AppMomServer As Date = Nothing

            If NomeServ Like "\\*" Or NomeServ Like "*:\*" Then
                Try
                    AppMomServer = System.IO.File.GetLastWriteTime(NomeServ)
                Catch
                End Try
                If AppMomServer = CDate(Nothing) Then
                    AppMomServer = System.IO.File.GetCreationTime(NomeServ)
                End If
            ElseIf NomeServ = "www.intermesa" Then
                AppMomServer = www.ArquivoMomentoModif(ArqDown)
            Else
                MsgBox("Não foi possível encontrar servidor '" & NomeServ & "' para atualização. Informe-se com suporte.")
                Exit Sub
            End If

            If DateDiff(DateInterval.Minute, System.IO.File.GetLastWriteTime(Local.NomeExec), AppMomServer) >= 2 Then
                If MsgBox("Deseja atualizar seu aplicativo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try

                        frmAlerta.Show("CLC novo sendo baixado. Aguarde...", "Atualizando Aplicativo")

                        Try
                            If NomeServ Like "\\*" Or NomeServ Like "*:\*" Then
                                FileCopy(NomeServ, ArqCompress)
                            ElseIf NomeServ = "www.intermesa" Then
                                Icraft.IcftBase.SalvaByteArray(www.ArquivoBin(Arq), ArqCompress)
                            End If
                        Catch EX As Exception
                            MsgBox("Falha ao tentar baixar arquivo. Tente novamente. Persistindo contacte suporte (erro:" & Icraft.IcftBase.MessageEx(EX, " atualizando apl") & ").")
                        End Try

                        Try
                            If System.IO.File.Exists(ArqBackup) Then
                                Kill(ArqBackup)
                            End If
                        Catch ex As Exception
                            MsgBox("Falha ao eliminar arquivo de backup. Tente novamente. Persistindo contacte suporte (erro:" & Icraft.IcftBase.MessageEx(ex, " atualizando apl") & ").")
                            Exit Sub
                        End Try

                        Try
                            frmAlerta.Show("CLC sendo backupeado para " & ArqBackup, "Atualizando Aplicativo")
                            Icraft.IcftBase.DosShell("zip", """" & ArqBackup & """ """ & ArqsMasc & """", "", "", "")
                            Icraft.IcftBase.Espera(1)
                        Catch ex As Exception
                            MsgBox("Falha ao compactar arquivos em backup. Tente novamente. Persistindo contacte suporte (erro:" & Icraft.IcftBase.MessageEx(ex, " atualizando apl") & ").")
                            Exit Sub
                        End Try

                        Try
                            frmAlerta.Show("Descomprimindo novos arquivos.", "Atualizando Aplicativo")
                            If System.IO.Directory.Exists(DirTempCLC) Then
                                Icraft.IcftBase.DosShell("CMD.EXE", "/C DEL """ & DirTempCLC & """ /S /F /Q", "", "", "")
                            End If
                            Icraft.IcftBase.DosShell("unzip", "-q -d """ & DirTempCLC & """ """ & ArqCompress & """", "", "", "")
                            Try
                                frmAlerta.HIDE()
                                OutrosFecha()
                                System.Diagnostics.Process.Start(Icraft.IcftBase.FileExpr(DirTempCLC, "CLC_TEMP.exe"), """" & Local.BaseDir & """ """ & ArqBackup & """")
                            Catch
                            End Try
                        Catch ex As Exception
                            MsgBox("Falha ao descompactar arquivos novos. Arquivos atuais foram danificados. Recupere backup em '" & ArqCompress & "' (erro:" & Icraft.IcftBase.MessageEx(ex, " atualizando apl") & ").")


                            ' POSTERIORMENTE, COLOCAR RECUPERAÇÃO DE BACKUP AUTOMÁTICO
                            ' LIMPAR DIRETÓRIO NOVAMENTE E DEPOIS RECUPERAR ÚLTIMO BACKUP SALVO


                            Exit Sub
                        End Try

                        Login.Strconn = Nothing
                        Application.ExitThread()


                    Catch
                    End Try
                End If
            Else
                MsgBox("Não há atualizações disponíveis.")
            End If


        Catch ex As Exception
            MsgBox("Atualização indisponível no momento. Tente mais tarde (erro: " & Icraft.IcftBase.MessageEx(ex) & ")")
            Exit Sub
        End Try

    End Sub

    Private Sub Princ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Application.ThreadException, AddressOf Local.Trata_Thread_UnhandledException
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf Local.Trata_Domain_UnhandledException
        Me.Text = My.Application.Info.ProductName & " - " & Icraft.IcftBase.VersaoApl()

        If Icraft.IcftBase.Compare(System.IO.Path.GetFileName(Local.NomeExec), "CLC_TEMP.EXE") Then
            Try
                Icraft.IcftBase.EliminarProcesso("CLC")
                Me.Show()

                Dim DirOrig As String = My.Application.CommandLineArgs(0)
                Dim ArqBackup As String = My.Application.CommandLineArgs(1)

                frmAlerta.Show("Atualizando diretório original. Aguarde...", "Atualizando Aplicativo")
                Icraft.IcftBase.Espera(2)
                Icraft.IcftBase.DosShell("CMD.EXE", "/C DEL """ & DirOrig & """ /S /F /Q", "", "", "")
                Icraft.IcftBase.DosShell("XCOPY", """" & Local.BaseDir & """ """ & DirOrig & """ /Y /E /C /Q", "", "", "")

                Dim ProgOrig As String = Icraft.IcftBase.FileExpr(DirOrig, "CLC.exe")

                Icraft.IcftBase.GravaLog("C:\LOG.TXT", "TEMP " & Icraft.IcftBase.FileExpr(DirOrig, "CLC_TEMP.EXE"))
                Icraft.IcftBase.GravaLog("C:\LOG.TXT", "PROG ORIG " & ProgOrig)

                System.IO.File.Copy(Icraft.IcftBase.FileExpr(DirOrig, "CLC_TEMP.EXE"), ProgOrig)

                Icraft.IcftBase.GravaLog("C:\LOG.TXT", "EXISTE " & ProgOrig & "? " & System.IO.File.Exists(ProgOrig))

                Icraft.IcftBase.Espera(2)

                Dim SI As New System.Diagnostics.ProcessStartInfo
                SI.WorkingDirectory = DirOrig
                SI.FileName = ProgOrig
                System.Diagnostics.Process.Start(SI)
            Catch EX As Exception
                MsgBox("Erro durante a atualização:" & EX.Message & ". A atualização não pode continuar.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
            Me.Close()

            Exit Sub

        End If
        Splash.Show()
        Icraft.IcftBase.Espera(1)
        Login.Show()
        For z = 0 To 1 Step 0.2
            Splash.Opacity = 1 - z
            Login.Opacity = z
            Icraft.IcftBase.Espera(0.1)
        Next
        Splash.Hide()
        Application.DoEvents()
        MenuDireciona(mnuPrinc.Items)

        ' trata autômatos...
        Importa.Inicia()
    End Sub

    Sub MenuDireciona(ByVal Opcao As ToolStripItemCollection)
        Try
            For Each Item As Object In Opcao
                If TypeOf Item Is ToolStripMenuItem Then
                    AddHandler CType(Item, ToolStripMenuItem).Click, AddressOf MenuItem_Click
                    If Item.DropDownItems.Count > 0 Then
                        MenuDireciona(Item.DropDownItems)
                    End If
                End If
            Next
        Catch EX As Exception
            Stop
        End Try
    End Sub

    Public Sub Mostra()
        AtivaTimer(TipoAcao.Mostra)
    End Sub

    Dim Instrucao As TipoAcao = 0

    <Flags()> Enum TipoAcao
        Nenhuma
        Mostra
    End Enum

    Private Sub tmrGeral_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGeral.Tick
        Dim Ativo As Boolean = False
        If (Instrucao And TipoAcao.Mostra) And Opacity < 1 Then
            Opacity += 0.3
            Ativo = True
        End If
        If Not Ativo Then
            tmrGeral.Enabled = False
        End If
    End Sub

    Sub AtivaTimer(ByVal Acao As TipoAcao)
        Instrucao = Instrucao + TipoAcao.Mostra
        If Not tmrGeral.Enabled Then
            tmrGeral.Enabled = True
        End If
    End Sub

    Private Sub MenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Elem As New Icraft.IcftBase.ElementosStr(Icraft.IcftBase.NZV(sender.tag, ""))
        Dim NomeTabela As String = Elem("tabela").Conteudo
        If NomeTabela <> "" Then
            Local.MostraForm("frm" & Elem("tabela").Conteudo.Replace("_", ""), Me, NomeTabela)
        End If
    End Sub

    Private Sub OrganizarEmCascataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizarEmCascataToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub LadoALadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LadoALadoToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConfiguraçõesDoUsuárioLogadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesDoUsuárioLogadoToolStripMenuItem.Click
        Local.MostraForm(frmConfigUsuario, Me)
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        Local.MostraForm(frmGerUsuario, Me)
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Local.MostraForm(frmRel, Me)
    End Sub

    Private Sub ManutençãoDeRepositórioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManutençãoDeRepositórioToolStripMenuItem.Click
        Local.MostraForm(frmTrataImagens, Me)
    End Sub

    Private Sub ConfiguraçãoGlobalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçãoGlobalToolStripMenuItem.Click
        Local.MostraForm(frmConfigGlobal, Me)
    End Sub

    Private Sub ImportaçãoDeNFeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportaçãoDeNFeToolStripMenuItem.Click
        Local.MostraForm(Importa, Me)
        Importa.Max()
    End Sub

    Private Sub ExportaçãoDeNFeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportaçãoDeNFeToolStripMenuItem.Click
        Local.MostraForm(Exporta, Me)
    End Sub

    Private Sub CadastramentoDeCNAEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastramentoDeCNAEToolStripMenuItem.Click
        Local.MostraForm(frmImpCNAE, Me)
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistóricoToolStripMenuItem.Click
        Local.MostraForm(frmHistorico, Me)
    End Sub

    Private Sub BoletoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletoToolStripMenuItem.Click
        Local.MostraForm(frmBoleto, Me)
    End Sub

    Private Sub RestriçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestriçõesToolStripMenuItem.Click
        Local.MostraForm(frmVerRestr, Me)
    End Sub

    Private Sub ChecagemDeNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecagemDeNotasToolStripMenuItem.Click
        Local.MostraForm(ChecarNF, Me)
    End Sub

    Private Sub ConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigToolStripMenuItem.Click
        Local.MostraForm(frmSiteConfig, Me)
    End Sub

    Private Sub VerNotasDeDiretórioXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerNotasDeDiretórioXMLToolStripMenuItem.Click
        Local.MostraForm(frmVerXml, Me)
    End Sub

    Public Sub MostraStatus(ByVal Texto As String)
        lblStatus.Text = Texto
    End Sub

    Private Sub LayoutDePraçaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayoutDePraçaToolStripMenuItem.Click
        Local.MostraForm(frmArmaLayout, Me)
    End Sub

    Private Sub ColetorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColetorToolStripMenuItem.Click
        Local.MostraForm(frmCargaDataSets, Me)
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Local.MostraForm(frmConsEtiq, Me)
    End Sub

    Private Sub EspecificaçõesDeItensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecificaçõesDeItensToolStripMenuItem.Click
        Local.MostraForm(frmEspecItens, Me)
    End Sub

    Private Sub VolumesPorPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumesPorPedidoToolStripMenuItem.Click
        Local.MostraForm(frmVolumesPedido, Me)
    End Sub

    Private Sub VolumesPorDimensãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumesPorDimensãoToolStripMenuItem.Click
        Local.MostraForm(frmVolumesDimensao, Me)
    End Sub

    Private Sub EtiquetasNaPraçaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasNaPraçaToolStripMenuItem.Click
        Local.MostraForm(frmEtiqsPraca, Me)
    End Sub

    Private Sub DimensõesNasPraçasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DimensõesNasPraçasToolStripMenuItem.Click
        Local.MostraForm(frmDimensoesPraca, Me)
    End Sub

    Private Sub SobreOSistemaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOSistemaToolStripMenuItem1.Click
        Local.MostraForm(SobreSistema, Me)
    End Sub

    Private Sub VerificarAtualizaçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarAtualizaçõesToolStripMenuItem.Click
        AutoAtt()
    End Sub

    Private Sub DimensõesPorQtdPeçasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DimensõesPorQtdPeçasToolStripMenuItem.Click
        Local.MostraForm(frmDimensoesPorPecas, Me)
    End Sub

    Private Sub EtiquetasNãoEncontradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasNãoEncontradasToolStripMenuItem.Click
        Local.MostraForm(frmEtiqsNaoEncontradas, Me)
    End Sub

    Private Sub ConferênciaDePraçasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConferênciaDePraçasToolStripMenuItem.Click
        Local.MostraForm(frmConferenciaPraca, Me)
    End Sub

    Private Sub AvariasEObservaçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvariasEObservaçõesToolStripMenuItem.Click
        Local.MostraForm(frmAvariasObs, Me)
    End Sub

    Private Sub PesoDaPeçaPorEspecificaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesoDaPeçaPorEspecificaçãoToolStripMenuItem.Click
        Local.MostraForm(frmPesoPecaEspec, Me)
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Local.MostraForm(frmConfDifPeso, Me)
    End Sub

    Private Sub ConferênciaDePesoTeóricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConferênciaDePesoTeóricoToolStripMenuItem.Click
        Local.MostraForm(frmConfTeorico, Me)
    End Sub

    Private Sub SaldoDeItensDeOrdemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoDeItensDeOrdemToolStripMenuItem.Click
        Local.MostraForm(frmOrdemItemSaldo, Me)
    End Sub

    Private Sub CadastroDeCiamodeloToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeCiamodeloToolStripMenuItem.Click
        frmCiaT.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        Try
            TesteDiver.Show()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.OkOnly, "Teste")
        End Try
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Local.MostraForm(frmCriaDataset, Me)
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Local.MostraForm(CodBarras, Me)
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        Local.MostraForm(frmTestes, Me)
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        Local.MostraForm(frmGeraReport, Me)
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        Local.MostraForm(frmTeste, Me)
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Local.MostraForm(frmImpressao, Me)
    End Sub

    Private Sub ConsolidaçãoDeEstoqueParaConferênciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidaçãoDeEstoqueParaConferênciaToolStripMenuItem.Click
        Local.MostraForm(frmConsolEstoque, Me)
    End Sub

    Private Sub OrdemDeVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdemDeVendaToolStripMenuItem.Click
        Local.MostraForm(frmOrdemVenda, Me)
    End Sub

    Private Sub FaltaConferirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaltaConferirToolStripMenuItem.Click
        Local.MostraForm(frmConferir, Me)
    End Sub

    Private Sub DiferençasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiferençasToolStripMenuItem.Click
        Local.MostraForm(frmModificacoes, Me)
    End Sub

    Private Sub InserçãoDeFotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserçãoDeFotosToolStripMenuItem.Click
        Local.MostraForm(frmFotos, Me)
    End Sub

    Private Sub GridDeManutençãoDeEtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDeManutençãoDeEtiquetasToolStripMenuItem.Click
        Local.MostraForm(frmGridEtiq, Me)
    End Sub

    Private Sub CarregamentosPorPontoDeColetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarregamentosPorPontoDeColetaToolStripMenuItem.Click
        Local.MostraForm(frmPontoColeta, Me)
    End Sub

    Private Sub EntregasParaClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntregasParaClientesToolStripMenuItem.Click
        Local.MostraForm(frmEntregaCliente, Me)
    End Sub

    Private Sub ResumoDeCarregamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumoDeCarregamentoToolStripMenuItem.Click
        Local.MostraForm(frmResumoCarrega, Me)
    End Sub

    Private Sub CarregamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarregamentosToolStripMenuItem.Click
        Local.MostraForm(frmCarregamentos, Me)
    End Sub

    Private Sub CadastroDeViagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeViagemToolStripMenuItem1.Click
        Local.MostraForm(frmViagem, Me)
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        Local.MostraForm(frmPontoColetaComViagem, Me)
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiçosToolStripMenuItem.Click
        Local.MostraForm(frmMensagens, Me)
    End Sub

    Private Sub ConsultasCustomizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasCustomizadasToolStripMenuItem.Click
        Local.MostraForm(frmPesquisas, Me)
    End Sub

    Private Sub TesteImportDSNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesteImportDSNToolStripMenuItem.Click
        Local.MostraForm(frmImpDSN, Me)
    End Sub

    Private Sub EstoquePorProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoquePorProdutoToolStripMenuItem.Click
        Local.MostraForm(frmEstoqueDina, Me)
    End Sub

    Private Sub EstoquePorPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoquePorPedidoToolStripMenuItem.Click
        Local.MostraForm(frmEstoquePed, Me)
    End Sub

    Private Sub VendasPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasPorClienteToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(0)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub VendasPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasPorVendedorToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(1)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub VendaDeVendedoresPorMêsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendaDeVendedoresPorMêsToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(2)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub VendasMensaisPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasMensaisPorClienteToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(3)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub VendasMensaisDeProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasMensaisDeProdutosToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(4)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub TotalDeComprasPorFornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDeComprasPorFornecedorToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(5)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub CorrelaçãoProdEspecCLCXCIEXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrelaçãoProdEspecCLCXCIEXToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(6)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub CorrelaçãoClienteMoedaIncotCLCXCIEXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrelaçãoClienteMoedaIncotCLCXCIEXToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(7)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub EstoqueDeProdutoAvariadoENãoAvariadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueDeProdutoAvariadoENãoAvariadoToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(8)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub CanalizaçãoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanalizaçãoDeClientesToolStripMenuItem.Click
        Local.MostraForm(frmVendedorPorCliente, Me)
    End Sub

    Private Sub EspecProdutosXDescrParaVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecProdutosXDescrParaVendedoresToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(9)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub OrdensDeVendaSemIPIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdensDeVendaSemIPIToolStripMenuItem.Click
        Dim f As frmEstoqueEstat = Local.MostraForm("", frmEstoqueEstat, Me)
        f.TXTCONSULTA.Text = f.TXTCONSULTA.Items(10)
        f.btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub VisãoDeGerencialDeKEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisãoDeGerencialDeKEntradaToolStripMenuItem.Click
        Local.MostraForm(frmGerencial, Me)
    End Sub

    Private Sub GerencialAgrupadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerencialAgrupadoToolStripMenuItem.Click
        Local.MostraForm(frmGerencialAgrupado, Me)
    End Sub

    Private Sub CarregamentoDeItensDaOrdemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarregamentoDeItensDaOrdemToolStripMenuItem.Click
        Local.MostraForm(frmCarregaOrdem, Me)
    End Sub

    Private Sub EstoqueParaVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueParaVendedoresToolStripMenuItem.Click
        Local.MostraForm(frmEstoqueVendedor, Me)
    End Sub

    Private Sub PendênciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendênciasToolStripMenuItem.Click
        Local.MostraForm(frmPendencias, Me)
    End Sub

    Private Sub ConferênciaItensEmbarqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConferênciaItensEmbarqueToolStripMenuItem.Click
        Local.MostraForm(frmConfItemEmb, Me)
    End Sub

    Private Sub PedidosPorNavioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosPorNavioToolStripMenuItem.Click
        Local.MostraForm(frmPedidoViagem, Me)
    End Sub

    Private Sub EstoqueAgrupadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueAgrupadoToolStripMenuItem.Click
        Local.MostraForm(frmEstoqueAgrupado, Me)
    End Sub

    Private Sub DimensõesPorNCMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DimensõesPorNCMToolStripMenuItem.Click
        Local.MostraForm(frmVolumesDimensaoNCM, Me)
    End Sub

    Private Sub PosiçãoDoEstoqueRochaTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PosiçãoDoEstoqueRochaTopToolStripMenuItem.Click
        Local.MostraForm(frmPosicaoRocha, Me)
    End Sub
End Class
