Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Form1
    Public MYconnection = New MySqlConnection(MYconnectionString)
    Public MSconnection = New SqlConnection(MSconnectionString)
    Private Sub btnCheckMSSQL_Click(sender As Object, e As EventArgs) Handles btnCheckMSSQL.Click

        Try
            MSconnection.Open() 'CONNECTION OPEN FOR CONNECTION MSSQL
            If MSconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Failed!")
            End If
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btnCheckMYSQL_Click(sender As Object, e As EventArgs) Handles btnCheckMYSQL.Click

        Try
            MYconnection.Open()
            If MYconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Failed!")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub
End Class
