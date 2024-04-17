Module Main
    Sub Main()
        Console.WriteLine("Using For loop:")
        Dim numbers() As Integer = {1, 2, 3, 4, 5}
        Dim sum As Integer = 0
        For i As Integer = 0 To numbers.Length - 1
            sum += numbers(i)
        Next
        Console.WriteLine("Sum of elements: " & sum)
        Console.WriteLine("Using For Each loop:")
        Dim sumForEach As Integer = 0
        For Each num As Integer In numbers
            sumForEach += num
        Next
        Console.WriteLine("Sum of elements: " & sumForEach)
        Console.ReadLine()
    End Sub
End Module