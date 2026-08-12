# WinForms HTML editor control - C# and VB.NET sample projects

Looking for a winforms html editor for a C# desktop app? This repository is a set of
runnable sample projects for the SpiceLogic .NET windows forms html editor control, a
c# winform wysiwyg html editor you install straight from NuGet. If you have been
searching for a winforms rich text editor that gives you full HTML (not just RTF), clean
paste from Word, mail merge, and a real editor API, these samples show the everyday
patterns: quickstart, load/save, Word paste cleanup, toolbar customization, and mail
merge templates. Search for "winforms html editor nuget" and this control, and this
repo, are exactly what you will find.

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

Current package version: `9.5.7`.

## Run the samples

Prerequisites: Windows. The control itself supports .NET Framework 4.5, 4.7.2, and 4.8,
plus .NET 5 through .NET 10, all on Windows, so it runs on whatever target framework your
own app already uses. The samples in this repository are checked in targeting
net8.0-windows purely as a default, and you need the matching SDK for whichever target
you build against (the .NET 8 SDK for the default, or .NET Framework 4.8 plus the .NET
SDK if you retarget to net48).

```
git clone https://github.com/spicelogic/winforms-html-editor-control-samples.git
cd winforms-html-editor-control-samples
dotnet build WinFormsHtmlEditorSamples.sln
dotnet run --project 01-Quickstart
```

### Targeting a different .NET version

`Directory.Build.props` at the repo root holds a single `<TargetFramework>` line that
every sample project inherits. Change that one line and rebuild to retarget all five
samples at once. Valid values, matching what the NuGet package ships:

- `net48`, `net472`, `net45` (.NET Framework, including .NET Framework 4.8)
- `net5.0-windows`, `net6.0-windows`, `net7.0-windows`
- `net8.0-windows` (the default here), `net9.0-windows`, `net10.0-windows`

The samples include the small `#if NET6_0_OR_GREATER` block each `Program.cs` needs so
they also build cleanly on .NET Framework, where the source-generated
`ApplicationConfiguration.Initialize()` is not available.

## Samples

| Folder | What it shows | Question it answers |
| --- | --- | --- |
| [01-Quickstart](01-Quickstart) | Docking the editor to fill a form, seeding starting HTML, and a live character count from `HtmlChanged` | What is the smallest working editor host? |
| [02-LoadAndSaveHtml](02-LoadAndSaveHtml) | Open/Save menu commands, and the difference between `BodyHtml` and `DocumentHtml` | Which property do I save to a database versus a standalone HTML file? |
| [03-PasteFromWord](03-PasteFromWord) | Handling the `Pasting` event to strip Word/Outlook markup with a documented regex helper | How do I clean up messy HTML pasted from Microsoft Word? |
| [04-ToolbarCustomization](04-ToolbarCustomization) | Hiding built-in toolbar buttons and adding a custom `ToolStripButton` | How do I customize the toolbar for my own workflow? |
| [05-MailMergeTemplate](05-MailMergeTemplate) | Registering placeholder fields, the built-in placeholder toolbar, and a live merge preview | How do I let end users build their own mail-merge templates? |

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
