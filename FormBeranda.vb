Public Class FormBeranda
    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        FormDataBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnKategori_Click(sender As Object, e As EventArgs) Handles btnKategori.Click
        FormKategori.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class