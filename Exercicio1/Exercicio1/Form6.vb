Public Class Form6

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.ConsultasDataSet.DataTable2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class