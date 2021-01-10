<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnHomePro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnMaterials = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeAdvPay = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeAttendance = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeWorkers = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeSalary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox3)
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox2)
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(542, 36)
        Me.GunaPanel1.TabIndex = 76
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.CustomIconSize = 12.0!
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(450, 10)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox3.TabIndex = 57
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.CustomIconSize = 12.0!
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(479, 10)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox2.TabIndex = 56
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(506, 10)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox1.TabIndex = 55
        '
        'btnHomePro
        '
        Me.btnHomePro.AnimationHoverSpeed = 0.07!
        Me.btnHomePro.AnimationSpeed = 0.03!
        Me.btnHomePro.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePro.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomePro.BorderColor = System.Drawing.Color.Black
        Me.btnHomePro.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomePro.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomePro.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomePro.CheckedImage = CType(resources.GetObject("btnHomePro.CheckedImage"), System.Drawing.Image)
        Me.btnHomePro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomePro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomePro.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomePro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePro.ForeColor = System.Drawing.Color.White
        Me.btnHomePro.Image = Nothing
        Me.btnHomePro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomePro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomePro.Location = New System.Drawing.Point(36, 134)
        Me.btnHomePro.Name = "btnHomePro"
        Me.btnHomePro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomePro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomePro.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomePro.OnHoverImage = Nothing
        Me.btnHomePro.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomePro.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomePro.Radius = 15
        Me.btnHomePro.Size = New System.Drawing.Size(213, 56)
        Me.btnHomePro.TabIndex = 64
        Me.btnHomePro.Text = "Projects"
        Me.btnHomePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMaterials
        '
        Me.btnMaterials.AnimationHoverSpeed = 0.07!
        Me.btnMaterials.AnimationSpeed = 0.03!
        Me.btnMaterials.BackColor = System.Drawing.Color.Transparent
        Me.btnMaterials.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnMaterials.BorderColor = System.Drawing.Color.Black
        Me.btnMaterials.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnMaterials.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnMaterials.CheckedForeColor = System.Drawing.Color.White
        Me.btnMaterials.CheckedImage = CType(resources.GetObject("btnMaterials.CheckedImage"), System.Drawing.Image)
        Me.btnMaterials.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnMaterials.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMaterials.FocusedColor = System.Drawing.Color.Empty
        Me.btnMaterials.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterials.ForeColor = System.Drawing.Color.White
        Me.btnMaterials.Image = Nothing
        Me.btnMaterials.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMaterials.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMaterials.Location = New System.Drawing.Point(274, 285)
        Me.btnMaterials.Name = "btnMaterials"
        Me.btnMaterials.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaterials.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMaterials.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMaterials.OnHoverImage = Nothing
        Me.btnMaterials.OnHoverLineColor = System.Drawing.Color.White
        Me.btnMaterials.OnPressedColor = System.Drawing.Color.Black
        Me.btnMaterials.Radius = 15
        Me.btnMaterials.Size = New System.Drawing.Size(213, 56)
        Me.btnMaterials.TabIndex = 70
        Me.btnMaterials.Text = "Materials"
        Me.btnMaterials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHomeAdvPay
        '
        Me.btnHomeAdvPay.AnimationHoverSpeed = 0.07!
        Me.btnHomeAdvPay.AnimationSpeed = 0.03!
        Me.btnHomeAdvPay.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeAdvPay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomeAdvPay.BorderColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomeAdvPay.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.CheckedImage = CType(resources.GetObject("btnHomeAdvPay.CheckedImage"), System.Drawing.Image)
        Me.btnHomeAdvPay.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomeAdvPay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeAdvPay.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeAdvPay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeAdvPay.ForeColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.Image = Nothing
        Me.btnHomeAdvPay.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeAdvPay.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeAdvPay.Location = New System.Drawing.Point(36, 285)
        Me.btnHomeAdvPay.Name = "btnHomeAdvPay"
        Me.btnHomeAdvPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeAdvPay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.OnHoverImage = Nothing
        Me.btnHomeAdvPay.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.Radius = 15
        Me.btnHomeAdvPay.Size = New System.Drawing.Size(213, 56)
        Me.btnHomeAdvPay.TabIndex = 65
        Me.btnHomeAdvPay.Text = "Advance Payment"
        Me.btnHomeAdvPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHomeAttendance
        '
        Me.btnHomeAttendance.AnimationHoverSpeed = 0.07!
        Me.btnHomeAttendance.AnimationSpeed = 0.03!
        Me.btnHomeAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomeAttendance.BorderColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomeAttendance.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomeAttendance.CheckedImage = CType(resources.GetObject("btnHomeAttendance.CheckedImage"), System.Drawing.Image)
        Me.btnHomeAttendance.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomeAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeAttendance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeAttendance.ForeColor = System.Drawing.Color.White
        Me.btnHomeAttendance.Image = Nothing
        Me.btnHomeAttendance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeAttendance.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeAttendance.Location = New System.Drawing.Point(274, 134)
        Me.btnHomeAttendance.Name = "btnHomeAttendance"
        Me.btnHomeAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeAttendance.OnHoverImage = Nothing
        Me.btnHomeAttendance.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.Radius = 15
        Me.btnHomeAttendance.Size = New System.Drawing.Size(213, 56)
        Me.btnHomeAttendance.TabIndex = 66
        Me.btnHomeAttendance.Text = "Attendance"
        Me.btnHomeAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHomeWorkers
        '
        Me.btnHomeWorkers.AnimationHoverSpeed = 0.07!
        Me.btnHomeWorkers.AnimationSpeed = 0.03!
        Me.btnHomeWorkers.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeWorkers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomeWorkers.BorderColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomeWorkers.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomeWorkers.CheckedImage = CType(resources.GetObject("btnHomeWorkers.CheckedImage"), System.Drawing.Image)
        Me.btnHomeWorkers.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomeWorkers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeWorkers.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeWorkers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeWorkers.ForeColor = System.Drawing.Color.White
        Me.btnHomeWorkers.Image = Nothing
        Me.btnHomeWorkers.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeWorkers.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeWorkers.Location = New System.Drawing.Point(36, 206)
        Me.btnHomeWorkers.Name = "btnHomeWorkers"
        Me.btnHomeWorkers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeWorkers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeWorkers.OnHoverImage = Nothing
        Me.btnHomeWorkers.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeWorkers.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.Radius = 15
        Me.btnHomeWorkers.Size = New System.Drawing.Size(213, 56)
        Me.btnHomeWorkers.TabIndex = 67
        Me.btnHomeWorkers.Text = "Employees"
        Me.btnHomeWorkers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHomeSalary
        '
        Me.btnHomeSalary.AnimationHoverSpeed = 0.07!
        Me.btnHomeSalary.AnimationSpeed = 0.03!
        Me.btnHomeSalary.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeSalary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomeSalary.BorderColor = System.Drawing.Color.Black
        Me.btnHomeSalary.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomeSalary.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomeSalary.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomeSalary.CheckedImage = CType(resources.GetObject("btnHomeSalary.CheckedImage"), System.Drawing.Image)
        Me.btnHomeSalary.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomeSalary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeSalary.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeSalary.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeSalary.ForeColor = System.Drawing.Color.White
        Me.btnHomeSalary.Image = Nothing
        Me.btnHomeSalary.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeSalary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeSalary.Location = New System.Drawing.Point(274, 206)
        Me.btnHomeSalary.Name = "btnHomeSalary"
        Me.btnHomeSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeSalary.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeSalary.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeSalary.OnHoverImage = Nothing
        Me.btnHomeSalary.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeSalary.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeSalary.Radius = 15
        Me.btnHomeSalary.Size = New System.Drawing.Size(213, 56)
        Me.btnHomeSalary.TabIndex = 68
        Me.btnHomeSalary.Text = "Salary"
        Me.btnHomeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(175, 58)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(162, 43)
        Me.GunaLabel8.TabIndex = 75
        Me.GunaLabel8.Text = "Reports"
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 370)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.btnHomePro)
        Me.Controls.Add(Me.btnMaterials)
        Me.Controls.Add(Me.btnHomeAdvPay)
        Me.Controls.Add(Me.btnHomeWorkers)
        Me.Controls.Add(Me.btnHomeAttendance)
        Me.Controls.Add(Me.btnHomeSalary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnHomePro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnMaterials As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeAdvPay As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeAttendance As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeWorkers As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeSalary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
