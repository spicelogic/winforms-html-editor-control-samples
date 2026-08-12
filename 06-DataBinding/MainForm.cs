namespace DataBinding;

/// <summary>
/// Launches the two data binding scenarios: binding the editor's BodyHtml property, and
/// binding its DocumentHtml property, to a field on a bound business object.
/// </summary>
public class MainForm : Form
{
    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - data binding";
        Width = 640;
        Height = 320;
        StartPosition = FormStartPosition.CenterScreen;
        Padding = new Padding(15);

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        Label description = new()
        {
            Dock = DockStyle.Top,
            Height = 80,
            Text = "The WinForms HTML editor supports standard WinForms data binding for both the " +
                   "BodyHtml and DocumentHtml properties, so you can bind editor content to a list, " +
                   "a DataSet, or a business object through a BindingSource - the same way you would " +
                   "bind any other control."
        };

        Label instructions = new()
        {
            Dock = DockStyle.Top,
            Height = 30,
            Font = new Font(Font, FontStyle.Bold),
            Text = "Choose a binding scenario:"
        };

        Button bodyHtmlButton = new()
        {
            Dock = DockStyle.Top,
            Height = 40,
            Text = "BodyHtml binding - bind editor content via the BodyHtml property",
            TextAlign = ContentAlignment.MiddleLeft
        };
        bodyHtmlButton.Click += (_, _) => new BodyHtmlBindingForm().Show();

        Button documentHtmlButton = new()
        {
            Dock = DockStyle.Top,
            Height = 40,
            Text = "DocumentHtml binding - bind the full document HTML, including head and body",
            TextAlign = ContentAlignment.MiddleLeft
        };
        documentHtmlButton.Click += (_, _) => new DocumentHtmlBindingForm().Show();

        // Docked controls stack from the last one added (outermost) to the first (innermost),
        // so this order puts the description at the very top and the buttons below it.
        Controls.Add(documentHtmlButton);
        Controls.Add(bodyHtmlButton);
        Controls.Add(instructions);
        Controls.Add(description);
    }
}
