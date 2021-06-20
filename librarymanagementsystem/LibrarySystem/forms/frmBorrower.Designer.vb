<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrower
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
        Me.txt_bid = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.rch_address = New System.Windows.Forms.RichTextBox()
        Me.rdio_male = New System.Windows.Forms.RadioButton()
        Me.rdio_female = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtg_ABorrowLists = New System.Windows.Forms.DataGridView()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bid
        '
        Me.txt_bid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bid.Location = New System.Drawing.Point(122, 54)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.Size = New System.Drawing.Size(357, 25)
        Me.txt_bid.TabIndex = 1
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(122, 87)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(357, 25)
        Me.txt_fname.TabIndex = 2
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(122, 145)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(357, 25)
        Me.txt_mname.TabIndex = 4
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(122, 117)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(357, 25)
        Me.txt_lname.TabIndex = 3
        '
        'rch_address
        '
        Me.rch_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_address.Location = New System.Drawing.Point(122, 173)
        Me.rch_address.Name = "rch_address"
        Me.rch_address.Size = New System.Drawing.Size(357, 58)
        Me.rch_address.TabIndex = 5
        Me.rch_address.Text = ""
        '
        'rdio_male
        '
        Me.rdio_male.AutoSize = True
        Me.rdio_male.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_male.Location = New System.Drawing.Point(129, 237)
        Me.rdio_male.Name = "rdio_male"
        Me.rdio_male.Size = New System.Drawing.Size(55, 21)
        Me.rdio_male.TabIndex = 9
        Me.rdio_male.TabStop = True
        Me.rdio_male.Text = "Male"
        Me.rdio_male.UseVisualStyleBackColor = True
        '
        'rdio_female
        '
        Me.rdio_female.AutoSize = True
        Me.rdio_female.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_female.Location = New System.Drawing.Point(191, 237)
        Me.rdio_female.Name = "rdio_female"
        Me.rdio_female.Size = New System.Drawing.Size(67, 21)
        Me.rdio_female.TabIndex = 10
        Me.rdio_female.TabStop = True
        Me.rdio_female.Text = "Female"
        Me.rdio_female.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sex :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Middle Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Borrower Id :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(604, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'dtg_ABorrowLists
        '
        Me.dtg_ABorrowLists.AllowUserToAddRows = False
        Me.dtg_ABorrowLists.AllowUserToDeleteRows = False
        Me.dtg_ABorrowLists.AllowUserToResizeColumns = False
        Me.dtg_ABorrowLists.AllowUserToResizeRows = False
        Me.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_ABorrowLists.Location = New System.Drawing.Point(7, 318)
        Me.dtg_ABorrowLists.Name = "dtg_ABorrowLists"
        Me.dtg_ABorrowLists.RowHeadersVisible = False
        Me.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_ABorrowLists.Size = New System.Drawing.Size(846, 193)
        Me.dtg_ABorrowLists.TabIndex = 12
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(602, 197)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(216, 25)
        Me.txtCourse.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Course/Year :"
        '
        'btn_last
        '
        Me.btn_last.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(775, 277)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(51, 24)
        Me.btn_last.TabIndex = 27
        Me.btn_last.Text = ">>|"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(718, 277)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(51, 24)
        Me.btn_next.TabIndex = 26
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(583, 245)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(64, 26)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(718, 245)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(68, 26)
        Me.btn_New.TabIndex = 24
        Me.btn_New.Text = "Clear"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(604, 277)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(51, 24)
        Me.btn_first.TabIndex = 28
        Me.btn_first.Text = "|<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(650, 245)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(68, 26)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(584, 245)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 26)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Location = New System.Drawing.Point(661, 277)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(51, 24)
        Me.btn_prev.TabIndex = 25
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact No. : "
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(122, 262)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(357, 25)
        Me.txtContact.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(785, 245)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(606, 92)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(209, 20)
        Me.txtPhoto.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(863, 39)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Borrower"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(650, 246)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(68, 26)
        Me.btnDisable.TabIndex = 33
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnCard
        '
        Me.btnCard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.Location = New System.Drawing.Point(512, 245)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(66, 56)
        Me.btnCard.TabIndex = 34
        Me.btnCard.Text = "Print Card"
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 523)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtg_ABorrowLists)
        Me.Controls.Add(Me.txt_bid)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.rdio_female)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rch_address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdio_male)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.btnDisable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_bid As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents rch_address As System.Windows.Forms.RichTextBox
    Friend WithEvents rdio_male As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_female As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtg_ABorrowLists As System.Windows.Forms.DataGridView
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPhoto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents btnCard As Button
End Class
