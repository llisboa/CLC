<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaDataSets
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
        Me.TXTDIR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXTEXTENSAO = New System.Windows.Forms.TextBox
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BTNSALVAR = New System.Windows.Forms.Button
        Me.TABS = New System.Windows.Forms.ListBox
        Me.BTNBUSCA = New System.Windows.Forms.Button
        Me.ARQS = New System.Windows.Forms.ListBox
        Me.TAB = New Icraft.IcftFGridBas
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnVoltar = New System.Windows.Forms.Button
        Me.btnGravarnaBase = New System.Windows.Forms.Button
        Me.GRAV = New Icraft.IcftFGridBas
        Me.btnMover = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTDIR
        '
        Me.TXTDIR.Location = New System.Drawing.Point(65, 8)
        Me.TXTDIR.Name = "TXTDIR"
        Me.TXTDIR.Size = New System.Drawing.Size(352, 20)
        Me.TXTDIR.TabIndex = 0
        Me.TXTDIR.Text = "C:\COLETOR\10.50.0.71\Docs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Diretório"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Máscara"
        '
        'TXTEXTENSAO
        '
        Me.TXTEXTENSAO.Location = New System.Drawing.Point(504, 8)
        Me.TXTEXTENSAO.Name = "TXTEXTENSAO"
        Me.TXTEXTENSAO.Size = New System.Drawing.Size(61, 20)
        Me.TXTEXTENSAO.TabIndex = 2
        Me.TXTEXTENSAO.Text = "*.DSN"
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(522, 123)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(99, 24)
        Me.btnCarregar.TabIndex = 4
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BTNSALVAR)
        Me.Panel1.Controls.Add(Me.TABS)
        Me.Panel1.Controls.Add(Me.BTNBUSCA)
        Me.Panel1.Controls.Add(Me.ARQS)
        Me.Panel1.Controls.Add(Me.btnCarregar)
        Me.Panel1.Controls.Add(Me.TXTDIR)
        Me.Panel1.Controls.Add(Me.TXTEXTENSAO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 167)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(519, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tabelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Arquivos"
        '
        'BTNSALVAR
        '
        Me.BTNSALVAR.Location = New System.Drawing.Point(630, 123)
        Me.BTNSALVAR.Name = "BTNSALVAR"
        Me.BTNSALVAR.Size = New System.Drawing.Size(99, 24)
        Me.BTNSALVAR.TabIndex = 8
        Me.BTNSALVAR.Text = "Salvar"
        Me.BTNSALVAR.UseVisualStyleBackColor = True
        '
        'TABS
        '
        Me.TABS.FormattingEnabled = True
        Me.TABS.Location = New System.Drawing.Point(522, 53)
        Me.TABS.Name = "TABS"
        Me.TABS.Size = New System.Drawing.Size(207, 56)
        Me.TABS.TabIndex = 7
        '
        'BTNBUSCA
        '
        Me.BTNBUSCA.Location = New System.Drawing.Point(591, 6)
        Me.BTNBUSCA.Name = "BTNBUSCA"
        Me.BTNBUSCA.Size = New System.Drawing.Size(136, 24)
        Me.BTNBUSCA.TabIndex = 6
        Me.BTNBUSCA.Text = "Procurar Arquivos"
        Me.BTNBUSCA.UseVisualStyleBackColor = True
        '
        'ARQS
        '
        Me.ARQS.FormattingEnabled = True
        Me.ARQS.Location = New System.Drawing.Point(15, 53)
        Me.ARQS.Name = "ARQS"
        Me.ARQS.Size = New System.Drawing.Size(488, 95)
        Me.ARQS.TabIndex = 5
        '
        'TAB
        '
        Me.TAB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TAB.Location = New System.Drawing.Point(0, 167)
        Me.TAB.Name = "TAB"
        Me.TAB.Size = New System.Drawing.Size(736, 135)
        Me.TAB.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnMover)
        Me.Panel2.Controls.Add(Me.btnVoltar)
        Me.Panel2.Controls.Add(Me.btnGravarnaBase)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 34)
        Me.Panel2.TabIndex = 8
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Location = New System.Drawing.Point(337, 7)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(127, 24)
        Me.btnVoltar.TabIndex = 11
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        Me.btnVoltar.Visible = False
        '
        'btnGravarnaBase
        '
        Me.btnGravarnaBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravarnaBase.Location = New System.Drawing.Point(603, 6)
        Me.btnGravarnaBase.Name = "btnGravarnaBase"
        Me.btnGravarnaBase.Size = New System.Drawing.Size(127, 24)
        Me.btnGravarnaBase.TabIndex = 10
        Me.btnGravarnaBase.Text = "Gravar na Base"
        Me.btnGravarnaBase.UseVisualStyleBackColor = True
        '
        'GRAV
        '
        Me.GRAV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRAV.Location = New System.Drawing.Point(0, 167)
        Me.GRAV.Name = "GRAV"
        Me.GRAV.Size = New System.Drawing.Size(736, 135)
        Me.GRAV.TabIndex = 9
        Me.GRAV.Visible = False
        '
        'btnMover
        '
        Me.btnMover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMover.Location = New System.Drawing.Point(470, 6)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(127, 24)
        Me.btnMover.TabIndex = 12
        Me.btnMover.Text = "Mover"
        Me.btnMover.UseVisualStyleBackColor = True
        '
        'frmCargaDataSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 336)
        Me.Controls.Add(Me.GRAV)
        Me.Controls.Add(Me.TAB)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaDataSets"
        Me.Text = "Carga de Arquivos Criados pelos Coletores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTDIR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTEXTENSAO As System.Windows.Forms.TextBox
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TAB As Icraft.IcftFGridBas
    Friend WithEvents BTNBUSCA As System.Windows.Forms.Button
    Friend WithEvents ARQS As System.Windows.Forms.ListBox
    Friend WithEvents TABS As System.Windows.Forms.ListBox
    Friend WithEvents BTNSALVAR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnGravarnaBase As System.Windows.Forms.Button
    Friend WithEvents GRAV As Icraft.IcftFGridBas
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnMover As System.Windows.Forms.Button
End Class
