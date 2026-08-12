using System.ComponentModel;
using System.Windows.Forms;
using SpiceLogic.HtmlEditor.WinForms.Helpers.Controls;

namespace CustomDialog.Dialogs
{
    public partial class TableCellPropertiesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCellPropertiesDialog));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.cmbHeightUnit = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkWidth = new System.Windows.Forms.CheckBox();
            this.cmbWidthUnit = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHorizontalAlign = new System.Windows.Forms.ComboBox();
            this.cmbVerticalAlign = new System.Windows.Forms.ComboBox();
            this.chkNoWrap = new System.Windows.Forms.CheckBox();
            this.txtBgColor = new System.Windows.Forms.TextBox();
            this.chkOverrideSettings4Cells = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.chklnkBgColor = new CheckboxWithLinklabel();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(345, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 5;
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
            this.btnOK.Location = new System.Drawing.Point(255, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkHeight);
            this.groupBox5.Controls.Add(this.cmbHeightUnit);
            this.groupBox5.Controls.Add(this.txtHeight);
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Location = new System.Drawing.Point(220, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 60);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Height";
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
            // cmbHeightUnit
            // 
            this.cmbHeightUnit.Enabled = false;
            this.cmbHeightUnit.FormattingEnabled = true;
            this.cmbHeightUnit.Items.AddRange(new object[] {
            "px",
            "%"});
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkWidth);
            this.groupBox4.Controls.Add(this.cmbWidthUnit);
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Location = new System.Drawing.Point(15, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 60);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Width";
            // 
            // chkWidth
            // 
            this.chkWidth.AutoSize = true;
            this.chkWidth.Location = new System.Drawing.Point(56, 19);
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
            "%"});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Horizontal Align";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vertical Align";
            // 
            // cmbHorizontalAlign
            // 
            this.cmbHorizontalAlign.FormattingEnabled = true;
            this.cmbHorizontalAlign.Items.AddRange(new object[] {
            "NotSet",
            "right",
            "center",
            "left",
            "middle"});
            this.cmbHorizontalAlign.Location = new System.Drawing.Point(220, 80);
            this.cmbHorizontalAlign.Name = "cmbHorizontalAlign";
            this.cmbHorizontalAlign.Size = new System.Drawing.Size(160, 21);
            this.cmbHorizontalAlign.TabIndex = 19;
            // 
            // cmbVerticalAlign
            // 
            this.cmbVerticalAlign.FormattingEnabled = true;
            this.cmbVerticalAlign.Items.AddRange(new object[] {
            "NotSet",
            "top",
            "middle",
            "bottom",
            "baseline"});
            this.cmbVerticalAlign.Location = new System.Drawing.Point(220, 107);
            this.cmbVerticalAlign.Name = "cmbVerticalAlign";
            this.cmbVerticalAlign.Size = new System.Drawing.Size(160, 21);
            this.cmbVerticalAlign.TabIndex = 20;
            // 
            // chkNoWrap
            // 
            this.chkNoWrap.AutoSize = true;
            this.chkNoWrap.Location = new System.Drawing.Point(9, 145);
            this.chkNoWrap.Name = "chkNoWrap";
            this.chkNoWrap.Size = new System.Drawing.Size(69, 17);
            this.chkNoWrap.TabIndex = 21;
            this.chkNoWrap.Text = "No Wrap";
            this.chkNoWrap.UseVisualStyleBackColor = true;
            // 
            // txtBgColor
            // 
            this.txtBgColor.BackColor = System.Drawing.Color.White;
            this.txtBgColor.Enabled = false;
            this.txtBgColor.Location = new System.Drawing.Point(290, 145);
            this.txtBgColor.Name = "txtBgColor";
            this.txtBgColor.ReadOnly = true;
            this.txtBgColor.Size = new System.Drawing.Size(90, 20);
            this.txtBgColor.TabIndex = 25;
            // 
            // chkOverrideSettings4Cells
            // 
            this.chkOverrideSettings4Cells.AutoSize = true;
            this.chkOverrideSettings4Cells.Location = new System.Drawing.Point(9, 175);
            this.chkOverrideSettings4Cells.Name = "chkOverrideSettings4Cells";
            this.chkOverrideSettings4Cells.Size = new System.Drawing.Size(157, 17);
            this.chkOverrideSettings4Cells.TabIndex = 27;
            this.chkOverrideSettings4Cells.Text = "Overrride settings to all cells";
            this.chkOverrideSettings4Cells.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Class Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CSS";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(110, 202);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(270, 20);
            this.txtClassName.TabIndex = 29;
            // 
            // txtCss
            // 
            this.txtCss.Location = new System.Drawing.Point(110, 226);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCss.Size = new System.Drawing.Size(270, 49);
            this.txtCss.TabIndex = 29;
            // 
            // chklnkBgColor
            // 
            this.chklnkBgColor.AutoSize = true;
            this.chklnkBgColor.Checked = false;
            this.chklnkBgColor.LinkText = "Background Color";
            this.chklnkBgColor.Location = new System.Drawing.Point(160, 145);
            this.chklnkBgColor.Margin = new System.Windows.Forms.Padding(0);
            this.chklnkBgColor.Name = "chklnkBgColor";
            this.chklnkBgColor.Size = new System.Drawing.Size(113, 20);
            this.chklnkBgColor.TabIndex = 30;
            this.chklnkBgColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chklnkBgColor_LinkClicked);
            // 
            // TableCellPropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.ControlBox = false;
            this.Controls.Add(this.chklnkBgColor);
            this.Controls.Add(this.txtCss);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkOverrideSettings4Cells);
            this.Controls.Add(this.txtBgColor);
            this.Controls.Add(this.chkNoWrap);
            this.Controls.Add(this.cmbVerticalAlign);
            this.Controls.Add(this.cmbHorizontalAlign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "TableCellPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Cell Properties";
            this.Load += new System.EventHandler(this.TableCellPropertiesDialog_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private GroupBox groupBox5;
        private CheckBox chkHeight;
        private ComboBox cmbHeightUnit;
        private TextBox txtHeight;
        private GroupBox groupBox4;
        private CheckBox chkWidth;
        private ComboBox cmbWidthUnit;
        private TextBox txtWidth;
        private Label label1;
        private Label label2;
        private ComboBox cmbHorizontalAlign;
        private ComboBox cmbVerticalAlign;
        private CheckBox chkNoWrap;
        private TextBox txtBgColor;
        private CheckBox chkOverrideSettings4Cells;
        private Label label3;
        private Label label4;
        private TextBox txtClassName;
        private TextBox txtCss;
        private CheckboxWithLinklabel chklnkBgColor;
    }
}