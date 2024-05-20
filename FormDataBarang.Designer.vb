<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBarang
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
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        picClear = New PictureBox()
        picDelete = New PictureBox()
        picSearch = New PictureBox()
        v = New PictureBox()
        picSimpan = New PictureBox()
        Panel7 = New Panel()
        cmbStatus = New ComboBox()
        Panel6 = New Panel()
        txtSpek = New RichTextBox()
        Panel5 = New Panel()
        txtDeskripsi = New RichTextBox()
        Panel4 = New Panel()
        txtHarga = New TextBox()
        Panel3 = New Panel()
        cmbKategori = New ComboBox()
        Panel2 = New Panel()
        txtBrand = New TextBox()
        Panel1 = New Panel()
        txtNamaBarang = New TextBox()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(picClear, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(v, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSimpan, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(331, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 0
        Label1.Text = "Data Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Turquoise
        Label2.Location = New Point(265, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 11
        Label2.Text = "RenTech Solutions App"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 100)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(760, 252)
        DataGridView1.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSeaGreen
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(picClear)
        GroupBox1.Controls.Add(picDelete)
        GroupBox1.Controls.Add(picSearch)
        GroupBox1.Controls.Add(v)
        GroupBox1.Controls.Add(picSimpan)
        GroupBox1.Controls.Add(Panel7)
        GroupBox1.Controls.Add(Panel6)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.Controls.Add(Panel4)
        GroupBox1.Controls.Add(Panel3)
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 376)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(757, 256)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Barang"
        ' 
        ' picClear
        ' 
        picClear.BackColor = Color.Turquoise
        picClear.BackgroundImageLayout = ImageLayout.Zoom
        picClear.Image = My.Resources.Resources.clear_icon_2
        picClear.Location = New Point(659, 104)
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
        picDelete.Location = New Point(578, 168)
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
        picSearch.Location = New Point(659, 40)
        picSearch.Name = "picSearch"
        picSearch.Size = New Size(75, 58)
        picSearch.SizeMode = PictureBoxSizeMode.Zoom
        picSearch.TabIndex = 8
        picSearch.TabStop = False
        ' 
        ' v
        ' 
        v.BackColor = Color.Turquoise
        v.BackgroundImageLayout = ImageLayout.Zoom
        v.Image = My.Resources.Resources.edit_icon_png_14
        v.Location = New Point(578, 104)
        v.Name = "v"
        v.Size = New Size(75, 58)
        v.SizeMode = PictureBoxSizeMode.Zoom
        v.TabIndex = 7
        v.TabStop = False
        ' 
        ' picSimpan
        ' 
        picSimpan.BackColor = Color.Turquoise
        picSimpan.BackgroundImageLayout = ImageLayout.Zoom
        picSimpan.Image = My.Resources.Resources.Save_Button_PNG_Transparent_Images
        picSimpan.Location = New Point(578, 40)
        picSimpan.Name = "picSimpan"
        picSimpan.Size = New Size(75, 58)
        picSimpan.SizeMode = PictureBoxSizeMode.Zoom
        picSimpan.TabIndex = 6
        picSimpan.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(cmbStatus)
        Panel7.Location = New Point(285, 200)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(274, 44)
        Panel7.TabIndex = 4
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Tersedia", "Disewa", "Perbaikan"})
        cmbStatus.Location = New Point(6, 5)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(265, 33)
        cmbStatus.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(txtSpek)
        Panel6.Location = New Point(285, 121)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(274, 75)
        Panel6.TabIndex = 2
        ' 
        ' txtSpek
        ' 
        txtSpek.BorderStyle = BorderStyle.None
        txtSpek.Location = New Point(3, 3)
        txtSpek.Name = "txtSpek"
        txtSpek.Size = New Size(268, 72)
        txtSpek.TabIndex = 0
        txtSpek.Text = ""
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(txtDeskripsi)
        Panel5.Location = New Point(285, 40)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(274, 75)
        Panel5.TabIndex = 1
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.None
        txtDeskripsi.Location = New Point(3, 3)
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(268, 72)
        txtDeskripsi.TabIndex = 0
        txtDeskripsi.Text = ""
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(txtHarga)
        Panel4.Location = New Point(13, 200)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(244, 44)
        Panel4.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.None
        txtHarga.Location = New Point(6, 10)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(235, 24)
        txtHarga.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(cmbKategori)
        Panel3.Location = New Point(13, 148)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(244, 44)
        Panel3.TabIndex = 2
        ' 
        ' cmbKategori
        ' 
        cmbKategori.FormattingEnabled = True
        cmbKategori.Location = New Point(6, 5)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(235, 33)
        cmbKategori.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtBrand)
        Panel2.Location = New Point(13, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(244, 44)
        Panel2.TabIndex = 1
        ' 
        ' txtBrand
        ' 
        txtBrand.BorderStyle = BorderStyle.None
        txtBrand.Location = New Point(6, 10)
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(235, 24)
        txtBrand.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtNamaBarang)
        Panel1.Location = New Point(13, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 44)
        Panel1.TabIndex = 0
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.BorderStyle = BorderStyle.None
        txtNamaBarang.Location = New Point(6, 10)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(235, 24)
        txtNamaBarang.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Turquoise
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = My.Resources.Resources.R__4_
        PictureBox1.Location = New Point(659, 168)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' FormDataBarang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(778, 644)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormDataBarang"
        Text = "FormDataBarang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(picClear, ComponentModel.ISupportInitialize).EndInit()
        CType(picDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(picSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(v, ComponentModel.ISupportInitialize).EndInit()
        CType(picSimpan, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtDeskripsi As RichTextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtSpek As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents v As PictureBox
    Friend WithEvents picSimpan As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picClear As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
