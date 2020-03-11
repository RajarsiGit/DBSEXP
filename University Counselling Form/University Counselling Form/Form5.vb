Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsDate(TextBox5.Text) And IsNumeric(TextBox1.Text) Then
            ADMISSIONTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            Me.DataSet11.PERSONAL_DETAILS.AcceptChanges()
            Me.Hide()
            Form7.Show()
        Else
            MessageBox.Show("Only use numbers", Label1.Text + " & " + Label6.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class