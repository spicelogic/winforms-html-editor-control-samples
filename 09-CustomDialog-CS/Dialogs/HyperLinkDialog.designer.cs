using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs
{
    public partial class HyperLinkDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            btnCancel = new Button();
            btnOK = new Button();
            grpInnerHtml = new GroupBox();
            txtInnerHtml = new TextBox();
            grpURL = new GroupBox();
            pnlRelativeUrl = new Panel();
            txtURL = new TextBox();
            cmbTarget = new ComboBox();
            rdoWorkingDirFile = new RadioButton();
            chkTargetIncluded = new CheckBox();
            lnkImportToBaseFolder = new LinkLabel();
            btnBrowseFile = new Button();
            lnkBrowseWD = new LinkLabel();
            rdoLocalFile = new RadioButton();
            chkOverwrite = new CheckBox();
            rdInternetURL = new RadioButton();
            lnkCheck = new LinkLabel();
            chkRemoveLink = new CheckBox();
            grpToolTip = new GroupBox();
            txtToolTip = new TextBox();
            toolTip1 = new ToolTip(components);
            grpInnerHtml.SuspendLayout();
            grpURL.SuspendLayout();
            pnlRelativeUrl.SuspendLayout();
            grpToolTip.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.Location = new System.Drawing.Point(1647, 822);
            btnCancel.Margin = new Padding(7, 8, 7, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(210, 64);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Cursor = Cursors.Hand;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnOK.Location = new System.Drawing.Point(1423, 822);
            btnOK.Margin = new Padding(7, 8, 7, 8);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(210, 64);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // grpInnerHtml
            // 
            grpInnerHtml.Controls.Add(txtInnerHtml);
            grpInnerHtml.Dock = DockStyle.Top;
            grpInnerHtml.Location = new System.Drawing.Point(19, 22);
            grpInnerHtml.Margin = new Padding(7, 8, 7, 8);
            grpInnerHtml.Name = "grpInnerHtml";
            grpInnerHtml.Padding = new Padding(7, 8, 7, 8);
            grpInnerHtml.Size = new System.Drawing.Size(1829, 266);
            grpInnerHtml.TabIndex = 6;
            grpInnerHtml.TabStop = false;
            grpInnerHtml.Text = "InnerHtml (or Text)";
            // 
            // txtInnerHtml
            // 
            txtInnerHtml.BackColor = System.Drawing.Color.WhiteSmoke;
            txtInnerHtml.Dock = DockStyle.Fill;
            txtInnerHtml.Location = new System.Drawing.Point(7, 43);
            txtInnerHtml.Margin = new Padding(7, 8, 7, 8);
            txtInnerHtml.Multiline = true;
            txtInnerHtml.Name = "txtInnerHtml";
            txtInnerHtml.ScrollBars = ScrollBars.Both;
            txtInnerHtml.Size = new System.Drawing.Size(1815, 215);
            txtInnerHtml.TabIndex = 0;
            // 
            // grpURL
            // 
            grpURL.Controls.Add(pnlRelativeUrl);
            grpURL.Dock = DockStyle.Top;
            grpURL.Location = new System.Drawing.Point(19, 288);
            grpURL.Margin = new Padding(7, 8, 7, 8);
            grpURL.Name = "grpURL";
            grpURL.Padding = new Padding(7, 8, 7, 8);
            grpURL.Size = new System.Drawing.Size(1829, 371);
            grpURL.TabIndex = 7;
            grpURL.TabStop = false;
            grpURL.Text = "URL";
            // 
            // pnlRelativeUrl
            // 
            pnlRelativeUrl.Controls.Add(txtURL);
            pnlRelativeUrl.Controls.Add(cmbTarget);
            pnlRelativeUrl.Controls.Add(rdoWorkingDirFile);
            pnlRelativeUrl.Controls.Add(chkTargetIncluded);
            pnlRelativeUrl.Controls.Add(lnkImportToBaseFolder);
            pnlRelativeUrl.Controls.Add(btnBrowseFile);
            pnlRelativeUrl.Controls.Add(lnkBrowseWD);
            pnlRelativeUrl.Controls.Add(rdoLocalFile);
            pnlRelativeUrl.Controls.Add(chkOverwrite);
            pnlRelativeUrl.Controls.Add(rdInternetURL);
            pnlRelativeUrl.Location = new System.Drawing.Point(14, 53);
            pnlRelativeUrl.Margin = new Padding(7, 8, 7, 8);
            pnlRelativeUrl.Name = "pnlRelativeUrl";
            pnlRelativeUrl.Size = new System.Drawing.Size(1848, 318);
            pnlRelativeUrl.TabIndex = 41;
            pnlRelativeUrl.MouseMove += pnlRelativeUrl_MouseMove;
            // 
            // txtURL
            // 
            txtURL.BackColor = System.Drawing.Color.WhiteSmoke;
            txtURL.Dock = DockStyle.Top;
            txtURL.Location = new System.Drawing.Point(0, 0);
            txtURL.Margin = new Padding(7, 8, 7, 8);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.ScrollBars = ScrollBars.Both;
            txtURL.Size = new System.Drawing.Size(1848, 131);
            txtURL.TabIndex = 41;
            // 
            // cmbTarget
            // 
            cmbTarget.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbTarget.Enabled = false;
            cmbTarget.FormattingEnabled = true;
            cmbTarget.Items.AddRange(new object[] { "_blank", "_parent", "_search", "_self", "_top" });
            cmbTarget.Location = new System.Drawing.Point(1587, 222);
            cmbTarget.Margin = new Padding(7, 8, 7, 8);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new System.Drawing.Size(228, 44);
            cmbTarget.TabIndex = 38;
            // 
            // rdoWorkingDirFile
            // 
            rdoWorkingDirFile.AutoSize = true;
            rdoWorkingDirFile.Location = new System.Drawing.Point(747, 155);
            rdoWorkingDirFile.Margin = new Padding(7, 8, 7, 8);
            rdoWorkingDirFile.Name = "rdoWorkingDirFile";
            rdoWorkingDirFile.Size = new System.Drawing.Size(266, 40);
            rdoWorkingDirFile.TabIndex = 6;
            rdoWorkingDirFile.Text = "Relative to Base Url";
            rdoWorkingDirFile.UseVisualStyleBackColor = true;
            rdoWorkingDirFile.CheckedChanged += rdoWorkingDirFile_CheckedChanged;
            // 
            // chkTargetIncluded
            // 
            chkTargetIncluded.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkTargetIncluded.AutoSize = true;
            chkTargetIncluded.Location = new System.Drawing.Point(1423, 165);
            chkTargetIncluded.Margin = new Padding(7, 8, 7, 8);
            chkTargetIncluded.Name = "chkTargetIncluded";
            chkTargetIncluded.Size = new System.Drawing.Size(118, 40);
            chkTargetIncluded.TabIndex = 37;
            chkTargetIncluded.Text = "Target";
            chkTargetIncluded.UseVisualStyleBackColor = true;
            chkTargetIncluded.CheckedChanged += chkTargetIncluded_CheckedChanged;
            // 
            // lnkImportToBaseFolder
            // 
            lnkImportToBaseFolder.AutoSize = true;
            lnkImportToBaseFolder.Enabled = false;
            lnkImportToBaseFolder.Location = new System.Drawing.Point(747, 260);
            lnkImportToBaseFolder.Margin = new Padding(7, 0, 7, 0);
            lnkImportToBaseFolder.Name = "lnkImportToBaseFolder";
            lnkImportToBaseFolder.Size = new System.Drawing.Size(363, 36);
            lnkImportToBaseFolder.TabIndex = 40;
            lnkImportToBaseFolder.TabStop = true;
            lnkImportToBaseFolder.Text = "Import a file to the base folder";
            lnkImportToBaseFolder.LinkClicked += lnkImportToBaseFolder_LinkClicked;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.AutoSize = true;
            btnBrowseFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowseFile.Cursor = Cursors.Hand;
            btnBrowseFile.Enabled = false;
            btnBrowseFile.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBrowseFile.Location = new System.Drawing.Point(397, 216);
            btnBrowseFile.Margin = new Padding(7, 8, 7, 8);
            btnBrowseFile.MinimumSize = new System.Drawing.Size(210, 66);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Padding = new Padding(19, 0, 19, 0);
            btnBrowseFile.Size = new System.Drawing.Size(210, 66);
            btnBrowseFile.TabIndex = 3;
            btnBrowseFile.Text = "Browse";
            btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnBrowseFile, "Browse File");
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // lnkBrowseWD
            // 
            lnkBrowseWD.AutoSize = true;
            lnkBrowseWD.Enabled = false;
            lnkBrowseWD.Location = new System.Drawing.Point(747, 210);
            lnkBrowseWD.Margin = new Padding(7, 0, 7, 0);
            lnkBrowseWD.Name = "lnkBrowseWD";
            lnkBrowseWD.Size = new System.Drawing.Size(198, 36);
            lnkBrowseWD.TabIndex = 39;
            lnkBrowseWD.TabStop = true;
            lnkBrowseWD.Text = "Browse for a file";
            lnkBrowseWD.LinkClicked += lnkBrowseWD_LinkClicked;
            // 
            // rdoLocalFile
            // 
            rdoLocalFile.AutoSize = true;
            rdoLocalFile.Location = new System.Drawing.Point(7, 224);
            rdoLocalFile.Margin = new Padding(7, 8, 7, 8);
            rdoLocalFile.Name = "rdoLocalFile";
            rdoLocalFile.Size = new System.Drawing.Size(370, 40);
            rdoLocalFile.TabIndex = 5;
            rdoLocalFile.Text = "Local File with absolute path";
            rdoLocalFile.UseVisualStyleBackColor = true;
            rdoLocalFile.CheckedChanged += rdoLocalFile_CheckedChanged;
            // 
            // chkOverwrite
            // 
            chkOverwrite.AutoSize = true;
            chkOverwrite.Enabled = false;
            chkOverwrite.Location = new System.Drawing.Point(1237, 258);
            chkOverwrite.Margin = new Padding(7, 8, 7, 8);
            chkOverwrite.Name = "chkOverwrite";
            chkOverwrite.Size = new System.Drawing.Size(159, 40);
            chkOverwrite.TabIndex = 8;
            chkOverwrite.Text = "Overwrite";
            chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // rdInternetURL
            // 
            rdInternetURL.AutoSize = true;
            rdInternetURL.Checked = true;
            rdInternetURL.Location = new System.Drawing.Point(7, 155);
            rdInternetURL.Margin = new Padding(7, 8, 7, 8);
            rdInternetURL.Name = "rdInternetURL";
            rdInternetURL.Size = new System.Drawing.Size(191, 40);
            rdInternetURL.TabIndex = 4;
            rdInternetURL.TabStop = true;
            rdInternetURL.Text = "Internet URL";
            rdInternetURL.UseVisualStyleBackColor = true;
            // 
            // lnkCheck
            // 
            lnkCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lnkCheck.AutoSize = true;
            lnkCheck.Cursor = Cursors.Hand;
            lnkCheck.Location = new System.Drawing.Point(275, 835);
            lnkCheck.Margin = new Padding(7, 0, 7, 0);
            lnkCheck.Name = "lnkCheck";
            lnkCheck.Size = new System.Drawing.Size(138, 36);
            lnkCheck.TabIndex = 8;
            lnkCheck.TabStop = true;
            lnkCheck.Text = "Check URL";
            lnkCheck.LinkClicked += lnkCheck_LinkClicked;
            // 
            // chkRemoveLink
            // 
            chkRemoveLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkRemoveLink.AutoSize = true;
            chkRemoveLink.Location = new System.Drawing.Point(7, 840);
            chkRemoveLink.Margin = new Padding(7, 8, 7, 8);
            chkRemoveLink.Name = "chkRemoveLink";
            chkRemoveLink.Size = new System.Drawing.Size(192, 40);
            chkRemoveLink.TabIndex = 9;
            chkRemoveLink.Text = "Remove Link";
            chkRemoveLink.UseVisualStyleBackColor = true;
            // 
            // grpToolTip
            // 
            grpToolTip.Controls.Add(txtToolTip);
            grpToolTip.Dock = DockStyle.Top;
            grpToolTip.Location = new System.Drawing.Point(19, 659);
            grpToolTip.Margin = new Padding(7, 8, 7, 8);
            grpToolTip.Name = "grpToolTip";
            grpToolTip.Padding = new Padding(7, 8, 7, 8);
            grpToolTip.Size = new System.Drawing.Size(1829, 116);
            grpToolTip.TabIndex = 36;
            grpToolTip.TabStop = false;
            grpToolTip.Text = "ToolTip";
            // 
            // txtToolTip
            // 
            txtToolTip.Dock = DockStyle.Fill;
            txtToolTip.Location = new System.Drawing.Point(7, 43);
            txtToolTip.Margin = new Padding(7, 8, 7, 8);
            txtToolTip.Name = "txtToolTip";
            txtToolTip.ScrollBars = ScrollBars.Both;
            txtToolTip.Size = new System.Drawing.Size(1815, 42);
            txtToolTip.TabIndex = 0;
            // 
            // HyperLinkDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1867, 896);
            Controls.Add(grpToolTip);
            Controls.Add(chkRemoveLink);
            Controls.Add(lnkCheck);
            Controls.Add(grpURL);
            Controls.Add(grpInnerHtml);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "HyperLinkDialog";
            Padding = new Padding(19, 22, 19, 22);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hyperlink Editor";
            Load += HyperLinkDialog_Load;
            grpInnerHtml.ResumeLayout(false);
            grpInnerHtml.PerformLayout();
            grpURL.ResumeLayout(false);
            pnlRelativeUrl.ResumeLayout(false);
            pnlRelativeUrl.PerformLayout();
            grpToolTip.ResumeLayout(false);
            grpToolTip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private GroupBox grpInnerHtml;
        private TextBox txtInnerHtml;
        private GroupBox grpURL;
        private LinkLabel lnkCheck;
        private CheckBox chkRemoveLink;
        private ComboBox cmbTarget;
        private GroupBox grpToolTip;
        private TextBox txtToolTip;
        private CheckBox chkTargetIncluded;
        private Button btnBrowseFile;
        private ToolTip toolTip1;
        private RadioButton rdoWorkingDirFile;
        private RadioButton rdoLocalFile;
        private RadioButton rdInternetURL;
        private CheckBox chkOverwrite;
        private LinkLabel lnkBrowseWD;
        private LinkLabel lnkImportToBaseFolder;
        private Panel pnlRelativeUrl;
        private TextBox txtURL;
    }
}