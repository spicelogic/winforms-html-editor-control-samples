# 10 - Custom context menu

Replaces the editor's built-in right-click menu with a custom `ContextMenuStrip` built
from the same actions the toolbar exposes (cut/copy/delete, alignment, table editing,
image/link/cell properties), and uses the `ContextMenuShowing` event to enable, disable,
and show or hide individual items based on what is under the cursor - for example the
table submenu only appears when the caret is inside a table.

Key API members used: `EditorContextMenuStrip`, `ContextMenuShowing`, `ToolbarItemOverrider`,
`StateQuery`, `Content.TableAuthoringService`, `Formatting`, `Editor`, `Selection`.

A VB.NET version of this same sample sits alongside in `10-CustomContextMenu-VB`.

## Run it

```
dotnet run --project 10-CustomContextMenu-CS
```
