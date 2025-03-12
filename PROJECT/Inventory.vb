Imports MySql.Data.MySqlClient

Public Class frmInventory
    ' Connection string for MySQL database
    Dim connStr As String = "Server=localhost;Port=3306;Database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"
    Dim conn As New MySqlConnection(connStr)

    ' Form Load event - to load inventory when the form is loaded
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    ' Load the inventory data from the database and display it in the DataGridView
    Private Sub LoadInventory()
        Try
            conn.Open()
            Dim query As String = "SELECT ItemID, ItemName, Price, Stock FROM ItemsI"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear the DataGridView before loading new data
            dgvInventory.Rows.Clear()

            ' Loop through the database records and add rows to the DataGridView
            While reader.Read()
                Dim itemName As String = reader("ItemName").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                Dim stock As Integer = Convert.ToInt32(reader("Stock"))

                ' Add the item details to the DataGridView
                dgvInventory.Rows.Add(itemName, price.ToString("F2"), stock)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Add stock to the selected item
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Dim itemID As Integer
        Dim quantity As Integer

        ' Validate ItemID and Quantity
        If Integer.TryParse(txtItemID.Text, itemID) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then
            If quantity > 0 Then
                Try
                    conn.Open()
                    Dim query As String = "UPDATE ItemsI SET Stock = Stock + @Quantity WHERE ItemID = @ItemID"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@ItemID", itemID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the inventory to reflect the updated stock
                    LoadInventory()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter valid ItemID and Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Remove stock from the selected item
    Private Sub btnRemoveStock_Click(sender As Object, e As EventArgs) Handles btnRemoveStock.Click
        Dim itemID As Integer
        Dim quantity As Integer

        ' Validate ItemID and Quantity
        If Integer.TryParse(txtItemID.Text, itemID) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then
            If quantity > 0 Then
                Try
                    conn.Open()
                    ' Ensure stock is available before removing
                    Dim query As String = "UPDATE ItemsI SET Stock = Stock - @Quantity WHERE ItemID = @ItemID AND Stock >= @Quantity"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@ItemID", itemID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Stock removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Reload the inventory to reflect the updated stock
                        LoadInventory()
                    Else
                        MessageBox.Show("Not enough stock to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter valid ItemID and Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Check and display stock level of a specific item based on ItemID
    Private Sub btnCheckStock_Click(sender As Object, e As EventArgs) Handles btnCheckStock.Click
        Dim itemID As Integer

        ' Validate ItemID
        If Integer.TryParse(txtItemID.Text, itemID) Then
            Try
                conn.Open()
                Dim query As String = "SELECT ItemName, Stock FROM ItemsI WHERE ItemID = @ItemID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ItemID", itemID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim itemName As String = reader("ItemName").ToString()
                    Dim stock As Integer = Convert.ToInt32(reader("Stock"))
                    lblStockLevel.Text = "Stock Level: " & stock.ToString()
                Else
                    MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please enter a valid ItemID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
