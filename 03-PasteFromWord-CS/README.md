# 03 - Paste from Word

Handles the `Pasting` event to clean up clipboard HTML from Microsoft Word and Outlook.
When `IsPastingFromMsWord` is true, class/style attributes and Word's own `<o:p>` /
`<w:...>` markup are stripped with a small, documented regex helper
(`WordHtmlCleaner.cs`), then `e.PastingHtml` and `e.IsModified` are set so the cleaned
HTML is what actually lands in the document. A side panel logs a before/after character
count for every paste so the cleanup is visible.

Key API members used: `Pasting`, `PastingHtmlEventArgs` (`PastingHtml`, `IsModified`,
`IsPastingFromMsWord`).

## Run it

```
dotnet run --project 03-PasteFromWord-CS
```

Then copy some formatted text from Word or Outlook and paste it into the editor (Ctrl+V)
to see the cleanup log update.

A VB.NET version of this sample sits alongside in `03-PasteFromWord-VB`.
