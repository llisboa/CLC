Imports System.IO

Public Class frmAlerta
    Public Shadows Sub Show(ByVal Texto As String, Optional ByVal Titulo As String = "")
        MdiParent = Princ
        pg.Value = 0
        lblTitulo.Text = Titulo
        lblEtiq.Text = Texto
        MyBase.Show()
        MyBase.Focus()
        Icraft.IcftBase.Espera(0.1)
        Tmp.Interval = 200
        Tmp.Enabled = True
    End Sub

    Sub Exec()
        pg.Value = (pg.Value + 1) Mod 100
    End Sub

    Public Contador As Integer = 0
    Sub Counter()
        Do While True
            Contador += 1
            Threading.Thread.Sleep(1000)
            Threading.Thread.Sleep(0)
        Loop
    End Sub

    Sub VerificaThread()
        If Not IsNothing(TH) Then
            TH.Abort()
            TH.Join()
            TH = Nothing
        End If
        TH = New Threading.Thread(AddressOf Counter)
        TH.Start()
    End Sub

    Public Shadows Sub HIDE()
        MyBase.Hide()
    End Sub

    Dim Tmp As New Timer
    Public TH As System.Threading.Thread

    Private Sub frmAlerta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler Tmp.Tick, AddressOf Exec
        VerificaThread()
    End Sub
End Class