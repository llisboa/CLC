Public Class Local

    Shared _Tabela As String
    Public Shared Property Tabela() As String
        Get
            Return _Tabela
        End Get
        Set(ByVal value As String)
            _Tabela = value
        End Set
    End Property

    Shared _NomeTabela As String
    Public Shared Property NomeTabela() As String
        Get
            Return _NomeTabela
        End Get
        Set(ByVal value As String)
            _NomeTabela = value
        End Set
    End Property

    Shared _Filtro As String
    Public Shared Property Filtro() As String
        Get
            Return _Filtro
        End Get
        Set(ByVal value As String)
            _Filtro = value
        End Set
    End Property

    Public Shared UsuarioConfig As Icraft.IcftBase.ElementosStr

    Shared Function InSQL(ByVal SQL As String)
        Dim ArStatus As Array = SQL.Split(";")
        Dim InStatus As String = ""
        For i As Integer = 0 To ArStatus.Length - 1
            InStatus &= " etiq_status_cod IN ('" & ArStatus(i) & "') OR "
        Next
        If InStatus.Contains("OR") Then
            InStatus = InStatus.Substring(0, InStatus.LastIndexOf("OR"))
        End If
        Return InStatus
    End Function


    Shared Function NomeExec() As String
        Return Replace(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase, "file:///", "")
    End Function

    Shared Function BaseDir() As String
        Return System.IO.Path.GetDirectoryName(NomeExec)
    End Function

    Public Shared Sub MostraForm(ByVal Formulario As Object, Optional ByVal Princ As Form = Nothing, Optional ByVal NomeTabela As String = "", Optional ByVal Filtro As String = "")
        MostraForm("", Formulario, Princ, NomeTabela, Filtro)
    End Sub

    Public Shared Function MostraForm(ByVal Titulo As String, ByVal Formulario As Object, Optional ByVal Princ As Form = Nothing, Optional ByVal NomeTabela As String = "", Optional ByVal Filtro As String = "") As Windows.Forms.Form
        Dim F As Form = Nothing
        Dim AcessoOK As Boolean = False
        If TypeOf Formulario Is String Then
            F = FormPorNome(Formulario)
            If IsNothing(F) Then
                If Not Login.Perm.Contains("ADM") Then
                    If Not PermOK(Apl.Esquema, "AUTOTABFORM", NomeTabela, "ACC") Then
                        MsgBox("Acesso negado.", MsgBoxStyle.Information, "Acesso Restrito")
                        Return Nothing
                    Else
                        AcessoOK = True
                    End If
                End If
                F = New Windows.Forms.Form
                F.Name = "AutoTab" & NomeTabela
                Dim WF As New Local.Auto(F, Apl.Esquema, Apl.Esquema, Apl.Esquema, NomeTabela, Login.Strconn, , , UsuarioConfig.ToStyleStr)
            End If
        Else
            F = Formulario
        End If
        If Not Login.Perm.Contains("ADM") Then
            If Not AcessoOK AndAlso Not PermOK(Apl.Esquema, "FORMULÁRIO", F.Name, "ACC") Then
                MsgBox("Acesso negado.", MsgBoxStyle.Information, "Acesso Restrito")
                Return Nothing
            End If
        End If
        If Not IsNothing(Princ) Then
            F.MdiParent = Princ
            F.Icon = Princ.Icon.Clone
        End If
        If NomeTabela <> "" Then
            Local._NomeTabela = NomeTabela
        End If
        If Filtro <> "" Then
            Local._Filtro = Filtro
        End If
        F.ShowInTaskbar = False
        F.ShowIcon = False
        F.Show()
        F.Focus()
        F.Size = New Size(750, 550)
        F.Location = New System.Drawing.Point(0, 0)
        Dim AbrirMax As Boolean = False
        Try
            AbrirMax = CType(Icraft.IcftBase.NZ(Icraft.IcftBase.TrimCasado(Local.UsuarioConfig.Items("AbrirFormMaximizado").Conteudo, "'", "'"), False), Boolean)
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
        If AbrirMax Then
            F.WindowState = FormWindowState.Maximized
        End If
        If Titulo <> "" Then
            F.Text = Titulo
        End If
        Return F
    End Function

    Public Shared DefMaximizado As Boolean = False

    Public Shared Function FormPorNome(ByVal Nome As String) As Form
        Select Case UCase(Nome)
            Case "LOGIN"
                Return My.Forms.Login
            Case "PRINC"
                Return My.Forms.Princ
            Case "SOBRESISTEMA"
                Return My.Forms.SobreSistema
        End Select
        Return Nothing
    End Function

    Shared Sub MostraErr(ByVal Ex As Exception, ByVal Titulo As String)
        Dim Msg As String = Icraft.IcftBase.MessageEx(Ex, Titulo)
        MsgBox(Msg, MsgBoxStyle.Critical, Titulo)
    End Sub

    Class Auto
        Public Criado As GeraFormApl = Nothing
        Sub New(ByVal Formulario As Form, ByVal Sistema As String, ByVal EsquemaPrinc As String, ByVal EsquemaGerador As String, ByVal Tabela As String, ByVal StrConn As Object, Optional ByVal LargEtiq As Integer = 0, Optional ByVal LargCampo As Integer = 0, Optional ByVal UsuarioConfig As String = "", Optional ByVal ContainerParaCriacao As Object = Nothing, Optional ByVal Consulta As String = "")
            Criado = New GeraFormApl(Formulario, Sistema, EsquemaPrinc, EsquemaGerador, Tabela, StrConn, UCase(Login.Usuario!USUARIO), LargEtiq, LargCampo, UsuarioConfig, ContainerParaCriacao, Consulta)
            AddHandler Criado.MostraStatus, AddressOf MostraStatus
        End Sub
        Public Shared Sub MostraStatus(ByVal Texto As String)
            Princ.MostraStatus(Texto)
        End Sub
    End Class

    ' TRATAMENTO DE ERRO

    Public Shared Sub Trata_Domain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Dim Ex As Exception = DirectCast(e.ExceptionObject, Exception)
        Trata_UnhandledException(sender, Ex)
    End Sub

    Public Shared Sub Trata_Thread_UnhandledException(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
        Dim Ex As Exception = e.Exception
        Trata_UnhandledException(sender, Ex)
    End Sub

    Public Shared Sub Trata_UnhandledException(ByVal sender As Object, ByVal Ex As Exception)
        Dim Compl As String = ""
        Dim AppTitulo As String = My.Application.Info.Title & " - " & Icraft.IcftBase.VersaoApl
        Try
            Compl = "(login no sistema: " & Login.txtLogin.Text & ")"
        Catch
        End Try
        Try
            Dim Mess As String = Icraft.IcftBase.TextoLogEx(Ex, Compl)
            Dim Arq As String = Icraft.IcftBase.FileExpr(System.IO.Path.GetDirectoryName(Application.ExecutablePath), AppTitulo & ".log")
            Icraft.IcftBase.GravaLog(Arq, Mess)
        Catch Ex2 As Exception
            MsgBox("Erro na tentativa de registro de log. Aplicativo não pode continuar. Mais detalhes:" & Ex2.Message & ".", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Falha Crítica em " & Princ.Text)
            Application.ExitThread()
        End Try
        MsgBox(Icraft.IcftBase.MessageEx(Ex), MsgBoxStyle.Critical, "Falha em " & Princ.Text)
    End Sub

    Public Shared Function PermOK(ByVal GerEsquema As String, ByVal Tipo As String, ByVal Recurso As String, ByVal Permissao As String) As Boolean
        Try
            Dim PARAMS As New ArrayList
            PARAMS.Add(":USUARIO")
            PARAMS.Add(UCase(Login.Usuario!USUARIO))
            PARAMS.Add(":RECURSO")
            PARAMS.Add(UCase(Recurso))
            PARAMS.Add(":TIPO")
            PARAMS.Add(UCase(Tipo))
            PARAMS.Add(":PERMISSAO")
            PARAMS.Add(";" & UCase(Permissao) & ";")
            Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT COUNT(*) FROM " & GerEsquema & ".GER_DIREITO WHERE EXISTS(SELECT * FROM " & GerEsquema & ".GER_USUARIO WHERE INSTR(';' || UPPER(GRUPO) || ';',';ADM;')<>0 AND UPPER(USUARIO)=:USUARIO) OR (INSTR(';' || UPPER(PERMISSAO) || ';', :PERMISSAO)<>0 AND (UPPER(USUARIO) = :USUARIO OR UPPER(GRUPO) = (SELECT UPPER(GRUPO) FROM " & GerEsquema & ".GER_USUARIO WHERE USUARIO = :USUARIO)) AND (UPPER(OBJETO_TIPO) = :TIPO AND (UPPER(OBJETO_NOME) = :RECURSO OR UPPER(OBJETO_CLASSE) =   (SELECT UPPER(CLASSE)      FROM " & GerEsquema & ".GER_ADICIONAL_OBJ WHERE TIPO =:TIPO AND UPPER(OBJETO) =:RECURSO ))))", Login.Strconn, PARAMS)
            If Not IsNothing(DS) AndAlso DS.Tables.Count = 1 AndAlso DS.Tables(0).Rows.Count > 0 AndAlso DS.Tables(0).Rows(0)(0) <> 0 Then
                Return True
            End If
        Catch EX As Exception
        End Try
        Return False
    End Function

    Public Shared Function DirCorrente() As String
        Return System.IO.Path.GetDirectoryName(Application.ExecutablePath)
    End Function


    Shared Function PreparaDS(ByVal Rel As String, ByVal DSN As String, ByVal Pesquisas As Dictionary(Of String, String), ByVal FF As Icraft.IcftFFiltro, ByVal Criterio As String) As System.Data.DataSet
        Dim DS As New System.Data.DataSet
        DS.ReadXmlSchema(Icraft.IcftBase.FileExpr(DirCorrente, "RELATORIOS", DSN & ".xsd"))
        Dim Logo As Object = Icraft.IcftBase.DSArquivo("SELECT CONFIG CAMINHO FROM " & Apl.Esquema & ".SYS_CONFIG_GLOBAL WHERE PARAM='RELATORIO_LOGO'", Login.Strconn, , Apl.Esquema)

        Dim Pos As Integer = 0
        For Each Chave As String In Pesquisas.Keys

            Dim TTB As String
            Dim CRIT As String = ""

            If Pos = 0 Then

                Dim FFSQL As String = ""
                Try
                    FFSQL = FF.SQL
                Catch
                End Try
                Dim FFCRITERIOSQL As String = ""
                Try
                    FFCRITERIOSQL = FF.CriterioSQL
                Catch
                End Try

                If IsNothing(FF) OrElse FFSQL = "" Then
                    TTB = Pesquisas(Chave)
                Else
                    TTB = "(" & FFSQL & ")"
                End If

                If Criterio <> "" Then
                    TTB = "(SELECT * FROM " & TTB & " WHERE " & Criterio & ")"
                End If

                If Not IsNothing(FF) Then
                    CRIT = FFCRITERIOSQL
                End If
            Else
                TTB = Pesquisas(Chave)
            End If

            If DSN = "BoletoRelItau" Then
                Dim b As New Icraft.IcftBase.Boleto
                b.StrConn = Login.Strconn
                b.CarregaApartirDeConsulta(TTB, Login.Strconn)
                Return b.DS
            End If

            Dim TB As System.Data.DataTable

            If Pos = 0 Then
                TB = DS.Tables(0)
            Else
                TB = Nothing
                If Icraft.IcftBase.Exists(DS.Tables, Chave, "TableName") Then
                    TB = DS.Tables(Chave)
                Else
                    Dim NOMET As String = Icraft.IcftBase.NZ(Icraft.IcftBase.LItem(TTB, 2), TTB)
                    If Icraft.IcftBase.Exists(DS.Tables, NOMET, "TableName") Then
                        TB = DS.Tables(NOMET)
                    ElseIf Icraft.IcftBase.Exists(DS.Tables, "TB_" & NOMET, "TableName") Then
                        TB = DS.Tables("TB_" & NOMET)
                    End If
                End If
                If IsNothing(TB) Then
                    Throw New Exception("Tabela '" & Chave & "' não encontrada na pesquisa do relatório.")
                End If
            End If

            Dim Ar As New ArrayList

            For Each Linha As System.Data.DataRow In Icraft.IcftBase.DSCarrega("SELECT * FROM " & TTB & IIf(CRIT <> "", " WHERE " & CRIT, ""), Login.Strconn).Tables(0).Rows
                Ar.Clear()

                For Each Coluna As System.Data.DataColumn In TB.Columns
                    If Coluna.ColumnName = "_LOGOTIPO" Then
                        Ar.Add(Logo)
                    ElseIf Coluna.ColumnName.StartsWith("IMG_BARRAS_") Then
                        Dim Barra As New Icraft.IcftBase.CodBarras
                        Barra.AlturaPx = 50
                        Dim TEXTO As String = Icraft.IcftBase.TrocaTexto(Icraft.IcftBase.NZV(Linha(Coluna.ColumnName), ""), "(", "", ")", "", ".", "")
                        If Trim(TEXTO) <> "" Then
                            Barra.Text = TEXTO
                            If System.Text.RegularExpressions.Regex.Match(TEXTO, "[^0-9]").Success Then
                                Barra.Metodo = Icraft.IcftBase.CodBarras.MetodoOpc.ImagemInteiraCode128B
                                Barra.LarguraPx = (Len(TEXTO) + 4) * 11
                            Else
                                Barra.Metodo = Icraft.IcftBase.CodBarras.MetodoOpc.ImagemInteiraCode128C
                                Barra.LarguraPx = (Len(TEXTO) / 2 + 4) * 11
                            End If
                            Barra.Extensao = "gif"
                            Dim bit As System.Drawing.Bitmap = Barra.ObtemImagemInteira
                            If Rel = "RPTETIQUETALAND" Then
                                bit.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            End If
                            Dim map As New System.IO.MemoryStream
                            bit.Save(map, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Ar.Add(map.ToArray)
                        Else
                            Ar.Add(System.Convert.DBNull)
                        End If
                    Else
                        Try
                            If Coluna.DataType.ToString = "System.Byte[]" Then
                                Ar.Add(System.Convert.DBNull)
                            Else
                                Ar.Add(Linha(Coluna.ColumnName))
                            End If
                        Catch EX As Exception
                            Ar.Add(System.Convert.DBNull)
                        End Try
                    End If
                Next

                Try
                    TB.Rows.Add(Ar.ToArray)
                Catch EX As System.Data.InvalidConstraintException
                End Try
            Next
            Pos += 1
        Next

        Return DS
    End Function

    Shared Function MontaSqlPeso(ByVal Name As String, ByVal Text As String)
        Dim Ar As Array = Name.Split(";")
        Dim SQL As String = ""
        If Text = "GERENCIAL" Then
            SQL = Ar(0)
        ElseIf Text = "INTERPRETADO" Then
            SQL = Ar(1)
        End If
        Return SQL
    End Function

    Shared Sub MostraRelatorio(ByVal NomeRelatorio As String, Optional ByVal Criterio As String = "", Optional ByVal NoArquivo As String = "")
        Dim REL As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT * FROM " & Apl.Esquema & ".GER_ADICIONAL_OBJ WHERE TIPO = 'RELATÓRIO' AND OBJETO = '" & NomeRelatorio & "'", Login.Strconn)
        If REL.Tables.Count = 0 OrElse REL.Tables(0).Rows.Count = 0 Then
            Icraft.IcftBase.TrataErro(Princ, New Exception("Relatório " & NomeRelatorio & " inexistente. Suporte foi comunicado."), "Clique no menu principal.")
        Else
            Dim DEF As New Local.RelDets(REL.Tables(0).Rows(0)!PROP_EXTEND)
            Local.MostraRelatorio(DEF.Etiq, REL.Tables(0).Rows(0)!OBJETO, DEF.DS, DEF.Pesquisas, Nothing, Criterio, NoArquivo)
        End If
    End Sub



    Shared Sub MostraRelatorio(ByVal Rel As String, ByVal Rpt As String, ByVal DSNome As String, ByVal Pesquisas As Dictionary(Of String, String), ByVal FF As Icraft.IcftFFiltro, Optional ByVal Criterio As String = "", Optional ByVal NoArquivo As String = "")
        Try
            frmAlerta.Show("Relatório sendo construído. Aguarde.", Rel)

            Dim RELOB As Object = Apl.ReportPorNome(Rpt)
            Dim DS As System.Data.DataSet = Local.PreparaDS(Rpt, DSNome, Pesquisas, FF, Criterio)

            Dim ip As String = ""
            Try
                ip = Icraft.IcftBase.IPLocal()(0)
            Catch ex As Exception
            End Try
            Dim Titulo As String = Rel

            If Not TypeOf RELOB Is RptViagemFech Then
                RELOB.SetDataSource(DS)
            Else
                RELOB.SetDataSource(DS.Tables(0))
                CType(RELOB, RptViagemFech).Subreports(0).Database.Tables(0).SetDataSource(DS.Tables(1))
            End If

            Dim R As New frmRelImp
            R.Rpt.ReportSource = RELOB

            For Each Param As String In Split("MostraIP;MostraFiltro;MostraTitulo;MostraEmpresa;MostraVersao;MostraUsuario;MostraDataHora;MostraLogo", ";")
                Try
                    Select Case Param
                        Case "MostraIP"
                            RELOB.SetParameterValue("MostraIP", ip)
                        Case "MostraFiltro"
                            RELOB.SetParameterValue("MostraFiltro", "")
                        Case "MostraTitulo"
                            RELOB.SetParameterValue("MostraTitulo", Titulo)
                        Case "MostraEmpresa"
                            RELOB.SetParameterValue("MostraEmpresa", "Sociedade Brasileira de Dermatologia")
                        Case "MostraVersao"
                            RELOB.SetParameterValue("MostraVersao", "V" & My.Application.Info.Version.ToString)
                        Case "MostraUsuario"
                            RELOB.SetParameterValue("MostraUsuario", Login.Usuario!USUARIO)
                        Case "MostraDataHora"
                            RELOB.SetParameterValue("MostraDataHora", Icraft.IcftBase.DSValor("SYSDATE", "DUAL", Login.Strconn, ""))
                    End Select
                Catch
                End Try
            Next

            R.Text = "Relatório: " & Titulo
            If NoArquivo <> "" Then
                RELOB.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, NoArquivo)
            Else
                R.Rpt.Show()
            End If

            Local.MostraForm(R, Princ)
            Princ.lblStatus.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
            frmAlerta.TH.Abort()
            frmAlerta.TH.Join()
            frmAlerta.TH = Nothing
        End Try
        frmAlerta.HIDE()
    End Sub

    Class RelDets
        Public Rpt As String
        Public DS As String
        Public Etiq As String
        Public Descr As String
        Public Consulta As String
        Public BuscaDefs As String
        Public FiltroCamposSQL As String
        Public Ordem As Integer
        Public Pesquisas As New Dictionary(Of String, String)
        Sub New(ByVal Elems As String)
            Dim ELEM As New Icraft.IcftBase.ElementosStr(Elems)
            Me.Ordem = Ordem
            Rpt = ELEM("RPT").Conteudo
            DS = ELEM("DS").Conteudo
            Etiq = ELEM("ETIQ").Conteudo
            Descr = ELEM("DESCR").Conteudo
            Consulta = ELEM("CONSULTA").Conteudo
            BuscaDefs = ELEM("BUSCADEFS").Conteudo
            FiltroCamposSQL = ELEM("FILTROCAMPOSSQL").Conteudo
            Ordem = Icraft.IcftBase.NZV(ELEM("ORDEM").Conteudo, 0)
            Pesquisas.Clear()
            If Consulta <> "" Then
                Pesquisas.Add("Tabela", Consulta)
            End If

            For z As Integer = 0 To ELEM.Count - 1
                Dim Nome As String = UCase(ELEM.Items(z).Nome)
                If Not Icraft.IcftBase.TemNaLista("RPT;DS;ETIQ;DESCR;CONSULTA;BUSCADEFS;FILTROCAMPOSSQL;ORDEM", Nome) Then
                    Pesquisas.Add(Nome, ELEM.Items(z).Conteudo)
                End If
            Next
        End Sub

    End Class

    Public Shared Function TrimCasado(ByVal Texto As String, ByVal Inicio As String, Optional ByVal Final As String = "") As String
        If Final = "" Then Final = Inicio
        Do While True
            If Texto.StartsWith(Inicio) AndAlso Texto.EndsWith(Final) Then
                Dim TamInicio As Integer = Len(Inicio)
                Texto = Mid(Texto, TamInicio + 1, Len(Texto) - TamInicio - Len(Final))
            Else
                Exit Do
            End If
        Loop
        Return Texto
    End Function

    Class GeraFormApl

        Property ChaveConcatStr() As Object
            Get
                Return Frm.Text
            End Get
            Set(ByVal value As Object)
                Frm.Text = value
            End Set
        End Property

        Sub CarregaCamposEmGeral()
            Frm.Bind()
        End Sub

        Public Frm As New Icraft.IcftFForm

        Sub New(ByVal Formulario As Windows.Forms.Form, ByVal Sistema As String, ByVal EsquemaPrinc As String, ByVal EsquemaGerador As String, ByVal Tabela As String, ByVal StrConn As Object, ByVal Usuario As String, Optional ByVal LargEtiq As Integer = 0, Optional ByVal LargCampo As Integer = 0, Optional ByVal UsuarioConfig As String = "", Optional ByVal ContainerParaCriacao As Object = Nothing, Optional ByVal Consulta As String = "")
            If IsNothing(ContainerParaCriacao) Then
                Formulario.Controls.Add(Frm)
            Else
                ContainerParaCriacao.CONTROLS.add(Frm)
            End If

            Frm.Consulta = Consulta
            Frm.Dock = System.Windows.Forms.DockStyle.Fill
            Frm.DYEspacoPX = 10
            Frm.EsquemaGerador = Apl.Esquema
            Frm.EsquemaPrinc = Apl.Esquema
            Frm.LargCampo = 400
            Frm.LargEtiq = 140
            Frm.Location = New System.Drawing.Point(0, 0)
            Frm.MinimumSize = New System.Drawing.Size(616, 390)
            Frm.Name = "FRM"
            Frm.Sistema = Apl.Esquema
            Frm.Size = New System.Drawing.Size(877, 450)
            Frm.StrConn = Login.Strconn
            Frm.Tabela = Tabela
            Frm.TabIndex = 0
            Frm.TempoAteMostrarRegMili = 0
            Frm.TipoForm = Icraft.IcftFForm.TipoFormOpc.Form
            Frm.Usuario = Usuario
            Frm.UsuarioConfig = UsuarioConfig

            Frm.Bind()
        End Sub

        Public Event MostraStatus(ByVal Texto As String)
        Public Event AntesDeGravar(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)
        Public Event AntesDeExcluir(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)
        Public Event AposGravar(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)

    End Class

    Shared Function EscolhaParam(ByVal Tipo As Object, ByVal ParamArray Param() As String)
        Dim Pos As Integer = 0
        Try
            Pos = Val(Tipo.text)
        Catch
        End Try
        If Pos > 0 Then
            Pos -= 1
        End If
        If Pos >= Param.Length Then
            Pos = 0
        End If
        Return Param(Pos)
    End Function

End Class
