Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Entities.MailMerge

''' <summary>
''' Builds a mail-merge template with end-user-insertable placeholder fields, then merges
''' a sample data record into the template on demand for a preview.
'''
''' The top editor is the template the end user edits, with the built-in placeholder
''' toolbar enabled (ShowPlaceholderToolbar) so they can insert fields like "First name"
''' without typing raw tokens. The bottom editor is a read-only preview that shows the
''' same content with the tokens replaced by sample record values.
'''
''' The split layout and the button strip live in the designer; open MainForm.vb in the
''' Visual Studio designer to see them.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    ' A single sample record standing in for a row you would normally pull from a
    ' database, CRM, or invoicing system. The keys match each field's Token.
    Private Shared ReadOnly SampleRecord As New Dictionary(Of String, String) From {
        {"{{FirstName}}", "Jordan"},
        {"{{LastName}}", "Reyes"},
        {"{{Company}}", "Northwind Traders"},
        {"{{InvoiceNumber}}", "INV-10452"},
        {"{{DueDate}}", "2026-09-01"}
    }

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        ' Register the fields the end user is allowed to insert into the template.
        _templateEditor.Content.MailMerge.PlaceholderFields = New List(Of PlaceholderField) From {
            New PlaceholderField("First name", "{{FirstName}}"),
            New PlaceholderField("Last name", "{{LastName}}"),
            New PlaceholderField("Company", "{{Company}}"),
            New PlaceholderField("Invoice number", "{{InvoiceNumber}}"),
            New PlaceholderField("Due date", "{{DueDate}}")
        }

        ' Reveal the built-in field picker toolbar so the end user can insert fields
        ' without typing raw tokens.
        _templateEditor.ShowPlaceholderToolbar = True

        _templateEditor.BodyHtml =
            "<p>Dear {{FirstName}} {{LastName}},</p>" &
            "<p>This is a reminder that invoice {{InvoiceNumber}} for {{Company}} is due on {{DueDate}}.</p>" &
            "<p>Use the placeholder toolbar above to insert additional fields, then click ""Preview merged"" to see the result.</p>"

        _previewEditor.BodyHtml = "<p><em>Click ""Preview merged"" to see the template with sample data filled in.</em></p>"
        _previewEditor.ChangeReadOnlyMode(True)
    End Sub

    Private Sub OnPreviewMerged(ByVal sender As Object, ByVal e As EventArgs) Handles _previewButton.Click
        Dim merged As String = _templateEditor.BodyHtml

        For Each pair In SampleRecord
            ' String.Replace(String, String) is already an ordinal comparison, and it is the
            ' overload available on every target framework this sample builds against (the
            ' StringComparison overload is .NET Core 2.1+ only, not .NET Framework).
            merged = merged.Replace(pair.Key, pair.Value)
        Next

        _previewEditor.ChangeReadOnlyMode(False)
        _previewEditor.BodyHtml = merged
        _previewEditor.ChangeReadOnlyMode(True)
    End Sub

End Class
