<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMinimizedIcon = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.labelValue = New System.Windows.Forms.Label()
        Me.sliderScale = New System.Windows.Forms.TrackBar()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCloseIcon = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.groupBoxScale = New System.Windows.Forms.GroupBox()
        Me.lblSelectFileName = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.groupBoxImage = New System.Windows.Forms.GroupBox()
        Me.groupBoxOperation = New System.Windows.Forms.GroupBox()
        CType(Me.sliderScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxScale.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxImage.SuspendLayout()
        Me.groupBoxOperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinimizedIcon
        '
        Me.btnMinimizedIcon.BackColor = System.Drawing.Color.Black
        Me.btnMinimizedIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimizedIcon.ForeColor = System.Drawing.Color.White
        Me.btnMinimizedIcon.Location = New System.Drawing.Point(768, 3)
        Me.btnMinimizedIcon.Name = "btnMinimizedIcon"
        Me.btnMinimizedIcon.Size = New System.Drawing.Size(35, 25)
        Me.btnMinimizedIcon.TabIndex = 16
        Me.btnMinimizedIcon.TabStop = False
        Me.btnMinimizedIcon.Text = "-"
        Me.btnMinimizedIcon.UseVisualStyleBackColor = False
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(15, 623)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(820, 15)
        Me.progressBar.Step = 1
        Me.progressBar.TabIndex = 14
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(18, 143)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(150, 37)
        Me.btnStop.TabIndex = 12
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'labelValue
        '
        Me.labelValue.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.labelValue.Location = New System.Drawing.Point(70, 22)
        Me.labelValue.Name = "labelValue"
        Me.labelValue.Size = New System.Drawing.Size(40, 28)
        Me.labelValue.TabIndex = 11
        Me.labelValue.Text = "0.1"
        Me.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sliderScale
        '
        Me.sliderScale.AutoSize = False
        Me.sliderScale.LargeChange = 1
        Me.sliderScale.Location = New System.Drawing.Point(18, 48)
        Me.sliderScale.Maximum = 20
        Me.sliderScale.Minimum = 1
        Me.sliderScale.Name = "sliderScale"
        Me.sliderScale.Size = New System.Drawing.Size(150, 40)
        Me.sliderScale.TabIndex = 5
        Me.sliderScale.Value = 10
        '
        'btnGo
        '
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(18, 96)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(150, 37)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCloseIcon
        '
        Me.btnCloseIcon.BackColor = System.Drawing.Color.Black
        Me.btnCloseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCloseIcon.ForeColor = System.Drawing.Color.White
        Me.btnCloseIcon.Location = New System.Drawing.Point(813, 3)
        Me.btnCloseIcon.Name = "btnCloseIcon"
        Me.btnCloseIcon.Size = New System.Drawing.Size(35, 25)
        Me.btnCloseIcon.TabIndex = 15
        Me.btnCloseIcon.TabStop = False
        Me.btnCloseIcon.Text = "×"
        Me.btnCloseIcon.UseVisualStyleBackColor = False
        '
        'btnSaveImage
        '
        Me.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveImage.Location = New System.Drawing.Point(43, 87)
        Me.btnSaveImage.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(150, 50)
        Me.btnSaveImage.TabIndex = 2
        Me.btnSaveImage.Text = "Save Image..."
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInit.Location = New System.Drawing.Point(43, 147)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(150, 50)
        Me.btnInit.TabIndex = 3
        Me.btnInit.Text = "Init"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(43, 207)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFileSelect
        '
        Me.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileSelect.Location = New System.Drawing.Point(43, 27)
        Me.btnFileSelect.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(150, 50)
        Me.btnFileSelect.TabIndex = 1
        Me.btnFileSelect.Text = "File Select..."
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'groupBoxScale
        '
        Me.groupBoxScale.Controls.Add(Me.btnStop)
        Me.groupBoxScale.Controls.Add(Me.labelValue)
        Me.groupBoxScale.Controls.Add(Me.sliderScale)
        Me.groupBoxScale.Controls.Add(Me.btnGo)
        Me.groupBoxScale.Location = New System.Drawing.Point(30, 301)
        Me.groupBoxScale.Name = "groupBoxScale"
        Me.groupBoxScale.Size = New System.Drawing.Size(183, 200)
        Me.groupBoxScale.TabIndex = 8
        Me.groupBoxScale.TabStop = False
        Me.groupBoxScale.Text = "Scale"
        '
        'lblSelectFileName
        '
        Me.lblSelectFileName.Location = New System.Drawing.Point(8, 24)
        Me.lblSelectFileName.Name = "lblSelectFileName"
        Me.lblSelectFileName.Size = New System.Drawing.Size(550, 21)
        Me.lblSelectFileName.TabIndex = 4
        '
        'pictureBox
        '
        Me.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox.Location = New System.Drawing.Point(8, 48)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(550, 518)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox.TabIndex = 3
        Me.pictureBox.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(2, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(847, 29)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Scale Nearest Neighbor"
        '
        'groupBoxImage
        '
        Me.groupBoxImage.Controls.Add(Me.lblSelectFileName)
        Me.groupBoxImage.Controls.Add(Me.pictureBox)
        Me.groupBoxImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBoxImage.Location = New System.Drawing.Point(267, 36)
        Me.groupBoxImage.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxImage.Name = "groupBoxImage"
        Me.groupBoxImage.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxImage.Size = New System.Drawing.Size(568, 578)
        Me.groupBoxImage.TabIndex = 12
        Me.groupBoxImage.TabStop = False
        Me.groupBoxImage.Text = "Image"
        '
        'groupBoxOperation
        '
        Me.groupBoxOperation.Controls.Add(Me.btnSaveImage)
        Me.groupBoxOperation.Controls.Add(Me.btnInit)
        Me.groupBoxOperation.Controls.Add(Me.btnClose)
        Me.groupBoxOperation.Controls.Add(Me.btnFileSelect)
        Me.groupBoxOperation.Controls.Add(Me.groupBoxScale)
        Me.groupBoxOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBoxOperation.Location = New System.Drawing.Point(15, 36)
        Me.groupBoxOperation.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxOperation.Name = "groupBoxOperation"
        Me.groupBoxOperation.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxOperation.Size = New System.Drawing.Size(240, 578)
        Me.groupBoxOperation.TabIndex = 11
        Me.groupBoxOperation.TabStop = False
        Me.groupBoxOperation.Text = "Operation"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 650)
        Me.Controls.Add(Me.btnMinimizedIcon)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.btnCloseIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.groupBoxImage)
        Me.Controls.Add(Me.groupBoxOperation)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        CType(Me.sliderScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxScale.ResumeLayout(False)
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxImage.ResumeLayout(False)
        Me.groupBoxOperation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnMinimizedIcon As Button
    Private WithEvents progressBar As ProgressBar
    Private WithEvents btnStop As Button
    Private WithEvents labelValue As Label
    Private WithEvents sliderScale As TrackBar
    Private WithEvents btnGo As Button
    Private WithEvents btnCloseIcon As Button
    Private WithEvents btnSaveImage As Button
    Private WithEvents btnInit As Button
    Private WithEvents btnClose As Button
    Private WithEvents btnFileSelect As Button
    Private WithEvents groupBoxScale As GroupBox
    Private WithEvents lblSelectFileName As Label
    Private WithEvents pictureBox As PictureBox
    Private WithEvents lblTitle As Label
    Private WithEvents groupBoxImage As GroupBox
    Private WithEvents groupBoxOperation As GroupBox
End Class
