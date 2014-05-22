Public Class Form1

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        '        Dim numero1, numero2 As Integer

        '        numero1 = txtNum1.Text
        '        numero2 = txtNum2.Text

        '        If (numero1 < numero2) Then
        '        MsgBox("Numero1 menor que Numero2")
        '        ElseIf (numero1 = numero2) Then
        '        MsgBox("Numero1 igual que Numero2")
        '        Else
        '        MsgBox("Numero1 mayor que Numero2")
        '        End If

        If (txtNum1.Text.Contains("ol")) Then
            MsgBox("La frase contiene la cadena de caracteres OL")
        Else
            MsgBox("La frase no contiene la cadena de caracteres OL")
        End If
    End Sub
End Class
