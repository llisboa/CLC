<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisas
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
        Me.Topo = New System.Windows.Forms.Panel
        Me.G10 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.TXT10NFS = New System.Windows.Forms.MaskedTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTCONSULTA = New System.Windows.Forms.ComboBox
        Me.G02 = New System.Windows.Forms.Panel
        Me.TXT02OPER = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT02FIM = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT02INI = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.G01 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT01VIAGEM = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT01PEDIDO = New System.Windows.Forms.ComboBox
        Me.G06 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.TXT06QTDREG = New System.Windows.Forms.TextBox
        Me.CHK06NUMDIF = New System.Windows.Forms.CheckBox
        Me.G05 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.TXT05QTDREG = New System.Windows.Forms.TextBox
        Me.CHK05NUMDIF = New System.Windows.Forms.CheckBox
        Me.G08 = New System.Windows.Forms.Panel
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.TXT08QTDREG = New System.Windows.Forms.TextBox
        Me.G04 = New System.Windows.Forms.Panel
        Me.BTN04ANO = New System.Windows.Forms.Button
        Me.BTN04SEME = New System.Windows.Forms.Button
        Me.BTN04TRI = New System.Windows.Forms.Button
        Me.BTN04MES = New System.Windows.Forms.Button
        Me.BTN04SEM = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TXT04FIM = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXT04INI = New System.Windows.Forms.MaskedTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.G03 = New System.Windows.Forms.Panel
        Me.TXT03OPER = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXT03FIM = New System.Windows.Forms.MaskedTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT03INI = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CWEB = New Icraft.IcftFWebBrow
        Me.Topo.SuspendLayout()
        Me.G10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.G02.SuspendLayout()
        Me.G01.SuspendLayout()
        Me.G06.SuspendLayout()
        Me.G05.SuspendLayout()
        Me.G08.SuspendLayout()
        Me.G04.SuspendLayout()
        Me.G03.SuspendLayout()
        Me.SuspendLayout()
        '
        'Topo
        '
        Me.Topo.Controls.Add(Me.G10)
        Me.Topo.Controls.Add(Me.Panel2)
        Me.Topo.Controls.Add(Me.Label1)
        Me.Topo.Controls.Add(Me.TXTCONSULTA)
        Me.Topo.Controls.Add(Me.G02)
        Me.Topo.Controls.Add(Me.G01)
        Me.Topo.Controls.Add(Me.G06)
        Me.Topo.Controls.Add(Me.G05)
        Me.Topo.Controls.Add(Me.G08)
        Me.Topo.Controls.Add(Me.G04)
        Me.Topo.Controls.Add(Me.G03)
        Me.Topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Topo.Location = New System.Drawing.Point(0, 0)
        Me.Topo.Name = "Topo"
        Me.Topo.Size = New System.Drawing.Size(631, 98)
        Me.Topo.TabIndex = 1
        '
        'G10
        '
        Me.G10.Controls.Add(Me.Label23)
        Me.G10.Controls.Add(Me.TXT10NFS)
        Me.G10.Controls.Add(Me.Label24)
        Me.G10.Location = New System.Drawing.Point(12, 40)
        Me.G10.Name = "G10"
        Me.G10.Size = New System.Drawing.Size(607, 51)
        Me.G10.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(292, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(221, 13)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "(informe só o num das NFs separadas por "";"")"
        '
        'TXT10NFS
        '
        Me.TXT10NFS.Location = New System.Drawing.Point(25, 2)
        Me.TXT10NFS.Name = "TXT10NFS"
        Me.TXT10NFS.Size = New System.Drawing.Size(260, 20)
        Me.TXT10NFS.TabIndex = 19
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(0, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "NFs"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(543, 7)
        Me.Panel2.MaximumSize = New System.Drawing.Size(50, 30)
        Me.Panel2.MinimumSize = New System.Drawing.Size(80, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(80, 30)
        Me.Panel2.TabIndex = 5
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 0)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(80, 30)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Consulta"
        '
        'TXTCONSULTA
        '
        Me.TXTCONSULTA.FormattingEnabled = True
        Me.TXTCONSULTA.Items.AddRange(New Object() {"1=Conferência de Itens Carregados e Total de Etiquetas", "2=Ordens de Venda no Período", "3=Total das Ordens no Período", "4=Ranking de Produtos/Especificações", "5=Conferência Ordem de Venda CLC x CIEX", "6=Conferência Pedido+Item CLC x CIEX", "7=Itens de OV no CLC e não encontrados no CIEX (sem BHOC)", "8=Itens de OV no CIEX e não encontrados no CLC (sem BHOC)", "9=Itens duplicados no CIEX (sem BHOC)", "10=Resumo de NFs", "11=Itens de pedido que existem no CIEX e não existem no CLC", "12=Itens de pedido que existem no CLC e não existem no CIEX", "13=Total de Etiquetas cadastradas por Usuários", "14=Total de Itens de Ordens Cadastrados por Usuários", "15=Total de Itens de Pedidos Cadastrados por Usuários"})
        Me.TXTCONSULTA.Location = New System.Drawing.Point(66, 10)
        Me.TXTCONSULTA.Name = "TXTCONSULTA"
        Me.TXTCONSULTA.Size = New System.Drawing.Size(348, 21)
        Me.TXTCONSULTA.TabIndex = 6
        '
        'G02
        '
        Me.G02.Controls.Add(Me.TXT02OPER)
        Me.G02.Controls.Add(Me.Label18)
        Me.G02.Controls.Add(Me.Label9)
        Me.G02.Controls.Add(Me.Label4)
        Me.G02.Controls.Add(Me.TXT02FIM)
        Me.G02.Controls.Add(Me.Label8)
        Me.G02.Controls.Add(Me.TXT02INI)
        Me.G02.Controls.Add(Me.Label7)
        Me.G02.Location = New System.Drawing.Point(12, 40)
        Me.G02.Name = "G02"
        Me.G02.Size = New System.Drawing.Size(607, 51)
        Me.G02.TabIndex = 13
        '
        'TXT02OPER
        '
        Me.TXT02OPER.FormattingEnabled = True
        Me.TXT02OPER.Location = New System.Drawing.Point(291, 2)
        Me.TXT02OPER.Name = "TXT02OPER"
        Me.TXT02OPER.Size = New System.Drawing.Size(190, 21)
        Me.TXT02OPER.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(235, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Operador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "dd/mm/yyyy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "dd/mm/yyyy"
        '
        'TXT02FIM
        '
        Me.TXT02FIM.Location = New System.Drawing.Point(133, 2)
        Me.TXT02FIM.Name = "TXT02FIM"
        Me.TXT02FIM.Size = New System.Drawing.Size(74, 20)
        Me.TXT02FIM.TabIndex = 21
        Me.TXT02FIM.Tag = "Tipo:DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "até"
        '
        'TXT02INI
        '
        Me.TXT02INI.Location = New System.Drawing.Point(25, 2)
        Me.TXT02INI.Name = "TXT02INI"
        Me.TXT02INI.Size = New System.Drawing.Size(74, 20)
        Me.TXT02INI.TabIndex = 19
        Me.TXT02INI.Tag = "Tipo:DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "De"
        '
        'G01
        '
        Me.G01.Controls.Add(Me.Label3)
        Me.G01.Controls.Add(Me.TXT01VIAGEM)
        Me.G01.Controls.Add(Me.Label2)
        Me.G01.Controls.Add(Me.TXT01PEDIDO)
        Me.G01.Location = New System.Drawing.Point(12, 40)
        Me.G01.Name = "G01"
        Me.G01.Size = New System.Drawing.Size(607, 51)
        Me.G01.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Viagem"
        '
        'TXT01VIAGEM
        '
        Me.TXT01VIAGEM.FormattingEnabled = True
        Me.TXT01VIAGEM.Location = New System.Drawing.Point(310, 3)
        Me.TXT01VIAGEM.Name = "TXT01VIAGEM"
        Me.TXT01VIAGEM.Size = New System.Drawing.Size(236, 21)
        Me.TXT01VIAGEM.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Pedido"
        '
        'TXT01PEDIDO
        '
        Me.TXT01PEDIDO.FormattingEnabled = True
        Me.TXT01PEDIDO.Location = New System.Drawing.Point(54, 3)
        Me.TXT01PEDIDO.Name = "TXT01PEDIDO"
        Me.TXT01PEDIDO.Size = New System.Drawing.Size(174, 21)
        Me.TXT01PEDIDO.TabIndex = 9
        '
        'G06
        '
        Me.G06.Controls.Add(Me.Label17)
        Me.G06.Controls.Add(Me.TXT06QTDREG)
        Me.G06.Controls.Add(Me.CHK06NUMDIF)
        Me.G06.Location = New System.Drawing.Point(12, 40)
        Me.G06.Name = "G06"
        Me.G06.Size = New System.Drawing.Size(607, 51)
        Me.G06.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(237, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Qtd Regs Apres"
        '
        'TXT06QTDREG
        '
        Me.TXT06QTDREG.Location = New System.Drawing.Point(322, 3)
        Me.TXT06QTDREG.Name = "TXT06QTDREG"
        Me.TXT06QTDREG.Size = New System.Drawing.Size(55, 20)
        Me.TXT06QTDREG.TabIndex = 5
        Me.TXT06QTDREG.Text = "5"
        '
        'CHK06NUMDIF
        '
        Me.CHK06NUMDIF.AutoSize = True
        Me.CHK06NUMDIF.Checked = True
        Me.CHK06NUMDIF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK06NUMDIF.Location = New System.Drawing.Point(3, 5)
        Me.CHK06NUMDIF.Name = "CHK06NUMDIF"
        Me.CHK06NUMDIF.Size = New System.Drawing.Size(223, 17)
        Me.CHK06NUMDIF.TabIndex = 0
        Me.CHK06NUMDIF.Text = "Somente números diferentes (qtd e preço)"
        Me.CHK06NUMDIF.UseVisualStyleBackColor = True
        '
        'G05
        '
        Me.G05.Controls.Add(Me.Label16)
        Me.G05.Controls.Add(Me.TXT05QTDREG)
        Me.G05.Controls.Add(Me.CHK05NUMDIF)
        Me.G05.Location = New System.Drawing.Point(12, 40)
        Me.G05.Name = "G05"
        Me.G05.Size = New System.Drawing.Size(607, 51)
        Me.G05.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(237, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Qtd Regs Apres"
        '
        'TXT05QTDREG
        '
        Me.TXT05QTDREG.Location = New System.Drawing.Point(322, 4)
        Me.TXT05QTDREG.Name = "TXT05QTDREG"
        Me.TXT05QTDREG.Size = New System.Drawing.Size(55, 20)
        Me.TXT05QTDREG.TabIndex = 3
        Me.TXT05QTDREG.Text = "5"
        '
        'CHK05NUMDIF
        '
        Me.CHK05NUMDIF.AutoSize = True
        Me.CHK05NUMDIF.Checked = True
        Me.CHK05NUMDIF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK05NUMDIF.Location = New System.Drawing.Point(3, 5)
        Me.CHK05NUMDIF.Name = "CHK05NUMDIF"
        Me.CHK05NUMDIF.Size = New System.Drawing.Size(223, 17)
        Me.CHK05NUMDIF.TabIndex = 0
        Me.CHK05NUMDIF.Text = "Somente números diferentes (qtd e preço)"
        Me.CHK05NUMDIF.UseVisualStyleBackColor = True
        '
        'G08
        '
        Me.G08.Controls.Add(Me.Label30)
        Me.G08.Controls.Add(Me.Label31)
        Me.G08.Controls.Add(Me.TXT08QTDREG)
        Me.G08.Location = New System.Drawing.Point(12, 40)
        Me.G08.Name = "G08"
        Me.G08.Size = New System.Drawing.Size(607, 51)
        Me.G08.TabIndex = 26
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(237, 8)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 13)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Qtd Regs Apres"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 5)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Total de Registros: "
        '
        'TXT08QTDREG
        '
        Me.TXT08QTDREG.Location = New System.Drawing.Point(322, 4)
        Me.TXT08QTDREG.Name = "TXT08QTDREG"
        Me.TXT08QTDREG.Size = New System.Drawing.Size(55, 20)
        Me.TXT08QTDREG.TabIndex = 3
        Me.TXT08QTDREG.Text = "8"
        '
        'G04
        '
        Me.G04.Controls.Add(Me.BTN04ANO)
        Me.G04.Controls.Add(Me.BTN04SEME)
        Me.G04.Controls.Add(Me.BTN04TRI)
        Me.G04.Controls.Add(Me.BTN04MES)
        Me.G04.Controls.Add(Me.BTN04SEM)
        Me.G04.Controls.Add(Me.Label12)
        Me.G04.Controls.Add(Me.Label13)
        Me.G04.Controls.Add(Me.TXT04FIM)
        Me.G04.Controls.Add(Me.Label14)
        Me.G04.Controls.Add(Me.TXT04INI)
        Me.G04.Controls.Add(Me.Label15)
        Me.G04.Location = New System.Drawing.Point(12, 40)
        Me.G04.Name = "G04"
        Me.G04.Size = New System.Drawing.Size(607, 51)
        Me.G04.TabIndex = 24
        '
        'BTN04ANO
        '
        Me.BTN04ANO.Location = New System.Drawing.Point(538, 15)
        Me.BTN04ANO.Name = "BTN04ANO"
        Me.BTN04ANO.Size = New System.Drawing.Size(40, 20)
        Me.BTN04ANO.TabIndex = 23
        Me.BTN04ANO.Text = "Ano"
        Me.BTN04ANO.UseVisualStyleBackColor = True
        '
        'BTN04SEME
        '
        Me.BTN04SEME.Location = New System.Drawing.Point(468, 15)
        Me.BTN04SEME.Name = "BTN04SEME"
        Me.BTN04SEME.Size = New System.Drawing.Size(67, 20)
        Me.BTN04SEME.TabIndex = 23
        Me.BTN04SEME.Text = "Semestre"
        Me.BTN04SEME.UseVisualStyleBackColor = True
        '
        'BTN04TRI
        '
        Me.BTN04TRI.Location = New System.Drawing.Point(399, 15)
        Me.BTN04TRI.Name = "BTN04TRI"
        Me.BTN04TRI.Size = New System.Drawing.Size(66, 20)
        Me.BTN04TRI.TabIndex = 23
        Me.BTN04TRI.Text = "Trimestre"
        Me.BTN04TRI.UseVisualStyleBackColor = True
        '
        'BTN04MES
        '
        Me.BTN04MES.Location = New System.Drawing.Point(342, 15)
        Me.BTN04MES.Name = "BTN04MES"
        Me.BTN04MES.Size = New System.Drawing.Size(54, 20)
        Me.BTN04MES.TabIndex = 23
        Me.BTN04MES.Text = "Mês"
        Me.BTN04MES.UseVisualStyleBackColor = True
        '
        'BTN04SEM
        '
        Me.BTN04SEM.Location = New System.Drawing.Point(285, 15)
        Me.BTN04SEM.Name = "BTN04SEM"
        Me.BTN04SEM.Size = New System.Drawing.Size(54, 20)
        Me.BTN04SEM.TabIndex = 23
        Me.BTN04SEM.Text = "Semana"
        Me.BTN04SEM.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(136, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "dd/mm/yyyy"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "dd/mm/yyyy"
        '
        'TXT04FIM
        '
        Me.TXT04FIM.Location = New System.Drawing.Point(133, 2)
        Me.TXT04FIM.Name = "TXT04FIM"
        Me.TXT04FIM.Size = New System.Drawing.Size(74, 20)
        Me.TXT04FIM.TabIndex = 21
        Me.TXT04FIM.Tag = "Tipo:DATE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(104, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "até"
        '
        'TXT04INI
        '
        Me.TXT04INI.Location = New System.Drawing.Point(25, 2)
        Me.TXT04INI.Name = "TXT04INI"
        Me.TXT04INI.Size = New System.Drawing.Size(74, 20)
        Me.TXT04INI.TabIndex = 19
        Me.TXT04INI.Tag = "Tipo:DATE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(0, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "De"
        '
        'G03
        '
        Me.G03.Controls.Add(Me.TXT03OPER)
        Me.G03.Controls.Add(Me.Label19)
        Me.G03.Controls.Add(Me.Label5)
        Me.G03.Controls.Add(Me.Label6)
        Me.G03.Controls.Add(Me.TXT03FIM)
        Me.G03.Controls.Add(Me.Label10)
        Me.G03.Controls.Add(Me.TXT03INI)
        Me.G03.Controls.Add(Me.Label11)
        Me.G03.Location = New System.Drawing.Point(12, 40)
        Me.G03.Name = "G03"
        Me.G03.Size = New System.Drawing.Size(607, 51)
        Me.G03.TabIndex = 23
        '
        'TXT03OPER
        '
        Me.TXT03OPER.FormattingEnabled = True
        Me.TXT03OPER.Location = New System.Drawing.Point(291, 2)
        Me.TXT03OPER.Name = "TXT03OPER"
        Me.TXT03OPER.Size = New System.Drawing.Size(190, 21)
        Me.TXT03OPER.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(235, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Operador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "dd/mm/yyyy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "dd/mm/yyyy"
        '
        'TXT03FIM
        '
        Me.TXT03FIM.Location = New System.Drawing.Point(133, 2)
        Me.TXT03FIM.Name = "TXT03FIM"
        Me.TXT03FIM.Size = New System.Drawing.Size(74, 20)
        Me.TXT03FIM.TabIndex = 21
        Me.TXT03FIM.Tag = "Tipo:DATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(104, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "até"
        '
        'TXT03INI
        '
        Me.TXT03INI.Location = New System.Drawing.Point(25, 2)
        Me.TXT03INI.Name = "TXT03INI"
        Me.TXT03INI.Size = New System.Drawing.Size(74, 20)
        Me.TXT03INI.TabIndex = 19
        Me.TXT03INI.Tag = "Tipo:DATE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "De"
        '
        'CWEB
        '
        Me.CWEB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CWEB.Location = New System.Drawing.Point(0, 98)
        Me.CWEB.Name = "CWEB"
        Me.CWEB.Size = New System.Drawing.Size(631, 175)
        Me.CWEB.SQL = Nothing
        Me.CWEB.StrConn = Nothing
        Me.CWEB.TabIndex = 2
        '
        'frmPesquisas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 273)
        Me.Controls.Add(Me.CWEB)
        Me.Controls.Add(Me.Topo)
        Me.Name = "frmPesquisas"
        Me.Text = "Pesquisas Customizadas"
        Me.Topo.ResumeLayout(False)
        Me.Topo.PerformLayout()
        Me.G10.ResumeLayout(False)
        Me.G10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.G02.ResumeLayout(False)
        Me.G02.PerformLayout()
        Me.G01.ResumeLayout(False)
        Me.G01.PerformLayout()
        Me.G06.ResumeLayout(False)
        Me.G06.PerformLayout()
        Me.G05.ResumeLayout(False)
        Me.G05.PerformLayout()
        Me.G08.ResumeLayout(False)
        Me.G08.PerformLayout()
        Me.G04.ResumeLayout(False)
        Me.G04.PerformLayout()
        Me.G03.ResumeLayout(False)
        Me.G03.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Topo As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTCONSULTA As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents G01 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT01VIAGEM As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT01PEDIDO As System.Windows.Forms.ComboBox
    Friend WithEvents CWEB As Icraft.IcftFWebBrow
    Friend WithEvents G02 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT02INI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT02FIM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents G03 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT03FIM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT03INI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents G04 As System.Windows.Forms.Panel
    Friend WithEvents BTN04ANO As System.Windows.Forms.Button
    Friend WithEvents BTN04SEME As System.Windows.Forms.Button
    Friend WithEvents BTN04TRI As System.Windows.Forms.Button
    Friend WithEvents BTN04MES As System.Windows.Forms.Button
    Friend WithEvents BTN04SEM As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXT04FIM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXT04INI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents G05 As System.Windows.Forms.Panel
    Friend WithEvents G08 As System.Windows.Forms.Panel
    Friend WithEvents CHK05NUMDIF As System.Windows.Forms.CheckBox
    Friend WithEvents G06 As System.Windows.Forms.Panel
    Friend WithEvents CHK06NUMDIF As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TXT05QTDREG As System.Windows.Forms.TextBox
    Friend WithEvents TXT08QTDREG As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXT06QTDREG As System.Windows.Forms.TextBox
    Friend WithEvents TXT02OPER As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TXT03OPER As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents G10 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TXT10NFS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
