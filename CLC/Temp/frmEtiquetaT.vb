
Public Class frmEtiquetaT
    Inherits Form

    Const TempoAteMostrarReg As Integer = 300
    Dim TT As New ToolTip

    Private Sub frmEtiquetaT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdPrinc.StrConn = Login.Strconn
        grdPrinc.Tabela = "ETIQUETA"
        grdPrinc.Usuario = Login.Usuario!USUARIO
        grdPrinc.Sistema = Apl.Esquema
        grdPrinc.EsquemaGerador = Apl.Esquema
        grdPrinc.EsquemaPrinc = Apl.Esquema
        grdPrinc.Bind()
        Try
            Dim D As New Icraft.IcftBase.Defs(Apl.Esquema, "ETIQUETA;ETIQUETA_REG", Login.Strconn, Apl.Esquema)

            For Each Linha As System.Data.DataRow In D.Campos.Tables(0).Select("TABELA='ETIQUETA'")
                Diagnostics.Debug.Print(Linha!CAMPO)
                Dim Ctl As Object = tabPrinc.Controls.Find("FLD" & Linha("CAMPO"), True)(0)
                Dim Tooltip As String = D.ToolTip(Linha!tabela, Linha!campo)
                Dim TamMax As Integer = D.TamMax(Linha!tabela, Linha!campo)
                If TamMax > 0 Then
                    Ctl.maxlength = TamMax
                End If
                TT.SetToolTip(Ctl, Tooltip)
            Next

            'Icraft.IcftBase.CarregaCombo(FLDESTADO, True, Icraft.IcftBase.EstadosDoBrasil)

            AtualizaChaves()
            tmrMostra.Interval = TempoAteMostrarReg
            AddHandler tmrMostra.Tick, AddressOf MostraProg
            'CarregaRamos()
            CarregaAtivCia()
        Catch EX As Exception
            Local.MostraErr(EX, "Carregando Form")
        End Try
    End Sub

    Dim DSTab As System.Data.DataSet = Nothing
    Dim DSCamp As System.Data.DataSet = Nothing



    Dim DSAtivCia As System.Data.DataSet = Nothing
    Sub CarregaAtivCia()
        DSAtivCia = Icraft.IcftBase.DSCarrega("SELECT ETIQUETA FROM IM.ETIQUETA", Login.Strconn)
    End Sub

    Dim DSRamos As System.Data.DataSet = Nothing
    'Sub CarregaRamos()
    '    DSRamos = Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.RAMO_ATIVIDADE", Login.Strconn)
    'End Sub

    Dim DSChaves As System.Data.DataSet = Nothing
    Sub AtualizaChaves()
        Dim Salva As Boolean = False
        If Not IsNothing(DSChaves) AndAlso (RegPos - 1) < DSChaves.Tables(0).Rows.Count Then
            Salva = True
        End If

        Dim ChaveAtual As String = ""
        If Salva Then
            ChaveAtual = DSChaves.Tables(0).Rows(RegPos - 1)("COD")
        End If

        DSChaves = Icraft.IcftBase.DSCarrega(SQLChave, Login.Strconn)
        DSChaves.Tables(0).PrimaryKey = New System.Data.DataColumn() {DSChaves.Tables(0).Columns("COD")}


        If Salva Then
            Dim RegAtual As System.Data.DataRow = DSChaves.Tables(0).Rows.Find(ChaveAtual)
            RegPos = DSChaves.Tables(0).Rows.IndexOf(RegAtual) + 1
        End If
        RegMostra()
    End Sub

    Dim DSReg As System.Data.DataSet
    Dim DSRegAtiv As System.Data.DataSet
    Dim DSEntrega As System.Data.DataSet

    Dim tmrMostra As New Timer
    Sub RegMostra(Optional ByVal Programa As Boolean = True)
        lblReg.Text = "[carregando]"

        If Programa Then
            tmrMostra.Enabled = False
            tmrMostra.Enabled = True
        End If

        If RegPos = 0 Then
            RegPos = DSChaves.Tables(0).Rows.Count
        End If
        If RegPos = -1 Then
            RegPos = DSChaves.Tables(0).Rows.Count + 1
        End If

        Princ.barStatus.Text = Me.Text & " carregando registro "
        If RegPos <= DSChaves.Tables(0).Rows.Count Then
            Princ.barStatus.Text &= DSChaves.Tables(0).Rows(RegPos - 1)(0) & "."
        Else
            Princ.barStatus.Text &= "[novo]."
        End If

        If Not Programa Then
            MostraProg()
            Princ.barStatus.Text = ""
        End If

        lblReg.Text = RegPos & " de " & DSChaves.Tables(0).Rows.Count
        Application.DoEvents()
    End Sub

    Sub MostraProg()
        tmrMostra.Enabled = False
        If RegPos > DSChaves.Tables(0).Rows.Count Then
            For Each Ctl As Object In Campos
                Ctl.Text = ""
                If Ctl.Name = "FLDETIQ" Then
                    CType(Ctl, TextBox).BackColor = Color.White
                    CType(Ctl, TextBox).ReadOnly = False
                End If
            Next
            lblChave.Text = "[novo]"
        Else

            DSReg = Icraft.IcftBase.DSCarrega(SQLCarrega, Login.Strconn, ":ETIQUETA", DSChaves.Tables(0).Rows(RegPos - 1)("ETIQUETA"))
            'DSRegAtiv = Icraft.IcftBase.DSCarrega("SELECT RAMO_ATIVIDADE_COD FROM IM.CIA_RAMO_ATIVIDADE WHERE CIA_COD=:COD", Login.Strconn, ":COD", DSChaves.Tables(0).Rows(RegPos - 1)("COD"))
            'DSRegAtiv.Tables(0).PrimaryKey = New System.Data.DataColumn() {DSRegAtiv.Tables(0).Columns(0)}
            'DSEntrega = Icraft.IcftBase.DSCarrega("SELECT SEQ SEQ, CIA_COD_LOCAL Companhia FROM IM.CIA_LOCAL WHERE CIA_COD=:COD", Login.Strconn, ":COD", DSChaves.Tables(0).Rows(RegPos - 1)("COD"))
            DSEntrega.Tables(0).PrimaryKey = New System.Data.DataColumn() {DSEntrega.Tables(0).Columns(0)}

            For Each Ctl As Object In Campos
                Ctl.Text = Icraft.IcftBase.NZ(DSReg.Tables(0).Rows(0)(Mid(Ctl.Name, 4)), "")
                If Ctl.Name = "FLDETIQ" Then
                    CType(Ctl, TextBox).BackColor = System.Drawing.SystemColors.InactiveBorder
                    CType(Ctl, TextBox).ReadOnly = True
                End If
            Next
            lblChave.Text = DSReg.Tables(0).Rows(0)("ETIQUETA")
        End If

        CarregaImagens()
        CarregaAtividades()
        CarregaEntrega()

        Princ.barStatus.Text = ""
    End Sub

    Sub CarregaEntrega()
        grdEntrega.DataSource = DSEntrega.Tables(0)
        grdEntrega.Columns(0).Width = 40
        grdEntrega.Columns(1).Width = 100
        CType(grdEntrega.Columns(1), DataGridViewComboBoxColumn).DataSource = (From X In DSAtivCia.Tables(0).Rows Select X(0)).ToList
    End Sub


    Const AtivCheckDistY As Integer = 20
    Sub CarregaAtividades()
        Dim s As Integer = 1
        For Each Ctl As CheckBox In Icraft.IcftBase.Form.Controles(pnlAtiv, "ativchk")
            pnlAtiv.Controls.Remove(Ctl)
        Next
        For x As Integer = chkAtivIni.Left To pnlAtiv.Width Step (chkAtivProxCol.Left - chkAtivIni.Left)
            For y As Integer = chkAtivIni.Top To chkAtivFimCol.Top Step AtivCheckDistY
                If s > DSRamos.Tables(0).Rows.Count Then Exit Sub
                Dim chk As New CheckBox()
                chk.Top = y
                chk.Left = x
                chk.Text = DSRamos.Tables(0).Rows(s - 1)("COD")
                chk.Name = "ativchk" & s
                chk.Width = chkAtivProxCol.Left - chkAtivIni.Left - 10

                If RegPos <= DSChaves.Tables(0).Rows.Count Then
                    chk.Checked = DSRegAtiv.Tables(0).Rows.Contains(DSRamos.Tables(0).Rows(s - 1)("COD"))
                End If

                s += 1
                pnlAtiv.Controls.Add(chk)
            Next
        Next
    End Sub

    Sub CarregaImagem(ByVal Imagem As PictureBox, ByVal UrlOuArquivo As String)
        If UrlOuArquivo <> "" Then
            Imagem.Load(Icraft.IcftBase.FileExpr(UrlOuArquivo))
        Else
            Imagem.Image = Nothing
        End If
        Imagem.Tag = UrlOuArquivo
    End Sub

    Private _SQLCarrega As String = ""
    ReadOnly Property SQLCarrega() As String
        Get
            If _SQLCarrega = "" Then
                Dim SQL As String = ""
                For Each Ctl As Control In Campos
                    SQL &= IIf(SQL <> "", ", ", "") & Mid(Ctl.Name, 4)
                Next
                _SQLCarrega = "SELECT " & SQL & " FROM IM.ETIQUETA WHERE ETIQ=:ETIQ"
            End If
            Return _SQLCarrega
        End Get
    End Property

    Dim FiltroCustomSQL As String = ""
    Const FiltroCustomExpr = "[filtro custom]"
    ReadOnly Property SQLChave() As String
        Get
            Dim SQL As String = "SELECT COD FROM IM.ETIQUETA"
            If FiltroCustomSQL <> "" Then
                txtBusca.Text = FiltroCustomExpr
                SQL &= " WHERE " & FiltroCustomSQL
            Else
                If txtBusca.Text <> "" Then
                    SQL &= " WHERE UPPER(COD) LIKE '%" & UCase(Icraft.IcftBase.Tratex(txtBusca.Text)) & "%'"
                End If
            End If
            Return SQL
        End Get
    End Property

    Private _Campos As ArrayList = Nothing
    ReadOnly Property Campos() As ArrayList
        Get
            If IsNothing(_Campos) Then
                _Campos = Icraft.IcftBase.Form.Controles(tabPrinc, "FLD")
            End If
            Return _Campos
        End Get
    End Property

    Dim RegPos As Integer = 0
    Sub RegPrimeiro()
        RegPos = 1
        RegMostra()
    End Sub
    Sub RegAnterior()
        If RegPos > 1 Then
            RegPos -= 1
            RegMostra()
        End If
    End Sub
    Sub RegPosterior()
        If RegPos <= DSChaves.Tables(0).Rows.Count Then
            RegPos += 1
            RegMostra()
        End If
    End Sub
    Sub RegUltimo()
        RegPos = 0
        RegMostra()
    End Sub
    Sub RegNovo(Optional ByVal Programa As Boolean = False)
        RegPos = -1
        RegMostra(Programa)
    End Sub

    Private Sub btnPrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrim.Click
        Try
            RegPrimeiro()
        Catch EX As Exception
            Local.MostraErr(EX, "Primeiro Registro")
        End Try
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        Try
            RegAnterior()
        Catch EX As Exception
            Local.MostraErr(EX, "Registro Anterior")
        End Try
    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Try
            RegPosterior()
        Catch EX As Exception
            Local.MostraErr(EX, "Registro Posterior")
        End Try
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        Try
            RegUltimo()
        Catch EX As Exception
            Local.MostraErr(EX, "Último Registro")
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            RegNovo()
        Catch EX As Exception
            Local.MostraErr(EX, "Registro Novo")
        End Try
    End Sub

    Private Sub btnDuplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicar.Click
        Try
            Dim Conteudo As String = Icraft.IcftBase.Form.Conteudo(tabPrinc, "FLD")
            RegNovo(False)
            Icraft.IcftBase.Form.Conteudo(tabPrinc, "FLD") = Conteudo
            CarregaImagens()
        Catch EX As Exception
            Local.MostraErr(EX, "Duplicando Registro")
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Icraft.IcftBase.GravaReg("fld", tabPrinc, "IM.ETIQUETA", "ETIQ=:F_ETIQ", Login.Strconn, Nothing, ":F_ETIQ", lblChave.Text)
            AtualizaChaves()
            GravaAtividades()
            GravaEntrega()
            MsgBox("Registro gravado com sucesso.", MsgBoxStyle.Information, "Gravação de Registro")
        Catch EX As Exception
            Local.MostraErr(EX, "Salvando Registro")
        End Try
    End Sub

    Sub GravaEntrega()
        'Dim Comandos As New ArrayList
        'Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT SEQ, CIA_COD_LOCAL FROM IM.CIA_LOCAL WHERE CIA_COD=:CIA_COD ORDER BY SEQ", Login.Strconn, ":CIA_COD", FLDCOD.Text)
        'Dim REGS As List(Of DataGridViewRow) = (From X As DataGridViewRow In grdEntrega.Rows Where Not X.IsNewRow Order By X.Cells(0).Value Select X).ToList
        'Dim DSPos As Integer = 0
        'Dim RegsPos As Integer = 0
        'Do While DSPos < DS.Tables(0).Rows.Count Or RegsPos < REGS.Count
        '    If (DSPos < DS.Tables(0).Rows.Count) AndAlso (RegsPos >= REGS.Count OrElse DS.Tables(0).Rows(DSPos)(0) < REGS(RegsPos).Cells(0).Value) Then
        '        Comandos.Add("DELETE FROM IM.CIA_LOCAL WHERE CIA_COD = '" & Icraft.IcftBase.Tratex(FLDCOD.Text) & "' AND SEQ = " & DS.Tables(0).Rows(DSPos)(0))
        '        DSPos += 1
        '    ElseIf (RegsPos < REGS.Count) AndAlso (DSPos >= DS.Tables(0).Rows.Count OrElse DS.Tables(0).Rows(DSPos)(0) > REGS(RegsPos).Cells(0).Value) Then
        '        Comandos.Add("INSERT INTO IM.CIA_LOCAL(CIA_COD,SEQ,CIA_COD_LOCAL) VALUES('" & Icraft.IcftBase.Tratex(FLDCOD.Text) & "', " & REGS(RegsPos).Cells(0).Value & ", '" & Icraft.IcftBase.Tratex(REGS(RegsPos).Cells(1).Value) & "')")
        '        RegsPos += 1
        '    Else
        '        If DS.Tables(0).Rows(DSPos)(1) <> REGS(RegsPos).Cells(1).Value Then
        '            Comandos.Add("UPDATE IM.CIA_LOCAL SET CIA_COD_LOCAL = '" & Icraft.IcftBase.Tratex(REGS(RegsPos).Cells(1).Value) & "' WHERE CIA_COD = '" & Icraft.IcftBase.Tratex(FLDCOD.Text) & "' AND SEQ = " & DS.Tables(0).Rows(DSPos)(0))
        '        End If
        '        DSPos += 1
        '        RegsPos += 1
        '    End If
        'Loop
        'If Comandos.Count > 0 Then
        '    Icraft.IcftBase.DSGrava(Comandos, Login.Strconn)
        'End If
    End Sub

    Sub GravaAtividades()
        'Dim Comandos As New ArrayList
        'Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT RAMO_ATIVIDADE_COD FROM IM.CIA_RAMO_ATIVIDADE WHERE CIA_COD=:CIA_COD", Login.Strconn, ":CIA_COD", FLDCOD.Text)
        'Dim Controles As ArrayList = Icraft.IcftBase.Form.Controles(pnlAtiv, "ativchk")

        'For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
        '    Dim LinhaRamo As String = Linha(0)
        '    Dim Ctl As CheckBox = (From x In Controles Where x.text = LinhaRamo Select x).First
        '    If Not Ctl.Checked Then
        '        Comandos.Add("DELETE FROM IM.CIA_RAMO_ATIVIDADE WHERE CIA_COD='" & Icraft.IcftBase.Tratex(FLDCOD.Text) & "' AND RAMO_ATIVIDADE_COD = '" & Icraft.IcftBase.Tratex(Linha(0)) & "'")
        '    End If
        'Next
        'For Each Ctl As CheckBox In Controles
        '    Dim CtlNome As String = Ctl.Name
        '    Dim Ativ As String = Ctl.Text
        '    If Ctl.Checked AndAlso (From x In DS.Tables(0).Rows Where x(0) = Ativ).Count = 0 Then
        '        Comandos.Add("INSERT INTO IM.CIA_RAMO_ATIVIDADE(CIA_COD,RAMO_ATIVIDADE_COD) VALUES('" & Icraft.IcftBase.Tratex(FLDCOD.Text) & "', '" & Icraft.IcftBase.Tratex(Ativ) & "')")
        '    End If
        'Next
        'If Comandos.Count > 0 Then
        '    Icraft.IcftBase.DSGrava(Comandos, Login.Strconn)
        'End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            RegMostra()
        Catch EX As Exception
            Local.MostraErr(EX, "Cancelando Registro")
        End Try
    End Sub

    Private Sub btnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResult.Click
        Try
            If txtBusca.Text <> FiltroCustomExpr Then
                FiltroCustomSQL = ""
            End If
            AtualizaChaves()
        Catch EX As Exception
            Local.MostraErr(EX, "Procurando")
        End Try
    End Sub

    Private Sub btnCargaFLDLOGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaFLDLOGO.Click
        Try
            dlgArquivo.FileName = Icraft.IcftBase.FileExpr(FLDLOGO.Text)
            If dlgArquivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FLDLOGO.Text = Icraft.IcftBase.URLExpr(dlgArquivo.FileName)
                CarregaImagem(imagemFLDLOGO, FLDLOGO.Text)
            End If
        Catch EX As Exception
            Local.MostraErr(EX, "Carregando Imagem")
        End Try
    End Sub

    Sub CarregaImagens()
        For Each Ctl As PictureBox In Icraft.IcftBase.Form.Controles(tabPrinc, "imagem")
            Dim Campo As String = Mid(Ctl.Name, 7)
            Dim Fld As TextBox = tabPrinc.Controls.Find(Campo, True)(0)
            CarregaImagem(Ctl, Fld.Text)
        Next
    End Sub

    Private Sub btnLimpaFLDLOGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaFLDLOGO.Click
        Try
            FLDLOGO.Text = ""
            CarregaImagem(imagemFLDLOGO, FLDLOGO.Text)
        Catch EX As Exception
            Local.MostraErr(EX, "Eliminando Imagem")
        End Try
    End Sub

    Sub CarregaEntrega(ByVal Reg As Integer)
        Dim Entrega As String = ""
        Try
            Entrega = Icraft.IcftBase.NZV(grdEntrega.Rows(Reg).Cells(1).Value, "")
        Catch
        End Try
        Icraft.IcftBase.CarregaReg("entrega", pnlEntrega, "IM.CIA", "COD=:COD", Login.Strconn, ":COD", Entrega)
    End Sub

    Private Sub grdEntrega_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEntrega.RowEnter
        Try
            If e.RowIndex >= (grdEntrega.Rows.Count - 1) Then
                grdEntrega.Rows(e.RowIndex).Cells(0).Value = 0
            End If
            CarregaEntrega(e.RowIndex)
        Catch EX As Exception
            Local.MostraErr(EX, "Vendo Entrega")
        End Try
    End Sub

    Private Sub grdEntrega_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdEntrega.RowValidating
        Try
            Dim R As DataGridViewRow = grdEntrega.Rows(e.RowIndex)
            If Icraft.IcftBase.NZV(R.Cells(0).Value, 0) = 0 And R.Index < (grdEntrega.Rows.Count - 1) Then
                grdEntrega.Rows(R.Index).Cells(0).Value = Icraft.IcftBase.NZV((From x In grdEntrega.Rows Order By x.cells(0).value Descending Select x.cells(0).value).Max(), 0) + 1
            End If
        Catch EX As Exception
            Local.MostraErr(EX, "Validando Entrega")
        End Try
    End Sub

    Private Sub btnEntregaMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntregaMais.Click
        Try
            grdEntrega.CurrentRow.Cells(1).Value = Abre(Me, "Local de Entrega", grdEntrega.CurrentRow.Cells(1).Value)
        Catch EX As Exception
            Local.MostraErr(EX, "Detalhes de Entrega")
        End Try
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal NomeForm As String)
        InitializeComponent()
        Text = NomeForm
    End Sub

    Shared Function Abre(ByVal QuemChama As Form, ByVal Titulo As String, ByVal Filtro As String)
        Dim DTCIa As New frmCiaT(Titulo)
        DTCIa.txtBusca.Text = Filtro
        DTCIa.AtualizaChaves()
        DTCIa.btnRetornar.Visible = True
        Local.MostraForm(DTCIa, Princ)
        'Do While IsNothing(DTCIa.Result)
        Icraft.IcftBase.Espera(0.2)
        'Loop
        'Dim Result As Object = DTCIa.Result
        DTCIa.Dispose()
        QuemChama.Focus()
        Return Nothing 'Result
    End Function

    Dim Result As Object = Nothing

    Private Sub btnRetornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornar.Click
        Try
            Result = lblChave.Text
        Catch EX As Exception
            Local.MostraErr(EX, "Retornando Valor")
        End Try
    End Sub

    Dim CNPJ_MASC_PROG As String = "[0-9]{0,2}|[0-9]{2,2}\.[0-9]{0,3}|[0-9]{2,2}\.[0-9]{3,3}\.[0-9]{0,3}|[0-9]{2,2}\.[0-9]{3,3}\.[0-9]{3,3}\/[0-9]{0,4}|[0-9]{2,2}\.[0-9]{3,3}\.[0-9]{3,3}\/[0-9]{4,4}\-[0-9]{1,2}"
    Dim CNPJ_MASC_CONF As String = "[0-9]{2,2}\.[0-9]{3,3}\.[0-9]{3,3}\/[0-9]{4,4}\-[0-9]{2,2}"
    Dim CNPJ_MASC_AUTO As String = "  .   .   /    -  "

    Private Sub FLDCNPJ_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        FLDCNPJ.Text = CNPJ_MASC_AUTO
    End Sub

    Dim _FiltroCustom As New List(Of Icraft.IcftFFiltro.FiltroDef)


    Private Sub btnTabGrid_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnTabGrid.LinkClicked
        If sender.text = "Ver Grid" Then
            tabPrinc.Visible = False
            grdPrinc.Visible = True
            sender.text = "Ver Form"
        Else
            tabPrinc.Visible = True
            grdPrinc.Visible = False
            sender.text = "Ver Grid"
        End If
    End Sub
End Class

