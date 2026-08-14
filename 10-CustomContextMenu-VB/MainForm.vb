Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports SpiceLogic.HtmlEditor.Abstractions
Imports SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs
Imports mshtml

''' <summary>
''' Replaces the editor's built-in right-click menu with a custom ContextMenuStrip built
''' from the same actions the toolbar exposes (cut/copy/delete, alignment, table editing,
''' image/link/cell properties), and uses the ContextMenuShowing event to enable, disable,
''' and show or hide individual items based on what is under the cursor - for example the
''' table submenu only appears when the caret is inside a table.
'''
''' The menu structure and the editor's EditorContextMenuStrip assignment live in the
''' designer; open MainForm.vb in the Visual Studio designer and select the context menu
''' in the component tray to edit the items. This file wires up what each item does and
''' loads the icons from the Resources folder at runtime.
''' </summary>
Partial Public Class MainForm
    Inherits Form

    Public Sub New()
        InitializeComponent()

        ' No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        AssignIcons()
        WireUpCommands()

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

    ''' <summary>
    ''' The icons ship as loose files in the Resources folder rather than embedded resources,
    ''' so they are assigned here instead of being serialized into the designer's .resx.
    ''' </summary>
    Private Sub AssignIcons()
        _imagePropertiesItem.Image = LoadIcon("picture2.png")
        _linkPropertiesItem.Image = LoadIcon("hyperlink.gif")
        _cellPropertiesItem.Image = LoadIcon("tableCell.png")
        _tableMenu.Image = LoadIcon("tableInGeneral.png")
        _tablePropertiesItem.Image = LoadIcon("table.gif")
        _insertRowBeforeItem.Image = LoadIcon("tblInsertRow.png")
        _insertRowAfterItem.Image = LoadIcon("tblInsertRow.png")
        _deleteRowItem.Image = LoadIcon("tblDeleteRow.png")
        _insertColumnBeforeItem.Image = LoadIcon("tblInsertColumn.png")
        _insertColumnAfterItem.Image = LoadIcon("tblInsertColumn.png")
        _deleteColumnItem.Image = LoadIcon("tblDeleteColumn.png")
        _mergeCellsItem.Image = LoadIcon("mergeCell.png")
        _youTubeItem.Image = LoadIcon("youTube.png")
        _alignLeftItem.Image = LoadIcon("align_left.gif")
        _alignCenterItem.Image = LoadIcon("align_center.gif")
        _alignRightItem.Image = LoadIcon("align_right.gif")
        _removeAlignmentItem.Image = LoadIcon("removeAlign.png")
        _cutItem.Image = LoadIcon("btnCut.png")
        _copyItem.Image = LoadIcon("btnCopy.png")
        _pasteItem.Image = LoadIcon("btnPaste.png")
        _deleteItem.Image = LoadIcon("Delete.png")
        _selectAllItem.Image = LoadIcon("selectAll.png")
    End Sub

    ''' <summary>
    ''' Points each menu item at the editor service that performs the action. The dialog
    ''' items reuse the toolbar's own handlers, so a right-click opens exactly the same
    ''' dialog the toolbar button would.
    ''' </summary>
    Private Sub WireUpCommands()
        AddHandler _imagePropertiesItem.Click, Sub(s, e) _editor.ToolbarItemOverrider.OnImageButtonClicked(Me, e)
        AddHandler _linkPropertiesItem.Click, Sub(s, e) _editor.ToolbarItemOverrider.OnHyperLinkButtonClicked(Me, e)
        AddHandler _cellPropertiesItem.Click, Sub(s, e) _editor.ToolbarItemOverrider.OnTableCellEditingClicked(Me, e)
        AddHandler _youTubeItem.Click, Sub(s, e) _editor.ToolbarItemOverrider.OnYouTubeVideoInsertButtonClicked(Me, e)
        AddHandler _tablePropertiesItem.Click, Sub(s, e) _editor.ToolbarItemOverrider.OnTableModifyButtonClicked(Me, e)

        AddHandler _insertRowBeforeItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.InsertRow(InsertPositions.Before)
        AddHandler _insertRowAfterItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.InsertRow(InsertPositions.After)
        AddHandler _deleteRowItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.DeleteRow()
        AddHandler _insertColumnBeforeItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.Before)
        AddHandler _insertColumnAfterItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.After)
        AddHandler _deleteColumnItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.DeleteColumn()
        AddHandler _mergeCellsItem.Click, Sub(s, e) _editor.Content.TableAuthoringService.MergeSelectedCells()

        AddHandler _alignLeftItem.Click, Sub(s, e) _editor.Formatting.AlignLeft()
        AddHandler _alignCenterItem.Click, Sub(s, e) _editor.Formatting.AlignCenter()
        AddHandler _alignRightItem.Click, Sub(s, e) _editor.Formatting.AlignRight()
        AddHandler _removeAlignmentItem.Click, Sub(s, e) _editor.Formatting.RemoveAlignment()

        AddHandler _cutItem.Click, Sub(s, e) _editor.Editor.Cut()
        AddHandler _copyItem.Click, Sub(s, e) _editor.Editor.Copy()
        AddHandler _pasteItem.Click, Sub(s, e) _editor.Editor.Paste()
        AddHandler _deleteItem.Click, Sub(s, e) _editor.Editor.Delete()
        AddHandler _selectAllItem.Click, Sub(s, e) _editor.Selection.SelectAll()
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
