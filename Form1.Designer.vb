﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        txtPassword = New TextBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        txtUsername = New TextBox()
        btnExit = New Button()
        btnLogin = New Button()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSeaGreen
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(31, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(394, 498)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form Login"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtPassword)
        Panel2.Location = New Point(42, 284)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 52)
        Panel2.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.R
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(49, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ButtonHighlight
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Location = New Point(58, 13)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 24)
        txtPassword.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtUsername)
        Panel1.Location = New Point(42, 197)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 52)
        Panel1.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1077114
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ButtonHighlight
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Location = New Point(58, 15)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(230, 24)
        txtUsername.TabIndex = 12
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.LightSeaGreen
        btnExit.Location = New Point(42, 383)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(140, 50)
        btnExit.TabIndex = 15
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Turquoise
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(202, 383)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(140, 50)
        btnLogin.TabIndex = 14
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Turquoise
        Label2.Location = New Point(45, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 38)
        Label2.TabIndex = 9
        Label2.Text = "RenTech Solutions App"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(45, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 32)
        Label1.TabIndex = 8
        Label1.Text = "Login to"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(453, 584)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
