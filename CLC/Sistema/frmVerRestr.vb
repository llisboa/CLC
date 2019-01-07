Public Class frmVerRestr

    'Dim f As Local.Auto

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Atualiza(Nothing)
    End Sub

    Sub Atualiza(ByVal SQL As Object)
        'pnlGeral.Controls.Clear()
        'f = New Local.Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "VER_RESTR", Login.Strconn, , , Local.UsuarioConfig.ToStyleStr, pnlGeral, SQL)
    End Sub

    Private Sub btnBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoleto.Click
        'Try
        '        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT VR.SEQ,VR.ESQUEMA,VR.MOTIVO,VR.TABELA,VR.ATIVO,VR.DEL,VR.INS,VR.UPD,VR.CODIGO  FROM IM.VER_RESTR VR, (SELECT SEQ, ESQUEMA,TABELA FROM IM.VER_RESTR WHERE SEQ=:SEQ) F WHERE F.ESQUEMA = VR.ESQUEMA (+) AND F.TABELA = VR.TABELA (+)", Login.Strconn, ":SEQ", Val(f.Criado.ChaveConcatStr))
        '        Dim Texto As New System.Text.StringBuilder
        '        Dim Tabela As String = ""
        '        Dim Esquema As String = ""
        '        For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
        '            If Tabela = "" Then
        '                Tabela = Linha!tabela
        '                Esquema = Linha!esquema
        '            End If
        '            If Icraft.IcftBase.NZ(Linha!ATIVO, 0) <> 0 AndAlso (Icraft.IcftBase.NZ(Linha!del, 0) <> 0 OrElse Icraft.IcftBase.NZ(Linha!INS, 0) <> 0 Or Icraft.IcftBase.NZ(Linha!UPD, 0) <> 0) Then
        '                Texto.AppendLine("IF " & Icraft.IcftBase.ExprExpr(" OR ", "", IIf(Icraft.IcftBase.NZ(Linha!del, 0) <> 0, "deleting", ""), IIf(Icraft.IcftBase.NZ(Linha!ins, 0) <> 0, "INSERTING", ""), IIf(Icraft.IcftBase.NZ(Linha!upd, 0) <> 0, "UPDATING", "")) & " THEN")
        '                Texto.AppendLine("IF NOT USER LIKE 'REPL_%' THEN")
        '                Texto.AppendLine("IF " & Linha!codigo & " THEN")
        '                Texto.AppendLine("RAISE_APPLICATION_ERROR(-20000,'" & Linha!motivo & "');")
        '                Texto.AppendLine("END IF;")
        '                Texto.AppendLine("END IF;")
        '                Texto.AppendLine("END IF;" & vbCrLf)
        '            End If
        '        Next

        '        If Texto.Length > 0 Then
        '            Dim Trigg As New System.Text.StringBuilder
        '            Trigg.AppendLine("CREATE OR REPLACE TRIGGER " & Esquema & "." & Tabela & "_VER")
        '            Trigg.AppendLine("AFTER INSERT OR UPDATE OR DELETE ON " & Esquema & "." & Tabela & " FOR EACH ROW")
        '            Trigg.AppendLine("BEGIN")
        '            Trigg.AppendLine(Texto.ToString)
        '            Trigg.AppendLine("END;")
        '            Icraft.IcftBase.DSGrava("BEGIN EXECUTE IMMEDIATE '" & Replace(Trigg.ToString, "'", "''") & "'; END;", Login.Strconn)
        '            MsgBox("Atualizando validação de banco de dados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '        Else
        '            Try
        '                Icraft.IcftBase.DSGrava("BEGIN EXECUTE IMMEDIATE 'DROP TRIGGER " & Esquema & "." & Tabela & "_VER'; END;", Login.Strconn)
        '                MsgBox("Validação excluída por não existirem tópicos habilitados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '            Catch EX As Exception
        '                If InStr(EX.Message, "ORA-04080") <> 0 Then
        '                    MsgBox("Nenhuma validação ativa para este tópico foi encontrada na tentativa de exclusão.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '                Else
        '                    Throw EX
        '                End If
        '            End Try
        '        End If


        '    Catch EX As Exception
        '        Throw New Exception(Icraft.IcftBase.MessageEx(EX, "Atualizando validação de banco de dados"))
        '    End Try
        'End Sub

        'Private Sub btnEmitBolFiltr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitBolFiltr.Click
        '    Try
        '        Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT VR.SEQ,VR.ESQUEMA,VR.MOTIVO,VR.TABELA,VR.ATIVO,VR.DEL,VR.INS,VR.UPD,VR.CODIGO  FROM IM.VER_RESTR VR, (SELECT SEQ, ESQUEMA,TABELA FROM IM.VER_RESTR) F WHERE F.ESQUEMA = VR.ESQUEMA (+) AND F.TABELA = VR.TABELA (+)", Login.Strconn, Val(f.Criado.ChaveConcatStr))
        '        Dim Texto As New System.Text.StringBuilder
        '        Dim Tabela As String = ""
        '        Dim Esquema As String = ""
        '        Dim Z As Integer = 0
        '        For Each Linha As System.Data.DataRow In DS.Tables(Z).Rows
        '            Tabela = Linha!tabela
        '            Esquema = Linha!esquema
        '            If Icraft.IcftBase.NZ(Linha!ATIVO, 0) <> 0 AndAlso (Icraft.IcftBase.NZ(Linha!del, 0) <> 0 OrElse Icraft.IcftBase.NZ(Linha!INS, 0) <> 0 Or Icraft.IcftBase.NZ(Linha!UPD, 0) <> 0) Then
        '                Texto.AppendLine("IF " & Icraft.IcftBase.ExprExpr(" OR ", "", IIf(Icraft.IcftBase.NZ(Linha!del, 0) <> 0, "deleting", ""), IIf(Icraft.IcftBase.NZ(Linha!ins, 0) <> 0, "INSERTING", ""), IIf(Icraft.IcftBase.NZ(Linha!upd, 0) <> 0, "UPDATING", "")) & " THEN")
        '                Texto.AppendLine("IF NOT USER LIKE 'REPL_%' THEN")
        '                Texto.AppendLine("IF " & Linha!codigo & " then")
        '                Texto.AppendLine("RAISE_APPLICATION_ERROR(-20000,'" & Linha!motivo & "');")
        '                Texto.AppendLine("END IF;")
        '                Texto.AppendLine("END IF;")
        '                Texto.AppendLine("END IF;" & vbCrLf)
        '            End If
        '            If Texto.Length > 0 Then
        '                Dim Trigg As New System.Text.StringBuilder
        '                Trigg.AppendLine("CREATE OR REPLACE TRIGGER " & Esquema & "." & Tabela & "_VER")
        '                Trigg.AppendLine("AFTER INSERT OR UPDATE OR DELETE ON " & Esquema & "." & Tabela & " FOR EACH ROW")
        '                Trigg.AppendLine("BEGIN")
        '                Trigg.AppendLine(Texto.ToString)
        '                Trigg.AppendLine("END;")
        '                Icraft.IcftBase.DSGrava("BEGIN EXECUTE IMMEDIATE '" & Replace(Trigg.ToString, "'", "''") & "'; END;", Login.Strconn)
        '                Trigg = New System.Text.StringBuilder
        '            Else
        '                Try
        '                    Icraft.IcftBase.DSGrava("BEGIN EXECUTE IMMEDIATE 'DROP TRIGGER " & Esquema & "." & Tabela & "_VER'; END;", Login.Strconn)
        '                    MsgBox("Validação excluída por não existirem tópicos habilitados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '                Catch EX As Exception
        '                    If InStr(EX.Message, "ORA-04080") <> 0 Then
        '                        MsgBox("Nenhuma validação ativa para este tópico foi encontrada na tentativa de exclusão.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '                    Else
        '                        Throw EX
        '                    End If
        '                End Try
        '            End If
        '            Z += 1
        '            Texto = New System.Text.StringBuilder
        '        Next
        '        MsgBox("Atualizando validação de banco de dados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atualizando Restrição em Banco de Dados")
        '    Catch EX As Exception
        '        Throw New Exception(Icraft.IcftBase.MessageEx(EX, "Atualizando validação de banco de dados"))
        '    End Try
    End Sub
End Class