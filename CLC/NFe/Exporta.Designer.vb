<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exporta
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
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.btnDir = New System.Windows.Forms.Button
        Me.fldOpen = New System.Windows.Forms.FolderBrowserDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSerie = New System.Windows.Forms.TextBox
        Me.txtNotaInicio = New System.Windows.Forms.TextBox
        Me.txtNotaFim = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExec = New System.Windows.Forms.Button
        Me.grd = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTot = New System.Windows.Forms.Label
        Me.btnVerNoWinMerge = New System.Windows.Forms.Button
        Me.txtOrig = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtProg = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.btnConf = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEmissor = New System.Windows.Forms.ComboBox
        Me.TXTVERNORM = New System.Windows.Forms.CheckBox
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diretório"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(119, 13)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(163, 20)
        Me.txtDir.TabIndex = 1
        '
        'btnDir
        '
        Me.btnDir.Location = New System.Drawing.Point(303, 12)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(29, 20)
        Me.btnDir.TabIndex = 2
        Me.btnDir.Text = "..."
        Me.btnDir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Início"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(119, 87)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(34, 20)
        Me.txtSerie.TabIndex = 6
        '
        'txtNotaInicio
        '
        Me.txtNotaInicio.Location = New System.Drawing.Point(171, 87)
        Me.txtNotaInicio.Name = "txtNotaInicio"
        Me.txtNotaInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtNotaInicio.TabIndex = 7
        '
        'txtNotaFim
        '
        Me.txtNotaFim.Location = New System.Drawing.Point(171, 113)
        Me.txtNotaFim.Name = "txtNotaFim"
        Me.txtNotaFim.Size = New System.Drawing.Size(83, 20)
        Me.txtNotaFim.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Término"
        '
        'btnExec
        '
        Me.btnExec.Location = New System.Drawing.Point(287, 111)
        Me.btnExec.Name = "btnExec"
        Me.btnExec.Size = New System.Drawing.Size(75, 23)
        Me.btnExec.TabIndex = 10
        Me.btnExec.Text = "Executar"
        Me.btnExec.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.AllowUserToAddRows = False
        Me.grd.AllowUserToDeleteRows = False
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(27, 177)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(692, 182)
        Me.grd.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Arquivos criados"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(27, 362)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(128, 13)
        Me.lblTot.TabIndex = 15
        Me.lblTot.Text = "Selecione linha e escolha"
        '
        'btnVerNoWinMerge
        '
        Me.btnVerNoWinMerge.Location = New System.Drawing.Point(303, 365)
        Me.btnVerNoWinMerge.Name = "btnVerNoWinMerge"
        Me.btnVerNoWinMerge.Size = New System.Drawing.Size(125, 23)
        Me.btnVerNoWinMerge.TabIndex = 16
        Me.btnVerNoWinMerge.Text = "Visualizar Comparação"
        Me.btnVerNoWinMerge.UseVisualStyleBackColor = True
        '
        'txtOrig
        '
        Me.txtOrig.Location = New System.Drawing.Point(430, 71)
        Me.txtOrig.Name = "txtOrig"
        Me.txtOrig.Size = New System.Drawing.Size(237, 20)
        Me.txtOrig.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Para arquivo original, considerar ~/ (home) como:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Programa de comparação:"
        '
        'txtProg
        '
        Me.txtProg.Location = New System.Drawing.Point(431, 25)
        Me.txtProg.Name = "txtProg"
        Me.txtProg.Size = New System.Drawing.Size(237, 20)
        Me.txtProg.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Diretório temporário:"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(430, 114)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(237, 20)
        Me.txtTemp.TabIndex = 13
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(434, 365)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(143, 23)
        Me.btnConf.TabIndex = 17
        Me.btnConf.Text = "Conferência Automática"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Emissor"
        '
        'txtEmissor
        '
        Me.txtEmissor.FormattingEnabled = True
        Me.txtEmissor.Location = New System.Drawing.Point(119, 59)
        Me.txtEmissor.Name = "txtEmissor"
        Me.txtEmissor.Size = New System.Drawing.Size(163, 21)
        Me.txtEmissor.TabIndex = 4
        '
        'TXTVERNORM
        '
        Me.TXTVERNORM.AutoSize = True
        Me.TXTVERNORM.Location = New System.Drawing.Point(597, 365)
        Me.TXTVERNORM.Name = "TXTVERNORM"
        Me.TXTVERNORM.Size = New System.Drawing.Size(122, 30)
        Me.TXTVERNORM.TabIndex = 18
        Me.TXTVERNORM.Text = "Atualiza original com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "versão normalizada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TXTVERNORM.UseVisualStyleBackColor = True
        '
        'Exporta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 405)
        Me.Controls.Add(Me.TXTVERNORM)
        Me.Controls.Add(Me.txtEmissor)
        Me.Controls.Add(Me.txtProg)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.txtOrig)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.btnVerNoWinMerge)
        Me.Controls.Add(Me.btnExec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotaFim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNotaInicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.btnDir)
        Me.Name = "Exporta"
        Me.Text = "Exportação de Notas Fiscais - Criação de XML"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents btnDir As System.Windows.Forms.Button
    Friend WithEvents fldOpen As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtNotaInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtNotaFim As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExec As System.Windows.Forms.Button
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents btnVerNoWinMerge As System.Windows.Forms.Button
    Friend WithEvents txtOrig As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProg As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmissor As System.Windows.Forms.ComboBox
    Friend WithEvents TXTVERNORM As System.Windows.Forms.CheckBox
End Class
