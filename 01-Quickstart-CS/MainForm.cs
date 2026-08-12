using SpiceLogic.HtmlEditor.WinForms;

namespace Quickstart;

/// <summary>
/// The smallest possible host for the WinForms HTML editor: dock it to fill the form,
/// seed some starting content, and show a live character count of the current HTML.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly StatusStrip _statusStrip = new();
    private readonly ToolStripStatusLabel _charCountLabel = new();

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - quickstart";
        Width = 1000;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _statusStrip.Items.Add(_charCountLabel);

        Controls.Add(_editor);
        Controls.Add(_statusStrip);

        _editor.BodyHtml = "<p>Start typing to see the live character count update below.</p>";

        _editor.HtmlChanged += (_, _) => UpdateCharCount();

        UpdateCharCount();
    }

    private void UpdateCharCount()
    {
        int length = _editor.BodyHtml?.Length ?? 0;
        _charCountLabel.Text = $"Html length: {length} characters";
    }
}
