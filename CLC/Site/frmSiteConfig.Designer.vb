<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiteConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiteConfig))
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBusca = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPrinc
        '
        Me.grdPrinc.AutoBind = False
        Me.grdPrinc.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdPrinc.BindContainer = Nothing
        Me.grdPrinc.Campos = Nothing
        Me.grdPrinc.Chave = "PARAM"
        Me.grdPrinc.Defs = Nothing
        Me.grdPrinc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrinc.EsquemaGerador = Apl.Esquema
        Me.grdPrinc.EsquemaPrinc = Apl.Esquema
        Me.grdPrinc.Filtro = ""
        Me.grdPrinc.IncluiCamposSys = False
        Me.grdPrinc.Location = New System.Drawing.Point(0, 45)
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = Apl.Esquema
        Me.grdPrinc.Size = New System.Drawing.Size(802, 380)
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = "SYS_CONFIG_GLOBAL"
        Me.grdPrinc.TabIndex = 0
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBusca)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(501, 9)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 0
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Encontrar:"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(112, 11)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(368, 20)
        Me.txtBusca.TabIndex = 2
        '
        'frmSiteConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 425)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSiteConfig"
        Me.Text = "Configurações Específicas para Site"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
