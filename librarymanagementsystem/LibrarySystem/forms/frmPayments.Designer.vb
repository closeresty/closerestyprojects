<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Me.btnPenNew = New System.Windows.Forms.Button
        Me.btnPSave = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txthours = New System.Windows.Forms.TextBox
        Me.txtChange = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txttenderedAmount = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtTotPay = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtOverdueTime = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtSearchPborrower = New System.Windows.Forms.TextBox
        Me.dtgPenalties = New System.Windows.Forms.DataGridView
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPenClose = New System.Windows.Forms.Button
        Me.txttothours = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtgPenalties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPenNew
        '
        Me.btnPenNew.Location = New System.Drawing.Point(528, 369)
        Me.btnPenNew.Name = "btnPenNew"
        Me.btnPenNew.Size = New System.Drawing.Size(125, 31)
        Me.btnPenNew.TabIndex = 21
        Me.btnPenNew.Text = "New"
        Me.btnPenNew.UseVisualStyleBackColor = True
        '
        'btnPSave
        '
        Me.btnPSave.Location = New System.Drawing.Point(397, 369)
        Me.btnPSave.Name = "btnPSave"
        Me.btnPSave.Size = New System.Drawing.Size(125, 31)
        Me.btnPSave.TabIndex = 22
        Me.btnPSave.Text = "Save"
        Me.btnPSave.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txttothours)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.txtChange)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.txttenderedAmount)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.txtTotPay)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txtOverdueTime)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(383, 103)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(423, 253)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Payments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "="
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtamount)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.txthours)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(411, 60)
        Me.GroupBox10.TabIndex = 17
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Payment Per Hours"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(89, 27)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtamount.Size = New System.Drawing.Size(106, 25)
        Me.txtamount.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(23, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 17)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "hour"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(201, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 17)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "per"
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(247, 27)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(88, 25)
        Me.txthours.TabIndex = 10
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Location = New System.Drawing.Point(147, 197)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(254, 25)
        Me.txtChange.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(82, 200)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 17)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Change :"
        '
        'txttenderedAmount
        '
        Me.txttenderedAmount.Location = New System.Drawing.Point(147, 166)
        Me.txttenderedAmount.Name = "txttenderedAmount"
        Me.txttenderedAmount.Size = New System.Drawing.Size(254, 25)
        Me.txttenderedAmount.TabIndex = 14
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(21, 169)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 17)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Tendered Amount :"
        '
        'txtTotPay
        '
        Me.txtTotPay.Enabled = False
        Me.txtTotPay.Location = New System.Drawing.Point(147, 135)
        Me.txtTotPay.Name = "txtTotPay"
        Me.txtTotPay.Size = New System.Drawing.Size(254, 25)
        Me.txtTotPay.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(38, 138)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(103, 17)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Total Payments :"
        '
        'txtOverdueTime
        '
        Me.txtOverdueTime.Enabled = False
        Me.txtOverdueTime.Location = New System.Drawing.Point(120, 35)
        Me.txtOverdueTime.Name = "txtOverdueTime"
        Me.txtOverdueTime.Size = New System.Drawing.Size(142, 25)
        Me.txtOverdueTime.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(21, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 17)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Overdue Time:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Controls.Add(Me.TextBox7)
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Location = New System.Drawing.Point(506, 144)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(45, 25)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "do not touch.Time and Days for the future used. "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(71, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 17)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "Label25"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(71, 52)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 17)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Label25"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(75, 122)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Label26"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(15, 122)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 17)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Change :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 87)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(120, 17)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Tendered Amount :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(132, 84)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(177, 25)
        Me.TextBox7.TabIndex = 2
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(6, 52)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(70, 17)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Payments :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 26)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(70, 17)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Over Due :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSearchPborrower)
        Me.GroupBox4.Controls.Add(Me.dtgPenalties)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 365)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View Details of unreturned books with Penalties"
        '
        'txtSearchPborrower
        '
        Me.txtSearchPborrower.Location = New System.Drawing.Point(96, 42)
        Me.txtSearchPborrower.Name = "txtSearchPborrower"
        Me.txtSearchPborrower.Size = New System.Drawing.Size(263, 25)
        Me.txtSearchPborrower.TabIndex = 23
        '
        'dtgPenalties
        '
        Me.dtgPenalties.AllowUserToAddRows = False
        Me.dtgPenalties.AllowUserToDeleteRows = False
        Me.dtgPenalties.AllowUserToResizeColumns = False
        Me.dtgPenalties.AllowUserToResizeRows = False
        Me.dtgPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPenalties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgPenalties.Location = New System.Drawing.Point(9, 73)
        Me.dtgPenalties.MultiSelect = False
        Me.dtgPenalties.Name = "dtgPenalties"
        Me.dtgPenalties.RowHeadersVisible = False
        Me.dtgPenalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPenalties.Size = New System.Drawing.Size(350, 271)
        Me.dtgPenalties.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 45)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Borrower Id :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 44)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Overdues"
        '
        'btnPenClose
        '
        Me.btnPenClose.Location = New System.Drawing.Point(665, 369)
        Me.btnPenClose.Name = "btnPenClose"
        Me.btnPenClose.Size = New System.Drawing.Size(125, 31)
        Me.btnPenClose.TabIndex = 23
        Me.btnPenClose.Text = "Close"
        Me.btnPenClose.UseVisualStyleBackColor = True
        '
        'txttothours
        '
        Me.txttothours.Enabled = False
        Me.txttothours.Location = New System.Drawing.Point(318, 35)
        Me.txttothours.Name = "txttothours"
        Me.txttothours.Size = New System.Drawing.Size(64, 25)
        Me.txttothours.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "hr(s)"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 457)
        Me.Controls.Add(Me.btnPenClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPenNew)
        Me.Controls.Add(Me.btnPSave)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtgPenalties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPenNew As System.Windows.Forms.Button
    Friend WithEvents btnPSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txthours As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txttenderedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTotPay As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtOverdueTime As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchPborrower As System.Windows.Forms.TextBox
    Friend WithEvents dtgPenalties As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPenClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttothours As System.Windows.Forms.TextBox
End Class
