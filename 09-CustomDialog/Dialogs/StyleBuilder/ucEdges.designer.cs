using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    /// <summary>
    /// Class ucEdges
    /// </summary>
    public partial class ucEdges
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scMarginsPadding = new System.Windows.Forms.SplitContainer();
            this.gbMargins = new System.Windows.Forms.GroupBox();
            this.tbMRight = new System.Windows.Forms.TextBox();
            this.tbMLeft = new System.Windows.Forms.TextBox();
            this.tbMBottom = new System.Windows.Forms.TextBox();
            this.tbMTop = new System.Windows.Forms.TextBox();
            this.lMRight = new System.Windows.Forms.Label();
            this.lMLeft = new System.Windows.Forms.Label();
            this.lMBottom = new System.Windows.Forms.Label();
            this.lMTop = new System.Windows.Forms.Label();
            this.cbMRightType = new System.Windows.Forms.ComboBox();
            this.cbMLeftType = new System.Windows.Forms.ComboBox();
            this.cbMBottomType = new System.Windows.Forms.ComboBox();
            this.cbMTopType = new System.Windows.Forms.ComboBox();
            this.gbPadding = new System.Windows.Forms.GroupBox();
            this.tbPRight = new System.Windows.Forms.TextBox();
            this.tbPLeft = new System.Windows.Forms.TextBox();
            this.tbPBottom = new System.Windows.Forms.TextBox();
            this.tbPTop = new System.Windows.Forms.TextBox();
            this.lPRight = new System.Windows.Forms.Label();
            this.lPLeft = new System.Windows.Forms.Label();
            this.lPBottom = new System.Windows.Forms.Label();
            this.lPTop = new System.Windows.Forms.Label();
            this.cbPRightType = new System.Windows.Forms.ComboBox();
            this.cbPLeftType = new System.Windows.Forms.ComboBox();
            this.cbPBottomType = new System.Windows.Forms.ComboBox();
            this.cbPTopType = new System.Windows.Forms.ComboBox();
            this.scEdges = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbLeft = new System.Windows.Forms.GroupBox();
            this.btLeftColor = new System.Windows.Forms.Button();
            this.tbLeftWidth = new System.Windows.Forms.TextBox();
            this.cbLeftWidthType = new System.Windows.Forms.ComboBox();
            this.lLeftColor = new System.Windows.Forms.Label();
            this.lLeftWidth = new System.Windows.Forms.Label();
            this.lLeftStyle = new System.Windows.Forms.Label();
            this.cbLeftColor = new System.Windows.Forms.ComboBox();
            this.cbLeftWidth = new System.Windows.Forms.ComboBox();
            this.cbLeftStyle = new System.Windows.Forms.ComboBox();
            this.gbTop = new System.Windows.Forms.GroupBox();
            this.btTopColor = new System.Windows.Forms.Button();
            this.tbTopWidth = new System.Windows.Forms.TextBox();
            this.cbTopWidthType = new System.Windows.Forms.ComboBox();
            this.lTopColor = new System.Windows.Forms.Label();
            this.lTopWidth = new System.Windows.Forms.Label();
            this.lTopStyle = new System.Windows.Forms.Label();
            this.cbTopColor = new System.Windows.Forms.ComboBox();
            this.cbTopWidth = new System.Windows.Forms.ComboBox();
            this.cbTopStyle = new System.Windows.Forms.ComboBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbRight = new System.Windows.Forms.GroupBox();
            this.btRightColor = new System.Windows.Forms.Button();
            this.tbRightWidth = new System.Windows.Forms.TextBox();
            this.cbRightWidthType = new System.Windows.Forms.ComboBox();
            this.lRightColor = new System.Windows.Forms.Label();
            this.lRightWidth = new System.Windows.Forms.Label();
            this.lRightStyle = new System.Windows.Forms.Label();
            this.cbRightColor = new System.Windows.Forms.ComboBox();
            this.cbRightWidth = new System.Windows.Forms.ComboBox();
            this.cbRightStyle = new System.Windows.Forms.ComboBox();
            this.gbBottom = new System.Windows.Forms.GroupBox();
            this.btBottomColor = new System.Windows.Forms.Button();
            this.tbBottomWidth = new System.Windows.Forms.TextBox();
            this.cbBottomWidthType = new System.Windows.Forms.ComboBox();
            this.lBottomColor = new System.Windows.Forms.Label();
            this.lBottomWidth = new System.Windows.Forms.Label();
            this.lBottomStyle = new System.Windows.Forms.Label();
            this.cbBottomColor = new System.Windows.Forms.ComboBox();
            this.cbBottomWidth = new System.Windows.Forms.ComboBox();
            this.cbBottomStyle = new System.Windows.Forms.ComboBox();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.scMarginsPadding.Panel1.SuspendLayout();
            this.scMarginsPadding.Panel2.SuspendLayout();
            this.scMarginsPadding.SuspendLayout();
            this.gbMargins.SuspendLayout();
            this.gbPadding.SuspendLayout();
            this.scEdges.Panel1.SuspendLayout();
            this.scEdges.Panel2.SuspendLayout();
            this.scEdges.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbLeft.SuspendLayout();
            this.gbTop.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbRight.SuspendLayout();
            this.gbBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMarginsPadding
            // 
            this.scMarginsPadding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scMarginsPadding.Location = new System.Drawing.Point(3, 3);
            this.scMarginsPadding.Name = "scMarginsPadding";
            // 
            // scMarginsPadding.Panel1
            // 
            this.scMarginsPadding.Panel1.Controls.Add(this.gbMargins);
            // 
            // scMarginsPadding.Panel2
            // 
            this.scMarginsPadding.Panel2.Controls.Add(this.gbPadding);
            this.scMarginsPadding.Size = new System.Drawing.Size(454, 142);
            this.scMarginsPadding.SplitterDistance = 227;
            this.scMarginsPadding.SplitterWidth = 1;
            this.scMarginsPadding.TabIndex = 0;
            // 
            // gbMargins
            // 
            this.gbMargins.Controls.Add(this.tbMRight);
            this.gbMargins.Controls.Add(this.tbMLeft);
            this.gbMargins.Controls.Add(this.tbMBottom);
            this.gbMargins.Controls.Add(this.tbMTop);
            this.gbMargins.Controls.Add(this.lMRight);
            this.gbMargins.Controls.Add(this.lMLeft);
            this.gbMargins.Controls.Add(this.lMBottom);
            this.gbMargins.Controls.Add(this.lMTop);
            this.gbMargins.Controls.Add(this.cbMRightType);
            this.gbMargins.Controls.Add(this.cbMLeftType);
            this.gbMargins.Controls.Add(this.cbMBottomType);
            this.gbMargins.Controls.Add(this.cbMTopType);
            this.gbMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMargins.Location = new System.Drawing.Point(0, 0);
            this.gbMargins.Name = "gbMargins";
            this.gbMargins.Size = new System.Drawing.Size(227, 142);
            this.gbMargins.TabIndex = 0;
            this.gbMargins.TabStop = false;
            this.gbMargins.Text = "&Margins";
            // 
            // tbMRight
            // 
            this.tbMRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMRight.Location = new System.Drawing.Point(54, 100);
            this.tbMRight.Name = "tbMRight";
            this.tbMRight.Size = new System.Drawing.Size(100, 20);
            this.tbMRight.TabIndex = 11;
            // 
            // tbMLeft
            // 
            this.tbMLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMLeft.Location = new System.Drawing.Point(53, 73);
            this.tbMLeft.Name = "tbMLeft";
            this.tbMLeft.Size = new System.Drawing.Size(100, 20);
            this.tbMLeft.TabIndex = 10;
            // 
            // tbMBottom
            // 
            this.tbMBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMBottom.Location = new System.Drawing.Point(53, 46);
            this.tbMBottom.Name = "tbMBottom";
            this.tbMBottom.Size = new System.Drawing.Size(100, 20);
            this.tbMBottom.TabIndex = 9;
            // 
            // tbMTop
            // 
            this.tbMTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMTop.Location = new System.Drawing.Point(54, 19);
            this.tbMTop.Name = "tbMTop";
            this.tbMTop.Size = new System.Drawing.Size(100, 20);
            this.tbMTop.TabIndex = 8;
            // 
            // lMRight
            // 
            this.lMRight.AutoSize = true;
            this.lMRight.Location = new System.Drawing.Point(6, 103);
            this.lMRight.Name = "lMRight";
            this.lMRight.Size = new System.Drawing.Size(35, 13);
            this.lMRight.TabIndex = 7;
            this.lMRight.Text = "Right:";
            // 
            // lMLeft
            // 
            this.lMLeft.AutoSize = true;
            this.lMLeft.Location = new System.Drawing.Point(6, 76);
            this.lMLeft.Name = "lMLeft";
            this.lMLeft.Size = new System.Drawing.Size(28, 13);
            this.lMLeft.TabIndex = 6;
            this.lMLeft.Text = "Left:";
            // 
            // lMBottom
            // 
            this.lMBottom.AutoSize = true;
            this.lMBottom.Location = new System.Drawing.Point(6, 49);
            this.lMBottom.Name = "lMBottom";
            this.lMBottom.Size = new System.Drawing.Size(43, 13);
            this.lMBottom.TabIndex = 5;
            this.lMBottom.Text = "Bottom:";
            // 
            // lMTop
            // 
            this.lMTop.AutoSize = true;
            this.lMTop.Location = new System.Drawing.Point(6, 22);
            this.lMTop.Name = "lMTop";
            this.lMTop.Size = new System.Drawing.Size(29, 13);
            this.lMTop.TabIndex = 4;
            this.lMTop.Text = "Top:";
            // 
            // cbMRightType
            // 
            this.cbMRightType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMRightType.FormattingEnabled = true;
            this.cbMRightType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbMRightType.Location = new System.Drawing.Point(159, 100);
            this.cbMRightType.Name = "cbMRightType";
            this.cbMRightType.Size = new System.Drawing.Size(62, 21);
            this.cbMRightType.TabIndex = 3;
            // 
            // cbMLeftType
            // 
            this.cbMLeftType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMLeftType.FormattingEnabled = true;
            this.cbMLeftType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbMLeftType.Location = new System.Drawing.Point(159, 73);
            this.cbMLeftType.Name = "cbMLeftType";
            this.cbMLeftType.Size = new System.Drawing.Size(62, 21);
            this.cbMLeftType.TabIndex = 2;
            // 
            // cbMBottomType
            // 
            this.cbMBottomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMBottomType.FormattingEnabled = true;
            this.cbMBottomType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbMBottomType.Location = new System.Drawing.Point(159, 46);
            this.cbMBottomType.Name = "cbMBottomType";
            this.cbMBottomType.Size = new System.Drawing.Size(62, 21);
            this.cbMBottomType.TabIndex = 1;
            // 
            // cbMTopType
            // 
            this.cbMTopType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMTopType.FormattingEnabled = true;
            this.cbMTopType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbMTopType.Location = new System.Drawing.Point(160, 19);
            this.cbMTopType.Name = "cbMTopType";
            this.cbMTopType.Size = new System.Drawing.Size(62, 21);
            this.cbMTopType.TabIndex = 0;
            // 
            // gbPadding
            // 
            this.gbPadding.Controls.Add(this.tbPRight);
            this.gbPadding.Controls.Add(this.tbPLeft);
            this.gbPadding.Controls.Add(this.tbPBottom);
            this.gbPadding.Controls.Add(this.tbPTop);
            this.gbPadding.Controls.Add(this.lPRight);
            this.gbPadding.Controls.Add(this.lPLeft);
            this.gbPadding.Controls.Add(this.lPBottom);
            this.gbPadding.Controls.Add(this.lPTop);
            this.gbPadding.Controls.Add(this.cbPRightType);
            this.gbPadding.Controls.Add(this.cbPLeftType);
            this.gbPadding.Controls.Add(this.cbPBottomType);
            this.gbPadding.Controls.Add(this.cbPTopType);
            this.gbPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPadding.Location = new System.Drawing.Point(0, 0);
            this.gbPadding.Name = "gbPadding";
            this.gbPadding.Size = new System.Drawing.Size(226, 142);
            this.gbPadding.TabIndex = 0;
            this.gbPadding.TabStop = false;
            this.gbPadding.Text = "&Padding";
            // 
            // tbPRight
            // 
            this.tbPRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPRight.Location = new System.Drawing.Point(52, 100);
            this.tbPRight.Name = "tbPRight";
            this.tbPRight.Size = new System.Drawing.Size(100, 20);
            this.tbPRight.TabIndex = 11;
            // 
            // tbPLeft
            // 
            this.tbPLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPLeft.Location = new System.Drawing.Point(52, 73);
            this.tbPLeft.Name = "tbPLeft";
            this.tbPLeft.Size = new System.Drawing.Size(100, 20);
            this.tbPLeft.TabIndex = 10;
            // 
            // tbPBottom
            // 
            this.tbPBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPBottom.Location = new System.Drawing.Point(52, 46);
            this.tbPBottom.Name = "tbPBottom";
            this.tbPBottom.Size = new System.Drawing.Size(100, 20);
            this.tbPBottom.TabIndex = 9;
            // 
            // tbPTop
            // 
            this.tbPTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPTop.Location = new System.Drawing.Point(52, 19);
            this.tbPTop.Name = "tbPTop";
            this.tbPTop.Size = new System.Drawing.Size(100, 20);
            this.tbPTop.TabIndex = 8;
            // 
            // lPRight
            // 
            this.lPRight.AutoSize = true;
            this.lPRight.Location = new System.Drawing.Point(6, 103);
            this.lPRight.Name = "lPRight";
            this.lPRight.Size = new System.Drawing.Size(35, 13);
            this.lPRight.TabIndex = 7;
            this.lPRight.Text = "Right:";
            // 
            // lPLeft
            // 
            this.lPLeft.AutoSize = true;
            this.lPLeft.Location = new System.Drawing.Point(5, 76);
            this.lPLeft.Name = "lPLeft";
            this.lPLeft.Size = new System.Drawing.Size(28, 13);
            this.lPLeft.TabIndex = 6;
            this.lPLeft.Text = "Left:";
            // 
            // lPBottom
            // 
            this.lPBottom.AutoSize = true;
            this.lPBottom.Location = new System.Drawing.Point(5, 49);
            this.lPBottom.Name = "lPBottom";
            this.lPBottom.Size = new System.Drawing.Size(43, 13);
            this.lPBottom.TabIndex = 5;
            this.lPBottom.Text = "Bottom:";
            // 
            // lPTop
            // 
            this.lPTop.AutoSize = true;
            this.lPTop.Location = new System.Drawing.Point(5, 22);
            this.lPTop.Name = "lPTop";
            this.lPTop.Size = new System.Drawing.Size(29, 13);
            this.lPTop.TabIndex = 4;
            this.lPTop.Text = "Top:";
            // 
            // cbPRightType
            // 
            this.cbPRightType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRightType.FormattingEnabled = true;
            this.cbPRightType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbPRightType.Location = new System.Drawing.Point(158, 100);
            this.cbPRightType.Name = "cbPRightType";
            this.cbPRightType.Size = new System.Drawing.Size(62, 21);
            this.cbPRightType.TabIndex = 3;
            // 
            // cbPLeftType
            // 
            this.cbPLeftType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPLeftType.FormattingEnabled = true;
            this.cbPLeftType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbPLeftType.Location = new System.Drawing.Point(158, 73);
            this.cbPLeftType.Name = "cbPLeftType";
            this.cbPLeftType.Size = new System.Drawing.Size(62, 21);
            this.cbPLeftType.TabIndex = 2;
            // 
            // cbPBottomType
            // 
            this.cbPBottomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPBottomType.FormattingEnabled = true;
            this.cbPBottomType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbPBottomType.Location = new System.Drawing.Point(158, 46);
            this.cbPBottomType.Name = "cbPBottomType";
            this.cbPBottomType.Size = new System.Drawing.Size(62, 21);
            this.cbPBottomType.TabIndex = 1;
            // 
            // cbPTopType
            // 
            this.cbPTopType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTopType.FormattingEnabled = true;
            this.cbPTopType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbPTopType.Location = new System.Drawing.Point(158, 19);
            this.cbPTopType.Name = "cbPTopType";
            this.cbPTopType.Size = new System.Drawing.Size(62, 21);
            this.cbPTopType.TabIndex = 0;
            // 
            // scEdges
            // 
            this.scEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scEdges.Location = new System.Drawing.Point(3, 151);
            this.scEdges.Name = "scEdges";
            // 
            // scEdges.Panel1
            // 
            this.scEdges.Panel1.Controls.Add(this.splitContainer2);
            // 
            // scEdges.Panel2
            // 
            this.scEdges.Panel2.Controls.Add(this.splitContainer3);
            this.scEdges.Size = new System.Drawing.Size(454, 216);
            this.scEdges.SplitterDistance = 227;
            this.scEdges.SplitterWidth = 1;
            this.scEdges.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbTop);
            this.splitContainer2.Size = new System.Drawing.Size(227, 216);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbLeft
            // 
            this.gbLeft.Controls.Add(this.btLeftColor);
            this.gbLeft.Controls.Add(this.tbLeftWidth);
            this.gbLeft.Controls.Add(this.cbLeftWidthType);
            this.gbLeft.Controls.Add(this.lLeftColor);
            this.gbLeft.Controls.Add(this.lLeftWidth);
            this.gbLeft.Controls.Add(this.lLeftStyle);
            this.gbLeft.Controls.Add(this.cbLeftColor);
            this.gbLeft.Controls.Add(this.cbLeftWidth);
            this.gbLeft.Controls.Add(this.cbLeftStyle);
            this.gbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLeft.Location = new System.Drawing.Point(0, 0);
            this.gbLeft.Name = "gbLeft";
            this.gbLeft.Size = new System.Drawing.Size(227, 108);
            this.gbLeft.TabIndex = 0;
            this.gbLeft.TabStop = false;
            this.gbLeft.Text = "Left edge";
            // 
            // btLeftColor
            // 
            this.btLeftColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLeftColor.Location = new System.Drawing.Point(175, 71);
            this.btLeftColor.Name = "btLeftColor";
            this.btLeftColor.Size = new System.Drawing.Size(46, 23);
            this.btLeftColor.TabIndex = 8;
            this.btLeftColor.Text = "...";
            this.btLeftColor.UseVisualStyleBackColor = true;
            this.btLeftColor.Click += new System.EventHandler(this.btLeftColor_Click);
            // 
            // tbLeftWidth
            // 
            this.tbLeftWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLeftWidth.Location = new System.Drawing.Point(121, 46);
            this.tbLeftWidth.Name = "tbLeftWidth";
            this.tbLeftWidth.Size = new System.Drawing.Size(48, 20);
            this.tbLeftWidth.TabIndex = 7;
            // 
            // cbLeftWidthType
            // 
            this.cbLeftWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLeftWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeftWidthType.FormattingEnabled = true;
            this.cbLeftWidthType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbLeftWidthType.Location = new System.Drawing.Point(175, 46);
            this.cbLeftWidthType.Name = "cbLeftWidthType";
            this.cbLeftWidthType.Size = new System.Drawing.Size(46, 21);
            this.cbLeftWidthType.TabIndex = 6;
            // 
            // lLeftColor
            // 
            this.lLeftColor.AutoSize = true;
            this.lLeftColor.Location = new System.Drawing.Point(6, 76);
            this.lLeftColor.Name = "lLeftColor";
            this.lLeftColor.Size = new System.Drawing.Size(34, 13);
            this.lLeftColor.TabIndex = 5;
            this.lLeftColor.Text = "Color:";
            // 
            // lLeftWidth
            // 
            this.lLeftWidth.AutoSize = true;
            this.lLeftWidth.Location = new System.Drawing.Point(6, 49);
            this.lLeftWidth.Name = "lLeftWidth";
            this.lLeftWidth.Size = new System.Drawing.Size(38, 13);
            this.lLeftWidth.TabIndex = 4;
            this.lLeftWidth.Text = "Width:";
            // 
            // lLeftStyle
            // 
            this.lLeftStyle.AutoSize = true;
            this.lLeftStyle.Location = new System.Drawing.Point(6, 22);
            this.lLeftStyle.Name = "lLeftStyle";
            this.lLeftStyle.Size = new System.Drawing.Size(33, 13);
            this.lLeftStyle.TabIndex = 3;
            this.lLeftStyle.Text = "Style:";
            // 
            // cbLeftColor
            // 
            this.cbLeftColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLeftColor.FormattingEnabled = true;
            this.cbLeftColor.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.cbLeftColor.Location = new System.Drawing.Point(54, 73);
            this.cbLeftColor.Name = "cbLeftColor";
            this.cbLeftColor.Size = new System.Drawing.Size(115, 21);
            this.cbLeftColor.TabIndex = 2;
            // 
            // cbLeftWidth
            // 
            this.cbLeftWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLeftWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeftWidth.FormattingEnabled = true;
            this.cbLeftWidth.Items.AddRange(new object[] {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"});
            this.cbLeftWidth.Location = new System.Drawing.Point(54, 46);
            this.cbLeftWidth.Name = "cbLeftWidth";
            this.cbLeftWidth.Size = new System.Drawing.Size(61, 21);
            this.cbLeftWidth.TabIndex = 1;
            this.cbLeftWidth.SelectedIndexChanged += new System.EventHandler(this.cbLeftWidth_SelectedIndexChanged);
            // 
            // cbLeftStyle
            // 
            this.cbLeftStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLeftStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeftStyle.FormattingEnabled = true;
            this.cbLeftStyle.Location = new System.Drawing.Point(54, 19);
            this.cbLeftStyle.Name = "cbLeftStyle";
            this.cbLeftStyle.Size = new System.Drawing.Size(115, 21);
            this.cbLeftStyle.TabIndex = 0;
            this.cbLeftStyle.SelectedIndexChanged += new System.EventHandler(this.cbLeftStyle_SelectedIndexChanged);
            // 
            // gbTop
            // 
            this.gbTop.Controls.Add(this.btTopColor);
            this.gbTop.Controls.Add(this.tbTopWidth);
            this.gbTop.Controls.Add(this.cbTopWidthType);
            this.gbTop.Controls.Add(this.lTopColor);
            this.gbTop.Controls.Add(this.lTopWidth);
            this.gbTop.Controls.Add(this.lTopStyle);
            this.gbTop.Controls.Add(this.cbTopColor);
            this.gbTop.Controls.Add(this.cbTopWidth);
            this.gbTop.Controls.Add(this.cbTopStyle);
            this.gbTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTop.Location = new System.Drawing.Point(0, 0);
            this.gbTop.Name = "gbTop";
            this.gbTop.Size = new System.Drawing.Size(227, 107);
            this.gbTop.TabIndex = 0;
            this.gbTop.TabStop = false;
            this.gbTop.Text = "Top edge";
            // 
            // btTopColor
            // 
            this.btTopColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTopColor.Location = new System.Drawing.Point(175, 68);
            this.btTopColor.Name = "btTopColor";
            this.btTopColor.Size = new System.Drawing.Size(46, 23);
            this.btTopColor.TabIndex = 17;
            this.btTopColor.Text = "...";
            this.btTopColor.UseVisualStyleBackColor = true;
            this.btTopColor.Click += new System.EventHandler(this.btTopColor_Click);
            // 
            // tbTopWidth
            // 
            this.tbTopWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTopWidth.Location = new System.Drawing.Point(121, 43);
            this.tbTopWidth.Name = "tbTopWidth";
            this.tbTopWidth.Size = new System.Drawing.Size(48, 20);
            this.tbTopWidth.TabIndex = 16;
            // 
            // cbTopWidthType
            // 
            this.cbTopWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopWidthType.FormattingEnabled = true;
            this.cbTopWidthType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbTopWidthType.Location = new System.Drawing.Point(175, 43);
            this.cbTopWidthType.Name = "cbTopWidthType";
            this.cbTopWidthType.Size = new System.Drawing.Size(46, 21);
            this.cbTopWidthType.TabIndex = 15;
            // 
            // lTopColor
            // 
            this.lTopColor.AutoSize = true;
            this.lTopColor.Location = new System.Drawing.Point(6, 73);
            this.lTopColor.Name = "lTopColor";
            this.lTopColor.Size = new System.Drawing.Size(34, 13);
            this.lTopColor.TabIndex = 14;
            this.lTopColor.Text = "Color:";
            // 
            // lTopWidth
            // 
            this.lTopWidth.AutoSize = true;
            this.lTopWidth.Location = new System.Drawing.Point(6, 46);
            this.lTopWidth.Name = "lTopWidth";
            this.lTopWidth.Size = new System.Drawing.Size(38, 13);
            this.lTopWidth.TabIndex = 13;
            this.lTopWidth.Text = "Width:";
            // 
            // lTopStyle
            // 
            this.lTopStyle.AutoSize = true;
            this.lTopStyle.Location = new System.Drawing.Point(6, 19);
            this.lTopStyle.Name = "lTopStyle";
            this.lTopStyle.Size = new System.Drawing.Size(33, 13);
            this.lTopStyle.TabIndex = 12;
            this.lTopStyle.Text = "Style:";
            // 
            // cbTopColor
            // 
            this.cbTopColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopColor.FormattingEnabled = true;
            this.cbTopColor.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.cbTopColor.Location = new System.Drawing.Point(54, 70);
            this.cbTopColor.Name = "cbTopColor";
            this.cbTopColor.Size = new System.Drawing.Size(115, 21);
            this.cbTopColor.TabIndex = 11;
            // 
            // cbTopWidth
            // 
            this.cbTopWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopWidth.FormattingEnabled = true;
            this.cbTopWidth.Items.AddRange(new object[] {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"});
            this.cbTopWidth.Location = new System.Drawing.Point(54, 43);
            this.cbTopWidth.Name = "cbTopWidth";
            this.cbTopWidth.Size = new System.Drawing.Size(61, 21);
            this.cbTopWidth.TabIndex = 10;
            this.cbTopWidth.SelectedIndexChanged += new System.EventHandler(this.cbTopWidth_SelectedIndexChanged);
            // 
            // cbTopStyle
            // 
            this.cbTopStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopStyle.FormattingEnabled = true;
            this.cbTopStyle.Location = new System.Drawing.Point(54, 16);
            this.cbTopStyle.Name = "cbTopStyle";
            this.cbTopStyle.Size = new System.Drawing.Size(115, 21);
            this.cbTopStyle.TabIndex = 9;
            this.cbTopStyle.SelectedIndexChanged += new System.EventHandler(this.cbTopStyle_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gbRight);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gbBottom);
            this.splitContainer3.Size = new System.Drawing.Size(226, 216);
            this.splitContainer3.SplitterDistance = 108;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // gbRight
            // 
            this.gbRight.Controls.Add(this.btRightColor);
            this.gbRight.Controls.Add(this.tbRightWidth);
            this.gbRight.Controls.Add(this.cbRightWidthType);
            this.gbRight.Controls.Add(this.lRightColor);
            this.gbRight.Controls.Add(this.lRightWidth);
            this.gbRight.Controls.Add(this.lRightStyle);
            this.gbRight.Controls.Add(this.cbRightColor);
            this.gbRight.Controls.Add(this.cbRightWidth);
            this.gbRight.Controls.Add(this.cbRightStyle);
            this.gbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRight.Location = new System.Drawing.Point(0, 0);
            this.gbRight.Name = "gbRight";
            this.gbRight.Size = new System.Drawing.Size(226, 108);
            this.gbRight.TabIndex = 0;
            this.gbRight.TabStop = false;
            this.gbRight.Text = "Right edge";
            // 
            // btRightColor
            // 
            this.btRightColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRightColor.Location = new System.Drawing.Point(175, 71);
            this.btRightColor.Name = "btRightColor";
            this.btRightColor.Size = new System.Drawing.Size(46, 23);
            this.btRightColor.TabIndex = 17;
            this.btRightColor.Text = "...";
            this.btRightColor.UseVisualStyleBackColor = true;
            this.btRightColor.Click += new System.EventHandler(this.btRightColor_Click);
            // 
            // tbRightWidth
            // 
            this.tbRightWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRightWidth.Location = new System.Drawing.Point(121, 46);
            this.tbRightWidth.Name = "tbRightWidth";
            this.tbRightWidth.Size = new System.Drawing.Size(48, 20);
            this.tbRightWidth.TabIndex = 16;
            // 
            // cbRightWidthType
            // 
            this.cbRightWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRightWidthType.FormattingEnabled = true;
            this.cbRightWidthType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbRightWidthType.Location = new System.Drawing.Point(175, 46);
            this.cbRightWidthType.Name = "cbRightWidthType";
            this.cbRightWidthType.Size = new System.Drawing.Size(46, 21);
            this.cbRightWidthType.TabIndex = 15;
            // 
            // lRightColor
            // 
            this.lRightColor.AutoSize = true;
            this.lRightColor.Location = new System.Drawing.Point(6, 76);
            this.lRightColor.Name = "lRightColor";
            this.lRightColor.Size = new System.Drawing.Size(34, 13);
            this.lRightColor.TabIndex = 14;
            this.lRightColor.Text = "Color:";
            // 
            // lRightWidth
            // 
            this.lRightWidth.AutoSize = true;
            this.lRightWidth.Location = new System.Drawing.Point(6, 49);
            this.lRightWidth.Name = "lRightWidth";
            this.lRightWidth.Size = new System.Drawing.Size(38, 13);
            this.lRightWidth.TabIndex = 13;
            this.lRightWidth.Text = "Width:";
            // 
            // lRightStyle
            // 
            this.lRightStyle.AutoSize = true;
            this.lRightStyle.Location = new System.Drawing.Point(6, 22);
            this.lRightStyle.Name = "lRightStyle";
            this.lRightStyle.Size = new System.Drawing.Size(33, 13);
            this.lRightStyle.TabIndex = 12;
            this.lRightStyle.Text = "Style:";
            // 
            // cbRightColor
            // 
            this.cbRightColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightColor.FormattingEnabled = true;
            this.cbRightColor.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.cbRightColor.Location = new System.Drawing.Point(54, 73);
            this.cbRightColor.Name = "cbRightColor";
            this.cbRightColor.Size = new System.Drawing.Size(115, 21);
            this.cbRightColor.TabIndex = 11;
            // 
            // cbRightWidth
            // 
            this.cbRightWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRightWidth.FormattingEnabled = true;
            this.cbRightWidth.Items.AddRange(new object[] {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"});
            this.cbRightWidth.Location = new System.Drawing.Point(54, 46);
            this.cbRightWidth.Name = "cbRightWidth";
            this.cbRightWidth.Size = new System.Drawing.Size(61, 21);
            this.cbRightWidth.TabIndex = 10;
            this.cbRightWidth.SelectedIndexChanged += new System.EventHandler(this.cbRightWidth_SelectedIndexChanged);
            // 
            // cbRightStyle
            // 
            this.cbRightStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRightStyle.FormattingEnabled = true;
            this.cbRightStyle.Location = new System.Drawing.Point(54, 19);
            this.cbRightStyle.Name = "cbRightStyle";
            this.cbRightStyle.Size = new System.Drawing.Size(115, 21);
            this.cbRightStyle.TabIndex = 9;
            this.cbRightStyle.SelectedIndexChanged += new System.EventHandler(this.cbRightStyle_SelectedIndexChanged);
            // 
            // gbBottom
            // 
            this.gbBottom.Controls.Add(this.btBottomColor);
            this.gbBottom.Controls.Add(this.tbBottomWidth);
            this.gbBottom.Controls.Add(this.cbBottomWidthType);
            this.gbBottom.Controls.Add(this.lBottomColor);
            this.gbBottom.Controls.Add(this.lBottomWidth);
            this.gbBottom.Controls.Add(this.lBottomStyle);
            this.gbBottom.Controls.Add(this.cbBottomColor);
            this.gbBottom.Controls.Add(this.cbBottomWidth);
            this.gbBottom.Controls.Add(this.cbBottomStyle);
            this.gbBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBottom.Location = new System.Drawing.Point(0, 0);
            this.gbBottom.Name = "gbBottom";
            this.gbBottom.Size = new System.Drawing.Size(226, 107);
            this.gbBottom.TabIndex = 0;
            this.gbBottom.TabStop = false;
            this.gbBottom.Text = "Bottom Edge";
            // 
            // btBottomColor
            // 
            this.btBottomColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBottomColor.Location = new System.Drawing.Point(175, 68);
            this.btBottomColor.Name = "btBottomColor";
            this.btBottomColor.Size = new System.Drawing.Size(46, 23);
            this.btBottomColor.TabIndex = 17;
            this.btBottomColor.Text = "...";
            this.btBottomColor.UseVisualStyleBackColor = true;
            this.btBottomColor.Click += new System.EventHandler(this.btBottomColor_Click);
            // 
            // tbBottomWidth
            // 
            this.tbBottomWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBottomWidth.Location = new System.Drawing.Point(121, 43);
            this.tbBottomWidth.Name = "tbBottomWidth";
            this.tbBottomWidth.Size = new System.Drawing.Size(48, 20);
            this.tbBottomWidth.TabIndex = 16;
            // 
            // cbBottomWidthType
            // 
            this.cbBottomWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBottomWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBottomWidthType.FormattingEnabled = true;
            this.cbBottomWidthType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbBottomWidthType.Location = new System.Drawing.Point(175, 43);
            this.cbBottomWidthType.Name = "cbBottomWidthType";
            this.cbBottomWidthType.Size = new System.Drawing.Size(46, 21);
            this.cbBottomWidthType.TabIndex = 15;
            // 
            // lBottomColor
            // 
            this.lBottomColor.AutoSize = true;
            this.lBottomColor.Location = new System.Drawing.Point(6, 73);
            this.lBottomColor.Name = "lBottomColor";
            this.lBottomColor.Size = new System.Drawing.Size(34, 13);
            this.lBottomColor.TabIndex = 14;
            this.lBottomColor.Text = "Color:";
            // 
            // lBottomWidth
            // 
            this.lBottomWidth.AutoSize = true;
            this.lBottomWidth.Location = new System.Drawing.Point(6, 46);
            this.lBottomWidth.Name = "lBottomWidth";
            this.lBottomWidth.Size = new System.Drawing.Size(38, 13);
            this.lBottomWidth.TabIndex = 13;
            this.lBottomWidth.Text = "Width:";
            // 
            // lBottomStyle
            // 
            this.lBottomStyle.AutoSize = true;
            this.lBottomStyle.Location = new System.Drawing.Point(6, 19);
            this.lBottomStyle.Name = "lBottomStyle";
            this.lBottomStyle.Size = new System.Drawing.Size(33, 13);
            this.lBottomStyle.TabIndex = 12;
            this.lBottomStyle.Text = "Style:";
            // 
            // cbBottomColor
            // 
            this.cbBottomColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBottomColor.FormattingEnabled = true;
            this.cbBottomColor.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Blue",
            "Fuchsia",
            "Gray",
            "Green",
            "Lime",
            "Maroon",
            "Navy",
            "Olive",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.cbBottomColor.Location = new System.Drawing.Point(54, 70);
            this.cbBottomColor.Name = "cbBottomColor";
            this.cbBottomColor.Size = new System.Drawing.Size(115, 21);
            this.cbBottomColor.TabIndex = 11;
            // 
            // cbBottomWidth
            // 
            this.cbBottomWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBottomWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBottomWidth.FormattingEnabled = true;
            this.cbBottomWidth.Items.AddRange(new object[] {
            "<Not Set>",
            "Thin",
            "Medium",
            "Thick",
            "Custom"});
            this.cbBottomWidth.Location = new System.Drawing.Point(54, 43);
            this.cbBottomWidth.Name = "cbBottomWidth";
            this.cbBottomWidth.Size = new System.Drawing.Size(61, 21);
            this.cbBottomWidth.TabIndex = 10;
            this.cbBottomWidth.SelectedIndexChanged += new System.EventHandler(this.cbBottomWidth_SelectedIndexChanged);
            // 
            // cbBottomStyle
            // 
            this.cbBottomStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBottomStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBottomStyle.FormattingEnabled = true;
            this.cbBottomStyle.Location = new System.Drawing.Point(54, 16);
            this.cbBottomStyle.Name = "cbBottomStyle";
            this.cbBottomStyle.Size = new System.Drawing.Size(115, 21);
            this.cbBottomStyle.TabIndex = 9;
            this.cbBottomStyle.SelectedIndexChanged += new System.EventHandler(this.cbBottomStyle_SelectedIndexChanged);
            // 
            // ucEdges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scEdges);
            this.Controls.Add(this.scMarginsPadding);
            this.Name = "ucEdges";
            this.Size = new System.Drawing.Size(460, 370);
            this.Load += new System.EventHandler(this.ucEdges_Load);
            this.scMarginsPadding.Panel1.ResumeLayout(false);
            this.scMarginsPadding.Panel2.ResumeLayout(false);
            this.scMarginsPadding.ResumeLayout(false);
            this.gbMargins.ResumeLayout(false);
            this.gbMargins.PerformLayout();
            this.gbPadding.ResumeLayout(false);
            this.gbPadding.PerformLayout();
            this.scEdges.Panel1.ResumeLayout(false);
            this.scEdges.Panel2.ResumeLayout(false);
            this.scEdges.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbLeft.ResumeLayout(false);
            this.gbLeft.PerformLayout();
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gbRight.ResumeLayout(false);
            this.gbRight.PerformLayout();
            this.gbBottom.ResumeLayout(false);
            this.gbBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The sc margins padding
        /// </summary>
        private SplitContainer scMarginsPadding;
        /// <summary>
        /// The gb margins
        /// </summary>
        private GroupBox gbMargins;
        /// <summary>
        /// The gb padding
        /// </summary>
        private GroupBox gbPadding;
        /// <summary>
        /// The tb M right
        /// </summary>
        private TextBox tbMRight;
        /// <summary>
        /// The tb M left
        /// </summary>
        private TextBox tbMLeft;
        /// <summary>
        /// The tb M bottom
        /// </summary>
        private TextBox tbMBottom;
        /// <summary>
        /// The tb M top
        /// </summary>
        private TextBox tbMTop;
        /// <summary>
        /// The l M right
        /// </summary>
        private Label lMRight;
        /// <summary>
        /// The l M left
        /// </summary>
        private Label lMLeft;
        /// <summary>
        /// The l M bottom
        /// </summary>
        private Label lMBottom;
        /// <summary>
        /// The l M top
        /// </summary>
        private Label lMTop;
        /// <summary>
        /// The cb M right type
        /// </summary>
        private ComboBox cbMRightType;
        /// <summary>
        /// The cb M left type
        /// </summary>
        private ComboBox cbMLeftType;
        /// <summary>
        /// The cb M bottom type
        /// </summary>
        private ComboBox cbMBottomType;
        /// <summary>
        /// The cb M top type
        /// </summary>
        private ComboBox cbMTopType;
        /// <summary>
        /// The tb P right
        /// </summary>
        private TextBox tbPRight;
        /// <summary>
        /// The tb P left
        /// </summary>
        private TextBox tbPLeft;
        /// <summary>
        /// The tb P bottom
        /// </summary>
        private TextBox tbPBottom;
        /// <summary>
        /// The tb P top
        /// </summary>
        private TextBox tbPTop;
        /// <summary>
        /// The l P right
        /// </summary>
        private Label lPRight;
        /// <summary>
        /// The l P left
        /// </summary>
        private Label lPLeft;
        /// <summary>
        /// The l P bottom
        /// </summary>
        private Label lPBottom;
        /// <summary>
        /// The l P top
        /// </summary>
        private Label lPTop;
        /// <summary>
        /// The cb P right type
        /// </summary>
        private ComboBox cbPRightType;
        /// <summary>
        /// The cb P left type
        /// </summary>
        private ComboBox cbPLeftType;
        /// <summary>
        /// The cb P bottom type
        /// </summary>
        private ComboBox cbPBottomType;
        /// <summary>
        /// The cb P top type
        /// </summary>
        private ComboBox cbPTopType;
        /// <summary>
        /// The sc edges
        /// </summary>
        private SplitContainer scEdges;
        /// <summary>
        /// The split container2
        /// </summary>
        private SplitContainer splitContainer2;
        /// <summary>
        /// The gb left
        /// </summary>
        private GroupBox gbLeft;
        /// <summary>
        /// The cb left color
        /// </summary>
        private ComboBox cbLeftColor;
        /// <summary>
        /// The cb left width
        /// </summary>
        private ComboBox cbLeftWidth;
        /// <summary>
        /// The cb left style
        /// </summary>
        private ComboBox cbLeftStyle;
        /// <summary>
        /// The gb top
        /// </summary>
        private GroupBox gbTop;
        /// <summary>
        /// The split container3
        /// </summary>
        private SplitContainer splitContainer3;
        /// <summary>
        /// The gb right
        /// </summary>
        private GroupBox gbRight;
        /// <summary>
        /// The gb bottom
        /// </summary>
        private GroupBox gbBottom;
        /// <summary>
        /// The l left color
        /// </summary>
        private Label lLeftColor;
        /// <summary>
        /// The l left width
        /// </summary>
        private Label lLeftWidth;
        /// <summary>
        /// The l left style
        /// </summary>
        private Label lLeftStyle;
        /// <summary>
        /// The bt left color
        /// </summary>
        private Button btLeftColor;
        /// <summary>
        /// The tb left width
        /// </summary>
        private TextBox tbLeftWidth;
        /// <summary>
        /// The cb left width type
        /// </summary>
        private ComboBox cbLeftWidthType;
        /// <summary>
        /// The bt top color
        /// </summary>
        private Button btTopColor;
        /// <summary>
        /// The tb top width
        /// </summary>
        private TextBox tbTopWidth;
        /// <summary>
        /// The cb top width type
        /// </summary>
        private ComboBox cbTopWidthType;
        /// <summary>
        /// The l top color
        /// </summary>
        private Label lTopColor;
        /// <summary>
        /// The l top width
        /// </summary>
        private Label lTopWidth;
        /// <summary>
        /// The l top style
        /// </summary>
        private Label lTopStyle;
        /// <summary>
        /// The cb top color
        /// </summary>
        private ComboBox cbTopColor;
        /// <summary>
        /// The cb top width
        /// </summary>
        private ComboBox cbTopWidth;
        /// <summary>
        /// The cb top style
        /// </summary>
        private ComboBox cbTopStyle;
        /// <summary>
        /// The bt right color
        /// </summary>
        private Button btRightColor;
        /// <summary>
        /// The tb right width
        /// </summary>
        private TextBox tbRightWidth;
        /// <summary>
        /// The cb right width type
        /// </summary>
        private ComboBox cbRightWidthType;
        /// <summary>
        /// The l right color
        /// </summary>
        private Label lRightColor;
        /// <summary>
        /// The l right width
        /// </summary>
        private Label lRightWidth;
        /// <summary>
        /// The l right style
        /// </summary>
        private Label lRightStyle;
        /// <summary>
        /// The cb right color
        /// </summary>
        private ComboBox cbRightColor;
        /// <summary>
        /// The cb right width
        /// </summary>
        private ComboBox cbRightWidth;
        /// <summary>
        /// The cb right style
        /// </summary>
        private ComboBox cbRightStyle;
        /// <summary>
        /// The bt bottom color
        /// </summary>
        private Button btBottomColor;
        /// <summary>
        /// The tb bottom width
        /// </summary>
        private TextBox tbBottomWidth;
        /// <summary>
        /// The cb bottom width type
        /// </summary>
        private ComboBox cbBottomWidthType;
        /// <summary>
        /// The l bottom color
        /// </summary>
        private Label lBottomColor;
        /// <summary>
        /// The l bottom width
        /// </summary>
        private Label lBottomWidth;
        /// <summary>
        /// The l bottom style
        /// </summary>
        private Label lBottomStyle;
        /// <summary>
        /// The cb bottom color
        /// </summary>
        private ComboBox cbBottomColor;
        /// <summary>
        /// The cb bottom width
        /// </summary>
        private ComboBox cbBottomWidth;
        /// <summary>
        /// The cb bottom style
        /// </summary>
        private ComboBox cbBottomStyle;
        /// <summary>
        /// The DLG color
        /// </summary>
        private ColorDialog dlgColor;
    }
}
