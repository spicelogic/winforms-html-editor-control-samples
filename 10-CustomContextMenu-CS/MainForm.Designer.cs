using SpiceLogic.HtmlEditor.WinForms;

namespace CustomContextMenu
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._imagePropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this._linkPropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this._cellPropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._tablePropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this._insertRowBeforeItem = new System.Windows.Forms.ToolStripMenuItem();
            this._insertRowAfterItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteRowItem = new System.Windows.Forms.ToolStripMenuItem();
            this._insertColumnBeforeItem = new System.Windows.Forms.ToolStripMenuItem();
            this._insertColumnAfterItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteColumnItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mergeCellsItem = new System.Windows.Forms.ToolStripMenuItem();
            this._youTubeItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tableSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._alignmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._alignLeftItem = new System.Windows.Forms.ToolStripMenuItem();
            this._alignCenterItem = new System.Windows.Forms.ToolStripMenuItem();
            this._alignRightItem = new System.Windows.Forms.ToolStripMenuItem();
            this._removeAlignmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this._clipboardSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._cutItem = new System.Windows.Forms.ToolStripMenuItem();
            this._copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this._pasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this._selectAllSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._selectAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this._editor = new WinFormHtmlEditor();
            this._contextMenu.SuspendLayout();
            this.SuspendLayout();
            //
            // _contextMenu
            //
            this._contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._imagePropertiesItem,
            this._linkPropertiesItem,
            this._cellPropertiesItem,
            this._tableMenu,
            this._youTubeItem,
            this._tableSeparator,
            this._alignmentMenu,
            this._clipboardSeparator,
            this._cutItem,
            this._copyItem,
            this._pasteItem,
            this._deleteItem,
            this._selectAllSeparator,
            this._selectAllItem});
            this._contextMenu.Name = "_contextMenu";
            this._contextMenu.Size = new System.Drawing.Size(216, 264);
            //
            // _imagePropertiesItem
            //
            this._imagePropertiesItem.Name = "_imagePropertiesItem";
            this._imagePropertiesItem.Size = new System.Drawing.Size(215, 22);
            this._imagePropertiesItem.Text = "Image properties";
            //
            // _linkPropertiesItem
            //
            this._linkPropertiesItem.Name = "_linkPropertiesItem";
            this._linkPropertiesItem.Size = new System.Drawing.Size(215, 22);
            this._linkPropertiesItem.Text = "Link properties";
            //
            // _cellPropertiesItem
            //
            this._cellPropertiesItem.Name = "_cellPropertiesItem";
            this._cellPropertiesItem.Size = new System.Drawing.Size(215, 22);
            this._cellPropertiesItem.Text = "Cell properties";
            //
            // _tableMenu
            //
            this._tableMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tablePropertiesItem,
            this._insertRowBeforeItem,
            this._insertRowAfterItem,
            this._deleteRowItem,
            this._insertColumnBeforeItem,
            this._insertColumnAfterItem,
            this._deleteColumnItem,
            this._mergeCellsItem});
            this._tableMenu.Name = "_tableMenu";
            this._tableMenu.Size = new System.Drawing.Size(215, 22);
            this._tableMenu.Text = "Table";
            //
            // _tablePropertiesItem
            //
            this._tablePropertiesItem.Name = "_tablePropertiesItem";
            this._tablePropertiesItem.Size = new System.Drawing.Size(196, 22);
            this._tablePropertiesItem.Text = "Table properties";
            //
            // _insertRowBeforeItem
            //
            this._insertRowBeforeItem.Name = "_insertRowBeforeItem";
            this._insertRowBeforeItem.Size = new System.Drawing.Size(196, 22);
            this._insertRowBeforeItem.Text = "Insert row (before)";
            //
            // _insertRowAfterItem
            //
            this._insertRowAfterItem.Name = "_insertRowAfterItem";
            this._insertRowAfterItem.Size = new System.Drawing.Size(196, 22);
            this._insertRowAfterItem.Text = "Insert row (after)";
            //
            // _deleteRowItem
            //
            this._deleteRowItem.Name = "_deleteRowItem";
            this._deleteRowItem.Size = new System.Drawing.Size(196, 22);
            this._deleteRowItem.Text = "Delete row";
            //
            // _insertColumnBeforeItem
            //
            this._insertColumnBeforeItem.Name = "_insertColumnBeforeItem";
            this._insertColumnBeforeItem.Size = new System.Drawing.Size(196, 22);
            this._insertColumnBeforeItem.Text = "Insert column (before)";
            //
            // _insertColumnAfterItem
            //
            this._insertColumnAfterItem.Name = "_insertColumnAfterItem";
            this._insertColumnAfterItem.Size = new System.Drawing.Size(196, 22);
            this._insertColumnAfterItem.Text = "Insert column (after)";
            //
            // _deleteColumnItem
            //
            this._deleteColumnItem.Name = "_deleteColumnItem";
            this._deleteColumnItem.Size = new System.Drawing.Size(196, 22);
            this._deleteColumnItem.Text = "Delete column";
            //
            // _mergeCellsItem
            //
            this._mergeCellsItem.Name = "_mergeCellsItem";
            this._mergeCellsItem.Size = new System.Drawing.Size(196, 22);
            this._mergeCellsItem.Text = "Merge cells";
            //
            // _youTubeItem
            //
            this._youTubeItem.Name = "_youTubeItem";
            this._youTubeItem.Size = new System.Drawing.Size(215, 22);
            this._youTubeItem.Text = "YouTube video properties";
            //
            // _tableSeparator
            //
            this._tableSeparator.Name = "_tableSeparator";
            this._tableSeparator.Size = new System.Drawing.Size(212, 6);
            //
            // _alignmentMenu
            //
            this._alignmentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._alignLeftItem,
            this._alignCenterItem,
            this._alignRightItem,
            this._removeAlignmentItem});
            this._alignmentMenu.Name = "_alignmentMenu";
            this._alignmentMenu.Size = new System.Drawing.Size(215, 22);
            this._alignmentMenu.Text = "Alignment";
            //
            // _alignLeftItem
            //
            this._alignLeftItem.Name = "_alignLeftItem";
            this._alignLeftItem.Size = new System.Drawing.Size(180, 22);
            this._alignLeftItem.Text = "Left";
            //
            // _alignCenterItem
            //
            this._alignCenterItem.Name = "_alignCenterItem";
            this._alignCenterItem.Size = new System.Drawing.Size(180, 22);
            this._alignCenterItem.Text = "Center";
            //
            // _alignRightItem
            //
            this._alignRightItem.Name = "_alignRightItem";
            this._alignRightItem.Size = new System.Drawing.Size(180, 22);
            this._alignRightItem.Text = "Right";
            //
            // _removeAlignmentItem
            //
            this._removeAlignmentItem.Name = "_removeAlignmentItem";
            this._removeAlignmentItem.Size = new System.Drawing.Size(180, 22);
            this._removeAlignmentItem.Text = "Remove alignment";
            //
            // _clipboardSeparator
            //
            this._clipboardSeparator.Name = "_clipboardSeparator";
            this._clipboardSeparator.Size = new System.Drawing.Size(212, 6);
            //
            // _cutItem
            //
            this._cutItem.Name = "_cutItem";
            this._cutItem.Size = new System.Drawing.Size(215, 22);
            this._cutItem.Text = "Cut";
            //
            // _copyItem
            //
            this._copyItem.Name = "_copyItem";
            this._copyItem.Size = new System.Drawing.Size(215, 22);
            this._copyItem.Text = "Copy";
            //
            // _pasteItem
            //
            this._pasteItem.Name = "_pasteItem";
            this._pasteItem.Size = new System.Drawing.Size(215, 22);
            this._pasteItem.Text = "Paste";
            //
            // _deleteItem
            //
            this._deleteItem.Name = "_deleteItem";
            this._deleteItem.Size = new System.Drawing.Size(215, 22);
            this._deleteItem.Text = "Delete";
            //
            // _selectAllSeparator
            //
            this._selectAllSeparator.Name = "_selectAllSeparator";
            this._selectAllSeparator.Size = new System.Drawing.Size(212, 6);
            //
            // _selectAllItem
            //
            this._selectAllItem.Name = "_selectAllItem";
            this._selectAllItem.Size = new System.Drawing.Size(215, 22);
            this._selectAllItem.Text = "Select all";
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = this._contextMenu;
            this._editor.Location = new System.Drawing.Point(0, 0);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 700);
            this._editor.TabIndex = 0;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this._editor);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - custom context menu";
            this._contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip _contextMenu;
        private System.Windows.Forms.ToolStripMenuItem _imagePropertiesItem;
        private System.Windows.Forms.ToolStripMenuItem _linkPropertiesItem;
        private System.Windows.Forms.ToolStripMenuItem _cellPropertiesItem;
        private System.Windows.Forms.ToolStripMenuItem _tableMenu;
        private System.Windows.Forms.ToolStripMenuItem _tablePropertiesItem;
        private System.Windows.Forms.ToolStripMenuItem _insertRowBeforeItem;
        private System.Windows.Forms.ToolStripMenuItem _insertRowAfterItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteRowItem;
        private System.Windows.Forms.ToolStripMenuItem _insertColumnBeforeItem;
        private System.Windows.Forms.ToolStripMenuItem _insertColumnAfterItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteColumnItem;
        private System.Windows.Forms.ToolStripMenuItem _mergeCellsItem;
        private System.Windows.Forms.ToolStripMenuItem _youTubeItem;
        private System.Windows.Forms.ToolStripSeparator _tableSeparator;
        private System.Windows.Forms.ToolStripMenuItem _alignmentMenu;
        private System.Windows.Forms.ToolStripMenuItem _alignLeftItem;
        private System.Windows.Forms.ToolStripMenuItem _alignCenterItem;
        private System.Windows.Forms.ToolStripMenuItem _alignRightItem;
        private System.Windows.Forms.ToolStripMenuItem _removeAlignmentItem;
        private System.Windows.Forms.ToolStripSeparator _clipboardSeparator;
        private System.Windows.Forms.ToolStripMenuItem _cutItem;
        private System.Windows.Forms.ToolStripMenuItem _copyItem;
        private System.Windows.Forms.ToolStripMenuItem _pasteItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteItem;
        private System.Windows.Forms.ToolStripSeparator _selectAllSeparator;
        private System.Windows.Forms.ToolStripMenuItem _selectAllItem;
        private WinFormHtmlEditor _editor;
    }
}
