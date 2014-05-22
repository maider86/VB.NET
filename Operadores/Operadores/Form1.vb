Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, resultado As Integer
        Dim resultado2 As Double
        num1 = 2
        num2 = 5
        resultado = num1 + num2
        MsgBox(resultado.ToString)

        resultado = num1 - num2
        MsgBox(resultado.ToString)

        resultado = num1 * num2
        MsgBox(resultado.ToString)

        resultado2 = num1 / num2
        MsgBox(resultado2.ToString)

        resultado = num1 Mod num2
        MsgBox(resultado.ToString)

        resultado = 5 Mod num2
        MsgBox(resultado.ToString)

        num1 += 1 'Para incrementar en 1
        MsgBox(num1.ToString)

        num1 += 5 'Para incrementar en 5
        MsgBox(num1.ToString)

        num1 -= 5
        MsgBox(num1.ToString)
    End Sub
End Class
