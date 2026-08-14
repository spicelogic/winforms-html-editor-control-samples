using System.IO;
using SpiceLogic.HtmlEditor.WinForms.ToolbarModule;

namespace ToolbarCustomization;

/// <summary>
/// Shows the range of toolbar customization the control supports, across two tabs.
///
///   "Build a custom toolbar" hides the built-in toolbars entirely and moves a chosen
///   subset of built-in buttons - reached through ToolbarItemOverrider.ToolbarItems -
///   into your own ToolStrip, in whatever order you like.
///
///   "Customize the built-in toolbars" keeps the built-in toolbars but edits them in
///   place: hiding individual buttons (both through ToolbarItemOverrider, and through
///   the editor's own direct Btn* shortcut properties that point at those same
///   buttons), swapping a button icon, replacing a button's click behavior, changing a
///   tooltip, and appending custom buttons that act on the document.
///
/// The tabs, the two editors, and the custom ToolStrip are laid out in the designer;
/// open MainForm.cs in the Visual Studio designer to see them.
/// </summary>
public partial class MainForm : Form
{
    private const string SignatureHtml =
        "<p>Best regards,<br/>The Sales Team<br/><em>Sent with SpiceLogic HTML editor</em></p>";

    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.
    }

    private void OnLoad(object? sender, EventArgs e)
    {
        SetUpCustomToolbarTab();
        SetUpOverrideTab();
    }

    /// <summary>
    /// Hides both built-in toolbars, then relocates a chosen subset of built-in items -
    /// in whatever order you like - onto a ToolStrip you own. Use this when end users
    /// should see only a curated set of commands, laid out to match your application.
    /// </summary>
    private void SetUpCustomToolbarTab()
    {
        _customToolbarEditor.BodyHtml =
            "<p>This tab hides the editor's own toolbars and rebuilds a curated one from a chosen subset of built-in commands.</p>";

        _customToolbarEditor.Toolbar1.Visible = false;
        _customToolbarEditor.Toolbar2.Visible = false;

        ToolbarItemReferences items = _customToolbarEditor.ToolbarItemOverrider.ToolbarItems;

        _customToolbarEditor.Toolbar1.Items.Remove(items.Bold);
        _customStrip.Items.Add(items.Bold);

        _customToolbarEditor.Toolbar1.Items.Remove(items.Italic);
        _customStrip.Items.Add(items.Italic);

        _customToolbarEditor.Toolbar1.Items.Remove(items.Underline);
        _customStrip.Items.Add(items.Underline);

        _customToolbarEditor.Toolbar1.Items.Remove(items.Cut);
        _customStrip.Items.Add(items.Cut);

        _customToolbarEditor.Toolbar1.Items.Remove(items.Copy);
        _customStrip.Items.Add(items.Copy);

        _customToolbarEditor.Toolbar1.Items.Remove(items.Paste);
        _customStrip.Items.Add(items.Paste);

        _customToolbarEditor.Toolbar1.Items.Remove(items.FontName);
        _customStrip.Items.Add(items.FontName);

        _customToolbarEditor.Toolbar1.Items.Remove(items.FontSize);
        _customStrip.Items.Add(items.FontSize);

        _customToolbarEditor.Toolbar2.Items.Remove(items.Hyperlink);
        _customStrip.Items.Add(items.Hyperlink);

        _customToolbarEditor.Toolbar2.Items.Remove(items.Image);
        _customStrip.Items.Add(items.Image);

        _customToolbarEditor.Toolbar2.Items.Remove(items.FontColor);
        _customStrip.Items.Add(items.FontColor);
    }

    /// <summary>
    /// Keeps the built-in toolbars, but customizes individual buttons on them: hides
    /// some, restyles one, redirects one's click behavior, retags one's tooltip, and
    /// appends two buttons of our own that act on the document.
    /// </summary>
    private void SetUpOverrideTab()
    {
        _overrideEditor.BodyHtml =
            "<p>This tab keeps the built-in toolbars, but hides, restyles, and redirects individual buttons on them.</p>";

        // Hide a button through the general-purpose ToolbarItemOverrider path - the one to
        // reach for whenever a button has no dedicated shortcut property of its own.
        _overrideEditor.ToolbarItemOverrider.ToolbarItems.New.Visible = false;

        // Hide buttons through the editor's own direct Btn* shortcut properties instead.
        // These point at the exact same buttons as ToolbarItemOverrider.ToolbarItems.Symbol
        // and .YouTubeVideo - pick whichever reads better at the call site.
        _overrideEditor.BtnSymbol.Visible = false;
        _overrideEditor.BtnInsertYouTubeVideo.Visible = false;

        // Swap a button's icon.
        string savePath = Path.Combine(Application.StartupPath, "Resources", "save_accept.png");
        if (File.Exists(savePath))
        {
            _overrideEditor.ToolbarItemOverrider.ToolbarItems.Save.Image = Image.FromFile(savePath);
        }

        // Redirect a built-in button's click to your own logic instead of the default
        // behavior - useful when Save should write to your own storage, not a file dialog.
        _overrideEditor.ToolbarItemOverrider.SaveButtonClicked += OnSaveButtonClicked;

        // Retag a built-in button's tooltip to match what it actually does in your app.
        _overrideEditor.ToolbarItemOverrider.ToolbarItems.Open.ToolTipText = "Load content from database";

        // Append custom buttons that act on the document.
        var insertSignatureButton = new ToolStripButton("Insert signature")
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text
        };
        insertSignatureButton.Click += (_, _) => _overrideEditor.BodyHtml += SignatureHtml;
        _overrideEditor.Toolbar1.Items.Add(insertSignatureButton);

        var insertTimestampButton = new ToolStripButton("Insert timestamp")
        {
            DisplayStyle = ToolStripItemDisplayStyle.Text
        };
        insertTimestampButton.Click += (_, _) =>
            _overrideEditor.BodyHtml += $"<p>{DateTime.Now:yyyy-MM-dd HH:mm}</p>";
        _overrideEditor.Toolbar2.Items.Add(insertTimestampButton);
    }

    private static void OnSaveButtonClicked(object? sender, EventArgs e)
    {
        MessageBox.Show("Save the content to your own storage here, instead of the default save dialog.",
            "Custom save logic", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
