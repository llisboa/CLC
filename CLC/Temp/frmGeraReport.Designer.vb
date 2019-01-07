<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeraReport
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
        Me.FLDRELBASE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.FLDRELDESTINO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FLDDIR = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FLDARQDS = New System.Windows.Forms.TextBox
        Me.btnGerar = New System.Windows.Forms.Button
        Me.FLDTIPO = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Informe Relatório Base"
        '
        'FLDRELBASE
        '
        Me.FLDRELBASE.Location = New System.Drawing.Point(181, 43)
        Me.FLDRELBASE.Name = "FLDRELBASE"
        Me.FLDRELBASE.Size = New System.Drawing.Size(345, 20)
        Me.FLDRELBASE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Relatório Destino"
        '
        'FLDRELDESTINO
        '
        Me.FLDRELDESTINO.Location = New System.Drawing.Point(181, 69)
        Me.FLDRELDESTINO.Name = "FLDRELDESTINO"
        Me.FLDRELDESTINO.Size = New System.Drawing.Size(345, 20)
        Me.FLDRELDESTINO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Diretório"
        '
        'FLDDIR
        '
        Me.FLDDIR.Location = New System.Drawing.Point(181, 15)
        Me.FLDDIR.Name = "FLDDIR"
        Me.FLDDIR.Size = New System.Drawing.Size(345, 20)
        Me.FLDDIR.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Arquivo DS"
        '
        'FLDARQDS
        '
        Me.FLDARQDS.Location = New System.Drawing.Point(181, 95)
        Me.FLDARQDS.Name = "FLDARQDS"
        Me.FLDARQDS.Size = New System.Drawing.Size(345, 20)
        Me.FLDARQDS.TabIndex = 7
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(455, 188)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(107, 23)
        Me.btnGerar.TabIndex = 8
        Me.btnGerar.Text = "Gerar Relatório"
        Me.btnGerar.UseVisualStyleBackColor = True
        '
        'FLDTIPO
        '
        Me.FLDTIPO.FormattingEnabled = True
        Me.FLDTIPO.Items.AddRange(New Object() {"Tabular", "Colunar"})
        Me.FLDTIPO.Location = New System.Drawing.Point(108, 137)
        Me.FLDTIPO.Name = "FLDTIPO"
        Me.FLDTIPO.Size = New System.Drawing.Size(121, 21)
        Me.FLDTIPO.TabIndex = 9
        Me.FLDTIPO.Text = "Tabular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo"
        '
        'frmGeraReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 250)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FLDTIPO)
        Me.Controls.Add(Me.btnGerar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FLDARQDS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FLDDIR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FLDRELDESTINO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FLDRELBASE)
        Me.Name = "frmGeraReport"
        Me.Text = "Facilitador.. Gerador de relatório"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FLDRELBASE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FLDRELDESTINO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FLDDIR As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FLDARQDS As System.Windows.Forms.TextBox
    Friend WithEvents btnGerar As System.Windows.Forms.Button
    Friend WithEvents FLDTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
