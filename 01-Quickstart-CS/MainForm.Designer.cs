using SpiceLogic.HtmlEditor.WinForms;

namespace Quickstart
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
            this._charCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this._charCountLabel});
            this._statusStrip.Location = new System.Drawing.Point(0, 678);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(1000, 22);
            this._statusStrip.TabIndex = 1;
            //
            // _charCountLabel
            //
            this._charCountLabel.Name = "_charCountLabel";
            this._charCountLabel.Size = new System.Drawing.Size(133, 17);
            this._charCountLabel.Text = "Html length: 0 characters";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._statusStrip);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - quickstart";
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _charCountLabel;
    }
}
