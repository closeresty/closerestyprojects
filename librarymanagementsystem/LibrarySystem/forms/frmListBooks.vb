Public Class frmListBooks

    Private Sub frmListBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks', `BookPrice` as 'Price', DeweyDecimal " & _
        ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub txtSerach_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks', `BookPrice` as 'Price', DeweyDecimal " & _
         ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If dtgList.CurrentRow.Cells(10).Value = "Available" Then
                frmBorrow.txtAccesionNumBorrow.Text = dtgList.CurrentRow.Cells(0).Value
                Me.Close()
            Else
                MsgBox("The book is already borrowed.", MsgBoxStyle.Exclamation)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class