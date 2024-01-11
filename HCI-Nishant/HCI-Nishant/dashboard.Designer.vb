<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(dashboard))
        Label1 = New Label()
        Button1 = New Button()
        btninstructer = New Button()
        btnvehicle = New Button()
        btnlogout = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 599)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(790, 48)
        Label1.TabIndex = 0
        Label1.Text = "Welcome To the School Managemnet Stystem"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(28, 269)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 91)
        Button1.TabIndex = 1
        Button1.Text = "Student Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btninstructer
        ' 
        btninstructer.BackColor = Color.Transparent
        btninstructer.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btninstructer.Location = New Point(283, 272)
        btninstructer.Margin = New Padding(2)
        btninstructer.Name = "btninstructer"
        btninstructer.Size = New Size(159, 91)
        btninstructer.TabIndex = 2
        btninstructer.Text = "Instructor Dashboard"
        btninstructer.UseVisualStyleBackColor = False
        ' 
        ' btnvehicle
        ' 
        btnvehicle.BackColor = Color.Transparent
        btnvehicle.Font = New Font("Arial Rounded MT Bold", 10.875F, FontStyle.Regular, GraphicsUnit.Point)
        btnvehicle.Location = New Point(510, 272)
        btnvehicle.Margin = New Padding(2)
        btnvehicle.Name = "btnvehicle"
        btnvehicle.Size = New Size(146, 92)
        btnvehicle.TabIndex = 3
        btnvehicle.Text = "Vehicle Dashboard"
        btnvehicle.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.Transparent
        btnlogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnlogout.Location = New Point(783, 16)
        btnlogout.Margin = New Padding(2)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(128, 65)
        btnlogout.TabIndex = 4
        btnlogout.Text = "Log Out"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(700, 273)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 91)
        Button2.TabIndex = 5
        Button2.Text = "Course Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(915, 661)
        Controls.Add(Button2)
        Controls.Add(btnlogout)
        Controls.Add(btnvehicle)
        Controls.Add(btninstructer)
        Controls.Add(Button1)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "dashboard"
        Text = "dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btninstructer As Button
    Friend WithEvents btnvehicle As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Button2 As Button
End Class
