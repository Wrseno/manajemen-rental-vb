Public Class FormKategori
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdKategori.Text = "ID Kategori"
        txtIdKategori.ForeColor = Color.DarkGray
        txtNama.Text = "Nama"
        txtNama.ForeColor = Color.DarkGray

        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub txtIdKategori_GotFocus(sender As Object, e As EventArgs) Handles txtIdKategori.GotFocus
        If txtIdKategori.Text = "ID Kategori" Then
            txtIdKategori.Text = ""
            txtIdKategori.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtIdKategori_LostFocus(sender As Object, e As EventArgs) Handles txtIdKategori.LostFocus
        If txtIdKategori.Text = "" Then
            txtIdKategori.Text = "ID Kategori"
            txtIdKategori.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtNama_GotFocus(sender As Object, e As EventArgs) Handles txtNama.GotFocus
        If txtNama.Text = "Nama" Then
            txtNama.Text = ""
            txtNama.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNama_LostFocus(sender As Object, e As EventArgs) Handles txtNama.LostFocus
        If txtNama.Text = "" Then
            txtNama.Text = "Nama"
            txtNama.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtIdKategori.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtNama.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        Try
            addKategori(txtIdKategori.Text, txtNama.Text)
            MessageBox.Show("Kategori berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        clearKategori()
        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Dim idKategori = txtIdKategori.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data kategori '" & txtNama.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idKategori) Then
            MessageBox.Show("Kategori tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                editKategori(idKategori, txtNama.Text)
                MessageBox.Show("Kategori berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub picClear_Click(sender As Object, e As EventArgs) Handles picClear.Click
        clearBarang()
        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Dim idKategori = txtIdKategori.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data kategori '" & txtNama.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idKategori) Then
            MessageBox.Show("Kategori tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                deleteKategori(idKategori)
                MessageBox.Show("Kategori berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getKategori()
    End Sub

    Private Sub picReturn_Click(sender As Object, e As EventArgs) Handles picReturn.Click
        FormBeranda.Show()
        Me.Close()
    End Sub
End Class