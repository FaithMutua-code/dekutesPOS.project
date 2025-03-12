Imports MySql.Data.MySqlClient

Public Class frmLogin
    ' Database connection string
    Dim connStr As String = "Server=localhost;Port=3306;Database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn.Open()

            ' Query to check if the employee with the given username exists
            Dim query As String = "SELECT EmployeeID, FirstName, LastName, Password FROM Employees WHERE Username = @Username"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", username)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Compare the entered password with the stored password
                If password = reader("Password").ToString() Then
                    ' Login successful
                    MessageBox.Show("Login Successful", "Info", MessageBoxButtons.OK)

                    ' Optionally, you can save the employee details and show the main form
                    Dim mainForm As New frmMain()
                    mainForm.Show()
                    Me.Hide()
                Else
                    ' Incorrect password
                    MessageBox.Show("Incorrect password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' Username not found
                MessageBox.Show("Username not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As MySqlException
            ' Handle any database errors
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class

