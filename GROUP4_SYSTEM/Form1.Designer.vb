<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCheckMSSQL = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckMYSQL = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnCheckMSSQL
        '
        Me.btnCheckMSSQL.Animated = True
        Me.btnCheckMSSQL.BorderRadius = 15
        Me.btnCheckMSSQL.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckMSSQL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckMSSQL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheckMSSQL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheckMSSQL.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckMSSQL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMSSQL.ForeColor = System.Drawing.Color.White
        Me.btnCheckMSSQL.HoverState.FillColor = System.Drawing.Color.Black
        Me.btnCheckMSSQL.Location = New System.Drawing.Point(31, 74)
        Me.btnCheckMSSQL.Name = "btnCheckMSSQL"
        Me.btnCheckMSSQL.PressedColor = System.Drawing.Color.DimGray
        Me.btnCheckMSSQL.Size = New System.Drawing.Size(304, 95)
        Me.btnCheckMSSQL.TabIndex = 0
        Me.btnCheckMSSQL.Text = "CHECK CONNECTION (MSSQL)"
        '
        'btnCheckMYSQL
        '
        Me.btnCheckMYSQL.Animated = True
        Me.btnCheckMYSQL.BorderRadius = 15
        Me.btnCheckMYSQL.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckMYSQL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckMYSQL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheckMYSQL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheckMYSQL.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheckMYSQL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMYSQL.ForeColor = System.Drawing.Color.White
        Me.btnCheckMYSQL.HoverState.FillColor = System.Drawing.Color.Black
        Me.btnCheckMYSQL.Location = New System.Drawing.Point(359, 74)
        Me.btnCheckMYSQL.Name = "btnCheckMYSQL"
        Me.btnCheckMYSQL.PressedColor = System.Drawing.Color.DimGray
        Me.btnCheckMYSQL.Size = New System.Drawing.Size(304, 95)
        Me.btnCheckMYSQL.TabIndex = 1
        Me.btnCheckMYSQL.Text = "CHECK CONNECTION (MYSQL)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 253)
        Me.Controls.Add(Me.btnCheckMYSQL)
        Me.Controls.Add(Me.btnCheckMSSQL)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheckMSSQL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckMYSQL As Guna.UI2.WinForms.Guna2Button
End Class
