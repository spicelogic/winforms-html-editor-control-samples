using SpiceLogic.HtmlEditor.WinForms;

namespace MailMergeTemplate
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
            this._templateEditor = new WinFormHtmlEditor();
            this._previewEditor = new WinFormHtmlEditor();
            this._buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._previewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._buttonPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // _splitContainer
            //
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 40);
            this._splitContainer.Name = "_splitContainer";
            // The template and the preview are stacked rather than side by side, so each
            // editor keeps the full window width and its complete toolbar stays visible.
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // _splitContainer.Panel1
            //
            this._splitContainer.Panel1.Controls.Add(this._templateEditor);
            this._splitContainer.Panel1MinSize = 200;
            //
            // _splitContainer.Panel2
            //
            this._splitContainer.Panel2.Controls.Add(this._previewEditor);
            this._splitContainer.Panel2MinSize = 200;
            this._splitContainer.Size = new System.Drawing.Size(1000, 720);
            this._splitContainer.SplitterDistance = 380;
            this._splitContainer.TabIndex = 1;
            //
            // _templateEditor
            //
            this._templateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._templateEditor.EditorContextMenuStrip = null;
            this._templateEditor.Location = new System.Drawing.Point(0, 0);
            this._templateEditor.Name = "_templateEditor";
            this._templateEditor.Size = new System.Drawing.Size(1000, 380);
            this._templateEditor.TabIndex = 0;
            this._templateEditor.ToolbarContextMenuStrip = null;
            //
            // _previewEditor
            //
            this._previewEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previewEditor.EditorContextMenuStrip = null;
            this._previewEditor.Location = new System.Drawing.Point(0, 0);
            this._previewEditor.Name = "_previewEditor";
            this._previewEditor.Size = new System.Drawing.Size(1000, 336);
            this._previewEditor.TabIndex = 0;
            this._previewEditor.ToolbarContextMenuStrip = null;
            //
            // _buttonPanel
            //
            this._buttonPanel.Controls.Add(this._previewButton);
            this._buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonPanel.Location = new System.Drawing.Point(0, 0);
            this._buttonPanel.Name = "_buttonPanel";
            this._buttonPanel.Padding = new System.Windows.Forms.Padding(6);
            this._buttonPanel.Size = new System.Drawing.Size(1000, 40);
            this._buttonPanel.TabIndex = 0;
            //
            // _previewButton
            //
            this._previewButton.AutoSize = true;
            this._previewButton.Location = new System.Drawing.Point(9, 9);
            this._previewButton.Name = "_previewButton";
            this._previewButton.Size = new System.Drawing.Size(94, 23);
            this._previewButton.TabIndex = 0;
            this._previewButton.Text = "Preview merged";
            this._previewButton.UseVisualStyleBackColor = true;
            this._previewButton.Click += new System.EventHandler(this.OnPreviewMerged);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this._buttonPanel);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - mail merge template";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._buttonPanel.ResumeLayout(false);
            this._buttonPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private WinFormHtmlEditor _templateEditor;
        private WinFormHtmlEditor _previewEditor;
        private System.Windows.Forms.FlowLayoutPanel _buttonPanel;
        private System.Windows.Forms.Button _previewButton;
    }
}
