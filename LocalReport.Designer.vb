<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalReport
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
        Me.btnLocalOk = New System.Windows.Forms.Button()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLocalOk
        '
        Me.btnLocalOk.Location = New System.Drawing.Point(610, 389)
        Me.btnLocalOk.Name = "btnLocalOk"
        Me.btnLocalOk.Size = New System.Drawing.Size(78, 35)
        Me.btnLocalOk.TabIndex = 3
        Me.btnLocalOk.Text = "Okay"
        Me.btnLocalOk.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(112, 27)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(531, 310)
        Me.txtReport.TabIndex = 2
        '
        'LocalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLocalOk)
        Me.Controls.Add(Me.txtReport)
        Me.Name = "LocalReport"
        Me.Text = "LocationReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLocalOk As Button
    Friend WithEvents txtReport As TextBox
End Class
