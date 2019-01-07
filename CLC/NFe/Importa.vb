Imports Icraft.IcftBase
Imports CLC.Local

Public Class Importa

    Dim SalvaTop As Integer = 0
    Dim SalvaLeft As Integer = 0

    Public Sub Max()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.AutoSize = True
        If SalvaTop <> 0 Then
            Me.Top = SalvaTop
        End If
        If SalvaLeft <> 0 Then
            Me.Left = SalvaLeft
        End If
        Notifica("Acessando mais detalhes...")
    End Sub


    Public Sub Mini()
        SalvaTop = Me.Top
        SalvaLeft = Me.Left
        Me.Top = 0
        Me.Left = 0
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.AutoSize = False
        Height = gTemp.Height + 30
    End Sub

    Public Shared Sub Inicia()
        Icraft.IcftBase.Form.Conteudo(CLC.Importa, "txt") = ""
        Icraft.IcftBase.Form.Conteudo(CLC.Importa, "txt") = Icraft.IcftBase.DecrypB(Icraft.IcftBase.RegAplKey(My.Application.Info.Title, "ImportaNFEDados"))

        If CLC.Importa.txtLogin.Checked Then
            Try
                Login.txtLogin.Text = CLC.Importa.txtUsuario.Text
                Login.txtSenha.Text = CLC.Importa.txtSenha.Text
                Login.Loga()
                Local.MostraForm(CLC.Importa, Princ)
                CLC.Importa.Mini()
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Login Automático Falhou"))
            End Try
        End If
    End Sub

    Dim tmrExec As New Timer
    Sub Temporiza()
        If Not txtSuspend.Checked Then
            tmrExec.Enabled = False

            ' trata momento de execução
            Dim Atual As Long = Val(lblContador.Text)
            Atual -= 1
            If Atual < 0 Then
                Atual = Icraft.IcftBase.NZV(txtSegs.Text, 10)

                Notifica("Executando...")
                Importa(False)

                lblUltima.Text = Format(Now, "dd/MM/yyyy HH:mm:ss")
            Else
                Notifica("Aguardando...")
            End If

            lblContador.Text = Format(Atual, "00")
            Application.DoEvents()

            tmrExec.Enabled = True
        Else
            Notifica("Suspenso...")
        End If
    End Sub

    Sub Notifica(ByVal Texto As String)
        Application.DoEvents()
        lblAcompanha.Text = Texto
        Static UltAmostra As Date = CDate(Nothing)
        If DateDiff(DateInterval.Second, UltAmostra, Now) >= 10 Then
            AtribInfo()
            UltAmostra = Now
        End If
    End Sub

    Sub AtribInfo()
        Dim Result As String = ""
        If Not IsNothing(QtdDir) Then
            For Each Chave As String In From x As String In QtdDir.Keys Order By x
                Result &= IIf(Result <> "", vbCrLf, "") & Chave & "=" & Icraft.IcftBase.NumPl(QtdDir(Chave), "arquivo")
            Next
        End If
        lblArqInfo.Text = Result
    End Sub

    Dim QtdDir As Dictionary(Of String, Integer)

    Private Sub Importa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDir.Text = DSConfig(Login.Strconn, "DIR", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
        txtDirRelativo.Text = DSConfig(Login.Strconn, "DIR_REL", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
        lblContador.Text = "03"
        lblUltima.Text = "aguardar..."
        tmrExec.Interval = 1000
        tmrExec.Enabled = True
        AddHandler tmrExec.Tick, AddressOf Temporiza

        If Trim(txtDir.Text) = "" OrElse Not System.IO.Directory.Exists(txtDir.Text) Then
            txtSuspend.Checked = True
            Notifica("Configure os diretórios corretamente...")
        Else
            For Each DD As String In DirEspec
                Dim DDD As String = Icraft.IcftBase.FileExpr(txtDir.Text, DD)
                If Not System.IO.Directory.Exists(DDD) Then
                    System.IO.Directory.CreateDirectory(DDD)
                End If
            Next
        End If
    End Sub

    Dim DirEspec() As String = {"Erro", "Duplicado", "Tratado", "CNPJInexist", "Cancelado", "CancelaInexistente", "Invalido", "JaCancelado"}

    Function Arqs(ByVal Totaliza As Boolean) As ArrayList
        Dim LISTACOMPLETA As ArrayList = Icraft.IcftBase.ListaDir(Icraft.IcftBase.FileExpr(txtDir.Text), "*.xml", True)
        Dim LISTA As New ArrayList
        Dim DirNeg As New ArrayList

        For Each DD As String In DirEspec
            Dim DDD As String = Icraft.IcftBase.FileExpr(txtDir.Text, DD)
            DirNeg.Add(DDD)
        Next

        For Each ITEM As String In LISTACOMPLETA
            Dim DirL As String = LCase(System.IO.Path.GetDirectoryName(ITEM.ToString.ToLower))
            If Not Icraft.IcftBase.TemNaLista(DirNeg, DirL) Then
                LISTA.Add(ITEM)
            Else
                If Totaliza Then
                    Icraft.IcftBase.RegDict(QtdDir, System.IO.Path.GetFileName(DirL)) += 1
                End If
            End If
        Next

        If Totaliza Then
            RegDict(QtdDir, "total") = LISTA.Count
        End If
        Notifica("Obtendo arquivos:" & LISTA.Count)
        Return LISTA
    End Function

    Dim JaEstaRodando As Boolean = False
    Public Executando As Boolean = True
    Sub Importa(ByVal Reconhecim As Boolean)
        If txtDir.Text = "" Then
            Notifica("IMPORTANTE: Informe um diretório válido.")
            txtSuspend.Checked = True
            txtDir.Focus()
            Exit Sub
        End If
        If txtDirRelativo.Text = "" Then
            Notifica("IMPORTANTE: Informe um caminho relatório válido.")
            txtSuspend.Checked = True
            txtDirRelativo.Focus()
            Exit Sub
        End If

        QtdDir = New Dictionary(Of String, Integer)
        If Not JaEstaRodando Then
            JaEstaRodando = True
            Notifica("Início da etapa de importação de XML")
            Dim z As Integer = 0
            Dim LISTA As ArrayList = Arqs(True)





            ' busca notas não canceladas somente
            Do While Executando And z < LISTA.Count

                If System.IO.File.Exists(LISTA(z)) Then
                    Dim Xml As New System.Xml.XmlDocument
                    Try
                        Xml.Load(LISTA(z))
                        If TrataDados(Xml, LISTA(z), False, Reconhecim) Then
                            XmlGrava("Tratado", LISTA(z), Nothing, "Tratando notas")
                        End If
                    Catch ex As Exception
                        XmlGrava("Erro", LISTA(z), ex, "Tratando notas")
                    End Try
                End If
                z += 1
                Notifica("Importação de arquivos: " & z & "/" & LISTA.Count)
                Application.DoEvents()
            Loop

            LISTA = Arqs(False)





            ' busca por notas canceladas somente
            z = 0
            Do While Executando And z < LISTA.Count

                If System.IO.File.Exists(LISTA(z)) Then
                    Dim Xml As New System.Xml.XmlDocument
                    Try
                        Xml.Load(LISTA(z))
                        If TrataDados(Xml, LISTA(z), True, Reconhecim) Then
                            XmlGrava("Tratado", LISTA(z), Nothing, "Tratando cancelamentos")
                        End If
                    Catch ex As Exception
                        XmlGrava("Erro", LISTA(z), ex, "Tratando cancelamentos")
                    End Try
                End If
                z += 1
                Notifica("Importação de notas canceladas: " & z & "/" & LISTA.Count)
                Application.DoEvents()
            Loop
            Notifica("Término desta etapa de importação de XML")
            JaEstaRodando = False
        End If
        AtribInfo()
    End Sub


    Private Function TrataDados(ByVal XML As System.Xml.XmlDocument, ByRef Arquivo As String, ByVal CANCELA As Boolean, ByVal Reconhecim As Boolean) As Boolean
        Dim NOTANUM As String = ""
        Dim NOTASERIE As String = ""

        Dim CANC As String = NFe.ObtemCancNFE(XML)
        Dim VERS As String = NFe.ObtemVersao(XML)
        Dim OPER As String = NFe.ObtemOperacao(XML)

        If CANC <> "" And (OPER <> "CANCELAR" And OPER <> "") Then Throw New Exception("Operação incorreta CANC: " & CANC & " - OPER:" & OPER)

        If CANC <> "" Then
            OPER = "CANCELAR"
        End If


        Dim CIA As System.Data.DataSet = Nothing
        Dim CODCIA As String = ""
        Dim LOGO As String = ""

        Dim NFCONV() As String
        Dim NFICONV() As String

        If TemNaLista(NFe.VersoesPermitidas, VERS) Then
            If Not CANCELA AndAlso (OPER <> "CANCELAR" And CANC = "") Then

                RegDict(QtdDir, "nfe" & VERS) += 1

                NOTANUM = NFe.OBTEMNOTANUM(XML)
                NOTASERIE = NFe.ObtemNotaSerie(XML)
                Dim CNPJNFS As String = NFe.ObtemCnpjEmit(XML)

                Try
                    CIA = DSCarrega("SELECT COD, LOGO FROM IM.CIA WHERE REPLACE(REPLACE(REPLACE(CNPJ,'.',''),'/',''),'-','')='" & CNPJNFS & "'", Login.Strconn)
                    CODCIA = CIA.Tables(0).Rows(0)("COD")
                    LOGO = NZ(CIA.Tables(0).Rows(0)("LOGO"), "")
                Catch EX As Exception
                    XmlGrava("CNPJInexist", Arquivo, New Exception("Erro obtendo CNPJ:" & EX.Message), "CNPJ:" & NZV(CNPJNFS, "nulo") & " msg: " & EX.Message)
                    Return False
                End Try

                Dim X As String = NZ(XmlElem(XML, "nfeProc/NFe/infNFe/ide/verProc"), "")
                NFCONV = NFe.NFConv
                NFICONV = NFe.NFIConv
                If X = "" Then
                    X = NZ(XmlElem(XML, "NFe/infNFe/ide/verProc"), "")
                    If X <> "" Then
                        For Z As Integer = 0 To NFCONV.Count - 1 Step 2
                            NFCONV(Z + 1) = Replace(NFCONV(Z + 1), "nfeProc/", "")
                        Next
                        For z As Integer = 0 To NFICONV.Count - 1 Step 2
                            NFICONV(z + 1) = Replace(NFICONV(z + 1), "nfeProc/", "")
                        Next
                    Else
                        Throw New Exception("Verproc não encontrado no arquivo")
                    End If
                End If

                GravaNota(Arquivo, XML, NFCONV, NFICONV, NOTASERIE, NOTANUM, LOGO, CODCIA)

            ElseIf CANCELA AndAlso (OPER = "CANCELAR") Then
                RegDict(QtdDir, "cancnfe" & VERS) += 1

                Dim NFID As String = XmlElem(XML, "procCancNFe/cancNFe/infCanc/chNFe")
                Dim NFCCONV() As String = Nothing

                If NFID <> "" Then
                    NFCCONV = NFe.NFCConv("procCancNFe/")
                Else
                    NFID = XmlElem(XML, "retCancNFe/infCanc/chNFe")
                    If NFID <> "" Then
                        NFCCONV = NFe.NFCConv("")
                    Else
                        Throw New Exception("Ref. ChNFe não encontrada na instrução de cancelamento")
                    End If
                End If

                Dim NFNULL As String = DSValor("PROTNFE_INFPROT_CHNFE", "IM.NF", Login.Strconn, "PROTNFE_INFPROT_CHNFE=:NFE", ":NFE", NFID)

                If NFNULL = "" Then
                    XmlGrava("CancelaInexistente", Arquivo, New Exception("Tentativa de cancelar NF inexistente"), "Ao tentar cancelar NFE " & NFID)
                    Exit Function
                End If

                Dim NFCAMPOSC() As String = ArrayPegaItem(NFCCONV, 2)
                Dim SQL As String = "ARQUIVO_CANC = :ARQUIVO_CANC"

                For Each ITEM As String In NFCAMPOSC
                    SQL &= IIf(SQL <> "", ", ", "") & ITEM & " = :" & ITEM
                Next

                Dim y As ArrayList = XmlElemParams(XML, NFCCONV)
                If NZV(DSValor("CANCNFE_INFCANC_ID", "IM.NF", Login.Strconn, "PROTNFE_INFPROT_CHNFE =:PROTNFE_INFPROT_CHNFE", ":PROTNFE_INFPROT_CHNFE", NFID), "") = "" Then
                    Dim ARQ As String = URLExpr(txtDirRelativo.Text, "Tratado", System.IO.Path.GetFileName(Arquivo))
                    Icraft.IcftBase.DSGrava("UPDATE IM.NF SET " & SQL & " WHERE PROTNFE_INFPROT_CHNFE =:PROTNFE_INFPROT_CHNFE", Login.Strconn, ":PROTNFE_INFPROT_CHNFE", NFID, ":ARQUIVO_CANC", ARQ, y)
                    XmlGrava("Cancelado", Arquivo)
                    Return False
                Else
                    XmlGrava("JaCancelado", Arquivo)
                    Return False
                End If
            Else
                Return False
            End If

        Else
            XmlGrava("Invalido", Arquivo, New Exception("Arquivo inválido"), "Formato não reconhecido ou versão '" & VERS & "' incorreta (permitidas:" & NFe.VersoesPermitidas & ")")
            Return False
        End If
        Return True
    End Function

    Dim CriterioErroDuplicacao As String = "(?is)duplicad|exclusiv"
    Sub XmlGrava(ByVal Cond As String, ByVal Arquivo As String, Optional ByVal Erro As Exception = Nothing, Optional ByVal Complemento As String = Nothing)
        Dim TCOND As String = ""
        Dim TDIR As String = Cond
        If Not IsNothing(Erro) Then
            TCOND = Icraft.IcftBase.MessageEx(Erro, Complemento)
            If System.Text.RegularExpressions.Regex.Match(TCOND, CriterioErroDuplicacao).Success Then
                TDIR = "Duplicado"
                TCOND = "Arquivo " & Arquivo & " com NFe duplicada."
            End If
            Notifica(TCOND & " em arquivo " & Arquivo)
        Else
            TCOND = "OK"
        End If

        Dim VDIR As String = FileExpr(txtDir.Text, TDIR)
        Dim dEST As String = Icraft.IcftBase.NomeArqLivre(VDIR, System.IO.Path.GetFileName(Arquivo))
        System.IO.File.Move(Arquivo, dEST)
        GravaLog(FileExpr(txtDir.Text, "Log.txt"), ExibeData(Now, "yyyy mm dd hh mm ss") & ": em " & dEST & " - " & TCOND)

        RegDict(QtdDir, "arqs") -= 1
        RegDict(QtdDir, LCase(TDIR)) += 1
    End Sub

    Private Sub Importa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(Login.Strconn) Then
            Mini()
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Icraft.IcftBase.RegAplKey(My.Application.Info.Title, "ImportaNFEDados") = Icraft.IcftBase.EncrypB(Icraft.IcftBase.Form.Conteudo(Me, "txt"))
    End Sub

    Private Sub btnDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir.Click
        fldOpen.SelectedPath = txtDir.Text
        If fldOpen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDir.Text = fldOpen.SelectedPath
        End If
    End Sub

    Private Sub btnExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecutar.Click
        txtSuspend.Checked = False
        lblContador.Text = "00"
    End Sub

    Private Sub txtVal(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDir.Validated, txtDirRelativo.Validated, txtSegs.Validated
        txtSuspend.Checked = True
        btnSalva_Click(sender, e)
    End Sub

    Private Sub txtSuspend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspend.CheckedChanged
        btnSalva_Click(sender, e)
    End Sub

    Public Shared Function XmlElemParams(ByVal Xml As Object, ByVal Params() As String) As ArrayList
        Dim Conteudo As New ArrayList
        For z As Integer = 0 To Params.Count - 1 Step 2
            Conteudo.Add(":" & Params(z))

            Try
                Conteudo.Add(NZ(XmlElem(Xml, Params(z + 1)), System.Convert.DBNull))
            Catch EX As Exception
                Throw New Exception("Erro na obtenção de param " & Params(z) & " no caminho " & Params(z + 1) & ": " & EX.Message)
            End Try

        Next
        Return Conteudo
    End Function

    Sub GravaNota(ByVal Arquivo As String, ByVal XML As System.Xml.XmlDocument, ByVal NFCONV() As String, ByVal NFICONV() As String, ByVal NOTASERIE As String, ByVal NOTANUM As String, ByVal LOGO As String, ByVal CODCIA As String)

        'ativar para checagem
        Static Checagem As Boolean = True

        Dim VET As ArrayList = XmlElemParams(XML, NFCONV)
        Dim Arq As String = URLExpr(txtDirRelativo.Text, "Tratado", System.IO.Path.GetFileName(Arquivo))
        Dim NFCampos() As String = ArrayPegaItem(NFCONV)
        Dim NFICampos() As String = ArrayPegaItem(NFICONV)
        Dim VERS As String = NFe.ObtemVersao(XML)
        Dim CAMPOS As String = "ARQUIVO, LOGO, DATA_IMPORTACAO, CIA_COD, " & Join(NFCampos, ", ")
        Dim VARIAVEIS As String = ":ARQUIVO, :LOGO, :DATA_IMPORTACAO, :CIA_COD, " & ":" & Join(NFCampos, ", :")
        Dim VALORES As ArrayList = ParamArrayToArrayList(":ARQUIVO", Arq, ":LOGO", LOGO, ":DATA_IMPORTACAO", Now, ":CIA_COD", CODCIA, VET)

        Try
            Icraft.IcftBase.DSGrava("INSERT INTO IM.NF (" & CAMPOS & ") VALUES (" & VARIAVEIS & ")", Login.Strconn, VALORES)
        Catch EX As Exception


            'BLOCO PARA FACILITAR DEPURAÇÃO... PROCURA CAMPO COM PROBLEMA.
            Dim ERRO As String = ""
            For XX As Integer = 6 To Split(VARIAVEIS, ", ").Count - 1
                Dim C = (From P In Split(CAMPOS, ", ") Take XX).ToArray
                Dim V = (From P In Split(VARIAVEIS, ", ") Take XX).ToArray
                Try
                    Icraft.IcftBase.DSGrava("INSERT INTO IM.NF (" & Join(C.ToArray, ", ") & ") VALUES (" & Join(V.ToArray, ", ") & ")", Login.Strconn, VALORES)
                    Icraft.IcftBase.DSGrava("DELETE IM.NF WHERE CIA_COD = :CIA_COD AND  INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF", Login.Strconn, VALORES)
                Catch EX2 As Exception
                    ERRO = "Erro ao incluir " & V.Last & ": " & EX2.Message
                    Exit For
                End Try
            Next


            Throw New Exception("Problemas ao tentar gravar NF " & NOTASERIE & "-" & NOTANUM & " obtida de arquivo " & Arquivo & ": " & EX.Message)
        End Try

        Dim XMLITEM As System.Xml.XmlNode = Nothing
        Try
            XMLITEM = XML.Item("nfeProc").Item("NFe").Item("infNFe").Item("det")
        Catch
        End Try
        Dim XMLVOL As System.Xml.XmlNode = Nothing
        Try
            XMLVOL = XML.Item("nfeProc").Item("NFe").Item("infNFe").Item("transp").Item("vol")
        Catch
        End Try
        Dim XMLDUP As System.Xml.XmlNode = Nothing
        Try
            XMLDUP = XML.Item("nfeProc").Item("NFe").Item("infNFe").Item("cobr").Item("dup")
        Catch
        End Try
        Dim XMLREBOQUE As System.Xml.XmlNode = Nothing
        Try
            XMLREBOQUE = XML.Item("nfeProc").Item("NFe").Item("infNFe").Item("transp").Item("reboque")
        Catch
        End Try


        Try
            If Not IsNothing(XMLVOL) Then
                CAMPOS = "INFNFE_IDE_SERIE, INFNFE_IDE_NNF, NF_CIA_COD, SEQ, VOL_ESP, VOL_MARCA, VOL_NVOL, VOL_PESOB, VOL_PESOL, VOL_QVOL"
                VARIAVEIS = ":INFNFE_IDE_SERIE, :INFNFE_IDE_NNF, :NF_CIA_COD, :SEQ, :VOL_ESP, :VOL_MARCA, :VOL_NVOL, :VOL_PESOB, :VOL_PESOL, :VOL_QVOL"

                Do While Not IsNothing(XMLVOL) AndAlso XMLVOL.Name = "vol"
                    Dim VOL_ESP As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("esp"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    Dim VOL_MARCA As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("marca"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    Dim VOL_NVOL As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("nVol"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    Dim VOL_PESOB As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("pesoB"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    If Not IsDBNull(VOL_PESOB) Then
                        VOL_PESOB = Val(VOL_PESOB)
                    End If
                    Dim VOL_PESOL As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("pesoL"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    If Not IsDBNull(VOL_PESOL) Then
                        VOL_PESOL = Val(VOL_PESOL)
                    End If
                    Dim VOL_QVOL As Object = NZV(ObtemDoXmlElem(XMLVOL.Item("qVol"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    If Not IsDBNull(VOL_QVOL) Then
                        VOL_QVOL = Val(VOL_QVOL)
                    End If
                    Dim VOL_ITEM As Integer = DSProxSeq("SEQ", "IM.NF_VOLUME", Login.Strconn, "INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF AND NF_CIA_COD = :NF_CIA_COD", ":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA)
                    VALORES = ParamArrayToArrayList(":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA, ":SEQ", VOL_ITEM, ":VOL_ESP", VOL_ESP, ":VOL_MARCA", VOL_MARCA, ":VOL_NVOL", VOL_NVOL, ":VOL_PESOB", VOL_PESOB, ":VOL_PESOL", VOL_PESOL, ":VOL_QVOL", VOL_QVOL)
                    Icraft.IcftBase.DSGrava("INSERT INTO IM.NF_VOLUME (" & CAMPOS & ") VALUES (" & VARIAVEIS & ")", Login.Strconn, VALORES)
                    XMLVOL = XMLVOL.NextSibling
                Loop
            End If

            If Not IsNothing(XMLDUP) Then
                CAMPOS = "INFNFE_IDE_SERIE, INFNFE_IDE_NNF, NF_CIA_COD, SEQ, DUP_NDUP, DUP_DVENC, DUP_VDUP"
                VARIAVEIS = ":INFNFE_IDE_SERIE, :INFNFE_IDE_NNF, :NF_CIA_COD, :SEQ, :DUP_NDUP, :DUP_DVENC, :DUP_VDUP"

                Do While Not IsNothing(XMLDUP) AndAlso XMLDUP.Name = "dup"
                    Dim DUP_NDUP As Object = NZV(ObtemDoXmlElem(XMLDUP.Item("nDup"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    Dim DUP_DVENC As Object = NZV(ObtemDoXmlElem(XMLDUP.Item("dVenc"), TipoExtracao.FirstChildValue), System.Convert.DBNull)
                    Dim DUP_VDUP As Object = NZV(ObtemDoXmlElem(XMLDUP.Item("vDup"), TipoExtracao.FirstChildValue), System.Convert.DBNull)

                    Dim DUP_ITEM As Integer = DSProxSeq("SEQ", "IM.NF_DUP", Login.Strconn, "INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF AND NF_CIA_COD = :NF_CIA_COD", ":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA)
                    VALORES = ParamArrayToArrayList(":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA, ":SEQ", DUP_ITEM, ":DUP_NDUP", DUP_NDUP, ":DUP_DVENC", DUP_DVENC, ":DUP_VDUP", DUP_VDUP)
                    Icraft.IcftBase.DSGrava("INSERT INTO IM.NF_DUP (" & CAMPOS & ") VALUES (" & VARIAVEIS & ")", Login.Strconn, VALORES)
                    XMLDUP = XMLDUP.NextSibling
                Loop
            End If

            If Not IsNothing(XMLREBOQUE) Then
                CAMPOS = "INFNFE_IDE_SERIE, INFNFE_IDE_NNF, NF_CIA_COD, SEQ, PLACA, RNTC, UF"
                VARIAVEIS = ":INFNFE_IDE_SERIE, :INFNFE_IDE_NNF, :NF_CIA_COD, :SEQ, :PLACA, :RNTC, :UF"

                Do While Not IsNothing(XMLREBOQUE) AndAlso XMLREBOQUE.Name = "reboque"
                    Dim REBOQUE_PLACA As String = NZV(ObtemDoXmlElem(XMLREBOQUE.Item("placa"), TipoExtracao.FirstChildValue), "")
                    Dim REBOQUE_RNTC As String = NZV(ObtemDoXmlElem(XMLREBOQUE.Item("RNTC"), TipoExtracao.FirstChildValue), "")
                    Dim REBOQUE_UF As String = NZV(ObtemDoXmlElem(XMLREBOQUE.Item("UF"), TipoExtracao.FirstChildValue), "")
                    Dim REBOQUE_ITEM As Integer = DSProxSeq("SEQ", "IM.NF_REBOQUE", Login.Strconn, "INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF AND NF_CIA_COD = :NF_CIA_COD", ":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA)
                    VALORES = ParamArrayToArrayList(":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA, ":SEQ", REBOQUE_ITEM, ":PLACA", REBOQUE_PLACA, ":RNTC", REBOQUE_RNTC, ":UF", REBOQUE_UF)
                    Icraft.IcftBase.DSGrava("INSERT INTO IM.NF_REBOQUE (" & CAMPOS & ") VALUES (" & VARIAVEIS & ")", Login.Strconn, VALORES)
                    XMLREBOQUE = XMLREBOQUE.NextSibling
                Loop
            End If


            If Not IsNothing(XMLITEM) Then
                CAMPOS = "INFNFE_IDE_SERIE, INFNFE_IDE_NNF, NF_CIA_COD, SEQ, " & Join(NFICampos, ", ")
                VARIAVEIS = ":INFNFE_IDE_SERIE, :INFNFE_IDE_NNF, :NF_CIA_COD, :SEQ, :" & Join(NFICampos, ", :")

                Do While XMLITEM.Name = "det"
                    Dim ITEMSEQ As Integer = XMLITEM.Attributes("nItem").Value
                    Dim PREF As New Xml.XmlDocument
                    PREF.LoadXml(<?xml version="1.0" encoding="UTF-8"?>
                                 <nfeProc>
                                     <NFe>
                                         <infNFe>
                                         </infNFe>
                                     </NFe>
                                 </nfeProc>.ToString)
                    PREF.FirstChild.FirstChild.FirstChild.InnerXml = XMLITEM.OuterXml

                    Dim VETI As ArrayList = XmlElemParams(PREF, NFICONV)

                    VALORES = ParamArrayToArrayList(":INFNFE_IDE_SERIE", NOTASERIE, ":INFNFE_IDE_NNF", NOTANUM, ":NF_CIA_COD", CODCIA, ":SEQ", ITEMSEQ, VETI)

                    Try
                        Icraft.IcftBase.DSGrava("INSERT INTO IM.NF_ITEM (" & CAMPOS & ") VALUES (" & VARIAVEIS & ")", Login.Strconn, VALORES)
                    Catch EX As Exception


                        Dim ERRO As String = ""
                        For XX As Integer = 4 To Split(VARIAVEIS, ", ").Count - 1
                            Dim C = (From P In Split(CAMPOS, ", ") Take XX).ToArray
                            Dim V = (From P In Split(VARIAVEIS, ", ") Take XX).ToArray
                            Try
                                Icraft.IcftBase.DSGrava("INSERT INTO IM.NF_ITEM (" & Join(C.ToArray, ", ") & ") VALUES (" & Join(V.ToArray, ", ") & ")", Login.Strconn, VALORES)
                                Icraft.IcftBase.DSGrava("DELETE IM.NF_ITEM WHERE NF_CIA_COD = :NF_CIA_COD AND  INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF", Login.Strconn, VALORES)
                            Catch EX2 As Exception
                                ERRO = "Erro ao incluir " & V.Last & ": " & EX2.Message
                                Exit For
                            End Try
                        Next


                        Throw New Exception("Problemas ao tentar gravar NF_ITEM " & NOTASERIE & "-" & NOTANUM & " item " & ITEMSEQ & " obtida de arquivo " & Arquivo & ": " & ERRO)
                    End Try

                    XMLITEM = XMLITEM.NextSibling
                Loop
            End If
        Catch ex As Exception
            ' caso ocorra erro, deixa base livre da nf incluída
            Dim V As Dictionary(Of String, Object) = ParamArrayToDict(VALORES)
            NFe.ApagaNota(V("NF_CIA_COD"), V("INFNFE_IDE_SERIE"), V("INFNFE_IDE_NNF"))
            Throw ex
        End Try

    End Sub

    Private Sub btnmover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmover.Click
        If txtDir.Text = "" Then
            MsgBox("INFORME UM DIRETÓRIO DE DESTINO.")
            Exit Sub
        End If

        Dim L As ArrayList = Icraft.IcftBase.ListaDir("C:\NOTAXML", "*.XML", True)
        Dim tot As Integer = 0
        For Each arq As String In L
            Dim DIV() As String = Split(arq, "\")
            If TemNaLista(DirEspec, DIV(2)) Then
                Dim Xml As New System.Xml.XmlDocument
                Xml.Load(arq)

                Try
                    Dim NOTANUM As Integer = NFe.OBTEMNOTANUM(Xml)
                    Dim NOTASERIE As Integer = NFe.ObtemNotaSerie(Xml)
                    Dim CNPJ As String = NFe.ObtemCnpjEmit(Xml)
                    Dim CIACOD As String = ""
                    Try
                        Dim CIA As System.Data.DataSet = NFe.ObtemCia(CNPJ)
                        CIACOD = CIA.Tables(0).Rows(0)("COD")
                    Catch
                    End Try

                    If txtserie.Text = "" OrElse NOTASERIE = Val(txtserie.Text) Then
                        If (txtini.Text = "" OrElse NOTANUM >= Val(txtini.Text)) And (txtfim.Text = "" OrElse NOTANUM <= Val(txtfim.Text)) Then
                            NFe.ApagaNota(CIACOD, NOTASERIE, NOTANUM)
                            System.IO.File.Move(arq, Icraft.IcftBase.FileExpr(txtDir.Text, System.IO.Path.GetFileName(arq)))
                            tot += 1
                        End If
                    End If
                Catch EX As Exception
                End Try

            End If
        Next
        MsgBox("retorno de notas concluído (total:" & tot & " transf.)")
    End Sub

End Class