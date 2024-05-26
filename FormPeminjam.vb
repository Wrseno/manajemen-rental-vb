Public Class FormPeminjam
    Private Sub FormPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = "Nama"
        txtName.ForeColor = Color.DarkGray
        txtAlamat.Text = "Alamat"
        txtAlamat.ForeColor = Color.DarkGray
        txtNoHp.Text = "Nomor Hp"
        txtNoHp.ForeColor = Color.DarkGray
        txtNik.Text = "NIK"
        txtNik.ForeColor = Color.DarkGray

        DataGridView1.DataSource = getPeminjam()
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        If txtName.Text = "Nama" Then
            txtName.Text = ""
            txtName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        If txtName.Text = "" Then
            txtName.Text = "Nama"
            txtName.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtAlamat_GotFocus(sender As Object, e As EventArgs) Handles txtAlamat.GotFocus
        If txtAlamat.Text = "Alamat" Then
            txtAlamat.Text = ""
            txtAlamat.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAlamat_LostFocus(sender As Object, e As EventArgs) Handles txtAlamat.LostFocus
        If txtAlamat.Text = "" Then
            txtAlamat.Text = "Alamat"
            txtAlamat.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtNoHp_GotFocus(sender As Object, e As EventArgs) Handles txtNoHp.GotFocus
        If txtNoHp.Text = "Nomor Hp" Then
            txtNoHp.Text = ""
            txtNoHp.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNoHp_LostFocus(sender As Object, e As EventArgs) Handles txtNoHp.LostFocus
        If txtNoHp.Text = "" Then
            txtNoHp.Text = "Nomor Hp"
            txtNoHp.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtNik_GotFocus(sender As Object, e As EventArgs) Handles txtNik.GotFocus
        If txtNik.Text = "NIK" Then
            txtNik.Text = ""
            txtNik.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNik_LostFocus(sender As Object, e As EventArgs) Handles txtNik.LostFocus
        If txtNik.Text = "" Then
            txtNik.Text = "NIK"
            txtNik.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtIdPeminjam.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtName.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtAlamat.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txtNoHp.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtNik.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        Try
            addPeminjam(txtName.Text, txtAlamat.Text, txtNoHp.Text, txtNik.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getPeminjam()
    End Sub

    Private Sub picClear_Click(sender As Object, e As EventArgs) Handles picClear.Click
        clearPeminjam()
        DataGridView1.DataSource = getPeminjam()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Dim idPeminjam = txtIdPeminjam.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data peminjam '" & txtName.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idPeminjam) Then
            MessageBox.Show("Peminjam tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                editPeminjam(idPeminjam, txtName.Text, txtAlamat.Text, txtNoHp.Text, txtNik.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getPeminjam()
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        DataGridView1.DataSource = getPeminjamById(txtIdPeminjam.Text)
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Dim idPeminjam = txtIdPeminjam.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data peminjam '" & txtName.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idPeminjam) Then
            MessageBox.Show("Peminjam tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                deletePeminjam(idPeminjam)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getPeminjam()
    End Sub

    Private Sub picReturn_Click(sender As Object, e As EventArgs) Handles picReturn.Click
        FormBeranda.Show()
        Me.Close()
    End Sub
End Class