Imports Icraft.IcftBase
Public Class frmTestes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblResult.Text = DSProxSeqEtiq("ETIQUETA", "IM.ETIQUETA", txtParam.Text, Login.Strconn)
    End Sub


    Private Sub btnValidaCNPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidaCNPJ.Click
        Dim CNPJ As String = Icraft.IcftBase.TrocaTexto(txtParam.Text, ".", "", "-", "", "/", "")
        Dim Txt As String
        'Try
        Txt = CNPJ.Substring(0, 12)
        'Catch ex As Exception
        'MsgBox("Informe os 12 dígitos.")

        'Finally
        If txtParam.Text <> "" Then
            Dim textoDigitado As New TextBox
            textoDigitado.Text = txtParam.Text.ToString
            textoDigitado.ReadOnly = True
            txtParam.Visible = False
            textoDigitado.Top = 52
            textoDigitado.Left = 86
            Me.Controls.Add(textoDigitado)
        End If

        Dim DV1 As Integer = DacMod11(Txt)
        Dim DV2 As Integer = DacMod11(Txt & DV1)

        If DV1 & DV2 = CNPJ.Substring(12) Then
            MsgBox("CNPJ VALIDO!")
            lblResult.Text = "OK"
        Else
            MsgBox("CNPJ INVALIDO!")
            lblResult.Text = "INVALIDO"
        End If
        'End Try




    End Sub
    Sub LblTexto(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim textoCabecalho As New FontStyle
        textoCabecalho = FontStyle.Bold

    End Sub

    Sub LblCabecalho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cabecalho As New Label

        cabecalho.Text = "Verifique o seu CNPJ"
        cabecalho.Top = 12
        cabecalho.Left = 12
        cabecalho.Width = 300

        Me.Controls.Add(cabecalho)
    End Sub

    Private Sub frmTestes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim str = "<div>"
        ret.Text = Mid(("<div><p>" & txt.Text & "</p></div>"), 0, txt.Text.LastIndexOf("<div>"))
    End Sub
End Class