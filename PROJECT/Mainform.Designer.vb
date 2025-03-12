<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        MenuStrip1 = New MenuStrip()
        SalesToolStripMenuItem = New ToolStripMenuItem()
        PaymentToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        EmployeesToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        MenuStrip3 = New MenuStrip()
        MenuStrip4 = New MenuStrip()
        MenuStrip5 = New MenuStrip()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SalesToolStripMenuItem, PaymentToolStripMenuItem, InventoryToolStripMenuItem, EmployeesToolStripMenuItem, ReportToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 24)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(553, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(66, 29)
        SalesToolStripMenuItem.Text = "sales"
        ' 
        ' PaymentToolStripMenuItem
        ' 
        PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        PaymentToolStripMenuItem.Size = New Size(96, 29)
        PaymentToolStripMenuItem.Text = "Payment"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(103, 29)
        InventoryToolStripMenuItem.Text = "Inventory"
        ' 
        ' EmployeesToolStripMenuItem
        ' 
        EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        EmployeesToolStripMenuItem.Size = New Size(114, 29)
        EmployeesToolStripMenuItem.Text = "Employees"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(81, 29)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(85, 29)
        ToolStripMenuItem1.Text = "Logout"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Location = New Point(0, 72)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 2
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' MenuStrip3
        ' 
        MenuStrip3.ImageScalingSize = New Size(24, 24)
        MenuStrip3.Location = New Point(0, 48)
        MenuStrip3.Name = "MenuStrip3"
        MenuStrip3.Size = New Size(800, 24)
        MenuStrip3.TabIndex = 4
        MenuStrip3.Text = "MenuStrip3"
        ' 
        ' MenuStrip4
        ' 
        MenuStrip4.ImageScalingSize = New Size(24, 24)
        MenuStrip4.Location = New Point(0, 24)
        MenuStrip4.Name = "MenuStrip4"
        MenuStrip4.Size = New Size(800, 24)
        MenuStrip4.TabIndex = 5
        MenuStrip4.Text = "MenuStrip4"
        ' 
        ' MenuStrip5
        ' 
        MenuStrip5.ImageScalingSize = New Size(24, 24)
        MenuStrip5.Location = New Point(0, 0)
        MenuStrip5.Name = "MenuStrip5"
        MenuStrip5.Size = New Size(800, 24)
        MenuStrip5.TabIndex = 6
        MenuStrip5.Text = "MenuStrip5"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        Controls.Add(MenuStrip3)
        Controls.Add(MenuStrip4)
        Controls.Add(MenuStrip5)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        Text = "Mainform"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents MenuStrip5 As MenuStrip
End Class
