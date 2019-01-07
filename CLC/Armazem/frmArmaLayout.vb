Public Class frmArmaLayout

    ''' <summary>
    ''' Declaração do GerFiltro.
    ''' </summary>
    ''' <remarks></remarks>
    Shared _GerFiltro As String

    ''' <summary>
    ''' Carrega o filtro na tela.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property GerFiltro() As String
        Get
            Return _GerFiltro
        End Get
        Set(ByVal value As String)
            _GerFiltro = value
        End Set
    End Property
    Private Sub txtArm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArm.SelectedIndexChanged
        ATUALIZA_GALPA()
    End Sub

    ''' <summary>
    ''' Função de atualização no layout do galpão.
    ''' </summary>
    ''' <remarks></remarks>
    Sub ATUALIZA_GALPA()
        Icraft.IcftBase.CarregaCombo(txtGalpa, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT ARM_NUM FROM IM.ETIQUETA WHERE ARMAZEM_CIA_COD = :ARM_COD", Login.Strconn, ":ARM_COD", txtArm.Text))
        ATUALIZA_LAYOUT()
    End Sub

    Private Sub frmArmaLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ATUALIZA_ARMA()
    End Sub

    ''' <summary>
    ''' Atualiza o número do armazém apresentado no layout.
    ''' </summary>
    ''' <remarks></remarks>
    Sub ATUALIZA_ARMA()
        Icraft.IcftBase.CarregaCombo(txtArm, 1, False, "|", False, Icraft.IcftBase.DSCarrega("SELECT COD FROM IM.CIA C WHERE EXISTS(SELECT * FROM IM.CIA_RAMO_ATIVIDADE CR WHERE CR.CIA_COD = C.COD AND cr.ramo_atividade_cod = 'ARMAZÉM')", Login.Strconn))
        ATUALIZA_GALPA()
    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        ATUALIZA_LAYOUT()
    End Sub

    Private Sub txtGalpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGalpa.SelectedIndexChanged
        ATUALIZA_LAYOUT()
    End Sub

    ''' <summary>
    ''' Variável de contagem.
    ''' </summary>
    ''' <remarks></remarks>
    Dim PASSO As Integer = 20

    Sub ATUALIZA_LAYOUT()
        pnlLayout.Padding() = New Padding(10)
        pnlLayout.Controls.Clear()
        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT * FROM IM.ARMAZEM_PRACA WHERE ARMAZEM_CIA_COD = :CIA_COD AND ARMAZEM_NUM = :ARM_NUM ORDER BY PRACA", Login.Strconn, ":CIA_COD", txtArm.Text, ":ARM_NUM", txtGalpa.Text)
        Dim Y As Integer = 0
        For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
            Dim Elem As New Icraft.IcftBase.ElementosStr(Icraft.IcftBase.NZ(Linha!QUADRO_CFG, ""))
            Dim Quadro As String = Elem.Items("Quadro").Conteudo
            Dim Texto As String = Elem.Items("Texto").Conteudo
            If Texto = "" Then
                Texto = Linha!Praca
            End If
            If Quadro = "" Then
                Quadro = "0," & Y & "," & PASSO * 4 & "," & Y + PASSO
                Y += PASSO
            End If

            Dim Lab As New TextBox
            Lab.Tag = Linha!PRACA
            Lab.Multiline = True
            Dim Q() As String = Split(Quadro, ",")
            Lab.Left = Q(0)
            Lab.Top = Q(1)
            Lab.Width = Q(2) - Q(0) + 1
            Lab.Height = Q(3) - Q(1) + 1
            Lab.BorderStyle = BorderStyle.Fixed3D
            Lab.Text = Texto
            Lab.AllowDrop = True

            AddHandler Lab.Click, AddressOf ETIQ_CLICK
            AddHandler Lab.KeyDown, AddressOf ETIQ_KEYDOWN
            AddHandler Lab.DragDrop, AddressOf ETIQ_DRAG
            AddHandler Lab.DragEnter, AddressOf ETIQ_DRAGENTER
            AddHandler Lab.DragLeave, AddressOf ETIQ_DRAGLEAVE
            AddHandler Lab.DragOver, AddressOf ETIQ_DRAGOVER
            pnlLayout.Controls.Add(Lab)
        Next
    End Sub

    Dim DRAG As Object = Nothing
    Sub ETIQ_DRAGENTER(ByVal SENDER As Object, ByVal E As System.Windows.Forms.DragEventArgs)
        DRAG = SENDER
        DX = SENDER.LEFT
        DY = SENDER.TOP
        E.Effect = DragDropEffects.All
    End Sub

    Dim DX As Integer
    Dim DY As Integer
    Sub ETIQ_DRAGOVER(ByVal SENDER As Object, ByVal E As System.Windows.Forms.DragEventArgs)
        If E.X <> DX Or E.Y <> DY Then
            SENDER.LOCATION = Me.PointToClient(New Point(E.X, E.Y))
        End If
    End Sub

    Sub ETIQ_DRAG(ByVal SENDER As Object, ByVal E As Object)

    End Sub

    Sub ETIQ_DRAGLEAVE(ByVal SENDER As Object, ByVal E As Object)

    End Sub

    Sub AtualizaSel()
        For Each CTL As TextBox In pnlLayout.Controls
            CTL.BackColor = Color.White
            CTL.ForeColor = Color.Black
        Next
        For Each ITEM As TextBox In AR
            ITEM.BackColor = Color.Gray
            ITEM.ForeColor = Color.White
        Next
    End Sub

    Sub ETIQ_CLICK(ByVal sender As Object, ByVal e As Object)
        If Not Control.ModifierKeys = Keys.Shift Then
            AR.Clear()
        End If
        AR.Add(sender)
        AtualizaSel()
        _GerFiltro = txtGalpa.Text & ";" & sender.ToString.Substring(sender.ToString.LastIndexOf(":") + 1)
    End Sub

    Dim AR As New ArrayList

    Sub ETIQ_KEYDOWN(ByVal SENDER As Object, ByVal E As System.Windows.Forms.KeyEventArgs)
        If E.Shift Then
            If E.KeyCode = Keys.Right Then
                For Each item As TextBox In AR
                    item.Width += PASSO
                Next
            ElseIf E.KeyCode = Keys.Left Then
                For Each item As TextBox In AR
                    item.Width -= PASSO
                    If item.Width < PASSO * 4 Then item.Width = PASSO
                Next
            ElseIf E.KeyCode = Keys.Up Then
                For Each item As TextBox In AR
                    item.Height -= PASSO
                    If item.Height < PASSO Then item.Height = PASSO
                Next
            ElseIf E.KeyCode = Keys.Down Then
                For Each item As TextBox In AR
                    item.Height += PASSO
                Next
            End If

        Else

            If E.KeyCode = Keys.Right Then
                For Each ITEM As TextBox In AR
                    ITEM.Left += PASSO
                Next

            ElseIf E.KeyCode = Keys.Left Then
                For Each ITEM As TextBox In AR
                    ITEM.Left -= PASSO
                Next
            ElseIf E.KeyCode = Keys.Up Then
                For Each ITEM As TextBox In AR
                    ITEM.Top -= PASSO
                Next
            ElseIf E.KeyCode = Keys.Down Then
                For Each ITEM As TextBox In AR
                    ITEM.Top += PASSO
                Next
            End If
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        For Each CTL As TextBox In pnlLayout.Controls
            If CTL.Tag <> "" Then
                Dim DESCR As New Icraft.IcftBase.ElementosStr("")
                DESCR.Items("Quadro").Conteudo = CTL.Left + pnlLayout.HorizontalScroll.Value & "," & CTL.Top + pnlLayout.VerticalScroll.Value & "," & CTL.Right + pnlLayout.HorizontalScroll.Value & "," & CTL.Bottom + pnlLayout.VerticalScroll.Value
                DESCR.Items("Texto").Conteudo = CTL.Text
                Icraft.IcftBase.DSGrava("UPDATE IM.ARMAZEM_PRACA SET QUADRO_CFG = :QUADRO_CFG WHERE ARMAZEM_CIA_COD=:ARQ AND ARMAZEM_NUM=:NUM AND PRACA=:PRACA", Login.Strconn, ":QUADRO_CFG", DESCR.ToString, ":ARQ", txtArm.Text, ":NUM", txtGalpa.Text, ":PRACA", CTL.Tag)
            End If
        Next
        MsgBox("Layout salvo.")
    End Sub

    Private Sub btnSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelTodos.Click
        AR.Clear()
        For Each CTL As TextBox In pnlLayout.Controls
            AR.Add(CTL)
        Next
        AtualizaSel()
        If AR.Count > 0 Then
            AR(0).FOCUS()
        End If
    End Sub

    Private Sub btnDimensoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDimensoes.Click
        Local.MostraForm(frmVolumesDimensao, Princ, , _GerFiltro)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Local.MostraForm(frmEtiqsPraca, Princ, , _GerFiltro)
    End Sub
End Class
