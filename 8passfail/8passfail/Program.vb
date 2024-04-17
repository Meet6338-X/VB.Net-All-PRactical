Module Main
    Sub Main()
        Console.WriteLine("Enter the percentage:")
        Dim percentage As Double = Convert.ToDouble(Console.ReadLine())
        If percentage < 40 Then
            Console.WriteLine("Result: Fail")
        ElseIf percentage >= 40 AndAlso percentage < 60 Then
            Console.WriteLine("Result: Pass Class")
        ElseIf percentage >= 60 AndAlso percentage < 75 Then
            Console.WriteLine("Result: First Class")
        ElseIf percentage >= 75 Then
            Console.WriteLine("Result: Distinction")
        End If
        Console.ReadLine()
    End Sub
End Module