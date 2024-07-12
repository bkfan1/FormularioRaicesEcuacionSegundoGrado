<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioRaicesEcuacionSegundoGrado
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputA = New System.Windows.Forms.TextBox()
        Me.InputB = New System.Windows.Forms.TextBox()
        Me.InputC = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblResultado1 = New System.Windows.Forms.Label()
        Me.LblResultado2 = New System.Windows.Forms.Label()
        Me.LblRaicesImaginarias = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese los Valores de"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "a:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(223, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "b:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(386, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "c:"
        '
        'InputA
        '
        Me.InputA.Location = New System.Drawing.Point(84, 75)
        Me.InputA.Name = "InputA"
        Me.InputA.Size = New System.Drawing.Size(45, 20)
        Me.InputA.TabIndex = 4
        '
        'InputB
        '
        Me.InputB.Location = New System.Drawing.Point(268, 75)
        Me.InputB.Name = "InputB"
        Me.InputB.Size = New System.Drawing.Size(49, 20)
        Me.InputB.TabIndex = 5
        '
        'InputC
        '
        Me.InputC.Location = New System.Drawing.Point(431, 75)
        Me.InputC.Name = "InputC"
        Me.InputC.Size = New System.Drawing.Size(49, 20)
        Me.InputC.TabIndex = 6
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnCalcular.Enabled = False
        Me.BtnCalcular.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.Color.White
        Me.BtnCalcular.Location = New System.Drawing.Point(218, 133)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(99, 43)
        Me.BtnCalcular.TabIndex = 7
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(117, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Resultados:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(39, 329)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(104, 42)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gold
        Me.BtnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(260, 329)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 42)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblResultado1
        '
        Me.LblResultado1.AutoSize = True
        Me.LblResultado1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultado1.ForeColor = System.Drawing.Color.White
        Me.LblResultado1.Location = New System.Drawing.Point(38, 268)
        Me.LblResultado1.Name = "LblResultado1"
        Me.LblResultado1.Size = New System.Drawing.Size(0, 27)
        Me.LblResultado1.TabIndex = 11
        Me.LblResultado1.Visible = False
        '
        'LblResultado2
        '
        Me.LblResultado2.AutoSize = True
        Me.LblResultado2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultado2.ForeColor = System.Drawing.Color.White
        Me.LblResultado2.Location = New System.Drawing.Point(257, 268)
        Me.LblResultado2.Name = "LblResultado2"
        Me.LblResultado2.Size = New System.Drawing.Size(0, 27)
        Me.LblResultado2.TabIndex = 12
        Me.LblResultado2.Visible = False
        '
        'LblRaicesImaginarias
        '
        Me.LblRaicesImaginarias.AutoSize = True
        Me.LblRaicesImaginarias.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRaicesImaginarias.ForeColor = System.Drawing.Color.White
        Me.LblRaicesImaginarias.Location = New System.Drawing.Point(44, 268)
        Me.LblRaicesImaginarias.Name = "LblRaicesImaginarias"
        Me.LblRaicesImaginarias.Size = New System.Drawing.Size(0, 27)
        Me.LblRaicesImaginarias.TabIndex = 13
        Me.LblRaicesImaginarias.Visible = False
        '
        'FormularioRaicesEcuacionSegundoGrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.FormularioRaicesEcuacionSegundoGrado.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.LblRaicesImaginarias)
        Me.Controls.Add(Me.LblResultado2)
        Me.Controls.Add(Me.LblResultado1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.InputC)
        Me.Controls.Add(Me.InputB)
        Me.Controls.Add(Me.InputA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioRaicesEcuacionSegundoGrado"
        Me.Text = "Formulario Raíces de Ecuación de Segundo Grado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputA As TextBox
    Friend WithEvents InputB As TextBox
    Friend WithEvents InputC As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblResultado1 As Label
    Friend WithEvents LblResultado2 As Label
    Friend WithEvents LblRaicesImaginarias As Label
End Class
