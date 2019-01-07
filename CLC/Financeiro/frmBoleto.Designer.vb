<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoleto
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.fttProduto = New System.Windows.Forms.ComboBox
        Me.fttNome = New System.Windows.Forms.TextBox
        Me.fttCPF = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.fttCNPJ = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.fttMatr = New System.Windows.Forms.TextBox
        Me.btnFiltro = New System.Windows.Forms.Button
        Me.pnlBoletos = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnEmitBolFiltr = New System.Windows.Forms.Button
        Me.btnBoleto = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sacado Matrícula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sacado Nome (parte)"
        '
        'fttProduto
        '
        Me.fttProduto.FormattingEnabled = True
        Me.fttProduto.Location = New System.Drawing.Point(77, 19)
        Me.fttProduto.Name = "fttProduto"
        Me.fttProduto.Size = New System.Drawing.Size(267, 21)
        Me.fttProduto.TabIndex = 1
        '
        'fttNome
        '
        Me.fttNome.Location = New System.Drawing.Point(661, 19)
        Me.fttNome.Name = "fttNome"
        Me.fttNome.Size = New System.Drawing.Size(250, 20)
        Me.fttNome.TabIndex = 3
        '
        'fttCPF
        '
        Me.fttCPF.Location = New System.Drawing.Point(77, 46)
        Me.fttCPF.Name = "fttCPF"
        Me.fttCPF.Size = New System.Drawing.Size(167, 20)
        Me.fttCPF.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CPF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CNPJ"
        '
        'fttCNPJ
        '
        Me.fttCNPJ.Location = New System.Drawing.Point(290, 46)
        Me.fttCNPJ.Name = "fttCNPJ"
        Me.fttCNPJ.Size = New System.Drawing.Size(167, 20)
        Me.fttCNPJ.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fttMatr)
        Me.GroupBox1.Controls.Add(Me.btnFiltro)
        Me.GroupBox1.Controls.Add(Me.fttProduto)
        Me.GroupBox1.Controls.Add(Me.fttCNPJ)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.fttCPF)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fttNome)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 82)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolha uma ou mais opções"
        '
        'fttMatr
        '
        Me.fttMatr.Location = New System.Drawing.Point(456, 19)
        Me.fttMatr.Name = "fttMatr"
        Me.fttMatr.Size = New System.Drawing.Size(67, 20)
        Me.fttMatr.TabIndex = 8
        '
        'btnFiltro
        '
        Me.btnFiltro.Location = New System.Drawing.Point(808, 46)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(103, 26)
        Me.btnFiltro.TabIndex = 7
        Me.btnFiltro.Text = "Buscar"
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'pnlBoletos
        '
        Me.pnlBoletos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBoletos.Location = New System.Drawing.Point(0, 82)
        Me.pnlBoletos.Name = "pnlBoletos"
        Me.pnlBoletos.Size = New System.Drawing.Size(846, 495)
        Me.pnlBoletos.TabIndex = 8
        Me.pnlBoletos.TabStop = False
        Me.pnlBoletos.Text = "Boletos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEmitBolFiltr)
        Me.GroupBox2.Controls.Add(Me.btnBoleto)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(846, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 495)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operações"
        '
        'btnEmitBolFiltr
        '
        Me.btnEmitBolFiltr.Location = New System.Drawing.Point(6, 67)
        Me.btnEmitBolFiltr.Name = "btnEmitBolFiltr"
        Me.btnEmitBolFiltr.Size = New System.Drawing.Size(84, 41)
        Me.btnEmitBolFiltr.TabIndex = 0
        Me.btnEmitBolFiltr.Text = "Emitir Boletos Filtrados"
        Me.btnEmitBolFiltr.UseVisualStyleBackColor = True
        '
        'btnBoleto
        '
        Me.btnBoleto.Location = New System.Drawing.Point(7, 20)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(84, 41)
        Me.btnBoleto.TabIndex = 0
        Me.btnBoleto.Text = "Emitir Boleto Atual"
        Me.btnBoleto.UseVisualStyleBackColor = True
        '
        'frmBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 577)
        Me.Controls.Add(Me.pnlBoletos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBoleto"
        Me.Text = "Boletos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fttProduto As System.Windows.Forms.ComboBox
    Friend WithEvents fttNome As System.Windows.Forms.TextBox
    Friend WithEvents fttCPF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fttCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltro As System.Windows.Forms.Button
    Friend WithEvents pnlBoletos As System.Windows.Forms.GroupBox
    Friend WithEvents fttMatr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBoleto As System.Windows.Forms.Button
    Friend WithEvents btnEmitBolFiltr As System.Windows.Forms.Button
End Class
