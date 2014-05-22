<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rock = New System.Windows.Forms.CheckBox()
        Me.pop = New System.Windows.Forms.CheckBox()
        Me.clasica = New System.Windows.Forms.CheckBox()
        Me.reggaeton = New System.Windows.Forms.CheckBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.otros = New System.Windows.Forms.CheckBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rock
        '
        Me.rock.AutoSize = True
        Me.rock.Location = New System.Drawing.Point(13, 40)
        Me.rock.Name = "rock"
        Me.rock.Size = New System.Drawing.Size(52, 17)
        Me.rock.TabIndex = 0
        Me.rock.Text = "Rock"
        Me.rock.UseVisualStyleBackColor = True
        '
        'pop
        '
        Me.pop.AutoSize = True
        Me.pop.Location = New System.Drawing.Point(13, 63)
        Me.pop.Name = "pop"
        Me.pop.Size = New System.Drawing.Size(45, 17)
        Me.pop.TabIndex = 1
        Me.pop.Text = "Pop"
        Me.pop.UseVisualStyleBackColor = True
        '
        'clasica
        '
        Me.clasica.AutoSize = True
        Me.clasica.Location = New System.Drawing.Point(13, 86)
        Me.clasica.Name = "clasica"
        Me.clasica.Size = New System.Drawing.Size(60, 17)
        Me.clasica.TabIndex = 2
        Me.clasica.Text = "Clásica"
        Me.clasica.UseVisualStyleBackColor = True
        '
        'reggaeton
        '
        Me.reggaeton.AutoSize = True
        Me.reggaeton.Location = New System.Drawing.Point(13, 109)
        Me.reggaeton.Name = "reggaeton"
        Me.reggaeton.Size = New System.Drawing.Size(79, 17)
        Me.reggaeton.TabIndex = 3
        Me.reggaeton.Text = "Reggaetón"
        Me.reggaeton.UseVisualStyleBackColor = True
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(13, 13)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(167, 13)
        Me.lblPregunta.TabIndex = 4
        Me.lblPregunta.Text = "¿Qué género de música te gusta?"
        '
        'otros
        '
        Me.otros.AutoSize = True
        Me.otros.Location = New System.Drawing.Point(13, 132)
        Me.otros.Name = "otros"
        Me.otros.Size = New System.Drawing.Size(51, 17)
        Me.otros.TabIndex = 5
        Me.otros.Text = "Otros"
        Me.otros.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(62, 155)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.otros)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.reggaeton)
        Me.Controls.Add(Me.clasica)
        Me.Controls.Add(Me.pop)
        Me.Controls.Add(Me.rock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rock As System.Windows.Forms.CheckBox
    Friend WithEvents pop As System.Windows.Forms.CheckBox
    Friend WithEvents clasica As System.Windows.Forms.CheckBox
    Friend WithEvents reggaeton As System.Windows.Forms.CheckBox
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents otros As System.Windows.Forms.CheckBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button

End Class
