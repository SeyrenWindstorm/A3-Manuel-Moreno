Module Module1

    Sub Main()
        Dim a, b, res As Double

        Console.WriteLine("Valor de el lado a")
        b = Console.ReadLine()
        Console.WriteLine("Valor de el lado b")
        a = Console.ReadLine()

        res = CalcularHipo(a, b)

        Console.WriteLine("La Hipotenusa es {0}", res)
        Console.ReadLine()

    End Sub
    Public Function CalcularHipo(ByVal a As Double, ByVal b As Double) As Double
        Dim c2 As Double
        c2 = (a ^ 2) + (b ^ 2)
        Return c2
    End Function

End Module
