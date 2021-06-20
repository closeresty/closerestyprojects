Public Class frmBorrow

   
    Private Sub frmBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower', `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_BlistOfBooks)

        check_due.Start()
    End Sub

    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged
        sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower', `DateBorrowed`, `Purpose`, `DueDate` " & _
        " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " & _
        " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND (BookTitle Like '%" & txt_Search.Text & "' or br.AccessionNo Like '%" & txt_Search.Text & "%' OR Concat(`Firstname`,' ', `Lastname`)  Like '%" & txt_Search.Text & "') ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_BlistOfBooks)
    End Sub

    Private Sub btnSearchAccesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAccesion.Click
        With frmListBooks
            .Show()
            .Focus()
            .btnAdd.Visible = True
        End With
    End Sub

    Private Sub txtAccesionNumBorrow_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccesionNumBorrow.TextChanged
        If txtAccesionNumBorrow.Text = "" Then
            txtTitle.Clear()
            txtAuthor.Clear()
            txtDatePublish.Clear()
            txtpublisher.Clear()
            txtbooktype.Clear()
        Else
            sql = "Select * From tblbooks b, tblcategory c WHERE b.CategoryId=c.CategoryId AND AccessionNo='" & txtAccesionNumBorrow.Text & "'"
            reloadtxt(sql)
            '`AccessionNo`, `BookTitle`, `Author`, `PublishDate`, `BookPublisher`, `BookQuantity`
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtTitle.Text = .Item("BookTitle")
                    txtAuthor.Text = .Item("Author")
                    txtDatePublish.Text = .Item("PublishDate")
                    txtpublisher.Text = .Item("BookPublisher")
                    txtbooktype.Text = .Item("BookType")
                End With
            End If
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        cleartext(GroupBox1)
        cleartext(grp_Bgroup)
        sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_BlistOfBooks)
    End Sub

    Private Sub btnSearchBorrower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBorrower.Click
        With frmListBorrower
            .Show()
            .Focus()
            .btnAdd.Visible = True
        End With
    End Sub

    Private Sub txtBorrowerId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBorrowerId.TextChanged
        If txtBorrowerId.Text = "" Then
            txtName.Clear()
            txtCourse.Clear()
        Else
            reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" & txtBorrowerId.Text & "'")

            If dt.Rows.Count > 0 Then
                txtName.Text = dt.Rows(0).Item("Firstname") & " " & dt.Rows(0).Item("Lastname")
                txtCourse.Text = dt.Rows(0).Item("CourseYear")


            Else
                txtName.Clear()
                txtCourse.Clear()
            End If
        End If

    End Sub

    Private Sub btn_Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bsave.Click
        Try
            If txtAccesionNumBorrow.Text = "" Or txtBorrowerId.Text = "" Then
                MsgBox("All fields are required.", MsgBoxStyle.Exclamation)
            ElseIf cboPurpose.Text = "Select" Then
                MsgBox("Pls. choose your porpuse.", MsgBoxStyle.Exclamation)
            Else


                Dim formatdate As Date
                If cboPurpose.Text = "Photocopy" Then
                    formatdate = DateAdd(DateInterval.Minute, 30, Now)
                    txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")

                ElseIf cboPurpose.Text = "Research" Then

                    If Format(Now, "tt") = "AM" Then
                        txtdue.Text = Format(Date.Now().Date, "yyyy-MM-dd") & " 11:30:00"
                    ElseIf Format(Now, "tt") = "PM" Then
                        txtdue.Text = Format(Date.Now().Date, "yyyy-MM-dd") & " 17:30:00"
                    End If

                ElseIf cboPurpose.Text = "Overnight" Then
                    formatdate = DateAdd(DateInterval.Hour, 24, Now)
                    txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")

                    'ElseIf txtbooktype.Text.ToUpper() = "FICTION" Then

                    '    formatdate = DateAdd(DateInterval.Hour, 72, Now)
                    '    txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")


                    'ElseIf txtbooktype.Text.ToUpper() = "NON-FICTION" Then

                    '    formatdate = DateAdd(DateInterval.Hour, 24, Now)
                    '    txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")

                End If


                sql = "INSERT INTO  `tblborrow`  " & _
                " (`AccessionNo`, `NoCopies`, `DateBorrowed`, `Purpose`, `Status`, `DueDate`, `BorrowerId`) " & _
                " VALUES ('" & txtAccesionNumBorrow.Text & "',1,NOW(),'" & cboPurpose.Text & "', 'Borrowed','" & txtdue.Text & "','" & txtBorrowerId.Text & "')"
                result = create(sql)

                If result = True Then
                    MsgBox("Book has been borrowed in the library")
                    updates("UPDATE tblbooks set Status = 'Not Available' Where AccessionNo='" & txtAccesionNumBorrow.Text & "'")
                End If



                ''updates the items copy
                'updates("UPDATE tblbooks set BookQuantity = BookQuantity - '" _
                '    & txtNumBorCopies.Text & "' Where AccessionNo='" & txtAccesionNumBorrow.Text & "'")




                Call btnNew_Click(sender, e)

                'edit("UPDATE borrowers set statistic = statistic + 1  Where borrower_id='" _
                '     & cboBorrowerId.Text & "'")

                'edit("UPDATE replica_items set statistic = statistic + 1  Where accessionNumber='" _
                '    & txtAccesionNumBorrow.Text & "'")

                ''call fisr load to refresh the record
                'Call First_Load(sender, e)
                'cboBorrowerId.Text = ""
                'txtAccesionNumBorrow.Clear()
                ' check_due.Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub check_due_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_due.Tick

        sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId FROM tblborrow Where  Status='Borrowed' AND purpose = 'Photocopy' "
        checkOverduePurposed(sql, "Photocopy")
        sql = "SELECT BorrowId FROM tblborrow Where  Status='Borrowed' AND Purpose = 'Research'"
        checkOverduePurposed(sql, "Research")
        sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'"
        checkOverduePurposed(sql, "Overnight")
        sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'"
        checkOverduePurposed(sql, "Borrowed for 3days")

    End Sub
#Region "numbers only"
    Private Sub txtAccesionNumBorrow_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccesionNumBorrow.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtBorrowerId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBorrowerId.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtNumBorCopies_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub cboPurpose_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPurpose.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtcategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbooktype.TextChanged
        Try
            'If txtbooktype.Text.ToUpper() = "FICTION" Then
            '    cboPurpose.Text = "Borrowed for 3days"
            '    cboPurpose.Enabled = False

            'ElseIf txtbooktype.Text.ToUpper() = "NON-FICTION" Then
            '    cboPurpose.Text = "Overnight"
            '    cboPurpose.Enabled = False
            'Else
            '    cboPurpose.Enabled = True
            '    cboPurpose.Text = "Select"

            'End If
        Catch ex As Exception

        End Try
    End Sub
End Class