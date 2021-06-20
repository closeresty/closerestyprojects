Public Class frmProgress

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 20 Then
            picShow.Image = My.Resources.wait_icon1
        End If
        If ProgressBar1.Value = 40 Then
            picShow.Image = My.Resources.wait_icon2
        End If
        If ProgressBar1.Value = 60 Then
            picShow.Image = My.Resources.wait_icon1
        End If
        If ProgressBar1.Value = 80 Then
            picShow.Image = My.Resources.wait_icon2
        End If
        If ProgressBar1.Value = 100 Then
            picShow.Image = My.Resources.wait_icon1
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            picShow.Dock = DockStyle.Fill
            picShow.Image = My.Resources.CDM
            picShow.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub frmprogress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
