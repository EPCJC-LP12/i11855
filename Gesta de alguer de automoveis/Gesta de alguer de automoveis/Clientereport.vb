Public Class Clientereport

    Private Sub Cliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class