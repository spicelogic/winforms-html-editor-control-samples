using SpiceLogic.HtmlEditor.WinForms;

namespace LoadAndSaveHtml
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
            this._editor = new WinFormHtmlEditor();
            this._optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._bodyHtmlOption = new System.Windows.Forms.RadioButton();
            this._documentHtmlOption = new System.Windows.Forms.RadioButton();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._openItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this._optionsPanel.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 56);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 668);
            this._editor.TabIndex = 2;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _optionsPanel
            //
            this._optionsPanel.Controls.Add(this._bodyHtmlOption);
            this._optionsPanel.Controls.Add(this._documentHtmlOption);
            this._optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._optionsPanel.Location = new System.Drawing.Point(0, 24);
            this._optionsPanel.Name = "_optionsPanel";
            this._optionsPanel.Size = new System.Drawing.Size(1000, 32);
            this._optionsPanel.TabIndex = 1;
            //
            // _bodyHtmlOption
            //
            this._bodyHtmlOption.AutoSize = true;
            this._bodyHtmlOption.Checked = true;
            this._bodyHtmlOption.Location = new System.Drawing.Point(3, 3);
            this._bodyHtmlOption.Name = "_bodyHtmlOption";
            this._bodyHtmlOption.Size = new System.Drawing.Size(186, 17);
            this._bodyHtmlOption.TabIndex = 0;
            this._bodyHtmlOption.TabStop = true;
            this._bodyHtmlOption.Text = "Use BodyHtml (inner content only)";
            //
            // _documentHtmlOption
            //
            this._documentHtmlOption.AutoSize = true;
            this._documentHtmlOption.Location = new System.Drawing.Point(195, 3);
            this._documentHtmlOption.Name = "_documentHtmlOption";
            this._documentHtmlOption.Size = new System.Drawing.Size(191, 17);
            this._documentHtmlOption.TabIndex = 1;
            this._documentHtmlOption.Text = "Use DocumentHtml (full document)";
            //
            // _menuStrip
            //
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenu});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1000, 24);
            this._menuStrip.TabIndex = 0;
            //
            // _fileMenu
            //
            this._fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openItem,
            this._saveItem});
            this._fileMenu.Name = "_fileMenu";
            this._fileMenu.Size = new System.Drawing.Size(37, 20);
            this._fileMenu.Text = "File";
            //
            // _openItem
            //
            this._openItem.Name = "_openItem";
            this._openItem.Size = new System.Drawing.Size(126, 22);
            this._openItem.Text = "Open...";
            this._openItem.Click += new System.EventHandler(this.OnOpen);
            //
            // _saveItem
            //
            this._saveItem.Name = "_saveItem";
            this._saveItem.Size = new System.Drawing.Size(126, 22);
            this._saveItem.Text = "Save as...";
            this._saveItem.Click += new System.EventHandler(this.OnSave);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 724);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._optionsPanel);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - load and save HTML";
            this._optionsPanel.ResumeLayout(false);
            this._optionsPanel.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.FlowLayoutPanel _optionsPanel;
        private System.Windows.Forms.RadioButton _bodyHtmlOption;
        private System.Windows.Forms.RadioButton _documentHtmlOption;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileMenu;
        private System.Windows.Forms.ToolStripMenuItem _openItem;
        private System.Windows.Forms.ToolStripMenuItem _saveItem;
    }
}
