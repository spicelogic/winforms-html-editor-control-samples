# WinForms HTML editor control - C# and VB.NET sample projects

Looking for a winforms html editor for a C# desktop app? This repository is a set of
runnable sample projects for the SpiceLogic .NET windows forms html editor control, a
c# winform wysiwyg html editor you install straight from NuGet. If you have been
searching for a winforms rich text editor that gives you full HTML (not just RTF), clean
paste from Word, mail merge, and a real editor API, these samples show the everyday
patterns: quickstart, load/save, Word paste cleanup, toolbar and context menu
customization, data binding, localization, custom spell checking, custom dialogs, and
mail merge templates. Search for "winforms html editor nuget" and this control, and this
repo, are exactly what you will find.

Every sample from 04 onward ships as a matching pair: a C# project and a VB.NET twin in a
`-VB` folder next to it, both wired into the same solution, so VB.NET developers get the
identical walkthrough in their own language rather than a C#-to-VB translation exercise.

## What this is

These are runnable sample projects for the commercial SpiceLogic .NET WinForms HTML
Editor control, which installs from NuGet. The control itself is closed source and
commercial; the samples in this repository are MIT licensed, so you can copy, adapt, and
ship them freely in your own application.

## Install

```
dotnet add package SpiceLogic.HtmlEditor.WinForms
```

```
PM> Install-Package SpiceLogic.HtmlEditor.WinForms
```

The sample projects reference the package as `Version="*"`, so a restore always pulls the
latest published release and you are never evaluating an old build.

## Run the samples

Prerequisites: Windows. The control itself supports .NET Framework 4.5, 4.7.2, and 4.8,
plus .NET 5 through .NET 10, all on Windows, so it runs on whatever target framework your
own app already uses. The samples in this repository are checked in targeting `net48`,
because .NET Framework 4.8 is part of Windows 10 (1903 and later) and Windows 11, so they
run on a stock Windows machine with no runtime to install. Point them at whatever your own
application uses with the one-line change below, and install the matching SDK for that
target.

```
git clone https://github.com/spicelogic/winforms-html-editor-control-samples.git
cd winforms-html-editor-control-samples
dotnet build WinFormsHtmlEditorSamples.sln
dotnet run --project 01-Quickstart
```

### Targeting a different .NET version

`Directory.Build.props` at the repo root holds a single `<TargetFramework>` line that
every sample project inherits. Change that one line and rebuild to retarget every C# and
VB.NET sample at once. Valid values, matching what the NuGet package ships:

- `net48` (the default here), `net472`, `net45` (.NET Framework)
- `net5.0-windows`, `net6.0-windows`, `net7.0-windows`
- `net8.0-windows`, `net9.0-windows`, `net10.0-windows`

The samples include the small `#if NET6_0_OR_GREATER` block each `Program.cs` needs so
they also build cleanly on .NET Framework, where the source-generated
`ApplicationConfiguration.Initialize()` is not available.

## Samples

Eleven samples, eighteen projects in the solution: every sample from 04 onward has a
"VB.NET twin" folder alongside its C# folder, using the identical scenario and the same
key API members.

| Folder | What it shows | Question it answers | VB.NET twin |
| --- | --- | --- | --- |
| [01-Quickstart](01-Quickstart) | Docking the editor to fill a form, seeding starting HTML, and a live character count from `HtmlChanged` | What is the smallest working editor host? | - |
| [02-LoadAndSaveHtml](02-LoadAndSaveHtml) | Open/Save menu commands, and the difference between `BodyHtml` (inner content) and `DocumentHtml` (full document) | Which property do I save to a database versus a standalone HTML file? | - |
| [03-PasteFromWord](03-PasteFromWord) | Handling the `Pasting` event to strip Word/Outlook markup with a documented regex helper, with a before/after character-count log | How do I clean up messy HTML pasted from Microsoft Word? | - |
| [04-ToolbarCustomization](04-ToolbarCustomization) | Building a fully custom toolbar from a chosen subset of built-in buttons, plus hiding/reordering/re-icon-ing buttons on the built-in toolbars via `ToolbarItemOverrider` | How do I customize the toolbar for my own workflow? | [04-ToolbarCustomization-VB](04-ToolbarCustomization-VB) |
| [05-MailMergeTemplate](05-MailMergeTemplate) | Registering placeholder fields, the built-in placeholder toolbar, and a live merge preview in a second read-only editor | How do I let end users build their own mail-merge templates? | - |
| [06-DataBinding](06-DataBinding) | Binding `BodyHtml` or `DocumentHtml` to a business object through a standard `BindingSource` and `BindingNavigator` | How do I data-bind the editor's content like any other WinForms control? | [06-DataBinding-VB](06-DataBinding-VB) |
| [07-Localization](07-Localization) | Switching the editor UI language and spell-check dictionary independently at runtime, plus overriding individual UI strings with a JSON file | How do I localize the editor UI, and override specific strings without recompiling? | [07-Localization-VB](07-Localization-VB) |
| [08-CustomSpellChecker](08-CustomSpellChecker) | Plugging a custom spell-checking engine in via `ISpellCheckerEngine`, toggled against the built-in engine | How do I replace the built-in spell checker with my own dictionary or cloud API? | [08-CustomSpellChecker-VB](08-CustomSpellChecker-VB) |
| [09-CustomDialog](09-CustomDialog) | Replacing every built-in editor dialog (hyperlink, image, table, table cell, spell checker, symbol picker, search/replace, YouTube insert, style builder) with your own implementation | How do I replace the editor's built-in dialogs with my own branded UI? | [09-CustomDialog-VB](09-CustomDialog-VB) |
| [10-CustomContextMenu](10-CustomContextMenu) | Replacing the built-in right-click menu with a custom `ContextMenuStrip`, enabling/disabling items via `ContextMenuShowing` based on caret context | How do I build my own right-click menu for the editor? | [10-CustomContextMenu-VB](10-CustomContextMenu-VB) |
| [11-FullEditorDemo](11-FullEditorDemo) | A full tour of the control: the complete default toolbar, high-DPI toolbar scaling, live spell checking with a persistent per-user dictionary, and document-level styling via the header style block | What does the editor look like fully assembled, beyond the smallest quickstart host? | [11-FullEditorDemo-VB](11-FullEditorDemo-VB) |

