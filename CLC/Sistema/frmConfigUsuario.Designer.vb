<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.grdConfig = New System.Windows.Forms.DataGridView
        Me.PARAM = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VALOR = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.grdConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(390, 35)
        Me.Panel1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelar.Location = New System.Drawing.Point(225, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(300, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 25)
        Me.Label1.TabIndex = 1
        '
        'btnSalvar
        '
        Me.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSalvar.Location = New System.Drawing.Point(310, 5)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 25)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'grdConfig
        '
        Me.grdConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdConfig.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PARAM, Me.VALOR})
        Me.grdConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdConfig.Location = New System.Drawing.Point(0, 0)
        Me.grdConfig.Name = "grdConfig"
        Me.grdConfig.Size = New System.Drawing.Size(390, 265)
        Me.grdConfig.TabIndex = 1
        '
        'PARAM
        '
        Me.PARAM.HeaderText = "Parâmetro"
        Me.PARAM.Items.AddRange(New Object() {"GridOcultarChave", "AbrirFormMaximizado"})
        Me.PARAM.Name = "PARAM"
        Me.PARAM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PARAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PARAM.Width = 200
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "Definição"
        Me.VALOR.Items.AddRange(New Object() {"True", "False"})
        Me.VALOR.Name = "VALOR"
        Me.VALOR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VALOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmConfigUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 300)
        Me.Controls.Add(Me.grdConfig)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmConfigUsuario"
        Me.Text = "Configuração do Usuário Conectado"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdConfig As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents PARAM As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents VALOR As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
