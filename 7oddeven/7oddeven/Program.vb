Module Module1
    Dim i As Integer
    Sub Main()
        Console.WriteLine("Enter Number")
        i = Integer.Parse(Console.ReadLine())
        If (i Mod 2 = 0) Then
            Console.WriteLine("Number is Even")
        Else
            Console.WriteLine("Number is Odd")
        End If
        Console.ReadLine()
    End Sub
End Module
