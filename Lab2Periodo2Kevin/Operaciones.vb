Public Class Operaciones

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        TextBox3.Text = Val(TextBox1.Text) + (TextBox2.Text)
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        TextBox3.Text = Val(TextBox1.Text) - (TextBox2.Text)
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        TextBox3.Text = Val(TextBox1.Text) * (TextBox2.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim i As Integer
        Dim num As Integer
        Dim tot As Long
        num = ComboBox1.Text
        For i = 1 To 10
            tot = num + i

            ListBox1.Items.Add(num & " + " & i & " = " & tot)
            ListBox1.Items.Add("")
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim i As Integer
        Dim num As Integer
        Dim tot As Long
        num = ComboBox2.Text
        For i = 1 To 10
            tot = num - i

            ListBox1.Items.Add(num & " - " & i & " = " & tot)
            ListBox1.Items.Add("")
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim i As Integer
        Dim num As Integer
        Dim tot As Long
        num = ComboBox3.Text
        For i = 1 To 10
            tot = num * i

            ListBox1.Items.Add(num & " x " & i & " = " & tot)
            ListBox1.Items.Add("")
        Next
    End Sub

End Class

