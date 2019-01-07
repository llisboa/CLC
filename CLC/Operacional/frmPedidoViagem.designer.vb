<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoViagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoViagem))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtPEDIDO = New System.Windows.Forms.TextBox
        Me.lblPEDIDO = New System.Windows.Forms.Label
        Me.CTLATE = New System.Windows.Forms.MaskedTextBox
        Me.lblAte = New System.Windows.Forms.Label
        Me.CTLDE = New System.Windows.Forms.MaskedTextBox
        Me.lblDe = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPEDIDO)
        Me.Panel1.Controls.Add(Me.lblPEDIDO)
        Me.Panel1.Controls.Add(Me.CTLATE)
        Me.Panel1.Controls.Add(Me.lblAte)
        Me.Panel1.Controls.Add(Me.CTLDE)
        Me.Panel1.Controls.Add(Me.lblDe)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 54)
        Me.Panel1.TabIndex = 0
        '
        'txtPEDIDO
        '
        Me.txtPEDIDO.Location = New System.Drawing.Point(318, 28)
        Me.txtPEDIDO.Name = "txtPEDIDO"
        Me.txtPEDIDO.Size = New System.Drawing.Size(267, 20)
        Me.txtPEDIDO.TabIndex = 11
        '
        'lblPEDIDO
        '
        Me.lblPEDIDO.AutoSize = True
        Me.lblPEDIDO.Location = New System.Drawing.Point(315, 9)
        Me.lblPEDIDO.Name = "lblPEDIDO"
        Me.lblPEDIDO.Size = New System.Drawing.Size(40, 13)
        Me.lblPEDIDO.TabIndex = 10
        Me.lblPEDIDO.Text = "Pedido"
        '
        'CTLATE
        '
        Me.CTLATE.Location = New System.Drawing.Point(136, 28)
        Me.CTLATE.Name = "CTLATE"
        Me.CTLATE.Size = New System.Drawing.Size(100, 20)
        Me.CTLATE.TabIndex = 6
        Me.CTLATE.Tag = "tipo:DATE"
        Me.CTLATE.ValidatingType = GetType(Date)
        '
        'lblAte
        '
        Me.lblAte.AutoSize = True
        Me.lblAte.Location = New System.Drawing.Point(133, 9)
        Me.lblAte.Name = "lblAte"
        Me.lblAte.Size = New System.Drawing.Size(23, 13)
        Me.lblAte.TabIndex = 5
        Me.lblAte.Text = "Ate"
        '
        'CTLDE
        '
        Me.CTLDE.Location = New System.Drawing.Point(15, 28)
        Me.CTLDE.Name = "CTLDE"
        Me.CTLDE.Size = New System.Drawing.Size(100, 20)
        Me.CTLDE.TabIndex = 4
        Me.CTLDE.Tag = "tipo:DATE"
        Me.CTLDE.ValidatingType = GetType(Date)
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(12, 9)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(21, 13)
        Me.lblDe.TabIndex = 3
        Me.lblDe.Text = "De"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(680, 26)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(73, 22)
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
        Me.grdPrinc.Info = "Informações..."
        Me.grdPrinc.Location = New System.Drawing.Point(0, 54)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(758, 315)
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
        'frmPedidoViagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 369)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPedidoViagem"
        Me.Text = "Pedidos por Viagem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents CTLATE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAte As System.Windows.Forms.Label
    Friend WithEvents CTLDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents txtPEDIDO As System.Windows.Forms.TextBox
    Friend WithEvents lblPEDIDO As System.Windows.Forms.Label
End Class
