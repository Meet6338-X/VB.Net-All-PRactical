Module Module1
    Sub Main()
        Dim n As Integer
        Console.WriteLine("Enter a Number")
        n = Integer.Parse(Console.ReadLine())
        If (n > 0) Then
            Console.WriteLine("Number is Positive")
        Else
            Console.WriteLine("Number is Negative")
        End If
        Console.ReadLine()
    End Sub
End Module