Public Class Aluguer

    Private Sub Aluguer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Aluguer' table. You can move, or remove it, as needed.
        Me.AluguerTableAdapter.Fill(Me.Database1DataSet.Aluguer)
        'TODO: This line of code loads data into the 'Database1DataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.Clientes)
        'TODO: This line of code loads data into the 'Database1DataSet.Automoveis' table. You can move, or remove it, as needed.
        Me.AutomoveisTableAdapter.Fill(Me.Database1DataSet.Automoveis)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Me.AluguerTableAdapter.Insert(Me.DateTimePicker1.Value, SqlTypes.SqlDateTime.Null, Me.ComboBox2.SelectedValue, Me.ComboBox1.SelectedValue)

            MessageBox.Show("Inserido com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class