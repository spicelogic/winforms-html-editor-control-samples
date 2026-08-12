using SpiceLogic.HtmlEditor.Abstractions;
using SpiceLogic.HtmlEditor.WinForms;

namespace DataBinding;

/// <summary>
/// Binds the editor's DocumentHtml property - the full document including head and body,
/// rather than just the body fragment - to a field on a business object. Everything else about
/// the binding works the same as the BodyHtml scenario; see that form's comments for the
/// details on write timing.
/// </summary>
public class DocumentHtmlBindingForm : Form
{
    private readonly BindingSource _bindingSource = new();
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly DataGridView _grid = new()
    {
        Dock = DockStyle.Top,
        Height = 200,
        AutoGenerateColumns = true,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    };

    private readonly List<Student> _students;

    public DocumentHtmlBindingForm()
    {
        Text = "DocumentHtml binding demo";
        Width = 950;
        Height = 640;

        // Tells the editor that DocumentHtml (not BodyHtml) is the property it should treat as
        // the primary content for this instance.
        _editor.Options.DefaultHtmlType = HtmlContentTypes.DocumentHtml;

        _students = StudentRepository.Load();
        _bindingSource.DataSource = _students;
        _grid.DataSource = _bindingSource;

        _editor.DataBindings.Add(new Binding("DocumentHtml", _bindingSource, "History", true));

        BindingNavigator navigator = new(_bindingSource) { Dock = DockStyle.Top };
        ToolStripButton saveButton = new("Save data") { DisplayStyle = ToolStripItemDisplayStyle.Text };
        saveButton.Click += SaveButton_Click;
        navigator.Items.Add(saveButton);

        Controls.Add(_editor);
        Controls.Add(_grid);
        Controls.Add(navigator);
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        Validate();
        _bindingSource.EndEdit();
        StudentRepository.Save(_students);
    }
}
