Imports System.Runtime.CompilerServices

Module globalExtensions
    <Extension()>
    Public Sub InvokeIfRequired(ByVal control As Control, action As MethodInvoker)
        Try
            If control.InvokeRequired Then
                control.Invoke(action)
            Else
                action()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module