Imports Icraft.IcftBase
Imports CLC.Login
Public Class frmGerUsuario
    Dim Auto As New Local.Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "GER_USUARIO", Login.Strconn)

    Sub AntesDeExcluirReg(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)
        Try
            DSGrava("BEGIN EXECUTE IMMEDIATE 'DROP USER " & P("FLDUSUARIO", , Container) & " CASCADE'; END;", StrConn)
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Erro ao tentar gravar."))
        End Try
    End Sub

    Sub AntesDeGravaReg(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)
        Dim DS As New DataSet
        Try
            DS = DSCarrega("SELECT COUNT(*) AS COUNT FROM " & Apl.Esquema & ".GER_USUARIO WHERE USUARIO = '" & Icraft.IcftBase.P("FLDUSUARIO", , Container) & "'", Login.Strconn)
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Erro ao tentar gravar."))
        End Try

        If DS.Tables(0).Rows(0)("COUNT") < 1 Then
            Try
                DSGrava("BEGIN EXECUTE IMMEDIATE 'CREATE USER " & P("FLDUSUARIO", , Container) & " IDENTIFIED BY " & P("FLDSENHA", , Container) & " DEFAULT TABLESPACE T_IM_DAT TEMPORARY TABLESPACE TEMP PROFILE DEFAULT ACCOUNT UNLOCK'; END;", StrConn)
                DSGrava("BEGIN EXECUTE IMMEDIATE 'GRANT ALL PRIVILEGES TO " & P("FLDUSUARIO", , Container) & "'; END;", StrConn)
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Erro ao tentar gravar."))
            End Try
        Else
            Try
                DSGrava("BEGIN EXECUTE IMMEDIATE 'DROP USER " & P("FLDUSUARIO", , Container) & " CASCADE'; END;", StrConn)
                DSGrava("DELETE IM.GER_USUARIO WHERE USUARIO = '" & P("FLDUSUARIO", , Container) & "'", StrConn)
                DSGrava("BEGIN EXECUTE IMMEDIATE 'CREATE USER " & P("FLDUSUARIO", , Container) & " IDENTIFIED BY " & P("FLDSENHA", , Container) & " DEFAULT TABLESPACE T_IM_DAT TEMPORARY TABLESPACE TEMP PROFILE DEFAULT ACCOUNT UNLOCK'; END;", StrConn)
                DSGrava("BEGIN EXECUTE IMMEDIATE 'GRANT ALL PRIVILEGES TO " & P("FLDUSUARIO", , Container) & "'; END;", StrConn)
            Catch ex As Exception
                Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Erro ao tentar gravar."))
            End Try
        End If
    End Sub

    Private Sub frmGerUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler Auto.Criado.AntesDeGravar, AddressOf AntesDeGravaReg
        AddHandler Auto.Criado.AntesDeExcluir, AddressOf AntesDeExcluirReg
    End Sub

End Class