<div align="center">

# WinForms HTML editor control

**Runnable C# and VB.NET sample projects for the SpiceLogic .NET WinForms HTML Editor**

[![NuGet](https://img.shields.io/nuget/v/SpiceLogic.HtmlEditor.WinForms?label=NuGet&color=004880)](https://www.nuget.org/packages/SpiceLogic.HtmlEditor.WinForms/)
[![Downloads](https://img.shields.io/nuget/dt/SpiceLogic.HtmlEditor.WinForms?label=downloads&color=success)](https://www.nuget.org/packages/SpiceLogic.HtmlEditor.WinForms/)
[![Samples license](https://img.shields.io/badge/samples-MIT-blue)](LICENSE)
[![Targets](https://img.shields.io/badge/.NET-Framework%204.5%20to%20.NET%2010-512BD4)](#targeting-a-different-net-version)
[![Languages](https://img.shields.io/badge/languages-C%23%20%2B%20VB.NET-brightgreen)](#samples)

[Product page](https://www.spicelogic.com/Products/NET-WinForms-HTML-Editor-Control-8)&nbsp; &middot;&nbsp;
[Documentation](https://www.spicelogic.com/docs/WinHTMLEditorControl)&nbsp; &middot;&nbsp;
[NuGet](https://www.nuget.org/packages/SpiceLogic.HtmlEditor.WinForms/)&nbsp; &middot;&nbsp;
[WPF version](https://github.com/spicelogic/wpf-html-editor-control-samples)

</div>

> [!TIP]
> ### Coding with an AI assistant? Connect our MCP server first.
>
> ```text
> https://mcp.spicelogic.com/html-editor/winforms
> ```
>
> Claude Code, Cursor, GitHub Copilot, Windsurf, and any other MCP-capable client can read the
> real documentation for this control instead of guessing at member names. The server answers
> with verified API signatures, working samples, the current NuGet package id and version, and
> the exact licensing code, so the code it writes compiles the first time.
>
> <details>
> <summary><b>Add it to your assistant</b></summary>
>
> Claude Code, one line:
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
>
> Any other client, in its MCP configuration file:
>
> ```json
> {
>   "mcpServers": {
>     "spicelogic-winforms": {
>       "type": "http",
>       "url": "https://mcp.spicelogic.com/html-editor/winforms"
>     }
>   }
> }
> ```
>
> Tools exposed: `get_quickstart`, `get_api`, `get_sample`, `search_docs`, `get_doc_page`,
> `get_licensing`. Full write-up:
> [MCP server for the WinForms HTML editor](https://www.spicelogic.com/docs/WinHTMLEditorControl/Programming/mcp-server-501).
>
> </details>

---

Looking for a winforms html editor for a C# desktop app? This repository is a set of runnable
sample projects for the SpiceLogic .NET windows forms html editor control, a c# winform wysiwyg
html editor you install straight from NuGet. If you have been searching for a winforms rich text
editor that gives you full HTML (not just RTF), clean paste from Word, mail merge, and a real
editor API, these samples show the everyday patterns: quickstart, load/save, Word paste cleanup,
toolbar and context menu customization, data binding, localization, custom spell checking, custom
dialogs, and mail merge templates. Search for "winforms html editor nuget" and this control, and
this repo, are exactly what you will find.

Every sample ships as a matching pair: a C# project and a VB.NET twin in a `-VB` folder next to
it, both wired into the same solution, so VB.NET developers get the identical walkthrough in
their own language rather than a C#-to-VB translation exercise.

Every form is built in the Visual Studio designer, so you can open any `MainForm.cs` or
`MainForm.vb`, see the editor on the design surface, and drag your own controls around it.

## What this is

Runnable sample projects for the commercial SpiceLogic .NET WinForms HTML Editor control, which
installs from NuGet. The control itself is closed source and commercial; the samples in this
repository are MIT licensed, so you can copy, adapt, and ship them freely in your own application.

## Install

```bash
dotnet add package SpiceLogic.HtmlEditor.WinForms
```

```powershell
PM> Install-Package SpiceLogic.HtmlEditor.WinForms
```

The sample projects reference the package as `Version="*"`, so a restore always pulls the latest
published release and you are never evaluating an old build.

## Get the samples

```bash
git clone https://github.com/spicelogic/winforms-html-editor-control-samples.git
```

Open `WinFormsHtmlEditorSamples.sln` and start with **01-Quickstart-CS**.

Prerequisites: Windows. The control supports .NET Framework 4.5, 4.7.2, and 4.8, plus .NET 5
through .NET 10, all on Windows, so it runs on whatever target framework your own app already
uses. The samples are checked in targeting `net48`, because .NET Framework 4.8 is part of
Windows 10 (1903 and later) and Windows 11, so they run on a stock Windows machine with no
runtime to install.

<details>
<summary><b>Targeting a different .NET version</b></summary>

`Directory.Build.props` at the repo root holds a single `<TargetFramework>` line that every
sample project inherits. Change that one line and rebuild to retarget every C# and VB.NET sample
at once. Valid values, matching what the NuGet package ships:

| Family | Targets |
| --- | --- |
| .NET Framework | `net48` (the default here), `net472`, `net45` |
| .NET | `net5.0-windows`, `net6.0-windows`, `net7.0-windows`, `net8.0-windows`, `net9.0-windows`, `net10.0-windows` |

The samples include the small `#if NET6_0_OR_GREATER` block each `Program.cs` needs so they also
build cleanly on .NET Framework, where the source-generated
`ApplicationConfiguration.Initialize()` is not available.

</details>

## Samples

Eleven samples, twenty-two projects in the solution: every sample has a VB.NET twin folder
alongside its C# folder, using the identical scenario and the same key API members.

| # | Sample | What it shows | Question it answers |
| :-- | :-- | :-- | :-- |
| 01 | [Quickstart](01-Quickstart-CS) <br> [VB](01-Quickstart-VB) | Docking the editor to fill a form, a styled starting document, and a live character count from `HtmlChanged` | What is the smallest working editor host? |
| 02 | [LoadAndSaveHtml](02-LoadAndSaveHtml-CS) <br> [VB](02-LoadAndSaveHtml-VB) | Open and save commands, and the difference between `BodyHtml` (inner content) and `DocumentHtml` (full document) | Which property do I save to a database versus a standalone HTML file? |
| 03 | [PasteFromWord](03-PasteFromWord-CS) <br> [VB](03-PasteFromWord-VB) | Handling the `Pasting` event to strip Word and Outlook markup, with a before and after character-count log | How do I clean up messy HTML pasted from Microsoft Word? |
| 04 | [ToolbarCustomization](04-ToolbarCustomization-CS) <br> [VB](04-ToolbarCustomization-VB) | Building a custom toolbar from a chosen subset of built-in buttons, plus hiding, reordering, and re-iconing buttons through `ToolbarItemOverrider` | How do I customize the toolbar for my own workflow? |
| 05 | [MailMergeTemplate](05-MailMergeTemplate-CS) <br> [VB](05-MailMergeTemplate-VB) | Registering placeholder fields, the built-in placeholder toolbar, and a live merge preview in a second read-only editor | How do I let end users build their own mail-merge templates? |
| 06 | [DataBinding](06-DataBinding-CS) <br> [VB](06-DataBinding-VB) | Binding `BodyHtml` or `DocumentHtml` to a business object through a standard `BindingSource` and `BindingNavigator` | How do I data-bind the editor's content like any other WinForms control? |
| 07 | [Localization](07-Localization-CS) <br> [VB](07-Localization-VB) | Switching the editor UI language and spell-check dictionary independently at runtime, plus overriding individual UI strings with a JSON file | How do I localize the editor UI without recompiling? |
| 08 | [CustomSpellChecker](08-CustomSpellChecker-CS) <br> [VB](08-CustomSpellChecker-VB) | Plugging a custom spell-checking engine in through `ISpellCheckerEngine`, toggled against the built-in engine | How do I replace the built-in spell checker with my own dictionary or cloud API? |
| 09 | [CustomDialog](09-CustomDialog-CS) <br> [VB](09-CustomDialog-VB) | Replacing every built-in editor dialog (hyperlink, image, table, table cell, spell checker, symbol picker, search and replace, YouTube insert, style builder) with your own | How do I replace the editor's dialogs with my own branded UI? |
| 10 | [CustomContextMenu](10-CustomContextMenu-CS) <br> [VB](10-CustomContextMenu-VB) | Replacing the right-click menu with a custom `ContextMenuStrip`, enabling and hiding items through `ContextMenuShowing` based on caret context | How do I build my own right-click menu for the editor? |
| 11 | [FullEditorDemo](11-FullEditorDemo-CS) <br> [VB](11-FullEditorDemo-VB) | A full tour: the complete default toolbar, high-DPI toolbar scaling, live spell checking with a persistent per-user dictionary, and document-level styling through the header style block | What does the editor look like fully assembled? |

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

| | |
| :-- | :-- |
| **Paste from Word and Outlook** | Without the mess, so your c# winform wysiwyg html editor never hands you a document full of Microsoft markup |
| **Clean HTML** | Ready for your database and your email pipeline to store or send as-is |
| **Mail-merge templates** | Built by end users themselves, with a built-in field picker toolbar |
| **Spell check** | No deployment drama, no external dictionaries to manage |
| **Tables** | A full visual table editor users can drive without calling support |
| **Images** | Arrive clean, whether pasted, dragged, or inserted from a dialog |
| **A full editor API** | Content, selection, formatting, and file operations, all drivable from your code |
| **Toolbar customization** | Hide, add, and rewire buttons to match your application |
| **A multilingual UI** | Editor chrome in your users' language |
| **A CSS style builder** | Consistent formatting without hand-written CSS |
| **Source view** | WYSIWYG plus raw HTML, for the rare power user who wants it |

## Trial and licensing

The control runs a free 14-day trial with no license key required, which is exactly what every
sample here does, so there is nothing to obtain before you evaluate it.

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

> [!IMPORTANT]
> A misplaced key does not throw an error, it silently leaves the application in trial mode.
>
> - `LicenseKey` is static, so one assignment covers every editor in the process. Never set it
>   per form or per instance.
> - Set it before the first editor is constructed. Assigning it later leaves editors that
>   already exist in trial mode.
> - Source code license customers who build the editor from the purchased source do not set
>   `LicenseKey` at all. That build is licensed automatically.

Your key is on your account at [members.spicelogic.com](https://members.spicelogic.com). Full
details, including what changes at the end of the trial, are in
[how to license the WinForms HTML editor](https://www.spicelogic.com/docs/WinHTMLEditorControl/StartUp/how-to-license-winforms-html-editor-153).

## Links

| | |
| :-- | :-- |
| Product page | https://www.spicelogic.com/Products/NET-WinForms-HTML-Editor-Control-8 |
| Documentation | https://www.spicelogic.com/docs/WinHTMLEditorControl |
| MCP server | `https://mcp.spicelogic.com/html-editor/winforms` |
| NuGet package | https://www.nuget.org/packages/SpiceLogic.HtmlEditor.WinForms/ |
| WPF version of this control | https://www.spicelogic.com/Products/WPF-HTML-Editor-Control-17 |
| WPF samples repo | https://github.com/spicelogic/wpf-html-editor-control-samples |
