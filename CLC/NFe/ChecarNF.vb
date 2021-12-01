Imports CLC.Local
Imports Icraft.IcftBase
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class ChecarNF
    Sub RegFaixa(ByRef Inicio As Integer, ByRef Final As Integer)
        lblCheck.Text = ""
        If Inicio <> 0 Then
            If Final = Inicio Then
                lblCheck.Text &= " " & ("Nota inexistente " & Inicio) & " "
            Else
                lblCheck.Text &= " " & ("Faixa inexistente de " & Inicio & " à " & Final) & " "
            End If
            Inicio = 0
            Final = 0
        End If
    End Sub

    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        lblCheck.Text = "..."
        Dim UltCNPJ As String = ""

        For Each CNPJ As System.Data.DataRow In DSCarrega("SELECT EMIT_CNPJ, CIA_COD, INFNFE_IDE_SERIE FROM IM.NF WHERE NOT INFNFE_ID IS NULL GROUP BY CIA_COD, EMIT_CNPJ, INFNFE_IDE_SERIE ORDER BY EMIT_CNPJ, INFNFE_IDE_SERIE", CLC.Login.Strconn).Tables(0).Rows
            If UltCNPJ <> CNPJ!EMIT_CNPJ Then
                If UltCNPJ <> "" Then
                    lblCheck.Text &= ""
                End If
                lblCheck.Text &= (CNPJ!EMIT_CNPJ & " - " & CNPJ!CIA_COD)
                lblCheck.Text &= " " & vbCrLf
                UltCNPJ = CNPJ!EMIT_CNPJ
            End If

            Dim MIN As Integer = DSValor("MIN(INFNFE_IDE_NNF)", "IM.NF", CLC.Login.Strconn, "EMIT_CNPJ = :CPNJ AND INFNFE_IDE_SERIE = :SERIE AND NOT INFNFE_ID IS NULL", ":CPNJ", CNPJ!EMIT_CNPJ, ":SERIE", CNPJ!INFNFE_IDE_SERIE)
            Dim MAX As Integer = DSValor("MAX(INFNFE_IDE_NNF)", "IM.NF", CLC.Login.Strconn, "EMIT_CNPJ = :CPNJ AND INFNFE_IDE_SERIE = :SERIE AND NOT INFNFE_ID IS NULL", ":CPNJ", CNPJ!EMIT_CNPJ, ":SERIE", CNPJ!INFNFE_IDE_SERIE)
            Dim CODCIA As String = DSValor("CIA_COD", "IM.NF", CLC.Login.Strconn, "EMIT_CNPJ = :CPNJ AND INFNFE_IDE_SERIE = :SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF", ":CPNJ", CNPJ!EMIT_CNPJ, ":SERIE", CNPJ!INFNFE_IDE_SERIE, ":INFNFE_IDE_NNF", MIN)
            Dim IDNF As Integer

            IDNF = DSValor("COUNT(INFNFE_IDE_NNF)", "IM.NF", CLC.Login.Strconn, "EMIT_CNPJ = :CPNJ AND INFNFE_IDE_SERIE = :SERIE AND NOT INFNFE_ID IS NULL", ":CPNJ", CNPJ!EMIT_CNPJ, ":SERIE", CNPJ!INFNFE_IDE_SERIE)

            lblCheck.Text &= "Série:" & CNPJ!INFNFE_IDE_SERIE & vbCrLf & "Mínimo:" & MIN & vbCrLf & "Máximo:" & MAX & vbCrLf & CODCIA & vbCrLf & ("" & vbCrLf & ".....")
            lblCheck.Text &= ""
            lblMaxMin.Text = "Pronto" & vbCrLf & "Todos:" & " " & IDNF & ""
        Next
        lblCheck.Text &= ""
    End Sub

    Private Sub btnManda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManda.Click
        EnviaEmail("lucianoicraft@gmail.com", txtEmail.Text, "Intermesa - Checagem de Notas Fiscais - Lista de Inexistência", lblCheck.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblMaxMin.Text = "Aguarde..." & vbCrLf
        Exit Sub
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        'EnviaEmail("lucianoicraft@gmail.com", txtEmail.Text, "Intermesa - Checagem de Notas Fiscais - Lista de Inexistência", lblCheck)
    End Sub
End Class