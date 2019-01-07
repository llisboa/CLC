Public Class frmModificacoes

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Private Sub frmModificacoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstoqueF.StrConn = Login.Strconn
            txtComparaStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
            txtComparaStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
            txtComparaStatus.StrConn = Login.Strconn
            txtComparaStatus.BIND()
            txtComparaStatus.Text = "DISPONÍVEL"
            txtComparaMom.Text = Format(DateAdd(DateInterval.Day, -7, Now), "yyyy-MM-dd HH:mm:ss")
            chkComparaNao.Checked = False
            txtComStatus.SQL = "SELECT Etiq_status_cod FROM IM.vw_col_rastrea_etiq GROUP BY ETIQ_STATUS_COD"
            txtComStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
            txtComStatus.StrConn = Login.Strconn
            txtComStatus.BIND()
            txtComStatus.Text = "DISPONÍVEL"
            txtComMom.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
            chkComNao.Checked = True
            Atualizar()
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "Na carga do form"))
        End Try
    End Sub

    Sub Atualizar()
        If txtComMom.Text <> "" And txtComparaMom.Text <> "" Then
            Try
                pnlComparaStatus.Visible = Not chkQQ.Checked
                pnlComparaCom.Visible = Not chkQQ.Checked
                Dim Sql As String = "  SELECT COMPARA_ANTES.ETIQUETA, VW.ARMAZEM_CIA_COD, vw.armazem_num, vw.armazem_praca ,COMPARA_ANTES.STATUS_COD STATUS_ANTES, COMPARA_DEPOIS.STATUS_COD STATUS_DEPOIS , VW.PRODUTO_COD, VW.ESPEC, COMPARA_DEPOIS.OPERADOR FROM (SELECT ER.* FROM IM.ETIQUETA_REG ER, (SELECT ETIQUETA,MAX(SEQ) MAX_SEQ FROM IM.ETIQUETA_REG WHERE MOMENTO_REG <= TO_DATE('" & Format(CDate(txtComparaMom.Text), "yyyy-MM-dd HH:mm:ss") & "','YYYY-MM-DD HH24:MI:SS') GROUP BY ETIQUETA) MAX_REG" & vbCrLf & _
                "  WHERE ER.ETIQUETA = MAX_REG.ETIQUETA AND" & vbCrLf & _
                "  ER.SEQ = MAX_REG.MAX_SEQ) COMPARA_ANTES," & vbCrLf & _
                "  (SELECT ER.* FROM IM.ETIQUETA_REG ER, (SELECT ETIQUETA,MAX(SEQ) MAX_SEQ FROM IM.ETIQUETA_REG WHERE MOMENTO_REG <= TO_DATE('" & Format(CDate(txtComMom.Text), "yyyy-MM-dd HH:mm:ss") & "','YYYY-MM-DD HH24:MI:SS') GROUP BY ETIQUETA) MAX_REG" & vbCrLf & _
                "  WHERE ER.ETIQUETA = MAX_REG.ETIQUETA AND" & vbCrLf & _
                "  ER.SEQ = MAX_REG.MAX_SEQ) COMPARA_DEPOIS," & vbCrLf & _
                "  (" & EstoqueF.SQL & ") VW" & vbCrLf & _
                "  WHERE COMPARA_ANTES.ETIQUETA = COMPARA_DEPOIS.ETIQUETA (+) AND" & vbCrLf & _
                "  COMPARA_ANTES.ETIQUETA = VW.ETIQUETA AND" & vbCrLf

                If chkQQ.Enabled Then
                    Sql &= "COMPARA_ANTES.STATUS_COD<>COMPARA_DEPOIS.STATUS_COD"
                Else
                    Sql &= "  " & IIf(chkComparaNao.Checked, "NOT ", "") & "COMPARA_ANTES.STATUS_COD IN (" & txtComparaStatus.SqlText & ") AND" & vbCrLf & _
                    "  " & IIf(chkComNao.Checked, "NOT ", "") & "COMPARA_DEPOIS.STATUS_COD IN (" & txtComStatus.SqlText & ")" & vbCrLf
                End If
                Sql &= "  ORDER BY STATUS_ANTES, STATUS_DEPOIS, ETIQUETA"


                grdPrinc.ColunaNomes = "Etiqueta;Armazém;Número do Armazém;Praça do Armazém;Status Anterior;Status Atual;Código do Produto;Especificação;Operador"
                grdPrinc.StrConn = Login.Strconn
                grdPrinc.Usuario = Login.Usuario!usuario
                grdPrinc.SQL = Sql
                grdPrinc.Bind()
                grdPrinc.Grid.ReadOnly = True
                _Repos = True
                Try
                    cal.SelectionStart = CDate(txtComparaMom.Text)
                Catch
                End Try
                Try
                    cal.SelectionEnd = CDate(txtComMom.Text)
                Catch
                End Try
                _Repos = False

            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
            End Try
        End If
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub btnAgora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgora.Click
        txtComMom.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub chkQQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkQQ.CheckedChanged
        Atualizar()
    End Sub

    Private _Repos As Boolean = False
    Private Sub cal_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles cal.DateSelected
        Try
            If Not _Repos Then
                txtComparaMom.Text = Format(cal.SelectionStart, "yyyy-MM-dd 00:00:00")
                txtComMom.Text = Format(cal.SelectionEnd, "yyyy-MM-dd 23:59:59")
                Atualizar()
            End If
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "Selecionando período"))
        End Try
    End Sub
End Class