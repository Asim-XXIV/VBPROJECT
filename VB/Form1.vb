Imports System.Data.SqlClient

Public Class Form1
    ' Connection string for your database
    Private connectionString As String = "Data Source=DESKTOP-G82B7UC\SQLEXPRESS;Initial Catalog=Userdetails;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Validate the login credentials against the database
        If ValidateLogin(username, password) Then
            ' If the login is successful, show Form2
            Dim form2 As New form2()
            form2.Show()
            Me.Hide() ' Optionally hide or close Form1
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim isValidLogin As Boolean = False

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim count As Integer = Convert.ToInt32(result)
                        isValidLogin = (count > 0)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while validating login credentials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return isValidLogin
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Show the signup form (Form4)
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide() ' Optionally hide or close Form1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set focus to another control to prevent textbox focus
        Button1.Select()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
