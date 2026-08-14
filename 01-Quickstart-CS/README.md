# 01 - Quickstart

The smallest possible host for the SpiceLogic WinForms HTML editor control. It docks the
editor to fill the form, sets a starting `BodyHtml` value, and shows a live character
count of the current HTML in a status strip as you type.

Key API members used: `WinFormHtmlEditor`, `BodyHtml`, `HtmlChanged`.

A VB.NET version of this same walkthrough sits alongside in `01-Quickstart-VB`.

## Run it

```
dotnet run --project 01-Quickstart-CS
```

## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
