Imports Icraft.IcftBase
Public Class frmImpressao
    Private Sub frmImpressao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstoqueF.StrConn = Login.Strconn
        chkStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Shared _DS As New System.Data.DataSet
    Public Shared Property DS() As System.Data.DataSet
        Get
            Return _DS
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DS = value
        End Set
    End Property

    Shared _Data As Date = Now
    Public Shared Property Data() As Date
        Get
            Return _Data
        End Get
        Set(ByVal value As Date)
            _Data = value
        End Set
    End Property

    Shared _Etiq As New ArrayList
    Public Shared Property Etiq() As ArrayList
        Get
            Return _Etiq
        End Get
        Set(ByVal value As ArrayList)
            _Etiq = value
        End Set
    End Property

    Shared _Index As New ArrayList
    Public Shared Property Index() As ArrayList
        Get
            Return _Index
        End Get
        Set(ByVal value As ArrayList)
            _Index = value
        End Set
    End Property

    Sub Atualizar()
        Try
            _DS = DSCarrega("SELECT ETIQUETA, FILA_IMP, DATA_EMISSAO FROM (" & EstoqueF.SQL & ") WHERE ETIQ_STATUS_COD IN ('" & chkStatus.Text & "')", Login.Strconn)
            Dim SQL As String = "SELECT ETIQ_STATUS_COD, ETIQUETA, '' MARCAR, DATA_EMISSAO, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, PESO_LIQUIDO, PESO_BRUTO, PESO_BALANCA_LIQ, PESO_BALANCA_BRUTO, PESO_TEORICO, FILA_IMP FROM (" & EstoqueF.SQL & ") WHERE ETIQ_STATUS_COD IN (" & chkStatus.SqlText & ")"
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Status;Etiqueta;Marcar;Data da Emissão;Produto;Especificações;Pedido;Item;Peso Líquido;Peso Bruto; Balança Liquido;Balança Bruto;Teórico;Fila de Impressão"
            grdPrinc.Bind()
            If chkMarcar.Checked Then
                MarcarTodas(grdPrinc.Grid, _DS)
            End If
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub
    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Public Shared Function MarcarTodas(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        For Z As Integer = 0 To grd.Rows.Count - 1
            grd.Rows(Z).Cells(2).Value = 1
        Next
        Return Nothing
    End Function

    Public Shared Function DesmarcarTodas(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        For Z As Integer = 0 To grd.Rows.Count - 1
            grd.Rows(Z).Cells(2).Value = ""
        Next
        Return Nothing
    End Function

    Public Shared Function CriaFila(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        Dim DateTime As String = Format(Date.Now, "dd") & " de " & Format(Date.Now, "MMM") & " de " & Format(Date.Now, "yyy")
        _Etiq = Verifica(grd, _DS, "Etiq")
        _Index = Verifica(grd, _DS, "Index")
        For x As Integer = 0 To _Etiq.Count - 1
            DSGrava("UPDATE IM.ETIQUETA SET FILA_IMP = '" & frmImpressao.txtFilaImp.Text & " - " & DateTime & "' WHERE ETIQUETA = '" & _Etiq(x) & "'", Login.Strconn)
        Next
        For x As Integer = 0 To Index.Count - 1
            If Index.Contains(x) Then
                grd.Rows(x).Cells(2).Value = 1
            End If
        Next
        Return MsgBox("Fila: " & frmImpressao.txtFilaImp.Text & " - " & DateTime & " criada!")
    End Function


    Public Shared Function LimpaFila(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        _Etiq = Verifica(grd, _DS, "Etiq")
        _Index = Verifica(grd, _DS, "Index")
        For x As Integer = 0 To _Etiq.Count - 1
            DSGrava("UPDATE IM.ETIQUETA SET FILA_IMP = NULL WHERE ETIQUETA = '" & _Etiq(x) & "'", Login.Strconn)
        Next
        For x As Integer = 0 To Index.Count - 1
            If Index.Contains(x) Then
                grd.Rows(x).Cells(2).Value = 1
            End If
        Next
        Return MsgBox("Fila excluída!")
    End Function

    Public Shared Function Verifica(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet, ByVal opc As String) As ArrayList
        Dim val As String = ""
        For Z As Integer = 0 To grd.Rows.Count - 1
            val = Icraft.IcftBase.NZV(grd.Rows(Z).Cells(2).Value, 0)
            If val = 1 Then
                _Etiq.Add(grd.Rows(Z).Cells(1).Value)
                _Index.Add(grd.Rows(Z).Index)
            End If
        Next
        If opc = "Etiq" Then
            Return _Etiq
        ElseIf opc = "Index" Then
            Return _Index
        End If
        Return Nothing
    End Function

    Public Shared Function AtualizaDataImp(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        _Etiq = Verifica(grd, _DS, "Etiq")
        _Index = Verifica(grd, _DS, "Index")
        For X As Integer = 0 To _Etiq.Count - 1
            DSGrava("UPDATE IM.ETIQUETA SET DATA_EMISSAO = TRUNC(SYSDATE) WHERE ETIQUETA = '" & _Etiq(X) & "'", Login.Strconn)
        Next
        For x As Integer = 0 To Index.Count - 1
            If Index.Contains(x) Then
                grd.Rows(x).Cells(3).Value = _DS.Tables(0).Rows(x)(2)
            End If
        Next
        Return MsgBox("Data de emissão atualizada!")
    End Function

    Public Shared Function LimpaDataImp(ByVal grd As DataGridView, ByVal ds As System.Data.DataSet)
        _Etiq = Verifica(grd, _DS, "Etiq")
        _Index = Verifica(grd, _DS, "Index")
        For X As Integer = 0 To _Etiq.Count - 1
            DSGrava("UPDATE IM.ETIQUETA SET DATA_EMISSAO = NULL WHERE ETIQUETA = '" & _Etiq(X) & "'", Login.Strconn)
        Next
        For x As Integer = 0 To Index.Count - 1
            If Index.Contains(x) Then
                grd.Rows(x).Cells(3).Value = _DS.Tables(0).Rows(x)(2)
            End If
        Next
        Return MsgBox("Data de emissão atualizada!")
    End Function

    Private Sub btnAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If chkAttDataImp.Checked Then
            AtualizaDataImp(grdPrinc.Grid, _DS)
        End If
        If chkLimpaDataImp.Checked Then
            LimpaDataImp(grdPrinc.Grid, _DS)
        End If
        If chkCriaFila.Checked Then
            CriaFila(grdPrinc.Grid, _DS)
        End If
        If chkLimparFila.Checked Then
            LimpaFila(grdPrinc.Grid, _DS)
        End If
        Atualizar()
    End Sub

    Private Sub btnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualiza.Click
        If EstoqueF.FilaImpSQL = "" Then
            Try
                EstoqueF.FilaImpSQL = "IN('" & _DS.Tables(0).Rows(0)("FILA_IMP") & "')"
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao visualizar relatório, não há filas selecionadas."))
            End Try
        End If
        Local.MostraRelatorio("RPTETIQUETA", "FILA_IMP " & EstoqueF.FilaImpSQL)
    End Sub

    Private Sub chkTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMarcar.CheckedChanged
        If chkMarcar.Checked Then
            chkDesmarcar.Enabled = False
            MarcarTodas(grdPrinc.Grid, _DS)
        Else
            chkDesmarcar.Enabled = True
        End If
    End Sub

    Private Sub chkDesmarcar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesmarcar.CheckedChanged
        If chkDesmarcar.Checked Then
            chkMarcar.Enabled = False
            DesmarcarTodas(grdPrinc.Grid, _DS)
        Else
            chkMarcar.Enabled = True
        End If
    End Sub

    Private Sub chkCriaFila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCriaFila.CheckedChanged
        If chkCriaFila.Checked Then
            chkLimparFila.Enabled = False
        Else
            chkLimparFila.Enabled = True
        End If
    End Sub

    Private Sub chkLimparFila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLimparFila.CheckedChanged
        If chkLimparFila.Checked Then
            chkCriaFila.Enabled = False
        Else
            chkCriaFila.Enabled = True
        End If
    End Sub

    Private Sub chkAttDataImp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAttDataImp.CheckedChanged
        If chkAttDataImp.Checked Then
            chkLimpaDataImp.Enabled = False
        Else
            chkLimpaDataImp.Enabled = True
        End If
    End Sub

    Private Sub chkLimpaDataImp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLimpaDataImp.CheckedChanged
        If chkLimpaDataImp.Checked Then
            chkAttDataImp.Enabled = False
        Else
            chkAttDataImp.Enabled = True
        End If
    End Sub
End Class