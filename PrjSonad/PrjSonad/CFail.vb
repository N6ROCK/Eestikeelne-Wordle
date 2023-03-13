Public Class CFail
    Implements ISona
    Private intNumber As Integer
    Private intFileNum As Integer
    Private strKotoba As String

    Private Property num As Integer Implements ISona.num
        Get
            Return intNumber
        End Get
        Set(ByVal value As Integer)
            intNumber = value
        End Set
    End Property

    Private Property FileNum As Integer Implements ISona.FileNum
        Get
            Return intFileNum
        End Get
        Set(ByVal value As Integer)
            intFileNum = value
        End Set
    End Property

    Private Property Sona As String Implements ISona.Sona
        Get
            Return strKotoba
        End Get
        Set(ByVal value As String)
            strKotoba = value
        End Set
    End Property

    Private Function DaiSukaSlovo() As String _
        Implements ISona.DaiSukaSlovo
        FileOpen(intFileNum, "Sonad.txt", OpenMode.Input)
        Dim dai As Integer
        Do Until EOF(intFileNum) And dai = 220
            strKotoba = LineInput(intFileNum)
            If dai = intNumber Then
                FileClose(intFileNum)
                Exit Do
            Else
                dai = dai + 1
            End If
        Loop
        Return strKotoba
        FileClose(intFileNum)
    End Function
End Class
