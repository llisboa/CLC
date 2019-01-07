Public Class frmCriaDataset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Icraft.IcftBase.DSConfig(Login.Strconn, "FRMCRIADATASET", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "FLD")

            Dim DS As System.Data.DataSet = Nothing
            Dim DSM As New System.Data.DataSet

            ' TL COM A CONFIGURAÇÃO DAS TABELAS
            Dim TABA As ArrayList = Icraft.IcftBase.SplitMultiDelim(FLDTABELA.Text, New String() {vbCrLf, ";"})
            Dim RELA As ArrayList = Icraft.IcftBase.SplitMultiDelim(FLDREL.Text, New String() {vbCrLf, ";"})

            For Each TABL As String In TABA
                Dim AR As New Icraft.IcftBase.ElementoStr(TABL)
                Dim NOME As String = AR.Nome
                Dim TABELA As String = AR.Conteudo
                Dim SQL As String = ""
                If Not TABELA.StartsWith("SELECT ", StringComparison.OrdinalIgnoreCase) Then
                    SQL = "SELECT * FROM " & FLDESQUEMA.Text & "." & TABELA

                    DS = Icraft.IcftBase.DSCarregaEstrut(SQL, Login.Strconn)
                    SQL = ""
                    For Each CAMPO As System.Data.DataColumn In DS.Tables(0).Columns
                        If Not CAMPO.ColumnName Like "SYS_*" Then
                            SQL &= IIf(SQL <> "", ", ", "") & CAMPO.ColumnName
                        End If
                    Next
                    SQL = "SELECT " & SQL & " FROM " & FLDESQUEMA.Text & "." & TABELA
                    If NOME = "" Then
                        NOME = TABELA
                    End If
                Else
                    SQL = TABELA
                End If

                DS = Icraft.IcftBase.DSCarregaEstrut(SQL, Login.Strconn)
                If NOME <> "" Then
                    DS.Tables(0).TableName = NOME
                End If
                DSM.Tables.Add(DS.Tables(0).Clone)
            Next

            For Z As Integer = 0 To RELA.Count - 1 Step 2
                If RELA(Z) <> "" Then
                    Dim LADO1 As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(RELA(Z), "(.*?)\((.*?)\)")
                    Dim LADON As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(RELA(Z + 1), "(.*?)\((.*?)\)")
                    Dim COL1 As System.Data.DataColumn = DSM.Tables(LADO1.Groups(1).Value).Columns(Split(LADO1.Groups(2).Value, "+")(0))
                    Dim COLN As System.Data.DataColumn = DSM.Tables(LADON.Groups(1).Value).Columns(Split(LADON.Groups(2).Value, "+")(0))
                    Dim REL As New System.Data.DataRelation(LADO1.Groups(1).Value & "_" & LADON.Groups(1).Value, COL1, COLN)

                    DSM.Relations.Add(REL)
                End If
            Next

            DSM.WriteXmlSchema(Icraft.IcftBase.FileExpr(FLDDIRETORIO.Text, FLDARQ.Text))
            MsgBox("Esquema gravado.")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub frmCriaDataset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.Form.Conteudo(Me, "FLD") = Icraft.IcftBase.DSConfig(Login.Strconn, "FRMCRIADATASET", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
    End Sub

End Class
