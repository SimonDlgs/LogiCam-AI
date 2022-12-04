Imports System.IO
Imports System.ComponentModel
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports LogiCam_AI.MyML
Imports LogiCam_AI.MyML.Consumption
Imports System.Drawing.Imaging

Public Class MainForm
    Private Started As Boolean = False
    Private ReadOnly Cameras As New VideoCaptureDeviceForm
    Dim Camera As VideoCaptureDevice

    Private ReadOnly Path As String = My.Application.Info.DirectoryPath & "\img.jpg"
    Private ReadOnly localExePath As String = My.Application.Info.DirectoryPath & "\Resources\"


    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalRefresh.Start()
        Me.CameraView.SizeMode = PictureBoxSizeMode.Zoom
        WebcamSelection()
    End Sub

    Private Sub Capt(sender As Object, eventArgs As NewFrameEventArgs)
        Me.CameraView.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SetOffline()
    End Sub

    Private Sub SelectCamBtn_Click(sender As Object, e As EventArgs) Handles SelectCamBtn.Click
        WebcamSelection()
    End Sub

    Private Function WebcamSelection() As Boolean
        Try
            If Cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Camera = Cameras.VideoDevice
                AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Capt)
                Camera.Start()
                Me.CameraView.SizeMode = PictureBoxSizeMode.Zoom
                Me.RefreshDetect.Start()
                Me.SelectCamBtn.Visible = False
                Me.StopButton.Visible = True
                Return True
            Else
                MessageBox.Show("No camera selected.", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                StopProc()
                Me.SelectCamBtn.Visible = True
                Me.StopButton.Visible = False
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.SelectCamBtn.Visible = True
            Me.StopButton.Visible = False
            StopProc()
            Return False
        End Try
    End Function

    Private Sub DetectType_DoWork(sender As Object, e As DoWorkEventArgs) Handles DetectType.DoWork
        Try
            Started = True
            Me.CameraView.InvokeIfRequired(Sub() Me.CameraView.Image.Save(Path, ImageFormat.Jpeg))
            Dim imageBytes = My.Computer.FileSystem.ReadAllBytes(Path)

            Me.InfosTextbox.InvokeIfRequired(Sub() InfosTextbox.Text =
                "Frames: " & Camera.FramesReceived.ToString() &
                "Frames (Max): " & Camera.VideoResolution.MaximumFrameRate.ToString() &
                "Bytes received: " & Camera.BytesReceived.ToString() &
                "Frame size: " & Camera.VideoResolution.FrameSize.ToString())

            Dim SampleData As New Consumption.ModelInput() With {
                        .ImageSource = imageBytes
            }
            Dim PredictGroup As ModelOutput = SurroundingClass.Predict(SampleData, localExePath & "MLModel1.zip")
            Me.DetectedLabel.InvokeIfRequired(Sub() Me.DetectedLabel.Text = PredictGroup.PredictedLabel.ToUpper())

            Started = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshDetect_Tick(sender As Object, e As EventArgs) Handles RefreshDetect.Tick
        If Started = False Then Me.DetectType.RunWorkerAsync()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StopProc()
    End Sub

    Sub StopProc()
        Me.SelectCamBtn.Visible = True
        Me.StopButton.Visible = False
        Me.RefreshDetect.Stop()
        Me.DetectType.CancelAsync()
        If Camera IsNot Nothing Then Camera.SignalToStop()
        Me.CameraView.Image = My.Resources.NoCamera
    End Sub

    Private Sub GlobalRefresh_Tick(sender As Object, e As EventArgs) Handles GlobalRefresh.Tick
        Try
            If Camera IsNot Nothing Then
                If Camera.IsRunning = True Then
                    Me.CamStatutLabel.Text = "Online"
                    Me.CamStatutLabel.ForeColor = Color.Green
                Else
                    SetOffline()
                End If
            Else
                SetOffline()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SetOffline()
        StopProc()
        Me.DetectedLabel.Text = Nothing
        Me.InfosTextbox.Text = Nothing
        Me.CamStatutLabel.Text = "Offline"
        Me.CamStatutLabel.ForeColor = Color.IndianRed
        File.Delete(Path)
    End Sub
End Class