# 11 - Full editor demo

A full tour of the control rather than the smallest possible host (see 01-Quickstart): the
complete default toolbar against a real starter document, high-DPI toolbar scaling, live
spell checking backed by a persistent per-user dictionary, and document-level styling via
the header style block.

Key API members used: `WinFormHtmlEditor`, `BodyHtml`, `RefreshHighDpiScaling`, `Options`,
`SpellCheckOptions`, `HeaderStyleContentElementID` / `HeaderStyleContent`.

## Run it

```
dotnet run --project 11-FullEditorDemo
```

A VB.NET version sits alongside in `11-FullEditorDemo-VB`.
