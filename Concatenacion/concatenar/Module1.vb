Module Module1

    Sub Main()

        Dim nom, ape, completo As String

        Console.WriteLine("Escriba su nombre")
        nom = Console.ReadLine()
        Console.WriteLine("Escriba su apellido")
        ape = Console.ReadLine()

        completo = Nombre(nom, ape)

        Console.WriteLine("Hola {0} ", completo)
        Console.ReadLine()

    End Sub

    Public Function Nombre(ByVal n As String, ByVal a As String) As String
        Dim c As String
        c = n & " " & a
        Return c
    End Function

End Module
