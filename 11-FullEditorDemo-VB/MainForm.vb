Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Core.SpellCheck
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.UserOptions

''' <summary>
''' A full tour of the WinForms HTML editor rather than the smallest possible host: the
''' complete default toolbar working against a real document, high-DPI toolbar scaling,
''' live spell checking with a persistent user dictionary, and document-level styling
''' through the header style block.
'''
''' The editor and status strip are laid out in the designer; open MainForm.vb in the
''' Visual Studio designer to see them.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    ''' <summary>
    ''' The document stylesheet. It sets no absolute font size: the text keeps the editor's
    ''' own default size and everything else is expressed in em, so the document reads at the
    ''' same scale as the rest of the application. The table is deliberately not width:100% -
    ''' a percentage width is resolved against the viewport, which leaves the document a few
    ''' pixels wider than the visible area once the vertical scrollbar appears.
    ''' </summary>
    Private Const DocumentStyle As String =
        "body { font-family: 'Segoe UI', 'Helvetica Neue', Arial, sans-serif; line-height: 1.6; color: #1f2933; margin: 24px 30px; }" &
        "h1 { font-size: 2em; font-weight: 600; color: #0f2540; margin: 0 0 4px 0; }" &
        "h2 { font-size: 1.3em; font-weight: 600; color: #0f2540; margin: 26px 0 10px 0; padding-bottom: 6px; border-bottom: 1px solid #e2e8f0; }" &
        "p { margin: 0 0 12px 0; }" &
        "a { color: #1a6fd4; text-decoration: none; border-bottom: 1px solid #bcd6f5; }" &
        "ul, ol { margin: 0 0 14px 0; padding-left: 22px; }" &
        "li { margin-bottom: 7px; }" &
        ".eyebrow { font-size: 0.75em; font-weight: 600; color: #1a6fd4; letter-spacing: 1.2px; margin: 0 0 6px 0; }" &
        ".lede { font-size: 1.1em; color: #52606d; margin: 0 0 22px 0; }" &
        ".callout { background-color: #f2f7fd; border-left: 4px solid #1a6fd4; padding: 14px 18px; margin: 0 0 22px 0; }" &
        ".callout p { margin: 0; }" &
        "table { border-collapse: collapse; margin: 4px 0 18px 0; }" &
        "th { background-color: #0f2540; color: #ffffff; text-align: left; font-weight: 600; padding: 10px 16px; }" &
        "td { border-bottom: 1px solid #e2e8f0; padding: 10px 16px; }" &
        "tr.alt td { background-color: #f7f9fc; }" &
        ".badge { display: inline-block; padding: 2px 10px; font-size: 0.85em; font-weight: 600; border-radius: 10px; }" &
        ".badge-live { background-color: #dff3e4; color: #1b6b3a; }" &
        ".badge-review { background-color: #fdf0d5; color: #8a5a00; }" &
        ".badge-planned { background-color: #eceff3; color: #52606d; }" &
        "blockquote { margin: 0 0 14px 0; padding: 2px 0 2px 18px; border-left: 3px solid #cfd8e3; color: #52606d; font-style: italic; }" &
        ".muted { color: #7b8794; font-size: 0.85em; }"

    Private Const StarterDocumentHtml As String =
        "<p class=""eyebrow"">Regional expansion</p>" &
        "<h1>Northwind Traders rollout brief</h1>" &
        "<p class=""lede"">Headings, character formatting, lists, a data table, and hyperlinks all render " &
        "exactly as your end users will produce them, styled entirely by the document stylesheet.</p>" &
        "<div class=""callout"">" &
        "<p><strong>Steering review:</strong> 4 September &nbsp;&middot;&nbsp; <strong>Go-live window:</strong> " &
        "22 September to 6 October &nbsp;&middot;&nbsp; <strong>Owner:</strong> Alicia Kwan</p>" &
        "</div>" &
        "<h2>Rollout milestones</h2>" &
        "<ol>" &
        "<li>Vendor contracts signed</li>" &
        "<li>Regional pricing approved</li>" &
        "<li>Public launch</li>" &
        "</ol>" &
        "<h2>Coverage by market</h2>" &
        "<table>" &
        "<tr><th>Market</th><th>Status</th><th>Owner</th><th>Go-live</th></tr>" &
        "<tr><td>Northeast</td><td><span class=""badge badge-live"">Live</span></td><td>Alicia Kwan</td><td>Complete</td></tr>" &
        "<tr class=""alt""><td>Midwest</td><td><span class=""badge badge-review"">In review</span></td><td>Diego Ferreira</td><td>22 September</td></tr>" &
        "<tr><td>West coast</td><td><span class=""badge badge-planned"">Planned</span></td><td>Priya Natarajan</td><td>6 October</td></tr>" &
        "<tr class=""alt""><td>Canada</td><td><span class=""badge badge-planned"">Planned</span></td><td>Priya Natarajan</td><td>Q4</td></tr>" &
        "</table>" &
        "<h2>Commercial terms</h2>" &
        "<blockquote>Fees are fixed for the initial three markets. Any market added after the September " &
        "steering review is quoted separately against the same rate card.</blockquote>" &
        "<p>Full terms are documented on the <a href=""https://www.spicelogic.com"" target=""_blank"">partner " &
        "portal</a>. Reach out with questions before the next steering review.</p>" &
        "<p class=""muted"">Prepared by the delivery team &nbsp;&middot;&nbsp; Revision 4</p>"

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs a 14-day trial. See the licensing docs
        ' linked in the README before shipping.

        ConfigureEditor()

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
        _editor.HeaderStyleContent = DocumentStyle

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

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDpiLabel()
    End Sub

    Private Sub OnRefreshDpiClick(sender As Object, e As EventArgs) Handles _refreshDpiButton.Click
        ' Re-applies DPI-aware toolbar icon sizing, for example after the form moves to
        ' a monitor with different scaling or the OS scaling setting changes at runtime.
        _editor.RefreshHighDpiScaling()
        UpdateDpiLabel()
    End Sub

    Private Sub OnEditorHtmlChanged(sender As Object, e As EventArgs) Handles _editor.HtmlChanged
        UpdateCharCount()
    End Sub

    Private Sub OnSpellCheckCompleted(sender As Object, e As SpellCheckCompletedEventArgs) Handles _editor.SpellCheckCompleted
        _spellCheckLabel.Text = If(e.Canceled, "Spell check: cancelled", "Spell check: complete")
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
