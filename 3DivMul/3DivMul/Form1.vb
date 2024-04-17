Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2 As Double ' Using Double for division to handle decimal numbers
        num1 = InputBox("Enter the first number:")
        num2 = InputBox("Enter the second number:")
        Dim divisionResult As Double
        Dim multiplicationResult As Double
        If num2 <> 0 Then
            divisionResult = num1 / num2
        Else
            MsgBox("Error: Division by zero is not allowed.")
            Return ' Exit the program if division by zero occurs
        End If
        multiplicationResult = num1 * num2
        MsgBox("Division Result: " & divisionResult)
        MsgBox("Multiplication Result: " & multiplicationResult)
        Me.Close()
    End Sub
End Class