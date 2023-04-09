<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderReportForm
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
        Me.btnGenerateOrderReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnOrderReportOkay = New System.Windows.Forms.Button()
        Me.txtOrderReport = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGenerateOrderReport
        '
        Me.btnGenerateOrderReport.Location = New System.Drawing.Point(357, 208)
        Me.btnGenerateOrderReport.Name = "btnGenerateOrderReport"
        Me.btnGenerateOrderReport.Size = New System.Drawing.Size(87, 35)
        Me.btnGenerateOrderReport.TabIndex = 2
        Me.btnGenerateOrderReport.Text = "Generate"
        Me.btnGenerateOrderReport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "End Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Start Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(254, 366)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 7
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(254, 404)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 8
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(513, 389)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(87, 35)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnOrderReportOkay
        '
        Me.btnOrderReportOkay.Location = New System.Drawing.Point(606, 389)
        Me.btnOrderReportOkay.Name = "btnOrderReportOkay"
        Me.btnOrderReportOkay.Size = New System.Drawing.Size(87, 35)
        Me.btnOrderReportOkay.TabIndex = 6
        Me.btnOrderReportOkay.Text = "Okay"
        Me.btnOrderReportOkay.UseVisualStyleBackColor = True
        '
        'txtOrderReport
        '
        Me.txtOrderReport.Location = New System.Drawing.Point(108, 27)
        Me.txtOrderReport.Multiline = True
        Me.txtOrderReport.Name = "txtOrderReport"
        Me.txtOrderReport.Size = New System.Drawing.Size(531, 310)
        Me.txtOrderReport.TabIndex = 4
        '
        'OrderReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnOrderReportOkay)
        Me.Controls.Add(Me.txtOrderReport)
        Me.Controls.Add(Me.btnGenerateOrderReport)
        Me.Name = "OrderReportForm"
        Me.Text = "Order Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerateOrderReport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnOrderReportOkay As Button
    Friend WithEvents txtOrderReport As TextBox
End Class
