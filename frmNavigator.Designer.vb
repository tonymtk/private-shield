<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavigator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNavigator))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.OpenLinkButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.LinkBox = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.Label()
        Me.LinkBox2 = New System.Windows.Forms.TextBox()
        Me.CopyButton2 = New System.Windows.Forms.Button()
        Me.LinkBox3 = New System.Windows.Forms.TextBox()
        Me.CopyButton3 = New System.Windows.Forms.Button()
        Me.LinkBox4 = New System.Windows.Forms.TextBox()
        Me.CopyButton4 = New System.Windows.Forms.Button()
        Me.OpenLinkButton2 = New System.Windows.Forms.Button()
        Me.OpenLinkButton3 = New System.Windows.Forms.Button()
        Me.OpenLinkButton4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(207, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.CloseButton.Size = New System.Drawing.Size(258, 31)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Sair"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'OpenLinkButton
        '
        Me.OpenLinkButton.Location = New System.Drawing.Point(388, 61)
        Me.OpenLinkButton.Name = "OpenLinkButton"
        Me.OpenLinkButton.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.OpenLinkButton.Size = New System.Drawing.Size(77, 23)
        Me.OpenLinkButton.TabIndex = 2
        Me.OpenLinkButton.Text = "Abrir Link"
        Me.OpenLinkButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(310, 61)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.CopyButton.Size = New System.Drawing.Size(72, 23)
        Me.CopyButton.TabIndex = 3
        Me.CopyButton.Text = "Copiar Link"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'LinkBox
        '
        Me.LinkBox.Enabled = False
        Me.LinkBox.Location = New System.Drawing.Point(19, 61)
        Me.LinkBox.Name = "LinkBox"
        Me.LinkBox.Size = New System.Drawing.Size(285, 20)
        Me.LinkBox.TabIndex = 4
        Me.LinkBox.Text = "http://www.rpdev.cf"
        '
        'Logo
        '
        Me.Logo.AutoSize = True
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logo.ForeColor = System.Drawing.Color.Turquoise
        Me.Logo.Location = New System.Drawing.Point(12, 9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(189, 40)
        Me.Logo.TabIndex = 5
        Me.Logo.Text = "SERVIDORES"
        '
        'LinkBox2
        '
        Me.LinkBox2.Enabled = False
        Me.LinkBox2.Location = New System.Drawing.Point(19, 87)
        Me.LinkBox2.Name = "LinkBox2"
        Me.LinkBox2.Size = New System.Drawing.Size(285, 20)
        Me.LinkBox2.TabIndex = 7
        Me.LinkBox2.Text = "http://server01.rpdev.cf"
        '
        'CopyButton2
        '
        Me.CopyButton2.Location = New System.Drawing.Point(310, 87)
        Me.CopyButton2.Name = "CopyButton2"
        Me.CopyButton2.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.CopyButton2.Size = New System.Drawing.Size(72, 23)
        Me.CopyButton2.TabIndex = 6
        Me.CopyButton2.Text = "Copiar Link"
        Me.CopyButton2.UseVisualStyleBackColor = True
        '
        'LinkBox3
        '
        Me.LinkBox3.Enabled = False
        Me.LinkBox3.Location = New System.Drawing.Point(19, 113)
        Me.LinkBox3.Name = "LinkBox3"
        Me.LinkBox3.Size = New System.Drawing.Size(285, 20)
        Me.LinkBox3.TabIndex = 9
        Me.LinkBox3.Text = "http://server02.rpdev.cf"
        '
        'CopyButton3
        '
        Me.CopyButton3.Location = New System.Drawing.Point(310, 113)
        Me.CopyButton3.Name = "CopyButton3"
        Me.CopyButton3.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.CopyButton3.Size = New System.Drawing.Size(72, 23)
        Me.CopyButton3.TabIndex = 8
        Me.CopyButton3.Text = "Copiar Link"
        Me.CopyButton3.UseVisualStyleBackColor = True
        '
        'LinkBox4
        '
        Me.LinkBox4.Enabled = False
        Me.LinkBox4.Location = New System.Drawing.Point(19, 139)
        Me.LinkBox4.Name = "LinkBox4"
        Me.LinkBox4.Size = New System.Drawing.Size(285, 20)
        Me.LinkBox4.TabIndex = 11
        Me.LinkBox4.Text = "http://server03.rpdev.cf"
        '
        'CopyButton4
        '
        Me.CopyButton4.Location = New System.Drawing.Point(310, 139)
        Me.CopyButton4.Name = "CopyButton4"
        Me.CopyButton4.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.CopyButton4.Size = New System.Drawing.Size(72, 23)
        Me.CopyButton4.TabIndex = 10
        Me.CopyButton4.Text = "Copiar Link"
        Me.CopyButton4.UseVisualStyleBackColor = True
        '
        'OpenLinkButton2
        '
        Me.OpenLinkButton2.Location = New System.Drawing.Point(388, 87)
        Me.OpenLinkButton2.Name = "OpenLinkButton2"
        Me.OpenLinkButton2.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.OpenLinkButton2.Size = New System.Drawing.Size(77, 23)
        Me.OpenLinkButton2.TabIndex = 12
        Me.OpenLinkButton2.Text = "Abrir Link"
        Me.OpenLinkButton2.UseVisualStyleBackColor = True
        '
        'OpenLinkButton3
        '
        Me.OpenLinkButton3.Location = New System.Drawing.Point(388, 113)
        Me.OpenLinkButton3.Name = "OpenLinkButton3"
        Me.OpenLinkButton3.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.OpenLinkButton3.Size = New System.Drawing.Size(77, 23)
        Me.OpenLinkButton3.TabIndex = 13
        Me.OpenLinkButton3.Text = "Abrir Link"
        Me.OpenLinkButton3.UseVisualStyleBackColor = True
        '
        'OpenLinkButton4
        '
        Me.OpenLinkButton4.Location = New System.Drawing.Point(388, 139)
        Me.OpenLinkButton4.Name = "OpenLinkButton4"
        Me.OpenLinkButton4.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.OpenLinkButton4.Size = New System.Drawing.Size(77, 23)
        Me.OpenLinkButton4.TabIndex = 14
        Me.OpenLinkButton4.Text = "Abrir Link"
        Me.OpenLinkButton4.UseVisualStyleBackColor = True
        '
        'frmNavigator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.PrivateShield.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(473, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.OpenLinkButton4)
        Me.Controls.Add(Me.OpenLinkButton3)
        Me.Controls.Add(Me.OpenLinkButton2)
        Me.Controls.Add(Me.LinkBox4)
        Me.Controls.Add(Me.CopyButton4)
        Me.Controls.Add(Me.LinkBox3)
        Me.Controls.Add(Me.CopyButton3)
        Me.Controls.Add(Me.LinkBox2)
        Me.Controls.Add(Me.CopyButton2)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.LinkBox)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.OpenLinkButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNavigator"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navegador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents OpenLinkButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents LinkBox As System.Windows.Forms.TextBox
    Friend WithEvents Logo As System.Windows.Forms.Label
    Friend WithEvents LinkBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CopyButton2 As System.Windows.Forms.Button
    Friend WithEvents LinkBox3 As System.Windows.Forms.TextBox
    Friend WithEvents CopyButton3 As System.Windows.Forms.Button
    Friend WithEvents LinkBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CopyButton4 As System.Windows.Forms.Button
    Friend WithEvents OpenLinkButton2 As System.Windows.Forms.Button
    Friend WithEvents OpenLinkButton3 As System.Windows.Forms.Button
    Friend WithEvents OpenLinkButton4 As System.Windows.Forms.Button
End Class
