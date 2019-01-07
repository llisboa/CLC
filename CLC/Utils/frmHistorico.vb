Imports Icraft.IcftBase
Imports CLC.Local
Imports Icraft.IcftBase.RetornaChaveConcatStr

Public Class frmHistorico

    Public Function ExibeHist2(ByVal TipoConsulta As String, ByVal TabelaouSQL As String, ByVal Campo1 As String, ByVal Value1 As String, ByVal Campo2 As String, ByVal Value2 As String, ByVal StrConn As Object) As Object
        Dim Ret As String
        If TipoConsulta = "CRIACAO" Then
            Dim DSCriacao As DataSet = DSCarrega("SELECT (" & "SYS_MOMENTO_CRIA" & ") AS MOMENTO , (" & "SYS_USUARIO_CRIA" & ") AS USUARIO , (" & "SYS_LOCAL_CRIA" & ") AS LOCAL FROM (" & Apl.Esquema & "." & TabelaouSQL & ") WHERE (" & Campo1 & ") = (" & "'" & Value1 & "'" & ") AND (" & Campo2 & ") = (" & "'" & Value2 & "'" & ")", StrConn)
            Dim Criacao As String = DSCriacao.Tables(0).Rows(0)("MOMENTO") & "," & DSCriacao.Tables(0).Rows(0)("USUARIO") & "," & DSCriacao.Tables(0).Rows(0)("LOCAL")
            Ret = Criacao
            Return Ret
        ElseIf TipoConsulta = "ATT" Then
            Dim DSAtualizacao = DSCarrega("SELECT (" & "SYS_MOMENTO_ATUALIZA" & ") AS MOMENTO , (" & "SYS_USUARIO_ATUALIZA" & ") AS USUARIO , (" & "SYS_LOCAL_ATUALIZA" & ") AS LOCAL FROM (" & Apl.Esquema & "." & TabelaouSQL & ") WHERE (" & Campo1 & ") = (" & "'" & Value1 & "'" & ") AND (" & Campo2 & ") = (" & "'" & Value2 & "'" & ")", StrConn)
            Dim Atualizacao As String = DSAtualizacao.Tables(0).Rows(0)("MOMENTO") & "," & DSAtualizacao.Tables(0).Rows(0)("USUARIO") & "," & DSAtualizacao.Tables(0).Rows(0)("LOCAL")
            If Atualizacao = ",," Then
                Return ("Não existe atualização")
            Else
                Ret = Atualizacao
                Return Ret
            End If
        End If
        Return MsgBox("A referência buscada não existe.")
    End Function

    Public Function ExibeHist(ByVal TipoConsulta As String, ByVal TabelaouSQL As String, ByVal Campo1 As String, ByVal Value1 As String, ByVal StrConn As Object) As Object
        Dim Ret As String
        If TipoConsulta = "CRIACAO" Then
            Dim DSCriacao As DataSet = DSCarrega("SELECT (" & "SYS_MOMENTO_CRIA" & ") AS MOMENTO , (" & "SYS_USUARIO_CRIA" & ") AS USUARIO , (" & "SYS_LOCAL_CRIA" & ") AS LOCAL FROM (" & Apl.Esquema & "." & TabelaouSQL & ") WHERE (" & Campo1 & ") = (" & "'" & Value1 & "'" & ")", StrConn)
            Dim Criacao As String = DSCriacao.Tables(0).Rows(0)("MOMENTO") & "," & DSCriacao.Tables(0).Rows(0)("USUARIO") & "," & DSCriacao.Tables(0).Rows(0)("LOCAL")
            Ret = Criacao
            Return Ret
        ElseIf TipoConsulta = "ATT" Then
            Dim DSAtualizacao = DSCarrega("SELECT (" & "SYS_MOMENTO_ATUALIZA" & ") AS MOMENTO , (" & "SYS_USUARIO_ATUALIZA" & ") AS USUARIO , (" & "SYS_LOCAL_ATUALIZA" & ") AS LOCAL FROM (" & Apl.Esquema & "." & TabelaouSQL & ") WHERE (" & Campo1 & ") = (" & "'" & Value1 & "'" & ")", StrConn)
            Dim Atualizacao As String = DSAtualizacao.Tables(0).Rows(0)("MOMENTO") & "," & DSAtualizacao.Tables(0).Rows(0)("USUARIO") & "," & DSAtualizacao.Tables(0).Rows(0)("LOCAL")
            If Atualizacao = ",," Then
                Return ("Não existe atualização")
            Else
                Ret = Atualizacao
                Return Ret
            End If
        End If
        Return MsgBox("A referência buscada não existe.")
    End Function

    Private Sub btnCriacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriacao.Click, tabCria.Click
        Dim Texto As String = ""
        Dim _Campo1 As String = ""
        Dim _Value1 As String = ""
        Dim _Campo2 As String = ""
        Dim _Value2 As String = ""
        If RetornaChaveConcat.IndexOf(";") > 0 Then
            Dim Posicao As String = RetornaChaveConcat.IndexOf(";")
            _Campo1 = PKey(NomeTabela, 1, Login.Strconn)
            _Value1 = RetornaChaveConcat.Substring(0, Posicao)
            _Campo2 = PKey(NomeTabela, 2, Login.Strconn)
            _Value2 = RetornaChaveConcat.Substring(Posicao + 1)
            lblIdentif.Text = _Value2
            Texto = ExibeHist2("CRIACAO", NomeTabela, _Campo1, _Value1, _Campo2, _Value2, Login.Strconn)
        Else
            _Campo1 = PKey(NomeTabela, 1, Login.Strconn)
            _Value1 = RetornaChaveConcat
            lblIdentif.Text = _Value1
            Texto = ExibeHist("CRIACAO", NomeTabela, _Campo1, _Value1, Login.Strconn)
        End If
        Dim Matriz() As String
        Matriz = Texto.Split(",")
        txtCria_Momento.Text = (Matriz(0))
        txtCria_Usuario.Text = (Matriz(1))
        txtCria_Local.Text = (Matriz(2))
    End Sub

    Private Sub btnAtt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtt.Click, TabAtt.Click
        Dim Texto As String = ""
        Dim _Campo1 As String = ""
        Dim _Value1 As String = ""
        Dim _Campo2 As String = ""
        Dim _Value2 As String = ""
        If RetornaChaveConcat.IndexOf(";") > 0 Then
            Dim Posicao As String = RetornaChaveConcat.IndexOf(";")
            _Campo1 = PKey(NomeTabela, 1, Login.Strconn)
            _Value1 = RetornaChaveConcat.Substring(0, Posicao)
            _Campo2 = PKey(NomeTabela, 2, Login.Strconn)
            _Value2 = RetornaChaveConcat.Substring(Posicao + 1)
            lblIdentif.Text = _Value2
            Texto = ExibeHist2("ATT", NomeTabela, _Campo1, _Value1, _Campo2, _Value2, Login.Strconn)
        Else
            _Campo1 = PKey(NomeTabela, 1, Login.Strconn)
            _Value1 = RetornaChaveConcat
            lblIdentif.Text = _Value1
            Texto = ExibeHist("ATT", NomeTabela, _Campo1, _Value1, Login.Strconn)
        End If
        Dim Matriz() As String
        Matriz = Texto.Split(",")
        txtAtt_Momento.Text = (Matriz(0))
        txtAtt_Usuario.Text = (Matriz(1))
        txtAtt_Local.Text = (Matriz(2))
    End Sub

    Private Sub frmHistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIdentif.Text = RetornaChaveConcat
    End Sub

End Class