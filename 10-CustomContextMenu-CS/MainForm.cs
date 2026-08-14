using SpiceLogic.HtmlEditor.Abstractions;
using SpiceLogic.HtmlEditor.WinForms.Models.BOs.EditorEventArgs;
using mshtml;

namespace CustomContextMenu;

/// <summary>
/// Replaces the editor's built-in right-click menu with a custom
/// <see cref="ContextMenuStrip"/> built from the same actions the toolbar exposes
/// (cut/copy/delete, alignment, table editing, image/link/cell properties), and uses the
/// <c>ContextMenuShowing</c> event to enable, disable, and show or hide individual items
/// based on what is under the cursor - for example the table submenu only appears when
/// the caret is inside a table.
///
/// The menu structure and the editor's EditorContextMenuStrip assignment live in the
/// designer; open MainForm.cs in the Visual Studio designer and select the context menu
/// in the component tray to edit the items. This file wires up what each item does and
/// loads the icons from the Resources folder at runtime.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        AssignIcons();
        WireUpCommands();

        _editor.ContextMenuShowing += OnContextMenuShowing;

        _editor.BodyHtml = @"
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
               become enabled in the context menu.</p>";
    }

    /// <summary>
    /// The icons ship as loose files in the Resources folder rather than embedded resources,
    /// so they are assigned here instead of being serialized into the designer's .resx.
    /// </summary>
    private void AssignIcons()
    {
        _imagePropertiesItem.Image = LoadIcon("picture2.png");
        _linkPropertiesItem.Image = LoadIcon("hyperlink.gif");
        _cellPropertiesItem.Image = LoadIcon("tableCell.png");
        _tableMenu.Image = LoadIcon("tableInGeneral.png");
        _tablePropertiesItem.Image = LoadIcon("table.gif");
        _insertRowBeforeItem.Image = LoadIcon("tblInsertRow.png");
        _insertRowAfterItem.Image = LoadIcon("tblInsertRow.png");
        _deleteRowItem.Image = LoadIcon("tblDeleteRow.png");
        _insertColumnBeforeItem.Image = LoadIcon("tblInsertColumn.png");
        _insertColumnAfterItem.Image = LoadIcon("tblInsertColumn.png");
        _deleteColumnItem.Image = LoadIcon("tblDeleteColumn.png");
        _mergeCellsItem.Image = LoadIcon("mergeCell.png");
        _youTubeItem.Image = LoadIcon("youTube.png");
        _alignLeftItem.Image = LoadIcon("align_left.gif");
        _alignCenterItem.Image = LoadIcon("align_center.gif");
        _alignRightItem.Image = LoadIcon("align_right.gif");
        _removeAlignmentItem.Image = LoadIcon("removeAlign.png");
        _cutItem.Image = LoadIcon("btnCut.png");
        _copyItem.Image = LoadIcon("btnCopy.png");
        _pasteItem.Image = LoadIcon("btnPaste.png");
        _deleteItem.Image = LoadIcon("Delete.png");
        _selectAllItem.Image = LoadIcon("selectAll.png");
    }

    /// <summary>
    /// Points each menu item at the editor service that performs the action. The dialog
    /// items reuse the toolbar's own handlers, so a right-click opens exactly the same
    /// dialog the toolbar button would.
    /// </summary>
    private void WireUpCommands()
    {
        _imagePropertiesItem.Click += (_, e) => _editor.ToolbarItemOverrider.OnImageButtonClicked(this, e);
        _linkPropertiesItem.Click += (_, e) => _editor.ToolbarItemOverrider.OnHyperLinkButtonClicked(this, e);
        _cellPropertiesItem.Click += (_, e) => _editor.ToolbarItemOverrider.OnTableCellEditingClicked(this, e);
        _youTubeItem.Click += (_, e) => _editor.ToolbarItemOverrider.OnYouTubeVideoInsertButtonClicked(this, e);
        _tablePropertiesItem.Click += (_, e) => _editor.ToolbarItemOverrider.OnTableModifyButtonClicked(this, e);

        _insertRowBeforeItem.Click += (_, _) => _editor.Content.TableAuthoringService.InsertRow(InsertPositions.Before);
        _insertRowAfterItem.Click += (_, _) => _editor.Content.TableAuthoringService.InsertRow(InsertPositions.After);
        _deleteRowItem.Click += (_, _) => _editor.Content.TableAuthoringService.DeleteRow();
        _insertColumnBeforeItem.Click += (_, _) => _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.Before);
        _insertColumnAfterItem.Click += (_, _) => _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.After);
        _deleteColumnItem.Click += (_, _) => _editor.Content.TableAuthoringService.DeleteColumn();
        _mergeCellsItem.Click += (_, _) => _editor.Content.TableAuthoringService.MergeSelectedCells();

        _alignLeftItem.Click += (_, _) => _editor.Formatting.AlignLeft();
        _alignCenterItem.Click += (_, _) => _editor.Formatting.AlignCenter();
        _alignRightItem.Click += (_, _) => _editor.Formatting.AlignRight();
        _removeAlignmentItem.Click += (_, _) => _editor.Formatting.RemoveAlignment();

        _cutItem.Click += (_, _) => _editor.Editor.Cut();
        _copyItem.Click += (_, _) => _editor.Editor.Copy();
        _pasteItem.Click += (_, _) => _editor.Editor.Paste();
        _deleteItem.Click += (_, _) => _editor.Editor.Delete();
        _selectAllItem.Click += (_, _) => _editor.Selection.SelectAll();
    }

    private static Image? LoadIcon(string fileName)
    {
        var path = Path.Combine(Application.StartupPath, "Resources", fileName);
        return File.Exists(path) ? Image.FromFile(path) : null;
    }

    private void OnContextMenuShowing(object? sender, ContextMenuShowingEventArgs e)
    {
        _deleteItem.Enabled = _editor.StateQuery.CanDelete();
        _copyItem.Enabled = _editor.StateQuery.CanCopy();
        _cutItem.Enabled = _editor.StateQuery.CanCut();

        _youTubeItem.Visible = _editor.StateQuery.IsYouTubeVideo();

        var isImage = _editor.StateQuery.IsImage();
        var isLink = _editor.StateQuery.IsActiveOrAncestorElementHyperLink();

        // An image wrapped in its own <a> tag (the whole link is just that image) is both an
        // image and a link at once, so check both properties instead of picking one.
        IHTMLElement activeElement = _editor.StateQuery.GetActiveHtmlElement();
        if (isImage
            && activeElement.parentElement?.tagName?.ToLower() == "a"
            && activeElement.parentElement.innerHTML == activeElement.outerHTML)
        {
            _imagePropertiesItem.Checked = true;
            _linkPropertiesItem.Checked = true;
        }
        else
        {
            _linkPropertiesItem.Checked = isLink;
            _imagePropertiesItem.Checked = isImage;
        }

        var isTable = _editor.StateQuery.IsTable();
        var isTableCell = _editor.StateQuery.IsTableCell();

        _tableSeparator.Visible = isTable || isTableCell || _editor.StateQuery.IsHyperLink();
        _tableMenu.Visible = isTable || isTableCell;
        _cellPropertiesItem.Visible = isTableCell;
        _mergeCellsItem.Enabled = _editor.StateQuery.CanMergeTableCells();
    }
}
