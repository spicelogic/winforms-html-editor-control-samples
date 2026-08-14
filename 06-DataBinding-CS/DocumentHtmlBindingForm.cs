using SpiceLogic.HtmlEditor.Abstractions;

namespace DataBinding;

/// <summary>
/// Binds the editor's DocumentHtml property - the full document including head and body,
/// rather than just the body fragment - to a field on a business object. Everything else about
/// the binding works the same as the BodyHtml scenario; see that form's comments for the
/// details on write timing.
///
/// The grid, navigator, and docked editor are laid out in the designer; open
/// DocumentHtmlBindingForm.cs in the Visual Studio designer to see them.
/// </summary>
public partial class DocumentHtmlBindingForm : Form
{
    private readonly List<Student> _students;

    public DocumentHtmlBindingForm()
    {
        InitializeComponent();

        // Tells the editor that DocumentHtml (not BodyHtml) is the property it should treat as
        // the primary content for this instance.
        _editor.Options.DefaultHtmlType = HtmlContentTypes.DocumentHtml;

        _students = StudentRepository.Load();
        _bindingSource.DataSource = _students;

        _editor.DataBindings.Add(new Binding("DocumentHtml", _bindingSource, "History", true));
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        Validate();
        _bindingSource.EndEdit();
        StudentRepository.Save(_students);
    }
}
