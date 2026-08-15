# 09 - Custom dialog

Replaces every built-in editor dialog (hyperlink, image, table, table cell, spell
checker, symbol picker, search/replace, YouTube video insert, and the style builder)
with fully custom implementations, wired up on `MainForm_Load` via the `Dialog`
properties. Each replacement dialog implements the corresponding interface (for
example `IImageDialog`, `IHyperlinkDialog`) and lives in the `Dialogs` folder, so you
can use them as a starting point for your own branded dialogs, or study just the one
or two dialogs you actually need to replace.

Key API members used: `Dialog.ImageDialog`, `Dialog.HyperlinkDialog`,
`Dialog.SpellCheckerDialog`, `Dialog.TableCellDialog`, `Dialog.TableDialog`,
`Dialog.SymbolDialog`, `Dialog.SearchDialog`, `Dialog.StyleBuilderDialog`,
`Dialog.YouTubeVideoInsertDialog`, `IImageDialog`, `IHyperlinkDialog`,
`ISpellCheckerDialog`, `ITableCellDialog`, `ITableDialog`, `ISymbolDialog`,
`ISearchDialog`, `IStyleBuilderDialog`, `IYouTubeVideoInsertDialog`.

A VB.NET version of this sample sits alongside in `09-CustomDialog-VB`.


## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
