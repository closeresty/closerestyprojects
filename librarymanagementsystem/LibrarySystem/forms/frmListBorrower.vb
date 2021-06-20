Public Class frmListBorrower

    Private Sub frmListBorrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` "
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` WHERE BorrowerId Like '%" & txtSearch.Text & "%' OR `Firstname` Like '%" & txtSearch.Text & "%'  OR  `Lastname` Like '%" & txtSearch.Text & "%' OR  BorrowerId Like '%" & txtSearch.Text & "%'"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            frmBorrow.txtBorrowerId.Text = dtgList.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class