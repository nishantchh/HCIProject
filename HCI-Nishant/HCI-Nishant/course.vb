Imports System.Data.DataTable
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Course
    Dim dt As New DataTable
    Dim index As New Integer

    Private Sub Course_load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt.Columns.Add("Course ID", GetType(String))
        dt.Columns.Add("Course Name", GetType(String))
        dt.Columns.Add("Course Duration", GetType(Integer))
        dt.Columns.Add("Course Type", GetType(Integer))
        dt.Columns.Add("Instructor Name", GetType(String))
        dt.Columns.Add("Course Add Date", GetType(Date))


        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If Textmodel.Text <> "" And Textbrand.Text <> "" Then
            dt.Rows.Add(Textmodel.Text, Textbrand.Text, Textmilege.Text, ComboBox1.SelectedItem, DateTimePicker2.Value.ToString("dd/MM/yyyy"), ComboBox2.SelectedItem)

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Textmodel.Text = ""
        Textbrand.Text = ""
        Textmilege.Text = ""

        ComboBox1.SelectedItem = ""

        ComboBox2.SelectedItem = ""

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim newdata As DataGridViewRow
        newdata = DataGridView1.Rows(index)
        newdata.Cells(0).Value = Textmodel.Text
        newdata.Cells(1).Value = Textbrand.Text
        newdata.Cells(2).Value = Textmilege.Text
        newdata.Cells(4).Value = ComboBox1.SelectedItem
        newdata.Cells(5).Value = DateTimePicker2.Value.ToString("dd/MM/yyyy")
        newdata.Cells(6).Value = ComboBox2.SelectedItem

    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        DataGridView1.Rows.RemoveAt(index)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Textmodel.Text = selectedRow.Cells(0).Value.ToString()
        Textbrand.Text = selectedRow.Cells(1).Value.ToString()
        Textmilege.Text = selectedRow.Cells(2).Value.ToString()
        ComboBox1.SelectedItem = selectedRow.Cells(4).Value.ToString()
        ComboBox2.SelectedItem = selectedRow.Cells(6).Value.ToString()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        dashboard.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class