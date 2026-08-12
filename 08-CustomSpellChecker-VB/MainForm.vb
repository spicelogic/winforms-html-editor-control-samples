Imports System
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.WinForms
Imports SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck

''' <summary>
''' Demonstrates plugging a custom spell-checking engine into the editor by implementing
''' ISpellCheckerEngine (see CustomSpellCheckerEngine.vb) and assigning it to
''' SpellCheckOptions.CustomSpellCheckerEngine. A radio button toggles between the
''' built-in OpenOffice-based engine and the custom demo engine so the difference is
''' visible: the built-in engine checks against a real English dictionary, while the
''' custom engine flags every word starting with the letter "a" as misspelled.
''' </summary>
Public Class MainForm
    Inherits Form

    Private ReadOnly _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}
    Private ReadOnly _builtInOption As New RadioButton() With {.Text = "Built-in engine", .Checked = True, .AutoSize = True}
    Private ReadOnly _customOption As New RadioButton() With {.Text = "Custom engine (demo)", .AutoSize = True}
    Private ReadOnly _optionsPanel As New FlowLayoutPanel() With {.Dock = DockStyle.Top, .Height = 32, .FlowDirection = FlowDirection.LeftToRight}

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - custom spell checker"
        Width = 1000
        Height = 700

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        _editor.SpellCheckOptions.CurlyUnderlineImageFilePath = Path.Combine(Application.StartupPath, "underline.gif")
        _editor.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = True

        AddHandler _builtInOption.CheckedChanged, AddressOf OnEngineChanged

        _optionsPanel.Controls.Add(_builtInOption)
        _optionsPanel.Controls.Add(_customOption)

        Controls.Add(_editor)
        Controls.Add(_optionsPanel)

        _editor.BodyHtml =
            "<p>Type a word and press space to trigger inline spell checking. The built-in engine checks " &
            "against a real English dictionary; the custom engine below flags every word starting with the " &
            "letter ""a"" as misspelled, so the demo logic is obvious. Right-click a flagged word to see " &
            "suggestions.</p>"
    End Sub

    Private Sub OnEngineChanged(sender As Object, e As EventArgs)
        If _builtInOption.Checked Then
            _editor.SpellCheckOptions.SpellChecker = SpellCheckerEngineTypes.OpenOffice
        Else
            _editor.SpellCheckOptions.SpellChecker = SpellCheckerEngineTypes.Custom
            _editor.SpellCheckOptions.CustomSpellCheckerEngine = New CustomSpellCheckerEngine()
        End If
    End Sub
End Class
