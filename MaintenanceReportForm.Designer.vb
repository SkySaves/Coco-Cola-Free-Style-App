<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceReportForm
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
        Me.btnMaintOkay = New System.Windows.Forms.Button()
        Me.txtMaintenanceReport = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMaintOkay
        '
        Me.btnMaintOkay.Location = New System.Drawing.Point(606, 389)
        Me.btnMaintOkay.Name = "btnMaintOkay"
        Me.btnMaintOkay.Size = New System.Drawing.Size(87, 35)
        Me.btnMaintOkay.TabIndex = 3
        Me.btnMaintOkay.Text = "Okay"
        Me.btnMaintOkay.UseVisualStyleBackColor = True
        '
        'txtMaintenanceReport
        '
        Me.txtMaintenanceReport.Location = New System.Drawing.Point(108, 27)
        Me.txtMaintenanceReport.Multiline = True
        Me.txtMaintenanceReport.Name = "txtMaintenanceReport"
        Me.txtMaintenanceReport.Size = New System.Drawing.Size(531, 310)
        Me.txtMaintenanceReport.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Use up/down arrow keys to navigate"
        '
        'MaintenanceReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMaintOkay)
        Me.Controls.Add(Me.txtMaintenanceReport)
        Me.Name = "MaintenanceReportForm"
        Me.Text = "Maintenance Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMaintOkay As Button
    Friend WithEvents txtMaintenanceReport As TextBox
    Friend WithEvents Label1 As Label
End Class
