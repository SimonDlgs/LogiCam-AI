Imports System.Runtime.CompilerServices

Module globalExtensions
    <Extension()>
    Public Sub InvokeIfRequired(ByVal control As Control, action As MethodInvoker)
        If control.InvokeRequired Then
            control.Invoke(action)
        Else
            action()
        End If
    End Sub
End Module