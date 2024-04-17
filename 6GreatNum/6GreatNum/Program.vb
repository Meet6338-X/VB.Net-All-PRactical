Module Module1
    Sub Main()
        Dim a, b, c As Integer
        Console.Write("Enter the values of a, b, and c:")
        Console.WriteLine()
        a = Val(Console.ReadLine())
        b = Val(Console.ReadLine())
        c = Val(Console.ReadLine())
        If a > b Then
            If a > c Then
                Console.WriteLine("Greatest Number is:" & a)
            Else
                Console.WriteLine("Greatest Number is:" & c)
            End If
        Else
            If b > c Then
                Console.WriteLine("Greatest Number is:" & b)
            Else
                Console.WriteLine("Greatest Number is:" & c)
            End If
        End If
        Console.ReadLine()
    End Sub
End Module