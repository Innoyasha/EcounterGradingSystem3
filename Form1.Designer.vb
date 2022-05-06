<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnFaculty = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnStudents = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnTeachers = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Guna2Panel1.Controls.Add(Me.btnFaculty)
        Me.Guna2Panel1.Controls.Add(Me.btnStudents)
        Me.Guna2Panel1.Controls.Add(Me.btnTeachers)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(24, 26)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(628, 395)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnFaculty
        '
        Me.btnFaculty.BorderRadius = 8
        Me.btnFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFaculty.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFaculty.FillColor2 = System.Drawing.Color.Silver
        Me.btnFaculty.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnFaculty.ForeColor = System.Drawing.Color.Black
        Me.btnFaculty.Location = New System.Drawing.Point(86, 287)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(464, 48)
        Me.btnFaculty.TabIndex = 3
        Me.btnFaculty.Text = "FACULTY"
        '
        'btnStudents
        '
        Me.btnStudents.BorderRadius = 8
        Me.btnStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudents.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudents.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudents.FillColor2 = System.Drawing.Color.Silver
        Me.btnStudents.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnStudents.ForeColor = System.Drawing.Color.Black
        Me.btnStudents.Location = New System.Drawing.Point(86, 219)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(464, 48)
        Me.btnStudents.TabIndex = 2
        Me.btnStudents.Text = "STUDENTS"
        '
        'btnTeachers
        '
        Me.btnTeachers.BorderRadius = 8
        Me.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeachers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTeachers.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTeachers.FillColor2 = System.Drawing.Color.Silver
        Me.btnTeachers.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnTeachers.ForeColor = System.Drawing.Color.Black
        Me.btnTeachers.Location = New System.Drawing.Point(86, 152)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(464, 48)
        Me.btnTeachers.TabIndex = 1
        Me.btnTeachers.Text = "TEACHERS"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Imprint MT Shadow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(17, 31)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(591, 59)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Encounter Grading System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(675, 450)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Form1"
        Me.Text = "Encounter_Dash"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnStudents As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnTeachers As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
