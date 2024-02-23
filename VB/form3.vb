Imports System.Data.SqlClient

Public Class form3
    Private connectionString As String = "Data Source=DESKTOP-G82B7UC\SQLEXPRESS;Initial Catalog=Userdetails;Integrated Security=True"

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve and display the highest invoice number
        Dim highestInvoiceNumber As Integer = GetHighestInvoiceNumber()
        txtHighestInvoiceNumber.Text = highestInvoiceNumber.ToString()

        Dim subtotalAmount As Decimal = form2.SubTotalAmount

        ' Set the value of the subtotal textbox
        TextBox1.Text = subtotalAmount.ToString()

        ' Retrieve and display data for the highest invoice number in the DataGridView
        If highestInvoiceNumber > 0 Then
            PopulateDataGridView(highestInvoiceNumber)
        End If
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged, txtService.TextChanged, txtDiscount.TextChanged
        ' Calculate total payable amount
        CalculateTotalPayable()
    End Sub

    Private Sub CalculateTotalPayable()
        Try
            ' Parse input values
            Dim subtotal As Decimal = Convert.ToDecimal(TextBox1.Text)
            Dim discount As Decimal = If(Decimal.TryParse(txtDiscount.Text, Nothing), Convert.ToDecimal(txtDiscount.Text), 0)
            Dim serviceCharge As Decimal = If(Decimal.TryParse(txtService.Text, Nothing), Convert.ToDecimal(txtService.Text), 0)
            Dim tax As Decimal = If(Decimal.TryParse(txtTax.Text, Nothing), Convert.ToDecimal(txtTax.Text), 0)

            ' Calculate total payable amount
            Dim totalPayable As Decimal = subtotal + serviceCharge + tax - discount

            ' Display total payable amount
            txtTotalPayable.Text = totalPayable.ToString()
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred while calculating the total payable amount: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetHighestInvoiceNumber() As Integer
        Dim highestInvoice As Integer = 0
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT MAX(InvoiceNo) FROM InvoiceDetails"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        highestInvoice = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the highest invoice number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return highestInvoice
    End Function

    Private Sub PopulateDataGridView(ByVal invoiceNumber As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Item, Quantity, Price, Amount FROM InvoiceDetails WHERE InvoiceNo = @InvoiceNo"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@InvoiceNo", invoiceNumber)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        dgvInvoiceDetails.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving invoice details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        ' Close the current instance of Form3
        Me.Close()
        ' Show the existing instance of Form2
        form2.Show()
        ' Clear the input parameters in Form2
        form2.ClearInputParameters()
    End Sub

    Private Sub dgvInvoiceDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceDetails.CellContentClick

    End Sub
End Class
