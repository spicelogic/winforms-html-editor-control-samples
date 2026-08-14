namespace LoadAndSaveHtml;

/// <summary>
/// Demonstrates the difference between the two properties you can persist:
///
///   BodyHtml     - inner content only, no &lt;html&gt;/&lt;head&gt; wrapper.
///                  This is what you typically store in a database column,
///                  because it is easy to drop into an email body or another
///                  page without fighting a nested &lt;html&gt; tag.
///
///   DocumentHtml - the complete document, including &lt;html&gt;, &lt;head&gt;
///                  and any style/meta content. Use this when you want a
///                  file that can be opened standalone in a browser.
///
/// The layout (menu, radio buttons, docked editor) lives in the designer; open
/// MainForm.cs in the Visual Studio designer to see it. A radio button lets you pick
/// which property Open/Save uses, so you can see the difference in the saved .html file.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _editor.DocumentTitle = "Sample document";
        _editor.BodyHtml = "<p>Open or save this content as HTML using the File menu above.</p>";
    }

    private void OnOpen(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "HTML files (*.html;*.htm)|*.html;*.htm|All files (*.*)|*.*",
            Title = "Open HTML file"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        string html = File.ReadAllText(dialog.FileName);

        if (_bodyHtmlOption.Checked)
        {
            _editor.BodyHtml = html;
        }
        else
        {
            _editor.DocumentHtml = html;
        }
    }

    private void OnSave(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
            Title = "Save HTML file",
            FileName = _bodyHtmlOption.Checked ? "body-content.html" : "full-document.html"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        // BodyHtml gives inner content only (good for a database column or an email body).
        // DocumentHtml gives a complete, standalone document (good for a file you can open in a browser).
        string html = _bodyHtmlOption.Checked ? _editor.BodyHtml : _editor.DocumentHtml;

        File.WriteAllText(dialog.FileName, html);

        MessageBox.Show(this,
            $"Saved using {(_bodyHtmlOption.Checked ? "BodyHtml" : "DocumentHtml")}.",
            "Saved",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
