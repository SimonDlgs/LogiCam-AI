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
        Me.InfosTextbox = New System.Windows.Forms.TextBox()
        Me.CamStatutLabel = New System.Windows.Forms.Label()
        Me.CamStatLabel = New System.Windows.Forms.Label()
        Me.GlobalRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.CameraView = New System.Windows.Forms.PictureBox()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.CrossbarSettingsButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.Line1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CameraView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectCamBtn
        '
        Me.SelectCamBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectCamBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectCamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectCamBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SelectCamBtn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SelectCamBtn.Location = New System.Drawing.Point(579, 496)
        Me.SelectCamBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SelectCamBtn.Name = "SelectCamBtn"
        Me.SelectCamBtn.Size = New System.Drawing.Size(158, 45)
        Me.SelectCamBtn.TabIndex = 2
        Me.SelectCamBtn.Text = "Select camera..."
        Me.SelectCamBtn.UseVisualStyleBackColor = True
        Me.SelectCamBtn.Visible = False
        '
        'DetectedLabel
        '
        Me.DetectedLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetectedLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DetectedLabel.Location = New System.Drawing.Point(270, 29)
        Me.DetectedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DetectedLabel.Name = "DetectedLabel"
        Me.DetectedLabel.Size = New System.Drawing.Size(466, 44)
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
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.Color.IndianRed
        Me.StopButton.Location = New System.Drawing.Point(12, 496)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(92, 45)
        Me.StopButton.TabIndex = 4
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        Me.StopButton.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.InfosTextbox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(253, 450)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'InfosTextbox
        '
        Me.InfosTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.InfosTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfosTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfosTextbox.ForeColor = System.Drawing.Color.White
        Me.InfosTextbox.Location = New System.Drawing.Point(10, 26)
        Me.InfosTextbox.Multiline = True
        Me.InfosTextbox.Name = "InfosTextbox"
        Me.InfosTextbox.ReadOnly = True
        Me.InfosTextbox.Size = New System.Drawing.Size(233, 414)
        Me.InfosTextbox.TabIndex = 8
        '
        'CamStatutLabel
        '
        Me.CamStatutLabel.AutoSize = True
        Me.CamStatutLabel.ForeColor = System.Drawing.Color.IndianRed
        Me.CamStatutLabel.Location = New System.Drawing.Point(127, 29)
        Me.CamStatutLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CamStatutLabel.Name = "CamStatutLabel"
        Me.CamStatutLabel.Size = New System.Drawing.Size(43, 15)
        Me.CamStatutLabel.TabIndex = 5
        Me.CamStatutLabel.Text = "Offline"
        '
        'CamStatLabel
        '
        Me.CamStatLabel.AutoSize = True
        Me.CamStatLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CamStatLabel.Location = New System.Drawing.Point(67, 29)
        Me.CamStatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CamStatLabel.Name = "CamStatLabel"
        Me.CamStatLabel.Size = New System.Drawing.Size(63, 15)
        Me.CamStatLabel.TabIndex = 4
        Me.CamStatLabel.Text = "Camera is "
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
        Me.CameraView.Location = New System.Drawing.Point(271, 76)
        Me.CameraView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CameraView.Name = "CameraView"
        Me.CameraView.Size = New System.Drawing.Size(466, 414)
        Me.CameraView.TabIndex = 0
        Me.CameraView.TabStop = False
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.CrossbarSettingsButton)
        Me.MenuPanel.Controls.Add(Me.SettingsButton)
        Me.MenuPanel.Controls.Add(Me.Line1)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(749, 24)
        Me.MenuPanel.TabIndex = 6
        '
        'CrossbarSettingsButton
        '
        Me.CrossbarSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CrossbarSettingsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CrossbarSettingsButton.FlatAppearance.BorderSize = 0
        Me.CrossbarSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrossbarSettingsButton.Location = New System.Drawing.Point(501, 0)
        Me.CrossbarSettingsButton.Name = "CrossbarSettingsButton"
        Me.CrossbarSettingsButton.Size = New System.Drawing.Size(124, 23)
        Me.CrossbarSettingsButton.TabIndex = 2
        Me.CrossbarSettingsButton.Text = "Crossbar settings"
        Me.CrossbarSettingsButton.UseVisualStyleBackColor = True
        Me.CrossbarSettingsButton.Visible = False
        '
        'SettingsButton
        '
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingsButton.FlatAppearance.BorderSize = 0
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Location = New System.Drawing.Point(625, 0)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(124, 23)
        Me.SettingsButton.TabIndex = 0
        Me.SettingsButton.Text = "Webcam settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Line1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Line1.Location = New System.Drawing.Point(0, 23)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(749, 1)
        Me.Line1.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(749, 553)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.CamStatutLabel)
        Me.Controls.Add(Me.CamStatLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.DetectedLabel)
        Me.Controls.Add(Me.SelectCamBtn)
        Me.Controls.Add(Me.CameraView)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(765, 471)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogiCam AI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CameraView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CameraView As PictureBox
    Friend WithEvents SelectCamBtn As Button
    Friend WithEvents DetectedLabel As Label
    Friend WithEvents DetectType As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshDetect As Timer
    Friend WithEvents StopButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CamStatutLabel As Label
    Friend WithEvents CamStatLabel As Label
    Friend WithEvents GlobalRefresh As Timer
    Friend WithEvents InfosTextbox As TextBox
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents SettingsButton As Button
    Friend WithEvents Line1 As Panel
    Friend WithEvents CrossbarSettingsButton As Button
End Class
