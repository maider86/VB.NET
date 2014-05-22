Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        Dim i As Integer

        '        For i = 0 To 4
        '        MsgBox(i)
        '        Next

        '        Dim array(10) As Integer
        '        Dim i As Integer

        '        For i = 0 To 9
        '        Array(i) = i + 1
        '        MsgBox("Array(" + i.ToString + ") = " + Array(i).ToString)
        '        Next

        Dim i As Integer
        Dim j As Integer

        For i = 0 To 2
            MsgBox("Bucle externo i = " + i.ToString)
            For j = 0 To 3
                MsgBox("Bucle interno j = " + j.ToString)
            Next
        Next
    End Sub
End Class
