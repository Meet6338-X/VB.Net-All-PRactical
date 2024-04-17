Public Class Form1
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            MessageBox.Show("TabPage1 selected")
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            MessageBox.Show("TabPage2 selected")
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            MessageBox.Show("TabPage3 selected")
        End If
    End Sub
End Class
