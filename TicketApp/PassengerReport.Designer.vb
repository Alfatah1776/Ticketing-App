<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassengerReport
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
        Me.CRVPassenger = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVPassenger
        '
        Me.CRVPassenger.ActiveViewIndex = -1
        Me.CRVPassenger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPassenger.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPassenger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPassenger.Location = New System.Drawing.Point(0, 0)
        Me.CRVPassenger.Name = "CRVPassenger"
        Me.CRVPassenger.Size = New System.Drawing.Size(1381, 647)
        Me.CRVPassenger.TabIndex = 0
        '
        'PassengerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 647)
        Me.Controls.Add(Me.CRVPassenger)
        Me.Name = "PassengerReport"
        Me.Text = "PassengerReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVPassenger As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
