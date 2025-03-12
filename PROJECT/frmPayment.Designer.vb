<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        txtCustomerName = New TextBox()
        cboPaymentMethod = New ComboBox()
        lblPaymentStatus = New Label()
        btnSubmitPayment = New Button()
        btnClear = New Button()
        lblTotalAmount = New Label()
        Label1 = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(167, 173)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(150, 31)
        txtCustomerName.TabIndex = 1
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.FormattingEnabled = True
        cboPaymentMethod.Items.AddRange(New Object() {"cash", "mpesa", "bank", "airtel money"})
        cboPaymentMethod.Location = New Point(390, 79)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(182, 33)
        cboPaymentMethod.TabIndex = 2
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Location = New Point(144, 257)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(133, 25)
        lblPaymentStatus.TabIndex = 3
        lblPaymentStatus.Text = "Payment Status"
        ' 
        ' btnSubmitPayment
        ' 
        btnSubmitPayment.Location = New Point(32, 351)
        btnSubmitPayment.Name = "btnSubmitPayment"
        btnSubmitPayment.Size = New Size(112, 34)
        btnSubmitPayment.TabIndex = 4
        btnSubmitPayment.Text = "Submit Payment"
        btnSubmitPayment.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(276, 351)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(32, 99)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(116, 25)
        lblTotalAmount.TabIndex = 6
        lblTotalAmount.Text = "Total amount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 7
        Label1.Text = "customer name"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(565, 351)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmPayment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(Label1)
        Controls.Add(lblTotalAmount)
        Controls.Add(btnClear)
        Controls.Add(btnSubmitPayment)
        Controls.Add(lblPaymentStatus)
        Controls.Add(cboPaymentMethod)
        Controls.Add(txtCustomerName)
        Name = "frmPayment"
        Text = "frmPayment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPaymentAmount As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents btnSubmitPayment As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
End Class
