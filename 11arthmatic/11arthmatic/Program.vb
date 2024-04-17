Module Module1
    Sub Main()
        Dim N1, N2, Result, choice As Integer
        Do
            Console.WriteLine("Menu:-")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            Console.WriteLine("5. Exit.")
            Console.WriteLine("Enter choice: ")
            choice = Console.ReadLine()
            Console.WriteLine("Enter number 1: ")
            N1 = Console.ReadLine()
            Console.WriteLine("Enter number 2: ")
            N2 = Console.ReadLine()
            Select Case choice
                Case 1
                    Result = N1 + N2
                    Console.WriteLine("Sum = " & Result)
                Case 2
                    Result = N1 - N2
                    Console.WriteLine("Difference = " & Result)
                Case 3
                    Result = N1 * N2
                    Console.WriteLine("Product = " & Result)
                Case 4
                    Result = N1 \ N2
                    Console.WriteLine("Quotient = " & Result)
                    Result = N1 Mod N2
                    Console.WriteLine("Remainder = " & Result)
                Case 5
                    Exit Sub
                Case Else
                    Console.WriteLine("Wrong option ...")
            End Select
        Loop While choice <> 5
    End Sub
End Module