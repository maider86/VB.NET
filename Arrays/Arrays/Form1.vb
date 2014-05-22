Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim array(3) As String
        array(0) = "Hola"
        array(1) = "Mundo"
        array(2) = "¿Qué tal?"
        MsgBox(array(0) + " " + array(1) + " " + array(2))

        Dim array2() As Integer
        array2 = New Integer() {1, 2, 3}
        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)

        ReDim Preserve array2(2)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)

        ReDim array2(3)
        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)

        '(0,0)  (0,1)   (0,2)
        '  1      2       3
        '  4      5       6
        '(1,0)  (1,1)   (1,2)
        Dim arrayBiDimensional(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(arrayBiDimensional(1, 1).ToString)
    End Sub
End Class
