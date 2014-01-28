Public Class Form5

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.ConsultasDataSet.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class