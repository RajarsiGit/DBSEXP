Public Class Form3
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PAYMENT_DETAILSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.DataSet11.PAYMENT_DETAILS.AcceptChanges()
        Me.Hide()
        Form4.Show()
    End Sub
End Class