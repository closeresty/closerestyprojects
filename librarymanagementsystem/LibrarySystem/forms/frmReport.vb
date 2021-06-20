Public Class frmReport

    Private Sub btnListBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListBooks.Click
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, `BookPrice` as 'Price', `BookQuantity` as 'No.Copies', `Status`,`OverAllQty` FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`"
        reports(sql, "ListofBooks", CrystalReportViewer1)
        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub btn_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click

        Select Case cboStatus.Text
            Case "Borrowed"

                sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  DATE(DateBorrowed) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "'"
                reports(sql, "DateFilterBorrowed", CrystalReportViewer1)
            Case "Returned"
                sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND  DATE(DateReturned) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "' "
                reports(sql, "DateFilterReturned", CrystalReportViewer1)
            Case "Overdue"
                sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue'  AND DATE(DueDate) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "'"
                reports(sql, "DateFilterDue", CrystalReportViewer1)

        End Select


        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub rdoDaily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDaily.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  Date(`DateBorrowed`) = CURDATE() "
                    reports(sql, "DailyBorrowed", CrystalReportViewer1)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND Date(`DateReturned`) = CURDATE() "
                    reports(sql, "DailyReturned", CrystalReportViewer1)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue'  AND Date(`DueDate`) = CURDATE() "
                    reports(sql, "DailyDue", CrystalReportViewer1)

            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoWeekly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWeekly.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  DAYOFWEEK(  `DateBorrowed` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DateBorrowed) = MONTH(Now())"
                    reports(sql, "WeeklyBorrowed", CrystalReportViewer1)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND DAYOFWEEK(  `DateReturned` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DateReturned) = MONTH(Now())"
                    reports(sql, "WeeklyReturned", CrystalReportViewer1)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue' AND DAYOFWEEK(  `DueDate` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DueDate) = MONTH(Now())"
                    reports(sql, "WeeklyDue", CrystalReportViewer1)
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoMonthly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMonthly.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND MONTH(DateBorrowed) = MONTH(Now())"
                    reports(sql, "MonthlyBorrowed", CrystalReportViewer1)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND MONTH(DateReturned) = MONTH(Now())"
                    reports(sql, "MonthlyReturned", CrystalReportViewer1)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue' AND  MONTH(DueDate) = MONTH(Now())"
                    reports(sql, "MonthlyDue", CrystalReportViewer1)
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnTotalbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalbooks.Click
        sql = "SELECT * FROM `tblbooknumber`"
        reports(sql, "NumberofBooks", CrystalReportViewer1)
    End Sub
End Class