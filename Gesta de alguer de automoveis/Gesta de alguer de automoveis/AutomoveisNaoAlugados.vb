Public Class AutomoveisNaoAlugados

    Private Sub AutomoveisNaoAlugados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.Database1DataSet.DataTable2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class