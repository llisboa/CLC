<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqsNaoEncontradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiqsNaoEncontradas))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.EstoqueF = New CLC.EstoqueF
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.pnlComandos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(491, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Esta visão leva em conta somente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "status ""CONFERIR""."
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
        Me.grdPrinc.EsquemaGerador = Apl.Esquema
        Me.grdPrinc.EsquemaPrinc = Apl.Esquema
        Me.grdPrinc.Filtro = Nothing
        Me.grdPrinc.IncluiCamposSys = False
        Me.grdPrinc.Location = New System.Drawing.Point(0, 49)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = Apl.Esquema
        Me.grdPrinc.Size = New System.Drawing.Size(759, 321)
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 4
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'EstoqueF
        '
        Me.EstoqueF.ArmazemSQL = Nothing
        Me.EstoqueF.BotaoTexto = "Filtro de Estoque"
        Me.EstoqueF.ContainerSQL = Nothing
        Me.EstoqueF.DataEmissaoSQL = Nothing
        Me.EstoqueF.EstabelecimentoSQL = Nothing
        Me.EstoqueF.EstadoSQL = Nothing
        Me.EstoqueF.EtiquetaSQL = Nothing
        Me.EstoqueF.FilaImpSQL = Nothing
        Me.EstoqueF.GrupoSQL = Nothing
        Me.EstoqueF.Location = New System.Drawing.Point(1, 0)
        Me.EstoqueF.MedidaSQL = Nothing
        Me.EstoqueF.Name = "EstoqueF"
        Me.EstoqueF.NCMSQL = Nothing
        Me.EstoqueF.OrdemVendaSQL = Nothing
        Me.EstoqueF.OVItemSQL = Nothing
        Me.EstoqueF.PedidoSQL = Nothing
        Me.EstoqueF.PedItemSQL = Nothing
        Me.EstoqueF.PracaSQL = Nothing
        Me.EstoqueF.ProdutoSQL = Nothing
        Me.EstoqueF.QualidadeSQL = Nothing
        Me.EstoqueF.Size = New System.Drawing.Size(117, 27)
        Me.EstoqueF.StrConn = Nothing
        Me.EstoqueF.TabIndex = 3
        Me.EstoqueF.ViagemSQL = Nothing
        '
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlComandos.Controls.Add(Me.btnImprimir)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(759, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlComandos.Size = New System.Drawing.Size(79, 370)
        Me.pnlComandos.TabIndex = 7
        '
        'btnImprimir
        '
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimir.Location = New System.Drawing.Point(5, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(65, 38)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(679, 15)
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
        'frmEtiqsNaoEncontradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 370)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlComandos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEtiqsNaoEncontradas"
        Me.Text = "Etiquetas com Status de ""CONFERIR"""
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlComandos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
