Public Class frmBoleto

    Class Auto
        Public Criado As Local.GeraFormApl = Nothing
        Sub New(ByVal Formulario As Windows.Forms.Form, ByVal Sistema As String, ByVal EsquemaPrinc As String, ByVal EsquemaGerador As String, ByVal Tabela As String, ByVal StrConn As Object, Optional ByVal LargEtiq As Integer = 0, Optional ByVal LargCampo As Integer = 0, Optional ByVal UsuarioConfig As String = "", Optional ByVal ContainerParaCriacao As Object = Nothing, Optional ByVal Consulta As String = "")
            Criado = New Local.GeraFormApl(Formulario, Sistema, EsquemaPrinc, EsquemaGerador, Tabela, StrConn, UCase(Login.Usuario!USUARIO), LargEtiq, LargCampo, UsuarioConfig, ContainerParaCriacao, Consulta)
            AddHandler Criado.MostraStatus, AddressOf MostraStatus
        End Sub
        Public Shared Sub MostraStatus(ByVal Texto As String)
            Princ.lblStatus.Text = Texto
        End Sub
    End Class

    Dim f As Auto
    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Dim sql As String = ""
        Dim PROD As String = Icraft.IcftBase.ObtemValorCtl(fttProduto)
        If PROD <> "" Then
            sql &= IIf(sql <> "", " AND ", "") & "PRODUTO_SEQ = " & PROD
        End If
        If fttMatr.Text <> "" Then
            sql &= IIf(sql <> "", " AND ", "") & "SACADO_SOCIO_MAT = " & fttMatr.Text
        End If
        If fttNome.Text <> "" Then
            sql &= IIf(sql <> "", " AND ", "") & "INSTR(UPPER(SACADO_NOME), '" & Icraft.IcftBase.Tratex(UCase(fttNome.Text)) & "')<>0"
        End If
        If fttCPF.Text <> "" Then
            sql &= IIf(sql <> "", " AND ", "") & "REPLACE(REPLACE(SACADO_CPF,'-',''),'.','') = '" & Icraft.IcftBase.TrocaTexto(Icraft.IcftBase.Tratex(fttCPF.Text), "-", "", ".", "") & "'"
        End If
        If fttCNPJ.Text <> "" Then
            sql &= IIf(sql <> "", " AND ", "") & "REPLACE(REPLACE(REPLACE(SACADO_CNPJ,'-',''),'.',''),'/','') = '" & Icraft.IcftBase.TrocaTexto(Icraft.IcftBase.Tratex(fttCNPJ.Text), "-", "", ".", "", "/", "") & "'"
        End If
        Atualiza("SELECT * FROM " & Apl.Esquema & ".BOLETO" & IIf(sql <> "", " WHERE " & sql, ""))
        Me.f.Criado.CarregaCamposEmGeral()
    End Sub

    Sub Atualiza(ByVal SQL As Object)
        pnlBoletos.Controls.Clear()
        f = New Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "BOLETO", Login.Strconn, , , Local.UsuarioConfig.ToStyleStr, pnlBoletos)
    End Sub

    Private Sub btnBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoleto.Click
        Dim Chave As String = f.Criado.ChaveConcatStr
        Dim FF As New Icraft.IcftFFiltro
        Dim Rels As New Dictionary(Of String, Local.RelDets)
        If Chave <> "" Then
            Local.MostraRelatorio("RPTBOLETORELITAU", "SEQ = " & Chave)
        End If
    End Sub

    Private Sub btnEmitBolFiltr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitBolFiltr.Click
        Dim crit As String = ""
        Dim Z As Integer = 0
        If f.Criado.Frm.DSChaves.Tables(0).Rows.Count > 30 Then
            Throw New Exception("Quantidade máxima permitida para impressão de boletos é de 30 folhas. Você está tentando imprimir " & f.Criado.Frm.DSChaves.Tables(0).Rows.Count & " registros.")
        End If
        For Each Linha As System.Data.DataRow In f.Criado.Frm.DSChaves.Tables(0).Rows
            crit &= IIf(crit <> "", ", ", "") & Linha(0)
        Next
        If crit = "" Then
            MsgBox("Sem registros para imprimir.", MsgBoxStyle.Critical, "Boletos filtrados.")
        Else
            Local.MostraRelatorio("RPTBOLETORELITAU", "SEQ IN (" & crit & ")")
        End If
    End Sub

End Class