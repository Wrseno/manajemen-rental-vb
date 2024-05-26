<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
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
        Panel9 = New Panel()
        txtTglKembali = New TextBox()
        Panel6 = New Panel()
        cmbPeminjam = New ComboBox()
        Panel5 = New Panel()
        cmbBarang = New ComboBox()
        Panel8 = New Panel()
        txtIdPenyewaan = New TextBox()
        Panel7 = New Panel()
        cmbDikembalikan = New ComboBox()
        Panel3 = New Panel()
        txtTglPinjam = New TextBox()
        picReturn = New PictureBox()
        picClear = New PictureBox()
        picDelete = New PictureBox()
        picSearch = New PictureBox()
        picEdit = New PictureBox()
        Panel4 = New Panel()
        txtTglHrsKembali = New TextBox()
        picSave = New PictureBox()
        Panel2 = New Panel()
        txtTotalBayar = New TextBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Panel1 = New Panel()
        txtDenda = New TextBox()
        GroupBox1 = New GroupBox()
        picCalendar = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel10 = New Panel()
        txtLamaSewa = New TextBox()
        Label1 = New Label()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel3.SuspendLayout()
        CType(picReturn, ComponentModel.ISupportInitialize).BeginInit()
        CType(picClear, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(picEdit, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(picSave, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picCalendar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(txtTglKembali)
        Panel9.Location = New Point(291, 79)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(244, 44)
        Panel9.TabIndex = 4
        ' 
        ' txtTglKembali
        ' 
        txtTglKembali.BorderStyle = BorderStyle.None
        txtTglKembali.Location = New Point(6, 10)
        txtTglKembali.Name = "txtTglKembali"
        txtTglKembali.Size = New Size(235, 24)
        txtTglKembali.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(cmbPeminjam)
        Panel6.Location = New Point(13, 30)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(244, 44)
        Panel6.TabIndex = 5
        ' 
        ' cmbPeminjam
        ' 
        cmbPeminjam.FormattingEnabled = True
        cmbPeminjam.Location = New Point(6, 5)
        cmbPeminjam.Name = "cmbPeminjam"
        cmbPeminjam.Size = New Size(235, 33)
        cmbPeminjam.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(cmbBarang)
        Panel5.Location = New Point(13, 79)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(244, 44)
        Panel5.TabIndex = 4
        ' 
        ' cmbBarang
        ' 
        cmbBarang.FormattingEnabled = True
        cmbBarang.Location = New Point(6, 5)
        cmbBarang.Name = "cmbBarang"
        cmbBarang.Size = New Size(235, 33)
        cmbBarang.TabIndex = 3
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(txtIdPenyewaan)
        Panel8.Location = New Point(291, 228)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(244, 44)
        Panel8.TabIndex = 12
        ' 
        ' txtIdPenyewaan
        ' 
        txtIdPenyewaan.BackColor = Color.White
        txtIdPenyewaan.BorderStyle = BorderStyle.None
        txtIdPenyewaan.Location = New Point(6, 10)
        txtIdPenyewaan.Name = "txtIdPenyewaan"
        txtIdPenyewaan.Size = New Size(235, 24)
        txtIdPenyewaan.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(cmbDikembalikan)
        Panel7.Location = New Point(291, 30)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(244, 44)
        Panel7.TabIndex = 6
        ' 
        ' cmbDikembalikan
        ' 
        cmbDikembalikan.FormattingEnabled = True
        cmbDikembalikan.Items.AddRange(New Object() {"Sudah", "Belum"})
        cmbDikembalikan.Location = New Point(6, 5)
        cmbDikembalikan.Name = "cmbDikembalikan"
        cmbDikembalikan.Size = New Size(235, 33)
        cmbDikembalikan.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtTglPinjam)
        Panel3.Location = New Point(13, 177)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(244, 44)
        Panel3.TabIndex = 3
        ' 
        ' txtTglPinjam
        ' 
        txtTglPinjam.BorderStyle = BorderStyle.None
        txtTglPinjam.Location = New Point(3, 10)
        txtTglPinjam.Name = "txtTglPinjam"
        txtTglPinjam.Size = New Size(235, 24)
        txtTglPinjam.TabIndex = 1
        ' 
        ' picReturn
        ' 
        picReturn.BackColor = Color.Turquoise
        picReturn.BackgroundImageLayout = ImageLayout.Zoom
        picReturn.Image = My.Resources.Resources.R__4_
        picReturn.Location = New Point(659, 157)
        picReturn.Name = "picReturn"
        picReturn.Size = New Size(75, 58)
        picReturn.SizeMode = PictureBoxSizeMode.Zoom
        picReturn.TabIndex = 11
        picReturn.TabStop = False
        ' 
        ' picClear
        ' 
        picClear.BackColor = Color.Turquoise
        picClear.BackgroundImageLayout = ImageLayout.Zoom
        picClear.Image = My.Resources.Resources.clear_icon_2
        picClear.Location = New Point(659, 93)
        picClear.Name = "picClear"
        picClear.Size = New Size(75, 58)
        picClear.SizeMode = PictureBoxSizeMode.Zoom
        picClear.TabIndex = 10
        picClear.TabStop = False
        ' 
        ' picDelete
        ' 
        picDelete.BackColor = Color.Turquoise
        picDelete.BackgroundImageLayout = ImageLayout.Zoom
        picDelete.Image = My.Resources.Resources.R__3_
        picDelete.Location = New Point(578, 157)
        picDelete.Name = "picDelete"
        picDelete.Size = New Size(75, 58)
        picDelete.SizeMode = PictureBoxSizeMode.Zoom
        picDelete.TabIndex = 9
        picDelete.TabStop = False
        ' 
        ' picSearch
        ' 
        picSearch.BackColor = Color.Turquoise
        picSearch.BackgroundImageLayout = ImageLayout.Zoom
        picSearch.Image = My.Resources.Resources.R__2_
        picSearch.Location = New Point(659, 29)
        picSearch.Name = "picSearch"
        picSearch.Size = New Size(75, 58)
        picSearch.SizeMode = PictureBoxSizeMode.Zoom
        picSearch.TabIndex = 8
        picSearch.TabStop = False
        ' 
        ' picEdit
        ' 
        picEdit.BackColor = Color.Turquoise
        picEdit.BackgroundImageLayout = ImageLayout.Zoom
        picEdit.Image = My.Resources.Resources.edit_icon_png_14
        picEdit.Location = New Point(578, 93)
        picEdit.Name = "picEdit"
        picEdit.Size = New Size(75, 58)
        picEdit.SizeMode = PictureBoxSizeMode.Zoom
        picEdit.TabIndex = 7
        picEdit.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(txtTglHrsKembali)
        Panel4.Location = New Point(13, 227)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(244, 44)
        Panel4.TabIndex = 2
        ' 
        ' txtTglHrsKembali
        ' 
        txtTglHrsKembali.BorderStyle = BorderStyle.None
        txtTglHrsKembali.Location = New Point(6, 10)
        txtTglHrsKembali.Name = "txtTglHrsKembali"
        txtTglHrsKembali.Size = New Size(235, 24)
        txtTglHrsKembali.TabIndex = 2
        ' 
        ' picSave
        ' 
        picSave.BackColor = Color.Turquoise
        picSave.BackgroundImageLayout = ImageLayout.Zoom
        picSave.Image = My.Resources.Resources.Save_Button_PNG_Transparent_Images
        picSave.Location = New Point(578, 29)
        picSave.Name = "picSave"
        picSave.Size = New Size(75, 58)
        picSave.SizeMode = PictureBoxSizeMode.Zoom
        picSave.TabIndex = 6
        picSave.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtTotalBayar)
        Panel2.Location = New Point(291, 178)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(244, 44)
        Panel2.TabIndex = 1
        ' 
        ' txtTotalBayar
        ' 
        txtTotalBayar.BorderStyle = BorderStyle.None
        txtTotalBayar.Location = New Point(6, 10)
        txtTotalBayar.Name = "txtTotalBayar"
        txtTotalBayar.Size = New Size(235, 24)
        txtTotalBayar.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 91)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(760, 252)
        DataGridView1.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Turquoise
        Label2.Location = New Point(265, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 19
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtDenda)
        Panel1.Location = New Point(291, 128)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 44)
        Panel1.TabIndex = 0
        ' 
        ' txtDenda
        ' 
        txtDenda.BorderStyle = BorderStyle.None
        txtDenda.Location = New Point(6, 10)
        txtDenda.Name = "txtDenda"
        txtDenda.Size = New Size(235, 24)
        txtDenda.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSeaGreen
        GroupBox1.Controls.Add(picCalendar)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Panel10)
        GroupBox1.Controls.Add(Panel9)
        GroupBox1.Controls.Add(Panel7)
        GroupBox1.Controls.Add(Panel3)
        GroupBox1.Controls.Add(Panel6)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.Controls.Add(Panel8)
        GroupBox1.Controls.Add(picReturn)
        GroupBox1.Controls.Add(picClear)
        GroupBox1.Controls.Add(picDelete)
        GroupBox1.Controls.Add(picSearch)
        GroupBox1.Controls.Add(picEdit)
        GroupBox1.Controls.Add(picSave)
        GroupBox1.Controls.Add(Panel4)
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 349)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(757, 283)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Penyewaan"
        ' 
        ' picCalendar
        ' 
        picCalendar.BackColor = Color.Turquoise
        picCalendar.BackgroundImageLayout = ImageLayout.Zoom
        picCalendar.Image = My.Resources.Resources.calendar_icon_1600
        picCalendar.Location = New Point(578, 220)
        picCalendar.Name = "picCalendar"
        picCalendar.Size = New Size(75, 58)
        picCalendar.SizeMode = PictureBoxSizeMode.Zoom
        picCalendar.TabIndex = 15
        picCalendar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Turquoise
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = My.Resources.Resources.Plus_Symbol_Transparent_Images1
        PictureBox1.Location = New Point(659, 219)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(txtLamaSewa)
        Panel10.Location = New Point(13, 127)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(244, 44)
        Panel10.TabIndex = 5
        ' 
        ' txtLamaSewa
        ' 
        txtLamaSewa.BorderStyle = BorderStyle.None
        txtLamaSewa.Location = New Point(6, 10)
        txtLamaSewa.Name = "txtLamaSewa"
        txtLamaSewa.Size = New Size(235, 24)
        txtLamaSewa.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(297, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 32)
        Label1.TabIndex = 18
        Label1.Text = "Data Penyewaan"
        ' 
        ' FormPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(778, 644)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "FormPeminjaman"
        Text = "FormPeminjaman"
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(picReturn, ComponentModel.ISupportInitialize).EndInit()
        CType(picClear, ComponentModel.ISupportInitialize).EndInit()
        CType(picDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(picSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(picEdit, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(picSave, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(picCalendar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtTglKembali As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmbPeminjam As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtIdPenyewaan As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmbDikembalikan As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTglPinjam As TextBox
    Friend WithEvents picReturn As PictureBox
    Friend WithEvents picClear As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtTglHrsKembali As TextBox
    Friend WithEvents picSave As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDenda As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtLamaSewa As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picCalendar As PictureBox
End Class
