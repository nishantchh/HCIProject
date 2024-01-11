<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        btnremove = New Button()
        btnexit = New Button()
        btnadd = New Button()
        btnupdate = New Button()
        btninsert = New Button()
        DataGridView1 = New DataGridView()
        ComboBox4 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox7 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnremove
        ' 
        btnremove.BackColor = Color.Violet
        btnremove.Location = New Point(691, 739)
        btnremove.Margin = New Padding(2, 2, 2, 2)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(123, 59)
        btnremove.TabIndex = 65
        btnremove.Text = "Remove"
        btnremove.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Olive
        btnexit.Location = New Point(854, 739)
        btnexit.Margin = New Padding(2, 2, 2, 2)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(138, 59)
        btnexit.TabIndex = 64
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.RosyBrown
        btnadd.Location = New Point(359, 739)
        btnadd.Margin = New Padding(2, 2, 2, 2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 59)
        btnadd.TabIndex = 63
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.DarkSlateGray
        btnupdate.Location = New Point(532, 739)
        btnupdate.Margin = New Padding(2, 2, 2, 2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(131, 59)
        btnupdate.TabIndex = 62
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btninsert
        ' 
        btninsert.BackColor = SystemColors.MenuHighlight
        btninsert.Location = New Point(181, 739)
        btninsert.Margin = New Padding(2, 2, 2, 2)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(139, 59)
        btninsert.TabIndex = 61
        btninsert.Text = "Insert"
        btninsert.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(414, 153)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(821, 541)
        DataGridView1.TabIndex = 60
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"9 AM", "11 AM", "1 PM", "3 PM", "5 PM"})
        ComboBox4.Location = New Point(134, 663)
        ComboBox4.Margin = New Padding(2, 2, 2, 2)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(187, 33)
        ComboBox4.TabIndex = 59
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(134, 615)
        DateTimePicker2.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(189, 31)
        DateTimePicker2.TabIndex = 58
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Part Time", "Full Time"})
        ComboBox3.Location = New Point(135, 577)
        ComboBox3.Margin = New Padding(2, 2, 2, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(187, 33)
        ComboBox3.TabIndex = 57
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Post Graduate", "Under Graduate", "Graduate"})
        ComboBox2.Location = New Point(134, 541)
        ComboBox2.Margin = New Padding(2, 2, 2, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(187, 33)
        ComboBox2.TabIndex = 56
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(134, 506)
        TextBox7.Margin = New Padding(2, 2, 2, 2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(187, 31)
        TextBox7.TabIndex = 55
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(134, 466)
        DateTimePicker1.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(189, 31)
        DateTimePicker1.TabIndex = 54
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox1.Location = New Point(134, 427)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 33)
        ComboBox1.TabIndex = 53
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(134, 385)
        TextBox6.Margin = New Padding(2, 2, 2, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(187, 31)
        TextBox6.TabIndex = 52
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(134, 345)
        TextBox5.Margin = New Padding(2, 2, 2, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(189, 31)
        TextBox5.TabIndex = 51
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(134, 305)
        TextBox4.Margin = New Padding(2, 2, 2, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(189, 31)
        TextBox4.TabIndex = 50
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(134, 262)
        TextBox3.Margin = New Padding(2, 2, 2, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(187, 31)
        TextBox3.TabIndex = 49
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(134, 227)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(187, 31)
        TextBox2.TabIndex = 48
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(12, 470)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(115, 25)
        Label14.TabIndex = 46
        Label14.Text = "Date Of Birth"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(30, 663)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(50, 25)
        Label13.TabIndex = 45
        Label13.Text = "Time"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 619)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(115, 25)
        Label12.TabIndex = 44
        Label12.Text = "Starting Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 581)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 25)
        Label11.TabIndex = 43
        Label11.Text = "Contract Type"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 548)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 25)
        Label10.TabIndex = 42
        Label10.Text = "Education"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 509)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 25)
        Label9.TabIndex = 41
        Label9.Text = "Nationality"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 427)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 25)
        Label8.TabIndex = 40
        Label8.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 388)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 39
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 347)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 25)
        Label6.TabIndex = 38
        Label6.Text = "Contact No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 305)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 37
        Label5.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 268)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 25)
        Label4.TabIndex = 36
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 228)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 35
        Label3.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 186)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 34
        Label2.Text = "Instructor Id"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(45, 28)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 32)
        Label1.TabIndex = 0
        Label1.Text = "Instructor Dashboard"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 191)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(76, 31)
        TextBox1.TabIndex = 47
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(402, 16)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(362, 87)
        Panel1.TabIndex = 33
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1247, 815)
        Controls.Add(btnremove)
        Controls.Add(btnexit)
        Controls.Add(btnadd)
        Controls.Add(btnupdate)
        Controls.Add(btninsert)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox4)
        Controls.Add(DateTimePicker2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox7)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Instructer Dashboard"
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
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
