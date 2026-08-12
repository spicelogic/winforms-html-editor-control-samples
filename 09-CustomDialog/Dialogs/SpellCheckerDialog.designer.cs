using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs
{
    partial class SpellCheckerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellCheckerDialog));
            this.suggestionList = new System.Windows.Forms.ListBox();
            this.statusPaneWord = new System.Windows.Forms.StatusStrip();
            this.statusPaneCount = new System.Windows.Forms.StatusStrip();
            this.statusPaneIndex = new System.Windows.Forms.StatusStrip();
            this.btnAddToDictionary = new System.Windows.Forms.Button();
            this.richTxtDocument = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSuggessions = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnIgnoreAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.messageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReplacementWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionList
            // 
            this.suggestionList.Location = new System.Drawing.Point(10, 203);
            this.suggestionList.Name = "suggestionList";
            this.suggestionList.Size = new System.Drawing.Size(478, 121);
            this.suggestionList.TabIndex = 18;
            this.suggestionList.SelectedIndexChanged += new System.EventHandler(this.suggestionList_SelectedIndexChanged);
            this.suggestionList.DoubleClick += new System.EventHandler(this.btnReplace_Click);
            // 
            // statusPaneWord
            // 
            this.statusPaneWord.AutoSize = true;
            this.statusPaneWord.Name = "statusPaneWord";
            this.statusPaneWord.Width = 270;
            // 
            // statusPaneCount
            // 
            this.statusPaneCount.Name = "statusPaneCount";
            this.statusPaneCount.Text = "Word: 0 of 0";
            // 
            // statusPaneIndex
            // 
            this.statusPaneIndex.Name = "statusPaneIndex";
            this.statusPaneIndex.Text = "Index: 0";
            this.statusPaneIndex.Width = 80;
            // 
            // btnAddToDictionary
            // 
            this.btnAddToDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToDictionary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddToDictionary.AutoSize = true;
            this.btnAddToDictionary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddToDictionary.Location = new System.Drawing.Point(498, 97);
            this.btnAddToDictionary.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnAddToDictionary.Name = "btnAddToDictionary";
            this.btnAddToDictionary.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddToDictionary.Size = new System.Drawing.Size(140, 23);
            this.btnAddToDictionary.TabIndex = 21;
            this.btnAddToDictionary.Text = "&Add to Dictionary";
            this.btnAddToDictionary.Click += new System.EventHandler(this.btnAddtoDictionary_Click);
            // 
            // richTxtDocument
            // 
            this.richTxtDocument.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtDocument.DetectUrls = false;
            this.richTxtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtDocument.Location = new System.Drawing.Point(0, 0);
            this.richTxtDocument.Name = "richTxtDocument";
            this.richTxtDocument.ReadOnly = true;
            this.richTxtDocument.Size = new System.Drawing.Size(476, 113);
            this.richTxtDocument.TabIndex = 1;
            this.richTxtDocument.TabStop = false;
            this.richTxtDocument.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTxtDocument);
            this.panel1.Location = new System.Drawing.Point(11, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 115);
            this.panel1.TabIndex = 26;
            // 
            // lblSuggessions
            // 
            this.lblSuggessions.AutoSize = true;
            this.lblSuggessions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSuggessions.Location = new System.Drawing.Point(8, 183);
            this.lblSuggessions.Name = "lblSuggessions";
            this.lblSuggessions.Size = new System.Drawing.Size(74, 13);
            this.lblSuggessions.TabIndex = 17;
            this.lblSuggessions.Text = "Replace &With:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(498, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceAll.Enabled = false;
            this.btnReplaceAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReplaceAll.AutoSize = true;
            this.btnReplaceAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReplaceAll.Location = new System.Drawing.Point(498, 203);
            this.btnReplaceAll.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnReplaceAll.Size = new System.Drawing.Size(140, 23);
            this.btnReplaceAll.TabIndex = 23;
            this.btnReplaceAll.Text = "Replace A&ll";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnIgnoreAll
            // 
            this.btnIgnoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnoreAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgnoreAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIgnoreAll.AutoSize = true;
            this.btnIgnoreAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIgnoreAll.Location = new System.Drawing.Point(498, 72);
            this.btnIgnoreAll.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnIgnoreAll.Name = "btnIgnoreAll";
            this.btnIgnoreAll.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnIgnoreAll.Size = new System.Drawing.Size(140, 23);
            this.btnIgnoreAll.TabIndex = 20;
            this.btnIgnoreAll.Text = "I&gnore All";
            this.btnIgnoreAll.Click += new System.EventHandler(this.btnIgnoreAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.Enabled = false;
            this.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReplace.AutoSize = true;
            this.btnReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReplace.Location = new System.Drawing.Point(498, 178);
            this.btnReplace.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnReplace.Size = new System.Drawing.Size(140, 23);
            this.btnReplace.TabIndex = 22;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgnore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIgnore.AutoSize = true;
            this.btnIgnore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIgnore.Location = new System.Drawing.Point(498, 47);
            this.btnIgnore.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnIgnore.Size = new System.Drawing.Size(140, 23);
            this.btnIgnore.TabIndex = 19;
            this.btnIgnore.Text = "&Ignore Once";
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(498, 122);
            this.btnDelete.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelete.Size = new System.Drawing.Size(140, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripStatusLabel,
            this.wordCountToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // messageToolStripStatusLabel
            // 
            this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
            this.messageToolStripStatusLabel.Size = new System.Drawing.Size(386, 17);
            this.messageToolStripStatusLabel.Spring = true;
            this.messageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wordCountToolStripStatusLabel
            // 
            this.wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel";
            this.wordCountToolStripStatusLabel.Size = new System.Drawing.Size(83, 17);
            this.wordCountToolStripStatusLabel.Text = "Word 0 from 0";
            this.wordCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wordStatusLabel
            // 
            this.wordStatusLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordStatusLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.wordStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.wordStatusLabel.Name = "wordStatusLabel";
            this.wordStatusLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.wordStatusLabel.Size = new System.Drawing.Size(660, 31);
            this.wordStatusLabel.TabIndex = 29;
            this.wordStatusLabel.Text = "Misspelled word: Maaango";
            this.wordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 2);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // txtReplacementWord
            // 
            this.txtReplacementWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplacementWord.Location = new System.Drawing.Point(110, 179);
            this.txtReplacementWord.Name = "txtReplacementWord";
            this.txtReplacementWord.Size = new System.Drawing.Size(378, 21);
            this.txtReplacementWord.TabIndex = 31;
            this.txtReplacementWord.TextChanged += new System.EventHandler(this.txtReplaceWord_TextChanged);
            // 
            // SpellCheckerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(660, 358);
            this.Controls.Add(this.txtReplacementWord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wordStatusLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.suggestionList);
            this.Controls.Add(this.btnAddToDictionary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSuggessions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnIgnoreAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnIgnore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpellCheckerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell Check";
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox suggestionList;
        private StatusStrip statusPaneWord;
        private StatusStrip statusPaneCount;
        private StatusStrip statusPaneIndex;
        private Button btnAddToDictionary;
        private RichTextBox richTxtDocument;
        private Panel panel1;
        private Label lblSuggessions;
        private Button btnCancel;
        private Button btnReplaceAll;
        private Button btnIgnoreAll;
        private Button btnReplace;
        private Button btnIgnore;
        private Button btnDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel messageToolStripStatusLabel;
        private ToolStripStatusLabel wordCountToolStripStatusLabel;
        private Label wordStatusLabel;
        private GroupBox groupBox1;
        private TextBox txtReplacementWord;
    }
}