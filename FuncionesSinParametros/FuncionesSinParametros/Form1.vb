Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Saludo()
        MsgBox("Soy la función que no devuelve parametros")
    End Sub

    Function DevuelveSaludo()
        Dim saludo As String
        saludo = "Soy la función que devuelve parametros"
        Return saludo
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Saludo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hola As String
        hola = DevuelveSaludo()
        MsgBox(hola)
    End Sub
End Class
