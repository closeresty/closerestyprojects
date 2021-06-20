<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTotalbooks = New System.Windows.Forms.Button()
        Me.btnListBooks = New System.Windows.Forms.Button()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_strtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_endDate = New System.Windows.Forms.DateTimePicker()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 55)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(161, 438)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTotalbooks)
        Me.GroupBox1.Controls.Add(Me.btnListBooks)
        Me.GroupBox1.Controls.Add(Me.rdoMonthly)
        Me.GroupBox1.Controls.Add(Me.rdoWeekly)
        Me.GroupBox1.Controls.Add(Me.rdoDaily)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Books"
        '
        'btnTotalbooks
        '
        Me.btnTotalbooks.Location = New System.Drawing.Point(10, 53)
        Me.btnTotalbooks.Name = "btnTotalbooks"
        Me.btnTotalbooks.Size = New System.Drawing.Size(133, 22)
        Me.btnTotalbooks.TabIndex = 3
        Me.btnTotalbooks.Text = "Total No. of Books"
        Me.btnTotalbooks.UseVisualStyleBackColor = True
        '
        'btnListBooks
        '
        Me.btnListBooks.Location = New System.Drawing.Point(9, 25)
        Me.btnListBooks.Name = "btnListBooks"
        Me.btnListBooks.Size = New System.Drawing.Size(133, 22)
        Me.btnListBooks.TabIndex = 2
        Me.btnListBooks.Text = "List of Books"
        Me.btnListBooks.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Location = New System.Drawing.Point(24, 186)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(97, 17)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly Report"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Location = New System.Drawing.Point(24, 163)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(96, 17)
        Me.rdoWeekly.TabIndex = 2
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly Report"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoDaily
        '
        Me.rdoDaily.AutoSize = True
        Me.rdoDaily.Location = New System.Drawing.Point(24, 140)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(83, 17)
        Me.rdoDaily.TabIndex = 2
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Text = "Daily Report"
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status :"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue"})
        Me.cboStatus.Location = New System.Drawing.Point(6, 103)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(137, 21)
        Me.cboStatus.TabIndex = 0
        Me.cboStatus.Text = "Borrowed"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_strtDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtp_endDate)
        Me.GroupBox2.Controls.Add(Me.btn_preview)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 162)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Filter"
        '
        'dtp_strtDate
        '
        Me.dtp_strtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_strtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_strtDate.Location = New System.Drawing.Point(10, 41)
        Me.dtp_strtDate.Name = "dtp_strtDate"
        Me.dtp_strtDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_strtDate.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Start Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "End Date :"
        '
        'dtp_endDate
        '
        Me.dtp_endDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_endDate.Location = New System.Drawing.Point(10, 89)
        Me.dtp_endDate.Name = "dtp_endDate"
        Me.dtp_endDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_endDate.TabIndex = 17
        '
        'btn_preview
        '
        Me.btn_preview.Location = New System.Drawing.Point(64, 120)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(78, 28)
        Me.btn_preview.TabIndex = 15
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(3, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(161, 55)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(774, 438)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(935, 55)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Books Inventory Report"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 493)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmReport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents rdoMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWeekly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDaily As System.Windows.Forms.RadioButton
    Friend WithEvents btnListBooks As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_strtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_endDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_preview As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnTotalbooks As System.Windows.Forms.Button
End Class
