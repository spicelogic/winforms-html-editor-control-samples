using System.ComponentModel;
using System.Windows.Forms;

namespace CustomDialog.Dialogs
{
    partial class SearchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkMatchWholeWordOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDirectionDown = new System.Windows.Forms.RadioButton();
            this.rdoDirectionUp = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplaceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(14, 104);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chkMatchCase.TabIndex = 3;
            this.chkMatchCase.Text = "Match &case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkMatchWholeWordOnly
            // 
            this.chkMatchWholeWordOnly.AutoSize = true;
            this.chkMatchWholeWordOnly.Location = new System.Drawing.Point(14, 78);
            this.chkMatchWholeWordOnly.Name = "chkMatchWholeWordOnly";
            this.chkMatchWholeWordOnly.Size = new System.Drawing.Size(135, 17);
            this.chkMatchWholeWordOnly.TabIndex = 2;
            this.chkMatchWholeWordOnly.Text = "Match &whole word only";
            this.chkMatchWholeWordOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDirectionDown);
            this.groupBox1.Controls.Add(this.rdoDirectionUp);
            this.groupBox1.Location = new System.Drawing.Point(170, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdoDirectionDown
            // 
            this.rdoDirectionDown.AutoSize = true;
            this.rdoDirectionDown.Checked = true;
            this.rdoDirectionDown.Location = new System.Drawing.Point(51, 19);
            this.rdoDirectionDown.Name = "rdoDirectionDown";
            this.rdoDirectionDown.Size = new System.Drawing.Size(53, 17);
            this.rdoDirectionDown.TabIndex = 1;
            this.rdoDirectionDown.TabStop = true;
            this.rdoDirectionDown.Text = "&Down";
            this.rdoDirectionDown.UseVisualStyleBackColor = true;
            // 
            // rdoDirectionUp
            // 
            this.rdoDirectionUp.AutoSize = true;
            this.rdoDirectionUp.Location = new System.Drawing.Point(6, 19);
            this.rdoDirectionUp.Name = "rdoDirectionUp";
            this.rdoDirectionUp.Size = new System.Drawing.Size(39, 17);
            this.rdoDirectionUp.TabIndex = 0;
            this.rdoDirectionUp.TabStop = true;
            this.rdoDirectionUp.Text = "&Up";
            this.rdoDirectionUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(420, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.AutoSize = true;
            this.btnFindNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindNext.Location = new System.Drawing.Point(420, 13);
            this.btnFindNext.MinimumSize = new System.Drawing.Size(90, 23);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnFindNext.Size = new System.Drawing.Size(90, 23);
            this.btnFindNext.TabIndex = 5;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(105, 14);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(300, 20);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fi&nd What:";
            // 
            // txtReplaceBox
            // 
            this.txtReplaceBox.Location = new System.Drawing.Point(105, 43);
            this.txtReplaceBox.Name = "txtReplaceBox";
            this.txtReplaceBox.Size = new System.Drawing.Size(300, 20);
            this.txtReplaceBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Re&place With:";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.AutoSize = true;
            this.btnReplaceAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReplaceAll.Location = new System.Drawing.Point(420, 73);
            this.btnReplaceAll.MinimumSize = new System.Drawing.Size(90, 23);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnReplaceAll.Size = new System.Drawing.Size(90, 23);
            this.btnReplaceAll.TabIndex = 7;
            this.btnReplaceAll.Text = "Replace &All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.AutoSize = true;
            this.btnReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReplace.Location = new System.Drawing.Point(420, 43);
            this.btnReplace.MinimumSize = new System.Drawing.Size(90, 23);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnReplace.Size = new System.Drawing.Size(90, 23);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // SearchWindow
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(525, 139);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplaceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.chkMatchWholeWordOnly);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchWindow_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.SearchWindow_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkMatchCase;
        private CheckBox chkMatchWholeWordOnly;
        private GroupBox groupBox1;
        private RadioButton rdoDirectionDown;
        private RadioButton rdoDirectionUp;
        private Button btnCancel;
        private Button btnFindNext;
        private TextBox txtSearchBox;
        private Label label1;
        private TextBox txtReplaceBox;
        private Label label2;
        private Button btnReplaceAll;
        private Button btnReplace;
    }
}