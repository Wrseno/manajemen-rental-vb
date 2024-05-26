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
        Form1.Close()
    End Sub

    Private Sub FormBeranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPenyewa.Text = getTotalPenyewa()
        lblTotalBarang.Text = getTotalBarang()
        lblTotalStokBarang.Text = getTotalStokBarang()
    End Sub

    Private Sub btnPeminjam_Click(sender As Object, e As EventArgs) Handles btnPeminjam.Click
        FormPeminjam.Show()
        Me.Hide()
    End Sub

    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        FormPeminjaman.Show
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLaporanBulanan.Show()
        Me.Hide()
    End Sub
End Class