Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim num2 As Integer = Integer.Parse(TextBox2.Text)
        TextBox3.Text = (num1 + num2).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim num2 As Integer = Integer.Parse(TextBox2.Text)
        TextBox3.Text = (num1 - num2).ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim num2 As Integer = Integer.Parse(TextBox2.Text)
        TextBox3.Text = (num1 * num2).ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim num2 As Integer = Integer.Parse(TextBox2.Text)
        If num2 <> 0 Then
            TextBox3.Text = (num1 / num2).ToString()
        Else
            TextBox3.Text = "Error: Cannot divide by zero"
        End If
    End Sub
End Class
