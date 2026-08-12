Namespace Global.CustomDialog.Dialogs.StyleBuilder

    ''' <summary>
    ''' Interface for the user control that edits specific set of attributes
    ''' </summary>
    Public Interface IEditorStylePage
        ''' <summary>
        ''' Forces flushing content from the user control into the dictionary of styles that was provided
        ''' </summary>
        Sub FlushContent()
    End Interface

End Namespace
