Public Class Form1
    Dim aritmetica As New Aritmetica()
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        aritmetica.aritmetica(TxtExpresion.Text)
    End Sub
End Class
