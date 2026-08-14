using SpiceLogic.HtmlEditor.WinForms;

namespace LocalizationSample
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
            this._topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._languageLabel = new System.Windows.Forms.Label();
            this._languageCombo = new System.Windows.Forms.ComboBox();
            this._currentLanguageLabel = new System.Windows.Forms.Label();
            this._spellCheckLabel = new System.Windows.Forms.Label();
            this._spellCheckCombo = new System.Windows.Forms.ComboBox();
            this._jsonOverrideCheckBox = new System.Windows.Forms.CheckBox();
            this._topPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 44);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 716);
            this._editor.TabIndex = 1;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _topPanel
            //
            this._topPanel.AutoSize = true;
            this._topPanel.Controls.Add(this._languageLabel);
            this._topPanel.Controls.Add(this._languageCombo);
            this._topPanel.Controls.Add(this._currentLanguageLabel);
            this._topPanel.Controls.Add(this._spellCheckLabel);
            this._topPanel.Controls.Add(this._spellCheckCombo);
            this._topPanel.Controls.Add(this._jsonOverrideCheckBox);
            this._topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._topPanel.Location = new System.Drawing.Point(0, 0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this._topPanel.Size = new System.Drawing.Size(1000, 44);
            this._topPanel.TabIndex = 0;
            this._topPanel.WrapContents = false;
            //
            // _languageLabel
            //
            this._languageLabel.AutoSize = true;
            this._languageLabel.Location = new System.Drawing.Point(10, 16);
            this._languageLabel.Margin = new System.Windows.Forms.Padding(0, 6, 5, 0);
            this._languageLabel.Name = "_languageLabel";
            this._languageLabel.Size = new System.Drawing.Size(84, 13);
            this._languageLabel.TabIndex = 0;
            this._languageLabel.Text = "Editor language:";
            //
            // _languageCombo
            //
            this._languageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._languageCombo.Location = new System.Drawing.Point(99, 13);
            this._languageCombo.Margin = new System.Windows.Forms.Padding(0, 3, 15, 0);
            this._languageCombo.Name = "_languageCombo";
            this._languageCombo.Size = new System.Drawing.Size(200, 21);
            this._languageCombo.TabIndex = 1;
            this._languageCombo.SelectedIndexChanged += new System.EventHandler(this.OnLanguageChanged);
            //
            // _currentLanguageLabel
            //
            this._currentLanguageLabel.AutoSize = true;
            this._currentLanguageLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this._currentLanguageLabel.Location = new System.Drawing.Point(314, 16);
            this._currentLanguageLabel.Margin = new System.Windows.Forms.Padding(0, 6, 15, 0);
            this._currentLanguageLabel.Name = "_currentLanguageLabel";
            this._currentLanguageLabel.Size = new System.Drawing.Size(0, 13);
            this._currentLanguageLabel.TabIndex = 2;
            //
            // _spellCheckLabel
            //
            this._spellCheckLabel.AutoSize = true;
            this._spellCheckLabel.Location = new System.Drawing.Point(329, 16);
            this._spellCheckLabel.Margin = new System.Windows.Forms.Padding(0, 6, 5, 0);
            this._spellCheckLabel.Name = "_spellCheckLabel";
            this._spellCheckLabel.Size = new System.Drawing.Size(115, 13);
            this._spellCheckLabel.TabIndex = 3;
            this._spellCheckLabel.Text = "Spell check language:";
            //
            // _spellCheckCombo
            //
            this._spellCheckCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._spellCheckCombo.Location = new System.Drawing.Point(449, 13);
            this._spellCheckCombo.Margin = new System.Windows.Forms.Padding(0, 3, 15, 0);
            this._spellCheckCombo.Name = "_spellCheckCombo";
            this._spellCheckCombo.Size = new System.Drawing.Size(200, 21);
            this._spellCheckCombo.TabIndex = 4;
            this._spellCheckCombo.SelectedIndexChanged += new System.EventHandler(this.OnSpellCheckLanguageChanged);
            //
            // _jsonOverrideCheckBox
            //
            this._jsonOverrideCheckBox.AutoSize = true;
            this._jsonOverrideCheckBox.Location = new System.Drawing.Point(664, 16);
            this._jsonOverrideCheckBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this._jsonOverrideCheckBox.Name = "_jsonOverrideCheckBox";
            this._jsonOverrideCheckBox.Size = new System.Drawing.Size(168, 17);
            this._jsonOverrideCheckBox.TabIndex = 5;
            this._jsonOverrideCheckBox.Text = "Enable JSON override (Polish)";
            this._jsonOverrideCheckBox.UseVisualStyleBackColor = true;
            this._jsonOverrideCheckBox.CheckedChanged += new System.EventHandler(this.OnJsonOverrideChanged);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._topPanel);
            this.Name = "MainForm";
            this.Text = "SpiceLogic WinForms HTML editor - localization";
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.FlowLayoutPanel _topPanel;
        private System.Windows.Forms.Label _languageLabel;
        private System.Windows.Forms.ComboBox _languageCombo;
        private System.Windows.Forms.Label _currentLanguageLabel;
        private System.Windows.Forms.Label _spellCheckLabel;
        private System.Windows.Forms.ComboBox _spellCheckCombo;
        private System.Windows.Forms.CheckBox _jsonOverrideCheckBox;
    }
}
