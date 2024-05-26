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
        btnPeminjaman = New Button()
        btnExit = New Button()
        Button1 = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        lblPenyewa = New Label()
        lblTotalBarang = New Label()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        lblTotalStokBarang = New Label()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(24, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 10
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(24, 59)
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
        btnBarang.Location = New Point(24, 168)
        btnBarang.Name = "btnBarang"
        btnBarang.Size = New Size(166, 50)
        btnBarang.TabIndex = 12
        btnBarang.Text = "Data Barang"
        btnBarang.UseVisualStyleBackColor = False
        ' 
        ' btnKategori
        ' 
        btnKategori.BackColor = Color.Turquoise
        btnKategori.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKategori.ForeColor = SystemColors.ButtonHighlight
        btnKategori.Location = New Point(24, 108)
        btnKategori.Name = "btnKategori"
        btnKategori.Size = New Size(166, 50)
        btnKategori.TabIndex = 13
        btnKategori.Text = "Data Kategori"
        btnKategori.UseVisualStyleBackColor = False
        ' 
        ' btnPeminjam
        ' 
        btnPeminjam.BackColor = Color.Turquoise
        btnPeminjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeminjam.ForeColor = SystemColors.ButtonHighlight
        btnPeminjam.Location = New Point(21, 230)
        btnPeminjam.Name = "btnPeminjam"
        btnPeminjam.Size = New Size(169, 50)
        btnPeminjam.TabIndex = 14
        btnPeminjam.Text = "Data Penyewa"
        btnPeminjam.UseVisualStyleBackColor = False
        ' 
        ' btnPeminjaman
        ' 
        btnPeminjaman.BackColor = Color.Turquoise
        btnPeminjaman.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeminjaman.ForeColor = SystemColors.ButtonHighlight
        btnPeminjaman.Location = New Point(24, 292)
        btnPeminjaman.Name = "btnPeminjaman"
        btnPeminjaman.Size = New Size(166, 50)
        btnPeminjaman.TabIndex = 16
        btnPeminjaman.Text = "Data Penyewaan"
        btnPeminjaman.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Turquoise
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(276, 505)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 50)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Turquoise
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(25, 352)
        Button1.Name = "Button1"
        Button1.Size = New Size(165, 50)
        Button1.TabIndex = 18
        Button1.Text = "Laporan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(244, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 28)
        Label3.TabIndex = 19
        Label3.Text = "Total Penyewa"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1077114
        PictureBox1.Location = New Point(235, 108)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' lblPenyewa
        ' 
        lblPenyewa.AutoSize = True
        lblPenyewa.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPenyewa.ForeColor = SystemColors.ControlLightLight
        lblPenyewa.Location = New Point(303, 109)
        lblPenyewa.Name = "lblPenyewa"
        lblPenyewa.Size = New Size(28, 32)
        lblPenyewa.TabIndex = 21
        lblPenyewa.Text = "0"
        ' 
        ' lblTotalBarang
        ' 
        lblTotalBarang.AutoSize = True
        lblTotalBarang.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalBarang.ForeColor = SystemColors.ControlLightLight
        lblTotalBarang.Location = New Point(303, 178)
        lblTotalBarang.Name = "lblTotalBarang"
        lblTotalBarang.Size = New Size(28, 32)
        lblTotalBarang.TabIndex = 24
        lblTotalBarang.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.R__5_
        PictureBox2.Location = New Point(235, 177)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(62, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(244, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 28)
        Label5.TabIndex = 22
        Label5.Text = "Total Barang"
        ' 
        ' lblTotalStokBarang
        ' 
        lblTotalStokBarang.AutoSize = True
        lblTotalStokBarang.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalStokBarang.ForeColor = SystemColors.ControlLightLight
        lblTotalStokBarang.Location = New Point(303, 245)
        lblTotalStokBarang.Name = "lblTotalStokBarang"
        lblTotalStokBarang.Size = New Size(28, 32)
        lblTotalStokBarang.TabIndex = 27
        lblTotalStokBarang.Text = "0"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.R__5_
        PictureBox3.Location = New Point(235, 244)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(244, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 28)
        Label6.TabIndex = 25
        Label6.Text = "Total Stok Barang"
        ' 
        ' FormBeranda
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(453, 584)
        Controls.Add(lblTotalStokBarang)
        Controls.Add(PictureBox3)
        Controls.Add(Label6)
        Controls.Add(lblTotalBarang)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(lblPenyewa)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(btnExit)
        Controls.Add(btnPeminjaman)
        Controls.Add(btnPeminjam)
        Controls.Add(btnKategori)
        Controls.Add(btnBarang)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "FormBeranda"
        Text = "FormBeranda"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnKategori As Button
    Friend WithEvents btnPeminjam As Button
    Friend WithEvents btnPeminjaman As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPenyewa As Label
    Friend WithEvents lblTotalBarang As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalStokBarang As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
End Class
