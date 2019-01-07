<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChecarNF
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
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCheck = New System.Windows.Forms.Label
        Me.btnManda = New System.Windows.Forms.Button
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAtualiza = New System.Windows.Forms.Button
        Me.lblMaxMin = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(451, 550)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnEnviar)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.btnManda)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnAtualiza)
        Me.TabPage1.Controls.Add(Me.lblMaxMin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(443, 524)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Checagem de Notas Fiscais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblCheck)
        Me.Panel1.Location = New System.Drawing.Point(17, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 379)
        Me.Panel1.TabIndex = 14
        '
        'lblCheck
        '
        Me.lblCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCheck.Location = New System.Drawing.Point(12, 12)
        Me.lblCheck.MinimumSize = New System.Drawing.Size(325, 336)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(325, 336)
        Me.lblCheck.TabIndex = 13
        Me.lblCheck.Text = "Resultado:"
        '
        'btnManda
        '
        Me.btnManda.Location = New System.Drawing.Point(677, 429)
        Me.btnManda.Name = "btnManda"
        Me.btnManda.Size = New System.Drawing.Size(91, 23)
        Me.btnManda.TabIndex = 5
        Me.btnManda.Text = "Enviar"
        Me.btnManda.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(17, 491)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Informe seu E-mail:"
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Location = New System.Drawing.Point(266, 15)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(111, 50)
        Me.btnAtualiza.TabIndex = 1
        Me.btnAtualiza.Text = "Atualizar"
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'lblMaxMin
        '
        Me.lblMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxMin.Location = New System.Drawing.Point(17, 15)
        Me.lblMaxMin.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lblMaxMin.Name = "lblMaxMin"
        Me.lblMaxMin.Size = New System.Drawing.Size(219, 50)
        Me.lblMaxMin.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(305, 488)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 14
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'ChecarNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 574)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ChecarNF"
        Me.Text = "Checar sequência de notas fiscais"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnManda As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
    Friend WithEvents lblMaxMin As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
End Class
