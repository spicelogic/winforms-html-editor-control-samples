using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    /// <summary>
    /// Class frmFontPicker
    /// </summary>
    public partial class frmFontPicker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lHint = new System.Windows.Forms.Label();
            this.lInstalledFonts = new System.Windows.Forms.Label();
            this.lbInstalledFonts = new System.Windows.Forms.ListBox();
            this.lGenericFonts = new System.Windows.Forms.Label();
            this.cbGenericFonts = new System.Windows.Forms.ComboBox();
            this.lCustomFont = new System.Windows.Forms.Label();
            this.tbCustomFont = new System.Windows.Forms.TextBox();
            this.btAddInstalledFont = new System.Windows.Forms.Button();
            this.btAddGenericFont = new System.Windows.Forms.Button();
            this.btAddCustomFont = new System.Windows.Forms.Button();
            this.lbSelectedFonts = new System.Windows.Forms.ListBox();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lSelectedFontsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lHint
            // 
            this.lHint.AutoSize = true;
            this.lHint.Location = new System.Drawing.Point(12, 9);
            this.lHint.Name = "lHint";
            this.lHint.Size = new System.Drawing.Size(225, 13);
            this.lHint.TabIndex = 0;
            this.lHint.Text = "Create a font sequence in order of preference:";
            // 
            // lInstalledFonts
            // 
            this.lInstalledFonts.AutoSize = true;
            this.lInstalledFonts.Location = new System.Drawing.Point(12, 33);
            this.lInstalledFonts.Name = "lInstalledFonts";
            this.lInstalledFonts.Size = new System.Drawing.Size(78, 13);
            this.lInstalledFonts.TabIndex = 1;
            this.lInstalledFonts.Text = "&Installed Fonts:";
            // 
            // lbInstalledFonts
            // 
            this.lbInstalledFonts.FormattingEnabled = true;
            this.lbInstalledFonts.Location = new System.Drawing.Point(15, 49);
            this.lbInstalledFonts.Name = "lbInstalledFonts";
            this.lbInstalledFonts.Size = new System.Drawing.Size(222, 160);
            this.lbInstalledFonts.TabIndex = 2;
            // 
            // lGenericFonts
            // 
            this.lGenericFonts.AutoSize = true;
            this.lGenericFonts.Location = new System.Drawing.Point(12, 215);
            this.lGenericFonts.Name = "lGenericFonts";
            this.lGenericFonts.Size = new System.Drawing.Size(76, 13);
            this.lGenericFonts.TabIndex = 3;
            this.lGenericFonts.Text = "&Generic Fonts:";
            // 
            // cbGenericFonts
            // 
            this.cbGenericFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenericFonts.FormattingEnabled = true;
            this.cbGenericFonts.Items.AddRange(new object[] {
            "Monospace",
            "Serif",
            "Sans-Serif",
            "Cursive",
            "Fantasy"});
            this.cbGenericFonts.Location = new System.Drawing.Point(15, 231);
            this.cbGenericFonts.Name = "cbGenericFonts";
            this.cbGenericFonts.Size = new System.Drawing.Size(222, 21);
            this.cbGenericFonts.TabIndex = 4;
            // 
            // lCustomFont
            // 
            this.lCustomFont.AutoSize = true;
            this.lCustomFont.Location = new System.Drawing.Point(12, 264);
            this.lCustomFont.Name = "lCustomFont";
            this.lCustomFont.Size = new System.Drawing.Size(66, 13);
            this.lCustomFont.TabIndex = 5;
            this.lCustomFont.Text = "&Custom font:";
            // 
            // tbCustomFont
            // 
            this.tbCustomFont.Location = new System.Drawing.Point(12, 280);
            this.tbCustomFont.Name = "tbCustomFont";
            this.tbCustomFont.Size = new System.Drawing.Size(225, 20);
            this.tbCustomFont.TabIndex = 6;
            this.tbCustomFont.TextChanged += new System.EventHandler(this.tbCustomFont_TextChanged);
            // 
            // btAddInstalledFont
            // 
            this.btAddInstalledFont.Location = new System.Drawing.Point(243, 49);
            this.btAddInstalledFont.Name = "btAddInstalledFont";
            this.btAddInstalledFont.Size = new System.Drawing.Size(48, 23);
            this.btAddInstalledFont.TabIndex = 7;
            this.btAddInstalledFont.Text = ">>>";
            this.btAddInstalledFont.UseVisualStyleBackColor = true;
            this.btAddInstalledFont.Click += new System.EventHandler(this.btAddInstalledFont_Click);
            // 
            // btAddGenericFont
            // 
            this.btAddGenericFont.Location = new System.Drawing.Point(243, 229);
            this.btAddGenericFont.Name = "btAddGenericFont";
            this.btAddGenericFont.Size = new System.Drawing.Size(48, 23);
            this.btAddGenericFont.TabIndex = 8;
            this.btAddGenericFont.Text = ">>>";
            this.btAddGenericFont.UseVisualStyleBackColor = true;
            this.btAddGenericFont.Click += new System.EventHandler(this.btAddGenericFont_Click);
            // 
            // btAddCustomFont
            // 
            this.btAddCustomFont.Location = new System.Drawing.Point(243, 278);
            this.btAddCustomFont.Name = "btAddCustomFont";
            this.btAddCustomFont.Size = new System.Drawing.Size(48, 23);
            this.btAddCustomFont.TabIndex = 9;
            this.btAddCustomFont.Text = ">>>";
            this.btAddCustomFont.UseVisualStyleBackColor = true;
            this.btAddCustomFont.Click += new System.EventHandler(this.brAddCustomFont_Click);
            // 
            // lbSelectedFonts
            // 
            this.lbSelectedFonts.FormattingEnabled = true;
            this.lbSelectedFonts.Location = new System.Drawing.Point(297, 49);
            this.lbSelectedFonts.Name = "lbSelectedFonts";
            this.lbSelectedFonts.Size = new System.Drawing.Size(241, 251);
            this.lbSelectedFonts.TabIndex = 10;
            this.lbSelectedFonts.SelectedIndexChanged += new System.EventHandler(this.lbSelectedFonts_SelectedIndexChanged);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Location = new System.Drawing.Point(544, 49);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btMoveUp.TabIndex = 11;
            this.btMoveUp.Text = "Move &Up";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.Click += new System.EventHandler(this.btMoveUp_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Location = new System.Drawing.Point(544, 78);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btMoveDown.TabIndex = 12;
            this.btMoveDown.Text = "Move &Down";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.Click += new System.EventHandler(this.btMoveDown_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(544, 277);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 13;
            this.btRemove.Text = "&Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(463, 313);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(546, 313);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lSelectedFontsTitle
            // 
            this.lSelectedFontsTitle.AutoSize = true;
            this.lSelectedFontsTitle.Location = new System.Drawing.Point(294, 33);
            this.lSelectedFontsTitle.Name = "lSelectedFontsTitle";
            this.lSelectedFontsTitle.Size = new System.Drawing.Size(81, 13);
            this.lSelectedFontsTitle.TabIndex = 16;
            this.lSelectedFontsTitle.Text = "&Selected Fonts:";
            // 
            // frmFontPicker
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.lSelectedFontsTitle);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btMoveDown);
            this.Controls.Add(this.btMoveUp);
            this.Controls.Add(this.lbSelectedFonts);
            this.Controls.Add(this.btAddCustomFont);
            this.Controls.Add(this.btAddGenericFont);
            this.Controls.Add(this.btAddInstalledFont);
            this.Controls.Add(this.tbCustomFont);
            this.Controls.Add(this.lCustomFont);
            this.Controls.Add(this.cbGenericFonts);
            this.Controls.Add(this.lGenericFonts);
            this.Controls.Add(this.lbInstalledFonts);
            this.Controls.Add(this.lInstalledFonts);
            this.Controls.Add(this.lHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmFontPicker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Font Picker";
            this.Load += new System.EventHandler(this.frmFontPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The l hint
        /// </summary>
        private Label lHint;
        /// <summary>
        /// The l installed fonts
        /// </summary>
        private Label lInstalledFonts;
        /// <summary>
        /// The lb installed fonts
        /// </summary>
        private ListBox lbInstalledFonts;
        /// <summary>
        /// The l generic fonts
        /// </summary>
        private Label lGenericFonts;
        /// <summary>
        /// The cb generic fonts
        /// </summary>
        private ComboBox cbGenericFonts;
        /// <summary>
        /// The l custom font
        /// </summary>
        private Label lCustomFont;
        /// <summary>
        /// The tb custom font
        /// </summary>
        private TextBox tbCustomFont;
        /// <summary>
        /// The bt add installed font
        /// </summary>
        private Button btAddInstalledFont;
        /// <summary>
        /// The bt add generic font
        /// </summary>
        private Button btAddGenericFont;
        /// <summary>
        /// The bt add custom font
        /// </summary>
        private Button btAddCustomFont;
        /// <summary>
        /// The lb selected fonts
        /// </summary>
        private ListBox lbSelectedFonts;
        /// <summary>
        /// The bt move up
        /// </summary>
        private Button btMoveUp;
        /// <summary>
        /// The bt move down
        /// </summary>
        private Button btMoveDown;
        /// <summary>
        /// The bt remove
        /// </summary>
        private Button btRemove;
        /// <summary>
        /// The bt ok
        /// </summary>
        private Button btOk;
        /// <summary>
        /// The bt cancel
        /// </summary>
        private Button btCancel;
        /// <summary>
        /// The l selected fonts title
        /// </summary>
        private Label lSelectedFontsTitle;
    }
}