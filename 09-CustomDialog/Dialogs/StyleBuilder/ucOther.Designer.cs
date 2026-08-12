using System.ComponentModel;
using System.Windows.Forms;

using CustomDialog.Dialogs;
namespace CustomDialog.Dialogs.StyleBuilder
{
    public partial class ucOther
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
            this.gbUserInterface = new System.Windows.Forms.GroupBox();
            this.lCursor = new System.Windows.Forms.Label();
            this.cbCursor = new System.Windows.Forms.ComboBox();
            this.gbTables = new System.Windows.Forms.GroupBox();
            this.scBordersLayout = new System.Windows.Forms.SplitContainer();
            this.lBorders = new System.Windows.Forms.Label();
            this.cbBorders = new System.Windows.Forms.ComboBox();
            this.lLayout = new System.Windows.Forms.Label();
            this.cbLayout = new System.Windows.Forms.ComboBox();
            this.gbVisualEffects = new System.Windows.Forms.GroupBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lFilter = new System.Windows.Forms.Label();
            this.gbBehavior = new System.Windows.Forms.GroupBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lURL = new System.Windows.Forms.Label();
            this.gbUserInterface.SuspendLayout();
            this.gbTables.SuspendLayout();
            this.scBordersLayout.Panel1.SuspendLayout();
            this.scBordersLayout.Panel2.SuspendLayout();
            this.scBordersLayout.SuspendLayout();
            this.gbVisualEffects.SuspendLayout();
            this.gbBehavior.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInterface
            // 
            this.gbUserInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserInterface.Controls.Add(this.cbCursor);
            this.gbUserInterface.Controls.Add(this.lCursor);
            this.gbUserInterface.Location = new System.Drawing.Point(3, 3);
            this.gbUserInterface.Name = "gbUserInterface";
            this.gbUserInterface.Size = new System.Drawing.Size(454, 65);
            this.gbUserInterface.TabIndex = 0;
            this.gbUserInterface.TabStop = false;
            this.gbUserInterface.Text = "User interface";
            // 
            // lCursor
            // 
            this.lCursor.AutoSize = true;
            this.lCursor.Location = new System.Drawing.Point(6, 16);
            this.lCursor.Name = "lCursor";
            this.lCursor.Size = new System.Drawing.Size(40, 13);
            this.lCursor.TabIndex = 0;
            this.lCursor.Text = "&Cursor:";
            // 
            // cbCursor
            // 
            this.cbCursor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCursor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCursor.FormattingEnabled = true;
            this.cbCursor.Location = new System.Drawing.Point(6, 32);
            this.cbCursor.Name = "cbCursor";
            this.cbCursor.Size = new System.Drawing.Size(442, 21);
            this.cbCursor.TabIndex = 1;
            // 
            // gbTables
            // 
            this.gbTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTables.Controls.Add(this.scBordersLayout);
            this.gbTables.Location = new System.Drawing.Point(3, 74);
            this.gbTables.Name = "gbTables";
            this.gbTables.Size = new System.Drawing.Size(454, 74);
            this.gbTables.TabIndex = 1;
            this.gbTables.TabStop = false;
            this.gbTables.Text = "Tables";
            // 
            // scBordersLayout
            // 
            this.scBordersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBordersLayout.Location = new System.Drawing.Point(3, 16);
            this.scBordersLayout.Name = "scBordersLayout";
            // 
            // scBordersLayout.Panel1
            // 
            this.scBordersLayout.Panel1.Controls.Add(this.cbBorders);
            this.scBordersLayout.Panel1.Controls.Add(this.lBorders);
            // 
            // scBordersLayout.Panel2
            // 
            this.scBordersLayout.Panel2.Controls.Add(this.cbLayout);
            this.scBordersLayout.Panel2.Controls.Add(this.lLayout);
            this.scBordersLayout.Size = new System.Drawing.Size(448, 55);
            this.scBordersLayout.SplitterDistance = 224;
            this.scBordersLayout.SplitterWidth = 1;
            this.scBordersLayout.TabIndex = 0;
            // 
            // lBorders
            // 
            this.lBorders.AutoSize = true;
            this.lBorders.Location = new System.Drawing.Point(3, 1);
            this.lBorders.Name = "lBorders";
            this.lBorders.Size = new System.Drawing.Size(46, 13);
            this.lBorders.TabIndex = 0;
            this.lBorders.Text = "&Borders:";
            // 
            // cbBorders
            // 
            this.cbBorders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorders.FormattingEnabled = true;
            this.cbBorders.Location = new System.Drawing.Point(3, 18);
            this.cbBorders.Name = "cbBorders";
            this.cbBorders.Size = new System.Drawing.Size(218, 21);
            this.cbBorders.TabIndex = 1;
            // 
            // lLayout
            // 
            this.lLayout.AutoSize = true;
            this.lLayout.Location = new System.Drawing.Point(3, 1);
            this.lLayout.Name = "lLayout";
            this.lLayout.Size = new System.Drawing.Size(42, 13);
            this.lLayout.TabIndex = 0;
            this.lLayout.Text = "&Layout:";
            // 
            // cbLayout
            // 
            this.cbLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayout.FormattingEnabled = true;
            this.cbLayout.Location = new System.Drawing.Point(6, 18);
            this.cbLayout.Name = "cbLayout";
            this.cbLayout.Size = new System.Drawing.Size(214, 21);
            this.cbLayout.TabIndex = 1;
            // 
            // gbVisualEffects
            // 
            this.gbVisualEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVisualEffects.Controls.Add(this.lFilter);
            this.gbVisualEffects.Controls.Add(this.tbFilter);
            this.gbVisualEffects.Location = new System.Drawing.Point(3, 154);
            this.gbVisualEffects.Name = "gbVisualEffects";
            this.gbVisualEffects.Size = new System.Drawing.Size(454, 54);
            this.gbVisualEffects.TabIndex = 2;
            this.gbVisualEffects.TabStop = false;
            this.gbVisualEffects.Text = "Visual effects";
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(109, 19);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(339, 20);
            this.tbFilter.TabIndex = 0;
            // 
            // lFilter
            // 
            this.lFilter.AutoSize = true;
            this.lFilter.Location = new System.Drawing.Point(6, 22);
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(32, 13);
            this.lFilter.TabIndex = 1;
            this.lFilter.Text = "&Filter:";
            // 
            // gbBehavior
            // 
            this.gbBehavior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBehavior.Controls.Add(this.lURL);
            this.gbBehavior.Controls.Add(this.tbURL);
            this.gbBehavior.Location = new System.Drawing.Point(3, 214);
            this.gbBehavior.Name = "gbBehavior";
            this.gbBehavior.Size = new System.Drawing.Size(454, 55);
            this.gbBehavior.TabIndex = 3;
            this.gbBehavior.TabStop = false;
            this.gbBehavior.Text = "Behavior";
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(109, 19);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(339, 20);
            this.tbURL.TabIndex = 0;
            // 
            // lURL
            // 
            this.lURL.AutoSize = true;
            this.lURL.Location = new System.Drawing.Point(6, 22);
            this.lURL.Name = "lURL";
            this.lURL.Size = new System.Drawing.Size(32, 13);
            this.lURL.TabIndex = 1;
            this.lURL.Text = "&URL:";
            // 
            // ucOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBehavior);
            this.Controls.Add(this.gbVisualEffects);
            this.Controls.Add(this.gbTables);
            this.Controls.Add(this.gbUserInterface);
            this.Name = "ucOther";
            this.Size = new System.Drawing.Size(460, 380);
            this.Load += new System.EventHandler(this.ucOther_Load);
            this.gbUserInterface.ResumeLayout(false);
            this.gbUserInterface.PerformLayout();
            this.gbTables.ResumeLayout(false);
            this.scBordersLayout.Panel1.ResumeLayout(false);
            this.scBordersLayout.Panel1.PerformLayout();
            this.scBordersLayout.Panel2.ResumeLayout(false);
            this.scBordersLayout.Panel2.PerformLayout();
            this.scBordersLayout.ResumeLayout(false);
            this.gbVisualEffects.ResumeLayout(false);
            this.gbVisualEffects.PerformLayout();
            this.gbBehavior.ResumeLayout(false);
            this.gbBehavior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbUserInterface;
        private ComboBox cbCursor;
        private Label lCursor;
        private GroupBox gbTables;
        private SplitContainer scBordersLayout;
        private ComboBox cbBorders;
        private Label lBorders;
        private ComboBox cbLayout;
        private Label lLayout;
        private GroupBox gbVisualEffects;
        private Label lFilter;
        private TextBox tbFilter;
        private GroupBox gbBehavior;
        private Label lURL;
        private TextBox tbURL;
    }
}
