<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course
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
        btnremove = New Button()
        btnexit = New Button()
        btnadd = New Button()
        btnupdate = New Button()
        btninsert = New Button()
        DataGridView1 = New DataGridView()
        ComboBox2 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label15 = New Label()
        Label7 = New Label()
        Textmilege = New TextBox()
        Label8 = New Label()
        Textbrand = New TextBox()
        Label9 = New Label()
        Textmodel = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnremove
        ' 
        btnremove.BackColor = Color.Crimson
        btnremove.Location = New Point(390, 601)
        btnremove.Margin = New Padding(2)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(138, 59)
        btnremove.TabIndex = 91
        btnremove.Text = "Remove"
        btnremove.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.LemonChiffon
        btnexit.Location = New Point(1008, 653)
        btnexit.Margin = New Padding(2)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(138, 59)
        btnexit.TabIndex = 90
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Gray
        btnadd.Location = New Point(390, 494)
        btnadd.Margin = New Padding(2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 59)
        btnadd.TabIndex = 89
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Lime
        btnupdate.Location = New Point(106, 601)
        btnupdate.Margin = New Padding(2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(139, 59)
        btnupdate.TabIndex = 88
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btninsert
        ' 
        btninsert.BackColor = SystemColors.HotTrack
        btninsert.Location = New Point(106, 494)
        btninsert.Margin = New Padding(2)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(139, 59)
        btninsert.TabIndex = 87
        btninsert.Text = "Insert"
        btninsert.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(561, 215)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(620, 374)
        DataGridView1.TabIndex = 86
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Introductory", "Standard", "Pass Plus"})
        ComboBox2.Location = New Point(265, 321)
        ComboBox2.Margin = New Padding(2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(251, 33)
        ComboBox2.TabIndex = 85
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(265, 395)
        DateTimePicker2.Margin = New Padding(2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(251, 31)
        DateTimePicker2.TabIndex = 83
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Red", "Black", "Blue", "White", "Other"})
        ComboBox1.Location = New Point(265, 359)
        ComboBox1.Margin = New Padding(2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(251, 33)
        ComboBox1.TabIndex = 82
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(116, 8)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 79)
        Panel1.TabIndex = 84
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(357, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 48)
        Label1.TabIndex = 0
        Label1.Text = "Course Dashboard"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(120, 365)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(140, 25)
        Label15.TabIndex = 77
        Label15.Text = "Instructor Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(120, 221)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 25)
        Label7.TabIndex = 71
        Label7.Text = "Course ID"
        ' 
        ' Textmilege
        ' 
        Textmilege.Location = New Point(265, 286)
        Textmilege.Margin = New Padding(2)
        Textmilege.Name = "Textmilege"
        Textmilege.Size = New Size(251, 31)
        Textmilege.TabIndex = 80
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(116, 256)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 25)
        Label8.TabIndex = 72
        Label8.Text = "Course Name"
        ' 
        ' Textbrand
        ' 
        Textbrand.Location = New Point(265, 253)
        Textbrand.Margin = New Padding(2)
        Textbrand.Name = "Textbrand"
        Textbrand.Size = New Size(251, 31)
        Textbrand.TabIndex = 79
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(116, 288)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(141, 25)
        Label9.TabIndex = 73
        Label9.Text = "Course Duration"
        ' 
        ' Textmodel
        ' 
        Textmodel.Location = New Point(265, 215)
        Textmodel.Margin = New Padding(2)
        Textmodel.Name = "Textmodel"
        Textmodel.Size = New Size(251, 31)
        Textmodel.TabIndex = 78
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(120, 399)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(148, 25)
        Label13.TabIndex = 75
        Label13.Text = "Course Add Date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(120, 326)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(109, 25)
        Label14.TabIndex = 76
        Label14.Text = "Course Type"
        ' 
        ' Course
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1237, 751)
        Controls.Add(btnremove)
        Controls.Add(btnexit)
        Controls.Add(btnadd)
        Controls.Add(btnupdate)
        Controls.Add(btninsert)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox2)
        Controls.Add(DateTimePicker2)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Controls.Add(Label15)
        Controls.Add(Label7)
        Controls.Add(Textmilege)
        Controls.Add(Label8)
        Controls.Add(Textbrand)
        Controls.Add(Label9)
        Controls.Add(Textmodel)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Name = "Course"
        StartPosition = FormStartPosition.CenterScreen
        Text = "course"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnremove As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Textmilege As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Textbrand As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Textmodel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
