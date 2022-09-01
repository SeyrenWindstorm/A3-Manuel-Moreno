Module Module1

    Public Sub Main()

        Dim nota1, nota2, res As Double

        Console.WriteLine("Escriba la Nota 1")
        nota1 = Console.ReadLine()
        Console.WriteLine("Escriba la Nota 2")
        nota2 = Console.ReadLine()

        res = CalcularPromedio(nota1, nota2)

        Console.WriteLine("El promedio es {0}", res)
        Console.ReadLine()

    End Sub

    Public Function CalcularPromedio(ByVal n1 As Double, ByVal n2 As Double) As Double
        Dim r As Double
        r = (n1 + n2) / 2
        Return r
    End Function

End Module
