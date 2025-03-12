Imports MySql.Data.MySqlClient

Public Class frmPayment
    ' Database connection string
    Dim connStr As String = "Server=localhost;Port=3306;Database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"
    Dim conn As New MySqlConnection(connStr)

    ' Property to receive total price from frmSales
    Public Property TotalAmount As Decimal

    ' Form Load Event
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize controls
        cboPaymentMethod.SelectedIndex = -1
        txtCustomerName.Clear()
        lblPaymentStatus.Text = ""

        ' Display the total amount from frmSales
        lblTotalAmount.Text = "Total Amount: $" & TotalAmount.ToString("F2")
    End Sub

    ' Submit payment logic
    Private Sub btnSubmitPayment_Click(sender As Object, e As EventArgs) Handles btnSubmitPayment.Click
        ' Validate form fields
        If String.IsNullOrEmpty(txtCustomerName.Text) OrElse cboPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields before submitting the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Use TotalAmount from frmSales as payment amount
        Dim paymentAmount As Decimal = TotalAmount

        ' Insert payment information into the database
        Try
            Dim query As String = "INSERT INTO Payments (CustomerName, PaymentAmount, PaymentMethod, PaymentDate) " &
                                  "VALUES (@CustomerName, @PaymentAmount, @PaymentMethod, @PaymentDate)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@PaymentAmount", paymentAmount)
            cmd.Parameters.AddWithValue("@PaymentMethod", cboPaymentMethod.SelectedItem)
            cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now)

            conn.Open()
            cmd.ExecuteNonQuery()

            ' Display success message
            lblPaymentStatus.Text = "Payment of $" & paymentAmount.ToString("0.00") & " was successfully processed!"
            lblPaymentStatus.ForeColor = Color.Green
            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the form after submission
            txtCustomerName.Clear()
            cboPaymentMethod.SelectedIndex = -1

            ' Optionally, navigate to the Sales Form after payment
            ' Dim salesForm As New frmSales()
            ' salesForm.Show()
            ' Me.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustomerName.Clear()
        cboPaymentMethod.SelectedIndex = -1
        lblPaymentStatus.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

