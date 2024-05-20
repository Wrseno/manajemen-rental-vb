Public Class FormDataBarang
    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNamaBarang.Text = "Nama Barang"
        txtNamaBarang.ForeColor = Color.DarkGray
        txtBrand.Text = "Brand"
        txtBrand.ForeColor = Color.DarkGray
        txtDeskripsi.Text = "Deskripsi"
        txtDeskripsi.ForeColor = Color.DarkGray
        txtHarga.Text = "Harga"
        txtHarga.ForeColor = Color.DarkGray
        txtSpek.Text = "Spesifikasi"
        txtSpek.ForeColor = Color.DarkGray

        DataGridView1.DataSource = getTableBarang()
    End Sub

    Private Sub txtNamaBarang_GotFocus(sender As Object, e As EventArgs) Handles txtNamaBarang.GotFocus
        If txtNamaBarang.Text = "Nama Barang" Then
            txtNamaBarang.Text = ""
            txtNamaBarang.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNamaBarang_LostFocus(sender As Object, e As EventArgs) Handles txtNamaBarang.LostFocus
        If txtNamaBarang.Text = "" Then
            txtNamaBarang.Text = "Nama Barang"
            txtNamaBarang.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtBrand_GotFocus(sender As Object, e As EventArgs) Handles txtBrand.GotFocus
        If txtBrand.Text = "Brand" Then
            txtBrand.Text = ""
            txtBrand.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBrand_LostFocus(sender As Object, e As EventArgs) Handles txtBrand.LostFocus
        If txtBrand.Text = "" Then
            txtBrand.Text = "Brand"
            txtBrand.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtHarga_GotFocus(sender As Object, e As EventArgs) Handles txtHarga.GotFocus
        If txtHarga.Text = "Harga" Then
            txtHarga.Text = ""
            txtHarga.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtHarga_LostFocus(sender As Object, e As EventArgs) Handles txtHarga.LostFocus
        If txtHarga.Text = "" Then
            txtHarga.Text = "Harga"
            txtHarga.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtSpek_GotFocus(sender As Object, e As EventArgs) Handles txtSpek.GotFocus
        If txtSpek.Text = "Spesifikasi" Then
            txtSpek.Text = ""
            txtSpek.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSpek_LostFocus(sender As Object, e As EventArgs) Handles txtSpek.LostFocus
        If txtSpek.Text = "" Then
            txtSpek.Text = "Spesifikasi"
            txtSpek.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtDesk_GotFocus(sender As Object, e As EventArgs) Handles txtDeskripsi.GotFocus
        If txtDeskripsi.Text = "Deskripsi" Then
            txtDeskripsi.Text = ""
            txtDeskripsi.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDesk_LostFocus(sender As Object, e As EventArgs) Handles txtDeskripsi.LostFocus
        If txtDeskripsi.Text = "" Then
            txtDeskripsi.Text = "Deskripsi"
            txtDeskripsi.ForeColor = Color.DarkGray
        End If
    End Sub
End Class