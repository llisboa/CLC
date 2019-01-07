<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPendencias))
        Me.tab = New System.Windows.Forms.TabControl
        Me.tabPendente = New System.Windows.Forms.TabPage
        Me.pnlCriação = New System.Windows.Forms.Panel
        Me.tabCria = New System.Windows.Forms.TabControl
        Me.tabViagem = New System.Windows.Forms.TabPage
        Me.Sair = New System.Windows.Forms.Button
        Me.ctlRef = New System.Windows.Forms.MaskedTextBox
        Me.btnSalvarViagem = New System.Windows.Forms.Button
        Me.cbxTransp = New System.Windows.Forms.ComboBox
        Me.ctlDataFch = New System.Windows.Forms.MaskedTextBox
        Me.ctlObs = New System.Windows.Forms.TextBox
        Me.lblObs = New System.Windows.Forms.Label
        Me.lblDataFech = New System.Windows.Forms.Label
        Me.lblCarreta = New System.Windows.Forms.Label
        Me.lblRef = New System.Windows.Forms.Label
        Me.tabEscala = New System.Windows.Forms.TabPage
        Me.btnSair = New System.Windows.Forms.Button
        Me.ctlViagemRef = New System.Windows.Forms.MaskedTextBox
        Me.btnSalvarEscala = New System.Windows.Forms.Button
        Me.ctlETS = New System.Windows.Forms.MaskedTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ctlEscala = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbxLocal = New System.Windows.Forms.ComboBox
        Me.ctlETA = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grdPend = New Icraft.IcftFGrid2
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnEmbarcar = New System.Windows.Forms.Button
        Me.pnlPendentes = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscaPend = New System.Windows.Forms.TextBox
        Me.btnBuscaPend = New System.Windows.Forms.Button
        Me.TabParciais = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdViagens = New Icraft.IcftFGrid2
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdItensParc = New Icraft.IcftFGrid2
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnConfirma = New System.Windows.Forms.Button
        Me.pnlPaciais = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblBusca = New System.Windows.Forms.Label
        Me.txtBuscaParc = New System.Windows.Forms.TextBox
        Me.btnBuscaParc = New System.Windows.Forms.Button
        Me.tab.SuspendLayout()
        Me.tabPendente.SuspendLayout()
        Me.pnlCriação.SuspendLayout()
        Me.tabCria.SuspendLayout()
        Me.tabViagem.SuspendLayout()
        Me.tabEscala.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlPendentes.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabParciais.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlPaciais.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.tabPendente)
        Me.tab.Controls.Add(Me.TabParciais)
        Me.tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(958, 420)
        Me.tab.TabIndex = 0
        '
        'tabPendente
        '
        Me.tabPendente.Controls.Add(Me.pnlCriação)
        Me.tabPendente.Controls.Add(Me.grdPend)
        Me.tabPendente.Controls.Add(Me.Panel6)
        Me.tabPendente.Controls.Add(Me.pnlPendentes)
        Me.tabPendente.Location = New System.Drawing.Point(4, 22)
        Me.tabPendente.Name = "tabPendente"
        Me.tabPendente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPendente.Size = New System.Drawing.Size(950, 394)
        Me.tabPendente.TabIndex = 0
        Me.tabPendente.Text = "Itens a serem embarcados"
        Me.tabPendente.UseVisualStyleBackColor = True
        '
        'pnlCriação
        '
        Me.pnlCriação.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCriação.Controls.Add(Me.tabCria)
        Me.pnlCriação.Location = New System.Drawing.Point(186, 68)
        Me.pnlCriação.Name = "pnlCriação"
        Me.pnlCriação.Size = New System.Drawing.Size(686, 330)
        Me.pnlCriação.TabIndex = 19
        Me.pnlCriação.Visible = False
        '
        'tabCria
        '
        Me.tabCria.Controls.Add(Me.tabViagem)
        Me.tabCria.Controls.Add(Me.tabEscala)
        Me.tabCria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCria.Location = New System.Drawing.Point(0, 0)
        Me.tabCria.Name = "tabCria"
        Me.tabCria.SelectedIndex = 0
        Me.tabCria.Size = New System.Drawing.Size(682, 326)
        Me.tabCria.TabIndex = 0
        '
        'tabViagem
        '
        Me.tabViagem.Controls.Add(Me.Sair)
        Me.tabViagem.Controls.Add(Me.ctlRef)
        Me.tabViagem.Controls.Add(Me.btnSalvarViagem)
        Me.tabViagem.Controls.Add(Me.cbxTransp)
        Me.tabViagem.Controls.Add(Me.ctlDataFch)
        Me.tabViagem.Controls.Add(Me.ctlObs)
        Me.tabViagem.Controls.Add(Me.lblObs)
        Me.tabViagem.Controls.Add(Me.lblDataFech)
        Me.tabViagem.Controls.Add(Me.lblCarreta)
        Me.tabViagem.Controls.Add(Me.lblRef)
        Me.tabViagem.Location = New System.Drawing.Point(4, 22)
        Me.tabViagem.Name = "tabViagem"
        Me.tabViagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViagem.Size = New System.Drawing.Size(674, 300)
        Me.tabViagem.TabIndex = 0
        Me.tabViagem.Text = "Viagem"
        Me.tabViagem.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Location = New System.Drawing.Point(597, 271)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(75, 23)
        Me.Sair.TabIndex = 19
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = True
        '
        'ctlRef
        '
        Me.ctlRef.Location = New System.Drawing.Point(179, 13)
        Me.ctlRef.Name = "ctlRef"
        Me.ctlRef.Size = New System.Drawing.Size(169, 20)
        Me.ctlRef.TabIndex = 18
        Me.ctlRef.Tag = "FORMATO:REF"
        '
        'btnSalvarViagem
        '
        Me.btnSalvarViagem.Location = New System.Drawing.Point(516, 271)
        Me.btnSalvarViagem.Name = "btnSalvarViagem"
        Me.btnSalvarViagem.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarViagem.TabIndex = 17
        Me.btnSalvarViagem.Text = "Salvar"
        Me.btnSalvarViagem.UseVisualStyleBackColor = True
        '
        'cbxTransp
        '
        Me.cbxTransp.FormattingEnabled = True
        Me.cbxTransp.Location = New System.Drawing.Point(179, 45)
        Me.cbxTransp.Name = "cbxTransp"
        Me.cbxTransp.Size = New System.Drawing.Size(169, 21)
        Me.cbxTransp.TabIndex = 6
        '
        'ctlDataFch
        '
        Me.ctlDataFch.Location = New System.Drawing.Point(179, 79)
        Me.ctlDataFch.Name = "ctlDataFch"
        Me.ctlDataFch.Size = New System.Drawing.Size(169, 20)
        Me.ctlDataFch.TabIndex = 5
        Me.ctlDataFch.Tag = "tipo:DATE"
        '
        'ctlObs
        '
        Me.ctlObs.Location = New System.Drawing.Point(179, 114)
        Me.ctlObs.Name = "ctlObs"
        Me.ctlObs.Size = New System.Drawing.Size(493, 20)
        Me.ctlObs.TabIndex = 4
        Me.ctlObs.Tag = "FORMATO:MEMO"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(6, 117)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(70, 13)
        Me.lblObs.TabIndex = 3
        Me.lblObs.Text = "Observações"
        '
        'lblDataFech
        '
        Me.lblDataFech.AutoSize = True
        Me.lblDataFech.Location = New System.Drawing.Point(6, 82)
        Me.lblDataFech.Name = "lblDataFech"
        Me.lblDataFech.Size = New System.Drawing.Size(160, 13)
        Me.lblDataFech.TabIndex = 2
        Me.lblDataFech.Text = "Data do Fechamento da Viagem"
        '
        'lblCarreta
        '
        Me.lblCarreta.AutoSize = True
        Me.lblCarreta.Location = New System.Drawing.Point(6, 48)
        Me.lblCarreta.Name = "lblCarreta"
        Me.lblCarreta.Size = New System.Drawing.Size(167, 13)
        Me.lblCarreta.TabIndex = 1
        Me.lblCarreta.Text = "Navio ou Transportadora/Veículo"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(6, 16)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(112, 13)
        Me.lblRef.TabIndex = 0
        Me.lblRef.Text = "Referência da Viagem"
        '
        'tabEscala
        '
        Me.tabEscala.Controls.Add(Me.btnSair)
        Me.tabEscala.Controls.Add(Me.ctlViagemRef)
        Me.tabEscala.Controls.Add(Me.btnSalvarEscala)
        Me.tabEscala.Controls.Add(Me.ctlETS)
        Me.tabEscala.Controls.Add(Me.Label6)
        Me.tabEscala.Controls.Add(Me.ctlEscala)
        Me.tabEscala.Controls.Add(Me.Label5)
        Me.tabEscala.Controls.Add(Me.cbxLocal)
        Me.tabEscala.Controls.Add(Me.ctlETA)
        Me.tabEscala.Controls.Add(Me.Label2)
        Me.tabEscala.Controls.Add(Me.Label3)
        Me.tabEscala.Controls.Add(Me.Label4)
        Me.tabEscala.Location = New System.Drawing.Point(4, 22)
        Me.tabEscala.Name = "tabEscala"
        Me.tabEscala.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEscala.Size = New System.Drawing.Size(674, 300)
        Me.tabEscala.TabIndex = 1
        Me.tabEscala.Text = "Escala"
        Me.tabEscala.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(596, 271)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 20
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'ctlViagemRef
        '
        Me.ctlViagemRef.Location = New System.Drawing.Point(179, 13)
        Me.ctlViagemRef.Name = "ctlViagemRef"
        Me.ctlViagemRef.Size = New System.Drawing.Size(169, 20)
        Me.ctlViagemRef.TabIndex = 19
        Me.ctlViagemRef.Tag = "FORMATO:REF"
        '
        'btnSalvarEscala
        '
        Me.btnSalvarEscala.Location = New System.Drawing.Point(515, 271)
        Me.btnSalvarEscala.Name = "btnSalvarEscala"
        Me.btnSalvarEscala.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarEscala.TabIndex = 18
        Me.btnSalvarEscala.Text = "Salvar"
        Me.btnSalvarEscala.UseVisualStyleBackColor = True
        '
        'ctlETS
        '
        Me.ctlETS.Location = New System.Drawing.Point(179, 153)
        Me.ctlETS.Name = "ctlETS"
        Me.ctlETS.Size = New System.Drawing.Size(169, 20)
        Me.ctlETS.TabIndex = 17
        Me.ctlETS.Tag = "tipo:DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Previsão de Saída"
        '
        'ctlEscala
        '
        Me.ctlEscala.Location = New System.Drawing.Point(179, 48)
        Me.ctlEscala.Name = "ctlEscala"
        Me.ctlEscala.Size = New System.Drawing.Size(169, 20)
        Me.ctlEscala.TabIndex = 15
        Me.ctlEscala.Tag = "AUTO:PROXSEQ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Escala"
        '
        'cbxLocal
        '
        Me.cbxLocal.FormattingEnabled = True
        Me.cbxLocal.Location = New System.Drawing.Point(179, 83)
        Me.cbxLocal.Name = "cbxLocal"
        Me.cbxLocal.Size = New System.Drawing.Size(169, 21)
        Me.cbxLocal.TabIndex = 12
        '
        'ctlETA
        '
        Me.ctlETA.Location = New System.Drawing.Point(179, 117)
        Me.ctlETA.Name = "ctlETA"
        Me.ctlETA.Size = New System.Drawing.Size(169, 20)
        Me.ctlETA.TabIndex = 11
        Me.ctlETA.Tag = "tipo:DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Previsão de Chegada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Local"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Referência da Viagem"
        '
        'grdPend
        '
        Me.grdPend.AutoBind = False
        Me.grdPend.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdPend.BindContainer = Nothing
        Me.grdPend.Campos = Nothing
        Me.grdPend.CamposExtend = Nothing
        Me.grdPend.CamposFixos = ""
        Me.grdPend.Chave = Nothing
        Me.grdPend.ColunaNomes = ""
        Me.grdPend.Defs = Nothing
        Me.grdPend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPend.EsquemaGerador = "IM"
        Me.grdPend.EsquemaPrinc = "IM"
        Me.grdPend.Filtro = Nothing
        Me.grdPend.IncluiCamposSys = False
        Me.grdPend.Info = "Informações..."
        Me.grdPend.Location = New System.Drawing.Point(3, 68)
        Me.grdPend.MostraNumReg = False
        Me.grdPend.Name = "grdPend"
        Me.grdPend.Ocultar = Nothing
        Me.grdPend.Params = CType(resources.GetObject("grdPend.Params"), System.Collections.ArrayList)
        Me.grdPend.Sistema = "IM"
        Me.grdPend.Size = New System.Drawing.Size(869, 323)
        Me.grdPend.SomenteLeitura = False
        Me.grdPend.SQL = ""
        Me.grdPend.StrConn = Nothing
        Me.grdPend.Tabela = ""
        Me.grdPend.TabIndex = 12
        Me.grdPend.Tag = ""
        Me.grdPend.Totaliza = ""
        Me.grdPend.Usuario = ""
        Me.grdPend.ValorPadrao = CType(resources.GetObject("grdPend.ValorPadrao"), System.Collections.ArrayList)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnEmbarcar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(872, 68)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(75, 323)
        Me.Panel6.TabIndex = 15
        '
        'btnEmbarcar
        '
        Me.btnEmbarcar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmbarcar.Location = New System.Drawing.Point(0, 0)
        Me.btnEmbarcar.Name = "btnEmbarcar"
        Me.btnEmbarcar.Size = New System.Drawing.Size(75, 43)
        Me.btnEmbarcar.TabIndex = 18
        Me.btnEmbarcar.Text = "Criar Embarque"
        Me.btnEmbarcar.UseVisualStyleBackColor = True
        '
        'pnlPendentes
        '
        Me.pnlPendentes.Controls.Add(Me.Panel4)
        Me.pnlPendentes.Controls.Add(Me.Panel5)
        Me.pnlPendentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPendentes.Location = New System.Drawing.Point(3, 3)
        Me.pnlPendentes.MaximumSize = New System.Drawing.Size(944, 65)
        Me.pnlPendentes.MinimumSize = New System.Drawing.Size(944, 65)
        Me.pnlPendentes.Name = "pnlPendentes"
        Me.pnlPendentes.Size = New System.Drawing.Size(944, 65)
        Me.pnlPendentes.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(599, 65)
        Me.Panel4.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtBuscaPend)
        Me.Panel5.Controls.Add(Me.btnBuscaPend)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(599, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(345, 65)
        Me.Panel5.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Busca Rápida"
        '
        'txtBuscaPend
        '
        Me.txtBuscaPend.Location = New System.Drawing.Point(98, 10)
        Me.txtBuscaPend.Name = "txtBuscaPend"
        Me.txtBuscaPend.Size = New System.Drawing.Size(166, 20)
        Me.txtBuscaPend.TabIndex = 15
        '
        'btnBuscaPend
        '
        Me.btnBuscaPend.Location = New System.Drawing.Point(270, 7)
        Me.btnBuscaPend.Name = "btnBuscaPend"
        Me.btnBuscaPend.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaPend.TabIndex = 16
        Me.btnBuscaPend.Text = "Buscar"
        Me.btnBuscaPend.UseVisualStyleBackColor = True
        '
        'TabParciais
        '
        Me.TabParciais.Controls.Add(Me.GroupBox2)
        Me.TabParciais.Controls.Add(Me.Splitter1)
        Me.TabParciais.Controls.Add(Me.GroupBox1)
        Me.TabParciais.Controls.Add(Me.Panel1)
        Me.TabParciais.Controls.Add(Me.pnlPaciais)
        Me.TabParciais.Location = New System.Drawing.Point(4, 22)
        Me.TabParciais.Name = "TabParciais"
        Me.TabParciais.Padding = New System.Windows.Forms.Padding(3)
        Me.TabParciais.Size = New System.Drawing.Size(950, 394)
        Me.TabParciais.TabIndex = 1
        Me.TabParciais.Text = "Embarques a serem finalizados"
        Me.TabParciais.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdViagens)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 110)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Embarques"
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
        Me.grdViagens.Size = New System.Drawing.Size(863, 91)
        Me.grdViagens.SomenteLeitura = False
        Me.grdViagens.SQL = ""
        Me.grdViagens.StrConn = Nothing
        Me.grdViagens.Tabela = ""
        Me.grdViagens.TabIndex = 14
        Me.grdViagens.Tag = ""
        Me.grdViagens.Totaliza = ""
        Me.grdViagens.Usuario = ""
        Me.grdViagens.ValorPadrao = CType(resources.GetObject("grdViagens.ValorPadrao"), System.Collections.ArrayList)
        '
        'Splitter1
        '
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(3, 269)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(869, 12)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdItensParc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 201)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordens de Venda / Itens"
        '
        'grdItensParc
        '
        Me.grdItensParc.AutoBind = False
        Me.grdItensParc.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdItensParc.BindContainer = Nothing
        Me.grdItensParc.Campos = Nothing
        Me.grdItensParc.CamposExtend = Nothing
        Me.grdItensParc.CamposFixos = ""
        Me.grdItensParc.Chave = Nothing
        Me.grdItensParc.ColunaNomes = ""
        Me.grdItensParc.Defs = Nothing
        Me.grdItensParc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdItensParc.EsquemaGerador = "IM"
        Me.grdItensParc.EsquemaPrinc = "IM"
        Me.grdItensParc.Filtro = Nothing
        Me.grdItensParc.IncluiCamposSys = False
        Me.grdItensParc.Info = "Informações..."
        Me.grdItensParc.Location = New System.Drawing.Point(3, 16)
        Me.grdItensParc.MostraNumReg = False
        Me.grdItensParc.Name = "grdItensParc"
        Me.grdItensParc.Ocultar = Nothing
        Me.grdItensParc.Params = CType(resources.GetObject("grdItensParc.Params"), System.Collections.ArrayList)
        Me.grdItensParc.Sistema = "IM"
        Me.grdItensParc.Size = New System.Drawing.Size(863, 182)
        Me.grdItensParc.SomenteLeitura = False
        Me.grdItensParc.SQL = ""
        Me.grdItensParc.StrConn = Nothing
        Me.grdItensParc.Tabela = ""
        Me.grdItensParc.TabIndex = 14
        Me.grdItensParc.Tag = ""
        Me.grdItensParc.Totaliza = ""
        Me.grdItensParc.Usuario = ""
        Me.grdItensParc.ValorPadrao = CType(resources.GetObject("grdItensParc.ValorPadrao"), System.Collections.ArrayList)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnConfirma)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(872, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 323)
        Me.Panel1.TabIndex = 16
        '
        'btnConfirma
        '
        Me.btnConfirma.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfirma.Location = New System.Drawing.Point(0, 0)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(75, 43)
        Me.btnConfirma.TabIndex = 18
        Me.btnConfirma.Text = "Finalizar Embarque"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'pnlPaciais
        '
        Me.pnlPaciais.Controls.Add(Me.Panel3)
        Me.pnlPaciais.Controls.Add(Me.Panel2)
        Me.pnlPaciais.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPaciais.Location = New System.Drawing.Point(3, 3)
        Me.pnlPaciais.MaximumSize = New System.Drawing.Size(944, 65)
        Me.pnlPaciais.MinimumSize = New System.Drawing.Size(944, 65)
        Me.pnlPaciais.Name = "pnlPaciais"
        Me.pnlPaciais.Size = New System.Drawing.Size(944, 65)
        Me.pnlPaciais.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 65)
        Me.Panel3.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblBusca)
        Me.Panel2.Controls.Add(Me.txtBuscaParc)
        Me.Panel2.Controls.Add(Me.btnBuscaParc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(599, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 65)
        Me.Panel2.TabIndex = 20
        '
        'lblBusca
        '
        Me.lblBusca.AutoSize = True
        Me.lblBusca.Location = New System.Drawing.Point(18, 16)
        Me.lblBusca.Name = "lblBusca"
        Me.lblBusca.Size = New System.Drawing.Size(74, 13)
        Me.lblBusca.TabIndex = 18
        Me.lblBusca.Text = "Busca Rápida"
        '
        'txtBuscaParc
        '
        Me.txtBuscaParc.Location = New System.Drawing.Point(98, 9)
        Me.txtBuscaParc.Name = "txtBuscaParc"
        Me.txtBuscaParc.Size = New System.Drawing.Size(166, 20)
        Me.txtBuscaParc.TabIndex = 15
        '
        'btnBuscaParc
        '
        Me.btnBuscaParc.Location = New System.Drawing.Point(270, 6)
        Me.btnBuscaParc.Name = "btnBuscaParc"
        Me.btnBuscaParc.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaParc.TabIndex = 16
        Me.btnBuscaParc.Text = "Buscar"
        Me.btnBuscaParc.UseVisualStyleBackColor = True
        '
        'frmPendencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 420)
        Me.Controls.Add(Me.tab)
        Me.Name = "frmPendencias"
        Me.Text = "Itens para Embarcar"
        Me.tab.ResumeLayout(False)
        Me.tabPendente.ResumeLayout(False)
        Me.pnlCriação.ResumeLayout(False)
        Me.tabCria.ResumeLayout(False)
        Me.tabViagem.ResumeLayout(False)
        Me.tabViagem.PerformLayout()
        Me.tabEscala.ResumeLayout(False)
        Me.tabEscala.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.pnlPendentes.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabParciais.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlPaciais.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents tabPendente As System.Windows.Forms.TabPage
    Friend WithEvents TabParciais As System.Windows.Forms.TabPage
    Friend WithEvents pnlPendentes As System.Windows.Forms.Panel
    Friend WithEvents pnlPaciais As System.Windows.Forms.Panel
    Friend WithEvents grdPend As Icraft.IcftFGrid2
    Friend WithEvents txtBuscaParc As System.Windows.Forms.TextBox
    Friend WithEvents lblBusca As System.Windows.Forms.Label
    Friend WithEvents btnBuscaParc As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnEmbarcar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscaPend As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaPend As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdViagens As Icraft.IcftFGrid2
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdItensParc As Icraft.IcftFGrid2
    Friend WithEvents pnlCriação As System.Windows.Forms.Panel
    Friend WithEvents tabCria As System.Windows.Forms.TabControl
    Friend WithEvents tabViagem As System.Windows.Forms.TabPage
    Friend WithEvents tabEscala As System.Windows.Forms.TabPage
    Friend WithEvents lblCarreta As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents cbxTransp As System.Windows.Forms.ComboBox
    Friend WithEvents ctlDataFch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ctlObs As System.Windows.Forms.TextBox
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents lblDataFech As System.Windows.Forms.Label
    Friend WithEvents btnSalvarViagem As System.Windows.Forms.Button
    Friend WithEvents cbxLocal As System.Windows.Forms.ComboBox
    Friend WithEvents ctlETA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalvarEscala As System.Windows.Forms.Button
    Friend WithEvents ctlETS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ctlEscala As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctlRef As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ctlViagemRef As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
