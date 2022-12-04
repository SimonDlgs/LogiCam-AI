Imports WebcamCapturer.Controls.WinForms
Imports WebcamCapturer.Core

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SelectCamBtn = New System.Windows.Forms.Button()
        Me.DetectedLabel = New System.Windows.Forms.Label()
        Me.DetectType = New System.ComponentModel.BackgroundWorker()
        Me.RefreshDetect = New System.Windows.Forms.Timer(Me.components)
        Me.StopButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaxFrmLabel = New System.Windows.Forms.Label()
        Me.MaximumFrameLabel = New System.Windows.Forms.Label()
        Me.CamStatutLabel = New System.Windows.Forms.Label()
        Me.CamStatLabel = New System.Windows.Forms.Label()
        Me.BytesRcvLabel = New System.Windows.Forms.Label()
        Me.BytReceinvedLabel = New System.Windows.Forms.Label()
        Me.CountFrmLabel = New System.Windows.Forms.Label()
        Me.FrameCountLabel = New System.Windows.Forms.Label()
        Me.GlobalRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.CameraView = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CameraView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectCamBtn
        '
        Me.SelectCamBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectCamBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectCamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectCamBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SelectCamBtn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SelectCamBtn.Location = New System.Drawing.Point(507, 353)
        Me.SelectCamBtn.Name = "SelectCamBtn"
        Me.SelectCamBtn.Size = New System.Drawing.Size(124, 39)
        Me.SelectCamBtn.TabIndex = 2
        Me.SelectCamBtn.Text = "Select camera..."
        Me.SelectCamBtn.UseVisualStyleBackColor = True
        Me.SelectCamBtn.Visible = False
        '
        'DetectedLabel
        '
        Me.DetectedLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetectedLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.DetectedLabel.Location = New System.Drawing.Point(232, 10)
        Me.DetectedLabel.Name = "DetectedLabel"
        Me.DetectedLabel.Size = New System.Drawing.Size(399, 38)
        Me.DetectedLabel.TabIndex = 3
        Me.DetectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DetectType
        '
        Me.DetectType.WorkerSupportsCancellation = True
        '
        'RefreshDetect
        '
        Me.RefreshDetect.Interval = 1500
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.StopButton.ForeColor = System.Drawing.Color.IndianRed
        Me.StopButton.Location = New System.Drawing.Point(10, 353)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(79, 39)
        Me.StopButton.TabIndex = 4
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        Me.StopButton.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.MaxFrmLabel)
        Me.GroupBox1.Controls.Add(Me.MaximumFrameLabel)
        Me.GroupBox1.Controls.Add(Me.CamStatutLabel)
        Me.GroupBox1.Controls.Add(Me.CamStatLabel)
        Me.GroupBox1.Controls.Add(Me.BytesRcvLabel)
        Me.GroupBox1.Controls.Add(Me.BytReceinvedLabel)
        Me.GroupBox1.Controls.Add(Me.CountFrmLabel)
        Me.GroupBox1.Controls.Add(Me.FrameCountLabel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 337)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'MaxFrmLabel
        '
        Me.MaxFrmLabel.AutoSize = True
        Me.MaxFrmLabel.Location = New System.Drawing.Point(102, 50)
        Me.MaxFrmLabel.Name = "MaxFrmLabel"
        Me.MaxFrmLabel.Size = New System.Drawing.Size(13, 13)
        Me.MaxFrmLabel.TabIndex = 7
        Me.MaxFrmLabel.Text = "0"
        '
        'MaximumFrameLabel
        '
        Me.MaximumFrameLabel.AutoSize = True
        Me.MaximumFrameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MaximumFrameLabel.Location = New System.Drawing.Point(5, 50)
        Me.MaximumFrameLabel.Name = "MaximumFrameLabel"
        Me.MaximumFrameLabel.Size = New System.Drawing.Size(91, 15)
        Me.MaximumFrameLabel.TabIndex = 6
        Me.MaximumFrameLabel.Text = "Frames (Max) : "
        '
        'CamStatutLabel
        '
        Me.CamStatutLabel.AutoSize = True
        Me.CamStatutLabel.ForeColor = System.Drawing.Color.IndianRed
        Me.CamStatutLabel.Location = New System.Drawing.Point(97, 25)
        Me.CamStatutLabel.Name = "CamStatutLabel"
        Me.CamStatutLabel.Size = New System.Drawing.Size(37, 13)
        Me.CamStatutLabel.TabIndex = 5
        Me.CamStatutLabel.Text = "Offline"
        '
        'CamStatLabel
        '
        Me.CamStatLabel.AutoSize = True
        Me.CamStatLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CamStatLabel.Location = New System.Drawing.Point(5, 24)
        Me.CamStatLabel.Name = "CamStatLabel"
        Me.CamStatLabel.Size = New System.Drawing.Size(94, 15)
        Me.CamStatLabel.TabIndex = 4
        Me.CamStatLabel.Text = "Camera statut : "
        '
        'BytesRcvLabel
        '
        Me.BytesRcvLabel.AutoSize = True
        Me.BytesRcvLabel.Location = New System.Drawing.Point(113, 63)
        Me.BytesRcvLabel.Name = "BytesRcvLabel"
        Me.BytesRcvLabel.Size = New System.Drawing.Size(13, 13)
        Me.BytesRcvLabel.TabIndex = 3
        Me.BytesRcvLabel.Text = "0"
        '
        'BytReceinvedLabel
        '
        Me.BytReceinvedLabel.AutoSize = True
        Me.BytReceinvedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BytReceinvedLabel.Location = New System.Drawing.Point(5, 63)
        Me.BytReceinvedLabel.Name = "BytReceinvedLabel"
        Me.BytReceinvedLabel.Size = New System.Drawing.Size(102, 15)
        Me.BytReceinvedLabel.TabIndex = 2
        Me.BytReceinvedLabel.Text = "Bytes Received : "
        '
        'CountFrmLabel
        '
        Me.CountFrmLabel.AutoSize = True
        Me.CountFrmLabel.Location = New System.Drawing.Point(97, 37)
        Me.CountFrmLabel.Name = "CountFrmLabel"
        Me.CountFrmLabel.Size = New System.Drawing.Size(13, 13)
        Me.CountFrmLabel.TabIndex = 1
        Me.CountFrmLabel.Text = "0"
        '
        'FrameCountLabel
        '
        Me.FrameCountLabel.AutoSize = True
        Me.FrameCountLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FrameCountLabel.Location = New System.Drawing.Point(5, 37)
        Me.FrameCountLabel.Name = "FrameCountLabel"
        Me.FrameCountLabel.Size = New System.Drawing.Size(86, 15)
        Me.FrameCountLabel.TabIndex = 0
        Me.FrameCountLabel.Text = "Frame count : "
        '
        'GlobalRefresh
        '
        '
        'CameraView
        '
        Me.CameraView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CameraView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CameraView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CameraView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CameraView.Image = Global.LogiCam_AI.My.Resources.Resources.NoCamera
        Me.CameraView.Location = New System.Drawing.Point(232, 51)
        Me.CameraView.Name = "CameraView"
        Me.CameraView.Size = New System.Drawing.Size(400, 297)
        Me.CameraView.TabIndex = 0
        Me.CameraView.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(642, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.DetectedLabel)
        Me.Controls.Add(Me.SelectCamBtn)
        Me.Controls.Add(Me.CameraView)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(658, 413)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogiCam AI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CameraView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CameraView As PictureBox
    Friend WithEvents SelectCamBtn As Button
    Friend WithEvents DetectedLabel As Label
    Friend WithEvents DetectType As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshDetect As Timer
    Friend WithEvents StopButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BytesRcvLabel As Label
    Friend WithEvents BytReceinvedLabel As Label
    Friend WithEvents CountFrmLabel As Label
    Friend WithEvents FrameCountLabel As Label
    Friend WithEvents CamStatutLabel As Label
    Friend WithEvents CamStatLabel As Label
    Friend WithEvents GlobalRefresh As Timer
    Friend WithEvents MaxFrmLabel As Label
    Friend WithEvents MaximumFrameLabel As Label
End Class
