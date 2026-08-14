using SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs;

namespace PasteFromWord;

/// <summary>
/// Handles the Pasting event to clean up Word/Outlook clipboard HTML before it lands in
/// the document. When IsPastingFromMsWord is true, class/style attributes and Word's own
/// "o:" / "w:" namespaced markup are stripped with a small documented regex helper
/// (see WordHtmlCleaner.cs). A log panel below the editor records a before/after summary
/// for every paste so the cleanup is visible.
///
/// The layout lives in the designer; open MainForm.cs in the Visual Studio designer to see it.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

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
