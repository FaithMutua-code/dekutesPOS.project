<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        cboReportFilter = New ComboBox()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        btnGenerateReport = New Button()
        progressBarReport = New ProgressBar()
        dgvReport = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnClose = New Button()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboReportFilter
        ' 
        cboReportFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboReportFilter.FormattingEnabled = True
        cboReportFilter.Items.AddRange(New Object() {"All Sales", "This Month", "Custom Date range"})
        cboReportFilter.Location = New Point(130, 33)
        cboReportFilter.Name = "cboReportFilter"
        cboReportFilter.Size = New Size(182, 33)
        cboReportFilter.TabIndex = 0
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(108, 84)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(300, 31)
        dtpStartDate.TabIndex = 1
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(93, 149)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(300, 31)
        dtpEndDate.TabIndex = 2
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.Location = New Point(140, 222)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(158, 34)
        btnGenerateReport.TabIndex = 3
        btnGenerateReport.Text = "Generate Report"
        btnGenerateReport.UseVisualStyleBackColor = True
        ' 
        ' progressBarReport
        ' 
        progressBarReport.Location = New Point(130, 309)
        progressBarReport.Name = "progressBarReport"
        progressBarReport.Size = New Size(150, 34)
        progressBarReport.TabIndex = 4
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(510, 84)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 62
        dgvReport.Size = New Size(476, 370)
        dgvReport.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 6
        Label1.Text = "Report Filter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 25)
        Label2.TabIndex = 7
        Label2.Text = "Start Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 8
        Label3.Text = "End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 309)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 9
        Label4.Text = "Progress bar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 17F)
        Label5.Location = New Point(577, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 46)
        Label5.TabIndex = 10
        Label5.Text = "The Report"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(177, 387)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(992, 499)
        Controls.Add(btnClose)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvReport)
        Controls.Add(progressBarReport)
        Controls.Add(btnGenerateReport)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(cboReportFilter)
        Name = "frmReports"
        Text = "Reports"
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboReportFilter As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents progressBarReport As ProgressBar
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
End Class