## Quickstart code

```csharp
using SpiceLogic.HtmlEditor.WinForms;

public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - quickstart";
        Controls.Add(_editor);

        _editor.BodyHtml = "<p>Start typing...</p>";
        _editor.HtmlChanged += (_, _) =>
        {
            string currentHtml = _editor.BodyHtml;
            // Persist, validate, or sync currentHtml here.
        };
    }
}
```

## What the control does

- Paste from Word and Outlook without the mess, so your c# winform wysiwyg html editor
  never hands you a document full of Microsoft markup.
- Clean HTML your database and email can trust, ready to store or send as-is.
- Mail-merge templates end users build themselves, with a built-in field picker toolbar.
- Spell check with no deployment drama, no external dictionaries to manage.
- Tables users can edit without calling support, with a full visual table editor.
- Images that arrive clean, whether pasted, dragged, or inserted from a dialog.
- A full editor API to drive it from your own code, covering content, selection,
  formatting, and file operations.
- Toolbar customization, so you can hide, add, and rewire buttons to match your app.
- A multilingual UI, so the editor chrome matches your users' language.
- A CSS style builder, so formatting stays consistent without hand-written CSS.
- WYSIWYG plus source view, for the rare case a power user wants to edit raw HTML.

## Trial and licensing

The control runs a free 14-day trial with no license key required, which is exactly what every
sample in this repository does, so there is nothing to obtain before you evaluate it.

Once you buy, applying the key is one line at application startup, before any form containing the
editor is created:

```csharp
// Program.cs
using SpiceLogic.HtmlEditor.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        WinFormHtmlEditor.LicenseKey = "PASTE-YOUR-LICENSE-KEY-HERE";

        ApplicationConfiguration.Initialize(); // .NET Framework instead: Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
```

```vbnet
' ApplicationEvents.vb
Imports SpiceLogic.HtmlEditor.WinForms

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            WinFormHtmlEditor.LicenseKey = "PASTE-YOUR-LICENSE-KEY-HERE"
        End Sub
    End Class
End Namespace
```

Three things are worth knowing, because a misplaced key does not throw an error - it silently
leaves the application in trial mode:

- `LicenseKey` is static, so one assignment covers every editor in the process. Never set it per
  form or per instance.
- Set it before the first editor is constructed. Assigning it later leaves editors that already
  exist in trial mode.
- Source code license customers who build the editor from the purchased source do not set
  `LicenseKey` at all. That build is licensed automatically.

Your key is on your account at [members.spicelogic.com](https://members.spicelogic.com). Full
details, including what changes at the end of the trial, are in
[how to license the WinForms HTML editor](https://www.spicelogic.com/docs/WinHTMLEditorControl/StartUp/how-to-license-winforms-html-editor-153).

An official MCP server is also available for AI coding assistants, documented at
[spicelogic.com/docs/WinHTMLEditorControl/Programming/mcp-server-501](https://www.spicelogic.com/docs/WinHTMLEditorControl/Programming/mcp-server-501).

## Links

- Product page: https://www.spicelogic.com/Products/NET-WinForms-HTML-Editor-Control-8
- Documentation: https://www.spicelogic.com/docs/WinHTMLEditorControl
- NuGet package: https://www.nuget.org/packages/SpiceLogic.HtmlEditor.WinForms/
- WPF version of this control: https://www.spicelogic.com/Products/WPF-HTML-Editor-Control-17
- WPF samples repo: https://github.com/spicelogic/wpf-html-editor-control-samples
