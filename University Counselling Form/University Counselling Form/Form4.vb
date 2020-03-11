Imports System.ComponentModel

Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsDate(TextBox6.Text) And IsNumeric(TextBox4.Text) Then
            PERSONAL_DETAILSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            Me.DataSet11.PERSONAL_DETAILS.AcceptChanges()
            Form7.Show()
            Me.Hide()
        Else
            MessageBox.Show("Only use numbers", Label4.Text + " & " + Label8.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class