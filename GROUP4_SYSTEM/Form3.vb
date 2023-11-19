Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim ID As String = ""

    Public Sub adminFullname()
        If signin = "MSSQL" Then
            MSconnection = New SqlConnection(MSconnectionString)
            Dim query As String = "SELECT CONCAT(firstname, ' ', middlename, ' ', lastname) AS labelfullname FROM tbl_admin WHERE admin_id = @ID;"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", adminID)

            MSconnection.Open()
            Dim labelfullname As String = MScommand.ExecuteScalar().ToString()
            MSconnection.Close()
            lblFullname.Text = labelfullname
        ElseIf signin = "MYSQL" Then
            MYconnection = New MySqlConnection(MYconnectionString)
            Dim query As String = "SELECT CONCAT(firstname, ' ', middlename, ' ', lastname) AS labelfullname FROM tbl_admin WHERE admin_id = @ID;"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", adminID)

            MYconnection.Open()
            Dim labelfullname As String = MYcommand.ExecuteScalar().ToString()
            MYconnection.Close()
            lblFullname.Text = labelfullname
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYloadData()
        MSloadData()
        adminFullname()

        'Dim result As MsgBoxResult = msgbox_insert.Show()

        'If result = MsgBoxResult.Cancel Then
        '    msgbox_update.Show()
        'End If
        Dim currentDateTime As DateTime = DateTime.Now
        lblNowDate.Text = currentDateTime.ToString("MMMM dd yyyy hh:mm tt")

        If signin = "MSSQL" Then
            MSconnection = New SqlConnection(MSconnectionString)

            lblUser.Text = Username
            lblUser_side_drawer.Text = Username
            Try
                MSconnection.Open()

                Dim query As String = "SELECT CONVERT(NVARCHAR(50), date_time, 107) + ' ' + RIGHT(CONVERT(NVARCHAR(50), date_time, 0), 7) AS formatted_datetime FROM [GROUP4_DB].[dbo].[tbl_admin] WHERE [admin_id] = @ADMIN_ID"
                Dim MScommand As New SqlCommand(query, MSconnection)
                MScommand.Parameters.AddWithValue("@ADMIN_ID", adminID)

                Dim MSreader As SqlDataReader = MScommand.ExecuteReader()

                If MSreader.Read() Then
                    lblCreateAcc.Text = MSreader("formatted_datetime").ToString()
                    lblCreateAcc_side_drawer.Text = MSreader("formatted_datetime").ToString()
                End If
                MessageBox.Show(MSreader("formatted_datetime").ToString())
                MSconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MSconnection.Dispose()
            End Try

        ElseIf signin = "MYSQL" Then
            MYconnection = New MySqlConnection(MYconnectionString)

            lblUser_side_drawer.Text = Username
            lblUser.Text = Username
            Try
                MYconnection.Open()

                Dim query As String = "SELECT CONCAT(DATE_FORMAT(date_time, '%M %d, %Y'),' ',TIME_FORMAT(date_time, '%h:%i %p')) AS formatted_datetime FROM tbl_admin WHERE admin_id = @ADMIN_ID;"
                Dim MYcommand As New MySqlCommand(query, MYconnection)
                MYcommand.Parameters.AddWithValue("@ADMIN_ID", adminID)

                Dim MYreader As MySqlDataReader = MYcommand.ExecuteReader()

                If MYreader.Read() Then
                    lblCreateAcc.Text = MYreader("formatted_datetime").ToString()
                    lblCreateAcc_side_drawer.Text = MYreader("formatted_datetime").ToString()
                End If
                MYconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MYconnection.Dispose()
            End Try
        End If



    End Sub

    Public Sub MSloadData()
        MSconnection = New SqlConnection(MSconnectionString)

        Dim MScommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info;", MSconnection)

        Dim da As New SqlDataAdapter(MScommand)
        Dim dt As New DataTable

        da.Fill(dt)
        GunaDataGridView1.DataSource = dt
    End Sub

    Public Sub MYloadData()
        MYconnection = New MySqlConnection(MYconnectionString)

        Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info;", MYconnection)

        Dim da As New MySqlDataAdapter(MYcommand)
        Dim dt As New DataTable

        da.Fill(dt)
        GunaDataGridView2.DataSource = dt


    End Sub

    Private Sub btnMS_Register_Click(sender As Object, e As EventArgs) Handles btnMS_Register.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim selectedCourse As String = course.SelectedItem.ToString()

            Dim query As String = "INSERT INTO tbl_info (firstname, middlename, lastname, course) VALUES (@Fname, @Mname, @Lname, @Course)"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MScommand.Parameters.AddWithValue("@Course", selectedCourse)

            MScommand.ExecuteNonQuery()
            msgbox_insert.Show()
            MYloadData()
            MSloadData()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            MSconnection.Dispose()
        End Try
    End Sub

    Private Sub btnMY_Register_Click(sender As Object, e As EventArgs) Handles btnMY_Register.Click
        MYconnection = New MySqlConnection(MYconnectionString)

        Try
            MYconnection.Open()
            Dim selectedCourse As String = course.SelectedItem.ToString()

            Dim query As String = "INSERT INTO tbl_info (firstname, middlename, lastname, course) VALUES (@Fname, @Mname, @Lname, @Course)"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", selectedCourse)

            MYcommand.ExecuteNonQuery()
            msgbox_insert.Show()
            MYloadData()
            MSloadData()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            MYconnection.Dispose()
        End Try
    End Sub



    Private Sub btnMS_Update_Click(sender As Object, e As EventArgs) Handles btnMS_Update.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim query As String = "UPDATE tbl_info SET firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@ID", ID)
            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MScommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())


            MScommand.ExecuteNonQuery()

            msgbox_update.Show()

            MYloadData()
            MSloadData()

        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btnMY_Update_Click(sender As Object, e As EventArgs) Handles btnMY_Update.Click
        MYconnection = New MySqlConnection(MYconnectionString)


        Try
            MYconnection.Open()
            Dim query As String = "UPDATE tbl_info SET firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@ID", ID)
            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())

            MYcommand.ExecuteNonQuery()
            msgbox_update.Show()
            MYloadData()
            MSloadData()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try

    End Sub

    Private Sub Guna2DataGridView1(sender As Object, e As MouseEventArgs) Handles GunaDataGridView1.MouseClick
        MSconnection = New SqlConnection(MSconnectionString)

        Try

            MSconnection.Open()

            Dim dr As DataGridViewRow = GunaDataGridView1.SelectedRows(0)

            ID = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", ID)

            Dim Reader As SqlDataReader = MScommand.ExecuteReader()

            If Reader.Read() Then
                txtfname.Text = Reader("firstname").ToString()
                txtmname.Text = Reader("middlename").ToString()
                txtlname.Text = Reader("lastname").ToString()
            Else
                MessageBox.Show("Student not found.")
            End If
            Reader.Close()


        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub GunaDataGridView(sender As Object, e As MouseEventArgs) Handles GunaDataGridView2.MouseClick
        MYconnection = New MySqlConnection(MYconnectionString)

        Try

            MYconnection.Open()

            Dim dr As DataGridViewRow = GunaDataGridView2.SelectedRows(0)

            ID = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", ID)

            Dim Reader As MySqlDataReader = MYcommand.ExecuteReader()

            If Reader.Read() Then
                txtfname.Text = Reader("firstname").ToString()
                txtmname.Text = Reader("middlename").ToString()
                txtlname.Text = Reader("lastname").ToString()
            Else
                MessageBox.Show("Student not found.")
            End If
            Reader.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        MSconnection = New SqlConnection(MSconnectionString)
        MYconnection = New MySqlConnection(MYconnectionString)

        Try
            MSconnection.Open()

            Dim MScommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", MSconnection)
            MScommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim da As New SqlDataAdapter(MScommand)
            Dim dt As New DataTable

            da.Fill(dt)
            GunaDataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

        Try

            MYconnection.Open()

            Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", MYconnection)
            MYcommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim dta As New MySqlDataAdapter(MYcommand)
            Dim dtl As New DataTable

            dta.Fill(dtl)
            GunaDataGridView2.DataSource = dtl
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub btnMS_Delete_Click(sender As Object, e As EventArgs) Handles btnMS_Delete.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", ID)

            MScommand.ExecuteNonQuery()
            Dim result As MsgBoxResult = msgbox_delete_complete.Show()
            If result = MsgBoxResult.Yes Then
                msgbox_delete_complete.Show()
                msgbox_delete.Show()
            End If

            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            course.SelectedItem = Nothing

            MYloadData()
            MSloadData()
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btnMY_Delete_Click(sender As Object, e As EventArgs) Handles btnMY_Delete.Click
        MYconnection = New MySqlConnection(MYconnectionString)

        Try
            MYconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", ID)

            MYcommand.ExecuteNonQuery()
            Dim result As MsgBoxResult = msgbox_delete_complete.Show()
            If result = MsgBoxResult.Yes Then
                msgbox_delete_complete.Show()
                msgbox_delete.Show()
            End If

            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            course.SelectedItem = Nothing

            MSloadData()
            MYloadData()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        course.SelectedItem = Nothing
        txtSearch.Clear()
    End Sub

    Private Sub btn_more_details_Click(sender As Object, e As EventArgs) Handles btn_more_details.Click
        Panel_side_drawer.Location = New Point(1006, 0)
    End Sub

    Private Sub btn_side_drawer_return_Click(sender As Object, e As EventArgs) Handles btn_side_drawer_return.Click
        Panel_side_drawer.Location = New Point(-1006, 0)
    End Sub

    Private Sub btn_MS_truncate_Click(sender As Object, e As EventArgs) Handles btn_MS_truncate.Click
        Dim result As MsgBoxResult = msgbox_truncate.Show()

        MSconnection = New SqlConnection(MSconnectionString)

        If result = MsgBoxResult.Yes Then
            Try
                MSconnection.Open()
                Dim query As String = "TRUNCATE TABLE tbl_info"
                Dim MScommand As New SqlCommand(query, MSconnection)
                MScommand.ExecuteNonQuery()
                msgbox_truncate_complete.Show()
                MSloadData()
                MYloadData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                MSconnection.Close()
            End Try

        ElseIf result = MsgBoxResult.No Then

        End If
    End Sub

    Private Sub btn_MY_truncate_Click(sender As Object, e As EventArgs) Handles btn_MY_truncate.Click
        Dim result As MsgBoxResult = msgbox_truncate.Show()

        MYconnection = New MySqlConnection(MYconnectionString)

        If result = MsgBoxResult.Yes Then
            Try
                MYconnection.Open()
                Dim query As String = "TRUNCATE TABLE tbl_info"
                Dim MYcommand As New MySqlCommand(query, MYconnection)
                MYcommand.ExecuteNonQuery()
                msgbox_truncate_complete.Show()
                MSloadData()
                MYloadData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                MYconnection.Close()
            End Try

        ElseIf result = MsgBoxResult.No Then

        End If
    End Sub


End Class