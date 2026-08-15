# 11 - Full editor demo

A full tour of the control rather than the smallest possible host (see 01-Quickstart-CS): the
complete default toolbar against a real starter document, high-DPI toolbar scaling, live
spell checking backed by a persistent per-user dictionary, and document-level styling via
the header style block.

Key API members used: `WinFormHtmlEditor`, `BodyHtml`, `RefreshHighDpiScaling`, `Options`,
`SpellCheckOptions`, `HeaderStyleContentElementID` / `HeaderStyleContent`.


A VB.NET version sits alongside in `11-FullEditorDemo-VB`.

## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
