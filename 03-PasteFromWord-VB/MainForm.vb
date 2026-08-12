Imports System.Drawing
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs

''' <summary>
''' Handles the Pasting event to clean up Word/Outlook clipboard HTML before it lands in
''' the document. When IsPastingFromMsWord is true, class/style attributes and Word's own
''' "o:" / "w:" namespaced markup are stripped with a small documented regex helper
''' (see WordHtmlCleaner.vb). A side panel logs a before/after summary for every paste so
''' the cleanup is visible.
''' </summary>
Public Class MainForm
    Inherits Form

    Private WithEvents _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}
    Private ReadOnly _log As New TextBox() With {
        .Dock = DockStyle.Fill,
        .Multiline = True,
        .ReadOnly = True,
        .ScrollBars = ScrollBars.Vertical,
        .Font = New Font(FontFamily.GenericMonospace, 9)
    }
    Private ReadOnly _splitContainer As New SplitContainer() With {.Dock = DockStyle.Fill, .Orientation = Orientation.Vertical}

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - paste from Word"
        Width = 1200
        Height = 700

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        Dim logPanel As New Panel() With {.Dock = DockStyle.Fill, .Padding = New Padding(4)}
        Dim logLabel As New Label() With {.Text = "Paste log", .Dock = DockStyle.Top, .Height = 20}
        logPanel.Controls.Add(_log)
        logPanel.Controls.Add(logLabel)

        _splitContainer.Panel1.Controls.Add(_editor)
        _splitContainer.Panel2.Controls.Add(logPanel)
        _splitContainer.SplitterDistance = 750

        Controls.Add(_splitContainer)

        _editor.BodyHtml = "<p>Copy some formatted text from Microsoft Word or Outlook, then paste it here (Ctrl+V) to see the cleanup log.</p>"
    End Sub

    Private Sub OnPasting(sender As Object, e As PastingHtmlEventArgs) Handles _editor.Pasting
        Dim incoming As String = If(e.PastingHtml, String.Empty)
        Dim incomingLength As Integer = incoming.Length

        AppendLog($"Incoming paste: {incomingLength} characters. From MS Word: {e.IsPastingFromMsWord}.")

        If e.IsPastingFromMsWord Then
            Dim cleaned As String = WordHtmlCleaner.Clean(incoming)

            ' Setting PastingHtml is what tells the editor the content changed;
            ' IsModified is a read-only flag the editor computes from that assignment.
            e.PastingHtml = cleaned

            AppendLog($"Cleaned paste: {cleaned.Length} characters (removed {incomingLength - cleaned.Length} characters of Word markup).")
        End If
    End Sub

    Private Sub AppendLog(message As String)
        _log.AppendText($"{DateTime.Now:HH:mm:ss}  {message}{Environment.NewLine}")
    End Sub

End Class
