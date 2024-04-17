Module Main
    Sub Main()
        Console.WriteLine("Using While loop:")
        Dim i As Integer = 1
        While i <= 5
            Console.WriteLine(i)
            i += 1
        End While
        Console.WriteLine("Using Do While loop:")
        Dim j As Integer = 1
        Do While j <= 5
            Console.WriteLine(j)
            j += 1
        Loop
        Console.ReadLine()
    End Sub
End Module