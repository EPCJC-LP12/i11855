Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.Médicos' table. You can move, or remove it, as needed.
        Me.MédicosTableAdapter.Fill(Me.ConsultasDataSet.Médicos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class