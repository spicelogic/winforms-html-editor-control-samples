Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Core.SpellCheck
Imports SpiceLogic.HtmlEditor.WinForms
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.UserOptions

''' <summary>
''' A full tour of the WinForms HTML editor rather than the smallest possible host: the
''' complete default toolbar working against a real document, high-DPI toolbar scaling,
''' live spell checking with a persistent user dictionary, and document-level styling
''' through the header style block.
''' </summary>
Public Class MainForm
    Inherits Form

    Private ReadOnly _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}
    Private ReadOnly _statusStrip As New StatusStrip()
    Private ReadOnly _charCountLabel As New ToolStripStatusLabel()
    Private ReadOnly _dpiLabel As New ToolStripStatusLabel()
    Private ReadOnly _spellCheckLabel As New ToolStripStatusLabel()

    Private Const StarterDocumentHtml As String =
        "<h1>Regional expansion brief</h1>" &
        "<p>This starter document exercises the editor's default toolbar end to end: headings, " &
        "character formatting, ordered and unordered lists, a data table, and hyperlinks all " &
        "render exactly as your end users will produce them, with no extra styling code from " &
        "the host application.</p>" &
        "<h2>Rollout milestones</h2>" &
        "<ol>" &
        "<li>Vendor contracts signed</li>" &
        "<li>Regional pricing approved</li>" &
        "<li>Public launch</li>" &
        "</ol>" &
        "<h2>Coverage by market</h2>" &
        "<table>" &
        "<tr><th>Market</th><th>Status</th><th>Owner</th></tr>" &
        "<tr><td>Northeast</td><td>Live</td><td>Alicia Kwan</td></tr>" &
        "<tr><td>Midwest</td><td><i>In review</i></td><td>Diego Ferreira</td></tr>" &
        "<tr><td>West coast</td><td>Planned</td><td>Priya Natarajan</td></tr>" &
        "</table>" &
        "<p>Full terms are documented on the <a href=""https://spicelogic.com"" target=""_blank"">partner " &
        "portal</a>. Reach out with questions before the next steering review.</p>"

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - full editor demo"
        Width = 1200
        Height = 800
        WindowState = FormWindowState.Maximized

        ' No license key set, so the editor runs a 14-day trial. See the licensing docs
        ' linked in the README before shipping.

        ConfigureEditor()
        BuildStatusStrip()

        Controls.Add(_editor)
        Controls.Add(_statusStrip)

        AddHandler _editor.HtmlChanged, Sub() UpdateCharCount()
        AddHandler _editor.SpellCheckCompleted,
            Sub(sender As Object, args As SpellCheckCompletedEventArgs)
                _spellCheckLabel.Text = If(args.Canceled, "Spell check: cancelled", "Spell check: complete")
            End Sub
        AddHandler Load, Sub() UpdateDpiLabel()

        UpdateCharCount()
    End Sub

    Private Sub ConfigureEditor()
        ' Keep the writer's current formatting (bold, list level, alignment...) flowing into
        ' the next paragraph instead of resetting on every Enter key press.
        _editor.Options.ContinueSameStyleAfterEnterKey = True

        ' Normalize file:// image and link URLs dropped in from Explorer to plain local
        ' paths, so saved HTML stays portable across machines.
        _editor.Options.ConvertFileUrlsToLocalPaths = True

        ' Keep pasted clipboard images inline as base64 so the document stays self-contained,
        ' with no separate image files to track alongside it.
        _editor.Options.PasteImageFromClipboardBehavior = UserOption.ImageStorage.Base64

        ' Brand the document with consistent typography and table styling, independent of
        ' whatever CSS the host application otherwise uses.
        _editor.HeaderStyleContentElementID = "full_editor_demo_style"
        _editor.HeaderStyleContent =
            "body { font-family: 'Segoe UI', sans-serif; line-height: 1.6; } " &
            "table { border-collapse: collapse; width: 100%; } " &
            "td, th { border: 1px solid #ccc; padding: 6px 10px; text-align: left; }"

        ' Live, as-you-type squiggle underlines rather than only the on-demand dialog reached
        ' from the toolbar's spell check button.
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = True

        ' A per-user dictionary file under LocalApplicationData (never next to the .exe, which
        ' fails once installed under Program Files) so a word a reviewer adds through
        ' "Add to Dictionary" stays accepted across sessions.
        Dim localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim appFolder = Path.Combine(localAppData, "SpiceLogic", "FullEditorDemoVB")
        Directory.CreateDirectory(appFolder)
        _editor.SpellCheckOptions.DictionaryFile.UserDictionaryFilePath = Path.Combine(appFolder, "user-dictionary.txt")
        _editor.SpellCheckOptions.DictionaryFile.EnableUserDictionary = True

        _editor.BodyHtml = StarterDocumentHtml
    End Sub

    Private Sub BuildStatusStrip()
        _dpiLabel.Text = "Display scaling: -"
        _charCountLabel.Text = "Html length: 0 characters"
        _spellCheckLabel.Text = "Spell check: idle"

        Dim refreshDpiButton As New ToolStripButton("Refresh display scaling") With {
            .DisplayStyle = ToolStripItemDisplayStyle.Text
        }
        AddHandler refreshDpiButton.Click,
            Sub()
                ' Re-applies DPI-aware toolbar icon sizing, for example after the form moves to
                ' a monitor with different scaling or the OS scaling setting changes at runtime.
                _editor.RefreshHighDpiScaling()
                UpdateDpiLabel()
            End Sub

        _statusStrip.Items.Add(refreshDpiButton)
        _statusStrip.Items.Add(New ToolStripSeparator())
        _statusStrip.Items.Add(_dpiLabel)
        _statusStrip.Items.Add(New ToolStripSeparator())
        _statusStrip.Items.Add(_charCountLabel)
        _statusStrip.Items.Add(New ToolStripSeparator())
        _statusStrip.Items.Add(_spellCheckLabel)
    End Sub

    Private Sub UpdateCharCount()
        Dim length = If(_editor.BodyHtml?.Length, 0)
        _charCountLabel.Text = $"Html length: {length} characters"
    End Sub

    Private Sub UpdateDpiLabel()
        Using graphics = CreateGraphics()
            _dpiLabel.Text = $"Display scaling: {graphics.DpiX:0} dpi ({graphics.DpiX / 96:P0})"
        End Using
    End Sub

End Class
