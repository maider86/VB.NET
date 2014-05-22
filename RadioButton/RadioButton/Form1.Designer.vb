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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Suma = New System.Windows.Forms.RadioButton()
        Me.Resta = New System.Windows.Forms.RadioButton()
        Me.Multiplicacion = New System.Windows.Forms.RadioButton()
        Me.Division = New System.Windows.Forms.RadioButton()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Operacion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Operacion)
        Me.GroupBox1.Controls.Add(Me.numero2)
        Me.GroupBox1.Controls.Add(Me.numero1)
        Me.GroupBox1.Controls.Add(Me.Division)
        Me.GroupBox1.Controls.Add(Me.Multiplicacion)
        Me.GroupBox1.Controls.Add(Me.Resta)
        Me.GroupBox1.Controls.Add(Me.Suma)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(7, 20)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(52, 17)
        Me.Suma.TabIndex = 0
        Me.Suma.TabStop = True
        Me.Suma.Text = "Suma"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Location = New System.Drawing.Point(7, 43)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(53, 17)
        Me.Resta.TabIndex = 1
        Me.Resta.TabStop = True
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.AutoSize = True
        Me.Multiplicacion.Location = New System.Drawing.Point(6, 66)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.Multiplicacion.TabIndex = 2
        Me.Multiplicacion.TabStop = True
        Me.Multiplicacion.Text = "Multiplicacion"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.AutoSize = True
        Me.Division.Location = New System.Drawing.Point(6, 89)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(62, 17)
        Me.Division.TabIndex = 3
        Me.Division.TabStop = True
        Me.Division.Text = "División"
        Me.Division.UseVisualStyleBackColor = True
        '
        'numero1
        '
        Me.numero1.Location = New System.Drawing.Point(120, 20)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(75, 20)
        Me.numero1.TabIndex = 4
        '
        'numero2
        '
        Me.numero2.Location = New System.Drawing.Point(120, 46)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(75, 20)
        Me.numero2.TabIndex = 5
        '
        'Operacion
        '
        Me.Operacion.Location = New System.Drawing.Point(120, 87)
        Me.Operacion.Name = "Operacion"
        Me.Operacion.Size = New System.Drawing.Size(75, 23)
        Me.Operacion.TabIndex = 6
        Me.Operacion.Text = "Ejecutar"
        Me.Operacion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Operacion As System.Windows.Forms.Button
    Friend WithEvents numero2 As System.Windows.Forms.TextBox
    Friend WithEvents numero1 As System.Windows.Forms.TextBox
    Friend WithEvents Division As System.Windows.Forms.RadioButton
    Friend WithEvents Multiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents Resta As System.Windows.Forms.RadioButton
    Friend WithEvents Suma As System.Windows.Forms.RadioButton

End Class
