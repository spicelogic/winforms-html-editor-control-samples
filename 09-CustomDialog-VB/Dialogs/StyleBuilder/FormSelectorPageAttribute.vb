Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' The attribute is designed to help distinguish user controls designed to edit style attributes among others.
    ''' </summary>
    Public NotInheritable Class FormSelectorPageAttribute
        Inherits Attribute

        Private _handledTags As String
        Private ReadOnly _separatedTags As List(Of String) = New List(Of String)()

        ''' <summary>
        ''' Initializes a new instance of the <see cref="FormSelectorPageAttribute"/> class.
        ''' </summary>
        ''' <param name="initialPageName">Initial name of the page.</param>
        ''' <param name="handledTags">The handled tags.</param>
        Public Sub New(initialPageName As String, handledTags As String)
            Me.PageName = initialPageName
            Me.HandledTags = handledTags
        End Sub

        ''' <summary>
        ''' Name of the page to be displayed in tabs
        ''' </summary>
        Public Property PageName As String
            Get
                Return _pageName
            End Get
            Private Set(value As String)
                _pageName = value
            End Set
        End Property
        Private _pageName As String

        ''' <summary>
        ''' List of comma-separated tags that the attached user control handles
        ''' </summary>
        Public Property HandledTags As String
            Get
                Return _handledTags
            End Get

            Private Set(value As String)
                _handledTags = value

                ' Update separated tags
                _separatedTags.Clear()
                For Each tag As String In _handledTags.Split(";"c, ","c)
                    Dim tagTrimmed As String = tag.Trim()
                    If tagTrimmed.Length > 0 Then
                        _separatedTags.Add(tagTrimmed)
                    End If
                Next
            End Set
        End Property

        ''' <summary>
        ''' Checks whether a tag is handled by the attached user control
        ''' </summary>
        ''' <param name="specificTag">tag to check</param>
        ''' <returns>true is the attached user control handles the tag specified</returns>
        Public Function HandlesTag(specificTag As String) As Boolean
            Return _separatedTags.Any(Function(tag) String.Equals(tag, specificTag, StringComparison.InvariantCultureIgnoreCase))

            ' defaulting to false
        End Function
    End Class

End Namespace
