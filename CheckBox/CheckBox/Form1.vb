Public Class Form1

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim rock, pop, clasica, reggaeton, otros As Boolean

        If Me.rock.Checked = True Then
            rock = True
        Else
            rock = False
        End If
        If Me.pop.Checked = True Then
            pop = True
        Else
            pop = False
        End If
        If Me.clasica.Checked = True Then
            clasica = True
        Else
            clasica = False
        End If
        If Me.reggaeton.Checked = True Then
            reggaeton = True
        Else
            reggaeton = False
        End If
        If Me.otros.Checked = True Then
            otros = True
        Else
            otros = False
        End If

        MsgBox("Generos seleccionados: ")
        If rock = True Then
            MsgBox("ROCK")
        End If
        If pop = True Then
            MsgBox("POP")
        End If
        If clasica = True Then
            MsgBox("CLÁSICA")
        End If
        If reggaeton = True Then
            MsgBox("REGGAETÓN")
        End If
        If otros = True Then
            MsgBox("OTROS")
        End If
    End Sub
End Class
