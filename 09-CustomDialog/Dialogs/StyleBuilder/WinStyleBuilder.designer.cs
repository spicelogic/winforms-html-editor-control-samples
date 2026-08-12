using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public sealed partial class WinStyleBuilder
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
            this.lbPage = new System.Windows.Forms.ListBox();
            this.pnlSelectedPage = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.chkRemoveStyle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPage
            // 
            this.lbPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPage.FormattingEnabled = true;
            this.lbPage.Items.AddRange(new object[] {
            "Font",
            "Background",
            "Text",
            "Position",
            "Layout",
            "Edges",
            "List Position",
            "Other"});
            this.lbPage.Location = new System.Drawing.Point(12, 12);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(123, 433);
            this.lbPage.TabIndex = 0;
            this.lbPage.SelectedIndexChanged += new System.EventHandler(this.lbPage_SelectedIndexChanged);
            // 
            // pnlSelectedPage
            // 
            this.pnlSelectedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectedPage.Location = new System.Drawing.Point(141, 12);
            this.pnlSelectedPage.Name = "pnlSelectedPage";
            this.pnlSelectedPage.Size = new System.Drawing.Size(517, 433);
            this.pnlSelectedPage.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(502, 451);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(583, 451);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // chkRemoveStyle
            // 
            this.chkRemoveStyle.AutoSize = true;
            this.chkRemoveStyle.Location = new System.Drawing.Point(13, 456);
            this.chkRemoveStyle.Name = "chkRemoveStyle";
            this.chkRemoveStyle.Size = new System.Drawing.Size(278, 17);
            this.chkRemoveStyle.TabIndex = 4;
            this.chkRemoveStyle.Text = "Remove Style (Return Empty String for Style Attribute)";
            this.chkRemoveStyle.UseVisualStyleBackColor = true;
            // 
            // WinStyleBuilder
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(670, 486);
            this.ControlBox = false;
            this.Controls.Add(this.chkRemoveStyle);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.pnlSelectedPage);
            this.Controls.Add(this.lbPage);
            this.Name = "WinStyleBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Style Builder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFontSelector_FormClosed);
            this.Load += new System.EventHandler(this.frmFontSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbPage;
        private Panel pnlSelectedPage;
        private Button btOk;
        private Button btCancel;
        private CheckBox chkRemoveStyle;
    }
}