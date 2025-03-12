Public Class frmMain
    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim salesForm As New frmSales()
        salesForm.MdiParent = Me
        salesForm.Show()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim inventoryForm As New frmInventory()
        inventoryForm.MdiParent = Me
        inventoryForm.Show()
    End Sub
    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim ReportForm As New frmReports()
        ReportForm.MdiParent = Me
        ReportForm.Show()
    End Sub
    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Dim EmployeesForm As New frmEmployees()
        EmployeesForm.MdiParent = Me
        EmployeesForm.Show()
    End Sub
    Private Sub PaymenttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Dim PaymentForm As New frmPayment()
        PaymentForm.MdiParent = Me
        PaymentForm.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class