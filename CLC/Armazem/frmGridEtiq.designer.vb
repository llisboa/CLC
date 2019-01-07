<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridEtiq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGridEtiq))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opc2 = New System.Windows.Forms.RadioButton
        Me.opc1 = New System.Windows.Forms.RadioButton
        Me.chkStatus = New icraft.IcftFCheckOpc
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.grd2 = New Icraft.IcftFGrid2
        Me.btnCampos = New System.Windows.Forms.Button
        Me.OPCCAMPOS = New Icraft.IcftFOpc
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.chkStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 80)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(675, 46)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opc2)
        Me.GroupBox1.Controls.Add(Me.opc1)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 36)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Grid"
        '
        'opc2
        '
        Me.opc2.AutoSize = True
        Me.opc2.Location = New System.Drawing.Point(49, 14)
        Me.opc2.Name = "opc2"
        Me.opc2.Size = New System.Drawing.Size(31, 17)
        Me.opc2.TabIndex = 0
        Me.opc2.Text = "2"
        Me.opc2.UseVisualStyleBackColor = True
        '
        'opc1
        '
        Me.opc1.AutoSize = True
        Me.opc1.Checked = True
        Me.opc1.Location = New System.Drawing.Point(11, 14)
        Me.opc1.Name = "opc1"
        Me.opc1.Size = New System.Drawing.Size(31, 17)
        Me.opc1.TabIndex = 0
        Me.opc1.TabStop = True
        Me.opc1.Text = "1"
        Me.opc1.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.chkStatus.AlturaPx = 37
        Me.chkStatus.AutoBind = False
        Me.chkStatus.AutoScroll = True
        Me.chkStatus.AutoSize = True
        Me.chkStatus.DeslocaAlturaPx = 20
        Me.chkStatus.DeslocaLarguraPx = 100
        Me.chkStatus.LarguraPx = 334
        Me.chkStatus.Location = New System.Drawing.Point(338, 6)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(334, 37)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 1
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
        Me.grdPrinc.EsquemaPrinc = ""
        Me.grdPrinc.Filtro = Nothing
        Me.grdPrinc.IncluiCamposSys = False
        Me.grdPrinc.Location = New System.Drawing.Point(0, 80)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(758, 289)
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 4
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'grd2
        '
        Me.grd2.AutoBind = False
        Me.grd2.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grd2.BindContainer = Nothing
        Me.grd2.Campos = Nothing
        Me.grd2.CamposExtend = Nothing
        Me.grd2.CamposFixos = ""
        Me.grd2.Chave = Nothing
        Me.grd2.ColunaNomes = ""
        Me.grd2.Defs = Nothing
        Me.grd2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd2.EsquemaGerador = ""
        Me.grd2.EsquemaPrinc = ""
        Me.grd2.Filtro = Nothing
        Me.grd2.IncluiCamposSys = False
        Me.grd2.Location = New System.Drawing.Point(0, 80)
        Me.grd2.MostraNumReg = False
        Me.grd2.Name = "grd2"
        Me.grd2.Ocultar = Nothing
        Me.grd2.Params = CType(resources.GetObject("grd2.Params"), System.Collections.ArrayList)
        Me.grd2.Sistema = ""
        Me.grd2.Size = New System.Drawing.Size(758, 289)
        Me.grd2.SQL = ""
        Me.grd2.StrConn = Nothing
        Me.grd2.Tabela = ""
        Me.grd2.TabIndex = 5
        Me.grd2.Totaliza = ""
        Me.grd2.Usuario = ""
        Me.grd2.ValorPadrao = CType(resources.GetObject("grd2.ValorPadrao"), System.Collections.ArrayList)
        Me.grd2.Visible = False
        '
        'btnCampos
        '
        Me.btnCampos.Location = New System.Drawing.Point(245, 23)
        Me.btnCampos.Name = "btnCampos"
        Me.btnCampos.Size = New System.Drawing.Size(73, 22)
        Me.btnCampos.TabIndex = 4
        Me.btnCampos.Text = "Campos"
        Me.btnCampos.UseVisualStyleBackColor = True
        '
        'OPCCAMPOS
        '
        Me.OPCCAMPOS.Atualizar = Nothing
        Me.OPCCAMPOS.AutoBind = False
        Me.OPCCAMPOS.ListaSQL = "SELECT CAMPO_DEF FROM (SELECT TO_CHAR(ORDEM,'00') || ' | ' ||  CAMPO || ' | ' || " & _
            "ETIQ CAMPO_DEF FROM IM.GER_CAMPO WHERE TABELA = 'ETIQUETA' AND CAMPO<>'ETIQUETA'" & _
            ") ORDER BY 1 "
        Me.OPCCAMPOS.Location = New System.Drawing.Point(242, 39)
        Me.OPCCAMPOS.Metodo = Icraft.IcftFOpc.MetodoOpc.Trecho
        Me.OPCCAMPOS.MostraConfirma = True
        Me.OPCCAMPOS.Name = "OPCCAMPOS"
        Me.OPCCAMPOS.Params = CType(resources.GetObject("OPCCAMPOS.Params"), System.Collections.ArrayList)
        Me.OPCCAMPOS.Size = New System.Drawing.Size(319, 318)
        Me.OPCCAMPOS.StrConn = Nothing
        Me.OPCCAMPOS.TabIndex = 5
        Me.OPCCAMPOS.TextoSQL = ""
        Me.OPCCAMPOS.Titulo = ""
        Me.OPCCAMPOS.Visible = False
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
        'frmGridEtiq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 369)
        Me.Controls.Add(Me.btnCampos)
        Me.Controls.Add(Me.OPCCAMPOS)
        Me.Controls.Add(Me.grd2)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGridEtiq"
        Me.Text = "Grid de Manutenção de Etiquetas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents chkStatus As icraft.IcftFCheckOpc
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents grd2 As Icraft.IcftFGrid2
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opc2 As System.Windows.Forms.RadioButton
    Friend WithEvents opc1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCampos As System.Windows.Forms.Button
    Friend WithEvents OPCCAMPOS As Icraft.IcftFOpc
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
