<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        btnAddToCart = New Button()
        txtQuantity = New TextBox()
        btnCompleteSale = New Button()
        lblTotalPrice = New Label()
        lstCart = New ListBox()
        cboItems = New ComboBox()
        lblselect = New Label()
        btnReset = New Button()
        btnPay = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAddToCart.Location = New Point(64, 135)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(164, 34)
        btnAddToCart.TabIndex = 0
        btnAddToCart.Text = "Add To Cart"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.AutoCompleteMode = AutoCompleteMode.Append
        txtQuantity.BackColor = SystemColors.ScrollBar
        txtQuantity.Location = New Point(76, 67)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(150, 31)
        txtQuantity.TabIndex = 2
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCompleteSale
        ' 
        btnCompleteSale.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnCompleteSale.Location = New Point(64, 368)
        btnCompleteSale.Name = "btnCompleteSale"
        btnCompleteSale.Size = New Size(187, 34)
        btnCompleteSale.TabIndex = 3
        btnCompleteSale.Text = "Complete Sale"
        btnCompleteSale.UseVisualStyleBackColor = False
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        lblTotalPrice.Location = New Point(90, 324)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(91, 25)
        lblTotalPrice.TabIndex = 4
        lblTotalPrice.Text = "Total Price"
        ' 
        ' lstCart
        ' 
        lstCart.FormattingEnabled = True
        lstCart.ItemHeight = 25
        lstCart.Location = New Point(48, 175)
        lstCart.Name = "lstCart"
        lstCart.Size = New Size(180, 129)
        lstCart.TabIndex = 5
        ' 
        ' cboItems
        ' 
        cboItems.FormattingEnabled = True
        cboItems.Location = New Point(722, 67)
        cboItems.Name = "cboItems"
        cboItems.Size = New Size(303, 33)
        cboItems.TabIndex = 6
        ' 
        ' lblselect
        ' 
        lblselect.AutoSize = True
        lblselect.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        lblselect.Location = New Point(815, 26)
        lblselect.Name = "lblselect"
        lblselect.Size = New Size(138, 25)
        lblselect.TabIndex = 7
        lblselect.Text = "Select Item here"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(572, 368)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 8
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(370, 369)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(112, 34)
        btnPay.TabIndex = 9
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(778, 369)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 10
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1108, 450)
        Controls.Add(btnClose)
        Controls.Add(btnPay)
        Controls.Add(btnReset)
        Controls.Add(lblselect)
        Controls.Add(cboItems)
        Controls.Add(lstCart)
        Controls.Add(lblTotalPrice)
        Controls.Add(btnCompleteSale)
        Controls.Add(txtQuantity)
        Controls.Add(btnAddToCart)
        Name = "frmSales"
        Text = "frmsales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddToCart As Button
    Friend WithEvents dgvSalesItems As DataGridView
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnCompleteSale As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lstCart As ListBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cboItems As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblselect As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnClose As Button
End Class
