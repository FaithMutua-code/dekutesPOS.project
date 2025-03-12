<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        txtEmployeeID = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        cboRole = New ComboBox()
        btnAddEmployee = New Button()
        btnDeleteEmployee = New Button()
        btnSearchEmployee = New Button()
        lblEmployeeID = New Label()
        lblUserName = New Label()
        lblPassword = New Label()
        lblPhone = New Label()
        Label5 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtRole = New TextBox()
        lblRole = New Label()
        lblLastName = New Label()
        lblFirstName = New Label()
        dgvEmployeeList = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        progressBarEmployee = New ProgressBar()
        btnClear = New Button()
        btnClose = New Button()
        CType(dgvEmployeeList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(139, 29)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(150, 31)
        txtEmployeeID.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(139, 190)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(139, 246)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(139, 329)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(139, 376)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 4
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Cashier", "Manager", "Admin"})
        cboRole.Location = New Point(375, 63)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(182, 33)
        cboRole.TabIndex = 5
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(12, 501)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(112, 34)
        btnAddEmployee.TabIndex = 6
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.Location = New Point(199, 501)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(112, 34)
        btnDeleteEmployee.TabIndex = 7
        btnDeleteEmployee.Text = "Delete Employee"
        btnDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnSearchEmployee
        ' 
        btnSearchEmployee.Location = New Point(375, 501)
        btnSearchEmployee.Name = "btnSearchEmployee"
        btnSearchEmployee.Size = New Size(112, 34)
        btnSearchEmployee.TabIndex = 8
        btnSearchEmployee.Text = "Search"
        btnSearchEmployee.UseVisualStyleBackColor = True
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.AutoSize = True
        lblEmployeeID.Location = New Point(3, 32)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(113, 25)
        lblEmployeeID.TabIndex = 9
        lblEmployeeID.Text = "Employee ID"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(14, 190)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(94, 25)
        lblUserName.TabIndex = 10
        lblUserName.Text = "UserName"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(12, 252)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(87, 25)
        lblPassword.TabIndex = 11
        lblPassword.Text = "Password"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(39, 335)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(62, 25)
        lblPhone.TabIndex = 12
        lblPhone.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 25)
        Label5.TabIndex = 13
        Label5.Text = "Email"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(139, 72)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(150, 31)
        txtFirstName.TabIndex = 14
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(139, 127)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(150, 31)
        txtLastName.TabIndex = 15
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(139, 283)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(150, 31)
        txtRole.TabIndex = 16
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.FlatStyle = FlatStyle.Popup
        lblRole.Location = New Point(37, 289)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 25)
        lblRole.TabIndex = 17
        lblRole.Text = "Role"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(14, 130)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 25)
        lblLastName.TabIndex = 18
        lblLastName.Text = "Last Name"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(14, 75)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 19
        lblFirstName.Text = "First Name"
        ' 
        ' dgvEmployeeList
        ' 
        dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeList.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgvEmployeeList.Location = New Point(581, 12)
        dgvEmployeeList.Name = "dgvEmployeeList"
        dgvEmployeeList.RowHeadersWidth = 62
        dgvEmployeeList.Size = New Size(1138, 348)
        dgvEmployeeList.TabIndex = 20
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Employee ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "First Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Last Name"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Username"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Role"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Phone"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Email"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 150
        ' 
        ' progressBarEmployee
        ' 
        progressBarEmployee.Location = New Point(366, 443)
        progressBarEmployee.Name = "progressBarEmployee"
        progressBarEmployee.Size = New Size(150, 34)
        progressBarEmployee.TabIndex = 21
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(403, 244)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 22
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(692, 425)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 23
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmEmployees
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1710, 547)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(progressBarEmployee)
        Controls.Add(dgvEmployeeList)
        Controls.Add(lblFirstName)
        Controls.Add(lblLastName)
        Controls.Add(lblRole)
        Controls.Add(txtRole)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(Label5)
        Controls.Add(lblPhone)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(lblEmployeeID)
        Controls.Add(btnSearchEmployee)
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnAddEmployee)
        Controls.Add(cboRole)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtEmployeeID)
        Name = "frmEmployees"
        Text = "frmEmployees"
        CType(dgvEmployeeList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnSearchEmployee As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents dgvEmployeeList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents progressBarEmployee As ProgressBar
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
