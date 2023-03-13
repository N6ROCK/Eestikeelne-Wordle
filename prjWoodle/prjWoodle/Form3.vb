Public Class Form3
    Public Kesk As Color
    Public Parem As Color
    Public Vasak As Color
    Dim cl As Color = Color.FromArgb(0, 0, 0, 0)
    Private Sub CBAjaliimit_CheckedChanged(sender As Object, e As EventArgs) Handles CBAjaliimit.CheckedChanged
        TxtAjaliimit.Enabled = CBAjaliimit.Checked
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If CBAjaliimit.Checked = True Then
            If Kesk.ToArgb = Vasak.ToArgb Or Kesk.ToArgb = Parem.ToArgb Or Vasak.ToArgb = Parem.ToArgb Then
                LblError.Text = "Palun valige erinevad värvid"
            ElseIf IsNumeric(TxtAjaliimit.Text) And (Kesk.ToArgb = cl.ToArgb Or Parem.ToArgb = cl.ToArgb Or Vasak.ToArgb = cl.ToArgb) Then
                LblError.Text = "Palun valige värvid"
            ElseIf (Not (IsNumeric(TxtAjaliimit.Text)) Or CInt(TxtAjaliimit.Text) < 0 Or CInt(TxtAjaliimit.Text) > 60) And (Kesk.ToArgb <> cl.ToArgb Or Parem.ToArgb <> cl.ToArgb Or Vasak.ToArgb <> cl.ToArgb) Then
                TxtAjaliimit.Text = "Sisesta arv"
            ElseIf IsNumeric(TxtAjaliimit.Text) And (Kesk.ToArgb <> cl.ToArgb Or Parem.ToArgb <> cl.ToArgb Or Vasak.ToArgb <> cl.ToArgb) Then
                FGamewordle.timerAjaliimit.Interval = TxtAjaliimit.Text * 60000
                FGamewordle.timerAjaliimit.Enabled = True
                Me.Hide()
                FGamewordle.Show()
            Else
                TxtAjaliimit.Text = "Sisesta arv"
                LblError.Text = "Palun valige värvid"
            End If
        Else
            If Kesk.ToArgb = cl.ToArgb Or Parem.ToArgb = cl.ToArgb Or Vasak.ToArgb = cl.ToArgb Then
                LblError.Text = "Palun valige värvid"
            ElseIf Kesk.ToArgb = Vasak.ToArgb Or Kesk.ToArgb = Parem.ToArgb Or Vasak.ToArgb = Parem.ToArgb Then
                LblError.Text = "Palun valige erinevad värvid"
            Else
                Me.Hide()
                FGamewordle.Show()
            End If
        End If
    End Sub

    Private Sub CbCentre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCentre.SelectedIndexChanged
        If CbCentre.Text = "Punane" Then
            Kesk = Color.Red
        ElseIf CbCentre.Text = "Oranž" Then
            Kesk = Color.Orange
        ElseIf CbCentre.Text = "Kollane" Then
            Kesk = Color.Yellow
        ElseIf CbCentre.Text = "Roheline" Then
            Kesk = Color.Green
        ElseIf CbCentre.Text = "Sinine" Then
            Kesk = Color.Blue
        ElseIf CbCentre.Text = "Violetne" Then
            Kesk = Color.Violet
        ElseIf CbCentre.Text = "Roosa" Then
            Kesk = Color.Pink
        ElseIf CbCentre.Text = "Pruun" Then
            Kesk = Color.Brown
        End If
    End Sub

    Private Sub CbLeft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLeft.SelectedIndexChanged
        If CbLeft.Text = "Punane" Then
            Vasak = Color.Red
        ElseIf CbLeft.Text = "Oranž" Then
            Vasak = Color.Orange
        ElseIf CbLeft.Text = "Kollane" Then
            Vasak = Color.Yellow
        ElseIf CbLeft.Text = "Roheline" Then
            Vasak = Color.Green
        ElseIf CbLeft.Text = "Sinine" Then
            Vasak = Color.Blue
        ElseIf CbLeft.Text = "Violetne" Then
            Vasak = Color.Violet
        ElseIf CbLeft.Text = "Roosa" Then
            Vasak = Color.Pink
        ElseIf CbLeft.Text = "Pruun" Then
            Vasak = Color.Brown
        End If
    End Sub

    Private Sub CbRight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRight.SelectedIndexChanged
        If CbRight.Text = "Punane" Then
            Parem = Color.Red
        ElseIf CbRight.Text = "Oranž" Then
            Parem = Color.Orange
        ElseIf CbRight.Text = "Kollane" Then
            Parem = Color.Yellow
        ElseIf CbRight.Text = "Roheline" Then
            Parem = Color.Green
        ElseIf CbRight.Text = "Sinine" Then
            Parem = Color.Blue
        ElseIf CbRight.Text = "Violetne" Then
            Parem = Color.Violet
        ElseIf CbRight.Text = "Roosa" Then
            Parem = Color.Pink
        ElseIf CbRight.Text = "Pruun" Then
            Parem = Color.Brown
        End If
    End Sub
End Class