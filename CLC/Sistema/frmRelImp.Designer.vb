<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelImp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Rpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Rpt
        '
        Me.Rpt.ActiveViewIndex = -1
        Me.Rpt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Rpt.DisplayGroupTree = False
        Me.Rpt.Location = New System.Drawing.Point(0, 0)
        Me.Rpt.Name = "Rpt"
        Me.Rpt.SelectionFormula = ""
        Me.Rpt.ShowCloseButton = False
        Me.Rpt.ShowGroupTreeButton = False
        Me.Rpt.ShowRefreshButton = False
        Me.Rpt.Size = New System.Drawing.Size(541, 240)
        Me.Rpt.TabIndex = 0
        Me.Rpt.ViewTimeSelectionFormula = ""
        '
        'frmRelImp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 287)
        Me.Controls.Add(Me.Rpt)
        Me.Name = "frmRelImp"
        Me.Text = "Visualização de Relatório"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
