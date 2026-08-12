using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs
{
    public partial class ImageDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDialog));
            this.txtToolTip = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.chkInsertLocalBase64 = new System.Windows.Forms.CheckBox();
            this.grpToolTip = new System.Windows.Forms.GroupBox();
            this.grpURL = new System.Windows.Forms.GroupBox();
            this.pnlUrl = new System.Windows.Forms.Panel();
            this.lnkImportToBaseFolder = new System.Windows.Forms.LinkLabel();
            this.lnkBrowseWD = new System.Windows.Forms.LinkLabel();
            this.rdoWorkingDirFile = new System.Windows.Forms.RadioButton();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.rdoLocalFile = new System.Windows.Forms.RadioButton();
            this.rdInternetURL = new System.Windows.Forms.RadioButton();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.chkBorderColor = new System.Windows.Forms.CheckBox();
            this.chkBorderStyle = new System.Windows.Forms.CheckBox();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.lnkBgColor = new System.Windows.Forms.LinkLabel();
            this.chkBorderThickness = new System.Windows.Forms.CheckBox();
            this.chkAlignment = new System.Windows.Forms.CheckBox();
            this.txtBgColor = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkLockAspectRatio = new System.Windows.Forms.CheckBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.chkWidth = new System.Windows.Forms.CheckBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpToolTip.SuspendLayout();
            this.grpURL.SuspendLayout();
            this.pnlUrl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToolTip
            // 
            this.txtToolTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToolTip.Location = new System.Drawing.Point(3, 16);
            this.txtToolTip.Name = "txtToolTip";
            this.txtToolTip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToolTip.Size = new System.Drawing.Size(734, 20);
            this.txtToolTip.TabIndex = 0;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFile.Enabled = false;
            this.btnBrowseFile.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseFile.AutoSize = true;
            this.btnBrowseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseFile.Location = new System.Drawing.Point(22, 110);
            this.btnBrowseFile.MinimumSize = new System.Drawing.Size(90, 24);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnBrowseFile.Size = new System.Drawing.Size(90, 24);
            this.btnBrowseFile.TabIndex = 53;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnBrowseFile, "Browse File");
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // chkInsertLocalBase64
            // 
            this.chkInsertLocalBase64.AutoSize = true;
            this.chkInsertLocalBase64.Enabled = false;
            this.chkInsertLocalBase64.Location = new System.Drawing.Point(5, 145);
            this.chkInsertLocalBase64.Name = "chkInsertLocalBase64";
            this.chkInsertLocalBase64.Size = new System.Drawing.Size(160, 17);
            this.chkInsertLocalBase64.TabIndex = 60;
            this.chkInsertLocalBase64.Text = "Insert local image as base64";
            this.chkInsertLocalBase64.UseVisualStyleBackColor = true;
            this.chkInsertLocalBase64.VisibleChanged += new System.EventHandler(this.chkInsertLocalBase64_VisibleChanged);
            // 
            // grpToolTip
            // 
            this.grpToolTip.Controls.Add(this.txtToolTip);
            this.grpToolTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpToolTip.Location = new System.Drawing.Point(0, 195);
            this.grpToolTip.Name = "grpToolTip";
            this.grpToolTip.Size = new System.Drawing.Size(740, 42);
            this.grpToolTip.TabIndex = 42;
            this.grpToolTip.TabStop = false;
            this.grpToolTip.Text = "ToolTip";
            // 
            // grpURL
            // 
            this.grpURL.Controls.Add(this.pnlUrl);
            this.grpURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpURL.Location = new System.Drawing.Point(0, 0);
            this.grpURL.Name = "grpURL";
            this.grpURL.Size = new System.Drawing.Size(740, 195);
            this.grpURL.TabIndex = 40;
            this.grpURL.TabStop = false;
            this.grpURL.Text = "Picture Source URL";
            // 
            // pnlUrl
            // 
            this.pnlUrl.Controls.Add(this.chkInsertLocalBase64);
            this.pnlUrl.Controls.Add(this.lnkImportToBaseFolder);
            this.pnlUrl.Controls.Add(this.lnkBrowseWD);
            this.pnlUrl.Controls.Add(this.btnBrowseFile);
            this.pnlUrl.Controls.Add(this.rdoWorkingDirFile);
            this.pnlUrl.Controls.Add(this.chkOverwrite);
            this.pnlUrl.Controls.Add(this.rdoLocalFile);
            this.pnlUrl.Controls.Add(this.rdInternetURL);
            this.pnlUrl.Controls.Add(this.txtURL);
            this.pnlUrl.Location = new System.Drawing.Point(8, 17);
            this.pnlUrl.Name = "pnlUrl";
            this.pnlUrl.Size = new System.Drawing.Size(729, 168);
            this.pnlUrl.TabIndex = 52;
            this.pnlUrl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUrl_MouseMove);
            // 
            // lnkImportToBaseFolder
            // 
            this.lnkImportToBaseFolder.AutoSize = true;
            this.lnkImportToBaseFolder.Enabled = false;
            this.lnkImportToBaseFolder.Location = new System.Drawing.Point(370, 115);
            this.lnkImportToBaseFolder.Name = "lnkImportToBaseFolder";
            this.lnkImportToBaseFolder.Size = new System.Drawing.Size(146, 13);
            this.lnkImportToBaseFolder.TabIndex = 59;
            this.lnkImportToBaseFolder.TabStop = true;
            this.lnkImportToBaseFolder.Text = "Import a file to the base folder";
            this.lnkImportToBaseFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImportToBaseFolder_LinkClicked);
            // 
            // lnkBrowseWD
            // 
            this.lnkBrowseWD.AutoSize = true;
            this.lnkBrowseWD.Enabled = false;
            this.lnkBrowseWD.Location = new System.Drawing.Point(370, 81);
            this.lnkBrowseWD.Name = "lnkBrowseWD";
            this.lnkBrowseWD.Size = new System.Drawing.Size(82, 13);
            this.lnkBrowseWD.TabIndex = 58;
            this.lnkBrowseWD.TabStop = true;
            this.lnkBrowseWD.Text = "Browse for a file";
            this.lnkBrowseWD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrowseWD_LinkClicked);
            // 
            // rdoWorkingDirFile
            // 
            this.rdoWorkingDirFile.AutoSize = true;
            this.rdoWorkingDirFile.Location = new System.Drawing.Point(370, 56);
            this.rdoWorkingDirFile.Name = "rdoWorkingDirFile";
            this.rdoWorkingDirFile.Size = new System.Drawing.Size(119, 17);
            this.rdoWorkingDirFile.TabIndex = 56;
            this.rdoWorkingDirFile.Text = "Relative to Base Url";
            this.rdoWorkingDirFile.UseVisualStyleBackColor = true;
            this.rdoWorkingDirFile.CheckedChanged += new System.EventHandler(this.rdoWorkingDirFile_CheckedChanged);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Enabled = false;
            this.chkOverwrite.Location = new System.Drawing.Point(560, 115);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(71, 17);
            this.chkOverwrite.TabIndex = 57;
            this.chkOverwrite.Text = "Overwrite";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // rdoLocalFile
            // 
            this.rdoLocalFile.AutoSize = true;
            this.rdoLocalFile.Location = new System.Drawing.Point(4, 81);
            this.rdoLocalFile.Name = "rdoLocalFile";
            this.rdoLocalFile.Size = new System.Drawing.Size(159, 17);
            this.rdoLocalFile.TabIndex = 55;
            this.rdoLocalFile.Text = "Local File with absolute path";
            this.rdoLocalFile.UseVisualStyleBackColor = true;
            this.rdoLocalFile.CheckedChanged += new System.EventHandler(this.rdoLocalFile_CheckedChanged);
            // 
            // rdInternetURL
            // 
            this.rdInternetURL.AutoSize = true;
            this.rdInternetURL.Checked = true;
            this.rdInternetURL.Location = new System.Drawing.Point(3, 56);
            this.rdInternetURL.Name = "rdInternetURL";
            this.rdInternetURL.Size = new System.Drawing.Size(86, 17);
            this.rdInternetURL.TabIndex = 54;
            this.rdInternetURL.TabStop = true;
            this.rdInternetURL.Text = "Internet URL";
            this.rdInternetURL.UseVisualStyleBackColor = true;
            this.rdInternetURL.CheckedChanged += new System.EventHandler(this.rdInternetURL_CheckedChanged);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Window;
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtURL.Location = new System.Drawing.Point(0, 0);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtURL.Size = new System.Drawing.Size(729, 50);
            this.txtURL.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 42);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternative Text";
            // 
            // txtAlt
            // 
            this.txtAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlt.Location = new System.Drawing.Point(3, 16);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAlt.Size = new System.Drawing.Size(734, 20);
            this.txtAlt.TabIndex = 0;
            // 
            // cmbAlign
            // 
            this.cmbAlign.Enabled = false;
            this.cmbAlign.FormattingEnabled = true;
            this.cmbAlign.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Bottom",
            "Middle",
            "Top"});
            this.cmbAlign.Location = new System.Drawing.Point(82, 18);
            this.cmbAlign.Name = "cmbAlign";
            this.cmbAlign.Size = new System.Drawing.Size(88, 21);
            this.cmbAlign.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBorderStyle);
            this.groupBox2.Controls.Add(this.chkBorderColor);
            this.groupBox2.Controls.Add(this.chkBorderStyle);
            this.groupBox2.Controls.Add(this.txtBorder);
            this.groupBox2.Controls.Add(this.lnkBgColor);
            this.groupBox2.Controls.Add(this.chkBorderThickness);
            this.groupBox2.Controls.Add(this.chkAlignment);
            this.groupBox2.Controls.Add(this.txtBgColor);
            this.groupBox2.Controls.Add(this.cmbAlign);
            this.groupBox2.Location = new System.Drawing.Point(3, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 70);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layout";
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.Enabled = false;
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "Dotted",
            "Dashed",
            "Solid",
            "Double",
            "Groove",
            "Ridge",
            "Inset",
            "Outset"});
            this.cmbBorderStyle.Location = new System.Drawing.Point(370, 42);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(82, 21);
            this.cmbBorderStyle.TabIndex = 51;
            // 
            // chkBorderColor
            // 
            this.chkBorderColor.AutoSize = true;
            this.chkBorderColor.Location = new System.Drawing.Point(245, 20);
            this.chkBorderColor.Name = "chkBorderColor";
            this.chkBorderColor.Size = new System.Drawing.Size(15, 14);
            this.chkBorderColor.TabIndex = 48;
            this.chkBorderColor.UseVisualStyleBackColor = true;
            this.chkBorderColor.CheckedChanged += new System.EventHandler(this.chkBorderColor_CheckedChanged);
            // 
            // chkBorderStyle
            // 
            this.chkBorderStyle.AutoSize = true;
            this.chkBorderStyle.Location = new System.Drawing.Point(245, 44);
            this.chkBorderStyle.Name = "chkBorderStyle";
            this.chkBorderStyle.Size = new System.Drawing.Size(83, 17);
            this.chkBorderStyle.TabIndex = 47;
            this.chkBorderStyle.Text = "Border Style";
            this.chkBorderStyle.UseVisualStyleBackColor = true;
            this.chkBorderStyle.CheckedChanged += new System.EventHandler(this.chkBorderStyle_CheckedChanged);
            // 
            // txtBorder
            // 
            this.txtBorder.Enabled = false;
            this.txtBorder.Location = new System.Drawing.Point(113, 42);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(57, 20);
            this.txtBorder.TabIndex = 45;
            // 
            // lnkBgColor
            // 
            this.lnkBgColor.AutoSize = true;
            this.lnkBgColor.Enabled = false;
            this.lnkBgColor.Location = new System.Drawing.Point(260, 21);
            this.lnkBgColor.Name = "lnkBgColor";
            this.lnkBgColor.Size = new System.Drawing.Size(65, 13);
            this.lnkBgColor.TabIndex = 50;
            this.lnkBgColor.TabStop = true;
            this.lnkBgColor.Text = "Border Color";
            this.lnkBgColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBgColor_LinkClicked);
            // 
            // chkBorderThickness
            // 
            this.chkBorderThickness.AutoSize = true;
            this.chkBorderThickness.Location = new System.Drawing.Point(7, 44);
            this.chkBorderThickness.Name = "chkBorderThickness";
            this.chkBorderThickness.Size = new System.Drawing.Size(109, 17);
            this.chkBorderThickness.TabIndex = 1;
            this.chkBorderThickness.Text = "Border Thickness";
            this.chkBorderThickness.UseVisualStyleBackColor = true;
            this.chkBorderThickness.CheckedChanged += new System.EventHandler(this.chkBorderThickness_CheckedChanged);
            // 
            // chkAlignment
            // 
            this.chkAlignment.AutoSize = true;
            this.chkAlignment.Location = new System.Drawing.Point(7, 20);
            this.chkAlignment.Name = "chkAlignment";
            this.chkAlignment.Size = new System.Drawing.Size(72, 17);
            this.chkAlignment.TabIndex = 0;
            this.chkAlignment.Text = "Alignment";
            this.chkAlignment.UseVisualStyleBackColor = true;
            this.chkAlignment.CheckedChanged += new System.EventHandler(this.chkAlignment_CheckedChanged);
            // 
            // txtBgColor
            // 
            this.txtBgColor.BackColor = System.Drawing.Color.White;
            this.txtBgColor.Enabled = false;
            this.txtBgColor.Location = new System.Drawing.Point(370, 17);
            this.txtBgColor.Name = "txtBgColor";
            this.txtBgColor.ReadOnly = true;
            this.txtBgColor.Size = new System.Drawing.Size(95, 20);
            this.txtBgColor.TabIndex = 49;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkLockAspectRatio);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.chkWidth);
            this.groupBox4.Controls.Add(this.chkHeight);
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Location = new System.Drawing.Point(479, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 95);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Size";
            // 
            // chkLockAspectRatio
            // 
            this.chkLockAspectRatio.AutoSize = true;
            this.chkLockAspectRatio.Checked = true;
            this.chkLockAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLockAspectRatio.Location = new System.Drawing.Point(6, 19);
            this.chkLockAspectRatio.Name = "chkLockAspectRatio";
            this.chkLockAspectRatio.Size = new System.Drawing.Size(114, 17);
            this.chkLockAspectRatio.TabIndex = 48;
            this.chkLockAspectRatio.Text = "Lock Aspect Ratio";
            this.chkLockAspectRatio.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            this.txtHeight.Enabled = false;
            this.txtHeight.Location = new System.Drawing.Point(110, 42);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(57, 20);
            this.txtHeight.TabIndex = 46;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Enabled = false;
            this.txtWidth.Location = new System.Drawing.Point(110, 67);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(57, 20);
            this.txtWidth.TabIndex = 47;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // chkWidth
            // 
            this.chkWidth.AutoSize = true;
            this.chkWidth.Location = new System.Drawing.Point(6, 67);
            this.chkWidth.Name = "chkWidth";
            this.chkWidth.Size = new System.Drawing.Size(54, 17);
            this.chkWidth.TabIndex = 2;
            this.chkWidth.Text = "Width";
            this.chkWidth.UseVisualStyleBackColor = true;
            this.chkWidth.CheckedChanged += new System.EventHandler(this.chkWidth_CheckedChanged);
            // 
            // chkHeight
            // 
            this.chkHeight.AutoSize = true;
            this.chkHeight.Location = new System.Drawing.Point(6, 44);
            this.chkHeight.Name = "chkHeight";
            this.chkHeight.Size = new System.Drawing.Size(57, 17);
            this.chkHeight.TabIndex = 1;
            this.chkHeight.Text = "Height";
            this.chkHeight.UseVisualStyleBackColor = true;
            this.chkHeight.CheckedChanged += new System.EventHandler(this.chkHeight_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(647, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(557, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 23);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpToolTip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpURL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Insert Dialog";
            this.Load += new System.EventHandler(this.ImageInsertDialog_Load);
            this.grpToolTip.ResumeLayout(false);
            this.grpToolTip.PerformLayout();
            this.grpURL.ResumeLayout(false);
            this.pnlUrl.ResumeLayout(false);
            this.pnlUrl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip1;
        private TextBox txtToolTip;
        private GroupBox grpToolTip;
        private Button btnCancel;
        private Button btnOK;
        private GroupBox grpURL;
        private GroupBox groupBox1;
        private TextBox txtAlt;
        private ComboBox cmbAlign;
        private GroupBox groupBox2;
        private TextBox txtBorder;
        private CheckBox chkBorderThickness;
        private CheckBox chkAlignment;
        private GroupBox groupBox4;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private CheckBox chkWidth;
        private CheckBox chkHeight;
        private CheckBox chkBorderStyle;
        private ComboBox cmbBorderStyle;
        private CheckBox chkBorderColor;
        private LinkLabel lnkBgColor;
        private TextBox txtBgColor;
        private CheckBox chkLockAspectRatio;
        private Panel pnlUrl;
        private LinkLabel lnkImportToBaseFolder;
        private LinkLabel lnkBrowseWD;
        private Button btnBrowseFile;
        private RadioButton rdoWorkingDirFile;
        private CheckBox chkOverwrite;
        private RadioButton rdoLocalFile;
        private RadioButton rdInternetURL;
        private TextBox txtURL;
        private CheckBox chkInsertLocalBase64;
    }
}