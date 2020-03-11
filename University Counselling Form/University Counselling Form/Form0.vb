Public Class Form0
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.Show()
        Button3.Show()
        Button5.Show()
        Label1.Hide()
        Label2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Show()
        Button3.Show()
        Button5.Show()
        Label1.Hide()
        Label2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Hide()
        Button3.Hide()
        Button5.Hide()
        Label1.Show()
        Label2.Show()
        TextBox1.Show()
        TextBox2.Show()
        Button1.Show()
        Button4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text Like "rajarsi3997" And TextBox2.Text Like "Rajarsi@3997" Then
            Form7.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username/password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form0_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class