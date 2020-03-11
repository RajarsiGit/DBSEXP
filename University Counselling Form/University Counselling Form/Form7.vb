Imports System.ComponentModel

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.STUDENTTableAdapter.Fill(Me.DataSet11.STUDENT)
        Me.PAYMENT_DETAILSTableAdapter.Fill(Me.DataSet11.PAYMENT_DETAILS)
        Me.RANKTableAdapter.Fill(Me.DataSet11.RANK)
        Me.ADMISSIONTableAdapter.Fill(Me.DataSet11.ADMISSION)
        Me.ADDRESSTableAdapter.Fill(Me.DataSet11.ADDRESS)
        Me.PERSONAL_DETAILSTableAdapter.Fill(Me.DataSet11.PERSONAL_DETAILS)
        Me.STUDENTTableAdapter.Fill(Me.DataSet11.STUDENT)

        DataGridView1.DataSource = BindingSource1
        DataGridView2.DataSource = BindingSource2
        DataGridView3.DataSource = BindingSource3
        DataGridView4.DataSource = BindingSource4
        DataGridView5.DataSource = BindingSource5
        DataGridView6.DataSource = BindingSource6
    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form0.Show()
    End Sub
End Class