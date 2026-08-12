Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms

''' <summary>
''' Binds the editor's BodyHtml property to a field on a business object through a standard
''' WinForms BindingSource, the same way you would bind any other control on the form. Use the
''' binding navigator to move between records and see the editor content change, edit the HTML,
''' then click "Save data" to write the edits back to disk.
'''
''' The WinForms editor writes a bound value back to the data source on validation (for example
''' when you navigate to another record or the form loses focus), not on every keystroke - the
''' control does not raise property-change notifications for BodyHtml, so
''' DataSourceUpdateMode.OnPropertyChanged has no effect. If you need to react to every
''' keystroke, handle the editor's HtmlChanged event instead.
''' </summary>
Public Class BodyHtmlBindingForm
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
        Text = "BodyHtml binding demo (VB.NET)"
        Width = 950
        Height = 640

        _students = StudentRepository.Load()
        _bindingSource.DataSource = _students
        _grid.DataSource = _bindingSource

        ' The key line: a plain WinForms Binding on the editor's BodyHtml property.
        _editor.DataBindings.Add(New Binding("BodyHtml", _bindingSource, "History", True))

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
