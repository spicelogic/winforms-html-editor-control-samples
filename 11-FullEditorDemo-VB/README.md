# 11 - Full editor demo (VB.NET)

A full tour of the control rather than the smallest possible host: the complete default
toolbar against a real starter document, high-DPI toolbar scaling, live spell checking
backed by a persistent per-user dictionary, and document-level styling via the header
style block.

Key API members used: `WinFormHtmlEditor`, `BodyHtml`, `RefreshHighDpiScaling`, `Options`,
`SpellCheckOptions`, `HeaderStyleContentElementID` / `HeaderStyleContent`.

## Run it

```
dotnet run --project 11-FullEditorDemo-VB
```

This is the VB.NET counterpart to the C# `11-FullEditorDemo` sample alongside it.
