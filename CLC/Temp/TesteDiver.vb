Public Class TesteDiver


    Private Sub TesteDiver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsNothing(t) Then
            t.Parent.Controls.Remove(t)
        End If
        t = New Windows.Forms.TabControl
        t.Name = "tabPrinc"
        t.Height = 300
        t.Width = 600
        t.Left = 50
        t.Top = 50
        t.Dock = DockStyle.Fill
        Me.Controls.Add(t)
        t.BringToFront()

        Icraft.IcftBase.Form.Conteudo(Me, "TXT") = Icraft.IcftBase.DSConfig(Login.Strconn, "FORM_TESTE", Apl.Esquema & ".SYS_CONFIG_GLOBAL")

        Dim TBE As New Windows.Forms.TabPage("ESTRUTURA")
        t.TabPages.Add(TBE)
        EE = New Windows.Forms.DataGrid
        EE.Name = "GRDTOT"
        TBE.Controls.Add(EE)
        EE.Dock = DockStyle.Fill

    End Sub

    Private Sub btnEscolher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscolher.Click
        dlg.SelectedPath = txtArq.Text
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtArq.Text = dlg.SelectedPath
            btnAtualizar_Click(sender, e)
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Icraft.IcftBase.DSConfig(Login.Strconn, "FORM_TESTE", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "TXT")
        ADS.WriteXml(Icraft.IcftBase.FileExpr(txtArq.Text, "Esquema.xml"))
        MsgBox("Gravado.")
    End Sub


    Public Function XSDDefsToDS(ByVal Diretorio As String, Optional ByVal PrefNome As String = "", Optional ByVal DS As System.Data.DataSet = Nothing, Optional ByVal Elem As Object = Nothing) As System.Data.DataSet
        If IsNothing(DS) Then
            DS = Icraft.IcftBase.DSTabCols(Nothing, "", _
                                                         New Icraft.IcftBase.TabCol("SEQ", 0), _
                                                         New Icraft.IcftBase.TabCol("ARQUIVO", "x"), _
                                                         New Icraft.IcftBase.TabCol("DEF", "x"), _
                                                         New Icraft.IcftBase.TabCol("DESCR", "x"), _
                                                         New Icraft.IcftBase.TabCol("MIN", "x"), _
                                                         New Icraft.IcftBase.TabCol("MAX", "x"), _
                                                         New Icraft.IcftBase.TabCol("TIPO_BASE", "x"), _
                                                         New Icraft.IcftBase.TabCol("ENUM", "x"), _
                                                         New Icraft.IcftBase.TabCol("REGEX", "x"), _
                                                         New Icraft.IcftBase.TabCol("OBRIG", "x") _
                                                    )
        End If

        If IsNothing(Elem) Then
            Dim xml As New System.Xml.Schema.XmlSchemaSet
            For Each F As String In Icraft.IcftBase.ListaDir(Diretorio, "*.xsd")
                xml.Add(Nothing, Icraft.IcftBase.FileExpr(F))
            Next
            xml.Compile()
            Elem = xml.GlobalTypes.Values
        End If

        For Each obj In Elem

            If TypeOf obj Is System.Xml.Schema.XmlSchemaSequence Or TypeOf obj Is System.Xml.Schema.XmlSchemaChoice Then
                XSDDefsToDS(Diretorio, PrefNome, DS, obj.ITEMS)
            Else

                If Not IsNothing(obj.NAME) Then

                    If DS.Tables(0).Select("DEF='" & Icraft.IcftBase.ExprExpr("_", "", PrefNome, obj.name) & "'").Count = 0 Then

                        Dim ANNO As Object = Nothing
                        Dim Tipo As Object = Nothing
                        Dim ENUMSTR As Object = Nothing
                        Dim MINSTR As Object = Nothing
                        Dim MAXSTR As Object = Nothing
                        Dim REGEXSTR As Object = Nothing

                        Try

                            Try
                                ANNO = Trim(obj.ANNOTATION.ITEMS(0).MARKUP(0).VALUE)
                            Catch
                            End Try


                            Try
                                Tipo = obj.CONTENT.BASETYPENAME.NAME
                            Catch
                                Try
                                    Tipo = obj.ElementSchemaType.Name
                                Catch
                                End Try
                            End Try


                            Dim ENUMS As New List(Of String)
                            Dim MINS As New List(Of String)
                            Dim MAXS As New List(Of String)
                            Dim REGEXS As New List(Of String)

                            Dim VER As Object = Nothing
                            Try
                                VER = obj.CONTENT.FACETS
                            Catch
                                Try
                                    VER = obj.ElementSchemaType.CONTENT.FACETS
                                Catch
                                End Try
                            End Try

                            Try
                                For Each Item In VER
                                    Try
                                        If TypeOf Item Is System.Xml.Schema.XmlSchemaEnumerationFacet Then
                                            ENUMS.Add(Item.VALUE)
                                        ElseIf TypeOf Item Is System.Xml.Schema.XmlSchemaMinLengthFacet Then
                                            MINS.Add(Item.VALUE)
                                        ElseIf TypeOf Item Is System.Xml.Schema.XmlSchemaMaxLengthFacet Then
                                            MAXS.Add(Item.VALUE)
                                        ElseIf TypeOf Item Is System.Xml.Schema.XmlSchemaPatternFacet Then
                                            REGEXS.Add(Item.VALUE)
                                        End If
                                    Catch
                                    End Try
                                Next
                            Catch
                            End Try

                            ENUMSTR = Join(ENUMS.ToArray, ";")
                            MINSTR = Join(MINS.ToArray, ";")
                            MAXSTR = Join(MAXS.ToArray, ";")
                            REGEXSTR = Join(REGEXS.ToArray, ";")


                            Try
                                If TypeOf obj Is System.Xml.Schema.XmlSchemaComplexType Then
                                    If obj.CONTENTTYPEPARTICLE.ToString <> "System.Xml.Schema.XmlSchemaParticle+EmptyParticle" Then
                                        XSDDefsToDS(Diretorio, Icraft.IcftBase.ExprExpr("_", "", PrefNome, obj.NAME), DS, obj.CONTENTTYPEPARTICLE.ITEMS)
                                    End If
                                Else
                                    If Not IsNothing(obj.ELEMENTTYPE) Then
                                        XSDDefsToDS(Diretorio, Icraft.IcftBase.ExprExpr("_", "", PrefNome, obj.NAME), DS, obj.ELEMENTTYPE.CONTENTTYPEPARTICLE.ITEMS)
                                    End If
                                End If
                            Catch
                            End Try

                        Catch EX As Exception
                            Stop
                        End Try
                        DS.Tables(0).Rows.Add(DS.Tables(0).Rows.Count + 1, System.IO.Path.GetFileName(obj.SOURCEURI), Icraft.IcftBase.ExprExpr("_", "", PrefNome, obj.name), ANNO, MINSTR, MAXSTR, Tipo, ENUMSTR, REGEXSTR, Nothing)



                        Try
                            If Not IsNothing(obj.PARTICLE) Then
                                XSDDefsToDS(Diretorio, Icraft.IcftBase.ExprExpr("_", "", PrefNome, obj.NAME), DS, obj.PARTICLE)
                            End If
                        Catch ex As Exception
                        End Try

                    End If
                End If



            End If
        Next

        Return DS
    End Function

    Dim t As Windows.Forms.TabControl
    Dim EE As Windows.Forms.DataGrid

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            ADS = XSDDefsToDS(txtArq.Text)
            EE.DataSource = ADS.Tables(0)
        Catch EX As Exception
            MsgBox("Erro " & EX.Message)
        End Try

        Icraft.IcftBase.DSConfig(Login.Strconn, "FORM_TESTE", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "TXT")
    End Sub
    Dim ADS As System.Data.DataSet = Nothing

    Sub COPY(ByVal ORIGEM, ByVal DESTINO)
        If System.IO.File.Exists(DESTINO) Then
            Kill(DESTINO)
        End If
        System.IO.File.Copy(ORIGEM, DESTINO)
    End Sub

    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        Icraft.IcftBase.DSConfig(Login.Strconn, "FORM_TESTE", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "TXT")

        Dim campos As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT * FROM" & Apl.Esquema & ".GER_CAMPO", Login.Strconn)
        Dim DEFS As System.Data.DataTable = EE.DataSource

        For Each LINHA As System.Data.DataRow In campos.Tables(0).Rows
            Dim ELEMS As Icraft.IcftBase.ElementosStr = New Icraft.IcftBase.ElementosStr(Icraft.IcftBase.NZV(LINHA!PROP_EXTEND, ""))
            Dim EXTEND As String = ELEMS.Items("CAMPOXML").Conteudo
            If EXTEND <> "" Then
                For Each ROW As System.Data.DataRow In DEFS.Select("DEF = '" & EXTEND & "'")
                    Dim FORMATO As String = ""
                    If Icraft.IcftBase.NZV(ROW!ENUM, "") <> "" Then
                        For Each ITEM As String In Split(ROW!ENUM, ";")
                            Dim DESCR As String = Replace(ROW!DESCR, "(", Chr(10))
                            DESCR = Replace(DESCR, ")", Chr(10))
                            DESCR = Replace(DESCR, "; ", Chr(10))
                            DESCR = Replace(DESCR, ";", Chr(10))
                            Dim POS As Integer = InStr(DESCR, Chr(10) & ITEM & " - ")
                            Dim TEXTO As String = ""
                            If POS = 0 Then
                                POS = InStr(DESCR, Chr(10) & ITEM & "- ")
                                If POS = 0 Then Continue For
                                TEXTO = Mid(DESCR, POS + Len(ITEM) + 3)
                            Else
                                TEXTO = Mid(DESCR, POS + Len(ITEM) + 4)
                            End If

                            Dim POSF As Integer = InStr(TEXTO, ";")
                            If POSF = 0 Then
                                POSF = InStr(TEXTO, Chr(10))
                            End If
                            If POSF = 0 Then
                                POSF = Len(TEXTO) + 1
                            End If
                            TEXTO = Microsoft.VisualBasic.Left(TEXTO, POSF - 1)
                            FORMATO &= IIf(FORMATO <> "", ";", "") & Trim(ITEM) & ";" & Trim(Replace(TEXTO, Chr(10), " "))
                        Next
                    End If
                    If FORMATO <> "" Then
                        FORMATO = "LISTA_OPC;LISTA:'" & Replace(FORMATO, "'", "") & "'"
                        Dim ANTIGO As String = Icraft.IcftBase.NZV(Icraft.IcftBase.DSValor("FORMATO", Apl.Esquema & ".GER_CAMPO", Login.Strconn, "SISTEMA = 'IM' AND TABELA = :TABELA AND CAMPO = :CAMPO", Login.Strconn, ":TABELA", LINHA!TABELA, ":CAMPO", LINHA!CAMPO), "")
                        If ANTIGO <> FORMATO Then
                            If MsgBox("Deseja gravar formato --> " & FORMATO & " <-- em antigo --> " & ANTIGO & " <-- no campo " & LINHA!campo & " da tabela " & LINHA!tabela & "??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Icraft.IcftBase.DSGrava("UPDATE" & Apl.Esquema & ".GER_CAMPO SET FORMATO = :FORMATO WHERE SISTEMA =" & "'" & Apl.Esquema & "'" & " AND TABELA = :TABELA AND CAMPO = :CAMPO", Login.Strconn, ":FORMATO", FORMATO, ":TABELA", LINHA!TABELA, ":CAMPO", LINHA!CAMPO)
                            End If
                        End If
                    End If
                Next
            End If
        Next

        MsgBox("Término.")
    End Sub

    Private Sub btnRecup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecup.Click
        Icraft.IcftBase.DSConfig(Login.Strconn, "FORM_TESTE", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "TXT")
        ADS = New System.Data.DataSet
        ADS.ReadXml(Icraft.IcftBase.FileExpr(txtArq.Text, "Esquema.xml"))
        EE.DataSource = ADS.Tables(0)
        MsgBox("Recuperado.")
    End Sub
End Class