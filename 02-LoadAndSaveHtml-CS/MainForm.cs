using SpiceLogic.HtmlEditor.WinForms;

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
/// A radio button lets you pick which property Open/Save uses, so you can see
/// the difference in the saved .html file.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly RadioButton _bodyHtmlOption = new() { Text = "Use BodyHtml (inner content only)", Checked = true, AutoSize = true };
    private readonly RadioButton _documentHtmlOption = new() { Text = "Use DocumentHtml (full document)", AutoSize = true };
    private readonly FlowLayoutPanel _optionsPanel = new() { Dock = DockStyle.Top, Height = 32, FlowDirection = FlowDirection.LeftToRight };

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - load and save HTML";
        Width = 1000;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        var menuStrip = new MenuStrip();
        var fileMenu = new ToolStripMenuItem("File");
        var openItem = new ToolStripMenuItem("Open...", null, OnOpen);
        var saveItem = new ToolStripMenuItem("Save as...", null, OnSave);
        fileMenu.DropDownItems.Add(openItem);
        fileMenu.DropDownItems.Add(saveItem);
        menuStrip.Items.Add(fileMenu);
        MainMenuStrip = menuStrip;

        _optionsPanel.Controls.Add(_bodyHtmlOption);
        _optionsPanel.Controls.Add(_documentHtmlOption);

        Controls.Add(_editor);
        Controls.Add(_optionsPanel);
        Controls.Add(menuStrip);

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
