using SpiceLogic.HtmlEditor.WinForms;

namespace FullEditorDemo
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
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._refreshDpiButton = new System.Windows.Forms.ToolStripButton();
            this._dpiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._dpiLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._charCountSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._charCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._spellCheckSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._spellCheckLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 0);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 678);
            this._editor.TabIndex = 0;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _statusStrip
            //
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._refreshDpiButton,
            this._dpiSeparator,
            this._dpiLabel,
            this._charCountSeparator,
            this._charCountLabel,
            this._spellCheckSeparator,
            this._spellCheckLabel});
            this._statusStrip.Location = new System.Drawing.Point(0, 678);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(1000, 22);
            this._statusStrip.TabIndex = 1;
            //
            // _refreshDpiButton
            //
            this._refreshDpiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._refreshDpiButton.Name = "_refreshDpiButton";
            this._refreshDpiButton.Size = new System.Drawing.Size(129, 20);
            this._refreshDpiButton.Text = "Refresh display scaling";
            this._refreshDpiButton.Click += new System.EventHandler(this.OnRefreshDpiClick);
            //
            // _dpiSeparator
            //
            this._dpiSeparator.Name = "_dpiSeparator";
            this._dpiSeparator.Size = new System.Drawing.Size(6, 22);
            //
            // _dpiLabel
            //
            this._dpiLabel.Name = "_dpiLabel";
            this._dpiLabel.Size = new System.Drawing.Size(103, 17);
            this._dpiLabel.Text = "Display scaling: -";
            //
            // _charCountSeparator
            //
            this._charCountSeparator.Name = "_charCountSeparator";
            this._charCountSeparator.Size = new System.Drawing.Size(6, 22);
            //
            // _charCountLabel
            //
            this._charCountLabel.Name = "_charCountLabel";
            this._charCountLabel.Size = new System.Drawing.Size(133, 17);
            this._charCountLabel.Text = "Html length: 0 characters";
            //
            // _spellCheckSeparator
            //
            this._spellCheckSeparator.Name = "_spellCheckSeparator";
            this._spellCheckSeparator.Size = new System.Drawing.Size(6, 22);
            //
            // _spellCheckLabel
            //
            this._spellCheckLabel.Name = "_spellCheckLabel";
            this._spellCheckLabel.Size = new System.Drawing.Size(93, 17);
            this._spellCheckLabel.Text = "Spell check: idle";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._statusStrip);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - full editor demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripButton _refreshDpiButton;
        private System.Windows.Forms.ToolStripSeparator _dpiSeparator;
        private System.Windows.Forms.ToolStripStatusLabel _dpiLabel;
        private System.Windows.Forms.ToolStripSeparator _charCountSeparator;
        private System.Windows.Forms.ToolStripStatusLabel _charCountLabel;
        private System.Windows.Forms.ToolStripSeparator _spellCheckSeparator;
        private System.Windows.Forms.ToolStripStatusLabel _spellCheckLabel;
    }
}
