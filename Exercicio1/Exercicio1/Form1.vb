Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.Pacientes' table. You can move, or remove it, as needed.
        Me.PacientesTableAdapter.Fill(Me.ConsultasDataSet.Pacientes)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
