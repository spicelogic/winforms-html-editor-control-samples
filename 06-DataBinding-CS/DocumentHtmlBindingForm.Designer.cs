using SpiceLogic.HtmlEditor.WinForms;

namespace DataBinding
{
    partial class DocumentHtmlBindingForm
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
            this.components = new System.ComponentModel.Container();
            this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._editor = new WinFormHtmlEditor();
            this._grid = new System.Windows.Forms.DataGridView();
            this._navigator = new System.Windows.Forms.BindingNavigator(this._bindingSource);
            this._saveButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._navigator)).BeginInit();
            this._navigator.SuspendLayout();
            this.SuspendLayout();
            //
            // _editor
            //
            this._editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editor.EditorContextMenuStrip = null;
            this._editor.Location = new System.Drawing.Point(0, 225);
            this._editor.Name = "_editor";
            this._editor.Size = new System.Drawing.Size(1000, 475);
            this._editor.TabIndex = 2;
            this._editor.ToolbarContextMenuStrip = null;
            //
            // _grid
            //
            this._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.DataSource = this._bindingSource;
            this._grid.Dock = System.Windows.Forms.DockStyle.Top;
            this._grid.Location = new System.Drawing.Point(0, 25);
            this._grid.Name = "_grid";
            this._grid.Size = new System.Drawing.Size(1000, 200);
            this._grid.TabIndex = 1;
            //
            // _navigator
            //
            this._navigator.BindingSource = this._bindingSource;
            this._navigator.Dock = System.Windows.Forms.DockStyle.Top;
            this._navigator.Items.Add(this._saveButton);
            this._navigator.Location = new System.Drawing.Point(0, 0);
            this._navigator.Name = "_navigator";
            this._navigator.Size = new System.Drawing.Size(1000, 25);
            this._navigator.TabIndex = 0;
            //
            // _saveButton
            //
            this._saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(63, 22);
            this._saveButton.Text = "Save data";
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            //
            // DocumentHtmlBindingForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this._editor);
            this.Controls.Add(this._grid);
            this.Controls.Add(this._navigator);
            this.Name = "DocumentHtmlBindingForm";
            this.Text = "DocumentHtml binding demo";
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._navigator)).EndInit();
            this._navigator.ResumeLayout(false);
            this._navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource _bindingSource;
        private WinFormHtmlEditor _editor;
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.BindingNavigator _navigator;
        private System.Windows.Forms.ToolStripButton _saveButton;
    }
}
