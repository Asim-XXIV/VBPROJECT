<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form3
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
        dgvInvoiceDetails = New DataGridView()
        txtTotalPayable = New TextBox()
        subTotal57835 = New Label()
        btnGenerateBill = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTax = New TextBox()
        txtService = New TextBox()
        txtDiscount = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        txtHighestInvoiceNumber = New TextBox()
        CType(dgvInvoiceDetails, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvInvoiceDetails
        ' 
        dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInvoiceDetails.Location = New Point(125, 76)
        dgvInvoiceDetails.Margin = New Padding(4)
        dgvInvoiceDetails.Name = "dgvInvoiceDetails"
        dgvInvoiceDetails.RowHeadersWidth = 51
        dgvInvoiceDetails.RowTemplate.Height = 29
        dgvInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInvoiceDetails.Size = New Size(516, 416)
        dgvInvoiceDetails.TabIndex = 6
        dgvInvoiceDetails.TabStop = False
        ' 
        ' txtTotalPayable
        ' 
        txtTotalPayable.Location = New Point(922, 521)
        txtTotalPayable.Margin = New Padding(4)
        txtTotalPayable.Name = "txtTotalPayable"
        txtTotalPayable.Size = New Size(155, 31)
        txtTotalPayable.TabIndex = 13
        ' 
        ' subTotal57835
        ' 
        subTotal57835.AutoSize = True
        subTotal57835.Location = New Point(794, 530)
        subTotal57835.Margin = New Padding(4, 0, 4, 0)
        subTotal57835.Name = "subTotal57835"
        subTotal57835.Size = New Size(114, 25)
        subTotal57835.TabIndex = 12
        subTotal57835.Text = "Total Payable"
        ' 
        ' btnGenerateBill
        ' 
        btnGenerateBill.BackColor = Color.MediumTurquoise
        btnGenerateBill.FlatStyle = FlatStyle.Popup
        btnGenerateBill.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerateBill.Location = New Point(945, 588)
        btnGenerateBill.Margin = New Padding(4)
        btnGenerateBill.Name = "btnGenerateBill"
        btnGenerateBill.Size = New Size(119, 38)
        btnGenerateBill.TabIndex = 11
        btnGenerateBill.Text = "Print"
        btnGenerateBill.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtTax)
        Panel1.Controls.Add(txtService)
        Panel1.Controls.Add(txtDiscount)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(649, 76)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(465, 322)
        Panel1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 221)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 25)
        Label4.TabIndex = 18
        Label4.Text = "TAX"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 161)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 25)
        Label3.TabIndex = 17
        Label3.Text = "Service charge"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 106)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 16
        Label2.Text = "Discount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 25)
        Label1.TabIndex = 15
        Label1.Text = "Sub total"
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(249, 212)
        txtTax.Margin = New Padding(4)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(185, 31)
        txtTax.TabIndex = 3
        ' 
        ' txtService
        ' 
        txtService.Location = New Point(249, 152)
        txtService.Margin = New Padding(4)
        txtService.Name = "txtService"
        txtService.Size = New Size(185, 31)
        txtService.TabIndex = 2
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(249, 98)
        txtDiscount.Margin = New Padding(4)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(185, 31)
        txtDiscount.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(249, 42)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(185, 31)
        TextBox1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(374, 22)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 25)
        Label5.TabIndex = 17
        Label5.Text = "Invoice no."
        ' 
        ' txtHighestInvoiceNumber
        ' 
        txtHighestInvoiceNumber.Location = New Point(481, 19)
        txtHighestInvoiceNumber.Margin = New Padding(4)
        txtHighestInvoiceNumber.Name = "txtHighestInvoiceNumber"
        txtHighestInvoiceNumber.Size = New Size(100, 31)
        txtHighestInvoiceNumber.TabIndex = 18
        ' 
        ' form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1161, 635)
        Controls.Add(txtHighestInvoiceNumber)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(txtTotalPayable)
        Controls.Add(subTotal57835)
        Controls.Add(btnGenerateBill)
        Controls.Add(dgvInvoiceDetails)
        Margin = New Padding(4)
        Name = "form3"
        Text = "Form2"
        CType(dgvInvoiceDetails, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents dgvItems As DataGridView
    Friend WithEvents items As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents subTotal57835 As Label
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents txtInvoiceNo1 As TextBox
    Public WithEvents dgvInvoiceDetails As DataGridView
    Friend WithEvents txtHighestInvoiceNumber As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTotalPayable As TextBox
End Class
