Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.MedicoDestrito' table. You can move, or remove it, as needed.
        Me.MedicoDestritoTableAdapter.Fill(Me.ConsultasDataSet.MedicoDestrito)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class