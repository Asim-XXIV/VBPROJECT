<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form2
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
        Label1 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        cmbItem = New ComboBox()
        dgvItems = New DataGridView()
        items = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        amount = New DataGridViewTextBoxColumn()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label3 = New Label()
        btnGenerateBill = New Button()
        subTotal57835 = New Label()
        txtSubTotal = New TextBox()
        txtInvoiceNo = New TextBox()
        Label4 = New Label()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(191, 42)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 30)
        Label1.TabIndex = 0
        Label1.Text = "Items"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(704, 41)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 30)
        Label2.TabIndex = 1
        Label2.Text = "Price"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.MediumTurquoise
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(484, 86)
        btnAdd.Margin = New Padding(4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(119, 38)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' cmbItem
        ' 
        cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        cmbItem.FormattingEnabled = True
        cmbItem.Items.AddRange(New Object() {"Veg Burger", "Chicken Burger", "Veg MoMo", "Chicken MoMo", "Chicken Pizza", "Mixed Pizza", "Thukpa", "Paratha", "Pakoda", "Veg Khana", "Chicken Khana", "Milk Tea", "Black Tea", "Hot Lemon", "Cold Drinks"})
        cmbItem.Location = New Point(255, 39)
        cmbItem.Margin = New Padding(4)
        cmbItem.Name = "cmbItem"
        cmbItem.Size = New Size(238, 36)
        cmbItem.TabIndex = 3
        ' 
        ' dgvItems
        ' 
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {items, price, quantity, amount})
        dgvItems.Location = New Point(15, 130)
        dgvItems.Margin = New Padding(4)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersWidth = 51
        dgvItems.RowTemplate.Height = 29
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(980, 425)
        dgvItems.TabIndex = 5
        dgvItems.TabStop = False
        ' 
        ' items
        ' 
        items.HeaderText = "Items"
        items.MinimumWidth = 6
        items.Name = "items"
        ' 
        ' price
        ' 
        price.HeaderText = "Price"
        price.MinimumWidth = 6
        price.Name = "price"
        ' 
        ' quantity
        ' 
        quantity.HeaderText = "Quantity"
        quantity.MinimumWidth = 6
        quantity.Name = "quantity"
        ' 
        ' amount
        ' 
        amount.HeaderText = "Amount"
        amount.MinimumWidth = 6
        amount.Name = "amount"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtPrice.Location = New Point(770, 34)
        txtPrice.Margin = New Padding(4)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(124, 35)
        txtPrice.TabIndex = 4
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(560, 44)
        txtQuantity.Margin = New Padding(4)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(126, 31)
        txtQuantity.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(510, 44)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 25)
        Label3.TabIndex = 7
        Label3.Text = "Qty"
        ' 
        ' btnGenerateBill
        ' 
        btnGenerateBill.BackColor = Color.MediumTurquoise
        btnGenerateBill.FlatStyle = FlatStyle.Popup
        btnGenerateBill.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerateBill.Location = New Point(861, 631)
        btnGenerateBill.Margin = New Padding(4)
        btnGenerateBill.Name = "btnGenerateBill"
        btnGenerateBill.Size = New Size(119, 38)
        btnGenerateBill.TabIndex = 8
        btnGenerateBill.Text = "Next"
        btnGenerateBill.UseVisualStyleBackColor = False
        ' 
        ' subTotal57835
        ' 
        subTotal57835.AutoSize = True
        subTotal57835.Location = New Point(742, 571)
        subTotal57835.Margin = New Padding(4, 0, 4, 0)
        subTotal57835.Name = "subTotal57835"
        subTotal57835.Size = New Size(85, 25)
        subTotal57835.TabIndex = 9
        subTotal57835.Text = "Sub Total"
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(839, 565)
        txtSubTotal.Margin = New Padding(4)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(155, 31)
        txtSubTotal.TabIndex = 10
        ' 
        ' txtInvoiceNo
        ' 
        txtInvoiceNo.Location = New Point(121, 13)
        txtInvoiceNo.Margin = New Padding(4)
        txtInvoiceNo.Name = "txtInvoiceNo"
        txtInvoiceNo.Size = New Size(126, 31)
        txtInvoiceNo.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(3, 9)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 30)
        Label4.TabIndex = 12
        Label4.Text = "Invoice NO"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 705)
        Controls.Add(Label4)
        Controls.Add(txtInvoiceNo)
        Controls.Add(txtSubTotal)
        Controls.Add(subTotal57835)
        Controls.Add(btnGenerateBill)
        Controls.Add(Label3)
        Controls.Add(txtQuantity)
        Controls.Add(dgvItems)
        Controls.Add(txtPrice)
        Controls.Add(cmbItem)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form1"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents items As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Public WithEvents cmbItem As ComboBox
    Public WithEvents txtPrice As TextBox
    Public WithEvents dgvItems As DataGridView
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents subTotal57835 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label4 As Label
End Class
