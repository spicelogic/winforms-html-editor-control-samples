using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucText
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
            this.gbAlignment = new System.Windows.Forms.GroupBox();
            this.lAlJustification = new System.Windows.Forms.Label();
            this.lAlVertical = new System.Windows.Forms.Label();
            this.lAlHorizontal = new System.Windows.Forms.Label();
            this.cbAlJustification = new System.Windows.Forms.ComboBox();
            this.cbAlVertical = new System.Windows.Forms.ComboBox();
            this.cbAlHorizontal = new System.Windows.Forms.ComboBox();
            this.gbSpacingBetween = new System.Windows.Forms.GroupBox();
            this.lSbLines = new System.Windows.Forms.Label();
            this.lSbLetters = new System.Windows.Forms.Label();
            this.cbSpacingLinesCustom = new System.Windows.Forms.ComboBox();
            this.cbSpacingLettersCustom = new System.Windows.Forms.ComboBox();
            this.tbSpacingLines = new System.Windows.Forms.TextBox();
            this.tbSpacingLetters = new System.Windows.Forms.TextBox();
            this.cbSpacingLines = new System.Windows.Forms.ComboBox();
            this.cbSpacingLetters = new System.Windows.Forms.ComboBox();
            this.gbTextFlow = new System.Windows.Forms.GroupBox();
            this.lTfTextDirection = new System.Windows.Forms.Label();
            this.lTfIndentation = new System.Windows.Forms.Label();
            this.cbTextFlowDirection = new System.Windows.Forms.ComboBox();
            this.tbTextFlowIndentation = new System.Windows.Forms.TextBox();
            this.cbTextFlowCustom = new System.Windows.Forms.ComboBox();
            this.gbAlignment.SuspendLayout();
            this.gbSpacingBetween.SuspendLayout();
            this.gbTextFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlignment
            // 
            this.gbAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAlignment.Controls.Add(this.lAlJustification);
            this.gbAlignment.Controls.Add(this.lAlVertical);
            this.gbAlignment.Controls.Add(this.lAlHorizontal);
            this.gbAlignment.Controls.Add(this.cbAlJustification);
            this.gbAlignment.Controls.Add(this.cbAlVertical);
            this.gbAlignment.Controls.Add(this.cbAlHorizontal);
            this.gbAlignment.Location = new System.Drawing.Point(3, 3);
            this.gbAlignment.Name = "gbAlignment";
            this.gbAlignment.Size = new System.Drawing.Size(454, 107);
            this.gbAlignment.TabIndex = 0;
            this.gbAlignment.TabStop = false;
            this.gbAlignment.Text = "Alignment";
            // 
            // lAlJustification
            // 
            this.lAlJustification.AutoSize = true;
            this.lAlJustification.Location = new System.Drawing.Point(6, 76);
            this.lAlJustification.Name = "lAlJustification";
            this.lAlJustification.Size = new System.Drawing.Size(65, 13);
            this.lAlJustification.TabIndex = 4;
            this.lAlJustification.Text = "&Justification:";
            // 
            // lAlVertical
            // 
            this.lAlVertical.AutoSize = true;
            this.lAlVertical.Location = new System.Drawing.Point(6, 49);
            this.lAlVertical.Name = "lAlVertical";
            this.lAlVertical.Size = new System.Drawing.Size(45, 13);
            this.lAlVertical.TabIndex = 2;
            this.lAlVertical.Text = "&Vertical:";
            // 
            // lAlHorizontal
            // 
            this.lAlHorizontal.AutoSize = true;
            this.lAlHorizontal.Location = new System.Drawing.Point(6, 22);
            this.lAlHorizontal.Name = "lAlHorizontal";
            this.lAlHorizontal.Size = new System.Drawing.Size(57, 13);
            this.lAlHorizontal.TabIndex = 0;
            this.lAlHorizontal.Text = "&Horizontal:";
            // 
            // cbAlJustification
            // 
            this.cbAlJustification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlJustification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlJustification.FormattingEnabled = true;
            this.cbAlJustification.Location = new System.Drawing.Point(89, 73);
            this.cbAlJustification.Name = "cbAlJustification";
            this.cbAlJustification.Size = new System.Drawing.Size(359, 21);
            this.cbAlJustification.TabIndex = 5;
            // 
            // cbAlVertical
            // 
            this.cbAlVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlVertical.FormattingEnabled = true;
            this.cbAlVertical.Location = new System.Drawing.Point(89, 46);
            this.cbAlVertical.Name = "cbAlVertical";
            this.cbAlVertical.Size = new System.Drawing.Size(359, 21);
            this.cbAlVertical.TabIndex = 3;
            // 
            // cbAlHorizontal
            // 
            this.cbAlHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlHorizontal.FormattingEnabled = true;
            this.cbAlHorizontal.Location = new System.Drawing.Point(89, 19);
            this.cbAlHorizontal.Name = "cbAlHorizontal";
            this.cbAlHorizontal.Size = new System.Drawing.Size(359, 21);
            this.cbAlHorizontal.TabIndex = 1;
            this.cbAlHorizontal.SelectedIndexChanged += new System.EventHandler(this.cbAlHorizontal_SelectedIndexChanged);
            // 
            // gbSpacingBetween
            // 
            this.gbSpacingBetween.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSpacingBetween.Controls.Add(this.lSbLines);
            this.gbSpacingBetween.Controls.Add(this.lSbLetters);
            this.gbSpacingBetween.Controls.Add(this.cbSpacingLinesCustom);
            this.gbSpacingBetween.Controls.Add(this.cbSpacingLettersCustom);
            this.gbSpacingBetween.Controls.Add(this.tbSpacingLines);
            this.gbSpacingBetween.Controls.Add(this.tbSpacingLetters);
            this.gbSpacingBetween.Controls.Add(this.cbSpacingLines);
            this.gbSpacingBetween.Controls.Add(this.cbSpacingLetters);
            this.gbSpacingBetween.Location = new System.Drawing.Point(3, 116);
            this.gbSpacingBetween.Name = "gbSpacingBetween";
            this.gbSpacingBetween.Size = new System.Drawing.Size(454, 83);
            this.gbSpacingBetween.TabIndex = 1;
            this.gbSpacingBetween.TabStop = false;
            this.gbSpacingBetween.Text = "Spacing between";
            // 
            // lSbLines
            // 
            this.lSbLines.AutoSize = true;
            this.lSbLines.Location = new System.Drawing.Point(6, 49);
            this.lSbLines.Name = "lSbLines";
            this.lSbLines.Size = new System.Drawing.Size(35, 13);
            this.lSbLines.TabIndex = 4;
            this.lSbLines.Text = "&Lines:";
            // 
            // lSbLetters
            // 
            this.lSbLetters.AutoSize = true;
            this.lSbLetters.Location = new System.Drawing.Point(6, 22);
            this.lSbLetters.Name = "lSbLetters";
            this.lSbLetters.Size = new System.Drawing.Size(42, 13);
            this.lSbLetters.TabIndex = 0;
            this.lSbLetters.Text = "L&etters:";
            // 
            // cbSpacingLinesCustom
            // 
            this.cbSpacingLinesCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpacingLinesCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpacingLinesCustom.FormattingEnabled = true;
            this.cbSpacingLinesCustom.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbSpacingLinesCustom.Location = new System.Drawing.Point(383, 46);
            this.cbSpacingLinesCustom.Name = "cbSpacingLinesCustom";
            this.cbSpacingLinesCustom.Size = new System.Drawing.Size(65, 21);
            this.cbSpacingLinesCustom.TabIndex = 7;
            // 
            // cbSpacingLettersCustom
            // 
            this.cbSpacingLettersCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpacingLettersCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpacingLettersCustom.FormattingEnabled = true;
            this.cbSpacingLettersCustom.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbSpacingLettersCustom.Location = new System.Drawing.Point(383, 19);
            this.cbSpacingLettersCustom.Name = "cbSpacingLettersCustom";
            this.cbSpacingLettersCustom.Size = new System.Drawing.Size(65, 21);
            this.cbSpacingLettersCustom.TabIndex = 3;
            // 
            // tbSpacingLines
            // 
            this.tbSpacingLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpacingLines.Location = new System.Drawing.Point(277, 46);
            this.tbSpacingLines.Name = "tbSpacingLines";
            this.tbSpacingLines.Size = new System.Drawing.Size(100, 20);
            this.tbSpacingLines.TabIndex = 6;
            // 
            // tbSpacingLetters
            // 
            this.tbSpacingLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpacingLetters.Location = new System.Drawing.Point(277, 19);
            this.tbSpacingLetters.Name = "tbSpacingLetters";
            this.tbSpacingLetters.Size = new System.Drawing.Size(100, 20);
            this.tbSpacingLetters.TabIndex = 2;
            // 
            // cbSpacingLines
            // 
            this.cbSpacingLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpacingLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpacingLines.FormattingEnabled = true;
            this.cbSpacingLines.Location = new System.Drawing.Point(89, 46);
            this.cbSpacingLines.Name = "cbSpacingLines";
            this.cbSpacingLines.Size = new System.Drawing.Size(182, 21);
            this.cbSpacingLines.TabIndex = 5;
            this.cbSpacingLines.SelectedIndexChanged += new System.EventHandler(this.cbSpacingLines_SelectedIndexChanged);
            // 
            // cbSpacingLetters
            // 
            this.cbSpacingLetters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpacingLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpacingLetters.FormattingEnabled = true;
            this.cbSpacingLetters.Location = new System.Drawing.Point(89, 19);
            this.cbSpacingLetters.Name = "cbSpacingLetters";
            this.cbSpacingLetters.Size = new System.Drawing.Size(182, 21);
            this.cbSpacingLetters.TabIndex = 1;
            this.cbSpacingLetters.SelectedIndexChanged += new System.EventHandler(this.cbSpacingLetters_SelectedIndexChanged);
            // 
            // gbTextFlow
            // 
            this.gbTextFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTextFlow.Controls.Add(this.lTfTextDirection);
            this.gbTextFlow.Controls.Add(this.lTfIndentation);
            this.gbTextFlow.Controls.Add(this.cbTextFlowDirection);
            this.gbTextFlow.Controls.Add(this.tbTextFlowIndentation);
            this.gbTextFlow.Controls.Add(this.cbTextFlowCustom);
            this.gbTextFlow.Location = new System.Drawing.Point(3, 205);
            this.gbTextFlow.Name = "gbTextFlow";
            this.gbTextFlow.Size = new System.Drawing.Size(454, 83);
            this.gbTextFlow.TabIndex = 2;
            this.gbTextFlow.TabStop = false;
            this.gbTextFlow.Text = "Text flow";
            // 
            // lTfTextDirection
            // 
            this.lTfTextDirection.AutoSize = true;
            this.lTfTextDirection.Location = new System.Drawing.Point(6, 49);
            this.lTfTextDirection.Name = "lTfTextDirection";
            this.lTfTextDirection.Size = new System.Drawing.Size(74, 13);
            this.lTfTextDirection.TabIndex = 3;
            this.lTfTextDirection.Text = "Te&xt direction:";
            // 
            // lTfIndentation
            // 
            this.lTfIndentation.AutoSize = true;
            this.lTfIndentation.Location = new System.Drawing.Point(6, 22);
            this.lTfIndentation.Name = "lTfIndentation";
            this.lTfIndentation.Size = new System.Drawing.Size(63, 13);
            this.lTfIndentation.TabIndex = 0;
            this.lTfIndentation.Text = "&Indentation:";
            // 
            // cbTextFlowDirection
            // 
            this.cbTextFlowDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTextFlowDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextFlowDirection.FormattingEnabled = true;
            this.cbTextFlowDirection.Location = new System.Drawing.Point(89, 46);
            this.cbTextFlowDirection.Name = "cbTextFlowDirection";
            this.cbTextFlowDirection.Size = new System.Drawing.Size(359, 21);
            this.cbTextFlowDirection.TabIndex = 4;
            // 
            // tbTextFlowIndentation
            // 
            this.tbTextFlowIndentation.Location = new System.Drawing.Point(89, 19);
            this.tbTextFlowIndentation.Name = "tbTextFlowIndentation";
            this.tbTextFlowIndentation.Size = new System.Drawing.Size(100, 20);
            this.tbTextFlowIndentation.TabIndex = 1;
            // 
            // cbTextFlowCustom
            // 
            this.cbTextFlowCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextFlowCustom.FormattingEnabled = true;
            this.cbTextFlowCustom.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbTextFlowCustom.Location = new System.Drawing.Point(195, 19);
            this.cbTextFlowCustom.Name = "cbTextFlowCustom";
            this.cbTextFlowCustom.Size = new System.Drawing.Size(60, 21);
            this.cbTextFlowCustom.TabIndex = 2;
            // 
            // ucText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTextFlow);
            this.Controls.Add(this.gbSpacingBetween);
            this.Controls.Add(this.gbAlignment);
            this.Name = "ucText";
            this.Size = new System.Drawing.Size(460, 380);
            this.Load += new System.EventHandler(this.ucText_Load);
            this.gbAlignment.ResumeLayout(false);
            this.gbAlignment.PerformLayout();
            this.gbSpacingBetween.ResumeLayout(false);
            this.gbSpacingBetween.PerformLayout();
            this.gbTextFlow.ResumeLayout(false);
            this.gbTextFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbAlignment;
        private GroupBox gbSpacingBetween;
        private GroupBox gbTextFlow;
        private Label lAlJustification;
        private Label lAlVertical;
        private Label lAlHorizontal;
        private ComboBox cbAlJustification;
        private ComboBox cbAlVertical;
        private ComboBox cbAlHorizontal;
        private Label lSbLines;
        private Label lSbLetters;
        private ComboBox cbSpacingLinesCustom;
        private ComboBox cbSpacingLettersCustom;
        private TextBox tbSpacingLines;
        private TextBox tbSpacingLetters;
        private ComboBox cbSpacingLines;
        private ComboBox cbSpacingLetters;
        private Label lTfTextDirection;
        private Label lTfIndentation;
        private ComboBox cbTextFlowDirection;
        private TextBox tbTextFlowIndentation;
        private ComboBox cbTextFlowCustom;
    }
}
