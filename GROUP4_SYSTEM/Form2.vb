Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form2

    Dim signup As String

    Private Sub btnToSignin_Click(sender As Object, e As EventArgs) Handles btnToSignin.Click
        Panel_login.Show()
        Panel_Signup.Hide()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        MSconnection = New SqlConnection(MSconnectionString)
        'MYconnection = New MySqlConnection(MYconnectionString)
        Dim MSreader As SqlDataReader
        Dim MYreader As MySqlDataReader

        If signin = "MSSQL" Then
            Using MSconnection As New SqlConnection(MSconnectionString)
                Try
                    MSconnection.Open()
                    Dim query As String = "SELECT * FROM tbl_admin WHERE username = @Username AND password = @Password"

                    Dim MScommand As New SqlCommand(query, MSconnection)
                    MScommand.Parameters.AddWithValue("@Username", txtUsername.Text)
                    MScommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                    MSreader = MScommand.ExecuteReader()

                    If MSreader.Read() Then
                        adminID = MSreader("admin_id").ToString()
                        Username = MSreader("username").ToString()
                        Password = MSreader("password").ToString()

                    End If
                    If txtUsername.Text = "" And txtPassword.Text = "" Then
                        MessageBox.Show("Fill Up!")
                    Else
                        If MSreader.HasRows Then
                            msgbox_signin.Show()
                            Form3.Show()
                            Me.Hide()
                            txtUsername.Clear()
                            txtPassword.Clear()
                        Else
                            MessageBox.Show("Incorrect Username or Password!")
                        End If
                    End If
                    MSconnection.Close()

                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MSconnection.Dispose()
                End Try
            End Using
        ElseIf signin = "MYSQL" Then
            Using MYconnection As New MySqlConnection(MYconnectionString)
                Try
                    MYconnection.Open()
                    Dim query As String = "SELECT * FROM tbl_admin WHERE username = @Username AND password = @Password"

                    Dim MYcommand As New MySqlCommand(query, MYconnection)
                    MYcommand.Parameters.AddWithValue("@Username", txtUsername.Text)
                    MYcommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                    MYreader = MYcommand.ExecuteReader()

                    If MYreader.Read() Then
                        adminID = MYreader("admin_id").ToString()
                        Username = MYreader("username").ToString()
                        Password = MYreader("password").ToString()

                    End If

                    If txtUsername.Text = "" And txtPassword.Text = "" Then
                        MessageBox.Show("Fill Up!")
                    Else
                        If MYreader.HasRows Then
                            msgbox_signin.Show()
                            Form3.Show()
                            Me.Hide()

                            txtUsername.Clear()
                            txtPassword.Clear()
                        Else
                            MessageBox.Show("Error!")
                        End If
                    End If
                    MYconnection.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MYconnection.Dispose()
                End Try
            End Using
        End If

    End Sub

    Private Sub btnToCreateAcc_Click(sender As Object, e As EventArgs) Handles btnToCreateAcc.Click
        Panel_login.Hide()
        Panel_Signup.Show()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        MSconnection = New SqlConnection(MSconnectionString)
        MYconnection = New MySqlConnection(MYconnectionString)

        If signup = "MSSQL" Then
            Try
                MSconnection.Open()

                'FOR CHECKING DUPLICATE USERNAME

                Dim query As String = "INSERT INTO tbl_admin (username, password, firstname, middlename, lastname, date_time) VALUES (@Username, @Password, @Fname, @Mname, @Lname, GETDATE())"
                Dim MScommand As New SqlCommand(query, MSconnection)
                MScommand.Parameters.AddWithValue("@Username", txtCreateUser.Text)
                MScommand.Parameters.AddWithValue("@Password", txtCreatePass.Text)
                MScommand.Parameters.AddWithValue("@Fname", txtCreateFname.Text)
                MScommand.Parameters.AddWithValue("@Mname", txtCreateMname.Text)
                MScommand.Parameters.AddWithValue("@Lname", txtCreateLname.Text)

                MScommand.ExecuteNonQuery()
                msgbox_signup.Show()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                MSconnection.Dispose()
            End Try

        ElseIf signup = "MYSQL" Then
            Try
                MYconnection.Open()

                'FOR CHECKING DUPLICATE USERNAME

                Dim query As String = "INSERT INTO tbl_admin (username, password, firstname, middlename, lastname, date_time) VALUES (@Username, @Password, @Fname, @Mname, @Lname, NOW())"
                Dim MYcommand As New MySqlCommand(query, MYconnection)
                MYcommand.Parameters.AddWithValue("@Username", txtCreateUser.Text)
                MYcommand.Parameters.AddWithValue("@Password", txtCreatePass.Text)
                MYcommand.Parameters.AddWithValue("@Fname", txtCreateFname.Text)
                MYcommand.Parameters.AddWithValue("@Mname", txtCreateMname.Text)
                MYcommand.Parameters.AddWithValue("@Lname", txtCreateLname.Text)

                MYcommand.ExecuteNonQuery()
                msgbox_signup.Show()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MYconnection.Dispose()
            End Try

        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_Signup.Hide()
    End Sub

    Private Sub rdo_MS_signup_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_MS_signup.CheckedChanged
        signup = "MSSQL"
    End Sub

    Private Sub rdo_MY_signup_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_MY_signup.CheckedChanged
        signup = "MYSQL"
    End Sub

    Private Sub rdo_MS_login_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_MS_login.CheckedChanged
        signin = "MSSQL"
    End Sub

    Private Sub rdo_MY_login_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_MY_login.CheckedChanged
        signin = "MYSQL"
    End Sub


    'Private Sub Form2(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Form1.Close()
    'End Sub
End Class