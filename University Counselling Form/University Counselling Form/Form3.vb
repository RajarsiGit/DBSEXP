Imports System.ComponentModel

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsDate(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
            PAYMENT_DETAILSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            Me.DataSet11.PAYMENT_DETAILS.AcceptChanges()
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("Only use numbers", Label4.Text + " & " + Label3.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class