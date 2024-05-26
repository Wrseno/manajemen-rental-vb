Public Class FormDataBarang
    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdBarang.Text = "ID Barang"
        txtIdBarang.ForeColor = Color.DarkGray
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
        cmbStatus.Text = "Status"
        cmbStatus.ForeColor = Color.DarkGray
        cmbKategori.Text = "Kategori"
        cmbKategori.ForeColor = Color.DarkGray
        txtStok.Text = "Stok"
        txtStok.ForeColor = Color.DarkGray

        DataGridView1.DataSource = getTableBarang()

        LoadKategoriComboBox()
    End Sub

    Private Sub txtIdBarang_GotFocus(sender As Object, e As EventArgs) Handles txtIdBarang.GotFocus
        If txtIdBarang.Text = "ID Barang" Then
            txtIdBarang.Text = ""
            txtIdBarang.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtIdBarang_LostFocus(sender As Object, e As EventArgs) Handles txtIdBarang.LostFocus
        If txtIdBarang.Text = "" Then
            txtIdBarang.Text = "ID Barang"
            txtIdBarang.ForeColor = Color.DarkGray
        End If
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

    Private Sub cmbStatus_GotFocus(sender As Object, e As EventArgs) Handles cmbStatus.GotFocus
        If cmbStatus.Text = "Status" Then
            cmbStatus.Text = ""
            cmbStatus.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbStatus_LostFocus(sender As Object, e As EventArgs) Handles cmbStatus.LostFocus
        If cmbStatus.Text = "" Then
            cmbStatus.Text = "Status"
            cmbStatus.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub cmbKategori_GotFocus(sender As Object, e As EventArgs) Handles cmbKategori.GotFocus
        If cmbKategori.Text = "Status" Then
            cmbKategori.Text = ""
            cmbKategori.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbKategori_LostFocus(sender As Object, e As EventArgs) Handles cmbKategori.LostFocus
        If cmbKategori.Text = "" Then
            cmbKategori.Text = "Status"
            cmbKategori.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtStok_GotFocus(sender As Object, e As EventArgs) Handles txtStok.GotFocus
        If txtStok.Text = "Stok" Then
            txtStok.Text = ""
            txtStok.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtStok_LostFocus(sender As Object, e As EventArgs) Handles txtStok.LostFocus
        If txtStok.Text = "" Then
            txtStok.Text = "Stok"
            txtStok.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtIdBarang.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtNamaBarang.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtBrand.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        cmbKategori.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtSpek.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
        txtDeskripsi.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString
        txtHarga.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString
        cmbStatus.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value.ToString
        txtStok.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub LoadKategoriComboBox()
        Dim dataTable As DataTable = getKategori()

        If dataTable IsNot Nothing Then
            cmbKategori.DataSource = dataTable
            cmbKategori.DisplayMember = "nama"
            cmbKategori.ValueMember = "id"
            cmbKategori.SelectedIndex = -1
            cmbKategori.Text = "Kategori"
        Else
            cmbKategori.DataSource = Nothing
            cmbKategori.Text = "Kategori"
        End If
    End Sub

    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        Try
            Dim idKategori As Integer = CInt(cmbKategori.SelectedValue)
            addBarang(txtIdBarang.Text, txtNamaBarang.Text, txtBrand.Text, idKategori,
                      txtSpek.Text, txtDeskripsi.Text, CInt(txtHarga.Text), cmbStatus.SelectedItem.ToString(), CInt(txtStok.Text))
        Catch ex As InvalidCastException
            MessageBox.Show("Pilih kategori yang valid.", "Input tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTableBarang()
    End Sub

    Private Sub picReturn_Click(sender As Object, e As EventArgs) Handles picReturn.Click
        FormBeranda.Show()
        Me.Close()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Dim idBarang As String = txtIdBarang.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data barang '" & txtNamaBarang.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idBarang) Then
            MessageBox.Show("Barang tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                Dim idKategori As Integer = CInt(cmbKategori.SelectedValue)
                editBarang(idBarang, txtNamaBarang.Text, txtBrand.Text, idKategori,
                        txtSpek.Text, txtDeskripsi.Text, CInt(txtHarga.Text), cmbStatus.SelectedItem.ToString(), CInt(txtStok.Text))
            Catch ex As InvalidCastException
                MessageBox.Show("Pilih kategori yang valid.", "Input tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If


        DataGridView1.DataSource = getTableBarang()
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        DataGridView1.DataSource = getViewBarang(txtIdBarang.Text)
    End Sub

    Private Sub picClear_Click(sender As Object, e As EventArgs) Handles picClear.Click
        clearBarang()
        DataGridView1.DataSource = getTableBarang()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Dim idBarang As String = txtIdBarang.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data barang '" & txtNamaBarang.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idBarang) Then
            MessageBox.Show("Barang tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                deleteBarang(idBarang)
                DataGridView1.DataSource = getTableBarang()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class