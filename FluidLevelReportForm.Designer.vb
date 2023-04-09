<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FluidLevelReportForm
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
        Me.btnFluidLevelOk = New System.Windows.Forms.Button()
        Me.txtFluidLevelReport = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFluidLevelOk
        '
        Me.btnFluidLevelOk.Location = New System.Drawing.Point(606, 389)
        Me.btnFluidLevelOk.Name = "btnFluidLevelOk"
        Me.btnFluidLevelOk.Size = New System.Drawing.Size(87, 35)
        Me.btnFluidLevelOk.TabIndex = 3
        Me.btnFluidLevelOk.Text = "Okay"
        Me.btnFluidLevelOk.UseVisualStyleBackColor = True
        '
        'txtFluidLevelReport
        '
        Me.txtFluidLevelReport.Location = New System.Drawing.Point(108, 27)
        Me.txtFluidLevelReport.Multiline = True
        Me.txtFluidLevelReport.Name = "txtFluidLevelReport"
        Me.txtFluidLevelReport.Size = New System.Drawing.Size(531, 310)
        Me.txtFluidLevelReport.TabIndex = 2
        '
        'FluidLevelReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFluidLevelOk)
        Me.Controls.Add(Me.txtFluidLevelReport)
        Me.Name = "FluidLevelReportForm"
        Me.Text = "FluidLevelReportForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFluidLevelOk As Button
    Friend WithEvents txtFluidLevelReport As TextBox
End Class
