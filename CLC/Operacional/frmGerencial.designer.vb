<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencial))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCFOP = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.lblTipo = New System.Windows.Forms.Label
        Me.chkNaoCanc = New System.Windows.Forms.CheckBox
        Me.chkCanc = New System.Windows.Forms.CheckBox
        Me.CTLATE = New System.Windows.Forms.MaskedTextBox
        Me.lblAte = New System.Windows.Forms.Label
        Me.CTLDE = New System.Windows.Forms.MaskedTextBox
        Me.lblDe = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.txtEmissor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtEmissor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCFOP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTipo)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.chkNaoCanc)
        Me.Panel1.Controls.Add(Me.chkCanc)
        Me.Panel1.Controls.Add(Me.CTLATE)
        Me.Panel1.Controls.Add(Me.lblAte)
        Me.Panel1.Controls.Add(Me.CTLDE)
        Me.Panel1.Controls.Add(Me.lblDe)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 54)
        Me.Panel1.TabIndex = 0
        '
        'txtCFOP
        '
        Me.txtCFOP.Location = New System.Drawing.Point(298, 28)
        Me.txtCFOP.Name = "txtCFOP"
        Me.txtCFOP.Size = New System.Drawing.Size(267, 20)
        Me.txtCFOP.TabIndex = 11
        Me.txtCFOP.Text = "5106;6106;5123;6123;5120;6120;5102;6102;5119;6119"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CFOP"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(249, 28)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(35, 20)
        Me.txtTipo.TabIndex = 9
        Me.txtTipo.Text = "1"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(246, 9)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Tipo"
        '
        'chkNaoCanc
        '
        Me.chkNaoCanc.AutoSize = True
        Me.chkNaoCanc.Location = New System.Drawing.Point(460, 8)
        Me.chkNaoCanc.Name = "chkNaoCanc"
        Me.chkNaoCanc.Size = New System.Drawing.Size(105, 17)
        Me.chkNaoCanc.TabIndex = 7
        Me.chkNaoCanc.Text = "Não Canceladas"
        Me.chkNaoCanc.UseVisualStyleBackColor = True
        '
        'chkCanc
        '
        Me.chkCanc.AutoSize = True
        Me.chkCanc.Location = New System.Drawing.Point(372, 8)
        Me.chkCanc.Name = "chkCanc"
        Me.chkCanc.Size = New System.Drawing.Size(82, 17)
        Me.chkCanc.TabIndex = 7
        Me.chkCanc.Text = "Canceladas"
        Me.chkCanc.UseVisualStyleBackColor = True
        '
        'CTLATE
        '
        Me.CTLATE.Location = New System.Drawing.Point(130, 28)
        Me.CTLATE.Name = "CTLATE"
        Me.CTLATE.Size = New System.Drawing.Size(100, 20)
        Me.CTLATE.TabIndex = 6
        Me.CTLATE.Tag = "tipo:DATE"
        Me.CTLATE.ValidatingType = GetType(Date)
        '
        'lblAte
        '
        Me.lblAte.AutoSize = True
        Me.lblAte.Location = New System.Drawing.Point(127, 9)
        Me.lblAte.Name = "lblAte"
        Me.lblAte.Size = New System.Drawing.Size(23, 13)
        Me.lblAte.TabIndex = 5
        Me.lblAte.Text = "Ate"
        '
        'CTLDE
        '
        Me.CTLDE.Location = New System.Drawing.Point(9, 28)
        Me.CTLDE.Name = "CTLDE"
        Me.CTLDE.Size = New System.Drawing.Size(100, 20)
        Me.CTLDE.TabIndex = 4
        Me.CTLDE.Tag = "tipo:DATE"
        Me.CTLDE.ValidatingType = GetType(Date)
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(6, 9)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(21, 13)
        Me.lblDe.TabIndex = 3
        Me.lblDe.Text = "De"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(722, 26)
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
        Me.grdPrinc.Size = New System.Drawing.Size(798, 315)
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
        'txtEmissor
        '
        Me.txtEmissor.Location = New System.Drawing.Point(584, 28)
        Me.txtEmissor.Name = "txtEmissor"
        Me.txtEmissor.Size = New System.Drawing.Size(132, 20)
        Me.txtEmissor.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(581, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Emissor"
        '
        'frmGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 369)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGerencial"
        Me.Text = "Gerencial"
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
    Friend WithEvents chkCanc As System.Windows.Forms.CheckBox
    Friend WithEvents txtCFOP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents chkNaoCanc As System.Windows.Forms.CheckBox
    Friend WithEvents txtEmissor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
