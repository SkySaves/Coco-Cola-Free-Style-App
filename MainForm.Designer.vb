<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.rad32oz = New System.Windows.Forms.RadioButton()
        Me.rad24oz = New System.Windows.Forms.RadioButton()
        Me.rad8oz = New System.Windows.Forms.RadioButton()
        Me.rad16oz = New System.Windows.Forms.RadioButton()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        Me.picColaZero = New System.Windows.Forms.PictureBox()
        Me.picRoot = New System.Windows.Forms.PictureBox()
        Me.picMinute = New System.Windows.Forms.PictureBox()
        Me.picMello = New System.Windows.Forms.PictureBox()
        Me.PicFanta = New System.Windows.Forms.PictureBox()
        Me.picPepper = New System.Windows.Forms.PictureBox()
        Me.picSpriteZero = New System.Windows.Forms.PictureBox()
        Me.picPibb = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.picPowerade = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.picDietCola = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picCola = New System.Windows.Forms.PictureBox()
        Me.btnMixDisp = New System.Windows.Forms.Button()
        Me.btnOrderSyrup = New System.Windows.Forms.Button()
        Me.btnSyrupLvl = New System.Windows.Forms.Button()
        Me.btnMaintenanceReport = New System.Windows.Forms.Button()
        Me.btnLocalReport = New System.Windows.Forms.Button()
        Me.btnOrderReport = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColaZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMello, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpriteZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPibb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDietCola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rad32oz
        '
        Me.rad32oz.AutoSize = True
        Me.rad32oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad32oz.Location = New System.Drawing.Point(371, 466)
        Me.rad32oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad32oz.Name = "rad32oz"
        Me.rad32oz.Size = New System.Drawing.Size(77, 30)
        Me.rad32oz.TabIndex = 28
        Me.rad32oz.TabStop = True
        Me.rad32oz.Text = "32oz"
        Me.rad32oz.UseVisualStyleBackColor = True
        '
        'rad24oz
        '
        Me.rad24oz.AutoSize = True
        Me.rad24oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad24oz.Location = New System.Drawing.Point(284, 466)
        Me.rad24oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad24oz.Name = "rad24oz"
        Me.rad24oz.Size = New System.Drawing.Size(77, 30)
        Me.rad24oz.TabIndex = 27
        Me.rad24oz.TabStop = True
        Me.rad24oz.Text = "24oz"
        Me.rad24oz.UseVisualStyleBackColor = True
        '
        'rad8oz
        '
        Me.rad8oz.AutoSize = True
        Me.rad8oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad8oz.Location = New System.Drawing.Point(115, 466)
        Me.rad8oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad8oz.Name = "rad8oz"
        Me.rad8oz.Size = New System.Drawing.Size(65, 30)
        Me.rad8oz.TabIndex = 23
        Me.rad8oz.TabStop = True
        Me.rad8oz.Text = "8oz"
        Me.rad8oz.UseVisualStyleBackColor = True
        '
        'rad16oz
        '
        Me.rad16oz.AutoSize = True
        Me.rad16oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad16oz.Location = New System.Drawing.Point(198, 466)
        Me.rad16oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad16oz.Name = "rad16oz"
        Me.rad16oz.Size = New System.Drawing.Size(77, 30)
        Me.rad16oz.TabIndex = 26
        Me.rad16oz.TabStop = True
        Me.rad16oz.Text = "16oz"
        Me.rad16oz.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'picSprite
        '
        Me.picSprite.Image = CType(resources.GetObject("picSprite.Image"), System.Drawing.Image)
        Me.picSprite.Location = New System.Drawing.Point(371, 11)
        Me.picSprite.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(114, 110)
        Me.picSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSprite.TabIndex = 22
        Me.picSprite.TabStop = False
        '
        'picColaZero
        '
        Me.picColaZero.Image = CType(resources.GetObject("picColaZero.Image"), System.Drawing.Image)
        Me.picColaZero.Location = New System.Drawing.Point(253, 11)
        Me.picColaZero.Margin = New System.Windows.Forms.Padding(2)
        Me.picColaZero.Name = "picColaZero"
        Me.picColaZero.Size = New System.Drawing.Size(114, 110)
        Me.picColaZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picColaZero.TabIndex = 21
        Me.picColaZero.TabStop = False
        '
        'picRoot
        '
        Me.picRoot.Image = CType(resources.GetObject("picRoot.Image"), System.Drawing.Image)
        Me.picRoot.Location = New System.Drawing.Point(371, 165)
        Me.picRoot.Margin = New System.Windows.Forms.Padding(2)
        Me.picRoot.Name = "picRoot"
        Me.picRoot.Size = New System.Drawing.Size(114, 110)
        Me.picRoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoot.TabIndex = 20
        Me.picRoot.TabStop = False
        '
        'picMinute
        '
        Me.picMinute.Image = CType(resources.GetObject("picMinute.Image"), System.Drawing.Image)
        Me.picMinute.Location = New System.Drawing.Point(371, 307)
        Me.picMinute.Margin = New System.Windows.Forms.Padding(2)
        Me.picMinute.Name = "picMinute"
        Me.picMinute.Size = New System.Drawing.Size(114, 110)
        Me.picMinute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinute.TabIndex = 19
        Me.picMinute.TabStop = False
        '
        'picMello
        '
        Me.picMello.Image = CType(resources.GetObject("picMello.Image"), System.Drawing.Image)
        Me.picMello.Location = New System.Drawing.Point(253, 307)
        Me.picMello.Margin = New System.Windows.Forms.Padding(2)
        Me.picMello.Name = "picMello"
        Me.picMello.Size = New System.Drawing.Size(114, 110)
        Me.picMello.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMello.TabIndex = 18
        Me.picMello.TabStop = False
        '
        'PicFanta
        '
        Me.PicFanta.Image = CType(resources.GetObject("PicFanta.Image"), System.Drawing.Image)
        Me.PicFanta.Location = New System.Drawing.Point(16, 307)
        Me.PicFanta.Margin = New System.Windows.Forms.Padding(2)
        Me.PicFanta.Name = "PicFanta"
        Me.PicFanta.Size = New System.Drawing.Size(114, 110)
        Me.PicFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFanta.TabIndex = 17
        Me.PicFanta.TabStop = False
        '
        'picPepper
        '
        Me.picPepper.Image = CType(resources.GetObject("picPepper.Image"), System.Drawing.Image)
        Me.picPepper.Location = New System.Drawing.Point(135, 307)
        Me.picPepper.Margin = New System.Windows.Forms.Padding(2)
        Me.picPepper.Name = "picPepper"
        Me.picPepper.Size = New System.Drawing.Size(114, 110)
        Me.picPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPepper.TabIndex = 16
        Me.picPepper.TabStop = False
        '
        'picSpriteZero
        '
        Me.picSpriteZero.Image = CType(resources.GetObject("picSpriteZero.Image"), System.Drawing.Image)
        Me.picSpriteZero.Location = New System.Drawing.Point(16, 165)
        Me.picSpriteZero.Margin = New System.Windows.Forms.Padding(2)
        Me.picSpriteZero.Name = "picSpriteZero"
        Me.picSpriteZero.Size = New System.Drawing.Size(114, 110)
        Me.picSpriteZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpriteZero.TabIndex = 10
        Me.picSpriteZero.TabStop = False
        '
        'picPibb
        '
        Me.picPibb.Image = CType(resources.GetObject("picPibb.Image"), System.Drawing.Image)
        Me.picPibb.Location = New System.Drawing.Point(135, 165)
        Me.picPibb.Margin = New System.Windows.Forms.Padding(2)
        Me.picPibb.Name = "picPibb"
        Me.picPibb.Size = New System.Drawing.Size(114, 110)
        Me.picPibb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPibb.TabIndex = 14
        Me.picPibb.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(135, 165)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 13
        Me.PictureBox12.TabStop = False
        '
        'picPowerade
        '
        Me.picPowerade.Image = CType(resources.GetObject("picPowerade.Image"), System.Drawing.Image)
        Me.picPowerade.Location = New System.Drawing.Point(253, 165)
        Me.picPowerade.Margin = New System.Windows.Forms.Padding(2)
        Me.picPowerade.Name = "picPowerade"
        Me.picPowerade.Size = New System.Drawing.Size(114, 110)
        Me.picPowerade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerade.TabIndex = 12
        Me.picPowerade.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(135, 165)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'picDietCola
        '
        Me.picDietCola.Image = CType(resources.GetObject("picDietCola.Image"), System.Drawing.Image)
        Me.picDietCola.Location = New System.Drawing.Point(135, 11)
        Me.picDietCola.Margin = New System.Windows.Forms.Padding(2)
        Me.picDietCola.Name = "picDietCola"
        Me.picDietCola.Size = New System.Drawing.Size(114, 110)
        Me.picDietCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDietCola.TabIndex = 24
        Me.picDietCola.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'picCola
        '
        Me.picCola.Image = CType(resources.GetObject("picCola.Image"), System.Drawing.Image)
        Me.picCola.Location = New System.Drawing.Point(16, 11)
        Me.picCola.Margin = New System.Windows.Forms.Padding(2)
        Me.picCola.Name = "picCola"
        Me.picCola.Size = New System.Drawing.Size(114, 110)
        Me.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCola.TabIndex = 15
        Me.picCola.TabStop = False
        '
        'btnMixDisp
        '
        Me.btnMixDisp.BackColor = System.Drawing.Color.Red
        Me.btnMixDisp.Location = New System.Drawing.Point(509, 348)
        Me.btnMixDisp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMixDisp.Name = "btnMixDisp"
        Me.btnMixDisp.Size = New System.Drawing.Size(92, 59)
        Me.btnMixDisp.TabIndex = 29
        Me.btnMixDisp.Text = "Mix/Dispense"
        Me.btnMixDisp.UseVisualStyleBackColor = False
        '
        'btnOrderSyrup
        '
        Me.btnOrderSyrup.BackColor = System.Drawing.Color.Salmon
        Me.btnOrderSyrup.Location = New System.Drawing.Point(509, 203)
        Me.btnOrderSyrup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderSyrup.Name = "btnOrderSyrup"
        Me.btnOrderSyrup.Size = New System.Drawing.Size(92, 59)
        Me.btnOrderSyrup.TabIndex = 33
        Me.btnOrderSyrup.Text = "Re-Order Syrup"
        Me.btnOrderSyrup.UseVisualStyleBackColor = False
        '
        'btnSyrupLvl
        '
        Me.btnSyrupLvl.BackColor = System.Drawing.Color.Salmon
        Me.btnSyrupLvl.Location = New System.Drawing.Point(509, 139)
        Me.btnSyrupLvl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSyrupLvl.Name = "btnSyrupLvl"
        Me.btnSyrupLvl.Size = New System.Drawing.Size(92, 59)
        Me.btnSyrupLvl.TabIndex = 32
        Me.btnSyrupLvl.Text = "Syrup Level"
        Me.btnSyrupLvl.UseVisualStyleBackColor = False
        '
        'btnMaintenanceReport
        '
        Me.btnMaintenanceReport.BackColor = System.Drawing.Color.Salmon
        Me.btnMaintenanceReport.Location = New System.Drawing.Point(509, 75)
        Me.btnMaintenanceReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaintenanceReport.Name = "btnMaintenanceReport"
        Me.btnMaintenanceReport.Size = New System.Drawing.Size(92, 59)
        Me.btnMaintenanceReport.TabIndex = 31
        Me.btnMaintenanceReport.Text = "Maintenance Report"
        Me.btnMaintenanceReport.UseVisualStyleBackColor = False
        '
        'btnLocalReport
        '
        Me.btnLocalReport.BackColor = System.Drawing.Color.Salmon
        Me.btnLocalReport.Location = New System.Drawing.Point(509, 11)
        Me.btnLocalReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLocalReport.Name = "btnLocalReport"
        Me.btnLocalReport.Size = New System.Drawing.Size(92, 59)
        Me.btnLocalReport.TabIndex = 30
        Me.btnLocalReport.Text = "Local Report"
        Me.btnLocalReport.UseVisualStyleBackColor = False
        '
        'btnOrderReport
        '
        Me.btnOrderReport.BackColor = System.Drawing.Color.Salmon
        Me.btnOrderReport.Location = New System.Drawing.Point(509, 277)
        Me.btnOrderReport.Name = "btnOrderReport"
        Me.btnOrderReport.Size = New System.Drawing.Size(92, 59)
        Me.btnOrderReport.TabIndex = 34
        Me.btnOrderReport.Text = "Order Report"
        Me.btnOrderReport.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(616, 506)
        Me.Controls.Add(Me.btnOrderReport)
        Me.Controls.Add(Me.rad32oz)
        Me.Controls.Add(Me.rad24oz)
        Me.Controls.Add(Me.rad8oz)
        Me.Controls.Add(Me.rad16oz)
        Me.Controls.Add(Me.picSprite)
        Me.Controls.Add(Me.picColaZero)
        Me.Controls.Add(Me.picRoot)
        Me.Controls.Add(Me.picMinute)
        Me.Controls.Add(Me.picMello)
        Me.Controls.Add(Me.PicFanta)
        Me.Controls.Add(Me.picPepper)
        Me.Controls.Add(Me.picSpriteZero)
        Me.Controls.Add(Me.picPibb)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.picPowerade)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.picDietCola)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picCola)
        Me.Controls.Add(Me.btnMixDisp)
        Me.Controls.Add(Me.btnOrderSyrup)
        Me.Controls.Add(Me.btnSyrupLvl)
        Me.Controls.Add(Me.btnMaintenanceReport)
        Me.Controls.Add(Me.btnLocalReport)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "CocoCola Free Style"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColaZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMello, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpriteZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPibb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDietCola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad32oz As RadioButton
    Friend WithEvents rad24oz As RadioButton
    Friend WithEvents rad8oz As RadioButton
    Friend WithEvents rad16oz As RadioButton
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents picSprite As PictureBox
    Friend WithEvents picColaZero As PictureBox
    Friend WithEvents picRoot As PictureBox
    Friend WithEvents picMinute As PictureBox
    Friend WithEvents picMello As PictureBox
    Friend WithEvents PicFanta As PictureBox
    Friend WithEvents picPepper As PictureBox
    Friend WithEvents picSpriteZero As PictureBox
    Friend WithEvents picPibb As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents picPowerade As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents picDietCola As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picCola As PictureBox
    Friend WithEvents btnMixDisp As Button
    Friend WithEvents btnOrderSyrup As Button
    Friend WithEvents btnSyrupLvl As Button
    Friend WithEvents btnMaintenanceReport As Button
    Friend WithEvents btnLocalReport As Button
    Friend WithEvents btnOrderReport As Button
End Class
