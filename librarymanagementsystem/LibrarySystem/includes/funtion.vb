
Imports MySql.Data.MySqlClient
Module funtion
    Public con As MySqlConnection = mysqldb()
    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
    End Sub


    Public Sub getallforms()
        Try
 

            For Each f As Form In My.Application.OpenForms
                Select Case f.Name
                    Case "frm_Login"
                        'frm_Login.Show()
                    Case Else
                        f.Hide()
                End Select

            Next
        Catch ex As Exception

        End Try

        'For Each t As Type In sender.GetType().Assembly.GetTypes()
        '    If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then

        '        MsgBox(t.Name)

        '    End If
        'Next
    End Sub

    Public Sub cbo_fill(ByVal cbo As ComboBox, ByVal member As String, ByVal id As String, ByVal table As String)

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "Select * From " & table
            End With

            da = New MySqlDataAdapter("Select * From " & table, con)
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)
            With cbo
                .DataSource = dt
                .ValueMember = id
                .DisplayMember = member
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        'da.Dispose()

    End Sub

    Public Sub emptymessage()
        MsgBox("There are empty fields left that must be filled up!", MsgBoxStyle.Exclamation)
    End Sub
 
 
    Public inc As Integer = 0
    Public maxrows As Integer

    Public Sub select_navigation(ByVal sql As String)
        Try
            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                dt = New DataTable
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                maxrows = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message & "select_navigation")
            End Try

            con.Close()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub navagate_records(ByVal txt As Object)
        Try
            txt.text = dt.Rows(inc).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Public Sub auto_suggest(ByVal member As String, ByVal table As String, ByVal txt As Object)
    '    Try
    '        reload("select  " & member & " from  " & table)
    '        filltxtshow()

    '        Dim r As DataRow
    '        txt.AutoCompleteCustomSource.Clear()

    '        For Each r In dt.Rows
    '            txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)

    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Public Sub query(ByVal member As String, ByVal table As String, ByVal dtg As Object)
    '    Try
    '        reload("SELECT " & member & " FROM " & table)
    '        filltable(dtg)

    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Sub validation(ByVal frm As Object)
        Try
            For Each txt As Control In frm.Controls

                If txt.GetType Is GetType(TextBox) Then
                    If txt.Text = "" Then
                        MsgBox("One of the box is empty, you filled out!")
                    Else
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  
    Public Sub ErrorMessage(ByVal lbl As Label, ByVal message As String, ByVal btn As Button)
        lbl.BackColor = Color.Red
        lbl.ForeColor = Color.White
        lbl.Text = message
        btn.Enabled = False
    End Sub
    Public Sub ClearErrorMessage(ByVal lbl As Label, ByVal btn As Button)
        lbl.BackColor = Color.Transparent
        lbl.Text = ""
        btn.Enabled = True
    End Sub
    'declarations
    Dim day As String = Format(Today, "dddd") 'string format of days
    Dim hoursinterval As Integer
    Dim retrievtime As Date 'date borrowed 
    Dim convertedtimeH As Integer    'hour borrowed 
    Dim convertedtimeM As Integer   'minute borrowed 


    Dim time As Date 'current date
    Dim CurrHour As Integer ' current hour
    Dim CurrMinute As Integer 'current minute

    Public Sub checkOverduePurposed(ByVal sql As String, ByVal choiceofporpuse As String)

        Try
            'for retriving the data
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Dim id As Integer = row.Item(1)
                Select Case day
                    Case "Monday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select

                    Case "Tuesday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select

                    Case "Wednesday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"


                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select

                    Case "Thursday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select

                    Case "Friday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select

                    Case "Saturday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select
                    Case "Sunday"
                        Select Case choiceofporpuse
                            Case "Research"
                                timeOfresearch(id)
                            Case "Photocopy"
                                timeOfPhotocopy(id, row.Item(0))
                            Case "Overnight"

                                ' MsgBox("Overnight")
                                timeOfOvernight(id, row.Item(0))
                            Case "Borrowed for 3days"

                                ' MsgBox("Overnight")
                                timeOfthreeDays(id, row.Item(0))
                        End Select
                End Select
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
       
    End Sub
    Public Sub timeOfresearch(ByVal id As Integer)



        If Format(Now, "tt") = "AM" Then
            Dim checktime As Integer = DatePart("h", Now) & Format(Now, "mm")
            If checktime <= 830 Or checktime >= 1130 Then
                ' MsgBox(Format(Date.Now().Date, "yyyy-MM-dd") & " 11:30:00")
                sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
                & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
                updates(sql)
            End If

        ElseIf Format(Now, "tt") = "PM" Then
            Dim checktime As Integer = DatePart("h", Now) & DatePart("n", Now)
            If checktime <= 1330 Or checktime >= 1730 Then
                sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
                 & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
                updates(sql)
            End If

        End If
        'If retrievtime >= 24 Then
        '    sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
        '    & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
        '    updates(sql)
        '    Return
        'End If
    End Sub
    Public Sub timeOfPhotocopy(ByVal id As Integer, ByVal retrievtime As Integer)

        If retrievtime >= 30 Then
            'sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose` ='Photocopy' and borrow_id in ('" & id & "')"
            'updates(sql)
            sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
               & " WHERE Status='Borrowed' AND `Purpose` ='Photocopy' and BorrowId='" & id & "'"
            updates(sql)
            Return

        End If
    End Sub
    Public Sub timeOfOvernight(ByVal id As Integer, ByVal hoursinterval As Integer)
        If hoursinterval >= 24 Then
            'sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose`='Overnight' and borrow_id in ('" & id & "')"
            'updates(sql)
            sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
             & " WHERE Status='Borrowed' AND `Purpose` ='Overnight' and BorrowId='" & id & "'"
            updates(sql)
            Return
        End If
    End Sub
    Public Sub timeOfthreeDays(ByVal id As Integer, ByVal hoursinterval As Integer)
        If hoursinterval >= 73 Then
            'sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose`='Overnight' and borrow_id in ('" & id & "')"
            'updates(sql)
            sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
             & " WHERE Status='Borrowed' AND `Purpose` ='Borrowed for 3days' and BorrowId='" & id & "'"
            updates(sql)
            Return
        End If
    End Sub
    Public Sub formClose()
        frmBooks.Close()
        frmBorrow.Close()
        frmBorrower.Close()
        frmCategory.Close()
        frmListBooks.Close()
        frmListBorrower.Close()
        frmPayments.Close()
        frmReport.Close()
        frmReturn.Close()
        frmUser.Close()

    End Sub
    'Public Sub formulaofpayments(ByVal frm As frmPayments)
    '    Try
    '        Dim totaltime As Integer
    '        Dim ts As TimeSpan = TimeSpan.Parse(frm.txtOverdueTime.Text)
    '        Dim TValueMin As Integer = ts.Minutes.ToString
    '        Dim tValueHour As Integer = 60 * ts.Hours.ToString
    '        Dim condays As Integer = 24 * ts.Days.ToString

    '        totaltime = condays + tValueHour + TValueMin
    '        totaltime = totaltime / Val(frm.txtminutes.Text)
    '        frm.txtTotPay.Text = totaltime * Val(frm.txtamount.Text)

    '    Catch ex As Exception
    '        'MsgBox(ex.Message & "lbl_Rduedate_Click")
    '    End Try
    'End Sub
    Public Sub formulaofpayments()
        Try
            Dim totalhours As Integer 
            Dim ts As TimeSpan = TimeSpan.Parse(frmPayments.txtOverdueTime.Text)
            'Dim TValueMin As Integer = ts.Minutes.ToString
            Dim tValueHour As Integer = ts.Hours.ToString
            Dim condays As Integer = 24 * ts.Days.ToString

            totalhours = condays + tValueHour
            totalhours = totalhours / Val(frmPayments.txthours.Text)
            frmPayments.txtTotPay.Text = totalhours * Val(frmPayments.txtamount.Text)

        Catch ex As Exception
            'MsgBox(ex.Message & "lbl_Rduedate_Click")
        End Try
    End Sub
    Public Sub columnInvisible(ByVal dtg As DataGridView)
        Dim c As DataGridViewColumn
        For Each c In dtg.Columns

        Next

    End Sub
End Module
