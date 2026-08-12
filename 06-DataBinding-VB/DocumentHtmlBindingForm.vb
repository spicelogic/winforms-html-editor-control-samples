Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions
Imports SpiceLogic.HtmlEditor.WinForms

''' <summary>
''' Binds the editor's DocumentHtml property - the full document including head and body,
''' rather than just the body fragment - to a field on a business object. Everything else about
''' the binding works the same as the BodyHtml scenario; see that form's comments for the
''' details on write timing.
''' </summary>
Public Class DocumentHtmlBindingForm
    Inherits Form

    Private ReadOnly _bindingSource As New BindingSource()
    Private ReadOnly _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}
    Private ReadOnly _grid As New DataGridView() With {
        .Dock = DockStyle.Top,
        .Height = 200,
        .AutoGenerateColumns = True,
        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    }

    Private ReadOnly _students As List(Of Student)

    Public Sub New()
        Text = "DocumentHtml binding demo (VB.NET)"
        Width = 950
        Height = 640

        ' Tells the editor that DocumentHtml (not BodyHtml) is the property it should treat as
        ' the primary content for this instance.
        _editor.Options.DefaultHtmlType = HtmlContentTypes.DocumentHtml

        _students = StudentRepository.Load()
        _bindingSource.DataSource = _students
        _grid.DataSource = _bindingSource

        _editor.DataBindings.Add(New Binding("DocumentHtml", _bindingSource, "History", True))

        Dim navigator As New BindingNavigator(_bindingSource) With {.Dock = DockStyle.Top}
        Dim saveButton As New ToolStripButton("Save data") With {.DisplayStyle = ToolStripItemDisplayStyle.Text}
        AddHandler saveButton.Click, AddressOf SaveButton_Click
        navigator.Items.Add(saveButton)

        Controls.Add(_editor)
        Controls.Add(_grid)
        Controls.Add(navigator)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)
        Validate()
        _bindingSource.EndEdit()
        StudentRepository.Save(_students)
    End Sub

End Class
