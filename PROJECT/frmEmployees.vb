Imports MySql.Data.MySqlClient

Public Class frmEmployees
    ' Database connection string
    Dim connStr As String = "Server=localhost;Port=3306;Database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"
    Dim conn As New MySqlConnection(connStr)

    ' Form Load Event to initialize and load employee list
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize controls (if needed)
        progressBarEmployee.Visible = False
        LoadEmployeeList()
    End Sub

    ' Load Employee data from the database into the DataGridView
    Private Sub LoadEmployeeList()
        Try
            progressBarEmployee.Visible = True
            conn.Open()
            Dim query As String = "SELECT EmployeeID, FirstName, LastName, Username, Role, Phone, Email FROM Employees"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvEmployeeList.Rows.Clear()
            While reader.Read()
                dgvEmployeeList.Rows.Add(reader("EmployeeID"), reader("FirstName"), reader("LastName"), reader("Username"), reader("Role"), reader("Phone"), reader("Email"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            progressBarEmployee.Visible = False
        End Try
    End Sub

    ' Add new Employee to the database
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Try
            ' Check if required fields are filled
            If String.IsNullOrEmpty(txtFirstName.Text) OrElse String.IsNullOrEmpty(txtLastName.Text) OrElse String.IsNullOrEmpty(txtUsername.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Create the SQL query to insert a new employee
            Dim query As String = "INSERT INTO Employees (FirstName, LastName, Username, Password, Role, Phone, Email) " &
                                  "VALUES (@FirstName, @LastName, @Username, @Password, @Role, @Phone, @Email)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Encrypt password if necessary
            cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

            conn.Open()
            cmd.ExecuteNonQuery()

            ' Display success message
            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the employee list (to display in the DataGridView)
            LoadEmployeeList()

        Catch ex As MySqlException
            ' Log or display error for SQL exceptions
            MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Log or display any other type of error
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Update an existing Employee
    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim employeeID As Integer = Convert.ToInt32(dgvEmployeeList.SelectedRows(0).Cells("EmployeeID").Value)

            Try
                Dim query As String = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Username = @Username, " &
                                      "Password = @Password, Role = @Role, Phone = @Phone, Email = @Email WHERE EmployeeID = @EmployeeID"
                Dim cmd As New MySqlCommand(query, conn)

                ' Add parameters for the update
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Encrypt password if necessary
                cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmployeeList() ' Refresh the employee list
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select an employee to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Delete an Employee
    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim employeeID As Integer = Convert.ToInt32(dgvEmployeeList.SelectedRows(0).Cells("EmployeeID").Value)

            Try
                Dim query As String = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmployeeList() ' Refresh the employee list
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Search for Employee based on Employee ID or Name
    Private Sub btnSearchEmployee_Click(sender As Object, e As EventArgs) Handles btnSearchEmployee.Click
        Try
            progressBarEmployee.Visible = True
            conn.Open()

            Dim query As String
            If Not String.IsNullOrEmpty(txtEmployeeID.Text) Then
                query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID"
            ElseIf Not String.IsNullOrEmpty(txtFirstName.Text) Then
                query = "SELECT * FROM Employees WHERE FirstName LIKE @FirstName"
            Else
                query = "SELECT * FROM Employees"
            End If

            Dim cmd As New MySqlCommand(query, conn)

            If Not String.IsNullOrEmpty(txtEmployeeID.Text) Then
                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
            End If

            If Not String.IsNullOrEmpty(txtFirstName.Text) Then
                cmd.Parameters.AddWithValue("@FirstName", "%" & txtFirstName.Text & "%")
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvEmployeeList.Rows.Clear()
            While reader.Read()
                dgvEmployeeList.Rows.Add(reader("EmployeeID"), reader("FirstName"), reader("LastName"), reader("Username"), reader("Role"), reader("Phone"), reader("Email"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            progressBarEmployee.Visible = False
        End Try
    End Sub

    ' Event handler for Clear button click
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all textboxes
        txtEmployeeID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPhone.Clear()
        txtEmail.Clear()

        ' Reset the role combo box to its default (empty or first item)
        cboRole.SelectedIndex = -1

        ' Optionally, clear DataGridView selection
        dgvEmployeeList.ClearSelection()

        ' Hide progress bar (if visible)
        progressBarEmployee.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class

