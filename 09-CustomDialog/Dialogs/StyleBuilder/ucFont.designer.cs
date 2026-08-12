using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucFont
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
            this.gbFontName = new System.Windows.Forms.GroupBox();
            this.btFontFamilySelect = new System.Windows.Forms.Button();
            this.rbSystemFont = new System.Windows.Forms.RadioButton();
            this.rbFamily = new System.Windows.Forms.RadioButton();
            this.cbSystemFont = new System.Windows.Forms.ComboBox();
            this.tbFontFamily = new System.Windows.Forms.TextBox();
            this.gbFontAttributes = new System.Windows.Forms.GroupBox();
            this.txtForeColor = new System.Windows.Forms.TextBox();
            this.cbFontVariant = new System.Windows.Forms.ComboBox();
            this.cbFontStyle = new System.Windows.Forms.ComboBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSizeRelative = new System.Windows.Forms.RadioButton();
            this.cbRelativeSize = new System.Windows.Forms.ComboBox();
            this.cbAbsoluteSize = new System.Windows.Forms.ComboBox();
            this.rbSizeAbsolute = new System.Windows.Forms.RadioButton();
            this.cbSpecificSizeType = new System.Windows.Forms.ComboBox();
            this.tbSpecificSize = new System.Windows.Forms.TextBox();
            this.rbSizeSpecific = new System.Windows.Forms.RadioButton();
            this.gbEffects = new System.Windows.Forms.GroupBox();
            this.cbEffectOverline = new System.Windows.Forms.CheckBox();
            this.cbEffectUnderline = new System.Windows.Forms.CheckBox();
            this.cbEffectStrikethrough = new System.Windows.Forms.CheckBox();
            this.cbEffectNone = new System.Windows.Forms.CheckBox();
            this.dlgColorPicker = new System.Windows.Forms.ColorDialog();
            this.gbBold = new System.Windows.Forms.GroupBox();
            this.rbBoldRelative = new System.Windows.Forms.RadioButton();
            this.rbBoldAbsolute = new System.Windows.Forms.RadioButton();
            this.cbBoldRelative = new System.Windows.Forms.ComboBox();
            this.cbBoldAbsolute = new System.Windows.Forms.ComboBox();
            this.gbCapitalization = new System.Windows.Forms.GroupBox();
            this.cbCapitalization = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbFontName.SuspendLayout();
            this.gbFontAttributes.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbEffects.SuspendLayout();
            this.gbBold.SuspendLayout();
            this.gbCapitalization.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFontName
            // 
            this.gbFontName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFontName.Controls.Add(this.btFontFamilySelect);
            this.gbFontName.Controls.Add(this.rbSystemFont);
            this.gbFontName.Controls.Add(this.rbFamily);
            this.gbFontName.Controls.Add(this.cbSystemFont);
            this.gbFontName.Controls.Add(this.tbFontFamily);
            this.gbFontName.Location = new System.Drawing.Point(3, 3);
            this.gbFontName.Name = "gbFontName";
            this.gbFontName.Size = new System.Drawing.Size(454, 77);
            this.gbFontName.TabIndex = 0;
            this.gbFontName.TabStop = false;
            this.gbFontName.Text = "&Font name";
            // 
            // btFontFamilySelect
            // 
            this.btFontFamilySelect.Location = new System.Drawing.Point(368, 21);
            this.btFontFamilySelect.Name = "btFontFamilySelect";
            this.btFontFamilySelect.Size = new System.Drawing.Size(37, 23);
            this.btFontFamilySelect.TabIndex = 2;
            this.btFontFamilySelect.Text = "...";
            this.btFontFamilySelect.UseVisualStyleBackColor = true;
            this.btFontFamilySelect.Click += new System.EventHandler(this.btFontFamilySelect_Click);
            // 
            // rbSystemFont
            // 
            this.rbSystemFont.AutoSize = true;
            this.rbSystemFont.Location = new System.Drawing.Point(6, 51);
            this.rbSystemFont.Name = "rbSystemFont";
            this.rbSystemFont.Size = new System.Drawing.Size(83, 17);
            this.rbSystemFont.TabIndex = 3;
            this.rbSystemFont.Text = "System font:";
            this.rbSystemFont.UseVisualStyleBackColor = true;
            this.rbSystemFont.CheckedChanged += new System.EventHandler(this.FontTypeChanged);
            // 
            // rbFamily
            // 
            this.rbFamily.AutoSize = true;
            this.rbFamily.Checked = true;
            this.rbFamily.Location = new System.Drawing.Point(6, 20);
            this.rbFamily.Name = "rbFamily";
            this.rbFamily.Size = new System.Drawing.Size(54, 17);
            this.rbFamily.TabIndex = 0;
            this.rbFamily.TabStop = true;
            this.rbFamily.Text = "Family";
            this.rbFamily.UseVisualStyleBackColor = true;
            this.rbFamily.CheckedChanged += new System.EventHandler(this.FontTypeChanged);
            // 
            // cbSystemFont
            // 
            this.cbSystemFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSystemFont.FormattingEnabled = true;
            this.cbSystemFont.Location = new System.Drawing.Point(95, 50);
            this.cbSystemFont.Name = "cbSystemFont";
            this.cbSystemFont.Size = new System.Drawing.Size(310, 21);
            this.cbSystemFont.TabIndex = 4;
            // 
            // tbFontFamily
            // 
            this.tbFontFamily.Location = new System.Drawing.Point(95, 21);
            this.tbFontFamily.Name = "tbFontFamily";
            this.tbFontFamily.Size = new System.Drawing.Size(267, 20);
            this.tbFontFamily.TabIndex = 1;
            // 
            // gbFontAttributes
            // 
            this.gbFontAttributes.Controls.Add(this.txtForeColor);
            this.gbFontAttributes.Location = new System.Drawing.Point(9, 122);
            this.gbFontAttributes.Name = "gbFontAttributes";
            this.gbFontAttributes.Size = new System.Drawing.Size(49, 39);
            this.gbFontAttributes.TabIndex = 1;
            this.gbFontAttributes.TabStop = false;
            this.gbFontAttributes.Text = "Color";
            // 
            // txtForeColor
            // 
            this.txtForeColor.BackColor = System.Drawing.Color.Black;
            this.txtForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtForeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtForeColor.Location = new System.Drawing.Point(3, 16);
            this.txtForeColor.Name = "txtForeColor";
            this.txtForeColor.ReadOnly = true;
            this.txtForeColor.Size = new System.Drawing.Size(43, 20);
            this.txtForeColor.TabIndex = 7;
            this.txtForeColor.Click += new System.EventHandler(this.txtForeColor_Click);
            // 
            // cbFontVariant
            // 
            this.cbFontVariant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFontVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontVariant.FormattingEnabled = true;
            this.cbFontVariant.Location = new System.Drawing.Point(3, 16);
            this.cbFontVariant.Name = "cbFontVariant";
            this.cbFontVariant.Size = new System.Drawing.Size(80, 21);
            this.cbFontVariant.TabIndex = 6;
            // 
            // cbFontStyle
            // 
            this.cbFontStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontStyle.FormattingEnabled = true;
            this.cbFontStyle.Location = new System.Drawing.Point(3, 16);
            this.cbFontStyle.Name = "cbFontStyle";
            this.cbFontStyle.Size = new System.Drawing.Size(109, 21);
            this.cbFontStyle.TabIndex = 4;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSizeRelative);
            this.gbSize.Controls.Add(this.cbRelativeSize);
            this.gbSize.Controls.Add(this.cbAbsoluteSize);
            this.gbSize.Controls.Add(this.rbSizeAbsolute);
            this.gbSize.Controls.Add(this.cbSpecificSizeType);
            this.gbSize.Controls.Add(this.tbSpecificSize);
            this.gbSize.Controls.Add(this.rbSizeSpecific);
            this.gbSize.Location = new System.Drawing.Point(3, 207);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(215, 110);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "&Size";
            // 
            // rbSizeRelative
            // 
            this.rbSizeRelative.AutoSize = true;
            this.rbSizeRelative.Location = new System.Drawing.Point(6, 74);
            this.rbSizeRelative.Name = "rbSizeRelative";
            this.rbSizeRelative.Size = new System.Drawing.Size(64, 17);
            this.rbSizeRelative.TabIndex = 5;
            this.rbSizeRelative.TabStop = true;
            this.rbSizeRelative.Text = "Relative";
            this.rbSizeRelative.UseVisualStyleBackColor = true;
            this.rbSizeRelative.CheckedChanged += new System.EventHandler(this.rbSizeRelative_CheckedChanged);
            // 
            // cbRelativeSize
            // 
            this.cbRelativeSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRelativeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelativeSize.FormattingEnabled = true;
            this.cbRelativeSize.Items.AddRange(new object[] {
            "Larger",
            "Smaller"});
            this.cbRelativeSize.Location = new System.Drawing.Point(95, 73);
            this.cbRelativeSize.Name = "cbRelativeSize";
            this.cbRelativeSize.Size = new System.Drawing.Size(114, 21);
            this.cbRelativeSize.TabIndex = 6;
            // 
            // cbAbsoluteSize
            // 
            this.cbAbsoluteSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbsoluteSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbsoluteSize.FormattingEnabled = true;
            this.cbAbsoluteSize.Items.AddRange(new object[] {
            "XX-Small",
            "X-Small",
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "XX-Large"});
            this.cbAbsoluteSize.Location = new System.Drawing.Point(95, 46);
            this.cbAbsoluteSize.Name = "cbAbsoluteSize";
            this.cbAbsoluteSize.Size = new System.Drawing.Size(114, 21);
            this.cbAbsoluteSize.TabIndex = 4;
            // 
            // rbSizeAbsolute
            // 
            this.rbSizeAbsolute.AutoSize = true;
            this.rbSizeAbsolute.Location = new System.Drawing.Point(6, 47);
            this.rbSizeAbsolute.Name = "rbSizeAbsolute";
            this.rbSizeAbsolute.Size = new System.Drawing.Size(66, 17);
            this.rbSizeAbsolute.TabIndex = 3;
            this.rbSizeAbsolute.TabStop = true;
            this.rbSizeAbsolute.Text = "Absolute";
            this.rbSizeAbsolute.UseVisualStyleBackColor = true;
            this.rbSizeAbsolute.CheckedChanged += new System.EventHandler(this.rbSizeAbsolute_CheckedChanged);
            // 
            // cbSpecificSizeType
            // 
            this.cbSpecificSizeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpecificSizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecificSizeType.FormattingEnabled = true;
            this.cbSpecificSizeType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbSpecificSizeType.Location = new System.Drawing.Point(144, 19);
            this.cbSpecificSizeType.Name = "cbSpecificSizeType";
            this.cbSpecificSizeType.Size = new System.Drawing.Size(65, 21);
            this.cbSpecificSizeType.TabIndex = 2;
            // 
            // tbSpecificSize
            // 
            this.tbSpecificSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecificSize.Location = new System.Drawing.Point(95, 19);
            this.tbSpecificSize.Name = "tbSpecificSize";
            this.tbSpecificSize.Size = new System.Drawing.Size(43, 20);
            this.tbSpecificSize.TabIndex = 1;
            // 
            // rbSizeSpecific
            // 
            this.rbSizeSpecific.AutoSize = true;
            this.rbSizeSpecific.Checked = true;
            this.rbSizeSpecific.Location = new System.Drawing.Point(6, 20);
            this.rbSizeSpecific.Name = "rbSizeSpecific";
            this.rbSizeSpecific.Size = new System.Drawing.Size(63, 17);
            this.rbSizeSpecific.TabIndex = 0;
            this.rbSizeSpecific.TabStop = true;
            this.rbSizeSpecific.Text = "Specific";
            this.rbSizeSpecific.UseVisualStyleBackColor = true;
            this.rbSizeSpecific.CheckedChanged += new System.EventHandler(this.rbSizeSpecific_CheckedChanged);
            // 
            // gbEffects
            // 
            this.gbEffects.Controls.Add(this.cbEffectOverline);
            this.gbEffects.Controls.Add(this.cbEffectUnderline);
            this.gbEffects.Controls.Add(this.cbEffectStrikethrough);
            this.gbEffects.Controls.Add(this.cbEffectNone);
            this.gbEffects.Location = new System.Drawing.Point(347, 189);
            this.gbEffects.Name = "gbEffects";
            this.gbEffects.Size = new System.Drawing.Size(98, 128);
            this.gbEffects.TabIndex = 3;
            this.gbEffects.TabStop = false;
            this.gbEffects.Text = "Effects";
            // 
            // cbEffectOverline
            // 
            this.cbEffectOverline.AutoSize = true;
            this.cbEffectOverline.Location = new System.Drawing.Point(6, 85);
            this.cbEffectOverline.Name = "cbEffectOverline";
            this.cbEffectOverline.Size = new System.Drawing.Size(65, 17);
            this.cbEffectOverline.TabIndex = 3;
            this.cbEffectOverline.Text = "Overline";
            this.cbEffectOverline.UseVisualStyleBackColor = true;
            // 
            // cbEffectUnderline
            // 
            this.cbEffectUnderline.AutoSize = true;
            this.cbEffectUnderline.Location = new System.Drawing.Point(6, 39);
            this.cbEffectUnderline.Name = "cbEffectUnderline";
            this.cbEffectUnderline.Size = new System.Drawing.Size(71, 17);
            this.cbEffectUnderline.TabIndex = 1;
            this.cbEffectUnderline.Text = "Underline";
            this.cbEffectUnderline.UseVisualStyleBackColor = true;
            // 
            // cbEffectStrikethrough
            // 
            this.cbEffectStrikethrough.AutoSize = true;
            this.cbEffectStrikethrough.Location = new System.Drawing.Point(6, 62);
            this.cbEffectStrikethrough.Name = "cbEffectStrikethrough";
            this.cbEffectStrikethrough.Size = new System.Drawing.Size(89, 17);
            this.cbEffectStrikethrough.TabIndex = 2;
            this.cbEffectStrikethrough.Text = "Strikethrough";
            this.cbEffectStrikethrough.UseVisualStyleBackColor = true;
            // 
            // cbEffectNone
            // 
            this.cbEffectNone.AutoSize = true;
            this.cbEffectNone.Location = new System.Drawing.Point(6, 19);
            this.cbEffectNone.Name = "cbEffectNone";
            this.cbEffectNone.Size = new System.Drawing.Size(52, 17);
            this.cbEffectNone.TabIndex = 0;
            this.cbEffectNone.Text = "None";
            this.cbEffectNone.UseVisualStyleBackColor = true;
            this.cbEffectNone.CheckedChanged += new System.EventHandler(this.cbEffectNone_CheckedChanged);
            // 
            // dlgColorPicker
            // 
            this.dlgColorPicker.AnyColor = true;
            this.dlgColorPicker.FullOpen = true;
            // 
            // gbBold
            // 
            this.gbBold.Controls.Add(this.rbBoldRelative);
            this.gbBold.Controls.Add(this.rbBoldAbsolute);
            this.gbBold.Controls.Add(this.cbBoldRelative);
            this.gbBold.Controls.Add(this.cbBoldAbsolute);
            this.gbBold.Location = new System.Drawing.Point(67, 103);
            this.gbBold.Name = "gbBold";
            this.gbBold.Size = new System.Drawing.Size(204, 82);
            this.gbBold.TabIndex = 4;
            this.gbBold.TabStop = false;
            this.gbBold.Text = "Bold";
            // 
            // rbBoldRelative
            // 
            this.rbBoldRelative.AutoSize = true;
            this.rbBoldRelative.Location = new System.Drawing.Point(6, 47);
            this.rbBoldRelative.Name = "rbBoldRelative";
            this.rbBoldRelative.Size = new System.Drawing.Size(64, 17);
            this.rbBoldRelative.TabIndex = 3;
            this.rbBoldRelative.TabStop = true;
            this.rbBoldRelative.Text = "Relative";
            this.rbBoldRelative.UseVisualStyleBackColor = true;
            this.rbBoldRelative.CheckedChanged += new System.EventHandler(this.rbBoldRadioButtonChanged);
            // 
            // rbBoldAbsolute
            // 
            this.rbBoldAbsolute.AutoSize = true;
            this.rbBoldAbsolute.Checked = true;
            this.rbBoldAbsolute.Location = new System.Drawing.Point(6, 20);
            this.rbBoldAbsolute.Name = "rbBoldAbsolute";
            this.rbBoldAbsolute.Size = new System.Drawing.Size(66, 17);
            this.rbBoldAbsolute.TabIndex = 2;
            this.rbBoldAbsolute.TabStop = true;
            this.rbBoldAbsolute.Text = "Absolute";
            this.rbBoldAbsolute.UseVisualStyleBackColor = true;
            this.rbBoldAbsolute.CheckedChanged += new System.EventHandler(this.rbBoldRadioButtonChanged);
            // 
            // cbBoldRelative
            // 
            this.cbBoldRelative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoldRelative.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoldRelative.FormattingEnabled = true;
            this.cbBoldRelative.Location = new System.Drawing.Point(95, 46);
            this.cbBoldRelative.Name = "cbBoldRelative";
            this.cbBoldRelative.Size = new System.Drawing.Size(103, 21);
            this.cbBoldRelative.TabIndex = 1;
            // 
            // cbBoldAbsolute
            // 
            this.cbBoldAbsolute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoldAbsolute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoldAbsolute.FormattingEnabled = true;
            this.cbBoldAbsolute.Location = new System.Drawing.Point(95, 19);
            this.cbBoldAbsolute.Name = "cbBoldAbsolute";
            this.cbBoldAbsolute.Size = new System.Drawing.Size(103, 21);
            this.cbBoldAbsolute.TabIndex = 0;
            // 
            // gbCapitalization
            // 
            this.gbCapitalization.Controls.Add(this.cbCapitalization);
            this.gbCapitalization.Location = new System.Drawing.Point(240, 202);
            this.gbCapitalization.Name = "gbCapitalization";
            this.gbCapitalization.Size = new System.Drawing.Size(86, 40);
            this.gbCapitalization.TabIndex = 5;
            this.gbCapitalization.TabStop = false;
            this.gbCapitalization.Text = "Capitalization";
            // 
            // cbCapitalization
            // 
            this.cbCapitalization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCapitalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapitalization.FormattingEnabled = true;
            this.cbCapitalization.Location = new System.Drawing.Point(3, 16);
            this.cbCapitalization.Name = "cbCapitalization";
            this.cbCapitalization.Size = new System.Drawing.Size(80, 21);
            this.cbCapitalization.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFontStyle);
            this.groupBox1.Location = new System.Drawing.Point(330, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Italic";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFontVariant);
            this.groupBox2.Location = new System.Drawing.Point(240, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 43);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Small caps";
            // 
            // ucFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCapitalization);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBold);
            this.Controls.Add(this.gbEffects);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbFontAttributes);
            this.Controls.Add(this.gbFontName);
            this.Name = "UcFont";
            this.Size = new System.Drawing.Size(460, 380);
            this.Load += new System.EventHandler(this.ucFont_Load);
            this.gbFontName.ResumeLayout(false);
            this.gbFontName.PerformLayout();
            this.gbFontAttributes.ResumeLayout(false);
            this.gbFontAttributes.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbEffects.ResumeLayout(false);
            this.gbEffects.PerformLayout();
            this.gbBold.ResumeLayout(false);
            this.gbBold.PerformLayout();
            this.gbCapitalization.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbFontName;
        private Button btFontFamilySelect;
        private RadioButton rbSystemFont;
        private RadioButton rbFamily;
        private ComboBox cbSystemFont;
        private TextBox tbFontFamily;
        private GroupBox gbFontAttributes;
        private ComboBox cbFontVariant;
        private ComboBox cbFontStyle;
        private GroupBox gbSize;
        private RadioButton rbSizeRelative;
        private ComboBox cbRelativeSize;
        private ComboBox cbAbsoluteSize;
        private RadioButton rbSizeAbsolute;
        private ComboBox cbSpecificSizeType;
        private TextBox tbSpecificSize;
        private RadioButton rbSizeSpecific;
        private GroupBox gbEffects;
        private CheckBox cbEffectOverline;
        private CheckBox cbEffectUnderline;
        private CheckBox cbEffectStrikethrough;
        private CheckBox cbEffectNone;
        private ColorDialog dlgColorPicker;
        private GroupBox gbBold;
        private RadioButton rbBoldRelative;
        private RadioButton rbBoldAbsolute;
        private ComboBox cbBoldRelative;
        private ComboBox cbBoldAbsolute;
        private GroupBox gbCapitalization;
        private ComboBox cbCapitalization;
        private TextBox txtForeColor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
