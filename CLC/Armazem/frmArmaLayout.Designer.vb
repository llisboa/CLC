<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmaLayout
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
        Me.txtArm = New System.Windows.Forms.ComboBox
        Me.txtGalpa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlTopo = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnDimensoes = New System.Windows.Forms.Button
        Me.btnSelTodos = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.pnlLayout = New System.Windows.Forms.Panel
        Me.pnlTopo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtArm
        '
        Me.txtArm.FormattingEnabled = True
        Me.txtArm.Location = New System.Drawing.Point(63, 12)
        Me.txtArm.Name = "txtArm"
        Me.txtArm.Size = New System.Drawing.Size(214, 21)
        Me.txtArm.TabIndex = 0
        '
        'txtGalpa
        '
        Me.txtGalpa.FormattingEnabled = True
        Me.txtGalpa.Location = New System.Drawing.Point(327, 12)
        Me.txtGalpa.Name = "txtGalpa"
        Me.txtGalpa.Size = New System.Drawing.Size(214, 21)
        Me.txtGalpa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Armazém"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Galpão"
        '
        'pnlTopo
        '
        Me.pnlTopo.Controls.Add(Me.Label3)
        Me.pnlTopo.Controls.Add(Me.Button1)
        Me.pnlTopo.Controls.Add(Me.btnDimensoes)
        Me.pnlTopo.Controls.Add(Me.btnSelTodos)
        Me.pnlTopo.Controls.Add(Me.btnSalvar)
        Me.pnlTopo.Controls.Add(Me.btnCarregar)
        Me.pnlTopo.Controls.Add(Me.txtArm)
        Me.pnlTopo.Controls.Add(Me.txtGalpa)
        Me.pnlTopo.Controls.Add(Me.Label1)
        Me.pnlTopo.Controls.Add(Me.Label2)
        Me.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopo.Name = "pnlTopo"
        Me.pnlTopo.Size = New System.Drawing.Size(705, 75)
        Me.pnlTopo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Para praças selecionadas, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "relatório de..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Etiquetas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDimensoes
        '
        Me.btnDimensoes.Location = New System.Drawing.Point(469, 42)
        Me.btnDimensoes.Name = "btnDimensoes"
        Me.btnDimensoes.Size = New System.Drawing.Size(82, 21)
        Me.btnDimensoes.TabIndex = 8
        Me.btnDimensoes.Text = "Dimensões"
        Me.btnDimensoes.UseVisualStyleBackColor = True
        '
        'btnSelTodos
        '
        Me.btnSelTodos.Location = New System.Drawing.Point(89, 42)
        Me.btnSelTodos.Name = "btnSelTodos"
        Me.btnSelTodos.Size = New System.Drawing.Size(101, 21)
        Me.btnSelTodos.TabIndex = 7
        Me.btnSelTodos.Text = "Selecionar Todos"
        Me.btnSelTodos.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(15, 42)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 21)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(571, 12)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(68, 21)
        Me.btnCarregar.TabIndex = 6
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'pnlLayout
        '
        Me.pnlLayout.AutoScroll = True
        Me.pnlLayout.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLayout.Location = New System.Drawing.Point(0, 75)
        Me.pnlLayout.Name = "pnlLayout"
        Me.pnlLayout.Size = New System.Drawing.Size(705, 382)
        Me.pnlLayout.TabIndex = 7
        Me.pnlLayout.Tag = ""
        '
        'frmArmaLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 457)
        Me.Controls.Add(Me.pnlLayout)
        Me.Controls.Add(Me.pnlTopo)
        Me.Name = "frmArmaLayout"
        Me.Text = "Layout de Armazém"
        Me.pnlTopo.ResumeLayout(False)
        Me.pnlTopo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtArm As System.Windows.Forms.ComboBox
    Friend WithEvents txtGalpa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTopo As System.Windows.Forms.Panel
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents pnlLayout As System.Windows.Forms.Panel
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSelTodos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDimensoes As System.Windows.Forms.Button
End Class
