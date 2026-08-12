Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck
Imports SpiceLogic.HtmlEditor.Resources.Localization
Imports SpiceLogic.HtmlEditor.WinForms

''' <summary>
''' Shows three independent localization features:
'''
'''   1. Switching the built-in editor UI (toolbar tooltips, dialogs, context menus) between
'''      every language the control ships, using the Language property and the EditorLanguage enum.
'''   2. Switching the inline spell-check dictionary independently of the UI language, using
'''      SpellCheckOptions.SpellCheckLanguage (defaults to SameAsEditorLanguage).
'''   3. Overriding individual UI strings at runtime with a small JSON file dropped next to the
'''      application - no recompiling the control required.
''' </summary>
Public Class MainForm
    Inherits Form

    Private ReadOnly _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}

    Private ReadOnly _topPanel As New FlowLayoutPanel() With {
        .Dock = DockStyle.Top,
        .AutoSize = True,
        .WrapContents = False,
        .Padding = New Padding(10, 10, 10, 5)
    }

    Private ReadOnly _languageCombo As New ComboBox() With {
        .DropDownStyle = ComboBoxStyle.DropDownList,
        .Width = 200,
        .Margin = New Padding(0, 3, 15, 0)
    }

    Private ReadOnly _currentLanguageLabel As New Label() With {
        .AutoSize = True,
        .ForeColor = Color.DarkBlue,
        .Margin = New Padding(0, 6, 15, 0)
    }

    Private ReadOnly _spellCheckCombo As New ComboBox() With {
        .DropDownStyle = ComboBoxStyle.DropDownList,
        .Width = 200,
        .Margin = New Padding(0, 3, 15, 0)
    }

    Private ReadOnly _jsonOverrideCheckBox As New CheckBox() With {
        .AutoSize = True,
        .Text = "Enable JSON override (Polish)",
        .Margin = New Padding(0, 6, 0, 0)
    }

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - localization (VB.NET)"
        Width = 1200
        Height = 800

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _topPanel.Controls.Add(New Label() With {.AutoSize = True, .Margin = New Padding(0, 6, 5, 0), .Text = "Editor language:"})
        _topPanel.Controls.Add(_languageCombo)
        _topPanel.Controls.Add(_currentLanguageLabel)
        _topPanel.Controls.Add(New Label() With {.AutoSize = True, .Margin = New Padding(0, 6, 5, 0), .Text = "Spell check language:"})
        _topPanel.Controls.Add(_spellCheckCombo)
        _topPanel.Controls.Add(_jsonOverrideCheckBox)

        Controls.Add(_editor)
        Controls.Add(_topPanel)

        ' 1. Editor language dropdown, populated from the EditorLanguage enum the control ships.
        For Each lang As EditorLanguage In [Enum].GetValues(GetType(EditorLanguage))
            _languageCombo.Items.Add(lang)
        Next
        _languageCombo.SelectedItem = EditorLanguage.EnglishUs
        _currentLanguageLabel.Text = "Current: EnglishUs"
        AddHandler _languageCombo.SelectedIndexChanged, AddressOf OnLanguageChanged
        AddHandler _jsonOverrideCheckBox.CheckedChanged, AddressOf OnJsonOverrideChanged

        ' 2. Spell-check language dropdown. SameAsEditorLanguage (the default) tracks whatever
        '    is picked above automatically; pick a specific language here to override it.
        For Each lang As SpellCheckLanguage In [Enum].GetValues(GetType(SpellCheckLanguage))
            _spellCheckCombo.Items.Add(lang)
        Next
        _spellCheckCombo.SelectedItem = SpellCheckLanguage.SameAsEditorLanguage
        AddHandler _spellCheckCombo.SelectedIndexChanged, AddressOf OnSpellCheckLanguageChanged

        _editor.BodyHtml = "<h2>Localization</h2>" _
            & "<p>Change the language dropdown above to see all toolbar tooltips, context menu " _
            & "items, and dialog strings update.</p>" _
            & "<p>Right-click to test context menu localization.</p>" _
            & "<p>Click toolbar buttons (Hyperlink, Image, Table, etc.) to test dialog localization.</p>" _
            & "<p>Inline spell-check is enabled - type a misspelled word followed by a space " _
            & "(e.g. <i>helllo</i>) to see the curly underline. The spell check language dropdown " _
            & "above defaults to <i>SameAsEditorLanguage</i> (the dictionary tracks the editor " _
            & "language); pick a specific language there to override it independently.</p>" _
            & "<hr/>" _
            & "<p><b>JSON override demo:</b> select <i>Polish</i> from the language dropdown, then " _
            & "check <i>Enable JSON override</i>. Toolbar tooltips like Bold, Italic, and Underline " _
            & "switch to a <code>[CUSTOM]</code> prefix, proving the JSON file overrides the " _
            & "embedded RESX strings.</p>"

        ' 3. Inline spell-check: SpellCheckLanguage defaults to SameAsEditorLanguage, so picking
        '    Polish in the language dropdown also switches the dictionary to pl_PL.
        _editor.SpellCheckOptions.CurlyUnderlineImageFilePath = Path.Combine(Application.StartupPath, "underline.gif")
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = True
    End Sub

    Private Sub OnLanguageChanged(sender As Object, e As EventArgs)
        If TypeOf _languageCombo.SelectedItem Is EditorLanguage Then
            Dim selectedLang = CType(_languageCombo.SelectedItem, EditorLanguage)
            _editor.Language = selectedLang
            _currentLanguageLabel.Text = $"Current: {selectedLang}"
        End If
    End Sub

    Private Sub OnSpellCheckLanguageChanged(sender As Object, e As EventArgs)
        ' Setting SpellCheckLanguage flags the engine to reload the dictionary on the next
        ' inline spell-check pass.
        If TypeOf _spellCheckCombo.SelectedItem Is SpellCheckLanguage Then
            Dim selectedLang = CType(_spellCheckCombo.SelectedItem, SpellCheckLanguage)
            _editor.SpellCheckOptions.SpellCheckLanguage = selectedLang
        End If
    End Sub

    Private Sub OnJsonOverrideChanged(sender As Object, e As EventArgs)
        If _jsonOverrideCheckBox.Checked Then
            Dim overrideDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SpiceLogic.HtmlEditor.Localization")
            If Not Directory.Exists(overrideDir) Then
                MessageBox.Show(
                    $"Override directory not found:{vbLf}{overrideDir}{vbLf}{vbLf}Make sure the JSON file is set to Copy to Output Directory.",
                    "JSON override", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                _jsonOverrideCheckBox.Checked = False
                Return
            End If

            LocalizationManager.SetJsonOverrideDirectory(overrideDir)
        Else
            LocalizationManager.SetJsonOverrideDirectory(Nothing)
        End If

        ' Re-apply the current language to refresh all strings.
        If TypeOf _languageCombo.SelectedItem Is EditorLanguage Then
            Dim selectedLang = CType(_languageCombo.SelectedItem, EditorLanguage)
            _editor.Language = selectedLang
        End If
    End Sub

End Class
