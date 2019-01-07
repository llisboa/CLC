<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRel
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
        Me.lstRel = New System.Windows.Forms.ListBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.FF = New Icraft.IcftFFiltro
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAnexar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.btnLocalizar = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtSMTP = New System.Windows.Forms.TextBox
        Me.txtSENHA = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtUSUARIO = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtREM = New System.Windows.Forms.TextBox
        Me.txtASSUNTO = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEMAIL = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ndwCopias = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFim = New System.Windows.Forms.TextBox
        Me.txtIni = New System.Windows.Forms.TextBox
        Me.rbtInterval = New System.Windows.Forms.RadioButton
        Me.rbtTodas = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstImp = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DDG = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExpExcel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnVisualiza = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFechar = New System.Windows.Forms.Button
        Me.tmp = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ndwCopias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRel
        '
        Me.lstRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRel.FormattingEnabled = True
        Me.lstRel.Items.AddRange(New Object() {"Listagem de Departamentos;RptListaDepartam;DSListaDepartam;SBDB.DEPTO", "Emails e Telefones de Companhia;RptListaCIA;DSListaCIA;SBDB.CIA;"})
        Me.lstRel.Location = New System.Drawing.Point(3, 3)
        Me.lstRel.Name = "lstRel"
        Me.lstRel.Size = New System.Drawing.Size(630, 433)
        Me.lstRel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 471)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstRel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1.Escolha o Relatório"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FF)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2.Defina o Filtro"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FF
        '
        Me.FF.AutoBind = False
        Me.FF.AutoSize = True
        Me.FF.CamposSQL = "*"
        Me.FF.ConsultaSQL = Nothing
        Me.FF.Defs = Nothing
        Me.FF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FF.EsquemaGerador = ""
        Me.FF.EsquemaPrinc = ""
        Me.FF.Location = New System.Drawing.Point(3, 3)
        Me.FF.Name = "FF"
        Me.FF.Sistema = Nothing
        Me.FF.Size = New System.Drawing.Size(630, 439)
        Me.FF.StrConn = Nothing
        Me.FF.Tabela = ""
        Me.FF.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.btnAnexar)
        Me.TabPage3.Controls.Add(Me.btnImprimir)
        Me.TabPage3.Controls.Add(Me.btnVisualizar)
        Me.TabPage3.Controls.Add(Me.btnLocalizar)
        Me.TabPage3.Controls.Add(Me.btnEnviar)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(636, 445)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3.Configurar a impressão"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Panel2.AutoSize = True
        Me.Panel2.Location = New System.Drawing.Point(24, 390)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 52)
        Me.Panel2.TabIndex = 12
        '
        'btnAnexar
        '
        Me.btnAnexar.Location = New System.Drawing.Point(464, 390)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(75, 23)
        Me.btnAnexar.TabIndex = 11
        Me.btnAnexar.Text = "Anexar"
        Me.btnAnexar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(464, 206)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(464, 180)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 9
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(464, 153)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnLocalizar.TabIndex = 8
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(464, 419)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSMTP)
        Me.GroupBox5.Controls.Add(Me.txtSENHA)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtUSUARIO)
        Me.GroupBox5.Location = New System.Drawing.Point(428, 240)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(111, 148)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SMTP AUTH"
        '
        'txtSMTP
        '
        Me.txtSMTP.Location = New System.Drawing.Point(11, 35)
        Me.txtSMTP.Name = "txtSMTP"
        Me.txtSMTP.Size = New System.Drawing.Size(88, 20)
        Me.txtSMTP.TabIndex = 2
        '
        'txtSENHA
        '
        Me.txtSENHA.Location = New System.Drawing.Point(10, 113)
        Me.txtSENHA.Name = "txtSENHA"
        Me.txtSENHA.Size = New System.Drawing.Size(88, 20)
        Me.txtSENHA.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Servidor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Usuário"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Senha"
        '
        'txtUSUARIO
        '
        Me.txtUSUARIO.Location = New System.Drawing.Point(11, 74)
        Me.txtUSUARIO.Name = "txtUSUARIO"
        Me.txtUSUARIO.Size = New System.Drawing.Size(88, 20)
        Me.txtUSUARIO.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtREM)
        Me.GroupBox4.Controls.Add(Me.txtASSUNTO)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtEMAIL)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 241)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 146)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Envio por Email"
        '
        'txtREM
        '
        Me.txtREM.Location = New System.Drawing.Point(78, 21)
        Me.txtREM.Name = "txtREM"
        Me.txtREM.Size = New System.Drawing.Size(309, 20)
        Me.txtREM.TabIndex = 2
        '
        'txtASSUNTO
        '
        Me.txtASSUNTO.Location = New System.Drawing.Point(78, 47)
        Me.txtASSUNTO.Name = "txtASSUNTO"
        Me.txtASSUNTO.Size = New System.Drawing.Size(309, 20)
        Me.txtASSUNTO.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Remetente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-569, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Servidor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Emails (separados por ponto e vírgula = ';')"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Assunto"
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Location = New System.Drawing.Point(11, 89)
        Me.txtEMAIL.Multiline = True
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(376, 43)
        Me.txtEMAIL.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ndwCopias)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 76)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opções"
        '
        'ndwCopias
        '
        Me.ndwCopias.Location = New System.Drawing.Point(27, 43)
        Me.ndwCopias.Name = "ndwCopias"
        Me.ndwCopias.Size = New System.Drawing.Size(48, 20)
        Me.ndwCopias.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nr Cópias"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtFim)
        Me.GroupBox2.Controls.Add(Me.txtIni)
        Me.GroupBox2.Controls.Add(Me.rbtInterval)
        Me.GroupBox2.Controls.Add(Me.rbtTodas)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 76)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Intervalo de Páginas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Final"
        '
        'txtFim
        '
        Me.txtFim.Location = New System.Drawing.Point(214, 43)
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Size = New System.Drawing.Size(54, 20)
        Me.txtFim.TabIndex = 2
        '
        'txtIni
        '
        Me.txtIni.Location = New System.Drawing.Point(118, 43)
        Me.txtIni.Name = "txtIni"
        Me.txtIni.Size = New System.Drawing.Size(54, 20)
        Me.txtIni.TabIndex = 2
        '
        'rbtInterval
        '
        Me.rbtInterval.AutoSize = True
        Me.rbtInterval.Location = New System.Drawing.Point(16, 45)
        Me.rbtInterval.Name = "rbtInterval"
        Me.rbtInterval.Size = New System.Drawing.Size(95, 17)
        Me.rbtInterval.TabIndex = 1
        Me.rbtInterval.TabStop = True
        Me.rbtInterval.Text = "Intervalo inicial"
        Me.rbtInterval.UseVisualStyleBackColor = True
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Location = New System.Drawing.Point(16, 23)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 0
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstImp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione a Impressora"
        '
        'lstImp
        '
        Me.lstImp.FormattingEnabled = True
        Me.lstImp.Location = New System.Drawing.Point(16, 18)
        Me.lstImp.Name = "lstImp"
        Me.lstImp.Size = New System.Drawing.Size(486, 82)
        Me.lstImp.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Comentário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Status:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExpExcel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnVisualiza)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnFechar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(644, 32)
        Me.Panel1.TabIndex = 1
        '
        'btnExpExcel
        '
        Me.btnExpExcel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpExcel.Location = New System.Drawing.Point(333, 5)
        Me.btnExpExcel.Name = "btnExpExcel"
        Me.btnExpExcel.Size = New System.Drawing.Size(124, 22)
        Me.btnExpExcel.TabIndex = 3
        Me.btnExpExcel.Text = "Exportar para Excel"
        Me.btnExpExcel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(457, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 22)
        Me.Label2.TabIndex = 4
        '
        'btnVisualiza
        '
        Me.btnVisualiza.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVisualiza.Location = New System.Drawing.Point(470, 5)
        Me.btnVisualiza.Name = "btnVisualiza"
        Me.btnVisualiza.Size = New System.Drawing.Size(78, 22)
        Me.btnVisualiza.TabIndex = 0
        Me.btnVisualiza.Text = "Visualizar"
        Me.btnVisualiza.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(548, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 22)
        Me.Label1.TabIndex = 2
        '
        'btnFechar
        '
        Me.btnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFechar.Location = New System.Drawing.Point(561, 5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(78, 22)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 503)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRel"
        Me.Text = "Relatórios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ndwCopias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DDG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstRel As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnVisualiza As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExpExcel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FF As Icraft.IcftFFiltro
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ndwCopias As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFim As System.Windows.Forms.TextBox
    Friend WithEvents txtIni As System.Windows.Forms.TextBox
    Friend WithEvents rbtInterval As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSMTP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtREM As System.Windows.Forms.TextBox
    Friend WithEvents txtASSUNTO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSENHA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents tmp As System.Windows.Forms.Timer
    Friend WithEvents lstImp As System.Windows.Forms.ListBox
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents btnAnexar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
