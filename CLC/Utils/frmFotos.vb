Imports Icraft.IcftBase
Public Class frmFotos

    Private Sub btnDiretorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorio.Click
        Try
            DDG.SelectedPath = txtDiretorio.Text
            If DDG.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtDiretorio.Text = DDG.SelectedPath
                btnAtualizar_Click(Nothing, Nothing)
            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando diretório"))
        End Try
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            'Icraft.IcftBase.CarregaCombo(TXTVIAGEMESCALA, 0, 0, "|", True, Icraft.IcftBase.DSCarrega("SELECT VIAGEM_REF || ' | ' || TO_CHAR(ESCALA,'FM000') || ' | ' || CIA_COD_LOCAL FROM IM.VIAGEM_ESCALA ORDER BY 1", Login.Strconn))
            Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
            grdprinc.SQL = "SELECT '' Arquivo, 0 Sel, '' Titulo, '' Obs, '' ViagemEscala , '' Etiqueta, '' TratamentoEm, '' Resultado, '' Destino FROM DUAL ARQS WHERE ROWNUM<1"
            grdprinc.Usuario = Login.Usuario!USUARIO
            grdprinc.StrConn = Login.Strconn
            grdprinc.ColunaNomes = "Arquivo;Sel;Título;Observações;ViagemEscala;Etiqueta;TratamentoEm;Resultado;Destino"
            grdprinc.CamposExtend = "Geral.SEL|FORMATO:BOOL"
            grdprinc.EsquemaGerador = Apl.Esquema
            grdprinc.Sistema = Apl.Esquema
            grdprinc.EsquemaPrinc = Apl.Esquema
            grdprinc.Tabela = "Geral"
            grdprinc.Bloquear = "Arquivo;TratamentoEm;Resultado;Destino"
            grdprinc.Bind()
            Dim dt As System.Data.DataTable = grdprinc.Grid.DataSource
            Dim z As Integer = 1
            For Each Item As String In Icraft.IcftBase.ListaDir(txtDiretorio.Text, "*.jpg", False)
                ' últimas colunas do grid sempre são posição e tipo
                dt.Rows.Add(Item, 0, "", "", "", "", "", "", "", z, "det")
                z += 1
            Next
            Ult = -1
            grdprinc.ExecAposCargaExtra()
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "buscando arquivo"))
        End Try

    End Sub

    Private Sub grdprinc_AposAtualizar() Handles grdprinc.AposAtualizar
        Try
            btnAtualizar_Click(Nothing, Nothing)
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "após atualizar grid"))
        End Try
    End Sub

    Sub LimpaReg()
        txtTitulo.Text = ""
        txtObs.Text = ""
        TXTVIAGEMESCALA.Text = ""
        TXTETIQUETA.Text = ""
        picImg.Image = Nothing
    End Sub

    Dim Ult As Integer = -1

    Private Sub grdprinc_AposSelecionarCelula() Handles grdprinc.AposSelecionarCelula
        If IsNothing(grdprinc.Grid.CurrentRow) OrElse grdprinc.Grid.CurrentRow.Index < 0 Then
            LimpaReg()
        Else
            If Ult <> grdprinc.Grid.CurrentRow.Index Then
                Ult = grdprinc.Grid.CurrentRow.Index

                Try
                    txtTitulo.Text = grdprinc.Grid.CurrentRow.Cells("Titulo").Value
                    txtObs.Text = grdprinc.Grid.CurrentRow.Cells("Obs").Value
                    TXTVIAGEMESCALA.Text = grdprinc.Grid.CurrentRow.Cells("ViagemEscala").Value
                    TXTETIQUETA.Text = grdprinc.Grid.CurrentRow.Cells("Etiqueta").Value
                    picImg.Image = Icraft.IcftBase.ParaCaber(New Bitmap(grdprinc.Grid.CurrentRow.Cells("Arquivo").Value.ToString), picImg.Width, picImg.Height)
                Catch ex As Exception
                    LimpaReg()
                    txtTitulo.Text = ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Shell("mspaint """ & grdprinc.Grid.CurrentRow.Cells(0).Value & """", AppWinStyle.MaximizedFocus)
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "executando mspaint para editar"))
        End Try
    End Sub

    Private Sub btnGrava_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrava.Click
        Try
            If TXTVIAGEMESCALA.Text <> "" And TXTETIQUETA.Text <> "" Then
                MsgBox("Informe ou viagem com escala ou etiqueta, pois a imagem será vinculada apenas a um destes.", MsgBoxStyle.OkOnly, "Vinculando foto")
                Exit Sub
            End If
            If TXTVIAGEMESCALA.Text = "" And TXTETIQUETA.Text = "" Then
                MsgBox("Informe ou escala ou viagem.", MsgBoxStyle.OkOnly, "Vinculando Foto")
                Exit Sub
            End If
            grdprinc.Grid.CurrentRow.Cells("Titulo").Value = txtTitulo.Text
            grdprinc.Grid.CurrentRow.Cells("Obs").Value = txtObs.Text
            grdprinc.Grid.CurrentRow.Cells("ViagemEscala").Value = TXTVIAGEMESCALA.Text
            grdprinc.Grid.CurrentRow.Cells("Etiqueta").Value = TXTETIQUETA.Text
            grdprinc.Grid.CurrentRow.Cells("Sel").Value = 1
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "atualizando dados no grid"))
        End Try
    End Sub


    Private Sub TXTVIAGEMESCALA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTVIAGEMESCALA.SelectedIndexChanged
        TXTETIQUETA.Text = ""
    End Sub

    Private Sub TXTETIQUETA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTETIQUETA.KeyDown
        If e.KeyCode = Keys.F9 Then
            If Len(TXTETIQUETA.Text) < 4 Then
                MsgBox("Informe pelo menos 4 caracteres antes de buscar etiqueta.", MsgBoxStyle.OkOnly, "Buscando etiqueta")
                Exit Sub
            End If
            Icraft.IcftBase.CarregaCombo(TXTETIQUETA, 0, 0, "|", True, Icraft.IcftBase.DSCarrega("SELECT ETIQUETA || ' | ' || PRODUTO_COD || ' | ' || ESPEC FROM IM.VW_COL_RASTREA_ETIQ WHERE ETIQUETA LIKE :ETIQUETA || '%' ORDER BY 1", Login.Strconn, ":ETIQUETA", TXTETIQUETA.Text))
        End If
    End Sub

    Private Sub TXTETIQUETA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTETIQUETA.SelectedIndexChanged
        TXTVIAGEMESCALA.Text = ""
    End Sub

    Private Sub frmFotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO")
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If MsgBox("Somente arquivos selecionados abaixo serão enviados. Continuar?", MsgBoxStyle.YesNo, "Upload de Imagens") = MsgBoxResult.Yes Then

            ' verificando diretório se está acessível
            Dim NomeServ As String = ""
            Try
                NomeServ = Icraft.IcftBase.TextoCondicional(Icraft.IcftBase.DSConfig(Login.Strconn, "FOTOS_DIR_DEPENDE_REDE", "IM.SYS_CONFIG_GLOBAL"), Join(Icraft.IcftBase.IPLocal().ToArray, "|"))
            Catch
            End Try
            If Not System.IO.Directory.Exists(NomeServ) Then
                MsgBox("Sua máquina não possui acesso ao servidor para salvar informações. Verifique com suporte (diretório=" & NomeServ & ").", MsgBoxStyle.OkOnly, "Upload de Imagens")
                Andamento("")
                Exit Sub
            End If

            Dim DT As System.Data.DataTable = grdprinc.Grid.DataSource

            Dim z As Integer = 1
            Dim Qtd As Integer = 0
            For Each LINHA As System.Data.DataRow In DT.Rows
                If Icraft.IcftBase.NZ(LINHA!SEL, False) And Icraft.IcftBase.NZ(LINHA!Resultado, "") <> "OK" Then
                    Andamento("Conferindo Arquivo " & z)

                    If Icraft.IcftBase.NZ(LINHA!ETIQUETA, "") = "" And Icraft.IcftBase.NZ(LINHA!VIAGEMESCALA, "") = "" Then
                        LINHA!Resultado = "Erro. Não podem ser incluídas fotos sem vínculo viagem/escala ou etiqueta."
                        Qtd += 1
                    End If
                    'verifica se o usuário consegue gravar arquivos no diretório especificado.
                    Try
                        Icraft.IcftBase.GravaLog(NomeServ & "\teste.txt", "teste")
                        Kill(NomeServ & "\teste.txt")
                    Catch ex As Exception
                        Qtd += 1
                        Throw New Exception("O sistema não conseguiu gravar arquivos no diretório " & NomeServ & ". Favor verificar com suporte.")
                    End Try


                    If TXTTAMANHO.Text = "" Then
                        MsgBox("Favor especificar um tamanho para a imagem " & LINHA!ARQUIVO & ".")
                    End If

                    ' cleiton vai continuar. pensar em todas as condições de erro antes de começar a entrar com fotos
                    ' sem etiqueta ou viagemescala
                    ' sem nome de arquivo (até isso)
                    ' nome de arquivo duplicado na origem
                End If
            Next
            If Qtd > 0 Then
                MsgBox(Qtd & " " & Icraft.IcftBase.Pl(Qtd, "erro foi", "erros foram") & " encontrados. Verifique campo resultado no quadro de arquivos.", MsgBoxStyle.OkOnly, "Upload de Imagens")
                Andamento("")
                Exit Sub
            End If
            Icraft.IcftBase.Espera(2)


            ' obtendo arquivo temporário para trabalho de redimensionamento
            Dim Temp As String = Icraft.IcftBase.TemporaryDir(System.IO.Path.GetTempPath)
            MkDir(Temp)
            If MsgBox("Imagens redimensionadas serão salvas no diretório " & Temp & ". Continua?", MsgBoxStyle.YesNo, "Upload de Imagens") = MsgBoxResult.No Then
                Try
                    RmDir(Temp)
                Catch
                End Try
                Exit Sub
            End If

            ' redimensionando todas as imagens
            z = 1
            For Each LINHA As System.Data.DataRow In DT.Rows
                If Icraft.IcftBase.NZ(LINHA!SEL, False) And Icraft.IcftBase.NZ(LINHA!Resultado, "") <> "OK" Then
                    Andamento("Redimensionando Imagem " & z)
                    z += 1
                    Dim Arquivo As String = Icraft.IcftBase.FileExpr(Temp, System.IO.Path.GetFileName(LINHA!arquivo))
                    Dim BB As New Bitmap(CType(LINHA!arquivo, String))
                    Dim Res() As String = Split(TXTTAMANHO.Text, "X")
                    LINHA!TratamentoEm = Arquivo
                    If BB.Width > Res(0) Or BB.Height > Res(1) Then
                        Icraft.IcftBase.ParaCaber(BB, Res(0), Res(1)).Save(LINHA!TratamentoEm)
                    Else
                        MsgBox("Não foi possível redimensionar a imagem. Será mantido o tamanho original.")
                        System.IO.File.Copy(LINHA!ARQUIVO, Temp & "\" & System.IO.Path.GetFileName(LINHA!arquivo))
                    End If
                End If
            Next
            Icraft.IcftBase.Espera(2)


            z = 1
            For Each LINHA As System.Data.DataRow In DT.Rows
                If Icraft.IcftBase.NZ(LINHA!SEL, False) And Icraft.IcftBase.NZ(LINHA!Resultado, "") <> "OK" Then
                    Andamento("Copiando Arquivo " & z)
                    z += 1

                    Try
                        Dim Destino As String = ""
                        Dim Viagem As String = ""
                        Dim Escala As String = ""
                        Dim Etiqueta As String = ""

                        Dim VE() As String = Split(Icraft.IcftBase.NZ(LINHA!VIAGEMESCALA, ""), " | ")
                        Dim ET() As String = Split(Icraft.IcftBase.NZ(LINHA!ETIQUETA, ""), " | ")
                        Dim Diretorio As String = ""

                        If VE.Length > 1 Then
                            Viagem = VE(0)
                            Escala = VE(1)
                            Destino = Icraft.IcftBase.TiraCaracEspec(TrechoAte(VE, 2), "_")
                            Diretorio = "ViaEsc"
                        Else
                            Etiqueta = ET(0)
                            Destino = Icraft.IcftBase.TiraCaracEspec(ET(0), "_")
                            Diretorio = "Etiq"
                        End If

                        Dim Momento As Date = Now
                        Destino = Icraft.IcftBase.ExprExpr("_", "", Destino, Format(Momento, "yyyyMMdd_HHmmss"))
                        Destino = Icraft.IcftBase.URLExpr("~/img/clc", Diretorio, Destino)

                        Dim Livre As Integer = 1
                        For Livre = 1 To 9999
                            Dim DestinoCompl As String = UCase(Destino & IIf(Livre = 1, "", "_" & Format(Livre, "0000")) & System.IO.Path.GetExtension(LINHA!TratamentoEm))
                            If Icraft.IcftBase.DSValor("COUNT(*)", "IM.ANEXO", Login.Strconn, "ARQUIVO=:ARQUIVO", ":ARQUIVO", DestinoCompl) = 0 Then
                                Destino = DestinoCompl
                                Exit For
                            End If
                        Next
                        If Livre > 9999 Then
                            Throw New Exception("Já existem 9999 imagens vinculadas ao termo '" & Destino & "'")
                        End If
                        Dim Seq As Integer = Icraft.IcftBase.DSProxSeq("SEQ", "IM.ANEXO", Login.Strconn, "")

                        Dim AR As ArrayList = ListaDir(NomeServ & "\" & Diretorio, "*.JPG", True)
                        For X As Integer = 0 To AR.Count - 1
                            If AR.Contains(NomeServ & "\" & Diretorio & "\" & Destino.Substring(Destino.LastIndexOf("/") + 1)) Then
                                MsgBox("Arquivo duplicado")
                                Qtd += 1
                            End If
                        Next

                        Icraft.IcftBase.DSGrava("INSERT INTO IM.ANEXO (SEQ,ARQUIVO,VIAGEM_REF,ESCALA,ETIQUETA,TITULO,OBS,MOMENTO,OPERADOR) VALUES(:SEQ,:ARQUIVO,:VIAGEM_REF,:ESCALA,:ETIQUETA,:TITULO,:OBS,:MOMENTO,:OPERADOR)", Login.Strconn, ":SEQ", Seq, ":ARQUIVO", Destino, ":VIAGEM_REF", Viagem, ":ESCALA", Escala, ":ETIQUETA", Etiqueta, ":TITULO", LINHA!TITULO, ":OBS", LINHA!OBS, ":MOMENTO", Momento, ":OPERADOR", Login.Usuario!USUARIO)
                        System.IO.File.Copy(LINHA!TratamentoEm, Icraft.IcftBase.FileExpr(NomeServ, Diretorio, System.IO.Path.GetFileName(Destino)))
                        LINHA!Destino = Destino
                        LINHA!Resultado = "OK"
                    Catch ex As Exception
                        LINHA!Resultado = "Erro. " & ex.Message
                        If MsgBox(LINHA!Resultado & ". Deseja continuar?", MsgBoxStyle.YesNo, "Upload de Imagens") = MsgBoxResult.No Then
                            Andamento("")
                            Exit Sub
                        End If
                    End Try
                End If
            Next

            Icraft.IcftBase.Espera(2)

            Andamento("")
            MsgBox("Upload completo. Verifique os registros abaixo para garantir que foram aceitos.", MsgBoxStyle.OkOnly, "Upload de Imagens")
            If MsgBox("Deseja apagar arquivos temporários?", MsgBoxStyle.YesNo, "Arquivos temporários") = MsgBoxResult.Yes Then
                For Each ITEM As Object In ListaDir(Temp, "*.JPG", True)
                    Try
                        Kill(ITEM)
                    Catch ex As Exception
                        MsgBox("Não foi possível apagar o item: " & ITEM & "." & vbCrLf & "Verifique o diretório " & Temp & ".")
                    End Try
                Next
            End If
        End If
    End Sub

    Function TrechoAte(ByVal Lista As Object, ByVal Ate As Integer, Optional ByVal Separa As String = " | ", Optional ByVal SeparaConcat As String = "_") As String
        Dim Ar() As String
        If TypeOf Lista Is String Then
            Ar = Split(Lista, Separa)
        Else
            Ar = Lista
        End If

        Dim Concat As String = ""
        For z As Integer = 1 To Ate
            If z <= Ar.Length Then
                Concat &= IIf(Concat <> "", SeparaConcat, "") & Ar(z - 1)
            End If
        Next
        Return Concat
    End Function

    Sub Andamento(ByVal Texto As String)
        pnlAndamento.Visible = Texto <> ""
        lblAndamento.Text = Texto
    End Sub
End Class