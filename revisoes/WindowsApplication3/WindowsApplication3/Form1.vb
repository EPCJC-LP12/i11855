Public Class Form1

    Private Sub UtilizadoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UtilizadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Utilizadores' table. You can move, or remove it, as needed.
        Me.UtilizadoresTableAdapter.Fill(Me.Database1DataSet.Utilizadores)

    End Sub
End Class
