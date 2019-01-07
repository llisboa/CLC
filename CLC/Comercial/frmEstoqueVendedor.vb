Imports Icraft.IcftBase

Public Class frmEstoqueVendedor

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Atualizar()
    End Sub

    Sub Atualizar()
        Try
            Dim SQL As String = "SELECT SUBSTR(VW.PRODUTO_COD,0,3) PRODUTO," & vbCrLf & _
            "VW.ESPEC_SEQ SEQ," & vbCrLf & _
            "VW.ESPEC ""ESPECIFICAÇÕES""," & vbCrLf & _
            "PE.COMER_PROD ""PRODUTO [VENDEDORES]"", " & vbCrLf & _
            "PE.COMER_DIMENS ""DIMENSÃO [VENDEDORES]"", " & vbCrLf & _
            "PE.COMER_COMPL ""COMPLEMENTO [VENDEDORES]"", " & vbCrLf & _
            "VW.PEDIDO, " & vbCrLf & _
            "VW.ENTRADA, " & vbCrLf & _
            "VW.SAIDA, " & vbCrLf & _
            "VW.REAL_CALC ""REAL CALCULADO"", " & vbCrLf & _
            "VW.REAL_AVARIADO ""REAL AVARIADO"", " & vbCrLf & _
            "VW.REAL_OK ""REAL OK"", " & vbCrLf & _
            "VW.NEGOCIADO_AVARIADO ""NEGOCIADO AVARIADO"", " & vbCrLf & _
            "VW.NEGOCIADO_OK ""NEGOCIADO OK"" , " & vbCrLf & _
            "VW.RESERVADO_AVARIADO ""RESERVADO AVARIADO"", " & vbCrLf & _
            "VW.RESERVADO_OK ""RESERVADO OK""," & vbCrLf & _
            "VW.DISPONIVEL_OK ""DISPONÍVEL OK"", " & vbCrLf & _
            "VW.DISPONIVEL_AVARIADO ""DISPONÍVEL AVARIADO""" & vbCrLf & _
            "FROM IM.VW_COL_ESTOQUE_DINA VW," & vbCrLf & _
            "IM.PROD_ESPEC PE," & vbCrLf & _
            "IM.ORDEM_VENDA_ITEM OVI" & vbCrLf & _
            "WHERE SUBSTR(VW.PRODUTO_COD,0,3) = PE.PRODUTO_COD (+)" & vbCrLf & _
            "AND VW.ESPEC_SEQ                 = PE.SEQ (+)" & vbCrLf & _
            "AND OVI.STATUS_COD <> 'ENTREGUE'" & vbCrLf & _
            "AND SUBSTR(VW.PRODUTO_COD,0,3) = OVI.PRODUTO_COD (+)" & vbCrLf & _
            "AND VW.ESPEC_SEQ = OVI.ESPEC_SEQ (+)"
            If txtBusca.Text <> "" Then
                Dim CRIT As String = ""
                For Each P As String In Split(txtBusca.Text, ";")
                    CRIT &= IIf(CRIT <> "", " AND ", "") & "INSTR(UPPER(SUBSTR(VW.PRODUTO_COD,0,3) || ESPEC), '" & Trim(UCase(Icraft.IcftBase.Tratex(P))) & "')<>0"
                Next
                SQL &= " AND " & CRIT
            End If
            grdPrinc.StrConn = Login.Strconn
            grdPrinc.Usuario = Login.Usuario!usuario
            grdPrinc.SQL = SQL
            grdPrinc.ColunaNomes = "Produto;Sequencial;Especificações;Produto [Vendedor];Dimensão [Vendedor];Complemento [Vendedor];Pedido;Entrada;Saída;Real Calculado;Real Avariado;Real Ok;Negociado Avariado;Negociado Ok;Rservado Avariado;Reservado Ok;Disponível Ok;Disponível Avariado"
            grdPrinc.Bind()
            grdPrinc.Grid.ReadOnly = True
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub txtBusca_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAtualizar_Click(sender, Nothing)
        End If
    End Sub

    Private Sub frmEstoqueVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Atualizar()
    End Sub
End Class