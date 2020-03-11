Imports System.ComponentModel

Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) And IsNumeric(TextBox5.Text) Then
            RANKTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            Me.DataSet11.RANK.AcceptChanges()
            Me.Hide()
            Form0.Show()
        Else
            MessageBox.Show("Only use numbers", Label3.Text + " & " + Label4.Text + " & " + Label6.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class