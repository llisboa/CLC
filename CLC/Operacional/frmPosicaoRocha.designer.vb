<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPosicaoRocha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPosicaoRocha))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CTLATE = New System.Windows.Forms.MaskedTextBox
        Me.lblAte = New System.Windows.Forms.Label
        Me.CTLDE = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkSemCancel = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.ComboBox
        Me.lblDe = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.grdPrinc = New Icraft.IcftFGrid2
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CTLATE)
        Me.Panel1.Controls.Add(Me.lblAte)
        Me.Panel1.Controls.Add(Me.CTLDE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chkSemCancel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTipo)
        Me.Panel1.Controls.Add(Me.lblDe)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 63)
        Me.Panel1.TabIndex = 0
        '
        'CTLATE
        '
        Me.CTLATE.Location = New System.Drawing.Point(172, 32)
        Me.CTLATE.Name = "CTLATE"
        Me.CTLATE.Size = New System.Drawing.Size(100, 20)
        Me.CTLATE.TabIndex = 1
        Me.CTLATE.Tag = "tipo:DATE"
        Me.CTLATE.ValidatingType = GetType(Date)
        '
        'lblAte
        '
        Me.lblAte.AutoSize = True
        Me.lblAte.Location = New System.Drawing.Point(143, 37)
        Me.lblAte.Name = "lblAte"
        Me.lblAte.Size = New System.Drawing.Size(23, 13)
        Me.lblAte.TabIndex = 9
        Me.lblAte.Text = "Ate"
        '
        'CTLDE
        '
        Me.CTLDE.Location = New System.Drawing.Point(40, 33)
        Me.CTLDE.Name = "CTLDE"
        Me.CTLDE.Size = New System.Drawing.Size(100, 20)
        Me.CTLDE.TabIndex = 0
        Me.CTLDE.Tag = "tipo:DATE"
        Me.CTLDE.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "De"
        '
        'chkSemCancel
        '
        Me.chkSemCancel.AutoSize = True
        Me.chkSemCancel.Checked = True
        Me.chkSemCancel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSemCancel.Location = New System.Drawing.Point(297, 34)
        Me.chkSemCancel.Name = "chkSemCancel"
        Me.chkSemCancel.Size = New System.Drawing.Size(106, 17)
        Me.chkSemCancel.TabIndex = 2
        Me.chkSemCancel.Text = "Sem Canceladas"
        Me.chkSemCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo de Consulta:"
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Items.AddRange(New Object() {"1-Notas de entrada no Rocha Top", "2-Notas de saída do Rocha Top"})
        Me.txtTipo.Location = New System.Drawing.Point(501, 32)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(188, 21)
        Me.txtTipo.TabIndex = 4
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDe.Location = New System.Drawing.Point(26, 2)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(305, 24)
        Me.lblDe.TabIndex = 3
        Me.lblDe.Text = "Posição de Estoque no Rocha Top"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(713, 30)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(73, 22)
        Me.btnAtualizar.TabIndex = 5
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
        Me.grdPrinc.Location = New System.Drawing.Point(0, 63)
        Me.grdPrinc.MostraNumReg = False
        Me.grdPrinc.MostraRodape = True
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Ocultar = Nothing
        Me.grdPrinc.Params = CType(resources.GetObject("grdPrinc.Params"), System.Collections.ArrayList)
        Me.grdPrinc.Sistema = "IM"
        Me.grdPrinc.Size = New System.Drawing.Size(798, 306)
        Me.grdPrinc.SomenteLeitura = False
        Me.grdPrinc.SQL = ""
        Me.grdPrinc.StrConn = Nothing
        Me.grdPrinc.Tabela = ""
        Me.grdPrinc.TabIndex = 0
        Me.grdPrinc.Tag = ""
        Me.grdPrinc.Totaliza = ""
        Me.grdPrinc.Usuario = ""
        Me.grdPrinc.ValorPadrao = CType(resources.GetObject("grdPrinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'frmPosicaoRocha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 369)
        Me.Controls.Add(Me.grdPrinc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPosicaoRocha"
        Me.Text = "Posição de Estoque no Rocha Top"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdPrinc As Icraft.IcftFGrid2
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.ComboBox
    Friend WithEvents chkSemCancel As System.Windows.Forms.CheckBox
    Friend WithEvents CTLATE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAte As System.Windows.Forms.Label
    Friend WithEvents CTLDE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
