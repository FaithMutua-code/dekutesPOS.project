Imports MySql.Data.MySqlClient

Public Class frmReports
    ' Define connection string for MySQL database
    Dim connStr As String = "Server=localhost;Port=3306;Database=POSDatabase1;Uid=root;Pwd=Mr.Meow@1234;"

    ' This method handles the generation of the report based on selected filters
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        ' Show the progress bar while fetching the report data
        progressBarReport.Visible = True
        progressBarReport.Style = ProgressBarStyle.Marquee

        ' Initialize the query string
        Dim reportQuery As String = ""

        ' Check the selected filter from the ComboBox
        If cboReportFilter.SelectedItem = "This Month" Then
            ' Query to fetch data for the current month
            reportQuery = "SELECT * FROM SalesI WHERE MONTH(Date) = MONTH(CURRENT_DATE()) AND YEAR(Date) = YEAR(CURRENT_DATE())"
        ElseIf cboReportFilter.SelectedItem = "Custom Date Range" Then
            ' Query to fetch data between the selected start and end dates
            reportQuery = "SELECT * FROM SalesI WHERE Date BETWEEN @StartDate AND @EndDate"
        Else
            ' Default: All SalesI
            reportQuery = "SELECT * FROM SalesI"
        End If

        ' Create a DataTable to store the report data
        Dim dt As New DataTable()

        ' Fetch data from the database and bind it to the DataGridView
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Create a command for the query
                Dim cmd As New MySqlCommand(reportQuery, conn)

                ' If using a custom date range, add parameters for the start and end date
                If cboReportFilter.SelectedItem = "Custom Date Range" Then
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.ToString("yyyy-MM-dd"))
                End If

                ' Execute the query and load the data into the DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using

            ' Bind the fetched data to the DataGridView
            dgvReport.DataSource = dt

        Catch ex As Exception
            ' Handle any errors that occur during the query execution
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Hide the progress bar once the report is loaded
            progressBarReport.Visible = False
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
