<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtExpresion = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expresión aritmetica"
        '
        'TxtExpresion
        '
        Me.TxtExpresion.Location = New System.Drawing.Point(120, 20)
        Me.TxtExpresion.Name = "TxtExpresion"
        Me.TxtExpresion.Size = New System.Drawing.Size(300, 20)
        Me.TxtExpresion.TabIndex = 1
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(220, 60)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtResultado.TabIndex = 2
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(120, 60)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Button1"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 120)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtExpresion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aritmetica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtExpresion As System.Windows.Forms.TextBox
    Friend WithEvents TxtResultado As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button

End Class
