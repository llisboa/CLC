<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensagens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensagens))
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.btnReenvia = New System.Windows.Forms.Button
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.btnEnviaResumo = New System.Windows.Forms.Button
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.btnImpResumo = New System.Windows.Forms.Button
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnEnviaViagem = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnImpViagem = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.pnlAcompanhamento = New System.Windows.Forms.Panel
        Me.grdAcompanhamento = New Icraft.IcftFGrid2
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.pnlConfigEmail = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Corpo = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtEmails = New System.Windows.Forms.TextBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grpResumo = New System.Windows.Forms.GroupBox
        Me.grdResumo = New Icraft.IcftFGrid2
        Me.grpViagens = New System.Windows.Forms.GroupBox
        Me.grdViagens = New Icraft.IcftFGrid2
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAssunto = New System.Windows.Forms.TextBox
        Me.txtCC = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rbtNormal = New System.Windows.Forms.RadioButton
        Me.rbtAlta = New System.Windows.Forms.RadioButton
        Me.rbtBaixa = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pnlComandos.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlAcompanhamento.SuspendLayout()
        Me.pnlConfigEmail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpResumo.SuspendLayout()
        Me.grpViagens.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlComandos.Controls.Add(Me.btnReenvia)
        Me.pnlComandos.Controls.Add(Me.Panel10)
        Me.pnlComandos.Controls.Add(Me.btnEnviaResumo)
        Me.pnlComandos.Controls.Add(Me.Panel9)
        Me.pnlComandos.Controls.Add(Me.btnImpResumo)
        Me.pnlComandos.Controls.Add(Me.Panel8)
        Me.pnlComandos.Controls.Add(Me.btnEnviaViagem)
        Me.pnlComandos.Controls.Add(Me.Panel7)
        Me.pnlComandos.Controls.Add(Me.btnImpViagem)
        Me.pnlComandos.Controls.Add(Me.Panel6)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(664, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Size = New System.Drawing.Size(85, 617)
        Me.pnlComandos.TabIndex = 0
        '
        'btnReenvia
        '
        Me.btnReenvia.AutoSize = True
        Me.btnReenvia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReenvia.Location = New System.Drawing.Point(0, 175)
        Me.btnReenvia.Name = "btnReenvia"
        Me.btnReenvia.Size = New System.Drawing.Size(83, 40)
        Me.btnReenvia.TabIndex = 9
        Me.btnReenvia.Text = "Reenviar Marcados"
        Me.btnReenvia.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 172)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(83, 3)
        Me.Panel10.TabIndex = 8
        '
        'btnEnviaResumo
        '
        Me.btnEnviaResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnviaResumo.Location = New System.Drawing.Point(0, 132)
        Me.btnEnviaResumo.Name = "btnEnviaResumo"
        Me.btnEnviaResumo.Size = New System.Drawing.Size(83, 40)
        Me.btnEnviaResumo.TabIndex = 7
        Me.btnEnviaResumo.Text = "Enviar Resumos"
        Me.btnEnviaResumo.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 129)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(83, 3)
        Me.Panel9.TabIndex = 6
        '
        'btnImpResumo
        '
        Me.btnImpResumo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImpResumo.Location = New System.Drawing.Point(0, 89)
        Me.btnImpResumo.Name = "btnImpResumo"
        Me.btnImpResumo.Size = New System.Drawing.Size(83, 40)
        Me.btnImpResumo.TabIndex = 5
        Me.btnImpResumo.Text = "Imprimir Resumos"
        Me.btnImpResumo.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 86)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(83, 3)
        Me.Panel8.TabIndex = 4
        '
        'btnEnviaViagem
        '
        Me.btnEnviaViagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnviaViagem.Location = New System.Drawing.Point(0, 46)
        Me.btnEnviaViagem.Name = "btnEnviaViagem"
        Me.btnEnviaViagem.Size = New System.Drawing.Size(83, 40)
        Me.btnEnviaViagem.TabIndex = 3
        Me.btnEnviaViagem.Text = "Enviar Viagens"
        Me.btnEnviaViagem.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 43)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(83, 3)
        Me.Panel7.TabIndex = 2
        '
        'btnImpViagem
        '
        Me.btnImpViagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImpViagem.Location = New System.Drawing.Point(0, 3)
        Me.btnImpViagem.Name = "btnImpViagem"
        Me.btnImpViagem.Size = New System.Drawing.Size(83, 40)
        Me.btnImpViagem.TabIndex = 1
        Me.btnImpViagem.Text = "Imprimir Viagens"
        Me.btnImpViagem.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(83, 3)
        Me.Panel6.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.pnlAcompanhamento)
        Me.pnlBottom.Controls.Add(Me.Splitter2)
        Me.pnlBottom.Controls.Add(Me.pnlConfigEmail)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 243)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(664, 374)
        Me.pnlBottom.TabIndex = 1
        '
        'pnlAcompanhamento
        '
        Me.pnlAcompanhamento.Controls.Add(Me.grdAcompanhamento)
        Me.pnlAcompanhamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAcompanhamento.Location = New System.Drawing.Point(0, 289)
        Me.pnlAcompanhamento.Name = "pnlAcompanhamento"
        Me.pnlAcompanhamento.Size = New System.Drawing.Size(664, 85)
        Me.pnlAcompanhamento.TabIndex = 1
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
        Me.grdAcompanhamento.Location = New System.Drawing.Point(0, 0)
        Me.grdAcompanhamento.MostraNumReg = False
        Me.grdAcompanhamento.Name = "grdAcompanhamento"
        Me.grdAcompanhamento.Ocultar = Nothing
        Me.grdAcompanhamento.Params = CType(resources.GetObject("grdAcompanhamento.Params"), System.Collections.ArrayList)
        Me.grdAcompanhamento.Sistema = "IM"
        Me.grdAcompanhamento.Size = New System.Drawing.Size(664, 85)
        Me.grdAcompanhamento.SomenteLeitura = False
        Me.grdAcompanhamento.SQL = ""
        Me.grdAcompanhamento.StrConn = Nothing
        Me.grdAcompanhamento.Tabela = ""
        Me.grdAcompanhamento.TabIndex = 22
        Me.grdAcompanhamento.Tag = ""
        Me.grdAcompanhamento.Totaliza = ""
        Me.grdAcompanhamento.Usuario = ""
        Me.grdAcompanhamento.ValorPadrao = CType(resources.GetObject("grdAcompanhamento.ValorPadrao"), System.Collections.ArrayList)
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Splitter2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 279)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(664, 10)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'pnlConfigEmail
        '
        Me.pnlConfigEmail.Controls.Add(Me.Panel2)
        Me.pnlConfigEmail.Controls.Add(Me.Panel4)
        Me.pnlConfigEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigEmail.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigEmail.Name = "pnlConfigEmail"
        Me.pnlConfigEmail.Size = New System.Drawing.Size(664, 279)
        Me.pnlConfigEmail.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Corpo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 179)
        Me.Panel2.TabIndex = 0
        '
        'Corpo
        '
        Me.Corpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Corpo.Location = New System.Drawing.Point(0, 0)
        Me.Corpo.Multiline = True
        Me.Corpo.Name = "Corpo"
        Me.Corpo.Size = New System.Drawing.Size(664, 179)
        Me.Corpo.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(664, 100)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.txtAssunto)
        Me.Panel5.Controls.Add(Me.txtCC)
        Me.Panel5.Controls.Add(Me.txtEmails)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(586, 100)
        Me.Panel5.TabIndex = 0
        '
        'txtEmails
        '
        Me.txtEmails.Location = New System.Drawing.Point(72, 6)
        Me.txtEmails.Multiline = True
        Me.txtEmails.Name = "txtEmails"
        Me.txtEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEmails.Size = New System.Drawing.Size(508, 39)
        Me.txtEmails.TabIndex = 18
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 233)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(664, 10)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 233)
        Me.Panel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpResumo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpViagens)
        Me.SplitContainer1.Size = New System.Drawing.Size(664, 233)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 22
        '
        'grpResumo
        '
        Me.grpResumo.Controls.Add(Me.grdResumo)
        Me.grpResumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpResumo.Location = New System.Drawing.Point(0, 0)
        Me.grpResumo.Name = "grpResumo"
        Me.grpResumo.Size = New System.Drawing.Size(219, 233)
        Me.grpResumo.TabIndex = 0
        Me.grpResumo.TabStop = False
        Me.grpResumo.Text = "Resumos"
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
        Me.grdResumo.Size = New System.Drawing.Size(213, 214)
        Me.grdResumo.SomenteLeitura = False
        Me.grdResumo.SQL = ""
        Me.grdResumo.StrConn = Nothing
        Me.grdResumo.Tabela = ""
        Me.grdResumo.TabIndex = 16
        Me.grdResumo.Tag = ""
        Me.grdResumo.Totaliza = ""
        Me.grdResumo.Usuario = ""
        Me.grdResumo.ValorPadrao = CType(resources.GetObject("grdResumo.ValorPadrao"), System.Collections.ArrayList)
        '
        'grpViagens
        '
        Me.grpViagens.Controls.Add(Me.grdViagens)
        Me.grpViagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpViagens.Location = New System.Drawing.Point(0, 0)
        Me.grpViagens.Name = "grpViagens"
        Me.grpViagens.Size = New System.Drawing.Size(441, 233)
        Me.grpViagens.TabIndex = 0
        Me.grpViagens.TabStop = False
        Me.grpViagens.Text = "Viagens"
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
        Me.grdViagens.Size = New System.Drawing.Size(435, 214)
        Me.grdViagens.SomenteLeitura = False
        Me.grdViagens.SQL = ""
        Me.grdViagens.StrConn = Nothing
        Me.grdViagens.Tabela = ""
        Me.grdViagens.TabIndex = 21
        Me.grdViagens.Tag = ""
        Me.grdViagens.Totaliza = ""
        Me.grdViagens.Usuario = ""
        Me.grdViagens.ValorPadrao = CType(resources.GetObject("grdViagens.ValorPadrao"), System.Collections.ArrayList)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Assunto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "CC:"
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(72, 76)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(507, 20)
        Me.txtAssunto.TabIndex = 27
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(72, 49)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(507, 20)
        Me.txtCC.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Para:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(586, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(78, 100)
        Me.Panel3.TabIndex = 0
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Location = New System.Drawing.Point(6, 46)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbtNormal.TabIndex = 24
        Me.rbtNormal.Text = "Normal"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'rbtAlta
        '
        Me.rbtAlta.AutoSize = True
        Me.rbtAlta.Checked = True
        Me.rbtAlta.Location = New System.Drawing.Point(6, 29)
        Me.rbtAlta.Name = "rbtAlta"
        Me.rbtAlta.Size = New System.Drawing.Size(43, 17)
        Me.rbtAlta.TabIndex = 25
        Me.rbtAlta.TabStop = True
        Me.rbtAlta.Text = "Alta"
        Me.rbtAlta.UseVisualStyleBackColor = True
        '
        'rbtBaixa
        '
        Me.rbtBaixa.AutoSize = True
        Me.rbtBaixa.Location = New System.Drawing.Point(6, 63)
        Me.rbtBaixa.Name = "rbtBaixa"
        Me.rbtBaixa.Size = New System.Drawing.Size(51, 17)
        Me.rbtBaixa.TabIndex = 26
        Me.rbtBaixa.Text = "Baixa"
        Me.rbtBaixa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtBaixa)
        Me.GroupBox2.Controls.Add(Me.rbtAlta)
        Me.GroupBox2.Controls.Add(Me.rbtNormal)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(78, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prioridade"
        '
        'frmMensagens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlComandos)
        Me.Name = "frmMensagens"
        Me.Text = "Mensagens"
        Me.pnlComandos.ResumeLayout(False)
        Me.pnlComandos.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlAcompanhamento.ResumeLayout(False)
        Me.pnlConfigEmail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpResumo.ResumeLayout(False)
        Me.grpViagens.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpResumo As System.Windows.Forms.GroupBox
    Friend WithEvents grdResumo As Icraft.IcftFGrid2
    Friend WithEvents grpViagens As System.Windows.Forms.GroupBox
    Friend WithEvents grdViagens As Icraft.IcftFGrid2
    Friend WithEvents pnlAcompanhamento As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents pnlConfigEmail As System.Windows.Forms.Panel
    Friend WithEvents grdAcompanhamento As Icraft.IcftFGrid2
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtEmails As System.Windows.Forms.TextBox
    Friend WithEvents Corpo As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnReenvia As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnEnviaResumo As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnImpResumo As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnEnviaViagem As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnImpViagem As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBaixa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAlta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNormal As System.Windows.Forms.RadioButton
End Class
