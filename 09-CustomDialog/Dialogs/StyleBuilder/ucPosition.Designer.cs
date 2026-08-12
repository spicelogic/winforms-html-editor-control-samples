using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucPosition
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private readonly IContainer components = null;

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
            this.lPositionMode = new System.Windows.Forms.Label();
            this.cbPositionMode = new System.Windows.Forms.ComboBox();
            this.cbTopType = new System.Windows.Forms.ComboBox();
            this.cbLeftType = new System.Windows.Forms.ComboBox();
            this.cbHeightType = new System.Windows.Forms.ComboBox();
            this.cbWidthType = new System.Windows.Forms.ComboBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lTop = new System.Windows.Forms.Label();
            this.lLeft = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lZIndex = new System.Windows.Forms.Label();
            this.tbZIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lPositionMode
            // 
            this.lPositionMode.AutoSize = true;
            this.lPositionMode.Location = new System.Drawing.Point(3, 0);
            this.lPositionMode.Name = "lPositionMode";
            this.lPositionMode.Size = new System.Drawing.Size(76, 13);
            this.lPositionMode.TabIndex = 0;
            this.lPositionMode.Text = "&Position mode:";
            // 
            // cbPositionMode
            // 
            this.cbPositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPositionMode.FormattingEnabled = true;
            this.cbPositionMode.Location = new System.Drawing.Point(3, 19);
            this.cbPositionMode.Name = "cbPositionMode";
            this.cbPositionMode.Size = new System.Drawing.Size(454, 21);
            this.cbPositionMode.TabIndex = 1;
            this.cbPositionMode.SelectedIndexChanged += new System.EventHandler(this.cbPositionMode_SelectedIndexChanged);
            // 
            // cbTopType
            // 
            this.cbTopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopType.FormattingEnabled = true;
            this.cbTopType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbTopType.Location = new System.Drawing.Point(136, 46);
            this.cbTopType.Name = "cbTopType";
            this.cbTopType.Size = new System.Drawing.Size(68, 21);
            this.cbTopType.TabIndex = 4;
            // 
            // cbLeftType
            // 
            this.cbLeftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeftType.FormattingEnabled = true;
            this.cbLeftType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbLeftType.Location = new System.Drawing.Point(136, 73);
            this.cbLeftType.Name = "cbLeftType";
            this.cbLeftType.Size = new System.Drawing.Size(68, 21);
            this.cbLeftType.TabIndex = 7;
            // 
            // cbHeightType
            // 
            this.cbHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeightType.FormattingEnabled = true;
            this.cbHeightType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbHeightType.Location = new System.Drawing.Point(389, 46);
            this.cbHeightType.Name = "cbHeightType";
            this.cbHeightType.Size = new System.Drawing.Size(68, 21);
            this.cbHeightType.TabIndex = 10;
            // 
            // cbWidthType
            // 
            this.cbWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidthType.FormattingEnabled = true;
            this.cbWidthType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbWidthType.Location = new System.Drawing.Point(389, 73);
            this.cbWidthType.Name = "cbWidthType";
            this.cbWidthType.Size = new System.Drawing.Size(68, 21);
            this.cbWidthType.TabIndex = 13;
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(52, 46);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(76, 20);
            this.tbTop.TabIndex = 3;
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(52, 73);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(76, 20);
            this.tbLeft.TabIndex = 6;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(307, 46);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(76, 20);
            this.tbHeight.TabIndex = 9;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(307, 73);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(76, 20);
            this.tbWidth.TabIndex = 12;
            // 
            // lTop
            // 
            this.lTop.AutoSize = true;
            this.lTop.Location = new System.Drawing.Point(3, 49);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(29, 13);
            this.lTop.TabIndex = 2;
            this.lTop.Text = "&Top:";
            // 
            // lLeft
            // 
            this.lLeft.AutoSize = true;
            this.lLeft.Location = new System.Drawing.Point(3, 76);
            this.lLeft.Name = "lLeft";
            this.lLeft.Size = new System.Drawing.Size(28, 13);
            this.lLeft.TabIndex = 5;
            this.lLeft.Text = "&Left:";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(222, 49);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(41, 13);
            this.lHeight.TabIndex = 8;
            this.lHeight.Text = "&Height:";
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(222, 76);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(38, 13);
            this.lWidth.TabIndex = 11;
            this.lWidth.Text = "&Width:";
            // 
            // lZIndex
            // 
            this.lZIndex.AutoSize = true;
            this.lZIndex.Location = new System.Drawing.Point(3, 111);
            this.lZIndex.Name = "lZIndex";
            this.lZIndex.Size = new System.Drawing.Size(46, 13);
            this.lZIndex.TabIndex = 14;
            this.lZIndex.Text = "&Z-Index:";
            // 
            // tbZIndex
            // 
            this.tbZIndex.Location = new System.Drawing.Point(6, 127);
            this.tbZIndex.Name = "tbZIndex";
            this.tbZIndex.Size = new System.Drawing.Size(76, 20);
            this.tbZIndex.TabIndex = 15;
            // 
            // ucPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbZIndex);
            this.Controls.Add(this.lZIndex);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lLeft);
            this.Controls.Add(this.lTop);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.tbTop);
            this.Controls.Add(this.cbWidthType);
            this.Controls.Add(this.cbHeightType);
            this.Controls.Add(this.cbLeftType);
            this.Controls.Add(this.cbTopType);
            this.Controls.Add(this.cbPositionMode);
            this.Controls.Add(this.lPositionMode);
            this.Name = "ucPosition";
            this.Size = new System.Drawing.Size(460, 380);
            this.Load += new System.EventHandler(this.ucPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lPositionMode;
        private ComboBox cbPositionMode;
        private ComboBox cbTopType;
        private ComboBox cbLeftType;
        private ComboBox cbHeightType;
        private ComboBox cbWidthType;
        private TextBox tbTop;
        private TextBox tbLeft;
        private TextBox tbHeight;
        private TextBox tbWidth;
        private Label lTop;
        private Label lLeft;
        private Label lHeight;
        private Label lWidth;
        private Label lZIndex;
        private TextBox tbZIndex;
    }
}
