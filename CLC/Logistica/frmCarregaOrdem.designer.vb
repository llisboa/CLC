<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarregaOrdem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarregaOrdem))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkOpc = New icraft.IcftFCheckOpc
        Me.txtBusca = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.pnlCima = New System.Windows.Forms.Panel
        Me.grpDimensoes = New System.Windows.Forms.GroupBox
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.pnlCima.SuspendLayout()
        Me.grpDimensoes.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtBusca)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 57)
        Me.Panel1.TabIndex = 0
        '
        'chkOpc
        '
        Me.chkOpc.AlturaPx = 36
        Me.chkOpc.AutoBind = False
        Me.chkOpc.AutoSize = True
        Me.chkOpc.DeslocaAlturaPx = 20
        Me.chkOpc.DeslocaLarguraPx = 100
        Me.chkOpc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkOpc.LarguraPx = 198
        Me.chkOpc.Location = New System.Drawing.Point(0, 0)
        Me.chkOpc.Name = "chkOpc"
        Me.chkOpc.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkOpc.Params = CType(resources.GetObject("chkOpc.Params"), System.Collections.ArrayList)
        Me.chkOpc.Size = New System.Drawing.Size(497, 47)
        Me.chkOpc.SQL = ""
        Me.chkOpc.SqlText = ""
        Me.chkOpc.StrConn = Nothing
        Me.chkOpc.TabIndex = 6
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(590, 6)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(143, 20)
        Me.txtBusca.TabIndex = 4
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
        Me.pnlCima.Location = New System.Drawing.Point(0, 57)
        Me.pnlCima.Name = "pnlCima"
        Me.pnlCima.Size = New System.Drawing.Size(833, 195)
        Me.pnlCima.TabIndex = 7
        '
        'grpDimensoes
        '
        Me.grpDimensoes.Controls.Add(Me.grdPrinc)
        Me.grpDimensoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDimensoes.Location = New System.Drawing.Point(0, 0)
        Me.grpDimensoes.Name = "grpDimensoes"
        Me.grpDimensoes.Size = New System.Drawing.Size(833, 195)
        Me.grpDimensoes.TabIndex = 5
        Me.grpDimensoes.TabStop = False
        Me.grpDimensoes.Text = "Itens de Ordem de Venda"
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
        Me.grdPrinc.Size = New System.Drawing.Size(827, 176)
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
        'btnVisualiza
        '
        Me.btnVisualiza.Location = New System.Drawing.Point(6, 6)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(119, 22)
        Me.btnVisualiza.TabIndex = 7
        Me.btnVisualiza.Text = "Visualizar Etiqueta"
        Me.btnVisualiza.UseVisualStyleBackColor = True
        Me.btnVisualiza.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(833, 230)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnVisualiza)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(702, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(131, 230)
        Me.Panel4.TabIndex = 9
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 252)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(833, 10)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.chkOpc)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 47)
        Me.Panel2.TabIndex = 5
        '
        'frmCarregaOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 492)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlCima)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCarregaOrdem"
        Me.Text = "Carregamento de Ordem de Venda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlCima.ResumeLayout(False)
        Me.grpDimensoes.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCima As System.Windows.Forms.Panel
    Friend WithEvents grpDimensoes As System.Windows.Forms.GroupBox
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents chkOpc As icraft.IcftFCheckOpc
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
