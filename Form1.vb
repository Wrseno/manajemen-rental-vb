Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Masukkan username", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Masukkan password", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
            db.Open()
            sqlCommand = New MySqlCommand("select * from users where username=@username and password=@password", db)
            sqlCommand.Parameters.AddWithValue("@username", txtUsername.Text)
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text)

            sqlReader = sqlCommand.ExecuteReader()
            If (sqlReader.Read()) Then
                FormBeranda.Show()
                Me.Hide()
            Else
                MessageBox.Show("Masukkan username dan password yang benar", "Input tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtPassword.Text = ""
        End Try

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.DarkGray

        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DarkGray
    End Sub
End Class
