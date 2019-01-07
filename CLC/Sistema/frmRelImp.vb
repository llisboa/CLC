Public Class frmRelImp

    Sub Atualiza()
        Rpt.Height = Me.ClientRectangle.Height - 6
        Rpt.Width = Me.ClientRectangle.Width - 6
        Rpt.Left = 3
        Rpt.Top = 3
    End Sub

    Private Sub frmRelImp_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Atualiza()
    End Sub

End Class