# 04 - Toolbar customization

Two tabs covering the full range of toolbar customization. "Build a custom toolbar"
hides the built-in toolbars and moves a chosen subset of built-in buttons, in any
order, onto a `ToolStrip` you own. "Customize the built-in toolbars" keeps the
built-in toolbars but hides individual buttons (both through `ToolbarItemOverrider`
and through direct shortcut properties like `BtnSymbol`), swaps a button icon,
redirects the Save button's click to custom logic, retags a tooltip, and appends
custom buttons that act on the document.

Key API members used: `Toolbar1`, `Toolbar2`, `ToolbarItemOverrider`,
`ToolbarItemOverrider.ToolbarItems`, `ToolbarItemOverrider.SaveButtonClicked`,
`BtnSymbol`, `BtnInsertYouTubeVideo`, `BodyHtml`.

## Run it

```
dotnet run --project 04-ToolbarCustomization-CS
```

A VB.NET version of this sample sits alongside in `04-ToolbarCustomization-VB`.
