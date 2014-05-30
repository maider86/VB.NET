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
        Me.sumar = New System.Windows.Forms.RadioButton()
        Me.restar = New System.Windows.Forms.RadioButton()
        Me.multiplicar = New System.Windows.Forms.RadioButton()
        Me.dividir = New System.Windows.Forms.RadioButton()
        Me.numero1 = New System.Windows.Forms.Label()
        Me.numero2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sumar
        '
        Me.sumar.AutoSize = True
        Me.sumar.Location = New System.Drawing.Point(13, 64)
        Me.sumar.Name = "sumar"
        Me.sumar.Size = New System.Drawing.Size(55, 17)
        Me.sumar.TabIndex = 0
        Me.sumar.TabStop = True
        Me.sumar.Text = "Sumar"
        Me.sumar.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.AutoSize = True
        Me.restar.Location = New System.Drawing.Point(12, 87)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(56, 17)
        Me.restar.TabIndex = 1
        Me.restar.TabStop = True
        Me.restar.Text = "Restar"
        Me.restar.UseVisualStyleBackColor = True
        '
        'multiplicar
        '
        Me.multiplicar.AutoSize = True
        Me.multiplicar.Location = New System.Drawing.Point(80, 64)
        Me.multiplicar.Name = "multiplicar"
        Me.multiplicar.Size = New System.Drawing.Size(72, 17)
        Me.multiplicar.TabIndex = 2
        Me.multiplicar.TabStop = True
        Me.multiplicar.Text = "Multiplicar"
        Me.multiplicar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.AutoSize = True
        Me.dividir.Location = New System.Drawing.Point(80, 87)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(54, 17)
        Me.dividir.TabIndex = 3
        Me.dividir.TabStop = True
        Me.dividir.Text = "Dividir"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'numero1
        '
        Me.numero1.AutoSize = True
        Me.numero1.Location = New System.Drawing.Point(18, 13)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(50, 13)
        Me.numero1.TabIndex = 4
        Me.numero1.Text = "Numero1"
        '
        'numero2
        '
        Me.numero2.AutoSize = True
        Me.numero2.Location = New System.Drawing.Point(87, 13)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(50, 13)
        Me.numero2.TabIndex = 5
        Me.numero2.Text = "Numero2"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(18, 30)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(50, 20)
        Me.txtNum1.TabIndex = 6
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(86, 30)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(51, 20)
        Me.txtNum2.TabIndex = 7
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(36, 122)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 8
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(168, 163)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.multiplicar)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.sumar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sumar As System.Windows.Forms.RadioButton
    Friend WithEvents restar As System.Windows.Forms.RadioButton
    Friend WithEvents multiplicar As System.Windows.Forms.RadioButton
    Friend WithEvents dividir As System.Windows.Forms.RadioButton
    Friend WithEvents numero1 As System.Windows.Forms.Label
    Friend WithEvents numero2 As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button

End Class
