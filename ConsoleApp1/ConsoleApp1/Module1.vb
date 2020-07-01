Imports YFCommonTools

Module Module1

    Sub Main()
        Dim l = Licensing.RetrieveAllMacs()
        Console.WriteLine(String.Join(", ", l))
        Console.ReadKey()
    End Sub

End Module
