﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        txtNama = New TextBox()
        Panel8 = New Panel()
        txtIdKategori = New TextBox()
        picReturn = New PictureBox()
        picClear = New PictureBox()
        picDelete = New PictureBox()
        picSearch = New PictureBox()
        picSave = New PictureBox()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        picEdit = New PictureBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        Panel8.SuspendLayout()
        CType(picReturn, ComponentModel.ISupportInitialize).BeginInit()
        CType(picClear, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSave, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picEdit, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.None
        txtNama.Location = New Point(6, 10)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(235, 24)
        txtNama.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(txtIdKategori)
        Panel8.Location = New Point(13, 32)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(244, 44)
        Panel8.TabIndex = 12
        ' 
        ' txtIdKategori
        ' 
        txtIdKategori.BackColor = Color.White
        txtIdKategori.BorderStyle = BorderStyle.None
        txtIdKategori.Location = New Point(6, 10)
        txtIdKategori.Name = "txtIdKategori"
        txtIdKategori.Size = New Size(235, 24)
        txtIdKategori.TabIndex = 0
        ' 
        ' picReturn
        ' 
        picReturn.BackColor = Color.Turquoise
        picReturn.BackgroundImageLayout = ImageLayout.Zoom
        picReturn.Image = My.Resources.Resources.R__4_
        picReturn.Location = New Point(659, 168)
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
        ' picSave
        ' 
        picSave.BackColor = Color.Turquoise
        picSave.BackgroundImageLayout = ImageLayout.Zoom
        picSave.Image = My.Resources.Resources.Save_Button_PNG_Transparent_Images
        picSave.Location = New Point(578, 40)
        picSave.Name = "picSave"
        picSave.Size = New Size(75, 58)
        picSave.SizeMode = PictureBoxSizeMode.Zoom
        picSave.TabIndex = 6
        picSave.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtNama)
        Panel1.Location = New Point(276, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 44)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSeaGreen
        GroupBox1.Controls.Add(Panel8)
        GroupBox1.Controls.Add(picReturn)
        GroupBox1.Controls.Add(picClear)
        GroupBox1.Controls.Add(picDelete)
        GroupBox1.Controls.Add(picSearch)
        GroupBox1.Controls.Add(picEdit)
        GroupBox1.Controls.Add(picSave)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 349)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(757, 283)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Kategori"
        ' 
        ' picEdit
        ' 
        picEdit.BackColor = Color.Turquoise
        picEdit.BackgroundImageLayout = ImageLayout.Zoom
        picEdit.Image = My.Resources.Resources.edit_icon_png_14
        picEdit.Location = New Point(578, 104)
        picEdit.Name = "picEdit"
        picEdit.Size = New Size(75, 58)
        picEdit.SizeMode = PictureBoxSizeMode.Zoom
        picEdit.TabIndex = 7
        picEdit.TabStop = False
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
        DataGridView1.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Turquoise
        Label2.Location = New Point(265, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 15
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(331, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 32)
        Label1.TabIndex = 14
        Label1.Text = "Kategori"
        ' 
        ' FormKategori
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(778, 644)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormKategori"
        Text = "FormKategori"
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(picReturn, ComponentModel.ISupportInitialize).EndInit()
        CType(picClear, ComponentModel.ISupportInitialize).EndInit()
        CType(picDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(picSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(picSave, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(picEdit, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtIdKategori As TextBox
    Friend WithEvents picReturn As PictureBox
    Friend WithEvents picClear As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picSave As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
