<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerRestr
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
        Me.pnlGeral = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnEmitBolFiltr = New System.Windows.Forms.Button
        Me.btnBoleto = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGeral
        '
        Me.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGeral.Name = "pnlGeral"
        Me.pnlGeral.Padding = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.pnlGeral.Size = New System.Drawing.Size(735, 519)
        Me.pnlGeral.TabIndex = 10
        Me.pnlGeral.TabStop = False
        Me.pnlGeral.Text = "Registros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEmitBolFiltr)
        Me.GroupBox2.Controls.Add(Me.btnBoleto)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(735, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 519)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operações"
        '
        'btnEmitBolFiltr
        '
        Me.btnEmitBolFiltr.Location = New System.Drawing.Point(6, 67)
        Me.btnEmitBolFiltr.Name = "btnEmitBolFiltr"
        Me.btnEmitBolFiltr.Size = New System.Drawing.Size(84, 41)
        Me.btnEmitBolFiltr.TabIndex = 0
        Me.btnEmitBolFiltr.Text = "Atualizar Todos"
        Me.btnEmitBolFiltr.UseVisualStyleBackColor = True
        '
        'btnBoleto
        '
        Me.btnBoleto.Location = New System.Drawing.Point(7, 20)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(84, 41)
        Me.btnBoleto.TabIndex = 0
        Me.btnBoleto.Text = "Atualizar Base de Dados"
        Me.btnBoleto.UseVisualStyleBackColor = True
        '
        'frmVerRestr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 519)
        Me.Controls.Add(Me.pnlGeral)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmVerRestr"
        Me.Text = "Configuração de Restrições"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlGeral As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmitBolFiltr As System.Windows.Forms.Button
    Friend WithEvents btnBoleto As System.Windows.Forms.Button
End Class
