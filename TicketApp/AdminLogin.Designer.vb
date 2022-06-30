<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.AdminUsername = New System.Windows.Forms.TextBox()
        Me.AdminPassword = New System.Windows.Forms.TextBox()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.AdminPictureBox = New System.Windows.Forms.PictureBox()
        Me.BtnAdminLogin = New System.Windows.Forms.Button()
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(304, 210)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(84, 19)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PasswordLabel.Location = New System.Drawing.Point(304, 251)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(81, 19)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        '
        'AdminUsername
        '
        Me.AdminUsername.Location = New System.Drawing.Point(392, 209)
        Me.AdminUsername.Name = "AdminUsername"
        Me.AdminUsername.Size = New System.Drawing.Size(180, 20)
        Me.AdminUsername.TabIndex = 2
        '
        'AdminPassword
        '
        Me.AdminPassword.Location = New System.Drawing.Point(392, 250)
        Me.AdminPassword.Name = "AdminPassword"
        Me.AdminPassword.Size = New System.Drawing.Size(180, 20)
        Me.AdminPassword.TabIndex = 3
        '
        'AdminPanel
        '
        Me.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminPanel.Location = New System.Drawing.Point(0, 0)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(973, 678)
        Me.AdminPanel.TabIndex = 5
        '
        'AdminPictureBox
        '
        Me.AdminPictureBox.Image = CType(resources.GetObject("AdminPictureBox.Image"), System.Drawing.Image)
        Me.AdminPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.AdminPictureBox.Name = "AdminPictureBox"
        Me.AdminPictureBox.Size = New System.Drawing.Size(973, 678)
        Me.AdminPictureBox.TabIndex = 0
        Me.AdminPictureBox.TabStop = False
        '
        'BtnAdminLogin
        '
        Me.BtnAdminLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminLogin.FlatAppearance.BorderSize = 0
        Me.BtnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminLogin.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminLogin.ForeColor = System.Drawing.Color.White
        Me.BtnAdminLogin.Location = New System.Drawing.Point(392, 292)
        Me.BtnAdminLogin.Name = "BtnAdminLogin"
        Me.BtnAdminLogin.Size = New System.Drawing.Size(180, 28)
        Me.BtnAdminLogin.TabIndex = 6
        Me.BtnAdminLogin.Text = "Login as Admin"
        Me.BtnAdminLogin.UseVisualStyleBackColor = False
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(973, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnAdminLogin)
        Me.Controls.Add(Me.AdminPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.AdminUsername)
        Me.Controls.Add(Me.AdminPictureBox)
        Me.Controls.Add(Me.AdminPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents AdminUsername As TextBox
    Friend WithEvents AdminPassword As TextBox
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents AdminPictureBox As PictureBox
    Friend WithEvents BtnAdminLogin As Button
End Class
