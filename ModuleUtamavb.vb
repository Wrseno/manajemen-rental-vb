Imports MySql.Data.MySqlClient

Module ModuleUtamavb
    Public con As String = "server=localhost;user=root;password=;database=rentech_vb;"
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
                barang.status AS Status 
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

    Public Sub addBarang(id As String, nama_barang As String, brand As String,
                         id_kategori As Integer, spesifikasi As String, deskripsi As String, harga As Integer, status As String)
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
            closeDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menyimpan data barang")
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub editBarang(id As String, nama_barang As String, brand As String,
                         id_kategori As Integer, spesifikasi As String, deskripsi As String, harga As Integer, status As String)
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
            .txtIdBarang.Text = ""
            .txtNamaBarang.Text = ""
            .txtBrand.Text = ""
            .cmbKategori.Text = ""
            .txtSpek.Text = ""
            .txtDeskripsi.Text = ""
            .txtHarga.Text = ""
            .cmbStatus.Text = ""
            .txtStok.Text = ""
        End With
    End Sub

    Public Sub deleteBarang(id As String)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "DELETE FROM barang WHERE id=@id"
        sqlCommand.Parameters.AddWithValue("@id", id)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
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

    Public Sub addKategori(id As Integer, nama As String)
        sqlCommand = New MySqlCommand
        sqlCommand.Connection = db
        sqlCommand.CommandText = "INSERT INTO kategori (id, nama) VALUES (@id, @nama)"
        sqlCommand.Parameters.AddWithValue("@id", id)
        sqlCommand.Parameters.AddWithValue("@nama", nama)

        Try
            openDB()
            sqlCommand.ExecuteNonQuery()
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
            .txtNama.Text = ""
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
End Module
