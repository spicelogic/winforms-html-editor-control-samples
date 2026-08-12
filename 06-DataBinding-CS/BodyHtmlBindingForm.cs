using SpiceLogic.HtmlEditor.WinForms;

namespace DataBinding;

/// <summary>
/// Binds the editor's BodyHtml property to a field on a business object through a standard
/// WinForms BindingSource, the same way you would bind any other control on the form. Use the
/// binding navigator to move between records and see the editor content change, edit the HTML,
/// then click "Save data" to write the edits back to disk.
///
/// The WinForms editor writes a bound value back to the data source on validation (for example
/// when you navigate to another record or the form loses focus), not on every keystroke - the
/// control does not raise property-change notifications for BodyHtml, so
/// DataSourceUpdateMode.OnPropertyChanged has no effect. If you need to react to every
/// keystroke, handle the editor's HtmlChanged event instead.
/// </summary>
public class BodyHtmlBindingForm : Form
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

    public BodyHtmlBindingForm()
    {
        Text = "BodyHtml binding demo";
        Width = 950;
        Height = 640;

        _students = StudentRepository.Load();
        _bindingSource.DataSource = _students;
        _grid.DataSource = _bindingSource;

        // The key line: a plain WinForms Binding on the editor's BodyHtml property.
        _editor.DataBindings.Add(new Binding("BodyHtml", _bindingSource, "History", true));

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
