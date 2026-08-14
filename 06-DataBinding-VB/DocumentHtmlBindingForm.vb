Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions

''' <summary>
''' Binds the editor's DocumentHtml property - the full document including head and body,
''' rather than just the body fragment - to a field on a business object. Everything else about
''' the binding works the same as the BodyHtml scenario; see that form's comments for the
''' details on write timing.
'''
''' The grid, navigator, and docked editor are laid out in the designer; open
''' DocumentHtmlBindingForm.vb in the Visual Studio designer to see them.
''' </summary>
Partial Public Class DocumentHtmlBindingForm
    Inherits Form

    Private ReadOnly _students As List(Of Student)

    Public Sub New()
        InitializeComponent()

        ' Tells the editor that DocumentHtml (not BodyHtml) is the property it should treat as
        ' the primary content for this instance.
        _editor.Options.DefaultHtmlType = HtmlContentTypes.DocumentHtml

        _students = StudentRepository.Load()
        _bindingSource.DataSource = _students

        _editor.DataBindings.Add(New Binding("DocumentHtml", _bindingSource, "History", True))
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles _saveButton.Click
        Validate()
        _bindingSource.EndEdit()
        StudentRepository.Save(_students)
    End Sub

End Class
