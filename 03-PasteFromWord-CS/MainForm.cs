using SpiceLogic.HtmlEditor.WinForms;
using SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs;

namespace PasteFromWord;

/// <summary>
/// Handles the Pasting event to clean up Word/Outlook clipboard HTML before it lands in
/// the document. When IsPastingFromMsWord is true, class/style attributes and Word's own
/// "o:" / "w:" namespaced markup are stripped with a small documented regex helper
/// (see WordHtmlCleaner.cs). A side panel logs a before/after summary for every paste so
/// the cleanup is visible.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly TextBox _log = new()
    {
        Dock = DockStyle.Fill,
        Multiline = true,
        ReadOnly = true,
        ScrollBars = ScrollBars.Vertical,
        Font = new Font(FontFamily.GenericMonospace, 9)
    };
    private readonly SplitContainer _splitContainer = new() { Dock = DockStyle.Fill, Orientation = Orientation.Vertical };

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - paste from Word";
        Width = 1200;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        var logPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(4) };
        var logLabel = new Label { Text = "Paste log", Dock = DockStyle.Top, Height = 20 };
        logPanel.Controls.Add(_log);
        logPanel.Controls.Add(logLabel);

        _splitContainer.Panel1.Controls.Add(_editor);
        _splitContainer.Panel2.Controls.Add(logPanel);
        _splitContainer.SplitterDistance = 750;

        Controls.Add(_splitContainer);

        _editor.BodyHtml = "<p>Copy some formatted text from Microsoft Word or Outlook, then paste it here (Ctrl+V) to see the cleanup log.</p>";

        _editor.Pasting += OnPasting;
    }

    private void OnPasting(object? sender, PastingHtmlEventArgs e)
    {
        string incoming = e.PastingHtml ?? string.Empty;
        int incomingLength = incoming.Length;

        AppendLog($"Incoming paste: {incomingLength} characters. From MS Word: {e.IsPastingFromMsWord}.");

        if (e.IsPastingFromMsWord)
        {
            string cleaned = WordHtmlCleaner.Clean(incoming);

            // Setting PastingHtml is what tells the editor the content changed;
            // IsModified is a read-only flag the editor computes from that assignment.
            e.PastingHtml = cleaned;

            AppendLog($"Cleaned paste: {cleaned.Length} characters (removed {incomingLength - cleaned.Length} characters of Word markup).");
        }
    }

    private void AppendLog(string message)
    {
        _log.AppendText($"{DateTime.Now:HH:mm:ss}  {message}{Environment.NewLine}");
    }
}
