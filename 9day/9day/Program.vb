Imports System.Linq.Expressions

Module Main
    Sub Main()
        Console.WriteLine("Enter a number between 1 and 7:")
        Dim dayOfWeek As Integer = Convert.ToInt32(Console.ReadLine())
        Select Case dayOfWeek
            Case 1
                Console.WriteLine("Sunday")
            Case 2
                Console.WriteLine("Monday")
            Case 3
                Console.WriteLine("Tuesday")
            Case 4
                Console.WriteLine("Wednesday")
            Case 5
                Console.WriteLine("Thursday")
            Case 6
                Console.WriteLine("Friday")
            Case 7
                Console.WriteLine("Saturday")
            Case Else
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.")
        End Select
        Console.ReadLine() ' To keep console window open until a key is pressed
    End Sub
End Module