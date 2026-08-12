using SpiceLogic.HtmlEditor.Abstractions;
using SpiceLogic.HtmlEditor.WinForms;
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
/// </summary>
public class MainForm : Form
{
    private readonly WinFormHtmlEditor _editor = new() { Dock = DockStyle.Fill };

    private readonly ContextMenuStrip _contextMenu = new();
    private readonly ToolStripMenuItem _imagePropertiesItem;
    private readonly ToolStripMenuItem _linkPropertiesItem;
    private readonly ToolStripMenuItem _cellPropertiesItem;
    private readonly ToolStripMenuItem _tableMenu;
    private readonly ToolStripMenuItem _mergeCellsItem;
    private readonly ToolStripMenuItem _youTubeItem;
    private readonly ToolStripSeparator _tableSeparator = new();
    private readonly ToolStripMenuItem _cutItem;
    private readonly ToolStripMenuItem _copyItem;
    private readonly ToolStripMenuItem _deleteItem;

    public MainForm()
    {
        Text = "SpiceLogic WinForms HTML editor - custom context menu";
        Width = 1000;
        Height = 700;

        // No license key set, so the editor runs in trial mode. See the licensing docs linked in the README.

        Controls.Add(_editor);

        _imagePropertiesItem = new ToolStripMenuItem("Image properties", LoadIcon("picture2.png"),
            (_, e) => _editor.ToolbarItemOverrider.OnImageButtonClicked(this, e));
        _linkPropertiesItem = new ToolStripMenuItem("Link properties", LoadIcon("hyperlink.gif"),
            (_, e) => _editor.ToolbarItemOverrider.OnHyperLinkButtonClicked(this, e));
        _cellPropertiesItem = new ToolStripMenuItem("Cell properties", LoadIcon("tableCell.png"),
            (_, e) => _editor.ToolbarItemOverrider.OnTableCellEditingClicked(this, e));

        _mergeCellsItem = new ToolStripMenuItem("Merge cells", LoadIcon("mergeCell.png"),
            (_, _) => _editor.Content.TableAuthoringService.MergeSelectedCells());

        _tableMenu = new ToolStripMenuItem("Table", LoadIcon("tableInGeneral.png"));
        _tableMenu.DropDownItems.AddRange(
        [
            new ToolStripMenuItem("Table properties", LoadIcon("table.gif"),
                (_, e) => _editor.ToolbarItemOverrider.OnTableModifyButtonClicked(this, e)),
            new ToolStripMenuItem("Insert row (before)", LoadIcon("tblInsertRow.png"),
                (_, _) => _editor.Content.TableAuthoringService.InsertRow(InsertPositions.Before)),
            new ToolStripMenuItem("Insert row (after)", LoadIcon("tblInsertRow.png"),
                (_, _) => _editor.Content.TableAuthoringService.InsertRow(InsertPositions.After)),
            new ToolStripMenuItem("Delete row", LoadIcon("tblDeleteRow.png"),
                (_, _) => _editor.Content.TableAuthoringService.DeleteRow()),
            new ToolStripMenuItem("Insert column (before)", LoadIcon("tblInsertColumn.png"),
                (_, _) => _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.Before)),
            new ToolStripMenuItem("Insert column (after)", LoadIcon("tblInsertColumn.png"),
                (_, _) => _editor.Content.TableAuthoringService.InsertColumn(InsertPositions.After)),
            new ToolStripMenuItem("Delete column", LoadIcon("tblDeleteColumn.png"),
                (_, _) => _editor.Content.TableAuthoringService.DeleteColumn()),
            _mergeCellsItem
        ]);

        _youTubeItem = new ToolStripMenuItem("YouTube video properties", LoadIcon("youTube.png"),
            (_, e) => _editor.ToolbarItemOverrider.OnYouTubeVideoInsertButtonClicked(this, e));

        var alignmentMenu = new ToolStripMenuItem("Alignment");
        alignmentMenu.DropDownItems.AddRange(
        [
            new ToolStripMenuItem("Left", LoadIcon("align_left.gif"), (_, _) => _editor.Formatting.AlignLeft()),
            new ToolStripMenuItem("Center", LoadIcon("align_center.gif"), (_, _) => _editor.Formatting.AlignCenter()),
            new ToolStripMenuItem("Right", LoadIcon("align_right.gif"), (_, _) => _editor.Formatting.AlignRight()),
            new ToolStripMenuItem("Remove alignment", LoadIcon("removeAlign.png"), (_, _) => _editor.Formatting.RemoveAlignment())
        ]);

        _cutItem = new ToolStripMenuItem("Cut", LoadIcon("btnCut.png"), (_, _) => _editor.Editor.Cut());
        _copyItem = new ToolStripMenuItem("Copy", LoadIcon("btnCopy.png"), (_, _) => _editor.Editor.Copy());
        var pasteItem = new ToolStripMenuItem("Paste", LoadIcon("btnPaste.png"), (_, _) => _editor.Editor.Paste());
        _deleteItem = new ToolStripMenuItem("Delete", LoadIcon("Delete.png"), (_, _) => _editor.Editor.Delete());
        var selectAllItem = new ToolStripMenuItem("Select all", LoadIcon("selectAll.png"), (_, _) => _editor.Selection.SelectAll());

        _contextMenu.Items.AddRange(
        [
            _imagePropertiesItem,
            _linkPropertiesItem,
            _cellPropertiesItem,
            _tableMenu,
            _youTubeItem,
            _tableSeparator,
            alignmentMenu,
            new ToolStripSeparator(),
            _cutItem,
            _copyItem,
            pasteItem,
            _deleteItem,
            new ToolStripSeparator(),
            selectAllItem
        ]);

        _editor.EditorContextMenuStrip = _contextMenu;
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
