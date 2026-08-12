using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucBackground
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
            this.gbBackgroundColor = new System.Windows.Forms.GroupBox();
            this.txtBgColor = new System.Windows.Forms.TextBox();
            this.cbBgColorTransparent = new System.Windows.Forms.CheckBox();
            this.gbBackgroundImage = new System.Windows.Forms.GroupBox();
            this.cbDoNotUseBackground = new System.Windows.Forms.CheckBox();
            this.lScrolling = new System.Windows.Forms.Label();
            this.bTiling = new System.Windows.Forms.Label();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.lVertical = new System.Windows.Forms.Label();
            this.lHorizontal = new System.Windows.Forms.Label();
            this.tbVerCust = new System.Windows.Forms.TextBox();
            this.tbHorCust = new System.Windows.Forms.TextBox();
            this.cbVerCustType = new System.Windows.Forms.ComboBox();
            this.cbVertical = new System.Windows.Forms.ComboBox();
            this.cbHorCustType = new System.Windows.Forms.ComboBox();
            this.cbHorizontal = new System.Windows.Forms.ComboBox();
            this.cbScrolling = new System.Windows.Forms.ComboBox();
            this.cbTiling = new System.Windows.Forms.ComboBox();
            this.lBgImageFile = new System.Windows.Forms.Label();
            this.tbBgImage = new System.Windows.Forms.TextBox();
            this.btChooseBgImage = new System.Windows.Forms.Button();
            this.dlgColorPicker = new System.Windows.Forms.ColorDialog();
            this.dlgBgImage = new System.Windows.Forms.OpenFileDialog();
            this.gbBackgroundColor.SuspendLayout();
            this.gbBackgroundImage.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBackgroundColor
            // 
            this.gbBackgroundColor.Controls.Add(this.txtBgColor);
            this.gbBackgroundColor.Controls.Add(this.cbBgColorTransparent);
            this.gbBackgroundColor.Location = new System.Drawing.Point(3, 3);
            this.gbBackgroundColor.Name = "gbBackgroundColor";
            this.gbBackgroundColor.Size = new System.Drawing.Size(454, 50);
            this.gbBackgroundColor.TabIndex = 0;
            this.gbBackgroundColor.TabStop = false;
            this.gbBackgroundColor.Text = "Background color";
            // 
            // txtBgColor
            // 
            this.txtBgColor.BackColor = System.Drawing.Color.White;
            this.txtBgColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBgColor.Enabled = false;
            this.txtBgColor.Location = new System.Drawing.Point(9, 21);
            this.txtBgColor.Name = "txtBgColor";
            this.txtBgColor.ReadOnly = true;
            this.txtBgColor.Size = new System.Drawing.Size(36, 20);
            this.txtBgColor.TabIndex = 7;
            this.txtBgColor.Click += new System.EventHandler(this.txtBgColor_Click);
            // 
            // cbBgColorTransparent
            // 
            this.cbBgColorTransparent.AutoSize = true;
            this.cbBgColorTransparent.Checked = true;
            this.cbBgColorTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBgColorTransparent.Location = new System.Drawing.Point(66, 23);
            this.cbBgColorTransparent.Name = "cbBgColorTransparent";
            this.cbBgColorTransparent.Size = new System.Drawing.Size(83, 17);
            this.cbBgColorTransparent.TabIndex = 3;
            this.cbBgColorTransparent.Text = "Transparent";
            this.cbBgColorTransparent.UseVisualStyleBackColor = true;
            this.cbBgColorTransparent.CheckedChanged += new System.EventHandler(this.cbBgColorTransparent_CheckedChanged);
            // 
            // gbBackgroundImage
            // 
            this.gbBackgroundImage.Controls.Add(this.cbDoNotUseBackground);
            this.gbBackgroundImage.Controls.Add(this.lScrolling);
            this.gbBackgroundImage.Controls.Add(this.bTiling);
            this.gbBackgroundImage.Controls.Add(this.gbPosition);
            this.gbBackgroundImage.Controls.Add(this.cbScrolling);
            this.gbBackgroundImage.Controls.Add(this.cbTiling);
            this.gbBackgroundImage.Controls.Add(this.lBgImageFile);
            this.gbBackgroundImage.Controls.Add(this.tbBgImage);
            this.gbBackgroundImage.Controls.Add(this.btChooseBgImage);
            this.gbBackgroundImage.Location = new System.Drawing.Point(3, 86);
            this.gbBackgroundImage.Name = "gbBackgroundImage";
            this.gbBackgroundImage.Size = new System.Drawing.Size(454, 291);
            this.gbBackgroundImage.TabIndex = 1;
            this.gbBackgroundImage.TabStop = false;
            this.gbBackgroundImage.Text = "Background Image";
            // 
            // cbDoNotUseBackground
            // 
            this.cbDoNotUseBackground.AutoSize = true;
            this.cbDoNotUseBackground.Location = new System.Drawing.Point(6, 190);
            this.cbDoNotUseBackground.Name = "cbDoNotUseBackground";
            this.cbDoNotUseBackground.Size = new System.Drawing.Size(169, 17);
            this.cbDoNotUseBackground.TabIndex = 8;
            this.cbDoNotUseBackground.Text = "&Do not use background image";
            this.cbDoNotUseBackground.UseVisualStyleBackColor = true;
            this.cbDoNotUseBackground.CheckedChanged += new System.EventHandler(this.cbDoNotUseBackground_CheckedChanged);
            // 
            // lScrolling
            // 
            this.lScrolling.AutoSize = true;
            this.lScrolling.Location = new System.Drawing.Point(132, 78);
            this.lScrolling.Name = "lScrolling";
            this.lScrolling.Size = new System.Drawing.Size(50, 13);
            this.lScrolling.TabIndex = 5;
            this.lScrolling.Text = "&Scrolling:";
            // 
            // bTiling
            // 
            this.bTiling.AutoSize = true;
            this.bTiling.Location = new System.Drawing.Point(132, 51);
            this.bTiling.Name = "bTiling";
            this.bTiling.Size = new System.Drawing.Size(35, 13);
            this.bTiling.TabIndex = 3;
            this.bTiling.Text = "&Tiling:";
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.lVertical);
            this.gbPosition.Controls.Add(this.lHorizontal);
            this.gbPosition.Controls.Add(this.tbVerCust);
            this.gbPosition.Controls.Add(this.tbHorCust);
            this.gbPosition.Controls.Add(this.cbVerCustType);
            this.gbPosition.Controls.Add(this.cbVertical);
            this.gbPosition.Controls.Add(this.cbHorCustType);
            this.gbPosition.Controls.Add(this.cbHorizontal);
            this.gbPosition.Location = new System.Drawing.Point(114, 102);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(334, 82);
            this.gbPosition.TabIndex = 7;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Position";
            // 
            // lVertical
            // 
            this.lVertical.AutoSize = true;
            this.lVertical.Location = new System.Drawing.Point(18, 49);
            this.lVertical.Name = "lVertical";
            this.lVertical.Size = new System.Drawing.Size(45, 13);
            this.lVertical.TabIndex = 4;
            this.lVertical.Text = "&Vertical:";
            // 
            // lHorizontal
            // 
            this.lHorizontal.AutoSize = true;
            this.lHorizontal.Location = new System.Drawing.Point(18, 22);
            this.lHorizontal.Name = "lHorizontal";
            this.lHorizontal.Size = new System.Drawing.Size(57, 13);
            this.lHorizontal.TabIndex = 0;
            this.lHorizontal.Text = "&Horizontal:";
            // 
            // tbVerCust
            // 
            this.tbVerCust.Location = new System.Drawing.Point(194, 46);
            this.tbVerCust.Name = "tbVerCust";
            this.tbVerCust.Size = new System.Drawing.Size(52, 20);
            this.tbVerCust.TabIndex = 6;
            // 
            // tbHorCust
            // 
            this.tbHorCust.Location = new System.Drawing.Point(194, 19);
            this.tbHorCust.Name = "tbHorCust";
            this.tbHorCust.Size = new System.Drawing.Size(52, 20);
            this.tbHorCust.TabIndex = 2;
            // 
            // cbVerCustType
            // 
            this.cbVerCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerCustType.FormattingEnabled = true;
            this.cbVerCustType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbVerCustType.Location = new System.Drawing.Point(271, 46);
            this.cbVerCustType.Name = "cbVerCustType";
            this.cbVerCustType.Size = new System.Drawing.Size(57, 21);
            this.cbVerCustType.TabIndex = 7;
            // 
            // cbVertical
            // 
            this.cbVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVertical.FormattingEnabled = true;
            this.cbVertical.Location = new System.Drawing.Point(95, 46);
            this.cbVertical.Name = "cbVertical";
            this.cbVertical.Size = new System.Drawing.Size(75, 21);
            this.cbVertical.TabIndex = 5;
            this.cbVertical.SelectedIndexChanged += new System.EventHandler(this.cbVertical_SelectedIndexChanged);
            // 
            // cbHorCustType
            // 
            this.cbHorCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorCustType.FormattingEnabled = true;
            this.cbHorCustType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbHorCustType.Location = new System.Drawing.Point(271, 19);
            this.cbHorCustType.Name = "cbHorCustType";
            this.cbHorCustType.Size = new System.Drawing.Size(57, 21);
            this.cbHorCustType.TabIndex = 3;
            // 
            // cbHorizontal
            // 
            this.cbHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorizontal.FormattingEnabled = true;
            this.cbHorizontal.Location = new System.Drawing.Point(95, 19);
            this.cbHorizontal.Name = "cbHorizontal";
            this.cbHorizontal.Size = new System.Drawing.Size(75, 21);
            this.cbHorizontal.TabIndex = 1;
            this.cbHorizontal.SelectedIndexChanged += new System.EventHandler(this.cbHorizontal_SelectedIndexChanged);
            // 
            // cbScrolling
            // 
            this.cbScrolling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScrolling.FormattingEnabled = true;
            this.cbScrolling.Location = new System.Drawing.Point(209, 75);
            this.cbScrolling.Name = "cbScrolling";
            this.cbScrolling.Size = new System.Drawing.Size(239, 21);
            this.cbScrolling.TabIndex = 6;
            // 
            // cbTiling
            // 
            this.cbTiling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiling.FormattingEnabled = true;
            this.cbTiling.Location = new System.Drawing.Point(209, 48);
            this.cbTiling.Name = "cbTiling";
            this.cbTiling.Size = new System.Drawing.Size(239, 21);
            this.cbTiling.TabIndex = 4;
            // 
            // lBgImageFile
            // 
            this.lBgImageFile.AutoSize = true;
            this.lBgImageFile.Location = new System.Drawing.Point(6, 24);
            this.lBgImageFile.Name = "lBgImageFile";
            this.lBgImageFile.Size = new System.Drawing.Size(39, 13);
            this.lBgImageFile.TabIndex = 0;
            this.lBgImageFile.Text = "Image:";
            // 
            // tbBgImage
            // 
            this.tbBgImage.Location = new System.Drawing.Point(135, 21);
            this.tbBgImage.Name = "tbBgImage";
            this.tbBgImage.Size = new System.Drawing.Size(265, 20);
            this.tbBgImage.TabIndex = 1;
            this.tbBgImage.TextChanged += new System.EventHandler(this.tbBgImage_TextChanged);
            // 
            // btChooseBgImage
            // 
            this.btChooseBgImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChooseBgImage.Location = new System.Drawing.Point(406, 19);
            this.btChooseBgImage.Name = "btChooseBgImage";
            this.btChooseBgImage.Size = new System.Drawing.Size(42, 23);
            this.btChooseBgImage.TabIndex = 2;
            this.btChooseBgImage.Text = "...";
            this.btChooseBgImage.UseVisualStyleBackColor = true;
            this.btChooseBgImage.Click += new System.EventHandler(this.btChooseBgImage_Click);
            // 
            // ucBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBackgroundImage);
            this.Controls.Add(this.gbBackgroundColor);
            this.Name = "ucBackground";
            this.Size = new System.Drawing.Size(460, 380);
            this.Load += new System.EventHandler(this.ucBackground_Load);
            this.gbBackgroundColor.ResumeLayout(false);
            this.gbBackgroundColor.PerformLayout();
            this.gbBackgroundImage.ResumeLayout(false);
            this.gbBackgroundImage.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBackgroundColor;
        private GroupBox gbBackgroundImage;
        private CheckBox cbBgColorTransparent;
        private Button btChooseBgImage;
        private ColorDialog dlgColorPicker;
        private ComboBox cbScrolling;
        private ComboBox cbTiling;
        private Label lBgImageFile;
        private TextBox tbBgImage;
        private CheckBox cbDoNotUseBackground;
        private Label lScrolling;
        private Label bTiling;
        private GroupBox gbPosition;
        private Label lVertical;
        private Label lHorizontal;
        private TextBox tbVerCust;
        private TextBox tbHorCust;
        private ComboBox cbVerCustType;
        private ComboBox cbVertical;
        private ComboBox cbHorCustType;
        private ComboBox cbHorizontal;
        private OpenFileDialog dlgBgImage;
        private TextBox txtBgColor;

    }
}
