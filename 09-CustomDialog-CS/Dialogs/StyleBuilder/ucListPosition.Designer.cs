using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucListPosition
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
            this.gbBullets = new System.Windows.Forms.GroupBox();
            this.lPosition = new System.Windows.Forms.Label();
            this.cbBulletPosition = new System.Windows.Forms.ComboBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.gbBullets.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBullets
            // 
            this.gbBullets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBullets.Controls.Add(this.lPosition);
            this.gbBullets.Controls.Add(this.cbBulletPosition);
            this.gbBullets.Location = new System.Drawing.Point(3, 3);
            this.gbBullets.Name = "gbBullets";
            this.gbBullets.Size = new System.Drawing.Size(454, 54);
            this.gbBullets.TabIndex = 2;
            this.gbBullets.TabStop = false;
            this.gbBullets.Text = "Bullets";
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(6, 23);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(44, 13);
            this.lPosition.TabIndex = 8;
            this.lPosition.Text = "&Position";
            // 
            // cbBulletPosition
            // 
            this.cbBulletPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBulletPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBulletPosition.FormattingEnabled = true;
            this.cbBulletPosition.Location = new System.Drawing.Point(112, 20);
            this.cbBulletPosition.Name = "cbBulletPosition";
            this.cbBulletPosition.Size = new System.Drawing.Size(285, 21);
            this.cbBulletPosition.TabIndex = 1;
            // 
            // ucListPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBullets);
            this.Name = "ucListPosition";
            this.Size = new System.Drawing.Size(460, 219);
            this.Load += new System.EventHandler(this.ucLists_Load);
            this.gbBullets.ResumeLayout(false);
            this.gbBullets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBullets;
        private ComboBox cbBulletPosition;
        private Label lPosition;
        private OpenFileDialog dlgOpen;
    }
}
