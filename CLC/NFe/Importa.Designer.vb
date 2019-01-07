<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importa
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
        Me.btnDir = New System.Windows.Forms.Button
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDirRelativo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblArqInfo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSegs = New System.Windows.Forms.TextBox
        Me.btnExecutar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnSalva = New System.Windows.Forms.Button
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.CheckBox
        Me.gTemp = New System.Windows.Forms.GroupBox
        Me.lblAcompanha = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblUltima = New System.Windows.Forms.Label
        Me.lblContador = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSuspend = New System.Windows.Forms.CheckBox
        Me.fldOpen = New System.Windows.Forms.FolderBrowserDialog
        Me.txtfim = New System.Windows.Forms.TextBox
        Me.btnmover = New System.Windows.Forms.Button
        Me.txtini = New System.Windows.Forms.TextBox
        Me.txtserie = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gTemp.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDir
        '
        Me.btnDir.Location = New System.Drawing.Point(232, 22)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(29, 20)
        Me.btnDir.TabIndex = 6
        Me.btnDir.Text = "..."
        Me.btnDir.UseVisualStyleBackColor = True
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(63, 22)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(163, 20)
        Me.txtDir.TabIndex = 5
        Me.txtDir.Text = "K:\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Relativo"
        '
        'txtDirRelativo
        '
        Me.txtDirRelativo.Location = New System.Drawing.Point(63, 48)
        Me.txtDirRelativo.Name = "txtDirRelativo"
        Me.txtDirRelativo.Size = New System.Drawing.Size(163, 20)
        Me.txtDirRelativo.TabIndex = 7
        Me.txtDirRelativo.Text = "~/NotaXml"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArqInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 269)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Sobre Arquivos"
        '
        'lblArqInfo
        '
        Me.lblArqInfo.Location = New System.Drawing.Point(6, 19)
        Me.lblArqInfo.Multiline = True
        Me.lblArqInfo.Name = "lblArqInfo"
        Me.lblArqInfo.ReadOnly = True
        Me.lblArqInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblArqInfo.Size = New System.Drawing.Size(174, 238)
        Me.lblArqInfo.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSegs)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDir)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnDir)
        Me.GroupBox2.Controls.Add(Me.txtDirRelativo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 119)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apontamento para Diretório e Site"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Checagem em Segs"
        '
        'txtSegs
        '
        Me.txtSegs.Location = New System.Drawing.Point(119, 83)
        Me.txtSegs.Name = "txtSegs"
        Me.txtSegs.Size = New System.Drawing.Size(44, 20)
        Me.txtSegs.TabIndex = 12
        '
        'btnExecutar
        '
        Me.btnExecutar.Location = New System.Drawing.Point(334, 56)
        Me.btnExecutar.Name = "btnExecutar"
        Me.btnExecutar.Size = New System.Drawing.Size(92, 23)
        Me.btnExecutar.TabIndex = 11
        Me.btnExecutar.Text = "Executar Agora"
        Me.btnExecutar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalva)
        Me.GroupBox3.Controls.Add(Me.txtSenha)
        Me.GroupBox3.Controls.Add(Me.txtUsuario)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtLogin)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 136)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Início Automático"
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(88, 101)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 10
        Me.btnSalva.Text = "Registrar"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(88, 70)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(138, 20)
        Me.txtSenha.TabIndex = 9
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(88, 44)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(138, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Senha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Logar Como:"
        '
        'txtLogin
        '
        Me.txtLogin.AutoSize = True
        Me.txtLogin.Location = New System.Drawing.Point(15, 21)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(128, 17)
        Me.txtLogin.TabIndex = 5
        Me.txtLogin.Text = "No Login da Máquina"
        Me.txtLogin.UseVisualStyleBackColor = True
        '
        'gTemp
        '
        Me.gTemp.Controls.Add(Me.lblAcompanha)
        Me.gTemp.Controls.Add(Me.Label11)
        Me.gTemp.Controls.Add(Me.btnExecutar)
        Me.gTemp.Controls.Add(Me.lblUltima)
        Me.gTemp.Controls.Add(Me.lblContador)
        Me.gTemp.Controls.Add(Me.Label9)
        Me.gTemp.Controls.Add(Me.txtSuspend)
        Me.gTemp.Location = New System.Drawing.Point(12, 12)
        Me.gTemp.Name = "gTemp"
        Me.gTemp.Size = New System.Drawing.Size(463, 100)
        Me.gTemp.TabIndex = 20
        Me.gTemp.TabStop = False
        Me.gTemp.Text = "Importa NFe - Temporizador"
        '
        'lblAcompanha
        '
        Me.lblAcompanha.Location = New System.Drawing.Point(14, 52)
        Me.lblAcompanha.Name = "lblAcompanha"
        Me.lblAcompanha.Size = New System.Drawing.Size(297, 35)
        Me.lblAcompanha.TabIndex = 14
        Me.lblAcompanha.Text = "Iniciando a interface."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(313, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Aguardar:"
        '
        'lblUltima
        '
        Me.lblUltima.Location = New System.Drawing.Point(187, 24)
        Me.lblUltima.Name = "lblUltima"
        Me.lblUltima.Size = New System.Drawing.Size(124, 17)
        Me.lblUltima.TabIndex = 12
        Me.lblUltima.Text = "XX"
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.Location = New System.Drawing.Point(375, 11)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(51, 36)
        Me.lblContador.TabIndex = 11
        Me.lblContador.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Última Execução:"
        '
        'txtSuspend
        '
        Me.txtSuspend.AutoSize = True
        Me.txtSuspend.Location = New System.Drawing.Point(14, 22)
        Me.txtSuspend.Name = "txtSuspend"
        Me.txtSuspend.Size = New System.Drawing.Size(77, 17)
        Me.txtSuspend.TabIndex = 6
        Me.txtSuspend.Text = "Suspender"
        Me.txtSuspend.UseVisualStyleBackColor = True
        '
        'txtfim
        '
        Me.txtfim.Location = New System.Drawing.Point(33, 133)
        Me.txtfim.Name = "txtfim"
        Me.txtfim.Size = New System.Drawing.Size(44, 20)
        Me.txtfim.TabIndex = 16
        '
        'btnmover
        '
        Me.btnmover.Location = New System.Drawing.Point(20, 177)
        Me.btnmover.Name = "btnmover"
        Me.btnmover.Size = New System.Drawing.Size(75, 23)
        Me.btnmover.TabIndex = 17
        Me.btnmover.Text = "Habilitar"
        Me.btnmover.UseVisualStyleBackColor = True
        '
        'txtini
        '
        Me.txtini.Location = New System.Drawing.Point(33, 86)
        Me.txtini.Name = "txtini"
        Me.txtini.Size = New System.Drawing.Size(44, 20)
        Me.txtini.TabIndex = 15
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(33, 44)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(44, 20)
        Me.txtserie.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Série"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NF Início"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "NF Fim"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtserie)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.btnmover)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtini)
        Me.GroupBox4.Controls.Add(Me.txtfim)
        Me.GroupBox4.Location = New System.Drawing.Point(497, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(113, 223)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RE-Habilitar"
        '
        'Importa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 472)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gTemp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Importa"
        Me.Text = "Importação de XML formato NFE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gTemp.ResumeLayout(False)
        Me.gTemp.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDir As System.Windows.Forms.Button
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDirRelativo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.CheckBox
    Friend WithEvents gTemp As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSuspend As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblUltima As System.Windows.Forms.Label
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents btnExecutar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSegs As System.Windows.Forms.TextBox
    Friend WithEvents lblAcompanha As System.Windows.Forms.Label
    Friend WithEvents fldOpen As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblArqInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnmover As System.Windows.Forms.Button
    Friend WithEvents txtfim As System.Windows.Forms.TextBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents txtini As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
