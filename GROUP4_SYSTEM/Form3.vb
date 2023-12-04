Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim dr As MySqlDataAdapter
    Dim a As OpenFileDialog = New OpenFileDialog
    Dim ID As String = ""

    Public Sub showImage()

        If signin = "MSSQL" Then
            MSconnection = New SqlConnection(MSconnectionString)

            Try
                MSconnection.Open()

                Dim MScommand As New SqlCommand("SELECT profile_image FROM tbl_admin WHERE admin_id = @ID", MSconnection)
                MScommand.Parameters.AddWithValue("@ID", adminID)
                Dim imageData As Byte() = DirectCast(MScommand.ExecuteScalar(), Byte())

                If imageData IsNot Nothing Then
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    MsgBox("Not Found!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MSconnection.Close()
            End Try
        ElseIf signin = "MYSQL" Then
            MYconnection = New MySqlConnection(MYconnectionString)

            Try
                MYconnection.Open()

                Dim MYcommand As New MySqlCommand("SELECT profile_image FROM tbl_admin WHERE admin_id = @ID", MYconnection)
                MYcommand.Parameters.AddWithValue("@ID", adminID)
                Dim imageData As Byte() = DirectCast(MYcommand.ExecuteScalar(), Byte())

                If imageData IsNot Nothing Then
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    MsgBox("Not Found!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MYconnection.Close()
            End Try
        End If

    End Sub

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

    Public Sub MYcheckImage()
        MYconnection = New MySqlConnection(MYconnectionString)
        Try
            MYconnection.Open()

            Dim MYcommand As New MySqlCommand("SELECT COUNT(*) FROM tbl_admin WHERE admin_id = @ID AND profile_image IS NOT NULL", MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", adminID)
            Dim count As Integer = Convert.ToInt32(MYcommand.ExecuteScalar())

            If count > 0 Then
                showImage()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYloadData()
        MSloadData()
        adminFullname()
        MYcheckImage()
        btn_save_photo.Enabled = False
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

        If txtfname.Text = Nothing Or txtlname.Text = Nothing Or course.SelectedItem = Nothing Then
            MessageBox.Show("Empty value in textboxes!")
        Else
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
        End If
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

            Dim result As MsgBoxResult = msgbox_delete.Show()
            If result = MsgBoxResult.Yes Then
                msgbox_delete_complete.Show()
                MScommand.ExecuteNonQuery()
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



            Dim result As MsgBoxResult = msgbox_delete.Show()
            If result = MsgBoxResult.Yes Then
                msgbox_delete_complete.Show()
                MYcommand.ExecuteNonQuery()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As MsgBoxResult = msgbox_logout_popup1.Show()
        If result = MsgBoxResult.Yes Then
            Me.Hide()
            Form2.Show()
            open = False
            Me.Close()
        End If

    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim result As MsgBoxResult = msgbox_logout_popup1.Show()
        If result = MsgBoxResult.Yes Then
            Me.Hide()
            Form2.Show()
            open = False
            Me.Close()
        End If
    End Sub

    Private Sub btn_change_photo_Click(sender As Object, e As EventArgs) Handles btn_change_photo.Click
        Try
            a.Filter = "JPEG(*.jpg;*.jpeg|*.jpg|PNG(*.png)|*.png)"
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(a.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btn_save_photo.Enabled = True

    End Sub

    Private Sub btn_save_photo_Click(sender As Object, e As EventArgs) Handles btn_save_photo.Click
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim Image() As Byte = mstream.GetBuffer
        mstream.Close()

        If signin = "MSSQL" Then
            MSconnection = New SqlConnection(MSconnectionString)
            Try
                MSconnection.Open()

                Dim MScommand As New SqlCommand("SELECT COUNT(*) FROM tbl_admin WHERE admin_id = @ID AND profile_image IS NOT NULL", MSconnection)
                MScommand.Parameters.AddWithValue("@ID", adminID)
                Dim count As Integer = Convert.ToInt32(MScommand.ExecuteScalar())

                If count > 0 Then
                    MScommand = New SqlCommand("UPDATE tbl_admin SET profile_image = @ImageData WHERE admin_id = @ID", MSconnection)
                    MScommand.Parameters.AddWithValue("@ID", adminID)
                Else
                    MScommand = New SqlCommand("UPDATE tbl_admin SET profile_image = @ImageData WHERE admin_id = @ID", MSconnection)
                    MScommand.Parameters.AddWithValue("@ID", adminID)
                End If

                MScommand.Parameters.AddWithValue("@ImageData", Image)

                MScommand.ExecuteNonQuery()
                MsgBox("Success", MsgBoxStyle.Information, "Success!")
                showImage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MSconnection.Close()
            End Try
            btn_save_photo.Enabled = False

        ElseIf signin = "MYSQL" Then
            MYconnection = New MySqlConnection(MYconnectionString)
            Try
                MYconnection.Open()

                Dim MYcommand As New MySqlCommand("SELECT COUNT(*) FROM tbl_admin WHERE admin_id = @ID AND profile_image IS NOT NULL", MYconnection)
                MYcommand.Parameters.AddWithValue("@ID", adminID)
                Dim count As Integer = Convert.ToInt32(MYcommand.ExecuteScalar())

                If count > 0 Then
                    MYcommand = New MySqlCommand("UPDATE tbl_admin SET profile_image = @ImageData WHERE admin_id = @ID", MYconnection)
                    MYcommand.Parameters.AddWithValue("@ID", adminID)
                Else
                    MYcommand = New MySqlCommand("UPDATE tbl_admin SET profile_image = @ImageData WHERE admin_id = @ID", MYconnection)
                    MYcommand.Parameters.AddWithValue("@ID", adminID)
                End If

                MYcommand.Parameters.AddWithValue("@ImageData", Image)

                MYcommand.ExecuteNonQuery()
                MsgBox("Success", MsgBoxStyle.Information, "Success!")
                showImage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MYconnection.Close()
            End Try
            btn_save_photo.Enabled = False
        End If
    End Sub

    Private Sub btn_hover_profile1(sender As Object, e As EventArgs) Handles btn_hover_profile.CheckedChanged
        If btn_hover_profile.Checked Then
            Panel_change_photo.Location = New Point(41, 210)
        Else
            Panel_change_photo.Location = New Point(41, -210)
        End If
    End Sub
End Class