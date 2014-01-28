Public Class Form4

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultasDataSet.PacienteDistrito' table. You can move, or remove it, as needed.
        Me.PacienteDistritoTableAdapter.Fill(Me.ConsultasDataSet.PacienteDistrito)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class