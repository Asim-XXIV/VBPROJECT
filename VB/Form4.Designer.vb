<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnSubmit = New Button()
        txtLastName = New TextBox()
        txtUserName = New TextBox()
        TextBox5 = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(385, 45)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "First name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(385, 74)
        txtFirstName.Margin = New Padding(4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "Enter your first name"
        txtFirstName.Size = New Size(232, 31)
        txtFirstName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(385, 109)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 2
        Label2.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(385, 173)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 3
        Label3.Text = "User Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(385, 237)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 25)
        Label4.TabIndex = 4
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(385, 310)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 5
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(385, 374)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 25)
        Label6.TabIndex = 6
        Label6.Text = "Confirm password"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(859, 500)
        btnSubmit.Margin = New Padding(4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(128, 49)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(385, 138)
        txtLastName.Margin = New Padding(4)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Enter your last name"
        txtLastName.Size = New Size(232, 31)
        txtLastName.TabIndex = 10
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(385, 202)
        txtUserName.Margin = New Padding(4)
        txtUserName.Name = "txtUserName"
        txtUserName.PlaceholderText = "Enter your user name"
        txtUserName.Size = New Size(232, 31)
        txtUserName.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(385, 339)
        TextBox5.Margin = New Padding(4)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Enter your password"
        TextBox5.Size = New Size(232, 31)
        TextBox5.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(385, 275)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter your email"
        txtEmail.Size = New Size(232, 31)
        txtEmail.TabIndex = 13
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(385, 403)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Re-enter your password"
        txtPassword.Size = New Size(232, 31)
        txtPassword.TabIndex = 14
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(993, 560)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(TextBox5)
        Controls.Add(txtUserName)
        Controls.Add(txtLastName)
        Controls.Add(btnSubmit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtFirstName)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "Form4"
        Text = "form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
