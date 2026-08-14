using SpiceLogic.HtmlEditor.WinForms;

namespace PasteFromWord
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
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._editor = new WinFormHtmlEditor();
            this._logPanel = new System.Windows.Forms.Panel();
            this._log = new System.Windows.Forms.TextBox();
            this._logLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._logPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // _splitContainer
            //
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // The editor is stacked above the log rather than beside it, so the control keeps
            // the full window width and every default toolbar button stays visible.
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // _splitContainer.Panel1
            //
            this._splitContainer.Panel1.Controls.Add(this._editor);
            this._splitContainer.Panel1MinSize = 200;
            //
            // _splitContainer.Panel2
            //
            this._splitContainer.Panel2.Controls.Add(this._logPanel);
            this._splitContainer.Panel2MinSize = 100;
            this._splitContainer.Size = new System.Drawing.Size(1000, 724);
            this._splitContainer.SplitterDistance = 470;
            this._splitContainer.TabIndex = 0;
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 0);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 470);
            this._editor.TabIndex = 0;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _logPanel
            //
            this._logPanel.Controls.Add(this._log);
            this._logPanel.Controls.Add(this._logLabel);
            this._logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logPanel.Location = new System.Drawing.Point(0, 0);
            this._logPanel.Name = "_logPanel";
            this._logPanel.Padding = new System.Windows.Forms.Padding(4);
            this._logPanel.Size = new System.Drawing.Size(1000, 250);
            this._logPanel.TabIndex = 0;
            //
            // _log
            //
            this._log.Dock = System.Windows.Forms.DockStyle.Fill;
            this._log.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 9F);
            this._log.Location = new System.Drawing.Point(4, 24);
            this._log.Multiline = true;
            this._log.Name = "_log";
            this._log.ReadOnly = true;
            this._log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._log.Size = new System.Drawing.Size(992, 222);
            this._log.TabIndex = 1;
            //
            // _logLabel
            //
            this._logLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._logLabel.Location = new System.Drawing.Point(4, 4);
            this._logLabel.Name = "_logLabel";
            this._logLabel.Size = new System.Drawing.Size(992, 20);
            this._logLabel.TabIndex = 0;
            this._logLabel.Text = "Paste log";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 724);
            this.Controls.Add(this._splitContainer);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - paste from Word";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._logPanel.ResumeLayout(false);
            this._logPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.Panel _logPanel;
        private System.Windows.Forms.TextBox _log;
        private System.Windows.Forms.Label _logLabel;
    }
}
