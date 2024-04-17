Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2 As Integer
        num1 = InputBox("Enter the first number:")
        num2 = InputBox("Enter the second number:")
        Dim addition As Integer = num1 + num2
        Dim subtraction As Integer = num1 - num2
        MsgBox("Addition Result: " & addition)
        MsgBox("Subtraction Result: " & subtraction)
        Me.Close()
    End Sub
End Class
