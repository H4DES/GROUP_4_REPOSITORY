<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Signup = New Guna.UI2.WinForms.Guna2Panel()
        Me.rdo_MY_signup = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdo_MS_signup = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtCreateLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCreateMname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCreateFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCreatePass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnToSignin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignup = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCreateUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_login = New Guna.UI2.WinForms.Guna2Panel()
        Me.rdo_MY_login = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdo_MS_login = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnToCreateAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msgbox_signup = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.msgbox_signin = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel_Signup.SuspendLayout()
        Me.Panel_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Panel_Signup)
        Me.Guna2Panel1.Controls.Add(Me.Panel_login)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(587, 646)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Panel_Signup
        '
        Me.Panel_Signup.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Signup.BorderRadius = 40
        Me.Panel_Signup.Controls.Add(Me.rdo_MY_signup)
        Me.Panel_Signup.Controls.Add(Me.rdo_MS_signup)
        Me.Panel_Signup.Controls.Add(Me.txtCreateLname)
        Me.Panel_Signup.Controls.Add(Me.txtCreateMname)
        Me.Panel_Signup.Controls.Add(Me.txtCreateFname)
        Me.Panel_Signup.Controls.Add(Me.txtCreatePass)
        Me.Panel_Signup.Controls.Add(Me.btnToSignin)
        Me.Panel_Signup.Controls.Add(Me.btnSignup)
        Me.Panel_Signup.Controls.Add(Me.txtCreateUser)
        Me.Panel_Signup.Controls.Add(Me.Label2)
        Me.Panel_Signup.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Signup.Location = New System.Drawing.Point(87, 27)
        Me.Panel_Signup.Name = "Panel_Signup"
        Me.Panel_Signup.Size = New System.Drawing.Size(405, 555)
        Me.Panel_Signup.TabIndex = 5
        '
        'rdo_MY_signup
        '
        Me.rdo_MY_signup.AutoSize = True
        Me.rdo_MY_signup.CheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MY_signup.CheckedState.BorderThickness = 0
        Me.rdo_MY_signup.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rdo_MY_signup.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdo_MY_signup.CheckedState.InnerOffset = -4
        Me.rdo_MY_signup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_MY_signup.ForeColor = System.Drawing.Color.White
        Me.rdo_MY_signup.Location = New System.Drawing.Point(240, 403)
        Me.rdo_MY_signup.Name = "rdo_MY_signup"
        Me.rdo_MY_signup.Size = New System.Drawing.Size(65, 19)
        Me.rdo_MY_signup.TabIndex = 10
        Me.rdo_MY_signup.Text = "MYSQL"
        Me.rdo_MY_signup.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MY_signup.UncheckedState.BorderThickness = 0
        Me.rdo_MY_signup.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdo_MY_signup.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdo_MS_signup
        '
        Me.rdo_MS_signup.AutoSize = True
        Me.rdo_MS_signup.Checked = True
        Me.rdo_MS_signup.CheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MS_signup.CheckedState.BorderThickness = 0
        Me.rdo_MS_signup.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rdo_MS_signup.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdo_MS_signup.CheckedState.InnerOffset = -4
        Me.rdo_MS_signup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_MS_signup.ForeColor = System.Drawing.Color.White
        Me.rdo_MS_signup.Location = New System.Drawing.Point(104, 403)
        Me.rdo_MS_signup.Name = "rdo_MS_signup"
        Me.rdo_MS_signup.Size = New System.Drawing.Size(65, 19)
        Me.rdo_MS_signup.TabIndex = 9
        Me.rdo_MS_signup.TabStop = True
        Me.rdo_MS_signup.Text = "MSSQL"
        Me.rdo_MS_signup.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MS_signup.UncheckedState.BorderThickness = 0
        Me.rdo_MS_signup.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdo_MS_signup.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtCreateLname
        '
        Me.txtCreateLname.Animated = True
        Me.txtCreateLname.AutoRoundedCorners = True
        Me.txtCreateLname.BorderColor = System.Drawing.Color.Gray
        Me.txtCreateLname.BorderRadius = 20
        Me.txtCreateLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreateLname.DefaultText = ""
        Me.txtCreateLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreateLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreateLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateLname.FillColor = System.Drawing.Color.DimGray
        Me.txtCreateLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateLname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreateLname.ForeColor = System.Drawing.Color.Black
        Me.txtCreateLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateLname.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.user_plus_regular_24
        Me.txtCreateLname.Location = New System.Drawing.Point(34, 342)
        Me.txtCreateLname.Name = "txtCreateLname"
        Me.txtCreateLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreateLname.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCreateLname.PlaceholderText = "Lastname"
        Me.txtCreateLname.SelectedText = ""
        Me.txtCreateLname.Size = New System.Drawing.Size(338, 42)
        Me.txtCreateLname.TabIndex = 8
        '
        'txtCreateMname
        '
        Me.txtCreateMname.Animated = True
        Me.txtCreateMname.AutoRoundedCorners = True
        Me.txtCreateMname.BorderColor = System.Drawing.Color.Gray
        Me.txtCreateMname.BorderRadius = 20
        Me.txtCreateMname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreateMname.DefaultText = ""
        Me.txtCreateMname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreateMname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreateMname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateMname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateMname.FillColor = System.Drawing.Color.DimGray
        Me.txtCreateMname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateMname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreateMname.ForeColor = System.Drawing.Color.Black
        Me.txtCreateMname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateMname.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.user_plus_regular_24
        Me.txtCreateMname.Location = New System.Drawing.Point(33, 281)
        Me.txtCreateMname.Name = "txtCreateMname"
        Me.txtCreateMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreateMname.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCreateMname.PlaceholderText = "Middlename"
        Me.txtCreateMname.SelectedText = ""
        Me.txtCreateMname.Size = New System.Drawing.Size(338, 42)
        Me.txtCreateMname.TabIndex = 7
        '
        'txtCreateFname
        '
        Me.txtCreateFname.Animated = True
        Me.txtCreateFname.AutoRoundedCorners = True
        Me.txtCreateFname.BorderColor = System.Drawing.Color.Gray
        Me.txtCreateFname.BorderRadius = 20
        Me.txtCreateFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreateFname.DefaultText = ""
        Me.txtCreateFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreateFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreateFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateFname.FillColor = System.Drawing.Color.DimGray
        Me.txtCreateFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateFname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreateFname.ForeColor = System.Drawing.Color.Black
        Me.txtCreateFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateFname.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.user_plus_regular_24
        Me.txtCreateFname.Location = New System.Drawing.Point(33, 218)
        Me.txtCreateFname.Name = "txtCreateFname"
        Me.txtCreateFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreateFname.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCreateFname.PlaceholderText = "Firstname"
        Me.txtCreateFname.SelectedText = ""
        Me.txtCreateFname.Size = New System.Drawing.Size(338, 42)
        Me.txtCreateFname.TabIndex = 6
        '
        'txtCreatePass
        '
        Me.txtCreatePass.Animated = True
        Me.txtCreatePass.AutoRoundedCorners = True
        Me.txtCreatePass.BorderColor = System.Drawing.Color.Gray
        Me.txtCreatePass.BorderRadius = 20
        Me.txtCreatePass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreatePass.DefaultText = ""
        Me.txtCreatePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreatePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreatePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreatePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreatePass.FillColor = System.Drawing.Color.DimGray
        Me.txtCreatePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreatePass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreatePass.ForeColor = System.Drawing.Color.Black
        Me.txtCreatePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreatePass.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.lock_alt_regular_24
        Me.txtCreatePass.Location = New System.Drawing.Point(34, 158)
        Me.txtCreatePass.Name = "txtCreatePass"
        Me.txtCreatePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCreatePass.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCreatePass.PlaceholderText = "Password"
        Me.txtCreatePass.SelectedText = ""
        Me.txtCreatePass.Size = New System.Drawing.Size(338, 42)
        Me.txtCreatePass.TabIndex = 5
        '
        'btnToSignin
        '
        Me.btnToSignin.AutoRoundedCorners = True
        Me.btnToSignin.BorderRadius = 21
        Me.btnToSignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToSignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToSignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToSignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToSignin.FillColor = System.Drawing.Color.Transparent
        Me.btnToSignin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSignin.ForeColor = System.Drawing.Color.White
        Me.btnToSignin.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnToSignin.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnToSignin.Image = Global.GROUP4_SYSTEM.My.Resources.Resources.arrow_back_regular_24
        Me.btnToSignin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnToSignin.Location = New System.Drawing.Point(117, 496)
        Me.btnToSignin.Name = "btnToSignin"
        Me.btnToSignin.PressedColor = System.Drawing.Color.Transparent
        Me.btnToSignin.Size = New System.Drawing.Size(163, 45)
        Me.btnToSignin.TabIndex = 4
        Me.btnToSignin.Text = "Sign in"
        '
        'btnSignup
        '
        Me.btnSignup.Animated = True
        Me.btnSignup.AutoRoundedCorners = True
        Me.btnSignup.BorderColor = System.Drawing.Color.Transparent
        Me.btnSignup.BorderRadius = 25
        Me.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignup.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignup.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!)
        Me.btnSignup.ForeColor = System.Drawing.Color.Black
        Me.btnSignup.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignup.Location = New System.Drawing.Point(34, 441)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(338, 53)
        Me.btnSignup.TabIndex = 3
        Me.btnSignup.Text = "Sign up"
        '
        'txtCreateUser
        '
        Me.txtCreateUser.Animated = True
        Me.txtCreateUser.AutoRoundedCorners = True
        Me.txtCreateUser.BorderColor = System.Drawing.Color.Gray
        Me.txtCreateUser.BorderRadius = 20
        Me.txtCreateUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreateUser.DefaultText = ""
        Me.txtCreateUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreateUser.FillColor = System.Drawing.Color.DimGray
        Me.txtCreateUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreateUser.ForeColor = System.Drawing.Color.Black
        Me.txtCreateUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreateUser.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.user_check_solid_24
        Me.txtCreateUser.Location = New System.Drawing.Point(34, 101)
        Me.txtCreateUser.Name = "txtCreateUser"
        Me.txtCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreateUser.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCreateUser.PlaceholderText = "Username"
        Me.txtCreateUser.SelectedText = ""
        Me.txtCreateUser.Size = New System.Drawing.Size(338, 42)
        Me.txtCreateUser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(73, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 59)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Sign up"
        '
        'Panel_login
        '
        Me.Panel_login.BackColor = System.Drawing.Color.Transparent
        Me.Panel_login.BorderRadius = 40
        Me.Panel_login.Controls.Add(Me.rdo_MY_login)
        Me.Panel_login.Controls.Add(Me.rdo_MS_login)
        Me.Panel_login.Controls.Add(Me.btnToCreateAcc)
        Me.Panel_login.Controls.Add(Me.btnSignin)
        Me.Panel_login.Controls.Add(Me.txtPassword)
        Me.Panel_login.Controls.Add(Me.txtUsername)
        Me.Panel_login.Controls.Add(Me.Label1)
        Me.Panel_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_login.Location = New System.Drawing.Point(87, 59)
        Me.Panel_login.Name = "Panel_login"
        Me.Panel_login.Size = New System.Drawing.Size(405, 467)
        Me.Panel_login.TabIndex = 0
        '
        'rdo_MY_login
        '
        Me.rdo_MY_login.AutoSize = True
        Me.rdo_MY_login.CheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MY_login.CheckedState.BorderThickness = 0
        Me.rdo_MY_login.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rdo_MY_login.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdo_MY_login.CheckedState.InnerOffset = -4
        Me.rdo_MY_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_MY_login.ForeColor = System.Drawing.Color.White
        Me.rdo_MY_login.Location = New System.Drawing.Point(241, 257)
        Me.rdo_MY_login.Name = "rdo_MY_login"
        Me.rdo_MY_login.Size = New System.Drawing.Size(65, 19)
        Me.rdo_MY_login.TabIndex = 12
        Me.rdo_MY_login.Text = "MYSQL"
        Me.rdo_MY_login.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MY_login.UncheckedState.BorderThickness = 0
        Me.rdo_MY_login.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdo_MY_login.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdo_MS_login
        '
        Me.rdo_MS_login.AutoSize = True
        Me.rdo_MS_login.Checked = True
        Me.rdo_MS_login.CheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MS_login.CheckedState.BorderThickness = 0
        Me.rdo_MS_login.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rdo_MS_login.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdo_MS_login.CheckedState.InnerOffset = -4
        Me.rdo_MS_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdo_MS_login.ForeColor = System.Drawing.Color.White
        Me.rdo_MS_login.Location = New System.Drawing.Point(105, 257)
        Me.rdo_MS_login.Name = "rdo_MS_login"
        Me.rdo_MS_login.Size = New System.Drawing.Size(65, 19)
        Me.rdo_MS_login.TabIndex = 11
        Me.rdo_MS_login.TabStop = True
        Me.rdo_MS_login.Text = "MSSQL"
        Me.rdo_MS_login.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.rdo_MS_login.UncheckedState.BorderThickness = 0
        Me.rdo_MS_login.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdo_MS_login.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btnToCreateAcc
        '
        Me.btnToCreateAcc.AutoRoundedCorners = True
        Me.btnToCreateAcc.BorderRadius = 21
        Me.btnToCreateAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToCreateAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToCreateAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToCreateAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToCreateAcc.FillColor = System.Drawing.Color.Transparent
        Me.btnToCreateAcc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToCreateAcc.ForeColor = System.Drawing.Color.White
        Me.btnToCreateAcc.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnToCreateAcc.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnToCreateAcc.Image = Global.GROUP4_SYSTEM.My.Resources.Resources.arrow_back_regular_24
        Me.btnToCreateAcc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnToCreateAcc.Location = New System.Drawing.Point(117, 387)
        Me.btnToCreateAcc.Name = "btnToCreateAcc"
        Me.btnToCreateAcc.PressedColor = System.Drawing.Color.Transparent
        Me.btnToCreateAcc.Size = New System.Drawing.Size(163, 45)
        Me.btnToCreateAcc.TabIndex = 4
        Me.btnToCreateAcc.Text = "Create Account"
        '
        'btnSignin
        '
        Me.btnSignin.Animated = True
        Me.btnSignin.AutoRoundedCorners = True
        Me.btnSignin.BorderColor = System.Drawing.Color.Transparent
        Me.btnSignin.BorderRadius = 30
        Me.btnSignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignin.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignin.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.Color.Black
        Me.btnSignin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignin.Location = New System.Drawing.Point(34, 298)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(338, 62)
        Me.btnSignin.TabIndex = 3
        Me.btnSignin.Text = "Sign in"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.AutoRoundedCorners = True
        Me.txtPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword.BorderRadius = 24
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.DimGray
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.lock_alt_regular_24
        Me.txtPassword.Location = New System.Drawing.Point(34, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(338, 51)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.AutoRoundedCorners = True
        Me.txtUsername.BorderColor = System.Drawing.Color.Gray
        Me.txtUsername.BorderRadius = 24
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.DimGray
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconLeft = Global.GROUP4_SYSTEM.My.Resources.Resources.user_regular_24
        Me.txtUsername.Location = New System.Drawing.Point(34, 115)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(338, 51)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login"
        '
        'msgbox_signup
        '
        Me.msgbox_signup.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msgbox_signup.Caption = "Account Created!"
        Me.msgbox_signup.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.msgbox_signup.Parent = Me
        Me.msgbox_signup.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        Me.msgbox_signup.Text = "User admin account created successfully!"
        '
        'msgbox_signin
        '
        Me.msgbox_signin.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msgbox_signin.Caption = "Login Success!"
        Me.msgbox_signin.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.msgbox_signin.Parent = Me
        Me.msgbox_signin.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        Me.msgbox_signin.Text = "Account Login Successfull!"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 646)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel_Signup.ResumeLayout(False)
        Me.Panel_Signup.PerformLayout()
        Me.Panel_login.ResumeLayout(False)
        Me.Panel_login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_login As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSignin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnToCreateAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Signup As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtCreateLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCreateFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCreatePass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnToSignin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCreateUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCreateMname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rdo_MS_signup As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdo_MY_signup As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdo_MY_login As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdo_MS_login As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents msgbox_signup As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents msgbox_signin As Guna.UI2.WinForms.Guna2MessageDialog
End Class
