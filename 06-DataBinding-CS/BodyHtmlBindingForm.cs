namespace DataBinding;

/// <summary>
/// Binds the editor's BodyHtml property to a field on a business object through a standard
/// WinForms BindingSource, the same way you would bind any other control on the form. Use the
/// binding navigator to move between records and see the editor content change, edit the HTML,
/// then click "Save data" to write the edits back to disk.
///
/// The grid, navigator, and docked editor are laid out in the designer; open
/// BodyHtmlBindingForm.cs in the Visual Studio designer to see them.
///
/// The WinForms editor writes a bound value back to the data source on validation (for example
/// when you navigate to another record or the form loses focus), not on every keystroke - the
/// control does not raise property-change notifications for BodyHtml, so
/// DataSourceUpdateMode.OnPropertyChanged has no effect. If you need to react to every
/// keystroke, handle the editor's HtmlChanged event instead.
/// </summary>
public partial class BodyHtmlBindingForm : Form
{
    private readonly List<Student> _students;

    public BodyHtmlBindingForm()
    {
        InitializeComponent();

        _students = StudentRepository.Load();
        _bindingSource.DataSource = _students;

        // The key line: a plain WinForms Binding on the editor's BodyHtml property.
        _editor.DataBindings.Add(new Binding("BodyHtml", _bindingSource, "History", true));
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        Validate();
        _bindingSource.EndEdit();
        StudentRepository.Save(_students);
    }
}
