using SpiceLogic.HtmlEditor.WinForms;

namespace ToolbarCustomization
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
            this._tabs = new System.Windows.Forms.TabControl();
            this._buildTab = new System.Windows.Forms.TabPage();
            this._customToolbarEditor = new WinFormHtmlEditor();
            this._customStrip = new System.Windows.Forms.ToolStrip();
            this._overrideTab = new System.Windows.Forms.TabPage();
            this._overrideEditor = new WinFormHtmlEditor();
            this._tabs.SuspendLayout();
            this._buildTab.SuspendLayout();
            this._overrideTab.SuspendLayout();
            this.SuspendLayout();
            //
            // _tabs
            //
            this._tabs.Controls.Add(this._buildTab);
            this._tabs.Controls.Add(this._overrideTab);
            this._tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabs.Location = new System.Drawing.Point(0, 0);
            this._tabs.Name = "_tabs";
            this._tabs.SelectedIndex = 0;
            this._tabs.Size = new System.Drawing.Size(1000, 724);
            this._tabs.TabIndex = 0;
            //
            // _buildTab
            //
            this._buildTab.Controls.Add(this._customToolbarEditor);
            this._buildTab.Controls.Add(this._customStrip);
            this._buildTab.Location = new System.Drawing.Point(4, 22);
            this._buildTab.Name = "_buildTab";
            this._buildTab.Size = new System.Drawing.Size(992, 698);
            this._buildTab.TabIndex = 0;
            this._buildTab.Text = "Build a custom toolbar";
            this._buildTab.UseVisualStyleBackColor = true;
            //
            // _customToolbarEditor
            //
            this._customToolbarEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customToolbarEditor.EditorContextMenuStrip = null;
            this._customToolbarEditor.Location = new System.Drawing.Point(0, 25);
            this._customToolbarEditor.Name = "_customToolbarEditor";
            this._customToolbarEditor.Size = new System.Drawing.Size(992, 673);
            this._customToolbarEditor.TabIndex = 1;
            this._customToolbarEditor.ToolbarContextMenuStrip = null;
            //
            // _customStrip
            //
            this._customStrip.Location = new System.Drawing.Point(0, 0);
            this._customStrip.Name = "_customStrip";
            this._customStrip.Size = new System.Drawing.Size(992, 25);
            this._customStrip.TabIndex = 0;
            //
            // _overrideTab
            //
            this._overrideTab.Controls.Add(this._overrideEditor);
            this._overrideTab.Location = new System.Drawing.Point(4, 22);
            this._overrideTab.Name = "_overrideTab";
            this._overrideTab.Size = new System.Drawing.Size(992, 698);
            this._overrideTab.TabIndex = 1;
            this._overrideTab.Text = "Customize the built-in toolbars";
            this._overrideTab.UseVisualStyleBackColor = true;
            //
            // _overrideEditor
            //
            this._overrideEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._overrideEditor.EditorContextMenuStrip = null;
            this._overrideEditor.Location = new System.Drawing.Point(0, 0);
            this._overrideEditor.Name = "_overrideEditor";
            this._overrideEditor.Size = new System.Drawing.Size(992, 698);
            this._overrideEditor.TabIndex = 0;
            this._overrideEditor.ToolbarContextMenuStrip = null;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 724);
            this.Controls.Add(this._tabs);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - toolbar customization";
            this.Load += new System.EventHandler(this.OnLoad);
            this._tabs.ResumeLayout(false);
            this._buildTab.ResumeLayout(false);
            this._buildTab.PerformLayout();
            this._overrideTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl _tabs;
        private System.Windows.Forms.TabPage _buildTab;
        private WinFormHtmlEditor _customToolbarEditor;
        private System.Windows.Forms.ToolStrip _customStrip;
        private System.Windows.Forms.TabPage _overrideTab;
        private WinFormHtmlEditor _overrideEditor;
    }
}
