<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        btnBarang = New Button()
        btnKategori = New Button()
        btnPeminjam = New Button()
        btnPembayaran = New Button()
        btnPeminjaman = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(64, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 10
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(64, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 32)
        Label1.TabIndex = 11
        Label1.Text = "Main Menu"
        ' 
        ' btnBarang
        ' 
        btnBarang.BackColor = Color.Turquoise
        btnBarang.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBarang.ForeColor = SystemColors.ButtonHighlight
        btnBarang.Location = New Point(50, 171)
        btnBarang.Name = "btnBarang"
        btnBarang.Size = New Size(145, 50)
        btnBarang.TabIndex = 12
        btnBarang.Text = "Data Barang"
        btnBarang.UseVisualStyleBackColor = False
        ' 
        ' btnKategori
        ' 
        btnKategori.BackColor = Color.Turquoise
        btnKategori.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKategori.ForeColor = SystemColors.ButtonHighlight
        btnKategori.Location = New Point(49, 252)
        btnKategori.Name = "btnKategori"
        btnKategori.Size = New Size(145, 50)
        btnKategori.TabIndex = 13
        btnKategori.Text = "Data Kategori"
        btnKategori.UseVisualStyleBackColor = False
        ' 
        ' btnPeminjam
        ' 
        btnPeminjam.BackColor = Color.Turquoise
        btnPeminjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeminjam.ForeColor = SystemColors.ButtonHighlight
        btnPeminjam.Location = New Point(224, 252)
        btnPeminjam.Name = "btnPeminjam"
        btnPeminjam.Size = New Size(173, 50)
        btnPeminjam.TabIndex = 14
        btnPeminjam.Text = "Data Peminjam"
        btnPeminjam.UseVisualStyleBackColor = False
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.BackColor = Color.Turquoise
        btnPembayaran.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPembayaran.ForeColor = SystemColors.ButtonHighlight
        btnPembayaran.Location = New Point(224, 171)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(171, 50)
        btnPembayaran.TabIndex = 15
        btnPembayaran.Text = "Data Pembayaran"
        btnPembayaran.UseVisualStyleBackColor = False
        ' 
        ' btnPeminjaman
        ' 
        btnPeminjaman.BackColor = Color.Turquoise
        btnPeminjaman.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeminjaman.ForeColor = SystemColors.ButtonHighlight
        btnPeminjaman.Location = New Point(224, 337)
        btnPeminjaman.Name = "btnPeminjaman"
        btnPeminjaman.Size = New Size(171, 50)
        btnPeminjaman.TabIndex = 16
        btnPeminjaman.Text = "Data Peminjaman"
        btnPeminjaman.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(250, 481)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 50)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' FormBeranda
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 584)
        Controls.Add(btnExit)
        Controls.Add(btnPeminjaman)
        Controls.Add(btnPembayaran)
        Controls.Add(btnPeminjam)
        Controls.Add(btnKategori)
        Controls.Add(btnBarang)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "FormBeranda"
        Text = "FormBeranda"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnKategori As Button
    Friend WithEvents btnPeminjam As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnPeminjaman As Button
    Friend WithEvents btnExit As Button
End Class
