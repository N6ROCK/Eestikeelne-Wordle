Public Class FGamewordle
    Dim i As Integer
    Dim j As Integer
    Dim Word(4) As Char
    Dim Rnd As New Random
    Dim Answer(4) As Char
    Dim Textboxs(5, 4) As TextBox
   

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        If i > 4 Then
            Vordlus(Word)
            Array.Clear(Word, 0, Word.Length)
            i = 0
            j = j + 1
            If j < 5 Then
                Textboxs(j, i).Focus()
            End If
        End If
    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles BtnBackspace.Click
        If i > 0 Then
            i = i - 1
            Textboxs(j, i).Text = Textboxs(j, i).Text.Substring(0, Textboxs(j, i).Text.Length - 1)
        End If
    End Sub

    Private Sub txtchar12_TextChanged(sender As Object, e As EventArgs) _
        Handles txtChar65.TextChanged, txtChar64.TextChanged, txtChar63.TextChanged,
        txtChar62.TextChanged, txtChar61.TextChanged, txtChar55.TextChanged,
        txtChar54.TextChanged, txtChar53.TextChanged, txtChar52.TextChanged,
        txtChar51.TextChanged, txtChar45.TextChanged, txtChar44.TextChanged,
        txtChar43.TextChanged, txtChar42.TextChanged, txtChar41.TextChanged,
        txtChar35.TextChanged, txtChar34.TextChanged, txtChar33.TextChanged,
        txtChar32.TextChanged, txtChar31.TextChanged, txtChar25.TextChanged,
        txtChar24.TextChanged, txtChar23.TextChanged, txtChar22.TextChanged,
        txtChar21.TextChanged, txtChar15.TextChanged, txtChar14.TextChanged,
        txtChar13.TextChanged, txtChar12.TextChanged, txtChar11.TextChanged

        Textboxs(j, i).Focus()
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) _
        Handles BtnZ.Click, BtnY.Click, BtnX.Click, BtnW.Click,
        BtnV.Click, BtnÜ.Click, BtnU.Click, BtnT.Click, BtnS.Click,
        BtnR.Click, BtnQ.Click, BtnP.Click, BtnÕ.Click, BtnÖ.Click,
        BtnO.Click, BtnN.Click, BtnM.Click, BtnL.Click, BtnK.Click,
        BtnJ.Click, BtnI.Click, BtnH.Click, BtnG.Click, BtnF.Click,
        BtnE.Click, BtnD.Click, BtnC.Click, BtnB.Click, BtnÄ.Click,
        BtnA.Click
        Dim slovo As PrjSonad.ISona
        Dim KontrolliSona As String
        slovo = New PrjSonad.CFail
        If i = 0 And j = 0 And KontrolliSona Is Nothing Then
            slovo.num = Rnd.Next(0, 220)
            slovo.FileNum = FreeFile()
            KontrolliSona = slovo.DaiSukaSlovo
            kontroll(KontrolliSona)
        End If

        If i >= 0 And i <= 4 And j >= 0 And j <= 5 Then
            Word(i) = Replace(sender.name, "Btn", "")
            Textboxs(j, i).Text = Replace(sender.name, "Btn", "")
            i = i + 1
        End If
    End Sub

    Function kontroll(ByVal KontrolliSona As String)
        Dim k As Integer
        Dim l As Integer
        Dim Kontrolli() As Char = KontrolliSona.ToCharArray
        Do Until k > 4
            Do Until l = Len(KontrolliSona)
                If Kontrolli(l) = "Г" Then
                    If Kontrolli(l + 1) = "µ" Then
                        Answer(k) = "õ"
                        l = l + 2
                    ElseIf Kontrolli(l + 1) = "¤" Then
                        Answer(k) = "ä"
                        l = l + 2
                    ElseIf Kontrolli(l + 1) = "¶" Then
                        Answer(k) = "ö"
                        l = l + 2
                    ElseIf Kontrolli(l + 1) = "ј" Then
                        Answer(k) = "ü"
                        l = l + 2
                    End If
                Else
                    Answer(k) = Kontrolli(l)
                    l = l + 1
                End If
                k = k + 1
            Loop
        Loop
        Return Answer
    End Function

    Function Vordlus(ByVal Word() As Char)
        'Dim Answerchar() As Char = Answer.ToCharArray
        Dim answerFlags() As Boolean = {False, False, False, False, False}
        For n As Integer = 0 To 4
            If LCase(Word(n)) = Answer(n) Then
                Textboxs(j, n).BackColor = Form3.Kesk
                answerFlags(n) = True
            End If
        Next
        For n As Integer = 0 To 4
            For l As Integer = 0 To 4
                If LCase(Word(n)) = Answer(l) And answerFlags(l) = False Then
                    If n - l > 1 Then
                        Textboxs(j, n).BackColor = Form3.Vasak
                        answerFlags(l) = True
                    ElseIf n - l < 1 Then
                        Textboxs(j, n).BackColor = Form3.Parem
                        answerFlags(l) = True
                    End If
                End If
            Next
        Next

        Dim Sona As String = New String(Word)
        Dim ans As String = New String(Answer)
        Dim f = FTable
        Dim nr As Integer = 1
        If f.table.Columns.Count = 0 Then
            Dim col1 As New DataColumn("Nr")
            Dim col2 As New DataColumn("Tulemus")
            Dim col3 As New DataColumn("Sõna")
            Dim col4 As New DataColumn("Katse")
            f.table.Columns.Add(col1)
            f.table.Columns.Add(col2)
            f.table.Columns.Add(col3)
            f.table.Columns.Add(col4)
        End If
        If Sona = UCase(Answer) And j <= 5 Then
            Me.Hide()
            FGameover.Lbltulemus.Text = "Sina võidad"
            FGameover.Lblvastus.Text = ""
            f.table.Rows.Add(nr, "Võida", ans, j + 1)
            FTable.DataGridView1.DataSource = f.table
            FGameover.Show()
        ElseIf j = 5 And Sona <> Answer Then
            Me.Hide()
            FGameover.Lbltulemus.Text = "Sa kaotasid"
            FGameover.Lblvastus.Text = "Vastus:" & Answer
            f.table.Rows.Add(nr, "Lüüa", ans, "-")
            FGameover.Show()
            FTable.DataGridView1.DataSource = f.table
        End If
        Return 1
    End Function


    Private Sub timerAjaliimit_Tick(sender As Object, e As EventArgs) Handles timerAjaliimit.Tick
        timerAjaliimit.Enabled = False
        Me.Hide()
        FGameover.BtnRestart.Text = "Ok"
        FGameover.Lbltulemus.Text = "Aeg on läbi"
        FGameover.Lblvastus.Text = ""
        FGameover.Show()
    End Sub

    Private Sub FGamewordle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textboxs(0, 0) = txtChar11
        Textboxs(0, 1) = txtChar12
        Textboxs(0, 2) = txtChar13
        Textboxs(0, 3) = txtChar14
        Textboxs(0, 4) = txtChar15
        Textboxs(1, 0) = txtChar21
        Textboxs(1, 1) = txtChar22
        Textboxs(1, 2) = txtChar23
        Textboxs(1, 3) = txtChar24
        Textboxs(1, 4) = txtChar25
        Textboxs(2, 0) = txtChar31
        Textboxs(2, 1) = txtChar32
        Textboxs(2, 2) = txtChar33
        Textboxs(2, 3) = txtChar34
        Textboxs(2, 4) = txtChar35
        Textboxs(3, 0) = txtChar41
        Textboxs(3, 1) = txtChar42
        Textboxs(3, 2) = txtChar43
        Textboxs(3, 3) = txtChar44
        Textboxs(3, 4) = txtChar45
        Textboxs(4, 0) = txtChar51
        Textboxs(4, 1) = txtChar52
        Textboxs(4, 2) = txtChar53
        Textboxs(4, 3) = txtChar54
        Textboxs(4, 4) = txtChar55
        Textboxs(5, 0) = txtChar61
        Textboxs(5, 1) = txtChar62
        Textboxs(5, 2) = txtChar63
        Textboxs(5, 3) = txtChar64
        Textboxs(5, 4) = txtChar65

    End Sub

End Class
'Массив не содержит такое большое число измерений