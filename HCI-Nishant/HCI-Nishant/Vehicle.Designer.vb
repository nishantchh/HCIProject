<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Vehicle))
        Label1 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Textmodel = New TextBox()
        Textbrand = New TextBox()
        Textmilege = New TextBox()
        Textengin = New TextBox()
        ComboBox1 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        ComboBox2 = New ComboBox()
        DataGridView1 = New DataGridView()
        btnremove = New Button()
        btnexit = New Button()
        btnadd = New Button()
        btnupdate = New Button()
        btninsert = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(324, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 48)
        Label1.TabIndex = 0
        Label1.Text = "Vehicle Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(126, 9)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 79)
        Panel1.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(130, 222)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 25)
        Label7.TabIndex = 0
        Label7.Text = "Model"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(126, 257)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 25)
        Label8.TabIndex = 1
        Label8.Text = "Brand"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(126, 289)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 25)
        Label9.TabIndex = 2
        Label9.Text = "Milege"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(130, 441)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 25)
        Label12.TabIndex = 3
        Label12.Text = "Fuel Type"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(130, 400)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(122, 25)
        Label13.TabIndex = 4
        Label13.Text = "Date Of Make"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(130, 327)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(137, 25)
        Label14.TabIndex = 5
        Label14.Text = "Engine Capacity"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(130, 366)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 25)
        Label15.TabIndex = 6
        Label15.Text = "Colour"
        ' 
        ' Textmodel
        ' 
        Textmodel.Location = New Point(275, 216)
        Textmodel.Margin = New Padding(2, 2, 2, 2)
        Textmodel.Name = "Textmodel"
        Textmodel.Size = New Size(251, 31)
        Textmodel.TabIndex = 7
        ' 
        ' Textbrand
        ' 
        Textbrand.Location = New Point(275, 254)
        Textbrand.Margin = New Padding(2, 2, 2, 2)
        Textbrand.Name = "Textbrand"
        Textbrand.Size = New Size(251, 31)
        Textbrand.TabIndex = 8
        ' 
        ' Textmilege
        ' 
        Textmilege.Location = New Point(275, 287)
        Textmilege.Margin = New Padding(2, 2, 2, 2)
        Textmilege.Name = "Textmilege"
        Textmilege.Size = New Size(251, 31)
        Textmilege.TabIndex = 9
        ' 
        ' Textengin
        ' 
        Textengin.Location = New Point(275, 325)
        Textengin.Margin = New Padding(2, 2, 2, 2)
        Textengin.Name = "Textengin"
        Textengin.Size = New Size(251, 31)
        Textengin.TabIndex = 11
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Red", "Black", "Blue", "White", "Other"})
        ComboBox1.Location = New Point(275, 360)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(251, 33)
        ComboBox1.TabIndex = 16
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(275, 396)
        DateTimePicker2.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(251, 31)
        DateTimePicker2.TabIndex = 20
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Petrol", "Disel", "Other"})
        ComboBox2.Location = New Point(275, 441)
        ComboBox2.Margin = New Padding(2, 2, 2, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(251, 33)
        ComboBox2.TabIndex = 39
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(571, 216)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(620, 374)
        DataGridView1.TabIndex = 40
        ' 
        ' btnremove
        ' 
        btnremove.BackColor = Color.Violet
        btnremove.Location = New Point(400, 602)
        btnremove.Margin = New Padding(2, 2, 2, 2)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(138, 59)
        btnremove.TabIndex = 70
        btnremove.Text = "Remove"
        btnremove.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Olive
        btnexit.Location = New Point(1018, 654)
        btnexit.Margin = New Padding(2, 2, 2, 2)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(138, 59)
        btnexit.TabIndex = 69
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.RosyBrown
        btnadd.Location = New Point(400, 495)
        btnadd.Margin = New Padding(2, 2, 2, 2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 59)
        btnadd.TabIndex = 68
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.DarkSlateGray
        btnupdate.Location = New Point(116, 602)
        btnupdate.Margin = New Padding(2, 2, 2, 2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(139, 59)
        btnupdate.TabIndex = 67
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btninsert
        ' 
        btninsert.BackColor = SystemColors.MenuHighlight
        btninsert.Location = New Point(116, 495)
        btninsert.Margin = New Padding(2, 2, 2, 2)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(139, 59)
        btninsert.TabIndex = 66
        btninsert.Text = "Insert"
        btninsert.UseVisualStyleBackColor = False
        ' 
        ' Vehicle
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1211, 741)
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
        Controls.Add(Textengin)
        Controls.Add(Label7)
        Controls.Add(Textmilege)
        Controls.Add(Label8)
        Controls.Add(Textbrand)
        Controls.Add(Label9)
        Controls.Add(Textmodel)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Vehicle"
        Text = "Vehicle"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Textmodel As TextBox
    Friend WithEvents Textbrand As TextBox
    Friend WithEvents Textmilege As TextBox
    Friend WithEvents Textengin As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnremove As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btninsert As Button
End Class
