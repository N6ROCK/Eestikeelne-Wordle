Public Class FTable
    Public table As New DataTable()


    Private Sub FTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If table.Columns.Count = 0 Then
            Dim col1 As New DataColumn("Nr")
            Dim col2 As New DataColumn("Tulemus")
            Dim col3 As New DataColumn("Sõna")
            Dim col4 As New DataColumn("Katse")
            table.Columns.Add(col1)
            table.Columns.Add(col2)
            table.Columns.Add(col3)
            table.Columns.Add(col4)
        End If
        Try
            Dim fname As Integer = FreeFile()
            Dim sline As String = ""
            Dim r As Integer = 1
            Dim column As Boolean = False
            FileOpen(fname, "csv.txt", OpenMode.Input)
            Do Until EOF(fname)
                sline = LineInput(fname)
                If column = True Then
                    Dim words() As String = sline.Split(",")
                    DataGridView1.Rows.Add()
                    For i As Integer = 0 To 3
                        DataGridView1.Rows(r).Cells(i).Value = words(i)
                    Next
                    r = r + 1
                Else
                    column = True
                End If
            Loop
            FileClose(fname)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FTable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("csv.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
            sw.Close()
        End Using
        'Process.Start("csv.txt")
    End Sub
End Class