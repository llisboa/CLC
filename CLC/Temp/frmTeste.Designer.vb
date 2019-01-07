<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeste
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
        Me.grdPrinc = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnAtualiza = New System.Windows.Forms.Button
        Me.txtImporta = New System.Windows.Forms.TextBox
        Me.btnImporta = New System.Windows.Forms.Button
        CType(Me.grdPrinc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPrinc
        '
        Me.grdPrinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPrinc.Location = New System.Drawing.Point(0, 54)
        Me.grdPrinc.Name = "grdPrinc"
        Me.grdPrinc.Size = New System.Drawing.Size(415, 289)
        Me.grdPrinc.TabIndex = 0
        Me.grdPrinc.Tag = "Redim:True"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAtualiza)
        Me.Panel1.Controls.Add(Me.txtImporta)
        Me.Panel1.Controls.Add(Me.btnImporta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 48)
        Me.Panel1.TabIndex = 1
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Location = New System.Drawing.Point(341, 13)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(62, 23)
        Me.btnAtualiza.TabIndex = 2
        Me.btnAtualiza.Text = "Atualizar"
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'txtImporta
        '
        Me.txtImporta.Location = New System.Drawing.Point(12, 12)
        Me.txtImporta.Name = "txtImporta"
        Me.txtImporta.Size = New System.Drawing.Size(242, 20)
        Me.txtImporta.TabIndex = 1
        '
        'btnImporta
        '
        Me.btnImporta.Location = New System.Drawing.Point(265, 12)
        Me.btnImporta.Name = "btnImporta"
        Me.btnImporta.Size = New System.Drawing.Size(62, 23)
        Me.btnImporta.TabIndex = 0
        Me.btnImporta.Text = "Importar"
        Me.btnImporta.UseVisualStyleBackColor = True
        '
        'frmImporta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 342)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdPrinc)
        Me.Name = "frmImporta"
        Me.Text = "frmImporta"
        CType(Me.grdPrinc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPrinc As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtImporta As System.Windows.Forms.TextBox
    Friend WithEvents btnImporta As System.Windows.Forms.Button
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
End Class
