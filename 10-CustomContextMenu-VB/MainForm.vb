Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions
Imports SpiceLogic.HtmlEditor.WinForms
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs
Imports mshtml

''' <summary>
''' Replaces the editor's built-in right-click menu with a custom ContextMenuStrip built
''' from the same actions the toolbar exposes (cut/copy/delete, alignment, table editing,
''' image/link/cell properties), and uses the ContextMenuShowing event to enable, disable,
''' and show or hide individual items based on what is under the cursor - for example the
''' table submenu only appears when the caret is inside a table.
''' </summary>
Public Class MainForm
    Inherits Form

    Private WithEvents _editor As New WinFormHtmlEditor() With {.Dock = DockStyle.Fill}

    Private ReadOnly _contextMenu As New ContextMenuStrip()
    Private ReadOnly _imagePropertiesItem As ToolStripMenuItem
    Private ReadOnly _linkPropertiesItem As ToolStripMenuItem
    Private ReadOnly _cellPropertiesItem As ToolStripMenuItem
    Private ReadOnly _tableMenu As ToolStripMenuItem
    Private ReadOnly _mergeCellsItem As ToolStripMenuItem
    Private ReadOnly _youTubeItem As ToolStripMenuItem
    Private ReadOnly _tableSeparator As New ToolStripSeparator()
    Private ReadOnly _cutItem As ToolStripMenuItem
    Private ReadOnly _copyItem As ToolStripMenuItem
    Private ReadOnly _deleteItem As ToolStripMenuItem

    Public Sub New()
        Text = "SpiceLogic WinForms HTML editor - custom context menu"
        Width = 1000
        Height = 700

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        Controls.Add(_editor)

        _imagePropertiesItem = New ToolStripMenuItem("Image properties", LoadIcon("picture2.png"),
            Sub(s, e) _editor.ToolbarItemOverrider.OnImageButtonClicked(Me, e))
        _linkPropertiesItem = New ToolStripMenuItem("Link properties", LoadIcon("hyperlink.gif"),
            Sub(s, e) _editor.ToolbarItemOverrider.OnHyperLinkButtonClicked(Me, e))
        _cellPropertiesItem = New ToolStripMenuItem("Cell properties", LoadIcon("tableCell.png"),
            Sub(s, e) _editor.ToolbarItemOverrider.OnTableCellEditingClicked(Me, e))

        _mergeCellsItem = New ToolStripMenuItem("Merge cells", LoadIcon("mergeCell.png"),
            Sub(s, e) _editor.Content.TableAuthoringService.MergeSelectedCells())

        _tableMenu = New ToolStripMenuItem("Table", LoadIcon("tableInGeneral.png"))
        _tableMenu.DropDownItems.AddRange(New ToolStripItem() {
            New ToolStripMenuItem("Table properties", LoadIcon("table.gif"),
                Sub(s, e) _editor.ToolbarItemOverrider.OnTableModifyButtonClicked(Me, e)),
            New ToolStripMenuItem("Insert row (before)", LoadIcon("tblInsertRow.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.InsertRow(InsertPositions.Before)),
            New ToolStripMenuItem("Insert row (after)", LoadIcon("tblInsertRow.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.InsertRow(InsertPositions.After)),
            New ToolStripMenuItem("Delete row", LoadIcon("tblDeleteRow.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.DeleteRow()),
            New ToolStripMenuItem("Insert column (before)", LoadIcon("tblInsertColumn.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.Before)),
            New ToolStripMenuItem("Insert column (after)", LoadIcon("tblInsertColumn.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.After)),
            New ToolStripMenuItem("Delete column", LoadIcon("tblDeleteColumn.png"),
                Sub(s, e) _editor.Content.TableAuthoringService.DeleteColumn()),
            _mergeCellsItem
        })

        _youTubeItem = New ToolStripMenuItem("YouTube video properties", LoadIcon("youTube.png"),
            Sub(s, e) _editor.ToolbarItemOverrider.OnYouTubeVideoInsertButtonClicked(Me, e))

        Dim alignmentMenu = New ToolStripMenuItem("Alignment")
        alignmentMenu.DropDownItems.AddRange(New ToolStripItem() {
            New ToolStripMenuItem("Left", LoadIcon("align_left.gif"), Sub(s, e) _editor.Formatting.AlignLeft()),
            New ToolStripMenuItem("Center", LoadIcon("align_center.gif"), Sub(s, e) _editor.Formatting.AlignCenter()),
            New ToolStripMenuItem("Right", LoadIcon("align_right.gif"), Sub(s, e) _editor.Formatting.AlignRight()),
            New ToolStripMenuItem("Remove alignment", LoadIcon("removeAlign.png"), Sub(s, e) _editor.Formatting.RemoveAlignment())
        })

        _cutItem = New ToolStripMenuItem("Cut", LoadIcon("btnCut.png"), Sub(s, e) _editor.Editor.Cut())
        _copyItem = New ToolStripMenuItem("Copy", LoadIcon("btnCopy.png"), Sub(s, e) _editor.Editor.Copy())
        Dim pasteItem = New ToolStripMenuItem("Paste", LoadIcon("btnPaste.png"), Sub(s, e) _editor.Editor.Paste())
        _deleteItem = New ToolStripMenuItem("Delete", LoadIcon("Delete.png"), Sub(s, e) _editor.Editor.Delete())
        Dim selectAllItem = New ToolStripMenuItem("Select all", LoadIcon("selectAll.png"), Sub(s, e) _editor.Selection.SelectAll())

        _contextMenu.Items.AddRange(New ToolStripItem() {
            _imagePropertiesItem,
            _linkPropertiesItem,
            _cellPropertiesItem,
            _tableMenu,
            _youTubeItem,
            _tableSeparator,
            alignmentMenu,
            New ToolStripSeparator(),
            _cutItem,
            _copyItem,
            pasteItem,
            _deleteItem,
            New ToolStripSeparator(),
            selectAllItem
        })

        _editor.EditorContextMenuStrip = _contextMenu

        _editor.BodyHtml = "
            <h3>Right-click to try the custom context menu</h3>
            <p>This editor replaces the built-in right-click menu with a custom one. Right-click
               anywhere to see it. Try right-clicking inside the table below to see table-specific
               options such as Insert Row, Delete Column, and Merge Cells.</p>
            <table border='1' cellpadding='6' cellspacing='0' style='border-collapse:collapse; margin-top:10px;'>
                <tr style='background-color:#4472C4; color:white;'>
                    <th>Product</th><th>Category</th><th>Status</th>
                </tr>
                <tr>
                    <td>HTML editor</td><td>WinForms controls</td><td>Active</td>
                </tr>
                <tr>
                    <td>Data grid</td><td>WinForms controls</td><td>Planning</td>
                </tr>
            </table>
            <p style='margin-top:10px;'>Select some text and right-click to see Cut, Copy, and Delete
               become enabled in the context menu.</p>"
    End Sub

    Private Shared Function LoadIcon(ByVal fileName As String) As Image
        Dim iconPath As String = Path.Combine(Application.StartupPath, "Resources", fileName)
        If File.Exists(iconPath) Then
            Return Image.FromFile(iconPath)
        End If
        Return Nothing
    End Function

    Private Sub OnContextMenuShowing(ByVal sender As Object, ByVal e As ContextMenuShowingEventArgs) Handles _editor.ContextMenuShowing
        _deleteItem.Enabled = _editor.StateQuery.CanDelete()
        _copyItem.Enabled = _editor.StateQuery.CanCopy()
        _cutItem.Enabled = _editor.StateQuery.CanCut()

        _youTubeItem.Visible = _editor.StateQuery.IsYouTubeVideo()

        Dim isImage As Boolean = _editor.StateQuery.IsImage()
        Dim isLink As Boolean = _editor.StateQuery.IsActiveOrAncestorElementHyperLink()

        ' An image wrapped in its own <a> tag (the whole link is just that image) is both an
        ' image and a link at once, so check both properties instead of picking one.
        Dim activeElement As IHTMLElement = _editor.StateQuery.GetActiveHtmlElement()
        If isImage _
            AndAlso activeElement.parentElement IsNot Nothing _
            AndAlso activeElement.parentElement.tagName IsNot Nothing _
            AndAlso activeElement.parentElement.tagName.ToLower() = "a" _
            AndAlso activeElement.parentElement.innerHTML = activeElement.outerHTML Then
            _imagePropertiesItem.Checked = True
            _linkPropertiesItem.Checked = True
        Else
            _linkPropertiesItem.Checked = isLink
            _imagePropertiesItem.Checked = isImage
        End If

        Dim isTable As Boolean = _editor.StateQuery.IsTable()
        Dim isTableCell As Boolean = _editor.StateQuery.IsTableCell()

        _tableSeparator.Visible = isTable OrElse isTableCell OrElse _editor.StateQuery.IsHyperLink()
        _tableMenu.Visible = isTable OrElse isTableCell
        _cellPropertiesItem.Visible = isTableCell
        _mergeCellsItem.Enabled = _editor.StateQuery.CanMergeTableCells()
    End Sub
End Class
