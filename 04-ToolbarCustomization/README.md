# 04 - Toolbar customization

Hides a couple of built-in toolbar buttons (`BtnInsertYouTubeVideo`, `BtnSymbol`) by
setting their `Visible` property to false, and adds a custom `ToolStripButton`
("Insert signature") to `Toolbar2` that inserts a fixed HTML block at the end of
`BodyHtml` when clicked.

Key API members used: `BtnInsertYouTubeVideo`, `BtnSymbol`, `Toolbar2`, `BodyHtml`.

## Run it

```
dotnet run --project 04-ToolbarCustomization
```
