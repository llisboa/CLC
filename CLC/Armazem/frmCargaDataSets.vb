Public Class frmCargaDataSets

    Dim DS As System.Data.DataSet
    Dim DSW As System.Data.DataSet

    Enum MostraTipo
        Tab
        Grav
    End Enum
    Sub MOSTRA(ByVal Tipo As MostraTipo)
        TAB.Visible = Tipo = MostraTipo.Tab
        GRAV.Visible = Tipo = MostraTipo.Grav
        btnVoltar.Visible = Tipo = MostraTipo.Grav
        If Tipo = MostraTipo.Tab Then
            btnGravarnaBase.Text = "Gravar na Base"
        Else
            btnGravarnaBase.Text = "Concluir Gravação"
        End If
    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        MOSTRA(MostraTipo.Tab)

        StatusPerguntar = True
        ViagemPerguntar = True
        PracaPerguntar = True

        If ARQS.Text = "" Then
            MsgBox("Escolha um arquivo.")
            Exit Sub
        End If
        If TABS.Text = "" Then
            MsgBox("Escolha uma tabela.")
            Exit Sub
        End If

        TAB.Limpa()

        DS = New System.Data.DataSet
        DS.Tables.Add(New System.Data.DataTable)
        DS.Tables(0).TableName = TABS.Text
        DS.Tables(0).Columns.Add(New System.Data.DataColumn("_ARQ", GetType(String)))
        DS.Tables(0).Columns.Add(New System.Data.DataColumn("_TAB", GetType(String)))

        Dim NOARQ As New ArrayList
        Dim COLS As New List(Of System.Data.DataColumn)
        Dim C As New ArrayList

        Dim ListaArqs As ArrayList = Icraft.IcftBase.ListaDir(System.IO.Path.GetDirectoryName(ARQS.Text), System.IO.Path.GetFileName(ARQS.Text))
        For Each Arq As String In ListaArqs
            Dim DS2 As System.Data.DataSet = New System.Data.DataSet
            DS2.ReadXml(Arq)
            If DS2.Tables.Count > 0 Then
                For Z As Integer = 0 To DS2.Tables.Count - 1
                    Dim Arm As Boolean = False
                    For Each COL As System.Data.DataColumn In DS2.Tables(Z).Columns
                        If DS2.Tables(Z).TableName = TABS.Text Then
                            Try
                                If Not C.Contains(COL.ColumnName) Then

                                    If COL.ColumnName = "Armazem" Or COL.ColumnName = "ArmNum" Or COL.ColumnName = "Praça" Then
                                        Arm = True
                                    ElseIf Arm Then
                                        DS.Tables(0).Columns.Add("PraçaDef", COL.DataType)
                                        C.Add("PraçaDef")
                                        Arm = False
                                    End If


                                    DS.Tables(0).Columns.Add(COL.ColumnName, COL.DataType)
                                    C.Add(COL.ColumnName)

                                    If COL.ColumnName = "Viagem" Or COL.ColumnName = "Status" Then
                                        DS.Tables(0).Columns.Add(COL.ColumnName & "Def", COL.DataType)
                                        C.Add(COL.ColumnName & "Def")
                                    End If
                                End If
                            Catch
                            End Try
                        End If
                    Next
                Next
            Else
                NOARQ.Add(Arq)
            End If
        Next

        For Each Arq As String In ListaArqs
            If Not NOARQ.Contains(Arq) Then
                Dim DS2 As New System.Data.DataSet
                DS2.ReadXml(Arq)
                For Z As Integer = 0 To DS2.Tables.Count - 1
                    If DS2.Tables(Z).TableName = TABS.Text Then
                        Dim CS As New ArrayList
                        For Each CT As System.Data.DataColumn In DS2.Tables(Z).Columns
                            CS.Add(CT.ColumnName)
                        Next
                        DS2 = Verifica(DS2)
                        For Each linha As System.Data.DataRow In DS2.Tables(Z).Rows
                            Dim Lista As New ArrayList
                            For Each Col As System.Data.DataColumn In DS.Tables(0).Columns
                                If Col.ColumnName = "_ARQ" Then
                                    Lista.Add(Arq)
                                ElseIf Col.ColumnName = "_TAB" Then
                                    Lista.Add(DS2.Tables(Z).TableName)
                                Else
                                    Try
                                        If CS.Contains(Col.ColumnName) Then
                                            Lista.Add(linha(Col.ColumnName))
                                        Else
                                            Lista.Add(Convert.DBNull)
                                        End If
                                    Catch ex As System.ArgumentException
                                        Lista.Add(Convert.DBNull)
                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                        Lista.Add(Convert.DBNull)
                                    End Try
                                End If
                            Next

                            DS.Tables(0).Rows.Add(Lista.ToArray)
                        Next
                    End If
                Next
            End If
        Next

        TAB.Grid.AutoGenerateColumns = True
        TAB.Grid.AllowUserToAddRows = False
        TAB.Grid.DataSource = DS.Tables(0)
        Dim ES As New DataGridViewCellStyle
        ES.BackColor = Color.Yellow

        TAB.EliminaCols("PesoDef;StatusDef;ViagemDef;PraçaDef")

        If TABS.Text = "EtiqOff" Then

            If TAB.Grid.Columns.Contains("Status") Then
                TAB.IncluiCombo("StatusDef", Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.STATUS_ESTOQUE", Login.Strconn), "Status", ES).DataPropertyName = "StatusDef"
                Dim statusdef As DataGridViewComboBoxColumn = TAB.Grid.Columns("StatusDef")
                For Each linha As System.Data.DataRow In DS.Tables(0).Rows
                    If Icraft.IcftBase.TemNaLista(statusdef.Items, linha("status")) Then
                        linha("statusdef") = linha("status")
                    End If
                Next
            End If
            If TAB.Grid.Columns.Contains("Viagem") Then
                TAB.IncluiCombo("ViagemDef", Icraft.IcftBase.DSCarrega("SELECT OVE.VIAGEM_REF || '/' || TO_CHAR(OVE.SEQ,'FM000')  FROM IM.ORDEM_VENDA_EMB OVE, IM.VW_COL_RASTREA_OVI OVI WHERE OVE.ORDEM_VENDA_REF = OVI.OV_REF (+) AND OVE.ORDEM_VENDA_ITEM = OVI.OV_ITEM (+)", Login.Strconn), "Viagem", ES).DataPropertyName = "ViagemDef"
                Dim ViagemDef As DataGridViewComboBoxColumn = TAB.Grid.Columns("ViagemDef")
                For Each linha As System.Data.DataRow In DS.Tables(0).Rows
                    Dim Ar() As String = Split(linha("Viagem"), "/")
                    Dim ViagemF As String = Ar(0)
                    If Ar.Length > 0 Then
                        ViagemF &= "/" & Format(Val(Ar(1)), "000")
                    End If
                    If Icraft.IcftBase.TemNaLista(ViagemDef.Items, ViagemF) Then
                        linha("ViagemDef") = ViagemF
                    End If
                Next
            End If

            Dim Praca As String = ""
            If TAB.Grid.Columns.Contains("Praça") Then
                Praca = "Praça"
            ElseIf TAB.Grid.Columns.Contains("ArmNum") Then
                Praca = "ArmNum"
            ElseIf TAB.Grid.Columns.Contains("Armazem") Then
                Praca = "Armazem"
            End If
            If Praca <> "" Then
                TAB.IncluiCombo("PraçaDef", Icraft.IcftBase.DSCarrega("SELECT ARMAZEM_CIA_COD || ' | ' || ARMAZEM_NUM || ' | ' || PRACA FROM IM.ARMAZEM_PRACA", Login.Strconn), Praca, ES).DataPropertyName = "PraçaDef"
                Dim PracaDef As DataGridViewComboBoxColumn = TAB.Grid.Columns("PraçaDef")
                For Each linha As System.Data.DataRow In DS.Tables(0).Rows
                    Dim PracaF As String = ""
                    If TAB.Grid.Columns.Contains("Armazem") Then
                        PracaF &= IIf(PracaF <> "", " | ", "") & linha("Armazem")
                    End If
                    If TAB.Grid.Columns.Contains("ArmNum") Then
                        PracaF &= IIf(PracaF <> "", " | ", "") & linha("ArmNum")
                    End If
                    If TAB.Grid.Columns.Contains("Praça") Then
                        PracaF &= IIf(PracaF <> "", " | ", "") & linha("Praça")
                    End If
                    If Icraft.IcftBase.TemNaLista(PracaDef.Items, PracaF) Then
                        linha("ViagemDef") = PracaF
                    End If
                Next
            End If

        End If

    End Sub

    Public Function Verifica(ByVal DS As System.Data.DataSet)
        If DS.Tables.Count > 1 Then
            If DS.Tables(1).Rows.Count > 1 Then
                If Icraft.IcftBase.NZV(DS.Tables(1).Rows(0)("Viagem"), "") = "" Then
                    DS.Tables(1).Rows(0).Delete()
                End If
            End If
        End If
        Return DS
    End Function

    Private Sub BTNBUSCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCA.Click
        ARQS.Items.Clear()
        Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
        Dim ar As New ArrayList
        For Each Arq As String In Icraft.IcftBase.ListaDir(TXTDIR.Text, TXTEXTENSAO.Text)
            ar.Add(Arq)
        Next
        ar.Sort()
        ar.Reverse()
        ARQS.Items.AddRange(ar.ToArray)
    End Sub

    Private Sub ARQS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARQS.SelectedIndexChanged
        TABS.Items.Clear()
        Dim ListaArqs As ArrayList = Icraft.IcftBase.ListaDir(System.IO.Path.GetDirectoryName(ARQS.Text), System.IO.Path.GetFileName(ARQS.Text))
        For Each Arq As String In ListaArqs
            Dim DS2 As System.Data.DataSet = New System.Data.DataSet
            DS2.ReadXml(Arq)
            If DS2.Tables.Count > 0 Then
                For Z As Integer = 0 To DS2.Tables.Count - 1
                    TABS.Items.Add(DS2.Tables(Z).TableName)
                Next
            End If
        Next
        If TABS.Items.Count > 0 Then
            TABS.Text = TABS.Items(0)
        End If
    End Sub

    Private Sub TABS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TABS.SelectedIndexChanged
        btnCarregar_Click(Nothing, Nothing)
    End Sub

    Private Sub BTNSALVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALVAR.Click
        If MsgBox("Deseja atualizar o arquivo " & ARQS.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dss As New System.Data.DataSet
            dss.ReadXml(ARQS.Text)
            If dss.Tables.Contains(TABS.Text) Then
                dss.Tables.Remove(dss.Tables(TABS.Text))
            End If
            dss.Tables.Add(DS.Tables(0).Copy)
            Dim z As Integer = 0
            Do While z < dss.Tables(TABS.Text).Columns.Count
                If dss.Tables(TABS.Text).Columns(z).ColumnName.EndsWith("Def") Or dss.Tables(TABS.Text).Columns(z).ColumnName = "_ARQ" Or dss.Tables(TABS.Text).Columns(z).ColumnName = "_TAB" Then
                    dss.Tables(TABS.Text).Columns.Remove(dss.Tables(TABS.Text).Columns(z))
                Else
                    z += 1
                End If
            Loop
            DS.WriteXml(ARQS.Text)
            MsgBox("Arquivo " & ARQS.Text & " gravado.")
        End If
    End Sub

    Private Sub frmCargaDataSets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.DSConfigUsuario(Login.Strconn, Login.Usuario!usuario, Me.Name & "_ParamIni", "IM.SYS_CONFIG_USUARIO")
        AddHandler TAB.Grid.CellEndEdit, AddressOf Modifica

        DSW = Icraft.IcftBase.DSTabCols(Nothing, Nothing, New Icraft.IcftBase.TabCol("TAB", "X"), New Icraft.IcftBase.TabCol("CHAVE", New Object), New Icraft.IcftBase.TabCol("CAMPO", "X"), New Icraft.IcftBase.TabCol("ANTIGO", New Object), New Icraft.IcftBase.TabCol("NOVO", New Object))

    End Sub

    Dim StatusPerguntar As Boolean = True
    Dim ViagemPerguntar As Boolean = True
    Dim PracaPerguntar As Boolean = True

    Sub Modifica(ByVal Sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim STATUSDEFCOL As Integer = -1
        If TAB.Grid.Columns.Contains("StatusDef") Then
            STATUSDEFCOL = TAB.Grid.Columns("StatusDef").Index
        End If
        Dim VIAGEMDEFCOL As Integer = -1
        If TAB.Grid.Columns.Contains("ViagemDef") Then
            VIAGEMDEFCOL = TAB.Grid.Columns("ViagemDef").Index
        End If

        Dim PRACADEFCOL As Integer = -1
        If TAB.Grid.Columns.Contains("PraçaDef") Then
            PRACADEFCOL = TAB.Grid.Columns("PraçaDef").Index
        End If

        If e.ColumnIndex = STATUSDEFCOL Then
            If StatusPerguntar Then
                Dim Ret As MsgBoxResult = MsgBox("Deseja atualizar outros com mesma descrição (CANCEL para não atualizar nem perguntar mais)?", MsgBoxStyle.YesNoCancel)
                If Ret = MsgBoxResult.Cancel Then
                    StatusPerguntar = False
                ElseIf Ret = MsgBoxResult.Yes Then
                    For z As Integer = 0 To TAB.Grid.Rows.Count - 1
                        If z <> e.RowIndex Then
                            If Icraft.IcftBase.NZ(TAB.Grid.Rows(z).Cells("Status").Value, "") = Icraft.IcftBase.NZ(TAB.Grid.Rows(e.RowIndex).Cells("Status").Value, "") Then
                                TAB.Grid.Rows(z).Cells("StatusDef").Value = TAB.Grid.Rows(e.RowIndex).Cells("StatusDef").Value
                            End If
                        End If
                    Next
                End If
            End If
        ElseIf e.ColumnIndex = VIAGEMDEFCOL Then
            If ViagemPerguntar Then
                Dim Ret As MsgBoxResult = MsgBox("Deseja atualizar outros com mesma descrição (CANCEL para não atualizar nem perguntar mais)?", MsgBoxStyle.YesNoCancel)
                If Ret = MsgBoxResult.Cancel Then
                    ViagemPerguntar = False
                ElseIf Ret = MsgBoxResult.Yes Then
                    For z As Integer = 0 To TAB.Grid.Rows.Count - 1
                        If z <> e.RowIndex Then
                            If Icraft.IcftBase.NZ(TAB.Grid.Rows(z).Cells("Viagem").Value, "") = Icraft.IcftBase.NZ(TAB.Grid.Rows(e.RowIndex).Cells("Viagem").Value, "") Then
                                TAB.Grid.Rows(z).Cells("ViagemDef").Value = TAB.Grid.Rows(e.RowIndex).Cells("ViagemDef").Value
                            End If
                        End If
                    Next
                End If
            End If
        ElseIf e.ColumnIndex = PRACADEFCOL Then
            If PracaPerguntar Then
                Dim Ret As MsgBoxResult = MsgBox("Deseja atualizar outros com mesma descrição (CANCEL para não atualizar nem perguntar mais)?", MsgBoxStyle.YesNoCancel)
                If Ret = MsgBoxResult.Cancel Then
                    PracaPerguntar = False
                ElseIf Ret = MsgBoxResult.Yes Then
                    For z As Integer = 0 To TAB.Grid.Rows.Count - 1
                        If z <> e.RowIndex Then
                            Dim Atrib As Boolean = Not TAB.Grid.Columns.Contains("Armazem") OrElse (Icraft.IcftBase.NZ(TAB.Grid.Rows(z).Cells("Armazem").Value, "") = Icraft.IcftBase.NZ(TAB.Grid.Rows(e.RowIndex).Cells("Armazem").Value, ""))
                            If Atrib Then
                                Atrib = Not TAB.Grid.Columns.Contains("ArmNum") OrElse (Icraft.IcftBase.NZ(TAB.Grid.Rows(z).Cells("ArmNum").Value, "") = Icraft.IcftBase.NZ(TAB.Grid.Rows(e.RowIndex).Cells("ArmNum").Value, ""))
                                If Atrib Then
                                    Atrib = Not TAB.Grid.Columns.Contains("Praça") OrElse (Icraft.IcftBase.NZ(TAB.Grid.Rows(z).Cells("Praça").Value, "") = Icraft.IcftBase.NZ(TAB.Grid.Rows(e.RowIndex).Cells("Praça").Value, ""))
                                End If
                            End If
                            If Atrib Then
                                TAB.Grid.Rows(z).Cells("PraçaDef").Value = TAB.Grid.Rows(e.RowIndex).Cells("PraçaDef").Value
                            End If
                        End If
                    Next
                End If
            End If
        End If

    End Sub

    Sub GravarNaBase()
        For z As Integer = 0 To GRAV.Grid.Rows.Count - 1
            If TABS.Text = "EtiqOff" Then
                Try
                    If IsNumeric(Replace(GRAV.Grid.Rows(z).Cells("NOVO").Value, ",", ".")) Then
                        Icraft.IcftBase.DSGrava("UPDATE IM.ETIQUETA SET " & GRAV.Grid.Rows(z).Cells("CAMPO").Value & " = " & Replace(GRAV.Grid.Rows(z).Cells("NOVO").Value, ",", ".") & " WHERE ETIQUETA = '" & GRAV.Grid.Rows(z).Cells("CHAVE").Value & "'", Login.Strconn)
                    Else
                        Icraft.IcftBase.DSGrava("UPDATE IM.ETIQUETA SET " & GRAV.Grid.Rows(z).Cells("CAMPO").Value & " = '" & Replace(GRAV.Grid.Rows(z).Cells("NOVO").Value, ",", ".") & "' WHERE ETIQUETA = '" & GRAV.Grid.Rows(z).Cells("CHAVE").Value & "'", Login.Strconn)
                    End If
                    GRAV.Grid.Rows(z).Cells(0).Value = "Dados gravados com sucesso."
                Catch ex As Exception
                    GRAV.Grid.Rows(z).Cells(0).Style.BackColor = Color.Red
                    GRAV.Grid.Rows(z).Cells(0).Value = ex
                End Try
            ElseIf TABS.Text = "Coleta" Then
                Try
                    Dim Dados() As String = GRAV.Grid.Rows(z).Cells("CHAVE").Value.ToString.Split("/")
                    If Not ((GRAV.Grid.Rows(z).Cells("CAMPO").Value = "ESCALA") Or (GRAV.Grid.Rows(z).Cells("CAMPO").Value = "CIA_COD_LOCAL")) Then
                        Icraft.IcftBase.DSGrava("UPDATE IM.VIAGEM_ESCALA SET " & GRAV.Grid.Rows(z).Cells("CAMPO").Value & " = " & GRAV.Grid.Rows(z).Cells("NOVO").Value & " WHERE VIAGEM_REF = '" & Dados(0) & "' AND ESCALA = " & Dados(1) & "", Login.Strconn)
                        GRAV.Grid.Rows(z).Cells(0).Value = "Dados gravados com sucesso."
                    Else
                        GRAV.Grid.Rows(z).Cells(0).Value = "Estes dados não são gravados."
                    End If
                Catch ex As Exception
                    GRAV.Grid.Rows(z).Cells(0).Style.BackColor = Color.Red
                    GRAV.Grid.Rows(z).Cells(0).Value = ex
                End Try
            End If
        Next
    End Sub

    Private Sub btnGravarnaBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravarnaBase.Click
        'TAB;CHAVE;CAMPO;ANTIGO;NOVO
        If sender.text = "Concluir Gravação" Then
            GravarNaBase()
        Else
            DSW.Tables(0).Rows.Clear()
            If TABS.Text = "EtiqOff" Then
                If MsgBox("Deseja atualizar na base de dados as definições de peso/status/armazém presentes na tabela?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
                        Dim LINHAETIQ As String = Linha("ETIQ")
                        If LINHAETIQ Like "250*" Then
                            LINHAETIQ = Mid(LINHAETIQ, 4)
                        End If
                        Dim ETIQ As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT ETIQUETA, STATUS_COD, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, VIAGEM_REF_ORDEM, VIAGEM_SEQ_ORDEM FROM IM.ETIQUETA WHERE REPLACE(ETIQUETA,'.','') = :ETIQUETA", Login.Strconn, ":ETIQUETA", LINHAETIQ)
                        Dim VIAGEM() As String = Split(Icraft.IcftBase.NZV(Trim(Linha("ViagemDef")), ""), "/")
                        Dim VIAGEMREF As String = VIAGEM(0)
                        Dim VIAGEMSEQ As Integer = Val(VIAGEM(1))

                        If ETIQ.Tables(0).Rows.Count = 0 Then
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "PESO_BALANCA_LIQ", "[nenhum]", Val(Linha("Peso")))
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "PESO_BALANCA_BRUTO", "[nenhum]", Val(Linha("Peso")))
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "VIAGEM_REF_ORDEM", "[nenhum]", VIAGEMREF)
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "VIAGEM_SEQ_ORDEM", "[nenhum]", VIAGEMSEQ)
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "STATUS_COD", "[nenhum]", Linha("StatusDef"))
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", Linha("ETIQ"), "STATUS_COD", "[nenhum]", Linha("StatusDef"))
                        Else
                            Dim ArCols As System.Data.DataColumnCollection = DS.Tables(0).Columns
                            If ArCols.Contains("Peso") Then
                                DSW.Tables(0).Rows.Add("IM.ETIQUETA", ETIQ.Tables(0).Rows(0)!ETIQUETA, "PESO_BALANCA_BRUTO", ETIQ.Tables(0).Rows(0)!PESO_BALANCA_BRUTO, Val(Linha("Peso")))
                            End If
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", ETIQ.Tables(0).Rows(0)!ETIQUETA, "VIAGEM_REF_ORDEM", ETIQ.Tables(0).Rows(0)!VIAGEM_REF_ORDEM, VIAGEMREF)
                            DSW.Tables(0).Rows.Add("IM.ETIQUETA", ETIQ.Tables(0).Rows(0)!ETIQUETA, "VIAGEM_SEQ_ORDEM", ETIQ.Tables(0).Rows(0)!VIAGEM_SEQ_ORDEM, VIAGEMSEQ)
                            If ArCols.Contains("StatusDef") Then
                                DSW.Tables(0).Rows.Add("IM.ETIQUETA", ETIQ.Tables(0).Rows(0)!ETIQUETA, "STATUS_COD", ETIQ.Tables(0).Rows(0)!STATUS_COD, Linha("StatusDef"))
                            End If
                        End If
                    Next

                    GRAV.Grid.AutoGenerateColumns = True
                    GRAV.Grid.AllowUserToAddRows = False
                    GRAV.Grid.DataSource = DSW.Tables(0)

                    If Not GRAV.Grid.Columns.Contains("SITUACAO") Then
                        GRAV.Grid.Columns.Add("SITUACAO", "SITUAÇÃO")
                    End If

                    MOSTRA(MostraTipo.Grav)
                End If
            ElseIf TABS.Text = "Coleta" Then
                If MsgBox("Deseja atualizar na base de dados as definições de coleta presentes na tabela?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
                        Dim LINHAVIAGEM As String = Linha("VIAGEM")
                        Dim INFO() As String = Split(Icraft.IcftBase.NZV(Trim(Linha("Escala")), ""), "-")
                        Dim ESCALA As String = Val(INFO(0))
                        Dim ARMAZEM As String = INFO(1)
                        Dim VIAGEM As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT VIAGEM_REF, ESCALA, CIA_COD_LOCAL, ETA, OBS, LONADO, MOLHADO, ENVELOPADO, COM_MADEIRA, NOTA_ENTREGUE, CERTIFICADO_ENTREGUE FROM IM.VIAGEM_ESCALA WHERE VIAGEM_REF = :VIAGEM_REF AND ESCALA = :ESCALA AND CIA_COD_LOCAL = :CIA_COD_LOCAL", Login.Strconn, ":VIAGEM_REF", LINHAVIAGEM, ":ESCALA", ESCALA, ":CIA_COD_LOCAL", ARMAZEM)

                        If VIAGEM.Tables(0).Rows.Count > 0 Then
                            Try
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "ESCALA", VIAGEM.Tables(0).Rows(0)(1), Icraft.IcftBase.NZ(ESCALA, ""))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "CIA_COD_LOCAL", VIAGEM.Tables(0).Rows(0)(2), Icraft.IcftBase.NZ("'" & ARMAZEM & "'", ""))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "ATA", VIAGEM.Tables(0).Rows(0)(3), "TO_DATE('" & Replace(Format(CDate(Linha("Chegada")), "s"), "T", " ") & "', 'YYYY-MM-DD HH24:MI:SS')")
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "ATS", VIAGEM.Tables(0).Rows(0)(3), "TO_DATE('" & Replace(Format(CDate(Linha("Saída")), "s"), "T", " ") & "', 'YYYY-MM-DD HH24:MI:SS')")
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "OBS", VIAGEM.Tables(0).Rows(0)(4), "'" & Icraft.IcftBase.NZ(Linha("Obs"), "'" & "'") & "'")
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "LONADO", VIAGEM.Tables(0).Rows(0)(5), IIf(Linha("Lonado") = "true", 1, 0))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "MOLHADO", VIAGEM.Tables(0).Rows(0)(6), IIf(Linha("Molhado") = "true", 1, 0))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "ENVELOPADO", VIAGEM.Tables(0).Rows(0)(7), IIf(Linha("Envelopado") = "true", 1, 0))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "COM_MADEIRA", VIAGEM.Tables(0).Rows(0)(8), IIf(Linha("ComMadeira") = "true", 1, 0))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "NOTA_ENTREGUE", VIAGEM.Tables(0).Rows(0)(9), IIf(Linha("NotaEntreg") = "true", 1, 0))
                                DSW.Tables(0).Rows.Add("IM.VIAGEM_ESCALA", Linha("VIAGEM") & "/" & ESCALA, "CERTIFICADO_ENTREGUE", VIAGEM.Tables(0).Rows(0)(10), IIf(Linha("CertifComNF") = "true", 1, 0))
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                    GRAV.Grid.AutoGenerateColumns = True
                    GRAV.Grid.AllowUserToAddRows = False
                    GRAV.Grid.DataSource = DSW.Tables(0)

                    If Not GRAV.Grid.Columns.Contains("SITUACAO") Then
                        GRAV.Grid.Columns.Add("SITUACAO", "SITUAÇÃO")
                    End If

                    MOSTRA(MostraTipo.Grav)
                End If
                End If
            End If
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        MOSTRA(MostraTipo.Tab)
    End Sub

    Private Sub btnMover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMover.Click
        For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
            Dim dd As String = TXTDIR.Text & "_Tratado"
            Try
                MkDir(dd)
            Catch
            End Try
            Try
                FileCopy(Linha!_ARQ, Icraft.IcftBase.NomeArqLivre(dd, System.IO.Path.GetFileName(Linha!_ARQ)))
                System.IO.File.Delete(Linha!_ARQ)
                MsgBox("Arquivos movidos com sucesso!")
                BTNBUSCA_Click(Nothing, Nothing)
                Exit Sub
            Catch ex As Exception
                MsgBox(ex)
            End Try
        Next

    End Sub
End Class