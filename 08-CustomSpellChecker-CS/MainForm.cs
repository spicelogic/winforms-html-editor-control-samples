using SpiceLogic.HtmlEditor.WinForms;
using SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck;

namespace CustomSpellChecker;

/// <summary>
/// Demonstrates plugging a custom spell-checking engine into the editor by implementing
/// ISpellCheckerEngine (see CustomSpellCheckerEngine.cs) and assigning it to
/// SpellCheckOptions.CustomSpellCheckerEngine. A radio button toggles between the
/// built-in OpenOffice-based engine and the custom demo engine so the difference is
/// visible: the built-in engine checks against a real English dictionary, while the
/// custom engine flags every word starting with the letter "a" as misspelled.
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };
    private readonly RadioButton _builtInOption = new() { Text = "Built-in engine", Checked = true, AutoSize = true };
    private readonly RadioButton _customOption = new() { Text = "Custom engine (demo)", AutoSize = true };
    private readonly FlowLayoutPanel _optionsPanel = new() { Dock = DockStyle.Top, Height = 32, FlowDirection = FlowDirection.LeftToRight };

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - custom spell checker";
        Width = 1000;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _editor.SpellCheckOptions.CurlyUnderlineImageFilePath = Path.Combine(Application.StartupPath, "underline.gif");
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = true;

        _builtInOption.CheckedChanged += OnEngineChanged;

        _optionsPanel.Controls.Add(_builtInOption);
        _optionsPanel.Controls.Add(_customOption);

        Controls.Add(_editor);
        Controls.Add(_optionsPanel);

        _editor.BodyHtml =
            "<p>Type a word and press space to trigger inline spell checking. The built-in engine checks " +
            "against a real English dictionary; the custom engine below flags every word starting with the " +
            "letter \"a\" as misspelled, so the demo logic is obvious. Right-click a flagged word to see " +
            "suggestions.</p>";
    }

    private void OnEngineChanged(object? sender, EventArgs e)
    {
        if (_builtInOption.Checked)
        {
            _editor.SpellCheckOptions.SpellChecker = SpellCheckerEngineTypes.OpenOffice;
        }
        else
        {
            _editor.SpellCheckOptions.SpellChecker = SpellCheckerEngineTypes.Custom;
            _editor.SpellCheckOptions.CustomSpellCheckerEngine = new CustomSpellCheckerEngine();
        }
    }
}
