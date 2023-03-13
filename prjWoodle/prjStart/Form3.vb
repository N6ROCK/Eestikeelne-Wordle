Public Class Form3
    Private Sub CBAjaliimit_CheckedChanged(sender As Object, e As EventArgs) Handles CBAjaliimit.CheckedChanged
        TxtAjaliimit.Enabled = True
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If CBAjaliimit.Checked = True Then
            If IsNumeric(TxtAjaliimit.Text) Then
                FGamewordle.timerAjaliimit.Interval = TxtAjaliimit.Text * 60000
                FGamewordle.timerAjaliimit.Enabled = True
                Me.Close()
                FGamewordle.Show()
            Else
                TxtAjaliimit.Text = "Sisesta arv"
            End If
        Else
            Me.Close()
            FGamewordle.Show()
        End If
    End Sub
End Class