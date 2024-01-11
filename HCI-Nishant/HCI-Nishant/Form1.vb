Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'Validation Check
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MessageBox.Show("Welcome To Pass it Management System")
            Me.Hide()
            dashboard.Show()


        Else
            MessageBox.Show("Invalide Username or Password")
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
