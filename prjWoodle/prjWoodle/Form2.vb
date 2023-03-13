Public Class FGameover
    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        Dim f1 = New FGamewordle
        If BtnRestart.Text = "Restart" Then
            Me.Hide()
            f1.Show()
        ElseIf BtnRestart.Text = "Ok" Then
            Me.Close()
            f1.Close()
        End If
    End Sub


End Class