# 02 - Load and save HTML

Shows a menu strip with Open and Save commands, and demonstrates the difference between
`BodyHtml` (inner content only, what you would store in a database column) and
`DocumentHtml` (the complete document, including `<html>`/`<head>`, suitable for a
standalone file). A radio button switches which property Open/Save uses so you can see
the difference in the saved file.

Key API members used: `BodyHtml`, `DocumentHtml`, `DocumentTitle`, together with plain
`OpenFileDialog` / `SaveFileDialog` and `File.ReadAllText` / `File.WriteAllText`.

## Run it

```
dotnet run --project 02-LoadAndSaveHtml-CS
```

A VB.NET version of this sample sits alongside in `02-LoadAndSaveHtml-VB`.

## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
