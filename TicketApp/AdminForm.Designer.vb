<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtOrigin = New System.Windows.Forms.ComboBox()
        Me.TxtDestination = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtGender = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.TxtTotalFees = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDiscount = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTravelClass = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNationality = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Passenger Record "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Origin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Destination"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(6, 44)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(196, 20)
        Me.TxtName.TabIndex = 5
        '
        'TxtOrigin
        '
        Me.TxtOrigin.FormattingEnabled = True
        Me.TxtOrigin.Items.AddRange(New Object() {"Berlin", "Philadelphia"})
        Me.TxtOrigin.Location = New System.Drawing.Point(6, 184)
        Me.TxtOrigin.Name = "TxtOrigin"
        Me.TxtOrigin.Size = New System.Drawing.Size(196, 21)
        Me.TxtOrigin.TabIndex = 7
        '
        'TxtDestination
        '
        Me.TxtDestination.FormattingEnabled = True
        Me.TxtDestination.Items.AddRange(New Object() {"Philadelphia", "Hiroshima"})
        Me.TxtDestination.Location = New System.Drawing.Point(6, 234)
        Me.TxtDestination.Name = "TxtDestination"
        Me.TxtDestination.Size = New System.Drawing.Size(196, 21)
        Me.TxtDestination.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ClearBtn)
        Me.GroupBox3.Controls.Add(Me.BtnDelete)
        Me.GroupBox3.Controls.Add(Me.BtnEdit)
        Me.GroupBox3.Controls.Add(Me.BtnInsert)
        Me.GroupBox3.Location = New System.Drawing.Point(723, 548)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 99)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'ClearBtn
        '
        Me.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearBtn.Location = New System.Drawing.Point(6, 58)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(90, 33)
        Me.ClearBtn.TabIndex = 3
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Location = New System.Drawing.Point(112, 58)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 33)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Location = New System.Drawing.Point(112, 18)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(90, 33)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInsert.Location = New System.Drawing.Point(6, 18)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(90, 33)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(681, 569)
        Me.DataGridView1.TabIndex = 10
        '
        'TxtGender
        '
        Me.TxtGender.FormattingEnabled = True
        Me.TxtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.TxtGender.Location = New System.Drawing.Point(6, 136)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(196, 21)
        Me.TxtGender.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCheck)
        Me.GroupBox1.Controls.Add(Me.TxtTotalFees)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtDiscount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtTravelClass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNationality)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.TxtGender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDestination)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtOrigin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(723, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 464)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile"
        '
        'BtnCheck
        '
        Me.BtnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCheck.Location = New System.Drawing.Point(6, 422)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(196, 33)
        Me.BtnCheck.TabIndex = 4
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'TxtTotalFees
        '
        Me.TxtTotalFees.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtTotalFees.Location = New System.Drawing.Point(6, 384)
        Me.TxtTotalFees.Name = "TxtTotalFees"
        Me.TxtTotalFees.ReadOnly = True
        Me.TxtTotalFees.Size = New System.Drawing.Size(196, 20)
        Me.TxtTotalFees.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Total Fees (Readonly)"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.FormattingEnabled = True
        Me.TxtDiscount.Items.AddRange(New Object() {"Ukrainian Citizenship - 75% Discount", "People With Disability - 75% Discount", "Single Parent Family - 75% Discount", "None of them - No Discount"})
        Me.TxtDiscount.Location = New System.Drawing.Point(6, 332)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(196, 21)
        Me.TxtDiscount.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Discount"
        '
        'TxtTravelClass
        '
        Me.TxtTravelClass.FormattingEnabled = True
        Me.TxtTravelClass.Items.AddRange(New Object() {"First Class", "Business Class", "Economy Class"})
        Me.TxtTravelClass.Location = New System.Drawing.Point(6, 283)
        Me.TxtTravelClass.Name = "TxtTravelClass"
        Me.TxtTravelClass.Size = New System.Drawing.Size(196, 21)
        Me.TxtTravelClass.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Travel Class"
        '
        'TxtNationality
        '
        Me.TxtNationality.Location = New System.Drawing.Point(6, 89)
        Me.TxtNationality.Name = "TxtNationality"
        Me.TxtNationality.Size = New System.Drawing.Size(196, 20)
        Me.TxtNationality.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nationality"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(841, 41)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 23)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(973, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminForm"
        Me.Tag = ""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtOrigin As ComboBox
    Friend WithEvents TxtDestination As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtGender As ComboBox
    Friend WithEvents ClearBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNationality As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDiscount As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTravelClass As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalFees As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnCheck As Button
    Friend WithEvents btnLogout As Button
End Class
