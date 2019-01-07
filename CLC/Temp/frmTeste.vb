Imports Icraft.IcftBase
Public Class frmTeste
    Private Sub btnImporta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporta.Click
        Dim DS As New System.Data.DataSet
        If txtImporta.Text.EndsWith(".DSN") Then
            Try
                DS.ReadXml(txtImporta.Text)
                grdPrinc.DataSource = New System.Data.DataSet
                For z As Integer = 0 To grdPrinc.Rows.Count
                    Try
                        grdPrinc.Columns.Remove(grdPrinc.Columns(z).Name)
                    Catch ex As Exception
                    End Try
                Next
                grdPrinc.DataSource = DS.Tables(0)
            Catch ex As Exception
                Throw New Exception("Não foi possível localizar o arquivo " & txtImporta.Text.Substring(txtImporta.Text.LastIndexOf("\") + 1) & " no local especificado " & txtImporta.Text.Substring(0, txtImporta.Text.LastIndexOf("\") + 1))
            End Try
        Else
            txtImporta.Text &= ".DSN"
            Try
                DS.ReadXml(txtImporta.Text)
                grdPrinc.DataSource = DS.Tables(0)
            Catch ex As Exception
                Throw New Exception("Não foi possível localizar o arquivo " & txtImporta.Text.Substring(txtImporta.Text.LastIndexOf("\")) & "no local " & txtImporta.Text.Substring(0, txtImporta.Text.LastIndexOf("\")))
            End Try
        End If
        Dim MaxLen As Integer = 0
        Dim Len As Integer
        Dim ArMaxLen As New ArrayList
        For z As Integer = 0 To grdPrinc.Columns.Count - 1
            For x As Integer = 0 To grdPrinc.Rows.Count - 2
                Len = DS.Tables(0).Rows(x)(z).ToString.Length
                If Len > MaxLen Then
                    MaxLen = Len
                End If
            Next
            ArMaxLen.Add(MaxLen * 10)
            MaxLen = 0
            Dim Col As DataGridViewColumn = grdPrinc.Columns(z)
            If ArMaxLen(z) > Col.HeaderText.Length * 10 Then
                Col.Width = ArMaxLen(z)
            Else
                Col.Width = Col.HeaderText.Length * 12
            End If
        Next
        Try
            MsgBox("Coluna 1 = " & ArMaxLen(0) & " Coluna 2 = " & ArMaxLen(1) & " Coluna 3 = " & ArMaxLen(2) & " Coluna 4 = " & ArMaxLen(3))
        Catch ex As Exception
        End Try
    End Sub
    Dim r As Icraft.IcftBase.FormRedim
    Private Sub frmImporta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r = New Icraft.IcftBase.FormRedim(Me)
    End Sub
    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        Dim DS As New System.Data.DataSet
        Dim Etiq As String = DS.ReadXml(txtImporta.Text)
        For z As Integer = 0 To grdPrinc.Rows.Count - 2
            grdPrinc.CurrentCell = grdPrinc.Rows(z).Cells(0)
            Etiq = grdPrinc.CurrentRow.Cells(1).Value
            If Etiq.StartsWith("250") Then
                Etiq = Etiq.Substring(3)
                Etiq = Etiq.Insert(2, ".").Insert(5, ".")
            End If
            Dim vCol = New System.Windows.Forms.DataGridViewTextBoxColumn
            vCol.Name = "vCol"
            vCol.HeaderText = "Atualizado"
            vCol.CellTemplate = New DataGridViewTextBoxCell
            vCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            If z < 1 Then
                grdPrinc.Columns.Add(vCol)
            End If
            Try
                DSGrava("UPDATE IM.ETIQUETA SET STATUS_COD = 'CARREGADO' WHERE ETIQUETA = '" & Etiq & "'", Login.Strconn, ":Etiq", Etiq)
                grdPrinc.Rows(z).Cells(grdPrinc.Columns.Count - 1).Value = "SIM"
            Catch ex As Exception
                Throw New Exception("Erro ao atualizar status da linha " & z)
                grdPrinc.Rows(z).Cells(grdPrinc.Columns.Count - 1).Value = "NÃO"
            End Try
        Next
    End Sub
End Class