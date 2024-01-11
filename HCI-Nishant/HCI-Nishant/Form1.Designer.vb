<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnlogin = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(572, 114)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(573, 155)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(675, 112)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(675, 155)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(233, 31)
        TextBox2.TabIndex = 3
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(570, 392)
        btnlogin.Margin = New Padding(2, 2, 2, 2)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(115, 36)
        btnlogin.TabIndex = 4
        btnlogin.Text = "Log In"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(787, 392)
        btnexit.Margin = New Padding(2, 2, 2, 2)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(115, 36)
        btnexit.TabIndex = 5
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(960, 495)
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
End Class
