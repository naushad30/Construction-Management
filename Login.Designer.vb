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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtUser = New Guna.UI.WinForms.GunaTextBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtPass = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnFog = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BaseColor = System.Drawing.Color.White
        Me.txtUser.BorderColor = System.Drawing.Color.DimGray
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(162, 155)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.Radius = 15
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(259, 42)
        Me.txtUser.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnLogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedForeColor = System.Drawing.Color.White
        Me.btnLogin.CheckedImage = CType(resources.GetObject("btnLogin.CheckedImage"), System.Drawing.Image)
        Me.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(162, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnHoverLineColor = System.Drawing.Color.White
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 15
        Me.btnLogin.Size = New System.Drawing.Size(259, 46)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BaseColor = System.Drawing.Color.White
        Me.txtPass.BorderColor = System.Drawing.Color.DimGray
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(162, 224)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Radius = 15
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(259, 42)
        Me.txtPass.TabIndex = 3
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(35, 232)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(100, 22)
        Me.GunaLabel3.TabIndex = 1
        Me.GunaLabel3.Text = "Password"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(32, 163)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(103, 22)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Username"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.GunaPanel1.Controls.Add(Me.Guna2ImageButton1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(472, 38)
        Me.GunaPanel1.TabIndex = 4
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.CustomIconSize = 12.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(437, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ImageButton1.HoverState.Image = CType(resources.GetObject("Guna2ImageButton1.HoverState.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(937, 5)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.TabIndex = 62
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(229, 69)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(118, 43)
        Me.GunaLabel8.TabIndex = 0
        Me.GunaLabel8.Text = "Login"
        '
        'btnFog
        '
        Me.btnFog.AnimationHoverSpeed = 0.07!
        Me.btnFog.AnimationSpeed = 0.03!
        Me.btnFog.BackColor = System.Drawing.Color.Transparent
        Me.btnFog.BaseColor = System.Drawing.Color.Transparent
        Me.btnFog.BorderColor = System.Drawing.Color.Transparent
        Me.btnFog.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnFog.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnFog.CheckedForeColor = System.Drawing.Color.White
        Me.btnFog.CheckedImage = CType(resources.GetObject("btnFog.CheckedImage"), System.Drawing.Image)
        Me.btnFog.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnFog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFog.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFog.FocusedColor = System.Drawing.Color.Empty
        Me.btnFog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnFog.ForeColor = System.Drawing.Color.DimGray
        Me.btnFog.Image = Nothing
        Me.btnFog.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFog.LineColor = System.Drawing.Color.Transparent
        Me.btnFog.Location = New System.Drawing.Point(290, 272)
        Me.btnFog.Name = "btnFog"
        Me.btnFog.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnFog.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnFog.OnHoverForeColor = System.Drawing.Color.Red
        Me.btnFog.OnHoverImage = Nothing
        Me.btnFog.OnHoverLineColor = System.Drawing.Color.White
        Me.btnFog.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnFog.Size = New System.Drawing.Size(131, 20)
        Me.btnFog.TabIndex = 5
        Me.btnFog.Text = "Forgot Password?"
        Me.btnFog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(267, 350)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(154, 20)
        Me.GunaAdvenceButton1.TabIndex = 6
        Me.GunaAdvenceButton1.Text = "Create New Account"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 411)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btnFog)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnFog As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
