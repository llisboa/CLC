Imports System.Windows.Forms

Public Class Login
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Loga()
        Catch EX As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(EX, "Login Incorreto"))
        End Try
    End Sub

    Public Sub Loga()
        Dim DS As System.Data.DataSet = Nothing
        Dim Conn As System.Configuration.ConnectionStringSettings = Icraft.IcftBase.WebConn("strconn")
        Strconn = Icraft.IcftBase.StrConnObj("STRCONN;USER:" & txtLogin.Text & ";PASSWORD:" & txtSenha.Text)
        DS = Icraft.IcftBase.DSCarrega("SELECT * FROM " & Apl.Esquema & ".GER_USUARIO WHERE UPPER(USUARIO)=:USUARIO AND SISTEMA='" & Apl.Esquema & "'", Strconn, ":USUARIO", UCase(txtLogin.Text))
        If DS.Tables.Count = 1 AndAlso DS.Tables(0).Rows.Count = 1 Then
            Login.Perm = DS.Tables(0).Rows(0).Item(6)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Princ.Mostra()
            Me.Hide()
            Usuario = DS.Tables(0).Rows(0)
            frmConfigUsuario.Carregar(False)
            Exit Sub
        Else
            Throw New Exception("Usuário não encontrado")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
            Princ.Close()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Falha no Cancelamento"))
        End Try
    End Sub

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            txtLogin.Focus()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ativando Login"))
        End Try
    End Sub

    Private Sub Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Strconn = Nothing
            Princ.Close()
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Fechando Login"))
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Princ.Opacity = 0
            Text = Text & " - " & Princ.Text
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Carregando Login"))
        End Try
    End Sub

    Public Strconn As Object = Nothing
    Public Usuario As System.Data.DataRow = Nothing

    Private Sub txtLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLogin.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Shared _Perm As String
    Public Shared Property Perm() As String
        Get
            Return _Perm
        End Get
        Set(ByVal value As String)
            _Perm = value
        End Set
    End Property

End Class
