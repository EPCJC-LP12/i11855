Public Class Form1

    Private Sub AluguerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.AluguerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.Clientes)
        'TODO: This line of code loads data into the 'Database1DataSet.Aluguer' table. You can move, or remove it, as needed.
        Me.AluguerTableAdapter.Fill(Me.Database1DataSet.Aluguer)

    End Sub

    Private Sub AutomoveisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomoveisToolStripMenuItem.Click
        Automoveis.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.show()
    End Sub

    Private Sub AutomoveisToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AutomoveisToolStripMenuItem1.Click
        Aluguer.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AutomoveisAluguados.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        AutomoveisNaoAlugados.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Clientereport.Show()
    End Sub
End Class
