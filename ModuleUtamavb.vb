Imports MySql.Data.MySqlClient

Module ModuleUtamavb
    Public con As String = "server=localhost;user=root;password=;database=rts_vb;"
    Public db As New MySqlConnection(con)
    Public sqlCommand As MySqlCommand
    Public sqlAdapter As MySqlDataAdapter
    Public sqlDataSet As DataSet
    Public sqlReader As MySqlDataReader

    Public Sub openDB()
        Try
            closeDB()
            db.Open()
            'MessageBox.Show("Connection successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Caution" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub closeDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    Public Function getTableBarang() As DataTable
        Dim dataTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("
            SELECT 
                barang.id AS id,
                barang.nama_barang AS Nama, 
                barang.brand AS Brand, 
                kategori.nama AS Kategori, 
                barang.spesifikasi AS Spesifikasi, 
                barang.deskripsi AS Deskripsi, 
                barang.harga AS Harga, 
                barang.status AS Status, 
                barang.stok AS Stok
            FROM 
                barang
            JOIN
                kategori
            ON
                barang.id_kategori = kategori.id
            ORDER BY
                barang.id", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "barang")
            dataTable = sqlDataSet.Tables("barang")

            Return (dataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function

    ' Start Function Tabel Barang
    Public Function getViewBarang(id As String) As DataTable
        Dim viewTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT * FROM barang WHERE id=@id", db)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "barang")
            viewTable = sqlDataSet.Tables("barang")
            Return (viewTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try

    End Function

    Public Function getHargaBarang(id As String) As Integer
        Dim harga_barang As Integer = 0
        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT harga FROM barang WHERE id=@id", db)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlReader = sqlCommand.ExecuteReader()
            If sqlReader.Read Then
                harga_barang = Convert.ToInt32(sqlReader("harga"))
            End If
            sqlReader.Close()
            Return harga_barang
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            closeDB()
        End Try
    End Function

    Public Sub addBarang(id As String, nama_barang As String, brand As String,
                         id_kategori As Integer, spesifikasi As String, deskripsi As String, harga As Integer, status As String, stok As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "INSERT INTO barang (id, nama_barang, brand, id_kategori, spesifikasi, deskripsi, harga, status, stok) 
            VALUES(@id, @nama_barang, @brand, @id_kategori, @spesifikasi, @deskripsi, @harga, @status, @stok)"
        sqlCommand.Parameters.AddWithValue("@id", id)
        sqlCommand.Parameters.AddWithValue("@nama_barang", nama_barang)
        sqlCommand.Parameters.AddWithValue("@brand", brand)
        sqlCommand.Parameters.AddWithValue("@id_kategori", id_kategori)
        sqlCommand.Parameters.AddWithValue("@spesifikasi", spesifikasi)
        sqlCommand.Parameters.AddWithValue("@deskripsi", deskripsi)
        sqlCommand.Parameters.AddWithValue("@harga", harga)
        sqlCommand.Parameters.AddWithValue("@status", status)
        sqlCommand.Parameters.AddWithValue("@stok", stok)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data barang berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menyimpan data barang")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub editBarang(id As String, nama_barang As String, brand As String,
                         id_kategori As Integer, spesifikasi As String, deskripsi As String, harga As Integer, status As String, stok As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "UPDATE barang SET 
                                nama_barang=@nama_barang, brand=@brand, id_kategori=@id_kategori, 
                                spesifikasi=@spesifikasi, deskripsi=@deskripsi, harga=@harga, status=@status, stok=@stok WHERE id=@id"
        sqlCommand.Parameters.AddWithValue("@id", id)
        sqlCommand.Parameters.AddWithValue("@nama_barang", nama_barang)
        sqlCommand.Parameters.AddWithValue("@brand", brand)
        sqlCommand.Parameters.AddWithValue("@id_kategori", id_kategori)
        sqlCommand.Parameters.AddWithValue("@spesifikasi", spesifikasi)
        sqlCommand.Parameters.AddWithValue("@deskripsi", deskripsi)
        sqlCommand.Parameters.AddWithValue("@harga", harga)
        sqlCommand.Parameters.AddWithValue("@status", status)
        sqlCommand.Parameters.AddWithValue("@stok", stok)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data barang berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal mengubah data barang")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub clearBarang()
        With FormDataBarang
            .txtIdBarang.Text = "ID Barang"
            .txtNamaBarang.Text = "Nama Barang"
            .txtBrand.Text = "Brand"
            .cmbKategori.Text = "Kategori"
            .txtSpek.Text = "Spesifikasi"
            .txtDeskripsi.Text = "Deskripsi"
            .txtHarga.Text = "Harga"
            .cmbStatus.Text = "Status"
            .txtStok.Text = "Stok"
        End With
    End Sub

    Public Function getTotalBarang() As Integer
        Dim totalPenyewa As Integer = 0
        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"
        Dim query As String = "SELECT COUNT(DISTINCT id) AS total_barang FROM barang"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    totalPenyewa = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal mendapatkan total barang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return totalPenyewa
    End Function

    Public Function getTotalStokBarang() As Integer
        Dim totalPenyewa As Integer = 0
        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"
        Dim query As String = "SELECT SUM(stok) AS total_stok_barang FROM barang;"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    totalPenyewa = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal mendapatkan total stok barang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return totalPenyewa
    End Function

    Public Sub deleteBarang(id As String)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM barang WHERE id=@id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearBarang()
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data barang")
        Finally
            closeDB()
        End Try
    End Sub
    ' End Function Tabel Barang

    ' Start Function Tabel Kategori
    Public Function getKategori() As DataTable
        Dim dataTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT id, nama FROM kategori ORDER BY nama", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "kategori")
            dataTable = sqlDataSet.Tables("kategori")

            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function

    Public Function getKategoriById(id As String) As DataTable
        Dim viewTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT * FROM kategori WHERE id=@id", db)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "kategori")
            viewTable = sqlDataSet.Tables("kategori")
            Return (viewTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try

    End Function

    Public Sub addKategori(nama As String)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "INSERT INTO kategori (nama) VALUES (@nama)"
        sqlCommand.Parameters.AddWithValue("@nama", nama)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Kategori berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menambah data kategori")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub clearKategori()
        With FormKategori
            .txtIdKategori.Text = ""
            .txtNama.Text = "Nama"
        End With
    End Sub

    Public Sub editKategori(id As Integer, nama As String)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "UPDATE kategori SET nama = @nama WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)
        sqlCommand.Parameters.AddWithValue("@nama", nama)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Kategori berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal mengubah data kategori")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub deleteKategori(id As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM kategori WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Kategori berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearKategori()
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data kategori")
        Finally
            closeDB()
        End Try
    End Sub
    ' End Function Tabel Kategori

    ' Start Function Tabel Peminjam
    Public Function getPeminjam()
        Dim dataTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT 
                            peminjam.id AS ID,
                            peminjam.nama AS Nama,
                            peminjam.alamat AS Alamat,
                            peminjam.no_hp AS 'NomorHp',
                            peminjam.nik AS NIK
                        FROM peminjam 
                        ORDER BY peminjam.id", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "peminjam")
            dataTable = sqlDataSet.Tables("peminjam")

            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function

    Public Function getPeminjamById(id As String) As DataTable
        Dim viewTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT * FROM peminjam WHERE id=@id", db)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "peminjam")
            viewTable = sqlDataSet.Tables("peminjam")
            Return (viewTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try

    End Function

    Public Sub addPeminjam(nama As String, alamat As String, no_hp As String, nik As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "INSERT INTO peminjam (nama, alamat, no_hp, nik) VALUES (@nama, @alamat, @no_hp, @nik)"
        sqlCommand.Parameters.AddWithValue("@nama", nama)
        sqlCommand.Parameters.AddWithValue("@alamat", alamat)
        sqlCommand.Parameters.AddWithValue("@no_hp", no_hp)
        sqlCommand.Parameters.AddWithValue("@nik", nik)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Peminjam berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menambah data penyewa")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub clearPeminjam()
        With FormPeminjam
            .txtName.Text = "Nama"
            .txtAlamat.Text = "Alamat"
            .txtNoHp.Text = "Nomor Hp"
            .txtNik.Text = "NIK"
            .txtIdPeminjam.Text = ""
        End With
    End Sub

    Public Sub editPeminjam(id As Integer, nama As String, alamat As String, no_hp As String, nik As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "UPDATE peminjam SET nama = @nama, alamat = @alamat, no_hp = @no_hp, nik = @nik WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)
        sqlCommand.Parameters.AddWithValue("@nama", nama)
        sqlCommand.Parameters.AddWithValue("@alamat", alamat)
        sqlCommand.Parameters.AddWithValue("@no_hp", no_hp)
        sqlCommand.Parameters.AddWithValue("@nik", nik)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Peminjam berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal mengubah data penyewa")
        Finally
            closeDB()
        End Try
    End Sub

    Public Function getTotalPenyewa() As Integer
        Dim totalPenyewa As Integer = 0
        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"
        Dim query As String = "SELECT COUNT(DISTINCT id_peminjam) AS total_penyewa FROM peminjaman"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    totalPenyewa = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal mendapatkan total penyewa: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return totalPenyewa
    End Function

    Public Sub deletePeminjam(id As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM peminjam WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Peminjam berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearPeminjam()
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data penyewa")
        Finally
            closeDB()
        End Try
    End Sub
    ' End Function Tabel Peminjam

    ' Start Function Penyewaan
    Public Function getPeminjaman()
        Dim dataTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT 
        peminjaman.id AS ID,
        peminjam.nama AS 'Nama Penyewa',
        barang.nama_barang AS 'Nama Barang',
        peminjaman.lama_sewa AS 'Lama Sewa',
        DATE_FORMAT(peminjaman.tgl_pinjam, '%Y-%m-%d') AS 'Tgl Sewa',
        DATE_FORMAT(peminjaman.tgl_harus_kembali, '%Y-%m-%d') AS 'Tgl Harus Kembali',
        peminjaman.dikembalikan AS 'Dikembalikan',
        DATE_FORMAT(peminjaman.tgl_kembali, '%Y-%m-%d') AS 'Tgl Kembali',
        peminjaman.denda AS Denda,
        peminjaman.total_pembayaran AS 'Total Bayar'
    FROM 
        peminjaman
    JOIN 
        peminjam ON peminjaman.id_peminjam = peminjam.id
    JOIN 
        barang ON peminjaman.id_barang = barang.id
    ORDER BY 
        peminjaman.id;
                ", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "peminjaman")
            dataTable = sqlDataSet.Tables("peminjaman")

            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function

    Public Function getPeminjamanById(id As String) As DataTable
        Dim viewTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT * FROM peminjaman WHERE id=@id", db)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "peminjaman")
            viewTable = sqlDataSet.Tables("peminjaman")
            Return (viewTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try

    End Function

    Private Function CekKetersediaanBarang(idBarang As String) As Boolean
        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"
        Dim available As Boolean = False

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT status, stok FROM barang WHERE id = @idBarang"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idBarang", idBarang)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim status As String = reader("status").ToString()
                            Dim stok As Integer = Convert.ToInt32(reader("stok"))

                            ' Periksa status dan stok barang
                            If status = "Tersedia" AndAlso stok > 0 Then
                                available = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return available
    End Function


    Public Sub addPeminjaman(id_peminjam As Integer, id_barang As String, lama_sewa As Integer, tgl_pinjam As String, tgl_harus_kembali As String, dikembalikan As String, tgl_kembali As String, denda As String, total_pembayaran As String)
        If Not CekKetersediaanBarang(id_barang) Then
            MessageBox.Show("Barang tidak tersedia untuk disewa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Memulai transaksi
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Tambahkan data penyewaan ke tabel peminjaman
                        Dim insertQuery As String = "INSERT INTO peminjaman (id_peminjam, id_barang, lama_sewa, tgl_pinjam, tgl_harus_kembali, dikembalikan, tgl_kembali, denda, total_pembayaran) 
                                                 VALUES (@id_peminjam, @id_barang, @lama_sewa, @tgl_pinjam, @tgl_harus_kembali, @dikembalikan, @tgl_kembali, @denda, @total_pembayaran)"
                        Using cmd As New MySqlCommand(insertQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@id_peminjam", id_peminjam)
                            cmd.Parameters.AddWithValue("@id_barang", id_barang)
                            cmd.Parameters.AddWithValue("@lama_sewa", lama_sewa)
                            cmd.Parameters.AddWithValue("@tgl_pinjam", tgl_pinjam)
                            cmd.Parameters.AddWithValue("@tgl_harus_kembali", tgl_harus_kembali)
                            cmd.Parameters.AddWithValue("@dikembalikan", dikembalikan)
                            cmd.Parameters.AddWithValue("@tgl_kembali", tgl_kembali)
                            cmd.Parameters.AddWithValue("@denda", denda)
                            cmd.Parameters.AddWithValue("@total_pembayaran", total_pembayaran)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Kurangi stok barang
                        Dim updateQuery As String = "UPDATE barang SET stok = stok - 1 WHERE id = @idBarang"
                        Using cmd As New MySqlCommand(updateQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@idBarang", id_barang)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Commit transaksi
                        transaction.Commit()
                        MessageBox.Show("Penyewaan berhasil ditambahkan dan stok barang dikurangi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        ' Rollback transaksi jika terjadi kesalahan
                        transaction.Rollback()
                        MessageBox.Show("Terjadi kesalahan saat menambah penyewaan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub clearPeminjaman()
        With FormPeminjaman
            .cmbPeminjam.Text = "Penyewa"
            .cmbBarang.Text = "Nama Barang"
            .txtTglPinjam.Text = "Tanggal Sewa (yyyy-mm-dd)"
            .txtTglHrsKembali.Text = "Tanggal Hrs Kembali (yyyy-mm-dd)"
            .cmbDikembalikan.Text = "Dikembalikan"
            .txtTglKembali.Text = "Tanggal Kembali (yyyy-mm-dd)"
            .txtDenda.Text = "Denda"
            .txtTotalBayar.Text = "Total Bayar"
            .txtIdPenyewaan.Text = ""
            .txtLamaSewa.Text = "Lama Sewa"
        End With
    End Sub

    Public Sub editPeminjaman(id As Integer, id_peminjam As Integer, id_barang As String, lama_sewa As Integer, tgl_pinjam As String, tgl_harus_kembali As String, dikembalikan As String,
                           tgl_kembali As String, denda As String, total_pembayaran As String)
        If Not CekKetersediaanBarang(id_barang) Then
            MessageBox.Show("Barang tidak tersedia untuk disewa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Memulai transaksi
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Tambahkan data penyewaan ke tabel peminjaman
                        Dim insertQuery As String = "UPDATE peminjaman SET id_peminjam = @id_peminjam, id_barang = @id_barang, lama_sewa = @lama_sewa, tgl_pinjam = @tgl_pinjam, tgl_harus_kembali = @tgl_harus_kembali, 
dikembalikan = @dikembalikan, tgl_kembali = @tgl_kembali, denda = @denda, total_pembayaran = @total_pembayaran WHERE id = @id"
                        Using cmd As New MySqlCommand(insertQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@id_peminjam", id_peminjam)
                            cmd.Parameters.AddWithValue("@id_barang", id_barang)
                            cmd.Parameters.AddWithValue("@lama_sewa", lama_sewa)
                            cmd.Parameters.AddWithValue("@tgl_pinjam", tgl_pinjam)
                            cmd.Parameters.AddWithValue("@tgl_harus_kembali", tgl_harus_kembali)
                            cmd.Parameters.AddWithValue("@dikembalikan", dikembalikan)
                            cmd.Parameters.AddWithValue("@tgl_kembali", tgl_kembali)
                            cmd.Parameters.AddWithValue("@denda", denda)
                            cmd.Parameters.AddWithValue("@total_pembayaran", total_pembayaran)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using

                        If dikembalikan.ToLower() = "sudah" Then
                            Dim updateStockQuery As String = "UPDATE barang SET stok = stok + 1 WHERE id = @id_barang"
                            Using cmd As New MySqlCommand(updateStockQuery, conn, transaction)
                                cmd.Parameters.AddWithValue("@id_barang", id_barang)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If

                        ' Commit transaksi
                        transaction.Commit()
                        MessageBox.Show("Penyewaan berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        ' Rollback transaksi jika terjadi kesalahan
                        transaction.Rollback()
                        MessageBox.Show("Terjadi kesalahan saat menambah penyewaan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub deletePeminjaman(id As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM peminjaman WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            clearPeminjaman()
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data penyewaan")
        Finally
            closeDB()
        End Try
    End Sub
    ' End Function Penyewaan

    ' Start Function Laporan
    Public Function getLaporan()
        Dim dataTable As DataTable

        Try
            openDB()
            sqlCommand = New MySqlCommand("SELECT
                laporan_bulanan.id AS ID,
                laporan_bulanan.tanggal AS Tanggal,
                laporan_bulanan.jmlh_peminjam AS 'Jml Penyewa',
                laporan_bulanan.jmlh_barang_disewa AS 'Jml Barang Disewa',
                laporan_bulanan.barang_favorit AS 'Tersewa Banyak',
                laporan_bulanan.biaya_perbaikan AS 'Biaya Perbaikan',
                laporan_bulanan.total_pendapatan AS 'Total Pendapatan'
            FROM laporan_bulanan
            ORDER BY laporan_bulanan.id;
                ", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "laporan_bulanan")
            dataTable = sqlDataSet.Tables("laporan_bulanan")

            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function

    Public Sub GenerateMonthlyReport()
        Dim connectionString As String = "server=localhost;user=root;password=;database=rts_vb;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Menjalankan query untuk mendapatkan data laporan bulanan
                Dim jmlhPeminjam As Integer
                Dim jmlhBarangDisewa As Integer
                Dim barangFavorit As String
                Dim totalPendapatan As Decimal

                ' Query jumlah peminjam
                Using cmd As New MySqlCommand("SELECT COUNT(DISTINCT id_peminjam) FROM peminjaman WHERE MONTH(tgl_pinjam) = MONTH(CURRENT_DATE()) AND YEAR(tgl_pinjam) = YEAR(CURRENT_DATE())", conn)
                    jmlhPeminjam = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Query jumlah barang disewa
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM peminjaman WHERE MONTH(tgl_pinjam) = MONTH(CURRENT_DATE()) AND YEAR(tgl_pinjam) = YEAR(CURRENT_DATE())", conn)
                    jmlhBarangDisewa = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Query barang favorit
                Using cmd As New MySqlCommand("SELECT nama_barang FROM barang WHERE id = (SELECT id_barang FROM peminjaman WHERE MONTH(tgl_pinjam) = MONTH(CURRENT_DATE()) AND YEAR(tgl_pinjam) = YEAR(CURRENT_DATE()) GROUP BY id_barang ORDER BY COUNT(id_barang) DESC LIMIT 1)", conn)
                    barangFavorit = cmd.ExecuteScalar().ToString()
                End Using

                ' Query total pendapatan
                Using cmd As New MySqlCommand("SELECT SUM(total_pembayaran) FROM peminjaman WHERE MONTH(tgl_pinjam) = MONTH(CURRENT_DATE()) AND YEAR(tgl_pinjam) = YEAR(CURRENT_DATE())", conn)
                    totalPendapatan = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using

                ' Insert data ke tabel laporan_bulanan
                Using cmd As New MySqlCommand("INSERT INTO laporan_bulanan (tanggal, jmlh_peminjam, jmlh_barang_disewa, barang_favorit, biaya_perbaikan, total_pendapatan) VALUES (CURRENT_DATE(), @jmlh_peminjam, @jmlh_barang_disewa, @barang_favorit, @biaya_perbaikan, @total_pendapatan)", conn)
                    cmd.Parameters.AddWithValue("@jmlh_peminjam", jmlhPeminjam)
                    cmd.Parameters.AddWithValue("@jmlh_barang_disewa", jmlhBarangDisewa)
                    cmd.Parameters.AddWithValue("@barang_favorit", barangFavorit)
                    cmd.Parameters.AddWithValue("@biaya_perbaikan", 0) ' Misalkan biaya perbaikan tidak ada
                    cmd.Parameters.AddWithValue("@total_pendapatan", totalPendapatan)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Laporan bulanan berhasil dibuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub deleteLaporan(id As Integer)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM laporan_bulanan WHERE id = @id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data laporan")
        Finally
            closeDB()
        End Try
    End Sub
    ' End Function Laporan
End Module
