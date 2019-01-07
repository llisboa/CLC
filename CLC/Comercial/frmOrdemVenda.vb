Imports Icraft.IcftBase

Public Class frmOrdemVenda

    Public f As Local.Auto
    Dim Client As Windows.Forms.ComboBox
    Dim Vend As Windows.Forms.ComboBox
    Dim Grd As Icraft.IcftFGrid2

    Private Sub frmOrdemVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlGeral.Controls.Clear()
        f = New Local.Auto(Me, Apl.Esquema, Apl.Esquema, Apl.Esquema, "ORDEM_VENDA", Login.Strconn, , , Local.UsuarioConfig.ToStyleStr, pnlGeral)
        Client = f.Criado.Frm.Controls.Find("fldCLIENTE_COD", True)(0)
        Vend = f.Criado.Frm.Controls.Find("fldVENDEDOR_COD", True)(0)
        Grd = f.Criado.Frm.Controls.Find("gtbORDEM_VENDA_ITEM", True)(0)
        AddHandler Grd.DepoisDeCarregar, AddressOf DepoisDeCarregar
        AddHandler Grd.AposAtualizarInfo, AddressOf MostraInfo
        AddHandler f.Criado.Frm.AposGravar, AddressOf AposGravar
        AddHandler Client.TextChanged, AddressOf AtualizaCliente
        AddHandler f.Criado.Frm.AposMostrarReg, AddressOf AposLoad
        AddHandler f.Criado.Frm.AposBuscarReg, AddressOf AposBuscar
        Grd.Bind()
        AposLoad()
    End Sub

    Sub MostraInfo(ByVal lbl As Label)
        Dim Masc As String = " \| Itens=\(.*?\)"
        If System.Text.RegularExpressions.Regex.Match(lbl.Text, Masc).Success Then
            lbl.Text = System.Text.RegularExpressions.Regex.Replace(lbl.Text, Masc, Total)
        Else
            lbl.Text &= " " & Total
        End If
    End Sub

    Public Total As String
    Private Sub DepoisDeCarregar()
        Dim pnl As System.Windows.Forms.Panel = Grd.Controls.Find("Panel1", True)(0)
        Dim lbl As Windows.Forms.Label = pnl.Controls.Find("lblInfo", True)(0)
        Dim Valor As Double
        Dim Qtd As Double
        For Each ROW As DataGridViewRow In Grd.Grid.Rows
            Valor += (ROW.Cells(8).Value * ROW.Cells(9).Value)
            Qtd += ROW.Cells(8).Value
        Next
        Total = " | Itens=(Valor: " & Valor & " Qtd: " & Qtd & ")"
    End Sub
    Sub AposBuscar(ByVal Busca As String)
        If Busca.StartsWith("PROV") Then
            btnCria.Text = "Confirmar Previsão"
        Else
            btnCria.Text = "Criar Ordem"
        End If
    End Sub

    Sub AtualizaCliente()
        Try
            If Vend.Text = "" AndAlso Client.Text <> "" Then
                Vend.Text = DSValor("VENDEDOR_COD", "IM.CIA", Login.Strconn, "COD=:COD", ":COD", Client.Text)
            End If
        Catch
        End Try
    End Sub

    Sub AposLoad(Optional ByVal sender As System.Object = Nothing)
        If f.Criado.ChaveConcatStr.ToString.StartsWith("PROV") Then
            btnCria.Text = "Confirmar Previsão"
        Else
            btnCria.Text = "Criar Ordem"
        End If
    End Sub

    Sub AposGravar(ByVal Prefixo As String, ByVal Container As Object, ByVal EsquemaTabelaOrigem As Object, ByVal Filtro As String, ByVal StrConn As Object, ByVal AtribAdic As ArrayList, ByVal Params As ArrayList)
        Try
            Dim Ref As String = f.Criado.ChaveConcatStr
            Dim LOG As Object = Login.Strconn

            Dim Qtd As Integer = Icraft.IcftBase.DSValor("COUNT(*)", "IM.ORDEM_VENDA_COMISS", LOG, "ORDEM_VENDA_REF = :REF", ":REF", Ref)

            If Qtd = 0 Then
                Dim Vend As System.Data.DataSet = Icraft.IcftBase.DSCarrega("select OV.VENDEDOR_COD, V.PERC_VENDEDOR, V.PERC_SUPERVISOR, V.SUPERVISOR from IM.ORDEM_VENDA OV, IM.VENDEDOR V where OV.VENDEDOR_COD = V.COD (+) AND OV.REF = :REF", LOG, ":REF", Ref)
                If Vend.Tables(0).Rows.Count > 0 AndAlso Icraft.IcftBase.NZV(Vend.Tables(0).Rows(0)!VENDEDOR_COD, "") <> "" Then
                    If MsgBox("Não existem dados sobre comissão. Deseja incluir com base no vendedor informado?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        DSGrava("INSERT INTO IM.ORDEM_VENDA_COMISS(ORDEM_VENDA_REF, ITEM, VENDEDOR_COD, VALOR, TIPO) VALUES(:ORDEM_VENDA_REF, :ITEM, :VENDEDOR_COD, :VALOR, :TIPO)", LOG, ":ORDEM_VENDA_REF", Ref, ":ITEM", DSProxSeq("ITEM", "IM.ORDEM_VENDA_COMISS", LOG, "ORDEM_VENDA_REF = :REF", ":REF", Ref), ":VENDEDOR_COD", Vend.Tables(0).Rows(0)!VENDEDOR_COD, ":VALOR", Vend.Tables(0).Rows(0)!PERC_VENDEDOR, ":TIPO", "%")
                        If Icraft.IcftBase.NZ(Vend.Tables(0).Rows(0)!SUPERVISOR, "") <> "" Then
                            DSGrava("INSERT INTO IM.ORDEM_VENDA_COMISS(ORDEM_VENDA_REF, ITEM, VENDEDOR_COD, VALOR, TIPO) VALUES(:ORDEM_VENDA_REF, :ITEM, :VENDEDOR_COD, :VALOR, :TIPO)", LOG, ":ORDEM_VENDA_REF", Ref, ":ITEM", DSProxSeq("ITEM", "IM.ORDEM_VENDA_COMISS", LOG, "ORDEM_VENDA_REF = :REF", ":REF", Ref), ":VENDEDOR_COD", Vend.Tables(0).Rows(0)!SUPERVISOR, ":VALOR", Vend.Tables(0).Rows(0)!PERC_SUPERVISOR, ":TIPO", "%")
                        End If
                    End If
                End If

                MsgBox("Comissão cadastrada. É importante a conferência dos lançamentos.")

            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao incluir registros de comissão.")
        End Try
    End Sub

    Sub AtualizaBtn()
        If f.Criado.ChaveConcatStr.ToString.StartsWith("PROV") Then
            btnCria.Text = "Confirmar Previsão"
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim Chave As String = f.Criado.ChaveConcatStr
        Dim DS As System.Data.DataSet = DSCarrega("SELECT SUM(DECODE(ORDEM_VENDA_REF,'" & Chave & "',1,0)) TOT, SUM(DECODE(ORDEM_VENDA_REF,STATUS_COD,'" & Chave & "','CANCELADO',1,0)) CANC, SUM(DECODE(ORDEM_VENDA_REF,'" & Chave & "',DECODE(STATUS_COD,'CANCELADO',0,1))) NAO_CANC FROM IM.ORDEM_VENDA_ITEM", Login.Strconn)
        Dim Tot As Integer = DS.Tables(0).Rows(0)("TOT")
        Dim TotCanc As Integer = DS.Tables(0).Rows(0)("CANC")
        If Tot > TotCanc Then
            If MsgBox("De " & Tot & " itens," & TotCanc & " estão cancelados." & vbCrLf & vbCrLf & "Deseja realmente cancelar todos os itens desta ordem?", MsgBoxStyle.YesNo, ) = MsgBoxResult.Yes Then
                Try
                    DSGrava("UPDATE IM.ORDEM_VENDA_ITEM SET STATUS_COD = 'CANCELADO' WHERE ORDEM_VENDA_REF = '" & Chave & "'", Login.Strconn)
                    MsgBox(Tot & " itens cancelados.")
                    Me.f.Criado.CarregaCamposEmGeral()
                Catch ex As Exception
                    MsgBox("Erro ao cancelar itens da ordem " & Chave)
                End Try
            End If
        Else
            MsgBox("Todos os itens deste ordem já foram cancelados.")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Local.MostraRelatorio("RPTORDEMVENDA", "REF = '" & f.Criado.ChaveConcatStr & "'")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pnlOrdemCriada.Visible = False
    End Sub

    Sub Copia(ByRef Padrao As Boolean)
        Padrao = False
        pnlOrdemCriada.Visible = True
        Dim CTL As Button = f.Criado.Frm.Controls.Find("btnCria", True)(0)
        pnlOrdemCriada.Top = CTL.Top
        pnlOrdemCriada.Left = CTL.Left
        pnlOrdemCriada.Top = Icraft.IcftBase.TopAcum(CTL) - (pnlOrdemCriada.Height + CTL.Top)
        pnlOrdemCriada.Left = Icraft.IcftBase.LeftAcum(CTL) + (CTL.Left - CTL.Width)
        pnlOrdemCriada.Show()
        Form.Conteudo(pnlOrdemCriada, "ORD") = DSConfigUsuario(Login.Strconn, Login.Usuario("USUARIO"), "ORDEM_COPIA_REG", "IM.SYS_CONFIG_USUARIO")
    End Sub

    Private Sub btnCria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCria.Click
        pnlOrdemCriada.Visible = True
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        If MsgBox("Confirmar criação da ordem baseada nesta previsão?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DSConfigUsuario(Login.Strconn, Login.Usuario("USUARIO"), "ORDEM_VENDA_COPIA_REG", "IM.SYS_CONFIG_USUARIO") = Form.Conteudo(pnlOrdemCriada, "ORD")
            Dim Ordem As String = f.Criado.ChaveConcatStr
            Dim ORDEMNOVA As String = Icraft.IcftBase.DSRef(ORDPREFIXO.Text.ToUpper(), "REF", "IM.ORDEM_VENDA", Login.Strconn)
            If Ordem.StartsWith("PROV") Then
                DSGrava("BEGIN IM.LB.ORDEM_VENDA_COPIA('" & Ordem & "', '" & ORDEMNOVA & "');END;", Login.Strconn)
                DSGrava("BEGIN IM.LB.ORDEM_VENDA_APAGA('" & Ordem & "');END;", Login.Strconn)
            Else
                DSGrava("BEGIN IM.LB.ORDEM_VENDA_COPIA('" & Ordem & "', '" & ORDEMNOVA & "');END;", Login.Strconn)
            End If
            f.Criado.Frm.AtualizaChaves(ORDEMNOVA)
        End If
        pnlOrdemCriada.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Confirma a exclusão da ordem " & f.Criado.ChaveConcatStr & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim Ordem As String = f.Criado.ChaveConcatStr
            Dim OrdemAnt As Integer = f.Criado.ChaveConcatStr.ToString.Substring(9) - 1
            DSGrava("BEGIN IM.LB.ORDEM_VENDA_APAGA('" & Ordem & "');END;", Login.Strconn)
            f.Criado.Frm.AtualizaChaves(f.Criado.ChaveConcatStr.ToString.Substring(9) & OrdemAnt)
        End If
    End Sub
End Class