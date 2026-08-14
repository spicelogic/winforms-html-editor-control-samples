namespace DataBinding;

/// <summary>
/// Launches the two data binding scenarios: binding the editor's BodyHtml property, and
/// binding its DocumentHtml property, to a field on a bound business object.
///
/// The layout lives in the designer; open MainForm.cs in the Visual Studio designer to see it.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.
    }

    private void OnBodyHtmlButtonClick(object? sender, EventArgs e)
    {
        new BodyHtmlBindingForm().Show();
    }

    private void OnDocumentHtmlButtonClick(object? sender, EventArgs e)
    {
        new DocumentHtmlBindingForm().Show();
    }
}
