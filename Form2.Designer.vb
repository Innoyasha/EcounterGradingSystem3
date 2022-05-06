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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnClr1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLog1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TextPass1 = New System.Windows.Forms.TextBox()
        Me.TextUser1 = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(138, 17)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(194, 34)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Tacher's LogIn"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnClr1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnLog1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextPass1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextUser1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.RosyBrown
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(53, 64)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(497, 309)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'btnClr1
        '
        Me.btnClr1.BorderRadius = 6
        Me.btnClr1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClr1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClr1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClr1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClr1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClr1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClr1.FillColor2 = System.Drawing.Color.Silver
        Me.btnClr1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnClr1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClr1.Location = New System.Drawing.Point(286, 219)
        Me.btnClr1.Name = "btnClr1"
        Me.btnClr1.Size = New System.Drawing.Size(77, 23)
        Me.btnClr1.TabIndex = 6
        Me.btnClr1.Text = "Clear"
        '
        'btnLog1
        '
        Me.btnLog1.BorderRadius = 6
        Me.btnLog1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLog1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLog1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLog1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLog1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLog1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLog1.FillColor2 = System.Drawing.Color.Silver
        Me.btnLog1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnLog1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLog1.Location = New System.Drawing.Point(127, 219)
        Me.btnLog1.Name = "btnLog1"
        Me.btnLog1.Size = New System.Drawing.Size(77, 23)
        Me.btnLog1.TabIndex = 5
        Me.btnLog1.Text = "Log In"
        '
        'TextPass1
        '
        Me.TextPass1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextPass1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextPass1.Location = New System.Drawing.Point(127, 171)
        Me.TextPass1.Multiline = True
        Me.TextPass1.Name = "TextPass1"
        Me.TextPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPass1.Size = New System.Drawing.Size(236, 29)
        Me.TextPass1.TabIndex = 4
        '
        'TextUser1
        '
        Me.TextUser1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextUser1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextUser1.Location = New System.Drawing.Point(127, 108)
        Me.TextUser1.Multiline = True
        Me.TextUser1.Name = "TextUser1"
        Me.TextUser1.Size = New System.Drawing.Size(236, 29)
        Me.TextUser1.TabIndex = 3
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(97, 143)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(80, 22)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Paassword:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(100, 80)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(77, 22)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Username:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(609, 437)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Name = "Form2"
        Me.Text = "Teachers-LogIn"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnClr1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLog1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TextPass1 As TextBox
    Friend WithEvents TextUser1 As TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
