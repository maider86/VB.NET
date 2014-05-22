Public Class Form1

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        'MsgBox("Hola Mundo. ¿Qué tal?", MsgBoxStyle.Exclamation, "Saludo")
        Dim num1, num2, suma As Integer

        num1 = txtNum1.Text
        num2 = txtNum2.Text
        suma = num1 + num2

        MsgBox(suma)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
