using SpiceLogic.HtmlEditor.WinForms;

namespace CustomSpellChecker
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
            this._builtInOption = new System.Windows.Forms.RadioButton();
            this._customOption = new System.Windows.Forms.RadioButton();
            this._optionsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 32);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 668);
            this._editor.TabIndex = 1;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _optionsPanel
            //
            this._optionsPanel.Controls.Add(this._builtInOption);
            this._optionsPanel.Controls.Add(this._customOption);
            this._optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._optionsPanel.Location = new System.Drawing.Point(0, 0);
            this._optionsPanel.Name = "_optionsPanel";
            this._optionsPanel.Size = new System.Drawing.Size(1000, 32);
            this._optionsPanel.TabIndex = 0;
            //
            // _builtInOption
            //
            this._builtInOption.AutoSize = true;
            this._builtInOption.Checked = true;
            this._builtInOption.Location = new System.Drawing.Point(3, 3);
            this._builtInOption.Name = "_builtInOption";
            this._builtInOption.Size = new System.Drawing.Size(97, 17);
            this._builtInOption.TabIndex = 0;
            this._builtInOption.TabStop = true;
            this._builtInOption.Text = "Built-in engine";
            this._builtInOption.UseVisualStyleBackColor = true;
            this._builtInOption.CheckedChanged += new System.EventHandler(this.OnEngineChanged);
            //
            // _customOption
            //
            this._customOption.AutoSize = true;
            this._customOption.Location = new System.Drawing.Point(106, 3);
            this._customOption.Name = "_customOption";
            this._customOption.Size = new System.Drawing.Size(134, 17);
            this._customOption.TabIndex = 1;
            this._customOption.Text = "Custom engine (demo)";
            this._customOption.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._optionsPanel);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - custom spell checker";
            this._optionsPanel.ResumeLayout(false);
            this._optionsPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.FlowLayoutPanel _optionsPanel;
        private System.Windows.Forms.RadioButton _builtInOption;
        private System.Windows.Forms.RadioButton _customOption;
    }
}
