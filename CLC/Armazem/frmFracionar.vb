Imports Icraft.IcftBase
Public Class frmFracionar

    Private Sub frmFracionados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = " SELECT ETIQUETA, PRODUTO_COD, ESPEC, VOLUME_PECAS_QTD, PESO_LIQUIDO, PESO_BRUTO, PESO_TEORICO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO ETIQ_STATUS_COD, OBS FROM (" & EstoqueF.SQL & ") WHERE " & Local.InSQL(chkStatus.Text)
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Etiqueta;Produto;Especificações;Qtd Peças;Peso Líquido;Peso Bruto;Peso Teórico;Peso Líquido na Balança;Peso Bruto na Balança;Status;Observações"
            grdPrinc.Totaliza = "COUNT;;;SUM;SUM;SUM;SUM;SUM;SUM;"
            grdPrinc.Bind()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
        AddHandler grdPrinc.Grid.CellClick, AddressOf CellClick
    End Sub
    Dim Etiq As String = ""
    Dim QtdPecas As Integer = 0
    Dim PBrt As Double = 0
    Dim PLiq As Double = 0
    Dim PTeo As Double = 0
    Dim BBrt As Double = 0
    Dim BLiq As Double = 0
    Private Sub CellClick(ByVal sender As Object, ByVal e As Object)
        lblEtiq.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(0).Value, "")
        Etiq = lblEtiq.Text
        lblQtdPecas.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(3).Value, 0)
        QtdPecas = lblQtdPecas.Text
        txtBBrt.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(8).Value, 0)
        BBrt = txtBBrt.Text
        txtBLiq.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(7).Value, 0)
        BLiq = txtBLiq.Text
        txtPBrt.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(5).Value, 0)
        PBrt = txtPBrt.Text
        txtPLiq.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(4).Value, 0)
        PLiq = txtPLiq.Text
        txtPTeo.Text = NZV(CType(sender, Windows.Forms.DataGridView).CurrentRow.Cells(6).Value, 0)
        PTeo = txtPTeo.Text
    End Sub
    Sub AtualizaPeso()
        If txtBBrt.Text <> "" Then
            txtBBrt.Text = txtBBrt.Text / txtPart.Text
        End If
        If txtBLiq.Text <> "" Then
            txtBLiq.Text = txtBLiq.Text / txtPart.Text
        End If
        If txtPBrt.Text <> "" Then
            txtPBrt.Text = txtPBrt.Text / txtPart.Text
        End If
        If txtPLiq.Text <> "" Then
            txtPLiq.Text = txtPLiq.Text / txtPart.Text
        End If
        If txtPTeo.Text <> "" Then
            txtPTeo.Text = txtPTeo.Text / txtPart.Text
        End If
    End Sub
    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub btnAlteraPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlteraPeso.Click
        txtBBrt.Enabled = True
        txtBLiq.Enabled = True
        txtPBrt.Enabled = True
        txtPLiq.Enabled = True
        txtPTeo.Enabled = True
    End Sub

    Private Sub btnCalcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcula.Click
        AtualizaPeso()
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        MsgBox("Recurso não disponível no momento.")
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        '    Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT TEU_NR, OBS, ARMAZEM_CIA_COD, ARM_LINHA, ARM_COLUNA, ARM_NUM, ARM_PRACA
        '    Dim Pref As String = lblEtiq.Text.Substring(0, 6)
        '    If QtdPecas Mod txtPart.Text Then
        '        For i As Integer = 0 To txtPart.Text
        '            'Icraft.IcftBase.DSGrava("INSERT INTO IM.ETIQUETA(ETIQUETA, QTD_PECAS, PESO_LIQUIDO, PESO_BRUTO, PESO_TEORICO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, ETIQ_ANTERIOR, STATUS_COD
        '            'DSGrava("UPDATE IM.ETIQUETA SET PESO_BALANCA_LIQ = :PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO = :PESO_BALANCA_BRT, OBS = :OBS, TEU_NR = :TEU_NR WHERE ETIQUETA=:ETIQUETA", Login.Strconn, ":PESO_BALANCA_LIQ", LINHA.Cells(4).Value, ":PESO_BALANCA_BRT", LINHA.Cells(5).Value, ":OBS", LINHA.Cells(6).Value, ":TEU_NR", LINHA.Cells(7).Value, ":ETIQUETA", LINHA.Cells(0).Value)
        '        Next
        '    End If
    End Sub
End Class