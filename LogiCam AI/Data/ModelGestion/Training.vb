Imports Microsoft.ML
Imports Microsoft.ML.Data
Imports Microsoft.ML.Vision
Imports System
Imports System.Linq
Imports System.IO
Imports System.Collections.Generic

Namespace MyML
    Public Class Training
        Public Shared Function RetrainPipeline(ByVal mlContext As MLContext, ByVal trainData As IDataView) As ITransformer
            Dim pipeline = BuildPipeline(mlContext)
            Dim model = pipeline.Fit(trainData)
            Return model
        End Function

        Public Shared Function BuildPipeline(ByVal mlContext As MLContext) As IEstimator(Of ITransformer)
            Dim pipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName:="Label", inputColumnName:="Label").Append(mlContext.MulticlassClassification.Trainers.ImageClassification(labelColumnName:="Label", scoreColumnName:="Score", featureColumnName:="ImageSource")).Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName:="PredictedLabel", inputColumnName:="PredictedLabel"))
            Return pipeline
        End Function
    End Class
End Namespace