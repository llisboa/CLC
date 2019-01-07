Public Class frmGridEtiq

    Private Sub frmConsEtiq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPCCAMPOS.StrConn = Login.Strconn
        OPCCAMPOS.Bind()
        EstoqueF.StrConn = Login.Strconn
        chkStatus.Orientacao = icraft.IcftFCheckOpc.OrientaTipo.Horizontal
        chkStatus.StrConn = Login.Strconn
        chkStatus.BIND()
        chkStatus.Text = "DISPONÍVEL"
        Atualizar()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Atualizar()
    End Sub

    Function InSQL(ByVal Status As String)
        Dim InStatus As String = ""
        If Status.Contains(";") Then
            Dim AR() As String = Split(Status, ";")
            For I As Integer = 0 To AR.Length - 1
                InStatus &= "'" & AR(I) & "'"
            Next
            InStatus = InStatus.Replace("''", "' , '")
        Else
            InStatus = "'" & Status & "'"
        End If
        Return InStatus
    End Function

    Sub Atualizar()
        Try
            If opc1.Checked Then
                grd2.Visible = False
                grdPrinc.Visible = True
                grdPrinc.StrConn = Login.Strconn
                grdPrinc.Usuario = Login.Usuario!usuario
                grdPrinc.SQL = "SELECT " & IIf(CAMPOS = "", "E.*", "E.ETIQUETA, " & CAMPOS) & " FROM (" & EstoqueF.SQL & ") VW, IM.ETIQUETA E, IM.PED_ITEM PI, IM.PROD_ESPEC PE WHERE VW.ETIQUETA = E.ETIQUETA AND E.PED_REF = PI.PED_REF AND E.PED_ITEM = PI.ITEM AND PI.ESPEC_SEQ = PE.SEQ AND PI.PRODUTO_COD = PE.PRODUTO_COD AND ETIQ_STATUS_COD IN (" & InSQL(chkStatus.Text) & ")"
                grdPrinc.Tabela = "ETIQUETA"
                grdPrinc.Chave = "ETIQUETA"
                grdPrinc.Sistema = Apl.Esquema
                grdPrinc.EsquemaPrinc = Apl.Esquema
                grdPrinc.EsquemaGerador = Apl.Esquema
                grdPrinc.Bind()
            Else
                grd2.Visible = True
                grd2.Visible = False
                grd2.Visible = True
                grd2.StrConn = Login.Strconn
                grd2.Usuario = Login.Usuario!usuario
                grd2.SQL = "SELECT " & IIf(CAMPOS = "", "E.*", "E.ETIQUETA, " & CAMPOS) & " FROM (" & EstoqueF.SQL & ") VW, IM.ETIQUETA E, IM.PED_ITEM PI, IM.PROD_ESPEC PE WHERE VW.ETIQUETA = E.ETIQUETA AND E.PED_REF = PI.PED_REF AND E.PED_ITEM = PI.ITEM AND PI.ESPEC_SEQ = PE.SEQ AND PI.PRODUTO_COD = PE.PRODUTO_COD AND ETIQ_STATUS_COD IN (" & InSQL(chkStatus.Text) & ")"
                grd2.Tabela = "ETIQUETA"
                grd2.Chave = "ETIQUETA"
                grd2.Sistema = Apl.Esquema
                grd2.EsquemaPrinc = Apl.Esquema
                grd2.EsquemaGerador = Apl.Esquema
                grd2.CamposFixos = "ETIQUETA"
                grd2.Bind()
            End If
        Catch ex As Exception
            Throw New Exception(Icraft.IcftBase.MessageEx(ex, "Ao atualizar"))
        End Try
    End Sub

    Private Sub EstoqueF_AposConfirmar() Handles EstoqueF.AposConfirmar
        Atualizar()
    End Sub

    Private Sub btnCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCampos.Click
        OPCCAMPOS.Visible = True
    End Sub

    Private Sub OPCCAMPOS_AposCancelar() Handles OPCCAMPOS.AposCancelar
        OPCCAMPOS.Visible = False
    End Sub

    Dim CAMPOS As String = ""
    Private Sub OPCCAMPOS_AposConfirmar() Handles OPCCAMPOS.AposConfirmar
        OPCCAMPOS.Visible = False
        CAMPOS = ""
        Try
            For Each TEXTO As String In Split(Mid(OPCCAMPOS.TextoSQL, 5, Len(OPCCAMPOS.TextoSQL) - 5), ", ")
                Dim CAMPO As String = Split(Icraft.IcftBase.TrimCasado(TEXTO, "'", "'"), " | ")(1)
                CAMPOS &= IIf(CAMPOS <> "", ", ", "") & "E." & Trim(CAMPO)
            Next
        Catch
        End Try
        Atualizar()
    End Sub

End Class