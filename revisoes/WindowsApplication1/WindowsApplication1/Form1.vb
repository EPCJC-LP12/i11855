Public Class Form1
    Dim conViagem As Double
    Dim custViagem As Double

    Private Sub calcular()
        Dim preco As Double = CDbl(TextBox1.Text)
        Dim consumo As Double = CDbl(TextBox2.Text)
        Dim distancia As Double = CDbl(TextBox3.Text)

        conViagem = consumo * distancia / 100
        custViagem = distancia * preco
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcular()
        Me.TextBox4 = conViagem
        Me.TextBox5 = custViagem
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
