using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucLayout
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
            this.lVisibility = new System.Windows.Forms.Label();
            this.cbVisibility = new System.Windows.Forms.ComboBox();
            this.lDisplay = new System.Windows.Forms.Label();
            this.cbDisplay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAllowTextToFlow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAllowFloatingObject = new System.Windows.Forms.ComboBox();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.gbClipping = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbBottom = new System.Windows.Forms.TextBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.cbRightType = new System.Windows.Forms.ComboBox();
            this.cbBottomType = new System.Windows.Forms.ComboBox();
            this.cbLeftType = new System.Windows.Forms.ComboBox();
            this.cbTopType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOverflow = new System.Windows.Forms.ComboBox();
            this.gbPageBreaks = new System.Windows.Forms.GroupBox();
            this.lAfter = new System.Windows.Forms.Label();
            this.lBefore = new System.Windows.Forms.Label();
            this.cbPbAfter = new System.Windows.Forms.ComboBox();
            this.cbPbBefore = new System.Windows.Forms.ComboBox();
            this.gbContent.SuspendLayout();
            this.gbClipping.SuspendLayout();
            this.gbPageBreaks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVisibility
            // 
            this.lVisibility.AutoSize = true;
            this.lVisibility.Location = new System.Drawing.Point(3, 2);
            this.lVisibility.Name = "lVisibility";
            this.lVisibility.Size = new System.Drawing.Size(46, 13);
            this.lVisibility.TabIndex = 0;
            this.lVisibility.Text = "&Visibility:";
            // 
            // cbVisibility
            // 
            this.cbVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisibility.FormattingEnabled = true;
            this.cbVisibility.Location = new System.Drawing.Point(3, 18);
            this.cbVisibility.Name = "cbVisibility";
            this.cbVisibility.Size = new System.Drawing.Size(454, 21);
            this.cbVisibility.TabIndex = 1;
            // 
            // lDisplay
            // 
            this.lDisplay.AutoSize = true;
            this.lDisplay.Location = new System.Drawing.Point(3, 44);
            this.lDisplay.Name = "lDisplay";
            this.lDisplay.Size = new System.Drawing.Size(44, 13);
            this.lDisplay.TabIndex = 2;
            this.lDisplay.Text = "&Display:";
            // 
            // cbDisplay
            // 
            this.cbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplay.FormattingEnabled = true;
            this.cbDisplay.Location = new System.Drawing.Point(3, 60);
            this.cbDisplay.Name = "cbDisplay";
            this.cbDisplay.Size = new System.Drawing.Size(454, 21);
            this.cbDisplay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Allow te&xt to flow:";
            // 
            // cbAllowTextToFlow
            // 
            this.cbAllowTextToFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAllowTextToFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllowTextToFlow.FormattingEnabled = true;
            this.cbAllowTextToFlow.Location = new System.Drawing.Point(3, 102);
            this.cbAllowTextToFlow.Name = "cbAllowTextToFlow";
            this.cbAllowTextToFlow.Size = new System.Drawing.Size(454, 21);
            this.cbAllowTextToFlow.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Allow &floating objects:";
            // 
            // cbAllowFloatingObject
            // 
            this.cbAllowFloatingObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAllowFloatingObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllowFloatingObject.FormattingEnabled = true;
            this.cbAllowFloatingObject.Location = new System.Drawing.Point(3, 144);
            this.cbAllowFloatingObject.Name = "cbAllowFloatingObject";
            this.cbAllowFloatingObject.Size = new System.Drawing.Size(454, 21);
            this.cbAllowFloatingObject.TabIndex = 7;
            // 
            // gbContent
            // 
            this.gbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContent.Controls.Add(this.gbClipping);
            this.gbContent.Controls.Add(this.label5);
            this.gbContent.Controls.Add(this.cbOverflow);
            this.gbContent.Location = new System.Drawing.Point(3, 171);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(454, 129);
            this.gbContent.TabIndex = 8;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Content";
            // 
            // gbClipping
            // 
            this.gbClipping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClipping.Controls.Add(this.label9);
            this.gbClipping.Controls.Add(this.label8);
            this.gbClipping.Controls.Add(this.label7);
            this.gbClipping.Controls.Add(this.label6);
            this.gbClipping.Controls.Add(this.tbRight);
            this.gbClipping.Controls.Add(this.tbBottom);
            this.gbClipping.Controls.Add(this.tbLeft);
            this.gbClipping.Controls.Add(this.tbTop);
            this.gbClipping.Controls.Add(this.cbRightType);
            this.gbClipping.Controls.Add(this.cbBottomType);
            this.gbClipping.Controls.Add(this.cbLeftType);
            this.gbClipping.Controls.Add(this.cbTopType);
            this.gbClipping.Location = new System.Drawing.Point(6, 46);
            this.gbClipping.Name = "gbClipping";
            this.gbClipping.Size = new System.Drawing.Size(442, 77);
            this.gbClipping.TabIndex = 2;
            this.gbClipping.TabStop = false;
            this.gbClipping.Text = "Clipping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "&Right:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "&Bottom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "&Left:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Top:";
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(303, 46);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(70, 20);
            this.tbRight.TabIndex = 7;
            // 
            // tbBottom
            // 
            this.tbBottom.Location = new System.Drawing.Point(303, 19);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.Size = new System.Drawing.Size(70, 20);
            this.tbBottom.TabIndex = 6;
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(78, 46);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(70, 20);
            this.tbLeft.TabIndex = 5;
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(78, 19);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(70, 20);
            this.tbTop.TabIndex = 4;
            // 
            // cbRightType
            // 
            this.cbRightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRightType.FormattingEnabled = true;
            this.cbRightType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbRightType.Location = new System.Drawing.Point(379, 46);
            this.cbRightType.Name = "cbRightType";
            this.cbRightType.Size = new System.Drawing.Size(63, 21);
            this.cbRightType.TabIndex = 3;
            // 
            // cbBottomType
            // 
            this.cbBottomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBottomType.FormattingEnabled = true;
            this.cbBottomType.Items.AddRange(new object[] {
            "px",
            "%",
            "pt",
            "pc",
            "mm",
            "cm",
            "in",
            "em",
            "ex"});
            this.cbBottomType.Location = new System.Drawing.Point(379, 19);
            this.cbBottomType.Name = "cbBottomType";
            this.cbBottomType.Size = new System.Drawing.Size(63, 21);
            this.cbBottomType.TabIndex = 2;
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
            this.cbLeftType.Location = new System.Drawing.Point(154, 46);
            this.cbLeftType.Name = "cbLeftType";
            this.cbLeftType.Size = new System.Drawing.Size(63, 21);
            this.cbLeftType.TabIndex = 1;
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
            this.cbTopType.Location = new System.Drawing.Point(154, 19);
            this.cbTopType.Name = "cbTopType";
            this.cbTopType.Size = new System.Drawing.Size(63, 21);
            this.cbTopType.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Overflow:";
            // 
            // cbOverflow
            // 
            this.cbOverflow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOverflow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOverflow.FormattingEnabled = true;
            this.cbOverflow.Location = new System.Drawing.Point(114, 19);
            this.cbOverflow.Name = "cbOverflow";
            this.cbOverflow.Size = new System.Drawing.Size(334, 21);
            this.cbOverflow.TabIndex = 0;
            // 
            // gbPageBreaks
            // 
            this.gbPageBreaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPageBreaks.Controls.Add(this.lAfter);
            this.gbPageBreaks.Controls.Add(this.lBefore);
            this.gbPageBreaks.Controls.Add(this.cbPbAfter);
            this.gbPageBreaks.Controls.Add(this.cbPbBefore);
            this.gbPageBreaks.Location = new System.Drawing.Point(3, 306);
            this.gbPageBreaks.Name = "gbPageBreaks";
            this.gbPageBreaks.Size = new System.Drawing.Size(454, 78);
            this.gbPageBreaks.TabIndex = 3;
            this.gbPageBreaks.TabStop = false;
            this.gbPageBreaks.Text = "Printing page breaks";
            // 
            // lAfter
            // 
            this.lAfter.AutoSize = true;
            this.lAfter.Location = new System.Drawing.Point(6, 49);
            this.lAfter.Name = "lAfter";
            this.lAfter.Size = new System.Drawing.Size(29, 13);
            this.lAfter.TabIndex = 3;
            this.lAfter.Text = "&After";
            // 
            // lBefore
            // 
            this.lBefore.AutoSize = true;
            this.lBefore.Location = new System.Drawing.Point(6, 22);
            this.lBefore.Name = "lBefore";
            this.lBefore.Size = new System.Drawing.Size(41, 13);
            this.lBefore.TabIndex = 2;
            this.lBefore.Text = "B&efore:";
            // 
            // cbPbAfter
            // 
            this.cbPbAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPbAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPbAfter.FormattingEnabled = true;
            this.cbPbAfter.Location = new System.Drawing.Point(114, 46);
            this.cbPbAfter.Name = "cbPbAfter";
            this.cbPbAfter.Size = new System.Drawing.Size(334, 21);
            this.cbPbAfter.TabIndex = 1;
            // 
            // cbPbBefore
            // 
            this.cbPbBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPbBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPbBefore.FormattingEnabled = true;
            this.cbPbBefore.Location = new System.Drawing.Point(114, 19);
            this.cbPbBefore.Name = "cbPbBefore";
            this.cbPbBefore.Size = new System.Drawing.Size(334, 21);
            this.cbPbBefore.TabIndex = 0;
            // 
            // ucLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPageBreaks);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.cbAllowFloatingObject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAllowTextToFlow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDisplay);
            this.Controls.Add(this.lDisplay);
            this.Controls.Add(this.cbVisibility);
            this.Controls.Add(this.lVisibility);
            this.Name = "ucLayout";
            this.Size = new System.Drawing.Size(460, 387);
            this.Load += new System.EventHandler(this.ucLayout_Load);
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.gbClipping.ResumeLayout(false);
            this.gbClipping.PerformLayout();
            this.gbPageBreaks.ResumeLayout(false);
            this.gbPageBreaks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lVisibility;
        private ComboBox cbVisibility;
        private Label lDisplay;
        private ComboBox cbDisplay;
        private Label label3;
        private ComboBox cbAllowTextToFlow;
        private Label label4;
        private ComboBox cbAllowFloatingObject;
        private GroupBox gbContent;
        private GroupBox gbClipping;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tbRight;
        private TextBox tbBottom;
        private TextBox tbLeft;
        private TextBox tbTop;
        private ComboBox cbRightType;
        private ComboBox cbBottomType;
        private ComboBox cbLeftType;
        private ComboBox cbTopType;
        private Label label5;
        private ComboBox cbOverflow;
        private GroupBox gbPageBreaks;
        private Label lAfter;
        private Label lBefore;
        private ComboBox cbPbAfter;
        private ComboBox cbPbBefore;
    }
}
