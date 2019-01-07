<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodBarras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodBarras))
        Me.btnVer = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtExt = New System.Windows.Forms.ComboBox
        Me.txtTipo = New System.Windows.Forms.ComboBox
        Me.txtTxt = New System.Windows.Forms.TextBox
        Me.imgCodB = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.imgCodB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(46, 141)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(104, 23)
        Me.btnVer.TabIndex = 0
        Me.btnVer.Text = "Ver Cod Barras"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Extensão"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Texto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo"
        '
        'txtExt
        '
        Me.txtExt.FormattingEnabled = True
        Me.txtExt.Location = New System.Drawing.Point(124, 22)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(74, 21)
        Me.txtExt.TabIndex = 2
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Location = New System.Drawing.Point(124, 93)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(194, 21)
        Me.txtTipo.TabIndex = 3
        '
        'txtTxt
        '
        Me.txtTxt.Location = New System.Drawing.Point(124, 59)
        Me.txtTxt.Name = "txtTxt"
        Me.txtTxt.Size = New System.Drawing.Size(293, 20)
        Me.txtTxt.TabIndex = 4
        '
        'imgCodB
        '
        Me.imgCodB.Location = New System.Drawing.Point(124, 190)
        Me.imgCodB.Name = "imgCodB"
        Me.imgCodB.Size = New System.Drawing.Size(462, 50)
        Me.imgCodB.TabIndex = 5
        Me.imgCodB.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'CodBarras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 290)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.imgCodB)
        Me.Controls.Add(Me.txtTxt)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVer)
        Me.Name = "CodBarras"
        Me.Text = "CodBarras"
        CType(Me.imgCodB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExt As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTxt As System.Windows.Forms.TextBox
    Friend WithEvents imgCodB As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
