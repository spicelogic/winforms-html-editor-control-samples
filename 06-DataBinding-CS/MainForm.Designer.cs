namespace DataBinding
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this._documentHtmlButton = new System.Windows.Forms.Button();
            this._bodyHtmlButton = new System.Windows.Forms.Button();
            this._instructions = new System.Windows.Forms.Label();
            this._description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // _documentHtmlButton
            //
            this._documentHtmlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._documentHtmlButton.Location = new System.Drawing.Point(15, 165);
            this._documentHtmlButton.Name = "_documentHtmlButton";
            this._documentHtmlButton.Size = new System.Drawing.Size(594, 40);
            this._documentHtmlButton.TabIndex = 1;
            this._documentHtmlButton.Text = "DocumentHtml binding - bind the full document HTML, including head and body";
            this._documentHtmlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._documentHtmlButton.UseVisualStyleBackColor = true;
            this._documentHtmlButton.Click += new System.EventHandler(this.OnDocumentHtmlButtonClick);
            //
            // _bodyHtmlButton
            //
            this._bodyHtmlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._bodyHtmlButton.Location = new System.Drawing.Point(15, 125);
            this._bodyHtmlButton.Name = "_bodyHtmlButton";
            this._bodyHtmlButton.Size = new System.Drawing.Size(594, 40);
            this._bodyHtmlButton.TabIndex = 0;
            this._bodyHtmlButton.Text = "BodyHtml binding - bind editor content via the BodyHtml property";
            this._bodyHtmlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bodyHtmlButton.UseVisualStyleBackColor = true;
            this._bodyHtmlButton.Click += new System.EventHandler(this.OnBodyHtmlButtonClick);
            //
            // _instructions
            //
            this._instructions.Dock = System.Windows.Forms.DockStyle.Top;
            this._instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._instructions.Location = new System.Drawing.Point(15, 95);
            this._instructions.Name = "_instructions";
            this._instructions.Size = new System.Drawing.Size(594, 30);
            this._instructions.TabIndex = 2;
            this._instructions.Text = "Choose a binding scenario:";
            //
            // _description
            //
            this._description.Dock = System.Windows.Forms.DockStyle.Top;
            this._description.Location = new System.Drawing.Point(15, 15);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(594, 80);
            this._description.TabIndex = 3;
            this._description.Text = "The WinForms HTML editor supports standard WinForms data binding for both the Body" +
    "Html and DocumentHtml properties, so you can bind editor content to a list, a Dat" +
    "aSet, or a business object through a BindingSource - the same way you would bind " +
    "any other control.";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            // Docked controls stack from the last one added (outermost) to the first
            // (innermost), so this order puts the description at the very top and the
            // buttons below it.
            this.Controls.Add(this._documentHtmlButton);
            this.Controls.Add(this._bodyHtmlButton);
            this.Controls.Add(this._instructions);
            this.Controls.Add(this._description);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiceLogic WinForms HTML editor - data binding";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button _documentHtmlButton;
        private System.Windows.Forms.Button _bodyHtmlButton;
        private System.Windows.Forms.Label _instructions;
        private System.Windows.Forms.Label _description;
    }
}
