# 05 - Mail merge template

Registers five `PlaceholderField`s (first name, last name, company, invoice number, due
date) on `editor.Content.MailMerge.PlaceholderFields` and turns on the built-in field
picker with `ShowPlaceholderToolbar = true`. A split container shows the editable
template on the left and a read-only second `WinFormHtmlEditor` on the right; the
"Preview merged" button takes the current `BodyHtml`, replaces the tokens with values
from a small in-memory sample record, and shows the merged result in the preview editor.

Key API members used: `Content.MailMerge.PlaceholderFields`, `PlaceholderField`,
`ShowPlaceholderToolbar`, `BodyHtml`, `ChangeReadOnlyMode`.

A VB.NET version of this sample sits alongside in `05-MailMergeTemplate-VB`.


## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
