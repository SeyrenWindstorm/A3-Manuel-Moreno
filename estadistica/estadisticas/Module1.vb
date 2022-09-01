Module Module1

    Sub Main()
        Dim nota As Integer
        Dim c, e, ea As Integer
        Dim opc As String

        c = 1


        While (c = 1)
            Console.WriteLine("Escriba la calificacion del estudiante")
            nota = Console.ReadLine()

            If nota >= 0 & nota <= 100 Then e = e + 1

            If nota >= 71 Then ea = ea + 1

            Console.WriteLine("Desea ingresar otra nota? s/n ")
            opc = Console.ReadLine()

            If opc = "s" Then c = 1 Else c = 2

        End While

        Aprobados(e, ea)

    End Sub

    Public Sub Aprobados(ByVal est As Integer, ByVal apro As Integer)

        Console.WriteLine("estudiantes : " & est)

        Console.WriteLine("estudiantes aprobados: " & apro)

        Console.WriteLine("El porcentaje de estudiantes aprobados es: " & 100 / est * apro)

        Console.ReadLine()

    End Sub

End Module
