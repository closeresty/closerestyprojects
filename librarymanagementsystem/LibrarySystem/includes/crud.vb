Imports MySql.Data.MySqlClient
Module crud  
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Public result As String
    Public sqladd As String
    Public sqledit As String
#Region "old crud"
    Function save_or_update(ByVal sql As String, ByVal add As String, ByVal edit As String, ByVal msgedit As String, ByVal msgadd As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With cmd
                    .Connection = con
                    .CommandText = edit
                    result = cmd.ExecuteNonQuery 
                End With
                If result > 0 Then
                    MsgBox(msgedit)
                End If
            Else
                With cmd
                    .Connection = con
                    .CommandText = add
                    result = cmd.ExecuteNonQuery 
                End With
                If result > 0 Then
                    MsgBox(msgadd) 

                End If
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Function

    Public Sub createNoMsg(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                cmd.ExecuteNonQuery()
               
            End With
            con.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message & "createNoMsg")
        End Try

    End Sub
    Function create(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery

            End With

        Catch ex As Exception
            '  MsgBox(ex.Message & " create")
        Finally 
            con.Close()
        End Try

        Return result
    End Function
    Public Sub reloadDtg(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        End Try

        con.Close()
        da.Dispose()
    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

        Catch ex As Exception
            '   MsgBox(ex.Message & "reloadtxt")
        Finally

            con.Close()
            da.Dispose()

        End Try
    End Sub
    Function updates(ByVal sql As String)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                'If result = 0 Then
                '    MsgBox("No updated data", MsgBoxStyle.Information)
                'Else
                '    MsgBox("Data in the database has been updated")
                'End If
            End With
            con.Close()
        Catch ex As Exception
            '   MsgBox(ex.Message & "updates")
        End Try
        Return result
    End Function
    Function deletes(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            'If MessageBox.Show("Do you want to delete this rocord?", "Delete" _
            '                     , MessageBoxButtons.YesNo, MessageBoxIcon.Information) _
            '                     = Windows.Forms.DialogResult.Yes Then
            result = cmd.ExecuteNonQuery
         
            'End If
            con.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Return result
    End Function

#End Region

#Region "Report"
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\report\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        End Try
        con.Close()
        da.Dispose()
    End Sub
#End Region
End Module


