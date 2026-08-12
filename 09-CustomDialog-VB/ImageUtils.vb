Imports System
Imports System.Drawing

Namespace Global.CustomDialog

    Public NotInheritable Class ImageUtils
        Private Sub New()
        End Sub

        ''' <summary>
        ''' Gets the image dimension.
        ''' </summary>
        ''' <param name="absolutePath">The absolute path.</param>
        ''' <returns>System.Nullable{Size}.</returns>
        Public Shared Function GetImageDimension(absolutePath As String) As Size?
            Dim fullSizeImageHeight As Integer
            Dim fullSizeImageWidth As Integer
            Dim fullSizeImg As Image = Nothing
            Try
                fullSizeImg = Image.FromFile(absolutePath)
                fullSizeImageHeight = fullSizeImg.Height
                fullSizeImageWidth = fullSizeImg.Width
            Catch
                Return Nothing
            Finally
                If fullSizeImg IsNot Nothing Then
                    fullSizeImg.Dispose()
                    fullSizeImg = Nothing
                End If
                GC.Collect()
            End Try

            Return New Size(fullSizeImageWidth, fullSizeImageHeight)
        End Function
    End Class

End Namespace
