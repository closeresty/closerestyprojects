Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub visibleMenu()
        With Form1
            .btnBooks.Enabled = False
            .btnBorrower.Enabled = False
            .btnUser.Enabled = False
            .btnCategories.Enabled = False
            .btnLogs.Enabled = False
            .btnBorrow.Enabled = False
            .btnOverdue.Enabled = False
            .btnReports.Enabled = False
            .btnReturn.Enabled = False
            .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/lock.jpg")
        End With
    End Sub

    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluser` WHERE User_name= '" & username & "' and Pass = sha1('" & pass & "')")


            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("UserRole") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                    'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                    With Form1
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        .btnUser.Enabled = True
                        .btnCategories.Enabled = True
                        .btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                        .tsLogin.Text = "Logout"

                        .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/unlock.jpg")
                    End With

                 

                    LoginForm1.Close()

                 
                ElseIf dt.Rows(0).Item("UserRole") = "Librarian" Then

                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                    'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                    With Form1
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        .btnUser.Enabled = True
                        .btnCategories.Enabled = True
                        .btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                        .tsLogin.Text = "Logout"
                        .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/unlock.jpg")
                    End With

                   

                    LoginForm1.Close()


 
                ElseIf dt.Rows(0).Item("UserRole") = "Assistant" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                    'With Form1
                    With Form1
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        '.btnUser.Enabled = True
                        '.btnCategories.Enabled = True
                        '.btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                        .tsLogin.Text = "Logout"
                        .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/unlock.jpg")
                    End With

                     
                    LoginForm1.Close()
                End If
               
                Form1.UserIdToolStripStatus.Text = dt.Rows(0).Item("UserId")
                Form1.UserToolStripStatus.Text = dt.Rows(0).Item("Fullname")
                Form1.StatusStrip1.Visible = True
                'inserting logs
                sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " & _
                   " VALUES ('" & dt.Rows(0).Item("UserId") & "',Now(),'Logged in')"
                create(sql)

            Else
                MsgBox("Acount doest not exist!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
