using SpiceLogic.HtmlEditor.WinForms;

namespace ToolbarCustomization;

/// <summary>
/// Shows two independent toolbar customizations:
///
///   1. Hiding a couple of built-in buttons you do not want end users to see, by
///      setting their Visible property to false.
///   2. Adding your own ToolStripButton to Toolbar2 that runs custom logic, here
///      inserting a fixed HTML signature block at the end of the document.
///
/// Reordering built-in buttons is not shown, because the samples here only need
/// addition and hiding to cover the common toolbar customization scenarios.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };

    private const string SignatureHtml =
        "<p>Best regards,<br/>The Sales Team<br/><em>Sent with SpiceLogic HTML Editor</em></p>";

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - toolbar customization";
        Width = 1000;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        Controls.Add(_editor);

        _editor.BodyHtml = "<p>This toolbar hides a couple of built-in buttons and adds a custom \"Insert signature\" button.</p>";

        // 1. Hide built-in buttons you do not want to expose to end users.
        _editor.BtnInsertYouTubeVideo.Visible = false;
        _editor.BtnSymbol.Visible = false;

        // 2. Add a custom button to Toolbar2 that inserts a fixed HTML block.
        var insertSignatureButton = new ToolStripButton("Insert signature")
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text
        };
        insertSignatureButton.Click += (_, _) =>
        {
            _editor.BodyHtml += SignatureHtml;
        };

        _editor.Toolbar2.Items.Add(new ToolStripSeparator());
        _editor.Toolbar2.Items.Add(insertSignatureButton);
    }
}
