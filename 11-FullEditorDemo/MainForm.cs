using SpiceLogic.HtmlEditor.WinForms;
using SpiceLogic.HtmlEditor.WinForms.Models.BOs.UserOptions;

namespace FullEditorDemo;

/// <summary>
/// A full tour of the WinForms HTML editor rather than the smallest possible host (see
/// 01-Quickstart for that): the complete default toolbar working against a real document,
/// high-DPI toolbar scaling, live spell checking with a persistent user dictionary, and
/// document-level styling through the header style block.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly StatusStrip _statusStrip = new();
    private readonly ToolStripStatusLabel _charCountLabel = new();
    private readonly ToolStripStatusLabel _dpiLabel = new();
    private readonly ToolStripStatusLabel _spellCheckLabel = new();

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - full editor demo";
        Width = 1200;
        Height = 800;
        WindowState = FormWindowState.Maximized;

        // No license key set, so the editor runs a 14-day trial. See the licensing docs
        // linked in the README before shipping.

        ConfigureEditor();
        BuildStatusStrip();

        Controls.Add(_editor);
        Controls.Add(_statusStrip);

        _editor.HtmlChanged += (_, _) => UpdateCharCount();
        _editor.SpellCheckCompleted += (_, args) =>
            _spellCheckLabel.Text = args.Canceled ? "Spell check: cancelled" : "Spell check: complete";

        Load += (_, _) => UpdateDpiLabel();

        UpdateCharCount();
    }

    private void ConfigureEditor()
    {
        // Keep the writer's current formatting (bold, list level, alignment...) flowing into
        // the next paragraph instead of resetting on every Enter key press.
        _editor.Options.ContinueSameStyleAfterEnterKey = true;

        // Normalize file:// image and link URLs dropped in from Explorer to plain local
        // paths, so saved HTML stays portable across machines.
        _editor.Options.ConvertFileUrlsToLocalPaths = true;

        // Keep pasted clipboard images inline as base64 so the document stays self-contained,
        // with no separate image files to track alongside it.
        _editor.Options.PasteImageFromClipboardBehavior = UserOption.ImageStorage.Base64;

        // Brand the document with consistent typography and table styling, independent of
        // whatever CSS the host application otherwise uses.
        _editor.HeaderStyleContentElementID = "full_editor_demo_style";
        _editor.HeaderStyleContent =
            "body { font-family: 'Segoe UI', sans-serif; line-height: 1.6; } " +
            "table { border-collapse: collapse; width: 100%; } " +
            "td, th { border: 1px solid #ccc; padding: 6px 10px; text-align: left; }";

        // Live, as-you-type squiggle underlines rather than only the on-demand dialog reached
        // from the toolbar's spell check button.
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = true;

        // A per-user dictionary file under LocalApplicationData (never next to the .exe, which
        // fails once installed under Program Files) so a word a reviewer adds through
        // "Add to Dictionary" stays accepted across sessions.
        string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string appFolder = Path.Combine(localAppData, "SpiceLogic", "FullEditorDemo");
        Directory.CreateDirectory(appFolder);
        _editor.SpellCheckOptions.DictionaryFile.UserDictionaryFilePath = Path.Combine(appFolder, "user-dictionary.txt");
        _editor.SpellCheckOptions.DictionaryFile.EnableUserDictionary = true;

        _editor.BodyHtml = StarterDocumentHtml;
    }

    private void BuildStatusStrip()
    {
        _dpiLabel.Text = "Display scaling: -";
        _charCountLabel.Text = "Html length: 0 characters";
        _spellCheckLabel.Text = "Spell check: idle";

        var refreshDpiButton = new ToolStripButton("Refresh display scaling")
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text,
        };
        refreshDpiButton.Click += (_, _) =>
        {
            // Re-applies DPI-aware toolbar icon sizing, for example after the form moves to a
            // monitor with different scaling or the OS scaling setting changes at runtime.
            _editor.RefreshHighDpiScaling();
            UpdateDpiLabel();
        };

        _statusStrip.Items.Add(refreshDpiButton);
        _statusStrip.Items.Add(new ToolStripSeparator());
        _statusStrip.Items.Add(_dpiLabel);
        _statusStrip.Items.Add(new ToolStripSeparator());
        _statusStrip.Items.Add(_charCountLabel);
        _statusStrip.Items.Add(new ToolStripSeparator());
        _statusStrip.Items.Add(_spellCheckLabel);
    }

    private void UpdateCharCount()
    {
        int length = _editor.BodyHtml?.Length ?? 0;
        _charCountLabel.Text = $"Html length: {length} characters";
    }

    private void UpdateDpiLabel()
    {
        using var graphics = CreateGraphics();
        _dpiLabel.Text = $"Display scaling: {graphics.DpiX:0} dpi ({graphics.DpiX / 96:P0})";
    }

    private const string StarterDocumentHtml = """
        <h1>Regional expansion brief</h1>
        <p>This starter document exercises the editor's default toolbar end to end: headings,
        character formatting, ordered and unordered lists, a data table, and hyperlinks all
        render exactly as your end users will produce them, with no extra styling code from
        the host application.</p>
        <h2>Rollout milestones</h2>
        <ol>
        <li>Vendor contracts signed</li>
        <li>Regional pricing approved</li>
        <li>Public launch</li>
        </ol>
        <h2>Coverage by market</h2>
        <table>
        <tr><th>Market</th><th>Status</th><th>Owner</th></tr>
        <tr><td>Northeast</td><td>Live</td><td>Alicia Kwan</td></tr>
        <tr><td>Midwest</td><td><i>In review</i></td><td>Diego Ferreira</td></tr>
        <tr><td>West coast</td><td>Planned</td><td>Priya Natarajan</td></tr>
        </table>
        <p>Full terms are documented on the <a href="https://spicelogic.com" target="_blank">partner
        portal</a>. Reach out with questions before the next steering review.</p>
        """;
}
