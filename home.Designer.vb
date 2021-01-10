<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnHomePro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeAdvPay = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeAttendance = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeReports = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeWorkers = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnHomeSalary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnFog = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox3)
        Me.GunaPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(532, 38)
        Me.GunaPanel1.TabIndex = 36
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
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(469, 12)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox3.TabIndex = 74
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(498, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 17)
        Me.Guna2ControlBox1.TabIndex = 72
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(30, 66)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(464, 55)
        Me.GunaLabel8.TabIndex = 58
        Me.GunaLabel8.Text = "S && S Construction"
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
        Me.btnHomePro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePro.ForeColor = System.Drawing.Color.White
        Me.btnHomePro.Image = Nothing
        Me.btnHomePro.ImageOffsetX = 15
        Me.btnHomePro.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnHomePro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomePro.Location = New System.Drawing.Point(138, 142)
        Me.btnHomePro.Name = "btnHomePro"
        Me.btnHomePro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomePro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomePro.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomePro.OnHoverImage = Nothing
        Me.btnHomePro.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomePro.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomePro.Radius = 15
        Me.btnHomePro.Size = New System.Drawing.Size(276, 56)
        Me.btnHomePro.TabIndex = 59
        Me.btnHomePro.Text = "Projects"
        Me.btnHomePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnHomeAdvPay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeAdvPay.ForeColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.Image = Nothing
        Me.btnHomeAdvPay.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeAdvPay.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeAdvPay.Location = New System.Drawing.Point(138, 452)
        Me.btnHomeAdvPay.Name = "btnHomeAdvPay"
        Me.btnHomeAdvPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeAdvPay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.OnHoverImage = Nothing
        Me.btnHomeAdvPay.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeAdvPay.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeAdvPay.Radius = 15
        Me.btnHomeAdvPay.Size = New System.Drawing.Size(276, 56)
        Me.btnHomeAdvPay.TabIndex = 60
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
        Me.btnHomeAttendance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeAttendance.ForeColor = System.Drawing.Color.White
        Me.btnHomeAttendance.Image = Nothing
        Me.btnHomeAttendance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeAttendance.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeAttendance.Location = New System.Drawing.Point(138, 204)
        Me.btnHomeAttendance.Name = "btnHomeAttendance"
        Me.btnHomeAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeAttendance.OnHoverImage = Nothing
        Me.btnHomeAttendance.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeAttendance.Radius = 15
        Me.btnHomeAttendance.Size = New System.Drawing.Size(276, 56)
        Me.btnHomeAttendance.TabIndex = 61
        Me.btnHomeAttendance.Text = "Attendance"
        Me.btnHomeAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHomeReports
        '
        Me.btnHomeReports.AnimationHoverSpeed = 0.07!
        Me.btnHomeReports.AnimationSpeed = 0.03!
        Me.btnHomeReports.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeReports.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnHomeReports.BorderColor = System.Drawing.Color.Black
        Me.btnHomeReports.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHomeReports.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHomeReports.CheckedForeColor = System.Drawing.Color.White
        Me.btnHomeReports.CheckedImage = CType(resources.GetObject("btnHomeReports.CheckedImage"), System.Drawing.Image)
        Me.btnHomeReports.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHomeReports.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeReports.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeReports.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeReports.ForeColor = System.Drawing.Color.White
        Me.btnHomeReports.Image = Nothing
        Me.btnHomeReports.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeReports.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeReports.Location = New System.Drawing.Point(138, 514)
        Me.btnHomeReports.Name = "btnHomeReports"
        Me.btnHomeReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeReports.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeReports.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeReports.OnHoverImage = Nothing
        Me.btnHomeReports.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeReports.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeReports.Radius = 15
        Me.btnHomeReports.Size = New System.Drawing.Size(276, 56)
        Me.btnHomeReports.TabIndex = 64
        Me.btnHomeReports.Text = "Reports"
        Me.btnHomeReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnHomeWorkers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeWorkers.ForeColor = System.Drawing.Color.White
        Me.btnHomeWorkers.Image = Nothing
        Me.btnHomeWorkers.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeWorkers.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeWorkers.Location = New System.Drawing.Point(138, 266)
        Me.btnHomeWorkers.Name = "btnHomeWorkers"
        Me.btnHomeWorkers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeWorkers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeWorkers.OnHoverImage = Nothing
        Me.btnHomeWorkers.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeWorkers.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeWorkers.Radius = 15
        Me.btnHomeWorkers.Size = New System.Drawing.Size(276, 56)
        Me.btnHomeWorkers.TabIndex = 62
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
        Me.btnHomeSalary.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeSalary.ForeColor = System.Drawing.Color.White
        Me.btnHomeSalary.Image = Nothing
        Me.btnHomeSalary.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHomeSalary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHomeSalary.Location = New System.Drawing.Point(138, 390)
        Me.btnHomeSalary.Name = "btnHomeSalary"
        Me.btnHomeSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHomeSalary.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeSalary.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeSalary.OnHoverImage = Nothing
        Me.btnHomeSalary.OnHoverLineColor = System.Drawing.Color.White
        Me.btnHomeSalary.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeSalary.Radius = 15
        Me.btnHomeSalary.Size = New System.Drawing.Size(276, 56)
        Me.btnHomeSalary.TabIndex = 63
        Me.btnHomeSalary.Text = "Salary"
        Me.btnHomeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(138, 328)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 15
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(276, 56)
        Me.GunaAdvenceButton1.TabIndex = 66
        Me.GunaAdvenceButton1.Text = "Material"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnFog.Location = New System.Drawing.Point(460, 44)
        Me.btnFog.Name = "btnFog"
        Me.btnFog.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnFog.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnFog.OnHoverForeColor = System.Drawing.Color.Red
        Me.btnFog.OnHoverImage = Nothing
        Me.btnFog.OnHoverLineColor = System.Drawing.Color.White
        Me.btnFog.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnFog.Size = New System.Drawing.Size(61, 19)
        Me.btnFog.TabIndex = 85
        Me.btnFog.Text = "Logout"
        Me.btnFog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 604)
        Me.Controls.Add(Me.btnFog)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btnHomePro)
        Me.Controls.Add(Me.btnHomeAdvPay)
        Me.Controls.Add(Me.btnHomeAttendance)
        Me.Controls.Add(Me.btnHomeReports)
        Me.Controls.Add(Me.btnHomeWorkers)
        Me.Controls.Add(Me.btnHomeSalary)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnHomePro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeAdvPay As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeAttendance As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeReports As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeWorkers As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnHomeSalary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnFog As Guna.UI.WinForms.GunaAdvenceButton
End Class
