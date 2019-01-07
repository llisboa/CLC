<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Mensagem = New System.Windows.Forms.GroupBox
        Me.txtCorpo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtBaixa = New System.Windows.Forms.RadioButton
        Me.rbtAlta = New System.Windows.Forms.RadioButton
        Me.rbtNormal = New System.Windows.Forms.RadioButton
        Me.txtServidor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grpAnexos = New System.Windows.Forms.GroupBox
        Me.grdAnexos = New Icraft.IcftFGrid2
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnTodos = New System.Windows.Forms.Button
        Me.btnConfirma = New System.Windows.Forms.Button
        Me.lblAnexos = New System.Windows.Forms.Label
        Me.btnAnexar = New System.Windows.Forms.Button
        Me.btnDiretorio = New System.Windows.Forms.Button
        Me.txtNomeArq = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmails = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAssunto = New System.Windows.Forms.TextBox
        Me.txtRem = New System.Windows.Forms.TextBox
        Me.btnRemover = New System.Windows.Forms.Button
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.btnEnviaPendentes = New System.Windows.Forms.Button
        Me.btnReenviaSel = New System.Windows.Forms.Button
        Me.btnEnviaViagem = New System.Windows.Forms.Button
        Me.btnEnviaResumo = New System.Windows.Forms.Button
        Me.btnImpViagem = New System.Windows.Forms.Button
        Me.btnImpResumo = New System.Windows.Forms.Button
        Me.grpResumo = New System.Windows.Forms.GroupBox
        Me.grdResumo = New Icraft.IcftFGrid2
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.grpAcompanhamento = New System.Windows.Forms.GroupBox
        Me.grdAcompanhamento = New Icraft.IcftFGrid2
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.grpViagens = New System.Windows.Forms.GroupBox
        Me.grdViagens = New Icraft.IcftFGrid2
        Me.DDG = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1.SuspendLayout()
        Me.Mensagem.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpAnexos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlComandos.SuspendLayout()
        Me.grpResumo.SuspendLayout()
        Me.grpAcompanhamento.SuspendLayout()
        Me.grpViagens.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Mensagem)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 141)
        Me.Panel1.TabIndex = 16
        '
        'Mensagem
        '
        Me.Mensagem.Controls.Add(Me.txtCorpo)
        Me.Mensagem.Location = New System.Drawing.Point(714, 7)
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.Size = New System.Drawing.Size(377, 134)
        Me.Mensagem.TabIndex = 27
        Me.Mensagem.TabStop = False
        Me.Mensagem.Text = "Corpo da Mensagem"
        '
        'txtCorpo
        '
        Me.txtCorpo.Location = New System.Drawing.Point(6, 19)
        Me.txtCorpo.Multiline = True
        Me.txtCorpo.Name = "txtCorpo"
        Me.txtCorpo.Size = New System.Drawing.Size(365, 109)
        Me.txtCorpo.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtBaixa)
        Me.GroupBox2.Controls.Add(Me.rbtAlta)
        Me.GroupBox2.Controls.Add(Me.rbtNormal)
        Me.GroupBox2.Controls.Add(Me.txtServidor)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(1097, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 134)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configurações"
        '
        'rbtBaixa
        '
        Me.rbtBaixa.AutoSize = True
        Me.rbtBaixa.Location = New System.Drawing.Point(7, 114)
        Me.rbtBaixa.Name = "rbtBaixa"
        Me.rbtBaixa.Size = New System.Drawing.Size(51, 17)
        Me.rbtBaixa.TabIndex = 26
        Me.rbtBaixa.Text = "Baixa"
        Me.rbtBaixa.UseVisualStyleBackColor = True
        '
        'rbtAlta
        '
        Me.rbtAlta.AutoSize = True
        Me.rbtAlta.Checked = True
        Me.rbtAlta.Location = New System.Drawing.Point(7, 80)
        Me.rbtAlta.Name = "rbtAlta"
        Me.rbtAlta.Size = New System.Drawing.Size(43, 17)
        Me.rbtAlta.TabIndex = 25
        Me.rbtAlta.TabStop = True
        Me.rbtAlta.Text = "Alta"
        Me.rbtAlta.UseVisualStyleBackColor = True
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Location = New System.Drawing.Point(7, 97)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbtNormal.TabIndex = 24
        Me.rbtNormal.Text = "Normal"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(7, 34)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(88, 20)
        Me.txtServidor.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Prioridade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Servidor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpAnexos)
        Me.GroupBox1.Controls.Add(Me.lblAnexos)
        Me.GroupBox1.Controls.Add(Me.btnAnexar)
        Me.GroupBox1.Controls.Add(Me.btnDiretorio)
        Me.GroupBox1.Controls.Add(Me.txtNomeArq)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmails)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAssunto)
        Me.GroupBox1.Controls.Add(Me.txtRem)
        Me.GroupBox1.Controls.Add(Me.btnRemover)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 135)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Envio de Email"
        '
        'grpAnexos
        '
        Me.grpAnexos.Controls.Add(Me.grdAnexos)
        Me.grpAnexos.Controls.Add(Me.Panel2)
        Me.grpAnexos.Location = New System.Drawing.Point(-3, 1)
        Me.grpAnexos.Name = "grpAnexos"
        Me.grpAnexos.Size = New System.Drawing.Size(708, 135)
        Me.grpAnexos.TabIndex = 32
        Me.grpAnexos.TabStop = False
        Me.grpAnexos.Text = "Lista de Anexos"
        Me.grpAnexos.Visible = False
        '
        'grdAnexos
        '
        Me.grdAnexos.AutoBind = False
        Me.grdAnexos.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdAnexos.BindContainer = Nothing
        Me.grdAnexos.Campos = Nothing
        Me.grdAnexos.CamposExtend = Nothing
        Me.grdAnexos.CamposFixos = ""
        Me.grdAnexos.Chave = Nothing
        Me.grdAnexos.ColunaNomes = ""
        Me.grdAnexos.Defs = Nothing
        Me.grdAnexos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAnexos.EsquemaGerador = "IM"
        Me.grdAnexos.EsquemaPrinc = "IM"
        Me.grdAnexos.Filtro = Nothing
        Me.grdAnexos.IncluiCamposSys = False
        Me.grdAnexos.Info = "Informações..."
        Me.grdAnexos.Location = New System.Drawing.Point(3, 16)
        Me.grdAnexos.MostraNumReg = False
        Me.grdAnexos.Name = "grdAnexos"
        Me.grdAnexos.Ocultar = Nothing
        Me.grdAnexos.Params = CType(resources.GetObject("grdAnexos.Params"), System.Collections.ArrayList)
        Me.grdAnexos.Sistema = "IM"
        Me.grdAnexos.Size = New System.Drawing.Size(641, 116)
        Me.grdAnexos.SomenteLeitura = False
        Me.grdAnexos.SQL = ""
        Me.grdAnexos.StrConn = Nothing
        Me.grdAnexos.Tabela = ""
        Me.grdAnexos.TabIndex = 21
        Me.grdAnexos.Tag = ""
        Me.grdAnexos.Totaliza = ""
        Me.grdAnexos.Usuario = ""
        Me.grdAnexos.ValorPadrao = CType(resources.GetObject("grdAnexos.ValorPadrao"), System.Collections.ArrayList)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTodos)
        Me.Panel2.Controls.Add(Me.btnConfirma)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(644, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(61, 116)
        Me.Panel2.TabIndex = 22
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(3, 61)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(58, 24)
        Me.btnTodos.TabIndex = 3
        Me.btnTodos.Text = "Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Location = New System.Drawing.Point(3, 88)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(58, 24)
        Me.btnConfirma.TabIndex = 2
        Me.btnConfirma.Text = "Confirmar"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'lblAnexos
        '
        Me.lblAnexos.Location = New System.Drawing.Point(389, 74)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(249, 41)
        Me.lblAnexos.TabIndex = 31
        '
        'btnAnexar
        '
        Me.btnAnexar.Location = New System.Drawing.Point(644, 70)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(55, 21)
        Me.btnAnexar.TabIndex = 30
        Me.btnAnexar.Text = "Anexar"
        Me.btnAnexar.UseVisualStyleBackColor = True
        '
        'btnDiretorio
        '
        Me.btnDiretorio.Location = New System.Drawing.Point(674, 44)
        Me.btnDiretorio.Name = "btnDiretorio"
        Me.btnDiretorio.Size = New System.Drawing.Size(24, 21)
        Me.btnDiretorio.TabIndex = 29
        Me.btnDiretorio.Text = "..."
        Me.btnDiretorio.UseVisualStyleBackColor = True
        '
        'txtNomeArq
        '
        Me.txtNomeArq.Location = New System.Drawing.Point(389, 45)
        Me.txtNomeArq.Name = "txtNomeArq"
        Me.txtNomeArq.Size = New System.Drawing.Size(279, 20)
        Me.txtNomeArq.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Defina o nome do arquivo"
        '
        'txtEmails
        '
        Me.txtEmails.Location = New System.Drawing.Point(7, 86)
        Me.txtEmails.Multiline = True
        Me.txtEmails.Name = "txtEmails"
        Me.txtEmails.Size = New System.Drawing.Size(376, 43)
        Me.txtEmails.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Assunto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Emails (separados por ponto e vírgula = ';')"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Remetente"
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(74, 45)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(309, 20)
        Me.txtAssunto.TabIndex = 17
        '
        'txtRem
        '
        Me.txtRem.Location = New System.Drawing.Point(74, 18)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(309, 20)
        Me.txtRem.TabIndex = 16
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(644, 94)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(55, 21)
        Me.btnRemover.TabIndex = 33
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlComandos.Controls.Add(Me.btnEnviaPendentes)
        Me.pnlComandos.Controls.Add(Me.btnReenviaSel)
        Me.pnlComandos.Controls.Add(Me.btnEnviaViagem)
        Me.pnlComandos.Controls.Add(Me.btnEnviaResumo)
        Me.pnlComandos.Controls.Add(Me.btnImpViagem)
        Me.pnlComandos.Controls.Add(Me.btnImpResumo)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(935, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlComandos.Size = New System.Drawing.Size(93, 654)
        Me.pnlComandos.TabIndex = 15
        '
        'btnEnviaPendentes
        '
        Me.btnEnviaPendentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnviaPendentes.Location = New System.Drawing.Point(5, 195)
        Me.btnEnviaPendentes.Name = "btnEnviaPendentes"
        Me.btnEnviaPendentes.Size = New System.Drawing.Size(79, 38)
        Me.btnEnviaPendentes.TabIndex = 10
        Me.btnEnviaPendentes.Text = "Enviar Pendentes"
        Me.btnEnviaPendentes.UseVisualStyleBackColor = True
        '
        'btnReenviaSel
        '
        Me.btnReenviaSel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReenviaSel.Location = New System.Drawing.Point(5, 157)
        Me.btnReenviaSel.Name = "btnReenviaSel"
        Me.btnReenviaSel.Size = New System.Drawing.Size(79, 38)
        Me.btnReenviaSel.TabIndex = 9
        Me.btnReenviaSel.Text = "Reenviar Marcados"
        Me.btnReenviaSel.UseVisualStyleBackColor = True
        '
        'btnEnviaViagem
        '
        Me.btnEnviaViagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnviaViagem.Location = New System.Drawing.Point(5, 119)
        Me.btnEnviaViagem.Name = "btnEnviaViagem"
        Me.btnEnviaViagem.Size = New System.Drawing.Size(79, 38)
        Me.btnEnviaViagem.TabIndex = 8
        Me.btnEnviaViagem.Text = "Enviar Viagens"
        Me.btnEnviaViagem.UseVisualStyleBackColor = True
        '
        'btnEnviaResumo
        '
        Me.btnEnviaResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnviaResumo.Location = New System.Drawing.Point(5, 81)
        Me.btnEnviaResumo.Name = "btnEnviaResumo"
        Me.btnEnviaResumo.Size = New System.Drawing.Size(79, 38)
        Me.btnEnviaResumo.TabIndex = 7
        Me.btnEnviaResumo.Text = "Enviar Resumos"
        Me.btnEnviaResumo.UseVisualStyleBackColor = True
        '
        'btnImpViagem
        '
        Me.btnImpViagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImpViagem.Location = New System.Drawing.Point(5, 43)
        Me.btnImpViagem.Name = "btnImpViagem"
        Me.btnImpViagem.Size = New System.Drawing.Size(79, 38)
        Me.btnImpViagem.TabIndex = 6
        Me.btnImpViagem.Text = "Imprimir Viagens"
        Me.btnImpViagem.UseVisualStyleBackColor = True
        '
        'btnImpResumo
        '
        Me.btnImpResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImpResumo.Location = New System.Drawing.Point(5, 5)
        Me.btnImpResumo.Name = "btnImpResumo"
        Me.btnImpResumo.Size = New System.Drawing.Size(79, 38)
        Me.btnImpResumo.TabIndex = 1
        Me.btnImpResumo.Text = "Imprimir Resumos"
        Me.btnImpResumo.UseVisualStyleBackColor = True
        '
        'grpResumo
        '
        Me.grpResumo.Controls.Add(Me.grdResumo)
        Me.grpResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpResumo.Location = New System.Drawing.Point(0, 141)
        Me.grpResumo.Name = "grpResumo"
        Me.grpResumo.Size = New System.Drawing.Size(935, 179)
        Me.grpResumo.TabIndex = 17
        Me.grpResumo.TabStop = False
        Me.grpResumo.Text = "Resumo de Programação"
        '
        'grdResumo
        '
        Me.grdResumo.AutoBind = False
        Me.grdResumo.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdResumo.BindContainer = Nothing
        Me.grdResumo.Campos = Nothing
        Me.grdResumo.CamposExtend = Nothing
        Me.grdResumo.CamposFixos = ""
        Me.grdResumo.Chave = Nothing
        Me.grdResumo.ColunaNomes = ""
        Me.grdResumo.Defs = Nothing
        Me.grdResumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdResumo.EsquemaGerador = "IM"
        Me.grdResumo.EsquemaPrinc = "IM"
        Me.grdResumo.Filtro = Nothing
        Me.grdResumo.IncluiCamposSys = False
        Me.grdResumo.Info = "Informações..."
        Me.grdResumo.Location = New System.Drawing.Point(3, 16)
        Me.grdResumo.MostraNumReg = False
        Me.grdResumo.Name = "grdResumo"
        Me.grdResumo.Ocultar = Nothing
        Me.grdResumo.Params = CType(resources.GetObject("grdResumo.Params"), System.Collections.ArrayList)
        Me.grdResumo.Sistema = "IM"
        Me.grdResumo.Size = New System.Drawing.Size(929, 160)
        Me.grdResumo.SomenteLeitura = False
        Me.grdResumo.SQL = ""
        Me.grdResumo.StrConn = Nothing
        Me.grdResumo.Tabela = ""
        Me.grdResumo.TabIndex = 14
        Me.grdResumo.Tag = ""
        Me.grdResumo.Totaliza = ""
        Me.grdResumo.Usuario = ""
        Me.grdResumo.ValorPadrao = CType(resources.GetObject("grdResumo.ValorPadrao"), System.Collections.ArrayList)
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 320)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(935, 10)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'grpAcompanhamento
        '
        Me.grpAcompanhamento.Controls.Add(Me.grdAcompanhamento)
        Me.grpAcompanhamento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpAcompanhamento.Location = New System.Drawing.Point(0, 475)
        Me.grpAcompanhamento.Name = "grpAcompanhamento"
        Me.grpAcompanhamento.Size = New System.Drawing.Size(935, 179)
        Me.grpAcompanhamento.TabIndex = 19
        Me.grpAcompanhamento.TabStop = False
        Me.grpAcompanhamento.Text = "Acompanhamento"
        '
        'grdAcompanhamento
        '
        Me.grdAcompanhamento.AutoBind = False
        Me.grdAcompanhamento.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdAcompanhamento.BindContainer = Nothing
        Me.grdAcompanhamento.Campos = Nothing
        Me.grdAcompanhamento.CamposExtend = Nothing
        Me.grdAcompanhamento.CamposFixos = ""
        Me.grdAcompanhamento.Chave = Nothing
        Me.grdAcompanhamento.ColunaNomes = ""
        Me.grdAcompanhamento.Defs = Nothing
        Me.grdAcompanhamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAcompanhamento.EsquemaGerador = "IM"
        Me.grdAcompanhamento.EsquemaPrinc = "IM"
        Me.grdAcompanhamento.Filtro = Nothing
        Me.grdAcompanhamento.IncluiCamposSys = False
        Me.grdAcompanhamento.Info = "Informações..."
        Me.grdAcompanhamento.Location = New System.Drawing.Point(3, 16)
        Me.grdAcompanhamento.MostraNumReg = False
        Me.grdAcompanhamento.Name = "grdAcompanhamento"
        Me.grdAcompanhamento.Ocultar = Nothing
        Me.grdAcompanhamento.Params = CType(resources.GetObject("grdAcompanhamento.Params"), System.Collections.ArrayList)
        Me.grdAcompanhamento.Sistema = "IM"
        Me.grdAcompanhamento.Size = New System.Drawing.Size(929, 160)
        Me.grdAcompanhamento.SomenteLeitura = False
        Me.grdAcompanhamento.SQL = ""
        Me.grdAcompanhamento.StrConn = Nothing
        Me.grdAcompanhamento.Tabela = ""
        Me.grdAcompanhamento.TabIndex = 20
        Me.grdAcompanhamento.Tag = ""
        Me.grdAcompanhamento.Totaliza = ""
        Me.grdAcompanhamento.Usuario = ""
        Me.grdAcompanhamento.ValorPadrao = CType(resources.GetObject("grdAcompanhamento.ValorPadrao"), System.Collections.ArrayList)
        '
        'Splitter2
        '
        Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 465)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(935, 10)
        Me.Splitter2.TabIndex = 20
        Me.Splitter2.TabStop = False
        '
        'grpViagens
        '
        Me.grpViagens.Controls.Add(Me.grdViagens)
        Me.grpViagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpViagens.Location = New System.Drawing.Point(0, 330)
        Me.grpViagens.Name = "grpViagens"
        Me.grpViagens.Size = New System.Drawing.Size(935, 135)
        Me.grpViagens.TabIndex = 21
        Me.grpViagens.TabStop = False
        Me.grpViagens.Text = "Viagens de Programação"
        '
        'grdViagens
        '
        Me.grdViagens.AutoBind = False
        Me.grdViagens.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdViagens.BindContainer = Nothing
        Me.grdViagens.Campos = Nothing
        Me.grdViagens.CamposExtend = Nothing
        Me.grdViagens.CamposFixos = ""
        Me.grdViagens.Chave = Nothing
        Me.grdViagens.ColunaNomes = ""
        Me.grdViagens.Defs = Nothing
        Me.grdViagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdViagens.EsquemaGerador = "IM"
        Me.grdViagens.EsquemaPrinc = "IM"
        Me.grdViagens.Filtro = Nothing
        Me.grdViagens.IncluiCamposSys = False
        Me.grdViagens.Info = "Informações..."
        Me.grdViagens.Location = New System.Drawing.Point(3, 16)
        Me.grdViagens.MostraNumReg = False
        Me.grdViagens.Name = "grdViagens"
        Me.grdViagens.Ocultar = Nothing
        Me.grdViagens.Params = CType(resources.GetObject("grdViagens.Params"), System.Collections.ArrayList)
        Me.grdViagens.Sistema = "IM"
        Me.grdViagens.Size = New System.Drawing.Size(929, 116)
        Me.grdViagens.SomenteLeitura = False
        Me.grdViagens.SQL = ""
        Me.grdViagens.StrConn = Nothing
        Me.grdViagens.Tabela = ""
        Me.grdViagens.TabIndex = 19
        Me.grdViagens.Tag = ""
        Me.grdViagens.Totaliza = ""
        Me.grdViagens.Usuario = ""
        Me.grdViagens.ValorPadrao = CType(resources.GetObject("grdViagens.ValorPadrao"), System.Collections.ArrayList)
        '
        'frmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 654)
        Me.Controls.Add(Me.grpViagens)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.grpAcompanhamento)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.grpResumo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlComandos)
        Me.Name = "frmServicos"
        Me.Text = "Serviços"
        Me.Panel1.ResumeLayout(False)
        Me.Mensagem.ResumeLayout(False)
        Me.Mensagem.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpAnexos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlComandos.ResumeLayout(False)
        Me.grpResumo.ResumeLayout(False)
        Me.grpAcompanhamento.ResumeLayout(False)
        Me.grpViagens.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents btnImpResumo As System.Windows.Forms.Button
    Friend WithEvents grpResumo As System.Windows.Forms.GroupBox
    Friend WithEvents grdResumo As Icraft.IcftFGrid2
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpAcompanhamento As System.Windows.Forms.GroupBox
    Friend WithEvents grdAcompanhamento As Icraft.IcftFGrid2
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents grpViagens As System.Windows.Forms.GroupBox
    Friend WithEvents grdViagens As Icraft.IcftFGrid2
    Friend WithEvents btnEnviaPendentes As System.Windows.Forms.Button
    Friend WithEvents btnReenviaSel As System.Windows.Forms.Button
    Friend WithEvents btnEnviaViagem As System.Windows.Forms.Button
    Friend WithEvents btnEnviaResumo As System.Windows.Forms.Button
    Friend WithEvents btnImpViagem As System.Windows.Forms.Button
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmails As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Mensagem As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBaixa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAlta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNormal As System.Windows.Forms.RadioButton
    Friend WithEvents txtCorpo As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeArq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDiretorio As System.Windows.Forms.Button
    Friend WithEvents DDG As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnAnexar As System.Windows.Forms.Button
    Friend WithEvents lblAnexos As System.Windows.Forms.Label
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents grpAnexos As System.Windows.Forms.GroupBox
    Friend WithEvents grdAnexos As Icraft.IcftFGrid2
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
End Class
