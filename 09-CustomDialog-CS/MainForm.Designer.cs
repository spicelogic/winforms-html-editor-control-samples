using SpiceLogic.HtmlEditor.WinForms;

namespace CustomDialog
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
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.winFormHtmlEditor1 = new WinFormHtmlEditor();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // descriptionPanel
            //
            this.descriptionPanel.BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionPanel.Controls.Add(this.descriptionLabel2);
            this.descriptionPanel.Controls.Add(this.descriptionLabel1);
            this.descriptionPanel.Controls.Add(this.titleLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(15, 15);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Padding = new System.Windows.Forms.Padding(14);
            this.descriptionPanel.Size = new System.Drawing.Size(1000, 130);
            this.descriptionPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.titleLabel.Location = new System.Drawing.Point(14, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(170, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "What This Demo Shows";
            //
            // descriptionLabel1
            //
            this.descriptionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel1.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.descriptionLabel1.Location = new System.Drawing.Point(14, 40);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(970, 36);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "The HTML Editor has built-in dialogs for images, hyperlinks, tables, spell checking, symbols, search/replace, YouTube videos, and the style builder. You can fully replace any or all of them with your own custom dialog implementations by implementing the corresponding interface (e.g., IImageDialog, IHyperlinkDialog).";
            //
            // descriptionLabel2
            //
            this.descriptionLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.descriptionLabel2.Location = new System.Drawing.Point(14, 82);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(970, 36);
            this.descriptionLabel2.TabIndex = 2;
            this.descriptionLabel2.Text = "Try it: Click the Hyperlink, Image, Table, Spell Checker, or other toolbar buttons to see the custom dialogs in action. Check the Dialogs folder in this project for the full source code of each custom dialog implementation.";
            //
            // winFormHtmlEditor1
            //
            this.winFormHtmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winFormHtmlEditor1.Location = new System.Drawing.Point(15, 145);
            this.winFormHtmlEditor1.Name = "winFormHtmlEditor1";
            this.winFormHtmlEditor1.EditorContextMenuStrip = null;
            this.winFormHtmlEditor1.Size = new System.Drawing.Size(1000, 580);
            this.winFormHtmlEditor1.TabIndex = 1;
            this.winFormHtmlEditor1.ToolbarContextMenuStrip = null;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 740);
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Controls.Add(this.winFormHtmlEditor1);
            this.Controls.Add(this.descriptionPanel);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML Editor - Dialog Customization Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label descriptionLabel2;
        private WinFormHtmlEditor winFormHtmlEditor1;
    }
}
