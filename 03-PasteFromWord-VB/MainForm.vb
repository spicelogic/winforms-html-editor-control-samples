Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs

''' <summary>
''' Handles the Pasting event to clean up Word/Outlook clipboard HTML before it lands in
''' the document. When IsPastingFromMsWord is true, class/style attributes and Word's own
''' "o:" / "w:" namespaced markup are stripped with a small documented regex helper
''' (see WordHtmlCleaner.vb). A log panel below the editor records a before/after summary
''' for every paste so the cleanup is visible.
'''
''' The layout lives in the designer; open MainForm.vb in the Visual Studio designer to see it.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

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
