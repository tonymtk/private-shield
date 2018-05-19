<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerify))
        Me.Logo = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.VerifyOnline = New System.Windows.Forms.Timer(Me.components)
        Me.SafeButton = New System.Windows.Forms.Button()
        Me.ProcessBox = New System.Windows.Forms.TextBox()
        Me.LabelProcessBox = New System.Windows.Forms.Label()
        Me.LabelEdition = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SiteButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.AutoSize = True
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logo.ForeColor = System.Drawing.Color.Turquoise
        Me.Logo.Location = New System.Drawing.Point(117, 9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(235, 40)
        Me.Logo.TabIndex = 0
        Me.Logo.Text = "PRIVATESHIELD"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(423, 223)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(34, 24)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'VerifyOnline
        '
        '
        'SafeButton
        '
        Me.SafeButton.Location = New System.Drawing.Point(189, 152)
        Me.SafeButton.Name = "SafeButton"
        Me.SafeButton.Size = New System.Drawing.Size(90, 24)
        Me.SafeButton.TabIndex = 2
        Me.SafeButton.Text = "Ativar"
        Me.SafeButton.UseVisualStyleBackColor = True
        '
        'ProcessBox
        '
        Me.ProcessBox.Location = New System.Drawing.Point(117, 126)
        Me.ProcessBox.Name = "ProcessBox"
        Me.ProcessBox.Size = New System.Drawing.Size(238, 20)
        Me.ProcessBox.TabIndex = 3
        Me.ProcessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelProcessBox
        '
        Me.LabelProcessBox.AutoSize = True
        Me.LabelProcessBox.BackColor = System.Drawing.Color.Transparent
        Me.LabelProcessBox.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcessBox.ForeColor = System.Drawing.Color.White
        Me.LabelProcessBox.Location = New System.Drawing.Point(181, 99)
        Me.LabelProcessBox.Name = "LabelProcessBox"
        Me.LabelProcessBox.Size = New System.Drawing.Size(106, 24)
        Me.LabelProcessBox.TabIndex = 4
        Me.LabelProcessBox.Text = "PROCESSO:"
        '
        'LabelEdition
        '
        Me.LabelEdition.AutoSize = True
        Me.LabelEdition.BackColor = System.Drawing.Color.Transparent
        Me.LabelEdition.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdition.ForeColor = System.Drawing.Color.White
        Me.LabelEdition.Location = New System.Drawing.Point(102, 221)
        Me.LabelEdition.Name = "LabelEdition"
        Me.LabelEdition.Size = New System.Drawing.Size(90, 24)
        Me.LabelEdition.TabIndex = 5
        Me.LabelEdition.Text = "DIDÁTICO"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.Color.White
        Me.LabelVersion.Location = New System.Drawing.Point(14, 221)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(82, 24)
        Me.LabelVersion.TabIndex = 6
        Me.LabelVersion.Text = "V2.0.0.0"
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(352, 223)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(65, 24)
        Me.AboutButton.TabIndex = 7
        Me.AboutButton.Text = "Sobre"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'SiteButton
        '
        Me.SiteButton.Location = New System.Drawing.Point(257, 223)
        Me.SiteButton.Name = "SiteButton"
        Me.SiteButton.Size = New System.Drawing.Size(89, 24)
        Me.SiteButton.TabIndex = 8
        Me.SiteButton.Text = "RpDev.cf"
        Me.SiteButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PrivateShield.My.Resources.Resources.robot
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(352, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 65)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmVerify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.PrivateShield.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(469, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SiteButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelEdition)
        Me.Controls.Add(Me.LabelProcessBox)
        Me.Controls.Add(Me.ProcessBox)
        Me.Controls.Add(Me.SafeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerify"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents VerifyOnline As System.Windows.Forms.Timer
    Friend WithEvents SafeButton As System.Windows.Forms.Button
    Friend WithEvents ProcessBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelProcessBox As System.Windows.Forms.Label
    Friend WithEvents LabelEdition As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents SiteButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
