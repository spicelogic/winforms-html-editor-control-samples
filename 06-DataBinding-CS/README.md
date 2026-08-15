# 06 - Data binding

Shows how to bind the WinForms HTML editor's content to a business object through a standard
`BindingSource`, the same way you would bind any other WinForms control. Two scenarios are
included: binding `BodyHtml` (just the body fragment) and binding `DocumentHtml` (the full
document, including head and body) to the `History` field of a small `Student` list. A
`BindingNavigator` lets you move between records and watch the editor content follow, and a
"Save data" button writes your edits back to `sample-students.xml`.

Key API members used: `WinFormHtmlEditor`, `BodyHtml`, `DocumentHtml`,
`Options.DefaultHtmlType`, `DataBindings`.

Because the editor does not raise property-change notifications for `BodyHtml` or
`DocumentHtml`, a binding writes back to the data source on validation (moving to another
record, the control losing focus, and so on) rather than on every keystroke. For per-keystroke
updates, handle the editor's `HtmlChanged` event instead.

A VB.NET version of this sample sits alongside it in `06-DataBinding-VB`.


## Building this with an AI assistant?

> [!TIP]
> Point your assistant at our MCP server and it can read the real API for this
> control instead of guessing at member names:
> `https://mcp.spicelogic.com/html-editor/winforms`
>
> ```bash
> claude mcp add --transport http spicelogic-winforms https://mcp.spicelogic.com/html-editor/winforms
> ```
