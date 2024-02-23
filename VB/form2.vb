Imports System.Data.SqlClient

Public Class Form2
    Public Shared SubTotalAmount As Decimal
    Private connectionString As String = "Data Source=DESKTOP-G82B7UC\SQLEXPRESS;Initial Catalog=Userdetails;Integrated Security=True"
    Dim invoiceCounter As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the highest invoice number from the database
        invoiceCounter = GetHighestInvoiceNumber() + 1
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

    Public Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if ComboBox, and TextBoxes have values
        If cmbItem.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtPrice.Text) Then
            ' Get the item, price, and quantity
            Dim item As String = cmbItem.SelectedItem.ToString()
            Dim price As Decimal
            Dim quantity As Integer

            ' Attempt to parse price and quantity, show error if input is invalid
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MessageBox.Show("Invalid price. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Calculate the amount
            Dim amount As Decimal = price * quantity

            ' Add the item, price, quantity, and amount to the DataGridView
            If dgvItems IsNot Nothing Then
                dgvItems.Rows.Add(item, price, quantity, amount)
            End If

            ' Update subtotal
            UpdateSubtotal()

            ' Clear the ComboBox and TextBoxes for next entry
            cmbItem.SelectedIndex = -1
            txtPrice.Clear()
            txtQuantity.Clear()
        Else
            MessageBox.Show("Please select an item, enter its price and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub UpdateSubtotal()
        ' Calculate subtotal by summing up the values in the "Amount" column
        Dim subtotal As Decimal = 0
        If dgvItems IsNot Nothing Then
            For Each row As DataGridViewRow In dgvItems.Rows
                If Not row.IsNewRow Then
                    subtotal += Convert.ToDecimal(row.Cells("Amount").Value)
                End If
            Next
        End If

        ' Display subtotal in the TextBox
        If txtSubTotal IsNot Nothing Then
            txtSubTotal.Text = subtotal.ToString()
        End If
    End Sub

    Public Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        ' Reset the invoice number counter and display it
        If txtInvoiceNo IsNot Nothing Then
            txtInvoiceNo.Text = invoiceCounter.ToString()
        End If

        ' Increment the invoice counter for the next invoice
        invoiceCounter += 1

        ' Store data in the database
        StoreDataInDatabase()

        ' Set the subtotal amount
        SubTotalAmount = Convert.ToDecimal(txtSubTotal.Text)

        ' Open Form3
        Dim form3 As New form3() ' Pass 'Me' which represents the current instance of Form1
        Me.Hide() ' Hide Form2 instead of closing it
        form3.Show()
    End Sub

    Public Sub StoreDataInDatabase()
        ' Connect to the database and insert data into Billsdetails table
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If dgvItems IsNot Nothing Then
                For Each row As DataGridViewRow In dgvItems.Rows
                    If Not row.IsNewRow Then
                        Dim item As String = row.Cells("Items").Value.ToString()
                        Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                        Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                        Dim amount As Decimal = Convert.ToDecimal(row.Cells("Amount").Value)
                        Dim invoiceNo As String = txtInvoiceNo.Text

                        Dim query As String = "INSERT INTO InvoiceDetails (InvoiceNo, Item, Quantity, Price, Amount) VALUES (@InvoiceNo, @Item, @Quantity, @Price, @Amount)"
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@InvoiceNo", invoiceNo)
                            command.Parameters.AddWithValue("@Item", item)
                            command.Parameters.AddWithValue("@Quantity", quantity)
                            command.Parameters.AddWithValue("@Price", price)
                            command.Parameters.AddWithValue("@Amount", amount)
                            command.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End If
        End Using
    End Sub

    Public Sub ClearInputParameters()
        ' Clear the input parameters for a new order
        If dgvItems IsNot Nothing Then
            dgvItems.Rows.Clear()
        End If
        If txtSubTotal IsNot Nothing Then
            txtSubTotal.Clear()
        End If
        If txtInvoiceNo IsNot Nothing Then
            txtInvoiceNo.Clear()
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
