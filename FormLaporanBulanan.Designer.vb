<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBulanan
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
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        picReturn = New PictureBox()
        picReport = New PictureBox()
        picPrint = New PictureBox()
        picDelete = New PictureBox()
        labelId = New Label()
        txtId = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picReturn, ComponentModel.ISupportInitialize).BeginInit()
        CType(picReport, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPrint, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDelete, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 91)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(662, 541)
        DataGridView1.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Turquoise
        Label2.Location = New Point(265, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 23
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(269, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 32)
        Label1.TabIndex = 22
        Label1.Text = "Data Laporan Penyewaan"
        ' 
        ' picReturn
        ' 
        picReturn.BackColor = Color.Turquoise
        picReturn.BackgroundImageLayout = ImageLayout.Zoom
        picReturn.Image = My.Resources.Resources.R__4_
        picReturn.Location = New Point(691, 305)
        picReturn.Name = "picReturn"
        picReturn.Size = New Size(75, 58)
        picReturn.SizeMode = PictureBoxSizeMode.Zoom
        picReturn.TabIndex = 11
        picReturn.TabStop = False
        ' 
        ' picReport
        ' 
        picReport.BackColor = Color.Turquoise
        picReport.BackgroundImageLayout = ImageLayout.Zoom
        picReport.Image = My.Resources.Resources.R__7_
        picReport.Location = New Point(691, 101)
        picReport.Name = "picReport"
        picReport.Size = New Size(75, 58)
        picReport.SizeMode = PictureBoxSizeMode.Zoom
        picReport.TabIndex = 25
        picReport.TabStop = False
        ' 
        ' picPrint
        ' 
        picPrint.BackColor = Color.Turquoise
        picPrint.BackgroundImageLayout = ImageLayout.Zoom
        picPrint.Image = My.Resources.Resources.R__8_
        picPrint.Location = New Point(691, 174)
        picPrint.Name = "picPrint"
        picPrint.Size = New Size(75, 58)
        picPrint.SizeMode = PictureBoxSizeMode.Zoom
        picPrint.TabIndex = 26
        picPrint.TabStop = False
        ' 
        ' picDelete
        ' 
        picDelete.BackColor = Color.Turquoise
        picDelete.BackgroundImageLayout = ImageLayout.Zoom
        picDelete.Image = My.Resources.Resources.R__3_
        picDelete.Location = New Point(691, 238)
        picDelete.Name = "picDelete"
        picDelete.Size = New Size(75, 58)
        picDelete.SizeMode = PictureBoxSizeMode.Zoom
        picDelete.TabIndex = 27
        picDelete.TabStop = False
        ' 
        ' labelId
        ' 
        labelId.AutoSize = True
        labelId.ForeColor = Color.LightSeaGreen
        labelId.Location = New Point(690, 373)
        labelId.Name = "labelId"
        labelId.Size = New Size(0, 25)
        labelId.TabIndex = 28
        ' 
        ' txtId
        ' 
        txtId.BackColor = Color.LightSeaGreen
        txtId.BorderStyle = BorderStyle.None
        txtId.ForeColor = Color.LightSeaGreen
        txtId.Location = New Point(691, 373)
        txtId.Name = "txtId"
        txtId.Size = New Size(30, 24)
        txtId.TabIndex = 29
        ' 
        ' FormLaporanBulanan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(778, 644)
        Controls.Add(txtId)
        Controls.Add(labelId)
        Controls.Add(picDelete)
        Controls.Add(picPrint)
        Controls.Add(picReport)
        Controls.Add(DataGridView1)
        Controls.Add(picReturn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormLaporanBulanan"
        Text = "FormLaporanBulanan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(picReturn, ComponentModel.ISupportInitialize).EndInit()
        CType(picReport, ComponentModel.ISupportInitialize).EndInit()
        CType(picPrint, ComponentModel.ISupportInitialize).EndInit()
        CType(picDelete, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picReturn As PictureBox
    Friend WithEvents picReport As PictureBox
    Friend WithEvents picPrint As PictureBox
    Friend WithEvents picDelete As PictureBox
    Friend WithEvents labelId As Label
    Friend WithEvents txtId As TextBox
End Class
