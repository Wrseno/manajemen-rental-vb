Imports System.Drawing.Printing
Imports System.Text

Public Class FormLaporanBulanan
    Private Sub FormLaporanBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = getLaporan()
    End Sub

    Private WithEvents printDocument1 As New PrintDocument()
    Private printDialog1 As New PrintDialog()

    Private Sub printDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim printFont As New Font("Arial", 8)
        Dim headerFont As New Font("Arial", 8, FontStyle.Bold)
        Dim titleFont As New Font("Arial", 10, FontStyle.Bold)
        Dim rowPosition As Integer = e.MarginBounds.Top
        Dim columnPosition As Integer = e.MarginBounds.Left
        Dim rowHeight As Integer = 20
        Dim columnWidths(DataGridView1.Columns.Count - 1) As Integer
        Dim headerHeight As Integer = rowHeight * 2 ' Adjust this based on the expected number of lines for header
        Dim cellPadding As Integer = 5 ' Padding for each cell

        ' Menghitung lebar kolom berdasarkan lebar DataGridView
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            columnWidths(i) = DataGridView1.Columns(i).Width
        Next

        ' Menambah teks "Laporan Bulanan"
        e.Graphics.DrawString("Laporan Penyewaan - RenTech Solutions", titleFont, Brushes.Black, columnPosition, rowPosition)
        rowPosition += titleFont.Height + 10 ' Menambahkan tinggi font judul ditambah jarak

        ' Cetak header kolom dengan latar belakang dan membungkus teks header
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            ' Menggambar latar belakang header
            Dim headerRect As New Rectangle(columnPosition, rowPosition, columnWidths(i), headerHeight)
            e.Graphics.FillRectangle(Brushes.LightGray, headerRect)

            ' Menggambar teks header yang dibungkus dan ditengah
            DrawWrappedText(e.Graphics, DataGridView1.Columns(i).HeaderText, headerFont, Brushes.Black, headerRect)

            columnPosition += columnWidths(i)
        Next

        rowPosition += headerHeight
        columnPosition = e.MarginBounds.Left

        ' Cetak baris data
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                For i As Integer = 0 To DataGridView1.Columns.Count - 1
                    ' Menggambar teks isi yang ditengah dengan padding
                    Dim cellRect As New Rectangle(columnPosition + cellPadding, rowPosition + cellPadding, columnWidths(i) - (2 * cellPadding), rowHeight - (2 * cellPadding))
                    DrawCenteredText(e.Graphics, row.Cells(i).Value?.ToString(), printFont, Brushes.Black, cellRect)
                    columnPosition += columnWidths(i)
                Next
                rowPosition += rowHeight
                columnPosition = e.MarginBounds.Left
            End If
        Next
    End Sub

    Private Sub DrawWrappedText(graphics As Graphics, text As String, font As Font, brush As Brush, rect As Rectangle)
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center ' Mengatur teks ke tengah secara horizontal
        format.LineAlignment = StringAlignment.Center ' Mengatur teks ke tengah secara vertikal
        format.Trimming = StringTrimming.Word

        Dim textSize As SizeF = graphics.MeasureString(text, font, rect.Width, format)
        Dim lines As New List(Of String)()
        Dim currentLine As New StringBuilder()

        For Each word In text.Split(" "c)
            If graphics.MeasureString(currentLine.ToString() & " " & word, font).Width > rect.Width Then
                lines.Add(currentLine.ToString())
                currentLine.Clear()
            End If
            currentLine.Append(word & " ")
        Next
        lines.Add(currentLine.ToString())

        Dim lineHeight As Single = graphics.MeasureString("A", font).Height
        Dim totalHeight As Single = lines.Count * lineHeight
        Dim yOffset As Single = (rect.Height - totalHeight) / 2

        For Each line In lines
            Dim lineRect As New RectangleF(rect.X, rect.Y + yOffset, rect.Width, lineHeight)
            graphics.DrawString(line, font, brush, lineRect, format)
            yOffset += lineHeight
        Next
    End Sub

    Private Sub DrawCenteredText(graphics As Graphics, text As String, font As Font, brush As Brush, rect As Rectangle)
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center ' Mengatur teks ke tengah secara horizontal
        format.LineAlignment = StringAlignment.Center ' Mengatur teks ke tengah secara vertikal
        format.Trimming = StringTrimming.EllipsisCharacter

        graphics.DrawString(text, font, brush, rect, format)
    End Sub



    Private Sub picReport_Click(sender As Object, e As EventArgs) Handles picReport.Click
        GenerateMonthlyReport()
        DataGridView1.DataSource = getLaporan()
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        printDialog1.Document = printDocument1
        If printDialog1.ShowDialog() = DialogResult.OK Then
            printDocument1.Print()
        End If
    End Sub

    Private Sub picReturn_Click(sender As Object, e As EventArgs) Handles picReturn.Click
        Me.Close()
        FormBeranda.Show()
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        Dim idLaporan = txtId.Text
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data laporan '" & txtId.Text & "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If String.IsNullOrEmpty(idLaporan) Then
            MessageBox.Show("Laporan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Try
                deleteLaporan(idLaporan)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
            End Try
        End If

        DataGridView1.DataSource = getLaporan()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtId.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub
End Class