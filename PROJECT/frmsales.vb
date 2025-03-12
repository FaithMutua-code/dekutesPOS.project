Imports MySql.Data.MySqlClient

Public Class frmSales
    Dim connStr As String = "Server=localhost;Port=3306;database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"
    Dim conn As New MySqlConnection(connStr)
    Dim cart As New List(Of String) ' To store cart items temporarily
    Dim totalPrice As Decimal = 0.0

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems() ' Load items into ComboBox when form loads
    End Sub

    ' Load available items from the database into the ComboBox
    Private Sub LoadItems()
        Try
            conn.Open()
            Dim query As String = "SELECT ItemID, ItemName, Price, Stock FROM ItemsI"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cboItems.Items.Clear()  ' Clear existing items in the ComboBox
            While reader.Read()
                Dim itemName As String = reader("ItemName").ToString()
                Dim itemID As Integer = Convert.ToInt32(reader("ItemID"))
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                ' Add the item name, price, and ItemID to the ComboBox (using anonymous type)
                cboItems.Items.Add(New With {.ItemID = itemID, .ItemName = itemName, .Price = price})
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Handle adding items to the cart with the specified quantity
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' Check if the ComboBox has a selected item
        If cboItems.SelectedIndex >= 0 Then
            ' Get the selected item from the ComboBox
            Dim selectedItem = cboItems.SelectedItem
            Dim itemID As Integer = selectedItem.ItemID
            Dim itemName As String = selectedItem.ItemName
            Dim price As Decimal = selectedItem.Price
            Dim stock As Integer

            ' Get the stock value from the database for the selected item
            conn.Open()
            Dim stockQuery As String = "SELECT Stock FROM ItemsI WHERE ItemID = @ItemID"
            Dim cmd As New MySqlCommand(stockQuery, conn)
            cmd.Parameters.AddWithValue("@ItemID", itemID)
            stock = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            ' Get the quantity entered by the user
            Dim quantity As Integer
            If Integer.TryParse(txtQuantity.Text, quantity) Then
                If quantity > 0 And quantity <= stock Then
                    ' Add the item to the cart with the desired quantity
                    Dim cartItem As String = itemName & " x " & quantity.ToString() & " - $" & (price * quantity).ToString("F2")
                    cart.Add(cartItem)

                    ' Update the ListBox and Total Price
                    lstCart.Items.Add(cartItem)
                    totalPrice += price * quantity
                    lblTotalPrice.Text = "Total: $" & totalPrice.ToString("F2")
                Else
                    MessageBox.Show("Please enter a valid quantity within stock limits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle the "Pay" button click event
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' Before redirecting to the payment form, check if there are items in the cart
        If lstCart.Items.Count > 0 Then
            ' Create and show the payment form (frmPayment)
            Dim paymentForm As New frmPayment()

            ' Pass the total price to the payment form
            paymentForm.TotalAmount = totalPrice ' Add a TotalAmount property in frmPayment

            ' Show the payment form
            paymentForm.Show()

            ' Hide the current sales form
            Me.Hide()
        Else
            MessageBox.Show("Your cart is empty. Please add items to the cart before proceeding to payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Reset the cart and total price
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstCart.Items.Clear()
        cart.Clear()
        totalPrice = 0.0
        lblTotalPrice.Text = "Total: $0.00"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class

