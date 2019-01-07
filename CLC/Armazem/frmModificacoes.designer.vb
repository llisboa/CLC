<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificacoes))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkQQ = New System.Windows.Forms.CheckBox
        Me.cal = New System.Windows.Forms.MonthCalendar
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtComparaMom = New System.Windows.Forms.TextBox
        Me.pnlComparaStatus = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtComparaStatus = New icraft.IcftFCheckOpc
        Me.chkComparaNao = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnAgora = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtComMom = New System.Windows.Forms.TextBox
        Me.pnlComparaCom = New System.Windows.Forms.Panel
        Me.txtComStatus = New icraft.IcftFCheckOpc
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkComNao = New System.Windows.Forms.CheckBox
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.EstoqueF = New CLC.EstoqueF
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlComparaStatus.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlComparaCom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkQQ)
        Me.Panel1.Controls.Add(Me.cal)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 176)
        Me.Panel1.TabIndex = 0
        '
        'chkQQ
        '
        Me.chkQQ.AutoSize = True
        Me.chkQQ.Checked = True
        Me.chkQQ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQQ.Location = New System.Drawing.Point(319, 8)
        Me.chkQQ.Name = "chkQQ"
        Me.chkQQ.Size = New System.Drawing.Size(180, 17)
        Me.chkQQ.TabIndex = 6
        Me.chkQQ.Text = "Qualquer Modificação em Status"
        Me.chkQQ.UseVisualStyleBackColor = True
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(603, 0)
        Me.cal.Name = "cal"
        Me.cal.TabIndex = 5
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(520, 5)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(73, 22)
        Me.btnAtualizar.TabIndex = 4
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(124, 14)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(469, 151)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtComparaMom)
        Me.TabPage1.Controls.Add(Me.pnlComparaStatus)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(461, 125)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comparar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "yyyy-mm-dd hh:mi:ss"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Momento"
        '
        'txtComparaMom
        '
        Me.txtComparaMom.Location = New System.Drawing.Point(81, 15)
        Me.txtComparaMom.Name = "txtComparaMom"
        Me.txtComparaMom.Size = New System.Drawing.Size(136, 20)
        Me.txtComparaMom.TabIndex = 4
        '
        'pnlComparaStatus
        '
        Me.pnlComparaStatus.Controls.Add(Me.Label2)
        Me.pnlComparaStatus.Controls.Add(Me.txtComparaStatus)
        Me.pnlComparaStatus.Controls.Add(Me.chkComparaNao)
        Me.pnlComparaStatus.Location = New System.Drawing.Point(5, 41)
        Me.pnlComparaStatus.Name = "pnlComparaStatus"
        Me.pnlComparaStatus.Size = New System.Drawing.Size(451, 76)
        Me.pnlComparaStatus.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mostrar registros com STATUS que ("
        '
        'txtComparaStatus
        '
        Me.txtComparaStatus.AlturaPx = 37
        Me.txtComparaStatus.AutoBind = False
        Me.txtComparaStatus.DeslocaAlturaPx = 20
        Me.txtComparaStatus.DeslocaLarguraPx = 100
        Me.txtComparaStatus.LarguraPx = 334
        Me.txtComparaStatus.Location = New System.Drawing.Point(14, 28)
        Me.txtComparaStatus.Name = "txtComparaStatus"
        Me.txtComparaStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.txtComparaStatus.Params = CType(resources.GetObject("txtComparaStatus.Params"), System.Collections.ArrayList)
        Me.txtComparaStatus.Size = New System.Drawing.Size(334, 37)
        Me.txtComparaStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.txtComparaStatus.SqlText = ""
        Me.txtComparaStatus.StrConn = Nothing
        Me.txtComparaStatus.TabIndex = 6
        '
        'chkComparaNao
        '
        Me.chkComparaNao.AutoSize = True
        Me.chkComparaNao.Location = New System.Drawing.Point(273, 9)
        Me.chkComparaNao.Name = "chkComparaNao"
        Me.chkComparaNao.Size = New System.Drawing.Size(165, 17)
        Me.chkComparaNao.TabIndex = 16
        Me.chkComparaNao.Text = "NÃO) constam na lista abaixo"
        Me.chkComparaNao.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAgora)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtComMom)
        Me.TabPage2.Controls.Add(Me.pnlComparaCom)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(461, 125)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Com"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAgora
        '
        Me.btnAgora.Location = New System.Drawing.Point(329, 15)
        Me.btnAgora.Name = "btnAgora"
        Me.btnAgora.Size = New System.Drawing.Size(45, 22)
        Me.btnAgora.TabIndex = 7
        Me.btnAgora.Text = "Agora"
        Me.btnAgora.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "yyyy-mm-dd hh:mi:ss"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Momento"
        '
        'txtComMom
        '
        Me.txtComMom.Location = New System.Drawing.Point(81, 15)
        Me.txtComMom.Name = "txtComMom"
        Me.txtComMom.Size = New System.Drawing.Size(136, 20)
        Me.txtComMom.TabIndex = 4
        '
        'pnlComparaCom
        '
        Me.pnlComparaCom.Controls.Add(Me.txtComStatus)
        Me.pnlComparaCom.Controls.Add(Me.Label3)
        Me.pnlComparaCom.Controls.Add(Me.chkComNao)
        Me.pnlComparaCom.Location = New System.Drawing.Point(5, 41)
        Me.pnlComparaCom.Name = "pnlComparaCom"
        Me.pnlComparaCom.Size = New System.Drawing.Size(451, 76)
        Me.pnlComparaCom.TabIndex = 19
        '
        'txtComStatus
        '
        Me.txtComStatus.AlturaPx = 37
        Me.txtComStatus.AutoBind = False
        Me.txtComStatus.DeslocaAlturaPx = 20
        Me.txtComStatus.DeslocaLarguraPx = 100
        Me.txtComStatus.LarguraPx = 334
        Me.txtComStatus.Location = New System.Drawing.Point(14, 28)
        Me.txtComStatus.Name = "txtComStatus"
        Me.txtComStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Vertical
        Me.txtComStatus.Params = CType(resources.GetObject("txtComStatus.Params"), System.Collections.ArrayList)
        Me.txtComStatus.Size = New System.Drawing.Size(334, 37)
        Me.txtComStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        Me.txtComStatus.SqlText = ""
        Me.txtComStatus.StrConn = Nothing
        Me.txtComStatus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mostrar registros com STATUS que ("
        '
        'chkComNao
        '
        Me.chkComNao.AutoSize = True
        Me.chkComNao.Location = New System.Drawing.Point(273, 9)
        Me.chkComNao.Name = "chkComNao"
        Me.chkComNao.Size = New System.Drawing.Size(165, 17)
        Me.chkComNao.TabIndex = 16
        Me.chkComNao.Text = "NÃO) constam na lista abaixo"
        Me.chkComNao.UseVisualStyleBackColor = True
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
        Me.grdPrinc.Location = New System.Drawing.Point(0, 176)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = Apl.Esquema
        Me.grdPrinc.Size = New System.Drawing.Size(866, 193)
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
        'frmModificacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 369)
        Me.Controls.Add(Me.EstoqueF)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificacoes"
        Me.Text = "Movimentações no Estoque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlComparaStatus.ResumeLayout(False)
        Me.pnlComparaStatus.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pnlComparaCom.ResumeLayout(False)
        Me.pnlComparaCom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents EstoqueF As CLC.EstoqueF
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtComparaStatus As icraft.IcftFCheckOpc
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComparaMom As System.Windows.Forms.TextBox
    Friend WithEvents txtComStatus As icraft.IcftFCheckOpc
    Friend WithEvents txtComMom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkComparaNao As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkComNao As System.Windows.Forms.CheckBox
    Friend WithEvents btnAgora As System.Windows.Forms.Button
    Friend WithEvents cal As System.Windows.Forms.MonthCalendar
    Friend WithEvents chkQQ As System.Windows.Forms.CheckBox
    Friend WithEvents pnlComparaStatus As System.Windows.Forms.Panel
    Friend WithEvents pnlComparaCom As System.Windows.Forms.Panel
End Class
