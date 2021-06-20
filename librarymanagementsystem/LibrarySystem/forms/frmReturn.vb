Public Class frmReturn

    Private Sub frmReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " & _
        " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " & _
        " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_RlistReturn)
        dtg_RlistReturn.Columns(5).Visible = False
        dtg_RlistReturn.Columns(6).Visible = False


        sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`, `DateReturned` " & _
        " FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b " & _
        " WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' ORDER BY ReturnId Desc"
        reloadDtg(sql, dtgListreturned)




    End Sub

    Private Sub dtg_RlistReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_RlistReturn.Click
        Try
            sql = "SELECT *  " & _
            " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " & _
            " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND BorrowId=" & dtg_RlistReturn.CurrentRow.Cells(5).Value
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtRname.Text = .Item("Firstname") & " " & .Item("Lastname")
                    txtRbookTitle.Text = .Item("BookTitle")
                    txtRdescription.Text = .Item("BookDesc")
                    txtRauthor.Text = .Item("Author") 

                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearchPborrower_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPborrower.TextChanged
    
        sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " & _
        " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " & _
        " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" & txtSearchPborrower.Text & "%' ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_RlistReturn)
        dtg_RlistReturn.Columns(5).Visible = False
        dtg_RlistReturn.Columns(6).Visible = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn_Rsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rsave.Click

        If txtRname.Text = "" Then
            MsgBox("There is no borrower in the fields.", MsgBoxStyle.Exclamation)
            'ElseIf Val(txtRRqty.Text) < Val(txtRCopyBorrowed.Text) Then
            '    MsgBox("The return quantity is less than the number of the books that you had borrow.", MsgBoxStyle.Exclamation)
            'ElseIf Val(txtRRqty.Text) > Val(txtRCopyBorrowed.Text) Then
            '    MsgBox("The return quantity is greater than the number of the books that you had borrow.", MsgBoxStyle.Exclamation)
        Else 
            sql = "INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" & _
                  " VALUES (" & dtg_RlistReturn.CurrentRow.Cells(5).Value & ",1,NOW(),'Returned')"

            result = create(sql)
            If result = True Then

                sql = "UPDATE `tblborrow` SET  `Status` =  'Returned',`Remarks`='On Time' WHERE `BorrowId` = '" & dtg_RlistReturn.CurrentRow.Cells(5).Value & "'"
                updates(sql)

                'sql = "UPDATE  `tblbooks` SET  `BookQuantity` = `BookQuantity` + " & txtRCopyBorrowed.Text & " WHERE  `AccessionNo` = " & dtg_RlistReturn.CurrentRow.Cells(7).Value
                'updates(sql)

                sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" & dtg_RlistReturn.CurrentRow.Cells(6).Value & "'"
                updates(sql)


                MsgBox("Book has been returned in the library.")


                Call frmReturn_Load(sender, e)

                
                cleartext(grp_Rgroup)
            End If
        End If
      
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " & _
        " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " & _
        " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" & txtSearchPborrower.Text & "%' ORDER BY BorrowId Desc"
        reloadDtg(sql, dtg_RlistReturn)
        dtg_RlistReturn.Columns(5).Visible = False
        dtg_RlistReturn.Columns(6).Visible = False

        cleartext(grp_Rgroup)
    End Sub

    Private Sub txtrbooksSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrbooksSearch.TextChanged
        sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,`DateReturned` " & _
        " FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b " & _
        " WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned'" & _
        " AND  (bw.`BorrowerId` Like '%" & txtrbooksSearch.Text & "%' OR b.`AccessionNo` Like '%" & txtrbooksSearch.Text & _
        "%' OR  `Firstname` Like '%" & txtrbooksSearch.Text & "%' OR Lastname Like '%" & txtrbooksSearch.Text & _
        "%' OR BookTitle Like '%" & txtrbooksSearch.Text & "%') ORDER BY ReturnId Desc"
        reloadDtg(sql, dtgListreturned)
    End Sub

    Private Sub check_due_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_due.Tick

        sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId FROM tblborrow Where  Status='Borrowed' AND purpose = 'Photocopy' "
        checkOverduePurposed(sql, "Photocopy")
        sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId,DateBorrowed FROM tblborrow Where  Status='Borrowed' AND Purpose = 'Research'"
        checkOverduePurposed(sql, "Research")
        sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'"
        checkOverduePurposed(sql, "Overnight")
        sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Borrowed for 3days'"
        checkOverduePurposed(sql, "Borrowed for 3days")
    End Sub
 
#Region "numbers only"
    Private Sub txtSearchPborrower_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPborrower.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtRRqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRRqty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub 
#End Region 
End Class