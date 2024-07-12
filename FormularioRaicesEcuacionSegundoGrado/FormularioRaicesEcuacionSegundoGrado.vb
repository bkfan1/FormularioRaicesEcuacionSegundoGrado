Public Class FormularioRaicesEcuacionSegundoGrado
    ' Función para verificar si existe una solución real
    Private Function existeSolucionRC(a As Double, b As Double, c As Double) As Integer
        Dim discriminante As Double
        discriminante = b ^ 2 - 4 * a * c
        If discriminante < 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    ' Función para calcular la primera solución de la ecuación cuadrática
    Private Function solucionRC1(a As Double, b As Double, c As Double) As Double
        Dim discriminante As Double
        discriminante = b ^ 2 - 4 * a * c
        Return (-b + Math.Sqrt(discriminante)) / (2 * a)
    End Function

    ' Función para calcular la segunda solución de la ecuación cuadrática
    Private Function solucionRC2(a As Double, b As Double, c As Double) As Double
        Dim discriminante As Double
        discriminante = b ^ 2 - 4 * a * c
        Return (-b - Math.Sqrt(discriminante)) / (2 * a)
    End Function

    ' Evento al hacer clic en el botón Calcular
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim a As Double = Val(InputA.Text)
        Dim b As Double = Val(InputB.Text)
        Dim c As Double = Val(InputC.Text)

        If existeSolucionRC(a, b, c) = 1 Then
            Dim raiz1 As Double = solucionRC1(a, b, c)
            Dim raiz2 As Double = solucionRC2(a, b, c)

            LblRaicesImaginarias.Text = ""
            LblRaicesImaginarias.Visible = False

            LblResultado1.Text = "Raíz 1: " & raiz1
            LblResultado2.Text = "Raíz 2: " & raiz2
            LblResultado1.Visible = True
            LblResultado2.Visible = True
        Else
            LblResultado1.Text = ""
            LblResultado2.Text = ""
            LblResultado1.Visible = False
            LblResultado2.Visible = False

            LblRaicesImaginarias.Text = "Las raíces son imaginarias, sin solución real"
            LblRaicesImaginarias.Visible = True
            'MessageBox.Show("Las raíces son imaginarias", "Sin solución real", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        BtnCancelar.Enabled = True
    End Sub

    ' Evento al hacer clic en el botón Cancelar
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

    ' Procedimiento para limpiar los controles
    Private Sub Limpiar()
        InputA.Text = ""
        InputB.Text = ""
        InputC.Text = ""
        LblResultado1.Visible = False
        LblResultado2.Visible = False
        InputA.Focus()
        BtnCancelar.Enabled = False
    End Sub

    Private Sub VerificarInputs()
        Dim a As Double
        Dim b As Double
        Dim c As Double

        Dim isAValid As Boolean = Double.TryParse(InputA.Text, a)
        Dim isBValid As Boolean = Double.TryParse(InputB.Text, b)
        Dim isCValid As Boolean = Double.TryParse(InputC.Text, c)

        BtnCalcular.Enabled = isAValid AndAlso isBValid AndAlso isCValid
    End Sub

    ' Evento al cambiar el texto de los TextBox
    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles InputA.TextChanged, InputB.TextChanged, InputC.TextChanged
        VerificarInputs()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
