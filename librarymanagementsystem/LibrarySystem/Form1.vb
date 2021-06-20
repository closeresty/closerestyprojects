Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        visibleMenu()
        Timer1.Start()
    End Sub
    'Public Sub frmclose()
    '    frmBooks.Close()
    '    frmBorrower.Close()
    '    frmUser.Close()
    '    frmCategory.Close()
    '    'frmBorrow.Close()
    '    'frmReturn.Close()
    '    'frmPayments.Close()
    '    'frmListBooks.Close()
    '    'frmListBorrower.Close()
    '    'frmReport.Close()
    'End Sub
    Dim blneCancel As Boolean = False
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Select Case ((m.WParam.ToInt64() And &HFFFF) And &HFFF0)

            Case &HF060 ' The user chose to close the form.



                ' Alert the user.
                '----------------
                'If MessageBox.Show("Logout first before you close the form" & vbCrLf & vbCrLf & _
                '                   "ARE YOU SURE YOU WANT TO DO THIS?" & vbCrLf & vbCrLf, _
                '                   "*** W A R N I N G ***", _
                '                   MessageBoxButtons.YesNo, _
                '                   MessageBoxIcon.Warning, _
                '                   MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '    Me.Close()

                'Else
                '    ' Reset validation.
                '    '------------------
                '    Me.CausesValidation = True
                '    blneCancel = True
                'End If

                If tsLogin.Text = "Logout" Then
                    MsgBox("Logout first before you close the form.", MsgBoxStyle.Information)
                    Me.CausesValidation = True
                    blneCancel = True
                Else
                    Me.CausesValidation = False
                    blneCancel = False
                End If

        End Select

        MyBase.WndProc(m)
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If blneCancel = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = "Time : " & Format(Now(), "H:mm:ss")
        lblDate.Text = "Date : " & Format(Now(), "MM/dd/yyyy")


        Dim ampm As String = Format(Now, "tt")
        Dim checkdate As Integer
        Dim checkmin As String = DatePart("n", Now)
        Dim checkhour As String = DatePart("h", Now)

        If checkmin < 10 Then
            checkmin = 0 & checkmin
        End If

        checkdate = checkhour & checkmin


        Try


            'Select Case ampm
            '    Case "AM"
            '        If checkdate >= 830 And checkdate <= 1130 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If
            '    Case "PM"
            '        If checkdate >= 1330 And checkdate <= 1730 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If

            'End Select



        Catch ex As Exception

        End Try
    End Sub


    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmReport
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            LoginForm1.Show()
            LoginForm1.Focus()

        Else
            tsLogin.Text = "Login"
            visibleMenu()
            sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
               " VALUES ('" & UserIdToolStripStatus.Text & "',Now(),'Logged out')"
            create(sql)

            UserIdToolStripStatus.Text = ""
            UserToolStripStatus.Text = ""
            formClose()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmReturn
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmPayments
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        With frmBooks
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBorrower_Click(sender As Object, e As EventArgs) Handles btnBorrower.Click
        With frmBorrower
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        With frmCategory
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        With frmBorrow
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        With frmReturn
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnOverdue_Click(sender As Object, e As EventArgs) Handles btnOverdue.Click
        With frmPayments
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        With frmReport
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        With frmUserlogs
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        With frmListofBooks
            .Show()
            .Focus()
        End With
    End Sub
End Class
