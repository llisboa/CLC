<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmCriaDataset
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
        Me.FLDESQUEMA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FLDTABELA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FLDARQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FLDDIRETORIO = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.FLDREL = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'FLDESQUEMA
        '
        Me.FLDESQUEMA.Location = New System.Drawing.Point(99, 12)
        Me.FLDESQUEMA.Name = "FLDESQUEMA"
        Me.FLDESQUEMA.Size = New System.Drawing.Size(100, 20)
        Me.FLDESQUEMA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Esquema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome:Tabela ou SQL;Nome2:Tabela2 ou SQL2"
        '
        'FLDTABELA
        '
        Me.FLDTABELA.Location = New System.Drawing.Point(34, 59)
        Me.FLDTABELA.Multiline = True
        Me.FLDTABELA.Name = "FLDTABELA"
        Me.FLDTABELA.Size = New System.Drawing.Size(542, 103)
        Me.FLDTABELA.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Arq"
        '
        'FLDARQ
        '
        Me.FLDARQ.Location = New System.Drawing.Point(119, 284)
        Me.FLDARQ.Name = "FLDARQ"
        Me.FLDARQ.Size = New System.Drawing.Size(309, 20)
        Me.FLDARQ.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Diretório"
        '
        'FLDDIRETORIO
        '
        Me.FLDDIRETORIO.Location = New System.Drawing.Point(119, 310)
        Me.FLDDIRETORIO.Name = "FLDDIRETORIO"
        Me.FLDDIRETORIO.Size = New System.Drawing.Size(309, 20)
        Me.FLDDIRETORIO.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(511, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Criar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(511, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FLDREL
        '
        Me.FLDREL.Location = New System.Drawing.Point(33, 191)
        Me.FLDREL.Multiline = True
        Me.FLDREL.Name = "FLDREL"
        Me.FLDREL.Size = New System.Drawing.Size(543, 71)
        Me.FLDREL.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(368, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Relaciona: Nome1(N1Campo1+N1Campo2);Nome2(N2Campo1+N2Campo2)"
        '
        'frmCriaDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FLDDIRETORIO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FLDARQ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FLDREL)
        Me.Controls.Add(Me.FLDTABELA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FLDESQUEMA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriaDataset"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facilitador... Cria dataset para relatórios."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FLDESQUEMA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FLDTABELA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FLDARQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FLDDIRETORIO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FLDREL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
