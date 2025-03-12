<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        dgvInventory = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        txtItemID = New TextBox()
        btnAddStock = New Button()
        btnRemoveStock = New Button()
        lblStockLevel = New Label()
        btnCheckStock = New Button()
        Label1 = New Label()
        txtQuantity = New TextBox()
        Label2 = New Label()
        btnClose = New Button()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgvInventory.Location = New Point(428, 12)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersVisible = False
        dgvInventory.RowHeadersWidth = 62
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventory.Size = New Size(360, 225)
        dgvInventory.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ItemName"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Price"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Stock"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' txtItemID
        ' 
        txtItemID.Location = New Point(172, 94)
        txtItemID.Name = "txtItemID"
        txtItemID.Size = New Size(150, 31)
        txtItemID.TabIndex = 1
        ' 
        ' btnAddStock
        ' 
        btnAddStock.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAddStock.Location = New Point(66, 203)
        btnAddStock.Name = "btnAddStock"
        btnAddStock.Size = New Size(112, 34)
        btnAddStock.TabIndex = 2
        btnAddStock.Text = "Add Stock"
        btnAddStock.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveStock
        ' 
        btnRemoveStock.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnRemoveStock.Location = New Point(46, 245)
        btnRemoveStock.Name = "btnRemoveStock"
        btnRemoveStock.Size = New Size(149, 44)
        btnRemoveStock.TabIndex = 3
        btnRemoveStock.Text = "Remove Stock"
        btnRemoveStock.UseVisualStyleBackColor = False
        ' 
        ' lblStockLevel
        ' 
        lblStockLevel.AutoSize = True
        lblStockLevel.Location = New Point(83, 370)
        lblStockLevel.Name = "lblStockLevel"
        lblStockLevel.Size = New Size(95, 25)
        lblStockLevel.TabIndex = 4
        lblStockLevel.Text = "Stock level"
        ' 
        ' btnCheckStock
        ' 
        btnCheckStock.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnCheckStock.Location = New Point(35, 333)
        btnCheckStock.Name = "btnCheckStock"
        btnCheckStock.Size = New Size(160, 34)
        btnCheckStock.TabIndex = 5
        btnCheckStock.Text = "Check Stock"
        btnCheckStock.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-4, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 6
        Label1.Text = "Enter item ID"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(172, 144)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(150, 31)
        txtQuantity.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-4, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 25)
        Label2.TabIndex = 8
        Label2.Text = "Enter item Quantity "
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(464, 349)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(Label2)
        Controls.Add(txtQuantity)
        Controls.Add(Label1)
        Controls.Add(btnCheckStock)
        Controls.Add(lblStockLevel)
        Controls.Add(btnRemoveStock)
        Controls.Add(btnAddStock)
        Controls.Add(txtItemID)
        Controls.Add(dgvInventory)
        Name = "frmInventory"
        Text = "Inventory"
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents btnAddStock As Button
    Friend WithEvents btnRemoveStock As Button
    Friend WithEvents lblStockLevel As Label
    Friend WithEvents btnCheckStock As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
