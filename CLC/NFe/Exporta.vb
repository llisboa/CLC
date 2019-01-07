Imports CLC.Local
Imports Icraft.IcftBase

Public Class Exporta

    Dim Temps As New ArrayList
    Private Sub btnDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir.Click
        fldOpen.SelectedPath = txtDir.Text
        If fldOpen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDir.Text = fldOpen.SelectedPath
        End If
    End Sub

    Private Sub Exporta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Icraft.IcftBase.ApagaTemps(Temps)
    End Sub

    Private Sub Exporta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Icraft.IcftBase.CarregaCombo(txtEmissor, True, DSCarrega("SELECT CIA_COD FROM IM.NF", Login.Strconn))

        Icraft.IcftBase.Form.Conteudo(Me, "txt") = DSConfig(Login.Strconn, "FORM_NFE_EXPORTA", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
        grd.Columns.Add("Arquivo", "Arquivo")
        grd.Columns.Add("Original", "Original")
        grd.Columns.Add("Companhia", "Companhia")
        grd.Columns.Add("NrSerie", "NrSérie")
        grd.Columns.Add("NrNota", "NrNota")
        grd.Columns.Add("Comparacao", "Comparação com Original")
        If txtProg.Text = "" Then
            txtProg.Text = "C:\Program Files\WinMerge\WinMergeU.exe"
        End If
        If txtTemp.Text = "" Then
            txtTemp.Text = Icraft.IcftBase.TemporaryDir()
            If txtTemp.Text = "" Then
                txtTemp.Text = "c:\windows\temp"
            End If
        End If
    End Sub


    Private Sub btnExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec.Click
        DSConfig(Login.Strconn, "FORM_NFE_EXPORTA", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "txt")

        Dim FILTRO As String = IIf(txtEmissor.Text <> "", " AND CIA_COD = " & Icraft.IcftBase.SqlExpr(txtEmissor.Text), "") & IIf(txtSerie.Text <> "", " AND INFNFE_IDE_SERIE = " & txtSerie.Text, "") & IIf(txtNotaFim.Text <> "", " AND INFNFE_IDE_NNF >= " & txtNotaInicio.Text, "") & IIf(txtNotaFim.Text <> "", " AND INFNFE_IDE_NNF <= " & txtNotaFim.Text, "")
        Dim DS As System.Data.DataSet = DSCarrega("SELECT * FROM IM.NF" & IIf(FILTRO <> "", " WHERE " & Mid(FILTRO, 6), ""), Login.Strconn)

        grd.Rows.Clear()
        For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
            Dim DSI As System.Data.DataSet = DSCarrega("SELECT * FROM IM.NF_ITEM WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF ORDER BY SEQ", Login.Strconn, ":CIA_COD", Linha("CIA_COD"), ":INFNFE_IDE_SERIE", Linha("INFNFE_IDE_SERIE"), ":INFNFE_IDE_NNF", Linha("INFNFE_IDE_NNF"))
            Dim DSR As System.Data.DataSet = DSCarrega("SELECT * FROM IM.NF_REBOQUE WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF ORDER BY SEQ", Login.Strconn, ":CIA_COD", Linha("CIA_COD"), ":INFNFE_IDE_SERIE", Linha("INFNFE_IDE_SERIE"), ":INFNFE_IDE_NNF", Linha("INFNFE_IDE_NNF"))
            Dim DSV As System.Data.DataSet = DSCarrega("SELECT * FROM IM.NF_VOLUME WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF ORDER BY SEQ", Login.Strconn, ":CIA_COD", Linha("CIA_COD"), ":INFNFE_IDE_SERIE", Linha("INFNFE_IDE_SERIE"), ":INFNFE_IDE_NNF", Linha("INFNFE_IDE_NNF"))
            Dim DSD As System.Data.DataSet = DSCarrega("SELECT * FROM IM.NF_DUP WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :INFNFE_IDE_SERIE AND INFNFE_IDE_NNF = :INFNFE_IDE_NNF ORDER BY SEQ", Login.Strconn, ":CIA_COD", Linha("CIA_COD"), ":INFNFE_IDE_SERIE", Linha("INFNFE_IDE_SERIE"), ":INFNFE_IDE_NNF", Linha("INFNFE_IDE_NNF"))

            Dim xml As System.Xml.XmlDocument = Nothing
            Dim Vers As String = DS.Tables(0).Rows(0)!INFNFE_VERSAO
            Dim VersProc As String = DS.Tables(0).Rows(0)!IDE_VERPROC

            If TemNaLista(NFe.VersoesPermitidas, Vers) Then
                xml = NFe.ObtemXML(Linha, DSI.Tables(0).Rows, DSR.Tables(0).Rows, DSV.Tables(0).Rows, DSD.Tables(0).Rows)
            Else
                Stop
            End If

            Dim ARQ As String = FileExpr(txtDir.Text, Linha("CIA_COD") & "_" & Linha("INFNFE_IDE_SERIE") & "_" & Linha("INFNFE_IDE_NNF") & ".XML")
            xml.LoadXml(Replace(xml.OuterXml, " xmlns=""""", " "))
            xml.Save(ARQ)
            grd.Rows.Add(ARQ, Linha("ARQUIVO"), Linha("CIA_COD"), Linha("INFNFE_IDE_SERIE"), Linha("INFNFE_IDE_NNF"), "Pendente")
        Next

        MsgBox("Export de NF concluído.")
    End Sub


    Private Sub btnVerNoWinMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerNoWinMerge.Click
        If Not IsNothing(grd.CurrentRow) Then

            Dim Original As String = Replace(Replace(grd.CurrentRow.Cells(1).Value, "\", "/"), "~/", FileExpr(txtOrig.Text, "/"))
            Dim Normaliza As String = Icraft.IcftBase.NomeArqLivre(txtTemp.Text, System.IO.Path.GetFileName(Original))
            Dim xml As New Xml.XmlDocument
            xml.Load(Icraft.IcftBase.FileExpr(Original))
            xml.Save(Normaliza)
            Temps.Add(Normaliza)

            Dim COMA As String = txtProg.Text & " """ & grd.CurrentRow.Cells(0).Value & """ """ & Normaliza & """"
            Shell(COMA, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        Dim OK As Integer = 0
        Dim PROB As Integer = 0
        Dim ERRO As Integer = 0

        For z As Integer = 0 To grd.Rows.Count - 1

            grd.CurrentCell = grd.Rows(z).Cells(0)

            Try
                Dim TRADUZIDO As Boolean = False
                Dim Original As String = grd.CurrentRow.Cells(1).Value
                If Not Original.StartsWith("~/", StringComparison.OrdinalIgnoreCase) Then
                    TRADUZIDO = True
                Else
                    Original = Replace(Replace(grd.CurrentRow.Cells(1).Value, "\", "/"), "~/", FileExpr(txtOrig.Text, "/"))
                End If

                Dim Normaliza As String = Original
                If Not TRADUZIDO Then
                    Normaliza = Icraft.IcftBase.NomeArqLivre(txtTemp.Text, System.IO.Path.GetFileName(Original))
                    Dim xml As New Xml.XmlDocument

                    Try
                        xml.Load(Icraft.IcftBase.FileExpr(Original))
                    Catch EX As Exception
                        Throw New Exception("Probl ao obter original " & Original & ":" & EX.Message)
                    End Try

                    xml.Save(Normaliza)
                    Temps.Add(Normaliza)
                End If

                Dim ArqC As String = ObtemTexto(grd.CurrentRow.Cells(0).Value)
                Dim ArqO As String = ObtemTexto(Normaliza)


                If Not TRADUZIDO Then
                    'ACERTOS PARA CONFERËNCIA DE ORIGINAL - BANDO DE EXEMPLOS.....
                    'ArqO = Replace(ArqO, "<protNFe versao=""1.10"">", "<protNFe versao=""1.10"" xmlns=""http://www.portalfiscal.inf.br/nfe"">")
                    'ArqO = Replace(ArqO, "<protNFe versao=""1.10"">", "<protNFe versao=""1.10"" xmlns=""http://www.portalfiscal.inf.br/nfe"">")
                    'ArqO = Replace(ArqO, "<protNFe versao=""1.10"">", "<protNFe versao=""1.10"" xmlns=""http://www.portalfiscal.inf.br/nfe"">")
                    '<infNFe Id="NFe32100203262668000529550010000005608501005075" versao="1.10" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                    '<infNFe xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" Id="NFe32100203262668000529550010000005608501005075" versao="1.10">
                    '<infNFe Id="NFe32101103262668000529550010000011676642700400" versao="1.10" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                    '<infNFe xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" Id="NFe32101103262668000529550010000011676642700400" versao="1.10">
                    '<infNFe Id="(.*?)" versao="(.*?)" xmlns:xsi="(.*?)">
                    '<infNFe xmlns:xsi="$1" Id="$2" versao="$3">

                    ' ORGANIZA INFNFE XMLNS ID VERSÃO
                    ArqO = System.Text.RegularExpressions.Regex.Replace(ArqO, "<infNFe Id=""(.*?)"" versao=""(.*?)"" xmlns:xsi=""(.*?)"">", "<infNFe xmlns:xsi=""$3"" Id=""$1"" versao=""$2"">", System.Text.RegularExpressions.RegexOptions.Multiline)
                    ArqO = System.Text.RegularExpressions.Regex.Replace(ArqO, "<infNFe Id=""(.*?)"" versao=""(.*?)"">", "<infNFe xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" Id=""$1"" versao=""$2"">", System.Text.RegularExpressions.RegexOptions.Multiline)

                    '<infNFe Id="NFe33110703262668000103550010000000961900700000" versao="2.00">


                    'QTRIB COLOCA MÁSCARA FORMATANDO COM 0.0000
                    For Each ITEM As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(ArqO, "<qTrib>(.*?)</qTrib>", System.Text.RegularExpressions.RegexOptions.Multiline)
                        Dim FORMATADO As String = Replace(Format(Val(ITEM.Groups(1).Value), "0.0000"), ",", ".")
                        If ITEM.Groups(1).Value <> FORMATADO Then
                            ArqO = Replace(ArqO, ITEM.Groups(0).Value, "<qTrib>" & FORMATADO & "</qTrib>")
                        End If
                    Next

                    'VUNCOM COLOCA MÁSCARA FORMATANDO COM 0.0000000000
                    For Each ITEM As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(ArqO, "<vUnCom>(.*?)</vUnCom>", System.Text.RegularExpressions.RegexOptions.Multiline)
                        Dim FORMATADO As String = Replace(Format(Val(ITEM.Groups(1).Value), "0.0000000000"), ",", ".")
                        If ITEM.Groups(1).Value <> FORMATADO Then
                            ArqO = Replace(ArqO, ITEM.Groups(0).Value, "<vUnCom>" & FORMATADO & "</vUnCom>")
                        End If
                    Next

                    'VUNTRIB COLOCA MÁSCARA FORMATANDO COM 0.0000000000
                    For Each ITEM As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(ArqO, "<vUnTrib>(.*?)</vUnTrib>", System.Text.RegularExpressions.RegexOptions.Multiline)
                        Dim FORMATADO As String = Replace(Format(Val(ITEM.Groups(1).Value), "0.0000000000"), ",", ".")
                        If ITEM.Groups(1).Value <> FORMATADO Then
                            ArqO = Replace(ArqO, ITEM.Groups(0).Value, "<vUnTrib>" & FORMATADO & "</vUnTrib>")
                        End If
                    Next

                    'INCLUI 0 NO CNF PARA COMPARAÇÃO
                    For Each ITEM As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(ArqO, "<cNF>(.*?)</cNF>", System.Text.RegularExpressions.RegexOptions.Multiline)
                        Dim FORMATADO As String = Format(Val(ITEM.Groups(1).Value), "000000000")
                        If ITEM.Groups(1).Value <> FORMATADO Then
                            ArqO = Replace(ArqO, ITEM.Groups(0).Value, "<cNF>" & FORMATADO & "</cNF>")
                        End If
                    Next

                    'QVOL CONSIDERA SÓ PARTE INTEIRA (ELIMINA MÁSCARA)
                    For Each ITEM As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(ArqO, "<qVol>(.*?)</qVol>", System.Text.RegularExpressions.RegexOptions.Multiline)
                        If ITEM.Groups(1).Value <> "" Then
                            ArqO = Replace(ArqO, ITEM.Groups(0).Value, "<qVol>" & Val(ITEM.Groups(1).Value) & "</qVol>")
                        End If
                    Next

                    ' ACERTA PROTNFE PARA CONSIDERAR XMLNS
                    ArqO = Replace(ArqO, "<protNFe versao=""1.10"">", "<protNFe versao=""1.10"" xmlns=""http://www.portalfiscal.inf.br/nfe"">")
                    ArqO = Replace(ArqO, "<protNFe versao=""2.00"">", "<protNFe versao=""2.00"" xmlns=""http://www.portalfiscal.inf.br/nfe"">")

                    ' ELIMINA CNPJ E IE VAZIOS CASO ACONTEÇAM POIS MAIORIA NÃO OS CONSIDERA
                    ArqO = Replace(ArqO, "<CNPJ />" & vbCrLf, "")
                    ArqO = Replace(ArqO, "<IE />" & vbCrLf, "")

                    If TXTVERNORM.Checked Then
                        Kill(Normaliza)
                        Dim ARQ As New System.IO.StreamWriter(Normaliza, False)
                        grd.CurrentRow.Cells(1).Value = Normaliza
                        ARQ.Write(ArqO)
                        ARQ.Close()
                    End If
                End If

                ArqC = Icraft.IcftBase.TrocaTexto(ArqC, vbCrLf & vbCrLf, vbCrLf, Chr(9), "")
                ArqO = Icraft.IcftBase.TrocaTexto(ArqO, vbCrLf & vbCrLf, vbCrLf, Chr(9), "")
                Dim ARQCA As String() = Split(ArqC, vbCrLf)
                Dim ARQOA As String() = Split(ArqO, vbCrLf)

                Dim IG As String = "OK"
                For zz As Integer = 0 To ARQCA.Count - 1

                    Dim L1 As String = ""
                    Try
                        L1 = Trim(ARQCA(zz))
                    Catch
                    End Try
                    Dim L2 As String = ""
                    Try
                        L2 = Trim(ARQOA(zz))
                    Catch
                    End Try
                    If L1 <> L2 Then
                        IG = "PROBL:" & L1 & "<>" & L2
                        Exit For
                    End If
                Next
                grd.CurrentRow.Cells(5).Value = IG
                If IG = "OK" Then
                    OK += 1
                Else
                    PROB += 1
                End If

            Catch ex As Exception
                grd.CurrentRow.Cells(5).Value = "erro:" & ex.Message
                ERRO += 1
            End Try

        Next
        lblTot.Text = "Tot:" & OK + PROB + ERRO & " | Probl:" & PROB & " | Erro:" & ERRO & " | OK:" & OK
    End Sub

End Class