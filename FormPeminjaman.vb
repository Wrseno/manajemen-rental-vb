Imports System.Globalization

Public Class FormPeminjaman

    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTglPinjam.Text = "Tanggal Sewa (yyyy-mm-dd)"
        txtTglPinjam.ForeColor = Color.DarkGray
        txtTglHrsKembali.Text = "Tanggal Hrs Kembali (yyyy-mm-dd)"
        txtTglHrsKembali.ForeColor = Color.DarkGray
        cmbDikembalikan.Text = "Dikembalikan"
        cmbDikembalikan.ForeColor = Color.DarkGray
        txtTglKembali.Text = "Tanggal Kembali (yyyy-mm-dd)"
        txtTglKembali.ForeColor = Color.DarkGray
        txtDenda.Text = "Denda"
        txtDenda.ForeColor = Color.DarkGray
        txtTotalBayar.Text = "Total Bayar"
        txtTotalBayar.ForeColor = Color.DarkGray
        txtLamaSewa.Text = "Lama Sewa"
        txtLamaSewa.ForeColor = Color.DarkGray
        cmbBarang.ForeColor = Color.DarkGray
        cmbPeminjam.ForeColor = Color.DarkGray

        DataGridView1.DataSource = getPeminjaman()
        LoadBarangComboBox()
        LoadPeminjamComboBox()
    End Sub

    Private Sub txtTglPinjam_GotFocus(sender As Object, e As EventArgs) Handles txtTglPinjam.GotFocus
        If txtTglPinjam.Text = "Tanggal Sewa (yyyy-mm-dd)" Then
            txtTglPinjam.Text = ""
            txtTglPinjam.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTglPinjam_LostFocus(sender As Object, e As EventArgs) Handles txtTglPinjam.LostFocus
        If txtTglPinjam.Text = "" Then
            txtTglPinjam.Text = "Tanggal Sewa (yyyy-mm-dd)"
            txtTglPinjam.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtHrsKembali_GotFocus(sender As Object, e As EventArgs) Handles txtTglHrsKembali.GotFocus
        If txtTglHrsKembali.Text = "Tanggal Hrs Kembali (yyyy-mm-dd)" Then
            txtTglHrsKembali.Text = ""
            txtTglHrsKembali.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTglHrsKembali_LostFocus(sender As Object, e As EventArgs) Handles txtTglHrsKembali.LostFocus
        If txtTglHrsKembali.Text = "" Then
            txtTglHrsKembali.Text = "Tanggal Hrs Kembali (yyyy-mm-dd)"
            txtTglHrsKembali.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtTglKembali_GotFocus(sender As Object, e As EventArgs) Handles txtTglKembali.GotFocus
        If txtTglKembali.Text = "Tanggal Kembali (yyyy-mm-dd)" Then
            txtTglKembali.Text = ""
            txtTglKembali.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTglKembali_LostFocus(sender As Object, e As EventArgs) Handles txtTglKembali.LostFocus
        If txtTglKembali.Text = "" Then
            txtTglKembali.Text = "Tanggal Kembali (yyyy-mm-dd)"
            txtTglKembali.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub cmbDikembalikan_GotFocus(sender As Object, e As EventArgs) Handles cmbDikembalikan.GotFocus
        If cmbDikembalikan.Text = "Dikembalikan" Then
            cmbDikembalikan.Text = ""
            cmbDikembalikan.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbDikembalikan_LostFocus(sender As Object, e As EventArgs) Handles cmbDikembalikan.LostFocus
        If cmbDikembalikan.Text = "" Then
            cmbDikembalikan.Text = "Dikembalikan"
            cmbDikembalikan.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtDenda_GotFocus(sender As Object, e As EventArgs) Handles txtDenda.GotFocus
        If txtDenda.Text = "Denda" Then
            txtDenda.Text = ""
            txtDenda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDenda_LostFocus(sender As Object, e As EventArgs) Handles txtDenda.LostFocus
        If txtDenda.Text = "" Then
            txtDenda.Text = "Denda"
            txtDenda.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtLamaSewa_GotFocus(sender As Object, e As EventArgs) Handles txtLamaSewa.GotFocus
        If txtLamaSewa.Text = "Lama Sewa" Then
            txtLamaSewa.Text = ""
            txtLamaSewa.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLamaSewa_LostFocus(sender As Object, e As EventArgs) Handles txtLamaSewa.LostFocus
        If txtLamaSewa.Text = "" Then
            txtLamaSewa.Text = "Lama Sewa"
            txtLamaSewa.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtTotalBayar_GotFocus(sender As Object, e As EventArgs) Handles txtTotalBayar.GotFocus
        If txtTotalBayar.Text = "Total Bayar" Then
            txtTotalBayar.Text = ""
            txtTotalBayar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTotalBayar_LostFocus(sender As Object, e As EventArgs) Handles txtTotalBayar.LostFocus
        If txtTotalBayar.Text = "" Then
            txtTotalBayar.Text = "Total Bayar"
            txtTotalBayar.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtIdPenyewaan.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        cmbPeminjam.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        cmbBarang.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txtLamaSewa.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtTglPinjam.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
        txtTglHrsKembali.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString
        cmbDikembalikan.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString
        txtTglKembali.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value.ToString
        txtDenda.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value.ToString
        txtTotalBayar.Text = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub LoadPeminjamComboBox()
        Dim dataTable As DataTable = getPeminjam()

        If dataTable IsNot Nothing Then
            cmbPeminjam.DataSource = dataTable
            cmbPeminjam.DisplayMember = "nama"
            cmbPeminjam.ValueMember = "id"
            cmbPeminjam.SelectedIndex = -1
            cmbPeminjam.Text = "Penyewa"
        Else
            cmbPeminjam.DataSource = Nothing
            cmbPeminjam.Text = "Penyewa"
        End If
    End Sub

    Private Sub LoadBarangComboBox()
        Dim dataTable As DataTable = getTableBarang()

        If dataTable IsNot Nothing Then
            cmbBarang.DataSource = dataTable
            cmbBarang.DisplayMember = "Nama"
            cmbBarang.ValueMember = "id"
            cmbBarang.SelectedIndex = -1
            cmbBarang.Text = "Nama Barang"
        Else
            cmbBarang.DataSource = Nothing
            cmbBarang.Text = "Nama Barang"
        End If
    End Sub


    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        Try
            addPeminjaman(cmbPeminjam.SelectedValue, cmbBarang.SelectedValue, CInt(txtLamaSewa.Text), txtTglPinjam.Text, txtTglHrsKembali.Text, cmbDikembalikan.SelectedItem, txtTglKembali.Text, txtDenda.Text, txtTotalBayar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getPeminjaman()
    End Sub

    Public Function ParseDate(dateString As String) As DateTime
        Dim parsedDate As DateTime
        Dim format As String = "yyyy-MM-dd"
        If DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
            Return parsedDate
        Else
            Throw New FormatException("Tanggal tidak dikenali sebagai format yang valid (yyyy-MM-dd).")
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarang.SelectedIndexChanged
        txtTotalBayar.Text = "0"
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Try
            editPeminjaman(txtIdPenyewaan.Text, cmbPeminjam.SelectedValue, cmbBarang.SelectedValue, CInt(txtLamaSewa.Text), txtTglPinjam.Text, txtTglHrsKembali.Text, cmbDikembalikan.SelectedItem, txtTglKembali.Text, txtDenda.Text, txtTotalBayar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getPeminjaman()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Dim tglPinjam As DateTime = ParseDate(txtTglPinjam.Text)
            Dim lamaSewa As Integer = CInt(txtLamaSewa.Text)

            Dim tglHarusDikembalikan As DateTime = DateTime.ParseExact(tglPinjam.AddDays(lamaSewa).ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture)
            Dim tglHarusDikembalikanFormatted As String = tglHarusDikembalikan.ToString("yyyy-MM-dd")

            Dim denda As Integer = 0
            txtDenda.Text = denda

            Dim dateHrsKembali As DateTime = DateTime.ParseExact(tglHarusDikembalikanFormatted, "yyyy-MM-dd", CultureInfo.InvariantCulture)
            Dim dateDikembalikan As DateTime = DateTime.ParseExact(txtTglKembali.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture)

            If dateDikembalikan > dateHrsKembali Then
                Dim daysLate As Integer = (dateDikembalikan - dateHrsKembali).Days
                denda = daysLate * 2000
                txtDenda.Text = denda
            End If

            Dim hargaBarang As Integer = getHargaBarang(cmbBarang.SelectedValue)

            Dim totalHarga As Integer = hargaBarang * lamaSewa + denda
            txtTotalBayar.Text = totalHarga
        Catch ex As FormatException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub picCalendar_Click(sender As Object, e As EventArgs) Handles picCalendar.Click
        txtTglPinjam.Text = DateTime.Now.ToString("yyyy-MM-dd")

        Dim tglPinjam As DateTime = ParseDate(txtTglPinjam.Text)
        Dim lamaSewa As Integer = CInt(txtLamaSewa.Text)

        Dim tglHarusDikembalikan As DateTime = DateTime.ParseExact(tglPinjam.AddDays(lamaSewa).ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim tglHarusDikembalikanFormatted As String = tglHarusDikembalikan.ToString("yyyy-MM-dd")

        txtTglHrsKembali.Text = tglHarusDikembalikanFormatted
        txtTglKembali.Text = tglHarusDikembalikanFormatted
    End Sub

    Private Sub picReturn_Click(sender As Object, e As EventArgs) Handles picReturn.Click
        Me.Close()
        FormBeranda.Show()
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        DataGridView1.DataSource = getPeminjamanById(txtIdPenyewaan.Text)
    End Sub

    Private Sub picClear_Click(sender As Object, e As EventArgs) Handles picClear.Click
        clearPeminjaman()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Dim idPenyewa = txtIdPenyewaan.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data penyewa '" & cmbPeminjam.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idPenyewa) Then
            MessageBox.Show("Penyewa tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                deletePeminjaman(idPenyewa)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getPeminjaman()
    End Sub
End Class