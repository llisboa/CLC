<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoqueEstat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoqueEstat))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBusca = New System.Windows.Forms.TextBox
        Me.TXTCONSULTA = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.pnlCima = New System.Windows.Forms.Panel
        Me.grpDimensoes = New System.Windows.Forms.GroupBox
        Me.grpSub = New System.Windows.Forms.GroupBox
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.pnlBaixo = New System.Windows.Forms.Panel
        Me.pnlBotoes = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.grdEtiq = New Icraft.IcftFGrid2
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.Panel1.SuspendLayout()
        Me.pnlCima.SuspendLayout()
        Me.grpDimensoes.SuspendLayout()
        Me.grpSub.SuspendLayout()
        Me.pnlBaixo.SuspendLayout()
        Me.pnlBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBusca)
        Me.Panel1.Controls.Add(Me.TXTCONSULTA)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Consulta"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(590, 6)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(143, 20)
        Me.txtBusca.TabIndex = 4
        '
        'TXTCONSULTA
        '
        Me.TXTCONSULTA.FormattingEnabled = True
        Me.TXTCONSULTA.Items.AddRange(New Object() {"1=Total de vendas/saldo/reservas por cliente", "2=Vendas por vendedor com saldo e reservas", "3=Vendas mensais por vendedor", "4=Vendas mensais por cliente", "5=Vendas mensais de produto", "6=Total de compras por fornecedor", "7=Correlação Prod/Espec CLC x CIEX", "8=Correlação Cliente/Moeda/Incot CLC x CIEX", "9=Estoque de produto avariado de não avariado", "10=Especificações de Produto e Descrições Comerciais p/ Vendedores", "11=Ordens de Venda sem IPI"})
        Me.TXTCONSULTA.Location = New System.Drawing.Point(62, 6)
        Me.TXTCONSULTA.Name = "TXTCONSULTA"
        Me.TXTCONSULTA.Size = New System.Drawing.Size(348, 21)
        Me.TXTCONSULTA.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(511, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Busca Rápida"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(751, 3)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(80, 30)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'pnlCima
        '
        Me.pnlCima.Controls.Add(Me.grpDimensoes)
        Me.pnlCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCima.Location = New System.Drawing.Point(0, 37)
        Me.pnlCima.Name = "pnlCima"
        Me.pnlCima.Size = New System.Drawing.Size(834, 298)
        Me.pnlCima.TabIndex = 7
        '
        'grpDimensoes
        '
        Me.grpDimensoes.Controls.Add(Me.grdPrinc)
        Me.grpDimensoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDimensoes.Location = New System.Drawing.Point(0, 0)
        Me.grpDimensoes.Name = "grpDimensoes"
        Me.grpDimensoes.Size = New System.Drawing.Size(834, 298)
        Me.grpDimensoes.TabIndex = 5
        Me.grpDimensoes.TabStop = False
        Me.grpDimensoes.Text = "Estoque"
        '
        'grpSub
        '
        Me.grpSub.Controls.Add(Me.grdEtiq)
        Me.grpSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSub.Location = New System.Drawing.Point(0, 0)
        Me.grpSub.Name = "grpSub"
        Me.grpSub.Size = New System.Drawing.Size(703, 147)
        Me.grpSub.TabIndex = 1
        Me.grpSub.TabStop = False
        Me.grpSub.Text = "Ordens de Venda"
        '
        'btnVisualiza
        '
        Me.btnVisualiza.Location = New System.Drawing.Point(6, 6)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(119, 22)
        Me.btnVisualiza.TabIndex = 7
        Me.btnVisualiza.Text = "..."
        Me.btnVisualiza.UseVisualStyleBackColor = True
        '
        'pnlBaixo
        '
        Me.pnlBaixo.Controls.Add(Me.grpSub)
        Me.pnlBaixo.Controls.Add(Me.pnlBotoes)
        Me.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBaixo.Location = New System.Drawing.Point(0, 345)
        Me.pnlBaixo.Name = "pnlBaixo"
        Me.pnlBaixo.Size = New System.Drawing.Size(834, 147)
        Me.pnlBaixo.TabIndex = 8
        Me.pnlBaixo.Visible = False
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.btnVisualiza)
        Me.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBotoes.Location = New System.Drawing.Point(703, 0)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(131, 147)
        Me.pnlBotoes.TabIndex = 9
        Me.pnlBotoes.Visible = False
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 335)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(834, 10)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'grdEtiq
        '
        Me.grdEtiq.AutoBind = False
        Me.grdEtiq.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdEtiq.BindContainer = Nothing
        Me.grdEtiq.Campos = Nothing
        Me.grdEtiq.CamposExtend = Nothing
        Me.grdEtiq.CamposFixos = ""
        Me.grdEtiq.Chave = Nothing
        Me.grdEtiq.ColunaNomes = ""
        Me.grdEtiq.Defs = Nothing
        Me.grdEtiq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEtiq.EsquemaGerador = "IM"
        Me.grdEtiq.EsquemaPrinc = "IM"
        Me.grdEtiq.Filtro = Nothing
        Me.grdEtiq.IncluiCamposSys = False
        Me.grdEtiq.Location = New System.Drawing.Point(3, 16)
        Me.grdEtiq.MostraNumReg = False
        Me.grdEtiq.Name = "grdEtiq"
        Me.grdEtiq.Ocultar = Nothing
        Me.grdEtiq.Params = CType(resources.GetObject("grdEtiq.Params"), System.Collections.ArrayList)
        Me.grdEtiq.Sistema = "IM"
        Me.grdEtiq.Size = New System.Drawing.Size(697, 128)
        Me.grdEtiq.SomenteLeitura = False
        Me.grdEtiq.SQL = ""
        Me.grdEtiq.StrConn = Nothing
        Me.grdEtiq.Tabela = ""
        Me.grdEtiq.TabIndex = 6
        Me.grdEtiq.Tag = ""
        Me.grdEtiq.Totaliza = ""
        Me.grdEtiq.Usuario = ""
        Me.grdEtiq.ValorPadrao = CType(resources.GetObject("grdEtiq.ValorPadrao"), System.Collections.ArrayList)
        '
        'grdPrinc
        '
        Me.grdPrinc.AutoBind = False
        Me.grdPrinc.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdPrinc.BindContainer = Nothing
        Me.grdPrinc.Campos = Nothing
        Me.grdPrinc.CamposExtend = Nothing
        Me.grdPrinc.CamposFixos = ""
        Me.grdPrinc.Chave = Nothing
        Me.grdPrinc.ColunaNomes = ""
        Me.grdPrinc.Defs = Nothing
        Me.grdPrinc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrinc.EsquemaGerador = "IM"
        Me.grdPrinc.EsquemaPrinc = "IM"
        Me.grdPrinc.Filtro = Nothing
        Me.grdPrinc.IncluiCamposSys = False
        Me.grdPrinc.Location = New System.Drawing.Point(3, 16)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(828, 279)
        Me.grdPrinc.SomenteLeitura = False
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 4
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'frmEstoqueEstat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 492)
        Me.Controls.Add(Me.pnlBaixo)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlCima)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEstoqueEstat"
        Me.Text = "Grid de Consultas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlCima.ResumeLayout(False)
        Me.grpDimensoes.ResumeLayout(False)
        Me.grpSub.ResumeLayout(False)
        Me.pnlBaixo.ResumeLayout(False)
        Me.pnlBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdEtiq As Icraft.IcftFGrid2
    Friend WithEvents grpSub As System.Windows.Forms.GroupBox
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCima As System.Windows.Forms.Panel
    Friend WithEvents grpDimensoes As System.Windows.Forms.GroupBox
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents pnlBaixo As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnlBotoes As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTCONSULTA As System.Windows.Forms.ComboBox
End Class
