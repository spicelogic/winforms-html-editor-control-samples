using SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck;
using SpiceLogic.HtmlEditor.Resources.Localization;
using SpiceLogic.HtmlEditor.WinForms;

namespace LocalizationSample;

/// <summary>
/// Shows three independent localization features:
///
///   1. Switching the built-in editor UI (toolbar tooltips, dialogs, context menus) between
///      every language the control ships, using the Language property and the EditorLanguage enum.
///   2. Switching the inline spell-check dictionary independently of the UI language, using
///      SpellCheckOptions.SpellCheckLanguage (defaults to SameAsEditorLanguage).
///   3. Overriding individual UI strings at runtime with a small JSON file dropped next to the
///      application - no recompiling the control required.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };

    private readonly FlowLayoutPanel _topPanel = new()
    {
        Dock = DockStyle.Top,
        AutoSize = true,
        WrapContents = false,
        Padding = new Padding(10, 10, 10, 5)
    };

    private readonly ComboBox _languageCombo = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200, Margin = new Padding(0, 3, 15, 0) };
    private readonly Label _currentLanguageLabel = new() { AutoSize = true, ForeColor = Color.DarkBlue, Margin = new Padding(0, 6, 15, 0) };
    private readonly ComboBox _spellCheckCombo = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200, Margin = new Padding(0, 3, 15, 0) };
    private readonly CheckBox _jsonOverrideCheckBox = new() { AutoSize = true, Text = "Enable JSON override (Polish)", Margin = new Padding(0, 6, 0, 0) };

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - localization";
        Width = 1200;
        Height = 800;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _topPanel.Controls.Add(new Label { AutoSize = true, Margin = new Padding(0, 6, 5, 0), Text = "Editor language:" });
        _topPanel.Controls.Add(_languageCombo);
        _topPanel.Controls.Add(_currentLanguageLabel);
        _topPanel.Controls.Add(new Label { AutoSize = true, Margin = new Padding(0, 6, 5, 0), Text = "Spell check language:" });
        _topPanel.Controls.Add(_spellCheckCombo);
        _topPanel.Controls.Add(_jsonOverrideCheckBox);

        Controls.Add(_editor);
        Controls.Add(_topPanel);

        // 1. Editor language dropdown, populated from the EditorLanguage enum the control ships.
        foreach (EditorLanguage lang in Enum.GetValues(typeof(EditorLanguage)))
        {
            _languageCombo.Items.Add(lang);
        }
        _languageCombo.SelectedItem = EditorLanguage.EnglishUs;
        _currentLanguageLabel.Text = "Current: EnglishUs";
        _languageCombo.SelectedIndexChanged += OnLanguageChanged;
        _jsonOverrideCheckBox.CheckedChanged += OnJsonOverrideChanged;

        // 2. Spell-check language dropdown. SameAsEditorLanguage (the default) tracks whatever
        //    is picked above automatically; pick a specific language here to override it.
        foreach (SpellCheckLanguage lang in Enum.GetValues(typeof(SpellCheckLanguage)))
        {
            _spellCheckCombo.Items.Add(lang);
        }
        _spellCheckCombo.SelectedItem = SpellCheckLanguage.SameAsEditorLanguage;
        _spellCheckCombo.SelectedIndexChanged += OnSpellCheckLanguageChanged;

        _editor.BodyHtml = "<h2>Localization</h2>"
            + "<p>Change the language dropdown above to see all toolbar tooltips, context menu "
            + "items, and dialog strings update.</p>"
            + "<p>Right-click to test context menu localization.</p>"
            + "<p>Click toolbar buttons (Hyperlink, Image, Table, etc.) to test dialog localization.</p>"
            + "<p>Inline spell-check is enabled - type a misspelled word followed by a space "
            + "(e.g. <i>helllo</i>) to see the curly underline. The spell check language dropdown "
            + "above defaults to <i>SameAsEditorLanguage</i> (the dictionary tracks the editor "
            + "language); pick a specific language there to override it independently.</p>"
            + "<hr/>"
            + "<p><b>JSON override demo:</b> select <i>Polish</i> from the language dropdown, then "
            + "check <i>Enable JSON override</i>. Toolbar tooltips like Bold, Italic, and Underline "
            + "switch to a <code>[CUSTOM]</code> prefix, proving the JSON file overrides the "
            + "embedded RESX strings.</p>";

        // 3. Inline spell-check: SpellCheckLanguage defaults to SameAsEditorLanguage, so picking
        //    Polish in the language dropdown also switches the dictionary to pl_PL.
        _editor.SpellCheckOptions.CurlyUnderlineImageFilePath = Path.Combine(Application.StartupPath, "underline.gif");
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = true;
    }

    private void OnLanguageChanged(object? sender, EventArgs e)
    {
        if (_languageCombo.SelectedItem is EditorLanguage selectedLang)
        {
            _editor.Language = selectedLang;
            _currentLanguageLabel.Text = $"Current: {selectedLang}";
        }
    }

    private void OnSpellCheckLanguageChanged(object? sender, EventArgs e)
    {
        // Setting SpellCheckLanguage flags the engine to reload the dictionary on the next
        // inline spell-check pass.
        if (_spellCheckCombo.SelectedItem is SpellCheckLanguage selectedLang)
        {
            _editor.SpellCheckOptions.SpellCheckLanguage = selectedLang;
        }
    }

    private void OnJsonOverrideChanged(object? sender, EventArgs e)
    {
        if (_jsonOverrideCheckBox.Checked)
        {
            var overrideDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SpiceLogic.HtmlEditor.Localization");
            if (!Directory.Exists(overrideDir))
            {
                MessageBox.Show(
                    $"Override directory not found:\n{overrideDir}\n\nMake sure the JSON file is set to Copy to Output Directory.",
                    "JSON override", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _jsonOverrideCheckBox.Checked = false;
                return;
            }

            LocalizationManager.SetJsonOverrideDirectory(overrideDir);
        }
        else
        {
            LocalizationManager.SetJsonOverrideDirectory(null);
        }

        // Re-apply the current language to refresh all strings.
        if (_languageCombo.SelectedItem is EditorLanguage selectedLang)
        {
            _editor.Language = selectedLang;
        }
    }
}
