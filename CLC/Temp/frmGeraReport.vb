Public Class frmGeraReport

    Dim TAMCARAC As Integer = 96
    Dim TAMLINHA As Integer = 300
    Dim ESPACO As Integer = 100



    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        Icraft.IcftBase.DSConfig(Login.Strconn, "FRMGERAREPORT", Apl.Esquema & ".SYS_CONFIG_GLOBAL") = Icraft.IcftBase.Form.Conteudo(Me, "FLD")

        Dim REL As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        REL.Load(Icraft.IcftBase.FileExpr(FLDDIR.Text, FLDRELBASE.Text))
        Dim ARQ As String = Icraft.IcftBase.FileExpr(FLDDIR.Text, FLDRELDESTINO.Text)
        If System.IO.File.Exists(ARQ) Then
            Kill(ARQ)
            Try
                Kill(System.IO.Path.GetFileNameWithoutExtension(ARQ) & ".vb")
            Catch
            End Try
        End If

        Dim TABELAS As String = Join(Icraft.IcftBase.ItemsToArrayList(REL.Database.Tables, "NAME").ToArray, ";")
        Dim DEFS As Icraft.IcftBase.Defs = Nothing
        Try
            DEFS = New Icraft.IcftBase.Defs(APL.ESQUEMA, TABELAS, Login.Strconn, APL.ESQUEMA)
        Catch
        End Try

        ' ACERTA DEFS OU VARS
        For Each OBJ As CrystalDecisions.CrystalReports.Engine.ReportObject In REL.ReportDefinition.ReportObjects
            If OBJ.Name = "VarLogotipo" Then
                OBJ.Top = 171
                OBJ.Left = 0
                OBJ.Height = 1171
                OBJ.Width = 1454
            End If
        Next


        If FLDTIPO.Text = "Tabular" Then

            ' ACERTA CAMPOS
            Dim X As Integer = 0
            For Each OBJ As CrystalDecisions.CrystalReports.Engine.ReportObject In REL.ReportDefinition.ReportObjects
                If Not OBJ.Name Like "Def*" Then
                    If TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.FieldObject Then
                        Dim CAMPO As CrystalDecisions.CrystalReports.Engine.FieldObject = OBJ
                        CAMPO.ApplyFont(New System.Drawing.Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point))
                        Try
                            Dim TABCAMPO As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(CAMPO.DataSource.FormulaName, "\{(.*?)\.(.*?)\}")
                            Dim CAMPODEF As System.Data.DataRow = DEFS.Campo(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value)
                            DEFINETAMCAMPO(REL, DEFS, TABCAMPO, CAMPO, CAMPODEF)
                        Catch
                        End Try
                        CAMPO.Left = X
                        CAMPO.Top = 0
                        X = X + CAMPO.Width + ESPACO
                    End If
                End If
            Next

            ' ACERTA ETIQUETAS
            For Each OBJ As CrystalDecisions.CrystalReports.Engine.ReportObject In REL.ReportDefinition.ReportObjects
                If Not OBJ.Name Like "Def*" Then
                    If TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.FieldHeadingObject Then
                        Dim ETIQ As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = OBJ
                        ETIQ.ApplyFont(New System.Drawing.Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point))
                        Dim CAMPO As CrystalDecisions.CrystalReports.Engine.FieldObject = REL.ReportDefinition.ReportObjects(ETIQ.FieldObjectName)
                        Try
                            Dim TABCAMPO As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(CAMPO.DataSource.FormulaName, "\{(.*?)\.(.*?)\}")
                            Dim CAMPODEF As System.Data.DataRow = DEFS.Campo(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value)
                            ETIQ.Text = CAMPODEF("ETIQ")
                        Catch
                        End Try
                        ETIQ.Width = CAMPO.Width
                        ETIQ.Left = CAMPO.Left
                        ETIQ.Top = 1482
                    End If
                End If
            Next

        ElseIf FLDTIPO.Text = "Colunar" Then
            Dim X(20) As Integer
            Dim y(20) As Integer
            Dim XMAX As Integer = 15390


            For Each OBJ As CrystalDecisions.CrystalReports.Engine.ReportObject In REL.ReportDefinition.ReportObjects
                If Not OBJ.Name Like "Def*" Then
                    Dim ss = Sec(REL, OBJ.Name)
                    If TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.FieldHeadingObject Then
                        Dim ETIQ As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = OBJ
                        Dim CAMPO As CrystalDecisions.CrystalReports.Engine.FieldObject = REL.ReportDefinition.ReportObjects(ETIQ.FieldObjectName)

                        Try
                            Dim TABCAMPO As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(CAMPO.DataSource.FormulaName, "\{(.*?)\.(.*?)\}")
                            Dim CAMPODEF As System.Data.DataRow = DEFS.Campo(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value)
                            ETIQ.Width = System.Math.Max(10, (Len(CAMPODEF!ETIQ) + 1)) * TAMCARAC
                            ETIQ.Text = CAMPODEF!ETIQ & ":"
                            DEFINETAMCAMPO(REL, DEFS, TABCAMPO, CAMPO, CAMPODEF)
                        Catch
                        End Try

                        Dim TAMCAMPO As Integer = CAMPO.Width

                        If X(ss) + ETIQ.Width + CAMPO.Width > XMAX Then
                            y(ss) += TAMLINHA
                            X(ss) = 0
                        End If

                        ETIQ.Left = X(ss)
                        ETIQ.Top = y(ss) + 8
                        ETIQ.ObjectFormat.HorizontalAlignment = CrystalDecisions.Shared.Alignment.LeftAlign

                        CAMPO.Left = X(ss) + ETIQ.Width
                        CAMPO.Top = y(ss)

                        X(ss) += ETIQ.Width + CAMPO.Width + ESPACO
                    ElseIf TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.TextObject Then
                        Dim TOBJ As CrystalDecisions.CrystalReports.Engine.TextObject = OBJ
                        TOBJ.ApplyFont(New System.Drawing.Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point))

                    End If
                End If
            Next

            For Each OBJ As CrystalDecisions.CrystalReports.Engine.ReportObject In REL.ReportDefinition.ReportObjects
                If Not OBJ.Name Like "Def*" Then
                    If TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.FieldHeadingObject Then
                        Dim ETIQ As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = OBJ
                        ETIQ.ApplyFont(New System.Drawing.Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point))
                    ElseIf TypeOf OBJ Is CrystalDecisions.CrystalReports.Engine.FieldObject Then
                        Dim CAMPO As CrystalDecisions.CrystalReports.Engine.FieldObject = OBJ

                        Dim TABCAMPO As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(CAMPO.DataSource.FormulaName, "\{(.*?)\.(.*?)\}")
                        Dim CAMPODEF As System.Data.DataRow = DEFS.Campo(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value)
                        DEFINETAMCAMPO(REL, DEFS, TABCAMPO, CAMPO, CAMPODEF)

                        CAMPO.ApplyFont(New System.Drawing.Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point))
                    End If
                End If
            Next

        End If

        REL.SaveAs(ARQ, False)
        MsgBox("OK")
    End Sub

    Sub DEFINETAMCAMPO(ByVal rel As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal DEFS As Icraft.IcftBase.Defs, ByVal TABCAMPO As System.Text.RegularExpressions.Match, ByRef CAMPO As CrystalDecisions.CrystalReports.Engine.FieldObject, ByVal CAMPODEF As System.Data.DataRow)
        Dim TIPO As Icraft.IcftBase.Defs.TipoDefEstrut = Nothing

        Try
            TIPO = DEFS.TipoDef(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value)
        Catch
        End Try

        If Icraft.IcftBase.NZ(CAMPODEF!FORMATO, "") = "MOMENTO" Then
            CAMPO.Width = 17 * TAMCARAC

            CAMPO.FieldFormat.TimeFormat.HourFormat = CrystalDecisions.Shared.HourFormat.NumericHour
            CAMPO.FieldFormat.TimeFormat.MinuteFormat = CrystalDecisions.Shared.MinuteFormat.NumericMinute
            CAMPO.FieldFormat.TimeFormat.SecondFormat = CrystalDecisions.Shared.SecondFormat.NumericSecond
        ElseIf Not IsNothing(TIPO) AndAlso TIPO.Tipo = "DATE" Then
            CAMPO.Width = 10 * TAMCARAC
            CAMPO.FieldFormat.TimeFormat.HourFormat = CrystalDecisions.Shared.HourFormat.NoHour
            CAMPO.FieldFormat.TimeFormat.MinuteFormat = CrystalDecisions.Shared.MinuteFormat.NoMinute
            CAMPO.FieldFormat.TimeFormat.SecondFormat = CrystalDecisions.Shared.SecondFormat.NumericNoSecond
        ElseIf Not IsNothing(TIPO) AndAlso TIPO.Tipo = "FLOAT" Then
            CAMPO.Width = 18 * TAMCARAC
        ElseIf Not IsNothing(TIPO) AndAlso TIPO.Tipo = "NUMBER" Then
            CAMPO.Width = (TIPO.Tamanho + TIPO.TamDecimal + 3) * TAMCARAC
            CAMPO.FieldFormat.NumericFormat.DecimalPlaces = TIPO.TamDecimal
        ElseIf Not IsNothing(TIPO) Then
            CAMPO.Width = System.Math.Max(10, Val(DEFS.TamMax(TABCAMPO.Groups(1).Value, TABCAMPO.Groups(2).Value))) * TAMCARAC * 1.145
        End If
    End Sub

    Private Sub frmGeraReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icraft.IcftBase.Form.Conteudo(Me, "FLD") = Icraft.IcftBase.DSConfig(Login.Strconn, "FRMGERAREPORT", Apl.Esquema & ".SYS_CONFIG_GLOBAL")
    End Sub

    Function Sec(ByVal rel As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal obj As String) As Integer
        Static Dict As Dictionary(Of String, Integer) = Nothing
        If IsNothing(Dict) Then
            Dict = New Dictionary(Of String, Integer)
            For z As Integer = 0 To rel.ReportDefinition.Sections.Count - 1
                For Each Atual As CrystalDecisions.CrystalReports.Engine.ReportObject In rel.ReportDefinition.Sections(z).ReportObjects
                    Dict.Add(Atual.Name, z)
                Next
            Next
        End If

        Return Dict(obj)
    End Function
End Class
