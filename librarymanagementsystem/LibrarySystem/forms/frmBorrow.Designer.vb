<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.components = New System.ComponentModel.Container
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btn_Bsave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearchAccesion = New System.Windows.Forms.Button
        Me.txtAccesionNumBorrow = New System.Windows.Forms.TextBox
        Me.lblAccessionNumBorrow = New System.Windows.Forms.Label
        Me.txtbooktype = New System.Windows.Forms.TextBox
        Me.txtpublisher = New System.Windows.Forms.TextBox
        Me.txtDatePublish = New System.Windows.Forms.TextBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAuthor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.grp_Bgroup = New System.Windows.Forms.GroupBox
        Me.txtBorrowerId = New System.Windows.Forms.TextBox
        Me.btnSearchBorrower = New System.Windows.Forms.Button
        Me.cboPurpose = New System.Windows.Forms.ComboBox
        Me.txtdue = New System.Windows.Forms.TextBox
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.dtg_BlistOfBooks = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.check_due = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_Bgroup.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dtg_BlistOfBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 59)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(839, 439)
        Me.TabControl2.TabIndex = 21
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnClose)
        Me.TabPage3.Controls.Add(Me.btnNew)
        Me.TabPage3.Controls.Add(Me.btn_Bsave)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.grp_Bgroup)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(831, 413)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Details"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(698, 289)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 39)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(576, 289)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 39)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "Clear"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btn_Bsave
        '
        Me.btn_Bsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bsave.Location = New System.Drawing.Point(455, 289)
        Me.btn_Bsave.Name = "btn_Bsave"
        Me.btn_Bsave.Size = New System.Drawing.Size(116, 39)
        Me.btn_Bsave.TabIndex = 17
        Me.btn_Bsave.Text = "Borrow"
        Me.btn_Bsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchAccesion)
        Me.GroupBox1.Controls.Add(Me.txtAccesionNumBorrow)
        Me.GroupBox1.Controls.Add(Me.lblAccessionNumBorrow)
        Me.GroupBox1.Controls.Add(Me.txtbooktype)
        Me.GroupBox1.Controls.Add(Me.txtpublisher)
        Me.GroupBox1.Controls.Add(Me.txtDatePublish)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 291)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book's Details"
        '
        'btnSearchAccesion
        '
        Me.btnSearchAccesion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAccesion.Location = New System.Drawing.Point(300, 49)
        Me.btnSearchAccesion.Name = "btnSearchAccesion"
        Me.btnSearchAccesion.Size = New System.Drawing.Size(57, 25)
        Me.btnSearchAccesion.TabIndex = 24
        Me.btnSearchAccesion.Text = "Find"
        Me.btnSearchAccesion.UseVisualStyleBackColor = True
        '
        'txtAccesionNumBorrow
        '
        Me.txtAccesionNumBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAccesionNumBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAccesionNumBorrow.Location = New System.Drawing.Point(118, 50)
        Me.txtAccesionNumBorrow.Name = "txtAccesionNumBorrow"
        Me.txtAccesionNumBorrow.Size = New System.Drawing.Size(176, 25)
        Me.txtAccesionNumBorrow.TabIndex = 17
        '
        'lblAccessionNumBorrow
        '
        Me.lblAccessionNumBorrow.AutoSize = True
        Me.lblAccessionNumBorrow.Location = New System.Drawing.Point(15, 52)
        Me.lblAccessionNumBorrow.Name = "lblAccessionNumBorrow"
        Me.lblAccessionNumBorrow.Size = New System.Drawing.Size(97, 17)
        Me.lblAccessionNumBorrow.TabIndex = 16
        Me.lblAccessionNumBorrow.Text = "Accession No. :"
        '
        'txtbooktype
        '
        Me.txtbooktype.Enabled = False
        Me.txtbooktype.Location = New System.Drawing.Point(118, 210)
        Me.txtbooktype.Name = "txtbooktype"
        Me.txtbooktype.Size = New System.Drawing.Size(250, 25)
        Me.txtbooktype.TabIndex = 14
        '
        'txtpublisher
        '
        Me.txtpublisher.Enabled = False
        Me.txtpublisher.Location = New System.Drawing.Point(118, 179)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(250, 25)
        Me.txtpublisher.TabIndex = 14
        '
        'txtDatePublish
        '
        Me.txtDatePublish.Enabled = False
        Me.txtDatePublish.Location = New System.Drawing.Point(118, 148)
        Me.txtDatePublish.Name = "txtDatePublish"
        Me.txtDatePublish.Size = New System.Drawing.Size(250, 25)
        Me.txtDatePublish.TabIndex = 14
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(118, 84)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(250, 25)
        Me.txtTitle.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Type of Books :"
        '
        'txtAuthor
        '
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Location = New System.Drawing.Point(118, 117)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(250, 25)
        Me.txtAuthor.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Publisher :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Date Publish :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Author :"
        '
        'grp_Bgroup
        '
        Me.grp_Bgroup.Controls.Add(Me.txtBorrowerId)
        Me.grp_Bgroup.Controls.Add(Me.btnSearchBorrower)
        Me.grp_Bgroup.Controls.Add(Me.cboPurpose)
        Me.grp_Bgroup.Controls.Add(Me.txtdue)
        Me.grp_Bgroup.Controls.Add(Me.txtCourse)
        Me.grp_Bgroup.Controls.Add(Me.txtName)
        Me.grp_Bgroup.Controls.Add(Me.Label15)
        Me.grp_Bgroup.Controls.Add(Me.Label13)
        Me.grp_Bgroup.Controls.Add(Me.Label7)
        Me.grp_Bgroup.Controls.Add(Me.Label17)
        Me.grp_Bgroup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Bgroup.Location = New System.Drawing.Point(434, 55)
        Me.grp_Bgroup.Name = "grp_Bgroup"
        Me.grp_Bgroup.Size = New System.Drawing.Size(380, 228)
        Me.grp_Bgroup.TabIndex = 15
        Me.grp_Bgroup.TabStop = False
        Me.grp_Bgroup.Text = "Borrower's"
        '
        'txtBorrowerId
        '
        Me.txtBorrowerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBorrowerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBorrowerId.Location = New System.Drawing.Point(112, 60)
        Me.txtBorrowerId.Name = "txtBorrowerId"
        Me.txtBorrowerId.Size = New System.Drawing.Size(176, 25)
        Me.txtBorrowerId.TabIndex = 24
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.Location = New System.Drawing.Point(293, 60)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(57, 25)
        Me.btnSearchBorrower.TabIndex = 23
        Me.btnSearchBorrower.Text = "Find"
        Me.btnSearchBorrower.UseVisualStyleBackColor = True
        '
        'cboPurpose
        '
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Items.AddRange(New Object() {"Overnight", "Research", "Photocopy"})
        Me.cboPurpose.Location = New System.Drawing.Point(112, 153)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(246, 25)
        Me.cboPurpose.TabIndex = 22
        Me.cboPurpose.Text = "Select"
        '
        'txtdue
        '
        Me.txtdue.Location = New System.Drawing.Point(293, 153)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.Size = New System.Drawing.Size(40, 25)
        Me.txtdue.TabIndex = 18
        '
        'txtCourse
        '
        Me.txtCourse.Enabled = False
        Me.txtCourse.Location = New System.Drawing.Point(112, 122)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(246, 25)
        Me.txtCourse.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(112, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(246, 25)
        Me.txtName.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(43, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Purpose :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Year/Section :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Borrower Id :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(56, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Name :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(831, 413)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Borrowed Books"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txt_Search)
        Me.GroupBox6.Controls.Add(Me.dtg_BlistOfBooks)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(819, 392)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "List Of Borrowed Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search :"
        '
        'txt_Search
        '
        Me.txt_Search.BackColor = System.Drawing.Color.White
        Me.txt_Search.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(507, 24)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(306, 31)
        Me.txt_Search.TabIndex = 1
        '
        'dtg_BlistOfBooks
        '
        Me.dtg_BlistOfBooks.AllowUserToAddRows = False
        Me.dtg_BlistOfBooks.AllowUserToDeleteRows = False
        Me.dtg_BlistOfBooks.AllowUserToResizeColumns = False
        Me.dtg_BlistOfBooks.AllowUserToResizeRows = False
        Me.dtg_BlistOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_BlistOfBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_BlistOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_BlistOfBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_BlistOfBooks.Location = New System.Drawing.Point(6, 61)
        Me.dtg_BlistOfBooks.Name = "dtg_BlistOfBooks"
        Me.dtg_BlistOfBooks.RowHeadersVisible = False
        Me.dtg_BlistOfBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_BlistOfBooks.Size = New System.Drawing.Size(807, 325)
        Me.dtg_BlistOfBooks.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(863, 39)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Borrow Books"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'check_due
        '
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 510)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_Bgroup.ResumeLayout(False)
        Me.grp_Bgroup.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dtg_BlistOfBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Bsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchAccesion As System.Windows.Forms.Button
    Friend WithEvents txtAccesionNumBorrow As System.Windows.Forms.TextBox
    Friend WithEvents lblAccessionNumBorrow As System.Windows.Forms.Label
    Friend WithEvents txtDatePublish As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grp_Bgroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtBorrowerId As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchBorrower As System.Windows.Forms.Button
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdue As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents dtg_BlistOfBooks As System.Windows.Forms.DataGridView
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents check_due As System.Windows.Forms.Timer
    Friend WithEvents txtbooktype As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
