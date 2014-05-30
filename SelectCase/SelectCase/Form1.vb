Public Class Form1

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim opcion As String = "" 'Es conveniente inicializar, aunque no obligatorio. De esta manera desaparecen las advertencias
        Dim num1, num2 As Integer
        Dim resultado As Double

        If sumar.Checked = True Then
            opcion = "Sumar"
        End If

        If restar.Checked = True Then
            opcion = "Restar"
        End If

        If multiplicar.Checked = True Then
            opcion = "Multiplicar"
        End If

        If dividir.Checked = True Then
            opcion = "Dividir"
        End If

        num1 = numero1.Text
        num2 = numero2.Text

        Select Case opcion
            Case "Sumar"
                resultado = num1 + num2
            Case "Restar"
                resultado = num1 - num2
            Case "Multiplicar"
                resultado = num1 * num2
            Case "Dividir"
                resultado = num1 / num2
            Case Else
                MsgBox("No ha seleccionado ninguna operación")
                Exit Sub 'Para que salga de la función
        End Select
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

End Class
