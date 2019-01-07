<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFracionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFracionar))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlStatus = New System.Windows.Forms.Panel
        Me.chkStatus = New icraft.IcftFCheckOpc
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblQtdPecas = New System.Windows.Forms.Label
        Me.lblQtdPecasAtual = New System.Windows.Forms.Label
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.btnAlteraPeso = New System.Windows.Forms.Button
        Me.txtBBrt = New System.Windows.Forms.TextBox
        Me.txtBLiq = New System.Windows.Forms.TextBox
        Me.txtPTeo = New System.Windows.Forms.TextBox
        Me.txtPBrt = New System.Windows.Forms.TextBox
        Me.txtPLiq = New System.Windows.Forms.TextBox
        Me.btnConfirma = New System.Windows.Forms.Button
        Me.lblBBrt = New System.Windows.Forms.Label
        Me.lblBLiq = New System.Windows.Forms.Label
        Me.lblPTeo = New System.Windows.Forms.Label
        Me.lblPBrt = New System.Windows.Forms.Label
        Me.lblPLiq = New System.Windows.Forms.Label
        Me.btnCalcula = New System.Windows.Forms.Button
        Me.txtPart = New System.Windows.Forms.TextBox
        Me.lblPart = New System.Windows.Forms.Label
        Me.lblEtiq = New System.Windows.Forms.Label
        Me.lblEtiqAtual = New System.Windows.Forms.Label
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlStatus)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 49)
        Me.Panel1.TabIndex = 0
        '
        'pnlStatus
        '
        Me.pnlStatus.Controls.Add(Me.chkStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(338, 6)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(334, 37)
        Me.pnlStatus.TabIndex = 6
        '
        'chkStatus
        '
        Me.chkStatus.AlturaPx = 37
        Me.chkStatus.AutoBind = False
        Me.chkStatus.AutoSize = True
        Me.chkStatus.DeslocaAlturaPx = 20
        Me.chkStatus.DeslocaLarguraPx = 100
        Me.chkStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkStatus.LarguraPx = 334
        Me.chkStatus.Location = New System.Drawing.Point(0, 0)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(334, 37)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnAtualizar)
        Me.Panel3.Location = New System.Drawing.Point(675, 12)
        Me.Panel3.MaximumSize = New System.Drawing.Size(50, 30)
        Me.Panel3.MinimumSize = New System.Drawing.Size(80, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 30)
        Me.Panel3.TabIndex = 5
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
        Me.grdPrinc.Location = New System.Drawing.Point(0, 49)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(758, 504)
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblQtdPecas)
        Me.Panel2.Controls.Add(Me.lblQtdPecasAtual)
        Me.Panel2.Controls.Add(Me.btnVisualiza)
        Me.Panel2.Controls.Add(Me.btnAlteraPeso)
        Me.Panel2.Controls.Add(Me.txtBBrt)
        Me.Panel2.Controls.Add(Me.txtBLiq)
        Me.Panel2.Controls.Add(Me.txtPTeo)
        Me.Panel2.Controls.Add(Me.txtPBrt)
        Me.Panel2.Controls.Add(Me.txtPLiq)
        Me.Panel2.Controls.Add(Me.btnConfirma)
        Me.Panel2.Controls.Add(Me.lblBBrt)
        Me.Panel2.Controls.Add(Me.lblBLiq)
        Me.Panel2.Controls.Add(Me.lblPTeo)
        Me.Panel2.Controls.Add(Me.lblPBrt)
        Me.Panel2.Controls.Add(Me.lblPLiq)
        Me.Panel2.Controls.Add(Me.btnCalcula)
        Me.Panel2.Controls.Add(Me.txtPart)
        Me.Panel2.Controls.Add(Me.lblPart)
        Me.Panel2.Controls.Add(Me.lblEtiq)
        Me.Panel2.Controls.Add(Me.lblEtiqAtual)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 91)
        Me.Panel2.TabIndex = 3
        '
        'lblQtdPecas
        '
        Me.lblQtdPecas.AutoSize = True
        Me.lblQtdPecas.Location = New System.Drawing.Point(85, 38)
        Me.lblQtdPecas.Name = "lblQtdPecas"
        Me.lblQtdPecas.Size = New System.Drawing.Size(16, 13)
        Me.lblQtdPecas.TabIndex = 24
        Me.lblQtdPecas.Text = "..."
        '
        'lblQtdPecasAtual
        '
        Me.lblQtdPecasAtual.AutoSize = True
        Me.lblQtdPecasAtual.Location = New System.Drawing.Point(3, 38)
        Me.lblQtdPecasAtual.Name = "lblQtdPecasAtual"
        Me.lblQtdPecasAtual.Size = New System.Drawing.Size(60, 13)
        Me.lblQtdPecasAtual.TabIndex = 23
        Me.lblQtdPecasAtual.Text = "Qtd Peças:"
        '
        'btnVisualiza
        '
        Me.btnVisualiza.Location = New System.Drawing.Point(650, 63)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(100, 22)
        Me.btnVisualiza.TabIndex = 22
        Me.btnVisualiza.Text = "Visualizar Relatório"
        Me.btnVisualiza.UseVisualStyleBackColor = True
        '
        'btnAlteraPeso
        '
        Me.btnAlteraPeso.Location = New System.Drawing.Point(650, 35)
        Me.btnAlteraPeso.Name = "btnAlteraPeso"
        Me.btnAlteraPeso.Size = New System.Drawing.Size(100, 22)
        Me.btnAlteraPeso.TabIndex = 21
        Me.btnAlteraPeso.Text = "Alterar Peso"
        Me.btnAlteraPeso.UseVisualStyleBackColor = True
        '
        'txtBBrt
        '
        Me.txtBBrt.Enabled = False
        Me.txtBBrt.Location = New System.Drawing.Point(557, 7)
        Me.txtBBrt.Name = "txtBBrt"
        Me.txtBBrt.Size = New System.Drawing.Size(73, 20)
        Me.txtBBrt.TabIndex = 20
        '
        'txtBLiq
        '
        Me.txtBLiq.Enabled = False
        Me.txtBLiq.Location = New System.Drawing.Point(557, 34)
        Me.txtBLiq.Name = "txtBLiq"
        Me.txtBLiq.Size = New System.Drawing.Size(73, 20)
        Me.txtBLiq.TabIndex = 19
        '
        'txtPTeo
        '
        Me.txtPTeo.Enabled = False
        Me.txtPTeo.Location = New System.Drawing.Point(364, 55)
        Me.txtPTeo.Name = "txtPTeo"
        Me.txtPTeo.Size = New System.Drawing.Size(73, 20)
        Me.txtPTeo.TabIndex = 17
        '
        'txtPBrt
        '
        Me.txtPBrt.Enabled = False
        Me.txtPBrt.Location = New System.Drawing.Point(364, 31)
        Me.txtPBrt.Name = "txtPBrt"
        Me.txtPBrt.Size = New System.Drawing.Size(73, 20)
        Me.txtPBrt.TabIndex = 16
        '
        'txtPLiq
        '
        Me.txtPLiq.Enabled = False
        Me.txtPLiq.Location = New System.Drawing.Point(364, 7)
        Me.txtPLiq.Name = "txtPLiq"
        Me.txtPLiq.Size = New System.Drawing.Size(73, 20)
        Me.txtPLiq.TabIndex = 15
        '
        'btnConfirma
        '
        Me.btnConfirma.Location = New System.Drawing.Point(650, 7)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(100, 22)
        Me.btnConfirma.TabIndex = 14
        Me.btnConfirma.Text = "Confirma"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'lblBBrt
        '
        Me.lblBBrt.AutoSize = True
        Me.lblBBrt.Location = New System.Drawing.Point(462, 10)
        Me.lblBBrt.Name = "lblBBrt"
        Me.lblBBrt.Size = New System.Drawing.Size(77, 13)
        Me.lblBBrt.TabIndex = 12
        Me.lblBBrt.Text = "Balança Bruto:"
        '
        'lblBLiq
        '
        Me.lblBLiq.AutoSize = True
        Me.lblBLiq.Location = New System.Drawing.Point(462, 34)
        Me.lblBLiq.Name = "lblBLiq"
        Me.lblBLiq.Size = New System.Drawing.Size(88, 13)
        Me.lblBLiq.TabIndex = 10
        Me.lblBLiq.Text = "Balança Líquido:"
        '
        'lblPTeo
        '
        Me.lblPTeo.AutoSize = True
        Me.lblPTeo.Location = New System.Drawing.Point(285, 58)
        Me.lblPTeo.Name = "lblPTeo"
        Me.lblPTeo.Size = New System.Drawing.Size(73, 13)
        Me.lblPTeo.TabIndex = 8
        Me.lblPTeo.Text = "Peso Teórico:"
        '
        'lblPBrt
        '
        Me.lblPBrt.AutoSize = True
        Me.lblPBrt.Location = New System.Drawing.Point(285, 34)
        Me.lblPBrt.Name = "lblPBrt"
        Me.lblPBrt.Size = New System.Drawing.Size(62, 13)
        Me.lblPBrt.TabIndex = 6
        Me.lblPBrt.Text = "Peso Bruto:"
        '
        'lblPLiq
        '
        Me.lblPLiq.AutoSize = True
        Me.lblPLiq.Location = New System.Drawing.Point(285, 10)
        Me.lblPLiq.Name = "lblPLiq"
        Me.lblPLiq.Size = New System.Drawing.Size(73, 13)
        Me.lblPLiq.TabIndex = 4
        Me.lblPLiq.Text = "Peso Líquido:"
        '
        'btnCalcula
        '
        Me.btnCalcula.Location = New System.Drawing.Point(149, 63)
        Me.btnCalcula.Name = "btnCalcula"
        Me.btnCalcula.Size = New System.Drawing.Size(100, 22)
        Me.btnCalcula.TabIndex = 3
        Me.btnCalcula.Text = "Calcular Peso"
        Me.btnCalcula.UseVisualStyleBackColor = True
        '
        'txtPart
        '
        Me.txtPart.Location = New System.Drawing.Point(206, 34)
        Me.txtPart.Name = "txtPart"
        Me.txtPart.Size = New System.Drawing.Size(43, 20)
        Me.txtPart.TabIndex = 3
        '
        'lblPart
        '
        Me.lblPart.AutoSize = True
        Me.lblPart.Location = New System.Drawing.Point(121, 38)
        Me.lblPart.Name = "lblPart"
        Me.lblPart.Size = New System.Drawing.Size(77, 13)
        Me.lblPart.TabIndex = 2
        Me.lblPart.Text = "Particionar em:"
        '
        'lblEtiq
        '
        Me.lblEtiq.AutoSize = True
        Me.lblEtiq.Location = New System.Drawing.Point(85, 10)
        Me.lblEtiq.Name = "lblEtiq"
        Me.lblEtiq.Size = New System.Drawing.Size(16, 13)
        Me.lblEtiq.TabIndex = 1
        Me.lblEtiq.Text = "..."
        '
        'lblEtiqAtual
        '
        Me.lblEtiqAtual.AutoSize = True
        Me.lblEtiqAtual.Location = New System.Drawing.Point(3, 10)
        Me.lblEtiqAtual.Name = "lblEtiqAtual"
        Me.lblEtiqAtual.Size = New System.Drawing.Size(75, 13)
        Me.lblEtiqAtual.TabIndex = 0
        Me.lblEtiqAtual.Text = "Etiqueta atual:"
        '
        'EstoqueF
        '
        Me.EstoqueF.ArmazemSQL = Nothing
        Me.EstoqueF.BotaoTexto = "Filtro de Estoque"
        Me.EstoqueF.CarregaEtaSQL = Nothing
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
        'frmFracionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFracionar"
        Me.Text = "Fracionar Etiquetas"
        Me.Panel1.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents chkStatus As icraft.IcftFCheckOpc
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblPart As System.Windows.Forms.Label
    Friend WithEvents lblEtiq As System.Windows.Forms.Label
    Friend WithEvents lblEtiqAtual As System.Windows.Forms.Label
    Friend WithEvents txtPart As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcula As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents lblBBrt As System.Windows.Forms.Label
    Friend WithEvents lblBLiq As System.Windows.Forms.Label
    Friend WithEvents lblPTeo As System.Windows.Forms.Label
    Friend WithEvents lblPBrt As System.Windows.Forms.Label
    Friend WithEvents lblPLiq As System.Windows.Forms.Label
    Friend WithEvents txtBBrt As System.Windows.Forms.TextBox
    Friend WithEvents txtBLiq As System.Windows.Forms.TextBox
    Friend WithEvents txtPTeo As System.Windows.Forms.TextBox
    Friend WithEvents txtPBrt As System.Windows.Forms.TextBox
    Friend WithEvents txtPLiq As System.Windows.Forms.TextBox
    Friend WithEvents btnAlteraPeso As System.Windows.Forms.Button
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents lblQtdPecas As System.Windows.Forms.Label
    Friend WithEvents lblQtdPecasAtual As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
End Class
