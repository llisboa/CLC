<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorico
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
        Me.btnCriacao = New System.Windows.Forms.Button
        Me.tabHistorico = New System.Windows.Forms.TabControl
        Me.tabCria = New System.Windows.Forms.TabPage
        Me.frameCria = New System.Windows.Forms.GroupBox
        Me.txtCria_Momento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCria_Local = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCria_Usuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabAtt = New System.Windows.Forms.TabPage
        Me.frameAtt = New System.Windows.Forms.GroupBox
        Me.btnAtt = New System.Windows.Forms.Button
        Me.txtAtt_Momento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAtt_Local = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAtt_Usuario = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblIdentif = New System.Windows.Forms.Label
        Me.tabHistorico.SuspendLayout()
        Me.tabCria.SuspendLayout()
        Me.frameCria.SuspendLayout()
        Me.TabAtt.SuspendLayout()
        Me.frameAtt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCriacao
        '
        Me.btnCriacao.Location = New System.Drawing.Point(92, 140)
        Me.btnCriacao.Name = "btnCriacao"
        Me.btnCriacao.Size = New System.Drawing.Size(115, 25)
        Me.btnCriacao.TabIndex = 0
        Me.btnCriacao.Text = "Visualizar Criação"
        Me.btnCriacao.UseVisualStyleBackColor = True
        '
        'tabHistorico
        '
        Me.tabHistorico.Controls.Add(Me.tabCria)
        Me.tabHistorico.Controls.Add(Me.TabAtt)
        Me.tabHistorico.Location = New System.Drawing.Point(12, 40)
        Me.tabHistorico.Name = "tabHistorico"
        Me.tabHistorico.SelectedIndex = 0
        Me.tabHistorico.Size = New System.Drawing.Size(351, 260)
        Me.tabHistorico.TabIndex = 9
        '
        'tabCria
        '
        Me.tabCria.Controls.Add(Me.frameCria)
        Me.tabCria.Location = New System.Drawing.Point(4, 22)
        Me.tabCria.Name = "tabCria"
        Me.tabCria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCria.Size = New System.Drawing.Size(343, 234)
        Me.tabCria.TabIndex = 0
        Me.tabCria.Text = "Momento de Criação"
        Me.tabCria.UseVisualStyleBackColor = True
        '
        'frameCria
        '
        Me.frameCria.Controls.Add(Me.txtCria_Momento)
        Me.frameCria.Controls.Add(Me.Label1)
        Me.frameCria.Controls.Add(Me.txtCria_Local)
        Me.frameCria.Controls.Add(Me.btnCriacao)
        Me.frameCria.Controls.Add(Me.Label3)
        Me.frameCria.Controls.Add(Me.txtCria_Usuario)
        Me.frameCria.Controls.Add(Me.Label2)
        Me.frameCria.Location = New System.Drawing.Point(20, 29)
        Me.frameCria.Name = "frameCria"
        Me.frameCria.Size = New System.Drawing.Size(300, 180)
        Me.frameCria.TabIndex = 8
        Me.frameCria.TabStop = False
        Me.frameCria.Text = "Visualizando histórico de Criação"
        '
        'txtCria_Momento
        '
        Me.txtCria_Momento.Location = New System.Drawing.Point(110, 30)
        Me.txtCria_Momento.Name = "txtCria_Momento"
        Me.txtCria_Momento.Size = New System.Drawing.Size(140, 20)
        Me.txtCria_Momento.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Momento"
        '
        'txtCria_Local
        '
        Me.txtCria_Local.Location = New System.Drawing.Point(110, 105)
        Me.txtCria_Local.Name = "txtCria_Local"
        Me.txtCria_Local.Size = New System.Drawing.Size(140, 20)
        Me.txtCria_Local.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Local"
        '
        'txtCria_Usuario
        '
        Me.txtCria_Usuario.Location = New System.Drawing.Point(110, 70)
        Me.txtCria_Usuario.Name = "txtCria_Usuario"
        Me.txtCria_Usuario.Size = New System.Drawing.Size(140, 20)
        Me.txtCria_Usuario.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Usuário"
        '
        'TabAtt
        '
        Me.TabAtt.Controls.Add(Me.frameAtt)
        Me.TabAtt.Location = New System.Drawing.Point(4, 22)
        Me.TabAtt.Name = "TabAtt"
        Me.TabAtt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAtt.Size = New System.Drawing.Size(343, 234)
        Me.TabAtt.TabIndex = 1
        Me.TabAtt.Text = "Momento de Atualização"
        Me.TabAtt.UseVisualStyleBackColor = True
        '
        'frameAtt
        '
        Me.frameAtt.Controls.Add(Me.btnAtt)
        Me.frameAtt.Controls.Add(Me.txtAtt_Momento)
        Me.frameAtt.Controls.Add(Me.Label4)
        Me.frameAtt.Controls.Add(Me.txtAtt_Local)
        Me.frameAtt.Controls.Add(Me.Label5)
        Me.frameAtt.Controls.Add(Me.txtAtt_Usuario)
        Me.frameAtt.Controls.Add(Me.Label6)
        Me.frameAtt.Location = New System.Drawing.Point(20, 20)
        Me.frameAtt.Name = "frameAtt"
        Me.frameAtt.Size = New System.Drawing.Size(300, 180)
        Me.frameAtt.TabIndex = 15
        Me.frameAtt.TabStop = False
        Me.frameAtt.Text = "Visualizando histórico de Atualização"
        '
        'btnAtt
        '
        Me.btnAtt.Location = New System.Drawing.Point(92, 140)
        Me.btnAtt.Name = "btnAtt"
        Me.btnAtt.Size = New System.Drawing.Size(115, 25)
        Me.btnAtt.TabIndex = 15
        Me.btnAtt.Text = "Última Atualização"
        Me.btnAtt.UseVisualStyleBackColor = True
        '
        'txtAtt_Momento
        '
        Me.txtAtt_Momento.Location = New System.Drawing.Point(110, 30)
        Me.txtAtt_Momento.Name = "txtAtt_Momento"
        Me.txtAtt_Momento.Size = New System.Drawing.Size(140, 20)
        Me.txtAtt_Momento.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Momento"
        '
        'txtAtt_Local
        '
        Me.txtAtt_Local.Location = New System.Drawing.Point(110, 105)
        Me.txtAtt_Local.Name = "txtAtt_Local"
        Me.txtAtt_Local.Size = New System.Drawing.Size(140, 20)
        Me.txtAtt_Local.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Local"
        '
        'txtAtt_Usuario
        '
        Me.txtAtt_Usuario.Location = New System.Drawing.Point(110, 70)
        Me.txtAtt_Usuario.Name = "txtAtt_Usuario"
        Me.txtAtt_Usuario.Size = New System.Drawing.Size(140, 20)
        Me.txtAtt_Usuario.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Usuário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Identif."
        '
        'lblIdentif
        '
        Me.lblIdentif.AutoSize = True
        Me.lblIdentif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentif.Location = New System.Drawing.Point(76, 9)
        Me.lblIdentif.Name = "lblIdentif"
        Me.lblIdentif.Size = New System.Drawing.Size(0, 16)
        Me.lblIdentif.TabIndex = 10
        '
        'frmHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 333)
        Me.Controls.Add(Me.lblIdentif)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tabHistorico)
        Me.Name = "frmHistorico"
        Me.Text = "Histórico"
        Me.tabHistorico.ResumeLayout(False)
        Me.tabCria.ResumeLayout(False)
        Me.frameCria.ResumeLayout(False)
        Me.frameCria.PerformLayout()
        Me.TabAtt.ResumeLayout(False)
        Me.frameAtt.ResumeLayout(False)
        Me.frameAtt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCriacao As System.Windows.Forms.Button
    Friend WithEvents tabHistorico As System.Windows.Forms.TabControl
    Friend WithEvents TabAtt As System.Windows.Forms.TabPage
    Friend WithEvents btnAtt As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblIdentif As System.Windows.Forms.Label
    Friend WithEvents tabCria As System.Windows.Forms.TabPage
    Friend WithEvents frameCria As System.Windows.Forms.GroupBox
    Friend WithEvents txtCria_Momento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCria_Local As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCria_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents frameAtt As System.Windows.Forms.GroupBox
    Friend WithEvents txtAtt_Momento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAtt_Local As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAtt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class