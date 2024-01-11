Imports System.Data.DataTable

Public Class Form2
    Dim dt As New DataTable
    Dim index As New Integer

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub Form2_load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt.Columns.Add("Instructer Id", GetType(Integer))
        dt.Columns.Add("First Name", GetType(String))
        dt.Columns.Add("Last Name", GetType(String))
        dt.Columns.Add("Address", GetType(String))
        dt.Columns.Add("contact No", GetType(Integer))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Gender", GetType(String))
        dt.Columns.Add("DOB", GetType(Date))
        dt.Columns.Add("Nationality", GetType(String))
        dt.Columns.Add("Education", GetType(String))
        dt.Columns.Add("Contract Type", GetType(String))
        dt.Columns.Add("Start Date", GetType(Date))
        dt.Columns.Add("Time", GetType(String))

        DataGridView1.DataSource = dt
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        'Validation'
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            dt.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, ComboBox1.SelectedItem, DateTimePicker1.Value.ToString("dd/MM/yyyy"), TextBox7.Text, ComboBox2.SelectedItem, ComboBox3.SelectedItem, DateTimePicker2.Value.ToString("dd/MM/yyyy"), ComboBox4.SelectedItem)

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedItem = ""
        TextBox7.Text = ""
        ComboBox2.SelectedItem = ""
        ComboBox3.SelectedItem = ""
        ComboBox4.SelectedItem = ""
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim newdata As DataGridViewRow
        newdata = DataGridView1.Rows(index)
        newdata.Cells(0).Value = TextBox1.Text
        newdata.Cells(1).Value = TextBox2.Text
        newdata.Cells(2).Value = TextBox3.Text
        newdata.Cells(3).Value = TextBox4.Text
        newdata.Cells(4).Value = TextBox5.Text
        newdata.Cells(5).Value = TextBox6.Text
        newdata.Cells(6).Value = ComboBox1.SelectedItem
        newdata.Cells(7).Value = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        newdata.Cells(8).Value = TextBox7.Text
        newdata.Cells(9).Value = ComboBox2.SelectedItem
        newdata.Cells(10).Value = ComboBox3.SelectedItem
        newdata.Cells(11).Value = DateTimePicker2.Value.ToString("dd/MM/yyyy")
        newdata.Cells(12).Value = ComboBox4.SelectedItem


    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        DataGridView1.Rows.RemoveAt(index)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        TextBox3.Text = selectedRow.Cells(2).Value.ToString()
        TextBox4.Text = selectedRow.Cells(3).Value.ToString()
        TextBox5.Text = selectedRow.Cells(4).Value.ToString()
        TextBox6.Text = selectedRow.Cells(5).Value.ToString()
        ComboBox1.SelectedItem = selectedRow.Cells(6).ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class