Module Module1

    Sub Main()


        Dim precio, valor As Double

            Console.WriteLine("Valor del Automovil")
        valor = Console.ReadLine()
        precio = PrecioTotal(valor)


        Console.WriteLine("Valor del Automovil {0}", precio)
        Console.ReadLine()


        End Sub

        Public Function PrecioTotal(ByVal vt As Double) As Double
        Dim c, vd, itbms As Double

        vd = vt * 0.12
        itbms = vt * 0.06
        c = vt + vd + itbms

        Return c

    End Function


    End Module

