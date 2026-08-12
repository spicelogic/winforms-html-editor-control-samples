Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms

''' <summary>
''' The smallest possible host for the WinForms HTML editor: dock it to fill the form,
''' seed some starting content, and show a live character count of the current HTML.
''' </summary>
Public Class MainForm
    Inherits Form

    Private WithEvents _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}
    Private ReadOnly _statusStrip As New StatusStrip()
    Private ReadOnly _charCountLabel As New ToolStripStatusLabel()

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - quickstart"
        Width = 1000
        Height = 700

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _statusStrip.Items.Add(_charCountLabel)

        Controls.Add(_editor)
        Controls.Add(_statusStrip)

        _editor.BodyHtml = "<p>Start typing to see the live character count update below.</p>"

        UpdateCharCount()
    End Sub

    Private Sub OnEditorHtmlChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _editor.HtmlChanged
        UpdateCharCount()
    End Sub

    Private Sub UpdateCharCount()
        Dim length As Integer = If(_editor.BodyHtml?.Length, 0)
        _charCountLabel.Text = $"Html length: {length} characters"
    End Sub
End Class
