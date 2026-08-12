using System.ComponentModel;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.WinForms.Helpers.Controls;

namespace CustomDialog.Dialogs
{
    public partial class TablePropertiesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablePropertiesDialog));
            this.grpLayout = new System.Windows.Forms.GroupBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.grpHeight = new System.Windows.Forms.GroupBox();
            this.cmbHeightUnit = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.grpWidth = new System.Windows.Forms.GroupBox();
            this.chkWidth = new System.Windows.Forms.CheckBox();
            this.cmbWidthUnit = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.chkCaption = new System.Windows.Forms.CheckBox();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.grpAttributes = new System.Windows.Forms.GroupBox();
            this.chklnkBackgroundPicture = new CheckboxWithLinklabel();
            this.chklnkBgColor = new CheckboxWithLinklabel();
            this.chklnkBorderColor = new CheckboxWithLinklabel();
            this.chkBorderToAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.chkBorderStyle = new System.Windows.Forms.CheckBox();
            this.pbBackgroundPicture = new System.Windows.Forms.PictureBox();
            this.txtBgColor = new System.Windows.Forms.TextBox();
            this.txtBorderColor = new System.Windows.Forms.TextBox();
            this.chkBorderCollapse = new System.Windows.Forms.CheckBox();
            this.grpSummaryDesc = new System.Windows.Forms.GroupBox();
            this.txtSummaryDescription = new System.Windows.Forms.TextBox();
            this.numCellSpacing = new System.Windows.Forms.NumericUpDown();
            this.numCellPadding = new System.Windows.Forms.NumericUpDown();
            this.chkCellSpacing = new System.Windows.Forms.CheckBox();
            this.chkCellPadding = new System.Windows.Forms.CheckBox();
            this.numBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.chkBorderWidth = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCellProperties = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grpLayout.SuspendLayout();
            this.grpHeight.SuspendLayout();
            this.grpWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            this.grpAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundPicture)).BeginInit();
            this.grpSummaryDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLayout
            // 
            this.grpLayout.Controls.Add(this.txtCaption);
            this.grpLayout.Controls.Add(this.grpHeight);
            this.grpLayout.Controls.Add(this.grpWidth);
            this.grpLayout.Controls.Add(this.chkCaption);
            this.grpLayout.Controls.Add(this.numCols);
            this.grpLayout.Controls.Add(this.numRows);
            this.grpLayout.Controls.Add(this.lblColumns);
            this.grpLayout.Controls.Add(this.lblRows);
            this.grpLayout.Location = new System.Drawing.Point(7, 12);
            this.grpLayout.Name = "grpLayout";
            this.grpLayout.Size = new System.Drawing.Size(615, 110);
            this.grpLayout.TabIndex = 0;
            this.grpLayout.TabStop = false;
            this.grpLayout.Text = "Layout";
            // 
            // txtCaption
            // 
            this.txtCaption.Enabled = false;
            this.txtCaption.Location = new System.Drawing.Point(110, 80);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(495, 20);
            this.txtCaption.TabIndex = 15;
            // 
            // grpHeight
            // 
            this.grpHeight.Controls.Add(this.cmbHeightUnit);
            this.grpHeight.Controls.Add(this.txtHeight);
            this.grpHeight.Controls.Add(this.chkHeight);
            this.grpHeight.AutoSize = true;
            this.grpHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpHeight.Location = new System.Drawing.Point(450, 19);
            this.grpHeight.Name = "grpHeight";
            this.grpHeight.Size = new System.Drawing.Size(160, 60);
            this.grpHeight.TabIndex = 14;
            this.grpHeight.TabStop = false;
            this.grpHeight.Text = "Height";
            // 
            // cmbHeightUnit
            // 
            this.cmbHeightUnit.Enabled = false;
            this.cmbHeightUnit.FormattingEnabled = true;
            this.cmbHeightUnit.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cmbHeightUnit.Location = new System.Drawing.Point(78, 36);
            this.cmbHeightUnit.Name = "cmbHeightUnit";
            this.cmbHeightUnit.Size = new System.Drawing.Size(70, 21);
            this.cmbHeightUnit.TabIndex = 8;
            // 
            // txtHeight
            // 
            this.txtHeight.Enabled = false;
            this.txtHeight.Location = new System.Drawing.Point(7, 38);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(65, 20);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.Text = "100";
            // 
            // chkHeight
            // 
            this.chkHeight.AutoSize = true;
            this.chkHeight.Location = new System.Drawing.Point(58, 19);
            this.chkHeight.Name = "chkHeight";
            this.chkHeight.Size = new System.Drawing.Size(15, 14);
            this.chkHeight.TabIndex = 20;
            this.chkHeight.UseVisualStyleBackColor = true;
            this.chkHeight.CheckedChanged += new System.EventHandler(this.chkHeight_CheckedChanged);
            // 
            // grpWidth
            // 
            this.grpWidth.Controls.Add(this.chkWidth);
            this.grpWidth.Controls.Add(this.cmbWidthUnit);
            this.grpWidth.Controls.Add(this.txtWidth);
            this.grpWidth.AutoSize = true;
            this.grpWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpWidth.Location = new System.Drawing.Point(280, 18);
            this.grpWidth.Name = "grpWidth";
            this.grpWidth.Size = new System.Drawing.Size(160, 60);
            this.grpWidth.TabIndex = 13;
            this.grpWidth.TabStop = false;
            this.grpWidth.Text = "Width";
            // 
            // chkWidth
            // 
            this.chkWidth.AutoSize = true;
            this.chkWidth.Location = new System.Drawing.Point(59, 19);
            this.chkWidth.Name = "chkWidth";
            this.chkWidth.Size = new System.Drawing.Size(15, 14);
            this.chkWidth.TabIndex = 20;
            this.chkWidth.UseVisualStyleBackColor = true;
            this.chkWidth.CheckedChanged += new System.EventHandler(this.chkWidth_CheckedChanged);
            // 
            // cmbWidthUnit
            // 
            this.cmbWidthUnit.Enabled = false;
            this.cmbWidthUnit.FormattingEnabled = true;
            this.cmbWidthUnit.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cmbWidthUnit.Location = new System.Drawing.Point(78, 36);
            this.cmbWidthUnit.Name = "cmbWidthUnit";
            this.cmbWidthUnit.Size = new System.Drawing.Size(70, 21);
            this.cmbWidthUnit.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Enabled = false;
            this.txtWidth.Location = new System.Drawing.Point(7, 38);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(65, 20);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "100";
            // 
            // chkCaption
            // 
            this.chkCaption.AutoSize = true;
            this.chkCaption.Location = new System.Drawing.Point(11, 82);
            this.chkCaption.Name = "chkCaption";
            this.chkCaption.Size = new System.Drawing.Size(62, 17);
            this.chkCaption.TabIndex = 12;
            this.chkCaption.Text = "Caption";
            this.chkCaption.UseVisualStyleBackColor = true;
            this.chkCaption.CheckedChanged += new System.EventHandler(this.chkCaption_CheckedChanged);
            // 
            // numCols
            // 
            this.numCols.Location = new System.Drawing.Point(110, 45);
            this.numCols.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(58, 20);
            this.numCols.TabIndex = 4;
            this.numCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(110, 18);
            this.numRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(58, 20);
            this.numRows.TabIndex = 3;
            this.numRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(7, 49);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 13);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(8, 22);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(37, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // grpAttributes
            // 
            this.grpAttributes.Controls.Add(this.chklnkBackgroundPicture);
            this.grpAttributes.Controls.Add(this.chklnkBgColor);
            this.grpAttributes.Controls.Add(this.chklnkBorderColor);
            this.grpAttributes.Controls.Add(this.chkBorderToAll);
            this.grpAttributes.Controls.Add(this.label2);
            this.grpAttributes.Controls.Add(this.label1);
            this.grpAttributes.Controls.Add(this.txtCss);
            this.grpAttributes.Controls.Add(this.txtClassName);
            this.grpAttributes.Controls.Add(this.cmbBorderStyle);
            this.grpAttributes.Controls.Add(this.chkBorderStyle);
            this.grpAttributes.Controls.Add(this.pbBackgroundPicture);
            this.grpAttributes.Controls.Add(this.txtBgColor);
            this.grpAttributes.Controls.Add(this.txtBorderColor);
            this.grpAttributes.Controls.Add(this.chkBorderCollapse);
            this.grpAttributes.Controls.Add(this.grpSummaryDesc);
            this.grpAttributes.Controls.Add(this.numCellSpacing);
            this.grpAttributes.Controls.Add(this.numCellPadding);
            this.grpAttributes.Controls.Add(this.chkCellSpacing);
            this.grpAttributes.Controls.Add(this.chkCellPadding);
            this.grpAttributes.Controls.Add(this.numBorderWidth);
            this.grpAttributes.Controls.Add(this.chkBorderWidth);
            this.grpAttributes.Location = new System.Drawing.Point(7, 130);
            this.grpAttributes.Name = "grpAttributes";
            this.grpAttributes.Size = new System.Drawing.Size(615, 350);
            this.grpAttributes.TabIndex = 1;
            this.grpAttributes.TabStop = false;
            this.grpAttributes.Text = "Attributes";
            // 
            // chklnkBackgroundPicture
            // 
            this.chklnkBackgroundPicture.AutoSize = true;
            this.chklnkBackgroundPicture.Checked = true;
            this.chklnkBackgroundPicture.LinkText = "Background Picture";
            this.chklnkBackgroundPicture.Location = new System.Drawing.Point(340, 38);
            this.chklnkBackgroundPicture.Margin = new System.Windows.Forms.Padding(0);
            this.chklnkBackgroundPicture.Name = "chklnkBackgroundPicture";
            this.chklnkBackgroundPicture.Size = new System.Drawing.Size(120, 20);
            this.chklnkBackgroundPicture.TabIndex = 63;
            this.chklnkBackgroundPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chklnkBackgroundPicture_LinkClicked);
            // 
            // chklnkBgColor
            // 
            this.chklnkBgColor.AutoSize = true;
            this.chklnkBgColor.Checked = true;
            this.chklnkBgColor.LinkText = "Background Color";
            this.chklnkBgColor.Location = new System.Drawing.Point(340, 17);
            this.chklnkBgColor.Margin = new System.Windows.Forms.Padding(0);
            this.chklnkBgColor.Name = "chklnkBgColor";
            this.chklnkBgColor.Size = new System.Drawing.Size(111, 20);
            this.chklnkBgColor.TabIndex = 62;
            this.chklnkBgColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chklnkBgColor_LinkClicked);
            // 
            // chklnkBorderColor
            // 
            this.chklnkBorderColor.AutoSize = true;
            this.chklnkBorderColor.Checked = true;
            this.chklnkBorderColor.LinkText = "Border Color";
            this.chklnkBorderColor.Location = new System.Drawing.Point(10, 40);
            this.chklnkBorderColor.MinimumSize = new System.Drawing.Size(120, 20);
            this.chklnkBorderColor.Margin = new System.Windows.Forms.Padding(0);
            this.chklnkBorderColor.Name = "chklnkBorderColor";
            this.chklnkBorderColor.Size = new System.Drawing.Size(86, 20);
            this.chklnkBorderColor.TabIndex = 61;
            this.chklnkBorderColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chklnkBorderColor_LinkClicked);
            // 
            // chkBorderToAll
            // 
            this.chkBorderToAll.AutoSize = true;
            this.chkBorderToAll.Checked = true;
            this.chkBorderToAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBorderToAll.Location = new System.Drawing.Point(10, 109);
            this.chkBorderToAll.Name = "chkBorderToAll";
            this.chkBorderToAll.Size = new System.Drawing.Size(121, 17);
            this.chkBorderToAll.TabIndex = 59;
            this.chkBorderToAll.Text = "Apply border to cells";
            this.chkBorderToAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "CSS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Class Name";
            // 
            // txtCss
            // 
            this.txtCss.Location = new System.Drawing.Point(110, 201);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCss.Size = new System.Drawing.Size(495, 50);
            this.txtCss.TabIndex = 57;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(110, 177);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(160, 20);
            this.txtClassName.TabIndex = 55;
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
            this.cmbBorderStyle.Location = new System.Drawing.Point(110, 63);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.SelectedIndex = 0;
            this.cmbBorderStyle.Size = new System.Drawing.Size(160, 21);
            this.cmbBorderStyle.TabIndex = 53;
            // 
            // chkBorderStyle
            // 
            this.chkBorderStyle.AutoSize = true;
            this.chkBorderStyle.Location = new System.Drawing.Point(10, 63);
            this.chkBorderStyle.Name = "chkBorderStyle";
            this.chkBorderStyle.Size = new System.Drawing.Size(83, 17);
            this.chkBorderStyle.TabIndex = 52;
            this.chkBorderStyle.Text = "Border Style";
            this.chkBorderStyle.UseVisualStyleBackColor = true;
            this.chkBorderStyle.CheckedChanged += new System.EventHandler(this.chkBorderStyle_CheckedChanged);
            // 
            // pbBackgroundPicture
            // 
            this.pbBackgroundPicture.Location = new System.Drawing.Point(340, 58);
            this.pbBackgroundPicture.Name = "pbBackgroundPicture";
            this.pbBackgroundPicture.Size = new System.Drawing.Size(270, 95);
            this.pbBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackgroundPicture.TabIndex = 21;
            this.pbBackgroundPicture.TabStop = false;
            // 
            // txtBgColor
            // 
            this.txtBgColor.BackColor = System.Drawing.Color.White;
            this.txtBgColor.Enabled = false;
            this.txtBgColor.Location = new System.Drawing.Point(495, 17);
            this.txtBgColor.Name = "txtBgColor";
            this.txtBgColor.ReadOnly = true;
            this.txtBgColor.Size = new System.Drawing.Size(115, 20);
            this.txtBgColor.TabIndex = 18;
            // 
            // txtBorderColor
            // 
            this.txtBorderColor.BackColor = System.Drawing.Color.White;
            this.txtBorderColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBorderColor.Enabled = false;
            this.txtBorderColor.Location = new System.Drawing.Point(180, 40);
            this.txtBorderColor.Name = "txtBorderColor";
            this.txtBorderColor.ReadOnly = true;
            this.txtBorderColor.Size = new System.Drawing.Size(140, 20);
            this.txtBorderColor.TabIndex = 16;
            // 
            // chkBorderCollapse
            // 
            this.chkBorderCollapse.AutoSize = true;
            this.chkBorderCollapse.Location = new System.Drawing.Point(10, 86);
            this.chkBorderCollapse.Name = "chkBorderCollapse";
            this.chkBorderCollapse.Size = new System.Drawing.Size(100, 17);
            this.chkBorderCollapse.TabIndex = 14;
            this.chkBorderCollapse.Text = "Border Collapse";
            this.chkBorderCollapse.UseVisualStyleBackColor = true;
            // 
            // grpSummaryDesc
            // 
            this.grpSummaryDesc.Controls.Add(this.txtSummaryDescription);
            this.grpSummaryDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpSummaryDesc.Location = new System.Drawing.Point(3, 261);
            this.grpSummaryDesc.Name = "grpSummaryDesc";
            this.grpSummaryDesc.Size = new System.Drawing.Size(609, 86);
            this.grpSummaryDesc.TabIndex = 13;
            this.grpSummaryDesc.TabStop = false;
            this.grpSummaryDesc.Text = "Summary Description";
            // 
            // txtSummaryDescription
            // 
            this.txtSummaryDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSummaryDescription.Location = new System.Drawing.Point(3, 16);
            this.txtSummaryDescription.Multiline = true;
            this.txtSummaryDescription.Name = "txtSummaryDescription";
            this.txtSummaryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSummaryDescription.Size = new System.Drawing.Size(603, 67);
            this.txtSummaryDescription.TabIndex = 0;
            // 
            // numCellSpacing
            // 
            this.numCellSpacing.Enabled = false;
            this.numCellSpacing.Location = new System.Drawing.Point(180, 154);
            this.numCellSpacing.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCellSpacing.Name = "numCellSpacing";
            this.numCellSpacing.Size = new System.Drawing.Size(58, 20);
            this.numCellSpacing.TabIndex = 12;
            // 
            // numCellPadding
            // 
            this.numCellPadding.Enabled = false;
            this.numCellPadding.Location = new System.Drawing.Point(180, 132);
            this.numCellPadding.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCellPadding.Name = "numCellPadding";
            this.numCellPadding.Size = new System.Drawing.Size(58, 20);
            this.numCellPadding.TabIndex = 11;
            // 
            // chkCellSpacing
            // 
            this.chkCellSpacing.AutoSize = true;
            this.chkCellSpacing.Location = new System.Drawing.Point(10, 156);
            this.chkCellSpacing.Name = "chkCellSpacing";
            this.chkCellSpacing.Size = new System.Drawing.Size(80, 17);
            this.chkCellSpacing.TabIndex = 10;
            this.chkCellSpacing.Text = "Cellspacing";
            this.chkCellSpacing.UseVisualStyleBackColor = true;
            this.chkCellSpacing.CheckedChanged += new System.EventHandler(this.chkCellSpacing_CheckedChanged);
            // 
            // chkCellPadding
            // 
            this.chkCellPadding.AutoSize = true;
            this.chkCellPadding.Location = new System.Drawing.Point(10, 134);
            this.chkCellPadding.Name = "chkCellPadding";
            this.chkCellPadding.Size = new System.Drawing.Size(81, 17);
            this.chkCellPadding.TabIndex = 9;
            this.chkCellPadding.Text = "Cellpadding";
            this.chkCellPadding.UseVisualStyleBackColor = true;
            this.chkCellPadding.CheckedChanged += new System.EventHandler(this.chkCellPadding_CheckedChanged);
            // 
            // numBorderWidth
            // 
            this.numBorderWidth.Location = new System.Drawing.Point(180, 15);
            this.numBorderWidth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numBorderWidth.Name = "numBorderWidth";
            this.numBorderWidth.Size = new System.Drawing.Size(58, 20);
            this.numBorderWidth.TabIndex = 8;
            this.numBorderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBorderWidth.ValueChanged += new System.EventHandler(this.numBorderWidth_ValueChanged);
            // 
            // chkBorderWidth
            // 
            this.chkBorderWidth.AutoSize = true;
            this.chkBorderWidth.Checked = true;
            this.chkBorderWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBorderWidth.Location = new System.Drawing.Point(10, 20);
            this.chkBorderWidth.Name = "chkBorderWidth";
            this.chkBorderWidth.Size = new System.Drawing.Size(88, 17);
            this.chkBorderWidth.TabIndex = 7;
            this.chkBorderWidth.Text = "Border Width";
            this.chkBorderWidth.UseVisualStyleBackColor = true;
            this.chkBorderWidth.CheckedChanged += new System.EventHandler(this.chkBorderWidth_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(530, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 3;
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
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(436, 490);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCellProperties
            // 
            this.btnCellProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCellProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCellProperties.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCellProperties.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCellProperties.AutoSize = true;
            this.btnCellProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCellProperties.Location = new System.Drawing.Point(7, 490);
            this.btnCellProperties.MinimumSize = new System.Drawing.Size(180, 23);
            this.btnCellProperties.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnCellProperties.Name = "btnCellProperties";
            this.btnCellProperties.Size = new System.Drawing.Size(180, 23);
            this.btnCellProperties.TabIndex = 4;
            this.btnCellProperties.Text = "Cell properties";
            this.btnCellProperties.UseVisualStyleBackColor = true;
            this.btnCellProperties.Click += new System.EventHandler(this.btnCellProperties_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(286, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(118, 20);
            this.txtId.TabIndex = 1;
            // 
            // TablePropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 520);
            this.ControlBox = false;
            this.Controls.Add(this.grpAttributes);
            this.Controls.Add(this.grpLayout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCellProperties);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TablePropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Properties";
            this.Load += new System.EventHandler(this.TablePropertiesDialog_Load);
            this.grpLayout.ResumeLayout(false);
            this.grpLayout.PerformLayout();
            this.grpHeight.ResumeLayout(false);
            this.grpHeight.PerformLayout();
            this.grpWidth.ResumeLayout(false);
            this.grpWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            this.grpAttributes.ResumeLayout(false);
            this.grpAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundPicture)).EndInit();
            this.grpSummaryDesc.ResumeLayout(false);
            this.grpSummaryDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpLayout;
        private GroupBox grpAttributes;
        private NumericUpDown numRows;
        private Label lblColumns;
        private Label lblRows;
        private NumericUpDown numCols;
        private ComboBox cmbWidthUnit;
        private TextBox txtWidth;
        private CheckBox chkCaption;
        private CheckBox chkBorderWidth;
        private GroupBox grpSummaryDesc;
        private TextBox txtSummaryDescription;
        private NumericUpDown numCellSpacing;
        private NumericUpDown numCellPadding;
        private NumericUpDown numBorderWidth;
        private CheckBox chkBorderCollapse;
        private TextBox txtBgColor;
        private TextBox txtBorderColor;
        private PictureBox pbBackgroundPicture;
        private Button btnCancel;
        private Button btnOK;
        private GroupBox grpHeight;
        private CheckBox chkHeight;
        private ComboBox cmbHeightUnit;
        private TextBox txtHeight;
        private GroupBox grpWidth;
        private CheckBox chkWidth;
        private Button btnCellProperties;
        private TextBox txtCaption;
        private CheckBox chkCellSpacing;
        private CheckBox chkCellPadding;
        private ComboBox cmbBorderStyle;
        private CheckBox chkBorderStyle;
        private TextBox txtCss;
        private TextBox txtClassName;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private CheckBox chkBorderToAll;
        private CheckboxWithLinklabel chklnkBorderColor;
        private CheckboxWithLinklabel chklnkBackgroundPicture;
        private CheckboxWithLinklabel chklnkBgColor;

    }
}