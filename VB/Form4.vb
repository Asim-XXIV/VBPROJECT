Imports System.Data.SqlClient

Public Class Form4
    Private connectionString As String = "Data Source=DESKTOP-G82B7UC\SQLEXPRESS;Initial Catalog=Userdetails;Integrated Security=True"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim userName As String = txtUserName.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        If InsertUserDetails(firstName, lastName, userName, email, password) Then
            MessageBox.Show("Submit successful!")
            ' Close Form4
            Me.Close()
            ' Show Form1 (Login form)
            Dim loginForm As New Form1()
            loginForm.Show()
        Else
            MessageBox.Show("Failed to submit user details.")
        End If
    End Sub

    Private Function InsertUserDetails(firstName As String, lastName As String, userName As String, email As String, password As String) As Boolean
        Dim query As String = "INSERT INTO Users (FirstName, LastName, UserName, Email, Password) VALUES (@FirstName, @LastName, @UserName, @Email, @Password)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@LastName", lastName)
                command.Parameters.AddWithValue("@UserName", userName)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
