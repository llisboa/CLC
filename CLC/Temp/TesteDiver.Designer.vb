﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TesteDiver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TesteDiver))
        Me.txtArq = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEscolher = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnConf = New System.Windows.Forms.Button
        Me.btnRecup = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtArq
        '
        Me.txtArq.Location = New System.Drawing.Point(140, 12)
        Me.txtArq.Name = "txtArq"
        Me.txtArq.Size = New System.Drawing.Size(414, 20)
        Me.txtArq.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Schema Dir"
        '
        'btnEscolher
        '
        Me.btnEscolher.Location = New System.Drawing.Point(560, 10)
        Me.btnEscolher.Name = "btnEscolher"
        Me.btnEscolher.Size = New System.Drawing.Size(75, 23)
        Me.btnEscolher.TabIndex = 2
        Me.btnEscolher.Text = "Escolher"
        Me.btnEscolher.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(595, 9)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(560, 38)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnConf)
        Me.Panel1.Controls.Add(Me.btnRecup)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 39)
        Me.Panel1.TabIndex = 3
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(12, 9)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(75, 23)
        Me.btnConf.TabIndex = 2
        Me.btnConf.Text = "Confirmar"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'btnRecup
        '
        Me.btnRecup.Location = New System.Drawing.Point(499, 9)
        Me.btnRecup.Name = "btnRecup"
        Me.btnRecup.Size = New System.Drawing.Size(75, 23)
        Me.btnRecup.TabIndex = 2
        Me.btnRecup.Text = "Recuperar"
        Me.btnRecup.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Controls.Add(Me.btnEscolher)
        Me.Panel2.Controls.Add(Me.txtArq)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 75)
        Me.Panel2.TabIndex = 4
        '
        'TesteDiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 389)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TesteDiver"
        Me.Text = "Teste"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtArq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEscolher As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dlg As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents btnRecup As System.Windows.Forms.Button
End Class
