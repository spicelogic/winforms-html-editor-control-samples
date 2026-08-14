using SpiceLogic.HtmlEditor.Abstractions.Entities.MailMerge;

namespace MailMergeTemplate;

/// <summary>
/// Builds a mail-merge template with end-user-insertable placeholder fields, then merges
/// a sample data record into the template on demand for a preview.
///
/// The top editor is the template the end user edits, with the built-in placeholder
/// toolbar enabled (ShowPlaceholderToolbar) so they can insert fields like "First name"
/// without typing raw tokens. The bottom editor is a read-only preview that shows the
/// same content with the tokens replaced by sample record values.
///
/// The split layout and the button strip live in the designer; open MainForm.cs in the
/// Visual Studio designer to see them.
/// </summary>
public partial class MainForm : Form
{
    // A single sample record standing in for a row you would normally pull from a
    // database, CRM, or invoicing system. The keys match each field's Token.
    private static readonly Dictionary<string, string> SampleRecord = new()
    {
        ["{{FirstName}}"] = "Jordan",
        ["{{LastName}}"] = "Reyes",
        ["{{Company}}"] = "Northwind Traders",
        ["{{InvoiceNumber}}"] = "INV-10452",
        ["{{DueDate}}"] = "2026-09-01"
    };

    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        // Register the fields the end user is allowed to insert into the template.
        _templateEditor.Content.MailMerge.PlaceholderFields = new List<PlaceholderField>
        {
            new("First name", "{{FirstName}}"),
            new("Last name", "{{LastName}}"),
            new("Company", "{{Company}}"),
            new("Invoice number", "{{InvoiceNumber}}"),
            new("Due date", "{{DueDate}}")
        };

        // Reveal the built-in field picker toolbar so the end user can insert fields
        // without typing raw tokens.
        _templateEditor.ShowPlaceholderToolbar = true;

        _templateEditor.BodyHtml =
            "<p>Dear {{FirstName}} {{LastName}},</p>" +
            "<p>This is a reminder that invoice {{InvoiceNumber}} for {{Company}} is due on {{DueDate}}.</p>" +
            "<p>Use the placeholder toolbar above to insert additional fields, then click \"Preview merged\" to see the result.</p>";

        _previewEditor.BodyHtml = "<p><em>Click \"Preview merged\" to see the template with sample data filled in.</em></p>";
        _previewEditor.ChangeReadOnlyMode(true);
    }

    private void OnPreviewMerged(object? sender, EventArgs e)
    {
        string merged = _templateEditor.BodyHtml;

        foreach (var pair in SampleRecord)
        {
            // The two-argument String.Replace overload is already an ordinal comparison, and
            // it is the one available on every target framework this sample builds against
            // (the StringComparison overload is .NET Core 2.1+ only, not .NET Framework).
            merged = merged.Replace(pair.Key, pair.Value);
        }

        _previewEditor.ChangeReadOnlyMode(false);
        _previewEditor.BodyHtml = merged;
        _previewEditor.ChangeReadOnlyMode(true);
    }
}
