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
            MessageBox.Show("Connection successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            sqlCommand = New MySqlCommand("select * from barang order by id", db)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet

            sqlAdapter.Fill(sqlDataSet, "barang")
            dataTable = sqlDataSet.Tables("barang")

            dataTable.Columns("id").ColumnName = "ID"
            dataTable.Columns("nama_barang").ColumnName = "Nama"
            dataTable.Columns("brand").ColumnName = "Brand"
            dataTable.Columns("id_kategori").ColumnName = "Kategori"
            dataTable.Columns("spesifikasi").ColumnName = "Spesifikasi"
            dataTable.Columns("deskripsi").ColumnName = "Deskripsi"
            dataTable.Columns("harga").ColumnName = "Harga"
            dataTable.Columns("status").ColumnName = "Status"

            Return (dataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closeDB()
        End Try
    End Function
End Module
