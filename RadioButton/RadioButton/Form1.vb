Public Class Form1

    Private Sub Operacion_Click(sender As Object, e As EventArgs) Handles Operacion.Click
        Dim num1, num2 As Integer
        Dim resultado As Double

        num1 = numero1.Text
        num2 = numero2.Text

        'Para saber si el radioButton está seleccionado
        If (Suma.Checked = True) Then
            resultado = num1 + num2
        ElseIf (Resta.Checked = True) Then
            resultado = num1 - num2
        ElseIf (Multiplicacion.Checked = True) Then
            resultado = num1 * num2
        Else
            resultado = num1 / num2
        End If
        MsgBox("El resultado de la operación es " + resultado.ToString)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para que el radioButton de la División se muestre seleccionada por defecto. Sino, se muestra
        'seleccionada el primer RadioButton.
        Division.Checked = True
    End Sub
End Class
