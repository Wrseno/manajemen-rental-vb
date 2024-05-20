Public Class FormBeranda
    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        FormDataBarang.Show()
        Me.Hide()
    End Sub
End Class