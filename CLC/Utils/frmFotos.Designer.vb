<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFotos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFotos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXTTAMANHO = New System.Windows.Forms.ComboBox
        Me.txtDiretorio = New System.Windows.Forms.TextBox
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.btnDiretorio = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DDG = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXTETIQUETA = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTVIAGEMESCALA = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnGrava = New System.Windows.Forms.Button
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.picImg = New System.Windows.Forms.PictureBox
        Me.grdprinc = New Icraft.IcftFGrid2
        Me.lblAndamento = New System.Windows.Forms.Label
        Me.pnlAndamento = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAndamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtDiretorio)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.btnDiretorio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 84)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlAndamento)
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTTAMANHO)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 42)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upload"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(278, 13)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 14
        Me.btnUpload.Text = "Enviar"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tamanho no Destino (px):"
        '
        'TXTTAMANHO
        '
        Me.TXTTAMANHO.FormattingEnabled = True
        Me.TXTTAMANHO.Items.AddRange(New Object() {"3072X2304", "1280X960", "800X600", "600X450"})
        Me.TXTTAMANHO.Location = New System.Drawing.Point(144, 14)
        Me.TXTTAMANHO.Name = "TXTTAMANHO"
        Me.TXTTAMANHO.Size = New System.Drawing.Size(106, 21)
        Me.TXTTAMANHO.TabIndex = 12
        '
        'txtDiretorio
        '
        Me.txtDiretorio.Location = New System.Drawing.Point(72, 5)
        Me.txtDiretorio.Name = "txtDiretorio"
        Me.txtDiretorio.Size = New System.Drawing.Size(256, 20)
        Me.txtDiretorio.TabIndex = 7
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(531, 5)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 6
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnDiretorio
        '
        Me.btnDiretorio.Location = New System.Drawing.Point(336, 5)
        Me.btnDiretorio.Name = "btnDiretorio"
        Me.btnDiretorio.Size = New System.Drawing.Size(24, 21)
        Me.btnDiretorio.TabIndex = 2
        Me.btnDiretorio.Text = "..."
        Me.btnDiretorio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diretório:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TXTETIQUETA)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TXTVIAGEMESCALA)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnGrava)
        Me.Panel2.Controls.Add(Me.txtObs)
        Me.Panel2.Controls.Add(Me.txtTitulo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.picImg)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(387, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 405)
        Me.Panel2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Digite pelo menos 4 caracteres e aperte F9."
        '
        'TXTETIQUETA
        '
        Me.TXTETIQUETA.FormattingEnabled = True
        Me.TXTETIQUETA.Location = New System.Drawing.Point(65, 319)
        Me.TXTETIQUETA.Name = "TXTETIQUETA"
        Me.TXTETIQUETA.Size = New System.Drawing.Size(154, 21)
        Me.TXTETIQUETA.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Etiqueta:"
        '
        'TXTVIAGEMESCALA
        '
        Me.TXTVIAGEMESCALA.FormattingEnabled = True
        Me.TXTVIAGEMESCALA.Location = New System.Drawing.Point(10, 293)
        Me.TXTVIAGEMESCALA.Name = "TXTVIAGEMESCALA"
        Me.TXTVIAGEMESCALA.Size = New System.Drawing.Size(209, 21)
        Me.TXTVIAGEMESCALA.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Viagem/Escala:"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(144, 148)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnGrava
        '
        Me.btnGrava.Location = New System.Drawing.Point(145, 369)
        Me.btnGrava.Name = "btnGrava"
        Me.btnGrava.Size = New System.Drawing.Size(75, 23)
        Me.btnGrava.TabIndex = 5
        Me.btnGrava.Text = "Gravar"
        Me.btnGrava.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(10, 215)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(209, 58)
        Me.txtObs.TabIndex = 4
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(10, 174)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(209, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Título"
        '
        'picImg
        '
        Me.picImg.Location = New System.Drawing.Point(5, 7)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(215, 138)
        Me.picImg.TabIndex = 0
        Me.picImg.TabStop = False
        '
        'grdprinc
        '
        Me.grdprinc.AutoBind = False
        Me.grdprinc.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grdprinc.BindContainer = Nothing
        Me.grdprinc.Campos = Nothing
        Me.grdprinc.CamposExtend = Nothing
        Me.grdprinc.CamposFixos = ""
        Me.grdprinc.Chave = Nothing
        Me.grdprinc.ColunaNomes = ""
        Me.grdprinc.Defs = Nothing
        Me.grdprinc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdprinc.EsquemaGerador = ""
        Me.grdprinc.EsquemaPrinc = ""
        Me.grdprinc.Filtro = Nothing
        Me.grdprinc.IncluiCamposSys = False
        Me.grdprinc.Location = New System.Drawing.Point(0, 84)
        Me.grdprinc.MostraNumReg = False
        Me.grdprinc.Name = "grdprinc"
        Me.grdprinc.Ocultar = Nothing
        Me.grdprinc.Params = CType(resources.GetObject("grdprinc.Params"), System.Collections.ArrayList)
        Me.grdprinc.Sistema = ""
        Me.grdprinc.Size = New System.Drawing.Size(387, 405)
        Me.grdprinc.SQL = ""
        Me.grdprinc.StrConn = Nothing
        Me.grdprinc.Tabela = ""
        Me.grdprinc.TabIndex = 3
        Me.grdprinc.Totaliza = ""
        Me.grdprinc.Usuario = ""
        Me.grdprinc.ValorPadrao = CType(resources.GetObject("grdprinc.ValorPadrao"), System.Collections.ArrayList)
        '
        'lblAndamento
        '
        Me.lblAndamento.ForeColor = System.Drawing.Color.White
        Me.lblAndamento.Location = New System.Drawing.Point(7, 4)
        Me.lblAndamento.Name = "lblAndamento"
        Me.lblAndamento.Size = New System.Drawing.Size(194, 14)
        Me.lblAndamento.TabIndex = 16
        Me.lblAndamento.Text = "."
        Me.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAndamento
        '
        Me.pnlAndamento.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlAndamento.Controls.Add(Me.lblAndamento)
        Me.pnlAndamento.Location = New System.Drawing.Point(369, 13)
        Me.pnlAndamento.Name = "pnlAndamento"
        Me.pnlAndamento.Size = New System.Drawing.Size(206, 21)
        Me.pnlAndamento.TabIndex = 17
        Me.pnlAndamento.Visible = False
        '
        'frmFotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 489)
        Me.Controls.Add(Me.grdprinc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFotos"
        Me.Text = "Inserção de Fotos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAndamento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDiretorio As System.Windows.Forms.Button
    Friend WithEvents DDG As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picImg As System.Windows.Forms.PictureBox
    Friend WithEvents btnGrava As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents grdprinc As Icraft.IcftFGrid2
    Friend WithEvents TXTETIQUETA As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTVIAGEMESCALA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiretorio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTTAMANHO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents lblAndamento As System.Windows.Forms.Label
    Friend WithEvents pnlAndamento As System.Windows.Forms.Panel
End Class
