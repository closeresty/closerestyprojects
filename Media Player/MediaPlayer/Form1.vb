Public Class frmMediaPlayer

    Private Sub btnAddPlayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlayList.Click
        OpenFileDialog1.ShowDialog()
        lstPlayList.Items.Add(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.URL = lstPlayList.SelectedItem
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            lstPlayList.SelectedIndex += +1
            AxWindowsMediaPlayer1.URL = lstPlayList.SelectedItem
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("No more song in the list", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Try
            lstPlayList.SelectedIndex += -1
            AxWindowsMediaPlayer1.URL = lstPlayList.SelectedItem
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("No more song in the list", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub
End Class
