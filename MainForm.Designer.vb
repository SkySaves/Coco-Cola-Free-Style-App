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
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnSyrupLvl = New System.Windows.Forms.Button()
        Me.btnOrderSyrup = New System.Windows.Forms.Button()
        Me.btnMixDisp = New System.Windows.Forms.Button()
        Me.picCola = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picColaZero = New System.Windows.Forms.PictureBox()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        Me.picDietCola = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.picPowerade = New System.Windows.Forms.PictureBox()
        Me.picRoot = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.picPibb = New System.Windows.Forms.PictureBox()
        Me.picPepper = New System.Windows.Forms.PictureBox()
        Me.picMello = New System.Windows.Forms.PictureBox()
        Me.picMinute = New System.Windows.Forms.PictureBox()
        Me.picSpriteZero = New System.Windows.Forms.PictureBox()
        Me.PicFanta = New System.Windows.Forms.PictureBox()
        Me.rad16oz = New System.Windows.Forms.RadioButton()
        Me.rad24oz = New System.Windows.Forms.RadioButton()
        Me.rad32oz = New System.Windows.Forms.RadioButton()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.rad8oz = New System.Windows.Forms.RadioButton()
        CType(Me.picCola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColaZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDietCola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPibb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMello, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpriteZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Salmon
        Me.btnReports.Location = New System.Drawing.Point(502, 10)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(92, 59)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.Salmon
        Me.btnStatistics.Location = New System.Drawing.Point(502, 74)
        Me.btnStatistics.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(92, 59)
        Me.btnStatistics.TabIndex = 7
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'btnSyrupLvl
        '
        Me.btnSyrupLvl.BackColor = System.Drawing.Color.Salmon
        Me.btnSyrupLvl.Location = New System.Drawing.Point(502, 138)
        Me.btnSyrupLvl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSyrupLvl.Name = "btnSyrupLvl"
        Me.btnSyrupLvl.Size = New System.Drawing.Size(92, 59)
        Me.btnSyrupLvl.TabIndex = 8
        Me.btnSyrupLvl.Text = "Syrup Level"
        Me.btnSyrupLvl.UseVisualStyleBackColor = False
        '
        'btnOrderSyrup
        '
        Me.btnOrderSyrup.BackColor = System.Drawing.Color.Salmon
        Me.btnOrderSyrup.Location = New System.Drawing.Point(502, 202)
        Me.btnOrderSyrup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderSyrup.Name = "btnOrderSyrup"
        Me.btnOrderSyrup.Size = New System.Drawing.Size(92, 59)
        Me.btnOrderSyrup.TabIndex = 9
        Me.btnOrderSyrup.Text = "Re-Order Syrup/CO2"
        Me.btnOrderSyrup.UseVisualStyleBackColor = False
        '
        'btnMixDisp
        '
        Me.btnMixDisp.BackColor = System.Drawing.Color.Red
        Me.btnMixDisp.Location = New System.Drawing.Point(502, 347)
        Me.btnMixDisp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMixDisp.Name = "btnMixDisp"
        Me.btnMixDisp.Size = New System.Drawing.Size(92, 59)
        Me.btnMixDisp.TabIndex = 5
        Me.btnMixDisp.Text = "Mix/Dispense"
        Me.btnMixDisp.UseVisualStyleBackColor = False
        '
        'picCola
        '
        Me.picCola.Image = CType(resources.GetObject("picCola.Image"), System.Drawing.Image)
        Me.picCola.Location = New System.Drawing.Point(9, 10)
        Me.picCola.Margin = New System.Windows.Forms.Padding(2)
        Me.picCola.Name = "picCola"
        Me.picCola.Size = New System.Drawing.Size(114, 110)
        Me.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCola.TabIndex = 1
        Me.picCola.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(128, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picColaZero
        '
        Me.picColaZero.Image = CType(resources.GetObject("picColaZero.Image"), System.Drawing.Image)
        Me.picColaZero.Location = New System.Drawing.Point(246, 10)
        Me.picColaZero.Margin = New System.Windows.Forms.Padding(2)
        Me.picColaZero.Name = "picColaZero"
        Me.picColaZero.Size = New System.Drawing.Size(114, 110)
        Me.picColaZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picColaZero.TabIndex = 1
        Me.picColaZero.TabStop = False
        '
        'picSprite
        '
        Me.picSprite.Image = CType(resources.GetObject("picSprite.Image"), System.Drawing.Image)
        Me.picSprite.Location = New System.Drawing.Point(364, 10)
        Me.picSprite.Margin = New System.Windows.Forms.Padding(2)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(114, 110)
        Me.picSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSprite.TabIndex = 1
        Me.picSprite.TabStop = False
        '
        'picDietCola
        '
        Me.picDietCola.Image = CType(resources.GetObject("picDietCola.Image"), System.Drawing.Image)
        Me.picDietCola.Location = New System.Drawing.Point(128, 10)
        Me.picDietCola.Margin = New System.Windows.Forms.Padding(2)
        Me.picDietCola.Name = "picDietCola"
        Me.picDietCola.Size = New System.Drawing.Size(114, 110)
        Me.picDietCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDietCola.TabIndex = 1
        Me.picDietCola.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(128, 164)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'picPowerade
        '
        Me.picPowerade.Image = CType(resources.GetObject("picPowerade.Image"), System.Drawing.Image)
        Me.picPowerade.Location = New System.Drawing.Point(246, 164)
        Me.picPowerade.Margin = New System.Windows.Forms.Padding(2)
        Me.picPowerade.Name = "picPowerade"
        Me.picPowerade.Size = New System.Drawing.Size(114, 110)
        Me.picPowerade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPowerade.TabIndex = 1
        Me.picPowerade.TabStop = False
        '
        'picRoot
        '
        Me.picRoot.Image = CType(resources.GetObject("picRoot.Image"), System.Drawing.Image)
        Me.picRoot.Location = New System.Drawing.Point(364, 164)
        Me.picRoot.Margin = New System.Windows.Forms.Padding(2)
        Me.picRoot.Name = "picRoot"
        Me.picRoot.Size = New System.Drawing.Size(114, 110)
        Me.picRoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoot.TabIndex = 1
        Me.picRoot.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(128, 164)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 1
        Me.PictureBox12.TabStop = False
        '
        'picPibb
        '
        Me.picPibb.Image = CType(resources.GetObject("picPibb.Image"), System.Drawing.Image)
        Me.picPibb.Location = New System.Drawing.Point(128, 164)
        Me.picPibb.Margin = New System.Windows.Forms.Padding(2)
        Me.picPibb.Name = "picPibb"
        Me.picPibb.Size = New System.Drawing.Size(114, 110)
        Me.picPibb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPibb.TabIndex = 1
        Me.picPibb.TabStop = False
        '
        'picPepper
        '
        Me.picPepper.Image = CType(resources.GetObject("picPepper.Image"), System.Drawing.Image)
        Me.picPepper.Location = New System.Drawing.Point(128, 306)
        Me.picPepper.Margin = New System.Windows.Forms.Padding(2)
        Me.picPepper.Name = "picPepper"
        Me.picPepper.Size = New System.Drawing.Size(114, 110)
        Me.picPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPepper.TabIndex = 1
        Me.picPepper.TabStop = False
        '
        'picMello
        '
        Me.picMello.Image = CType(resources.GetObject("picMello.Image"), System.Drawing.Image)
        Me.picMello.Location = New System.Drawing.Point(246, 306)
        Me.picMello.Margin = New System.Windows.Forms.Padding(2)
        Me.picMello.Name = "picMello"
        Me.picMello.Size = New System.Drawing.Size(114, 110)
        Me.picMello.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMello.TabIndex = 1
        Me.picMello.TabStop = False
        '
        'picMinute
        '
        Me.picMinute.Image = CType(resources.GetObject("picMinute.Image"), System.Drawing.Image)
        Me.picMinute.Location = New System.Drawing.Point(364, 306)
        Me.picMinute.Margin = New System.Windows.Forms.Padding(2)
        Me.picMinute.Name = "picMinute"
        Me.picMinute.Size = New System.Drawing.Size(114, 110)
        Me.picMinute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinute.TabIndex = 1
        Me.picMinute.TabStop = False
        '
        'picSpriteZero
        '
        Me.picSpriteZero.Image = CType(resources.GetObject("picSpriteZero.Image"), System.Drawing.Image)
        Me.picSpriteZero.Location = New System.Drawing.Point(9, 164)
        Me.picSpriteZero.Margin = New System.Windows.Forms.Padding(2)
        Me.picSpriteZero.Name = "picSpriteZero"
        Me.picSpriteZero.Size = New System.Drawing.Size(114, 110)
        Me.picSpriteZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpriteZero.TabIndex = 1
        Me.picSpriteZero.TabStop = False
        '
        'PicFanta
        '
        Me.PicFanta.Image = CType(resources.GetObject("PicFanta.Image"), System.Drawing.Image)
        Me.PicFanta.Location = New System.Drawing.Point(9, 306)
        Me.PicFanta.Margin = New System.Windows.Forms.Padding(2)
        Me.PicFanta.Name = "PicFanta"
        Me.PicFanta.Size = New System.Drawing.Size(114, 110)
        Me.PicFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFanta.TabIndex = 1
        Me.PicFanta.TabStop = False
        '
        'rad16oz
        '
        Me.rad16oz.AutoSize = True
        Me.rad16oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad16oz.Location = New System.Drawing.Point(191, 465)
        Me.rad16oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad16oz.Name = "rad16oz"
        Me.rad16oz.Size = New System.Drawing.Size(77, 30)
        Me.rad16oz.TabIndex = 2
        Me.rad16oz.TabStop = True
        Me.rad16oz.Text = "16oz"
        Me.rad16oz.UseVisualStyleBackColor = True
        '
        'rad24oz
        '
        Me.rad24oz.AutoSize = True
        Me.rad24oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad24oz.Location = New System.Drawing.Point(277, 465)
        Me.rad24oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad24oz.Name = "rad24oz"
        Me.rad24oz.Size = New System.Drawing.Size(77, 30)
        Me.rad24oz.TabIndex = 3
        Me.rad24oz.TabStop = True
        Me.rad24oz.Text = "24oz"
        Me.rad24oz.UseVisualStyleBackColor = True
        '
        'rad32oz
        '
        Me.rad32oz.AutoSize = True
        Me.rad32oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad32oz.Location = New System.Drawing.Point(364, 465)
        Me.rad32oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad32oz.Name = "rad32oz"
        Me.rad32oz.Size = New System.Drawing.Size(77, 30)
        Me.rad32oz.TabIndex = 4
        Me.rad32oz.TabStop = True
        Me.rad32oz.Text = "32oz"
        Me.rad32oz.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'rad8oz
        '
        Me.rad8oz.AutoSize = True
        Me.rad8oz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad8oz.Location = New System.Drawing.Point(108, 465)
        Me.rad8oz.Margin = New System.Windows.Forms.Padding(2)
        Me.rad8oz.Name = "rad8oz"
        Me.rad8oz.Size = New System.Drawing.Size(65, 30)
        Me.rad8oz.TabIndex = 1
        Me.rad8oz.TabStop = True
        Me.rad8oz.Text = "8oz"
        Me.rad8oz.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(616, 506)
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
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnReports)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "CocoCola Free Style"
        CType(Me.picCola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColaZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDietCola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPibb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMello, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpriteZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReports As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnSyrupLvl As Button
    Friend WithEvents btnOrderSyrup As Button
    Friend WithEvents btnMixDisp As Button
    Friend WithEvents picCola As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picColaZero As PictureBox
    Friend WithEvents picSprite As PictureBox
    Friend WithEvents picDietCola As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents picPowerade As PictureBox
    Friend WithEvents picRoot As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents picPibb As PictureBox
    Friend WithEvents picPepper As PictureBox
    Friend WithEvents picMello As PictureBox
    Friend WithEvents picMinute As PictureBox
    Friend WithEvents picSpriteZero As PictureBox
    Friend WithEvents PicFanta As PictureBox
    Friend WithEvents rad16oz As RadioButton
    Friend WithEvents rad24oz As RadioButton
    Friend WithEvents rad32oz As RadioButton
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents rad8oz As RadioButton
End Class
