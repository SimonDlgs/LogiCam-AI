Imports Microsoft.ML
Imports Microsoft.ML.Data
Imports System
Imports System.Linq
Imports System.IO
Imports System.Collections.Generic

Namespace MyML
    Public Class Consumption

#Region "model input class"
        Public Class ModelInput
            <ColumnName("Label")>
            Public Property Label As String
            <ColumnName("ImageSource")>
            Public Property ImageSource As Byte()
        End Class
#End Region

#Region "model output class"
        Public Class ModelOutput
            <ColumnName("Label")>
            Public Property Label As UInteger
            <ColumnName("ImageSource")>
            Public Property ImageSource As Byte()
            <ColumnName("PredictedLabel")>
            Public Property PredictedLabel As String
            <ColumnName("Score")>
            Public Property Score As Single()
        End Class
#End Region

        Private Shared MLNetModelPath As String = Nothing

        Public Shared Function ModelPath(value As String) As String
            MLNetModelPath = value
            Return MLNetModelPath
        End Function

        Public Shared ReadOnly PredictEngine As New Lazy(Of PredictionEngine(Of ModelInput, ModelOutput))(Function() SurroundingClass.CreatePredictEngine(MLNetModelPath), True)

        Class SurroundingClass
            Public Shared Function Predict(ByVal input As ModelInput, ModelFile As String) As ModelOutput
                ModelPath(ModelFile)
                Dim predEngine = PredictEngine.Value
                Return predEngine.Predict(input)
            End Function

            Public Shared Function CreatePredictEngine(ModelPath As String) As PredictionEngine(Of ModelInput, ModelOutput)
                Dim mlContext = New MLContext()
                Dim __ = Nothing
                Dim mlModel As ITransformer = mlContext.Model.Load(ModelPath, __)
                Return mlContext.Model.CreatePredictionEngine(Of ModelInput, ModelOutput)(mlModel)
            End Function
        End Class
    End Class
End Namespace