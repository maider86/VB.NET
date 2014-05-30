Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim array(5)

        '        Do
        '        MsgBox("Bucle Do = " + i.ToString)
        '        i += 1
        '        Loop While i < 3

        '        i = 0

        '        Do While i < 3
        '        MsgBox("Bucle Do While = " + i.ToString)
        '        i += 1
        '        Loop

        '        i = 0

        '        While i < 3
        '        MsgBox("Bucle While = " + i.ToString)
        '        i += 1
        '        End While

        Do While i < 5
            array(i) = i
            i += 1
        Loop

        i = 0

        While i < 5
            MsgBox("Array(" + i.ToString + ") = " + array(i).ToString)
            i += 1
        End While

    End Sub
End Class
