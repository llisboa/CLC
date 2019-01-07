<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPontoColeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPontoColeta))
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.pnlComandos = New System.Windows.Forms.Panel
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.pnlGeral = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.pnlComandos.SuspendLayout()
        Me.pnlGeral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlComandos
        '
        Me.pnlComandos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlComandos.Controls.Add(Me.btnImprimir)
        Me.pnlComandos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlComandos.Location = New System.Drawing.Point(759, 0)
        Me.pnlComandos.Name = "pnlComandos"
        Me.pnlComandos.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlComandos.Size = New System.Drawing.Size(79, 370)
        Me.pnlComandos.TabIndex = 6
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
        'pnlGeral
        '
        Me.pnlGeral.Controls.Add(Me.grdPrinc)
        Me.pnlGeral.Controls.Add(Me.Panel1)
        Me.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGeral.Name = "pnlGeral"
        Me.pnlGeral.Size = New System.Drawing.Size(759, 370)
        Me.pnlGeral.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 49)
        Me.Panel1.TabIndex = 5
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(678, 21)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(73, 22)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmPontoColeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 370)
        Me.Controls.Add(Me.pnlGeral)
        Me.Controls.Add(Me.pnlComandos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPontoColeta"
        Me.Text = "Carregamentos por Ponto de Coleta"
        Me.pnlComandos.ResumeLayout(False)
        Me.pnlGeral.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents pnlComandos As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents pnlGeral As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
