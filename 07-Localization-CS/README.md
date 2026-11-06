# 07 - Localization

Switches the WinForms HTML editor between every built-in UI language, switches the inline
spell-check dictionary independently of the UI language, and shows how to override individual
UI strings at runtime with a JSON file - no recompiling the control required.

Key API members used: `WinFormHtmlEditor.Language`, `EditorLanguage`, `SpellCheckOptions.SpellCheckLanguage`,
`SpellCheckLanguage`, `LocalizationManager.SetJsonOverrideDirectory`.

Pick **Polish** from the *Editor language* dropdown, then tick **Enable JSON override** to see a
few toolbar tooltips switch to a `[Custom]` prefix, proving the JSON file in
`SpiceLogic.HtmlEditor.Localization\EditorStrings.pl-PL.json` overrides the built-in Polish text.
See the [localization override guide](SpiceLogic.HtmlEditor.Localization/README.md) in this
folder for the full how-to and the catalog of every overridable key.

A VB.NET version of this same sample sits alongside in `07-Localization-VB`.


## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```

## A custom interface language

Select `Custom` and load `SpiceLogic.HtmlEditor.Localization` to use
`EditorStrings.custom.json`. WinForms and WPF expose the JSON override checkbox;
Avalonia loads the folder at startup and provides a Custom interface button.
The supplied file demonstrates two Turkish labels. Remaining labels fall back
to neutral English. For a complete language, ask your coding assistant to translate
every value in `_OVERRIDABLE-KEYS.reference.json`, preserving the keys and format
placeholders, and save the result as `EditorStrings.custom.json`. Review the
translation and test the actual dialogs before shipping. Custom does not supply
a spelling dictionary or infer a .NET culture; configure spelling separately.
