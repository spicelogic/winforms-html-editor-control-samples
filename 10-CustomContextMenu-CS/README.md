# 10 - Custom context menu

Replaces the editor's built-in right-click menu with a custom `ContextMenuStrip` built
from the same actions the toolbar exposes (cut/copy/delete, alignment, table editing,
image/link/cell properties), and uses the `ContextMenuShowing` event to enable, disable,
and show or hide individual items based on what is under the cursor - for example the
table submenu only appears when the caret is inside a table.

Key API members used: `EditorContextMenuStrip`, `ContextMenuShowing`, `ToolbarItemOverrider`,
`StateQuery`, `Content.TableAuthoringService`, `Formatting`, `Editor`, `Selection`.

A VB.NET version of this same sample sits alongside in `10-CustomContextMenu-VB`.


## Keep the default menu

Use `ContextMenuItems` to change only selected built-in commands. Configure these properties after InitializeComponent.

```csharp
editor.ContextMenuItems.ViewSource.Visible = false;
editor.ContextMenuItems.Paste.Enabled = false;
```

```vb
editor.ContextMenuItems.ViewSource.Visible = False
editor.ContextMenuItems.Paste.Enabled = False
```

Use `Text` and `Image` for persistent caption and icon overrides. Use each reference's `Item` and `DefaultContextMenu.Items` to reorder existing items or add native commands. Built-in command handlers remain attached. Setting `Visible` or `Enabled` back to true restores selection-based behavior; it does not force unavailable commands enabled. `ContextMenuShowing` runs before display.

## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
