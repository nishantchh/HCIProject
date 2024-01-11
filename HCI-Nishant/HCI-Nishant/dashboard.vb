Public Class dashboard
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentdashboard As New Studentdashboard
        studentdashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btninstructer_Click(sender As Object, e As EventArgs) Handles btninstructer.Click
        Dim instructerdashboard As New Form2
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnvehicle_Click(sender As Object, e As EventArgs) Handles btnvehicle.Click
        Dim vehicledashboard As New Vehicle
        Vehicle.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim course As New Course
        course.Show()
        Me.Hide()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class