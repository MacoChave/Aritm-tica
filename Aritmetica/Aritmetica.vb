Public Class Aritmetica

    Dim caracter As Char

    Dim prevLex As String
    Dim auxLex As String
    Dim avLex As String

    Dim prevDig As Integer
    Dim digito As Integer
    Dim avDigito As Integer
    Dim auxDig As String
    Dim resultado As Integer

    Dim parentesis As Boolean = False
    Dim estado As Integer

    Public Sub aritmetica(texto)
        estado = 0
        For a As Integer = 0 To texto.Length - 1 Step 1
            caracter = texto.Chars(a)
            Select Case estado
                Case 0 'A
                    Select Case caracter
                        Case "(" '-> B
                            estado = 1
                            parentesis = True
                        Case "0" To "9" '->C
                            estado = 2
                            auxDig = caracter
                        Case Else 'Cualquier operador
                            MessageBox.Show("Una expresión aritmetica" & vbCrLf & "no puede comenzar con " & caracter)
                    End Select
                Case 1 'B
                    Select Case caracter
                        Case "0" To "9" '->C
                            estado = 2
                            auxDig = caracter
                        Case Else 'Cualquier operador
                            MessageBox.Show("Se esperaba un número" & vbCrLf & "no esto " & caracter)
                    End Select
                Case 2 'C
                    Select Case caracter
                        Case "0" To "9" '->C
                            auxDig += caracter
                        Case "*" ' ->D
                            auxLex = caracter
                            digito = Integer.Parse(auxDig)
                            If (prevDig = 0) Then
                                resultado = digito * auxDig
                                digito = Nothing
                                auxDig = Nothing
                            End If
                            estado = 3
                        Case "/" ' ->D
                            auxLex = caracter
                            digito = Integer.Parse(auxDig)
                            If (prevDig = 0) Then
                                resultado = digito / auxDig
                                digito = Nothing
                                auxDig = Nothing
                            End If
                            estado = 3
                        Case "+" ' ->D
                            auxLex = caracter
                            digito = Integer.Parse(auxDig)
                            If (prevDig = 0 & caracter) Then

                            End If
                            estado = 3
                        Case "-" ' ->D
                            auxLex = caracter
                            digito = Integer.Parse(auxDig)
                            If (prevDig = 0) Then

                            End If
                            estado = 3
                        Case ")" '->E
                            estado = 4
                            digito = Integer.Parse(auxDig)
                            parentesis = False
                    End Select
                Case 3 'D
                    Select Case caracter
                        Case "0" To "9" '->C
                            estado = 2
                            auxDig = caracter
                            prevDig = digito
                        Case "(" ' -C
                            estado = 2
                            auxDig = caracter
                            prevDig = digito
                        Case Else 'Cualquier operador
                            MessageBox.Show("Se esperaba un número" & vbCrLf & "no esto " & caracter)
                    End Select
                Case 4 'E
                    Select Case caracter
                        Case "+", "-" '->D"
                            estado = 2
                            auxLex = caracter
                            prevDig = digito
                        Case "*", "/" '->D
                            estado = 2
                            auxLex = caracter
                            prevDig = digito
                        Case Else 'Cualquier operador
                            MessageBox.Show("Se esperaba un operador" & vbCrLf & "no esto " & caracter)
                    End Select
            End Select
        Next
    End Sub
End Class
