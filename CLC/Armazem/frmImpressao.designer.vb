<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpressao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpressao))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkDesmarcar = New System.Windows.Forms.CheckBox
        Me.grpFilaImp = New System.Windows.Forms.GroupBox
        Me.chkLimparFila = New System.Windows.Forms.CheckBox
        Me.chkCriaFila = New System.Windows.Forms.CheckBox
        Me.grpDataImp = New System.Windows.Forms.GroupBox
        Me.chkLimpaDataImp = New System.Windows.Forms.CheckBox
        Me.chkAttDataImp = New System.Windows.Forms.CheckBox
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtFilaImp = New System.Windows.Forms.TextBox
        Me.lblFila = New System.Windows.Forms.Label
        Me.chkMarcar = New System.Windows.Forms.CheckBox
        Me.chkStatus = New icraft.IcftFCheckOpc
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.grpFilaImp.SuspendLayout()
        Me.grpDataImp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkDesmarcar)
        Me.Panel1.Controls.Add(Me.grpFilaImp)
        Me.Panel1.Controls.Add(Me.grpDataImp)
        Me.Panel1.Controls.Add(Me.btnVisualiza)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.txtFilaImp)
        Me.Panel1.Controls.Add(Me.lblFila)
        Me.Panel1.Controls.Add(Me.chkMarcar)
        Me.Panel1.Controls.Add(Me.chkStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 77)
        Me.Panel1.TabIndex = 0
        '
        'chkDesmarcar
        '
        Me.chkDesmarcar.AutoSize = True
        Me.chkDesmarcar.Location = New System.Drawing.Point(503, 54)
        Me.chkDesmarcar.Name = "chkDesmarcar"
        Me.chkDesmarcar.Size = New System.Drawing.Size(110, 17)
        Me.chkDesmarcar.TabIndex = 14
        Me.chkDesmarcar.Text = "Desmarcar Todas"
        Me.chkDesmarcar.UseVisualStyleBackColor = True
        '
        'grpFilaImp
        '
        Me.grpFilaImp.Controls.Add(Me.chkLimparFila)
        Me.grpFilaImp.Controls.Add(Me.chkCriaFila)
        Me.grpFilaImp.Location = New System.Drawing.Point(668, 5)
        Me.grpFilaImp.Name = "grpFilaImp"
        Me.grpFilaImp.Size = New System.Drawing.Size(112, 66)
        Me.grpFilaImp.TabIndex = 13
        Me.grpFilaImp.TabStop = False
        Me.grpFilaImp.Text = "Fila de Impressão"
        '
        'chkLimparFila
        '
        Me.chkLimparFila.AutoSize = True
        Me.chkLimparFila.Location = New System.Drawing.Point(6, 42)
        Me.chkLimparFila.Name = "chkLimparFila"
        Me.chkLimparFila.Size = New System.Drawing.Size(57, 17)
        Me.chkLimparFila.TabIndex = 16
        Me.chkLimparFila.Text = "Limpar"
        Me.chkLimparFila.UseVisualStyleBackColor = True
        '
        'chkCriaFila
        '
        Me.chkCriaFila.AutoSize = True
        Me.chkCriaFila.Location = New System.Drawing.Point(6, 19)
        Me.chkCriaFila.Name = "chkCriaFila"
        Me.chkCriaFila.Size = New System.Drawing.Size(47, 17)
        Me.chkCriaFila.TabIndex = 15
        Me.chkCriaFila.Text = "Criar"
        Me.chkCriaFila.UseVisualStyleBackColor = True
        '
        'grpDataImp
        '
        Me.grpDataImp.Controls.Add(Me.chkLimpaDataImp)
        Me.grpDataImp.Controls.Add(Me.chkAttDataImp)
        Me.grpDataImp.Location = New System.Drawing.Point(795, 5)
        Me.grpDataImp.Name = "grpDataImp"
        Me.grpDataImp.Size = New System.Drawing.Size(112, 66)
        Me.grpDataImp.TabIndex = 12
        Me.grpDataImp.TabStop = False
        Me.grpDataImp.Text = "Data de Impressão"
        '
        'chkLimpaDataImp
        '
        Me.chkLimpaDataImp.AutoSize = True
        Me.chkLimpaDataImp.Location = New System.Drawing.Point(6, 42)
        Me.chkLimpaDataImp.Name = "chkLimpaDataImp"
        Me.chkLimpaDataImp.Size = New System.Drawing.Size(57, 17)
        Me.chkLimpaDataImp.TabIndex = 18
        Me.chkLimpaDataImp.Text = "Limpar"
        Me.chkLimpaDataImp.UseVisualStyleBackColor = True
        '
        'chkAttDataImp
        '
        Me.chkAttDataImp.AutoSize = True
        Me.chkAttDataImp.Location = New System.Drawing.Point(6, 19)
        Me.chkAttDataImp.Name = "chkAttDataImp"
        Me.chkAttDataImp.Size = New System.Drawing.Size(63, 17)
        Me.chkAttDataImp.TabIndex = 17
        Me.chkAttDataImp.Text = "Atualiza"
        Me.chkAttDataImp.UseVisualStyleBackColor = True
        '
        'btnVisualiza
        '
        Me.btnVisualiza.Location = New System.Drawing.Point(945, 43)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(71, 28)
        Me.btnVisualiza.TabIndex = 9
        Me.btnVisualiza.Text = "Visualizar"
        Me.btnVisualiza.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(945, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 28)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtFilaImp
        '
        Me.txtFilaImp.Location = New System.Drawing.Point(503, 9)
        Me.txtFilaImp.Name = "txtFilaImp"
        Me.txtFilaImp.Size = New System.Drawing.Size(142, 20)
        Me.txtFilaImp.TabIndex = 2
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(474, 9)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(23, 13)
        Me.lblFila.TabIndex = 1
        Me.lblFila.Text = "Fila"
        '
        'chkMarcar
        '
        Me.chkMarcar.AutoSize = True
        Me.chkMarcar.Location = New System.Drawing.Point(503, 35)
        Me.chkMarcar.Name = "chkMarcar"
        Me.chkMarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkMarcar.TabIndex = 0
        Me.chkMarcar.Text = "Marcar Todas"
        Me.chkMarcar.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AlturaPx = 37
        Me.chkStatus.AutoBind = False
        Me.chkStatus.DeslocaAlturaPx = 20
        Me.chkStatus.DeslocaLarguraPx = 100
        Me.chkStatus.LarguraPx = 334
        Me.chkStatus.Location = New System.Drawing.Point(144, 9)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.chkStatus.Params = CType(resources.GetObject("chkStatus.Params"), System.Collections.ArrayList)
        Me.chkStatus.Size = New System.Drawing.Size(334, 37)
        Me.chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.chkStatus.SqlText = ""
        Me.chkStatus.StrConn = Nothing
        Me.chkStatus.TabIndex = 5
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
        Me.grdPrinc.Location = New System.Drawing.Point(0, 77)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = Apl.Esquema
        Me.grdPrinc.Size = New System.Drawing.Size(1028, 292)
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
        'frmImpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 369)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImpressao"
        Me.Text = "Fila de Impressão"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpFilaImp.ResumeLayout(False)
        Me.grpFilaImp.PerformLayout()
        Me.grpDataImp.ResumeLayout(False)
        Me.grpDataImp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents chkMarcar As System.Windows.Forms.CheckBox
    Friend WithEvents lblFila As System.Windows.Forms.Label
    Friend WithEvents txtFilaImp As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents chkStatus As icraft.IcftFCheckOpc
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents grpFilaImp As System.Windows.Forms.GroupBox
    Friend WithEvents grpDataImp As System.Windows.Forms.GroupBox
    Friend WithEvents chkDesmarcar As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimparFila As System.Windows.Forms.CheckBox
    Friend WithEvents chkCriaFila As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimpaDataImp As System.Windows.Forms.CheckBox
    Friend WithEvents chkAttDataImp As System.Windows.Forms.CheckBox
End Class
